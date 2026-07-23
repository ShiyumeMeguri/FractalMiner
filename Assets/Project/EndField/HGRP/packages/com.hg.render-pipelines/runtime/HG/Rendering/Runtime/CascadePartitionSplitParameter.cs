using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class CascadePartitionSplitParameter : VolumeParameter<float> // TypeDefIndex: 37890
	{
		// Fields
		[NonSerialized]
		private NoInterpMinFloatParameter maxDistance; // 0x20
		internal bool normalized; // 0x28
		[NonSerialized]
		private CascadePartitionSplitParameter previous; // 0x30
		[NonSerialized]
		private CascadePartitionSplitParameter next; // 0x38
		[NonSerialized]
		private NoInterpClampedIntParameter cascadeCounts; // 0x40
		private int minCascadeToAppears; // 0x48
	
		// Properties
		internal float min { get => default; } // 0x0000000189B42DAC-0x0000000189B42E10 
		// Single get_min()
		float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_min(
		        CascadePartitionSplitParameter *this,
		        MethodInfo *method)
		{
		  CascadePartitionSplitParameter *previous; // rdx
		  double v4; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2222, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2222, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *(float *)&v4 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                      (ILFixDynamicMethodWrapper_15 *)Patch,
		                      (Object *)this,
		                      0LL);
		  }
		  else
		  {
		    previous = this->fields.previous;
		    if ( previous )
		      v4 = sub_1800057D0(10LL, previous);
		    else
		      LODWORD(v4) = 0;
		  }
		  return *(float *)&v4;
		}
		
		internal float max { get => default; } // 0x0000000189B42D28-0x0000000189B42DAC 
		// Single get_max()
		float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_max(
		        CascadePartitionSplitParameter *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  NoInterpClampedIntParameter *cascadeCounts; // rdx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2223, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2223, 0LL);
		    if ( Patch )
		    {
		      *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                        (ILFixDynamicMethodWrapper_15 *)Patch,
		                        (Object *)this,
		                        0LL);
		      return *(float *)&v5;
		    }
		LABEL_8:
		    sub_1800D8260(v3, cascadeCounts);
		  }
		  cascadeCounts = this->fields.cascadeCounts;
		  if ( !cascadeCounts )
		    goto LABEL_8;
		  if ( (int)sub_180002F70(10LL, cascadeCounts) > this->fields.minCascadeToAppears && this->fields.next )
		    v5 = sub_1800057D0(10LL, this->fields.next);
		  else
		    LODWORD(v5) = 1065353216;
		  return *(float *)&v5;
		}
		
		internal float representationDistance { get => default; } // 0x0000000189B42E10-0x0000000189B42E6C 
		// Single get_representationDistance()
		float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_representationDistance(
		        CascadePartitionSplitParameter *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  NoInterpMinFloatParameter *maxDistance; // rdx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2224, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2224, 0LL);
		    if ( Patch )
		    {
		      *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                        (ILFixDynamicMethodWrapper_15 *)Patch,
		                        (Object *)this,
		                        0LL);
		      return *(float *)&v5;
		    }
		LABEL_5:
		    sub_1800D8260(v3, maxDistance);
		  }
		  maxDistance = this->fields.maxDistance;
		  if ( !maxDistance )
		    goto LABEL_5;
		  v5 = sub_1800057D0(10LL, maxDistance);
		  return *(float *)&v5;
		}
		
		public override float value { get => default; set {} } // 0x0000000189B42E6C-0x0000000189B42EBC 0x0000000189B42EBC-0x0000000189B42F48
		// Single get_value()
		float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_value(
		        CascadePartitionSplitParameter *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2225, 0LL) )
		    return this->fields._.m_Value;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2225, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_value(Single)
		void HG::Rendering::Runtime::CascadePartitionSplitParameter::set_value(
		        CascadePartitionSplitParameter *this,
		        float value,
		        MethodInfo *method)
		{
		  float v4; // xmm6_4
		  float min; // xmm7_4
		  float max; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  v4 = value;
		  if ( IFix::WrappersManagerImpl::IsPatched(2226, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2226, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    min = HG::Rendering::Runtime::CascadePartitionSplitParameter::get_min(this, 0LL);
		    max = HG::Rendering::Runtime::CascadePartitionSplitParameter::get_max(this, 0LL);
		    if ( min > value )
		    {
		      v4 = min;
		    }
		    else if ( value > max )
		    {
		      v4 = max;
		    }
		    this->fields._.m_Value = v4;
		  }
		}
		
	
		// Constructors
		public CascadePartitionSplitParameter() {} // Dummy constructor
		public CascadePartitionSplitParameter(float value, bool normalized = false /* Metadata: 0x023031A6 */, bool overrideState = false /* Metadata: 0x023031A7 */) {} // 0x0000000184DA1380-0x0000000184DA1390
		// CascadePartitionSplitParameter(Single, Boolean, Boolean)
		void HG::Rendering::Runtime::CascadePartitionSplitParameter::CascadePartitionSplitParameter(
		        CascadePartitionSplitParameter *this,
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
		internal void Init(NoInterpClampedIntParameter cascadeCounts, int minCascadeToAppears, NoInterpMinFloatParameter maxDistance, CascadePartitionSplitParameter previous, CascadePartitionSplitParameter next) {} // 0x0000000189B42C58-0x0000000189B42D28
		// Void Init(NoInterpClampedIntParameter, Int32, NoInterpMinFloatParameter, CascadePartitionSplitParameter, CascadePartitionSplitParameter)
		void HG::Rendering::Runtime::CascadePartitionSplitParameter::Init(
		        CascadePartitionSplitParameter *this,
		        NoInterpClampedIntParameter *cascadeCounts,
		        int32_t minCascadeToAppears,
		        NoInterpMinFloatParameter *maxDistance,
		        CascadePartitionSplitParameter *previous,
		        CascadePartitionSplitParameter *next,
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
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2227, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2227, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v21);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_891(
		      Patch,
		      (Object *)this,
		      (Object *)cascadeCounts,
		      minCascadeToAppears,
		      (Object *)maxDistance,
		      (Object *)previous,
		      (Object *)next,
		      0LL);
		  }
		  else
		  {
		    this->fields.maxDistance = maxDistance;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.maxDistance, v11, v12, v13, P3);
		    this->fields.previous = previous;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.previous, v14, v15, (Int32__Array **)previous, P3a);
		    this->fields.next = next;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.next, v16, v17, (Int32__Array **)next, P3b);
		    this->fields.cascadeCounts = cascadeCounts;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.cascadeCounts, v18, v19, v20, P3c);
		    this->fields.minCascadeToAppears = minCascadeToAppears;
		  }
		}
		
	}
}
