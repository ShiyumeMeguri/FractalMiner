using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class Node // TypeDefIndex: 38819
	{
		// Fields
		public static List<CSGPolygon> polys; // 0x00
		public static IList<CSGPolygon> frontPolys; // 0x08
		public static IList<CSGPolygon> backPolys; // 0x10
		public static Node node; // 0x18
		public Plane? splitPlane; // 0x10
		public Node front; // 0x28
		public Node back; // 0x30
		public List<CSGPolygon> polygons; // 0x38
		[ThreadStatic]
		private static System.Random random; // 0x80000000
	
		// Properties
		public IEnumerable<CSGPolygon> AllPolygons { [IteratorStateMachine(typeof(_get_AllPolygons_d__10))] get => default; } // 0x0000000189C7C81C-0x0000000189C7C8A0 
	
		// Constructors
		public Node() {} // 0x0000000189C7C6E4-0x0000000189C7C734
		// Node()
		void HG::Rendering::Runtime::CSG::Node::Node(Node_2 *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v6; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v7; // rdx
		  VolumetricRenderer_VolumetricBounds *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		  MethodInfo *v11; // [rsp+58h] [rbp+30h]
		  int32_t v12; // [rsp+60h] [rbp+38h]
		  int32_t v13; // [rsp+68h] [rbp+40h]
		  float v14; // [rsp+70h] [rbp+48h]
		  int32_t v15; // [rsp+78h] [rbp+50h]
		  bool v16; // [rsp+80h] [rbp+58h]
		  bool v17; // [rsp+88h] [rbp+60h]
		  MethodInfo *v18; // [rsp+90h] [rbp+68h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		  v6 = (List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		  this->fields.polygons = v6;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.polygons,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14,
		    v15,
		    v16,
		    v17,
		    v18);
		}
		
	
		// Methods
		public static IEnumerable<CSGPolygon> getAllPolygons(Node root, ref List<CSGPolygon> polygons) => default; // 0x0000000189C7C734-0x0000000189C7C81C
		public static void transformAllPolygons(Node root, Matrix4x4 matrix) {} // 0x0000000189C7CA0C-0x0000000189C7CCCC
		// Void transformAllPolygons(Node, Matrix4x4)
		void HG::Rendering::Runtime::CSG::Node::transformAllPolygons(Node_2 *root, Matrix4x4 *matrix, MethodInfo *method)
		{
		  Object__Class *v5; // rdx
		  Vector3__Array *vertices; // rcx
		  int32_t v7; // r15d
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons; // rax
		  Object *Item; // r14
		  int32_t v10; // esi
		  Object__Class *klass; // rax
		  __int64 v12; // r13
		  __int64 v13; // r8
		  Vector3 *v14; // rax
		  __int64 v15; // r13
		  __int64 v16; // r8
		  Vector3 *v17; // rax
		  Node_2 *front; // rcx
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  Node_2 *back; // rcx
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Vector3 v30; // [rsp+28h] [rbp-59h] BYREF
		  Vector3 v31; // [rsp+38h] [rbp-49h] BYREF
		  Vector3 v32; // [rsp+48h] [rbp-39h] BYREF
		  Vector3 v33; // [rsp+58h] [rbp-29h] BYREF
		  Matrix4x4 v34; // [rsp+68h] [rbp-19h] BYREF
		  Vector3 v35; // [rsp+A8h] [rbp+27h] BYREF
		  Vector3 v36; // [rsp+B8h] [rbp+37h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5444, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5444, 0LL);
		    if ( Patch )
		    {
		      v27 = *(_OWORD *)&matrix->m01;
		      *(_OWORD *)&v34.m00 = *(_OWORD *)&matrix->m00;
		      v28 = *(_OWORD *)&matrix->m02;
		      *(_OWORD *)&v34.m01 = v27;
		      v29 = *(_OWORD *)&matrix->m03;
		      *(_OWORD *)&v34.m02 = v28;
		      *(_OWORD *)&v34.m03 = v29;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1577(Patch, (Object *)root, &v34, 0LL);
		      return;
		    }
		LABEL_26:
		    sub_1800D8260(vertices, v5);
		  }
		  v7 = 0;
		  if ( !root )
		    goto LABEL_26;
		  while ( 1 )
		  {
		    polygons = root->fields.polygons;
		    if ( !polygons )
		      goto LABEL_26;
		    if ( v7 >= polygons->fields._size )
		      break;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             (List_1_System_Object_ *)root->fields.polygons,
		             v7,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::get_Item);
		    v10 = 0;
		    if ( !Item )
		      goto LABEL_26;
		    while ( 1 )
		    {
		      klass = Item[2].klass;
		      if ( !klass )
		        goto LABEL_26;
		      if ( v10 >= SLODWORD(klass->_0.namespaze) )
		        break;
		      vertices = (Vector3__Array *)Item[2].klass;
		      if ( (unsigned int)v10 >= LODWORD(klass->_0.namespaze) )
		        goto LABEL_20;
		      v12 = *((_QWORD *)&vertices->vector[0].x + v10);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
		      v5 = Item[2].klass;
		      vertices = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->vertices;
		      if ( !v5 )
		        goto LABEL_26;
		      if ( (unsigned int)v10 >= LODWORD(v5->_0.namespaze) )
		        goto LABEL_20;
		      v13 = *((_QWORD *)&v5->_0.byval_arg.data.dummy + v10);
		      if ( !v13 )
		        goto LABEL_26;
		      if ( !vertices )
		        goto LABEL_26;
		      sub_180049C60(vertices, &v30, *(int *)(v13 + 48));
		      v31 = v30;
		      v14 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v35, matrix, &v31, 0LL);
		      vertices = (Vector3__Array *)LODWORD(v14->z);
		      if ( !v12 )
		        goto LABEL_26;
		      *(_QWORD *)(v12 + 16) = *(_QWORD *)&v14->x;
		      *(_DWORD *)(v12 + 24) = (_DWORD)vertices;
		      vertices = (Vector3__Array *)Item[2].klass;
		      if ( !vertices )
		        goto LABEL_26;
		      if ( (unsigned int)v10 >= vertices->max_length.size )
		LABEL_20:
		        sub_1800D2AB0(vertices, v5);
		      v5 = Item[2].klass;
		      v15 = *((_QWORD *)&vertices->vector[0].x + v10);
		      vertices = TypeInfo::HG::Rendering::Runtime::CSG::BSP->static_fields->normals;
		      v16 = *((_QWORD *)&v5->_0.byval_arg.data.dummy + v10);
		      if ( !v16 || !vertices )
		        goto LABEL_26;
		      sub_180049C60(vertices, &v32, *(int *)(v16 + 48));
		      v33 = v32;
		      v17 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v36, matrix, &v33, 0LL);
		      ++v10;
		      vertices = (Vector3__Array *)LODWORD(v17->z);
		      *(_QWORD *)(v15 + 28) = *(_QWORD *)&v17->x;
		      *(_DWORD *)(v15 + 36) = (_DWORD)vertices;
		    }
		    ++v7;
		  }
		  if ( root->fields.front )
		  {
		    front = root->fields.front;
		    v19 = *(_OWORD *)&matrix->m01;
		    *(_OWORD *)&v34.m00 = *(_OWORD *)&matrix->m00;
		    v20 = *(_OWORD *)&matrix->m02;
		    *(_OWORD *)&v34.m01 = v19;
		    v21 = *(_OWORD *)&matrix->m03;
		    *(_OWORD *)&v34.m02 = v20;
		    *(_OWORD *)&v34.m03 = v21;
		    HG::Rendering::Runtime::CSG::Node::transformAllPolygons(front, &v34, 0LL);
		  }
		  if ( root->fields.back )
		  {
		    back = root->fields.back;
		    v23 = *(_OWORD *)&matrix->m01;
		    *(_OWORD *)&v34.m00 = *(_OWORD *)&matrix->m00;
		    v24 = *(_OWORD *)&matrix->m02;
		    *(_OWORD *)&v34.m01 = v23;
		    v25 = *(_OWORD *)&matrix->m03;
		    *(_OWORD *)&v34.m02 = v24;
		    *(_OWORD *)&v34.m03 = v25;
		    HG::Rendering::Runtime::CSG::Node::transformAllPolygons(back, &v34, 0LL);
		  }
		}
		
		public void Invert() {} // 0x0000000189C7B874-0x0000000189C7BA50
		// Void Invert()
		void HG::Rendering::Runtime::CSG::Node::Invert(Node_2 *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t i; // ebx
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons; // rax
		  List_1_System_Object_ *v7; // rsi
		  Object *Item; // rax
		  Object *v9; // rax
		  MethodInfo *v10; // r8
		  Vector3 *v11; // rax
		  __int64 v12; // xmm6_8
		  float z; // ebx
		  float v14; // xmm2_4
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v15; // rdx
		  VolumetricRenderer_VolumetricBounds *v16; // r8
		  __m128i v17; // xmm1
		  Int32__Array **front; // r9
		  Node_2 *v19; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rdx
		  VolumetricRenderer_VolumetricBounds *v21; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _BYTE v23[20]; // [rsp+20h] [rbp-40h] BYREF
		  int32_t v24; // [rsp+38h] [rbp-28h]
		  Plane v25; // [rsp+40h] [rbp-20h] BYREF
		  bool v26; // [rsp+50h] [rbp-10h]
		  bool v27; // [rsp+58h] [rbp-8h]
		  MethodInfo *vars0; // [rsp+60h] [rbp+0h]
		
		  *(_QWORD *)&v25.m_Normal.x = 0LL;
		  v25.m_Normal.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5274, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5274, 0LL);
		    if ( !Patch )
		LABEL_14:
		      sub_1800D8260(v4, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.splitPlane.hasValue )
		  {
		    for ( i = 0; ; ++i )
		    {
		      polygons = this->fields.polygons;
		      if ( !polygons )
		        goto LABEL_14;
		      if ( i >= polygons->fields._size )
		        break;
		      v7 = (List_1_System_Object_ *)this->fields.polygons;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               v7,
		               i,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::get_Item);
		      if ( !Item )
		        goto LABEL_14;
		      v9 = (Object *)HG::Rendering::Runtime::CSG::CSGPolygon::Flip((CSGPolygon *)Item, 0LL);
		      System::Collections::Generic::List<System::Object>::set_Item(
		        v7,
		        i,
		        v9,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::set_Item);
		    }
		    System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		      (SDKUtils_AudioParam *)&v25,
		      (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		      MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		    *(_QWORD *)v23 = _mm_unpacklo_ps((__m128)v25, _mm_shuffle_ps((__m128)v25, (__m128)v25, 85)).m128_u64[0];
		    *(_DWORD *)&v23[8] = _mm_shuffle_ps((__m128)v25, (__m128)v25, 170).m128_u32[0];
		    v11 = UnityEngine::Vector3::op_UnaryNegation(&v25.m_Normal, (Vector3 *)v23, v10);
		    v12 = *(_QWORD *)&v11->x;
		    z = v11->z;
		    System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		      (SDKUtils_AudioParam *)&v25,
		      (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		      MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		    v14 = -_mm_shuffle_ps((__m128)v25, (__m128)v25, 255).m128_f32[0];
		    *(_QWORD *)v23 = v12;
		    *(float *)&v23[8] = z;
		    v25 = 0LL;
		    UnityEngine::Plane::Plane(&v25, (Vector3 *)v23, v14, 0LL);
		    *(_WORD *)&v23[1] = 0;
		    v23[3] = 0;
		    *(Plane *)&v23[4] = v25;
		    v23[0] = 1;
		    v17 = _mm_srli_si128((__m128i)v25, 12);
		    *(_OWORD *)&this->fields.splitPlane.hasValue = *(_OWORD *)v23;
		    LODWORD(this->fields.splitPlane.value.m_Distance) = _mm_cvtsi128_si32(v17);
		    if ( this->fields.front )
		      HG::Rendering::Runtime::CSG::Node::Invert(this->fields.front, 0LL);
		    if ( this->fields.back )
		      HG::Rendering::Runtime::CSG::Node::Invert(this->fields.back, 0LL);
		    front = (Int32__Array **)this->fields.front;
		    this->fields.front = this->fields.back;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&this->fields.front,
		      v15,
		      v16,
		      front,
		      *(MethodInfo **)v23,
		      *(MethodInfo **)&v23[8],
		      *(int32_t *)&v23[16],
		      v24,
		      v25.m_Normal.x,
		      SLODWORD(v25.m_Normal.z),
		      v26,
		      v27,
		      vars0);
		    this->fields.back = v19;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&this->fields.back,
		      v20,
		      v21,
		      (Int32__Array **)v19,
		      *(MethodInfo **)v23,
		      *(MethodInfo **)&v23[8],
		      *(int32_t *)&v23[16],
		      v24,
		      v25.m_Normal.x,
		      SLODWORD(v25.m_Normal.z),
		      v26,
		      v27,
		      vars0);
		  }
		}
		
		public IEnumerable<CSGPolygon> ClipPolygons(IList<CSGPolygon> polygons) => default; // 0x0000000189C7B410-0x0000000189C7B5F4
		// IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon] ClipPolygons(IList`1[HG.Rendering.Runtime.CSG.CSGPolygon])
		IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *HG::Rendering::Runtime::CSG::Node::ClipPolygons(
		        Node_2 *this,
		        IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v5; // rax
		  __int64 v6; // rdx
		  Node_2 *back; // rcx
		  List_1_System_Object_ *v8; // rbp
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v9; // rax
		  List_1_System_Object_ *v10; // rsi
		  int v11; // r15d
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  CSGPolygon *v14; // rbx
		  IEnumerable_1_System_Object_ *v15; // rax
		  IEnumerable_1_System_Object_ *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Plane v19; // [rsp+40h] [rbp-38h] BYREF
		  Plane v20; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5263, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5263, 0LL);
		    if ( !Patch )
		      goto LABEL_17;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1528(Patch, (Object *)this, (Object *)polygons, 0LL);
		  }
		  else
		  {
		    if ( this->fields.splitPlane.hasValue )
		    {
		      v5 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		      v8 = (List_1_System_Object_ *)v5;
		      if ( v5 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v5,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		        v9 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		        v10 = (List_1_System_Object_ *)v9;
		        if ( v9 )
		        {
		          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		            v9,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		          v11 = 0;
		          if ( polygons )
		          {
		            while ( v11 < (int)sub_1800320D0(
		                                 0LL,
		                                 TypeInfo::System::Collections::Generic::ICollection<HG::Rendering::Runtime::CSG::CSGPolygon>,
		                                 polygons) )
		            {
		              System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		                (SDKUtils_AudioParam *)&v19,
		                (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		                MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		              v14 = (CSGPolygon *)sub_1808B3994(v13, v12, polygons, (unsigned int)v11);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		              v20 = v19;
		              HG::Rendering::Runtime::CSG::Extensions::SplitPolygon(
		                &v20,
		                v14,
		                (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v8,
		                (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v10,
		                (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v8,
		                (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v10,
		                0LL);
		              ++v11;
		            }
		            if ( this->fields.front )
		            {
		              v15 = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::CSG::Node::ClipPolygons(
		                                                      this->fields.front,
		                                                      (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v8,
		                                                      0LL);
		              v8 = System::Linq::Enumerable::ToList<System::Object>(
		                     v15,
		                     MethodInfo::System::Linq::Enumerable::ToList<HG::Rendering::Runtime::CSG::CSGPolygon>);
		            }
		            if ( !this->fields.back )
		            {
		              sub_183127A90(
		                v10,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::Clear);
		              return (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)System::Linq::Enumerable::Concat<System::Object>(
		                                                                             (IEnumerable_1_System_Object_ *)v8,
		                                                                             (IEnumerable_1_System_Object_ *)v10,
		                                                                             MethodInfo::System::Linq::Enumerable::Concat<HG::Rendering::Runtime::CSG::CSGPolygon>);
		            }
		            back = this->fields.back;
		            if ( back )
		            {
		              v16 = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::CSG::Node::ClipPolygons(
		                                                      back,
		                                                      (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v10,
		                                                      0LL);
		              v10 = System::Linq::Enumerable::ToList<System::Object>(
		                      v16,
		                      MethodInfo::System::Linq::Enumerable::ToList<HG::Rendering::Runtime::CSG::CSGPolygon>);
		              return (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)System::Linq::Enumerable::Concat<System::Object>(
		                                                                             (IEnumerable_1_System_Object_ *)v8,
		                                                                             (IEnumerable_1_System_Object_ *)v10,
		                                                                             MethodInfo::System::Linq::Enumerable::Concat<HG::Rendering::Runtime::CSG::CSGPolygon>);
		            }
		          }
		        }
		      }
		LABEL_17:
		      sub_1800D8260(back, v6);
		    }
		    return (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)System::Linq::Enumerable::ToArray<System::Object>(
		                                                                   (IEnumerable_1_System_Object_ *)polygons,
		                                                                   MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::CSG::CSGPolygon>);
		  }
		}
		
		public void ClipTo(Node other) {} // 0x0000000189C7B5F4-0x0000000189C7B69C
		private static CSGPolygon SelectSplitPlane(IEnumerable<CSGPolygon> polygons) => default; // 0x0000000189C7C59C-0x0000000189C7C6E4
		[IDTag(0)]
		private static void Build(Node node, IEnumerable<CSGPolygon> polygons, Queue<KeyValuePair<Node, IEnumerable<CSGPolygon>>> todo) {} // 0x0000000189C7AF58-0x0000000189C7B410
		// Void Build(Node, IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon], Queue`1[KeyValuePair`2[HG.Rendering.Runtime.CSG.Node,IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon]]])
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CSG::Node::Build(
		        Node_2 *node,
		        IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons,
		        Queue_1_KeyValuePair_2_HG_Rendering_Runtime_CSG_Node_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *todo,
		        MethodInfo *method)
		{
		  Queue_1_KeyValuePair_2_HG_Rendering_Runtime_CSG_Node_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v4; // r12
		  Node_2 *v6; // rdi
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  CSGPolygon *v9; // rax
		  __m128i v10; // xmm6
		  int32_t v11; // r15d
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // r14
		  int32_t v16; // r13d
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v20; // r15
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v27; // rsi
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  Node_2 *v30; // rax
		  Node_2 *v31; // rsi
		  unsigned __int64 v32; // r8
		  signed __int64 v33; // rtt
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  Node_2 *v36; // rax
		  Node_2 *v37; // r14
		  unsigned __int64 v38; // r8
		  signed __int64 v39; // rtt
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  StructMultiKey_2_System_Object_System_Object_ v45; // [rsp+40h] [rbp-A8h] BYREF
		  _BYTE v46[20]; // [rsp+50h] [rbp-98h] BYREF
		  __int64 v47; // [rsp+70h] [rbp-78h] BYREF
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v48; // [rsp+78h] [rbp-70h]
		  CSGPolygon *v49; // [rsp+80h] [rbp-68h]
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v50; // [rsp+88h] [rbp-60h]
		  Il2CppExceptionWrapper *v51; // [rsp+90h] [rbp-58h] BYREF
		  SDKUtils_AudioParam v52; // [rsp+98h] [rbp-50h] BYREF
		
		  v4 = todo;
		  v6 = node;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5289, 0LL) )
		  {
		    if ( !v6 )
		      sub_1800D8260(v8, v7);
		    if ( !v6->fields.splitPlane.hasValue )
		    {
		      v9 = HG::Rendering::Runtime::CSG::Node::SelectSplitPlane(polygons, 0LL);
		      if ( !v9 )
		        return;
		      *(_DWORD *)v46 = 1;
		      v10 = _mm_loadu_si128((const __m128i *)&v9->fields);
		      *(__m128i *)&v46[4] = v10;
		      *(_OWORD *)&v6->fields.splitPlane.hasValue = *(_OWORD *)v46;
		      LODWORD(v6->fields.splitPlane.value.m_Distance) = _mm_cvtsi128_si32(_mm_srli_si128(v10, 12));
		    }
		    v11 = System::Linq::Enumerable::Count<System::Object>(
		            (IEnumerable_1_System_Object_ *)polygons,
		            MethodInfo::System::Linq::Enumerable::Count<HG::Rendering::Runtime::CSG::CSGPolygon>);
		    v12 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		    v15 = v12;
		    if ( !v12 )
		      sub_1800D8260(v14, v13);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v12,
		      v11,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		    v50 = v15;
		    v16 = System::Linq::Enumerable::Count<System::Object>(
		            (IEnumerable_1_System_Object_ *)polygons,
		            MethodInfo::System::Linq::Enumerable::Count<HG::Rendering::Runtime::CSG::CSGPolygon>);
		    v17 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
		    v20 = v17;
		    if ( !v17 )
		      sub_1800D8260(v19, v18);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v17,
		      v16,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
		    v48 = v20;
		    if ( !polygons )
		      sub_1800D8260(v22, v21);
		    v47 = sub_1800428A0(
		            0LL,
		            TypeInfo::System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>,
		            polygons);
		    v45.Value1 = 0LL;
		    v45.Value2 = (Object *)&v47;
		    try
		    {
		      while ( 1 )
		      {
		        if ( !v47 )
		          sub_1800D8250(v24, v23);
		        if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		          break;
		        if ( !v47 )
		          sub_1800D8250(v26, v25);
		        v49 = (CSGPolygon *)sub_1804C92E8();
		        System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		          &v52,
		          (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&v6->fields,
		          MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		        v27 = (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v6->fields.polygons;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		        *(SDKUtils_AudioParam *)v46 = v52;
		        HG::Rendering::Runtime::CSG::Extensions::SplitPolygon(
		          (Plane *)v46,
		          v49,
		          v27,
		          v27,
		          (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v15,
		          (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v20,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v51 )
		    {
		      v45.Value1 = (Object *)v51->ex;
		      sub_1801F6A10(&v45);
		      v4 = todo;
		      v6 = node;
		      v15 = v50;
		      v20 = v48;
		      goto LABEL_15;
		    }
		    sub_1801F6A10(&v45);
		LABEL_15:
		    if ( v15 )
		    {
		      if ( v15->fields._size > 0 )
		      {
		        if ( !v6 )
		          goto LABEL_46;
		        if ( !v6->fields.front )
		        {
		          v30 = (Node_2 *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::Node);
		          v31 = v30;
		          if ( !v30 )
		            goto LABEL_46;
		          HG::Rendering::Runtime::CSG::Node::Node(v30, 0LL);
		          v6->fields.front = v31;
		          if ( dword_18F35FD08 )
		          {
		            v32 = (((unsigned __int64)&v6->fields.front >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v32 + 36190]);
		            do
		              v33 = qword_18F0BCBA0[v32 + 36190];
		            while ( v33 != _InterlockedCompareExchange64(
		                             &qword_18F0BCBA0[v32 + 36190],
		                             v33 | (1LL << (((unsigned __int64)&v6->fields.front >> 12) & 0x3F)),
		                             v33) );
		          }
		        }
		        v45 = 0LL;
		        Newtonsoft::Json::Utilities::StructMultiKey<System::Object,System::Object>::StructMultiKey(
		          &v45,
		          (Object *)v6->fields.front,
		          (Object *)v15,
		          MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>::KeyValuePair);
		        if ( !v4 )
		          sub_1800D8250(v35, v34);
		        *(StructMultiKey_2_System_Object_System_Object_ *)v46 = v45;
		        System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>::Enqueue(
		          (Queue_1_KeyValuePair_2_System_Object_System_Object_ *)v4,
		          (KeyValuePair_2_System_Object_System_Object_ *)v46,
		          MethodInfo::System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>>::Enqueue);
		      }
		      if ( v20 )
		      {
		        if ( v20->fields._size <= 0 )
		          return;
		        if ( v6 )
		        {
		          if ( v6->fields.back )
		          {
		LABEL_33:
		            v45 = 0LL;
		            Newtonsoft::Json::Utilities::StructMultiKey<System::Object,System::Object>::StructMultiKey(
		              &v45,
		              (Object *)v6->fields.back,
		              (Object *)v20,
		              MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>::KeyValuePair);
		            if ( !v4 )
		              sub_1800D8250(v41, v40);
		            *(StructMultiKey_2_System_Object_System_Object_ *)v46 = v45;
		            System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>::Enqueue(
		              (Queue_1_KeyValuePair_2_System_Object_System_Object_ *)v4,
		              (KeyValuePair_2_System_Object_System_Object_ *)v46,
		              MethodInfo::System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>>::Enqueue);
		            return;
		          }
		          v36 = (Node_2 *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::Node);
		          v37 = v36;
		          if ( v36 )
		          {
		            HG::Rendering::Runtime::CSG::Node::Node(v36, 0LL);
		            v6->fields.back = v37;
		            if ( dword_18F35FD08 )
		            {
		              v38 = (((unsigned __int64)&v6->fields.back >> 12) & 0x1FFFFF) >> 6;
		              _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		              do
		                v39 = qword_18F0BCBA0[v38 + 36190];
		              while ( v39 != _InterlockedCompareExchange64(
		                               &qword_18F0BCBA0[v38 + 36190],
		                               v39 | (1LL << (((unsigned __int64)&v6->fields.back >> 12) & 0x3F)),
		                               v39) );
		            }
		            goto LABEL_33;
		          }
		        }
		      }
		    }
		LABEL_46:
		    sub_1800D8250(v29, v28);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5289, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v44, v43);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)v6,
		    (Object *)polygons,
		    (Object *)v4,
		    0LL);
		}
		
		public static void splitter(object obj) {} // 0x0000000189C7C8A0-0x0000000189C7CA0C
		// Void splitter(Object)
		void HG::Rendering::Runtime::CSG::Node::splitter(Object *obj, MethodInfo *method)
		{
		  __int64 v3; // rax
		  Node_2 *node; // rdx
		  void *polys; // rcx
		  __int64 v6; // r14
		  int32_t i; // r15d
		  Object *Item; // r12
		  __int64 v9; // rbp
		  IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdi
		  IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v11; // rbx
		  IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v12; // rsi
		  IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v13; // rbp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Plane v15; // [rsp+40h] [rbp-38h] BYREF
		  Plane v16; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5445, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5445, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, obj, 0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(polys, node);
		  }
		  v3 = sub_180005050(obj, TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_10;
		  for ( i = *(_DWORD *)(v3 + 16); i < *(_DWORD *)(v6 + 20); ++i )
		  {
		    polys = TypeInfo::HG::Rendering::Runtime::CSG::Node;
		    node = TypeInfo::HG::Rendering::Runtime::CSG::Node->static_fields->node;
		    if ( !node )
		      goto LABEL_10;
		    System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		      (SDKUtils_AudioParam *)&v15,
		      (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&node->fields,
		      MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		    polys = TypeInfo::HG::Rendering::Runtime::CSG::Node->static_fields->polys;
		    if ( !polys )
		      goto LABEL_10;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             (List_1_System_Object_ *)polys,
		             i,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::get_Item);
		    polys = TypeInfo::HG::Rendering::Runtime::CSG::Node->static_fields;
		    v9 = *((_QWORD *)polys + 3);
		    if ( !v9 )
		      goto LABEL_10;
		    v10 = (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)*((_QWORD *)polys + 1);
		    v11 = (IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)*((_QWORD *)polys + 2);
		    v12 = *(IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ **)(*((_QWORD *)polys + 3) + 56LL);
		    v13 = *(IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ **)(v9 + 56);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    v16 = v15;
		    HG::Rendering::Runtime::CSG::Extensions::SplitPolygon(&v16, (CSGPolygon *)Item, v13, v12, v10, v11, 0LL);
		  }
		}
		
		[IDTag(1)]
		public void Build(IEnumerable<CSGPolygon> polygons) {} // 0x0000000189C7AE60-0x0000000189C7AF58
		// Void Build(IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon])
		void HG::Rendering::Runtime::CSG::Node::Build(
		        Node_2 *this,
		        IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons,
		        MethodInfo *method)
		{
		  Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Queue_1_KeyValuePair_2_System_Object_System_Object_ *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  StructMultiKey_2_System_Object_System_Object_ v12; // [rsp+20h] [rbp-28h] BYREF
		  Node_2 *node[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5288, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5288, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)polygons,
		      0LL);
		  }
		  else
		  {
		    v5 = (Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>>);
		    v8 = (Queue_1_KeyValuePair_2_System_Object_System_Object_ *)v5;
		    if ( !v5 )
		      sub_1800D8260(v7, v6);
		    System::Collections::Generic::Stack<System::Dynamic::BindingRestrictions_TestBuilder::AndNode>::Stack(
		      v5,
		      100,
		      MethodInfo::System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>>::Queue);
		    v12 = 0LL;
		    Newtonsoft::Json::Utilities::StructMultiKey<System::Object,System::Object>::StructMultiKey(
		      &v12,
		      (Object *)this,
		      (Object *)polygons,
		      MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>::KeyValuePair);
		    *(StructMultiKey_2_System_Object_System_Object_ *)node = v12;
		    sub_1808B3A38(v8, node);
		    while ( v8->fields._size > 0 )
		    {
		      System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>::Dequeue(
		        (KeyValuePair_2_System_Object_System_Object_ *)node,
		        v8,
		        MethodInfo::System::Collections::Generic::Queue<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::CSG::Node,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGPolygon>>>::Dequeue);
		      HG::Rendering::Runtime::CSG::Node::Build(
		        node[0],
		        (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)node[1],
		        (Queue_1_KeyValuePair_2_HG_Rendering_Runtime_CSG_Node_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v8,
		        0LL);
		    }
		  }
		}
		
		public Node Clone() => default; // 0x0000000189C7B69C-0x0000000189C7B874
		// Node Clone()
		Node_2 *HG::Rendering::Runtime::CSG::Node::Clone(Node_2 *this, MethodInfo *method)
		{
		  Node_2 *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Node_2 *v6; // rbx
		  __m128i v7; // xmm1
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  VolumetricRenderer_VolumetricBounds *v9; // r8
		  Int32__Array **v10; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v11; // rdx
		  VolumetricRenderer_VolumetricBounds *v12; // r8
		  Int32__Array **v13; // r9
		  List_1_System_Object_ *polygons; // rsi
		  IEnumerable_1_System_Object_ *v15; // rbp
		  Func_2_HG_Rendering_Runtime_CSG_CSGPolygon_HG_Rendering_Runtime_CSG_CSGPolygon_ *_9__20_0; // rdi
		  Object *v17; // r14
		  Func_2_Object_Object_ *v18; // rax
		  Node_c_1__StaticFields *static_fields; // r8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rdx
		  Int32__Array **v21; // r9
		  IEnumerable_1_System_Object_ *v22; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v25; // [rsp+20h] [rbp-48h] BYREF
		  _BYTE v26[20]; // [rsp+30h] [rbp-38h]
		  int32_t v27; // [rsp+48h] [rbp-20h]
		  bool v28; // [rsp+50h] [rbp-18h]
		  bool v29; // [rsp+58h] [rbp-10h]
		  MethodInfo *v30; // [rsp+60h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5254, 0LL) )
		  {
		    v3 = (Node_2 *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::Node);
		    v6 = v3;
		    if ( !v3 )
		      goto LABEL_15;
		    HG::Rendering::Runtime::CSG::Node::Node(v3, 0LL);
		    if ( this->fields.splitPlane.hasValue )
		    {
		      System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		        (SDKUtils_AudioParam *)&v25,
		        (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		        MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		      *(_WORD *)&v26[1] = 0;
		      v26[3] = 0;
		      *(__m128i *)&v26[4] = v25;
		      v26[0] = 1;
		      v7 = _mm_srli_si128(v25, 12);
		      *(_OWORD *)&v6->fields.splitPlane.hasValue = *(_OWORD *)v26;
		      LODWORD(v6->fields.splitPlane.value.m_Distance) = _mm_cvtsi128_si32(v7);
		    }
		    if ( this->fields.front )
		    {
		      v6->fields.front = HG::Rendering::Runtime::CSG::Node::Clone(this->fields.front, 0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&v6->fields.front,
		        v8,
		        v9,
		        v10,
		        (MethodInfo *)v25.m128i_i64[0],
		        (MethodInfo *)v25.m128i_i64[1],
		        *(int32_t *)v26,
		        *(int32_t *)&v26[8],
		        *(float *)&v26[16],
		        v27,
		        v28,
		        v29,
		        v30);
		    }
		    if ( this->fields.back )
		    {
		      v6->fields.back = HG::Rendering::Runtime::CSG::Node::Clone(this->fields.back, 0LL);
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&v6->fields.back,
		        v11,
		        v12,
		        v13,
		        (MethodInfo *)v25.m128i_i64[0],
		        (MethodInfo *)v25.m128i_i64[1],
		        *(int32_t *)v26,
		        *(int32_t *)&v26[8],
		        *(float *)&v26[16],
		        v27,
		        v28,
		        v29,
		        v30);
		    }
		    polygons = (List_1_System_Object_ *)v6->fields.polygons;
		    v15 = (IEnumerable_1_System_Object_ *)this->fields.polygons;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		    _9__20_0 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__20_0;
		    if ( !_9__20_0 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		      v17 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9;
		      v18 = (Func_2_Object_Object_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
		      _9__20_0 = (Func_2_HG_Rendering_Runtime_CSG_CSGPolygon_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v18;
		      if ( !v18 )
		        goto LABEL_15;
		      System::Func<System::Object,System::Object>::Func(
		        v18,
		        v17,
		        MethodInfo::HG::Rendering::Runtime::CSG::Node::__c::_Clone_b__20_0,
		        0LL);
		      static_fields = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields;
		      static_fields->__9__20_0 = _9__20_0;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__20_0,
		        v20,
		        (VolumetricRenderer_VolumetricBounds *)static_fields,
		        v21,
		        (MethodInfo *)v25.m128i_i64[0],
		        (MethodInfo *)v25.m128i_i64[1],
		        *(int32_t *)v26,
		        *(int32_t *)&v26[8],
		        *(float *)&v26[16],
		        v27,
		        v28,
		        v29,
		        v30);
		    }
		    v22 = System::Linq::Enumerable::Select<System::Object,System::Object>(
		            v15,
		            (Func_2_Object_Object_ *)_9__20_0,
		            MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
		    if ( polygons )
		    {
		      System::Collections::Generic::List<System::Object>::AddRange(
		        polygons,
		        v22,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::AddRange);
		      return v6;
		    }
		LABEL_15:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5254, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1521(Patch, (Object *)this, 0LL);
		}
		
		private float? RayCastNode(Node n, Ray r) => default; // 0x0000000189C7BFE8-0x0000000189C7C0A0
		// Nullable`1[Single] RayCastNode(Node, Ray)
		Nullable_1_Single_ HG::Rendering::Runtime::CSG::Node::RayCastNode(Node_2 *this, Node_2 *n, Ray *r, MethodInfo *method)
		{
		  Nullable_1_Single_ v7; // rbx
		  __int64 v8; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // xmm1_8
		  Ray v14; // [rsp+30h] [rbp-28h] BYREF
		
		  v7 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5433, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5433, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v13 = *(_QWORD *)&r->m_Direction.y;
		    *(_OWORD *)&v14.m_Origin.x = *(_OWORD *)&r->m_Origin.x;
		    *(_QWORD *)&v14.m_Direction.y = v13;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1569(Patch, (Object *)this, (Object *)n, &v14, 0LL);
		  }
		  else
		  {
		    if ( n )
		    {
		      v8 = *(_QWORD *)&r->m_Direction.y;
		      *(_OWORD *)&v14.m_Origin.x = *(_OWORD *)&r->m_Origin.x;
		      *(_QWORD *)&v14.m_Direction.y = v8;
		      return HG::Rendering::Runtime::CSG::Node::RayCast(n, &v14, 0LL);
		    }
		    return v7;
		  }
		}
		
		private bool RayCastItems(List<CSGPolygon> polygons, Vector3 planeIntersectionPoint) => default; // 0x0000000189C7BA50-0x0000000189C7BFE8
		// Boolean RayCastItems(List`1[HG.Rendering.Runtime.CSG.CSGPolygon], Vector3)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		bool HG::Rendering::Runtime::CSG::Node::RayCastItems(
		        Node_2 *this,
		        List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons,
		        Vector3 *planeIntersectionPoint,
		        MethodInfo *method)
		{
		  float v7; // xmm7_4
		  float v8; // xmm6_4
		  float v9; // xmm0_4
		  __int64 v10; // rdx
		  struct Node_c_1__Class *v11; // rcx
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *_9__22_2; // rbx
		  Object *v13; // rsi
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v17; // rdx
		  VolumetricRenderer_VolumetricBounds *v18; // r8
		  Int32__Array **v19; // r9
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ **p__9__22_2; // rcx
		  Object *v21; // rsi
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  Object *v25; // rsi
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  __int64 v31; // r8
		  Object *current; // rsi
		  unsigned int v33; // edi
		  Object__Class *klass; // rax
		  __int64 v35; // rcx
		  float v36; // xmm2_4
		  __m128 v37; // xmm1
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int64 v40; // rax
		  Object__Class *v41; // r8
		  __int64 v42; // rdx
		  __int64 v43; // rax
		  float v44; // xmm2_4
		  __m128 v45; // xmm1
		  __m128 v46; // xmm0
		  MethodInfo *v47; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  MethodInfo *v52; // [rsp+20h] [rbp-E8h]
		  MethodInfo *v53; // [rsp+28h] [rbp-E0h]
		  List_1_T_Enumerator_System_Object_ v54; // [rsp+30h] [rbp-D8h] BYREF
		  int32_t v55; // [rsp+48h] [rbp-C0h]
		  Vector3 v56; // [rsp+50h] [rbp-B8h] BYREF
		  MethodInfo *v57; // [rsp+60h] [rbp-A8h]
		  __int64 v58; // [rsp+68h] [rbp-A0h]
		  __int64 v59; // [rsp+70h] [rbp-98h]
		  __int64 v60; // [rsp+80h] [rbp-88h]
		  Vector3 v61; // [rsp+90h] [rbp-78h] BYREF
		  float v62[4]; // [rsp+A0h] [rbp-68h]
		  float v63[4]; // [rsp+B0h] [rbp-58h]
		  List_1_T_Enumerator_System_Object_ v64; // [rsp+C0h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5434, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5434, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v50, v49);
		    v56 = *planeIntersectionPoint;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1570(Patch, (Object *)this, (Object *)polygons, &v56, 0LL);
		  }
		  System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		    (SDKUtils_AudioParam *)&v54,
		    (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		    MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		  sub_1800036A0(TypeInfo::System::Math);
		  v7 = fabs(*(float *)&v54._list);
		  System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		    (SDKUtils_AudioParam *)&v54,
		    (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		    MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		  v8 = fabs(*((float *)&v54._list + 1));
		  System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		    (SDKUtils_AudioParam *)&v54,
		    (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		    MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		  v9 = fabs(*(float *)&v54._index);
		  if ( v7 <= v8 || v7 <= v9 )
		  {
		    if ( v8 <= v7 || v8 <= v9 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		      v11 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c;
		      _9__22_2 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_2;
		      if ( _9__22_2 )
		        goto LABEL_16;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		      v25 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9;
		      v26 = (Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *)sub_18002C620(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector2>);
		      _9__22_2 = v26;
		      if ( !v26 )
		        sub_1800D8260(v28, v27);
		      System::Func<UnityEngine::Vector3,UnityEngine::Vector2>::Func(
		        v26,
		        v25,
		        MethodInfo::HG::Rendering::Runtime::CSG::Node::__c::_RayCastItems_b__22_2,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_2 = _9__22_2;
		      p__9__22_2 = &TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_2;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		      v11 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c;
		      _9__22_2 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_1;
		      if ( _9__22_2 )
		        goto LABEL_16;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		      v21 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9;
		      v22 = (Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *)sub_18002C620(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector2>);
		      _9__22_2 = v22;
		      if ( !v22 )
		        sub_1800D8260(v24, v23);
		      System::Func<UnityEngine::Vector3,UnityEngine::Vector2>::Func(
		        v22,
		        v21,
		        MethodInfo::HG::Rendering::Runtime::CSG::Node::__c::_RayCastItems_b__22_1,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_1 = _9__22_2;
		      p__9__22_2 = &TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_1;
		    }
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		    v11 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c;
		    _9__22_2 = TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_0;
		    if ( _9__22_2 )
		      goto LABEL_16;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Node::__c);
		    v13 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9;
		    v14 = (Func_2_UnityEngine_Vector3_UnityEngine_Vector2_ *)sub_18002C620(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector2>);
		    _9__22_2 = v14;
		    if ( !v14 )
		      sub_1800D8260(v16, v15);
		    System::Func<UnityEngine::Vector3,UnityEngine::Vector2>::Func(
		      v14,
		      v13,
		      MethodInfo::HG::Rendering::Runtime::CSG::Node::__c::_RayCastItems_b__22_0,
		      0LL);
		    TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_0 = _9__22_2;
		    p__9__22_2 = &TypeInfo::HG::Rendering::Runtime::CSG::Node::__c->static_fields->__9__22_0;
		  }
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)p__9__22_2,
		    v17,
		    v18,
		    v19,
		    v52,
		    v53,
		    (int32_t)v54._list,
		    v54._index,
		    *(float *)&v54._current,
		    v55,
		    SLOBYTE(v56.x),
		    SLOBYTE(v56.z),
		    v57);
		LABEL_16:
		  if ( !polygons )
		    sub_1800D8260(v11, v10);
		  System::Collections::Generic::List<unsigned long>::GetEnumerator(
		    (List_1_T_Enumerator_System_UInt64_ *)&v54,
		    (List_1_System_UInt64_ *)polygons,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::GetEnumerator);
		  v64 = v54;
		  v54._list = 0LL;
		  *(_QWORD *)&v54._index = &v64;
		LABEL_18:
		  if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		          &v64,
		          MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::CSG::CSGPolygon>::MoveNext) )
		    return 0;
		  current = v64._current;
		  v33 = 0;
		  if ( !v64._current )
		    sub_1800D8250(v30, v29);
		  while ( 1 )
		  {
		    klass = current[2].klass;
		    if ( !klass )
		      sub_1800D8250(v30, v29);
		    if ( (signed int)v33 >= SLODWORD(klass->_0.namespaze) )
		      return 1;
		    if ( v33 >= LODWORD(klass->_0.namespaze) )
		      sub_1800D2AA0((int)v33, v29, v31);
		    v35 = *((_QWORD *)&klass->_0.byval_arg.data.dummy + (int)v33);
		    if ( !v35 )
		      sub_1800D8250(0LL, v29);
		    v60 = *(_QWORD *)&planeIntersectionPoint->x;
		    v59 = *(_QWORD *)(v35 + 16);
		    v36 = *(float *)(v35 + 24) - planeIntersectionPoint->z;
		    v37 = (__m128)HIDWORD(v59);
		    if ( !_9__22_2 )
		      sub_1800D8250(v35, v29);
		    v37.m128_f32[0] = *((float *)&v59 + 1) - *((float *)&v60 + 1);
		    *(_QWORD *)&v61.x = _mm_unpacklo_ps((__m128)(unsigned int)v59, v37).m128_u64[0];
		    v61.z = v36;
		    UnityEngine::Events::UnityAction<UnityEngine::Vector3>::Invoke(
		      (UnityAction_1_UnityEngine_Vector3_ *)_9__22_2,
		      &v61,
		      0LL);
		    v58 = v40;
		    v41 = current[2].klass;
		    if ( !v41 )
		      sub_1800D8250(v39, v38);
		    v42 = (unsigned int)((int)(v33 + 1) >> 31);
		    LODWORD(v42) = (int)(v33 + 1) % SLODWORD(v41->_0.namespaze);
		    if ( (unsigned int)v42 >= LODWORD(v41->_0.namespaze) )
		      sub_1800D2AA0(v39, v42, v41);
		    v43 = *((_QWORD *)&v41->_0.byval_arg.data.dummy + (int)v42);
		    if ( !v43 )
		      sub_1800D8250(v39, v42);
		    *(_QWORD *)v63 = *(_QWORD *)&planeIntersectionPoint->x;
		    *(_QWORD *)v62 = *(_QWORD *)(v43 + 16);
		    v44 = *(float *)(v43 + 24) - planeIntersectionPoint->z;
		    v45 = (__m128)LODWORD(v62[1]);
		    v45.m128_f32[0] = v62[1] - v63[1];
		    v46 = (__m128)LODWORD(v62[0]);
		    v46.m128_f32[0] = v62[0] - v63[0];
		    *(_QWORD *)&v56.x = _mm_unpacklo_ps(v46, v45).m128_u64[0];
		    v56.z = v44;
		    UnityEngine::Events::UnityAction<UnityEngine::Vector3>::Invoke(
		      (UnityAction_1_UnityEngine_Vector3_ *)_9__22_2,
		      &v56,
		      0LL);
		    v57 = v47;
		    if ( (float)((float)((float)-*(float *)&v58 * (float)(*(float *)&v47 - *(float *)&v58))
		               + (float)((float)(*((float *)&v47 + 1) - *((float *)&v58 + 1)) * (float)-*((float *)&v58 + 1))) <= 0.0 )
		      goto LABEL_18;
		    ++v33;
		  }
		}
		
		public float? RayCast(Ray r) => default; // 0x0000000189C7C0A0-0x0000000189C7C59C
		// Nullable`1[Single] RayCast(Ray)
		Nullable_1_Single_ HG::Rendering::Runtime::CSG::Node::RayCast(Node_2 *this, Ray *r, MethodInfo *method)
		{
		  float z; // eax
		  float v6; // xmm6_4
		  float v7; // eax
		  MethodInfo *v8; // r9
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  __int64 v11; // xmm3_8
		  MethodInfo *v12; // r9
		  Vector3 *v13; // rax
		  MethodInfo *v14; // r9
		  float v15; // r14d
		  __int64 v16; // xmm7_8
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v17; // rdx
		  __int64 v18; // xmm0_8
		  float v19; // eax
		  MethodInfo *v20; // r8
		  float v21; // xmm0_4
		  Nullable_1_Single_ result; // rax
		  Node_2 *front; // rbx
		  float v24; // eax
		  Ray *v25; // r8
		  Node_2 *v26; // rbx
		  float v27; // eax
		  Vector3 *v28; // rax
		  __int64 v29; // xmm3_8
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  __int64 v32; // xmm0_8
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v33; // rdx
		  __int64 v34; // xmm0_8
		  float v35; // eax
		  MethodInfo *v36; // r8
		  __int128 v37; // xmm0
		  Node_2 *v38; // rdx
		  Node_2 *back; // rdx
		  __int64 v40; // xmm1_8
		  List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons; // rdx
		  __int64 v42; // xmm0_8
		  float v43; // eax
		  MethodInfo *v44; // r8
		  float v45; // eax
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  __int64 v51; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  __int64 v55; // xmm1_8
		  Vector3 v56; // [rsp+28h] [rbp-39h] BYREF
		  Vector3 v57; // [rsp+38h] [rbp-29h] BYREF
		  Ray v58; // [rsp+48h] [rbp-19h] BYREF
		  Ray v59[2]; // [rsp+68h] [rbp+7h] BYREF
		  Nullable_1_Single_ v60; // [rsp+E0h] [rbp+7Fh]
		
		  *(_DWORD *)&v60.hasValue = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5432, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5432, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v54, v53);
		    v55 = *(_QWORD *)&r->m_Direction.y;
		    *(_OWORD *)&v59[0].m_Origin.x = *(_OWORD *)&r->m_Origin.x;
		    *(_QWORD *)&v59[0].m_Direction.y = v55;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1571(Patch, (Object *)this, v59, 0LL);
		  }
		  if ( !this->fields.splitPlane.hasValue )
		    return 0LL;
		  System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		    (SDKUtils_AudioParam *)&v58,
		    (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		    MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		  z = r->m_Origin.z;
		  *(_QWORD *)&v56.x = *(_QWORD *)&r->m_Origin.x;
		  v56.z = z;
		  v6 = HG::Rendering::Runtime::CSG::Extensions::Distance(&v56, (Plane *)&v58, 0LL);
		  v7 = r->m_Direction.z;
		  *(_QWORD *)&v56.x = *(_QWORD *)&r->m_Direction.x;
		  v56.z = v7;
		  v9 = UnityEngine::Vector3::op_Multiply(&v57, &v56, v6, v8);
		  v10 = *(_QWORD *)&r->m_Origin.x;
		  v11 = *(_QWORD *)&v9->x;
		  v56.z = v9->z;
		  v57.z = r->m_Origin.z;
		  *(_QWORD *)&v56.x = v11;
		  *(_QWORD *)&v57.x = v10;
		  v13 = UnityEngine::Vector3::op_Addition(&v58.m_Origin, &v57, &v56, v12);
		  v15 = v13->z;
		  v16 = *(_QWORD *)&v13->x;
		  if ( v6 < -0.001 )
		  {
		    back = this->fields.back;
		    v40 = *(_QWORD *)&r->m_Direction.y;
		    *(_OWORD *)&v59[0].m_Origin.x = *(_OWORD *)&r->m_Origin.x;
		    *(_QWORD *)&v59[0].m_Direction.y = v40;
		    result = HG::Rendering::Runtime::CSG::Node::RayCastNode(this, back, v59, 0LL);
		    if ( result.hasValue )
		      return result;
		    polygons = this->fields.polygons;
		    *(_QWORD *)&v57.x = v16;
		    v57.z = v15;
		    if ( !HG::Rendering::Runtime::CSG::Node::RayCastItems(this, polygons, &v57, 0LL) )
		    {
		      System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		        (SDKUtils_AudioParam *)&v58,
		        (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		        MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		      *(_QWORD *)&v57.x = *(_QWORD *)&v58.m_Origin.x;
		      v42 = *(_QWORD *)&r->m_Direction.x;
		      v57.z = v58.m_Origin.z;
		      v43 = r->m_Direction.z;
		      *(_QWORD *)&v56.x = v42;
		      v56.z = v43;
		      if ( UnityEngine::Vector3::Dot(&v56, &v57, v44) <= 0.0 )
		        return 0LL;
		      front = this->fields.front;
		      *(_QWORD *)&v57.x = *(_QWORD *)&r->m_Direction.x;
		      v57.z = v45;
		      v47 = UnityEngine::Vector3::op_Multiply(&v58.m_Origin, &v57, v6, v46);
		      *(_QWORD *)&v56.x = *(_QWORD *)&r->m_Origin.x;
		      v48 = *(_QWORD *)&v47->x;
		      v57.z = v47->z;
		      v56.z = r->m_Origin.z;
		      *(_QWORD *)&v57.x = v48;
		      v50 = UnityEngine::Vector3::op_Addition(&v58.m_Origin, &v56, &v57, v49);
		      *(_QWORD *)&v57.x = *(_QWORD *)&r->m_Direction.x;
		      v51 = *(_QWORD *)&v50->x;
		      *(float *)&v50 = v50->z;
		      v57.z = r->m_Direction.z;
		      memset(v59, 0, 24);
		      LODWORD(v56.z) = (_DWORD)v50;
		      *(_QWORD *)&v56.x = v51;
		      UnityEngine::Ray::Ray(v59, &v56, &v57, 0LL);
		      v25 = &v58;
		      v58 = v59[0];
		      goto LABEL_18;
		    }
		    goto LABEL_21;
		  }
		  if ( v6 > 0.001 )
		  {
		    v26 = this->fields.front;
		    v27 = r->m_Direction.z;
		    *(_QWORD *)&v57.x = *(_QWORD *)&r->m_Direction.x;
		    v57.z = v27;
		    v28 = UnityEngine::Vector3::op_Multiply(&v58.m_Origin, &v57, v6, v14);
		    *(_QWORD *)&v56.x = *(_QWORD *)&r->m_Origin.x;
		    v29 = *(_QWORD *)&v28->x;
		    v57.z = v28->z;
		    v56.z = r->m_Origin.z;
		    *(_QWORD *)&v57.x = v29;
		    v31 = UnityEngine::Vector3::op_Addition(&v58.m_Origin, &v56, &v57, v30);
		    *(_QWORD *)&v57.x = *(_QWORD *)&r->m_Direction.x;
		    v32 = *(_QWORD *)&v31->x;
		    *(float *)&v31 = v31->z;
		    v57.z = r->m_Direction.z;
		    memset(v59, 0, 24);
		    LODWORD(v56.z) = (_DWORD)v31;
		    *(_QWORD *)&v56.x = v32;
		    UnityEngine::Ray::Ray(v59, &v56, &v57, 0LL);
		    v58 = v59[0];
		    result = HG::Rendering::Runtime::CSG::Node::RayCastNode(this, v26, &v58, 0LL);
		    if ( result.hasValue )
		      return result;
		    v33 = this->fields.polygons;
		    *(_QWORD *)&v57.x = v16;
		    v57.z = v15;
		    if ( !HG::Rendering::Runtime::CSG::Node::RayCastItems(this, v33, &v57, 0LL) )
		    {
		      System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		        (SDKUtils_AudioParam *)&v58,
		        (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		        MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		      *(_QWORD *)&v57.x = *(_QWORD *)&v58.m_Origin.x;
		      v34 = *(_QWORD *)&r->m_Direction.x;
		      v57.z = v58.m_Origin.z;
		      v35 = r->m_Direction.z;
		      *(_QWORD *)&v56.x = v34;
		      v56.z = v35;
		      if ( UnityEngine::Vector3::Dot(&v56, &v57, v36) >= 0.0 )
		        return 0LL;
		LABEL_13:
		      v37 = *(_OWORD *)&r->m_Origin.x;
		      v38 = this->fields.back;
		      v25 = v59;
		      *(_QWORD *)&v59[0].m_Direction.y = *(_QWORD *)&r->m_Direction.y;
		      *(_OWORD *)&v59[0].m_Origin.x = v37;
		      goto LABEL_19;
		    }
		LABEL_21:
		    v60.value = v6;
		    v60.hasValue = 1;
		    return v60;
		  }
		  v17 = this->fields.polygons;
		  *(_QWORD *)&v57.x = *(_QWORD *)&v13->x;
		  v57.z = v15;
		  if ( HG::Rendering::Runtime::CSG::Node::RayCastItems(this, v17, &v57, 0LL) )
		    goto LABEL_21;
		  System::Nullable<Beyond::SDK::SDKUtils::AudioParam>::get_Value(
		    (SDKUtils_AudioParam *)&v58,
		    (Nullable_1_Beyond_SDK_SDKUtils_AudioParam_ *)&this->fields,
		    MethodInfo::System::Nullable<UnityEngine::Plane>::get_Value);
		  *(_QWORD *)&v57.x = *(_QWORD *)&v58.m_Origin.x;
		  v18 = *(_QWORD *)&r->m_Direction.x;
		  v57.z = v58.m_Origin.z;
		  v19 = r->m_Direction.z;
		  *(_QWORD *)&v56.x = v18;
		  v56.z = v19;
		  v21 = UnityEngine::Vector3::Dot(&v56, &v57, v20);
		  if ( v21 == 0.0 )
		    return 0LL;
		  if ( v21 <= 0.0 )
		    goto LABEL_13;
		  front = this->fields.front;
		  *(_QWORD *)&v56.x = v16;
		  v56.z = v15;
		  memset(&v58, 0, sizeof(v58));
		  v24 = r->m_Direction.z;
		  *(_QWORD *)&v57.x = *(_QWORD *)&r->m_Direction.x;
		  v57.z = v24;
		  UnityEngine::Ray::Ray(&v58, &v56, &v57, 0LL);
		  v25 = v59;
		  v59[0] = v58;
		LABEL_18:
		  v38 = front;
		LABEL_19:
		  result = HG::Rendering::Runtime::CSG::Node::RayCastNode(this, v38, v25, 0LL);
		  if ( !result.hasValue )
		    return 0LL;
		  return result;
		}
		
	}
}
