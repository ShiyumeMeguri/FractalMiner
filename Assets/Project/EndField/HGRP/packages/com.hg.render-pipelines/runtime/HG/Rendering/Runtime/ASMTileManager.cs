using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class ASMTileManager
	{
		public ASMTileManager()
		{
			// // ASMTileManager()
			// void HG::Rendering::Runtime::ASMTileManager::ASMTileManager(ASMTileManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // r8
			//   __int64 v4; // r9
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   LRUCache *v8; // rax
			//   OneofDescriptorProto *v9; // rdx
			//   __int64 v10; // rcx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryVisual_ECSRangeVoxelInfo_ *v13; // rax
			//   Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *v14; // rdi
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   MethodInfo *methodc; // [rsp+20h] [rbp-20h]
			//   MethodInfo *methoda; // [rsp+20h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-20h]
			//   String *v21; // [rsp+28h] [rbp-18h]
			//   String *v22; // [rsp+28h] [rbp-18h]
			//   String *v23; // [rsp+28h] [rbp-18h]
			//   NativeArray_1_HG_Rendering_Runtime_ASMTile_ v24; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919E55 )
			//   {
			//     sub_18003C530(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LRUCache);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray);
			//     byte_18D919E55 = 1;
			//   }
			//   v24 = 0LL;
			//   Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::NativeArray(
			//     &v24,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::NativeArray);
			//   this.fields.m_cachedTiles = v24;
			//   v24 = 0LL;
			//   Unity::Collections::NativeArray<int>::NativeArray(
			//     (NativeArray_1_System_Int32_ *)&v24,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//   this.fields.m_calculateTileVisibilityJob_tileIndicies = (NativeArray_1_System_Int32_)v24;
			//   v24 = 0LL;
			//   Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray(
			//     (NativeArray_1_UnityEngine_Vector2_ *)&v24,
			//     5,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray);
			//   this.fields.m_frustumVerts = (NativeArray_1_UnityEngine_Vector2_)v24;
			//   v24 = 0LL;
			//   Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray(
			//     (NativeArray_1_UnityEngine_Vector2_ *)&v24,
			//     5,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray);
			//   this.fields.m_frustumVertsForIndirect = (NativeArray_1_UnityEngine_Vector2_)v24;
			//   this.fields.m_tilesThisFrame = (ASMTile__Array *)il2cpp_array_new_specific_0(
			//                                                       TypeInfo::HG::Rendering::Runtime::ASMTile[0],
			//                                                       256LL,
			//                                                       v3,
			//                                                       v4);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_tilesThisFrame,
			//     v5,
			//     v6,
			//     v7,
			//     (String__Array *)methodc,
			//     v21,
			//     (MethodInfo *)v24.m_Buffer);
			//   v8 = (LRUCache *)sub_180004920(TypeInfo::HG::Rendering::Runtime::LRUCache);
			//   if ( !v8
			//     || (this.fields.m_cachedTilesLRUCache = v8,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_cachedTilesLRUCache,
			//           v9,
			//           v11,
			//           v12,
			//           (String__Array *)methoda,
			//           v22,
			//           (MethodInfo *)v24.m_Buffer),
			//         v13 = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryVisual_ECSRangeVoxelInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>),
			//         (v14 = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)v13) == 0LL) )
			//   {
			//     sub_180B536AC(v10, v9);
			//   }
			//   System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RemoteFactoryVisual::ECSRangeVoxelInfo>::Dictionary(
			//     v13,
			//     MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Dictionary);
			//   this.fields.m_cachedTilesDict = v14;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_cachedTilesDict,
			//     v15,
			//     v16,
			//     v17,
			//     (String__Array *)methodb,
			//     v23,
			//     (MethodInfo *)v24.m_Buffer);
			//   v24 = 0LL;
			//   Unity::Collections::NativeArray<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeArray(
			//     (NativeArray_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ *)&v24,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>::NativeArray);
			//   this.fields.m_tempCachedTilesScore = (NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_)v24;
			//   v24 = 0LL;
			//   Unity::Collections::NativeArray<int>::NativeArray(
			//     (NativeArray_1_System_Int32_ *)&v24,
			//     256,
			//     Allocator__Enum_Persistent,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//   this.fields.m_tilesForRenderThisFrame = (NativeArray_1_System_Int32_)v24;
			// }
			// 
		}

		public void Initialize()
		{
			// // Void Initialize()
			// void HG::Rendering::Runtime::ASMTileManager::Initialize(ASMTileManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(436, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(436, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(this, 0LL);
			//   }
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::ASMTileManager::Dispose(ASMTileManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919E4B )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::Dispose);
			//     byte_18D919E4B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(528, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(528, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::Dispose);
			//     Unity::Collections::NativeArray<int>::Dispose(
			//       &this.fields.m_calculateTileVisibilityJob_tileIndicies,
			//       MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_frustumVerts,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_frustumVertsForIndirect,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::Dispose);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields.m_tempCachedTilesScore,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>::Dispose);
			//     Unity::Collections::NativeArray<int>::Dispose(
			//       &this.fields.m_tilesForRenderThisFrame,
			//       MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public ASMTile GetTile(Vector3Int key)
		{
			// // ASMTile GetTile(Vector3Int)
			// ASMTile *HG::Rendering::Runtime::ASMTileManager::GetTile(
			//         ASMTile *__return_ptr retstr,
			//         ASMTileManager *this,
			//         Vector3Int *key,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rcx
			//   int32_t v9; // eax
			//   int32_t v10; // eax
			//   int v11; // eax
			//   Void *m_Buffer; // rcx
			//   __m128i v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int64 v15; // rcx
			//   Void *v16; // rax
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   int32_t vtIndex; // eax
			//   ASMTile *v20; // rax
			//   int32_t m_Z; // eax
			//   Vector3Int v23; // [rsp+30h] [rbp-40h] BYREF
			//   ASMTile v24; // [rsp+40h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919E4C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item);
			//     byte_18D919E4C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1729, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1729, 0LL);
			//     if ( Patch )
			//     {
			//       m_Z = key.m_Z;
			//       *(_QWORD *)&v23.m_X = *(_QWORD *)&key.m_X;
			//       v23.m_Z = m_Z;
			//       v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_664(&v24, Patch, (Object *)this, &v23, 0LL);
			//       goto LABEL_13;
			//     }
			//     goto LABEL_11;
			//   }
			//   m_cachedTilesDict = this.fields.m_cachedTilesDict;
			//   if ( !m_cachedTilesDict )
			//     goto LABEL_11;
			//   v9 = key.m_Z;
			//   *(_QWORD *)&v23.m_X = *(_QWORD *)&key.m_X;
			//   v23.m_Z = v9;
			//   if ( !(unsigned __int8)sub_1804DC4F8(
			//                            m_cachedTilesDict,
			//                            &v23,
			//                            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
			//   {
			// LABEL_9:
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     v20 = (ASMTile *)sub_188796A38(&v24);
			// LABEL_13:
			//     v17 = *(_OWORD *)&v20.mins.x;
			//     v18 = *(_OWORD *)&v20.tileCoords.m_X;
			//     vtIndex = v20.vtIndex;
			//     goto LABEL_14;
			//   }
			//   m_cachedTilesDict = this.fields.m_cachedTilesDict;
			//   if ( !m_cachedTilesDict )
			// LABEL_11:
			//     sub_180B536AC(m_cachedTilesDict, Patch);
			//   v10 = key.m_Z;
			//   *(_QWORD *)&v23.m_X = *(_QWORD *)&key.m_X;
			//   v23.m_Z = v10;
			//   v11 = sub_1808368FC(m_cachedTilesDict, &v23);
			//   m_Buffer = this.fields.m_cachedTiles.m_Buffer;
			//   v13 = *(__m128i *)&m_Buffer[36 * v11 + 16];
			//   v14 = *(_OWORD *)&m_Buffer[36 * v11];
			//   v24.vtIndex = *(_DWORD *)&m_Buffer[36 * v11 + 32];
			//   *(_OWORD *)&v24.mins.x = v14;
			//   if ( !_mm_srli_si128(v13, 8).m128i_i8[4] )
			//     goto LABEL_9;
			//   v15 = 9LL * v11;
			//   v16 = this.fields.m_cachedTiles.m_Buffer;
			//   v17 = *(_OWORD *)&v16[4 * v15];
			//   v18 = *(_OWORD *)&v16[4 * v15 + 16];
			//   vtIndex = *(_DWORD *)&v16[4 * v15 + 32];
			// LABEL_14:
			//   *(_OWORD *)&retstr.mins.x = v17;
			//   *(_OWORD *)&retstr.tileCoords.m_X = v18;
			//   retstr.vtIndex = vtIndex;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public ASMTile GetTile(int cachedTileIndex)
		{
			// // ASMTile GetTile(Int32)
			// ASMTile *HG::Rendering::Runtime::ASMTileManager::GetTile(
			//         ASMTile *__return_ptr retstr,
			//         ASMTileManager *this,
			//         int32_t cachedTileIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdi
			//   Void *m_Buffer; // rax
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   int32_t vtIndex; // eax
			//   ASMTile *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   ASMTile v16; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   v5 = cachedTileIndex;
			//   if ( !byte_18D919E4D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     byte_18D919E4D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1730, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1730, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_665(&v16, Patch, (Object *)this, v5, 0LL);
			//     goto LABEL_10;
			//   }
			//   if ( (unsigned int)v5 > 0xFF )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     v11 = (ASMTile *)sub_188796A38(&v16);
			// LABEL_10:
			//     v8 = *(_OWORD *)&v11.mins.x;
			//     v9 = *(_OWORD *)&v11.tileCoords.m_X;
			//     vtIndex = v11.vtIndex;
			//     goto LABEL_11;
			//   }
			//   m_Buffer = this.fields.m_cachedTiles.m_Buffer;
			//   v8 = *(_OWORD *)&m_Buffer[36 * v5];
			//   v9 = *(_OWORD *)&m_Buffer[36 * v5 + 16];
			//   vtIndex = *(_DWORD *)&m_Buffer[36 * v5 + 32];
			// LABEL_11:
			//   *(_OWORD *)&retstr.mins.x = v8;
			//   *(_OWORD *)&retstr.tileCoords.m_X = v9;
			//   retstr.vtIndex = vtIndex;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void SetFrustumVerts(Vector2[] verts, Vector2[] vertsForIndirect)
		{
			// // Void SetFrustumVerts(Vector2[], Vector2[])
			// void HG::Rendering::Runtime::ASMTileManager::SetFrustumVerts(
			//         ASMTileManager *this,
			//         Vector2__Array *verts,
			//         Vector2__Array *vertsForIndirect,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdi
			//   int v10; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // [rsp+30h] [rbp-18h] BYREF
			//   __int64 v13; // [rsp+38h] [rbp-10h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1731, 0LL) )
			//   {
			//     v9 = 0LL;
			//     v10 = 0;
			//     if ( verts )
			//     {
			//       while ( 1 )
			//       {
			//         sub_18004E290(verts, &v12, v10);
			//         *(_QWORD *)&this.fields.m_frustumVerts.m_Buffer[v9] = v12;
			//         if ( !vertsForIndirect )
			//           break;
			//         sub_18004E290(vertsForIndirect, &v13, v10++);
			//         *(_QWORD *)&this.fields.m_frustumVertsForIndirect.m_Buffer[v9] = v13;
			//         v9 += 8LL;
			//         if ( v10 >= 5 )
			//           return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1731, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)verts,
			//     (Object *)vertsForIndirect,
			//     0LL);
			// }
			// 
		}

		public int GetValidTileCount()
		{
			// // Int32 GetValidTileCount()
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::Runtime::ASMTileManager::GetValidTileCount(ASMTileManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t v5; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3Int key; // [rsp+20h] [rbp-98h] BYREF
			//   Il2CppException *ex; // [rsp+30h] [rbp-88h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ *v12; // [rsp+38h] [rbp-80h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v13; // [rsp+40h] [rbp-78h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v14; // [rsp+68h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v15; // [rsp+90h] [rbp-28h] BYREF
			//   KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ current; // [rsp+98h] [rbp-20h] BYREF
			//   int value; // [rsp+D0h] [rbp+18h] BYREF
			//   int32_t v18; // [rsp+D8h] [rbp+20h]
			// 
			//   if ( !byte_18D919E4E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
			//     byte_18D919E4E = 1;
			//   }
			//   *(_QWORD *)&key.m_X = 0LL;
			//   key.m_Z = 0;
			//   value = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1732, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1732, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v5 = 0;
			//     v18 = 0;
			//     if ( !this.fields.m_cachedTilesDict )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)&v13,
			//       (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_cachedTilesDict,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     v14 = v13;
			//     ex = 0LL;
			//     v12 = &v14;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
			//                 &v14,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
			//       {
			//         current = (KeyValuePair_2_UnityEngine_Vector3Int_System_Single_)v14._current;
			//         System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::Deconstruct(
			//           &current,
			//           &key,
			//           (float *)&value,
			//           MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
			//         if ( _mm_srli_si128(*(__m128i *)((_QWORD)this[16LL] + 36LL * value + 16), 8).m128i_i8[4] )
			//           v18 = ++v5;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       ex = v15.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       return v18;
			//     }
			//     return v5;
			//   }
			// }
			// 
			return 0;
		}

		public int GetRenderedTileCount()
		{
			// // Int32 GetRenderedTileCount()
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::Runtime::ASMTileManager::GetRenderedTileCount(ASMTileManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t v5; // ebx
			//   Void *m_Buffer; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Vector3Int key; // [rsp+20h] [rbp-98h] BYREF
			//   Il2CppException *ex; // [rsp+30h] [rbp-88h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ *v13; // [rsp+38h] [rbp-80h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v14; // [rsp+40h] [rbp-78h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v15; // [rsp+68h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v16; // [rsp+90h] [rbp-28h] BYREF
			//   KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ current; // [rsp+98h] [rbp-20h] BYREF
			//   int value; // [rsp+D0h] [rbp+18h] BYREF
			//   int32_t v19; // [rsp+D8h] [rbp+20h]
			// 
			//   if ( !byte_18D919E4F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
			//     byte_18D919E4F = 1;
			//   }
			//   *(_QWORD *)&key.m_X = 0LL;
			//   key.m_Z = 0;
			//   value = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1733, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1733, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v5 = 0;
			//     v19 = 0;
			//     if ( !this.fields.m_cachedTilesDict )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)&v14,
			//       (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this.fields.m_cachedTilesDict,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     v15 = v14;
			//     ex = 0LL;
			//     v13 = &v15;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
			//                 &v15,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
			//       {
			//         current = (KeyValuePair_2_UnityEngine_Vector3Int_System_Single_)v15._current;
			//         System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::Deconstruct(
			//           &current,
			//           &key,
			//           (float *)&value,
			//           MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
			//         m_Buffer = this.fields.m_cachedTiles.m_Buffer;
			//         if ( (unsigned __int8)BYTE4(*(_QWORD *)&m_Buffer[36 * value + 24]) )
			//         {
			//           if ( (unsigned __int16)WORD2(*(_QWORD *)&m_Buffer[36 * value + 24]) >> 8 )
			//             v19 = ++v5;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v16 )
			//     {
			//       ex = v16.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       return v19;
			//     }
			//     return v5;
			//   }
			// }
			// 
			return 0;
		}

		public void InvalidateAllTiles()
		{
			// // Void InvalidateAllTiles()
			// void HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(ASMTileManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rcx
			//   int32_t v5; // esi
			//   __int64 v6; // rdi
			//   __int64 v7; // rax
			//   __int128 v8; // xmm0
			//   int v9; // ecx
			//   __int128 v10; // xmm1
			//   Void *m_Buffer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v13[56]; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919E50 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear);
			//     byte_18D919E50 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(437, 0LL) )
			//   {
			//     m_cachedTilesDict = this.fields.m_cachedTilesDict;
			//     if ( m_cachedTilesDict )
			//     {
			//       System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear(
			//         m_cachedTilesDict,
			//         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear);
			//       this.fields.m_renderCountThisFrame = 0;
			//       v5 = 0;
			//       if ( this.fields.m_cachedTiles.m_Length > 0 )
			//       {
			//         v6 = 0LL;
			//         do
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//           v7 = sub_188796A38(v13);
			//           ++v5;
			//           v8 = *(_OWORD *)v7;
			//           v9 = *(_DWORD *)(v7 + 32);
			//           v10 = *(_OWORD *)(v7 + 16);
			//           m_Buffer = this.fields.m_cachedTiles.m_Buffer;
			//           *(_OWORD *)&m_Buffer[v6] = v8;
			//           *(_OWORD *)&m_Buffer[v6 + 16] = v10;
			//           *(_DWORD *)&m_Buffer[v6 + 32] = v9;
			//           v6 += 36LL;
			//         }
			//         while ( v5 < this.fields.m_cachedTiles.m_Length );
			//       }
			//       m_cachedTilesDict = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)this.fields.m_cachedTilesLRUCache;
			//       if ( m_cachedTilesDict )
			//       {
			//         HG::Rendering::Runtime::LRUCache::Reset((LRUCache *)m_cachedTilesDict, 128, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(m_cachedTilesDict, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(437, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void CreateTilesThisFrame(Vector2 centerPoint, float radius, float gridSize)
		{
			// // Void CreateTilesThisFrame(Vector2, Single, Single)
			// void HG::Rendering::Runtime::ASMTileManager::CreateTilesThisFrame(
			//         ASMTileManager *this,
			//         Vector2 centerPoint,
			//         float radius,
			//         float gridSize,
			//         MethodInfo *method)
			// {
			//   char v7; // dl
			//   __int64 v8; // rcx
			//   int v9; // r8d
			//   int32_t v10; // esi
			//   int32_t v11; // r15d
			//   char v12; // dl
			//   __int64 v13; // rcx
			//   int v14; // r8d
			//   int32_t v15; // r14d
			//   int32_t v16; // ebp
			//   int32_t i; // ebx
			//   double v18; // xmm0_8
			//   __int64 v19; // rcx
			//   ASMTile__Array *m_tilesThisFrame; // rdx
			//   __int64 m_tilesThisFrameCount; // rax
			//   __int64 v22; // rcx
			//   int32_t vtIndex; // eax
			//   __int128 v24; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v26; // [rsp+38h] [rbp-90h]
			//   __int64 v27; // [rsp+40h] [rbp-88h] BYREF
			//   ASMTile v28; // [rsp+48h] [rbp-80h] BYREF
			// 
			//   if ( !byte_18D919E51 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     byte_18D919E51 = 1;
			//   }
			//   memset(&v28, 0, sizeof(v28));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1734, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1734, 0LL);
			//     if ( !Patch )
			// LABEL_16:
			//       sub_180B536AC(v19, m_tilesThisFrame);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_666(Patch, (Object *)this, centerPoint, radius, gridSize, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_tilesThisFrameCount = 0;
			//     v10 = sub_182592070(v8, v7, v9) - 1;
			//     v11 = sub_1826E82D0() + 1;
			//     v15 = sub_182592070(v13, v12, v14) - 1;
			//     v16 = sub_1826E82D0() + 1;
			//     while ( v10 <= v11 )
			//     {
			//       for ( i = v15; i <= v16; ++i )
			//       {
			//         *((float *)&v26 + 1) = (float)((float)i + 0.5) * gridSize;
			//         *(float *)&v26 = (float)((float)v10 + 0.5) * gridSize;
			//         v27 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(v26, centerPoint);
			//         v18 = sub_182413570(&v27);
			//         if ( radius > (float)(*(float *)&v18 - (float)(gridSize * 0.80000001)) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//           HG::Rendering::Runtime::ASMTile::ASMTile(&v28, v10, i, 0, gridSize, 0LL);
			//           m_tilesThisFrame = this.fields.m_tilesThisFrame;
			//           if ( !m_tilesThisFrame )
			//             goto LABEL_16;
			//           m_tilesThisFrameCount = this.fields.m_tilesThisFrameCount;
			//           if ( (unsigned int)m_tilesThisFrameCount >= m_tilesThisFrame.max_length.size )
			//             sub_180070270(v19, m_tilesThisFrame);
			//           v22 = m_tilesThisFrameCount;
			//           vtIndex = v28.vtIndex;
			//           v24 = *(_OWORD *)&v28.tileCoords.m_X;
			//           *(_OWORD *)&m_tilesThisFrame.vector[v22].mins.x = *(_OWORD *)&v28.mins.x;
			//           *(_OWORD *)&m_tilesThisFrame.vector[v22].tileCoords.m_X = v24;
			//           m_tilesThisFrame.vector[v22].vtIndex = vtIndex;
			//           ++this.fields.m_tilesThisFrameCount;
			//         }
			//       }
			//       ++v10;
			//     }
			//   }
			// }
			// 
		}

		public void UpdateCachedTiles(Vector2 centerPoint, float radius)
		{
			// // Void UpdateCachedTiles(Vector2, Single)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::ASMTileManager::UpdateCachedTiles(
			//         ASMTileManager *this,
			//         Vector2 centerPoint,
			//         float radius,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm6_4
			//   ASMTileManager *v5; // rsi
			//   Vector2 v6; // xmm7_8
			//   ASMTileManager *v7; // r14
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int v10; // edi
			//   Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *Values; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *v14; // rbx
			//   int32_t m_Length; // r15d
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   int32_t Count; // eax
			//   NativeArray_1_HG_Rendering_Runtime_ASMTile_ m_cachedTiles; // xmm1
			//   NativeArray_1_System_Int32_ m_calculateTileVisibilityJob_tileIndicies; // xmm2
			//   NativeArray_1_UnityEngine_Vector2_ m_frustumVerts; // xmm3
			//   ASMTile__Array *vtIndex; // rdx
			//   LRUCache *m_tilesThisFrame; // rcx
			//   __int64 v24; // r8
			//   LRUCache *m_cachedTilesLRUCache; // rcx
			//   int32_t v26; // r14d
			//   int32_t v27; // eax
			//   int32_t v28; // edi
			//   ValueTuple_2_Int32_Int32_ v29; // rax
			//   ValueTuple_2_Int32_Int32_ v30; // r8
			//   ValueTuple_2_Int32_Int32_ v31; // r9
			//   int32_t Item1; // ebx
			//   Vector3Int *v33; // rax
			//   __int64 v34; // xmm6_8
			//   int32_t m_Z; // r15d
			//   __int64 Item; // rdi
			//   __int64 v37; // rax
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int64 v40; // rcx
			//   Void *m_Buffer; // rax
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int64 v44; // rcx
			//   Void *v45; // rax
			//   Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rdi
			//   __int64 v47; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   __int64 v51; // [rsp+0h] [rbp-1C8h] BYREF
			//   Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v52; // [rsp+30h] [rbp-198h] BYREF
			//   Vector3Int v53; // [rsp+50h] [rbp-178h] BYREF
			//   Vector3Int v54; // [rsp+60h] [rbp-168h] BYREF
			//   Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v55; // [rsp+70h] [rbp-158h] BYREF
			//   JobHandle v56; // [rsp+90h] [rbp-138h] BYREF
			//   Vector2 v57; // [rsp+A0h] [rbp-128h]
			//   Vector3Int v58; // [rsp+B0h] [rbp-118h] BYREF
			//   Vector3Int v59; // [rsp+C0h] [rbp-108h] BYREF
			//   Vector3Int v60; // [rsp+D0h] [rbp-F8h] BYREF
			//   JobHandle v61; // [rsp+E0h] [rbp-E8h] BYREF
			//   ASMTileManager_CalculateTileVisibilities v62; // [rsp+F0h] [rbp-D8h] BYREF
			//   Il2CppExceptionWrapper *v63; // [rsp+130h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v64; // [rsp+138h] [rbp-90h] BYREF
			//   ASMTile v65; // [rsp+140h] [rbp-88h] BYREF
			//   __int128 v66; // [rsp+170h] [rbp-58h]
			// 
			//   v4 = radius;
			//   v5 = this;
			//   v6 = centerPoint;
			//   v57 = centerPoint;
			//   v7 = this;
			//   *(_QWORD *)&v54.m_X = this;
			//   if ( !byte_18D919E52 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ArrayExtensions::ResizeArray<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Values);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::get_Current);
			//     sub_18003C530(&MethodInfo::Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::get_Count);
			//     byte_18D919E52 = 1;
			//   }
			//   v61 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1735, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1735, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v50, v49);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_668(Patch, (Object *)v5, v6, radius, 0LL);
			//   }
			//   else
			//   {
			//     v10 = 0;
			//     if ( !v5.fields.m_cachedTilesDict )
			//       sub_180B536AC(v9, v8);
			//     Values = System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Values(
			//                (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v5.fields.m_cachedTilesDict,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Values);
			//     v14 = Values;
			//     *(_QWORD *)&v53.m_X = Values;
			//     if ( !Values )
			//       sub_180B536AC(v13, v12);
			//     m_Length = v5.fields.m_calculateTileVisibilityJob_tileIndicies.m_Length;
			//     if ( m_Length < System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Count(
			//                       Values,
			//                       MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::get_Count) )
			//     {
			//       if ( !v14 )
			//         sub_180B536AC(v17, v16);
			//       Count = System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Count(
			//                 v14,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::get_Count);
			//       UnityEngine::Rendering::ArrayExtensions::ResizeArray<int>(
			//         &v5.fields.m_calculateTileVisibilityJob_tileIndicies,
			//         Count,
			//         Allocator__Enum_Persistent,
			//         MethodInfo::UnityEngine::Rendering::ArrayExtensions::ResizeArray<int>);
			//     }
			//     if ( !v14 )
			//       sub_180B536AC(v17, v16);
			//     System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)&v52,
			//       (Dictionary_2_TKey_TValue_ValueCollection_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)v14,
			//       MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     v55 = v52;
			//     v52._dictionary = 0LL;
			//     *(_QWORD *)&v52._index = &v55;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
			//                 &v55,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
			//         *(_DWORD *)&v5.fields.m_calculateTileVisibilityJob_tileIndicies.m_Buffer[4 * v10++] = v55._currentValue;
			//     }
			//     catch ( Il2CppExceptionWrapper *v63 )
			//     {
			//       v52._dictionary = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)v63.ex;
			//       if ( v52._dictionary )
			//         sub_18000F780(v52._dictionary);
			//       v4 = radius;
			//       v6 = v57;
			//       v5 = this;
			//       v14 = *(Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ **)&v53.m_X;
			//       v7 = *(ASMTileManager **)&v54.m_X;
			//     }
			//     sub_1802F01E0(&v65, 0LL, 64LL);
			//     m_cachedTiles = v5.fields.m_cachedTiles;
			//     m_calculateTileVisibilityJob_tileIndicies = v5.fields.m_calculateTileVisibilityJob_tileIndicies;
			//     m_frustumVerts = v5.fields.m_frustumVerts;
			//     *(Vector2 *)((char *)&v66 + 4) = v6;
			//     *((float *)&v66 + 3) = v4;
			//     LODWORD(v66) = v7.fields.m_cachedTiles.m_Length;
			//     *(_OWORD *)&v52._dictionary = 0LL;
			//     v62.cachedTiles = m_cachedTiles;
			//     v62.tileIndices = m_calculateTileVisibilityJob_tileIndicies;
			//     v62.frustumVerts = m_frustumVerts;
			//     *(_OWORD *)&v62.count = v66;
			//     Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>(
			//       &v56,
			//       &v62,
			//       (JobHandle *)&v52,
			//       MethodInfo::Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>);
			//     v61 = v56;
			//     Unity::Jobs::JobHandle::Complete(&v61, 0LL);
			//     if ( !v14 )
			//       goto LABEL_53;
			//     System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)&v52,
			//       (Dictionary_2_TKey_TValue_ValueCollection_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)v14,
			//       MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     v55 = v52;
			//     v52._dictionary = 0LL;
			//     *(_QWORD *)&v52._index = &v55;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
			//                 &v55,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
			//       {
			//         if ( _mm_srli_si128(*(__m128i *)((_QWORD)v5[16LL] + 36LL * *(int *)(&v55 + 16) + 16), 8).m128i_i8[6] )
			//         {
			//           m_cachedTilesLRUCache = v5.fields.m_cachedTilesLRUCache;
			//           if ( !m_cachedTilesLRUCache )
			//             sub_1802DC2C8(0LL, v55._currentValue);
			//           HG::Rendering::Runtime::LRUCache::Visit(m_cachedTilesLRUCache, v55._currentValue, 0LL);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v64 )
			//     {
			//       vtIndex = (ASMTile__Array *)&v51;
			//       v52._dictionary = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)v64.ex;
			//       if ( v52._dictionary )
			//         sub_18000F780(v52._dictionary);
			//       v5 = this;
			//     }
			//     v26 = 0;
			//     if ( v5.fields.m_tilesThisFrameCount > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         m_tilesThisFrame = (LRUCache *)v5.fields.m_tilesThisFrame;
			//         if ( !m_tilesThisFrame )
			//           break;
			//         v54 = *(Vector3Int *)(sub_180410DF0(m_tilesThisFrame, v26, v24) + 16);
			//         if ( !_mm_srli_si128((__m128i)HG::Rendering::Runtime::ASMTileManager::GetTile(&v65, v5, &v54, 0LL)[16LL], 8).m128i_i8[4] )
			//         {
			//           m_tilesThisFrame = (LRUCache *)v5.fields.m_tilesThisFrame;
			//           if ( !m_tilesThisFrame )
			//             break;
			//           v53 = *(Vector3Int *)(sub_180410DF0(m_tilesThisFrame, v26, v24) + 16);
			//           v27 = HG::Rendering::Runtime::ASMUtils::TileCoordsToKey(&v53, 0LL);
			//           v28 = v27;
			//           m_tilesThisFrame = v5.fields.m_cachedTilesLRUCache;
			//           if ( !m_tilesThisFrame )
			//             break;
			//           v29 = HG::Rendering::Runtime::LRUCache::Allocate(m_tilesThisFrame, v27, 0LL);
			//           Item1 = v29.Item1;
			//           if ( v29.Item2 != -1 && v29.Item2 != v28 )
			//           {
			//             v33 = HG::Rendering::Runtime::ASMUtils::KeyToTileCoords((Vector3Int *)&v52, v29.Item2, 0LL);
			//             v34 = *(_QWORD *)&v33.m_X;
			//             m_Z = v33.m_Z;
			//             m_tilesThisFrame = (LRUCache *)v5.fields.m_cachedTilesDict;
			//             if ( !m_tilesThisFrame )
			//               break;
			//             *(_QWORD *)&v58.m_X = *(_QWORD *)&v33.m_X;
			//             v58.m_Z = m_Z;
			//             if ( System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey(
			//                    (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_tilesThisFrame,
			//                    &v58,
			//                    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
			//             {
			//               m_tilesThisFrame = (LRUCache *)v5.fields.m_cachedTilesDict;
			//               if ( !m_tilesThisFrame )
			//                 break;
			//               *(_QWORD *)&v59.m_X = v34;
			//               v59.m_Z = m_Z;
			//               Item = System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item(
			//                        (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_tilesThisFrame,
			//                        &v59,
			//                        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//               v37 = sub_188796A38(&v65);
			//               v38 = *(_OWORD *)v37;
			//               v39 = *(_OWORD *)(v37 + 16);
			//               vtIndex = (ASMTile__Array *)*(unsigned int *)(v37 + 32);
			//               v40 = 9 * Item;
			//               m_Buffer = v5.fields.m_cachedTiles.m_Buffer;
			//               *(_OWORD *)&m_Buffer[4 * v40] = v38;
			//               *(_OWORD *)&m_Buffer[4 * v40 + 16] = v39;
			//               *(_DWORD *)&m_Buffer[4 * v40 + 32] = (_DWORD)vtIndex;
			//               m_tilesThisFrame = (LRUCache *)v5.fields.m_cachedTilesDict;
			//               if ( !m_tilesThisFrame )
			//                 break;
			//               *(_QWORD *)&v60.m_X = v34;
			//               v60.m_Z = m_Z;
			//               System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove(
			//                 (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_tilesThisFrame,
			//                 &v60,
			//                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove);
			//             }
			//           }
			//           vtIndex = v5.fields.m_tilesThisFrame;
			//           if ( !vtIndex )
			//             break;
			//           if ( (unsigned int)v26 >= vtIndex.max_length.size )
			//             ((void (__fastcall __noreturn *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_180070260)(
			//               m_tilesThisFrame,
			//               vtIndex,
			//               v30,
			//               v31);
			//           v42 = *(_OWORD *)&vtIndex.vector[v26].mins.x;
			//           v43 = *(_OWORD *)&vtIndex.vector[v26].tileCoords.m_X;
			//           vtIndex = (ASMTile__Array *)(unsigned int)vtIndex.vector[v26].vtIndex;
			//           v44 = 9LL * Item1;
			//           v45 = v5.fields.m_cachedTiles.m_Buffer;
			//           *(_OWORD *)&v45[4 * v44] = v42;
			//           *(_OWORD *)&v45[4 * v44 + 16] = v43;
			//           *(_DWORD *)&v45[4 * v44 + 32] = (_DWORD)vtIndex;
			//           m_cachedTilesDict = v5.fields.m_cachedTilesDict;
			//           m_tilesThisFrame = (LRUCache *)v5.fields.m_tilesThisFrame;
			//           if ( !m_tilesThisFrame )
			//             break;
			//           v47 = ((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_180410DF0)(m_tilesThisFrame, v26, v30);
			//           if ( !m_cachedTilesDict )
			//             break;
			//           v56 = *(JobHandle *)(v47 + 16);
			//           System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::set_Item(
			//             m_cachedTilesDict,
			//             (Vector3Int *)&v56,
			//             Item1,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::set_Item);
			//         }
			//         if ( ++v26 >= v5.fields.m_tilesThisFrameCount )
			//           return;
			//       }
			// LABEL_53:
			//       sub_1802DC2C8(m_tilesThisFrame, vtIndex);
			//     }
			//   }
			// }
			// 
		}

		public void PreRenderTiles(HGASMVirtualTextureAllocator vtAllocator, Vector2 frustumCenterPos, int maxRenderCount, int startVTIdx)
		{
			// // Void PreRenderTiles(HGASMVirtualTextureAllocator, Vector2, Int32, Int32)
			// void HG::Rendering::Runtime::ASMTileManager::PreRenderTiles(
			//         ASMTileManager *this,
			//         HGASMVirtualTextureAllocator *vtAllocator,
			//         Vector2 frustumCenterPos,
			//         int32_t maxRenderCount,
			//         int32_t startVTIdx,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_HG_Rendering_Runtime_ASMTile_ m_cachedTiles; // xmm2
			//   NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ m_tempCachedTilesScore; // xmm3
			//   NativeArray_1_UnityEngine_Vector2_ m_frustumVerts; // xmm1
			//   __int64 v13; // r8
			//   __int64 v14; // r9
			//   int v15; // edi
			//   __int64 v16; // rdx
			//   int v17; // eax
			//   int32_t v18; // esi
			//   __int64 v19; // rdi
			//   bool v20; // zf
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v22; // r14
			//   __int64 v23; // rdx
			//   NativeArray_1_HG_Rendering_Runtime_ASMTile_ v24; // xmm0
			//   __m128i v25; // xmm6
			//   Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rcx
			//   Void *m_Buffer; // rax
			//   int v28; // edx
			//   __int128 v29; // xmm1
			//   __int64 v30; // rcx
			//   __int128 v31; // xmm0
			//   __int64 v32; // rax
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   JobHandle v35; // [rsp+48h] [rbp-C0h] BYREF
			//   NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v36; // [rsp+58h] [rbp-B0h] BYREF
			//   NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v37; // [rsp+68h] [rbp-A0h] BYREF
			//   _BYTE v38[16]; // [rsp+78h] [rbp-90h] BYREF
			//   __int128 v39; // [rsp+88h] [rbp-80h]
			//   __int128 v40; // [rsp+A8h] [rbp-60h]
			//   ASMTileManager_CalculateTileScoresJob v41; // [rsp+B8h] [rbp-50h] BYREF
			//   JobHandle v42; // [rsp+F8h] [rbp-10h] BYREF
			//   NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v43; // [rsp+108h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D919E53 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>>::Schedule);
			//     byte_18D919E53 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1738, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1738, 0LL);
			//     if ( !Patch )
			// LABEL_23:
			//       sub_180B536AC(Patch, v23);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_670(
			//       Patch,
			//       (Object *)this,
			//       (Object *)vtAllocator,
			//       frustumCenterPos,
			//       maxRenderCount,
			//       startVTIdx,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_1802F01E0(v38, 0LL, 64LL);
			//     m_cachedTiles = this.fields.m_cachedTiles;
			//     m_tempCachedTilesScore = this.fields.m_tempCachedTilesScore;
			//     LODWORD(v40) = 256;
			//     m_frustumVerts = this.fields.m_frustumVerts;
			//     *(Vector2 *)((char *)&v40 + 4) = frustumCenterPos;
			//     v37 = 0LL;
			//     v36 = 0LL;
			//     *(_OWORD *)&v41.count = v40;
			//     v41.cachedTiles = m_cachedTiles;
			//     v41.frustumVerts = m_frustumVerts;
			//     v41.cachedTilesScore = m_tempCachedTilesScore;
			//     Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>(
			//       &v35,
			//       &v41,
			//       (JobHandle *)&v36,
			//       MethodInfo::Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>);
			//     v42 = v35;
			//     Unity::Jobs::JobHandle::Complete(&v42, 0LL);
			//     v36 = this.fields.m_tempCachedTilesScore;
			//     Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>(
			//       (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v35,
			//       (NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v36,
			//       MethodInfo::Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>);
			//     v36 = v37;
			//     Unity::Collections::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>>::Schedule(
			//       (JobHandle *)&v43,
			//       (SortJob_2_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ *)&v35,
			//       (JobHandle *)&v36,
			//       MethodInfo::Unity::Collections::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>>::Schedule);
			//     v37 = v43;
			//     Unity::Jobs::JobHandle::Complete((JobHandle *)&v37, 0LL);
			//     v13 = 0LL;
			//     v14 = 0LL;
			//     v15 = 0;
			//     v16 = 0LL;
			//     do
			//     {
			//       if ( _mm_srli_si128(*(__m128i *)(v16 + (_QWORD)this[16LL] + 16), 8).m128i_i8[4]
			//         && !_mm_srli_si128(*(__m128i *)(v16 + (_QWORD)this[16LL] + 16), 8).m128i_i8[5] )
			//       {
			//         ++v15;
			//       }
			//       v16 += 36LL;
			//       v17 = *(_DWORD *)&this.fields.m_tempCachedTilesScore.m_Buffer[v14];
			//       v14 += 8LL;
			//       *(_DWORD *)&this.fields.m_tilesForRenderThisFrame.m_Buffer[v13] = v17;
			//       v13 += 4LL;
			//     }
			//     while ( v16 < 9216 );
			//     sub_180002C70(TypeInfo::System::Math);
			//     if ( maxRenderCount <= v15 )
			//       v15 = maxRenderCount;
			//     v18 = 0;
			//     this.fields.m_renderCountThisFrame = v15;
			//     if ( v15 > 0 )
			//     {
			//       v19 = 0LL;
			//       do
			//       {
			//         v20 = this.fields.m_cachedTilesDict == 0LL;
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_cachedTiles.m_Buffer;
			//         v22 = *(int *)&this.fields.m_tilesForRenderThisFrame.m_Buffer[v19];
			//         v23 = 9 * v22;
			//         v24 = *(NativeArray_1_HG_Rendering_Runtime_ASMTile_ *)((char *)&Patch.klass + 36 * v22);
			//         v25 = *(__m128i *)((char *)&Patch.fields.virtualMachine + 36 * v22);
			//         LODWORD(v41.cachedTilesScore.m_Buffer) = *((_DWORD *)&Patch.fields.anonObj + 9 * v22);
			//         v41.cachedTiles = v24;
			//         if ( v20 )
			//           goto LABEL_23;
			//         m_cachedTilesDict = this.fields.m_cachedTilesDict;
			//         v35.jobGroup = v25.m128i_i64[0];
			//         v35.jobType = _mm_cvtsi128_si32(_mm_srli_si128(v25, 8));
			//         if ( (unsigned __int8)sub_1804DC4F8(
			//                                 m_cachedTilesDict,
			//                                 &v35,
			//                                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
			//         {
			//           if ( !vtAllocator )
			//             goto LABEL_23;
			//           v36.m_Buffer = (Void *)v25.m128i_i64[0];
			//           v36.m_Length = _mm_cvtsi128_si32(_mm_srli_si128(v25, 8));
			//           if ( !HG::Rendering::Runtime::HGASMVirtualTextureAllocator::AllocateTile(
			//                   vtAllocator,
			//                   this,
			//                   (Vector3Int *)&v36,
			//                   startVTIdx,
			//                   0LL) )
			//             goto LABEL_20;
			//           m_Buffer = this.fields.m_cachedTiles.m_Buffer;
			//           v28 = *(_DWORD *)&m_Buffer[36 * v22 + 32];
			//           v29 = *(_OWORD *)&m_Buffer[36 * v22];
			//           v30 = 9 * v22;
			//           v39 = *(_OWORD *)&m_Buffer[36 * v22 + 16];
			//           BYTE13(v39) = 1;
			//           v31 = v39;
			//           *(_OWORD *)&m_Buffer[4 * v30] = v29;
			//           *(_OWORD *)&m_Buffer[4 * v30 + 16] = v31;
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//           v32 = sub_188796A38(&v41);
			//           v30 = 9 * v22;
			//           v33 = *(_OWORD *)v32;
			//           v28 = *(_DWORD *)(v32 + 32);
			//           v34 = *(_OWORD *)(v32 + 16);
			//           m_Buffer = this.fields.m_cachedTiles.m_Buffer;
			//           *(_OWORD *)&m_Buffer[4 * v30] = v33;
			//           *(_OWORD *)&m_Buffer[4 * v30 + 16] = v34;
			//         }
			//         *(_DWORD *)&m_Buffer[4 * v30 + 32] = v28;
			// LABEL_20:
			//         ++v18;
			//         v19 += 4LL;
			//       }
			//       while ( v18 < this.fields.m_renderCountThisFrame );
			//     }
			//   }
			// }
			// 
		}

		public int GetTileRenderCountThisFrame()
		{
			// // Int32 GetTileRenderCountThisFrame()
			// int32_t HG::Rendering::Runtime::ASMTileManager::GetTileRenderCountThisFrame(ASMTileManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1740, 0LL) )
			//     return this.fields.m_renderCountThisFrame;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1740, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public int GetTilesForRender(out NativeArray<int> tilesForRenderThisFrame)
		{
			// // Int32 GetTilesForRender(NativeArray`1[System.Int32] ByRef)
			// int32_t HG::Rendering::Runtime::ASMTileManager::GetTilesForRender(
			//         ASMTileManager *this,
			//         NativeArray_1_System_Int32_ *tilesForRenderThisFrame,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1741, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1741, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_671(Patch, (Object *)this, tilesForRenderThisFrame, 0LL);
			//   }
			//   else
			//   {
			//     *tilesForRenderThisFrame = this.fields.m_tilesForRenderThisFrame;
			//     return this.fields.m_renderCountThisFrame;
			//   }
			// }
			// 
			return 0;
		}

		public void GenerateIndirectData(float gridSize, int startVTIndex, int gridCountX, int gridCountY, float asmRadius, ref Matrix4x4[] worldToShadowMatrices, out Matrix4x4 baseWorldToShadowMatrix, out Vector2 indexRegionMins, out Vector2 indexRegionMaxs, out int indirectWidth, out int indirectHeight)
		{
			// // Void GenerateIndirectData(Single, Int32, Int32, Int32, Single, Matrix4x4[] ByRef, Matrix4x4 ByRef, Vector2 ByRef, Vector2 ByRef, Int32 ByRef, Int32 ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ASMTileManager::GenerateIndirectData(
			//         ASMTileManager *this,
			//         float gridSize,
			//         int32_t startVTIndex,
			//         int32_t gridCountX,
			//         int32_t gridCountY,
			//         float asmRadius,
			//         Matrix4x4__Array **worldToShadowMatrices,
			//         Matrix4x4 *baseWorldToShadowMatrix,
			//         Vector2 *indexRegionMins,
			//         Vector2 *indexRegionMaxs,
			//         int32_t *indirectWidth,
			//         int32_t *indirectHeight,
			//         MethodInfo *method)
			// {
			//   float v15; // xmm13_4
			//   ASMTileManager *v16; // r15
			//   _OWORD *v17; // rax
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm2
			//   __int128 v20; // xmm3
			//   int v21; // r14d
			//   int v22; // r12d
			//   int v23; // edi
			//   int v24; // esi
			//   __int128 v25; // xmm12
			//   __m128i v26; // xmm14
			//   __m128 teamId; // xmm6
			//   __m128 chunkNo; // xmm7
			//   __m128 startIndex; // xmm8
			//   __m128 dataLength; // xmm10
			//   NativeArray_1_UnityEngine_Vector2_ m_frustumVertsForIndirect; // xmm11
			//   bool IsPatched; // al
			//   __int64 v33; // rdx
			//   char v34; // r8
			//   char v35; // r9
			//   char v36; // r10
			//   char v37; // cl
			//   Void *m_Buffer; // r15
			//   float v39; // xmm0_4
			//   int v40; // r13d
			//   unsigned __int64 v41; // xmm15_8
			//   int v42; // ecx
			//   __m128 v43; // xmm1
			//   __m128 v44; // xmm2
			//   unsigned __int64 v45; // xmm11_8
			//   Vector3Int *v46; // r8
			//   ITilemap *v47; // r9
			//   float v48; // xmm7_4
			//   float v49; // xmm6_4
			//   __int128 v50; // xmm8
			//   __int128 v51; // xmm10
			//   int i; // r14d
			//   float v53; // xmm12_4
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm0
			//   ILFixDynamicMethodWrapper_2 *v56; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   Void *v59; // rax
			//   __m128 v60; // xmm1
			//   int v61; // ecx
			//   __m128 v62; // xmm9
			//   int32_t v63; // edi
			//   int32_t v64; // esi
			//   __m128 v65; // xmm2
			//   __m128 v66; // xmm3
			//   __m128 v67; // xmm0
			//   __m128 v68; // xmm1
			//   int32_t v69; // r13d
			//   int v70; // r15d
			//   int v71; // r12d
			//   __int64 v72; // r14
			//   int v73; // eax
			//   ASMTile *Tile; // rax
			//   __int64 vtIndex; // r8
			//   __int64 v76; // rdx
			//   float v77; // xmm6_4
			//   float v78; // xmm8_4
			//   __m128 v79; // xmm7
			//   int32_t v80; // xmm10_4
			//   int32_t v81; // xmm11_4
			//   float v82; // xmm6_4
			//   __int64 v83; // rdx
			//   __int64 v84; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdi
			//   MethodInfo *P3; // [rsp+20h] [rbp-278h]
			//   __int64 v87; // [rsp+70h] [rbp-228h]
			//   __int64 v88; // [rsp+70h] [rbp-228h]
			//   __int64 v89; // [rsp+70h] [rbp-228h]
			//   char v90; // [rsp+78h] [rbp-220h]
			//   int v91; // [rsp+7Ch] [rbp-21Ch]
			//   int v92; // [rsp+80h] [rbp-218h]
			//   int v93; // [rsp+80h] [rbp-218h]
			//   TileAnimationData v94; // [rsp+88h] [rbp-210h] BYREF
			//   int v95; // [rsp+98h] [rbp-200h]
			//   int v96; // [rsp+9Ch] [rbp-1FCh]
			//   int32_t useLength; // [rsp+A0h] [rbp-1F8h]
			//   int v98; // [rsp+A4h] [rbp-1F4h]
			//   NativeArray_1_UnityEngine_Vector2_ v99; // [rsp+B0h] [rbp-1E8h] BYREF
			//   Void *v100; // [rsp+C0h] [rbp-1D8h]
			//   __int64 v101; // [rsp+D0h] [rbp-1C8h] BYREF
			//   unsigned __int64 v102; // [rsp+D8h] [rbp-1C0h]
			//   unsigned __int64 v103; // [rsp+E0h] [rbp-1B8h]
			//   Il2CppException *ex; // [rsp+E8h] [rbp-1B0h]
			//   NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_TriangleWorker_GroupData_ *v105; // [rsp+F0h] [rbp-1A8h]
			//   NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_TriangleWorker_GroupData_ v106; // [rsp+F8h] [rbp-1A0h] BYREF
			//   ASMTile v107; // [rsp+130h] [rbp-168h] BYREF
			//   NativeArray_1_T_ReadOnly_MagicaCloth_TriangleWorker_GroupData_ v108; // [rsp+160h] [rbp-138h] BYREF
			//   __int128 v109; // [rsp+170h] [rbp-128h]
			//   __int128 v110; // [rsp+180h] [rbp-118h]
			//   __m128 v111; // [rsp+190h] [rbp-108h]
			//   Il2CppExceptionWrapper *v112; // [rsp+1A0h] [rbp-F8h] BYREF
			//   __int128 v113; // [rsp+1A8h] [rbp-F0h]
			//   TileAnimationData v114; // [rsp+1B8h] [rbp-E0h] BYREF
			// 
			//   v15 = gridSize;
			//   v16 = this;
			//   if ( !byte_18D919E54 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<HG::Rendering::Runtime::ASMTile>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<HG::Rendering::Runtime::ASMTile>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<HG::Rendering::Runtime::ASMTile>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::GetEnumerator);
			//     byte_18D919E54 = 1;
			//   }
			//   v100 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1742, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1742, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v84, v83);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_672(
			//       Patch,
			//       (Object *)v16,
			//       gridSize,
			//       startVTIndex,
			//       gridCountX,
			//       gridCountY,
			//       asmRadius,
			//       worldToShadowMatrices,
			//       baseWorldToShadowMatrix,
			//       indexRegionMins,
			//       indexRegionMaxs,
			//       indirectWidth,
			//       indirectHeight,
			//       0LL);
			//   }
			//   else
			//   {
			//     v17 = (_OWORD *)sub_182805160(&v108);
			//     v18 = v17[1];
			//     v19 = v17[2];
			//     v20 = v17[3];
			//     *(_OWORD *)&baseWorldToShadowMatrix.m00 = *v17;
			//     *(_OWORD *)&baseWorldToShadowMatrix.m01 = v18;
			//     *(_OWORD *)&baseWorldToShadowMatrix.m02 = v19;
			//     *(_OWORD *)&baseWorldToShadowMatrix.m03 = v20;
			//     v90 = 0;
			//     v21 = 0x40000000;
			//     v91 = 0x40000000;
			//     v22 = 0x40000000;
			//     v95 = 0x40000000;
			//     v23 = -1073741824;
			//     v96 = -1073741824;
			//     v24 = -1073741824;
			//     v92 = -1073741824;
			//     Unity::Collections::NativeArray_1_T_::ReadOnly<MagicaCloth::TriangleWorker::GroupData>::GetEnumerator(
			//       (NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_TriangleWorker_GroupData_ *)&v108,
			//       (NativeArray_1_T_ReadOnly_MagicaCloth_TriangleWorker_GroupData_ *)&v16.fields,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::GetEnumerator);
			//     v106.m_Array = v108;
			//     *(_OWORD *)&v106.m_Index = v109;
			//     *(_OWORD *)&v106.value.triangleDataChunk.dataLength = v110;
			//     *(_QWORD *)&v106.value.triangleIndexChunk.dataLength = v111.m128_u64[0];
			//     ex = 0LL;
			//     v105 = &v106;
			//     try
			//     {
			//       v62 = 0LL;
			//       while ( 1 )
			//       {
			//         do
			//         {
			//           if ( !Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<MagicaCloth::TriangleWorker::GroupData>::MoveNext(
			//                   &v106,
			//                   MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<HG::Rendering::Runtime::ASMTile>::MoveNext) )
			//             goto LABEL_69;
			//           v25 = *(_OWORD *)&v106.value.teamId;
			//           v113 = *(_OWORD *)&v106.value.teamId;
			//           v26 = *(__m128i *)&v106.value.triangleDataChunk.useLength;
			//           useLength = v106.value.triangleIndexChunk.useLength;
			//         }
			//         while ( !_mm_srli_si128(*(__m128i *)(&v106 + 36), 8).m128i_i8[4] );
			//         teamId = (__m128)(unsigned int)v106.value.teamId;
			//         chunkNo = (__m128)(unsigned int)v106.value.triangleDataChunk.chunkNo;
			//         startIndex = (__m128)(unsigned int)v106.value.triangleDataChunk.startIndex;
			//         dataLength = (__m128)(unsigned int)v106.value.triangleDataChunk.dataLength;
			//         m_frustumVertsForIndirect = v16.fields.m_frustumVertsForIndirect;
			//         v99 = m_frustumVertsForIndirect;
			//         v94 = 0LL;
			//         v101 = 0LL;
			//         IsPatched = IFix::WrappersManagerImpl::IsPatched(1725, 0LL);
			//         v33 = 0LL;
			//         if ( IsPatched )
			//         {
			//           v56 = IFix::WrappersManagerImpl::GetPatch(1725, 0LL);
			//           if ( !v56 )
			//             sub_1802DC2C8(v58, v57);
			//           v99 = m_frustumVertsForIndirect;
			//           if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_660(
			//                  v56,
			//                  &v99,
			//                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps(teamId, chunkNo),
			//                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps(startIndex, dataLength),
			//                  0LL) )
			//           {
			//             goto LABEL_33;
			//           }
			//         }
			//         else
			//         {
			//           v34 = 1;
			//           v35 = 1;
			//           v36 = 1;
			//           v37 = 1;
			//           m_Buffer = v99.m_Buffer;
			//           do
			//           {
			//             v34 &= *(float *)&v99.m_Buffer[8 * v33] > startIndex.m128_f32[0];
			//             v39 = *(float *)&v99.m_Buffer[8 * v33 + 4];
			//             v35 &= v39 > dataLength.m128_f32[0];
			//             v36 &= teamId.m128_f32[0] > *(float *)&v99.m_Buffer[8 * v33];
			//             v37 &= chunkNo.m128_f32[0] > v39;
			//             ++v33;
			//           }
			//           while ( v33 < 5 );
			//           if ( (unsigned __int8)v34 | (unsigned __int8)(v35 | v36 | v37) )
			//           {
			// LABEL_5:
			//             v16 = this;
			//           }
			//           else
			//           {
			//             v40 = 0;
			//             v102 = _mm_unpacklo_ps(teamId, chunkNo).m128_u64[0];
			//             v41 = _mm_unpacklo_ps(teamId, dataLength).m128_u64[0];
			//             v103 = _mm_unpacklo_ps(startIndex, chunkNo).m128_u64[0];
			//             v99.m_Buffer = (Void *)_mm_unpacklo_ps(startIndex, dataLength).m128_u64[0];
			//             while ( v40 < 8 )
			//             {
			//               if ( v40 >= 4 )
			//               {
			//                 v43 = (__m128)*(_DWORD *)m_Buffer;
			//                 v44 = (__m128)*(unsigned int *)&m_Buffer[4];
			//               }
			//               else
			//               {
			//                 v42 = (v40 + 1) % 4;
			//                 v43 = (__m128)*(unsigned int *)&m_Buffer[8 * v42 + 8];
			//                 v44 = (__m128)*(unsigned int *)&m_Buffer[8 * v42 + 12];
			//               }
			//               v45 = _mm_unpacklo_ps(
			//                       (__m128)*(_DWORD *)&m_Buffer[8 * (v40 % 4) + 8],
			//                       (__m128)*(_DWORD *)&m_Buffer[8 * (v40 % 4) + 12]).m128_u64[0];
			//               v101 = sub_18473B264(_mm_unpacklo_ps(v43, v44).m128_u64[0], v45);
			//               v87 = sub_182413630(&v101);
			//               v48 = *((float *)&v87 + 1);
			//               v49 = -*(float *)&v87;
			//               v50 = 0LL;
			//               v51 = 0LL;
			//               for ( i = 0; i < 5; ++i )
			//               {
			//                 v88 = sub_18473B264(
			//                         _mm_unpacklo_ps((__m128)*(_DWORD *)&m_Buffer[8 * i], (__m128)*(_DWORD *)&m_Buffer[8 * i + 4]).m128_u64[0],
			//                         v45);
			//                 v53 = (float)(v48 * *(float *)&v88) + (float)(v49 * *((float *)&v88 + 1));
			//                 v54 = v50;
			//                 *(float *)&v54 = UnityEngine::Mathf::Min(*(float *)&v50, v53, 0LL);
			//                 v50 = v54;
			//                 v55 = v51;
			//                 *(float *)&v55 = UnityEngine::Mathf::Max(*(float *)&v51, v53, 0LL);
			//                 v51 = v55;
			//               }
			//               v94 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(&v114, 0LL, v46, v47, P3);
			//               sub_18473B264(v102, v45);
			//               sub_182718290(&v94, 0LL);
			//               sub_18473B264(v41, v45);
			//               sub_182718290(&v94, 1LL);
			//               sub_18473B264(v103, v45);
			//               sub_182718290(&v94, 2LL);
			//               sub_18473B264(v99.m_Buffer, v45);
			//               sub_182718290(&v94, 3LL);
			//               if ( *(float *)&v50 > sub_182637EE0(&v94, 0LL)
			//                 && *(float *)&v50 > sub_182637EE0(&v94, 1LL)
			//                 && *(float *)&v50 > sub_182637EE0(&v94, 2LL) )
			//               {
			//                 v21 = v91;
			//                 if ( *(float *)&v50 > sub_182637EE0(&v94, 3LL) )
			//                   goto LABEL_5;
			//               }
			//               if ( sub_182637EE0(&v94, 0LL) > *(float *)&v51
			//                 && sub_182637EE0(&v94, 1LL) > *(float *)&v51
			//                 && sub_182637EE0(&v94, 2LL) > *(float *)&v51 )
			//               {
			//                 v21 = v91;
			//                 if ( sub_182637EE0(&v94, 3LL) > *(float *)&v51 )
			//                   goto LABEL_5;
			//               }
			//               ++v40;
			//             }
			//             v25 = v113;
			//             v21 = v91;
			//             v16 = this;
			// LABEL_33:
			//             v59 = v16.fields.m_frustumVertsForIndirect.m_Buffer;
			//             v60 = (__m128)*(unsigned int *)&v59[4];
			//             *(_OWORD *)&v107.mins.x = v25;
			//             *(__m128i *)&v107.tileCoords.m_X = v26;
			//             v107.vtIndex = useLength;
			//             if ( asmRadius > HG::Rendering::Runtime::ASMUtils::ASMTileDistance(
			//                                &v107,
			//                                (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)*(_DWORD *)v59, v60),
			//                                0LL) )
			//             {
			//               v61 = _mm_cvtsi128_si32(v26);
			//               if ( v21 >= v61 )
			//                 v21 = v61;
			//               v91 = v21;
			//               if ( v22 >= v26.m128i_i32[1] )
			//                 v22 = v26.m128i_i32[1];
			//               v95 = v22;
			//               if ( v23 <= v61 )
			//                 v23 = v61;
			//               v96 = v23;
			//               if ( v24 <= v26.m128i_i32[1] )
			//                 v24 = v26.m128i_i32[1];
			//               v92 = v24;
			//               v90 = 1;
			//             }
			//           }
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v112 )
			//     {
			//       ex = v112.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v15 = gridSize;
			//       v21 = v91;
			//       v22 = v95;
			//       v23 = v96;
			//       v24 = v92;
			//       v62 = 0LL;
			//     }
			// LABEL_69:
			//     v63 = v23 - v21 + 1;
			//     v64 = v24 - v22 + 1;
			//     if ( v90 && v63 * v64 <= 128 && v63 * v64 > 0 )
			//     {
			//       v65 = 0LL;
			//       v65.m128_f32[0] = (float)v21 * v15;
			//       v66 = 0LL;
			//       v66.m128_f32[0] = (float)v22 * v15;
			//       *indexRegionMins = (Vector2)_mm_unpacklo_ps(v65, v66).m128_u64[0];
			//       v67 = 0LL;
			//       v68 = 0LL;
			//       v67.m128_f32[0] = (float)((float)v63 * v15) + v65.m128_f32[0];
			//       v68.m128_f32[0] = (float)((float)v64 * v15) + v66.m128_f32[0];
			//       *indexRegionMaxs = (Vector2)_mm_unpacklo_ps(v67, v68).m128_u64[0];
			//       v69 = 0;
			//       if ( v64 > 0 )
			//       {
			//         v70 = 0;
			//         v71 = v64 + v22 - 1;
			//         do
			//         {
			//           if ( v63 > 0 )
			//           {
			//             v89 = 0LL;
			//             HIDWORD(v100) = v71;
			//             v72 = 16LL * v70;
			//             v73 = v63 + v91 - 1;
			//             v93 = v73;
			//             do
			//             {
			//               LODWORD(v100) = v73;
			//               v99.m_Buffer = v100;
			//               v99.m_Length = 0;
			//               Tile = HG::Rendering::Runtime::ASMTileManager::GetTile((ASMTile *)&v108, this, (Vector3Int *)&v99, 0LL);
			//               if ( !((unsigned __int16)WORD2(*(_QWORD *)&Tile.tileCoords.m_Z) >> 8)
			//                 || (vtIndex = Tile.vtIndex, (_DWORD)vtIndex == -1) )
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                 v79.m128_i32[0] = v62.m128_i32[0];
			//                 v80 = v62.m128_i32[0];
			//                 v81 = v62.m128_i32[0];
			//                 v77 = -1.0;
			//                 v78 = -1.0;
			//               }
			//               else
			//               {
			//                 useLength = (int)vtIndex % gridCountX;
			//                 v76 = (unsigned int)((int)vtIndex >> 31);
			//                 v98 = (int)vtIndex / gridCountY;
			//                 v77 = (float)(1.0 / (float)gridCountX) * (float)((int)vtIndex % gridCountX);
			//                 v78 = (float)(1.0 / (float)gridCountY) * (float)((int)vtIndex / gridCountY);
			//                 if ( !*worldToShadowMatrices )
			//                 {
			//                   LODWORD(v76) = (int)vtIndex % gridCountY;
			//                   sub_1802DC2C8((unsigned int)((int)vtIndex % gridCountX), v76);
			//                 }
			//                 sub_18005A9F0(*worldToShadowMatrices, &v108, vtIndex);
			//                 *(NativeArray_1_T_ReadOnly_MagicaCloth_TriangleWorker_GroupData_ *)&baseWorldToShadowMatrix.m00 = v108;
			//                 *(_OWORD *)&baseWorldToShadowMatrix.m01 = v109;
			//                 *(_OWORD *)&baseWorldToShadowMatrix.m02 = v110;
			//                 v79 = v111;
			//                 *(__m128 *)&baseWorldToShadowMatrix.m03 = v111;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                 v80 = _mm_shuffle_ps(v79, v79, 85).m128_u32[0];
			//                 v81 = _mm_shuffle_ps(v79, v79, 170).m128_u32[0];
			//               }
			//               v82 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(v77, v78, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//               *(float *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23]._CSMSectionOffset
			//                        + v72) = v82;
			//               *(int32_t *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23]._PunctualLightShadowSectionOffset
			//                          + v72) = v79.m128_i32[0];
			//               *(int32_t *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23]._CharacterShadowSectionOffset
			//                          + v72) = v80;
			//               *(int32_t *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23]._ASMSectionOffset
			//                          + v72) = v81;
			//               v73 = --v93;
			//               ++v89;
			//               v72 += 16LL;
			//             }
			//             while ( v89 < v63 );
			//           }
			//           ++v69;
			//           --v71;
			//           v70 += v63;
			//         }
			//         while ( v69 < v64 );
			//       }
			//       *indirectWidth = v63;
			//       *indirectHeight = v64;
			//     }
			//     else
			//     {
			//       *indirectWidth = 0;
			//       *indirectHeight = 0;
			//       *indexRegionMins = (Vector2)_mm_unpacklo_ps(v62, v62).m128_u64[0];
			//       *indexRegionMaxs = (Vector2)_mm_unpacklo_ps(v62, v62).m128_u64[0];
			//     }
			//   }
			// }
			// 
		}

		public const int MAX_TILE_COUNT = 256;

		public NativeArray<ASMTile> m_cachedTiles;

		private NativeArray<int> m_calculateTileVisibilityJob_tileIndicies;

		private NativeArray<Vector2> m_frustumVerts;

		private NativeArray<Vector2> m_frustumVertsForIndirect;

		public ASMTile[] m_tilesThisFrame;

		private LRUCache m_cachedTilesLRUCache;

		private int m_tilesThisFrameCount;

		public Dictionary<Vector3Int, int> m_cachedTilesDict;

		private int m_renderCountThisFrame;

		private NativeArray<ASMTileManager.ScoreIndexStruct> m_tempCachedTilesScore;

		private NativeArray<int> m_tilesForRenderThisFrame;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		private struct ScoreIndexStruct : IComparable<ASMTileManager.ScoreIndexStruct>
		{
			public int CompareTo(ASMTileManager.ScoreIndexStruct obj)
			{
				// // Int32 CompareTo(ASMTileManager+ScoreIndexStruct)
				// int32_t HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct::CompareTo(
				//         ASMTileManager_ScoreIndexStruct *this,
				//         ASMTileManager_ScoreIndexStruct obj,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   float score; // [rsp+3Ch] [rbp+14h]
				// 
				//   score = obj.score;
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1743, 0LL) )
				//     return System::Single::CompareTo((Single *)&this.score, score, 0LL);
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1743, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v8, v7);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_673(Patch, this, obj, 0LL);
				// }
				// 
				return 0;
			}

			public int index;

			public float score;
		}

		[BurstCompile]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		private struct CalculateTileVisibilities : IJob
		{
			[MethodImpl(256)]
			public void Execute()
			{
				// // Void Execute()
				// void HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities::Execute(
				//         ASMTileManager_CalculateTileVisibilities *this,
				//         MethodInfo *method)
				// {
				//   int32_t v2; // edi
				//   __int64 v4; // rsi
				//   __int64 v5; // r15
				//   __m128 v6; // xmm7
				//   int32_t v7; // r14d
				//   __m128i v8; // xmm6
				//   __int64 v9; // rax
				//   bool v10; // al
				//   NativeArray_1_UnityEngine_Vector2_ frustumVerts; // xmm0
				//   Vector2 v12; // rdx
				//   __int64 v13; // rcx
				//   Void *m_Buffer; // rax
				//   __m128i v15; // xmm0
				//   NativeArray_1_UnityEngine_Vector2_ v16; // [rsp+28h] [rbp-49h] BYREF
				//   ASMTile v17; // [rsp+38h] [rbp-39h] BYREF
				//   __m128i v18; // [rsp+78h] [rbp+7h]
				// 
				//   v2 = 0;
				//   if ( this.count > 0 )
				//   {
				//     v4 = 0LL;
				//     do
				//     {
				//       v5 = *(int *)&this.tileIndices.m_Buffer[v4];
				//       v6 = *(__m128 *)&this.cachedTiles.m_Buffer[36 * v5];
				//       v7 = *(_DWORD *)&this.cachedTiles.m_Buffer[36 * v5 + 32];
				//       v8 = *(__m128i *)&this.cachedTiles.m_Buffer[36 * v5 + 16];
				//       v9 = HIDWORD(*(_QWORD *)&this.cachedTiles.m_Buffer[36 * v5 + 24]);
				//       v17.vtIndex = v7;
				//       v18 = v8;
				//       *(__m128 *)&v17.mins.x = v6;
				//       if ( (_BYTE)v9 )
				//       {
				//         frustumVerts = this.frustumVerts;
				//         v17.vtIndex = v7;
				//         *(__m128i *)&v17.tileCoords.m_X = v8;
				//         v16 = frustumVerts;
				//         if ( HG::Rendering::Runtime::ASMUtils::IsTileFrustumIntersecting(
				//                &v16,
				//                (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v6, _mm_shuffle_ps(v6, v6, 85)),
				//                (Vector2)*(_OWORD *)&_mm_unpacklo_ps(_mm_shuffle_ps(v6, v6, 170), _mm_shuffle_ps(v6, v6, 255)),
				//                0LL) )
				//         {
				//           v10 = 1;
				//           goto LABEL_9;
				//         }
				//         if ( !_mm_cvtsi128_si32(_mm_srli_si128(v8, 8)) )
				//         {
				//           v12 = (Vector2)_mm_unpacklo_ps((__m128)LODWORD(this.centerPoint.x), (__m128)LODWORD(this.centerPoint.y)).m128_u64[0];
				//           *(__m128 *)&v17.mins.x = v6;
				//           *(__m128i *)&v17.tileCoords.m_X = v8;
				//           v17.vtIndex = v7;
				//           v10 = this.radius > HG::Rendering::Runtime::ASMUtils::ASMTileDistance(&v17, v12, 0LL);
				//           goto LABEL_9;
				//         }
				//       }
				//       v10 = 0;
				// LABEL_9:
				//       v13 = 9 * v5;
				//       v18.m128i_i8[14] = v10;
				//       m_Buffer = this.cachedTiles.m_Buffer;
				//       ++v2;
				//       v15 = v18;
				//       v4 += 4LL;
				//       *(__m128 *)&m_Buffer[4 * v13] = v6;
				//       *(__m128i *)&m_Buffer[4 * v13 + 16] = v15;
				//       *(_DWORD *)&m_Buffer[4 * v13 + 32] = v7;
				//     }
				//     while ( v2 < this.count );
				//   }
				// }
				// 
			}

			public NativeArray<ASMTile> cachedTiles;

			[ReadOnly]
			public NativeArray<int> tileIndices;

			[ReadOnly]
			public NativeArray<Vector2> frustumVerts;

			public int count;

			public Vector2 centerPoint;

			public float radius;
		}

		[BurstCompile]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		private struct CalculateTileScoresJob : IJob
		{
			[MethodImpl(256)]
			public void Execute()
			{
				// // Void Execute()
				// void HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob::Execute(
				//         ASMTileManager_CalculateTileScoresJob *this,
				//         MethodInfo *method)
				// {
				//   int32_t v2; // esi
				//   __int64 v4; // r14
				//   __int64 v5; // rbx
				//   Void *m_Buffer; // rcx
				//   float v7; // xmm6_4
				//   __m128 v8; // xmm7
				//   __m128i v9; // xmm8
				//   __int64 v10; // rax
				//   __int64 v11; // rax
				//   __m128 y_low; // xmm2
				//   float v13; // xmm0_4
				//   NativeArray_1_UnityEngine_Vector2_ frustumVerts; // [rsp+20h] [rbp-78h] BYREF
				//   ASMTile v15; // [rsp+30h] [rbp-68h] BYREF
				//   unsigned __int64 v16; // [rsp+A0h] [rbp+8h]
				// 
				//   v2 = 0;
				//   if ( this.count > 0 )
				//   {
				//     v4 = 0LL;
				//     v5 = 0LL;
				//     do
				//     {
				//       m_Buffer = this.cachedTiles.m_Buffer;
				//       v7 = 3.4028235e38;
				//       v8 = *(__m128 *)&this.cachedTiles.m_Buffer[v5];
				//       v15.vtIndex = *(_DWORD *)&this.cachedTiles.m_Buffer[v5 + 32];
				//       v9 = *(__m128i *)&m_Buffer[v5 + 16];
				//       v10 = HIDWORD(*(_QWORD *)&m_Buffer[v5 + 24]);
				//       *(__m128 *)&v15.mins.x = v8;
				//       if ( (_BYTE)v10 )
				//       {
				//         v15.vtIndex = *(_DWORD *)&m_Buffer[v5 + 32];
				//         v11 = *(_QWORD *)&m_Buffer[v5 + 24] >> 40;
				//         *(__m128 *)&v15.mins.x = v8;
				//         if ( !(_BYTE)v11 )
				//         {
				//           y_low = (__m128)LODWORD(this.frustumCenterPos.y);
				//           v15.vtIndex = *(_DWORD *)&m_Buffer[v5 + 32];
				//           *(__m128 *)&v15.mins.x = v8;
				//           *(__m128i *)&v15.tileCoords.m_X = v9;
				//           v13 = HG::Rendering::Runtime::ASMUtils::ASMTileDistance(
				//                   &v15,
				//                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(this.frustumCenterPos.x), y_low),
				//                   0LL);
				//           frustumVerts = this.frustumVerts;
				//           v7 = v13 + (float)(100000 * _mm_cvtsi128_si32(_mm_srli_si128(v9, 8)));
				//           if ( !HG::Rendering::Runtime::ASMUtils::IsTileFrustumIntersecting(
				//                   &frustumVerts,
				//                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v8, _mm_shuffle_ps(v8, v8, 85)),
				//                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps(_mm_shuffle_ps(v8, v8, 170), _mm_shuffle_ps(v8, v8, 255)),
				//                   0LL) )
				//             v7 = v7 + 5000.0;
				//         }
				//       }
				//       v5 += 36LL;
				//       v16 = __PAIR64__(LODWORD(v7), v2++);
				//       *(_QWORD *)&this.cachedTilesScore.m_Buffer[v4] = v16;
				//       v4 += 8LL;
				//     }
				//     while ( v2 < this.count );
				//   }
				// }
				// 
			}

			[ReadOnly]
			public NativeArray<ASMTile> cachedTiles;

			[ReadOnly]
			public NativeArray<Vector2> frustumVerts;

			[WriteOnly]
			public NativeArray<ASMTileManager.ScoreIndexStruct> cachedTilesScore;

			public int count;

			public Vector2 frustumCenterPos;
		}
	}
}
