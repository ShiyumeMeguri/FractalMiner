using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class FullScreenVFXData
	{
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x000025D2 File Offset: 0x000007D2
		public Mesh fullScreenMesh
		{
			get
			{
				return null;
			}
		}

		public FullScreenVFXData()
		{
			// // FullScreenVFXData()
			// void HG::Rendering::Runtime::FullScreenVFXData::FullScreenVFXData(FullScreenVFXData *this, MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int64 v3; // r9
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   String__Array *v8; // [rsp+50h] [rbp+28h]
			//   String *v9; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v10; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D91953B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D91953B = 1;
			//   }
			//   this.fields.meshVertices = (Vector3__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 3LL, v2, v3);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.meshVertices, v5, v6, v7, v8, v9, v10);
			// }
			// 
		}

		private static Mesh CreateTriangleMesh()
		{
			// // Mesh CreateTriangleMesh()
			// Mesh *HG::Rendering::Runtime::FullScreenVFXData::CreateTriangleMesh(MethodInfo *method)
			// {
			//   Mesh *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   Mesh *v4; // rdi
			//   __int64 v5; // r8
			//   __int64 v6; // r9
			//   __int64 v7; // rax
			//   Vector3__Array *v8; // rbp
			//   __int64 v9; // r8
			//   __int64 v10; // r9
			//   Vector2__Array *v11; // rax
			//   __int64 v12; // r8
			//   __int64 v13; // r9
			//   Vector2__Array *v14; // rbx
			//   Int32__Array *v15; // rax
			//   Int32__Array *v16; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v19; // [rsp+20h] [rbp-38h] BYREF
			//   int v20; // [rsp+28h] [rbp-30h]
			// 
			//   if ( !byte_18D91953A )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18D4FA490);
			//     byte_18D91953A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1013, 0LL) )
			//   {
			//     v1 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//     v4 = v1;
			//     if ( v1 )
			//     {
			//       UnityEngine::Mesh::Mesh(v1, 0LL);
			//       v7 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 3LL, v5, v6);
			//       v8 = (Vector3__Array *)v7;
			//       if ( v7 )
			//       {
			//         v20 = 0;
			//         v19 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v7, 0LL, &v19);
			//         v20 = 0;
			//         v19 = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v8, 1LL, &v19);
			//         v20 = 0;
			//         v19 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u).m128_u64[0];
			//         sub_180040FA0(v8, 2LL, &v19);
			//         v11 = (Vector2__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector2, 3LL, v9, v10);
			//         v14 = v11;
			//         if ( v11 )
			//         {
			//           if ( !v11.max_length.size )
			//             goto LABEL_14;
			//           v11.vector[0].x = 0.0;
			//           v11.vector[0].y = 0.0;
			//           if ( v11.max_length.size <= 1u )
			//             goto LABEL_14;
			//           v11.vector[1].y = 0.0;
			//           v11.vector[1].x = 2.0;
			//           if ( v11.max_length.size <= 2u )
			//             goto LABEL_14;
			//           v11.vector[2].x = 0.0;
			//           v11.vector[2].y = 2.0;
			//           v15 = (Int32__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 3LL, v12, v13);
			//           v16 = v15;
			//           if ( v15 )
			//           {
			//             if ( v15.max_length.size > 1u )
			//             {
			//               v15.vector[1] = 2;
			//               if ( v15.max_length.size > 2u )
			//               {
			//                 v15.vector[2] = 1;
			//                 UnityEngine::Mesh::set_vertices(v4, v8, 0LL);
			//                 UnityEngine::Mesh::set_triangles(v4, v16, 0LL);
			//                 UnityEngine::Object::set_name((Object_1 *)v4, (String *)"FullScreenTriangle", 0LL);
			//                 UnityEngine::Mesh::set_uv(v4, v14, 0LL);
			//                 UnityEngine::Mesh::RecalculateBounds(v4, MeshUpdateFlags__Enum_Default, 0LL);
			//                 return v4;
			//               }
			//             }
			// LABEL_14:
			//             sub_180070270(v3, v2);
			//           }
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1013, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			// }
			// 
			return null;
		}

		public bool renderFullScreenVFXData;

		private Mesh m_initMesh;

		public Vector3[] meshVertices;
	}
}
