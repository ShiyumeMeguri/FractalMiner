using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGDirtyLens", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGDirtyLens : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38042
	{
		// Fields
		[Tooltip("Controls the tex of the dirty lens effect.")]
		public Texture2DParameter dirtyTex; // 0x30
		[Tooltip("Controls the strength of the dirty lens effect.")]
		public ClampedFloatParameter intensity; // 0x38
	
		// Constructors
		public HGDirtyLens() {} // 0x000000018402BC80-0x000000018402BD10
		// HGDirtyLens()
		void HG::Rendering::Runtime::HGDirtyLens::HGDirtyLens(HGDirtyLens *this, MethodInfo *method)
		{
		  Texture2DParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  Texture2DParameter *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 v10; // rax
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  v3 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v6 = v3;
		  if ( !v3
		    || (UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v3, 0LL, 0, 0LL),
		        this->fields.dirtyTex = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.dirtyTex, v7, v8, v9, v13),
		        (v10 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v10 + 36) = 1065353216;
		  *(_DWORD *)(v10 + 24) = 0;
		  *(_BYTE *)(v10 + 16) = 0;
		  *(_DWORD *)(v10 + 32) = 0;
		  *(_DWORD *)(v10 + 40) = 1065353216;
		  this->fields.intensity = (ClampedFloatParameter *)v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.intensity, v4, v11, v12, v14);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6B17C-0x0000000189B6B1E4
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGDirtyLens::IsActive(HGDirtyLens *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  ClampedFloatParameter *intensity; // rdx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2689, 0LL) )
		  {
		    intensity = this->fields.intensity;
		    if ( intensity )
		    {
		      v5 = sub_1800057D0(10LL, intensity);
		      return *(float *)&v5 > 0.0;
		    }
		LABEL_5:
		    sub_1800D8260(v3, intensity);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2689, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
