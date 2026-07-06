using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/BlackBox", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGBlackBox : VolumeComponent
	{
		public HGBlackBox()
		{
			// // HGBlackBox()
			// void HG::Rendering::Runtime::HGBlackBox::HGBlackBox(HGBlackBox *this, MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   BoolParameter *v10; // rax
			//   BoolParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   __int64 v15; // rdi
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   MethodInfo *v18; // rdx
			//   Quaternion v19; // xmm6
			//   __int64 v20; // rdi
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   ClampedFloatParameter *v23; // rax
			//   ClampedFloatParameter *v24; // rdi
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   MessageDescriptor *v27; // r9
			//   ClampedFloatParameter *v28; // rax
			//   ClampedFloatParameter *v29; // rdi
			//   OneofDescriptorProto *v30; // rdx
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   FloatParameter *v33; // rax
			//   FloatParameter *v34; // rdi
			//   OneofDescriptorProto *v35; // rdx
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   MethodInfo *v38; // rdx
			//   Quaternion v39; // xmm10
			//   __int64 v40; // rdi
			//   FileDescriptor *v41; // r8
			//   MessageDescriptor *v42; // r9
			//   ClampedFloatParameter *v43; // rax
			//   ClampedFloatParameter *v44; // rdi
			//   OneofDescriptorProto *v45; // rdx
			//   FileDescriptor *v46; // r8
			//   MessageDescriptor *v47; // r9
			//   ClampedFloatParameter *v48; // rax
			//   ClampedFloatParameter *v49; // rdi
			//   OneofDescriptorProto *v50; // rdx
			//   FileDescriptor *v51; // r8
			//   MessageDescriptor *v52; // r9
			//   FloatParameter *v53; // rax
			//   FloatParameter *v54; // rdi
			//   OneofDescriptorProto *v55; // rdx
			//   FileDescriptor *v56; // r8
			//   MessageDescriptor *v57; // r9
			//   Texture2DParameter *v58; // rax
			//   Texture2DParameter *v59; // rdi
			//   OneofDescriptorProto *v60; // rdx
			//   FileDescriptor *v61; // r8
			//   MessageDescriptor *v62; // r9
			//   Vector2Parameter *v63; // rax
			//   Vector2Parameter *v64; // rdi
			//   OneofDescriptorProto *v65; // rdx
			//   FileDescriptor *v66; // r8
			//   MessageDescriptor *v67; // r9
			//   Vector2Parameter *v68; // rax
			//   Vector2Parameter *v69; // rdi
			//   OneofDescriptorProto *v70; // rdx
			//   FileDescriptor *v71; // r8
			//   MessageDescriptor *v72; // r9
			//   Vector2Parameter *v73; // rax
			//   Vector2Parameter *v74; // rdi
			//   OneofDescriptorProto *v75; // rdx
			//   FileDescriptor *v76; // r8
			//   MessageDescriptor *v77; // r9
			//   Vector2Parameter *v78; // rax
			//   Vector2Parameter *v79; // rdi
			//   OneofDescriptorProto *v80; // rdx
			//   FileDescriptor *v81; // r8
			//   MessageDescriptor *v82; // r9
			//   Vector2Parameter *v83; // rax
			//   Vector2Parameter *v84; // rdi
			//   OneofDescriptorProto *v85; // rdx
			//   FileDescriptor *v86; // r8
			//   MessageDescriptor *v87; // r9
			//   Vector2Parameter *v88; // rax
			//   Vector2Parameter *v89; // rdi
			//   OneofDescriptorProto *v90; // rdx
			//   FileDescriptor *v91; // r8
			//   MessageDescriptor *v92; // r9
			//   Vector2Parameter *v93; // rax
			//   Vector2Parameter *v94; // rdi
			//   OneofDescriptorProto *v95; // rdx
			//   FileDescriptor *v96; // r8
			//   MessageDescriptor *v97; // r9
			//   BoolParameter *v98; // rax
			//   BoolParameter *v99; // rdi
			//   OneofDescriptorProto *v100; // rdx
			//   FileDescriptor *v101; // r8
			//   MessageDescriptor *v102; // r9
			//   BoolParameter *v103; // rax
			//   BoolParameter *v104; // rdi
			//   OneofDescriptorProto *v105; // rdx
			//   FileDescriptor *v106; // r8
			//   MessageDescriptor *v107; // r9
			//   BoolParameter *v108; // rax
			//   BoolParameter *v109; // rdi
			//   OneofDescriptorProto *v110; // rdx
			//   FileDescriptor *v111; // r8
			//   MessageDescriptor *v112; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStater; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStates; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatet; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStateu; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStaten; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStateo; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStatep; // [rsp+20h] [rbp-88h]
			//   String__Array *overrideStateq; // [rsp+20h] [rbp-88h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodt; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodu; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodv; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-80h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-80h]
			//   Quaternion v157; // [rsp+30h] [rbp-78h] BYREF
			// 
			//   if ( !byte_18D8ED9CC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//     byte_18D8ED9CC = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.enabled = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.enabled,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v157.x);
			//   v10 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v10, 0, 0, 0LL);
			//   this.fields.useBlackBox = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.useBlackBox,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v157.x);
			//   v15 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v15 )
			//     goto LABEL_32;
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(_OWORD *)(v15 + 24) = 0LL;
			//   *(_BYTE *)(v15 + 16) = 0;
			//   this.fields.centerPos = (Vector4Parameter *)v15;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.centerPos,
			//     v4,
			//     v16,
			//     v17,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v157.x);
			//   v19 = *UnityEngine::Quaternion::get_identity(&v157, v18);
			//   v20 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v20 )
			//     goto LABEL_32;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Quaternion *)(v20 + 24) = v19;
			//   *(_WORD *)(v20 + 40) = 0;
			//   *(_BYTE *)(v20 + 42) = 1;
			//   *(_BYTE *)(v20 + 16) = 0;
			//   this.fields.blendColor = (ColorParameter *)v20;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.blendColor,
			//     v4,
			//     v21,
			//     v22,
			//     overrideStatec,
			//     (String *)methodd,
			//     *(MethodInfo **)&v157.x);
			//   v23 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v24 = v23;
			//   if ( !v23 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v23, 20.0, 0.0, 100.0, 0, 0LL);
			//   this.fields.blendWidth = v24;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.blendWidth,
			//     v25,
			//     v26,
			//     v27,
			//     overrideStater,
			//     (String *)methods,
			//     *(MethodInfo **)&v157.x);
			//   v28 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v29 = v28;
			//   if ( !v28 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v28, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.blendProgress = v29;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.blendProgress,
			//     v30,
			//     v31,
			//     v32,
			//     overrideStates,
			//     (String *)methodt,
			//     *(MethodInfo **)&v157.x);
			//   v33 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v34 = v33;
			//   if ( !v33 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v33, 500.0, 0, 0LL);
			//   this.fields.blendRadius = v34;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.blendRadius,
			//     v35,
			//     v36,
			//     v37,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v157.x);
			//   v39 = *UnityEngine::Quaternion::get_identity(&v157, v38);
			//   v40 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v40 )
			//     goto LABEL_32;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Quaternion *)(v40 + 24) = v39;
			//   *(_WORD *)(v40 + 40) = 0;
			//   *(_BYTE *)(v40 + 42) = 1;
			//   *(_BYTE *)(v40 + 16) = 0;
			//   this.fields.contourColor = (ColorParameter *)v40;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourColor,
			//     v4,
			//     v41,
			//     v42,
			//     overrideStatee,
			//     (String *)methodf,
			//     *(MethodInfo **)&v157.x);
			//   v43 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v44 = v43;
			//   if ( !v43 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v43, 20.0, 0.0, 100.0, 0, 0LL);
			//   this.fields.contourRangeWidth = v44;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourRangeWidth,
			//     v45,
			//     v46,
			//     v47,
			//     overrideStatet,
			//     (String *)methodu,
			//     *(MethodInfo **)&v157.x);
			//   v48 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v49 = v48;
			//   if ( !v48 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v48, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.contourRangeProgress = v49;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourRangeProgress,
			//     v50,
			//     v51,
			//     v52,
			//     overrideStateu,
			//     (String *)methodv,
			//     *(MethodInfo **)&v157.x);
			//   v53 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v54 = v53;
			//   if ( !v53 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v53, 500.0, 0, 0LL);
			//   this.fields.contourRangeRadius = v54;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourRangeRadius,
			//     v55,
			//     v56,
			//     v57,
			//     overrideStatef,
			//     (String *)methodg,
			//     *(MethodInfo **)&v157.x);
			//   v58 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v59 = v58;
			//   if ( !v58 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v58, 0LL, 0, 0LL);
			//   this.fields.contourTexture = v59;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourTexture,
			//     v60,
			//     v61,
			//     v62,
			//     overrideStateg,
			//     (String *)methodh,
			//     *(MethodInfo **)&v157.x);
			//   v63 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v64 = v63;
			//   if ( !v63 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v63,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u),
			//     0,
			//     0LL);
			//   this.fields.contourTexTiling = v64;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourTexTiling,
			//     v65,
			//     v66,
			//     v67,
			//     overrideStateh,
			//     (String *)methodi,
			//     *(MethodInfo **)&v157.x);
			//   v68 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v69 = v68;
			//   if ( !v68 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v68,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.contourTexUVSpeed = v69;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contourTexUVSpeed,
			//     v70,
			//     v71,
			//     v72,
			//     overrideStatei,
			//     (String *)methodj,
			//     *(MethodInfo **)&v157.x);
			//   v73 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v74 = v73;
			//   if ( !v73 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v73,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u),
			//     0,
			//     0LL);
			//   this.fields.disturbTexTiling = v74;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.disturbTexTiling,
			//     v75,
			//     v76,
			//     v77,
			//     overrideStatej,
			//     (String *)methodk,
			//     *(MethodInfo **)&v157.x);
			//   v78 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v79 = v78;
			//   if ( !v78 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v78,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.disturbTexUVSpeed = v79;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.disturbTexUVSpeed,
			//     v80,
			//     v81,
			//     v82,
			//     overrideStatek,
			//     (String *)methodl,
			//     *(MethodInfo **)&v157.x);
			//   v83 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v84 = v83;
			//   if ( !v83 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v83,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.disturbIntensity = v84;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.disturbIntensity,
			//     v85,
			//     v86,
			//     v87,
			//     overrideStatel,
			//     (String *)methodm,
			//     *(MethodInfo **)&v157.x);
			//   v88 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v89 = v88;
			//   if ( !v88 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v88,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u),
			//     0,
			//     0LL);
			//   this.fields.maskTexTiling = v89;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskTexTiling,
			//     v90,
			//     v91,
			//     v92,
			//     overrideStatem,
			//     (String *)methodn,
			//     *(MethodInfo **)&v157.x);
			//   v93 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v94 = v93;
			//   if ( !v93 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v93,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.maskTexUVSpeed = v94;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.maskTexUVSpeed,
			//     v95,
			//     v96,
			//     v97,
			//     overrideStaten,
			//     (String *)methodo,
			//     *(MethodInfo **)&v157.x);
			//   v98 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v99 = v98;
			//   if ( !v98 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v98, 1, 0, 0LL);
			//   this.fields.useDisturb = v99;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.useDisturb,
			//     v100,
			//     v101,
			//     v102,
			//     overrideStateo,
			//     (String *)methodp,
			//     *(MethodInfo **)&v157.x);
			//   v103 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v104 = v103;
			//   if ( !v103
			//     || (UnityEngine::Rendering::BoolParameter::BoolParameter(v103, 1, 0, 0LL),
			//         this.fields.useMask = v104,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.useMask,
			//           v105,
			//           v106,
			//           v107,
			//           overrideStatep,
			//           (String *)methodq,
			//           *(MethodInfo **)&v157.x),
			//         v108 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter),
			//         (v109 = v108) == 0LL) )
			//   {
			// LABEL_32:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v108, 1, 0, 0LL);
			//   this.fields.useMaskAsAlpha = v109;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.useMaskAsAlpha,
			//     v110,
			//     v111,
			//     v112,
			//     overrideStateq,
			//     (String *)methodr,
			//     *(MethodInfo **)&v157.x);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGBlackBox::IsActive(HGBlackBox *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   BoolParameter *wrapperArray; // rdx
			//   bool result; // al
			//   BoolParameter *v7; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = (BoolParameter *)static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_10;
			//   if ( *(int *)&wrapperArray.fields._.m_Value > 2131 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v3.static_fields;
			//     v7 = (BoolParameter *)static_fields.wrapperArray;
			//     if ( !static_fields.wrapperArray )
			//       goto LABEL_10;
			//     if ( *(_DWORD *)&v7.fields._.m_Value <= 0x853u )
			//       sub_180070270(static_fields, wrapperArray);
			//     if ( *(_QWORD *)&v7[533].fields._.m_Value )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(2131, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//       goto LABEL_10;
			//     }
			//   }
			//   wrapperArray = this.fields.enabled;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   result = sub_1800023D0(10LL, wrapperArray);
			//   if ( result )
			//   {
			//     wrapperArray = this.fields.useBlackBox;
			//     if ( wrapperArray )
			//       return sub_1800023D0(10LL, wrapperArray);
			// LABEL_10:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public BoolParameter enabled;

		public BoolParameter useBlackBox;

		public Vector4Parameter centerPos;

		public ColorParameter blendColor;

		public ClampedFloatParameter blendWidth;

		public ClampedFloatParameter blendProgress;

		public FloatParameter blendRadius;

		public ColorParameter contourColor;

		public ClampedFloatParameter contourRangeWidth;

		public ClampedFloatParameter contourRangeProgress;

		public FloatParameter contourRangeRadius;

		public Texture2DParameter contourTexture;

		public Vector2Parameter contourTexTiling;

		public Vector2Parameter contourTexUVSpeed;

		public Vector2Parameter disturbTexTiling;

		public Vector2Parameter disturbTexUVSpeed;

		public Vector2Parameter disturbIntensity;

		public Vector2Parameter maskTexTiling;

		public Vector2Parameter maskTexUVSpeed;

		public BoolParameter useDisturb;

		public BoolParameter useMask;

		public BoolParameter useMaskAsAlpha;
	}
}
