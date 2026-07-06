using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	public struct CalculateTileVerticesJob : IJobParallelFor
	{
		public void Execute(int y)
		{
			// // Void Execute(Int32)
			// void HG::Rendering::Runtime::CalculateTileVerticesJob::Execute(
			//         CalculateTileVerticesJob *this,
			//         int32_t y,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // r9
			//   int v6; // esi
			//   Void *m_Buffer; // rax
			//   __int64 v8; // xmm0_8
			//   Void *v9; // rax
			//   __int64 v10; // xmm0_8
			//   float3 *v11; // rax
			//   __m128 x_low; // xmm3
			//   __m128 y_low; // xmm1
			//   float tileSize; // xmm2_4
			//   MethodInfo *v15; // r9
			//   MethodInfo *v16; // rax
			//   Void *v17; // rcx
			//   Void *v18; // rcx
			//   __int64 v19; // xmm0_8
			//   float3 *v20; // rax
			//   __m128 v21; // xmm3
			//   __m128 v22; // xmm1
			//   float v23; // xmm2_4
			//   MethodInfo *v24; // r9
			//   float3 *v25; // rax
			//   __int64 v26; // r9
			//   int32_t numVerticesX; // r11d
			//   float v28; // ecx
			//   __int64 v29; // xmm0_8
			//   MethodInfo *v30; // r9
			//   float3 *v31; // rax
			//   __int64 v32; // r10
			//   __int64 v33; // xmm3_8
			//   MethodInfo *v34; // r9
			//   float v35; // xmm4_4
			//   float3 *v36; // rax
			//   __int64 v37; // xmm3_8
			//   MethodInfo *v38; // r9
			//   float3 *v39; // rax
			//   __int64 v40; // xmm2_8
			//   MethodInfo *v41; // r9
			//   float3 *v42; // rax
			//   float z; // ecx
			//   __int64 v44; // r9
			//   int v45; // r11d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   float3 v49; // [rsp+28h] [rbp-49h] BYREF
			//   float3 v50; // [rsp+38h] [rbp-39h] BYREF
			//   float3 v51; // [rsp+48h] [rbp-29h] BYREF
			//   float3 v52; // [rsp+58h] [rbp-19h] BYREF
			//   float3 v53; // [rsp+68h] [rbp-9h] BYREF
			//   float3 v54; // [rsp+78h] [rbp+7h] BYREF
			//   float3 v55; // [rsp+88h] [rbp+17h] BYREF
			//   float3 v56; // [rsp+98h] [rbp+27h] BYREF
			//   float3 v57; // [rsp+A8h] [rbp+37h] BYREF
			//   float3 v58; // [rsp+B8h] [rbp+47h] BYREF
			// 
			//   v6 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1544, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1544, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v48, v47);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_592(Patch, this, y, 0LL);
			//   }
			//   else
			//   {
			//     m_Buffer = this.frustumCorners.m_Buffer;
			//     v8 = *(_QWORD *)m_Buffer;
			//     v50.z = *(float *)&m_Buffer[8];
			//     v9 = this.frustumCorners.m_Buffer;
			//     *(_QWORD *)&v50.x = v8;
			//     v10 = *(_QWORD *)&v9[12];
			//     LODWORD(v9) = *(_DWORD *)&v9[20];
			//     *(_QWORD *)&v49.x = v10;
			//     LODWORD(v49.z) = (_DWORD)v9;
			//     v11 = Unity::Mathematics::float3::op_Subtraction(&v52, &v49, &v50, v5);
			//     *(float *)&v10 = (float)this.actualWidth;
			//     *(_QWORD *)&v49.x = *(_QWORD *)&v11.x;
			//     x_low = (__m128)LODWORD(v49.x);
			//     y_low = (__m128)LODWORD(v49.y);
			//     x_low.m128_f32[0] = v49.x / *(float *)&v10;
			//     v49.z = v11.z / *(float *)&v10;
			//     y_low.m128_f32[0] = v49.y / *(float *)&v10;
			//     tileSize = (float)this.tileSize;
			//     *(_QWORD *)&v49.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//     v16 = (MethodInfo *)Unity::Mathematics::float3::op_Multiply(&v52, &v49, tileSize, v15);
			//     v17 = this.frustumCorners.m_Buffer;
			//     x_low.m128_u64[0] = *(_QWORD *)v17;
			//     v49.z = *(float *)&v17[8];
			//     v18 = this.frustumCorners.m_Buffer;
			//     *(_QWORD *)&v49.x = x_low.m128_u64[0];
			//     v19 = *(_QWORD *)&v18[24];
			//     v50.z = *(float *)&v18[32];
			//     *(_QWORD *)&v50.x = v19;
			//     v20 = Unity::Mathematics::float3::op_Subtraction(&v51, &v50, &v49, v16);
			//     *(float *)&v19 = (float)this.actualHeight;
			//     *(_QWORD *)&v49.x = *(_QWORD *)&v20.x;
			//     v21 = (__m128)LODWORD(v49.x);
			//     v22 = (__m128)LODWORD(v49.y);
			//     v21.m128_f32[0] = v49.x / *(float *)&v19;
			//     v49.z = v20.z / *(float *)&v19;
			//     v22.m128_f32[0] = v49.y / *(float *)&v19;
			//     v23 = (float)this.tileSize;
			//     *(_QWORD *)&v49.x = _mm_unpacklo_ps(v21, v22).m128_u64[0];
			//     v25 = Unity::Mathematics::float3::op_Multiply(&v51, &v49, v23, v24);
			//     numVerticesX = this.numVerticesX;
			//     if ( numVerticesX > 0 )
			//     {
			//       v28 = *(float *)(v26 + 8);
			//       *(_QWORD *)&v49.x = *(_QWORD *)v26;
			//       v29 = *(_QWORD *)&v25.x;
			//       v50.z = v25.z;
			//       v49.z = v28;
			//       *(_QWORD *)&v50.x = v29;
			//       v30 = (MethodInfo *)&this.tileVertices.m_Buffer[12 * numVerticesX * y];
			//       do
			//       {
			//         v31 = Unity::Mathematics::float3::op_Multiply(&v55, &v49, (float)v6, v30);
			//         *(_QWORD *)&v54.x = *(_QWORD *)v32;
			//         v33 = *(_QWORD *)&v31.x;
			//         v53.z = v31.z;
			//         v54.z = *(float *)(v32 + 8);
			//         *(_QWORD *)&v53.x = v33;
			//         v36 = Unity::Mathematics::float3::op_Multiply(&v56, &v50, v35, v34);
			//         v37 = *(_QWORD *)&v36.x;
			//         *(float *)&v36 = v36.z;
			//         *(_QWORD *)&v51.x = v37;
			//         LODWORD(v51.z) = (_DWORD)v36;
			//         v39 = Unity::Mathematics::float3::op_Addition(&v57, &v54, &v53, v38);
			//         v40 = *(_QWORD *)&v39.x;
			//         *(float *)&v39 = v39.z;
			//         *(_QWORD *)&v52.x = v40;
			//         LODWORD(v52.z) = (_DWORD)v39;
			//         v42 = Unity::Mathematics::float3::op_Addition(&v58, &v52, &v51, v41);
			//         ++v6;
			//         z = v42.z;
			//         *(_QWORD *)v44 = *(_QWORD *)&v42.x;
			//         *(float *)(v44 + 8) = z;
			//         v30 = (MethodInfo *)(v44 + 12);
			//       }
			//       while ( v6 < v45 );
			//     }
			//   }
			// }
			// 
		}

		public int tileSize;

		public int numVerticesX;

		public int actualWidth;

		public int actualHeight;

		[ReadOnly]
		public NativeArray<float3> frustumCorners;

		[NativeDisableParallelForRestriction]
		public NativeArray<float3> tileVertices;
	}
}
