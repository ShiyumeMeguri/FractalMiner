using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGWindSimpleManager // TypeDefIndex: 37713
	{
		// Fields
		private const int MAX_WIND_MOTOR_COUNT = 4; // Metadata: 0x0230307B
		private float m_cleanupTimer; // 0x10
		private const float CLEANUP_INTERVAL = 60f; // Metadata: 0x0230307C
		private HGWindFootMotor[] m_windFootMotors; // 0x18
		private List<HGWindMotor> m_windMotors; // 0x20
		private Dictionary<int, HGMainWindState> m_windMainState; // 0x28
		private List<HGWindMotorState> m_windMotorState; // 0x30
		private List<int> m_validCameraIds; // 0x38
		private List<int> m_keysToRemove; // 0x40
		public HGWindParamDataCache m_windParamDataCache; // 0x48
	
		// Nested types
		public struct HGWindFootMotor // TypeDefIndex: 37709
		{
			// Fields
			public float range; // 0x00
			public Vector3 position; // 0x04
		}
	
		public class HGMainWindState // TypeDefIndex: 37710
		{
			// Fields
			public float lastIntensity; // 0x10
			public Vector3 lastDirection; // 0x14
			public Vector2 lastNoiseUV; // 0x20
			public float lastWindTime; // 0x28
			public Vector2 curNoiseUV; // 0x2C
			public float curWindTime; // 0x34
	
			// Constructors
			public HGMainWindState() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		public class HGWindMotorState // TypeDefIndex: 37711
		{
			// Fields
			public HGWindMotorData lastData; // 0x10
			public float lastWindTime; // 0x44
			public Vector2 lastDirection; // 0x48
			public Vector3 lastPosition; // 0x50
			public float curWindTime; // 0x5C
	
			// Constructors
			public HGWindMotorState() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		// Constructors
		public HGWindSimpleManager() {} // 0x0000000182ED7BA0-0x0000000182ED7D30
		// HGWindSimpleManager()
		void HG::Rendering::Runtime::HGWindSimpleManager::HGWindSimpleManager(HGWindSimpleManager *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v9; // rdi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Dictionary_2_System_Int32_System_Object_ *v13; // rax
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *v14; // rdi
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v18; // rax
		  List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *v19; // rdi
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v23; // rax
		  List_1_System_Int32_ *v24; // rdi
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v28; // rax
		  List_1_System_Int32_ *v29; // rdi
		  HGRuntimeGrassQuery_Node *v30; // rdx
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  MethodInfo *v33; // [rsp+20h] [rbp-8h]
		  MethodInfo *v34; // [rsp+20h] [rbp-8h]
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_windFootMotors = (HGWindSimpleManager_HGWindFootMotor__Array *)il2cpp_array_new_specific_1(
		                                                                                  TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindFootMotor,
		                                                                                  4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_windFootMotors, v3, v4, v5, v33);
		  v6 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>);
		  v9 = (List_1_HG_Rendering_Runtime_HGWindMotor_ *)v6;
		  if ( !v6 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v6,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::List);
		  this->fields.m_windMotors = v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_windMotors, v10, v11, v12, v34);
		  v13 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>);
		  v14 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *)v13;
		  if ( !v13 )
		    goto LABEL_2;
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v13,
		    MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Dictionary);
		  this->fields.m_windMainState = v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_windMainState, v15, v16, v17, v35);
		  v18 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>);
		  v19 = (List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *)v18;
		  if ( !v18 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v18,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::List);
		  this->fields.m_windMotorState = v19;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_windMotorState, v20, v21, v22, v36);
		  sub_18033B9D0(&this->fields.m_windParamDataCache, 0LL, 300LL);
		  v23 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  v24 = (List_1_System_Int32_ *)v23;
		  if ( !v23
		    || (System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v23,
		          MethodInfo::System::Collections::Generic::List<int>::List),
		        this->fields.m_validCameraIds = v24,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_validCameraIds, v25, v26, v27, v37),
		        v28 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>),
		        (v29 = (List_1_System_Int32_ *)v28) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v8, v7);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v28,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_keysToRemove = v29;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_keysToRemove, v30, v31, v32, v38);
		  this->fields.m_cleanupTimer = 0.0;
		  if ( !TypeInfo::Beyond::DeviceInfo->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::Beyond::DeviceInfo);
		  if ( Beyond::DeviceInfo::get_isMobile(0LL) )
		  {
		    LOWORD(this[2].fields.m_windParamDataCache._WindMotorParams2.FixedElementField) = 257;
		    this[2].fields.m_windParamDataCache._WindMotorParams0.FixedElementField = 40.0;
		    this[2].fields.m_windParamDataCache._WindMotorParams1.FixedElementField = 20.0;
		  }
		  else
		  {
		    LOWORD(this[2].fields.m_windParamDataCache._WindMotorParams2.FixedElementField) = 514;
		    this[2].fields.m_windParamDataCache._WindMotorParams0.FixedElementField = 60.0;
		    this[2].fields.m_windParamDataCache._WindMotorParams1.FixedElementField = 30.0;
		  }
		}
		
	
		// Methods
		public void SetWindFootMotor(int index, Vector3 position, float range) {} // 0x000000018323D810-0x000000018323D8C0
		// Void SetWindFootMotor(Int32, Vector3, Single)
		void HG::Rendering::Runtime::HGWindSimpleManager::SetWindFootMotor(
		        HGWindSimpleManager *this,
		        int32_t index,
		        Vector3 *position,
		        float range,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  __int64 v8; // rbx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGWindSimpleManager_HGWindFootMotor__Array *m_windFootMotors; // rax
		  HGWindSimpleManager_HGWindFootMotor *v11; // rcx
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // xmm0_8
		  Vector3 v15; // [rsp+30h] [rbp-28h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v8 = index;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size > 1695 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_10;
		    if ( wrapperArray->max_length.size <= 0x69Fu )
		LABEL_11:
		      sub_1800D2AB0(v6, wrapperArray);
		    if ( wrapperArray[47].vector[3] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1695, 0LL);
		      if ( Patch )
		      {
		        v14 = *(_QWORD *)&position->x;
		        v15.z = position->z;
		        *(_QWORD *)&v15.x = v14;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_681(Patch, (Object *)this, v8, &v15, range, 0LL);
		        return;
		      }
		      goto LABEL_10;
		    }
		  }
		  if ( (unsigned int)v8 > 3 )
		    return;
		  m_windFootMotors = this->fields.m_windFootMotors;
		  if ( !m_windFootMotors )
		LABEL_10:
		    sub_1800D8260(v6, wrapperArray);
		  if ( (unsigned int)v8 >= m_windFootMotors->max_length.size )
		    goto LABEL_11;
		  v11 = &m_windFootMotors->vector[v8];
		  z = position->z;
		  *(_QWORD *)&v11->position.x = *(_QWORD *)&position->x;
		  v11->position.z = z;
		  v11->range = range;
		}
		
		public void RegisterWindMotor(HGWindMotor wind) {} // 0x00000001847740E0-0x00000001847741D0
		// Void RegisterWindMotor(HGWindMotor)
		void HG::Rendering::Runtime::HGWindSimpleManager::RegisterWindMotor(
		        HGWindSimpleManager *this,
		        HGWindMotor *wind,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *v6; // rcx
		  int32_t windPriority; // ebp
		  int32_t i; // esi
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
		  List_1_System_Object_ *v10; // rcx
		  List_1_System_Object_ *v11; // rbx
		  Object *v12; // rax
		  Object *Item; // rax
		  List_1_System_Object_ *m_windMotorState; // rbx
		  Object *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1698, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1698, 0LL);
		    if ( !Patch )
		      goto LABEL_5;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)wind,
		      0LL);
		  }
		  else if ( this->fields.m_windMotors
		         && !System::Collections::Generic::List<System::Object>::Contains(
		               (List_1_System_Object_ *)this->fields.m_windMotors,
		               (Object *)wind,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Contains) )
		  {
		    if ( !wind )
		      goto LABEL_5;
		    windPriority = wind->fields.data.windPriority;
		    for ( i = 0; ; ++i )
		    {
		      m_windMotors = this->fields.m_windMotors;
		      if ( !m_windMotors )
		        goto LABEL_5;
		      v10 = (List_1_System_Object_ *)this->fields.m_windMotors;
		      if ( i >= m_windMotors->fields._size )
		        break;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               v10,
		               i,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Item);
		      if ( !Item )
		        goto LABEL_5;
		      if ( SLODWORD(Item[2].klass) < windPriority )
		      {
		        v6 = (List_1_System_Object_ *)this->fields.m_windMotors;
		        if ( v6 )
		        {
		          System::Collections::Generic::List<System::Object>::Insert(
		            v6,
		            i,
		            (Object *)wind,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Insert);
		          m_windMotorState = (List_1_System_Object_ *)this->fields.m_windMotorState;
		          v15 = (Object *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
		          if ( v15 )
		          {
		            if ( m_windMotorState )
		            {
		              System::Collections::Generic::List<System::Object>::Insert(
		                m_windMotorState,
		                i,
		                v15,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Insert);
		              return;
		            }
		          }
		        }
		LABEL_5:
		        sub_1800D8260(v6, v5);
		      }
		    }
		    sub_182F01190(v10, (Object *)wind);
		    v11 = (List_1_System_Object_ *)this->fields.m_windMotorState;
		    v12 = (Object *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
		    if ( !v12 || !v11 )
		      goto LABEL_5;
		    sub_182F01190(v11, v12);
		  }
		}
		
		public void UnRegisterWindMotor(HGWindMotor wind) {} // 0x0000000184773F80-0x0000000184774020
		// Void UnRegisterWindMotor(HGWindMotor)
		void HG::Rendering::Runtime::HGWindSimpleManager::UnRegisterWindMotor(
		        HGWindSimpleManager *this,
		        HGWindMotor *wind,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_windMotors; // rcx
		  int32_t v7; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1700, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1700, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)wind,
		      0LL);
		  }
		  else if ( this->fields.m_windMotors
		         && System::Collections::Generic::List<System::Object>::Contains(
		              (List_1_System_Object_ *)this->fields.m_windMotors,
		              (Object *)wind,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Contains) )
		  {
		    m_windMotors = (List_1_System_Object_ *)this->fields.m_windMotors;
		    if ( !m_windMotors )
		      goto LABEL_8;
		    v7 = System::Collections::Generic::List<System::Object>::IndexOf(
		           m_windMotors,
		           (Object *)wind,
		           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::IndexOf);
		    if ( this->fields.m_windMotorState )
		      System::Collections::Generic::List<System::Object>::RemoveAt(
		        (List_1_System_Object_ *)this->fields.m_windMotorState,
		        v7,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::RemoveAt);
		    m_windMotors = (List_1_System_Object_ *)this->fields.m_windMotors;
		    if ( !m_windMotors )
		LABEL_8:
		      sub_1800D8260(m_windMotors, v5);
		    System::Collections::Generic::List<System::Object>::Remove(
		      m_windMotors,
		      (Object *)wind,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Remove);
		  }
		}
		
		public void GamePlayUpdate(float deltaTime) {} // 0x00000001832DEAC0-0x00000001832DF740
		// Void GamePlayUpdate(Single)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGWindSimpleManager::GamePlayUpdate(
		        HGWindSimpleManager *this,
		        float deltaTime,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  float v4; // xmm2_4
		  HGWindSimpleManager *v5; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  unsigned int i; // edi
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rbx
		  HGWindMotor__Array *items; // rbx
		  HGWindMotor *v15; // rax
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v16; // rbx
		  HGWindMotor__Array *v17; // rbx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v18; // rbx
		  HGWindMotor__Array *v19; // rbx
		  HGWindMotor *v20; // r14
		  __int64 (__fastcall *v21)(HGWindMotor *, __int64, MethodInfo *); // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // rbx
		  void (__fastcall *v25)(__int64, __int64 *); // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v28; // rbx
		  HGWindMotor__Array *v29; // rbx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v30; // rbx
		  HGWindMotor__Array *v31; // rbx
		  HGWindMotor *v32; // rbx
		  __int64 (__fastcall *v33)(HGWindMotor *); // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __int64 v36; // rbx
		  void (__fastcall *v37)(__int64, __int64 *); // rax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v40; // rbx
		  HGWindMotor__Array *v41; // rbx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v42; // rbx
		  HGWindMotor__Array *v43; // rbx
		  HGWindMotor *v44; // rbx
		  __int64 (__fastcall *v45)(HGWindMotor *); // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  __int64 v48; // rbx
		  void (__fastcall *v49)(__int64, MethodInfo **); // rax
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v50; // rbx
		  HGWindMotor__Array *v51; // rbx
		  HGWindMotor *v52; // rax
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v53; // rbx
		  HGWindMotor__Array *v54; // rbx
		  HGWindMotor *v55; // rbx
		  __int64 (__fastcall *v56)(HGWindMotor *, __int64, MethodInfo *); // rax
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  __int64 v59; // rbx
		  void (__fastcall *v60)(__int64, __int64 *); // rax
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v63; // rbx
		  HGWindMotor__Array *v64; // rbx
		  HGWindMotor *v65; // rbx
		  __int64 (__fastcall *v66)(HGWindMotor *); // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  __int64 v69; // rbx
		  float v70; // xmm6_4
		  void (__fastcall *v71)(__int64, Vector3 *); // rax
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v72; // rbx
		  HGWindMotor__Array *v73; // rbx
		  HGWindMotor *v74; // rax
		  unsigned int v75; // r14d
		  float gameplayTime; // xmm10_4
		  HGRuntimeGrassQuery_Node *v77; // rdx
		  __int64 v78; // rcx
		  HGRuntimeGrassQuery_Node *v79; // r8
		  Int32__Array **v80; // r9
		  float v81; // xmm10_4
		  float v82; // xmm0_4
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rbx
		  __int64 *v84; // rdx
		  __int64 v85; // rcx
		  __int64 v86; // r8
		  float *value; // rbx
		  float v88; // xmm6_4
		  float v89; // xmm7_4
		  float v90; // xmm8_4
		  __int64 v91; // xmm9_8
		  float v92; // edi
		  struct ILFixDynamicMethodWrapper_2__Class *v93; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v94; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v95; // rcx
		  ILFixDynamicMethodWrapper_2 *v96; // rcx
		  Beyond::JobMathf *v97; // rcx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v98; // rax
		  unsigned __int32 v99; // xmm9_4
		  List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *m_windMotorState; // rax
		  HGWindSimpleManager_HGWindMotorState__Array *v101; // rbx
		  HGWindSimpleManager_HGWindMotorState *v102; // rbx
		  float v103; // xmm6_4
		  float curWindTime; // xmm0_4
		  float v105; // xmm0_4
		  float v106; // xmm0_4
		  float v107; // xmm0_4
		  __int64 v108; // [rsp+0h] [rbp-218h] BYREF
		  MethodInfo *ex; // [rsp+20h] [rbp-1F8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v110; // [rsp+28h] [rbp-1F0h]
		  __int64 v111; // [rsp+30h] [rbp-1E8h] BYREF
		  int v112; // [rsp+38h] [rbp-1E0h]
		  Vector3 v113; // [rsp+40h] [rbp-1D8h] BYREF
		  HGWindMotor *v114; // [rsp+50h] [rbp-1C8h]
		  HGWindMotor *v115; // [rsp+58h] [rbp-1C0h]
		  __int64 v116; // [rsp+60h] [rbp-1B8h] BYREF
		  int v117; // [rsp+68h] [rbp-1B0h]
		  __int64 v118; // [rsp+70h] [rbp-1A8h] BYREF
		  int v119; // [rsp+78h] [rbp-1A0h]
		  HGWindMotor *v120; // [rsp+A8h] [rbp-170h]
		  HGWindMotor *v121; // [rsp+C0h] [rbp-158h]
		  HGWindMotor *v122; // [rsp+D8h] [rbp-140h]
		  HGWindMotor *v123; // [rsp+E8h] [rbp-130h]
		  _BYTE v124[24]; // [rsp+F8h] [rbp-120h] BYREF
		  __int128 v125; // [rsp+110h] [rbp-108h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v126; // [rsp+120h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v127; // [rsp+148h] [rbp-D0h] BYREF
		  HGWindMotor *v129; // [rsp+238h] [rbp+20h]
		  Vector2 v130; // [rsp+238h] [rbp+20h]
		
		  v5 = this;
		  memset(&v126, 0, sizeof(v126));
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v6, v3);
		  if ( wrapperArray->max_length.size <= 1702 )
		    goto LABEL_13;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = v6->static_fields->wrapperArray;
		  if ( !v8 )
		    sub_1800D8260(v6, v3);
		  if ( v8->max_length.size <= 0x6A6u )
		    sub_1800D2AB0(v6, v3);
		  if ( v8[47].vector[10] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1702, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)v5, deltaTime, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    for ( i = 0; ; ++i )
		    {
		      m_windMotors = v5->fields.m_windMotors;
		      if ( !m_windMotors )
		        sub_1800D8260(v6, v3);
		      if ( (signed int)i >= m_windMotors->fields._size )
		        break;
		      if ( i >= m_windMotors->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = m_windMotors->fields._items;
		      if ( !items )
		        sub_1800D8260(v6, v3);
		      if ( i >= items->max_length.size )
		        sub_1800D2AB0(v6, v3);
		      v15 = items->vector[i];
		      if ( !v15 )
		        sub_1800D8260(v6, v3);
		      if ( v15->fields.data.shape == 1 )
		      {
		        v16 = v5->fields.m_windMotors;
		        if ( !v16 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v16->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v17 = v16->fields._items;
		        if ( !v17 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v17->max_length.size )
		          sub_1800D2AB0(v6, v3);
		        v129 = v17->vector[i];
		        if ( !v129 )
		          sub_1800D8260(v6, v3);
		        v18 = v5->fields.m_windMotors;
		        if ( !v18 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v18->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v19 = v18->fields._items;
		        if ( !v19 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v19->max_length.size )
		          sub_1800D2AB0(v6, v3);
		        v20 = v19->vector[i];
		        if ( !v20 )
		          sub_1800D8260(v6, v3);
		        v21 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v21 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))sub_180059EA0("UnityEngine.Component::get_transform()");
		          qword_18F36FBC0 = (__int64)v21;
		        }
		        v24 = v21(v20, v3, method);
		        if ( !v24 )
		          sub_1800D8260(v23, v22);
		        v116 = 0LL;
		        v117 = 0;
		        v25 = (void (__fastcall *)(__int64, __int64 *))qword_18F370130;
		        if ( !qword_18F370130 )
		        {
		          v25 = (void (__fastcall *)(__int64, __int64 *))sub_180059EA0(
		                                                           "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
		          qword_18F370130 = (__int64)v25;
		        }
		        v25(v24, &v116);
		        LODWORD(v129->fields.data.width) = v116;
		        v28 = v5->fields.m_windMotors;
		        if ( !v28 )
		          sub_1800D8260(v27, v26);
		        if ( i >= v28->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v29 = v28->fields._items;
		        if ( !v29 )
		          sub_1800D8260(v27, v26);
		        if ( i >= v29->max_length.size )
		          sub_1800D2AB0(v27, v26);
		        v114 = v29->vector[i];
		        if ( !v114 )
		          sub_1800D8260(v27, v26);
		        v30 = v5->fields.m_windMotors;
		        if ( !v30 )
		          sub_1800D8260(v27, v26);
		        if ( i >= v30->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v31 = v30->fields._items;
		        if ( !v31 )
		          sub_1800D8260(v27, v26);
		        if ( i >= v31->max_length.size )
		          sub_1800D2AB0(v27, v26);
		        v32 = v31->vector[i];
		        v120 = v32;
		        if ( !v32 )
		          sub_1800D8260(v27, v26);
		        v33 = (__int64 (__fastcall *)(HGWindMotor *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v33 = (__int64 (__fastcall *)(HGWindMotor *))sub_180059EA0("UnityEngine.Component::get_transform()");
		          qword_18F36FBC0 = (__int64)v33;
		        }
		        v36 = v33(v32);
		        if ( !v36 )
		          sub_1800D8260(v35, v34);
		        v118 = 0LL;
		        v119 = 0;
		        v37 = (void (__fastcall *)(__int64, __int64 *))qword_18F370130;
		        if ( !qword_18F370130 )
		        {
		          v37 = (void (__fastcall *)(__int64, __int64 *))sub_180059EA0(
		                                                           "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
		          qword_18F370130 = (__int64)v37;
		        }
		        v37(v36, &v118);
		        v114->fields.data.height = *((float *)&v118 + 1);
		        v40 = v5->fields.m_windMotors;
		        if ( !v40 )
		          sub_1800D8260(v39, v38);
		        if ( i >= v40->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v41 = v40->fields._items;
		        if ( !v41 )
		          sub_1800D8260(v39, v38);
		        if ( i >= v41->max_length.size )
		          sub_1800D2AB0(v39, v38);
		        v115 = v41->vector[i];
		        if ( !v115 )
		          sub_1800D8260(v39, v38);
		        v42 = v5->fields.m_windMotors;
		        if ( !v42 )
		          sub_1800D8260(v39, v38);
		        if ( i >= v42->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v43 = v42->fields._items;
		        if ( !v43 )
		          sub_1800D8260(v39, v38);
		        if ( i >= v43->max_length.size )
		          sub_1800D2AB0(v39, v38);
		        v44 = v43->vector[i];
		        v121 = v44;
		        if ( !v44 )
		          sub_1800D8260(v39, v38);
		        v45 = (__int64 (__fastcall *)(HGWindMotor *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v45 = (__int64 (__fastcall *)(HGWindMotor *))sub_180059EA0("UnityEngine.Component::get_transform()");
		          qword_18F36FBC0 = (__int64)v45;
		        }
		        v48 = v45(v44);
		        if ( !v48 )
		          sub_1800D8260(v47, v46);
		        ex = 0LL;
		        LODWORD(v110) = 0;
		        v49 = (void (__fastcall *)(__int64, MethodInfo **))qword_18F370130;
		        if ( !qword_18F370130 )
		        {
		          v49 = (void (__fastcall *)(__int64, MethodInfo **))sub_180059EA0(
		                                                               "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
		          qword_18F370130 = (__int64)v49;
		        }
		        v49(v48, &ex);
		        LODWORD(v115->fields.data.length) = (_DWORD)v110;
		      }
		      v50 = v5->fields.m_windMotors;
		      if ( !v50 )
		        sub_1800D8260(v6, v3);
		      if ( i >= v50->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      v51 = v50->fields._items;
		      if ( !v51 )
		        sub_1800D8260(v6, v3);
		      if ( i >= v51->max_length.size )
		        sub_1800D2AB0(v6, v3);
		      v52 = v51->vector[i];
		      if ( !v52 )
		        sub_1800D8260(v6, v3);
		      if ( !v52->fields.data.shape )
		      {
		        v53 = v5->fields.m_windMotors;
		        if ( !v53 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v53->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v54 = v53->fields._items;
		        if ( !v54 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v54->max_length.size )
		          sub_1800D2AB0(v6, v3);
		        v55 = v54->vector[i];
		        v122 = v55;
		        if ( !v55 )
		          sub_1800D8260(v6, v3);
		        v56 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v56 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))sub_180059EA0("UnityEngine.Component::get_transform()");
		          qword_18F36FBC0 = (__int64)v56;
		        }
		        v59 = v56(v55, v3, method);
		        if ( !v59 )
		          sub_1800D8260(v58, v57);
		        v111 = 0LL;
		        v112 = 0;
		        v60 = (void (__fastcall *)(__int64, __int64 *))qword_18F370130;
		        if ( !qword_18F370130 )
		        {
		          v60 = (void (__fastcall *)(__int64, __int64 *))sub_180059EA0(
		                                                           "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
		          qword_18F370130 = (__int64)v60;
		        }
		        v60(v59, &v111);
		        v63 = v5->fields.m_windMotors;
		        if ( !v63 )
		          sub_1800D8260(v62, v61);
		        if ( i >= v63->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v64 = v63->fields._items;
		        if ( !v64 )
		          sub_1800D8260(v62, v61);
		        if ( i >= v64->max_length.size )
		          sub_1800D2AB0(v62, v61);
		        v65 = v64->vector[i];
		        v123 = v65;
		        if ( !v65 )
		          sub_1800D8260(v62, v61);
		        v66 = (__int64 (__fastcall *)(HGWindMotor *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v66 = (__int64 (__fastcall *)(HGWindMotor *))sub_180059EA0("UnityEngine.Component::get_transform()");
		          qword_18F36FBC0 = (__int64)v66;
		        }
		        v69 = v66(v65);
		        v70 = *((float *)&v111 + 1);
		        if ( !v69 )
		          sub_1800D8260(v68, v67);
		        *(_QWORD *)&v113.x = _mm_unpacklo_ps((__m128)HIDWORD(v111), (__m128)HIDWORD(v111)).m128_u64[0];
		        v113.z = *((float *)&v111 + 1);
		        v71 = (void (__fastcall *)(__int64, Vector3 *))qword_18F370138;
		        if ( !qword_18F370138 )
		        {
		          v71 = (void (__fastcall *)(__int64, Vector3 *))sub_180059EA0(
		                                                           "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		          qword_18F370138 = (__int64)v71;
		        }
		        v71(v69, &v113);
		        v72 = v5->fields.m_windMotors;
		        if ( !v72 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v72->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v73 = v72->fields._items;
		        if ( !v73 )
		          sub_1800D8260(v6, v3);
		        if ( i >= v73->max_length.size )
		          sub_1800D2AB0(v6, v3);
		        v74 = v73->vector[i];
		        if ( !v74 )
		          sub_1800D8260(v6, v3);
		        v74->fields.data.radius = v70;
		      }
		    }
		    v75 = 0;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		    gameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
		    v81 = gameplayTime - HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(0LL);
		    v82 = v5->fields.m_cleanupTimer + v81;
		    v5->fields.m_cleanupTimer = v82;
		    if ( v82 > 60.0 )
		    {
		      HG::Rendering::Runtime::HGWindSimpleManager::_CleanupInvalidCameraStates(v5, 0LL);
		      v5->fields.m_cleanupTimer = 0.0;
		    }
		    m_windMainState = v5->fields.m_windMainState;
		    if ( !m_windMainState )
		      sub_1800D8260(v78, v77);
		    *(_OWORD *)&v124[8] = 0LL;
		    v125 = 0LL;
		    *(_QWORD *)v124 = m_windMainState;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)v124, v77, v79, v80, ex);
		    *(_QWORD *)&v124[8] = (unsigned int)m_windMainState->fields._version;
		    DWORD2(v125) = 2;
		    *(_OWORD *)&v126._dictionary = *(_OWORD *)v124;
		    v126._current = 0LL;
		    *(_QWORD *)&v126._getEnumeratorRetType = *((_QWORD *)&v125 + 1);
		    ex = 0LL;
		    v110 = &v126;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v126,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::MoveNext) )
		      {
		        value = (float *)v126._current.value;
		        if ( !v126._current.value )
		          sub_1800D8250(v85, v84);
		        v88 = (float)(*(float *)&v126._current.value[1].klass * 0.079999998) * v81;
		        v89 = *((float *)&v126._current.value[2].monitor + 1);
		        v90 = *(float *)&v126._current.value[3].klass;
		        v91 = *(__int64 *)((char *)&v126._current.value[1].klass + 4);
		        v111 = v91;
		        v92 = *((float *)&v126._current.value[1].monitor + 1);
		        v93 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v93 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v94 = v93->static_fields->wrapperArray;
		        if ( !v94 )
		          sub_1800D8250(v93, 0LL);
		        if ( v94->max_length.size <= 630 )
		          goto LABEL_123;
		        if ( !v93->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v93);
		          v93 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v94 = v93->static_fields->wrapperArray;
		        if ( !v94 )
		          sub_1800D8250(v93, 0LL);
		        if ( v94->max_length.size <= 0x276u )
		          sub_1800D2AA0(v93, v94, v86);
		        if ( v94[17].vector[18] )
		        {
		          if ( !v93->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v93);
		            v93 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v95 = v93->static_fields->wrapperArray;
		          if ( !v95 )
		            sub_1800D8250(0LL, v94);
		          if ( v95->max_length.size <= 0x276u )
		            sub_1800D2AA0(v95, v94, v86);
		          v96 = v95[17].vector[18];
		          if ( !v96 )
		            sub_1800D8250(0LL, v94);
		          *(_QWORD *)&v113.x = v91;
		          v113.z = v92;
		          v130 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(v96, &v113, 0LL);
		        }
		        else
		        {
		LABEL_123:
		          v130 = (Vector2)_mm_unpacklo_ps((__m128)(unsigned int)v111, (__m128)_mm_cvtsi32_si128(LODWORD(v92))).m128_u64[0];
		        }
		        value[11] = v89 - (float)(v130.x * v88);
		        value[12] = v90 - (float)(v130.y * v88);
		        if ( !value )
		          sub_1800D8250(v93, v94);
		        value[13] = value[13] + v88;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v127 )
		    {
		      v84 = &v108;
		      ex = (MethodInfo *)v127->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v75 = 0;
		      v5 = this;
		    }
		    v97 = 0LL;
		    v98 = v5->fields.m_windMotors;
		    if ( !v98 )
		LABEL_217:
		      sub_1800D8250(v97, v84);
		    v99 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_u32[0];
		    while ( (int)v97 < v98->fields._size )
		    {
		      m_windMotorState = v5->fields.m_windMotorState;
		      if ( m_windMotorState )
		      {
		        if ( v75 >= m_windMotorState->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v101 = m_windMotorState->fields._items;
		        if ( v101 )
		        {
		          if ( v75 >= v101->max_length.size )
		            sub_1800D2AA0(v97, v84, v86);
		          v102 = v101->vector[v75];
		          if ( v102 )
		          {
		            v103 = (float)(v102->fields.lastData.windSpeed * 0.02) * v81;
		            if ( COERCE_FLOAT(COERCE_UNSIGNED_INT(v102->fields.lastData.windSpeed - 1.0) & v99) < 0.001 )
		            {
		              curWindTime = v102->fields.curWindTime;
		              Beyond::JobMathf::Fmod(v97, 3.1415927, v4);
		              if ( curWindTime > 1.5707964 )
		              {
		                v105 = v103 + v102->fields.curWindTime;
		                Beyond::JobMathf::Fmod(v97, 3.1415927, v4);
		                if ( v105 < 1.5707964 )
		                {
		                  v106 = v102->fields.curWindTime;
		                  Beyond::JobMathf::Fmod(v97, 3.1415927, v4);
		                  v103 = 3.1415927 - v106;
		                }
		              }
		            }
		            v107 = v103 + v102->fields.curWindTime;
		            Beyond::JobMathf::Fmod(v97, 628.31854, v4);
		            v102->fields.curWindTime = v107;
		            v97 = (Beyond::JobMathf *)++v75;
		            v98 = v5->fields.m_windMotors;
		            if ( v98 )
		              continue;
		          }
		        }
		      }
		      goto LABEL_217;
		    }
		  }
		}
		
		public void UpdateEcsFoliageSyncSystemParam(long windSystemIns, float time, float lastTime) {} // 0x0000000189CF8568-0x0000000189CF8650
		// Void UpdateEcsFoliageSyncSystemParam(Int64, Single, Single)
		void HG::Rendering::Runtime::HGWindSimpleManager::UpdateEcsFoliageSyncSystemParam(
		        HGWindSimpleManager *this,
		        int64_t windSystemIns,
		        float time,
		        float lastTime,
		        MethodInfo *method)
		{
		  Vector4 WindGlobalParams0; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Vector4 v11; // [rsp+50h] [rbp-48h] BYREF
		  Vector4 v12; // [rsp+60h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1717, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1717, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_688(Patch, (Object *)this, windSystemIns, time, lastTime, 0LL);
		  }
		  else
		  {
		    WindGlobalParams0 = this->fields.m_windParamDataCache._WindGlobalParams0;
		    v11 = this[2].fields.m_windParamDataCache._WindGlobalParams0;
		    v12 = WindGlobalParams0;
		    UnityEngine::HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_UpdateWindParam(
		      windSystemIns,
		      &v12,
		      &this->fields.m_windParamDataCache._WindMotorParams0.FixedElementField,
		      &this[1].fields.m_cleanupTimer,
		      &this[1].fields.m_windParamDataCache._WindGlobalParams0.z,
		      (float *)&this[2].monitor,
		      &v11,
		      time,
		      lastTime,
		      0LL);
		  }
		}
		
		private static bool CheckCameraValid(int guid) => default; // 0x0000000183336170-0x00000001833362D0
		// Boolean CheckCameraValid(Int32)
		bool HG::Rendering::Runtime::HGWindSimpleManager::CheckCameraValid(int32_t guid, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *main; // rax
		  struct Object_1__Class *v6; // rcx
		  Camera *v7; // rbx
		  char *m_CachedPtr; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size > 933 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3A5 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[19].vtable.GetHashCode.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(933, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		                 (ILFixDynamicMethodWrapper_17 *)Patch,
		                 (AudioLogChannel__Enum)guid,
		                 0LL);
		    }
		LABEL_20:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  UnityEngine::Application::get_isPlaying(0LL);
		  main = UnityEngine::Camera::get_main(0LL);
		  v6 = TypeInfo::UnityEngine::Object;
		  v7 = main;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v7 )
		    return 0;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::UnityEngine::Object;
		  }
		  if ( !v7->fields._._._.m_CachedPtr )
		    return 0;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::UnityEngine::Object;
		  }
		  if ( v6->static_fields->OffsetOfInstanceIDInCPlusPlusObject == -1 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v6);
		    TypeInfo::UnityEngine::Object->static_fields->OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
		    v6 = TypeInfo::UnityEngine::Object;
		  }
		  m_CachedPtr = (char *)v7->fields._._._.m_CachedPtr;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::UnityEngine::Object;
		  }
		  return *(_DWORD *)&m_CachedPtr[v6->static_fields->OffsetOfInstanceIDInCPlusPlusObject] == guid;
		}
		
		private void _SetupWindParamCache(ref ShaderVariablesGlobal cb, int cameraGuid) {} // 0x0000000183334A40-0x0000000183334D40
		// Void _SetupWindParamCache(ShaderVariablesGlobal ByRef, Int32)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetupWindParamCache(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t cameraGuid,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ShaderVariablesGlobal *v7; // rdi
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Camera *main; // rax
		  struct Object_1__Class *v10; // rcx
		  Camera *v11; // rbx
		  char *m_CachedPtr; // rbx
		  HGWindParamDataCache_WindMotorParams0_e_FixedBuffer *p_WindMotorParams0; // rcx
		  char *p_w; // rdx
		  char *p_fields; // rcx
		  char *v16; // rdx
		  char *p_z; // rcx
		  char *v18; // rdx
		  char *p_monitor; // rcx
		  char *v20; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v22; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = cb;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_33;
		  if ( wrapperArray->max_length.size > 932 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    cb = (ShaderVariablesGlobal *)v6->static_fields->wrapperArray;
		    if ( !cb )
		      goto LABEL_33;
		    if ( LODWORD(cb->_BackBufferSize.z) <= 0x3A4 )
		      goto LABEL_51;
		    if ( *(_QWORD *)&cb[3]._InkSimulationWorldToUV.w )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(932, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, (Object *)this, v7, cameraGuid, 0LL);
		        return;
		      }
		      goto LABEL_33;
		    }
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cb = (ShaderVariablesGlobal *)v6->static_fields->wrapperArray;
		  if ( !cb )
		    goto LABEL_33;
		  if ( SLODWORD(cb->_BackBufferSize.z) > 933 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		      goto LABEL_33;
		    if ( LODWORD(v6->_0.namespaze) > 0x3A5 )
		    {
		      if ( !v6[19].vtable.GetHashCode.method )
		        goto LABEL_9;
		      v22 = IFix::WrappersManagerImpl::GetPatch(933, 0LL);
		      if ( v22 )
		      {
		        if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		                (ILFixDynamicMethodWrapper_17 *)v22,
		                (AudioLogChannel__Enum)cameraGuid,
		                0LL) )
		          return;
		        goto LABEL_20;
		      }
		LABEL_33:
		      sub_1800D8260(v6, cb);
		    }
		LABEL_51:
		    sub_1800D2AB0(v6, cb);
		  }
		LABEL_9:
		  UnityEngine::Application::get_isPlaying(0LL);
		  main = UnityEngine::Camera::get_main(0LL);
		  v10 = TypeInfo::UnityEngine::Object;
		  v11 = main;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v10 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v11 )
		  {
		    if ( !v10->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v10);
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		    if ( v11->fields._._._.m_CachedPtr )
		    {
		      if ( !v10->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v10);
		        v10 = TypeInfo::UnityEngine::Object;
		      }
		      if ( v10->static_fields->OffsetOfInstanceIDInCPlusPlusObject == -1 )
		      {
		        if ( !v10->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v10);
		        TypeInfo::UnityEngine::Object->static_fields->OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
		        v10 = TypeInfo::UnityEngine::Object;
		      }
		      m_CachedPtr = (char *)v11->fields._._._.m_CachedPtr;
		      if ( !v10->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v10);
		        v10 = TypeInfo::UnityEngine::Object;
		      }
		      if ( *(_DWORD *)&m_CachedPtr[v10->static_fields->OffsetOfInstanceIDInCPlusPlusObject] == cameraGuid )
		      {
		LABEL_20:
		        this->fields.m_windParamDataCache._WindGlobalParams0 = *(Vector4 *)&v7->_FoliageInteractiveParams0.w;
		        this[2].fields.m_windParamDataCache._WindGlobalParams0 = *(Vector4 *)&v7->_FogBakeLutYawParams.w;
		        p_WindMotorParams0 = &this->fields.m_windParamDataCache._WindMotorParams0;
		        p_w = (char *)&v7->_AtmosphereFogParams5.w;
		        if ( (unsigned __int64)((char *)&this->fields.m_windParamDataCache._WindMotorParams0
		                              - (char *)&v7->_AtmosphereFogParams5.w) < 0x40
		          || (unsigned __int64)(p_w - (char *)p_WindMotorParams0) < 0x40 )
		        {
		          sub_18033B330(p_WindMotorParams0, p_w, 64LL);
		        }
		        else
		        {
		          *(_OWORD *)&p_WindMotorParams0->FixedElementField = *(_OWORD *)p_w;
		          this->fields.m_windParamDataCache._WindMotorCount = *(Vector4 *)&v7->_ExponentialFogParams0.w;
		          *(_OWORD *)&this->fields.m_windParamDataCache._WindLeafFadeDistance = *(_OWORD *)&v7->_ExponentialFogParams1.w;
		          *(_OWORD *)&this[1].klass = *(_OWORD *)&v7->_ExponentialFogParams2.w;
		        }
		        p_fields = (char *)&this[1].fields;
		        v16 = (char *)&v7->_ExponentialFogParams3.w;
		        if ( (unsigned __int64)((char *)&this[1].fields - (char *)&v7->_ExponentialFogParams3.w) < 0x40
		          || (unsigned __int64)(v16 - p_fields) < 0x40 )
		        {
		          sub_18033B330(p_fields, v16, 64LL);
		        }
		        else
		        {
		          *(_OWORD *)p_fields = *(_OWORD *)v16;
		          *(_OWORD *)&this[1].fields.m_windMotors = *(_OWORD *)&v7->_ExponentialFogParams4.w;
		          *(_OWORD *)&this[1].fields.m_windMotorState = *(_OWORD *)&v7->_ExponentialFogParams5.w;
		          *(_OWORD *)&this[1].fields.m_keysToRemove = *(_OWORD *)&v7->_VolumetricFogParams0.w;
		        }
		        p_z = (char *)&this[1].fields.m_windParamDataCache._WindGlobalParams0.z;
		        v18 = (char *)&v7->_VolumetricFogParams1.w;
		        if ( (unsigned __int64)((char *)&this[1].fields.m_windParamDataCache._WindGlobalParams0.z
		                              - (char *)&v7->_VolumetricFogParams1.w) < 0x40
		          || (unsigned __int64)(v18 - p_z) < 0x40 )
		        {
		          sub_18033B330(p_z, v18, 64LL);
		        }
		        else
		        {
		          *(_OWORD *)p_z = *(_OWORD *)v18;
		          *(_OWORD *)&this[1].fields.m_windParamDataCache._WindMotorParams2.FixedElementField = *(_OWORD *)&v7->_VolumetricFogParams2.w;
		          *(_OWORD *)&this[1].fields.m_windParamDataCache._WindMotorCount.z = *(_OWORD *)&v7->_VolumetricFogParams3.w;
		          *(_OWORD *)&this[1].fields.m_windParamDataCache._WindMainQuaility = *(_OWORD *)&v7->_VolumetricFogParams4.w;
		        }
		        p_monitor = (char *)&this[2].monitor;
		        v20 = (char *)&v7->_HeightFogFlowNoiseParams0.w;
		        if ( (unsigned __int64)((char *)&this[2].monitor - (char *)&v7->_HeightFogFlowNoiseParams0.w) < 0x40
		          || (unsigned __int64)(v20 - p_monitor) < 0x40 )
		        {
		          sub_18033B330(p_monitor, v20, 64LL);
		        }
		        else
		        {
		          *(_OWORD *)p_monitor = *(_OWORD *)v20;
		          *(_OWORD *)&this[2].fields.m_windFootMotors = *(_OWORD *)&v7->_HeightFogFlowNoiseParams1.w;
		          *(_OWORD *)&this[2].fields.m_windMainState = *(_OWORD *)&v7->_FogBakeLutRescaleParams.w;
		          *(_OWORD *)&this[2].fields.m_validCameraIds = *(_OWORD *)&v7->_FogBakeLutEncodeParams.w;
		        }
		      }
		    }
		  }
		}
		
		public void SetupShaderVariablesGlobalWind(ref ShaderVariablesGlobal cb, int cameraGuid, Vector3 cameraPos, HGEnvironmentPhase phase) {} // 0x0000000183101AF0-0x0000000183101D80
		// Void SetupShaderVariablesGlobalWind(ShaderVariablesGlobal ByRef, Int32, Vector3, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGWindSimpleManager::SetupShaderVariablesGlobalWind(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t cameraGuid,
		        Vector3 *cameraPos,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
		  int32_t size; // ebx
		  __int128 v14; // xmm0
		  float z; // eax
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v17; // rax
		  int v18; // ecx
		  __int64 v19; // rsi
		  float *v20; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v23; // rax
		  ILFixDynamicMethodWrapper_2 *v24; // rax
		  _OWORD v25[2]; // [rsp+40h] [rbp-28h] BYREF
		
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_28;
		  if ( wrapperArray->max_length.size > 916 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v8);
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v8->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_28;
		    if ( wrapperArray->max_length.size <= 0x394u )
		      goto LABEL_50;
		    if ( wrapperArray[25].vector[16] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(916, 0LL);
		      if ( !Patch )
		        goto LABEL_28;
		      v22 = *(_QWORD *)&cameraPos->x;
		      DWORD2(v25[0]) = LODWORD(cameraPos->z);
		      *(_QWORD *)&v25[0] = v22;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_374(
		        Patch,
		        (Object *)this,
		        cb,
		        cameraGuid,
		        (Vector3 *)v25,
		        (Object *)phase,
		        0LL);
		      return;
		    }
		  }
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMain(this, cb, cameraGuid, phase, 0LL);
		  m_windMotors = this->fields.m_windMotors;
		  if ( !m_windMotors )
		    goto LABEL_28;
		  size = 4;
		  if ( m_windMotors->fields._size < 4 )
		    size = m_windMotors->fields._size;
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_28;
		  if ( wrapperArray->max_length.size <= 918 )
		    goto LABEL_12;
		  if ( !v8->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v8);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_28;
		  if ( wrapperArray->max_length.size <= 0x396u )
		LABEL_50:
		    sub_1800D2AB0(v8, wrapperArray);
		  if ( wrapperArray[25].vector[18] )
		  {
		    v23 = IFix::WrappersManagerImpl::GetPatch(918, 0LL);
		    if ( !v23 )
		      goto LABEL_28;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(v23, (Object *)this, cb, size, 0LL);
		    goto LABEL_13;
		  }
		LABEL_12:
		  v14 = LODWORD(v25[0]);
		  *(float *)&v14 = (float)size;
		  v25[0] = v14;
		  *(_OWORD *)&cb->_FogBakeLutYawParams.w = v14;
		LABEL_13:
		  z = cameraPos->z;
		  *(_QWORD *)&v25[0] = *(_QWORD *)&cameraPos->x;
		  *((float *)v25 + 2) = z;
		  HG::Rendering::Runtime::HGWindSimpleManager::_SortWindMotorsForSingleCamera(this, (Vector3 *)v25, 0LL);
		  for ( i = 0; ; ++i )
		  {
		    v17 = this->fields.m_windMotors;
		    if ( !v17 )
		      goto LABEL_28;
		    v18 = 4;
		    if ( v17->fields._size < 4 )
		      v18 = v17->fields._size;
		    if ( i >= v18 )
		      break;
		    HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMotor(this, cb, i, 0LL);
		  }
		  v19 = v17->fields._size;
		  if ( (int)v19 < 4 )
		  {
		    v20 = &cb->_ExponentialFogParams3.w + 4 * v19;
		    while ( 1 )
		    {
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = v8->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        break;
		      if ( wrapperArray->max_length.size <= 930 )
		        goto LABEL_24;
		      if ( !v8->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v8);
		        v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v8 = (struct ILFixDynamicMethodWrapper_2__Class *)v8->static_fields->wrapperArray;
		      if ( !v8 )
		        break;
		      if ( LODWORD(v8->_0.namespaze) <= 0x3A2 )
		        goto LABEL_50;
		      if ( v8[19].vtable.Finalize.methodPtr )
		      {
		        v24 = IFix::WrappersManagerImpl::GetPatch(930, 0LL);
		        if ( !v24 )
		          break;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(v24, (Object *)this, cb, v19, 0LL);
		      }
		      else
		      {
		LABEL_24:
		        *((_QWORD *)v20 - 8) = 0LL;
		        *(_QWORD *)v20 = 0LL;
		        *((_QWORD *)v20 + 8) = 0LL;
		        *((_QWORD *)v20 + 16) = 0LL;
		        *((_QWORD *)v20 - 7) = 0LL;
		        *((_QWORD *)v20 + 1) = 0LL;
		        *((_QWORD *)v20 + 9) = 0LL;
		        *((_QWORD *)v20 + 17) = 0LL;
		        *((_QWORD *)v20 + 28) = 0LL;
		        *((_QWORD *)v20 + 36) = 0LL;
		        *((_QWORD *)v20 + 44) = 0LL;
		        *((_QWORD *)v20 + 29) = 0LL;
		        *((_QWORD *)v20 + 37) = 0LL;
		        *((_QWORD *)v20 + 45) = 0LL;
		      }
		      LODWORD(v19) = v19 + 1;
		      v20 += 4;
		      if ( (int)v19 >= 4 )
		        goto LABEL_26;
		    }
		LABEL_28:
		    sub_1800D8260(v8, wrapperArray);
		  }
		LABEL_26:
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindFoot(this, cb, phase, 0LL);
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetupWindParamCache(this, cb, cameraGuid, 0LL);
		}
		
		private void _SetupShaderVariablesWindMain(ref ShaderVariablesGlobal cb, int cameraGuid, HGEnvironmentPhase phase) {} // 0x00000001831CAD90-0x00000001831CB200
		// Void _SetupShaderVariablesWindMain(ShaderVariablesGlobal ByRef, Int32, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMain(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t cameraGuid,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *textures; // rcx
		  ShaderVariablesGlobal *v9; // r14
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rsi
		  Object__Class *v12; // xmm7_8
		  __m128 speed_low; // xmm6
		  float z; // r15d
		  struct MethodInfo *v15; // rbx
		  Dictionary_2_System_Int32_System_Object_ *v16; // rbx
		  struct MethodInfo *v17; // rsi
		  int32_t Entry; // eax
		  InsertionBehavior__Enum v19; // r9d
		  Dictionary_2_TKey_TValue_Entry_System_Int32_System_Object___Array *entries; // rbx
		  Object *value; // rbx
		  __m128 v22; // xmm3
		  __m128 v23; // xmm3
		  __m128 v24; // xmm3
		  __m128 v25; // xmm4
		  __m128 v26; // xmm4
		  __m128 v27; // xmm4
		  __m128 v28; // xmm3
		  __m128 v29; // xmm3
		  __m128 v30; // xmm3
		  int v31; // xmm1_4
		  int klass_high; // xmm0_4
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *v33; // rbp
		  struct MethodInfo *v34; // rsi
		  struct HGShaderIDs__Class *v35; // rax
		  unsigned int WindGlobalNoiseTex; // edi
		  Object *currentPipeline; // rbx
		  HGRenderPipelineRuntimeResources *v38; // rax
		  void (__fastcall *v39)(_QWORD, __int64); // rax
		  __int64 v40; // rbx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *v41; // rbx
		  Object *v42; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Il2CppClass *klass; // rax
		  __int64 v45; // rax
		  Object *v46; // rax
		  __int64 v47; // r8
		  ILFixDynamicMethodWrapper_2 *v48; // rax
		  __int64 v49; // rax
		  int32_t v50; // [rsp+30h] [rbp-58h] BYREF
		  Object__Class *v51; // [rsp+38h] [rbp-50h]
		
		  textures = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v9 = cb;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    textures = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = textures->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_42;
		  if ( wrapperArray->max_length.size > 917 )
		  {
		    if ( !textures->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(textures);
		      textures = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    cb = (ShaderVariablesGlobal *)textures->static_fields->wrapperArray;
		    if ( !cb )
		      goto LABEL_42;
		    if ( LODWORD(cb->_BackBufferSize.z) <= 0x395 )
		      goto LABEL_45;
		    if ( *(_QWORD *)&cb[3]._CharacterParams10.y )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(917, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, (Object *)this, v9, cameraGuid, (Object *)phase, 0LL);
		        return;
		      }
		      goto LABEL_42;
		    }
		  }
		  if ( !phase )
		    goto LABEL_42;
		  m_windMainState = this->fields.m_windMainState;
		  speed_low = (__m128)LODWORD(phase->fields.windConfig.speed);
		  v12 = *(Object__Class **)&phase->fields.windConfig.direction.x;
		  speed_low.m128_f32[0] = speed_low.m128_f32[0] * 0.25;
		  z = phase->fields.windConfig.direction.z;
		  v51 = v12;
		  if ( !m_windMainState )
		    goto LABEL_42;
		  v15 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey->klass->rgctx_data[22].rgctxDataDummy
		        + 4) )
		    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey->klass->rgctx_data[22].rgctxDataDummy)();
		  if ( System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
		         (Dictionary_2_System_Int32_System_Object_ *)m_windMainState,
		         cameraGuid,
		         (MethodInfo *)v15->klass->rgctx_data[22].rgctxDataDummy) < 0 )
		  {
		    v41 = this->fields.m_windMainState;
		    v42 = (Object *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState);
		    if ( !v42 || !v41 )
		      goto LABEL_42;
		    System::Collections::Generic::Dictionary<int,System::Object>::set_Item(
		      (Dictionary_2_System_Int32_System_Object_ *)v41,
		      cameraGuid,
		      v42,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item);
		  }
		  v16 = (Dictionary_2_System_Int32_System_Object_ *)this->fields.m_windMainState;
		  if ( !v16 )
		    goto LABEL_42;
		  v17 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item->klass->rgctx_data[22].rgctxDataDummy
		        + 4) )
		    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item->klass->rgctx_data[22].rgctxDataDummy)();
		  Entry = System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
		            v16,
		            cameraGuid,
		            (MethodInfo *)v17->klass->rgctx_data[22].rgctxDataDummy);
		  if ( Entry < 0 )
		  {
		    klass = v17->klass;
		    v50 = cameraGuid;
		    v45 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)klass->rgctx_data[23].rgctxDataDummy);
		    v46 = (Object *)il2cpp_value_box_0(v45, &v50);
		    System::ThrowHelper::GetKeyNotFoundException(v46, 0LL);
		  }
		  entries = v16->fields._entries;
		  if ( !entries )
		    goto LABEL_42;
		  if ( (unsigned int)Entry >= entries->max_length.size )
		    goto LABEL_45;
		  value = entries->vector[Entry].value;
		  if ( !value )
		    goto LABEL_42;
		  v22 = _mm_shuffle_ps(speed_low, speed_low, 225);
		  v22.m128_f32[0] = *((float *)&value[3].klass + 1);
		  v23 = _mm_shuffle_ps(v22, v22, 198);
		  v23.m128_f32[0] = *(float *)&v51;
		  v24 = _mm_shuffle_ps(v23, v23, 39);
		  v24.m128_f32[0] = z;
		  *(__m128 *)&v9->_FoliageInteractiveParams0.w = _mm_shuffle_ps(v24, v24, 57);
		  v25 = _mm_shuffle_ps((__m128)LODWORD(value[1].klass), (__m128)LODWORD(value[1].klass), 225);
		  v25.m128_f32[0] = *(float *)&value[2].monitor;
		  v26 = _mm_shuffle_ps(v25, v25, 198);
		  v26.m128_f32[0] = *((float *)&value[1].klass + 1);
		  v27 = _mm_shuffle_ps(v26, v26, 39);
		  v27.m128_f32[0] = *((float *)&value[1].monitor + 1);
		  *(__m128 *)&v9->_CloudShadowParams0.w = _mm_shuffle_ps(v27, v27, 57);
		  v28 = _mm_shuffle_ps((__m128)HIDWORD(value[2].monitor), (__m128)HIDWORD(value[2].monitor), 225);
		  v28.m128_f32[0] = *(float *)&value[3].klass;
		  v29 = _mm_shuffle_ps(v28, v28, 198);
		  v29.m128_f32[0] = *(float *)&value[2].klass;
		  v30 = _mm_shuffle_ps(v29, v29, 39);
		  v30.m128_f32[0] = *((float *)&value[2].klass + 1);
		  *(__m128 *)&v9->_PrevFoliageInteractiveParams0.w = _mm_shuffle_ps(v30, v30, 57);
		  v31 = (int)value[3].klass;
		  LODWORD(value[2].klass) = HIDWORD(value[2].monitor);
		  klass_high = HIDWORD(value[3].klass);
		  *(Object__Class **)((char *)&value[1].klass + 4) = v12;
		  LODWORD(value[2].monitor) = klass_high;
		  LODWORD(value[1].klass) = speed_low.m128_i32[0];
		  HIDWORD(value[2].klass) = v31;
		  *((float *)&value[1].monitor + 1) = z;
		  v33 = this->fields.m_windMainState;
		  if ( !v33 )
		    goto LABEL_42;
		  v34 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item->klass->rgctx_data[24].rgctxDataDummy
		        + 4) )
		    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item->klass->rgctx_data[24].rgctxDataDummy)();
		  LOBYTE(v19) = 1;
		  System::Collections::Generic::Dictionary<int,System::Object>::TryInsert(
		    (Dictionary_2_System_Int32_System_Object_ *)v33,
		    cameraGuid,
		    value,
		    v19,
		    (MethodInfo *)v34->klass->rgctx_data[24].rgctxDataDummy);
		  v35 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v35 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  }
		  WindGlobalNoiseTex = v35->static_fields->_WindGlobalNoiseTex;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentPipeline = (Object *)HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !currentPipeline )
		    goto LABEL_42;
		  cb = (ShaderVariablesGlobal *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    cb = (ShaderVariablesGlobal *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  textures = *(struct ILFixDynamicMethodWrapper_2__Class **)&cb->unity_DeltaTime.x;
		  if ( !textures->_0.image )
		LABEL_42:
		    sub_1800D8260(textures, cb);
		  if ( (int)textures->_0.image->typeCount > 416 )
		  {
		    if ( !LODWORD(cb->_LastTimeParameters.z) )
		    {
		      il2cpp_runtime_class_init_1(cb);
		      cb = (ShaderVariablesGlobal *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v47 = **(_QWORD **)&cb->unity_DeltaTime.x;
		    if ( !v47 )
		      goto LABEL_42;
		    if ( *(_DWORD *)(v47 + 24) <= 0x1A0u )
		      goto LABEL_45;
		    if ( *(_QWORD *)(v47 + 3360) )
		    {
		      v48 = IFix::WrappersManagerImpl::GetPatch(416, 0LL);
		      if ( !v48 )
		        goto LABEL_42;
		      goto LABEL_60;
		    }
		  }
		  currentPipeline = (Object *)currentPipeline[3].monitor;
		  if ( !currentPipeline )
		    goto LABEL_42;
		  if ( !LODWORD(cb->_LastTimeParameters.z) )
		  {
		    il2cpp_runtime_class_init_1(cb);
		    cb = (ShaderVariablesGlobal *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  textures = **(struct ILFixDynamicMethodWrapper_2__Class ***)&cb->unity_DeltaTime.x;
		  if ( !textures )
		    goto LABEL_42;
		  if ( SLODWORD(textures->_0.namespaze) > 417 )
		  {
		    if ( !LODWORD(cb->_LastTimeParameters.z) )
		    {
		      il2cpp_runtime_class_init_1(cb);
		      cb = (ShaderVariablesGlobal *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    cb = **(ShaderVariablesGlobal ***)&cb->unity_DeltaTime.x;
		    if ( cb )
		    {
		      if ( LODWORD(cb->_BackBufferSize.z) > 0x1A1 )
		      {
		        if ( !*(_QWORD *)&cb[1]._CharacterParams14.y )
		          goto LABEL_34;
		        v48 = IFix::WrappersManagerImpl::GetPatch(417, 0LL);
		        if ( !v48 )
		          goto LABEL_42;
		LABEL_60:
		        v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_202(v48, currentPipeline, 0LL);
		        goto LABEL_35;
		      }
		LABEL_45:
		      sub_1800D2AB0(textures, cb);
		    }
		    goto LABEL_42;
		  }
		LABEL_34:
		  v38 = (HGRenderPipelineRuntimeResources *)currentPipeline[7].klass;
		LABEL_35:
		  if ( !v38 )
		    goto LABEL_42;
		  textures = (struct ILFixDynamicMethodWrapper_2__Class *)v38->fields.textures;
		  if ( !textures )
		    goto LABEL_42;
		  v39 = (void (__fastcall *)(_QWORD, __int64))qword_18F36F5F0;
		  v40 = *((_QWORD *)&textures->_0.byval_arg + 1);
		  if ( !qword_18F36F5F0 )
		  {
		    v39 = (void (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                  "UnityEngine.Shader::SetGlobalTextureImpl(System.Int32,UnityEngine.Texture)");
		    if ( !v39 )
		    {
		      v49 = sub_1802EE1B8("UnityEngine.Shader::SetGlobalTextureImpl(System.Int32,UnityEngine.Texture)");
		      sub_18007E1B0(v49, 0LL);
		    }
		    qword_18F36F5F0 = (__int64)v39;
		  }
		  v39(WindGlobalNoiseTex, v40);
		}
		
		private bool _IsWindMotorCanStop(float windTime) => default; // 0x0000000183C015F0-0x0000000183C01680
		// Boolean _IsWindMotorCanStop(Single)
		bool HG::Rendering::Runtime::HGWindSimpleManager::_IsWindMotorCanStop(
		        HGWindSimpleManager *this,
		        float windTime,
		        MethodInfo *method)
		{
		  float v3; // xmm2_4
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 927 )
		  {
		LABEL_5:
		    Beyond::JobMathf::Fmod((Beyond::JobMathf *)v5, 3.1415927, v3);
		    return fabs(windTime) < 0.1;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x39F )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( !*(_QWORD *)&v5[19]._1.naturalAligment )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_126(
		           (ILFixDynamicMethodWrapper_3 *)Patch,
		           (Object *)this,
		           windTime,
		           0LL);
		}
		
		private void _SetupShaderVariableWindMotorCount(ref ShaderVariablesGlobal cb, int count) {} // 0x0000000183DD36B0-0x0000000183DD3750
		// Void _SetupShaderVariableWindMotorCount(ShaderVariablesGlobal ByRef, Int32)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariableWindMotorCount(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t count,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __int128 v9; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned int v11; // [rsp+30h] [rbp-18h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 918 )
		  {
		LABEL_5:
		    v9 = v11;
		    *(float *)&v9 = (float)count;
		    *(_OWORD *)&cb->_FogBakeLutYawParams.w = v9;
		    return;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x396 )
		    sub_1800D2AB0(v6, cb);
		  if ( !v6[19]._1.cctor_thread )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(918, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, cb);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, (Object *)this, cb, count, 0LL);
		}
		
		private void _SetupShaderVariablesWindMotor(ref ShaderVariablesGlobal cb, int index) {} // 0x0000000183440510-0x00000001834409C0
		// Void _SetupShaderVariablesWindMotor(ShaderVariablesGlobal ByRef, Int32)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMotor(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t index,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *v9; // rax
		  HGWindSimpleManager_HGWindMotorState__Array *items; // r14
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
		  HGWindSimpleManager_HGWindMotorState *v12; // r14
		  float v13; // xmm1_4
		  HGWindMotor__Array *v14; // rdi
		  HGWindMotor *v15; // rdi
		  __m128 v16; // xmm6
		  __int64 (__fastcall *v17)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, _QWORD, MethodInfo *); // rax
		  float distanceToCamera; // r12d
		  __int128 v19; // xmm11
		  __int128 v20; // xmm12
		  __int64 v21; // r15
		  void (__fastcall *v22)(__int64, Vector3 *); // rax
		  float z; // r15d
		  unsigned __int64 v24; // xmm0_8
		  unsigned __int64 v25; // xmm10_8
		  Vector3 *Direction; // rax
		  __int64 v27; // xmm7_8
		  bool v28; // zf
		  float v29; // edi
		  __m128 v30; // xmm1
		  __m128 v31; // xmm7
		  unsigned __int32 x_low; // xmm8_4
		  __m128 y_low; // xmm9
		  __int64 v34; // xmm0_8
		  __int128 v35; // xmm1
		  __m128 v36; // xmm2
		  float v37; // eax
		  __int128 v38; // xmm0
		  __m128 v39; // xmm1
		  __int128 v40; // xmm0
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *v43; // r10
		  HGWindSimpleManager_HGWindMotorState__Array *v44; // rax
		  __int64 v45; // r10
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  List_1_System_Object_ *m_windMotorState; // rdi
		  Object *v48; // rax
		  __m128 v49; // xmm6
		  __int64 v50; // rax
		  __int64 v51; // rax
		  ILFixDynamicMethodWrapper_2 *v52; // rax
		  Vector3 *v53; // rax
		  ILFixDynamicMethodWrapper_2 *v54; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-E0h]
		  float curWindTime; // [rsp+30h] [rbp-D0h]
		  Vector3 v57; // [rsp+40h] [rbp-C0h] BYREF
		  Vector3 v58; // [rsp+50h] [rbp-B0h] BYREF
		  HGWindMotorData v59; // [rsp+60h] [rbp-A0h] BYREF
		
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)index;
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_43;
		  if ( wrapperArray->max_length.size > 924 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size <= 0x39Cu )
		      goto LABEL_44;
		    if ( wrapperArray[25].vector[24] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(924, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, (Object *)this, cb, (int32_t)v5, 0LL);
		        return;
		      }
		      goto LABEL_43;
		    }
		  }
		  if ( !this->fields.m_windMotorState )
		    return;
		  if ( this->fields.m_windMotorState->fields._size < (int)v5 )
		  {
		    m_windMotorState = (List_1_System_Object_ *)this->fields.m_windMotorState;
		    v48 = (Object *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
		    if ( !v48 )
		      goto LABEL_43;
		    System::Collections::Generic::List<System::Object>::set_Item(
		      m_windMotorState,
		      (int32_t)v5,
		      v48,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::set_Item);
		  }
		  v9 = this->fields.m_windMotorState;
		  if ( !v9 )
		    goto LABEL_43;
		  if ( (unsigned int)v5 >= v9->fields._size )
		LABEL_77:
		    System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		  items = v9->fields._items;
		  if ( !items )
		    goto LABEL_43;
		  if ( (unsigned int)v5 >= items->max_length.size )
		    goto LABEL_44;
		  m_windMotors = this->fields.m_windMotors;
		  v12 = items->vector[(_QWORD)v5];
		  if ( !m_windMotors )
		LABEL_43:
		    sub_1800D8260(v6, wrapperArray);
		  v13 = 0.0;
		  if ( m_windMotors->fields._size > (int)v5 )
		  {
		    if ( (unsigned int)v5 >= m_windMotors->fields._size )
		      goto LABEL_77;
		    v14 = m_windMotors->fields._items;
		    if ( !v14 )
		      goto LABEL_43;
		    if ( (unsigned int)v5 >= v14->max_length.size )
		      goto LABEL_44;
		    v15 = v14->vector[(_QWORD)v5];
		    if ( !v15 )
		      goto LABEL_43;
		    v16 = *(__m128 *)&v15->fields.data.angle;
		    v17 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, _QWORD, MethodInfo *))qword_18F36FBC0;
		    distanceToCamera = v15->fields.data.distanceToCamera;
		    v19 = *(_OWORD *)&v15->fields.data.windPriority;
		    v20 = *(_OWORD *)&v15->fields.data.width;
		    *(__m128 *)&v59.angle = v16;
		    if ( !qword_18F36FBC0 )
		    {
		      v17 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, _QWORD, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v17 )
		      {
		        v50 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v50, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v17;
		    }
		    v21 = v17(v15, wrapperArray, *(_QWORD *)&index, method);
		    if ( !v21 )
		      goto LABEL_43;
		    *(_QWORD *)&v57.x = 0LL;
		    v57.z = 0.0;
		    v22 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v22 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                       "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v22 )
		      {
		        v51 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v51, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v22;
		    }
		    v22(v21, &v57);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size <= 925 )
		      goto LABEL_24;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size <= 0x39Du )
		      goto LABEL_44;
		    if ( wrapperArray[25].vector[25] )
		    {
		      v52 = IFix::WrappersManagerImpl::GetPatch(925, 0LL);
		      if ( !v52 )
		        goto LABEL_43;
		      v58 = v57;
		      v53 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(&v57, v52, &v58, 0LL);
		      v24 = *(_QWORD *)&v53->x;
		      z = v53->z;
		    }
		    else
		    {
		LABEL_24:
		      z = v57.z;
		      v24 = _mm_unpacklo_ps((__m128)LODWORD(v57.x), (__m128)LODWORD(v57.y)).m128_u64[0];
		    }
		    v25 = v24;
		    Direction = HG::Rendering::Runtime::HGWindMotor::GetDirection(&v57, v15, 0LL);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v27 = *(_QWORD *)&Direction->x;
		    v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor == 0;
		    v29 = Direction->z;
		    *(_QWORD *)&v58.x = *(_QWORD *)&Direction->x;
		    if ( v28 )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size <= 630 )
		      goto LABEL_29;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_43;
		    if ( wrapperArray->max_length.size > 0x276u )
		    {
		      if ( wrapperArray[17].vector[18] )
		      {
		        v54 = IFix::WrappersManagerImpl::GetPatch(630, 0LL);
		        if ( !v54 )
		          goto LABEL_43;
		        *(_QWORD *)&v58.x = v27;
		        v58.z = v29;
		        v30 = (__m128)(unsigned __int64)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(v54, &v58, 0LL);
		        goto LABEL_30;
		      }
		LABEL_29:
		      v30 = _mm_unpacklo_ps((__m128)LODWORD(v58.x), (__m128)_mm_cvtsi32_si128(LODWORD(v29)));
		LABEL_30:
		      v31 = v30;
		      *(_QWORD *)&v57.x = v30.m128_u64[0];
		      x_low = v30.m128_i32[0];
		      y_low.m128_i32[0] = _mm_shuffle_ps(v31, v31, 85).m128_u32[0];
		      LODWORD(v13) = _mm_shuffle_ps(v16, v16, 85).m128_u32[0];
		      goto LABEL_31;
		    }
		LABEL_44:
		    sub_1800D2AB0(v6, wrapperArray);
		  }
		  if ( !v12 )
		    goto LABEL_43;
		  distanceToCamera = v12->fields.lastData.distanceToCamera;
		  x_low = LODWORD(v12->fields.lastDirection.x);
		  y_low = (__m128)LODWORD(v12->fields.lastDirection.y);
		  v19 = *(_OWORD *)&v12->fields.lastData.windPriority;
		  z = v12->fields.lastPosition.z;
		  v20 = *(_OWORD *)&v12->fields.lastData.width;
		  v25 = *(_QWORD *)&v12->fields.lastPosition.x;
		  v31.m128_u64[0] = _mm_unpacklo_ps((__m128)x_low, y_low).m128_u64[0];
		  v49 = _mm_shuffle_ps(*(__m128 *)&v12->fields.lastData.angle, *(__m128 *)&v12->fields.lastData.angle, 225);
		  v49.m128_f32[0] = 0.0;
		  v16 = _mm_shuffle_ps(v49, v49, 225);
		  *(__m128 *)&v59.angle = v16;
		LABEL_31:
		  if ( v13 <= 1.0 )
		  {
		    if ( !v12 )
		      goto LABEL_43;
		    if ( HG::Rendering::Runtime::HGWindSimpleManager::_IsWindMotorCanStop(this, v12->fields.curWindTime, 0LL) )
		      v59.windSpeed = 0.0;
		    else
		      v59.windSpeed = 1.0;
		    v16 = *(__m128 *)&v59.angle;
		  }
		  if ( !v12 )
		    goto LABEL_43;
		  v34 = *(_QWORD *)&v12->fields.lastPosition.x;
		  v35 = *(_OWORD *)&v12->fields.lastData.width;
		  v58.z = v12->fields.lastPosition.z;
		  v36 = (__m128)LODWORD(v12->fields.lastDirection.y);
		  v37 = v12->fields.lastData.distanceToCamera;
		  *(_QWORD *)&v58.x = v34;
		  v38 = *(_OWORD *)&v12->fields.lastData.windPriority;
		  *(_OWORD *)&v59.width = v35;
		  v39 = (__m128)LODWORD(v12->fields.lastDirection.x);
		  *(_OWORD *)&v59.windPriority = v38;
		  v40 = *(_OWORD *)&v12->fields.lastData.angle;
		  v59.distanceToCamera = v37;
		  *(_OWORD *)&v59.angle = v40;
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetLastWindMotorParams(
		    this,
		    cb,
		    (int32_t)v5,
		    &v59,
		    &v58,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v39, v36),
		    v12->fields.lastWindTime,
		    0LL);
		  *(float *)&v40 = v12->fields.curWindTime;
		  *(_OWORD *)&v12->fields.lastData.windPriority = v19;
		  *(_OWORD *)&v12->fields.lastData.width = v20;
		  *(__m128 *)&v12->fields.lastData.angle = v16;
		  v12->fields.lastData.distanceToCamera = distanceToCamera;
		  *(_QWORD *)&v12->fields.lastPosition.x = v25;
		  LODWORD(v12->fields.lastWindTime) = v40;
		  LODWORD(v12->fields.lastDirection.x) = x_low;
		  LODWORD(v12->fields.lastDirection.y) = y_low.m128_i32[0];
		  v12->fields.lastPosition.z = z;
		  v43 = this->fields.m_windMotorState;
		  if ( !v43 )
		    goto LABEL_43;
		  if ( (unsigned int)v5 >= v43->fields._size )
		    goto LABEL_77;
		  v44 = v43->fields._items;
		  if ( !v44 )
		    goto LABEL_43;
		  v6 = v5;
		  if ( (unsigned int)v5 >= v44->max_length.size )
		    goto LABEL_44;
		  v44->vector[(_QWORD)v5] = v12;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)(&v44->klass + (_QWORD)&v5->_0.image + 4),
		    (HGRuntimeGrassQuery_Node *)wrapperArray,
		    v41,
		    v42,
		    methoda);
		  ++*(_DWORD *)(v45 + 28);
		  curWindTime = v12->fields.curWindTime;
		  *(_QWORD *)&v58.x = v25;
		  v58.z = z;
		  *(_OWORD *)&v59.windPriority = v19;
		  *(_OWORD *)&v59.width = v20;
		  *(__m128 *)&v59.angle = v16;
		  v59.distanceToCamera = distanceToCamera;
		  HG::Rendering::Runtime::HGWindSimpleManager::_SetWindMotorParams(
		    this,
		    cb,
		    (int32_t)v5,
		    &v59,
		    &v58,
		    *(Vector2 *)v31.m128_f32,
		    curWindTime,
		    0LL);
		}
		
		public HGWindMotorData GetWindMotorData(HGWindMotor windMotor) => default; // 0x0000000189CF849C-0x0000000189CF8568
		// HGWindMotorData GetWindMotorData(HGWindMotor)
		HGWindMotorData *HG::Rendering::Runtime::HGWindSimpleManager::GetWindMotorData(
		        HGWindMotorData *__return_ptr retstr,
		        HGWindSimpleManager *this,
		        HGWindMotor *windMotor,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int128 v9; // xmm0
		  float distanceToCamera; // eax
		  __int128 v11; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWindMotorData *v13; // rax
		  HGWindMotorData v15; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1718, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1718, 0LL);
		    if ( Patch )
		    {
		      v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_689(&v15, Patch, (Object *)this, (Object *)windMotor, 0LL);
		      v11 = *(_OWORD *)&v13->width;
		      *(_OWORD *)&retstr->windPriority = *(_OWORD *)&v13->windPriority;
		      v9 = *(_OWORD *)&v13->angle;
		      distanceToCamera = v13->distanceToCamera;
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit((Object_1 *)windMotor, 0LL) )
		  {
		    if ( windMotor )
		    {
		      distanceToCamera = windMotor->fields.data.distanceToCamera;
		      v11 = *(_OWORD *)&windMotor->fields.data.width;
		      *(_OWORD *)&retstr->windPriority = *(_OWORD *)&windMotor->fields.data.windPriority;
		      v9 = *(_OWORD *)&windMotor->fields.data.angle;
		LABEL_9:
		      *(_OWORD *)&retstr->width = v11;
		      goto LABEL_10;
		    }
		    goto LABEL_7;
		  }
		  v9 = 0LL;
		  distanceToCamera = 0.0;
		  *(_OWORD *)&retstr->windPriority = 0LL;
		  *(_OWORD *)&retstr->width = 0LL;
		LABEL_10:
		  *(_OWORD *)&retstr->angle = v9;
		  retstr->distanceToCamera = distanceToCamera;
		  return retstr;
		}
		
		private void _SetupShaderVariablesWindFoot(ref ShaderVariablesGlobal cb, HGEnvironmentPhase phase) {} // 0x0000000183B0ADE0-0x0000000183B0AFC0
		// Void _SetupShaderVariablesWindFoot(ShaderVariablesGlobal ByRef, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindFoot(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ShaderVariablesGlobal *v7; // rdi
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  HGWindSimpleManager_HGWindFootMotor__Array *m_windFootMotors; // rax
		  __m128 v10; // xmm3
		  __m128 v11; // xmm6
		  __m128 v12; // xmm5
		  __m128 v13; // xmm4
		  __m128 v14; // xmm2
		  __m128 v15; // xmm2
		  __m128 v16; // xmm2
		  __m128 v17; // xmm2
		  __m128 v18; // xmm3
		  __m128 v19; // xmm3
		  __m128 v20; // xmm3
		  __m128 v21; // xmm3
		  __m128 v22; // xmm2
		  __m128 v23; // xmm3
		  __m128 v24; // xmm2
		  __m128 v25; // xmm3
		  __m128 v26; // xmm2
		  __m128 v27; // xmm2
		  __m128 v28; // xmm3
		  __m128 v29; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = cb;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size <= 931 )
		    goto LABEL_5;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cb = (ShaderVariablesGlobal *)v6->static_fields->wrapperArray;
		  if ( !cb )
		LABEL_11:
		    sub_1800D8260(v6, cb);
		  if ( LODWORD(cb->_BackBufferSize.z) <= 0x3A3 )
		    goto LABEL_12;
		  if ( *(_QWORD *)&cb[3]._InkSimulationWorldToUV.y )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(931, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, v7, (Object *)phase, 0LL);
		      return;
		    }
		    goto LABEL_11;
		  }
		LABEL_5:
		  m_windFootMotors = this->fields.m_windFootMotors;
		  if ( !m_windFootMotors )
		    goto LABEL_11;
		  if ( m_windFootMotors->max_length.size > 0 )
		  {
		    v10 = (__m128)m_windFootMotors->vector[0];
		    if ( m_windFootMotors->max_length.size > 1u )
		    {
		      v11 = (__m128)m_windFootMotors->vector[1];
		      if ( m_windFootMotors->max_length.size > 2u )
		      {
		        v12 = (__m128)m_windFootMotors->vector[2];
		        if ( m_windFootMotors->max_length.size > 3u )
		        {
		          v13 = (__m128)m_windFootMotors->vector[3];
		          v14 = _mm_shuffle_ps(v10, v10, 85);
		          v15 = _mm_shuffle_ps(v14, v14, 225);
		          v15.m128_f32[0] = _mm_shuffle_ps(v10, v10, 170).m128_f32[0];
		          v16 = _mm_shuffle_ps(v15, v15, 198);
		          v16.m128_f32[0] = _mm_shuffle_ps(v10, v10, 255).m128_f32[0];
		          v17 = _mm_shuffle_ps(v16, v16, 39);
		          v17.m128_f32[0] = v10.m128_f32[0];
		          v18 = _mm_shuffle_ps(v11, v11, 85);
		          v19 = _mm_shuffle_ps(v18, v18, 225);
		          v19.m128_f32[0] = _mm_shuffle_ps(v11, v11, 170).m128_f32[0];
		          v20 = _mm_shuffle_ps(v19, v19, 198);
		          v20.m128_f32[0] = _mm_shuffle_ps(v11, v11, 255).m128_f32[0];
		          v21 = _mm_shuffle_ps(v20, v20, 39);
		          v21.m128_f32[0] = v11.m128_f32[0];
		          *(__m128 *)&v7->_AtmosphereFogParams0.w = _mm_shuffle_ps(v17, v17, 57);
		          *(__m128 *)&v7->_AtmosphereFogParams1.w = _mm_shuffle_ps(v21, v21, 57);
		          v22 = _mm_shuffle_ps(v12, v12, 85);
		          v23 = _mm_shuffle_ps(v13, v13, 85);
		          v24 = _mm_shuffle_ps(v22, v22, 225);
		          v24.m128_f32[0] = _mm_shuffle_ps(v12, v12, 170).m128_f32[0];
		          v25 = _mm_shuffle_ps(v23, v23, 225);
		          v26 = _mm_shuffle_ps(v24, v24, 198);
		          v26.m128_f32[0] = _mm_shuffle_ps(v12, v12, 255).m128_f32[0];
		          v25.m128_f32[0] = _mm_shuffle_ps(v13, v13, 170).m128_f32[0];
		          v27 = _mm_shuffle_ps(v26, v26, 39);
		          v28 = _mm_shuffle_ps(v25, v25, 198);
		          v27.m128_f32[0] = v12.m128_f32[0];
		          v28.m128_f32[0] = _mm_shuffle_ps(v13, v13, 255).m128_f32[0];
		          v29 = _mm_shuffle_ps(v28, v28, 39);
		          v29.m128_f32[0] = v13.m128_f32[0];
		          *(__m128 *)&v7->_AtmosphereFogParams3.w = _mm_shuffle_ps(v29, v29, 57);
		          *(__m128 *)&v7->_AtmosphereFogParams2.w = _mm_shuffle_ps(v27, v27, 57);
		          return;
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D2AB0(v6, cb);
		  }
		  *(_OWORD *)&v7->_AtmosphereFogParams0.w = 0LL;
		  *(_OWORD *)&v7->_AtmosphereFogParams1.w = 0LL;
		  *(_OWORD *)&v7->_AtmosphereFogParams2.w = 0LL;
		  *(_OWORD *)&v7->_AtmosphereFogParams3.w = 0LL;
		}
		
		private void _SetWindMotorParams(ref ShaderVariablesGlobal cb, int index, HGWindMotorData motorData, Vector3 position, Vector2 direction, float windTime) {} // 0x00000001832DFCF0-0x00000001832E0020
		// Void _SetWindMotorParams(ShaderVariablesGlobal ByRef, Int32, HGWindMotorData, Vector3, Vector2, Single)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetWindMotorParams(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t index,
		        HGWindMotorData *motorData,
		        Vector3 *position,
		        Vector2 direction,
		        float windTime,
		        MethodInfo *method)
		{
		  float v8; // xmm1_4
		  __int64 v10; // r14
		  struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int v15; // edi
		  unsigned __int32 v16; // xmm4_4
		  __int128 v17; // xmm5
		  float v18; // xmm3_4
		  float rangeIn; // xmm7_4
		  float x; // xmm8_4
		  float y; // xmm10_4
		  float v22; // xmm9_4
		  __int64 v23; // rax
		  __int128 v24; // xmm0
		  char v25; // r15
		  BOOL rectBackward; // ecx
		  float v27; // xmm1_4
		  float v28; // xmm11_4
		  float v29; // xmm0_4
		  float v30; // xmm2_4
		  __int64 i; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // r10
		  __int128 v33; // xmm1
		  float distanceToCamera; // eax
		  float z; // ecx
		  __int128 v36; // xmm0
		  __int128 v37; // xmm0
		  __int128 v38; // [rsp+50h] [rbp-89h] BYREF
		  HGWindMotorData v39; // [rsp+60h] [rbp-79h] BYREF
		
		  v10 = index;
		  v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v11->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size <= 929 )
		    goto LABEL_5;
		  if ( !v11->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v11);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11->static_fields->wrapperArray;
		  if ( !v11 )
		LABEL_20:
		    sub_1800D8260(v11, wrapperArray);
		  if ( LODWORD(v11->_0.namespaze) <= 0x3A1 )
		    sub_1800D2AB0(v11, wrapperArray);
		  if ( v11[19].vtable.Equals.method )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(929, 0LL);
		    if ( Patch )
		    {
		      v33 = *(_OWORD *)&motorData->width;
		      distanceToCamera = motorData->distanceToCamera;
		      z = position->z;
		      *(_QWORD *)&v38 = *(_QWORD *)&position->x;
		      v36 = *(_OWORD *)&motorData->windPriority;
		      v39.distanceToCamera = distanceToCamera;
		      *(_OWORD *)&v39.width = v33;
		      *(_OWORD *)&v39.windPriority = v36;
		      v37 = *(_OWORD *)&motorData->angle;
		      *((float *)&v38 + 2) = z;
		      *(_OWORD *)&v39.angle = v37;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_372(
		        Patch,
		        (Object *)this,
		        cb,
		        v10,
		        &v39,
		        (Vector3 *)&v38,
		        direction,
		        windTime,
		        0LL);
		      return;
		    }
		    goto LABEL_20;
		  }
		LABEL_5:
		  v15 = 0;
		  v16 = 0;
		  LODWORD(v17) = 0;
		  v18 = 0.0;
		  rangeIn = 0.0;
		  x = position->x;
		  y = position->y;
		  v22 = position->z;
		  v23 = HIDWORD(*(_QWORD *)&motorData->windPriority);
		  v38 = 0LL;
		  if ( !(_DWORD)v23 )
		  {
		    v24 = *(_OWORD *)&motorData->angle;
		    if ( *(float *)&v24 <= 180.0 )
		    {
		      v25 = 0;
		      Beyond::DampingMath::cosf((Beyond::DampingMath *)v11, v8);
		      *(float *)&v17 = (float)(*(float *)&v24 * 0.017453292) * 0.5;
		    }
		    else
		    {
		      LODWORD(v17) = -1073741824;
		      v25 = 1;
		    }
		    v18 = motorData->windSpeed * 0.25;
		    v16 = _mm_shuffle_ps(*(__m128 *)&motorData->width, *(__m128 *)&motorData->width, 255).m128_u32[0];
		    LODWORD(rangeIn) = _mm_shuffle_ps(*(__m128 *)&motorData->windPriority, *(__m128 *)&motorData->windPriority, 170).m128_u32[0];
		    rectBackward = v25 != 0;
		    goto LABEL_9;
		  }
		  if ( (_DWORD)v23 == 1 )
		  {
		    v17 = *(_OWORD *)&motorData->width;
		    v18 = motorData->windSpeed * 0.25;
		    rangeIn = motorData->rangeIn;
		    v16 = _mm_shuffle_ps(*(__m128 *)&motorData->windPriority, *(__m128 *)&motorData->windPriority, 255).m128_u32[0];
		    rectBackward = motorData->rectBackward;
		LABEL_9:
		    v27 = direction.x;
		    v28 = direction.y;
		    v29 = (float)rectBackward;
		    v30 = (float)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&motorData->angle, 8));
		    goto LABEL_10;
		  }
		  v29 = *((float *)&v38 + 3);
		  v30 = *((float *)&v38 + 2);
		  v28 = *((float *)&v38 + 1);
		  v27 = *(float *)&v38;
		LABEL_10:
		  for ( i = 0LL; ; ++i )
		  {
		    while ( 1 )
		    {
		      while ( !v15 )
		      {
		        *(&cb->_AtmosphereFogParams5.w + 4 * v10 + i) = x;
		        *((_DWORD *)&cb->_ExponentialFogParams3.w + 4 * v10 + i) = v16;
		        v15 = 1;
		        *(&cb->_VolumetricFogParams1.w + 4 * v10 + i++) = v27;
		      }
		      if ( v15 != 1 )
		        break;
		      *(&cb->_AtmosphereFogParams5.w + 4 * v10 + i) = y;
		      *((_DWORD *)&cb->_ExponentialFogParams3.w + 4 * v10 + i) = v17;
		      v15 = 2;
		      *(&cb->_VolumetricFogParams1.w + 4 * v10 + i++) = v28;
		    }
		    if ( v15 != 2 )
		      break;
		    *(&cb->_AtmosphereFogParams5.w + 4 * v10 + i) = v22;
		    *(&cb->_ExponentialFogParams3.w + 4 * v10 + i) = v18;
		    v15 = 3;
		    *(&cb->_VolumetricFogParams1.w + 4 * v10 + i) = v30;
		  }
		  *((_DWORD *)&cb->_AtmosphereFogParams5.w + 4 * v10 + i) = LODWORD(motorData->height);
		  *(&cb->_ExponentialFogParams3.w + 4 * v10 + i) = rangeIn;
		  *(&cb->_VolumetricFogParams1.w + 4 * v10 + i) = v29;
		  *(&cb->_HeightFogFlowNoiseParams0.w + 4 * (int)v10) = (float)(int)HIDWORD(*(_QWORD *)&motorData->windPriority);
		  *(&cb->_HeightFogFlowNoiseParams1.x + 4 * (int)v10) = windTime;
		}
		
		private void _SetLastWindMotorParams(ref ShaderVariablesGlobal cb, int index, HGWindMotorData lastMotorData, Vector3 lastPosition, Vector2 lastDirection, float lastWindTime) {} // 0x00000001832DFA70-0x00000001832DFCF0
		// Void _SetLastWindMotorParams(ShaderVariablesGlobal ByRef, Int32, HGWindMotorData, Vector3, Vector2, Single)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SetLastWindMotorParams(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t index,
		        HGWindMotorData *lastMotorData,
		        Vector3 *lastPosition,
		        Vector2 lastDirection,
		        float lastWindTime,
		        MethodInfo *method)
		{
		  float v8; // xmm1_4
		  __int64 v10; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  unsigned __int32 v15; // xmm4_4
		  float x; // xmm8_4
		  __int128 v17; // xmm5
		  float y; // xmm10_4
		  float v19; // xmm3_4
		  float v20; // xmm9_4
		  float rangeIn; // xmm7_4
		  __int64 v22; // rax
		  __int128 v23; // xmm0
		  __m128 v24; // xmm4
		  int v25; // ecx
		  __int64 i; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v28; // xmm1
		  float z; // ecx
		  __int128 v30; // xmm0
		  __int128 v31; // xmm0
		  Vector3 v32; // [rsp+50h] [rbp-69h] BYREF
		  HGWindMotorData v33; // [rsp+60h] [rbp-59h] BYREF
		
		  v10 = index;
		  v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v11->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_21;
		  if ( wrapperArray->max_length.size <= 928 )
		    goto LABEL_5;
		  if ( !v11->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v11);
		    v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = (struct ILFixDynamicMethodWrapper_2__Class *)v11->static_fields->wrapperArray;
		  if ( !v11 )
		LABEL_21:
		    sub_1800D8260(v11, wrapperArray);
		  if ( LODWORD(v11->_0.namespaze) <= 0x3A0 )
		    sub_1800D2AB0(v11, wrapperArray);
		  if ( v11[19].vtable.Equals.methodPtr )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(928, 0LL);
		    if ( Patch )
		    {
		      v28 = *(_OWORD *)&lastMotorData->width;
		      v33.distanceToCamera = lastMotorData->distanceToCamera;
		      z = lastPosition->z;
		      *(_QWORD *)&v32.x = *(_QWORD *)&lastPosition->x;
		      v30 = *(_OWORD *)&lastMotorData->windPriority;
		      v32.z = z;
		      *(_OWORD *)&v33.windPriority = v30;
		      v31 = *(_OWORD *)&lastMotorData->angle;
		      *(_OWORD *)&v33.width = v28;
		      *(_OWORD *)&v33.angle = v31;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_372(
		        Patch,
		        (Object *)this,
		        cb,
		        v10,
		        &v33,
		        &v32,
		        lastDirection,
		        lastWindTime,
		        0LL);
		      return;
		    }
		    goto LABEL_21;
		  }
		LABEL_5:
		  v15 = 0;
		  x = lastPosition->x;
		  LODWORD(v17) = 0;
		  y = lastPosition->y;
		  v19 = 0.0;
		  v20 = lastPosition->z;
		  rangeIn = 0.0;
		  v22 = HIDWORD(*(_QWORD *)&lastMotorData->windPriority);
		  if ( !(_DWORD)v22 )
		  {
		    v23 = *(_OWORD *)&lastMotorData->angle;
		    if ( *(float *)&v23 <= 180.0 )
		    {
		      Beyond::DampingMath::cosf((Beyond::DampingMath *)v11, v8);
		      *(float *)&v17 = (float)(*(float *)&v23 * 0.017453292) * 0.5;
		    }
		    else
		    {
		      LODWORD(v17) = -1073741824;
		    }
		    v24 = *(__m128 *)&lastMotorData->width;
		    LODWORD(rangeIn) = _mm_shuffle_ps(
		                         *(__m128 *)&lastMotorData->windPriority,
		                         *(__m128 *)&lastMotorData->windPriority,
		                         170).m128_u32[0];
		    goto LABEL_9;
		  }
		  if ( (_DWORD)v22 == 1 )
		  {
		    rangeIn = lastMotorData->rangeIn;
		    v24 = *(__m128 *)&lastMotorData->windPriority;
		    v17 = *(_OWORD *)&lastMotorData->width;
		LABEL_9:
		    v19 = lastMotorData->windSpeed * 0.25;
		    v15 = _mm_shuffle_ps(v24, v24, 255).m128_u32[0];
		  }
		  v25 = 0;
		  for ( i = 0LL; ; ++i )
		  {
		    while ( 1 )
		    {
		      while ( !v25 )
		      {
		        *(&cb->_CloudShadowParams1.w + 4 * v10 + i) = x;
		        v25 = 1;
		        *((_DWORD *)&cb->_Style_MatFarAlb0.w + 4 * v10 + i++) = v15;
		      }
		      if ( v25 != 1 )
		        break;
		      *(&cb->_CloudShadowParams1.w + 4 * v10 + i) = y;
		      v25 = 2;
		      *((_DWORD *)&cb->_Style_MatFarAlb0.w + 4 * v10 + i++) = v17;
		    }
		    if ( v25 != 2 )
		      break;
		    *(&cb->_CloudShadowParams1.w + 4 * v10 + i) = v20;
		    v25 = 3;
		    *(&cb->_Style_MatFarAlb0.w + 4 * v10 + i) = v19;
		  }
		  *((_DWORD *)&cb->_CloudShadowParams1.w + 4 * v10 + i) = LODWORD(lastMotorData->height);
		  *(&cb->_Style_MatFarAlb0.w + 4 * v10 + i) = rangeIn;
		  *(&cb->_Style_GbCoef.w + 4 * (int)v10) = (float)(int)HIDWORD(*(_QWORD *)&lastMotorData->windPriority);
		  *(&cb->_VFXParams0.x + 4 * (int)v10) = lastWindTime;
		}
		
		private void _SortWindMotorsForSingleCamera(Vector3 cameraPos) {} // 0x000000018344C630-0x000000018344CA00
		// Void _SortWindMotorsForSingleCamera(Vector3)
		void HG::Rendering::Runtime::HGWindSimpleManager::_SortWindMotorsForSingleCamera(
		        HGWindSimpleManager *this,
		        Vector3 *cameraPos,
		        MethodInfo *method)
		{
		  Vector3 *v4; // r14
		  void *v5; // rcx
		  __int64 v6; // r8
		  unsigned int i; // ebx
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *v9; // rdi
		  struct HGWindSimpleManager_c__Class *v10; // rcx
		  Comparison_1_HG_Rendering_Runtime_HGWindMotor_ *_9__30_0; // rbx
		  struct MethodInfo *v12; // rsi
		  Object *v13; // rdi
		  __int64 (__fastcall *v14)(Object *); // rax
		  __int64 v15; // rdi
		  void (__fastcall *v16)(__int64, Vector3 *); // rax
		  MethodInfo *v17; // r9
		  __int64 v18; // xmm1_8
		  float z; // ecx
		  __int64 v20; // xmm0_8
		  float v21; // eax
		  Vector3 *v22; // rax
		  __int64 v23; // r8
		  float v24; // ebp
		  __int64 v25; // rdi
		  struct Math__Class *v26; // rcx
		  __m128 v27; // xmm2
		  __m128d v28; // xmm3
		  double v29; // xmm0_8
		  float v30; // xmm0_4
		  Object__Array *items; // rbp
		  int32_t size; // r14d
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  Il2CppRGCTXData v34; // rax
		  Object *v35; // rsi
		  Comparison_1_Object_ *v36; // rax
		  HGRuntimeGrassQuery_Node *v37; // rdx
		  HGRuntimeGrassQuery_Node *v38; // r8
		  Int32__Array **v39; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v41; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v42; // rax
		  Vector3 *v43; // rax
		  __int64 v44; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-78h]
		  Vector3 v46; // [rsp+30h] [rbp-68h] BYREF
		  Vector3 v47; // [rsp+40h] [rbp-58h] BYREF
		  Vector3 v48; // [rsp+50h] [rbp-48h] BYREF
		  float v49[4]; // [rsp+60h] [rbp-38h]
		  Vector3 v50; // [rsp+70h] [rbp-28h] BYREF
		  Vector3 v51[2]; // [rsp+80h] [rbp-18h] BYREF
		
		  v4 = cameraPos;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **((_QWORD **)v5 + 23);
		  if ( !v6 )
		    goto LABEL_41;
		  if ( *(int *)(v6 + 24) > 919 )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    cameraPos = (Vector3 *)**((_QWORD **)v5 + 23);
		    if ( !cameraPos )
		      goto LABEL_41;
		    if ( LODWORD(cameraPos[2].x) <= 0x397 )
		LABEL_47:
		      sub_1800D2AB0(v5, cameraPos);
		    if ( *(_QWORD *)&cameraPos[615].y )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(919, 0LL);
		      if ( Patch )
		      {
		        v41 = *(_QWORD *)&v4->x;
		        v46.z = v4->z;
		        *(_QWORD *)&v46.x = v41;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, &v46, 0LL);
		        return;
		      }
		      goto LABEL_41;
		    }
		  }
		  for ( i = 0; ; ++i )
		  {
		    m_windMotors = this->fields.m_windMotors;
		    if ( !m_windMotors )
		      goto LABEL_41;
		    v9 = this->fields.m_windMotors;
		    if ( (signed int)i >= m_windMotors->fields._size )
		      break;
		    if ( i >= m_windMotors->fields._size )
		      goto LABEL_65;
		    cameraPos = (Vector3 *)m_windMotors->fields._items;
		    if ( !cameraPos )
		      goto LABEL_41;
		    if ( i >= LODWORD(cameraPos[2].x) )
		      goto LABEL_47;
		    v13 = (Object *)*((_QWORD *)&cameraPos[2].z + (int)i);
		    if ( !v13 )
		      goto LABEL_41;
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    cameraPos = (Vector3 *)**((_QWORD **)v5 + 23);
		    if ( !cameraPos )
		      goto LABEL_41;
		    if ( SLODWORD(cameraPos[2].x) <= 920 )
		      goto LABEL_21;
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (void *)**((_QWORD **)v5 + 23);
		    if ( !v5 )
		      goto LABEL_41;
		    if ( *((_DWORD *)v5 + 6) <= 0x398u )
		      goto LABEL_47;
		    if ( *((_QWORD *)v5 + 924) )
		    {
		      v42 = IFix::WrappersManagerImpl::GetPatch(920, 0LL);
		      if ( !v42 )
		        goto LABEL_41;
		      v43 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(&v50, v42, v13, 0LL);
		      v18 = *(_QWORD *)&v43->x;
		      z = v43->z;
		    }
		    else
		    {
		LABEL_21:
		      v14 = (__int64 (__fastcall *)(Object *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v14 = (__int64 (__fastcall *)(Object *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v14;
		      }
		      v15 = v14(v13);
		      if ( !v15 )
		        goto LABEL_41;
		      *(_QWORD *)&v46.x = 0LL;
		      v46.z = 0.0;
		      v16 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v16 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        if ( !v16 )
		        {
		          v44 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v44, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v16;
		      }
		      v16(v15, &v46);
		      v18 = *(_QWORD *)&v46.x;
		      z = v46.z;
		    }
		    v20 = *(_QWORD *)&v4->x;
		    v21 = v4->z;
		    v48.z = z;
		    *(_QWORD *)&v47.x = v20;
		    v47.z = v21;
		    *(_QWORD *)&v48.x = v18;
		    v22 = UnityEngine::Vector3::op_Subtraction(v51, &v48, &v47, v17);
		    v5 = this->fields.m_windMotors;
		    v24 = v22->z;
		    *(_QWORD *)v49 = *(_QWORD *)&v22->x;
		    if ( !v5 )
		      goto LABEL_41;
		    if ( i >= *((_DWORD *)v5 + 6) )
		LABEL_65:
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    v5 = (void *)*((_QWORD *)v5 + 2);
		    if ( !v5 )
		      goto LABEL_41;
		    if ( i >= *((_DWORD *)v5 + 6) )
		      goto LABEL_47;
		    v25 = *((_QWORD *)v5 + (int)i + 4);
		    if ( !v25 )
		      goto LABEL_41;
		    v26 = TypeInfo::System::Math;
		    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		    v27 = (__m128)LODWORD(v49[1]);
		    v27.m128_f32[0] = (float)((float)(v27.m128_f32[0] * v27.m128_f32[0]) + (float)(v49[0] * v49[0]))
		                    + (float)(v24 * v24);
		    v28 = _mm_cvtps_pd(v27);
		    if ( v28.m128d_f64[0] < 0.0 )
		      v29 = sub_1801D32D0(v26, cameraPos, v23);
		    else
		      *(_QWORD *)&v29 = *(_OWORD *)&_mm_sqrt_pd(v28);
		    v30 = v29;
		    *(float *)(v25 + 80) = v30;
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v10 = TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c);
		    v10 = TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c;
		  }
		  _9__30_0 = v10->static_fields->__9__30_0;
		  if ( _9__30_0 )
		    goto LABEL_11;
		  if ( !v10->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v10);
		    v10 = TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c;
		  }
		  v35 = (Object *)v10->static_fields->__9;
		  v36 = (Comparison_1_Object_ *)sub_1800368D0(TypeInfo::System::Comparison<HG::Rendering::Runtime::HGWindMotor>);
		  _9__30_0 = (Comparison_1_HG_Rendering_Runtime_HGWindMotor_ *)v36;
		  if ( !v36 )
		LABEL_41:
		    sub_1800D8260(v5, cameraPos);
		  System::Comparison<System::Object>::Comparison(
		    v36,
		    v35,
		    MethodInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c::__SortWindMotorsForSingleCamera_b__30_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c->static_fields->__9__30_0 = _9__30_0;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c->static_fields->__9__30_0,
		    v37,
		    v38,
		    v39,
		    methoda);
		LABEL_11:
		  v12 = MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Sort;
		  if ( v9->fields._size > 1 )
		  {
		    items = (Object__Array *)v9->fields._items;
		    size = v9->fields._size;
		    rgctx_data = MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Sort->klass->rgctx_data;
		    v34.rgctxDataDummy = rgctx_data[52].rgctxDataDummy;
		    if ( (*((_BYTE *)v34.rgctxDataDummy + 312) & 1) == 0 )
		      sub_1800360B0((const Il2CppRGCTXData)rgctx_data[52].rgctxDataDummy, cameraPos);
		    if ( !*((_DWORD *)v34.rgctxDataDummy + 56) )
		      ((void (__fastcall *)(_QWORD))il2cpp_runtime_class_init_1)((Il2CppRGCTXData)v34.rgctxDataDummy);
		    System::Collections::Generic::ArraySortHelper<System::Object>::Sort(
		      items,
		      0,
		      size,
		      (Comparison_1_Object_ *)_9__30_0,
		      (MethodInfo *)v12->klass->rgctx_data[51].rgctxDataDummy);
		  }
		  ++v9->fields._version;
		}
		
		private void _ClearShaderVariablesWindMotor(ref ShaderVariablesGlobal cb, int index) {} // 0x0000000183101D80-0x0000000183101F60
		// Void _ClearShaderVariablesWindMotor(ShaderVariablesGlobal ByRef, Int32)
		void HG::Rendering::Runtime::HGWindSimpleManager::_ClearShaderVariablesWindMotor(
		        HGWindSimpleManager *this,
		        ShaderVariablesGlobal *cb,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v5; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = index;
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 930 )
		  {
		LABEL_5:
		    *((_DWORD *)&cb->_AtmosphereFogParams5.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams3.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VolumetricFogParams1.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_HeightFogFlowNoiseParams0.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams0.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams4.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VolumetricFogParams2.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_HeightFogFlowNoiseParams1.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams0.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams4.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VolumetricFogParams2.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_HeightFogFlowNoiseParams1.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams0.z + 4 * v5) = 0;
		    *((_DWORD *)&cb->_ExponentialFogParams4.z + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VolumetricFogParams2.z + 4 * v5) = 0;
		    *((_DWORD *)&cb->_HeightFogFlowNoiseParams1.z + 4 * v5) = 0;
		    *((_DWORD *)&cb->_CloudShadowParams1.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_Style_MatFarAlb0.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_Style_GbCoef.w + 4 * v5) = 0;
		    *((_DWORD *)&cb->_CloudShadowParams2.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_Style_MatFarAlb1.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VFXParams0.x + 4 * v5) = 0;
		    *((_DWORD *)&cb->_CloudShadowParams2.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_Style_MatFarAlb1.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VFXParams0.y + 4 * v5) = 0;
		    *((_DWORD *)&cb->_CloudShadowParams2.z + 4 * v5) = 0;
		    *((_DWORD *)&cb->_Style_MatFarAlb1.z + 4 * v5) = 0;
		    *((_DWORD *)&cb->_VFXParams0.z + 4 * v5) = 0;
		    return;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x3A2 )
		    sub_1800D2AB0(v6, wrapperArray);
		  if ( !v6[19].vtable.Finalize.methodPtr )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(930, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, wrapperArray);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, (Object *)this, cb, v5, 0LL);
		}
		
		private void _CleanupInvalidCameraStates() {} // 0x000000018459C5F0-0x000000018459CB90
		// Void _CleanupInvalidCameraStates()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGWindSimpleManager::_CleanupInvalidCameraStates(
		        HGWindSimpleManager *this,
		        MethodInfo *method)
		{
		  HGWindSimpleManager *v2; // r15
		  __int64 v3; // rdx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rax
		  __int64 count; // rcx
		  List_1_System_Int32_ *m_validCameraIds; // rbx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Camera__Array *allCameras; // rdi
		  unsigned int i; // ebx
		  Object_1 *v11; // r13
		  List_1_System_Int32_ *v12; // rsi
		  unsigned int InstanceID; // eax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  List_1_System_Int32_ *m_keysToRemove; // rbx
		  Dictionary_2_TKey_TValue_KeyCollection_System_Object_System_Boolean_ *Keys; // rax
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  __int64 v19; // rcx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  Dictionary_2_System_Object_System_Boolean_ *dictionary; // rbx
		  __int64 v23; // rdx
		  signed __int64 right_low; // rcx
		  HGRuntimeGrassQuery_Node *left; // rdx
		  __int64 v26; // r8
		  __int64 v27; // rax
		  __int64 v28; // r9
		  int32_t v29; // edi
		  List_1_System_Int32_ *v30; // rbx
		  struct MethodInfo *v31; // rsi
		  List_1_System_Int32_ *v32; // rbx
		  struct MethodInfo *v33; // rsi
		  __int64 size; // rdx
		  List_1_System_Int32_ *v35; // r9
		  HGRuntimeGrassQuery_Node__Class *klass; // rtt
		  __int64 v37; // rax
		  __int64 z_low; // rdx
		  __int64 v39; // rdx
		  __int64 v40; // rdx
		  Dictionary_2_System_Int32_System_Object_ *v41; // rcx
		  Il2CppClass *v42; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  __int64 v46; // [rsp+0h] [rbp-A8h] BYREF
		  MethodInfo *v47; // [rsp+20h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v48; // [rsp+28h] [rbp-80h] BYREF
		  HGRuntimeGrassQuery_Node v49; // [rsp+30h] [rbp-78h] BYREF
		
		  v2 = this;
		  memset(&v49.fields.bounds.m_Center.z, 0, 48);
		  if ( IFix::WrappersManagerImpl::IsPatched(1703, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1703, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v45, v44);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else if ( v2->fields.m_windMainState )
		  {
		    m_windMainState = v2->fields.m_windMainState;
		    count = (unsigned int)m_windMainState->fields._count;
		    if ( (_DWORD)count != m_windMainState->fields._freeCount )
		    {
		      m_validCameraIds = v2->fields.m_validCameraIds;
		      if ( !m_validCameraIds )
		        sub_1800D8260(count, v3);
		      ++m_validCameraIds->fields._version;
		      m_validCameraIds->fields._size = 0;
		      allCameras = UnityEngine::Camera::get_allCameras(0LL);
		      for ( i = 0; ; ++i )
		      {
		        if ( !allCameras )
		          sub_1800D8260(v8, v7);
		        if ( (signed int)i >= allCameras->max_length.size )
		          break;
		        if ( i >= allCameras->max_length.size )
		          sub_1800D2AB0(v8, v7);
		        v11 = (Object_1 *)allCameras->vector[i];
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        }
		        if ( !UnityEngine::Object::CompareBaseObjects(v11, 0LL, 0LL) )
		        {
		          v12 = v2->fields.m_validCameraIds;
		          if ( i >= allCameras->max_length.size )
		            sub_1800D2AB0(v8, v7);
		          if ( !allCameras->vector[i] )
		            sub_1800D8260(v8, v7);
		          InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)allCameras->vector[i], 0LL);
		          if ( !v12 )
		            sub_1800D8260(v15, v14);
		          sub_183081250(v12, InstanceID, MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		      }
		      m_keysToRemove = v2->fields.m_keysToRemove;
		      if ( !m_keysToRemove )
		        sub_1800D8260(v8, v7);
		      ++m_keysToRemove->fields._version;
		      m_keysToRemove->fields._size = 0;
		      if ( !v2->fields.m_windMainState )
		        sub_1800D8260(v8, v7);
		      Keys = System::Collections::Generic::Dictionary<System::Object,bool>::get_Keys(
		               (Dictionary_2_System_Object_System_Boolean_ *)v2->fields.m_windMainState,
		               MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Keys);
		      if ( !Keys )
		        sub_1800D8260(v19, v18);
		      dictionary = Keys->fields._dictionary;
		      *(_OWORD *)&v49.monitor = 0LL;
		      v49.klass = (HGRuntimeGrassQuery_Node__Class *)dictionary;
		      sub_18002D1B0(&v49, v18, v20, v21, v47);
		      if ( !dictionary )
		        sub_1800D8260(right_low, v23);
		      HIDWORD(v49.monitor) = dictionary->fields._version;
		      LODWORD(v49.monitor) = 0;
		      v49.fields.bounds.m_Center.x = 0.0;
		      *(_OWORD *)&v49.fields.left = *(_OWORD *)&v49.klass;
		      v49.fields.grassInstanceBounds = *(Bounds__Array **)&v49.fields.bounds.m_Center.x;
		      v49.klass = 0LL;
		      v49.monitor = (MonitorData *)&v49.fields.left;
		      try
		      {
		LABEL_23:
		        left = v49.fields.left;
		        if ( !v49.fields.left )
		          sub_1800D8250(right_low, 0LL);
		        if ( HIDWORD(v49.fields.right) != HIDWORD(v49.fields.left->fields.parent) )
		          System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		        right_low = LODWORD(v49.fields.right);
		        while ( (unsigned int)right_low < LODWORD(v49.fields.left->fields.bounds.m_Extents.y) )
		        {
		          v26 = *(_QWORD *)&v49.fields.left->fields.bounds.m_Center.z;
		          v27 = (int)right_low;
		          right_low = (unsigned int)(right_low + 1);
		          LODWORD(v49.fields.right) = right_low;
		          if ( !v26 )
		            sub_1800D8250(right_low, v49.fields.left);
		          if ( (unsigned int)v27 >= *(_DWORD *)(v26 + 24) )
		            sub_1800D2AA0(right_low, v49.fields.left, v26);
		          v28 = v26 + 24 * v27;
		          if ( *(int *)(v28 + 32) >= 0 )
		          {
		            v29 = *(_DWORD *)(v28 + 40);
		            LODWORD(v49.fields.grassInstanceBounds) = v29;
		            v30 = v2->fields.m_validCameraIds;
		            if ( !v30 )
		              sub_1800D8250(right_low, v49.fields.left);
		            v31 = MethodInfo::System::Collections::Generic::List<int>::Contains;
		            if ( !v30->fields._size )
		              goto LABEL_35;
		            if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::List<int>::Contains->klass->rgctx_data[20].rgctxDataDummy
		                  + 4) )
		              (*(void (**)(void))MethodInfo::System::Collections::Generic::List<int>::Contains->klass->rgctx_data[20].rgctxDataDummy)();
		            if ( System::Collections::Generic::List<int>::IndexOf(
		                   v30,
		                   v29,
		                   (MethodInfo *)v31->klass->rgctx_data[20].rgctxDataDummy) == -1 )
		            {
		LABEL_35:
		              v32 = v2->fields.m_keysToRemove;
		              if ( !v32 )
		                sub_1800D8250(right_low, left);
		              v33 = MethodInfo::System::Collections::Generic::List<int>::Add;
		              ++v32->fields._version;
		              right_low = (signed __int64)v32->fields._items;
		              size = v32->fields._size;
		              if ( !right_low )
		                sub_1800D8250(0LL, size);
		              if ( (unsigned int)size < *(_DWORD *)(right_low + 24) )
		              {
		                v32->fields._size = size + 1;
		                if ( (unsigned int)size >= *(_DWORD *)(right_low + 24) )
		                  sub_1800D2AA0(right_low, size, v26);
		                *(_DWORD *)(right_low + 4 * size + 32) = v29;
		              }
		              else
		              {
		                if ( !*((_QWORD *)v33->klass->rgctx_data[11].rgctxDataDummy + 4) )
		                  (*(void (**)(void))v33->klass->rgctx_data[11].rgctxDataDummy)();
		                System::Collections::Generic::List<int>::AddWithResize(
		                  v32,
		                  v29,
		                  (MethodInfo *)v33->klass->rgctx_data[11].rgctxDataDummy);
		              }
		            }
		            goto LABEL_23;
		          }
		        }
		        LODWORD(v49.fields.right) = LODWORD(v49.fields.left->fields.bounds.m_Extents.y) + 1;
		        LODWORD(v49.fields.grassInstanceBounds) = 0;
		      }
		      catch ( Il2CppExceptionWrapper *v47 )
		      {
		        left = (HGRuntimeGrassQuery_Node *)&v46;
		        v49.klass = (HGRuntimeGrassQuery_Node__Class *)v47->methodPointer;
		        right_low = (signed __int64)v49.klass;
		        if ( v49.klass )
		          sub_18007E1E0(v49.klass);
		        v2 = this;
		      }
		      v35 = v2->fields.m_keysToRemove;
		      if ( !v35 )
		        sub_1800D8250(right_low, left);
		      *(_OWORD *)&v49.monitor = 0LL;
		      v49.klass = (HGRuntimeGrassQuery_Node__Class *)v35;
		      if ( dword_18F35FD08 )
		      {
		        left = (HGRuntimeGrassQuery_Node *)&qword_18F103690[(((unsigned __int64)&v49 >> 12) & 0x1FFFFF) >> 6];
		        _m_prefetchw(left);
		        do
		        {
		          right_low = (__int64)left->klass | (1LL << (((unsigned __int64)&v49 >> 12) & 0x3F));
		          klass = left->klass;
		        }
		        while ( klass != (HGRuntimeGrassQuery_Node__Class *)_InterlockedCompareExchange64(
		                                                              (volatile signed __int64 *)left,
		                                                              right_low,
		                                                              (signed __int64)left->klass) );
		      }
		      LODWORD(v49.monitor) = 0;
		      HIDWORD(v49.monitor) = v35->fields._version;
		      v49.fields.bounds.m_Center.x = 0.0;
		      *(_OWORD *)&v49.fields.bounds.m_Center.z = *(_OWORD *)&v49.klass;
		      v49.fields.parent = *(HGRuntimeGrassQuery_Node **)&v49.fields.bounds.m_Center.x;
		      v49.klass = 0LL;
		      v49.monitor = (MonitorData *)&v49.fields.bounds.m_Center.z;
		      try
		      {
		        while ( 1 )
		        {
		          v37 = *(_QWORD *)&v49.fields.bounds.m_Center.z;
		          if ( !*(_QWORD *)&v49.fields.bounds.m_Center.z )
		            sub_1800D8250(right_low, left);
		          z_low = LODWORD(v49.fields.bounds.m_Extents.z);
		          if ( LODWORD(v49.fields.bounds.m_Extents.z) != *(_DWORD *)(*(_QWORD *)&v49.fields.bounds.m_Center.z + 28LL)
		            || LODWORD(v49.fields.bounds.m_Extents.y) >= *(_DWORD *)(*(_QWORD *)&v49.fields.bounds.m_Center.z + 24LL) )
		          {
		            break;
		          }
		          v39 = *(_QWORD *)(*(_QWORD *)&v49.fields.bounds.m_Center.z + 16LL);
		          if ( !v39 )
		            sub_1800D8250(SLODWORD(v49.fields.bounds.m_Extents.y), 0LL);
		          if ( LODWORD(v49.fields.bounds.m_Extents.y) >= *(_DWORD *)(v39 + 24) )
		            sub_1800D2AA0(
		              SLODWORD(v49.fields.bounds.m_Extents.y),
		              v39,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
		          v40 = *(unsigned int *)(v39 + 4LL * SLODWORD(v49.fields.bounds.m_Extents.y) + 32);
		          LODWORD(v49.fields.parent) = v40;
		          ++LODWORD(v49.fields.bounds.m_Extents.y);
		          v41 = (Dictionary_2_System_Int32_System_Object_ *)v2->fields.m_windMainState;
		          if ( !v41 )
		            sub_1800D8250(0LL, v40);
		          System::Collections::Generic::Dictionary<int,System::Object>::Remove(
		            v41,
		            v40,
		            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Remove);
		        }
		        v42 = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext->klass;
		        if ( ((__int64)v42->vtable[0].methodPtr & 1) == 0 )
		        {
		          sub_1800360B0(v42, LODWORD(v49.fields.bounds.m_Extents.z));
		          z_low = LODWORD(v49.fields.bounds.m_Extents.z);
		          v37 = *(_QWORD *)&v49.fields.bounds.m_Center.z;
		        }
		        if ( !v37 )
		          sub_1800D8250(v42, z_low);
		        if ( (_DWORD)z_low != *(_DWORD *)(v37 + 28) )
		          System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		        LODWORD(v49.fields.bounds.m_Extents.y) = *(_DWORD *)(v37 + 24) + 1;
		        LODWORD(v49.fields.parent) = 0;
		      }
		      catch ( Il2CppExceptionWrapper *v48 )
		      {
		        v49.klass = (HGRuntimeGrassQuery_Node__Class *)v48->ex;
		        if ( v49.klass )
		          sub_18007E1E0(v49.klass);
		      }
		    }
		  }
		}
		
		public void Dispose() {} // 0x0000000189CF8414-0x0000000189CF849C
		// Void Dispose()
		void HG::Rendering::Runtime::HGWindSimpleManager::Dispose(HGWindSimpleManager *this, MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rcx
		  List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *m_windMotorState; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1706, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1706, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_windMotors = this->fields.m_windMotors;
		    if ( m_windMotors )
		      sub_183127A90(
		        m_windMotors,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Clear);
		    m_windMainState = this->fields.m_windMainState;
		    if ( m_windMainState )
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		        (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)m_windMainState,
		        MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Clear);
		    m_windMotorState = this->fields.m_windMotorState;
		    if ( m_windMotorState )
		      sub_183127A90(
		        m_windMotorState,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Clear);
		  }
		}
		
	}
}
