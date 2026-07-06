using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	public static class HGRainRendererUtils
	{
		internal static float CalculateTemporalWeightByDeltaTime(float temporalTimeThreshould, float deltaTime)
		{
			// // Single CalculateTemporalWeightByDeltaTime(Single, Single)
			// float HG::Rendering::Runtime::Rain::HGRainRendererUtils::CalculateTemporalWeightByDeltaTime(
			//         float temporalTimeThreshould,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Beyond::JobMathf *v4; // rcx
			//   double v5; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(740, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(740, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//                       (ILFixDynamicMethodWrapper_3 *)Patch,
			//                       temporalTimeThreshould,
			//                       deltaTime,
			//                       0LL);
			//   }
			//   else if ( deltaTime < COERCE_FLOAT(1) )
			//   {
			//     LODWORD(v5) = 0;
			//   }
			//   else
			//   {
			//     if ( (int)sub_1826E82D0() <= 0 )
			//       LODWORD(v5) = 0;
			//     else
			//       v5 = sub_1802EB1B0((_DWORD)v4, v3);
			//     Beyond::JobMathf::Clamp01(v4);
			//   }
			//   return *(float *)&v5;
			// }
			// 
			return 0f;
		}

		internal static Mesh GetScreenDropNormalizedQuad()
		{
			// // Mesh GetScreenDropNormalizedQuad()
			// Mesh *HG::Rendering::Runtime::Rain::HGRainRendererUtils::GetScreenDropNormalizedQuad(MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   __int64 v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Vector3__Array *v6; // rsi
			//   __int64 v7; // r8
			//   __int64 v8; // r9
			//   __int64 v9; // rax
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   Vector2__Array *v12; // rbx
			//   Array *v13; // r14
			//   Mesh *v14; // rax
			//   Mesh *v15; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v18; // [rsp+20h] [rbp-40h] BYREF
			//   int v19; // [rsp+28h] [rbp-38h]
			// 
			//   if ( !byte_18D919D44 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&4F3A974D03B4939FC26A965844D8E5F89E151FF80F59BB8AF511CC703F5DA157_Field);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18C9B3B28);
			//     byte_18D919D44 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4781, 0LL) )
			//   {
			//     v3 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 4LL, v1, v2);
			//     v6 = (Vector3__Array *)v3;
			//     if ( v3 )
			//     {
			//       v19 = 0;
			//       v18 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0xBF000000).m128_u64[0];
			//       sub_180040FA0(v3, 0LL, &v18);
			//       v19 = 0;
			//       v18 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0x3F000000u).m128_u64[0];
			//       sub_180040FA0(v6, 1LL, &v18);
			//       v19 = 0;
			//       v18 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0xBF000000).m128_u64[0];
			//       sub_180040FA0(v6, 2LL, &v18);
			//       v19 = 0;
			//       v18 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u).m128_u64[0];
			//       sub_180040FA0(v6, 3LL, &v18);
			//       v9 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector2, 4LL, v7, v8);
			//       v12 = (Vector2__Array *)v9;
			//       if ( v9 )
			//       {
			//         if ( !*(_DWORD *)(v9 + 24)
			//           || (*(_DWORD *)(v9 + 32) = 0, *(_DWORD *)(v9 + 36) = 0, *(_DWORD *)(v9 + 24) <= 1u)
			//           || (*(_DWORD *)(v9 + 40) = 0, *(_DWORD *)(v9 + 44) = 1065353216, *(_DWORD *)(v9 + 24) <= 2u)
			//           || (*(_QWORD *)(v9 + 48) = 1065353216LL, *(_DWORD *)(v9 + 24) <= 3u) )
			//         {
			//           sub_180070270(v5, v4);
			//         }
			//         *(_DWORD *)(v9 + 56) = 1065353216;
			//         *(_DWORD *)(v9 + 60) = 1065353216;
			//         v13 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 6LL, v10, v11);
			//         System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//           v13,
			//           4F3A974D03B4939FC26A965844D8E5F89E151FF80F59BB8AF511CC703F5DA157_Field,
			//           0LL);
			//         v14 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//         v15 = v14;
			//         if ( v14 )
			//         {
			//           UnityEngine::Mesh::Mesh(v14, 0LL);
			//           UnityEngine::Mesh::set_vertices(v15, v6, 0LL);
			//           UnityEngine::Mesh::set_uv(v15, v12, 0LL);
			//           UnityEngine::Mesh::set_triangles(v15, (Int32__Array *)v13, 0LL);
			//           UnityEngine::Object::set_name((Object_1 *)v15, (String *)"ScreenRainQuad", 0LL);
			//           UnityEngine::Object::set_hideFlags((Object_1 *)v15, HideFlags__Enum_HideAndDontSave, 0LL);
			//           UnityEngine::Mesh::UploadMeshData(v15, 1, 0LL);
			//           return v15;
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4781, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			// }
			// 
			return null;
		}

		internal static Mesh GetScreenDropQuadSeq()
		{
			// // Mesh GetScreenDropQuadSeq()
			// Mesh *HG::Rendering::Runtime::Rain::HGRainRendererUtils::GetScreenDropQuadSeq(MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   Vector3__Array *v3; // rsi
			//   __int64 v4; // r8
			//   __int64 v5; // r9
			//   Vector2__Array *v6; // rdi
			//   __int64 v7; // r8
			//   __int64 v8; // r9
			//   __int64 v9; // rcx
			//   Int32__Array *v10; // rbx
			//   float v11; // xmm1_4
			//   int v12; // r8d
			//   __int64 v13; // rdx
			//   int v14; // r9d
			//   __int64 v15; // rax
			//   __int64 v16; // rax
			//   __int64 v17; // rax
			//   __int64 v18; // rax
			//   __int64 v19; // rax
			//   __int64 v20; // rax
			//   int32_t v21; // eax
			//   Mesh *v22; // rax
			//   Mesh *v23; // rbp
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC28 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18C9B3B28);
			//     byte_18D8EDC28 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1317, 0LL) )
			//   {
			//     v3 = (Vector3__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 120LL, v1, v2);
			//     v6 = (Vector2__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector2, 120LL, v4, v5);
			//     v10 = (Int32__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 180LL, v7, v8);
			//     v11 = 0.0;
			//     v12 = 0;
			//     v13 = 0LL;
			//     v14 = 0;
			//     if ( v3 )
			//     {
			//       while ( 1 )
			//       {
			//         if ( (unsigned int)v13 >= v3.max_length.size )
			//           goto LABEL_26;
			//         v9 = 3LL * (int)v13;
			//         v15 = (int)v13 + 1LL;
			//         *(_QWORD *)(&v3.vector[0].x + v9) = 0xBF000000BF000000uLL;
			//         *(&v3.vector[0].z + v9) = v11;
			//         if ( (unsigned int)v15 >= v3.max_length.size )
			//           goto LABEL_26;
			//         v9 = 3 * v15;
			//         *(_QWORD *)(&v3.vector[0].x + v9) = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0x3F000000u).m128_u64[0];
			//         *(&v3.vector[0].z + v9) = (float)v14;
			//         v16 = (int)v13 + 2LL;
			//         if ( (unsigned int)v16 >= v3.max_length.size )
			//           goto LABEL_26;
			//         v9 = 3 * v16;
			//         *(_QWORD *)(&v3.vector[0].x + v9) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0xBF000000).m128_u64[0];
			//         *(&v3.vector[0].z + v9) = (float)v14;
			//         v17 = (int)v13 + 3LL;
			//         if ( (unsigned int)v17 >= v3.max_length.size )
			//           goto LABEL_26;
			//         v9 = 3 * v17;
			//         *(_QWORD *)(&v3.vector[0].x + v9) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u).m128_u64[0];
			//         *(&v3.vector[0].z + v9) = (float)v14;
			//         if ( !v6 )
			//           goto LABEL_25;
			//         if ( (unsigned int)v13 >= v6.max_length.size )
			//           goto LABEL_26;
			//         v6.vector[(int)v13] = 0LL;
			//         v18 = (int)v13 + 1LL;
			//         if ( (unsigned int)v18 >= v6.max_length.size )
			//           goto LABEL_26;
			//         v6.vector[v18].x = 0.0;
			//         v6.vector[v18].y = 1.0;
			//         v19 = (int)v13 + 2LL;
			//         if ( (unsigned int)v19 >= v6.max_length.size )
			//           goto LABEL_26;
			//         v6.vector[v19] = (Vector2)1065353216LL;
			//         v20 = (int)v13 + 3LL;
			//         if ( (unsigned int)v20 >= v6.max_length.size )
			//           goto LABEL_26;
			//         v6.vector[v20].x = 1.0;
			//         v6.vector[v20].y = 1.0;
			//         if ( !v10 )
			//           goto LABEL_25;
			//         if ( (unsigned int)v12 >= v10.max_length.size )
			//           goto LABEL_26;
			//         v9 = v12 + 1LL;
			//         v10.vector[v12] = v13;
			//         if ( (unsigned int)v9 >= v10.max_length.size )
			//           goto LABEL_26;
			//         v10.vector[v9] = v13 + 1;
			//         v9 = v12 + 2LL;
			//         if ( (unsigned int)v9 >= v10.max_length.size
			//           || (v10.vector[v9] = v13 + 2, v9 = v12 + 3LL, (unsigned int)v9 >= v10.max_length.size)
			//           || (v10.vector[v9] = v13 + 3, v9 = v12 + 4LL, (unsigned int)v9 >= v10.max_length.size)
			//           || (v10.vector[v9] = v13 + 2, v9 = v12 + 5LL, (unsigned int)v9 >= v10.max_length.size) )
			//         {
			// LABEL_26:
			//           sub_180070270(v9, v13);
			//         }
			//         v21 = v13 + 1;
			//         ++v14;
			//         v13 = (unsigned int)(v13 + 4);
			//         v10.vector[v9] = v21;
			//         v12 += 6;
			//         if ( v12 >= 180 )
			//           break;
			//         v11 = (float)v14;
			//       }
			//       v22 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//       v23 = v22;
			//       if ( v22 )
			//       {
			//         UnityEngine::Mesh::Mesh(v22, 0LL);
			//         UnityEngine::Mesh::set_vertices(v23, v3, 0LL);
			//         UnityEngine::Mesh::set_uv(v23, v6, 0LL);
			//         UnityEngine::Mesh::set_triangles(v23, v10, 0LL);
			//         UnityEngine::Object::set_name((Object_1 *)v23, (String *)"ScreenRainQuad", 0LL);
			//         UnityEngine::Object::set_hideFlags((Object_1 *)v23, HideFlags__Enum_HideAndDontSave, 0LL);
			//         UnityEngine::Mesh::UploadMeshData(v23, 1, 0LL);
			//         return v23;
			//       }
			//     }
			// LABEL_25:
			//     sub_180B536AC(v9, v13);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1317, 0LL);
			//   if ( !Patch )
			//     goto LABEL_25;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			// }
			// 
			return null;
		}
	}
}
