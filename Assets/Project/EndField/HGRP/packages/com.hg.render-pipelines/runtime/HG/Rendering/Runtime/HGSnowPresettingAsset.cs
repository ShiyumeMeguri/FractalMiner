using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.Snow;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGSnowPresettingAsset", menuName = "\u2605 Beyond/HGSnow/HGSnowPresettingAsset")]
	public class HGSnowPresettingAsset : ScriptableObject // TypeDefIndex: 37687
	{
		// Fields
		public SnowCommonPreSettingParam snowCommonPreSettingParam; // 0x18
	
		// Constructors
		public HGSnowPresettingAsset() {} // 0x0000000184D2B240-0x0000000184D2B2A0
		// HGSnowPresettingAsset()
		void HG::Rendering::Runtime::HGSnowPresettingAsset::HGSnowPresettingAsset(
		        HGSnowPresettingAsset *this,
		        MethodInfo *method)
		{
		  SnowCommonPreSettingParam *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  SnowCommonPreSettingParam *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  v3 = (SnowCommonPreSettingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam::SnowCommonPreSettingParam(v3, 0LL);
		  this->fields.snowCommonPreSettingParam = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.snowCommonPreSettingParam, v7, v8, v9, v10);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
