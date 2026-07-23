using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class FullScreenVFXData // TypeDefIndex: 38247
	{
		// Fields
		public const int GRID_VERTEX_COUNT = 144; // Metadata: 0x02303BFF
		public bool renderFullScreenVFXData; // 0x10
		private Mesh m_initMesh; // 0x18
		private FullScreenMeshMode m_cachedMode; // 0x20
		public Vector3[] meshVertices; // 0x28
	
		// Properties
		public Mesh fullScreenMesh { get => default; } // 0x00000001831D0DB0-0x00000001831D0DF0 
		// Mesh get_fullScreenMesh()
		Mesh *HG::Rendering::Runtime::FullScreenVFXData::get_fullScreenMesh(FullScreenVFXData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1133, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1133, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::FullScreenVFXData::EnsureMeshTopology(this, 0LL);
		    return this->fields.m_initMesh;
		  }
		}
		
	
		// Constructors
		public FullScreenVFXData() {} // 0x00000001843BAF60-0x00000001843BAF90
		// FullScreenVFXData()
		void HG::Rendering::Runtime::FullScreenVFXData::FullScreenVFXData(FullScreenVFXData *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  MethodInfo *v6; // [rsp+50h] [rbp+28h]
		
		  this->fields.meshVertices = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 3LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.meshVertices, v3, v4, v5, v6);
		}
		
	
		// Methods
		public void EnsureMeshTopology() {} // 0x00000001831D0DF0-0x00000001831D0FB0
		// Void EnsureMeshTopology()
		void HG::Rendering::Runtime::FullScreenVFXData::EnsureMeshTopology(FullScreenVFXData *this, MethodInfo *method)
		{
		  Mesh *m_initMesh; // rsi
		  int32_t fullScreenMeshMode; // edi
		  struct Object_1__Class *v5; // rcx
		  Mesh *v6; // rsi
		  struct Object_1__Class *v7; // rcx
		  Mesh *v8; // rax
		  __int64 v9; // rdx
		  Mesh *v10; // rcx
		  Object_1 *v11; // rsi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Mesh *v15; // rcx
		  __int64 v16; // rdx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1125, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1125, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_initMesh = this->fields.m_initMesh;
		    fullScreenMeshMode = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial->static_fields->fullScreenMeshMode;
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v5 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !m_initMesh )
		      goto LABEL_8;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( !m_initMesh->fields._.m_CachedPtr || fullScreenMeshMode != this->fields.m_cachedMode )
		    {
		LABEL_8:
		      v6 = this->fields.m_initMesh;
		      this->fields.m_cachedMode = fullScreenMeshMode;
		      v7 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v7 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v7 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !v6 )
		        goto LABEL_14;
		      if ( !v7->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v7);
		      if ( !v6->fields._.m_CachedPtr )
		      {
		LABEL_14:
		        v8 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		        v11 = (Object_1 *)v8;
		        if ( !v8 )
		          goto LABEL_15;
		        UnityEngine::Mesh::Mesh(v8, 0LL);
		        UnityEngine::Object::set_name(v11, (String *)"FullScreenVFXMesh", 0LL);
		        this->fields.m_initMesh = (Mesh *)v11;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_initMesh, v12, v13, v14, v21);
		        v10 = this->fields.m_initMesh;
		        if ( !v10 )
		          goto LABEL_15;
		        UnityEngine::Mesh::MarkDynamic(v10, 0LL);
		      }
		      v15 = this->fields.m_initMesh;
		      if ( fullScreenMeshMode == 1 )
		      {
		        HG::Rendering::Runtime::FullScreenVFXData::BuildGridMesh(v15, 0LL);
		        v16 = 144LL;
		      }
		      else
		      {
		        HG::Rendering::Runtime::FullScreenVFXData::BuildTriangleMesh(v15, 0LL);
		        v16 = 3LL;
		      }
		      this->fields.meshVertices = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, v16);
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.meshVertices, v17, v18, v19, v21);
		      v10 = this->fields.m_initMesh;
		      if ( v10 )
		      {
		        UnityEngine::Mesh::UploadMeshData(v10, 0, 0LL);
		        return;
		      }
		LABEL_15:
		      sub_1800D8260(v10, v9);
		    }
		  }
		}
		
		public void UpdateMeshVertices(Camera camera, float clipZ) {} // 0x00000001831D0BE0-0x00000001831D0D20
		// Void UpdateMeshVertices(Camera, Single)
		void HG::Rendering::Runtime::FullScreenVFXData::UpdateMeshVertices(
		        FullScreenVFXData *this,
		        Camera *camera,
		        float clipZ,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v6; // rcx
		  Mesh *m_initMesh; // rdi
		  Vector3__Array *v8; // rdi
		  __int64 v9; // rdx
		  Mesh *v10; // rcx
		  Boolean__Array *fullScreenGridMask; // rdi
		  Vector3__Array *meshVertices; // rbp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1124, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1124, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		        (ILFixDynamicMethodWrapper_9 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        clipZ,
		        0LL);
		      return;
		    }
		    goto LABEL_17;
		  }
		  HG::Rendering::Runtime::FullScreenVFXData::EnsureMeshTopology(this, 0LL);
		  v6 = TypeInfo::UnityEngine::Object;
		  m_initMesh = this->fields.m_initMesh;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_initMesh )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v6);
		    if ( m_initMesh->fields._.m_CachedPtr && this->fields.meshVertices && this->fields.meshVertices->max_length.value )
		    {
		      if ( this->fields.m_cachedMode == 1 )
		      {
		        fullScreenGridMask = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenGridMask(0LL);
		        meshVertices = this->fields.meshVertices;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		        HG::Rendering::Runtime::HGVFXManager::CalculateScreenMaterialGridCellMeshVertex(
		          camera,
		          clipZ,
		          fullScreenGridMask,
		          meshVertices,
		          0LL);
		      }
		      else
		      {
		        v8 = this->fields.meshVertices;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		        HG::Rendering::Runtime::HGVFXManager::CalculateScreenMaterialMeshVertex(camera, clipZ, v8, 0LL);
		      }
		      v10 = this->fields.m_initMesh;
		      if ( v10 )
		      {
		        UnityEngine::Mesh::set_vertices(v10, this->fields.meshVertices, 0LL);
		        v10 = this->fields.m_initMesh;
		        if ( v10 )
		        {
		          UnityEngine::Mesh::UploadMeshData(v10, 0, 0LL);
		          return;
		        }
		      }
		LABEL_17:
		      sub_1800D8260(v10, v9);
		    }
		  }
		}
		
		private static void BuildTriangleMesh(Mesh mesh) {} // 0x0000000184993180-0x0000000184993320
		// Void BuildTriangleMesh(Mesh)
		void HG::Rendering::Runtime::FullScreenVFXData::BuildTriangleMesh(Mesh *mesh, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rax
		  Vector3__Array *v6; // rsi
		  __int64 v7; // rax
		  Vector2__Array *v8; // rbx
		  Int32__Array *v9; // rax
		  Int32__Array *v10; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1127, 0LL) )
		  {
		    if ( mesh )
		    {
		      UnityEngine::Mesh::ClearImpl(mesh, 1, 0LL);
		      v5 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 3LL);
		      v6 = (Vector3__Array *)v5;
		      if ( v5 )
		      {
		        if ( !*(_DWORD *)(v5 + 24) )
		          goto LABEL_16;
		        *(_QWORD *)(v5 + 32) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        *(_DWORD *)(v5 + 40) = 0;
		        if ( *(_DWORD *)(v5 + 24) <= 1u )
		          goto LABEL_16;
		        *(_QWORD *)(v5 + 44) = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL).m128_u64[0];
		        *(_DWORD *)(v5 + 52) = 0;
		        if ( *(_DWORD *)(v5 + 24) <= 2u )
		          goto LABEL_16;
		        *(_QWORD *)(v5 + 56) = _mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u).m128_u64[0];
		        *(_DWORD *)(v5 + 64) = 0;
		        v7 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 3LL);
		        v8 = (Vector2__Array *)v7;
		        if ( v7 )
		        {
		          if ( !*(_DWORD *)(v7 + 24) )
		            goto LABEL_16;
		          *(_QWORD *)(v7 + 32) = 0LL;
		          if ( *(_DWORD *)(v7 + 24) <= 1u )
		            goto LABEL_16;
		          *(_QWORD *)(v7 + 40) = 0x40000000LL;
		          if ( *(_DWORD *)(v7 + 24) <= 2u )
		            goto LABEL_16;
		          *(_DWORD *)(v7 + 48) = 0;
		          *(_DWORD *)(v7 + 52) = 0x40000000;
		          v9 = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 3LL);
		          v10 = v9;
		          if ( v9 )
		          {
		            if ( v9->max_length.size > 1u )
		            {
		              v9->vector[1] = 2;
		              if ( v9->max_length.size > 2u )
		              {
		                v9->vector[2] = 1;
		                UnityEngine::Mesh::set_vertices(mesh, v6, 0LL);
		                UnityEngine::Mesh::set_uv(mesh, v8, 0LL);
		                UnityEngine::Mesh::set_triangles(mesh, v10, 0LL);
		                UnityEngine::Mesh::RecalculateBounds(mesh, MeshUpdateFlags__Enum_Default, 0LL);
		                return;
		              }
		            }
		LABEL_16:
		            sub_1800D2AB0(v4, v3);
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1127, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)mesh, 0LL);
		}
		
		private static void BuildGridMesh(Mesh mesh) {} // 0x0000000189BADC68-0x0000000189BADF00
		// Void BuildGridMesh(Mesh)
		void HG::Rendering::Runtime::FullScreenVFXData::BuildGridMesh(Mesh *mesh, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Vector3__Array *v5; // r12
		  Vector2__Array *v6; // rbx
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v7; // rax
		  List_1_System_Int32_ *v8; // r15
		  int v9; // r14d
		  int i; // ebp
		  int v11; // r13d
		  int32_t v12; // esi
		  float v13; // xmm8_4
		  float v14; // xmm6_4
		  float v15; // xmm1_4
		  float v16; // xmm0_4
		  __int64 v17; // rax
		  __int64 v18; // rax
		  __int64 v19; // rax
		  Int32__Array *v20; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1126, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1126, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)mesh, 0LL);
		      return;
		    }
		LABEL_16:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !mesh )
		    goto LABEL_16;
		  UnityEngine::Mesh::ClearImpl(mesh, 1, 0LL);
		  v5 = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 144LL);
		  v6 = (Vector2__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 144LL);
		  v7 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  v8 = (List_1_System_Int32_ *)v7;
		  if ( !v7 )
		    goto LABEL_16;
		  System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		    v7,
		    216,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  v9 = 0;
		  for ( i = 0; i < 144; i += 24 )
		  {
		    v11 = 0;
		    v12 = i;
		    v13 = (float)(v9 + 1) / 6.0;
		    v14 = (float)v9 / 6.0;
		    do
		    {
		      v15 = (float)(v11 + 1) / 6.0;
		      v16 = (float)v11 / 6.0;
		      if ( !v6 )
		        goto LABEL_16;
		      if ( (unsigned int)v12 >= v6->max_length.size )
		        goto LABEL_14;
		      v6->vector[v12].x = v16;
		      v6->vector[v12].y = v14;
		      v17 = v12 + 1LL;
		      if ( (unsigned int)v17 >= v6->max_length.size
		        || (v6->vector[v17].x = v16, v6->vector[v17].y = v13, v18 = v12 + 2LL, (unsigned int)v18 >= v6->max_length.size)
		        || (v6->vector[v18].x = v15, v6->vector[v18].y = v14, v19 = v12 + 3LL, (unsigned int)v19 >= v6->max_length.size) )
		      {
		LABEL_14:
		        sub_1800D2AB0(v4, v3);
		      }
		      v6->vector[v19].x = v15;
		      v6->vector[v19].y = v13;
		      sub_183081250(v8, (unsigned int)v12, MethodInfo::System::Collections::Generic::List<int>::Add);
		      sub_183081250(v8, (unsigned int)(v12 + 1), MethodInfo::System::Collections::Generic::List<int>::Add);
		      sub_183081250(v8, (unsigned int)(v12 + 2), MethodInfo::System::Collections::Generic::List<int>::Add);
		      sub_183081250(v8, (unsigned int)(v12 + 2), MethodInfo::System::Collections::Generic::List<int>::Add);
		      sub_183081250(v8, (unsigned int)(v12 + 1), MethodInfo::System::Collections::Generic::List<int>::Add);
		      sub_183081250(v8, (unsigned int)(v12 + 3), MethodInfo::System::Collections::Generic::List<int>::Add);
		      ++v11;
		      v12 += 4;
		    }
		    while ( v11 < 6 );
		    ++v9;
		  }
		  UnityEngine::Mesh::set_vertices(mesh, v5, 0LL);
		  UnityEngine::Mesh::set_uv(mesh, v6, 0LL);
		  v20 = System::Collections::Generic::List<int>::ToArray(
		          v8,
		          MethodInfo::System::Collections::Generic::List<int>::ToArray);
		  UnityEngine::Mesh::set_triangles(mesh, v20, 0LL);
		  UnityEngine::Mesh::RecalculateBounds(mesh, MeshUpdateFlags__Enum_Default, 0LL);
		}
		
	}
}
