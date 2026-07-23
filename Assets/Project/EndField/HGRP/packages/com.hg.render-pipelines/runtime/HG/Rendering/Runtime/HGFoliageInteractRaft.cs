using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGFoliageInteractRaft : HGFoliageInteract // TypeDefIndex: 37695
	{
		// Constructors
		public HGFoliageInteractRaft() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		public Vector3 GetRaftCenterPosition() => default; // 0x0000000189CF17E0-0x0000000189CF1874
		// Vector3 GetRaftCenterPosition()
		Vector3 *HG::Rendering::Runtime::HGFoliageInteractRaft::GetRaftCenterPosition(
		        Vector3 *__return_ptr retstr,
		        HGFoliageInteractRaft *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Transform *Parent; // rax
		  Vector3 *position; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // xmm0_8
		  float z; // eax
		  Vector3 v14[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1691, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1691, 0LL);
		    if ( Patch )
		    {
		      position = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v14, Patch, (Object *)this, 0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_6;
		  Parent = UnityEngine::Transform::GetParent(transform, 0LL);
		  if ( !Parent )
		    goto LABEL_6;
		  position = UnityEngine::Transform::get_position(v14, Parent, 0LL);
		LABEL_8:
		  v11 = *(_QWORD *)&position->x;
		  z = position->z;
		  *(_QWORD *)&retstr->x = v11;
		  retstr->z = z;
		  return retstr;
		}
		
		public Vector3 GetCapsuleProxyPositionA() => default; // 0x0000000189CF1448-0x0000000189CF15C8
		// Vector3 GetCapsuleProxyPositionA()
		Vector3 *HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyPositionA(
		        Vector3 *__return_ptr retstr,
		        HGFoliageInteractRaft *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Transform *Parent; // rax
		  Vector3 *position; // rax
		  __int64 v10; // xmm8_8
		  float z; // esi
		  float CapsuleProxyHalfLength; // xmm6_4
		  float CapsuleProxyRadius; // xmm0_4
		  Transform *v14; // rax
		  Transform *v15; // rax
		  Vector3 *forward; // rax
		  float v17; // xmm7_4
		  __int64 v18; // xmm0_8
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  __int64 v21; // xmm1_8
		  MethodInfo *v22; // r9
		  Vector3 *v23; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // xmm0_8
		  float v26; // eax
		  Vector3 v28; // [rsp+20h] [rbp-60h] BYREF
		  Vector3 v29; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 v30[2]; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(941, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(941, 0LL);
		    if ( Patch )
		    {
		      v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v30, Patch, (Object *)this, 0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(v7, v6);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_8;
		  Parent = UnityEngine::Transform::GetParent(transform, 0LL);
		  if ( !Parent )
		    goto LABEL_8;
		  position = UnityEngine::Transform::get_position(&v29, Parent, 0LL);
		  v10 = *(_QWORD *)&position->x;
		  z = position->z;
		  CapsuleProxyHalfLength = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyHalfLength(this, 0LL);
		  CapsuleProxyRadius = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyRadius(this, 0LL);
		  v14 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v14 )
		    goto LABEL_8;
		  v15 = UnityEngine::Transform::GetParent(v14, 0LL);
		  if ( !v15 )
		    goto LABEL_8;
		  forward = UnityEngine::Transform::get_forward(&v29, v15, 0LL);
		  v17 = CapsuleProxyRadius * 0.5;
		  v18 = *(_QWORD *)&forward->x;
		  *(float *)&forward = forward->z;
		  *(_QWORD *)&v28.x = v18;
		  LODWORD(v28.z) = (_DWORD)forward;
		  v20 = UnityEngine::Vector3::op_Multiply(&v29, CapsuleProxyHalfLength - v17, &v28, v19);
		  v21 = *(_QWORD *)&v20->x;
		  *(float *)&v20 = v20->z;
		  *(_QWORD *)&v28.x = v21;
		  LODWORD(v28.z) = (_DWORD)v20;
		  *(_QWORD *)&v29.x = v10;
		  v29.z = z;
		  v23 = UnityEngine::Vector3::op_Addition(v30, &v29, &v28, v22);
		LABEL_10:
		  v25 = *(_QWORD *)&v23->x;
		  v26 = v23->z;
		  *(_QWORD *)&retstr->x = v25;
		  retstr->z = v26;
		  return retstr;
		}
		
		public Vector3 GetCapsuleProxyPositionB() => default; // 0x0000000189CF15C8-0x0000000189CF1748
		// Vector3 GetCapsuleProxyPositionB()
		Vector3 *HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyPositionB(
		        Vector3 *__return_ptr retstr,
		        HGFoliageInteractRaft *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Transform *Parent; // rax
		  Vector3 *position; // rax
		  __int64 v10; // xmm8_8
		  float z; // esi
		  float CapsuleProxyHalfLength; // xmm6_4
		  float CapsuleProxyRadius; // xmm0_4
		  Transform *v14; // rax
		  Transform *v15; // rax
		  Vector3 *forward; // rax
		  float v17; // xmm7_4
		  __int64 v18; // xmm0_8
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  __int64 v21; // xmm1_8
		  MethodInfo *v22; // r9
		  Vector3 *v23; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // xmm0_8
		  float v26; // eax
		  Vector3 v28; // [rsp+20h] [rbp-60h] BYREF
		  Vector3 v29; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 v30[2]; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(944, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(944, 0LL);
		    if ( Patch )
		    {
		      v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v30, Patch, (Object *)this, 0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(v7, v6);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_8;
		  Parent = UnityEngine::Transform::GetParent(transform, 0LL);
		  if ( !Parent )
		    goto LABEL_8;
		  position = UnityEngine::Transform::get_position(&v29, Parent, 0LL);
		  v10 = *(_QWORD *)&position->x;
		  z = position->z;
		  CapsuleProxyHalfLength = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyHalfLength(this, 0LL);
		  CapsuleProxyRadius = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyRadius(this, 0LL);
		  v14 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v14 )
		    goto LABEL_8;
		  v15 = UnityEngine::Transform::GetParent(v14, 0LL);
		  if ( !v15 )
		    goto LABEL_8;
		  forward = UnityEngine::Transform::get_forward(&v29, v15, 0LL);
		  v17 = CapsuleProxyRadius * 0.5;
		  v18 = *(_QWORD *)&forward->x;
		  *(float *)&forward = forward->z;
		  *(_QWORD *)&v28.x = v18;
		  LODWORD(v28.z) = (_DWORD)forward;
		  v20 = UnityEngine::Vector3::op_Multiply(&v29, CapsuleProxyHalfLength - v17, &v28, v19);
		  v21 = *(_QWORD *)&v20->x;
		  *(float *)&v20 = v20->z;
		  *(_QWORD *)&v28.x = v21;
		  LODWORD(v28.z) = (_DWORD)v20;
		  *(_QWORD *)&v29.x = v10;
		  v29.z = z;
		  v23 = UnityEngine::Vector3::op_Subtraction(v30, &v29, &v28, v22);
		LABEL_10:
		  v25 = *(_QWORD *)&v23->x;
		  v26 = v23->z;
		  *(_QWORD *)&retstr->x = v25;
		  retstr->z = v26;
		  return retstr;
		}
		
		public float GetCapsuleProxyRadius() => default; // 0x0000000189CF1748-0x0000000189CF17E0
		// Single GetCapsuleProxyRadius()
		float HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyRadius(
		        HGFoliageInteractRaft *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  float x; // xmm6_4
		  Transform *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(943, 0LL) )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      x = UnityEngine::Transform::get_localScale(&v10, transform, 0LL)->x;
		      v7 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( v7 )
		        return fmaxf(x, UnityEngine::Transform::get_localScale(&v10, v7, 0LL)->z);
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(943, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		private float GetCapsuleProxyHalfLength() => default; // 0x0000000189CF13DC-0x0000000189CF1448
		// Single GetCapsuleProxyHalfLength()
		float HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyHalfLength(
		        HGFoliageInteractRaft *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v8[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(942, 0LL) )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		      return UnityEngine::Transform::get_localScale(v8, transform, 0LL)->y;
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(942, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		private new void OnEnable() {} // 0x0000000189CF194C-0x0000000189CF1AC4
		// Void OnEnable()
		void HG::Rendering::Runtime::HGFoliageInteractRaft::OnEnable(HGFoliageInteractRaft *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
		  HGManagerContext *v6; // rax
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int128 v20; // [rsp+20h] [rbp-19h] BYREF
		  SingleFieldAccessor v21; // [rsp+30h] [rbp-9h] BYREF
		  HGFoliageInteractRaftCPP raft; // [rsp+70h] [rbp+37h] BYREF
		
		  DWORD1(v20) = 0;
		  v21.klass = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1692, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1692, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext
		      || (foliageInteractiveManager_k__BackingField = currentManagerContext->fields._foliageInteractiveManager_k__BackingField) == 0LL
		      || (HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractToManager(
		            foliageInteractiveManager_k__BackingField,
		            (HGFoliageInteract *)this,
		            0LL),
		          (v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL)) == 0LL)
		      || (foliageInteractiveManager_k__BackingField = v6->fields._foliageInteractiveManager_k__BackingField) == 0LL )
		    {
		      sub_1800D8260(foliageInteractiveManager_k__BackingField, v4);
		    }
		    HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractRaftToManager(
		      foliageInteractiveManager_k__BackingField,
		      this,
		      0LL);
		    v21.fields._.descriptor = 0LL;
		    v21.monitor = (MonitorData *)(unsigned int)UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		    v21.fields._.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)UnityEngine::Component::get_transform(
		                                                                                 (Component *)this,
		                                                                                 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&v21.fields, v7, v8, v9, (MethodInfo *)v20);
		    v21.fields._.descriptor = (FieldDescriptor *)this->fields._.interactiveCollider;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&v21.fields._.descriptor,
		      v10,
		      v11,
		      (Int32__Array **)v21.fields._.descriptor,
		      (MethodInfo *)v20);
		    *(_OWORD *)&v21.fields.setValueDelegate = *(_OWORD *)&v21.monitor;
		    v21.fields.hasDelegate = (Func_2_Google_Protobuf_IMessage_Boolean_ *)v21.fields._.descriptor;
		    UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::RegisterInteract_Injected(
		      (HGFoliageInteractCPP *)&v21.fields.setValueDelegate,
		      0LL);
		    v21.klass = 0LL;
		    *(_QWORD *)&v20 = (unsigned int)UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		    *((_QWORD *)&v20 + 1) = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)((char *)&v20 + 8), v12, v13, v14, (MethodInfo *)v20);
		    v21.klass = (SingleFieldAccessor__Class *)this->fields._.interactiveCollider;
		    sub_18002D1B0(&v21, v15, v16, (Int32__Array **)v21.klass, (MethodInfo *)v20);
		    *(_OWORD *)&raft.compID = v20;
		    raft.interactCollider = (Mesh *)v21.klass;
		    UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::RegisterInteractRaft_Injected(&raft, 0LL);
		  }
		}
		
		private new void OnDisable() {} // 0x0000000189CF1874-0x0000000189CF194C
		// Void OnDisable()
		void HG::Rendering::Runtime::HGFoliageInteractRaft::OnDisable(HGFoliageInteractRaft *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
		  HGManagerContext *v6; // rax
		  HGManagerContext *v7; // rax
		  int32_t InstanceID; // eax
		  int32_t v9; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1693, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      goto LABEL_10;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext )
		      goto LABEL_12;
		    if ( !currentManagerContext->fields._foliageInteractiveManager_k__BackingField )
		    {
		LABEL_10:
		      InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		      UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::UnregisterInteract(InstanceID, 0LL);
		      v9 = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		      UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::UnregisterInteractRaft(v9, 0LL);
		      return;
		    }
		    v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( v6 )
		    {
		      foliageInteractiveManager_k__BackingField = v6->fields._foliageInteractiveManager_k__BackingField;
		      if ( foliageInteractiveManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractFromManager(
		          foliageInteractiveManager_k__BackingField,
		          (HGFoliageInteract *)this,
		          0LL);
		        v7 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		        if ( v7 )
		        {
		          foliageInteractiveManager_k__BackingField = v7->fields._foliageInteractiveManager_k__BackingField;
		          if ( foliageInteractiveManager_k__BackingField )
		          {
		            HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractRaftFromManager(
		              foliageInteractiveManager_k__BackingField,
		              this,
		              0LL);
		            goto LABEL_10;
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(foliageInteractiveManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1693, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
