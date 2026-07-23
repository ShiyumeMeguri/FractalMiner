using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class CharLightVolumeData // TypeDefIndex: 38021
	{
		// Fields
		[Header("\u89D2\u8272\u5149\u7167\u63A7\u5236")]
		public BoolParameter charMainLightControl; // 0x10
		[ClampedFloatRange(0f, 5f)]
		public ClampedFloatParameter charMainLightMultiplier; // 0x18
		[ClampedFloatRange(0f, 3f)]
		public ClampedFloatParameter charEnvLightMultiplier; // 0x20
		[ClampedFloatRange(0f, 2f)]
		public ClampedFloatParameter charEnvShadowMultiplier; // 0x28
		[ClampedFloatRange(0f, 2f)]
		public ClampedFloatParameter charMainLightSpecularMultiplier; // 0x30
		[ClampedFloatRange(-1f, 1f)]
		public ClampedFloatParameter charMainLightRangeBias; // 0x38
		[ClampedFloatRange(0f, 3f)]
		public ClampedFloatParameter charEyeBaseLightMultiplier; // 0x40
		[ClampedFloatRange(0f, 3f)]
		public ClampedFloatParameter charEyeHighlightMultiplier; // 0x48
		[ClampedFloatRange(0f, 3f)]
		public ClampedFloatParameter charEyeScatteringMultiplier; // 0x50
		public BoolParameter charIgnoreMainLightShadow; // 0x58
		public HGCharacterVolume.CharacterLightModeParameter charMainLightMode; // 0x60
		public Vector2Parameter charCustomMainLightDir; // 0x68
		public Vector2Parameter charCameraFollowMainLightBias; // 0x70
		public ColorParameter charMainLightOverrideColor; // 0x78
		public ColorParameter charSkinMainLightOverrideColor; // 0x80
		[Tooltip("\u6839\u636E\u573A\u666F\u5185\u5149\u7167\u81EA\u52A8\u9002\u914D\u9002\u5408Dialog\u7B49\u7279\u5199\u4E0B\u7684\u89D2\u8272\u5149\u7167\u8868\u73B0\uFF0C\u573A\u666F\u5149\u7167\u8F83\u6697\u65F6\uFF0C\u589E\u52A0\u89D2\u8272\u7F8E\u89C2\u6027\uFF0C\u964D\u4F4E\u89D2\u8272\u548C\u573A\u666F\u7684\u878D\u5408\u5EA6")]
		public BoolParameter charLightDialogMode; // 0x88
		[Header("\u89D2\u8272\u9634\u5F71\u8272\u8C03")]
		public HGCharacterVolume.CharacterShadowTintModeParameter charShadowTintControl; // 0x90
		public ColorParameter charShadowTintColor; // 0x98
		public ColorParameter charSkinShadowTintColor; // 0xA0
		[Header("\u89D2\u8272\u8FB9\u7F18\u5149")]
		public BoolParameter charAutoRimEnable; // 0xA8
		public ColorParameter charAutoRimColor; // 0xB0
		[ClampedFloatRange(0f, 1f)]
		public ClampedFloatParameter charAutoRimDir; // 0xB8
		[ClampedFloatRange(0f, 10f)]
		public ClampedFloatParameter charAutoRimIntensity; // 0xC0
		[ClampedFloatRange(0f, 1f)]
		public ClampedFloatParameter charAutoRimWidth; // 0xC8
		[Header("\u8138\u90E8\u8FB9\u7F18\u5149")]
		public BoolParameter charFaceRimEnable; // 0xD0
		public ColorParameter charFaceRimColor; // 0xD8
		[ClampedFloatRange(0f, 1f)]
		public ClampedFloatParameter charFaceRimDir; // 0xE0
		[ClampedFloatRange(0f, 10f)]
		public ClampedFloatParameter charFaceRimIntensity; // 0xE8
		[Header("\u73AF\u5883\u5F71\u54CD")]
		public BoolParameter charIgnoreSceneAdditionalLights; // 0xF0
		public BoolParameter charIgnoreSceneEnv; // 0xF8
		private static CharLightVolumeData m_DefaultCharLightVolumeData; // 0x00
	
		// Properties
		public static CharLightVolumeData defaultCharLightVolumeData { get => default; } // 0x0000000189B68BB0-0x0000000189B68C54 
		// CharLightVolumeData get_defaultCharLightVolumeData()
		CharLightVolumeData *HG::Rendering::Runtime::CharLightVolumeData::get_defaultCharLightVolumeData(MethodInfo *method)
		{
		  struct CharLightVolumeData__Class *v1; // rcx
		  CharLightVolumeData *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Type__Class *v5; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2436, 0LL) )
		  {
		    v1 = TypeInfo::HG::Rendering::Runtime::CharLightVolumeData;
		    if ( TypeInfo::HG::Rendering::Runtime::CharLightVolumeData->static_fields->m_DefaultCharLightVolumeData )
		      return v1->static_fields->m_DefaultCharLightVolumeData;
		    v2 = (CharLightVolumeData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CharLightVolumeData);
		    v5 = (Type__Class *)v2;
		    if ( v2 )
		    {
		      HG::Rendering::Runtime::CharLightVolumeData::CharLightVolumeData(v2, 0LL);
		      static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::CharLightVolumeData->static_fields;
		      static_fields->klass = v5;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::CharLightVolumeData->static_fields,
		        static_fields,
		        v7,
		        v8,
		        v11);
		      v1 = TypeInfo::HG::Rendering::Runtime::CharLightVolumeData;
		      return v1->static_fields->m_DefaultCharLightVolumeData;
		    }
		LABEL_7:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2436, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_945(Patch, 0LL);
		}
		
	
		// Nested types
		public class ClampedFloatRangeAttribute : Attribute // TypeDefIndex: 38020
		{
			// Fields
			public float min; // 0x10
			public float max; // 0x14
	
			// Constructors
			public ClampedFloatRangeAttribute() {} // Dummy constructor
			public ClampedFloatRangeAttribute(float min, float max) {} // 0x0000000184D8D120-0x0000000184D8D130
			// MinMaxRangeAttribute(Single, Single)
			void VLB::MinMaxRangeAttribute::MinMaxRangeAttribute(
			        MinMaxRangeAttribute *this,
			        float min,
			        float max,
			        MethodInfo *method)
			{
			  this->fields._minValue_k__BackingField = min;
			  this->fields._maxValue_k__BackingField = max;
			}
			
		}
	
		// Constructors
		public CharLightVolumeData() {} // 0x0000000189B6851C-0x0000000189B68BB0
		// CharLightVolumeData()
		void HG::Rendering::Runtime::CharLightVolumeData::CharLightVolumeData(CharLightVolumeData *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
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
		  BoolParameter *v32; // rax
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  HGCharacterVolume_CharacterLightModeParameter *v35; // rax
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  __int64 v38; // rax
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  __int64 v41; // rax
		  PropertyInfo_1 *v42; // r8
		  Int32__Array **v43; // r9
		  MethodInfo *v44; // rdx
		  __m128i v45; // xmm6
		  __int64 v46; // rax
		  PropertyInfo_1 *v47; // r8
		  Int32__Array **v48; // r9
		  MethodInfo *v49; // rdx
		  __m128i v50; // xmm6
		  __int64 v51; // rax
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  BoolParameter *v54; // rax
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  HGCharacterVolume_CharacterShadowTintModeParameter *v57; // rax
		  PropertyInfo_1 *v58; // r8
		  Int32__Array **v59; // r9
		  MethodInfo *v60; // rdx
		  __m128i v61; // xmm6
		  __int64 v62; // rax
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **v64; // r9
		  MethodInfo *v65; // rdx
		  __m128i v66; // xmm6
		  __int64 v67; // rax
		  PropertyInfo_1 *v68; // r8
		  Int32__Array **v69; // r9
		  BoolParameter *v70; // rax
		  PropertyInfo_1 *v71; // r8
		  Int32__Array **v72; // r9
		  MethodInfo *v73; // rdx
		  __m128i v74; // xmm6
		  __int64 v75; // rax
		  PropertyInfo_1 *v76; // r8
		  Int32__Array **v77; // r9
		  __int64 v78; // rax
		  PropertyInfo_1 *v79; // r8
		  Int32__Array **v80; // r9
		  __int64 v81; // rax
		  PropertyInfo_1 *v82; // r8
		  Int32__Array **v83; // r9
		  __int64 v84; // rax
		  PropertyInfo_1 *v85; // r8
		  Int32__Array **v86; // r9
		  BoolParameter *v87; // rax
		  PropertyInfo_1 *v88; // r8
		  Int32__Array **v89; // r9
		  MethodInfo *v90; // rdx
		  __m128i v91; // xmm6
		  __int64 v92; // rax
		  PropertyInfo_1 *v93; // r8
		  Int32__Array **v94; // r9
		  __int64 v95; // rax
		  PropertyInfo_1 *v96; // r8
		  Int32__Array **v97; // r9
		  __int64 v98; // rax
		  PropertyInfo_1 *v99; // r8
		  Int32__Array **v100; // r9
		  BoolParameter *v101; // rax
		  PropertyInfo_1 *v102; // r8
		  Int32__Array **v103; // r9
		  BoolParameter *v104; // rax
		  PropertyInfo_1 *v105; // r8
		  Int32__Array **v106; // r9
		  Vector4 v107; // [rsp+20h] [rbp-28h] BYREF
		  MethodInfo *v108; // [rsp+70h] [rbp+28h]
		
		  v3 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_32;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.charMainLightControl = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v6, v7, *(MethodInfo **)&v107.x);
		  v8 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_32;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 24) = 1065353216;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1084227584;
		  this->fields.charMainLightMultiplier = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightMultiplier, v4, v9, v10, *(MethodInfo **)&v107.x);
		  v11 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_32;
		  *(_DWORD *)(v11 + 24) = 1060320051;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 36) = 1077936128;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.charEnvLightMultiplier = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEnvLightMultiplier, v4, v12, v13, *(MethodInfo **)&v107.x);
		  v14 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_32;
		  *(_DWORD *)(v14 + 24) = 1065353216;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 0;
		  *(_DWORD *)(v14 + 36) = 0x40000000;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.charEnvShadowMultiplier = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEnvShadowMultiplier, v4, v15, v16, *(MethodInfo **)&v107.x);
		  v17 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v17 )
		    goto LABEL_32;
		  *(_DWORD *)(v17 + 24) = 1065353216;
		  *(_BYTE *)(v17 + 16) = 0;
		  *(_DWORD *)(v17 + 32) = 0;
		  *(_DWORD *)(v17 + 36) = 0x40000000;
		  *(_DWORD *)(v17 + 40) = 1065353216;
		  this->fields.charMainLightSpecularMultiplier = (ClampedFloatParameter *)v17;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charMainLightSpecularMultiplier,
		    v4,
		    v18,
		    v19,
		    *(MethodInfo **)&v107.x);
		  v20 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v20 )
		    goto LABEL_32;
		  *(_DWORD *)(v20 + 24) = 0;
		  *(_BYTE *)(v20 + 16) = 0;
		  *(_DWORD *)(v20 + 32) = -1082130432;
		  *(_DWORD *)(v20 + 36) = 1065353216;
		  *(_DWORD *)(v20 + 40) = 1065353216;
		  this->fields.charMainLightRangeBias = (ClampedFloatParameter *)v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightRangeBias, v4, v21, v22, *(MethodInfo **)&v107.x);
		  v23 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v23 )
		    goto LABEL_32;
		  *(_DWORD *)(v23 + 24) = 1065353216;
		  *(_BYTE *)(v23 + 16) = 0;
		  *(_DWORD *)(v23 + 32) = 0;
		  *(_DWORD *)(v23 + 36) = 1077936128;
		  *(_DWORD *)(v23 + 40) = 1065353216;
		  this->fields.charEyeBaseLightMultiplier = (ClampedFloatParameter *)v23;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEyeBaseLightMultiplier, v4, v24, v25, *(MethodInfo **)&v107.x);
		  v26 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v26 )
		    goto LABEL_32;
		  *(_DWORD *)(v26 + 24) = 1065353216;
		  *(_BYTE *)(v26 + 16) = 0;
		  *(_DWORD *)(v26 + 32) = 0;
		  *(_DWORD *)(v26 + 36) = 1077936128;
		  *(_DWORD *)(v26 + 40) = 1065353216;
		  this->fields.charEyeHighlightMultiplier = (ClampedFloatParameter *)v26;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEyeHighlightMultiplier, v4, v27, v28, *(MethodInfo **)&v107.x);
		  v29 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v29 )
		    goto LABEL_32;
		  *(_DWORD *)(v29 + 24) = 1065353216;
		  *(_BYTE *)(v29 + 16) = 0;
		  *(_DWORD *)(v29 + 32) = 0;
		  *(_DWORD *)(v29 + 36) = 1077936128;
		  *(_DWORD *)(v29 + 40) = 1065353216;
		  this->fields.charEyeScatteringMultiplier = (ClampedFloatParameter *)v29;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEyeScatteringMultiplier, v4, v30, v31, *(MethodInfo **)&v107.x);
		  v32 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v32 )
		    goto LABEL_32;
		  v32->fields._.m_Value = 0;
		  v32->fields._._.overrideState = 0;
		  this->fields.charIgnoreMainLightShadow = v32;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charIgnoreMainLightShadow, v4, v33, v34, *(MethodInfo **)&v107.x);
		  v35 = (HGCharacterVolume_CharacterLightModeParameter *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter);
		  if ( !v35 )
		    goto LABEL_32;
		  v35->fields._.m_Value = 0;
		  v35->fields._._.overrideState = 0;
		  this->fields.charMainLightMode = v35;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightMode, v4, v36, v37, *(MethodInfo **)&v107.x);
		  v38 = sub_18002C620(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v38 )
		    goto LABEL_32;
		  *(_BYTE *)(v38 + 16) = 0;
		  *(_QWORD *)(v38 + 24) = 1106247680LL;
		  this->fields.charCustomMainLightDir = (Vector2Parameter *)v38;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charCustomMainLightDir, v4, v39, v40, *(MethodInfo **)&v107.x);
		  v41 = sub_18002C620(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v41 )
		    goto LABEL_32;
		  *(_DWORD *)(v41 + 24) = 1106247680;
		  *(_BYTE *)(v41 + 16) = 0;
		  *(_DWORD *)(v41 + 28) = 1092616192;
		  this->fields.charCameraFollowMainLightBias = (Vector2Parameter *)v41;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charCameraFollowMainLightBias,
		    v4,
		    v42,
		    v43,
		    *(MethodInfo **)&v107.x);
		  v45 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v107, v44));
		  v46 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v46 )
		    goto LABEL_32;
		  *(_WORD *)(v46 + 41) = 257;
		  *(__m128i *)(v46 + 24) = v45;
		  *(_BYTE *)(v46 + 16) = 0;
		  this->fields.charMainLightOverrideColor = (ColorParameter *)v46;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightOverrideColor, v4, v47, v48, *(MethodInfo **)&v107.x);
		  v50 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v107, v49));
		  v51 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v51 )
		    goto LABEL_32;
		  *(_WORD *)(v51 + 41) = 257;
		  *(__m128i *)(v51 + 24) = v50;
		  *(_BYTE *)(v51 + 16) = 0;
		  this->fields.charSkinMainLightOverrideColor = (ColorParameter *)v51;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charSkinMainLightOverrideColor,
		    v4,
		    v52,
		    v53,
		    *(MethodInfo **)&v107.x);
		  v54 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v54 )
		    goto LABEL_32;
		  v54->fields._.m_Value = 0;
		  v54->fields._._.overrideState = 0;
		  this->fields.charLightDialogMode = v54;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charLightDialogMode, v4, v55, v56, *(MethodInfo **)&v107.x);
		  v57 = (HGCharacterVolume_CharacterShadowTintModeParameter *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter);
		  if ( !v57 )
		    goto LABEL_32;
		  v57->fields._.m_Value = 0;
		  v57->fields._._.overrideState = 0;
		  this->fields.charShadowTintControl = v57;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charShadowTintControl, v4, v58, v59, *(MethodInfo **)&v107.x);
		  v61 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v107, v60));
		  v62 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v62 )
		    goto LABEL_32;
		  *(_WORD *)(v62 + 41) = 257;
		  *(__m128i *)(v62 + 24) = v61;
		  *(_BYTE *)(v62 + 16) = 0;
		  this->fields.charShadowTintColor = (ColorParameter *)v62;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charShadowTintColor, v4, v63, v64, *(MethodInfo **)&v107.x);
		  v66 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v107, v65));
		  v67 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v67 )
		    goto LABEL_32;
		  *(_WORD *)(v67 + 41) = 257;
		  *(__m128i *)(v67 + 24) = v66;
		  *(_BYTE *)(v67 + 16) = 0;
		  this->fields.charSkinShadowTintColor = (ColorParameter *)v67;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charSkinShadowTintColor, v4, v68, v69, *(MethodInfo **)&v107.x);
		  v70 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v70 )
		    goto LABEL_32;
		  v70->fields._.m_Value = 0;
		  v70->fields._._.overrideState = 0;
		  this->fields.charAutoRimEnable = v70;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimEnable, v4, v71, v72, *(MethodInfo **)&v107.x);
		  v74 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v107, v73));
		  v75 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v75 )
		    goto LABEL_32;
		  *(_WORD *)(v75 + 41) = 257;
		  *(__m128i *)(v75 + 24) = v74;
		  *(_BYTE *)(v75 + 16) = 0;
		  this->fields.charAutoRimColor = (ColorParameter *)v75;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimColor, v4, v76, v77, *(MethodInfo **)&v107.x);
		  v78 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v78 )
		    goto LABEL_32;
		  *(_DWORD *)(v78 + 24) = 0;
		  *(_BYTE *)(v78 + 16) = 0;
		  *(_DWORD *)(v78 + 32) = 0;
		  *(_DWORD *)(v78 + 36) = 1065353216;
		  *(_DWORD *)(v78 + 40) = 1065353216;
		  this->fields.charAutoRimDir = (ClampedFloatParameter *)v78;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimDir, v4, v79, v80, *(MethodInfo **)&v107.x);
		  v81 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v81 )
		    goto LABEL_32;
		  *(_DWORD *)(v81 + 24) = 1065353216;
		  *(_BYTE *)(v81 + 16) = 0;
		  *(_DWORD *)(v81 + 32) = 0;
		  *(_DWORD *)(v81 + 36) = 1092616192;
		  *(_DWORD *)(v81 + 40) = 1065353216;
		  this->fields.charAutoRimIntensity = (ClampedFloatParameter *)v81;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimIntensity, v4, v82, v83, *(MethodInfo **)&v107.x);
		  v84 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v84 )
		    goto LABEL_32;
		  *(_DWORD *)(v84 + 24) = 1053609165;
		  *(_BYTE *)(v84 + 16) = 0;
		  *(_DWORD *)(v84 + 32) = 0;
		  *(_DWORD *)(v84 + 36) = 1065353216;
		  *(_DWORD *)(v84 + 40) = 1065353216;
		  this->fields.charAutoRimWidth = (ClampedFloatParameter *)v84;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimWidth, v4, v85, v86, *(MethodInfo **)&v107.x);
		  v87 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v87 )
		    goto LABEL_32;
		  v87->fields._.m_Value = 0;
		  v87->fields._._.overrideState = 0;
		  this->fields.charFaceRimEnable = v87;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimEnable, v4, v88, v89, *(MethodInfo **)&v107.x);
		  v91 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v107, v90));
		  v92 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v92 )
		    goto LABEL_32;
		  *(_WORD *)(v92 + 41) = 257;
		  *(__m128i *)(v92 + 24) = v91;
		  *(_BYTE *)(v92 + 16) = 0;
		  this->fields.charFaceRimColor = (ColorParameter *)v92;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimColor, v4, v93, v94, *(MethodInfo **)&v107.x);
		  v95 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v95 )
		    goto LABEL_32;
		  *(_DWORD *)(v95 + 24) = 0;
		  *(_BYTE *)(v95 + 16) = 0;
		  *(_DWORD *)(v95 + 32) = 0;
		  *(_DWORD *)(v95 + 36) = 1065353216;
		  *(_DWORD *)(v95 + 40) = 1065353216;
		  this->fields.charFaceRimDir = (ClampedFloatParameter *)v95;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimDir, v4, v96, v97, *(MethodInfo **)&v107.x);
		  v98 = sub_18002C620(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v98 )
		    goto LABEL_32;
		  *(_DWORD *)(v98 + 24) = 1065353216;
		  *(_BYTE *)(v98 + 16) = 0;
		  *(_DWORD *)(v98 + 32) = 0;
		  *(_DWORD *)(v98 + 36) = 1092616192;
		  *(_DWORD *)(v98 + 40) = 1065353216;
		  this->fields.charFaceRimIntensity = (ClampedFloatParameter *)v98;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimIntensity, v4, v99, v100, *(MethodInfo **)&v107.x);
		  v101 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v101
		    || (v101->fields._.m_Value = 0,
		        v101->fields._._.overrideState = 0,
		        this->fields.charIgnoreSceneAdditionalLights = v101,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this->fields.charIgnoreSceneAdditionalLights,
		          v4,
		          v102,
		          v103,
		          *(MethodInfo **)&v107.x),
		        (v104 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter)) == 0LL) )
		  {
		LABEL_32:
		    sub_1800D8260(v5, v4);
		  }
		  v104->fields._.m_Value = 0;
		  v104->fields._._.overrideState = 0;
		  this->fields.charIgnoreSceneEnv = v104;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charIgnoreSceneEnv, v4, v105, v106, v108);
		}
		
	}
}
