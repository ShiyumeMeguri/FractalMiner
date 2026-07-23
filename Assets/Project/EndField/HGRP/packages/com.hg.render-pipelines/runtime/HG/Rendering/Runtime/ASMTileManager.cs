using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class ASMTileManager // TypeDefIndex: 37817
	{
		// Fields
		public const int MAX_TILE_COUNT = 256; // Metadata: 0x02303173
		public NativeArray<ASMTile> m_cachedTiles; // 0x10
		private NativeArray<int> m_calculateTileVisibilityJob_tileIndicies; // 0x20
		private NativeArray<Vector2> m_frustumVerts; // 0x30
		private NativeArray<Vector2> m_frustumVertsForIndirect; // 0x40
		public ASMTile[] m_tilesThisFrame; // 0x50
		private LRUCache m_cachedTilesLRUCache; // 0x58
		private int m_tilesThisFrameCount; // 0x60
		public Dictionary<Vector3Int, int> m_cachedTilesDict; // 0x68
		private int m_renderCountThisFrame; // 0x70
		private NativeArray<ScoreIndexStruct> m_tempCachedTilesScore; // 0x78
		private NativeArray<int> m_tilesForRenderThisFrame; // 0x88
	
		// Nested types
		private struct ScoreIndexStruct : IComparable<ScoreIndexStruct> // TypeDefIndex: 37814
		{
			// Fields
			public int index; // 0x00
			public float score; // 0x04
	
			// Methods
			public int CompareTo(ScoreIndexStruct obj) => default; // 0x0000000189D24FF8-0x0000000189D25064
			// Int32 CompareTo(ASMTileManager+ScoreIndexStruct)
			int32_t HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct::CompareTo(
			        ASMTileManager_ScoreIndexStruct *this,
			        ASMTileManager_ScoreIndexStruct obj,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  float score; // [rsp+3Ch] [rbp+14h]
			
			  score = obj.score;
			  if ( !IFix::WrappersManagerImpl::IsPatched(2057, 0LL) )
			    return System::Single::CompareTo((Single *)&this->score, score, 0LL);
			  Patch = IFix::WrappersManagerImpl::GetPatch(2057, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v8, v7);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_827(Patch, this, obj, 0LL);
			}
			
		}
	
		[BurstCompile]
		private struct CalculateTileVisibilities : IJob // TypeDefIndex: 37815
		{
			// Fields
			public NativeArray<ASMTile> cachedTiles; // 0x00
			[ReadOnly]
			public NativeArray<int> tileIndices; // 0x10
			[ReadOnly]
			public NativeArray<Vector2> frustumVerts; // 0x20
			public int count; // 0x30
			public Vector2 centerPoint; // 0x34
			public float radius; // 0x3C
	
			// Methods
			public void Execute() {} // 0x000000018860CF34-0x000000018860D098
			// Void Execute()
			void HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities::Execute(
			        ASMTileManager_CalculateTileVisibilities *this,
			        MethodInfo *method)
			{
			  int32_t v2; // edi
			  __int64 v4; // rsi
			  __int64 v5; // r15
			  __m128 v6; // xmm7
			  int32_t v7; // r14d
			  __m128i v8; // xmm6
			  __int64 v9; // rax
			  bool v10; // al
			  NativeArray_1_UnityEngine_Vector2_ frustumVerts; // xmm0
			  Vector2 v12; // rdx
			  __int64 v13; // rcx
			  Void *m_Buffer; // rax
			  __m128i v15; // xmm0
			  NativeArray_1_UnityEngine_Vector2_ v16; // [rsp+28h] [rbp-49h] BYREF
			  ASMTile v17; // [rsp+38h] [rbp-39h] BYREF
			  __m128i v18; // [rsp+78h] [rbp+7h]
			
			  v2 = 0;
			  if ( this->count > 0 )
			  {
			    v4 = 0LL;
			    do
			    {
			      v5 = *(int *)&this->tileIndices.m_Buffer[v4];
			      v6 = *(__m128 *)&this->cachedTiles.m_Buffer[36 * v5];
			      v7 = *(_DWORD *)&this->cachedTiles.m_Buffer[36 * v5 + 32];
			      v8 = *(__m128i *)&this->cachedTiles.m_Buffer[36 * v5 + 16];
			      v9 = HIDWORD(*(_QWORD *)&this->cachedTiles.m_Buffer[36 * v5 + 24]);
			      v17.vtIndex = v7;
			      v18 = v8;
			      *(__m128 *)&v17.mins.x = v6;
			      if ( (_BYTE)v9 )
			      {
			        frustumVerts = this->frustumVerts;
			        v17.vtIndex = v7;
			        *(__m128i *)&v17.tileCoords.m_X = v8;
			        v16 = frustumVerts;
			        if ( HG::Rendering::Runtime::ASMUtils::IsTileFrustumIntersecting(
			               &v16,
			               (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v6, _mm_shuffle_ps(v6, v6, 85)),
			               (Vector2)*(_OWORD *)&_mm_unpacklo_ps(_mm_shuffle_ps(v6, v6, 170), _mm_shuffle_ps(v6, v6, 255)),
			               0LL) )
			        {
			          v10 = 1;
			          goto LABEL_9;
			        }
			        if ( !_mm_cvtsi128_si32(_mm_srli_si128(v8, 8)) )
			        {
			          v12 = (Vector2)_mm_unpacklo_ps((__m128)LODWORD(this->centerPoint.x), (__m128)LODWORD(this->centerPoint.y)).m128_u64[0];
			          *(__m128 *)&v17.mins.x = v6;
			          *(__m128i *)&v17.tileCoords.m_X = v8;
			          v17.vtIndex = v7;
			          v10 = this->radius > HG::Rendering::Runtime::ASMUtils::ASMTileDistance(&v17, v12, 0LL);
			          goto LABEL_9;
			        }
			      }
			      v10 = 0;
			LABEL_9:
			      v13 = 9 * v5;
			      v18.m128i_i8[14] = v10;
			      m_Buffer = this->cachedTiles.m_Buffer;
			      ++v2;
			      v15 = v18;
			      v4 += 4LL;
			      *(__m128 *)&m_Buffer[4 * v13] = v6;
			      *(__m128i *)&m_Buffer[4 * v13 + 16] = v15;
			      *(_DWORD *)&m_Buffer[4 * v13 + 32] = v7;
			    }
			    while ( v2 < this->count );
			  }
			}
			
		}
	
		[BurstCompile]
		private struct CalculateTileScoresJob : IJob // TypeDefIndex: 37816
		{
			// Fields
			[ReadOnly]
			public NativeArray<ASMTile> cachedTiles; // 0x00
			[ReadOnly]
			public NativeArray<Vector2> frustumVerts; // 0x10
			[WriteOnly]
			public NativeArray<ScoreIndexStruct> cachedTilesScore; // 0x20
			public int count; // 0x30
			public Vector2 frustumCenterPos; // 0x34
	
			// Methods
			public void Execute() {} // 0x0000000189D157F0-0x0000000189D15978
			// Void Execute()
			void HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob::Execute(
			        ASMTileManager_CalculateTileScoresJob *this,
			        MethodInfo *method)
			{
			  int32_t v2; // esi
			  __int64 v4; // r14
			  __int64 v5; // rbx
			  Void *m_Buffer; // rcx
			  float v7; // xmm6_4
			  __m128 v8; // xmm7
			  __m128i v9; // xmm8
			  __int64 v10; // rax
			  __int64 v11; // rax
			  __m128 y_low; // xmm2
			  float v13; // xmm0_4
			  NativeArray_1_UnityEngine_Vector2_ frustumVerts; // [rsp+20h] [rbp-78h] BYREF
			  ASMTile v15; // [rsp+30h] [rbp-68h] BYREF
			  unsigned __int64 v16; // [rsp+A0h] [rbp+8h]
			
			  v2 = 0;
			  if ( this->count > 0 )
			  {
			    v4 = 0LL;
			    v5 = 0LL;
			    do
			    {
			      m_Buffer = this->cachedTiles.m_Buffer;
			      v7 = 3.4028235e38;
			      v8 = *(__m128 *)&this->cachedTiles.m_Buffer[v5];
			      v15.vtIndex = *(_DWORD *)&this->cachedTiles.m_Buffer[v5 + 32];
			      v9 = *(__m128i *)&m_Buffer[v5 + 16];
			      v10 = HIDWORD(*(_QWORD *)&m_Buffer[v5 + 24]);
			      *(__m128 *)&v15.mins.x = v8;
			      if ( (_BYTE)v10 )
			      {
			        v15.vtIndex = *(_DWORD *)&m_Buffer[v5 + 32];
			        v11 = *(_QWORD *)&m_Buffer[v5 + 24] >> 40;
			        *(__m128 *)&v15.mins.x = v8;
			        if ( !(_BYTE)v11 )
			        {
			          y_low = (__m128)LODWORD(this->frustumCenterPos.y);
			          v15.vtIndex = *(_DWORD *)&m_Buffer[v5 + 32];
			          *(__m128 *)&v15.mins.x = v8;
			          *(__m128i *)&v15.tileCoords.m_X = v9;
			          v13 = HG::Rendering::Runtime::ASMUtils::ASMTileDistance(
			                  &v15,
			                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(this->frustumCenterPos.x), y_low),
			                  0LL);
			          frustumVerts = this->frustumVerts;
			          v7 = v13 + (float)(100000 * _mm_cvtsi128_si32(_mm_srli_si128(v9, 8)));
			          if ( !HG::Rendering::Runtime::ASMUtils::IsTileFrustumIntersecting(
			                  &frustumVerts,
			                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v8, _mm_shuffle_ps(v8, v8, 85)),
			                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps(_mm_shuffle_ps(v8, v8, 170), _mm_shuffle_ps(v8, v8, 255)),
			                  0LL) )
			            v7 = v7 + 5000.0;
			        }
			      }
			      v5 += 36LL;
			      v16 = __PAIR64__(LODWORD(v7), v2++);
			      *(_QWORD *)&this->cachedTilesScore.m_Buffer[v4] = v16;
			      v4 += 8LL;
			    }
			    while ( v2 < this->count );
			  }
			}
			
		}
	
		// Constructors
		public ASMTileManager() {} // 0x0000000189D06A5C-0x0000000189D06C34
		// ASMTileManager()
		void HG::Rendering::Runtime::ASMTileManager::ASMTileManager(ASMTileManager *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  LRUCache *v6; // rax
		  Type *v7; // rdx
		  __int64 v8; // rcx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryVisual_ECSRangeVoxelInfo_ *v11; // rax
		  Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *v12; // rdi
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *methodc; // [rsp+20h] [rbp-20h]
		  MethodInfo *methoda; // [rsp+20h] [rbp-20h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-20h]
		  NativeArray_1_BeyondDynamicBone_SelfCollisionConstraint_PointTriangleContact_ v19; // [rsp+30h] [rbp-10h] BYREF
		
		  v19 = 0LL;
		  Unity::Collections::NativeArray<BeyondDynamicBone::SelfCollisionConstraint::PointTriangleContact>::NativeArray(
		    &v19,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::NativeArray);
		  this->fields.m_cachedTiles = (NativeArray_1_HG_Rendering_Runtime_ASMTile_)v19;
		  v19 = 0LL;
		  Unity::Collections::NativeArray<int>::NativeArray(
		    (NativeArray_1_System_Int32_ *)&v19,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		  this->fields.m_calculateTileVisibilityJob_tileIndicies = (NativeArray_1_System_Int32_)v19;
		  v19 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::float2>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_float2_ *)&v19,
		    5,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray);
		  this->fields.m_frustumVerts = (NativeArray_1_UnityEngine_Vector2_)v19;
		  v19 = 0LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::float2>::NativeArray(
		    (NativeArray_1_Unity_Mathematics_float2_ *)&v19,
		    5,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::NativeArray);
		  this->fields.m_frustumVertsForIndirect = (NativeArray_1_UnityEngine_Vector2_)v19;
		  this->fields.m_tilesThisFrame = (ASMTile__Array *)il2cpp_array_new_specific_1(
		                                                      TypeInfo::HG::Rendering::Runtime::ASMTile,
		                                                      256LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_tilesThisFrame, v3, v4, v5, methodc);
		  v6 = (LRUCache *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::LRUCache);
		  if ( !v6
		    || (this->fields.m_cachedTilesLRUCache = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_cachedTilesLRUCache, v7, v9, v10, methoda),
		        v11 = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryVisual_ECSRangeVoxelInfo_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>),
		        (v12 = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)v11) == 0LL) )
		  {
		    sub_1800D8260(v8, v7);
		  }
		  System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RemoteFactoryVisual::ECSRangeVoxelInfo>::Dictionary(
		    v11,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Dictionary);
		  this->fields.m_cachedTilesDict = v12;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_cachedTilesDict, v13, v14, v15, methodb);
		  v19 = 0LL;
		  Unity::Collections::NativeArray<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::NativeArray(
		    (NativeArray_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v19,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>::NativeArray);
		  this->fields.m_tempCachedTilesScore = (NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_)v19;
		  v19 = 0LL;
		  Unity::Collections::NativeArray<int>::NativeArray(
		    (NativeArray_1_System_Int32_ *)&v19,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		  this->fields.m_tilesForRenderThisFrame = (NativeArray_1_System_Int32_)v19;
		}
		
	
		// Methods
		public void Initialize() {} // 0x0000000189D05F20-0x0000000189D05F70
		// Void Initialize()
		void HG::Rendering::Runtime::ASMTileManager::Initialize(ASMTileManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(443, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(443, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(this, 0LL);
		  }
		}
		
		public void Dispose() {} // 0x0000000189D04C30-0x0000000189D04CDC
		// Void Dispose()
		void HG::Rendering::Runtime::ASMTileManager::Dispose(ASMTileManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(553, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(553, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Unity::Collections::NativeArray<BeyondDynamicBone::WindManager::WindData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_WindManager_WindData_ *)&this->fields,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::Dispose);
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		      (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_calculateTileVisibilityJob_tileIndicies,
		      MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_frustumVerts,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_frustumVertsForIndirect,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector2>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::WindManager::WindData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_WindManager_WindData_ *)&this->fields.m_tempCachedTilesScore,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>::Dispose);
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		      (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_tilesForRenderThisFrame,
		      MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		  }
		}
		
		[IDTag(0)]
		public ASMTile GetTile(Vector3Int key) => default; // 0x0000000189D05B0C-0x0000000189D05C64
		// ASMTile GetTile(Vector3Int)
		ASMTile *HG::Rendering::Runtime::ASMTileManager::GetTile(
		        ASMTile *__return_ptr retstr,
		        ASMTileManager *this,
		        Vector3Int *key,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rcx
		  int32_t v9; // eax
		  int32_t v10; // eax
		  int v11; // eax
		  Void *m_Buffer; // rcx
		  __m128i v13; // xmm1
		  __int128 v14; // xmm0
		  __int64 v15; // rcx
		  Void *v16; // rax
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  int32_t vtIndex; // eax
		  MethodInfo *v20; // rdx
		  ASMTile *InvalidTile; // rax
		  int32_t m_Z; // eax
		  Vector3Int v24; // [rsp+30h] [rbp-40h] BYREF
		  ASMTile v25; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2043, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2043, 0LL);
		    if ( Patch )
		    {
		      m_Z = key->m_Z;
		      *(_QWORD *)&v24.m_X = *(_QWORD *)&key->m_X;
		      v24.m_Z = m_Z;
		      InvalidTile = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_818(&v25, Patch, (Object *)this, &v24, 0LL);
		      goto LABEL_11;
		    }
		    goto LABEL_9;
		  }
		  m_cachedTilesDict = this->fields.m_cachedTilesDict;
		  if ( !m_cachedTilesDict )
		    goto LABEL_9;
		  v9 = key->m_Z;
		  *(_QWORD *)&v24.m_X = *(_QWORD *)&key->m_X;
		  v24.m_Z = v9;
		  if ( !(unsigned __int8)sub_180582078(
		                           m_cachedTilesDict,
		                           &v24,
		                           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
		  {
		LABEL_7:
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		    InvalidTile = HG::Rendering::Runtime::ASMTile::get_InvalidTile(&v25, v20);
		LABEL_11:
		    v17 = *(_OWORD *)&InvalidTile->mins.x;
		    v18 = *(_OWORD *)&InvalidTile->tileCoords.m_X;
		    vtIndex = InvalidTile->vtIndex;
		    goto LABEL_12;
		  }
		  m_cachedTilesDict = this->fields.m_cachedTilesDict;
		  if ( !m_cachedTilesDict )
		LABEL_9:
		    sub_1800D8260(m_cachedTilesDict, Patch);
		  v10 = key->m_Z;
		  *(_QWORD *)&v24.m_X = *(_QWORD *)&key->m_X;
		  v24.m_Z = v10;
		  v11 = sub_1808B56E8(m_cachedTilesDict, &v24);
		  m_Buffer = this->fields.m_cachedTiles.m_Buffer;
		  v13 = *(__m128i *)&m_Buffer[36 * v11 + 16];
		  v14 = *(_OWORD *)&m_Buffer[36 * v11];
		  v25.vtIndex = *(_DWORD *)&m_Buffer[36 * v11 + 32];
		  *(_OWORD *)&v25.mins.x = v14;
		  if ( !_mm_srli_si128(v13, 8).m128i_i8[4] )
		    goto LABEL_7;
		  v15 = 9LL * v11;
		  v16 = this->fields.m_cachedTiles.m_Buffer;
		  v17 = *(_OWORD *)&v16[4 * v15];
		  v18 = *(_OWORD *)&v16[4 * v15 + 16];
		  vtIndex = *(_DWORD *)&v16[4 * v15 + 32];
		LABEL_12:
		  *(_OWORD *)&retstr->mins.x = v17;
		  *(_OWORD *)&retstr->tileCoords.m_X = v18;
		  retstr->vtIndex = vtIndex;
		  return retstr;
		}
		
		[IDTag(1)]
		public ASMTile GetTile(int cachedTileIndex) => default; // 0x0000000189D05C64-0x0000000189D05D1C
		// ASMTile GetTile(Int32)
		ASMTile *HG::Rendering::Runtime::ASMTileManager::GetTile(
		        ASMTile *__return_ptr retstr,
		        ASMTileManager *this,
		        int32_t cachedTileIndex,
		        MethodInfo *method)
		{
		  __int64 v5; // rdi
		  Void *m_Buffer; // rax
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  int32_t vtIndex; // eax
		  MethodInfo *v11; // rdx
		  ASMTile *InvalidTile; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  ASMTile v17; // [rsp+30h] [rbp-38h] BYREF
		
		  v5 = cachedTileIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(2044, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2044, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    InvalidTile = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_819(&v17, Patch, (Object *)this, v5, 0LL);
		    goto LABEL_8;
		  }
		  if ( (unsigned int)v5 > 0xFF )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		    InvalidTile = HG::Rendering::Runtime::ASMTile::get_InvalidTile(&v17, v11);
		LABEL_8:
		    v8 = *(_OWORD *)&InvalidTile->mins.x;
		    v9 = *(_OWORD *)&InvalidTile->tileCoords.m_X;
		    vtIndex = InvalidTile->vtIndex;
		    goto LABEL_9;
		  }
		  m_Buffer = this->fields.m_cachedTiles.m_Buffer;
		  v8 = *(_OWORD *)&m_Buffer[36 * v5];
		  v9 = *(_OWORD *)&m_Buffer[36 * v5 + 16];
		  vtIndex = *(_DWORD *)&m_Buffer[36 * v5 + 32];
		LABEL_9:
		  *(_OWORD *)&retstr->mins.x = v8;
		  *(_OWORD *)&retstr->tileCoords.m_X = v9;
		  retstr->vtIndex = vtIndex;
		  return retstr;
		}
		
		public void SetFrustumVerts(Vector2[] verts, Vector2[] vertsForIndirect) {} // 0x0000000189D0635C-0x0000000189D06430
		// Void SetFrustumVerts(Vector2[], Vector2[])
		void HG::Rendering::Runtime::ASMTileManager::SetFrustumVerts(
		        ASMTileManager *this,
		        Vector2__Array *verts,
		        Vector2__Array *vertsForIndirect,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdi
		  int v10; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // [rsp+30h] [rbp-18h] BYREF
		  __int64 v13; // [rsp+38h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2045, 0LL) )
		  {
		    v9 = 0LL;
		    v10 = 0;
		    if ( verts )
		    {
		      while ( 1 )
		      {
		        sub_1800473A0(verts, &v12, v10);
		        *(_QWORD *)&this->fields.m_frustumVerts.m_Buffer[v9] = v12;
		        if ( !vertsForIndirect )
		          break;
		        sub_1800473A0(vertsForIndirect, &v13, v10++);
		        *(_QWORD *)&this->fields.m_frustumVertsForIndirect.m_Buffer[v9] = v13;
		        v9 += 8LL;
		        if ( v10 >= 5 )
		          return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2045, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)verts,
		    (Object *)vertsForIndirect,
		    0LL);
		}
		
		public int GetValidTileCount() => default; // 0x0000000189D05D80-0x0000000189D05F20
		// Int32 GetValidTileCount()
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::Runtime::ASMTileManager::GetValidTileCount(ASMTileManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t v5; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3Int key; // [rsp+20h] [rbp-98h] BYREF
		  Il2CppException *ex; // [rsp+30h] [rbp-88h]
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ *v12; // [rsp+38h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v13; // [rsp+40h] [rbp-78h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v14; // [rsp+68h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v15; // [rsp+90h] [rbp-28h] BYREF
		  KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ current; // [rsp+98h] [rbp-20h] BYREF
		  int value; // [rsp+D0h] [rbp+18h] BYREF
		  int32_t v18; // [rsp+D8h] [rbp+20h]
		
		  *(_QWORD *)&key.m_X = 0LL;
		  key.m_Z = 0;
		  value = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2046, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2046, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = 0;
		    v18 = 0;
		    if ( !this->fields.m_cachedTilesDict )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)&v13,
		      (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_cachedTilesDict,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
		    v14 = v13;
		    ex = 0LL;
		    v12 = &v14;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
		                &v14,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
		      {
		        current = (KeyValuePair_2_UnityEngine_Vector3Int_System_Single_)v14._current;
		        System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::Deconstruct(
		          &current,
		          &key,
		          (float *)&value,
		          MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
		        if ( _mm_srli_si128(*(__m128i *)((_QWORD)this[16LL] + 36LL * value + 16), 8).m128i_i8[4] )
		          v18 = ++v5;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      ex = v15->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      return v18;
		    }
		    return v5;
		  }
		}
		
		public int GetRenderedTileCount() => default; // 0x0000000189D0591C-0x0000000189D05AC0
		// Int32 GetRenderedTileCount()
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::Runtime::ASMTileManager::GetRenderedTileCount(ASMTileManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t v5; // ebx
		  Void *m_Buffer; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Vector3Int key; // [rsp+20h] [rbp-98h] BYREF
		  Il2CppException *ex; // [rsp+30h] [rbp-88h]
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ *v13; // [rsp+38h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v14; // [rsp+40h] [rbp-78h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v15; // [rsp+68h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v16; // [rsp+90h] [rbp-28h] BYREF
		  KeyValuePair_2_UnityEngine_Vector3Int_System_Single_ current; // [rsp+98h] [rbp-20h] BYREF
		  int value; // [rsp+D0h] [rbp+18h] BYREF
		  int32_t v19; // [rsp+D8h] [rbp+20h]
		
		  *(_QWORD *)&key.m_X = 0LL;
		  key.m_Z = 0;
		  value = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2047, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2047, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = 0;
		    v19 = 0;
		    if ( !this->fields.m_cachedTilesDict )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)&v14,
		      (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)this->fields.m_cachedTilesDict,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::GetEnumerator);
		    v15 = v14;
		    ex = 0LL;
		    v13 = &v15;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
		                &v15,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
		      {
		        current = (KeyValuePair_2_UnityEngine_Vector3Int_System_Single_)v15._current;
		        System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,float>::Deconstruct(
		          &current,
		          &key,
		          (float *)&value,
		          MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Vector3Int,int>::Deconstruct);
		        m_Buffer = this->fields.m_cachedTiles.m_Buffer;
		        if ( (unsigned __int8)BYTE4(*(_QWORD *)&m_Buffer[36 * value + 24]) )
		        {
		          if ( (unsigned __int16)WORD2(*(_QWORD *)&m_Buffer[36 * value + 24]) >> 8 )
		            v19 = ++v5;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v16 )
		    {
		      ex = v16->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      return v19;
		    }
		    return v5;
		  }
		}
		
		public void InvalidateAllTiles() {} // 0x0000000189D05F70-0x0000000189D0603C
		// Void InvalidateAllTiles()
		void HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(ASMTileManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rcx
		  int32_t v5; // esi
		  __int64 v6; // rdi
		  MethodInfo *v7; // rdx
		  ASMTile *InvalidTile; // rax
		  __int128 v9; // xmm0
		  int32_t vtIndex; // ecx
		  __int128 v11; // xmm1
		  Void *m_Buffer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ASMTile v14; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(444, 0LL) )
		  {
		    m_cachedTilesDict = this->fields.m_cachedTilesDict;
		    if ( m_cachedTilesDict )
		    {
		      System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear(
		        m_cachedTilesDict,
		        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Clear);
		      this->fields.m_renderCountThisFrame = 0;
		      v5 = 0;
		      if ( this->fields.m_cachedTiles.m_Length > 0 )
		      {
		        v6 = 0LL;
		        do
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		          InvalidTile = HG::Rendering::Runtime::ASMTile::get_InvalidTile(&v14, v7);
		          ++v5;
		          v9 = *(_OWORD *)&InvalidTile->mins.x;
		          vtIndex = InvalidTile->vtIndex;
		          v11 = *(_OWORD *)&InvalidTile->tileCoords.m_X;
		          m_Buffer = this->fields.m_cachedTiles.m_Buffer;
		          *(_OWORD *)&m_Buffer[v6] = v9;
		          *(_OWORD *)&m_Buffer[v6 + 16] = v11;
		          *(_DWORD *)&m_Buffer[v6 + 32] = vtIndex;
		          v6 += 36LL;
		        }
		        while ( v5 < this->fields.m_cachedTiles.m_Length );
		      }
		      m_cachedTilesDict = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)this->fields.m_cachedTilesLRUCache;
		      if ( m_cachedTilesDict )
		      {
		        HG::Rendering::Runtime::LRUCache::Reset((LRUCache *)m_cachedTilesDict, 128, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(m_cachedTilesDict, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(444, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void CreateTilesThisFrame(Vector2 centerPoint, float radius, float gridSize) {} // 0x0000000189D04A08-0x0000000189D04C30
		// Void CreateTilesThisFrame(Vector2, Single, Single)
		void HG::Rendering::Runtime::ASMTileManager::CreateTilesThisFrame(
		        ASMTileManager *this,
		        Vector2 centerPoint,
		        float radius,
		        float gridSize,
		        MethodInfo *method)
		{
		  char v7; // dl
		  __int64 v8; // rcx
		  int v9; // r8d
		  int32_t v10; // edi
		  int32_t v11; // r15d
		  char v12; // dl
		  __int64 v13; // rcx
		  int v14; // r8d
		  int32_t v15; // r14d
		  int32_t v16; // ebp
		  int32_t i; // ebx
		  double v18; // xmm0_8
		  __int64 v19; // rcx
		  ASMTile__Array *m_tilesThisFrame; // rdx
		  __int64 m_tilesThisFrameCount; // rax
		  __int64 v22; // rcx
		  int32_t vtIndex; // eax
		  __int128 v24; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // [rsp+38h] [rbp-90h]
		  __int64 v27; // [rsp+40h] [rbp-88h] BYREF
		  ASMTile v28; // [rsp+48h] [rbp-80h] BYREF
		
		  memset(&v28, 0, sizeof(v28));
		  if ( IFix::WrappersManagerImpl::IsPatched(2048, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2048, 0LL);
		    if ( !Patch )
		LABEL_14:
		      sub_1800D8260(v19, m_tilesThisFrame);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_820(Patch, (Object *)this, centerPoint, radius, gridSize, 0LL);
		  }
		  else
		  {
		    this->fields.m_tilesThisFrameCount = 0;
		    v10 = sub_1834464B0(v8, v7, v9) - 1;
		    v11 = sub_1832DBD50() + 1;
		    v15 = sub_1834464B0(v13, v12, v14) - 1;
		    v16 = sub_1832DBD50() + 1;
		    while ( v10 <= v11 )
		    {
		      for ( i = v15; i <= v16; ++i )
		      {
		        *((float *)&v26 + 1) = (float)((float)i + 0.5) * gridSize;
		        *(float *)&v26 = (float)((float)v10 + 0.5) * gridSize;
		        v27 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(v26, centerPoint);
		        v18 = sub_182FA2AF0(&v27);
		        if ( radius > (float)(*(float *)&v18 - (float)(gridSize * 0.80000001)) )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		          HG::Rendering::Runtime::ASMTile::ASMTile(&v28, v10, i, 0, gridSize, 0LL);
		          m_tilesThisFrame = this->fields.m_tilesThisFrame;
		          if ( !m_tilesThisFrame )
		            goto LABEL_14;
		          m_tilesThisFrameCount = this->fields.m_tilesThisFrameCount;
		          if ( (unsigned int)m_tilesThisFrameCount >= m_tilesThisFrame->max_length.size )
		            sub_1800D2AB0(v19, m_tilesThisFrame);
		          v22 = m_tilesThisFrameCount;
		          vtIndex = v28.vtIndex;
		          v24 = *(_OWORD *)&v28.tileCoords.m_X;
		          *(_OWORD *)&m_tilesThisFrame->vector[v22].mins.x = *(_OWORD *)&v28.mins.x;
		          *(_OWORD *)&m_tilesThisFrame->vector[v22].tileCoords.m_X = v24;
		          m_tilesThisFrame->vector[v22].vtIndex = vtIndex;
		          ++this->fields.m_tilesThisFrameCount;
		        }
		      }
		      ++v10;
		    }
		  }
		}
		
		public void UpdateCachedTiles(Vector2 centerPoint, float radius) {} // 0x0000000189D06430-0x0000000189D06A5C
		// Void UpdateCachedTiles(Vector2, Single)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::ASMTileManager::UpdateCachedTiles(
		        ASMTileManager *this,
		        Vector2 centerPoint,
		        float radius,
		        MethodInfo *method)
		{
		  float v4; // xmm6_4
		  ASMTileManager *v5; // rsi
		  Vector2 v6; // xmm7_8
		  ASMTileManager *v7; // r14
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int v10; // edi
		  Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *Values; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *v14; // rbx
		  int32_t m_Length; // r15d
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int32_t Count; // eax
		  VirtualMesh_Work_IntersetcSortJob m_cachedTiles; // xmm1
		  VirtualMesh_Work_IntersetcSortJob m_calculateTileVisibilityJob_tileIndicies; // xmm2
		  VirtualMesh_Work_IntersetcSortJob m_frustumVerts; // xmm3
		  unsigned __int64 vtIndex; // rdx
		  LRUCache *m_tilesThisFrame; // rcx
		  __int64 v24; // r8
		  LRUCache *m_cachedTilesLRUCache; // rcx
		  int32_t v26; // r14d
		  int32_t v27; // eax
		  int32_t v28; // edi
		  ValueTuple_2_Int32_Int32_ v29; // rax
		  ValueTuple_2_Int32_Int32_ v30; // r8
		  int32_t Item1; // ebx
		  Vector3Int *v32; // rax
		  __int64 v33; // xmm6_8
		  int32_t m_Z; // r15d
		  __int64 Item; // rdi
		  MethodInfo *v36; // rdx
		  ASMTile *InvalidTile; // rax
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int64 v40; // rcx
		  Void *m_Buffer; // rax
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int64 v44; // rcx
		  Void *v45; // rax
		  Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rdi
		  __int64 v47; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  __int64 v51; // [rsp+0h] [rbp-1C8h] BYREF
		  Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v52; // [rsp+30h] [rbp-198h] BYREF
		  Vector3Int v53; // [rsp+50h] [rbp-178h] BYREF
		  Vector3Int v54; // [rsp+60h] [rbp-168h] BYREF
		  Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_UnityEngine_Vector3Int_System_Int32_ v55; // [rsp+70h] [rbp-158h] BYREF
		  JobHandle v56; // [rsp+90h] [rbp-138h] BYREF
		  Vector2 v57; // [rsp+A0h] [rbp-128h]
		  Vector3Int v58; // [rsp+B0h] [rbp-118h] BYREF
		  Vector3Int v59; // [rsp+C0h] [rbp-108h] BYREF
		  Vector3Int v60; // [rsp+D0h] [rbp-F8h] BYREF
		  JobHandle v61; // [rsp+E0h] [rbp-E8h] BYREF
		  VirtualMesh_Work_IntersetcSortJob v62[4]; // [rsp+F0h] [rbp-D8h] BYREF
		  Il2CppExceptionWrapper *v63; // [rsp+130h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v64; // [rsp+138h] [rbp-90h] BYREF
		  ASMTile v65; // [rsp+140h] [rbp-88h] BYREF
		  VirtualMesh_Work_IntersetcSortJob v66; // [rsp+170h] [rbp-58h]
		
		  v4 = radius;
		  v5 = this;
		  v6 = centerPoint;
		  v57 = centerPoint;
		  v7 = this;
		  *(_QWORD *)&v54.m_X = this;
		  v61 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2049, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2049, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v50, v49);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_822(Patch, (Object *)v5, v6, radius, 0LL);
		  }
		  else
		  {
		    v10 = 0;
		    if ( !v7->fields.m_cachedTilesDict )
		      sub_1800D8260(v9, v8);
		    Values = System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Values(
		               (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v7->fields.m_cachedTilesDict,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Values);
		    v14 = Values;
		    *(_QWORD *)&v53.m_X = Values;
		    if ( !Values )
		      sub_1800D8260(v13, v12);
		    m_Length = v5->fields.m_calculateTileVisibilityJob_tileIndicies.m_Length;
		    if ( m_Length < System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Count(
		                      Values,
		                      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::get_Count) )
		    {
		      if ( !v14 )
		        sub_1800D8260(v17, v16);
		      Count = System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::get_Count(
		                v14,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::get_Count);
		      UnityEngine::Rendering::ArrayExtensions::ResizeArray<int>(
		        &v5->fields.m_calculateTileVisibilityJob_tileIndicies,
		        Count,
		        Allocator__Enum_Persistent,
		        MethodInfo::UnityEngine::Rendering::ArrayExtensions::ResizeArray<int>);
		    }
		    if ( !v14 )
		      sub_1800D8260(v17, v16);
		    System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)&v52,
		      (Dictionary_2_TKey_TValue_ValueCollection_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)v14,
		      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::GetEnumerator);
		    v55 = v52;
		    v52._dictionary = 0LL;
		    *(_QWORD *)&v52._index = &v55;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
		                &v55,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
		        *(_DWORD *)&v5->fields.m_calculateTileVisibilityJob_tileIndicies.m_Buffer[4 * v10++] = v55._currentValue;
		    }
		    catch ( Il2CppExceptionWrapper *v63 )
		    {
		      v52._dictionary = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)v63->ex;
		      if ( v52._dictionary )
		        sub_18007E1E0(v52._dictionary);
		      v4 = radius;
		      v6 = v57;
		      v5 = this;
		      v14 = *(Dictionary_2_TKey_TValue_ValueCollection_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ **)&v53.m_X;
		      v7 = *(ASMTileManager **)&v54.m_X;
		    }
		    sub_18033B9D0(&v65, 0LL, 64LL);
		    m_cachedTiles = (VirtualMesh_Work_IntersetcSortJob)v5->fields.m_cachedTiles;
		    m_calculateTileVisibilityJob_tileIndicies = (VirtualMesh_Work_IntersetcSortJob)v5->fields.m_calculateTileVisibilityJob_tileIndicies;
		    m_frustumVerts = (VirtualMesh_Work_IntersetcSortJob)v5->fields.m_frustumVerts;
		    *(Vector2 *)((char *)&v66.hitList.m_ListData + 4) = v6;
		    *((float *)&v66.hitList.m_DeprecatedAllocator + 1) = v4;
		    LODWORD(v66.hitList.m_ListData) = v7->fields.m_cachedTiles.m_Length;
		    *(_OWORD *)&v52._dictionary = 0LL;
		    v62[0] = m_cachedTiles;
		    v62[1] = m_calculateTileVisibilityJob_tileIndicies;
		    v62[2] = m_frustumVerts;
		    v62[3] = v66;
		    Unity::Jobs::IJobExtensions::Schedule<BeyondDynamicBone::VirtualMesh::Work_IntersetcSortJob>(
		      &v56,
		      v62,
		      (JobHandle *)&v52,
		      MethodInfo::Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>);
		    v61 = v56;
		    Unity::Jobs::JobHandle::Complete(&v61, 0LL);
		    if ( !v14 )
		      goto LABEL_51;
		    System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)&v52,
		      (Dictionary_2_TKey_TValue_ValueCollection_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)v14,
		      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<UnityEngine::Vector3Int,int>::GetEnumerator);
		    v55 = v52;
		    v52._dictionary = 0LL;
		    *(_QWORD *)&v52._index = &v55;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext(
		                &v55,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<UnityEngine::Vector3Int,int>::MoveNext) )
		      {
		        if ( _mm_srli_si128(*(__m128i *)((_QWORD)v5[16LL] + 36LL * *(int *)(&v55 + 16) + 16), 8).m128i_i8[6] )
		        {
		          m_cachedTilesLRUCache = v5->fields.m_cachedTilesLRUCache;
		          if ( !m_cachedTilesLRUCache )
		            sub_1800D8250(0LL, v55._currentValue);
		          HG::Rendering::Runtime::LRUCache::Visit(m_cachedTilesLRUCache, v55._currentValue, 0LL);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v64 )
		    {
		      vtIndex = (unsigned __int64)&v51;
		      v52._dictionary = (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)v64->ex;
		      if ( v52._dictionary )
		        sub_18007E1E0(v52._dictionary);
		      v5 = this;
		    }
		    v26 = 0;
		    if ( v5->fields.m_tilesThisFrameCount > 0 )
		    {
		      while ( 1 )
		      {
		        m_tilesThisFrame = (LRUCache *)v5->fields.m_tilesThisFrame;
		        if ( !m_tilesThisFrame )
		          break;
		        v54 = *(Vector3Int *)(sub_180469C64(m_tilesThisFrame, v26, v24) + 16);
		        if ( !_mm_srli_si128((__m128i)HG::Rendering::Runtime::ASMTileManager::GetTile(&v65, v5, &v54, 0LL)[16LL], 8).m128i_i8[4] )
		        {
		          m_tilesThisFrame = (LRUCache *)v5->fields.m_tilesThisFrame;
		          if ( !m_tilesThisFrame )
		            break;
		          v53 = *(Vector3Int *)(sub_180469C64(m_tilesThisFrame, v26, v24) + 16);
		          v27 = HG::Rendering::Runtime::ASMUtils::TileCoordsToKey(&v53, 0LL);
		          v28 = v27;
		          m_tilesThisFrame = v5->fields.m_cachedTilesLRUCache;
		          if ( !m_tilesThisFrame )
		            break;
		          v29 = HG::Rendering::Runtime::LRUCache::Allocate(m_tilesThisFrame, v27, 0LL);
		          Item1 = v29.Item1;
		          if ( v29.Item2 != -1 && v29.Item2 != v28 )
		          {
		            v32 = HG::Rendering::Runtime::ASMUtils::KeyToTileCoords((Vector3Int *)&v52, v29.Item2, 0LL);
		            v33 = *(_QWORD *)&v32->m_X;
		            m_Z = v32->m_Z;
		            m_tilesThisFrame = (LRUCache *)v5->fields.m_cachedTilesDict;
		            if ( !m_tilesThisFrame )
		              break;
		            *(_QWORD *)&v58.m_X = *(_QWORD *)&v32->m_X;
		            v58.m_Z = m_Z;
		            if ( System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey(
		                   (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_tilesThisFrame,
		                   &v58,
		                   MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
		            {
		              m_tilesThisFrame = (LRUCache *)v5->fields.m_cachedTilesDict;
		              if ( !m_tilesThisFrame )
		                break;
		              *(_QWORD *)&v59.m_X = v33;
		              v59.m_Z = m_Z;
		              Item = System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item(
		                       (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_tilesThisFrame,
		                       &v59,
		                       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::get_Item);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		              InvalidTile = HG::Rendering::Runtime::ASMTile::get_InvalidTile(&v65, v36);
		              v38 = *(_OWORD *)&InvalidTile->mins.x;
		              v39 = *(_OWORD *)&InvalidTile->tileCoords.m_X;
		              vtIndex = (unsigned int)InvalidTile->vtIndex;
		              v40 = 9 * Item;
		              m_Buffer = v5->fields.m_cachedTiles.m_Buffer;
		              *(_OWORD *)&m_Buffer[4 * v40] = v38;
		              *(_OWORD *)&m_Buffer[4 * v40 + 16] = v39;
		              *(_DWORD *)&m_Buffer[4 * v40 + 32] = vtIndex;
		              m_tilesThisFrame = (LRUCache *)v5->fields.m_cachedTilesDict;
		              if ( !m_tilesThisFrame )
		                break;
		              *(_QWORD *)&v60.m_X = v33;
		              v60.m_Z = m_Z;
		              System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove(
		                (Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *)m_tilesThisFrame,
		                &v60,
		                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::Remove);
		            }
		          }
		          vtIndex = (unsigned __int64)v5->fields.m_tilesThisFrame;
		          if ( !vtIndex )
		            break;
		          if ( (unsigned int)v26 >= *(_DWORD *)(vtIndex + 24) )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD, _QWORD))sub_1800D2AA0)(m_tilesThisFrame, vtIndex, v30);
		          v42 = *(_OWORD *)(vtIndex + 36LL * v26 + 32);
		          v43 = *(_OWORD *)(vtIndex + 36LL * v26 + 48);
		          vtIndex = *(unsigned int *)(vtIndex + 36LL * v26 + 64);
		          v44 = 9LL * Item1;
		          v45 = v5->fields.m_cachedTiles.m_Buffer;
		          *(_OWORD *)&v45[4 * v44] = v42;
		          *(_OWORD *)&v45[4 * v44 + 16] = v43;
		          *(_DWORD *)&v45[4 * v44 + 32] = vtIndex;
		          m_cachedTilesDict = v5->fields.m_cachedTilesDict;
		          m_tilesThisFrame = (LRUCache *)v5->fields.m_tilesThisFrame;
		          if ( !m_tilesThisFrame )
		            break;
		          v47 = ((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_180469C64)(m_tilesThisFrame, v26, v30);
		          if ( !m_cachedTilesDict )
		            break;
		          v56 = *(JobHandle *)(v47 + 16);
		          System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::set_Item(
		            m_cachedTilesDict,
		            (Vector3Int *)&v56,
		            Item1,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::set_Item);
		        }
		        if ( ++v26 >= v5->fields.m_tilesThisFrameCount )
		          return;
		      }
		LABEL_51:
		      sub_1800D8250(m_tilesThisFrame, vtIndex);
		    }
		  }
		}
		
		public void PreRenderTiles(HGASMVirtualTextureAllocator vtAllocator, Vector2 frustumCenterPos, int maxRenderCount, int startVTIdx) {} // 0x0000000189D0603C-0x0000000189D0635C
		// Void PreRenderTiles(HGASMVirtualTextureAllocator, Vector2, Int32, Int32)
		void HG::Rendering::Runtime::ASMTileManager::PreRenderTiles(
		        ASMTileManager *this,
		        HGASMVirtualTextureAllocator *vtAllocator,
		        Vector2 frustumCenterPos,
		        int32_t maxRenderCount,
		        int32_t startVTIdx,
		        MethodInfo *method)
		{
		  NativeArray_1_HG_Rendering_Runtime_ASMTile_ m_cachedTiles; // xmm2
		  NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ m_tempCachedTilesScore; // xmm3
		  NativeArray_1_UnityEngine_Vector2_ m_frustumVerts; // xmm1
		  __int64 v13; // r8
		  __int64 v14; // r9
		  int v15; // edi
		  __int64 v16; // rdx
		  int v17; // eax
		  int32_t v18; // esi
		  __int64 v19; // rdi
		  bool v20; // zf
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v22; // r14
		  __int64 v23; // rdx
		  VirtualMesh_Work_IntersetcSortJob v24; // xmm0
		  __m128i v25; // xmm6
		  Dictionary_2_UnityEngine_Vector3Int_System_Int32_ *m_cachedTilesDict; // rcx
		  Void *m_Buffer; // rax
		  int32_t vtIndex; // edx
		  __int128 v29; // xmm1
		  __int64 v30; // rcx
		  __int128 v31; // xmm0
		  MethodInfo *v32; // rdx
		  ASMTile *InvalidTile; // rax
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  JobHandle v36; // [rsp+48h] [rbp-C0h] BYREF
		  NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v37; // [rsp+58h] [rbp-B0h] BYREF
		  NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v38; // [rsp+68h] [rbp-A0h] BYREF
		  _BYTE v39[16]; // [rsp+78h] [rbp-90h] BYREF
		  __int128 v40; // [rsp+88h] [rbp-80h]
		  __int128 v41; // [rsp+A8h] [rbp-60h]
		  VirtualMesh_Work_IntersetcSortJob v42[2]; // [rsp+B8h] [rbp-50h] BYREF
		  NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v43; // [rsp+D8h] [rbp-30h]
		  __int128 v44; // [rsp+E8h] [rbp-20h]
		  JobHandle v45; // [rsp+F8h] [rbp-10h] BYREF
		  NativeArray_1_HG_Rendering_Runtime_ASMTileManager_ScoreIndexStruct_ v46; // [rsp+108h] [rbp+0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2052, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2052, 0LL);
		    if ( !Patch )
		LABEL_21:
		      sub_1800D8260(Patch, v23);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_824(
		      Patch,
		      (Object *)this,
		      (Object *)vtAllocator,
		      frustumCenterPos,
		      maxRenderCount,
		      startVTIdx,
		      0LL);
		  }
		  else
		  {
		    sub_18033B9D0(v39, 0LL, 64LL);
		    m_cachedTiles = this->fields.m_cachedTiles;
		    m_tempCachedTilesScore = this->fields.m_tempCachedTilesScore;
		    LODWORD(v41) = 256;
		    m_frustumVerts = this->fields.m_frustumVerts;
		    *(Vector2 *)((char *)&v41 + 4) = frustumCenterPos;
		    v38 = 0LL;
		    v37 = 0LL;
		    v44 = v41;
		    v42[0] = (VirtualMesh_Work_IntersetcSortJob)m_cachedTiles;
		    v42[1] = (VirtualMesh_Work_IntersetcSortJob)m_frustumVerts;
		    v43 = m_tempCachedTilesScore;
		    Unity::Jobs::IJobExtensions::Schedule<BeyondDynamicBone::VirtualMesh::Work_IntersetcSortJob>(
		      &v36,
		      v42,
		      (JobHandle *)&v37,
		      MethodInfo::Unity::Jobs::IJobExtensions::Schedule<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>);
		    v45 = v36;
		    Unity::Jobs::JobHandle::Complete(&v45, 0LL);
		    v37 = this->fields.m_tempCachedTilesScore;
		    Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>(
		      (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v36,
		      (NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v37,
		      MethodInfo::Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>);
		    v37 = v38;
		    Unity::Collections::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>>::Schedule(
		      (JobHandle *)&v46,
		      (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v36,
		      (JobHandle *)&v37,
		      MethodInfo::Unity::Collections::SortJob<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::ASMTileManager::ScoreIndexStruct>>::Schedule);
		    v38 = v46;
		    Unity::Jobs::JobHandle::Complete((JobHandle *)&v38, 0LL);
		    v13 = 0LL;
		    v14 = 0LL;
		    v15 = 0;
		    v16 = 0LL;
		    do
		    {
		      if ( _mm_srli_si128(*(__m128i *)(v16 + (_QWORD)this[16LL] + 16), 8).m128i_i8[4]
		        && !_mm_srli_si128(*(__m128i *)(v16 + (_QWORD)this[16LL] + 16), 8).m128i_i8[5] )
		      {
		        ++v15;
		      }
		      v16 += 36LL;
		      v17 = *(_DWORD *)&this->fields.m_tempCachedTilesScore.m_Buffer[v14];
		      v14 += 8LL;
		      *(_DWORD *)&this->fields.m_tilesForRenderThisFrame.m_Buffer[v13] = v17;
		      v13 += 4LL;
		    }
		    while ( v16 < 9216 );
		    sub_1800036A0(TypeInfo::System::Math);
		    if ( maxRenderCount <= v15 )
		      v15 = maxRenderCount;
		    v18 = 0;
		    this->fields.m_renderCountThisFrame = v15;
		    if ( v15 > 0 )
		    {
		      v19 = 0LL;
		      do
		      {
		        v20 = this->fields.m_cachedTilesDict == 0LL;
		        Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_cachedTiles.m_Buffer;
		        v22 = *(int *)&this->fields.m_tilesForRenderThisFrame.m_Buffer[v19];
		        v23 = 9 * v22;
		        v24 = *(VirtualMesh_Work_IntersetcSortJob *)((char *)&Patch->klass + 36 * v22);
		        v25 = *(__m128i *)((char *)&Patch->fields.virtualMachine + 36 * v22);
		        LODWORD(v43.m_Buffer) = *((_DWORD *)&Patch->fields.anonObj + 9 * v22);
		        v42[0] = v24;
		        if ( v20 )
		          goto LABEL_21;
		        m_cachedTilesDict = this->fields.m_cachedTilesDict;
		        v36.jobGroup = v25.m128i_i64[0];
		        v36.jobType = _mm_cvtsi128_si32(_mm_srli_si128(v25, 8));
		        if ( (unsigned __int8)sub_180582078(
		                                m_cachedTilesDict,
		                                &v36,
		                                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,int>::ContainsKey) )
		        {
		          if ( !vtAllocator )
		            goto LABEL_21;
		          v37.m_Buffer = (Void *)v25.m128i_i64[0];
		          v37.m_Length = _mm_cvtsi128_si32(_mm_srli_si128(v25, 8));
		          if ( !HG::Rendering::Runtime::HGASMVirtualTextureAllocator::AllocateTile(
		                  vtAllocator,
		                  this,
		                  (Vector3Int *)&v37,
		                  startVTIdx,
		                  0LL) )
		            goto LABEL_18;
		          m_Buffer = this->fields.m_cachedTiles.m_Buffer;
		          vtIndex = *(_DWORD *)&m_Buffer[36 * v22 + 32];
		          v29 = *(_OWORD *)&m_Buffer[36 * v22];
		          v30 = 9 * v22;
		          v40 = *(_OWORD *)&m_Buffer[36 * v22 + 16];
		          BYTE13(v40) = 1;
		          v31 = v40;
		          *(_OWORD *)&m_Buffer[4 * v30] = v29;
		          *(_OWORD *)&m_Buffer[4 * v30 + 16] = v31;
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ASMTile);
		          InvalidTile = HG::Rendering::Runtime::ASMTile::get_InvalidTile((ASMTile *)v42, v32);
		          v30 = 9 * v22;
		          v34 = *(_OWORD *)&InvalidTile->mins.x;
		          vtIndex = InvalidTile->vtIndex;
		          v35 = *(_OWORD *)&InvalidTile->tileCoords.m_X;
		          m_Buffer = this->fields.m_cachedTiles.m_Buffer;
		          *(_OWORD *)&m_Buffer[4 * v30] = v34;
		          *(_OWORD *)&m_Buffer[4 * v30 + 16] = v35;
		        }
		        *(_DWORD *)&m_Buffer[4 * v30 + 32] = vtIndex;
		LABEL_18:
		        ++v18;
		        v19 += 4LL;
		      }
		      while ( v18 < this->fields.m_renderCountThisFrame );
		    }
		  }
		}
		
		public int GetTileRenderCountThisFrame() => default; // 0x0000000189D05AC0-0x0000000189D05B0C
		// Int32 GetTileRenderCountThisFrame()
		int32_t HG::Rendering::Runtime::ASMTileManager::GetTileRenderCountThisFrame(ASMTileManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2054, 0LL) )
		    return this->fields.m_renderCountThisFrame;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2054, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int GetTilesForRender(out NativeArray<int> tilesForRenderThisFrame) {
			tilesForRenderThisFrame = default;
			return default;
		} // 0x0000000189D05D1C-0x0000000189D05D80
		// Int32 GetTilesForRender(NativeArray`1[System.Int32] ByRef)
		int32_t HG::Rendering::Runtime::ASMTileManager::GetTilesForRender(
		        ASMTileManager *this,
		        NativeArray_1_System_Int32_ *tilesForRenderThisFrame,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2055, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2055, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_825(Patch, (Object *)this, tilesForRenderThisFrame, 0LL);
		  }
		  else
		  {
		    *tilesForRenderThisFrame = this->fields.m_tilesForRenderThisFrame;
		    return this->fields.m_renderCountThisFrame;
		  }
		}
		
		public void GenerateIndirectData(float gridSize, int startVTIndex, int gridCountX, int gridCountY, float asmRadius, ref Matrix4x4[] worldToShadowMatrices, out Matrix4x4 baseWorldToShadowMatrix, out Vector2 indexRegionMins, out Vector2 indexRegionMaxs, out int indirectWidth, out int indirectHeight) {
			baseWorldToShadowMatrix = default;
			indexRegionMins = default;
			indexRegionMaxs = default;
			indirectWidth = default;
			indirectHeight = default;
		} // 0x0000000189D04CDC-0x0000000189D0591C
		// Void GenerateIndirectData(Single, Int32, Int32, Int32, Single, Matrix4x4[] ByRef, Matrix4x4 ByRef, Vector2 ByRef, Vector2 ByRef, Int32 ByRef, Int32 ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ASMTileManager::GenerateIndirectData(
		        ASMTileManager *this,
		        float gridSize,
		        int32_t startVTIndex,
		        int32_t gridCountX,
		        int32_t gridCountY,
		        float asmRadius,
		        Matrix4x4__Array **worldToShadowMatrices,
		        Matrix4x4 *baseWorldToShadowMatrix,
		        Vector2 *indexRegionMins,
		        Vector2 *indexRegionMaxs,
		        int32_t *indirectWidth,
		        int32_t *indirectHeight,
		        MethodInfo *method)
		{
		  float v15; // xmm13_4
		  ASMTileManager *v16; // r12
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v18; // xmm1
		  __int128 v19; // xmm2
		  __int128 v20; // xmm3
		  int v21; // r15d
		  int v22; // r13d
		  int v23; // edi
		  int v24; // r14d
		  __int128 v25; // xmm12
		  __m128i v26; // xmm14
		  __m128 teamId; // xmm6
		  __m128 chunkNo; // xmm7
		  __m128 startIndex; // xmm8
		  __m128 dataLength; // xmm10
		  NativeArray_1_UnityEngine_Vector2_ m_frustumVertsForIndirect; // xmm11
		  bool IsPatched; // al
		  __int64 v33; // rdx
		  char v34; // r8
		  char v35; // r9
		  char v36; // r10
		  char v37; // cl
		  Void *m_Buffer; // r12
		  float v39; // xmm0_4
		  int v40; // ecx
		  unsigned __int64 v41; // xmm15_8
		  int v42; // eax
		  int v43; // ecx
		  __m128 v44; // xmm1
		  __m128 v45; // xmm2
		  unsigned __int64 v46; // xmm11_8
		  Vector3Int *v47; // r8
		  ITilemap *v48; // r9
		  float v49; // xmm7_4
		  float v50; // xmm6_4
		  __int128 v51; // xmm8
		  __int128 v52; // xmm10
		  int i; // r15d
		  float v54; // xmm12_4
		  __int128 v55; // xmm0
		  __int128 v56; // xmm0
		  ILFixDynamicMethodWrapper_2 *v57; // rax
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  Void *v60; // rax
		  __m128 v61; // xmm1
		  int v62; // ecx
		  __m128 v63; // xmm9
		  int32_t v64; // edi
		  int32_t v65; // r14d
		  __m128 v66; // xmm2
		  __m128 v67; // xmm3
		  __m128 v68; // xmm0
		  __m128 v69; // xmm1
		  int32_t v70; // eax
		  int v71; // r12d
		  int v72; // r13d
		  __int64 v73; // r15
		  int v74; // eax
		  ASMTile *Tile; // rax
		  __int64 vtIndex; // r8
		  __int64 v77; // rdx
		  float v78; // xmm6_4
		  float v79; // xmm8_4
		  __m128 v80; // xmm7
		  unsigned __int32 v81; // xmm10_4
		  unsigned __int32 v82; // xmm11_4
		  float v83; // xmm6_4
		  __int64 v84; // rdx
		  __int64 v85; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdi
		  MethodInfo *P3; // [rsp+20h] [rbp-278h]
		  __int64 v88; // [rsp+70h] [rbp-228h]
		  __int64 v89; // [rsp+70h] [rbp-228h]
		  __int64 v90; // [rsp+70h] [rbp-228h]
		  char v91; // [rsp+78h] [rbp-220h]
		  int v92; // [rsp+7Ch] [rbp-21Ch]
		  int v93; // [rsp+80h] [rbp-218h]
		  int32_t v94; // [rsp+80h] [rbp-218h]
		  int v95; // [rsp+84h] [rbp-214h]
		  int v96; // [rsp+84h] [rbp-214h]
		  TileAnimationData v97; // [rsp+88h] [rbp-210h] BYREF
		  int v98; // [rsp+98h] [rbp-200h]
		  int v99; // [rsp+9Ch] [rbp-1FCh]
		  int32_t useLength; // [rsp+A0h] [rbp-1F8h]
		  int v101; // [rsp+A4h] [rbp-1F4h]
		  NativeArray_1_UnityEngine_Vector2_ v102; // [rsp+B0h] [rbp-1E8h] BYREF
		  Void *v103; // [rsp+C0h] [rbp-1D8h]
		  __int64 v104; // [rsp+D0h] [rbp-1C8h] BYREF
		  unsigned __int64 v105; // [rsp+D8h] [rbp-1C0h]
		  unsigned __int64 v106; // [rsp+E0h] [rbp-1B8h]
		  Il2CppException *ex; // [rsp+E8h] [rbp-1B0h]
		  NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_TriangleWorker_GroupData_ *v108; // [rsp+F0h] [rbp-1A8h]
		  NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_TriangleWorker_GroupData_ v109; // [rsp+F8h] [rbp-1A0h] BYREF
		  ASMTile v110; // [rsp+130h] [rbp-168h] BYREF
		  NativeArray_1_T_ReadOnly_MagicaCloth_TriangleWorker_GroupData_ v111; // [rsp+160h] [rbp-138h] BYREF
		  __int128 v112; // [rsp+170h] [rbp-128h]
		  __int128 v113; // [rsp+180h] [rbp-118h]
		  __m128 v114; // [rsp+190h] [rbp-108h]
		  Il2CppExceptionWrapper *v115; // [rsp+1A0h] [rbp-F8h] BYREF
		  __int128 v116; // [rsp+1A8h] [rbp-F0h]
		  TileAnimationData v117; // [rsp+1B8h] [rbp-E0h] BYREF
		
		  v15 = gridSize;
		  v16 = this;
		  v103 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2056, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2056, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v85, v84);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_826(
		      Patch,
		      (Object *)v16,
		      gridSize,
		      startVTIndex,
		      gridCountX,
		      gridCountY,
		      asmRadius,
		      worldToShadowMatrices,
		      baseWorldToShadowMatrix,
		      indexRegionMins,
		      indexRegionMaxs,
		      indirectWidth,
		      indirectHeight,
		      0LL);
		  }
		  else
		  {
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v18 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    v19 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    v20 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&baseWorldToShadowMatrix->m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    *(_OWORD *)&baseWorldToShadowMatrix->m01 = v18;
		    *(_OWORD *)&baseWorldToShadowMatrix->m02 = v19;
		    *(_OWORD *)&baseWorldToShadowMatrix->m03 = v20;
		    v91 = 0;
		    v21 = 0x40000000;
		    v92 = 0x40000000;
		    v22 = 0x40000000;
		    v99 = 0x40000000;
		    v23 = -1073741824;
		    v93 = -1073741824;
		    v24 = -1073741824;
		    v95 = -1073741824;
		    Unity::Collections::NativeArray_1_T_::ReadOnly<MagicaCloth::TriangleWorker::GroupData>::GetEnumerator(
		      (NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_TriangleWorker_GroupData_ *)&v111,
		      (NativeArray_1_T_ReadOnly_MagicaCloth_TriangleWorker_GroupData_ *)&v16->fields,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::ASMTile>::GetEnumerator);
		    v109.m_Array = v111;
		    *(_OWORD *)&v109.m_Index = v112;
		    *(_OWORD *)&v109.value.triangleDataChunk.dataLength = v113;
		    *(_QWORD *)&v109.value.triangleIndexChunk.dataLength = v114.m128_u64[0];
		    ex = 0LL;
		    v108 = &v109;
		    try
		    {
		      v63 = 0LL;
		      while ( 1 )
		      {
		        do
		        {
		          if ( !Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<MagicaCloth::TriangleWorker::GroupData>::MoveNext(
		                  &v109,
		                  MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<HG::Rendering::Runtime::ASMTile>::MoveNext) )
		            goto LABEL_68;
		          v25 = *(_OWORD *)&v109.value.teamId;
		          v116 = *(_OWORD *)&v109.value.teamId;
		          v26 = *(__m128i *)&v109.value.triangleDataChunk.useLength;
		          useLength = v109.value.triangleIndexChunk.useLength;
		        }
		        while ( !_mm_srli_si128(*(__m128i *)(&v109 + 36), 8).m128i_i8[4] );
		        teamId = (__m128)(unsigned int)v109.value.teamId;
		        chunkNo = (__m128)(unsigned int)v109.value.triangleDataChunk.chunkNo;
		        startIndex = (__m128)(unsigned int)v109.value.triangleDataChunk.startIndex;
		        dataLength = (__m128)(unsigned int)v109.value.triangleDataChunk.dataLength;
		        m_frustumVertsForIndirect = v16->fields.m_frustumVertsForIndirect;
		        v102 = m_frustumVertsForIndirect;
		        v97 = 0LL;
		        v104 = 0LL;
		        IsPatched = IFix::WrappersManagerImpl::IsPatched(2039, 0LL);
		        v33 = 0LL;
		        if ( IsPatched )
		        {
		          v57 = IFix::WrappersManagerImpl::GetPatch(2039, 0LL);
		          if ( !v57 )
		            sub_1800D8250(v59, v58);
		          v102 = m_frustumVertsForIndirect;
		          if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_814(
		                 v57,
		                 &v102,
		                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps(teamId, chunkNo),
		                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps(startIndex, dataLength),
		                 0LL) )
		          {
		            goto LABEL_31;
		          }
		        }
		        else
		        {
		          v34 = 1;
		          v35 = 1;
		          v36 = 1;
		          v37 = 1;
		          m_Buffer = v102.m_Buffer;
		          do
		          {
		            v34 &= *(float *)&v102.m_Buffer[8 * v33] > startIndex.m128_f32[0];
		            v39 = *(float *)&v102.m_Buffer[8 * v33 + 4];
		            v35 &= v39 > dataLength.m128_f32[0];
		            v36 &= teamId.m128_f32[0] > *(float *)&v102.m_Buffer[8 * v33];
		            v37 &= chunkNo.m128_f32[0] > v39;
		            ++v33;
		          }
		          while ( v33 < 5 );
		          if ( (unsigned __int8)v34 | (unsigned __int8)(v35 | v36 | v37) )
		          {
		LABEL_3:
		            v16 = this;
		          }
		          else
		          {
		            v40 = 0;
		            v105 = _mm_unpacklo_ps(teamId, chunkNo).m128_u64[0];
		            v41 = _mm_unpacklo_ps(teamId, dataLength).m128_u64[0];
		            v106 = _mm_unpacklo_ps(startIndex, chunkNo).m128_u64[0];
		            v102.m_Buffer = (Void *)_mm_unpacklo_ps(startIndex, dataLength).m128_u64[0];
		            while ( 1 )
		            {
		              v98 = v40;
		              if ( v40 >= 8 )
		                break;
		              v42 = v40 % 4;
		              if ( v40 >= 4 )
		              {
		                v44 = (__m128)*(_DWORD *)m_Buffer;
		                v45 = (__m128)*(unsigned int *)&m_Buffer[4];
		              }
		              else
		              {
		                v43 = (v40 + 1) % 4;
		                v44 = (__m128)*(unsigned int *)&m_Buffer[8 * v43 + 8];
		                v45 = (__m128)*(unsigned int *)&m_Buffer[8 * v43 + 12];
		              }
		              v46 = _mm_unpacklo_ps(
		                      (__m128)*(_DWORD *)&m_Buffer[8 * v42 + 8],
		                      (__m128)*(_DWORD *)&m_Buffer[8 * v42 + 12]).m128_u64[0];
		              v104 = sub_1858CAD18(_mm_unpacklo_ps(v44, v45).m128_u64[0], v46);
		              v88 = sub_182FA2990(&v104);
		              v49 = *((float *)&v88 + 1);
		              v50 = -*(float *)&v88;
		              v51 = 0LL;
		              v52 = 0LL;
		              for ( i = 0; i < 5; ++i )
		              {
		                v89 = sub_1858CAD18(
		                        _mm_unpacklo_ps((__m128)*(_DWORD *)&m_Buffer[8 * i], (__m128)*(_DWORD *)&m_Buffer[8 * i + 4]).m128_u64[0],
		                        v46);
		                v54 = (float)(v49 * *(float *)&v89) + (float)(v50 * *((float *)&v89 + 1));
		                v55 = v51;
		                *(float *)&v55 = UnityEngine::Mathf::Min(*(float *)&v51, v54, 0LL);
		                v51 = v55;
		                v56 = v52;
		                *(float *)&v56 = UnityEngine::Mathf::Max(*(float *)&v52, v54, 0LL);
		                v52 = v56;
		              }
		              v97 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(&v117, 0LL, v47, v48, P3);
		              sub_1858CAD18(v105, v46);
		              sub_18323BA00(&v97, 0LL);
		              sub_1858CAD18(v41, v46);
		              sub_18323BA00(&v97, 1LL);
		              sub_1858CAD18(v106, v46);
		              sub_18323BA00(&v97, 2LL);
		              sub_1858CAD18(v102.m_Buffer, v46);
		              sub_18323BA00(&v97, 3LL);
		              if ( *(float *)&v51 > sub_1832E0B20(&v97, 0LL)
		                && *(float *)&v51 > sub_1832E0B20(&v97, 1LL)
		                && *(float *)&v51 > sub_1832E0B20(&v97, 2LL) )
		              {
		                v21 = v92;
		                if ( *(float *)&v51 > sub_1832E0B20(&v97, 3LL) )
		                  goto LABEL_3;
		              }
		              if ( sub_1832E0B20(&v97, 0LL) > *(float *)&v52
		                && sub_1832E0B20(&v97, 1LL) > *(float *)&v52
		                && sub_1832E0B20(&v97, 2LL) > *(float *)&v52 )
		              {
		                v21 = v92;
		                if ( sub_1832E0B20(&v97, 3LL) > *(float *)&v52 )
		                  goto LABEL_3;
		              }
		              v40 = v98 + 1;
		            }
		            v25 = v116;
		            v21 = v92;
		            v16 = this;
		LABEL_31:
		            v60 = v16->fields.m_frustumVertsForIndirect.m_Buffer;
		            v61 = (__m128)*(unsigned int *)&v60[4];
		            *(_OWORD *)&v110.mins.x = v25;
		            *(__m128i *)&v110.tileCoords.m_X = v26;
		            v110.vtIndex = useLength;
		            if ( asmRadius > HG::Rendering::Runtime::ASMUtils::ASMTileDistance(
		                               &v110,
		                               (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)*(_DWORD *)v60, v61),
		                               0LL) )
		            {
		              v62 = _mm_cvtsi128_si32(v26);
		              if ( v21 >= v62 )
		                v21 = v62;
		              v92 = v21;
		              if ( v22 >= v26.m128i_i32[1] )
		                v22 = v26.m128i_i32[1];
		              v99 = v22;
		              if ( v23 <= v62 )
		                v23 = v62;
		              v93 = v23;
		              if ( v24 <= v26.m128i_i32[1] )
		                v24 = v26.m128i_i32[1];
		              v95 = v24;
		              v91 = 1;
		            }
		          }
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v115 )
		    {
		      ex = v115->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v15 = gridSize;
		      v21 = v92;
		      v22 = v99;
		      v23 = v93;
		      v24 = v95;
		      v63 = 0LL;
		    }
		LABEL_68:
		    v64 = v23 - v21 + 1;
		    v65 = v24 - v22 + 1;
		    if ( v91 && v64 * v65 <= 128 && v64 * v65 > 0 )
		    {
		      v66 = (__m128)COERCE_UNSIGNED_INT((float)v21);
		      v66.m128_f32[0] = v66.m128_f32[0] * v15;
		      v67 = (__m128)COERCE_UNSIGNED_INT((float)v22);
		      v67.m128_f32[0] = v67.m128_f32[0] * v15;
		      *indexRegionMins = (Vector2)_mm_unpacklo_ps(v66, v67).m128_u64[0];
		      v68 = (__m128)COERCE_UNSIGNED_INT((float)v64);
		      v69 = (__m128)COERCE_UNSIGNED_INT((float)v65);
		      v68.m128_f32[0] = (float)(v68.m128_f32[0] * v15) + v66.m128_f32[0];
		      v69.m128_f32[0] = (float)(v69.m128_f32[0] * v15) + v67.m128_f32[0];
		      *indexRegionMaxs = (Vector2)_mm_unpacklo_ps(v68, v69).m128_u64[0];
		      v70 = 0;
		      v94 = 0;
		      if ( v65 > 0 )
		      {
		        v71 = 0;
		        v72 = v65 + v22 - 1;
		        do
		        {
		          if ( v64 > 0 )
		          {
		            v90 = 0LL;
		            HIDWORD(v103) = v72;
		            v73 = 16LL * v71;
		            v74 = v64 + v92 - 1;
		            v96 = v74;
		            do
		            {
		              LODWORD(v103) = v74;
		              v102.m_Buffer = v103;
		              v102.m_Length = 0;
		              Tile = HG::Rendering::Runtime::ASMTileManager::GetTile((ASMTile *)&v111, this, (Vector3Int *)&v102, 0LL);
		              if ( !((unsigned __int16)WORD2(*(_QWORD *)&Tile->tileCoords.m_Z) >> 8)
		                || (vtIndex = Tile->vtIndex, (_DWORD)vtIndex == -1) )
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                v80.m128_i32[0] = v63.m128_i32[0];
		                v81 = v63.m128_i32[0];
		                v82 = v63.m128_i32[0];
		                v78 = -1.0;
		                v79 = -1.0;
		              }
		              else
		              {
		                useLength = (int)vtIndex % gridCountX;
		                v77 = (unsigned int)((int)vtIndex >> 31);
		                v101 = (int)vtIndex / gridCountY;
		                v78 = (float)(1.0 / (float)gridCountX) * (float)((int)vtIndex % gridCountX);
		                v79 = (float)(1.0 / (float)gridCountY) * (float)((int)vtIndex / gridCountY);
		                if ( !*worldToShadowMatrices )
		                {
		                  LODWORD(v77) = (int)vtIndex % gridCountY;
		                  sub_1800D8250((unsigned int)((int)vtIndex % gridCountX), v77);
		                }
		                sub_180031960(*worldToShadowMatrices, &v111, vtIndex);
		                *(NativeArray_1_T_ReadOnly_MagicaCloth_TriangleWorker_GroupData_ *)&baseWorldToShadowMatrix->m00 = v111;
		                *(_OWORD *)&baseWorldToShadowMatrix->m01 = v112;
		                *(_OWORD *)&baseWorldToShadowMatrix->m02 = v113;
		                v80 = v114;
		                *(__m128 *)&baseWorldToShadowMatrix->m03 = v114;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                v81 = _mm_shuffle_ps(v80, v80, 85).m128_u32[0];
		                v82 = _mm_shuffle_ps(v80, v80, 170).m128_u32[0];
		              }
		              v83 = HG::Rendering::Runtime::HGUtils::PackTwoHalfValuesAsFloat(v78, v79, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		              *(float *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[23].shadowData._CSMShadowBiases.FixedElementField
		                       + v73) = v83;
		              *(_DWORD *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[23].shadowData._CSMShadowAtlasParams.FixedElementField
		                        + v73) = v80.m128_i32[0];
		              *(_DWORD *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[23].shadowData._CSMShadowTexelSize.x
		                        + v73) = v81;
		              *(_DWORD *)((char *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[23].shadowData._CSMShadowTexelSize.y
		                        + v73) = v82;
		              v74 = --v96;
		              ++v90;
		              v73 += 16LL;
		            }
		            while ( v90 < v64 );
		            v70 = v94;
		          }
		          v94 = ++v70;
		          --v72;
		          v71 += v64;
		        }
		        while ( v70 < v65 );
		      }
		      *indirectWidth = v64;
		      *indirectHeight = v65;
		    }
		    else
		    {
		      *indirectWidth = 0;
		      *indirectHeight = 0;
		      *indexRegionMins = (Vector2)_mm_unpacklo_ps(v63, v63).m128_u64[0];
		      *indexRegionMaxs = (Vector2)_mm_unpacklo_ps(v63, v63).m128_u64[0];
		    }
		  }
		}
		
	}
}
