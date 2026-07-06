using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGECSRegion : MonoBehaviour
	{
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000025D2 File Offset: 0x000007D2
		public static NativeArray<ComponentType> s_ECSRegionDefaultComponentTypes
		{
			get
			{
				// // NativeArray`1[UnityEngine.HyperGryph.ECS.ComponentType] get_s_ECSRegionDefaultComponentTypes()
				// NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *HG::Rendering::Runtime::HGECSRegion::get_s_ECSRegionDefaultComponentTypes(
				//         NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v3; // rdx
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *v4; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v8; // xmm0
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *result; // rax
				//   NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v10; // [rsp+20h] [rbp-28h] BYREF
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // [rsp+30h] [rbp-18h] BYREF
				//   ComponentType allocator; // [rsp+50h] [rbp+8h] BYREF
				// 
				//   if ( !byte_18D919CCD )
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
				//     byte_18D919CCD = 1;
				//   }
				//   v10 = 0LL;
				//   if ( IFix::WrappersManagerImpl::IsPatched(403, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(403, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     v4 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(&v11, Patch, 0LL);
				//   }
				//   else
				//   {
				//     LODWORD(allocator.value) = 2;
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
				//       &v10,
				//       1,
				//       (AllocatorManager_AllocatorHandle)2,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>,
				//                                   v3);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v10,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     v4 = (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)sub_180314768(&v11, &v10);
				//   }
				//   v8 = *v4;
				//   result = retstr;
				//   *retstr = v8;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000025D2 File Offset: 0x000007D2
		public static NativeArray<ComponentType> s_CullingRegionComponentTypes
		{
			get
			{
				// // NativeArray`1[UnityEngine.HyperGryph.ECS.ComponentType] get_s_CullingRegionComponentTypes()
				// NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *HG::Rendering::Runtime::HGECSRegion::get_s_CullingRegionComponentTypes(
				//         NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v3; // rdx
				//   MethodInfo *v4; // rdx
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *v5; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v9; // xmm0
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *result; // rax
				//   NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // [rsp+20h] [rbp-20h] BYREF
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v12; // [rsp+30h] [rbp-10h] BYREF
				//   ComponentType value; // [rsp+50h] [rbp+10h] BYREF
				// 
				//   if ( !byte_18D919CCE )
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
				//     byte_18D919CCE = 1;
				//   }
				//   v11 = 0LL;
				//   if ( IFix::WrappersManagerImpl::IsPatched(404, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(404, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(&v12, Patch, 0LL);
				//   }
				//   else
				//   {
				//     LODWORD(value.value) = 2;
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
				//       &v11,
				//       2,
				//       (AllocatorManager_AllocatorHandle)2,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
				//     value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>(
				//                               (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>,
				//                               v3);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v11,
				//       &value,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>(
				//                               (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>,
				//                               v4);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v11,
				//       &value,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     v5 = (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)sub_180314768(&v12, &v11);
				//   }
				//   v9 = *v5;
				//   result = retstr;
				//   *retstr = v9;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public HGECSRegion()
		{
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGECSRegion::OnEnable(HGECSRegion *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(405, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(405, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGECSRegion::AddEntity(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGECSRegion::OnDisable(HGECSRegion *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(408, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(408, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGECSRegion::RemoveEntity(this, 0LL);
			//   }
			// }
			// 
		}

		private void Update()
		{
			// // Void Update()
			// void HG::Rendering::Runtime::HGECSRegion::Update(HGECSRegion *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(410, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(410, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGECSRegion::TransformChanged(this, 0LL);
			//   }
			// }
			// 
		}

		private void TransformChanged()
		{
			// // Void TransformChanged()
			// void HG::Rendering::Runtime::HGECSRegion::TransformChanged(HGECSRegion *this, MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Transform *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(411, 0LL) )
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( transform )
			//     {
			//       if ( !UnityEngine::Transform::get_hasChanged(transform, 0LL) )
			//         return;
			//       v6 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( v6 )
			//       {
			//         UnityEngine::Transform::set_hasChanged(v6, 0, 0LL);
			//         HG::Rendering::Runtime::HGECSRegion::UpdateEntity(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(411, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void AddEntity()
		{
			// // Void AddEntity()
			// void HG::Rendering::Runtime::HGECSRegion::AddEntity(HGECSRegion *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   EntityManager_1 v5; // xmm0
			//   BoolParameter *enableShadowCulling; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *s_CullingRegionComponentTypes; // rax
			//   EntityType v8; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   EntityManager_1 v10; // [rsp+20h] [rbp-20h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919CCF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D919CCF = 1;
			//   }
			//   v10 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(406, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(406, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v4, v3);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//   if ( this.fields.m_entity )
			//     return;
			//   v5 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager((EntityManager_1 *)&v11, 0LL);
			//   enableShadowCulling = this.fields.enableShadowCulling;
			//   v10 = v5;
			//   if ( !enableShadowCulling )
			//     goto LABEL_13;
			//   if ( enableShadowCulling.fields._._.overrideState )
			//     this.fields.m_regionTypeMask |= 1u;
			//   if ( this.fields.m_regionTypeMask == 1 )
			//     s_CullingRegionComponentTypes = HG::Rendering::Runtime::HGECSRegion::get_s_CullingRegionComponentTypes(&v11, 0LL);
			//   else
			//     s_CullingRegionComponentTypes = HG::Rendering::Runtime::HGECSRegion::get_s_ECSRegionDefaultComponentTypes(&v11, 0LL);
			//   v11 = *s_CullingRegionComponentTypes;
			//   v8.id = UnityEngine::HyperGryph::ECS::EntityManager::GetOrRegisterEntityType(&v10, &v11, 0LL).id;
			//   this.fields.m_entity = UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&v10, v8, 0LL);
			//   HG::Rendering::Runtime::HGECSRegion::UpdateEntity(this, 0LL);
			// }
			// 
		}

		private void RemoveEntity()
		{
			// // Void RemoveEntity()
			// void HG::Rendering::Runtime::HGECSRegion::RemoveEntity(HGECSRegion *this, MethodInfo *method)
			// {
			//   EntityManager_1 *RendererEntityManager; // rax
			//   Entity_1 m_entity; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   EntityManager_1 v8; // [rsp+20h] [rbp-28h] BYREF
			//   EntityManager_1 v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919CD0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D919CD0 = 1;
			//   }
			//   v8 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(409, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(409, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     if ( this.fields.m_entity )
			//     {
			//       RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v9, 0LL);
			//       m_entity = this.fields.m_entity;
			//       v8 = *RendererEntityManager;
			//       UnityEngine::HyperGryph::ECS::EntityManager::DestroyEntity(&v8, m_entity, 0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//       this.fields.m_entity.globalIndex = 0;
			//       this.fields.m_entity.version = 0;
			//       this.fields.m_regionTypeMask = 0;
			//     }
			//   }
			// }
			// 
		}

		private void UpdateEntity()
		{
			// // Void UpdateEntity()
			// void HG::Rendering::Runtime::HGECSRegion::UpdateEntity(HGECSRegion *this, MethodInfo *method)
			// {
			//   EntityManager_1 *RendererEntityManager; // rax
			//   Transform *transform; // rax
			//   BoolParameter *enableShadowCulling; // rdx
			//   __int64 v6; // rcx
			//   Vector3 *position; // rax
			//   __int64 v8; // xmm0_8
			//   Transform *v9; // rax
			//   Vector3 *localScale; // rax
			//   __int64 v11; // xmm0_8
			//   Transform *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Quaternion v14; // [rsp+20h] [rbp-50h] BYREF
			//   EntityManager_1 v15; // [rsp+30h] [rbp-40h] BYREF
			//   HGECSRegionComponent t; // [rsp+40h] [rbp-30h] BYREF
			//   HGCullingParameterComponent v17; // [rsp+90h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919CD1 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D919CD1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(407, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     if ( !*(_QWORD *)&this.fields.m_entity )
			//       return;
			//     RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v15, 0LL);
			//     memset(&t, 0, sizeof(t));
			//     t.isEnable = 1;
			//     v15 = *RendererEntityManager;
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( transform )
			//     {
			//       position = UnityEngine::Transform::get_position((Vector3 *)&v14, transform, 0LL);
			//       v8 = *(_QWORD *)&position.x;
			//       *(float *)&position = position.z;
			//       *(_QWORD *)&t.center.x = v8;
			//       LODWORD(t.center.z) = (_DWORD)position;
			//       v9 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( v9 )
			//       {
			//         localScale = UnityEngine::Transform::get_localScale((Vector3 *)&v14, v9, 0LL);
			//         v11 = *(_QWORD *)&localScale.x;
			//         *(float *)&localScale = localScale.z;
			//         *(_QWORD *)&t.size.x = v11;
			//         LODWORD(t.size.z) = (_DWORD)localScale;
			//         v12 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( v12 )
			//         {
			//           t.rotation = *UnityEngine::Transform::get_rotation(&v14, v12, 0LL);
			//           UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>(
			//             &v15,
			//             &this.fields.m_entity,
			//             &t,
			//             MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGECSRegionComponent>);
			//           if ( (this.fields.m_regionTypeMask & 1) == 0 )
			//             return;
			//           enableShadowCulling = this.fields.enableShadowCulling;
			//           if ( enableShadowCulling )
			//           {
			//             v17.enableShadowCulling = sub_1800023D0(10LL, enableShadowCulling);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>(
			//               &v15,
			//               &this.fields.m_entity,
			//               &v17,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v6, enableShadowCulling);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(407, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public BoolParameter enableShadowCulling;

		private Entity m_entity;

		private HGECSRegionTypeMask m_regionTypeMask;
	}
}
