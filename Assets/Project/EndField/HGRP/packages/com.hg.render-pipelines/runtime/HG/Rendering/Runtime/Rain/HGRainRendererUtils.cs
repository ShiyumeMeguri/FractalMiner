using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public static class HGRainRendererUtils // TypeDefIndex: 38848
	{
		// Methods
		internal static float CalculateTemporalWeightByDeltaTime(float temporalTimeThreshold, float deltaTime) => default; // 0x0000000189C7803C-0x0000000189C780E8
		// Single CalculateTemporalWeightByDeltaTime(Single, Single)
		float HG::Rendering::Runtime::Rain::HGRainRendererUtils::CalculateTemporalWeightByDeltaTime(
		        float temporalTimeThreshold,
		        float deltaTime,
		        MethodInfo *method)
		{
		  int v3; // eax
		  Beyond::JobMathf *v4; // rcx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(808, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(808, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, temporalTimeThreshold, deltaTime, 0LL);
		  }
		  else if ( deltaTime < COERCE_FLOAT(1) )
		  {
		    LODWORD(v5) = 0;
		  }
		  else
		  {
		    v3 = sub_1832DBD50();
		    if ( v3 <= 0 )
		    {
		      LODWORD(v5) = 0;
		    }
		    else
		    {
		      deltaTime = 1.0 / (float)v3;
		      v5 = sub_1803369A0();
		    }
		    Beyond::JobMathf::Clamp01(v4, deltaTime);
		  }
		  return *(float *)&v5;
		}
		
		internal static Mesh GetScreenDropNormalizedQuad() => default; // 0x0000000189C780E8-0x0000000189C7832C
		// Mesh GetScreenDropNormalizedQuad()
		Mesh *HG::Rendering::Runtime::Rain::HGRainRendererUtils::GetScreenDropNormalizedQuad(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Vector3__Array *v4; // rsi
		  __int64 v5; // rax
		  Vector2__Array *v6; // rbx
		  Array *v7; // r14
		  Mesh *v8; // rax
		  Mesh *v9; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v12; // [rsp+20h] [rbp-40h] BYREF
		  int v13; // [rsp+28h] [rbp-38h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5479, 0LL) )
		  {
		    v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		    v4 = (Vector3__Array *)v1;
		    if ( v1 )
		    {
		      v13 = 0;
		      v12 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0xBF000000).m128_u64[0];
		      sub_180049BD0(v1, 0LL, &v12);
		      v13 = 0;
		      v12 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0x3F000000u).m128_u64[0];
		      sub_180049BD0(v4, 1LL, &v12);
		      v13 = 0;
		      v12 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0xBF000000).m128_u64[0];
		      sub_180049BD0(v4, 2LL, &v12);
		      v13 = 0;
		      v12 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u).m128_u64[0];
		      sub_180049BD0(v4, 3LL, &v12);
		      v5 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 4LL);
		      v6 = (Vector2__Array *)v5;
		      if ( v5 )
		      {
		        if ( !*(_DWORD *)(v5 + 24)
		          || (*(_DWORD *)(v5 + 32) = 0, *(_DWORD *)(v5 + 36) = 0, *(_DWORD *)(v5 + 24) <= 1u)
		          || (*(_DWORD *)(v5 + 40) = 0, *(_DWORD *)(v5 + 44) = 1065353216, *(_DWORD *)(v5 + 24) <= 2u)
		          || (*(_QWORD *)(v5 + 48) = 1065353216LL, *(_DWORD *)(v5 + 24) <= 3u) )
		        {
		          sub_1800D2AB0(v3, v2);
		        }
		        *(_DWORD *)(v5 + 56) = 1065353216;
		        *(_DWORD *)(v5 + 60) = 1065353216;
		        v7 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		        System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		          v7,
		          4F3A974D03B4939FC26A965844D8E5F89E151FF80F59BB8AF511CC703F5DA157_Field,
		          0LL);
		        v8 = (Mesh *)sub_18002C620(TypeInfo::UnityEngine::Mesh);
		        v9 = v8;
		        if ( v8 )
		        {
		          UnityEngine::Mesh::Mesh(v8, 0LL);
		          UnityEngine::Mesh::set_vertices(v9, v4, 0LL);
		          UnityEngine::Mesh::set_uv(v9, v6, 0LL);
		          UnityEngine::Mesh::set_triangles(v9, (Int32__Array *)v7, 0LL);
		          UnityEngine::Object::set_name((Object_1 *)v9, (String *)"ScreenRainQuad", 0LL);
		          UnityEngine::Object::set_hideFlags((Object_1 *)v9, HideFlags__Enum_HideAndDontSave, 0LL);
		          UnityEngine::Mesh::UploadMeshData(v9, 1, 0LL);
		          return v9;
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5479, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
		internal static Mesh GetScreenDropQuadSeq() => default; // 0x00000001833B3520-0x00000001833B3830
		// Mesh GetScreenDropQuadSeq()
		Mesh *HG::Rendering::Runtime::Rain::HGRainRendererUtils::GetScreenDropQuadSeq(MethodInfo *method)
		{
		  Vector3__Array *v1; // rsi
		  Vector2__Array *v2; // rdi
		  __int64 v3; // rcx
		  Int32__Array *v4; // rbx
		  float v5; // xmm1_4
		  int v6; // r8d
		  __int64 v7; // rdx
		  int v8; // r9d
		  __int64 v9; // rax
		  __int64 v10; // rax
		  __int64 v11; // rax
		  __int64 v12; // rax
		  __int64 v13; // rax
		  __int64 v14; // rax
		  int32_t v15; // eax
		  Mesh *v16; // rax
		  Mesh *v17; // rbp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1573, 0LL) )
		  {
		    v1 = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 120LL);
		    v2 = (Vector2__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 120LL);
		    v4 = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 180LL);
		    v5 = 0.0;
		    v6 = 0;
		    v7 = 0LL;
		    v8 = 0;
		    if ( v1 )
		    {
		      while ( 1 )
		      {
		        if ( (unsigned int)v7 >= v1->max_length.size )
		          goto LABEL_24;
		        v3 = 3LL * (int)v7;
		        v9 = (int)v7 + 1LL;
		        *(_QWORD *)(&v1->vector[0].x + v3) = 0xBF000000BF000000uLL;
		        *(&v1->vector[0].z + v3) = v5;
		        if ( (unsigned int)v9 >= v1->max_length.size )
		          goto LABEL_24;
		        v3 = 3 * v9;
		        *(_QWORD *)(&v1->vector[0].x + v3) = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0x3F000000u).m128_u64[0];
		        *(&v1->vector[0].z + v3) = (float)v8;
		        v10 = (int)v7 + 2LL;
		        if ( (unsigned int)v10 >= v1->max_length.size )
		          goto LABEL_24;
		        v3 = 3 * v10;
		        *(_QWORD *)(&v1->vector[0].x + v3) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0xBF000000).m128_u64[0];
		        *(&v1->vector[0].z + v3) = (float)v8;
		        v11 = (int)v7 + 3LL;
		        if ( (unsigned int)v11 >= v1->max_length.size )
		          goto LABEL_24;
		        v3 = 3 * v11;
		        *(_QWORD *)(&v1->vector[0].x + v3) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u).m128_u64[0];
		        *(&v1->vector[0].z + v3) = (float)v8;
		        if ( !v2 )
		          goto LABEL_21;
		        if ( (unsigned int)v7 >= v2->max_length.size )
		          goto LABEL_24;
		        v2->vector[(int)v7] = 0LL;
		        v12 = (int)v7 + 1LL;
		        if ( (unsigned int)v12 >= v2->max_length.size )
		          goto LABEL_24;
		        v2->vector[v12].x = 0.0;
		        v2->vector[v12].y = 1.0;
		        v13 = (int)v7 + 2LL;
		        if ( (unsigned int)v13 >= v2->max_length.size )
		          goto LABEL_24;
		        v2->vector[v13] = (Vector2)1065353216LL;
		        v14 = (int)v7 + 3LL;
		        if ( (unsigned int)v14 >= v2->max_length.size )
		          goto LABEL_24;
		        v2->vector[v14].x = 1.0;
		        v2->vector[v14].y = 1.0;
		        if ( !v4 )
		          goto LABEL_21;
		        if ( (unsigned int)v6 >= v4->max_length.size )
		          goto LABEL_24;
		        v3 = v6 + 1LL;
		        v4->vector[v6] = v7;
		        if ( (unsigned int)v3 >= v4->max_length.size )
		          goto LABEL_24;
		        v4->vector[v3] = v7 + 1;
		        v3 = v6 + 2LL;
		        if ( (unsigned int)v3 >= v4->max_length.size
		          || (v4->vector[v3] = v7 + 2, v3 = v6 + 3LL, (unsigned int)v3 >= v4->max_length.size)
		          || (v4->vector[v3] = v7 + 3, v3 = v6 + 4LL, (unsigned int)v3 >= v4->max_length.size)
		          || (v4->vector[v3] = v7 + 2, v3 = v6 + 5LL, (unsigned int)v3 >= v4->max_length.size) )
		        {
		LABEL_24:
		          sub_1800D2AB0(v3, v7);
		        }
		        v15 = v7 + 1;
		        ++v8;
		        v7 = (unsigned int)(v7 + 4);
		        v4->vector[v3] = v15;
		        v6 += 6;
		        if ( v6 >= 180 )
		          break;
		        v5 = (float)v8;
		      }
		      v16 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		      v17 = v16;
		      if ( v16 )
		      {
		        UnityEngine::Mesh::Mesh(v16, 0LL);
		        UnityEngine::Mesh::set_vertices(v17, v1, 0LL);
		        UnityEngine::Mesh::set_uv(v17, v2, 0LL);
		        UnityEngine::Mesh::set_triangles(v17, v4, 0LL);
		        UnityEngine::Object::set_name((Object_1 *)v17, (String *)"ScreenRainQuad", 0LL);
		        UnityEngine::Object::set_hideFlags((Object_1 *)v17, HideFlags__Enum_HideAndDontSave, 0LL);
		        UnityEngine::Mesh::UploadMeshData(v17, 1, 0LL);
		        return v17;
		      }
		    }
		LABEL_21:
		    sub_1800D8260(v3, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1573, 0LL);
		  if ( !Patch )
		    goto LABEL_21;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
	}
}
