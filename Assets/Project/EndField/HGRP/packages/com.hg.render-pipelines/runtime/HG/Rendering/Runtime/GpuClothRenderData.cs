using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct GpuClothRenderData
	{
		public bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::Runtime::GpuClothRenderData::IsValid(GpuClothRenderData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1129, 0LL) )
			//     return this.isValid;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1129, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_417(Patch, this, 0LL);
			// }
			// 
			return default(bool);
		}

		public bool isValid;

		public int clothNum;

		public ClothConstData clothConstData;

		public ComputeBuffer clothNodeDataBuffer;

		public ComputeBuffer clothMetaDataBuffer;

		public ComputeBuffer clothBatchMetaDataBuffer;

		public ComputeBuffer clothBatchCacheMapBuffer;

		public ComputeBuffer clothSkeletonDataBuffer;
	}
}
