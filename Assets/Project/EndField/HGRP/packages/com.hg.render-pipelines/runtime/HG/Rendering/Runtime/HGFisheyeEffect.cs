using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/FisheyeEffect", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGFisheyeEffect : VolumeComponent // TypeDefIndex: 38043
	{
		// Fields
		public BoolParameter enabled; // 0x30
		public ClampedFloatParameter distortion; // 0x38
	
		// Constructors
		public HGFisheyeEffect() {} // 0x000000018484AF80-0x000000018484B000
		// HGFisheyeEffect()
		void HG::Rendering::Runtime::HGFisheyeEffect::HGFisheyeEffect(HGFisheyeEffect *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3
		    || (v3->fields._.m_Value = 0,
		        v3->fields._._.overrideState = 0,
		        this->fields.enabled = v3,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.enabled, v4, v6, v7, v11),
		        (v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v8 + 36) = 1056964608;
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.distortion = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.distortion, v4, v9, v10, v12);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6B1E4-0x0000000189B6B240
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGFisheyeEffect::IsActive(HGFisheyeEffect *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  BoolParameter *enabled; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2690, 0LL) )
		  {
		    enabled = this->fields.enabled;
		    if ( enabled )
		      return sub_180006280(10LL, enabled);
		LABEL_5:
		    sub_1800D8260(v3, enabled);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2690, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
