using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(MeshFilter))]
	[ExecuteInEditMode]
	public class HGWaterRendererV2 : MonoBehaviour
	{
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000025D2 File Offset: 0x000007D2
		public static NativeArray<ComponentType> s_waterType
		{
			get
			{
				// // NativeArray`1[UnityEngine.HyperGryph.ECS.ComponentType] get_s_waterType()
				// NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *HG::Rendering::Runtime::HGWaterRendererV2::get_s_waterType(
				//         NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v3; // rdx
				//   MethodInfo *v4; // rdx
				//   MethodInfo *v5; // rdx
				//   MethodInfo *v6; // rdx
				//   MethodInfo *v7; // rdx
				//   MethodInfo *v8; // rdx
				//   MethodInfo *v9; // rdx
				//   MethodInfo *v10; // rdx
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // xmm0
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v14; // rdx
				//   __int64 v15; // rcx
				//   NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v16; // [rsp+20h] [rbp-20h] BYREF
				//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v17; // [rsp+30h] [rbp-10h] BYREF
				//   ComponentType allocator; // [rsp+50h] [rbp+10h] BYREF
				// 
				//   if ( !byte_18D8EDBE8 )
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGWaterComponent>);
				//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
				//     byte_18D8EDBE8 = 1;
				//   }
				//   v16 = 0LL;
				//   if ( IFix::WrappersManagerImpl::IsPatched(4686, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4686, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v15, v14);
				//     v11 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(&v17, Patch, 0LL);
				//   }
				//   else
				//   {
				//     LODWORD(allocator.value) = 2;
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
				//       &v16,
				//       8,
				//       (AllocatorManager_AllocatorHandle)2,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>,
				//                                   v3);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>,
				//                                   v4);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>,
				//                                   v5);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>,
				//                                   v6);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>,
				//                                   v7);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>,
				//                                   v8);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGWaterComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGWaterComponent>,
				//                                   v9);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
				//                                   (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>,
				//                                   v10);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
				//       &v16,
				//       &allocator,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
				//     Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit(
				//       &v17,
				//       &v16,
				//       MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
				//     v11 = v17;
				//   }
				//   result = retstr;
				//   *retstr = v11;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00002608 File Offset: 0x00000808
		public int dynamicMaterialIndex
		{
			get
			{
				// // Int32 get_defaultArea()
				// int32_t UnityEngine::AI::NavMeshSurface::get_defaultArea(NavMeshSurface *this, MethodInfo *method)
				// {
				//   return this.fields.m_DefaultArea;
				// }
				// 
				return 0;
			}
		}

		public HGWaterRendererV2()
		{
			// // HGWaterRendererV2()
			// void HG::Rendering::Runtime::HGWaterRendererV2::HGWaterRendererV2(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   if ( !byte_18D8EDBEE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D8EDBEE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity, method);
			//   this.fields.renderType = 2;
			//   this.fields.m_entity = 0LL;
			//   this.fields.wetnessOffset = 0.25;
			//   this.fields.m_dynamicMaterialIndex = -1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void SetDirty()
		{
			// // Void SetDirty()
			// void HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4687, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4687, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_ecsDirty = 1;
			//   }
			// }
			// 
		}

		public void EnableDynamic(int materialIndex)
		{
			// // Void EnableDynamic(Int32)
			// void HG::Rendering::Runtime::HGWaterRendererV2::EnableDynamic(
			//         HGWaterRendererV2 *this,
			//         int32_t materialIndex,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4688, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4688, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       materialIndex,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_dynamicMaterialIndex = materialIndex;
			//     HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
			//   }
			// }
			// 
		}

		public void DisableDynamic()
		{
			// // Void DisableDynamic()
			// void HG::Rendering::Runtime::HGWaterRendererV2::DisableDynamic(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4689, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4689, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_dynamicMaterialIndex = -1;
			//     HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGWaterRendererV2::OnEnable(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDBE9 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
			//     byte_18D8EDBE9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4690, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4690, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_meshFilter = (MeshFilter *)UnityEngine::Component::GetComponent<System::Object>(
			//                                                 (Component *)this,
			//                                                 MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_meshFilter, v3, v4, v5, v9, v10);
			//   }
			// }
			// 
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
			// // Void Update()
			// void HG::Rendering::Runtime::HGWaterRendererV2::Update(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v5; // rdx
			//   __int64 (__fastcall *v6)(HGWaterRendererV2 *); // rax
			//   __int64 v7; // rdi
			//   unsigned __int8 (__fastcall *v8)(__int64); // rax
			//   Transform *transform; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v11; // rax
			//   __int64 v12; // rax
			//   __int64 v13; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size > 4693 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v3.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray.max_length.size <= 0x1255u )
			//       goto LABEL_39;
			//     if ( wrapperArray[130].vector[13] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4693, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_22;
			//     }
			//   }
			//   HG::Rendering::Runtime::HGWaterRendererV2::MeshChanged(this, 0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v5);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size <= 4699 )
			//     goto LABEL_13;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_22;
			//   if ( LODWORD(v3._0.namespaze) <= 0x125B )
			// LABEL_39:
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[100]._0.namespaze )
			//   {
			// LABEL_13:
			//     v6 = (__int64 (__fastcall *)(HGWaterRendererV2 *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v6 = (__int64 (__fastcall *)(HGWaterRendererV2 *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//       if ( !v6 )
			//       {
			//         v12 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v12, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v6;
			//     }
			//     v7 = v6(this);
			//     if ( v7 )
			//     {
			//       v8 = (unsigned __int8 (__fastcall *)(__int64))qword_18D8F52C0;
			//       if ( !qword_18D8F52C0 )
			//       {
			//         v8 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.Transform::get_hasChanged()");
			//         if ( !v8 )
			//         {
			//           v13 = sub_1802DBBE8("UnityEngine.Transform::get_hasChanged()");
			//           sub_18000F750(v13, 0LL);
			//         }
			//         qword_18D8F52C0 = (__int64)v8;
			//       }
			//       if ( !v8(v7) )
			//         goto LABEL_17;
			//       transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( transform )
			//       {
			//         UnityEngine::Transform::set_hasChanged(transform, 0, 0LL);
			//         HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
			//         goto LABEL_17;
			//       }
			//     }
			// LABEL_22:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   v11 = IFix::WrappersManagerImpl::GetPatch(4699, 0LL);
			//   if ( !v11 )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)v11, (Object *)this, 0LL);
			// LABEL_17:
			//   if ( this.fields.m_ecsDirty )
			//   {
			//     this.fields.m_ecsDirty = 0;
			//     HG::Rendering::Runtime::HGWaterRendererV2::UpdateEntity(this, 0LL);
			//   }
			// }
			// 
		}

		private void MeshChanged()
		{
			// // Void MeshChanged()
			// void HG::Rendering::Runtime::HGWaterRendererV2::MeshChanged(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   MeshFilter *static_fields; // rcx
			//   MeshFilter__Class *klass; // rdx
			//   MeshFilter *m_meshFilter; // rbx
			//   Mesh *m_mesh; // rsi
			//   __int64 (__fastcall *v8)(MeshFilter *); // rax
			//   __int64 v9; // rbx
			//   bool v10; // zf
			//   bool v11; // al
			//   Object_1 *v12; // rbx
			//   __int64 v13; // rdx
			//   Object_1 *sharedMesh; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   MeshFilter__Class *v18; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rax
			//   Object_1 *v21; // rbx
			//   __int64 v22; // rdx
			//   Object_1 *v23; // rbx
			//   Object_1 *v24; // rbx
			//   __int64 v25; // rdx
			//   Object_1 *v26; // rbx
			//   Object_1 *v27; // rbx
			//   __int64 v28; // rdx
			//   Object_1 *v29; // rsi
			//   MethodInfo *v30; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v31; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDBEA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBEA = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (MeshFilter *)v3.static_fields;
			//   klass = static_fields.klass;
			//   if ( !static_fields.klass )
			//     goto LABEL_45;
			//   if ( SLODWORD(klass._0.namespaze) > 4694 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, klass);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (MeshFilter *)v3.static_fields;
			//     v18 = static_fields.klass;
			//     if ( !static_fields.klass )
			//       goto LABEL_45;
			//     if ( LODWORD(v18._0.namespaze) <= 0x1256 )
			//       sub_180070270(static_fields, klass);
			//     if ( v18[99].vtable.ToString.methodPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4694, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			// LABEL_45:
			//       sub_180B536AC(static_fields, klass);
			//     }
			//   }
			//   m_meshFilter = this.fields.m_meshFilter;
			//   m_mesh = this.fields.m_mesh;
			//   if ( !m_meshFilter )
			//     goto LABEL_45;
			//   v8 = (__int64 (__fastcall *)(MeshFilter *))qword_18D8F4800;
			//   if ( !qword_18D8F4800 )
			//   {
			//     v8 = (__int64 (__fastcall *)(MeshFilter *))il2cpp_resolve_icall_0("UnityEngine.MeshFilter::get_sharedMesh()");
			//     if ( !v8 )
			//     {
			//       v20 = sub_1802DBBE8("UnityEngine.MeshFilter::get_sharedMesh()");
			//       sub_18000F750(v20, 0LL);
			//     }
			//     qword_18D8F4800 = (__int64)v8;
			//   }
			//   v9 = v8(m_meshFilter);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v9 != 0 || m_mesh != 0LL )
			//   {
			//     if ( v9 )
			//     {
			//       if ( m_mesh )
			//       {
			//         v11 = m_mesh == (Mesh *)v9;
			// LABEL_27:
			//         if ( v11 )
			//           return;
			//         v12 = (Object_1 *)this.fields.m_mesh;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//         if ( !UnityEngine::Object::op_Equality(v12, 0LL, 0LL) )
			//           goto LABEL_57;
			//         static_fields = this.fields.m_meshFilter;
			//         if ( !static_fields )
			//           goto LABEL_45;
			//         sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(static_fields, 0LL);
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//         if ( !UnityEngine::Object::op_Inequality(sharedMesh, 0LL, 0LL) )
			//         {
			// LABEL_57:
			//           v21 = (Object_1 *)this.fields.m_mesh;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//           if ( UnityEngine::Object::op_Inequality(v21, 0LL, 0LL) )
			//           {
			//             static_fields = this.fields.m_meshFilter;
			//             if ( !static_fields )
			//               goto LABEL_45;
			//             v23 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(static_fields, 0LL);
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v22);
			//             if ( UnityEngine::Object::op_Equality(v23, 0LL, 0LL) )
			//             {
			//               HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(this, 0LL);
			// LABEL_43:
			//               static_fields = this.fields.m_meshFilter;
			//               if ( static_fields )
			//               {
			//                 this.fields.m_mesh = UnityEngine::MeshFilter::get_sharedMesh(static_fields, 0LL);
			//                 sub_1800054D0((HGRenderPathScene *)&this.fields.m_mesh, v15, v16, v17, v30, v31);
			//                 return;
			//               }
			//               goto LABEL_45;
			//             }
			//           }
			//           v24 = (Object_1 *)this.fields.m_mesh;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//           if ( !UnityEngine::Object::op_Inequality(v24, 0LL, 0LL) )
			//             goto LABEL_43;
			//           static_fields = this.fields.m_meshFilter;
			//           if ( !static_fields )
			//             goto LABEL_45;
			//           v26 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(static_fields, 0LL);
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v25);
			//           if ( !UnityEngine::Object::op_Inequality(v26, 0LL, 0LL) )
			//             goto LABEL_43;
			//           static_fields = this.fields.m_meshFilter;
			//           v27 = (Object_1 *)this.fields.m_mesh;
			//           if ( !static_fields )
			//             goto LABEL_45;
			//           v29 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(static_fields, 0LL);
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v28);
			//           if ( !UnityEngine::Object::op_Inequality(v27, v29, 0LL) )
			//             goto LABEL_43;
			//           HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(this, 0LL);
			//         }
			//         HG::Rendering::Runtime::HGWaterRendererV2::AddEntity(this, 0LL);
			//         goto LABEL_43;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//       v10 = *(_QWORD *)(v9 + 16) == 0LL;
			//     }
			//     else
			//     {
			//       static_fields = (MeshFilter *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//       if ( !m_mesh )
			//         goto LABEL_45;
			//       v10 = m_mesh.fields._.m_CachedPtr == 0LL;
			//     }
			//     v11 = v10;
			//     goto LABEL_27;
			//   }
			// }
			// 
		}

		private void TransformChanged()
		{
			// // Void TransformChanged()
			// void HG::Rendering::Runtime::HGWaterRendererV2::TransformChanged(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (__fastcall *v5)(HGWaterRendererV2 *); // rax
			//   __int64 v6; // rbx
			//   unsigned __int8 (__fastcall *v7)(__int64); // rax
			//   Transform *transform; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rax
			//   __int64 v11; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size > 4699 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_13;
			//     if ( LODWORD(v3._0.namespaze) <= 0x125B )
			//       sub_180070270(v3, wrapperArray);
			//     if ( v3[100]._0.namespaze )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4699, 0LL);
			//       if ( !Patch )
			//         goto LABEL_13;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//   }
			//   v5 = (__int64 (__fastcall *)(HGWaterRendererV2 *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v5 = (__int64 (__fastcall *)(HGWaterRendererV2 *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v5 )
			//     {
			//       v10 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v10, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v5;
			//   }
			//   v6 = v5(this);
			//   if ( !v6 )
			//     goto LABEL_13;
			//   v7 = (unsigned __int8 (__fastcall *)(__int64))qword_18D8F52C0;
			//   if ( !qword_18D8F52C0 )
			//   {
			//     v7 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.Transform::get_hasChanged()");
			//     if ( !v7 )
			//     {
			//       v11 = sub_1802DBBE8("UnityEngine.Transform::get_hasChanged()");
			//       sub_18000F750(v11, 0LL);
			//     }
			//     qword_18D8F52C0 = (__int64)v7;
			//   }
			//   if ( v7(v6) )
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( transform )
			//     {
			//       UnityEngine::Transform::set_hasChanged(transform, 0, 0LL);
			//       HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
			//       return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// }
			// 
		}

		private void AddEntity()
		{
			// // Void AddEntity()
			// void HG::Rendering::Runtime::HGWaterRendererV2::AddEntity(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   void (__fastcall *v4)(EntityManager_1 *); // rax
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v5; // xmm6
			//   void (__fastcall *v6)(EntityManager_1 *, _QWORD, Void *, EntityType *); // rax
			//   __int64 v7; // rax
			//   __int64 v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   EntityManager_1 v12; // [rsp+20h] [rbp-38h] BYREF
			//   EntityManager_1 v13; // [rsp+30h] [rbp-28h] BYREF
			//   EntityType entityType; // [rsp+70h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDBEB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D8EDBEB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4695, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4695, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity, v3);
			//     if ( !*(_QWORD *)&this.fields.m_entity )
			//     {
			//       v4 = (void (__fastcall *)(EntityManager_1 *))qword_18D8F5E78;
			//       v12 = 0LL;
			//       if ( !qword_18D8F5E78 )
			//       {
			//         v4 = (void (__fastcall *)(EntityManager_1 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManage"
			//                                                        "r_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//         if ( !v4 )
			//         {
			//           v7 = sub_1802DBBE8(
			//                  "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//           sub_18000F750(v7, 0LL);
			//         }
			//         qword_18D8F5E78 = (__int64)v4;
			//       }
			//       v4(&v12);
			//       v13 = v12;
			//       v5 = *HG::Rendering::Runtime::HGWaterRendererV2::get_s_waterType(
			//               (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v12,
			//               0LL);
			//       if ( !byte_18D8F5E64 )
			//       {
			//         sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::HyperGryph::ECS::ComponentType>);
			//         byte_18D8F5E64 = 1;
			//       }
			//       v6 = (void (__fastcall *)(EntityManager_1 *, _QWORD, Void *, EntityType *))qword_18D8F5EA0;
			//       entityType.id = 0;
			//       if ( !qword_18D8F5EA0 )
			//       {
			//         v6 = (void (__fastcall *)(EntityManager_1 *, _QWORD, Void *, EntityType *))il2cpp_resolve_icall_0(
			//                                                                                      "UnityEngine.HyperGryph.ECS.EntityMa"
			//                                                                                      "nager::GetOrRegisterEntityTypeImpl_"
			//                                                                                      "Injected(UnityEngine.HyperGryph.ECS"
			//                                                                                      ".EntityManager&,System.Int32,System"
			//                                                                                      ".IntPtr,UnityEngine.HyperGryph.ECS.EntityType&)");
			//         if ( !v6 )
			//         {
			//           v8 = sub_1802DBBE8(
			//                  "UnityEngine.HyperGryph.ECS.EntityManager::GetOrRegisterEntityTypeImpl_Injected(UnityEngine.HyperGryph.E"
			//                  "CS.EntityManager&,System.Int32,System.IntPtr,UnityEngine.HyperGryph.ECS.EntityType&)");
			//           sub_18000F750(v8, 0LL);
			//         }
			//         qword_18D8F5EA0 = (__int64)v6;
			//       }
			//       v6(&v13, (unsigned int)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v5, 8)), v5.m_Buffer, &entityType);
			//       this.fields.m_entity = UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&v13, entityType, 0LL);
			//       HG::Rendering::Runtime::HGWaterRendererV2::UpdateEntity(this, 0LL);
			//     }
			//   }
			// }
			// 
		}

		private void RemoveEntity()
		{
			// // Void RemoveEntity()
			// void HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   EntityManager_1 v4; // xmm0
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   EntityManager_1 _unity_self; // [rsp+20h] [rbp-28h] BYREF
			//   EntityManager_1 v10; // [rsp+30h] [rbp-18h] BYREF
			//   Entity_1 entity; // [rsp+60h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDBEC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D8EDBEC = 1;
			//   }
			//   _unity_self = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4692, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4692, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity, v3);
			//     if ( this.fields.m_entity )
			//     {
			//       v4 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v10, 0LL);
			//       entity = this.fields.m_entity;
			//       _unity_self = v4;
			//       UnityEngine::HyperGryph::ECS::EntityManager::DestroyEntity_Injected(&_unity_self, &entity, 0LL);
			//       if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity, v5);
			//       this.fields.m_entity = 0LL;
			//     }
			//   }
			// }
			// 
		}

		public void UpdateEntity()
		{
			// // Void UpdateEntity()
			// void HG::Rendering::Runtime::HGWaterRendererV2::UpdateEntity(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   MeshFilter *m_meshFilter; // rcx
			//   __int64 v5; // rdx
			//   Object_1 *sharedMesh; // rbx
			//   void (__fastcall *v7)(RenderObjectInfoComponent *); // rax
			//   Mesh *v8; // rbx
			//   Transform *transform; // rax
			//   Bounds *Bounds; // rax
			//   __m128 v11; // xmm6
			//   Object_1 *v12; // rax
			//   __int64 v13; // rdx
			//   int32_t InstanceID; // r12d
			//   Object_1 *waterConfig; // rbx
			//   HGWaterConfig *v16; // rax
			//   int32_t materialIndex; // r14d
			//   struct MethodInfo *v18; // rsi
			//   MethodInfo **rgctx_data; // r9
			//   _QWORD *v20; // rbx
			//   _QWORD *sceneMask; // rsi
			//   EntityInstanceData *v22; // rcx
			//   struct MethodInfo *v23; // r15
			//   EntityInstanceData *v24; // rcx
			//   struct MethodInfo *v25; // r15
			//   EntityInstanceData *v26; // rcx
			//   struct MethodInfo *v27; // r15
			//   EntityInstanceData *v28; // rcx
			//   struct MethodInfo *v29; // r15
			//   EntityInstanceData *v30; // rcx
			//   struct MethodInfo *v31; // r15
			//   EntityInstanceData *v32; // rcx
			//   HGWaterComponent *HGWaterComponent; // rax
			//   struct MethodInfo *v34; // r14
			//   bool v35; // zf
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   EntityInstanceData *v41; // rcx
			//   GameObject *gameObject; // rax
			//   char layer; // al
			//   GameObject *v44; // rax
			//   int32_t artTag; // eax
			//   struct MethodInfo *v46; // r14
			//   EntityInstanceData *v47; // rcx
			//   __int64 v48; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RenderObjectInfoComponent v50; // [rsp+30h] [rbp-D0h] BYREF
			//   Bounds v51; // [rsp+48h] [rbp-B8h] BYREF
			//   HGWaterComponent v52; // [rsp+60h] [rbp-A0h] BYREF
			//   HGWaterComponent v53; // [rsp+D0h] [rbp-30h] BYREF
			//   BoundingCenterXComponent t; // [rsp+190h] [rbp+90h] BYREF
			// 
			//   if ( !byte_18D8EDBED )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBED = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4696, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4696, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_42;
			//   }
			//   if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity, v3);
			//   if ( this.fields.m_entity )
			//   {
			//     m_meshFilter = this.fields.m_meshFilter;
			//     if ( !m_meshFilter )
			//       goto LABEL_42;
			//     sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( UnityEngine::Object::op_Inequality(sharedMesh, 0LL, 0LL) )
			//     {
			//       v7 = (void (__fastcall *)(RenderObjectInfoComponent *))qword_18D8F5E78;
			//       *(_OWORD *)&v50.roLayerMask = 0LL;
			//       if ( !qword_18D8F5E78 )
			//       {
			//         v7 = (void (__fastcall *)(RenderObjectInfoComponent *))il2cpp_resolve_icall_0(
			//                                                                  "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEn"
			//                                                                  "tityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//         if ( !v7 )
			//         {
			//           v48 = sub_1802DBBE8(
			//                   "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS"
			//                   ".EntityManager&)");
			//           sub_18000F750(v48, 0LL);
			//         }
			//         qword_18D8F5E78 = (__int64)v7;
			//       }
			//       v7(&v50);
			//       m_meshFilter = this.fields.m_meshFilter;
			//       if ( m_meshFilter )
			//       {
			//         v8 = UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
			//         transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         Bounds = HG::Rendering::Runtime::HGWaterRendererV2::GetBounds(&v51, v8, transform, 0LL);
			//         m_meshFilter = this.fields.m_meshFilter;
			//         v11 = *(__m128 *)&Bounds.m_Center.x;
			//         *(_QWORD *)&v51.m_Extents.y = *(_QWORD *)&Bounds.m_Extents.y;
			//         if ( m_meshFilter )
			//         {
			//           v12 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
			//           if ( v12 )
			//           {
			//             InstanceID = UnityEngine::Object::GetInstanceID(v12, 0LL);
			//             waterConfig = (Object_1 *)this.fields.waterConfig;
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//             if ( UnityEngine::Object::op_Inequality(waterConfig, 0LL, 0LL) )
			//             {
			//               v16 = this.fields.waterConfig;
			//               if ( !v16 )
			//                 goto LABEL_42;
			//               materialIndex = v16.fields.materialIndex;
			//             }
			//             else
			//             {
			//               materialIndex = 0;
			//             }
			//             if ( this.fields.m_dynamicMaterialIndex != -1 )
			//               materialIndex = this.fields.m_dynamicMaterialIndex;
			//             v18 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>;
			//             LODWORD(t.x) = (BoundingCenterXComponent)v11.m128_i32[0];
			//             if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>.rgctx_data )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//             rgctx_data = (MethodInfo **)v18.rgctx_data;
			//             v20 = *(_QWORD **)&v50.roLayerMask;
			//             sceneMask = (_QWORD *)v50.sceneMask;
			//             v22 = (EntityInstanceData *)(**(_QWORD **)&v50.roLayerMask + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
			//               v22,
			//               (EntityTypeInstanceData *)(*(_QWORD *)v50.sceneMask + 576LL * v22.entityType),
			//               &t,
			//               *rgctx_data);
			//             v23 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>;
			//             LODWORD(t.x) = (BoundingCenterXComponent)_mm_shuffle_ps(v11, v11, 85).m128_u32[0];
			//             if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>.rgctx_data )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//             v24 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
			//               v24,
			//               (EntityTypeInstanceData *)(*sceneMask + 576LL * v24.entityType),
			//               (BoundingCenterYComponent *)&t,
			//               (MethodInfo *)v23.rgctx_data.rgctxDataDummy);
			//             v25 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>;
			//             LODWORD(t.x) = (BoundingCenterXComponent)_mm_shuffle_ps(v11, v11, 170).m128_u32[0];
			//             if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>.rgctx_data )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//             v26 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
			//               v26,
			//               (EntityTypeInstanceData *)(*sceneMask + 576LL * v26.entityType),
			//               (BoundingCenterZComponent *)&t,
			//               (MethodInfo *)v25.rgctx_data.rgctxDataDummy);
			//             v27 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>;
			//             LODWORD(t.x) = (BoundingCenterXComponent)_mm_shuffle_ps(v11, v11, 255).m128_u32[0];
			//             if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>.rgctx_data )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//             v28 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
			//               v28,
			//               (EntityTypeInstanceData *)(*sceneMask + 576LL * v28.entityType),
			//               (BoundingExtentXComponent *)&t,
			//               (MethodInfo *)v27.rgctx_data.rgctxDataDummy);
			//             v29 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>;
			//             t.x = v51.m_Extents.y;
			//             if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>.rgctx_data )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//             v30 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
			//               v30,
			//               (EntityTypeInstanceData *)(*sceneMask + 576LL * v30.entityType),
			//               (BoundingExtentYComponent *)&t,
			//               (MethodInfo *)v29.rgctx_data.rgctxDataDummy);
			//             v31 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>;
			//             t.x = v51.m_Extents.z;
			//             if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>.rgctx_data )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//             v32 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
			//               v32,
			//               (EntityTypeInstanceData *)(*sceneMask + 576LL * v32.entityType),
			//               (BoundingExtentZComponent *)&t,
			//               (MethodInfo *)v31.rgctx_data.rgctxDataDummy);
			//             HGWaterComponent = HG::Rendering::Runtime::HGWaterRendererV2::GetHGWaterComponent(
			//                                  &v53,
			//                                  this,
			//                                  InstanceID,
			//                                  materialIndex,
			//                                  0LL);
			//             v34 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>;
			//             v35 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>.rgctx_data == 0LL;
			//             v36 = *(_OWORD *)&HGWaterComponent.objectToWorld.m20;
			//             *(_OWORD *)&v52.renderTypeMask = *(_OWORD *)&HGWaterComponent.renderTypeMask;
			//             v37 = *(_OWORD *)&HGWaterComponent.objectToWorld.m21;
			//             *(_OWORD *)&v52.objectToWorld.m20 = v36;
			//             v38 = *(_OWORD *)&HGWaterComponent.objectToWorld.m22;
			//             *(_OWORD *)&v52.objectToWorld.m21 = v37;
			//             v39 = *(_OWORD *)&HGWaterComponent.objectToWorld.m23;
			//             *(_OWORD *)&v52.objectToWorld.m22 = v38;
			//             v40 = *(_OWORD *)&HGWaterComponent.param0.z;
			//             *(_OWORD *)&v52.objectToWorld.m23 = v39;
			//             *(_QWORD *)&v52.param1.z = *(_QWORD *)&HGWaterComponent.param1.z;
			//             *(_OWORD *)&v52.param0.z = v40;
			//             if ( v35 )
			//               sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>);
			//             v41 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::HGWaterComponent>(
			//               v41,
			//               (EntityTypeInstanceData *)(*sceneMask + 576LL * v41.entityType),
			//               &v52,
			//               (MethodInfo *)v34.rgctx_data.rgctxDataDummy);
			//             gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//             if ( gameObject )
			//             {
			//               layer = UnityEngine::GameObject::get_layer(gameObject, 0LL);
			//               v50.objectFlags = 1793;
			//               v50.sceneMask = -1LL;
			//               v50.roLayerMask = 1 << (layer & 0x1F);
			//               v44 = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//               if ( v44 )
			//               {
			//                 artTag = UnityEngine::GameObject::get_artTag(v44, 0LL);
			//                 v46 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>;
			//                 v50.artTag = artTag;
			//                 v50.sortingFudgeSqr = 256.0;
			//                 if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>.rgctx_data )
			//                   sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//                 v47 = (EntityInstanceData *)(*v20 + 16LL * this.fields.m_entity.globalIndex);
			//                 UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
			//                   v47,
			//                   (EntityTypeInstanceData *)(*sceneMask + 576LL * v47.entityType),
			//                   &v50,
			//                   (MethodInfo *)v46.rgctx_data.rgctxDataDummy);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_42:
			//       sub_180B536AC(m_meshFilter, v3);
			//     }
			//   }
			// }
			// 
		}

		public void RestWetnessOffset()
		{
			// // Void RestWetnessOffset()
			// void HG::Rendering::Runtime::HGWaterRendererV2::RestWetnessOffset(HGWaterRendererV2 *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4700, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4700, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_useFeatureWetnessOffset )
			//   {
			//     this.fields.wetnessOffset = this.fields.m_initWetnessOffset;
			//     this.fields.m_useFeatureWetnessOffset = 0;
			//   }
			// }
			// 
		}

		public void FeatureWetnessOffset(float offset)
		{
			// // Void FeatureWetnessOffset(Single)
			// void HG::Rendering::Runtime::HGWaterRendererV2::FeatureWetnessOffset(
			//         HGWaterRendererV2 *this,
			//         float offset,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4701, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4701, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, offset, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_useFeatureWetnessOffset )
			//       this.fields.m_initWetnessOffset = this.fields.wetnessOffset;
			//     this.fields.wetnessOffset = offset;
			//     this.fields.m_useFeatureWetnessOffset = 1;
			//   }
			// }
			// 
		}

		public HGWaterComponent GetHGWaterComponent(int meshInstanceID, int materialIndex)
		{
			// // HGWaterComponent GetHGWaterComponent(Int32, Int32)
			// HGWaterComponent *HG::Rendering::Runtime::HGWaterRendererV2::GetHGWaterComponent(
			//         HGWaterComponent *__return_ptr retstr,
			//         HGWaterRendererV2 *this,
			//         int32_t meshInstanceID,
			//         int32_t materialIndex,
			//         MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   bool v13; // zf
			//   float v14; // xmm3_4
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   float heightLayer; // xmm1_4
			//   __m128 v19; // xmm2
			//   __int128 v20; // xmm0
			//   __m128 v21; // xmm2
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __m128 v24; // xmm2
			//   Vector4 v25; // xmm2
			//   __int128 v26; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGWaterComponent *v29; // rax
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __m128 v35; // [rsp+30h] [rbp-C8h]
			//   HGWaterComponent v36; // [rsp+40h] [rbp-B8h] BYREF
			//   Matrix4x4 v37; // [rsp+B0h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4698, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4698, 0LL);
			//     if ( Patch )
			//     {
			//       v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1347(
			//               &v36,
			//               Patch,
			//               (Object *)this,
			//               meshInstanceID,
			//               materialIndex,
			//               0LL);
			//       v30 = *(_OWORD *)&v29.objectToWorld.m20;
			//       *(_OWORD *)&retstr.renderTypeMask = *(_OWORD *)&v29.renderTypeMask;
			//       v31 = *(_OWORD *)&v29.objectToWorld.m21;
			//       *(_OWORD *)&retstr.objectToWorld.m20 = v30;
			//       v32 = *(_OWORD *)&v29.objectToWorld.m22;
			//       *(_OWORD *)&retstr.objectToWorld.m21 = v31;
			//       v33 = *(_OWORD *)&v29.objectToWorld.m23;
			//       *(_OWORD *)&retstr.objectToWorld.m22 = v32;
			//       v34 = *(_OWORD *)&v29.param0.z;
			//       *(_OWORD *)&retstr.objectToWorld.m23 = v33;
			//       *(_QWORD *)&v33 = *(_QWORD *)&v29.param1.z;
			//       *(_OWORD *)&retstr.param0.z = v34;
			//       *(_QWORD *)&retstr.param1.z = v33;
			//       return retstr;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v11, v10);
			//   }
			//   v36.renderTypeMask = this.fields.renderType;
			//   memset(&v36.objectToWorld, 0, sizeof(v36.objectToWorld));
			//   v36.meshID = meshInstanceID;
			//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !transform )
			//     goto LABEL_7;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v37, transform, 0LL);
			//   v13 = !this.fields.enableOrderByDistance;
			//   v14 = 0.0;
			//   *(_QWORD *)&v36.param0.y = 0LL;
			//   v36.param0.w = 0.0;
			//   v15 = *(_OWORD *)&localToWorldMatrix.m01;
			//   *(_OWORD *)&v36.objectToWorld.m00 = *(_OWORD *)&localToWorldMatrix.m00;
			//   v16 = *(_OWORD *)&localToWorldMatrix.m02;
			//   *(_OWORD *)&v36.objectToWorld.m01 = v15;
			//   v17 = *(_OWORD *)&localToWorldMatrix.m03;
			//   *(_OWORD *)&v36.objectToWorld.m02 = v16;
			//   *(_OWORD *)&v36.objectToWorld.m03 = v17;
			//   v36.param0.x = (float)materialIndex;
			//   if ( !v13 )
			//     v14 = 1.0;
			//   heightLayer = (float)this.fields.heightLayer;
			//   v35.m128_i32[3] = 0;
			//   v19 = v35;
			//   v19.m128_f32[0] = this.fields.wetnessOffset;
			//   *(_OWORD *)&retstr.renderTypeMask = *(_OWORD *)&v36.renderTypeMask;
			//   v20 = *(_OWORD *)&v36.objectToWorld.m21;
			//   v21 = _mm_shuffle_ps(v19, v19, 225);
			//   v21.m128_f32[0] = heightLayer;
			//   *(_OWORD *)&retstr.objectToWorld.m20 = *(_OWORD *)&v36.objectToWorld.m20;
			//   v22 = *(_OWORD *)&v36.objectToWorld.m22;
			//   *(_OWORD *)&retstr.objectToWorld.m21 = v20;
			//   v23 = *(_OWORD *)&v36.objectToWorld.m23;
			//   *(_OWORD *)&retstr.objectToWorld.m22 = v22;
			//   v24 = _mm_shuffle_ps(v21, v21, 198);
			//   v24.m128_f32[0] = v14;
			//   v25 = (Vector4)_mm_shuffle_ps(v24, v24, 201);
			//   v36.param1 = v25;
			//   v26 = *(_OWORD *)&v36.param0.z;
			//   *(_OWORD *)&retstr.objectToWorld.m23 = v23;
			//   *(_OWORD *)&retstr.param0.z = v26;
			//   *(_QWORD *)&retstr.param1.z = *(_OWORD *)&_mm_unpackhi_pd((__m128d)v25, (__m128d)v25);
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Bounds GetBounds(Mesh mesh, Transform transform)
		{
			// // Bounds GetBounds(Mesh, Transform)
			// Bounds *HG::Rendering::Runtime::HGWaterRendererV2::GetBounds(
			//         Bounds *__return_ptr retstr,
			//         Mesh *mesh,
			//         Transform *transform,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *wrapperArray; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __m128 v10; // xmm6
			//   __m128 v11; // xmm7
			//   __m128 v12; // xmm8
			//   __m128 v13; // xmm9
			//   void (__fastcall *v14)(Mesh *, Vector4 *); // rax
			//   __m128 v15; // xmm5
			//   __m128 v16; // xmm10
			//   float v17; // xmm11_4
			//   float v18; // xmm6_4
			//   void (__fastcall *v19)(Transform *, Vector4 *); // rax
			//   void (__fastcall *v20)(Transform *, unsigned __int64 *); // rax
			//   void (__fastcall *v21)(unsigned __int64 *, Vector4 *, unsigned __int64 *, Matrix4x4 *); // rax
			//   __int64 v22; // rdx
			//   Vector4 v23; // xmm6
			//   float z; // xmm13_4
			//   __int64 v25; // rdx
			//   Vector4 v26; // xmm9
			//   float v27; // xmm14_4
			//   __int64 v28; // rdx
			//   Vector4 v29; // xmm10
			//   float v30; // xmm15_4
			//   void (__fastcall *v31)(Mesh *, Bounds *); // rax
			//   MethodInfo *v32; // r9
			//   Vector3 *v33; // rax
			//   __int64 v34; // xmm11_8
			//   __m128 si128; // xmm8
			//   void (__fastcall *v36)(Mesh *, Bounds *); // rax
			//   float v37; // xmm11_4
			//   MethodInfo *v38; // r9
			//   Vector3 *v39; // rax
			//   __m128 v40; // xmm3
			//   void (__fastcall *v41)(Mesh *, Bounds *); // rax
			//   float v42; // xmm6_4
			//   MethodInfo *v43; // r9
			//   Vector3 *v44; // rax
			//   __m128 z_low; // xmm12
			//   void (__fastcall *v46)(Mesh *, Bounds *); // rax
			//   __m128 v47; // xmm12
			//   MethodInfo *v48; // r9
			//   Vector3 *v49; // rax
			//   __int64 v50; // xmm10_8
			//   void (__fastcall *v51)(Mesh *, Bounds *); // rax
			//   float v52; // xmm10_4
			//   MethodInfo *v53; // r9
			//   Vector3 *v54; // rax
			//   __m128 v55; // xmm3
			//   void (__fastcall *v56)(Mesh *, Bounds *); // rax
			//   float v57; // xmm6_4
			//   MethodInfo *v58; // r9
			//   Vector3 *v59; // rax
			//   __m128 v60; // xmm9
			//   void (__fastcall *v61)(Mesh *, Bounds *); // rax
			//   __m128 v62; // xmm9
			//   MethodInfo *v63; // r9
			//   Vector3 *v64; // rax
			//   __int64 v65; // xmm10_8
			//   void (__fastcall *v66)(Mesh *, Bounds *); // rax
			//   float v67; // xmm10_4
			//   MethodInfo *v68; // r9
			//   Vector3 *v69; // rax
			//   __m128 v70; // xmm3
			//   void (__fastcall *v71)(Mesh *, Bounds *); // rax
			//   float v72; // xmm6_4
			//   MethodInfo *v73; // r9
			//   Vector3 *v74; // rax
			//   __m128 v75; // xmm1
			//   float v76; // xmm3_4
			//   float v77; // xmm2_4
			//   MethodInfo *v78; // r9
			//   Vector3 *v79; // rax
			//   __int64 v80; // xmm0_8
			//   Bounds *result; // rax
			//   __int64 v82; // rax
			//   __int64 v83; // rax
			//   __int64 v84; // rax
			//   __int64 v85; // rax
			//   ILFixDynamicMethodWrapper_2 *v86; // rax
			//   Vector3 *v87; // rax
			//   unsigned __int64 v88; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *v89; // rax
			//   Vector3 *v90; // rax
			//   unsigned __int64 v91; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *v92; // rax
			//   Vector3 *v93; // rax
			//   unsigned __int64 v94; // xmm1_8
			//   __int64 v95; // rax
			//   __int64 v96; // rax
			//   __int64 v97; // rax
			//   __int64 v98; // rax
			//   __int64 v99; // rax
			//   __int64 v100; // rax
			//   __int64 v101; // rax
			//   __int64 v102; // rax
			//   __int64 v103; // rax
			//   Bounds *v104; // rax
			//   __int128 v105; // xmm0
			//   __int64 v106; // xmm1_8
			//   Vector4 v107; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector4 v108; // [rsp+48h] [rbp-C0h] BYREF
			//   Bounds v109; // [rsp+58h] [rbp-B0h] BYREF
			//   unsigned __int64 v110; // [rsp+70h] [rbp-98h] BYREF
			//   int v111; // [rsp+78h] [rbp-90h]
			//   unsigned __int64 v112; // [rsp+88h] [rbp-80h] BYREF
			//   int v113; // [rsp+90h] [rbp-78h]
			//   unsigned __int64 v114; // [rsp+98h] [rbp-70h] BYREF
			//   int v115; // [rsp+A0h] [rbp-68h]
			//   Vector4 v116; // [rsp+A8h] [rbp-60h] BYREF
			//   __int64 v117; // [rsp+B8h] [rbp-50h]
			//   Matrix4x4 v118; // [rsp+C0h] [rbp-48h] BYREF
			//   Matrix4x4 v119; // [rsp+108h] [rbp+0h] BYREF
			//   __m128 v120; // [rsp+148h] [rbp+40h]
			//   __m128 v121; // [rsp+158h] [rbp+50h]
			//   float v122; // [rsp+218h] [rbp+110h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4697, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4697, 0LL);
			//     if ( Patch )
			//     {
			//       v104 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1281(&v109, Patch, (Object *)mesh, (Object *)transform, 0LL);
			//       v105 = *(_OWORD *)&v104.m_Center.x;
			//       v106 = *(_QWORD *)&v104.m_Extents.y;
			//       result = retstr;
			//       *(_OWORD *)&retstr.m_Center.x = v105;
			//       *(_QWORD *)&retstr.m_Extents.y = v106;
			//       return result;
			//     }
			//     goto LABEL_39;
			//   }
			//   if ( !transform )
			//     goto LABEL_39;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v119, transform, 0LL);
			//   v10 = *(__m128 *)&localToWorldMatrix.m00;
			//   v11 = *(__m128 *)&localToWorldMatrix.m01;
			//   v12 = *(__m128 *)&localToWorldMatrix.m02;
			//   v13 = *(__m128 *)&localToWorldMatrix.m03;
			//   if ( !mesh )
			//     goto LABEL_39;
			//   v117 = 0LL;
			//   v14 = (void (__fastcall *)(Mesh *, Vector4 *))qword_18D8F4940;
			//   v116 = 0LL;
			//   if ( !qword_18D8F4940 )
			//   {
			//     v14 = (void (__fastcall *)(Mesh *, Vector4 *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v14 )
			//     {
			//       v82 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v82, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v14;
			//   }
			//   v14(mesh, &v116);
			//   v15 = _mm_shuffle_ps(v10, v10, 85);
			//   v16 = _mm_shuffle_ps(v10, v10, 170);
			//   v17 = (float)(v11.m128_f32[0] * v116.y) + (float)(v10.m128_f32[0] * v116.x);
			//   v18 = (float)((float)((float)(_mm_shuffle_ps(v10, v10, 255).m128_f32[0] * v116.x)
			//                       + (float)(_mm_shuffle_ps(v11, v11, 255).m128_f32[0] * v116.y))
			//               + (float)(_mm_shuffle_ps(v12, v12, 255).m128_f32[0] * v116.z))
			//       + _mm_shuffle_ps(v13, v13, 255).m128_f32[0];
			//   v15.m128_f32[0] = (float)((float)((float)((float)(v15.m128_f32[0] * v116.x)
			//                                           + (float)(_mm_shuffle_ps(v11, v11, 85).m128_f32[0] * v116.y))
			//                                   + (float)(_mm_shuffle_ps(v12, v12, 85).m128_f32[0] * v116.z))
			//                           + _mm_shuffle_ps(v13, v13, 85).m128_f32[0])
			//                   * (float)(1.0 / v18);
			//   v16.m128_f32[0] = (float)((float)((float)((float)(v16.m128_f32[0] * v116.x)
			//                                           + (float)(_mm_shuffle_ps(v11, v11, 170).m128_f32[0] * v116.y))
			//                                   + (float)(_mm_shuffle_ps(v12, v12, 170).m128_f32[0] * v116.z))
			//                           + _mm_shuffle_ps(v13, v13, 170).m128_f32[0])
			//                   * (float)(1.0 / v18);
			//   v122 = (float)((float)(v17 + (float)(v12.m128_f32[0] * v116.z)) + v13.m128_f32[0]) * (float)(1.0 / v18);
			//   v120 = v15;
			//   v121 = v16;
			//   sub_182805160(&v119);
			//   v19 = (void (__fastcall *)(Transform *, Vector4 *))qword_18D8F5300;
			//   v108 = 0LL;
			//   if ( !qword_18D8F5300 )
			//   {
			//     v19 = (void (__fastcall *)(Transform *, Vector4 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//     if ( !v19 )
			//     {
			//       v83 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//       sub_18000F750(v83, 0LL);
			//     }
			//     qword_18D8F5300 = (__int64)v19;
			//   }
			//   v19(transform, &v108);
			//   v110 = 0LL;
			//   v111 = 0;
			//   v20 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18D8F5380;
			//   if ( !qword_18D8F5380 )
			//   {
			//     v20 = (void (__fastcall *)(Transform *, unsigned __int64 *))il2cpp_resolve_icall_0(
			//                                                                   "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
			//     if ( !v20 )
			//     {
			//       v84 = sub_1802DBBE8("UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v84, 0LL);
			//     }
			//     qword_18D8F5380 = (__int64)v20;
			//   }
			//   v20(transform, &v110);
			//   v114 = v110;
			//   v115 = v111;
			//   v21 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, Matrix4x4 *))qword_18D8F4BC8;
			//   v113 = 0;
			//   v112 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   memset(&v118, 0, sizeof(v118));
			//   if ( !qword_18D8F4BC8 )
			//   {
			//     v21 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                                  "UnityEngine.Matrix4x4::"
			//                                                                                                  "TRS_Injected(UnityEngin"
			//                                                                                                  "e.Vector3&,UnityEngine."
			//                                                                                                  "Quaternion&,UnityEngine"
			//                                                                                                  ".Vector3&,UnityEngine.Matrix4x4&)");
			//     if ( !v21 )
			//     {
			//       v85 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v85, 0LL);
			//     }
			//     qword_18D8F4BC8 = (__int64)v21;
			//   }
			//   v21(&v112, &v108, &v114, &v118);
			//   v119 = v118;
			//   v23 = *UnityEngine::Matrix4x4::GetColumn(&v108, &v119, 0, 0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v22);
			//     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)wrapperArray.static_fields.wrapperArray;
			//   if ( !Patch )
			//     goto LABEL_39;
			//   if ( Patch.fields.methodId <= 1165 )
			//     goto LABEL_14;
			//   if ( !wrapperArray._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(wrapperArray, Patch);
			//     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_39;
			//   if ( LODWORD(wrapperArray._0.namespaze) <= 0x48D )
			//     goto LABEL_73;
			//   if ( wrapperArray[24].vtable.Finalize.methodPtr )
			//   {
			//     v86 = IFix::WrappersManagerImpl::GetPatch(1165, 0LL);
			//     v108.x = v23.x;
			//     LODWORD(v108.w) = _mm_shuffle_ps((__m128)v23, (__m128)v23, 255).m128_u32[0];
			//     LODWORD(v108.y) = _mm_shuffle_ps((__m128)v23, (__m128)v23, 85).m128_u32[0];
			//     LODWORD(v108.z) = _mm_shuffle_ps((__m128)v23, (__m128)v23, 170).m128_u32[0];
			//     if ( !v86 )
			//       goto LABEL_39;
			//     v87 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433((Vector3 *)&v107, v86, &v108, 0LL);
			//     z = v87.z;
			//     v88 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v87.x, (__m128)*(unsigned __int64 *)&v87.x, 85).m128_u64[0];
			//     *(_QWORD *)&v107.x = *(_QWORD *)&v87.x;
			//     v23.x = v107.x;
			//     v112 = v88;
			//   }
			//   else
			//   {
			// LABEL_14:
			//     LODWORD(v112) = _mm_shuffle_ps((__m128)v23, (__m128)v23, 85).m128_u32[0];
			//     LODWORD(z) = _mm_shuffle_ps((__m128)v23, (__m128)v23, 170).m128_u32[0];
			//   }
			//   v26 = *UnityEngine::Matrix4x4::GetColumn(&v108, &v119, 1, 0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v25);
			//     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)wrapperArray.static_fields.wrapperArray;
			//   if ( !Patch )
			//     goto LABEL_39;
			//   if ( Patch.fields.methodId <= 1165 )
			//     goto LABEL_21;
			//   if ( !wrapperArray._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(wrapperArray, Patch);
			//     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_39;
			//   if ( LODWORD(wrapperArray._0.namespaze) <= 0x48D )
			//     goto LABEL_73;
			//   if ( wrapperArray[24].vtable.Finalize.methodPtr )
			//   {
			//     v89 = IFix::WrappersManagerImpl::GetPatch(1165, 0LL);
			//     v108.x = v26.x;
			//     LODWORD(v108.w) = _mm_shuffle_ps((__m128)v26, (__m128)v26, 255).m128_u32[0];
			//     LODWORD(v108.y) = _mm_shuffle_ps((__m128)v26, (__m128)v26, 85).m128_u32[0];
			//     LODWORD(v108.z) = _mm_shuffle_ps((__m128)v26, (__m128)v26, 170).m128_u32[0];
			//     if ( !v89 )
			//       goto LABEL_39;
			//     v90 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433((Vector3 *)&v107, v89, &v108, 0LL);
			//     v27 = v90.z;
			//     v91 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v90.x, (__m128)*(unsigned __int64 *)&v90.x, 85).m128_u64[0];
			//     *(_QWORD *)&v107.x = *(_QWORD *)&v90.x;
			//     v26.x = v107.x;
			//     v114 = v91;
			//   }
			//   else
			//   {
			// LABEL_21:
			//     LODWORD(v114) = _mm_shuffle_ps((__m128)v26, (__m128)v26, 85).m128_u32[0];
			//     LODWORD(v27) = _mm_shuffle_ps((__m128)v26, (__m128)v26, 170).m128_u32[0];
			//   }
			//   v29 = *UnityEngine::Matrix4x4::GetColumn(&v116, &v119, 2, 0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v28);
			//     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)wrapperArray.static_fields.wrapperArray;
			//   if ( !Patch )
			//     goto LABEL_39;
			//   if ( Patch.fields.methodId > 1165 )
			//   {
			//     if ( !wrapperArray._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(wrapperArray, Patch);
			//       wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_39;
			//     if ( LODWORD(wrapperArray._0.namespaze) > 0x48D )
			//     {
			//       if ( !wrapperArray[24].vtable.Finalize.methodPtr )
			//         goto LABEL_28;
			//       v92 = IFix::WrappersManagerImpl::GetPatch(1165, 0LL);
			//       v108.x = v29.x;
			//       LODWORD(v108.w) = _mm_shuffle_ps((__m128)v29, (__m128)v29, 255).m128_u32[0];
			//       LODWORD(v108.y) = _mm_shuffle_ps((__m128)v29, (__m128)v29, 85).m128_u32[0];
			//       LODWORD(v108.z) = _mm_shuffle_ps((__m128)v29, (__m128)v29, 170).m128_u32[0];
			//       if ( v92 )
			//       {
			//         v107 = v108;
			//         v93 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433((Vector3 *)&v108, v92, &v107, 0LL);
			//         v30 = v93.z;
			//         v94 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v93.x, (__m128)*(unsigned __int64 *)&v93.x, 85).m128_u64[0];
			//         *(_QWORD *)&v107.x = *(_QWORD *)&v93.x;
			//         v29.x = v107.x;
			//         v110 = v94;
			//         goto LABEL_29;
			//       }
			// LABEL_39:
			//       sub_180B536AC(wrapperArray, Patch);
			//     }
			// LABEL_73:
			//     sub_180070270(wrapperArray, Patch);
			//   }
			// LABEL_28:
			//   LODWORD(v110) = _mm_shuffle_ps((__m128)v29, (__m128)v29, 85).m128_u32[0];
			//   LODWORD(v30) = _mm_shuffle_ps((__m128)v29, (__m128)v29, 170).m128_u32[0];
			// LABEL_29:
			//   v31 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   if ( !qword_18D8F4940 )
			//   {
			//     v31 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v31 )
			//     {
			//       v95 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v95, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v31;
			//   }
			//   v31(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v33 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v32);
			//   v34 = *(_QWORD *)&v33.x;
			//   v107.z = v33.z;
			//   si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18A357260);
			//   *(_QWORD *)&v107.x = v34;
			//   v36 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   LODWORD(v37) = COERCE_UNSIGNED_INT(*(float *)&v34 * v23.x) & si128.m128_i32[0];
			//   if ( !qword_18D8F4940 )
			//   {
			//     v36 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v36 )
			//     {
			//       v96 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v96, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v36;
			//   }
			//   v36(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v39 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v38);
			//   v40 = (__m128)*(unsigned __int64 *)&v39.x;
			//   v107.z = v39.z;
			//   *(_QWORD *)&v107.x = v40.m128_u64[0];
			//   v41 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   LODWORD(v42) = COERCE_UNSIGNED_INT(_mm_shuffle_ps(v40, v40, 85).m128_f32[0] * v26.x) & si128.m128_i32[0];
			//   if ( !qword_18D8F4940 )
			//   {
			//     v41 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v41 )
			//     {
			//       v97 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v97, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v41;
			//   }
			//   v41(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v44 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v43);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v44.x;
			//   z_low = (__m128)LODWORD(v44.z);
			//   z_low.m128_f32[0] = z_low.m128_f32[0] * v29.x;
			//   v46 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   v47 = _mm_and_ps(z_low, si128);
			//   v47.m128_f32[0] = v47.m128_f32[0] + (float)(v42 + v37);
			//   if ( !qword_18D8F4940 )
			//   {
			//     v46 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v46 )
			//     {
			//       v98 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v98, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v46;
			//   }
			//   v46(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v49 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v48);
			//   v50 = *(_QWORD *)&v49.x;
			//   v107.z = v49.z;
			//   *(_QWORD *)&v107.x = v50;
			//   v51 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   LODWORD(v52) = COERCE_UNSIGNED_INT(*(float *)&v50 * *(float *)&v112) & si128.m128_i32[0];
			//   if ( !qword_18D8F4940 )
			//   {
			//     v51 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v51 )
			//     {
			//       v99 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v99, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v51;
			//   }
			//   v51(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v54 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v53);
			//   v55 = (__m128)*(unsigned __int64 *)&v54.x;
			//   v107.z = v54.z;
			//   *(_QWORD *)&v107.x = v55.m128_u64[0];
			//   v56 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   LODWORD(v57) = COERCE_UNSIGNED_INT(_mm_shuffle_ps(v55, v55, 85).m128_f32[0] * *(float *)&v114) & si128.m128_i32[0];
			//   if ( !qword_18D8F4940 )
			//   {
			//     v56 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v56 )
			//     {
			//       v100 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v100, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v56;
			//   }
			//   v56(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v59 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v58);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v59.x;
			//   v60 = (__m128)LODWORD(v59.z);
			//   v60.m128_f32[0] = v60.m128_f32[0] * *(float *)&v110;
			//   v61 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   v62 = _mm_and_ps(v60, si128);
			//   v62.m128_f32[0] = v62.m128_f32[0] + (float)(v57 + v52);
			//   if ( !qword_18D8F4940 )
			//   {
			//     v61 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v61 )
			//     {
			//       v101 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v101, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v61;
			//   }
			//   v61(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v64 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v63);
			//   v65 = *(_QWORD *)&v64.x;
			//   v107.z = v64.z;
			//   *(_QWORD *)&v107.x = v65;
			//   v66 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   LODWORD(v67) = COERCE_UNSIGNED_INT(*(float *)&v65 * z) & si128.m128_i32[0];
			//   if ( !qword_18D8F4940 )
			//   {
			//     v66 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v66 )
			//     {
			//       v102 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v102, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v66;
			//   }
			//   v66(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v69 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v68);
			//   v70 = (__m128)*(unsigned __int64 *)&v69.x;
			//   v107.z = v69.z;
			//   *(_QWORD *)&v107.x = v70.m128_u64[0];
			//   v71 = (void (__fastcall *)(Mesh *, Bounds *))qword_18D8F4940;
			//   memset(&v109, 0, sizeof(v109));
			//   LODWORD(v72) = COERCE_UNSIGNED_INT(_mm_shuffle_ps(v70, v70, 85).m128_f32[0] * v27) & si128.m128_i32[0];
			//   if ( !qword_18D8F4940 )
			//   {
			//     v71 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_0("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//     if ( !v71 )
			//     {
			//       v103 = sub_1802DBBE8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
			//       sub_18000F750(v103, 0LL);
			//     }
			//     qword_18D8F4940 = (__int64)v71;
			//   }
			//   v71(mesh, &v109);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v109.m_Extents.x;
			//   v107.z = v109.m_Extents.z;
			//   v74 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 2.0, v73);
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v74.x;
			//   v75 = v120;
			//   v76 = v121.m128_f32[0];
			//   v77 = v74.z * v30;
			//   *(_QWORD *)&retstr.m_Extents.x = 0LL;
			//   retstr.m_Extents.z = 0.0;
			//   *(_QWORD *)&retstr.m_Center.x = _mm_unpacklo_ps((__m128)LODWORD(v122), v75).m128_u64[0];
			//   retstr.m_Center.z = v76;
			//   *(_QWORD *)&v107.x = _mm_unpacklo_ps(v47, v62).m128_u64[0];
			//   v107.z = COERCE_FLOAT(LODWORD(v77) & si128.m128_i32[0]) + (float)(v72 + v67);
			//   v79 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v108, (Vector3 *)&v107, 0.5, v78);
			//   v80 = *(_QWORD *)&v79.x;
			//   *(float *)&v79 = v79.z;
			//   *(_QWORD *)&retstr.m_Extents.x = v80;
			//   LODWORD(retstr.m_Extents.z) = (_DWORD)v79;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void SetMeshFilterAndRendererVisibleInInspector(bool value)
		{
			// // Void SetMeshFilterAndRendererVisibleInInspector(Boolean)
			// void HG::Rendering::Runtime::HGWaterRendererV2::SetMeshFilterAndRendererVisibleInInspector(
			//         HGWaterRendererV2 *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   BOOL v4; // edi
			//   GameObject *gameObject; // rax
			//   __int64 v6; // rdx
			//   Object *v7; // rcx
			//   GameObject *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *v10; // [rsp+20h] [rbp-18h] BYREF
			//   Object *component; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   v4 = value;
			//   if ( !byte_18D919843 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::MeshRenderer>);
			//     byte_18D919843 = 1;
			//   }
			//   component = 0LL;
			//   v10 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4702, 0LL) )
			//   {
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     if ( !gameObject )
			//       goto LABEL_13;
			//     if ( UnityEngine::GameObject::TryGetComponent<System::Object>(
			//            gameObject,
			//            &component,
			//            MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::MeshFilter>) )
			//     {
			//       v7 = component;
			//       if ( !component )
			//         goto LABEL_13;
			//       UnityEngine::Object::set_hideFlags((Object_1 *)component, (HideFlags__Enum)(2 * !v4), 0LL);
			//     }
			//     v8 = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     if ( v8 )
			//     {
			//       if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
			//               v8,
			//               &v10,
			//               MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::MeshRenderer>) )
			//         return;
			//       v7 = v10;
			//       if ( v10 )
			//       {
			//         UnityEngine::Object::set_hideFlags((Object_1 *)v10, (HideFlags__Enum)(2 * !v4), 0LL);
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4702, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, v4, 0LL);
			// }
			// 
		}

		private Mesh m_mesh;

		private MeshFilter m_meshFilter;

		private Entity m_entity;

		public HGWaterConfig waterConfig;

		public bool enableStreaming;

		public bool enableOrderByDistance;

		public HGWaterStreamingType waterStreamingType;

		public HGWaterRender.HGWaterRenderType renderType;

		public HGWaterRender.HGWaterHeightLayer heightLayer;

		[Header("水向上打湿高度的距离")]
		public float wetnessOffset;

		private bool m_useFeatureWetnessOffset;

		private float m_initWetnessOffset;

		private bool m_ecsDirty;

		[Header("动态赋值Index")]
		[SerializeField]
		private int m_dynamicMaterialIndex;
	}
}
