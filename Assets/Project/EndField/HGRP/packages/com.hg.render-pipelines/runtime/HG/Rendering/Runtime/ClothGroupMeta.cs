using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct ClothGroupMeta // TypeDefIndex: 37572
	{
		// Fields
		public const int MAX_CLOTH_PER_GROUP = 4; // Metadata: 0x02302F3F
		public const int MAX_CLOTH_NODE_PER_GROUP = 512; // Metadata: 0x02302F40
		public const int MAX_CLOTH_BATCH_PER_GROUP = 8; // Metadata: 0x02302F42
		public const int MAX_CLOTH_CACHE_ENTRY_PER_GROUP = 128; // Metadata: 0x02302F43
		public const int MAX_CLOTH_SKELETON_PER_GROUP = 512; // Metadata: 0x02302F45
		public int clothNum; // 0x00
		public uint clothGroupHash; // 0x04
		public Vector2 groupWorldPosXZ; // 0x08
		public unsafe fixed /* 0x00000000-0x00000000 */ uint clothHashes[0]; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ int clothNodeNum[0]; // 0x20
		public unsafe fixed /* 0x00000000-0x00000000 */ int clothBatchNum[0]; // 0x30
		public unsafe fixed /* 0x00000000-0x00000000 */ int clothBatchCacheNum[0]; // 0x40
	
		// Properties
		public static int MAX_CLOTH_META_SIZE_PER_GROUP { get => default; } // 0x0000000189C6806C-0x0000000189C680B0 
		// Int32 get_MAX_CLOTH_META_SIZE_PER_GROUP()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_META_SIZE_PER_GROUP(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1267, 0LL) )
		    return 704;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1267, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static int MAX_CLOTH_NODE_SIZE_PER_GROUP { get => default; } // 0x0000000189C680B0-0x0000000189C680F4 
		// Int32 get_MAX_CLOTH_NODE_SIZE_PER_GROUP()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_NODE_SIZE_PER_GROUP(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1268, 0LL) )
		    return 98304;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1268, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static int MAX_CLOTH_BATCH_META_SIZE_PER_GROUP { get => default; } // 0x0000000189C67FE4-0x0000000189C68028 
		// Int32 get_MAX_CLOTH_BATCH_META_SIZE_PER_GROUP()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_BATCH_META_SIZE_PER_GROUP(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1269, 0LL) )
		    return 64;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1269, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static int MAX_CLOTH_CACHE_ENTRY_SIZE_PER_GROUP { get => default; } // 0x0000000189C68028-0x0000000189C6806C 
		// Int32 get_MAX_CLOTH_CACHE_ENTRY_SIZE_PER_GROUP()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_CACHE_ENTRY_SIZE_PER_GROUP(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1270, 0LL) )
		    return 1024;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1270, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static int MAX_CLOTH_SKELETON_SIZE_PER_GROUP { get => default; } // 0x0000000189C680F4-0x0000000189C68138 
		// Int32 get_MAX_CLOTH_SKELETON_SIZE_PER_GROUP()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_SKELETON_SIZE_PER_GROUP(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1271, 0LL) )
		    return 49152;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1271, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
	
		// Methods
		public void CopyFromClothGroupMeta(ClothGroupMeta other) {} // 0x0000000189C67A80-0x0000000189C67B8C
		// Void CopyFromClothGroupMeta(ClothGroupMeta)
		void HG::Rendering::Runtime::ClothGroupMeta::CopyFromClothGroupMeta(
		        ClothGroupMeta *this,
		        ClothGroupMeta *other,
		        MethodInfo *method)
		{
		  __m128 v5; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  ClothGroupMeta v13; // [rsp+20h] [rbp-50h] BYREF
		  __int128 v14; // [rsp+40h] [rbp-30h]
		  __int128 v15; // [rsp+50h] [rbp-20h]
		  __int128 v16; // [rsp+60h] [rbp-10h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1272, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1272, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v9 = *(_OWORD *)&other->clothHashes.FixedElementField;
		    *(_OWORD *)&v13.clothNum = *(_OWORD *)&other->clothNum;
		    v10 = *(_OWORD *)&other[1].clothNum;
		    *(_OWORD *)&v13.clothHashes.FixedElementField = v9;
		    v11 = *(_OWORD *)&other[1].clothHashes.FixedElementField;
		    v14 = v10;
		    v12 = *(_OWORD *)&other[2].clothNum;
		    v15 = v11;
		    v16 = v12;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_488(Patch, this, &v13, 0LL);
		  }
		  else
		  {
		    v5 = *(__m128 *)&other->clothNum;
		    this->clothNum = _mm_cvtsi128_si32(*(__m128i *)&other->clothNum);
		    LODWORD(this->groupWorldPosXZ.y) = _mm_shuffle_ps(v5, v5, 255).m128_u32[0];
		    LODWORD(this->groupWorldPosXZ.x) = _mm_shuffle_ps(v5, v5, 170).m128_u32[0];
		    this->clothGroupHash = v5.m128_u32[1];
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		      (Void *)&this->clothHashes,
		      (Void *)&other->clothHashes,
		      16LL,
		      0LL);
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)&this[1], (Void *)&other[1], 16LL, 0LL);
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		      (Void *)&this[1].clothHashes,
		      (Void *)&other[1].clothHashes,
		      16LL,
		      0LL);
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)&this[2], (Void *)&other[2], 16LL, 0LL);
		  }
		}
		
		public void SetClothHash(int idx, uint hash) {} // 0x0000000189C67E78-0x0000000189C67EE4
		// Void SetClothHash(Int32, UInt32)
		void HG::Rendering::Runtime::ClothGroupMeta::SetClothHash(
		        ClothGroupMeta *this,
		        int32_t idx,
		        uint32_t hash,
		        MethodInfo *method)
		{
		  __int64 v4; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v4 = idx;
		  if ( IFix::WrappersManagerImpl::IsPatched(1273, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1273, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_490(Patch, this, v4, hash, 0LL);
		  }
		  else
		  {
		    *(&this->clothHashes.FixedElementField + v4) = hash;
		  }
		}
		
		public void SetClothNodeNum(int idx, int num) {} // 0x0000000189C67EE4-0x0000000189C67F50
		// Void SetClothNodeNum(Int32, Int32)
		void HG::Rendering::Runtime::ClothGroupMeta::SetClothNodeNum(
		        ClothGroupMeta *this,
		        int32_t idx,
		        int32_t num,
		        MethodInfo *method)
		{
		  __int64 v4; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v4 = idx;
		  if ( IFix::WrappersManagerImpl::IsPatched(1274, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1274, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_490(Patch, this, v4, num, 0LL);
		  }
		  else
		  {
		    *(&this[1].clothNum + v4) = num;
		  }
		}
		
		public void SetClothBatchNum(int idx, int num) {} // 0x0000000189C67E0C-0x0000000189C67E78
		// Void SetClothBatchNum(Int32, Int32)
		void HG::Rendering::Runtime::ClothGroupMeta::SetClothBatchNum(
		        ClothGroupMeta *this,
		        int32_t idx,
		        int32_t num,
		        MethodInfo *method)
		{
		  __int64 v4; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v4 = idx;
		  if ( IFix::WrappersManagerImpl::IsPatched(1275, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1275, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_490(Patch, this, v4, num, 0LL);
		  }
		  else
		  {
		    *(&this[1].clothHashes.FixedElementField + v4) = num;
		  }
		}
		
		public void SetClothBatchCacheNum(int idx, int num) {} // 0x0000000189C67DA0-0x0000000189C67E0C
		// Void SetClothBatchCacheNum(Int32, Int32)
		void HG::Rendering::Runtime::ClothGroupMeta::SetClothBatchCacheNum(
		        ClothGroupMeta *this,
		        int32_t idx,
		        int32_t num,
		        MethodInfo *method)
		{
		  __int64 v4; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v4 = idx;
		  if ( IFix::WrappersManagerImpl::IsPatched(1276, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1276, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_490(Patch, this, v4, num, 0LL);
		  }
		  else
		  {
		    *(&this[2].clothNum + v4) = num;
		  }
		}
		
		public int GetTotalClothNodeNum() => default; // 0x0000000189C67C64-0x0000000189C67CD0
		// Int32 GetTotalClothNodeNum()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothNodeNum(ClothGroupMeta *this, MethodInfo *method)
		{
		  int32_t v3; // ebx
		  __int64 clothNum; // rdx
		  ClothGroupMeta *v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1277, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1277, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_491(Patch, this, 0LL);
		  }
		  else
		  {
		    clothNum = this->clothNum;
		    if ( clothNum > 0 )
		    {
		      v5 = this + 1;
		      do
		      {
		        v3 += v5->clothNum;
		        v5 = (ClothGroupMeta *)((char *)v5 + 4);
		        --clothNum;
		      }
		      while ( clothNum );
		    }
		    return v3;
		  }
		}
		
		public int GetTotalClothBatchNum() => default; // 0x0000000189C67BF8-0x0000000189C67C64
		// Int32 GetTotalClothBatchNum()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchNum(ClothGroupMeta *this, MethodInfo *method)
		{
		  int32_t v3; // ebx
		  __int64 clothNum; // rdx
		  ClothGroupMeta_clothHashes_e_FixedBuffer *p_clothHashes; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1278, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1278, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_491(Patch, this, 0LL);
		  }
		  else
		  {
		    clothNum = this->clothNum;
		    if ( clothNum > 0 )
		    {
		      p_clothHashes = &this[1].clothHashes;
		      do
		      {
		        v3 += p_clothHashes->FixedElementField;
		        ++p_clothHashes;
		        --clothNum;
		      }
		      while ( clothNum );
		    }
		    return v3;
		  }
		}
		
		public int GetTotalClothBatchCacheMapNum() => default; // 0x0000000189C67B8C-0x0000000189C67BF8
		// Int32 GetTotalClothBatchCacheMapNum()
		int32_t HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchCacheMapNum(ClothGroupMeta *this, MethodInfo *method)
		{
		  int32_t v3; // ebx
		  __int64 clothNum; // rdx
		  ClothGroupMeta *v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1279, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1279, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_491(Patch, this, 0LL);
		  }
		  else
		  {
		    clothNum = this->clothNum;
		    if ( clothNum > 0 )
		    {
		      v5 = this + 2;
		      do
		      {
		        v3 += v5->clothNum;
		        v5 = (ClothGroupMeta *)((char *)v5 + 4);
		        --clothNum;
		      }
		      while ( clothNum );
		    }
		    return v3;
		  }
		}
		
		public bool Validate() => default; // 0x0000000189C67F50-0x0000000189C67FE4
		// Boolean Validate()
		bool HG::Rendering::Runtime::ClothGroupMeta::Validate(ClothGroupMeta *this, MethodInfo *method)
		{
		  int v3; // ebx
		  __int64 clothNum; // r8
		  int v5; // edx
		  int v6; // ecx
		  ClothGroupMeta_clothHashes_e_FixedBuffer *p_clothHashes; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1280, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1280, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_492(Patch, this, 0LL);
		  }
		  else
		  {
		    if ( this->clothNum > 4 )
		      return 0;
		    clothNum = this->clothNum;
		    v5 = 0;
		    v6 = 0;
		    if ( clothNum <= 0 )
		      return 1;
		    p_clothHashes = &this[1].clothHashes;
		    do
		    {
		      v3 += p_clothHashes[-4].FixedElementField;
		      v5 += p_clothHashes->FixedElementField;
		      v6 += p_clothHashes[4].FixedElementField;
		      ++p_clothHashes;
		      --clothNum;
		    }
		    while ( clothNum );
		    return v3 <= 512 && v5 <= 8 && v6 <= 128;
		  }
		}
		
	}
}
