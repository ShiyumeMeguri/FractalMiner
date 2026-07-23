using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGFoliageOccluderRenderParams // TypeDefIndex: 37982
	{
		// Fields
		public bool shouldRender; // 0x10
		public bool curMaskIsA; // 0x11
		public float lodFadeValue; // 0x14
		public Matrix4x4 cullingMatrix; // 0x18
	
		// Properties
		public static HGFoliageOccluderRenderParams defaultParams { get => default; } // 0x0000000182ED8C00-0x0000000182ED8C70 
		// HGFoliageOccluderRenderParams get_defaultParams()
		HGFoliageOccluderRenderParams *HG::Rendering::Runtime::HGFoliageOccluderRenderParams::get_defaultParams(
		        MethodInfo *method)
		{
		  HGFoliageOccluderRenderParams *result; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Matrix4x4__StaticFields *static_fields; // rdx
		  __int128 v5; // xmm1
		  __int128 v6; // xmm2
		  __int128 v7; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2619, 0LL) )
		  {
		    result = (HGFoliageOccluderRenderParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderRenderParams);
		    if ( result )
		    {
		      *(_WORD *)&result->fields.shouldRender = 256;
		      result->fields.lodFadeValue = 0.0;
		      static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v5 = *(_OWORD *)&static_fields->zeroMatrix.m01;
		      v6 = *(_OWORD *)&static_fields->zeroMatrix.m02;
		      v7 = *(_OWORD *)&static_fields->zeroMatrix.m03;
		      *(_OWORD *)&result->fields.cullingMatrix.m00 = *(_OWORD *)&static_fields->zeroMatrix.m00;
		      *(_OWORD *)&result->fields.cullingMatrix.m01 = v5;
		      *(_OWORD *)&result->fields.cullingMatrix.m02 = v6;
		      *(_OWORD *)&result->fields.cullingMatrix.m03 = v7;
		      return result;
		    }
		LABEL_4:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2619, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_965(Patch, 0LL);
		}
		
	
		// Constructors
		public HGFoliageOccluderRenderParams() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	}
}
