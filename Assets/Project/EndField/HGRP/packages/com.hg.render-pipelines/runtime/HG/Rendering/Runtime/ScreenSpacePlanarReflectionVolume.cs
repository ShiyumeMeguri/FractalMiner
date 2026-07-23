using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/ScreenSpacePlanarReflection", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class ScreenSpacePlanarReflectionVolume : VolumeComponent // TypeDefIndex: 38059
	{
		// Fields
		public BoolParameter enable; // 0x30
		public FloatParameter planeHeight; // 0x38
		public ClampedFloatParameter fadeness; // 0x40
		public ColorParameter tintColor; // 0x48
		public BoolParameter noiseEnable; // 0x50
		[Tooltip("Specifies a noise texture for SSPR.")]
		public Texture2DParameter noiseTexture; // 0x58
		public MinFloatParameter noiseIntensity; // 0x60
		public ClampedFloatParameter rtScale; // 0x68
	
		// Constructors
		public ScreenSpacePlanarReflectionVolume() {} // 0x000000018402BAB0-0x000000018402BC80
		// ScreenSpacePlanarReflectionVolume()
		void HG::Rendering::Runtime::ScreenSpacePlanarReflectionVolume::ScreenSpacePlanarReflectionVolume(
		        ScreenSpacePlanarReflectionVolume *this,
		        MethodInfo *method)
		{
		  BoolParameter *v3; // rax
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
		  MethodInfo *v14; // rdx
		  __int64 v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  Vector4 v18; // xmm0
		  BoolParameter *v19; // rax
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  Texture2DParameter *v22; // rax
		  Texture2DParameter *v23; // rdi
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  __int64 v27; // rax
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  __int64 v30; // rax
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  Vector4 v33; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_10;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enable = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enable, v4, v6, v7, *(MethodInfo **)&v33.x);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v8 )
		    goto LABEL_10;
		  *(_DWORD *)(v8 + 24) = 1008981770;
		  *(_BYTE *)(v8 + 16) = 0;
		  this->fields.planeHeight = (FloatParameter *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.planeHeight, v4, v9, v10, *(MethodInfo **)&v33.x);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_10;
		  *(_DWORD *)(v11 + 24) = 1048576000;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 1008981770;
		  *(_DWORD *)(v11 + 36) = 1065353216;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.fadeness = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fadeness, v4, v12, v13, *(MethodInfo **)&v33.x);
		  v33 = *UnityEngine::Vector4::get_one(&v33, v14);
		  v15 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v15 )
		    goto LABEL_10;
		  v18 = v33;
		  *(_WORD *)(v15 + 41) = 257;
		  *(_BYTE *)(v15 + 16) = 0;
		  *(Vector4 *)(v15 + 24) = v18;
		  this->fields.tintColor = (ColorParameter *)v15;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.tintColor, v4, v16, v17, *(MethodInfo **)&v33.x);
		  v19 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v19 )
		    goto LABEL_10;
		  v19->fields._.m_Value = 0;
		  v19->fields._._.overrideState = 0;
		  this->fields.noiseEnable = v19;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.noiseEnable, v4, v20, v21, *(MethodInfo **)&v33.x);
		  v22 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v23 = v22;
		  if ( !v22 )
		    goto LABEL_10;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v22, 0LL, 0, 0LL);
		  this->fields.noiseTexture = v23;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.noiseTexture, v24, v25, v26, *(MethodInfo **)&v33.x);
		  v27 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v27
		    || (*(_DWORD *)(v27 + 24) = 0,
		        *(_BYTE *)(v27 + 16) = 0,
		        *(_DWORD *)(v27 + 32) = 0,
		        this->fields.noiseIntensity = (MinFloatParameter *)v27,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.noiseIntensity, v4, v28, v29, *(MethodInfo **)&v33.x),
		        (v30 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_10:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v30 + 24) = 1065353216;
		  *(_BYTE *)(v30 + 16) = 0;
		  *(_DWORD *)(v30 + 32) = 1048576000;
		  *(_DWORD *)(v30 + 36) = 1065353216;
		  *(_DWORD *)(v30 + 40) = 1065353216;
		  this->fields.rtScale = (ClampedFloatParameter *)v30;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.rtScale, v4, v31, v32, *(MethodInfo **)&v33.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6DCDC-0x0000000189B6DD38
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ScreenSpacePlanarReflectionVolume::IsActive(
		        ScreenSpacePlanarReflectionVolume *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  BoolParameter *enable; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2704, 0LL) )
		  {
		    enable = this->fields.enable;
		    if ( enable )
		      return sub_180006280(10LL, enable);
		LABEL_5:
		    sub_1800D8260(v3, enable);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2704, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
