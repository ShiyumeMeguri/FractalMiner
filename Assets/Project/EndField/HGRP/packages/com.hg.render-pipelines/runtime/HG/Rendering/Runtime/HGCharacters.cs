using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	public class HGCharacters
	{
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00002608 File Offset: 0x00000808
		public static int count
		{
			get
			{
				// // Int32 get_count()
				// int32_t HG::Rendering::Runtime::HGCharacters::get_count(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   List_1_HG_Rendering_Runtime_HGCharacterHelper_ *characterHelpers; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D8EDB96 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Count);
				//     byte_18D8EDB96 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v1);
				//   characterHelpers = HG::Rendering::Runtime::HGCharacters::get_characterHelpers(0LL);
				//   if ( !characterHelpers )
				//     sub_180B536AC(v4, v3);
				//   return characterHelpers.fields._size;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000025D2 File Offset: 0x000007D2
		public static List<HGCharacterHelper> characterHelpers
		{
			get
			{
				return null;
			}
		}

		public HGCharacters()
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

		public static void EnqueueCharacter(HGCharacterHelper characterHelper)
		{
		}

		public static void SortCharacterHelpers()
		{
			// // Void SortCharacterHelpers()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCharacters::SortCharacterHelpers(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct HGCharacters__Class *v2; // rcx
			//   HGCharacters__StaticFields *static_fields; // rax
			//   __int64 v4; // rdx
			//   HGCharacters__StaticFields *v5; // rcx
			//   __int64 v6; // rdx
			//   Object *current; // rbx
			//   struct HGCharacters__Class *v8; // rax
			//   List_1_System_Object_ *m_CharacterHelpers; // rcx
			//   int16_t v10; // ax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Il2CppExceptionWrapper *v16; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v17; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v18; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDB99 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCharacterHelper>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCharacterHelper>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCharacterHelper>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::IndexOf);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Sort);
			//     byte_18D8EDB99 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3499, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3499, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v1);
			//       v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//     }
			//     if ( v2.static_fields.m_CharacterHelpers )
			//     {
			//       if ( !v2._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v2, v1);
			//         v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//       }
			//       static_fields = v2.static_fields;
			//       if ( !static_fields.m_CharacterHelpers )
			//         sub_180B536AC(v2, v1);
			//       System::Collections::Generic::List<System::Object>::Sort(
			//         (List_1_System_Object_ *)static_fields.m_CharacterHelpers,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Sort);
			//       v5 = TypeInfo::HG::Rendering::Runtime::HGCharacters.static_fields;
			//       if ( !v5.m_CharacterHelpers )
			//         sub_180B536AC(v5, v4);
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         &v17,
			//         (List_1_System_Object_ *)v5.m_CharacterHelpers,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::GetEnumerator);
			//       v18 = v17;
			//       v17._list = 0LL;
			//       *(_QWORD *)&v17._index = &v18;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v18,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCharacterHelper>::MoveNext) )
			//         {
			//           current = v18._current;
			//           v8 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v6);
			//             v8 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//           }
			//           m_CharacterHelpers = (List_1_System_Object_ *)v8.static_fields.m_CharacterHelpers;
			//           if ( !m_CharacterHelpers )
			//             sub_1802DC2C8(0LL, v6);
			//           v10 = System::Collections::Generic::List<System::Object>::IndexOf(
			//                   m_CharacterHelpers,
			//                   current,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::IndexOf);
			//           if ( !current )
			//             sub_1802DC2C8(v12, v11);
			//           HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer((HGCharacterHelper *)current, v10, 0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v16 )
			//       {
			//         v17._list = (List_1_System_Object_ *)v16.ex;
			//         if ( v17._list )
			//           sub_18000F780(v17._list);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public static void DequeueCharacter(HGCharacterHelper characterHelper)
		{
			// // Void DequeueCharacter(HGCharacterHelper)
			// void HG::Rendering::Runtime::HGCharacters::DequeueCharacter(HGCharacterHelper *characterHelper, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGCharacters__Class *v4; // rax
			//   __int64 v5; // rdx
			//   struct HGCharacters__Class *v6; // rax
			//   List_1_System_Object_ *m_CharacterHelpers; // rcx
			//   struct HGCharacters__Class *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB9A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Remove);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB9A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3507, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3507, 0LL);
			//     if ( !Patch )
			//       goto LABEL_20;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)characterHelper, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//     }
			//     if ( v4.static_fields.m_CharacterHelpers )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//       if ( !UnityEngine::Object::op_Equality((Object_1 *)characterHelper, 0LL, 0LL) )
			//       {
			//         v6 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v5);
			//           v6 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//         }
			//         m_CharacterHelpers = (List_1_System_Object_ *)v6.static_fields.m_CharacterHelpers;
			//         if ( !m_CharacterHelpers )
			//           goto LABEL_20;
			//         if ( System::Collections::Generic::List<System::Object>::Contains(
			//                m_CharacterHelpers,
			//                (Object *)characterHelper,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Contains) )
			//         {
			//           v8 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v5);
			//             v8 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//           }
			//           m_CharacterHelpers = (List_1_System_Object_ *)v8.static_fields.m_CharacterHelpers;
			//           if ( m_CharacterHelpers )
			//           {
			//             System::Collections::Generic::List<System::Object>::Remove(
			//               m_CharacterHelpers,
			//               (Object *)characterHelper,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Remove);
			//             if ( characterHelper )
			//             {
			//               HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(characterHelper, -1, 0LL);
			//               HG::Rendering::Runtime::HGCharacters::SortCharacterHelpers(0LL);
			//               return;
			//             }
			//           }
			// LABEL_20:
			//           sub_180B536AC(m_CharacterHelpers, v5);
			//         }
			//       }
			//     }
			//   }
			// }
			// 
		}

		public static short QueryID(HGCharacterHelper characterHelper)
		{
			// // Int16 QueryID(HGCharacterHelper)
			// int16_t HG::Rendering::Runtime::HGCharacters::QueryID(HGCharacterHelper *characterHelper, MethodInfo *method)
			// {
			//   List_1_System_Object_ *m_CharacterHelpers; // rcx
			//   __int64 v4; // rdx
			//   struct HGCharacters__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB9B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::IndexOf);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB9B = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_CharacterHelpers = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     m_CharacterHelpers = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = **(_QWORD **)&m_CharacterHelpers[4].fields._size;
			//   if ( !v4 )
			//     goto LABEL_33;
			//   if ( *(int *)(v4 + 24) <= 3497 )
			//     goto LABEL_44;
			//   if ( !m_CharacterHelpers[5].fields._size )
			//   {
			//     il2cpp_runtime_class_init_0(m_CharacterHelpers, v4);
			//     m_CharacterHelpers = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_CharacterHelpers = **(List_1_System_Object_ ***)&m_CharacterHelpers[4].fields._size;
			//   if ( !m_CharacterHelpers )
			//     goto LABEL_33;
			//   if ( m_CharacterHelpers.fields._size <= 0xDA9u )
			//     sub_180070270(m_CharacterHelpers, v4);
			//   if ( !m_CharacterHelpers[700].monitor )
			//   {
			// LABEL_44:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v4);
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters.static_fields.m_CharacterHelpers )
			//       return -1;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( !byte_18D8F4EFA )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFA = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !characterHelper )
			//       return -1;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( !characterHelper.fields._._._._.m_CachedPtr )
			//       return -1;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v4);
			//     m_CharacterHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCharacters.static_fields.m_CharacterHelpers;
			//     if ( !m_CharacterHelpers )
			//       goto LABEL_33;
			//     if ( !System::Collections::Generic::List<System::Object>::Contains(
			//             m_CharacterHelpers,
			//             (Object *)characterHelper,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Contains) )
			//       return -1;
			//     v5 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v4);
			//       v5 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
			//     }
			//     m_CharacterHelpers = (List_1_System_Object_ *)v5.static_fields.m_CharacterHelpers;
			//     if ( m_CharacterHelpers )
			//       return System::Collections::Generic::List<System::Object>::IndexOf(
			//                m_CharacterHelpers,
			//                (Object *)characterHelper,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::IndexOf);
			// LABEL_33:
			//     sub_180B536AC(m_CharacterHelpers, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3497, 0LL);
			//   if ( !Patch )
			//     goto LABEL_33;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//            (ILFixDynamicMethodWrapper_29 *)Patch,
			//            (Object *)characterHelper,
			//            0LL);
			// }
			// 
			return 0;
		}

		public static uint GetShadowLayer(short index)
		{
			// // UInt32 GetShadowLayer(Int16)
			// uint32_t HG::Rendering::Runtime::HGCharacters::GetShadowLayer(int16_t index, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
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
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1787 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x6FB )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !*((_QWORD *)&v3[38]._0.byval_arg + 1) )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1787, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_694(Patch, index, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( index < 0 )
			//     return 0;
			//   else
			//     return 1 << ((index + 8) & 0x1F);
			// }
			// 
			return 0U;
		}

		public static bool EnableCharacterShadow(HGCharacterHelper characterHelper)
		{
			// // Boolean EnableCharacterShadow(HGCharacterHelper)
			// bool HG::Rendering::Runtime::HGCharacters::EnableCharacterShadow(
			//         HGCharacterHelper *characterHelper,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D8EDB9C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     byte_18D8EDB9C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3496, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3496, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//              (ILFixDynamicMethodWrapper_27 *)Patch,
			//              (Object *)characterHelper,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v3);
			//     return (unsigned __int16)HG::Rendering::Runtime::HGCharacters::QueryID(characterHelper, 0LL) <= 0xEu;
			//   }
			// }
			// 
			return default(bool);
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<HGCharacters> s_Instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly HGCharacters instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static List<HGCharacterHelper> m_CharacterHelpers;

		public const int MAX_CHARACTER_SHADOWMAP_COUNT = 15;

		public const int SHADOW_LAYER_START_INDEX = 8;
	}
}
