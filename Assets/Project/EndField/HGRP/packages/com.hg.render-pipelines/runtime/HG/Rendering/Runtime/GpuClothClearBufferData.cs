using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct GpuClothClearBufferData
	{
		public bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::Runtime::GpuClothClearBufferData::IsValid(GpuClothClearBufferData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1130, 0LL) )
			//     return this.shouldClear;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1130, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_418(Patch, this, 0LL);
			// }
			// 
			return default(bool);
		}

		public bool shouldClear;

		public int4 eleNum;

		public ComputeBuffer clothNodeDataBuffer;

		public ComputeBuffer clothBatchMetaDataBuffer;

		public ComputeBuffer clothBatchCacheMapBuffer;
	}
}
