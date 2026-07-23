using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class ASMUtils // TypeDefIndex: 37813
	{
		// Constructors
		public ASMUtils() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static bool IsTileFrustumIntersecting(NativeArray<Vector2> frustumVerts, Vector2 tileMins, Vector2 tileMaxs) => default; // 0x0000000189D06D40-0x0000000189D070A0
		// Boolean IsTileFrustumIntersecting(NativeArray`1[UnityEngine.Vector2], Vector2, Vector2)
		bool HG::Rendering::Runtime::ASMUtils::IsTileFrustumIntersecting(
		        NativeArray_1_UnityEngine_Vector2_ *frustumVerts,
		        Vector2 tileMins,
		        Vector2 tileMaxs,
		        MethodInfo *method)
		{
		  int v7; // ebx
		  float *m_Buffer; // rdx
		  __int64 v9; // r11
		  char v10; // r8
		  char v11; // r9
		  char v12; // r10
		  char v13; // cl
		  float v14; // xmm0_4
		  float v15; // xmm1_4
		  Void *v16; // rsi
		  __int64 v17; // rax
		  __m128 v18; // xmm1
		  __m128 v19; // xmm2
		  unsigned __int64 v20; // xmm8_8
		  __int64 v21; // rax
		  float v22; // xmm3_4
		  float v23; // xmm2_4
		  float v24; // xmm6_4
		  Void *v25; // r8
		  Void *v26; // r8
		  __int64 v27; // r9
		  float v28; // xmm4_4
		  float v29; // xmm7_4
		  float v30; // xmm4_4
		  float v31; // xmm5_4
		  float v32; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  float v37; // [rsp+34h] [rbp-C4h]
		  NativeArray_1_UnityEngine_Vector2_ v40; // [rsp+60h] [rbp-98h] BYREF
		
		  v7 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2039, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2039, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v36, v35);
		    v40 = *frustumVerts;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_814(Patch, &v40, tileMins, tileMaxs, 0LL);
		  }
		  else
		  {
		    m_Buffer = (float *)frustumVerts->m_Buffer;
		    v9 = 5LL;
		    v10 = 1;
		    v11 = 1;
		    v12 = 1;
		    v13 = 1;
		    do
		    {
		      v14 = *m_Buffer;
		      v15 = m_Buffer[1];
		      m_Buffer += 2;
		      v10 &= v14 > tileMaxs.x;
		      v11 &= v15 > tileMaxs.y;
		      v12 &= tileMins.x > v14;
		      v13 &= tileMins.y > v15;
		      --v9;
		    }
		    while ( v9 );
		    if ( !((unsigned __int8)v10 | (unsigned __int8)(v11 | v12 | v13)) )
		    {
		      v16 = frustumVerts->m_Buffer;
		      v40.m_Buffer = (Void *)tileMaxs;
		      while ( 1 )
		      {
		        if ( v7 >= 4 )
		        {
		          v18 = (__m128)*(_DWORD *)v16;
		          v19 = (__m128)*(unsigned int *)&v16[4];
		        }
		        else
		        {
		          v17 = (v7 + 1) % 4;
		          v18 = (__m128)*(unsigned int *)&v16[8 * v17 + 8];
		          v19 = (__m128)*(unsigned int *)&v16[8 * v17 + 12];
		        }
		        v20 = _mm_unpacklo_ps((__m128)*(_DWORD *)&v16[8 * (v7 % 4) + 8], (__m128)*(_DWORD *)&v16[8 * (v7 % 4) + 12]).m128_u64[0];
		        v40.m_Buffer = (Void *)sub_1858CAD18(_mm_unpacklo_ps(v18, v19).m128_u64[0], v20);
		        v21 = sub_182FA2990(&v40);
		        v37 = *((float *)&v21 + 1);
		        v22 = 0.0;
		        v23 = 0.0;
		        v24 = -*(float *)&v21;
		        v25 = v16;
		        do
		        {
		          v40.m_Buffer = (Void *)sub_1858CAD18(
		                                   _mm_unpacklo_ps((__m128)*(_DWORD *)v25, (__m128)*(_DWORD *)&v25[4]).m128_u64[0],
		                                   v20);
		          v28 = (float)(*((float *)&v40.m_Buffer + 1) * v24) + (float)(*(float *)&v40.m_Buffer * v37);
		          if ( v28 <= v22 )
		            v22 = (float)(*((float *)&v40.m_Buffer + 1) * v24) + (float)(*(float *)&v40.m_Buffer * v37);
		          if ( v23 <= v28 )
		            v23 = (float)(*((float *)&v40.m_Buffer + 1) * v24) + (float)(*(float *)&v40.m_Buffer * v37);
		          v25 = v26 + 8;
		        }
		        while ( v27 != 1 );
		        v40.m_Buffer = (Void *)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(tileMins, v20);
		        v29 = (float)(*((float *)&v40.m_Buffer + 1) * v24) + (float)(*(float *)&v40.m_Buffer * v37);
		        v40.m_Buffer = (Void *)sub_1858CAD18(__PAIR64__(LODWORD(tileMaxs.y), LODWORD(tileMins.x)), v20);
		        v40.m_Buffer = (Void *)sub_1858CAD18(__PAIR64__(LODWORD(tileMins.y), LODWORD(tileMaxs.x)), v20);
		        v40.m_Buffer = (Void *)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(tileMaxs, v20);
		        v32 = (float)(*((float *)&v40.m_Buffer + 1) * v24) + (float)(*(float *)&v40.m_Buffer * v37);
		        if ( v22 > v29 && v22 > v30 && v22 > v31 && v22 > v32 )
		          break;
		        if ( v29 > v23 && v30 > v23 && v31 > v23 && v32 > v23 )
		          break;
		        if ( ++v7 >= 8 )
		          return 1;
		      }
		    }
		    return 0;
		  }
		}
		
		public static float ASMTileDistance(ASMTile tile, Vector2 position) => default; // 0x0000000189D06C34-0x0000000189D06D40
		// Single ASMTileDistance(ASMTile, Vector2)
		float HG::Rendering::Runtime::ASMUtils::ASMTileDistance(ASMTile *tile, Vector2 position, MethodInfo *method)
		{
		  Vector2 v5; // r8
		  Vector2 v6; // r9
		  __m128 v7; // xmm3
		  Vector2 v8; // rax
		  Vector2 v9; // rdx
		  Vector2 v10; // r8
		  int32_t v11; // r9d
		  Vector2 v12; // rax
		  double v13; // xmm0_8
		  __int64 v15; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  ASMTile v19; // [rsp+20h] [rbp-60h] BYREF
		  __int64 v20; // [rsp+A8h] [rbp+28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2040, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2040, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v15);
		    v17 = *(_OWORD *)&tile->mins.x;
		    v18 = *(_OWORD *)&tile->tileCoords.m_X;
		    v19.vtIndex = tile->vtIndex;
		    *(_OWORD *)&v19.mins.x = v17;
		    *(_OWORD *)&v19.tileCoords.m_X = v18;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_815(Patch, &v19, position, 0LL);
		  }
		  else
		  {
		    v7 = *(__m128 *)&tile->mins.x;
		    v8 = sub_1853DF234(
		           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                  *(__m128 *)&tile->mins.x,
		                                  _mm_shuffle_ps(*(__m128 *)&tile->mins.x, *(__m128 *)&tile->mins.x, 85)),
		           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                  _mm_shuffle_ps(*(__m128 *)&tile->mins.x, *(__m128 *)&tile->mins.x, 170),
		                                  _mm_shuffle_ps(v7, v7, 255)),
		           v5,
		           v6);
		    v12 = sub_1858CACF0(v8, v9, v10, v11);
		    v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(v12, position);
		    v13 = sub_182FA2AF0(&v20);
		    return *(float *)&v13 - (float)((float)(tile->maxs.x - v7.m128_f32[0]) * 0.80000001);
		  }
		}
		
		public static int TileCoordsToKey(Vector3Int tileCoords) => default; // 0x0000000189D07140-0x0000000189D071AC
		// Int32 TileCoordsToKey(Vector3Int)
		int32_t HG::Rendering::Runtime::ASMUtils::TileCoordsToKey(Vector3Int *tileCoords, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int32_t m_Z; // eax
		  Vector3Int v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2041, 0LL) )
		    return tileCoords->m_Z + 4 * (tileCoords->m_Y + (tileCoords->m_X << 15)) - 2147418112;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2041, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  m_Z = tileCoords->m_Z;
		  *(_QWORD *)&v7.m_X = *(_QWORD *)&tileCoords->m_X;
		  v7.m_Z = m_Z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_816(Patch, &v7, 0LL);
		}
		
		public static Vector3Int KeyToTileCoords(int key) => default; // 0x0000000189D070A0-0x0000000189D07140
		// Vector3Int KeyToTileCoords(Int32)
		Vector3Int *HG::Rendering::Runtime::ASMUtils::KeyToTileCoords(
		        Vector3Int *__return_ptr retstr,
		        int32_t key,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3Int *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3Int v11[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2042, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2042, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_817(v11, Patch, key, 0LL);
		    v9 = *(_QWORD *)&v8->m_X;
		    LODWORD(v8) = v8->m_Z;
		    *(_QWORD *)&retstr->m_X = v9;
		    retstr->m_Z = (int)v8;
		  }
		  else
		  {
		    retstr->m_X = key / 0x20000 - 0x4000;
		    retstr->m_Y = key % 0x20000 / 4 - 0x4000;
		    retstr->m_Z = key % 4;
		  }
		  return retstr;
		}
		
	}
}
