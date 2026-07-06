using System;
using Unity.Jobs;
using UnityEngine;

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2773239595
{
	public static void CreateJobReflectionData()
	{
		// // Void CreateJobReflectionData()
		// void __JobReflectionRegistrationOutput__2773239595::CreateJobReflectionData(MethodInfo *method)
		// {
		//   unsigned __int64 v1; // rdx
		//   void (__fastcall __noreturn **v2)(); // rbx
		//   __int64 v3; // rdi
		//   void (__fastcall __noreturn **v4)(); // rax
		//   unsigned int v5; // eax
		//   __int64 v6; // rax
		//   bool v7; // zf
		//   __int64 v8; // r8
		//   signed __int64 v9; // r9
		//   unsigned __int64 v10; // r8
		//   signed __int64 v11; // rtt
		//   __int64 v12; // rdi
		//   __int64 v13; // rax
		//   __int64 v14; // rdi
		//   _QWORD **v15; // rcx
		//   __int64 v16; // r8
		//   __int64 v17; // rax
		//   unsigned int v18; // r8d
		//   __int64 v19; // rdi
		//   void (__fastcall __noreturn **v20)(); // rax
		//   unsigned int v21; // eax
		//   unsigned int v22; // r8d
		//   __int64 v23; // rax
		//   __int64 v24; // r8
		//   signed __int64 v25; // r9
		//   char v26; // r8
		//   signed __int64 v27; // rtt
		//   __int64 v28; // rdi
		//   __int64 v29; // rax
		//   __int64 v30; // rdi
		//   _QWORD **v31; // rcx
		//   __int64 v32; // r8
		//   __int64 v33; // rax
		//   unsigned int v34; // ecx
		//   __int64 v35; // rdi
		//   unsigned int v36; // eax
		//   unsigned int v37; // ecx
		//   __int64 v38; // rax
		//   __int64 v39; // r8
		//   signed __int64 v40; // r9
		//   char v41; // r8
		//   signed __int64 v42; // rtt
		//   __int64 v43; // rdi
		//   __int64 v44; // rax
		//   __int64 v45; // rdi
		//   _QWORD **v46; // rcx
		//   __int64 v47; // r8
		//   __int64 v48; // rax
		//   struct MethodInfo *v49; // rbx
		//   Il2CppRGCTXData v50; // rax
		//   __int64 v51; // rdx
		//   __int64 v52; // rbx
		//   __int64 v53; // rax
		//   __int64 v54; // rdx
		//   Type *TypeFromHandle; // rax
		//   struct MethodInfo *v56; // rbx
		//   Il2CppRGCTXData v57; // rax
		//   __int64 v58; // rdx
		//   __int64 v59; // rbx
		//   __int64 v60; // rax
		//   __int64 v61; // rdx
		//   Type *v62; // rax
		//   struct MethodInfo *v63; // rbx
		//   Il2CppRGCTXData v64; // rax
		//   __int64 v65; // rbx
		//   __int64 v66; // rax
		//   __int64 v67; // rdx
		//   Type *v68; // rax
		//   Il2CppExceptionWrapper *v69; // rdi
		//   Il2CppClass *klass; // rbx
		//   __int64 v71; // rax
		//   Il2CppExceptionWrapper *v72; // rdi
		//   Il2CppClass *v73; // rbx
		//   __int64 v74; // rax
		//   Il2CppExceptionWrapper *v75; // rdi
		//   Il2CppClass *v76; // rbx
		//   __int64 v77; // rax
		//   Il2CppExceptionWrapper v78; // [rsp+30h] [rbp-68h] BYREF
		//   Il2CppExceptionWrapper v79; // [rsp+38h] [rbp-60h] BYREF
		//   Il2CppExceptionWrapper v80; // [rsp+40h] [rbp-58h] BYREF
		//   Il2CppExceptionWrapper *v81; // [rsp+48h] [rbp-50h] BYREF
		//   Il2CppExceptionWrapper *v82; // [rsp+50h] [rbp-48h] BYREF
		//   Il2CppExceptionWrapper *v83; // [rsp+58h] [rbp-40h] BYREF
		//   int v84; // [rsp+60h] [rbp-38h] BYREF
		//   _DWORD v85[4]; // [rsp+70h] [rbp-28h] BYREF
		//   Il2CppException *ex; // [rsp+A8h] [rbp+10h]
		//   Il2CppException *exa; // [rsp+A8h] [rbp+10h]
		//   Il2CppException *exb; // [rsp+A8h] [rbp+10h]
		// 
		//   if ( !byte_18D8EDC36 )
		//   {
		//     v2 = 0LL;
		//     v1 = _InterlockedExchangeAdd64(
		//            (volatile signed __int64 *)&MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>,
		//            0LL);
		//     if ( (v1 & 1) != 0 )
		//     {
		//       v3 = ((unsigned int)v1 >> 1) & 0xFFFFFFF;
		//       switch ( (unsigned int)v1 >> 29 )
		//       {
		//         case 1u:
		//           v4 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v3);
		//           goto LABEL_32;
		//         case 2u:
		//           v4 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v3);
		//           goto LABEL_32;
		//         case 3u:
		//         case 6u:
		//           v5 = ((unsigned int)v1 >> 1) & 0xFFFFFFF;
		//           v1 = (unsigned int)v1 >> 29;
		//           if ( (_DWORD)v1 )
		//           {
		//             if ( (_DWORD)v1 == 3 )
		//             {
		//               v4 = (void (__fastcall __noreturn **)())sub_180039480(v5);
		//               goto LABEL_32;
		//             }
		//             if ( (_DWORD)v1 == 6 )
		//             {
		//               v6 = sub_1802DF9C0(v5);
		//               v4 = (void (__fastcall __noreturn **)())sub_18005F4B0(v6, 0LL);
		//               goto LABEL_32;
		//             }
		//             goto LABEL_13;
		//           }
		//           if ( !v5 || (v7 = v5 == 1, v4 = off_18A2C5600, !v7) )
		// LABEL_13:
		//             v4 = 0LL;
		// LABEL_32:
		//           if ( v4 )
		//             _InterlockedExchange64(
		//               (volatile __int64 *)&MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>,
		//               (__int64)v4);
		//           break;
		//         case 4u:
		//           v4 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v3);
		//           goto LABEL_32;
		//         case 5u:
		//           v8 = 8 * v3;
		//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v3) )
		//           {
		//             v4 = *(void (__fastcall __noreturn ***)())(v8 + qword_18D8F6F98);
		//           }
		//           else
		//           {
		//             v9 = il2cpp_string_new_len(
		//                    qword_18D8E5198
		//                  + *(int *)(v8 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
		//                  + *(int *)(qword_18D8E51A0 + 16),
		//                    *(unsigned int *)(v8 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
		//             v4 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		//                                                       (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v3),
		//                                                       v9,
		//                                                       0LL);
		//             if ( !v4 )
		//             {
		//               if ( dword_18D8E43F8 )
		//               {
		//                 v1 = (unsigned __int64)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v3) >> 12) & 0x1FFFFF) >> 6];
		//                 v10 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v3) >> 12) & 0x3F;
		//                 _m_prefetchw((const void *)v1);
		//                 do
		//                   v11 = *(_QWORD *)v1;
		//                 while ( v11 != _InterlockedCompareExchange64(
		//                                  (volatile signed __int64 *)v1,
		//                                  *(_QWORD *)v1 | (1LL << v10),
		//                                  *(_QWORD *)v1) );
		//               }
		//               v4 = (void (__fastcall __noreturn **)())v9;
		//             }
		//           }
		//           goto LABEL_32;
		//         case 7u:
		//           v12 = sub_1802DF920((unsigned int)v3);
		//           v13 = *(_QWORD *)(v12 + 16);
		//           v14 = (v12 - *(_QWORD *)(v13 + 128)) >> 5;
		//           if ( *(_BYTE *)(v13 + 42) == 21 )
		//           {
		//             v15 = *(_QWORD ***)(v13 + 96);
		//             if ( *v15 )
		//             {
		//               v16 = **v15 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
		//               v13 = sub_180039550(v16 / 92 + v16);
		//             }
		//             else
		//             {
		//               v13 = 0LL;
		//             }
		//           }
		//           v84 = v14 + *(_DWORD *)(*(_QWORD *)(v13 + 104) + 32LL);
		//           v17 = sub_1801B8ECC(
		//                   (unsigned int)&v84,
		//                   (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
		//                   *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
		//                   12,
		//                   (__int64)sub_1802C7760);
		//           if ( !v17 || (v1 = *(unsigned int *)(v17 + 8), (_DWORD)v1 == -1) )
		//             v4 = 0LL;
		//           else
		//             v4 = (void (__fastcall __noreturn **)())(v1 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
		//           goto LABEL_32;
		//         default:
		//           break;
		//       }
		//     }
		//     v18 = _InterlockedExchangeAdd64(
		//             (volatile signed __int64 *)&MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>,
		//             0LL);
		//     if ( (v18 & 1) != 0 )
		//     {
		//       v19 = (v18 >> 1) & 0xFFFFFFF;
		//       switch ( v18 >> 29 )
		//       {
		//         case 1u:
		//           v20 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v19);
		//           goto LABEL_61;
		//         case 2u:
		//           v20 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v19);
		//           goto LABEL_61;
		//         case 3u:
		//         case 6u:
		//           v21 = (v18 >> 1) & 0xFFFFFFF;
		//           v22 = v18 >> 29;
		//           if ( v22 )
		//           {
		//             if ( v22 == 3 )
		//             {
		//               v20 = (void (__fastcall __noreturn **)())sub_180039480(v21);
		//               goto LABEL_61;
		//             }
		//             if ( v22 == 6 )
		//             {
		//               v23 = sub_1802DF9C0(v21);
		//               v20 = (void (__fastcall __noreturn **)())sub_18005F4B0(v23, 0LL);
		//               goto LABEL_61;
		//             }
		//           }
		//           else if ( v21 == 1 )
		//           {
		//             v20 = off_18A2C5600;
		//             goto LABEL_61;
		//           }
		// LABEL_60:
		//           v20 = 0LL;
		// LABEL_61:
		//           if ( v20 )
		//             _InterlockedExchange64(
		//               (volatile __int64 *)&MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>,
		//               (__int64)v20);
		//           break;
		//         case 4u:
		//           v20 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v19);
		//           goto LABEL_61;
		//         case 5u:
		//           v24 = 8 * v19;
		//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v19) )
		//           {
		//             v20 = *(void (__fastcall __noreturn ***)())(v24 + qword_18D8F6F98);
		//           }
		//           else
		//           {
		//             v25 = il2cpp_string_new_len(
		//                     qword_18D8E5198
		//                   + *(int *)(v24 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
		//                   + *(int *)(qword_18D8E51A0 + 16),
		//                     *(unsigned int *)(v24 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
		//             v20 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		//                                                        (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v19),
		//                                                        v25,
		//                                                        0LL);
		//             if ( !v20 )
		//             {
		//               if ( dword_18D8E43F8 )
		//               {
		//                 v1 = 0x180000000LL
		//                    + 8 * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v19) >> 12) & 0x1FFFFF) >> 6)
		//                    + 224948432;
		//                 v26 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v19) >> 12) & 0x3F;
		//                 _m_prefetchw((const void *)v1);
		//                 do
		//                   v27 = *(_QWORD *)v1;
		//                 while ( v27 != _InterlockedCompareExchange64(
		//                                  (volatile signed __int64 *)v1,
		//                                  *(_QWORD *)v1 | (1LL << v26),
		//                                  *(_QWORD *)v1) );
		//               }
		//               v20 = (void (__fastcall __noreturn **)())v25;
		//             }
		//           }
		//           goto LABEL_61;
		//         case 7u:
		//           v28 = sub_1802DF920((unsigned int)v19);
		//           v29 = *(_QWORD *)(v28 + 16);
		//           v30 = (v28 - *(_QWORD *)(v29 + 128)) >> 5;
		//           if ( *(_BYTE *)(v29 + 42) == 21 )
		//           {
		//             v31 = *(_QWORD ***)(v29 + 96);
		//             if ( *v31 )
		//             {
		//               v32 = **v31 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
		//               v29 = sub_180039550(v32 / 92 + v32);
		//             }
		//             else
		//             {
		//               v29 = 0LL;
		//             }
		//           }
		//           v85[0] = v30 + *(_DWORD *)(*(_QWORD *)(v29 + 104) + 32LL);
		//           v33 = sub_1801B8ECC(
		//                   (unsigned int)v85,
		//                   (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
		//                   *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
		//                   12,
		//                   (__int64)sub_1802C7760);
		//           if ( !v33 )
		//             goto LABEL_60;
		//           v1 = *(unsigned int *)(v33 + 8);
		//           if ( (_DWORD)v1 == -1 )
		//             goto LABEL_60;
		//           v20 = (void (__fastcall __noreturn **)())(v1 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
		//           goto LABEL_61;
		//         default:
		//           break;
		//       }
		//     }
		//     v34 = _InterlockedExchangeAdd64(
		//             (volatile signed __int64 *)&MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>,
		//             0LL);
		//     if ( (v34 & 1) != 0 )
		//     {
		//       v35 = (v34 >> 1) & 0xFFFFFFF;
		//       switch ( v34 >> 29 )
		//       {
		//         case 1u:
		//           v2 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v35);
		//           goto LABEL_89;
		//         case 2u:
		//           v2 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v35);
		//           goto LABEL_89;
		//         case 3u:
		//         case 6u:
		//           v36 = (v34 >> 1) & 0xFFFFFFF;
		//           v37 = v34 >> 29;
		//           if ( v37 )
		//           {
		//             if ( v37 == 3 )
		//             {
		//               v2 = (void (__fastcall __noreturn **)())sub_180039480(v36);
		//             }
		//             else if ( v37 == 6 )
		//             {
		//               v38 = sub_1802DF9C0(v36);
		//               v2 = (void (__fastcall __noreturn **)())sub_18005F4B0(v38, 0LL);
		//             }
		//           }
		//           else if ( v36 == 1 )
		//           {
		//             v2 = off_18A2C5600;
		//           }
		//           goto LABEL_89;
		//         case 4u:
		//           v2 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v35);
		//           goto LABEL_89;
		//         case 5u:
		//           v39 = 8 * v35;
		//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v35) )
		//           {
		//             v2 = *(void (__fastcall __noreturn ***)())(v39 + qword_18D8F6F98);
		//           }
		//           else
		//           {
		//             v40 = il2cpp_string_new_len(
		//                     qword_18D8E5198
		//                   + *(int *)(v39 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
		//                   + *(int *)(qword_18D8E51A0 + 16),
		//                     *(unsigned int *)(v39 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
		//             v2 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		//                                                       (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v35),
		//                                                       v40,
		//                                                       0LL);
		//             if ( !v2 )
		//             {
		//               if ( dword_18D8E43F8 )
		//               {
		//                 v1 = 0x180000000LL
		//                    + 8 * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v35) >> 12) & 0x1FFFFF) >> 6)
		//                    + 224948432;
		//                 v41 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v35) >> 12) & 0x3F;
		//                 _m_prefetchw((const void *)v1);
		//                 do
		//                   v42 = *(_QWORD *)v1;
		//                 while ( v42 != _InterlockedCompareExchange64(
		//                                  (volatile signed __int64 *)v1,
		//                                  *(_QWORD *)v1 | (1LL << v41),
		//                                  *(_QWORD *)v1) );
		//               }
		//               v2 = (void (__fastcall __noreturn **)())v40;
		//             }
		//           }
		//           goto LABEL_89;
		//         case 7u:
		//           v43 = sub_1802DF920((unsigned int)v35);
		//           v44 = *(_QWORD *)(v43 + 16);
		//           v45 = (v43 - *(_QWORD *)(v44 + 128)) >> 5;
		//           if ( *(_BYTE *)(v44 + 42) == 21 )
		//           {
		//             v46 = *(_QWORD ***)(v44 + 96);
		//             if ( *v46 )
		//             {
		//               v47 = **v46 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
		//               v44 = sub_180039550(v47 / 92 + v47);
		//             }
		//             else
		//             {
		//               v44 = 0LL;
		//             }
		//           }
		//           v85[0] = v45 + *(_DWORD *)(*(_QWORD *)(v44 + 104) + 32LL);
		//           v48 = sub_1801B8ECC(
		//                   (unsigned int)v85,
		//                   (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
		//                   *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
		//                   12,
		//                   (__int64)sub_1802C7760);
		//           if ( v48 )
		//           {
		//             v1 = *(unsigned int *)(v48 + 8);
		//             if ( (_DWORD)v1 != -1 )
		//               v2 = (void (__fastcall __noreturn **)())(v1 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
		//           }
		// LABEL_89:
		//           if ( v2 )
		//             _InterlockedExchange64(
		//               (volatile __int64 *)&MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>,
		//               (__int64)v2);
		//           break;
		//         default:
		//           break;
		//       }
		//     }
		//     byte_18D8EDC36 = 1;
		//   }
		//   try
		//   {
		//     v49 = MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>;
		//     if ( !MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>.rgctx_data )
		//       sub_180041F40(MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::CalculatePlanesJob>);
		//     v50.rgctxDataDummy = v49.rgctx_data[1].rgctxDataDummy;
		//     if ( (*((_BYTE *)v50.rgctxDataDummy + 312) & 1) == 0 )
		//       ((void (__fastcall *)(_QWORD))sub_18003C700)((const Il2CppRGCTXData)v49.rgctx_data[1].rgctxDataDummy);
		//     if ( !*((_DWORD *)v50.rgctxDataDummy + 56) )
		//       ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)((Il2CppRGCTXData)v50.rgctxDataDummy, v1);
		//     Unity::Jobs::IJobExtensions::JobStruct<HG::Rendering::Runtime::CalculatePlanesJob>::Initialize((MethodInfo *)v49.rgctx_data.rgctxDataDummy);
		//   }
		//   catch ( Il2CppExceptionWrapper *v81 )
		//   {
		//     v69 = v81;
		//     klass = v81.ex.object.klass;
		//     v71 = sub_18003C530(&TypeInfo::System::Exception);
		//     if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v71, klass) )
		//     {
		//       v80.ex = v69.ex;
		//       throw &v80;
		//     }
		//     ex = v69.ex;
		//     v52 = sub_18003C530(&TypeRef::HG::Rendering::Runtime::CalculatePlanesJob);
		//     v53 = sub_18003C530(&TypeInfo::System::Type);
		//     if ( !*(_DWORD *)(v53 + 224) )
		//       il2cpp_runtime_class_init_0(v53, v54);
		//     TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v52, 0LL);
		//     Unity::Jobs::EarlyInitHelpers::JobReflectionDataCreationFailed((Exception *)ex, TypeFromHandle, 0LL);
		//   }
		//   try
		//   {
		//     v56 = MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>;
		//     if ( !MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>.rgctx_data )
		//       sub_180041F40(MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>);
		//     v57.rgctxDataDummy = v56.rgctx_data[1].rgctxDataDummy;
		//     if ( (*((_BYTE *)v57.rgctxDataDummy + 312) & 1) == 0 )
		//       ((void (__fastcall *)(_QWORD))sub_18003C700)((const Il2CppRGCTXData)v56.rgctx_data[1].rgctxDataDummy);
		//     if ( !*((_DWORD *)v57.rgctxDataDummy + 56) )
		//       ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)((Il2CppRGCTXData)v57.rgctxDataDummy, v51);
		//     Unity::Jobs::IJobExtensions::JobStruct<HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities>::Initialize((MethodInfo *)v56.rgctx_data.rgctxDataDummy);
		//   }
		//   catch ( Il2CppExceptionWrapper *v82 )
		//   {
		//     v72 = v82;
		//     v73 = v82.ex.object.klass;
		//     v74 = sub_18003C530(&TypeInfo::System::Exception);
		//     if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v74, v73) )
		//     {
		//       v79.ex = v72.ex;
		//       throw &v79;
		//     }
		//     exa = v72.ex;
		//     v59 = sub_18003C530(&TypeRef::HG::Rendering::Runtime::ASMTileManager::CalculateTileVisibilities);
		//     v60 = sub_18003C530(&TypeInfo::System::Type);
		//     if ( !*(_DWORD *)(v60 + 224) )
		//       il2cpp_runtime_class_init_0(v60, v61);
		//     v62 = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v59, 0LL);
		//     Unity::Jobs::EarlyInitHelpers::JobReflectionDataCreationFailed((Exception *)exa, v62, 0LL);
		//   }
		//   try
		//   {
		//     v63 = MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>;
		//     if ( !MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>.rgctx_data )
		//       sub_180041F40(MethodInfo::Unity::Jobs::IJobExtensions::EarlyJobInit<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>);
		//     v64.rgctxDataDummy = v63.rgctx_data[1].rgctxDataDummy;
		//     if ( (*((_BYTE *)v64.rgctxDataDummy + 312) & 1) == 0 )
		//       ((void (__fastcall *)(_QWORD))sub_18003C700)((const Il2CppRGCTXData)v63.rgctx_data[1].rgctxDataDummy);
		//     if ( !*((_DWORD *)v64.rgctxDataDummy + 56) )
		//       ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)((Il2CppRGCTXData)v64.rgctxDataDummy, v58);
		//     Unity::Jobs::IJobExtensions::JobStruct<HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob>::Initialize((MethodInfo *)v63.rgctx_data.rgctxDataDummy);
		//   }
		//   catch ( Il2CppExceptionWrapper *v83 )
		//   {
		//     v75 = v83;
		//     v76 = v83.ex.object.klass;
		//     v77 = sub_18003C530(&TypeInfo::System::Exception);
		//     if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v77, v76) )
		//     {
		//       v78.ex = v75.ex;
		//       throw &v78;
		//     }
		//     exb = v75.ex;
		//     v65 = sub_18003C530(&TypeRef::HG::Rendering::Runtime::ASMTileManager::CalculateTileScoresJob);
		//     v66 = sub_18003C530(&TypeInfo::System::Type);
		//     if ( !*(_DWORD *)(v66 + 224) )
		//       il2cpp_runtime_class_init_0(v66, v67);
		//     v68 = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v65, 0LL);
		//     Unity::Jobs::EarlyInitHelpers::JobReflectionDataCreationFailed((Exception *)exb, v68, 0LL);
		//   }
		// }
		// 
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
		// // Void EarlyInit()
		// void __JobReflectionRegistrationOutput__2773239595::EarlyInit(MethodInfo *method)
		// {
		//   __JobReflectionRegistrationOutput__2773239595::CreateJobReflectionData(0LL);
		// }
		// 
	}
}
