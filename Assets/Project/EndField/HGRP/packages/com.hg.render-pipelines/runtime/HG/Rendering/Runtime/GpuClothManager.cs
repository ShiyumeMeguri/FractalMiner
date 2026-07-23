using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class GpuClothManager // TypeDefIndex: 37580
	{
		// Fields
		public const int MAX_ANCHOR_NUM = 2; // Metadata: 0x02302F47
		public const int MAX_NEIGHBOR_NUM = 8; // Metadata: 0x02302F48
		public const int MAX_CLOTH_NEIGHBOR_NUM = 128; // Metadata: 0x02302F49
		public const int CLOTH_BATCH_SIZE = 256; // Metadata: 0x02302F4B
		public const int MAX_COLLIDER_NUM = 4; // Metadata: 0x02302F4D
		public const int MAX_RUNTIME_CLOTH_GROUP_NUM = 50; // Metadata: 0x02302F4E
		internal readonly Vector4 CHARACTER_POSITION_OFFSET; // 0x10
		internal readonly Vector4 INVALID_POSITION; // 0x20
		internal ClothConstData clothConstData; // 0x30
		private Mesh m_characterMesh; // 0x110
		private float m_capsuleRadius; // 0x118
		private float m_capsuleHeight; // 0x11C
		internal bool needClearGPUBuffer; // 0x120
		internal ComputeBuffer clothNodeDataBuffer; // 0x128
		internal ComputeBuffer clothMetaDataBuffer; // 0x130
		internal ComputeBuffer clothBatchMetaDataBuffer; // 0x138
		internal ComputeBuffer clothBatchCacheMapBuffer; // 0x140
		internal ComputeBuffer clothSkeletonDataBuffer; // 0x148
		internal GpuClothRenderData renderData; // 0x150
		internal GpuClothClearBufferData clearBufferData; // 0x260
		internal bool isStreamingMode; // 0x290
		internal float skeletonFlipped; // 0x294
		internal const float PHYSICS_DELTA_TIME = 0.023333333f; // Metadata: 0x02302F4F
		internal float gameplayDt; // 0x298
		internal float cumulativeTime; // 0x29C
		internal bool shouldStep; // 0x2A0
		internal float loopNum; // 0x2A4
		internal float windTime; // 0x2A8
		internal float windSpeed; // 0x2AC
		internal Vector2 windNoiseUV; // 0x2B0
		private int m_runtimeClothNum; // 0x2B8
		private int m_runtimeClothGroupNum; // 0x2BC
		private NativeParallelHashMap<uint, RuntimeClothData_Internal> m_clothHashToRuntimeClothData; // 0x2C0
		private DynamicArray<ClothMetaData> m_runtimeClothMetaArray; // 0x2D0
		private bool m_isForcedRefresh; // 0x2D8
		private NativeParallelHashMap<uint, ClothGroupData_Internal> m_registedClothGroupData; // 0x2E0
		private NativeParallelHashMap<uint, ClothGroupMeta_Internal> m_activatedGroupHashToGroupMeta; // 0x2F0
		private int[] m_availableCellIdx; // 0x300
		private static ClothActivateComparer s_clothActiveComparer; // 0x00
		private IndexedHashSet<uint> m_shouldActivatedGroupHash; // 0x308
		private NativeParallelHashSet<uint> m_activatedGroupHash; // 0x310
		private NativeParallelHashSet<uint> m_lastActivatedGroupHash; // 0x320
		private DynamicArray<uint> m_pendingActivateGroupHash; // 0x330
		private DynamicArray<uint> m_pendingDeactivateGroupHash; // 0x338
		private Vector2 m_lastPlayerCenterXZ; // 0x340
		private Vector2 m_playerCenterXZ; // 0x348
		private const float CLOTH_DIRTY_DISTANCE = 32f; // Metadata: 0x02302F53
		private NativeParallelHashSet<uint> m_groupHashNeedToUpload; // 0x350
		private NativeParallelHashSet<uint> m_groupHashUploaded; // 0x360
		private bool m_isClothMetaBufferDirty; // 0x370
		internal GpuClothGroupUploadData clothGroupUploadData; // 0x378
	
		// Nested types
		private struct ClothGroupMeta_Internal // TypeDefIndex: 37576
		{
			// Fields
			public ClothGroupMeta clothGroupMeta; // 0x00
			public int cellIdx; // 0x50
			public unsafe fixed /* 0x00000000-0x00000000 */ int clothMetaIdx[0]; // 0x54
	
			// Methods
			public void FindAndSetClothMetaIdx(int oldIdx, int newIdx) {} // 0x0000000189C67CD0-0x0000000189C67DA0
			// Void FindAndSetClothMetaIdx(Int32, Int32)
			void HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx(
			        GpuClothManager_ClothGroupMeta_Internal *this,
			        int32_t oldIdx,
			        int32_t newIdx,
			        MethodInfo *method)
			{
			  __int64 clothNum; // r8
			  int v8; // eax
			  __int64 v9; // rdx
			  uint32_t *p_clothGroupHash; // rcx
			  __int64 v11; // rax
			  ArgumentOutOfRangeException *v12; // rax
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  ArgumentOutOfRangeException *v15; // rbx
			  __int64 v16; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1288, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1288, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_493(Patch, this, oldIdx, newIdx, 0LL);
			      return;
			    }
			LABEL_10:
			    sub_1800D8260(v14, v13);
			  }
			  clothNum = this->clothGroupMeta.clothNum;
			  v8 = 0;
			  if ( clothNum <= 0 )
			  {
			LABEL_6:
			    v11 = sub_18007E180(&TypeInfo::System::ArgumentOutOfRangeException);
			    v12 = (ArgumentOutOfRangeException *)sub_1800368D0(v11);
			    v15 = v12;
			    if ( v12 )
			    {
			      System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v12, 0LL);
			      v16 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx);
			      sub_18007E190(v15, v16);
			    }
			    goto LABEL_10;
			  }
			  v9 = 0LL;
			  p_clothGroupHash = &this[2].clothGroupMeta.clothGroupHash;
			  while ( *p_clothGroupHash != oldIdx )
			  {
			    ++v8;
			    ++v9;
			    ++p_clothGroupHash;
			    if ( v9 >= clothNum )
			      goto LABEL_6;
			  }
			  *(&this[2].clothGroupMeta.clothGroupHash + v8) = newIdx;
			}
			
		}
	
		private struct ClothGroupData_Internal // TypeDefIndex: 37577
		{
			// Fields
			public ClothGroupMeta clothGroupMeta; // 0x00
			public unsafe byte* groupClothMetaBytes; // 0x50
			public int groupClothMetaBytesSize; // 0x58
			public unsafe byte* groupClothNodeBytes; // 0x60
			public int groupClothNodeBytesSize; // 0x68
			public unsafe byte* groupClothBatchMetaBytes; // 0x70
			public int groupClothBatchMetaBytesSize; // 0x78
			public unsafe byte* groupClothBatchCacheBytes; // 0x80
			public int groupClothBatchCacheBytesSize; // 0x88
	
			// Methods
			public void CopyFromClothGroupData([IsReadOnly] in ClothGroupData groupData) {} // 0x0000000189C674D0-0x0000000189C67678
			// Void CopyFromClothGroupData(ClothGroupData ByRef)
			void HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::CopyFromClothGroupData(
			        GpuClothManager_ClothGroupData_Internal *this,
			        ClothGroupData *groupData,
			        MethodInfo *method)
			{
			  __int128 v5; // xmm1
			  Span_1_Byte_ groupClothMetaBytes; // xmm0
			  Span_1_Byte_ groupClothNodeBytes; // xmm1
			  Span_1_Byte_ groupClothBatchMetaBytes; // xmm0
			  MissionAcceptMode_EnterAreaInfo_MissionArea *PinnableReference; // rax
			  int64_t length; // rcx
			  Void *v11; // rbx
			  uint8_t *v12; // rax
			  int64_t groupClothBatchCacheBytesSize; // r8
			  MissionAcceptMode_EnterAreaInfo_MissionArea *v14; // rax
			  __int64 x_low; // rcx
			  Void *v16; // rbx
			  Void *v17; // rax
			  int64_t v18; // r8
			  MissionAcceptMode_EnterAreaInfo_MissionArea *v19; // rax
			  int64_t FixedElementField; // rcx
			  Void *v21; // rbx
			  Void *v22; // rax
			  int64_t v23; // r8
			  MissionAcceptMode_EnterAreaInfo_MissionArea *v24; // rax
			  int64_t v25; // rcx
			  Void *v26; // rbx
			  uint8_t *v27; // rax
			  int64_t groupClothMetaBytesSize; // r8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v30; // rdx
			  __int64 v31; // rcx
			  ClothGroupMeta v32; // [rsp+20h] [rbp-58h] BYREF
			  Span_1_Byte_ v33; // [rsp+40h] [rbp-38h]
			  Span_1_Byte_ v34; // [rsp+50h] [rbp-28h]
			  Span_1_Byte_ v35; // [rsp+60h] [rbp-18h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1298, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1298, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v31, v30);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_498(Patch, this, groupData, 0LL);
			  }
			  else
			  {
			    v5 = *(_OWORD *)&groupData->clothGroupMeta.clothHashes.FixedElementField;
			    *(_OWORD *)&v32.clothNum = *(_OWORD *)&groupData->clothGroupMeta.clothNum;
			    groupClothMetaBytes = groupData->groupClothMetaBytes;
			    *(_OWORD *)&v32.clothHashes.FixedElementField = v5;
			    groupClothNodeBytes = groupData->groupClothNodeBytes;
			    v33 = groupClothMetaBytes;
			    groupClothBatchMetaBytes = groupData->groupClothBatchMetaBytes;
			    v34 = groupClothNodeBytes;
			    v35 = groupClothBatchMetaBytes;
			    HG::Rendering::Runtime::ClothGroupMeta::CopyFromClothGroupMeta(&this->clothGroupMeta, &v32, 0LL);
			    PinnableReference = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
			                          (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData->groupClothBatchCacheBytes,
			                          MethodInfo::System::Span<unsigned char>::GetPinnableReference);
			    length = groupData->groupClothBatchCacheBytes._length;
			    this->groupClothBatchCacheBytesSize = length;
			    v11 = (Void *)PinnableReference;
			    v12 = (uint8_t *)Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(
			                       length,
			                       0,
			                       Allocator__Enum_Persistent,
			                       0LL);
			    groupClothBatchCacheBytesSize = this->groupClothBatchCacheBytesSize;
			    this->groupClothBatchCacheBytes = v12;
			    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v12, v11, groupClothBatchCacheBytesSize, 0LL);
			    v14 = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
			            (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData[1],
			            MethodInfo::System::Span<unsigned char>::GetPinnableReference);
			    x_low = SLODWORD(groupData[1].clothGroupMeta.groupWorldPosXZ.x);
			    LODWORD(this[1].clothGroupMeta.groupWorldPosXZ.x) = x_low;
			    v16 = (Void *)v14;
			    v17 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(x_low, 0, Allocator__Enum_Persistent, 0LL);
			    v18 = SLODWORD(this[1].clothGroupMeta.groupWorldPosXZ.x);
			    *(_QWORD *)&this[1].clothGroupMeta.clothNum = v17;
			    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v17, v16, v18, 0LL);
			    v19 = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
			            (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData[1].clothGroupMeta.clothHashes,
			            MethodInfo::System::Span<unsigned char>::GetPinnableReference);
			    FixedElementField = groupData[1].clothGroupMeta.clothBatchNum.FixedElementField;
			    this[1].clothGroupMeta.clothBatchNum.FixedElementField = FixedElementField;
			    v21 = (Void *)v19;
			    v22 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(
			            FixedElementField,
			            0,
			            Allocator__Enum_Persistent,
			            0LL);
			    v23 = this[1].clothGroupMeta.clothBatchNum.FixedElementField;
			    *(_QWORD *)&this[1].clothGroupMeta.clothHashes.FixedElementField = v22;
			    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v22, v21, v23, 0LL);
			    v24 = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
			            (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData[1].groupClothMetaBytes,
			            MethodInfo::System::Span<unsigned char>::GetPinnableReference);
			    v25 = groupData[1].groupClothMetaBytes._length;
			    this[1].groupClothMetaBytesSize = v25;
			    v26 = (Void *)v24;
			    v27 = (uint8_t *)Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(
			                       v25,
			                       0,
			                       Allocator__Enum_Persistent,
			                       0LL);
			    groupClothMetaBytesSize = this[1].groupClothMetaBytesSize;
			    this[1].groupClothMetaBytes = v27;
			    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v27, v26, groupClothMetaBytesSize, 0LL);
			  }
			}
			
			public void Reset() {} // 0x0000000189C67678-0x0000000189C6774C
			// Void Reset()
			void HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::Reset(
			        GpuClothManager_ClothGroupData_Internal *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1302, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1302, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_500(Patch, this, 0LL);
			  }
			  else
			  {
			    if ( this->groupClothBatchCacheBytes )
			    {
			      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
			        (Void *)this->groupClothBatchCacheBytes,
			        Allocator__Enum_Persistent,
			        0LL);
			      this->groupClothBatchCacheBytes = 0LL;
			    }
			    this->groupClothBatchCacheBytesSize = 0;
			    if ( *(_QWORD *)&this[1].clothGroupMeta.clothNum )
			    {
			      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
			        *(Void **)&this[1].clothGroupMeta.clothNum,
			        Allocator__Enum_Persistent,
			        0LL);
			      *(_QWORD *)&this[1].clothGroupMeta.clothNum = 0LL;
			    }
			    this[1].clothGroupMeta.groupWorldPosXZ.x = 0.0;
			    if ( *(_QWORD *)&this[1].clothGroupMeta.clothHashes.FixedElementField )
			    {
			      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
			        *(Void **)&this[1].clothGroupMeta.clothHashes.FixedElementField,
			        Allocator__Enum_Persistent,
			        0LL);
			      *(_QWORD *)&this[1].clothGroupMeta.clothHashes.FixedElementField = 0LL;
			    }
			    this[1].clothGroupMeta.clothBatchNum.FixedElementField = 0;
			    if ( this[1].groupClothMetaBytes )
			    {
			      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
			        (Void *)this[1].groupClothMetaBytes,
			        Allocator__Enum_Persistent,
			        0LL);
			      this[1].groupClothMetaBytes = 0LL;
			    }
			    this[1].groupClothMetaBytesSize = 0;
			  }
			}
			
		}
	
		private class ClothActivateComparer : IComparer<uint> // TypeDefIndex: 37578
		{
			// Fields
			public Vector2 playerCenterXZ; // 0x10
			public unsafe NativeParallelHashMap<uint, ClothGroupData_Internal>* registedClothGroupData; // 0x18
	
			// Constructors
			public ClothActivateComparer() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
	
			// Methods
			public int Compare(uint a, uint b) => default; // 0x0000000189C671D4-0x0000000189C6731C
			// Int32 Compare(UInt32, UInt32)
			int32_t HG::Rendering::Runtime::GpuClothManager::ClothActivateComparer::Compare(
			        GpuClothManager_ClothActivateComparer *this,
			        uint32_t a,
			        uint32_t b,
			        MethodInfo *method)
			{
			  __m128 x_low; // xmm6
			  __m128 y_low; // xmm7
			  double v9; // xmm0_8
			  __m128 v10; // xmm6
			  float v11; // xmm8_4
			  __m128 v12; // xmm7
			  double v13; // xmm0_8
			  int32_t result; // eax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v16; // rdx
			  __int64 v17; // rcx
			  __int64 v18; // [rsp+30h] [rbp-D8h] BYREF
			  GpuClothManager_ClothGroupData_Internal v19[2]; // [rsp+38h] [rbp-D0h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1318, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1318, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v17, v16);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_532(
			             (ILFixDynamicMethodWrapper_3 *)Patch,
			             (Object *)this,
			             a,
			             b,
			             0LL);
			  }
			  else
			  {
			    x_low = (__m128)LODWORD(this->fields.playerCenterXZ.x);
			    y_low = (__m128)LODWORD(this->fields.playerCenterXZ.y);
			    Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
			      v19,
			      this->fields.registedClothGroupData,
			      a,
			      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
			    v18 = sub_1858CAD18(
			            _mm_unpacklo_ps(x_low, y_low).m128_u64[0],
			            _mm_unpacklo_ps(
			              (__m128)LODWORD(v19[0].clothGroupMeta.groupWorldPosXZ.x),
			              (__m128)LODWORD(v19[0].clothGroupMeta.groupWorldPosXZ.y)).m128_u64[0]);
			    v9 = sub_182FA2AF0(&v18);
			    v10 = (__m128)LODWORD(this->fields.playerCenterXZ.x);
			    v11 = *(float *)&v9;
			    v12 = (__m128)LODWORD(this->fields.playerCenterXZ.y);
			    Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
			      v19,
			      this->fields.registedClothGroupData,
			      b,
			      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
			    v18 = sub_1858CAD18(
			            _mm_unpacklo_ps(v10, v12).m128_u64[0],
			            _mm_unpacklo_ps(
			              (__m128)LODWORD(v19[0].clothGroupMeta.groupWorldPosXZ.x),
			              (__m128)LODWORD(v19[0].clothGroupMeta.groupWorldPosXZ.y)).m128_u64[0]);
			    v13 = sub_182FA2AF0(&v18);
			    result = 1;
			    if ( *(float *)&v13 > v11 )
			      return -1;
			  }
			  return result;
			}
			
		}
	
		private struct RuntimeClothData_Internal // TypeDefIndex: 37579
		{
			// Fields
			public bool isDataReady; // 0x00
			public float skeletonOffset; // 0x04
			public float isSingleSkeleton; // 0x08
		}
	
		// Constructors
		public GpuClothManager() {} // 0x000000018458A120-0x000000018458A660
		// GpuClothManager()
		void HG::Rendering::Runtime::GpuClothManager::GpuClothManager(GpuClothManager *this, MethodInfo *method)
		{
		  Vector4 si128; // xmm1
		  int v4; // ebx
		  __int64 v5; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v6; // rax
		  __int64 v7; // rdx
		  ComputeBuffer *clothMetaDataBuffer; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v9; // rsi
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  __int64 v13; // rax
		  __int64 v14; // rax
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  IndexedHashSet_1_System_UInt32_ *v18; // rax
		  ComputeBuffer *v19; // rsi
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v23; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v24; // rsi
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v28; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v29; // rsi
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Il2CppClass *klass; // rcx
		  __int64 v34; // rax
		  Il2CppClass *v35; // rcx
		  __int64 v36; // rax
		  Il2CppClass *v37; // rcx
		  __int64 v38; // rax
		  Il2CppClass *v39; // rcx
		  __int64 v40; // rax
		  Il2CppClass *v41; // rcx
		  __int64 v42; // rax
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v48; // xmm1
		  __int128 v49; // xmm0
		  Type *v50; // rdx
		  PropertyInfo_1 *v51; // r8
		  Int32__Array **v52; // r9
		  __int64 v53; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-59h]
		  MethodInfo *methode; // [rsp+20h] [rbp-59h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-59h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-59h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-59h]
		  MethodInfo *methodf; // [rsp+20h] [rbp-59h]
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v60; // [rsp+30h] [rbp-49h] BYREF
		  _BYTE v61[128]; // [rsp+40h] [rbp-39h] BYREF
		
		  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959B10);
		  this->fields.CHARACTER_POSITION_OFFSET = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959930);
		  *(_QWORD *)&this[1].fields.INVALID_POSITION.y = 1090519040LL;
		  this->fields.INVALID_POSITION = si128;
		  v4 = 0;
		  this[1].fields.INVALID_POSITION.w = 0.0;
		  v60 = 0LL;
		  v5 = sub_18011C4C0(MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::NativeParallelHashMap->klass);
		  Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::NativeParallelHashMap(
		    &v60,
		    200,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v5 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z = v60;
		  v6 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>);
		  v9 = v6;
		  if ( !v6 )
		    goto LABEL_2;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v6,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::DynamicArray);
		  *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z = v9;
		  sub_18002D1B0((SingleFieldAccessor *)&this[1].fields.clothConstData.clothParam1.z, v10, v11, v12, methoda);
		  v60 = 0LL;
		  v13 = sub_18011C4C0(MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::NativeParallelHashMap->klass);
		  Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::NativeParallelHashMap(
		    (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&v60,
		    50,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v13 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.m_characterMesh = v60;
		  v60 = 0LL;
		  v14 = sub_18011C4C0(MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::NativeParallelHashMap->klass);
		  Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::NativeParallelHashMap(
		    (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&v60,
		    50,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v14 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.needClearGPUBuffer = v60;
		  this[1].fields.clothMetaDataBuffer = (ComputeBuffer *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 50LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this[1].fields.clothMetaDataBuffer, v15, v16, v17, methode);
		  v18 = (IndexedHashSet_1_System_UInt32_ *)sub_1800368D0(TypeInfo::Beyond::IndexedHashSet<unsigned int>);
		  v19 = (ComputeBuffer *)v18;
		  if ( !v18 )
		    goto LABEL_2;
		  Beyond::IndexedHashSet<unsigned int>::IndexedHashSet(
		    v18,
		    50,
		    MethodInfo::Beyond::IndexedHashSet<unsigned int>::IndexedHashSet);
		  this[1].fields.clothBatchMetaDataBuffer = v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this[1].fields.clothBatchMetaDataBuffer, v20, v21, v22, methodb);
		  v60 = 0LL;
		  Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
		    (NativeParallelHashSet_1_System_UInt32_ *)&v60,
		    50,
		    (AllocatorManager_AllocatorHandle)4,
		    MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothBatchCacheMapBuffer = v60;
		  v60 = 0LL;
		  Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
		    (NativeParallelHashSet_1_System_UInt32_ *)&v60,
		    50,
		    (AllocatorManager_AllocatorHandle)4,
		    MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.renderData.isValid = v60;
		  v23 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<unsigned int>);
		  v24 = v23;
		  if ( !v23
		    || (UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		          v23,
		          MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::DynamicArray),
		        *(_QWORD *)&this[1].fields.renderData.clothConstData.packedDeltaT.z = v24,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this[1].fields.renderData.clothConstData.packedDeltaT.z,
		          v25,
		          v26,
		          v27,
		          methodc),
		        v28 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<unsigned int>),
		        (v29 = v28) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(clothMetaDataBuffer, v7);
		  }
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v28,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::DynamicArray);
		  *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.x = v29;
		  sub_18002D1B0((SingleFieldAccessor *)&this[1].fields.renderData.clothConstData.clothParam1, v30, v31, v32, methodd);
		  *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.z = 0LL;
		  *(_QWORD *)&this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField = 0LL;
		  v60 = 0LL;
		  Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
		    (NativeParallelHashSet_1_System_UInt32_ *)&v60,
		    50,
		    (AllocatorManager_AllocatorHandle)4,
		    MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.renderData.clothNodeDataBuffer = v60;
		  v60 = 0LL;
		  Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
		    (NativeParallelHashSet_1_System_UInt32_ *)&v60,
		    4,
		    (AllocatorManager_AllocatorHandle)4,
		    MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
		  *(_QWORD *)v61 = 0LL;
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.renderData.clothBatchMetaDataBuffer = v60;
		  memset(&v61[88], 0, 40);
		  klass = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::NativeList->klass;
		  v60 = 0LL;
		  v34 = sub_18011C4C0(klass);
		  Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::NativeList(
		    (NativeList_1_HG_Rendering_Runtime_ClothGroupUploadDataMap_ *)&v60,
		    4,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v34 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v61[8] = v60;
		  v35 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::NativeList->klass;
		  v60 = 0LL;
		  v36 = sub_18011C4C0(v35);
		  Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::NativeList(
		    (NativeList_1_HG_Rendering_Runtime_ClothMetaData_ *)&v60,
		    200,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v36 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v61[24] = v60;
		  v37 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::NativeList->klass;
		  v60 = 0LL;
		  v38 = sub_18011C4C0(v37);
		  Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::NativeList(
		    (NativeList_1_HG_Rendering_Runtime_ClothNodeData_ *)&v60,
		    680,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v38 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v61[40] = v60;
		  v39 = MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList->klass;
		  v60 = 0LL;
		  v40 = sub_18011C4C0(v39);
		  Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList(
		    (NativeList_1_Unity_Mathematics_int4_ *)&v60,
		    16,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v40 + 192));
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v61[56] = v60;
		  v41 = MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList->klass;
		  v60 = 0LL;
		  v42 = sub_18011C4C0(v41);
		  Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList(
		    (NativeList_1_Unity_Mathematics_int4_ *)&v60,
		    128,
		    (AllocatorManager_AllocatorHandle)4,
		    2,
		    **(MethodInfo ***)(v42 + 192));
		  v43 = v60;
		  *(_OWORD *)&this[1].fields.clearBufferData.shouldClear = *(_OWORD *)v61;
		  v44 = *(_OWORD *)&v61[32];
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v61[72] = v43;
		  *(_OWORD *)&this[1].fields.clearBufferData.eleNum.w = *(_OWORD *)&v61[16];
		  v45 = *(_OWORD *)&v61[48];
		  *(_OWORD *)&this[1].fields.clearBufferData.clothBatchMetaDataBuffer = v44;
		  v46 = *(_OWORD *)&v61[64];
		  *(_OWORD *)&this[1].fields.isStreamingMode = v45;
		  v47 = *(_OWORD *)&v61[80];
		  *(_OWORD *)&this[1].fields.shouldStep = v46;
		  v48 = *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v61[96];
		  *(_OWORD *)&this[1].fields.windNoiseUV.x = v47;
		  v49 = *(_OWORD *)&v61[112];
		  this[1].fields.m_clothHashToRuntimeClothData = v48;
		  *(_OWORD *)&this[1].fields.m_runtimeClothMetaArray = v49;
		  sub_18002D1B0((SingleFieldAccessor *)&this[1].fields.m_runtimeClothNum, v50, v51, v52, methodf);
		  do
		  {
		    clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
		    if ( !clothMetaDataBuffer )
		      goto LABEL_2;
		    if ( (unsigned int)v4 >= LODWORD(clothMetaDataBuffer[1].klass) )
		      sub_1800D2AB0(clothMetaDataBuffer, v7);
		    v53 = v4++;
		    *((_DWORD *)&clothMetaDataBuffer[1].monitor + v53) = 1;
		  }
		  while ( v4 < 50 );
		}
		
		static GpuClothManager() {} // 0x0000000184D61580-0x0000000184D615D0
		// GpuClothManager()
		void HG::Rendering::Runtime::GpuClothManager::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *static_fields; // rdx
		  MethodInfo *v7; // [rsp+50h] [rbp+28h]
		
		  v1 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GpuClothManager::ClothActivateComparer);
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::GpuClothManager->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GpuClothManager->static_fields,
		    static_fields,
		    v4,
		    v5,
		    v7);
		}
		
	
		// Methods
		internal void Initialize(HGRenderPipelineRuntimeResources resource) {} // 0x00000001847A5360-0x00000001847A53C0
		// Void Initialize(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::GpuClothManager::Initialize(
		        GpuClothManager *this,
		        HGRenderPipelineRuntimeResources *resource,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1281, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1281, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)resource,
		      0LL);
		  }
		  else
		  {
		    if ( !resource || (assets = resource->fields.assets) == 0LL )
		LABEL_4:
		      sub_1800D8260(v6, assets);
		    HG::Rendering::Runtime::GpuClothManager::_SetCharacterProxyMesh(this, assets->fields.defaultCapsuleMesh, 0LL);
		  }
		}
		
		internal void Tick(float deltaTime) {} // 0x00000001832E11D0-0x00000001832E1250
		// Void Tick(Single)
		void HG::Rendering::Runtime::GpuClothManager::Tick(GpuClothManager *this, float deltaTime, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1283 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		    if ( v4 )
		    {
		      if ( LODWORD(v4->_0.namespaze) <= 0x503 )
		        sub_1800D2AB0(v4, wrapperArray);
		      if ( !v4[27]._0.properties )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1283, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		          (ILFixDynamicMethodWrapper_18 *)Patch,
		          (Object *)this,
		          deltaTime,
		          0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v4, wrapperArray);
		  }
		LABEL_5:
		  this[1].fields.CHARACTER_POSITION_OFFSET.x = deltaTime;
		  HG::Rendering::Runtime::GpuClothManager::_UpdateWindParams(this, 0LL);
		  if ( LOBYTE(this[1].monitor) )
		  {
		    HG::Rendering::Runtime::GpuClothManager::_ProcessPendingQueue(this, 0LL);
		    HG::Rendering::Runtime::GpuClothManager::_SetPerDrawData(this, 0LL);
		    HG::Rendering::Runtime::GpuClothManager::_UpdateStreamingMode(this, 0LL);
		  }
		}
		
		private void _UpdateWindParams() {} // 0x00000001832DF7A0-0x00000001832DF960
		// Void _UpdateWindParams()
		void HG::Rendering::Runtime::GpuClothManager::_UpdateWindParams(GpuClothManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  Vector2 wrapperArray; // rdx
		  HGEnvironmentPhase *s_interpolatedPhase; // rax
		  Vector2 v6; // r8
		  int32_t v7; // r9d
		  __m128 z_low; // xmm8
		  __m128 w_low; // xmm9
		  __int64 v10; // xmm7_8
		  float z; // edi
		  Vector2 v12; // xmm2_8
		  Vector2 v13; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v16; // [rsp+20h] [rbp-58h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (Vector2)v3->static_fields->wrapperArray;
		  if ( !*(_QWORD *)&wrapperArray )
		    goto LABEL_14;
		  if ( *(int *)(*(_QWORD *)&wrapperArray + 24LL) <= 1284 )
		    goto LABEL_32;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (Vector2)v3->static_fields->wrapperArray;
		  if ( !*(_QWORD *)&wrapperArray )
		    goto LABEL_14;
		  if ( *(_DWORD *)(*(_QWORD *)&wrapperArray + 24LL) <= 0x504u )
		    goto LABEL_29;
		  if ( !*(_QWORD *)(*(_QWORD *)&wrapperArray + 10304LL) )
		  {
		LABEL_32:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    s_interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
		    z_low = (__m128)LODWORD(this[1].fields.INVALID_POSITION.z);
		    w_low = (__m128)LODWORD(this[1].fields.INVALID_POSITION.w);
		    this[1].fields.INVALID_POSITION.x = (float)((float)((float)(this[1].fields.INVALID_POSITION.y * 0.25) * 0.079999998)
		                                              * this[1].fields.CHARACTER_POSITION_OFFSET.x)
		                                      + this[1].fields.INVALID_POSITION.x;
		    if ( !s_interpolatedPhase )
		      goto LABEL_14;
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v10 = *(_QWORD *)&s_interpolatedPhase->fields.windConfig.direction.x;
		    z = s_interpolatedPhase->fields.windConfig.direction.z;
		    *(_QWORD *)&v16.x = v10;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (Vector2)v3->static_fields->wrapperArray;
		    if ( !*(_QWORD *)&wrapperArray )
		      goto LABEL_14;
		    if ( *(int *)(*(_QWORD *)&wrapperArray + 24LL) <= 630 )
		    {
		LABEL_12:
		      v12 = (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v16.x), (__m128)_mm_cvtsi32_si128(LODWORD(z))).m128_u64[0];
		LABEL_13:
		      v13 = sub_1858CACF0(v12, wrapperArray, v6, v7);
		      *(_QWORD *)&this[1].fields.INVALID_POSITION.z = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(
		                                                        _mm_unpacklo_ps(z_low, w_low).m128_u64[0],
		                                                        v13);
		      return;
		    }
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		LABEL_14:
		      sub_1800D8260(v3, wrapperArray);
		    if ( LODWORD(v3->_0.namespaze) > 0x276 )
		    {
		      if ( !v3[13].static_fields )
		        goto LABEL_12;
		      Patch = IFix::WrappersManagerImpl::GetPatch(630, 0LL);
		      if ( Patch )
		      {
		        *(_QWORD *)&v16.x = v10;
		        v16.z = z;
		        v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v16, 0LL);
		        goto LABEL_13;
		      }
		      goto LABEL_14;
		    }
		LABEL_29:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		  v14 = IFix::WrappersManagerImpl::GetPatch(1284, 0LL);
		  if ( !v14 )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v14, (Object *)this, 0LL);
		}
		
		private void _ProcessPendingQueue() {} // 0x0000000189C6C984-0x0000000189C6CBEC
		// Void _ProcessPendingQueue()
		void HG::Rendering::Runtime::GpuClothManager::_ProcessPendingQueue(GpuClothManager *this, MethodInfo *method)
		{
		  double v3; // xmm0_8
		  float v4; // xmm1_4
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rax
		  __int64 v8; // rax
		  int32_t i; // edi
		  __int64 v10; // rax
		  IndexedArray_1_System_Int32_ *v11; // rcx
		  uint32_t *Ref; // rax
		  int32_t j; // edi
		  __int64 v14; // rax
		  IndexedArray_1_System_Int32_ *v15; // rcx
		  uint32_t *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  GpuClothManager_ClothGroupData_Internal v18; // [rsp+20h] [rbp-128h] BYREF
		  __int128 v19; // [rsp+80h] [rbp-C8h]
		  __int128 v20; // [rsp+90h] [rbp-B8h]
		  __int128 v21; // [rsp+A0h] [rbp-A8h]
		  GpuClothManager_ClothGroupData_Internal clothGroupData; // [rsp+B0h] [rbp-98h] BYREF
		  __int128 v23; // [rsp+110h] [rbp-38h]
		  __int128 v24; // [rsp+120h] [rbp-28h]
		  __int128 v25; // [rsp+130h] [rbp-18h]
		  __int64 v26; // [rsp+160h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1285, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1285, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_21;
		  }
		  if ( LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) )
		    return;
		  if ( Unity::Collections::NativeParallelHashSet<Unity::Mathematics::int4>::Count(
		         (NativeParallelHashSet_1_Unity_Mathematics_int4_ *)&this[1].fields.renderData.clothNodeDataBuffer,
		         MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Count) > 0 )
		    return;
		  v26 = sub_1858CAD18(
		          _mm_unpacklo_ps(
		            (__m128)LODWORD(this[1].fields.renderData.clothConstData.clothParam1.z),
		            (__m128)LODWORD(this[1].fields.renderData.clothConstData.clothParam1.w)).m128_u64[0],
		          _mm_unpacklo_ps(
		            (__m128)LODWORD(this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField),
		            (__m128)*((unsigned int *)&this[1].fields.renderData.clothConstData + 9)).m128_u64[0]);
		  v3 = sub_182FA2AF0(&v26);
		  if ( *(float *)&v3 < 32.0 && !LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) )
		    return;
		  v4 = *((float *)&this[1].fields.renderData.clothConstData + 9);
		  this[1].fields.renderData.clothConstData.clothParam1.z = this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField;
		  this[1].fields.renderData.clothConstData.clothParam1.w = v4;
		  HG::Rendering::Runtime::GpuClothManager::_UpdatePendingGroupHash(this, 1, 0LL);
		  v7 = *(_QWORD *)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
		  if ( !v7
		    || (v6 = *(unsigned int *)(v7 + 24), (v8 = *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.x) == 0) )
		  {
		LABEL_21:
		    sub_1800D8260(v6, v5);
		  }
		  if ( (_DWORD)v6 || *(_DWORD *)(v8 + 24) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      v10 = *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.x;
		      if ( !v10 )
		        goto LABEL_21;
		      v11 = *(IndexedArray_1_System_Int32_ **)&this[1].fields.renderData.clothConstData.clothParam1.x;
		      if ( i >= *(_DWORD *)(v10 + 24) )
		        break;
		      Ref = (uint32_t *)Beyond::Gameplay::Core::DynamicScene::IndexedArray<int>::GetRef(
		                          v11,
		                          i,
		                          MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item);
		      HG::Rendering::Runtime::GpuClothManager::_DeactivateClothGroup_Internal(this, *Ref, 0LL);
		    }
		    UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		      (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v11,
		      MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
		    for ( j = 0; ; ++j )
		    {
		      v14 = *(_QWORD *)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
		      if ( !v14 )
		        goto LABEL_21;
		      v15 = *(IndexedArray_1_System_Int32_ **)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
		      if ( j >= *(_DWORD *)(v14 + 24) )
		        break;
		      v16 = (uint32_t *)Beyond::Gameplay::Core::DynamicScene::IndexedArray<int>::GetRef(
		                          v15,
		                          j,
		                          MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item);
		      Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
		        &v18,
		        (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&this[1].fields.m_characterMesh,
		        *v16,
		        MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
		      clothGroupData = v18;
		      v23 = v19;
		      v24 = v20;
		      v25 = v21;
		      HG::Rendering::Runtime::GpuClothManager::_ActivateClothGroup_Internal(this, &clothGroupData, 0LL);
		    }
		    UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		      (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v15,
		      MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
		  }
		  LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 0;
		}
		
		private void _SetPerDrawData() {} // 0x0000000189C6CBEC-0x0000000189C6CE70
		// Void _SetPerDrawData()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::GpuClothManager::_SetPerDrawData(GpuClothManager *this, MethodInfo *method)
		{
		  EntityManagerRange_Enumerator *Enumerator; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // rbx
		  bool v7; // zf
		  EntityTypeInstanceData *v8; // rbx
		  ECSClothDataComponent *v9; // r15
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  CommonInstanceDataComponent *v12; // r12
		  int32_t i; // edi
		  char *v14; // rsi
		  bool Value; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  GpuClothManager_RuntimeClothData_Internal item; // [rsp+20h] [rbp-108h] BYREF
		  EntityManager v20; // [rsp+30h] [rbp-F8h] BYREF
		  _BYTE v21[48]; // [rsp+40h] [rbp-E8h] BYREF
		  __int64 v22; // [rsp+70h] [rbp-B8h]
		  EntityManager v23; // [rsp+78h] [rbp-B0h] BYREF
		  Il2CppExceptionWrapper *v24; // [rsp+88h] [rbp-A0h] BYREF
		  EntityManagerRange v25; // [rsp+90h] [rbp-98h] BYREF
		  __int128 v26; // [rsp+B0h] [rbp-78h]
		  EntityManagerRange v27; // [rsp+C8h] [rbp-60h] BYREF
		  __int128 v28; // [rsp+E8h] [rbp-40h]
		  GroupType v29; // [rsp+140h] [rbp+18h] BYREF
		
		  v23 = 0LL;
		  memset(v21, 0, sizeof(v21));
		  v22 = 0LL;
		  *(_QWORD *)&item.isDataReady = 0LL;
		  item.isSingleSkeleton = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1291, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1291, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v18, v17);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v23 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v20, 0LL);
		    UnityEngine::HyperGryph::ECS::EntityManager::Iterate<Beyond::Gameplay::Factory::UnitTransFragment,Beyond::Gameplay::Factory::CurMapUnitTag>(
		      &v25,
		      &v23,
		      MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::ECSClothDataComponent,UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>);
		    v27 = v25;
		    v28 = v26;
		    Enumerator = UnityEngine::HyperGryph::ECS::EntityManagerRange::GetEnumerator(
		                   (EntityManagerRange_Enumerator *)&v25,
		                   &v27,
		                   0LL);
		    *(_OWORD *)v21 = *(_OWORD *)&Enumerator->m_entityTypes;
		    *(_OWORD *)&v21[16] = *(_OWORD *)&Enumerator->m_includeComponentMask.componentMaskWords.FixedElementField;
		    *(_OWORD *)&v21[32] = *(_OWORD *)&Enumerator->m_index;
		    v22 = *(_QWORD *)&Enumerator[1].m_count;
		    v20.m_entitiesPPtr = 0LL;
		    v20.m_entityTypesPPtr = v21;
		    try
		    {
		      while ( UnityEngine::HyperGryph::ECS::EntityManagerRange::Enumerator::MoveNext(
		                (EntityManagerRange_Enumerator *)v21,
		                0LL) )
		      {
		        v6 = 576LL * (int)v22;
		        v7 = *(_QWORD *)v21 + v6 == 0;
		        v8 = (EntityTypeInstanceData *)(*(_QWORD *)v21 + v6);
		        v29.m_entityTypes = v8;
		        if ( v7 )
		          sub_1800D8250(v5, v4);
		        v9 = UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::ECSClothDataComponent>(
		               &v29,
		               MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::ECSClothDataComponent>);
		        v12 = UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>(
		                &v29,
		                MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>);
		        for ( i = 0; ; ++i )
		        {
		          if ( !v8 )
		            sub_1800D8250(v11, v10);
		          if ( i >= v8->count )
		            break;
		          v14 = (char *)v12 + 256 * (__int64)i;
		          Value = Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::TryGetValue(
		                    (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z,
		                    v9[i].clothHash,
		                    &item,
		                    MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::TryGetValue);
		          *((_DWORD *)v14 + 60) = 0;
		          if ( Value && item.isDataReady )
		          {
		            *((float *)v14 + 60) = item.skeletonOffset + 1.0;
		            *((_DWORD *)v14 + 61) = LODWORD(item.isSingleSkeleton);
		          }
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v24 )
		    {
		      v20.m_entitiesPPtr = v24->ex;
		      if ( v20.m_entitiesPPtr )
		        sub_18007E1E0(v20.m_entitiesPPtr);
		    }
		  }
		}
		
		private void _UpdateStreamingMode() {} // 0x0000000189C6D614-0x0000000189C6D694
		// Void _UpdateStreamingMode()
		void HG::Rendering::Runtime::GpuClothManager::_UpdateStreamingMode(GpuClothManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  _BOOL8 v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1292, 0LL) )
		  {
		    if ( Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int4,bool>::Count(
		           (NativeParallelHashMap_2_Unity_Mathematics_int4_System_Boolean_ *)&this[1].fields.m_characterMesh,
		           MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Count) )
		    {
		      LOBYTE(v5) = 1;
		    }
		    else
		    {
		      v5 = LODWORD(this[1].fields.clothConstData.packedDeltaT.y) != 0;
		    }
		    if ( this )
		    {
		      LOBYTE(this[1].monitor) = v5;
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1292, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _UpdatePendingGroupHash(bool needSwap) {} // 0x0000000189C6CE70-0x0000000189C6D304
		// Void _UpdatePendingGroupHash(Boolean)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::GpuClothManager::_UpdatePendingGroupHash(
		        GpuClothManager *this,
		        bool needSwap,
		        MethodInfo *method)
		{
		  GpuClothManager *v4; // rbx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdi
		  __int64 v8; // rdi
		  __int128 v9; // xmm1
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  int32_t j; // esi
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  uint32_t v17; // eax
		  __int64 v18; // rdx
		  GpuClothManager__StaticFields *static_fields; // rcx
		  GpuClothManager_ClothActivateComparer *s_clothActiveComparer; // rdi
		  float v21; // xmm7_4
		  GpuClothManager__StaticFields *v22; // rcx
		  IComparer_1_System_UInt32_ **v23; // rdx
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  int32_t i; // esi
		  uint32_t Item; // eax
		  __int64 v28; // rdx
		  DynamicArray_1_System_UInt32_ *v29; // rcx
		  __int64 v30; // rdx
		  DynamicArray_1_System_UInt32_ *v31; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  Il2CppExceptionWrapper *v35; // [rsp+20h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v36; // [rsp+28h] [rbp-70h] BYREF
		  NativeParallelHashSet_1_T_Enumerator_System_UInt32_ v37; // [rsp+30h] [rbp-68h] BYREF
		  NativeParallelHashSet_1_T_Enumerator_System_UInt32_ v38; // [rsp+48h] [rbp-50h] BYREF
		  uint32_t value; // [rsp+B8h] [rbp+20h] BYREF
		
		  v4 = this;
		  memset(&v38, 0, sizeof(v38));
		  if ( IFix::WrappersManagerImpl::IsPatched(1286, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1286, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v34, v33);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)v4, needSwap, 0LL);
		  }
		  else
		  {
		    v7 = *(_QWORD *)&v4[1].fields.renderData.clothConstData.packedDeltaT.z;
		    if ( !v7 )
		      sub_1800D8260(v6, v5);
		    if ( *(int *)(v7 + 24) <= 0 )
		    {
		      v8 = *(_QWORD *)&v4[1].fields.renderData.clothConstData.clothParam1.x;
		      if ( !v8 )
		        sub_1800D8260(v6, v5);
		      if ( *(int *)(v8 + 24) <= 0 )
		      {
		        if ( needSwap )
		        {
		          v9 = *(_OWORD *)&v4[1].fields.renderData.isValid;
		          *(_OWORD *)&v4[1].fields.renderData.isValid = *(_OWORD *)&v4[1].fields.clothBatchCacheMapBuffer;
		          *(_OWORD *)&v4[1].fields.clothBatchCacheMapBuffer = v9;
		        }
		        Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
		          (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
		          MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
		        if ( !v4[1].fields.clothBatchMetaDataBuffer )
		          sub_1800D8260(v11, v10);
		        if ( ParadoxNotion::WeakReferenceTable<System::Object,System::Object>::get_Count(
		               (WeakReferenceTable_2_System_Object_System_Object_ *)v4[1].fields.clothBatchMetaDataBuffer,
		               MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Count) > 50 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GpuClothManager);
		          static_fields = TypeInfo::HG::Rendering::Runtime::GpuClothManager->static_fields;
		          s_clothActiveComparer = static_fields->s_clothActiveComparer;
		          v21 = *((float *)&v4[1].fields.renderData.clothConstData + 9);
		          if ( !static_fields->s_clothActiveComparer )
		            sub_1800D8260(static_fields, v18);
		          s_clothActiveComparer->fields.playerCenterXZ.x = v4[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField;
		          s_clothActiveComparer->fields.playerCenterXZ.y = v21;
		          v22 = TypeInfo::HG::Rendering::Runtime::GpuClothManager->static_fields;
		          if ( !v22->s_clothActiveComparer )
		            sub_1800D8260(v22, v18);
		          v22->s_clothActiveComparer->fields.registedClothGroupData = (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&v4[1].fields.m_characterMesh;
		          v23 = (IComparer_1_System_UInt32_ **)TypeInfo::HG::Rendering::Runtime::GpuClothManager->static_fields;
		          if ( !v4[1].fields.clothBatchMetaDataBuffer )
		            sub_1800D8260(v22, v23);
		          Beyond::IndexedHashSet<unsigned int>::Sort(
		            (IndexedHashSet_1_System_UInt32_ *)v4[1].fields.clothBatchMetaDataBuffer,
		            *v23,
		            MethodInfo::Beyond::IndexedHashSet<unsigned int>::Sort);
		          for ( i = 0; i < 50; ++i )
		          {
		            if ( !v4[1].fields.clothBatchMetaDataBuffer )
		              sub_1800D8260(v25, v24);
		            Item = Beyond::IndexedHashSet<unsigned int>::get_Item(
		                     (IndexedHashSet_1_System_UInt32_ *)v4[1].fields.clothBatchMetaDataBuffer,
		                     i,
		                     MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Item);
		            Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
		              (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
		              Item,
		              MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
		          }
		        }
		        else
		        {
		          for ( j = 0; ; ++j )
		          {
		            if ( !v4[1].fields.clothBatchMetaDataBuffer )
		              sub_1800D8260(v13, v12);
		            if ( j >= ParadoxNotion::WeakReferenceTable<System::Object,System::Object>::get_Count(
		                        (WeakReferenceTable_2_System_Object_System_Object_ *)v4[1].fields.clothBatchMetaDataBuffer,
		                        MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Count) )
		              break;
		            if ( !v4[1].fields.clothBatchMetaDataBuffer )
		              sub_1800D8260(v16, v15);
		            v17 = Beyond::IndexedHashSet<unsigned int>::get_Item(
		                    (IndexedHashSet_1_System_UInt32_ *)v4[1].fields.clothBatchMetaDataBuffer,
		                    j,
		                    MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Item);
		            Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
		              (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
		              v17,
		              MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
		          }
		        }
		        Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashSet<unsigned int>::GetEnumerator(
		          (UnsafeParallelHashSet_1_T_Enumerator_System_UInt32_ *)&v37,
		          (UnsafeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.renderData,
		          MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::GetEnumerator);
		        v38 = v37;
		        v37.m_Enumerator.m_Buffer = 0LL;
		        *(_QWORD *)&v37.m_Enumerator.m_Index = &v38;
		        try
		        {
		          while ( Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext(
		                    &v38,
		                    MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext) )
		          {
		            value = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
		                      &v38,
		                      MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
		            if ( !Unity::Collections::NativeParallelHashSet<unsigned int>::Contains(
		                    (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
		                    value,
		                    MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Contains) )
		            {
		              v29 = *(DynamicArray_1_System_UInt32_ **)&v4[1].fields.renderData.clothConstData.clothParam1.x;
		              if ( !v29 )
		                sub_1800D8250(0LL, v28);
		              UnityEngine::Rendering::DynamicArray<unsigned int>::Add(
		                v29,
		                &value,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Add);
		            }
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v35 )
		        {
		          v37.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v35->ex;
		          if ( v37.m_Enumerator.m_Buffer )
		            sub_18007E1E0(v37.m_Enumerator.m_Buffer);
		          v4 = this;
		        }
		        v37.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v4[1].fields.clothBatchCacheMapBuffer;
		        *(_QWORD *)&v37.m_Enumerator.m_Index = 0xFFFFFFFFLL;
		        *(_QWORD *)&v37.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
		        *(_OWORD *)&v38.m_Enumerator.m_Buffer = *(_OWORD *)&v37.m_Enumerator.m_Buffer;
		        *(_QWORD *)&v38.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
		        v37.m_Enumerator.m_Buffer = 0LL;
		        *(_QWORD *)&v37.m_Enumerator.m_Index = &v38;
		        try
		        {
		          while ( Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext(
		                    &v38,
		                    MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext) )
		          {
		            value = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
		                      &v38,
		                      MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
		            if ( !Unity::Collections::NativeParallelHashSet<unsigned int>::Contains(
		                    (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.renderData,
		                    value,
		                    MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Contains) )
		            {
		              v31 = *(DynamicArray_1_System_UInt32_ **)&v4[1].fields.renderData.clothConstData.packedDeltaT.z;
		              if ( !v31 )
		                sub_1800D8250(0LL, v30);
		              UnityEngine::Rendering::DynamicArray<unsigned int>::Add(
		                v31,
		                &value,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Add);
		            }
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v36 )
		        {
		          v37.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v36->ex;
		          if ( v37.m_Enumerator.m_Buffer )
		            sub_18007E1E0(v37.m_Enumerator.m_Buffer);
		        }
		      }
		    }
		  }
		}
		
		public void RegisterClothGroup([IsReadOnly] in ClothGroupData clothGroupData) {} // 0x0000000189C6BF28-0x0000000189C6C050
		// Void RegisterClothGroup(ClothGroupData ByRef)
		void HG::Rendering::Runtime::GpuClothManager::RegisterClothGroup(
		        GpuClothManager *this,
		        ClothGroupData *clothGroupData,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  GpuClothManager_ClothGroupData_Internal v8; // [rsp+20h] [rbp-128h] BYREF
		  __int128 v9; // [rsp+80h] [rbp-C8h]
		  __int128 v10; // [rsp+90h] [rbp-B8h]
		  __int128 v11; // [rsp+A0h] [rbp-A8h]
		  GpuClothManager_ClothGroupData_Internal v12; // [rsp+B0h] [rbp-98h] BYREF
		  __int128 v13; // [rsp+110h] [rbp-38h]
		  __int128 v14; // [rsp+120h] [rbp-28h]
		  __int128 v15; // [rsp+130h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1293, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1293, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_499(Patch, (Object *)this, clothGroupData, 0LL);
		  }
		  else
		  {
		    if ( !LOBYTE(this[1].monitor) )
		    {
		      HG::Rendering::Runtime::GpuClothManager::ResetCpuData(this, 0LL);
		      HG::Rendering::Runtime::GpuClothManager::ResetStreamingResource(this, 0LL);
		      HG::Rendering::Runtime::GpuClothManager::_InitStreamingGpuBuffer(this, 0LL);
		      LOBYTE(this[1].monitor) = 1;
		    }
		    sub_18033B9D0(&v8, 0LL, 144LL);
		    HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::CopyFromClothGroupData(&v8, clothGroupData, 0LL);
		    v12 = v8;
		    v13 = v9;
		    v14 = v10;
		    v15 = v11;
		    sub_1806B076C(
		      &this[1].fields.m_characterMesh,
		      clothGroupData->clothGroupMeta.clothGroupHash,
		      &v12,
		      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Add);
		  }
		}
		
		public void ActivateClothGroup(uint clothGroupHash) {} // 0x0000000189C6ADC8-0x0000000189C6AE40
		// Void ActivateClothGroup(UInt32)
		void HG::Rendering::Runtime::GpuClothManager::ActivateClothGroup(
		        GpuClothManager *this,
		        uint32_t clothGroupHash,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ComputeBuffer *clothBatchMetaDataBuffer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1299, 0LL) )
		  {
		    clothBatchMetaDataBuffer = this[1].fields.clothBatchMetaDataBuffer;
		    if ( clothBatchMetaDataBuffer )
		    {
		      Beyond::IndexedHashSet<unsigned int>::Add(
		        (IndexedHashSet_1_System_UInt32_ *)clothBatchMetaDataBuffer,
		        clothGroupHash,
		        MethodInfo::Beyond::IndexedHashSet<unsigned int>::Add);
		      LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 1;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(clothBatchMetaDataBuffer, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1299, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		    (ILFixDynamicMethodWrapper_9 *)Patch,
		    (Object *)this,
		    (LoginSceneAnimCtrl_EState__Enum)clothGroupHash,
		    0LL);
		}
		
		private void _ActivateClothGroup_Internal(ref ClothGroupData_Internal clothGroupData) {} // 0x0000000189C6C568-0x0000000189C6C5FC
		// Void _ActivateClothGroup_Internal(GpuClothManager+ClothGroupData_Internal ByRef)
		void HG::Rendering::Runtime::GpuClothManager::_ActivateClothGroup_Internal(
		        GpuClothManager *this,
		        GpuClothManager_ClothGroupData_Internal *clothGroupData,
		        MethodInfo *method)
		{
		  int32_t updated; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1289, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1289, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_496(Patch, (Object *)this, clothGroupData, 0LL);
		  }
		  else
		  {
		    updated = HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeGroupMeta(
		                this,
		                &clothGroupData->clothGroupMeta,
		                clothGroupData->groupClothBatchCacheBytes,
		                0LL);
		    HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeBuffer(this, updated, clothGroupData, 0LL);
		    Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
		      (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData.clothNodeDataBuffer,
		      clothGroupData->clothGroupMeta.clothGroupHash,
		      MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
		    LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) = 1;
		  }
		}
		
		public void DeactivateClothGroup(uint clothGroupHash) {} // 0x0000000189C6AE40-0x0000000189C6AEB8
		// Void DeactivateClothGroup(UInt32)
		void HG::Rendering::Runtime::GpuClothManager::DeactivateClothGroup(
		        GpuClothManager *this,
		        uint32_t clothGroupHash,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ComputeBuffer *clothBatchMetaDataBuffer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1300, 0LL) )
		  {
		    clothBatchMetaDataBuffer = this[1].fields.clothBatchMetaDataBuffer;
		    if ( clothBatchMetaDataBuffer )
		    {
		      Beyond::IndexedHashSet<unsigned int>::Remove(
		        (IndexedHashSet_1_System_UInt32_ *)clothBatchMetaDataBuffer,
		        clothGroupHash,
		        MethodInfo::Beyond::IndexedHashSet<unsigned int>::Remove);
		      LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 1;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(clothBatchMetaDataBuffer, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1300, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		    (ILFixDynamicMethodWrapper_9 *)Patch,
		    (Object *)this,
		    (LoginSceneAnimCtrl_EState__Enum)clothGroupHash,
		    0LL);
		}
		
		private void _DeactivateClothGroup_Internal(uint clothGroupHash) {} // 0x0000000189C6C5FC-0x0000000189C6C8B0
		// Void _DeactivateClothGroup_Internal(UInt32)
		void HG::Rendering::Runtime::GpuClothManager::_DeactivateClothGroup_Internal(
		        GpuClothManager *this,
		        uint32_t clothGroupHash,
		        MethodInfo *method)
		{
		  int32_t clothNum; // edi
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ClothGroupMeta_clothHashes_e_FixedBuffer *p_clothHashes; // r14
		  __int64 v9; // r15
		  ComputeBuffer *clothMetaDataBuffer; // rax
		  int v11; // r15d
		  int32_t *i; // rdi
		  int32_t v13; // r14d
		  DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ *v14; // rax
		  unsigned int w; // r12d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _OWORD v17[6]; // [rsp+20h] [rbp-E0h] BYREF
		  int v18; // [rsp+80h] [rbp-80h]
		  GpuClothManager_ClothGroupMeta_Internal item; // [rsp+90h] [rbp-70h] BYREF
		  unsigned int v20; // [rsp+E0h] [rbp-20h]
		  char v21; // [rsp+E4h] [rbp-1Ch] BYREF
		  _OWORD v22[6]; // [rsp+100h] [rbp+0h] BYREF
		  int v23; // [rsp+160h] [rbp+60h]
		
		  sub_18033B9D0(&item, 0LL, 100LL);
		  sub_18033B9D0(v17, 0LL, 100LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1287, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1287, 0LL);
		    if ( !Patch )
		      goto LABEL_24;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (LoginSceneAnimCtrl_EState__Enum)clothGroupHash,
		      0LL);
		  }
		  else if ( Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue(
		              (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&this[1].fields.needClearGPUBuffer,
		              clothGroupHash,
		              &item,
		              MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue) )
		  {
		    --LODWORD(this[1].fields.clothConstData.packedDeltaT.y);
		    clothNum = item.clothGroupMeta.clothNum;
		    LODWORD(this[1].fields.clothConstData.packedDeltaT.x) -= item.clothGroupMeta.clothNum;
		    Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove(
		      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.needClearGPUBuffer,
		      clothGroupHash,
		      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Remove);
		    if ( clothNum > 0 )
		    {
		      p_clothHashes = &item.clothGroupMeta.clothHashes;
		      v9 = (unsigned int)clothNum;
		      do
		      {
		        Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove(
		          (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z,
		          p_clothHashes->FixedElementField,
		          MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove);
		        ++p_clothHashes;
		        --v9;
		      }
		      while ( v9 );
		    }
		    clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
		    if ( !clothMetaDataBuffer )
		      goto LABEL_24;
		    if ( v20 >= LODWORD(clothMetaDataBuffer[1].klass) )
		      sub_1800D2AB0((int)v20, v6);
		    v11 = 0;
		    *((_DWORD *)&clothMetaDataBuffer[1].monitor + (int)v20) = 1;
		    if ( clothNum > 0 )
		    {
		      for ( i = (int32_t *)&v21; ; ++i )
		      {
		        v13 = *i;
		        HG::Rendering::Runtime::GpuClothUtils::SwapAndRemove<HG::Rendering::Runtime::ClothMetaData>(
		          *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z,
		          *i,
		          MethodInfo::HG::Rendering::Runtime::GpuClothUtils::SwapAndRemove<HG::Rendering::Runtime::ClothMetaData>);
		        v14 = *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z;
		        *i = -1;
		        LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) = 1;
		        if ( !v14 )
		          break;
		        if ( v13 != v14->fields._size_k__BackingField )
		        {
		          w = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item(
		                v14,
		                v13,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item)->groupOffset.w;
		          if ( w == item.clothGroupMeta.clothGroupHash )
		          {
		            v6 = *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z;
		            if ( !v6 )
		              break;
		            HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx(
		              &item,
		              *(_DWORD *)(v6 + 24),
		              v13,
		              0LL);
		          }
		          else if ( Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue(
		                      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&this[1].fields.needClearGPUBuffer,
		                      w,
		                      (GpuClothManager_ClothGroupMeta_Internal *)v17,
		                      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue) )
		          {
		            v6 = *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z;
		            if ( !v6 )
		              break;
		            HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx(
		              (GpuClothManager_ClothGroupMeta_Internal *)v17,
		              *(_DWORD *)(v6 + 24),
		              v13,
		              0LL);
		            v22[0] = v17[0];
		            v22[1] = v17[1];
		            v22[2] = v17[2];
		            v22[3] = v17[3];
		            v22[4] = v17[4];
		            v22[5] = v17[5];
		            v23 = v18;
		            sub_1806B082C(
		              &this[1].fields.needClearGPUBuffer,
		              w,
		              v22,
		              MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::set_Item);
		          }
		          else
		          {
		            HG::Rendering::HGRPLogger::LogError<unsigned int>(
		              (String *)"Cloth group {0} not exist!",
		              clothGroupHash,
		              MethodInfo::HG::Rendering::HGRPLogger::LogError<unsigned int>);
		          }
		        }
		        if ( ++v11 >= item.clothGroupMeta.clothNum )
		          return;
		      }
		LABEL_24:
		      sub_1800D8260(v7, v6);
		    }
		  }
		  else
		  {
		    HG::Rendering::HGRPLogger::LogError<unsigned int>(
		      (String *)"Cloth group ({0}) not exist when unregistering",
		      clothGroupHash,
		      MethodInfo::HG::Rendering::HGRPLogger::LogError<unsigned int>);
		  }
		}
		
		public void UnregisterClothGroup(uint clothGroupHash) {} // 0x0000000189C6C3A8-0x0000000189C6C4A4
		// Void UnregisterClothGroup(UInt32)
		void HG::Rendering::Runtime::GpuClothManager::UnregisterClothGroup(
		        GpuClothManager *this,
		        uint32_t clothGroupHash,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  GpuClothManager_ClothGroupData_Internal v8; // [rsp+20h] [rbp-128h] BYREF
		  __int128 v9; // [rsp+80h] [rbp-C8h]
		  __int128 v10; // [rsp+90h] [rbp-B8h]
		  __int128 v11; // [rsp+A0h] [rbp-A8h]
		  GpuClothManager_ClothGroupData_Internal v12; // [rsp+B0h] [rbp-98h] BYREF
		  __int128 v13; // [rsp+110h] [rbp-38h]
		  __int128 v14; // [rsp+120h] [rbp-28h]
		  __int128 v15; // [rsp+130h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1301, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1301, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (LoginSceneAnimCtrl_EState__Enum)clothGroupHash,
		      0LL);
		  }
		  else
		  {
		    Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
		      &v8,
		      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&this[1].fields.m_characterMesh,
		      clothGroupHash,
		      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
		    v12 = v8;
		    v13 = v9;
		    v14 = v10;
		    v15 = v11;
		    HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::Reset(&v12, 0LL);
		    Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove(
		      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.m_characterMesh,
		      clothGroupHash,
		      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Remove);
		  }
		}
		
		public void SetPlayerCenter(Vector3 playerCenter) {} // 0x00000001831CC1A0-0x00000001831CC1E0
		// Void SetPlayerCenter(Vector3)
		void HG::Rendering::Runtime::GpuClothManager::SetPlayerCenter(
		        GpuClothManager *this,
		        Vector3 *playerCenter,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1303, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1303, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v5);
		    z = playerCenter->z;
		    *(_QWORD *)&v8.x = *(_QWORD *)&playerCenter->x;
		    v8.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, &v8, 0LL);
		  }
		  else
		  {
		    this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField = playerCenter->x;
		    *((_DWORD *)&this[1].fields.renderData.clothConstData + 9) = LODWORD(playerCenter->z);
		  }
		}
		
		public void UpdateCharacterPositions(List<Vector3> characterPositions) {} // 0x000000018323BD90-0x000000018323C3C0
		// Void UpdateCharacterPositions(List`1[UnityEngine.Vector3])
		void HG::Rendering::Runtime::GpuClothManager::UpdateCharacterPositions(
		        GpuClothManager *this,
		        List_1_UnityEngine_Vector3_ *characterPositions,
		        MethodInfo *method)
		{
		  Vector3__Array *items; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *wrapperArray; // rcx
		  Vector3Int *v7; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v8; // r9
		  int32_t v9; // edi
		  __int64 v10; // rbx
		  int32_t v11; // r12d
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  MethodInfo *v13; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v14; // rsi
		  bool v15; // zf
		  float v16; // xmm0_4
		  __int64 v17; // xmm6_8
		  float z; // r14d
		  __m128 v19; // xmm3
		  __m128 v20; // xmm3
		  __m128 v21; // xmm3
		  __m128 v22; // xmm3
		  MethodInfo *v23; // r9
		  Vector4 v24; // xmm6
		  __m128 v25; // xmm3
		  __m128 v26; // xmm3
		  __m128 v27; // xmm3
		  __m128 v28; // xmm3
		  __m128 v29; // xmm3
		  __int64 v30; // r8
		  Vector4 v31; // xmm6
		  float x; // xmm11_4
		  float v33; // xmm9_4
		  float v34; // xmm8_4
		  float v35; // xmm6_4
		  float v36; // xmm7_4
		  float v37; // xmm10_4
		  struct Math__Class *v38; // rcx
		  __m128d v39; // xmm1
		  double v40; // xmm0_8
		  float v41; // xmm6_4
		  struct ILFixDynamicMethodWrapper_2__Class *v42; // r9
		  __int64 v43; // xmm6_8
		  float v44; // r14d
		  __m128 v45; // xmm3
		  __m128 v46; // xmm3
		  __m128 v47; // xmm3
		  __m128 v48; // xmm3
		  Vector4 v49; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v51; // rax
		  Vector4 *v52; // rax
		  ILFixDynamicMethodWrapper_2 *v53; // rax
		  Vector4 *v54; // rax
		  ILFixDynamicMethodWrapper_2 *v55; // rax
		  Vector3 *v56; // rax
		  ILFixDynamicMethodWrapper_2 *v57; // rax
		  ILFixDynamicMethodWrapper_2 *v58; // rax
		  Vector4 *v59; // rax
		  ILFixDynamicMethodWrapper_2 *v60; // rax
		  ILFixDynamicMethodWrapper_2 *v61; // rax
		  ILFixDynamicMethodWrapper_2 *v62; // rax
		  MethodInfo *methoda; // [rsp+28h] [rbp-E0h]
		  __m128 CHARACTER_POSITION_OFFSET; // [rsp+38h] [rbp-D0h] BYREF
		  __m128 v65; // [rsp+48h] [rbp-C0h] BYREF
		  Vector4 v66; // [rsp+58h] [rbp-B0h]
		  Vector4 v67; // [rsp+68h] [rbp-A0h]
		  Vector4 v68; // [rsp+78h] [rbp-90h]
		  Vector3 v69; // [rsp+88h] [rbp-80h] BYREF
		  float v70[4]; // [rsp+98h] [rbp-70h]
		  Vector3 v71; // [rsp+A8h] [rbp-60h] BYREF
		  float v72[4]; // [rsp+B8h] [rbp-50h]
		  float v73[4]; // [rsp+C8h] [rbp-40h]
		  Vector3 v74; // [rsp+D8h] [rbp-30h] BYREF
		  TileAnimationData v75; // [rsp+E8h] [rbp-20h] BYREF
		  Vector4 v76; // [rsp+F8h] [rbp-10h] BYREF
		  Vector4 v77; // [rsp+108h] [rbp+0h] BYREF
		  Vector4 v78; // [rsp+118h] [rbp+10h] BYREF
		  Vector4 v79; // [rsp+128h] [rbp+20h] BYREF
		  Vector4 v80; // [rsp+138h] [rbp+30h] BYREF
		  Vector4 v81; // [rsp+148h] [rbp+40h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1304, 0LL) )
		  {
		    v9 = 0;
		    v10 = 0LL;
		    if ( characterPositions )
		    {
		      while ( 1 )
		      {
		        v11 = 3 * v9;
		        if ( v9 >= characterPositions->fields._size )
		        {
		          HG::Rendering::Runtime::ClothConstData::SetSingleFloat(&this->fields.clothConstData, v11, 3, -1.0, 0LL);
		        }
		        else
		        {
		          TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                     &v75,
		                                     (TileBase *)items,
		                                     v7,
		                                     (ITilemap *)v8,
		                                     methoda);
		          v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor == 0;
		          CHARACTER_POSITION_OFFSET = *(__m128 *)TileAnimationDataNoRef;
		          if ( v15 )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( SLODWORD(wrapperArray->_0.namespaze) <= 1253 )
		            goto LABEL_8;
		          if ( !v14->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v14);
		            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( LODWORD(wrapperArray->_0.namespaze) <= 0x4E5 )
		            goto LABEL_61;
		          if ( *(_QWORD *)&wrapperArray[26]._1.token )
		          {
		            Patch = IFix::WrappersManagerImpl::GetPatch(1253, 0LL);
		            if ( !Patch )
		              break;
		            v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_479(Patch, &this->fields.clothConstData, v11, 3, 0LL);
		            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          else
		          {
		LABEL_8:
		            v16 = *((float *)&(&this->fields.m_characterMesh)[6 * v10] + 1);
		          }
		          if ( v16 < 0.0 )
		          {
		            v41 = CHARACTER_POSITION_OFFSET.m128_f32[3];
		            v37 = CHARACTER_POSITION_OFFSET.m128_f32[2];
		            v33 = CHARACTER_POSITION_OFFSET.m128_f32[1];
		            x = CHARACTER_POSITION_OFFSET.m128_f32[0];
		          }
		          else
		          {
		            if ( (unsigned int)v9 >= characterPositions->fields._size )
		              goto LABEL_119;
		            items = characterPositions->fields._items;
		            if ( !items )
		              break;
		            if ( (unsigned int)v9 >= items->max_length.size )
		              goto LABEL_61;
		            v15 = v14->_1.cctor_finished_or_no_cctor == 0;
		            v17 = *(_QWORD *)&items->vector[v9].x;
		            z = items->vector[v9].z;
		            *(_QWORD *)v70 = v17;
		            if ( v15 )
		            {
		              il2cpp_runtime_class_init_1(v14);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              break;
		            if ( SLODWORD(wrapperArray->_0.namespaze) <= 1305 )
		              goto LABEL_17;
		            if ( !v14->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v14);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              break;
		            if ( LODWORD(wrapperArray->_0.namespaze) <= 0x519 )
		              goto LABEL_61;
		            if ( wrapperArray[27].vtable.Equals.method )
		            {
		              v51 = IFix::WrappersManagerImpl::GetPatch(1305, 0LL);
		              if ( !v51 )
		                break;
		              *(_QWORD *)&v69.x = v17;
		              v69.z = z;
		              v52 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v76, v51, &v69, 0LL);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              v22 = *(__m128 *)v52;
		            }
		            else
		            {
		LABEL_17:
		              v19 = _mm_shuffle_ps((__m128)LODWORD(v70[0]), (__m128)LODWORD(v70[0]), 225);
		              v19.m128_f32[0] = v70[1];
		              v20 = _mm_shuffle_ps(v19, v19, 198);
		              v20.m128_f32[0] = z;
		              v21 = _mm_shuffle_ps(v20, v20, 39);
		              v21.m128_f32[0] = v70[0];
		              v22 = _mm_shuffle_ps(v21, v21, 57);
		            }
		            CHARACTER_POSITION_OFFSET = (__m128)this->fields.CHARACTER_POSITION_OFFSET;
		            v65 = v22;
		            v24 = *UnityEngine::Vector4::op_Addition(&v77, (Vector4 *)&v65, (Vector4 *)&CHARACTER_POSITION_OFFSET, v13);
		            if ( !v14->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v14);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              break;
		            if ( SLODWORD(wrapperArray->_0.namespaze) <= 1251 )
		              goto LABEL_22;
		            if ( !v14->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v14);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              break;
		            if ( LODWORD(wrapperArray->_0.namespaze) <= 0x4E3 )
		              goto LABEL_61;
		            if ( *(_QWORD *)&wrapperArray[26]._1.static_fields_size )
		            {
		              v53 = IFix::WrappersManagerImpl::GetPatch(1251, 0LL);
		              if ( !v53 )
		                break;
		              v54 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_477(
		                      &v78,
		                      v53,
		                      &this->fields.clothConstData,
		                      3 * v9,
		                      0LL);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              v29 = *(__m128 *)v54;
		            }
		            else
		            {
		LABEL_22:
		              v25 = (__m128)*((unsigned int *)&this->fields.clothConstData.colliderInfoArray.FixedElementField + 12 * v10);
		              v26 = _mm_shuffle_ps(v25, v25, 225);
		              v26.m128_f32[0] = *((float *)&this->fields.clothConstData + 12 * v10 + 9);
		              v27 = _mm_shuffle_ps(v26, v26, 198);
		              v27.m128_f32[0] = *(float *)&(&this->fields.m_characterMesh)[6 * v10];
		              v28 = _mm_shuffle_ps(v27, v27, 39);
		              v28.m128_f32[0] = *((float *)&(&this->fields.m_characterMesh)[6 * v10] + 1);
		              v29 = _mm_shuffle_ps(v28, v28, 57);
		            }
		            CHARACTER_POSITION_OFFSET = (__m128)v24;
		            v65 = v29;
		            v31 = *UnityEngine::Vector4::op_Subtraction(
		                     &v79,
		                     (Vector4 *)&CHARACTER_POSITION_OFFSET,
		                     (Vector4 *)&v65,
		                     v23);
		            if ( !v14->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v14);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              break;
		            if ( SLODWORD(wrapperArray->_0.namespaze) <= 1306 )
		              goto LABEL_27;
		            if ( !v14->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v14);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              break;
		            if ( LODWORD(wrapperArray->_0.namespaze) <= 0x51A )
		              goto LABEL_61;
		            if ( wrapperArray[27].vtable.Finalize.methodPtr )
		            {
		              v55 = IFix::WrappersManagerImpl::GetPatch(1306, 0LL);
		              v66.x = v31.x;
		              LODWORD(v33) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 85).m128_u32[0];
		              LODWORD(v37) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 170).m128_u32[0];
		              x = v31.x;
		              LODWORD(v66.w) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 255).m128_u32[0];
		              *(_QWORD *)&v66.y = __PAIR64__(LODWORD(v37), LODWORD(v33));
		              if ( !v55 )
		                break;
		              v65 = (__m128)v66;
		              v56 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v74, v55, (Vector4 *)&v65, 0LL);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              v35 = v56->z;
		              *(_QWORD *)v73 = *(_QWORD *)&v56->x;
		              v34 = v73[0];
		              LODWORD(v36) = _mm_shuffle_ps((__m128)*(unsigned __int64 *)v73, (__m128)*(unsigned __int64 *)v73, 85).m128_u32[0];
		            }
		            else
		            {
		LABEL_27:
		              x = v31.x;
		              LODWORD(v33) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 85).m128_u32[0];
		              v34 = v31.x;
		              LODWORD(v35) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 170).m128_u32[0];
		              v36 = v33;
		              v37 = v35;
		            }
		            v38 = TypeInfo::System::Math;
		            if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v39 = 0LL;
		            v39.m128d_f64[0] = (float)((float)((float)(v36 * v36) + (float)(v34 * v34)) + (float)(v35 * v35));
		            if ( v39.m128d_f64[0] < 0.0 )
		              v40 = sub_1801D32D0(v38, items, v30);
		            else
		              *(_QWORD *)&v40 = *(_OWORD *)&_mm_sqrt_pd(v39);
		            v41 = v40;
		          }
		          if ( !v14->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v14);
		            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( SLODWORD(wrapperArray->_0.namespaze) <= 1250 )
		            goto LABEL_37;
		          if ( !v14->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v14);
		            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( LODWORD(wrapperArray->_0.namespaze) <= 0x4E2 )
		            goto LABEL_61;
		          if ( *(_QWORD *)&wrapperArray[26]._1.element_size )
		          {
		            v57 = IFix::WrappersManagerImpl::GetPatch(1250, 0LL);
		            *(_QWORD *)&v67.x = __PAIR64__(LODWORD(v33), LODWORD(x));
		            *(_QWORD *)&v67.z = __PAIR64__(LODWORD(v41), LODWORD(v37));
		            if ( !v57 )
		              break;
		            v65 = (__m128)v67;
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_476(
		              v57,
		              &this->fields.clothConstData,
		              3 * v9 + 1,
		              (Vector4 *)&v65,
		              0LL);
		          }
		          else
		          {
		LABEL_37:
		            *(&this->fields.m_capsuleRadius + 12 * v10) = x;
		            *(&this->fields.m_capsuleHeight + 12 * v10) = v33;
		            *((float *)&this->fields.needClearGPUBuffer + 12 * v10) = v37;
		            *((float *)&this->fields.needClearGPUBuffer + 12 * v10 + 1) = v41;
		          }
		          if ( (unsigned int)v9 >= characterPositions->fields._size )
		LABEL_119:
		            System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		          items = characterPositions->fields._items;
		          if ( !items )
		            break;
		          if ( (unsigned int)v9 >= items->max_length.size )
		            goto LABEL_61;
		          v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor == 0;
		          v43 = *(_QWORD *)&items->vector[v9].x;
		          v44 = items->vector[v9].z;
		          *(_QWORD *)v72 = v43;
		          if ( v15 )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v42->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( SLODWORD(wrapperArray->_0.namespaze) <= 1305 )
		            goto LABEL_45;
		          if ( !v42->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v42);
		            v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v42->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( LODWORD(wrapperArray->_0.namespaze) <= 0x519 )
		            goto LABEL_61;
		          if ( wrapperArray[27].vtable.Equals.method )
		          {
		            v58 = IFix::WrappersManagerImpl::GetPatch(1305, 0LL);
		            if ( !v58 )
		              break;
		            *(_QWORD *)&v71.x = v43;
		            v71.z = v44;
		            v59 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v80, v58, &v71, 0LL);
		            v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            v48 = *(__m128 *)v59;
		          }
		          else
		          {
		LABEL_45:
		            v45 = _mm_shuffle_ps((__m128)LODWORD(v72[0]), (__m128)LODWORD(v72[0]), 225);
		            v45.m128_f32[0] = v72[1];
		            v46 = _mm_shuffle_ps(v45, v45, 198);
		            v46.m128_f32[0] = v44;
		            v47 = _mm_shuffle_ps(v46, v46, 39);
		            v47.m128_f32[0] = v72[0];
		            v48 = _mm_shuffle_ps(v47, v47, 57);
		          }
		          v65 = (__m128)this->fields.CHARACTER_POSITION_OFFSET;
		          CHARACTER_POSITION_OFFSET = v48;
		          v49 = *UnityEngine::Vector4::op_Addition(
		                   &v81,
		                   (Vector4 *)&CHARACTER_POSITION_OFFSET,
		                   (Vector4 *)&v65,
		                   (MethodInfo *)v42);
		          if ( !v8->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v8);
		            v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v8->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( SLODWORD(wrapperArray->_0.namespaze) <= 1250 )
		            goto LABEL_50;
		          if ( !v8->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v8);
		            v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)v8->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( LODWORD(wrapperArray->_0.namespaze) <= 0x4E2 )
		            goto LABEL_61;
		          if ( *(_QWORD *)&wrapperArray[26]._1.element_size )
		          {
		            v60 = IFix::WrappersManagerImpl::GetPatch(1250, 0LL);
		            v68.x = v49.x;
		            LODWORD(v68.w) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 255).m128_u32[0];
		            LODWORD(v68.y) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 85).m128_u32[0];
		            LODWORD(v68.z) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 170).m128_u32[0];
		            if ( !v60 )
		              break;
		            v65 = (__m128)v68;
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_476(
		              v60,
		              &this->fields.clothConstData,
		              3 * v9,
		              (Vector4 *)&v65,
		              0LL);
		          }
		          else
		          {
		LABEL_50:
		            *((_DWORD *)&this->fields.clothConstData.colliderInfoArray.FixedElementField + 12 * v10) = LODWORD(v49.x);
		            *((_DWORD *)&this->fields.clothConstData + 12 * v10 + 9) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 85).m128_u32[0];
		            LODWORD((&this->fields.m_characterMesh)[6 * v10]) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 170).m128_u32[0];
		            HIDWORD((&this->fields.m_characterMesh)[6 * v10]) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 255).m128_u32[0];
		          }
		          wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          items = (Vector3__Array *)wrapperArray->static_fields->wrapperArray;
		          if ( !items )
		            break;
		          if ( items->max_length.size <= 1252 )
		            goto LABEL_55;
		          if ( !wrapperArray->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(wrapperArray);
		            wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->static_fields->wrapperArray;
		          if ( !wrapperArray )
		            break;
		          if ( LODWORD(wrapperArray->_0.namespaze) <= 0x4E4 )
		LABEL_61:
		            sub_1800D2AB0(wrapperArray, items);
		          if ( *(_QWORD *)&wrapperArray[26]._1.thread_static_fields_offset )
		          {
		            v61 = IFix::WrappersManagerImpl::GetPatch(1252, 0LL);
		            if ( !v61 )
		              break;
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_478(v61, &this->fields.clothConstData, 3 * v9, 3, 1.0, 0LL);
		          }
		          else
		          {
		LABEL_55:
		            HIDWORD((&this->fields.m_characterMesh)[6 * v10]) = 1065353216;
		          }
		        }
		        ++v9;
		        ++v10;
		        if ( v9 >= 4 )
		          return;
		      }
		    }
		LABEL_58:
		    sub_1800D8260(wrapperArray, items);
		  }
		  v62 = IFix::WrappersManagerImpl::GetPatch(1304, 0LL);
		  if ( !v62 )
		    goto LABEL_58;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)v62,
		    (Object *)this,
		    (Object *)characterPositions,
		    0LL);
		}
		
		internal void UpdateTimer() {} // 0x0000000189C6C4A4-0x0000000189C6C568
		// Void UpdateTimer()
		void HG::Rendering::Runtime::GpuClothManager::UpdateTimer(GpuClothManager *this, MethodInfo *method)
		{
		  float v2; // xmm1_4
		  System::MathF *v4; // rcx
		  float v5; // xmm6_4
		  float v6; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1307, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1307, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) = 0;
		    if ( HG::Rendering::Runtime::GpuClothManager::IsClothSkeletonValid(this, 0LL) )
		    {
		      v5 = this[1].fields.CHARACTER_POSITION_OFFSET.y + this[1].fields.CHARACTER_POSITION_OFFSET.x;
		      this[1].fields.CHARACTER_POSITION_OFFSET.y = v5;
		      if ( v5 >= 0.023333333 )
		      {
		        System::MathF::Floor(v4, v2);
		        v6 = fminf(v5 / 0.023333333, 2.0);
		        this[1].fields.CHARACTER_POSITION_OFFSET.w = v6;
		        LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) = 1;
		        this[1].fields.CHARACTER_POSITION_OFFSET.y = v5 - (float)(v6 * 0.023333333);
		      }
		    }
		  }
		}
		
		internal GpuClothRenderData GetRenderData() => default; // 0x0000000189C6B178-0x0000000189C6B4BC
		// GpuClothRenderData GetRenderData()
		GpuClothRenderData *HG::Rendering::Runtime::GpuClothManager::GetRenderData(
		        GpuClothRenderData *__return_ptr retstr,
		        GpuClothManager *this,
		        MethodInfo *method)
		{
		  Vector4 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  Vector4 v11; // xmm1
		  Vector4 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  Vector4 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  Vector4 v24; // xmm1
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  UnsafeList_1_Unity_Mathematics_int4_ *v33; // r9
		  Type *v34; // rdx
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  UnsafeList_1_Unity_Mathematics_int4_ *windNoiseUV; // r9
		  Type *v40; // rdx
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  Type *v43; // rdx
		  PropertyInfo_1 *v44; // r8
		  GpuClothRenderData *v45; // rax
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *p_m_clothHashToRuntimeClothData; // rcx
		  __int64 v47; // rdx
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v48; // xmm1
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v49; // xmm0
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v50; // xmm1
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v51; // xmm0
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v52; // xmm1
		  Vector4 v53; // xmm0
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v54; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  GpuClothRenderData *v58; // rax
		  __int64 v59; // rdx
		  GpuClothRenderData *v60; // rcx
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  __int128 v64; // xmm0
		  __int128 v65; // xmm1
		  Vector4 packedDeltaT; // xmm0
		  Vector4 clothParam1; // xmm1
		  Vector4 v69; // [rsp+20h] [rbp-118h] BYREF
		  Vector4 v70; // [rsp+30h] [rbp-108h]
		  __int128 v71; // [rsp+40h] [rbp-F8h]
		  __int128 v72; // [rsp+50h] [rbp-E8h]
		  __int128 v73; // [rsp+60h] [rbp-D8h]
		  __int128 v74; // [rsp+70h] [rbp-C8h]
		  __int128 v75; // [rsp+80h] [rbp-B8h]
		  Vector4 v76; // [rsp+90h] [rbp-A8h]
		  Vector4 v77; // [rsp+A0h] [rbp-98h]
		  __int128 v78; // [rsp+B0h] [rbp-88h]
		  __int128 v79; // [rsp+C0h] [rbp-78h]
		  __int128 v80; // [rsp+D0h] [rbp-68h]
		  __int128 v81; // [rsp+E0h] [rbp-58h]
		  __int128 v82; // [rsp+F0h] [rbp-48h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1309, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1309, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v57, v56);
		    v58 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_503((GpuClothRenderData *)&v69, Patch, (Object *)this, 0LL);
		    v59 = 2LL;
		    v60 = retstr;
		    do
		    {
		      v61 = *(_OWORD *)&v58->clothConstData.packedDeltaT.z;
		      *(_OWORD *)&v60->isValid = *(_OWORD *)&v58->isValid;
		      v62 = *(_OWORD *)&v58->clothConstData.clothParam1.z;
		      *(_OWORD *)&v60->clothConstData.packedDeltaT.z = v61;
		      v63 = *(_OWORD *)&v58->clothNodeDataBuffer;
		      *(_OWORD *)&v60->clothConstData.clothParam1.z = v62;
		      v64 = *(_OWORD *)&v58->clothBatchMetaDataBuffer;
		      *(_OWORD *)&v60->clothNodeDataBuffer = v63;
		      v65 = *(_OWORD *)&v58->clothSkeletonDataBuffer;
		      *(_OWORD *)&v60->clothBatchMetaDataBuffer = v64;
		      packedDeltaT = v58[1].clothConstData.packedDeltaT;
		      *(_OWORD *)&v60->clothSkeletonDataBuffer = v65;
		      clothParam1 = v58[1].clothConstData.clothParam1;
		      v58 = (GpuClothRenderData *)((char *)v58 + 128);
		      v60[1].clothConstData.packedDeltaT = packedDeltaT;
		      v60 = (GpuClothRenderData *)((char *)v60 + 128);
		      *(Vector4 *)&v60[-1].clothBatchCacheMapBuffer = clothParam1;
		      --v59;
		    }
		    while ( v59 );
		    *(_OWORD *)&v60->isValid = *(_OWORD *)&v58->isValid;
		  }
		  else
		  {
		    LOBYTE(this->fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) = 0;
		    if ( LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) )
		    {
		      HG::Rendering::Runtime::ClothConstData::SetDt(&this->fields.clothConstData, 0.023333333, 0LL);
		      HG::Rendering::Runtime::ClothConstData::SetSkeletonFlipped(
		        &this->fields.clothConstData,
		        *((float *)&this[1].monitor + 1),
		        0LL);
		      HG::Rendering::Runtime::ClothConstData::SetLoopNum(
		        &this->fields.clothConstData,
		        this[1].fields.CHARACTER_POSITION_OFFSET.w,
		        0LL);
		      HG::Rendering::Runtime::ClothConstData::SetClothWindParams(
		        &this->fields.clothConstData,
		        this[1].fields.INVALID_POSITION.x,
		        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                               (__m128)LODWORD(this[1].fields.INVALID_POSITION.z),
		                               (__m128)LODWORD(this[1].fields.INVALID_POSITION.w)),
		        0LL);
		      HIDWORD(this->fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) = LODWORD(this[1].fields.clothConstData.packedDeltaT.x);
		      v5 = this->fields.clothConstData.clothParam1;
		      v69 = this->fields.clothConstData.packedDeltaT;
		      v6 = *(_OWORD *)&this->fields.clothConstData.colliderInfoArray.FixedElementField;
		      v70 = v5;
		      v7 = *(_OWORD *)&this->fields.m_capsuleRadius;
		      v71 = v6;
		      v8 = *(_OWORD *)&this->fields.clothNodeDataBuffer;
		      v72 = v7;
		      v9 = *(_OWORD *)&this->fields.clothBatchMetaDataBuffer;
		      v73 = v8;
		      v10 = *(_OWORD *)&this->fields.clothSkeletonDataBuffer;
		      v74 = v9;
		      v11 = this->fields.renderData.clothConstData.packedDeltaT;
		      v75 = v10;
		      v12 = this->fields.renderData.clothConstData.clothParam1;
		      v76 = v11;
		      v13 = *(_OWORD *)&this->fields.renderData.clothConstData.colliderInfoArray.FixedElementField;
		      v77 = v12;
		      v14 = *(_OWORD *)&this->fields.renderData.clothMetaDataBuffer;
		      v78 = v13;
		      v15 = *(_OWORD *)&this->fields.renderData.clothBatchCacheMapBuffer;
		      v79 = v14;
		      v16 = *(_OWORD *)&this->fields.clearBufferData.shouldClear;
		      v80 = v15;
		      v17 = *(_OWORD *)&this->fields.clearBufferData.eleNum.w;
		      v81 = v16;
		      v82 = v17;
		      v18 = v70;
		      *(Vector4 *)&this->fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel.Index = v69;
		      v19 = v71;
		      *(Vector4 *)&this->fields.m_isForcedRefresh = v18;
		      v20 = v72;
		      *(_OWORD *)&this->fields.m_registedClothGroupData.m_HashMapData.m_AllocatorLabel.Index = v19;
		      v21 = v73;
		      *(_OWORD *)&this->fields.m_activatedGroupHashToGroupMeta.m_HashMapData.m_AllocatorLabel.Index = v20;
		      v22 = v74;
		      *(_OWORD *)&this->fields.m_shouldActivatedGroupHash = v21;
		      v23 = v75;
		      *(_OWORD *)&this->fields.m_activatedGroupHash.m_Data.m_HashMapData.m_AllocatorLabel.Index = v22;
		      v24 = v76;
		      *(_OWORD *)&this->fields.m_lastActivatedGroupHash.m_Data.m_HashMapData.m_AllocatorLabel.Index = v23;
		      *(Vector4 *)&this->fields.m_pendingDeactivateGroupHash = v24;
		      v25 = v78;
		      *(Vector4 *)&this->fields.m_playerCenterXZ.x = v77;
		      v26 = v79;
		      *(_OWORD *)&this->fields.m_groupHashNeedToUpload.m_Data.m_HashMapData.m_AllocatorLabel.Index = v25;
		      v27 = v80;
		      *(_OWORD *)&this->fields.m_groupHashUploaded.m_Data.m_HashMapData.m_AllocatorLabel.Index = v26;
		      v28 = v81;
		      *(_OWORD *)&this->fields.clothGroupUploadData.isValid = v27;
		      v29 = v82;
		      *(_OWORD *)&this->fields.clothGroupUploadData.uploadDataMap.m_DeprecatedAllocator.Index = v28;
		      *(_OWORD *)&this->fields.clothGroupUploadData.clothMetaUploadData.m_DeprecatedAllocator.Index = v29;
		      *(_QWORD *)&this->fields.clothGroupUploadData.clothNodeUploadData.m_DeprecatedAllocator.Index = *(_QWORD *)&this->fields.gameplayDt;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothNodeUploadData.m_DeprecatedAllocator,
		        v30,
		        v31,
		        v32,
		        *(MethodInfo **)&v69.x);
		      v33 = *(UnsafeList_1_Unity_Mathematics_int4_ **)&this->fields.shouldStep;
		      this->fields.clothGroupUploadData.clothBatchMetaUploadData.m_ListData = v33;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothBatchMetaUploadData,
		        v34,
		        v35,
		        (Int32__Array **)v33,
		        *(MethodInfo **)&v69.x);
		      v36 = *(Int32__Array ***)&this->fields.windTime;
		      *(_QWORD *)&this->fields.clothGroupUploadData.clothBatchMetaUploadData.m_DeprecatedAllocator.Index = v36;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothBatchMetaUploadData.m_DeprecatedAllocator,
		        v37,
		        v38,
		        v36,
		        *(MethodInfo **)&v69.x);
		      windNoiseUV = (UnsafeList_1_Unity_Mathematics_int4_ *)this->fields.windNoiseUV;
		      this->fields.clothGroupUploadData.clothBatchCacheMapUploadData.m_ListData = windNoiseUV;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothBatchCacheMapUploadData,
		        v40,
		        v41,
		        (Int32__Array **)windNoiseUV,
		        *(MethodInfo **)&v69.x);
		      v42 = *(Int32__Array ***)&this->fields.m_runtimeClothNum;
		      *(_QWORD *)&this->fields.clothGroupUploadData.clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index = v42;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothBatchCacheMapUploadData.m_DeprecatedAllocator,
		        v43,
		        v44,
		        v42,
		        *(MethodInfo **)&v69.x);
		      LOBYTE(this->fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) = HIDWORD(this->fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) != 0;
		    }
		    v45 = retstr;
		    p_m_clothHashToRuntimeClothData = &this->fields.m_clothHashToRuntimeClothData;
		    v47 = 2LL;
		    do
		    {
		      v48 = p_m_clothHashToRuntimeClothData[1];
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->isValid = *p_m_clothHashToRuntimeClothData;
		      v49 = p_m_clothHashToRuntimeClothData[2];
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->clothConstData.packedDeltaT.z = v48;
		      v50 = p_m_clothHashToRuntimeClothData[3];
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->clothConstData.clothParam1.z = v49;
		      v51 = p_m_clothHashToRuntimeClothData[4];
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->clothNodeDataBuffer = v50;
		      v52 = p_m_clothHashToRuntimeClothData[5];
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->clothBatchMetaDataBuffer = v51;
		      v53 = (Vector4)p_m_clothHashToRuntimeClothData[6];
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->clothSkeletonDataBuffer = v52;
		      v54 = p_m_clothHashToRuntimeClothData[7];
		      p_m_clothHashToRuntimeClothData += 8;
		      v45[1].clothConstData.packedDeltaT = v53;
		      v45 = (GpuClothRenderData *)((char *)v45 + 128);
		      *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45[-1].clothBatchCacheMapBuffer = v54;
		      --v47;
		    }
		    while ( v47 );
		    *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45->isValid = *p_m_clothHashToRuntimeClothData;
		  }
		  return retstr;
		}
		
		internal GpuClothClearBufferData GetClearBufferData() => default; // 0x0000000189C6B070-0x0000000189C6B178
		// GpuClothClearBufferData GetClearBufferData()
		GpuClothClearBufferData *HG::Rendering::Runtime::GpuClothManager::GetClearBufferData(
		        GpuClothClearBufferData *__return_ptr retstr,
		        GpuClothManager *this,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ComputeBuffer *v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  GpuClothManager__Class *windNoiseUV; // r9
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  GpuClothClearBufferData *v19; // rax
		  GpuClothClearBufferData *result; // rax
		  GpuClothClearBufferData v21; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1310, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1310, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v18, v17);
		    v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_504(&v21, Patch, (Object *)this, 0LL);
		    v14 = *(_OWORD *)&v19->eleNum.w;
		    *(_OWORD *)&retstr->shouldClear = *(_OWORD *)&v19->shouldClear;
		    v15 = *(_OWORD *)&v19->clothBatchMetaDataBuffer;
		  }
		  else
		  {
		    LOBYTE(this->fields.clothGroupUploadData.clothMetaDataBuffer) = 0;
		    if ( this->fields.isStreamingMode )
		    {
		      *(__m128i *)((char *)&this->fields.clothGroupUploadData.clothMetaDataBuffer + 4) = _mm_load_si128((const __m128i *)&xmmword_18DC810E0);
		      this->fields.clothGroupUploadData.clothBatchCacheMapBuffer = *(ComputeBuffer **)&this->fields.gameplayDt;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothBatchCacheMapBuffer,
		        v5,
		        v6,
		        v7,
		        *(MethodInfo **)&v21.shouldClear);
		      v8 = *(ComputeBuffer **)&this->fields.windTime;
		      this->fields.clothGroupUploadData.clothSkeletonDataBuffer = v8;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this->fields.clothGroupUploadData.clothSkeletonDataBuffer,
		        v9,
		        v10,
		        (Int32__Array **)v8,
		        *(MethodInfo **)&v21.shouldClear);
		      windNoiseUV = (GpuClothManager__Class *)this->fields.windNoiseUV;
		      this[1].klass = windNoiseUV;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&this[1],
		        v12,
		        v13,
		        (Int32__Array **)windNoiseUV,
		        *(MethodInfo **)&v21.shouldClear);
		      LOBYTE(this->fields.clothGroupUploadData.clothMetaDataBuffer) = 1;
		      this->fields.isStreamingMode = 0;
		    }
		    v14 = *(_OWORD *)&this->fields.clothGroupUploadData.clothBatchMetaDataBuffer;
		    *(_OWORD *)&retstr->shouldClear = *(_OWORD *)&this->fields.clothGroupUploadData.clothMetaDataBuffer;
		    v15 = *(_OWORD *)&this->fields.clothGroupUploadData.clothSkeletonDataBuffer;
		  }
		  result = retstr;
		  *(_OWORD *)&retstr->eleNum.w = v14;
		  *(_OWORD *)&retstr->clothBatchMetaDataBuffer = v15;
		  return result;
		}
		
		internal GpuClothGroupUploadData GetUploadData() => default; // 0x0000000189C6B568-0x0000000189C6BE70
		// GpuClothGroupUploadData GetUploadData()
		// Hidden C++ exception states: #wind=2 #try_helpers=1
		GpuClothGroupUploadData *HG::Rendering::Runtime::GpuClothManager::GetUploadData(
		        GpuClothGroupUploadData *__return_ptr retstr,
		        GpuClothManager *this,
		        MethodInfo *method)
		{
		  GpuClothManager *v3; // rbx
		  GpuClothGroupUploadData *v4; // rsi
		  GpuClothManager *v5; // r14
		  int v6; // r12d
		  bool v7; // r15
		  uint32_t Current; // eax
		  uint32_t v9; // r13d
		  AllocatorManager_AllocatorHandle m_DeprecatedAllocator; // r12d
		  int32_t TotalClothNodeNum; // r13d
		  int32_t TotalClothBatchNum; // r13d
		  int32_t TotalClothBatchCacheMapNum; // r13d
		  int i; // r12d
		  uint32_t v15; // r13d
		  uint32_t v16; // eax
		  int v17; // ecx
		  unsigned __int64 v18; // r9
		  signed __int64 v19; // rtt
		  unsigned __int64 v20; // r9
		  signed __int64 v21; // rtt
		  unsigned __int64 v22; // r9
		  signed __int64 v23; // rtt
		  unsigned __int64 v24; // r9
		  signed __int64 v25; // rtt
		  unsigned __int64 v26; // r9
		  signed __int64 v27; // rtt
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ m_clothHashToRuntimeClothData; // xmm0
		  __int128 v29; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  GpuClothGroupUploadData *v33; // rax
		  NativeParallelHashSet_1_T_Enumerator_System_UInt32_ v35; // [rsp+30h] [rbp-208h] BYREF
		  uint32_t v36; // [rsp+50h] [rbp-1E8h]
		  Il2CppException *ex; // [rsp+58h] [rbp-1E0h]
		  NativeParallelHashSet_1_T_Enumerator_System_UInt32_ *v38; // [rsp+60h] [rbp-1D8h]
		  NativeParallelHashSet_1_T_Enumerator_System_UInt32_ v39; // [rsp+68h] [rbp-1D0h] BYREF
		  ClothGroupUploadDataMap value; // [rsp+80h] [rbp-1B8h] BYREF
		  GpuClothManager *v41; // [rsp+B0h] [rbp-188h]
		  GpuClothManager_RuntimeClothData_Internal v42; // [rsp+B8h] [rbp-180h] BYREF
		  __int64 v43; // [rsp+C8h] [rbp-170h]
		  GpuClothManager_RuntimeClothData_Internal v44; // [rsp+E0h] [rbp-158h] BYREF
		  Il2CppExceptionWrapper *v45; // [rsp+F8h] [rbp-140h] BYREF
		  GpuClothGroupUploadData item; // [rsp+100h] [rbp-138h] BYREF
		  GpuClothManager_ClothGroupData_Internal v47; // [rsp+180h] [rbp-B8h] BYREF
		  uint8_t *v48; // [rsp+1E0h] [rbp-58h]
		  int32_t v49; // [rsp+1E8h] [rbp-50h]
		  uint8_t *v50; // [rsp+1F0h] [rbp-48h]
		  int32_t v51; // [rsp+1F8h] [rbp-40h]
		  uint8_t *v52; // [rsp+200h] [rbp-38h]
		  int32_t v53; // [rsp+208h] [rbp-30h]
		  int v56; // [rsp+258h] [rbp+20h]
		
		  v3 = this;
		  v4 = retstr;
		  v5 = this;
		  v41 = this;
		  sub_18033B9D0(&item, 0LL, 100LL);
		  sub_18033B9D0(&v47, 0LL, 144LL);
		  memset(&value, 0, sizeof(value));
		  if ( IFix::WrappersManagerImpl::IsPatched(1311, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1311, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v32, v31);
		    v33 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_505(&item, Patch, (Object *)v3, 0LL);
		    *(_OWORD *)&v4->isValid = *(_OWORD *)&v33->isValid;
		    *(_OWORD *)&v4->uploadDataMap.m_DeprecatedAllocator.Index = *(_OWORD *)&v33->uploadDataMap.m_DeprecatedAllocator.Index;
		    *(_OWORD *)&v4->clothMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33->clothMetaUploadData.m_DeprecatedAllocator.Index;
		    *(_OWORD *)&v4->clothNodeUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33->clothNodeUploadData.m_DeprecatedAllocator.Index;
		    *(_OWORD *)&v4->clothBatchMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33->clothBatchMetaUploadData.m_DeprecatedAllocator.Index;
		    *(_OWORD *)&v4->clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33->clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index;
		    m_clothHashToRuntimeClothData = *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v33->clothNodeDataBuffer;
		    v29 = *(_OWORD *)&v33->clothBatchCacheMapBuffer;
		  }
		  else
		  {
		    HG::Rendering::Runtime::GpuClothGroupUploadData::Reset(
		      (GpuClothGroupUploadData *)&v3[1].fields.clearBufferData,
		      0LL);
		    if ( LOBYTE(v3[1].fields.CHARACTER_POSITION_OFFSET.z)
		      && (LOBYTE(v3[1].fields.renderData.clothSkeletonDataBuffer)
		       || Unity::Collections::NativeParallelHashSet<Unity::Mathematics::int4>::Count(
		            (NativeParallelHashSet_1_Unity_Mathematics_int4_ *)&v3[1].fields.renderData.clothNodeDataBuffer,
		            MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Count)) )
		    {
		      v6 = 0;
		      v56 = 0;
		      Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
		        (NativeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothBatchMetaDataBuffer,
		        MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
		      Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashSet<unsigned int>::GetEnumerator(
		        (UnsafeParallelHashSet_1_T_Enumerator_System_UInt32_ *)&v35,
		        (UnsafeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothNodeDataBuffer,
		        MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::GetEnumerator);
		      v39 = v35;
		      ex = 0LL;
		      v38 = &v39;
		      v7 = 1;
		      while ( Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext(
		                &v39,
		                MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext) )
		      {
		        Current = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
		                    &v39,
		                    MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
		        v9 = Current;
		        v36 = Current;
		        if ( v6 >= 4 )
		          break;
		        if ( Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue(
		               (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&v3[1].fields.needClearGPUBuffer,
		               Current,
		               (GpuClothManager_ClothGroupMeta_Internal *)&item,
		               MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue)
		          && Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::TryGetValue(
		               (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&v3[1].fields.m_characterMesh,
		               v9,
		               &v47,
		               MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::TryGetValue) )
		        {
		          m_DeprecatedAllocator = item.clothBatchCacheMapUploadData.m_DeprecatedAllocator;
		          memset(&value, 0, sizeof(value));
		          TotalClothNodeNum = HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothNodeNum((ClothGroupMeta *)&item, 0LL);
		          value.clothNodeDataMap.x = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
		                                       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.clearBufferData.clothBatchCacheMapBuffer,
		                                       MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::get_Length);
		          value.clothNodeDataMap.y = value.clothNodeDataMap.x + TotalClothNodeNum;
		          value.clothNodeDataMap.z = *(_DWORD *)&m_DeprecatedAllocator << 9;
		          value.clothNodeDataMap.w = (*(_DWORD *)&m_DeprecatedAllocator << 9) + TotalClothNodeNum;
		          if ( value.clothNodeDataMap.x + TotalClothNodeNum > 680 )
		            break;
		          *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.clearBufferData.clothBatchCacheMapBuffer;
		          HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothNodeData>(
		            (NativeList_1_HG_Rendering_Runtime_ClothNodeData_ *)&v35,
		            v48,
		            v49,
		            0,
		            TotalClothNodeNum,
		            MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothNodeData>);
		          TotalClothBatchNum = HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchNum(
		                                 (ClothGroupMeta *)&item,
		                                 0LL);
		          value.clothBatchMetaDataMap.x = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
		                                            (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.gameplayDt,
		                                            MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::get_Length);
		          value.clothBatchMetaDataMap.y = (TotalClothBatchNum + 1) / 2 + value.clothBatchMetaDataMap.x;
		          value.clothBatchMetaDataMap.z = 4 * *(_DWORD *)&m_DeprecatedAllocator;
		          value.clothBatchMetaDataMap.w = 4 * *(_DWORD *)&m_DeprecatedAllocator + (TotalClothBatchNum + 1) / 2;
		          *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.gameplayDt;
		          HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>(
		            (NativeList_1_Unity_Mathematics_int4_ *)&v35,
		            v50,
		            v51,
		            0,
		            (TotalClothBatchNum + 1) / 2,
		            MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>);
		          TotalClothBatchCacheMapNum = HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchCacheMapNum(
		                                         (ClothGroupMeta *)&item,
		                                         0LL);
		          value.clothBatchCacheDataMap.x = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
		                                             (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.windTime,
		                                             MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::get_Length);
		          value.clothBatchCacheDataMap.y = (TotalClothBatchCacheMapNum + 1) / 2 + value.clothBatchCacheDataMap.x;
		          value.clothBatchCacheDataMap.z = *(_DWORD *)&m_DeprecatedAllocator << 6;
		          value.clothBatchCacheDataMap.w = (*(_DWORD *)&m_DeprecatedAllocator << 6)
		                                         + (TotalClothBatchCacheMapNum + 1) / 2;
		          if ( value.clothBatchCacheDataMap.y > 128 )
		            break;
		          *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.windTime;
		          HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>(
		            (NativeList_1_Unity_Mathematics_int4_ *)&v35,
		            v52,
		            v53,
		            0,
		            (TotalClothBatchCacheMapNum + 1) / 2,
		            MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>);
		          for ( i = 0; i < *(int *)&item.isValid; ++i )
		          {
		            v15 = *((_DWORD *)&item.uploadDataMap.m_DeprecatedAllocator + i);
		            Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::get_Item(
		              &v42,
		              (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v3[1].fields.clothConstData.packedDeltaT.z,
		              v15,
		              MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::get_Item);
		            v43 = *(_QWORD *)&v42.isDataReady;
		            LOBYTE(v43) = 1;
		            *(_QWORD *)&v44.isDataReady = v43;
		            v44.isSingleSkeleton = v42.isSingleSkeleton;
		            Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::set_Item(
		              (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v3[1].fields.clothConstData.packedDeltaT.z,
		              v15,
		              &v44,
		              MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::set_Item);
		          }
		          Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Add(
		            (NativeList_1_HG_Rendering_Runtime_ClothGroupUploadDataMap_ *)&v3[1].fields.clearBufferData.eleNum.y,
		            &value,
		            MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Add);
		          v6 = ++v56;
		          v9 = v36;
		        }
		        Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
		          (NativeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothBatchMetaDataBuffer,
		          v9,
		          MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
		      }
		      v35.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v3[1].fields.renderData.clothBatchMetaDataBuffer;
		      *(_QWORD *)&v35.m_Enumerator.m_Index = 0xFFFFFFFFLL;
		      *(_QWORD *)&v35.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
		      *(_OWORD *)&v39.m_Enumerator.m_Buffer = *(_OWORD *)&v35.m_Enumerator.m_Buffer;
		      *(_QWORD *)&v39.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
		      ex = 0LL;
		      v38 = &v39;
		      try
		      {
		        while ( Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext(
		                  &v39,
		                  MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext) )
		        {
		          v16 = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
		                  &v39,
		                  MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
		          Unity::Collections::NativeParallelHashSet<unsigned int>::Remove(
		            (NativeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothNodeDataBuffer,
		            v16,
		            MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Remove);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v45 )
		      {
		        ex = v45->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v7 = 1;
		        v3 = this;
		        v4 = retstr;
		        v5 = v41;
		      }
		      if ( LOBYTE(v3[1].fields.renderData.clothSkeletonDataBuffer) )
		      {
		        *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.clearBufferData.clothNodeDataBuffer;
		        HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>(
		          (NativeList_1_HG_Rendering_Runtime_ClothMetaData_ *)&v35,
		          *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&v3[1].fields.clothConstData.clothParam1.z,
		          MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>);
		        LOBYTE(v3[1].fields.renderData.clothSkeletonDataBuffer) = 0;
		      }
		      *(_QWORD *)&v5[1].fields.m_runtimeClothNum = *(_QWORD *)&v3->fields.shouldStep;
		      v17 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v18 = (((unsigned __int64)&v5[1].fields.m_runtimeClothNum >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v18 + 36190]);
		        do
		          v19 = qword_18F0BCBA0[v18 + 36190];
		        while ( v19 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v18 + 36190],
		                         v19 | (1LL << (((unsigned __int64)&v5[1].fields.m_runtimeClothNum >> 12) & 0x3F)),
		                         v19) );
		        v17 = dword_18F35FD08;
		      }
		      v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer = *(UnsafeParallelHashMapData **)&v3->fields.gameplayDt;
		      if ( v17 )
		      {
		        v20 = (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v20 + 36190]);
		        do
		          v21 = qword_18F0BCBA0[v20 + 36190];
		        while ( v21 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v20 + 36190],
		                         v21 | (1LL << (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData >> 12) & 0x3F)),
		                         v21) );
		        v17 = dword_18F35FD08;
		      }
		      *(_QWORD *)&v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel.Index = *(_QWORD *)&v3->fields.windTime;
		      if ( v17 )
		      {
		        v22 = (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v22 + 36190]);
		        do
		          v23 = qword_18F0BCBA0[v22 + 36190];
		        while ( v23 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v22 + 36190],
		                         v23 | (1LL << (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel >> 12) & 0x3F)),
		                         v23) );
		        v17 = dword_18F35FD08;
		      }
		      v5[1].fields.m_runtimeClothMetaArray = (DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ *)v3->fields.windNoiseUV;
		      if ( v17 )
		      {
		        v24 = (((unsigned __int64)&v5[1].fields.m_runtimeClothMetaArray >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v24 + 36190]);
		        do
		          v25 = qword_18F0BCBA0[v24 + 36190];
		        while ( v25 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v24 + 36190],
		                         v25 | (1LL << (((unsigned __int64)&v5[1].fields.m_runtimeClothMetaArray >> 12) & 0x3F)),
		                         v25) );
		        v17 = dword_18F35FD08;
		      }
		      *(_QWORD *)&v5[1].fields.m_isForcedRefresh = *(_QWORD *)&v3->fields.m_runtimeClothNum;
		      if ( v17 )
		      {
		        v26 = (((unsigned __int64)&v5[1].fields.m_isForcedRefresh >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v26 + 36190]);
		        do
		          v27 = qword_18F0BCBA0[v26 + 36190];
		        while ( v27 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v26 + 36190],
		                         v27 | (1LL << (((unsigned __int64)&v5[1].fields.m_isForcedRefresh >> 12) & 0x3F)),
		                         v27) );
		      }
		      if ( Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
		             (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.clearBufferData.clothNodeDataBuffer,
		             MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::get_Length) <= 0 )
		        v7 = v56 > 0;
		      v5[1].fields.clearBufferData.shouldClear = v7;
		    }
		    *(_OWORD *)&v4->isValid = *(_OWORD *)&v3[1].fields.clearBufferData.shouldClear;
		    *(_OWORD *)&v4->uploadDataMap.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.clearBufferData.eleNum.w;
		    *(_OWORD *)&v4->clothMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.clearBufferData.clothBatchMetaDataBuffer;
		    *(_OWORD *)&v4->clothNodeUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.isStreamingMode;
		    *(_OWORD *)&v4->clothBatchMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.shouldStep;
		    *(_OWORD *)&v4->clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.windNoiseUV.x;
		    m_clothHashToRuntimeClothData = v3[1].fields.m_clothHashToRuntimeClothData;
		    v29 = *(_OWORD *)&v3[1].fields.m_runtimeClothMetaArray;
		  }
		  *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v4->clothNodeDataBuffer = m_clothHashToRuntimeClothData;
		  *(_OWORD *)&v4->clothBatchCacheMapBuffer = v29;
		  return v4;
		}
		
		internal ComputeBuffer GetSkeletonBuffer() => default; // 0x0000000189C6B4BC-0x0000000189C6B568
		// ComputeBuffer GetSkeletonBuffer()
		ComputeBuffer *HG::Rendering::Runtime::GpuClothManager::GetSkeletonBuffer(GpuClothManager *this, MethodInfo *method)
		{
		  ComputeBuffer *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ComputeBuffer *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1312, 0LL) )
		  {
		    if ( *(_QWORD *)&this->fields.m_runtimeClothNum
		      && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this->fields.m_runtimeClothNum, 0LL) )
		    {
		      return *(ComputeBuffer **)&this->fields.m_runtimeClothNum;
		    }
		    v3 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		    v6 = v3;
		    if ( v3 )
		    {
		      UnityEngine::ComputeBuffer::ComputeBuffer(v3, 1, 96, 0LL);
		      *(_QWORD *)&this->fields.m_runtimeClothNum = v6;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_runtimeClothNum, v7, v8, v9, v12);
		      return *(ComputeBuffer **)&this->fields.m_runtimeClothNum;
		    }
		LABEL_8:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1312, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_506(Patch, (Object *)this, 0LL);
		}
		
		internal void FlipSkeletonFlag() {} // 0x0000000189C6B004-0x0000000189C6B070
		// Void FlipSkeletonFlag()
		void HG::Rendering::Runtime::GpuClothManager::FlipSkeletonFlag(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1313, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1313, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) )
		  {
		    *((float *)&this[1].monitor + 1) = 1.0 - *((float *)&this[1].monitor + 1);
		  }
		}
		
		internal bool IsClothSkeletonValid() => default; // 0x0000000189C6BED8-0x0000000189C6BF28
		// Boolean IsClothSkeletonValid()
		bool HG::Rendering::Runtime::GpuClothManager::IsClothSkeletonValid(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1308, 0LL) )
		    return (bool)this[1].monitor;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1308, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool IsClothSkeletonFlipped() => default; // 0x0000000189C6BE70-0x0000000189C6BED8
		// Boolean IsClothSkeletonFlipped()
		bool HG::Rendering::Runtime::GpuClothManager::IsClothSkeletonFlipped(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1314, 0LL) )
		    return *((float *)&this[1].monitor + 1) != 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1314, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool ShouldStep() => default; // 0x0000000189C6C358-0x0000000189C6C3A8
		// Boolean ShouldStep()
		bool HG::Rendering::Runtime::GpuClothManager::ShouldStep(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1315, 0LL) )
		    return LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1315, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void Dispose() {} // 0x0000000189C6AEB8-0x0000000189C6B004
		// Void Dispose()
		void HG::Rendering::Runtime::GpuClothManager::Dispose(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1316, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1316, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::GpuClothManager::ResetStreamingResource(this, 0LL);
		    HG::Rendering::Runtime::GpuClothManager::ResetGpuResource(this, 0LL);
		    HG::Rendering::Runtime::GpuClothManager::ResetCpuData(this, 0LL);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>(
		      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>(
		      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.m_characterMesh,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>(
		      (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.needClearGPUBuffer,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
		      (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.clothBatchCacheMapBuffer,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
		      (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
		      (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData.clothNodeDataBuffer,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
		      (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData.clothBatchMetaDataBuffer,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothGroupUploadDataMap>(
		      (NativeList_1_HG_Rendering_Runtime_ClothGroupUploadDataMap_ *)&this[1].fields.clearBufferData.eleNum.y,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothGroupUploadDataMap>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothMetaData>(
		      (NativeList_1_HG_Rendering_Runtime_ClothMetaData_ *)&this[1].fields.clearBufferData.clothNodeDataBuffer,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothMetaData>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothNodeData>(
		      (NativeList_1_HG_Rendering_Runtime_ClothNodeData_ *)&this[1].fields.clearBufferData.clothBatchCacheMapBuffer,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothNodeData>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>(
		      (NativeList_1_Unity_Mathematics_int4_ *)&this[1].fields.gameplayDt,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>);
		    HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>(
		      (NativeList_1_Unity_Mathematics_int4_ *)&this[1].fields.windTime,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>);
		  }
		}
		
		internal void ResetCpuData() {} // 0x0000000189C6C050-0x0000000189C6C0A0
		// Void ResetCpuData()
		void HG::Rendering::Runtime::GpuClothManager::ResetCpuData(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1294, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1294, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HIDWORD(this[1].monitor) = 0;
		  }
		}
		
		internal void ResetStreamingResource() {} // 0x0000000189C6C1E0-0x0000000189C6C358
		// Void ResetStreamingResource()
		void HG::Rendering::Runtime::GpuClothManager::ResetStreamingResource(GpuClothManager *this, MethodInfo *method)
		{
		  ComputeBuffer *clothBatchMetaDataBuffer; // rcx
		  ComputeBuffer *clothMetaDataBuffer; // rdx
		  __int64 v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1295, 0LL) )
		  {
		    this[1].fields.clothConstData.packedDeltaT.x = 0.0;
		    this[1].fields.clothConstData.packedDeltaT.y = 0.0;
		    Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int2,unsigned char>::Clear(
		      (NativeParallelHashMap_2_Unity_Mathematics_int2_System_Byte_ *)&this[1].fields.clothConstData.packedDeltaT.z,
		      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Clear);
		    Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int2,unsigned char>::Clear(
		      (NativeParallelHashMap_2_Unity_Mathematics_int2_System_Byte_ *)&this[1].fields.needClearGPUBuffer,
		      MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Clear);
		    clothBatchMetaDataBuffer = 0LL;
		    do
		    {
		      clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
		      if ( !clothMetaDataBuffer )
		        goto LABEL_13;
		      if ( (unsigned int)clothBatchMetaDataBuffer >= LODWORD(clothMetaDataBuffer[1].klass) )
		        sub_1800D2AB0(clothBatchMetaDataBuffer, clothMetaDataBuffer);
		      v5 = (int)clothBatchMetaDataBuffer;
		      clothBatchMetaDataBuffer = (ComputeBuffer *)(unsigned int)((_DWORD)clothBatchMetaDataBuffer + 1);
		      *((_DWORD *)&clothMetaDataBuffer[1].monitor + v5) = 1;
		    }
		    while ( (int)clothBatchMetaDataBuffer < 50 );
		    clothBatchMetaDataBuffer = *(ComputeBuffer **)&this[1].fields.clothConstData.clothParam1.z;
		    if ( clothBatchMetaDataBuffer )
		    {
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)clothBatchMetaDataBuffer,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::Clear);
		      LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 0;
		      Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int2,unsigned char>::Clear(
		        (NativeParallelHashMap_2_Unity_Mathematics_int2_System_Byte_ *)&this[1].fields.m_characterMesh,
		        MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Clear);
		      clothBatchMetaDataBuffer = this[1].fields.clothBatchMetaDataBuffer;
		      if ( clothBatchMetaDataBuffer )
		      {
		        Beyond::IndexedHashSet<unsigned int>::Clear(
		          (IndexedHashSet_1_System_UInt32_ *)clothBatchMetaDataBuffer,
		          MethodInfo::Beyond::IndexedHashSet<unsigned int>::Clear);
		        Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
		          (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.clothBatchCacheMapBuffer,
		          MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
		        Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
		          (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData,
		          MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
		        clothBatchMetaDataBuffer = *(ComputeBuffer **)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
		        if ( clothBatchMetaDataBuffer )
		        {
		          UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)clothBatchMetaDataBuffer,
		            MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
		          clothBatchMetaDataBuffer = *(ComputeBuffer **)&this[1].fields.renderData.clothConstData.clothParam1.x;
		          if ( clothBatchMetaDataBuffer )
		          {
		            UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)clothBatchMetaDataBuffer,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
		            this[1].fields.renderData.clothConstData.clothParam1.z = 0.0;
		            this[1].fields.renderData.clothConstData.clothParam1.w = 0.0;
		            this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField = 0.0;
		            *((_DWORD *)&this[1].fields.renderData.clothConstData + 9) = 0;
		            return;
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(clothBatchMetaDataBuffer, clothMetaDataBuffer);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1295, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void ResetGpuResource() {} // 0x0000000189C6C0A0-0x0000000189C6C1E0
		// Void ResetGpuResource()
		void HG::Rendering::Runtime::GpuClothManager::ResetGpuResource(GpuClothManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  ComputeBuffer *windNoiseUV; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1317, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1317, 0LL);
		    if ( !Patch )
		      goto LABEL_23;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( *(_QWORD *)&this->fields.gameplayDt
		      && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this->fields.gameplayDt, 0LL) )
		    {
		      windNoiseUV = *(ComputeBuffer **)&this->fields.gameplayDt;
		      if ( !windNoiseUV )
		        goto LABEL_23;
		      UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
		    }
		    if ( *(_QWORD *)&this->fields.shouldStep
		      && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this->fields.shouldStep, 0LL) )
		    {
		      windNoiseUV = *(ComputeBuffer **)&this->fields.shouldStep;
		      if ( !windNoiseUV )
		        goto LABEL_23;
		      UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
		    }
		    if ( *(_QWORD *)&this->fields.windTime
		      && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this->fields.windTime, 0LL) )
		    {
		      windNoiseUV = *(ComputeBuffer **)&this->fields.windTime;
		      if ( !windNoiseUV )
		        goto LABEL_23;
		      UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
		    }
		    if ( *(_QWORD *)&this->fields.windNoiseUV
		      && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this->fields.windNoiseUV, 0LL) )
		    {
		      windNoiseUV = (ComputeBuffer *)this->fields.windNoiseUV;
		      if ( !windNoiseUV )
		        goto LABEL_23;
		      UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
		    }
		    if ( *(_QWORD *)&this->fields.m_runtimeClothNum
		      && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this->fields.m_runtimeClothNum, 0LL) )
		    {
		      windNoiseUV = *(ComputeBuffer **)&this->fields.m_runtimeClothNum;
		      if ( windNoiseUV )
		      {
		        UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
		        return;
		      }
		LABEL_23:
		      sub_1800D8260(windNoiseUV, v3);
		    }
		  }
		}
		
		private void _SetCharacterProxyMesh(Mesh characterProxyMesh) {} // 0x00000001847A53C0-0x00000001847A5500
		// Void _SetCharacterProxyMesh(Mesh)
		void HG::Rendering::Runtime::GpuClothManager::_SetCharacterProxyMesh(
		        GpuClothManager *this,
		        Mesh *characterProxyMesh,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __m128 *bounds; // rax
		  float v11; // xmm6_4
		  float v12; // xmm1_4
		  float v13; // xmm6_4
		  float v14; // xmm7_4
		  float v15; // xmm7_4
		  int32_t v16; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v18; // [rsp+20h] [rbp-58h] BYREF
		  Bounds v19; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1282, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1282, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)characterProxyMesh,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v9, v8);
		  }
		  this->fields.clearBufferData.clothBatchMetaDataBuffer = (ComputeBuffer *)characterProxyMesh;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.clearBufferData.clothBatchMetaDataBuffer,
		    v5,
		    v6,
		    v7,
		    *(MethodInfo **)&v18.x);
		  if ( !characterProxyMesh )
		    goto LABEL_10;
		  bounds = (__m128 *)UnityEngine::Mesh::get_bounds(&v19, characterProxyMesh, 0LL);
		  v11 = _mm_shuffle_ps(*bounds, *bounds, 255).m128_f32[0];
		  v12 = _mm_shuffle_ps((__m128)bounds[1].m128_u64[0], (__m128)bounds[1].m128_u64[0], 85).m128_f32[0];
		  *(_QWORD *)&v19.m_Extents.y = bounds[1].m128_u64[0];
		  if ( v11 <= v12 )
		    v11 = v12;
		  v13 = v11 * 0.75;
		  *(float *)&this->fields.clearBufferData.clothBatchCacheMapBuffer = v13;
		  v14 = 0.1;
		  if ( (float)(v19.m_Extents.y - v13) >= 0.1 )
		    v14 = v19.m_Extents.y - v13;
		  v15 = v14 * 0.69999999;
		  v16 = 0;
		  *((float *)&this->fields.clearBufferData.clothBatchCacheMapBuffer + 1) = v15;
		  do
		  {
		    v18.x = v13;
		    v18.y = v15;
		    *(_QWORD *)&v18.z = 0LL;
		    HG::Rendering::Runtime::ClothConstData::SetVec4(&this->fields.clothConstData, v16 + 2, &v18, 0LL);
		    *(Vector4 *)&v19.m_Center.x = this->fields.INVALID_POSITION;
		    HG::Rendering::Runtime::ClothConstData::SetVec4(&this->fields.clothConstData, v16, (Vector4 *)&v19, 0LL);
		    v16 += 3;
		  }
		  while ( v16 < 12 );
		}
		
		private void _UpdateRuntimeBuffer(int cellIdx, ref ClothGroupData_Internal clothGroupData) {} // 0x0000000189C6D304-0x0000000189C6D408
		// Void _UpdateRuntimeBuffer(Int32, GpuClothManager+ClothGroupData_Internal ByRef)
		void HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeBuffer(
		        GpuClothManager *this,
		        int32_t cellIdx,
		        GpuClothManager_ClothGroupData_Internal *clothGroupData,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ *v8; // rcx
		  __int64 v9; // rax
		  int v10; // ebp
		  int v11; // eax
		  int32_t v12; // edi
		  ClothMetaData *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int4 v15; // [rsp+30h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1290, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1290, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_495(Patch, (Object *)this, cellIdx, clothGroupData, 0LL);
		  }
		  else
		  {
		    v9 = *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z;
		    if ( !v9 )
		      goto LABEL_9;
		    v10 = *(_DWORD *)(v9 + 24);
		    HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>(
		      *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z,
		      clothGroupData->groupClothBatchCacheBytes,
		      clothGroupData->groupClothBatchCacheBytesSize,
		      MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>);
		    v15.x = cellIdx << 9;
		    v11 = 8 * cellIdx;
		    v15.z = cellIdx << 7;
		    v12 = 0;
		    v15.y = v11;
		    if ( clothGroupData->clothGroupMeta.clothNum > 0 )
		    {
		      v15.w = clothGroupData->clothGroupMeta.clothGroupHash;
		      while ( 1 )
		      {
		        v8 = *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z;
		        if ( !v8 )
		          break;
		        Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item(
		                 v8,
		                 v12 + v10,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item);
		        ++v12;
		        Item->groupOffset = v15;
		        if ( v12 >= clothGroupData->clothGroupMeta.clothNum )
		          goto LABEL_7;
		      }
		LABEL_9:
		      sub_1800D8260(v8, v7);
		    }
		LABEL_7:
		    LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) = 1;
		  }
		}
		
		private unsafe int _UpdateRuntimeGroupMeta(ref ClothGroupMeta clothGroupMeta, byte* clothMetaBytes) => default; // 0x0000000189C6D408-0x0000000189C6D614
		// Int32 _UpdateRuntimeGroupMeta(ClothGroupMeta ByRef, Byte*)
		int32_t HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeGroupMeta(
		        GpuClothManager *this,
		        ClothGroupMeta *clothGroupMeta,
		        uint8_t *clothMetaBytes,
		        MethodInfo *method)
		{
		  GpuClothManager *v5; // rdi
		  ComputeBuffer *clothMetaDataBuffer; // rcx
		  __int64 v7; // rdx
		  int32_t v8; // r12d
		  int32_t v9; // ebx
		  int32_t v10; // r8d
		  int v11; // eax
		  int32_t v12; // r13d
		  int v13; // r14d
		  NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *p_z; // rdi
		  ClothGroupMeta *v15; // r15
		  float v16; // xmm1_4
		  uint32_t FixedElementField; // edx
		  __int128 v18; // xmm0
		  int v19; // eax
		  __int128 v20; // xmm1
		  __int128 v21; // xmm2
		  __int128 v22; // xmm3
		  __int128 v23; // xmm4
		  __int128 v24; // xmm5
		  __int64 v25; // r8
		  int v26; // ecx
		  __int64 clothGroupHash; // rdx
		  __int64 v29; // [rsp+28h] [rbp-E0h]
		  GpuClothManager_RuntimeClothData_Internal v30; // [rsp+38h] [rbp-D0h] BYREF
		  __int128 v31; // [rsp+48h] [rbp-C0h] BYREF
		  __int128 v32; // [rsp+58h] [rbp-B0h]
		  __int128 v33; // [rsp+68h] [rbp-A0h]
		  __int128 v34; // [rsp+78h] [rbp-90h]
		  __int128 v35; // [rsp+88h] [rbp-80h]
		  __int128 v36; // [rsp+98h] [rbp-70h] BYREF
		  int v37; // [rsp+A8h] [rbp-60h]
		  _BYTE v38[80]; // [rsp+B8h] [rbp-50h] BYREF
		  __int128 v39; // [rsp+108h] [rbp+0h]
		  int v40; // [rsp+118h] [rbp+10h]
		
		  v5 = this;
		  clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
		  v7 = 0xFFFFFFFFLL;
		  v8 = -1;
		  v9 = 0;
		  v10 = 0;
		  if ( !clothMetaDataBuffer )
		    goto LABEL_20;
		  while ( v10 < SLODWORD(clothMetaDataBuffer[1].klass) )
		  {
		    if ( (unsigned int)v10 >= LODWORD(clothMetaDataBuffer[1].klass) )
		      sub_1800D2AB0(clothMetaDataBuffer, 0xFFFFFFFFLL);
		    if ( *((_DWORD *)&clothMetaDataBuffer[1].monitor + v10) != -1 )
		    {
		      v8 = v10;
		      *((_DWORD *)&clothMetaDataBuffer[1].monitor + v10) = -1;
		      break;
		    }
		    ++v10;
		  }
		  v11 = clothGroupMeta->clothNum + LODWORD(v5[1].fields.clothConstData.packedDeltaT.x);
		  v12 = 0;
		  ++LODWORD(v5[1].fields.clothConstData.packedDeltaT.y);
		  v13 = v8 << 9;
		  LODWORD(v5[1].fields.clothConstData.packedDeltaT.x) = v11;
		  if ( clothGroupMeta->clothNum > 0 )
		  {
		    p_z = (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v5[1].fields.clothConstData.packedDeltaT.z;
		    v15 = clothGroupMeta + 1;
		    do
		    {
		      LODWORD(v29) = 0;
		      if ( v15->clothNum <= 256 )
		        v16 = 0.0;
		      else
		        v16 = 1.0;
		      FixedElementField = v15[-1].clothHashes.FixedElementField;
		      *((float *)&v29 + 1) = (float)v13;
		      *(_QWORD *)&v30.isDataReady = v29;
		      v30.isSingleSkeleton = v16;
		      Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Add(
		        p_z,
		        FixedElementField,
		        &v30,
		        MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Add);
		      v13 += v15->clothNum;
		      ++v12;
		      v15 = (ClothGroupMeta *)((char *)v15 + 4);
		    }
		    while ( v12 < clothGroupMeta->clothNum );
		    v5 = this;
		  }
		  sub_18033B9D0(v38, 0LL, 100LL);
		  v18 = *(_OWORD *)&clothGroupMeta->clothNum;
		  v19 = v40;
		  v20 = *(_OWORD *)&clothGroupMeta->clothHashes.FixedElementField;
		  LODWORD(v39) = v8;
		  v21 = *(_OWORD *)&clothGroupMeta[1].clothNum;
		  v37 = v40;
		  v22 = *(_OWORD *)&clothGroupMeta[1].clothHashes.FixedElementField;
		  v23 = *(_OWORD *)&clothGroupMeta[2].clothNum;
		  v24 = v39;
		  v31 = v18;
		  v32 = v20;
		  v33 = v21;
		  v34 = v22;
		  v35 = v23;
		  v36 = v39;
		  if ( clothGroupMeta->clothNum > 0 )
		  {
		    v25 = *(_QWORD *)&v5[1].fields.clothConstData.clothParam1.z;
		    v7 = (__int64)&v36 + 4;
		    if ( v25 )
		    {
		      do
		      {
		        v26 = v9 + *(_DWORD *)(v25 + 24);
		        ++v9;
		        *(_DWORD *)v7 = v26;
		        v7 += 4LL;
		      }
		      while ( v9 < clothGroupMeta->clothNum );
		      v19 = v37;
		      v24 = v36;
		      v23 = v35;
		      v22 = v34;
		      v21 = v33;
		      v20 = v32;
		      v18 = v31;
		      goto LABEL_19;
		    }
		LABEL_20:
		    sub_1800D8260(clothMetaDataBuffer, v7);
		  }
		LABEL_19:
		  clothGroupHash = clothGroupMeta->clothGroupHash;
		  v31 = v18;
		  v32 = v20;
		  v33 = v21;
		  v34 = v22;
		  v35 = v23;
		  v36 = v24;
		  v37 = v19;
		  sub_1806B0710(
		    &v5[1].fields.needClearGPUBuffer,
		    clothGroupHash,
		    &v31,
		    MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Add);
		  return v8;
		}
		
		private void _InitStreamingGpuBuffer() {} // 0x0000000189C6C8B0-0x0000000189C6C984
		// Void _InitStreamingGpuBuffer()
		void HG::Rendering::Runtime::GpuClothManager::_InitStreamingGpuBuffer(GpuClothManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1296, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1296, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
		      (ComputeBuffer **)&this->fields.shouldStep,
		      176,
		      200,
		      0LL);
		    HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
		      (ComputeBuffer **)&this->fields.gameplayDt,
		      192,
		      25600,
		      0LL);
		    HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer((ComputeBuffer **)&this->fields.windTime, 16, 200, 0LL);
		    HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
		      (ComputeBuffer **)&this->fields.windNoiseUV,
		      16,
		      3200,
		      0LL);
		    HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
		      (ComputeBuffer **)&this->fields.m_runtimeClothNum,
		      96,
		      25600,
		      0LL);
		    this->fields.isStreamingMode = 1;
		  }
		}
		
		public static void PipelineUpdateV2(Transform centerTransform) {} // 0x0000000183C070E0-0x0000000183C072B0
		// Void PipelineUpdateV2(Transform)
		void HG::Rendering::Runtime::GpuClothManager::PipelineUpdateV2(Transform *centerTransform, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGEnvironmentPhase *s_interpolatedPhase; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  void (__fastcall *v8)(__int64 *); // rax
		  struct Object_1__Class *v9; // rcx
		  void (__fastcall *v10)(Transform *, unsigned __int64 *); // rax
		  unsigned __int64 v11; // xmm0_8
		  int v12; // eax
		  void (__fastcall *v13)(unsigned __int64 *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rax
		  __int64 v16; // rax
		  __int64 v17; // rax
		  unsigned __int64 v18; // [rsp+20h] [rbp-38h] BYREF
		  int v19; // [rsp+28h] [rbp-30h]
		  __int64 v20; // [rsp+30h] [rbp-28h] BYREF
		  float z; // [rsp+38h] [rbp-20h]
		  unsigned __int64 v22; // [rsp+40h] [rbp-18h] BYREF
		  int v23; // [rsp+48h] [rbp-10h]
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->max_length.size > 678 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x2A6 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[14].rgctx_data )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(678, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		          (ILFixDynamicMethodWrapper_39 *)Patch,
		          (Object *)centerTransform,
		          0LL);
		        return;
		      }
		    }
		LABEL_26:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  s_interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
		  if ( !s_interpolatedPhase )
		    sub_1800D8260(v7, v6);
		  v20 = *(_QWORD *)&s_interpolatedPhase->fields.windConfig.direction.x;
		  z = s_interpolatedPhase->fields.windConfig.direction.z;
		  v8 = (void (__fastcall *)(__int64 *))qword_18F3707A0;
		  if ( !qword_18F3707A0 )
		  {
		    v8 = (void (__fastcall *)(__int64 *))il2cpp_resolve_icall_1(
		                                           "UnityEngine.HyperGryph.HGGpuClothManagerV2::SetWindDirection_Injected(UnityEngine.Vector3&)");
		    if ( !v8 )
		    {
		      v15 = sub_1802EE1B8("UnityEngine.HyperGryph.HGGpuClothManagerV2::SetWindDirection_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v15, 0LL);
		    }
		    qword_18F3707A0 = (__int64)v8;
		  }
		  v8(&v20);
		  v9 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v9 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !centerTransform )
		    goto LABEL_16;
		  if ( !v9->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v9);
		  if ( centerTransform->fields._._.m_CachedPtr )
		  {
		    v18 = 0LL;
		    v19 = 0;
		    v10 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v10 = (void (__fastcall *)(Transform *, unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v10 )
		      {
		        v16 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v16, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v10;
		    }
		    v10(centerTransform, &v18);
		    v11 = v18;
		    v12 = v19;
		  }
		  else
		  {
		LABEL_16:
		    v12 = _mm_cvtsi128_si32((__m128i)0LL);
		    v11 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  }
		  v23 = v12;
		  v13 = (void (__fastcall *)(unsigned __int64 *))qword_18F3707A8;
		  v22 = v11;
		  if ( !qword_18F3707A8 )
		  {
		    v13 = (void (__fastcall *)(unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                     "UnityEngine.HyperGryph.HGGpuClothManagerV2::SetPlayerCenter_Injecte"
		                                                     "d(UnityEngine.Vector3&)");
		    if ( !v13 )
		    {
		      v17 = sub_1802EE1B8("UnityEngine.HyperGryph.HGGpuClothManagerV2::SetPlayerCenter_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v17, 0LL);
		    }
		    qword_18F3707A8 = (__int64)v13;
		  }
		  v13(&v22);
		}
		
	}
}
