using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
	public struct CalculatePlanesJob : IJob
	{
		public void Execute()
		{
			// // Void Execute()
			// void HG::Rendering::Runtime::CalculatePlanesJob::Execute(CalculatePlanesJob *this, MethodInfo *method)
			// {
			//   __int64 v3; // r9
			//   __int64 numTilesX; // rax
			//   __int64 v5; // r12
			//   Void *m_Buffer; // rsi
			//   int v7; // edi
			//   Void *v8; // r14
			//   int v9; // edi
			//   Void *v10; // r15
			//   int v11; // eax
			//   __int64 v12; // xmm0_8
			//   int v13; // eax
			//   __int64 v14; // rax
			//   __int64 v15; // xmm3_8
			//   __int64 v16; // rax
			//   int32_t numTilesY; // r8d
			//   __int64 v18; // rdx
			//   __int64 v19; // r15
			//   Void *v20; // rdi
			//   Void *v21; // rsi
			//   __int64 v22; // r14
			//   __int64 v23; // rbx
			//   int v24; // eax
			//   __int64 v25; // xmm0_8
			//   int v26; // eax
			//   __int64 v27; // rax
			//   __int64 v28; // xmm3_8
			//   __int64 v29; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   __int64 v33; // [rsp+28h] [rbp-29h] BYREF
			//   int v34; // [rsp+30h] [rbp-21h]
			//   __int64 v35; // [rsp+38h] [rbp-19h] BYREF
			//   int v36; // [rsp+40h] [rbp-11h]
			//   __int64 v37; // [rsp+48h] [rbp-9h] BYREF
			//   int v38; // [rsp+50h] [rbp-1h]
			//   __int64 v39; // [rsp+58h] [rbp+7h] BYREF
			//   int v40; // [rsp+60h] [rbp+Fh]
			//   _BYTE v41[16]; // [rsp+68h] [rbp+17h] BYREF
			//   _BYTE v42[16]; // [rsp+78h] [rbp+27h] BYREF
			//   __int128 v43; // [rsp+88h] [rbp+37h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1543, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1543, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v32, v31);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_591(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     numTilesX = this.numTilesX;
			//     if ( numTilesX >= 0 )
			//     {
			//       v5 = numTilesX + 1;
			//       m_Buffer = this.tileVertices.m_Buffer;
			//       v7 = this.numTilesX + 1;
			//       HIDWORD(v43) = 0;
			//       v8 = m_Buffer;
			//       v9 = this.numTilesY * v7;
			//       v10 = this.xPlanes.m_Buffer;
			//       do
			//       {
			//         v11 = *(_DWORD *)&m_Buffer[12 * v9 + 8];
			//         v33 = *(_QWORD *)&m_Buffer[12 * v9];
			//         v12 = *(_QWORD *)v8;
			//         v34 = v11;
			//         v13 = *(_DWORD *)&v8[8];
			//         v35 = v12;
			//         v36 = v13;
			//         v14 = sub_182345040(v41, &v35, &v33, v3);
			//         v15 = *(_QWORD *)v14;
			//         LODWORD(v14) = *(_DWORD *)(v14 + 8);
			//         v37 = v15;
			//         v38 = v14;
			//         v16 = sub_1828B45B0(v42, &v37);
			//         ++v9;
			//         v8 += 12;
			//         v39 = *(_QWORD *)v16;
			//         *(_QWORD *)&v43 = v39;
			//         DWORD2(v43) = *(_DWORD *)(v16 + 8);
			//         *(_OWORD *)v10 = v43;
			//         v10 += 16;
			//         --v5;
			//       }
			//       while ( v5 );
			//     }
			//     numTilesY = this.numTilesY;
			//     if ( numTilesY >= 0 )
			//     {
			//       v18 = this.numTilesX;
			//       v19 = (unsigned int)(numTilesY + 1);
			//       v20 = this.tileVertices.m_Buffer;
			//       v21 = this.yPlanes.m_Buffer;
			//       HIDWORD(v43) = 0;
			//       v22 = 3 * v18;
			//       v23 = 12LL * ((int)v18 + 1);
			//       do
			//       {
			//         v24 = *(_DWORD *)&v20[8];
			//         v39 = *(_QWORD *)v20;
			//         v25 = *(_QWORD *)&v20[4 * v22];
			//         v40 = v24;
			//         v26 = *(_DWORD *)&v20[4 * v22 + 8];
			//         v37 = v25;
			//         v38 = v26;
			//         v27 = sub_182345040(v42, &v37, &v39, v3);
			//         v28 = *(_QWORD *)v27;
			//         LODWORD(v27) = *(_DWORD *)(v27 + 8);
			//         v35 = v28;
			//         v36 = v27;
			//         v29 = sub_1828B45B0(v41, &v35);
			//         v20 += v23;
			//         v33 = *(_QWORD *)v29;
			//         *(_QWORD *)&v43 = v33;
			//         DWORD2(v43) = *(_DWORD *)(v29 + 8);
			//         *(_OWORD *)v21 = v43;
			//         v21 += 16;
			//         --v19;
			//       }
			//       while ( v19 );
			//     }
			//   }
			// }
			// 
		}

		public int numTilesX;

		public int numTilesY;

		[ReadOnly]
		public NativeArray<float3> tileVertices;

		[WriteOnly]
		public NativeArray<float4> xPlanes;

		[WriteOnly]
		public NativeArray<float4> yPlanes;
	}
}
