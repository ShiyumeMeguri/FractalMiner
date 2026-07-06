using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class HGWindSimpleManager
	{
		public HGWindSimpleManager()
		{
		}

		public void SetWindFootMotor(int index, Vector3 position, float range)
		{
			// // Void SetWindFootMotor(Int32, Vector3, Single)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGWindSimpleManager::SetWindFootMotor(
			//         HGWindSimpleManager *this,
			//         int32_t index,
			//         Vector3 *position,
			//         float range,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGWindSimpleManager_HGWindFootMotor__Array *m_windFootMotors; // rax
			//   HGWindSimpleManager_HGWindFootMotor *v11; // rcx
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // xmm0_8
			//   Vector3 v15; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   v7 = index;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&index);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v8.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size > 1428 )
			//   {
			//     if ( !v8._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v8, wrapperArray);
			//       v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v8.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_12;
			//     if ( wrapperArray.max_length.size <= 0x594u )
			// LABEL_13:
			//       sub_180070270(v8, wrapperArray);
			//     if ( wrapperArray[39].vector[24] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1428, 0LL);
			//       if ( Patch )
			//       {
			//         v14 = *(_QWORD *)&position.x;
			//         v15.z = position.z;
			//         *(_QWORD *)&v15.x = v14;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_539(Patch, (Object *)this, v7, &v15, range, 0LL);
			//         return;
			//       }
			//       goto LABEL_12;
			//     }
			//   }
			//   if ( (unsigned int)v7 > 3 )
			//     return;
			//   m_windFootMotors = this.fields.m_windFootMotors;
			//   if ( !m_windFootMotors )
			// LABEL_12:
			//     sub_180B536AC(v8, wrapperArray);
			//   if ( (unsigned int)v7 >= m_windFootMotors.max_length.size )
			//     goto LABEL_13;
			//   v11 = &m_windFootMotors.vector[v7];
			//   z = position.z;
			//   *(_QWORD *)&v11.position.x = *(_QWORD *)&position.x;
			//   v11.position.z = z;
			//   v11.range = range;
			// }
			// 
		}

		public void RegisterWindMotor(HGWindMotor wind)
		{
			// // Void RegisterWindMotor(HGWindMotor)
			// void HG::Rendering::Runtime::HGWindSimpleManager::RegisterWindMotor(
			//         HGWindSimpleManager *this,
			//         HGWindMotor *wind,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *v6; // rcx
			//   int32_t windPriority; // ebp
			//   int32_t i; // esi
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
			//   List_1_System_Object_ *v10; // rcx
			//   List_1_System_Object_ *v11; // rbx
			//   Object *v12; // rax
			//   Object *Item; // rax
			//   List_1_System_Object_ *m_windMotorState; // rbx
			//   Object *v15; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCC1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Insert);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Insert);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Item);
			//     byte_18D8EDCC1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1431, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1431, 0LL);
			//     if ( !Patch )
			//       goto LABEL_7;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)wind,
			//       0LL);
			//   }
			//   else if ( this.fields.m_windMotors
			//          && !System::Collections::Generic::List<System::Object>::Contains(
			//                (List_1_System_Object_ *)this.fields.m_windMotors,
			//                (Object *)wind,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Contains) )
			//   {
			//     if ( !wind )
			//       goto LABEL_7;
			//     windPriority = wind.fields.data.windPriority;
			//     for ( i = 0; ; ++i )
			//     {
			//       m_windMotors = this.fields.m_windMotors;
			//       if ( !m_windMotors )
			//         goto LABEL_7;
			//       v10 = (List_1_System_Object_ *)this.fields.m_windMotors;
			//       if ( i >= m_windMotors.fields._size )
			//         break;
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                v10,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Item);
			//       if ( !Item )
			//         goto LABEL_7;
			//       if ( SLODWORD(Item[2].klass) < windPriority )
			//       {
			//         v6 = (List_1_System_Object_ *)this.fields.m_windMotors;
			//         if ( v6 )
			//         {
			//           System::Collections::Generic::List<System::Object>::Insert(
			//             v6,
			//             i,
			//             (Object *)wind,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Insert);
			//           m_windMotorState = (List_1_System_Object_ *)this.fields.m_windMotorState;
			//           v15 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
			//           if ( v15 )
			//           {
			//             if ( m_windMotorState )
			//             {
			//               System::Collections::Generic::List<System::Object>::Insert(
			//                 m_windMotorState,
			//                 i,
			//                 v15,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Insert);
			//               return;
			//             }
			//           }
			//         }
			// LABEL_7:
			//         sub_180B536AC(v6, v5);
			//       }
			//     }
			//     sub_1822AD140(v10, (Object *)wind);
			//     v11 = (List_1_System_Object_ *)this.fields.m_windMotorState;
			//     v12 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
			//     if ( !v12 || !v11 )
			//       goto LABEL_7;
			//     sub_1822AD140(v11, v12);
			//   }
			// }
			// 
		}

		public void UnRegisterWindMotor(HGWindMotor wind)
		{
			// // Void UnRegisterWindMotor(HGWindMotor)
			// void HG::Rendering::Runtime::HGWindSimpleManager::UnRegisterWindMotor(
			//         HGWindSimpleManager *this,
			//         HGWindMotor *wind,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_windMotors; // rcx
			//   int32_t v7; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DD4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::IndexOf);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Remove);
			//     byte_18D919DD4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1433, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1433, 0LL);
			//     if ( !Patch )
			//       goto LABEL_12;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)wind,
			//       0LL);
			//   }
			//   else if ( this.fields.m_windMotors
			//          && System::Collections::Generic::List<System::Object>::Contains(
			//               (List_1_System_Object_ *)this.fields.m_windMotors,
			//               (Object *)wind,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Contains) )
			//   {
			//     m_windMotors = (List_1_System_Object_ *)this.fields.m_windMotors;
			//     if ( m_windMotors )
			//     {
			//       v7 = System::Collections::Generic::List<System::Object>::IndexOf(
			//              m_windMotors,
			//              (Object *)wind,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::IndexOf);
			//       if ( this.fields.m_windMotorState )
			//         System::Collections::Generic::List<System::Object>::RemoveAt(
			//           (List_1_System_Object_ *)this.fields.m_windMotorState,
			//           v7,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::RemoveAt);
			//       m_windMotors = (List_1_System_Object_ *)this.fields.m_windMotors;
			//       if ( m_windMotors )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           m_windMotors,
			//           (Object *)wind,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Remove);
			//         return;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_windMotors, v5);
			//   }
			// }
			// 
		}

		public void GamePlayUpdate(float deltaTime)
		{
			// // Void GamePlayUpdate(Single)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGWindSimpleManager::GamePlayUpdate(
			//         HGWindSimpleManager *this,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   float v4; // xmm2_4
			//   HGWindSimpleManager *v5; // r14
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v8; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   unsigned int i; // edi
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rbx
			//   HGWindMotor__Array *items; // rbx
			//   HGWindMotor *v15; // rax
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v16; // rbx
			//   HGWindMotor__Array *v17; // rbx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v18; // rbx
			//   HGWindMotor__Array *v19; // rbx
			//   HGWindMotor *v20; // r15
			//   __int64 (__fastcall *v21)(HGWindMotor *, __int64, MethodInfo *); // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rbx
			//   void (__fastcall *v25)(__int64, Il2CppException **); // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v28; // rbx
			//   HGWindMotor__Array *v29; // rbx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v30; // rbx
			//   HGWindMotor__Array *v31; // rbx
			//   HGWindMotor *v32; // rbx
			//   __int64 (__fastcall *v33)(HGWindMotor *); // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   __int64 v36; // rbx
			//   void (__fastcall *v37)(__int64, __int64 *); // rax
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v40; // rbx
			//   HGWindMotor__Array *v41; // rbx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v42; // rbx
			//   HGWindMotor__Array *v43; // rbx
			//   HGWindMotor *v44; // rbx
			//   __int64 (__fastcall *v45)(HGWindMotor *); // rax
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   __int64 v48; // rbx
			//   void (__fastcall *v49)(__int64, __int64 *); // rax
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v50; // rbx
			//   HGWindMotor__Array *v51; // rbx
			//   HGWindMotor *v52; // rax
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v53; // rbx
			//   HGWindMotor__Array *v54; // rbx
			//   HGWindMotor *v55; // rbx
			//   __int64 (__fastcall *v56)(HGWindMotor *, __int64, MethodInfo *); // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   __int64 v59; // rbx
			//   void (__fastcall *v60)(__int64, __int64 *); // rax
			//   __int64 v61; // rdx
			//   __int64 v62; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v63; // rbx
			//   HGWindMotor__Array *v64; // rbx
			//   HGWindMotor *v65; // rbx
			//   __int64 (__fastcall *v66)(HGWindMotor *); // rax
			//   __int64 v67; // rdx
			//   __int64 v68; // rcx
			//   __int64 v69; // rbx
			//   float v70; // xmm6_4
			//   void (__fastcall *v71)(__int64, Vector3 *); // rax
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v72; // rbx
			//   HGWindMotor__Array *v73; // rbx
			//   HGWindMotor *v74; // rax
			//   unsigned int v75; // r15d
			//   float gameplayTime; // xmm14_4
			//   HGRenderPathBase_HGRenderPathResources *v77; // rdx
			//   __int64 v78; // rcx
			//   PassConstructorID__Enum__Array *v79; // r8
			//   HGCamera *v80; // r9
			//   float v81; // xmm14_4
			//   float v82; // xmm0_4
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rbx
			//   unsigned __int64 v84; // rdx
			//   __int64 v85; // rcx
			//   unsigned __int64 v86; // r8
			//   signed __int64 v87; // r9
			//   float *value; // rdi
			//   float v89; // xmm6_4
			//   float v90; // xmm7_4
			//   float v91; // xmm8_4
			//   __int64 v92; // xmm9_8
			//   float v93; // esi
			//   __int64 v94; // rbx
			//   void (__fastcall __noreturn **v95)(); // rax
			//   unsigned int v96; // eax
			//   __int64 v97; // rax
			//   unsigned int v98; // r8d
			//   signed __int64 v99; // rtt
			//   __int64 v100; // rbx
			//   __int64 v101; // rax
			//   __int64 v102; // rbx
			//   _QWORD **v103; // rcx
			//   __int64 v104; // r8
			//   __int64 v105; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v106; // rcx
			//   unsigned __int64 v107; // rdx
			//   __int64 v108; // rbx
			//   void (__fastcall __noreturn **v109)(); // rax
			//   unsigned int v110; // eax
			//   __int64 v111; // rax
			//   unsigned int v112; // r8d
			//   signed __int64 v113; // rtt
			//   __int64 v114; // rbx
			//   __int64 v115; // rax
			//   __int64 v116; // rbx
			//   _QWORD **v117; // rcx
			//   __int64 v118; // r8
			//   __int64 v119; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v120; // rcx
			//   ILFixDynamicMethodWrapper_2 *v121; // rcx
			//   Beyond::JobMathf *v122; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v123; // rax
			//   unsigned __int32 v124; // xmm9_4
			//   List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *m_windMotorState; // rax
			//   HGWindSimpleManager_HGWindMotorState__Array *v126; // rbx
			//   HGWindSimpleManager_HGWindMotorState *v127; // rbx
			//   float v128; // xmm6_4
			//   float curWindTime; // xmm0_4
			//   float v130; // xmm0_4
			//   float v131; // xmm0_4
			//   float v132; // xmm0_4
			//   MethodInfo *v133[6]; // [rsp+0h] [rbp-228h] BYREF
			//   Il2CppException *ex; // [rsp+30h] [rbp-1F8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v135; // [rsp+38h] [rbp-1F0h]
			//   __int64 v136; // [rsp+40h] [rbp-1E8h] BYREF
			//   int v137; // [rsp+48h] [rbp-1E0h]
			//   __int64 v138; // [rsp+50h] [rbp-1D8h] BYREF
			//   float v139; // [rsp+58h] [rbp-1D0h]
			//   __int64 v140; // [rsp+60h] [rbp-1C8h] BYREF
			//   int v141; // [rsp+68h] [rbp-1C0h]
			//   Vector3 v142; // [rsp+70h] [rbp-1B8h] BYREF
			//   HGWindMotor *v143; // [rsp+80h] [rbp-1A8h]
			//   HGWindMotor *v144; // [rsp+88h] [rbp-1A0h]
			//   HGWindMotor *v145; // [rsp+B8h] [rbp-170h]
			//   HGWindMotor *v146; // [rsp+D0h] [rbp-158h]
			//   HGWindMotor *v147; // [rsp+E8h] [rbp-140h]
			//   HGWindMotor *v148; // [rsp+F8h] [rbp-130h]
			//   _BYTE v149[40]; // [rsp+108h] [rbp-120h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v150; // [rsp+130h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v151; // [rsp+158h] [rbp-D0h] BYREF
			//   Vector2 v153; // [rsp+248h] [rbp+20h]
			// 
			//   v5 = this;
			//   if ( !byte_18D8EDCC2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::get_Item);
			//     byte_18D8EDCC2 = 1;
			//   }
			//   memset(&v150, 0, sizeof(v150));
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v6, v3);
			//   if ( wrapperArray.max_length.size <= 1435 )
			//     goto LABEL_17;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, v3);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = v6.static_fields.wrapperArray;
			//   if ( !v8 )
			//     sub_180B536AC(v6, v3);
			//   if ( v8.max_length.size <= 0x59Bu )
			//     sub_180070270(v6, v3);
			//   if ( v8[39].vector[31] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1435, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)v5, deltaTime, 0LL);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     for ( i = 0; ; ++i )
			//     {
			//       m_windMotors = v5.fields.m_windMotors;
			//       if ( !m_windMotors )
			//         sub_180B536AC(v6, v3);
			//       if ( (signed int)i >= m_windMotors.fields._size )
			//         break;
			//       if ( i >= m_windMotors.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       items = m_windMotors.fields._items;
			//       if ( !items )
			//         sub_180B536AC(v6, v3);
			//       if ( i >= items.max_length.size )
			//         sub_180070270(v6, v3);
			//       v15 = items.vector[i];
			//       if ( !v15 )
			//         sub_180B536AC(v6, v3);
			//       if ( v15.fields.data.shape == 1 )
			//       {
			//         v16 = v5.fields.m_windMotors;
			//         if ( !v16 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v16.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v17 = v16.fields._items;
			//         if ( !v17 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v17.max_length.size )
			//           sub_180070270(v6, v3);
			//         v153 = (Vector2)v17.vector[i];
			//         if ( !*(_QWORD *)&v153 )
			//           sub_180B536AC(v6, v3);
			//         v18 = v5.fields.m_windMotors;
			//         if ( !v18 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v18.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v19 = v18.fields._items;
			//         if ( !v19 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v19.max_length.size )
			//           sub_180070270(v6, v3);
			//         v20 = v19.vector[i];
			//         if ( !v20 )
			//           sub_180B536AC(v6, v3);
			//         v21 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v21 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))sub_180017470("UnityEngine.Component::get_transform()");
			//           qword_18D8F4D40 = (__int64)v21;
			//         }
			//         v24 = v21(v20, v3, method);
			//         if ( !v24 )
			//           sub_180B536AC(v23, v22);
			//         ex = 0LL;
			//         LODWORD(v135) = 0;
			//         v25 = (void (__fastcall *)(__int64, Il2CppException **))qword_18D8F5320;
			//         if ( !qword_18D8F5320 )
			//         {
			//           v25 = (void (__fastcall *)(__int64, Il2CppException **))sub_180017470(
			//                                                                     "UnityEngine.Transform::get_localScale_Injected(Unity"
			//                                                                     "Engine.Vector3&)");
			//           qword_18D8F5320 = (__int64)v25;
			//         }
			//         v25(v24, &ex);
			//         *(_DWORD *)(*(_QWORD *)&v153 + 48LL) = (_DWORD)ex;
			//         v28 = v5.fields.m_windMotors;
			//         if ( !v28 )
			//           sub_180B536AC(v27, v26);
			//         if ( i >= v28.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v29 = v28.fields._items;
			//         if ( !v29 )
			//           sub_180B536AC(v27, v26);
			//         if ( i >= v29.max_length.size )
			//           sub_180070270(v27, v26);
			//         v143 = v29.vector[i];
			//         if ( !v143 )
			//           sub_180B536AC(v27, v26);
			//         v30 = v5.fields.m_windMotors;
			//         if ( !v30 )
			//           sub_180B536AC(v27, v26);
			//         if ( i >= v30.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v31 = v30.fields._items;
			//         if ( !v31 )
			//           sub_180B536AC(v27, v26);
			//         if ( i >= v31.max_length.size )
			//           sub_180070270(v27, v26);
			//         v32 = v31.vector[i];
			//         v145 = v32;
			//         if ( !v32 )
			//           sub_180B536AC(v27, v26);
			//         v33 = (__int64 (__fastcall *)(HGWindMotor *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v33 = (__int64 (__fastcall *)(HGWindMotor *))sub_180017470("UnityEngine.Component::get_transform()");
			//           qword_18D8F4D40 = (__int64)v33;
			//         }
			//         v36 = v33(v32);
			//         if ( !v36 )
			//           sub_180B536AC(v35, v34);
			//         v136 = 0LL;
			//         v137 = 0;
			//         v37 = (void (__fastcall *)(__int64, __int64 *))qword_18D8F5320;
			//         if ( !qword_18D8F5320 )
			//         {
			//           v37 = (void (__fastcall *)(__int64, __int64 *))sub_180017470(
			//                                                            "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
			//           qword_18D8F5320 = (__int64)v37;
			//         }
			//         v37(v36, &v136);
			//         v143.fields.data.height = *((float *)&v136 + 1);
			//         v40 = v5.fields.m_windMotors;
			//         if ( !v40 )
			//           sub_180B536AC(v39, v38);
			//         if ( i >= v40.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v41 = v40.fields._items;
			//         if ( !v41 )
			//           sub_180B536AC(v39, v38);
			//         if ( i >= v41.max_length.size )
			//           sub_180070270(v39, v38);
			//         v144 = v41.vector[i];
			//         if ( !v144 )
			//           sub_180B536AC(v39, v38);
			//         v42 = v5.fields.m_windMotors;
			//         if ( !v42 )
			//           sub_180B536AC(v39, v38);
			//         if ( i >= v42.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v43 = v42.fields._items;
			//         if ( !v43 )
			//           sub_180B536AC(v39, v38);
			//         if ( i >= v43.max_length.size )
			//           sub_180070270(v39, v38);
			//         v44 = v43.vector[i];
			//         v146 = v44;
			//         if ( !v44 )
			//           sub_180B536AC(v39, v38);
			//         v45 = (__int64 (__fastcall *)(HGWindMotor *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v45 = (__int64 (__fastcall *)(HGWindMotor *))sub_180017470("UnityEngine.Component::get_transform()");
			//           qword_18D8F4D40 = (__int64)v45;
			//         }
			//         v48 = v45(v44);
			//         if ( !v48 )
			//           sub_180B536AC(v47, v46);
			//         v138 = 0LL;
			//         v139 = 0.0;
			//         v49 = (void (__fastcall *)(__int64, __int64 *))qword_18D8F5320;
			//         if ( !qword_18D8F5320 )
			//         {
			//           v49 = (void (__fastcall *)(__int64, __int64 *))sub_180017470(
			//                                                            "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
			//           qword_18D8F5320 = (__int64)v49;
			//         }
			//         v49(v48, &v138);
			//         v144.fields.data.length = v139;
			//       }
			//       v50 = v5.fields.m_windMotors;
			//       if ( !v50 )
			//         sub_180B536AC(v6, v3);
			//       if ( i >= v50.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       v51 = v50.fields._items;
			//       if ( !v51 )
			//         sub_180B536AC(v6, v3);
			//       if ( i >= v51.max_length.size )
			//         sub_180070270(v6, v3);
			//       v52 = v51.vector[i];
			//       if ( !v52 )
			//         sub_180B536AC(v6, v3);
			//       if ( !v52.fields.data.shape )
			//       {
			//         v53 = v5.fields.m_windMotors;
			//         if ( !v53 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v53.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v54 = v53.fields._items;
			//         if ( !v54 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v54.max_length.size )
			//           sub_180070270(v6, v3);
			//         v55 = v54.vector[i];
			//         v147 = v55;
			//         if ( !v55 )
			//           sub_180B536AC(v6, v3);
			//         v56 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v56 = (__int64 (__fastcall *)(HGWindMotor *, __int64, MethodInfo *))sub_180017470("UnityEngine.Component::get_transform()");
			//           qword_18D8F4D40 = (__int64)v56;
			//         }
			//         v59 = v56(v55, v3, method);
			//         if ( !v59 )
			//           sub_180B536AC(v58, v57);
			//         v140 = 0LL;
			//         v141 = 0;
			//         v60 = (void (__fastcall *)(__int64, __int64 *))qword_18D8F5320;
			//         if ( !qword_18D8F5320 )
			//         {
			//           v60 = (void (__fastcall *)(__int64, __int64 *))sub_180017470(
			//                                                            "UnityEngine.Transform::get_localScale_Injected(UnityEngine.Vector3&)");
			//           qword_18D8F5320 = (__int64)v60;
			//         }
			//         v60(v59, &v140);
			//         v63 = v5.fields.m_windMotors;
			//         if ( !v63 )
			//           sub_180B536AC(v62, v61);
			//         if ( i >= v63.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v64 = v63.fields._items;
			//         if ( !v64 )
			//           sub_180B536AC(v62, v61);
			//         if ( i >= v64.max_length.size )
			//           sub_180070270(v62, v61);
			//         v65 = v64.vector[i];
			//         v148 = v65;
			//         if ( !v65 )
			//           sub_180B536AC(v62, v61);
			//         v66 = (__int64 (__fastcall *)(HGWindMotor *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v66 = (__int64 (__fastcall *)(HGWindMotor *))sub_180017470("UnityEngine.Component::get_transform()");
			//           qword_18D8F4D40 = (__int64)v66;
			//         }
			//         v69 = v66(v65);
			//         v70 = *((float *)&v140 + 1);
			//         if ( !v69 )
			//           sub_180B536AC(v68, v67);
			//         *(_QWORD *)&v142.x = _mm_unpacklo_ps((__m128)HIDWORD(v140), (__m128)HIDWORD(v140)).m128_u64[0];
			//         v142.z = *((float *)&v140 + 1);
			//         v71 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F5328;
			//         if ( !qword_18D8F5328 )
			//         {
			//           v71 = (void (__fastcall *)(__int64, Vector3 *))sub_180017470(
			//                                                            "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
			//           qword_18D8F5328 = (__int64)v71;
			//         }
			//         v71(v69, &v142);
			//         v72 = v5.fields.m_windMotors;
			//         if ( !v72 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v72.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v73 = v72.fields._items;
			//         if ( !v73 )
			//           sub_180B536AC(v6, v3);
			//         if ( i >= v73.max_length.size )
			//           sub_180070270(v6, v3);
			//         v74 = v73.vector[i];
			//         if ( !v74 )
			//           sub_180B536AC(v6, v3);
			//         v74.fields.data.radius = v70;
			//       }
			//     }
			//     v75 = 0;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v3);
			//     gameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//     v81 = gameplayTime - HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(0LL);
			//     v82 = v5.fields.m_cleanupTimer + v81;
			//     v5.fields.m_cleanupTimer = v82;
			//     if ( v82 > 60.0 )
			//     {
			//       HG::Rendering::Runtime::HGWindSimpleManager::_CleanupInvalidCameraStates(v5, 0LL);
			//       v5.fields.m_cleanupTimer = 0.0;
			//     }
			//     m_windMainState = v5.fields.m_windMainState;
			//     if ( !m_windMainState )
			//       sub_180B536AC(v78, v77);
			//     memset(&v149[8], 0, 32);
			//     *(_QWORD *)v149 = m_windMainState;
			//     sub_1800054D0((HGRenderPathScene *)v149, v77, v79, v80, v133[4], v133[5]);
			//     *(_QWORD *)&v149[8] = (unsigned int)m_windMainState.fields._version;
			//     *(_DWORD *)&v149[32] = 2;
			//     *(_OWORD *)&v149[16] = 0LL;
			//     *(_OWORD *)&v150._dictionary = *(_OWORD *)v149;
			//     v150._current = 0LL;
			//     *(_QWORD *)&v150._getEnumeratorRetType = *(_QWORD *)&v149[32];
			//     ex = 0LL;
			//     v135 = &v150;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v150,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::MoveNext) )
			//       {
			//         value = (float *)v150._current.value;
			//         if ( !v150._current.value )
			//           sub_1802DC2C8(v85, v84);
			//         v89 = (float)(*(float *)&v150._current.value[1].klass * 0.079999998) * v81;
			//         v90 = *((float *)&v150._current.value[2].monitor + 1);
			//         v91 = *(float *)&v150._current.value[3].klass;
			//         v92 = *(__int64 *)((char *)&v150._current.value[1].klass + 4);
			//         v136 = v92;
			//         v93 = *((float *)&v150._current.value[1].monitor + 1);
			//         if ( !byte_18D8EDC37 )
			//         {
			//           v86 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//           if ( (v86 & 1) != 0 )
			//           {
			//             v94 = ((unsigned int)v86 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v86 >> 29 )
			//             {
			//               case 1u:
			//                 v95 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v94);
			//                 goto LABEL_140;
			//               case 2u:
			//                 v95 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v94);
			//                 goto LABEL_140;
			//               case 3u:
			//               case 6u:
			//                 v96 = ((unsigned int)v86 >> 1) & 0xFFFFFFF;
			//                 v86 = (unsigned int)v86 >> 29;
			//                 if ( (_DWORD)v86 )
			//                 {
			//                   if ( (_DWORD)v86 == 3 )
			//                   {
			//                     v95 = (void (__fastcall __noreturn **)())sub_180039480(v96);
			//                     goto LABEL_140;
			//                   }
			//                   if ( (_DWORD)v86 == 6 )
			//                   {
			//                     v97 = sub_1802DF9C0(v96);
			//                     v95 = (void (__fastcall __noreturn **)())sub_18005F4B0(v97, 0LL);
			//                     goto LABEL_140;
			//                   }
			//                 }
			//                 else if ( v96 == 1 )
			//                 {
			//                   v95 = off_18A2C5600;
			//                   goto LABEL_140;
			//                 }
			// LABEL_139:
			//                 v95 = 0LL;
			// LABEL_140:
			//                 if ( v95 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, (__int64)v95);
			//                 break;
			//               case 4u:
			//                 v95 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v94);
			//                 goto LABEL_140;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v94) )
			//                 {
			//                   v95 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v94);
			//                 }
			//                 else
			//                 {
			//                   v87 = il2cpp_string_new_len(
			//                           qword_18D8E5198
			//                         + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v94 + 4)
			//                         + *(int *)(qword_18D8E51A0 + 16),
			//                           *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v94));
			//                   v95 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v94),
			//                                                              v87,
			//                                                              0LL);
			//                   if ( !v95 )
			//                   {
			//                     v86 = qword_18D8F6F98 + 8 * v94;
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v98 = (v86 >> 12) & 0x1FFFFF;
			//                       v84 = (unsigned __int64)v98 >> 6;
			//                       v86 = v98 & 0x3F;
			//                       _m_prefetchw(&qword_18D6870D0[v84]);
			//                       do
			//                         v99 = qword_18D6870D0[v84];
			//                       while ( v99 != _InterlockedCompareExchange64(&qword_18D6870D0[v84], v99 | (1LL << v86), v99) );
			//                     }
			//                     v95 = (void (__fastcall __noreturn **)())v87;
			//                   }
			//                 }
			//                 goto LABEL_140;
			//               case 7u:
			//                 v100 = sub_1802DF920((unsigned int)v94);
			//                 v101 = *(_QWORD *)(v100 + 16);
			//                 v102 = (v100 - *(_QWORD *)(v101 + 128)) >> 5;
			//                 if ( *(_BYTE *)(v101 + 42) == 21 )
			//                 {
			//                   v103 = *(_QWORD ***)(v101 + 96);
			//                   if ( *v103 )
			//                   {
			//                     v104 = **v103 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                     v101 = sub_180039550(v104 / 92 + v104);
			//                   }
			//                   else
			//                   {
			//                     v101 = 0LL;
			//                   }
			//                 }
			//                 LODWORD(v140) = v102 + *(_DWORD *)(*(_QWORD *)(v101 + 104) + 32LL);
			//                 v105 = sub_1801B8ECC(
			//                          (unsigned int)&v140,
			//                          (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                          *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                          12,
			//                          (__int64)sub_1802C7760);
			//                 if ( !v105 )
			//                   goto LABEL_139;
			//                 v84 = *(unsigned int *)(v105 + 8);
			//                 if ( (_DWORD)v84 == -1 )
			//                   goto LABEL_139;
			//                 v95 = (void (__fastcall __noreturn **)())(v84 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                 goto LABEL_140;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8EDC37 = 1;
			//         }
			//         v106 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v84);
			//           v106 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v107 = (unsigned __int64)v106.static_fields.wrapperArray;
			//         if ( !v107 )
			//           sub_1802DC2C8(v106, 0LL);
			//         if ( *(int *)(v107 + 24) <= 598 )
			//           goto LABEL_189;
			//         if ( !v106._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v106, v107);
			//           v106 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v107 = (unsigned __int64)v106.static_fields.wrapperArray;
			//         if ( !v107 )
			//           sub_1802DC2C8(v106, 0LL);
			//         if ( *(_DWORD *)(v107 + 24) <= 0x256u )
			//           sub_180070260(v106, v107, v86, v87);
			//         if ( *(_QWORD *)(v107 + 4816) )
			//         {
			//           if ( !byte_18D919D50 )
			//           {
			//             v86 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v86 & 1) != 0 )
			//             {
			//               v108 = ((unsigned int)v86 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v86 >> 29 )
			//               {
			//                 case 1u:
			//                   v109 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v108);
			//                   goto LABEL_180;
			//                 case 2u:
			//                   v109 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v108);
			//                   goto LABEL_180;
			//                 case 3u:
			//                 case 6u:
			//                   v110 = ((unsigned int)v86 >> 1) & 0xFFFFFFF;
			//                   v86 = (unsigned int)v86 >> 29;
			//                   if ( (_DWORD)v86 )
			//                   {
			//                     if ( (_DWORD)v86 == 3 )
			//                     {
			//                       v109 = (void (__fastcall __noreturn **)())sub_180039480(v110);
			//                       goto LABEL_180;
			//                     }
			//                     if ( (_DWORD)v86 == 6 )
			//                     {
			//                       v111 = sub_1802DF9C0(v110);
			//                       v109 = (void (__fastcall __noreturn **)())sub_18005F4B0(v111, 0LL);
			//                       goto LABEL_180;
			//                     }
			//                   }
			//                   else if ( v110 == 1 )
			//                   {
			//                     v109 = off_18A2C5600;
			//                     goto LABEL_180;
			//                   }
			// LABEL_179:
			//                   v109 = 0LL;
			// LABEL_180:
			//                   if ( v109 )
			//                     _InterlockedExchange64(
			//                       (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
			//                       (__int64)v109);
			//                   break;
			//                 case 4u:
			//                   v109 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v108);
			//                   goto LABEL_180;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v108) )
			//                   {
			//                     v109 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v108);
			//                   }
			//                   else
			//                   {
			//                     v87 = il2cpp_string_new_len(
			//                             qword_18D8E5198
			//                           + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v108 + 4)
			//                           + *(int *)(qword_18D8E51A0 + 16),
			//                             *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v108));
			//                     v109 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                 (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v108),
			//                                                                 v87,
			//                                                                 0LL);
			//                     if ( !v109 )
			//                     {
			//                       v86 = qword_18D8F6F98 + 8 * v108;
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v112 = (v86 >> 12) & 0x1FFFFF;
			//                         v107 = (unsigned __int64)v112 >> 6;
			//                         v86 = v112 & 0x3F;
			//                         _m_prefetchw(&qword_18D6870D0[v107]);
			//                         do
			//                           v113 = qword_18D6870D0[v107];
			//                         while ( v113 != _InterlockedCompareExchange64(&qword_18D6870D0[v107], v113 | (1LL << v86), v113) );
			//                       }
			//                       v109 = (void (__fastcall __noreturn **)())v87;
			//                     }
			//                   }
			//                   goto LABEL_180;
			//                 case 7u:
			//                   v114 = sub_1802DF920((unsigned int)v108);
			//                   v115 = *(_QWORD *)(v114 + 16);
			//                   v116 = (v114 - *(_QWORD *)(v115 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v115 + 42) == 21 )
			//                   {
			//                     v117 = *(_QWORD ***)(v115 + 96);
			//                     if ( *v117 )
			//                     {
			//                       v118 = **v117 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                       v115 = sub_180039550(v118 / 92 + v118);
			//                     }
			//                     else
			//                     {
			//                       v115 = 0LL;
			//                     }
			//                   }
			//                   LODWORD(v138) = v116 + *(_DWORD *)(*(_QWORD *)(v115 + 104) + 32LL);
			//                   v119 = sub_1801B8ECC(
			//                            (unsigned int)&v138,
			//                            (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                            *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                            12,
			//                            (__int64)sub_1802C7760);
			//                   if ( !v119 )
			//                     goto LABEL_179;
			//                   v107 = *(unsigned int *)(v119 + 8);
			//                   if ( (_DWORD)v107 == -1 )
			//                     goto LABEL_179;
			//                   v109 = (void (__fastcall __noreturn **)())(v107 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                   goto LABEL_180;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D919D50 = 1;
			//             v106 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           if ( !v106._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v106, v107);
			//             v106 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v120 = v106.static_fields.wrapperArray;
			//           if ( !v120 )
			//             sub_1802DC2C8(0LL, v107);
			//           if ( v120.max_length.size <= 0x256u )
			//             sub_180070260(v120, v107, v86, v87);
			//           v121 = v120[16].vector[22];
			//           if ( !v121 )
			//             sub_1802DC2C8(0LL, v107);
			//           *(_QWORD *)&v142.x = v92;
			//           v142.z = v93;
			//           v153 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(v121, &v142, 0LL);
			//         }
			//         else
			//         {
			// LABEL_189:
			//           v153 = (Vector2)_mm_unpacklo_ps((__m128)(unsigned int)v136, (__m128)_mm_cvtsi32_si128(LODWORD(v93))).m128_u64[0];
			//         }
			//         value[11] = v90 - (float)(v153.x * v89);
			//         value[12] = v91 - (float)(v153.y * v89);
			//         if ( !value )
			//           sub_1802DC2C8(v106, v107);
			//         value[13] = value[13] + v89;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v151 )
			//     {
			//       v84 = (unsigned __int64)v133;
			//       ex = v151.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v75 = 0;
			//       v5 = this;
			//     }
			//     v122 = 0LL;
			//     v123 = v5.fields.m_windMotors;
			//     if ( !v123 )
			// LABEL_283:
			//       sub_1802DC2C8(v122, v84);
			//     v124 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_u32[0];
			//     while ( (int)v122 < v123.fields._size )
			//     {
			//       m_windMotorState = v5.fields.m_windMotorState;
			//       if ( m_windMotorState )
			//       {
			//         if ( v75 >= m_windMotorState.fields._size )
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         v126 = m_windMotorState.fields._items;
			//         if ( v126 )
			//         {
			//           if ( v75 >= v126.max_length.size )
			//             sub_180070260(v122, v84, v86, v87);
			//           v127 = v126.vector[v75];
			//           if ( v127 )
			//           {
			//             v128 = (float)(v127.fields.lastData.windSpeed * 0.02) * v81;
			//             if ( COERCE_FLOAT(COERCE_UNSIGNED_INT(v127.fields.lastData.windSpeed - 1.0) & v124) < 0.001 )
			//             {
			//               curWindTime = v127.fields.curWindTime;
			//               Beyond::JobMathf::Fmod(v122, 3.1415927, v4);
			//               if ( curWindTime > 1.5707964 )
			//               {
			//                 v130 = v128 + v127.fields.curWindTime;
			//                 Beyond::JobMathf::Fmod(v122, 3.1415927, v4);
			//                 if ( v130 < 1.5707964 )
			//                 {
			//                   v131 = v127.fields.curWindTime;
			//                   Beyond::JobMathf::Fmod(v122, 3.1415927, v4);
			//                   v128 = 3.1415927 - v131;
			//                 }
			//               }
			//             }
			//             v132 = v128 + v127.fields.curWindTime;
			//             Beyond::JobMathf::Fmod(v122, 628.31854, v4);
			//             v127.fields.curWindTime = v132;
			//             v122 = (Beyond::JobMathf *)++v75;
			//             v123 = v5.fields.m_windMotors;
			//             if ( v123 )
			//               continue;
			//           }
			//         }
			//       }
			//       goto LABEL_283;
			//     }
			//   }
			// }
			// 
		}

		public void UpdateEcsFoliageSyncSystemParam(long windSystemIns, float time, float lastTime)
		{
			// // Void UpdateEcsFoliageSyncSystemParam(Int64, Single, Single)
			// void HG::Rendering::Runtime::HGWindSimpleManager::UpdateEcsFoliageSyncSystemParam(
			//         HGWindSimpleManager *this,
			//         int64_t windSystemIns,
			//         float time,
			//         float lastTime,
			//         MethodInfo *method)
			// {
			//   Vector4 WindGlobalParams0; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Vector4 v11; // [rsp+50h] [rbp-48h] BYREF
			//   Vector4 v12; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1448, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1448, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_545(Patch, (Object *)this, windSystemIns, time, lastTime, 0LL);
			//   }
			//   else
			//   {
			//     WindGlobalParams0 = this.fields.m_windParamDataCache._WindGlobalParams0;
			//     v11 = this[2].fields.m_windParamDataCache._WindGlobalParams0;
			//     v12 = WindGlobalParams0;
			//     UnityEngine::HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_UpdateWindParam(
			//       windSystemIns,
			//       &v12,
			//       &this.fields.m_windParamDataCache._WindMotorParams0.FixedElementField,
			//       &this[1].fields.m_cleanupTimer,
			//       &this[1].fields.m_windParamDataCache._WindGlobalParams0.z,
			//       (float *)&this[2].monitor,
			//       &v11,
			//       time,
			//       lastTime,
			//       0LL);
			//   }
			// }
			// 
		}

		private static bool CheckCameraValid(int guid)
		{
			// // Boolean CheckCameraValid(Int32)
			// bool HG::Rendering::Runtime::HGWindSimpleManager::CheckCameraValid(int32_t guid, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Object_1__StaticFields *static_fields; // rdx
			//   Camera *main; // rbx
			//   char *m_CachedPtr; // rbx
			//   int v8; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t OffsetOfInstanceIDInCPlusPlusObject; // eax
			// 
			//   if ( !byte_18D8EDCC3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCC3 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_33;
			//   if ( wrapperArray.max_length.size > 858 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x35A )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[18]._0.fields )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(858, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//                  (ILFixDynamicMethodWrapper_17 *)Patch,
			//                  (AudioLogChannel__Enum)guid,
			//                  0LL);
			//     }
			// LABEL_33:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_9:
			//   UnityEngine::Application::get_isPlaying(0LL);
			//   main = UnityEngine::Camera::get_main(0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, static_fields);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, static_fields);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !main )
			//     return 0;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, static_fields);
			//   if ( !main.fields._._._.m_CachedPtr )
			//     return 0;
			//   if ( !byte_18D8F4EAC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAC = 1;
			//   }
			//   if ( main.fields._._._.m_CachedPtr )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, static_fields);
			//     if ( TypeInfo::UnityEngine::Object.static_fields.OffsetOfInstanceIDInCPlusPlusObject == -1 )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, static_fields);
			//       OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
			//       static_fields = TypeInfo::UnityEngine::Object.static_fields;
			//       static_fields.OffsetOfInstanceIDInCPlusPlusObject = OffsetOfInstanceIDInCPlusPlusObject;
			//     }
			//     m_CachedPtr = (char *)main.fields._._._.m_CachedPtr;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, static_fields);
			//     v8 = *(_DWORD *)&m_CachedPtr[TypeInfo::UnityEngine::Object.static_fields.OffsetOfInstanceIDInCPlusPlusObject];
			//   }
			//   else
			//   {
			//     v8 = 0;
			//   }
			//   return v8 == guid;
			// }
			// 
			return default(bool);
		}

		private void _SetupWindParamCache(ref ShaderVariablesGlobal cb, int cameraGuid)
		{
			// // Void _SetupWindParamCache(ShaderVariablesGlobal ByRef, Int32)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetupWindParamCache(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t cameraGuid,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v7.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_10;
			//   if ( wrapperArray.max_length.size > 857 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v7.static_fields;
			//     v10 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v10.max_length.size <= 0x359u )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v10[23].vector[29] )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(857, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(Patch, (Object *)this, cb, cameraGuid, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( HG::Rendering::Runtime::HGWindSimpleManager::CheckCameraValid(cameraGuid, 0LL) )
			//   {
			//     this.fields.m_windParamDataCache._WindGlobalParams0 = *(Vector4 *)&cb._FoliageInteractiveParams0.w;
			//     this[2].fields.m_windParamDataCache._WindGlobalParams0 = *(Vector4 *)&cb._FogBakeLutYawParams.w;
			//     System::Buffer::MemoryCopy(
			//       (Void *)&cb._AtmosphereFogParams5.w,
			//       (Void *)&this.fields.m_windParamDataCache._WindMotorParams0,
			//       64LL,
			//       64LL,
			//       0LL);
			//     System::Buffer::MemoryCopy((Void *)&cb._ExponentialFogParams3.w, (Void *)&this[1].fields, 64LL, 64LL, 0LL);
			//     System::Buffer::MemoryCopy(
			//       (Void *)&cb._VolumetricFogParams1.w,
			//       (Void *)&this[1].fields.m_windParamDataCache._WindGlobalParams0.z,
			//       64LL,
			//       64LL,
			//       0LL);
			//     System::Buffer::MemoryCopy((Void *)&cb._HeightFogFlowNoiseParams0.w, (Void *)&this[2].monitor, 64LL, 64LL, 0LL);
			//   }
			// }
			// 
		}

		public void SetupShaderVariablesGlobalWind(ref ShaderVariablesGlobal cb, int cameraGuid, Vector3 cameraPos, HGEnvironmentPhase phase)
		{
			// // Void SetupShaderVariablesGlobalWind(ShaderVariablesGlobal ByRef, Int32, Vector3, HGEnvironmentPhase)
			// void HG::Rendering::Runtime::HGWindSimpleManager::SetupShaderVariablesGlobalWind(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t cameraGuid,
			//         Vector3 *cameraPos,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v10; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
			//   int32_t size; // ebx
			//   __int128 v14; // xmm0
			//   float z; // eax
			//   int32_t i; // ebx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v17; // rax
			//   int v18; // ecx
			//   __int64 v19; // rsi
			//   float *v20; // rbx
			//   __int64 v21; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v23; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *v24; // rax
			//   ILFixDynamicMethodWrapper_2 *v25; // rax
			//   ILFixDynamicMethodWrapper_2 *v26; // rax
			//   _OWORD v27[2]; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDCC4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Count);
			//     byte_18D8EDCC4 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_44;
			//   if ( wrapperArray.max_length.size > 841 )
			//   {
			//     if ( !v10._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v10, wrapperArray);
			//       v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v10.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_44;
			//     if ( wrapperArray.max_length.size <= 0x349u )
			//       goto LABEL_73;
			//     if ( wrapperArray[23].vector[13] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(841, 0LL);
			//       if ( !Patch )
			//         goto LABEL_44;
			//       v23 = *(_QWORD *)&cameraPos.x;
			//       DWORD2(v27[0]) = LODWORD(cameraPos.z);
			//       *(_QWORD *)&v27[0] = v23;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_334(
			//         Patch,
			//         (Object *)this,
			//         cb,
			//         cameraGuid,
			//         (Vector3 *)v27,
			//         (Object *)phase,
			//         0LL);
			//       return;
			//     }
			//   }
			//   HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMain(this, cb, cameraGuid, phase, 0LL);
			//   m_windMotors = this.fields.m_windMotors;
			//   if ( !m_windMotors )
			//     goto LABEL_44;
			//   size = 4;
			//   if ( m_windMotors.fields._size < 4 )
			//     size = m_windMotors.fields._size;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_44;
			//   if ( wrapperArray.max_length.size <= 843 )
			//     goto LABEL_18;
			//   if ( !v10._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v10, wrapperArray);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_44;
			//   if ( wrapperArray.max_length.size <= 0x34Bu )
			//     goto LABEL_73;
			//   if ( wrapperArray[23].vector[15] )
			//   {
			//     v24 = IFix::WrappersManagerImpl::GetPatch(843, 0LL);
			//     if ( !v24 )
			//       goto LABEL_44;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(v24, (Object *)this, cb, size, 0LL);
			//   }
			//   else
			//   {
			// LABEL_18:
			//     v14 = LODWORD(v27[0]);
			//     *(float *)&v14 = (float)size;
			//     v27[0] = v14;
			//     *(_OWORD *)&cb._FogBakeLutYawParams.w = v14;
			//   }
			//   z = cameraPos.z;
			//   *(_QWORD *)&v27[0] = *(_QWORD *)&cameraPos.x;
			//   *((float *)v27 + 2) = z;
			//   HG::Rendering::Runtime::HGWindSimpleManager::_SortWindMotorsForSingleCamera(this, (Vector3 *)v27, 0LL);
			//   for ( i = 0; ; ++i )
			//   {
			//     v17 = this.fields.m_windMotors;
			//     if ( !v17 )
			//       goto LABEL_44;
			//     v18 = 4;
			//     if ( v17.fields._size < 4 )
			//       v18 = v17.fields._size;
			//     if ( i >= v18 )
			//       break;
			//     HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMotor(this, cb, i, 0LL);
			//   }
			//   v19 = v17.fields._size;
			//   if ( (int)v19 < 4 )
			//   {
			//     v20 = &cb._ExponentialFogParams3.w + 4 * v19;
			//     while ( 1 )
			//     {
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         byte_18D8EDC37 = 1;
			//       }
			//       v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//         v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       wrapperArray = v10.static_fields.wrapperArray;
			//       if ( !wrapperArray )
			//         break;
			//       if ( wrapperArray.max_length.size <= 855 )
			//         goto LABEL_32;
			//       if ( !v10._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v10, wrapperArray);
			//         v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       v10 = (struct ILFixDynamicMethodWrapper_2__Class *)v10.static_fields.wrapperArray;
			//       if ( !v10 )
			//         break;
			//       if ( LODWORD(v10._0.namespaze) <= 0x357 )
			//         goto LABEL_73;
			//       if ( v10[18]._0.typeMetadataHandle )
			//       {
			//         v25 = IFix::WrappersManagerImpl::GetPatch(855, 0LL);
			//         if ( !v25 )
			//           break;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(v25, (Object *)this, cb, v19, 0LL);
			//       }
			//       else
			//       {
			// LABEL_32:
			//         *((_QWORD *)v20 - 8) = 0LL;
			//         *(_QWORD *)v20 = 0LL;
			//         *((_QWORD *)v20 + 8) = 0LL;
			//         *((_QWORD *)v20 + 16) = 0LL;
			//         *((_QWORD *)v20 - 7) = 0LL;
			//         *((_QWORD *)v20 + 1) = 0LL;
			//         *((_QWORD *)v20 + 9) = 0LL;
			//         *((_QWORD *)v20 + 17) = 0LL;
			//         *((_QWORD *)v20 + 28) = 0LL;
			//         *((_QWORD *)v20 + 36) = 0LL;
			//         *((_QWORD *)v20 + 44) = 0LL;
			//         *((_QWORD *)v20 + 29) = 0LL;
			//         *((_QWORD *)v20 + 37) = 0LL;
			//         *((_QWORD *)v20 + 45) = 0LL;
			//       }
			//       LODWORD(v19) = v19 + 1;
			//       v20 += 4;
			//       if ( (int)v19 >= 4 )
			//         goto LABEL_34;
			//     }
			// LABEL_44:
			//     sub_180B536AC(v10, wrapperArray);
			//   }
			// LABEL_34:
			//   HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindFoot(this, cb, phase, 0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v21);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_44;
			//   if ( wrapperArray.max_length.size <= 857 )
			//     goto LABEL_40;
			//   if ( !v10._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v10, wrapperArray);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_44;
			//   if ( wrapperArray.max_length.size <= 0x359u )
			// LABEL_73:
			//     sub_180070270(v10, wrapperArray);
			//   if ( !wrapperArray[23].vector[29] )
			//   {
			// LABEL_40:
			//     if ( HG::Rendering::Runtime::HGWindSimpleManager::CheckCameraValid(cameraGuid, 0LL) )
			//     {
			//       this.fields.m_windParamDataCache._WindGlobalParams0 = *(Vector4 *)&cb._FoliageInteractiveParams0.w;
			//       this[2].fields.m_windParamDataCache._WindGlobalParams0 = *(Vector4 *)&cb._FogBakeLutYawParams.w;
			//       System::Buffer::MemoryCopy(
			//         (Void *)&cb._AtmosphereFogParams5.w,
			//         (Void *)&this.fields.m_windParamDataCache._WindMotorParams0,
			//         64LL,
			//         64LL,
			//         0LL);
			//       System::Buffer::MemoryCopy((Void *)&cb._ExponentialFogParams3.w, (Void *)&this[1].fields, 64LL, 64LL, 0LL);
			//       System::Buffer::MemoryCopy(
			//         (Void *)&cb._VolumetricFogParams1.w,
			//         (Void *)&this[1].fields.m_windParamDataCache._WindGlobalParams0.z,
			//         64LL,
			//         64LL,
			//         0LL);
			//       System::Buffer::MemoryCopy((Void *)&cb._HeightFogFlowNoiseParams0.w, (Void *)&this[2].monitor, 64LL, 64LL, 0LL);
			//     }
			//     return;
			//   }
			//   v26 = IFix::WrappersManagerImpl::GetPatch(857, 0LL);
			//   if ( !v26 )
			//     goto LABEL_44;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(v26, (Object *)this, cb, cameraGuid, 0LL);
			// }
			// 
		}

		private void _SetupShaderVariablesWindMain(ref ShaderVariablesGlobal cb, int cameraGuid, HGEnvironmentPhase phase)
		{
			// // Void _SetupShaderVariablesWindMain(ShaderVariablesGlobal ByRef, Int32, HGEnvironmentPhase)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMain(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t cameraGuid,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *m_RenderPipelineResources; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rsi
			//   Object__Class *v12; // xmm7_8
			//   __m128 speed_low; // xmm6
			//   float z; // r15d
			//   struct MethodInfo *v15; // rbx
			//   Dictionary_2_System_Int32_System_Object_ *v16; // rbx
			//   struct MethodInfo *v17; // rsi
			//   int32_t Entry; // eax
			//   InsertionBehavior__Enum v19; // r9d
			//   Dictionary_2_TKey_TValue_Entry_System_Int32_System_Object___Array *entries; // rbx
			//   Object *value; // rbx
			//   __m128 v22; // xmm3
			//   __m128 v23; // xmm3
			//   __m128 v24; // xmm3
			//   __m128 v25; // xmm4
			//   __m128 v26; // xmm4
			//   __m128 v27; // xmm4
			//   __m128 v28; // xmm3
			//   __m128 v29; // xmm3
			//   __m128 v30; // xmm3
			//   int v31; // xmm1_4
			//   int klass_high; // xmm0_4
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *v33; // rbp
			//   struct MethodInfo *v34; // rsi
			//   __int64 v35; // rdx
			//   struct HGShaderIDs__Class *v36; // rax
			//   unsigned int WindGlobalNoiseTex; // edi
			//   HGRenderPipeline *currentPipeline; // rax
			//   HGRenderPipelineGlobalSettings *m_GlobalSettings; // rax
			//   __int64 v40; // rax
			//   __int64 v41; // rbx
			//   void (__fastcall *v42)(_QWORD, __int64); // rax
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *v43; // rbx
			//   Object *v44; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Il2CppClass *klass; // rax
			//   __int64 v47; // rax
			//   __int64 v48; // r8
			//   Object *v49; // rax
			//   __int64 v50; // rax
			//   __int64 v51; // [rsp+30h] [rbp-58h] BYREF
			//   Object__Class *v52; // [rsp+38h] [rbp-50h]
			// 
			//   if ( !byte_18D8EDCC5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D8EDCC5 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_RenderPipelineResources = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     m_RenderPipelineResources = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = m_RenderPipelineResources.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_37;
			//   if ( wrapperArray.max_length.size > 842 )
			//   {
			//     if ( !m_RenderPipelineResources._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(m_RenderPipelineResources, wrapperArray);
			//       m_RenderPipelineResources = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = m_RenderPipelineResources.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_37;
			//     if ( wrapperArray.max_length.size <= 0x34Au )
			// LABEL_40:
			//       sub_180070270(m_RenderPipelineResources, wrapperArray);
			//     if ( wrapperArray[23].vector[14] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(842, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(Patch, (Object *)this, cb, cameraGuid, (Object *)phase, 0LL);
			//         return;
			//       }
			//       goto LABEL_37;
			//     }
			//   }
			//   if ( !phase )
			//     goto LABEL_37;
			//   m_windMainState = this.fields.m_windMainState;
			//   speed_low = (__m128)LODWORD(phase.fields.windConfig.speed);
			//   v12 = *(Object__Class **)&phase.fields.windConfig.direction.x;
			//   speed_low.m128_f32[0] = speed_low.m128_f32[0] * 0.25;
			//   z = phase.fields.windConfig.direction.z;
			//   v52 = v12;
			//   if ( !m_windMainState )
			//     goto LABEL_37;
			//   v15 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey;
			//   if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey.klass.rgctx_data[22].rgctxDataDummy
			//         + 4) )
			//     (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::ContainsKey.klass.rgctx_data[22].rgctxDataDummy)();
			//   if ( System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
			//          (Dictionary_2_System_Int32_System_Object_ *)m_windMainState,
			//          cameraGuid,
			//          (MethodInfo *)v15.klass.rgctx_data[22].rgctxDataDummy) < 0 )
			//   {
			//     v43 = this.fields.m_windMainState;
			//     v44 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState);
			//     if ( !v44 || !v43 )
			//       goto LABEL_37;
			//     System::Collections::Generic::Dictionary<int,System::Object>::set_Item(
			//       (Dictionary_2_System_Int32_System_Object_ *)v43,
			//       cameraGuid,
			//       v44,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item);
			//   }
			//   v16 = (Dictionary_2_System_Int32_System_Object_ *)this.fields.m_windMainState;
			//   if ( !v16 )
			//     goto LABEL_37;
			//   v17 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item;
			//   if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item.klass.rgctx_data[22].rgctxDataDummy
			//         + 4) )
			//     (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Item.klass.rgctx_data[22].rgctxDataDummy)();
			//   Entry = System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
			//             v16,
			//             cameraGuid,
			//             (MethodInfo *)v17.klass.rgctx_data[22].rgctxDataDummy);
			//   if ( Entry < 0 )
			//   {
			//     klass = v17.klass;
			//     LODWORD(v51) = cameraGuid;
			//     v47 = ((__int64 (__fastcall *)(_QWORD))sub_18010B520)((const Il2CppRGCTXData)klass.rgctx_data[23].rgctxDataDummy);
			//     v49 = (Object *)il2cpp_value_box(v47, &v51, v48);
			//     System::ThrowHelper::GetKeyNotFoundException(v49, 0LL);
			//   }
			//   entries = v16.fields._entries;
			//   if ( !entries )
			// LABEL_37:
			//     sub_180B536AC(m_RenderPipelineResources, wrapperArray);
			//   if ( (unsigned int)Entry >= entries.max_length.size )
			//     goto LABEL_40;
			//   value = entries.vector[Entry].value;
			//   if ( !value )
			//     goto LABEL_37;
			//   v22 = _mm_shuffle_ps(speed_low, speed_low, 225);
			//   v22.m128_f32[0] = *((float *)&value[3].klass + 1);
			//   v23 = _mm_shuffle_ps(v22, v22, 198);
			//   v23.m128_f32[0] = *(float *)&v52;
			//   v24 = _mm_shuffle_ps(v23, v23, 39);
			//   v24.m128_f32[0] = z;
			//   *(__m128 *)&cb._FoliageInteractiveParams0.w = _mm_shuffle_ps(v24, v24, 57);
			//   v25 = _mm_shuffle_ps((__m128)LODWORD(value[1].klass), (__m128)LODWORD(value[1].klass), 225);
			//   v25.m128_f32[0] = *(float *)&value[2].monitor;
			//   v26 = _mm_shuffle_ps(v25, v25, 198);
			//   v26.m128_f32[0] = *((float *)&value[1].klass + 1);
			//   v27 = _mm_shuffle_ps(v26, v26, 39);
			//   v27.m128_f32[0] = *((float *)&value[1].monitor + 1);
			//   *(__m128 *)&cb._CloudShadowParams0.w = _mm_shuffle_ps(v27, v27, 57);
			//   v28 = _mm_shuffle_ps((__m128)HIDWORD(value[2].monitor), (__m128)HIDWORD(value[2].monitor), 225);
			//   v28.m128_f32[0] = *(float *)&value[3].klass;
			//   v29 = _mm_shuffle_ps(v28, v28, 198);
			//   v29.m128_f32[0] = *(float *)&value[2].klass;
			//   v30 = _mm_shuffle_ps(v29, v29, 39);
			//   v30.m128_f32[0] = *((float *)&value[2].klass + 1);
			//   *(__m128 *)&cb._PrevFoliageInteractiveParams0.w = _mm_shuffle_ps(v30, v30, 57);
			//   v31 = (int)value[3].klass;
			//   LODWORD(value[2].klass) = HIDWORD(value[2].monitor);
			//   klass_high = HIDWORD(value[3].klass);
			//   *(Object__Class **)((char *)&value[1].klass + 4) = v12;
			//   LODWORD(value[2].monitor) = klass_high;
			//   LODWORD(value[1].klass) = speed_low.m128_i32[0];
			//   HIDWORD(value[2].klass) = v31;
			//   *((float *)&value[1].monitor + 1) = z;
			//   v33 = this.fields.m_windMainState;
			//   if ( !v33 )
			//     goto LABEL_37;
			//   v34 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item;
			//   if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item.klass.rgctx_data[24].rgctxDataDummy
			//         + 4) )
			//     (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::set_Item.klass.rgctx_data[24].rgctxDataDummy)();
			//   LOBYTE(v19) = 1;
			//   System::Collections::Generic::Dictionary<int,System::Object>::TryInsert(
			//     (Dictionary_2_System_Int32_System_Object_ *)v33,
			//     cameraGuid,
			//     value,
			//     v19,
			//     (MethodInfo *)v34.klass.rgctx_data[24].rgctxDataDummy);
			//   v36 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs, v35);
			//     v36 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   }
			//   WindGlobalNoiseTex = v36.static_fields._WindGlobalNoiseTex;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v35);
			//   currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//   if ( !currentPipeline )
			//     goto LABEL_37;
			//   m_GlobalSettings = currentPipeline.fields.m_GlobalSettings;
			//   if ( !m_GlobalSettings )
			//     goto LABEL_37;
			//   m_RenderPipelineResources = (struct ILFixDynamicMethodWrapper_2__Class *)m_GlobalSettings.fields.m_RenderPipelineResources;
			//   if ( !m_RenderPipelineResources )
			//     goto LABEL_37;
			//   v40 = *((_QWORD *)&m_RenderPipelineResources._0.byval_arg + 1);
			//   if ( !v40 )
			//     goto LABEL_37;
			//   v41 = *(_QWORD *)(v40 + 40);
			//   v42 = (void (__fastcall *)(_QWORD, __int64))qword_18D8F46E0;
			//   if ( !qword_18D8F46E0 )
			//   {
			//     v42 = (void (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_0(
			//                                                   "UnityEngine.Shader::SetGlobalTextureImpl(System.Int32,UnityEngine.Texture)");
			//     if ( !v42 )
			//     {
			//       v50 = sub_1802DBBE8("UnityEngine.Shader::SetGlobalTextureImpl(System.Int32,UnityEngine.Texture)");
			//       sub_18000F750(v50, 0LL);
			//     }
			//     qword_18D8F46E0 = (__int64)v42;
			//   }
			//   v42(WindGlobalNoiseTex, v41);
			// }
			// 
		}

		private bool _IsWindMotorCanStop(float windTime)
		{
			// // Boolean _IsWindMotorCanStop(Single)
			// bool HG::Rendering::Runtime::HGWindSimpleManager::_IsWindMotorCanStop(
			//         HGWindSimpleManager *this,
			//         float windTime,
			//         MethodInfo *method)
			// {
			//   float v3; // xmm2_4
			//   Beyond::JobMathf *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(852, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(852, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_82(
			//              (ILFixDynamicMethodWrapper_3 *)Patch,
			//              (Object *)this,
			//              windTime,
			//              0LL);
			//   }
			//   else
			//   {
			//     Beyond::JobMathf::Fmod(v5, 3.1415927, v3);
			//     return fabs(windTime) < 0.1;
			//   }
			// }
			// 
			return default(bool);
		}

		private void _SetupShaderVariableWindMotorCount(ref ShaderVariablesGlobal cb, int count)
		{
			// // Void _SetupShaderVariableWindMotorCount(ShaderVariablesGlobal ByRef, Int32)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariableWindMotorCount(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t count,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int128 v9; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned int v11; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 843 )
			//   {
			// LABEL_7:
			//     v9 = v11;
			//     *(float *)&v9 = (float)count;
			//     *(_OWORD *)&cb._FogBakeLutYawParams.w = v9;
			//     return;
			//   }
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   if ( LODWORD(v7._0.namespaze) <= 0x34B )
			//     sub_180070270(v7, wrapperArray);
			//   if ( !v7[18]._0.gc_desc )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(843, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v7, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(Patch, (Object *)this, cb, count, 0LL);
			// }
			// 
		}

		private void _SetupShaderVariablesWindMotor(ref ShaderVariablesGlobal cb, int index)
		{
			// // Void _SetupShaderVariablesWindMotor(ShaderVariablesGlobal ByRef, Int32)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindMotor(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *items; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *v9; // rax
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
			//   __int64 v11; // r14
			//   float v12; // xmm1_4
			//   HGWindMotor__Array *v13; // rdi
			//   HGWindMotor *v14; // rdi
			//   __m128 v15; // xmm6
			//   __int64 (__fastcall *v16)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, _QWORD, MethodInfo *); // rax
			//   float distanceToCamera; // r12d
			//   __int128 v18; // xmm11
			//   __int128 v19; // xmm12
			//   __int64 v20; // r15
			//   void (__fastcall *v21)(__int64, Vector3 *); // rax
			//   __int64 v22; // rdx
			//   float z; // r15d
			//   unsigned __int64 v24; // xmm0_8
			//   unsigned __int64 v25; // xmm10_8
			//   Vector3 *Direction; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // xmm7_8
			//   float v29; // edi
			//   __m128 v30; // xmm1
			//   __m128 v31; // xmm7
			//   unsigned __int32 v32; // xmm8_4
			//   __m128 v33; // xmm9
			//   __int64 v34; // xmm0_8
			//   __int128 v35; // xmm1
			//   __m128 v36; // xmm2
			//   float v37; // eax
			//   __int128 v38; // xmm0
			//   __m128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   PassConstructorID__Enum__Array *v41; // r8
			//   HGCamera *v42; // r9
			//   List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *v43; // r10
			//   HGWindSimpleManager_HGWindMotorState__Array *v44; // rax
			//   __int64 v45; // r10
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   List_1_System_Object_ *m_windMotorState; // rdi
			//   Object *v48; // rax
			//   __m128 v49; // xmm6
			//   __int64 v50; // rax
			//   __int64 v51; // rax
			//   ILFixDynamicMethodWrapper_2 *v52; // rax
			//   Vector3 *v53; // rax
			//   ILFixDynamicMethodWrapper_2 *v54; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v56; // [rsp+28h] [rbp-D8h]
			//   float v57; // [rsp+30h] [rbp-D0h]
			//   Vector3 v58; // [rsp+40h] [rbp-C0h] BYREF
			//   Vector3 v59; // [rsp+50h] [rbp-B0h] BYREF
			//   HGWindMotorData v60; // [rsp+60h] [rbp-A0h] BYREF
			// 
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)index;
			//   if ( !byte_18D8EDCC6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::set_Item);
			//     byte_18D8EDCC6 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = items.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_51;
			//   if ( wrapperArray.max_length.size > 849 )
			//   {
			//     if ( !items._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(items, wrapperArray);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = items.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_51;
			//     if ( wrapperArray.max_length.size <= 0x351u )
			//       goto LABEL_52;
			//     if ( wrapperArray[23].vector[21] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(849, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(Patch, (Object *)this, cb, (int32_t)v5, 0LL);
			//         return;
			//       }
			//       goto LABEL_51;
			//     }
			//   }
			//   if ( !this.fields.m_windMotorState )
			//     return;
			//   if ( this.fields.m_windMotorState.fields._size < (int)v5 )
			//   {
			//     m_windMotorState = (List_1_System_Object_ *)this.fields.m_windMotorState;
			//     v48 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState);
			//     if ( !v48 )
			//       goto LABEL_51;
			//     System::Collections::Generic::List<System::Object>::set_Item(
			//       m_windMotorState,
			//       (int32_t)v5,
			//       v48,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::set_Item);
			//   }
			//   v9 = this.fields.m_windMotorState;
			//   if ( !v9 )
			//     goto LABEL_51;
			//   if ( (unsigned int)v5 >= v9.fields._size )
			// LABEL_85:
			//     System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//   items = (struct ILFixDynamicMethodWrapper_2__Class *)v9.fields._items;
			//   if ( !items )
			//     goto LABEL_51;
			//   if ( (unsigned int)v5 >= LODWORD(items._0.namespaze) )
			//     goto LABEL_52;
			//   m_windMotors = this.fields.m_windMotors;
			//   v11 = *((_QWORD *)&items._0.byval_arg.data.dummy + (_QWORD)v5);
			//   if ( !m_windMotors )
			// LABEL_51:
			//     sub_180B536AC(items, wrapperArray);
			//   v12 = 0.0;
			//   if ( m_windMotors.fields._size > (int)v5 )
			//   {
			//     if ( (unsigned int)v5 >= m_windMotors.fields._size )
			//       goto LABEL_85;
			//     v13 = m_windMotors.fields._items;
			//     if ( !v13 )
			//       goto LABEL_51;
			//     if ( (unsigned int)v5 >= v13.max_length.size )
			//       goto LABEL_52;
			//     v14 = v13.vector[(_QWORD)v5];
			//     if ( !v14 )
			//       goto LABEL_51;
			//     v15 = *(__m128 *)&v14.fields.data.angle;
			//     v16 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, _QWORD, MethodInfo *))qword_18D8F4D40;
			//     distanceToCamera = v14.fields.data.distanceToCamera;
			//     v18 = *(_OWORD *)&v14.fields.data.windPriority;
			//     v19 = *(_OWORD *)&v14.fields.data.width;
			//     *(__m128 *)&v60.angle = v15;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v16 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, _QWORD, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//       if ( !v16 )
			//       {
			//         v50 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v50, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v16;
			//     }
			//     v20 = v16(v14, wrapperArray, *(_QWORD *)&index, method);
			//     if ( !v20 )
			//       goto LABEL_51;
			//     *(_QWORD *)&v58.x = 0LL;
			//     v58.z = 0.0;
			//     v21 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//     if ( !qword_18D8F52E0 )
			//     {
			//       v21 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       if ( !v21 )
			//       {
			//         v51 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v51, 0LL);
			//       }
			//       qword_18D8F52E0 = (__int64)v21;
			//     }
			//     v21(v20, &v58);
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v22);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = items.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_51;
			//     if ( wrapperArray.max_length.size <= 850 )
			//       goto LABEL_30;
			//     if ( !items._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(items, wrapperArray);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = items.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_51;
			//     if ( wrapperArray.max_length.size <= 0x352u )
			//       goto LABEL_52;
			//     if ( wrapperArray[23].vector[22] )
			//     {
			//       v52 = IFix::WrappersManagerImpl::GetPatch(850, 0LL);
			//       if ( !v52 )
			//         goto LABEL_51;
			//       v59 = v58;
			//       v53 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(&v58, v52, &v59, 0LL);
			//       v24 = *(_QWORD *)&v53.x;
			//       z = v53.z;
			//     }
			//     else
			//     {
			// LABEL_30:
			//       z = v58.z;
			//       v24 = _mm_unpacklo_ps((__m128)LODWORD(v58.x), (__m128)LODWORD(v58.y)).m128_u64[0];
			//     }
			//     v25 = v24;
			//     Direction = HG::Rendering::Runtime::HGWindMotor::GetDirection(&v58, v14, 0LL);
			//     v28 = *(_QWORD *)&Direction.x;
			//     v29 = Direction.z;
			//     *(_QWORD *)&v59.x = *(_QWORD *)&Direction.x;
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v27);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = items.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_51;
			//     if ( wrapperArray.max_length.size <= 598 )
			//       goto LABEL_37;
			//     if ( !items._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(items, wrapperArray);
			//       items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = items.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_51;
			//     if ( wrapperArray.max_length.size > 0x256u )
			//     {
			//       if ( wrapperArray[16].vector[22] )
			//       {
			//         v54 = IFix::WrappersManagerImpl::GetPatch(598, 0LL);
			//         if ( !v54 )
			//           goto LABEL_51;
			//         *(_QWORD *)&v59.x = v28;
			//         v59.z = v29;
			//         v30 = (__m128)(unsigned __int64)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(v54, &v59, 0LL);
			//         goto LABEL_38;
			//       }
			// LABEL_37:
			//       v30 = _mm_unpacklo_ps((__m128)LODWORD(v59.x), (__m128)_mm_cvtsi32_si128(LODWORD(v29)));
			// LABEL_38:
			//       v31 = v30;
			//       *(_QWORD *)&v58.x = v30.m128_u64[0];
			//       v32 = v30.m128_i32[0];
			//       v33.m128_i32[0] = _mm_shuffle_ps(v31, v31, 85).m128_u32[0];
			//       LODWORD(v12) = _mm_shuffle_ps(v15, v15, 85).m128_u32[0];
			//       goto LABEL_39;
			//     }
			// LABEL_52:
			//     sub_180070270(items, wrapperArray);
			//   }
			//   if ( !v11 )
			//     goto LABEL_51;
			//   distanceToCamera = *(float *)(v11 + 64);
			//   v32 = *(_DWORD *)(v11 + 72);
			//   v33 = (__m128)*(unsigned int *)(v11 + 76);
			//   v18 = *(_OWORD *)(v11 + 16);
			//   z = *(float *)(v11 + 88);
			//   v19 = *(_OWORD *)(v11 + 32);
			//   v25 = *(_QWORD *)(v11 + 80);
			//   v31.m128_u64[0] = _mm_unpacklo_ps((__m128)v32, v33).m128_u64[0];
			//   v49 = _mm_shuffle_ps(*(__m128 *)(v11 + 48), *(__m128 *)(v11 + 48), 225);
			//   v49.m128_f32[0] = 0.0;
			//   v15 = _mm_shuffle_ps(v49, v49, 225);
			//   *(__m128 *)&v60.angle = v15;
			// LABEL_39:
			//   if ( v12 <= 1.0 )
			//   {
			//     if ( !v11 )
			//       goto LABEL_51;
			//     if ( HG::Rendering::Runtime::HGWindSimpleManager::_IsWindMotorCanStop(this, *(float *)(v11 + 92), 0LL) )
			//       v60.windSpeed = 0.0;
			//     else
			//       v60.windSpeed = 1.0;
			//     v15 = *(__m128 *)&v60.angle;
			//   }
			//   if ( !v11 )
			//     goto LABEL_51;
			//   v34 = *(_QWORD *)(v11 + 80);
			//   v35 = *(_OWORD *)(v11 + 32);
			//   v59.z = *(float *)(v11 + 88);
			//   v36 = (__m128)*(unsigned int *)(v11 + 76);
			//   v37 = *(float *)(v11 + 64);
			//   *(_QWORD *)&v59.x = v34;
			//   v38 = *(_OWORD *)(v11 + 16);
			//   *(_OWORD *)&v60.width = v35;
			//   v39 = (__m128)*(unsigned int *)(v11 + 72);
			//   *(_OWORD *)&v60.windPriority = v38;
			//   v40 = *(_OWORD *)(v11 + 48);
			//   v60.distanceToCamera = v37;
			//   *(_OWORD *)&v60.angle = v40;
			//   HG::Rendering::Runtime::HGWindSimpleManager::_SetLastWindMotorParams(
			//     this,
			//     cb,
			//     (int32_t)v5,
			//     &v60,
			//     &v59,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v39, v36),
			//     *(float *)(v11 + 68),
			//     0LL);
			//   LODWORD(v40) = *(_DWORD *)(v11 + 92);
			//   *(_OWORD *)(v11 + 16) = v18;
			//   *(_OWORD *)(v11 + 32) = v19;
			//   *(__m128 *)(v11 + 48) = v15;
			//   *(float *)(v11 + 64) = distanceToCamera;
			//   *(_QWORD *)(v11 + 80) = v25;
			//   *(_DWORD *)(v11 + 68) = v40;
			//   *(_DWORD *)(v11 + 72) = v32;
			//   *(_DWORD *)(v11 + 76) = v33.m128_i32[0];
			//   *(float *)(v11 + 88) = z;
			//   v43 = this.fields.m_windMotorState;
			//   if ( !v43 )
			//     goto LABEL_51;
			//   if ( (unsigned int)v5 >= v43.fields._size )
			//     goto LABEL_85;
			//   v44 = v43.fields._items;
			//   if ( !v44 )
			//     goto LABEL_51;
			//   items = v5;
			//   if ( (unsigned int)v5 >= v44.max_length.size )
			//     goto LABEL_52;
			//   v44.vector[(_QWORD)v5] = (HGWindSimpleManager_HGWindMotorState *)v11;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)(&v44.klass + (_QWORD)&v5._0.image + 4),
			//     (HGRenderPathBase_HGRenderPathResources *)wrapperArray,
			//     v41,
			//     v42,
			//     methoda,
			//     v56);
			//   ++*(_DWORD *)(v45 + 28);
			//   v57 = *(float *)(v11 + 92);
			//   *(_QWORD *)&v59.x = v25;
			//   v59.z = z;
			//   *(_OWORD *)&v60.windPriority = v18;
			//   *(_OWORD *)&v60.width = v19;
			//   *(__m128 *)&v60.angle = v15;
			//   v60.distanceToCamera = distanceToCamera;
			//   HG::Rendering::Runtime::HGWindSimpleManager::_SetWindMotorParams(
			//     this,
			//     cb,
			//     (int32_t)v5,
			//     &v60,
			//     &v59,
			//     *(Vector2 *)v31.m128_f32,
			//     v57,
			//     0LL);
			// }
			// 
		}

		public HGWindMotorData GetWindMotorData(HGWindMotor windMotor)
		{
			// // HGWindMotorData GetWindMotorData(HGWindMotor)
			// HGWindMotorData *HG::Rendering::Runtime::HGWindSimpleManager::GetWindMotorData(
			//         HGWindMotorData *__return_ptr retstr,
			//         HGWindSimpleManager *this,
			//         HGWindMotor *windMotor,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int128 v9; // xmm0
			//   float distanceToCamera; // eax
			//   __int128 v11; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGWindMotorData *v13; // rax
			//   HGWindMotorData v15; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919DD5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DD5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1449, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1449, 0LL);
			//     if ( Patch )
			//     {
			//       v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_546(&v15, Patch, (Object *)this, (Object *)windMotor, 0LL);
			//       v11 = *(_OWORD *)&v13.width;
			//       *(_OWORD *)&retstr.windPriority = *(_OWORD *)&v13.windPriority;
			//       v9 = *(_OWORD *)&v13.angle;
			//       distanceToCamera = v13.distanceToCamera;
			//       goto LABEL_11;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v8, v7);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Implicit((Object_1 *)windMotor, 0LL) )
			//   {
			//     if ( windMotor )
			//     {
			//       distanceToCamera = windMotor.fields.data.distanceToCamera;
			//       v11 = *(_OWORD *)&windMotor.fields.data.width;
			//       *(_OWORD *)&retstr.windPriority = *(_OWORD *)&windMotor.fields.data.windPriority;
			//       v9 = *(_OWORD *)&windMotor.fields.data.angle;
			// LABEL_11:
			//       *(_OWORD *)&retstr.width = v11;
			//       goto LABEL_12;
			//     }
			//     goto LABEL_9;
			//   }
			//   v9 = 0LL;
			//   distanceToCamera = 0.0;
			//   *(_OWORD *)&retstr.windPriority = 0LL;
			//   *(_OWORD *)&retstr.width = 0LL;
			// LABEL_12:
			//   *(_OWORD *)&retstr.angle = v9;
			//   retstr.distanceToCamera = distanceToCamera;
			//   return retstr;
			// }
			// 
			return null;
		}

		private void _SetupShaderVariablesWindFoot(ref ShaderVariablesGlobal cb, HGEnvironmentPhase phase)
		{
			// // Void _SetupShaderVariablesWindFoot(ShaderVariablesGlobal ByRef, HGEnvironmentPhase)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetupShaderVariablesWindFoot(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         HGEnvironmentPhase *phase,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGWindSimpleManager_HGWindFootMotor__Array *m_windFootMotors; // rax
			//   __m128 v10; // xmm3
			//   __m128 v11; // xmm6
			//   __m128 v12; // xmm5
			//   __m128 v13; // xmm4
			//   __m128 v14; // xmm2
			//   __m128 v15; // xmm2
			//   __m128 v16; // xmm2
			//   __m128 v17; // xmm2
			//   __m128 v18; // xmm3
			//   __m128 v19; // xmm3
			//   __m128 v20; // xmm3
			//   __m128 v21; // xmm3
			//   __m128 v22; // xmm2
			//   __m128 v23; // xmm3
			//   __m128 v24; // xmm2
			//   __m128 v25; // xmm3
			//   __m128 v26; // xmm2
			//   __m128 v27; // xmm2
			//   __m128 v28; // xmm3
			//   __m128 v29; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size <= 856 )
			//     goto LABEL_7;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			// LABEL_13:
			//     sub_180B536AC(v7, wrapperArray);
			//   if ( wrapperArray.max_length.size <= 0x358u )
			//     goto LABEL_14;
			//   if ( wrapperArray[23].vector[28] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(856, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)phase, 0LL);
			//       return;
			//     }
			//     goto LABEL_13;
			//   }
			// LABEL_7:
			//   m_windFootMotors = this.fields.m_windFootMotors;
			//   if ( !m_windFootMotors )
			//     goto LABEL_13;
			//   if ( m_windFootMotors.max_length.size > 0 )
			//   {
			//     v10 = (__m128)m_windFootMotors.vector[0];
			//     if ( m_windFootMotors.max_length.size > 1u )
			//     {
			//       v11 = (__m128)m_windFootMotors.vector[1];
			//       if ( m_windFootMotors.max_length.size > 2u )
			//       {
			//         v12 = (__m128)m_windFootMotors.vector[2];
			//         if ( m_windFootMotors.max_length.size > 3u )
			//         {
			//           v13 = (__m128)m_windFootMotors.vector[3];
			//           v14 = _mm_shuffle_ps(v10, v10, 85);
			//           v15 = _mm_shuffle_ps(v14, v14, 225);
			//           v15.m128_f32[0] = _mm_shuffle_ps(v10, v10, 170).m128_f32[0];
			//           v16 = _mm_shuffle_ps(v15, v15, 198);
			//           v16.m128_f32[0] = _mm_shuffle_ps(v10, v10, 255).m128_f32[0];
			//           v17 = _mm_shuffle_ps(v16, v16, 39);
			//           v17.m128_f32[0] = v10.m128_f32[0];
			//           v18 = _mm_shuffle_ps(v11, v11, 85);
			//           v19 = _mm_shuffle_ps(v18, v18, 225);
			//           v19.m128_f32[0] = _mm_shuffle_ps(v11, v11, 170).m128_f32[0];
			//           v20 = _mm_shuffle_ps(v19, v19, 198);
			//           v20.m128_f32[0] = _mm_shuffle_ps(v11, v11, 255).m128_f32[0];
			//           v21 = _mm_shuffle_ps(v20, v20, 39);
			//           v21.m128_f32[0] = v11.m128_f32[0];
			//           *(__m128 *)&cb._AtmosphereFogParams0.w = _mm_shuffle_ps(v17, v17, 57);
			//           *(__m128 *)&cb._AtmosphereFogParams1.w = _mm_shuffle_ps(v21, v21, 57);
			//           v22 = _mm_shuffle_ps(v12, v12, 85);
			//           v23 = _mm_shuffle_ps(v13, v13, 85);
			//           v24 = _mm_shuffle_ps(v22, v22, 225);
			//           v24.m128_f32[0] = _mm_shuffle_ps(v12, v12, 170).m128_f32[0];
			//           v25 = _mm_shuffle_ps(v23, v23, 225);
			//           v26 = _mm_shuffle_ps(v24, v24, 198);
			//           v26.m128_f32[0] = _mm_shuffle_ps(v12, v12, 255).m128_f32[0];
			//           v25.m128_f32[0] = _mm_shuffle_ps(v13, v13, 170).m128_f32[0];
			//           v27 = _mm_shuffle_ps(v26, v26, 39);
			//           v28 = _mm_shuffle_ps(v25, v25, 198);
			//           v27.m128_f32[0] = v12.m128_f32[0];
			//           v28.m128_f32[0] = _mm_shuffle_ps(v13, v13, 255).m128_f32[0];
			//           v29 = _mm_shuffle_ps(v28, v28, 39);
			//           v29.m128_f32[0] = v13.m128_f32[0];
			//           *(__m128 *)&cb._AtmosphereFogParams3.w = _mm_shuffle_ps(v29, v29, 57);
			//           *(__m128 *)&cb._AtmosphereFogParams2.w = _mm_shuffle_ps(v27, v27, 57);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180070270(v7, wrapperArray);
			//   }
			//   *(_OWORD *)&cb._AtmosphereFogParams0.w = 0LL;
			//   *(_OWORD *)&cb._AtmosphereFogParams1.w = 0LL;
			//   *(_OWORD *)&cb._AtmosphereFogParams2.w = 0LL;
			//   *(_OWORD *)&cb._AtmosphereFogParams3.w = 0LL;
			// }
			// 
		}

		private void _SetWindMotorParams(ref ShaderVariablesGlobal cb, int index, HGWindMotorData motorData, Vector3 position, Vector2 direction, float windTime)
		{
			// // Void _SetWindMotorParams(ShaderVariablesGlobal ByRef, Int32, HGWindMotorData, Vector3, Vector2, Single)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetWindMotorParams(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t index,
			//         HGWindMotorData *motorData,
			//         Vector3 *position,
			//         Vector2 direction,
			//         float windTime,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // r14
			//   struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int v14; // edi
			//   unsigned __int32 v15; // xmm4_4
			//   __int128 v16; // xmm5
			//   float v17; // xmm3_4
			//   float rangeIn; // xmm7_4
			//   float x; // xmm8_4
			//   float y; // xmm10_4
			//   float v21; // xmm9_4
			//   __int64 v22; // rax
			//   char v23; // r15
			//   float v24; // xmm1_4
			//   float v25; // xmm11_4
			//   float rectBackward; // xmm0_4
			//   float v27; // xmm2_4
			//   __int64 i; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // r10
			//   __int128 v30; // xmm1
			//   float distanceToCamera; // eax
			//   float z; // ecx
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm0
			//   double v35; // xmm0_8
			//   __int128 v36; // [rsp+50h] [rbp-89h] BYREF
			//   HGWindMotorData v37; // [rsp+60h] [rbp-79h] BYREF
			// 
			//   v9 = index;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v12.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_21;
			//   if ( wrapperArray.max_length.size > 854 )
			//   {
			//     if ( !v12._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v12, wrapperArray);
			//       v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v12 = (struct ILFixDynamicMethodWrapper_2__Class *)v12.static_fields.wrapperArray;
			//     if ( v12 )
			//     {
			//       if ( LODWORD(v12._0.namespaze) <= 0x356 )
			//         sub_180070270(v12, wrapperArray);
			//       if ( !v12[18]._0.generic_class )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(854, 0LL);
			//       if ( Patch )
			//       {
			//         v30 = *(_OWORD *)&motorData.width;
			//         distanceToCamera = motorData.distanceToCamera;
			//         z = position.z;
			//         *(_QWORD *)&v36 = *(_QWORD *)&position.x;
			//         v33 = *(_OWORD *)&motorData.windPriority;
			//         v37.distanceToCamera = distanceToCamera;
			//         *(_OWORD *)&v37.width = v30;
			//         *(_OWORD *)&v37.windPriority = v33;
			//         v34 = *(_OWORD *)&motorData.angle;
			//         *((float *)&v36 + 2) = z;
			//         *(_OWORD *)&v37.angle = v34;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_332(
			//           Patch,
			//           (Object *)this,
			//           cb,
			//           v9,
			//           &v37,
			//           (Vector3 *)&v36,
			//           direction,
			//           windTime,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(v12, wrapperArray);
			//   }
			// LABEL_7:
			//   v14 = 0;
			//   v15 = 0;
			//   LODWORD(v16) = 0;
			//   v17 = 0.0;
			//   rangeIn = 0.0;
			//   x = position.x;
			//   y = position.y;
			//   v21 = position.z;
			//   v22 = HIDWORD(*(_QWORD *)&motorData.windPriority);
			//   v36 = 0LL;
			//   if ( (_DWORD)v22 )
			//   {
			//     if ( (_DWORD)v22 == 1 )
			//     {
			//       v16 = *(_OWORD *)&motorData.width;
			//       v17 = motorData.windSpeed * 0.25;
			//       rangeIn = motorData.rangeIn;
			//       v15 = _mm_shuffle_ps(*(__m128 *)&motorData.windPriority, *(__m128 *)&motorData.windPriority, 255).m128_u32[0];
			//       v24 = direction.x;
			//       v25 = direction.y;
			//       rectBackward = (float)motorData.rectBackward;
			//       v27 = (float)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&motorData.angle, 8));
			//     }
			//     else
			//     {
			//       rectBackward = *((float *)&v36 + 3);
			//       v27 = *((float *)&v36 + 2);
			//       v25 = *((float *)&v36 + 1);
			//       v24 = *(float *)&v36;
			//     }
			//   }
			//   else
			//   {
			//     if ( COERCE_FLOAT(*(_OWORD *)&motorData.angle) <= 180.0 )
			//     {
			//       v23 = 0;
			//       v35 = Beyond::DampingMath::cosf();
			//       LODWORD(v16) = LODWORD(v35);
			//     }
			//     else
			//     {
			//       LODWORD(v16) = -1073741824;
			//       v23 = 1;
			//     }
			//     v17 = motorData.windSpeed * 0.25;
			//     v15 = _mm_shuffle_ps(*(__m128 *)&motorData.width, *(__m128 *)&motorData.width, 255).m128_u32[0];
			//     LODWORD(rangeIn) = _mm_shuffle_ps(*(__m128 *)&motorData.windPriority, *(__m128 *)&motorData.windPriority, 170).m128_u32[0];
			//     v24 = direction.x;
			//     v25 = direction.y;
			//     rectBackward = (float)(v23 != 0);
			//     v27 = (float)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&motorData.angle, 8));
			//   }
			//   for ( i = 0LL; ; ++i )
			//   {
			//     while ( 1 )
			//     {
			//       while ( !v14 )
			//       {
			//         *(&cb._AtmosphereFogParams5.w + 4 * v9 + i) = x;
			//         *((_DWORD *)&cb._ExponentialFogParams3.w + 4 * v9 + i) = v15;
			//         v14 = 1;
			//         *(&cb._VolumetricFogParams1.w + 4 * v9 + i++) = v24;
			//       }
			//       if ( v14 != 1 )
			//         break;
			//       *(&cb._AtmosphereFogParams5.w + 4 * v9 + i) = y;
			//       *((_DWORD *)&cb._ExponentialFogParams3.w + 4 * v9 + i) = v16;
			//       v14 = 2;
			//       *(&cb._VolumetricFogParams1.w + 4 * v9 + i++) = v25;
			//     }
			//     if ( v14 != 2 )
			//       break;
			//     *(&cb._AtmosphereFogParams5.w + 4 * v9 + i) = v21;
			//     *(&cb._ExponentialFogParams3.w + 4 * v9 + i) = v17;
			//     v14 = 3;
			//     *(&cb._VolumetricFogParams1.w + 4 * v9 + i) = v27;
			//   }
			//   *((_DWORD *)&cb._AtmosphereFogParams5.w + 4 * v9 + i) = LODWORD(motorData.height);
			//   *(&cb._ExponentialFogParams3.w + 4 * v9 + i) = rangeIn;
			//   *(&cb._VolumetricFogParams1.w + 4 * v9 + i) = rectBackward;
			//   *(&cb._HeightFogFlowNoiseParams0.w + 4 * (int)v9) = (float)(int)HIDWORD(*(_QWORD *)&motorData.windPriority);
			//   *(&cb._HeightFogFlowNoiseParams1.x + 4 * (int)v9) = windTime;
			// }
			// 
		}

		private void _SetLastWindMotorParams(ref ShaderVariablesGlobal cb, int index, HGWindMotorData lastMotorData, Vector3 lastPosition, Vector2 lastDirection, float lastWindTime)
		{
			// // Void _SetLastWindMotorParams(ShaderVariablesGlobal ByRef, Int32, HGWindMotorData, Vector3, Vector2, Single)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SetLastWindMotorParams(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t index,
			//         HGWindMotorData *lastMotorData,
			//         Vector3 *lastPosition,
			//         Vector2 lastDirection,
			//         float lastWindTime,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rsi
			//   struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   unsigned __int32 v14; // xmm4_4
			//   float x; // xmm8_4
			//   int v16; // xmm5_4
			//   float y; // xmm10_4
			//   float v18; // xmm3_4
			//   float v19; // xmm9_4
			//   float rangeIn; // xmm7_4
			//   __int64 v21; // rax
			//   __m128 v22; // xmm4
			//   int v23; // ecx
			//   __int64 i; // r8
			//   double v25; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v27; // xmm1
			//   float z; // ecx
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm0
			//   Vector3 v31; // [rsp+50h] [rbp-69h] BYREF
			//   HGWindMotorData v32; // [rsp+60h] [rbp-59h] BYREF
			// 
			//   v9 = index;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v12.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_23;
			//   if ( wrapperArray.max_length.size <= 853 )
			//     goto LABEL_7;
			//   if ( !v12._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v12, wrapperArray);
			//     v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v12 = (struct ILFixDynamicMethodWrapper_2__Class *)v12.static_fields.wrapperArray;
			//   if ( !v12 )
			// LABEL_23:
			//     sub_180B536AC(v12, wrapperArray);
			//   if ( LODWORD(v12._0.namespaze) <= 0x355 )
			//     sub_180070270(v12, wrapperArray);
			//   if ( v12[18]._0.parent )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(853, 0LL);
			//     if ( Patch )
			//     {
			//       v27 = *(_OWORD *)&lastMotorData.width;
			//       v32.distanceToCamera = lastMotorData.distanceToCamera;
			//       z = lastPosition.z;
			//       *(_QWORD *)&v31.x = *(_QWORD *)&lastPosition.x;
			//       v29 = *(_OWORD *)&lastMotorData.windPriority;
			//       v31.z = z;
			//       *(_OWORD *)&v32.windPriority = v29;
			//       v30 = *(_OWORD *)&lastMotorData.angle;
			//       *(_OWORD *)&v32.width = v27;
			//       *(_OWORD *)&v32.angle = v30;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_332(
			//         Patch,
			//         (Object *)this,
			//         cb,
			//         v9,
			//         &v32,
			//         &v31,
			//         lastDirection,
			//         lastWindTime,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_23;
			//   }
			// LABEL_7:
			//   v14 = 0;
			//   x = lastPosition.x;
			//   v16 = 0;
			//   y = lastPosition.y;
			//   v18 = 0.0;
			//   v19 = lastPosition.z;
			//   rangeIn = 0.0;
			//   v21 = HIDWORD(*(_QWORD *)&lastMotorData.windPriority);
			//   if ( !(_DWORD)v21 )
			//   {
			//     if ( COERCE_FLOAT(*(_OWORD *)&lastMotorData.angle) <= 180.0 )
			//     {
			//       v25 = Beyond::DampingMath::cosf();
			//       v16 = LODWORD(v25);
			//     }
			//     else
			//     {
			//       v16 = -1073741824;
			//     }
			//     v22 = *(__m128 *)&lastMotorData.width;
			//     LODWORD(rangeIn) = _mm_shuffle_ps(
			//                          *(__m128 *)&lastMotorData.windPriority,
			//                          *(__m128 *)&lastMotorData.windPriority,
			//                          170).m128_u32[0];
			//     goto LABEL_11;
			//   }
			//   if ( (_DWORD)v21 == 1 )
			//   {
			//     rangeIn = lastMotorData.rangeIn;
			//     v22 = *(__m128 *)&lastMotorData.windPriority;
			//     v16 = *(_OWORD *)&lastMotorData.width;
			// LABEL_11:
			//     v18 = lastMotorData.windSpeed * 0.25;
			//     v14 = _mm_shuffle_ps(v22, v22, 255).m128_u32[0];
			//   }
			//   v23 = 0;
			//   for ( i = 0LL; ; ++i )
			//   {
			//     while ( 1 )
			//     {
			//       while ( !v23 )
			//       {
			//         *(&cb._CloudShadowParams1.w + 4 * v9 + i) = x;
			//         v23 = 1;
			//         *((_DWORD *)&cb._Style_MatFarAlb0.w + 4 * v9 + i++) = v14;
			//       }
			//       if ( v23 != 1 )
			//         break;
			//       *(&cb._CloudShadowParams1.w + 4 * v9 + i) = y;
			//       v23 = 2;
			//       *((_DWORD *)&cb._Style_MatFarAlb0.w + 4 * v9 + i++) = v16;
			//     }
			//     if ( v23 != 2 )
			//       break;
			//     *(&cb._CloudShadowParams1.w + 4 * v9 + i) = v19;
			//     v23 = 3;
			//     *(&cb._Style_MatFarAlb0.w + 4 * v9 + i) = v18;
			//   }
			//   *((_DWORD *)&cb._CloudShadowParams1.w + 4 * v9 + i) = LODWORD(lastMotorData.height);
			//   *(&cb._Style_MatFarAlb0.w + 4 * v9 + i) = rangeIn;
			//   *(&cb._Style_GbCoef.w + 4 * (int)v9) = (float)(int)HIDWORD(*(_QWORD *)&lastMotorData.windPriority);
			//   *(&cb._VFXParams0.x + 4 * (int)v9) = lastWindTime;
			// }
			// 
		}

		private void _SortWindMotorsForSingleCamera(Vector3 cameraPos)
		{
			// // Void _SortWindMotorsForSingleCamera(Vector3)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_SortWindMotorsForSingleCamera(
			//         HGWindSimpleManager *this,
			//         Vector3 *cameraPos,
			//         MethodInfo *method)
			// {
			//   _QWORD **items; // rcx
			//   _QWORD *v6; // rdx
			//   unsigned int i; // ebx
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rax
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *v9; // rdi
			//   struct HGWindSimpleManager_c__Class *v10; // rcx
			//   Comparison_1_HG_Rendering_Runtime_HGWindMotor_ *_9__30_0; // rbx
			//   struct MethodInfo *v12; // rsi
			//   float z; // eax
			//   Vector3 *Position; // rax
			//   __int64 v15; // xmm0_8
			//   MethodInfo *v16; // r9
			//   Vector3 *v17; // rax
			//   __int64 v18; // xmm3_8
			//   _QWORD *v19; // rdi
			//   double v20; // xmm0_8
			//   Object__Array *v21; // rbp
			//   int32_t size; // r14d
			//   __int64 v23; // rax
			//   __int64 v24; // rdx
			//   Object *v25; // rsi
			//   Comparison_1_Object_ *v26; // rax
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v31; // xmm0_8
			//   MethodInfo *methoda; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v33; // [rsp+28h] [rbp-60h]
			//   Vector3 v34; // [rsp+30h] [rbp-58h] BYREF
			//   Vector3 v35; // [rsp+40h] [rbp-48h] BYREF
			//   __int64 v36; // [rsp+50h] [rbp-38h] BYREF
			//   int v37; // [rsp+58h] [rbp-30h]
			//   Vector3 v38; // [rsp+60h] [rbp-28h] BYREF
			//   Vector3 v39[2]; // [rsp+70h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDCC7 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Runtime::HGWindMotor>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Sort);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::get_Item);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c::__SortWindMotorsForSingleCamera_b__30_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c);
			//     byte_18D8EDCC7 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cameraPos);
			//     items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (_QWORD *)*items[23];
			//   if ( !v6 )
			//     goto LABEL_30;
			//   if ( *((int *)v6 + 6) > 844 )
			//   {
			//     if ( !*((_DWORD *)items + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(items, v6);
			//       items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v6 = (_QWORD *)*items[23];
			//     if ( !v6 )
			//       goto LABEL_30;
			//     if ( *((_DWORD *)v6 + 6) <= 0x34Cu )
			// LABEL_35:
			//       sub_180070270(items, v6);
			//     if ( v6[848] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(844, 0LL);
			//       if ( Patch )
			//       {
			//         v31 = *(_QWORD *)&cameraPos.x;
			//         v34.z = cameraPos.z;
			//         *(_QWORD *)&v34.x = v31;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, &v34, 0LL);
			//         return;
			//       }
			//       goto LABEL_30;
			//     }
			//   }
			//   for ( i = 0; ; ++i )
			//   {
			//     m_windMotors = this.fields.m_windMotors;
			//     if ( !m_windMotors )
			//       goto LABEL_30;
			//     v9 = this.fields.m_windMotors;
			//     if ( (signed int)i >= m_windMotors.fields._size )
			//       break;
			//     if ( i >= m_windMotors.fields._size )
			//       goto LABEL_43;
			//     items = (_QWORD **)m_windMotors.fields._items;
			//     if ( !items )
			//       goto LABEL_30;
			//     if ( i >= *((_DWORD *)items + 6) )
			//       goto LABEL_35;
			//     v6 = items[(int)i + 4];
			//     if ( !v6 )
			//       goto LABEL_30;
			//     z = cameraPos.z;
			//     *(_QWORD *)&v34.x = *(_QWORD *)&cameraPos.x;
			//     v34.z = z;
			//     Position = HG::Rendering::Runtime::HGWindMotor::GetPosition(&v38, (HGWindMotor *)v6, 0LL);
			//     v15 = *(_QWORD *)&Position.x;
			//     *(float *)&Position = Position.z;
			//     *(_QWORD *)&v35.x = v15;
			//     LODWORD(v35.z) = (_DWORD)Position;
			//     v17 = UnityEngine::Vector3::op_Subtraction(v39, &v35, &v34, v16);
			//     items = (_QWORD **)this.fields.m_windMotors;
			//     v18 = *(_QWORD *)&v17.x;
			//     *(float *)&v17 = v17.z;
			//     v36 = v18;
			//     v37 = (int)v17;
			//     if ( !items )
			//       goto LABEL_30;
			//     if ( i >= *((_DWORD *)items + 6) )
			// LABEL_43:
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     items = (_QWORD **)items[2];
			//     if ( !items )
			//       goto LABEL_30;
			//     if ( i >= *((_DWORD *)items + 6) )
			//       goto LABEL_35;
			//     v19 = items[(int)i + 4];
			//     if ( !v19 )
			//       goto LABEL_30;
			//     v20 = sub_18238EFA0(&v36);
			//     *((_DWORD *)v19 + 20) = LODWORD(v20);
			//   }
			//   v10 = TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c, v6);
			//     v10 = TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c;
			//   }
			//   _9__30_0 = v10.static_fields.__9__30_0;
			//   if ( _9__30_0 )
			//     goto LABEL_15;
			//   if ( !v10._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v10, v6);
			//     v10 = TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c;
			//   }
			//   v25 = (Object *)v10.static_fields.__9;
			//   v26 = (Comparison_1_Object_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Runtime::HGWindMotor>);
			//   _9__30_0 = (Comparison_1_HG_Rendering_Runtime_HGWindMotor_ *)v26;
			//   if ( !v26 )
			// LABEL_30:
			//     sub_180B536AC(items, v6);
			//   System::Comparison<System::Object>::Comparison(
			//     v26,
			//     v25,
			//     MethodInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c::__SortWindMotorsForSingleCamera_b__30_0,
			//     0LL);
			//   TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c.static_fields.__9__30_0 = _9__30_0;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGWindSimpleManager::__c.static_fields.__9__30_0,
			//     v27,
			//     v28,
			//     v29,
			//     methoda,
			//     v33);
			// LABEL_15:
			//   v12 = MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Sort;
			//   if ( v9.fields._size > 1 )
			//   {
			//     v21 = (Object__Array *)v9.fields._items;
			//     size = v9.fields._size;
			//     v23 = ((__int64 (__fastcall *)(_QWORD))sub_18010B520)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Sort.klass.rgctx_data[52].rgctxDataDummy);
			//     if ( !*(_DWORD *)(v23 + 224) )
			//       il2cpp_runtime_class_init_0(v23, v24);
			//     System::Collections::Generic::ArraySortHelper<System::Object>::Sort(
			//       v21,
			//       0,
			//       size,
			//       (Comparison_1_Object_ *)_9__30_0,
			//       (MethodInfo *)v12.klass.rgctx_data[51].rgctxDataDummy);
			//   }
			//   ++v9.fields._version;
			// }
			// 
		}

		private void _ClearShaderVariablesWindMotor(ref ShaderVariablesGlobal cb, int index)
		{
			// // Void _ClearShaderVariablesWindMotor(ShaderVariablesGlobal ByRef, Int32)
			// void HG::Rendering::Runtime::HGWindSimpleManager::_ClearShaderVariablesWindMotor(
			//         HGWindSimpleManager *this,
			//         ShaderVariablesGlobal *cb,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdi
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v5 = index;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 855 )
			//   {
			// LABEL_7:
			//     *((_DWORD *)&cb._AtmosphereFogParams5.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams3.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VolumetricFogParams1.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._HeightFogFlowNoiseParams0.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams0.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams4.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VolumetricFogParams2.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._HeightFogFlowNoiseParams1.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams0.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams4.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VolumetricFogParams2.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._HeightFogFlowNoiseParams1.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams0.z + 4 * v5) = 0;
			//     *((_DWORD *)&cb._ExponentialFogParams4.z + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VolumetricFogParams2.z + 4 * v5) = 0;
			//     *((_DWORD *)&cb._HeightFogFlowNoiseParams1.z + 4 * v5) = 0;
			//     *((_DWORD *)&cb._CloudShadowParams1.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._Style_MatFarAlb0.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._Style_GbCoef.w + 4 * v5) = 0;
			//     *((_DWORD *)&cb._CloudShadowParams2.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._Style_MatFarAlb1.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VFXParams0.x + 4 * v5) = 0;
			//     *((_DWORD *)&cb._CloudShadowParams2.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._Style_MatFarAlb1.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VFXParams0.y + 4 * v5) = 0;
			//     *((_DWORD *)&cb._CloudShadowParams2.z + 4 * v5) = 0;
			//     *((_DWORD *)&cb._Style_MatFarAlb1.z + 4 * v5) = 0;
			//     *((_DWORD *)&cb._VFXParams0.z + 4 * v5) = 0;
			//     return;
			//   }
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   if ( LODWORD(v7._0.namespaze) <= 0x357 )
			//     sub_180070270(v7, wrapperArray);
			//   if ( !v7[18]._0.typeMetadataHandle )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(855, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v7, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(Patch, (Object *)this, cb, v5, 0LL);
			// }
			// 
		}

		private void _CleanupInvalidCameraStates()
		{
			// // Void _CleanupInvalidCameraStates()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGWindSimpleManager::_CleanupInvalidCameraStates(
			//         HGWindSimpleManager *this,
			//         MethodInfo *method)
			// {
			//   HGWindSimpleManager *v2; // r14
			//   __int64 v3; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGWindSimpleManager_HGMainWindState_ *m_windMainState; // rax
			//   __int64 count; // rcx
			//   List_1_System_Int32_ *m_validCameraIds; // rbx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Camera__Array *allCameras; // rdi
			//   unsigned int i; // ebx
			//   Object_1 *v11; // r13
			//   List_1_System_Int32_ *v12; // rsi
			//   int32_t InstanceID; // eax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   List_1_System_Int32_ *m_keysToRemove; // rbx
			//   Dictionary_2_TKey_TValue_KeyCollection_UnityEngine_InputSystem_Utilities_InternedString_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_PrecompiledLayout_ *Keys; // rax
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   __int64 v19; // rcx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   Dictionary_2_UnityEngine_InputSystem_Utilities_InternedString_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_PrecompiledLayout_ *dictionary; // rbx
			//   __int64 v23; // rdx
			//   signed __int64 items; // rcx
			//   __int64 v25; // r9
			//   __int64 *v26; // rdx
			//   __int64 v27; // r8
			//   __int64 v28; // rax
			//   int32_t v29; // edi
			//   List_1_System_Int32_ *v30; // rbx
			//   struct MethodInfo *v31; // rsi
			//   List_1_System_Int32_ *v32; // rbx
			//   struct MethodInfo *v33; // rsi
			//   __int64 size; // rdx
			//   List_1_System_Int32_ *v35; // r9
			//   __int64 v36; // rtt
			//   __int64 v37; // rax
			//   __int64 v38; // rdx
			//   __int64 v39; // rdx
			//   __int64 v40; // rdx
			//   Dictionary_2_System_Int32_System_Object_ *v41; // rcx
			//   Il2CppClass *klass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   __int64 v46; // [rsp+0h] [rbp-A8h] BYREF
			//   MethodInfo *v47; // [rsp+20h] [rbp-88h] BYREF
			//   MethodInfo *v48; // [rsp+28h] [rbp-80h] BYREF
			//   _BYTE v49[24]; // [rsp+30h] [rbp-78h] BYREF
			//   __int128 v50; // [rsp+48h] [rbp-60h] BYREF
			//   __int64 v51; // [rsp+58h] [rbp-50h]
			//   __int128 v52; // [rsp+60h] [rbp-48h] BYREF
			//   __int64 v53; // [rsp+70h] [rbp-38h]
			// 
			//   v2 = this;
			//   if ( !byte_18D8EDCC8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Keys);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCC8 = 1;
			//   }
			//   v52 = 0LL;
			//   v53 = 0LL;
			//   v50 = 0LL;
			//   v51 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1436, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1436, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v45, v44);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else if ( v2.fields.m_windMainState )
			//   {
			//     m_windMainState = v2.fields.m_windMainState;
			//     count = (unsigned int)m_windMainState.fields._count;
			//     if ( (_DWORD)count != m_windMainState.fields._freeCount )
			//     {
			//       m_validCameraIds = v2.fields.m_validCameraIds;
			//       if ( !m_validCameraIds )
			//         sub_180B536AC(count, v3);
			//       ++m_validCameraIds.fields._version;
			//       m_validCameraIds.fields._size = 0;
			//       allCameras = UnityEngine::Camera::get_allCameras(0LL);
			//       for ( i = 0; ; ++i )
			//       {
			//         if ( !allCameras )
			//           sub_180B536AC(v8, v7);
			//         if ( (signed int)i >= allCameras.max_length.size )
			//           break;
			//         if ( i >= allCameras.max_length.size )
			//           sub_180070270(v8, v7);
			//         v11 = (Object_1 *)allCameras.vector[i];
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//         if ( UnityEngine::Object::op_Inequality(v11, 0LL, 0LL) )
			//         {
			//           v12 = v2.fields.m_validCameraIds;
			//           if ( i >= allCameras.max_length.size )
			//             sub_180070270(v8, v7);
			//           if ( !allCameras.vector[i] )
			//             sub_180B536AC(v8, v7);
			//           InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)allCameras.vector[i], 0LL);
			//           if ( !v12 )
			//             sub_180B536AC(v15, v14);
			//           sub_18231EF50(v12, InstanceID);
			//         }
			//       }
			//       m_keysToRemove = v2.fields.m_keysToRemove;
			//       if ( !m_keysToRemove )
			//         sub_180B536AC(v8, v7);
			//       ++m_keysToRemove.fields._version;
			//       m_keysToRemove.fields._size = 0;
			//       if ( !v2.fields.m_windMainState )
			//         sub_180B536AC(v8, v7);
			//       Keys = System::Collections::Generic::Dictionary<UnityEngine::InputSystem::Utilities::InternedString,UnityEngine::InputSystem::Layouts::InputControlLayout_Collection::PrecompiledLayout>::get_Keys(
			//                (Dictionary_2_UnityEngine_InputSystem_Utilities_InternedString_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_PrecompiledLayout_ *)v2.fields.m_windMainState,
			//                MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::get_Keys);
			//       if ( !Keys )
			//         sub_180B536AC(v19, v18);
			//       dictionary = Keys.fields._dictionary;
			//       *(_OWORD *)&v49[8] = 0LL;
			//       *(_QWORD *)v49 = dictionary;
			//       sub_1800054D0((HGRenderPathScene *)v49, v18, v20, v21, v47, v48);
			//       if ( !dictionary )
			//         sub_180B536AC(items, v23);
			//       *(_DWORD *)&v49[12] = dictionary.fields._version;
			//       *(_DWORD *)&v49[8] = 0;
			//       *(_DWORD *)&v49[16] = 0;
			//       v52 = *(_OWORD *)v49;
			//       v53 = *(_QWORD *)&v49[16];
			//       *(_QWORD *)v49 = 0LL;
			//       *(_QWORD *)&v49[8] = &v52;
			//       try
			//       {
			// LABEL_24:
			//         v26 = (__int64 *)v52;
			//         if ( !(_QWORD)v52 )
			//           sub_1802DC2C8(items, 0LL);
			//         if ( HIDWORD(v52) != *(_DWORD *)(v52 + 44) )
			//           System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//         items = DWORD2(v52);
			//         while ( (unsigned int)items < *(_DWORD *)(v52 + 32) )
			//         {
			//           v27 = *(_QWORD *)(v52 + 24);
			//           v28 = (int)items;
			//           items = (unsigned int)(items + 1);
			//           DWORD2(v52) = items;
			//           if ( !v27 )
			//             sub_1802DC2C8(items, v52);
			//           if ( (unsigned int)v28 >= *(_DWORD *)(v27 + 24) )
			//             sub_180070260(items, v52, v27, v25);
			//           v25 = v27 + 24 * v28;
			//           if ( *(int *)(v25 + 32) >= 0 )
			//           {
			//             v29 = *(_DWORD *)(v25 + 40);
			//             LODWORD(v53) = v29;
			//             v30 = v2.fields.m_validCameraIds;
			//             if ( !v30 )
			//               sub_1802DC2C8(items, v52);
			//             v31 = MethodInfo::System::Collections::Generic::List<int>::Contains;
			//             if ( !v30.fields._size )
			//               goto LABEL_36;
			//             if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::List<int>::Contains.klass.rgctx_data[20].rgctxDataDummy
			//                   + 4) )
			//               (*(void (**)(void))MethodInfo::System::Collections::Generic::List<int>::Contains.klass.rgctx_data[20].rgctxDataDummy)();
			//             if ( System::Collections::Generic::List<int>::IndexOf(
			//                    v30,
			//                    v29,
			//                    (MethodInfo *)v31.klass.rgctx_data[20].rgctxDataDummy) == -1 )
			//             {
			// LABEL_36:
			//               v32 = v2.fields.m_keysToRemove;
			//               if ( !v32 )
			//                 sub_1802DC2C8(items, v26);
			//               v33 = MethodInfo::System::Collections::Generic::List<int>::Add;
			//               ++v32.fields._version;
			//               items = (signed __int64)v32.fields._items;
			//               size = v32.fields._size;
			//               if ( !items )
			//                 sub_1802DC2C8(0LL, size);
			//               if ( (unsigned int)size < *(_DWORD *)(items + 24) )
			//               {
			//                 v32.fields._size = size + 1;
			//                 if ( (unsigned int)size >= *(_DWORD *)(items + 24) )
			//                   sub_180070260(items, size, v27, v25);
			//                 *(_DWORD *)(items + 4 * size + 32) = v29;
			//               }
			//               else
			//               {
			//                 if ( !*((_QWORD *)v33.klass.rgctx_data[11].rgctxDataDummy + 4) )
			//                   (*(void (**)(void))v33.klass.rgctx_data[11].rgctxDataDummy)();
			//                 System::Collections::Generic::List<int>::AddWithResize(
			//                   v32,
			//                   v29,
			//                   (MethodInfo *)v33.klass.rgctx_data[11].rgctxDataDummy);
			//               }
			//             }
			//             goto LABEL_24;
			//           }
			//         }
			//         DWORD2(v52) = *(_DWORD *)(v52 + 32) + 1;
			//         LODWORD(v53) = 0;
			//       }
			//       catch ( Il2CppExceptionWrapper *v47 )
			//       {
			//         v26 = &v46;
			//         *(_QWORD *)v49 = v47.methodPointer;
			//         items = *(_QWORD *)v49;
			//         if ( *(_QWORD *)v49 )
			//           sub_18000F780(*(_QWORD *)v49);
			//         v2 = this;
			//       }
			//       v35 = v2.fields.m_keysToRemove;
			//       if ( !v35 )
			//         sub_1802DC2C8(items, v26);
			//       *(_OWORD *)&v49[8] = 0LL;
			//       *(_QWORD *)v49 = v35;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v26 = &qword_18D6870D0[(((unsigned __int64)v49 >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(v26);
			//         do
			//         {
			//           items = *v26 | (1LL << (((unsigned __int64)v49 >> 12) & 0x3F));
			//           v36 = *v26;
			//         }
			//         while ( v36 != _InterlockedCompareExchange64(v26, items, *v26) );
			//       }
			//       *(_DWORD *)&v49[8] = 0;
			//       *(_DWORD *)&v49[12] = v35.fields._version;
			//       *(_DWORD *)&v49[16] = 0;
			//       v50 = *(_OWORD *)v49;
			//       v51 = *(_QWORD *)&v49[16];
			//       *(_QWORD *)v49 = 0LL;
			//       *(_QWORD *)&v49[8] = &v50;
			//       try
			//       {
			//         while ( 1 )
			//         {
			//           v37 = v50;
			//           if ( !(_QWORD)v50 )
			//             sub_1802DC2C8(items, v26);
			//           v38 = HIDWORD(v50);
			//           if ( HIDWORD(v50) != *(_DWORD *)(v50 + 28) || DWORD2(v50) >= *(_DWORD *)(v50 + 24) )
			//             break;
			//           v39 = *(_QWORD *)(v50 + 16);
			//           if ( !v39 )
			//             sub_1802DC2C8(SDWORD2(v50), 0LL);
			//           if ( DWORD2(v50) >= *(_DWORD *)(v39 + 24) )
			//             sub_180070260(
			//               SDWORD2(v50),
			//               v39,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext,
			//               v35);
			//           v40 = *(unsigned int *)(v39 + 4LL * SDWORD2(v50) + 32);
			//           LODWORD(v51) = v40;
			//           ++DWORD2(v50);
			//           v41 = (Dictionary_2_System_Int32_System_Object_ *)v2.fields.m_windMainState;
			//           if ( !v41 )
			//             sub_1802DC2C8(0LL, v40);
			//           System::Collections::Generic::Dictionary<int,System::Object>::Remove(
			//             v41,
			//             v40,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Remove);
			//         }
			//         klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext.klass;
			//         if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//         {
			//           sub_18003C700(klass);
			//           v38 = HIDWORD(v50);
			//           v37 = v50;
			//         }
			//         if ( !v37 )
			//           sub_1802DC2C8(klass, v38);
			//         if ( (_DWORD)v38 != *(_DWORD *)(v37 + 28) )
			//           System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//         DWORD2(v50) = *(_DWORD *)(v37 + 24) + 1;
			//         LODWORD(v51) = 0;
			//       }
			//       catch ( Il2CppExceptionWrapper *v48 )
			//       {
			//         *(_QWORD *)v49 = v48.methodPointer;
			//         if ( *(_QWORD *)v49 )
			//           sub_18000F780(*(_QWORD *)v49);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGWindSimpleManager::Dispose(HGWindSimpleManager *this, MethodInfo *method)
			// {
			//   List_1_HG_Rendering_Runtime_HGWindMotor_ *m_windMotors; // rcx
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *m_windMainState; // rcx
			//   List_1_HG_Rendering_Runtime_HGWindSimpleManager_HGWindMotorState_ *m_windMotorState; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919DD6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Clear);
			//     byte_18D919DD6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1439, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1439, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_windMotors = this.fields.m_windMotors;
			//     if ( m_windMotors )
			//       sub_1823B99D0(
			//         m_windMotors,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindMotor>::Clear);
			//     m_windMainState = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_windMainState;
			//     if ( m_windMainState )
			//       System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//         m_windMainState,
			//         MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGWindSimpleManager::HGMainWindState>::Clear);
			//     m_windMotorState = this.fields.m_windMotorState;
			//     if ( m_windMotorState )
			//       sub_1823B99D0(
			//         m_windMotorState,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWindSimpleManager::HGWindMotorState>::Clear);
			//   }
			// }
			// 
		}

		private const int MAX_WIND_MOTOR_COUNT = 4;

		private float m_cleanupTimer;

		private const float CLEANUP_INTERVAL = 60f;

		private HGWindSimpleManager.HGWindFootMotor[] m_windFootMotors;

		private List<HGWindMotor> m_windMotors;

		private Dictionary<int, HGWindSimpleManager.HGMainWindState> m_windMainState;

		private List<HGWindSimpleManager.HGWindMotorState> m_windMotorState;

		private List<int> m_validCameraIds;

		private List<int> m_keysToRemove;

		public HGWindParamDataCache m_windParamDataCache;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct HGWindFootMotor
		{
			public float range;

			public Vector3 position;
		}

		public class HGMainWindState
		{
			public HGMainWindState()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public float lastIntensity;

			public Vector3 lastDirection;

			public Vector2 lastNoiseUV;

			public float lastWindTime;

			public Vector2 curNoiseUV;

			public float curWindTime;
		}

		public class HGWindMotorState
		{
			public HGWindMotorState()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public HGWindMotorData lastData;

			public float lastWindTime;

			public Vector2 lastDirection;

			public Vector3 lastPosition;

			public float curWindTime;
		}
	}
}
