using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/ChromaticAbberation", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGChromaticAbberation : VolumeComponent // TypeDefIndex: 38035
	{
		// Fields
		public BoolParameter enabled; // 0x30
		public Vector2Parameter center; // 0x38
		public ClampedFloatParameter intensity; // 0x40
		public BoolParameter averageStep; // 0x48
		public BoolParameter enableGlobalCenter; // 0x50
		public Vector3Parameter globalCenter; // 0x58
	
		// Constructors
		public HGChromaticAbberation() {} // 0x0000000184415F50-0x00000001844160C0
		// HGChromaticAbberation()
		void HG::Rendering::Runtime::HGChromaticAbberation::HGChromaticAbberation(
		        HGChromaticAbberation *this,
		        MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  BoolParameter *v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  BoolParameter *v17; // rax
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rdi
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_10;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enabled = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.enabled, v4, v6, v7, v23);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v8 )
		    goto LABEL_10;
		  *(_DWORD *)(v8 + 24) = 1056964608;
		  *(_DWORD *)(v8 + 28) = 1056964608;
		  *(_BYTE *)(v8 + 16) = 0;
		  this->fields.center = (Vector2Parameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.center, v4, v9, v10, v24);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_10;
		  *(_DWORD *)(v11 + 24) = 1036831949;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 36) = 1050253722;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.intensity = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.intensity, v4, v12, v13, v25);
		  v14 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v14 )
		    goto LABEL_10;
		  v14->fields._.m_Value = 0;
		  v14->fields._._.overrideState = 0;
		  this->fields.averageStep = v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.averageStep, v4, v15, v16, v26);
		  v17 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v17
		    || (v17->fields._.m_Value = 0,
		        v17->fields._._.overrideState = 0,
		        this->fields.enableGlobalCenter = v17,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.enableGlobalCenter, v4, v18, v19, v27),
		        (v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector3Parameter)) == 0) )
		  {
		LABEL_10:
		    sub_1800D8260(v5, v4);
		  }
		  if ( !byte_18F36E4F5 )
		  {
		    sub_180035ED0(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector3>::VolumeParameter);
		    byte_18F36E4F5 = 1;
		  }
		  *(_BYTE *)(v20 + 16) = 0;
		  *(_QWORD *)(v20 + 24) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v20 + 32) = 0;
		  this->fields.globalCenter = (Vector3Parameter *)v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.globalCenter, v4, v21, v22, v28);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B69A78-0x0000000189B69AFC
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGChromaticAbberation::IsActive(HGChromaticAbberation *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  void *enabled; // rdx
		  bool result; // al
		  double v6; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2681, 0LL) )
		  {
		    enabled = this->fields.enabled;
		    if ( enabled )
		    {
		      result = sub_180006280(10LL, enabled);
		      if ( !result )
		        return result;
		      enabled = this->fields.intensity;
		      if ( enabled )
		      {
		        v6 = sub_1800057D0(10LL, enabled);
		        return *(float *)&v6 > 0.0;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v3, enabled);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2681, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
