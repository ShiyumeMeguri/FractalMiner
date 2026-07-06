using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
	public struct ClothGroupMeta
	{
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00002608 File Offset: 0x00000808
		public static int MAX_CLOTH_META_SIZE_PER_GROUP
		{
			get
			{
				// // Int32 get_MAX_CLOTH_META_SIZE_PER_GROUP()
				// int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_META_SIZE_PER_GROUP(MethodInfo *method)
				// {
				//   return 704;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00002608 File Offset: 0x00000808
		public static int MAX_CLOTH_NODE_SIZE_PER_GROUP
		{
			get
			{
				// // Int32 get_MAX_CLOTH_NODE_SIZE_PER_GROUP()
				// int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_NODE_SIZE_PER_GROUP(MethodInfo *method)
				// {
				//   return 98304;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00002608 File Offset: 0x00000808
		public static int MAX_CLOTH_BATCH_META_SIZE_PER_GROUP
		{
			get
			{
				// // UInt32 get_capacity()
				// uint32_t UnityEngine::Rendering::BitArray64::get_capacity(BitArray64 *this, MethodInfo *method)
				// {
				//   return 64;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00002608 File Offset: 0x00000808
		public static int MAX_CLOTH_CACHE_ENTRY_SIZE_PER_GROUP
		{
			get
			{
				// // Int32 get_MAX_CLOTH_CACHE_ENTRY_SIZE_PER_GROUP()
				// int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_CACHE_ENTRY_SIZE_PER_GROUP(MethodInfo *method)
				// {
				//   return 1024;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00002608 File Offset: 0x00000808
		public static int MAX_CLOTH_SKELETON_SIZE_PER_GROUP
		{
			get
			{
				// // Int32 get_MAX_CLOTH_SKELETON_SIZE_PER_GROUP()
				// int32_t HG::Rendering::Runtime::ClothGroupMeta::get_MAX_CLOTH_SKELETON_SIZE_PER_GROUP(MethodInfo *method)
				// {
				//   return 49152;
				// }
				// 
				return 0;
			}
		}

		public void CopyFromClothGroupMeta(ClothGroupMeta other)
		{
			// // Void CopyFromClothGroupMeta(ClothGroupMeta)
			// void HG::Rendering::Runtime::ClothGroupMeta::CopyFromClothGroupMeta(
			//         ClothGroupMeta *this,
			//         ClothGroupMeta *other,
			//         MethodInfo *method)
			// {
			//   __m128 v5; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   ClothGroupMeta v13; // [rsp+20h] [rbp-50h] BYREF
			//   __int128 v14; // [rsp+40h] [rbp-30h]
			//   __int128 v15; // [rsp+50h] [rbp-20h]
			//   __int128 v16; // [rsp+60h] [rbp-10h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1131, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1131, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v9 = *(_OWORD *)&other.clothHashes.FixedElementField;
			//     *(_OWORD *)&v13.clothNum = *(_OWORD *)&other.clothNum;
			//     v10 = *(_OWORD *)&other[1].clothNum;
			//     *(_OWORD *)&v13.clothHashes.FixedElementField = v9;
			//     v11 = *(_OWORD *)&other[1].clothHashes.FixedElementField;
			//     v14 = v10;
			//     v12 = *(_OWORD *)&other[2].clothNum;
			//     v15 = v11;
			//     v16 = v12;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_419(Patch, this, &v13, 0LL);
			//   }
			//   else
			//   {
			//     v5 = *(__m128 *)&other.clothNum;
			//     this.clothNum = _mm_cvtsi128_si32(*(__m128i *)&other.clothNum);
			//     LODWORD(this.groupWorldPosXZ.y) = _mm_shuffle_ps(v5, v5, 255).m128_u32[0];
			//     LODWORD(this.groupWorldPosXZ.x) = _mm_shuffle_ps(v5, v5, 170).m128_u32[0];
			//     this.clothGroupHash = v5.m128_u32[1];
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//       (Void *)&this.clothHashes,
			//       (Void *)&other.clothHashes,
			//       16LL,
			//       0LL);
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)&this[1], (Void *)&other[1], 16LL, 0LL);
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//       (Void *)&this[1].clothHashes,
			//       (Void *)&other[1].clothHashes,
			//       16LL,
			//       0LL);
			//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)&this[2], (Void *)&other[2], 16LL, 0LL);
			//   }
			// }
			// 
		}

		public void SetClothHash(int idx, uint hash)
		{
			// // Void SetClothHash(Int32, UInt32)
			// void HG::Rendering::Runtime::ClothGroupMeta::SetClothHash(
			//         ClothGroupMeta *this,
			//         int32_t idx,
			//         uint32_t hash,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v4 = idx;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1132, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1132, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_420(Patch, this, v4, hash, 0LL);
			//   }
			//   else
			//   {
			//     *(&this.clothHashes.FixedElementField + v4) = hash;
			//   }
			// }
			// 
		}

		public void SetClothNodeNum(int idx, int num)
		{
			// // Void SetClothNodeNum(Int32, Int32)
			// void HG::Rendering::Runtime::ClothGroupMeta::SetClothNodeNum(
			//         ClothGroupMeta *this,
			//         int32_t idx,
			//         int32_t num,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v4 = idx;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1133, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1133, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_421(Patch, this, v4, num, 0LL);
			//   }
			//   else
			//   {
			//     *(&this[1].clothNum + v4) = num;
			//   }
			// }
			// 
		}

		public void SetClothBatchNum(int idx, int num)
		{
			// // Void SetClothBatchNum(Int32, Int32)
			// void HG::Rendering::Runtime::ClothGroupMeta::SetClothBatchNum(
			//         ClothGroupMeta *this,
			//         int32_t idx,
			//         int32_t num,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v4 = idx;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1134, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1134, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_421(Patch, this, v4, num, 0LL);
			//   }
			//   else
			//   {
			//     *(&this[1].clothHashes.FixedElementField + v4) = num;
			//   }
			// }
			// 
		}

		public void SetClothBatchCacheNum(int idx, int num)
		{
			// // Void SetClothBatchCacheNum(Int32, Int32)
			// void HG::Rendering::Runtime::ClothGroupMeta::SetClothBatchCacheNum(
			//         ClothGroupMeta *this,
			//         int32_t idx,
			//         int32_t num,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v4 = idx;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1135, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1135, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_421(Patch, this, v4, num, 0LL);
			//   }
			//   else
			//   {
			//     *(&this[2].clothNum + v4) = num;
			//   }
			// }
			// 
		}

		public int GetTotalClothNodeNum()
		{
			// // Int32 GetTotalClothNodeNum()
			// int32_t HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothNodeNum(ClothGroupMeta *this, MethodInfo *method)
			// {
			//   int32_t v3; // ebx
			//   __int64 clothNum; // rdx
			//   ClothGroupMeta *v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1136, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1136, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_422(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     clothNum = this.clothNum;
			//     if ( clothNum > 0 )
			//     {
			//       v5 = this + 1;
			//       do
			//       {
			//         v3 += v5.clothNum;
			//         v5 = (ClothGroupMeta *)((char *)v5 + 4);
			//         --clothNum;
			//       }
			//       while ( clothNum );
			//     }
			//     return v3;
			//   }
			// }
			// 
			return 0;
		}

		public int GetTotalClothBatchNum()
		{
			// // Int32 GetTotalClothBatchNum()
			// int32_t HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchNum(ClothGroupMeta *this, MethodInfo *method)
			// {
			//   int32_t v3; // ebx
			//   __int64 clothNum; // rdx
			//   ClothGroupMeta_clothHashes_e_FixedBuffer *p_clothHashes; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1137, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1137, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_422(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     clothNum = this.clothNum;
			//     if ( clothNum > 0 )
			//     {
			//       p_clothHashes = &this[1].clothHashes;
			//       do
			//       {
			//         v3 += p_clothHashes.FixedElementField;
			//         ++p_clothHashes;
			//         --clothNum;
			//       }
			//       while ( clothNum );
			//     }
			//     return v3;
			//   }
			// }
			// 
			return 0;
		}

		public int GetTotalClothBatchCacheMapNum()
		{
			// // Int32 GetTotalClothBatchCacheMapNum()
			// int32_t HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchCacheMapNum(ClothGroupMeta *this, MethodInfo *method)
			// {
			//   int32_t v3; // ebx
			//   __int64 clothNum; // rdx
			//   ClothGroupMeta *v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1138, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1138, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_422(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     clothNum = this.clothNum;
			//     if ( clothNum > 0 )
			//     {
			//       v5 = this + 2;
			//       do
			//       {
			//         v3 += v5.clothNum;
			//         v5 = (ClothGroupMeta *)((char *)v5 + 4);
			//         --clothNum;
			//       }
			//       while ( clothNum );
			//     }
			//     return v3;
			//   }
			// }
			// 
			return 0;
		}

		public bool Validate()
		{
			// // Boolean Validate()
			// bool HG::Rendering::Runtime::ClothGroupMeta::Validate(ClothGroupMeta *this, MethodInfo *method)
			// {
			//   int v3; // ebx
			//   __int64 clothNum; // r8
			//   int v5; // edx
			//   int v6; // ecx
			//   ClothGroupMeta_clothHashes_e_FixedBuffer *p_clothHashes; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1139, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1139, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_423(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.clothNum > 4 )
			//       return 0;
			//     clothNum = this.clothNum;
			//     v5 = 0;
			//     v6 = 0;
			//     if ( clothNum <= 0 )
			//       return 1;
			//     p_clothHashes = &this[1].clothHashes;
			//     do
			//     {
			//       v3 += p_clothHashes[-4].FixedElementField;
			//       v5 += p_clothHashes.FixedElementField;
			//       v6 += p_clothHashes[4].FixedElementField;
			//       ++p_clothHashes;
			//       --clothNum;
			//     }
			//     while ( clothNum );
			//     return v3 <= 512 && v5 <= 8 && v6 <= 128;
			//   }
			// }
			// 
			return default(bool);
		}

		public const int MAX_CLOTH_PER_GROUP = 4;

		public const int MAX_CLOTH_NODE_PER_GROUP = 512;

		public const int MAX_CLOTH_BATCH_PER_GROUP = 8;

		public const int MAX_CLOTH_CACHE_ENTRY_PER_GROUP = 128;

		public const int MAX_CLOTH_SKELETON_PER_GROUP = 512;

		public int clothNum;

		public uint clothGroupHash;

		public Vector2 groupWorldPosXZ;

		[FixedBuffer(typeof(uint), 4)]
		public ClothGroupMeta.<clothHashes>e__FixedBuffer clothHashes;

		[FixedBuffer(typeof(int), 4)]
		public ClothGroupMeta.<clothNodeNum>e__FixedBuffer clothNodeNum;

		[FixedBuffer(typeof(int), 4)]
		public ClothGroupMeta.<clothBatchNum>e__FixedBuffer clothBatchNum;

		[FixedBuffer(typeof(int), 4)]
		public ClothGroupMeta.<clothBatchCacheNum>e__FixedBuffer clothBatchCacheNum;

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct <clothHashes>e__FixedBuffer
		{
			public uint FixedElementField;
		}

		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct <clothNodeNum>e__FixedBuffer
		{
			public int FixedElementField;
		}

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct <clothBatchNum>e__FixedBuffer
		{
			public int FixedElementField;
		}

		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct <clothBatchCacheNum>e__FixedBuffer
		{
			public int FixedElementField;
		}
	}
}
