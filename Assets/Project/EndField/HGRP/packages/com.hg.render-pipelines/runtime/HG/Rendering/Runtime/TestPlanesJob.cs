using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 136)]
	public struct TestPlanesJob : IJobParallelFor
	{
		public void Execute(int lightIndex)
		{
			// // Void Execute(Int32)
			// void HG::Rendering::Runtime::TestPlanesJob::Execute(TestPlanesJob *this, int32_t lightIndex, MethodInfo *method)
			// {
			//   __int64 v3; // rsi
			//   int32_t v5; // edi
			//   int v6; // r9d
			//   __m128 v7; // xmm2
			//   int v8; // r11d
			//   MethodInfo *v9; // r8
			//   unsigned __int64 v10; // xmm4_8
			//   Void *m_Buffer; // rax
			//   __int64 v12; // r15
			//   Void *v13; // r10
			//   Void *v14; // r14
			//   __m128 v15; // xmm0
			//   Void *v16; // r10
			//   float v17; // xmm5_4
			//   int32_t numTilesY; // edx
			//   __int64 v19; // r14
			//   Void *v20; // r8
			//   __m128 v21; // xmm0
			//   Void *v22; // r8
			//   float v23; // xmm5_4
			//   _WORD *v24; // r10
			//   int32_t numTilesX; // r10d
			//   int32_t v26; // r8d
			//   int32_t v27; // edx
			//   Void *v28; // r9
			//   __int16 v29; // cx
			//   int32_t v30; // edx
			//   int32_t v31; // r9d
			//   Void *v32; // r8
			//   __int16 v33; // cx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   Vector3 value; // [rsp+20h] [rbp-20h] BYREF
			//   Vector3 vector; // [rsp+30h] [rbp-10h] BYREF
			//   __int16 v39; // [rsp+78h] [rbp+38h]
			//   __int16 v40; // [rsp+78h] [rbp+38h]
			// 
			//   v3 = lightIndex;
			//   v5 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1662, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1662, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v36, v35);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_639(Patch, this, v3, 0LL);
			//   }
			//   else
			//   {
			//     v6 = v3 * (this.numTilesX + 1);
			//     v7 = (__m128)_mm_loadu_si128((const __m128i *)&this.lightSphereData.m_Buffer[16 * v3]);
			//     v8 = v3 * (this.numTilesY + 1);
			//     v9 = (MethodInfo *)(unsigned int)_mm_cvtsi128_si32((__m128i)_mm_shuffle_ps(v7, v7, 170));
			//     v10 = _mm_unpacklo_ps(v7, _mm_shuffle_ps(v7, v7, 85)).m128_u64[0];
			//     if ( this.numTilesX >= 0 )
			//     {
			//       m_Buffer = this.xIntersections.m_Buffer;
			//       v12 = (unsigned int)(this.numTilesX + 1);
			//       v13 = this.xPlanes.m_Buffer;
			//       *(_QWORD *)&value.x = v10;
			//       LODWORD(value.z) = (_DWORD)v9;
			//       v14 = &m_Buffer[2 * v6];
			//       do
			//       {
			//         v15 = (__m128)_mm_loadu_si128((const __m128i *)v13);
			//         *(_QWORD *)&vector.x = _mm_unpacklo_ps(v15, _mm_shuffle_ps(v15, v15, 85)).m128_u64[0];
			//         LODWORD(vector.z) = _mm_shuffle_ps(v15, v15, 170).m128_u32[0];
			//         v15.m128_f32[0] = Dest::Math::Vector3ex::Dot(&vector, &value, v9);
			//         v13 = v16 + 16;
			//         LOBYTE(v39) = v17 > (float)-v15.m128_f32[0];
			//         HIBYTE(v39) = v17 > v15.m128_f32[0];
			//         *(_WORD *)v14 = v39;
			//         v14 += 2;
			//         --v12;
			//       }
			//       while ( v12 );
			//     }
			//     numTilesY = this.numTilesY;
			//     if ( numTilesY >= 0 )
			//     {
			//       v19 = (unsigned int)(numTilesY + 1);
			//       LODWORD(vector.z) = (_DWORD)v9;
			//       v20 = this.yPlanes.m_Buffer;
			//       *(_QWORD *)&vector.x = v10;
			//       do
			//       {
			//         v21 = (__m128)_mm_loadu_si128((const __m128i *)v20);
			//         *(_QWORD *)&value.x = _mm_unpacklo_ps(v21, _mm_shuffle_ps(v21, v21, 85)).m128_u64[0];
			//         LODWORD(value.z) = _mm_shuffle_ps(v21, v21, 170).m128_u32[0];
			//         v21.m128_f32[0] = Dest::Math::Vector3ex::Dot(&value, &vector, (MethodInfo *)v20);
			//         v20 = v22 + 16;
			//         LOBYTE(v40) = v23 > (float)-v21.m128_f32[0];
			//         HIBYTE(v40) = v23 > v21.m128_f32[0];
			//         *v24 = v40;
			//         --v19;
			//       }
			//       while ( v19 );
			//     }
			//     numTilesX = this.numTilesX;
			//     v26 = 0;
			//     v27 = 0;
			//     if ( this.numTilesX > 0 )
			//     {
			//       v28 = &this.xIntersections.m_Buffer[2 * v6];
			//       while ( 1 )
			//       {
			//         v29 = *(_WORD *)&v28[2];
			//         if ( (unsigned __int8)*(_WORD *)v28 != (_BYTE)v29 )
			//           v26 = v27;
			//         ++v27;
			//         if ( HIBYTE(*(_WORD *)v28) != HIBYTE(v29) )
			//           break;
			//         v28 += 2;
			//         if ( v27 >= numTilesX )
			//           goto LABEL_16;
			//       }
			//       numTilesX = v27;
			//     }
			// LABEL_16:
			//     v30 = 0;
			//     v31 = this.numTilesY;
			//     *(_QWORD *)&this.xIntersectionRange.m_Buffer[8 * v3] = __PAIR64__(numTilesX, v26);
			//     if ( v31 > 0 )
			//     {
			//       v32 = &this.yIntersections.m_Buffer[2 * v8];
			//       while ( 1 )
			//       {
			//         v33 = *(_WORD *)&v32[2];
			//         if ( (unsigned __int8)*(_WORD *)v32 != (_BYTE)v33 )
			//           v5 = v30;
			//         ++v30;
			//         if ( HIBYTE(*(_WORD *)v32) != HIBYTE(v33) )
			//           break;
			//         v32 += 2;
			//         if ( v30 >= v31 )
			//           goto LABEL_24;
			//       }
			//       v31 = v30;
			//     }
			// LABEL_24:
			//     *(_QWORD *)&this.yIntersectionRange.m_Buffer[8 * v3] = __PAIR64__(v31, v5);
			//   }
			// }
			// 
		}

		public int numTilesX;

		public int numTilesY;

		public float3 cameraPosition;

		[ReadOnly]
		public NativeArray<float4> lightSphereData;

		[ReadOnly]
		public NativeArray<float4> xPlanes;

		[ReadOnly]
		public NativeArray<float4> yPlanes;

		[NativeDisableParallelForRestriction]
		public NativeArray<bool2> xIntersections;

		[NativeDisableParallelForRestriction]
		public NativeArray<bool2> yIntersections;

		[NativeDisableParallelForRestriction]
		public NativeArray<int2> xIntersectionRange;

		[NativeDisableParallelForRestriction]
		public NativeArray<int2> yIntersectionRange;
	}
}
