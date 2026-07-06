using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class CascadeEndBorderParameter : VolumeParameter<float>
	{
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float representationDistance
		{
			get
			{
				// // Single get_representationDistance()
				// float HG::Rendering::Runtime::CascadeEndBorderParameter::get_representationDistance(
				//         CascadeEndBorderParameter *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				//   void *cascadeCounts; // rdx
				//   float v5; // xmm6_4
				//   CascadePartitionSplitParameter *min; // rdx
				//   float v7; // xmm7_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1878, 0LL) )
				//   {
				//     cascadeCounts = this.fields.cascadeCounts;
				//     if ( cascadeCounts )
				//     {
				//       v5 = (int)sub_18003ED00(10LL) > this.fields.minCascadeToAppears && this.fields.max
				//          ? sub_18003F9B0(10LL, this.fields.max)
				//          : 1.0;
				//       min = this.fields.min;
				//       v7 = min ? sub_18003F9B0(10LL, min) : 0.0;
				//       cascadeCounts = this.fields.maxDistance;
				//       if ( cascadeCounts )
				//         return sub_18003F9B0(10LL, cascadeCounts) * (float)(v5 - v7);
				//     }
				// LABEL_13:
				//     sub_180B536AC(v3, cascadeCounts);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1878, 0LL);
				//   if ( !Patch )
				//     goto LABEL_13;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000025D0 File Offset: 0x000007D0
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
				// // Void set_weight(Single)
				// void UnityEngine::Animations::Rigging::RigConstraint<UnityEngine::Animations::Rigging::TwoBoneIKConstraintJob,UnityEngine::Animations::Rigging::TwoBoneIKConstraintData,System::Object>::set_weight(
				//         RigConstraint_3_TwoBoneIKConstraintJob_TwoBoneIKConstraintData_System_Object_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				// 
				//   Beyond::JobMathf::Clamp01((Beyond::JobMathf *)this);
				//   *(float *)(v3 + 24) = value;
				// }
				// 
			}
		}

		public CascadeEndBorderParameter(float value, [MetadataOffset(Offset = "0x01F90E54")] bool normalized = false, [MetadataOffset(Offset = "0x01F90E55")] bool overrideState = false)
		{
			// // CascadeEndBorderParameter(Single, Boolean, Boolean)
			// void HG::Rendering::Runtime::CascadeEndBorderParameter::CascadeEndBorderParameter(
			//         CascadeEndBorderParameter *this,
			//         float value,
			//         bool normalized,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D919EBD )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::VolumeParameter);
			//     byte_18D919EBD = 1;
			//   }
			//   this.fields._.m_Value = value;
			//   this.fields.normalized = normalized;
			//   this.fields._._.overrideState = overrideState;
			// }
			// 
		}

		internal void Init(NoInterpClampedIntParameter cascadeCounts, int minCascadeToAppears, NoInterpMinFloatParameter maxDistance, CascadePartitionSplitParameter min, CascadePartitionSplitParameter max)
		{
			// // Void Init(NoInterpClampedIntParameter, Int32, NoInterpMinFloatParameter, CascadePartitionSplitParameter, CascadePartitionSplitParameter)
			// void HG::Rendering::Runtime::CascadeEndBorderParameter::Init(
			//         CascadeEndBorderParameter *this,
			//         NoInterpClampedIntParameter *cascadeCounts,
			//         int32_t minCascadeToAppears,
			//         NoInterpMinFloatParameter *maxDistance,
			//         CascadePartitionSplitParameter *min,
			//         CascadePartitionSplitParameter *max,
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
			//   if ( IFix::WrappersManagerImpl::IsPatched(1879, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1879, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v21);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_727(
			//       Patch,
			//       (Object *)this,
			//       (Object *)cascadeCounts,
			//       minCascadeToAppears,
			//       (Object *)maxDistance,
			//       (Object *)min,
			//       (Object *)max,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.maxDistance = maxDistance;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.maxDistance, v11, v12, v13, (String__Array *)P3, (String *)P4, P5);
			//     this.fields.min = min;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.min,
			//       v14,
			//       v15,
			//       (MessageDescriptor *)min,
			//       (String__Array *)P3a,
			//       (String *)P4a,
			//       P5a);
			//     this.fields.max = max;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.max,
			//       v16,
			//       v17,
			//       (MessageDescriptor *)max,
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

		internal bool normalized;

		[NonSerialized]
		private CascadePartitionSplitParameter min;

		[NonSerialized]
		private CascadePartitionSplitParameter max;

		[NonSerialized]
		private NoInterpMinFloatParameter maxDistance;

		[NonSerialized]
		private NoInterpClampedIntParameter cascadeCounts;

		private int minCascadeToAppears;
	}
}
