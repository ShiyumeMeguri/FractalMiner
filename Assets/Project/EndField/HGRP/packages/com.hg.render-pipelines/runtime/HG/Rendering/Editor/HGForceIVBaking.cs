using System;
using UnityEngine;

namespace HG.Rendering.Editor
{
	[ExecuteInEditMode]
	public class HGForceIVBaking : MonoBehaviour
	{
		public HGForceIVBaking()
		{
			// // HGForceIVBaking()
			// void HG::Rendering::Editor::HGForceIVBaking::HGForceIVBaking(HGForceIVBaking *this, MethodInfo *method)
			// {
			//   void (__fastcall __noreturn **v2)(); // rbx
			//   __int64 v3; // rdi
			//   unsigned int v4; // eax
			//   unsigned int v5; // eax
			//   __int64 v6; // rax
			//   __int64 v7; // r8
			//   signed __int64 v8; // r9
			//   unsigned __int64 v9; // r8
			//   Il2CppMethodPointer methodPointer; // rtt
			//   __int64 v11; // rdi
			//   __int64 v12; // rax
			//   __int64 v13; // rdi
			//   _QWORD **v14; // rcx
			//   __int64 v15; // r8
			//   __int64 v16; // rax
			//   int v17; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8F4D70 )
			//   {
			//     v2 = 0LL;
			//     method = (MethodInfo *)_InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//     if ( ((unsigned __int8)method & 1) != 0 )
			//     {
			//       v3 = ((unsigned int)method >> 1) & 0xFFFFFFF;
			//       switch ( (unsigned int)method >> 29 )
			//       {
			//         case 1u:
			//           v2 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v3);
			//           goto LABEL_28;
			//         case 2u:
			//           v2 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v3);
			//           goto LABEL_28;
			//         case 3u:
			//         case 6u:
			//           v4 = (unsigned int)method;
			//           method = (MethodInfo *)((unsigned int)method >> 29);
			//           v5 = (v4 >> 1) & 0xFFFFFFF;
			//           if ( (_DWORD)method )
			//           {
			//             if ( (_DWORD)method == 3 )
			//             {
			//               v2 = (void (__fastcall __noreturn **)())sub_180039480(v5);
			//             }
			//             else if ( (_DWORD)method == 6 )
			//             {
			//               v6 = sub_1802DF9C0(v5);
			//               v2 = (void (__fastcall __noreturn **)())sub_18005F4B0(v6, 0LL);
			//             }
			//           }
			//           else if ( v5 == 1 )
			//           {
			//             v2 = off_18A2C5600;
			//           }
			//           goto LABEL_28;
			//         case 4u:
			//           v2 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v3);
			//           goto LABEL_28;
			//         case 5u:
			//           v7 = 8 * v3;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v3) )
			//           {
			//             v2 = *(void (__fastcall __noreturn ***)())(v7 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v8 = il2cpp_string_new_len(
			//                    qword_18D8E5198
			//                  + *(int *)(v7 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                  + *(int *)(qword_18D8E51A0 + 16),
			//                    *(unsigned int *)(v7 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v2 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                       (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v3),
			//                                                       v8,
			//                                                       0LL);
			//             if ( !v2 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v9 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v3) >> 12) & 0x3F;
			//                 method = (MethodInfo *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v3) >> 12) & 0x1FFFFF) >> 6];
			//                 _m_prefetchw(method);
			//                 do
			//                   methodPointer = method.methodPointer;
			//                 while ( methodPointer != (Il2CppMethodPointer)_InterlockedCompareExchange64(
			//                                                                 (volatile signed __int64 *)method,
			//                                                                 (__int64)method.methodPointer | (1LL << v9),
			//                                                                 (signed __int64)method.methodPointer) );
			//               }
			//               v2 = (void (__fastcall __noreturn **)())v8;
			//             }
			//           }
			//           goto LABEL_28;
			//         case 7u:
			//           v11 = sub_1802DF920((unsigned int)v3);
			//           v12 = *(_QWORD *)(v11 + 16);
			//           v13 = (v11 - *(_QWORD *)(v12 + 128)) >> 5;
			//           if ( *(_BYTE *)(v12 + 42) == 21 )
			//           {
			//             v14 = *(_QWORD ***)(v12 + 96);
			//             if ( *v14 )
			//             {
			//               v15 = **v14 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//               v12 = sub_180039550(v15 / 92 + v15);
			//             }
			//             else
			//             {
			//               v12 = 0LL;
			//             }
			//           }
			//           v17 = v13 + *(_DWORD *)(*(_QWORD *)(v12 + 104) + 32LL);
			//           v16 = sub_1801B8ECC(
			//                   (unsigned int)&v17,
			//                   (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                   *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                   12,
			//                   (__int64)sub_1802C7760);
			//           if ( v16 )
			//           {
			//             method = (MethodInfo *)*(unsigned int *)(v16 + 8);
			//             if ( (_DWORD)method != -1 )
			//               v2 = (void (__fastcall __noreturn **)())((char *)method + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//           }
			// LABEL_28:
			//           if ( v2 )
			//             _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v2);
			//           break;
			//         default:
			//           break;
			//       }
			//     }
			//     byte_18D8F4D70 = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, method);
			// }
			// 
		}
	}
}
