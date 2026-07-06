using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGASMVirtualTextureAllocator
	{
		public HGASMVirtualTextureAllocator()
		{
		}

		public void Initialize(int asmTileResolution)
		{
			// // Void Initialize(Int32)
			// void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(
			//         HGASMVirtualTextureAllocator *this,
			//         int32_t asmTileResolution,
			//         MethodInfo *method)
			// {
			//   int i; // ebx
			//   int v6; // r14d
			//   int32_t v7; // edi
			//   HGASMVirtualTextureAllocator_ASMVTData__Array *m_vtData; // rbp
			//   __int64 v9; // rdx
			//   LRUCache *m_lruCache; // rcx
			//   __int64 v11; // rax
			//   __int128 v12; // xmm1
			//   __int64 v13; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGASMVirtualTextureAllocator_ASMVTData v15; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(434, 0LL) )
			//   {
			//     for ( i = 0; i < 16; ++i )
			//     {
			//       v6 = 0;
			//       v7 = i;
			//       do
			//       {
			//         m_vtData = this.fields.m_vtData;
			//         memset(&v15, 0, sizeof(v15));
			//         HG::Rendering::Runtime::HGASMVirtualTextureAllocator::ASMVTData::ASMVTData(&v15, v7, asmTileResolution, 0LL);
			//         if ( !m_vtData )
			//           goto LABEL_12;
			//         if ( (unsigned int)v7 >= m_vtData.max_length.size )
			//           sub_180070270(m_lruCache, v9);
			//         v11 = v7;
			//         ++v6;
			//         v12 = *(_OWORD *)&v15.uvMaxs.y;
			//         v7 += 16;
			//         v13 = v11;
			//         LODWORD(v11) = v15.pixelMaxs.m_Y;
			//         *(_OWORD *)&m_vtData.vector[v13].vtIndex = *(_OWORD *)&v15.vtIndex;
			//         *(_OWORD *)&m_vtData.vector[v13].uvMaxs.y = v12;
			//         m_vtData.vector[v13].pixelMaxs.m_Y = v11;
			//       }
			//       while ( v6 < 16 );
			//     }
			//     m_lruCache = this.fields.m_lruCache;
			//     if ( m_lruCache )
			//     {
			//       HG::Rendering::Runtime::LRUCache::Reset(m_lruCache, 128, 0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_lruCache, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(434, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//     (ILFixDynamicMethodWrapper_26 *)Patch,
			//     (Object *)this,
			//     asmTileResolution,
			//     0LL);
			// }
			// 
		}

		public HGASMVirtualTextureAllocator.ASMVTData GetVTData(int vtIndex)
		{
			// // HGASMVirtualTextureAllocator+ASMVTData GetVTData(Int32)
			// HGASMVirtualTextureAllocator_ASMVTData *HG::Rendering::Runtime::HGASMVirtualTextureAllocator::GetVTData(
			//         HGASMVirtualTextureAllocator_ASMVTData *__return_ptr retstr,
			//         HGASMVirtualTextureAllocator *this,
			//         int32_t vtIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdi
			//   __int64 v7; // rcx
			//   HGASMVirtualTextureAllocator_ASMVTData__Array *m_vtData; // rdx
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   int32_t m_Y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGASMVirtualTextureAllocator_ASMVTData *v13; // rax
			//   HGASMVirtualTextureAllocator_ASMVTData v15; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   v5 = vtIndex;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1758, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1758, 0LL);
			//     if ( Patch )
			//     {
			//       v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_680(&v15, Patch, (Object *)this, v5, 0LL);
			//       v9 = *(_OWORD *)&v13.vtIndex;
			//       v10 = *(_OWORD *)&v13.uvMaxs.y;
			//       m_Y = v13.pixelMaxs.m_Y;
			//       goto LABEL_9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v7, m_vtData);
			//   }
			//   m_vtData = this.fields.m_vtData;
			//   if ( !m_vtData )
			//     goto LABEL_7;
			//   if ( (unsigned int)v5 >= m_vtData.max_length.size )
			//     sub_180070270(v7, m_vtData);
			//   v9 = *(_OWORD *)&m_vtData.vector[v5].vtIndex;
			//   v10 = *(_OWORD *)&m_vtData.vector[v5].uvMaxs.y;
			//   m_Y = m_vtData.vector[v5].pixelMaxs.m_Y;
			// LABEL_9:
			//   *(_OWORD *)&retstr.vtIndex = v9;
			//   *(_OWORD *)&retstr.uvMaxs.y = v10;
			//   retstr.pixelMaxs.m_Y = m_Y;
			//   return retstr;
			// }
			// 
			return default(HGASMVirtualTextureAllocator.ASMVTData);
		}

		public bool AllocateTile(ASMTileManager asmTileManager, Vector3Int tileCoords, int startVTIdx)
		{
			// // Boolean AllocateTile(ASMTileManager, Vector3Int, Int32)
			// bool HG::Rendering::Runtime::HGASMVirtualTextureAllocator::AllocateTile(
			//         HGASMVirtualTextureAllocator *this,
			//         ASMTileManager *asmTileManager,
			//         Vector3Int *tileCoords,
			//         int32_t startVTIdx,
			//         MethodInfo *method)
			// {
			//   int32_t m_Z; // eax
			//   int32_t v10; // eax
			//   unsigned __int64 v11; // rdx
			//   LRUCache *m_lruCache; // rcx
			//   unsigned __int64 v13; // rbx
			//   Vector3Int *v14; // rax
			//   __int64 v15; // xmm0_8
			//   int32_t v16; // r15d
			//   __int64 v17; // rdi
			//   __int64 v18; // rax
			//   __int64 v19; // rcx
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   Void *m_Buffer; // rax
			//   int32_t v23; // eax
			//   bool result; // al
			//   int32_t v25; // eax
			//   __int64 v26; // rcx
			//   Void *v27; // rax
			//   int v28; // ebx
			//   int32_t v29; // eax
			//   __int64 v30; // rcx
			//   __int128 v31; // xmm1
			//   __int64 v32; // rdx
			//   Void *v33; // rcx
			//   int32_t v34; // eax
			//   __int128 v35; // [rsp+38h] [rbp-21h] BYREF
			//   Vector3Int v36; // [rsp+48h] [rbp-11h] BYREF
			//   __int128 v37; // [rsp+58h] [rbp-1h] BYREF
			//   _BYTE v38[48]; // [rsp+68h] [rbp+Fh] BYREF
			// 
			//   if ( !byte_18D919E68 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTile);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item);
			//     byte_18D919E68 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1739, 0LL) )
			//   {
			//     m_Z = tileCoords.m_Z;
			//     *(_QWORD *)&v35 = *(_QWORD *)&tileCoords.m_X;
			//     DWORD2(v35) = m_Z;
			//     v10 = HG::Rendering::Runtime::ASMUtils::TileCoordsToKey((Vector3Int *)&v35, 0LL);
			//     m_lruCache = this.fields.m_lruCache;
			//     if ( !m_lruCache )
			//       goto LABEL_19;
			//     v13 = (unsigned __int64)HG::Rendering::Runtime::LRUCache::Allocate(m_lruCache, v10, 0LL);
			//     v11 = HIDWORD(v13);
			//     if ( HIDWORD(v13) == -1 )
			//     {
			//       if ( !asmTileManager )
			//         goto LABEL_19;
			//     }
			//     else
			//     {
			//       v14 = HG::Rendering::Runtime::ASMUtils::KeyToTileCoords((Vector3Int *)&v37, SHIDWORD(v13), 0LL);
			//       v15 = *(_QWORD *)&v14.m_X;
			//       v16 = v14.m_Z;
			//       *(_QWORD *)&v35 = *(_QWORD *)&v14.m_X;
			//       if ( !asmTileManager )
			//         goto LABEL_19;
			//       m_lruCache = (LRUCache *)asmTileManager.fields.m_cachedTilesDict;
			//       if ( !m_lruCache )
			//         goto LABEL_19;
			//       *(_QWORD *)&v36.m_X = v15;
			//       v36.m_Z = v16;
			//       if ( (unsigned __int8)sub_1804DC4F8(
			//                               m_lruCache,
			//                               &v36,
			//                               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
			//       {
			//         m_lruCache = (LRUCache *)asmTileManager.fields.m_cachedTilesDict;
			//         if ( !m_lruCache )
			//           goto LABEL_19;
			//         *(_QWORD *)&v36.m_X = v35;
			//         v36.m_Z = v16;
			//         v17 = (int)sub_1808368FC(m_lruCache, &v36);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::ASMTile);
			//         v18 = sub_188796A38(v38);
			//         v19 = 9 * v17;
			//         v20 = *(_OWORD *)v18;
			//         v11 = *(unsigned int *)(v18 + 32);
			//         v21 = *(_OWORD *)(v18 + 16);
			//         m_Buffer = asmTileManager.fields.m_cachedTiles.m_Buffer;
			//         *(_OWORD *)&m_Buffer[4 * v19] = v20;
			//         *(_OWORD *)&m_Buffer[4 * v19 + 16] = v21;
			//         *(_DWORD *)&m_Buffer[4 * v19 + 32] = v11;
			//         m_lruCache = (LRUCache *)asmTileManager.fields.m_cachedTilesDict;
			//         if ( !m_lruCache )
			//           goto LABEL_19;
			//         *(_QWORD *)&v36.m_X = v35;
			//         v36.m_Z = v16;
			//         sub_1804DC5F4(
			//           m_lruCache,
			//           &v36,
			//           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove);
			//       }
			//     }
			//     m_lruCache = (LRUCache *)asmTileManager.fields.m_cachedTilesDict;
			//     if ( m_lruCache )
			//     {
			//       v23 = tileCoords.m_Z;
			//       *(_QWORD *)&v36.m_X = *(_QWORD *)&tileCoords.m_X;
			//       v36.m_Z = v23;
			//       result = sub_1804DC4F8(
			//                  m_lruCache,
			//                  &v36,
			//                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey);
			//       if ( !result )
			//         return result;
			//       m_lruCache = (LRUCache *)asmTileManager.fields.m_cachedTilesDict;
			//       if ( m_lruCache )
			//       {
			//         v25 = tileCoords.m_Z;
			//         *(_QWORD *)&v36.m_X = *(_QWORD *)&tileCoords.m_X;
			//         v36.m_Z = v25;
			//         v26 = (int)sub_1808368FC(m_lruCache, &v36);
			//         v27 = asmTileManager.fields.m_cachedTiles.m_Buffer;
			//         v28 = startVTIdx + v13 - 1;
			//         v11 = 9 * v26;
			//         m_lruCache = (LRUCache *)asmTileManager.fields.m_cachedTilesDict;
			//         v37 = *(_OWORD *)&v27[4 * v11];
			//         v35 = *(_OWORD *)&v27[4 * v11 + 16];
			//         if ( m_lruCache )
			//         {
			//           v29 = tileCoords.m_Z;
			//           *(_QWORD *)&v36.m_X = *(_QWORD *)&tileCoords.m_X;
			//           v36.m_Z = v29;
			//           v30 = (int)sub_1808368FC(m_lruCache, &v36);
			//           result = 1;
			//           v31 = v35;
			//           v32 = 9 * v30;
			//           v33 = asmTileManager.fields.m_cachedTiles.m_Buffer;
			//           *(_OWORD *)&v33[4 * v32] = v37;
			//           *(_OWORD *)&v33[4 * v32 + 16] = v31;
			//           *(_DWORD *)&v33[4 * v32 + 32] = v28;
			//           return result;
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(m_lruCache, v11);
			//   }
			//   m_lruCache = (LRUCache *)IFix::WrappersManagerImpl::GetPatch(1739, 0LL);
			//   if ( !m_lruCache )
			//     goto LABEL_19;
			//   v34 = tileCoords.m_Z;
			//   *(_QWORD *)&v36.m_X = *(_QWORD *)&tileCoords.m_X;
			//   v36.m_Z = v34;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_669(
			//            (ILFixDynamicMethodWrapper_2 *)m_lruCache,
			//            (Object *)this,
			//            (Object *)asmTileManager,
			//            &v36,
			//            startVTIdx,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public void VisitTilesThisFrame(ASMTileManager asmTileManager, int startVTIdx)
		{
			// // Void VisitTilesThisFrame(ASMTileManager, Int32)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::VisitTilesThisFrame(
			//         HGASMVirtualTextureAllocator *this,
			//         ASMTileManager *asmTileManager,
			//         int32_t startVTIdx,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Void *m_Buffer; // r8
			//   LRUCache *m_lruCache; // rcx
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   int value; // [rsp+30h] [rbp-98h] BYREF
			//   Vector3Int key; // [rsp+38h] [rbp-90h] BYREF
			//   Il2CppException *ex; // [rsp+48h] [rbp-80h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ *v18; // [rsp+50h] [rbp-78h]
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v19; // [rsp+58h] [rbp-70h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v20; // [rsp+80h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v21; // [rsp+A8h] [rbp-20h] BYREF
			//   KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ current; // [rsp+B0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E69 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
			//     byte_18D919E69 = 1;
			//   }
			//   *(_QWORD *)&key.m_X = 0LL;
			//   key.m_Z = 0;
			//   value = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1756, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1756, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(
			//       (ILFixDynamicMethodWrapper_16 *)Patch,
			//       (Object *)this,
			//       (Object *)asmTileManager,
			//       startVTIdx,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !asmTileManager )
			//       sub_180B536AC(v8, v7);
			//     if ( !asmTileManager.fields.m_cachedTilesDict )
			//       sub_180B536AC(v8, v7);
			//     System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)&v19,
			//       (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)asmTileManager.fields.m_cachedTilesDict,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
			//     v20 = v19;
			//     ex = 0LL;
			//     v18 = &v20;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
			//                 &v20,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
			//       {
			//         current = (KeyValuePair_2_UnityEngine_Vector3Int_System_Single_)v20._current;
			//         System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::Deconstruct(
			//           &current,
			//           &key,
			//           (float *)&value,
			//           MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
			//         m_Buffer = asmTileManager.fields.m_cachedTiles.m_Buffer;
			//         if ( (unsigned __int8)BYTE6(*(_QWORD *)&m_Buffer[36 * value + 24])
			//           && *(_DWORD *)&m_Buffer[36 * value + 32] != -1 )
			//         {
			//           m_lruCache = this.fields.m_lruCache;
			//           v11 = *(unsigned int *)&m_Buffer[36 * value + 32];
			//           if ( !m_lruCache )
			//             sub_1802DC2C8(0LL, v11);
			//           HG::Rendering::Runtime::LRUCache::Visit(m_lruCache, v11 - startVTIdx + 1, 0LL);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v21 )
			//     {
			//       ex = v21.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private const int GRID_COUNT_X = 16;

		private const int GRID_COUNT_Y = 16;

		private readonly LRUCache m_lruCache;

		private readonly HGASMVirtualTextureAllocator.ASMVTData[] m_vtData;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
		public struct ASMVTData
		{
			public ASMVTData(int inVTIndex, int gridResolution)
			{
				// // HGASMVirtualTextureAllocator+ASMVTData(Int32, Int32)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::ASMVTData::ASMVTData(
				//         HGASMVirtualTextureAllocator_ASMVTData *this,
				//         int32_t inVTIndex,
				//         int32_t gridResolution,
				//         MethodInfo *method)
				// {
				//   __m128 v4; // xmm0
				//   Vector2 v5; // rax
				//   int v6; // r8d
				//   int v7; // r9d
				//   int v8; // r9d
				//   int v9; // r10d
				//   int v10; // r10d
				//   __int64 v11; // r11
				//   __int64 v12; // rax
				//   __int64 v13; // r11
				//   __int64 v14; // [rsp+30h] [rbp+8h]
				// 
				//   this.vtIndex = inVTIndex;
				//   this.uvMins.x = (float)(inVTIndex % 16) * 0.0625;
				//   v4 = (__m128)COERCE_UNSIGNED_INT((float)(inVTIndex / 16));
				//   v4.m128_f32[0] = v4.m128_f32[0] * 0.0625;
				//   LODWORD(this.uvMins.y) = v4.m128_i32[0];
				//   v5 = sub_1842BE4B8(
				//          (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(this.uvMins.x), v4),
				//          (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3D800000u, (__m128)0x3D800000u),
				//          *(Vector2 *)&gridResolution,
				//          (Vector2)(unsigned int)(inVTIndex % 16));
				//   v8 = v6 * v7;
				//   v10 = v6 * v9;
				//   *(Vector2 *)(v11 + 12) = v5;
				//   LODWORD(v14) = v6 - 1;
				//   HIDWORD(v14) = v6 - 1;
				//   *(_QWORD *)(v11 + 20) = __PAIR64__(v10, v8);
				//   v12 = sub_184CE95D4(__PAIR64__(v10, v8), v14);
				//   *(_QWORD *)(v13 + 28) = v12;
				// }
				// 
			}

			public int vtIndex;

			public Vector2 uvMins;

			public Vector2 uvMaxs;

			public Vector2Int pixelMins;

			public Vector2Int pixelMaxs;
		}
	}
}
