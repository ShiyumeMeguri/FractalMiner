using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/FrostedGlass", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class FrostedGlass : VolumeComponent // TypeDefIndex: 38011
	{
		// Fields
		public ClampedFloatParameter colorThreshold; // 0x30
		public ClampedFloatParameter downsampleScale; // 0x38
		public ClampedIntParameter downsampleNum; // 0x40
	
		// Constructors
		public FrostedGlass() {} // 0x0000000184405820-0x0000000184405910
		// FrostedGlass()
		void HG::Rendering::Runtime::FrostedGlass::FrostedGlass(FrostedGlass *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  IntParameter *v11; // rax
		  ClampedIntParameter *v12; // rdi
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v3 )
		    goto LABEL_5;
		  *(_DWORD *)(v3 + 24) = 1075838976;
		  *(_BYTE *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 32) = 1056964608;
		  *(_DWORD *)(v3 + 36) = 1084227584;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  this->fields.colorThreshold = (ClampedFloatParameter *)v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.colorThreshold, v4, v6, v7, v16);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_5;
		  *(_DWORD *)(v8 + 24) = 1048576000;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 1031798784;
		  *(_DWORD *)(v8 + 36) = 1048576000;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.downsampleScale = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.downsampleScale, v4, v9, v10, v17);
		  v11 = (IntParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
		  v12 = (ClampedIntParameter *)v11;
		  if ( !v11 )
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  UnityEngine::Rendering::IntParameter::IntParameter(v11, 3, 0, 0LL);
		  v12->fields.min = 1;
		  v12->fields.max = 4;
		  this->fields.downsampleNum = v12;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.downsampleNum, v13, v14, v15, v18);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B691C0-0x0000000189B6920C
		// Boolean IsActive()
		bool HG::Rendering::Runtime::FrostedGlass::IsActive(FrostedGlass *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2676, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2676, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
