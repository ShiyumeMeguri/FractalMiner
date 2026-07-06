using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
	public struct LightSphereDataJob : IJobParallelFor
	{
		public void Execute(int index)
		{
			// // Void Execute(Int32)
			// void HG::Rendering::Runtime::LightSphereDataJob::Execute(LightSphereDataJob *this, int32_t index, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1656, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1656, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_637(Patch, this, index, 0LL);
			//   }
			// }
			// 
		}

		public float3 cameraPosition;

		[ReadOnly]
		public NativeArray<VisibleLight> visibleLights;

		[ReadOnly]
		public NativeArray<int> lightIndices;

		public NativeArray<float4> lightSphereData;
	}
}
