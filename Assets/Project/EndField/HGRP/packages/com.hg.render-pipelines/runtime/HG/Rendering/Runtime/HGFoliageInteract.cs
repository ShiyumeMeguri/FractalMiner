using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGFoliageInteract : MonoBehaviour // TypeDefIndex: 37691
	{
		// Fields
		public Mesh interactiveCollider; // 0x18
	
		// Constructors
		public HGFoliageInteract() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void OnEnable() {} // 0x0000000189CF1C10-0x0000000189CF1CE8
		// Void OnEnable()
		void HG::Rendering::Runtime::HGFoliageInteract::OnEnable(HGFoliageInteract *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGFoliageInteractCPP v14; // [rsp+20h] [rbp-40h] BYREF
		  HGFoliageInteractCPP interact; // [rsp+40h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1674, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1674, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext
		      || (foliageInteractiveManager_k__BackingField = currentManagerContext->fields._foliageInteractiveManager_k__BackingField) == 0LL )
		    {
		      sub_1800D8260(foliageInteractiveManager_k__BackingField, v4);
		    }
		    HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractToManager(
		      foliageInteractiveManager_k__BackingField,
		      this,
		      0LL);
		    v14.interactCollider = 0LL;
		    *(_QWORD *)&v14.compID = (unsigned int)UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		    v14.transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&v14.transform, v6, v7, v8, *(MethodInfo **)&v14.compID);
		    v14.interactCollider = this->fields.interactiveCollider;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&v14.interactCollider,
		      v9,
		      v10,
		      (Int32__Array **)v14.interactCollider,
		      *(MethodInfo **)&v14.compID);
		    interact = v14;
		    UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::RegisterInteract_Injected(&interact, 0LL);
		  }
		}
		
		private void OnDisable() {} // 0x0000000189CF1AC4-0x0000000189CF1B40
		// Void OnDisable()
		void HG::Rendering::Runtime::HGFoliageInteract::OnDisable(HGFoliageInteract *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
		  int32_t InstanceID; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1676, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      foliageInteractiveManager_k__BackingField = currentManagerContext->fields._foliageInteractiveManager_k__BackingField;
		      if ( foliageInteractiveManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractFromManager(
		          foliageInteractiveManager_k__BackingField,
		          this,
		          0LL);
		        InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		        UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::UnregisterInteract(InstanceID, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(foliageInteractiveManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1676, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDrawGizmos() {} // 0x0000000189CF1B40-0x0000000189CF1C10
		// Void OnDrawGizmos()
		void HG::Rendering::Runtime::HGFoliageInteract::OnDrawGizmos(HGFoliageInteract *this, MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  Object_1 *interactiveCollider; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4 v12; // [rsp+20h] [rbp-88h] BYREF
		  Matrix4x4 v13; // [rsp+60h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1678, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1678, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_6;
		  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v13, transform, 0LL);
		  v7 = *(_OWORD *)&localToWorldMatrix->m01;
		  *(_OWORD *)&v12.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		  v8 = *(_OWORD *)&localToWorldMatrix->m02;
		  *(_OWORD *)&v12.m01 = v7;
		  v9 = *(_OWORD *)&localToWorldMatrix->m03;
		  *(_OWORD *)&v12.m02 = v8;
		  *(_OWORD *)&v12.m03 = v9;
		  UnityEngine::Gizmos::set_matrix(&v12, 0LL);
		  interactiveCollider = (Object_1 *)this->fields.interactiveCollider;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality(interactiveCollider, 0LL, 0LL) )
		    UnityEngine::Gizmos::DrawWireMesh(this->fields.interactiveCollider, 0LL);
		}
		
	}
}
