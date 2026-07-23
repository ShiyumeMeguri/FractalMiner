using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGCharacterHelper : MonoBehaviour, IComparable // TypeDefIndex: 38686
	{
		// Fields
		[NonSerialized]
		public List<CharacterRendererInfo> renderers; // 0x18
		[NonSerialized]
		public LODGroup m_LodGroup; // 0x20
		private List<Renderer> shadowProxyRenderers; // 0x28
		private LOD[] m_CachedLods; // 0x30
		[SerializeField]
		private int priority; // 0x38
		public bool m_EnableCastSelfShadow; // 0x3C
		public bool m_EnableCastHDPunctualLightShadow; // 0x3D
		[SerializeField]
		private float boundSizeOffset; // 0x40
		public List<HGCharacterShadowSphere> boneSpheres; // 0x48
		public List<HGCharacterShadowSphere> customBoneSpheres; // 0x50
		public bool enableSphereBasedBounds; // 0x58
		private Dictionary<Camera, Bounds> m_CameraBoundsMap; // 0x60
		private Dictionary<Camera, Bounds> m_CameraHDPLSBoundsMap; // 0x68
		private static readonly Plane[] s_FrustumPlanesCache; // 0x00
		private const int MAX_CAMERA_COUNT_FOR_CLEAN = 4; // Metadata: 0x02304092
		[NonSerialized]
		[HideInInspector]
		public Bounds bounds; // 0x70
		[NonSerialized]
		[HideInInspector]
		public Bounds hdplsBounds; // 0x88
		private const float BOUND_UPDATE_THRESHOLD = 0.02f; // Metadata: 0x02304093
		internal bool isBoundOverride; // 0xA0
		internal Bounds m_OverrideBound; // 0xA4
		internal HGCharacterShadowBoundOverride m_OverrideSource; // 0xC0
	
		// Properties
		public bool enableCastSelfShadow { get => default; set {} } // 0x00000001834522C0-0x0000000183452320 0x0000000189C44F38-0x0000000189C44FA8
		// Boolean get_enableCastSelfShadow()
		bool HG::Rendering::Runtime::HGCharacterHelper::get_enableCastSelfShadow(HGCharacterHelper *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 4125 )
		    return this->fields.m_EnableCastSelfShadow;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x101D )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[87].vtable.Equals.method )
		    return this->fields.m_EnableCastSelfShadow;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4125, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_enableCastSelfShadow(Boolean)
		void HG::Rendering::Runtime::HGCharacterHelper::set_enableCastSelfShadow(
		        HGCharacterHelper *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4126, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4126, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else if ( this->fields.m_EnableCastSelfShadow != value )
		  {
		    this->fields.m_EnableCastSelfShadow = value;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    HG::Rendering::Runtime::HGCharacters::SortAndRebuild(0LL);
		  }
		}
		
		public bool enableCastHDPunctualLightShadow { get => default; set {} } // 0x0000000183452320-0x0000000183452380 0x0000000189C44EC8-0x0000000189C44F38
		// Boolean get_enableCastHDPunctualLightShadow()
		bool HG::Rendering::Runtime::HGCharacterHelper::get_enableCastHDPunctualLightShadow(
		        HGCharacterHelper *this,
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
		  if ( wrapperArray->max_length.size <= 4129 )
		    return this->fields.m_EnableCastHDPunctualLightShadow;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1021 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[87].vtable.GetHashCode.method )
		    return this->fields.m_EnableCastHDPunctualLightShadow;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4129, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_enableCastHDPunctualLightShadow(Boolean)
		void HG::Rendering::Runtime::HGCharacterHelper::set_enableCastHDPunctualLightShadow(
		        HGCharacterHelper *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4132, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4132, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else if ( this->fields.m_EnableCastHDPunctualLightShadow != value )
		  {
		    this->fields.m_EnableCastHDPunctualLightShadow = value;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    HG::Rendering::Runtime::HGCharacters::SortAndRebuild(0LL);
		  }
		}
		
		public short id { get => default; } // 0x0000000183A48820-0x0000000183A489D0 
		// Int16 get_id()
		int16_t HG::Rendering::Runtime::HGCharacterHelper::get_id(HGCharacterHelper *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  List_1_System_Object_ **static_fields; // rdx
		  List_1_System_Object_ *m_SelfShadowCharacterHelpers; // rcx
		  struct Object_1__Class *v6; // rcx
		  List_1_System_Object_ *v8; // r8
		  int32_t v9; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  List_1_System_Object___Class *klass; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (List_1_System_Object_ **)v2->static_fields;
		  m_SelfShadowCharacterHelpers = *static_fields;
		  if ( !*static_fields )
		    goto LABEL_24;
		  if ( m_SelfShadowCharacterHelpers->fields._size > 2113 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (List_1_System_Object_ **)v2->static_fields;
		    v8 = *static_fields;
		    if ( !*static_fields )
		      goto LABEL_24;
		    if ( v8->fields._size <= 0x841u )
		      goto LABEL_41;
		    if ( v8[423].fields._items )
		    {
		      v9 = 2113;
		LABEL_33:
		      Patch = IFix::WrappersManagerImpl::GetPatch(v9, 0LL);
		      if ( !Patch )
		        goto LABEL_24;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v2->static_fields;
		  static_fields = (List_1_System_Object_ **)m_SelfShadowCharacterHelpers->klass;
		  if ( !m_SelfShadowCharacterHelpers->klass )
		    goto LABEL_24;
		  if ( *((int *)static_fields + 6) <= 2114 )
		    goto LABEL_11;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v2->static_fields;
		  klass = m_SelfShadowCharacterHelpers->klass;
		  if ( !m_SelfShadowCharacterHelpers->klass )
		    goto LABEL_24;
		  if ( LODWORD(klass->_0.namespaze) <= 0x842 )
		LABEL_41:
		    sub_1800D2AB0(m_SelfShadowCharacterHelpers, static_fields);
		  if ( klass[19].vtable.get_Item.methodPtr )
		  {
		    v9 = 2114;
		    goto LABEL_33;
		  }
		LABEL_11:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  if ( TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_SelfShadowCharacterHelpers )
		  {
		    v6 = TypeInfo::UnityEngine::Object;
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
		    if ( this )
		    {
		      if ( !v6->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v6);
		      if ( this->fields._._._._.m_CachedPtr )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_SelfShadowCharacterHelpers;
		        if ( m_SelfShadowCharacterHelpers )
		          return System::Collections::Generic::List<System::Object>::IndexOf(
		                   m_SelfShadowCharacterHelpers,
		                   (Object *)this,
		                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::IndexOf);
		LABEL_24:
		        sub_1800D8260(m_SelfShadowCharacterHelpers, static_fields);
		      }
		    }
		  }
		  return -1;
		}
		
		public Bounds overrideBound { get => default; } // 0x0000000189C44E4C-0x0000000189C44EC8 
		// Bounds get_overrideBound()
		Bounds *HG::Rendering::Runtime::HGCharacterHelper::get_overrideBound(
		        Bounds *__return_ptr retstr,
		        HGCharacterHelper *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  __int64 v6; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Bounds *v10; // rax
		  Bounds *result; // rax
		  Bounds v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2110, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2110, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(&v12, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v10->m_Center.x;
		    v6 = *(_QWORD *)&v10->m_Extents.y;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_OverrideBound.m_Center.x;
		    v6 = *(_QWORD *)&this->fields.m_OverrideBound.m_Extents.y;
		  }
		  *(_OWORD *)&retstr->m_Center.x = v5;
		  result = retstr;
		  *(_QWORD *)&retstr->m_Extents.y = v6;
		  return result;
		}
		
	
		// Nested types
		[Serializable]
		public struct HGCharacterShadowSphere // TypeDefIndex: 38684
		{
			// Fields
			public Transform rootTransform; // 0x00
			public float radius; // 0x08
			public Vector3 localOffset; // 0x0C
		}
	
		public struct CharacterRendererInfo // TypeDefIndex: 38685
		{
			// Fields
			public Renderer renderer; // 0x00
			public bool inLodGroup; // 0x08
			public bool castSelfShadow; // 0x09
		}
	
		// Constructors
		public HGCharacterHelper() {} // 0x0000000184436150-0x00000001844362D0
		// HGCharacterHelper()
		void HG::Rendering::Runtime::HGCharacterHelper::HGCharacterHelper(HGCharacterHelper *this, MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_UnityEngine_Renderer_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  LowLevelList_1_System_Object_ *v15; // rax
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  LowLevelList_1_System_Object_ *v20; // rax
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *v21; // rdi
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v25; // rax
		  Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *v26; // rdi
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v30; // rax
		  Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *v31; // rdi
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		
		  v3 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::CharacterRendererInfo>);
		  v6 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *)v3;
		  if ( !v3 )
		    goto LABEL_9;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::CharacterRendererInfo>::List);
		  this->fields.renderers = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.renderers, v7, v8, v9, v35);
		  v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
		  v11 = (List_1_UnityEngine_Renderer_ *)v10;
		  if ( !v10 )
		    goto LABEL_9;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List);
		  this->fields.shadowProxyRenderers = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowProxyRenderers, v12, v13, v14, v36);
		  *(_WORD *)&this->fields.m_EnableCastSelfShadow = 257;
		  v15 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>);
		  v16 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *)v15;
		  if ( !v15 )
		    goto LABEL_9;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v15,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::List);
		  this->fields.boneSpheres = v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.boneSpheres, v17, v18, v19, v37);
		  v20 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>);
		  v21 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *)v20;
		  if ( !v20 )
		    goto LABEL_9;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v20,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::List);
		  this->fields.customBoneSpheres = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.customBoneSpheres, v22, v23, v24, v38);
		  v25 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>);
		  v26 = (Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *)v25;
		  if ( !v25
		    || (System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
		          v25,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::Dictionary),
		        this->fields.m_CameraBoundsMap = v26,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CameraBoundsMap, v27, v28, v29, v39),
		        v30 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>),
		        (v31 = (Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *)v30) == 0LL) )
		  {
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
		    v30,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::Dictionary);
		  this->fields.m_CameraHDPLSBoundsMap = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CameraHDPLSBoundsMap, v32, v33, v34, v40);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
		static HGCharacterHelper() {} // 0x0000000184D7A590-0x0000000184D7A5D0
		// HGCharacterHelper()
		void HG::Rendering::Runtime::HGCharacterHelper::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGCharacterHelper->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGCharacterHelper->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Methods
		public int GetShadowProxyEntities(NativeArray<Entity> outEntities) => default; // 0x0000000189C44910-0x0000000189C44A3C
		// Int32 GetShadowProxyEntities(NativeArray`1[UnityEngine.HyperGryph.ECS.Entity])
		int32_t HG::Rendering::Runtime::HGCharacterHelper::GetShadowProxyEntities(
		        HGCharacterHelper *this,
		        NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *outEntities,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Void *m_Buffer; // rcx
		  int32_t v7; // edi
		  int32_t v8; // esi
		  __int64 v9; // r15
		  List_1_UnityEngine_Renderer_ *shadowProxyRenderers; // rax
		  Object *Item; // rbx
		  uint64_t entityID; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v15; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4123, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4123, 0LL);
		    if ( !Patch )
		LABEL_13:
		      sub_1800D8260(m_Buffer, v5);
		    v15 = *outEntities;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1456(Patch, (Object *)this, &v15, 0LL);
		  }
		  else
		  {
		    v7 = 0;
		    v8 = 0;
		    v9 = 0LL;
		    while ( 1 )
		    {
		      shadowProxyRenderers = this->fields.shadowProxyRenderers;
		      if ( !shadowProxyRenderers )
		        goto LABEL_13;
		      if ( v8 >= shadowProxyRenderers->fields._size || v7 >= outEntities->m_Length )
		        return v7;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               (List_1_System_Object_ *)this->fields.shadowProxyRenderers,
		               v8,
		               MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Item);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL) )
		      {
		        if ( !Item )
		          goto LABEL_13;
		        if ( UnityEngine::Renderer::get_entityID((Renderer *)Item, 0LL) )
		        {
		          entityID = UnityEngine::Renderer::get_entityID((Renderer *)Item, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		          m_Buffer = outEntities->m_Buffer;
		          ++v7;
		          *(_QWORD *)&outEntities->m_Buffer[v9] = entityID;
		          v9 += 8LL;
		        }
		      }
		      ++v8;
		    }
		  }
		}
		
		public NativeArray<Entity> GetHDPLSShadowEntities(Camera camera) => default; // 0x000000018302CD20-0x000000018302D0E0
		// NativeArray`1[UnityEngine.HyperGryph.ECS.Entity] GetHDPLSShadowEntities(Camera)
		NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSShadowEntities(
		        NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *__return_ptr retstr,
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  unsigned int v4; // r12d
		  void *m_CachedLods; // rcx
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *renderers; // rdx
		  List_1_UnityEngine_Renderer_ *shadowProxyRenderers; // rax
		  struct MethodInfo *v11; // r15
		  __int64 size; // r14
		  Il2CppClass *klass; // rax
		  _QWORD *rgctxDataDummy; // rsi
		  __int64 v15; // rax
		  __int64 v16; // rcx
		  __int64 v17; // rax
		  unsigned int v18; // esi
		  __int64 (__fastcall *v19)(__int64, _QWORD, __int64, _QWORD); // rax
		  __int64 v20; // rdx
		  __int64 v21; // r13
		  Il2CppClass *v22; // rax
		  Il2CppRGCTXData v23; // rcx
		  void (__fastcall *v24)(__int64, _QWORD, __int64); // rax
		  unsigned int v25; // ebx
		  Void **v26; // r14
		  List_1_UnityEngine_Renderer_ *v27; // rax
		  __int64 v28; // rsi
		  __int64 (__fastcall *v29)(__int64); // rax
		  __int64 (__fastcall *v30)(__int64); // rax
		  __int64 v31; // rax
		  Void *v32; // rsi
		  struct MethodInfo *v33; // rbx
		  Il2CppClass *v34; // rax
		  Il2CppRGCTXData v35; // rcx
		  Il2CppClass *v36; // rcx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v39; // xmm0
		  __int64 v40; // rax
		  __int64 v41; // rax
		  __int64 v42; // rax
		  __int64 v43; // rax
		  Object_1 *m_LodGroup; // rsi
		  __int64 v45; // rdi
		  Void *m_Buffer; // r14
		  unsigned int i; // ebx
		  Renderer *v48; // rsi
		  uint64_t entityID; // rax
		  Void *v50; // rsi
		  Void *v51; // r14
		  int32_t j; // esi
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *v53; // rax
		  Void *v54; // rbx
		  uint64_t v55; // rax
		  Void *v56; // rbx
		  int32_t lodIndex; // [rsp+30h] [rbp-40h] BYREF
		  float fadeValue; // [rsp+34h] [rbp-3Ch] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v59; // [rsp+38h] [rbp-38h]
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v60; // [rsp+48h] [rbp-28h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v61; // [rsp+58h] [rbp-18h] BYREF
		
		  v4 = 0;
		  m_CachedLods = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  lodIndex = 0;
		  fadeValue = 0.0;
		  v60 = 0LL;
		  v61 = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_CachedLods = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  renderers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *)**((_QWORD **)m_CachedLods + 23);
		  if ( !renderers )
		    goto LABEL_49;
		  if ( renderers->fields._size > 4124 )
		  {
		    if ( !*((_DWORD *)m_CachedLods + 56) )
		    {
		      il2cpp_runtime_class_init_1(m_CachedLods);
		      m_CachedLods = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    renderers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *)**((_QWORD **)m_CachedLods + 23);
		    if ( !renderers )
		      goto LABEL_49;
		    if ( renderers->fields._size <= 0x101Cu )
		LABEL_52:
		      sub_1800D2AB0(m_CachedLods, renderers);
		    if ( *(_QWORD *)&renderers[825].fields._size )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(4124, 0LL);
		      if ( Patch )
		      {
		        v39 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1457(&v61, Patch, (Object *)this, (Object *)camera, 0LL);
		LABEL_109:
		        *retstr = v39;
		        return retstr;
		      }
		      goto LABEL_49;
		    }
		  }
		  if ( !this->fields.shadowProxyRenderers
		    || (shadowProxyRenderers = this->fields.shadowProxyRenderers, shadowProxyRenderers->fields._size <= 0) )
		  {
		    m_LodGroup = (Object_1 *)this->fields.m_LodGroup;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_LodGroup, 0LL, 0LL)
		      && this->fields.m_CachedLods
		      && this->fields.m_CachedLods->max_length.value )
		    {
		      m_CachedLods = this->fields.m_LodGroup;
		      if ( !m_CachedLods )
		        goto LABEL_49;
		      UnityEngine::LODGroup::CalculateLOD((LODGroup *)m_CachedLods, camera, &lodIndex, &fadeValue, 0LL);
		      if ( lodIndex < 0 )
		        goto LABEL_94;
		      m_CachedLods = this->fields.m_CachedLods;
		      if ( !m_CachedLods )
		        goto LABEL_49;
		      if ( lodIndex >= *((_DWORD *)m_CachedLods + 6) )
		      {
		LABEL_94:
		        *retstr = 0LL;
		        Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray(
		          retstr,
		          0,
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray);
		        return retstr;
		      }
		      v45 = *(_QWORD *)(sub_180002100(m_CachedLods, lodIndex) + 8);
		      if ( v45 )
		      {
		        Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray(
		          &v60,
		          *(_DWORD *)(v45 + 24),
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray);
		        m_Buffer = v60.m_Buffer;
		        for ( i = 0; (signed int)i < *(_DWORD *)(v45 + 24); ++i )
		        {
		          if ( i >= *(_DWORD *)(v45 + 24) )
		            goto LABEL_52;
		          v48 = *(Renderer **)(v45 + 8LL * (int)i + 32);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality((Object_1 *)v48, 0LL, 0LL) )
		          {
		            if ( !v48 )
		              goto LABEL_49;
		            if ( UnityEngine::Renderer::get_entityID(v48, 0LL) )
		            {
		              entityID = UnityEngine::Renderer::get_entityID(v48, 0LL);
		              m_CachedLods = TypeInfo::UnityEngine::HyperGryph::ECS::Entity;
		              v50 = (Void *)entityID;
		              if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		              v59.m_Buffer = v50;
		              ++v4;
		              *(_QWORD *)m_Buffer = v50;
		              m_Buffer += 8;
		            }
		          }
		        }
		        Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray(
		          &v61,
		          &v60,
		          0,
		          v4,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray);
		        v39 = v61;
		        goto LABEL_109;
		      }
		    }
		    else
		    {
		      renderers = this->fields.renderers;
		      if ( renderers )
		      {
		        Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray(
		          &v61,
		          renderers->fields._size,
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray);
		        v51 = v61.m_Buffer;
		        for ( j = 0; ; ++j )
		        {
		          v53 = this->fields.renderers;
		          if ( !v53 )
		            goto LABEL_49;
		          if ( j >= v53->fields._size )
		            break;
		          System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		            (ObjectTranslator_LuaCSFunctionPtr *)&v60,
		            (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.renderers,
		            j,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::CharacterRendererInfo>::get_Item);
		          v54 = v60.m_Buffer;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality((Object_1 *)v54, 0LL, 0LL) )
		          {
		            if ( !v54 )
		              goto LABEL_49;
		            if ( UnityEngine::Renderer::get_entityID((Renderer *)v54, 0LL) )
		            {
		              v55 = UnityEngine::Renderer::get_entityID((Renderer *)v54, 0LL);
		              m_CachedLods = TypeInfo::UnityEngine::HyperGryph::ECS::Entity;
		              v56 = (Void *)v55;
		              if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		              v59.m_Buffer = v56;
		              ++v4;
		              *(_QWORD *)v51 = v56;
		              v51 += 8;
		            }
		          }
		        }
		        Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray(
		          &v60,
		          &v61,
		          0,
		          v4,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray);
		        v39 = v60;
		        goto LABEL_109;
		      }
		    }
		LABEL_49:
		    sub_1800D8260(m_CachedLods, renderers);
		  }
		  v11 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray;
		  size = shadowProxyRenderers->fields._size;
		  klass = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray->klass,
		      renderers);
		  rgctxDataDummy = klass->rgctx_data->rgctxDataDummy;
		  v15 = rgctxDataDummy[4];
		  if ( (*(_BYTE *)(v15 + 312) & 1) == 0 )
		    sub_1800360B0(rgctxDataDummy[4], renderers);
		  v16 = *(_QWORD *)(*(_QWORD *)(v15 + 192) + 16LL);
		  if ( !*(_QWORD *)(v16 + 56) )
		    sub_1800430B0(v16);
		  v17 = rgctxDataDummy[4];
		  if ( (*(_BYTE *)(v17 + 312) & 1) == 0 )
		    sub_1800360B0(rgctxDataDummy[4], renderers);
		  v18 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::AlignOf<Beyond::Gameplay::Factory::ECSVATFSM::VATFSMProcessor::VATFSMAudioData>(*(MethodInfo **)(*(_QWORD *)(v17 + 192) + 40LL));
		  v19 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))qword_18F36EF08;
		  if ( !qword_18F36EF08 )
		  {
		    v19 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))il2cpp_resolve_icall_1(
		                                                                      "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::M"
		                                                                      "allocTracked(System.Int64,System.Int32,Unity.Colle"
		                                                                      "ctions.Allocator,System.Int32)");
		    if ( !v19 )
		    {
		      v40 = sub_1802EE1B8(
		              "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MallocTracked(System.Int64,System.Int32,Unity.Collections"
		              ".Allocator,System.Int32)");
		      sub_18007E1B0(v40, 0LL);
		    }
		    qword_18F36EF08 = (__int64)v19;
		  }
		  v21 = v19(8 * size, v18, 2LL, 0LL);
		  v22 = v11->klass;
		  if ( ((__int64)v22->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v11->klass, v20);
		  v23.rgctxDataDummy = v22->rgctx_data[2].rgctxDataDummy;
		  if ( !*((_QWORD *)v23.rgctxDataDummy + 7) )
		    ((void (__fastcall *)(_QWORD))sub_1800430B0)((Il2CppRGCTXData)v23.rgctxDataDummy);
		  v24 = (void (__fastcall *)(__int64, _QWORD, __int64))qword_18F36EF38;
		  if ( !qword_18F36EF38 )
		  {
		    v24 = (void (__fastcall *)(__int64, _QWORD, __int64))il2cpp_resolve_icall_1(
		                                                           "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(Syste"
		                                                           "m.Void*,System.Byte,System.Int64)");
		    if ( !v24 )
		    {
		      v41 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System.Void*,System.Byte,System.Int64)");
		      sub_18007E1B0(v41, 0LL);
		    }
		    qword_18F36EF38 = (__int64)v24;
		  }
		  v24(v21, 0LL, 8 * size);
		  v25 = 0;
		  v26 = (Void **)v21;
		  while ( 1 )
		  {
		    v27 = this->fields.shadowProxyRenderers;
		    if ( !v27 )
		      goto LABEL_49;
		    if ( (signed int)v25 >= v27->fields._size )
		      break;
		    if ( v25 >= v27->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    m_CachedLods = v27->fields._items;
		    if ( !m_CachedLods )
		      goto LABEL_49;
		    if ( v25 >= *((_DWORD *)m_CachedLods + 6) )
		      goto LABEL_52;
		    v28 = *((_QWORD *)m_CachedLods + (int)v25 + 4);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    m_CachedLods = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( v28 )
		    {
		      m_CachedLods = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( *(_QWORD *)(v28 + 16) )
		      {
		        v29 = (__int64 (__fastcall *)(__int64))qword_18F36F508;
		        if ( !qword_18F36F508 )
		        {
		          v29 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.Renderer::get_entityID()");
		          if ( !v29 )
		          {
		            v42 = sub_1802EE1B8("UnityEngine.Renderer::get_entityID()");
		            sub_18007E1B0(v42, 0LL);
		          }
		          qword_18F36F508 = (__int64)v29;
		        }
		        if ( v29(v28) )
		        {
		          v30 = (__int64 (__fastcall *)(__int64))qword_18F36F508;
		          if ( !qword_18F36F508 )
		          {
		            v30 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.Renderer::get_entityID()");
		            if ( !v30 )
		            {
		              v43 = sub_1802EE1B8("UnityEngine.Renderer::get_entityID()");
		              sub_18007E1B0(v43, 0LL);
		            }
		            qword_18F36F508 = (__int64)v30;
		          }
		          v31 = v30(v28);
		          m_CachedLods = TypeInfo::UnityEngine::HyperGryph::ECS::Entity;
		          v32 = (Void *)v31;
		          if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		          v59.m_Buffer = v32;
		          ++v4;
		          *v26++ = v32;
		        }
		      }
		    }
		    ++v25;
		  }
		  v33 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray;
		  v34 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray->klass;
		  if ( ((__int64)v34->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetSubArray->klass,
		      renderers);
		  v35.rgctxDataDummy = v34->rgctx_data[2].rgctxDataDummy;
		  if ( !*((_QWORD *)v35.rgctxDataDummy + 7) )
		    ((void (__fastcall *)(_QWORD))sub_1800430B0)((Il2CppRGCTXData)v35.rgctxDataDummy);
		  v36 = v33->klass;
		  if ( ((__int64)v36->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v36, renderers);
		  v59.m_Buffer = (Void *)v21;
		  *(_QWORD *)&v59.m_Length = v4 | 0x100000000LL;
		  result = retstr;
		  *retstr = v59;
		  return result;
		}
		
		private void OnEnable() {} // 0x0000000183A48080-0x0000000183A48130
		// Void OnEnable()
		void HG::Rendering::Runtime::HGCharacterHelper::OnEnable(HGCharacterHelper *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4133, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4133, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::Runtime::HGCharacterHelper::FindRenderers(this, 0LL, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  HG::Rendering::Runtime::HGCharacters::EnqueueCharacter(this, 0LL);
		  v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		  v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v3;
		  if ( !v3 )
		    goto LABEL_8;
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v3,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering,
		    0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		  UnityEngine::Rendering::RenderPipelineManager::add_beginFrameRenderingNoAlloc(v6, 0LL);
		}
		
		public int CompareTo(object obj) => default; // 0x000000018389ED00-0x000000018389EDC0
		// Int32 CompareTo(Object)
		int32_t HG::Rendering::Runtime::HGCharacterHelper::CompareTo(HGCharacterHelper *this, Object *obj, MethodInfo *method)
		{
		  int32_t v5; // ebx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdi
		  int32_t priority; // eax
		  int32_t InstanceID; // esi
		  int32_t v12; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4145, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4145, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		               (ILFixDynamicMethodWrapper_17 *)Patch,
		               (Object *)this,
		               obj,
		               0LL);
		LABEL_11:
		    sub_1800D8260(v7, v6);
		  }
		  v5 = 1;
		  if ( !obj || !sub_180005050(obj, TypeInfo::HG::Rendering::Runtime::HGCharacterHelper) )
		    return v5;
		  v8 = sub_180005130(obj, TypeInfo::HG::Rendering::Runtime::HGCharacterHelper);
		  if ( !v8 )
		    goto LABEL_11;
		  priority = this->fields.priority;
		  if ( *(_DWORD *)(v8 + 56) < priority )
		    return -1;
		  if ( *(_DWORD *)(v8 + 56) > priority )
		    return v5;
		  InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		  v12 = UnityEngine::Object::GetInstanceID((Object_1 *)v8, 0LL);
		  if ( InstanceID < v12 )
		    return -1;
		  return InstanceID > v12;
		}
		
		public void SetPriority(int orderPriority) {} // 0x0000000189C44AF4-0x0000000189C44B60
		// Void SetPriority(Int32)
		void HG::Rendering::Runtime::HGCharacterHelper::SetPriority(
		        HGCharacterHelper *this,
		        int32_t orderPriority,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4146, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4146, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      orderPriority,
		      0LL);
		  }
		  else
		  {
		    this->fields.priority = orderPriority;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    HG::Rendering::Runtime::HGCharacters::SortAndRebuild(0LL);
		  }
		}
		
		[ContextMenu("FindRenderers")]
		public void FindRenderers(LODGroup lodGroup = null) {} // 0x00000001839C6600-0x00000001839C6A80
		// Void FindRenderers(LODGroup)
		void HG::Rendering::Runtime::HGCharacterHelper::FindRenderers(
		        HGCharacterHelper *this,
		        LODGroup *lodGroup,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  LODGroup *m_LodGroup; // rbx
		  GameObject *gameObject; // rax
		  Type *v10; // rdx
		  LODGroup *renderers; // rcx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  LOD__Array *v15; // r12
		  Object_1 *v16; // rbx
		  LOD__Array *LODs; // rdi
		  bool v18; // al
		  Component *v19; // rbx
		  GameObject *v20; // rax
		  Object__Array *v21; // r15
		  int32_t v22; // ebp
		  Object *v23; // rsi
		  bool v24; // r14
		  Object_1 *monitor; // rbx
		  char v26; // r13
		  int32_t i; // ebx
		  PropertyInfo_1 *v28; // r8
		  __int64 v29; // r9
		  Object_1 *v30; // rbx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  int16_t id; // ax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v34; // rax
		  List_1_UnityEngine_Renderer_ *v35; // rbx
		  Type *v36; // rdx
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SingleFieldAccessor v40; // [rsp+20h] [rbp-48h] BYREF
		
		  *(_OWORD *)&v40.klass = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4134, 0LL) )
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( lodGroup )
		    {
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( lodGroup->fields._._.m_CachedPtr )
		      {
		        this->fields.m_LodGroup = lodGroup;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_LodGroup, v5, v6, v7, (MethodInfo *)v40.klass);
		      }
		    }
		    m_LodGroup = this->fields.m_LodGroup;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_LodGroup )
		      goto LABEL_19;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_LodGroup->fields._._.m_CachedPtr )
		    {
		LABEL_19:
		      gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		      if ( !gameObject )
		        goto LABEL_65;
		      this->fields.m_LodGroup = (LODGroup *)UnityEngine::GameObject::GetComponent<System::Object>(
		                                              gameObject,
		                                              MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::LODGroup>);
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_LodGroup, v12, v13, v14, (MethodInfo *)v40.klass);
		    }
		    v15 = 0LL;
		    v16 = (Object_1 *)this->fields.m_LodGroup;
		    LODs = 0LL;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v18 = UnityEngine::Object::op_Implicit(v16, 0LL);
		    v19 = (Component *)this;
		    if ( v18 )
		    {
		      renderers = this->fields.m_LodGroup;
		      if ( !renderers )
		        goto LABEL_65;
		      LODs = UnityEngine::LODGroup::GetLODs(renderers, 1, 0LL);
		    }
		    renderers = (LODGroup *)this->fields.renderers;
		    if ( renderers )
		    {
		      sub_183E41B50(
		        renderers,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::CharacterRendererInfo>::Clear);
		      if ( this->fields.shadowProxyRenderers )
		      {
		        sub_183127A90(
		          this->fields.shadowProxyRenderers,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::Clear);
		      }
		      else
		      {
		        v34 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
		        v35 = (List_1_UnityEngine_Renderer_ *)v34;
		        if ( !v34 )
		          goto LABEL_65;
		        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v34,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List);
		        this->fields.shadowProxyRenderers = v35;
		        v19 = (Component *)this;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowProxyRenderers, v36, v37, v38, (MethodInfo *)v40.klass);
		      }
		      v20 = UnityEngine::Component::get_gameObject(v19, 0LL);
		      if ( v20 )
		      {
		        v21 = UnityEngine::GameObject::GetComponentsInChildren<System::Object>(
		                v20,
		                1,
		                MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Renderer>);
		        v22 = 0;
		        if ( v21 )
		        {
		          while ( v22 < v21->max_length.size )
		          {
		            if ( (unsigned int)v22 >= v21->max_length.size )
		LABEL_66:
		              sub_1800D2AB0(renderers, v10);
		            v23 = v21->vector[v22];
		            if ( !v23
		              || (struct ParticleSystemRenderer__Class *)v23->klass != TypeInfo::UnityEngine::ParticleSystemRenderer )
		            {
		              v24 = 0;
		              monitor = (Object_1 *)v19[1].monitor;
		              v26 = 1;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              if ( UnityEngine::Object::op_Implicit(monitor, 0LL) && LODs )
		              {
		                for ( i = 0; i < LODs->max_length.size; ++i )
		                {
		                  if ( !v24 )
		                  {
		                    if ( (unsigned int)i >= LODs->max_length.size )
		                      goto LABEL_66;
		                    v24 = System::Array::IndexOf<System::Object>(
		                            (Object__Array *)LODs->vector[i].renderers,
		                            v23,
		                            MethodInfo::System::Array::IndexOf<UnityEngine::Renderer>) >= 0;
		                  }
		                  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->_1.cctor_finished_or_no_cctor )
		                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
		                  renderers = (LODGroup *)TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->static_fields;
		                  if ( i >= SLODWORD(renderers->klass) )
		                  {
		                    if ( (unsigned int)i >= LODs->max_length.size )
		                      goto LABEL_66;
		                    if ( System::Array::IndexOf<System::Object>(
		                           (Object__Array *)LODs->vector[i].renderers,
		                           v23,
		                           MethodInfo::System::Array::IndexOf<UnityEngine::Renderer>) >= 0 )
		                    {
		                      v26 = 0;
		                      break;
		                    }
		                  }
		                }
		              }
		              if ( !v23 )
		                goto LABEL_65;
		              if ( UnityEngine::Renderer::get_shadowCastingMode((Renderer *)v23, 0LL) == ShadowCastingMode__Enum_ShadowsOnly
		                || UnityEngine::Renderer::get_shadowCastingMode((Renderer *)v23, 0LL) == ShadowCastingMode__Enum_ShadowsOnlyTwoSided )
		              {
		                v19 = (Component *)this;
		                renderers = (LODGroup *)this->fields.shadowProxyRenderers;
		                if ( !renderers )
		                  goto LABEL_65;
		                sub_182F01190((List_1_System_Object_ *)renderers, v23);
		              }
		              else
		              {
		                v19 = (Component *)this;
		                *(_OWORD *)&v40.klass = (unsigned __int64)v23;
		                ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		                  &v40,
		                  v10,
		                  v28,
		                  (Int32__Array **)this->fields.renderers);
		                LOBYTE(v40.monitor) = v24;
		                BYTE1(v40.monitor) = v26;
		                if ( !v29 )
		                  goto LABEL_65;
		                v40.fields._ = *(FieldAccessorBase__Fields *)&v40.klass;
		                sub_183C93B70(
		                  v29,
		                  &v40.fields,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::CharacterRendererInfo>::Add);
		              }
		            }
		            ++v22;
		          }
		          v30 = (Object_1 *)v19[1].monitor;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Implicit(v30, 0LL) )
		            goto LABEL_64;
		          renderers = this->fields.m_LodGroup;
		          if ( renderers )
		          {
		            v15 = UnityEngine::LODGroup::GetLODs(renderers, 1, 0LL);
		LABEL_64:
		            this->fields.m_CachedLods = v15;
		            sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CachedLods, v10, v31, v32, (MethodInfo *)v40.klass);
		            id = HG::Rendering::Runtime::HGCharacterHelper::get_id(this, 0LL);
		            HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(this, id, 0, 0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_65:
		    sub_1800D8260(renderers, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4134, 0LL);
		  if ( !Patch )
		    goto LABEL_65;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)lodGroup,
		    0LL);
		}
		
		internal void SetShadowBoundOverride(Bounds b, HGCharacterShadowBoundOverride source) {} // 0x0000000189C44B60-0x0000000189C44C10
		// Void SetShadowBoundOverride(Bounds, HGCharacterShadowBoundOverride)
		void HG::Rendering::Runtime::HGCharacterHelper::SetShadowBoundOverride(
		        HGCharacterHelper *this,
		        Bounds *b,
		        HGCharacterShadowBoundOverride *source,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  __int128 v10; // xmm0
		  __int64 v11; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // xmm1_8
		  MethodInfo *v16; // [rsp+20h] [rbp-38h]
		  Bounds v17; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4147, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4147, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    v15 = *(_QWORD *)&b->m_Extents.y;
		    *(_OWORD *)&v17.m_Center.x = *(_OWORD *)&b->m_Center.x;
		    *(_QWORD *)&v17.m_Extents.y = v15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1460(Patch, (Object *)this, &v17, (Object *)source, 0LL);
		  }
		  else
		  {
		    v10 = *(_OWORD *)&b->m_Center.x;
		    this->fields.isBoundOverride = 1;
		    v11 = *(_QWORD *)&b->m_Extents.y;
		    *(_OWORD *)&this->fields.m_OverrideBound.m_Center.x = v10;
		    this->fields.m_OverrideSource = source;
		    *(_QWORD *)&this->fields.m_OverrideBound.m_Extents.y = v11;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_OverrideSource, v7, v8, v9, v16);
		  }
		}
		
		internal void ClearShadowBoundOverride(HGCharacterShadowBoundOverride source) {} // 0x0000000189C44764-0x0000000189C44804
		// Void ClearShadowBoundOverride(HGCharacterShadowBoundOverride)
		void HG::Rendering::Runtime::HGCharacterHelper::ClearShadowBoundOverride(
		        HGCharacterHelper *this,
		        HGCharacterShadowBoundOverride *source,
		        MethodInfo *method)
		{
		  Object_1 *m_OverrideSource; // rbx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4148, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4148, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)source,
		      0LL);
		  }
		  else
		  {
		    m_OverrideSource = (Object_1 *)this->fields.m_OverrideSource;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(m_OverrideSource, (Object_1 *)source, 0LL) )
		    {
		      this->fields.m_OverrideSource = 0LL;
		      this->fields.isBoundOverride = 0;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_OverrideSource, v6, v7, v8, v12);
		    }
		  }
		}
		
		[IDTag(1)]
		public Bounds GetBounds() => default; // 0x0000000189C44804-0x0000000189C44894
		// Bounds GetBounds()
		Bounds *HG::Rendering::Runtime::HGCharacterHelper::GetBounds(
		        Bounds *__return_ptr retstr,
		        HGCharacterHelper *this,
		        MethodInfo *method)
		{
		  Bounds *overrideBound; // rax
		  __int128 v6; // xmm0
		  __int64 v7; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Bounds *result; // rax
		  Bounds v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4149, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4149, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    overrideBound = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(&v12, Patch, (Object *)this, 0LL);
		    goto LABEL_8;
		  }
		  if ( this->fields.isBoundOverride )
		  {
		    overrideBound = HG::Rendering::Runtime::HGCharacterHelper::get_overrideBound(&v12, this, 0LL);
		LABEL_8:
		    v6 = *(_OWORD *)&overrideBound->m_Center.x;
		    v7 = *(_QWORD *)&overrideBound->m_Extents.y;
		    goto LABEL_9;
		  }
		  v6 = *(_OWORD *)&this->fields.bounds.m_Center.x;
		  v7 = *(_QWORD *)&this->fields.bounds.m_Extents.y;
		LABEL_9:
		  *(_OWORD *)&retstr->m_Center.x = v6;
		  result = retstr;
		  *(_QWORD *)&retstr->m_Extents.y = v7;
		  return result;
		}
		
		[IDTag(1)]
		public Bounds GetHDPLSBounds() => default; // 0x0000000189C44894-0x0000000189C44910
		// Bounds GetHDPLSBounds()
		Bounds *HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSBounds(
		        Bounds *__return_ptr retstr,
		        HGCharacterHelper *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  __int64 v6; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Bounds *v10; // rax
		  Bounds *result; // rax
		  Bounds v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4150, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4150, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(&v12, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v10->m_Center.x;
		    v6 = *(_QWORD *)&v10->m_Extents.y;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.hdplsBounds.m_Center.x;
		    v6 = *(_QWORD *)&this->fields.hdplsBounds.m_Extents.y;
		  }
		  *(_OWORD *)&retstr->m_Center.x = v5;
		  result = retstr;
		  *(_QWORD *)&retstr->m_Extents.y = v6;
		  return result;
		}
		
		[IDTag(0)]
		public Bounds GetBounds(Camera camera) => default; // 0x0000000183B64220-0x0000000183B643C0
		// Bounds GetBounds(Camera)
		Bounds *HG::Rendering::Runtime::HGCharacterHelper::GetBounds(
		        Bounds *__return_ptr retstr,
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  _QWORD **v6; // rcx
		  Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *entries; // rdx
		  Dictionary_2_System_Object_UnityEngine_Bounds_ *m_CameraBoundsMap; // rsi
		  struct MethodInfo *v10; // r14
		  int32_t Entry; // eax
		  __int64 v12; // xmm1_8
		  Bounds *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds *overrideBound; // rax
		  Bounds v16; // [rsp+30h] [rbp-28h] BYREF
		
		  v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  entries = (Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *)*v6[23];
		  if ( !entries )
		    goto LABEL_20;
		  if ( entries->max_length.size > 2109 )
		  {
		    if ( !*((_DWORD *)v6 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    entries = (Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *)*v6[23];
		    if ( !entries )
		      goto LABEL_20;
		    if ( entries->max_length.size <= 0x83Du )
		LABEL_23:
		      sub_1800D2AB0(v6, entries);
		    if ( entries[12].vector[28].key )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2109, 0LL);
		      if ( !Patch )
		        goto LABEL_20;
		      overrideBound = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(
		                        &v16,
		                        Patch,
		                        (Object *)this,
		                        (Object *)camera,
		                        0LL);
		LABEL_32:
		      v12 = *(_QWORD *)&overrideBound->m_Extents.y;
		      *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&overrideBound->m_Center.x;
		      goto LABEL_18;
		    }
		  }
		  if ( this->fields.isBoundOverride )
		  {
		    overrideBound = HG::Rendering::Runtime::HGCharacterHelper::get_overrideBound(&v16, this, 0LL);
		    goto LABEL_32;
		  }
		  v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !camera )
		    goto LABEL_19;
		  if ( !*((_DWORD *)v6 + 56) )
		    il2cpp_runtime_class_init_1(v6);
		  if ( !camera->fields._._._.m_CachedPtr )
		    goto LABEL_19;
		  m_CameraBoundsMap = (Dictionary_2_System_Object_UnityEngine_Bounds_ *)this->fields.m_CameraBoundsMap;
		  if ( !m_CameraBoundsMap )
		    goto LABEL_20;
		  v10 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		        + 4) )
		    (*(void (__fastcall **)(const Il2CppRGCTXData *, Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *, Camera *, MethodInfo *))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)(
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data,
		      entries,
		      camera,
		      method);
		  Entry = System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::FindEntry(
		            m_CameraBoundsMap,
		            (Object *)camera,
		            (MethodInfo *)v10->klass->rgctx_data[22].rgctxDataDummy);
		  if ( Entry < 0 )
		  {
		LABEL_19:
		    v12 = *(_QWORD *)&this->fields.bounds.m_Extents.y;
		    *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&this->fields.bounds.m_Center.x;
		    goto LABEL_18;
		  }
		  entries = m_CameraBoundsMap->fields._entries;
		  if ( !entries )
		LABEL_20:
		    sub_1800D8260(v6, entries);
		  if ( (unsigned int)Entry >= entries->max_length.size )
		    goto LABEL_23;
		  v12 = *(_QWORD *)&entries->vector[Entry].value.m_Extents.y;
		  *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&entries->vector[Entry].value.m_Center.x;
		LABEL_18:
		  result = retstr;
		  *(_QWORD *)&retstr->m_Extents.y = v12;
		  return result;
		}
		
		[IDTag(0)]
		public Bounds GetHDPLSBounds(Camera camera) => default; // 0x0000000183B64090-0x0000000183B64220
		// Bounds GetHDPLSBounds(Camera)
		Bounds *HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSBounds(
		        Bounds *__return_ptr retstr,
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  _QWORD **v6; // rcx
		  Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *entries; // rdx
		  Dictionary_2_System_Object_UnityEngine_Bounds_ *m_CameraHDPLSBoundsMap; // rdi
		  struct MethodInfo *v10; // r14
		  int32_t Entry; // eax
		  __int64 v12; // xmm1_8
		  Bounds *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds *v15; // rax
		  Bounds v16; // [rsp+30h] [rbp-28h] BYREF
		
		  v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  entries = (Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *)*v6[23];
		  if ( !entries )
		    goto LABEL_19;
		  if ( entries->max_length.size > 2172 )
		  {
		    if ( !*((_DWORD *)v6 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    entries = (Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *)*v6[23];
		    if ( !entries )
		      goto LABEL_19;
		    if ( entries->max_length.size <= 0x87Cu )
		LABEL_22:
		      sub_1800D2AB0(v6, entries);
		    if ( *(_QWORD *)&entries[13].vector[8].hashCode )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2172, 0LL);
		      if ( Patch )
		      {
		        v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(&v16, Patch, (Object *)this, (Object *)camera, 0LL);
		        v12 = *(_QWORD *)&v15->m_Extents.y;
		        *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&v15->m_Center.x;
		        goto LABEL_17;
		      }
		      goto LABEL_19;
		    }
		  }
		  v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !camera )
		    goto LABEL_18;
		  if ( !*((_DWORD *)v6 + 56) )
		    il2cpp_runtime_class_init_1(v6);
		  if ( !camera->fields._._._.m_CachedPtr )
		    goto LABEL_18;
		  m_CameraHDPLSBoundsMap = (Dictionary_2_System_Object_UnityEngine_Bounds_ *)this->fields.m_CameraHDPLSBoundsMap;
		  if ( !m_CameraHDPLSBoundsMap )
		    goto LABEL_19;
		  v10 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		        + 4) )
		    (*(void (__fastcall **)(const Il2CppRGCTXData *, Dictionary_2_TKey_TValue_Entry_System_Object_UnityEngine_Bounds___Array *, Camera *, MethodInfo *))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)(
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data,
		      entries,
		      camera,
		      method);
		  Entry = System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::FindEntry(
		            m_CameraHDPLSBoundsMap,
		            (Object *)camera,
		            (MethodInfo *)v10->klass->rgctx_data[22].rgctxDataDummy);
		  if ( Entry < 0 )
		  {
		LABEL_18:
		    v12 = *(_QWORD *)&this->fields.hdplsBounds.m_Extents.y;
		    *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&this->fields.hdplsBounds.m_Center.x;
		    goto LABEL_17;
		  }
		  entries = m_CameraHDPLSBoundsMap->fields._entries;
		  if ( !entries )
		LABEL_19:
		    sub_1800D8260(v6, entries);
		  if ( (unsigned int)Entry >= entries->max_length.size )
		    goto LABEL_22;
		  v12 = *(_QWORD *)&entries->vector[Entry].value.m_Extents.y;
		  *(_OWORD *)&retstr->m_Center.x = *(_OWORD *)&entries->vector[Entry].value.m_Center.x;
		LABEL_17:
		  result = retstr;
		  *(_QWORD *)&retstr->m_Extents.y = v12;
		  return result;
		}
		
		private bool IsRendererVisible(Renderer renderer) => default; // 0x0000000182FAAA40-0x0000000182FAAC50
		// Boolean IsRendererVisible(Renderer)
		bool HG::Rendering::Runtime::HGCharacterHelper::IsRendererVisible(
		        HGCharacterHelper *this,
		        Renderer *renderer,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct Object_1__Class *v7; // rcx
		  unsigned __int8 (__fastcall *v8)(Renderer *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  __int64 (__fastcall *v9)(Renderer *); // rax
		  __int64 v10; // rdi
		  unsigned __int8 (__fastcall *v11)(__int64); // rax
		  struct HGCharacterHelper__Class *v12; // rax
		  HGCharacterHelper__StaticFields *static_fields; // rax
		  Plane__Array *s_FrustumPlanesCache; // rdi
		  void (__fastcall *v15)(Renderer *, __int128 *); // rax
		  __int64 (__fastcall *v16)(Plane__Array *, __int128 *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rax
		  __int64 v20; // rax
		  __int128 v21; // [rsp+20h] [rbp-48h] BYREF
		  __int64 v22; // [rsp+30h] [rbp-38h]
		  __int128 v23; // [rsp+40h] [rbp-28h] BYREF
		  __int64 v24; // [rsp+50h] [rbp-18h]
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_25;
		  if ( wrapperArray->max_length.size > 4139 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_25;
		    if ( LODWORD(v5->_0.namespaze) <= 0x102B )
		      sub_1800D2AB0(v5, wrapperArray);
		    if ( *((_QWORD *)&v5[88]._0.this_arg + 1) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(4139, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		                 (ILFixDynamicMethodWrapper_33 *)Patch,
		                 (Object *)this,
		                 (Object *)renderer,
		                 0LL);
		      goto LABEL_25;
		    }
		  }
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v7 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v7 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !renderer )
		    return 0;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v7);
		  if ( !renderer->fields._._.m_CachedPtr )
		    return 0;
		  v8 = (unsigned __int8 (__fastcall *)(Renderer *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36F4D0;
		  if ( !qword_18F36F4D0 )
		  {
		    v8 = (unsigned __int8 (__fastcall *)(Renderer *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Renderer::get_enabled()");
		    if ( !v8 )
		    {
		      v19 = sub_1802EE1B8("UnityEngine.Renderer::get_enabled()");
		      sub_18007E1B0(v19, 0LL);
		    }
		    qword_18F36F4D0 = (__int64)v8;
		  }
		  if ( !v8(renderer, wrapperArray, method) )
		    return 0;
		  v9 = (__int64 (__fastcall *)(Renderer *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v9 = (__int64 (__fastcall *)(Renderer *))sub_180059EA0("UnityEngine.Component::get_gameObject()");
		    qword_18F36FBC8 = (__int64)v9;
		  }
		  v10 = v9(renderer);
		  if ( !v10 )
		LABEL_25:
		    sub_1800D8260(v5, wrapperArray);
		  v11 = (unsigned __int8 (__fastcall *)(__int64))qword_18F36FC70;
		  if ( !qword_18F36FC70 )
		  {
		    v11 = (unsigned __int8 (__fastcall *)(__int64))sub_180059EA0("UnityEngine.GameObject::get_activeInHierarchy()");
		    qword_18F36FC70 = (__int64)v11;
		  }
		  if ( !v11(v10) )
		    return 0;
		  v12 = TypeInfo::HG::Rendering::Runtime::HGCharacterHelper;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterHelper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterHelper);
		    v12 = TypeInfo::HG::Rendering::Runtime::HGCharacterHelper;
		  }
		  static_fields = v12->static_fields;
		  v21 = 0LL;
		  s_FrustumPlanesCache = static_fields->s_FrustumPlanesCache;
		  v22 = 0LL;
		  v15 = (void (__fastcall *)(Renderer *, __int128 *))qword_18F36F560;
		  if ( !qword_18F36F560 )
		  {
		    v15 = (void (__fastcall *)(Renderer *, __int128 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v15 )
		    {
		      v20 = sub_1802EE1B8("UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v20, 0LL);
		    }
		    qword_18F36F560 = (__int64)v15;
		  }
		  v15(renderer, &v21);
		  v16 = (__int64 (__fastcall *)(Plane__Array *, __int128 *))qword_18F36F288;
		  v23 = v21;
		  v24 = v22;
		  if ( !qword_18F36F288 )
		  {
		    v16 = (__int64 (__fastcall *)(Plane__Array *, __int128 *))sub_180059EA0(
		                                                                "UnityEngine.GeometryUtility::TestPlanesAABB_Injected(Uni"
		                                                                "tyEngine.Plane[],UnityEngine.Bounds&)");
		    qword_18F36F288 = (__int64)v16;
		  }
		  return v16(s_FrustumPlanesCache, &v23);
		}
		
		private void OnBeginFrameRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000183452380-0x0000000183452C80
		// Void OnBeginFrameRendering(ScriptableRenderContext, List`1[UnityEngine.Camera])
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering(
		        HGCharacterHelper *this,
		        ScriptableRenderContext context,
		        List_1_UnityEngine_Camera_ *cameras,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v9; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  Camera *hasDelegate; // rbx
		  struct Object_1__Class *v15; // rcx
		  struct HGCharacterHelper__Class *v16; // rax
		  __int64 v17; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v18; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v20; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v21; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v22; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v23; // rax
		  ILFixDynamicMethodWrapper_20 *v24; // rcx
		  bool m_EnableCastSelfShadow; // cl
		  ILFixDynamicMethodWrapper_2__StaticFields *v26; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v27; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v28; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v29; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v30; // rax
		  ILFixDynamicMethodWrapper_39 *monitor; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v32; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v33; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v34; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v35; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v36; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v37; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v38; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v39; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *v40; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v41; // rax
		  ILFixDynamicMethodWrapper_20 *v42; // rcx
		  bool m_EnableCastHDPunctualLightShadow; // cl
		  ILFixDynamicMethodWrapper_2__StaticFields *v44; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v45; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v46; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v47; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v48; // rax
		  ILFixDynamicMethodWrapper_39 *v49; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v50; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v51; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v52; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *v53; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v54; // rax
		  Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *m_CameraBoundsMap; // rcx
		  MethodInfo *methoda; // [rsp+20h] [rbp-68h]
		  SingleFieldAccessor v57; // [rsp+30h] [rbp-58h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v7, context.m_Ptr);
		  if ( wrapperArray->max_length.size > 4136 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v9 = v7->static_fields->wrapperArray;
		    if ( !v9 )
		      sub_1800D8260(v7, context.m_Ptr);
		    if ( v9->max_length.size <= 0x1028u )
		      sub_1800D2AB0(v7, context.m_Ptr);
		    if ( v9[115].klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(4136, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v12, v11);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, context, (Object *)cameras, 0LL);
		      return;
		    }
		  }
		  if ( !cameras )
		    sub_1800D8260(v7, context.m_Ptr);
		  *(_OWORD *)&v57.monitor = 0LL;
		  v57.klass = (SingleFieldAccessor__Class *)cameras;
		  sub_18002D1B0(&v57, (Type *)context.m_Ptr, (PropertyInfo_1 *)cameras, (Int32__Array **)method, methoda);
		  LODWORD(v57.monitor) = 0;
		  HIDWORD(v57.monitor) = cameras->fields._version;
		  v57.fields._.getValueDelegate = 0LL;
		  *(_OWORD *)&v57.fields.setValueDelegate = *(_OWORD *)&v57.klass;
		  v57.fields.hasDelegate = 0LL;
		  v57.klass = 0LL;
		  v57.monitor = (MonitorData *)&v57.fields.setValueDelegate;
		  while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		            (List_1_T_Enumerator_System_Object_ *)&v57.fields.setValueDelegate,
		            MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
		  {
		    hasDelegate = (Camera *)v57.fields.hasDelegate;
		    v15 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v15 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v15 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( hasDelegate )
		    {
		      if ( !v15->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v15);
		      if ( hasDelegate->fields._._._.m_CachedPtr )
		      {
		        v16 = TypeInfo::HG::Rendering::Runtime::HGCharacterHelper;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterHelper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterHelper);
		          v16 = TypeInfo::HG::Rendering::Runtime::HGCharacterHelper;
		        }
		        UnityEngine::GeometryUtility::CalculateFrustumPlanes(hasDelegate, v16->static_fields->s_FrustumPlanesCache, 0LL);
		        v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        static_fields = v18->static_fields;
		        if ( !static_fields->wrapperArray )
		          sub_1800D8250(static_fields, 0LL);
		        if ( static_fields->wrapperArray->max_length.size <= 4125 )
		          goto LABEL_40;
		        if ( !v18->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v18);
		          v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v20 = v18->static_fields;
		        v21 = v20->wrapperArray;
		        if ( !v20->wrapperArray )
		          sub_1800D8250(v20, 0LL);
		        if ( v21->max_length.size <= 0x101Du )
		          sub_1800D2AA0(v20, v21, v17);
		        if ( v21[114].vector[21] )
		        {
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v22 = v18->static_fields;
		          v23 = v22->wrapperArray;
		          if ( !v22->wrapperArray )
		            sub_1800D8250(v22, v21);
		          if ( v23->max_length.size <= 0x101Du )
		            sub_1800D2AA0(v22, v21, v17);
		          v24 = (ILFixDynamicMethodWrapper_20 *)v23[114].vector[21];
		          if ( !v24 )
		            sub_1800D8250(0LL, v21);
		          m_EnableCastSelfShadow = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(v24, (Object *)this, 0LL);
		          v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        else
		        {
		LABEL_40:
		          m_EnableCastSelfShadow = this->fields.m_EnableCastSelfShadow;
		        }
		        if ( !m_EnableCastSelfShadow )
		          goto LABEL_59;
		        if ( this->fields.enableSphereBasedBounds )
		        {
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v35 = v18->static_fields;
		          if ( !v35->wrapperArray )
		            sub_1800D8250(v35, 0LL);
		          if ( v35->wrapperArray->max_length.size <= 4137 )
		            goto LABEL_84;
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v36 = v18->static_fields;
		          v37 = v36->wrapperArray;
		          if ( !v36->wrapperArray )
		            sub_1800D8250(v36, 0LL);
		          if ( v37->max_length.size <= 0x1029u )
		            sub_1800D2AA0(v36, v37, v17);
		          if ( !v37[115].monitor )
		          {
		LABEL_84:
		            HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphereInternal(
		              this,
		              hasDelegate,
		              1,
		              this->fields.m_CameraBoundsMap,
		              &this->fields.bounds,
		              0LL);
		            goto LABEL_58;
		          }
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v38 = v18->static_fields;
		          v39 = v38->wrapperArray;
		          if ( !v38->wrapperArray )
		            sub_1800D8250(v38, v37);
		          if ( v39->max_length.size <= 0x1029u )
		            sub_1800D2AA0(v38, v37, v17);
		          monitor = (ILFixDynamicMethodWrapper_39 *)v39[115].monitor;
		          if ( !monitor )
		            sub_1800D8250(0LL, v37);
		        }
		        else
		        {
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v26 = v18->static_fields;
		          if ( !v26->wrapperArray )
		            sub_1800D8250(v26, 0LL);
		          if ( v26->wrapperArray->max_length.size <= 4140 )
		            goto LABEL_68;
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v27 = v18->static_fields;
		          v28 = v27->wrapperArray;
		          if ( !v27->wrapperArray )
		            sub_1800D8250(v27, 0LL);
		          if ( v28->max_length.size <= 0x102Cu )
		            sub_1800D2AA0(v27, v28, v17);
		          if ( !v28[115].vector[0] )
		          {
		LABEL_68:
		            HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsInternal(
		              this,
		              hasDelegate,
		              1,
		              this->fields.m_CameraBoundsMap,
		              &this->fields.bounds,
		              0LL);
		            goto LABEL_58;
		          }
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v29 = v18->static_fields;
		          v30 = v29->wrapperArray;
		          if ( !v29->wrapperArray )
		            sub_1800D8250(v29, v28);
		          if ( v30->max_length.size <= 0x102Cu )
		            sub_1800D2AA0(v29, v28, v17);
		          monitor = (ILFixDynamicMethodWrapper_39 *)v30[115].vector[0];
		          if ( !monitor )
		            sub_1800D8250(0LL, v28);
		        }
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(monitor, (Object *)this, (Object *)hasDelegate, 0LL);
		LABEL_58:
		        v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		LABEL_59:
		        if ( !v18->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v18);
		          v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v32 = v18->static_fields;
		        if ( !v32->wrapperArray )
		          sub_1800D8250(v32, 0LL);
		        if ( v32->wrapperArray->max_length.size <= 4129 )
		          goto LABEL_92;
		        if ( !v18->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v18);
		          v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v33 = v18->static_fields;
		        v34 = v33->wrapperArray;
		        if ( !v33->wrapperArray )
		          sub_1800D8250(v33, 0LL);
		        if ( v34->max_length.size <= 0x1021u )
		          sub_1800D2AA0(v33, v34, v17);
		        if ( v34[114].vector[25] )
		        {
		          if ( !v18->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v18);
		            v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v40 = v18->static_fields;
		          v41 = v40->wrapperArray;
		          if ( !v40->wrapperArray )
		            sub_1800D8250(v40, v34);
		          if ( v41->max_length.size <= 0x1021u )
		            sub_1800D2AA0(v40, v34, v17);
		          v42 = (ILFixDynamicMethodWrapper_20 *)v41[114].vector[25];
		          if ( !v42 )
		            sub_1800D8250(0LL, v34);
		          m_EnableCastHDPunctualLightShadow = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(v42, (Object *)this, 0LL);
		          v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        else
		        {
		LABEL_92:
		          m_EnableCastHDPunctualLightShadow = this->fields.m_EnableCastHDPunctualLightShadow;
		        }
		        if ( m_EnableCastHDPunctualLightShadow )
		        {
		          if ( this->fields.enableSphereBasedBounds )
		          {
		            if ( !v18->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v18);
		              v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v50 = v18->static_fields;
		            if ( !v50->wrapperArray )
		              sub_1800D8250(v50, 0LL);
		            if ( v50->wrapperArray->max_length.size <= 4142 )
		              goto LABEL_126;
		            if ( !v18->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v18);
		              v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v51 = v18->static_fields;
		            v52 = v51->wrapperArray;
		            if ( !v51->wrapperArray )
		              sub_1800D8250(v51, 0LL);
		            if ( v52->max_length.size <= 0x102Eu )
		              sub_1800D2AA0(v51, v52, v17);
		            if ( v52[115].vector[2] )
		            {
		              if ( !v18->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(v18);
		                v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v53 = v18->static_fields;
		              v54 = v53->wrapperArray;
		              if ( !v53->wrapperArray )
		                sub_1800D8250(v53, v52);
		              if ( v54->max_length.size <= 0x102Eu )
		                sub_1800D2AA0(v53, v52, v17);
		              v49 = (ILFixDynamicMethodWrapper_39 *)v54[115].vector[2];
		              if ( !v49 )
		                sub_1800D8250(0LL, v52);
		LABEL_109:
		              IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(v49, (Object *)this, (Object *)hasDelegate, 0LL);
		            }
		            else
		            {
		LABEL_126:
		              HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphereInternal(
		                this,
		                hasDelegate,
		                0,
		                this->fields.m_CameraHDPLSBoundsMap,
		                &this->fields.hdplsBounds,
		                0LL);
		            }
		          }
		          else
		          {
		            if ( !v18->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v18);
		              v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v44 = v18->static_fields;
		            if ( !v44->wrapperArray )
		              sub_1800D8250(v44, 0LL);
		            if ( v44->wrapperArray->max_length.size > 4143 )
		            {
		              if ( !v18->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(v18);
		                v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v45 = v18->static_fields;
		              v46 = v45->wrapperArray;
		              if ( !v45->wrapperArray )
		                sub_1800D8250(v45, 0LL);
		              if ( v46->max_length.size <= 0x102Fu )
		                sub_1800D2AA0(v45, v46, v17);
		              if ( v46[115].vector[3] )
		              {
		                if ( !v18->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(v18);
		                  v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                }
		                v47 = v18->static_fields;
		                v48 = v47->wrapperArray;
		                if ( !v47->wrapperArray )
		                  sub_1800D8250(v47, v46);
		                if ( v48->max_length.size <= 0x102Fu )
		                  sub_1800D2AA0(v47, v46, v17);
		                v49 = (ILFixDynamicMethodWrapper_39 *)v48[115].vector[3];
		                if ( !v49 )
		                  sub_1800D8250(0LL, v46);
		                goto LABEL_109;
		              }
		            }
		            HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsInternal(
		              this,
		              hasDelegate,
		              0,
		              this->fields.m_CameraHDPLSBoundsMap,
		              &this->fields.hdplsBounds,
		              0LL);
		          }
		        }
		      }
		    }
		  }
		  m_CameraBoundsMap = this->fields.m_CameraBoundsMap;
		  if ( !m_CameraBoundsMap )
		    sub_1800D8250(0LL, v13);
		  if ( m_CameraBoundsMap->fields._count - m_CameraBoundsMap->fields._freeCount > 4 )
		    HG::Rendering::Runtime::HGCharacterHelper::CleanupInactiveCameraData(this, cameras, 0LL);
		}
		
		private void UpdateBoundsInternal(Camera camera, bool checkVisibility, Dictionary<Camera, Bounds> targetMap, ref Bounds fallbackBounds) {} // 0x0000000182FAB980-0x0000000182FAC890
		// Void UpdateBoundsInternal(Camera, Boolean, Dictionary`2[UnityEngine.Camera,UnityEngine.Bounds], Bounds ByRef)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsInternal(
		        HGCharacterHelper *this,
		        Camera *camera,
		        bool checkVisibility,
		        Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *targetMap,
		        Bounds *fallbackBounds,
		        MethodInfo *method)
		{
		  unsigned int v6; // ebx
		  _QWORD **items; // rcx
		  _DWORD *wrapperArray; // rdx
		  struct Object_1__Class *v13; // rcx
		  __int64 (__fastcall *v14)(HGCharacterHelper *); // rax
		  __int64 v15; // rdi
		  void (__fastcall *v16)(__int64, Vector3 *); // rax
		  double v17; // xmm9_8
		  float z; // r12d
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  MethodInfo *v21; // r9
		  __int64 v22; // xmm10_8
		  float v23; // r13d
		  __int128 v24; // xmm7
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *renderers; // rax
		  __int128 v26; // xmm6
		  unsigned __int8 (__fastcall *v27)(_QWORD); // rax
		  __int64 (__fastcall *v28)(_QWORD); // rax
		  __int64 v29; // r14
		  __int64 (__fastcall *v30)(__int64); // rax
		  char v31; // al
		  unsigned __int8 (__fastcall *v32)(_QWORD); // rax
		  void (__fastcall *v33)(_QWORD, Bounds *); // rax
		  MethodInfo *v34; // r9
		  float boundSizeOffset; // xmm2_4
		  MethodInfo *v36; // r9
		  Vector3 *v37; // rax
		  __int64 v38; // r8
		  __int64 v39; // xmm3_8
		  MethodInfo *v40; // r9
		  Vector3 *v41; // rax
		  __int64 v42; // xmm3_8
		  MethodInfo *v43; // r9
		  Vector3 *v44; // rax
		  __m128i v45; // xmm4
		  __int64 v46; // xmm8_8
		  __int64 v47; // xmm7_8
		  float v48; // r11d
		  float v49; // edi
		  MethodInfo *v50; // rax
		  MethodInfo *v51; // r9
		  __m128 v52; // xmm6
		  Vector3 *v53; // rax
		  float *v54; // r9
		  float v55; // xmm4_4
		  __m128 v56; // xmm5
		  __m128 v57; // xmm0
		  __m128 v58; // xmm1
		  __m128 v59; // xmm3
		  float v60; // xmm2_4
		  Vector3 *v61; // rax
		  __int64 v62; // xmm3_8
		  MethodInfo *v63; // r9
		  Vector3 *v64; // rax
		  float v65; // ecx
		  __m128 v66; // xmm5
		  float v67; // xmm4_4
		  float v68; // r11d
		  MethodInfo *v69; // r9
		  float *v70; // r9
		  __int64 v71; // xmm0_8
		  float *v72; // r10
		  float v73; // ecx
		  __int64 v74; // xmm0_8
		  __int64 v75; // r9
		  float *v76; // r10
		  __m128 v77; // xmm6
		  unsigned __int64 *v78; // r11
		  float v79; // eax
		  __int64 v80; // xmm0_8
		  float v81; // eax
		  Vector3 *v82; // rax
		  MethodInfo *v83; // r9
		  float *v84; // r11
		  float v85; // xmm4_4
		  __m128 v86; // xmm5
		  __m128 v87; // xmm0
		  __m128 v88; // xmm1
		  __m128 v89; // xmm3
		  float v90; // xmm2_4
		  Vector3 *v91; // rax
		  __int64 v92; // xmm3_8
		  MethodInfo *v93; // r9
		  Vector3 *v94; // rax
		  float v95; // xmm4_4
		  __m128 v96; // xmm5
		  MethodInfo *v97; // r9
		  Vector3 *v98; // rax
		  unsigned __int8 (__fastcall *v99)(_QWORD); // rax
		  __int64 (__fastcall *v100)(_QWORD); // rax
		  __int64 v101; // r14
		  unsigned __int8 (__fastcall *v102)(__int64); // rax
		  struct HGCharacterHelper__Class *v103; // rax
		  HGCharacterHelper__StaticFields *static_fields; // rax
		  Plane__Array *s_FrustumPlanesCache; // r14
		  void (__fastcall *v106)(_QWORD, Bounds *); // rax
		  __int64 (__fastcall *v107)(Plane__Array *, Bounds *); // rax
		  float v108; // eax
		  Vector3 *v109; // rax
		  float v110; // xmm2_4
		  MethodInfo *v111; // r8
		  __int64 v112; // rdx
		  __int64 v113; // rcx
		  MethodInfo *v114; // r9
		  float v115; // xmm0_4
		  float v116; // xmm6_4
		  __int64 v117; // xmm0_8
		  MethodInfo *v118; // r9
		  Vector3 *v119; // rax
		  __int64 v120; // xmm0_8
		  __int64 *v121; // r8
		  __int64 v122; // xmm0_8
		  MethodInfo *v123; // r9
		  Vector3 *v124; // rax
		  __m128 v125; // xmm3
		  MethodInfo *v126; // r9
		  uint3 *v127; // rax
		  float v128; // edi
		  struct MethodInfo *v129; // rbx
		  int32_t Entry; // eax
		  __int64 v131; // rdx
		  MethodInfo *v132; // r9
		  __int64 v133; // xmm0_8
		  Vector3 *v134; // rax
		  float v135; // xmm2_4
		  MethodInfo *v136; // r8
		  __int64 v137; // rdx
		  __int64 v138; // rcx
		  MethodInfo *v139; // r9
		  float v140; // xmm0_4
		  MethodInfo *v141; // r9
		  Vector3 *v142; // rax
		  __int64 v143; // xmm0_8
		  __int64 *v144; // r8
		  __int64 v145; // xmm0_8
		  MethodInfo *v146; // r9
		  Vector3 *v147; // rax
		  __m128 v148; // xmm3
		  MethodInfo *v149; // r9
		  uint3 *v150; // rax
		  struct MethodInfo *v151; // rbx
		  Il2CppClass *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v154; // rax
		  __int64 v155; // rax
		  _QWORD *v156; // rax
		  ILFixDynamicMethodWrapper_2 *v157; // rax
		  __int64 v158; // rax
		  __int64 v159; // rax
		  __int64 v160; // rax
		  __int64 v161; // rax
		  __int64 v162; // rax
		  __int64 v163; // rax
		  __int64 v164; // rax
		  __int64 v165; // rax
		  __int64 v166; // rax
		  __int64 v167; // rax
		  char v168; // [rsp+40h] [rbp-C0h]
		  Vector3 value; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 vector; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 v171; // [rsp+70h] [rbp-90h] BYREF
		  Vector3 m_Extents; // [rsp+80h] [rbp-80h] BYREF
		  uint3 v173; // [rsp+90h] [rbp-70h] BYREF
		  Bounds v174; // [rsp+A0h] [rbp-60h]
		  Bounds v175; // [rsp+B8h] [rbp-48h] BYREF
		  unsigned __int64 v176; // [rsp+D0h] [rbp-30h]
		  Vector3 v177; // [rsp+E0h] [rbp-20h] BYREF
		  Bounds v178; // [rsp+F0h] [rbp-10h]
		  Vector3 v179; // [rsp+110h] [rbp+10h] BYREF
		  Vector3 v180; // [rsp+120h] [rbp+20h] BYREF
		  Vector3 v181; // [rsp+130h] [rbp+30h] BYREF
		  Vector3 v182; // [rsp+140h] [rbp+40h] BYREF
		  Vector3 v183; // [rsp+150h] [rbp+50h] BYREF
		  Vector3 v184; // [rsp+160h] [rbp+60h] BYREF
		  Vector3 v185; // [rsp+170h] [rbp+70h] BYREF
		  Vector3 v186; // [rsp+180h] [rbp+80h] BYREF
		  Vector3 v187; // [rsp+190h] [rbp+90h] BYREF
		  Vector3 v188; // [rsp+1A0h] [rbp+A0h] BYREF
		  Vector3 v189; // [rsp+1B0h] [rbp+B0h] BYREF
		  Vector3 v190; // [rsp+1C0h] [rbp+C0h] BYREF
		  Vector3 v191; // [rsp+1D0h] [rbp+D0h] BYREF
		  Vector3 v192; // [rsp+1E0h] [rbp+E0h] BYREF
		  Vector3 v193; // [rsp+1F0h] [rbp+F0h] BYREF
		  Vector3 v194; // [rsp+200h] [rbp+100h] BYREF
		  Vector3 v195; // [rsp+210h] [rbp+110h] BYREF
		  Vector3 v196; // [rsp+220h] [rbp+120h] BYREF
		  Bounds v197; // [rsp+230h] [rbp+130h] BYREF
		  Vector3 v198; // [rsp+250h] [rbp+150h] BYREF
		  Vector3 v199; // [rsp+260h] [rbp+160h] BYREF
		  Vector3 v200; // [rsp+270h] [rbp+170h] BYREF
		  Vector3 v201; // [rsp+280h] [rbp+180h] BYREF
		  Vector3 v202; // [rsp+290h] [rbp+190h] BYREF
		  Il2CppMethodPointer methodPointer; // [rsp+2A0h] [rbp+1A0h]
		  unsigned __int64 v204; // [rsp+2B0h] [rbp+1B0h]
		  unsigned __int64 v205; // [rsp+2C0h] [rbp+1C0h]
		  unsigned __int64 v206; // [rsp+2D0h] [rbp+1D0h]
		  unsigned __int64 v207; // [rsp+2E0h] [rbp+1E0h]
		  unsigned __int64 v208; // [rsp+2F0h] [rbp+1F0h]
		  unsigned __int64 v209; // [rsp+300h] [rbp+200h]
		  Vector3 v210; // [rsp+310h] [rbp+210h] BYREF
		  Vector3 v211; // [rsp+320h] [rbp+220h] BYREF
		  Vector3 v212; // [rsp+330h] [rbp+230h] BYREF
		  Vector3 v213; // [rsp+340h] [rbp+240h] BYREF
		  Vector3 v214; // [rsp+350h] [rbp+250h] BYREF
		  Vector3 v215; // [rsp+360h] [rbp+260h] BYREF
		  Vector3 v216; // [rsp+370h] [rbp+270h] BYREF
		  Vector3 v217; // [rsp+380h] [rbp+280h] BYREF
		  Vector3 v218; // [rsp+390h] [rbp+290h] BYREF
		  Vector3 v219; // [rsp+3A0h] [rbp+2A0h] BYREF
		  Vector3 v220; // [rsp+3B0h] [rbp+2B0h] BYREF
		  Vector3 v221; // [rsp+3C0h] [rbp+2C0h] BYREF
		  Vector3 v222; // [rsp+3D0h] [rbp+2D0h] BYREF
		  Vector3 v223; // [rsp+3E0h] [rbp+2E0h] BYREF
		  Vector3 v224; // [rsp+3F0h] [rbp+2F0h] BYREF
		
		  v6 = 0;
		  items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  *(_QWORD *)&v174.m_Extents.x = 0LL;
		  v174.m_Extents.z = 0.0;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (_DWORD *)*items[23];
		  if ( !wrapperArray )
		    goto LABEL_102;
		  if ( (int)wrapperArray[6] > 4141 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (_DWORD *)*items[23];
		    if ( !wrapperArray )
		      goto LABEL_102;
		    if ( wrapperArray[6] <= 0x102Du )
		      goto LABEL_113;
		    if ( *((_QWORD *)wrapperArray + 4145) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(4141, 0LL);
		      if ( !Patch )
		        goto LABEL_102;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1459(
		        Patch,
		        (Object *)this,
		        (Object *)camera,
		        checkVisibility,
		        (Object *)targetMap,
		        fallbackBounds,
		        0LL);
		      return;
		    }
		  }
		  if ( !this->fields.renderers )
		    return;
		  v13 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v13 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v13 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !camera )
		    return;
		  if ( !v13->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v13);
		  if ( !camera->fields._._._.m_CachedPtr )
		    return;
		  v14 = (__int64 (__fastcall *)(HGCharacterHelper *))qword_18F36FBC0;
		  v168 = 0;
		  if ( !qword_18F36FBC0 )
		  {
		    v14 = (__int64 (__fastcall *)(HGCharacterHelper *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v14 )
		    {
		      v154 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v154, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v14;
		  }
		  v15 = v14(this);
		  if ( !v15 )
		    goto LABEL_102;
		  *(_QWORD *)&v171.x = 0LL;
		  v171.z = 0.0;
		  v16 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v16 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                     "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v16 )
		    {
		      v155 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v155, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v16;
		  }
		  v16(v15, &v171);
		  v17 = *(double *)&v171.x;
		  z = v171.z;
		  m_Extents.z = 0.0;
		  *(_QWORD *)&m_Extents.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v174.m_Center = v171;
		  v20 = UnityEngine::Vector3::op_Multiply(&v210, &m_Extents, 0.5, v19);
		  v22 = *(_QWORD *)&v20->x;
		  v23 = v20->z;
		  *(_QWORD *)&v174.m_Extents.x = *(_QWORD *)&v20->x;
		  v24 = *(_OWORD *)&v174.m_Center.x;
		  v174.m_Extents.z = v23;
		  while ( 1 )
		  {
		    renderers = this->fields.renderers;
		    if ( !renderers )
		      goto LABEL_102;
		    if ( (signed int)v6 >= renderers->fields._size )
		      break;
		    if ( v6 >= renderers->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    items = (_QWORD **)renderers->fields._items;
		    if ( !items )
		      goto LABEL_102;
		    if ( v6 >= *((_DWORD *)items + 6) )
		      goto LABEL_113;
		    v26 = *(_OWORD *)&items[2 * (int)v6 + 4];
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    items = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( (_QWORD)v26 )
		    {
		      items = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( *(_QWORD *)(v26 + 16) )
		      {
		        if ( checkVisibility )
		        {
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            goto LABEL_102;
		          if ( (int)wrapperArray[6] <= 4139 )
		            goto LABEL_161;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		          v156 = *items;
		          if ( !*items )
		            goto LABEL_102;
		          if ( *((_DWORD *)v156 + 6) <= 0x102Bu )
		            goto LABEL_113;
		          if ( v156[4143] )
		          {
		            v157 = IFix::WrappersManagerImpl::GetPatch(4139, 0LL);
		            if ( !v157 )
		              goto LABEL_102;
		            v31 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		                    (ILFixDynamicMethodWrapper_33 *)v157,
		                    (Object *)this,
		                    (Object *)v26,
		                    0LL);
		          }
		          else
		          {
		LABEL_161:
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            items = (_QWORD **)TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            if ( !*(_QWORD *)(v26 + 16) )
		              goto LABEL_80;
		            v99 = (unsigned __int8 (__fastcall *)(_QWORD))qword_18F36F4D0;
		            if ( !qword_18F36F4D0 )
		            {
		              v99 = (unsigned __int8 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Renderer::get_enabled()");
		              if ( !v99 )
		              {
		                v158 = sub_1802EE1B8("UnityEngine.Renderer::get_enabled()");
		                sub_18007E1B0(v158, 0LL);
		              }
		              qword_18F36F4D0 = (__int64)v99;
		            }
		            if ( !v99(v26) )
		              goto LABEL_80;
		            v100 = (__int64 (__fastcall *)(_QWORD))qword_18F36FBC8;
		            if ( !qword_18F36FBC8 )
		            {
		              v100 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		              if ( !v100 )
		              {
		                v159 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		                sub_18007E1B0(v159, 0LL);
		              }
		              qword_18F36FBC8 = (__int64)v100;
		            }
		            v101 = v100(v26);
		            if ( !v101 )
		              goto LABEL_102;
		            v102 = (unsigned __int8 (__fastcall *)(__int64))qword_18F36FC70;
		            if ( !qword_18F36FC70 )
		            {
		              v102 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.GameObject::get_activeInHierarchy()");
		              if ( !v102 )
		              {
		                v160 = sub_1802EE1B8("UnityEngine.GameObject::get_activeInHierarchy()");
		                sub_18007E1B0(v160, 0LL);
		              }
		              qword_18F36FC70 = (__int64)v102;
		            }
		            if ( v102(v101) )
		            {
		              v103 = TypeInfo::HG::Rendering::Runtime::HGCharacterHelper;
		              if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterHelper->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterHelper);
		                v103 = TypeInfo::HG::Rendering::Runtime::HGCharacterHelper;
		              }
		              static_fields = v103->static_fields;
		              memset(&v175, 0, sizeof(v175));
		              s_FrustumPlanesCache = static_fields->s_FrustumPlanesCache;
		              v106 = (void (__fastcall *)(_QWORD, Bounds *))qword_18F36F560;
		              if ( !qword_18F36F560 )
		              {
		                v106 = (void (__fastcall *)(_QWORD, Bounds *))il2cpp_resolve_icall_1(
		                                                                "UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		                if ( !v106 )
		                {
		                  v161 = sub_1802EE1B8("UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		                  sub_18007E1B0(v161, 0LL);
		                }
		                qword_18F36F560 = (__int64)v106;
		              }
		              v106(v26, &v175);
		              v107 = (__int64 (__fastcall *)(Plane__Array *, Bounds *))qword_18F36F288;
		              v197 = v175;
		              if ( !qword_18F36F288 )
		              {
		                v107 = (__int64 (__fastcall *)(Plane__Array *, Bounds *))il2cpp_resolve_icall_1(
		                                                                           "UnityEngine.GeometryUtility::TestPlanesAABB_I"
		                                                                           "njected(UnityEngine.Plane[],UnityEngine.Bounds&)");
		                if ( !v107 )
		                {
		                  v162 = sub_1802EE1B8(
		                           "UnityEngine.GeometryUtility::TestPlanesAABB_Injected(UnityEngine.Plane[],UnityEngine.Bounds&)");
		                  sub_18007E1B0(v162, 0LL);
		                }
		                qword_18F36F288 = (__int64)v107;
		              }
		              v31 = v107(s_FrustumPlanesCache, &v197);
		            }
		            else
		            {
		LABEL_80:
		              v31 = 0;
		            }
		          }
		          goto LABEL_35;
		        }
		        v27 = (unsigned __int8 (__fastcall *)(_QWORD))qword_18F36F4D0;
		        if ( !qword_18F36F4D0 )
		        {
		          v27 = (unsigned __int8 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Renderer::get_enabled()");
		          if ( !v27 )
		          {
		            v163 = sub_1802EE1B8("UnityEngine.Renderer::get_enabled()");
		            sub_18007E1B0(v163, 0LL);
		          }
		          qword_18F36F4D0 = (__int64)v27;
		        }
		        if ( v27(v26) )
		        {
		          v28 = (__int64 (__fastcall *)(_QWORD))qword_18F36FBC8;
		          if ( !qword_18F36FBC8 )
		          {
		            v28 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		            if ( !v28 )
		            {
		              v164 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		              sub_18007E1B0(v164, 0LL);
		            }
		            qword_18F36FBC8 = (__int64)v28;
		          }
		          v29 = v28(v26);
		          if ( !v29 )
		            goto LABEL_102;
		          v30 = (__int64 (__fastcall *)(__int64))qword_18F36FC70;
		          if ( !qword_18F36FC70 )
		          {
		            v30 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.GameObject::get_activeInHierarchy()");
		            if ( !v30 )
		            {
		              v165 = sub_1802EE1B8("UnityEngine.GameObject::get_activeInHierarchy()");
		              sub_18007E1B0(v165, 0LL);
		            }
		            qword_18F36FC70 = (__int64)v30;
		          }
		          v31 = v30(v29);
		LABEL_35:
		          if ( v31 )
		          {
		            v32 = (unsigned __int8 (__fastcall *)(_QWORD))qword_18F36F4F8;
		            if ( !qword_18F36F4F8 )
		            {
		              v32 = (unsigned __int8 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Renderer::GetIsRealtimeShadowCaster()");
		              if ( !v32 )
		              {
		                v166 = sub_1802EE1B8("UnityEngine.Renderer::GetIsRealtimeShadowCaster()");
		                sub_18007E1B0(v166, 0LL);
		              }
		              qword_18F36F4F8 = (__int64)v32;
		            }
		            if ( v32(v26) )
		            {
		              v33 = (void (__fastcall *)(_QWORD, Bounds *))qword_18F36F560;
		              memset(&v175, 0, sizeof(v175));
		              if ( !qword_18F36F560 )
		              {
		                v33 = (void (__fastcall *)(_QWORD, Bounds *))il2cpp_resolve_icall_1(
		                                                               "UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		                if ( !v33 )
		                {
		                  v167 = sub_1802EE1B8("UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		                  sub_18007E1B0(v167, 0LL);
		                }
		                qword_18F36F560 = (__int64)v33;
		              }
		              v33(v26, &v175);
		              v178 = v175;
		              m_Extents = v175.m_Extents;
		              UnityEngine::Vector3::op_Multiply(&v211, &m_Extents, 2.0, v34);
		              boundSizeOffset = this->fields.boundSizeOffset;
		              v171.z = 1.0;
		              *(_QWORD *)&v171.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		              v37 = UnityEngine::Vector3::op_Multiply(&v212, &v171, boundSizeOffset, v36);
		              *(_QWORD *)&v199.x = *(_QWORD *)v38;
		              v39 = *(_QWORD *)&v37->x;
		              v198.z = v37->z;
		              LODWORD(v37) = *(_DWORD *)(v38 + 8);
		              *(_QWORD *)&v198.x = v39;
		              LODWORD(v199.z) = (_DWORD)v37;
		              v41 = UnityEngine::Vector3::op_Subtraction(&v213, &v199, &v198, v40);
		              v42 = *(_QWORD *)&v41->x;
		              *(float *)&v41 = v41->z;
		              *(_QWORD *)&v200.x = v42;
		              LODWORD(v200.z) = (_DWORD)v41;
		              v44 = UnityEngine::Vector3::op_Multiply(&v214, &v200, 0.5, v43);
		              v46 = v45.m128i_i64[0];
		              *(_QWORD *)&v178.m_Center.x = v45.m128i_i64[0];
		              v47 = *(_QWORD *)&v44->x;
		              v48 = v44->z;
		              v49 = COERCE_FLOAT(_mm_cvtsi128_si32(_mm_srli_si128(v45, 8)));
		              *(_QWORD *)&v178.m_Extents.x = *(_QWORD *)&v44->x;
		              v178.m_Extents.z = v48;
		              v178.m_Center.z = v49;
		              if ( v168 )
		              {
		                *(_QWORD *)&v201.x = v47;
		                v201.z = v48;
		                *(_QWORD *)&v202.x = v45.m128i_i64[0];
		                v202.z = v49;
		                v50 = (MethodInfo *)UnityEngine::Vector3::op_Subtraction(&v215, &v202, &v201, v21);
		                *(_QWORD *)&v179.x = v22;
		                v179.z = v23;
		                *(double *)&v180.x = v17;
		                v180.z = z;
		                v52 = (__m128)*(unsigned __int64 *)&UnityEngine::Vector3::op_Subtraction(&v222, &v180, &v179, v50)->x;
		                methodPointer = v51->methodPointer;
		                v204 = v52.m128_u64[0];
		                if ( *(float *)&methodPointer <= v52.m128_f32[0] )
		                  v52 = (__m128)(unsigned __int64)methodPointer;
		                *(_QWORD *)&v181.x = v22;
		                v181.z = v23;
		                *(double *)&v182.x = v17;
		                v182.z = z;
		                v53 = UnityEngine::Vector3::op_Addition(&v216, &v182, &v181, v51);
		                v57 = (__m128)*(unsigned __int64 *)v54;
		                v205 = *(_QWORD *)&v53->x;
		                v58 = (__m128)v205;
		                v206 = v57.m128_u64[0];
		                if ( *(float *)&v205 <= v57.m128_f32[0] )
		                  v58 = v57;
		                v59 = (__m128)HIDWORD(v205);
		                if ( *((float *)&v205 + 1) <= *((float *)&v206 + 1) )
		                  v59 = (__m128)HIDWORD(v206);
		                v60 = v53->z;
		                if ( v60 <= v54[2] )
		                  v60 = v54[2];
		                *(_QWORD *)&v183.x = _mm_unpacklo_ps(v52, v56).m128_u64[0];
		                v183.z = v55;
		                v184.z = v60;
		                *(_QWORD *)&v184.x = _mm_unpacklo_ps(v58, v59).m128_u64[0];
		                v61 = UnityEngine::Vector3::op_Subtraction(&v217, &v184, &v183, (MethodInfo *)v54);
		                v62 = *(_QWORD *)&v61->x;
		                *(float *)&v61 = v61->z;
		                *(_QWORD *)&v185.x = v62;
		                LODWORD(v185.z) = (_DWORD)v61;
		                v64 = UnityEngine::Vector3::op_Multiply(&v218, &v185, 0.5, v63);
		                v65 = v64->z;
		                *(_QWORD *)&v186.x = *(_QWORD *)&v64->x;
		                v186.z = v65;
		                *(_QWORD *)&v187.x = _mm_unpacklo_ps(v52, v66).m128_u64[0];
		                v187.z = v67;
		                UnityEngine::Vector3::op_Addition(&v219, &v187, &v186, (MethodInfo *)v64);
		                *(_QWORD *)&v188.x = v47;
		                v188.z = v68;
		                *(_QWORD *)&v189.x = v46;
		                v189.z = v49;
		                UnityEngine::Vector3::op_Addition(&v220, &v189, &v188, v69);
		                v71 = *(_QWORD *)v70;
		                v190.z = v70[2];
		                v73 = v72[2];
		                *(_QWORD *)&v190.x = v71;
		                v74 = *(_QWORD *)v72;
		                v191.z = v73;
		                *(_QWORD *)&v191.x = v74;
		                v77 = (__m128)*(unsigned __int64 *)&UnityEngine::Vector3::op_Subtraction(
		                                                      &v221,
		                                                      &v191,
		                                                      &v190,
		                                                      (MethodInfo *)v70)->x;
		                v207 = *v78;
		                v208 = v77.m128_u64[0];
		                if ( *(float *)&v207 <= v77.m128_f32[0] )
		                  v77 = (__m128)v207;
		                v79 = *(float *)(v75 + 8);
		                *(_QWORD *)&v196.x = *(_QWORD *)v75;
		                v80 = *(_QWORD *)v76;
		                v196.z = v79;
		                v81 = v76[2];
		                *(_QWORD *)&v192.x = v80;
		                v192.z = v81;
		                v82 = UnityEngine::Vector3::op_Addition(&v224, &v192, &v196, (MethodInfo *)v75);
		                v87 = (__m128)*(unsigned __int64 *)v84;
		                v209 = *(_QWORD *)&v82->x;
		                v88 = (__m128)v209;
		                v176 = v87.m128_u64[0];
		                if ( *(float *)&v209 <= v87.m128_f32[0] )
		                  v88 = v87;
		                v89 = (__m128)HIDWORD(v209);
		                if ( *((float *)&v209 + 1) <= *((float *)&v176 + 1) )
		                  v89 = (__m128)HIDWORD(v176);
		                v90 = v82->z;
		                if ( v90 <= v84[2] )
		                  v90 = v84[2];
		                *(_QWORD *)&v193.x = _mm_unpacklo_ps(v77, v86).m128_u64[0];
		                v193.z = v85;
		                v194.z = v90;
		                *(_QWORD *)&v194.x = _mm_unpacklo_ps(v88, v89).m128_u64[0];
		                v91 = UnityEngine::Vector3::op_Subtraction(&v223, &v194, &v193, v83);
		                v92 = *(_QWORD *)&v91->x;
		                *(float *)&v91 = v91->z;
		                *(_QWORD *)&v195.x = v92;
		                LODWORD(v195.z) = (_DWORD)v91;
		                v94 = UnityEngine::Vector3::op_Multiply(&v177, &v195, 0.5, v93);
		                v22 = *(_QWORD *)&v94->x;
		                v23 = v94->z;
		                *(_QWORD *)&v174.m_Extents.x = v22;
		                v174.m_Extents.z = v23;
		                value.z = v95;
		                *(_QWORD *)&value.x = _mm_unpacklo_ps(v77, v96).m128_u64[0];
		                *(_QWORD *)&vector.x = v22;
		                vector.z = v23;
		                v98 = UnityEngine::Vector3::op_Addition((Vector3 *)&v173, &value, &vector, v97);
		                z = v98->z;
		                v17 = *(double *)&v98->x;
		                v174.m_Center.z = z;
		                *((_QWORD *)&v24 + 1) = *(_QWORD *)&v174.m_Center.z;
		                *(double *)&v24 = v17;
		                *(_OWORD *)&v174.m_Center.x = v24;
		              }
		              else
		              {
		                v24 = *(_OWORD *)&v178.m_Center.x;
		                v168 = 1;
		                v174 = v178;
		                v17 = *(double *)&v178.m_Center.x;
		                v23 = v178.m_Extents.z;
		                v22 = *(_QWORD *)&v178.m_Extents.x;
		                z = COERCE_FLOAT(_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v178.m_Center.x, 8)));
		              }
		            }
		          }
		        }
		      }
		    }
		    ++v6;
		  }
		  if ( v168 )
		  {
		    *(double *)&vector.x = v17;
		    vector.z = z;
		    v108 = fallbackBounds->m_Center.z;
		    *(_QWORD *)&value.x = *(_QWORD *)&fallbackBounds->m_Center.x;
		    value.z = v108;
		    v109 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v173, &vector, &value, v21);
		    v110 = v109->z;
		    v176 = *(_QWORD *)&v109->x;
		    *(_QWORD *)&value.x = _mm_unpacklo_ps((__m128)v176, (__m128)HIDWORD(v176)).m128_u64[0];
		    *(_QWORD *)&vector.x = *(_QWORD *)&value.x;
		    value.z = v110;
		    vector.z = v110;
		    v115 = Dest::Math::Vector3ex::Dot(&vector, &value, v111);
		    if ( v115 < 0.0 )
		      v116 = sub_1803386C0(v113, v112);
		    else
		      v116 = fsqrt(v115);
		    *(_QWORD *)&value.x = v22;
		    value.z = v23;
		    UnityEngine::Vector3::op_Multiply((Vector3 *)&v173, &value, 2.0, v114);
		    v117 = *(_QWORD *)&fallbackBounds->m_Extents.x;
		    value.z = fallbackBounds->m_Extents.z;
		    *(_QWORD *)&value.x = v117;
		    v119 = UnityEngine::Vector3::op_Multiply(&v177, &value, 2.0, v118);
		    v120 = *(_QWORD *)&v119->x;
		    *(float *)&v119 = v119->z;
		    *(_QWORD *)&value.x = v120;
		    v122 = *v121;
		    LODWORD(value.z) = (_DWORD)v119;
		    LODWORD(v119) = *((_DWORD *)v121 + 2);
		    *(_QWORD *)&vector.x = v122;
		    LODWORD(vector.z) = (_DWORD)v119;
		    v124 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v173, &vector, &value, v123);
		    v125 = (__m128)*(unsigned __int64 *)&v124->x;
		    LODWORD(v171.x) = *(_QWORD *)&v124->x;
		    LODWORD(v171.y) = _mm_shuffle_ps(v125, v125, 85).m128_u32[0];
		    v171.z = v124->z;
		    *(_QWORD *)&v177.x = v125.m128_u64[0];
		    v127 = Unity::Mathematics::uint3::op_BitwiseAnd(&v173, (uint3 *)&v171, 0x7FFFFFFFu, v126);
		    v128 = *(float *)&v127->z;
		    *(_QWORD *)&m_Extents.x = *(_QWORD *)&v127->x;
		    if ( !targetMap )
		      goto LABEL_102;
		    v129 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue;
		    if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		          + 4) )
		      (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		    Entry = System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::FindEntry(
		              (Dictionary_2_System_Object_UnityEngine_Bounds_ *)targetMap,
		              (Object *)camera,
		              (MethodInfo *)v129->klass->rgctx_data[22].rgctxDataDummy);
		    if ( Entry >= 0 )
		    {
		      wrapperArray = targetMap->fields._entries;
		      if ( wrapperArray )
		      {
		        if ( (unsigned int)Entry < wrapperArray[6] )
		        {
		          v133 = *(_QWORD *)&wrapperArray[10 * Entry + 16];
		          *(_OWORD *)&v175.m_Center.x = *(_OWORD *)&wrapperArray[10 * Entry + 12];
		          *(_QWORD *)&v175.m_Extents.y = v133;
		          *(_QWORD *)&value.x = *(_QWORD *)&v175.m_Center.x;
		          LODWORD(value.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&wrapperArray[10 * Entry + 14]));
		          *(double *)&vector.x = v17;
		          vector.z = z;
		          v134 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v173, &vector, &value, v132);
		          v135 = v134->z;
		          v176 = *(_QWORD *)&v134->x;
		          *(_QWORD *)&value.x = _mm_unpacklo_ps((__m128)v176, (__m128)HIDWORD(v176)).m128_u64[0];
		          *(_QWORD *)&vector.x = *(_QWORD *)&value.x;
		          value.z = v135;
		          vector.z = v135;
		          v140 = Dest::Math::Vector3ex::Dot(&vector, &value, v136);
		          if ( v140 < 0.0 )
		            v116 = sub_1803386C0(v138, v137);
		          else
		            v116 = fsqrt(v140);
		          *(_QWORD *)&value.x = v22;
		          value.z = v23;
		          UnityEngine::Vector3::op_Multiply((Vector3 *)&v173, &value, 2.0, v139);
		          value = v175.m_Extents;
		          v142 = UnityEngine::Vector3::op_Multiply(&v177, &value, 2.0, v141);
		          v143 = *(_QWORD *)&v142->x;
		          *(float *)&v142 = v142->z;
		          *(_QWORD *)&value.x = v143;
		          v145 = *v144;
		          LODWORD(value.z) = (_DWORD)v142;
		          LODWORD(v142) = *((_DWORD *)v144 + 2);
		          *(_QWORD *)&vector.x = v145;
		          LODWORD(vector.z) = (_DWORD)v142;
		          v147 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v173, &vector, &value, v146);
		          v148 = (__m128)*(unsigned __int64 *)&v147->x;
		          LODWORD(v171.x) = *(_QWORD *)&v147->x;
		          LODWORD(v171.y) = _mm_shuffle_ps(v148, v148, 85).m128_u32[0];
		          v171.z = v147->z;
		          v150 = Unity::Mathematics::uint3::op_BitwiseAnd(&v173, (uint3 *)&v171, 0x7FFFFFFFu, v149);
		          v128 = *(float *)&v150->z;
		          *(_QWORD *)&m_Extents.x = *(_QWORD *)&v150->x;
		          goto LABEL_93;
		        }
		LABEL_113:
		        sub_1800D2AB0(items, wrapperArray);
		      }
		LABEL_102:
		      sub_1800D8260(items, wrapperArray);
		    }
		LABEL_93:
		    if ( m_Extents.x > 0.02 || m_Extents.y > 0.02 || v128 > 0.02 || v116 > 0.02 )
		    {
		      v151 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item;
		      if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item->klass->rgctx_data[24].rgctxDataDummy
		            + 4) )
		      {
		        LOBYTE(v131) = m_Extents.y > 0.02;
		        (*(void (__fastcall **)(const Il2CppRGCTXData *, __int64))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item->klass->rgctx_data[24].rgctxDataDummy)(
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item->klass->rgctx_data,
		          v131);
		      }
		      klass = v151->klass;
		      LOBYTE(v132) = 1;
		      *(_OWORD *)&v197.m_Center.x = v24;
		      *(_QWORD *)&v197.m_Extents.y = *(_QWORD *)&v174.m_Extents.y;
		      System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::TryInsert(
		        (Dictionary_2_System_Object_UnityEngine_Bounds_ *)targetMap,
		        (Object *)camera,
		        &v197,
		        (InsertionBehavior__Enum)v132,
		        (MethodInfo *)klass->rgctx_data[24].rgctxDataDummy);
		    }
		  }
		}
		
		public void UpdateBounds(Camera camera) {} // 0x0000000183F71A20-0x0000000183F71AA0
		// Void UpdateBounds(Camera)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateBounds(
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
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
		  if ( wrapperArray->max_length.size <= 4140 )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsInternal(
		      this,
		      camera,
		      1,
		      this->fields.m_CameraBoundsMap,
		      &this->fields.bounds,
		      0LL);
		    return;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x102C )
		    sub_1800D2AB0(v5, camera);
		  if ( !v5[88]._0.element_class )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4140, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, camera);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		public void UpdateHDPLSBounds(Camera camera) {} // 0x0000000183F71990-0x0000000183F71A20
		// Void UpdateHDPLSBounds(Camera)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateHDPLSBounds(
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
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
		  if ( wrapperArray->max_length.size <= 4143 )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsInternal(
		      this,
		      camera,
		      0,
		      this->fields.m_CameraHDPLSBoundsMap,
		      &this->fields.hdplsBounds,
		      0LL);
		    return;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x102F )
		    sub_1800D2AB0(v5, camera);
		  if ( !v5[88]._0.parent )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4143, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, camera);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		private void UpdateBoundsBySphereInternal(Camera camera, bool checkVisibility, Dictionary<Camera, Bounds> targetMap, ref Bounds fallbackBounds) {} // 0x0000000182FCA6A0-0x0000000182FCB240
		// Void UpdateBoundsBySphereInternal(Camera, Boolean, Dictionary`2[UnityEngine.Camera,UnityEngine.Bounds], Bounds ByRef)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphereInternal(
		        HGCharacterHelper *this,
		        Camera *camera,
		        bool checkVisibility,
		        Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *targetMap,
		        Bounds *fallbackBounds,
		        MethodInfo *method)
		{
		  _QWORD **items; // rcx
		  bool v9; // si
		  _DWORD *entries; // rdx
		  __m128 v12; // xmm13
		  unsigned int v13; // edi
		  __m128 v14; // xmm11
		  __m128 v15; // xmm12
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *boneSpheres; // r15
		  float v17; // xmm9_4
		  __m128 v18; // xmm10
		  float v19; // xmm8_4
		  unsigned int v20; // ebx
		  int size; // r15d
		  __m128 v22; // xmm6
		  __int64 (__fastcall *v23)(_QWORD, _QWORD, _QWORD); // rax
		  __m128 v24; // xmm5
		  float v25; // xmm6_4
		  __m128 x_low; // xmm0
		  __m128 v27; // xmm3
		  __m128 y_low; // xmm1
		  Vector3 *v29; // rax
		  __int64 v30; // xmm3_8
		  MethodInfo *v31; // r9
		  Vector3 *v32; // rax
		  float z; // ecx
		  MethodInfo *v34; // r9
		  Vector3 *v35; // rax
		  MethodInfo *v36; // r9
		  __int64 v37; // xmm3_8
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *renderers; // rax
		  __m128i v39; // xmm6
		  __m128 v40; // xmm7
		  __m128 v41; // xmm8
		  float v42; // xmm9_4
		  float v43; // xmm2_4
		  float3 *v44; // rax
		  __int64 v45; // xmm2_8
		  MethodInfo *v46; // r8
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  MethodInfo *v49; // r9
		  float v50; // xmm0_4
		  float v51; // xmm6_4
		  __int64 v52; // xmm10_8
		  float v53; // esi
		  __m128 v54; // xmm3
		  float v55; // eax
		  MethodInfo *v56; // r9
		  Vector3 *v57; // rax
		  __m128 v58; // xmm0
		  __m128 v59; // xmm5
		  float v60; // xmm4_4
		  MethodInfo *v61; // r9
		  float3 *v62; // rax
		  __int64 v63; // xmm2_8
		  MethodInfo *v64; // r9
		  uint3 *v65; // rax
		  float v66; // edi
		  struct MethodInfo *v67; // rbx
		  int32_t Entry; // eax
		  __int64 v69; // rdx
		  MethodInfo *v70; // r9
		  __int64 v71; // xmm0_8
		  float3 *v72; // rax
		  __int64 v73; // xmm2_8
		  MethodInfo *v74; // r8
		  __int64 v75; // rdx
		  __int64 v76; // rcx
		  MethodInfo *v77; // r9
		  float v78; // xmm0_4
		  Vector3 *v79; // rax
		  __m128 v80; // xmm3
		  MethodInfo *v81; // r9
		  Vector3 *v82; // rax
		  __m128 v83; // xmm0
		  __m128 v84; // xmm5
		  float v85; // xmm4_4
		  MethodInfo *v86; // r9
		  float3 *v87; // rax
		  __int64 v88; // xmm2_8
		  MethodInfo *v89; // r9
		  uint3 *v90; // rax
		  char IsRendererVisible; // al
		  unsigned __int8 (__fastcall *v92)(__int64); // rax
		  void (__fastcall *v93)(__int64, Bounds *); // rax
		  MethodInfo *v94; // r9
		  float boundSizeOffset; // xmm2_4
		  MethodInfo *v96; // r9
		  Vector3 *v97; // rax
		  __int64 v98; // r8
		  __int64 v99; // xmm3_8
		  MethodInfo *v100; // r9
		  Vector3 *v101; // rax
		  __int64 v102; // xmm3_8
		  MethodInfo *v103; // r9
		  Vector3 *v104; // rax
		  __m128i v105; // xmm4
		  __int64 v106; // xmm3_8
		  __int128 v107; // xmm0
		  struct MethodInfo *v108; // rbx
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  unsigned __int8 (__fastcall *v110)(__int64); // rax
		  __int64 (__fastcall *v111)(__int64); // rax
		  __int64 v112; // rsi
		  __int64 (__fastcall *v113)(__int64); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v115; // rax
		  __int64 v116; // rax
		  Vector3 value; // [rsp+40h] [rbp-C0h] BYREF
		  Vector3 vector; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 v119; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 m_Extents; // [rsp+70h] [rbp-90h] BYREF
		  uint3 v121; // [rsp+80h] [rbp-80h] BYREF
		  Bounds v122; // [rsp+90h] [rbp-70h] BYREF
		  Bounds v123; // [rsp+B0h] [rbp-50h] BYREF
		  Vector3 v124; // [rsp+D0h] [rbp-30h] BYREF
		  Bounds v125; // [rsp+E0h] [rbp-20h]
		  Vector3 v126; // [rsp+100h] [rbp+0h] BYREF
		  Vector3 v127; // [rsp+110h] [rbp+10h] BYREF
		  Vector3 v128; // [rsp+120h] [rbp+20h] BYREF
		  Vector3 v129; // [rsp+130h] [rbp+30h] BYREF
		
		  items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v9 = checkVisibility;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  entries = (_DWORD *)*items[23];
		  if ( !entries )
		    goto LABEL_97;
		  if ( (int)entries[6] > 4138 )
		  {
		    if ( !*((_DWORD *)items + 56) )
		    {
		      il2cpp_runtime_class_init_1(items);
		      items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    entries = (_DWORD *)*items[23];
		    if ( !entries )
		      goto LABEL_97;
		    if ( entries[6] <= 0x102Au )
		      goto LABEL_102;
		    if ( *((_QWORD *)entries + 4142) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(4138, 0LL);
		      if ( !Patch )
		        goto LABEL_97;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1459(
		        Patch,
		        (Object *)this,
		        (Object *)camera,
		        v9,
		        (Object *)targetMap,
		        fallbackBounds,
		        0LL);
		      return;
		    }
		  }
		  if ( !this->fields.renderers || !this->fields.boneSpheres || !this->fields.boneSpheres->fields._size )
		    return;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !camera )
		    return;
		  items = (_QWORD **)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !camera->fields._._._.m_CachedPtr )
		    return;
		  v12 = (__m128)0x7F800000u;
		  v13 = 0;
		  v14 = (__m128)0xFF800000;
		  v15 = (__m128)0x7F800000u;
		  boneSpheres = this->fields.boneSpheres;
		  v17 = INFINITY;
		  v18 = (__m128)0xFF800000;
		  v19 = -INFINITY;
		  v20 = 0;
		  if ( !boneSpheres )
		    goto LABEL_97;
		  size = boneSpheres->fields._size;
		  if ( size > 0 )
		  {
		    do
		    {
		      entries = this->fields.boneSpheres;
		      if ( !entries )
		        goto LABEL_97;
		      if ( v20 >= entries[6] )
		LABEL_114:
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      entries = (_DWORD *)*((_QWORD *)entries + 2);
		      if ( !entries )
		        goto LABEL_97;
		      if ( v20 >= entries[6] )
		        goto LABEL_102;
		      v22 = *(__m128 *)&entries[6 * v20 + 8];
		      *(_QWORD *)&v122.m_Extents.y = *(_QWORD *)&entries[6 * v20 + 12];
		      *(__m128 *)&v122.m_Center.x = v22;
		      *(_QWORD *)&v125.m_Extents.y = *(_QWORD *)&v122.m_Extents.y;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      items = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( v22.m128_u64[0] )
		      {
		        items = (_QWORD **)TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( *(_QWORD *)(v22.m128_u64[0] + 16) )
		        {
		          m_Extents = v122.m_Extents;
		          *(_QWORD *)&v119.x = 0LL;
		          v119.z = 0.0;
		          v23 = qword_18F370188;
		          if ( !qword_18F370188 )
		          {
		            v23 = (__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Transform::TransformPoint_Injected(Unity"
		                                                                    "Engine.Vector3&,UnityEngine.Vector3&)");
		            if ( !v23 )
		            {
		              v115 = sub_1802EE1B8("UnityEngine.Transform::TransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)");
		              sub_18007E1B0(v115, 0LL);
		            }
		            qword_18F370188 = v23;
		          }
		          v23(v22.m128_u64[0], &m_Extents, &v119);
		          x_low = (__m128)LODWORD(v119.x);
		          y_low = (__m128)LODWORD(v119.y);
		          v24 = (__m128)LODWORD(v119.x);
		          v27 = (__m128)LODWORD(v119.y);
		          v25 = _mm_shuffle_ps(v22, v22, 170).m128_f32[0];
		          x_low.m128_f32[0] = v119.x + v25;
		          v27.m128_f32[0] = v119.y - v25;
		          y_low.m128_f32[0] = v119.y + v25;
		          if ( v12.m128_f32[0] > (float)(v119.x - v25) )
		          {
		            v24.m128_f32[0] = v119.x - v25;
		            v12 = v24;
		          }
		          if ( x_low.m128_f32[0] > v14.m128_f32[0] )
		            v14 = x_low;
		          if ( v15.m128_f32[0] > v27.m128_f32[0] )
		            v15 = v27;
		          if ( y_low.m128_f32[0] > v18.m128_f32[0] )
		            v18 = y_low;
		          if ( v17 > (float)(v119.z - v25) )
		            v17 = v119.z - v25;
		          if ( (float)(v119.z + v25) > v19 )
		            v19 = v119.z + v25;
		        }
		      }
		      ++v20;
		    }
		    while ( (int)v20 < size );
		    v9 = checkVisibility;
		  }
		  memset(&v123, 0, sizeof(v123));
		  m_Extents.z = v17;
		  *(_QWORD *)&m_Extents.x = _mm_unpacklo_ps(v12, v15).m128_u64[0];
		  v119.z = v19;
		  *(_QWORD *)&v119.x = _mm_unpacklo_ps(v14, v18).m128_u64[0];
		  v29 = UnityEngine::Vector3::op_Subtraction(&value, &v119, &m_Extents, (MethodInfo *)targetMap);
		  v30 = *(_QWORD *)&v29->x;
		  *(float *)&v29 = v29->z;
		  *(_QWORD *)&m_Extents.x = v30;
		  LODWORD(m_Extents.z) = (_DWORD)v29;
		  v32 = UnityEngine::Vector3::op_Multiply(&value, &m_Extents, 0.5, v31);
		  z = v32->z;
		  *(_QWORD *)&v123.m_Extents.x = *(_QWORD *)&v32->x;
		  v123.m_Extents.z = z;
		  m_Extents.z = z;
		  *(_QWORD *)&v119.x = _mm_unpacklo_ps(v12, v15).m128_u64[0];
		  v119.z = v17;
		  *(_QWORD *)&m_Extents.x = *(_QWORD *)&v123.m_Extents.x;
		  v35 = UnityEngine::Vector3::op_Addition(&v127, &v119, &m_Extents, v34);
		  v37 = *(_QWORD *)&v35->x;
		  *(float *)&v35 = v35->z;
		  *(_QWORD *)&v123.m_Center.x = v37;
		  LODWORD(v123.m_Center.z) = (_DWORD)v35;
		  while ( 1 )
		  {
		    renderers = this->fields.renderers;
		    if ( !renderers )
		      goto LABEL_97;
		    if ( (signed int)v13 >= renderers->fields._size )
		      break;
		    if ( v13 >= renderers->fields._size )
		      goto LABEL_114;
		    items = (_QWORD **)renderers->fields._items;
		    if ( !items )
		      goto LABEL_97;
		    if ( v13 >= *((_DWORD *)items + 6) )
		      goto LABEL_102;
		    v39 = *(__m128i *)&items[2 * (int)v13 + 4];
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    items = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( v39.m128i_i64[0] )
		    {
		      items = (_QWORD **)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( *(_QWORD *)(v39.m128i_i64[0] + 16) && !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v39, 8)) )
		      {
		        if ( v9 )
		        {
		          IsRendererVisible = HG::Rendering::Runtime::HGCharacterHelper::IsRendererVisible(
		                                this,
		                                (Renderer *)v39.m128i_i64[0],
		                                0LL);
		LABEL_79:
		          if ( IsRendererVisible )
		          {
		            v92 = (unsigned __int8 (__fastcall *)(__int64))qword_18F36F4F8;
		            if ( !qword_18F36F4F8 )
		            {
		              v92 = (unsigned __int8 (__fastcall *)(__int64))sub_180059EA0("UnityEngine.Renderer::GetIsRealtimeShadowCaster()");
		              qword_18F36F4F8 = (__int64)v92;
		            }
		            if ( v92(v39.m128i_i64[0]) )
		            {
		              v93 = (void (__fastcall *)(__int64, Bounds *))qword_18F36F560;
		              memset(&v122, 0, sizeof(v122));
		              if ( !qword_18F36F560 )
		              {
		                v93 = (void (__fastcall *)(__int64, Bounds *))il2cpp_resolve_icall_1(
		                                                                "UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		                if ( !v93 )
		                {
		                  v116 = sub_1802EE1B8("UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
		                  sub_18007E1B0(v116, 0LL);
		                }
		                qword_18F36F560 = (__int64)v93;
		              }
		              v93(v39.m128i_i64[0], &v122);
		              v125 = v122;
		              m_Extents = v122.m_Extents;
		              UnityEngine::Vector3::op_Multiply(&v128, &m_Extents, 2.0, v94);
		              boundSizeOffset = this->fields.boundSizeOffset;
		              v119.z = 1.0;
		              *(_QWORD *)&v119.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		              v97 = UnityEngine::Vector3::op_Multiply(&v129, &v119, boundSizeOffset, v96);
		              *(_QWORD *)&vector.x = *(_QWORD *)v98;
		              v99 = *(_QWORD *)&v97->x;
		              v126.z = v97->z;
		              LODWORD(v97) = *(_DWORD *)(v98 + 8);
		              *(_QWORD *)&v126.x = v99;
		              LODWORD(vector.z) = (_DWORD)v97;
		              v101 = UnityEngine::Vector3::op_Subtraction(&v124, &vector, &v126, v100);
		              v102 = *(_QWORD *)&v101->x;
		              *(float *)&v101 = v101->z;
		              *(_QWORD *)&value.x = v102;
		              LODWORD(value.z) = (_DWORD)v101;
		              v104 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v121, &value, 0.5, v103);
		              LODWORD(v125.m_Center.z) = _mm_cvtsi128_si32(_mm_srli_si128(v105, 8));
		              v106 = *(_QWORD *)&v104->x;
		              *(float *)&v104 = v104->z;
		              *(_QWORD *)&v125.m_Extents.x = v106;
		              *((_QWORD *)&v107 + 1) = *(_QWORD *)&v125.m_Center.z;
		              LODWORD(v125.m_Extents.z) = (_DWORD)v104;
		              *(double *)&v107 = *(double *)v105.m128i_i64;
		              *(_OWORD *)&v125.m_Center.x = v107;
		              *(_OWORD *)&v122.m_Center.x = v107;
		              *(_QWORD *)&v122.m_Extents.y = *(_QWORD *)&v125.m_Extents.y;
		              UnityEngine::Bounds::Encapsulate(&v123, &v122, 0LL);
		            }
		          }
		          goto LABEL_60;
		        }
		        v110 = (unsigned __int8 (__fastcall *)(__int64))qword_18F36F4D0;
		        if ( !qword_18F36F4D0 )
		        {
		          v110 = (unsigned __int8 (__fastcall *)(__int64))sub_180059EA0("UnityEngine.Renderer::get_enabled()");
		          qword_18F36F4D0 = (__int64)v110;
		        }
		        if ( v110(v39.m128i_i64[0]) )
		        {
		          v111 = (__int64 (__fastcall *)(__int64))qword_18F36FBC8;
		          if ( !qword_18F36FBC8 )
		          {
		            v111 = (__int64 (__fastcall *)(__int64))sub_180059EA0("UnityEngine.Component::get_gameObject()");
		            qword_18F36FBC8 = (__int64)v111;
		          }
		          v112 = v111(v39.m128i_i64[0]);
		          if ( !v112 )
		            goto LABEL_97;
		          v113 = (__int64 (__fastcall *)(__int64))qword_18F36FC70;
		          if ( !qword_18F36FC70 )
		          {
		            v113 = (__int64 (__fastcall *)(__int64))sub_180059EA0("UnityEngine.GameObject::get_activeInHierarchy()");
		            qword_18F36FC70 = (__int64)v113;
		          }
		          IsRendererVisible = v113(v112);
		          v9 = checkVisibility;
		          goto LABEL_79;
		        }
		      }
		    }
		LABEL_60:
		    ++v13;
		  }
		  v40 = (__m128)LODWORD(v123.m_Center.x);
		  v41 = (__m128)LODWORD(v123.m_Center.y);
		  v42 = v123.m_Center.z;
		  vector.z = v123.m_Center.z;
		  v43 = fallbackBounds->m_Center.z;
		  *(_QWORD *)&v121.x = *(_QWORD *)&fallbackBounds->m_Center.x;
		  *(_QWORD *)&value.x = _mm_unpacklo_ps(
		                          (__m128)*(unsigned __int64 *)&v121.x,
		                          _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v121.x, (__m128)*(unsigned __int64 *)&v121.x, 85)).m128_u64[0];
		  *(_QWORD *)&vector.x = _mm_unpacklo_ps((__m128)LODWORD(v123.m_Center.x), (__m128)LODWORD(v123.m_Center.y)).m128_u64[0];
		  value.z = v43;
		  v44 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v121, (float3 *)&vector, (float3 *)&value, v36);
		  v45 = *(_QWORD *)&v44->x;
		  value.z = v44->z;
		  vector.z = value.z;
		  *(_QWORD *)&value.x = v45;
		  *(_QWORD *)&vector.x = v45;
		  v50 = Dest::Math::Vector3ex::Dot(&vector, &value, v46);
		  if ( v50 < 0.0 )
		    v51 = sub_1803386C0(v48, v47);
		  else
		    v51 = fsqrt(v50);
		  v52 = *(_QWORD *)&v123.m_Extents.x;
		  v53 = v123.m_Extents.z;
		  value = v123.m_Extents;
		  v54 = (__m128)*(unsigned __int64 *)&UnityEngine::Vector3::op_Multiply((Vector3 *)&v121, &value, 2.0, v49)->x;
		  v55 = fallbackBounds->m_Extents.z;
		  *(_QWORD *)&value.x = *(_QWORD *)&fallbackBounds->m_Extents.x;
		  value.z = v55;
		  v57 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v121, &value, 2.0, v56);
		  v58 = (__m128)*(unsigned __int64 *)&v57->x;
		  value.z = v57->z;
		  *(_QWORD *)&value.x = _mm_unpacklo_ps(v58, _mm_shuffle_ps(v58, v58, 85)).m128_u64[0];
		  *(_QWORD *)&vector.x = _mm_unpacklo_ps(v59, _mm_shuffle_ps(v54, v54, 85)).m128_u64[0];
		  vector.z = v60;
		  v62 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v121, (float3 *)&vector, (float3 *)&value, v61);
		  v63 = *(_QWORD *)&v62->x;
		  *(float *)&v62 = v62->z;
		  *(_QWORD *)&value.x = v63;
		  LODWORD(value.z) = (_DWORD)v62;
		  v65 = Unity::Mathematics::uint3::op_BitwiseAnd(&v121, (uint3 *)&value, 0x7FFFFFFFu, v64);
		  v66 = *(float *)&v65->z;
		  *(_QWORD *)&v119.x = *(_QWORD *)&v65->x;
		  if ( !targetMap )
		    goto LABEL_97;
		  v67 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue;
		  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		        + 4) )
		    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
		  Entry = System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::FindEntry(
		            (Dictionary_2_System_Object_UnityEngine_Bounds_ *)targetMap,
		            (Object *)camera,
		            (MethodInfo *)v67->klass->rgctx_data[22].rgctxDataDummy);
		  if ( Entry >= 0 )
		  {
		    entries = targetMap->fields._entries;
		    if ( entries )
		    {
		      if ( (unsigned int)Entry < entries[6] )
		      {
		        v71 = *(_QWORD *)&entries[10 * Entry + 16];
		        *(_OWORD *)&v122.m_Center.x = *(_OWORD *)&entries[10 * Entry + 12];
		        *(_QWORD *)&v122.m_Extents.y = v71;
		        vector.z = v42;
		        *(_QWORD *)&value.x = _mm_unpacklo_ps(
		                                *(__m128 *)&v122.m_Center.x,
		                                _mm_shuffle_ps(*(__m128 *)&v122.m_Center.x, *(__m128 *)&v122.m_Center.x, 85)).m128_u64[0];
		        *(_QWORD *)&vector.x = _mm_unpacklo_ps(v40, v41).m128_u64[0];
		        LODWORD(value.z) = _mm_shuffle_ps(*(__m128 *)&v122.m_Center.x, *(__m128 *)&v122.m_Center.x, 170).m128_u32[0];
		        v72 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v121, (float3 *)&vector, (float3 *)&value, v70);
		        v73 = *(_QWORD *)&v72->x;
		        value.z = v72->z;
		        vector.z = value.z;
		        *(_QWORD *)&value.x = v73;
		        *(_QWORD *)&vector.x = v73;
		        v78 = Dest::Math::Vector3ex::Dot(&vector, &value, v74);
		        if ( v78 < 0.0 )
		          v51 = sub_1803386C0(v76, v75);
		        else
		          v51 = fsqrt(v78);
		        *(_QWORD *)&value.x = v52;
		        value.z = v53;
		        v79 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v121, &value, 2.0, v77);
		        v80 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v79->x, (__m128)*(unsigned __int64 *)&v79->x, 85);
		        value = v122.m_Extents;
		        v82 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v121, &value, 2.0, v81);
		        v83 = (__m128)*(unsigned __int64 *)&v82->x;
		        value.z = v82->z;
		        *(_QWORD *)&value.x = _mm_unpacklo_ps(v83, _mm_shuffle_ps(v83, v83, 85)).m128_u64[0];
		        *(_QWORD *)&vector.x = _mm_unpacklo_ps(v84, v80).m128_u64[0];
		        vector.z = v85;
		        v87 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v121, (float3 *)&vector, (float3 *)&value, v86);
		        v88 = *(_QWORD *)&v87->x;
		        *(float *)&v87 = v87->z;
		        *(_QWORD *)&value.x = v88;
		        LODWORD(value.z) = (_DWORD)v87;
		        v90 = Unity::Mathematics::uint3::op_BitwiseAnd(&v121, (uint3 *)&value, 0x7FFFFFFFu, v89);
		        v66 = *(float *)&v90->z;
		        *(_QWORD *)&v119.x = *(_QWORD *)&v90->x;
		        goto LABEL_72;
		      }
		LABEL_102:
		      sub_1800D2AB0(items, entries);
		    }
		LABEL_97:
		    sub_1800D8260(items, entries);
		  }
		LABEL_72:
		  if ( v119.x > 0.02 || v119.y > 0.02 || v66 > 0.02 || v51 > 0.02 )
		  {
		    v108 = MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item;
		    if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item->klass->rgctx_data[24].rgctxDataDummy
		          + 4) )
		    {
		      LOBYTE(v69) = v119.y > 0.02;
		      (*(void (__fastcall **)(const Il2CppRGCTXData *, __int64))MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item->klass->rgctx_data[24].rgctxDataDummy)(
		        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::set_Item->klass->rgctx_data,
		        v69);
		    }
		    LOBYTE(v70) = 1;
		    rgctx_data = v108->klass->rgctx_data;
		    v122 = v123;
		    System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::TryInsert(
		      (Dictionary_2_System_Object_UnityEngine_Bounds_ *)targetMap,
		      (Object *)camera,
		      &v122,
		      (InsertionBehavior__Enum)v70,
		      (MethodInfo *)rgctx_data[24].rgctxDataDummy);
		  }
		}
		
		public void UpdateBoundsBySphere(Camera camera) {} // 0x0000000183E11EF0-0x0000000183E11F70
		// Void UpdateBoundsBySphere(Camera)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphere(
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
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
		  if ( wrapperArray->max_length.size <= 4137 )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphereInternal(
		      this,
		      camera,
		      1,
		      this->fields.m_CameraBoundsMap,
		      &this->fields.bounds,
		      0LL);
		    return;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x1029 )
		    sub_1800D2AB0(v5, camera);
		  if ( !*((_QWORD *)&v5[88]._0.byval_arg + 1) )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4137, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, camera);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		public void UpdateHDPLSBoundsBySphere(Camera camera) {} // 0x0000000183E11E60-0x0000000183E11EF0
		// Void UpdateHDPLSBoundsBySphere(Camera)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateHDPLSBoundsBySphere(
		        HGCharacterHelper *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
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
		  if ( wrapperArray->max_length.size <= 4142 )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphereInternal(
		      this,
		      camera,
		      0,
		      this->fields.m_CameraHDPLSBoundsMap,
		      &this->fields.hdplsBounds,
		      0LL);
		    return;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x102E )
		    sub_1800D2AB0(v5, camera);
		  if ( !v5[88]._0.declaringType )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4142, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, camera);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		public void UpdateShadowRenderingLayer(short index, bool onDequeue) {} // 0x00000001833EF380-0x00000001833EF680
		// Void UpdateShadowRenderingLayer(Int16, Boolean)
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(
		        HGCharacterHelper *this,
		        int16_t index,
		        bool onDequeue,
		        MethodInfo *method)
		{
		  int v4; // ebx
		  bool v7; // r12
		  uint32_t ShadowLayer; // eax
		  int v9; // ebx
		  unsigned int v10; // esi
		  __int64 v11; // rdx
		  struct Object_1__Class *items; // rcx
		  int32_t v13; // r13d
		  __int16 v14; // ax
		  unsigned __int16 v15; // bp
		  uint16_t v16; // r15
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *renderers; // rax
		  __m128i v19; // xmm0
		  Renderer *v20; // rdi
		  void (__fastcall *v21)(Renderer *, _QWORD); // rax
		  void (__fastcall *v22)(Renderer *, _QWORD); // rax
		  List_1_UnityEngine_Renderer_ *shadowProxyRenderers; // rax
		  Object *Item; // rax
		  Renderer *v25; // rbx
		  __int64 v26; // rax
		  __int64 v27; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int16 v29; // [rsp+30h] [rbp-48h]
		  int v30; // [rsp+34h] [rbp-44h]
		  __m128i v31; // [rsp+38h] [rbp-40h]
		
		  v4 = index;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4130, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    v7 = HG::Rendering::Runtime::HGCharacters::EnableCharacterSelfShadow(this, 0LL);
		    ShadowLayer = HG::Rendering::Runtime::HGCharacters::GetShadowLayer(v4, 0LL);
		    v9 = v4 + 1;
		    v10 = ShadowLayer | 2;
		    v30 = ShadowLayer | 2;
		    if ( v9 > 14 )
		      LOWORD(v9) = 14;
		    v13 = 0;
		    if ( HG::Rendering::Runtime::HGCharacterHelper::get_enableCastHDPunctualLightShadow(this, 0LL) )
		      v14 = 15;
		    else
		      v14 = 0;
		    v15 = 0;
		    v16 = 0;
		    if ( !onDequeue )
		    {
		      v15 = v9;
		      v16 = v14;
		    }
		    v29 = v15;
		    for ( i = 0; ; ++i )
		    {
		      renderers = this->fields.renderers;
		      if ( !renderers )
		        goto LABEL_44;
		      if ( i >= renderers->fields._size )
		        break;
		      if ( (unsigned int)i >= renderers->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      items = (struct Object_1__Class *)renderers->fields._items;
		      if ( !items )
		        goto LABEL_44;
		      if ( (unsigned int)i >= LODWORD(items->_0.namespaze) )
		        sub_1800D2AB0(items, v11);
		      v19 = *((__m128i *)&items->_0.byval_arg + i);
		      v31 = v19;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v19 = v31;
		      }
		      items = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v19 = v31;
		      }
		      v20 = (Renderer *)v19.m128i_i64[0];
		      if ( v19.m128i_i64[0] )
		      {
		        items = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v19 = v31;
		        }
		        if ( v20->fields._._.m_CachedPtr )
		        {
		          if ( ((unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v19, 9)) & v7) == 0
		            || !HG::Rendering::Runtime::HGCharacterHelper::get_enableCastSelfShadow(this, 0LL) )
		          {
		            v10 = 2;
		            v15 = v16;
		          }
		          v21 = (void (__fastcall *)(Renderer *, _QWORD))qword_18F36F520;
		          if ( !qword_18F36F520 )
		          {
		            v21 = (void (__fastcall *)(Renderer *, _QWORD))il2cpp_resolve_icall_1(
		                                                             "UnityEngine.Renderer::set_renderingLayerMask(System.UInt32)");
		            if ( !v21 )
		            {
		              v26 = sub_1802EE1B8("UnityEngine.Renderer::set_renderingLayerMask(System.UInt32)");
		              sub_18007E1B0(v26, 0LL);
		            }
		            qword_18F36F520 = (__int64)v21;
		          }
		          v21(v20, v10);
		          if ( !UnityEngine::Renderer::GetIsRealtimeShadowCaster(v20, 0LL) )
		            v15 = 0;
		          v22 = (void (__fastcall *)(Renderer *, _QWORD))qword_18F36F510;
		          if ( !qword_18F36F510 )
		          {
		            v22 = (void (__fastcall *)(Renderer *, _QWORD))il2cpp_resolve_icall_1("UnityEngine.Renderer::set_characterIndex(System.UInt16)");
		            if ( !v22 )
		            {
		              v27 = sub_1802EE1B8("UnityEngine.Renderer::set_characterIndex(System.UInt16)");
		              sub_18007E1B0(v27, 0LL);
		            }
		            qword_18F36F510 = (__int64)v22;
		          }
		          v22(v20, v15);
		        }
		      }
		      v15 = v29;
		      v10 = v30;
		    }
		    while ( 1 )
		    {
		      shadowProxyRenderers = this->fields.shadowProxyRenderers;
		      if ( !shadowProxyRenderers )
		        break;
		      if ( v13 >= shadowProxyRenderers->fields._size )
		        return;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               (List_1_System_Object_ *)this->fields.shadowProxyRenderers,
		               v13,
		               MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Item);
		      items = TypeInfo::UnityEngine::Object;
		      v25 = (Renderer *)Item;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        items = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          items = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( v25 )
		      {
		        if ( !items->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(items);
		        if ( v25->fields._._.m_CachedPtr )
		        {
		          UnityEngine::Renderer::set_renderingLayerMask(v25, 2u, 0LL);
		          UnityEngine::Renderer::set_characterIndex(v25, v16, 0LL);
		        }
		      }
		      ++v13;
		    }
		LABEL_44:
		    sub_1800D8260(items, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4130, 0LL);
		  if ( !Patch )
		    goto LABEL_44;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1458(Patch, (Object *)this, v4, onDequeue, 0LL);
		}
		
		public void SetBoundSizeOffset(float offset) {} // 0x0000000189C44A98-0x0000000189C44AF4
		// Void SetBoundSizeOffset(Single)
		void HG::Rendering::Runtime::HGCharacterHelper::SetBoundSizeOffset(
		        HGCharacterHelper *this,
		        float offset,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4151, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4151, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, offset, 0LL);
		  }
		  else
		  {
		    this->fields.boundSizeOffset = offset;
		  }
		}
		
		private void CleanupInactiveCameraData(List<Camera> cameras) {} // 0x0000000189C44284-0x0000000189C44764
		// Void CleanupInactiveCameraData(List`1[UnityEngine.Camera])
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::Runtime::HGCharacterHelper::CleanupInactiveCameraData(
		        HGCharacterHelper *this,
		        List_1_UnityEngine_Camera_ *cameras,
		        MethodInfo *method)
		{
		  Object *v3; // rsi
		  HGCharacterHelper *v4; // rdi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_System_Object_ *v8; // rbx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Dictionary_2_TKey_TValue_KeyCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *Keys; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 *v14; // rdx
		  List_1_System_UInt64_ *list; // rcx
		  Object *currentKey; // r14
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  Dictionary_2_System_Object_UnityEngine_Bounds_ *m_CameraBoundsMap; // rcx
		  Dictionary_2_TKey_TValue_KeyCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *v21; // rax
		  Object *v22; // r14
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  Dictionary_2_System_Object_UnityEngine_Bounds_ *m_CameraHDPLSBoundsMap; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // [rsp+0h] [rbp-A8h] BYREF
		  List_1_T_Enumerator_System_UInt64_ v31; // [rsp+20h] [rbp-88h] BYREF
		  List_1_T_Enumerator_System_Object_ v32; // [rsp+38h] [rbp-70h] BYREF
		  Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Object_Beyond_Gameplay_NavMeshChunkManager_MapLoadRecord_ v33; // [rsp+50h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v34; // [rsp+68h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v35; // [rsp+70h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v36; // [rsp+78h] [rbp-30h] BYREF
		  Il2CppExceptionWrapper *v37; // [rsp+80h] [rbp-28h] BYREF
		
		  v3 = (Object *)cameras;
		  v4 = this;
		  memset(&v32, 0, sizeof(v32));
		  if ( IFix::WrappersManagerImpl::IsPatched(4144, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4144, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v29, v28);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v4, v3, 0LL);
		  }
		  else
		  {
		    v5 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Camera>);
		    v8 = (List_1_System_Object_ *)v5;
		    if ( !v5 )
		      sub_1800D8260(v7, v6);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v5,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::List);
		    if ( !v4->fields.m_CameraBoundsMap )
		      sub_1800D8260(v10, v9);
		    Keys = System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Keys(
		             (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4->fields.m_CameraBoundsMap,
		             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::get_Keys);
		    if ( !Keys )
		      sub_1800D8260(v13, v12);
		    System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v31,
		      (Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)Keys,
		      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<UnityEngine::Camera,UnityEngine::Bounds>::GetEnumerator);
		    v33 = (Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Object_Beyond_Gameplay_NavMeshChunkManager_MapLoadRecord_)v31;
		    v31._list = 0LL;
		    *(_QWORD *)&v31._index = &v33;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::Object,Beyond::Gameplay::NavMeshChunkManager::MapLoadRecord>::MoveNext(
		                &v33,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<UnityEngine::Camera,UnityEngine::Bounds>::MoveNext) )
		      {
		        currentKey = v33._currentKey;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( !UnityEngine::Object::op_Equality((Object_1 *)currentKey, 0LL, 0LL) )
		        {
		          if ( !v3 )
		            sub_1800D8250(v18, v17);
		          if ( System::Collections::Generic::List<System::Object>::Contains(
		                 (List_1_System_Object_ *)v3,
		                 currentKey,
		                 MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Contains) )
		          {
		            continue;
		          }
		        }
		        if ( !v8 )
		          sub_1800D8250(v18, v17);
		        sub_182F01190(v8, currentKey);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v34 )
		    {
		      v14 = &v30;
		      v31._list = (List_1_System_UInt64_ *)v34->ex;
		      list = v31._list;
		      if ( v31._list )
		        sub_18007E1E0(v31._list);
		      v3 = (Object *)cameras;
		      v4 = this;
		    }
		    if ( !v8 )
		      goto LABEL_51;
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      &v31,
		      (List_1_System_UInt64_ *)v8,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::GetEnumerator);
		    v32 = (List_1_T_Enumerator_System_Object_)v31;
		    v31._list = 0LL;
		    *(_QWORD *)&v31._index = &v32;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v32,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
		      {
		        m_CameraBoundsMap = (Dictionary_2_System_Object_UnityEngine_Bounds_ *)v4->fields.m_CameraBoundsMap;
		        if ( !m_CameraBoundsMap )
		          sub_1800D8250(0LL, v19);
		        System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::Remove(
		          m_CameraBoundsMap,
		          v32._current,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::Remove);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v35 )
		    {
		      v31._list = (List_1_System_UInt64_ *)v35->ex;
		      if ( v31._list )
		        sub_18007E1E0(v31._list);
		      v3 = (Object *)cameras;
		      v4 = this;
		    }
		    sub_183127A90(v8, MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Clear);
		    list = (List_1_System_UInt64_ *)v4->fields.m_CameraHDPLSBoundsMap;
		    if ( !list
		      || (v21 = System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Keys(
		                  (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)list,
		                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::get_Keys)) == 0LL )
		    {
		LABEL_51:
		      sub_1800D8250(list, v14);
		    }
		    System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v31,
		      (Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v21,
		      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<UnityEngine::Camera,UnityEngine::Bounds>::GetEnumerator);
		    v33 = (Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Object_Beyond_Gameplay_NavMeshChunkManager_MapLoadRecord_)v31;
		    v31._list = 0LL;
		    *(_QWORD *)&v31._index = &v33;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::Object,Beyond::Gameplay::NavMeshChunkManager::MapLoadRecord>::MoveNext(
		                &v33,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<UnityEngine::Camera,UnityEngine::Bounds>::MoveNext) )
		      {
		        v22 = v33._currentKey;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( !UnityEngine::Object::op_Equality((Object_1 *)v22, 0LL, 0LL) )
		        {
		          if ( !v3 )
		            sub_1800D8250(v24, v23);
		          if ( System::Collections::Generic::List<System::Object>::Contains(
		                 (List_1_System_Object_ *)v3,
		                 v22,
		                 MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Contains) )
		          {
		            continue;
		          }
		        }
		        sub_182F01190(v8, v22);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v36 )
		    {
		      v31._list = (List_1_System_UInt64_ *)v36->ex;
		      if ( v31._list )
		        sub_18007E1E0(v31._list);
		      v4 = this;
		    }
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      &v31,
		      (List_1_System_UInt64_ *)v8,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::GetEnumerator);
		    v32 = (List_1_T_Enumerator_System_Object_)v31;
		    v31._list = 0LL;
		    *(_QWORD *)&v31._index = &v32;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v32,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
		      {
		        m_CameraHDPLSBoundsMap = (Dictionary_2_System_Object_UnityEngine_Bounds_ *)v4->fields.m_CameraHDPLSBoundsMap;
		        if ( !m_CameraHDPLSBoundsMap )
		          sub_1800D8250(0LL, v25);
		        System::Collections::Generic::Dictionary<System::Object,UnityEngine::Bounds>::Remove(
		          m_CameraHDPLSBoundsMap,
		          v32._current,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::Remove);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v37 )
		    {
		      v31._list = (List_1_System_UInt64_ *)v37->ex;
		      if ( v31._list )
		        sub_18007E1E0(v31._list);
		    }
		  }
		}
		
		private void CleanUp() {} // 0x0000000183A47D70-0x0000000183A47E40
		// Void CleanUp()
		void HG::Rendering::Runtime::HGCharacterHelper::CleanUp(HGCharacterHelper *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  Dictionary_2_UnityEngine_Camera_UnityEngine_Bounds_ *m_CameraBoundsMap; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v6; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4152, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    HG::Rendering::Runtime::HGCharacters::DequeueCharacter(this, 0LL);
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v3;
		    if ( v3 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering,
		        0LL);
		      if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v6, 0LL);
		      m_CameraBoundsMap = this->fields.m_CameraBoundsMap;
		      if ( m_CameraBoundsMap )
		      {
		        System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear(
		          (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_CameraBoundsMap,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::Clear);
		        m_CameraBoundsMap = this->fields.m_CameraHDPLSBoundsMap;
		        if ( m_CameraBoundsMap )
		        {
		          System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear(
		            (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_CameraBoundsMap,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,UnityEngine::Bounds>::Clear);
		          return;
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_CameraBoundsMap, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4152, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDisable() {} // 0x0000000183A47D30-0x0000000183A47D70
		// Void OnDisable()
		void HG::Rendering::Runtime::HGCharacterHelper::OnDisable(HGCharacterHelper *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4154, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4154, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGCharacterHelper::CleanUp(this, 0LL);
		  }
		}
		
		private void OnDestroy() {} // 0x0000000183A48E10-0x0000000183A48E50
		// Void OnDestroy()
		void HG::Rendering::Runtime::HGCharacterHelper::OnDestroy(HGCharacterHelper *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4155, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4155, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGCharacterHelper::CleanUp(this, 0LL);
		  }
		}
		
		private void OnValidate() {} // 0x0000000189C44A3C-0x0000000189C44A98
		// Void OnValidate()
		void HG::Rendering::Runtime::HGCharacterHelper::OnValidate(HGCharacterHelper *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4156, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4156, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    HG::Rendering::Runtime::HGCharacters::SortAndRebuild(0LL);
		  }
		}
		
		public void UpdateBoneSpheresByBoundingBox() {} // 0x0000000189C44C10-0x0000000189C44E4C
		// Void UpdateBoneSpheresByBoundingBox()
		void HG::Rendering::Runtime::HGCharacterHelper::UpdateBoneSpheresByBoundingBox(
		        HGCharacterHelper *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *boneSpheres; // rcx
		  int32_t i; // esi
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_CharacterRendererInfo_ *renderers; // rax
		  Transform *transform; // rax
		  void *ptr; // rbx
		  Transform *v9; // r15
		  Bounds *localBounds; // rax
		  __m128i v11; // xmm6
		  __int64 v12; // xmm0_8
		  SkinnedMeshRenderer *v13; // rax
		  SkinnedMeshRenderer *v14; // r14
		  Object_1 *rootBone; // rbx
		  Component *v16; // rax
		  Vector3 *localPosition; // rax
		  Action_2_Google_Protobuf_IMessage_Object_ *v18; // xmm0_8
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  MonitorData *v21; // xmm6_8
		  float z; // ebx
		  Int32__Array **v23; // r9
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  __int64 v26; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SingleFieldAccessor v28; // [rsp+28h] [rbp-89h] BYREF
		  int v29; // [rsp+60h] [rbp-51h]
		  __int64 v30; // [rsp+68h] [rbp-49h] BYREF
		  int v31; // [rsp+70h] [rbp-41h]
		  _BYTE v32[24]; // [rsp+78h] [rbp-39h]
		  Bounds v33; // [rsp+98h] [rbp-19h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v34; // [rsp+B8h] [rbp+7h] BYREF
		  Vector3 v35; // [rsp+C8h] [rbp+17h] BYREF
		  Vector3 v36[2]; // [rsp+D8h] [rbp+27h] BYREF
		
		  memset(&v28, 0, 24);
		  if ( IFix::WrappersManagerImpl::IsPatched(4157, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4157, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_17:
		    sub_1800D8260(boneSpheres, v3);
		  }
		  boneSpheres = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.boneSpheres;
		  if ( !boneSpheres )
		    goto LABEL_17;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		    boneSpheres,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::Clear);
		  if ( this->fields.renderers )
		  {
		    for ( i = 0; ; ++i )
		    {
		      renderers = this->fields.renderers;
		      if ( !renderers )
		        goto LABEL_17;
		      if ( i >= renderers->fields._size )
		        break;
		      System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		        &v34,
		        (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)this->fields.renderers,
		        i,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::CharacterRendererInfo>::get_Item);
		      transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      ptr = v34.ptr;
		      v9 = transform;
		      if ( !v34.ptr )
		        goto LABEL_17;
		      localBounds = UnityEngine::Renderer::get_localBounds(&v33, (Renderer *)v34.ptr, 0LL);
		      v11 = *(__m128i *)&localBounds->m_Center.x;
		      v12 = *(_QWORD *)&localBounds->m_Extents.y;
		      *(_OWORD *)v32 = *(_OWORD *)&localBounds->m_Center.x;
		      *(_QWORD *)&v32[16] = v12;
		      v13 = (SkinnedMeshRenderer *)sub_180005050(ptr, TypeInfo::UnityEngine::SkinnedMeshRenderer);
		      v14 = v13;
		      if ( v13 )
		      {
		        rootBone = (Object_1 *)UnityEngine::SkinnedMeshRenderer::get_rootBone(v13, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality(rootBone, 0LL, 0LL) )
		        {
		          v16 = (Component *)UnityEngine::SkinnedMeshRenderer::get_rootBone(v14, 0LL);
		          if ( !v16 )
		            goto LABEL_17;
		          v9 = UnityEngine::Component::get_transform(v16, 0LL);
		        }
		      }
		      if ( !v9 )
		        goto LABEL_17;
		      localPosition = UnityEngine::Transform::get_localPosition(&v35, v9, 0LL);
		      v28.fields.hasDelegate = (Func_2_Google_Protobuf_IMessage_Boolean_ *)v11.m128i_i64[0];
		      v29 = _mm_cvtsi128_si32(_mm_srli_si128(v11, 8));
		      v18 = *(Action_2_Google_Protobuf_IMessage_Object_ **)&localPosition->x;
		      *(float *)&localPosition = localPosition->z;
		      v28.fields.setValueDelegate = v18;
		      LODWORD(v28.fields.clearDelegate) = (_DWORD)localPosition;
		      v20 = UnityEngine::Vector3::op_Subtraction(
		              v36,
		              (Vector3 *)&v28.fields.hasDelegate,
		              (Vector3 *)&v28.fields.setValueDelegate,
		              v19);
		      v21 = *(MonitorData **)&v20->x;
		      z = v20->z;
		      v30 = *(_QWORD *)&v32[12];
		      v31 = *(_DWORD *)&v32[20];
		      *(float *)&v18 = sub_182F9FF00(&v30);
		      v23 = (Int32__Array **)this->fields.boneSpheres;
		      LODWORD(v28.monitor) = (_DWORD)v18;
		      *(MonitorData **)((char *)&v28.monitor + 4) = v21;
		      *((float *)&v28.fields._.getValueDelegate + 1) = z;
		      v28.klass = (SingleFieldAccessor__Class *)v9;
		      ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		        &v28,
		        v24,
		        v25,
		        v23);
		      if ( !v26 )
		        goto LABEL_17;
		      *(_OWORD *)&v33.m_Center.x = *(_OWORD *)&v28.klass;
		      *(_QWORD *)&v33.m_Extents.y = v28.fields._.getValueDelegate;
		      sub_180478D70(
		        v26,
		        &v33,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::Add);
		    }
		    this->fields.enableSphereBasedBounds = 1;
		  }
		}
		
	}
}
