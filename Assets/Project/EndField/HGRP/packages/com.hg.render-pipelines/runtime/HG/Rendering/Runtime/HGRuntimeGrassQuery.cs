using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	public class HGRuntimeGrassQuery
	{
		public HGRuntimeGrassQuery()
		{
			// // HGRuntimeGrassQuery()
			// void HG::Rendering::Runtime::HGRuntimeGrassQuery::HGRuntimeGrassQuery(HGRuntimeGrassQuery *this, MethodInfo *method)
			// {
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *v6; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED9BB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>);
			//     byte_18D8ED9BB = 1;
			//   }
			//   v3 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>);
			//   v6 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,float>::Dictionary(
			//     v3,
			//     MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Dictionary);
			//   this.fields.m_grassClusterToNode = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_grassClusterToNode, v7, v8, v9, v10, v11);
			// }
			// 
		}

		public HGRuntimeGrassQuery.Node GetNodeRoot()
		{
			// // HGRuntimeGrassQuery+Node GetNodeRoot()
			// HGRuntimeGrassQuery_Node *HG::Rendering::Runtime::HGRuntimeGrassQuery::GetNodeRoot(
			//         HGRuntimeGrassQuery *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2195, 0LL) )
			//     return this.fields.m_root;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2195, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_802(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public Dictionary<Entity, HGRuntimeGrassQuery.Node> GetNodeLeaves()
		{
			// // Dictionary`2[UnityEngine.HyperGryph.ECS.Entity,HG.Rendering.Runtime.HGRuntimeGrassQuery+Node] GetNodeLeaves()
			// Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *HG::Rendering::Runtime::HGRuntimeGrassQuery::GetNodeLeaves(
			//         HGRuntimeGrassQuery *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2196, 0LL) )
			//     return this.fields.m_grassClusterToNode;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2196, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_803(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void RegisterGrassCluster(Entity grassCluster, Bounds meshBounds)
		{
			// // Void RegisterGrassCluster(Entity, Bounds)
			// void HG::Rendering::Runtime::HGRuntimeGrassQuery::RegisterGrassCluster(
			//         HGRuntimeGrassQuery *this,
			//         Entity_1 grassCluster,
			//         Bounds *meshBounds,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   __int64 v8; // rdx
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *m_grassClusterToNode; // rcx
			//   __int64 v10; // rsi
			//   __int64 v11; // xmm1_8
			//   uint64_t ComponentMaskLow; // rax
			//   uint8_t *ComponentPtrLowBits; // rax
			//   int v14; // r15d
			//   uint8_t *v15; // r12
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   int v21; // r14d
			//   Matrix4x4 *v22; // rdi
			//   MethodInfo *v23; // r8
			//   Vector3 *v24; // rax
			//   __int64 v25; // xmm8_8
			//   float z; // ebx
			//   Vector4 v27; // xmm0
			//   __m128 v28; // xmm7
			//   __m128 v29; // xmm6
			//   float v30; // eax
			//   Vector3 *size; // rax
			//   MethodInfo *v32; // r9
			//   Vector3 *v33; // rax
			//   __int64 v34; // xmm3_8
			//   MethodInfo *v35; // r9
			//   Vector3 *v36; // rax
			//   __int64 v37; // xmm3_8
			//   __int64 v38; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v40; // xmm1_8
			//   MethodInfo *v41; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v42; // [rsp+30h] [rbp-D8h]
			//   Bounds v43; // [rsp+38h] [rbp-D0h] BYREF
			//   Bounds v44; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v45; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v46; // [rsp+88h] [rbp-80h] BYREF
			//   Vector3 v47; // [rsp+98h] [rbp-70h] BYREF
			//   Vector3 v48; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v49; // [rsp+B8h] [rbp-50h] BYREF
			//   Vector3 v50; // [rsp+C8h] [rbp-40h] BYREF
			//   Bounds aabb; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v52; // [rsp+F0h] [rbp-18h] BYREF
			//   Vector3 v53; // [rsp+100h] [rbp-8h] BYREF
			//   Vector3 v54; // [rsp+110h] [rbp+8h] BYREF
			//   Vector3 v55; // [rsp+120h] [rbp+18h] BYREF
			//   Vector4 v56; // [rsp+130h] [rbp+28h] BYREF
			//   Vector4 v57; // [rsp+140h] [rbp+38h] BYREF
			//   Vector4 v58; // [rsp+150h] [rbp+48h] BYREF
			//   Entity_1 entity; // [rsp+1D0h] [rbp+C8h] BYREF
			// 
			//   entity = grassCluster;
			//   if ( !byte_18D91944F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Bounds);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery::Node);
			//     sub_18003C530(&off_18D4E85F0);
			//     byte_18D91944F = 1;
			//   }
			//   memset(&aabb, 0, sizeof(aabb));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2197, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2197, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     v40 = *(_QWORD *)&meshBounds.m_Extents.y;
			//     *(_OWORD *)&v44.m_Center.x = *(_OWORD *)&meshBounds.m_Center.x;
			//     *(_QWORD *)&v44.m_Extents.y = v40;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_806(Patch, (Object *)this, grassCluster, &v44, 0LL);
			//   }
			//   else
			//   {
			//     *(EntityManager_1 *)&v43.m_Center.x = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(
			//                                              (EntityManager_1 *)&v43,
			//                                              0LL);
			//     if ( !UnityEngine::HyperGryph::ECS::EntityManager::TryGetWorldAABBFromRendererEntity(
			//             (EntityManager_1 *)&v43,
			//             &entity,
			//             &aabb,
			//             0LL) )
			//     {
			//       HG::Rendering::HGRPLogger::LogError((String *)"Invalid Grass Cluster", 0LL);
			//       return;
			//     }
			//     v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery::Node);
			//     v10 = v7;
			//     if ( !v7
			//       || (v11 = *(_QWORD *)&aabb.m_Extents.y,
			//           *(_OWORD *)(v7 + 16) = *(_OWORD *)&aabb.m_Center.x,
			//           *(_QWORD *)(v7 + 32) = v11,
			//           (m_grassClusterToNode = this.fields.m_grassClusterToNode) == 0LL) )
			//     {
			// LABEL_14:
			//       sub_180B536AC(m_grassClusterToNode, v8);
			//     }
			//     System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,System::Object>::Add(
			//       (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Object_ *)m_grassClusterToNode,
			//       entity,
			//       (Object *)v7,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Add);
			//     HG::Rendering::Runtime::HGRuntimeGrassQuery::_AddNode(this, (HGRuntimeGrassQuery_Node *)v10, 0LL);
			//     ComponentMaskLow = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentMaskLow(
			//                          (EntityManager_1 *)&v43,
			//                          &entity,
			//                          0LL);
			//     ComponentPtrLowBits = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
			//                             (EntityManager_1 *)&v43,
			//                             &entity,
			//                             ComponentMaskLow & 0x1E000000000LL,
			//                             0LL);
			//     v14 = *(_DWORD *)ComponentPtrLowBits;
			//     v15 = ComponentPtrLowBits + 4;
			//     *(_QWORD *)(v10 + 64) = il2cpp_array_new_specific_0(
			//                               TypeInfo::UnityEngine::Bounds,
			//                               *(unsigned int *)ComponentPtrLowBits,
			//                               v16,
			//                               v17);
			//     sub_1800054D0((HGRenderPathScene *)(v10 + 64), v18, v19, v20, v41, v42);
			//     v21 = 0;
			//     if ( v14 > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         m_grassClusterToNode = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *)&v15[96 * v21];
			//         if ( !m_grassClusterToNode )
			//           break;
			//         v22 = (Matrix4x4 *)&v15[96 * v21];
			//         *(Vector4 *)&v43.m_Center.x = *UnityEngine::Matrix4x4::GetColumn(&v56, v22, 3, 0LL);
			//         v24 = UnityEngine::Vector4::op_Implicit(&v52, (Vector4 *)&v43, v23);
			//         v25 = *(_QWORD *)&v24.x;
			//         z = v24.z;
			//         v27 = *UnityEngine::Matrix4x4::GetColumn(&v57, v22, 0, 0LL);
			//         *(Vector4 *)&v43.m_Center.x = v27;
			//         *(double *)&v27.x = sub_184D04040(&v43);
			//         v28 = (__m128)v27;
			//         *(Vector4 *)&v43.m_Center.x = *UnityEngine::Matrix4x4::GetColumn(&v58, v22, 1, 0LL);
			//         *(double *)&v27.x = sub_184D04040(&v43);
			//         v29 = (__m128)v27;
			//         *(Vector4 *)&v43.m_Center.x = *UnityEngine::Matrix4x4::GetColumn((Vector4 *)&aabb, v22, 2, 0LL);
			//         *(double *)&v27.x = sub_184D04040(&v43);
			//         v30 = meshBounds.m_Center.z;
			//         *(_QWORD *)&v48.x = *(_QWORD *)&meshBounds.m_Center.x;
			//         *(_QWORD *)&v45.x = _mm_unpacklo_ps(v28, v29).m128_u64[0];
			//         v45.z = v27.x;
			//         *(_QWORD *)&v47.x = v25;
			//         v47.z = z;
			//         v48.z = v30;
			//         size = UnityEngine::Bounds::get_size(&v53, meshBounds, 0LL);
			//         *(_QWORD *)&v27.x = *(_QWORD *)&size.x;
			//         *(float *)&size = size.z;
			//         *(_QWORD *)&v46.x = *(_QWORD *)&v27.x;
			//         LODWORD(v46.z) = (_DWORD)size;
			//         memset(&v44, 0, sizeof(v44));
			//         v33 = UnityEngine::Vector3::Scale(&v54, &v46, &v45, v32);
			//         v34 = *(_QWORD *)&v33.x;
			//         *(float *)&v33 = v33.z;
			//         *(_QWORD *)&v49.x = v34;
			//         LODWORD(v49.z) = (_DWORD)v33;
			//         v36 = UnityEngine::Vector3::op_Addition(&v55, &v48, &v47, v35);
			//         v37 = *(_QWORD *)&v36.x;
			//         *(float *)&v36 = v36.z;
			//         *(_QWORD *)&v50.x = v37;
			//         LODWORD(v50.z) = (_DWORD)v36;
			//         UnityEngine::Bounds::Bounds(&v44, &v50, &v49, 0LL);
			//         if ( !*(_QWORD *)(v10 + 64) )
			//           break;
			//         v38 = *(_QWORD *)(v10 + 64);
			//         v43 = v44;
			//         sub_180412D4C(v38, v21++, &v43);
			//         if ( v21 >= v14 )
			//           return;
			//       }
			//       goto LABEL_14;
			//     }
			//   }
			// }
			// 
		}

		public void UnregisterGrassCluster(Entity grassCluster)
		{
			// // Void UnregisterGrassCluster(Entity)
			// void HG::Rendering::Runtime::HGRuntimeGrassQuery::UnregisterGrassCluster(
			//         HGRuntimeGrassQuery *this,
			//         Entity_1 grassCluster,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *m_grassClusterToNode; // rcx
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919450 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::get_Item);
			//     byte_18D919450 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2204, 0LL) )
			//   {
			//     m_grassClusterToNode = this.fields.m_grassClusterToNode;
			//     if ( m_grassClusterToNode )
			//     {
			//       Item = System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,System::Object>::get_Item(
			//                (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Object_ *)m_grassClusterToNode,
			//                grassCluster,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::get_Item);
			//       HG::Rendering::Runtime::HGRuntimeGrassQuery::_RemoveNode(this, (HGRuntimeGrassQuery_Node *)Item, 0LL);
			//       m_grassClusterToNode = this.fields.m_grassClusterToNode;
			//       if ( m_grassClusterToNode )
			//       {
			//         System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,System::Object>::Remove(
			//           (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Object_ *)m_grassClusterToNode,
			//           grassCluster,
			//           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Remove);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_grassClusterToNode, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2204, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_549(Patch, (Object *)this, grassCluster, 0LL);
			// }
			// 
		}

		public bool InGrassBoundingBox(Vector3 worldPos, out Bounds overlapBounds)
		{
			// // Boolean InGrassBoundingBox(Vector3, Bounds ByRef)
			// bool HG::Rendering::Runtime::HGRuntimeGrassQuery::InGrassBoundingBox(
			//         HGRuntimeGrassQuery *this,
			//         Vector3 *worldPos,
			//         Bounds *overlapBounds,
			//         MethodInfo *method)
			// {
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2207, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2207, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v8);
			//     z = worldPos.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&worldPos.x;
			//     v11.z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_808(Patch, (Object *)this, &v11, overlapBounds, 0LL);
			//   }
			//   else
			//   {
			//     *(_OWORD *)&overlapBounds.m_Center.x = 0LL;
			//     *(_QWORD *)&overlapBounds.m_Extents.y = 0LL;
			//     return HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
			//              this,
			//              this.fields.m_root,
			//              worldPos,
			//              overlapBounds,
			//              0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		private bool _InGrassBoundingBox(HGRuntimeGrassQuery.Node node, ref Vector3 worldPos, ref Bounds overlapBounds)
		{
			// // Boolean _InGrassBoundingBox(HGRuntimeGrassQuery+Node, Vector3 ByRef, Bounds ByRef)
			// bool HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
			//         HGRuntimeGrassQuery *this,
			//         HGRuntimeGrassQuery_Node *node,
			//         Vector3 *worldPos,
			//         Bounds *overlapBounds,
			//         MethodInfo *method)
			// {
			//   float z; // eax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Bounds__Array *grassInstanceBounds; // r14
			//   int32_t v14; // ebx
			//   float v15; // eax
			//   __int64 v16; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v18; // [rsp+30h] [rbp-40h] BYREF
			//   Bounds v19; // [rsp+40h] [rbp-30h] BYREF
			//   __int128 v20; // [rsp+58h] [rbp-18h] BYREF
			//   __int64 v21; // [rsp+68h] [rbp-8h]
			// 
			//   memset(&v19, 0, sizeof(v19));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2208, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2208, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_807(
			//                Patch,
			//                (Object *)this,
			//                (Object *)node,
			//                worldPos,
			//                overlapBounds,
			//                0LL);
			//     goto LABEL_15;
			//   }
			//   if ( !node )
			//     return 0;
			//   z = worldPos.z;
			//   *(_QWORD *)&v18.x = *(_QWORD *)&worldPos.x;
			//   v18.z = z;
			//   if ( !UnityEngine::Bounds::Contains(&node.fields.bounds, &v18, 0LL) )
			//     return 0;
			//   if ( HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::IsLeaf(node, 0LL) )
			//   {
			//     grassInstanceBounds = node.fields.grassInstanceBounds;
			//     v14 = 0;
			//     if ( grassInstanceBounds )
			//     {
			//       while ( v14 < grassInstanceBounds.max_length.size )
			//       {
			//         sub_18037A33C(grassInstanceBounds, &v20, v14);
			//         v15 = worldPos.z;
			//         *(_OWORD *)&v19.m_Center.x = v20;
			//         v18.z = v15;
			//         *(_QWORD *)&v18.x = *(_QWORD *)&worldPos.x;
			//         *(_QWORD *)&v19.m_Extents.y = v21;
			//         if ( UnityEngine::Bounds::Contains(&v19, &v18, 0LL) )
			//         {
			//           v16 = *(_QWORD *)&v19.m_Extents.y;
			//           *(_OWORD *)&overlapBounds.m_Center.x = *(_OWORD *)&v19.m_Center.x;
			//           *(_QWORD *)&overlapBounds.m_Extents.y = v16;
			//           return 1;
			//         }
			//         ++v14;
			//       }
			//       return 0;
			//     }
			// LABEL_15:
			//     sub_180B536AC(v11, v10);
			//   }
			//   return HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
			//            this,
			//            node.fields.left,
			//            worldPos,
			//            overlapBounds,
			//            0LL)
			//       || HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
			//            this,
			//            node.fields.right,
			//            worldPos,
			//            overlapBounds,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		private void _AddNode(HGRuntimeGrassQuery.Node node)
		{
			// // Void _AddNode(HGRuntimeGrassQuery+Node)
			// void HG::Rendering::Runtime::HGRuntimeGrassQuery::_AddNode(
			//         HGRuntimeGrassQuery *this,
			//         HGRuntimeGrassQuery_Node *node,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   HGRuntimeGrassQuery_Node *left; // rcx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   HGRuntimeGrassQuery_Node *m_root; // rbx
			//   __int64 v10; // xmm1_8
			//   float v11; // xmm0_4
			//   __int64 v12; // xmm2_8
			//   HGRuntimeGrassQuery_Node *parent; // r14
			//   HGRuntimeGrassQuery_Node *v14; // rax
			//   HGRuntimeGrassQuery_Node *v15; // rbp
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v24; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v25; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v26; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v27; // [rsp+28h] [rbp-60h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-60h]
			//   Bounds v29; // [rsp+30h] [rbp-58h] BYREF
			//   Bounds v30; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919451 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery::Node);
			//     byte_18D919451 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2198, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2198, 0LL);
			//     if ( !Patch )
			//       goto LABEL_23;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)node,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.m_root )
			//     {
			//       m_root = this.fields.m_root;
			//       while ( 1 )
			//       {
			//         if ( !m_root )
			//           goto LABEL_23;
			//         if ( HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::IsLeaf(m_root, 0LL) )
			//           break;
			//         if ( !node )
			//           goto LABEL_23;
			//         left = m_root.fields.left;
			//         if ( !left )
			//           goto LABEL_23;
			//         v10 = *(_QWORD *)&node.fields.bounds.m_Extents.y;
			//         *(_OWORD *)&v29.m_Center.x = *(_OWORD *)&node.fields.bounds.m_Center.x;
			//         *(_QWORD *)&v29.m_Extents.y = v10;
			//         v11 = HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ComputeMergeCost(left, &v29, 0LL);
			//         left = m_root.fields.right;
			//         if ( !left )
			//           goto LABEL_23;
			//         v12 = *(_QWORD *)&node.fields.bounds.m_Extents.y;
			//         *(_OWORD *)&v30.m_Center.x = *(_OWORD *)&node.fields.bounds.m_Center.x;
			//         *(_QWORD *)&v30.m_Extents.y = v12;
			//         if ( HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ComputeMergeCost(left, &v30, 0LL) > v11 )
			//           m_root = m_root.fields.left;
			//         else
			//           m_root = m_root.fields.right;
			//       }
			//       parent = m_root.fields.parent;
			//       v14 = (HGRuntimeGrassQuery_Node *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery::Node);
			//       v15 = v14;
			//       if ( v14 )
			//       {
			//         HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::Node(v14, parent, m_root, node, 0LL);
			//         if ( m_root.fields.parent )
			//         {
			//           left = m_root.fields.parent;
			//           if ( !left )
			//             goto LABEL_23;
			//           HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ReplaceChild(left, m_root, v15, 0LL);
			//         }
			//         else
			//         {
			//           this.fields.m_root = v15;
			//           sub_1800054D0((HGRenderPathScene *)&this.fields, v5, v16, v17, v25, v27);
			//         }
			//         m_root.fields.parent = v15;
			//         sub_1800054D0((HGRenderPathScene *)&m_root.fields.parent, v18, v19, v20, v25, v27);
			//         if ( node )
			//         {
			//           node.fields.parent = v15;
			//           sub_1800054D0((HGRenderPathScene *)&node.fields.parent, v5, v21, v22, v26, v28);
			//           HG::Rendering::Runtime::HGRuntimeGrassQuery::_BroadcastBounds(this, v15.fields.parent, 0LL);
			//           return;
			//         }
			//       }
			// LABEL_23:
			//       sub_180B536AC(left, v5);
			//     }
			//     this.fields.m_root = node;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields, v5, v7, v8, v24, v27);
			//   }
			// }
			// 
		}

		private void _RemoveNode(HGRuntimeGrassQuery.Node node)
		{
		}

		private void _BroadcastBounds(HGRuntimeGrassQuery.Node node)
		{
			// // Void _BroadcastBounds(HGRuntimeGrassQuery+Node)
			// void HG::Rendering::Runtime::HGRuntimeGrassQuery::_BroadcastBounds(
			//         HGRuntimeGrassQuery *this,
			//         HGRuntimeGrassQuery_Node *node,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRuntimeGrassQuery_Node *left; // rax
			//   __int64 v8; // xmm1_8
			//   HGRuntimeGrassQuery_Node *right; // rax
			//   __int64 v10; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Bounds v12; // [rsp+20h] [rbp-48h] BYREF
			//   Bounds v13; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2203, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2203, 0LL);
			//     if ( !Patch )
			// LABEL_9:
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)node,
			//       0LL);
			//   }
			//   else
			//   {
			//     while ( node )
			//     {
			//       *(_OWORD *)&node.fields.bounds.m_Center.x = 0LL;
			//       *(_QWORD *)&node.fields.bounds.m_Extents.y = 0LL;
			//       left = node.fields.left;
			//       if ( !left )
			//         goto LABEL_9;
			//       v8 = *(_QWORD *)&left.fields.bounds.m_Extents.y;
			//       *(_OWORD *)&v12.m_Center.x = *(_OWORD *)&left.fields.bounds.m_Center.x;
			//       *(_QWORD *)&v12.m_Extents.y = v8;
			//       UnityEngine::Bounds::Encapsulate(&node.fields.bounds, &v12, 0LL);
			//       right = node.fields.right;
			//       if ( !right )
			//         goto LABEL_9;
			//       v10 = *(_QWORD *)&right.fields.bounds.m_Extents.y;
			//       *(_OWORD *)&v13.m_Center.x = *(_OWORD *)&right.fields.bounds.m_Center.x;
			//       *(_QWORD *)&v13.m_Extents.y = v10;
			//       UnityEngine::Bounds::Encapsulate(&node.fields.bounds, &v13, 0LL);
			//       node = node.fields.parent;
			//     }
			//   }
			// }
			// 
		}

		private HGRuntimeGrassQuery.Node m_root;

		private Dictionary<Entity, HGRuntimeGrassQuery.Node> m_grassClusterToNode;

		public class Node
		{
			public Node(HGRuntimeGrassQuery.Node p, HGRuntimeGrassQuery.Node l, HGRuntimeGrassQuery.Node r)
			{
				// // HGRuntimeGrassQuery+Node(HGRuntimeGrassQuery+Node, HGRuntimeGrassQuery+Node, HGRuntimeGrassQuery+Node)
				// void HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::Node(
				//         HGRuntimeGrassQuery_Node *this,
				//         HGRuntimeGrassQuery_Node *p,
				//         HGRuntimeGrassQuery_Node *l,
				//         HGRuntimeGrassQuery_Node *r,
				//         MethodInfo *method)
				// {
				//   __int64 v9; // xmm1_8
				//   __int64 v10; // xmm1_8
				//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
				//   PassConstructorID__Enum__Array *v12; // r8
				//   HGCamera *v13; // r9
				//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
				//   PassConstructorID__Enum__Array *v15; // r8
				//   HGCamera *v16; // r9
				//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
				//   PassConstructorID__Enum__Array *v18; // r8
				//   HGCamera *v19; // r9
				//   Bounds v20; // [rsp+20h] [rbp-28h] BYREF
				//   MethodInfo *v21; // [rsp+78h] [rbp+30h]
				// 
				//   if ( !l
				//     || (v9 = *(_QWORD *)&l.fields.bounds.m_Extents.y,
				//         *(_OWORD *)&v20.m_Center.x = *(_OWORD *)&l.fields.bounds.m_Center.x,
				//         *(_QWORD *)&v20.m_Extents.y = v9,
				//         UnityEngine::Bounds::Encapsulate(&this.fields.bounds, &v20, 0LL),
				//         !r) )
				//   {
				//     sub_180B536AC(this, p);
				//   }
				//   v10 = *(_QWORD *)&r.fields.bounds.m_Extents.y;
				//   *(_OWORD *)&v20.m_Center.x = *(_OWORD *)&r.fields.bounds.m_Center.x;
				//   *(_QWORD *)&v20.m_Extents.y = v10;
				//   UnityEngine::Bounds::Encapsulate(&this.fields.bounds, &v20, 0LL);
				//   this.fields.parent = p;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&this.fields.parent,
				//     v11,
				//     v12,
				//     v13,
				//     *(MethodInfo **)&v20.m_Center.x,
				//     *(MethodInfo **)&v20.m_Center.z);
				//   this.fields.left = l;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&this.fields.left,
				//     v14,
				//     v15,
				//     v16,
				//     *(MethodInfo **)&v20.m_Center.x,
				//     *(MethodInfo **)&v20.m_Center.z);
				//   this.fields.right = r;
				//   sub_1800054D0((HGRenderPathScene *)&this.fields.right, v17, v18, v19, method, v21);
				// }
				// 
			}

			public Node(Bounds b)
			{
				// // Void set_value(Ray)
				// void ParadoxNotion::EventData<UnityEngine::Ray>::set_value(
				//         EventData_1_UnityEngine_Ray_ *this,
				//         Ray *value,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // xmm1_8
				// 
				//   v3 = *(_QWORD *)&value.m_Direction.y;
				//   *(_OWORD *)&this._value_k__BackingField.m_Origin.x = *(_OWORD *)&value.m_Origin.x;
				//   *(_QWORD *)&this._value_k__BackingField.m_Direction.y = v3;
				// }
				// 
			}

			public bool IsLeaf()
			{
				// // Boolean IsLeaf()
				// bool HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::IsLeaf(HGRuntimeGrassQuery_Node *this, MethodInfo *method)
				// {
				//   bool result; // al
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   result = IFix::WrappersManagerImpl::IsPatched(2201, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else if ( !this.fields.left )
				//   {
				//     return this.fields.right == 0LL;
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			public float ComputeMergeCost(Bounds b)
			{
				// // Single ComputeMergeCost(Bounds)
				// float HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ComputeMergeCost(
				//         HGRuntimeGrassQuery_Node *this,
				//         Bounds *b,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // xmm1_8
				//   __int64 v6; // xmm1_8
				//   float BoundsVolume; // xmm0_4
				//   __int64 v8; // xmm2_8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v11; // rdx
				//   __int64 v12; // rcx
				//   __int64 v13; // xmm1_8
				//   Bounds v14; // [rsp+20h] [rbp-30h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2199, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2199, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v12, v11);
				//     v13 = *(_QWORD *)&b.m_Extents.y;
				//     *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&b.m_Center.x;
				//     *(_QWORD *)&v14.m_Extents.y = v13;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_804(Patch, (Object *)this, &v14, 0LL);
				//   }
				//   else
				//   {
				//     v5 = *(_QWORD *)&this.fields.bounds.m_Extents.y;
				//     *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&this.fields.bounds.m_Center.x;
				//     *(_QWORD *)&v14.m_Extents.y = v5;
				//     UnityEngine::Bounds::Encapsulate(b, &v14, 0LL);
				//     v6 = *(_QWORD *)&b.m_Extents.y;
				//     *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&b.m_Center.x;
				//     *(_QWORD *)&v14.m_Extents.y = v6;
				//     BoundsVolume = HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::_GetBoundsVolume(this, &v14, 0LL);
				//     v8 = *(_QWORD *)&this.fields.bounds.m_Extents.y;
				//     *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&this.fields.bounds.m_Center.x;
				//     *(_QWORD *)&v14.m_Extents.y = v8;
				//     return BoundsVolume - HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::_GetBoundsVolume(this, &v14, 0LL);
				//   }
				// }
				// 
				return 0f;
			}

			public bool ReplaceChild(HGRuntimeGrassQuery.Node oldChild, HGRuntimeGrassQuery.Node newChild)
			{
				// // Boolean ReplaceChild(HGRuntimeGrassQuery+Node, HGRuntimeGrassQuery+Node)
				// bool HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ReplaceChild(
				//         HGRuntimeGrassQuery_Node *this,
				//         HGRuntimeGrassQuery_Node *oldChild,
				//         HGRuntimeGrassQuery_Node *newChild,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
				//   PassConstructorID__Enum__Array *v9; // r8
				//   HGCamera *v10; // r9
				//   HGRuntimeGrassQuery_Node **p_left; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   MethodInfo *v15; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v16; // [rsp+28h] [rbp-10h]
				// 
				//   result = IFix::WrappersManagerImpl::IsPatched(2202, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v14, v13);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
				//              (ILFixDynamicMethodWrapper_20 *)Patch,
				//              (Object *)this,
				//              (Object *)oldChild,
				//              (Object *)newChild,
				//              0LL);
				//   }
				//   else
				//   {
				//     if ( this.fields.left == oldChild )
				//     {
				//       this.fields.left = newChild;
				//       p_left = &this.fields.left;
				//     }
				//     else
				//     {
				//       if ( this.fields.right != oldChild )
				//         return result;
				//       this.fields.right = newChild;
				//       p_left = &this.fields.right;
				//     }
				//     sub_1800054D0((HGRenderPathScene *)p_left, v8, v9, v10, v15, v16);
				//     return 1;
				//   }
				// }
				// 
				return default(bool);
			}

			public HGRuntimeGrassQuery.Node FindSibling()
			{
				// // HGRuntimeGrassQuery+Node FindSibling()
				// HGRuntimeGrassQuery_Node *HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::FindSibling(
				//         HGRuntimeGrassQuery_Node *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   HGRuntimeGrassQuery_Node *parent; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2206, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2206, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_802(Patch, (Object *)this, 0LL);
				// LABEL_7:
				//     sub_180B536AC(parent, v3);
				//   }
				//   parent = this.fields.parent;
				//   if ( !parent )
				//     goto LABEL_7;
				//   if ( parent.fields.left == this )
				//     return parent.fields.right;
				//   else
				//     return parent.fields.left;
				// }
				// 
				return null;
			}

			private float _GetBoundsVolume(Bounds b)
			{
				// // Single _GetBoundsVolume(Bounds)
				// float HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::_GetBoundsVolume(
				//         HGRuntimeGrassQuery_Node *this,
				//         Bounds *b,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   __int64 v9; // xmm1_8
				//   Bounds v10; // [rsp+40h] [rbp-28h] BYREF
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2200, 0LL) )
				//     return (float)(COERCE_FLOAT(HIDWORD(*(_QWORD *)&b.m_Extents.x)) * COERCE_FLOAT(*(_QWORD *)&b.m_Extents.x))
				//          * b.m_Extents.z;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2200, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v8, v7);
				//   v9 = *(_QWORD *)&b.m_Extents.y;
				//   *(_OWORD *)&v10.m_Center.x = *(_OWORD *)&b.m_Center.x;
				//   *(_QWORD *)&v10.m_Extents.y = v9;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_804(Patch, (Object *)this, &v10, 0LL);
				// }
				// 
				return 0f;
			}

			public Bounds bounds;

			public HGRuntimeGrassQuery.Node parent;

			public HGRuntimeGrassQuery.Node left;

			public HGRuntimeGrassQuery.Node right;

			public Bounds[] grassInstanceBounds;
		}
	}
}
