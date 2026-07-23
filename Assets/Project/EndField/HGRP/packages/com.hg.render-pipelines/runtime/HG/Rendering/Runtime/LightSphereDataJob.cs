using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	public struct LightSphereDataJob : IJobParallelFor // TypeDefIndex: 37782
	{
		// Fields
		public float3 cameraPosition; // 0x00
		[ReadOnly]
		public NativeArray<VisibleLight> visibleLights; // 0x10
		[ReadOnly]
		public NativeArray<int> lightIndices; // 0x20
		public NativeArray<float4> lightSphereData; // 0x30
	
		// Methods
		public void Execute(int index) {} // 0x0000000189D0E698-0x0000000189D0E6EC
		// Void Execute(Int32)
		void HG::Rendering::Runtime::LightSphereDataJob::Execute(LightSphereDataJob *this, int32_t index, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1968, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1968, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_791(Patch, this, index, 0LL);
		  }
		}
		
	}
}
