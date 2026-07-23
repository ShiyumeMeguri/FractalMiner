using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.CSG;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.SDF
{
	public class MeshCombine // TypeDefIndex: 38796
	{
		// Fields
		private List<Vector3> vertices; // 0x10
		private List<int> triangles; // 0x18
		private Bounds bounds; // 0x20
	
		// Constructors
		public MeshCombine() {} // 0x0000000189C7ADE0-0x0000000189C7AE60
	
		// Methods
		public Vector3[] GetVertices() => default; // 0x0000000189C7AB64-0x0000000189C7ABC4
		// Vector3[] GetVertices()
		Vector3__Array *HG::Rendering::Runtime::SDF::MeshCombine::GetVertices(MeshCombine *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_UnityEngine_Vector3_ *vertices; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5399, 0LL) )
		  {
		    vertices = this->fields.vertices;
		    if ( vertices )
		      return (Vector3__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
		                                 (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)vertices,
		                                 MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::ToArray);
		LABEL_5:
		    sub_1800D8260(vertices, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5399, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_833(Patch, (Object *)this, 0LL);
		}
		
		public int[] GetTriangles() => default; // 0x0000000189C7AB04-0x0000000189C7AB64
		// Int32[] GetTriangles()
		Int32__Array *HG::Rendering::Runtime::SDF::MeshCombine::GetTriangles(MeshCombine *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_System_Int32_ *triangles; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5400, 0LL) )
		  {
		    triangles = this->fields.triangles;
		    if ( triangles )
		      return System::Collections::Generic::List<int>::ToArray(
		               triangles,
		               MethodInfo::System::Collections::Generic::List<int>::ToArray);
		LABEL_5:
		    sub_1800D8260(triangles, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5400, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1388(Patch, (Object *)this, 0LL);
		}
		
		public Bounds GetBounds() => default; // 0x0000000189C7AA90-0x0000000189C7AB04
		// Bounds GetBounds()
		Bounds *HG::Rendering::Runtime::SDF::MeshCombine::GetBounds(
		        Bounds *__return_ptr retstr,
		        MeshCombine *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  __int64 v6; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Bounds *v10; // rax
		  Bounds *result; // rax
		  Bounds v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5304, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5304, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_686(&v12, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v10->m_Center.x;
		    v6 = *(_QWORD *)&v10->m_Extents.y;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.bounds.m_Center.x;
		    v6 = *(_QWORD *)&this->fields.bounds.m_Extents.y;
		  }
		  *(_OWORD *)&retstr->m_Center.x = v5;
		  result = retstr;
		  *(_QWORD *)&retstr->m_Extents.y = v6;
		  return result;
		}
		
		public void Reset() {} // 0x0000000189C7AD6C-0x0000000189C7ADE0
		// Void Reset()
		void HG::Rendering::Runtime::SDF::MeshCombine::Reset(MeshCombine *this, MethodInfo *method)
		{
		  List_1_System_Int32_ *triangles; // rcx
		  List_1_UnityEngine_Vector3_ *vertices; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5401, 0LL) )
		  {
		    vertices = this->fields.vertices;
		    if ( vertices )
		    {
		      ++vertices->fields._version;
		      vertices->fields._size = 0;
		      triangles = this->fields.triangles;
		      if ( triangles )
		      {
		        ++triangles->fields._version;
		        triangles->fields._size = 0;
		        HG::Rendering::Runtime::SDF::MeshCombine::RecalculateBounds(this, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(triangles, vertices);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5401, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		[IDTag(0)]
		public void AddMesh(Mesh mesh, Matrix4x4 transform) {} // 0x0000000189C7A2D0-0x0000000189C7A4D8
		// Void AddMesh(Mesh, Matrix4x4)
		void HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(
		        MeshCombine *this,
		        Mesh *mesh,
		        Matrix4x4 *transform,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  List_1_System_Int32_ *v8; // rcx
		  List_1_UnityEngine_Vector3_ *vertices; // rax
		  int32_t size; // r12d
		  int32_t v11; // esi
		  Int32__Array *Triangles; // r14
		  int32_t v13; // ebx
		  Vector3__Array *v14; // rdi
		  int32_t v15; // ebx
		  __int128 v16; // xmm1
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  MethodInfo *v19; // r8
		  Vector3 *v20; // rax
		  __int64 v21; // r9
		  __int64 v22; // xmm0_8
		  float z; // eax
		  List_1_UnityEngine_Vector3_ *v24; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  float v29; // [rsp+38h] [rbp-69h] BYREF
		  __int64 v30; // [rsp+3Ch] [rbp-65h]
		  Vector4 v31; // [rsp+48h] [rbp-59h]
		  __int64 v32; // [rsp+58h] [rbp-49h] BYREF
		  float v33; // [rsp+60h] [rbp-41h]
		  Vector4 v34; // [rsp+68h] [rbp-39h] BYREF
		  Matrix4x4 v35; // [rsp+78h] [rbp-29h] BYREF
		  Vector3 v36; // [rsp+B8h] [rbp+17h] BYREF
		  Vector4 v37; // [rsp+C8h] [rbp+27h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5249, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5249, 0LL);
		    if ( Patch )
		    {
		      v26 = *(_OWORD *)&transform->m01;
		      *(_OWORD *)&v35.m00 = *(_OWORD *)&transform->m00;
		      v27 = *(_OWORD *)&transform->m02;
		      *(_OWORD *)&v35.m01 = v26;
		      v28 = *(_OWORD *)&transform->m03;
		      *(_OWORD *)&v35.m02 = v27;
		      *(_OWORD *)&v35.m03 = v28;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1516(Patch, (Object *)this, (Object *)mesh, &v35, 0LL);
		      return;
		    }
		LABEL_17:
		    sub_1800D8260(v8, v7);
		  }
		  vertices = this->fields.vertices;
		  if ( !vertices )
		    goto LABEL_17;
		  size = vertices->fields._size;
		  v11 = 0;
		  if ( !mesh )
		    goto LABEL_17;
		  while ( v11 < UnityEngine::Mesh::get_subMeshCount(mesh, 0LL) )
		  {
		    Triangles = UnityEngine::Mesh::GetTriangles(mesh, v11, 0LL);
		    v13 = 0;
		    if ( !Triangles )
		      goto LABEL_17;
		    while ( v13 < Triangles->max_length.size )
		    {
		      if ( (unsigned int)v13 >= Triangles->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = this->fields.triangles;
		      if ( !v8 )
		        goto LABEL_17;
		      sub_183081250(
		        v8,
		        (unsigned int)(size + Triangles->vector[v13++]),
		        MethodInfo::System::Collections::Generic::List<int>::Add);
		    }
		    ++v11;
		  }
		  v14 = UnityEngine::Mesh::get_vertices(mesh, 0LL);
		  v15 = 0;
		  if ( !v14 )
		    goto LABEL_17;
		  while ( v15 < v14->max_length.size )
		  {
		    sub_180049C60(v14, &v29, v15);
		    v31.x = v29;
		    *(_QWORD *)&v31.y = v30;
		    v16 = *(_OWORD *)&transform->m00;
		    v31.w = 1.0;
		    *(_OWORD *)&v35.m00 = v16;
		    v17 = *(_OWORD *)&transform->m02;
		    v34 = v31;
		    v18 = *(_OWORD *)&transform->m01;
		    *(_OWORD *)&v35.m02 = v17;
		    *(_OWORD *)&v35.m01 = v18;
		    *(_OWORD *)&v35.m03 = *(_OWORD *)&transform->m03;
		    v34 = *UnityEngine::Matrix4x4::op_Multiply(&v37, &v35, &v34, 0LL);
		    v20 = UnityEngine::Vector4::op_Implicit(&v36, &v34, v19);
		    if ( !this->fields.vertices )
		      goto LABEL_17;
		    v22 = *(_QWORD *)&v20->x;
		    z = v20->z;
		    v24 = this->fields.vertices;
		    v32 = v22;
		    v33 = z;
		    sub_18036459C(v24, &v32, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v21);
		    ++v15;
		  }
		}
		
		[IDTag(1)]
		public void AddMesh(BSP csg, Matrix4x4 transform) {} // 0x0000000189C7A4D8-0x0000000189C7AA90
		// Void AddMesh(BSP, Matrix4x4)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(
		        MeshCombine *this,
		        BSP *csg,
		        Matrix4x4 *transform,
		        MethodInfo *method)
		{
		  Matrix4x4 *v4; // r15
		  Object *v6; // r13
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rbx
		  LowLevelList_1_System_Object_ *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  LowLevelList_1_System_Object_ *v14; // rdi
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v15; // rdx
		  __int64 v16; // rcx
		  VolumetricRenderer_VolumetricBounds *v17; // r8
		  Int32__Array **v18; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v19; // rdx
		  VolumetricRenderer_VolumetricBounds *v20; // r8
		  Int32__Array **v21; // r9
		  Func_5_UnityEngine_Vector3_UnityEngine_Vector2_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *_9__8_0; // rdi
		  Object *v23; // rsi
		  Func_5_UnityEngine_Vector3_UnityEngine_Vector2_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v27; // rdx
		  VolumetricRenderer_VolumetricBounds *v28; // r8
		  Int32__Array **v29; // r9
		  Func_2_HG_Rendering_Runtime_CSG_PostionUVPair_Int32_ *v30; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  Func_2_HG_Rendering_Runtime_CSG_PostionUVPair_Int32_ *v33; // rsi
		  Action_4_Int32_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *v34; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  Action_4_Int32_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *v37; // r14
		  List_1_UnityEngine_Vector3_ *v38; // rdx
		  Il2CppException *v39; // rcx
		  Object__Class *klass; // r12
		  int namespaze; // r12d
		  MethodInfo *v42; // rsi
		  int32_t v43; // edi
		  __int64 v44; // r14
		  MonitorData *monitor; // rcx
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  __m128 v48; // xmm0
		  __m128 v49; // xmm1
		  unsigned __int32 v50; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  __int64 v54; // [rsp+0h] [rbp-158h] BYREF
		  MethodInfo *methoda; // [rsp+20h] [rbp-138h]
		  MethodInfo *v56; // [rsp+28h] [rbp-130h]
		  int32_t v57; // [rsp+30h] [rbp-128h]
		  int v58; // [rsp+34h] [rbp-124h]
		  Il2CppException *ex; // [rsp+38h] [rbp-120h]
		  void *v60; // [rsp+40h] [rbp-118h]
		  Vector4 v61; // [rsp+48h] [rbp-110h]
		  bool v62; // [rsp+58h] [rbp-100h]
		  MethodInfo *v63; // [rsp+60h] [rbp-F8h] BYREF
		  unsigned __int32 v64; // [rsp+68h] [rbp-F0h]
		  Vector4 v65; // [rsp+70h] [rbp-E8h] BYREF
		  List_1_T_Enumerator_System_Int32_ v66; // [rsp+80h] [rbp-D8h] BYREF
		  List_1_T_Enumerator_UnityEngine_Vector3_ v67; // [rsp+98h] [rbp-C0h] BYREF
		  List_1_T_Enumerator_UnityEngine_Vector3_ v68; // [rsp+B8h] [rbp-A0h] BYREF
		  Matrix4x4 v69; // [rsp+E0h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v70; // [rsp+120h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v71; // [rsp+128h] [rbp-30h] BYREF
		
		  v4 = transform;
		  v6 = (Object *)this;
		  memset(&v66, 0, sizeof(v66));
		  memset(&v67, 0, sizeof(v67));
		  if ( IFix::WrappersManagerImpl::IsPatched(5295, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5295, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v53, v52);
		    v69 = *v4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1516(Patch, v6, (Object *)csg, &v69, 0LL);
		  }
		  else
		  {
		    v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0);
		    v10 = v7;
		    if ( !v7 )
		      sub_1800D8260(v9, v8);
		    *(_QWORD *)&v61.x = v7;
		    v11 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
		    v14 = v11;
		    if ( !v11 )
		      sub_1800D8260(v13, v12);
		    System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		      v11,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		    if ( !v10 )
		      sub_1800D8260(v16, v15);
		    *(_QWORD *)(v10 + 16) = v14;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)(v10 + 16),
		      v15,
		      v17,
		      v18,
		      methoda,
		      v56,
		      v57,
		      (int32_t)ex,
		      *(float *)&v60,
		      SLODWORD(v61.x),
		      SLOBYTE(v61.z),
		      v62,
		      v63);
		    *(_QWORD *)(v10 + 24) = il2cpp_array_new_specific_1(TypeInfo::System::Collections::Generic::List<int>, 10LL);
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)(v10 + 24),
		      v19,
		      v20,
		      v21,
		      methoda,
		      v56,
		      v57,
		      (int32_t)ex,
		      *(float *)&v60,
		      SLODWORD(v61.x),
		      SLOBYTE(v61.z),
		      v62,
		      v63);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c);
		    _9__8_0 = TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c->static_fields->__9__8_0;
		    if ( !_9__8_0 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c);
		      v23 = (Object *)TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c->static_fields->__9;
		      v24 = (Func_5_UnityEngine_Vector3_UnityEngine_Vector2_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *)sub_18002C620(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector2,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>);
		      _9__8_0 = v24;
		      if ( !v24 )
		        sub_1800D8260(v26, v25);
		      System::Func<UnityEngine::Vector3,UnityEngine::Vector2,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>::Func(
		        v24,
		        v23,
		        MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c::_AddMesh_b__8_0,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c->static_fields->__9__8_0 = _9__8_0;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c->static_fields->__9__8_0,
		        v27,
		        v28,
		        v29,
		        methoda,
		        v56,
		        v57,
		        (int32_t)ex,
		        *(float *)&v60,
		        SLODWORD(v61.x),
		        SLOBYTE(v61.z),
		        v62,
		        v63);
		    }
		    v30 = (Func_2_HG_Rendering_Runtime_CSG_PostionUVPair_Int32_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::PostionUVPair,int>);
		    v33 = v30;
		    if ( !v30 )
		      sub_1800D8260(v32, v31);
		    System::Func<HG::Rendering::Runtime::CSG::PostionUVPair,int>::Func(
		      v30,
		      (Object *)v10,
		      MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0::_AddMesh_b__1,
		      0LL);
		    v34 = (Action_4_Int32_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *)sub_18002C620(TypeInfo::System::Action<int,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>);
		    v37 = v34;
		    if ( !v34 )
		      sub_1800D8260(v36, v35);
		    System::Action<int,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>::Action(
		      v34,
		      (Object *)v10,
		      MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0::_AddMesh_b__2,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    HG::Rendering::Runtime::CSG::Extensions::ToTriangleList<HG::Rendering::Runtime::CSG::PostionUVPair,int>(
		      (ICsgProvider *)csg,
		      _9__8_0,
		      v33,
		      v37,
		      MethodInfo::HG::Rendering::Runtime::CSG::Extensions::ToTriangleList<HG::Rendering::Runtime::CSG::PostionUVPair,int>);
		    klass = v6[1].klass;
		    if ( !klass )
		      sub_1800D8260(v39, v38);
		    namespaze = (int)klass->_0.namespaze;
		    v58 = namespaze;
		    v42 = *(MethodInfo **)(v10 + 24);
		    v63 = v42;
		    v43 = 0;
		    v57 = 0;
		    if ( !v42 )
		      goto LABEL_45;
		    while ( v43 < SLODWORD(v42->name) )
		    {
		      if ( (unsigned int)v43 >= LODWORD(v42->name) )
		        sub_1800D2AB0(v39, v38);
		      v44 = *((_QWORD *)&v42->klass + v43);
		      if ( v44 && *(int *)(v44 + 24) > 0 )
		      {
		        System::Collections::Generic::List<int>::GetEnumerator(
		          (List_1_T_Enumerator_System_Int32_ *)&v68,
		          *((List_1_System_Int32_ **)&v42->klass + v43),
		          MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		        *(_OWORD *)&v66._list = *(_OWORD *)&v68._list;
		        *(_QWORD *)&v66._current = *(_QWORD *)&v68._current.x;
		        ex = 0LL;
		        v60 = &v66;
		        try
		        {
		          while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                    &v66,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		          {
		            monitor = v6[1].monitor;
		            if ( !monitor )
		              sub_1800D8250(0LL, v38);
		            sub_183081250(
		              monitor,
		              (unsigned int)(namespaze + v66._current),
		              MethodInfo::System::Collections::Generic::List<int>::Add);
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v70 )
		        {
		          v38 = (List_1_UnityEngine_Vector3_ *)&v54;
		          ex = v70->ex;
		          v39 = ex;
		          if ( ex )
		            sub_18007E1E0(ex);
		          v4 = transform;
		          v6 = (Object *)this;
		          v10 = *(_QWORD *)&v61.x;
		          namespaze = v58;
		          v42 = v63;
		          v43 = v57;
		        }
		      }
		      v57 = ++v43;
		    }
		    if ( !v10 || (v38 = *(List_1_UnityEngine_Vector3_ **)(v10 + 16)) == 0LL )
		LABEL_45:
		      sub_1800D8250(v39, v38);
		    System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator(
		      &v68,
		      v38,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
		    v67 = v68;
		    ex = 0LL;
		    v60 = &v67;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext(
		                &v67,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
		      {
		        *(_QWORD *)&v61.x = *(_QWORD *)&v67._current.x;
		        *(_QWORD *)&v61.z = LODWORD(v67._current.z) | 0x3F80000000000000LL;
		        v65 = v61;
		        v69 = *v4;
		        v48 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
		                                                         (Vector4 *)&v68,
		                                                         &v69,
		                                                         &v65,
		                                                         0LL));
		        v49 = _mm_shuffle_ps(v48, v48, 85);
		        v50 = _mm_shuffle_ps(v48, v48, 170).m128_u32[0];
		        if ( !v6[1].klass )
		          sub_1800D8250(v47, v46);
		        v63 = (MethodInfo *)_mm_unpacklo_ps(v48, v49).m128_u64[0];
		        v64 = v50;
		        sub_1832536D0(v6[1].klass, &v63, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v71 )
		    {
		      ex = v71->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		public void RecalculateBounds() {} // 0x0000000189C7ABC4-0x0000000189C7AD6C
		// Void RecalculateBounds()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::SDF::MeshCombine::RecalculateBounds(MeshCombine *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_UnityEngine_Vector3_ *vertices; // rdi
		  Animator *v6; // rdx
		  int32_t v7; // r8d
		  MethodInfo *v8; // r9
		  Vector3 *Vector; // rax
		  __int64 v10; // rdx
		  __int64 z_low; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-68h] BYREF
		  Vector3 v16; // [rsp+30h] [rbp-58h] BYREF
		  List_1_T_Enumerator_UnityEngine_Vector3_ v17; // [rsp+40h] [rbp-48h] BYREF
		  List_1_T_Enumerator_UnityEngine_Vector3_ v18; // [rsp+60h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5303, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5303, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    *(_OWORD *)&this->fields.bounds.m_Center.x = 0LL;
		    *(_QWORD *)&this->fields.bounds.m_Extents.y = 0LL;
		    vertices = this->fields.vertices;
		    if ( !vertices )
		      sub_1800D8260(v4, v3);
		    if ( vertices->fields._size > 0 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::DynamicScene::DynamicStreamingScene::LodRawInfo>::get_Item(
		        (DynamicStreamingScene_LodRawInfo *)&v16,
		        (List_1_Beyond_Gameplay_Core_DynamicScene_DynamicStreamingScene_LodRawInfo_ *)this->fields.vertices,
		        0,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
		      this->fields.bounds.m_Center = v16;
		      Vector = UnityEngine::Animator::GetVector(&v16, v6, v7, v8);
		      z_low = LODWORD(Vector->z);
		      *(_QWORD *)&this->fields.bounds.m_Extents.x = *(_QWORD *)&Vector->x;
		      LODWORD(this->fields.bounds.m_Extents.z) = z_low;
		      if ( !this->fields.vertices )
		        sub_1800D8260(z_low, v10);
		      System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator(
		        &v17,
		        this->fields.vertices,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
		      v18 = v17;
		      v17._list = 0LL;
		      *(_QWORD *)&v17._index = &v18;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext(
		                  &v18,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
		        {
		          *(_QWORD *)&v16.x = *(_QWORD *)&v18._current.x;
		          LODWORD(v16.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v18._current.x, 8));
		          UnityEngine::Bounds::Encapsulate(&this->fields.bounds, &v16, 0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v15 )
		      {
		        v17._list = (List_1_UnityEngine_Vector3_ *)v15->ex;
		        if ( v17._list )
		          sub_18007E1E0(v17._list);
		      }
		    }
		  }
		}
		
	}
}
