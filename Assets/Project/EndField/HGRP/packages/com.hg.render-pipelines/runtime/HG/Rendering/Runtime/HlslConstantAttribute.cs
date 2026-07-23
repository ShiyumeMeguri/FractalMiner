using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class HlslConstantAttribute : Attribute // TypeDefIndex: 38697
	{
		// Properties
		public string OverrideName { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
	
		// Constructors
		public HlslConstantAttribute() {} // Dummy constructor
		public HlslConstantAttribute(string overrideName = null) {} // 0x00000001853908C0-0x00000001853908D0
		// SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
		void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		        SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
		        SortedList_2_System_Object_System_Object_ *dictionary,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields._dict = dictionary;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields,
		    (HGRuntimeGrassQuery_Node *)dictionary,
		    (HGRuntimeGrassQuery_Node *)method,
		    v3,
		    v4);
		}
		
	}
}
