using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	public struct TileCullingJob : IJobParallelFor // TypeDefIndex: 37795
	{
		// Fields
		public int tileSize; // 0x00
		public int numTilesX; // 0x04
		public int numTilesY; // 0x08
		public int actualWidth; // 0x0C
		public int actualHeight; // 0x10
		public float4x4 viewProjection; // 0x14
		public bool graphicsUVStartsAtTop; // 0x54
		[ReadOnly]
		public NativeArray<float3> tileVertices; // 0x58
		[ReadOnly]
		public NativeArray<int2> xIntersectionRange; // 0x68
		[ReadOnly]
		public NativeArray<int2> yIntersectionRange; // 0x78
		[ReadOnly]
		public NativeArray<float4> lightSphereData; // 0x88
		[NativeDisableUnsafePtrRestriction]
		public unsafe int* tileLightMask; // 0x98
	
		// Methods
		public void Execute(int lightIndex) {} // 0x0000000189D115C0-0x0000000189D11B3C
		// Void Execute(Int32)
		void HG::Rendering::Runtime::TileCullingJob::Execute(TileCullingJob *this, int32_t lightIndex, MethodInfo *method)
		{
		  __int64 v3; // r15
		  Void *m_Buffer; // rax
		  __m128 v6; // xmm2
		  float4 c1; // xmm0
		  float4 c2; // xmm1
		  __m128 v9; // xmm3
		  __m128 v10; // xmm2
		  __m128 v11; // xmm3
		  Vector2 v12; // rdx
		  Vector2 v13; // r8
		  int32_t v14; // r9d
		  Vector2 v15; // rax
		  __m128 v16; // xmm4
		  __m128 v17; // xmm3
		  __int64 v18; // rax
		  __int64 v19; // r8
		  __int64 v20; // rbx
		  int v21; // r11d
		  int v22; // r9d
		  int v23; // edx
		  int v24; // r12d
		  int v25; // eax
		  int v26; // ecx
		  int32_t v27; // r13d
		  int32_t v28; // eax
		  int32_t v29; // r8d
		  int v30; // ebx
		  int32_t v31; // r15d
		  int v32; // eax
		  __int64 v33; // rcx
		  Void *v34; // rax
		  __int64 v35; // xmm0_8
		  __int64 v36; // rax
		  __int64 v37; // xmm0_8
		  float3__StaticFields *static_fields; // rax
		  __int64 v39; // xmm0_8
		  int v40; // r15d
		  int v41; // eax
		  __int64 v42; // rcx
		  Void *v43; // rax
		  __int64 v44; // xmm0_8
		  __int64 v45; // rax
		  __int64 v46; // xmm0_8
		  float3__StaticFields *v47; // rax
		  __int64 v48; // xmm0_8
		  int v49; // ecx
		  int32_t v50; // r11d
		  int32_t v51; // r8d
		  int32_t v52; // edx
		  int32_t v53; // r9d
		  int v54; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  int32_t numTilesX; // [rsp+30h] [rbp-D0h]
		  int v59; // [rsp+38h] [rbp-C8h]
		  int32_t v60; // [rsp+3Ch] [rbp-C4h]
		  int v61; // [rsp+44h] [rbp-BCh]
		  int v62; // [rsp+48h] [rbp-B8h]
		  int32_t v63; // [rsp+54h] [rbp-ACh]
		  int32_t v64; // [rsp+5Ch] [rbp-A4h]
		  _BYTE v65[12]; // [rsp+60h] [rbp-A0h]
		  __int32 v66; // [rsp+70h] [rbp-90h] BYREF
		  __int64 v67; // [rsp+74h] [rbp-8Ch]
		  int v68; // [rsp+7Ch] [rbp-84h]
		  __int64 v69; // [rsp+80h] [rbp-80h]
		  __int64 v70; // [rsp+88h] [rbp-78h]
		  __int64 v71; // [rsp+90h] [rbp-70h] BYREF
		  int v72; // [rsp+98h] [rbp-68h]
		  float3 v73; // [rsp+A0h] [rbp-60h] BYREF
		  float3 v74; // [rsp+B0h] [rbp-50h] BYREF
		  float3 v75; // [rsp+C0h] [rbp-40h] BYREF
		  __int64 v76; // [rsp+D0h] [rbp-30h] BYREF
		  int v77; // [rsp+D8h] [rbp-28h]
		  float3 v78; // [rsp+E0h] [rbp-20h] BYREF
		  float3 v79; // [rsp+F0h] [rbp-10h] BYREF
		  float3 v80; // [rsp+100h] [rbp+0h] BYREF
		  __m128 v81; // [rsp+110h] [rbp+10h]
		  _BYTE v82[16]; // [rsp+120h] [rbp+20h] BYREF
		  _OWORD v83[5]; // [rsp+130h] [rbp+30h] BYREF
		  __int64 v85; // [rsp+1D8h] [rbp+D8h]
		  int v86; // [rsp+1D8h] [rbp+D8h]
		
		  v3 = lightIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(1975, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1975, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v57, v56);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_794(Patch, this, v3, 0LL);
		    return;
		  }
		  m_Buffer = this->lightSphereData.m_Buffer;
		  v68 = 1065353216;
		  v6 = (__m128)_mm_loadu_si128((const __m128i *)&m_Buffer[16 * v3]);
		  v66 = v6.m128_i32[0];
		  LODWORD(v67) = _mm_shuffle_ps(v6, v6, 85).m128_u32[0];
		  HIDWORD(v67) = _mm_shuffle_ps(v6, v6, 170).m128_u32[0];
		  *(_QWORD *)&v65[4] = v67;
		  c1 = this->viewProjection.c1;
		  v83[0] = this->viewProjection.c0;
		  c2 = this->viewProjection.c2;
		  v83[1] = c1;
		  *(_DWORD *)v65 = v6.m128_i32[0];
		  v83[3] = this->viewProjection.c3;
		  v81 = v6;
		  v83[2] = c2;
		  v9 = (__m128)_mm_loadu_si128((const __m128i *)sub_182F3DE20(v82, v83, &v66));
		  v10 = v9;
		  c1.x = _mm_shuffle_ps(v9, v9, 255).m128_f32[0];
		  v10.m128_f32[0] = v9.m128_f32[0] / c1.x;
		  v11 = _mm_shuffle_ps(v9, v9, 85);
		  v11.m128_f32[0] = v11.m128_f32[0] / c1.x;
		  v15 = sub_1858CACF0(_mm_unpacklo_ps(v10, v11).m128_u64[0], v12, v13, v14);
		  v85 = ((__int64 (__fastcall *)(_QWORD))sub_186689CC0)(v15);
		  v17 = (__m128)HIDWORD(v85);
		  if ( this->graphicsUVStartsAtTop )
		  {
		    v16.m128_f32[0] = v16.m128_f32[0] - *((float *)&v85 + 1);
		    v17 = v16;
		  }
		  v18 = sub_185EDCFF4(
		          _mm_unpacklo_ps((__m128)(unsigned int)v85, v17).m128_u64[0],
		          _mm_unpacklo_ps(
		            (__m128)COERCE_UNSIGNED_INT((float)this->actualWidth),
		            (__m128)COERCE_UNSIGNED_INT((float)this->actualHeight)).m128_u64[0]);
		  v19 = *(_QWORD *)&this->xIntersectionRange.m_Buffer[8 * v3];
		  v20 = *(_QWORD *)&this->yIntersectionRange.m_Buffer[8 * v3];
		  v63 = HIDWORD(v19);
		  v70 = v20;
		  v69 = v20;
		  v21 = (int)*(float *)&v18 / this->tileSize;
		  v59 = v21;
		  v60 = (int)*((float *)&v18 + 1) / this->tileSize;
		  if ( v60 >= this->numTilesY || v60 < 0 || (v22 = v19, (int)v19 >= SHIDWORD(v19)) )
		  {
		    v23 = 0;
		    v24 = 0;
		    v86 = 0;
		    if ( v60 < 0 )
		    {
		      v25 = 0;
		      goto LABEL_12;
		    }
		  }
		  else
		  {
		    do
		    {
		      _InterlockedAdd(&this->tileLightMask[v22 + this->numTilesX * v60], 1 << (((int)v3 % 32) & 0x1F));
		      ++v22;
		    }
		    while ( v22 < SHIDWORD(v19) );
		    v23 = 0;
		    v24 = 0;
		    v86 = 0;
		  }
		  v25 = v20 + 1;
		LABEL_12:
		  v61 = v25;
		  if ( v60 >= this->numTilesY )
		    v26 = this->numTilesY + 1;
		  else
		    v26 = HIDWORD(v69) - 1;
		  v62 = v26;
		  v27 = v25;
		  if ( v25 <= v26 )
		  {
		    v28 = HIDWORD(v19);
		    v29 = v19 + 1;
		    v30 = ((int)v3 % 32) & 0x1F;
		    v64 = v29;
		    do
		    {
		      v31 = v29;
		      numTilesX = this->numTilesX;
		      if ( v29 <= v28 )
		      {
		        while ( 1 )
		        {
		          v32 = this->numTilesX + 1;
		          *(_QWORD *)&v73.x = *(_QWORD *)v65;
		          v33 = 3LL * (v31 + v27 * v32);
		          v34 = this->tileVertices.m_Buffer;
		          v35 = *(_QWORD *)&v34[4 * v33];
		          v72 = *(_DWORD *)&v34[4 * v33 + 8];
		          v73.z = *(float *)&v65[8];
		          v71 = v35;
		          v36 = sub_1834C8E00(v82, &v71);
		          v37 = *(_QWORD *)v36;
		          v74.z = *(float *)(v36 + 8);
		          *(_QWORD *)&v74.x = v37;
		          static_fields = TypeInfo::Unity::Mathematics::float3->static_fields;
		          v39 = *(_QWORD *)&static_fields->zero.x;
		          *(float *)&static_fields = static_fields->zero.z;
		          *(_QWORD *)&v75.x = v39;
		          LODWORD(v75.z) = (_DWORD)static_fields;
		          if ( HG::Rendering::Runtime::GeometryUtils::IntersectRaySphere(&v75, &v74, &v73, v81.m128_f32[3], 0, 0LL) )
		            break;
		          if ( ++v31 > v63 )
		            goto LABEL_22;
		        }
		        numTilesX = v31;
		      }
		LABEL_22:
		      v40 = v63 - 1;
		      if ( v63 - 1 < 0 )
		      {
		LABEL_25:
		        v49 = 0;
		      }
		      else
		      {
		        while ( 1 )
		        {
		          v41 = this->numTilesX + 1;
		          *(_QWORD *)&v78.x = *(_QWORD *)v65;
		          v42 = 3LL * (v40 + v27 * v41);
		          v43 = this->tileVertices.m_Buffer;
		          v44 = *(_QWORD *)&v43[4 * v42];
		          v77 = *(_DWORD *)&v43[4 * v42 + 8];
		          v78.z = *(float *)&v65[8];
		          v76 = v44;
		          v45 = sub_1834C8E00(&v66, &v76);
		          v46 = *(_QWORD *)v45;
		          v79.z = *(float *)(v45 + 8);
		          *(_QWORD *)&v79.x = v46;
		          v47 = TypeInfo::Unity::Mathematics::float3->static_fields;
		          v48 = *(_QWORD *)&v47->zero.x;
		          *(float *)&v47 = v47->zero.z;
		          *(_QWORD *)&v80.x = v48;
		          LODWORD(v80.z) = (_DWORD)v47;
		          if ( HG::Rendering::Runtime::GeometryUtils::IntersectRaySphere(&v80, &v79, &v78, v81.m128_f32[3], 0, 0LL) )
		            break;
		          if ( --v40 < 0 )
		            goto LABEL_25;
		        }
		        v49 = v40;
		      }
		      v50 = v27;
		      if ( v27 <= v60 )
		        v50 = v27 - 1;
		      v51 = 0;
		      v52 = v49 + 1;
		      if ( numTilesX - 1 >= 0 )
		        v51 = numTilesX - 1;
		      v53 = v51;
		      if ( v52 >= this->numTilesX )
		        v52 = this->numTilesX;
		      if ( v51 < v52 )
		      {
		        do
		        {
		          _InterlockedAdd(&this->tileLightMask[v53 + this->numTilesX * v50], 1 << v30);
		          ++v53;
		        }
		        while ( v53 < v52 );
		      }
		      v54 = v52 - v51;
		      if ( v27 != v61 )
		        v54 = v24;
		      v24 = v54;
		      v28 = v63;
		      v23 = v52 - v51;
		      v29 = v64;
		      if ( v27 != v62 )
		        v23 = v86;
		      ++v27;
		      v86 = v23;
		    }
		    while ( v27 <= v62 );
		    LODWORD(v20) = v70;
		    LODWORD(v3) = lightIndex;
		    v21 = v59;
		    v86 = v23;
		  }
		  if ( (int)v20 < v60 && v24 < 1 )
		  {
		    _InterlockedAdd(&this->tileLightMask[v21 + this->numTilesX * (int)v20], 1 << (((int)v3 % 32) & 0x1F));
		    v23 = v86;
		  }
		  if ( HIDWORD(v69) - 2 == v60 && HIDWORD(v69) - 1 > (int)v20 && v23 < 1 )
		    _InterlockedAdd(&this->tileLightMask[v21 + this->numTilesX * (HIDWORD(v69) - 1)], 1 << (((int)v3 % 32) & 0x1F));
		}
		
	}
}
