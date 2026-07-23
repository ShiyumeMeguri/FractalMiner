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
	public static class Extensions // TypeDefIndex: 38816
	{
		// Fields
		public const float EPSILON = 0.001f; // Metadata: 0x023044D9
		public const float Epsilon = 0.001f; // Metadata: 0x023044DD
		public static object lock1; // 0x00
		public static object lock2; // 0x08
		public static object lock3; // 0x10
		public static object lock4; // 0x18
	
		// Constructors
		static Extensions() {} // 0x0000000189C77DE8-0x0000000189C77EE4
	
		// Methods
		public static Quaternion QuaternionFromMatrix(Matrix4x4 m) => default; // 0x0000000189C76220-0x0000000189C76520
		// Quaternion QuaternionFromMatrix(Matrix4x4)
		Quaternion *HG::Rendering::Runtime::CSG::Extensions::QuaternionFromMatrix(
		        Quaternion *__return_ptr retstr,
		        Matrix4x4 *m,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float v9; // xmm9_4
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  float v12; // xmm8_4
		  float Item; // xmm7_4
		  float v14; // xmm6_4
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  float v17; // xmm7_4
		  float v18; // xmm0_4
		  float v19; // xmm6_4
		  MethodInfo *v20; // rdx
		  float v21; // xmm0_4
		  float v22; // xmm6_4
		  MethodInfo *v23; // rdx
		  float v24; // xmm6_4
		  float v25; // xmm0_4
		  MethodInfo *v26; // rdx
		  Quaternion v27; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  Quaternion *result; // rax
		  Quaternion v35; // [rsp+28h] [rbp-59h] BYREF
		  Matrix4x4 v36; // [rsp+38h] [rbp-49h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5421, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5421, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v30, v29);
		    v31 = *(_OWORD *)&m->m01;
		    *(_OWORD *)&v36.m00 = *(_OWORD *)&m->m00;
		    v32 = *(_OWORD *)&m->m02;
		    *(_OWORD *)&v36.m01 = v31;
		    v33 = *(_OWORD *)&m->m03;
		    *(_OWORD *)&v36.m02 = v32;
		    *(_OWORD *)&v36.m03 = v33;
		    v27 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1563(&v35, Patch, &v36, 0LL);
		  }
		  else
		  {
		    UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
		    UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
		    UnityEngine::Matrix4x4::get_Item(m, 10, 0LL);
		    v35.w = sub_1803386C0(v6, v5) * 0.5;
		    UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
		    UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
		    UnityEngine::Matrix4x4::get_Item(m, 10, 0LL);
		    v9 = sub_1803386C0(v8, v7) * 0.5;
		    UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
		    UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
		    UnityEngine::Matrix4x4::get_Item(m, 10, 0LL);
		    v12 = sub_1803386C0(v11, v10) * 0.5;
		    Item = UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
		    v14 = UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
		    fmaxf(0.0, UnityEngine::Matrix4x4::get_Item(m, 10, 0LL) + (float)((float)(1.0 - Item) - v14));
		    v17 = sub_1803386C0(v16, v15) * 0.5;
		    v18 = UnityEngine::Matrix4x4::get_Item(m, 6, 0LL);
		    v19 = (float)(v18 - UnityEngine::Matrix4x4::get_Item(m, 9, 0LL)) * v9;
		    v35.x = UnityEngine::Mathf::Sign(v19, v20) * v9;
		    v21 = UnityEngine::Matrix4x4::get_Item(m, 8, 0LL);
		    v22 = (float)(v21 - UnityEngine::Matrix4x4::get_Item(m, 2, 0LL)) * v12;
		    v35.y = UnityEngine::Mathf::Sign(v22, v23) * v12;
		    v24 = UnityEngine::Matrix4x4::get_Item(m, 1, 0LL);
		    v25 = UnityEngine::Matrix4x4::get_Item(m, 4, 0LL);
		    v35.z = UnityEngine::Mathf::Sign((float)(v24 - v25) * v17, v26) * v17;
		    v27 = v35;
		  }
		  result = retstr;
		  *retstr = v27;
		  return result;
		}
		
	
		// Extension methods
		public static void SplitPolygon(this Plane plane, CSGPolygon polygon, IList<CSGPolygon> coPlanarFront, IList<CSGPolygon> coPlanarBack, IList<CSGPolygon> front, IList<CSGPolygon> back) {} // 0x0000000189C76520-0x0000000189C77120
		// Void SplitPolygon(Plane, CSGPolygon, IList`1[HG.Rendering.Runtime.CSG.CSGPolygon], IList`1[HG.Rendering.Runtime.CSG.CSGPolygon], IList`1[HG.Rendering.Runtime.CSG.CSGPolygon], IList`1[HG.Rendering.Runtime.CSG.CSGPolygon])
		// Hidden C++ exception states: #wind=6
		void HG::Rendering::Runtime::CSG::Extensions::SplitPolygon(
		        Plane *plane,
		        CSGPolygon *polygon,
		        IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *coPlanarFront,
		        IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *coPlanarBack,
		        IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *front,
		        IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *back,
		        MethodInfo *method)
		{
		  Object *v7; // r12
		  Object *v8; // rbx
		  CSGPolygon *v9; // rsi
		  Plane *v10; // r13
		  CSGVertex *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  CSGVertex *v14; // r15
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  int v17; // r14d
		  Object *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  MethodInfo *v21; // r8
		  Int32Enum__Enum i; // ebx
		  CSGVertex__Array *Vertices; // rax
		  CSGVertex__Array *v24; // rcx
		  CSGVertex *v25; // r12
		  __int64 v26; // xmm6_8
		  float z; // ebx
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  float v30; // xmm0_4
		  __int64 v31; // rbx
		  int v32; // r14d
		  int v33; // r14d
		  __m128i v34; // xmm0
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v43; // rax
		  CSGVertex__Array *v44; // rdx
		  unsigned __int64 j; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v46; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v47; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v48; // r14
		  unsigned int v49; // r12d
		  CSGVertex__Array *v50; // rax
		  __int64 v51; // r8
		  CSGVertex__Array *v52; // rax
		  CSGVertex *v53; // rax
		  Int32Enum__Enum v54; // eax
		  float v55; // xmm7_4
		  Object *v56; // rbx
		  int32_t objID; // r12d
		  int32_t materialID; // r13d
		  CSGPolygon *v59; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  CSGPolygon *v62; // r15
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  int32_t v65; // r15d
		  int32_t v66; // esi
		  CSGPolygon *v67; // rax
		  __int64 v68; // rdx
		  __int64 v69; // rcx
		  CSGPolygon *v70; // rbx
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // r14
		  bool lockTaken; // [rsp+40h] [rbp-158h] BYREF
		  Object *obj; // [rsp+48h] [rbp-150h] BYREF
		  Int32Enum__Enum Item; // [rsp+50h] [rbp-148h]
		  Il2CppException *ex; // [rsp+60h] [rbp-138h] BYREF
		  Object v80; // [rsp+68h] [rbp-130h]
		  Object o1; // [rsp+80h] [rbp-118h] BYREF
		  Object v82; // [rsp+90h] [rbp-108h]
		  Vector3 m_Normal; // [rsp+A0h] [rbp-F8h] BYREF
		  Vector3 v84; // [rsp+B0h] [rbp-E8h] BYREF
		  int32_t index[2]; // [rsp+C0h] [rbp-D8h]
		  CSGVertex *v86; // [rsp+C8h] [rbp-D0h]
		  Int32Enum__Enum v87; // [rsp+D0h] [rbp-C8h]
		  __int64 v88; // [rsp+E0h] [rbp-B8h]
		  __int64 v89; // [rsp+F0h] [rbp-A8h]
		  __int64 v90; // [rsp+100h] [rbp-98h]
		  Il2CppExceptionWrapper *v91; // [rsp+110h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v92; // [rsp+118h] [rbp-80h] BYREF
		  Il2CppExceptionWrapper *v93; // [rsp+120h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v94; // [rsp+128h] [rbp-70h] BYREF
		  Il2CppExceptionWrapper *v95; // [rsp+130h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v96; // [rsp+138h] [rbp-60h] BYREF
		
		  v7 = (Object *)coPlanarBack;
		  v8 = (Object *)coPlanarFront;
		  v9 = polygon;
		  v10 = plane;
		  obj = 0LL;
		  lockTaken = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5264, 0LL) )
		  {
		    v11 = (CSGVertex *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>);
		    v14 = v11;
		    v86 = v11;
		    if ( !v11 )
		      sub_1800D8260(v13, v12);
		    System::Collections::Generic::List<Beyond::Gameplay::Core::PullComponent::PullAttenuationValueConfig>::List(
		      (List_1_Beyond_Gameplay_Core_PullComponent_PullAttenuationValueConfig_ *)v11,
		      10,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::List);
		    v17 = 0;
		    if ( !v9 )
		      sub_1800D8260(v16, v15);
		    o1 = (Object)v9->fields.Plane;
		    v18 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Plane, &o1);
		    o1.klass = (Object__Class *)TypeInfo::UnityEngine::Plane;
		    o1.monitor = (MonitorData *)-1LL;
		    v82 = (Object)*v10;
		    if ( System::ValueType::DefaultEquals(&o1, v18, 0LL) )
		    {
		      if ( !v14 )
		        sub_1800D8260(v20, v19);
		      sub_1836FCDC0(
		        v14,
		        0LL,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::Add);
		    }
		    else
		    {
		      for ( i = 0; ; i = Item + 1 )
		      {
		        Item = i;
		        Vertices = v9->fields.Vertices;
		        if ( !Vertices )
		          sub_1800D8260(v20, v19);
		        if ( (int)i >= Vertices->max_length.size )
		          break;
		        v24 = v9->fields.Vertices;
		        if ( i >= Vertices->max_length.size )
		          sub_1800D2AB0(v24, v19);
		        v25 = v24->vector[i];
		        if ( !v25 )
		          sub_1800D8260(v24, v19);
		        v26 = *(_QWORD *)&v25->fields.Position.x;
		        z = v25->fields.Position.z;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		        o1 = (Object)*v10;
		        *(_QWORD *)&v84.x = v26;
		        v84.z = z;
		        v30 = HG::Rendering::Runtime::CSG::Extensions::Distance(&v84, (Plane *)&o1, 0LL);
		        if ( v30 >= -0.001 )
		          v31 = v30 > 0.001;
		        else
		          LODWORD(v31) = 2;
		        v17 |= v31;
		        if ( !v14 )
		          sub_1800D8260(v29, v28);
		        sub_1836FCDC0(
		          v14,
		          (unsigned int)v31,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::Add);
		      }
		      v7 = (Object *)coPlanarBack;
		      if ( v17 )
		      {
		        v32 = v17 - 1;
		        if ( !v32 )
		          goto LABEL_31;
		        v33 = v32 - 1;
		        if ( !v33 )
		          goto LABEL_34;
		        if ( v33 == 1 )
		          goto LABEL_37;
		        return;
		      }
		      v8 = (Object *)coPlanarFront;
		    }
		    v34 = _mm_loadu_si128((const __m128i *)&v9->fields);
		    *(_QWORD *)&v84.x = v34.m128i_i64[0];
		    LODWORD(v84.z) = _mm_cvtsi128_si32(_mm_srli_si128(v34, 8));
		    m_Normal = v10->m_Normal;
		    if ( UnityEngine::Vector3::Dot(&m_Normal, &v84, v21) <= 0.0 )
		      goto LABEL_28;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions->static_fields->lock3;
		    o1.klass = (Object__Class *)&lockTaken;
		    o1.monitor = (MonitorData *)&obj;
		    ex = 0LL;
		    v80 = o1;
		    try
		    {
		      System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
		      if ( !v8 )
		        sub_1800D8250(v36, v35);
		      sub_1808B38EC(v36, v35, v8, v9);
		    }
		    catch ( Il2CppExceptionWrapper *v91 )
		    {
		      ex = v91->ex;
		      sub_1801F4710(&ex);
		      v7 = (Object *)coPlanarBack;
		      v9 = polygon;
		LABEL_28:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		      obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions->static_fields->lock4;
		      lockTaken = 0;
		      o1.klass = (Object__Class *)&lockTaken;
		      o1.monitor = (MonitorData *)&obj;
		      ex = 0LL;
		      v80 = o1;
		      try
		      {
		        System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
		        if ( !v7 )
		          sub_1800D8250(v38, v37);
		        sub_1808B38EC(v38, v37, v7, v9);
		      }
		      catch ( Il2CppExceptionWrapper *v92 )
		      {
		        ex = v92->ex;
		        sub_1801F4710(&ex);
		        v9 = polygon;
		LABEL_31:
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		        obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions->static_fields->lock1;
		        lockTaken = 0;
		        o1.klass = (Object__Class *)&lockTaken;
		        o1.monitor = (MonitorData *)&obj;
		        ex = 0LL;
		        v80 = o1;
		        try
		        {
		          System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
		          if ( !front )
		            sub_1800D8250(v40, v39);
		          sub_1808B38EC(v40, v39, front, v9);
		        }
		        catch ( Il2CppExceptionWrapper *v93 )
		        {
		          ex = v93->ex;
		          sub_1801F4710(&ex);
		          v9 = polygon;
		LABEL_34:
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		          obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions->static_fields->lock2;
		          lockTaken = 0;
		          o1.klass = (Object__Class *)&lockTaken;
		          o1.monitor = (MonitorData *)&obj;
		          ex = 0LL;
		          v80 = o1;
		          try
		          {
		            System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
		            if ( !back )
		              sub_1800D8250(v42, v41);
		            sub_1808B38EC(v42, v41, back, v9);
		          }
		          catch ( Il2CppExceptionWrapper *v94 )
		          {
		            ex = v94->ex;
		            sub_1801F4710(&ex);
		            v9 = polygon;
		            v10 = plane;
		            v14 = v86;
		LABEL_37:
		            v43 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
		            v46 = v43;
		            *(_QWORD *)&m_Normal.x = v43;
		            if ( !v43
		              || (System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		                    v43,
		                    10,
		                    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List),
		                  v47 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>),
		                  v48 = v47,
		                  (*(_QWORD *)&v84.x = v47) == 0LL) )
		            {
		LABEL_87:
		              sub_1800D8250(j, v44);
		            }
		            System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		              v47,
		              10,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
		            v49 = 0;
		            for ( j = 0LL; ; j = v49 )
		            {
		              v50 = v9->fields.Vertices;
		              if ( !v50 )
		                goto LABEL_87;
		              if ( (int)j >= v50->max_length.size )
		              {
		                if ( v46->fields._size >= 3
		                  && !HG::Rendering::Runtime::CSG::CSGPolygon::IsDegenerateSet(
		                        (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v46,
		                        0LL) )
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		                  obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions->static_fields->lock1;
		                  lockTaken = 0;
		                  o1.klass = (Object__Class *)&lockTaken;
		                  o1.monitor = (MonitorData *)&obj;
		                  ex = 0LL;
		                  v80 = o1;
		                  try
		                  {
		                    System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
		                    objID = v9->fields.objID;
		                    materialID = v9->fields.materialID;
		                    v59 = (CSGPolygon *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
		                    v62 = v59;
		                    if ( !v59 )
		                      sub_1800D8250(v61, v60);
		                    HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		                      v59,
		                      (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v46,
		                      objID,
		                      materialID,
		                      0LL);
		                    if ( !front )
		                      sub_1800D8250(v64, v63);
		                    sub_1808B38EC(v64, v63, front, v62);
		                  }
		                  catch ( Il2CppExceptionWrapper *v95 )
		                  {
		                    ex = v95->ex;
		                    sub_1801F4710(&ex);
		                    v9 = polygon;
		                    v48 = *(List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ **)&v84.x;
		                    goto LABEL_62;
		                  }
		                  sub_1801F4710(&ex);
		                }
		LABEL_62:
		                if ( v48->fields._size < 3 )
		                  return;
		                if ( HG::Rendering::Runtime::CSG::CSGPolygon::IsDegenerateSet(
		                       (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v48,
		                       0LL) )
		                {
		                  return;
		                }
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		                obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions->static_fields->lock2;
		                lockTaken = 0;
		                o1.klass = (Object__Class *)&lockTaken;
		                o1.monitor = (MonitorData *)&obj;
		                ex = 0LL;
		                v80 = o1;
		                try
		                {
		                  System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
		                  v65 = v9->fields.objID;
		                  v66 = v9->fields.materialID;
		                  v67 = (CSGPolygon *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
		                  v70 = v67;
		                  if ( !v67 )
		                    sub_1800D8250(v69, v68);
		                  HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		                    v67,
		                    (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v48,
		                    v65,
		                    v66,
		                    0LL);
		                  if ( !back )
		                    sub_1800D8250(v72, v71);
		                  sub_1808B38EC(v72, v71, back, v70);
		                }
		                catch ( Il2CppExceptionWrapper *v96 )
		                {
		                  ex = v96->ex;
		                  sub_1801F4710(&ex);
		                  return;
		                }
		                break;
		              }
		              j = (unsigned __int64)v9->fields.Vertices;
		              v44 = (CSGVertex__Array *)(unsigned int)((int)(v49 + 1) >> 31);
		              LODWORD(v44) = (int)(v49 + 1) % v50->max_length.size;
		              index[0] = (int)(v49 + 1) % *(_DWORD *)(j + 24);
		              if ( !v14 )
		                goto LABEL_87;
		              Item = System::Collections::Generic::List<System::Int32Enum>::get_Item(
		                       (List_1_System_Int32Enum_ *)v14,
		                       v49,
		                       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::get_Item);
		              v87 = System::Collections::Generic::List<System::Int32Enum>::get_Item(
		                      (List_1_System_Int32Enum_ *)v14,
		                      index[0],
		                      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::get_Item);
		              v52 = v9->fields.Vertices;
		              if ( !v52 )
		                goto LABEL_87;
		              if ( v49 >= v52->max_length.size
		                || (v53 = v52->vector[v49],
		                    v86 = v53,
		                    v44 = v9->fields.Vertices,
		                    j = index[0],
		                    index[0] >= (unsigned int)v44->max_length.size) )
		              {
		                sub_1800D2AA0(j, v44, v51);
		              }
		              *(_QWORD *)index = v44->vector[index[0]];
		              if ( Item != 2 )
		              {
		                sub_182F01190((List_1_System_Object_ *)v46, (Object *)v53);
		                v54 = Item;
		                if ( Item == 1 )
		                  goto LABEL_50;
		                v53 = v86;
		              }
		              sub_182F01190((List_1_System_Object_ *)v48, (Object *)v53);
		              v54 = Item;
		LABEL_50:
		              j = v54 | v87;
		              if ( (_DWORD)j == 3 )
		              {
		                if ( !v86 )
		                  goto LABEL_87;
		                v90 = *(_QWORD *)&v86->fields.Position.x;
		                ex = *(Il2CppException **)&v10->m_Normal.x;
		                j = *(_QWORD *)index;
		                if ( !*(_QWORD *)index )
		                  goto LABEL_87;
		                v89 = *(_QWORD *)&v86->fields.Position.x;
		                v88 = *(_QWORD *)(*(_QWORD *)index + 16LL);
		                v55 = *(float *)(*(_QWORD *)index + 24LL) - v86->fields.Position.z;
		                o1.klass = *(Object__Class **)&v10->m_Normal.x;
		                v56 = (Object *)HG::Rendering::Runtime::CSG::CSGVertex::Interpolate(
		                                  v86,
		                                  *(CSGVertex **)index,
		                                  (float)((float)-v10->m_Distance
		                                        - (float)((float)((float)(*((float *)&v90 + 1) * *((float *)&ex + 1))
		                                                        + (float)(*(float *)&v90 * *(float *)&ex))
		                                                + (float)(v86->fields.Position.z * v10->m_Normal.z)))
		                                / (float)((float)((float)(*(float *)&o1.klass * (float)(*(float *)&v88 - *(float *)&v89))
		                                                + (float)(*((float *)&o1.klass + 1)
		                                                        * (float)(*((float *)&v88 + 1) - *((float *)&v89 + 1))))
		                                        + (float)(v10->m_Normal.z * v55)),
		                                  0LL);
		                sub_182F01190(*(List_1_System_Object_ **)&m_Normal.x, v56);
		                sub_182F01190((List_1_System_Object_ *)v48, v56);
		                v46 = *(List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ **)&m_Normal.x;
		              }
		              ++v49;
		            }
		          }
		        }
		      }
		    }
		    sub_1801F4710(&ex);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5264, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v74, v73);
		  o1 = (Object)*v10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1527(
		    Patch,
		    (Plane *)&o1,
		    (Object *)v9,
		    v8,
		    v7,
		    (Object *)front,
		    (Object *)back,
		    0LL);
		}
		
		public static void ToTriangleList<V, I>(this ICsgProvider tree, Func<Vector3, Vector2, int, int, V> positionNormalToVertex, Func<V, I> insertVertex, Action<I, I, I, PostionUVPair> createTriangle) {}
		public static void ToListLine<V, I>(this ICsgProvider tree, Func<Vector3, Vector3, V> positionNormalToVertex, Func<V, I> insertVertex, Action<I, I> createLine) {}
		public static bool IsEmpty<T>(this IEnumerable<T> e) => default;
		public static float? Intersects(this Ray ray, BSP bsp) => default; // 0x0000000189C7618C-0x0000000189C76220
		// Nullable`1[Single] Intersects(Ray, BSP)
		Nullable_1_Single_ HG::Rendering::Runtime::CSG::Extensions::Intersects(Ray *ray, BSP *bsp, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // xmm1_8
		  Ray v11; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5440, 0LL) )
		  {
		    if ( bsp )
		    {
		      v7 = *(_QWORD *)&ray->m_Direction.y;
		      *(_OWORD *)&v11.m_Origin.x = *(_OWORD *)&ray->m_Origin.x;
		      *(_QWORD *)&v11.m_Direction.y = v7;
		      return HG::Rendering::Runtime::CSG::BSP::RayCast(bsp, &v11, 0LL);
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5440, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v10 = *(_QWORD *)&ray->m_Direction.y;
		  *(_OWORD *)&v11.m_Origin.x = *(_OWORD *)&ray->m_Origin.x;
		  *(_QWORD *)&v11.m_Direction.y = v10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1574(Patch, &v11, (Object *)bsp, 0LL);
		}
		
		public static float Distance(this Vector3 point, Plane plane) => default; // 0x0000000189C75EDC-0x0000000189C75F88
		// Single Distance(Vector3, Plane)
		float HG::Rendering::Runtime::CSG::Extensions::Distance(Vector3 *point, Plane *plane, MethodInfo *method)
		{
		  MethodInfo *v5; // r8
		  float v6; // eax
		  __int64 v7; // xmm0_8
		  float v8; // eax
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Plane v12; // xmm0
		  float z; // eax
		  Plane v14; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v15[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5265, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5265, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    v12 = *plane;
		    z = point->z;
		    *(_QWORD *)&v15[0].x = *(_QWORD *)&point->x;
		    v14 = v12;
		    v15[0].z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1522(Patch, v15, &v14, 0LL);
		  }
		  else
		  {
		    v6 = point->z;
		    *(_QWORD *)&v14.m_Normal.x = *(_QWORD *)&point->x;
		    v7 = *(_QWORD *)&plane->m_Normal.x;
		    v14.m_Normal.z = v6;
		    v8 = plane->m_Normal.z;
		    *(_QWORD *)&v15[0].x = v7;
		    v15[0].z = v8;
		    return UnityEngine::Vector3::Dot(v15, &v14.m_Normal, v5) + plane->m_Distance;
		  }
		}
		
		public static Bounds IncludePoint(this Bounds bound, Vector3 point) => default; // 0x0000000189C75F88-0x0000000189C7618C
		// Bounds IncludePoint(Bounds, Vector3)
		Bounds *HG::Rendering::Runtime::CSG::Extensions::IncludePoint(
		        Bounds *__return_ptr retstr,
		        Bounds *bound,
		        Vector3 *point,
		        MethodInfo *method)
		{
		  __m128 x_low; // xmm6
		  __m128 v8; // xmm0
		  __m128 v9; // xmm10
		  __m128 y_low; // xmm0
		  __m128 v11; // xmm9
		  Vector3 *min; // rax
		  float v13; // xmm8_4
		  __m128 v14; // xmm0
		  __m128 v15; // xmm7
		  __int128 v16; // xmm0
		  __m128 v17; // xmm6
		  Vector3 *max; // rax
		  __int128 v19; // xmm0
		  __int64 v20; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // xmm1_8
		  float z; // eax
		  __int128 v25; // xmm0
		  Bounds *v26; // rax
		  Bounds *result; // rax
		  Bounds v28; // [rsp+38h] [rbp-49h] BYREF
		  Vector3 v29; // [rsp+58h] [rbp-29h] BYREF
		  Bounds v30[4]; // [rsp+68h] [rbp-19h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5123, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5123, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, 0LL);
		    v23 = *(_QWORD *)&bound->m_Extents.y;
		    z = point->z;
		    *(_QWORD *)&v29.x = *(_QWORD *)&point->x;
		    v25 = *(_OWORD *)&bound->m_Center.x;
		    v29.z = z;
		    *(_QWORD *)&v28.m_Extents.y = v23;
		    *(_OWORD *)&v28.m_Center.x = v25;
		    v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1492(v30, Patch, &v28, &v29, 0LL);
		    v19 = *(_OWORD *)&v26->m_Center.x;
		    v20 = *(_QWORD *)&v26->m_Extents.y;
		  }
		  else
		  {
		    x_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v29, bound, 0LL)->x);
		    sub_1800036A0(TypeInfo::System::Math);
		    v8 = x_low;
		    v8.m128_f32[0] = System::Math::Min(x_low.m128_f32[0], point->x, 0LL);
		    v9 = v8;
		    y_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v29, bound, 0LL)->y);
		    y_low.m128_f32[0] = System::Math::Min(y_low.m128_f32[0], point->y, 0LL);
		    v11 = y_low;
		    min = UnityEngine::Bounds::get_min(&v29, bound, 0LL);
		    v13 = System::Math::Min(min->z, point->z, 0LL);
		    v14 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v29, bound, 0LL)->x);
		    v14.m128_f32[0] = System::Math::Max(v14.m128_f32[0], point->x, 0LL);
		    v15 = v14;
		    v16 = LODWORD(UnityEngine::Bounds::get_max(&v29, bound, 0LL)->y);
		    *(float *)&v16 = System::Math::Max(*(float *)&v16, point->y, 0LL);
		    v17 = (__m128)v16;
		    max = UnityEngine::Bounds::get_max(&v29, bound, 0LL);
		    *(float *)&v16 = System::Math::Max(max->z, point->z, 0LL);
		    *(_QWORD *)&v28.m_Center.x = _mm_unpacklo_ps(v15, v17).m128_u64[0];
		    *(_QWORD *)&v29.x = _mm_unpacklo_ps(v9, v11).m128_u64[0];
		    LODWORD(v28.m_Center.z) = v16;
		    v29.z = v13;
		    UnityEngine::Bounds::SetMinMax(bound, &v29, &v28.m_Center, 0LL);
		    v19 = *(_OWORD *)&bound->m_Center.x;
		    v20 = *(_QWORD *)&bound->m_Extents.y;
		  }
		  result = retstr;
		  *(_OWORD *)&retstr->m_Center.x = v19;
		  *(_QWORD *)&retstr->m_Extents.y = v20;
		  return result;
		}
		
		[IDTag(1)]
		public static Bounds Transform(this Bounds bound, Matrix4x4 transform) => default; // 0x0000000189C77564-0x0000000189C77C20
		// Bounds Transform(Bounds, Matrix4x4)
		// Hidden C++ exception states: #wind=1
		Bounds *HG::Rendering::Runtime::CSG::Extensions::Transform(
		        Bounds *__return_ptr retstr,
		        Bounds *bound,
		        Matrix4x4 *transform,
		        MethodInfo *method)
		{
		  Bounds *v6; // rdi
		  Object *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *v10; // r14
		  IEnumerable_1_UnityEngine_Vector3_ *v11; // rsi
		  Vector3 *min; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  float z; // r15d
		  __m128 x_low; // xmm6
		  __m128 y_low; // xmm7
		  float v18; // xmm8_4
		  __m128 v19; // xmm6
		  __m128 v20; // xmm7
		  float v21; // xmm8_4
		  __m128 v22; // xmm6
		  __m128 v23; // xmm7
		  float v24; // xmm8_4
		  Vector3 *max; // rax
		  float v26; // r15d
		  __m128 v27; // xmm6
		  __m128 v28; // xmm7
		  float v29; // xmm8_4
		  __m128 v30; // xmm6
		  __m128 v31; // xmm7
		  float v32; // xmm8_4
		  __m128 v33; // xmm6
		  __m128 v34; // xmm7
		  float v35; // xmm8_4
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *v36; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *v39; // rbx
		  IEnumerable_1_UnityEngine_Vector3_ *v40; // rbx
		  IEnumerable_1_UnityEngine_Vector3_ *v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  __int64 v48; // rax
		  __int64 v49; // xmm8_8
		  float v50; // ebx
		  Bounds *v51; // rax
		  __int128 v52; // xmm7
		  __int64 v53; // xmm6_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  Il2CppException *ex; // [rsp+30h] [rbp-118h] BYREF
		  __int64 *v59; // [rsp+38h] [rbp-110h]
		  Vector3 v60; // [rsp+40h] [rbp-108h] BYREF
		  __int64 v61; // [rsp+50h] [rbp-F8h] BYREF
		  Bounds v62; // [rsp+58h] [rbp-F0h] BYREF
		  Vector3 v63; // [rsp+70h] [rbp-D8h] BYREF
		  Bounds v64; // [rsp+80h] [rbp-C8h] BYREF
		  Il2CppExceptionWrapper *v65; // [rsp+A0h] [rbp-A8h] BYREF
		  Bounds v66; // [rsp+A8h] [rbp-A0h] BYREF
		  Matrix4x4 v67; // [rsp+C0h] [rbp-88h] BYREF
		
		  v6 = retstr;
		  memset(&v62, 0, sizeof(v62));
		  if ( IFix::WrappersManagerImpl::IsPatched(5423, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5423, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v56, v55);
		    v67 = *transform;
		    v64 = *bound;
		    *v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1565(&v66, Patch, &v64, &v67, 0LL);
		  }
		  else
		  {
		    v7 = (Object *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::Extensions::__c__DisplayClass13_0);
		    v10 = v7;
		    if ( !v7 )
		      sub_1800D8260(v9, v8);
		    v7[1] = *(Object *)&transform->m00;
		    v7[2] = *(Object *)&transform->m01;
		    v7[3] = *(Object *)&transform->m02;
		    v7[4] = *(Object *)&transform->m03;
		    v11 = (IEnumerable_1_UnityEngine_Vector3_ *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 8LL);
		    min = UnityEngine::Bounds::get_min(&v60, bound, 0LL);
		    z = min->z;
		    if ( !v11 )
		      sub_1800D8260(v14, v13);
		    ex = *(Il2CppException **)&min->x;
		    *(float *)&v59 = z;
		    sub_180049BD0(v11, 0LL, &ex);
		    x_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->x);
		    y_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->y);
		    v18 = UnityEngine::Bounds::get_max(&v60, bound, 0LL)->z;
		    ex = (Il2CppException *)_mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		    *(float *)&v59 = v18;
		    sub_180049BD0(v11, 1LL, &ex);
		    v19 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->x);
		    v20 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v60, bound, 0LL)->y);
		    v21 = UnityEngine::Bounds::get_min(&v60, bound, 0LL)->z;
		    ex = (Il2CppException *)_mm_unpacklo_ps(v19, v20).m128_u64[0];
		    *(float *)&v59 = v21;
		    sub_180049BD0(v11, 2LL, &ex);
		    v22 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->x);
		    v23 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v60, bound, 0LL)->y);
		    v24 = UnityEngine::Bounds::get_max(&v60, bound, 0LL)->z;
		    ex = (Il2CppException *)_mm_unpacklo_ps(v22, v23).m128_u64[0];
		    *(float *)&v59 = v24;
		    sub_180049BD0(v11, 3LL, &ex);
		    max = UnityEngine::Bounds::get_max(&v60, bound, 0LL);
		    v26 = max->z;
		    ex = *(Il2CppException **)&max->x;
		    *(float *)&v59 = v26;
		    sub_180049BD0(v11, 4LL, &ex);
		    v27 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v60, bound, 0LL)->x);
		    v28 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->y);
		    v29 = UnityEngine::Bounds::get_max(&v60, bound, 0LL)->z;
		    ex = (Il2CppException *)_mm_unpacklo_ps(v27, v28).m128_u64[0];
		    *(float *)&v59 = v29;
		    sub_180049BD0(v11, 5LL, &ex);
		    v30 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v60, bound, 0LL)->x);
		    v31 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->y);
		    v32 = UnityEngine::Bounds::get_min(&v60, bound, 0LL)->z;
		    ex = (Il2CppException *)_mm_unpacklo_ps(v30, v31).m128_u64[0];
		    *(float *)&v59 = v32;
		    sub_180049BD0(v11, 6LL, &ex);
		    v33 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v60, bound, 0LL)->x);
		    v34 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v60, bound, 0LL)->y);
		    v35 = UnityEngine::Bounds::get_min(&v60, bound, 0LL)->z;
		    ex = (Il2CppException *)_mm_unpacklo_ps(v33, v34).m128_u64[0];
		    *(float *)&v59 = v35;
		    sub_180049BD0(v11, 7LL, &ex);
		    v36 = (Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *)sub_18002C620(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector3>);
		    v39 = v36;
		    if ( !v36 )
		      sub_1800D8260(v38, v37);
		    System::Func<UnityEngine::Vector3,UnityEngine::Vector3>::Func(
		      v36,
		      v10,
		      MethodInfo::HG::Rendering::Runtime::CSG::Extensions::__c__DisplayClass13_0::_Transform_b__0,
		      0LL);
		    v40 = System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>(
		            v11,
		            v39,
		            MethodInfo::System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>);
		    System::Linq::Enumerable::First<UnityEngine::Vector3>(
		      &v63,
		      v40,
		      MethodInfo::System::Linq::Enumerable::First<UnityEngine::Vector3>);
		    System::Linq::Enumerable::First<UnityEngine::Vector3>(
		      (Vector3 *)&ex,
		      v40,
		      MethodInfo::System::Linq::Enumerable::First<UnityEngine::Vector3>);
		    *(_QWORD *)&v60.x = ex;
		    LODWORD(v60.z) = (_DWORD)v59;
		    ex = *(Il2CppException **)&v63.x;
		    *(float *)&v59 = v63.z;
		    UnityEngine::Bounds::Bounds(&v62, (Vector3 *)&ex, &v60, 0LL);
		    v41 = System::Linq::Enumerable::Skip<UnityEngine::Vector3>(
		            v40,
		            1,
		            MethodInfo::System::Linq::Enumerable::Skip<UnityEngine::Vector3>);
		    if ( !v41 )
		      sub_1800D8260(v43, v42);
		    v61 = sub_1800428A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector3>, v41);
		    ex = 0LL;
		    v59 = &v61;
		    try
		    {
		      v53 = *(_QWORD *)&v62.m_Extents.y;
		      v52 = *(_OWORD *)&v62.m_Center.x;
		      while ( 1 )
		      {
		        if ( !v61 )
		          sub_1800D8250(v45, v44);
		        if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		          break;
		        if ( !v61 )
		          sub_1800D8250(v47, v46);
		        v48 = sub_1802089F8(&v63, 0LL, TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector3>, v61);
		        v49 = *(_QWORD *)v48;
		        v50 = *(float *)(v48 + 8);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		        *(_QWORD *)&v60.x = v49;
		        v60.z = v50;
		        *(_OWORD *)&v64.m_Center.x = v52;
		        *(_QWORD *)&v64.m_Extents.y = v53;
		        v51 = HG::Rendering::Runtime::CSG::Extensions::IncludePoint(&v66, &v64, &v60, 0LL);
		        v52 = *(_OWORD *)&v51->m_Center.x;
		        *(_OWORD *)&v62.m_Center.x = *(_OWORD *)&v51->m_Center.x;
		        v53 = *(_QWORD *)&v51->m_Extents.y;
		        *(_QWORD *)&v62.m_Extents.y = v53;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v65 )
		    {
		      ex = v65->ex;
		      sub_1801F6A10(&ex);
		      v6 = retstr;
		      v53 = *(_QWORD *)&v62.m_Extents.y;
		      v52 = *(_OWORD *)&v62.m_Center.x;
		      goto LABEL_12;
		    }
		    sub_1801F6A10(&ex);
		LABEL_12:
		    *(_OWORD *)&v6->m_Center.x = v52;
		    *(_QWORD *)&v6->m_Extents.y = v53;
		  }
		  return v6;
		}
		
		[IteratorStateMachine(typeof(_Append_d__14<T>))]
		public static IEnumerable<T> Append<T>(this IEnumerable<T> start, IEnumerable<T> end) => default;
		public static IEnumerable<T> Append<T>(this IEnumerable<T> start, params T[] end) => default;
		[IDTag(0)]
		public static Vector3 Transform(this Vector3 vector, Matrix4x4 transform) => default; // 0x0000000189C77C20-0x0000000189C77DE8
		// Vector3 Transform(Vector3, Matrix4x4)
		Vector3 *HG::Rendering::Runtime::CSG::Extensions::Transform(
		        Vector3 *__return_ptr retstr,
		        Vector3 *vector,
		        Matrix4x4 *transform,
		        MethodInfo *method)
		{
		  __m128 v7; // xmm0
		  MethodInfo *v8; // r9
		  Vector3 *v9; // rax
		  __int64 v10; // xmm6_8
		  float v11; // ebx
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Vector3 *v16; // rax
		  float m22; // xmm2_4
		  MethodInfo *v18; // r8
		  float v19; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v21; // rcx
		  float z; // eax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  Vector3 *v26; // rax
		  Quaternion v28; // [rsp+38h] [rbp-29h] BYREF
		  Vector3 v29; // [rsp+48h] [rbp-19h] BYREF
		  Quaternion v30; // [rsp+58h] [rbp-9h] BYREF
		  Matrix4x4 v31; // [rsp+68h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5420, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5420, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, 0LL);
		    z = vector->z;
		    v23 = *(_OWORD *)&transform->m01;
		    *(_OWORD *)&v31.m00 = *(_OWORD *)&transform->m00;
		    v24 = *(_OWORD *)&transform->m02;
		    v29.z = z;
		    *(_OWORD *)&v31.m01 = v23;
		    v25 = *(_OWORD *)&transform->m03;
		    *(_OWORD *)&v31.m02 = v24;
		    *(_QWORD *)&v29.x = *(_QWORD *)&vector->x;
		    *(_OWORD *)&v31.m03 = v25;
		    v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1564((Vector3 *)&v30, Patch, &v29, &v31, 0LL);
		    *(_QWORD *)&v24 = *(_QWORD *)&v26->x;
		    v19 = v26->z;
		    *(_QWORD *)&retstr->x = v24;
		  }
		  else
		  {
		    v7 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v30, transform, 3, 0LL));
		    v29.z = vector->z;
		    *(_QWORD *)&v28.x = _mm_unpacklo_ps(v7, _mm_shuffle_ps(v7, v7, 85)).m128_u64[0];
		    *(_QWORD *)&v29.x = *(_QWORD *)&vector->x;
		    LODWORD(v28.z) = _mm_shuffle_ps(v7, v7, 170).m128_u32[0];
		    v9 = UnityEngine::Vector3::op_Addition((Vector3 *)&v30, &v29, (Vector3 *)&v28, v8);
		    v10 = *(_QWORD *)&v9->x;
		    v11 = v9->z;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    v12 = *(_OWORD *)&transform->m00;
		    v13 = *(_OWORD *)&transform->m01;
		    v29.z = v11;
		    *(_OWORD *)&v31.m00 = v12;
		    v14 = *(_OWORD *)&transform->m02;
		    *(_OWORD *)&v31.m01 = v13;
		    v15 = *(_OWORD *)&transform->m03;
		    *(_OWORD *)&v31.m02 = v14;
		    *(_OWORD *)&v31.m03 = v15;
		    *(_QWORD *)&v29.x = v10;
		    v28 = *HG::Rendering::Runtime::CSG::Extensions::QuaternionFromMatrix(&v30, &v31, 0LL);
		    v16 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v30, &v28, &v29, 0LL);
		    *(_QWORD *)&v14 = *(_QWORD *)&v16->x;
		    m22 = transform->m22;
		    *(float *)&v16 = v16->z;
		    *(_QWORD *)&v29.x = _mm_unpacklo_ps(*(__m128 *)&transform->m00, (__m128)LODWORD(transform->m11)).m128_u64[0];
		    v29.z = m22;
		    *(_QWORD *)&v28.x = v14;
		    LODWORD(v28.z) = (_DWORD)v16;
		    UnityEngine::Vector3::Scale((Vector3 *)&v28, &v29, v18);
		    v19 = v28.z;
		    *(_QWORD *)&retstr->x = *(_QWORD *)&v28.x;
		  }
		  retstr->z = v19;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 Transform(this Vector3 vector, Vector3 pos, Quaternion rotation, Vector3 scale) => default; // 0x0000000189C773DC-0x0000000189C77564
		// Vector3 Transform(Vector3, Vector3, Quaternion, Vector3)
		Vector3 *HG::Rendering::Runtime::CSG::Extensions::Transform(
		        Vector3 *__return_ptr retstr,
		        Vector3 *vector,
		        Vector3 *pos,
		        Quaternion *rotation,
		        Vector3 *scale,
		        MethodInfo *method)
		{
		  MethodInfo *v10; // r9
		  float v11; // eax
		  __int64 v12; // xmm0_8
		  float v13; // eax
		  Vector3 *v14; // rax
		  Quaternion v15; // xmm0
		  __int64 v16; // xmm3_8
		  Vector3 *v17; // rax
		  MethodInfo *v18; // r8
		  float v19; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // xmm0_8
		  float z; // eax
		  Quaternion v24; // xmm0
		  Vector3 *v25; // rax
		  Vector3 v27; // [rsp+48h] [rbp-9h] BYREF
		  Vector3 v28; // [rsp+58h] [rbp+7h] BYREF
		  Vector3 v29; // [rsp+68h] [rbp+17h] BYREF
		  Quaternion v30; // [rsp+78h] [rbp+27h] BYREF
		  Quaternion v31; // [rsp+88h] [rbp+37h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5441, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5441, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, 0LL);
		    *(_QWORD *)&v27.x = *(_QWORD *)&pos->x;
		    v22 = *(_QWORD *)&scale->x;
		    v28.z = scale->z;
		    v27.z = pos->z;
		    z = vector->z;
		    *(_QWORD *)&v28.x = v22;
		    v24 = *rotation;
		    v29.z = z;
		    v31 = v24;
		    *(_QWORD *)&v29.x = *(_QWORD *)&vector->x;
		    v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1575((Vector3 *)&v30, Patch, &v29, &v27, &v31, &v28, 0LL);
		    *(_QWORD *)&v24.x = *(_QWORD *)&v25->x;
		    v19 = v25->z;
		    *(_QWORD *)&retstr->x = *(_QWORD *)&v24.x;
		  }
		  else
		  {
		    v11 = pos->z;
		    *(_QWORD *)&v27.x = *(_QWORD *)&pos->x;
		    v12 = *(_QWORD *)&vector->x;
		    v27.z = v11;
		    v13 = vector->z;
		    *(_QWORD *)&v28.x = v12;
		    v28.z = v13;
		    v14 = UnityEngine::Vector3::op_Addition(&v29, &v28, &v27, v10);
		    v15 = *rotation;
		    v16 = *(_QWORD *)&v14->x;
		    *(float *)&v14 = v14->z;
		    *(_QWORD *)&v28.x = v16;
		    LODWORD(v28.z) = (_DWORD)v14;
		    v30 = v15;
		    v17 = UnityEngine::Quaternion::op_Multiply(&v29, &v30, &v28, 0LL);
		    *(_QWORD *)&v15.x = *(_QWORD *)&v17->x;
		    v27.z = v17->z;
		    *(_QWORD *)&v27.x = *(_QWORD *)&v15.x;
		    *(float *)&v17 = scale->z;
		    *(_QWORD *)&v28.x = *(_QWORD *)&scale->x;
		    LODWORD(v28.z) = (_DWORD)v17;
		    UnityEngine::Vector3::Scale(&v27, &v28, v18);
		    v19 = v27.z;
		    *(_QWORD *)&retstr->x = *(_QWORD *)&v27.x;
		  }
		  retstr->z = v19;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 TransformNormal(this Vector3 vector, Vector3 pos, Quaternion rotation, Vector3 scale) => default; // 0x0000000189C7724C-0x0000000189C773DC
		// Vector3 TransformNormal(Vector3, Vector3, Quaternion, Vector3)
		Vector3 *HG::Rendering::Runtime::CSG::Extensions::TransformNormal(
		        Vector3 *__return_ptr retstr,
		        Vector3 *vector,
		        Vector3 *pos,
		        Quaternion *rotation,
		        Vector3 *scale,
		        MethodInfo *method)
		{
		  __m128 y_low; // xmm6
		  float v11; // xmm7_4
		  __int64 v12; // xmm1_8
		  float v13; // eax
		  Quaternion v14; // xmm0
		  float v15; // eax
		  Vector3 *v16; // rax
		  Vector3 *v17; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // xmm0_8
		  float z; // eax
		  Quaternion v22; // xmm0
		  __int64 v23; // xmm0_8
		  float v24; // eax
		  Vector3 v26; // [rsp+48h] [rbp-29h] BYREF
		  Vector3 v27; // [rsp+58h] [rbp-19h] BYREF
		  Vector3 v28; // [rsp+68h] [rbp-9h] BYREF
		  Vector3 v29; // [rsp+78h] [rbp+7h] BYREF
		  Quaternion v30[3]; // [rsp+88h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5442, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5442, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, 0LL);
		    *(_QWORD *)&v27.x = *(_QWORD *)&pos->x;
		    v20 = *(_QWORD *)&scale->x;
		    v28.z = scale->z;
		    v27.z = pos->z;
		    z = vector->z;
		    *(_QWORD *)&v28.x = v20;
		    v22 = *rotation;
		    v26.z = z;
		    v30[0] = v22;
		    *(_QWORD *)&v26.x = *(_QWORD *)&vector->x;
		    v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1575(&v29, Patch, &v26, &v27, v30, &v28, 0LL);
		  }
		  else
		  {
		    y_low = (__m128)LODWORD(vector->y);
		    v11 = vector->z;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    v12 = *(_QWORD *)&pos->x;
		    v28.z = v11;
		    v13 = scale->z;
		    *(_QWORD *)&v26.x = *(_QWORD *)&scale->x;
		    v14 = *rotation;
		    v26.z = v13;
		    v15 = pos->z;
		    v30[0] = v14;
		    v27.z = v15;
		    *(_QWORD *)&v28.x = _mm_unpacklo_ps((__m128)LODWORD(vector->x), y_low).m128_u64[0];
		    *(_QWORD *)&v27.x = v12;
		    v16 = HG::Rendering::Runtime::CSG::Extensions::Transform(&v29, &v28, &v27, v30, &v26, 0LL);
		    *(_QWORD *)&v14.x = *(_QWORD *)&v16->x;
		    *(float *)&v16 = v16->z;
		    *(_QWORD *)&v28.x = *(_QWORD *)&v14.x;
		    LODWORD(v28.z) = (_DWORD)v16;
		    v17 = (Vector3 *)sub_182FAE2B0(&v29, &v28);
		  }
		  v23 = *(_QWORD *)&v17->x;
		  v24 = v17->z;
		  *(_QWORD *)&retstr->x = v23;
		  retstr->z = v24;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 TransformNormal(this Vector3 vector, Matrix4x4 transform) => default; // 0x0000000189C77120-0x0000000189C7724C
		// Vector3 TransformNormal(Vector3, Matrix4x4)
		Vector3 *HG::Rendering::Runtime::CSG::Extensions::TransformNormal(
		        Vector3 *__return_ptr retstr,
		        Vector3 *vector,
		        Matrix4x4 *transform,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  Vector3 *v11; // rax
		  Vector3 *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  float z; // eax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int64 v19; // xmm0_8
		  float v20; // eax
		  Vector3 v22; // [rsp+38h] [rbp-9h] BYREF
		  Vector3 v23; // [rsp+48h] [rbp+7h] BYREF
		  Matrix4x4 v24; // [rsp+58h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5422, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5422, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, 0LL);
		    z = vector->z;
		    v16 = *(_OWORD *)&transform->m01;
		    *(_OWORD *)&v24.m00 = *(_OWORD *)&transform->m00;
		    v17 = *(_OWORD *)&transform->m02;
		    v22.z = z;
		    *(_OWORD *)&v24.m01 = v16;
		    v18 = *(_OWORD *)&transform->m03;
		    *(_OWORD *)&v24.m02 = v17;
		    *(_QWORD *)&v22.x = *(_QWORD *)&vector->x;
		    *(_OWORD *)&v24.m03 = v18;
		    v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1564(&v23, Patch, &v22, &v24, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
		    v7 = *(_OWORD *)&transform->m00;
		    v8 = *(_OWORD *)&transform->m01;
		    v22.z = vector->z;
		    *(_OWORD *)&v24.m00 = v7;
		    v9 = *(_OWORD *)&transform->m02;
		    *(_OWORD *)&v24.m01 = v8;
		    v10 = *(_OWORD *)&transform->m03;
		    *(_OWORD *)&v24.m02 = v9;
		    *(_QWORD *)&v22.x = *(_QWORD *)&vector->x;
		    *(_OWORD *)&v24.m03 = v10;
		    v11 = HG::Rendering::Runtime::CSG::Extensions::Transform(&v23, &v22, &v24, 0LL);
		    *(_QWORD *)&v9 = *(_QWORD *)&v11->x;
		    *(float *)&v11 = v11->z;
		    *(_QWORD *)&v22.x = v9;
		    LODWORD(v22.z) = (_DWORD)v11;
		    v12 = (Vector3 *)sub_182FAE2B0(&v23, &v22);
		  }
		  v19 = *(_QWORD *)&v12->x;
		  v20 = v12->z;
		  *(_QWORD *)&retstr->x = v19;
		  retstr->z = v20;
		  return retstr;
		}
		
	}
}
