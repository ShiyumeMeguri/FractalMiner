using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VFXPPManager : MonoBehaviour
	{
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000025D2 File Offset: 0x000007D2
		public static VFXPPManager instance
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000025D2 File Offset: 0x000007D2
		private List<List<VFXPPComponent>> activeComponents
		{
			get
			{
				return null;
			}
		}

		public VFXPPManager()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::VFXPPManager::OnEnable(VFXPPManager_1 *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v6; // rbx
			//   __int64 v7; // rdx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v8; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED996 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering);
			//     byte_18D8ED996 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2097, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2097, 0LL);
			//     if ( !Patch )
			//       goto LABEL_8;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v3;
			//     if ( !v3 )
			//       goto LABEL_8;
			//     System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//       v3,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering,
			//       0LL);
			//     if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager, v7);
			//     UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v6, 0LL);
			//     v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     v9 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v8;
			//     if ( !v8 )
			// LABEL_8:
			//       sub_180B536AC(v5, v4);
			//     System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//       v8,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering,
			//       0LL);
			//     UnityEngine::Rendering::RenderPipelineManager::add_beginFrameRenderingNoAlloc(v9, 0LL);
			//   }
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::VFXPPManager::OnDisable(VFXPPManager_1 *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919426 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering);
			//     byte_18D919426 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2101, 0LL) )
			//   {
			//     v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v3;
			//     if ( v3 )
			//     {
			//       System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//         v3,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering,
			//         0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//       UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v6, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2101, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void AddActiveComponent(VFXPPType type, VFXPPComponent component)
		{
			// // Void AddActiveComponent(VFXPPType, VFXPPComponent)
			// void HG::Rendering::Runtime::VFXPPManager::AddActiveComponent(
			//         VFXPPManager_1 *this,
			//         VFXPPType__Enum type,
			//         VFXPPComponent *component,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *activeComponents; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Object *Item; // rax
			//   List_1_System_Object_ *v11; // rdi
			//   int32_t v12; // ebx
			//   Object *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED997 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Insert);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Item);
			//     byte_18D8ED997 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2051, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2051, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//         (ILFixDynamicMethodWrapper_17 *)Patch,
			//         (Object *)this,
			//         (AkCallbackType__Enum)type,
			//         (Object *)component,
			//         0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   activeComponents = (List_1_System_Object_ *)HG::Rendering::Runtime::VFXPPManager::get_activeComponents(this, 0LL);
			//   if ( !activeComponents )
			//     goto LABEL_8;
			//   Item = System::Collections::Generic::List<System::Object>::get_Item(
			//            activeComponents,
			//            type,
			//            MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Item);
			//   v11 = (List_1_System_Object_ *)Item;
			//   if ( !Item )
			//     goto LABEL_8;
			//   v12 = LODWORD(Item[1].monitor) - 1;
			//   if ( v12 >= 0 )
			//   {
			//     while ( 1 )
			//     {
			//       v13 = System::Collections::Generic::List<System::Object>::get_Item(
			//               v11,
			//               v12,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Item);
			//       if ( !v13 || !component )
			//         goto LABEL_8;
			//       if ( SLODWORD(v13[2].klass) <= component.fields.m_priority )
			//         break;
			//       if ( --v12 < 0 )
			//         goto LABEL_7;
			//     }
			//     System::Collections::Generic::List<System::Object>::Insert(
			//       v11,
			//       v12 + 1,
			//       (Object *)component,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Insert);
			//   }
			//   else
			//   {
			// LABEL_7:
			//     System::Collections::Generic::List<System::Object>::Insert(
			//       v11,
			//       0,
			//       (Object *)component,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Insert);
			//   }
			// }
			// 
		}

		public void RemoveActiveComponent(VFXPPType type, VFXPPComponent component)
		{
			// // Void RemoveActiveComponent(VFXPPType, VFXPPComponent)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VFXPPManager::RemoveActiveComponent(
			//         VFXPPManager_1 *this,
			//         VFXPPType__Enum type,
			//         VFXPPComponent *component,
			//         MethodInfo *method)
			// {
			//   Object *v4; // r14
			//   VFXPPManager_1 *v6; // r13
			//   void (__fastcall __noreturn **v7)(); // rbx
			//   int v8; // edi
			//   Object *current; // rsi
			//   List_1_System_Object_ *activeComponents; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Object *Item; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   __int64 v17; // rdi
			//   __int64 v18; // rax
			//   unsigned int v19; // eax
			//   unsigned int v20; // edx
			//   __int64 v21; // rax
			//   __int64 v22; // r8
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   __int64 v25; // r9
			//   __int64 v26; // rdi
			//   __int64 v27; // rax
			//   __int64 v28; // rdi
			//   _QWORD *v29; // rcx
			//   __int64 v30; // rax
			//   __int64 v31; // rdx
			//   List_1_System_Object_ *items; // rcx
			//   __int64 v33; // rdi
			//   unsigned int v34; // eax
			//   __int64 v35; // rax
			//   __int64 v36; // r8
			//   PassConstructorID__Enum__Array *v37; // r8
			//   HGCamera *v38; // r9
			//   void (__fastcall __noreturn **v39)(); // r9
			//   __int64 v40; // rdi
			//   __int64 v41; // rax
			//   __int64 v42; // rdi
			//   _QWORD *v43; // rcx
			//   __int64 v44; // rax
			//   bool v45; // zf
			//   List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *v46; // rax
			//   __int64 v47; // r8
			//   __int64 v48; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   __int64 v52; // [rsp+0h] [rbp-C8h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-A8h]
			//   MethodInfo *v54; // [rsp+28h] [rbp-A0h]
			//   int v55; // [rsp+30h] [rbp-98h]
			//   _QWORD v56[2]; // [rsp+38h] [rbp-90h] BYREF
			//   VFXPPType__Enum v57; // [rsp+48h] [rbp-80h]
			//   List_1_T_Enumerator_System_Object_ v58; // [rsp+50h] [rbp-78h] BYREF
			//   VFXPPComponent *v59; // [rsp+68h] [rbp-60h]
			//   List_1_T_Enumerator_System_Object_ v60; // [rsp+70h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v61; // [rsp+88h] [rbp-40h] BYREF
			// 
			//   v4 = (Object *)component;
			//   v6 = this;
			//   v57 = type;
			//   v59 = component;
			//   if ( !byte_18D8ED998 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VFXPPComponent>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VFXPPComponent>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VFXPPComponent>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED998 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2054, 0LL) )
			//   {
			//     v7 = 0LL;
			//     v8 = 0;
			//     v55 = 0;
			//     current = 0LL;
			//     v56[0] = 0LL;
			//     activeComponents = (List_1_System_Object_ *)HG::Rendering::Runtime::VFXPPManager::get_activeComponents(v6, 0LL);
			//     if ( !activeComponents )
			//       sub_180B536AC(v12, v11);
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              activeComponents,
			//              type,
			//              MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Item);
			//     if ( !Item )
			//       sub_180B536AC(v15, v14);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v58,
			//       (List_1_System_Object_ *)Item,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::GetEnumerator);
			//     v60 = v58;
			//     v58._list = 0LL;
			//     *(_QWORD *)&v58._index = &v60;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v60,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VFXPPComponent>::MoveNext) )
			//       {
			//         if ( !v60._current )
			//           sub_1802DC2C8(0LL, v16);
			//         if ( SLODWORD(v60._current[2].klass) >= v6.fields.m_curPriorityFilter )
			//         {
			//           v55 = ++v8;
			//           current = v60._current;
			//           if ( v8 != 1 )
			//             current = 0LL;
			//           v56[0] = current;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v61 )
			//     {
			//       v16 = (__int64)&v52;
			//       v58._list = (List_1_System_Object_ *)v61.ex;
			//       if ( v58._list )
			//         sub_18000F780(v58._list);
			//       v7 = 0LL;
			//       v4 = (Object *)component;
			//       v6 = this;
			//       v8 = v55;
			//       current = (Object *)v56[0];
			//     }
			//     if ( v8 == 1 )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         v16 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//         if ( (v16 & 1) != 0 )
			//         {
			//           v17 = ((unsigned int)v16 >> 1) & 0xFFFFFFF;
			//           switch ( (unsigned int)v16 >> 29 )
			//           {
			//             case 1u:
			//               v18 = sub_18003C670((unsigned int)v17);
			//               goto LABEL_22;
			//             case 2u:
			//               v16 = sub_18003C380((unsigned int)v17);
			//               goto LABEL_46;
			//             case 3u:
			//             case 6u:
			//               v19 = ((unsigned int)v16 >> 1) & 0xFFFFFFF;
			//               v20 = (unsigned int)v16 >> 29;
			//               if ( v20 )
			//               {
			//                 if ( v20 == 3 )
			//                 {
			//                   v18 = sub_180039480(v19);
			//                   goto LABEL_22;
			//                 }
			//                 if ( v20 == 6 )
			//                 {
			//                   v21 = sub_1802DF9C0(v19);
			//                   v18 = sub_18005F4B0(v21, 0LL);
			// LABEL_22:
			//                   v16 = v18;
			//                   goto LABEL_46;
			//                 }
			//                 goto LABEL_32;
			//               }
			//               if ( !v19 || (v16 = (__int64)off_18A2C5600, v19 != 1) )
			// LABEL_32:
			//                 v16 = 0LL;
			// LABEL_46:
			//               if ( !v16 )
			//                 goto LABEL_48;
			//               v16 = _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, v16);
			//               byte_18D8F4EFA = 1;
			//               break;
			//             case 4u:
			//               v18 = sub_1802DF920((unsigned int)v17);
			//               goto LABEL_22;
			//             case 5u:
			//               v22 = 8 * v17;
			//               if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v17) )
			//               {
			//                 v16 = *(_QWORD *)(v22 + qword_18D8F6F98);
			//               }
			//               else
			//               {
			//                 v24 = (HGCamera *)il2cpp_string_new_len(
			//                                     qword_18D8E5198
			//                                   + *(int *)(v22 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                                   + *(int *)(qword_18D8E51A0 + 16),
			//                                     *(unsigned int *)(v22 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                 v16 = _InterlockedCompareExchange64(
			//                         (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v17),
			//                         (signed __int64)v24,
			//                         0LL);
			//                 if ( !v16 )
			//                 {
			//                   sub_1800054D0((HGRenderPathScene *)(qword_18D8F6F98 + 8 * v17), 0LL, v23, v24, methoda, v54);
			//                   v16 = v25;
			//                 }
			//               }
			//               goto LABEL_46;
			//             case 7u:
			//               v26 = sub_1802DF920((unsigned int)v17);
			//               v27 = *(_QWORD *)(v26 + 16);
			//               v28 = (v26 - *(_QWORD *)(v27 + 128)) >> 5;
			//               if ( *(_BYTE *)(v27 + 42) == 21 )
			//               {
			//                 v29 = **(_QWORD ***)(v27 + 96);
			//                 if ( v29 )
			//                   v27 = sub_180039510(*v29);
			//                 else
			//                   v27 = 0LL;
			//               }
			//               LODWORD(v56[0]) = v28 + *(_DWORD *)(*(_QWORD *)(v27 + 104) + 32LL);
			//               v30 = sub_1801B8ECC(
			//                       (unsigned int)v56,
			//                       (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                       *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                       12,
			//                       (__int64)sub_1802C7760);
			//               if ( !v30 || (v31 = *(unsigned int *)(v30 + 8), (_DWORD)v31 == -1) )
			//                 v16 = 0LL;
			//               else
			//                 v16 = qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v31;
			//               goto LABEL_46;
			//             default:
			//               goto LABEL_48;
			//           }
			//         }
			//         else
			//         {
			// LABEL_48:
			//           byte_18D8F4EFA = 1;
			//         }
			//       }
			//       items = (List_1_System_Object_ *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         items = (List_1_System_Object_ *)_InterlockedExchangeAdd64(
			//                                            (volatile signed __int64 *)&TypeInfo::UnityEngine::Object,
			//                                            0LL);
			//         if ( ((unsigned __int8)items & 1) != 0 )
			//         {
			//           v33 = ((unsigned int)items >> 1) & 0xFFFFFFF;
			//           switch ( (unsigned int)items >> 29 )
			//           {
			//             case 1u:
			//               v7 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v33);
			//               goto LABEL_75;
			//             case 2u:
			//               v7 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v33);
			//               goto LABEL_75;
			//             case 3u:
			//             case 6u:
			//               v34 = ((unsigned int)items >> 1) & 0xFFFFFFF;
			//               items = (List_1_System_Object_ *)((unsigned int)items >> 29);
			//               if ( (_DWORD)items )
			//               {
			//                 if ( (_DWORD)items == 3 )
			//                 {
			//                   v7 = (void (__fastcall __noreturn **)())sub_180039480(v34);
			//                 }
			//                 else if ( (_DWORD)items == 6 )
			//                 {
			//                   v35 = sub_1802DF9C0(v34);
			//                   v7 = (void (__fastcall __noreturn **)())sub_18005F4B0(v35, 0LL);
			//                 }
			//               }
			//               else if ( v34 == 1 )
			//               {
			//                 v7 = off_18A2C5600;
			//               }
			//               goto LABEL_75;
			//             case 4u:
			//               v7 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v33);
			//               goto LABEL_75;
			//             case 5u:
			//               v36 = 8 * v33;
			//               if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v33) )
			//               {
			//                 v7 = *(void (__fastcall __noreturn ***)())(v36 + qword_18D8F6F98);
			//               }
			//               else
			//               {
			//                 v38 = (HGCamera *)il2cpp_string_new_len(
			//                                     qword_18D8E5198
			//                                   + *(int *)(v36 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                                   + *(int *)(qword_18D8E51A0 + 16),
			//                                     *(unsigned int *)(v36 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                 items = (List_1_System_Object_ *)qword_18D8F6F98;
			//                 v7 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                           (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v33),
			//                                                           (signed __int64)v38,
			//                                                           0LL);
			//                 if ( !v7 )
			//                 {
			//                   sub_1800054D0(
			//                     (HGRenderPathScene *)(qword_18D8F6F98 + 8 * v33),
			//                     (HGRenderPathBase_HGRenderPathResources *)v16,
			//                     v37,
			//                     v38,
			//                     methoda,
			//                     v54);
			//                   v7 = v39;
			//                 }
			//               }
			//               goto LABEL_75;
			//             case 7u:
			//               v40 = sub_1802DF920((unsigned int)v33);
			//               v41 = *(_QWORD *)(v40 + 16);
			//               v42 = (v40 - *(_QWORD *)(v41 + 128)) >> 5;
			//               if ( *(_BYTE *)(v41 + 42) == 21 )
			//               {
			//                 v43 = **(_QWORD ***)(v41 + 96);
			//                 if ( v43 )
			//                   v41 = sub_180039510(*v43);
			//                 else
			//                   v41 = 0LL;
			//               }
			//               LODWORD(v56[0]) = v42 + *(_DWORD *)(*(_QWORD *)(v41 + 104) + 32LL);
			//               v44 = sub_1801B8ECC(
			//                       (unsigned int)v56,
			//                       (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                       *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                       12,
			//                       (__int64)sub_1802C7760);
			//               if ( v44 )
			//               {
			//                 v16 = *(unsigned int *)(v44 + 8);
			//                 if ( (_DWORD)v16 != -1 )
			//                   v7 = (void (__fastcall __noreturn **)())(v16 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//               }
			// LABEL_75:
			//               if ( v7 )
			//                 _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v7);
			//               break;
			//             default:
			//               break;
			//           }
			//         }
			//         byte_18D8F4EAF = 1;
			//       }
			//       LOBYTE(items) = current == 0LL;
			//       if ( current == 0LL && v4 == 0LL )
			//         goto LABEL_90;
			//       if ( v59 )
			//       {
			//         if ( current )
			//         {
			//           v45 = current == v4;
			//         }
			//         else
			//         {
			//           items = (List_1_System_Object_ *)TypeInfo::UnityEngine::Object;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//           v45 = v4[1].klass == 0LL;
			//         }
			//       }
			//       else
			//       {
			//         items = (List_1_System_Object_ *)TypeInfo::UnityEngine::Object;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//         if ( !current )
			//           goto LABEL_108;
			//         v45 = current[1].klass == 0LL;
			//       }
			//       if ( v45 )
			//       {
			// LABEL_90:
			//         if ( !v4 )
			//           goto LABEL_108;
			//         sub_180003EE0(v4.klass);
			//         if ( ((unsigned __int8 (__fastcall *)(Object *, Il2CppGenericClass *))v4.klass[1]._0.parent)(
			//                v4,
			//                v4.klass[1]._0.generic_class) )
			//         {
			//           sub_18003FFC0(15LL, v4, v6.fields.m_ppVolumeProfile);
			//         }
			//         else
			//         {
			//           sub_180087860(17LL, v4, v6.fields.m_envPhaseForVFX);
			//         }
			//       }
			//     }
			//     v46 = HG::Rendering::Runtime::VFXPPManager::get_activeComponents(v6, 0LL);
			//     if ( v46 )
			//     {
			//       v16 = type;
			//       if ( (unsigned int)type >= v46.fields._size )
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       items = (List_1_System_Object_ *)v46.fields._items;
			//       if ( items )
			//       {
			//         if ( (unsigned int)v57 >= items.fields._size )
			//           sub_180070260(items, type, v47, v48);
			//         items = (List_1_System_Object_ *)*((_QWORD *)&items.fields._syncRoot + (int)type);
			//         if ( items )
			//         {
			//           System::Collections::Generic::List<System::Object>::Remove(
			//             items,
			//             v4,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Remove);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_108:
			//     sub_1802DC2C8(items, v16);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2054, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v51, v50);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//     (ILFixDynamicMethodWrapper_17 *)Patch,
			//     (Object *)v6,
			//     (AkCallbackType__Enum)type,
			//     v4,
			//     0LL);
			// }
			// 
		}

		private void OnBeginFrameRendering(ScriptableRenderContext context, List<Camera> targetCamera)
		{
			// // Void OnBeginFrameRendering(ScriptableRenderContext, List`1[UnityEngine.Camera])
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering(
			//         VFXPPManager_1 *this,
			//         ScriptableRenderContext context,
			//         List_1_UnityEngine_Camera_ *targetCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rsi
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   Object_1 *instance; // rbx
			//   __int64 v15; // rdx
			//   VolumeProfile *m_ppVolumeProfile; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   __int64 v21; // rcx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   Volume *m_ppVolumeForVFX; // rbx
			//   Volume *v25; // rbx
			//   HGEnvironmentPhase *m_envPhaseForVFX; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *activeComponents; // rax
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   __int64 v36; // rcx
			//   PassConstructorID__Enum__Array *v37; // r8
			//   HGCamera *v38; // r9
			//   List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *v39; // rbx
			//   __int64 v40; // rcx
			//   unsigned __int64 v41; // rdx
			//   VFXPPComponent *LastActiveComponent; // rsi
			//   unsigned int v43; // r8d
			//   __int64 v44; // rbx
			//   void (__fastcall __noreturn **v45)(); // rax
			//   unsigned int v46; // eax
			//   unsigned int v47; // r8d
			//   __int64 v48; // rax
			//   signed __int64 v49; // r9
			//   char v50; // r8
			//   signed __int64 v51; // rtt
			//   __int64 v52; // rbx
			//   __int64 v53; // rax
			//   __int64 v54; // rbx
			//   _QWORD **v55; // rcx
			//   __int64 v56; // r8
			//   __int64 v57; // rax
			//   unsigned int v58; // r8d
			//   __int64 v59; // rbx
			//   void (__fastcall __noreturn **v60)(); // rax
			//   unsigned int v61; // eax
			//   unsigned int v62; // r8d
			//   __int64 v63; // rax
			//   signed __int64 v64; // r9
			//   char v65; // r8
			//   signed __int64 v66; // rtt
			//   __int64 v67; // rbx
			//   __int64 v68; // rax
			//   __int64 v69; // rbx
			//   _QWORD **v70; // rcx
			//   __int64 v71; // r8
			//   __int64 v72; // rax
			//   __int64 v73; // rdx
			//   Object_1 *gameObject; // rbx
			//   MethodInfo *methoda; // [rsp+20h] [rbp-78h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-78h]
			//   MethodInfo *v77; // [rsp+28h] [rbp-70h]
			//   MethodInfo *v78; // [rsp+28h] [rbp-70h]
			//   Il2CppExceptionWrapper *v79; // [rsp+38h] [rbp-60h] BYREF
			//   int v80; // [rsp+40h] [rbp-58h] BYREF
			//   int v81; // [rsp+50h] [rbp-48h] BYREF
			//   _BYTE v82[24]; // [rsp+60h] [rbp-38h] BYREF
			//   List_1_T_Enumerator_System_Object_ v83; // [rsp+78h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D8ED999 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Count);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
			//     sub_18003C530(&MethodInfo::UnityEngine::ScriptableObject::CreateInstance<UnityEngine::Rendering::VolumeProfile>);
			//     byte_18D8ED999 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, context.m_Ptr);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, context.m_Ptr);
			//   if ( wrapperArray.max_length.size <= 2098 )
			//     goto LABEL_16;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, context.m_Ptr);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = v7.static_fields.wrapperArray;
			//   if ( !v9 )
			//     sub_180B536AC(v7, context.m_Ptr);
			//   if ( v9.max_length.size <= 0x832u )
			//     sub_180070270(v7, context.m_Ptr);
			//   if ( v9[58].vector[10] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2098, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, context, (Object *)targetCamera, 0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     instance = (Object_1 *)HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//     if ( UnityEngine::Object::op_Inequality(instance, (Object_1 *)this, 0LL) )
			//     {
			//       gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v73);
			//       HG::Rendering::Runtime::HGUtils::Destroy(gameObject, 0LL);
			//     }
			//     else
			//     {
			//       m_ppVolumeProfile = this.fields.m_ppVolumeProfile;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !m_ppVolumeProfile )
			//         goto LABEL_31;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( !m_ppVolumeProfile.fields._._.m_CachedPtr )
			//       {
			// LABEL_31:
			//         this.fields.m_ppVolumeProfile = (VolumeProfile *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<UnityEngine::Rendering::VolumeProfile>);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_ppVolumeProfile, v17, v18, v19, methoda, v77);
			//         m_ppVolumeForVFX = this.fields.m_ppVolumeForVFX;
			//         if ( !m_ppVolumeForVFX )
			//           sub_180B536AC(v21, v20);
			//         m_ppVolumeForVFX.fields.priority = 20000.0;
			//         v25 = this.fields.m_ppVolumeForVFX;
			//         if ( !v25 )
			//           sub_180B536AC(v21, v20);
			//         v25.fields.m_InternalProfile = this.fields.m_ppVolumeProfile;
			//         sub_1800054D0((HGRenderPathScene *)&v25.fields.m_InternalProfile, v20, v22, v23, methodb, v78);
			//       }
			//       m_envPhaseForVFX = this.fields.m_envPhaseForVFX;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !m_envPhaseForVFX )
			//         goto LABEL_46;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( !m_envPhaseForVFX.fields._._.m_CachedPtr )
			//       {
			// LABEL_46:
			//         this.fields.m_envPhaseForVFX = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_envPhaseForVFX, v27, v28, v29, methoda, v77);
			//         if ( !this.fields.m_envVolumeForVFX )
			//           sub_180B536AC(v31, v30);
			//         HG::Rendering::Runtime::HGEnvironmentVolume::_UpdatePriority(
			//           this.fields.m_envVolumeForVFX,
			//           EnvPriority__Enum_VfxPp,
			//           0LL);
			//         if ( !this.fields.m_envVolumeForVFX )
			//           sub_180B536AC(v33, v32);
			//         sub_180087860(10LL, this.fields.m_envVolumeForVFX, this.fields.m_envPhaseForVFX);
			//       }
			//       activeComponents = HG::Rendering::Runtime::VFXPPManager::get_activeComponents(this, 0LL);
			//       v39 = activeComponents;
			//       if ( !activeComponents )
			//         sub_180B536AC(v36, v35);
			//       *(_OWORD *)&v82[8] = 0LL;
			//       *(_QWORD *)v82 = activeComponents;
			//       sub_1800054D0((HGRenderPathScene *)v82, v35, v37, v38, methoda, v77);
			//       *(_DWORD *)&v82[8] = 0;
			//       *(_DWORD *)&v82[12] = v39.fields._version;
			//       *(_QWORD *)&v82[16] = 0LL;
			//       *(_OWORD *)&v83._list = *(_OWORD *)v82;
			//       v83._current = 0LL;
			//       *(_QWORD *)v82 = 0LL;
			//       *(_QWORD *)&v82[8] = &v83;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v83,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::MoveNext) )
			//         {
			//           if ( !v83._current )
			//             sub_1802DC2C8(v40, 0LL);
			//           if ( SLODWORD(v83._current[1].monitor) > 0 )
			//           {
			//             LastActiveComponent = HG::Rendering::Runtime::VFXPPManager::_FindLastActiveComponent(
			//                                     this,
			//                                     (List_1_HG_Rendering_Runtime_VFXPPComponent_ *)v83._current,
			//                                     0LL);
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v41);
			//             if ( !byte_18D8F4EFB )
			//             {
			//               v43 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//               if ( (v43 & 1) != 0 )
			//               {
			//                 v44 = (v43 >> 1) & 0xFFFFFFF;
			//                 switch ( v43 >> 29 )
			//                 {
			//                   case 1u:
			//                     v45 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v44);
			//                     goto LABEL_84;
			//                   case 2u:
			//                     v45 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v44);
			//                     goto LABEL_84;
			//                   case 3u:
			//                   case 6u:
			//                     v46 = (v43 >> 1) & 0xFFFFFFF;
			//                     v47 = v43 >> 29;
			//                     if ( v47 )
			//                     {
			//                       if ( v47 == 3 )
			//                       {
			//                         v45 = (void (__fastcall __noreturn **)())sub_180039480(v46);
			//                         goto LABEL_84;
			//                       }
			//                       if ( v47 == 6 )
			//                       {
			//                         v48 = sub_1802DF9C0(v46);
			//                         v45 = (void (__fastcall __noreturn **)())sub_18005F4B0(v48, 0LL);
			//                         goto LABEL_84;
			//                       }
			//                     }
			//                     else if ( v46 == 1 )
			//                     {
			//                       v45 = off_18A2C5600;
			//                       goto LABEL_84;
			//                     }
			// LABEL_83:
			//                     v45 = 0LL;
			// LABEL_84:
			//                     if ( v45 )
			//                       _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v45);
			//                     break;
			//                   case 4u:
			//                     v45 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v44);
			//                     goto LABEL_84;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v44) )
			//                     {
			//                       v45 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v44);
			//                     }
			//                     else
			//                     {
			//                       v49 = il2cpp_string_new_len(
			//                               qword_18D8E5198
			//                             + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v44 + 4)
			//                             + *(int *)(qword_18D8E51A0 + 16),
			//                               *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v44));
			//                       v45 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v44),
			//                                                                  v49,
			//                                                                  0LL);
			//                       if ( !v45 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v41 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v44) >> 12) & 0x1FFFFF) >> 6;
			//                           v50 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v44) >> 12) & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v41]);
			//                           do
			//                             v51 = qword_18D6870D0[v41];
			//                           while ( v51 != _InterlockedCompareExchange64(&qword_18D6870D0[v41], v51 | (1LL << v50), v51) );
			//                         }
			//                         v45 = (void (__fastcall __noreturn **)())v49;
			//                       }
			//                     }
			//                     goto LABEL_84;
			//                   case 7u:
			//                     v52 = sub_1802DF920((unsigned int)v44);
			//                     v53 = *(_QWORD *)(v52 + 16);
			//                     v54 = (v52 - *(_QWORD *)(v53 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v53 + 42) == 21 )
			//                     {
			//                       v55 = *(_QWORD ***)(v53 + 96);
			//                       if ( *v55 )
			//                       {
			//                         v56 = **v55 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v53 = sub_180039550(v56 / 92 + v56);
			//                       }
			//                       else
			//                       {
			//                         v53 = 0LL;
			//                       }
			//                     }
			//                     v80 = v54 + *(_DWORD *)(*(_QWORD *)(v53 + 104) + 32LL);
			//                     v57 = sub_1801B8ECC(
			//                             (unsigned int)&v80,
			//                             (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                             *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                             12,
			//                             (__int64)sub_1802C7760);
			//                     if ( !v57 )
			//                       goto LABEL_83;
			//                     v41 = *(unsigned int *)(v57 + 8);
			//                     if ( (_DWORD)v41 == -1 )
			//                       goto LABEL_83;
			//                     v45 = (void (__fastcall __noreturn **)())(v41 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_84;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D8F4EFB = 1;
			//             }
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v41);
			//             if ( !byte_18D8F4EAF )
			//             {
			//               v58 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//               if ( (v58 & 1) != 0 )
			//               {
			//                 v59 = (v58 >> 1) & 0xFFFFFFF;
			//                 switch ( v58 >> 29 )
			//                 {
			//                   case 1u:
			//                     v60 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v59);
			//                     goto LABEL_117;
			//                   case 2u:
			//                     v60 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v59);
			//                     goto LABEL_117;
			//                   case 3u:
			//                   case 6u:
			//                     v61 = (v58 >> 1) & 0xFFFFFFF;
			//                     v62 = v58 >> 29;
			//                     if ( v62 )
			//                     {
			//                       if ( v62 == 3 )
			//                       {
			//                         v60 = (void (__fastcall __noreturn **)())sub_180039480(v61);
			//                         goto LABEL_117;
			//                       }
			//                       if ( v62 == 6 )
			//                       {
			//                         v63 = sub_1802DF9C0(v61);
			//                         v60 = (void (__fastcall __noreturn **)())sub_18005F4B0(v63, 0LL);
			//                         goto LABEL_117;
			//                       }
			//                     }
			//                     else if ( v61 == 1 )
			//                     {
			//                       v60 = off_18A2C5600;
			//                       goto LABEL_117;
			//                     }
			// LABEL_116:
			//                     v60 = 0LL;
			// LABEL_117:
			//                     if ( v60 )
			//                       _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v60);
			//                     break;
			//                   case 4u:
			//                     v60 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v59);
			//                     goto LABEL_117;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v59) )
			//                     {
			//                       v60 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v59);
			//                     }
			//                     else
			//                     {
			//                       v64 = il2cpp_string_new_len(
			//                               qword_18D8E5198
			//                             + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v59 + 4)
			//                             + *(int *)(qword_18D8E51A0 + 16),
			//                               *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v59));
			//                       v60 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v59),
			//                                                                  v64,
			//                                                                  0LL);
			//                       if ( !v60 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v41 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v59) >> 12) & 0x1FFFFF) >> 6;
			//                           v65 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v59) >> 12) & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v41]);
			//                           do
			//                             v66 = qword_18D6870D0[v41];
			//                           while ( v66 != _InterlockedCompareExchange64(&qword_18D6870D0[v41], v66 | (1LL << v65), v66) );
			//                         }
			//                         v60 = (void (__fastcall __noreturn **)())v64;
			//                       }
			//                     }
			//                     goto LABEL_117;
			//                   case 7u:
			//                     v67 = sub_1802DF920((unsigned int)v59);
			//                     v68 = *(_QWORD *)(v67 + 16);
			//                     v69 = (v67 - *(_QWORD *)(v68 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v68 + 42) == 21 )
			//                     {
			//                       v70 = *(_QWORD ***)(v68 + 96);
			//                       if ( *v70 )
			//                       {
			//                         v71 = **v70 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v68 = sub_180039550(v71 / 92 + v71);
			//                       }
			//                       else
			//                       {
			//                         v68 = 0LL;
			//                       }
			//                     }
			//                     v81 = v69 + *(_DWORD *)(*(_QWORD *)(v68 + 104) + 32LL);
			//                     v72 = sub_1801B8ECC(
			//                             (unsigned int)&v81,
			//                             (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                             *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                             12,
			//                             (__int64)sub_1802C7760);
			//                     if ( !v72 )
			//                       goto LABEL_116;
			//                     v41 = *(unsigned int *)(v72 + 8);
			//                     if ( (_DWORD)v41 == -1 )
			//                       goto LABEL_116;
			//                     v60 = (void (__fastcall __noreturn **)())(v41 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_117;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D8F4EAF = 1;
			//             }
			//             if ( LastActiveComponent )
			//             {
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v41);
			//               if ( LastActiveComponent.fields._._._._._.m_CachedPtr
			//                 && LastActiveComponent.fields.m_priority >= this.fields.m_curPriorityFilter )
			//               {
			//                 if ( (unsigned __int8)sub_1800023D0(9LL, LastActiveComponent) )
			//                   sub_18003FFC0(14LL, LastActiveComponent, this.fields.m_ppVolumeProfile);
			//                 else
			//                   sub_180087860(16LL, LastActiveComponent, this.fields.m_envPhaseForVFX);
			//               }
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v79 )
			//       {
			//         *(Il2CppExceptionWrapper *)v82 = (Il2CppExceptionWrapper)v79.ex;
			//         if ( *(_QWORD *)v82 )
			//           sub_18000F780(*(_QWORD *)v82);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private VFXPPComponent _FindLastActiveComponent(List<VFXPPComponent> list)
		{
			// // VFXPPComponent _FindLastActiveComponent(List`1[HG.Rendering.Runtime.VFXPPComponent])
			// VFXPPComponent *HG::Rendering::Runtime::VFXPPManager::_FindLastActiveComponent(
			//         VFXPPManager_1 *this,
			//         List_1_HG_Rendering_Runtime_VFXPPComponent_ *list,
			//         MethodInfo *method)
			// {
			//   _QWORD **items; // rcx
			//   __int64 v6; // rdx
			//   int32_t v7; // ebx
			//   VFXPPComponent *v8; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED99A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Item);
			//     byte_18D8ED99A = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, list);
			//     items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = *items[23];
			//   if ( !v6 )
			//     goto LABEL_17;
			//   if ( *(int *)(v6 + 24) <= 2100 )
			//     goto LABEL_9;
			//   if ( !*((_DWORD *)items + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(items, v6);
			//     items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = *items[23];
			//   if ( !v6 )
			// LABEL_17:
			//     sub_180B536AC(items, v6);
			//   if ( *(_DWORD *)(v6 + 24) <= 0x834u )
			// LABEL_18:
			//     sub_180070270(items, v6);
			//   if ( *(_QWORD *)(v6 + 16832) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2100, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_781(Patch, (Object *)this, (Object *)list, 0LL);
			//     goto LABEL_17;
			//   }
			// LABEL_9:
			//   if ( !list )
			//     goto LABEL_17;
			//   v7 = list.fields._size - 1;
			//   if ( v7 < 0 )
			//     return 0LL;
			//   while ( 1 )
			//   {
			//     if ( (unsigned int)v7 >= list.fields._size )
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     items = (_QWORD **)list.fields._items;
			//     if ( !items )
			//       goto LABEL_17;
			//     if ( (unsigned int)v7 >= *((_DWORD *)items + 6) )
			//       goto LABEL_18;
			//     v8 = (VFXPPComponent *)items[v7 + 4];
			//     if ( !v8 )
			//       goto LABEL_17;
			//     if ( (unsigned __int8)sub_1800023D0(18LL, v8) || !v7 )
			//       return v8;
			//     if ( --v7 < 0 )
			//       return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public void SetPriorityFilter(VFXPPPriority priority)
		{
			// // Void SetPriorityFilter(VFXPPPriority)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VFXPPManager::SetPriorityFilter(
			//         VFXPPManager_1 *this,
			//         VFXPPPriority__Enum priority,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *activeComponents; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rcx
			//   VFXPPComponent *LastActiveComponent; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   VFXPPComponent *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Il2CppExceptionWrapper *v16; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v17; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v18; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919427 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Count);
			//     byte_18D919427 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2102, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2102, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, priority, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_curPriorityFilter = priority;
			//     activeComponents = (List_1_System_Object_ *)HG::Rendering::Runtime::VFXPPManager::get_activeComponents(this, 0LL);
			//     if ( !activeComponents )
			//       sub_180B536AC(v7, v6);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v17,
			//       activeComponents,
			//       MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::GetEnumerator);
			//     v18 = v17;
			//     v17._list = 0LL;
			//     *(_QWORD *)&v17._index = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::MoveNext) )
			//       {
			//         if ( !v18._current )
			//           sub_1802DC2C8(v8, 0LL);
			//         if ( SLODWORD(v18._current[1].monitor) > 0 )
			//         {
			//           LastActiveComponent = HG::Rendering::Runtime::VFXPPManager::_FindLastActiveComponent(
			//                                   this,
			//                                   (List_1_HG_Rendering_Runtime_VFXPPComponent_ *)v18._current,
			//                                   0LL);
			//           v12 = LastActiveComponent;
			//           if ( !LastActiveComponent )
			//             sub_1802DC2C8(v11, v10);
			//           if ( LastActiveComponent.fields.m_priority < this.fields.m_curPriorityFilter )
			//           {
			//             sub_180003EE0(LastActiveComponent.klass);
			//             if ( ((unsigned __int8 (__fastcall *)(VFXPPComponent *, Il2CppMethodPointer))v12.klass.vtable.get_ImplementedInVolume.method)(
			//                    v12,
			//                    v12.klass.vtable.SetData.methodPtr) )
			//             {
			//               sub_18003FFC0(15LL, v12, this.fields.m_ppVolumeProfile);
			//             }
			//             else
			//             {
			//               sub_180087860(17LL, v12, this.fields.m_envPhaseForVFX);
			//             }
			//           }
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v16 )
			//     {
			//       v17._list = (List_1_System_Object_ *)v16.ex;
			//       if ( v17._list )
			//         sub_18000F780(v17._list);
			//     }
			//   }
			// }
			// 
		}

		public void SetVFXPPActive(bool active)
		{
			// // Void SetVFXPPActive(Boolean)
			// void HG::Rendering::Runtime::VFXPPManager::SetVFXPPActive(VFXPPManager_1 *this, bool active, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Behaviour *m_ppVolumeForVFX; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2103, 0LL) )
			//   {
			//     m_ppVolumeForVFX = (Behaviour *)this.fields.m_ppVolumeForVFX;
			//     if ( m_ppVolumeForVFX )
			//     {
			//       UnityEngine::Behaviour::set_enabled(m_ppVolumeForVFX, active, 0LL);
			//       m_ppVolumeForVFX = (Behaviour *)this.fields.m_envVolumeForVFX;
			//       if ( m_ppVolumeForVFX )
			//       {
			//         UnityEngine::Behaviour::set_enabled(m_ppVolumeForVFX, active, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_ppVolumeForVFX, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2103, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, active, 0LL);
			// }
			// 
		}

		public bool GetVFXPPActive()
		{
			// // Boolean GetVFXPPActive()
			// bool HG::Rendering::Runtime::VFXPPManager::GetVFXPPActive(VFXPPManager_1 *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Behaviour *m_ppVolumeForVFX; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2104, 0LL) )
			//   {
			//     m_ppVolumeForVFX = (Behaviour *)this.fields.m_ppVolumeForVFX;
			//     if ( m_ppVolumeForVFX )
			//       return UnityEngine::Behaviour::get_enabled(m_ppVolumeForVFX, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_ppVolumeForVFX, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2104, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void SetVFXXPPLayer(int layer)
		{
			// // Void SetVFXXPPLayer(Int32)
			// void HG::Rendering::Runtime::VFXPPManager::SetVFXXPPLayer(VFXPPManager_1 *this, int32_t layer, MethodInfo *method)
			// {
			//   Component *instance; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   GameObject *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2105, 0LL) )
			//   {
			//     instance = (Component *)HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       gameObject = UnityEngine::Component::get_gameObject(instance, 0LL);
			//       if ( gameObject )
			//       {
			//         UnityEngine::GameObject::set_layer(gameObject, layer, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2105, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, layer, 0LL);
			// }
			// 
		}

		public void ResetVFXXPPLayer()
		{
			// // Void ResetVFXXPPLayer()
			// void HG::Rendering::Runtime::VFXPPManager::ResetVFXXPPLayer(VFXPPManager_1 *this, MethodInfo *method)
			// {
			//   Component *instance; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   GameObject *gameObject; // rbx
			//   int32_t v7; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919428 )
			//   {
			//     sub_18003C530(&off_18C920E00);
			//     byte_18D919428 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2106, 0LL) )
			//   {
			//     instance = (Component *)HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       gameObject = UnityEngine::Component::get_gameObject(instance, 0LL);
			//       v7 = UnityEngine::LayerMask::NameToLayer((String *)"Default", 0LL);
			//       if ( gameObject )
			//       {
			//         UnityEngine::GameObject::set_layer(gameObject, v7, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2106, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private List<List<VFXPPComponent>> m_activeComponents;

		private Volume m_ppVolumeForVFX;

		private VolumeProfile m_ppVolumeProfile;

		private HGEnvironmentVolume m_envVolumeForVFX;

		private HGEnvironmentPhase m_envPhaseForVFX;

		private VFXPPPriority m_curPriorityFilter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		protected static VFXPPManager s_instance;
	}
}
