using System;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class HGFoliageOccluderManager
	{
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x000025D2 File Offset: 0x000007D2
		private Vector4 occluderScaleParam
		{
			get
			{
				// // Vector4 get_occluderScaleParam()
				// Vector4 *HG::Rendering::Runtime::HGFoliageOccluderManager::get_occluderScaleParam(
				//         Vector4 *__return_ptr retstr,
				//         HGFoliageOccluderManager *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2171, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2171, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v9, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     *(_QWORD *)&retstr.z = LODWORD(this.fields.m_lodFadeValue);
				//     retstr.x = 32.0;
				//     retstr.y = 512.0;
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public HGFoliageOccluderManager()
		{
			// // HGFoliageOccluderManager()
			// void HG::Rendering::Runtime::HGFoliageOccluderManager::HGFoliageOccluderManager(
			//         HGFoliageOccluderManager *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   FileDescriptor *v4; // r8
			//   MessageDescriptor *v5; // r9
			//   String__Array *v6; // [rsp+50h] [rbp+28h]
			//   String *v7; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v8; // [rsp+60h] [rbp+38h]
			// 
			//   this.fields.m_lastUpdateCameraPos = (Vector2)sub_182E7A130(this, method);
			//   this.fields.m_curMaskIsA = 1;
			//   this.fields.m_currentCameraPos = 0LL;
			//   this.fields.m_params = HG::Rendering::Runtime::HGFoliageOccluderRenderParams::get_defaultParams(0LL);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_params, v3, v4, v5, v6, v7, v8);
			// }
			// 
		}

		public HGFoliageOccluderRenderParams GetParams()
		{
			// // HGFoliageOccluderRenderParams GetParams()
			// HGFoliageOccluderRenderParams *HG::Rendering::Runtime::HGFoliageOccluderManager::GetParams(
			//         HGFoliageOccluderManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2172, 0LL) )
			//     return this.fields.m_params;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2172, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_790(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void PipelineUpdate()
		{
			// // Void PipelineUpdate()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGFoliageOccluderManager::PipelineUpdate(
			//         HGFoliageOccluderManager *this,
			//         MethodInfo *method)
			// {
			//   HGFoliageOccluderManager *v2; // rdi
			//   HGFoliageOccluderManager *v3; // r13
			//   struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   double v10; // xmm6_8
			//   bool IsCurrFrameTriggerTransition; // al
			//   __int64 v12; // rdx
			//   double m_currentTimeStamp; // xmm1_8
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   float z; // xmm8_4
			//   char v17; // r12
			//   struct HGCamera__Class *v18; // rax
			//   HGCamera__StaticFields *static_fields; // rax
			//   Dictionary_2_TKey_TValue_ValueCollection_System_UInt64_System_Object_ *Values; // rax
			//   OneofDescriptorProto *v21; // rdx
			//   __int64 v22; // rcx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   Dictionary_2_System_UInt64_System_Object_ *dictionary; // rbx
			//   unsigned __int64 v26; // rdx
			//   signed __int64 v27; // rcx
			//   MessageDescriptor *v28; // r9
			//   __int64 v29; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rax
			//   __int64 v32; // rax
			//   __int64 v33; // rcx
			//   OneofDescriptor__Class *klass; // rsi
			//   Il2CppGenericClass *generic_class; // r14
			//   unsigned int v36; // r8d
			//   __int64 v37; // rbx
			//   void (__fastcall __noreturn **v38)(); // rax
			//   unsigned int v39; // eax
			//   unsigned int v40; // r8d
			//   __int64 v41; // rax
			//   char v42; // r8
			//   signed __int64 v43; // rtt
			//   __int64 v44; // rbx
			//   __int64 v45; // rax
			//   __int64 v46; // rbx
			//   _QWORD **v47; // rcx
			//   __int64 v48; // r8
			//   __int64 v49; // rax
			//   unsigned int v50; // r8d
			//   __int64 v51; // rbx
			//   void (__fastcall __noreturn **v52)(); // rax
			//   unsigned int v53; // eax
			//   unsigned int v54; // r8d
			//   __int64 v55; // rax
			//   char v56; // r8
			//   signed __int64 v57; // rtt
			//   __int64 v58; // rbx
			//   __int64 v59; // rax
			//   __int64 v60; // rbx
			//   _QWORD **v61; // rcx
			//   __int64 v62; // r8
			//   __int64 v63; // rax
			//   Il2CppGenericClass *v64; // rbx
			//   unsigned int (__fastcall *v65)(Il2CppGenericClass *); // rax
			//   Il2CppGenericClass *v66; // rbx
			//   unsigned int (__fastcall *v67)(Il2CppGenericClass *); // rax
			//   Il2CppGenericClass *v68; // rbx
			//   __int64 (__fastcall *v69)(Il2CppGenericClass *); // rax
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   __int64 v72; // rbx
			//   void (__fastcall *v73)(__int64, Vector3 *); // rax
			//   int z_low; // r15d
			//   __int64 (*v75)(void); // rax
			//   __int64 v76; // rdx
			//   Object_1 *v77; // rbx
			//   System::MathF *v78; // rcx
			//   __int64 (*v79)(void); // rax
			//   HGFoliageOccluderRenderParams *v80; // rcx
			//   __int64 v81; // rbx
			//   __int64 (__fastcall *v82)(__int64); // rax
			//   __int64 v83; // rbx
			//   void (__fastcall *v84)(__int64, Vector3 *); // rax
			//   System::MathF *v85; // rcx
			//   float y; // xmm0_4
			//   HGFoliageOccluderRenderParams *m_params; // rbx
			//   Matrix4x4 *CullingMatrix; // rax
			//   __int128 v89; // xmm1
			//   __int128 v90; // xmm2
			//   __int128 v91; // xmm3
			//   double (*v92)(void); // rax
			//   float v93; // xmm2_4
			//   __int64 v94; // rax
			//   __int64 v95; // rax
			//   __int64 v96; // rax
			//   __int64 v97; // rax
			//   __int64 v98; // rax
			//   __int64 v99; // rax
			//   __int64 v100; // rax
			//   __int64 v101; // rax
			//   __int64 v102; // rax
			//   String__Array *v103; // [rsp+20h] [rbp-158h]
			//   String__Array *v104; // [rsp+20h] [rbp-158h]
			//   String *v105; // [rsp+28h] [rbp-150h]
			//   String *v106; // [rsp+28h] [rbp-150h]
			//   Vector3 v107; // [rsp+30h] [rbp-148h] BYREF
			//   Vector3 v108; // [rsp+40h] [rbp-138h] BYREF
			//   __int128 v109; // [rsp+50h] [rbp-128h] BYREF
			//   OneofDescriptor v110; // [rsp+60h] [rbp-118h] BYREF
			//   Il2CppExceptionWrapper *v111; // [rsp+B8h] [rbp-C0h] BYREF
			//   Matrix4x4 v112[2]; // [rsp+C0h] [rbp-B8h] BYREF
			//   char v114; // [rsp+190h] [rbp+18h]
			// 
			//   v2 = this;
			//   v3 = this;
			//   if ( !byte_18D8ED9B3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Values);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__ValueCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::GetEnumerator);
			//     byte_18D8ED9B3 = 1;
			//   }
			//   v109 = 0LL;
			//   v110.klass = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v4.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v4, method);
			//   if ( wrapperArray.max_length.size <= 1969 )
			//     goto LABEL_16;
			//   if ( !v4._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v4, method);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = v4.static_fields.wrapperArray;
			//   if ( !v6 )
			//     sub_180B536AC(v4, method);
			//   if ( v6.max_length.size <= 0x7B1u )
			//     sub_180070270(v4, method);
			//   if ( !v6[54].vector[25] )
			//   {
			// LABEL_16:
			//     v2.fields.m_shouldRender = 0;
			//     v10 = UnityEngine::Time::get_timeAsDouble(0LL) - v2.fields.m_currentTimeStamp;
			//     IsCurrFrameTriggerTransition = UnityEngine::HyperGryph::HGLODStateSystem::IsCurrFrameTriggerTransition(0LL);
			//     if ( IsCurrFrameTriggerTransition )
			//       IsCurrFrameTriggerTransition = v10 > 1.401298464324817e-45;
			//     v2.fields.m_currentFrameTriggerTransition = IsCurrFrameTriggerTransition;
			//     if ( v10 >= 0.0 && !IsCurrFrameTriggerTransition )
			//     {
			//       v2.fields.m_currentFrameTriggerTransition = 0;
			//       goto LABEL_150;
			//     }
			//     v2.fields.m_currentFrameTriggerTransition = 1;
			//     m_currentTimeStamp = v2.fields.m_currentTimeStamp;
			//     v2.fields.m_currentTimeStamp = v2.fields.m_prevTimeStamp;
			//     v2.fields.m_prevTimeStamp = m_currentTimeStamp;
			//     v2.fields.m_currentTimeStamp = UnityEngine::Time::get_timeAsDouble(0LL);
			//     *(_QWORD *)&v107.x = 0LL;
			//     z = 0.0;
			//     v107.z = 0.0;
			//     v17 = 0;
			//     v114 = 0;
			//     v18 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v14);
			//       v18 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     static_fields = v18.static_fields;
			//     if ( !static_fields.s_Cameras )
			//       sub_180B536AC(v15, v14);
			//     Values = System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Values(
			//                (Dictionary_2_System_UInt64_System_Object_ *)static_fields.s_Cameras,
			//                MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Values);
			//     if ( !Values )
			//       sub_180B536AC(v22, v21);
			//     dictionary = Values.fields._dictionary;
			//     *(_OWORD *)&v110.fields._._File_k__BackingField = 0LL;
			//     v110.fields._._FullName_k__BackingField = (String *)dictionary;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v110.fields._._FullName_k__BackingField,
			//       v21,
			//       v23,
			//       v24,
			//       v103,
			//       v105,
			//       *(MethodInfo **)&v107.x);
			//     if ( !dictionary )
			//       sub_180B536AC(v27, v26);
			//     HIDWORD(v110.fields._._File_k__BackingField) = dictionary.fields._version;
			//     LODWORD(v110.fields._._File_k__BackingField) = 0;
			//     v110.fields.containingType = 0LL;
			//     v109 = *(_OWORD *)&v110.fields._._FullName_k__BackingField;
			//     v110.klass = 0LL;
			//     v110.fields.accessor = 0LL;
			//     v110.fields._Proto_k__BackingField = (OneofDescriptorProto *)&v109;
			//     try
			//     {
			//       z_low = _mm_cvtsi128_si32((__m128i)0LL);
			// LABEL_25:
			//       if ( !(_QWORD)v109 )
			//         sub_1802DC2C8(v27, v26);
			//       if ( HIDWORD(v109) != *(_DWORD *)(v109 + 44) )
			//         System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//       LODWORD(v29) = DWORD2(v109);
			//       while ( (unsigned int)v29 < *(_DWORD *)(v109 + 32) )
			//       {
			//         v30 = *(_QWORD *)(v109 + 24);
			//         v31 = (int)v29;
			//         v29 = (unsigned int)(v29 + 1);
			//         DWORD2(v109) = v29;
			//         if ( !v30 )
			//           sub_1802DC2C8(v29, 0LL);
			//         if ( (unsigned int)v31 >= *(_DWORD *)(v30 + 24) )
			//           sub_180070260(v29, v30, v109, v28);
			//         v32 = 32 * (v31 + 1);
			//         if ( *(int *)(v32 + v30) >= 0 )
			//         {
			//           v110.klass = *(OneofDescriptor__Class **)(v32 + v30 + 24);
			//           sub_1800054D0(
			//             &v110,
			//             (OneofDescriptorProto *)v30,
			//             (FileDescriptor *)v109,
			//             v28,
			//             v104,
			//             v106,
			//             *(MethodInfo **)&v107.x);
			//           klass = v110.klass;
			//           if ( !v110.klass )
			//             sub_1802DC2C8(v33, v26);
			//           generic_class = v110.klass._0.generic_class;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//           if ( !byte_18D8F4EFB )
			//           {
			//             v36 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//             if ( (v36 & 1) != 0 )
			//             {
			//               v37 = (v36 >> 1) & 0xFFFFFFF;
			//               switch ( v36 >> 29 )
			//               {
			//                 case 1u:
			//                   v38 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v37);
			//                   goto LABEL_63;
			//                 case 2u:
			//                   v38 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v37);
			//                   goto LABEL_63;
			//                 case 3u:
			//                 case 6u:
			//                   v39 = (v36 >> 1) & 0xFFFFFFF;
			//                   v40 = v36 >> 29;
			//                   if ( v40 )
			//                   {
			//                     if ( v40 == 3 )
			//                     {
			//                       v38 = (void (__fastcall __noreturn **)())sub_180039480(v39);
			//                       goto LABEL_63;
			//                     }
			//                     if ( v40 == 6 )
			//                     {
			//                       v41 = sub_1802DF9C0(v39);
			//                       v38 = (void (__fastcall __noreturn **)())sub_18005F4B0(v41, 0LL);
			//                       goto LABEL_63;
			//                     }
			//                   }
			//                   else if ( v39 == 1 )
			//                   {
			//                     v38 = off_18A2C5600;
			//                     goto LABEL_63;
			//                   }
			// LABEL_62:
			//                   v38 = 0LL;
			// LABEL_63:
			//                   if ( v38 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v38);
			//                   break;
			//                 case 4u:
			//                   v38 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v37);
			//                   goto LABEL_63;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v37) )
			//                   {
			//                     v38 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v37);
			//                   }
			//                   else
			//                   {
			//                     v28 = (MessageDescriptor *)il2cpp_string_new_len(
			//                                                  qword_18D8E5198
			//                                                + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v37 + 4)
			//                                                + *(int *)(qword_18D8E51A0 + 16),
			//                                                  *(unsigned int *)(qword_18D8E5198
			//                                                                  + *(int *)(qword_18D8E51A0 + 8)
			//                                                                  + 8 * v37));
			//                     v38 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v37),
			//                                                                (signed __int64)v28,
			//                                                                0LL);
			//                     if ( !v38 )
			//                     {
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v26 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v37) >> 12) & 0x1FFFFF) >> 6;
			//                         v42 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v37) >> 12) & 0x3F;
			//                         _m_prefetchw(&qword_18D6870D0[v26]);
			//                         do
			//                           v43 = qword_18D6870D0[v26];
			//                         while ( v43 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v43 | (1LL << v42), v43) );
			//                       }
			//                       v38 = (void (__fastcall __noreturn **)())v28;
			//                     }
			//                   }
			//                   goto LABEL_63;
			//                 case 7u:
			//                   v44 = sub_1802DF920((unsigned int)v37);
			//                   v45 = *(_QWORD *)(v44 + 16);
			//                   v46 = (v44 - *(_QWORD *)(v45 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v45 + 42) == 21 )
			//                   {
			//                     v47 = *(_QWORD ***)(v45 + 96);
			//                     if ( *v47 )
			//                     {
			//                       v48 = **v47 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                       v45 = sub_180039550(v48 / 92 + v48);
			//                     }
			//                     else
			//                     {
			//                       v45 = 0LL;
			//                     }
			//                   }
			//                   *(_DWORD *)&v110.fields._IsSynthetic_k__BackingField = v46
			//                                                                        + *(_DWORD *)(*(_QWORD *)(v45 + 104) + 32LL);
			//                   v49 = sub_1801B8ECC(
			//                           (unsigned int)&v110.fields._IsSynthetic_k__BackingField,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v49 )
			//                     goto LABEL_62;
			//                   v26 = *(unsigned int *)(v49 + 8);
			//                   if ( (_DWORD)v26 == -1 )
			//                     goto LABEL_62;
			//                   v38 = (void (__fastcall __noreturn **)())(v26 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                   goto LABEL_63;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8F4EFB = 1;
			//           }
			//           v27 = (signed __int64)TypeInfo::UnityEngine::Object;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//           if ( !byte_18D8F4EAF )
			//           {
			//             v50 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//             if ( (v50 & 1) != 0 )
			//             {
			//               v51 = (v50 >> 1) & 0xFFFFFFF;
			//               v27 = 0x180000000uLL;
			//               switch ( v50 >> 29 )
			//               {
			//                 case 1u:
			//                   v52 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v51);
			//                   goto LABEL_96;
			//                 case 2u:
			//                   v52 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v51);
			//                   goto LABEL_96;
			//                 case 3u:
			//                 case 6u:
			//                   v53 = (v50 >> 1) & 0xFFFFFFF;
			//                   v54 = v50 >> 29;
			//                   if ( v54 )
			//                   {
			//                     if ( v54 == 3 )
			//                     {
			//                       v52 = (void (__fastcall __noreturn **)())sub_180039480(v53);
			//                       goto LABEL_96;
			//                     }
			//                     if ( v54 == 6 )
			//                     {
			//                       v55 = sub_1802DF9C0(v53);
			//                       v52 = (void (__fastcall __noreturn **)())sub_18005F4B0(v55, 0LL);
			//                       goto LABEL_96;
			//                     }
			//                   }
			//                   else if ( v53 == 1 )
			//                   {
			//                     v52 = off_18A2C5600;
			//                     goto LABEL_96;
			//                   }
			// LABEL_95:
			//                   v52 = 0LL;
			// LABEL_96:
			//                   if ( v52 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v52);
			//                   break;
			//                 case 4u:
			//                   v52 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v51);
			//                   goto LABEL_96;
			//                 case 5u:
			//                   v27 = qword_18D8F6F98;
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v51) )
			//                   {
			//                     v52 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v51);
			//                   }
			//                   else
			//                   {
			//                     v28 = (MessageDescriptor *)il2cpp_string_new_len(
			//                                                  qword_18D8E5198
			//                                                + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v51 + 4)
			//                                                + *(int *)(qword_18D8E51A0 + 16),
			//                                                  *(unsigned int *)(qword_18D8E5198
			//                                                                  + *(int *)(qword_18D8E51A0 + 8)
			//                                                                  + 8 * v51));
			//                     v27 = qword_18D8F6F98;
			//                     v52 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v51),
			//                                                                (signed __int64)v28,
			//                                                                0LL);
			//                     if ( !v52 )
			//                     {
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v26 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v51) >> 12) & 0x1FFFFF) >> 6;
			//                         v56 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v51) >> 12) & 0x3F;
			//                         _m_prefetchw(&qword_18D6870D0[v26]);
			//                         do
			//                         {
			//                           v27 = qword_18D6870D0[v26] | (1LL << v56);
			//                           v57 = qword_18D6870D0[v26];
			//                         }
			//                         while ( v57 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v27, v57) );
			//                       }
			//                       v52 = (void (__fastcall __noreturn **)())v28;
			//                     }
			//                   }
			//                   goto LABEL_96;
			//                 case 7u:
			//                   v58 = sub_1802DF920((unsigned int)v51);
			//                   v59 = *(_QWORD *)(v58 + 16);
			//                   v60 = (v58 - *(_QWORD *)(v59 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v59 + 42) == 21 )
			//                   {
			//                     v61 = *(_QWORD ***)(v59 + 96);
			//                     if ( *v61 )
			//                     {
			//                       v62 = **v61 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                       v59 = sub_180039550(v62 / 92 + v62);
			//                     }
			//                     else
			//                     {
			//                       v59 = 0LL;
			//                     }
			//                   }
			//                   LODWORD(v110.monitor) = v60 + *(_DWORD *)(*(_QWORD *)(v59 + 104) + 32LL);
			//                   v63 = sub_1801B8ECC(
			//                           (unsigned int)&v110.monitor,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v63 )
			//                     goto LABEL_95;
			//                   v26 = *(unsigned int *)(v63 + 8);
			//                   if ( (_DWORD)v26 == -1 )
			//                     goto LABEL_95;
			//                   v52 = (void (__fastcall __noreturn **)())(v26 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                   goto LABEL_96;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8F4EAF = 1;
			//           }
			//           if ( generic_class )
			//           {
			//             v27 = (signed __int64)TypeInfo::UnityEngine::Object;
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//             if ( generic_class.context.method_inst )
			//             {
			//               if ( !klass )
			//                 sub_1802DC2C8(v27, v26);
			//               v64 = klass._0.generic_class;
			//               if ( !v64 )
			//                 sub_1802DC2C8(v27, v26);
			//               v65 = (unsigned int (__fastcall *)(Il2CppGenericClass *))qword_18D8F4200;
			//               if ( !qword_18D8F4200 )
			//               {
			//                 v65 = (unsigned int (__fastcall *)(Il2CppGenericClass *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//                 if ( !v65 )
			//                 {
			//                   v94 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//                   sub_18000F750(v94, 0LL);
			//                 }
			//                 qword_18D8F4200 = (__int64)v65;
			//               }
			//               if ( v65(v64) == 2 )
			//                 goto LABEL_114;
			//               v66 = klass._0.generic_class;
			//               if ( !v66 )
			//                 sub_1802DC2C8(v27, v26);
			//               v67 = (unsigned int (__fastcall *)(Il2CppGenericClass *))qword_18D8F4200;
			//               if ( !qword_18D8F4200 )
			//               {
			//                 v67 = (unsigned int (__fastcall *)(Il2CppGenericClass *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//                 if ( !v67 )
			//                 {
			//                   v95 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//                   sub_18000F750(v95, 0LL);
			//                 }
			//                 qword_18D8F4200 = (__int64)v67;
			//               }
			//               if ( v67(v66) == 1 )
			//               {
			// LABEL_114:
			//                 v68 = klass._0.generic_class;
			//                 if ( !v68 )
			//                   sub_1802DC2C8(v27, v26);
			//                 v69 = (__int64 (__fastcall *)(Il2CppGenericClass *))qword_18D8F4D40;
			//                 if ( !qword_18D8F4D40 )
			//                 {
			//                   v69 = (__int64 (__fastcall *)(Il2CppGenericClass *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//                   if ( !v69 )
			//                   {
			//                     v96 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//                     sub_18000F750(v96, 0LL);
			//                   }
			//                   qword_18D8F4D40 = (__int64)v69;
			//                 }
			//                 v72 = v69(v68);
			//                 if ( !v72 )
			//                   sub_1802DC2C8(v71, v70);
			//                 *(_QWORD *)&v108.x = 0LL;
			//                 v108.z = 0.0;
			//                 v73 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//                 if ( !qword_18D8F52E0 )
			//                 {
			//                   v73 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                                    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//                   if ( !v73 )
			//                   {
			//                     v97 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//                     sub_18000F750(v97, 0LL);
			//                   }
			//                   qword_18D8F52E0 = (__int64)v73;
			//                 }
			//                 v73(v72, &v108);
			//                 v107 = v108;
			//                 z_low = LODWORD(v108.z);
			//                 v17 = 1;
			//                 v114 = 1;
			//                 z = v108.z;
			//               }
			//             }
			//           }
			//           goto LABEL_25;
			//         }
			//       }
			//       DWORD2(v109) = *(_DWORD *)(v109 + 32) + 1;
			//       v110.klass = 0LL;
			//     }
			//     catch ( Il2CppExceptionWrapper *v111 )
			//     {
			//       v110.fields.accessor = (OneofAccessor *)v111.ex;
			//       if ( v110.fields.accessor )
			//         sub_18000F780(v110.fields.accessor);
			//       v2 = this;
			//       z = v107.z;
			//       z_low = _mm_cvtsi128_si32((__m128i)LODWORD(v107.z));
			//       v17 = v114;
			//       v3 = this;
			//     }
			//     v75 = (__int64 (*)(void))qword_18D8F4278;
			//     if ( !qword_18D8F4278 )
			//     {
			//       v75 = (__int64 (*)(void))il2cpp_resolve_icall_0("UnityEngine.Camera::get_main()");
			//       if ( !v75 )
			//       {
			//         v98 = sub_1802DBBE8("UnityEngine.Camera::get_main()");
			//         sub_18000F750(v98, 0LL);
			//       }
			//       qword_18D8F4278 = (__int64)v75;
			//     }
			//     v77 = (Object_1 *)v75();
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v76);
			//     if ( UnityEngine::Object::op_Implicit(v77, 0LL) )
			//     {
			//       v79 = (__int64 (*)(void))qword_18D8F4278;
			//       if ( !qword_18D8F4278 )
			//       {
			//         v79 = (__int64 (*)(void))il2cpp_resolve_icall_0("UnityEngine.Camera::get_main()");
			//         if ( !v79 )
			//         {
			//           v99 = sub_1802DBBE8("UnityEngine.Camera::get_main()");
			//           sub_18000F750(v99, 0LL);
			//         }
			//         qword_18D8F4278 = (__int64)v79;
			//       }
			//       v81 = v79();
			//       if ( !v81 )
			//         goto LABEL_163;
			//       v82 = (__int64 (__fastcall *)(__int64))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v82 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//         if ( !v82 )
			//         {
			//           v100 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//           sub_18000F750(v100, 0LL);
			//         }
			//         qword_18D8F4D40 = (__int64)v82;
			//       }
			//       v83 = v82(v81);
			//       if ( !v83 )
			//         goto LABEL_163;
			//       memset(&v108, 0, sizeof(v108));
			//       v84 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//       if ( !qword_18D8F52E0 )
			//       {
			//         v84 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         if ( !v84 )
			//         {
			//           v101 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           sub_18000F750(v101, 0LL);
			//         }
			//         qword_18D8F52E0 = (__int64)v84;
			//       }
			//       v84(v83, &v108);
			//       *(_QWORD *)&v107.x = *(_QWORD *)&v108.x;
			//       z_low = LODWORD(v108.z);
			//       v17 = 1;
			//       z = v108.z;
			//     }
			//     else if ( !v17 )
			//     {
			//       goto LABEL_146;
			//     }
			//     System::MathF::Floor(v78, 0.0);
			//     v2.fields.m_currentCameraPos.x = (float)(v107.x * 8.0) * 0.125;
			//     System::MathF::Floor(v85, 0.0);
			//     v2.fields.m_currentCameraPos.y = (float)(z * 8.0) * 0.125;
			// LABEL_146:
			//     *(_OWORD *)&v110.monitor = *(_OWORD *)&v2.fields.m_lastUpdateCameraPos.x;
			//     v2.fields.m_cameraParam = *(Vector4 *)&v110.monitor;
			//     y = v2.fields.m_currentCameraPos.y;
			//     v2.fields.m_lastUpdateCameraPos.x = v2.fields.m_currentCameraPos.x;
			//     v2.fields.m_lastUpdateCameraPos.y = y;
			//     v2.fields.m_curMaskIsA = !v2.fields.m_curMaskIsA;
			//     v2.fields.m_shouldRender = 1;
			//     if ( v17 )
			//     {
			//       m_params = v2.fields.m_params;
			//       LODWORD(v107.z) = z_low;
			//       CullingMatrix = HG::Rendering::Runtime::HGFoliageOccluderManager::_GetCullingMatrix(v112, v2, &v107, 0LL);
			//       v89 = *(_OWORD *)&CullingMatrix.m01;
			//       v90 = *(_OWORD *)&CullingMatrix.m02;
			//       v91 = *(_OWORD *)&CullingMatrix.m03;
			//       if ( !m_params )
			//         goto LABEL_163;
			//       *(_OWORD *)&m_params.fields.cullingMatrix.m00 = *(_OWORD *)&CullingMatrix.m00;
			//       *(_OWORD *)&m_params.fields.cullingMatrix.m01 = v89;
			//       *(_OWORD *)&m_params.fields.cullingMatrix.m02 = v90;
			//       *(_OWORD *)&m_params.fields.cullingMatrix.m03 = v91;
			//     }
			// LABEL_150:
			//     v80 = v2.fields.m_params;
			//     if ( !v80 )
			//       goto LABEL_163;
			//     v80.fields.shouldRender = v2.fields.m_shouldRender;
			//     v80 = v2.fields.m_params;
			//     if ( !v80 )
			//       goto LABEL_163;
			//     v80.fields.curMaskIsA = v2.fields.m_curMaskIsA;
			//     if ( v2.fields.m_currentTimeStamp - v2.fields.m_prevTimeStamp < 1.401298464324817e-45 )
			//     {
			//       v2.fields.m_shouldRender = 0;
			//     }
			//     else
			//     {
			//       v92 = (double (*)(void))qword_18D8F5178;
			//       if ( !qword_18D8F5178 )
			//       {
			//         v92 = (double (*)(void))il2cpp_resolve_icall_0("UnityEngine.Time::get_timeAsDouble()");
			//         if ( !v92 )
			//         {
			//           v102 = sub_1802DBBE8("UnityEngine.Time::get_timeAsDouble()");
			//           sub_18000F750(v102, 0LL);
			//         }
			//         qword_18D8F5178 = (__int64)v92;
			//       }
			//       v93 = (v92() - 0.5 - v2.fields.m_prevTimeStamp) / (v2.fields.m_currentTimeStamp - v2.fields.m_prevTimeStamp);
			//       if ( v93 >= 0.0 )
			//       {
			//         if ( v93 > 1.0 )
			//           v93 = 1.0;
			// LABEL_161:
			//         v3.fields.m_lodFadeValue = v93;
			//         v80 = v2.fields.m_params;
			//         if ( v80 )
			//         {
			//           v80.fields.lodFadeValue = v2.fields.m_lodFadeValue;
			//           return;
			//         }
			// LABEL_163:
			//         sub_1802DC2C8(v80, v12);
			//       }
			//     }
			//     v93 = 0.0;
			//     goto LABEL_161;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1969, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v9, v8);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			// }
			// 
		}

		public void SetShaderVariablesGlobalFoliageOccluder(ref ShaderVariablesGlobal cb)
		{
			// // Void SetShaderVariablesGlobalFoliageOccluder(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGFoliageOccluderManager::SetShaderVariablesGlobalFoliageOccluder(
			//         HGFoliageOccluderManager *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2173, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2173, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128i *)&cb[1]._WiderFoVViewProjMatrix.m03 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGFoliageOccluderManager::get_occluderScaleParam(
			//                                                                                         &v8,
			//                                                                                         this,
			//                                                                                         0LL));
			//     *(__m128i *)&cb[1]._WiderFoVInvViewProjMatrix.m00 = _mm_loadu_si128((const __m128i *)&this.fields.m_cameraParam);
			//   }
			// }
			// 
		}

		private Matrix4x4 _GetCullingMatrix(Vector3 camPos)
		{
			// // Matrix4x4 _GetCullingMatrix(Vector3)
			// Matrix4x4 *HG::Rendering::Runtime::HGFoliageOccluderManager::_GetCullingMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGFoliageOccluderManager *this,
			//         Vector3 *camPos,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // r8
			//   void (__fastcall *v9)(Matrix4x4 *, __int64, __int64); // rax
			//   float v10; // eax
			//   MethodInfo *v11; // r9
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm0_8
			//   __int64 v14; // xmm0_8
			//   void (__fastcall *v15)(Vector3 *, Vector3 *, Vector3 *, __int128 *); // rax
			//   void (__fastcall *v16)(_OWORD *, __int128 *); // rax
			//   void (__fastcall *v17)(Matrix4x4 *, __int128 *, Matrix4x4 *); // rax
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   Matrix4x4 *result; // rax
			//   __int64 v22; // rax
			//   __int64 v23; // rax
			//   __int64 v24; // rax
			//   __int64 v25; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v27; // rcx
			//   float z; // eax
			//   Matrix4x4 *v29; // rax
			//   __int128 v30; // xmm1
			//   Vector3 v31; // [rsp+40h] [rbp-C0h] BYREF
			//   Vector3 v32; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector3 v33; // [rsp+60h] [rbp-A0h] BYREF
			//   Matrix4x4 v34; // [rsp+70h] [rbp-90h] BYREF
			//   __int128 v35; // [rsp+B0h] [rbp-50h] BYREF
			//   __int128 v36; // [rsp+C0h] [rbp-40h]
			//   __int128 v37; // [rsp+D0h] [rbp-30h]
			//   __int128 v38; // [rsp+E0h] [rbp-20h]
			//   __int128 v39; // [rsp+F0h] [rbp-10h] BYREF
			//   __int128 v40; // [rsp+100h] [rbp+0h]
			//   __int128 v41; // [rsp+110h] [rbp+10h]
			//   __int128 v42; // [rsp+120h] [rbp+20h]
			//   Matrix4x4 v43; // [rsp+130h] [rbp+30h] BYREF
			//   Vector3 v44; // [rsp+170h] [rbp+70h] BYREF
			//   _OWORD v45[4]; // [rsp+180h] [rbp+80h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1970, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1970, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v27, 0LL);
			//     z = camPos.z;
			//     *(_QWORD *)&v33.x = *(_QWORD *)&camPos.x;
			//     v33.z = z;
			//     v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_762(&v43, Patch, (Object *)this, &v33, 0LL);
			//     v30 = *(_OWORD *)&v29.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v29.m00;
			//     v19 = *(_OWORD *)&v29.m02;
			//     *(_OWORD *)&retstr.m01 = v30;
			//     v20 = *(_OWORD *)&v29.m03;
			//   }
			//   else
			//   {
			//     v9 = (void (__fastcall *)(Matrix4x4 *, __int64, __int64))qword_18D8F4BE0;
			//     memset(&v34, 0, sizeof(v34));
			//     if ( !qword_18D8F4BE0 )
			//     {
			//       v9 = (void (__fastcall *)(Matrix4x4 *, __int64, __int64))il2cpp_resolve_icall_0(
			//                                                                  "UnityEngine.Matrix4x4::Ortho_Injected(System.Single,Sys"
			//                                                                  "tem.Single,System.Single,System.Single,System.Single,Sy"
			//                                                                  "stem.Single,UnityEngine.Matrix4x4&)");
			//       if ( !v9 )
			//       {
			//         v22 = sub_1802DBBE8(
			//                 "UnityEngine.Matrix4x4::Ortho_Injected(System.Single,System.Single,System.Single,System.Single,System.Sin"
			//                 "gle,System.Single,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v22, 0LL);
			//       }
			//       qword_18D8F4BE0 = (__int64)v9;
			//     }
			//     v9(&v34, v7, v8);
			//     v10 = camPos.z;
			//     v31.z = 0.0;
			//     *(_QWORD *)&v31.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//     *(_QWORD *)&v32.x = *(_QWORD *)&camPos.x;
			//     v32.z = v10;
			//     v12 = UnityEngine::Vector3::op_Addition(&v44, &v32, &v31, v11);
			//     *(_QWORD *)&v32.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//     v13 = *(_QWORD *)&v12.x;
			//     *(float *)&v12 = v12.z;
			//     *(_QWORD *)&v31.x = v13;
			//     v14 = *(_QWORD *)&camPos.x;
			//     LODWORD(v31.z) = (_DWORD)v12;
			//     v33.z = camPos.z;
			//     v15 = (void (__fastcall *)(Vector3 *, Vector3 *, Vector3 *, __int128 *))qword_18D8F4BF0;
			//     *(_QWORD *)&v33.x = v14;
			//     v32.z = 1.0;
			//     v35 = 0LL;
			//     v36 = 0LL;
			//     v37 = 0LL;
			//     v38 = 0LL;
			//     if ( !qword_18D8F4BF0 )
			//     {
			//       v15 = (void (__fastcall *)(Vector3 *, Vector3 *, Vector3 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                                 "UnityEngine.Matrix4x4::LookAt_Injected(U"
			//                                                                                 "nityEngine.Vector3&,UnityEngine.Vector3&"
			//                                                                                 ",UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
			//       if ( !v15 )
			//       {
			//         v23 = sub_1802DBBE8(
			//                 "UnityEngine.Matrix4x4::LookAt_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,Un"
			//                 "ityEngine.Matrix4x4&)");
			//         sub_18000F750(v23, 0LL);
			//       }
			//       qword_18D8F4BF0 = (__int64)v15;
			//     }
			//     v15(&v33, &v31, &v32, &v35);
			//     v16 = (void (__fastcall *)(_OWORD *, __int128 *))qword_18D8F4BD0;
			//     v45[0] = v35;
			//     v45[1] = v36;
			//     v45[2] = v37;
			//     v45[3] = v38;
			//     v39 = 0LL;
			//     v40 = 0LL;
			//     v41 = 0LL;
			//     v42 = 0LL;
			//     if ( !qword_18D8F4BD0 )
			//     {
			//       v16 = (void (__fastcall *)(_OWORD *, __int128 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,"
			//                                                          "UnityEngine.Matrix4x4&)");
			//       if ( !v16 )
			//       {
			//         v24 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v24, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v16;
			//     }
			//     v16(v45, &v39);
			//     v17 = (void (__fastcall *)(Matrix4x4 *, __int128 *, Matrix4x4 *))qword_18D8F4BC0;
			//     v43 = v34;
			//     v35 = v39;
			//     v36 = v40;
			//     v37 = v41;
			//     v38 = v42;
			//     memset(&v34, 0, sizeof(v34));
			//     if ( !qword_18D8F4BC0 )
			//     {
			//       v17 = (void (__fastcall *)(Matrix4x4 *, __int128 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
			//                                                                          "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
			//                                                                          "rix4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v17 )
			//       {
			//         v25 = sub_1802DBBE8(
			//                 "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Un"
			//                 "ityEngine.Matrix4x4&)");
			//         sub_18000F750(v25, 0LL);
			//       }
			//       qword_18D8F4BC0 = (__int64)v17;
			//     }
			//     v17(&v43, &v35, &v34);
			//     v18 = *(_OWORD *)&v34.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v34.m00;
			//     v19 = *(_OWORD *)&v34.m02;
			//     *(_OWORD *)&retstr.m01 = v18;
			//     v20 = *(_OWORD *)&v34.m03;
			//   }
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v19;
			//   *(_OWORD *)&retstr.m03 = v20;
			//   return result;
			// }
			// 
			return null;
		}

		public const float OCCLUDER_FADE_TRANSITION_TIME = 0.5f;

		public const float OCCLUDER_COVERAGE_SIZE = 64f;

		public const float OCCLUDER_COVERAGE_HALF_SIZE = 32f;

		public const int OCCLUDER_MASK_RESOLUTION = 512;

		private float m_lodFadeValue;

		private bool m_currentFrameTriggerTransition;

		private Vector2 m_lastUpdateCameraPos;

		private Vector2 m_currentCameraPos;

		private Vector4 m_cameraParam;

		private double m_prevTimeStamp;

		private double m_currentTimeStamp;

		private bool m_curMaskIsA;

		private bool m_shouldRender;

		private HGFoliageOccluderRenderParams m_params;
	}
}
