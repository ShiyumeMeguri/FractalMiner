using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class MaterialSubsurfaceExtensions
	{
		public static HGSubsurfaceProfile GetSubsurfaceProfile(this Material material)
		{
			// // HGSubsurfaceProfile GetSubsurfaceProfile(Material)
			// HGSubsurfaceProfile *HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceProfile(
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9196F1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D9196F1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3292, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3292, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1169(Patch, (Object *)material, 0LL);
			// LABEL_10:
			//     sub_180B536AC(static_fields, v3);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   if ( !material )
			//     goto LABEL_10;
			//   if ( UnityEngine::Material::HasProperty(material, static_fields._UseSubsurfaceProfile, 0LL)
			//     && (sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
			//         UnityEngine::Material::GetFloatImpl(
			//           material,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._UseSubsurfaceProfile,
			//           0LL) > 0.0) )
			//   {
			//     return UnityEngine::Material::get_subsurfaceProfile(material, 0LL);
			//   }
			//   else
			//   {
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public static bool GetSubsurfaceData(this Material material, out SubsurfaceData data)
		{
			// // Boolean GetSubsurfaceData(Material, SubsurfaceData ByRef)
			// bool HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceData(
			//         Material *material,
			//         SubsurfaceData *data,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   Color *Color; // rax
			//   HGShaderIDs__StaticFields *v8; // rdx
			//   bool result; // al
			//   __int64 v10; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v12; // [rsp+20h] [rbp-38h] BYREF
			//   _BYTE v13[24]; // [rsp+30h] [rbp-28h]
			// 
			//   if ( !byte_18D9196F2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D9196F2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3293, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3293, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1170(Patch, (Object *)material, data, 0LL);
			// LABEL_10:
			//     sub_180B536AC(static_fields, v5);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   if ( !material )
			//     goto LABEL_10;
			//   if ( UnityEngine::Material::HasProperty(material, static_fields._EnableSubsurface, 0LL)
			//     && (sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
			//         UnityEngine::Material::GetFloatImpl(
			//           material,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._EnableSubsurface,
			//           0LL) > 0.0) )
			//   {
			//     *(_DWORD *)v13 = 0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     Color = UnityEngine::Material::GetColor(
			//               &v12,
			//               material,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SubsurfaceColor,
			//               0LL);
			//     v8 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     *(Color *)&v13[4] = *Color;
			//     *(_DWORD *)&v13[20] = UnityEngine::Material::GetFloatImpl(material, v8._SubsurfaceIndirect, 0LL);
			//     result = 1;
			//     v10 = *(_QWORD *)&v13[16];
			//     *(_OWORD *)&data.RefCount = *(_OWORD *)v13;
			//     *(_QWORD *)&data.SubsurfaceColor.a = v10;
			//   }
			//   else
			//   {
			//     result = 0;
			//     *(_OWORD *)&data.RefCount = 0LL;
			//     *(_QWORD *)&data.SubsurfaceColor.a = 0LL;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}
	}
}
