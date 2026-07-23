using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/HGCharacterShadowBoundOverride(\u89D2\u8272\u81EA\u9634\u5F71\u81EA\u5B9A\u4E49\u5305\u56F4\u76D2)")]
	[ExecuteAlways]
	public class HGCharacterShadowBoundOverride : MonoBehaviour // TypeDefIndex: 38690
	{
		// Fields
		[CrossSubDirectorRef]
		[SerializeField]
		private HGCharacterHelper targetCharacter; // 0x18
		[Range(0.01f, 1f)]
		[SerializeField]
		private float radius; // 0x20
		[SerializeField]
		private Vector3 scale; // 0x24
		[SerializeField]
		[Space]
		private bool followTarget; // 0x30
		[CrossSubDirectorRef]
		[SerializeField]
		private Transform followNode; // 0x38
		[SerializeField]
		private Vector3 followOffset; // 0x40
		private const float k_SnapHeightOffset = 1.5f; // Metadata: 0x0230409A
	
		// Constructors
		public HGCharacterShadowBoundOverride() {} // 0x0000000189C45578-0x0000000189C455CC
		// HGCharacterShadowBoundOverride()
		void HG::Rendering::Runtime::HGCharacterShadowBoundOverride::HGCharacterShadowBoundOverride(
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  Vector3 *one; // rax
		  Animator *z_low; // rdx
		  __int64 v4; // r8
		  MethodInfo *v5; // r9
		  Vector3 *Vector; // rax
		  float z; // ecx
		  __int64 v8; // r8
		  Vector3 v9[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields.radius = 0.2;
		  one = UnityEngine::Vector3::get_one(v9, method);
		  z_low = (Animator *)LODWORD(one->z);
		  *(_QWORD *)(v4 + 36) = *(_QWORD *)&one->x;
		  *(_DWORD *)(v4 + 44) = (_DWORD)z_low;
		  Vector = UnityEngine::Animator::GetVector(v9, z_low, v4, v5);
		  z = Vector->z;
		  *(_QWORD *)(v8 + 64) = *(_QWORD *)&Vector->x;
		  *(float *)(v8 + 72) = z;
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)v8, 0LL);
		}
		
	
		// Methods
		public IEnumerable GetTargetCharacterNodeDropDown() => default; // 0x0000000189C44FA8-0x0000000189C45040
		// IEnumerable GetTargetCharacterNodeDropDown()
		IEnumerable *HG::Rendering::Runtime::HGCharacterShadowBoundOverride::GetTargetCharacterNodeDropDown(
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  Object_1 *targetCharacter; // rbx
		  __int64 v4; // rdx
		  Component *v6; // rcx
		  GameObject *gameObject; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4158, 0LL) )
		  {
		    targetCharacter = (Object_1 *)this->fields.targetCharacter;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(targetCharacter, 0LL, 0LL) )
		      return 0LL;
		    v6 = (Component *)this->fields.targetCharacter;
		    if ( v6 )
		    {
		      gameObject = UnityEngine::Component::get_gameObject(v6, 0LL);
		      if ( gameObject )
		        return (IEnumerable *)UnityEngine::GameObject::GetComponentsInChildren<System::Object>(
		                                gameObject,
		                                MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Transform>);
		    }
		LABEL_8:
		    sub_1800D8260(v6, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4158, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1461(Patch, (Object *)this, 0LL);
		}
		
		[CrossSubDirectorRefResolved]
		private void OnCrossRefsResolved() {} // 0x0000000189C452BC-0x0000000189C4536C
		// Void OnCrossRefsResolved()
		void HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnCrossRefsResolved(
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  Object_1 *targetCharacter; // rbx
		  HGCharacterHelper *v4; // rbx
		  Bounds *WorldBounds; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds v10; // [rsp+20h] [rbp-48h] BYREF
		  Bounds v11; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4159, 0LL) )
		  {
		    targetCharacter = (Object_1 *)this->fields.targetCharacter;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(targetCharacter, 0LL, 0LL) )
		      return;
		    v4 = this->fields.targetCharacter;
		    WorldBounds = HG::Rendering::Runtime::HGCharacterShadowBoundOverride::GetWorldBounds(&v11, this, 0LL);
		    if ( v4 )
		    {
		      v8 = *(_QWORD *)&WorldBounds->m_Extents.y;
		      *(_OWORD *)&v10.m_Center.x = *(_OWORD *)&WorldBounds->m_Center.x;
		      *(_QWORD *)&v10.m_Extents.y = v8;
		      HG::Rendering::Runtime::HGCharacterHelper::SetShadowBoundOverride(v4, &v10, this, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4159, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnEnable() {} // 0x0000000189C45480-0x0000000189C45578
		// Void OnEnable()
		void HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnEnable(
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  Object_1 *targetCharacter; // rbx
		  HGCharacterHelper *v4; // rbx
		  Bounds *WorldBounds; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // xmm1_8
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v9; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds v12; // [rsp+20h] [rbp-48h] BYREF
		  Bounds v13; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4161, 0LL) )
		  {
		    targetCharacter = (Object_1 *)this->fields.targetCharacter;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(targetCharacter, 0LL, 0LL) )
		      return;
		    v4 = this->fields.targetCharacter;
		    WorldBounds = HG::Rendering::Runtime::HGCharacterShadowBoundOverride::GetWorldBounds(&v13, this, 0LL);
		    if ( v4 )
		    {
		      v8 = *(_QWORD *)&WorldBounds->m_Extents.y;
		      *(_OWORD *)&v12.m_Center.x = *(_OWORD *)&WorldBounds->m_Center.x;
		      *(_QWORD *)&v12.m_Extents.y = v8;
		      HG::Rendering::Runtime::HGCharacterHelper::SetShadowBoundOverride(v4, &v12, this, 0LL);
		      v9 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		      v10 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v9;
		      if ( v9 )
		      {
		        System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		          v9,
		          (Object *)this,
		          MethodInfo::HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnBeginFrameRendering,
		          0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		        UnityEngine::Rendering::RenderPipelineManager::add_beginFrameRenderingNoAlloc(v10, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4161, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnBeginFrameRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000189C451BC-0x0000000189C452BC
		// Void OnBeginFrameRendering(ScriptableRenderContext, List`1[UnityEngine.Camera])
		void HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnBeginFrameRendering(
		        HGCharacterShadowBoundOverride *this,
		        ScriptableRenderContext context,
		        List_1_UnityEngine_Camera_ *cameras,
		        MethodInfo *method)
		{
		  Object_1 *targetCharacter; // rbx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGCharacterHelper *v10; // rbx
		  Object_1 *m_OverrideSource; // rbx
		  HGCharacterHelper *v12; // rbx
		  Bounds *WorldBounds; // rax
		  __int64 v14; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds v16; // [rsp+30h] [rbp-48h] BYREF
		  Bounds v17; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4162, 0LL) )
		  {
		    targetCharacter = (Object_1 *)this->fields.targetCharacter;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(targetCharacter, 0LL, 0LL) )
		      return;
		    v10 = this->fields.targetCharacter;
		    if ( v10 )
		    {
		      m_OverrideSource = (Object_1 *)v10->fields.m_OverrideSource;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(m_OverrideSource, (Object_1 *)this, 0LL) )
		        return;
		      v12 = this->fields.targetCharacter;
		      WorldBounds = HG::Rendering::Runtime::HGCharacterShadowBoundOverride::GetWorldBounds(&v17, this, 0LL);
		      if ( v12 )
		      {
		        v14 = *(_QWORD *)&WorldBounds->m_Extents.y;
		        *(_OWORD *)&v16.m_Center.x = *(_OWORD *)&WorldBounds->m_Center.x;
		        *(_QWORD *)&v16.m_Extents.y = v14;
		        HG::Rendering::Runtime::HGCharacterHelper::SetShadowBoundOverride(v12, &v16, this, 0LL);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4162, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, context, (Object *)cameras, 0LL);
		}
		
		private void OnDisable() {} // 0x0000000189C453BC-0x0000000189C45480
		// Void OnDisable()
		void HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnDisable(
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  Object_1 *targetCharacter; // rbx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v4; // rax
		  __int64 v5; // rdx
		  HGCharacterHelper *v6; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4163, 0LL) )
		  {
		    targetCharacter = (Object_1 *)this->fields.targetCharacter;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(targetCharacter, 0LL, 0LL) )
		      return;
		    v4 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		    v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v4;
		    if ( v4 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v4,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnBeginFrameRendering,
		        0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v7, 0LL);
		      v6 = this->fields.targetCharacter;
		      if ( v6 )
		      {
		        HG::Rendering::Runtime::HGCharacterHelper::ClearShadowBoundOverride(v6, this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4163, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDestroy() {} // 0x0000000189C4536C-0x0000000189C453BC
		// Void OnDestroy()
		void HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnDestroy(
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4164, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4164, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGCharacterShadowBoundOverride::OnDisable(this, 0LL);
		  }
		}
		
		public Bounds GetWorldBounds() => default; // 0x0000000189C45040-0x0000000189C451BC
		// Bounds GetWorldBounds()
		Bounds *HG::Rendering::Runtime::HGCharacterShadowBoundOverride::GetWorldBounds(
		        Bounds *__return_ptr retstr,
		        HGCharacterShadowBoundOverride *this,
		        MethodInfo *method)
		{
		  Object_1 *followNode; // rbx
		  __int64 v6; // rcx
		  Transform *v7; // rdx
		  Vector3 *position; // rax
		  float z; // ecx
		  __int64 v10; // xmm0_8
		  MethodInfo *v11; // r9
		  MethodInfo *v12; // r9
		  Transform *transform; // rax
		  float v14; // eax
		  float v15; // xmm1_4
		  Vector3 *v16; // rax
		  float v17; // edx
		  __int64 v18; // xmm4_8
		  __int64 v19; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v22; // [rsp+20h] [rbp-40h] BYREF
		  Vector3 v23; // [rsp+30h] [rbp-30h] BYREF
		  Bounds v24; // [rsp+40h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4160, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4160, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(&v24, Patch, (Object *)this, 0LL);
		      return retstr;
		    }
		    goto LABEL_10;
		  }
		  if ( !this->fields.followTarget
		    || (followNode = (Object_1 *)this->fields.followNode,
		        sub_1800036A0(TypeInfo::UnityEngine::Object),
		        !UnityEngine::Object::op_Inequality(followNode, 0LL, 0LL)) )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      UnityEngine::Transform::get_position(&v24.m_Center, transform, 0LL);
		      goto LABEL_8;
		    }
		LABEL_10:
		    sub_1800D8260(v6, v7);
		  }
		  v7 = this->fields.followNode;
		  if ( !v7 )
		    goto LABEL_10;
		  position = UnityEngine::Transform::get_position(&v24.m_Center, v7, 0LL);
		  z = this->fields.followOffset.z;
		  *(_QWORD *)&v22.x = *(_QWORD *)&this->fields.followOffset.x;
		  v10 = *(_QWORD *)&position->x;
		  *(float *)&position = position->z;
		  v22.z = z;
		  *(_QWORD *)&v23.x = v10;
		  LODWORD(v23.z) = (_DWORD)position;
		  UnityEngine::Vector3::op_Addition(&v24.m_Center, &v23, &v22, v11);
		LABEL_8:
		  v14 = this->fields.scale.z;
		  v15 = this->fields.radius + this->fields.radius;
		  *(_QWORD *)&v23.x = *(_QWORD *)&this->fields.scale.x;
		  v23.z = v14;
		  v16 = UnityEngine::Vector3::op_Multiply(&v24.m_Center, v15, &v23, v12);
		  v22.z = v17;
		  *(_QWORD *)&v22.x = v18;
		  v19 = *(_QWORD *)&v16->x;
		  v23.z = v16->z;
		  *(_OWORD *)&retstr->m_Center.x = 0LL;
		  *(_QWORD *)&retstr->m_Extents.y = 0LL;
		  *(_QWORD *)&v23.x = v19;
		  UnityEngine::Bounds::Bounds(retstr, &v22, &v23, 0LL);
		  return retstr;
		}
		
	}
}
