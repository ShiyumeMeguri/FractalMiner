using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class HGInteractionResources
	{
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh QuadMesh
		{
			get
			{
				// // Mesh get_QuadMesh()
				// Mesh *HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(MethodInfo *method)
				// {
				//   Object_1 *quadMesh; // rbx
				//   Mesh *v2; // rax
				//   __int64 v3; // rdx
				//   Mesh *v4; // rcx
				//   String *v5; // rbx
				//   OneofDescriptorProto *static_fields; // rdx
				//   FileDescriptor *v7; // r8
				//   MessageDescriptor *v8; // r9
				//   Mesh *v9; // rdi
				//   __int64 v10; // r8
				//   __int64 v11; // r9
				//   __int64 v12; // rax
				//   Vector3__Array *v13; // rbx
				//   Mesh *v14; // rbx
				//   __int64 v15; // r8
				//   __int64 v16; // r9
				//   __int64 v17; // rax
				//   Mesh *v18; // rbx
				//   __int64 v19; // r8
				//   __int64 v20; // r9
				//   Array *v21; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   String__Array *v24; // [rsp+20h] [rbp-40h] BYREF
				//   String *v25; // [rsp+28h] [rbp-38h]
				//   __int128 v26; // [rsp+30h] [rbp-30h]
				// 
				//   if ( !byte_18D919E0A )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
				//     sub_18003C530(&TypeInfo::System::Int32);
				//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE_Field_1);
				//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
				//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
				//     byte_18D919E0A = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1521, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
				//     quadMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Equality(quadMesh, 0LL, 0LL) )
				//     {
				// LABEL_19:
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
				//       return TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//     }
				//     v2 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
				//     v5 = (String *)v2;
				//     if ( v2 )
				//     {
				//       UnityEngine::Mesh::Mesh(v2, 0LL);
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
				//       static_fields = (OneofDescriptorProto *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields;
				//       static_fields.fields.name_ = v5;
				//       sub_1800054D0(
				//         (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh,
				//         static_fields,
				//         v7,
				//         v8,
				//         v24,
				//         v25,
				//         (MethodInfo *)v26);
				//       v4 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//       if ( v4 )
				//       {
				//         UnityEngine::Mesh::ClearImpl(v4, 1, 0LL);
				//         v4 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//         if ( v4 )
				//         {
				//           UnityEngine::Mesh::set_indexFormat(v4, IndexFormat__Enum_UInt16, 0LL);
				//           v9 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//           v12 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 4LL, v10, v11);
				//           v13 = (Vector3__Array *)v12;
				//           if ( v12 )
				//           {
				//             LODWORD(v25) = -1090519040;
				//             v24 = (String__Array *)_mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
				//             sub_180040FA0(v12, 0LL, &v24);
				//             LODWORD(v25) = 1056964608;
				//             v24 = (String__Array *)_mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
				//             sub_180040FA0(v13, 1LL, &v24);
				//             LODWORD(v25) = 1056964608;
				//             v24 = (String__Array *)_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
				//             sub_180040FA0(v13, 2LL, &v24);
				//             LODWORD(v25) = -1090519040;
				//             v24 = (String__Array *)_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
				//             sub_180040FA0(v13, 3LL, &v24);
				//             if ( v9 )
				//             {
				//               UnityEngine::Mesh::set_vertices(v9, v13, 0LL);
				//               v14 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//               v17 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector2, 4LL, v15, v16);
				//               if ( v17 )
				//               {
				//                 if ( !*(_DWORD *)(v17 + 24)
				//                   || (*(_DWORD *)(v17 + 32) = 0, *(_DWORD *)(v17 + 36) = 0, *(_DWORD *)(v17 + 24) <= 1u)
				//                   || (*(_DWORD *)(v17 + 40) = 0,
				//                       v4 = (Mesh *)1065353216,
				//                       *(_DWORD *)(v17 + 44) = 1065353216,
				//                       *(_DWORD *)(v17 + 24) <= 2u)
				//                   || (*(_DWORD *)(v17 + 48) = 1065353216, *(_DWORD *)(v17 + 52) = 1065353216,
				//                                                           *(_DWORD *)(v17 + 24) <= 3u) )
				//                 {
				//                   sub_180070270(v4, v3);
				//                 }
				//                 *(_QWORD *)(v17 + 56) = 1065353216LL;
				//                 if ( v14 )
				//                 {
				//                   UnityEngine::Mesh::set_uv(v14, (Vector2__Array *)v17, 0LL);
				//                   v18 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//                   v21 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 6LL, v19, v20);
				//                   System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
				//                     v21,
				//                     FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE_Field_1,
				//                     0LL);
				//                   if ( v18 )
				//                   {
				//                     UnityEngine::Mesh::set_triangles(v18, (Int32__Array *)v21, 0LL);
				//                     v4 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields._quadMesh;
				//                     if ( v4 )
				//                     {
				//                       UnityEngine::Mesh::RecalculateBounds(v4, MeshUpdateFlags__Enum_Default, 0LL);
				//                       goto LABEL_19;
				//                     }
				//                   }
				//                 }
				//               }
				//             }
				//           }
				//         }
				//       }
				//     }
				// LABEL_22:
				//     sub_180B536AC(v4, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1521, 0LL);
				//   if ( !Patch )
				//     goto LABEL_22;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static Mesh Cylinder;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static Mesh Capsule;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static Mesh Cube;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static Mesh _quadMesh;
	}
}
