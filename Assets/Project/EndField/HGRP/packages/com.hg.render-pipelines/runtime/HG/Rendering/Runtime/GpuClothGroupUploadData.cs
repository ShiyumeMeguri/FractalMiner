using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct GpuClothGroupUploadData
	{
		public bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::Runtime::GpuClothGroupUploadData::IsValid(GpuClothGroupUploadData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1127, 0LL) )
			//     return this.isValid;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1127, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_415(Patch, this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::GpuClothGroupUploadData::Reset(GpuClothGroupUploadData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919CE2 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Clear);
			//     byte_18D919CE2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1128, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1128, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_416(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     this.isValid = 0;
			//     sub_180313F98(
			//       &this.uploadDataMap,
			//       MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Clear);
			//     sub_180313F98(
			//       &this.clothMetaUploadData,
			//       MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::Clear);
			//     sub_180313F98(
			//       &this.clothNodeUploadData,
			//       MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::Clear);
			//     sub_180313F98(
			//       &this.clothBatchMetaUploadData,
			//       MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::Clear);
			//     sub_180313F98(
			//       &this.clothBatchCacheMapUploadData,
			//       MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::Clear);
			//   }
			// }
			// 
		}

		public const int MAX_NODE_NUM_PER_CBUFFER = 340;

		public const int MAX_NODE_NUM_PER_UPLOAD = 680;

		public const int MAX_CACHE_ENTRY_BUDGET = 128;

		public const int MAX_UPLOAD_GROUP_NUM = 4;

		public bool isValid;

		public NativeList<ClothGroupUploadDataMap> uploadDataMap;

		public NativeList<ClothMetaData> clothMetaUploadData;

		public NativeList<ClothNodeData> clothNodeUploadData;

		public NativeList<int4> clothBatchMetaUploadData;

		public NativeList<int4> clothBatchCacheMapUploadData;

		public ComputeBuffer clothMetaDataBuffer;

		public ComputeBuffer clothNodeDataBuffer;

		public ComputeBuffer clothBatchMetaDataBuffer;

		public ComputeBuffer clothBatchCacheMapBuffer;

		public ComputeBuffer clothSkeletonDataBuffer;
	}
}
