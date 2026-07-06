using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class CullingGroupManager
	{
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x000025D2 File Offset: 0x000007D2
		public static CullingGroupManager instance
		{
			get
			{
				return null;
			}
		}

		public CullingGroupManager()
		{
			// // CullingGroupManager()
			// void HG::Rendering::Runtime::CullingGroupManager::CullingGroupManager(CullingGroupManager *this, MethodInfo *method)
			// {
			//   Stack_1_System_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Stack_1_UnityEngine_CullingGroup_ *v6; // rbx
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   String__Array *v10; // [rsp+50h] [rbp+28h]
			//   String *v11; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v12; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDA2A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Stack);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>);
			//     byte_18D8EDA2A = 1;
			//   }
			//   v3 = (Stack_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>);
			//   v6 = (Stack_1_UnityEngine_CullingGroup_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   System::Collections::Generic::Stack<System::Object>::Stack(
			//     v3,
			//     MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Stack);
			//   this.fields.m_FreeList = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v7, v8, v9, v10, v11, v12);
			// }
			// 
		}

		public CullingGroup Alloc()
		{
			// // CullingGroup Alloc()
			// CullingGroup *HG::Rendering::Runtime::CullingGroupManager::Alloc(CullingGroupManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Stack_1_UnityEngine_CullingGroup_ *m_FreeList; // rax
			//   CullingGroup *v6; // rax
			//   CullingGroup *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9194A9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::CullingGroup);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Pop);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::get_Count);
			//     byte_18D9194A9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2363, 0LL) )
			//   {
			//     m_FreeList = this.fields.m_FreeList;
			//     if ( m_FreeList )
			//     {
			//       if ( m_FreeList.fields._size > 0 )
			//         return (CullingGroup *)System::Collections::Generic::Stack<System::Object>::Pop(
			//                                  (Stack_1_System_Object_ *)this.fields.m_FreeList,
			//                                  MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Pop);
			//       v6 = (CullingGroup *)sub_180004920(TypeInfo::UnityEngine::CullingGroup);
			//       v7 = v6;
			//       if ( v6 )
			//       {
			//         UnityEngine::CullingGroup::CullingGroup(v6, 0LL);
			//         return v7;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2363, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_849(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void Free(CullingGroup group)
		{
			// // Void Free(CullingGroup)
			// void HG::Rendering::Runtime::CullingGroupManager::Free(
			//         CullingGroupManager *this,
			//         CullingGroup *group,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Stack_1_System_Object_ *m_FreeList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9194AA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Push);
			//     byte_18D9194AA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2364, 0LL) )
			//   {
			//     m_FreeList = (Stack_1_System_Object_ *)this.fields.m_FreeList;
			//     if ( m_FreeList )
			//     {
			//       System::Collections::Generic::Stack<System::Object>::Push(
			//         m_FreeList,
			//         (Object *)group,
			//         MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Push);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_FreeList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2364, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)group,
			//     0LL);
			// }
			// 
		}

		public void Cleanup()
		{
			// // Void Cleanup()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::CullingGroupManager::Cleanup(CullingGroupManager *this, MethodInfo *method)
			// {
			//   Object *v2; // r14
			//   OneofDescriptorProto *v3; // rdx
			//   __int64 v4; // rcx
			//   FileDescriptor *v5; // r8
			//   MessageDescriptor *v6; // r9
			//   Object__Class *klass; // rbx
			//   __int64 *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   struct MethodInfo *v11; // rdi
			//   __int64 v12; // rcx
			//   int v13; // eax
			//   __int64 v14; // rdx
			//   __int64 v15; // rax
			//   int v16; // eax
			//   __int64 v17; // rdx
			//   __int64 v18; // rdi
			//   Object__Class *v19; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   __int64 v23; // rax
			//   __int64 v24; // rax
			//   __int64 v25; // rax
			//   ProtocolViolationException *v26; // rbx
			//   String *v27; // rax
			//   __int64 v28; // [rsp+0h] [rbp-68h] BYREF
			//   String__Array *v29; // [rsp+20h] [rbp-48h] BYREF
			//   _BYTE v30[64]; // [rsp+28h] [rbp-40h] BYREF
			// 
			//   v2 = (Object *)this;
			//   if ( !byte_18D8EDA29 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::GetEnumerator);
			//     byte_18D8EDA29 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(529, 0LL) )
			//   {
			//     klass = v2[1].klass;
			//     if ( !klass )
			//       sub_180B536AC(v4, v3);
			//     *(_OWORD *)&v30[8] = 0LL;
			//     *(_QWORD *)v30 = klass;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//       (OneofDescriptor *)v30,
			//       v3,
			//       v5,
			//       v6,
			//       v29);
			//     *(_DWORD *)&v30[8] = HIDWORD(klass._0.namespaze);
			//     *(_DWORD *)&v30[12] = -2;
			//     *(_QWORD *)&v30[16] = 0LL;
			//     *(_OWORD *)&v30[24] = *(_OWORD *)v30;
			//     *(_QWORD *)&v30[40] = 0LL;
			//     *(_QWORD *)v30 = 0LL;
			//     *(_QWORD *)&v30[8] = &v30[24];
			//     try
			//     {
			//       while ( 1 )
			//       {
			//         v11 = MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::MoveNext;
			//         v12 = *(_QWORD *)&v30[24];
			//         if ( !*(_QWORD *)&v30[24] )
			//           sub_1802DC2C8(0LL, v8);
			//         if ( *(_DWORD *)&v30[32] != *(_DWORD *)(*(_QWORD *)&v30[24] + 28LL) )
			//         {
			//           v25 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//           v26 = (ProtocolViolationException *)sub_18004C870(v25);
			//           sub_180002BF0(v26);
			//           v27 = (String *)sub_18000F7E0(&off_18D556BA0);
			//           System::Net::ProtocolViolationException::ProtocolViolationException(v26, v27, 0LL);
			//           sub_18000F7C0(v26, v11);
			//         }
			//         if ( *(_DWORD *)&v30[36] == -2 )
			//         {
			//           v16 = *(_DWORD *)(*(_QWORD *)&v30[24] + 24LL) - 1;
			//           *(_DWORD *)&v30[36] = v16;
			//           if ( v16 < 0 )
			//             goto LABEL_16;
			//           v14 = *(_QWORD *)(*(_QWORD *)&v30[24] + 16LL);
			//           if ( !v14 )
			//             sub_1802DC2C8(*(_QWORD *)&v30[24], 0LL);
			//           if ( (unsigned int)v16 >= *(_DWORD *)(v14 + 24) )
			//             sub_180070260(*(_QWORD *)&v30[24], v14, v9, v10);
			//           v15 = *(_QWORD *)(v14 + 8LL * v16 + 32);
			//         }
			//         else
			//         {
			//           if ( *(_DWORD *)&v30[36] == -1 )
			//             goto LABEL_16;
			//           v13 = *(_DWORD *)&v30[36] - 1;
			//           *(_DWORD *)&v30[36] = v13;
			//           if ( v13 < 0 )
			//           {
			//             *(_QWORD *)&v30[40] = 0LL;
			// LABEL_16:
			//             *(_DWORD *)&v30[36] = -1;
			//             goto LABEL_43;
			//           }
			//           v14 = *(_QWORD *)(*(_QWORD *)&v30[24] + 16LL);
			//           if ( !v14 )
			//             sub_1802DC2C8(*(_QWORD *)&v30[24], 0LL);
			//           if ( (unsigned int)v13 >= *(_DWORD *)(v14 + 24) )
			//             sub_180070260(v13, v14, v9, v10);
			//           v15 = *(_QWORD *)(v14 + 8LL * v13 + 32);
			//         }
			//         *(_QWORD *)&v30[40] = v15;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&v30[40],
			//           (OneofDescriptorProto *)v14,
			//           v9,
			//           v10,
			//           v29,
			//           *(String **)v30,
			//           *(MethodInfo **)&v30[8]);
			//         if ( *(int *)&v30[36] < 0 )
			//         {
			//           v23 = sub_18010B520(MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::get_Current.klass);
			//           v24 = sub_180328104(*(_QWORD *)(v23 + 192), 0LL);
			//           sub_18052E9F0(&v30[24], v24);
			//         }
			//         v18 = *(_QWORD *)&v30[40];
			//         if ( !*(_QWORD *)&v30[40] )
			//           sub_1802DC2C8(
			//             MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::get_Current,
			//             v17);
			//         UnityEngine::CullingGroup::DisposeInternal(*(CullingGroup **)&v30[40], 0LL);
			//         *(_QWORD *)(v18 + 16) = 0LL;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v29 )
			//     {
			//       v8 = &v28;
			//       *(_QWORD *)v30 = v29.klass;
			//       *(_DWORD *)(*(_QWORD *)&v30[8] + 12LL) = -1;
			//       v12 = *(_QWORD *)v30;
			//       if ( *(_QWORD *)v30 )
			//         sub_18000F780(*(_QWORD *)v30);
			//       v2 = (Object *)this;
			//     }
			// LABEL_43:
			//     v19 = v2[1].klass;
			//     if ( !v19 )
			//       sub_1802DC2C8(v12, v8);
			//     System::Array::Clear((Array *)v19._0.name, 0, (int32_t)v19._0.namespaze, 0LL);
			//     LODWORD(v19._0.namespaze) = 0;
			//     ++HIDWORD(v19._0.namespaze);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(529, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v22, v21);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, v2, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static CullingGroupManager m_Instance;

		private Stack<CullingGroup> m_FreeList;
	}
}
