using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
	public struct CollectMaskJob : IJobParallelFor
	{
		public void Execute(int y)
		{
			// // Void Execute(Int32)
			// void HG::Rendering::Runtime::CollectMaskJob::Execute(CollectMaskJob *this, int32_t y, MethodInfo *method)
			// {
			//   int32_t i; // r10d
			//   int32_t v6; // r11d
			//   int v7; // r9d
			//   __int64 v8; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   NativeArray_1_System_UInt32_ tileLightMask; // [rsp+20h] [rbp-18h]
			// 
			//   if ( !byte_18D919E19 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<unsigned int>);
			//     byte_18D919E19 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1545, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1545, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_593(Patch, this, y, 0LL);
			//   }
			//   else
			//   {
			//     tileLightMask = this.tileLightMask;
			//     for ( i = 0; i < this.numTilesX; ++i )
			//     {
			//       v6 = 0;
			//       v7 = i + this.numTilesX * y;
			//       if ( this.lightCount > 0 )
			//       {
			//         v8 = this.lightCount * v7;
			//         do
			//         {
			//           if ( *(_BYTE *)&this.tileLightMarks.m_Buffer[v8] == 1 )
			//             _InterlockedAdd(
			//               (volatile signed __int32 *)&tileLightMask.m_Buffer[32 * v7 + 4 * (v6 / 32)],
			//               1 << ((v6 % 32) & 0x1F));
			//           ++v6;
			//           ++v8;
			//         }
			//         while ( v6 < this.lightCount );
			//       }
			//     }
			//   }
			// }
			// 
		}

		public int numTilesX;

		public int lightCount;

		[ReadOnly]
		public NativeArray<byte> tileLightMarks;

		[NativeDisableParallelForRestriction]
		public NativeArray<uint> tileLightMask;
	}
}
