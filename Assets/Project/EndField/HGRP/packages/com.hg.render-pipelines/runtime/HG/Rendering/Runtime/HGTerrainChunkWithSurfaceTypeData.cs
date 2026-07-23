using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTerrainChunkWithSurfaceTypeData : MonoBehaviour // TypeDefIndex: 38645
	{
		// Properties
		public int[] surfaceTypeData { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		

		// Void set_getValueDelegate(Func`1[Boolean])
		void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
		        ValueWatcher_1_System_Boolean_ *this,
		        Func_1_Boolean_ *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
		    (HGRuntimeGrassQuery_Node *)value,
		    (HGRuntimeGrassQuery_Node *)method,
		    v3,
		    v4);
		}
		
		public Vector4Int coordinate { get; set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
		// ValueTuple`2[Object,Int32] get_Current()
		ValueTuple_2_Object_Int32_ *System::Collections::Generic::SortedList_2_TKey_TValue_::SortedListValueEnumerator<int,System::ValueTuple<System::Object,int>>::get_Current(
		        ValueTuple_2_Object_Int32_ *__return_ptr retstr,
		        SortedList_2_TKey_TValue_SortedListValueEnumerator_System_Int32_System_ValueTuple_2_Object_Int32_ *this,
		        MethodInfo *method)
		{
		  ValueTuple_2_Object_Int32_ *result; // rax
		
		  result = retstr;
		  *retstr = this->fields._currentValue;
		  return result;
		}
		

		// Void set_color(Color)
		void UnityEngine::Tilemaps::Tile::set_color(Tile *this, Color *value, MethodInfo *method)
		{
		  this->fields.m_Color = *value;
		}
		
	
		// Constructors
		public HGTerrainChunkWithSurfaceTypeData() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	}
}
