using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGVolumetricFogUtils // TypeDefIndex: 37661
	{
		// Fields
		private static Mesh s_quadMesh; // 0x00
		private static Texture3D s_volumetricBlackTexture3D; // 0x08
	
		// Properties
		public static Mesh quadMesh { get; } // 0x0000000189CEF5C4-0x0000000189CEF670 
		// Mesh get_quadMesh()
		Mesh *HG::Rendering::Runtime::HGVolumetricFogUtils::get_quadMesh(MethodInfo *method)
		{
		  Object_1 *s_quadMesh; // rbx
		  Mesh *QuadMesh; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1555, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1555, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		  }
		  else
		  {
		    s_quadMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields->s_quadMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(s_quadMesh, 0LL, 0LL) )
		    {
		      QuadMesh = HG::Rendering::Runtime::HGVolumetricFogUtils::_CreateQuadMesh(0LL);
		      static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields;
		      static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)QuadMesh;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields,
		        static_fields,
		        v4,
		        v5,
		        v10);
		    }
		    return TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields->s_quadMesh;
		  }
		}
		
		public static Texture3D volumetricBlackTexture3D { get; } // 0x0000000189CEF670-0x0000000189CEF724 
		// Texture3D get_volumetricBlackTexture3D()
		Texture3D *HG::Rendering::Runtime::HGVolumetricFogUtils::get_volumetricBlackTexture3D(MethodInfo *method)
		{
		  Object_1 *s_volumetricBlackTexture3D; // rbx
		  Texture3D *VolumetricBlackTexture3D; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1558, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1558, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_642(Patch, 0LL);
		  }
		  else
		  {
		    s_volumetricBlackTexture3D = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields->s_volumetricBlackTexture3D;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(s_volumetricBlackTexture3D, 0LL, 0LL) )
		    {
		      VolumetricBlackTexture3D = HG::Rendering::Runtime::HGVolumetricFogUtils::_CreateVolumetricBlackTexture3D(0LL);
		      static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields;
		      static_fields->monitor = (MonitorData *)VolumetricBlackTexture3D;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields->s_volumetricBlackTexture3D,
		        static_fields,
		        v4,
		        v5,
		        v10);
		    }
		    return TypeInfo::HG::Rendering::Runtime::HGVolumetricFogUtils->static_fields->s_volumetricBlackTexture3D;
		  }
		}
		
	
		// Methods
		private static Mesh _CreateQuadMesh() => default; // 0x0000000189CEF370-0x0000000189CEF4E4
		// Mesh _CreateQuadMesh()
		Mesh *HG::Rendering::Runtime::HGVolumetricFogUtils::_CreateQuadMesh(MethodInfo *method)
		{
		  Mesh *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Mesh *v4; // rdi
		  __int64 v5; // rax
		  Vector3__Array *v6; // rsi
		  Array *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v10; // [rsp+20h] [rbp-20h] BYREF
		  int v11; // [rsp+28h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1556, 0LL) )
		  {
		    v1 = (Mesh *)sub_18002C620(TypeInfo::UnityEngine::Mesh);
		    v4 = v1;
		    if ( v1 )
		    {
		      UnityEngine::Mesh::Mesh(v1, 0LL);
		      v5 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		      v6 = (Vector3__Array *)v5;
		      if ( v5 )
		      {
		        v11 = 0;
		        v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v5, 0LL, &v10);
		        v11 = 0;
		        v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v6, 1LL, &v10);
		        v11 = 0;
		        v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v6, 2LL, &v10);
		        v11 = 0;
		        v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v6, 3LL, &v10);
		        v7 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		        System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		          v7,
		          752A6E22358C492163D1DE31BFAFB249C23A54C303CE495A18ABF04CF82E01B2_Field,
		          0LL);
		        UnityEngine::Mesh::set_vertices(v4, v6, 0LL);
		        UnityEngine::Mesh::set_triangles(v4, (Int32__Array *)v7, 0LL);
		        return v4;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1556, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
		private static Texture3D _CreateVolumetricBlackTexture3D() => default; // 0x0000000189CEF4E4-0x0000000189CEF5C4
		// Texture3D _CreateVolumetricBlackTexture3D()
		Texture3D *HG::Rendering::Runtime::HGVolumetricFogUtils::_CreateVolumetricBlackTexture3D(MethodInfo *method)
		{
		  Texture3D *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Object_1 *v4; // rbx
		  MethodInfo *v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v8; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1559, 0LL) )
		  {
		    v1 = (Texture3D *)sub_18002C620(TypeInfo::UnityEngine::Texture3D);
		    v4 = (Object_1 *)v1;
		    if ( v1 )
		    {
		      UnityEngine::Texture3D::Texture3D(
		        v1,
		        1,
		        1,
		        1,
		        GraphicsFormat__Enum_R16G16B16A16_SFloat,
		        TextureCreationFlags__Enum_None,
		        0LL);
		      UnityEngine::Object::set_name(v4, (String *)"Black Texture 3D", 0LL);
		      v8 = *UnityEngine::Quaternion::get_identity(&v8, v5);
		      UnityEngine::Texture3D::SetPixel((Texture3D *)v4, 0, 0, 0, (Color *)&v8, 0, 0LL);
		      UnityEngine::Texture3D::Apply((Texture3D *)v4, 0, 1, 0LL);
		      return (Texture3D *)v4;
		    }
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1559, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_642(Patch, 0LL);
		}
		
		public static RenderTexture GetAndCreateTemporaryRenderTexture(RenderTextureDescriptor desc, string name) => default; // 0x0000000189CEF1F4-0x0000000189CEF2BC
		// RenderTexture GetAndCreateTemporaryRenderTexture(RenderTextureDescriptor, String)
		RenderTexture *HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
		        RenderTextureDescriptor *desc,
		        String *name,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  Object_1 *Temporary; // rax
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  RenderTexture *v11; // rbx
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  RenderTextureDescriptor v16; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1546, 0LL) )
		  {
		    v5 = *(_OWORD *)&desc->_width_k__BackingField;
		    v6 = *(_OWORD *)&desc->_mipCount_k__BackingField;
		    v16._memoryless_k__BackingField = desc->_memoryless_k__BackingField;
		    *(_OWORD *)&v16._width_k__BackingField = v5;
		    v7 = *(_OWORD *)&desc->_dimension_k__BackingField;
		    *(_OWORD *)&v16._mipCount_k__BackingField = v6;
		    *(_OWORD *)&v16._dimension_k__BackingField = v7;
		    Temporary = (Object_1 *)UnityEngine::RenderTexture::GetTemporary(&v16, 0LL);
		    v11 = (RenderTexture *)Temporary;
		    if ( Temporary )
		    {
		      UnityEngine::Object::set_name(Temporary, name, 0LL);
		      UnityEngine::RenderTexture::Create(v11, 0LL);
		      return v11;
		    }
		LABEL_5:
		    sub_1800D8260(Patch, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1546, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  memoryless_k__BackingField = desc->_memoryless_k__BackingField;
		  v14 = *(_OWORD *)&desc->_mipCount_k__BackingField;
		  *(_OWORD *)&v16._width_k__BackingField = *(_OWORD *)&desc->_width_k__BackingField;
		  v15 = *(_OWORD *)&desc->_dimension_k__BackingField;
		  v16._memoryless_k__BackingField = memoryless_k__BackingField;
		  *(_OWORD *)&v16._mipCount_k__BackingField = v14;
		  *(_OWORD *)&v16._dimension_k__BackingField = v15;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_635(Patch, &v16, (Object *)name, 0LL);
		}
		
		[IDTag(0)]
		public static int DivideAndRoundUp(int dividend, int divisor) => default; // 0x0000000189CEF198-0x0000000189CEF1F4
		// Int32 DivideAndRoundUp(Int32, Int32)
		int32_t HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		        int32_t dividend,
		        int32_t divisor,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1534, 0LL) )
		    return (dividend + divisor - 1) / divisor;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1534, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_50((ILFixDynamicMethodWrapper_15 *)Patch, dividend, divisor, 0LL);
		}
		
		[IDTag(3)]
		public static Vector3Int DivideAndRoundUp(Vector3Int lhs, int divisor) => default; // 0x0000000189CEF038-0x0000000189CEF110
		// Vector3Int DivideAndRoundUp(Vector3Int, Int32)
		Vector3Int *HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		        Vector3Int *__return_ptr retstr,
		        Vector3Int *lhs,
		        int32_t divisor,
		        MethodInfo *method)
		{
		  int32_t v7; // edi
		  int32_t v8; // ebx
		  int32_t v9; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v11; // rcx
		  int32_t m_Z; // eax
		  Vector3Int *v13; // rax
		  __int64 v14; // xmm0_8
		  Vector3Int v16; // [rsp+30h] [rbp-28h] BYREF
		  Vector3Int v17[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1547, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1547, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, 0LL);
		    m_Z = lhs->m_Z;
		    *(_QWORD *)&v16.m_X = *(_QWORD *)&lhs->m_X;
		    v16.m_Z = m_Z;
		    v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_636(v17, Patch, &v16, divisor, 0LL);
		    v14 = *(_QWORD *)&v13->m_X;
		    v9 = v13->m_Z;
		    *(_QWORD *)&retstr->m_X = v14;
		  }
		  else
		  {
		    v7 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs->m_X, divisor, 0LL);
		    v8 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs->m_Y, divisor, 0LL);
		    v9 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs->m_Z, divisor, 0LL);
		    retstr->m_X = v7;
		    retstr->m_Y = v8;
		  }
		  retstr->m_Z = v9;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector2Int DivideAndRoundUp(Vector2Int lhs, int divisor) => default; // 0x0000000189CEEFB8-0x0000000189CEF038
		// Vector2Int DivideAndRoundUp(Vector2Int, Int32)
		Vector2Int HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		        Vector2Int lhs,
		        int32_t divisor,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t m_Y; // [rsp+34h] [rbp+Ch]
		  Vector2Int v10; // [rsp+48h] [rbp+20h]
		
		  m_Y = lhs.m_Y;
		  if ( IFix::WrappersManagerImpl::IsPatched(1533, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1533, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_626(Patch, lhs, divisor, 0LL);
		  }
		  else
		  {
		    v10.m_X = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_X, divisor, 0LL);
		    v10.m_Y = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(m_Y, divisor, 0LL);
		    return v10;
		  }
		}
		
		[IDTag(2)]
		public static Vector2Int DivideAndRoundUp(Vector2Int lhs, Vector2Int divisor) => default; // 0x0000000189CEF110-0x0000000189CEF198
		// Vector2Int DivideAndRoundUp(Vector2Int, Vector2Int)
		Vector2Int HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		        Vector2Int lhs,
		        Vector2Int divisor,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t v9; // [rsp+34h] [rbp+Ch]
		  int32_t m_Y; // [rsp+3Ch] [rbp+14h]
		  Vector2Int v11; // [rsp+48h] [rbp+20h]
		
		  m_Y = divisor.m_Y;
		  v9 = lhs.m_Y;
		  if ( IFix::WrappersManagerImpl::IsPatched(1535, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1535, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_627(Patch, lhs, divisor, 0LL);
		  }
		  else
		  {
		    v11.m_X = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(lhs.m_X, divisor.m_X, 0LL);
		    v11.m_Y = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(v9, m_Y, 0LL);
		    return v11;
		  }
		}
		
	
		// Extension methods
		public static Vector3Int GetWidthHeightAndVolumeDepth(this RenderTexture renderTexture) => default; // 0x0000000189CEF2BC-0x0000000189CEF370
		// Vector3Int GetWidthHeightAndVolumeDepth(RenderTexture)
		Vector3Int *HG::Rendering::Runtime::HGVolumetricFogUtils::GetWidthHeightAndVolumeDepth(
		        Vector3Int *__return_ptr retstr,
		        RenderTexture *renderTexture,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t v7; // edi
		  int32_t v8; // ebx
		  int32_t m_Z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3Int *v11; // rax
		  __int64 v12; // xmm0_8
		  Vector3Int v14[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1544, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1544, 0LL);
		    if ( Patch )
		    {
		      v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(v14, Patch, (Object *)renderTexture, 0LL);
		      v12 = *(_QWORD *)&v11->m_X;
		      m_Z = v11->m_Z;
		      *(_QWORD *)&retstr->m_X = v12;
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !renderTexture )
		    goto LABEL_5;
		  v7 = sub_180002F70(5LL, renderTexture);
		  v8 = sub_180002F70(7LL, renderTexture);
		  m_Z = UnityEngine::RenderTexture::get_volumeDepth(renderTexture, 0LL);
		  retstr->m_X = v7;
		  retstr->m_Y = v8;
		LABEL_7:
		  retstr->m_Z = m_Z;
		  return retstr;
		}
		
	}
}
