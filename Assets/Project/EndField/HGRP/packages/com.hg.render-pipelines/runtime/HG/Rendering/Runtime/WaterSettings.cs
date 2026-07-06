using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class WaterSettings
	{
		public static Mesh CreateQuad(int numVertsX, int numVertsY)
		{
			// // Mesh CreateQuad(Int32, Int32)
			// Mesh *HG::Rendering::Runtime::WaterSettings::CreateQuad(int32_t numVertsX, int32_t numVertsY, MethodInfo *method)
			// {
			//   __int64 v5; // r8
			//   __int64 v6; // r9
			//   Vector3__Array *v7; // rsi
			//   __int64 v8; // r9
			//   Vector2__Array *v9; // rdi
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   __int64 v12; // rax
			//   __int64 v13; // rdx
			//   int v14; // r11d
			//   __int64 v15; // rcx
			//   Int32__Array *v16; // rbx
			//   int v17; // r10d
			//   int v18; // r9d
			//   int v19; // r8d
			//   __m128 v20; // xmm2
			//   __m128 v21; // xmm1
			//   __int64 v22; // rax
			//   int32_t v23; // r9d
			//   int32_t v24; // r10d
			//   int v25; // r14d
			//   int v26; // r11d
			//   int32_t v27; // r8d
			//   int32_t v28; // r9d
			//   int32_t v29; // r9d
			//   __int64 v30; // rax
			//   unsigned int v31; // r9d
			//   int v32; // eax
			//   int v33; // ecx
			//   __int64 v34; // rax
			//   int32_t v35; // r9d
			//   int32_t v36; // r9d
			//   __int64 v37; // rax
			//   Mesh *v38; // rax
			//   Mesh *v39; // rbp
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDAD7 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18C8FC8E0);
			//     byte_18D8EDAD7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(961, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(961, 0LL);
			//     if ( !Patch )
			//       goto LABEL_30;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_354(Patch, numVertsX, numVertsY, 0LL);
			//   }
			//   else
			//   {
			//     v7 = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                              TypeInfo::UnityEngine::Vector3,
			//                              (unsigned int)((numVertsY + 1) * (numVertsX + 1)),
			//                              v5,
			//                              v6);
			//     v9 = (Vector2__Array *)il2cpp_array_new_specific_0(
			//                              TypeInfo::UnityEngine::Vector2,
			//                              (unsigned int)((numVertsX + 1) * (numVertsY + 1)),
			//                              (unsigned int)(numVertsX + 1),
			//                              v8);
			//     v12 = il2cpp_array_new_specific_0(TypeInfo::System::Int32, (unsigned int)(6 * numVertsY * numVertsX), v10, v11);
			//     v14 = 0;
			//     v15 = (unsigned int)(numVertsX + 1);
			//     v16 = (Int32__Array *)v12;
			//     if ( (int)v15 > 0 )
			//     {
			//       v17 = numVertsY + 1;
			//       v18 = numVertsX + 1;
			//       while ( 1 )
			//       {
			//         v19 = 0;
			//         if ( v17 > 0 )
			//           break;
			// LABEL_13:
			//         if ( ++v14 >= v18 )
			//           goto LABEL_14;
			//       }
			//       v13 = (unsigned int)v14;
			//       v20 = (__m128)COERCE_UNSIGNED_INT((float)v14);
			//       v20.m128_f32[0] = v20.m128_f32[0] / (float)numVertsX;
			//       while ( 1 )
			//       {
			//         v21 = (__m128)COERCE_UNSIGNED_INT((float)v19);
			//         v21.m128_f32[0] = v21.m128_f32[0] / (float)numVertsY;
			//         if ( !v9 )
			//           break;
			//         if ( (unsigned int)v13 >= v9.max_length.size )
			//           goto LABEL_42;
			//         LODWORD(v9.vector[(int)v13].x) = v20.m128_i32[0];
			//         LODWORD(v9.vector[(int)v13].y) = v21.m128_i32[0];
			//         if ( !v7 )
			//           break;
			//         if ( (unsigned int)v13 >= v7.max_length.size )
			// LABEL_42:
			//           sub_180070270(v15, v13);
			//         v22 = (int)v13;
			//         ++v19;
			//         v13 = (unsigned int)(v18 + v13);
			//         v15 = 3 * v22;
			//         *(_QWORD *)(&v7.vector[0].x + v15) = _mm_unpacklo_ps(v20, v21).m128_u64[0];
			//         *((_DWORD *)&v7.vector[0].z + v15) = 0;
			//         if ( v19 >= v17 )
			//           goto LABEL_13;
			//       }
			// LABEL_30:
			//       sub_180B536AC(v15, v13);
			//     }
			// LABEL_14:
			//     v23 = 0;
			//     v24 = 0;
			//     if ( numVertsX > 0 )
			//     {
			//       v25 = -1;
			//       v26 = numVertsX + 1;
			//       do
			//       {
			//         v27 = 0;
			//         if ( numVertsY > 0 )
			//         {
			//           v13 = (unsigned int)(v24 + 1);
			//           do
			//           {
			//             if ( (((_BYTE)v27 + (_BYTE)v24) & 1) != 0 )
			//             {
			//               if ( !v16 )
			//                 goto LABEL_30;
			//               if ( (unsigned int)v23 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v16.vector[v23] = v13 - 1;
			//               v15 = v23 + 1LL;
			//               if ( (unsigned int)v15 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v28 = v23 + 2;
			//               v16.vector[v15] = v13 + numVertsX;
			//               if ( (unsigned int)v28 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v15 = v28 + 1LL;
			//               v16.vector[v28] = v13;
			//               if ( (unsigned int)v15 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v29 = v28 + 2;
			//               v16.vector[v15] = v13 + numVertsX;
			//               if ( (unsigned int)v29 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v30 = v29;
			//               v15 = (unsigned int)(v13 + v26);
			//               v31 = v29 + 1;
			//               v16.vector[v30] = v15;
			//               if ( v31 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v32 = v25;
			//             }
			//             else
			//             {
			//               if ( !v16 )
			//                 goto LABEL_30;
			//               if ( (unsigned int)v23 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v16.vector[v23] = v13 - 1;
			//               v15 = v23 + 1LL;
			//               if ( (unsigned int)v15 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v35 = v23 + 2;
			//               v16.vector[v15] = v13 + v26;
			//               if ( (unsigned int)v35 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v15 = v35 + 1LL;
			//               v16.vector[v35] = v13;
			//               if ( (unsigned int)v15 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v36 = v35 + 2;
			//               v16.vector[v15] = v13 - 1;
			//               if ( (unsigned int)v36 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v37 = v36;
			//               v15 = (unsigned int)(v13 + numVertsX);
			//               v31 = v36 + 1;
			//               v16.vector[v37] = v15;
			//               if ( v31 >= v16.max_length.size )
			//                 goto LABEL_42;
			//               v32 = v25 + v26;
			//             }
			//             ++v27;
			//             v33 = v13 + v32 + 1;
			//             v34 = (int)v31;
			//             v15 = (unsigned int)(v24 + v33);
			//             v13 = (unsigned int)(v26 + v13);
			//             v23 = v31 + 1;
			//             v16.vector[v34] = v15;
			//           }
			//           while ( v27 < numVertsY );
			//         }
			//         ++v24;
			//         --v25;
			//       }
			//       while ( v24 < numVertsX );
			//     }
			//     if ( !v7 )
			//       goto LABEL_30;
			//     if ( v7.max_length.size > 65000 )
			//     {
			//       return 0LL;
			//     }
			//     else
			//     {
			//       v38 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//       v39 = v38;
			//       if ( !v38 )
			//         goto LABEL_30;
			//       UnityEngine::Mesh::Mesh(v38, 0LL);
			//       UnityEngine::Mesh::set_vertices(v39, v7, 0LL);
			//       UnityEngine::Mesh::set_uv(v39, v9, 0LL);
			//       UnityEngine::Mesh::set_triangles(v39, v16, 0LL);
			//       UnityEngine::Object::set_name((Object_1 *)v39, (String *)"Water Mesh", 0LL);
			//       return v39;
			//     }
			//   }
			// }
			// 
			return null;
		}

		public const int SCREEN_SPACE_MESH_VERTEX_NUM = 16;

		public const int MAX_SCREEN_SPACE_MESH_NUM = 16;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Vector4 prepassTextureSize_256x256;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Vector4 prepassTextureSize_512x512;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static Vector4 prepassTextureSize_1024x1024;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static Vector4 prepassTextureSize;
	}
}
