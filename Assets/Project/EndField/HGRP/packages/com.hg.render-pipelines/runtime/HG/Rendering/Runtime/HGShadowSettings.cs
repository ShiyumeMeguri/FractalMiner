using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Shadowing/Shadows", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class HGShadowSettings : VolumeComponent // TypeDefIndex: 37889
	{
		// Fields
		public ClampedFloatParameter csmDepthBias; // 0x30
		public ClampedFloatParameter csmNormalBias; // 0x38
		public ClampedFloatParameter shadowIntensity; // 0x40
		public ClampedFloatParameter csmShadowSoftness; // 0x48
		public Texture2DParameter csmShadowRamp; // 0x50
		public ClampedFloatParameter characterDepthBias; // 0x58
		public ClampedFloatParameter characterNormalBias; // 0x60
		public LightShadowResolutionParameter characterShadowResolution; // 0x68
		public HGShadowSampleModeParameter characterShadowSampleMode; // 0x70
	
		// Constructors
		private HGShadowSettings() {} // 0x000000018402BD10-0x000000018402BF60
		// HGShadowSettings()
		void HG::Rendering::Runtime::HGShadowSettings::HGShadowSettings(HGShadowSettings *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  Texture2DParameter *v17; // rax
		  Texture2DParameter *v18; // rdi
		  HGRuntimeGrassQuery_Node *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rax
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  LightShadowResolutionParameter *v28; // rax
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  HGShadowSampleModeParameter *v31; // rax
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  HGRuntimeGrassQuery_Node *v34; // rdx
		  HGRuntimeGrassQuery_Node *v35; // r8
		  Int32__Array **v36; // r9
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		  MethodInfo *v41; // [rsp+20h] [rbp-8h]
		  MethodInfo *v42; // [rsp+20h] [rbp-8h]
		  MethodInfo *v43; // [rsp+20h] [rbp-8h]
		  MethodInfo *v44; // [rsp+20h] [rbp-8h]
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+50h] [rbp+28h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v3 )
		    goto LABEL_11;
		  *(_DWORD *)(v3 + 24) = 1065353216;
		  *(_BYTE *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 32) = 0;
		  *(_DWORD *)(v3 + 36) = 1092616192;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  this->fields.csmDepthBias = (ClampedFloatParameter *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.csmDepthBias, v4, v6, v7, v37);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_11;
		  *(_DWORD *)(v8 + 24) = 1065353216;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1084227584;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.csmNormalBias = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.csmNormalBias, v4, v9, v10, v38);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_11;
		  *(_DWORD *)(v11 + 24) = 1065353216;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 36) = 1065353216;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.shadowIntensity = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowIntensity, v4, v12, v13, v39);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_11;
		  *(_DWORD *)(v14 + 24) = 1008981770;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 981668463;
		  *(_DWORD *)(v14 + 36) = 1036831949;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.csmShadowSoftness = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.csmShadowSoftness, v4, v15, v16, v40);
		  v17 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v18 = v17;
		  if ( !v17 )
		    goto LABEL_11;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v17, 0LL, 0, 0LL);
		  this->fields.csmShadowRamp = v18;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.csmShadowRamp, v19, v20, v21, v41);
		  v22 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v22 )
		    goto LABEL_11;
		  *(_DWORD *)(v22 + 24) = 1065353216;
		  *(_BYTE *)(v22 + 16) = 0;
		  *(_DWORD *)(v22 + 32) = 0;
		  *(_DWORD *)(v22 + 36) = 1077936128;
		  *(_DWORD *)(v22 + 40) = 1065353216;
		  this->fields.characterDepthBias = (ClampedFloatParameter *)v22;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.characterDepthBias, v4, v23, v24, v42);
		  v25 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v25 )
		    goto LABEL_11;
		  *(_DWORD *)(v25 + 24) = 1065353216;
		  *(_BYTE *)(v25 + 16) = 0;
		  *(_DWORD *)(v25 + 32) = 0;
		  *(_DWORD *)(v25 + 36) = 1103626240;
		  *(_DWORD *)(v25 + 40) = 1065353216;
		  this->fields.characterNormalBias = (ClampedFloatParameter *)v25;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.characterNormalBias, v4, v26, v27, v43);
		  v28 = (LightShadowResolutionParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::LightShadowResolutionParameter);
		  if ( !v28
		    || (v28->fields._.m_Value = -1,
		        v28->fields._._.overrideState = 0,
		        this->fields.characterShadowResolution = v28,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.characterShadowResolution, v4, v29, v30, v44),
		        (v31 = (HGShadowSampleModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGShadowSampleModeParameter)) == 0LL) )
		  {
		LABEL_11:
		    sub_1800D8260(v5, v4);
		  }
		  v31->fields._.m_Value = 0;
		  v31->fields._._.overrideState = 0;
		  this->fields.characterShadowSampleMode = v31;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.characterShadowSampleMode, v4, v32, v33, v45);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		  this->fields._._displayName_k__BackingField = (String *)"Shadows";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._._displayName_k__BackingField, v34, v35, v36, v46);
		}
		
	}
}
