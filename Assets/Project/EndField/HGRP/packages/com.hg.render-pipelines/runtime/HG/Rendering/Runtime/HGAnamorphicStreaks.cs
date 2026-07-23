using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGAnamorphicStreaks", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class HGAnamorphicStreaks : VolumeComponent // TypeDefIndex: 38001
	{
		// Fields
		public BoolParameter enable; // 0x30
		public ClampedFloatParameter bloomScale; // 0x38
		public MinFloatParameter bloomThreshold; // 0x40
		public ClampedFloatParameter bloomMaxBrightness; // 0x48
		public ColorParameter bloomTint; // 0x50
		public ClampedFloatParameter blurIntensity; // 0x58
		public ClampedFloatParameter blurDirAngle; // 0x60
	
		// Constructors
		public HGAnamorphicStreaks() {} // 0x0000000184599420-0x00000001845996A0
		// HGAnamorphicStreaks()
		void HG::Rendering::Runtime::HGAnamorphicStreaks::HGAnamorphicStreaks(HGAnamorphicStreaks *this, MethodInfo *method)
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
		  __int64 v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  MethodInfo *v17; // rdx
		  __int64 v18; // rax
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Vector4 v21; // xmm0
		  __int64 v22; // rax
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  Vector4 v28; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_9;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 1;
		  this->fields.enable = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.enable, v4, v6, v7, *(MethodInfo **)&v28.x);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_9;
		  *(_DWORD *)(v8 + 24) = 1065353216;
		  *(_BYTE *)(v8 + 16) = 1;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1092616192;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.bloomScale = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bloomScale, v4, v9, v10, *(MethodInfo **)&v28.x);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v11 )
		    goto LABEL_9;
		  *(_DWORD *)(v11 + 24) = 1082130432;
		  *(_BYTE *)(v11 + 16) = 1;
		  *(_DWORD *)(v11 + 32) = 0;
		  this->fields.bloomThreshold = (MinFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bloomThreshold, v4, v12, v13, *(MethodInfo **)&v28.x);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_9;
		  *(_DWORD *)(v14 + 24) = 1120403456;
		  *(_BYTE *)(v14 + 16) = 1;
		  *(_DWORD *)(v14 + 32) = 0;
		  *(_DWORD *)(v14 + 36) = 1120403456;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.bloomMaxBrightness = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bloomMaxBrightness, v4, v15, v16, *(MethodInfo **)&v28.x);
		  v28 = *UnityEngine::Vector4::get_one(&v28, v17);
		  v18 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v18 )
		    goto LABEL_9;
		  v21 = v28;
		  *(_WORD *)(v18 + 40) = 1;
		  *(_BYTE *)(v18 + 42) = 1;
		  *(Vector4 *)(v18 + 24) = v21;
		  *(_BYTE *)(v18 + 16) = 1;
		  this->fields.bloomTint = (ColorParameter *)v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bloomTint, v4, v19, v20, *(MethodInfo **)&v28.x);
		  v22 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v22 )
		    goto LABEL_9;
		  *(_DWORD *)(v22 + 24) = 1060320051;
		  *(_BYTE *)(v22 + 16) = 1;
		  *(_DWORD *)(v22 + 32) = 0;
		  *(_DWORD *)(v22 + 36) = 1065353216;
		  *(_DWORD *)(v22 + 40) = 1065353216;
		  this->fields.blurIntensity = (ClampedFloatParameter *)v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blurIntensity, v4, v23, v24, *(MethodInfo **)&v28.x);
		  v25 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v25 )
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v25 + 24) = 0;
		  *(_BYTE *)(v25 + 16) = 1;
		  *(_DWORD *)(v25 + 32) = 0;
		  *(_DWORD *)(v25 + 36) = 1127481344;
		  *(_DWORD *)(v25 + 40) = 1065353216;
		  this->fields.blurDirAngle = (ClampedFloatParameter *)v25;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blurDirAngle, v4, v26, v27, *(MethodInfo **)&v28.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6928C-0x0000000189B692E8
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGAnamorphicStreaks::IsActive(HGAnamorphicStreaks *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  BoolParameter *enable; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2663, 0LL) )
		  {
		    enable = this->fields.enable;
		    if ( enable )
		      return sub_180006280(10LL, enable);
		LABEL_5:
		    sub_1800D8260(v3, enable);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2663, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
