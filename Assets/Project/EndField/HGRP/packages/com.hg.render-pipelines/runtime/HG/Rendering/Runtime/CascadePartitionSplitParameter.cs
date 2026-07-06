using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class CascadePartitionSplitParameter : VolumeParameter<float>
	{
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float min
		{
			get
			{
				// // Single get_min()
				// float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_min(
				//         CascadePartitionSplitParameter *this,
				//         MethodInfo *method)
				// {
				//   CascadePartitionSplitParameter *previous; // rdx
				// 
				//   previous = this.fields.previous;
				//   if ( previous )
				//     return sub_18003F9B0(10LL, previous);
				//   else
				//     return 0.0;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float max
		{
			get
			{
				// // Single get_max()
				// float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_max(
				//         CascadePartitionSplitParameter *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				//   NoInterpClampedIntParameter *cascadeCounts; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1876, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1876, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				// LABEL_8:
				//     sub_180B536AC(v3, cascadeCounts);
				//   }
				//   cascadeCounts = this.fields.cascadeCounts;
				//   if ( !cascadeCounts )
				//     goto LABEL_8;
				//   if ( (int)sub_18003ED00(10LL) > this.fields.minCascadeToAppears && this.fields.next )
				//     return sub_18003F9B0(10LL, this.fields.next);
				//   else
				//     return 1.0;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float representationDistance
		{
			get
			{
				// // Single get_representationDistance()
				// float HG::Rendering::Runtime::CascadePartitionSplitParameter::get_representationDistance(
				//         CascadePartitionSplitParameter *this,
				//         MethodInfo *method)
				// {
				//   NoInterpMinFloatParameter *maxDistance; // rdx
				// 
				//   maxDistance = this.fields.maxDistance;
				//   if ( !maxDistance )
				//     sub_180B536AC(this, 0LL);
				//   return sub_18003F9B0(10LL, maxDistance);
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x000025D0 File Offset: 0x000007D0
		public override float value
		{
			get
			{
				// // Single omZbIWJIrldcSvYlXrKUFlzMuTURA()
				// float iLhuYWDbmVJbwzFrmgpHjHIbandoA<System::Object>::omZbIWJIrldcSvYlXrKUFlzMuTURA(
				//         iLhuYWDbmVJbwzFrmgpHjHIbandoA_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NfxnViHTtvNRHOZQvFrczEXLFcPT;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_value(Single)
				// void HG::Rendering::Runtime::CascadePartitionSplitParameter::set_value(
				//         CascadePartitionSplitParameter *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   float min; // xmm7_4
				//   float max; // xmm0_4
				// 
				//   min = HG::Rendering::Runtime::CascadePartitionSplitParameter::get_min(this, 0LL);
				//   max = HG::Rendering::Runtime::CascadePartitionSplitParameter::get_max(this, 0LL);
				//   if ( min > value )
				//   {
				//     this.fields._.m_Value = min;
				//   }
				//   else if ( value <= max )
				//   {
				//     this.fields._.m_Value = value;
				//   }
				//   else
				//   {
				//     this.fields._.m_Value = max;
				//   }
				// }
				// 
			}
		}

		public CascadePartitionSplitParameter(float value, [MetadataOffset(Offset = "0x01F90E52")] bool normalized = false, [MetadataOffset(Offset = "0x01F90E53")] bool overrideState = false)
		{
			// // CascadePartitionSplitParameter(Single, Boolean, Boolean)
			// void HG::Rendering::Runtime::CascadePartitionSplitParameter::CascadePartitionSplitParameter(
			//         CascadePartitionSplitParameter *this,
			//         float value,
			//         bool normalized,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D919EBC )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::VolumeParameter);
			//     byte_18D919EBC = 1;
			//   }
			//   this.fields._.m_Value = value;
			//   this.fields.normalized = normalized;
			//   this.fields._._.overrideState = overrideState;
			// }
			// 
		}

		internal void Init(NoInterpClampedIntParameter cascadeCounts, int minCascadeToAppears, NoInterpMinFloatParameter maxDistance, CascadePartitionSplitParameter previous, CascadePartitionSplitParameter next)
		{
			// // Void Init(NoInterpClampedIntParameter, Int32, NoInterpMinFloatParameter, CascadePartitionSplitParameter, CascadePartitionSplitParameter)
			// void HG::Rendering::Runtime::CascadePartitionSplitParameter::Init(
			//         CascadePartitionSplitParameter *this,
			//         NoInterpClampedIntParameter *cascadeCounts,
			//         int32_t minCascadeToAppears,
			//         NoInterpMinFloatParameter *maxDistance,
			//         CascadePartitionSplitParameter *previous,
			//         CascadePartitionSplitParameter *next,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   __int64 v21; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Object *P3; // [rsp+20h] [rbp-28h]
			//   Object *P3a; // [rsp+20h] [rbp-28h]
			//   Object *P3b; // [rsp+20h] [rbp-28h]
			//   Object *P3c; // [rsp+20h] [rbp-28h]
			//   Object *P4; // [rsp+28h] [rbp-20h]
			//   Object *P4a; // [rsp+28h] [rbp-20h]
			//   Object *P4b; // [rsp+28h] [rbp-20h]
			//   Object *P4c; // [rsp+28h] [rbp-20h]
			//   MethodInfo *P5; // [rsp+30h] [rbp-18h]
			//   MethodInfo *P5a; // [rsp+30h] [rbp-18h]
			//   MethodInfo *P5b; // [rsp+30h] [rbp-18h]
			//   MethodInfo *P5c; // [rsp+30h] [rbp-18h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1877, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1877, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v21);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_727(
			//       Patch,
			//       (Object *)this,
			//       (Object *)cascadeCounts,
			//       minCascadeToAppears,
			//       (Object *)maxDistance,
			//       (Object *)previous,
			//       (Object *)next,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.maxDistance = maxDistance;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.maxDistance, v11, v12, v13, (String__Array *)P3, (String *)P4, P5);
			//     this.fields.previous = previous;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.previous,
			//       v14,
			//       v15,
			//       (MessageDescriptor *)previous,
			//       (String__Array *)P3a,
			//       (String *)P4a,
			//       P5a);
			//     this.fields.next = next;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.next,
			//       v16,
			//       v17,
			//       (MessageDescriptor *)next,
			//       (String__Array *)P3b,
			//       (String *)P4b,
			//       P5b);
			//     this.fields.cascadeCounts = cascadeCounts;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.cascadeCounts,
			//       v18,
			//       v19,
			//       v20,
			//       (String__Array *)P3c,
			//       (String *)P4c,
			//       P5c);
			//     this.fields.minCascadeToAppears = minCascadeToAppears;
			//   }
			// }
			// 
		}

		[NonSerialized]
		private NoInterpMinFloatParameter maxDistance;

		internal bool normalized;

		[NonSerialized]
		private CascadePartitionSplitParameter previous;

		[NonSerialized]
		private CascadePartitionSplitParameter next;

		[NonSerialized]
		private NoInterpClampedIntParameter cascadeCounts;

		private int minCascadeToAppears;
	}
}
