using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGSludgeUtils
	{
		[IDTag(1)]
		public static bool CreateEntity(Transform transform, Vector3 localOrigin, uint sludgeSize, float thickness, float sizeY, float rebornTime, float rebornAnimTime, float disappearTime, Bounds boundsW, Vector3 disappearCenter, Vector3 waveCenter, ref HGSludgeAlignedPlane clipPlane0, ref HGSludgeAlignedPlane clipPlane1, Material sludgeMaterial, Texture2D heightmap, NativeArray<SludgeNodeData> nodeData, out Entity entity)
		{
			// // Boolean CreateEntity(Transform, Vector3, UInt32, Single, Single, Single, Single, Single, Bounds, Vector3, Vector3, HGSludgeAlignedPlane ByRef, HGSludgeAlignedPlane ByRef, Material, Texture2D, NativeArray`1[UnityEngine.HyperGryph.SludgeNodeData], Entity ByRef)
			// bool HG::Rendering::Runtime::HGSludgeUtils::CreateEntity(
			//         Transform *transform,
			//         Vector3 *localOrigin,
			//         uint32_t sludgeSize,
			//         float thickness,
			//         float sizeY,
			//         float rebornTime,
			//         float rebornAnimTime,
			//         float disappearTime,
			//         Bounds *boundsW,
			//         Vector3 *disappearCenter,
			//         Vector3 *waveCenter,
			//         HGSludgeAlignedPlane *clipPlane0,
			//         HGSludgeAlignedPlane *clipPlane1,
			//         Material *sludgeMaterial,
			//         Texture2D *heightmap,
			//         NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ *nodeData,
			//         Entity_1 *entity,
			//         MethodInfo *method)
			// {
			//   __int64 v21; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 *v24; // rax
			//   __int64 v25; // xmm9_8
			//   float v26; // r12d
			//   Vector3 *up; // rax
			//   __int64 v28; // xmm8_8
			//   float v29; // r15d
			//   Vector3 *right; // rax
			//   __int64 v31; // xmm7_8
			//   float v32; // r14d
			//   Vector3 *forward; // rax
			//   __int64 v34; // xmm6_8
			//   float v35; // edi
			//   float v36; // eax
			//   uint32_t v37; // eax
			//   __int64 v38; // xmm0_8
			//   uint32_t v39; // esi
			//   uint32_t v40; // ebx
			//   NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ v41; // xmm0
			//   __int64 v42; // xmm1_8
			//   float v43; // ecx
			//   __int64 v45; // xmm1_8
			//   __int64 v46; // xmm0_8
			//   __int128 v47; // xmm0
			//   __int64 v48; // xmm1_8
			//   Vector3 v49; // [rsp+A0h] [rbp-80h] BYREF
			//   Vector3 v50; // [rsp+B0h] [rbp-70h] BYREF
			//   Vector3 v51; // [rsp+C0h] [rbp-60h] BYREF
			//   Vector3 v52; // [rsp+D0h] [rbp-50h] BYREF
			//   Vector3 v53; // [rsp+E0h] [rbp-40h] BYREF
			//   Vector3 v54; // [rsp+F0h] [rbp-30h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ v55; // [rsp+100h] [rbp-20h] BYREF
			//   Bounds v56[4]; // [rsp+110h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919DC1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//     byte_18D919DC1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1382, 0LL) )
			//   {
			//     if ( transform )
			//     {
			//       z = localOrigin.z;
			//       *(_QWORD *)&v49.x = *(_QWORD *)&localOrigin.x;
			//       v49.z = z;
			//       v24 = UnityEngine::Transform::TransformPoint(&v50, transform, &v49, 0LL);
			//       v25 = *(_QWORD *)&v24.x;
			//       v26 = v24.z;
			//       up = UnityEngine::Transform::get_up(&v50, transform, 0LL);
			//       v28 = *(_QWORD *)&up.x;
			//       v29 = up.z;
			//       right = UnityEngine::Transform::get_right(&v50, transform, 0LL);
			//       v31 = *(_QWORD *)&right.x;
			//       v32 = right.z;
			//       forward = UnityEngine::Transform::get_forward(&v50, transform, 0LL);
			//       v34 = *(_QWORD *)&forward.x;
			//       v35 = forward.z;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane);
			//       v36 = localOrigin.z;
			//       *(_QWORD *)&v49.x = *(_QWORD *)&localOrigin.x;
			//       v49.z = v36;
			//       v37 = HG::Rendering::Runtime::HGSludgeAlignedPlane::EncodeToUInt(clipPlane0, &v49, 0LL);
			//       v38 = *(_QWORD *)&localOrigin.x;
			//       v49.z = localOrigin.z;
			//       v39 = v37;
			//       *(_QWORD *)&v49.x = v38;
			//       v40 = HG::Rendering::Runtime::HGSludgeAlignedPlane::EncodeToUInt(clipPlane1, &v49, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//       *(_QWORD *)&v54.x = v31;
			//       v54.z = v32;
			//       v41 = *nodeData;
			//       *(_QWORD *)&v51.x = v34;
			//       v55 = v41;
			//       v51.z = v35;
			//       v42 = *(_QWORD *)&waveCenter.x;
			//       v49.z = waveCenter.z;
			//       *(_QWORD *)&v49.x = v42;
			//       *(_QWORD *)&v56[0].m_Extents.y = *(_QWORD *)&boundsW.m_Extents.y;
			//       v43 = disappearCenter.z;
			//       *(_QWORD *)&v53.x = *(_QWORD *)&disappearCenter.x;
			//       *(_OWORD *)&v56[0].m_Center.x = *(_OWORD *)&boundsW.m_Center.x;
			//       v53.z = v43;
			//       *(_QWORD *)&v52.x = v28;
			//       v52.z = v29;
			//       *(_QWORD *)&v50.x = v25;
			//       v50.z = v26;
			//       return HG::Rendering::Runtime::HGSludgeUtils::CreateEntity(
			//                &v50,
			//                &v52,
			//                &v51,
			//                &v54,
			//                sludgeSize,
			//                thickness,
			//                sizeY,
			//                rebornTime,
			//                rebornAnimTime,
			//                disappearTime,
			//                v56,
			//                &v53,
			//                &v49,
			//                v39,
			//                v40,
			//                sludgeMaterial,
			//                heightmap,
			//                &v55,
			//                entity,
			//                0LL);
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v21);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1382, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v55 = *nodeData;
			//   v45 = *(_QWORD *)&waveCenter.x;
			//   v50.z = waveCenter.z;
			//   *(_QWORD *)&v50.x = v45;
			//   v46 = *(_QWORD *)&disappearCenter.x;
			//   v52.z = disappearCenter.z;
			//   *(_QWORD *)&v52.x = v46;
			//   v47 = *(_OWORD *)&boundsW.m_Center.x;
			//   v48 = *(_QWORD *)&boundsW.m_Extents.y;
			//   v51.z = localOrigin.z;
			//   *(_OWORD *)&v56[0].m_Center.x = v47;
			//   *(_QWORD *)&v51.x = *(_QWORD *)&localOrigin.x;
			//   *(_QWORD *)&v56[0].m_Extents.y = v48;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_527(
			//            Patch,
			//            (Object *)transform,
			//            &v51,
			//            sludgeSize,
			//            thickness,
			//            sizeY,
			//            rebornTime,
			//            rebornAnimTime,
			//            disappearTime,
			//            v56,
			//            &v52,
			//            &v50,
			//            clipPlane0,
			//            clipPlane1,
			//            (Object *)sludgeMaterial,
			//            (Object *)heightmap,
			//            &v55,
			//            entity,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(0)]
		public static bool CreateEntity(Vector3 originW, Vector3 up, Vector3 forward, Vector3 right, uint sludgeSize, float thickness, float sizeY, float rebornTime, float rebornAnimTime, float disappearTime, Bounds boundsW, Vector3 disappearCenter, Vector3 waveCenter, uint encodedClipPlane0, uint encodedClipPlane1, Material sludgeMaterial, Texture2D heightmap, NativeArray<SludgeNodeData> nodeData, out Entity entity)
		{
			// // Boolean CreateEntity(Vector3, Vector3, Vector3, Vector3, UInt32, Single, Single, Single, Single, Single, Bounds, Vector3, Vector3, UInt32, UInt32, Material, Texture2D, NativeArray`1[UnityEngine.HyperGryph.SludgeNodeData], Entity ByRef)
			// bool HG::Rendering::Runtime::HGSludgeUtils::CreateEntity(
			//         Vector3 *originW,
			//         Vector3 *up,
			//         Vector3 *forward,
			//         Vector3 *right,
			//         uint32_t sludgeSize,
			//         float thickness,
			//         float sizeY,
			//         float rebornTime,
			//         float rebornAnimTime,
			//         float disappearTime,
			//         Bounds *boundsW,
			//         Vector3 *disappearCenter,
			//         Vector3 *waveCenter,
			//         uint32_t encodedClipPlane0,
			//         uint32_t encodedClipPlane1,
			//         Material *sludgeMaterial,
			//         Texture2D *heightmap,
			//         NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ *nodeData,
			//         Entity_1 *entity,
			//         MethodInfo *method)
			// {
			//   __int64 v24; // rdx
			//   void (__fastcall *v25)(EntityManager_1 *); // rax
			//   MethodInfo *v26; // rdx
			//   MethodInfo *v27; // rdx
			//   MethodInfo *v28; // rdx
			//   MethodInfo *v29; // rdx
			//   MethodInfo *v30; // rdx
			//   MethodInfo *v31; // rdx
			//   MethodInfo *v32; // rdx
			//   MethodInfo *v33; // rdx
			//   UnsafeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *m_ListData; // xmm6_8
			//   void (__fastcall *v35)(EntityManager_1 *, _QWORD, UnsafeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *, AllocatorManager_AllocatorHandle *); // rax
			//   __int64 v36; // rax
			//   __m128i v37; // xmm1
			//   __m128 v38; // xmm6
			//   MethodInfo *v39; // r9
			//   Vector3 *v40; // rax
			//   MethodInfo *v41; // r9
			//   Vector3 *v42; // rax
			//   uint64_t v43; // xmm3_8
			//   struct MethodInfo *v44; // r14
			//   EntityInstanceData *v45; // rcx
			//   struct MethodInfo *v46; // r14
			//   EntityInstanceData *v47; // rcx
			//   struct MethodInfo *v48; // r14
			//   EntityInstanceData *v49; // rcx
			//   struct MethodInfo *v50; // r14
			//   EntityInstanceData *v51; // rcx
			//   struct MethodInfo *v52; // r14
			//   EntityInstanceData *v53; // rcx
			//   struct MethodInfo *v54; // r14
			//   EntityInstanceData *v55; // rcx
			//   char v56; // al
			//   struct MethodInfo *v57; // r14
			//   bool v58; // zf
			//   EntityInstanceData *v59; // rcx
			//   __int64 v60; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int32_t InstanceID; // eax
			//   __int64 v63; // rdx
			//   float y; // xmm2_4
			//   float x; // xmm1_4
			//   float z; // xmm0_4
			//   float v67; // xmm2_4
			//   float v68; // xmm1_4
			//   float v69; // xmm2_4
			//   float v70; // xmm6_4
			//   float v71; // xmm7_4
			//   float v72; // xmm8_4
			//   float v73; // xmm1_4
			//   float v74; // xmm2_4
			//   struct MethodInfo *v75; // rdi
			//   float v76; // xmm1_4
			//   float v77; // xmm2_4
			//   EntityInstanceData *v78; // rcx
			//   Entity_1 v79; // rcx
			//   bool result; // al
			//   __int64 v81; // rax
			//   __int64 v82; // rax
			//   char *v83; // rcx
			//   uint64_t v84; // xmm1_8
			//   __int64 v85; // xmm0_8
			//   __int128 v86; // xmm0
			//   __int64 v87; // xmm1_8
			//   AllocatorManager_AllocatorHandle allocator; // [rsp+B0h] [rbp-80h] BYREF
			//   ComponentType value; // [rsp+C0h] [rbp-70h] BYREF
			//   NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v90; // [rsp+D0h] [rbp-60h] BYREF
			//   EntityManager_1 _unity_self; // [rsp+E0h] [rbp-50h] BYREF
			//   EntityManager_1 v92; // [rsp+F0h] [rbp-40h] BYREF
			//   RenderObjectInfoComponent t; // [rsp+100h] [rbp-30h] BYREF
			//   HGSludgeComponent v94; // [rsp+120h] [rbp-10h] BYREF
			//   Vector3 v95; // [rsp+190h] [rbp+60h] BYREF
			//   Vector3 v96; // [rsp+1A0h] [rbp+70h] BYREF
			//   Vector3 v97; // [rsp+1B0h] [rbp+80h] BYREF
			//   Bounds v98; // [rsp+1C0h] [rbp+90h] BYREF
			// 
			//   if ( !byte_18D8EDCA3 )
			//   {
			//     sub_18003C530(&TypeInfo::System::BitConverter);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGSludgeComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGSludgeComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C920E00);
			//     sub_18003C530(&off_18C9B5B88);
			//     sub_18003C530(&off_18C9B5B80);
			//     sub_18003C530(&off_18C9B5B78);
			//     byte_18D8EDCA3 = 1;
			//   }
			//   v90 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1383, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1383, 0LL);
			//     if ( Patch )
			//     {
			//       *(NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ *)&t.roLayerMask = *nodeData;
			//       v84 = *(_QWORD *)&waveCenter.x;
			//       *(float *)&value.componentID = waveCenter.z;
			//       value.value = v84;
			//       v85 = *(_QWORD *)&disappearCenter.x;
			//       v95.z = disappearCenter.z;
			//       *(_QWORD *)&v95.x = v85;
			//       v86 = *(_OWORD *)&boundsW.m_Center.x;
			//       v87 = *(_QWORD *)&boundsW.m_Extents.y;
			//       v96.z = right.z;
			//       v97.z = forward.z;
			//       *(float *)&v92.m_entityTypesPPtr = up.z;
			//       v90.m_DeprecatedAllocator = (AllocatorManager_AllocatorHandle)LODWORD(originW.z);
			//       *(_OWORD *)&v98.m_Center.x = v86;
			//       *(_QWORD *)&v96.x = *(_QWORD *)&right.x;
			//       *(_QWORD *)&v97.x = *(_QWORD *)&forward.x;
			//       v92.m_entitiesPPtr = *(void **)&up.x;
			//       v90.m_ListData = *(UnsafeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ **)&originW.x;
			//       *(_QWORD *)&v98.m_Extents.y = v87;
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_526(
			//                Patch,
			//                (Vector3 *)&v90,
			//                (Vector3 *)&v92,
			//                &v97,
			//                &v96,
			//                sludgeSize,
			//                thickness,
			//                sizeY,
			//                rebornTime,
			//                rebornAnimTime,
			//                disappearTime,
			//                &v98,
			//                &v95,
			//                (Vector3 *)&value,
			//                encodedClipPlane0,
			//                encodedClipPlane1,
			//                (Object *)sludgeMaterial,
			//                (Object *)heightmap,
			//                (NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ *)&t,
			//                entity,
			//                0LL);
			//     }
			// LABEL_37:
			//     sub_180B536AC(Patch, v60);
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v24);
			//   if ( UnityEngine::Object::op_Equality((Object_1 *)sludgeMaterial, 0LL, 0LL) )
			//   {
			//     v83 = "Null sludge material";
			//     goto LABEL_43;
			//   }
			//   if ( !nodeData.m_Length )
			//   {
			//     v83 = "Empty sludge node";
			// LABEL_43:
			//     HG::Rendering::HGRPLogger::LogError((String *)v83, 0LL);
			//     *entity = 0LL;
			//     return 0;
			//   }
			//   v25 = (void (__fastcall *)(EntityManager_1 *))qword_18D8F5E78;
			//   v92 = 0LL;
			//   if ( !qword_18D8F5E78 )
			//   {
			//     v25 = (void (__fastcall *)(EntityManager_1 *))il2cpp_resolve_icall_0(
			//                                                     "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_I"
			//                                                     "njected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//     if ( !v25 )
			//     {
			//       v81 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
			//       sub_18000F750(v81, 0LL);
			//     }
			//     qword_18D8F5E78 = (__int64)v25;
			//   }
			//   v25(&v92);
			//   allocator = (AllocatorManager_AllocatorHandle)2;
			//   _unity_self = v92;
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
			//     &v90,
			//     8,
			//     (AllocatorManager_AllocatorHandle)2,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>,
			//                             v26);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>,
			//                             v27);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>,
			//                             v28);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>,
			//                             v29);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>,
			//                             v30);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>,
			//                             v31);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>,
			//                             v32);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGSludgeComponent>(
			//                             (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGSludgeComponent>,
			//                             v33);
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
			//     &v90,
			//     &value,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
			//   m_ListData = v90.m_ListData;
			//   v92 = (EntityManager_1)v90;
			//   Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit(
			//     (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v90,
			//     (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v92,
			//     MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
			//   if ( !byte_18D8F5E64 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::HyperGryph::ECS::ComponentType>);
			//     byte_18D8F5E64 = 1;
			//   }
			//   v35 = (void (__fastcall *)(EntityManager_1 *, _QWORD, UnsafeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *, AllocatorManager_AllocatorHandle *))qword_18D8F5EA0;
			//   allocator = 0;
			//   if ( !qword_18D8F5EA0 )
			//   {
			//     v35 = (void (__fastcall *)(EntityManager_1 *, _QWORD, UnsafeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *, AllocatorManager_AllocatorHandle *))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.ECS.EntityManager::GetOrRegisterEntityTypeImpl_Injected(UnityEngine.HyperGryph.ECS.EntityManager&,System.Int32,System.IntPtr,UnityEngine.HyperGryph.ECS.EntityType&)");
			//     if ( !v35 )
			//     {
			//       v82 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.ECS.EntityManager::GetOrRegisterEntityTypeImpl_Injected(UnityEngine.HyperGryph.ECS."
			//               "EntityManager&,System.Int32,System.IntPtr,UnityEngine.HyperGryph.ECS.EntityType&)");
			//       sub_18000F750(v82, 0LL);
			//     }
			//     qword_18D8F5EA0 = (__int64)v35;
			//   }
			//   v35(&_unity_self, *(_DWORD *)&v90.m_DeprecatedAllocator, v90.m_ListData, &allocator);
			//   v36 = sub_18010B520(MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose.klass);
			//   Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::HyperGryph::ECS::ComponentType>::Destroy(
			//     m_ListData,
			//     *(MethodInfo **)(*(_QWORD *)(v36 + 192) + 176LL));
			//   *entity = UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&_unity_self, (EntityType)allocator, 0LL);
			//   v37 = *(__m128i *)&nodeData.m_Buffer[16];
			//   v38 = *(__m128 *)nodeData.m_Buffer;
			//   value.value = *(_QWORD *)&nodeData.m_Buffer[16];
			//   *(_DWORD *)&value.componentID = _mm_cvtsi128_si32(_mm_srli_si128(v37, 8));
			//   v40 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v90, 2.0, (Vector3 *)&value, v39);
			//   v37.m128i_i64[0] = *(_QWORD *)&v40.x;
			//   *(float *)&v40 = v40.z;
			//   value.value = v37.m128i_i64[0];
			//   *(_DWORD *)&value.componentID = (_DWORD)v40;
			//   v42 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v90, (Vector3 *)&value, 0.5, v41);
			//   v43 = *(_QWORD *)&v42.x;
			//   *(float *)&v42 = v42.z;
			//   *(uint64_t *)((char *)&t.sceneMask + 4) = v43;
			//   LODWORD(value.value) = (_DWORD)v42;
			//   v44 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>;
			//   allocator = (AllocatorManager_AllocatorHandle)_mm_shuffle_ps(v38, v38, 85).m128_u32[0];
			//   if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>.rgctx_data )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
			//   v45 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
			//     v45,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v45.entityType),
			//     (BoundingCenterXComponent *)&allocator,
			//     (MethodInfo *)v44.rgctx_data.rgctxDataDummy);
			//   v46 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>;
			//   allocator = (AllocatorManager_AllocatorHandle)_mm_shuffle_ps(v38, v38, 170).m128_u32[0];
			//   if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>.rgctx_data )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
			//   v47 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
			//     v47,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v47.entityType),
			//     (BoundingCenterYComponent *)&allocator,
			//     (MethodInfo *)v46.rgctx_data.rgctxDataDummy);
			//   v48 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>;
			//   allocator = (AllocatorManager_AllocatorHandle)_mm_shuffle_ps(v38, v38, 255).m128_u32[0];
			//   if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>.rgctx_data )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
			//   v49 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
			//     v49,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v49.entityType),
			//     (BoundingCenterZComponent *)&allocator,
			//     (MethodInfo *)v48.rgctx_data.rgctxDataDummy);
			//   v50 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>;
			//   allocator = (AllocatorManager_AllocatorHandle)HIDWORD(t.sceneMask);
			//   if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>.rgctx_data )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
			//   v51 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
			//     v51,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v51.entityType),
			//     (BoundingExtentXComponent *)&allocator,
			//     (MethodInfo *)v50.rgctx_data.rgctxDataDummy);
			//   v52 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>;
			//   allocator = (AllocatorManager_AllocatorHandle)t.artTag;
			//   if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>.rgctx_data )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
			//   v53 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
			//     v53,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v53.entityType),
			//     (BoundingExtentYComponent *)&allocator,
			//     (MethodInfo *)v52.rgctx_data.rgctxDataDummy);
			//   v54 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>;
			//   if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>.rgctx_data )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
			//   v55 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
			//     v55,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v55.entityType),
			//     (BoundingExtentZComponent *)&value,
			//     (MethodInfo *)v54.rgctx_data.rgctxDataDummy);
			//   v56 = UnityEngine::LayerMask::NameToLayer((String *)"Default", 0LL);
			//   v57 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>;
			//   t.objectFlags = 1793;
			//   t.sceneMask = -1LL;
			//   v58 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>.rgctx_data == 0LL;
			//   t.roLayerMask = 1 << (v56 & 0x1F);
			//   t.artTag = 0;
			//   t.sortingFudgeSqr = 256.0;
			//   if ( v58 )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
			//   v59 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
			//     v59,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v59.entityType),
			//     &t,
			//     (MethodInfo *)v57.rgctx_data.rgctxDataDummy);
			//   if ( !sludgeMaterial )
			//     goto LABEL_37;
			//   InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)sludgeMaterial, 0LL);
			//   v94.materialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(InstanceID, 0LL);
			//   v94.sludgeSize = sludgeSize;
			//   y = right.y;
			//   v94.right.x = right.x;
			//   x = forward.x;
			//   v94.disappearTime = fmaxf(disappearTime, 0.0099999998);
			//   v58 = TypeInfo::System::BitConverter._1.cctor_finished_or_no_cctor == 0;
			//   v94.right.z = right.z;
			//   v94.right.w = rebornTime;
			//   v94.forward.z = forward.z;
			//   v94.forward.w = rebornAnimTime;
			//   z = originW.z;
			//   v94.right.y = y;
			//   v67 = forward.y;
			//   v94.position.z = z;
			//   v94.forward.x = x;
			//   v68 = originW.x;
			//   v94.forward.y = v67;
			//   v69 = originW.y;
			//   v94.position.w = thickness;
			//   v94.up.z = up.z;
			//   v70 = disappearCenter.x;
			//   v71 = disappearCenter.y;
			//   v72 = disappearCenter.z;
			//   v94.position.x = v68;
			//   v73 = up.x;
			//   v94.position.y = v69;
			//   v74 = up.y;
			//   v94.up.w = sizeY;
			//   v94.up.x = v73;
			//   v94.up.y = v74;
			//   v94.ditherAlpha = 1.0;
			//   if ( v58 )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::BitConverter, v63);
			//   v75 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGSludgeComponent>;
			//   LODWORD(v94.customPerDraw0.w) = encodedClipPlane0;
			//   v76 = waveCenter.y;
			//   v58 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGSludgeComponent>.rgctx_data == 0LL;
			//   v77 = waveCenter.z;
			//   v94.customPerDraw1.x = waveCenter.x;
			//   v94.customPerDraw0.y = v71;
			//   v94.customPerDraw0.z = v72;
			//   LODWORD(v94.customPerDraw1.w) = encodedClipPlane1;
			//   v94.customPerDraw0.x = v70;
			//   v94.customPerDraw1.y = v76;
			//   v94.customPerDraw1.z = v77;
			//   if ( v58 )
			//     sub_180041F40(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGSludgeComponent>);
			//   v78 = (EntityInstanceData *)(*(_QWORD *)_unity_self.m_entitiesPPtr + 16LL * entity.globalIndex);
			//   UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::HGSludgeComponent>(
			//     v78,
			//     (EntityTypeInstanceData *)(*(_QWORD *)_unity_self.m_entityTypesPPtr + 576LL * v78.entityType),
			//     &v94,
			//     (MethodInfo *)v75.rgctx_data.rgctxDataDummy);
			//   v79 = *entity;
			//   v90 = (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_)*nodeData;
			//   if ( UnityEngine::HyperGryph::HGSludgeRender::RegisterSludge(
			//          v79,
			//          heightmap,
			//          (NativeArray_1_UnityEngine_HyperGryph_SludgeNodeData_ *)&v90,
			//          0LL) )
			//   {
			//     return 1;
			//   }
			//   HG::Rendering::HGRPLogger::LogError((String *)"Sludge register failed", 0LL);
			//   value.value = (uint64_t)*entity;
			//   UnityEngine::HyperGryph::ECS::EntityManager::DestroyEntity_Injected(&_unity_self, (Entity_1 *)&value, 0LL);
			//   result = 0;
			//   *entity = 0LL;
			//   return result;
			// }
			// 
			return default(bool);
		}

		public static void SetDitherAlpha(Entity entity, float ditherAlpha)
		{
			// // Void SetDitherAlpha(Entity, Single)
			// void HG::Rendering::Runtime::HGSludgeUtils::SetDitherAlpha(Entity_1 entity, float ditherAlpha, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   EntityManager_1 v7; // [rsp+20h] [rbp-28h] BYREF
			//   Entity_1 entitya; // [rsp+50h] [rbp+8h] BYREF
			//   HGSludgeComponent *componentPtr; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   entitya = entity;
			//   if ( !byte_18D919DC2 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::TryGetComponentPtr<UnityEngine::HyperGryph::ECS::HGSludgeComponent>);
			//     sub_18003C530(&off_18D5E78E8);
			//     byte_18D919DC2 = 1;
			//   }
			//   componentPtr = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1384, 0LL) )
			//   {
			//     v7 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v7, 0LL);
			//     if ( !UnityEngine::HyperGryph::ECS::EntityManager::TryGetComponentPtr<UnityEngine::HyperGryph::ECS::HGSludgeComponent>(
			//             &v7,
			//             &entitya,
			//             &componentPtr,
			//             MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::TryGetComponentPtr<UnityEngine::HyperGryph::ECS::HGSludgeComponent>) )
			//     {
			//       HG::Rendering::HGRPLogger::LogError((String *)"Invalid sludge entity", 0LL);
			//       return;
			//     }
			//     if ( componentPtr )
			//     {
			//       componentPtr.ditherAlpha = ditherAlpha;
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1384, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_528(Patch, entity, ditherAlpha, 0LL);
			// }
			// 
		}

		public static bool Raycast(Vector3 rayStartLocal, float maxDistance, float searchRange, Transform transform, int layerMask, HashSet<GameObject> needCheckGo, HashSet<GameObject> ignoreCheckGo, out float localMaxHeight, out float localMinHeight)
		{
			// // Boolean Raycast(Vector3, Single, Single, Transform, Int32, HashSet`1[UnityEngine.GameObject], HashSet`1[UnityEngine.GameObject], Single ByRef, Single ByRef)
			// // Hidden C++ exception states: #wind=2 #try_helpers=2
			// bool HG::Rendering::Runtime::HGSludgeUtils::Raycast(
			//         Vector3 *rayStartLocal,
			//         float maxDistance,
			//         float searchRange,
			//         Transform *transform,
			//         int32_t layerMask,
			//         HashSet_1_UnityEngine_GameObject_ *needCheckGo,
			//         HashSet_1_UnityEngine_GameObject_ *ignoreCheckGo,
			//         float *localMaxHeight,
			//         float *localMinHeight,
			//         MethodInfo *method)
			// {
			//   bool v12; // bl
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   MethodInfo *v15; // r8
			//   float y; // xmm6_4
			//   float v17; // xmm9_4
			//   HGSludgeUtils__StaticFields *static_fields; // rcx
			//   __int64 v19; // rdx
			//   HGSludgeUtils__StaticFields *v20; // rcx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   __m128i v23; // xmm7
			//   Object *current; // r15
			//   Component *v25; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   GameObject *gameObject; // r14
			//   int v29; // r14d
			//   Vector3 *v30; // rax
			//   HashSet_1_UnityEngine_GameObject_ *v31; // rdx
			//   Object *v32; // r12
			//   Component *v33; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   GameObject *v36; // r15
			//   Component *collider; // rax
			//   GameObject *v38; // rax
			//   unsigned int v39; // ecx
			//   Vector3 *v41; // rax
			//   float v42; // xmm0_4
			//   float v43; // xmm1_4
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // r14
			//   int k; // [rsp+68h] [rbp-240h]
			//   int j; // [rsp+6Ch] [rbp-23Ch]
			//   int i; // [rsp+70h] [rbp-238h]
			//   float v51; // [rsp+74h] [rbp-234h]
			//   Vector3 v52; // [rsp+80h] [rbp-228h] BYREF
			//   Vector3 v53; // [rsp+90h] [rbp-218h] BYREF
			//   int32_t v54; // [rsp+A0h] [rbp-208h]
			//   HashSet_1_T_Enumerator_System_Object_ v55; // [rsp+A8h] [rbp-200h] BYREF
			//   HashSet_1_T_Enumerator_System_Object_ v56; // [rsp+C0h] [rbp-1E8h] BYREF
			//   Vector3 v57; // [rsp+E0h] [rbp-1C8h] BYREF
			//   Vector3 v58; // [rsp+F0h] [rbp-1B8h] BYREF
			//   Vector3 v59; // [rsp+100h] [rbp-1A8h] BYREF
			//   Vector3 v60; // [rsp+110h] [rbp-198h] BYREF
			//   __int64 v61; // [rsp+120h] [rbp-188h]
			//   HashSet_1_T_Enumerator_System_Object_ *v62; // [rsp+128h] [rbp-180h]
			//   __int64 v63; // [rsp+130h] [rbp-178h]
			//   HashSet_1_T_Enumerator_System_Object_ *v64; // [rsp+138h] [rbp-170h]
			//   HashSet_1_T_Enumerator_System_Object_ v65; // [rsp+140h] [rbp-168h] BYREF
			//   RaycastHit v66; // [rsp+160h] [rbp-148h] BYREF
			//   Vector3 v67; // [rsp+1B0h] [rbp-F8h] BYREF
			//   Vector3 v68; // [rsp+1C0h] [rbp-E8h] BYREF
			//   Vector3 v69; // [rsp+1D0h] [rbp-D8h] BYREF
			//   __m128i v70[9]; // [rsp+1E0h] [rbp-C8h] BYREF
			// 
			//   v12 = 0;
			//   if ( !byte_18D919DC3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::GameObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::GameObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::GameObject>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::GameObject>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::GameObject>::get_Count);
			//     byte_18D919DC3 = 1;
			//   }
			//   memset(&v55, 0, sizeof(v55));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1385, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1385, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v46, v45);
			//     v52 = *rayStartLocal;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_529(
			//              Patch,
			//              &v52,
			//              maxDistance,
			//              searchRange,
			//              (Object *)transform,
			//              layerMask,
			//              (Object *)needCheckGo,
			//              (Object *)ignoreCheckGo,
			//              localMaxHeight,
			//              localMinHeight,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !transform )
			//       sub_180B536AC(v14, v13);
			//     v53 = *UnityEngine::Transform::get_up(&v52, transform, 0LL);
			//     v53 = *UnityEngine::Vector3::op_UnaryNegation(&v52, &v53, v15);
			//     y = -3.4028235e38;
			//     v51 = 3.4028235e38;
			//     for ( i = -2; i <= 2; ++i )
			//     {
			//       for ( j = -2; j <= 2; ++j )
			//       {
			//         v17 = (float)((float)i * searchRange) + rayStartLocal.z;
			//         *(_QWORD *)&v57.x = _mm_unpacklo_ps((__m128)COERCE_UNSIGNED_INT((float)j), (__m128)LODWORD(rayStartLocal.y)).m128_u64[0];
			//         v57.z = v17;
			//         memset(&v65, 0, sizeof(v65));
			//         v58 = v53;
			//         v59 = *UnityEngine::Transform::TransformPoint(&v67, transform, &v57, 0LL);
			//         UnityEngine::Ray::Ray((Ray *)&v65, &v59, &v58, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGSludgeUtils.static_fields;
			//         v56 = v65;
			//         v54 = UnityEngine::Physics::RaycastNonAlloc((Ray *)&v56, static_fields.s_raycastResults, maxDistance, 0LL);
			//         for ( k = 0; k <= v54 - 1; ++k )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//           v20 = TypeInfo::HG::Rendering::Runtime::HGSludgeUtils.static_fields;
			//           if ( !v20.s_raycastResults )
			//             sub_180B536AC(v20, v19);
			//           sub_18005A9F0(v20.s_raycastResults, v70, k);
			//           v23 = v70[0];
			//           *(__m128i *)&v66.m_Point.x = v70[0];
			//           *(__m128i *)&v66.m_Normal.y = v70[1];
			//           *(__m128i *)&v66.m_UV.x = v70[2];
			//           *(__m128i *)&v66.m_EcsId = v70[3];
			//           if ( !needCheckGo )
			//             sub_180B536AC(v22, v21);
			//           if ( needCheckGo.fields._count <= 0 )
			//           {
			//             v29 = _mm_cvtsi128_si32(_mm_srli_si128(v70[0], 8));
			//           }
			//           else
			//           {
			//             v55 = *(HashSet_1_T_Enumerator_System_Object_ *)sub_180407974(&v56, needCheckGo);
			//             v61 = 0LL;
			//             v62 = &v55;
			//             do
			//             {
			//               if ( !System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//                       &v55,
			//                       MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::GameObject>::MoveNext) )
			//               {
			//                 v29 = _mm_cvtsi128_si32(_mm_srli_si128(v23, 8));
			//                 goto LABEL_22;
			//               }
			//               current = v55._current;
			//               v25 = (Component *)UnityEngine::RaycastHit::get_transform(&v66, 0LL);
			//               if ( !v25 )
			//                 sub_1802DC2C8(v27, v26);
			//               gameObject = UnityEngine::Component::get_gameObject(v25, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//             }
			//             while ( !HG::Rendering::Runtime::HGSludgeUtils::IsSelfOrDescendant(gameObject, (GameObject *)current, 0LL) );
			//             *(_QWORD *)&v60.x = v23.m128i_i64[0];
			//             v29 = _mm_cvtsi128_si32(_mm_srli_si128(v23, 8));
			//             LODWORD(v60.z) = v29;
			//             v30 = UnityEngine::Transform::InverseTransformPoint(&v68, transform, &v60, 0LL);
			//             if ( y <= v30.y )
			//               y = v30.y;
			//           }
			// LABEL_22:
			//           v31 = ignoreCheckGo;
			//           if ( !ignoreCheckGo )
			//             goto LABEL_50;
			//           if ( ignoreCheckGo.fields._count > 0 )
			//           {
			//             System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
			//               (HashSet_1_T_Enumerator_System_UInt64_ *)&v56,
			//               (HashSet_1_System_UInt64_ *)ignoreCheckGo,
			//               MethodInfo::System::Collections::Generic::HashSet<UnityEngine::GameObject>::GetEnumerator);
			//             v55 = v56;
			//             v63 = 0LL;
			//             v64 = &v55;
			//             while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//                       &v55,
			//                       MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::GameObject>::MoveNext) )
			//             {
			//               v32 = v55._current;
			//               v33 = (Component *)UnityEngine::RaycastHit::get_transform(&v66, 0LL);
			//               if ( !v33 )
			//                 sub_1802DC2C8(v35, v34);
			//               v36 = UnityEngine::Component::get_gameObject(v33, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//               if ( HG::Rendering::Runtime::HGSludgeUtils::IsSelfOrDescendant(v36, (GameObject *)v32, 0LL) )
			//                 goto LABEL_37;
			//             }
			//           }
			//           collider = (Component *)UnityEngine::RaycastHit::get_collider(&v66, 0LL);
			//           if ( !collider || (v38 = UnityEngine::Component::get_gameObject(collider, 0LL)) == 0LL )
			// LABEL_50:
			//             sub_1802DC2C8(v22, v31);
			//           v39 = UnityEngine::GameObject::get_layer(v38, 0LL) & 0x1F;
			//           if ( _bittest(&layerMask, v39) )
			//           {
			//             *(_QWORD *)&v52.x = v23.m128i_i64[0];
			//             LODWORD(v52.z) = v29;
			//             v41 = UnityEngine::Transform::InverseTransformPoint(&v69, transform, &v52, 0LL);
			//             v42 = v41.y;
			//             if ( y <= v42 )
			//               y = v41.y;
			//             v43 = v51;
			//             if ( v42 <= v51 )
			//               v43 = v41.y;
			//             v51 = v43;
			//           }
			// LABEL_37:
			//           ;
			//         }
			//       }
			//     }
			//     *localMaxHeight = y;
			//     *localMinHeight = v51;
			//     if ( y != -3.4028235e38 )
			//       return 1;
			//     return v12;
			//   }
			// }
			// 
			return default(bool);
		}

		public static void Destroy(global::UnityEngine.Object obj)
		{
			// // Void Destroy(Object)
			// void HG::Rendering::Runtime::HGSludgeUtils::Destroy(Object_1 *obj, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919DC4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DC4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1387, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1387, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)obj, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality(obj, 0LL, 0LL) )
			//     {
			//       if ( UnityEngine::Application::get_isPlaying(0LL) )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         UnityEngine::Object::Destroy(obj, 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         UnityEngine::Object::DestroyImmediate(obj, 0LL);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public static uint NextPowerOfTwo(uint x)
		{
			// // UInt32 NextPowerOfTwo(UInt32)
			// uint32_t HG::Rendering::Runtime::HGSludgeUtils::NextPowerOfTwo(uint32_t x, MethodInfo *method)
			// {
			//   uint32_t v3; // ebx
			//   unsigned int v4; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1388, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1388, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, x, 0LL);
			//   }
			//   else if ( x )
			//   {
			//     v3 = ((((x - 1) >> 1) | (x - 1)) >> 2) | ((x - 1) >> 1) | (x - 1);
			//     v4 = (((v3 >> 4) | v3) >> 8) | (v3 >> 4) | v3;
			//     return (v4 | HIWORD(v4)) + 1;
			//   }
			//   else
			//   {
			//     return 1;
			//   }
			// }
			// 
			return 0U;
		}

		public static int NodeCount(int levelCount)
		{
			// // Int32 NodeCount(Int32)
			// int32_t HG::Rendering::Runtime::HGSludgeUtils::NodeCount(int32_t levelCount, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1389, 0LL) )
			//     return ((1 << (2 * (levelCount & 0xF))) - 1) / 3;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1389, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, levelCount, 0LL);
			// }
			// 
			return 0;
		}

		public static int NodeIndex(int level, int col, int row)
		{
			// // Int32 NodeIndex(Int32, Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGSludgeUtils::NodeIndex(int32_t level, int32_t col, int32_t row, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1390, 0LL) )
			//     return (row << (level & 0x1F)) + col + ((1 << (2 * (level & 0xF))) - 1) / 3;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1390, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1196(Patch, level, col, row, 0LL);
			// }
			// 
			return 0;
		}

		public static void SetPatchAABBs(ref SludgeNodeData nodeData, DynamicArray<Bounds> patchBounds)
		{
			// // Void SetPatchAABBs(SludgeNodeData ByRef, DynamicArray`1[UnityEngine.Bounds])
			// void HG::Rendering::Runtime::HGSludgeUtils::SetPatchAABBs(
			//         SludgeNodeData *nodeData,
			//         DynamicArray_1_UnityEngine_Bounds_ *patchBounds,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // r9
			//   float z; // eax
			//   Vector3 *v7; // rax
			//   __int64 v8; // xmm0_8
			//   __int64 v9; // xmm3_8
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   int32_t v12; // edi
			//   SludgeNodeData_patchAABBData_e_FixedBuffer *v13; // rbx
			//   RenderGraph_CompiledResourceInfo *Item; // rax
			//   __m128 v15; // xmm10
			//   float v16; // xmm9_4
			//   float v17; // xmm11_4
			//   float v18; // xmm12_4
			//   float x; // xmm7_4
			//   float v20; // xmm6_4
			//   Beyond::JobMathf *v21; // rcx
			//   float v22; // xmm6_4
			//   float v23; // xmm6_4
			//   Beyond::JobMathf *v24; // rcx
			//   float v25; // xmm10_4
			//   float v26; // xmm10_4
			//   Beyond::JobMathf *v27; // rcx
			//   float v28; // xmm9_4
			//   Beyond::JobMathf *v29; // rcx
			//   float v30; // xmm11_4
			//   Beyond::JobMathf *v31; // rcx
			//   float v32; // xmm12_4
			//   Beyond::JobMathf *v33; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v35; // [rsp+28h] [rbp-E0h] BYREF
			//   Bounds v36; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector3 v37[2]; // [rsp+58h] [rbp-B0h] BYREF
			//   __int64 v38; // [rsp+78h] [rbp-90h]
			//   Vector3 v39; // [rsp+80h] [rbp-88h] BYREF
			//   Vector3 v40; // [rsp+90h] [rbp-78h] BYREF
			//   Vector3 v41; // [rsp+A0h] [rbp-68h] BYREF
			//   Vector3 v42[12]; // [rsp+B0h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919DC5 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<UnityEngine::Bounds>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//     byte_18D919DC5 = 1;
			//   }
			//   memset(&v36, 0, sizeof(v36));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1391, 0LL) )
			//   {
			//     z = nodeData.aabbExtent.z;
			//     *(_QWORD *)&v35.x = *(_QWORD *)&nodeData.aabbExtent.x;
			//     v35.z = z;
			//     v7 = UnityEngine::Vector3::op_Multiply(v37, &v35, 2.0, v5);
			//     v8 = *(_QWORD *)&nodeData.aabbCenter.x;
			//     v9 = *(_QWORD *)&v7.x;
			//     v35.z = v7.z;
			//     v37[0].z = nodeData.aabbCenter.z;
			//     *(_QWORD *)&v35.x = v9;
			//     *(_QWORD *)&v37[0].x = v8;
			//     UnityEngine::Bounds::Bounds(&v36, v37, &v35, 0LL);
			//     v12 = 0;
			//     v13 = &nodeData.patchAABBData + 2;
			//     while ( patchBounds )
			//     {
			//       Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)patchBounds,
			//                v12,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<UnityEngine::Bounds>::get_Item);
			//       v15 = *(__m128 *)&Item.producers;
			//       v38 = *(_QWORD *)&Item.refCount;
			//       v16 = _mm_shuffle_ps(v15, v15, 255).m128_f32[0];
			//       if ( v16 != 0.0 )
			//       {
			//         v17 = *(float *)&v38;
			//         if ( *(float *)&v38 != 0.0 )
			//         {
			//           v18 = *((float *)&v38 + 1);
			//           if ( *((float *)&v38 + 1) != 0.0 )
			//           {
			//             x = UnityEngine::Bounds::get_min(v37, &v36, 0LL).x;
			//             v20 = UnityEngine::Bounds::get_size(&v35, &v36, 0LL).x;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//             Beyond::JobMathf::Clamp01(v21);
			//             v13[-2].FixedElementField = (int)(float)((float)((float)(v15.m128_f32[0] - x) / v20) * 255.0);
			//             v22 = _mm_shuffle_ps(v15, v15, 85).m128_f32[0] - UnityEngine::Bounds::get_min(&v39, &v36, 0LL).y;
			//             v23 = v22 / UnityEngine::Bounds::get_size(&v40, &v36, 0LL).y;
			//             Beyond::JobMathf::Clamp01(v24);
			//             v13[-1].FixedElementField = (int)(float)(v23 * 255.0);
			//             v25 = _mm_shuffle_ps(v15, v15, 170).m128_f32[0] - UnityEngine::Bounds::get_min(&v41, &v36, 0LL).z;
			//             v26 = v25 / UnityEngine::Bounds::get_size(v42, &v36, 0LL).z;
			//             Beyond::JobMathf::Clamp01(v27);
			//             v13.FixedElementField = (int)(float)(v26 * 255.0);
			//             v28 = v16 / v36.m_Extents.x;
			//             Beyond::JobMathf::Clamp01(v29);
			//             v13[1].FixedElementField = (int)(float)(v28 * 255.0);
			//             v30 = v17 / v36.m_Extents.y;
			//             Beyond::JobMathf::Clamp01(v31);
			//             v13[2].FixedElementField = (int)(float)(v30 * 255.0);
			//             v32 = v18 / v36.m_Extents.z;
			//             Beyond::JobMathf::Clamp01(v33);
			//             v13[3].FixedElementField = (int)(float)(v32 * 255.0);
			//           }
			//         }
			//       }
			//       ++v12;
			//       v13 += 6;
			//       if ( v12 >= 4 )
			//         return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v11, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1391, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_531(Patch, nodeData, (Object *)patchBounds, 0LL);
			// }
			// 
		}

		public static Bounds GetPatchAABB(ref SludgeNodeData nodeData, int i)
		{
			// // Bounds GetPatchAABB(SludgeNodeData ByRef, Int32)
			// Bounds *HG::Rendering::Runtime::HGSludgeUtils::GetPatchAABB(
			//         Bounds *__return_ptr retstr,
			//         SludgeNodeData *nodeData,
			//         int32_t i,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v7; // r9
			//   __m128 v8; // xmm6
			//   __m128 v9; // xmm3
			//   __m128 v10; // xmm2
			//   float v11; // xmm1_4
			//   Vector3 *v12; // rax
			//   __m128 v13; // xmm5
			//   __int64 v14; // xmm1_8
			//   float v15; // xmm4_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Vector3 v20; // [rsp+30h] [rbp-48h] BYREF
			//   Bounds v21; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1394, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1394, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_532(&v21, Patch, nodeData, i, 0LL);
			//   }
			//   else
			//   {
			//     v8 = (__m128)COERCE_UNSIGNED_INT((float)*(&nodeData.patchAABBData.FixedElementField + 6 * i));
			//     v8.m128_f32[0] = (float)((float)((float)(v8.m128_f32[0] / 127.5) - 1.0) * nodeData.aabbExtent.x)
			//                    + nodeData.aabbCenter.x;
			//     v9 = (__m128)COERCE_UNSIGNED_INT((float)*((unsigned __int8 *)&nodeData.patchAABBData + 6 * i + 3));
			//     v10 = (__m128)COERCE_UNSIGNED_INT((float)*(&nodeData[1].allHole + 6 * i));
			//     v9.m128_f32[0] = (float)(v9.m128_f32[0] / 255.0) * nodeData.aabbExtent.x;
			//     v10.m128_f32[0] = (float)(v10.m128_f32[0] / 255.0) * nodeData.aabbExtent.y;
			//     v11 = (float)((float)*(&nodeData[1].treeLevel + 6 * i) / 255.0) * nodeData.aabbExtent.z;
			//     *(_QWORD *)&v20.x = _mm_unpacklo_ps(v9, v10).m128_u64[0];
			//     v20.z = v11;
			//     v12 = UnityEngine::Vector3::op_Multiply(&v21.m_Center, 2.0, &v20, v7);
			//     v14 = *(_QWORD *)&v12.x;
			//     v20.z = v12.z;
			//     *(_OWORD *)&retstr.m_Center.x = 0LL;
			//     *(_QWORD *)&retstr.m_Extents.y = 0LL;
			//     v21.m_Center.z = v15;
			//     *(_QWORD *)&v20.x = v14;
			//     *(_QWORD *)&v21.m_Center.x = _mm_unpacklo_ps(v8, v13).m128_u64[0];
			//     UnityEngine::Bounds::Bounds(retstr, &v21.m_Center, &v20, 0LL);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static void ComputeSDF(float[,] sdf)
		{
			// // Void ComputeSDF(Single[,])
			// void HG::Rendering::Runtime::HGSludgeUtils::ComputeSDF(Single__Array_1 *sdf, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   System::Array *v5; // rcx
			//   PassConstructorID__Enum__Array *v6; // r8
			//   HGCamera *v7; // r9
			//   __int64 v8; // rdi
			//   Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *v9; // rax
			//   Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *v10; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   HashSet_1_System_Int32_ *v14; // rax
			//   HashSet_1_System_Int32_ *v15; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   int Length; // eax
			//   int32_t v20; // r12d
			//   int32_t i; // ebp
			//   int32_t v22; // ebx
			//   double v23; // xmm0_8
			//   Action_2_Int32_Int32_ *v24; // rsi
			//   int32_t v25; // r14d
			//   Action_2_Int32_Int32_ *v26; // rax
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   __int64 v30; // rax
			//   __int64 v31; // rax
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   __int64 v34; // rsi
			//   __int64 v35; // r9
			//   Vector2Int v36; // rax
			//   int32_t m_X; // ebx
			//   Vector2Int v38; // rbp
			//   __int64 v39; // rax
			//   unsigned __int64 v40; // rbp
			//   HashSet_1_System_Int32_ *v41; // r15
			//   int v42; // r14d
			//   __int64 v43; // rax
			//   int32_t v44; // r14d
			//   int32_t v45; // r15d
			//   int32_t v46; // ebp
			//   Action_2_Int32_Int32_ *v47; // rax
			//   Action_2_Int32_Int32_ *v48; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *callback; // [rsp+20h] [rbp-28h]
			//   MethodInfo *callbacka; // [rsp+20h] [rbp-28h]
			//   MethodInfo *callbackb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *callbackc; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v54; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v55; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v56; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v57; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D919DC6 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<int,int>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::HashSet);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::HashSet<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>::Queue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>::get_Count);
			//     sub_18003C530(TypeInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_0::_ComputeSDF_b__1);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_1::_ComputeSDF_b__2);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_1);
			//     byte_18D919DC6 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1395, 0LL) )
			//   {
			//     v3 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_0);
			//     v8 = v3;
			//     if ( !v3 )
			//       goto LABEL_33;
			//     *(_QWORD *)(v3 + 16) = sdf;
			//     sub_1800054D0((HGRenderPathScene *)(v3 + 16), v4, v6, v7, callback, v54);
			//     v9 = (Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *)sub_180004920(TypeInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>[0]);
			//     v10 = v9;
			//     if ( !v9 )
			//       goto LABEL_33;
			//     System::Collections::Generic::Stack<System::Dynamic::BindingRestrictions_TestBuilder::AndNode>::Stack(
			//       v9,
			//       MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>::Queue);
			//     *(_QWORD *)(v8 + 40) = v10;
			//     sub_1800054D0((HGRenderPathScene *)(v8 + 40), v11, v12, v13, callbacka, v55);
			//     v14 = (HashSet_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::HashSet<int>);
			//     v15 = v14;
			//     if ( !v14 )
			//       goto LABEL_33;
			//     System::Collections::Generic::HashSet<int>::HashSet(
			//       v14,
			//       MethodInfo::System::Collections::Generic::HashSet<int>::HashSet);
			//     *(_QWORD *)(v8 + 24) = v15;
			//     sub_1800054D0((HGRenderPathScene *)(v8 + 24), v16, v17, v18, callbackb, v56);
			//     v5 = *(System::Array **)(v8 + 16);
			//     if ( !v5 )
			//       goto LABEL_33;
			//     Length = System::Array::GetLength(v5, 0);
			//     v5 = *(System::Array **)(v8 + 16);
			//     *(_DWORD *)(v8 + 32) = Length;
			//     if ( !v5 )
			//       goto LABEL_33;
			//     v20 = System::Array::GetLength(v5, 1);
			//     for ( i = 0; i < *(_DWORD *)(v8 + 32); ++i )
			//     {
			//       v22 = 0;
			//       if ( v20 > 0 )
			//       {
			//         do
			//         {
			//           v5 = *(System::Array **)(v8 + 16);
			//           if ( !v5 )
			//             goto LABEL_33;
			//           v23 = sub_18006A270(v5, i, v22);
			//           if ( *(float *)&v23 == 0.0 )
			//           {
			//             v24 = *(Action_2_Int32_Int32_ **)(v8 + 48);
			//             v25 = *(_DWORD *)(v8 + 32);
			//             if ( !v24 )
			//             {
			//               v26 = (Action_2_Int32_Int32_ *)sub_180004920(TypeInfo::System::Action<int,int>);
			//               v24 = v26;
			//               if ( !v26 )
			//                 goto LABEL_33;
			//               System::Action<int,int>::Action(
			//                 v26,
			//                 (Object *)v8,
			//                 MethodInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_0::_ComputeSDF_b__1,
			//                 0LL);
			//               *(_QWORD *)(v8 + 48) = v24;
			//               sub_1800054D0((HGRenderPathScene *)(v8 + 48), v27, v28, v29, callbackc, v57);
			//             }
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//             HG::Rendering::Runtime::HGSludgeUtils::ForAround(i, v22, v25, v20, v24, 0LL);
			//           }
			//         }
			//         while ( ++v22 < v20 );
			//       }
			//     }
			//     while ( 1 )
			//     {
			//       v30 = *(_QWORD *)(v8 + 40);
			//       if ( !v30 )
			//         break;
			//       if ( *(int *)(v30 + 32) <= 0 )
			//         return;
			//       v31 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_1);
			//       v34 = v31;
			//       if ( !v31 )
			//         break;
			//       *(_QWORD *)(v31 + 32) = v8;
			//       sub_1800054D0((HGRenderPathScene *)(v31 + 32), v4, v32, v33, callbackc, v57);
			//       v35 = *(_QWORD *)(v34 + 32);
			//       if ( !v35 )
			//         break;
			//       v5 = *(System::Array **)(v35 + 40);
			//       if ( !v5 )
			//         break;
			//       v36 = System::Collections::Generic::Queue<UnityEngine::Vector2Int>::Dequeue(
			//               (Queue_1_UnityEngine_Vector2Int_ *)v5,
			//               MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2Int>::Dequeue);
			//       m_X = v36.m_X;
			//       *(_DWORD *)(v34 + 16) = v36.m_X;
			//       v38 = v36;
			//       v39 = *(_QWORD *)(v34 + 32);
			//       v40 = HIDWORD(*(unsigned __int64 *)&v38);
			//       *(_DWORD *)(v34 + 20) = v40;
			//       if ( !v39 )
			//         break;
			//       v41 = *(HashSet_1_System_Int32_ **)(v39 + 24);
			//       v42 = *(_DWORD *)(v39 + 32);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//       if ( !v41 )
			//         break;
			//       System::Collections::Generic::HashSet<int>::Remove(
			//         v41,
			//         m_X + v40 * v42,
			//         MethodInfo::System::Collections::Generic::HashSet<int>::Remove);
			//       v43 = *(_QWORD *)(v34 + 32);
			//       v44 = *(_DWORD *)(v34 + 16);
			//       v45 = *(_DWORD *)(v34 + 20);
			//       *(_DWORD *)(v34 + 24) = 2139095039;
			//       if ( !v43 )
			//         break;
			//       v46 = *(_DWORD *)(v43 + 32);
			//       v47 = (Action_2_Int32_Int32_ *)sub_180004920(TypeInfo::System::Action<int,int>);
			//       v48 = v47;
			//       if ( !v47 )
			//         break;
			//       System::Action<int,int>::Action(
			//         v47,
			//         (Object *)v34,
			//         MethodInfo::HG::Rendering::Runtime::HGSludgeUtils::__c__DisplayClass11_1::_ComputeSDF_b__2,
			//         0LL);
			//       HG::Rendering::Runtime::HGSludgeUtils::ForAround(v44, v45, v46, v20, v48, 0LL);
			//       v5 = *(System::Array **)(v34 + 32);
			//       if ( !v5 )
			//         break;
			//       v5 = (System::Array *)*((_QWORD *)v5 + 2);
			//       if ( !v5 )
			//         break;
			//       sub_18006A240(v5, *(int *)(v34 + 16), *(int *)(v34 + 20));
			//     }
			// LABEL_33:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1395, 0LL);
			//   if ( !Patch )
			//     goto LABEL_33;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)sdf, 0LL);
			// }
			// 
		}

		public static void ForAround(int ix, int iz, int xCount, int zCount, Action<int, int> callback)
		{
			// // Void ForAround(Int32, Int32, Int32, Int32, Action`2[Int32,Int32])
			// void HG::Rendering::Runtime::HGSludgeUtils::ForAround(
			//         int32_t ix,
			//         int32_t iz,
			//         int32_t xCount,
			//         int32_t zCount,
			//         Action_2_Int32_Int32_ *callback,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int v12; // eax
			//   int v13; // edi
			//   int v14; // esi
			//   int32_t v15; // ebp
			//   int32_t v16; // ebx
			//   int v17; // [rsp+40h] [rbp-28h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1399, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1399, 0LL);
			//     if ( !Patch )
			// LABEL_16:
			//       sub_180B536AC(Patch, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_533(Patch, ix, iz, xCount, zCount, (Object *)callback, 0LL);
			//   }
			//   else
			//   {
			//     v12 = iz - 1;
			//     v13 = -1;
			//     v17 = iz - 1;
			//     v14 = -iz;
			//     while ( 1 )
			//     {
			//       v15 = v13 + ix;
			//       v16 = v12;
			//       do
			//       {
			//         if ( v15 >= 0 && v15 < xCount && v16 >= 0 && v16 < zCount && (v13 || v14 + v16) )
			//         {
			//           if ( !callback )
			//             goto LABEL_16;
			//           sub_183B42660(callback, (unsigned int)v15, (unsigned int)v16, 0LL);
			//         }
			//         ++v16;
			//       }
			//       while ( v14 + v16 <= 1 );
			//       if ( ++v13 > 1 )
			//         break;
			//       v12 = v17;
			//     }
			//   }
			// }
			// 
		}

		public static void BlurHeight(float[,] height, int blurTimes)
		{
			// // Void BlurHeight(Single[,], Int32)
			// void HG::Rendering::Runtime::HGSludgeUtils::BlurHeight(Single__Array_1 *height, int32_t blurTimes, MethodInfo *method)
			// {
			//   __int64 v5; // r8
			//   __int64 v6; // r9
			//   Array *v7; // r15
			//   int v8; // ebp
			//   Single__Array_1 *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Single__Array_1 *v12; // r12
			//   int v13; // esi
			//   int i; // ebx
			//   double v15; // xmm0_8
			//   float v16; // xmm6_4
			//   double v17; // xmm0_8
			//   float v18; // xmm6_4
			//   float *v19; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DC7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//     sub_18003C530(&TypeInfo::System::Single);
			//     sub_18003C530(&7848C87B1819709EC2A0D678BCD530B3C49CA3BB2F61B8FCEF827B64DE251E15_Field_0);
			//     byte_18D919DC7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1402, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1402, 0LL);
			//     if ( !Patch )
			//       goto LABEL_17;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)height,
			//       blurTimes,
			//       0LL);
			//   }
			//   else
			//   {
			//     v7 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Single, 5LL, v5, v6);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v7,
			//       7848C87B1819709EC2A0D678BCD530B3C49CA3BB2F61B8FCEF827B64DE251E15_Field_0,
			//       0LL);
			//     v8 = 0;
			//     if ( blurTimes > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeUtils);
			//         v9 = HG::Rendering::Runtime::HGSludgeUtils::Convolution(height, (Single__Array *)v7, (Vector2Int)1LL, 0LL);
			//         v12 = HG::Rendering::Runtime::HGSludgeUtils::Convolution(
			//                 v9,
			//                 (Single__Array *)v7,
			//                 (Vector2Int)0x100000000LL,
			//                 0LL);
			//         v13 = 0;
			//         if ( !height )
			//           break;
			//         while ( v13 < (int)System::Array::GetLength((System::Array *)height, 0) )
			//         {
			//           for ( i = 0; i < (int)System::Array::GetLength((System::Array *)height, 1); ++i )
			//           {
			//             sub_18006A270(height, v13, i);
			//             if ( !v12 )
			//               goto LABEL_17;
			//             v15 = sub_18006A270(v12, v13, i);
			//             v16 = *(float *)&v15;
			//             v17 = sub_18006A270(height, v13, i);
			//             v18 = v16 - *(float *)&v17;
			//             if ( v18 <= 0.0 )
			//               v18 = 0.0;
			//             v19 = (float *)sub_180410F18(height, v13, i);
			//             *v19 = v18 + *v19;
			//           }
			//           ++v13;
			//         }
			//         if ( ++v8 >= blurTimes )
			//           return;
			//       }
			// LABEL_17:
			//       sub_180B536AC(v11, v10);
			//     }
			//   }
			// }
			// 
		}

		public static float[,] Convolution(float[,] src, float[] kernel, Vector2Int offsetDir)
		{
			// // Single[,] Convolution(Single[,], Single[], Vector2Int)
			// Single__Array_1 *HG::Rendering::Runtime::HGSludgeUtils::Convolution(
			//         Single__Array_1 *src,
			//         Single__Array *kernel,
			//         Vector2Int offsetDir,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int Length; // eax
			//   __int64 v10; // r15
			//   int v11; // eax
			//   __int64 v12; // r14
			//   int32_t size; // eax
			//   int32_t v14; // edx
			//   int v15; // r12d
			//   int v16; // ebp
			//   Single__Array_1 *v17; // r13
			//   int v18; // eax
			//   int v19; // r15d
			//   int v20; // eax
			//   int32_t v21; // r14d
			//   float v22; // xmm6_4
			//   unsigned int v23; // r12d
			//   double v24; // xmm0_8
			//   double v25; // xmm0_8
			//   __int64 v26; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned int v29; // [rsp+30h] [rbp-68h]
			//   int v30; // [rsp+34h] [rbp-64h]
			//   int v31; // [rsp+38h] [rbp-60h]
			//   int v32; // [rsp+3Ch] [rbp-5Ch]
			//   int v33; // [rsp+40h] [rbp-58h]
			//   unsigned int v34; // [rsp+44h] [rbp-54h]
			//   int v35; // [rsp+48h] [rbp-50h]
			//   int v36; // [rsp+4Ch] [rbp-4Ch]
			//   _QWORD v37[2]; // [rsp+50h] [rbp-48h] BYREF
			//   int32_t m_Y; // [rsp+B4h] [rbp+1Ch]
			// 
			//   m_Y = offsetDir.m_Y;
			//   if ( !byte_18D919DC8 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::System::Single);
			//     byte_18D919DC8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1403, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1403, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_534(Patch, (Object *)src, (Object *)kernel, offsetDir, 0LL);
			// LABEL_24:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !src )
			//     goto LABEL_24;
			//   Length = System::Array::GetLength((System::Array *)src, 0);
			//   v10 = Length;
			//   v30 = Length;
			//   v11 = System::Array::GetLength((System::Array *)src, 1);
			//   v12 = v11;
			//   v32 = v11;
			//   if ( !kernel )
			//     goto LABEL_24;
			//   v14 = kernel.max_length.size >> 31;
			//   size = kernel.max_length.size;
			//   v37[0] = v10;
			//   v36 = __SPAIR64__(v14, size) / 2;
			//   v15 = v36;
			//   v37[1] = v12;
			//   v16 = 0;
			//   v17 = (Single__Array_1 *)il2cpp_array_new_full_0(TypeInfo::System::Single, v37, 0LL);
			//   if ( (int)v10 > 0 )
			//   {
			//     v18 = v10;
			//     do
			//     {
			//       v19 = 0;
			//       if ( (int)v12 > 0 )
			//       {
			//         v8 = (unsigned int)(v16 - v15 * offsetDir.m_X);
			//         v20 = v15 * m_Y;
			//         v34 = v16 - v15 * offsetDir.m_X;
			//         v35 = v15 * m_Y;
			//         do
			//         {
			//           v21 = 0;
			//           v29 = v8;
			//           v22 = 0.0;
			//           v23 = v19 - v20;
			//           while ( v21 < kernel.max_length.size )
			//           {
			//             sub_180002C70(TypeInfo::System::Math);
			//             v31 = sub_182ACC210(v23, 0LL, (unsigned int)(v32 - 1));
			//             v33 = sub_182ACC210(v29, 0LL, (unsigned int)(v30 - 1));
			//             v24 = sub_18006A270(src, v33, v31);
			//             if ( *(float *)&v24 == NAN )
			//               LODWORD(v25) = 0;
			//             else
			//               v25 = sub_18006A270(src, v33, v31);
			//             if ( (unsigned int)v21 >= kernel.max_length.size )
			//               sub_180070270(v8, v7);
			//             v23 += m_Y;
			//             v26 = v21++;
			//             v29 += offsetDir.m_X;
			//             v22 = v22 + (float)(*(float *)&v25 * kernel.vector[v26]);
			//           }
			//           if ( !v17 )
			//             goto LABEL_24;
			//           sub_18006A240(v17, v16, v19);
			//           LODWORD(v12) = v32;
			//           ++v19;
			//           v8 = v34;
			//           v20 = v35;
			//         }
			//         while ( v19 < v32 );
			//         v18 = v30;
			//         v15 = v36;
			//       }
			//       ++v16;
			//     }
			//     while ( v16 < v18 );
			//   }
			//   return v17;
			// }
			// 
			return null;
		}

		public static bool IsSelfOrDescendant(GameObject node, GameObject root)
		{
			// // Boolean IsSelfOrDescendant(GameObject, GameObject)
			// bool HG::Rendering::Runtime::HGSludgeUtils::IsSelfOrDescendant(GameObject *node, GameObject *root, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object_1 *transform; // rbx
			//   Object_1 *v8; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DC9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DC9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1386, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1386, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)node,
			//              (Object *)root,
			//              0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)node, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Implicit((Object_1 *)root, 0LL) )
			//       {
			//         if ( node )
			//         {
			//           transform = (Object_1 *)UnityEngine::GameObject::get_transform(node, 0LL);
			//           if ( root )
			//           {
			//             v8 = (Object_1 *)UnityEngine::GameObject::get_transform(root, 0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Equality(transform, v8, 0LL) )
			//               return 1;
			//             if ( transform )
			//               return UnityEngine::Transform::IsChildOf((Transform *)transform, (Transform *)v8, 0LL);
			//           }
			//         }
			// LABEL_14:
			//         sub_180B536AC(v6, v5);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		[CompilerGenerated]
		internal static float <SetPatchAABBs>g__ConvertCenterTo01|9_0(float min, float size, float v)
		{
			// // Single <SetPatchAABBs>g__ConvertCenterTo01|9_0(Single, Single, Single)
			// float HG::Rendering::Runtime::HGSludgeUtils::_SetPatchAABBs_g__ConvertCenterTo01_9_0(
			//         float min,
			//         float size,
			//         float v,
			//         MethodInfo *method)
			// {
			//   Beyond::JobMathf *v4; // rcx
			//   float result; // xmm0_4
			// 
			//   result = (float)(v - min) / size;
			//   Beyond::JobMathf::Clamp01(v4);
			//   return result;
			// }
			// 
			return 0f;
		}

		[CompilerGenerated]
		internal static float <SetPatchAABBs>g__ConvertExtentTo01|9_1(float size, float v)
		{
			// // Single <SetPatchAABBs>g__ConvertExtentTo01|9_1(Single, Single)
			// float HG::Rendering::Runtime::HGSludgeUtils::_SetPatchAABBs_g__ConvertExtentTo01_9_1(
			//         float size,
			//         float v,
			//         MethodInfo *method)
			// {
			//   Beyond::JobMathf *v3; // rcx
			//   float result; // xmm0_4
			// 
			//   result = v / size;
			//   Beyond::JobMathf::Clamp01(v3);
			//   return result;
			// }
			// 
			return 0f;
		}

		[CompilerGenerated]
		internal static int <ComputeSDF>g__GetHash|11_0(int x, int z, int xCount)
		{
			// // Int32 <ComputeSDF>g__GetHash|11_0(Int32, Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGSludgeUtils::_ComputeSDF_g__GetHash_11_0(
			//         int32_t x,
			//         int32_t z,
			//         int32_t xCount,
			//         MethodInfo *method)
			// {
			//   return x + xCount * z;
			// }
			// 
			return 0;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static RaycastHit[] s_raycastResults;
	}
}
