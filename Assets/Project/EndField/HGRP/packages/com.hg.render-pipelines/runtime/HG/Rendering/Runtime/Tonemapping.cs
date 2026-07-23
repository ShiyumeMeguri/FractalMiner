using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Tonemapping", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class Tonemapping : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38064
	{
		// Fields
		[Tooltip("Specifies the tonemapping algorithm to use for the color grading process.")]
		public TonemappingModeParameter mode; // 0x30
		[Tooltip("Controls the transition between the toe and the mid section of the curve. A value of 0 results in no transition and a value of 1 results in a very hard transition.")]
		public ClampedFloatParameter toeStrength; // 0x38
		[Tooltip("Controls how much of the dynamic range is in the toe. Higher values result in longer toes and therefore contain more of the dynamic range.")]
		public ClampedFloatParameter toeLength; // 0x40
		[Tooltip("Controls the transition between the midsection and the shoulder of the curve. A value of 0 results in no transition and a value of 1 results in a very hard transition.")]
		public ClampedFloatParameter shoulderStrength; // 0x48
		[Tooltip("Sets how many F-stops (EV) to add to the dynamic range of the curve.")]
		public MinFloatParameter shoulderLength; // 0x50
		[Tooltip("Controls how much overshoot to add to the shoulder.")]
		public ClampedFloatParameter shoulderAngle; // 0x58
		[Tooltip("Sets a gamma correction value that HGRP applies to the whole curve.")]
		public MinFloatParameter gamma; // 0x60
		[Tooltip("A custom 3D texture lookup table to apply.")]
		public Texture3DParameter lutTexture; // 0x68
		[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
		public ClampedFloatParameter lutContribution; // 0x70
	
		// Constructors
		public Tonemapping() {} // 0x000000018402BFD0-0x000000018402C1F0
		// Tonemapping()
		void HG::Rendering::Runtime::Tonemapping::Tonemapping(Tonemapping *this, MethodInfo *method)
		{
		  TonemappingModeParameter *v3; // rax
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
		  __int64 v17; // rax
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  __int64 v23; // rax
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  Texture3DParameter *v26; // rax
		  Texture3DParameter *v27; // rdi
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  __int64 v31; // rax
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  MethodInfo *v34; // [rsp+20h] [rbp-8h]
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		  MethodInfo *v41; // [rsp+20h] [rbp-8h]
		  MethodInfo *v42; // [rsp+20h] [rbp-8h]
		
		  v3 = (TonemappingModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TonemappingModeParameter);
		  if ( !v3 )
		    goto LABEL_11;
		  v3->fields._.m_Value = 5;
		  v3->fields._._.overrideState = 0;
		  this->fields.mode = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mode, v4, v6, v7, v34);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_11;
		  *(_DWORD *)(v8 + 36) = 1065353216;
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.toeStrength = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.toeStrength, v4, v9, v10, v35);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_11;
		  *(_DWORD *)(v11 + 24) = 1056964608;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 36) = 1065353216;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.toeLength = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.toeLength, v4, v12, v13, v36);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_11;
		  *(_DWORD *)(v14 + 24) = 0;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 0;
		  *(_DWORD *)(v14 + 36) = 1065353216;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.shoulderStrength = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shoulderStrength, v4, v15, v16, v37);
		  v17 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v17 )
		    goto LABEL_11;
		  *(_DWORD *)(v17 + 24) = 1056964608;
		  *(_BYTE *)(v17 + 16) = 0;
		  *(_DWORD *)(v17 + 32) = 0;
		  this->fields.shoulderLength = (MinFloatParameter *)v17;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shoulderLength, v4, v18, v19, v38);
		  v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v20 )
		    goto LABEL_11;
		  *(_DWORD *)(v20 + 24) = 0;
		  *(_BYTE *)(v20 + 16) = 0;
		  *(_DWORD *)(v20 + 32) = 0;
		  *(_DWORD *)(v20 + 36) = 1065353216;
		  *(_DWORD *)(v20 + 40) = 1065353216;
		  this->fields.shoulderAngle = (ClampedFloatParameter *)v20;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shoulderAngle, v4, v21, v22, v39);
		  v23 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v23 )
		    goto LABEL_11;
		  *(_DWORD *)(v23 + 24) = 1065353216;
		  *(_BYTE *)(v23 + 16) = 0;
		  *(_DWORD *)(v23 + 32) = 981668463;
		  this->fields.gamma = (MinFloatParameter *)v23;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.gamma, v4, v24, v25, v40);
		  v26 = (Texture3DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture3DParameter);
		  v27 = v26;
		  if ( !v26
		    || (UnityEngine::Rendering::Texture3DParameter::Texture3DParameter(v26, 0LL, 0, 0LL),
		        this->fields.lutTexture = v27,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.lutTexture, v28, v29, v30, v41),
		        (v31 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_11:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v31 + 24) = 1065353216;
		  *(_BYTE *)(v31 + 16) = 0;
		  *(_DWORD *)(v31 + 32) = 0;
		  *(_DWORD *)(v31 + 36) = 1065353216;
		  *(_DWORD *)(v31 + 40) = 1065353216;
		  this->fields.lutContribution = (ClampedFloatParameter *)v31;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.lutContribution, v4, v32, v33, v42);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6DE70-0x0000000189B6DF20
		// Boolean IsActive()
		bool HG::Rendering::Runtime::Tonemapping::IsActive(Tonemapping *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  void *mode; // rdx
		  bool result; // al
		  double v6; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2707, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2707, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    mode = this->fields.mode;
		    if ( !mode )
		      goto LABEL_10;
		    if ( (unsigned int)sub_180002F70(10LL, mode) != 4 )
		    {
		      mode = this->fields.mode;
		      if ( mode )
		        return (unsigned int)sub_180002F70(10LL, mode) != 0;
		LABEL_10:
		      sub_1800D8260(v3, mode);
		    }
		    result = HG::Rendering::Runtime::Tonemapping::ValidateLUT(this, 0LL);
		    if ( result )
		    {
		      mode = this->fields.lutContribution;
		      if ( !mode )
		        goto LABEL_10;
		      v6 = sub_1800057D0(10LL, mode);
		      return *(float *)&v6 > 0.0;
		    }
		  }
		  return result;
		}
		
		public bool ValidateLUT() => default; // 0x0000000189B6DF20-0x0000000189B6E0F8
		// Boolean ValidateLUT()
		bool HG::Rendering::Runtime::Tonemapping::ValidateLUT(Tonemapping *this, MethodInfo *method)
		{
		  bool v3; // di
		  Object_1 *currentAsset; // rbx
		  __int64 v5; // rcx
		  Texture3DParameter *lutTexture; // rdx
		  Object_1 *v7; // rbx
		  __int64 v8; // rax
		  struct Texture3D__Class **v9; // rax
		  Texture3D *v10; // rsi
		  int v11; // ebx
		  int v12; // ebx
		  __int64 v13; // rax
		  RenderTexture *v14; // rsi
		  int v15; // ebx
		  int v16; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2708, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2708, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_21;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentAsset = (Object_1 *)HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(currentAsset, 0LL, 0LL) )
		    return 0;
		  lutTexture = this->fields.lutTexture;
		  if ( !lutTexture )
		    goto LABEL_21;
		  v7 = (Object_1 *)sub_1800460A0(10LL, lutTexture);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(v7, 0LL, 0LL) )
		    return 0;
		  lutTexture = this->fields.lutTexture;
		  if ( !lutTexture || (v8 = sub_1800460A0(10LL, lutTexture)) == 0 )
		LABEL_21:
		    sub_1800D8260(v5, lutTexture);
		  if ( (unsigned int)sub_180002F70(5LL, v8) != 32 )
		    return 0;
		  lutTexture = this->fields.lutTexture;
		  if ( !lutTexture )
		    goto LABEL_21;
		  v9 = (struct Texture3D__Class **)sub_1800460A0(10LL, lutTexture);
		  v10 = (Texture3D *)v9;
		  if ( v9 && *v9 == TypeInfo::UnityEngine::Texture3D )
		  {
		    v11 = sub_180002F70(5LL, v9);
		    if ( v11 == (unsigned int)sub_180002F70(7LL, v10) )
		    {
		      v12 = sub_180002F70(7LL, v10);
		      return v12 == UnityEngine::Texture3D::get_depth(v10, 0LL);
		    }
		  }
		  else
		  {
		    v13 = sub_180005050(v9, TypeInfo::UnityEngine::RenderTexture);
		    v14 = (RenderTexture *)v13;
		    if ( v13 )
		    {
		      if ( (unsigned int)sub_180002F70(9LL, v13) == 3 )
		      {
		        v15 = sub_180002F70(5LL, v14);
		        if ( v15 == (unsigned int)sub_180002F70(7LL, v14) )
		        {
		          v16 = sub_180002F70(7LL, v14);
		          if ( v16 == UnityEngine::RenderTexture::get_volumeDepth(v14, 0LL) )
		            return 1;
		        }
		      }
		    }
		  }
		  return v3;
		}
		
	}
}
