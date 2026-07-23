using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.Rain;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGRainPresettingAsset", menuName = "\u2605 Beyond/HGRain/HGRainPresettingAsset")]
	public class HGRainPresettingAsset : ScriptableObject // TypeDefIndex: 37666
	{
		// Fields
		public RainCommonPreSettingParam rainCommonPreSettingParam; // 0x18
	
		// Constructors
		public HGRainPresettingAsset() {} // 0x00000001831D3A70-0x00000001831D3AD0
		// HGRainPresettingAsset()
		void HG::Rendering::Runtime::HGRainPresettingAsset::HGRainPresettingAsset(
		        HGRainPresettingAsset *this,
		        MethodInfo *method)
		{
		  RainCommonPreSettingParam *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RainCommonPreSettingParam *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  v3 = (RainCommonPreSettingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonPreSettingParam);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::Rain::RainCommonPreSettingParam::RainCommonPreSettingParam(v3, 0LL);
		  this->fields.rainCommonPreSettingParam = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.rainCommonPreSettingParam, v7, v8, v9, v10);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
