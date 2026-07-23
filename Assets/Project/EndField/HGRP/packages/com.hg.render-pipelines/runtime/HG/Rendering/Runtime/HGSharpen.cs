using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGSharpen", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGSharpen : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38048
	{
		// Fields
		public HGSharpenModeParameter sharpenMode; // 0x30
		public ClampedFloatParameter sharpenIntensity; // 0x38
		public FloatParameter sharpenRange; // 0x40
		public ClampedFloatParameter sharpenThreshold; // 0x48
	
		// Constructors
		public HGSharpen() {} // 0x0000000184667ED0-0x0000000184667FC0
		// HGSharpen()
		void HG::Rendering::Runtime::HGSharpen::HGSharpen(HGSharpen *this, MethodInfo *method)
		{
		  HGSharpenModeParameter *v3; // rax
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
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		
		  v3 = (HGSharpenModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSharpenModeParameter);
		  if ( !v3 )
		    goto LABEL_6;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.sharpenMode = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.sharpenMode, v4, v6, v7, v17);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_6;
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1084227584;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.sharpenIntensity = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.sharpenIntensity, v4, v9, v10, v18);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v11
		    || (*(_DWORD *)(v11 + 24) = 1065353216,
		        *(_BYTE *)(v11 + 16) = 0,
		        this->fields.sharpenRange = (FloatParameter *)v11,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.sharpenRange, v4, v12, v13, v19),
		        (v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v14 + 24) = 0;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 0;
		  *(_DWORD *)(v14 + 36) = 1065353216;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.sharpenThreshold = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.sharpenThreshold, v4, v15, v16, v20);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000183DF2F20-0x0000000183DF2F90
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGSharpen::IsActive(HGSharpen *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  HGSharpenModeParameter *wrapperArray; // rdx
		  int v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (HGSharpenModeParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->fields._.m_Value <= 1060 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x424 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[22]._1.genericContainerHandle )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1060, 0LL);
		    if ( Patch )
		    {
		      LOBYTE(v5) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                     (ILFixDynamicMethodWrapper_20 *)Patch,
		                     (Object *)this,
		                     0LL);
		      return v5;
		    }
		    goto LABEL_9;
		  }
		LABEL_5:
		  wrapperArray = this->fields.sharpenMode;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  v5 = sub_180002F70(10LL, wrapperArray);
		  if ( v5 )
		    LOBYTE(v5) = 1;
		  return v5;
		}
		
		public bool IsTileCompatible() => default; // 0x0000000189B6D800-0x0000000189B6D84C
		// Boolean IsTileCompatible()
		bool HG::Rendering::Runtime::HGSharpen::IsTileCompatible(HGSharpen *this, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(2692, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2692, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  return result;
		}
		
	}
}
