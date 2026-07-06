using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	[AddComponentMenu("Rendering/HG Grass")]
	[DisallowMultipleComponent]
	public class HGGrass : MonoBehaviour
	{
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000025D0 File Offset: 0x000007D0
		public HGGrassData grassData
		{
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
				//         HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return (Object *)this.fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_getValueDelegate(Func`1[Boolean])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
				//         ValueWatcher_1_System_Boolean_ *this,
				//         Func_1_Boolean_ *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (OneofDescriptorProto *)value,
				//     (FileDescriptor *)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}
		}

		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00002650 File Offset: 0x00000850
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x000025D0 File Offset: 0x000007D0
		public uint sceneStateMask
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_countAll()
				// int32_t Beyond::PoolCore::ObjectPool<System::Object>::get_countAll(
				//         ObjectPool_1_System_Object__3 *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._countAll_k__BackingField;
				// }
				// 
				return 0U;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_countAll(Int32)
				// void Beyond::PoolCore::ObjectPool<System::Object>::set_countAll(
				//         ObjectPool_1_System_Object__3 *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._countAll_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000025D0 File Offset: 0x000007D0
		public int areaId
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_count()
				// int32_t Beyond::SparkBuffer::Runtime::Map::get_count(Map *this, MethodInfo *method)
				// {
				//   return this.m_count;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_atlasIndex(Int32)
				// void UnityEngine::TextCore::Glyph::set_atlasIndex(Glyph *this, int32_t value, MethodInfo *method)
				// {
				//   this.fields.m_AtlasIndex = value;
				// }
				// 
			}
		}

		public HGGrass()
		{
			// // TouchControl()
			// void Rewired::ComponentControls::TouchControl::TouchControl(TouchControl_1 *this, MethodInfo *method)
			// {
			//   this.fields._._._lastUpdateFrame = -1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		protected void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGGrass::OnDisable(HGGrass *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2187, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2187, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(this, 0LL);
			//     this.fields.m_previousGrassDataInstanceID = 0;
			//     this.fields.m_previousGrassDataVersion = -1;
			//   }
			// }
			// 
		}

		protected void OnDestroy()
		{
			// // Void OnDestroy()
			// void HG::Rendering::Runtime::HGGrass::OnDestroy(HGGrass *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2189, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2189, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(this, 0LL);
			//     this.fields.m_previousGrassDataInstanceID = 0;
			//     this.fields.m_previousGrassDataVersion = -1;
			//   }
			// }
			// 
		}

		protected void Update()
		{
			// // Void Update()
			// void HG::Rendering::Runtime::HGGrass::Update(HGGrass *this, MethodInfo *method)
			// {
			//   int32_t GrassDataInstanceID; // esi
			//   int32_t GrassDataVersion; // eax
			//   int32_t v5; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2190, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2190, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     GrassDataInstanceID = HG::Rendering::Runtime::HGGrass::_GetGrassDataInstanceID(this.fields._grassData, 0LL);
			//     GrassDataVersion = HG::Rendering::Runtime::HGGrass::_GetGrassDataVersion(this.fields._grassData, 0LL);
			//     v5 = GrassDataVersion;
			//     if ( this.fields.m_previousGrassDataInstanceID != GrassDataInstanceID
			//       || GrassDataVersion != this.fields.m_previousGrassDataVersion )
			//     {
			//       HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(this, 0LL);
			//       HG::Rendering::Runtime::HGGrass::_CreateGrassEntities(this, 0LL);
			//       this.fields.m_previousGrassDataInstanceID = GrassDataInstanceID;
			//       this.fields.m_previousGrassDataVersion = v5;
			//     }
			//   }
			// }
			// 
		}

		private void _CreateGrassEntities()
		{
			// // Void _CreateGrassEntities()
			// void HG::Rendering::Runtime::HGGrass::_CreateGrassEntities(HGGrass *this, MethodInfo *method)
			// {
			//   Object_1 *grassData; // rbx
			//   uint64_t clusters; // rdx
			//   unsigned __int64 m_Buffer; // rcx
			//   EntityManager_1 v6; // xmm0
			//   HGGrassData *v7; // rax
			//   int32_t v8; // edx
			//   int32_t v9; // r15d
			//   __int64 v10; // r12
			//   HGGrassData *v11; // rax
			//   Object *Item; // rdi
			//   MethodInfo *v13; // rdx
			//   MethodInfo *v14; // rdx
			//   MethodInfo *v15; // rdx
			//   MethodInfo *v16; // rdx
			//   MethodInfo *v17; // rdx
			//   MethodInfo *v18; // rdx
			//   MethodInfo *v19; // rdx
			//   MethodInfo *v20; // rdx
			//   ComponentType v21; // xmm6
			//   Object__Class *klass; // rax
			//   int namespaze; // eax
			//   ComponentType *v24; // rax
			//   MonitorData *monitor; // rax
			//   ComponentType *v26; // rax
			//   uint32_t id; // ebx
			//   uint64_t v28; // rax
			//   float v29; // eax
			//   float v30; // xmm0_4
			//   int monitor_high; // ebx
			//   char v32; // al
			//   uint64_t v33; // rbx
			//   uint8_t *ComponentPtrLowBits; // r13
			//   int32_t v35; // ebx
			//   Object__Class *v36; // rax
			//   __int64 v37; // r14
			//   __int16 v38; // ax
			//   int idleNode_high; // xmm0_4
			//   int32_t v40; // eax
			//   _QWORD *v41; // rdx
			//   __m128 fightNode_high; // xmm2
			//   __int64 v43; // xmm1_8
			//   __int64 v44; // rax
			//   unsigned __int64 v45; // xmm0_8
			//   uint64_t ComponentMaskLow; // rax
			//   uint8_t *v47; // r14
			//   int v48; // ebx
			//   MonitorData *v49; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComponentType value; // [rsp+30h] [rbp-D0h] BYREF
			//   ComponentType v52; // [rsp+40h] [rbp-C0h] BYREF
			//   EntityManager_1 v53; // [rsp+50h] [rbp-B0h] BYREF
			//   NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v54; // [rsp+60h] [rbp-A0h] BYREF
			//   __int128 v55; // [rsp+70h] [rbp-90h]
			//   __int64 v56; // [rsp+80h] [rbp-80h]
			//   NativeArray_1_MagicaCloth_RestoreDistanceConstraint_RestoreDistanceData_ v57; // [rsp+88h] [rbp-78h] BYREF
			//   RenderObjectLODInfoComponent t; // [rsp+98h] [rbp-68h] BYREF
			//   Object__Class *v59; // [rsp+B0h] [rbp-50h]
			//   Object__Class *v60; // [rsp+C0h] [rbp-40h]
			//   __int64 v61; // [rsp+D0h] [rbp-30h]
			//   RenderObjectInfoComponent v62; // [rsp+E0h] [rbp-20h] BYREF
			//   WeaponComponent_WeaponMountPointModifier batchGroupKey; // [rsp+F8h] [rbp-8h] BYREF
			//   EntityManager_1 source; // [rsp+120h] [rbp+20h] BYREF
			//   _BYTE v65[32]; // [rsp+130h] [rbp+30h] BYREF
			// 
			//   if ( !byte_18D919448 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK16Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK32Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK4Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK8Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK16Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK1Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK2Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK4Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK8Component>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::ListExtensions::ToNativeArray<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassRenderer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassCluster>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassCluster>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassRenderer>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C920E00);
			//     byte_18D919448 = 1;
			//   }
			//   v56 = 0LL;
			//   v53 = 0LL;
			//   v54 = 0LL;
			//   v55 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2193, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2193, 0LL);
			//     if ( !Patch )
			//       goto LABEL_41;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     grassData = (Object_1 *)this.fields._grassData;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality(grassData, 0LL, 0LL) )
			//     {
			//       v6 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&source, 0LL);
			//       v7 = this.fields._grassData;
			//       v53 = v6;
			//       if ( v7 )
			//       {
			//         clusters = (uint64_t)v7.fields.clusters;
			//         if ( clusters )
			//         {
			//           v8 = *(_DWORD *)(clusters + 24);
			//           v57 = 0LL;
			//           Unity::Collections::NativeArray<MagicaCloth::RestoreDistanceConstraint::RestoreDistanceData>::NativeArray(
			//             &v57,
			//             v8,
			//             Allocator__Enum_Persistent,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray);
			//           v9 = 0;
			//           v10 = 0LL;
			//           this.fields.m_entities = (NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_)v57;
			//           while ( 1 )
			//           {
			//             v11 = this.fields._grassData;
			//             if ( !v11 )
			//               break;
			//             m_Buffer = (unsigned __int64)v11.fields.clusters;
			//             if ( !m_Buffer )
			//               break;
			//             if ( v9 >= *(_DWORD *)(m_Buffer + 24) )
			//               return;
			//             Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                      (List_1_System_Object_ *)m_Buffer,
			//                      v9,
			//                      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassCluster>::get_Item);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
			//               &v54,
			//               11,
			//               (AllocatorManager_AllocatorHandle)2,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
			//             value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
			//                                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>,
			//                                       v13);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &value,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>,
			//                                     v14);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>,
			//                                     v15);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>,
			//                                     v16);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>,
			//                                     v17);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>,
			//                                     v18);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>,
			//                                     v19);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v52.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>(
			//                                     (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>,
			//                                     v20);
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               &v54,
			//               &v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             v21 = (ComponentType)v54;
			//             v52 = (ComponentType)v54;
			//             if ( !Item )
			//               break;
			//             klass = Item[3].klass;
			//             if ( !klass )
			//               break;
			//             namespaze = (int)klass._0.namespaze;
			//             if ( namespaze <= 4 )
			//             {
			//               if ( namespaze > 1 )
			//                 v24 = namespaze > 2
			//                     ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK4Component>(
			//                         (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK4Component>,
			//                         (MethodInfo *)clusters)
			//                     : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK2Component>(
			//                         (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK2Component>,
			//                         (MethodInfo *)clusters);
			//               else
			//                 v24 = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK1Component>(
			//                         (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK1Component>,
			//                         (MethodInfo *)clusters);
			//             }
			//             else
			//             {
			//               v24 = namespaze > 8
			//                   ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK16Component>(
			//                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK16Component>,
			//                       (MethodInfo *)clusters)
			//                   : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK8Component>(
			//                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK8Component>,
			//                       (MethodInfo *)clusters);
			//             }
			//             value.value = (uint64_t)v24;
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v52,
			//               &value,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             monitor = Item[3].monitor;
			//             if ( !monitor )
			//               break;
			//             if ( *((int *)monitor + 6) <= 8 )
			//               v26 = *((int *)monitor + 6) > 4
			//                   ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK8Component>(
			//                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK8Component>,
			//                       (MethodInfo *)clusters)
			//                   : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK4Component>(
			//                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK4Component>,
			//                       (MethodInfo *)clusters);
			//             else
			//               v26 = *((int *)monitor + 6) > 16
			//                   ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK32Component>(
			//                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK32Component>,
			//                       (MethodInfo *)clusters)
			//                   : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK16Component>(
			//                       (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK16Component>,
			//                       (MethodInfo *)clusters);
			//             value.value = (uint64_t)v26;
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//               (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v52,
			//               &value,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//             value = v21;
			//             value = *(ComponentType *)sub_180314768(v65, &value);
			//             id = UnityEngine::HyperGryph::ECS::EntityManager::GetOrRegisterEntityType(
			//                    &v53,
			//                    (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&value,
			//                    0LL).id;
			//             Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose(
			//               (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v52,
			//               MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose);
			//             v28 = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&v53, (EntityType)id, 0LL);
			//             v59 = Item[1].klass;
			//             v52.value = v28;
			//             LODWORD(value.value) = (_DWORD)v59;
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               (BoundingCenterXComponent *)&value,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//             v60 = Item[1].klass;
			//             LODWORD(value.value) = HIDWORD(v60);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               (BoundingCenterYComponent *)&value,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//             value.value = (uint64_t)Item[1].klass;
			//             LODWORD(value.value) = Item[1].monitor;
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               (BoundingCenterZComponent *)&value,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//             v61 = *(__int64 *)((char *)&Item[1].monitor + 4);
			//             LODWORD(value.value) = v61;
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               (BoundingExtentXComponent *)&value,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//             v57.m_Buffer = *(Void **)((char *)&Item[1].monitor + 4);
			//             LODWORD(value.value) = HIDWORD(v57.m_Buffer);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               (BoundingExtentYComponent *)&value,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//             value.value = *(uint64_t *)((char *)&Item[1].monitor + 4);
			//             LODWORD(value.value) = HIDWORD(Item[2].klass);
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               (BoundingExtentZComponent *)&value,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//             memset(&t, 0, sizeof(t));
			//             v29 = *(float *)&Item[1].monitor;
			//             *(_QWORD *)&t.lodCenter.x = Item[1].klass;
			//             v30 = *(float *)&Item[2].monitor * *(float *)&Item[2].monitor;
			//             t.lodCenter.z = v29;
			//             t.enableDither = 1;
			//             t.lodObjectHalfSizeSquared = v30;
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               &t,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>);
			//             monitor_high = HIDWORD(Item[2].monitor);
			//             v32 = UnityEngine::LayerMask::NameToLayer((String *)"Default", 0LL);
			//             v62.sceneMask = -1LL;
			//             v62.artTag = 8;
			//             v62.sortingFudgeSqr = 256.0;
			//             v62.roLayerMask = 1 << (v32 & 0x1F);
			//             v62.objectFlags = monitor_high | 0x701;
			//             UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
			//               &v53,
			//               (Entity_1 *)&v52,
			//               &v62,
			//               MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//             v33 = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentMaskLow(&v53, (Entity_1 *)&v52, 0LL) & 0x7F00;
			//             ComponentPtrLowBits = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
			//                                     &v53,
			//                                     (Entity_1 *)&v52,
			//                                     v33,
			//                                     0LL);
			//             m_Buffer = (unsigned __int64)Item[3].klass;
			//             value.value = (uint64_t)&ComponentPtrLowBits[24 * (v33 >> 8) + 4];
			//             if ( !m_Buffer )
			//               break;
			//             m_Buffer = *(unsigned int *)(m_Buffer + 24);
			//             v35 = 0;
			//             *(_DWORD *)ComponentPtrLowBits = m_Buffer;
			//             while ( 1 )
			//             {
			//               v36 = Item[3].klass;
			//               if ( !v36 )
			//                 goto LABEL_41;
			//               if ( v35 >= SLODWORD(v36._0.namespaze) )
			//                 break;
			//               System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::get_Item(
			//                 &batchGroupKey,
			//                 (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)Item[3].klass,
			//                 v35,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassRenderer>::get_Item);
			//               v56 = 0LL;
			//               LOWORD(v55) = 0;
			//               v37 = *(_QWORD *)&batchGroupKey.instId;
			//               v38 = UnityEngine::HyperGryph::HGGrassRender::RegisterGrassBatchGroup(
			//                       batchGroupKey.instId,
			//                       *(Material **)&batchGroupKey.fightMp.value,
			//                       *(Mesh **)&batchGroupKey.idleMp.value,
			//                       (uint16_t)batchGroupKey.idleNode,
			//                       0LL);
			//               idleNode_high = HIDWORD(batchGroupKey.idleNode);
			//               WORD1(v55) = v38;
			//               DWORD1(v55) = v37;
			//               m_Buffer = 24LL;
			//               v40 = v35;
			//               if ( *((float *)&batchGroupKey.idleNode + 1) <= 0.0 )
			//                 idleNode_high = 1065353216;
			//               v41 = (_QWORD *)value.value;
			//               ++v35;
			//               fightNode_high = (__m128)HIDWORD(batchGroupKey.fightNode);
			//               v43 = v56;
			//               *((_QWORD *)&v55 + 1) = __PAIR64__(HIDWORD(v37), idleNode_high);
			//               v44 = 24LL * v40;
			//               *(_OWORD *)&ComponentPtrLowBits[v44 + 4] = v55;
			//               v45 = _mm_unpacklo_ps((__m128)LODWORD(batchGroupKey.fightNode), fightNode_high).m128_u64[0];
			//               *(_QWORD *)&ComponentPtrLowBits[v44 + 20] = v43;
			//               *v41 = v45;
			//               clusters = (uint64_t)(v41 + 1);
			//               value.value = clusters;
			//             }
			//             ComponentMaskLow = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentMaskLow(
			//                                  &v53,
			//                                  (Entity_1 *)&v52,
			//                                  0LL);
			//             v47 = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
			//                     &v53,
			//                     (Entity_1 *)&v52,
			//                     ComponentMaskLow & 0x1E000000000LL,
			//                     0LL);
			//             m_Buffer = (unsigned __int64)Item[3].monitor;
			//             if ( !m_Buffer )
			//               break;
			//             v48 = 96 * *(_DWORD *)(m_Buffer + 24);
			//             Unity::Collections::ListExtensions::ToNativeArray<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>(
			//               (NativeArray_1_UnityEngine_HyperGryph_ECS_GrassPerInstanceData_ *)&source,
			//               (List_1_UnityEngine_HyperGryph_ECS_GrassPerInstanceData_ *)Item[3].monitor,
			//               (AllocatorManager_AllocatorHandle)2,
			//               MethodInfo::Unity::Collections::ListExtensions::ToNativeArray<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>);
			//             System::Buffer::MemoryCopy((Void *)source.m_entitiesPPtr, (Void *)v47 + 4, v48, v48, 0LL);
			//             v49 = Item[3].monitor;
			//             if ( !v49 )
			//               break;
			//             ++v9;
			//             *(_DWORD *)v47 = *((_DWORD *)v49 + 6);
			//             m_Buffer = (unsigned __int64)this.fields.m_entities.m_Buffer;
			//             *(_QWORD *)(v10 + m_Buffer) = v52.value;
			//             v10 += 8LL;
			//           }
			//         }
			//       }
			// LABEL_41:
			//       sub_180B536AC(m_Buffer, clusters);
			//     }
			//   }
			// }
			// 
		}

		private void _DestroyGrassEntities()
		{
			// // Void _DestroyGrassEntities()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(HGGrass *this, MethodInfo *method)
			// {
			//   HGGrass *v2; // rbx
			//   uint8_t *ComponentPtrLowBits; // r14
			//   int v4; // esi
			//   int i; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Il2CppExceptionWrapper *v9; // [rsp+20h] [rbp-88h] BYREF
			//   EntityManager_1 _unity_self; // [rsp+28h] [rbp-80h] BYREF
			//   EntityManager_1 v11; // [rsp+38h] [rbp-70h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v12; // [rsp+48h] [rbp-60h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v13[2]; // [rsp+68h] [rbp-40h] BYREF
			//   Entity_1 entity; // [rsp+C0h] [rbp+18h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919449 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::ECS::Entity>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::ECS::Entity>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::ECS::Entity>::get_Current);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::get_IsCreated);
			//     byte_18D919449 = 1;
			//   }
			//   _unity_self = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2188, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2188, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else if ( v2.fields.m_entities.m_Buffer )
			//   {
			//     _unity_self = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v11, 0LL);
			//     Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
			//       &v12,
			//       (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v2.fields.m_entities,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetEnumerator);
			//     v13[0] = v12;
			//     v11.m_entitiesPPtr = 0LL;
			//     v11.m_entityTypesPPtr = v13;
			//     try
			//     {
			//       while ( (unsigned __int8)sub_183182300(
			//                                  v13,
			//                                  MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::ECS::Entity>::MoveNext) )
			//       {
			//         entity = (Entity_1)v13[0].value;
			//         ComponentPtrLowBits = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
			//                                 &_unity_self,
			//                                 &entity,
			//                                 *(_QWORD *)(576LL
			//                                           * *(unsigned int *)(*(_QWORD *)_unity_self.m_entitiesPPtr
			//                                                             + 16LL * LODWORD(v13[0].value.startTime))
			//                                           + *(_QWORD *)_unity_self.m_entityTypesPPtr
			//                                           + 16) & 0x7F00LL,
			//                                 0LL);
			//         v4 = *(_DWORD *)ComponentPtrLowBits;
			//         for ( i = 0; i < v4; ++i )
			//           UnityEngine::HyperGryph::HGGrassRender::UnregisterGrassBatchGroupWithHandle(
			//             HIDWORD(*(_QWORD *)&ComponentPtrLowBits[24 * i + 4]),
			//             WORD1(*(_QWORD *)&ComponentPtrLowBits[24 * i + 4]),
			//             0LL);
			//         UnityEngine::HyperGryph::ECS::EntityManager::DestroyEntity_Injected(&_unity_self, &entity, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v9 )
			//     {
			//       v11.m_entitiesPPtr = v9.ex;
			//       if ( v11.m_entitiesPPtr )
			//         sub_18000F780(v11.m_entitiesPPtr);
			//       v2 = this;
			//     }
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v2.fields.m_entities,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose);
			//   }
			// }
			// 
		}

		private static int _GetGrassDataInstanceID(HGGrassData grassData)
		{
			// // Int32 _GetGrassDataInstanceID(HGGrassData)
			// int32_t HG::Rendering::Runtime::HGGrass::_GetGrassDataInstanceID(HGGrassData *grassData, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91944A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91944A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2191, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2191, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//              (ILFixDynamicMethodWrapper_29 *)Patch,
			//              (Object *)grassData,
			//              0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)grassData, 0LL, 0LL) )
			//     {
			//       if ( grassData )
			//         return UnityEngine::Object::GetInstanceID((Object_1 *)grassData, 0LL);
			// LABEL_9:
			//       sub_180B536AC(v4, v3);
			//     }
			//     return 0;
			//   }
			// }
			// 
			return 0;
		}

		private static int _GetGrassDataVersion(HGGrassData grassData)
		{
			// // Int32 _GetGrassDataVersion(HGGrassData)
			// int32_t HG::Rendering::Runtime::HGGrass::_GetGrassDataVersion(HGGrassData *grassData, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91944B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91944B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2192, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2192, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//              (ILFixDynamicMethodWrapper_29 *)Patch,
			//              (Object *)grassData,
			//              0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)grassData, 0LL, 0LL) )
			//     {
			//       if ( grassData )
			//         return grassData.fields.version;
			// LABEL_9:
			//       sub_180B536AC(v4, v3);
			//     }
			//     return -1;
			//   }
			// }
			// 
			return 0;
		}

		[SerializeField]
		private HGGrassData _grassData;

		private int m_previousGrassDataInstanceID;

		private int m_previousGrassDataVersion;

		private NativeArray<Entity> m_entities;
	}
}
