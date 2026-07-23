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
	[VolumeComponentMenuForRenderPipeline("Post-processing/Split Toning", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class SplitToning : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38062
	{
		// Fields
		[Tooltip("Specifies the color to use for shadows.")]
		public ColorParameter shadows; // 0x30
		[Tooltip("Specifies the color to use for highlights.")]
		public ColorParameter highlights; // 0x38
		[Tooltip("Controls the balance between the colors in the highlights and shadows.")]
		public ClampedFloatParameter balance; // 0x40
	
		// Constructors
		public SplitToning() {} // 0x00000001845FCEF0-0x00000001845FCFE0
		// SplitToning()
		void HG::Rendering::Runtime::SplitToning::SplitToning(SplitToning *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  Color v8; // xmm0
		  MethodInfo *v9; // rdx
		  __int64 v10; // rax
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Color v13; // xmm0
		  __int64 v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  Color v17; // [rsp+20h] [rbp-18h] BYREF
		
		  v17 = *UnityEngine::Color::get_grey(&v17, method);
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v3 )
		    goto LABEL_5;
		  v8 = v17;
		  *(_WORD *)(v3 + 40) = 0;
		  *(_BYTE *)(v3 + 42) = 1;
		  *(Color *)(v3 + 24) = v8;
		  *(_BYTE *)(v3 + 16) = 0;
		  this->fields.shadows = (ColorParameter *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadows, v4, v6, v7, *(MethodInfo **)&v17.r);
		  v17 = *UnityEngine::Color::get_grey(&v17, v9);
		  v10 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v10 )
		    goto LABEL_5;
		  v13 = v17;
		  *(_WORD *)(v10 + 40) = 0;
		  *(_BYTE *)(v10 + 42) = 1;
		  *(Color *)(v10 + 24) = v13;
		  *(_BYTE *)(v10 + 16) = 0;
		  this->fields.highlights = (ColorParameter *)v10;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlights, v4, v11, v12, *(MethodInfo **)&v17.r);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v14 + 24) = 0;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = -1027080192;
		  *(_DWORD *)(v14 + 36) = 1120403456;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.balance = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.balance, v4, v15, v16, *(MethodInfo **)&v17.r);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6DDD8-0x0000000189B6DE70
		// Boolean IsActive()
		bool HG::Rendering::Runtime::SplitToning::IsActive(SplitToning *this, MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  Color *grey; // rax
		  ColorParameter *shadows; // rcx
		  MethodInfo *v6; // rdx
		  Color *v8; // rax
		  ColorParameter *highlights; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Color v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2706, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2706, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    grey = UnityEngine::Color::get_grey(&v13, v3);
		    shadows = this->fields.shadows;
		    v13 = *grey;
		    if ( (unsigned __int8)sub_1808AEDCC(shadows, &v13) )
		    {
		      return 1;
		    }
		    else
		    {
		      v8 = UnityEngine::Color::get_grey(&v13, v6);
		      highlights = this->fields.highlights;
		      v13 = *v8;
		      return sub_1808AEDCC(highlights, &v13);
		    }
		  }
		}
		
	}
}
