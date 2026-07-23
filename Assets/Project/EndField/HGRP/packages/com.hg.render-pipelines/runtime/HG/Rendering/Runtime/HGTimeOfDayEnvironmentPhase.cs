using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTimeOfDayEnvironmentPhase : ScriptableObject // TypeDefIndex: 37654
	{
		// Fields
		public List<HGEnvironmentPhaseSlice> envPhaseSliceList; // 0x18
	
		// Constructors
		public HGTimeOfDayEnvironmentPhase() {} // 0x0000000189CEB714-0x0000000189CEB76C
		// HGTimeOfDayEnvironmentPhase()
		void HG::Rendering::Runtime::HGTimeOfDayEnvironmentPhase::HGTimeOfDayEnvironmentPhase(
		        HGTimeOfDayEnvironmentPhase *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGEnvironmentPhaseSlice_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentPhaseSlice>);
		  v6 = (List_1_HG_Rendering_Runtime_HGEnvironmentPhaseSlice_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentPhaseSlice>::List);
		  this->fields.envPhaseSliceList = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.envPhaseSliceList, v7, v8, v9, v10);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
