using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class MaterialSubsurfaceExtensions // TypeDefIndex: 38605
	{
		// Extension methods
		public static HGSubsurfaceProfile GetSubsurfaceProfile(this Material material) => default; // 0x0000000189C1A640-0x0000000189C1A704
		// HGSubsurfaceProfile GetSubsurfaceProfile(Material)
		HGSubsurfaceProfile *HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceProfile(
		        Material *material,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3908, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3908, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1375(Patch, (Object *)material, 0LL);
		LABEL_8:
		    sub_1800D8260(static_fields, v3);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  if ( !material )
		    goto LABEL_8;
		  if ( UnityEngine::Material::HasProperty(material, static_fields->_UseSubsurfaceProfile, 0LL)
		    && (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
		        UnityEngine::Material::GetFloatImpl(
		          material,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseSubsurfaceProfile,
		          0LL) > 0.0) )
		  {
		    return UnityEngine::Material::get_subsurfaceProfile(material, 0LL);
		  }
		  else
		  {
		    return 0LL;
		  }
		}
		
		public static bool GetSubsurfaceData(this Material material, out SubsurfaceData data) {
			data = default;
			return default;
		} // 0x0000000189C1A4F0-0x0000000189C1A640
		// Boolean GetSubsurfaceData(Material, SubsurfaceData ByRef)
		bool HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceData(
		        Material *material,
		        SubsurfaceData *data,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  bool result; // al
		  __int64 v8; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v10; // [rsp+20h] [rbp-38h] BYREF
		  _BYTE v11[24]; // [rsp+30h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3909, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3909, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1376(Patch, (Object *)material, data, 0LL);
		LABEL_8:
		    sub_1800D8260(static_fields, v5);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  if ( !material )
		    goto LABEL_8;
		  if ( UnityEngine::Material::HasProperty(material, static_fields->_EnableSubsurface, 0LL)
		    && (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
		        UnityEngine::Material::GetFloatImpl(
		          material,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EnableSubsurface,
		          0LL) > 0.0) )
		  {
		    *(_DWORD *)v11 = 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    *(Color *)&v11[4] = *UnityEngine::Material::GetColor(
		                           &v10,
		                           material,
		                           TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceColor,
		                           0LL);
		    *(_DWORD *)&v11[20] = UnityEngine::Material::GetFloatImpl(
		                            material,
		                            TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceIndirect,
		                            0LL);
		    result = 1;
		    v8 = *(_QWORD *)&v11[16];
		    *(_OWORD *)&data->RefCount = *(_OWORD *)v11;
		    *(_QWORD *)&data->SubsurfaceColor.a = v8;
		  }
		  else
		  {
		    result = 0;
		    *(_OWORD *)&data->RefCount = 0LL;
		    *(_QWORD *)&data->SubsurfaceColor.a = 0LL;
		  }
		  return result;
		}
		
	}
}
