using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGASMVirtualTextureAllocator // TypeDefIndex: 37824
	{
		// Fields
		private const int GRID_COUNT_X = 16; // Metadata: 0x0230317B
		private const int GRID_COUNT_Y = 16; // Metadata: 0x0230317C
		private readonly LRUCache m_lruCache; // 0x10
		private readonly ASMVTData[] m_vtData; // 0x18
	
		// Nested types
		public struct ASMVTData // TypeDefIndex: 37823
		{
			// Fields
			public int vtIndex; // 0x00
			public Vector2 uvMins; // 0x04
			public Vector2 uvMaxs; // 0x0C
			public Vector2Int pixelMins; // 0x14
			public Vector2Int pixelMaxs; // 0x1C
	
			// Constructors
			public ASMVTData(int inVTIndex, int gridResolution) {
				vtIndex = default;
				uvMins = default;
				uvMaxs = default;
				pixelMins = default;
				pixelMaxs = default;
			} // 0x0000000189D15730-0x0000000189D157F0
			// HGASMVirtualTextureAllocator+ASMVTData(Int32, Int32)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::ASMVTData::ASMVTData(
			        HGASMVirtualTextureAllocator_ASMVTData *this,
			        int32_t inVTIndex,
			        int32_t gridResolution,
			        MethodInfo *method)
			{
			  __m128 v4; // xmm0
			  Vector2 v5; // rax
			  int v6; // r8d
			  int v7; // r9d
			  int v8; // r9d
			  int v9; // r10d
			  int v10; // r10d
			  __int64 v11; // r11
			  __int64 v12; // rax
			  __int64 v13; // r11
			  __int64 v14; // [rsp+30h] [rbp+8h]
			
			  this->vtIndex = inVTIndex;
			  this->uvMins.x = (float)(inVTIndex % 16) * 0.0625;
			  v4 = (__m128)COERCE_UNSIGNED_INT((float)(inVTIndex / 16));
			  v4.m128_f32[0] = v4.m128_f32[0] * 0.0625;
			  LODWORD(this->uvMins.y) = v4.m128_i32[0];
			  v5 = sub_1853DF234(
			         (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(this->uvMins.x), v4),
			         (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3D800000u, (__m128)0x3D800000u),
			         *(Vector2 *)&gridResolution,
			         (Vector2)(unsigned int)(inVTIndex % 16));
			  v8 = v6 * v7;
			  v10 = v6 * v9;
			  *(Vector2 *)(v11 + 12) = v5;
			  LODWORD(v14) = v6 - 1;
			  HIDWORD(v14) = v6 - 1;
			  *(_QWORD *)(v11 + 20) = __PAIR64__(v10, v8);
			  v12 = sub_185EC333C(__PAIR64__(v10, v8), v14);
			  *(_QWORD *)(v13 + 28) = v12;
			}
			
		}
	
		// Constructors
		public HGASMVirtualTextureAllocator() {} // 0x0000000189D1B924-0x0000000189D1B974
		// HGASMVirtualTextureAllocator()
		void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::HGASMVirtualTextureAllocator(
		        HGASMVirtualTextureAllocator *this,
		        MethodInfo *method)
		{
		  LRUCache *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+50h] [rbp+28h]
		
		  v3 = (LRUCache *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::LRUCache);
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  this->fields.m_lruCache = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v6, v7, v11);
		  this->fields.m_vtData = (HGASMVirtualTextureAllocator_ASMVTData__Array *)il2cpp_array_new_specific_1(
		                                                                             TypeInfo::HG::Rendering::Runtime::HGASMVirtualTextureAllocator::ASMVTData,
		                                                                             256LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_vtData, v8, v9, v10, v12);
		}
		
	
		// Methods
		public void Initialize(int asmTileResolution) {} // 0x0000000189D1B638-0x0000000189D1B73C
		// Void Initialize(Int32)
		void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(
		        HGASMVirtualTextureAllocator *this,
		        int32_t asmTileResolution,
		        MethodInfo *method)
		{
		  int i; // ebx
		  int v6; // r14d
		  int32_t v7; // edi
		  HGASMVirtualTextureAllocator_ASMVTData__Array *m_vtData; // rbp
		  __int64 v9; // rdx
		  LRUCache *m_lruCache; // rcx
		  __int64 v11; // rax
		  __int128 v12; // xmm1
		  __int64 v13; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGASMVirtualTextureAllocator_ASMVTData v15; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(441, 0LL) )
		  {
		    for ( i = 0; i < 16; ++i )
		    {
		      v6 = 0;
		      v7 = i;
		      do
		      {
		        m_vtData = this->fields.m_vtData;
		        memset(&v15, 0, sizeof(v15));
		        HG::Rendering::Runtime::HGASMVirtualTextureAllocator::ASMVTData::ASMVTData(&v15, v7, asmTileResolution, 0LL);
		        if ( !m_vtData )
		          goto LABEL_12;
		        if ( (unsigned int)v7 >= m_vtData->max_length.size )
		          sub_1800D2AB0(m_lruCache, v9);
		        v11 = v7;
		        ++v6;
		        v12 = *(_OWORD *)&v15.uvMaxs.y;
		        v7 += 16;
		        v13 = v11;
		        LODWORD(v11) = v15.pixelMaxs.m_Y;
		        *(_OWORD *)&m_vtData->vector[v13].vtIndex = *(_OWORD *)&v15.vtIndex;
		        *(_OWORD *)&m_vtData->vector[v13].uvMaxs.y = v12;
		        m_vtData->vector[v13].pixelMaxs.m_Y = v11;
		      }
		      while ( v6 < 16 );
		    }
		    m_lruCache = this->fields.m_lruCache;
		    if ( m_lruCache )
		    {
		      HG::Rendering::Runtime::LRUCache::Reset(m_lruCache, 128, 0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(m_lruCache, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(441, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		    (ILFixDynamicMethodWrapper_29 *)Patch,
		    (Object *)this,
		    asmTileResolution,
		    0LL);
		}
		
		public ASMVTData GetVTData(int vtIndex) => default; // 0x0000000189D1B590-0x0000000189D1B638
		// HGASMVirtualTextureAllocator+ASMVTData GetVTData(Int32)
		HGASMVirtualTextureAllocator_ASMVTData *HG::Rendering::Runtime::HGASMVirtualTextureAllocator::GetVTData(
		        HGASMVirtualTextureAllocator_ASMVTData *__return_ptr retstr,
		        HGASMVirtualTextureAllocator *this,
		        int32_t vtIndex,
		        MethodInfo *method)
		{
		  __int64 v5; // rdi
		  __int64 v7; // rcx
		  HGASMVirtualTextureAllocator_ASMVTData__Array *m_vtData; // rdx
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  int32_t m_Y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGASMVirtualTextureAllocator_ASMVTData *v13; // rax
		  HGASMVirtualTextureAllocator_ASMVTData v15; // [rsp+30h] [rbp-38h] BYREF
		
		  v5 = vtIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(2079, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2079, 0LL);
		    if ( Patch )
		    {
		      v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_837(&v15, Patch, (Object *)this, v5, 0LL);
		      v9 = *(_OWORD *)&v13->vtIndex;
		      v10 = *(_OWORD *)&v13->uvMaxs.y;
		      m_Y = v13->pixelMaxs.m_Y;
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(v7, m_vtData);
		  }
		  m_vtData = this->fields.m_vtData;
		  if ( !m_vtData )
		    goto LABEL_7;
		  if ( (unsigned int)v5 >= m_vtData->max_length.size )
		    sub_1800D2AB0(v7, m_vtData);
		  v9 = *(_OWORD *)&m_vtData->vector[v5].vtIndex;
		  v10 = *(_OWORD *)&m_vtData->vector[v5].uvMaxs.y;
		  m_Y = m_vtData->vector[v5].pixelMaxs.m_Y;
		LABEL_9:
		  *(_OWORD *)&retstr->vtIndex = v9;
		  *(_OWORD *)&retstr->uvMaxs.y = v10;
		  retstr->pixelMaxs.m_Y = m_Y;
		  return retstr;
		}
		
		public bool AllocateTile(ASMTileManager asmTileManager, Vector3Int tileCoords, int startVTIdx) => default; // 0x0000000189D1B2FC-0x0000000189D1B590
		// Boolean AllocateTile(ASMTileManager, Vector3Int, Int32)
		bool HG::Rendering::Runtime::HGASMVirtualTextureAllocator::AllocateTile(
		        HGASMVirtualTextureAllocator *this,
		        ASMTileManager *asmTileManager,
		        Vector3Int *tileCoords,
		        int32_t startVTIdx,
		        MethodInfo *method)
		{
		  int32_t m_Z; // eax
		  int32_t v10; // eax
		  unsigned __int64 vtIndex; // rdx
		  LRUCache *m_lruCache; // rcx
		  unsigned __int64 v13; // rbx
		  Vector3Int *v14; // rax
		  __int64 v15; // xmm0_8
		  int32_t v16; // r15d
		  __int64 v17; // rdi
		  MethodInfo *v18; // rdx
		  ASMTile *InvalidTile; // rax
		  __int64 v20; // rcx
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  Void *m_Buffer; // rax
		  int32_t v24; // eax
		  bool result; // al
		  int32_t v26; // eax
		  __int64 v27; // rcx
		  Void *v28; // rax
		  int v29; // ebx
		  int32_t v30; // eax
		  __int64 v31; // rcx
		  Void *v32; // rax
		  __int128 v33; // xmm1
		  __int64 v34; // rdx
		  int32_t v35; // eax
		  __int128 v36; // [rsp+38h] [rbp-21h] BYREF
		  Vector3Int v37; // [rsp+48h] [rbp-11h] BYREF
		  __int128 v38; // [rsp+58h] [rbp-1h] BYREF
		  ASMTile v39; // [rsp+68h] [rbp+Fh] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2053, 0LL) )
		  {
		    m_Z = tileCoords->m_Z;
		    *(_QWORD *)&v36 = *(_QWORD *)&tileCoords->m_X;
		    DWORD2(v36) = m_Z;
		    v10 = HG::Rendering::Runtime::ASMUtils::TileCoordsToKey((Vector3Int *)&v36, 0LL);
		    m_lruCache = this->fields.m_lruCache;
		    if ( !m_lruCache )
		      goto LABEL_17;
		    v13 = (unsigned __int64)HG::Rendering::Runtime::LRUCache::Allocate(m_lruCache, v10, 0LL);
		    vtIndex = HIDWORD(v13);
		    if ( HIDWORD(v13) == -1 )
		    {
		      if ( !asmTileManager )
		        goto LABEL_17;
		    }
		    else
		    {
		      v14 = HG::Rendering::Runtime::ASMUtils::KeyToTileCoords((Vector3Int *)&v38, SHIDWORD(v13), 0LL);
		      v15 = *(_QWORD *)&v14->m_X;
		      v16 = v14->m_Z;
		      *(_QWORD *)&v36 = *(_QWORD *)&v14->m_X;
		      if ( !asmTileManager )
		        goto LABEL_17;
		      m_lruCache = (LRUCache *)asmTileManager->fields.m_cachedTilesDict;
		      if ( !m_lruCache )
		        goto LABEL_17;
		      *(_QWORD *)&v37.m_X = v15;
		      v37.m_Z = v16;
		      if ( (unsigned __int8)sub_180582078(
		                              m_lruCache,
		                              &v37,
		                              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
		      {
		        m_lruCache = (LRUCache *)asmTileManager->fields.m_cachedTilesDict;
		        if ( !m_lruCache )
		          goto LABEL_17;
		        *(_QWORD *)&v37.m_X = v36;
		        v37.m_Z = v16;
		        v17 = (int)sub_1808B56E8(m_lruCache, &v37);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		        InvalidTile = HG::Rendering::Runtime::ASMTile::get_InvalidTile(&v39, v18);
		        v20 = 9 * v17;
		        v21 = *(_OWORD *)&InvalidTile->mins.x;
		        vtIndex = (unsigned int)InvalidTile->vtIndex;
		        v22 = *(_OWORD *)&InvalidTile->tileCoords.m_X;
		        m_Buffer = asmTileManager->fields.m_cachedTiles.m_Buffer;
		        *(_OWORD *)&m_Buffer[4 * v20] = v21;
		        *(_OWORD *)&m_Buffer[4 * v20 + 16] = v22;
		        *(_DWORD *)&m_Buffer[4 * v20 + 32] = vtIndex;
		        m_lruCache = (LRUCache *)asmTileManager->fields.m_cachedTilesDict;
		        if ( !m_lruCache )
		          goto LABEL_17;
		        *(_QWORD *)&v37.m_X = v36;
		        v37.m_Z = v16;
		        sub_180582198(
		          m_lruCache,
		          &v37,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove);
		      }
		    }
		    m_lruCache = (LRUCache *)asmTileManager->fields.m_cachedTilesDict;
		    if ( m_lruCache )
		    {
		      v24 = tileCoords->m_Z;
		      *(_QWORD *)&v37.m_X = *(_QWORD *)&tileCoords->m_X;
		      v37.m_Z = v24;
		      result = sub_180582078(
		                 m_lruCache,
		                 &v37,
		                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey);
		      if ( !result )
		        return result;
		      m_lruCache = (LRUCache *)asmTileManager->fields.m_cachedTilesDict;
		      if ( m_lruCache )
		      {
		        v26 = tileCoords->m_Z;
		        *(_QWORD *)&v37.m_X = *(_QWORD *)&tileCoords->m_X;
		        v37.m_Z = v26;
		        v27 = (int)sub_1808B56E8(m_lruCache, &v37);
		        v28 = asmTileManager->fields.m_cachedTiles.m_Buffer;
		        v29 = startVTIdx + v13 - 1;
		        vtIndex = 9 * v27;
		        m_lruCache = (LRUCache *)asmTileManager->fields.m_cachedTilesDict;
		        v38 = *(_OWORD *)&v28[4 * vtIndex];
		        v36 = *(_OWORD *)&v28[4 * vtIndex + 16];
		        if ( m_lruCache )
		        {
		          v30 = tileCoords->m_Z;
		          *(_QWORD *)&v37.m_X = *(_QWORD *)&tileCoords->m_X;
		          v37.m_Z = v30;
		          v31 = (int)sub_1808B56E8(m_lruCache, &v37);
		          v32 = asmTileManager->fields.m_cachedTiles.m_Buffer;
		          v33 = v36;
		          v34 = 9 * v31;
		          *(_OWORD *)&v32[4 * v34] = v38;
		          *(_OWORD *)&v32[4 * v34 + 16] = v33;
		          *(_DWORD *)&v32[4 * v34 + 32] = v29;
		          return 1;
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(m_lruCache, vtIndex);
		  }
		  m_lruCache = (LRUCache *)IFix::WrappersManagerImpl::GetPatch(2053, 0LL);
		  if ( !m_lruCache )
		    goto LABEL_17;
		  v35 = tileCoords->m_Z;
		  *(_QWORD *)&v37.m_X = *(_QWORD *)&tileCoords->m_X;
		  v37.m_Z = v35;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_823(
		           (ILFixDynamicMethodWrapper_2 *)m_lruCache,
		           (Object *)this,
		           (Object *)asmTileManager,
		           &v37,
		           startVTIdx,
		           0LL);
		}
		
		public void VisitTilesThisFrame(ASMTileManager asmTileManager, int startVTIdx) {} // 0x0000000189D1B73C-0x0000000189D1B924
		// Void VisitTilesThisFrame(ASMTileManager, Int32)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGASMVirtualTextureAllocator::VisitTilesThisFrame(
		        HGASMVirtualTextureAllocator *this,
		        ASMTileManager *asmTileManager,
		        int32_t startVTIdx,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Void *m_Buffer; // r8
		  LRUCache *m_lruCache; // rcx
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  int value; // [rsp+30h] [rbp-98h] BYREF
		  Vector3Int key; // [rsp+38h] [rbp-90h] BYREF
		  Il2CppException *ex; // [rsp+48h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ *v18; // [rsp+50h] [rbp-78h]
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v19; // [rsp+58h] [rbp-70h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v20; // [rsp+80h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v21; // [rsp+A8h] [rbp-20h] BYREF
		  KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ current; // [rsp+B0h] [rbp-18h] BYREF
		
		  *(_QWORD *)&key.m_X = 0LL;
		  key.m_Z = 0;
		  value = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2077, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2077, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
		      (ILFixDynamicMethodWrapper_15 *)Patch,
		      (Object *)this,
		      (Object *)asmTileManager,
		      startVTIdx,
		      0LL);
		  }
		  else
		  {
		    if ( !asmTileManager )
		      sub_1800D8260(v8, v7);
		    if ( !asmTileManager->fields.m_cachedTilesDict )
		      sub_1800D8260(v8, v7);
		    System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)&v19,
		      (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)asmTileManager->fields.m_cachedTilesDict,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
		    v20 = v19;
		    ex = 0LL;
		    v18 = &v20;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
		                &v20,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
		      {
		        current = (KeyValuePair_2_UnityEngine_Vector3Int_System_Single_)v20._current;
		        System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::Deconstruct(
		          &current,
		          &key,
		          (float *)&value,
		          MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
		        m_Buffer = asmTileManager->fields.m_cachedTiles.m_Buffer;
		        if ( (unsigned __int8)BYTE6(*(_QWORD *)&m_Buffer[36 * value + 24])
		          && *(_DWORD *)&m_Buffer[36 * value + 32] != -1 )
		        {
		          m_lruCache = this->fields.m_lruCache;
		          v11 = *(unsigned int *)&m_Buffer[36 * value + 32];
		          if ( !m_lruCache )
		            sub_1800D8250(0LL, v11);
		          HG::Rendering::Runtime::LRUCache::Visit(m_lruCache, v11 - startVTIdx + 1, 0LL);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v21 )
		    {
		      ex = v21->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
	}
}
