using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGFoliageOccluderUtils // TypeDefIndex: 37984
	{
		// Fields
		private static Mesh s_quadMesh; // 0x00
	
		// Properties
		public static Mesh quadMesh { get; } // 0x0000000189B6B524-0x0000000189B6B5D0 
		// Mesh get_quadMesh()
		Mesh *HG::Rendering::Runtime::HGFoliageOccluderUtils::get_quadMesh(MethodInfo *method)
		{
		  Object_1 *s_quadMesh; // rbx
		  Mesh *QuadMesh; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2623, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2623, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		  }
		  else
		  {
		    s_quadMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderUtils->static_fields->s_quadMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(s_quadMesh, 0LL, 0LL) )
		    {
		      QuadMesh = HG::Rendering::Runtime::HGFoliageOccluderUtils::_CreateQuadMesh(0LL);
		      static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderUtils->static_fields;
		      static_fields->klass = (Type__Class *)QuadMesh;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderUtils->static_fields,
		        static_fields,
		        v4,
		        v5,
		        v10);
		    }
		    return TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderUtils->static_fields->s_quadMesh;
		  }
		}
		
	
		// Methods
		private static Mesh _CreateQuadMesh() => default; // 0x0000000189B6B388-0x0000000189B6B524
		// Mesh _CreateQuadMesh()
		Mesh *HG::Rendering::Runtime::HGFoliageOccluderUtils::_CreateQuadMesh(MethodInfo *method)
		{
		  Mesh *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Mesh *v4; // rdi
		  __int64 v5; // rax
		  Vector3__Array *v6; // rsi
		  Array *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v10; // [rsp+20h] [rbp-40h] BYREF
		  int v11; // [rsp+28h] [rbp-38h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2624, 0LL) )
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
		        v11 = -1090519040;
		        v10 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v5, 0LL, &v10);
		        v11 = -1090519040;
		        v10 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v6, 1LL, &v10);
		        v11 = 1056964608;
		        v10 = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
		        sub_180049BD0(v6, 2LL, &v10);
		        v11 = 1056964608;
		        v10 = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
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
		  Patch = IFix::WrappersManagerImpl::GetPatch(2624, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
	}
}
