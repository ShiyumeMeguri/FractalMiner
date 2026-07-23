using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct GpuClothClearBufferData // TypeDefIndex: 37567
	{
		// Fields
		public bool shouldClear; // 0x00
		public int4 eleNum; // 0x04
		public ComputeBuffer clothNodeDataBuffer; // 0x18
		public ComputeBuffer clothBatchMetaDataBuffer; // 0x20
		public ComputeBuffer clothBatchCacheMapBuffer; // 0x28
	
		// Methods
		public bool IsValid() => default; // 0x0000000189C6AC94-0x0000000189C6ACE0
		// Boolean IsValid()
		bool HG::Rendering::Runtime::GpuClothClearBufferData::IsValid(GpuClothClearBufferData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1266, 0LL) )
		    return this->shouldClear;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1266, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_487(Patch, this, 0LL);
		}
		
	}
}
