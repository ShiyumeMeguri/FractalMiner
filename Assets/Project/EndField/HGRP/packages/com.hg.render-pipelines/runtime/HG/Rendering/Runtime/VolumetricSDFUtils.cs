using System;
using HG.Rendering.Runtime.SDF;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class VolumetricSDFUtils
	{
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh CubeMesh
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh QuadMesh
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh SphereMesh
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh BlitMesh
		{
			get
			{
				// // Mesh get_BlitMesh()
				// Mesh *HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMesh(MethodInfo *method)
				// {
				//   Object_1 *blitMesh; // rbx
				//   Mesh *v2; // rax
				//   __int64 v3; // rdx
				//   Mesh *v4; // rcx
				//   Object *v5; // rbx
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
				//   VolumetricRenderer_VolumetricBounds *v7; // r8
				//   Material *v8; // r9
				//   LowLevelList_1_System_Object_ *v9; // rax
				//   List_1_UnityEngine_Vector3_ *v10; // rdi
				//   LowLevelList_1_System_Object_ *v11; // rax
				//   List_1_UnityEngine_Vector2_ *v12; // rsi
				//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v13; // rax
				//   List_1_System_Int32_ *v14; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *v17; // [rsp+20h] [rbp-48h] BYREF
				//   MethodInfo *v18; // [rsp+28h] [rbp-40h]
				//   int32_t v19; // [rsp+30h] [rbp-38h]
				//   int32_t v20; // [rsp+38h] [rbp-30h]
				//   float v21; // [rsp+40h] [rbp-28h]
				//   int32_t v22; // [rsp+48h] [rbp-20h]
				//   bool v23; // [rsp+50h] [rbp-18h]
				//   bool v24; // [rsp+58h] [rbp-10h]
				//   MethodInfo *v25; // [rsp+60h] [rbp-8h]
				// 
				//   if ( !byte_18D9197F9 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
				//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     byte_18D9197F9 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4428, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     blitMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMesh;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( UnityEngine::Object::op_Implicit(blitMesh, 0LL) )
				//     {
				// LABEL_13:
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//       return TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMesh;
				//     }
				//     v2 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
				//     v5 = (Object *)v2;
				//     if ( v2 )
				//     {
				//       UnityEngine::Mesh::Mesh(v2, 0LL);
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//       static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields;
				//       static_fields.fields._._.m_target = v5;
				//       sub_1800054D0(
				//         (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMesh,
				//         static_fields,
				//         v7,
				//         v8,
				//         v17,
				//         v18,
				//         v19,
				//         v20,
				//         v21,
				//         v22,
				//         v23,
				//         v24,
				//         v25);
				//       v9 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
				//       v10 = (List_1_UnityEngine_Vector3_ *)v9;
				//       if ( v9 )
				//       {
				//         System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
				//           v9,
				//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
				//         v17 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
				//         LODWORD(v18) = 1056964608;
				//         sub_180315038(v10, &v17, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//         v17 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xC0400000).m128_u64[0];
				//         LODWORD(v18) = 1056964608;
				//         sub_180315038(v10, &v17, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//         v17 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x40400000u, (__m128)0x3F800000u).m128_u64[0];
				//         LODWORD(v18) = 1056964608;
				//         sub_180315038(v10, &v17, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//         v11 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
				//         v12 = (List_1_UnityEngine_Vector2_ *)v11;
				//         if ( v11 )
				//         {
				//           System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
				//             v11,
				//             MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
				//           sub_182EC43F0(v12, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL));
				//           sub_182EC43F0(v12, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u));
				//           sub_182EC43F0(v12, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL));
				//           v13 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
				//           v14 = (List_1_System_Int32_ *)v13;
				//           if ( v13 )
				//           {
				//             System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
				//               v13,
				//               MethodInfo::System::Collections::Generic::List<int>::List);
				//             sub_18231EF50(v14, 0);
				//             sub_18231EF50(v14, 1);
				//             sub_18231EF50(v14, 2);
				//             v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMesh;
				//             if ( v4 )
				//             {
				//               UnityEngine::Mesh::SetVertices(v4, v10, 0LL);
				//               v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMesh;
				//               if ( v4 )
				//               {
				//                 UnityEngine::Mesh::SetUVs(v4, 0, v12, 0LL);
				//                 v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMesh;
				//                 if ( v4 )
				//                 {
				//                   UnityEngine::Mesh::SetTriangles(v4, v14, 0, 0LL);
				//                   goto LABEL_13;
				//                 }
				//               }
				//             }
				//           }
				//         }
				//       }
				//     }
				// LABEL_15:
				//     sub_180B536AC(v4, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4428, 0LL);
				//   if ( !Patch )
				//     goto LABEL_15;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh BlitMeshBackface
		{
			get
			{
				// // Mesh get_BlitMeshBackface()
				// Mesh *HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMeshBackface(MethodInfo *method)
				// {
				//   Object_1 *blitMeshBackface; // rbx
				//   Mesh *v2; // rax
				//   __int64 v3; // rdx
				//   Mesh *v4; // rcx
				//   Mesh *v5; // rbx
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
				//   VolumetricRenderer_VolumetricBounds *v7; // r8
				//   Material *v8; // r9
				//   LowLevelList_1_System_Object_ *v9; // rax
				//   List_1_UnityEngine_Vector3_ *v10; // rdi
				//   LowLevelList_1_System_Object_ *v11; // rax
				//   List_1_UnityEngine_Vector2_ *v12; // rsi
				//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v13; // rax
				//   List_1_System_Int32_ *v14; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *v17; // [rsp+20h] [rbp-48h] BYREF
				//   MethodInfo *v18; // [rsp+28h] [rbp-40h]
				//   int32_t v19; // [rsp+30h] [rbp-38h]
				//   int32_t v20; // [rsp+38h] [rbp-30h]
				//   float v21; // [rsp+40h] [rbp-28h]
				//   int32_t v22; // [rsp+48h] [rbp-20h]
				//   bool v23; // [rsp+50h] [rbp-18h]
				//   bool v24; // [rsp+58h] [rbp-10h]
				//   MethodInfo *v25; // [rsp+60h] [rbp-8h]
				// 
				//   if ( !byte_18D9197FA )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
				//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     byte_18D9197FA = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4429, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     blitMeshBackface = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMeshBackface;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( UnityEngine::Object::op_Implicit(blitMeshBackface, 0LL) )
				//     {
				// LABEL_13:
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//       return TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMeshBackface;
				//     }
				//     v2 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
				//     v5 = v2;
				//     if ( v2 )
				//     {
				//       UnityEngine::Mesh::Mesh(v2, 0LL);
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//       static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields;
				//       static_fields.fields._._.method = v5;
				//       sub_1800054D0(
				//         (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMeshBackface,
				//         static_fields,
				//         v7,
				//         v8,
				//         v17,
				//         v18,
				//         v19,
				//         v20,
				//         v21,
				//         v22,
				//         v23,
				//         v24,
				//         v25);
				//       v9 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
				//       v10 = (List_1_UnityEngine_Vector3_ *)v9;
				//       if ( v9 )
				//       {
				//         System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
				//           v9,
				//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
				//         v17 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
				//         LODWORD(v18) = 1056964608;
				//         sub_180315038(v10, &v17, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//         v17 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xC0400000).m128_u64[0];
				//         LODWORD(v18) = 1056964608;
				//         sub_180315038(v10, &v17, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//         v17 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x40400000u, (__m128)0x3F800000u).m128_u64[0];
				//         LODWORD(v18) = 1056964608;
				//         sub_180315038(v10, &v17, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
				//         v11 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
				//         v12 = (List_1_UnityEngine_Vector2_ *)v11;
				//         if ( v11 )
				//         {
				//           System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
				//             v11,
				//             MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
				//           sub_182EC43F0(v12, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL));
				//           sub_182EC43F0(v12, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u));
				//           sub_182EC43F0(v12, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL));
				//           v13 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
				//           v14 = (List_1_System_Int32_ *)v13;
				//           if ( v13 )
				//           {
				//             System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
				//               v13,
				//               MethodInfo::System::Collections::Generic::List<int>::List);
				//             sub_18231EF50(v14, 0);
				//             sub_18231EF50(v14, 2);
				//             sub_18231EF50(v14, 1);
				//             v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMeshBackface;
				//             if ( v4 )
				//             {
				//               UnityEngine::Mesh::SetVertices(v4, v10, 0LL);
				//               v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMeshBackface;
				//               if ( v4 )
				//               {
				//                 UnityEngine::Mesh::SetUVs(v4, 0, v12, 0LL);
				//                 v4 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._blitMeshBackface;
				//                 if ( v4 )
				//                 {
				//                   UnityEngine::Mesh::SetTriangles(v4, v14, 0, 0LL);
				//                   goto LABEL_13;
				//                 }
				//               }
				//             }
				//           }
				//         }
				//       }
				//     }
				// LABEL_15:
				//     sub_180B536AC(v4, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4429, 0LL);
				//   if ( !Patch )
				//     goto LABEL_15;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		public static T AddMissingComponent<T>(this GameObject go) where T : Component
		{
			return null;
		}

		public static Vector3 GetTextureResolution(Texture texture)
		{
			// // Vector3 GetTextureResolution(Texture)
			// Vector3 *HG::Rendering::Runtime::VolumetricSDFUtils::GetTextureResolution(
			//         Vector3 *__return_ptr retstr,
			//         Texture *texture,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // rdx
			//   Vector3 *v6; // rax
			//   unsigned __int64 v7; // xmm6_8
			//   float v8; // esi
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Texture *v11; // rsi
			//   RenderTexture *v12; // rdi
			//   __m128 v13; // xmm7
			//   __m128 v14; // xmm6
			//   int32_t depth; // eax
			//   RuntimeTypeHandle v16; // rbx
			//   __int64 v17; // rax
			//   Object *TypeFromHandle; // rdi
			//   RuntimeTypeHandle v19; // rax
			//   Object *v20; // rbx
			//   String *v21; // rax
			//   String *v22; // rdi
			//   __int64 v23; // rax
			//   InvalidEnumArgumentException *v24; // rax
			//   InvalidEnumArgumentException *v25; // rbx
			//   __int64 v26; // rax
			//   __m128i v27; // xmm1
			//   Vector3 *one; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v30; // xmm0_8
			//   float z; // eax
			//   __int64 v33; // [rsp+20h] [rbp-48h]
			//   float v34; // [rsp+28h] [rbp-40h]
			//   Vector3 v35; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9197FB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture3D);
			//     byte_18D9197FB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4392, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4392, 0LL);
			//     if ( !Patch )
			//       goto LABEL_22;
			//     one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(&v35, Patch, (Object *)texture, 0LL);
			// LABEL_24:
			//     v30 = *(_QWORD *)&one.x;
			//     z = one.z;
			//     *(_QWORD *)&retstr.x = v30;
			//     retstr.z = z;
			//     return retstr;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
			//   {
			//     one = UnityEngine::Vector3::get_one(&v35, v5);
			//     goto LABEL_24;
			//   }
			//   v6 = UnityEngine::Vector3::get_one(&v35, v5);
			//   v7 = *(_QWORD *)&v6.x;
			//   v8 = v6.z;
			//   v33 = *(_QWORD *)&v6.x;
			//   v34 = v8;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)texture, 0LL, 0LL) )
			//   {
			//     if ( !texture )
			//       goto LABEL_22;
			//     if ( (unsigned int)sub_18003ED00(9LL) == 3 )
			//     {
			//       v11 = 0LL;
			//       if ( (struct Texture3D__Class *)texture.klass == TypeInfo::UnityEngine::Texture3D )
			//         v11 = texture;
			//       v12 = (RenderTexture *)sub_18003F5A0(texture, TypeInfo::UnityEngine::RenderTexture);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality((Object_1 *)v11, 0LL, 0LL) )
			//       {
			//         if ( v11 )
			//         {
			//           v13 = (__m128)(unsigned int)v33;
			//           v13.m128_f32[0] = fmaxf(*(float *)&v33, (float)(int)sub_18003ED00(5LL));
			//           v14 = (__m128)HIDWORD(v33);
			//           v14.m128_f32[0] = fmaxf(*((float *)&v33 + 1), (float)(int)sub_18003ED00(7LL));
			//           depth = UnityEngine::Texture3D::get_depth((Texture3D *)v11, 0LL);
			//           goto LABEL_18;
			//         }
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Equality((Object_1 *)v12, 0LL, 0LL) )
			//         {
			//           v16.value = (void *)sub_18000F7E0(&TypeRef::UnityEngine::Texture3D);
			//           v17 = sub_18000F7E0(&TypeInfo::System::Type);
			//           sub_180002C70(v17);
			//           TypeFromHandle = (Object *)System::Type::GetTypeFromHandle(v16, 0LL);
			//           v19.value = (void *)sub_18000F7E0(&TypeRef::UnityEngine::RenderTexture);
			//           v20 = (Object *)System::Type::GetTypeFromHandle(v19, 0LL);
			//           v21 = (String *)sub_18000F7E0(&off_18D521A10);
			//           v22 = System::String::Format(v21, TypeFromHandle, v20, 0LL);
			//           v23 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//           v24 = (InvalidEnumArgumentException *)sub_180004920(v23);
			//           v25 = v24;
			//           if ( v24 )
			//           {
			//             System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v24, v22, 0LL);
			//             v26 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::GetTextureResolution);
			//             sub_18000F7C0(v25, v26);
			//           }
			//         }
			//         else if ( v12 )
			//         {
			//           v13 = (__m128)(unsigned int)v33;
			//           v13.m128_f32[0] = fmaxf(*(float *)&v33, (float)(int)sub_18003ED00(5LL));
			//           v14 = (__m128)HIDWORD(v33);
			//           v14.m128_f32[0] = fmaxf(*((float *)&v33 + 1), (float)(int)sub_18003ED00(7LL));
			//           depth = UnityEngine::RenderTexture::get_volumeDepth(v12, 0LL);
			// LABEL_18:
			//           v27 = (__m128i)LODWORD(v34);
			//           *(float *)v27.m128i_i32 = fmaxf(v34, (float)depth);
			//           v7 = _mm_unpacklo_ps(v13, v14).m128_u64[0];
			//           v8 = COERCE_FLOAT(_mm_cvtsi128_si32(v27));
			//           goto LABEL_19;
			//         }
			//       }
			// LABEL_22:
			//       sub_180B536AC(v10, v9);
			//     }
			//   }
			// LABEL_19:
			//   *(_QWORD *)&retstr.x = v7;
			//   retstr.z = v8;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 VoxelSize(Vector3 textureResolution, out float inverseResolution)
		{
			// // Vector3 VoxelSize(Vector3, Single ByRef)
			// Vector3 *HG::Rendering::Runtime::VolumetricSDFUtils::VoxelSize(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *textureResolution,
			//         float *inverseResolution,
			//         MethodInfo *method)
			// {
			//   float v7; // xmm4_4
			//   float v8; // xmm0_4
			//   float v9; // xmm1_4
			//   float v10; // xmm4_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v12; // rcx
			//   float z; // eax
			//   Vector3 *v14; // rax
			//   __int64 v15; // xmm0_8
			//   Vector3 v17; // [rsp+30h] [rbp-28h] BYREF
			//   Vector3 v18[2]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4393, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4393, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, 0LL);
			//     z = textureResolution.z;
			//     *(_QWORD *)&v17.x = *(_QWORD *)&textureResolution.x;
			//     v17.z = z;
			//     v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1261(v18, Patch, &v17, inverseResolution, 0LL);
			//     v15 = *(_QWORD *)&v14.x;
			//     *(float *)&v14 = v14.z;
			//     *(_QWORD *)&retstr.x = v15;
			//     LODWORD(retstr.z) = (_DWORD)v14;
			//   }
			//   else
			//   {
			//     v7 = 1.0 / fmaxf(textureResolution.x, fmaxf(textureResolution.y, textureResolution.z));
			//     *inverseResolution = v7;
			//     v8 = v7 * textureResolution.x;
			//     v9 = v7 * textureResolution.y;
			//     v10 = v7 * textureResolution.z;
			//     retstr.x = v8;
			//     retstr.y = v9;
			//     retstr.z = v10;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static void CustomBlit(CommandBuffer cmd, Material mat, int pass, [MetadataOffset(Offset = "0x01F91D8A")] bool backface = false)
		{
			// // Void CustomBlit(CommandBuffer, Material, Int32, Boolean)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         int32_t pass,
			//         bool backface,
			//         MethodInfo *method)
			// {
			//   Mesh *BlitMeshBackface; // rax
			//   Mesh *v10; // rbx
			//   _OWORD *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 v18; // [rsp+40h] [rbp-88h] BYREF
			//   _BYTE v19[64]; // [rsp+80h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9197FC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D9197FC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4523, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     if ( backface )
			//       BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMeshBackface(0LL);
			//     else
			//       BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMesh(0LL);
			//     v10 = BlitMeshBackface;
			//     v11 = (_OWORD *)sub_182805160(v19);
			//     if ( cmd )
			//     {
			//       v14 = v11[1];
			//       *(_OWORD *)&v18.m00 = *v11;
			//       v15 = v11[2];
			//       *(_OWORD *)&v18.m01 = v14;
			//       v16 = v11[3];
			//       *(_OWORD *)&v18.m02 = v15;
			//       *(_OWORD *)&v18.m03 = v16;
			//       UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, v10, &v18, mat, 0, pass, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v13, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4523, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)cmd,
			//     (Object *)mat,
			//     pass,
			//     backface,
			//     0LL);
			// }
			// 
		}

		[IDTag(0)]
		public static void CustomBlit(CommandBuffer cmd, Material mat, MaterialPropertyBlock propertyBlock, int pass, [MetadataOffset(Offset = "0x01F91D8B")] bool backface = false)
		{
			// // Void CustomBlit(CommandBuffer, Material, MaterialPropertyBlock, Int32, Boolean)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         MaterialPropertyBlock *propertyBlock,
			//         int32_t pass,
			//         bool backface,
			//         MethodInfo *method)
			// {
			//   Mesh *BlitMeshBackface; // rax
			//   Mesh *v11; // rdi
			//   _OWORD *v12; // rax
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   Matrix4x4 v18; // [rsp+40h] [rbp-88h] BYREF
			//   _BYTE v19[64]; // [rsp+80h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D9197FD )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D9197FD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4427, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     if ( backface )
			//       BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMeshBackface(0LL);
			//     else
			//       BlitMeshBackface = HG::Rendering::Runtime::VolumetricSDFUtils::get_BlitMesh(0LL);
			//     v11 = BlitMeshBackface;
			//     v12 = (_OWORD *)sub_182805160(v19);
			//     if ( cmd )
			//     {
			//       v15 = v12[1];
			//       *(_OWORD *)&v18.m00 = *v12;
			//       v16 = v12[2];
			//       *(_OWORD *)&v18.m01 = v15;
			//       v17 = v12[3];
			//       *(_OWORD *)&v18.m02 = v16;
			//       *(_OWORD *)&v18.m03 = v17;
			//       UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, v11, &v18, mat, 0, pass, propertyBlock, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(Patch, v13);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4427, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1270(
			//     Patch,
			//     (Object *)cmd,
			//     (Object *)mat,
			//     (Object *)propertyBlock,
			//     pass,
			//     backface,
			//     0LL);
			// }
			// 
		}

		public static void ClearRenderTarget(RenderTexture rt)
		{
			// // Void ClearRenderTarget(RenderTexture)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::ClearRenderTarget(RenderTexture *rt, MethodInfo *method)
			// {
			//   RenderTexture *Active; // rbx
			//   MethodInfo *v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Quaternion v8; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9197FE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9197FE = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4571, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4571, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)rt, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)rt, 0LL) )
			//     {
			//       Active = UnityEngine::RenderTexture::GetActive(0LL);
			//       UnityEngine::RenderTexture::SetActive(rt, 0LL);
			//       v8 = *UnityEngine::Quaternion::get_identity(&v8, v4);
			//       UnityEngine::GL::Clear(0, 1, (Color *)&v8, 1.0, 0LL);
			//       UnityEngine::RenderTexture::SetActive(Active, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public static void SetRenderTargets(CommandBuffer cmd, RenderTexture colorRT, RenderTexture depthRT, [MetadataOffset(Offset = "0x01F91D8C")] RenderBufferLoadAction loadAction = RenderBufferLoadAction.DontCare, [MetadataOffset(Offset = "0x01F91D8D")] RenderBufferStoreAction storeAction = RenderBufferStoreAction.Store)
		{
			// // Void SetRenderTargets(CommandBuffer, RenderTexture, RenderTexture, RenderBufferLoadAction, RenderBufferStoreAction)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//         CommandBuffer *cmd,
			//         RenderTexture *colorRT,
			//         RenderTexture *depthRT,
			//         RenderBufferLoadAction__Enum loadAction,
			//         RenderBufferStoreAction__Enum storeAction,
			//         MethodInfo *method)
			// {
			//   RenderTargetIdentifier__Array *RTs; // r14
			//   RenderTargetIdentifier *v11; // rax
			//   _DWORD *Loads; // rdx
			//   ILFixDynamicMethodWrapper_4 *Patch; // rcx
			//   __int128 v14; // xmm1
			//   RenderTargetIdentifier__Array *v15; // rsi
			//   RenderTargetIdentifier *v16; // rax
			//   __int128 v17; // xmm1
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v18; // rdx
			//   VolumetricRenderer_VolumetricBounds *v19; // r8
			//   Material *v20; // r9
			//   RenderTargetIdentifier *v21; // rax
			//   __int128 v22; // xmm2
			//   Action *v23; // xmm0_8
			//   MethodInfo *P3; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P4; // [rsp+30h] [rbp-D8h]
			//   int32_t v26; // [rsp+38h] [rbp-D0h]
			//   int32_t v27; // [rsp+40h] [rbp-C8h]
			//   __int128 v28; // [rsp+48h] [rbp-C0h] BYREF
			//   __int128 v29; // [rsp+58h] [rbp-B0h]
			//   MethodInfo *v30; // [rsp+68h] [rbp-A0h]
			//   ValueAnimation_1_StyleValues_ v31; // [rsp+70h] [rbp-98h] BYREF
			//   __int128 v32; // [rsp+E8h] [rbp-20h]
			//   __int128 v33; // [rsp+F8h] [rbp-10h]
			//   __int128 v34; // [rsp+108h] [rbp+0h]
			// 
			//   if ( !byte_18D9197FF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D9197FF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4437, 0LL) )
			//   {
			//     if ( !cmd )
			//       return;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     RTs = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._RTs;
			//     v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
			//             (Texture *)colorRT,
			//             0LL);
			//     if ( RTs )
			//     {
			//       v14 = *(_OWORD *)&v11.m_BufferPointer;
			//       v28 = *(_OWORD *)&v11.m_Type;
			//       v30 = *(MethodInfo **)&v11.m_DepthSlice;
			//       v29 = v14;
			//       sub_180428B38(RTs, 0LL, &v28);
			//       v15 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._RTs;
			//       v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//               (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
			//               (Texture *)depthRT,
			//               0LL);
			//       if ( v15 )
			//       {
			//         v17 = *(_OWORD *)&v16.m_BufferPointer;
			//         v28 = *(_OWORD *)&v16.m_Type;
			//         v30 = *(MethodInfo **)&v16.m_DepthSlice;
			//         v29 = v17;
			//         sub_180428B38(v15, 1LL, &v28);
			//         Patch = (ILFixDynamicMethodWrapper_4 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
			//         Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Loads;
			//         if ( Loads )
			//         {
			//           if ( Loads[6] <= 1u )
			//             goto LABEL_14;
			//           Loads[9] = loadAction;
			//           if ( !Loads[6] )
			//             goto LABEL_14;
			//           Loads[8] = loadAction;
			//           Patch = (ILFixDynamicMethodWrapper_4 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
			//           Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Stores;
			//           if ( Loads )
			//           {
			//             if ( Loads[6] > 1u )
			//             {
			//               Loads[9] = storeAction;
			//               if ( Loads[6] )
			//               {
			//                 Loads[8] = storeAction;
			//                 sub_1802F01E0(&v31.monitor, 0LL, 80LL);
			//                 v31.monitor = (MonitorData *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._RTs;
			//                 sub_1800054D0(
			//                   (VolumetricRenderer_VolumetricRenderItem *)&v31.monitor,
			//                   v18,
			//                   v19,
			//                   v20,
			//                   P3,
			//                   P4,
			//                   v26,
			//                   v27,
			//                   *(float *)&v28,
			//                   SDWORD2(v28),
			//                   v29,
			//                   SBYTE8(v29),
			//                   v30);
			//                 v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                         (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
			//                         (Texture *)depthRT,
			//                         0LL);
			//                 v22 = *(_OWORD *)&v21.m_BufferPointer;
			//                 v23 = *(Action **)&v21.m_DepthSlice;
			//                 *(_OWORD *)&v31.fields.m_StartTimeMs = *(_OWORD *)&v21.m_Type;
			//                 *(_OWORD *)&v31.fields._easingCurve_k__BackingField = v22;
			//                 v31.fields._onAnimationCompleted_k__BackingField = v23;
			//                 UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
			//                   (ValueAnimation_1_StyleValues_ *)&v31.monitor,
			//                   (Action *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Loads,
			//                   0LL);
			//                 Unity::VisualScripting::UnitConnection<System::Object,System::Object>::set_destinationUnit(
			//                   (UnitConnection_2_System_Object_System_Object_ *)&v31.monitor,
			//                   (IUnit *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Stores,
			//                   0LL);
			//                 *(_OWORD *)&v31.fields._interpolator_k__BackingField = *(_OWORD *)&v31.monitor;
			//                 v32 = *(_OWORD *)&v31.fields._isRunning_k__BackingField;
			//                 v31.fields._valueUpdated_k__BackingField = (Action_2_UnityEngine_UIElements_VisualElement_UnityEngine_UIElements_Experimental_StyleValues_ *)0x300000002LL;
			//                 *(_OWORD *)&v31.fields.fromValueSet = *(_OWORD *)&v31.fields.m_DurationMs;
			//                 v34 = *(_OWORD *)&v31.fields._valueUpdated_k__BackingField;
			//                 v33 = *(_OWORD *)&v31.fields._autoRecycle_k__BackingField;
			//                 UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			//                   cmd,
			//                   (RenderTargetBinding *)&v31.fields._interpolator_k__BackingField,
			//                   0LL);
			//                 return;
			//               }
			//             }
			// LABEL_14:
			//             sub_180070270(Patch, Loads);
			//           }
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(Patch, Loads);
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_4 *)IFix::WrappersManagerImpl::GetPatch(4437, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_497(
			//     Patch,
			//     (Object *)cmd,
			//     (Object *)colorRT,
			//     (Object *)depthRT,
			//     loadAction,
			//     storeAction,
			//     0LL);
			// }
			// 
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTexture colorRT)
		{
			// // Void SetRenderTarget(CommandBuffer, RenderTexture)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(
			//         CommandBuffer *cmd,
			//         RenderTexture *colorRT,
			//         MethodInfo *method)
			// {
			//   RenderTargetIdentifier *v5; // rax
			//   __int128 v6; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   RenderTargetIdentifier v10; // [rsp+30h] [rbp-68h] BYREF
			//   RenderTargetIdentifier v11; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4426, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4426, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)cmd,
			//       (Object *)colorRT,
			//       0LL);
			//   }
			//   else if ( cmd )
			//   {
			//     v5 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v11, (Texture *)colorRT, 0LL);
			//     v6 = *(_OWORD *)&v5.m_BufferPointer;
			//     *(_OWORD *)&v10.m_Type = *(_OWORD *)&v5.m_Type;
			//     *(_QWORD *)&v10.m_DepthSlice = *(_QWORD *)&v5.m_DepthSlice;
			//     *(_OWORD *)&v10.m_BufferPointer = v6;
			//     UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			//       cmd,
			//       &v10,
			//       RenderBufferLoadAction__Enum_DontCare,
			//       RenderBufferStoreAction__Enum_Store,
			//       0LL);
			//   }
			// }
			// 
		}

		public static void SetRenderTargetsWithDepth(CommandBuffer cmd, RenderTexture colorRT, RenderTexture depthRT, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore)
		{
			// // Void SetRenderTargetsWithDepth(CommandBuffer, RenderTexture, RenderTexture, RenderTargetIdentifier, RenderBufferLoadAction, RenderBufferStoreAction)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetsWithDepth(
			//         CommandBuffer *cmd,
			//         RenderTexture *colorRT,
			//         RenderTexture *depthRT,
			//         RenderTargetIdentifier *depth,
			//         RenderBufferLoadAction__Enum depthLoad,
			//         RenderBufferStoreAction__Enum depthStore,
			//         MethodInfo *method)
			// {
			//   RenderTargetIdentifier__Array *RTs; // rbx
			//   RenderTargetIdentifier *v12; // rax
			//   _DWORD *Loads; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v15; // xmm1
			//   RenderTargetIdentifier__Array *v16; // rbx
			//   RenderTargetIdentifier *v17; // rax
			//   __int128 v18; // xmm1
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v19; // rdx
			//   VolumetricRenderer_VolumetricBounds *v20; // r8
			//   Material *v21; // r9
			//   RenderTargetIdentifier *v22; // rax
			//   __int128 v23; // xmm2
			//   Action *v24; // xmm0_8
			//   __int128 v25; // xmm1
			//   MethodInfo *v26; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v27; // [rsp+30h] [rbp-D8h]
			//   int32_t v28; // [rsp+38h] [rbp-D0h]
			//   int32_t v29; // [rsp+40h] [rbp-C8h]
			//   RenderTargetIdentifier v30; // [rsp+48h] [rbp-C0h] BYREF
			//   ValueAnimation_1_StyleValues_ v31; // [rsp+70h] [rbp-98h] BYREF
			//   __int128 v32; // [rsp+E8h] [rbp-20h]
			//   __int128 v33; // [rsp+F8h] [rbp-10h]
			//   __int128 v34; // [rsp+108h] [rbp+0h]
			// 
			//   if ( !byte_18D919800 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919800 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4545, 0LL) )
			//   {
			//     if ( !cmd )
			//       return;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     RTs = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._RTs;
			//     v12 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
			//             (Texture *)colorRT,
			//             0LL);
			//     if ( RTs )
			//     {
			//       v15 = *(_OWORD *)&v12.m_BufferPointer;
			//       *(_OWORD *)&v30.m_Type = *(_OWORD *)&v12.m_Type;
			//       *(_QWORD *)&v30.m_DepthSlice = *(_QWORD *)&v12.m_DepthSlice;
			//       *(_OWORD *)&v30.m_BufferPointer = v15;
			//       sub_180428B38(RTs, 0LL, &v30);
			//       v16 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._RTs;
			//       v17 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//               (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
			//               (Texture *)depthRT,
			//               0LL);
			//       if ( v16 )
			//       {
			//         v18 = *(_OWORD *)&v17.m_BufferPointer;
			//         *(_OWORD *)&v30.m_Type = *(_OWORD *)&v17.m_Type;
			//         *(_QWORD *)&v30.m_DepthSlice = *(_QWORD *)&v17.m_DepthSlice;
			//         *(_OWORD *)&v30.m_BufferPointer = v18;
			//         sub_180428B38(v16, 1LL, &v30);
			//         Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
			//         Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Loads;
			//         if ( Loads )
			//         {
			//           if ( Loads[6] <= 1u )
			//             goto LABEL_14;
			//           Loads[9] = 2;
			//           if ( !Loads[6] )
			//             goto LABEL_14;
			//           Loads[8] = 2;
			//           Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
			//           Loads = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Stores;
			//           if ( Loads )
			//           {
			//             if ( Loads[6] > 1u )
			//             {
			//               Loads[9] = 0;
			//               if ( Loads[6] )
			//               {
			//                 Loads[8] = 0;
			//                 sub_1802F01E0(&v31.monitor, 0LL, 80LL);
			//                 v31.monitor = (MonitorData *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._RTs;
			//                 sub_1800054D0(
			//                   (VolumetricRenderer_VolumetricRenderItem *)&v31.monitor,
			//                   v19,
			//                   v20,
			//                   v21,
			//                   v26,
			//                   v27,
			//                   v28,
			//                   v29,
			//                   *(float *)&v30.m_Type,
			//                   v30.m_InstanceID,
			//                   (bool)v30.m_BufferPointer,
			//                   v30.m_MipLevel,
			//                   *(MethodInfo **)&v30.m_DepthSlice);
			//                 v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                         (RenderTargetIdentifier *)&v31.fields._interpolator_k__BackingField,
			//                         (Texture *)depthRT,
			//                         0LL);
			//                 v23 = *(_OWORD *)&v22.m_BufferPointer;
			//                 v24 = *(Action **)&v22.m_DepthSlice;
			//                 *(_OWORD *)&v31.fields.m_StartTimeMs = *(_OWORD *)&v22.m_Type;
			//                 *(_OWORD *)&v31.fields._easingCurve_k__BackingField = v23;
			//                 v31.fields._onAnimationCompleted_k__BackingField = v24;
			//                 UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
			//                   (ValueAnimation_1_StyleValues_ *)&v31.monitor,
			//                   (Action *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Loads,
			//                   0LL);
			//                 Unity::VisualScripting::UnitConnection<System::Object,System::Object>::set_destinationUnit(
			//                   (UnitConnection_2_System_Object_System_Object_ *)&v31.monitor,
			//                   (IUnit *)TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields._Stores,
			//                   0LL);
			//                 *(_OWORD *)&v31.fields._interpolator_k__BackingField = *(_OWORD *)&v31.monitor;
			//                 LODWORD(v31.fields._valueUpdated_k__BackingField) = depthLoad;
			//                 v32 = *(_OWORD *)&v31.fields._isRunning_k__BackingField;
			//                 HIDWORD(v31.fields._valueUpdated_k__BackingField) = depthStore;
			//                 *(_OWORD *)&v31.fields.fromValueSet = *(_OWORD *)&v31.fields.m_DurationMs;
			//                 v34 = *(_OWORD *)&v31.fields._valueUpdated_k__BackingField;
			//                 v33 = *(_OWORD *)&v31.fields._autoRecycle_k__BackingField;
			//                 UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			//                   cmd,
			//                   (RenderTargetBinding *)&v31.fields._interpolator_k__BackingField,
			//                   0LL);
			//                 return;
			//               }
			//             }
			// LABEL_14:
			//             sub_180070270(Patch, Loads);
			//           }
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(Patch, Loads);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4545, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   v25 = *(_OWORD *)&depth.m_BufferPointer;
			//   *(_OWORD *)&v30.m_Type = *(_OWORD *)&depth.m_Type;
			//   *(_QWORD *)&v30.m_DepthSlice = *(_QWORD *)&depth.m_DepthSlice;
			//   *(_OWORD *)&v30.m_BufferPointer = v25;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1302(
			//     Patch,
			//     (Object *)cmd,
			//     (Object *)colorRT,
			//     (Object *)depthRT,
			//     &v30,
			//     depthLoad,
			//     depthStore,
			//     0LL);
			// }
			// 
		}

		public static void SetRenderTargetWithDepth(CommandBuffer cmd, RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore)
		{
			// // Void SetRenderTargetWithDepth(CommandBuffer, RenderTargetIdentifier, RenderTargetIdentifier, RenderBufferLoadAction, RenderBufferStoreAction)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetWithDepth(
			//         CommandBuffer *cmd,
			//         RenderTargetIdentifier *color,
			//         RenderTargetIdentifier *depth,
			//         RenderBufferLoadAction__Enum depthLoad,
			//         RenderBufferStoreAction__Enum depthStore,
			//         MethodInfo *method)
			// {
			//   __int128 v10; // xmm1
			//   __int64 v11; // xmm0_8
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int64 v14; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v16; // xmm1
			//   __int64 v17; // xmm0_8
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   RenderTargetIdentifier v20; // [rsp+48h] [rbp-19h] BYREF
			//   RenderTargetIdentifier v21; // [rsp+78h] [rbp+17h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4533, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4533, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v14);
			//     v16 = *(_OWORD *)&depth.m_BufferPointer;
			//     *(_OWORD *)&v21.m_Type = *(_OWORD *)&depth.m_Type;
			//     v17 = *(_QWORD *)&depth.m_DepthSlice;
			//     *(_OWORD *)&v21.m_BufferPointer = v16;
			//     v18 = *(_OWORD *)&color.m_Type;
			//     *(_QWORD *)&v21.m_DepthSlice = v17;
			//     v19 = *(_OWORD *)&color.m_BufferPointer;
			//     *(_OWORD *)&v20.m_Type = v18;
			//     *(_QWORD *)&v18 = *(_QWORD *)&color.m_DepthSlice;
			//     *(_OWORD *)&v20.m_BufferPointer = v19;
			//     *(_QWORD *)&v20.m_DepthSlice = v18;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1295(Patch, (Object *)cmd, &v20, &v21, depthLoad, depthStore, 0LL);
			//   }
			//   else if ( cmd )
			//   {
			//     v10 = *(_OWORD *)&depth.m_BufferPointer;
			//     *(_OWORD *)&v20.m_Type = *(_OWORD *)&depth.m_Type;
			//     v11 = *(_QWORD *)&depth.m_DepthSlice;
			//     *(_OWORD *)&v20.m_BufferPointer = v10;
			//     v12 = *(_OWORD *)&color.m_Type;
			//     *(_QWORD *)&v20.m_DepthSlice = v11;
			//     v13 = *(_OWORD *)&color.m_BufferPointer;
			//     *(_OWORD *)&v21.m_Type = v12;
			//     *(_QWORD *)&v12 = *(_QWORD *)&color.m_DepthSlice;
			//     *(_OWORD *)&v21.m_BufferPointer = v13;
			//     *(_QWORD *)&v21.m_DepthSlice = v12;
			//     UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			//       cmd,
			//       &v21,
			//       RenderBufferLoadAction__Enum_DontCare,
			//       RenderBufferStoreAction__Enum_Store,
			//       &v20,
			//       depthLoad,
			//       depthStore,
			//       0LL);
			//   }
			// }
			// 
		}

		private static void CollectCombineMesh(Transform trans, Matrix4x4 parent, MeshCombine combine, Func<GameObject, bool> filter = null)
		{
			// // Void CollectCombineMesh(Transform, Matrix4x4, MeshCombine, Func`2[UnityEngine.GameObject,Boolean])
			// void HG::Rendering::Runtime::VolumetricSDFUtils::CollectCombineMesh(
			//         Transform *trans,
			//         Matrix4x4 *parent,
			//         MeshCombine *combine,
			//         Func_2_UnityEngine_GameObject_Boolean_ *filter,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t v11; // esi
			//   Component *Child; // rax
			//   Component *v13; // rdi
			//   GameObject *gameObject; // rax
			//   GameObject *v15; // rax
			//   Vector3 *localPosition; // rax
			//   __int64 v17; // xmm7_8
			//   float z; // ebx
			//   __m128i v19; // xmm6
			//   Vector3 *localScale; // rax
			//   __int64 v21; // xmm0_8
			//   Matrix4x4 *v22; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   Matrix4x4 *v30; // rax
			//   __int128 v31; // xmm6
			//   __int128 v32; // xmm7
			//   __int128 v33; // xmm8
			//   __int128 v34; // xmm9
			//   Object_1 *sharedMesh; // rbx
			//   Mesh *v36; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   Object *exists; // [rsp+38h] [rbp-D0h]
			//   Matrix4x4 v42; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v43; // [rsp+88h] [rbp-80h] BYREF
			//   Vector3 v44; // [rsp+98h] [rbp-70h] BYREF
			//   __m128i v45; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v46; // [rsp+B8h] [rbp-50h] BYREF
			//   Vector3 v47; // [rsp+C8h] [rbp-40h] BYREF
			//   Matrix4x4 v48; // [rsp+D8h] [rbp-30h] BYREF
			//   Quaternion v49; // [rsp+118h] [rbp+10h] BYREF
			//   Matrix4x4 v50[2]; // [rsp+128h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919801 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919801 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4572, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4572, 0LL);
			//     if ( Patch )
			//     {
			//       v38 = *(_OWORD *)&parent.m01;
			//       *(_OWORD *)&v42.m00 = *(_OWORD *)&parent.m00;
			//       v39 = *(_OWORD *)&parent.m02;
			//       *(_OWORD *)&v42.m01 = v38;
			//       v40 = *(_OWORD *)&parent.m03;
			//       *(_OWORD *)&v42.m02 = v39;
			//       *(_OWORD *)&v42.m03 = v40;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1308(
			//         Patch,
			//         (Object *)trans,
			//         &v42,
			//         (Object *)combine,
			//         (Object *)filter,
			//         0LL);
			//       return;
			//     }
			// LABEL_19:
			//     sub_180B536AC(v10, v9);
			//   }
			//   v11 = 0;
			//   if ( !trans )
			//     goto LABEL_19;
			//   while ( v11 < UnityEngine::Transform::get_childCount(trans, 0LL) )
			//   {
			//     Child = (Component *)UnityEngine::Transform::GetChild(trans, v11, 0LL);
			//     v13 = Child;
			//     if ( !Child )
			//       goto LABEL_19;
			//     gameObject = UnityEngine::Component::get_gameObject(Child, 0LL);
			//     if ( !gameObject )
			//       goto LABEL_19;
			//     if ( UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
			//     {
			//       if ( !filter
			//         || (v15 = UnityEngine::Component::get_gameObject(v13, 0LL), (unsigned __int8)sub_182478F30(filter, v15, 0LL)) )
			//       {
			//         exists = UnityEngine::Component::GetComponent<System::Object>(
			//                    v13,
			//                    MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
			//         localPosition = UnityEngine::Transform::get_localPosition(&v46, (Transform *)v13, 0LL);
			//         v17 = *(_QWORD *)&localPosition.x;
			//         z = localPosition.z;
			//         v19 = _mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_localRotation(&v49, (Transform *)v13, 0LL));
			//         localScale = UnityEngine::Transform::get_localScale(&v47, (Transform *)v13, 0LL);
			//         v45 = v19;
			//         *(_QWORD *)&v44.x = v17;
			//         v21 = *(_QWORD *)&localScale.x;
			//         *(float *)&localScale = localScale.z;
			//         *(_QWORD *)&v43.x = v21;
			//         LODWORD(v43.z) = (_DWORD)localScale;
			//         v44.z = z;
			//         v22 = UnityEngine::Matrix4x4::TRS(&v42, &v44, (Quaternion *)&v45, &v43, 0LL);
			//         v23 = *(_OWORD *)&v22.m01;
			//         *(_OWORD *)&v48.m00 = *(_OWORD *)&v22.m00;
			//         v24 = *(_OWORD *)&v22.m02;
			//         *(_OWORD *)&v48.m01 = v23;
			//         v25 = *(_OWORD *)&v22.m03;
			//         *(_OWORD *)&v48.m02 = v24;
			//         v26 = *(_OWORD *)&parent.m00;
			//         *(_OWORD *)&v48.m03 = v25;
			//         v27 = *(_OWORD *)&parent.m01;
			//         *(_OWORD *)&v42.m00 = v26;
			//         v28 = *(_OWORD *)&parent.m02;
			//         *(_OWORD *)&v42.m01 = v27;
			//         v29 = *(_OWORD *)&parent.m03;
			//         *(_OWORD *)&v42.m02 = v28;
			//         *(_OWORD *)&v42.m03 = v29;
			//         v30 = UnityEngine::Matrix4x4::op_Multiply(v50, &v42, &v48, 0LL);
			//         v31 = *(_OWORD *)&v30.m00;
			//         v32 = *(_OWORD *)&v30.m01;
			//         v33 = *(_OWORD *)&v30.m02;
			//         v34 = *(_OWORD *)&v30.m03;
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Implicit((Object_1 *)exists, 0LL) )
			//         {
			//           if ( !exists )
			//             goto LABEL_19;
			//           sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)exists, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Implicit(sharedMesh, 0LL) )
			//           {
			//             v36 = UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)exists, 0LL);
			//             if ( !combine )
			//               goto LABEL_19;
			//             *(_OWORD *)&v42.m00 = v31;
			//             *(_OWORD *)&v42.m01 = v32;
			//             *(_OWORD *)&v42.m02 = v33;
			//             *(_OWORD *)&v42.m03 = v34;
			//             HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(combine, v36, &v42, 0LL);
			//           }
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         *(_OWORD *)&v42.m00 = v31;
			//         *(_OWORD *)&v42.m01 = v32;
			//         *(_OWORD *)&v42.m02 = v33;
			//         *(_OWORD *)&v42.m03 = v34;
			//         HG::Rendering::Runtime::VolumetricSDFUtils::CollectCombineMesh((Transform *)v13, &v42, combine, filter, 0LL);
			//       }
			//     }
			//     ++v11;
			//   }
			// }
			// 
		}

		private static void UnionChildMesh(Transform trans, MeshCombine combine, Func<GameObject, bool> filter = null)
		{
			// // Void UnionChildMesh(Transform, MeshCombine, Func`2[UnityEngine.GameObject,Boolean])
			// void HG::Rendering::Runtime::VolumetricSDFUtils::UnionChildMesh(
			//         Transform *trans,
			//         MeshCombine *combine,
			//         Func_2_UnityEngine_GameObject_Boolean_ *filter,
			//         MethodInfo *method)
			// {
			//   Object *v4; // rsi
			//   BSP *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   BSP *v10; // r15
			//   Object__Array *v11; // r14
			//   int32_t v12; // ebp
			//   MeshFilter *v13; // rdi
			//   Object_1 *sharedMesh; // rbx
			//   GameObject *gameObject; // rax
			//   Mesh *v16; // rsi
			//   Transform *transform; // rdi
			//   int32_t v18; // ebx
			//   BSP *v19; // rax
			//   _OWORD *v20; // rax
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t objID; // [rsp+30h] [rbp-B8h]
			//   Matrix4x4 v26; // [rsp+40h] [rbp-A8h] BYREF
			//   _BYTE v27[64]; // [rsp+80h] [rbp-68h] BYREF
			// 
			//   v4 = (Object *)filter;
			//   if ( !byte_18D919802 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshFilter>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919802 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4574, 0LL) )
			//   {
			//     v7 = (BSP *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     v10 = v7;
			//     if ( v7 )
			//     {
			//       HG::Rendering::Runtime::CSG::BSP::BSP(v7, 0, 0LL);
			//       if ( trans )
			//       {
			//         v11 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
			//                 (Component *)trans,
			//                 MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshFilter>);
			//         objID = 0;
			//         v12 = 0;
			//         if ( v11 )
			//         {
			//           while ( v12 < v11.max_length.size )
			//           {
			//             if ( (unsigned int)v12 >= v11.max_length.size )
			//               sub_180070270(v9, v8);
			//             v13 = (MeshFilter *)v11.vector[v12];
			//             if ( !v13 )
			//               goto LABEL_19;
			//             sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh((MeshFilter *)v11.vector[v12], 0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Implicit(sharedMesh, 0LL) )
			//             {
			//               if ( !v4
			//                 || (gameObject = UnityEngine::Component::get_gameObject((Component *)v13, 0LL),
			//                     (unsigned __int8)sub_182478F30(v4, gameObject, 0LL)) )
			//               {
			//                 v16 = UnityEngine::MeshFilter::get_sharedMesh(v13, 0LL);
			//                 transform = UnityEngine::Component::get_transform((Component *)v13, 0LL);
			//                 v18 = objID++;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//                 v19 = HG::Rendering::Runtime::CSG::BSP::fromMesh(v16, transform, trans, v18, 0, 0LL);
			//                 HG::Rendering::Runtime::CSG::BSP::Union(v10, v19, 0LL);
			//                 v4 = (Object *)filter;
			//               }
			//             }
			//             ++v12;
			//           }
			//           v20 = (_OWORD *)sub_182805160(v27);
			//           if ( combine )
			//           {
			//             v21 = v20[1];
			//             *(_OWORD *)&v26.m00 = *v20;
			//             v22 = v20[2];
			//             *(_OWORD *)&v26.m01 = v21;
			//             v23 = v20[3];
			//             *(_OWORD *)&v26.m02 = v22;
			//             *(_OWORD *)&v26.m03 = v23;
			//             HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(combine, v10, &v26, 0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4574, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)trans,
			//     (Object *)combine,
			//     v4,
			//     0LL);
			// }
			// 
		}

		public static MeshCombine BuildMeshCombine(Transform trans, bool meshBoolean, Func<GameObject, bool> filter = null)
		{
			// // MeshCombine BuildMeshCombine(Transform, Boolean, Func`2[UnityEngine.GameObject,Boolean])
			// MeshCombine *HG::Rendering::Runtime::VolumetricSDFUtils::BuildMeshCombine(
			//         Transform *trans,
			//         bool meshBoolean,
			//         Func_2_UnityEngine_GameObject_Boolean_ *filter,
			//         MethodInfo *method)
			// {
			//   MeshCombine *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   MeshCombine *v10; // rdi
			//   __int128 *v11; // rax
			//   __int128 v12; // xmm6
			//   __int128 v13; // xmm7
			//   __int128 v14; // xmm8
			//   __int128 v15; // xmm9
			//   Object *v16; // rbx
			//   Bounds *Bounds; // rax
			//   __m128i v18; // xmm3
			//   Animator *v19; // rdx
			//   int32_t v20; // r8d
			//   MethodInfo *v21; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v23; // xmm1_8
			//   MethodInfo *v24; // rdx
			//   Quaternion *identity; // rax
			//   Quaternion v26; // xmm1
			//   Matrix4x4 *v27; // rax
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v33; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector3 v34; // [rsp+48h] [rbp-C0h] BYREF
			//   Bounds v35; // [rsp+58h] [rbp-B0h] BYREF
			//   Matrix4x4 v36; // [rsp+78h] [rbp-90h] BYREF
			//   Matrix4x4 v37[2]; // [rsp+B8h] [rbp-50h] BYREF
			// 
			//   if ( !byte_18D919803 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine);
			//     sub_18003C530(&MethodInfo::UnityEngine::Resources::GetBuiltinResource<UnityEngine::Mesh>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&off_18D521A88);
			//     byte_18D919803 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4626, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4626, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1326(
			//                Patch,
			//                (Object *)trans,
			//                meshBoolean,
			//                (Object *)filter,
			//                0LL);
			// LABEL_10:
			//     sub_180B536AC(v9, v8);
			//   }
			//   v7 = (MeshCombine *)sub_180004920(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine);
			//   v10 = v7;
			//   if ( !v7 )
			//     goto LABEL_10;
			//   HG::Rendering::Runtime::SDF::MeshCombine::MeshCombine(v7, 0LL);
			//   if ( meshBoolean )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::UnionChildMesh(trans, v10, 0LL, 0LL);
			//   }
			//   else
			//   {
			//     v11 = (__int128 *)sub_182805160(&v36);
			//     v12 = *v11;
			//     v13 = v11[1];
			//     v14 = v11[2];
			//     v15 = v11[3];
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     *(_OWORD *)&v36.m00 = v12;
			//     *(_OWORD *)&v36.m01 = v13;
			//     *(_OWORD *)&v36.m02 = v14;
			//     *(_OWORD *)&v36.m03 = v15;
			//     HG::Rendering::Runtime::VolumetricSDFUtils::CollectCombineMesh(trans, &v36, v10, filter, 0LL);
			//   }
			//   HG::Rendering::Runtime::SDF::MeshCombine::RecalculateBounds(v10, 0LL);
			//   v16 = UnityEngine::Resources::GetBuiltinResource<System::Object>(
			//           (String *)"Sphere.fbx",
			//           MethodInfo::UnityEngine::Resources::GetBuiltinResource<UnityEngine::Mesh>);
			//   Bounds = HG::Rendering::Runtime::SDF::MeshCombine::GetBounds(&v35, v10, 0LL);
			//   v18 = *(__m128i *)&Bounds.m_Center.x;
			//   *(_QWORD *)&v35.m_Extents.y = *(_QWORD *)&Bounds.m_Extents.y;
			//   Vector = UnityEngine::Animator::GetVector(&v33, v19, v20, v21);
			//   v23 = *(_QWORD *)&Vector.x;
			//   *(float *)&Vector = Vector.z;
			//   *(_QWORD *)&v34.x = v23;
			//   LODWORD(v34.z) = (_DWORD)Vector;
			//   identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v35, v24);
			//   *(_QWORD *)&v33.x = v18.m128i_i64[0];
			//   v26 = *identity;
			//   LODWORD(v33.z) = _mm_cvtsi128_si32(_mm_srli_si128(v18, 8));
			//   *(Quaternion *)&v35.m_Center.x = v26;
			//   v27 = UnityEngine::Matrix4x4::TRS(v37, &v33, (Quaternion *)&v35, &v34, 0LL);
			//   v28 = *(_OWORD *)&v27.m01;
			//   *(_OWORD *)&v36.m00 = *(_OWORD *)&v27.m00;
			//   v29 = *(_OWORD *)&v27.m02;
			//   *(_OWORD *)&v36.m01 = v28;
			//   v30 = *(_OWORD *)&v27.m03;
			//   *(_OWORD *)&v36.m02 = v29;
			//   *(_OWORD *)&v36.m03 = v30;
			//   HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(v10, (Mesh *)v16, &v36, 0LL);
			//   return v10;
			// }
			// 
			return null;
		}

		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			// // Void ValidateRenderTextureDesc(RenderTextureDescriptor)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc(
			//         RenderTextureDescriptor *desc,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   InvalidEnumArgumentException *v6; // rbx
			//   String *v7; // rax
			//   __int64 v8; // rax
			//   String *v9; // rdi
			//   String *v10; // rbx
			//   String *v11; // rax
			//   String *v12; // rdi
			//   __int64 v13; // rax
			//   ArgumentException *v14; // rbx
			//   String *v15; // rax
			//   __int64 v16; // rax
			//   String *v17; // rdi
			//   String *v18; // rbx
			//   String *v19; // rax
			//   String *v20; // rdi
			//   __int64 v21; // rax
			//   ArgumentException *v22; // rbx
			//   String *v23; // rax
			//   __int64 v24; // rax
			//   __int64 v25; // rax
			//   ArgumentException *v26; // rdi
			//   String *v27; // rbx
			//   String *v28; // rax
			//   __int64 v29; // rax
			//   __int64 v30; // rax
			//   ArgumentException *v31; // rdi
			//   String *v32; // rbx
			//   String *v33; // rax
			//   __int64 v34; // rax
			//   __int64 v35; // rax
			//   ArgumentException *v36; // rdi
			//   String *v37; // rbx
			//   String *v38; // rax
			//   __int64 v39; // rax
			//   __int64 v40; // rax
			//   ArgumentException *v41; // rdi
			//   String *v42; // rbx
			//   String *v43; // rax
			//   __int64 v44; // rax
			//   __int64 v45; // rax
			//   ArgumentException *v46; // rdi
			//   String *v47; // rbx
			//   String *v48; // rax
			//   __int64 v49; // rax
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   Enum v53; // [rsp+20h] [rbp-60h] BYREF
			//   int32_t graphicsFormat; // [rsp+30h] [rbp-50h]
			//   RenderTextureDescriptor v55; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D919804 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormatUtility);
			//     byte_18D919804 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4421, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4421, 0LL);
			//     if ( !Patch )
			//       goto LABEL_37;
			//     v50 = *(_OWORD *)&desc._width_k__BackingField;
			//     v51 = *(_OWORD *)&desc._mipCount_k__BackingField;
			//     v55._memoryless_k__BackingField = desc._memoryless_k__BackingField;
			//     *(_OWORD *)&v55._width_k__BackingField = v50;
			//     v52 = *(_OWORD *)&desc._dimension_k__BackingField;
			//     *(_OWORD *)&v55._mipCount_k__BackingField = v51;
			//     *(_OWORD *)&v55._dimension_k__BackingField = v52;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1265(Patch, &v55, 0LL);
			//     return;
			//   }
			//   if ( desc._graphicsFormat )
			//     goto LABEL_41;
			//   if ( !desc._depthStencilFormat_k__BackingField )
			//   {
			//     v3 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v6 = (InvalidEnumArgumentException *)sub_180004920(v3);
			//     if ( v6 )
			//     {
			//       v7 = (String *)sub_18000F7E0(&off_18D521AE0);
			//       System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v6, v7, 0LL);
			//       v8 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//       sub_18000F7C0(v6, v8);
			//     }
			//     goto LABEL_37;
			//   }
			//   if ( desc._graphicsFormat )
			//   {
			// LABEL_41:
			//     if ( !UnityEngine::SystemInfo::IsFormatSupported(
			//             (GraphicsFormat__Enum)desc._graphicsFormat,
			//             FormatUsage__Enum_Render,
			//             0LL) )
			//     {
			//       v53.monitor = (MonitorData *)-1LL;
			//       v53.klass = (Enum__Class *)sub_18000F7E0(&TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat);
			//       graphicsFormat = desc._graphicsFormat;
			//       v9 = System::Enum::ToString(&v53, 0LL);
			//       v10 = (String *)sub_18000F7E0(&off_18D521AF0);
			//       v11 = (String *)sub_18000F7E0(&off_18D521AF8);
			//       v12 = System::String::Concat(v11, v9, v10, 0LL);
			//       v13 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//       v14 = (ArgumentException *)sub_180004920(v13);
			//       if ( v14 )
			//       {
			//         v15 = (String *)sub_18000F7E0(&off_18D521B20);
			//         System::ArgumentException::ArgumentException(v14, v12, v15, 0LL);
			//         v16 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//         sub_18000F7C0(v14, v16);
			//       }
			//       goto LABEL_37;
			//     }
			//   }
			//   if ( desc._depthStencilFormat_k__BackingField )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormatUtility);
			//     if ( !UnityEngine::Experimental::Rendering::GraphicsFormatUtility::IsDepthFormat(
			//             (GraphicsFormat__Enum)desc._depthStencilFormat_k__BackingField,
			//             0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormatUtility);
			//       if ( !UnityEngine::Experimental::Rendering::GraphicsFormatUtility::IsStencilFormat(
			//               (GraphicsFormat__Enum)desc._depthStencilFormat_k__BackingField,
			//               0LL) )
			//       {
			//         v53.monitor = (MonitorData *)-1LL;
			//         v53.klass = (Enum__Class *)sub_18000F7E0(&TypeInfo::UnityEngine::Experimental::Rendering::GraphicsFormat);
			//         graphicsFormat = desc._depthStencilFormat_k__BackingField;
			//         v17 = System::Enum::ToString(&v53, 0LL);
			//         v18 = (String *)sub_18000F7E0(&off_18D521AF0);
			//         v19 = (String *)sub_18000F7E0(&off_18D521B28);
			//         v20 = System::String::Concat(v19, v17, v18, 0LL);
			//         v21 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//         v22 = (ArgumentException *)sub_180004920(v21);
			//         if ( v22 )
			//         {
			//           v23 = (String *)sub_18000F7E0(&off_18D521B00);
			//           System::ArgumentException::ArgumentException(v22, v20, v23, 0LL);
			//           v24 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//           sub_18000F7C0(v22, v24);
			//         }
			//         goto LABEL_37;
			//       }
			//     }
			//   }
			//   if ( desc._width_k__BackingField <= 0 )
			//   {
			//     v45 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v46 = (ArgumentException *)sub_180004920(v45);
			//     if ( v46 )
			//     {
			//       v47 = (String *)sub_18000F7E0(&off_18D521B08);
			//       v48 = (String *)sub_18000F7E0(&off_18D521B10);
			//       System::ArgumentException::ArgumentException(v46, v48, v47, 0LL);
			//       v49 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//       sub_18000F7C0(v46, v49);
			//     }
			// LABEL_37:
			//     sub_180B536AC(Patch, v4);
			//   }
			//   if ( desc._height_k__BackingField <= 0 )
			//   {
			//     v40 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v41 = (ArgumentException *)sub_180004920(v40);
			//     if ( v41 )
			//     {
			//       v42 = (String *)sub_18000F7E0(&off_18D521B18);
			//       v43 = (String *)sub_18000F7E0(&off_18D521AA8);
			//       System::ArgumentException::ArgumentException(v41, v43, v42, 0LL);
			//       v44 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//       sub_18000F7C0(v41, v44);
			//     }
			//     goto LABEL_37;
			//   }
			//   if ( desc._volumeDepth_k__BackingField <= 0 )
			//   {
			//     v35 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v36 = (ArgumentException *)sub_180004920(v35);
			//     if ( v36 )
			//     {
			//       v37 = (String *)sub_18000F7E0(&off_18D521AB0);
			//       v38 = (String *)sub_18000F7E0(&off_18D521AB8);
			//       System::ArgumentException::ArgumentException(v36, v38, v37, 0LL);
			//       v39 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//       sub_18000F7C0(v36, v39);
			//     }
			//     goto LABEL_37;
			//   }
			//   if ( desc._msaaSamples_k__BackingField != 1
			//     && desc._msaaSamples_k__BackingField != 2
			//     && desc._msaaSamples_k__BackingField != 4
			//     && desc._msaaSamples_k__BackingField != 8 )
			//   {
			//     v25 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v26 = (ArgumentException *)sub_180004920(v25);
			//     if ( v26 )
			//     {
			//       v27 = (String *)sub_18000F7E0(&off_18D521AC0);
			//       v28 = (String *)sub_18000F7E0(&off_18D521A90);
			//       System::ArgumentException::ArgumentException(v26, v28, v27, 0LL);
			//       v29 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//       sub_18000F7C0(v26, v29);
			//     }
			//     goto LABEL_37;
			//   }
			//   if ( desc._dimension_k__BackingField == 6
			//     && desc._volumeDepth_k__BackingField != 6 * (desc._volumeDepth_k__BackingField / 6u) )
			//   {
			//     v30 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v31 = (ArgumentException *)sub_180004920(v30);
			//     if ( v31 )
			//     {
			//       v32 = (String *)sub_18000F7E0(&off_18D521AB0);
			//       v33 = (String *)sub_18000F7E0(&off_18D521AA0);
			//       System::ArgumentException::ArgumentException(v31, v33, v32, 0LL);
			//       v34 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc);
			//       sub_18000F7C0(v31, v34);
			//     }
			//     goto LABEL_37;
			//   }
			// }
			// 
		}

		public static void ReleaseRenderTexture(ref RenderTexture rt)
		{
		}

		public static bool CreateRenderTextureIfNeeded(ref RenderTexture rt, RenderTextureDescriptor rtDesc)
		{
			// // Boolean CreateRenderTextureIfNeeded(RenderTexture ByRef, RenderTextureDescriptor)
			// bool HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded(
			//         RenderTexture **rt,
			//         RenderTextureDescriptor *rtDesc,
			//         MethodInfo *method)
			// {
			//   struct VolumetricSDFUtils__Class *v5; // rcx
			//   int32_t msaaSamples_k__BackingField; // eax
			//   int32_t volumeDepth_k__BackingField; // r14d
			//   bool v8; // cc
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   Object_1 *v12; // rbx
			//   RenderTexture *Patch; // rcx
			//   RenderTexture *v14; // rdx
			//   RenderTextureFormat__Enum format; // ebx
			//   bool sRGB; // bl
			//   RenderTexture *v18; // rax
			//   RenderTexture *v19; // rbx
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v23; // rdx
			//   VolumetricRenderer_VolumetricBounds *v24; // r8
			//   Material *v25; // r9
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   RenderTextureDescriptor v29; // [rsp+20h] [rbp-40h] BYREF
			//   bool v30; // [rsp+58h] [rbp-8h]
			//   MethodInfo *vars0; // [rsp+60h] [rbp+0h]
			// 
			//   if ( !byte_18D919806 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919806 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4420, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::System::Math);
			//     v5 = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils;
			//     msaaSamples_k__BackingField = 1;
			//     volumeDepth_k__BackingField = 1;
			//     if ( rtDesc._volumeDepth_k__BackingField >= 1 )
			//       volumeDepth_k__BackingField = rtDesc._volumeDepth_k__BackingField;
			//     v8 = rtDesc._msaaSamples_k__BackingField < 1;
			//     rtDesc._volumeDepth_k__BackingField = volumeDepth_k__BackingField;
			//     if ( !v8 )
			//       msaaSamples_k__BackingField = rtDesc._msaaSamples_k__BackingField;
			//     rtDesc._msaaSamples_k__BackingField = msaaSamples_k__BackingField;
			//     sub_180002C70(v5);
			//     v9 = *(_OWORD *)&rtDesc._width_k__BackingField;
			//     v10 = *(_OWORD *)&rtDesc._mipCount_k__BackingField;
			//     v29._memoryless_k__BackingField = rtDesc._memoryless_k__BackingField;
			//     *(_OWORD *)&v29._width_k__BackingField = v9;
			//     v11 = *(_OWORD *)&rtDesc._dimension_k__BackingField;
			//     *(_OWORD *)&v29._mipCount_k__BackingField = v10;
			//     *(_OWORD *)&v29._dimension_k__BackingField = v11;
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ValidateRenderTextureDesc(&v29, 0LL);
			//     v12 = (Object_1 *)*rt;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(v12, 0LL, 0LL) )
			//     {
			//       v14 = *rt;
			//       if ( !*rt )
			//         goto LABEL_34;
			//       if ( (unsigned int)sub_18003ED00(5LL) == rtDesc._width_k__BackingField )
			//       {
			//         v14 = *rt;
			//         if ( !*rt )
			//           goto LABEL_34;
			//         if ( (unsigned int)sub_18003ED00(7LL) == rtDesc._height_k__BackingField )
			//         {
			//           Patch = *rt;
			//           if ( !*rt )
			//             goto LABEL_34;
			//           if ( UnityEngine::RenderTexture::get_depthStencilFormat(Patch, 0LL) == rtDesc._depthStencilFormat_k__BackingField )
			//           {
			//             Patch = *rt;
			//             if ( !*rt )
			//               goto LABEL_34;
			//             if ( UnityEngine::RenderTexture::get_volumeDepth(Patch, 0LL) == volumeDepth_k__BackingField )
			//             {
			//               Patch = *rt;
			//               if ( !*rt )
			//                 goto LABEL_34;
			//               format = UnityEngine::RenderTexture::get_format(Patch, 0LL);
			//               if ( format == UnityEngine::RenderTextureDescriptor::get_colorFormat(rtDesc, 0LL) )
			//               {
			//                 v14 = *rt;
			//                 if ( !*rt )
			//                   goto LABEL_34;
			//                 if ( (unsigned int)sub_18003ED00(9LL) == rtDesc._dimension_k__BackingField )
			//                 {
			//                   Patch = *rt;
			//                   if ( !*rt )
			//                     goto LABEL_34;
			//                   sRGB = UnityEngine::RenderTexture::get_sRGB(Patch, 0LL);
			//                   if ( sRGB == UnityEngine::RenderTextureDescriptor::get_sRGB(rtDesc, 0LL) )
			//                   {
			//                     Patch = *rt;
			//                     if ( !*rt )
			//                       goto LABEL_34;
			//                     if ( UnityEngine::RenderTexture::get_enableRandomWrite(Patch, 0LL) == ((rtDesc._flags & 0x10) != 0) )
			//                     {
			//                       Patch = *rt;
			//                       if ( !*rt )
			//                         goto LABEL_34;
			//                       if ( UnityEngine::RenderTexture::get_useMipMap(Patch, 0LL) == ((rtDesc._flags & 1) != 0) )
			//                       {
			//                         Patch = *rt;
			//                         if ( !*rt )
			//                           goto LABEL_34;
			//                         if ( UnityEngine::RenderTexture::get_autoGenerateMips(Patch, 0LL) == ((rtDesc._flags & 2) != 0) )
			//                           return 0;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseRenderTexture(rt, 0LL);
			//     v18 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//     v19 = v18;
			//     if ( v18 )
			//     {
			//       v20 = *(_OWORD *)&rtDesc._width_k__BackingField;
			//       v21 = *(_OWORD *)&rtDesc._mipCount_k__BackingField;
			//       v29._memoryless_k__BackingField = rtDesc._memoryless_k__BackingField;
			//       *(_OWORD *)&v29._width_k__BackingField = v20;
			//       v22 = *(_OWORD *)&rtDesc._dimension_k__BackingField;
			//       *(_OWORD *)&v29._mipCount_k__BackingField = v21;
			//       *(_OWORD *)&v29._dimension_k__BackingField = v22;
			//       UnityEngine::RenderTexture::RenderTexture(v18, &v29, 0LL);
			//       *rt = v19;
			//       sub_1800054D0(
			//         (VolumetricRenderer_VolumetricRenderItem *)rt,
			//         v23,
			//         v24,
			//         v25,
			//         *(MethodInfo **)&v29._width_k__BackingField,
			//         *(MethodInfo **)&v29._msaaSamples_k__BackingField,
			//         v29._mipCount_k__BackingField,
			//         v29._stencilFormat_k__BackingField,
			//         *(float *)&v29._dimension_k__BackingField,
			//         v29._vrUsage_k__BackingField,
			//         v29._memoryless_k__BackingField,
			//         v30,
			//         vars0);
			//       Patch = *rt;
			//       if ( *rt )
			//       {
			//         UnityEngine::RenderTexture::Create(Patch, 0LL);
			//         return 1;
			//       }
			//     }
			// LABEL_34:
			//     sub_180B536AC(Patch, v14);
			//   }
			//   Patch = (RenderTexture *)IFix::WrappersManagerImpl::GetPatch(4420, 0LL);
			//   if ( !Patch )
			//     goto LABEL_34;
			//   memoryless_k__BackingField = rtDesc._memoryless_k__BackingField;
			//   v27 = *(_OWORD *)&rtDesc._mipCount_k__BackingField;
			//   *(_OWORD *)&v29._width_k__BackingField = *(_OWORD *)&rtDesc._width_k__BackingField;
			//   v28 = *(_OWORD *)&rtDesc._dimension_k__BackingField;
			//   v29._memoryless_k__BackingField = memoryless_k__BackingField;
			//   *(_OWORD *)&v29._mipCount_k__BackingField = v27;
			//   *(_OWORD *)&v29._dimension_k__BackingField = v28;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1266((ILFixDynamicMethodWrapper_2 *)Patch, rt, &v29, 0LL);
			// }
			// 
			return default(bool);
		}

		public static void ReleaseEncodedRenderTexture(ref VolumetricEncodedTexture ert)
		{
		}

		public static bool CreateEncodedRenderTextureIfNeeded(ref VolumetricEncodedTexture ert, RenderTextureDescriptor rtDesc)
		{
			// // Boolean CreateEncodedRenderTextureIfNeeded(VolumetricEncodedTexture ByRef, RenderTextureDescriptor)
			// bool HG::Rendering::Runtime::VolumetricSDFUtils::CreateEncodedRenderTextureIfNeeded(
			//         VolumetricEncodedTexture **ert,
			//         RenderTextureDescriptor *rtDesc,
			//         MethodInfo *method)
			// {
			//   char v5; // r14
			//   VolumetricEncodedTexture *v6; // rbx
			//   Object_1 *Texture; // rbx
			//   VolumetricEncodedTexture *v8; // rbx
			//   Texture *v9; // rax
			//   VolumetricEncodedTexture *v10; // rdx
			//   VolumetricEncodedTexture *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   VolumetricEncodedTexture *v13; // rbx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rdx
			//   VolumetricRenderer_VolumetricBounds *v15; // r8
			//   Material *v16; // r9
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   bool v20; // al
			//   VolumetricRenderer_VolumetricBounds *v21; // r8
			//   Material *v22; // r9
			//   bool v23; // r9
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   RenderTextureDescriptor v28; // [rsp+20h] [rbp-40h] BYREF
			//   bool v29; // [rsp+58h] [rbp-8h]
			//   MethodInfo *vars0; // [rsp+60h] [rbp+0h]
			//   Texture *v31; // [rsp+98h] [rbp+38h] BYREF
			// 
			//   if ( !byte_18D919808 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919808 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4630, 0LL) )
			//   {
			//     v5 = 0;
			//     v6 = *ert;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     Texture = (Object_1 *)HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(v6, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(Texture, 0LL, 0LL)
			//       || (v8 = *ert,
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils),
			//           v9 = HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(v8, 0LL),
			//           !sub_18003F5A0(v9, TypeInfo::UnityEngine::RenderTexture)) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseEncodedRenderTexture(ert, 0LL);
			//       v11 = (VolumetricEncodedTexture *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//       v13 = v11;
			//       if ( !v11 )
			//         goto LABEL_12;
			//       HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(v11, 0LL);
			//       *ert = v13;
			//       sub_1800054D0(
			//         (VolumetricRenderer_VolumetricRenderItem *)ert,
			//         v14,
			//         v15,
			//         v16,
			//         *(MethodInfo **)&v28._width_k__BackingField,
			//         *(MethodInfo **)&v28._msaaSamples_k__BackingField,
			//         v28._mipCount_k__BackingField,
			//         v28._stencilFormat_k__BackingField,
			//         *(float *)&v28._dimension_k__BackingField,
			//         v28._vrUsage_k__BackingField,
			//         v28._memoryless_k__BackingField,
			//         v29,
			//         vars0);
			//       v5 = 1;
			//     }
			//     Patch = (ILFixDynamicMethodWrapper_2 *)*ert;
			//     if ( *ert )
			//     {
			//       v31 = (Texture *)sub_18003F5A0(Patch.fields.virtualMachine, TypeInfo::UnityEngine::RenderTexture);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v17 = *(_OWORD *)&rtDesc._width_k__BackingField;
			//       v18 = *(_OWORD *)&rtDesc._mipCount_k__BackingField;
			//       v28._memoryless_k__BackingField = rtDesc._memoryless_k__BackingField;
			//       *(_OWORD *)&v28._width_k__BackingField = v17;
			//       v19 = *(_OWORD *)&rtDesc._dimension_k__BackingField;
			//       *(_OWORD *)&v28._mipCount_k__BackingField = v18;
			//       *(_OWORD *)&v28._dimension_k__BackingField = v19;
			//       v20 = HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded((RenderTexture **)&v31, &v28, 0LL);
			//       v10 = *ert;
			//       if ( *ert )
			//       {
			//         v10.fields.Tex = v31;
			//         LOBYTE(v22) = v5 | v20;
			//         sub_1800054D0(
			//           (VolumetricRenderer_VolumetricRenderItem *)&v10.fields,
			//           (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v10,
			//           v21,
			//           v22,
			//           *(MethodInfo **)&v28._width_k__BackingField,
			//           *(MethodInfo **)&v28._msaaSamples_k__BackingField,
			//           v28._mipCount_k__BackingField,
			//           v28._stencilFormat_k__BackingField,
			//           *(float *)&v28._dimension_k__BackingField,
			//           v28._vrUsage_k__BackingField,
			//           v28._memoryless_k__BackingField,
			//           v29,
			//           vars0);
			//         return v23;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4630, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   memoryless_k__BackingField = rtDesc._memoryless_k__BackingField;
			//   v26 = *(_OWORD *)&rtDesc._mipCount_k__BackingField;
			//   *(_OWORD *)&v28._width_k__BackingField = *(_OWORD *)&rtDesc._width_k__BackingField;
			//   v27 = *(_OWORD *)&rtDesc._dimension_k__BackingField;
			//   v28._memoryless_k__BackingField = memoryless_k__BackingField;
			//   *(_OWORD *)&v28._mipCount_k__BackingField = v26;
			//   *(_OWORD *)&v28._dimension_k__BackingField = v27;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1328(Patch, ert, &v28, 0LL);
			// }
			// 
			return default(bool);
		}

		public static RenderTexture GetTemporaryTexture(RenderTextureDescriptor rtDesc)
		{
			// // RenderTexture GetTemporaryTexture(RenderTextureDescriptor)
			// RenderTexture *HG::Rendering::Runtime::VolumetricSDFUtils::GetTemporaryTexture(
			//         RenderTextureDescriptor *rtDesc,
			//         MethodInfo *method)
			// {
			//   int32_t depthBufferBits; // ebx
			//   RenderTextureFormat__Enum colorFormat; // eax
			//   __int64 v6; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   RenderTextureDescriptor v11; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4425, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4425, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v6);
			//     v8 = *(_OWORD *)&rtDesc._width_k__BackingField;
			//     v9 = *(_OWORD *)&rtDesc._mipCount_k__BackingField;
			//     v11._memoryless_k__BackingField = rtDesc._memoryless_k__BackingField;
			//     *(_OWORD *)&v11._width_k__BackingField = v8;
			//     v10 = *(_OWORD *)&rtDesc._dimension_k__BackingField;
			//     *(_OWORD *)&v11._mipCount_k__BackingField = v9;
			//     *(_OWORD *)&v11._dimension_k__BackingField = v10;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1269(Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     depthBufferBits = UnityEngine::RenderTextureDescriptor::get_depthBufferBits(rtDesc, 0LL);
			//     colorFormat = UnityEngine::RenderTextureDescriptor::get_colorFormat(rtDesc, 0LL);
			//     return UnityEngine::RenderTexture::GetTemporary(
			//              rtDesc._width_k__BackingField,
			//              rtDesc._height_k__BackingField,
			//              depthBufferBits,
			//              colorFormat,
			//              0LL);
			//   }
			// }
			// 
			return null;
		}

		public static void ReleaseTemporaryTexture(ref RenderTexture texture)
		{
		}

		public static void CreateCommandBufferIfNeeded(ref CommandBuffer cmd, string name)
		{
		}

		public static void ReleaseCommandBuffer(ref CommandBuffer cmd)
		{
			// // Void ReleaseCommandBuffer(CommandBuffer ByRef)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseCommandBuffer(CommandBuffer **cmd, MethodInfo *method)
			// {
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
			//   VolumetricRenderer_VolumetricBounds *v4; // r8
			//   Material *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			//   int32_t v11; // [rsp+60h] [rbp+38h]
			//   int32_t v12; // [rsp+68h] [rbp+40h]
			//   float v13; // [rsp+70h] [rbp+48h]
			//   int32_t v14; // [rsp+78h] [rbp+50h]
			//   bool v15; // [rsp+80h] [rbp+58h]
			//   bool v16; // [rsp+88h] [rbp+60h]
			//   MethodInfo *v17; // [rsp+90h] [rbp+68h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4632, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4632, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1330(Patch, cmd, 0LL);
			//   }
			//   else if ( *cmd )
			//   {
			//     UnityEngine::Rendering::CommandBuffer::Dispose(*cmd, 0LL);
			//     *cmd = 0LL;
			//     sub_1800054D0(
			//       (VolumetricRenderer_VolumetricRenderItem *)cmd,
			//       v3,
			//       v4,
			//       v5,
			//       v9,
			//       v10,
			//       v11,
			//       v12,
			//       v13,
			//       v14,
			//       v15,
			//       v16,
			//       v17);
			//   }
			// }
			// 
		}

		public static void SetVolumetricMaterialMVMode(CommandBuffer cmd, Material mat, int mode)
		{
			// // Void SetVolumetricMaterialMVMode(CommandBuffer, Material, Int32)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         int32_t mode,
			//         MethodInfo *method)
			// {
			//   int i; // ebx
			//   VolumetricSDFUtils__StaticFields *static_fields; // rdx
			//   _QWORD *p_Layer_Default; // rcx
			//   __int64 v10; // rax
			//   Shader *v11; // r15
			//   String__Array *v12; // r8
			//   String *v13; // r8
			//   Shader *shader; // r15
			//   String__Array *s_MV_MODES; // r8
			//   String *v16; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LocalKeyword keyword; // [rsp+30h] [rbp-30h] BYREF
			//   LocalKeyword v19; // [rsp+48h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91980B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D91980B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4462, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4462, 0LL);
			//     if ( !Patch )
			//       goto LABEL_25;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(
			//       (ILFixDynamicMethodWrapper_16 *)Patch,
			//       (Object *)cmd,
			//       (Object *)mat,
			//       mode,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)mat, 0LL) )
			//     {
			//       for ( i = 1; ; ++i )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         p_Layer_Default = &TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields.Layer_Default;
			//         v10 = p_Layer_Default[9];
			//         if ( !v10 )
			//           break;
			//         if ( i >= *(_DWORD *)(v10 + 24) )
			//           return;
			//         if ( mode == i )
			//         {
			//           if ( !mat )
			//             goto LABEL_23;
			//           shader = UnityEngine::Material::get_shader(mat, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           p_Layer_Default = &TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils._0.image;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields;
			//           s_MV_MODES = static_fields.s_MV_MODES;
			//           if ( !s_MV_MODES )
			//             goto LABEL_23;
			//           if ( (unsigned int)i >= s_MV_MODES.max_length.size )
			//             sub_180070270(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils, static_fields);
			//           v16 = s_MV_MODES.vector[i];
			//           memset(&v19, 0, sizeof(v19));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, v16, 0LL);
			//           keyword = v19;
			//           if ( !cmd )
			// LABEL_23:
			//             sub_180B536AC(p_Layer_Default, static_fields);
			//           UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//         }
			//         else
			//         {
			//           if ( !mat )
			//             goto LABEL_21;
			//           v11 = UnityEngine::Material::get_shader(mat, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           p_Layer_Default = &TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils._0.image;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils.static_fields;
			//           v12 = static_fields.s_MV_MODES;
			//           if ( !v12 )
			//             goto LABEL_21;
			//           if ( (unsigned int)i >= v12.max_length.size )
			//             sub_180070270(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils, static_fields);
			//           v13 = v12.vector[i];
			//           memset(&v19, 0, sizeof(v19));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, v11, v13, 0LL);
			//           keyword = v19;
			//           if ( !cmd )
			// LABEL_21:
			//             sub_180B536AC(p_Layer_Default, static_fields);
			//           UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//         }
			//       }
			// LABEL_25:
			//       sub_180B536AC(p_Layer_Default, static_fields);
			//     }
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static Vector3 UpdateMainLightDirection(Material cloudMat, HGEnvironmentPhase phase)
		{
			// // Vector3 UpdateMainLightDirection(Material, HGEnvironmentPhase)
			// Vector3 *HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
			//         Vector3 *__return_ptr retstr,
			//         Material *cloudMat,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v7; // rdx
			//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
			//   MethodInfo *v9; // r8
			//   float v10; // eax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   int32_t MainLightDirection; // ebx
			//   double v16; // xmm0_8
			//   float v17; // xmm6_4
			//   double v18; // xmm0_8
			//   double v19; // xmm0_8
			//   double v20; // xmm0_8
			//   float v21; // xmm6_4
			//   double v22; // xmm0_8
			//   double v23; // xmm0_8
			//   float v24; // xmm6_4
			//   double v25; // xmm0_8
			//   double v26; // xmm0_8
			//   double v27; // xmm0_8
			//   Vector3 *up; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v30; // xmm0_8
			//   float z; // eax
			//   Vector3 v33; // [rsp+30h] [rbp-50h] BYREF
			//   Vector4 v34; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D91980C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D91980C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4454, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4454, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     up = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_324(
			//            (Vector3 *)&v34,
			//            Patch,
			//            (Object *)cloudMat,
			//            (Object *)phase,
			//            0LL);
			// LABEL_15:
			//     v30 = *(_QWORD *)&up.x;
			//     z = up.z;
			//     *(_QWORD *)&retstr.x = v30;
			//     retstr.z = z;
			//     return retstr;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit((Object_1 *)cloudMat, 0LL)
			//     || (sub_180002C70(TypeInfo::UnityEngine::Object), !UnityEngine::Object::op_Implicit((Object_1 *)phase, 0LL)) )
			//   {
			//     up = UnityEngine::Vector3::get_up((Vector3 *)&v34, v7);
			//     goto LABEL_15;
			//   }
			//   if ( !phase
			//     || (sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs),
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields,
			//         !cloudMat) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(static_fields, v7);
			//   }
			//   UnityEngine::Material::GetFloatImpl(cloudMat, static_fields._YawOffset, 0LL);
			//   UnityEngine::Material::GetFloatImpl(
			//     cloudMat,
			//     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PitchOffset,
			//     0LL);
			//   if ( UnityEngine::Material::GetInt(
			//          cloudMat,
			//          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._UseSunDirection,
			//          0LL) > 0 )
			//   {
			//     v10 = phase.fields.lightConfig.forwardDirect.z;
			//     *(_QWORD *)&v33.x = *(_QWORD *)&phase.fields.lightConfig.forwardDirect.x;
			//     v33.z = v10;
			//     *(_QWORD *)&v33.x = *(_QWORD *)&UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v34, &v33, v9).x;
			//     sub_1802E8980(v12, v11);
			//     sub_1802E8DF0(v14, v13);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   MainLightDirection = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._MainLightDirection;
			//   v16 = Beyond::DampingMath::cosf();
			//   v17 = *(float *)&v16;
			//   v18 = Beyond::DampingMath::cosf();
			//   v34.x = v17 * *(float *)&v18;
			//   v19 = Beyond::DampingMath::sinf();
			//   v34.y = *(float *)&v19;
			//   v20 = Beyond::DampingMath::cosf();
			//   v21 = *(float *)&v20;
			//   v22 = Beyond::DampingMath::sinf();
			//   *(_QWORD *)&v34.z = COERCE_UNSIGNED_INT(v21 * *(float *)&v22);
			//   UnityEngine::Material::SetVector(cloudMat, MainLightDirection, &v34, 0LL);
			//   v23 = Beyond::DampingMath::cosf();
			//   v24 = *(float *)&v23;
			//   v25 = Beyond::DampingMath::cosf();
			//   retstr.x = *(float *)&v25 * v24;
			//   v26 = Beyond::DampingMath::sinf();
			//   retstr.y = *(float *)&v26;
			//   v27 = Beyond::DampingMath::sinf();
			//   retstr.z = *(float *)&v27 * v24;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static void UpdateMainLightDirection(Material cloudMat, MaterialPropertyBlock propertyBlock, HGEnvironmentPhase phase)
		{
			// // Void UpdateMainLightDirection(Material, MaterialPropertyBlock, HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
			//         Material *cloudMat,
			//         MaterialPropertyBlock *propertyBlock,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
			//   MethodInfo *v9; // r8
			//   float z; // eax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   int32_t MainLightDirection; // ebx
			//   double v16; // xmm0_8
			//   float v17; // xmm6_4
			//   double v18; // xmm0_8
			//   double v19; // xmm0_8
			//   double v20; // xmm0_8
			//   float v21; // xmm6_4
			//   double v22; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v24; // [rsp+30h] [rbp-50h] BYREF
			//   Vector4 v25; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D91980D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D91980D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4633, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4633, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)cloudMat,
			//         (Object *)propertyBlock,
			//         (Object *)phase,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_13;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit((Object_1 *)cloudMat, 0LL) )
			//     return;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit((Object_1 *)phase, 0LL) || !propertyBlock )
			//     return;
			//   if ( !phase
			//     || (sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs),
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields,
			//         !cloudMat) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(static_fields, v7);
			//   }
			//   UnityEngine::Material::GetFloatImpl(cloudMat, static_fields._YawOffset, 0LL);
			//   UnityEngine::Material::GetFloatImpl(
			//     cloudMat,
			//     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PitchOffset,
			//     0LL);
			//   if ( UnityEngine::Material::GetInt(
			//          cloudMat,
			//          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._UseSunDirection,
			//          0LL) > 0 )
			//   {
			//     z = phase.fields.lightConfig.forwardDirect.z;
			//     *(_QWORD *)&v24.x = *(_QWORD *)&phase.fields.lightConfig.forwardDirect.x;
			//     v24.z = z;
			//     *(_QWORD *)&v24.x = *(_QWORD *)&UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v25, &v24, v9).x;
			//     sub_1802E8980(v12, v11);
			//     sub_1802E8DF0(v14, v13);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   MainLightDirection = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._MainLightDirection;
			//   v16 = Beyond::DampingMath::cosf();
			//   v17 = *(float *)&v16;
			//   v18 = Beyond::DampingMath::cosf();
			//   v25.x = v17 * *(float *)&v18;
			//   v19 = Beyond::DampingMath::sinf();
			//   v25.y = *(float *)&v19;
			//   v20 = Beyond::DampingMath::cosf();
			//   v21 = *(float *)&v20;
			//   v22 = Beyond::DampingMath::sinf();
			//   *(_QWORD *)&v25.z = COERCE_UNSIGNED_INT(v21 * *(float *)&v22);
			//   UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, MainLightDirection, &v25, 0LL);
			// }
			// 
		}

		public unsafe static void UpdateMainLightDirectionCPP(Material cloudMat, HGVolumetricCloudDataCB* dataCB, HGEnvironmentPhase phase)
		{
			// // Void UpdateMainLightDirectionCPP(Material, HGVolumetricCloudDataCB*, HGEnvironmentPhase)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirectionCPP(
			//         Material *cloudMat,
			//         HGVolumetricCloudDataCB *dataCB,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
			//   MethodInfo *v9; // r8
			//   float z; // eax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   double v15; // xmm0_8
			//   float v16; // xmm6_4
			//   double v17; // xmm0_8
			//   double v18; // xmm0_8
			//   double v19; // xmm0_8
			//   float v20; // xmm6_4
			//   double v21; // xmm0_8
			//   Vector3 v22; // [rsp+20h] [rbp-58h] BYREF
			//   Vector4 v23; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D91980E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D91980E = 1;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Implicit((Object_1 *)cloudMat, 0LL) )
			//   {
			//     if ( !phase )
			//       goto LABEL_11;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !cloudMat )
			//       goto LABEL_11;
			//     UnityEngine::Material::GetFloatImpl(cloudMat, static_fields._YawOffset, 0LL);
			//     UnityEngine::Material::GetFloatImpl(
			//       cloudMat,
			//       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PitchOffset,
			//       0LL);
			//     if ( UnityEngine::Material::GetInt(
			//            cloudMat,
			//            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._UseSunDirection,
			//            0LL) > 0 )
			//     {
			//       z = phase.fields.lightConfig.forwardDirect.z;
			//       *(_QWORD *)&v22.x = *(_QWORD *)&phase.fields.lightConfig.forwardDirect.x;
			//       v22.z = z;
			//       *(_QWORD *)&v22.x = *(_QWORD *)&UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v23, &v22, v9).x;
			//       sub_1802E8980(v12, v11);
			//       sub_1802E8DF0(v14, v13);
			//     }
			//     v15 = Beyond::DampingMath::cosf();
			//     v16 = *(float *)&v15;
			//     v17 = Beyond::DampingMath::cosf();
			//     v23.x = v16 * *(float *)&v17;
			//     v18 = Beyond::DampingMath::sinf();
			//     v23.y = *(float *)&v18;
			//     v19 = Beyond::DampingMath::cosf();
			//     v20 = *(float *)&v19;
			//     v21 = Beyond::DampingMath::sinf();
			//     *(_QWORD *)&v23.z = COERCE_UNSIGNED_INT(v20 * *(float *)&v21);
			//     if ( !dataCB )
			// LABEL_11:
			//       sub_180B536AC(static_fields, v7);
			//     dataCB._MainLightDirection = v23;
			//   }
			// }
			// 
		}

		public static Bounds CalculateBounds(Mesh mesh, Transform transform)
		{
			// // Bounds CalculateBounds(Mesh, Transform)
			// Bounds *HG::Rendering::Runtime::VolumetricSDFUtils::CalculateBounds(
			//         Bounds *__return_ptr retstr,
			//         Mesh *mesh,
			//         Transform *transform,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Bounds *bounds; // rax
			//   __int64 v10; // xmm1_8
			//   __int64 v11; // r8
			//   __int64 v12; // r9
			//   __int64 v13; // r14
			//   Vector3 *min; // rax
			//   __int64 v15; // xmm0_8
			//   Vector3 *v16; // rax
			//   __int64 v17; // xmm0_8
			//   float z; // eax
			//   Vector3 *v19; // rbx
			//   __m128 y_low; // xmm6
			//   Vector3 *max; // rax
			//   unsigned __int64 v22; // xmm0_8
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm0_8
			//   Vector3 *v25; // rbx
			//   __m128 v26; // xmm6
			//   Vector3 *v27; // rax
			//   unsigned __int64 v28; // xmm0_8
			//   Vector3 *v29; // rax
			//   __int64 v30; // xmm0_8
			//   Vector3 *v31; // rbx
			//   __m128 v32; // xmm6
			//   Vector3 *v33; // rax
			//   unsigned __int64 v34; // xmm0_8
			//   Vector3 *v35; // rax
			//   __int64 v36; // xmm0_8
			//   Vector3 *v37; // rax
			//   __int64 v38; // xmm0_8
			//   Vector3 *v39; // rax
			//   __int64 v40; // xmm0_8
			//   Vector3 *v41; // rbx
			//   __m128 v42; // xmm6
			//   Vector3 *v43; // rax
			//   unsigned __int64 v44; // xmm0_8
			//   Vector3 *v45; // rax
			//   __int64 v46; // xmm0_8
			//   Vector3 *v47; // rbx
			//   __m128 v48; // xmm6
			//   Vector3 *v49; // rax
			//   unsigned __int64 v50; // xmm0_8
			//   Vector3 *v51; // rax
			//   __int64 v52; // xmm0_8
			//   Vector3 *v53; // rbx
			//   __m128 v54; // xmm6
			//   Vector3 *v55; // rax
			//   unsigned __int64 v56; // xmm0_8
			//   Vector3 *v57; // rax
			//   __int64 v58; // rsi
			//   __int64 v59; // xmm0_8
			//   __int64 v60; // xmm6_8
			//   __int64 v61; // rbx
			//   __int128 v62; // xmm7
			//   Bounds *v63; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Bounds *v65; // rax
			//   __int64 v66; // xmm1_8
			//   Bounds v68; // [rsp+38h] [rbp-39h] BYREF
			//   Vector3 m_Center; // [rsp+58h] [rbp-19h] BYREF
			//   Bounds v70; // [rsp+68h] [rbp-9h] BYREF
			//   Bounds v71[2]; // [rsp+88h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D91980F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D91980F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4458, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4458, 0LL);
			//     if ( Patch )
			//     {
			//       v65 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1281(v71, Patch, (Object *)mesh, (Object *)transform, 0LL);
			//       v66 = *(_QWORD *)&v65.m_Extents.y;
			//       *(_OWORD *)&retstr.m_Center.x = *(_OWORD *)&v65.m_Center.x;
			//       *(_QWORD *)&retstr.m_Extents.y = v66;
			//       return retstr;
			//     }
			//     goto LABEL_14;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality((Object_1 *)mesh, 0LL, 0LL)
			//     || (sub_180002C70(TypeInfo::UnityEngine::Object),
			//         !UnityEngine::Object::op_Inequality((Object_1 *)transform, 0LL, 0LL)) )
			//   {
			//     *(_OWORD *)&retstr.m_Center.x = 0LL;
			//     *(_QWORD *)&v71[0].m_Extents.y = 0LL;
			//     *(_QWORD *)&retstr.m_Extents.y = 0LL;
			//     return retstr;
			//   }
			//   if ( !mesh )
			//     goto LABEL_14;
			//   bounds = UnityEngine::Mesh::get_bounds(&v70, mesh, 0LL);
			//   v10 = *(_QWORD *)&bounds.m_Extents.y;
			//   *(_OWORD *)&v71[0].m_Center.x = *(_OWORD *)&bounds.m_Center.x;
			//   *(_QWORD *)&v71[0].m_Extents.y = v10;
			//   v13 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 8LL, v11, v12);
			//   min = UnityEngine::Bounds::get_min(&v70.m_Center, v71, 0LL);
			//   if ( !transform
			//     || (v15 = *(_QWORD *)&min.x,
			//         v68.m_Center.z = min.z,
			//         *(_QWORD *)&v68.m_Center.x = v15,
			//         v16 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &v68.m_Center, 0LL),
			//         !v13) )
			//   {
			// LABEL_14:
			//     sub_180B536AC(v8, v7);
			//   }
			//   v17 = *(_QWORD *)&v16.x;
			//   z = v16.z;
			//   *(_QWORD *)&m_Center.x = v17;
			//   m_Center.z = z;
			//   sub_180040FA0(v13, 0LL, &m_Center);
			//   v19 = UnityEngine::Bounds::get_min(&v70.m_Center, v71, 0LL);
			//   y_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v71, 0LL).y);
			//   max = UnityEngine::Bounds::get_max(&m_Center, v71, 0LL);
			//   v22 = _mm_unpacklo_ps((__m128)LODWORD(v19.x), y_low).m128_u64[0];
			//   m_Center.z = max.z;
			//   *(_QWORD *)&m_Center.x = v22;
			//   v23 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v24 = *(_QWORD *)&v23.x;
			//   *(float *)&v23 = v23.z;
			//   *(_QWORD *)&v68.m_Center.x = v24;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v23;
			//   sub_180040FA0(v13, 1LL, &v68);
			//   v25 = UnityEngine::Bounds::get_min(&v70.m_Center, v71, 0LL);
			//   v26 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&m_Center, v71, 0LL).y);
			//   v27 = UnityEngine::Bounds::get_min(&m_Center, v71, 0LL);
			//   v28 = _mm_unpacklo_ps((__m128)LODWORD(v25.x), v26).m128_u64[0];
			//   m_Center.z = v27.z;
			//   *(_QWORD *)&m_Center.x = v28;
			//   v29 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v30 = *(_QWORD *)&v29.x;
			//   *(float *)&v29 = v29.z;
			//   *(_QWORD *)&v68.m_Center.x = v30;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v29;
			//   sub_180040FA0(v13, 2LL, &v68);
			//   v31 = UnityEngine::Bounds::get_min(&v70.m_Center, v71, 0LL);
			//   v32 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&m_Center, v71, 0LL).y);
			//   v33 = UnityEngine::Bounds::get_max(&m_Center, v71, 0LL);
			//   v34 = _mm_unpacklo_ps((__m128)LODWORD(v31.x), v32).m128_u64[0];
			//   m_Center.z = v33.z;
			//   *(_QWORD *)&m_Center.x = v34;
			//   v35 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v36 = *(_QWORD *)&v35.x;
			//   *(float *)&v35 = v35.z;
			//   *(_QWORD *)&v68.m_Center.x = v36;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v35;
			//   sub_180040FA0(v13, 3LL, &v68);
			//   v37 = UnityEngine::Bounds::get_max(&v70.m_Center, v71, 0LL);
			//   v38 = *(_QWORD *)&v37.x;
			//   *(float *)&v37 = v37.z;
			//   *(_QWORD *)&m_Center.x = v38;
			//   LODWORD(m_Center.z) = (_DWORD)v37;
			//   v39 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v40 = *(_QWORD *)&v39.x;
			//   *(float *)&v39 = v39.z;
			//   *(_QWORD *)&v68.m_Center.x = v40;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v39;
			//   sub_180040FA0(v13, 4LL, &v68);
			//   v41 = UnityEngine::Bounds::get_max(&v70.m_Center, v71, 0LL);
			//   v42 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v71, 0LL).y);
			//   v43 = UnityEngine::Bounds::get_max(&m_Center, v71, 0LL);
			//   v44 = _mm_unpacklo_ps((__m128)LODWORD(v41.x), v42).m128_u64[0];
			//   m_Center.z = v43.z;
			//   *(_QWORD *)&m_Center.x = v44;
			//   v45 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v46 = *(_QWORD *)&v45.x;
			//   *(float *)&v45 = v45.z;
			//   *(_QWORD *)&v68.m_Center.x = v46;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v45;
			//   sub_180040FA0(v13, 5LL, &v68);
			//   v47 = UnityEngine::Bounds::get_max(&v70.m_Center, v71, 0LL);
			//   v48 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v71, 0LL).y);
			//   v49 = UnityEngine::Bounds::get_min(&m_Center, v71, 0LL);
			//   v50 = _mm_unpacklo_ps((__m128)LODWORD(v47.x), v48).m128_u64[0];
			//   m_Center.z = v49.z;
			//   *(_QWORD *)&m_Center.x = v50;
			//   v51 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v52 = *(_QWORD *)&v51.x;
			//   *(float *)&v51 = v51.z;
			//   *(_QWORD *)&v68.m_Center.x = v52;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v51;
			//   sub_180040FA0(v13, 6LL, &v68);
			//   v53 = UnityEngine::Bounds::get_max(&v70.m_Center, v71, 0LL);
			//   v54 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&m_Center, v71, 0LL).y);
			//   v55 = UnityEngine::Bounds::get_min(&m_Center, v71, 0LL);
			//   v56 = _mm_unpacklo_ps((__m128)LODWORD(v53.x), v54).m128_u64[0];
			//   m_Center.z = v55.z;
			//   *(_QWORD *)&m_Center.x = v56;
			//   v57 = UnityEngine::Transform::TransformPoint(&v70.m_Center, transform, &m_Center, 0LL);
			//   v58 = 7LL;
			//   v59 = *(_QWORD *)&v57.x;
			//   *(float *)&v57 = v57.z;
			//   *(_QWORD *)&v68.m_Center.x = v59;
			//   LODWORD(v68.m_Center.z) = (_DWORD)v57;
			//   sub_180040FA0(v13, 7LL, &v68);
			//   memset(v71, 0, 24);
			//   sub_180040F70(v13, &v68, 0LL);
			//   sub_180040F70(v13, &m_Center, 0LL);
			//   v70.m_Center = m_Center;
			//   m_Center = v68.m_Center;
			//   UnityEngine::Bounds::SetMinMax(v71, &m_Center, &v70.m_Center, 0LL);
			//   v60 = *(_QWORD *)&v71[0].m_Extents.y;
			//   v61 = 1LL;
			//   v62 = *(_OWORD *)&v71[0].m_Center.x;
			//   do
			//   {
			//     sub_180040F70(v13, &v70, v61);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     m_Center = v70.m_Center;
			//     *(_OWORD *)&v71[0].m_Center.x = v62;
			//     *(_QWORD *)&v71[0].m_Extents.y = v60;
			//     v63 = HG::Rendering::Runtime::CSG::Extensions::IncludePoint(&v68, v71, &m_Center, 0LL);
			//     ++v61;
			//     v60 = *(_QWORD *)&v63.m_Extents.y;
			//     v62 = *(_OWORD *)&v63.m_Center.x;
			//     --v58;
			//   }
			//   while ( v58 );
			//   *(_OWORD *)&retstr.m_Center.x = v62;
			//   *(_QWORD *)&retstr.m_Extents.y = v60;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static void SetEncodedTexture(this Material mat, string name, VolumetricEncodedTexture tex)
		{
			// // Void SetEncodedTexture(Material, String, VolumetricEncodedTexture)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//         Material *mat,
			//         String *name,
			//         VolumetricEncodedTexture *tex,
			//         MethodInfo *method)
			// {
			//   VolumetricEncodedTexture_PropertyIDPack *EncodedTexIDPack; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int32_t RangeScale; // esi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t namea[4]; // [rsp+30h] [rbp-28h]
			//   Vector4 v13; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919810 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919810 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4634, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4634, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)mat,
			//       (Object *)name,
			//       (Object *)tex,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//     EncodedTexIDPack = HG::Rendering::Runtime::VolumetricEncodedTexture::GetEncodedTexIDPack(
			//                          (VolumetricEncodedTexture_PropertyIDPack *)&v13,
			//                          name,
			//                          0LL);
			//     RangeScale = EncodedTexIDPack._RangeScale;
			//     *(_QWORD *)namea = *(_QWORD *)&EncodedTexIDPack._Tex;
			//     if ( !tex )
			//     {
			//       if ( mat )
			//       {
			//         UnityEngine::Material::SetTextureImpl(mat, namea[0], 0LL, 0LL);
			//         return;
			//       }
			// LABEL_10:
			//       sub_180B536AC(v9, v8);
			//     }
			//     if ( !mat )
			//       goto LABEL_10;
			//     UnityEngine::Material::SetTextureImpl(mat, namea[0], tex.fields.Tex, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     v13 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(&v13, tex, 0LL);
			//     UnityEngine::Material::SetVector(mat, namea[1], &v13, 0LL);
			//     v13 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(&v13, tex, 0LL);
			//     UnityEngine::Material::SetVector(mat, RangeScale, &v13, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static void SetEncodedTexture(this MaterialPropertyBlock block, string name, VolumetricEncodedTexture tex)
		{
			// // Void SetEncodedTexture(MaterialPropertyBlock, String, VolumetricEncodedTexture)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//         MaterialPropertyBlock *block,
			//         String *name,
			//         VolumetricEncodedTexture *tex,
			//         MethodInfo *method)
			// {
			//   VolumetricEncodedTexture_PropertyIDPack *EncodedTexIDPack; // rax
			//   int32_t RangeScale; // r14d
			//   Object_1 *v9; // rbx
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Texture *blackTexture3D; // rax
			//   TileBase *v13; // rdx
			//   Vector3Int *v14; // r8
			//   ITilemap *v15; // r9
			//   MethodInfo *v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v18; // [rsp+20h] [rbp-30h]
			//   int32_t namea[4]; // [rsp+30h] [rbp-20h]
			//   Vector4 v20; // [rsp+40h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919811 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919811 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4450, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//     EncodedTexIDPack = HG::Rendering::Runtime::VolumetricEncodedTexture::GetEncodedTexIDPack(
			//                          (VolumetricEncodedTexture_PropertyIDPack *)&v20,
			//                          name,
			//                          0LL);
			//     RangeScale = EncodedTexIDPack._RangeScale;
			//     *(_QWORD *)namea = *(_QWORD *)&EncodedTexIDPack._Tex;
			//     if ( tex
			//       && (v9 = (Object_1 *)tex.fields.Tex,
			//           sub_180002C70(TypeInfo::UnityEngine::Object),
			//           UnityEngine::Object::op_Implicit(v9, 0LL)) )
			//     {
			//       if ( block )
			//       {
			//         UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(block, namea[0], tex.fields.Tex, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         v20 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(&v20, tex, 0LL);
			//         UnityEngine::MaterialPropertyBlock::SetVector(block, namea[1], &v20, 0LL);
			//         v20 = *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(&v20, tex, 0LL);
			// LABEL_8:
			//         UnityEngine::MaterialPropertyBlock::SetVector(block, RangeScale, &v20, 0LL);
			//         return;
			//       }
			//     }
			//     else
			//     {
			//       blackTexture3D = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//       if ( block )
			//       {
			//         UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(block, namea[0], blackTexture3D, 0LL);
			//         v20 = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                           (TileAnimationData *)&v20,
			//                           v13,
			//                           v14,
			//                           v15,
			//                           v18);
			//         UnityEngine::MaterialPropertyBlock::SetVector(block, namea[1], &v20, 0LL);
			//         v20 = *UnityEngine::Vector4::get_one(&v20, v16);
			//         goto LABEL_8;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v11, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4450, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)block,
			//     (Object *)name,
			//     (Object *)tex,
			//     0LL);
			// }
			// 
		}

		public static Texture GetTexture(this VolumetricEncodedTexture et)
		{
			// // Texture GetTexture(VolumetricEncodedTexture)
			// Texture *HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(VolumetricEncodedTexture *et, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4391, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4391, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_174(Patch, (Object *)et, 0LL);
			//   }
			//   else if ( et )
			//   {
			//     return et.fields.Tex;
			//   }
			//   else
			//   {
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public static Vector4 GetRangeBase(this VolumetricEncodedTexture et)
		{
			// // Vector4 GetRangeBase(VolumetricEncodedTexture)
			// Vector4 *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
			//         Vector4 *__return_ptr retstr,
			//         VolumetricEncodedTexture *et,
			//         MethodInfo *method)
			// {
			//   TileBase *v5; // rdx
			//   Vector3Int *v6; // r8
			//   ITilemap *v7; // r9
			//   Vector4 RangeBase; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4452, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4452, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     RangeBase = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v13, Patch, (Object *)et, 0LL);
			//     goto LABEL_8;
			//   }
			//   if ( et )
			//   {
			//     RangeBase = et.fields.RangeBase;
			// LABEL_8:
			//     *retstr = RangeBase;
			//     return retstr;
			//   }
			//   *retstr = *(Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                           (TileAnimationData *)&v13,
			//                           v5,
			//                           v6,
			//                           v7,
			//                           *(MethodInfo **)&v13.x);
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 GetRangeScale(this VolumetricEncodedTexture et)
		{
			// // Vector4 GetRangeScale(VolumetricEncodedTexture)
			// Vector4 *HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
			//         Vector4 *__return_ptr retstr,
			//         VolumetricEncodedTexture *et,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // rdx
			//   Vector4 RangeScale; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4453, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4453, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     RangeScale = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v11, Patch, (Object *)et, 0LL);
			//     goto LABEL_8;
			//   }
			//   if ( et )
			//   {
			//     RangeScale = et.fields.RangeScale;
			// LABEL_8:
			//     *retstr = RangeScale;
			//     return retstr;
			//   }
			//   *retstr = *UnityEngine::Vector4::get_one(&v11, v5);
			//   return retstr;
			// }
			// 
			return null;
		}

		public static void CreatePipelineRTIfNeeded(string name, ref VolumetricPipelineRT rt, int width, int height, RTLifeCycle lifeCycle, RenderTextureFormat format, [MetadataOffset(Offset = "0x01F91D8E")] bool enableMipmap = false)
		{
		}

		public static void ReleasePipelineRT(ref VolumetricPipelineRT rt, bool full)
		{
		}

		public static void UpdateFramingKeywords(CommandBuffer cmd, Material mat, bool enable, EFramingQuality quality)
		{
			// // Void UpdateFramingKeywords(CommandBuffer, Material, Boolean, EFramingQuality)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         bool enable,
			//         EFramingQuality__Enum quality,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Shader *shader; // rbx
			//   String *s_FramingQuarter; // r8
			//   Shader *v13; // rax
			//   String *s_FramingCheckerboard; // r8
			//   __int128 v15; // xmm0
			//   __int64 v16; // xmm1_8
			//   Shader *v17; // rbx
			//   String *v18; // r8
			//   Shader *v19; // rax
			//   String *v20; // r8
			//   Shader *v21; // rbx
			//   String *v22; // r8
			//   Shader *v23; // rax
			//   String *v24; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   LocalKeyword keyword; // [rsp+30h] [rbp-50h] BYREF
			//   LocalKeyword v29; // [rsp+48h] [rbp-38h] BYREF
			//   LocalKeyword v30; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919813 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D919813 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4490, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4490, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v27, v26);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_54(
			//       (ILFixDynamicMethodWrapper_8 *)Patch,
			//       (Object *)cmd,
			//       (Object *)mat,
			//       enable,
			//       quality,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !enable )
			//     {
			//       if ( !mat
			//         || (shader = UnityEngine::Material::get_shader(mat, 0LL),
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//             s_FramingQuarter = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FramingQuarter,
			//             memset(&v29, 0, sizeof(v29)),
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, shader, s_FramingQuarter, 0LL),
			//             keyword = v29,
			//             !cmd) )
			//       {
			//         sub_180B536AC(v10, v9);
			//       }
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//       v13 = UnityEngine::Material::get_shader(mat, 0LL);
			//       s_FramingCheckerboard = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FramingCheckerboard;
			//       memset(&v30, 0, sizeof(v30));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v13, s_FramingCheckerboard, 0LL);
			//       v15 = *(_OWORD *)&v30.m_SpaceInfo.m_KeywordSpace;
			//       v16 = *(_QWORD *)&v30.m_Index;
			// LABEL_18:
			//       *(_QWORD *)&keyword.m_Index = v16;
			//       *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v15;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//       return;
			//     }
			//     if ( quality )
			//     {
			//       if ( quality != EFramingQuality__Enum_Quarter )
			//         return;
			//       if ( !mat
			//         || (v21 = UnityEngine::Material::get_shader(mat, 0LL),
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//             v22 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FramingQuarter,
			//             memset(&v30, 0, sizeof(v30)),
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v21, v22, 0LL),
			//             keyword = v30,
			//             !cmd) )
			//       {
			//         sub_180B536AC(v10, v9);
			//       }
			//       UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//       v23 = UnityEngine::Material::get_shader(mat, 0LL);
			//       v24 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FramingCheckerboard;
			//       memset(&v29, 0, sizeof(v29));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, v23, v24, 0LL);
			//       v15 = *(_OWORD *)&v29.m_SpaceInfo.m_KeywordSpace;
			//       v16 = *(_QWORD *)&v29.m_Index;
			//       goto LABEL_18;
			//     }
			//     if ( !mat
			//       || (v17 = UnityEngine::Material::get_shader(mat, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//           v18 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FramingQuarter,
			//           memset(&v30, 0, sizeof(v30)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v17, v18, 0LL),
			//           keyword = v30,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v10, v9);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v19 = UnityEngine::Material::get_shader(mat, 0LL);
			//     v20 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FramingCheckerboard;
			//     memset(&v29, 0, sizeof(v29));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, v19, v20, 0LL);
			//     keyword = v29;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//   }
			// }
			// 
		}

		public static void UpdateTemporalKeywords(CommandBuffer cmd, Material mat, bool enableMV, bool enableDO)
		{
			// // Void UpdateTemporalKeywords(CommandBuffer, Material, Boolean, Boolean)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::UpdateTemporalKeywords(
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         bool enableMV,
			//         bool enableDO,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Shader *v11; // rbx
			//   String *v12; // r8
			//   Shader *v13; // rax
			//   String *v14; // r8
			//   Shader *v15; // rax
			//   String *v16; // r8
			//   Shader *v17; // rax
			//   String *v18; // r8
			//   __int128 v19; // xmm0
			//   __int64 v20; // xmm1_8
			//   Shader *v21; // rbx
			//   String *v22; // r8
			//   Shader *v23; // rax
			//   String *v24; // r8
			//   Shader *v25; // rax
			//   String *v26; // r8
			//   Shader *v27; // rax
			//   String *v28; // r8
			//   Shader *v29; // rbx
			//   String *v30; // r8
			//   Shader *v31; // rax
			//   String *v32; // r8
			//   Shader *v33; // rax
			//   String *v34; // r8
			//   Shader *shader; // rbx
			//   String *s_MergeTAAPassNMVNDO; // r8
			//   Shader *v37; // rax
			//   String *s_MergeTAAPassEMVNDO; // r8
			//   Shader *v39; // rax
			//   String *s_MergeTAAPassEMVEDO; // r8
			//   Shader *v41; // rax
			//   String *s_MergeTAAPassNMVEDO; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   LocalKeyword keyword; // [rsp+38h] [rbp-31h] BYREF
			//   LocalKeyword v47; // [rsp+50h] [rbp-19h] BYREF
			//   LocalKeyword v48; // [rsp+68h] [rbp-1h] BYREF
			//   LocalKeyword v49; // [rsp+80h] [rbp+17h] BYREF
			//   LocalKeyword v50; // [rsp+98h] [rbp+2Fh] BYREF
			// 
			//   if ( !byte_18D919814 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D919814 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4547, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4547, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v45, v44);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_49(
			//       (ILFixDynamicMethodWrapper_3 *)Patch,
			//       (Object *)cmd,
			//       (Object *)mat,
			//       enableMV,
			//       enableDO,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( enableMV )
			//     {
			//       if ( enableDO )
			//       {
			//         if ( !mat
			//           || (shader = UnityEngine::Material::get_shader(mat, 0LL),
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//               s_MergeTAAPassNMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVNDO,
			//               memset(&v50, 0, sizeof(v50)),
			//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, shader, s_MergeTAAPassNMVNDO, 0LL),
			//               keyword = v50,
			//               !cmd) )
			//         {
			//           sub_180B536AC(v10, v9);
			//         }
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//         v37 = UnityEngine::Material::get_shader(mat, 0LL);
			//         s_MergeTAAPassEMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVNDO;
			//         memset(&v49, 0, sizeof(v49));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v37, s_MergeTAAPassEMVNDO, 0LL);
			//         keyword = v49;
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//         v39 = UnityEngine::Material::get_shader(mat, 0LL);
			//         s_MergeTAAPassEMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVEDO;
			//         memset(&v48, 0, sizeof(v48));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v39, s_MergeTAAPassEMVEDO, 0LL);
			//         keyword = v48;
			//         UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//       }
			//       else
			//       {
			//         if ( !mat
			//           || (v29 = UnityEngine::Material::get_shader(mat, 0LL),
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//               v30 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVNDO,
			//               memset(&v50, 0, sizeof(v50)),
			//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, v29, v30, 0LL),
			//               keyword = v50,
			//               !cmd) )
			//         {
			//           sub_180B536AC(v10, v9);
			//         }
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//         v31 = UnityEngine::Material::get_shader(mat, 0LL);
			//         v32 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVNDO;
			//         memset(&v49, 0, sizeof(v49));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v31, v32, 0LL);
			//         keyword = v49;
			//         UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//         v33 = UnityEngine::Material::get_shader(mat, 0LL);
			//         v34 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVEDO;
			//         memset(&v48, 0, sizeof(v48));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v33, v34, 0LL);
			//         keyword = v48;
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//       }
			//       v41 = UnityEngine::Material::get_shader(mat, 0LL);
			//       s_MergeTAAPassNMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVEDO;
			//       memset(&v47, 0, sizeof(v47));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v47, v41, s_MergeTAAPassNMVEDO, 0LL);
			//       v19 = *(_OWORD *)&v47.m_SpaceInfo.m_KeywordSpace;
			//       v20 = *(_QWORD *)&v47.m_Index;
			//       goto LABEL_23;
			//     }
			//     if ( !enableDO )
			//     {
			//       if ( !mat
			//         || (v11 = UnityEngine::Material::get_shader(mat, 0LL),
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//             v12 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVNDO,
			//             memset(&v47, 0, sizeof(v47)),
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v47, v11, v12, 0LL),
			//             keyword = v47,
			//             !cmd) )
			//       {
			//         sub_180B536AC(v10, v9);
			//       }
			//       UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//       v13 = UnityEngine::Material::get_shader(mat, 0LL);
			//       v14 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVNDO;
			//       memset(&v48, 0, sizeof(v48));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v13, v14, 0LL);
			//       keyword = v48;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//       v15 = UnityEngine::Material::get_shader(mat, 0LL);
			//       v16 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVEDO;
			//       memset(&v49, 0, sizeof(v49));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v15, v16, 0LL);
			//       keyword = v49;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//       v17 = UnityEngine::Material::get_shader(mat, 0LL);
			//       v18 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVEDO;
			//       memset(&v50, 0, sizeof(v50));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, v17, v18, 0LL);
			//       v19 = *(_OWORD *)&v50.m_SpaceInfo.m_KeywordSpace;
			//       v20 = *(_QWORD *)&v50.m_Index;
			// LABEL_23:
			//       *(_QWORD *)&keyword.m_Index = v20;
			//       *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v19;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//       return;
			//     }
			//     if ( !mat
			//       || (v21 = UnityEngine::Material::get_shader(mat, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//           v22 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVNDO,
			//           memset(&v50, 0, sizeof(v50)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v50, v21, v22, 0LL),
			//           keyword = v50,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v10, v9);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v23 = UnityEngine::Material::get_shader(mat, 0LL);
			//     v24 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVNDO;
			//     memset(&v49, 0, sizeof(v49));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v49, v23, v24, 0LL);
			//     keyword = v49;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v25 = UnityEngine::Material::get_shader(mat, 0LL);
			//     v26 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVEDO;
			//     memset(&v48, 0, sizeof(v48));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v48, v25, v26, 0LL);
			//     keyword = v48;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v27 = UnityEngine::Material::get_shader(mat, 0LL);
			//     v28 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVEDO;
			//     memset(&v47, 0, sizeof(v47));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v47, v27, v28, 0LL);
			//     keyword = v47;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, mat, &keyword, 0LL);
			//   }
			// }
			// 
		}

		public static void ResetTemporalKeywords(CommandBuffer cmd, Material mat)
		{
			// // Void ResetTemporalKeywords(CommandBuffer, Material)
			// void HG::Rendering::Runtime::VolumetricSDFUtils::ResetTemporalKeywords(
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Shader *shader; // rbx
			//   String *s_MergeTAAPassNMVNDO; // r8
			//   Shader *v9; // rax
			//   String *s_MergeTAAPassEMVNDO; // r8
			//   Shader *v11; // rax
			//   String *s_MergeTAAPassEMVEDO; // r8
			//   Shader *v13; // rax
			//   String *s_MergeTAAPassNMVEDO; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   LocalKeyword keyword; // [rsp+28h] [rbp-29h] BYREF
			//   LocalKeyword v19; // [rsp+40h] [rbp-11h] BYREF
			//   LocalKeyword v20; // [rsp+58h] [rbp+7h] BYREF
			//   LocalKeyword v21; // [rsp+70h] [rbp+1Fh] BYREF
			//   LocalKeyword v22; // [rsp+88h] [rbp+37h] BYREF
			// 
			//   if ( !byte_18D919815 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D919815 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4491, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4491, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)cmd,
			//       (Object *)mat,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !mat
			//       || (shader = UnityEngine::Material::get_shader(mat, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//           s_MergeTAAPassNMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVNDO,
			//           memset(&v19, 0, sizeof(v19)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, s_MergeTAAPassNMVNDO, 0LL),
			//           keyword = v19,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v6, v5);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v9 = UnityEngine::Material::get_shader(mat, 0LL);
			//     s_MergeTAAPassEMVNDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVNDO;
			//     memset(&v20, 0, sizeof(v20));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v20, v9, s_MergeTAAPassEMVNDO, 0LL);
			//     keyword = v20;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v11 = UnityEngine::Material::get_shader(mat, 0LL);
			//     s_MergeTAAPassEMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassEMVEDO;
			//     memset(&v21, 0, sizeof(v21));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v21, v11, s_MergeTAAPassEMVEDO, 0LL);
			//     keyword = v21;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//     v13 = UnityEngine::Material::get_shader(mat, 0LL);
			//     s_MergeTAAPassNMVEDO = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_MergeTAAPassNMVEDO;
			//     memset(&v22, 0, sizeof(v22));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v22, v13, s_MergeTAAPassNMVEDO, 0LL);
			//     keyword = v22;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, mat, &keyword, 0LL);
			//   }
			// }
			// 
		}

		public const float MAX_DEPTH = 10000f;

		public const int DEPTH_BITS = 24;

		public const float MIN_OPTICAL_DEPTH = 0.01f;

		public const float MAX_OPTICAL_DEPTH = 100f;

		public const string VOLUMETRIC_MAT_PATH_ROOT = "Assets/Beyond/Arts/Environment/VolumetricCloud/";

		public const string VOLUMETRIC_SDF_PATH_ROOT = "Assets/Beyond/Arts/Environment/VolumetricCloud/Sdf/";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int Layer_Default;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static readonly int Layer_Invisible;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Mesh _cubeMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Mesh _quadMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static Mesh _sphereMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static Mesh _blitMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static Mesh _blitMeshBackface;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static RenderTargetIdentifier[] _RTs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static RenderBufferLoadAction[] _Loads;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		private static RenderBufferStoreAction[] _Stores;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		private static string[] s_MV_MODES;
	}
}
