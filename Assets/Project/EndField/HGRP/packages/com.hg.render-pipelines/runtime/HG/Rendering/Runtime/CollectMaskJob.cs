using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	public struct CollectMaskJob : IJobParallelFor // TypeDefIndex: 37757
	{
		// Fields
		public int numTilesX; // 0x00
		public int lightCount; // 0x04
		[ReadOnly]
		public NativeArray<byte> tileLightMarks; // 0x08
		[NativeDisableParallelForRestriction]
		public NativeArray<uint> tileLightMask; // 0x18
	
		// Methods
		public void Execute(int y) {} // 0x0000000189CF8EC0-0x0000000189CF8FA4
		// Void Execute(Int32)
		void HG::Rendering::Runtime::CollectMaskJob::Execute(CollectMaskJob *this, int32_t y, MethodInfo *method)
		{
		  int32_t i; // r10d
		  int32_t v6; // r11d
		  int v7; // r9d
		  __int64 v8; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  NativeArray_1_System_UInt32_ tileLightMask; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1832, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1832, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_740(Patch, this, y, 0LL);
		  }
		  else
		  {
		    tileLightMask = this->tileLightMask;
		    for ( i = 0; i < this->numTilesX; ++i )
		    {
		      v6 = 0;
		      v7 = i + this->numTilesX * y;
		      if ( this->lightCount > 0 )
		      {
		        v8 = this->lightCount * v7;
		        do
		        {
		          if ( *(_BYTE *)&this->tileLightMarks.m_Buffer[v8] == 1 )
		            _InterlockedAdd(
		              (volatile signed __int32 *)&tileLightMask.m_Buffer[32 * v7 + 4 * (v6 / 32)],
		              1 << ((v6 % 32) & 0x1F));
		          ++v6;
		          ++v8;
		        }
		        while ( v6 < this->lightCount );
		      }
		    }
		  }
		}
		
	}
}
