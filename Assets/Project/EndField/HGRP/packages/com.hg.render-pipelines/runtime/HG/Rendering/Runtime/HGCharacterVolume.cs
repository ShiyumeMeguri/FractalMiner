using System;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/HGCharacter/CharacterLighting", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class HGCharacterVolume : VolumeComponent
	{
		public HGCharacterVolume()
		{
			// // HGCharacterVolume()
			// void HG::Rendering::Runtime::HGCharacterVolume::HGCharacterVolume(HGCharacterVolume *this, MethodInfo *method)
			// {
			//   CubemapParameter *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   __int64 v5; // rcx
			//   CubemapParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   HGCharacterVolume_CharacterAmbientModeParameter *v10; // rax
			//   HGCharacterVolume_CharacterAmbientModeParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   ClampedFloatParameter *v15; // rax
			//   ClampedFloatParameter *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   Vector2Parameter *v20; // rax
			//   Vector2Parameter *v21; // rdi
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
			//   __int64 v35; // rdi
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   __m128i si128; // xmm9
			//   __int64 v39; // rdi
			//   FileDescriptor *v40; // r8
			//   MessageDescriptor *v41; // r9
			//   __m128i v42; // xmm9
			//   BoolParameter *v43; // rax
			//   BoolParameter *v44; // rdi
			//   OneofDescriptorProto *v45; // rdx
			//   FileDescriptor *v46; // r8
			//   MessageDescriptor *v47; // r9
			//   ClampedFloatParameter *v48; // rax
			//   ClampedFloatParameter *v49; // rdi
			//   OneofDescriptorProto *v50; // rdx
			//   FileDescriptor *v51; // r8
			//   MessageDescriptor *v52; // r9
			//   ClampedFloatParameter *v53; // rax
			//   ClampedFloatParameter *v54; // rdi
			//   OneofDescriptorProto *v55; // rdx
			//   FileDescriptor *v56; // r8
			//   MessageDescriptor *v57; // r9
			//   ClampedFloatParameter *v58; // rax
			//   ClampedFloatParameter *v59; // rdi
			//   OneofDescriptorProto *v60; // rdx
			//   FileDescriptor *v61; // r8
			//   MessageDescriptor *v62; // r9
			//   ClampedFloatParameter *v63; // rax
			//   ClampedFloatParameter *v64; // rdi
			//   OneofDescriptorProto *v65; // rdx
			//   FileDescriptor *v66; // r8
			//   MessageDescriptor *v67; // r9
			//   ClampedFloatParameter *v68; // rax
			//   ClampedFloatParameter *v69; // rdi
			//   OneofDescriptorProto *v70; // rdx
			//   FileDescriptor *v71; // r8
			//   MessageDescriptor *v72; // r9
			//   ClampedFloatParameter *v73; // rax
			//   ClampedFloatParameter *v74; // rdi
			//   OneofDescriptorProto *v75; // rdx
			//   FileDescriptor *v76; // r8
			//   MessageDescriptor *v77; // r9
			//   ClampedFloatParameter *v78; // rax
			//   ClampedFloatParameter *v79; // rdi
			//   OneofDescriptorProto *v80; // rdx
			//   FileDescriptor *v81; // r8
			//   MessageDescriptor *v82; // r9
			//   ClampedFloatParameter *v83; // rax
			//   ClampedFloatParameter *v84; // rdi
			//   OneofDescriptorProto *v85; // rdx
			//   FileDescriptor *v86; // r8
			//   MessageDescriptor *v87; // r9
			//   BoolParameter *v88; // rax
			//   BoolParameter *v89; // rdi
			//   OneofDescriptorProto *v90; // rdx
			//   FileDescriptor *v91; // r8
			//   MessageDescriptor *v92; // r9
			//   HGCharacterVolume_CharacterLightModeParameter *v93; // rax
			//   HGCharacterVolume_CharacterLightModeParameter *v94; // rdi
			//   OneofDescriptorProto *v95; // rdx
			//   FileDescriptor *v96; // r8
			//   MessageDescriptor *v97; // r9
			//   Vector2Parameter *v98; // rax
			//   Vector2Parameter *v99; // rdi
			//   OneofDescriptorProto *v100; // rdx
			//   FileDescriptor *v101; // r8
			//   MessageDescriptor *v102; // r9
			//   Vector2Parameter *v103; // rax
			//   Vector2Parameter *v104; // rdi
			//   OneofDescriptorProto *v105; // rdx
			//   FileDescriptor *v106; // r8
			//   MessageDescriptor *v107; // r9
			//   MethodInfo *v108; // rdx
			//   Vector4 v109; // xmm8
			//   __int64 v110; // rdi
			//   FileDescriptor *v111; // r8
			//   MessageDescriptor *v112; // r9
			//   MethodInfo *v113; // rdx
			//   Vector4 v114; // xmm8
			//   __int64 v115; // rdi
			//   FileDescriptor *v116; // r8
			//   MessageDescriptor *v117; // r9
			//   BoolParameter *v118; // rax
			//   BoolParameter *v119; // rdi
			//   OneofDescriptorProto *v120; // rdx
			//   FileDescriptor *v121; // r8
			//   MessageDescriptor *v122; // r9
			//   HGCharacterVolume_CharacterShadowTintModeParameter *v123; // rax
			//   HGCharacterVolume_CharacterShadowTintModeParameter *v124; // rdi
			//   OneofDescriptorProto *v125; // rdx
			//   FileDescriptor *v126; // r8
			//   MessageDescriptor *v127; // r9
			//   MethodInfo *v128; // rdx
			//   Vector4 v129; // xmm8
			//   __int64 v130; // rdi
			//   FileDescriptor *v131; // r8
			//   MessageDescriptor *v132; // r9
			//   MethodInfo *v133; // rdx
			//   Vector4 v134; // xmm8
			//   __int64 v135; // rdi
			//   FileDescriptor *v136; // r8
			//   MessageDescriptor *v137; // r9
			//   HGCharacterVolume_CharacterModeParameter *v138; // rax
			//   HGCharacterVolume_CharacterModeParameter *v139; // rdi
			//   OneofDescriptorProto *v140; // rdx
			//   FileDescriptor *v141; // r8
			//   MessageDescriptor *v142; // r9
			//   BoolParameter *v143; // rax
			//   BoolParameter *v144; // rdi
			//   OneofDescriptorProto *v145; // rdx
			//   FileDescriptor *v146; // r8
			//   MessageDescriptor *v147; // r9
			//   MethodInfo *v148; // rdx
			//   Vector4 v149; // xmm8
			//   __int64 v150; // rdi
			//   FileDescriptor *v151; // r8
			//   MessageDescriptor *v152; // r9
			//   ClampedFloatParameter *v153; // rax
			//   ClampedFloatParameter *v154; // rdi
			//   OneofDescriptorProto *v155; // rdx
			//   FileDescriptor *v156; // r8
			//   MessageDescriptor *v157; // r9
			//   ClampedFloatParameter *v158; // rax
			//   ClampedFloatParameter *v159; // rdi
			//   OneofDescriptorProto *v160; // rdx
			//   FileDescriptor *v161; // r8
			//   MessageDescriptor *v162; // r9
			//   ClampedFloatParameter *v163; // rax
			//   ClampedFloatParameter *v164; // rdi
			//   OneofDescriptorProto *v165; // rdx
			//   FileDescriptor *v166; // r8
			//   MessageDescriptor *v167; // r9
			//   ClampedFloatParameter *v168; // rax
			//   ClampedFloatParameter *v169; // rdi
			//   OneofDescriptorProto *v170; // rdx
			//   FileDescriptor *v171; // r8
			//   MessageDescriptor *v172; // r9
			//   BoolParameter *v173; // rax
			//   BoolParameter *v174; // rdi
			//   OneofDescriptorProto *v175; // rdx
			//   FileDescriptor *v176; // r8
			//   MessageDescriptor *v177; // r9
			//   BoolParameter *v178; // rax
			//   BoolParameter *v179; // rdi
			//   OneofDescriptorProto *v180; // rdx
			//   FileDescriptor *v181; // r8
			//   MessageDescriptor *v182; // r9
			//   MethodInfo *v183; // rdx
			//   Vector4 v184; // xmm8
			//   __int64 v185; // rdi
			//   FileDescriptor *v186; // r8
			//   MessageDescriptor *v187; // r9
			//   ClampedFloatParameter *v188; // rax
			//   ClampedFloatParameter *v189; // rdi
			//   OneofDescriptorProto *v190; // rdx
			//   FileDescriptor *v191; // r8
			//   MessageDescriptor *v192; // r9
			//   ClampedFloatParameter *v193; // rax
			//   ClampedFloatParameter *v194; // rdi
			//   OneofDescriptorProto *v195; // rdx
			//   FileDescriptor *v196; // r8
			//   MessageDescriptor *v197; // r9
			//   BoolParameter *v198; // rax
			//   BoolParameter *v199; // rdi
			//   OneofDescriptorProto *v200; // rdx
			//   FileDescriptor *v201; // r8
			//   MessageDescriptor *v202; // r9
			//   HGCharacterVolume_CharacterEnvironmentEffectModeParameter *v203; // rax
			//   HGCharacterVolume_CharacterEnvironmentEffectModeParameter *v204; // rdi
			//   OneofDescriptorProto *v205; // rdx
			//   FileDescriptor *v206; // r8
			//   MessageDescriptor *v207; // r9
			//   ClampedFloatParameter *v208; // rax
			//   ClampedFloatParameter *v209; // rdi
			//   OneofDescriptorProto *v210; // rdx
			//   FileDescriptor *v211; // r8
			//   MessageDescriptor *v212; // r9
			//   ClampedFloatParameter *v213; // rax
			//   ClampedFloatParameter *v214; // rdi
			//   OneofDescriptorProto *v215; // rdx
			//   FileDescriptor *v216; // r8
			//   MessageDescriptor *v217; // r9
			//   ClampedFloatParameter *v218; // rax
			//   ClampedFloatParameter *v219; // rdi
			//   OneofDescriptorProto *v220; // rdx
			//   FileDescriptor *v221; // r8
			//   MessageDescriptor *v222; // r9
			//   ClampedFloatParameter *v223; // rax
			//   ClampedFloatParameter *v224; // rdi
			//   OneofDescriptorProto *v225; // rdx
			//   FileDescriptor *v226; // r8
			//   MessageDescriptor *v227; // r9
			//   BoolParameter *v228; // rax
			//   BoolParameter *v229; // rdi
			//   OneofDescriptorProto *v230; // rdx
			//   FileDescriptor *v231; // r8
			//   MessageDescriptor *v232; // r9
			//   BoolParameter *v233; // rax
			//   BoolParameter *v234; // rdi
			//   OneofDescriptorProto *v235; // rdx
			//   FileDescriptor *v236; // r8
			//   MessageDescriptor *v237; // r9
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v238; // rax
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v239; // rdi
			//   OneofDescriptorProto *v240; // rdx
			//   FileDescriptor *v241; // r8
			//   MessageDescriptor *v242; // r9
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v243; // rax
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v244; // rdi
			//   OneofDescriptorProto *v245; // rdx
			//   FileDescriptor *v246; // r8
			//   MessageDescriptor *v247; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebb; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebc; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebd; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebe; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebf; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebg; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebh; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebi; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebj; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebk; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebl; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStaten; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateo; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatep; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateq; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStater; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebm; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebn; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebo; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebp; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStates; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatet; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateu; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebq; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebr; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatev; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatew; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebs; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebt; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebu; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatebv; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatex; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatey; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStatez; // [rsp+20h] [rbp-78h]
			//   String__Array *overrideStateba; // [rsp+20h] [rbp-78h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbc; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbd; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbe; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbf; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbg; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbh; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbi; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbj; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbk; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbl; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbm; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbn; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbo; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbp; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbq; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodt; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodu; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodv; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbr; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbs; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodw; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodx; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbt; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbu; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbv; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbw; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methody; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodz; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodba; // [rsp+28h] [rbp-70h]
			//   MethodInfo *methodbb; // [rsp+28h] [rbp-70h]
			//   Vector4 v346; // [rsp+30h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D8ED9D1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterAmbientModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterEnvironmentEffectModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CubemapParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//     byte_18D8ED9D1 = 1;
			//   }
			//   v3 = (CubemapParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::CubemapParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::CubemapParameter::CubemapParameter(v3, 0LL, 0, 0LL);
			//   this.fields.charMaxCubemap = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMaxCubemap,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v346.x);
			//   v10 = (HGCharacterVolume_CharacterAmbientModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterAmbientModeParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_69;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterAmbientModeParameter::CharacterAmbientModeParameter(
			//     v10,
			//     HGCharacterVolume_CharacterAmbientMode__Enum_Default,
			//     0,
			//     0LL);
			//   this.fields.charAmbientModeIndex = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAmbientModeIndex,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v346.x);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 1.0, 0.0, 5.0, 1, 0LL);
			//   this.fields.charAmbientLightBaseIntensity = v16;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAmbientLightBaseIntensity,
			//     v17,
			//     v18,
			//     v19,
			//     overrideStatebb,
			//     (String *)methodbc,
			//     *(MethodInfo **)&v346.x);
			//   v20 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v20,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x43340000u, (__m128)0LL),
			//     1,
			//     0LL);
			//   this.fields.charAmbientLightCustomDir = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAmbientLightCustomDir,
			//     v22,
			//     v23,
			//     v24,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v346.x);
			//   v25 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v25, 0.60000002, 0.0, 5.0, 1, 0LL);
			//   this.fields.charAmbientLightDirIntensity = v26;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAmbientLightDirIntensity,
			//     v27,
			//     v28,
			//     v29,
			//     overrideStatebc,
			//     (String *)methodbd,
			//     *(MethodInfo **)&v346.x);
			//   v30 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v30, 0.15000001, -0.5, 0.5, 1, 0LL);
			//   this.fields.charAmbientLightDirParam = v31;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAmbientLightDirParam,
			//     v32,
			//     v33,
			//     v34,
			//     overrideStatebd,
			//     (String *)methodbe,
			//     *(MethodInfo **)&v346.x);
			//   v35 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v35 )
			//     goto LABEL_69;
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v35 + 24) = si128;
			//   *(_BYTE *)(v35 + 16) = 0;
			//   this.fields.charGlobalAmbientParam0 = (Vector4Parameter *)v35;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charGlobalAmbientParam0,
			//     v4,
			//     v36,
			//     v37,
			//     overrideStatec,
			//     (String *)methodd,
			//     *(MethodInfo **)&v346.x);
			//   v39 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v39 )
			//     goto LABEL_69;
			//   v42 = _mm_load_si128((const __m128i *)&xmmword_18A357DD0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v39 + 24) = v42;
			//   *(_BYTE *)(v39 + 16) = 0;
			//   this.fields.charGlobalAmbientParam1 = (Vector4Parameter *)v39;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charGlobalAmbientParam1,
			//     v4,
			//     v40,
			//     v41,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v346.x);
			//   v43 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v44 = v43;
			//   if ( !v43 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v43, 0, 0, 0LL);
			//   this.fields.charMainLightControl = v44;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightControl,
			//     v45,
			//     v46,
			//     v47,
			//     overrideStatee,
			//     (String *)methodf,
			//     *(MethodInfo **)&v346.x);
			//   v48 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v49 = v48;
			//   if ( !v48 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v48, 1.0, 0.0, 5.0, 0, 0LL);
			//   this.fields.charMainLightMultiplier = v49;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightMultiplier,
			//     v50,
			//     v51,
			//     v52,
			//     overrideStatebe,
			//     (String *)methodbf,
			//     *(MethodInfo **)&v346.x);
			//   v53 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v54 = v53;
			//   if ( !v53 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v53, 0.69999999, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEnvLightMultiplier = v54;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEnvLightMultiplier,
			//     v55,
			//     v56,
			//     v57,
			//     overrideStatebf,
			//     (String *)methodbg,
			//     *(MethodInfo **)&v346.x);
			//   v58 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v59 = v58;
			//   if ( !v58 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v58, 1.0, 0.0, 2.0, 0, 0LL);
			//   this.fields.charEnvShadowMultiplier = v59;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEnvShadowMultiplier,
			//     v60,
			//     v61,
			//     v62,
			//     overrideStatebg,
			//     (String *)methodbh,
			//     *(MethodInfo **)&v346.x);
			//   v63 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v64 = v63;
			//   if ( !v63 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v63, 1.0, 0.0, 2.0, 0, 0LL);
			//   this.fields.charMainLightSpecularMultiplier = v64;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightSpecularMultiplier,
			//     v65,
			//     v66,
			//     v67,
			//     overrideStatebh,
			//     (String *)methodbi,
			//     *(MethodInfo **)&v346.x);
			//   v68 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v69 = v68;
			//   if ( !v68 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v68, 0.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEyeBaseLightMultiplier = v69;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEyeBaseLightMultiplier,
			//     v70,
			//     v71,
			//     v72,
			//     overrideStatebi,
			//     (String *)methodbj,
			//     *(MethodInfo **)&v346.x);
			//   v73 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v74 = v73;
			//   if ( !v73 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v73, 0.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEyeHighlightMultiplier = v74;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEyeHighlightMultiplier,
			//     v75,
			//     v76,
			//     v77,
			//     overrideStatebj,
			//     (String *)methodbk,
			//     *(MethodInfo **)&v346.x);
			//   v78 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v79 = v78;
			//   if ( !v78 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v78, 0.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.charEyeScatteringMultiplier = v79;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEyeScatteringMultiplier,
			//     v80,
			//     v81,
			//     v82,
			//     overrideStatebk,
			//     (String *)methodbl,
			//     *(MethodInfo **)&v346.x);
			//   v83 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v84 = v83;
			//   if ( !v83 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v83, 0.0, -1.0, 1.0, 0, 0LL);
			//   this.fields.charMainLightRangeBias = v84;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightRangeBias,
			//     v85,
			//     v86,
			//     v87,
			//     overrideStatebl,
			//     (String *)methodbm,
			//     *(MethodInfo **)&v346.x);
			//   v88 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v89 = v88;
			//   if ( !v88 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v88, 0, 0, 0LL);
			//   this.fields.charIgnoreMainLightShadow = v89;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charIgnoreMainLightShadow,
			//     v90,
			//     v91,
			//     v92,
			//     overrideStatef,
			//     (String *)methodg,
			//     *(MethodInfo **)&v346.x);
			//   v93 = (HGCharacterVolume_CharacterLightModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter);
			//   v94 = v93;
			//   if ( !v93 )
			//     goto LABEL_69;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter::CharacterLightModeParameter(
			//     v93,
			//     HGCharacterVolume_CharacterLightMode__Enum_Scene,
			//     0,
			//     0LL);
			//   this.fields.charMainLightMode = v94;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightMode,
			//     v95,
			//     v96,
			//     v97,
			//     overrideStateg,
			//     (String *)methodh,
			//     *(MethodInfo **)&v346.x);
			//   v98 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v99 = v98;
			//   if ( !v98 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v98,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41F00000u, (__m128)0x43160000u),
			//     1,
			//     0LL);
			//   this.fields.charCustomMainLightDir = v99;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charCustomMainLightDir,
			//     v100,
			//     v101,
			//     v102,
			//     overrideStateh,
			//     (String *)methodi,
			//     *(MethodInfo **)&v346.x);
			//   v103 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v104 = v103;
			//   if ( !v103 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v103,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x41F00000u, (__m128)0x41200000u),
			//     1,
			//     0LL);
			//   this.fields.charCameraFollowMainLightBias = v104;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charCameraFollowMainLightBias,
			//     v105,
			//     v106,
			//     v107,
			//     overrideStatei,
			//     (String *)methodj,
			//     *(MethodInfo **)&v346.x);
			//   v109 = *UnityEngine::Vector4::get_one(&v346, v108);
			//   v110 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v110 )
			//     goto LABEL_69;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v110 + 41) = 257;
			//   *(Vector4 *)(v110 + 24) = v109;
			//   *(_BYTE *)(v110 + 16) = 0;
			//   this.fields.charMainLightOverrideColor = (ColorParameter *)v110;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charMainLightOverrideColor,
			//     v4,
			//     v111,
			//     v112,
			//     overrideStatej,
			//     (String *)methodk,
			//     *(MethodInfo **)&v346.x);
			//   v114 = *UnityEngine::Vector4::get_one(&v346, v113);
			//   v115 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v115 )
			//     goto LABEL_69;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v115 + 41) = 257;
			//   *(Vector4 *)(v115 + 24) = v114;
			//   *(_BYTE *)(v115 + 16) = 0;
			//   this.fields.charSkinMainLightOverrideColor = (ColorParameter *)v115;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charSkinMainLightOverrideColor,
			//     v4,
			//     v116,
			//     v117,
			//     overrideStatek,
			//     (String *)methodl,
			//     *(MethodInfo **)&v346.x);
			//   v118 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v119 = v118;
			//   if ( !v118 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v118, 0, 0, 0LL);
			//   this.fields.charLightDialogMode = v119;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charLightDialogMode,
			//     v120,
			//     v121,
			//     v122,
			//     overrideStatel,
			//     (String *)methodm,
			//     *(MethodInfo **)&v346.x);
			//   v123 = (HGCharacterVolume_CharacterShadowTintModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter);
			//   v124 = v123;
			//   if ( !v123 )
			//     goto LABEL_69;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter::CharacterShadowTintModeParameter(
			//     v123,
			//     HGCharacterVolume_CharacterShadowTintMode__Enum_Auto,
			//     0,
			//     0LL);
			//   this.fields.charShadowTintControl = v124;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charShadowTintControl,
			//     v125,
			//     v126,
			//     v127,
			//     overrideStatem,
			//     (String *)methodn,
			//     *(MethodInfo **)&v346.x);
			//   v129 = *UnityEngine::Vector4::get_one(&v346, v128);
			//   v130 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v130 )
			//     goto LABEL_69;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v130 + 41) = 257;
			//   *(Vector4 *)(v130 + 24) = v129;
			//   *(_BYTE *)(v130 + 16) = 0;
			//   this.fields.charShadowTintColor = (ColorParameter *)v130;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charShadowTintColor,
			//     v4,
			//     v131,
			//     v132,
			//     overrideStaten,
			//     (String *)methodo,
			//     *(MethodInfo **)&v346.x);
			//   v134 = *UnityEngine::Vector4::get_one(&v346, v133);
			//   v135 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v135 )
			//     goto LABEL_69;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v135 + 41) = 257;
			//   *(Vector4 *)(v135 + 24) = v134;
			//   *(_BYTE *)(v135 + 16) = 0;
			//   this.fields.charSkinShadowTintColor = (ColorParameter *)v135;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charSkinShadowTintColor,
			//     v4,
			//     v136,
			//     v137,
			//     overrideStateo,
			//     (String *)methodp,
			//     *(MethodInfo **)&v346.x);
			//   v138 = (HGCharacterVolume_CharacterModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterModeParameter);
			//   v139 = v138;
			//   if ( !v138 )
			//     goto LABEL_69;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterModeParameter::CharacterModeParameter(
			//     v138,
			//     HGCharacterVolume_CharacterShadowMode__Enum_CameraVirtualLight,
			//     0,
			//     0LL);
			//   this.fields.charShadowMode = v139;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charShadowMode,
			//     v140,
			//     v141,
			//     v142,
			//     overrideStatep,
			//     (String *)methodq,
			//     *(MethodInfo **)&v346.x);
			//   v143 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v144 = v143;
			//   if ( !v143 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v143, 0, 0, 0LL);
			//   this.fields.charAutoRimEnable = v144;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimEnable,
			//     v145,
			//     v146,
			//     v147,
			//     overrideStateq,
			//     (String *)methodr,
			//     *(MethodInfo **)&v346.x);
			//   v149 = *UnityEngine::Vector4::get_one(&v346, v148);
			//   v150 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v150 )
			//     goto LABEL_69;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v150 + 41) = 257;
			//   *(Vector4 *)(v150 + 24) = v149;
			//   *(_BYTE *)(v150 + 16) = 0;
			//   this.fields.charAutoRimColor = (ColorParameter *)v150;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimColor,
			//     v4,
			//     v151,
			//     v152,
			//     overrideStater,
			//     (String *)methods,
			//     *(MethodInfo **)&v346.x);
			//   v153 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v154 = v153;
			//   if ( !v153 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v153, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charAutoRimDir = v154;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimDir,
			//     v155,
			//     v156,
			//     v157,
			//     overrideStatebm,
			//     (String *)methodbn,
			//     *(MethodInfo **)&v346.x);
			//   v158 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v159 = v158;
			//   if ( !v158 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v158, 1.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charAutoRimIntensity = v159;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimIntensity,
			//     v160,
			//     v161,
			//     v162,
			//     overrideStatebn,
			//     (String *)methodbo,
			//     *(MethodInfo **)&v346.x);
			//   v163 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v164 = v163;
			//   if ( !v163 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v163, 0.40000001, 0.0, 1.0, 0, 0LL);
			//   this.fields.charAutoRimWidth = v164;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimWidth,
			//     v165,
			//     v166,
			//     v167,
			//     overrideStatebo,
			//     (String *)methodbp,
			//     *(MethodInfo **)&v346.x);
			//   v168 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v169 = v168;
			//   if ( !v168 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v168, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charAutoRimAlbedo = v169;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimAlbedo,
			//     v170,
			//     v171,
			//     v172,
			//     overrideStatebp,
			//     (String *)methodbq,
			//     *(MethodInfo **)&v346.x);
			//   v173 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v174 = v173;
			//   if ( !v173 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v173, 0, 0, 0LL);
			//   this.fields.charAutoRimMode = v174;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charAutoRimMode,
			//     v175,
			//     v176,
			//     v177,
			//     overrideStates,
			//     (String *)methodt,
			//     *(MethodInfo **)&v346.x);
			//   v178 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v179 = v178;
			//   if ( !v178 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v178, 0, 0, 0LL);
			//   this.fields.charFaceRimEnable = v179;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimEnable,
			//     v180,
			//     v181,
			//     v182,
			//     overrideStatet,
			//     (String *)methodu,
			//     *(MethodInfo **)&v346.x);
			//   v184 = *UnityEngine::Vector4::get_one(&v346, v183);
			//   v185 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v185 )
			//     goto LABEL_69;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v185 + 41) = 257;
			//   *(Vector4 *)(v185 + 24) = v184;
			//   *(_BYTE *)(v185 + 16) = 0;
			//   this.fields.charFaceRimColor = (ColorParameter *)v185;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimColor,
			//     v4,
			//     v186,
			//     v187,
			//     overrideStateu,
			//     (String *)methodv,
			//     *(MethodInfo **)&v346.x);
			//   v188 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v189 = v188;
			//   if ( !v188 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v188, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charFaceRimDir = v189;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimDir,
			//     v190,
			//     v191,
			//     v192,
			//     overrideStatebq,
			//     (String *)methodbr,
			//     *(MethodInfo **)&v346.x);
			//   v193 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v194 = v193;
			//   if ( !v193 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v193, 1.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charFaceRimIntensity = v194;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charFaceRimIntensity,
			//     v195,
			//     v196,
			//     v197,
			//     overrideStatebr,
			//     (String *)methodbs,
			//     *(MethodInfo **)&v346.x);
			//   v198 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v199 = v198;
			//   if ( !v198 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v198, 0, 0, 0LL);
			//   this.fields.charRainEffectPreviewEnable = v199;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charRainEffectPreviewEnable,
			//     v200,
			//     v201,
			//     v202,
			//     overrideStatev,
			//     (String *)methodw,
			//     *(MethodInfo **)&v346.x);
			//   v203 = (HGCharacterVolume_CharacterEnvironmentEffectModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterEnvironmentEffectModeParameter);
			//   v204 = v203;
			//   if ( !v203 )
			//     goto LABEL_69;
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterEnvironmentEffectModeParameter::CharacterEnvironmentEffectModeParameter(
			//     v203,
			//     HGCharacterVolume_CharacterEnvironmentEffectMode__Enum_Rain,
			//     0,
			//     0LL);
			//   this.fields.charEnvironmentEffectMode = v204;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charEnvironmentEffectMode,
			//     v205,
			//     v206,
			//     v207,
			//     overrideStatew,
			//     (String *)methodx,
			//     *(MethodInfo **)&v346.x);
			//   v208 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v209 = v208;
			//   if ( !v208 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v208, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charSnowEffectPreviewIntensity = v209;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charSnowEffectPreviewIntensity,
			//     v210,
			//     v211,
			//     v212,
			//     overrideStatebs,
			//     (String *)methodbt,
			//     *(MethodInfo **)&v346.x);
			//   v213 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v214 = v213;
			//   if ( !v213 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v213, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.charRainEffectPreviewIntensity = v214;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charRainEffectPreviewIntensity,
			//     v215,
			//     v216,
			//     v217,
			//     overrideStatebt,
			//     (String *)methodbu,
			//     *(MethodInfo **)&v346.x);
			//   v218 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v219 = v218;
			//   if ( !v218 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v218, -100.0, -100.0, 200.0, 0, 0LL);
			//   this.fields.charWetEffectPreviewWorldHeight = v219;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charWetEffectPreviewWorldHeight,
			//     v220,
			//     v221,
			//     v222,
			//     overrideStatebu,
			//     (String *)methodbv,
			//     *(MethodInfo **)&v346.x);
			//   v223 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v224 = v223;
			//   if ( !v223 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v223, 2.0, 0.1, 10.0, 0, 0LL);
			//   this.fields.charRainEffectTextureTiling = v224;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charRainEffectTextureTiling,
			//     v225,
			//     v226,
			//     v227,
			//     overrideStatebv,
			//     (String *)methodbw,
			//     *(MethodInfo **)&v346.x);
			//   v228 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v229 = v228;
			//   if ( !v228 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v228, 0, 0, 0LL);
			//   this.fields.charIgnoreSceneAdditionalLights = v229;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charIgnoreSceneAdditionalLights,
			//     v230,
			//     v231,
			//     v232,
			//     overrideStatex,
			//     (String *)methody,
			//     *(MethodInfo **)&v346.x);
			//   v233 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v234 = v233;
			//   if ( !v233 )
			//     goto LABEL_69;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v233, 0, 0, 0LL);
			//   this.fields.charIgnoreSceneEnv = v234;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charIgnoreSceneEnv,
			//     v235,
			//     v236,
			//     v237,
			//     overrideStatey,
			//     (String *)methodz,
			//     *(MethodInfo **)&v346.x);
			//   v238 = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter);
			//   v239 = v238;
			//   if ( !v238
			//     || (HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter::CharacterRenderFeatureQualityTierParameter(
			//           v238,
			//           HGCharacterVolume_CharacterRenderFeatureQualityTier__Enum_Tier20,
			//           0,
			//           0LL),
			//         this.fields.charOutlineQualityMode = v239,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.charOutlineQualityMode,
			//           v240,
			//           v241,
			//           v242,
			//           overrideStatez,
			//           (String *)methodba,
			//           *(MethodInfo **)&v346.x),
			//         v243 = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter),
			//         (v244 = v243) == 0LL) )
			//   {
			// LABEL_69:
			//     sub_180B536AC(v5, v4);
			//   }
			//   HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter::CharacterRenderFeatureQualityTierParameter(
			//     v243,
			//     HGCharacterVolume_CharacterRenderFeatureQualityTier__Enum_Tier20,
			//     0,
			//     0LL);
			//   this.fields.charSelfShadowQualityMode = v244;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.charSelfShadowQualityMode,
			//     v245,
			//     v246,
			//     v247,
			//     overrideStateba,
			//     (String *)methodbb,
			//     *(MethodInfo **)&v346.x);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public void SetCharMaxCubemap(Texture texture)
		{
			// // Void SetCharMaxCubemap(Texture)
			// void HG::Rendering::Runtime::HGCharacterVolume::SetCharMaxCubemap(
			//         HGCharacterVolume *this,
			//         Texture *texture,
			//         MethodInfo *method)
			// {
			//   CubemapParameter *v5; // rdx
			//   __int64 v6; // rcx
			//   CubemapParameter *charMaxCubemap; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2222, 0LL) )
			//   {
			//     charMaxCubemap = this.fields.charMaxCubemap;
			//     if ( charMaxCubemap )
			//     {
			//       charMaxCubemap.fields._._.overrideState = 1;
			//       v5 = this.fields.charMaxCubemap;
			//       if ( v5 )
			//       {
			//         sub_180086B00(v6, v5, texture);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2222, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)texture,
			//     0LL);
			// }
			// 
		}

		public bool GetCharOutlinePassEnableState()
		{
			// // Boolean GetCharOutlinePassEnableState()
			// bool HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *wrapperArray; // rdx
			//   int32_t v6; // eax
			//   __int64 v7; // rdx
			//   struct HGCharacterQualitySettings__Class *v8; // rcx
			//   int32_t v9; // ebx
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9CE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
			//     byte_18D8ED9CE = 1;
			//   }
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
			//   wrapperArray = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.fields._.m_Value <= 889 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v11 = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			// LABEL_13:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( v11.fields._.m_Value <= 0x379u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( v11[223].monitor )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(889, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_13;
			//   }
			// LABEL_9:
			//   wrapperArray = this.fields.charOutlineQualityMode;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   v6 = sub_18003ED00(10LL);
			//   v8 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//   v9 = v6;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings, v7);
			//     v8 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//   }
			//   return v8.static_fields.characterOutlineTierLevel >= v9;
			// }
			// 
			return default(bool);
		}

		public bool GetCharShadowPassEnableState()
		{
			// // Boolean GetCharShadowPassEnableState()
			// bool HG::Rendering::Runtime::HGCharacterVolume::GetCharShadowPassEnableState(
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *wrapperArray; // rdx
			//   int32_t v6; // eax
			//   __int64 v7; // rdx
			//   struct HGCharacterQualitySettings__Class *v8; // rcx
			//   int32_t v9; // ebx
			//   HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9CF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
			//     byte_18D8ED9CF = 1;
			//   }
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
			//   wrapperArray = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.fields._.m_Value <= 719 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v11 = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			// LABEL_13:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( v11.fields._.m_Value <= 0x2CFu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( *(_QWORD *)&v11[180].fields._.m_Value )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(719, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_13;
			//   }
			// LABEL_9:
			//   wrapperArray = this.fields.charSelfShadowQualityMode;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   v6 = sub_18003ED00(10LL);
			//   v8 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//   v9 = v6;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings, v7);
			//     v8 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//   }
			//   return v8.static_fields.characterShadowTierLevel >= v9;
			// }
			// 
			return default(bool);
		}

		[IDTag(1)]
		public Vector3 GetCharLightVector(Transform cameraTransform)
		{
			// // Vector3 GetCharLightVector(Transform)
			// Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVector(
			//         Vector3 *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         Transform *cameraTransform,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   _DWORD *wrapperArray; // rdx
			//   Vector2Parameter *charCustomMainLightDir; // rbx
			//   float v10; // xmm8_4
			//   Vector2 (*v11)(PQSFilter *, MethodInfo *); // rax
			//   __m128 v12; // xmm6
			//   __m128 y_low; // xmm7
			//   __m128 v14; // xmm0
			//   __m128 v15; // xmm10
			//   __m128 v16; // xmm7
			//   __m128 v17; // xmm6
			//   unsigned __int64 v18; // xmm0_8
			//   float z; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v22; // rax
			//   __int64 v23; // xmm0_8
			//   Vector3 *forward; // rax
			//   __int64 v25; // xmm0_8
			//   float v26; // xmm9_4
			//   __int64 v27; // rax
			//   ILFixDynamicMethodWrapper_2 *v28; // rax
			//   Vector3 *v29; // rax
			//   Quaternion v30; // [rsp+30h] [rbp-78h] BYREF
			//   Quaternion v31; // [rsp+40h] [rbp-68h] BYREF
			//   unsigned __int64 v32; // [rsp+B0h] [rbp+8h]
			//   float v33; // [rsp+B0h] [rbp+8h]
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( (int)wrapperArray[6] > 833 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v7.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray[6] <= 0x341u )
			//       goto LABEL_43;
			//     if ( *((_QWORD *)wrapperArray + 837) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(833, 0LL);
			//       if ( Patch )
			//       {
			//         v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_324(
			//                 (Vector3 *)&v30,
			//                 Patch,
			//                 (Object *)this,
			//                 (Object *)cameraTransform,
			//                 0LL);
			//         v23 = *(_QWORD *)&v22.x;
			//         *(float *)&v22 = v22.z;
			//         *(_QWORD *)&retstr.x = v23;
			//         LODWORD(retstr.z) = (_DWORD)v22;
			//         return retstr;
			//       }
			//       goto LABEL_22;
			//     }
			//   }
			//   charCustomMainLightDir = this.fields.charCustomMainLightDir;
			//   if ( !charCustomMainLightDir )
			//     goto LABEL_22;
			//   sub_180003EE0(charCustomMainLightDir.klass);
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)Beyond::Gameplay::Core::PQSFilter::get_factorRange;
			//   v10 = 0.0;
			//   v11 = (Vector2 (*)(PQSFilter *, MethodInfo *))charCustomMainLightDir.klass.vtable.get_value.method;
			//   v32 = v11 == Beyond::Gameplay::Core::PQSFilter::get_factorRange
			//       ? _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]
			//       : ((__int64 (__fastcall *)(Vector2Parameter *, Il2CppMethodPointer))v11)(
			//           charCustomMainLightDir,
			//           charCustomMainLightDir.klass.vtable.set_value.methodPtr);
			//   wrapperArray = this.fields.charMainLightMode;
			//   v12 = (__m128)(unsigned int)v32;
			//   y_low = (__m128)HIDWORD(v32);
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( (unsigned int)sub_18003ED00(10LL) == 1 )
			//   {
			//     if ( !cameraTransform )
			//       goto LABEL_22;
			//     forward = UnityEngine::Transform::get_forward((Vector3 *)&v31, cameraTransform, 0LL);
			//     v25 = *(_QWORD *)&forward.x;
			//     *(float *)&forward = forward.z;
			//     *(_QWORD *)&v30.x = v25;
			//     LODWORD(v30.z) = (_DWORD)forward;
			//     v30 = *UnityEngine::Quaternion::LookRotation(&v31, (Vector3 *)&v30, 0LL);
			//     *(_QWORD *)&v30.x = *(_QWORD *)sub_182504AA0(&v31, &v30);
			//     if ( v30.x > 180.0 )
			//       v10 = 360.0;
			//     wrapperArray = this.fields.charCameraFollowMainLightBias;
			//     v26 = v30.x - v10;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     v27 = sub_18004A780(10LL);
			//     wrapperArray = this.fields.charCameraFollowMainLightBias;
			//     y_low = (__m128)LODWORD(v30.y);
			//     y_low.m128_f32[0] = v30.y + *((float *)&v27 + 1);
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     LODWORD(v33) = sub_18004A780(10LL);
			//     v12 = (__m128)LODWORD(v33);
			//     v12.m128_f32[0] = fmaxf(v33, v26);
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( (int)wrapperArray[6] > 834 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( !v7 )
			//       goto LABEL_22;
			//     if ( LODWORD(v7._0.namespaze) > 0x342 )
			//     {
			//       if ( !v7[17].vtable.Equals.methodPtr )
			//         goto LABEL_18;
			//       v28 = IFix::WrappersManagerImpl::GetPatch(834, 0LL);
			//       if ( v28 )
			//       {
			//         v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_323(
			//                 (Vector3 *)&v31,
			//                 v28,
			//                 (Object *)this,
			//                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v12, y_low),
			//                 0LL);
			//         v18 = *(_QWORD *)&v29.x;
			//         z = v29.z;
			//         goto LABEL_19;
			//       }
			// LABEL_22:
			//       sub_180B536AC(v7, wrapperArray);
			//     }
			// LABEL_43:
			//     sub_180070270(v7, wrapperArray);
			//   }
			// LABEL_18:
			//   v14 = (__m128)((unsigned __int64)sub_182C9F010(_mm_unpacklo_ps(v12, y_low).m128_u64[0]) >> 32);
			//   *(double *)v14.m128_u64 = Beyond::DampingMath::sinf();
			//   v15 = v14;
			//   *(double *)v14.m128_u64 = Beyond::DampingMath::cosf();
			//   v15.m128_f32[0] = v15.m128_f32[0] * v14.m128_f32[0];
			//   v16 = (__m128)COERCE_UNSIGNED_INT64(Beyond::DampingMath::sinf());
			//   v17 = (__m128)COERCE_UNSIGNED_INT64(Beyond::DampingMath::cosf());
			//   *(double *)v14.m128_u64 = Beyond::DampingMath::cosf();
			//   v17.m128_f32[0] = v17.m128_f32[0] * v14.m128_f32[0];
			//   v18 = _mm_unpacklo_ps(
			//           _mm_xor_ps(v15, (__m128)0x80000000),
			//           _mm_xor_ps(_mm_xor_ps(v16, (__m128)0x80000000), (__m128)0x80000000)).m128_u64[0];
			//   z = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)_mm_xor_ps(v17, (__m128)0x80000000)));
			// LABEL_19:
			//   *(_QWORD *)&retstr.x = v18;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public Vector3 GetCharLightVector(Vector2 rotation)
		{
			// // Vector3 GetCharLightVector(Vector2)
			// Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVector(
			//         Vector3 *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         Vector2 rotation,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double v9; // xmm0_8
			//   float v10; // xmm6_4
			//   double v11; // xmm0_8
			//   double v12; // xmm0_8
			//   double v13; // xmm0_8
			//   float v14; // xmm6_4
			//   double v15; // xmm0_8
			//   Vector3 *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v18; // rax
			//   __int64 v19; // xmm0_8
			//   Vector3 v20; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 834 )
			//   {
			// LABEL_7:
			//     ((void (__fastcall *)(_QWORD))sub_182C9F010)(rotation);
			//     v9 = Beyond::DampingMath::sinf();
			//     v10 = *(float *)&v9;
			//     v11 = Beyond::DampingMath::cosf();
			//     retstr.x = -(float)(v10 * *(float *)&v11);
			//     v12 = Beyond::DampingMath::sinf();
			//     retstr.y = *(float *)&v12;
			//     v13 = Beyond::DampingMath::cosf();
			//     v14 = *(float *)&v13;
			//     v15 = Beyond::DampingMath::cosf();
			//     result = retstr;
			//     retstr.z = -(float)(v14 * *(float *)&v15);
			//     return result;
			//   }
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   if ( LODWORD(v7._0.namespaze) <= 0x342 )
			//     sub_180070270(v7, wrapperArray);
			//   if ( !v7[17].vtable.Equals.methodPtr )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(834, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v7, wrapperArray);
			//   v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_323(&v20, Patch, (Object *)this, rotation, 0LL);
			//   v19 = *(_QWORD *)&v18.x;
			//   *(float *)&v18 = v18.z;
			//   *(_QWORD *)&retstr.x = v19;
			//   LODWORD(retstr.z) = (_DWORD)v18;
			//   return retstr;
			// }
			// 
			return null;
		}

		public Vector3 GetCharAutoRimVector(float directionAngle)
		{
			// // Vector3 GetCharAutoRimVector(Single)
			// Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharAutoRimVector(
			//         Vector3 *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         float directionAngle,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double v8; // xmm0_8
			//   double v9; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm0_8
			//   Vector3 v14; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 832 )
			//   {
			//     if ( !v6._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v6, wrapperArray);
			//       v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//     if ( v6 )
			//     {
			//       if ( LODWORD(v6._0.namespaze) <= 0x340 )
			//         sub_180070270(v6, wrapperArray);
			//       if ( !*(_QWORD *)&v6[17]._1.interfaces_count )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(832, 0LL);
			//       if ( Patch )
			//       {
			//         v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_322(&v14, Patch, (Object *)this, directionAngle, 0LL);
			//         v13 = *(_QWORD *)&v12.x;
			//         *(float *)&v12 = v12.z;
			//         *(_QWORD *)&retstr.x = v13;
			//         LODWORD(retstr.z) = (_DWORD)v12;
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v6, wrapperArray);
			//   }
			// LABEL_7:
			//   v8 = Beyond::DampingMath::sinf();
			//   retstr.x = *(float *)&v8;
			//   v9 = Beyond::DampingMath::cosf();
			//   *(_QWORD *)&retstr.y = LODWORD(v9);
			//   return retstr;
			// }
			// 
			return null;
		}

		public Vector3 GetCharFaceRimVector(float directionAngle)
		{
			// // Vector3 GetCharFaceRimVector(Single)
			// Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharFaceRimVector(
			//         Vector3 *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         float directionAngle,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double v8; // xmm0_8
			//   double v9; // xmm0_8
			//   Vector3 *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm0_8
			//   Vector3 v14; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 835 )
			//   {
			// LABEL_7:
			//     v8 = Beyond::DampingMath::sinf();
			//     retstr.x = -*(float *)&v8;
			//     retstr.y = 0.001;
			//     v9 = Beyond::DampingMath::cosf();
			//     result = retstr;
			//     retstr.z = -*(float *)&v9;
			//     return result;
			//   }
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			//     goto LABEL_8;
			//   if ( LODWORD(v6._0.namespaze) <= 0x343 )
			//     sub_180070270(v6, wrapperArray);
			//   if ( !v6[17].vtable.Equals.method )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(835, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v6, wrapperArray);
			//   v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_322(&v14, Patch, (Object *)this, directionAngle, 0LL);
			//   v13 = *(_QWORD *)&v12.x;
			//   *(float *)&v12 = v12.z;
			//   *(_QWORD *)&retstr.x = v13;
			//   LODWORD(retstr.z) = (_DWORD)v12;
			//   return retstr;
			// }
			// 
			return null;
		}

		public bool GetRainEffectPreviewEnabled()
		{
			// // Boolean GetRainEffectPreviewEnabled()
			// bool HG::Rendering::Runtime::HGCharacterVolume::GetRainEffectPreviewEnabled(
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
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
			//   if ( *(int *)&wrapperArray.fields._.m_Value <= 837 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_9;
			//   if ( LODWORD(v3._0.namespaze) <= 0x345 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[17].vtable.Finalize.method )
			//   {
			// LABEL_7:
			//     wrapperArray = this.fields.charRainEffectPreviewEnable;
			//     if ( wrapperArray )
			//       return sub_1800023D0(10LL, wrapperArray);
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(837, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public float GetPackedEnvironmentEffectIntensity()
		{
			// // Single GetPackedEnvironmentEffectIntensity()
			// float HG::Rendering::Runtime::HGCharacterVolume::GetPackedEnvironmentEffectIntensity(
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ClampedFloatParameter *wrapperArray; // rdx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int v7; // edi
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int v10; // esi
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // ebp
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   int v17; // ebx
			//   float result; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9D0 )
			//   {
			//     sub_18003C530(&TypeInfo::System::BitConverter);
			//     byte_18D8ED9D0 = 1;
			//   }
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
			//   wrapperArray = (ClampedFloatParameter *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_14;
			//   if ( SLODWORD(wrapperArray.fields._._.m_Value) <= 838 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_14:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x346 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( v3[17].vtable.GetHashCode.methodPtr )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(838, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_14;
			//   }
			// LABEL_9:
			//   wrapperArray = this.fields.charRainEffectPreviewIntensity;
			//   if ( !wrapperArray )
			//     goto LABEL_14;
			//   sub_18003F9B0(10LL, wrapperArray);
			//   wrapperArray = this.fields.charSnowEffectPreviewIntensity;
			//   if ( !wrapperArray )
			//     goto LABEL_14;
			//   sub_18003F9B0(10LL, wrapperArray);
			//   v7 = sub_1825C6750(v6, v5);
			//   v10 = sub_1825C6750(v9, v8);
			//   v13 = sub_1825C6750(v12, v11);
			//   v17 = sub_1825C6750(v15, v14);
			//   if ( !TypeInfo::System::BitConverter._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::BitConverter, v16);
			//   LODWORD(result) = v7 | ((v10 | ((v13 | (v17 << 8)) << 8)) << 8);
			//   return result;
			// }
			// 
			return 0f;
		}

		private Color AutoTintColor(Color color)
		{
			// // Color AutoTintColor(Color)
			// Color *HG::Rendering::Runtime::HGCharacterVolume::AutoTintColor(
			//         Color *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         Color *color,
			//         MethodInfo *method)
			// {
			//   Color *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Color v11; // xmm0
			//   Color *result; // rax
			//   MethodInfo *v13; // [rsp+20h] [rbp-40h]
			//   float v14; // [rsp+30h] [rbp-30h] BYREF
			//   float v15[3]; // [rsp+34h] [rbp-2Ch] BYREF
			//   Color v16; // [rsp+40h] [rbp-20h] BYREF
			//   Color v17; // [rsp+50h] [rbp-10h] BYREF
			//   float v18; // [rsp+70h] [rbp+10h] BYREF
			// 
			//   v14 = 0.0;
			//   v18 = 0.0;
			//   v15[0] = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(830, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(830, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     v16 = *color;
			//     v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(&v17, Patch, (Object *)this, &v16, 0LL);
			//   }
			//   else
			//   {
			//     v16 = *color;
			//     UnityEngine::Color::RGBToHSV(&v16, &v14, &v18, v15, 0LL);
			//     v7 = UnityEngine::Color::HSVToRGB(&v16, v14, v18, 2.0 / (float)(2.0 - v18), v13);
			//   }
			//   v11 = *v7;
			//   result = retstr;
			//   *retstr = v11;
			//   return result;
			// }
			// 
			return null;
		}

		public Color GetShadowTintColor()
		{
			// // Color GetShadowTintColor()
			// Color *HG::Rendering::Runtime::HGCharacterVolume::GetShadowTintColor(
			//         Color *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   HGCharacterVolume_CharacterShadowTintModeParameter **static_fields; // rcx
			//   HGCharacterVolume_CharacterShadowTintModeParameter *charShadowTintControl; // rdx
			//   Color *one; // rax
			//   Color v9; // xmm0
			//   Color *result; // rax
			//   HGCharacterVolume_CharacterShadowTintModeParameter *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ColorParameter *charShadowTintColor; // r8
			//   Color v14; // [rsp+20h] [rbp-28h] BYREF
			//   Color v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (HGCharacterVolume_CharacterShadowTintModeParameter **)v5.static_fields;
			//   charShadowTintControl = *static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_11;
			//   if ( charShadowTintControl.fields._.m_Value > 829 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, charShadowTintControl);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGCharacterVolume_CharacterShadowTintModeParameter **)v5.static_fields;
			//     v11 = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_11;
			//     if ( v11.fields._.m_Value <= 0x33Du )
			//       sub_180070270(static_fields, charShadowTintControl);
			//     if ( v11[208].monitor )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(829, 0LL);
			//       if ( Patch )
			//       {
			//         one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_321(&v14, Patch, (Object *)this, 0LL);
			//         goto LABEL_10;
			//       }
			// LABEL_11:
			//       sub_180B536AC(static_fields, charShadowTintControl);
			//     }
			//   }
			//   charShadowTintControl = this.fields.charShadowTintControl;
			//   if ( !charShadowTintControl )
			//     goto LABEL_11;
			//   if ( (unsigned int)sub_18003ED00(10LL) == 1 )
			//   {
			//     charShadowTintColor = this.fields.charShadowTintColor;
			//     if ( charShadowTintColor )
			//     {
			//       v14 = *(Color *)sub_180040AD0(&v14, 10LL, charShadowTintColor);
			//       one = HG::Rendering::Runtime::HGCharacterVolume::AutoTintColor(&v15, this, &v14, 0LL);
			//       goto LABEL_10;
			//     }
			//     goto LABEL_11;
			//   }
			//   one = (Color *)UnityEngine::Vector4::get_one((Vector4 *)&v15, (MethodInfo *)charShadowTintControl);
			// LABEL_10:
			//   v9 = *one;
			//   result = retstr;
			//   *retstr = v9;
			//   return result;
			// }
			// 
			return null;
		}

		public Color GetSkinShadowTintColor()
		{
			// // Color GetSkinShadowTintColor()
			// Color *HG::Rendering::Runtime::HGCharacterVolume::GetSkinShadowTintColor(
			//         Color *__return_ptr retstr,
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   HGCharacterVolume_CharacterShadowTintModeParameter **static_fields; // rcx
			//   HGCharacterVolume_CharacterShadowTintModeParameter *charShadowTintControl; // rdx
			//   Color *one; // rax
			//   Color v9; // xmm0
			//   Color *result; // rax
			//   HGCharacterVolume_CharacterShadowTintModeParameter *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ColorParameter *charSkinShadowTintColor; // r8
			//   Color v14; // [rsp+20h] [rbp-28h] BYREF
			//   Color v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (HGCharacterVolume_CharacterShadowTintModeParameter **)v5.static_fields;
			//   charShadowTintControl = *static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_11;
			//   if ( charShadowTintControl.fields._.m_Value > 831 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, charShadowTintControl);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGCharacterVolume_CharacterShadowTintModeParameter **)v5.static_fields;
			//     v11 = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_11;
			//     if ( v11.fields._.m_Value <= 0x33Fu )
			//       sub_180070270(static_fields, charShadowTintControl);
			//     if ( *(_QWORD *)&v11[208].fields._.m_Value )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(831, 0LL);
			//       if ( Patch )
			//       {
			//         one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_321(&v14, Patch, (Object *)this, 0LL);
			//         goto LABEL_10;
			//       }
			// LABEL_11:
			//       sub_180B536AC(static_fields, charShadowTintControl);
			//     }
			//   }
			//   charShadowTintControl = this.fields.charShadowTintControl;
			//   if ( !charShadowTintControl )
			//     goto LABEL_11;
			//   if ( (unsigned int)sub_18003ED00(10LL) == 1 )
			//   {
			//     charSkinShadowTintColor = this.fields.charSkinShadowTintColor;
			//     if ( charSkinShadowTintColor )
			//     {
			//       v14 = *(Color *)sub_180040AD0(&v14, 10LL, charSkinShadowTintColor);
			//       one = HG::Rendering::Runtime::HGCharacterVolume::AutoTintColor(&v15, this, &v14, 0LL);
			//       goto LABEL_10;
			//     }
			//     goto LABEL_11;
			//   }
			//   one = (Color *)UnityEngine::Vector4::get_one((Vector4 *)&v15, (MethodInfo *)charShadowTintControl);
			// LABEL_10:
			//   v9 = *one;
			//   result = retstr;
			//   *retstr = v9;
			//   return result;
			// }
			// 
			return null;
		}

		public HGCharacterVolume.CharacterShadowMode GetCharacterSelfShadowMode()
		{
			// // HGCharacterVolume+CharacterShadowMode GetCharacterSelfShadowMode()
			// HGCharacterVolume_CharacterShadowMode__Enum HG::Rendering::Runtime::HGCharacterVolume::GetCharacterSelfShadowMode(
			//         HGCharacterVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   HGCharacterVolume_CharacterModeParameter *wrapperArray; // rdx
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
			//   wrapperArray = (HGCharacterVolume_CharacterModeParameter *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.fields._.m_Value <= 1785 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_9;
			//   if ( LODWORD(v3._0.namespaze) <= 0x6F9 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[38]._0.namespaze )
			//   {
			// LABEL_7:
			//     wrapperArray = this.fields.charShadowMode;
			//     if ( wrapperArray )
			//       return (unsigned int)sub_18003ED00(10LL);
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1785, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return HGCharacterVolume.CharacterShadowMode.SceneLight;
		}

		public static void SetValueAndState(VolumeParameter srcParameter, VolumeParameter tarParam)
		{
			// // Void SetValueAndState(VolumeParameter, VolumeParameter)
			// void HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         VolumeParameter *srcParameter,
			//         VolumeParameter *tarParam,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2032, 0LL) )
			//   {
			//     if ( tarParam && srcParameter )
			//     {
			//       srcParameter.fields.overrideState = tarParam.fields.overrideState;
			//       sub_18004A830(v6, srcParameter, tarParam);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2032, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)srcParameter,
			//     (Object *)tarParam,
			//     0LL);
			// }
			// 
		}

		public CharLightVolumeData GetCharLightVolumeData()
		{
			return null;
		}

		public bool SetCharLightVolumeData(CharLightVolumeData charLightVolumeData)
		{
			// // Boolean SetCharLightVolumeData(CharLightVolumeData)
			// bool HG::Rendering::Runtime::HGCharacterVolume::SetCharLightVolumeData(
			//         HGCharacterVolume *this,
			//         CharLightVolumeData *charLightVolumeData,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2031, 0LL) )
			//   {
			//     if ( charLightVolumeData )
			//     {
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charMainLightControl,
			//         (VolumeParameter *)charLightVolumeData.fields.charMainLightControl,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charMainLightMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charMainLightMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charEnvLightMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charEnvLightMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charEnvShadowMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charEnvShadowMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charMainLightSpecularMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charMainLightSpecularMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charEyeBaseLightMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charEyeBaseLightMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charEyeHighlightMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charEyeHighlightMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charEyeScatteringMultiplier,
			//         (VolumeParameter *)charLightVolumeData.fields.charEyeScatteringMultiplier,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charMainLightRangeBias,
			//         (VolumeParameter *)charLightVolumeData.fields.charMainLightRangeBias,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charIgnoreMainLightShadow,
			//         (VolumeParameter *)charLightVolumeData.fields.charIgnoreMainLightShadow,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charMainLightMode,
			//         (VolumeParameter *)charLightVolumeData.fields.charMainLightMode,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charCameraFollowMainLightBias,
			//         (VolumeParameter *)charLightVolumeData.fields.charCameraFollowMainLightBias,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charCustomMainLightDir,
			//         (VolumeParameter *)charLightVolumeData.fields.charCustomMainLightDir,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charMainLightOverrideColor,
			//         (VolumeParameter *)charLightVolumeData.fields.charMainLightOverrideColor,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charSkinMainLightOverrideColor,
			//         (VolumeParameter *)charLightVolumeData.fields.charSkinMainLightOverrideColor,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charLightDialogMode,
			//         (VolumeParameter *)charLightVolumeData.fields.charLightDialogMode,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charShadowTintControl,
			//         (VolumeParameter *)charLightVolumeData.fields.charShadowTintControl,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charShadowTintColor,
			//         (VolumeParameter *)charLightVolumeData.fields.charShadowTintColor,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charSkinShadowTintColor,
			//         (VolumeParameter *)charLightVolumeData.fields.charSkinShadowTintColor,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charAutoRimEnable,
			//         (VolumeParameter *)charLightVolumeData.fields.charAutoRimEnable,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charAutoRimColor,
			//         (VolumeParameter *)charLightVolumeData.fields.charAutoRimColor,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charAutoRimDir,
			//         (VolumeParameter *)charLightVolumeData.fields.charAutoRimDir,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charAutoRimIntensity,
			//         (VolumeParameter *)charLightVolumeData.fields.charAutoRimIntensity,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charAutoRimWidth,
			//         (VolumeParameter *)charLightVolumeData.fields.charAutoRimWidth,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charFaceRimEnable,
			//         (VolumeParameter *)charLightVolumeData.fields.charFaceRimEnable,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charFaceRimIntensity,
			//         (VolumeParameter *)charLightVolumeData.fields.charFaceRimIntensity,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charFaceRimColor,
			//         (VolumeParameter *)charLightVolumeData.fields.charFaceRimColor,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charFaceRimDir,
			//         (VolumeParameter *)charLightVolumeData.fields.charFaceRimDir,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charIgnoreSceneAdditionalLights,
			//         (VolumeParameter *)charLightVolumeData.fields.charIgnoreSceneAdditionalLights,
			//         0LL);
			//       HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
			//         (VolumeParameter *)this.fields.charIgnoreSceneEnv,
			//         (VolumeParameter *)charLightVolumeData.fields.charIgnoreSceneEnv,
			//         0LL);
			//       return 1;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2031, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)charLightVolumeData,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		[HideInInspector]
		[InspectorName("角色反射Cube贴图")]
		public CubemapParameter charMaxCubemap;

		[HideInInspector]
		[Header("角色环境光")]
		[InspectorName("角色环境光预设")]
		public HGCharacterVolume.CharacterAmbientModeParameter charAmbientModeIndex;

		[HideInInspector]
		[InspectorName("角色环境光基础强度")]
		public ClampedFloatParameter charAmbientLightBaseIntensity;

		[InspectorName("角色环境光方向")]
		[HideInInspector]
		public Vector2Parameter charAmbientLightCustomDir;

		[InspectorName("角色环境光方向性强度")]
		[HideInInspector]
		public ClampedFloatParameter charAmbientLightDirIntensity;

		[HideInInspector]
		[InspectorName("角色环境光方向性系数")]
		public ClampedFloatParameter charAmbientLightDirParam;

		[HideInInspector]
		public Vector4Parameter charGlobalAmbientParam0;

		[HideInInspector]
		public Vector4Parameter charGlobalAmbientParam1;

		[HideInInspector]
		[Header("角色光照控制")]
		[InspectorName("角色灯光手动控制模式")]
		public BoolParameter charMainLightControl;

		[InspectorName("角色主光源强度系数")]
		[HideInInspector]
		public ClampedFloatParameter charMainLightMultiplier;

		[InspectorName("角色背光面强度系数")]
		[HideInInspector]
		public ClampedFloatParameter charEnvLightMultiplier;

		[HideInInspector]
		[InspectorName("角色环境亮度系数")]
		public ClampedFloatParameter charEnvShadowMultiplier;

		[InspectorName("角色高光亮度系数")]
		[HideInInspector]
		public ClampedFloatParameter charMainLightSpecularMultiplier;

		[InspectorName("角色眼睛整体亮度系数")]
		[HideInInspector]
		public ClampedFloatParameter charEyeBaseLightMultiplier;

		[InspectorName("角色眼睛高光亮度系数")]
		[HideInInspector]
		public ClampedFloatParameter charEyeHighlightMultiplier;

		[InspectorName("角色眼睛散射亮度系数")]
		[HideInInspector]
		public ClampedFloatParameter charEyeScatteringMultiplier;

		[HideInInspector]
		[InspectorName("角色明暗交界线偏移系数")]
		public ClampedFloatParameter charMainLightRangeBias;

		[HideInInspector]
		[InspectorName("角色忽略主光源阴影")]
		public BoolParameter charIgnoreMainLightShadow;

		[HideInInspector]
		[InspectorName("角色主光源方向模式")]
		public HGCharacterVolume.CharacterLightModeParameter charMainLightMode;

		[HideInInspector]
		[InspectorName("角色自定义主光源方向")]
		public Vector2Parameter charCustomMainLightDir;

		[HideInInspector]
		[InspectorName("角色灯光相对于相机的偏移角度")]
		public Vector2Parameter charCameraFollowMainLightBias;

		[InspectorName("角色主光源自定义颜色")]
		[HideInInspector]
		public ColorParameter charMainLightOverrideColor;

		[HideInInspector]
		[InspectorName("角色皮肤主光源自定义颜色")]
		public ColorParameter charSkinMainLightOverrideColor;

		[Tooltip("根据场景内光照自动适配适合Dialog等特写下的角色光照表现，场景光照较暗时，增加角色美观性，降低角色和场景的融合度")]
		[HideInInspector]
		[InspectorName("角色光照演出模式")]
		public BoolParameter charLightDialogMode;

		[InspectorName("角色阴影色调控制")]
		[Header("角色阴影色调")]
		[HideInInspector]
		public HGCharacterVolume.CharacterShadowTintModeParameter charShadowTintControl;

		[HideInInspector]
		[InspectorName("角色阴影颜色倾向（除皮肤外）")]
		public ColorParameter charShadowTintColor;

		[InspectorName("角色皮肤阴影颜色倾向")]
		[HideInInspector]
		public ColorParameter charSkinShadowTintColor;

		[HideInInspector]
		[Header("角色自投影")]
		[InspectorName("角色自阴影模式")]
		public HGCharacterVolume.CharacterModeParameter charShadowMode;

		[HideInInspector]
		[Header("角色边缘光")]
		[InspectorName("启用一键边缘光")]
		public BoolParameter charAutoRimEnable;

		[HideInInspector]
		[InspectorName("边缘光颜色")]
		public ColorParameter charAutoRimColor;

		[InspectorName("边缘光方向")]
		[HideInInspector]
		public ClampedFloatParameter charAutoRimDir;

		[InspectorName("边缘光强度")]
		[HideInInspector]
		public ClampedFloatParameter charAutoRimIntensity;

		[HideInInspector]
		[InspectorName("边缘光宽度")]
		public ClampedFloatParameter charAutoRimWidth;

		[HideInInspector]
		[InspectorName("边缘光受基础色影响程度")]
		public ClampedFloatParameter charAutoRimAlbedo;

		[HideInInspector]
		[InspectorName("边缘光新计算方式")]
		public BoolParameter charAutoRimMode;

		[HideInInspector]
		[Header("脸部边缘光")]
		[InspectorName("启用脸部额外边缘光")]
		public BoolParameter charFaceRimEnable;

		[HideInInspector]
		[InspectorName("脸部边缘光颜色")]
		public ColorParameter charFaceRimColor;

		[HideInInspector]
		[InspectorName("脸部边缘光方向")]
		public ClampedFloatParameter charFaceRimDir;

		[HideInInspector]
		[InspectorName("脸部边缘光强度")]
		public ClampedFloatParameter charFaceRimIntensity;

		[HideInInspector]
		[Header("角色场景交互效果")]
		[InspectorName("场景交互效果全局控制")]
		public BoolParameter charRainEffectPreviewEnable;

		[HideInInspector]
		[InspectorName("场景交互效果类型")]
		public HGCharacterVolume.CharacterEnvironmentEffectModeParameter charEnvironmentEffectMode;

		[InspectorName("积雪效果全局强度")]
		[HideInInspector]
		public ClampedFloatParameter charSnowEffectPreviewIntensity;

		[HideInInspector]
		[InspectorName("湿润效果全局强度")]
		public ClampedFloatParameter charRainEffectPreviewIntensity;

		[InspectorName("水线高度")]
		[HideInInspector]
		public ClampedFloatParameter charWetEffectPreviewWorldHeight;

		[InspectorName("环境效果贴图tiling")]
		[HideInInspector]
		public ClampedFloatParameter charRainEffectTextureTiling;

		[Header("环境影响")]
		[InspectorName("忽略场景中的点光")]
		[HideInInspector]
		public BoolParameter charIgnoreSceneAdditionalLights;

		[InspectorName("忽略场景Env Volume对角色的影响")]
		[HideInInspector]
		public BoolParameter charIgnoreSceneEnv;

		[InspectorName("角色描线性能分级")]
		[Header("性能分级")]
		[HideInInspector]
		public HGCharacterVolume.CharacterRenderFeatureQualityTierParameter charOutlineQualityMode;

		[InspectorName("角色自投影性能分级")]
		[HideInInspector]
		public HGCharacterVolume.CharacterRenderFeatureQualityTierParameter charSelfShadowQualityMode;

		[Serializable]
		public sealed class CharacterModeParameter : VolumeParameter<HGCharacterVolume.CharacterShadowMode>
		{
			public CharacterModeParameter(HGCharacterVolume.CharacterShadowMode value, [MetadataOffset(Offset = "0x01F91415")] bool overrideState = false)
			{
				// // HGCharacterVolume+CharacterModeParameter(HGCharacterVolume+CharacterShadowMode, Boolean)
				// void HG::Rendering::Runtime::HGCharacterVolume::CharacterModeParameter::CharacterModeParameter(
				//         HGCharacterVolume_CharacterModeParameter *this,
				//         HGCharacterVolume_CharacterShadowMode__Enum value,
				//         bool overrideState,
				//         MethodInfo *method)
				// {
				//   if ( byte_18D8ED9D2 )
				//   {
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//   }
				//   else
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowMode>::VolumeParameter);
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//     byte_18D8ED9D2 = 1;
				//   }
				// }
				// 
			}
		}

		[Serializable]
		public sealed class CharacterLightModeParameter : VolumeParameter<HGCharacterVolume.CharacterLightMode>
		{
			public CharacterLightModeParameter(HGCharacterVolume.CharacterLightMode value, [MetadataOffset(Offset = "0x01F91416")] bool overrideState = false)
			{
				// // HGCharacterVolume+CharacterLightModeParameter(HGCharacterVolume+CharacterLightMode, Boolean)
				// void HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter::CharacterLightModeParameter(
				//         HGCharacterVolume_CharacterLightModeParameter *this,
				//         HGCharacterVolume_CharacterLightMode__Enum value,
				//         bool overrideState,
				//         MethodInfo *method)
				// {
				//   if ( byte_18D8ED9D3 )
				//   {
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//   }
				//   else
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterLightMode>::VolumeParameter);
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//     byte_18D8ED9D3 = 1;
				//   }
				// }
				// 
			}
		}

		[Serializable]
		public sealed class CharacterRenderFeatureQualityTierParameter : VolumeParameter<HGCharacterVolume.CharacterRenderFeatureQualityTier>
		{
			public CharacterRenderFeatureQualityTierParameter(HGCharacterVolume.CharacterRenderFeatureQualityTier value, [MetadataOffset(Offset = "0x01F91417")] bool overrideState = false)
			{
				// // HGCharacterVolume+CharacterRenderFeatureQualityTierParameter(HGCharacterVolume+CharacterRenderFeatureQualityTier, Boolean)
				// void HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter::CharacterRenderFeatureQualityTierParameter(
				//         HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *this,
				//         HGCharacterVolume_CharacterRenderFeatureQualityTier__Enum value,
				//         bool overrideState,
				//         MethodInfo *method)
				// {
				//   if ( byte_18D8ED9D4 )
				//   {
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//   }
				//   else
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTier>::VolumeParameter);
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//     byte_18D8ED9D4 = 1;
				//   }
				// }
				// 
			}
		}

		[Serializable]
		public sealed class CharacterShadowTintModeParameter : VolumeParameter<HGCharacterVolume.CharacterShadowTintMode>
		{
			public CharacterShadowTintModeParameter(HGCharacterVolume.CharacterShadowTintMode value, [MetadataOffset(Offset = "0x01F91418")] bool overrideState = false)
			{
				// // HGCharacterVolume+CharacterShadowTintModeParameter(HGCharacterVolume+CharacterShadowTintMode, Boolean)
				// void HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter::CharacterShadowTintModeParameter(
				//         HGCharacterVolume_CharacterShadowTintModeParameter *this,
				//         HGCharacterVolume_CharacterShadowTintMode__Enum value,
				//         bool overrideState,
				//         MethodInfo *method)
				// {
				//   if ( byte_18D8ED9D5 )
				//   {
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//   }
				//   else
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintMode>::VolumeParameter);
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//     byte_18D8ED9D5 = 1;
				//   }
				// }
				// 
			}
		}

		[Serializable]
		public sealed class CharacterAmbientModeParameter : VolumeParameter<HGCharacterVolume.CharacterAmbientMode>
		{
			public CharacterAmbientModeParameter(HGCharacterVolume.CharacterAmbientMode value, [MetadataOffset(Offset = "0x01F91419")] bool overrideState = false)
			{
				// // HGCharacterVolume+CharacterAmbientModeParameter(HGCharacterVolume+CharacterAmbientMode, Boolean)
				// void HG::Rendering::Runtime::HGCharacterVolume::CharacterAmbientModeParameter::CharacterAmbientModeParameter(
				//         HGCharacterVolume_CharacterAmbientModeParameter *this,
				//         HGCharacterVolume_CharacterAmbientMode__Enum value,
				//         bool overrideState,
				//         MethodInfo *method)
				// {
				//   if ( byte_18D8ED9D6 )
				//   {
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//   }
				//   else
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterAmbientMode>::VolumeParameter);
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//     byte_18D8ED9D6 = 1;
				//   }
				// }
				// 
			}
		}

		[Serializable]
		public sealed class CharacterEnvironmentEffectModeParameter : VolumeParameter<HGCharacterVolume.CharacterEnvironmentEffectMode>
		{
			public CharacterEnvironmentEffectModeParameter(HGCharacterVolume.CharacterEnvironmentEffectMode value, [MetadataOffset(Offset = "0x01F9141A")] bool overrideState = false)
			{
				// // HGCharacterVolume+CharacterEnvironmentEffectModeParameter(HGCharacterVolume+CharacterEnvironmentEffectMode, Boolean)
				// void HG::Rendering::Runtime::HGCharacterVolume::CharacterEnvironmentEffectModeParameter::CharacterEnvironmentEffectModeParameter(
				//         HGCharacterVolume_CharacterEnvironmentEffectModeParameter *this,
				//         HGCharacterVolume_CharacterEnvironmentEffectMode__Enum value,
				//         bool overrideState,
				//         MethodInfo *method)
				// {
				//   if ( byte_18D8ED9D7 )
				//   {
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//   }
				//   else
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGCharacterVolume::CharacterEnvironmentEffectMode>::VolumeParameter);
				//     this.fields._.m_Value = value;
				//     this.fields._._.overrideState = overrideState;
				//     byte_18D8ED9D7 = 1;
				//   }
				// }
				// 
			}
		}

		public enum CharacterShadowMode
		{
			[InspectorName("跟随场景主光方向")]
			SceneLight,
			[InspectorName("跟随相机方向")]
			CameraVirtualLight
		}

		public enum CharacterLightMode
		{
			[InspectorName("跟随场景主光")]
			Scene,
			[InspectorName("跟随相机")]
			CameraFollow,
			[InspectorName("自定义方向")]
			Custom
		}

		public enum CharacterRenderFeatureQualityTier
		{
			[InspectorName("开启")]
			AlwaysOn,
			[InspectorName("低配手机不开启")]
			Tier10 = 10,
			[InspectorName("仅PC和Console开启")]
			Tier20 = 20,
			[InspectorName("关闭")]
			AlwaysOff = 2147483647
		}

		public enum CharacterShadowTintMode
		{
			[InspectorName("自动（跟随场景）")]
			Auto,
			[InspectorName("自定义阴影色调")]
			CustomTintColor
		}

		public enum CharacterAmbientMode
		{
			[InspectorName("Default (TopLight_LowContrast)")]
			Default,
			[InspectorName("TopLight_LowContrast")]
			TopLight_LowContrast,
			[InspectorName("TopLight_HighContrast")]
			TopLight_HighContrast,
			[InspectorName("InDoor_Normal")]
			InDoor_Normal = 10,
			[InspectorName("InDoor_Bright")]
			InDoor_Bright,
			[InspectorName("InDoor_Dark")]
			InDoor_Dark,
			Custom = 255
		}

		public enum CharacterEnvironmentEffectMode
		{
			Rain,
			Snow
		}
	}
}
