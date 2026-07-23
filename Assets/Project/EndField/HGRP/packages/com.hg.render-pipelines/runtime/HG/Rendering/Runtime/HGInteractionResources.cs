using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGInteractionResources // TypeDefIndex: 37749
	{
		// Fields
		public static Mesh Cylinder; // 0x00
		public static Mesh Capsule; // 0x08
		public static Mesh Cube; // 0x10
		private static Mesh _quadMesh; // 0x18
	
		// Properties
		public static Mesh QuadMesh { get; } // 0x0000000189D0160C-0x0000000189D01960 
		// Mesh get_QuadMesh()
		Mesh *HG::Rendering::Runtime::HGInteractionResources::get_QuadMesh(MethodInfo *method)
		{
		  Object_1 *quadMesh; // rbx
		  Mesh *v2; // rax
		  __int64 v3; // rdx
		  Mesh *v4; // rcx
		  Type__Class *v5; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Mesh *v9; // rdi
		  __int64 v10; // rax
		  Vector3__Array *v11; // rbx
		  Mesh *v12; // rbx
		  __int64 v13; // rax
		  Mesh *v14; // rbx
		  Array *v15; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v18; // [rsp+20h] [rbp-40h] BYREF
		  int v19; // [rsp+28h] [rbp-38h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1808, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		    quadMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(quadMesh, 0LL, 0LL) )
		    {
		LABEL_17:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      return TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		    }
		    v2 = (Mesh *)sub_18002C620(TypeInfo::UnityEngine::Mesh);
		    v5 = (Type__Class *)v2;
		    if ( v2 )
		    {
		      UnityEngine::Mesh::Mesh(v2, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		      static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields;
		      static_fields[1].klass = v5;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh,
		        static_fields,
		        v7,
		        v8,
		        v18);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		      if ( v4 )
		      {
		        UnityEngine::Mesh::ClearImpl(v4, 1, 0LL);
		        v4 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		        if ( v4 )
		        {
		          UnityEngine::Mesh::set_indexFormat(v4, IndexFormat__Enum_UInt16, 0LL);
		          v9 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		          v10 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		          v11 = (Vector3__Array *)v10;
		          if ( v10 )
		          {
		            v19 = -1090519040;
		            v18 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
		            sub_180049BD0(v10, 0LL, &v18);
		            v19 = 1056964608;
		            v18 = (MethodInfo *)_mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
		            sub_180049BD0(v11, 1LL, &v18);
		            v19 = 1056964608;
		            v18 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
		            sub_180049BD0(v11, 2LL, &v18);
		            v19 = -1090519040;
		            v18 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
		            sub_180049BD0(v11, 3LL, &v18);
		            if ( v9 )
		            {
		              UnityEngine::Mesh::set_vertices(v9, v11, 0LL);
		              v12 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		              v13 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 4LL);
		              if ( v13 )
		              {
		                if ( !*(_DWORD *)(v13 + 24)
		                  || (*(_DWORD *)(v13 + 32) = 0, *(_DWORD *)(v13 + 36) = 0, *(_DWORD *)(v13 + 24) <= 1u)
		                  || (*(_DWORD *)(v13 + 40) = 0,
		                      v4 = (Mesh *)1065353216,
		                      *(_DWORD *)(v13 + 44) = 1065353216,
		                      *(_DWORD *)(v13 + 24) <= 2u)
		                  || (*(_DWORD *)(v13 + 48) = 1065353216, *(_DWORD *)(v13 + 52) = 1065353216,
		                                                          *(_DWORD *)(v13 + 24) <= 3u) )
		                {
		                  sub_1800D2AB0(v4, v3);
		                }
		                *(_QWORD *)(v13 + 56) = 1065353216LL;
		                if ( v12 )
		                {
		                  UnityEngine::Mesh::set_uv(v12, (Vector2__Array *)v13, 0LL);
		                  v14 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		                  v15 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		                  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		                    v15,
		                    FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE_Field_0,
		                    0LL);
		                  if ( v14 )
		                  {
		                    UnityEngine::Mesh::set_triangles(v14, (Int32__Array *)v15, 0LL);
		                    v4 = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->_quadMesh;
		                    if ( v4 )
		                    {
		                      UnityEngine::Mesh::RecalculateBounds(v4, MeshUpdateFlags__Enum_Default, 0LL);
		                      goto LABEL_17;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_20:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1808, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
	
		// Constructors
		static HGInteractionResources() {} // 0x0000000189D01554-0x0000000189D0160C
		// HGInteractionResources()
		void HG::Rendering::Runtime::HGInteractionResources::cctor(MethodInfo *method)
		{
		  Object *v1; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  Object *v5; // rax
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Object *v9; // rax
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  v1 = UnityEngine::Resources::GetBuiltinResource<System::Object>(
		         (String *)"Cylinder.fbx",
		         MethodInfo::UnityEngine::Resources::GetBuiltinResource<UnityEngine::Mesh>);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v13);
		  v5 = UnityEngine::Resources::GetBuiltinResource<System::Object>(
		         (String *)"Capsule.fbx",
		         MethodInfo::UnityEngine::Resources::GetBuiltinResource<UnityEngine::Mesh>);
		  v6 = (Type *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields;
		  v6->monitor = (MonitorData *)v5;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->Capsule,
		    v6,
		    v7,
		    v8,
		    v14);
		  v9 = UnityEngine::Resources::GetBuiltinResource<System::Object>(
		         (String *)"Cube.fbx",
		         MethodInfo::UnityEngine::Resources::GetBuiltinResource<UnityEngine::Mesh>);
		  v10 = (Type *)TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields;
		  v10->fields._impl.value = v9;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields->Cube,
		    v10,
		    v11,
		    v12,
		    v15);
		}
		
	}
}
