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
	[VolumeComponentMenuForRenderPipeline("Post-processing/Lift, Gamma, Gain", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38054
	{
		// Fields
		[Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
		public Vector4Parameter lift; // 0x30
		[Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
		public Vector4Parameter gamma; // 0x38
		[Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
		public Vector4Parameter gain; // 0x40
	
		// Constructors
		private LiftGammaGain() {} // 0x000000018374BCE0-0x000000018374BDA0
		// LiftGammaGain()
		void HG::Rendering::Runtime::LiftGammaGain::LiftGammaGain(LiftGammaGain *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __m128i si128; // xmm6
		  __int64 v9; // rax
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // rax
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  MethodInfo *v18; // [rsp+20h] [rbp-18h]
		  MethodInfo *v19; // [rsp+20h] [rbp-18h]
		  MethodInfo *v20; // [rsp+20h] [rbp-18h]
		  MethodInfo *v21; // [rsp+60h] [rbp+28h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v3 )
		    goto LABEL_5;
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		  *(__m128i *)(v3 + 24) = si128;
		  *(_BYTE *)(v3 + 16) = 0;
		  this->fields.lift = (Vector4Parameter *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.lift, v4, v6, v7, v18);
		  v9 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v9
		    || (*(__m128i *)(v9 + 24) = si128,
		        *(_BYTE *)(v9 + 16) = 0,
		        this->fields.gamma = (Vector4Parameter *)v9,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.gamma, v4, v10, v11, v19),
		        (v12 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter)) == 0) )
		  {
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  *(__m128i *)(v12 + 24) = si128;
		  *(_BYTE *)(v12 + 16) = 0;
		  this->fields.gain = (Vector4Parameter *)v12;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.gain, v4, v13, v14, v20);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		  this->fields._._displayName_k__BackingField = (String *)"Lift, Gamma, Gain";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._._displayName_k__BackingField, v15, v16, v17, v21);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6D8B4-0x0000000189B6D954
		// Boolean IsActive()
		bool HG::Rendering::Runtime::LiftGammaGain::IsActive(LiftGammaGain *this, MethodInfo *method)
		{
		  __m128i si128; // xmm6
		  Vector4Parameter *lift; // rcx
		  Vector4Parameter *gamma; // rcx
		  Vector4Parameter *gain; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __m128i v11; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2703, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2703, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		    lift = this->fields.lift;
		    v11 = si128;
		    if ( (unsigned __int8)sub_1808AEDA8(lift, &v11) )
		      return 1;
		    gamma = this->fields.gamma;
		    v11 = si128;
		    if ( (unsigned __int8)sub_1808AEDA8(gamma, &v11) )
		    {
		      return 1;
		    }
		    else
		    {
		      gain = this->fields.gain;
		      v11 = si128;
		      return sub_1808AEDA8(gain, &v11);
		    }
		  }
		}
		
	}
}
