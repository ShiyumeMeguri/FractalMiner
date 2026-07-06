using System;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	public static class Extensions
	{
		public static void SplitPolygon(this Plane plane, CSGPolygon polygon, IList<CSGPolygon> coPlanarFront, IList<CSGPolygon> coPlanarBack, IList<CSGPolygon> front, IList<CSGPolygon> back)
		{
			// // Void SplitPolygon(Plane, CSGPolygon, IList`1[HG.Rendering.Runtime.CSG.CSGPolygon], IList`1[HG.Rendering.Runtime.CSG.CSGPolygon], IList`1[HG.Rendering.Runtime.CSG.CSGPolygon], IList`1[HG.Rendering.Runtime.CSG.CSGPolygon])
			// // Hidden C++ exception states: #wind=6
			// void HG::Rendering::Runtime::CSG::Extensions::SplitPolygon(
			//         Plane *plane,
			//         CSGPolygon *polygon,
			//         IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *coPlanarFront,
			//         IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *coPlanarBack,
			//         IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *front,
			//         IList_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *back,
			//         MethodInfo *method)
			// {
			//   Object *v7; // r12
			//   Object *v8; // rbx
			//   CSGPolygon *v9; // rsi
			//   Plane *v10; // r13
			//   CSGVertex *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   List_1_System_UInt32_ *v14; // r15
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // r8
			//   int v18; // r14d
			//   Object *v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   MethodInfo *v22; // r8
			//   Int32Enum__Enum i; // ebx
			//   CSGVertex__Array *Vertices; // rax
			//   CSGVertex__Array *v25; // rcx
			//   CSGVertex *v26; // r12
			//   __int64 v27; // xmm6_8
			//   float z; // ebx
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   float v31; // xmm0_4
			//   __int64 v32; // rbx
			//   int v33; // r14d
			//   int v34; // r14d
			//   __m128i v35; // xmm0
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v44; // rax
			//   CSGVertex__Array *v45; // rdx
			//   unsigned __int64 j; // rcx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v47; // rbx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v48; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v49; // r14
			//   unsigned int v50; // r12d
			//   CSGVertex__Array *v51; // rax
			//   __int64 v52; // r8
			//   __int64 v53; // r9
			//   CSGVertex__Array *v54; // rax
			//   CSGVertex *v55; // rax
			//   Int32Enum__Enum v56; // eax
			//   float v57; // xmm7_4
			//   Object *v58; // rbx
			//   int32_t objID; // r12d
			//   int32_t materialID; // r13d
			//   CSGPolygon *v61; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   CSGPolygon *v64; // r15
			//   __int64 v65; // rdx
			//   __int64 v66; // rcx
			//   int32_t v67; // r15d
			//   int32_t v68; // esi
			//   CSGPolygon *v69; // rax
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   CSGPolygon *v72; // rbx
			//   __int64 v73; // rdx
			//   __int64 v74; // rcx
			//   __int64 v75; // rdx
			//   __int64 v76; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // r14
			//   bool lockTaken; // [rsp+40h] [rbp-168h] BYREF
			//   Object *obj; // [rsp+48h] [rbp-160h] BYREF
			//   Int32Enum__Enum Item; // [rsp+50h] [rbp-158h]
			//   Plane v81; // [rsp+60h] [rbp-148h] BYREF
			//   Il2CppException *ex; // [rsp+70h] [rbp-138h] BYREF
			//   Plane v83; // [rsp+78h] [rbp-130h]
			//   Vector3 m_Normal; // [rsp+90h] [rbp-118h] BYREF
			//   Vector3 v85; // [rsp+A0h] [rbp-108h] BYREF
			//   int32_t index[2]; // [rsp+B0h] [rbp-F8h]
			//   CSGVertex *v87; // [rsp+B8h] [rbp-F0h]
			//   Int32Enum__Enum v88; // [rsp+C0h] [rbp-E8h]
			//   __int64 v89; // [rsp+D0h] [rbp-D8h]
			//   __int64 v90; // [rsp+E0h] [rbp-C8h]
			//   __int64 v91; // [rsp+F0h] [rbp-B8h]
			//   Il2CppExceptionWrapper *v92; // [rsp+100h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v93; // [rsp+108h] [rbp-A0h] BYREF
			//   Il2CppExceptionWrapper *v94; // [rsp+110h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v95; // [rsp+118h] [rbp-90h] BYREF
			//   Il2CppExceptionWrapper *v96; // [rsp+120h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v97; // [rsp+128h] [rbp-80h] BYREF
			//   Object o1; // [rsp+130h] [rbp-78h] BYREF
			//   Plane v99; // [rsp+140h] [rbp-68h]
			// 
			//   v7 = (Object *)coPlanarBack;
			//   v8 = (Object *)coPlanarFront;
			//   v9 = polygon;
			//   v10 = plane;
			//   if ( !byte_18D919D16 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::ICollection<HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Plane);
			//     byte_18D919D16 = 1;
			//   }
			//   obj = 0LL;
			//   lockTaken = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4588, 0LL) )
			//   {
			//     v11 = (CSGVertex *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>);
			//     v14 = (List_1_System_UInt32_ *)v11;
			//     v87 = v11;
			//     if ( !v11 )
			//       sub_180B536AC(v13, v12);
			//     System::Collections::Generic::List<Beyond::Gameplay::Core::PullComponent::PullAttenuationValueConfig>::List(
			//       (List_1_Beyond_Gameplay_Core_PullComponent_PullAttenuationValueConfig_ *)v11,
			//       10,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::List);
			//     v18 = 0;
			//     if ( !v9 )
			//       sub_180B536AC(v16, v15);
			//     v81 = v9.fields.Plane;
			//     v19 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Plane, &v81, v17);
			//     o1.klass = (Object__Class *)TypeInfo::UnityEngine::Plane;
			//     o1.monitor = (MonitorData *)-1LL;
			//     v99 = *v10;
			//     if ( System::ValueType::DefaultEquals(&o1, v19, 0LL) )
			//     {
			//       if ( !v14 )
			//         sub_180B536AC(v21, v20);
			//       sub_1826AA8C0(v14, 0);
			//     }
			//     else
			//     {
			//       for ( i = 0; ; i = Item + 1 )
			//       {
			//         Item = i;
			//         Vertices = v9.fields.Vertices;
			//         if ( !Vertices )
			//           sub_180B536AC(v21, v20);
			//         if ( (int)i >= Vertices.max_length.size )
			//           break;
			//         v25 = v9.fields.Vertices;
			//         if ( i >= Vertices.max_length.size )
			//           sub_180070270(v25, v20);
			//         v26 = v25.vector[i];
			//         if ( !v26 )
			//           sub_180B536AC(v25, v20);
			//         v27 = *(_QWORD *)&v26.fields.Position.x;
			//         z = v26.fields.Position.z;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//         v81 = *v10;
			//         *(_QWORD *)&v85.x = v27;
			//         v85.z = z;
			//         v31 = HG::Rendering::Runtime::CSG::Extensions::Distance(&v85, &v81, 0LL);
			//         if ( v31 >= -0.001 )
			//           v32 = v31 > 0.001;
			//         else
			//           LODWORD(v32) = 2;
			//         v18 |= v32;
			//         if ( !v14 )
			//           sub_180B536AC(v30, v29);
			//         sub_1826AA8C0(v14, v32);
			//       }
			//       v7 = (Object *)coPlanarBack;
			//       if ( v18 )
			//       {
			//         v33 = v18 - 1;
			//         if ( !v33 )
			//           goto LABEL_33;
			//         v34 = v33 - 1;
			//         if ( !v34 )
			//           goto LABEL_36;
			//         if ( v34 == 1 )
			//           goto LABEL_39;
			//         return;
			//       }
			//       v8 = (Object *)coPlanarFront;
			//     }
			//     v35 = _mm_loadu_si128((const __m128i *)&v9.fields);
			//     *(_QWORD *)&v85.x = v35.m128i_i64[0];
			//     LODWORD(v85.z) = _mm_cvtsi128_si32(_mm_srli_si128(v35, 8));
			//     m_Normal = v10.m_Normal;
			//     if ( UnityEngine::Vector3::Dot(&m_Normal, &v85, v22) <= 0.0 )
			//       goto LABEL_30;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions.static_fields.lock3;
			//     *(_QWORD *)&v81.m_Normal.x = &lockTaken;
			//     *(_QWORD *)&v81.m_Normal.z = &obj;
			//     ex = 0LL;
			//     v83 = v81;
			//     try
			//     {
			//       System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
			//       if ( !v8 )
			//         sub_1802DC2C8(v37, v36);
			//       sub_180835264(v37, v36, v8, v9);
			//     }
			//     catch ( Il2CppExceptionWrapper *v92 )
			//     {
			//       ex = v92.ex;
			//       sub_1801E36E0(&ex);
			//       v7 = (Object *)coPlanarBack;
			//       v9 = polygon;
			// LABEL_30:
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//       obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions.static_fields.lock4;
			//       lockTaken = 0;
			//       *(_QWORD *)&v81.m_Normal.x = &lockTaken;
			//       *(_QWORD *)&v81.m_Normal.z = &obj;
			//       ex = 0LL;
			//       v83 = v81;
			//       try
			//       {
			//         System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
			//         if ( !v7 )
			//           sub_1802DC2C8(v39, v38);
			//         sub_180835264(v39, v38, v7, v9);
			//       }
			//       catch ( Il2CppExceptionWrapper *v93 )
			//       {
			//         ex = v93.ex;
			//         sub_1801E36E0(&ex);
			//         v9 = polygon;
			// LABEL_33:
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//         obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions.static_fields.lock1;
			//         lockTaken = 0;
			//         *(_QWORD *)&v81.m_Normal.x = &lockTaken;
			//         *(_QWORD *)&v81.m_Normal.z = &obj;
			//         ex = 0LL;
			//         v83 = v81;
			//         try
			//         {
			//           System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
			//           if ( !front )
			//             sub_1802DC2C8(v41, v40);
			//           sub_180835264(v41, v40, front, v9);
			//         }
			//         catch ( Il2CppExceptionWrapper *v94 )
			//         {
			//           ex = v94.ex;
			//           sub_1801E36E0(&ex);
			//           v9 = polygon;
			// LABEL_36:
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//           obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions.static_fields.lock2;
			//           lockTaken = 0;
			//           *(_QWORD *)&v81.m_Normal.x = &lockTaken;
			//           *(_QWORD *)&v81.m_Normal.z = &obj;
			//           ex = 0LL;
			//           v83 = v81;
			//           try
			//           {
			//             System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
			//             if ( !back )
			//               sub_1802DC2C8(v43, v42);
			//             sub_180835264(v43, v42, back, v9);
			//           }
			//           catch ( Il2CppExceptionWrapper *v95 )
			//           {
			//             ex = v95.ex;
			//             sub_1801E36E0(&ex);
			//             v9 = polygon;
			//             v10 = plane;
			//             v14 = (List_1_System_UInt32_ *)v87;
			// LABEL_39:
			//             v44 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
			//             v47 = v44;
			//             *(_QWORD *)&m_Normal.x = v44;
			//             if ( !v44
			//               || (System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//                     v44,
			//                     10,
			//                     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List),
			//                   v48 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>),
			//                   v49 = v48,
			//                   (*(_QWORD *)&v85.x = v48) == 0LL) )
			//             {
			// LABEL_89:
			//               sub_1802DC2C8(j, v45);
			//             }
			//             System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//               v48,
			//               10,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
			//             v50 = 0;
			//             for ( j = 0LL; ; j = v50 )
			//             {
			//               v51 = v9.fields.Vertices;
			//               if ( !v51 )
			//                 goto LABEL_89;
			//               if ( (int)j >= v51.max_length.size )
			//               {
			//                 if ( v47.fields._size >= 3
			//                   && !HG::Rendering::Runtime::CSG::CSGPolygon::IsDegenerateSet(
			//                         (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v47,
			//                         0LL) )
			//                 {
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//                   obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions.static_fields.lock1;
			//                   lockTaken = 0;
			//                   *(_QWORD *)&v81.m_Normal.x = &lockTaken;
			//                   *(_QWORD *)&v81.m_Normal.z = &obj;
			//                   ex = 0LL;
			//                   v83 = v81;
			//                   try
			//                   {
			//                     System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
			//                     objID = v9.fields.objID;
			//                     materialID = v9.fields.materialID;
			//                     v61 = (CSGPolygon *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//                     v64 = v61;
			//                     if ( !v61 )
			//                       sub_1802DC2C8(v63, v62);
			//                     HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//                       v61,
			//                       (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v47,
			//                       objID,
			//                       materialID,
			//                       0LL);
			//                     if ( !front )
			//                       sub_1802DC2C8(v66, v65);
			//                     sub_180835264(v66, v65, front, v64);
			//                   }
			//                   catch ( Il2CppExceptionWrapper *v96 )
			//                   {
			//                     ex = v96.ex;
			//                     sub_1801E36E0(&ex);
			//                     v9 = polygon;
			//                     v49 = *(List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ **)&v85.x;
			//                     goto LABEL_64;
			//                   }
			//                   sub_1801E36E0(&ex);
			//                 }
			// LABEL_64:
			//                 if ( v49.fields._size < 3 )
			//                   return;
			//                 if ( HG::Rendering::Runtime::CSG::CSGPolygon::IsDegenerateSet(
			//                        (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v49,
			//                        0LL) )
			//                 {
			//                   return;
			//                 }
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//                 obj = TypeInfo::HG::Rendering::Runtime::CSG::Extensions.static_fields.lock2;
			//                 lockTaken = 0;
			//                 *(_QWORD *)&v81.m_Normal.x = &lockTaken;
			//                 *(_QWORD *)&v81.m_Normal.z = &obj;
			//                 ex = 0LL;
			//                 v83 = v81;
			//                 try
			//                 {
			//                   System::Threading::Monitor::Enter(obj, &lockTaken, 0LL);
			//                   v67 = v9.fields.objID;
			//                   v68 = v9.fields.materialID;
			//                   v69 = (CSGPolygon *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//                   v72 = v69;
			//                   if ( !v69 )
			//                     sub_1802DC2C8(v71, v70);
			//                   HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//                     v69,
			//                     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v49,
			//                     v67,
			//                     v68,
			//                     0LL);
			//                   if ( !back )
			//                     sub_1802DC2C8(v74, v73);
			//                   sub_180835264(v74, v73, back, v72);
			//                 }
			//                 catch ( Il2CppExceptionWrapper *v97 )
			//                 {
			//                   ex = v97.ex;
			//                   sub_1801E36E0(&ex);
			//                   return;
			//                 }
			//                 break;
			//               }
			//               j = (unsigned __int64)v9.fields.Vertices;
			//               v45 = (CSGVertex__Array *)(unsigned int)((int)(v50 + 1) >> 31);
			//               LODWORD(v45) = (int)(v50 + 1) % v51.max_length.size;
			//               index[0] = (int)(v50 + 1) % *(_DWORD *)(j + 24);
			//               if ( !v14 )
			//                 goto LABEL_89;
			//               Item = System::Collections::Generic::List<System::Int32Enum>::get_Item(
			//                        (List_1_System_Int32Enum_ *)v14,
			//                        v50,
			//                        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::get_Item);
			//               v88 = System::Collections::Generic::List<System::Int32Enum>::get_Item(
			//                       (List_1_System_Int32Enum_ *)v14,
			//                       index[0],
			//                       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::PolygonType>::get_Item);
			//               v54 = v9.fields.Vertices;
			//               if ( !v54 )
			//                 goto LABEL_89;
			//               if ( v50 >= v54.max_length.size
			//                 || (v55 = v54.vector[v50],
			//                     v87 = v55,
			//                     v45 = v9.fields.Vertices,
			//                     j = index[0],
			//                     index[0] >= (unsigned int)v45.max_length.size) )
			//               {
			//                 sub_180070260(j, v45, v52, v53);
			//               }
			//               *(_QWORD *)index = v45.vector[index[0]];
			//               if ( Item != 2 )
			//               {
			//                 sub_1822AD140((List_1_System_Object_ *)v47, (Object *)v55);
			//                 v56 = Item;
			//                 if ( Item == 1 )
			//                   goto LABEL_52;
			//                 v55 = v87;
			//               }
			//               sub_1822AD140((List_1_System_Object_ *)v49, (Object *)v55);
			//               v56 = Item;
			// LABEL_52:
			//               j = v56 | v88;
			//               if ( (_DWORD)j == 3 )
			//               {
			//                 if ( !v87 )
			//                   goto LABEL_89;
			//                 v91 = *(_QWORD *)&v87.fields.Position.x;
			//                 ex = *(Il2CppException **)&v10.m_Normal.x;
			//                 j = *(_QWORD *)index;
			//                 if ( !*(_QWORD *)index )
			//                   goto LABEL_89;
			//                 v90 = *(_QWORD *)&v87.fields.Position.x;
			//                 v89 = *(_QWORD *)(*(_QWORD *)index + 16LL);
			//                 v57 = *(float *)(*(_QWORD *)index + 24LL) - v87.fields.Position.z;
			//                 *(_QWORD *)&v81.m_Normal.x = *(_QWORD *)&v10.m_Normal.x;
			//                 v58 = (Object *)HG::Rendering::Runtime::CSG::CSGVertex::Interpolate(
			//                                   v87,
			//                                   *(CSGVertex **)index,
			//                                   (float)((float)-v10.m_Distance
			//                                         - (float)((float)((float)(*((float *)&v91 + 1) * *((float *)&ex + 1))
			//                                                         + (float)(*(float *)&v91 * *(float *)&ex))
			//                                                 + (float)(v87.fields.Position.z * v10.m_Normal.z)))
			//                                 / (float)((float)((float)(v81.m_Normal.x * (float)(*(float *)&v89 - *(float *)&v90))
			//                                                 + (float)(v81.m_Normal.y
			//                                                         * (float)(*((float *)&v89 + 1) - *((float *)&v90 + 1))))
			//                                         + (float)(v10.m_Normal.z * v57)),
			//                                   0LL);
			//                 sub_1822AD140(*(List_1_System_Object_ **)&m_Normal.x, v58);
			//                 sub_1822AD140((List_1_System_Object_ *)v49, v58);
			//                 v47 = *(List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ **)&m_Normal.x;
			//               }
			//               ++v50;
			//             }
			//           }
			//         }
			//       }
			//     }
			//     sub_1801E36E0(&ex);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4588, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v76, v75);
			//   v81 = *v10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1318(
			//     Patch,
			//     &v81,
			//     (Object *)v9,
			//     v8,
			//     v7,
			//     (Object *)front,
			//     (Object *)back,
			//     0LL);
			// }
			// 
		}

		public static void ToTriangleList<V, I>(this ICsgProvider tree, Func<Vector3, Vector2, int, int, V> positionNormalToVertex, Func<V, I> insertVertex, Action<I, I, I, PostionUVPair> createTriangle)
		{
		}

		public static void ToListLine<V, I>(this ICsgProvider tree, Func<Vector3, Vector3, V> positionNormalToVertex, Func<V, I> insertVertex, Action<I, I> createLine)
		{
		}

		public static bool IsEmpty<T>(this IEnumerable<T> e)
		{
			return default(bool);
		}

		public static Nullable<float> Intersects(this Ray ray, BSP bsp)
		{
			// // Nullable`1[Single] Intersects(Ray, BSP)
			// Nullable_1_Single_ HG::Rendering::Runtime::CSG::Extensions::Intersects(Ray *ray, BSP *bsp, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // xmm1_8
			//   Ray v11; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4740, 0LL) )
			//   {
			//     if ( bsp )
			//     {
			//       v7 = *(_QWORD *)&ray.m_Direction.y;
			//       *(_OWORD *)&v11.m_Origin.x = *(_OWORD *)&ray.m_Origin.x;
			//       *(_QWORD *)&v11.m_Direction.y = v7;
			//       return HG::Rendering::Runtime::CSG::BSP::RayCast(bsp, &v11, 0LL);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4740, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v10 = *(_QWORD *)&ray.m_Direction.y;
			//   *(_OWORD *)&v11.m_Origin.x = *(_OWORD *)&ray.m_Origin.x;
			//   *(_QWORD *)&v11.m_Direction.y = v10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1365(Patch, &v11, (Object *)bsp, 0LL);
			// }
			// 
			return null;
		}

		public static float Distance(this Vector3 point, Plane plane)
		{
			// // Single Distance(Vector3, Plane)
			// float HG::Rendering::Runtime::CSG::Extensions::Distance(Vector3 *point, Plane *plane, MethodInfo *method)
			// {
			//   MethodInfo *v5; // r8
			//   float v6; // eax
			//   __int64 v7; // xmm0_8
			//   float v8; // eax
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Plane v12; // xmm0
			//   float z; // eax
			//   Plane v14; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v15[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4589, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4589, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     v12 = *plane;
			//     z = point.z;
			//     *(_QWORD *)&v15[0].x = *(_QWORD *)&point.x;
			//     v14 = v12;
			//     v15[0].z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1313(Patch, v15, &v14, 0LL);
			//   }
			//   else
			//   {
			//     v6 = point.z;
			//     *(_QWORD *)&v14.m_Normal.x = *(_QWORD *)&point.x;
			//     v7 = *(_QWORD *)&plane.m_Normal.x;
			//     v14.m_Normal.z = v6;
			//     v8 = plane.m_Normal.z;
			//     *(_QWORD *)&v15[0].x = v7;
			//     v15[0].z = v8;
			//     return UnityEngine::Vector3::Dot(v15, &v14.m_Normal, v5) + plane.m_Distance;
			//   }
			// }
			// 
			return 0f;
		}

		public static Bounds IncludePoint(this Bounds bound, Vector3 point)
		{
			// // Bounds IncludePoint(Bounds, Vector3)
			// Bounds *HG::Rendering::Runtime::CSG::Extensions::IncludePoint(
			//         Bounds *__return_ptr retstr,
			//         Bounds *bound,
			//         Vector3 *point,
			//         MethodInfo *method)
			// {
			//   __m128 x_low; // xmm6
			//   __m128 v8; // xmm0
			//   __m128 v9; // xmm10
			//   __m128 y_low; // xmm0
			//   __m128 v11; // xmm9
			//   Vector3 *min; // rax
			//   float v13; // xmm8_4
			//   __m128 v14; // xmm0
			//   __m128 v15; // xmm7
			//   __int128 v16; // xmm0
			//   __m128 v17; // xmm6
			//   Vector3 *max; // rax
			//   __int128 v19; // xmm0
			//   __int64 v20; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v22; // rcx
			//   __int64 v23; // xmm1_8
			//   float z; // eax
			//   __int128 v25; // xmm0
			//   Bounds *v26; // rax
			//   Bounds *result; // rax
			//   Bounds v28; // [rsp+38h] [rbp-49h] BYREF
			//   Vector3 v29; // [rsp+58h] [rbp-29h] BYREF
			//   Bounds v30[4]; // [rsp+68h] [rbp-19h] BYREF
			// 
			//   if ( !byte_18D919D17 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919D17 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4459, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4459, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v22, 0LL);
			//     v23 = *(_QWORD *)&bound.m_Extents.y;
			//     z = point.z;
			//     *(_QWORD *)&v29.x = *(_QWORD *)&point.x;
			//     v25 = *(_OWORD *)&bound.m_Center.x;
			//     v29.z = z;
			//     *(_QWORD *)&v28.m_Extents.y = v23;
			//     *(_OWORD *)&v28.m_Center.x = v25;
			//     v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1280(v30, Patch, &v28, &v29, 0LL);
			//     v19 = *(_OWORD *)&v26.m_Center.x;
			//     v20 = *(_QWORD *)&v26.m_Extents.y;
			//   }
			//   else
			//   {
			//     x_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v29, bound, 0LL).x);
			//     sub_180002C70(TypeInfo::System::Math);
			//     v8 = x_low;
			//     v8.m128_f32[0] = System::Math::Min(x_low.m128_f32[0], point.x, 0LL);
			//     v9 = v8;
			//     y_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v29, bound, 0LL).y);
			//     y_low.m128_f32[0] = System::Math::Min(y_low.m128_f32[0], point.y, 0LL);
			//     v11 = y_low;
			//     min = UnityEngine::Bounds::get_min(&v29, bound, 0LL);
			//     v13 = System::Math::Min(min.z, point.z, 0LL);
			//     v14 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v29, bound, 0LL).x);
			//     v14.m128_f32[0] = System::Math::Max(v14.m128_f32[0], point.x, 0LL);
			//     v15 = v14;
			//     v16 = LODWORD(UnityEngine::Bounds::get_max(&v29, bound, 0LL).y);
			//     *(float *)&v16 = System::Math::Max(*(float *)&v16, point.y, 0LL);
			//     v17 = (__m128)v16;
			//     max = UnityEngine::Bounds::get_max(&v29, bound, 0LL);
			//     *(float *)&v16 = System::Math::Max(max.z, point.z, 0LL);
			//     *(_QWORD *)&v28.m_Center.x = _mm_unpacklo_ps(v15, v17).m128_u64[0];
			//     *(_QWORD *)&v29.x = _mm_unpacklo_ps(v9, v11).m128_u64[0];
			//     LODWORD(v28.m_Center.z) = v16;
			//     v29.z = v13;
			//     UnityEngine::Bounds::SetMinMax(bound, &v29, &v28.m_Center, 0LL);
			//     v19 = *(_OWORD *)&bound.m_Center.x;
			//     v20 = *(_QWORD *)&bound.m_Extents.y;
			//   }
			//   result = retstr;
			//   *(_OWORD *)&retstr.m_Center.x = v19;
			//   *(_QWORD *)&retstr.m_Extents.y = v20;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Bounds Transform(this Bounds bound, Matrix4x4 transform)
		{
			// // Bounds Transform(Bounds, Matrix4x4)
			// // Hidden C++ exception states: #wind=1
			// Bounds *HG::Rendering::Runtime::CSG::Extensions::Transform(
			//         Bounds *__return_ptr retstr,
			//         Bounds *bound,
			//         Matrix4x4 *transform,
			//         MethodInfo *method)
			// {
			//   Bounds *v6; // rdi
			//   Object *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   Object *v12; // r14
			//   IEnumerable_1_UnityEngine_Vector3_ *v13; // rsi
			//   Vector3 *min; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   float z; // r15d
			//   __m128 x_low; // xmm6
			//   __m128 y_low; // xmm7
			//   float v20; // xmm8_4
			//   __m128 v21; // xmm6
			//   __m128 v22; // xmm7
			//   float v23; // xmm8_4
			//   __m128 v24; // xmm6
			//   __m128 v25; // xmm7
			//   float v26; // xmm8_4
			//   Vector3 *max; // rax
			//   float v28; // r15d
			//   __m128 v29; // xmm6
			//   __m128 v30; // xmm7
			//   float v31; // xmm8_4
			//   __m128 v32; // xmm6
			//   __m128 v33; // xmm7
			//   float v34; // xmm8_4
			//   __m128 v35; // xmm6
			//   __m128 v36; // xmm7
			//   float v37; // xmm8_4
			//   Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *v38; // rax
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *v41; // rbx
			//   IEnumerable_1_UnityEngine_Vector3_ *v42; // rbx
			//   IEnumerable_1_UnityEngine_Vector3_ *v43; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __int64 v50; // rax
			//   __int64 v51; // xmm8_8
			//   float v52; // ebx
			//   Bounds *v53; // rax
			//   __int128 v54; // xmm7
			//   __int64 v55; // xmm6_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   Il2CppException *ex; // [rsp+30h] [rbp-118h] BYREF
			//   __int64 *v61; // [rsp+38h] [rbp-110h]
			//   Vector3 v62; // [rsp+40h] [rbp-108h] BYREF
			//   __int64 v63; // [rsp+50h] [rbp-F8h] BYREF
			//   Bounds v64; // [rsp+58h] [rbp-F0h] BYREF
			//   Vector3 v65; // [rsp+70h] [rbp-D8h] BYREF
			//   Bounds v66; // [rsp+80h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v67; // [rsp+A0h] [rbp-A8h] BYREF
			//   Bounds v68; // [rsp+A8h] [rbp-A0h] BYREF
			//   Matrix4x4 v69; // [rsp+C0h] [rbp-88h] BYREF
			// 
			//   v6 = retstr;
			//   if ( !byte_18D919D18 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::First<UnityEngine::Vector3>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Skip<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::CSG::Extensions::__c__DisplayClass13_0::_Transform_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions::__c__DisplayClass13_0);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D919D18 = 1;
			//   }
			//   memset(&v64, 0, sizeof(v64));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4723, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4723, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v58, v57);
			//     v69 = *transform;
			//     v66 = *bound;
			//     *v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1356(&v68, Patch, &v66, &v69, 0LL);
			//   }
			//   else
			//   {
			//     v7 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::Extensions::__c__DisplayClass13_0);
			//     v12 = v7;
			//     if ( !v7 )
			//       sub_180B536AC(v9, v8);
			//     v7[1] = *(Object *)&transform.m00;
			//     v7[2] = *(Object *)&transform.m01;
			//     v7[3] = *(Object *)&transform.m02;
			//     v7[4] = *(Object *)&transform.m03;
			//     v13 = (IEnumerable_1_UnityEngine_Vector3_ *)il2cpp_array_new_specific_0(
			//                                                   TypeInfo::UnityEngine::Vector3,
			//                                                   8LL,
			//                                                   v10,
			//                                                   v11);
			//     min = UnityEngine::Bounds::get_min(&v62, bound, 0LL);
			//     z = min.z;
			//     if ( !v13 )
			//       sub_180B536AC(v16, v15);
			//     ex = *(Il2CppException **)&min.x;
			//     *(float *)&v61 = z;
			//     sub_180040FA0(v13, 0LL, &ex);
			//     x_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).x);
			//     y_low = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).y);
			//     v20 = UnityEngine::Bounds::get_max(&v62, bound, 0LL).z;
			//     ex = (Il2CppException *)_mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//     *(float *)&v61 = v20;
			//     sub_180040FA0(v13, 1LL, &ex);
			//     v21 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).x);
			//     v22 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v62, bound, 0LL).y);
			//     v23 = UnityEngine::Bounds::get_min(&v62, bound, 0LL).z;
			//     ex = (Il2CppException *)_mm_unpacklo_ps(v21, v22).m128_u64[0];
			//     *(float *)&v61 = v23;
			//     sub_180040FA0(v13, 2LL, &ex);
			//     v24 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).x);
			//     v25 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v62, bound, 0LL).y);
			//     v26 = UnityEngine::Bounds::get_max(&v62, bound, 0LL).z;
			//     ex = (Il2CppException *)_mm_unpacklo_ps(v24, v25).m128_u64[0];
			//     *(float *)&v61 = v26;
			//     sub_180040FA0(v13, 3LL, &ex);
			//     max = UnityEngine::Bounds::get_max(&v62, bound, 0LL);
			//     v28 = max.z;
			//     ex = *(Il2CppException **)&max.x;
			//     *(float *)&v61 = v28;
			//     sub_180040FA0(v13, 4LL, &ex);
			//     v29 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v62, bound, 0LL).x);
			//     v30 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).y);
			//     v31 = UnityEngine::Bounds::get_max(&v62, bound, 0LL).z;
			//     ex = (Il2CppException *)_mm_unpacklo_ps(v29, v30).m128_u64[0];
			//     *(float *)&v61 = v31;
			//     sub_180040FA0(v13, 5LL, &ex);
			//     v32 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v62, bound, 0LL).x);
			//     v33 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).y);
			//     v34 = UnityEngine::Bounds::get_min(&v62, bound, 0LL).z;
			//     ex = (Il2CppException *)_mm_unpacklo_ps(v32, v33).m128_u64[0];
			//     *(float *)&v61 = v34;
			//     sub_180040FA0(v13, 6LL, &ex);
			//     v35 = (__m128)LODWORD(UnityEngine::Bounds::get_max(&v62, bound, 0LL).x);
			//     v36 = (__m128)LODWORD(UnityEngine::Bounds::get_min(&v62, bound, 0LL).y);
			//     v37 = UnityEngine::Bounds::get_min(&v62, bound, 0LL).z;
			//     ex = (Il2CppException *)_mm_unpacklo_ps(v35, v36).m128_u64[0];
			//     *(float *)&v61 = v37;
			//     sub_180040FA0(v13, 7LL, &ex);
			//     v38 = (Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *)sub_180004920(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector3>);
			//     v41 = v38;
			//     if ( !v38 )
			//       sub_180B536AC(v40, v39);
			//     System::Func<UnityEngine::Vector3,UnityEngine::Vector3>::Func(
			//       v38,
			//       v12,
			//       MethodInfo::HG::Rendering::Runtime::CSG::Extensions::__c__DisplayClass13_0::_Transform_b__0[0],
			//       0LL);
			//     v42 = System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>(
			//             v13,
			//             v41,
			//             MethodInfo::System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>);
			//     System::Linq::Enumerable::First<UnityEngine::Vector3>(
			//       &v65,
			//       v42,
			//       MethodInfo::System::Linq::Enumerable::First<UnityEngine::Vector3>);
			//     System::Linq::Enumerable::First<UnityEngine::Vector3>(
			//       (Vector3 *)&ex,
			//       v42,
			//       MethodInfo::System::Linq::Enumerable::First<UnityEngine::Vector3>);
			//     *(_QWORD *)&v62.x = ex;
			//     LODWORD(v62.z) = (_DWORD)v61;
			//     ex = *(Il2CppException **)&v65.x;
			//     *(float *)&v61 = v65.z;
			//     UnityEngine::Bounds::Bounds(&v64, (Vector3 *)&ex, &v62, 0LL);
			//     v43 = System::Linq::Enumerable::Skip<UnityEngine::Vector3>(
			//             v42,
			//             1,
			//             MethodInfo::System::Linq::Enumerable::Skip<UnityEngine::Vector3>);
			//     if ( !v43 )
			//       sub_180B536AC(v45, v44);
			//     v63 = sub_1800513A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector3>, v43);
			//     ex = 0LL;
			//     v61 = &v63;
			//     try
			//     {
			//       v55 = *(_QWORD *)&v64.m_Extents.y;
			//       v54 = *(_OWORD *)&v64.m_Center.x;
			//       while ( 1 )
			//       {
			//         if ( !v63 )
			//           sub_1802DC2C8(v47, v46);
			//         if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//           break;
			//         if ( !v63 )
			//           sub_1802DC2C8(v49, v48);
			//         v50 = sub_1801F9C08(&v65, 0LL, TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector3>, v63);
			//         v51 = *(_QWORD *)v50;
			//         v52 = *(float *)(v50 + 8);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//         *(_QWORD *)&v62.x = v51;
			//         v62.z = v52;
			//         *(_OWORD *)&v66.m_Center.x = v54;
			//         *(_QWORD *)&v66.m_Extents.y = v55;
			//         v53 = HG::Rendering::Runtime::CSG::Extensions::IncludePoint(&v68, &v66, &v62, 0LL);
			//         v54 = *(_OWORD *)&v53.m_Center.x;
			//         *(_OWORD *)&v64.m_Center.x = *(_OWORD *)&v53.m_Center.x;
			//         v55 = *(_QWORD *)&v53.m_Extents.y;
			//         *(_QWORD *)&v64.m_Extents.y = v55;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v67 )
			//     {
			//       ex = v67.ex;
			//       sub_1801E4D90(&ex);
			//       v6 = retstr;
			//       v55 = *(_QWORD *)&v64.m_Extents.y;
			//       v54 = *(_OWORD *)&v64.m_Center.x;
			//       goto LABEL_14;
			//     }
			//     sub_1801E4D90(&ex);
			// LABEL_14:
			//     *(_OWORD *)&v6.m_Center.x = v54;
			//     *(_QWORD *)&v6.m_Extents.y = v55;
			//   }
			//   return v6;
			// }
			// 
			return null;
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> start, IEnumerable<T> end)
		{
			return null;
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> start, params T[] end)
		{
			return null;
		}

		[IDTag(0)]
		public static Vector3 Transform(this Vector3 vector, Matrix4x4 transform)
		{
			// // Vector3 Transform(Vector3, Matrix4x4)
			// Vector3 *HG::Rendering::Runtime::CSG::Extensions::Transform(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *vector,
			//         Matrix4x4 *transform,
			//         MethodInfo *method)
			// {
			//   __m128 v7; // xmm0
			//   MethodInfo *v8; // r9
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm6_8
			//   float v11; // ebx
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   Vector3 *v16; // rax
			//   float m22; // xmm2_4
			//   MethodInfo *v18; // r8
			//   float v19; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v21; // rcx
			//   float z; // eax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   Vector3 *v26; // rax
			//   Quaternion v28; // [rsp+38h] [rbp-29h] BYREF
			//   Vector3 v29; // [rsp+48h] [rbp-19h] BYREF
			//   Quaternion v30; // [rsp+58h] [rbp-9h] BYREF
			//   Matrix4x4 v31; // [rsp+68h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919D19 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     byte_18D919D19 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4720, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4720, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, 0LL);
			//     z = vector.z;
			//     v23 = *(_OWORD *)&transform.m01;
			//     *(_OWORD *)&v31.m00 = *(_OWORD *)&transform.m00;
			//     v24 = *(_OWORD *)&transform.m02;
			//     v29.z = z;
			//     *(_OWORD *)&v31.m01 = v23;
			//     v25 = *(_OWORD *)&transform.m03;
			//     *(_OWORD *)&v31.m02 = v24;
			//     *(_QWORD *)&v29.x = *(_QWORD *)&vector.x;
			//     *(_OWORD *)&v31.m03 = v25;
			//     v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1355((Vector3 *)&v30, Patch, &v29, &v31, 0LL);
			//     *(_QWORD *)&v24 = *(_QWORD *)&v26.x;
			//     v19 = v26.z;
			//     *(_QWORD *)&retstr.x = v24;
			//   }
			//   else
			//   {
			//     v7 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v30, transform, 3, 0LL));
			//     v29.z = vector.z;
			//     *(_QWORD *)&v28.x = _mm_unpacklo_ps(v7, _mm_shuffle_ps(v7, v7, 85)).m128_u64[0];
			//     *(_QWORD *)&v29.x = *(_QWORD *)&vector.x;
			//     LODWORD(v28.z) = _mm_shuffle_ps(v7, v7, 170).m128_u32[0];
			//     v9 = UnityEngine::Vector3::op_Addition((Vector3 *)&v30, &v29, (Vector3 *)&v28, v8);
			//     v10 = *(_QWORD *)&v9.x;
			//     v11 = v9.z;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     v12 = *(_OWORD *)&transform.m00;
			//     v13 = *(_OWORD *)&transform.m01;
			//     v29.z = v11;
			//     *(_OWORD *)&v31.m00 = v12;
			//     v14 = *(_OWORD *)&transform.m02;
			//     *(_OWORD *)&v31.m01 = v13;
			//     v15 = *(_OWORD *)&transform.m03;
			//     *(_OWORD *)&v31.m02 = v14;
			//     *(_OWORD *)&v31.m03 = v15;
			//     *(_QWORD *)&v29.x = v10;
			//     v28 = *HG::Rendering::Runtime::CSG::Extensions::QuaternionFromMatrix(&v30, &v31, 0LL);
			//     v16 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v30, &v28, &v29, 0LL);
			//     *(_QWORD *)&v14 = *(_QWORD *)&v16.x;
			//     m22 = transform.m22;
			//     *(float *)&v16 = v16.z;
			//     *(_QWORD *)&v29.x = _mm_unpacklo_ps(*(__m128 *)&transform.m00, (__m128)LODWORD(transform.m11)).m128_u64[0];
			//     v29.z = m22;
			//     *(_QWORD *)&v28.x = v14;
			//     LODWORD(v28.z) = (_DWORD)v16;
			//     UnityEngine::Vector3::Scale((Vector3 *)&v28, &v29, v18);
			//     v19 = v28.z;
			//     *(_QWORD *)&retstr.x = *(_QWORD *)&v28.x;
			//   }
			//   retstr.z = v19;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 Transform(this Vector3 vector, Vector3 pos, Quaternion rotation, Vector3 scale)
		{
			// // Vector3 Transform(Vector3, Vector3, Quaternion, Vector3)
			// Vector3 *HG::Rendering::Runtime::CSG::Extensions::Transform(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *vector,
			//         Vector3 *pos,
			//         Quaternion *rotation,
			//         Vector3 *scale,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v10; // r9
			//   float v11; // eax
			//   __int64 v12; // xmm0_8
			//   float v13; // eax
			//   Vector3 *v14; // rax
			//   Quaternion v15; // xmm0
			//   __int64 v16; // xmm3_8
			//   Vector3 *v17; // rax
			//   MethodInfo *v18; // r8
			//   float v19; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // xmm0_8
			//   float z; // eax
			//   Quaternion v24; // xmm0
			//   Vector3 *v25; // rax
			//   Vector3 v27; // [rsp+48h] [rbp-9h] BYREF
			//   Vector3 v28; // [rsp+58h] [rbp+7h] BYREF
			//   Vector3 v29; // [rsp+68h] [rbp+17h] BYREF
			//   Quaternion v30; // [rsp+78h] [rbp+27h] BYREF
			//   Quaternion v31; // [rsp+88h] [rbp+37h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4741, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4741, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, 0LL);
			//     *(_QWORD *)&v27.x = *(_QWORD *)&pos.x;
			//     v22 = *(_QWORD *)&scale.x;
			//     v28.z = scale.z;
			//     v27.z = pos.z;
			//     z = vector.z;
			//     *(_QWORD *)&v28.x = v22;
			//     v24 = *rotation;
			//     v29.z = z;
			//     v31 = v24;
			//     *(_QWORD *)&v29.x = *(_QWORD *)&vector.x;
			//     v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1366((Vector3 *)&v30, Patch, &v29, &v27, &v31, &v28, 0LL);
			//     *(_QWORD *)&v24.x = *(_QWORD *)&v25.x;
			//     v19 = v25.z;
			//     *(_QWORD *)&retstr.x = *(_QWORD *)&v24.x;
			//   }
			//   else
			//   {
			//     v11 = pos.z;
			//     *(_QWORD *)&v27.x = *(_QWORD *)&pos.x;
			//     v12 = *(_QWORD *)&vector.x;
			//     v27.z = v11;
			//     v13 = vector.z;
			//     *(_QWORD *)&v28.x = v12;
			//     v28.z = v13;
			//     v14 = UnityEngine::Vector3::op_Addition(&v29, &v28, &v27, v10);
			//     v15 = *rotation;
			//     v16 = *(_QWORD *)&v14.x;
			//     *(float *)&v14 = v14.z;
			//     *(_QWORD *)&v28.x = v16;
			//     LODWORD(v28.z) = (_DWORD)v14;
			//     v30 = v15;
			//     v17 = UnityEngine::Quaternion::op_Multiply(&v29, &v30, &v28, 0LL);
			//     *(_QWORD *)&v15.x = *(_QWORD *)&v17.x;
			//     v27.z = v17.z;
			//     *(_QWORD *)&v27.x = *(_QWORD *)&v15.x;
			//     *(float *)&v17 = scale.z;
			//     *(_QWORD *)&v28.x = *(_QWORD *)&scale.x;
			//     LODWORD(v28.z) = (_DWORD)v17;
			//     UnityEngine::Vector3::Scale(&v27, &v28, v18);
			//     v19 = v27.z;
			//     *(_QWORD *)&retstr.x = *(_QWORD *)&v27.x;
			//   }
			//   retstr.z = v19;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 TransformNormal(this Vector3 vector, Vector3 pos, Quaternion rotation, Vector3 scale)
		{
			// // Vector3 TransformNormal(Vector3, Vector3, Quaternion, Vector3)
			// Vector3 *HG::Rendering::Runtime::CSG::Extensions::TransformNormal(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *vector,
			//         Vector3 *pos,
			//         Quaternion *rotation,
			//         Vector3 *scale,
			//         MethodInfo *method)
			// {
			//   __m128 y_low; // xmm6
			//   float v11; // xmm7_4
			//   __int64 v12; // xmm1_8
			//   float v13; // eax
			//   Quaternion v14; // xmm0
			//   float v15; // eax
			//   Vector3 *v16; // rax
			//   Vector3 *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // xmm0_8
			//   float z; // eax
			//   Quaternion v22; // xmm0
			//   __int64 v23; // xmm0_8
			//   float v24; // eax
			//   Vector3 v26; // [rsp+48h] [rbp-29h] BYREF
			//   Vector3 v27; // [rsp+58h] [rbp-19h] BYREF
			//   Vector3 v28; // [rsp+68h] [rbp-9h] BYREF
			//   Vector3 v29; // [rsp+78h] [rbp+7h] BYREF
			//   Quaternion v30[3]; // [rsp+88h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919D1A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     byte_18D919D1A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4742, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4742, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v19, 0LL);
			//     *(_QWORD *)&v27.x = *(_QWORD *)&pos.x;
			//     v20 = *(_QWORD *)&scale.x;
			//     v28.z = scale.z;
			//     v27.z = pos.z;
			//     z = vector.z;
			//     *(_QWORD *)&v28.x = v20;
			//     v22 = *rotation;
			//     v26.z = z;
			//     v30[0] = v22;
			//     *(_QWORD *)&v26.x = *(_QWORD *)&vector.x;
			//     v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1366(&v29, Patch, &v26, &v27, v30, &v28, 0LL);
			//   }
			//   else
			//   {
			//     y_low = (__m128)LODWORD(vector.y);
			//     v11 = vector.z;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     v12 = *(_QWORD *)&pos.x;
			//     v28.z = v11;
			//     v13 = scale.z;
			//     *(_QWORD *)&v26.x = *(_QWORD *)&scale.x;
			//     v14 = *rotation;
			//     v26.z = v13;
			//     v15 = pos.z;
			//     v30[0] = v14;
			//     v27.z = v15;
			//     *(_QWORD *)&v28.x = _mm_unpacklo_ps((__m128)LODWORD(vector.x), y_low).m128_u64[0];
			//     *(_QWORD *)&v27.x = v12;
			//     v16 = HG::Rendering::Runtime::CSG::Extensions::Transform(&v29, &v28, &v27, v30, &v26, 0LL);
			//     *(_QWORD *)&v14.x = *(_QWORD *)&v16.x;
			//     *(float *)&v16 = v16.z;
			//     *(_QWORD *)&v28.x = *(_QWORD *)&v14.x;
			//     LODWORD(v28.z) = (_DWORD)v16;
			//     v17 = (Vector3 *)sub_182413270(&v29, &v28);
			//   }
			//   v23 = *(_QWORD *)&v17.x;
			//   v24 = v17.z;
			//   *(_QWORD *)&retstr.x = v23;
			//   retstr.z = v24;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 TransformNormal(this Vector3 vector, Matrix4x4 transform)
		{
			// // Vector3 TransformNormal(Vector3, Matrix4x4)
			// Vector3 *HG::Rendering::Runtime::CSG::Extensions::TransformNormal(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *vector,
			//         Matrix4x4 *transform,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   Vector3 *v11; // rax
			//   Vector3 *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v14; // rcx
			//   float z; // eax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int64 v19; // xmm0_8
			//   float v20; // eax
			//   Vector3 v22; // [rsp+38h] [rbp-9h] BYREF
			//   Vector3 v23; // [rsp+48h] [rbp+7h] BYREF
			//   Matrix4x4 v24; // [rsp+58h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919D1B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     byte_18D919D1B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4722, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4722, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, 0LL);
			//     z = vector.z;
			//     v16 = *(_OWORD *)&transform.m01;
			//     *(_OWORD *)&v24.m00 = *(_OWORD *)&transform.m00;
			//     v17 = *(_OWORD *)&transform.m02;
			//     v22.z = z;
			//     *(_OWORD *)&v24.m01 = v16;
			//     v18 = *(_OWORD *)&transform.m03;
			//     *(_OWORD *)&v24.m02 = v17;
			//     *(_QWORD *)&v22.x = *(_QWORD *)&vector.x;
			//     *(_OWORD *)&v24.m03 = v18;
			//     v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1355(&v23, Patch, &v22, &v24, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     v7 = *(_OWORD *)&transform.m00;
			//     v8 = *(_OWORD *)&transform.m01;
			//     v22.z = vector.z;
			//     *(_OWORD *)&v24.m00 = v7;
			//     v9 = *(_OWORD *)&transform.m02;
			//     *(_OWORD *)&v24.m01 = v8;
			//     v10 = *(_OWORD *)&transform.m03;
			//     *(_OWORD *)&v24.m02 = v9;
			//     *(_QWORD *)&v22.x = *(_QWORD *)&vector.x;
			//     *(_OWORD *)&v24.m03 = v10;
			//     v11 = HG::Rendering::Runtime::CSG::Extensions::Transform(&v23, &v22, &v24, 0LL);
			//     *(_QWORD *)&v9 = *(_QWORD *)&v11.x;
			//     *(float *)&v11 = v11.z;
			//     *(_QWORD *)&v22.x = v9;
			//     LODWORD(v22.z) = (_DWORD)v11;
			//     v12 = (Vector3 *)sub_182413270(&v23, &v22);
			//   }
			//   v19 = *(_QWORD *)&v12.x;
			//   v20 = v12.z;
			//   *(_QWORD *)&retstr.x = v19;
			//   retstr.z = v20;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
		{
			// // Quaternion QuaternionFromMatrix(Matrix4x4)
			// Quaternion *HG::Rendering::Runtime::CSG::Extensions::QuaternionFromMatrix(
			//         Quaternion *__return_ptr retstr,
			//         Matrix4x4 *m,
			//         MethodInfo *method)
			// {
			//   float3 *v5; // rdx
			//   float3 *v6; // rcx
			//   float3 *v7; // r8
			//   float3 *v8; // r9
			//   float3 *v9; // rdx
			//   float3 *v10; // rcx
			//   float3 *v11; // r8
			//   float3 *v12; // r9
			//   float v13; // xmm9_4
			//   float3 *v14; // rdx
			//   float3 *v15; // rcx
			//   float3 *v16; // r8
			//   float3 *v17; // r9
			//   float v18; // xmm8_4
			//   float Item; // xmm7_4
			//   float v20; // xmm6_4
			//   float3 *v21; // rdx
			//   float3 *v22; // rcx
			//   float3 *v23; // r8
			//   float3 *v24; // r9
			//   float v25; // xmm7_4
			//   float v26; // xmm0_4
			//   float v27; // xmm6_4
			//   MethodInfo *v28; // rdx
			//   float v29; // xmm0_4
			//   float v30; // xmm6_4
			//   MethodInfo *v31; // rdx
			//   float v32; // xmm6_4
			//   float v33; // xmm0_4
			//   MethodInfo *v34; // rdx
			//   Quaternion v35; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   Quaternion *result; // rax
			//   Quaternion v43; // [rsp+28h] [rbp-59h] BYREF
			//   Matrix4x4 v44; // [rsp+38h] [rbp-49h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4721, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4721, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v38, v37);
			//     v39 = *(_OWORD *)&m.m01;
			//     *(_OWORD *)&v44.m00 = *(_OWORD *)&m.m00;
			//     v40 = *(_OWORD *)&m.m02;
			//     *(_OWORD *)&v44.m01 = v39;
			//     v41 = *(_OWORD *)&m.m03;
			//     *(_OWORD *)&v44.m02 = v40;
			//     *(_OWORD *)&v44.m03 = v41;
			//     v35 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1354(&v43, Patch, &v44, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
			//     UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
			//     UnityEngine::Matrix4x4::get_Item(m, 10, 0LL);
			//     v43.w = sub_1802ECED0(v6, v5, v7, v8) * 0.5;
			//     UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
			//     UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
			//     UnityEngine::Matrix4x4::get_Item(m, 10, 0LL);
			//     v13 = sub_1802ECED0(v10, v9, v11, v12) * 0.5;
			//     UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
			//     UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
			//     UnityEngine::Matrix4x4::get_Item(m, 10, 0LL);
			//     v18 = sub_1802ECED0(v15, v14, v16, v17) * 0.5;
			//     Item = UnityEngine::Matrix4x4::get_Item(m, 0, 0LL);
			//     v20 = UnityEngine::Matrix4x4::get_Item(m, 5, 0LL);
			//     fmaxf(0.0, UnityEngine::Matrix4x4::get_Item(m, 10, 0LL) + (float)((float)(1.0 - Item) - v20));
			//     v25 = sub_1802ECED0(v22, v21, v23, v24) * 0.5;
			//     v26 = UnityEngine::Matrix4x4::get_Item(m, 6, 0LL);
			//     v27 = (float)(v26 - UnityEngine::Matrix4x4::get_Item(m, 9, 0LL)) * v13;
			//     v43.x = UnityEngine::Mathf::Sign(v27, v28) * v13;
			//     v29 = UnityEngine::Matrix4x4::get_Item(m, 8, 0LL);
			//     v30 = (float)(v29 - UnityEngine::Matrix4x4::get_Item(m, 2, 0LL)) * v18;
			//     v43.y = UnityEngine::Mathf::Sign(v30, v31) * v18;
			//     v32 = UnityEngine::Matrix4x4::get_Item(m, 1, 0LL);
			//     v33 = UnityEngine::Matrix4x4::get_Item(m, 4, 0LL);
			//     v43.z = UnityEngine::Mathf::Sign((float)(v32 - v33) * v25, v34) * v25;
			//     v35 = v43;
			//   }
			//   result = retstr;
			//   *retstr = v35;
			//   return result;
			// }
			// 
			return null;
		}

		public const float EPSILON = 0.001f;

		public const float Epsilon = 0.001f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static object lock1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static object lock2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static object lock3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static object lock4;
	}
}
