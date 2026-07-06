using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	public class VolumetricCloudVolumeManager
	{
		public VolumetricCloudVolumeManager()
		{
		}

		public void RegisterCloudVolume(IVolumetricCloudVolume volume)
		{
			// // Void RegisterCloudVolume(IVolumetricCloudVolume)
			// void HG::Rendering::Runtime::VolumetricCloudVolumeManager::RegisterCloudVolume(
			//         VolumetricCloudVolumeManager *this,
			//         IVolumetricCloudVolume *volume,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_VolumetricCloudVolumes; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91979B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::Contains);
			//     byte_18D91979B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4372, 0LL) )
			//   {
			//     if ( !volume )
			//       return;
			//     m_VolumetricCloudVolumes = (List_1_System_Object_ *)this.fields.m_VolumetricCloudVolumes;
			//     if ( m_VolumetricCloudVolumes )
			//     {
			//       if ( System::Collections::Generic::List<System::Object>::Contains(
			//              m_VolumetricCloudVolumes,
			//              (Object *)volume,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::Contains) )
			//       {
			//         return;
			//       }
			//       m_VolumetricCloudVolumes = (List_1_System_Object_ *)this.fields.m_VolumetricCloudVolumes;
			//       if ( m_VolumetricCloudVolumes )
			//       {
			//         sub_1822AD140(m_VolumetricCloudVolumes, (Object *)volume);
			//         return;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_VolumetricCloudVolumes, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4372, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)volume,
			//     0LL);
			// }
			// 
		}

		public void UnregisterCloudVolume(IVolumetricCloudVolume volume)
		{
		}

		public ValueTuple<EVolumetricState, float> GetFadeRatioAndState(HGCamera camera)
		{
			// // ValueTuple`2[HG.Rendering.Runtime.EVolumetricState,Single] GetFadeRatioAndState(HGCamera)
			// ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ HG::Rendering::Runtime::VolumetricCloudVolumeManager::GetFadeRatioAndState(
			//         VolumetricCloudVolumeManager *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *entries; // rcx
			//   Object_1__StaticFields *wrapperArray; // rdx
			//   Dictionary_2_System_Int32_System_Object_ *m_states; // rdi
			//   Camera *v8; // rbx
			//   struct Object_1__Class *v9; // rcx
			//   char *m_CachedPtr; // rbx
			//   int32_t v11; // esi
			//   struct MethodInfo *v12; // rbx
			//   int32_t Entry; // eax
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t OffsetOfInstanceIDInCPlusPlusObject; // eax
			//   MethodInfo *v19; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v20; // [rsp+28h] [rbp-10h]
			//   ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ *v21; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDBA9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<HG::Rendering::Runtime::EVolumetricState,float>::ValueTuple);
			//     byte_18D8EDBA9 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (Object_1__StaticFields *)entries.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_28;
			//   if ( wrapperArray[6].OffsetOfInstanceIDInCPlusPlusObject <= 1033 )
			//     goto LABEL_9;
			//   if ( !entries._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(entries, wrapperArray);
			//     entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (Object_1__StaticFields *)entries.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_28;
			//   if ( wrapperArray[6].OffsetOfInstanceIDInCPlusPlusObject <= 0x409u )
			//     goto LABEL_29;
			//   if ( *(_QWORD *)&wrapperArray[2074].OffsetOfInstanceIDInCPlusPlusObject )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1033, 0LL);
			//     if ( !Patch )
			//       goto LABEL_28;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_372(Patch, (Object *)this, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			// LABEL_9:
			//     m_states = (Dictionary_2_System_Int32_System_Object_ *)this.fields.m_states;
			//     if ( !camera )
			//       goto LABEL_28;
			//     v8 = camera.fields.camera;
			//     if ( !v8 )
			//       goto LABEL_28;
			//     if ( !byte_18D8F4EAC )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAC = 1;
			//     }
			//     if ( v8.fields._._._.m_CachedPtr )
			//     {
			//       v9 = TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//         v9 = TypeInfo::UnityEngine::Object;
			//       }
			//       if ( v9.static_fields.OffsetOfInstanceIDInCPlusPlusObject == -1 )
			//       {
			//         if ( !v9._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(v9, wrapperArray);
			//         OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
			//         wrapperArray = TypeInfo::UnityEngine::Object.static_fields;
			//         wrapperArray.OffsetOfInstanceIDInCPlusPlusObject = OffsetOfInstanceIDInCPlusPlusObject;
			//         v9 = TypeInfo::UnityEngine::Object;
			//       }
			//       m_CachedPtr = (char *)v8.fields._._._.m_CachedPtr;
			//       if ( !v9._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v9, wrapperArray);
			//         v9 = TypeInfo::UnityEngine::Object;
			//       }
			//       entries = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.OffsetOfInstanceIDInCPlusPlusObject;
			//       v11 = *(_DWORD *)&m_CachedPtr[(_QWORD)entries];
			//     }
			//     else
			//     {
			//       v11 = 0;
			//     }
			//     if ( !m_states )
			//       goto LABEL_28;
			//     v12 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue;
			//     if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue.klass.rgctx_data[22].rgctxDataDummy
			//           + 4) )
			//       (*(void (__fastcall **)(const Il2CppRGCTXData *, Object_1__StaticFields *, MethodInfo *))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue.klass.rgctx_data[22].rgctxDataDummy)(
			//         MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue.klass.rgctx_data,
			//         wrapperArray,
			//         method);
			//     Entry = System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
			//               m_states,
			//               v11,
			//               (MethodInfo *)v12.klass.rgctx_data[22].rgctxDataDummy);
			//     if ( Entry >= 0 )
			//     {
			//       entries = (struct ILFixDynamicMethodWrapper_2__Class *)m_states.fields._entries;
			//       if ( !entries )
			//         goto LABEL_28;
			//       if ( (unsigned int)Entry < LODWORD(entries._0.namespaze) )
			//       {
			//         v21 = (ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ *)*((_QWORD *)&entries._0.this_arg.data.dummy
			//                                                                             + 3 * Entry);
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&v21,
			//           (HGRenderPathBase_HGRenderPathResources *)wrapperArray,
			//           v14,
			//           v15,
			//           v19,
			//           v20);
			//         if ( v21 )
			//           return v21[2];
			// LABEL_28:
			//         sub_180B536AC(entries, wrapperArray);
			//       }
			// LABEL_29:
			//       sub_180070270(entries, wrapperArray);
			//     }
			//     return (ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_)0x3F80000000000000LL;
			//   }
			// }
			// 
			return null;
		}

		public void UpdateFromCamera(HGCamera camera)
		{
			// // Void UpdateFromCamera(HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::VolumetricCloudVolumeManager::UpdateFromCamera(
			//         VolumetricCloudVolumeManager *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGCamera *v3; // r13
			//   IVolumetricCloudVolume *v5; // rsi
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v8; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Camera *v12; // rdi
			//   __int64 (__fastcall *v13)(Camera *, HGCamera *, MethodInfo *); // rax
			//   __int64 v14; // rdx
			//   Transform *v15; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   __int64 v17; // rcx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   List_1_HG_Rendering_Runtime_IVolumetricCloudVolume_ *m_VolumetricCloudVolumes; // rbx
			//   signed __int64 v21; // rdx
			//   VolumetricCloudSDF *v22; // r12
			//   __int64 v23; // rdi
			//   void (__fastcall __noreturn **v24)(); // rax
			//   unsigned int v25; // eax
			//   __int64 v26; // rax
			//   void (__fastcall __noreturn **v27)(); // rdi
			//   __int64 v28; // r8
			//   signed __int64 v29; // r9
			//   char v30; // r8
			//   signed __int64 v31; // rtt
			//   __int64 v32; // rdi
			//   __int64 v33; // rax
			//   __int64 v34; // rdi
			//   _QWORD **v35; // rcx
			//   __int64 v36; // r8
			//   __int64 v37; // rax
			//   Object_1 *m_states; // rcx
			//   unsigned int v39; // r8d
			//   __int64 v40; // r14
			//   unsigned int v41; // eax
			//   unsigned int v42; // r8d
			//   __int64 v43; // rax
			//   Transform *v44; // rdi
			//   void (__fastcall *v45)(Transform *, __int64 *); // rax
			//   __int64 v46; // r8
			//   signed __int64 v47; // r9
			//   char v48; // r8
			//   signed __int64 v49; // rtt
			//   __int64 v50; // rdi
			//   __int64 v51; // rax
			//   __int64 v52; // rdi
			//   _QWORD **v53; // rcx
			//   __int64 v54; // r8
			//   __int64 v55; // rax
			//   __int64 v56; // xmm6_8
			//   int v57; // r14d
			//   int v58; // edi
			//   VolumetricCloudVolumeManager *v59; // r15
			//   List_1_HG_Rendering_Runtime_IVolumetricCloudVolume_ *v60; // r9
			//   unsigned __int64 v61; // rdx
			//   signed __int64 v62; // rcx
			//   signed __int64 v63; // rtt
			//   Object *current; // rbx
			//   __int64 v65; // rdx
			//   __int64 v66; // rcx
			//   int32_t InstanceID; // eax
			//   int32_t v68; // ebx
			//   __int64 v69; // rax
			//   __int64 v70; // rax
			//   __int64 v71; // rax
			//   MethodInfo *v72[6]; // [rsp+0h] [rbp-F8h] BYREF
			//   _BYTE v73[24]; // [rsp+30h] [rbp-C8h] BYREF
			//   __int64 v74; // [rsp+50h] [rbp-A8h] BYREF
			//   int v75; // [rsp+58h] [rbp-A0h]
			//   List_1_T_Enumerator_System_Object_ v76; // [rsp+60h] [rbp-98h] BYREF
			//   Object *v77; // [rsp+78h] [rbp-80h]
			//   Transform *FinalTrigger; // [rsp+80h] [rbp-78h]
			//   Transform *v79; // [rsp+88h] [rbp-70h]
			//   int v80; // [rsp+90h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+A0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+A8h] [rbp-50h] BYREF
			//   Object *value; // [rsp+118h] [rbp+20h] BYREF
			// 
			//   v3 = camera;
			//   if ( !byte_18D8EDBAA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState);
			//     byte_18D8EDBAA = 1;
			//   }
			//   v5 = 0LL;
			//   value = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v6, camera);
			//   if ( wrapperArray.max_length.size <= 767 )
			//     goto LABEL_16;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, camera);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = v6.static_fields.wrapperArray;
			//   if ( !v8 )
			//     sub_180B536AC(v6, camera);
			//   if ( v8.max_length.size <= 0x2FFu )
			//     sub_180070270(v6, camera);
			//   if ( !v8[21].vector[11] )
			//   {
			// LABEL_16:
			//     if ( !v3 )
			//       sub_180B536AC(v6, camera);
			//     v12 = v3.fields.camera;
			//     if ( !v12 )
			//       sub_180B536AC(v6, camera);
			//     v13 = (__int64 (__fastcall *)(Camera *, HGCamera *, MethodInfo *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v13 = (__int64 (__fastcall *)(Camera *, HGCamera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//       if ( !v13 )
			//       {
			//         v70 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v70, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v13;
			//     }
			//     v15 = (Transform *)v13(v12, camera, method);
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v14);
			//     FinalTrigger = HG::Rendering::Runtime::HGEnvironmentManager::GetFinalTrigger(v12, v15, 0LL);
			//     v79 = FinalTrigger;
			//     m_VolumetricCloudVolumes = this.fields.m_VolumetricCloudVolumes;
			//     if ( !m_VolumetricCloudVolumes )
			//       sub_180B536AC(v17, v16);
			//     *(_OWORD *)&v73[8] = 0LL;
			//     *(_QWORD *)v73 = m_VolumetricCloudVolumes;
			//     sub_1800054D0((HGRenderPathScene *)v73, v16, v18, v19, v72[4], v72[5]);
			//     *(_DWORD *)&v73[8] = 0;
			//     *(_DWORD *)&v73[12] = m_VolumetricCloudVolumes.fields._version;
			//     *(_QWORD *)&v73[16] = 0LL;
			//     *(_OWORD *)&v76._list = *(_OWORD *)v73;
			//     v76._current = 0LL;
			//     *(_QWORD *)v73 = 0LL;
			//     *(_QWORD *)&v73[8] = &v76;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v76,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::MoveNext) )
			//       {
			//         if ( !v76._current )
			//           sub_1802DC2C8(0LL, v21);
			//         sub_1886B12DC((VolumetricCloudSDF *)v76._current, v3, 0);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v81 )
			//     {
			//       v21 = (signed __int64)v72;
			//       *(Il2CppExceptionWrapper *)v73 = (Il2CppExceptionWrapper)v81.ex;
			//       if ( *(_QWORD *)v73 )
			//         sub_18000F780(*(_QWORD *)v73);
			//       v5 = 0LL;
			//       v3 = camera;
			//     }
			//     v22 = 0LL;
			//     v77 = 0LL;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v21);
			//     if ( byte_18D8F4EFB )
			//     {
			//       v27 = off_18A2C5600;
			//     }
			//     else
			//     {
			//       v21 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//       if ( (v21 & 1) != 0 )
			//       {
			//         v23 = ((unsigned int)v21 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v21 >> 29 )
			//         {
			//           case 1u:
			//             v24 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v23);
			//             goto LABEL_63;
			//           case 2u:
			//             v24 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v23);
			//             goto LABEL_63;
			//           case 3u:
			//           case 6u:
			//             v25 = ((unsigned int)v21 >> 1) & 0xFFFFFFF;
			//             v21 = (unsigned int)v21 >> 29;
			//             if ( (_DWORD)v21 )
			//             {
			//               if ( (_DWORD)v21 == 3 )
			//               {
			//                 v24 = (void (__fastcall __noreturn **)())sub_180039480(v25);
			//                 goto LABEL_45;
			//               }
			//               if ( (_DWORD)v21 == 6 )
			//               {
			//                 v26 = sub_1802DF9C0(v25);
			//                 v24 = (void (__fastcall __noreturn **)())sub_18005F4B0(v26, 0LL);
			//                 goto LABEL_45;
			//               }
			//             }
			//             else if ( v25 == 1 )
			//             {
			//               v27 = off_18A2C5600;
			//               v24 = off_18A2C5600;
			//               goto LABEL_64;
			//             }
			//             v24 = 0LL;
			// LABEL_45:
			//             v27 = off_18A2C5600;
			// LABEL_64:
			//             if ( !v24 )
			//               goto LABEL_67;
			//             _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v24);
			//             byte_18D8F4EFB = 1;
			//             break;
			//           case 4u:
			//             v24 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v23);
			//             goto LABEL_63;
			//           case 5u:
			//             v28 = 8 * v23;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v23) )
			//             {
			//               v24 = *(void (__fastcall __noreturn ***)())(v28 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v29 = il2cpp_string_new_len(
			//                       qword_18D8E5198
			//                     + *(int *)(v28 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                     + *(int *)(qword_18D8E51A0 + 16),
			//                       *(unsigned int *)(v28 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v24 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                          (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v23),
			//                                                          v29,
			//                                                          0LL);
			//               if ( !v24 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v21 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v23) >> 12) & 0x1FFFFF) >> 6;
			//                   v30 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v23) >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6870D0[v21]);
			//                   do
			//                     v31 = qword_18D6870D0[v21];
			//                   while ( v31 != _InterlockedCompareExchange64(&qword_18D6870D0[v21], v31 | (1LL << v30), v31) );
			//                 }
			//                 v24 = (void (__fastcall __noreturn **)())v29;
			//               }
			//             }
			//             goto LABEL_63;
			//           case 7u:
			//             v32 = sub_1802DF920((unsigned int)v23);
			//             v33 = *(_QWORD *)(v32 + 16);
			//             v34 = (v32 - *(_QWORD *)(v33 + 128)) >> 5;
			//             if ( *(_BYTE *)(v33 + 42) == 21 )
			//             {
			//               v35 = *(_QWORD ***)(v33 + 96);
			//               if ( *v35 )
			//               {
			//                 v36 = **v35 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                 v33 = sub_180039550(v36 / 92 + v36);
			//               }
			//               else
			//               {
			//                 v33 = 0LL;
			//               }
			//             }
			//             v80 = v34 + *(_DWORD *)(*(_QWORD *)(v33 + 104) + 32LL);
			//             v37 = sub_1801B8ECC(
			//                     (unsigned int)&v80,
			//                     (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                     *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                     12,
			//                     (__int64)sub_1802C7760);
			//             if ( !v37 || (v21 = *(unsigned int *)(v37 + 8), (_DWORD)v21 == -1) )
			//               v24 = 0LL;
			//             else
			//               v24 = (void (__fastcall __noreturn **)())(v21 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			// LABEL_63:
			//             v27 = off_18A2C5600;
			//             goto LABEL_64;
			//           default:
			//             goto LABEL_66;
			//         }
			//       }
			//       else
			//       {
			// LABEL_66:
			//         v27 = off_18A2C5600;
			// LABEL_67:
			//         byte_18D8F4EFB = 1;
			//       }
			//     }
			//     m_states = (Object_1 *)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v21);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       v39 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//       if ( (v39 & 1) != 0 )
			//       {
			//         v40 = (v39 >> 1) & 0xFFFFFFF;
			//         switch ( v39 >> 29 )
			//         {
			//           case 1u:
			//             v27 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v40);
			//             goto LABEL_83;
			//           case 2u:
			//             v27 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v40);
			//             goto LABEL_83;
			//           case 3u:
			//           case 6u:
			//             v41 = (v39 >> 1) & 0xFFFFFFF;
			//             v42 = v39 >> 29;
			//             if ( v42 )
			//             {
			//               if ( v42 == 3 )
			//               {
			//                 v27 = (void (__fastcall __noreturn **)())sub_180039480(v41);
			//                 goto LABEL_83;
			//               }
			//               if ( v42 == 6 )
			//               {
			//                 v43 = sub_1802DF9C0(v41);
			//                 v27 = (void (__fastcall __noreturn **)())sub_18005F4B0(v43, 0LL);
			//                 goto LABEL_83;
			//               }
			//             }
			//             else if ( v41 == 1 )
			//             {
			//               goto LABEL_83;
			//             }
			// LABEL_82:
			//             v27 = 0LL;
			// LABEL_83:
			//             if ( v27 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v27);
			//             break;
			//           case 4u:
			//             v27 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v40);
			//             goto LABEL_83;
			//           case 5u:
			//             v46 = 8 * v40;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v40) )
			//             {
			//               v27 = *(void (__fastcall __noreturn ***)())(v46 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v47 = il2cpp_string_new_len(
			//                       qword_18D8E5198
			//                     + *(int *)(v46 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                     + *(int *)(qword_18D8E51A0 + 16),
			//                       *(unsigned int *)(v46 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               m_states = (Object_1 *)qword_18D8F6F98;
			//               v27 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                          (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v40),
			//                                                          v47,
			//                                                          0LL);
			//               if ( !v27 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v21 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v40) >> 12) & 0x1FFFFF) >> 6;
			//                   v48 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v40) >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6870D0[v21]);
			//                   do
			//                   {
			//                     m_states = (Object_1 *)(qword_18D6870D0[v21] | (1LL << v48));
			//                     v49 = qword_18D6870D0[v21];
			//                   }
			//                   while ( v49 != _InterlockedCompareExchange64(&qword_18D6870D0[v21], (signed __int64)m_states, v49) );
			//                 }
			//                 v27 = (void (__fastcall __noreturn **)())v47;
			//               }
			//             }
			//             goto LABEL_83;
			//           case 7u:
			//             v50 = sub_1802DF920((unsigned int)v40);
			//             v51 = *(_QWORD *)(v50 + 16);
			//             v52 = (v50 - *(_QWORD *)(v51 + 128)) >> 5;
			//             if ( *(_BYTE *)(v51 + 42) == 21 )
			//             {
			//               v53 = *(_QWORD ***)(v51 + 96);
			//               if ( *v53 )
			//               {
			//                 v54 = **v53 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                 v51 = sub_180039550(v54 / 92 + v54);
			//               }
			//               else
			//               {
			//                 v51 = 0LL;
			//               }
			//             }
			//             *(_DWORD *)v73 = v52 + *(_DWORD *)(*(_QWORD *)(v51 + 104) + 32LL);
			//             v55 = sub_1801B8ECC(
			//                     (unsigned int)v73,
			//                     (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                     *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                     12,
			//                     (__int64)sub_1802C7760);
			//             if ( !v55 )
			//               goto LABEL_82;
			//             v21 = *(unsigned int *)(v55 + 8);
			//             if ( (_DWORD)v21 == -1 )
			//               goto LABEL_82;
			//             v27 = (void (__fastcall __noreturn **)())(v21 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//             goto LABEL_83;
			//           default:
			//             break;
			//         }
			//       }
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !FinalTrigger )
			//       goto LABEL_124;
			//     m_states = (Object_1 *)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v21);
			//     v44 = v79;
			//     if ( v79.fields._._.m_CachedPtr )
			//     {
			//       v74 = 0LL;
			//       v75 = 0;
			//       v45 = (void (__fastcall *)(Transform *, __int64 *))qword_18D8F52E0;
			//       if ( !qword_18D8F52E0 )
			//       {
			//         v45 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_0(
			//                                                              "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         if ( !v45 )
			//         {
			//           v71 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           sub_18000F750(v71, 0LL);
			//         }
			//         qword_18D8F52E0 = (__int64)v45;
			//       }
			//       v45(v44, &v74);
			//       v56 = v74;
			//       v57 = v75;
			//       v58 = 0x80000000;
			//       v59 = this;
			//       v60 = this.fields.m_VolumetricCloudVolumes;
			//       if ( !v60 )
			//         goto LABEL_134;
			//       *(_OWORD *)&v73[8] = 0LL;
			//       *(_QWORD *)v73 = v60;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v61 = (((unsigned __int64)v73 >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6870D0[v61]);
			//         do
			//         {
			//           v62 = qword_18D6870D0[v61] | (1LL << (((unsigned __int64)v73 >> 12) & 0x3F));
			//           v63 = qword_18D6870D0[v61];
			//         }
			//         while ( v63 != _InterlockedCompareExchange64(&qword_18D6870D0[v61], v62, v63) );
			//       }
			//       *(_DWORD *)&v73[8] = 0;
			//       *(_DWORD *)&v73[12] = v60.fields._version;
			//       *(_QWORD *)&v73[16] = 0LL;
			//       *(_OWORD *)&v76._list = *(_OWORD *)v73;
			//       v76._current = 0LL;
			//       *(_QWORD *)v73 = 0LL;
			//       *(_QWORD *)&v73[8] = &v76;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v76,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::MoveNext) )
			//         {
			//           current = v76._current;
			//           if ( !v76._current )
			//             sub_1802DC2C8(m_states, v21);
			//           v74 = v56;
			//           v75 = v57;
			//           if ( (unsigned __int8)sub_1886B112C(v76._current, &v74) )
			//           {
			//             if ( !current )
			//               sub_1802DC2C8(v66, v65);
			//             if ( (int)sub_1886B1354(current) > v58 )
			//             {
			//               v58 = sub_1886B1354(current);
			//               v22 = (VolumetricCloudSDF *)current;
			//               v77 = current;
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v82 )
			//       {
			//         v21 = (signed __int64)v72;
			//         *(Il2CppExceptionWrapper *)v73 = (Il2CppExceptionWrapper)v82.ex;
			//         m_states = *(Object_1 **)v73;
			//         if ( *(_QWORD *)v73 )
			//           sub_18000F780(*(_QWORD *)v73);
			//         v5 = 0LL;
			//         v3 = camera;
			//         v22 = (VolumetricCloudSDF *)v77;
			//         v59 = this;
			//       }
			//       if ( v22 )
			//       {
			//         sub_1886B1274(v22, v3);
			//         if ( (unsigned __int8)sub_1886B1218(v22) )
			//           v5 = (IVolumetricCloudVolume *)v22;
			//       }
			//     }
			//     else
			//     {
			// LABEL_124:
			//       v59 = this;
			//     }
			//     if ( v3 )
			//     {
			//       m_states = (Object_1 *)v3.fields.camera;
			//       if ( m_states )
			//       {
			//         InstanceID = UnityEngine::Object::GetInstanceID(m_states, 0LL);
			//         v68 = InstanceID;
			//         m_states = (Object_1 *)v59.fields.m_states;
			//         if ( m_states )
			//         {
			//           if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
			//                   (Dictionary_2_System_Int32_System_Object_ *)m_states,
			//                   InstanceID,
			//                   &value,
			//                   MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue) )
			//           {
			//             v69 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState);
			//             if ( !v69 )
			//               goto LABEL_134;
			//             *(_DWORD *)(v69 + 20) = 1065353216;
			//             value = (Object *)v69;
			//             m_states = (Object_1 *)v59.fields.m_states;
			//             if ( !m_states )
			//               goto LABEL_134;
			//             System::Collections::Generic::Dictionary<int,System::Object>::Add(
			//               (Dictionary_2_System_Int32_System_Object_ *)m_states,
			//               v68,
			//               (Object *)v69,
			//               MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::Add);
			//           }
			//           m_states = (Object_1 *)value;
			//           if ( value )
			//           {
			//             HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState::UpdateState(
			//               (VolumetricCloudVolumeManager_VolumetricCloudState *)value,
			//               v3,
			//               v5,
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_134:
			//     sub_1802DC2C8(m_states, v21);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(767, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v11, v10);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)v3,
			//     0LL);
			// }
			// 
		}

		private const float FADE_TIME = 2f;

		private Dictionary<int, VolumetricCloudVolumeManager.VolumetricCloudState> m_states;

		private List<IVolumetricCloudVolume> m_VolumetricCloudVolumes;

		private class VolumetricCloudState
		{
			public VolumetricCloudState()
			{
				// // InteractionObject+Multiplier()
				// void RootMotion::FinalIK::InteractionObject::Multiplier::Multiplier(
				//         InteractionObject_Multiplier *this,
				//         MethodInfo *method)
				// {
				//   this.fields.multiplier = 1.0;
				// }
				// 
			}

			public void UpdateState(HGCamera camera, IVolumetricCloudVolume activeVolume)
			{
				// // Void UpdateState(HGCamera, IVolumetricCloudVolume)
				// void HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState::UpdateState(
				//         VolumetricCloudVolumeManager_VolumetricCloudState *this,
				//         HGCamera *camera,
				//         IVolumetricCloudVolume *activeVolume,
				//         MethodInfo *method)
				// {
				//   VolumetricCloudSDF *m_fadingVolume; // rcx
				//   __int64 v8; // rdx
				//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
				//   PassConstructorID__Enum__Array *v10; // r8
				//   HGCamera *v11; // r9
				//   Beyond::JobMathf *v12; // rcx
				//   float v13; // xmm0_4
				//   bool v14; // zf
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
				//   PassConstructorID__Enum__Array *v17; // r8
				//   HGCamera *v18; // r9
				//   float m_fadeRatio; // xmm6_4
				//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
				//   MethodInfo *methodb; // [rsp+20h] [rbp-28h]
				//   MethodInfo *methodc; // [rsp+20h] [rbp-28h]
				//   MethodInfo *v23; // [rsp+28h] [rbp-20h]
				//   MethodInfo *v24; // [rsp+28h] [rbp-20h]
				//   MethodInfo *v25; // [rsp+28h] [rbp-20h]
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   m_fadingVolume = (VolumetricCloudSDF *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
				//     m_fadingVolume = (VolumetricCloudSDF *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v8 = **(_QWORD **)&m_fadingVolume.fields.m_msBakeSizeY;
				//   if ( !v8 )
				//     goto LABEL_18;
				//   if ( *(int *)(v8 + 24) > 768 )
				//   {
				//     if ( !LODWORD(m_fadingVolume.fields.m_InvScale.x) )
				//     {
				//       il2cpp_runtime_class_init_0(m_fadingVolume, v8);
				//       m_fadingVolume = (VolumetricCloudSDF *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     m_fadingVolume = **(VolumetricCloudSDF ***)&m_fadingVolume.fields.m_msBakeSizeY;
				//     if ( !m_fadingVolume )
				//       goto LABEL_18;
				//     if ( LODWORD(m_fadingVolume.fields._._CollectVolumetricRenderCallback) <= 0x300 )
				//       sub_180070270(m_fadingVolume, v8);
				//     if ( m_fadingVolume[11].fields._loadingStates )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(768, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
				//           (ILFixDynamicMethodWrapper_28 *)Patch,
				//           (Object *)this,
				//           (Object *)camera,
				//           (Object *)activeVolume,
				//           0LL);
				//         return;
				//       }
				//       goto LABEL_18;
				//     }
				//   }
				//   if ( this.fields.m_state != 1 && activeVolume != this.fields.m_activeVolume && this.fields.m_activeVolume )
				//   {
				//     this.fields.m_fadingVolume = this.fields.m_activeVolume;
				//     this.fields.m_state = 1;
				//     sub_1800054D0(
				//       (HGRenderPathScene *)&this.fields.m_fadingVolume,
				//       (HGRenderPathBase_HGRenderPathResources *)v8,
				//       (PassConstructorID__Enum__Array *)activeVolume,
				//       (HGCamera *)method,
				//       methoda,
				//       v23);
				//     this.fields.m_activeVolume = 0LL;
				//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_activeVolume, v16, v17, v18, methodc, v25);
				//     this.fields.m_fadeRatio = fmaxf(1.0 - this.fields.m_fadeRatio, 0.0);
				//   }
				//   if ( !this.fields.m_state && activeVolume != this.fields.m_activeVolume )
				//   {
				//     this.fields.m_state = 2;
				//     this.fields.m_activeVolume = activeVolume;
				//     sub_1800054D0(
				//       (HGRenderPathScene *)&this.fields.m_activeVolume,
				//       (HGRenderPathBase_HGRenderPathResources *)v8,
				//       (PassConstructorID__Enum__Array *)activeVolume,
				//       (HGCamera *)method,
				//       methoda,
				//       v23);
				//     this.fields.m_fadeRatio = 0.0;
				//     if ( !activeVolume )
				//       goto LABEL_18;
				//     sub_1886B11B0((VolumetricCloudSDF *)activeVolume, camera);
				//   }
				//   if ( this.fields.m_fadeRatio < 1.0 )
				//   {
				//     m_fadeRatio = this.fields.m_fadeRatio;
				//     this.fields.m_fadeRatio = (float)(UnityEngine::Time::get_deltaTime(0LL) * 0.5) + m_fadeRatio;
				//   }
				//   else
				//   {
				//     if ( activeVolume )
				//     {
				//       if ( this.fields.m_state < 2u )
				//       {
				//         *(_QWORD *)&this.fields.m_state = 2LL;
				//         sub_1886B11B0((VolumetricCloudSDF *)activeVolume, camera);
				//       }
				//       else if ( this.fields.m_state == 2 )
				//       {
				//         this.fields.m_state = 3;
				//         this.fields.m_fadeRatio = 1.0;
				//       }
				//     }
				//     else
				//     {
				//       this.fields.m_state = 0;
				//     }
				//     this.fields.m_activeVolume = activeVolume;
				//     sub_1800054D0(
				//       (HGRenderPathScene *)&this.fields.m_activeVolume,
				//       (HGRenderPathBase_HGRenderPathResources *)v8,
				//       (PassConstructorID__Enum__Array *)activeVolume,
				//       (HGCamera *)method,
				//       methoda,
				//       v23);
				//     this.fields.m_fadingVolume = 0LL;
				//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_fadingVolume, v9, v10, v11, methodb, v24);
				//   }
				//   v13 = this.fields.m_fadeRatio;
				//   Beyond::JobMathf::Clamp01(v12);
				//   v14 = this.fields.m_state == 1;
				//   this.fields.m_fadeRatio = v13;
				//   if ( v14 )
				//   {
				//     m_fadingVolume = (VolumetricCloudSDF *)this.fields.m_fadingVolume;
				// LABEL_38:
				//     if ( m_fadingVolume )
				//     {
				//       sub_1886B12DC(m_fadingVolume, camera, 1);
				//       return;
				//     }
				// LABEL_18:
				//     sub_180B536AC(m_fadingVolume, v8);
				//   }
				//   if ( this.fields.m_state )
				//   {
				//     m_fadingVolume = (VolumetricCloudSDF *)this.fields.m_activeVolume;
				//     goto LABEL_38;
				//   }
				// }
				// 
			}

			public EVolumetricState m_state;

			public float m_fadeRatio;

			public IVolumetricCloudVolume m_activeVolume;

			public IVolumetricCloudVolume m_fadingVolume;
		}
	}
}
