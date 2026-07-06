using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class HGFoliageOccluderUtils
	{
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh quadMesh
		{
			get
			{
				return null;
			}
		}

		private static Mesh _CreateQuadMesh()
		{
			// // Mesh _CreateQuadMesh()
			// Mesh *HG::Rendering::Runtime::HGFoliageOccluderUtils::_CreateQuadMesh(MethodInfo *method)
			// {
			//   Mesh *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   Mesh *v4; // rdi
			//   __int64 v5; // r8
			//   __int64 v6; // r9
			//   __int64 v7; // rax
			//   Vector3__Array *v8; // rsi
			//   __int64 v9; // r8
			//   __int64 v10; // r9
			//   Array *v11; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v14; // [rsp+20h] [rbp-40h] BYREF
			//   int v15; // [rsp+28h] [rbp-38h]
			// 
			//   if ( !byte_18D919440 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&752A6E22358C492163D1DE31BFAFB249C23A54C303CE495A18ABF04CF82E01B2_Field);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D919440 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2175, 0LL) )
			//   {
			//     v1 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//     v4 = v1;
			//     if ( v1 )
			//     {
			//       UnityEngine::Mesh::Mesh(v1, 0LL);
			//       v7 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 4LL, v5, v6);
			//       v8 = (Vector3__Array *)v7;
			//       if ( v7 )
			//       {
			//         v15 = -1090519040;
			//         v14 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v7, 0LL, &v14);
			//         v15 = -1090519040;
			//         v14 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v8, 1LL, &v14);
			//         v15 = 1056964608;
			//         v14 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v8, 2LL, &v14);
			//         v15 = 1056964608;
			//         v14 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v8, 3LL, &v14);
			//         v11 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 6LL, v9, v10);
			//         System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//           v11,
			//           752A6E22358C492163D1DE31BFAFB249C23A54C303CE495A18ABF04CF82E01B2_Field,
			//           0LL);
			//         UnityEngine::Mesh::set_vertices(v4, v8, 0LL);
			//         UnityEngine::Mesh::set_triangles(v4, (Int32__Array *)v11, 0LL);
			//         return v4;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2175, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Mesh s_quadMesh;
	}
}
