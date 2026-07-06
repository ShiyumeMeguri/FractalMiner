using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/BWFlash", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGBWFlash : VolumeComponent
	{
		public HGBWFlash()
		{
			// // HGBWFlash()
			// void HG::Rendering::Runtime::HGBWFlash::HGBWFlash(HGBWFlash *this, MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   Vector2Parameter *v10; // rax
			//   Vector2Parameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   ClampedFloatParameter *v15; // rax
			//   ClampedFloatParameter *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   BoolParameter *v25; // rax
			//   BoolParameter *v26; // rdi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   BoolParameter *v30; // rax
			//   BoolParameter *v31; // rdi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   Texture2DParameter *v35; // rax
			//   Texture2DParameter *v36; // rdi
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   Vector2Parameter *v40; // rax
			//   Vector2Parameter *v41; // rdi
			//   OneofDescriptorProto *v42; // rdx
			//   FileDescriptor *v43; // r8
			//   MessageDescriptor *v44; // r9
			//   Vector2Parameter *v45; // rax
			//   Vector2Parameter *v46; // rdi
			//   OneofDescriptorProto *v47; // rdx
			//   FileDescriptor *v48; // r8
			//   MessageDescriptor *v49; // r9
			//   Vector2Parameter *v50; // rax
			//   Vector2Parameter *v51; // rdi
			//   OneofDescriptorProto *v52; // rdx
			//   FileDescriptor *v53; // r8
			//   MessageDescriptor *v54; // r9
			//   Vector2Parameter *v55; // rax
			//   Vector2Parameter *v56; // rdi
			//   OneofDescriptorProto *v57; // rdx
			//   FileDescriptor *v58; // r8
			//   MessageDescriptor *v59; // r9
			//   BoolParameter *v60; // rax
			//   BoolParameter *v61; // rdi
			//   OneofDescriptorProto *v62; // rdx
			//   FileDescriptor *v63; // r8
			//   MessageDescriptor *v64; // r9
			//   Texture2DParameter *v65; // rax
			//   Texture2DParameter *v66; // rdi
			//   OneofDescriptorProto *v67; // rdx
			//   FileDescriptor *v68; // r8
			//   MessageDescriptor *v69; // r9
			//   ClampedFloatParameter *v70; // rax
			//   ClampedFloatParameter *v71; // rdi
			//   OneofDescriptorProto *v72; // rdx
			//   FileDescriptor *v73; // r8
			//   MessageDescriptor *v74; // r9
			//   BoolParameter *v75; // rax
			//   BoolParameter *v76; // rdi
			//   OneofDescriptorProto *v77; // rdx
			//   FileDescriptor *v78; // r8
			//   MessageDescriptor *v79; // r9
			//   Vector2Parameter *v80; // rax
			//   Vector2Parameter *v81; // rdi
			//   OneofDescriptorProto *v82; // rdx
			//   FileDescriptor *v83; // r8
			//   MessageDescriptor *v84; // r9
			//   Vector2Parameter *v85; // rax
			//   Vector2Parameter *v86; // rdi
			//   OneofDescriptorProto *v87; // rdx
			//   FileDescriptor *v88; // r8
			//   MessageDescriptor *v89; // r9
			//   MethodInfo *v90; // rdx
			//   Vector4 v91; // xmm6
			//   __int64 v92; // rdi
			//   FileDescriptor *v93; // r8
			//   MessageDescriptor *v94; // r9
			//   MethodInfo *v95; // rdx
			//   Quaternion v96; // xmm6
			//   __int64 v97; // rdi
			//   FileDescriptor *v98; // r8
			//   MessageDescriptor *v99; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatep; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateq; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStater; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStaten; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateo; // [rsp+20h] [rbp-48h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-40h]
			//   Quaternion v138; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8ED9CD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     byte_18D8ED9CD = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.enabled = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.enabled,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v138.x);
			//   v10 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v10,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u),
			//     0,
			//     0LL);
			//   this.fields.centerPosition = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.centerPosition,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v138.x);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 1.0, 0.50999999, 1.0, 0, 0LL);
			//   this.fields.bwThreshold = v16;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.bwThreshold,
			//     v17,
			//     v18,
			//     v19,
			//     overrideStatep,
			//     (String *)methodq,
			//     *(MethodInfo **)&v138.x);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.0, -1.0, 1.0, 0, 0LL);
			//   this.fields.colorBias = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.colorBias,
			//     v22,
			//     v23,
			//     v24,
			//     overrideStateq,
			//     (String *)methodr,
			//     *(MethodInfo **)&v138.x);
			//   v25 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v25, 0, 0, 0LL);
			//   this.fields.inverse = v26;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.inverse,
			//     v27,
			//     v28,
			//     v29,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v138.x);
			//   v30 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v30, 0, 0, 0LL);
			//   this.fields.useFlashTex = v31;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.useFlashTex,
			//     v32,
			//     v33,
			//     v34,
			//     overrideStatec,
			//     (String *)methodd,
			//     *(MethodInfo **)&v138.x);
			//   v35 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v36 = v35;
			//   if ( !v35 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v35, 0LL, 0, 0LL);
			//   this.fields.flashTexture = v36;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.flashTexture,
			//     v37,
			//     v38,
			//     v39,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v138.x);
			//   v40 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v41 = v40;
			//   if ( !v40 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v40,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u),
			//     0,
			//     0LL);
			//   this.fields.flashTexTiling = v41;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.flashTexTiling,
			//     v42,
			//     v43,
			//     v44,
			//     overrideStatee,
			//     (String *)methodf,
			//     *(MethodInfo **)&v138.x);
			//   v45 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v46 = v45;
			//   if ( !v45 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v45,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.flashTexOffset = v46;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.flashTexOffset,
			//     v47,
			//     v48,
			//     v49,
			//     overrideStatef,
			//     (String *)methodg,
			//     *(MethodInfo **)&v138.x);
			//   v50 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v51 = v50;
			//   if ( !v50 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v50,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.flashTexSpeed = v51;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.flashTexSpeed,
			//     v52,
			//     v53,
			//     v54,
			//     overrideStateg,
			//     (String *)methodh,
			//     *(MethodInfo **)&v138.x);
			//   v55 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v56 = v55;
			//   if ( !v55 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v55,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u),
			//     0,
			//     0LL);
			//   this.fields.flashIntensity = v56;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.flashIntensity,
			//     v57,
			//     v58,
			//     v59,
			//     overrideStateh,
			//     (String *)methodi,
			//     *(MethodInfo **)&v138.x);
			//   v60 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v61 = v60;
			//   if ( !v60 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v60, 0, 0, 0LL);
			//   this.fields.useMaskTex = v61;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.useMaskTex,
			//     v62,
			//     v63,
			//     v64,
			//     overrideStatei,
			//     (String *)methodj,
			//     *(MethodInfo **)&v138.x);
			//   v65 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v66 = v65;
			//   if ( !v65 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v65, 0LL, 0, 0LL);
			//   this.fields.maskTexture = v66;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskTexture,
			//     v67,
			//     v68,
			//     v69,
			//     overrideStatej,
			//     (String *)methodk,
			//     *(MethodInfo **)&v138.x);
			//   v70 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v71 = v70;
			//   if ( !v70 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v70, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.maskIntensity = v71;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskIntensity,
			//     v72,
			//     v73,
			//     v74,
			//     overrideStater,
			//     (String *)methods,
			//     *(MethodInfo **)&v138.x);
			//   v75 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v76 = v75;
			//   if ( !v75 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v75, 0, 0, 0LL);
			//   this.fields.maskUsePolarUV = v76;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskUsePolarUV,
			//     v77,
			//     v78,
			//     v79,
			//     overrideStatek,
			//     (String *)methodl,
			//     *(MethodInfo **)&v138.x);
			//   v80 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v81 = v80;
			//   if ( !v80 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v80,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u),
			//     0,
			//     0LL);
			//   this.fields.maskTexTiling = v81;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskTexTiling,
			//     v82,
			//     v83,
			//     v84,
			//     overrideStatel,
			//     (String *)methodm,
			//     *(MethodInfo **)&v138.x);
			//   v85 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v86 = v85;
			//   if ( !v85 )
			//     goto LABEL_27;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v85,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.maskTexOffset = v86;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskTexOffset,
			//     v87,
			//     v88,
			//     v89,
			//     overrideStatem,
			//     (String *)methodn,
			//     *(MethodInfo **)&v138.x);
			//   v91 = *UnityEngine::Vector4::get_one((Vector4 *)&v138, v90);
			//   v92 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v92 )
			//     goto LABEL_27;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Vector4 *)(v92 + 24) = v91;
			//   *(_WORD *)(v92 + 40) = 0;
			//   *(_BYTE *)(v92 + 42) = 1;
			//   *(_BYTE *)(v92 + 16) = 0;
			//   this.fields.flashColor = (ColorParameter *)v92;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.flashColor,
			//     v4,
			//     v93,
			//     v94,
			//     overrideStaten,
			//     (String *)methodo,
			//     *(MethodInfo **)&v138.x);
			//   v96 = *UnityEngine::Quaternion::get_identity(&v138, v95);
			//   v97 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v97 )
			// LABEL_27:
			//     sub_180B536AC(v5, v4);
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Quaternion *)(v97 + 24) = v96;
			//   *(_WORD *)(v97 + 40) = 0;
			//   *(_BYTE *)(v97 + 42) = 1;
			//   *(_BYTE *)(v97 + 16) = 0;
			//   this.fields.backGroundColor = (ColorParameter *)v97;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.backGroundColor,
			//     v4,
			//     v98,
			//     v99,
			//     overrideStateo,
			//     (String *)methodp,
			//     *(MethodInfo **)&v138.x);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGBWFlash::IsActive(HGBWFlash *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   BoolParameter *enabled; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2221, 0LL) )
			//   {
			//     enabled = this.fields.enabled;
			//     if ( enabled )
			//       return sub_1800023D0(10LL, enabled);
			// LABEL_5:
			//     sub_180B536AC(v3, enabled);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2221, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enabled;

		public Vector2Parameter centerPosition;

		public ClampedFloatParameter bwThreshold;

		public ClampedFloatParameter colorBias;

		public BoolParameter inverse;

		public BoolParameter useFlashTex;

		public Texture2DParameter flashTexture;

		public Vector2Parameter flashTexTiling;

		public Vector2Parameter flashTexOffset;

		public Vector2Parameter flashTexSpeed;

		public Vector2Parameter flashIntensity;

		public BoolParameter useMaskTex;

		public Texture2DParameter maskTexture;

		public ClampedFloatParameter maskIntensity;

		public BoolParameter maskUsePolarUV;

		public Vector2Parameter maskTexTiling;

		public Vector2Parameter maskTexOffset;

		public ColorParameter flashColor;

		public ColorParameter backGroundColor;
	}
}
