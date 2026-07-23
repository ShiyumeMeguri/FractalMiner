using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public sealed class HlslFileOutputAttribute : Attribute // TypeDefIndex: 37365
{
	// Properties
	public string FileName { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	// IValueSource get_source()
	IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
	        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
	        MethodInfo *method)
	{
	  return this->fields.m_source;
	}
	

	// Constructors
	public HlslFileOutputAttribute() {} // Dummy constructor
	public HlslFileOutputAttribute(string fileName) {} // 0x00000001853908C0-0x00000001853908D0
	// SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
	void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
	        SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
	        SortedList_2_System_Object_System_Object_ *dictionary,
	        MethodInfo *method)
	{
	  Int32__Array **v3; // r9
	  MethodInfo *v4; // [rsp+28h] [rbp+28h]
	  String *v5; // [rsp+30h] [rbp+30h]
	  Extension *v6; // [rsp+38h] [rbp+38h]
	  MethodInfo *v7; // [rsp+40h] [rbp+40h]
	
	  this->fields._dict = dictionary;
	  sub_18002D1B0(
	    (FieldDescriptor *)&this->fields,
	    (FieldDescriptorProto *)dictionary,
	    (FileDescriptor *)method,
	    v3,
	    v4,
	    v5,
	    v6,
	    v7);
	}
	
}

