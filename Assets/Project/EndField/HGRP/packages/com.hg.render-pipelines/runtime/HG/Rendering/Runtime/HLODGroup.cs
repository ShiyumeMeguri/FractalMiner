using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HLODGroup : MonoBehaviour // TypeDefIndex: 37738
	{
		// Fields
		[SerializeField]
		private int _hlodCombinedTexSize; // 0x18
		[SerializeField]
		private Renderer _hlodRenderer; // 0x20
		[SerializeField]
		private List<Renderer> _rendererList; // 0x28
		[SerializeField]
		private HLODGroup _parentHLODGroup; // 0x30
		[SerializeField]
		private List<HLODGroup> _childHLODGroupList; // 0x38
		private bool m_needSyncHLODInfo; // 0x40
		private static IEnumerable s_hlodTextureSizeList; // 0x00
	
		// Properties
		public bool needSyncHLODInfo { get => default; } // 0x0000000189D033FC-0x0000000189D03448 
		// Boolean get_needSyncHLODInfo()
		bool HG::Rendering::Runtime::HLODGroup::get_needSyncHLODInfo(HLODGroup *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1765, 0LL) )
		    return this->fields.m_needSyncHLODInfo;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1765, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public float hlodDistance { get => default; } // 0x0000000189D03250-0x0000000189D033AC 
		// Single get_hlodDistance()
		float HG::Rendering::Runtime::HLODGroup::get_hlodDistance(HLODGroup *this, MethodInfo *method)
		{
		  struct StreamingSettingParameters__Class *v3; // rcx
		  Renderer *s_parameters; // rdx
		  Renderer__Class *klass; // rsi
		  MonitorData *monitor; // r14
		  Object_1 *hlodRenderer; // rbx
		  Bounds *bounds; // rax
		  __int64 v9; // xmm1_8
		  float v10; // xmm6_4
		  SettingParameter_1_System_Single_ *v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds v14; // [rsp+20h] [rbp-60h] BYREF
		  _BYTE v15[24]; // [rsp+38h] [rbp-48h]
		  Bounds v16; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1766, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1766, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		    goto LABEL_14;
		  }
		  sub_1800036A0(TypeInfo::StreamingSettingParameters);
		  v3 = TypeInfo::StreamingSettingParameters;
		  s_parameters = (Renderer *)TypeInfo::StreamingSettingParameters->static_fields->s_parameters;
		  if ( !s_parameters )
		    goto LABEL_14;
		  klass = s_parameters[1].klass;
		  monitor = s_parameters[1].monitor;
		  hlodRenderer = (Object_1 *)this->fields._hlodRenderer;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality(hlodRenderer, 0LL, 0LL) )
		  {
		    s_parameters = this->fields._hlodRenderer;
		    if ( s_parameters )
		    {
		      bounds = UnityEngine::Renderer::get_bounds(&v14, s_parameters, 0LL);
		      v9 = *(_QWORD *)&bounds->m_Extents.y;
		      *(_OWORD *)v15 = *(_OWORD *)&bounds->m_Center.x;
		      *(_QWORD *)&v15[16] = v9;
		      *(_QWORD *)&v14.m_Center.x = *(_QWORD *)&v15[12];
		      s_parameters = this->fields._hlodRenderer;
		      if ( s_parameters )
		      {
		        *(_QWORD *)&v15[16] = *(_QWORD *)&UnityEngine::Renderer::get_bounds(&v16, s_parameters, 0LL)->m_Extents.y;
		        v10 = fmaxf(v14.m_Center.x, *(float *)&v15[20]);
		        goto LABEL_8;
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v3, s_parameters);
		  }
		  v10 = 0.0;
		LABEL_8:
		  if ( this->fields._childHLODGroupList && this->fields._childHLODGroupList->fields._size )
		    v11 = (SettingParameter_1_System_Single_ *)monitor;
		  else
		    v11 = (SettingParameter_1_System_Single_ *)klass;
		  return HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		           v11,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
		       + v10;
		}
		
		public int hlodCombinedTexSize { get => default; set {} } // 0x0000000189D03204-0x0000000189D03250 0x0000000189D035D4-0x0000000189D0362C
		// Int32 get_hlodCombinedTexSize()
		int32_t HG::Rendering::Runtime::HLODGroup::get_hlodCombinedTexSize(HLODGroup *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1767, 0LL) )
		    return this->fields._hlodCombinedTexSize;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1767, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_hlodCombinedTexSize(Int32)
		void HG::Rendering::Runtime::HLODGroup::set_hlodCombinedTexSize(HLODGroup *this, int32_t value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1768, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1768, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._hlodCombinedTexSize = value;
		  }
		}
		
		public Renderer hlodRenderer { get => default; set {} } // 0x0000000189D033AC-0x0000000189D033FC 0x0000000189D0362C-0x0000000189D03690
		// Renderer get_hlodRenderer()
		Renderer *HG::Rendering::Runtime::HLODGroup::get_hlodRenderer(HLODGroup *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1769, 0LL) )
		    return this->fields._hlodRenderer;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1769, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_710(Patch, (Object *)this, 0LL);
		}
		

		// Void set_hlodRenderer(Renderer)
		void HG::Rendering::Runtime::HLODGroup::set_hlodRenderer(HLODGroup *this, Renderer *value, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1770, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1770, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._hlodRenderer = value;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._hlodRenderer, v5, v6, v7, v11);
		  }
		}
		
		public HLODGroup parentHLODGroup { get => default; set {} } // 0x0000000189D03448-0x0000000189D03498 0x0000000189D03690-0x0000000189D036F4
		// HLODGroup get_parentHLODGroup()
		HLODGroup *HG::Rendering::Runtime::HLODGroup::get_parentHLODGroup(HLODGroup *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1771, 0LL) )
		    return this->fields._parentHLODGroup;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1771, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_711(Patch, (Object *)this, 0LL);
		}
		

		// Void set_parentHLODGroup(HLODGroup)
		void HG::Rendering::Runtime::HLODGroup::set_parentHLODGroup(HLODGroup *this, HLODGroup *value, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1772, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1772, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._parentHLODGroup = value;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._parentHLODGroup, v5, v6, v7, v11);
		  }
		}
		
		public List<Renderer> rendererList { get => default; } // 0x0000000189D03584-0x0000000189D035D4 
		// List`1[UnityEngine.Renderer] get_rendererList()
		List_1_UnityEngine_Renderer_ *HG::Rendering::Runtime::HLODGroup::get_rendererList(HLODGroup *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1773, 0LL) )
		    return this->fields._rendererList;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1773, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_712(Patch, (Object *)this, 0LL);
		}
		
		public List<HLODGroup> childHLODGroupList { get => default; } // 0x0000000189D03158-0x0000000189D031A8 
		// List`1[HG.Rendering.Runtime.HLODGroup] get_childHLODGroupList()
		List_1_HG_Rendering_Runtime_HLODGroup_ *HG::Rendering::Runtime::HLODGroup::get_childHLODGroupList(
		        HLODGroup *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1774, 0LL) )
		    return this->fields._childHLODGroupList;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1774, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_713(Patch, (Object *)this, 0LL);
		}
		
		public bool hasChildHLOD { get => default; } // 0x0000000189D031A8-0x0000000189D03204 
		// Boolean get_hasChildHLOD()
		bool HG::Rendering::Runtime::HLODGroup::get_hasChildHLOD(HLODGroup *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_HG_Rendering_Runtime_HLODGroup_ *childHLODGroupList; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1775, 0LL) )
		  {
		    childHLODGroupList = this->fields._childHLODGroupList;
		    if ( childHLODGroupList )
		      return childHLODGroupList->fields._size > 0;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1775, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public Vector3 referencePoint { get => default; } // 0x0000000189D03498-0x0000000189D03584 
		// Vector3 get_referencePoint()
		Vector3 *HG::Rendering::Runtime::HLODGroup::get_referencePoint(
		        Vector3 *__return_ptr retstr,
		        HLODGroup *this,
		        MethodInfo *method)
		{
		  Object_1 *hlodRenderer; // rbx
		  __int64 v6; // rcx
		  GameObject *gameObject; // rax
		  Renderer *v8; // rdx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  Bounds *bounds; // rax
		  __m128i v12; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // xmm0_8
		  float z; // eax
		  Bounds v17; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1776, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1776, 0LL);
		    if ( Patch )
		    {
		      position = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(&v17.m_Center, Patch, (Object *)this, 0LL);
		      goto LABEL_11;
		    }
		LABEL_9:
		    sub_1800D8260(v6, v8);
		  }
		  hlodRenderer = (Object_1 *)this->fields._hlodRenderer;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(hlodRenderer, 0LL, 0LL) )
		  {
		    gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( gameObject )
		    {
		      transform = UnityEngine::GameObject::get_transform(gameObject, 0LL);
		      if ( transform )
		      {
		        position = UnityEngine::Transform::get_position(&v17.m_Center, transform, 0LL);
		LABEL_11:
		        v14 = *(_QWORD *)&position->x;
		        z = position->z;
		        *(_QWORD *)&retstr->x = v14;
		        retstr->z = z;
		        return retstr;
		      }
		    }
		    goto LABEL_9;
		  }
		  v8 = this->fields._hlodRenderer;
		  if ( !v8 )
		    goto LABEL_9;
		  bounds = UnityEngine::Renderer::get_bounds(&v17, v8, 0LL);
		  v12 = *(__m128i *)&bounds->m_Center.x;
		  *(_QWORD *)&retstr->x = *(_QWORD *)&bounds->m_Center.x;
		  LODWORD(retstr->z) = _mm_cvtsi128_si32(_mm_srli_si128(v12, 8));
		  return retstr;
		}
		
	
		// Constructors
		public HLODGroup() {} // 0x0000000189D030C4-0x0000000189D03158
		// HLODGroup()
		void HG::Rendering::Runtime::HLODGroup::HLODGroup(HLODGroup *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_UnityEngine_Renderer_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_HG_Rendering_Runtime_HLODGroup_ *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  this->fields._hlodCombinedTexSize = 512;
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
		  v6 = (List_1_UnityEngine_Renderer_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v3,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List),
		        this->fields._rendererList = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._rendererList, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HLODGroup>),
		        (v11 = (List_1_HG_Rendering_Runtime_HLODGroup_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HLODGroup>::List);
		  this->fields._childHLODGroupList = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._childHLODGroupList, v12, v13, v14, v16);
		  this->fields.m_needSyncHLODInfo = 1;
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
		static HLODGroup() {} // 0x0000000189D02FC4-0x0000000189D030C4
		// HLODGroup()
		void HG::Rendering::Runtime::HLODGroup::cctor(MethodInfo *method)
		{
		  ValueDropdownList_1_System_Int32_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ValueDropdownList_1_System_Int32_ *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  v1 = (ValueDropdownList_1_System_Int32_ *)sub_18002C620(TypeInfo::Sirenix::OdinInspector::ValueDropdownList<int>);
		  v4 = v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList(
		    v1,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    (String *)"128 x 128",
		    128,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    (String *)"256 x 256",
		    256,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    (String *)"512 x 512",
		    512,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    (String *)"1024 x 1024",
		    1024,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    (String *)"2048 x 2048",
		    2048,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v4,
		    (String *)"4096 x 4096",
		    4096,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  TypeInfo::HG::Rendering::Runtime::HLODGroup->static_fields->s_hlodTextureSizeList = (IEnumerable *)v4;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HLODGroup->static_fields, v5, v6, v7, v8);
		}
		
	
		// Methods
		protected void OnEnable() {} // 0x0000000189D02F40-0x0000000189D02FC4
		// Void OnEnable()
		void HG::Rendering::Runtime::HLODGroup::OnEnable(HLODGroup *this, MethodInfo *method)
		{
		  Object_1 *hlodRenderer; // rbx
		  __int64 v4; // rdx
		  Renderer *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1777, 0LL) )
		  {
		    hlodRenderer = (Object_1 *)this->fields._hlodRenderer;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(hlodRenderer, 0LL, 0LL) )
		      return;
		    v5 = this->fields._hlodRenderer;
		    if ( v5 )
		    {
		      UnityEngine::Renderer::set_forceRenderingOff(v5, 1, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1777, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
