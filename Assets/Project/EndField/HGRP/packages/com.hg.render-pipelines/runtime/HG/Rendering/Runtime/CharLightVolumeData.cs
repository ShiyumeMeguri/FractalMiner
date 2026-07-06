using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class CharLightVolumeData
	{
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000025D2 File Offset: 0x000007D2
		public static CharLightVolumeData defaultCharLightVolumeData
		{
			get
			{
				return null;
			}
		}

		public CharLightVolumeData()
		{
			// // CharLightVolumeData()
			// void HG::Rendering::Runtime::CharLightVolumeData::CharLightVolumeData(CharLightVolumeData *this, MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
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
			//   ClampedFloatParameter *v25; // rax
			//   ClampedFloatParameter *v26; // rdi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   ClampedFloatParameter *v30; // rax
			//   ClampedFloatParameter *v31; // rdi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   ClampedFloatParameter *v35; // rax
			//   ClampedFloatParameter *v36; // rdi
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   ClampedFloatParameter *v40; // rax
			//   ClampedFloatParameter *v41; // rdi
			//   OneofDescriptorProto *v42; // rdx
			//   FileDescriptor *v43; // r8
			//   MessageDescriptor *v44; // r9
			//   ClampedFloatParameter *v45; // rax
			//   ClampedFloatParameter *v46; // rdi
			//   OneofDescriptorProto *v47; // rdx
			//   FileDescriptor *v48; // r8
			//   MessageDescriptor *v49; // r9
			//   BoolParameter *v50; // rax
			//   BoolParameter *v51; // rdi
			//   OneofDescriptorProto *v52; // rdx
			//   FileDescriptor *v53; // r8
			//   MessageDescriptor *v54; // r9
			//   HGCharacterVolume_CharacterLightModeParameter *v55; // rax
			//   HGCharacterVolume_CharacterLightModeParameter *v56; // rdi
			//   OneofDescriptorProto *v57; // rdx
			//   FileDescriptor *v58; // r8
			//   MessageDescriptor *v59; // r9
			//   Vector2Parameter *v60; // rax
			//   Vector2Parameter *v61; // rdi
			//   OneofDescriptorProto *v62; // rdx
			//   FileDescriptor *v63; // r8
			//   MessageDescriptor *v64; // r9
			//   Vector2Parameter *v65; // rax
			//   Vector2Parameter *v66; // rdi
			//   OneofDescriptorProto *v67; // rdx
			//   FileDescriptor *v68; // r8
			//   MessageDescriptor *v69; // r9
			//   MethodInfo *v70; // rdx
			//   __m128i v71; // xmm8
			//   ColorParameter *v72; // rax
			//   ColorParameter *v73; // rdi
			//   OneofDescriptorProto *v74; // rdx
			//   FileDescriptor *v75; // r8
			//   MessageDescriptor *v76; // r9
			//   MethodInfo *v77; // rdx
			//   __m128i v78; // xmm8
			//   ColorParameter *v79; // rax
			//   ColorParameter *v80; // rdi
			//   OneofDescriptorProto *v81; // rdx
			//   FileDescriptor *v82; // r8
			//   MessageDescriptor *v83; // r9
			//   BoolParameter *v84; // rax
			//   BoolParameter *v85; // rdi
			//   OneofDescriptorProto *v86; // rdx
			//   FileDescriptor *v87; // r8
			//   MessageDescriptor *v88; // r9
			//   HGCharacterVolume_CharacterShadowTintModeParameter *v89; // rax
			//   HGCharacterVolume_CharacterShadowTintModeParameter *v90; // rdi
			//   OneofDescriptorProto *v91; // rdx
			//   FileDescriptor *v92; // r8
			//   MessageDescriptor *v93; // r9
			//   MethodInfo *v94; // rdx
			//   __m128i v95; // xmm8
			//   ColorParameter *v96; // rax
			//   ColorParameter *v97; // rdi
			//   OneofDescriptorProto *v98; // rdx
			//   FileDescriptor *v99; // r8
			//   MessageDescriptor *v100; // r9
			//   MethodInfo *v101; // rdx
			//   __m128i v102; // xmm8
			//   ColorParameter *v103; // rax
			//   ColorParameter *v104; // rdi
			//   OneofDescriptorProto *v105; // rdx
			//   FileDescriptor *v106; // r8
			//   MessageDescriptor *v107; // r9
			//   BoolParameter *v108; // rax
			//   BoolParameter *v109; // rdi
			//   OneofDescriptorProto *v110; // rdx
			//   FileDescriptor *v111; // r8
			//   MessageDescriptor *v112; // r9
			//   MethodInfo *v113; // rdx
			//   __m128i v114; // xmm8
			//   ColorParameter *v115; // rax
			//   ColorParameter *v116; // rdi
			//   OneofDescriptorProto *v117; // rdx
			//   FileDescriptor *v118; // r8
			//   MessageDescriptor *v119; // r9
			//   ClampedFloatParameter *v120; // rax
			//   ClampedFloatParameter *v121; // rdi
			//   OneofDescriptorProto *v122; // rdx
			//   FileDescriptor *v123; // r8
			//   MessageDescriptor *v124; // r9
			//   ClampedFloatParameter *v125; // rax
			//   ClampedFloatParameter *v126; // rdi
			//   OneofDescriptorProto *v127; // rdx
			//   FileDescriptor *v128; // r8
			//   MessageDescriptor *v129; // r9
			//   ClampedFloatParameter *v130; // rax
			//   ClampedFloatParameter *v131; // rdi
			//   OneofDescriptorProto *v132; // rdx
			//   FileDescriptor *v133; // r8
			//   MessageDescriptor *v134; // r9
			//   BoolParameter *v135; // rax
			//   BoolParameter *v136; // rdi
			//   OneofDescriptorProto *v137; // rdx
			//   FileDescriptor *v138; // r8
			//   MessageDescriptor *v139; // r9
			//   MethodInfo *v140; // rdx
			//   __m128i v141; // xmm8
			//   ColorParameter *v142; // rax
			//   ColorParameter *v143; // rdi
			//   OneofDescriptorProto *v144; // rdx
			//   FileDescriptor *v145; // r8
			//   MessageDescriptor *v146; // r9
			//   ClampedFloatParameter *v147; // rax
			//   ClampedFloatParameter *v148; // rdi
			//   OneofDescriptorProto *v149; // rdx
			//   FileDescriptor *v150; // r8
			//   MessageDescriptor *v151; // r9
			//   ClampedFloatParameter *v152; // rax
			//   ClampedFloatParameter *v153; // rdi
			//   OneofDescriptorProto *v154; // rdx
			//   FileDescriptor *v155; // r8
			//   MessageDescriptor *v156; // r9
			//   BoolParameter *v157; // rax
			//   BoolParameter *v158; // rdi
			//   OneofDescriptorProto *v159; // rdx
			//   FileDescriptor *v160; // r8
			//   MessageDescriptor *v161; // r9
			//   BoolParameter *v162; // rax
			//   BoolParameter *v163; // rdi
			//   OneofDescriptorProto *v164; // rdx
			//   FileDescriptor *v165; // r8
			//   MessageDescriptor *v166; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatep; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateq; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStater; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStates; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatet; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateu; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatev; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatew; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatex; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatey; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatez; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStaten; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateba; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStatebb; // [rsp+20h] [rbp-60h]
			//   String__Array *overrideStateo; // [rsp+20h] [rbp-60h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodt; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodu; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodv; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodw; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodx; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methody; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodz; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodba; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodbb; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodbc; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-58h]
			//   Vector4 v225[3]; // [rsp+30h] [rbp-50h] BYREF
			//   String__Array *v226; // [rsp+B0h] [rbp+30h]
			//   String *v227; // [rsp+B8h] [rbp+38h]
			//   MethodInfo *v228; // [rsp+C0h] [rbp+40h]
			// 
			//   if ( !byte_18D919455 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     byte_18D919455 = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.charMainLightControl = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v225[0].x);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 1.0, 0.0, 5.0, 0, 0LL);
			//   this.fields.charMainLightMultiplier = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightMultiplier,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStatep,
			//     (String *)methodq,
			//     *(MethodInfo **)&v225[0].x);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 0.69999999, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEnvLightMultiplier = v16;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEnvLightMultiplier,
			//     v17,
			//     v18,
			//     v19,
			//     overrideStateq,
			//     (String *)methodr,
			//     *(MethodInfo **)&v225[0].x);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 1.0, 0.0, 2.0, 0, 0LL);
			//   this.fields.charEnvShadowMultiplier = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEnvShadowMultiplier,
			//     v22,
			//     v23,
			//     v24,
			//     overrideStater,
			//     (String *)methods,
			//     *(MethodInfo **)&v225[0].x);
			//   v25 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v25, 1.0, 0.0, 2.0, 0, 0LL);
			//   this.fields.charMainLightSpecularMultiplier = v26;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightSpecularMultiplier,
			//     v27,
			//     v28,
			//     v29,
			//     overrideStates,
			//     (String *)methodt,
			//     *(MethodInfo **)&v225[0].x);
			//   v30 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v30, 0.0, -1.0, 1.0, 0, 0LL);
			//   this.fields.charMainLightRangeBias = v31;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightRangeBias,
			//     v32,
			//     v33,
			//     v34,
			//     overrideStatet,
			//     (String *)methodu,
			//     *(MethodInfo **)&v225[0].x);
			//   v35 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v36 = v35;
			//   if ( !v35 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v35, 1.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEyeBaseLightMultiplier = v36;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEyeBaseLightMultiplier,
			//     v37,
			//     v38,
			//     v39,
			//     overrideStateu,
			//     (String *)methodv,
			//     *(MethodInfo **)&v225[0].x);
			//   v40 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v41 = v40;
			//   if ( !v40 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v40, 1.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEyeHighlightMultiplier = v41;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEyeHighlightMultiplier,
			//     v42,
			//     v43,
			//     v44,
			//     overrideStatev,
			//     (String *)methodw,
			//     *(MethodInfo **)&v225[0].x);
			//   v45 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v46 = v45;
			//   if ( !v45 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v45, 1.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEyeScatteringMultiplier = v46;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEyeScatteringMultiplier,
			//     v47,
			//     v48,
			//     v49,
			//     overrideStatew,
			//     (String *)methodx,
			//     *(MethodInfo **)&v225[0].x);
			//   v50 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v51 = v50;
			//   if ( !v50 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v50, 0, 0, 0LL);
			//   this.fields.charIgnoreMainLightShadow = v51;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charIgnoreMainLightShadow,
			//     v52,
			//     v53,
			//     v54,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v225[0].x);
			//   v55 = (HGCharacterVolume_CharacterLightModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter);
			//   v56 = v55;
			//   if ( !v55 )
			//     goto LABEL_34;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter::CharacterLightModeParameter(
			//     v55,
			//     HGCharacterVolume_CharacterLightMode__Enum_Scene,
			//     0,
			//     0LL);
			//   this.fields.charMainLightMode = v56;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightMode,
			//     v57,
			//     v58,
			//     v59,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v225[0].x);
			//   v60 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v61 = v60;
			//   if ( !v60 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v60,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41F00000u, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.charCustomMainLightDir = v61;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charCustomMainLightDir,
			//     v62,
			//     v63,
			//     v64,
			//     overrideStatec,
			//     (String *)methodd,
			//     *(MethodInfo **)&v225[0].x);
			//   v65 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v66 = v65;
			//   if ( !v65 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v65,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41F00000u, (__m128)0x41200000u),
			//     0,
			//     0LL);
			//   this.fields.charCameraFollowMainLightBias = v66;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charCameraFollowMainLightBias,
			//     v67,
			//     v68,
			//     v69,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v225[0].x);
			//   v71 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v225, v70));
			//   v72 = (ColorParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   v73 = v72;
			//   if ( !v72 )
			//     goto LABEL_34;
			//   v225[0] = (Vector4)v71;
			//   UnityEngine::Rendering::ColorParameter::ColorParameter(v72, (Color *)v225, 0, 0LL);
			//   this.fields.charMainLightOverrideColor = v73;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightOverrideColor,
			//     v74,
			//     v75,
			//     v76,
			//     overrideStatee,
			//     (String *)methodf,
			//     *(MethodInfo **)&v225[0].x);
			//   v78 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v225, v77));
			//   v79 = (ColorParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   v80 = v79;
			//   if ( !v79 )
			//     goto LABEL_34;
			//   v225[0] = (Vector4)v78;
			//   UnityEngine::Rendering::ColorParameter::ColorParameter(v79, (Color *)v225, 0, 0LL);
			//   this.fields.charSkinMainLightOverrideColor = v80;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charSkinMainLightOverrideColor,
			//     v81,
			//     v82,
			//     v83,
			//     overrideStatef,
			//     (String *)methodg,
			//     *(MethodInfo **)&v225[0].x);
			//   v84 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v85 = v84;
			//   if ( !v84 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v84, 0, 0, 0LL);
			//   this.fields.charLightDialogMode = v85;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charLightDialogMode,
			//     v86,
			//     v87,
			//     v88,
			//     overrideStateg,
			//     (String *)methodh,
			//     *(MethodInfo **)&v225[0].x);
			//   v89 = (HGCharacterVolume_CharacterShadowTintModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter);
			//   v90 = v89;
			//   if ( !v89 )
			//     goto LABEL_34;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter::CharacterShadowTintModeParameter(
			//     v89,
			//     HGCharacterVolume_CharacterShadowTintMode__Enum_Auto,
			//     0,
			//     0LL);
			//   this.fields.charShadowTintControl = v90;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charShadowTintControl,
			//     v91,
			//     v92,
			//     v93,
			//     overrideStateh,
			//     (String *)methodi,
			//     *(MethodInfo **)&v225[0].x);
			//   v95 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v225, v94));
			//   v96 = (ColorParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   v97 = v96;
			//   if ( !v96 )
			//     goto LABEL_34;
			//   v225[0] = (Vector4)v95;
			//   UnityEngine::Rendering::ColorParameter::ColorParameter(v96, (Color *)v225, 0, 0LL);
			//   this.fields.charShadowTintColor = v97;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charShadowTintColor,
			//     v98,
			//     v99,
			//     v100,
			//     overrideStatei,
			//     (String *)methodj,
			//     *(MethodInfo **)&v225[0].x);
			//   v102 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v225, v101));
			//   v103 = (ColorParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   v104 = v103;
			//   if ( !v103 )
			//     goto LABEL_34;
			//   v225[0] = (Vector4)v102;
			//   UnityEngine::Rendering::ColorParameter::ColorParameter(v103, (Color *)v225, 0, 0LL);
			//   this.fields.charSkinShadowTintColor = v104;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charSkinShadowTintColor,
			//     v105,
			//     v106,
			//     v107,
			//     overrideStatej,
			//     (String *)methodk,
			//     *(MethodInfo **)&v225[0].x);
			//   v108 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v109 = v108;
			//   if ( !v108 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v108, 0, 0, 0LL);
			//   this.fields.charAutoRimEnable = v109;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimEnable,
			//     v110,
			//     v111,
			//     v112,
			//     overrideStatek,
			//     (String *)methodl,
			//     *(MethodInfo **)&v225[0].x);
			//   v114 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v225, v113));
			//   v115 = (ColorParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   v116 = v115;
			//   if ( !v115 )
			//     goto LABEL_34;
			//   v225[0] = (Vector4)v114;
			//   UnityEngine::Rendering::ColorParameter::ColorParameter(v115, (Color *)v225, 0, 0LL);
			//   this.fields.charAutoRimColor = v116;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimColor,
			//     v117,
			//     v118,
			//     v119,
			//     overrideStatel,
			//     (String *)methodm,
			//     *(MethodInfo **)&v225[0].x);
			//   v120 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v121 = v120;
			//   if ( !v120 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v120, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charAutoRimDir = v121;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimDir,
			//     v122,
			//     v123,
			//     v124,
			//     overrideStatex,
			//     (String *)methody,
			//     *(MethodInfo **)&v225[0].x);
			//   v125 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v126 = v125;
			//   if ( !v125 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v125, 1.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charAutoRimIntensity = v126;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimIntensity,
			//     v127,
			//     v128,
			//     v129,
			//     overrideStatey,
			//     (String *)methodz,
			//     *(MethodInfo **)&v225[0].x);
			//   v130 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v131 = v130;
			//   if ( !v130 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v130, 0.40000001, 0.0, 1.0, 0, 0LL);
			//   this.fields.charAutoRimWidth = v131;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimWidth,
			//     v132,
			//     v133,
			//     v134,
			//     overrideStatez,
			//     (String *)methodba,
			//     *(MethodInfo **)&v225[0].x);
			//   v135 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v136 = v135;
			//   if ( !v135 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v135, 0, 0, 0LL);
			//   this.fields.charFaceRimEnable = v136;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimEnable,
			//     v137,
			//     v138,
			//     v139,
			//     overrideStatem,
			//     (String *)methodn,
			//     *(MethodInfo **)&v225[0].x);
			//   v141 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v225, v140));
			//   v142 = (ColorParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   v143 = v142;
			//   if ( !v142 )
			//     goto LABEL_34;
			//   v225[0] = (Vector4)v141;
			//   UnityEngine::Rendering::ColorParameter::ColorParameter(v142, (Color *)v225, 0, 0LL);
			//   this.fields.charFaceRimColor = v143;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimColor,
			//     v144,
			//     v145,
			//     v146,
			//     overrideStaten,
			//     (String *)methodo,
			//     *(MethodInfo **)&v225[0].x);
			//   v147 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v148 = v147;
			//   if ( !v147 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v147, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charFaceRimDir = v148;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimDir,
			//     v149,
			//     v150,
			//     v151,
			//     overrideStateba,
			//     (String *)methodbb,
			//     *(MethodInfo **)&v225[0].x);
			//   v152 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v153 = v152;
			//   if ( !v152 )
			//     goto LABEL_34;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v152, 1.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charFaceRimIntensity = v153;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimIntensity,
			//     v154,
			//     v155,
			//     v156,
			//     overrideStatebb,
			//     (String *)methodbc,
			//     *(MethodInfo **)&v225[0].x);
			//   v157 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v158 = v157;
			//   if ( !v157
			//     || (UnityEngine::Rendering::BoolParameter::BoolParameter(v157, 0, 0, 0LL),
			//         this.fields.charIgnoreSceneAdditionalLights = v158,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.charIgnoreSceneAdditionalLights,
			//           v159,
			//           v160,
			//           v161,
			//           overrideStateo,
			//           (String *)methodp,
			//           *(MethodInfo **)&v225[0].x),
			//         v162 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter),
			//         (v163 = v162) == 0LL) )
			//   {
			// LABEL_34:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v162, 0, 0, 0LL);
			//   this.fields.charIgnoreSceneEnv = v163;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.charIgnoreSceneEnv, v164, v165, v166, v226, v227, v228);
			// }
			// 
		}

		[Header("角色光照控制")]
		public BoolParameter charMainLightControl;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 5f)]
		public ClampedFloatParameter charMainLightMultiplier;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 3f)]
		public ClampedFloatParameter charEnvLightMultiplier;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 2f)]
		public ClampedFloatParameter charEnvShadowMultiplier;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 2f)]
		public ClampedFloatParameter charMainLightSpecularMultiplier;

		[CharLightVolumeData.ClampedFloatRangeAttribute(-1f, 1f)]
		public ClampedFloatParameter charMainLightRangeBias;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 3f)]
		public ClampedFloatParameter charEyeBaseLightMultiplier;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 3f)]
		public ClampedFloatParameter charEyeHighlightMultiplier;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 3f)]
		public ClampedFloatParameter charEyeScatteringMultiplier;

		public BoolParameter charIgnoreMainLightShadow;

		public HGCharacterVolume.CharacterLightModeParameter charMainLightMode;

		public Vector2Parameter charCustomMainLightDir;

		public Vector2Parameter charCameraFollowMainLightBias;

		public ColorParameter charMainLightOverrideColor;

		public ColorParameter charSkinMainLightOverrideColor;

		[Tooltip("根据场景内光照自动适配适合Dialog等特写下的角色光照表现，场景光照较暗时，增加角色美观性，降低角色和场景的融合度")]
		public BoolParameter charLightDialogMode;

		[Header("角色阴影色调")]
		public HGCharacterVolume.CharacterShadowTintModeParameter charShadowTintControl;

		public ColorParameter charShadowTintColor;

		public ColorParameter charSkinShadowTintColor;

		[Header("角色边缘光")]
		public BoolParameter charAutoRimEnable;

		public ColorParameter charAutoRimColor;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 1f)]
		public ClampedFloatParameter charAutoRimDir;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 10f)]
		public ClampedFloatParameter charAutoRimIntensity;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 1f)]
		public ClampedFloatParameter charAutoRimWidth;

		[Header("脸部边缘光")]
		public BoolParameter charFaceRimEnable;

		public ColorParameter charFaceRimColor;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 1f)]
		public ClampedFloatParameter charFaceRimDir;

		[CharLightVolumeData.ClampedFloatRangeAttribute(0f, 10f)]
		public ClampedFloatParameter charFaceRimIntensity;

		[Header("环境影响")]
		public BoolParameter charIgnoreSceneAdditionalLights;

		public BoolParameter charIgnoreSceneEnv;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static CharLightVolumeData m_DefaultCharLightVolumeData;

		public class ClampedFloatRangeAttribute : Attribute
		{
			public ClampedFloatRangeAttribute(float min, float max)
			{
				// // MinMaxRangeAttribute(Single, Single)
				// void VLB::MinMaxRangeAttribute::MinMaxRangeAttribute(
				//         MinMaxRangeAttribute *this,
				//         float min,
				//         float max,
				//         MethodInfo *method)
				// {
				//   this.fields._minValue_k__BackingField = min;
				//   this.fields._maxValue_k__BackingField = max;
				// }
				// 
			}

			public float min;

			public float max;
		}
	}
}
