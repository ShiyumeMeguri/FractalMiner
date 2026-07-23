using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VFXPPCutsceneEffectData : VFXPPData // TypeDefIndex: 37948
	{
		// Fields
		[Range(-2f, 2f)]
		public float totalXOffset; // 0x18
		[Range(-2f, 2f)]
		public float totalYOffset; // 0x1C
		[Range(0f, 1f)]
		[Space(10f)]
		public float lightIntensity; // 0x20
		[Range(0f, 1f)]
		public float darkIntensity; // 0x24
		public bool enableCompatibilityMode; // 0x28
		public List<VFXPPCutsceneEffect.CutsceneEffectCfg> effectList; // 0x30
	
		// Constructors
		public VFXPPCutsceneEffectData() {} // 0x0000000189B60AE0-0x0000000189B60B3C
		// VFXPPCutsceneEffectData()
		void HG::Rendering::Runtime::VFXPPCutsceneEffectData::VFXPPCutsceneEffectData(
		        VFXPPCutsceneEffectData *this,
		        MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  this->fields.lightIntensity = 1.0;
		  this->fields.darkIntensity = 1.0;
		  v3 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>);
		  v6 = (List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::List);
		  this->fields.effectList = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.effectList, v7, v8, v9, v10);
		}
		
	}
}
