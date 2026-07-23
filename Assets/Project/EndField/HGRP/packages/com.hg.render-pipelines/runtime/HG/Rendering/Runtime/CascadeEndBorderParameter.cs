using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class CascadeEndBorderParameter : VolumeParameter<float> // TypeDefIndex: 37891
	{
		// Fields
		internal bool normalized; // 0x20
		[NonSerialized]
		private CascadePartitionSplitParameter min; // 0x28
		[NonSerialized]
		private CascadePartitionSplitParameter max; // 0x30
		[NonSerialized]
		private NoInterpMinFloatParameter maxDistance; // 0x38
		[NonSerialized]
		private NoInterpClampedIntParameter cascadeCounts; // 0x40
		private int minCascadeToAppears; // 0x48
	
		// Properties
		internal float representationDistance { get => default; } // 0x0000000189B42AD8-0x0000000189B42BA4 
		// Single get_representationDistance()
		float HG::Rendering::Runtime::CascadeEndBorderParameter::get_representationDistance(
		        CascadeEndBorderParameter *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  void *cascadeCounts; // rdx
		  double v5; // xmm0_8
		  float v6; // xmm6_4
		  CascadePartitionSplitParameter *min; // rdx
		  double v8; // xmm0_8
		  float v9; // xmm7_4
		  double v10; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2228, 0LL) )
		  {
		    cascadeCounts = this->fields.cascadeCounts;
		    if ( cascadeCounts )
		    {
		      if ( (int)sub_180002F70(10LL, cascadeCounts) > this->fields.minCascadeToAppears && this->fields.max )
		      {
		        v5 = sub_1800057D0(10LL, this->fields.max);
		        v6 = *(float *)&v5;
		      }
		      else
		      {
		        v6 = 1.0;
		      }
		      min = this->fields.min;
		      if ( min )
		      {
		        v8 = sub_1800057D0(10LL, min);
		        v9 = *(float *)&v8;
		      }
		      else
		      {
		        v9 = 0.0;
		      }
		      cascadeCounts = this->fields.maxDistance;
		      if ( cascadeCounts )
		      {
		        v10 = sub_1800057D0(10LL, cascadeCounts);
		        return *(float *)&v10 * (float)(v6 - v9);
		      }
		    }
		LABEL_13:
		    sub_1800D8260(v3, cascadeCounts);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2228, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		public override float value { get => default; set {} } // 0x0000000189B42BA4-0x0000000189B42BF4 0x0000000189B42BF4-0x0000000189B42C58
		// Single get_value()
		float HG::Rendering::Runtime::CascadeEndBorderParameter::get_value(CascadeEndBorderParameter *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2229, 0LL) )
		    return this->fields._.m_Value;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2229, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_value(Single)
		void HG::Rendering::Runtime::CascadeEndBorderParameter::set_value(
		        CascadeEndBorderParameter *this,
		        float value,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2230, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2230, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    Beyond::JobMathf::Clamp01(v4, value);
		    this->fields._.m_Value = value;
		  }
		}
		
	
		// Constructors
		public CascadeEndBorderParameter() {} // Dummy constructor
		public CascadeEndBorderParameter(float value, bool normalized = false /* Metadata: 0x023031A8 */, bool overrideState = false /* Metadata: 0x023031A9 */) {} // 0x0000000184DA1370-0x0000000184DA1380
		// CascadeEndBorderParameter(Single, Boolean, Boolean)
		void HG::Rendering::Runtime::CascadeEndBorderParameter::CascadeEndBorderParameter(
		        CascadeEndBorderParameter *this,
		        float value,
		        bool normalized,
		        bool overrideState,
		        MethodInfo *method)
		{
		  this->fields._.m_Value = value;
		  this->fields._._.overrideState = overrideState;
		  this->fields.normalized = normalized;
		}
		
	
		// Methods
		internal void Init(NoInterpClampedIntParameter cascadeCounts, int minCascadeToAppears, NoInterpMinFloatParameter maxDistance, CascadePartitionSplitParameter min, CascadePartitionSplitParameter max) {} // 0x0000000189B42A08-0x0000000189B42AD8
		// Void Init(NoInterpClampedIntParameter, Int32, NoInterpMinFloatParameter, CascadePartitionSplitParameter, CascadePartitionSplitParameter)
		void HG::Rendering::Runtime::CascadeEndBorderParameter::Init(
		        CascadeEndBorderParameter *this,
		        NoInterpClampedIntParameter *cascadeCounts,
		        int32_t minCascadeToAppears,
		        NoInterpMinFloatParameter *maxDistance,
		        CascadePartitionSplitParameter *min,
		        CascadePartitionSplitParameter *max,
		        MethodInfo *method)
		{
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  __int64 v21; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  MethodInfo *P3; // [rsp+20h] [rbp-28h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-28h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-28h]
		  MethodInfo *P3c; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2231, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2231, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v21);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_891(
		      Patch,
		      (Object *)this,
		      (Object *)cascadeCounts,
		      minCascadeToAppears,
		      (Object *)maxDistance,
		      (Object *)min,
		      (Object *)max,
		      0LL);
		  }
		  else
		  {
		    this->fields.maxDistance = maxDistance;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.maxDistance, v11, v12, v13, P3);
		    this->fields.min = min;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.min, v14, v15, (Int32__Array **)min, P3a);
		    this->fields.max = max;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.max, v16, v17, (Int32__Array **)max, P3b);
		    this->fields.cascadeCounts = cascadeCounts;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.cascadeCounts, v18, v19, v20, P3c);
		    this->fields.minCascadeToAppears = minCascadeToAppears;
		  }
		}
		
	}
}
