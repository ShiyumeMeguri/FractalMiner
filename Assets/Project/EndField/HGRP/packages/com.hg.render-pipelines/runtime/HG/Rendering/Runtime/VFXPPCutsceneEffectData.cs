using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VFXPPCutsceneEffectData : VFXPPData
	{
		public VFXPPCutsceneEffectData()
		{
			// // VFXPPCutsceneEffectData()
			// void HG::Rendering::Runtime::VFXPPCutsceneEffectData::VFXPPCutsceneEffectData(
			//         VFXPPCutsceneEffectData *this,
			//         MethodInfo *method)
			// {
			//   LowLevelList_1_System_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D91941B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>);
			//     byte_18D91941B = 1;
			//   }
			//   this.fields.lightIntensity = 1.0;
			//   this.fields.darkIntensity = 1.0;
			//   v3 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>);
			//   v6 = (List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *)v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v3,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::List);
			//   this.fields.effectList = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.effectList, v7, v8, v9, v10, v11);
			// }
			// 
		}

		[Range(-2f, 2f)]
		public float totalXOffset;

		[Range(-2f, 2f)]
		public float totalYOffset;

		[Space(10f)]
		[Range(0f, 1f)]
		public float lightIntensity;

		[Range(0f, 1f)]
		public float darkIntensity;

		public bool enableCompatibilityMode;

		public List<VFXPPCutsceneEffect.CutsceneEffectCfg> effectList;
	}
}
