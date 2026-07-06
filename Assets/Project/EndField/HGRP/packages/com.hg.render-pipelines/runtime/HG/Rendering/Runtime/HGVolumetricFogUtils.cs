using System;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class HGVolumetricFogUtils
	{
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Mesh quadMesh
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000025D2 File Offset: 0x000007D2
		public static Texture3D volumetricBlackTexture3D
		{
			get
			{
				return null;
			}
		}

		private static Mesh _CreateQuadMesh()
		{
			// // Mesh _CreateQuadMesh()
			// Mesh *HG::Rendering::Runtime::HGVolumetricFogUtils::_CreateQuadMesh(MethodInfo *method)
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
			//   unsigned __int64 v14; // [rsp+20h] [rbp-20h] BYREF
			//   int v15; // [rsp+28h] [rbp-18h]
			// 
			//   if ( !byte_18D919D9E )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&752A6E22358C492163D1DE31BFAFB249C23A54C303CE495A18ABF04CF82E01B2_Field);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D919D9E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1301, 0LL) )
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
			//         v15 = 0;
			//         v14 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v7, 0LL, &v14);
			//         v15 = 0;
			//         v14 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v8, 1LL, &v14);
			//         v15 = 0;
			//         v14 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         sub_180040FA0(v8, 2LL, &v14);
			//         v15 = 0;
			//         v14 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
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
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1301, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			// }
			// 
			return null;
		}

		private static Texture3D _CreateVolumetricBlackTexture3D()
		{
			// // Texture3D _CreateVolumetricBlackTexture3D()
			// Texture3D *HG::Rendering::Runtime::HGVolumetricFogUtils::_CreateVolumetricBlackTexture3D(MethodInfo *method)
			// {
			//   Texture3D *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   Object_1 *v4; // rbx
			//   MethodInfo *v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Quaternion v8; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919DA0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture3D);
			//     sub_18003C530(&off_18D5E7BD0);
			//     byte_18D919DA0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1304, 0LL) )
			//   {
			//     v1 = (Texture3D *)sub_180004920(TypeInfo::UnityEngine::Texture3D);
			//     v4 = (Object_1 *)v1;
			//     if ( v1 )
			//     {
			//       UnityEngine::Texture3D::Texture3D(
			//         v1,
			//         1,
			//         1,
			//         1,
			//         GraphicsFormat__Enum_R16G16B16A16_SFloat,
			//         TextureCreationFlags__Enum_None,
			//         0LL);
			//       UnityEngine::Object::set_name(v4, (String *)"Black Texture 3D", 0LL);
			//       v8 = *UnityEngine::Quaternion::get_identity(&v8, v5);
			//       UnityEngine::Texture3D::SetPixel((Texture3D *)v4, 0, 0, 0, (Color *)&v8, 0, 0LL);
			//       UnityEngine::Texture3D::Apply((Texture3D *)v4, 0, 1, 0LL);
			//       return (Texture3D *)v4;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1304, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(Patch, 0LL);
			// }
			// 
			return null;
		}

		public static Vector3Int GetWidthHeightAndVolumeDepth(this RenderTexture renderTexture)
		{
			// // Vector3Int GetWidthHeightAndVolumeDepth(RenderTexture)
			// Vector3Int *HG::Rendering::Runtime::HGVolumetricFogUtils::GetWidthHeightAndVolumeDepth(
			//         Vector3Int *__return_ptr retstr,
			//         RenderTexture *renderTexture,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int32_t v7; // edi
			//   int32_t v8; // ebx
			//   int32_t m_Z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3Int *v11; // rax
			//   __int64 v12; // xmm0_8
			//   Vector3Int v14[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1291, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1291, 0LL);
			//     if ( Patch )
			//     {
			//       v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_496(v14, Patch, (Object *)renderTexture, 0LL);
			//       v12 = *(_QWORD *)&v11.m_X;
			//       m_Z = v11.m_Z;
			//       *(_QWORD *)&retstr.m_X = v12;
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !renderTexture )
			//     goto LABEL_5;
			//   v7 = sub_18003ED00(5LL);
			//   v8 = sub_18003ED00(7LL);
			//   m_Z = UnityEngine::RenderTexture::get_volumeDepth(renderTexture, 0LL);
			//   retstr.m_X = v7;
			//   retstr.m_Y = v8;
			// LABEL_7:
			//   retstr.m_Z = m_Z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static RenderTexture GetAndCreateTemporaryRenderTexture(RenderTextureDescriptor desc, string name)
		{
			// // RenderTexture GetAndCreateTemporaryRenderTexture(RenderTextureDescriptor, String)
			// RenderTexture *HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
			//         RenderTextureDescriptor *desc,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm0
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   Object_1 *Temporary; // rax
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   RenderTexture *v11; // rbx
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   RenderTextureDescriptor v16; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1293, 0LL) )
			//   {
			//     v5 = *(_OWORD *)&desc._width_k__BackingField;
			//     v6 = *(_OWORD *)&desc._mipCount_k__BackingField;
			//     v16._memoryless_k__BackingField = desc._memoryless_k__BackingField;
			//     *(_OWORD *)&v16._width_k__BackingField = v5;
			//     v7 = *(_OWORD *)&desc._dimension_k__BackingField;
			//     *(_OWORD *)&v16._mipCount_k__BackingField = v6;
			//     *(_OWORD *)&v16._dimension_k__BackingField = v7;
			//     Temporary = (Object_1 *)UnityEngine::RenderTexture::GetTemporary(&v16, 0LL);
			//     v11 = (RenderTexture *)Temporary;
			//     if ( Temporary )
			//     {
			//       UnityEngine::Object::set_name(Temporary, name, 0LL);
			//       UnityEngine::RenderTexture::Create(v11, 0LL);
			//       return v11;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1293, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   memoryless_k__BackingField = desc._memoryless_k__BackingField;
			//   v14 = *(_OWORD *)&desc._mipCount_k__BackingField;
			//   *(_OWORD *)&v16._width_k__BackingField = *(_OWORD *)&desc._width_k__BackingField;
			//   v15 = *(_OWORD *)&desc._dimension_k__BackingField;
			//   v16._memoryless_k__BackingField = memoryless_k__BackingField;
			//   *(_OWORD *)&v16._mipCount_k__BackingField = v14;
			//   *(_OWORD *)&v16._dimension_k__BackingField = v15;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_497(Patch, &v16, (Object *)name, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static int DivideAndRoundUp(int dividend, int divisor)
		{
			// // Int32 DivideAndRoundUp(Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//         int32_t dividend,
			//         int32_t divisor,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1281, 0LL) )
			//     return (dividend + divisor - 1) / divisor;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1281, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47((ILFixDynamicMethodWrapper_16 *)Patch, dividend, divisor, 0LL);
			// }
			// 
			return 0;
		}

		[IDTag(3)]
		public static Vector3Int DivideAndRoundUp(Vector3Int lhs, int divisor)
		{
			// // Vector3Int DivideAndRoundUp(Vector3Int, Int32)
			// Vector3Int *HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//         Vector3Int *__return_ptr retstr,
			//         Vector3Int *lhs,
			//         int32_t divisor,
			//         MethodInfo *method)
			// {
			//   int32_t v7; // edi
			//   int32_t v8; // ebx
			//   int32_t v9; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v11; // rcx
			//   int32_t m_Z; // eax
			//   Vector3Int *v13; // rax
			//   __int64 v14; // xmm0_8
			//   Vector3Int v16; // [rsp+30h] [rbp-28h] BYREF
			//   Vector3Int v17[2]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1294, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1294, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, 0LL);
			//     m_Z = lhs.m_Z;
			//     *(_QWORD *)&v16.m_X = *(_QWORD *)&lhs.m_X;
			//     v16.m_Z = m_Z;
			//     v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_498(v17, Patch, &v16, divisor, 0LL);
			//     v14 = *(_QWORD *)&v13.m_X;
			//     v9 = v13.m_Z;
			//     *(_QWORD *)&retstr.m_X = v14;
			//   }
			//   else
			//   {
			//     v7 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_X, divisor, 0LL);
			//     v8 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_Y, divisor, 0LL);
			//     v9 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_Z, divisor, 0LL);
			//     retstr.m_X = v7;
			//     retstr.m_Y = v8;
			//   }
			//   retstr.m_Z = v9;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2Int DivideAndRoundUp(Vector2Int lhs, int divisor)
		{
			// // Vector2Int DivideAndRoundUp(Vector2Int, Int32)
			// Vector2Int HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//         Vector2Int lhs,
			//         int32_t divisor,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t m_Y; // [rsp+34h] [rbp+Ch]
			//   Vector2Int v10; // [rsp+48h] [rbp+20h]
			// 
			//   m_Y = lhs.m_Y;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1280, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1280, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_488(Patch, lhs, divisor, 0LL);
			//   }
			//   else
			//   {
			//     v10.m_X = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_X, divisor, 0LL);
			//     v10.m_Y = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(m_Y, divisor, 0LL);
			//     return v10;
			//   }
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector2Int DivideAndRoundUp(Vector2Int lhs, Vector2Int divisor)
		{
			// // Vector2Int DivideAndRoundUp(Vector2Int, Vector2Int)
			// Vector2Int HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//         Vector2Int lhs,
			//         Vector2Int divisor,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t v9; // [rsp+34h] [rbp+Ch]
			//   int32_t m_Y; // [rsp+3Ch] [rbp+14h]
			//   Vector2Int v11; // [rsp+48h] [rbp+20h]
			// 
			//   m_Y = divisor.m_Y;
			//   v9 = lhs.m_Y;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1282, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1282, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_489(Patch, lhs, divisor, 0LL);
			//   }
			//   else
			//   {
			//     v11.m_X = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_X, divisor.m_X, 0LL);
			//     v11.m_Y = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(v9, m_Y, 0LL);
			//     return v11;
			//   }
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Mesh s_quadMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Texture3D s_volumetricBlackTexture3D;
	}
}
