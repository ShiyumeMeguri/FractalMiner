using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	public struct CollectZBinJob : IJobParallelFor // TypeDefIndex: 37758
	{
		// Fields
		public int lightCount; // 0x00
		[ReadOnly]
		public NativeArray<byte> zSliceLightMarks; // 0x08
		[NativeDisableParallelForRestriction]
		public NativeArray<uint4> zBin; // 0x18
	
		// Methods
		public void Execute(int index) {} // 0x0000000189CF8FA4-0x0000000189CF90B8
		// Void Execute(Int32)
		void HG::Rendering::Runtime::CollectZBinJob::Execute(CollectZBinJob *this, int32_t index, MethodInfo *method)
		{
		  int32_t v5; // ebx
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  Void *v8; // r9
		  int v9; // eax
		  int v10; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  _DWORD v14[4]; // [rsp+10h] [rbp-38h]
		  __int128 v15; // [rsp+20h] [rbp-28h]
		  __int128 v16; // [rsp+30h] [rbp-18h]
		
		  v5 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1833, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_741(Patch, this, index, 0LL);
		  }
		  else
		  {
		    v6 = 0uLL;
		    v15 = 0uLL;
		    v7 = 0uLL;
		    v16 = 0uLL;
		    if ( this->lightCount > 0 )
		    {
		      v8 = &this->zSliceLightMarks.m_Buffer[this->lightCount * index];
		      do
		      {
		        if ( *v8 == 1 )
		        {
		          v9 = v5 / 32;
		          v10 = (v5 % 32) & 0x1F;
		          if ( v5 < 128 )
		            *((_DWORD *)&v16 + v9) |= 1 << v10;
		          else
		            v14[v9] |= 1 << v10;
		        }
		        ++v5;
		        ++v8;
		      }
		      while ( v5 < this->lightCount );
		      v6 = v16;
		      v7 = v15;
		    }
		    *(_OWORD *)&this->zBin.m_Buffer[32 * index] = v6;
		    *(_OWORD *)&this->zBin.m_Buffer[32 * index + 16] = v7;
		  }
		}
		
	}
}
