using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct GpuClothRenderData // TypeDefIndex: 37566
	{
		// Fields
		public bool isValid; // 0x00
		public int clothNum; // 0x04
		public ClothConstData clothConstData; // 0x08
		public ComputeBuffer clothNodeDataBuffer; // 0xE8
		public ComputeBuffer clothMetaDataBuffer; // 0xF0
		public ComputeBuffer clothBatchMetaDataBuffer; // 0xF8
		public ComputeBuffer clothBatchCacheMapBuffer; // 0x100
		public ComputeBuffer clothSkeletonDataBuffer; // 0x108
	
		// Methods
		public bool IsValid() => default; // 0x0000000189C6D934-0x0000000189C6D980
		// Boolean IsValid()
		bool HG::Rendering::Runtime::GpuClothRenderData::IsValid(GpuClothRenderData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1265, 0LL) )
		    return this->isValid;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1265, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_486(Patch, this, 0LL);
		}
		
	}
}
