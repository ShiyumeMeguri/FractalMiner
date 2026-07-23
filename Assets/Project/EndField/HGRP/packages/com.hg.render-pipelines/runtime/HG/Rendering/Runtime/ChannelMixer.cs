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
	[VolumeComponentMenuForRenderPipeline("Post-processing/Channel Mixer", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38006
	{
		// Fields
		[Header("Red Output Channel")]
		[InspectorName("Red")]
		[Tooltip("Controls the influence of the red channel in the output red channel.")]
		public ClampedFloatParameter redOutRedIn; // 0x30
		[InspectorName("Green")]
		[Tooltip("Controls the influence of the green channel in the output red channel.")]
		public ClampedFloatParameter redOutGreenIn; // 0x38
		[InspectorName("Blue")]
		[Tooltip("Controls the influence of the blue channel in the output red channel.")]
		public ClampedFloatParameter redOutBlueIn; // 0x40
		[Header("Green Output Channel")]
		[InspectorName("Red")]
		[Tooltip("Controls the influence of the red channel in the output green channel.")]
		public ClampedFloatParameter greenOutRedIn; // 0x48
		[InspectorName("Green")]
		[Tooltip("Controls the influence of the green channel in the output green channel.")]
		public ClampedFloatParameter greenOutGreenIn; // 0x50
		[InspectorName("Blue")]
		[Tooltip("Controls the influence of the blue channel in the output green channel.")]
		public ClampedFloatParameter greenOutBlueIn; // 0x58
		[Header("Blue Output Channel")]
		[InspectorName("Red")]
		[Tooltip("Controls the influence of the red channel in the output blue channel.")]
		public ClampedFloatParameter blueOutRedIn; // 0x60
		[InspectorName("Green")]
		[Tooltip("Controls the influence of the green channel in the output blue channel.")]
		public ClampedFloatParameter blueOutGreenIn; // 0x68
		[InspectorName("Blue")]
		[Tooltip("Controls the influence of the blue channel in the output blue channel.")]
		public ClampedFloatParameter blueOutBlueIn; // 0x70
	
		// Constructors
		public ChannelMixer() {} // 0x0000000184571C60-0x0000000184571EC0
		// ChannelMixer()
		void HG::Rendering::Runtime::ChannelMixer::ChannelMixer(ChannelMixer *this, MethodInfo *method)
		{
		  __int64 v3; // rax
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
		  __int64 v17; // rax
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  __int64 v23; // rax
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  __int64 v26; // rax
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  __int64 v29; // rax
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **v31; // r9
		  MethodInfo *v32; // [rsp+20h] [rbp-8h]
		  MethodInfo *v33; // [rsp+20h] [rbp-8h]
		  MethodInfo *v34; // [rsp+20h] [rbp-8h]
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v3 )
		    goto LABEL_11;
		  *(_DWORD *)(v3 + 24) = 1120403456;
		  *(_BYTE *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 32) = -1018691584;
		  *(_DWORD *)(v3 + 36) = 1128792064;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  this->fields.redOutRedIn = (ClampedFloatParameter *)v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.redOutRedIn, v4, v6, v7, v32);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_11;
		  *(_DWORD *)(v8 + 32) = -1018691584;
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 36) = 1128792064;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.redOutGreenIn = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.redOutGreenIn, v4, v9, v10, v33);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_11;
		  *(_DWORD *)(v11 + 24) = 0;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = -1018691584;
		  *(_DWORD *)(v11 + 36) = 1128792064;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.redOutBlueIn = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.redOutBlueIn, v4, v12, v13, v34);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_11;
		  *(_DWORD *)(v14 + 24) = 0;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = -1018691584;
		  *(_DWORD *)(v14 + 36) = 1128792064;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.greenOutRedIn = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.greenOutRedIn, v4, v15, v16, v35);
		  v17 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v17 )
		    goto LABEL_11;
		  *(_DWORD *)(v17 + 24) = 1120403456;
		  *(_BYTE *)(v17 + 16) = 0;
		  *(_DWORD *)(v17 + 32) = -1018691584;
		  *(_DWORD *)(v17 + 36) = 1128792064;
		  *(_DWORD *)(v17 + 40) = 1065353216;
		  this->fields.greenOutGreenIn = (ClampedFloatParameter *)v17;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.greenOutGreenIn, v4, v18, v19, v36);
		  v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v20 )
		    goto LABEL_11;
		  *(_DWORD *)(v20 + 24) = 0;
		  *(_BYTE *)(v20 + 16) = 0;
		  *(_DWORD *)(v20 + 32) = -1018691584;
		  *(_DWORD *)(v20 + 36) = 1128792064;
		  *(_DWORD *)(v20 + 40) = 1065353216;
		  this->fields.greenOutBlueIn = (ClampedFloatParameter *)v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.greenOutBlueIn, v4, v21, v22, v37);
		  v23 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v23 )
		    goto LABEL_11;
		  *(_DWORD *)(v23 + 24) = 0;
		  *(_BYTE *)(v23 + 16) = 0;
		  *(_DWORD *)(v23 + 32) = -1018691584;
		  *(_DWORD *)(v23 + 36) = 1128792064;
		  *(_DWORD *)(v23 + 40) = 1065353216;
		  this->fields.blueOutRedIn = (ClampedFloatParameter *)v23;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blueOutRedIn, v4, v24, v25, v38);
		  v26 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v26 )
		    goto LABEL_11;
		  *(_DWORD *)(v26 + 24) = 0;
		  *(_BYTE *)(v26 + 16) = 0;
		  *(_DWORD *)(v26 + 32) = -1018691584;
		  *(_DWORD *)(v26 + 36) = 1128792064;
		  *(_DWORD *)(v26 + 40) = 1065353216;
		  this->fields.blueOutGreenIn = (ClampedFloatParameter *)v26;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blueOutGreenIn, v4, v27, v28, v39);
		  v29 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v29 )
		LABEL_11:
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v29 + 24) = 1120403456;
		  *(_BYTE *)(v29 + 16) = 0;
		  *(_DWORD *)(v29 + 32) = -1018691584;
		  *(_DWORD *)(v29 + 36) = 1128792064;
		  *(_DWORD *)(v29 + 40) = 1065353216;
		  this->fields.blueOutBlueIn = (ClampedFloatParameter *)v29;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blueOutBlueIn, v4, v30, v31, v40);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B68394-0x0000000189B6851C
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ChannelMixer::IsActive(ChannelMixer *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  ClampedFloatParameter *redOutRedIn; // rdx
		  double v5; // xmm0_8
		  double v6; // xmm0_8
		  double v7; // xmm0_8
		  double v8; // xmm0_8
		  double v9; // xmm0_8
		  double v10; // xmm0_8
		  double v11; // xmm0_8
		  double v12; // xmm0_8
		  double v13; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2670, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2670, 0LL);
		    if ( !Patch )
		      goto LABEL_22;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    redOutRedIn = this->fields.redOutRedIn;
		    if ( !redOutRedIn )
		      goto LABEL_22;
		    v5 = sub_1800057D0(10LL, redOutRedIn);
		    if ( *(float *)&v5 == 100.0 )
		    {
		      redOutRedIn = this->fields.redOutGreenIn;
		      if ( !redOutRedIn )
		        goto LABEL_22;
		      v6 = sub_1800057D0(10LL, redOutRedIn);
		      if ( *(float *)&v6 == 0.0 )
		      {
		        redOutRedIn = this->fields.redOutBlueIn;
		        if ( !redOutRedIn )
		          goto LABEL_22;
		        v7 = sub_1800057D0(10LL, redOutRedIn);
		        if ( *(float *)&v7 == 0.0 )
		        {
		          redOutRedIn = this->fields.greenOutRedIn;
		          if ( !redOutRedIn )
		            goto LABEL_22;
		          v8 = sub_1800057D0(10LL, redOutRedIn);
		          if ( *(float *)&v8 == 0.0 )
		          {
		            redOutRedIn = this->fields.greenOutGreenIn;
		            if ( !redOutRedIn )
		              goto LABEL_22;
		            v9 = sub_1800057D0(10LL, redOutRedIn);
		            if ( *(float *)&v9 == 100.0 )
		            {
		              redOutRedIn = this->fields.greenOutBlueIn;
		              if ( !redOutRedIn )
		                goto LABEL_22;
		              v10 = sub_1800057D0(10LL, redOutRedIn);
		              if ( *(float *)&v10 == 0.0 )
		              {
		                redOutRedIn = this->fields.blueOutRedIn;
		                if ( !redOutRedIn )
		                  goto LABEL_22;
		                v11 = sub_1800057D0(10LL, redOutRedIn);
		                if ( *(float *)&v11 == 0.0 )
		                {
		                  redOutRedIn = this->fields.blueOutGreenIn;
		                  if ( !redOutRedIn )
		                    goto LABEL_22;
		                  v12 = sub_1800057D0(10LL, redOutRedIn);
		                  if ( *(float *)&v12 == 0.0 )
		                  {
		                    redOutRedIn = this->fields.blueOutBlueIn;
		                    if ( redOutRedIn )
		                    {
		                      v13 = sub_1800057D0(10LL, redOutRedIn);
		                      return *(float *)&v13 != 100.0;
		                    }
		LABEL_22:
		                    sub_1800D8260(v3, redOutRedIn);
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		    return 1;
		  }
		}
		
	}
}
