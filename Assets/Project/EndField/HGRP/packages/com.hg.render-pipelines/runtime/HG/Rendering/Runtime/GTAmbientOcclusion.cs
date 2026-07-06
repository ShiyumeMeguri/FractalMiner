using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/GTAmbientOcclusion", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class GTAmbientOcclusion : VolumeComponent
	{
		public GTAmbientOcclusion()
		{
			// // GTAmbientOcclusion()
			// void HG::Rendering::Runtime::GTAmbientOcclusion::GTAmbientOcclusion(GTAmbientOcclusion *this, MethodInfo *method)
			// {
			//   MethodInfo *v2; // xmm6_8
			//   BoolParameter *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   BoolParameter *v7; // rdi
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   BoolParameter *v11; // rax
			//   BoolParameter *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   BoolParameter *v16; // rax
			//   BoolParameter *v17; // rdi
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   IntParameter *v21; // rax
			//   ClampedIntParameter *v22; // rdi
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   IntParameter *v26; // rax
			//   ClampedIntParameter *v27; // rdi
			//   OneofDescriptorProto *v28; // rdx
			//   FileDescriptor *v29; // r8
			//   MessageDescriptor *v30; // r9
			//   ClampedFloatParameter *v31; // rax
			//   ClampedFloatParameter *v32; // rdi
			//   OneofDescriptorProto *v33; // rdx
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   FloatParameter *v36; // rax
			//   FloatParameter *v37; // rdi
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   FloatParameter *v41; // rax
			//   FloatParameter *v42; // rdi
			//   OneofDescriptorProto *v43; // rdx
			//   FileDescriptor *v44; // r8
			//   MessageDescriptor *v45; // r9
			//   FloatParameter *v46; // rax
			//   FloatParameter *v47; // rdi
			//   OneofDescriptorProto *v48; // rdx
			//   FileDescriptor *v49; // r8
			//   MessageDescriptor *v50; // r9
			//   FloatParameter *v51; // rax
			//   FloatParameter *v52; // rdi
			//   OneofDescriptorProto *v53; // rdx
			//   FileDescriptor *v54; // r8
			//   MessageDescriptor *v55; // r9
			//   FloatParameter *v56; // rax
			//   FloatParameter *v57; // rdi
			//   OneofDescriptorProto *v58; // rdx
			//   FileDescriptor *v59; // r8
			//   MessageDescriptor *v60; // r9
			//   FloatParameter *v61; // rax
			//   FloatParameter *v62; // rdi
			//   OneofDescriptorProto *v63; // rdx
			//   FileDescriptor *v64; // r8
			//   MessageDescriptor *v65; // r9
			//   FloatParameter *v66; // rax
			//   FloatParameter *v67; // rdi
			//   OneofDescriptorProto *v68; // rdx
			//   FileDescriptor *v69; // r8
			//   MessageDescriptor *v70; // r9
			//   FloatParameter *v71; // rax
			//   FloatParameter *v72; // rdi
			//   OneofDescriptorProto *v73; // rdx
			//   FileDescriptor *v74; // r8
			//   MessageDescriptor *v75; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v104; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v105; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v106; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v107; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v108; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v109; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v110; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v111; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v112; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v113; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v114; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v115; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v116; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8ED9C8 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//     byte_18D8ED9C8 = 1;
			//   }
			//   v4 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v7 = v4;
			//   if ( !v4 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v4, 0, 1, 0LL);
			//   this.fields.enable = v7;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.enable, v8, v9, v10, overrideState, (String *)methoda, v2);
			//   v11 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v11, 1, 0, 0LL);
			//   this.fields.enableFP32Depths = v12;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.enableFP32Depths,
			//     v13,
			//     v14,
			//     v15,
			//     overrideStatea,
			//     (String *)methodb,
			//     v104);
			//   v16 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v16, 1, 0, 0LL);
			//   this.fields.enableBentNormals = v17;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.enableBentNormals,
			//     v18,
			//     v19,
			//     v20,
			//     overrideStateb,
			//     (String *)methodc,
			//     v105);
			//   v21 = (IntParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//   v22 = (ClampedIntParameter *)v21;
			//   if ( !v21 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::IntParameter::IntParameter(v21, 2, 0, 0LL);
			//   v22.fields.max = 3;
			//   v22.fields.min = 0;
			//   this.fields.qualityLevel = v22;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.qualityLevel, v23, v24, v25, overrideStatec, (String *)methodd, v106);
			//   v26 = (IntParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//   v27 = (ClampedIntParameter *)v26;
			//   if ( !v26 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::IntParameter::IntParameter(v26, 1, 0, 0LL);
			//   v27.fields.min = 0;
			//   v27.fields.max = 3;
			//   this.fields.denoisePasses = v27;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.denoisePasses, v28, v29, v30, overrideStated, (String *)methode, v107);
			//   v31 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v32 = v31;
			//   if ( !v31 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v31, 5.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.radius = v32;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.radius, v33, v34, v35, overrideStatem, (String *)methodn, v108);
			//   v36 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v37 = v36;
			//   if ( !v36 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v36, 2.0, 0, 0LL);
			//   LODWORD(v37[1].klass) = 0;
			//   this.fields.radiusMultiplier = (MinFloatParameter *)v37;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.radiusMultiplier,
			//     v38,
			//     v39,
			//     v40,
			//     overrideStatee,
			//     (String *)methodf,
			//     v109);
			//   v41 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v42 = v41;
			//   if ( !v41 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v41, 0.80000001, 0, 0LL);
			//   LODWORD(v42[1].klass) = 0;
			//   this.fields.falloffRange = (MinFloatParameter *)v42;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.falloffRange, v43, v44, v45, overrideStatef, (String *)methodg, v110);
			//   v46 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v47 = v46;
			//   if ( !v46 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v46, 2.0, 0, 0LL);
			//   LODWORD(v47[1].klass) = 0;
			//   this.fields.sampleDistributionPower = (MinFloatParameter *)v47;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.sampleDistributionPower,
			//     v48,
			//     v49,
			//     v50,
			//     overrideStateg,
			//     (String *)methodh,
			//     v111);
			//   v51 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v52 = v51;
			//   if ( !v51 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v51, 2.0, 0, 0LL);
			//   LODWORD(v52[1].klass) = 0;
			//   this.fields.thinOccluderCompensation = (MinFloatParameter *)v52;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.thinOccluderCompensation,
			//     v53,
			//     v54,
			//     v55,
			//     overrideStateh,
			//     (String *)methodi,
			//     v112);
			//   v56 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v57 = v56;
			//   if ( !v56 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v56, 2.2, 0, 0LL);
			//   LODWORD(v57[1].klass) = 0;
			//   this.fields.finalValuePower = (MinFloatParameter *)v57;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.finalValuePower,
			//     v58,
			//     v59,
			//     v60,
			//     overrideStatei,
			//     (String *)methodj,
			//     v113);
			//   v61 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v62 = v61;
			//   if ( !v61 )
			//     goto LABEL_18;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v61, 3.3, 0, 0LL);
			//   LODWORD(v62[1].klass) = 0;
			//   this.fields.depthMIPSamplingOffset = (MinFloatParameter *)v62;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.depthMIPSamplingOffset,
			//     v63,
			//     v64,
			//     v65,
			//     overrideStatej,
			//     (String *)methodk,
			//     v114);
			//   v66 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v67 = v66;
			//   if ( !v66
			//     || (UnityEngine::Rendering::FloatParameter::FloatParameter(v66, 0.001, 0, 0LL),
			//         LODWORD(v67[1].klass) = 0,
			//         this.fields.mvFactor = (MinFloatParameter *)v67,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.mvFactor, v68, v69, v70, overrideStatek, (String *)methodl, v115),
			//         v71 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter),
			//         (v72 = v71) == 0LL) )
			//   {
			// LABEL_18:
			//     sub_180B536AC(v6, v5);
			//   }
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v71, 2.5, 0, 0LL);
			//   LODWORD(v72[1].klass) = 0;
			//   this.fields.depthFactor = (MinFloatParameter *)v72;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.depthFactor, v73, v74, v75, overrideStatel, (String *)methodm, v116);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::GTAmbientOcclusion::IsActive(GTAmbientOcclusion *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   BoolParameter *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (BoolParameter *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( *(int *)&wrapperArray.fields._.m_Value <= 988 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_9;
			//   if ( LODWORD(v3._0.namespaze) <= 0x3DC )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*((_QWORD *)&v3[21]._0.byval_arg + 1) )
			//   {
			// LABEL_7:
			//     wrapperArray = this.fields.enable;
			//     if ( wrapperArray )
			//       return sub_1800023D0(10LL, wrapperArray);
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(988, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enable;

		public BoolParameter enableFP32Depths;

		private BoolParameter enableBentNormals;

		public ClampedIntParameter qualityLevel;

		public ClampedIntParameter denoisePasses;

		public ClampedFloatParameter radius;

		public MinFloatParameter radiusMultiplier;

		public MinFloatParameter falloffRange;

		public MinFloatParameter sampleDistributionPower;

		public MinFloatParameter thinOccluderCompensation;

		public MinFloatParameter finalValuePower;

		public MinFloatParameter depthMIPSamplingOffset;

		public MinFloatParameter mvFactor;

		public MinFloatParameter depthFactor;
	}
}
