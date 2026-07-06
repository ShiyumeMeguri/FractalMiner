using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGFoliageInteract : MonoBehaviour
	{
		public HGFoliageInteract()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGFoliageInteract::OnEnable(HGFoliageInteract *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
			//   OneofDescriptorProto *v6; // rdx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   HGFoliageInteractCPP v14; // [rsp+20h] [rbp-40h] BYREF
			//   HGFoliageInteractCPP interact; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1407, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1407, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !currentManagerContext
			//       || (foliageInteractiveManager_k__BackingField = currentManagerContext.fields._foliageInteractiveManager_k__BackingField) == 0LL )
			//     {
			//       sub_180B536AC(foliageInteractiveManager_k__BackingField, v4);
			//     }
			//     HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractToManager(
			//       foliageInteractiveManager_k__BackingField,
			//       this,
			//       0LL);
			//     v14.interactCollider = 0LL;
			//     *(_QWORD *)&v14.compID = (unsigned int)UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
			//     v14.transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//       (OneofDescriptor *)&v14.transform,
			//       v6,
			//       v7,
			//       v8,
			//       *(String__Array **)&v14.compID);
			//     v14.interactCollider = this.fields.interactiveCollider;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       (OneofDescriptor *)&v14.interactCollider,
			//       v9,
			//       v10,
			//       (MessageDescriptor *)v14.interactCollider,
			//       *(String__Array **)&v14.compID,
			//       (String *)v14.transform);
			//     interact = v14;
			//     UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::RegisterInteract_Injected(&interact, 0LL);
			//   }
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGFoliageInteract::OnDisable(HGFoliageInteract *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
			//   int32_t InstanceID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1409, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       foliageInteractiveManager_k__BackingField = currentManagerContext.fields._foliageInteractiveManager_k__BackingField;
			//       if ( foliageInteractiveManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractFromManager(
			//           foliageInteractiveManager_k__BackingField,
			//           this,
			//           0LL);
			//         InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
			//         UnityEngine::HyperGryph::HGFoliageInteractiveManagerV2::UnregisterInteract(InstanceID, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(foliageInteractiveManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1409, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDrawGizmos()
		{
			// // Void OnDrawGizmos()
			// void HG::Rendering::Runtime::HGFoliageInteract::OnDrawGizmos(HGFoliageInteract *this, MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v7; // xmm1
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   Object_1 *interactiveCollider; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 value; // [rsp+20h] [rbp-88h] BYREF
			//   Matrix4x4 v13; // [rsp+60h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919DCD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DCD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1411, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1411, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !transform )
			//     goto LABEL_8;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v13, transform, 0LL);
			//   v7 = *(_OWORD *)&localToWorldMatrix.m01;
			//   *(_OWORD *)&value.m00 = *(_OWORD *)&localToWorldMatrix.m00;
			//   v8 = *(_OWORD *)&localToWorldMatrix.m02;
			//   *(_OWORD *)&value.m01 = v7;
			//   v9 = *(_OWORD *)&localToWorldMatrix.m03;
			//   *(_OWORD *)&value.m02 = v8;
			//   *(_OWORD *)&value.m03 = v9;
			//   UnityEngine::Gizmos::set_matrix_Injected(&value, 0LL);
			//   interactiveCollider = (Object_1 *)this.fields.interactiveCollider;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality(interactiveCollider, 0LL, 0LL) )
			//     UnityEngine::Gizmos::DrawWireMesh(this.fields.interactiveCollider, 0LL);
			// }
			// 
		}

		public Mesh interactiveCollider;
	}
}
