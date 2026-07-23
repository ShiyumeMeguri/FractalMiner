using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class StringExtention // TypeDefIndex: 37512
	{
		// Extension methods
		public static string CamelToPascalCaseWithSpace(this string text, bool preserveAcronyms = true /* Metadata: 0x02302EE1 */) => default; // 0x000000018374B5F0-0x000000018374B7D0
		// String CamelToPascalCaseWithSpace(String, Boolean)
		String *HG::Rendering::Runtime::StringExtention::CamelToPascalCaseWithSpace(
		        String *text,
		        bool preserveAcronyms,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t stringLength; // ebx
		  __int64 v8; // rbp
		  unsigned int v9; // eax
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  uint16_t Chars; // bx
		  uint16_t v14; // ax
		  int i; // ebx
		  uint16_t v16; // si
		  uint16_t v17; // ax
		  uint16_t v19; // si
		  uint16_t v20; // si
		  uint16_t v21; // si
		  Object *v22; // rbx
		  String *v23; // rax
		  String *v24; // rdi
		  __int64 v25; // rax
		  ArgumentOutOfRangeException *v26; // rbx
		  String *v27; // rax
		  __int64 v28; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v30; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(360, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(360, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		               (ILFixDynamicMethodWrapper_26 *)Patch,
		               (Object *)text,
		               preserveAcronyms,
		               0LL);
		LABEL_21:
		    sub_1800D8260(v6, v5);
		  }
		  if ( System::String::IsNullOrWhiteSpace(text, 0LL) )
		    return TypeInfo::System::String->static_fields->Empty;
		  if ( !text )
		    goto LABEL_21;
		  stringLength = text->fields._stringLength;
		  v8 = sub_1800368D0(TypeInfo::System::Text::StringBuilder);
		  if ( !v8 )
		    goto LABEL_21;
		  v9 = 2 * stringLength;
		  if ( (stringLength & 0x40000000) != 0 )
		  {
		    v22 = (Object *)sub_180035ED0(&off_18E319F10);
		    v23 = (String *)sub_180035ED0(&off_18E38E810);
		    v24 = SR::Format(v23, v22, 0LL);
		    v25 = sub_180035ED0(&TypeInfo::System::ArgumentOutOfRangeException);
		    v26 = (ArgumentOutOfRangeException *)sub_1800368D0(v25);
		    if ( v26 )
		    {
		      v27 = (String *)sub_180035ED0(&off_18E319F10);
		      System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v26, v27, v24, 0LL);
		      v28 = sub_180035ED0(&MethodInfo::System::Text::StringBuilder::StringBuilder);
		      sub_18007E190(v26, v28);
		    }
		    goto LABEL_21;
		  }
		  if ( !v9 )
		  {
		    if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		    v9 = 16;
		  }
		  *(_DWORD *)(v8 + 40) = 0x7FFFFFFF;
		  *(_QWORD *)(v8 + 16) = il2cpp_array_new_specific_1(TypeInfo::System::Char, v9);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v8 + 16), v10, v11, v12, v30);
		  Chars = System::String::get_Chars(text, 0, 0LL);
		  if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		  v14 = System::Char::ToUpper(Chars, 0LL);
		  System::Text::StringBuilder::Append((StringBuilder *)v8, v14, 0LL);
		  for ( i = 1; i < text->fields._stringLength; ++i )
		  {
		    v16 = System::String::get_Chars(text, i, 0LL);
		    if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		    if ( System::Char::IsUpper(v16, 0LL) )
		    {
		      if ( System::String::get_Chars(text, i - 1, 0LL) != 32 )
		      {
		        v19 = System::String::get_Chars(text, i - 1, 0LL);
		        if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		        if ( !System::Char::IsUpper(v19, 0LL) )
		          goto LABEL_20;
		      }
		      if ( preserveAcronyms )
		      {
		        v20 = System::String::get_Chars(text, i - 1, 0LL);
		        if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		        if ( System::Char::IsUpper(v20, 0LL) && i < text->fields._stringLength - 1 )
		        {
		          v21 = System::String::get_Chars(text, i + 1, 0LL);
		          if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		          if ( !System::Char::IsUpper(v21, 0LL) )
		LABEL_20:
		            System::Text::StringBuilder::Append((StringBuilder *)v8, 0x20u, 0LL);
		        }
		      }
		    }
		    v17 = System::String::get_Chars(text, i, 0LL);
		    System::Text::StringBuilder::Append((StringBuilder *)v8, v17, 0LL);
		  }
		  return (String *)sub_180032CB0(3LL, v8);
		}
		
	}
}
