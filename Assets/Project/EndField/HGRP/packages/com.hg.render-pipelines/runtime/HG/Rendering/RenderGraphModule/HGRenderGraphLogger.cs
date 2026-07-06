using System;
using System.Collections.Generic;
using System.Text;

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphLogger
	{
		public HGRenderGraphLogger()
		{
			// // HGRenderGraphLogger()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::HGRenderGraphLogger(
			//         HGRenderGraphLogger *this,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_System_Object_System_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Dictionary_2_System_String_System_Text_StringBuilder_ *v6; // rbx
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   String__Array *v10; // [rsp+50h] [rbp+28h]
			//   String *v11; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v12; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8ED94E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>);
			//     byte_18D8ED94E = 1;
			//   }
			//   v3 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>);
			//   v6 = (Dictionary_2_System_String_System_Text_StringBuilder_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			//     v3,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::Dictionary);
			//   this.fields.m_LogMap = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v7, v8, v9, v10, v11, v12);
			// }
			// 
		}

		public void Initialize(string logName)
		{
		}

		public void IncrementIndentation(int value)
		{
			// // Void IncrementIndentation(Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::IncrementIndentation(
			//         HGRenderGraphLogger *this,
			//         int32_t value,
			//         MethodInfo *method)
			// {
			//   int32_t m_CurrentIndentation; // ebx
			//   int32_t v6; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D919356 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919356 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(266, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(266, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     m_CurrentIndentation = this.fields.m_CurrentIndentation;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v6 = -value;
			//     if ( value > 0 )
			//       v6 = value;
			//     this.fields.m_CurrentIndentation = m_CurrentIndentation + v6;
			//   }
			// }
			// 
		}

		public void DecrementIndentation(int value)
		{
			// // Void DecrementIndentation(Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::DecrementIndentation(
			//         HGRenderGraphLogger *this,
			//         int32_t value,
			//         MethodInfo *method)
			// {
			//   int32_t v3; // edi
			//   int32_t m_CurrentIndentation; // ebx
			//   int32_t v7; // eax
			//   int v8; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   v3 = 0;
			//   if ( !byte_18D919357 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919357 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(55, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(55, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     m_CurrentIndentation = this.fields.m_CurrentIndentation;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v7 = -value;
			//     if ( value > 0 )
			//       v7 = value;
			//     v8 = m_CurrentIndentation - v7;
			//     if ( v8 > 0 )
			//       v3 = v8;
			//     this.fields.m_CurrentIndentation = v3;
			//   }
			// }
			// 
		}

		public void LogLine(string format, params object[] args)
		{
			// // Void LogLine(String, Object[])
			// void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//         HGRenderGraphLogger *this,
			//         String *format,
			//         Object__Array *args,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   int v8; // edi
			//   StringBuilder *m_CurrentBuilder; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(34, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(34, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)format,
			//       (Object *)args,
			//       0LL);
			//   }
			//   else
			//   {
			//     v8 = 0;
			//     if ( this.fields.m_CurrentIndentation > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         m_CurrentBuilder = this.fields.m_CurrentBuilder;
			//         if ( !m_CurrentBuilder )
			//           break;
			//         System::Text::StringBuilder::Append(m_CurrentBuilder, 9u, 0LL);
			//         if ( ++v8 >= this.fields.m_CurrentIndentation )
			//           goto LABEL_5;
			//       }
			// LABEL_9:
			//       sub_180B536AC(m_CurrentBuilder, v7);
			//     }
			// LABEL_5:
			//     m_CurrentBuilder = this.fields.m_CurrentBuilder;
			//     if ( !m_CurrentBuilder )
			//       goto LABEL_9;
			//     System::Text::StringBuilder::AppendFormat(m_CurrentBuilder, format, args, 0LL);
			//     m_CurrentBuilder = this.fields.m_CurrentBuilder;
			//     if ( !m_CurrentBuilder )
			//       goto LABEL_9;
			//     System::Text::StringBuilder::AppendLine(m_CurrentBuilder, 0LL);
			//   }
			// }
			// 
		}

		public string GetLog(string logName)
		{
			// // String GetLog(String)
			// String *HG::Rendering::RenderGraphModule::HGRenderGraphLogger::GetLog(
			//         HGRenderGraphLogger *this,
			//         String *logName,
			//         MethodInfo *method)
			// {
			//   Object *v5; // rdx
			//   Dictionary_2_System_String_System_Text_StringBuilder_ *m_LogMap; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *value; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919358 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::TryGetValue);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919358 = 1;
			//   }
			//   value = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(267, 0LL) )
			//   {
			//     m_LogMap = this.fields.m_LogMap;
			//     if ( m_LogMap )
			//     {
			//       if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
			//               (Dictionary_2_System_Object_System_Object_ *)m_LogMap,
			//               (Object *)logName,
			//               &value,
			//               MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::TryGetValue) )
			//         return (String *)"";
			//       v5 = value;
			//       if ( value )
			//         return (String *)sub_18003F3E0(3LL, value);
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_LogMap, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(267, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, (Object *)logName, 0LL);
			// }
			// 
			return null;
		}

		public string GetAllLogs()
		{
			// // String GetAllLogs()
			// // Hidden C++ exception states: #wind=1
			// String *HG::Rendering::RenderGraphModule::HGRenderGraphLogger::GetAllLogs(
			//         HGRenderGraphLogger *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   String *v5; // rbx
			//   Dictionary_2_System_String_System_Text_StringBuilder_ *m_LogMap; // rdi
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Object *value; // rdi
			//   String *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-78h] BYREF
			//   Il2CppException *ex; // [rsp+28h] [rbp-70h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v17; // [rsp+30h] [rbp-68h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v18; // [rsp+38h] [rbp-60h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v19; // [rsp+60h] [rbp-38h] BYREF
			//   String *v20; // [rsp+B0h] [rbp+18h]
			// 
			//   if ( !byte_18D919359 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Text::StringBuilder>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Text::StringBuilder>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Text::StringBuilder>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,System::Text::StringBuilder>::get_Value);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919359 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(268, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(268, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v5 = (String *)"";
			//     v20 = (String *)"";
			//     m_LogMap = this.fields.m_LogMap;
			//     if ( !m_LogMap )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       &v19,
			//       (Dictionary_2_System_Object_System_Object_ *)m_LogMap,
			//       MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::GetEnumerator);
			//     v18 = v19;
			//     ex = 0LL;
			//     v17 = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Text::StringBuilder>::MoveNext) )
			//       {
			//         value = v18._current.value;
			//         if ( !v18._current.value )
			//           sub_1802DC2C8(v8, v7);
			//         System::Text::StringBuilder::AppendLine((StringBuilder *)v18._current.value, 0LL);
			//         v10 = (String *)sub_18003F3E0(3LL, value);
			//         v5 = System::String::Concat(v5, v10, 0LL);
			//         v20 = v5;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       ex = v15.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       return v20;
			//     }
			//     return v5;
			//   }
			// }
			// 
			return null;
		}

		private Dictionary<string, StringBuilder> m_LogMap;

		private StringBuilder m_CurrentBuilder;

		private int m_CurrentIndentation;
	}
}
