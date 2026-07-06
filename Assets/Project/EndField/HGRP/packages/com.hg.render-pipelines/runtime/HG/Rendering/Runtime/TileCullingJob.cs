using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 160)]
	public struct TileCullingJob : IJobParallelFor
	{
		public void Execute(int lightIndex)
		{
			// // Void Execute(Int32)
			// void HG::Rendering::Runtime::TileCullingJob::Execute(TileCullingJob *this, int32_t lightIndex, MethodInfo *method)
			// {
			//   __int64 v4; // r15
			//   Void *m_Buffer; // rax
			//   __m128 v6; // xmm2
			//   float4 c1; // xmm0
			//   float4 c2; // xmm1
			//   __m128 v9; // xmm3
			//   __m128 v10; // xmm2
			//   __m128 v11; // xmm3
			//   __int64 v12; // rax
			//   __m128 v13; // xmm4
			//   __m128 v14; // xmm3
			//   __int64 v15; // rax
			//   __int64 v16; // r8
			//   __int64 v17; // rbx
			//   int v18; // r11d
			//   int v19; // r9d
			//   int v20; // edx
			//   int v21; // r12d
			//   int v22; // eax
			//   int v23; // ecx
			//   int32_t v24; // r13d
			//   int32_t v25; // eax
			//   int32_t v26; // r8d
			//   int v27; // ebx
			//   int32_t v28; // r15d
			//   int v29; // eax
			//   __int64 v30; // rcx
			//   Void *v31; // rax
			//   __int64 v32; // xmm0_8
			//   __int64 v33; // rax
			//   __int64 v34; // xmm0_8
			//   float3__StaticFields *static_fields; // rax
			//   __int64 v36; // xmm0_8
			//   int v37; // r15d
			//   int v38; // eax
			//   __int64 v39; // rcx
			//   Void *v40; // rax
			//   __int64 v41; // xmm0_8
			//   __int64 v42; // rax
			//   __int64 v43; // xmm0_8
			//   float3__StaticFields *v44; // rax
			//   __int64 v45; // xmm0_8
			//   int v46; // ecx
			//   int32_t v47; // r11d
			//   int32_t v48; // r8d
			//   int32_t v49; // edx
			//   int32_t v50; // r9d
			//   int v51; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v53; // rdx
			//   __int64 v54; // rcx
			//   int32_t numTilesX; // [rsp+30h] [rbp-D0h]
			//   int v56; // [rsp+38h] [rbp-C8h]
			//   int32_t v57; // [rsp+3Ch] [rbp-C4h]
			//   int v58; // [rsp+44h] [rbp-BCh]
			//   int v59; // [rsp+48h] [rbp-B8h]
			//   int32_t v60; // [rsp+54h] [rbp-ACh]
			//   int32_t v61; // [rsp+5Ch] [rbp-A4h]
			//   _BYTE v62[12]; // [rsp+60h] [rbp-A0h]
			//   __int32 v63; // [rsp+70h] [rbp-90h] BYREF
			//   __int64 v64; // [rsp+74h] [rbp-8Ch]
			//   int v65; // [rsp+7Ch] [rbp-84h]
			//   __int64 v66; // [rsp+80h] [rbp-80h]
			//   __int64 v67; // [rsp+88h] [rbp-78h]
			//   __int64 v68; // [rsp+90h] [rbp-70h] BYREF
			//   int v69; // [rsp+98h] [rbp-68h]
			//   float3 v70; // [rsp+A0h] [rbp-60h] BYREF
			//   float3 v71; // [rsp+B0h] [rbp-50h] BYREF
			//   float3 v72; // [rsp+C0h] [rbp-40h] BYREF
			//   __int64 v73; // [rsp+D0h] [rbp-30h] BYREF
			//   int v74; // [rsp+D8h] [rbp-28h]
			//   float3 v75; // [rsp+E0h] [rbp-20h] BYREF
			//   float3 v76; // [rsp+F0h] [rbp-10h] BYREF
			//   float3 v77; // [rsp+100h] [rbp+0h] BYREF
			//   __m128 v78; // [rsp+110h] [rbp+10h]
			//   _BYTE v79[16]; // [rsp+120h] [rbp+20h] BYREF
			//   _OWORD v80[5]; // [rsp+130h] [rbp+30h] BYREF
			//   __int64 v82; // [rsp+1D8h] [rbp+D8h]
			//   int v83; // [rsp+1D8h] [rbp+D8h]
			// 
			//   v4 = lightIndex;
			//   if ( !byte_18D919E34 )
			//   {
			//     sub_18003C530(&TypeInfo::Unity::Mathematics::float3);
			//     byte_18D919E34 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1663, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1663, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v54, v53);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_640(Patch, this, v4, 0LL);
			//     return;
			//   }
			//   m_Buffer = this.lightSphereData.m_Buffer;
			//   v65 = 1065353216;
			//   v6 = (__m128)_mm_loadu_si128((const __m128i *)&m_Buffer[16 * v4]);
			//   v63 = v6.m128_i32[0];
			//   LODWORD(v64) = _mm_shuffle_ps(v6, v6, 85).m128_u32[0];
			//   HIDWORD(v64) = _mm_shuffle_ps(v6, v6, 170).m128_u32[0];
			//   *(_QWORD *)&v62[4] = v64;
			//   c1 = this.viewProjection.c1;
			//   v80[0] = this.viewProjection.c0;
			//   c2 = this.viewProjection.c2;
			//   v80[1] = c1;
			//   *(_DWORD *)v62 = v6.m128_i32[0];
			//   v80[3] = this.viewProjection.c3;
			//   v78 = v6;
			//   v80[2] = c2;
			//   v9 = (__m128)_mm_loadu_si128((const __m128i *)sub_18238B530(v79, v80, &v63));
			//   v10 = v9;
			//   c1.x = _mm_shuffle_ps(v9, v9, 255).m128_f32[0];
			//   v10.m128_f32[0] = v9.m128_f32[0] / c1.x;
			//   v11 = _mm_shuffle_ps(v9, v9, 85);
			//   v11.m128_f32[0] = v11.m128_f32[0] / c1.x;
			//   v12 = sub_182C9F010(_mm_unpacklo_ps(v10, v11).m128_u64[0]);
			//   v82 = sub_185448C88(v12);
			//   v14 = (__m128)HIDWORD(v82);
			//   if ( this.graphicsUVStartsAtTop )
			//   {
			//     v13.m128_f32[0] = v13.m128_f32[0] - *((float *)&v82 + 1);
			//     v14 = v13;
			//   }
			//   v15 = sub_184D038DC(
			//           _mm_unpacklo_ps((__m128)(unsigned int)v82, v14).m128_u64[0],
			//           _mm_unpacklo_ps(
			//             (__m128)COERCE_UNSIGNED_INT((float)this.actualWidth),
			//             (__m128)COERCE_UNSIGNED_INT((float)this.actualHeight)).m128_u64[0]);
			//   v16 = *(_QWORD *)&this.xIntersectionRange.m_Buffer[8 * v4];
			//   v17 = *(_QWORD *)&this.yIntersectionRange.m_Buffer[8 * v4];
			//   v60 = HIDWORD(v16);
			//   v67 = v17;
			//   v66 = v17;
			//   v18 = (int)*(float *)&v15 / this.tileSize;
			//   v56 = v18;
			//   v57 = (int)*((float *)&v15 + 1) / this.tileSize;
			//   if ( v57 >= this.numTilesY || v57 < 0 || (v19 = v16, (int)v16 >= SHIDWORD(v16)) )
			//   {
			//     v20 = 0;
			//     v21 = 0;
			//     v83 = 0;
			//     if ( v57 < 0 )
			//     {
			//       v22 = 0;
			//       goto LABEL_14;
			//     }
			//   }
			//   else
			//   {
			//     do
			//     {
			//       _InterlockedAdd(&this.tileLightMask[v19 + this.numTilesX * v57], 1 << (((int)v4 % 32) & 0x1F));
			//       ++v19;
			//     }
			//     while ( v19 < SHIDWORD(v16) );
			//     v20 = 0;
			//     v21 = 0;
			//     v83 = 0;
			//   }
			//   v22 = v17 + 1;
			// LABEL_14:
			//   v58 = v22;
			//   if ( v57 >= this.numTilesY )
			//     v23 = this.numTilesY + 1;
			//   else
			//     v23 = HIDWORD(v66) - 1;
			//   v59 = v23;
			//   v24 = v22;
			//   if ( v22 <= v23 )
			//   {
			//     v25 = HIDWORD(v16);
			//     v26 = v16 + 1;
			//     v27 = ((int)v4 % 32) & 0x1F;
			//     v61 = v26;
			//     do
			//     {
			//       v28 = v26;
			//       numTilesX = this.numTilesX;
			//       if ( v26 <= v25 )
			//       {
			//         while ( 1 )
			//         {
			//           v29 = this.numTilesX + 1;
			//           *(_QWORD *)&v70.x = *(_QWORD *)v62;
			//           v30 = 3LL * (v28 + v24 * v29);
			//           v31 = this.tileVertices.m_Buffer;
			//           v32 = *(_QWORD *)&v31[4 * v30];
			//           v69 = *(_DWORD *)&v31[4 * v30 + 8];
			//           v70.z = *(float *)&v62[8];
			//           v68 = v32;
			//           v33 = sub_1828B45B0(v79, &v68);
			//           v34 = *(_QWORD *)v33;
			//           v71.z = *(float *)(v33 + 8);
			//           *(_QWORD *)&v71.x = v34;
			//           static_fields = TypeInfo::Unity::Mathematics::float3.static_fields;
			//           v36 = *(_QWORD *)&static_fields.zero.x;
			//           *(float *)&static_fields = static_fields.zero.z;
			//           *(_QWORD *)&v72.x = v36;
			//           LODWORD(v72.z) = (_DWORD)static_fields;
			//           if ( HG::Rendering::Runtime::GeometryUtils::IntersectRaySphere(&v72, &v71, &v70, v78.m128_f32[3], 0, 0LL) )
			//             break;
			//           if ( ++v28 > v60 )
			//             goto LABEL_24;
			//         }
			//         numTilesX = v28;
			//       }
			// LABEL_24:
			//       v37 = v60 - 1;
			//       if ( v60 - 1 < 0 )
			//       {
			// LABEL_27:
			//         v46 = 0;
			//       }
			//       else
			//       {
			//         while ( 1 )
			//         {
			//           v38 = this.numTilesX + 1;
			//           *(_QWORD *)&v75.x = *(_QWORD *)v62;
			//           v39 = 3LL * (v37 + v24 * v38);
			//           v40 = this.tileVertices.m_Buffer;
			//           v41 = *(_QWORD *)&v40[4 * v39];
			//           v74 = *(_DWORD *)&v40[4 * v39 + 8];
			//           v75.z = *(float *)&v62[8];
			//           v73 = v41;
			//           v42 = sub_1828B45B0(&v63, &v73);
			//           v43 = *(_QWORD *)v42;
			//           v76.z = *(float *)(v42 + 8);
			//           *(_QWORD *)&v76.x = v43;
			//           v44 = TypeInfo::Unity::Mathematics::float3.static_fields;
			//           v45 = *(_QWORD *)&v44.zero.x;
			//           *(float *)&v44 = v44.zero.z;
			//           *(_QWORD *)&v77.x = v45;
			//           LODWORD(v77.z) = (_DWORD)v44;
			//           if ( HG::Rendering::Runtime::GeometryUtils::IntersectRaySphere(&v77, &v76, &v75, v78.m128_f32[3], 0, 0LL) )
			//             break;
			//           if ( --v37 < 0 )
			//             goto LABEL_27;
			//         }
			//         v46 = v37;
			//       }
			//       v47 = v24;
			//       if ( v24 <= v57 )
			//         v47 = v24 - 1;
			//       v48 = 0;
			//       v49 = v46 + 1;
			//       if ( numTilesX - 1 >= 0 )
			//         v48 = numTilesX - 1;
			//       v50 = v48;
			//       if ( v49 >= this.numTilesX )
			//         v49 = this.numTilesX;
			//       if ( v48 < v49 )
			//       {
			//         do
			//         {
			//           _InterlockedAdd(&this.tileLightMask[v50 + this.numTilesX * v47], 1 << v27);
			//           ++v50;
			//         }
			//         while ( v50 < v49 );
			//       }
			//       v51 = v49 - v48;
			//       if ( v24 != v58 )
			//         v51 = v21;
			//       v21 = v51;
			//       v25 = v60;
			//       v20 = v49 - v48;
			//       v26 = v61;
			//       if ( v24 != v59 )
			//         v20 = v83;
			//       ++v24;
			//       v83 = v20;
			//     }
			//     while ( v24 <= v59 );
			//     LODWORD(v17) = v67;
			//     LODWORD(v4) = lightIndex;
			//     v18 = v56;
			//     v83 = v20;
			//   }
			//   if ( (int)v17 < v57 && v21 < 1 )
			//   {
			//     _InterlockedAdd(&this.tileLightMask[v18 + this.numTilesX * (int)v17], 1 << (((int)v4 % 32) & 0x1F));
			//     v20 = v83;
			//   }
			//   if ( HIDWORD(v66) - 2 == v57 && HIDWORD(v66) - 1 > (int)v17 && v20 < 1 )
			//     _InterlockedAdd(&this.tileLightMask[v18 + this.numTilesX * (HIDWORD(v66) - 1)], 1 << (((int)v4 % 32) & 0x1F));
			// }
			// 
		}

		public int tileSize;

		public int numTilesX;

		public int numTilesY;

		public int actualWidth;

		public int actualHeight;

		public float4x4 viewProjection;

		public bool graphicsUVStartsAtTop;

		[ReadOnly]
		public NativeArray<float3> tileVertices;

		[ReadOnly]
		public NativeArray<int2> xIntersectionRange;

		[ReadOnly]
		public NativeArray<int2> yIntersectionRange;

		[ReadOnly]
		public NativeArray<float4> lightSphereData;

		[NativeDisableUnsafePtrRestriction]
		public unsafe int* tileLightMask;
	}
}
