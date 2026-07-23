using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct GpuClothGroupUploadData // TypeDefIndex: 37565
	{
		// Fields
		public const int MAX_NODE_NUM_PER_CBUFFER = 340; // Metadata: 0x02302F38
		public const int MAX_NODE_NUM_PER_UPLOAD = 680; // Metadata: 0x02302F3A
		public const int MAX_CACHE_ENTRY_BUDGET = 128; // Metadata: 0x02302F3C
		public const int MAX_UPLOAD_GROUP_NUM = 4; // Metadata: 0x02302F3E
		public bool isValid; // 0x00
		public NativeList<ClothGroupUploadDataMap> uploadDataMap; // 0x08
		public NativeList<ClothMetaData> clothMetaUploadData; // 0x18
		public NativeList<ClothNodeData> clothNodeUploadData; // 0x28
		public NativeList<int4> clothBatchMetaUploadData; // 0x38
		public NativeList<int4> clothBatchCacheMapUploadData; // 0x48
		public ComputeBuffer clothMetaDataBuffer; // 0x58
		public ComputeBuffer clothNodeDataBuffer; // 0x60
		public ComputeBuffer clothBatchMetaDataBuffer; // 0x68
		public ComputeBuffer clothBatchCacheMapBuffer; // 0x70
		public ComputeBuffer clothSkeletonDataBuffer; // 0x78
	
		// Methods
		public bool IsValid() => default; // 0x0000000189C6ACE0-0x0000000189C6AD2C
		// Boolean IsValid()
		bool HG::Rendering::Runtime::GpuClothGroupUploadData::IsValid(GpuClothGroupUploadData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1263, 0LL) )
		    return this->isValid;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1263, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_484(Patch, this, 0LL);
		}
		
		public void Reset() {} // 0x0000000189C6AD2C-0x0000000189C6ADC8
		// Void Reset()
		void HG::Rendering::Runtime::GpuClothGroupUploadData::Reset(GpuClothGroupUploadData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1264, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1264, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_485(Patch, this, 0LL);
		  }
		  else
		  {
		    this->isValid = 0;
		    sub_180363E08(
		      &this->uploadDataMap,
		      MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Clear);
		    sub_180363E08(
		      &this->clothMetaUploadData,
		      MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::Clear);
		    sub_180363E08(
		      &this->clothNodeUploadData,
		      MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::Clear);
		    sub_180363E08(
		      &this->clothBatchMetaUploadData,
		      MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::Clear);
		    sub_180363E08(
		      &this->clothBatchCacheMapUploadData,
		      MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::Clear);
		  }
		}
		
	}
}
