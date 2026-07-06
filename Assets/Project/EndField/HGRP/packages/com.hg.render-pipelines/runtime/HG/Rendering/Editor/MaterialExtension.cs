using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Editor
{
	public static class MaterialExtension
	{
		public static SurfaceType GetSurfaceType(this Material material)
		{
			// // SurfaceType GetSurfaceType(Material)
			// SurfaceType__Enum HG::Rendering::Editor::MaterialExtension::GetSurfaceType(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193CA )
			//   {
			//     sub_18003C530(&off_18D4DEAB8);
			//     byte_18D9193CA = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_SurfaceType", 0LL) )
			//     return (int)UnityEngine::Material::GetFloat(material, (String *)"_SurfaceType", 0LL);
			//   else
			//     return 0;
			// }
			// 
			return (SurfaceType)SurfaceType.Opaque;
		}

		public static MaterialId GetMaterialId(this Material material)
		{
			// // MaterialId GetMaterialId(Material)
			// MaterialId__Enum HG::Rendering::Editor::MaterialExtension::GetMaterialId(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193CB )
			//   {
			//     sub_18003C530(&off_18D4DEA80);
			//     byte_18D9193CB = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_MaterialID", 0LL) )
			//     return (int)UnityEngine::Material::GetFloat(material, (String *)"_MaterialID", 0LL);
			//   else
			//     return 1;
			// }
			// 
			return (MaterialId)MaterialId.LitSSS;
		}

		public static BlendMode GetBlendMode(this Material material)
		{
			// // BlendMode GetBlendMode(Material)
			// BlendMode__Enum HG::Rendering::Editor::MaterialExtension::GetBlendMode(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193CC )
			//   {
			//     sub_18003C530(&off_18C8DDDA0);
			//     byte_18D9193CC = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_BlendMode", 0LL) )
			//     return (int)UnityEngine::Material::GetFloat(material, (String *)"_BlendMode", 0LL);
			//   else
			//     return 1;
			// }
			// 
			return (BlendMode)BlendMode.Alpha;
		}

		public static int GetLayerCount(this Material material)
		{
			// // Int32 GetLayerCount(Material)
			// int32_t HG::Rendering::Editor::MaterialExtension::GetLayerCount(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193CD )
			//   {
			//     sub_18003C530(&off_18D4DEB08);
			//     byte_18D9193CD = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_LayerCount", 0LL) )
			//     return UnityEngine::Material::GetInt(material, (String *)"_LayerCount", 0LL);
			//   else
			//     return 1;
			// }
			// 
			return 0;
		}

		public static bool GetZWrite(this Material material)
		{
			// // Boolean GetZWrite(Material)
			// bool HG::Rendering::Editor::MaterialExtension::GetZWrite(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193CE )
			//   {
			//     sub_18003C530(&off_18D4DEAE0);
			//     byte_18D9193CE = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   return UnityEngine::Material::HasProperty(material, (String *)"_ZWrite", 0LL)
			//       && UnityEngine::Material::GetInt(material, (String *)"_ZWrite", 0LL) == 1;
			// }
			// 
			return default(bool);
		}

		public static bool GetTransparentZWrite(this Material material)
		{
			// // Boolean GetTransparentZWrite(Material)
			// bool HG::Rendering::Editor::MaterialExtension::GetTransparentZWrite(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193CF )
			//   {
			//     sub_18003C530(&off_18D4DEB80);
			//     byte_18D9193CF = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   return UnityEngine::Material::HasProperty(material, (String *)"_TransparentZWrite", 0LL)
			//       && UnityEngine::Material::GetInt(material, (String *)"_TransparentZWrite", 0LL) == 1;
			// }
			// 
			return default(bool);
		}

		public static CullMode GetTransparentCullMode(this Material material)
		{
			// // CullMode GetTransparentCullMode(Material)
			// CullMode__Enum HG::Rendering::Editor::MaterialExtension::GetTransparentCullMode(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193D0 )
			//   {
			//     sub_18003C530(&off_18D4DEB30);
			//     byte_18D9193D0 = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_TransparentCullMode", 0LL) )
			//     return UnityEngine::Material::GetInt(material, (String *)"_TransparentCullMode", 0LL);
			//   else
			//     return 2;
			// }
			// 
			return (CullMode)CullMode.Off;
		}

		public static CullMode GetOpaqueCullMode(this Material material)
		{
			// // CullMode GetOpaqueCullMode(Material)
			// CullMode__Enum HG::Rendering::Editor::MaterialExtension::GetOpaqueCullMode(Material *material, MethodInfo *method)
			// {
			//   if ( !byte_18D9193D1 )
			//   {
			//     sub_18003C530(&off_18D4DE8B8);
			//     byte_18D9193D1 = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_OpaqueCullMode", 0LL) )
			//     return UnityEngine::Material::GetInt(material, (String *)"_OpaqueCullMode", 0LL);
			//   else
			//     return 2;
			// }
			// 
			return (CullMode)CullMode.Off;
		}

		public static CompareFunction GetTransparentZTest(this Material material)
		{
			// // CompareFunction GetTransparentZTest(Material)
			// CompareFunction__Enum HG::Rendering::Editor::MaterialExtension::GetTransparentZTest(
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D9193D2 )
			//   {
			//     sub_18003C530(&off_18D4DE8E0);
			//     byte_18D9193D2 = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_ZTestTransparent", 0LL) )
			//     return UnityEngine::Material::GetInt(material, (String *)"_ZTestTransparent", 0LL);
			//   else
			//     return 4;
			// }
			// 
			return (CompareFunction)CompareFunction.Disabled;
		}

		public static void ResetMaterialCustomRenderQueue(this Material material)
		{
			// // Void ResetMaterialCustomRenderQueue(Material)
			// void HG::Rendering::Editor::MaterialExtension::ResetMaterialCustomRenderQueue(Material *material, MethodInfo *method)
			// {
			//   SurfaceType__Enum SurfaceType; // eax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   int32_t renderQueue; // ebx
			//   HGRenderQueue_RenderQueueType__Enum TypeByRenderQueueValue; // eax
			//   HGRenderQueue_RenderQueueType__Enum OpaqueEquivalent; // eax
			//   int32_t v9; // ebx
			//   HGRenderQueue_RenderQueueType__Enum v10; // eax
			//   HGRenderQueue_RenderQueueType__Enum v11; // ebp
			//   float Float; // xmm7_4
			//   bool v13; // si
			//   bool v14; // bl
			//   int32_t v15; // eax
			//   __int64 v16; // rax
			//   InvalidEnumArgumentException *v17; // rbx
			//   String *v18; // rax
			//   __int64 v19; // rax
			// 
			//   if ( !byte_18D9193D3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&off_18D4DE8A0);
			//     sub_18003C530(&off_18D4DE938);
			//     sub_18003C530(&off_18D610390);
			//     byte_18D9193D3 = 1;
			//   }
			//   SurfaceType = HG::Rendering::Editor::MaterialExtension::GetSurfaceType(material, 0LL);
			//   if ( SurfaceType == SurfaceType__Enum_Opaque )
			//   {
			//     if ( material )
			//     {
			//       renderQueue = UnityEngine::Material::get_renderQueue(material, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       TypeByRenderQueueValue = HG::Rendering::Runtime::HGRenderQueue::GetTypeByRenderQueueValue(renderQueue, 0LL);
			//       OpaqueEquivalent = HG::Rendering::Runtime::HGRenderQueue::GetOpaqueEquivalent(TypeByRenderQueueValue, 0LL);
			//       goto LABEL_9;
			//     }
			// LABEL_20:
			//     sub_180B536AC(v5, v4);
			//   }
			//   if ( SurfaceType != SurfaceType__Enum_Transparent )
			//   {
			//     v16 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v17 = (InvalidEnumArgumentException *)sub_180004920(v16);
			//     if ( v17 )
			//     {
			//       v18 = (String *)sub_18000F7E0(&off_18D4DE900);
			//       System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v17, v18, 0LL);
			//       v19 = sub_18000F7E0(&MethodInfo::HG::Rendering::Editor::MaterialExtension::ResetMaterialCustomRenderQueue);
			//       sub_18000F7C0(v17, v19);
			//     }
			//     goto LABEL_20;
			//   }
			//   if ( !material )
			//     goto LABEL_20;
			//   v9 = UnityEngine::Material::get_renderQueue(material, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//   v10 = HG::Rendering::Runtime::HGRenderQueue::GetTypeByRenderQueueValue(v9, 0LL);
			//   OpaqueEquivalent = HG::Rendering::Runtime::HGRenderQueue::GetTransparentEquivalent(v10, 0LL);
			// LABEL_9:
			//   v11 = OpaqueEquivalent;
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_TransparentSortPriority", 0LL) )
			//     Float = UnityEngine::Material::GetFloat(material, (String *)"_TransparentSortPriority", 0LL);
			//   else
			//     Float = 0.0;
			//   v13 = UnityEngine::Material::HasProperty(material, (String *)"_AlphaCutoffEnable", 0LL)
			//      && UnityEngine::Material::GetFloat(material, (String *)"_AlphaCutoffEnable", 0LL) > 0.0;
			//   v14 = UnityEngine::Material::HasProperty(material, (String *)"_SupportDecals", 0LL)
			//      && UnityEngine::Material::GetFloat(material, (String *)"_SupportDecals", 0LL) > 0.0;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//   v15 = HG::Rendering::Runtime::HGRenderQueue::ChangeType(v11, (int)Float, v13, v14, 0LL);
			//   UnityEngine::Material::set_renderQueue(material, v15, 0LL);
			// }
			// 
		}

		public static void UpdateEmissiveColorFromIntensityAndEmissiveColorLDR(this Material material)
		{
			// // Void UpdateEmissiveColorFromIntensityAndEmissiveColorLDR(Material)
			// void HG::Rendering::Editor::MaterialExtension::UpdateEmissiveColorFromIntensityAndEmissiveColorLDR(
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __m128 v3; // xmm6
			//   Vector4 v4; // xmm6
			//   float Float; // xmm0_4
			//   MethodInfo *v6; // r9
			//   Vector4 v7; // [rsp+20h] [rbp-38h] BYREF
			//   Vector4 v8; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9193D4 )
			//   {
			//     sub_18003C530(&off_18C9F0990);
			//     sub_18003C530(&off_18D4DE9B0);
			//     sub_18003C530(&off_18D4DE9B8);
			//     byte_18D9193D4 = 1;
			//   }
			//   if ( !material )
			//     sub_180B536AC(material, method);
			//   if ( UnityEngine::Material::HasProperty(material, (String *)"_EmissiveColorLDR", 0LL)
			//     && UnityEngine::Material::HasProperty(material, (String *)"_EmissiveIntensity", 0LL)
			//     && UnityEngine::Material::HasProperty(material, (String *)"_EmissiveColor", 0LL) )
			//   {
			//     v3 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Material::GetColor(
			//                                                     (Color *)&v7,
			//                                                     material,
			//                                                     (String *)"_EmissiveColorLDR",
			//                                                     0LL));
			//     v7.x = UnityEngine::Mathf::GammaToLinearSpace(v3.m128_f32[0], 0LL);
			//     v7.y = UnityEngine::Mathf::GammaToLinearSpace(_mm_shuffle_ps(v3, v3, 85).m128_f32[0], 0LL);
			//     v7.z = UnityEngine::Mathf::GammaToLinearSpace(_mm_shuffle_ps(v3, v3, 170).m128_f32[0], 0LL);
			//     v7.w = 1.0;
			//     v4 = v7;
			//     Float = UnityEngine::Material::GetFloat(material, (String *)"_EmissiveIntensity", 0LL);
			//     v7 = v4;
			//     v7 = *UnityEngine::Vector4::op_Multiply(&v8, &v7, Float, v6);
			//     UnityEngine::Material::SetColor(material, (String *)"_EmissiveColor", (Color *)&v7, 0LL);
			//   }
			// }
			// 
		}
	}
}
