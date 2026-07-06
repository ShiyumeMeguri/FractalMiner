using System;

namespace HG.Rendering.Runtime
{
	internal static class StringExtention
	{
		public static string CamelToPascalCaseWithSpace(this string text, [MetadataOffset(Offset = "0x01F90B70")] bool preserveAcronyms = true)
		{
			// // String CamelToPascalCaseWithSpace(String, Boolean)
			// String *HG::Rendering::Runtime::StringExtention::CamelToPascalCaseWithSpace(
			//         String *text,
			//         bool preserveAcronyms,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int32_t stringLength; // ebx
			//   StringBuilder *v8; // rax
			//   StringBuilder *v9; // rbp
			//   __int64 v10; // rdx
			//   uint16_t Chars; // bx
			//   uint16_t v12; // ax
			//   int i; // ebx
			//   __int64 v14; // rdx
			//   uint16_t v15; // si
			//   uint16_t v16; // ax
			//   __int64 v18; // rdx
			//   uint16_t v19; // si
			//   __int64 v20; // rdx
			//   uint16_t v21; // si
			//   __int64 v22; // rdx
			//   uint16_t v23; // si
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED957 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Char);
			//     sub_18003C530(&TypeInfo::System::Text::StringBuilder);
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D8ED957 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(353, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(353, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_164(Patch, (Object *)text, preserveAcronyms, 0LL);
			// LABEL_21:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( System::String::IsNullOrWhiteSpace(text, 0LL) )
			//     return TypeInfo::System::String.static_fields.Empty;
			//   if ( !text )
			//     goto LABEL_21;
			//   stringLength = text.fields._stringLength;
			//   v8 = (StringBuilder *)sub_180004920(TypeInfo::System::Text::StringBuilder);
			//   v9 = v8;
			//   if ( !v8 )
			//     goto LABEL_21;
			//   System::Text::StringBuilder::StringBuilder(v8, 2 * stringLength, 0x7FFFFFFF, 0LL);
			//   Chars = System::String::get_Chars(text, 0, 0LL);
			//   if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Char, v10);
			//   v12 = System::Char::ToUpper(Chars, 0LL);
			//   System::Text::StringBuilder::Append(v9, v12, 0LL);
			//   for ( i = 1; i < text.fields._stringLength; ++i )
			//   {
			//     v15 = System::String::get_Chars(text, i, 0LL);
			//     if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Char, v14);
			//     if ( System::Char::IsUpper(v15, 0LL) )
			//     {
			//       if ( System::String::get_Chars(text, i - 1, 0LL) != 32 )
			//       {
			//         v19 = System::String::get_Chars(text, i - 1, 0LL);
			//         if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Char, v18);
			//         if ( !System::Char::IsUpper(v19, 0LL) )
			//           goto LABEL_20;
			//       }
			//       if ( preserveAcronyms )
			//       {
			//         v21 = System::String::get_Chars(text, i - 1, 0LL);
			//         if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Char, v20);
			//         if ( System::Char::IsUpper(v21, 0LL) && i < text.fields._stringLength - 1 )
			//         {
			//           v23 = System::String::get_Chars(text, i + 1, 0LL);
			//           if ( !TypeInfo::System::Char._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::System::Char, v22);
			//           if ( !System::Char::IsUpper(v23, 0LL) )
			// LABEL_20:
			//             System::Text::StringBuilder::Append(v9, 0x20u, 0LL);
			//         }
			//       }
			//     }
			//     v16 = System::String::get_Chars(text, i, 0LL);
			//     System::Text::StringBuilder::Append(v9, v16, 0LL);
			//   }
			//   return (String *)sub_18003F3E0(3LL, v9);
			// }
			// 
			return null;
		}
	}
}
