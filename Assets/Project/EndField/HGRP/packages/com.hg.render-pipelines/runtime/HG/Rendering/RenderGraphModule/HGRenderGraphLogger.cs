using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphLogger // TypeDefIndex: 37437
	{
		// Fields
		private Dictionary<string, StringBuilder> m_LogMap; // 0x10
		private StringBuilder m_CurrentBuilder; // 0x18
		private int m_CurrentIndentation; // 0x20
	
		// Constructors
		public HGRenderGraphLogger() {} // 0x0000000183947120-0x0000000183947170
		// HGRenderGraphLogger()
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::HGRenderGraphLogger(
		        HGRenderGraphLogger *this,
		        MethodInfo *method)
		{
		  Dictionary_2_System_Object_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_System_String_System_Text_StringBuilder_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>);
		  v6 = (Dictionary_2_System_String_System_Text_StringBuilder_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::Dictionary);
		  this->fields.m_LogMap = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v10);
		}
		
	
		// Methods
		public void Initialize(string logName) {} // 0x0000000189B370EC-0x0000000189B371E0
		// Void Initialize(String)
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::Initialize(
		        HGRenderGraphLogger *this,
		        String *logName,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_Object_System_Object_ *m_LogMap; // rcx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  StringBuilder *v10; // rax
		  Object *v11; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  Object *value; // [rsp+48h] [rbp+20h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(185, 0LL) )
		  {
		    m_LogMap = (Dictionary_2_System_Object_System_Object_ *)this->fields.m_LogMap;
		    if ( !m_LogMap )
		      goto LABEL_10;
		    if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
		            m_LogMap,
		            (Object *)logName,
		            &value,
		            MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::TryGetValue) )
		    {
		      v10 = (StringBuilder *)sub_1800368D0(TypeInfo::System::Text::StringBuilder);
		      v11 = (Object *)v10;
		      if ( !v10 )
		        goto LABEL_10;
		      System::Text::StringBuilder::StringBuilder(v10, 0LL);
		      m_LogMap = (Dictionary_2_System_Object_System_Object_ *)this->fields.m_LogMap;
		      value = v11;
		      if ( !m_LogMap )
		        goto LABEL_10;
		      System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		        m_LogMap,
		        (Object *)logName,
		        v11,
		        MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::Add);
		    }
		    this->fields.m_CurrentBuilder = (StringBuilder *)value;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CurrentBuilder, v7, v8, v9, v13);
		    m_LogMap = (Dictionary_2_System_Object_System_Object_ *)this->fields.m_CurrentBuilder;
		    if ( m_LogMap )
		    {
		      System::Text::StringBuilder::Clear((StringBuilder *)m_LogMap, 0LL);
		      this->fields.m_CurrentIndentation = 0;
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(m_LogMap, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(185, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)logName,
		    0LL);
		}
		
		public void IncrementIndentation(int value) {} // 0x0000000189B37074-0x0000000189B370EC
		// Void IncrementIndentation(Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::IncrementIndentation(
		        HGRenderGraphLogger *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  int32_t m_CurrentIndentation; // ebx
		  int32_t v6; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(270, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(270, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    m_CurrentIndentation = this->fields.m_CurrentIndentation;
		    sub_1800036A0(TypeInfo::System::Math);
		    v6 = -value;
		    if ( value > 0 )
		      v6 = value;
		    this->fields.m_CurrentIndentation = m_CurrentIndentation + v6;
		  }
		}
		
		public void DecrementIndentation(int value) {} // 0x0000000189B36DD4-0x0000000189B36E5C
		// Void DecrementIndentation(Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::DecrementIndentation(
		        HGRenderGraphLogger *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  int32_t v5; // edi
		  int32_t m_CurrentIndentation; // ebx
		  int32_t v7; // eax
		  int v8; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  v5 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(54, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(54, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    m_CurrentIndentation = this->fields.m_CurrentIndentation;
		    sub_1800036A0(TypeInfo::System::Math);
		    v7 = -value;
		    if ( value > 0 )
		      v7 = value;
		    v8 = m_CurrentIndentation - v7;
		    if ( v8 > 0 )
		      v5 = v8;
		    this->fields.m_CurrentIndentation = v5;
		  }
		}
		
		public void LogLine(string format, params object[] args) {} // 0x0000000189B371E0-0x0000000189B3729C
		// Void LogLine(String, Object[])
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		        HGRenderGraphLogger *this,
		        String *format,
		        Object__Array *args,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  int v8; // edi
		  StringBuilder *m_CurrentBuilder; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(29, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(29, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)format,
		      (Object *)args,
		      0LL);
		  }
		  else
		  {
		    v8 = 0;
		    if ( this->fields.m_CurrentIndentation > 0 )
		    {
		      while ( 1 )
		      {
		        m_CurrentBuilder = this->fields.m_CurrentBuilder;
		        if ( !m_CurrentBuilder )
		          break;
		        System::Text::StringBuilder::Append(m_CurrentBuilder, 9u, 0LL);
		        if ( ++v8 >= this->fields.m_CurrentIndentation )
		          goto LABEL_5;
		      }
		LABEL_9:
		      sub_1800D8260(m_CurrentBuilder, v7);
		    }
		LABEL_5:
		    m_CurrentBuilder = this->fields.m_CurrentBuilder;
		    if ( !m_CurrentBuilder )
		      goto LABEL_9;
		    System::Text::StringBuilder::AppendFormat(m_CurrentBuilder, format, args, 0LL);
		    m_CurrentBuilder = this->fields.m_CurrentBuilder;
		    if ( !m_CurrentBuilder )
		      goto LABEL_9;
		    System::Text::StringBuilder::AppendLine(m_CurrentBuilder, 0LL);
		  }
		}
		
		public string GetLog(string logName) => default; // 0x0000000189B36FD8-0x0000000189B37074
		// String GetLog(String)
		String *HG::Rendering::RenderGraphModule::HGRenderGraphLogger::GetLog(
		        HGRenderGraphLogger *this,
		        String *logName,
		        MethodInfo *method)
		{
		  Object *v5; // rdx
		  Dictionary_2_System_String_System_Text_StringBuilder_ *m_LogMap; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *value; // [rsp+48h] [rbp+20h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(271, 0LL) )
		  {
		    m_LogMap = this->fields.m_LogMap;
		    if ( m_LogMap )
		    {
		      if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
		              (Dictionary_2_System_Object_System_Object_ *)m_LogMap,
		              (Object *)logName,
		              &value,
		              MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::TryGetValue) )
		        return (String *)"";
		      v5 = value;
		      if ( value )
		        return (String *)sub_180032CB0(3LL, value);
		    }
		LABEL_8:
		    sub_1800D8260(m_LogMap, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(271, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_130(Patch, (Object *)this, (Object *)logName, 0LL);
		}
		
		public string GetAllLogs() => default; // 0x0000000189B36E5C-0x0000000189B36FD8
		// String GetAllLogs()
		// Hidden C++ exception states: #wind=1
		String *HG::Rendering::RenderGraphModule::HGRenderGraphLogger::GetAllLogs(
		        HGRenderGraphLogger *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  String *v5; // rbx
		  Dictionary_2_System_String_System_Text_StringBuilder_ *m_LogMap; // rdi
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Object *value; // rdi
		  String *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-78h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-70h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v17; // [rsp+30h] [rbp-68h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v18; // [rsp+38h] [rbp-60h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v19; // [rsp+60h] [rbp-38h] BYREF
		  String *v20; // [rsp+B0h] [rbp+18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(272, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(272, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = (String *)"";
		    v20 = (String *)"";
		    m_LogMap = this->fields.m_LogMap;
		    if ( !m_LogMap )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v19,
		      (Dictionary_2_System_UInt64_System_Object_ *)m_LogMap,
		      MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Text::StringBuilder>::GetEnumerator);
		    v18 = v19;
		    ex = 0LL;
		    v17 = &v18;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
		                &v18,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Text::StringBuilder>::MoveNext) )
		      {
		        value = v18._current.value;
		        if ( !v18._current.value )
		          sub_1800D8250(v8, v7);
		        System::Text::StringBuilder::AppendLine((StringBuilder *)v18._current.value, 0LL);
		        v10 = (String *)sub_180032CB0(3LL, value);
		        v5 = System::String::Concat(v5, v10, 0LL);
		        v20 = v5;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      ex = v15->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      return v20;
		    }
		    return v5;
		  }
		}
		
	}
}
