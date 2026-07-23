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
	[VolumeComponentMenuForRenderPipeline("Post-processing/White Balance", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38068
	{
		// Fields
		[Tooltip("Controls the color temperature HGRP uses for white balancing.")]
		public ClampedFloatParameter temperature; // 0x30
		[Tooltip("Controls the white balance color to compensate for a green or magenta tint.")]
		public ClampedFloatParameter tint; // 0x38
	
		// Constructors
		public WhiteBalance() {} // 0x000000018481D520-0x000000018481D5C0
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6E324-0x0000000189B6E444
		// Boolean IsActive()
		bool HG::Rendering::Runtime::WhiteBalance::IsActive(WhiteBalance *this, MethodInfo *method)
		{
		  Mathf__StaticFields *static_fields; // rcx
		  ClampedFloatParameter *temperature; // rdx
		  double v5; // xmm0_8
		  __int32 v6; // xmm7_4
		  double v8; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2710, 0LL) )
		  {
		    temperature = this->fields.temperature;
		    if ( temperature )
		    {
		      v5 = sub_1800057D0(10LL, temperature);
		      COERCE_FLOAT(v6 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		      static_fields = TypeInfo::UnityEngine::Mathf->static_fields;
		      if ( fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v5) & v6), 0.0) * 0.000001, static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - *(float *)&v5) & v6) )
		        return 1;
		      temperature = this->fields.tint;
		      if ( temperature )
		      {
		        v8 = sub_1800057D0(10LL, temperature);
		        return fmaxf(
		                 fmaxf(COERCE_FLOAT(LODWORD(v8) & v6), 0.0) * 0.000001,
		                 TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(0.0 - *(float *)&v8) & v6);
		      }
		    }
		LABEL_8:
		    sub_1800D8260(static_fields, temperature);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2710, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
