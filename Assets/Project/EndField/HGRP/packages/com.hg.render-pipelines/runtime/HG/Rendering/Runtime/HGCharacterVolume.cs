using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/HGCharacter/CharacterLighting", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class HGCharacterVolume : VolumeComponent // TypeDefIndex: 38034
	{
		// Fields
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u53CD\u5C04Cube\u8D34\u56FE")]
		public CubemapParameter charMaxCubemap; // 0x30
		[Header("\u89D2\u8272\u73AF\u5883\u5149")]
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u73AF\u5883\u5149\u9884\u8BBE")]
		public CharacterAmbientModeParameter charAmbientModeIndex; // 0x38
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u73AF\u5883\u5149\u57FA\u7840\u5F3A\u5EA6")]
		public ClampedFloatParameter charAmbientLightBaseIntensity; // 0x40
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u73AF\u5883\u5149\u65B9\u5411")]
		public Vector2Parameter charAmbientLightCustomDir; // 0x48
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u73AF\u5883\u5149\u65B9\u5411\u6027\u5F3A\u5EA6")]
		public ClampedFloatParameter charAmbientLightDirIntensity; // 0x50
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u73AF\u5883\u5149\u65B9\u5411\u6027\u7CFB\u6570")]
		public ClampedFloatParameter charAmbientLightDirParam; // 0x58
		[HideInInspector]
		public Vector4Parameter charGlobalAmbientParam0; // 0x60
		[HideInInspector]
		public Vector4Parameter charGlobalAmbientParam1; // 0x68
		[Header("\u89D2\u8272\u5149\u7167\u63A7\u5236")]
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u706F\u5149\u624B\u52A8\u63A7\u5236\u6A21\u5F0F")]
		public BoolParameter charMainLightControl; // 0x70
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u4E3B\u5149\u6E90\u5F3A\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charMainLightMultiplier; // 0x78
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u80CC\u5149\u9762\u5F3A\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charEnvLightMultiplier; // 0x80
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u73AF\u5883\u4EAE\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charEnvShadowMultiplier; // 0x88
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u9AD8\u5149\u4EAE\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charMainLightSpecularMultiplier; // 0x90
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u773C\u775B\u6574\u4F53\u4EAE\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charEyeBaseLightMultiplier; // 0x98
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u773C\u775B\u9AD8\u5149\u4EAE\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charEyeHighlightMultiplier; // 0xA0
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u773C\u775B\u6563\u5C04\u4EAE\u5EA6\u7CFB\u6570")]
		public ClampedFloatParameter charEyeScatteringMultiplier; // 0xA8
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u660E\u6697\u4EA4\u754C\u7EBF\u504F\u79FB\u7CFB\u6570")]
		public ClampedFloatParameter charMainLightRangeBias; // 0xB0
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u5FFD\u7565\u4E3B\u5149\u6E90\u9634\u5F71")]
		public BoolParameter charIgnoreMainLightShadow; // 0xB8
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u4E3B\u5149\u6E90\u65B9\u5411\u6A21\u5F0F")]
		public CharacterLightModeParameter charMainLightMode; // 0xC0
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u81EA\u5B9A\u4E49\u4E3B\u5149\u6E90\u65B9\u5411")]
		public Vector2Parameter charCustomMainLightDir; // 0xC8
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u706F\u5149\u76F8\u5BF9\u4E8E\u76F8\u673A\u7684\u504F\u79FB\u89D2\u5EA6")]
		public Vector2Parameter charCameraFollowMainLightBias; // 0xD0
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u4E3B\u5149\u6E90\u81EA\u5B9A\u4E49\u989C\u8272")]
		public ColorParameter charMainLightOverrideColor; // 0xD8
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u76AE\u80A4\u4E3B\u5149\u6E90\u81EA\u5B9A\u4E49\u989C\u8272")]
		public ColorParameter charSkinMainLightOverrideColor; // 0xE0
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u5149\u7167\u6F14\u51FA\u6A21\u5F0F")]
		[Tooltip("\u6839\u636E\u573A\u666F\u5185\u5149\u7167\u81EA\u52A8\u9002\u914D\u9002\u5408Dialog\u7B49\u7279\u5199\u4E0B\u7684\u89D2\u8272\u5149\u7167\u8868\u73B0\uFF0C\u573A\u666F\u5149\u7167\u8F83\u6697\u65F6\uFF0C\u589E\u52A0\u89D2\u8272\u7F8E\u89C2\u6027\uFF0C\u964D\u4F4E\u89D2\u8272\u548C\u573A\u666F\u7684\u878D\u5408\u5EA6")]
		public BoolParameter charLightDialogMode; // 0xE8
		[Header("\u89D2\u8272\u9634\u5F71\u8272\u8C03")]
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u9634\u5F71\u8272\u8C03\u63A7\u5236")]
		public CharacterShadowTintModeParameter charShadowTintControl; // 0xF0
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u9634\u5F71\u989C\u8272\u503E\u5411\uFF08\u9664\u76AE\u80A4\u5916\uFF09")]
		public ColorParameter charShadowTintColor; // 0xF8
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u76AE\u80A4\u9634\u5F71\u989C\u8272\u503E\u5411")]
		public ColorParameter charSkinShadowTintColor; // 0x100
		[Header("\u89D2\u8272\u81EA\u6295\u5F71")]
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u81EA\u9634\u5F71\u6A21\u5F0F")]
		public CharacterModeParameter charShadowMode; // 0x108
		[Header("\u89D2\u8272\u8FB9\u7F18\u5149")]
		[HideInInspector]
		[InspectorName("\u542F\u7528\u4E00\u952E\u8FB9\u7F18\u5149")]
		public BoolParameter charAutoRimEnable; // 0x110
		[HideInInspector]
		[InspectorName("\u8FB9\u7F18\u5149\u989C\u8272")]
		public ColorParameter charAutoRimColor; // 0x118
		[HideInInspector]
		[InspectorName("\u8FB9\u7F18\u5149\u65B9\u5411")]
		public ClampedFloatParameter charAutoRimDir; // 0x120
		[HideInInspector]
		[InspectorName("\u8FB9\u7F18\u5149\u5F3A\u5EA6")]
		public ClampedFloatParameter charAutoRimIntensity; // 0x128
		[HideInInspector]
		[InspectorName("\u8FB9\u7F18\u5149\u5BBD\u5EA6")]
		public ClampedFloatParameter charAutoRimWidth; // 0x130
		[HideInInspector]
		[InspectorName("\u8FB9\u7F18\u5149\u53D7\u57FA\u7840\u8272\u5F71\u54CD\u7A0B\u5EA6")]
		public ClampedFloatParameter charAutoRimAlbedo; // 0x138
		[HideInInspector]
		[InspectorName("\u8FB9\u7F18\u5149\u65B0\u8BA1\u7B97\u65B9\u5F0F")]
		public BoolParameter charAutoRimMode; // 0x140
		[Header("\u8138\u90E8\u8FB9\u7F18\u5149")]
		[HideInInspector]
		[InspectorName("\u542F\u7528\u8138\u90E8\u989D\u5916\u8FB9\u7F18\u5149")]
		public BoolParameter charFaceRimEnable; // 0x148
		[HideInInspector]
		[InspectorName("\u8138\u90E8\u8FB9\u7F18\u5149\u989C\u8272")]
		public ColorParameter charFaceRimColor; // 0x150
		[HideInInspector]
		[InspectorName("\u8138\u90E8\u8FB9\u7F18\u5149\u65B9\u5411")]
		public ClampedFloatParameter charFaceRimDir; // 0x158
		[HideInInspector]
		[InspectorName("\u8138\u90E8\u8FB9\u7F18\u5149\u5F3A\u5EA6")]
		public ClampedFloatParameter charFaceRimIntensity; // 0x160
		[Header("\u89D2\u8272\u573A\u666F\u4EA4\u4E92\u6548\u679C")]
		[HideInInspector]
		[InspectorName("\u573A\u666F\u4EA4\u4E92\u6548\u679C\u5168\u5C40\u63A7\u5236")]
		public BoolParameter charRainEffectPreviewEnable; // 0x168
		[HideInInspector]
		[InspectorName("\u573A\u666F\u4EA4\u4E92\u6548\u679C\u7C7B\u578B")]
		public CharacterEnvironmentEffectModeParameter charEnvironmentEffectMode; // 0x170
		[HideInInspector]
		[InspectorName("\u79EF\u96EA\u6548\u679C\u5168\u5C40\u5F3A\u5EA6")]
		public ClampedFloatParameter charSnowEffectPreviewIntensity; // 0x178
		[HideInInspector]
		[InspectorName("\u6E7F\u6DA6\u6548\u679C\u5168\u5C40\u5F3A\u5EA6")]
		public ClampedFloatParameter charRainEffectPreviewIntensity; // 0x180
		[HideInInspector]
		[InspectorName("\u6C34\u7EBF\u9AD8\u5EA6")]
		public ClampedFloatParameter charWetEffectPreviewWorldHeight; // 0x188
		[HideInInspector]
		[InspectorName("\u73AF\u5883\u6548\u679C\u8D34\u56FEtiling")]
		public ClampedFloatParameter charRainEffectTextureTiling; // 0x190
		[Header("\u73AF\u5883\u5F71\u54CD")]
		[HideInInspector]
		[InspectorName("\u5FFD\u7565\u573A\u666F\u4E2D\u7684\u70B9\u5149")]
		public BoolParameter charIgnoreSceneAdditionalLights; // 0x198
		[HideInInspector]
		[InspectorName("\u5FFD\u7565\u573A\u666FEnv Volume\u5BF9\u89D2\u8272\u7684\u5F71\u54CD")]
		public BoolParameter charIgnoreSceneEnv; // 0x1A0
		[Header("\u6027\u80FD\u5206\u7EA7")]
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u63CF\u7EBF\u6027\u80FD\u5206\u7EA7")]
		public CharacterRenderFeatureQualityTierParameter charOutlineQualityMode; // 0x1A8
		[HideInInspector]
		[InspectorName("\u89D2\u8272\u81EA\u6295\u5F71\u6027\u80FD\u5206\u7EA7")]
		public CharacterRenderFeatureQualityTierParameter charSelfShadowQualityMode; // 0x1B0
	
		// Nested types
		[Serializable]
		public sealed class CharacterModeParameter : VolumeParameter<CharacterShadowMode> // TypeDefIndex: 38022
		{
			// Constructors
			public CharacterModeParameter() {} // Dummy constructor
			public CharacterModeParameter(CharacterShadowMode value, bool overrideState = false /* Metadata: 0x0230382D */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
			// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        bool overrideState,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			  this->fields._.overrideState = overrideState;
			}
			
		}
	
		[Serializable]
		public sealed class CharacterLightModeParameter : VolumeParameter<CharacterLightMode> // TypeDefIndex: 38023
		{
			// Constructors
			public CharacterLightModeParameter() {} // Dummy constructor
			public CharacterLightModeParameter(CharacterLightMode value, bool overrideState = false /* Metadata: 0x0230382E */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
			// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        bool overrideState,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			  this->fields._.overrideState = overrideState;
			}
			
		}
	
		[Serializable]
		public sealed class CharacterRenderFeatureQualityTierParameter : VolumeParameter<CharacterRenderFeatureQualityTier> // TypeDefIndex: 38024
		{
			// Constructors
			public CharacterRenderFeatureQualityTierParameter() {} // Dummy constructor
			public CharacterRenderFeatureQualityTierParameter(CharacterRenderFeatureQualityTier value, bool overrideState = false /* Metadata: 0x0230382F */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
			// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        bool overrideState,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			  this->fields._.overrideState = overrideState;
			}
			
		}
	
		[Serializable]
		public sealed class CharacterShadowTintModeParameter : VolumeParameter<CharacterShadowTintMode> // TypeDefIndex: 38025
		{
			// Constructors
			public CharacterShadowTintModeParameter() {} // Dummy constructor
			public CharacterShadowTintModeParameter(CharacterShadowTintMode value, bool overrideState = false /* Metadata: 0x02303830 */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
			// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        bool overrideState,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			  this->fields._.overrideState = overrideState;
			}
			
		}
	
		[Serializable]
		public sealed class CharacterAmbientModeParameter : VolumeParameter<CharacterAmbientMode> // TypeDefIndex: 38026
		{
			// Constructors
			public CharacterAmbientModeParameter() {} // Dummy constructor
			public CharacterAmbientModeParameter(CharacterAmbientMode value, bool overrideState = false /* Metadata: 0x02303831 */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
			// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        bool overrideState,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			  this->fields._.overrideState = overrideState;
			}
			
		}
	
		[Serializable]
		public sealed class CharacterEnvironmentEffectModeParameter : VolumeParameter<CharacterEnvironmentEffectMode> // TypeDefIndex: 38027
		{
			// Constructors
			public CharacterEnvironmentEffectModeParameter() {} // Dummy constructor
			public CharacterEnvironmentEffectModeParameter(CharacterEnvironmentEffectMode value, bool overrideState = false /* Metadata: 0x02303832 */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
			// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        bool overrideState,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			  this->fields._.overrideState = overrideState;
			}
			
		}
	
		public enum CharacterShadowMode // TypeDefIndex: 38028
		{
			SceneLight = 0,
			CameraVirtualLight = 1
		}
	
		public enum CharacterLightMode // TypeDefIndex: 38029
		{
			Scene = 0,
			CameraFollow = 1,
			Custom = 2
		}
	
		public enum CharacterRenderFeatureQualityTier // TypeDefIndex: 38030
		{
			AlwaysOn = 0,
			Tier10 = 10,
			Tier20 = 20,
			AlwaysOff = 2147483647
		}
	
		public enum CharacterShadowTintMode // TypeDefIndex: 38031
		{
			Auto = 0,
			CustomTintColor = 1
		}
	
		public enum CharacterAmbientMode // TypeDefIndex: 38032
		{
			Default = 0,
			TopLight_LowContrast = 1,
			TopLight_HighContrast = 2,
			InDoor_Normal = 10,
			InDoor_Bright = 11,
			InDoor_Dark = 12,
			Custom = 255
		}
	
		public enum CharacterEnvironmentEffectMode // TypeDefIndex: 38033
		{
			Rain = 0,
			Snow = 1
		}
	
		// Constructors
		public HGCharacterVolume() {} // 0x000000018402CBD0-0x000000018402D730
		// HGCharacterVolume()
		void HG::Rendering::Runtime::HGCharacterVolume::HGCharacterVolume(HGCharacterVolume *this, MethodInfo *method)
		{
		  CubemapParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  CubemapParameter *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  HGCharacterVolume_CharacterAmbientModeParameter *v10; // rax
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  __int64 v13; // rax
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // rax
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rax
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rax
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  __int64 v28; // rax
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  BoolParameter *v31; // rax
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  __int64 v34; // rax
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  __int64 v37; // rax
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  __int64 v40; // rax
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  __int64 v43; // rax
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  __int64 v46; // rax
		  PropertyInfo_1 *v47; // r8
		  Int32__Array **v48; // r9
		  __int64 v49; // rax
		  PropertyInfo_1 *v50; // r8
		  Int32__Array **v51; // r9
		  __int64 v52; // rax
		  PropertyInfo_1 *v53; // r8
		  Int32__Array **v54; // r9
		  __int64 v55; // rax
		  PropertyInfo_1 *v56; // r8
		  Int32__Array **v57; // r9
		  BoolParameter *v58; // rax
		  PropertyInfo_1 *v59; // r8
		  Int32__Array **v60; // r9
		  HGCharacterVolume_CharacterLightModeParameter *v61; // rax
		  PropertyInfo_1 *v62; // r8
		  Int32__Array **v63; // r9
		  __int64 v64; // rax
		  PropertyInfo_1 *v65; // r8
		  Int32__Array **v66; // r9
		  __int64 v67; // rax
		  PropertyInfo_1 *v68; // r8
		  Int32__Array **v69; // r9
		  MethodInfo *v70; // rdx
		  Vector4 v71; // xmm6
		  __int64 v72; // rax
		  PropertyInfo_1 *v73; // r8
		  Int32__Array **v74; // r9
		  MethodInfo *v75; // rdx
		  Vector4 v76; // xmm6
		  __int64 v77; // rax
		  PropertyInfo_1 *v78; // r8
		  Int32__Array **v79; // r9
		  BoolParameter *v80; // rax
		  PropertyInfo_1 *v81; // r8
		  Int32__Array **v82; // r9
		  HGCharacterVolume_CharacterShadowTintModeParameter *v83; // rax
		  PropertyInfo_1 *v84; // r8
		  Int32__Array **v85; // r9
		  MethodInfo *v86; // rdx
		  Vector4 v87; // xmm6
		  __int64 v88; // rax
		  PropertyInfo_1 *v89; // r8
		  Int32__Array **v90; // r9
		  MethodInfo *v91; // rdx
		  Vector4 v92; // xmm6
		  __int64 v93; // rax
		  PropertyInfo_1 *v94; // r8
		  Int32__Array **v95; // r9
		  HGCharacterVolume_CharacterModeParameter *v96; // rax
		  PropertyInfo_1 *v97; // r8
		  Int32__Array **v98; // r9
		  BoolParameter *v99; // rax
		  PropertyInfo_1 *v100; // r8
		  Int32__Array **v101; // r9
		  MethodInfo *v102; // rdx
		  Vector4 v103; // xmm6
		  __int64 v104; // rax
		  PropertyInfo_1 *v105; // r8
		  Int32__Array **v106; // r9
		  __int64 v107; // rax
		  PropertyInfo_1 *v108; // r8
		  Int32__Array **v109; // r9
		  __int64 v110; // rax
		  PropertyInfo_1 *v111; // r8
		  Int32__Array **v112; // r9
		  __int64 v113; // rax
		  PropertyInfo_1 *v114; // r8
		  Int32__Array **v115; // r9
		  __int64 v116; // rax
		  PropertyInfo_1 *v117; // r8
		  Int32__Array **v118; // r9
		  BoolParameter *v119; // rax
		  PropertyInfo_1 *v120; // r8
		  Int32__Array **v121; // r9
		  BoolParameter *v122; // rax
		  PropertyInfo_1 *v123; // r8
		  Int32__Array **v124; // r9
		  MethodInfo *v125; // rdx
		  Vector4 v126; // xmm6
		  __int64 v127; // rax
		  PropertyInfo_1 *v128; // r8
		  Int32__Array **v129; // r9
		  __int64 v130; // rax
		  PropertyInfo_1 *v131; // r8
		  Int32__Array **v132; // r9
		  __int64 v133; // rax
		  PropertyInfo_1 *v134; // r8
		  Int32__Array **v135; // r9
		  BoolParameter *v136; // rax
		  PropertyInfo_1 *v137; // r8
		  Int32__Array **v138; // r9
		  HGCharacterVolume_CharacterEnvironmentEffectModeParameter *v139; // rax
		  PropertyInfo_1 *v140; // r8
		  Int32__Array **v141; // r9
		  __int64 v142; // rax
		  PropertyInfo_1 *v143; // r8
		  Int32__Array **v144; // r9
		  __int64 v145; // rax
		  PropertyInfo_1 *v146; // r8
		  Int32__Array **v147; // r9
		  __int64 v148; // rax
		  PropertyInfo_1 *v149; // r8
		  Int32__Array **v150; // r9
		  __int64 v151; // rax
		  PropertyInfo_1 *v152; // r8
		  Int32__Array **v153; // r9
		  BoolParameter *v154; // rax
		  PropertyInfo_1 *v155; // r8
		  Int32__Array **v156; // r9
		  BoolParameter *v157; // rax
		  PropertyInfo_1 *v158; // r8
		  Int32__Array **v159; // r9
		  HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v160; // rax
		  PropertyInfo_1 *v161; // r8
		  Int32__Array **v162; // r9
		  HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *v163; // rax
		  PropertyInfo_1 *v164; // r8
		  Int32__Array **v165; // r9
		  Vector4 v166; // [rsp+20h] [rbp-28h] BYREF
		
		  v3 = (CubemapParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::CubemapParameter);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_51;
		  UnityEngine::Rendering::CubemapParameter::CubemapParameter(v3, 0LL, 0, 0LL);
		  this->fields.charMaxCubemap = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMaxCubemap, v7, v8, v9, *(MethodInfo **)&v166.x);
		  v10 = (HGCharacterVolume_CharacterAmbientModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterAmbientModeParameter);
		  if ( !v10 )
		    goto LABEL_51;
		  v10->fields._.m_Value = 0;
		  v10->fields._._.overrideState = 0;
		  this->fields.charAmbientModeIndex = v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAmbientModeIndex, v4, v11, v12, *(MethodInfo **)&v166.x);
		  v13 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v13 )
		    goto LABEL_51;
		  *(_DWORD *)(v13 + 24) = 1065353216;
		  *(_BYTE *)(v13 + 16) = 1;
		  *(_DWORD *)(v13 + 32) = 0;
		  *(_DWORD *)(v13 + 36) = 1084227584;
		  *(_DWORD *)(v13 + 40) = 1065353216;
		  this->fields.charAmbientLightBaseIntensity = (ClampedFloatParameter *)v13;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charAmbientLightBaseIntensity,
		    v4,
		    v14,
		    v15,
		    *(MethodInfo **)&v166.x);
		  v16 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v16 )
		    goto LABEL_51;
		  *(_QWORD *)(v16 + 24) = 1127481344LL;
		  *(_BYTE *)(v16 + 16) = 1;
		  this->fields.charAmbientLightCustomDir = (Vector2Parameter *)v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAmbientLightCustomDir, v4, v17, v18, *(MethodInfo **)&v166.x);
		  v19 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v19 )
		    goto LABEL_51;
		  *(_DWORD *)(v19 + 24) = 1058642330;
		  *(_BYTE *)(v19 + 16) = 1;
		  *(_DWORD *)(v19 + 32) = 0;
		  *(_DWORD *)(v19 + 36) = 1084227584;
		  *(_DWORD *)(v19 + 40) = 1065353216;
		  this->fields.charAmbientLightDirIntensity = (ClampedFloatParameter *)v19;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charAmbientLightDirIntensity,
		    v4,
		    v20,
		    v21,
		    *(MethodInfo **)&v166.x);
		  v22 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v22 )
		    goto LABEL_51;
		  *(_DWORD *)(v22 + 24) = 1041865114;
		  *(_BYTE *)(v22 + 16) = 1;
		  *(_DWORD *)(v22 + 32) = -1090519040;
		  *(_DWORD *)(v22 + 36) = 1056964608;
		  *(_DWORD *)(v22 + 40) = 1065353216;
		  this->fields.charAmbientLightDirParam = (ClampedFloatParameter *)v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAmbientLightDirParam, v4, v23, v24, *(MethodInfo **)&v166.x);
		  v25 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v25 )
		    goto LABEL_51;
		  *(__m128i *)(v25 + 24) = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		  *(_BYTE *)(v25 + 16) = 0;
		  this->fields.charGlobalAmbientParam0 = (Vector4Parameter *)v25;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charGlobalAmbientParam0, v4, v26, v27, *(MethodInfo **)&v166.x);
		  v28 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v28 )
		    goto LABEL_51;
		  *(__m128i *)(v28 + 24) = _mm_load_si128((const __m128i *)&xmmword_18B959920);
		  *(_BYTE *)(v28 + 16) = 0;
		  this->fields.charGlobalAmbientParam1 = (Vector4Parameter *)v28;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charGlobalAmbientParam1, v4, v29, v30, *(MethodInfo **)&v166.x);
		  v31 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v31 )
		    goto LABEL_51;
		  v31->fields._.m_Value = 0;
		  v31->fields._._.overrideState = 0;
		  this->fields.charMainLightControl = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightControl, v4, v32, v33, *(MethodInfo **)&v166.x);
		  v34 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v34 )
		    goto LABEL_51;
		  *(_DWORD *)(v34 + 24) = 1065353216;
		  *(_BYTE *)(v34 + 16) = 0;
		  *(_DWORD *)(v34 + 32) = 0;
		  *(_DWORD *)(v34 + 36) = 1084227584;
		  *(_DWORD *)(v34 + 40) = 1065353216;
		  this->fields.charMainLightMultiplier = (ClampedFloatParameter *)v34;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightMultiplier, v4, v35, v36, *(MethodInfo **)&v166.x);
		  v37 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v37 )
		    goto LABEL_51;
		  *(_DWORD *)(v37 + 24) = 1060320051;
		  *(_BYTE *)(v37 + 16) = 0;
		  *(_DWORD *)(v37 + 32) = 0;
		  *(_DWORD *)(v37 + 36) = 1077936128;
		  *(_DWORD *)(v37 + 40) = 1065353216;
		  this->fields.charEnvLightMultiplier = (ClampedFloatParameter *)v37;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEnvLightMultiplier, v4, v38, v39, *(MethodInfo **)&v166.x);
		  v40 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v40 )
		    goto LABEL_51;
		  *(_DWORD *)(v40 + 24) = 1065353216;
		  *(_BYTE *)(v40 + 16) = 0;
		  *(_DWORD *)(v40 + 32) = 0;
		  *(_DWORD *)(v40 + 36) = 0x40000000;
		  *(_DWORD *)(v40 + 40) = 1065353216;
		  this->fields.charEnvShadowMultiplier = (ClampedFloatParameter *)v40;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEnvShadowMultiplier, v4, v41, v42, *(MethodInfo **)&v166.x);
		  v43 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v43 )
		    goto LABEL_51;
		  *(_DWORD *)(v43 + 24) = 1065353216;
		  *(_BYTE *)(v43 + 16) = 0;
		  *(_DWORD *)(v43 + 32) = 0;
		  *(_DWORD *)(v43 + 36) = 0x40000000;
		  *(_DWORD *)(v43 + 40) = 1065353216;
		  this->fields.charMainLightSpecularMultiplier = (ClampedFloatParameter *)v43;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charMainLightSpecularMultiplier,
		    v4,
		    v44,
		    v45,
		    *(MethodInfo **)&v166.x);
		  v46 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v46 )
		    goto LABEL_51;
		  *(_DWORD *)(v46 + 24) = 0;
		  *(_BYTE *)(v46 + 16) = 0;
		  *(_DWORD *)(v46 + 32) = 0;
		  *(_DWORD *)(v46 + 36) = 1077936128;
		  *(_DWORD *)(v46 + 40) = 1065353216;
		  this->fields.charEyeBaseLightMultiplier = (ClampedFloatParameter *)v46;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEyeBaseLightMultiplier, v4, v47, v48, *(MethodInfo **)&v166.x);
		  v49 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v49 )
		    goto LABEL_51;
		  *(_DWORD *)(v49 + 24) = 0;
		  *(_BYTE *)(v49 + 16) = 0;
		  *(_DWORD *)(v49 + 32) = 0;
		  *(_DWORD *)(v49 + 36) = 1077936128;
		  *(_DWORD *)(v49 + 40) = 1065353216;
		  this->fields.charEyeHighlightMultiplier = (ClampedFloatParameter *)v49;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEyeHighlightMultiplier, v4, v50, v51, *(MethodInfo **)&v166.x);
		  v52 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v52 )
		    goto LABEL_51;
		  *(_DWORD *)(v52 + 24) = 0;
		  *(_BYTE *)(v52 + 16) = 0;
		  *(_DWORD *)(v52 + 32) = 0;
		  *(_DWORD *)(v52 + 36) = 1077936128;
		  *(_DWORD *)(v52 + 40) = 1065353216;
		  this->fields.charEyeScatteringMultiplier = (ClampedFloatParameter *)v52;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEyeScatteringMultiplier, v4, v53, v54, *(MethodInfo **)&v166.x);
		  v55 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v55 )
		    goto LABEL_51;
		  *(_DWORD *)(v55 + 24) = 0;
		  *(_BYTE *)(v55 + 16) = 0;
		  *(_DWORD *)(v55 + 32) = -1082130432;
		  *(_DWORD *)(v55 + 36) = 1065353216;
		  *(_DWORD *)(v55 + 40) = 1065353216;
		  this->fields.charMainLightRangeBias = (ClampedFloatParameter *)v55;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightRangeBias, v4, v56, v57, *(MethodInfo **)&v166.x);
		  v58 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v58 )
		    goto LABEL_51;
		  v58->fields._.m_Value = 0;
		  v58->fields._._.overrideState = 0;
		  this->fields.charIgnoreMainLightShadow = v58;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charIgnoreMainLightShadow, v4, v59, v60, *(MethodInfo **)&v166.x);
		  v61 = (HGCharacterVolume_CharacterLightModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterLightModeParameter);
		  if ( !v61 )
		    goto LABEL_51;
		  v61->fields._.m_Value = 0;
		  v61->fields._._.overrideState = 0;
		  this->fields.charMainLightMode = v61;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightMode, v4, v62, v63, *(MethodInfo **)&v166.x);
		  v64 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v64 )
		    goto LABEL_51;
		  *(_DWORD *)(v64 + 24) = 1106247680;
		  *(_DWORD *)(v64 + 28) = 1125515264;
		  *(_BYTE *)(v64 + 16) = 1;
		  this->fields.charCustomMainLightDir = (Vector2Parameter *)v64;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charCustomMainLightDir, v4, v65, v66, *(MethodInfo **)&v166.x);
		  v67 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v67 )
		    goto LABEL_51;
		  *(_DWORD *)(v67 + 24) = 1106247680;
		  *(_DWORD *)(v67 + 28) = 1092616192;
		  *(_BYTE *)(v67 + 16) = 1;
		  this->fields.charCameraFollowMainLightBias = (Vector2Parameter *)v67;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charCameraFollowMainLightBias,
		    v4,
		    v68,
		    v69,
		    *(MethodInfo **)&v166.x);
		  v71 = *UnityEngine::Vector4::get_one(&v166, v70);
		  v72 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v72 )
		    goto LABEL_51;
		  *(_WORD *)(v72 + 41) = 257;
		  *(Vector4 *)(v72 + 24) = v71;
		  *(_BYTE *)(v72 + 16) = 0;
		  this->fields.charMainLightOverrideColor = (ColorParameter *)v72;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charMainLightOverrideColor, v4, v73, v74, *(MethodInfo **)&v166.x);
		  v76 = *UnityEngine::Vector4::get_one(&v166, v75);
		  v77 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v77 )
		    goto LABEL_51;
		  *(_WORD *)(v77 + 41) = 257;
		  *(Vector4 *)(v77 + 24) = v76;
		  *(_BYTE *)(v77 + 16) = 0;
		  this->fields.charSkinMainLightOverrideColor = (ColorParameter *)v77;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charSkinMainLightOverrideColor,
		    v4,
		    v78,
		    v79,
		    *(MethodInfo **)&v166.x);
		  v80 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v80 )
		    goto LABEL_51;
		  v80->fields._.m_Value = 0;
		  v80->fields._._.overrideState = 0;
		  this->fields.charLightDialogMode = v80;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charLightDialogMode, v4, v81, v82, *(MethodInfo **)&v166.x);
		  v83 = (HGCharacterVolume_CharacterShadowTintModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterShadowTintModeParameter);
		  if ( !v83 )
		    goto LABEL_51;
		  v83->fields._.m_Value = 0;
		  v83->fields._._.overrideState = 0;
		  this->fields.charShadowTintControl = v83;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charShadowTintControl, v4, v84, v85, *(MethodInfo **)&v166.x);
		  v87 = *UnityEngine::Vector4::get_one(&v166, v86);
		  v88 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v88 )
		    goto LABEL_51;
		  *(_WORD *)(v88 + 41) = 257;
		  *(Vector4 *)(v88 + 24) = v87;
		  *(_BYTE *)(v88 + 16) = 0;
		  this->fields.charShadowTintColor = (ColorParameter *)v88;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charShadowTintColor, v4, v89, v90, *(MethodInfo **)&v166.x);
		  v92 = *UnityEngine::Vector4::get_one(&v166, v91);
		  v93 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v93 )
		    goto LABEL_51;
		  *(_WORD *)(v93 + 41) = 257;
		  *(Vector4 *)(v93 + 24) = v92;
		  *(_BYTE *)(v93 + 16) = 0;
		  this->fields.charSkinShadowTintColor = (ColorParameter *)v93;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charSkinShadowTintColor, v4, v94, v95, *(MethodInfo **)&v166.x);
		  v96 = (HGCharacterVolume_CharacterModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterModeParameter);
		  if ( !v96 )
		    goto LABEL_51;
		  v96->fields._.m_Value = 1;
		  v96->fields._._.overrideState = 0;
		  this->fields.charShadowMode = v96;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charShadowMode, v4, v97, v98, *(MethodInfo **)&v166.x);
		  v99 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v99 )
		    goto LABEL_51;
		  v99->fields._.m_Value = 0;
		  v99->fields._._.overrideState = 0;
		  this->fields.charAutoRimEnable = v99;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimEnable, v4, v100, v101, *(MethodInfo **)&v166.x);
		  v103 = *UnityEngine::Vector4::get_one(&v166, v102);
		  v104 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v104 )
		    goto LABEL_51;
		  *(_WORD *)(v104 + 41) = 257;
		  *(Vector4 *)(v104 + 24) = v103;
		  *(_BYTE *)(v104 + 16) = 0;
		  this->fields.charAutoRimColor = (ColorParameter *)v104;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimColor, v4, v105, v106, *(MethodInfo **)&v166.x);
		  v107 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v107 )
		    goto LABEL_51;
		  *(_DWORD *)(v107 + 24) = 0;
		  *(_BYTE *)(v107 + 16) = 0;
		  *(_DWORD *)(v107 + 32) = 0;
		  *(_DWORD *)(v107 + 36) = 1065353216;
		  *(_DWORD *)(v107 + 40) = 1065353216;
		  this->fields.charAutoRimDir = (ClampedFloatParameter *)v107;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimDir, v4, v108, v109, *(MethodInfo **)&v166.x);
		  v110 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v110 )
		    goto LABEL_51;
		  *(_DWORD *)(v110 + 24) = 1065353216;
		  *(_BYTE *)(v110 + 16) = 0;
		  *(_DWORD *)(v110 + 32) = 0;
		  *(_DWORD *)(v110 + 36) = 1092616192;
		  *(_DWORD *)(v110 + 40) = 1065353216;
		  this->fields.charAutoRimIntensity = (ClampedFloatParameter *)v110;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimIntensity, v4, v111, v112, *(MethodInfo **)&v166.x);
		  v113 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v113 )
		    goto LABEL_51;
		  *(_DWORD *)(v113 + 24) = 1053609165;
		  *(_BYTE *)(v113 + 16) = 0;
		  *(_DWORD *)(v113 + 32) = 0;
		  *(_DWORD *)(v113 + 36) = 1065353216;
		  *(_DWORD *)(v113 + 40) = 1065353216;
		  this->fields.charAutoRimWidth = (ClampedFloatParameter *)v113;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimWidth, v4, v114, v115, *(MethodInfo **)&v166.x);
		  v116 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v116 )
		    goto LABEL_51;
		  *(_DWORD *)(v116 + 24) = 0;
		  *(_BYTE *)(v116 + 16) = 0;
		  *(_DWORD *)(v116 + 32) = 0;
		  *(_DWORD *)(v116 + 36) = 1065353216;
		  *(_DWORD *)(v116 + 40) = 1065353216;
		  this->fields.charAutoRimAlbedo = (ClampedFloatParameter *)v116;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimAlbedo, v4, v117, v118, *(MethodInfo **)&v166.x);
		  v119 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v119 )
		    goto LABEL_51;
		  v119->fields._.m_Value = 0;
		  v119->fields._._.overrideState = 0;
		  this->fields.charAutoRimMode = v119;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charAutoRimMode, v4, v120, v121, *(MethodInfo **)&v166.x);
		  v122 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v122 )
		    goto LABEL_51;
		  v122->fields._.m_Value = 0;
		  v122->fields._._.overrideState = 0;
		  this->fields.charFaceRimEnable = v122;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimEnable, v4, v123, v124, *(MethodInfo **)&v166.x);
		  v126 = *UnityEngine::Vector4::get_one(&v166, v125);
		  v127 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v127 )
		    goto LABEL_51;
		  *(_WORD *)(v127 + 41) = 257;
		  *(Vector4 *)(v127 + 24) = v126;
		  *(_BYTE *)(v127 + 16) = 0;
		  this->fields.charFaceRimColor = (ColorParameter *)v127;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimColor, v4, v128, v129, *(MethodInfo **)&v166.x);
		  v130 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v130 )
		    goto LABEL_51;
		  *(_DWORD *)(v130 + 24) = 0;
		  *(_BYTE *)(v130 + 16) = 0;
		  *(_DWORD *)(v130 + 32) = 0;
		  *(_DWORD *)(v130 + 36) = 1065353216;
		  *(_DWORD *)(v130 + 40) = 1065353216;
		  this->fields.charFaceRimDir = (ClampedFloatParameter *)v130;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimDir, v4, v131, v132, *(MethodInfo **)&v166.x);
		  v133 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v133 )
		    goto LABEL_51;
		  *(_DWORD *)(v133 + 24) = 1065353216;
		  *(_BYTE *)(v133 + 16) = 0;
		  *(_DWORD *)(v133 + 32) = 0;
		  *(_DWORD *)(v133 + 36) = 1092616192;
		  *(_DWORD *)(v133 + 40) = 1065353216;
		  this->fields.charFaceRimIntensity = (ClampedFloatParameter *)v133;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charFaceRimIntensity, v4, v134, v135, *(MethodInfo **)&v166.x);
		  v136 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v136 )
		    goto LABEL_51;
		  v136->fields._.m_Value = 0;
		  v136->fields._._.overrideState = 0;
		  this->fields.charRainEffectPreviewEnable = v136;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charRainEffectPreviewEnable,
		    v4,
		    v137,
		    v138,
		    *(MethodInfo **)&v166.x);
		  v139 = (HGCharacterVolume_CharacterEnvironmentEffectModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterEnvironmentEffectModeParameter);
		  if ( !v139 )
		    goto LABEL_51;
		  v139->fields._.m_Value = 0;
		  v139->fields._._.overrideState = 0;
		  this->fields.charEnvironmentEffectMode = v139;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charEnvironmentEffectMode, v4, v140, v141, *(MethodInfo **)&v166.x);
		  v142 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v142 )
		    goto LABEL_51;
		  *(_DWORD *)(v142 + 24) = 0;
		  *(_BYTE *)(v142 + 16) = 0;
		  *(_DWORD *)(v142 + 32) = 0;
		  *(_DWORD *)(v142 + 36) = 1065353216;
		  *(_DWORD *)(v142 + 40) = 1065353216;
		  this->fields.charSnowEffectPreviewIntensity = (ClampedFloatParameter *)v142;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charSnowEffectPreviewIntensity,
		    v4,
		    v143,
		    v144,
		    *(MethodInfo **)&v166.x);
		  v145 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v145 )
		    goto LABEL_51;
		  *(_DWORD *)(v145 + 24) = 0;
		  *(_BYTE *)(v145 + 16) = 0;
		  *(_DWORD *)(v145 + 32) = 0;
		  *(_DWORD *)(v145 + 36) = 1065353216;
		  *(_DWORD *)(v145 + 40) = 1065353216;
		  this->fields.charRainEffectPreviewIntensity = (ClampedFloatParameter *)v145;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charRainEffectPreviewIntensity,
		    v4,
		    v146,
		    v147,
		    *(MethodInfo **)&v166.x);
		  v148 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v148 )
		    goto LABEL_51;
		  *(_DWORD *)(v148 + 24) = -1027080192;
		  *(_BYTE *)(v148 + 16) = 0;
		  *(_DWORD *)(v148 + 32) = -1027080192;
		  *(_DWORD *)(v148 + 36) = 1128792064;
		  *(_DWORD *)(v148 + 40) = 1065353216;
		  this->fields.charWetEffectPreviewWorldHeight = (ClampedFloatParameter *)v148;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charWetEffectPreviewWorldHeight,
		    v4,
		    v149,
		    v150,
		    *(MethodInfo **)&v166.x);
		  v151 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v151 )
		    goto LABEL_51;
		  *(_DWORD *)(v151 + 24) = 0x40000000;
		  *(_BYTE *)(v151 + 16) = 0;
		  *(_DWORD *)(v151 + 32) = 1036831949;
		  *(_DWORD *)(v151 + 36) = 1092616192;
		  *(_DWORD *)(v151 + 40) = 1065353216;
		  this->fields.charRainEffectTextureTiling = (ClampedFloatParameter *)v151;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charRainEffectTextureTiling,
		    v4,
		    v152,
		    v153,
		    *(MethodInfo **)&v166.x);
		  v154 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v154 )
		    goto LABEL_51;
		  v154->fields._.m_Value = 0;
		  v154->fields._._.overrideState = 0;
		  this->fields.charIgnoreSceneAdditionalLights = v154;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.charIgnoreSceneAdditionalLights,
		    v4,
		    v155,
		    v156,
		    *(MethodInfo **)&v166.x);
		  v157 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v157 )
		    goto LABEL_51;
		  v157->fields._.m_Value = 0;
		  v157->fields._._.overrideState = 0;
		  this->fields.charIgnoreSceneEnv = v157;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charIgnoreSceneEnv, v4, v158, v159, *(MethodInfo **)&v166.x);
		  v160 = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter);
		  if ( !v160
		    || (v160->fields._.m_Value = 20,
		        v160->fields._._.overrideState = 0,
		        this->fields.charOutlineQualityMode = v160,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this->fields.charOutlineQualityMode,
		          v4,
		          v161,
		          v162,
		          *(MethodInfo **)&v166.x),
		        (v163 = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGCharacterVolume::CharacterRenderFeatureQualityTierParameter)) == 0LL) )
		  {
		LABEL_51:
		    sub_1800D8260(v5, v4);
		  }
		  v163->fields._.m_Value = 20;
		  v163->fields._._.overrideState = 0;
		  this->fields.charSelfShadowQualityMode = v163;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.charSelfShadowQualityMode, v4, v164, v165, *(MethodInfo **)&v166.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public void SetCharMaxCubemap(Texture texture) {} // 0x0000000189B69994-0x0000000189B69A08
		// Void SetCharMaxCubemap(Texture)
		void HG::Rendering::Runtime::HGCharacterVolume::SetCharMaxCubemap(
		        HGCharacterVolume *this,
		        Texture *texture,
		        MethodInfo *method)
		{
		  CubemapParameter *v5; // rdx
		  __int64 v6; // rcx
		  CubemapParameter *charMaxCubemap; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2679, 0LL) )
		  {
		    charMaxCubemap = this->fields.charMaxCubemap;
		    if ( charMaxCubemap )
		    {
		      charMaxCubemap->fields._._.overrideState = 1;
		      v5 = this->fields.charMaxCubemap;
		      if ( v5 )
		      {
		        sub_18003BA30(v6, v5, texture);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2679, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)texture,
		    0LL);
		}
		
		public bool GetCharOutlinePassEnableState() => default; // 0x0000000183D4E9C0-0x0000000183D4EA60
		// Boolean GetCharOutlinePassEnableState()
		bool HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *wrapperArray; // rdx
		  int32_t v5; // eax
		  struct HGCharacterQualitySettings__Class *v6; // rcx
		  int32_t v7; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->fields._.m_Value <= 960 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x3C0 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[20].rgctx_data )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(960, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_9;
		  }
		LABEL_5:
		  wrapperArray = this->fields.charOutlineQualityMode;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  v5 = sub_180002F70(10LL, wrapperArray);
		  v6 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		  v7 = v5;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
		    v6 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		  }
		  return v6->static_fields->characterOutlineTierLevel >= v7;
		}
		
		public bool GetCharShadowPassEnableState() => default; // 0x000000018344EE50-0x000000018344EEF0
		// Boolean GetCharShadowPassEnableState()
		bool HG::Rendering::Runtime::HGCharacterVolume::GetCharShadowPassEnableState(
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *wrapperArray; // rdx
		  int32_t v5; // eax
		  struct HGCharacterQualitySettings__Class *v6; // rcx
		  int32_t v7; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (HGCharacterVolume_CharacterRenderFeatureQualityTierParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->fields._.m_Value <= 784 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x310 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( *(_QWORD *)&v3[16]._1.field_count )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(784, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_9;
		  }
		LABEL_5:
		  wrapperArray = this->fields.charSelfShadowQualityMode;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  v5 = sub_180002F70(10LL, wrapperArray);
		  v6 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		  v7 = v5;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
		    v6 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		  }
		  return v6->static_fields->characterShadowTierLevel >= v7;
		}
		
		[IDTag(1)]
		public Vector3 GetCharLightVector(Transform cameraTransform) => default; // 0x0000000183B71E40-0x0000000183B720E0
		// Vector3 GetCharLightVector(Transform)
		Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVector(
		        Vector3 *__return_ptr retstr,
		        HGCharacterVolume *this,
		        Transform *cameraTransform,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  HGCharacterVolume *v7; // rsi
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Vector2Parameter *charCustomMainLightDir; // rbx
		  float v10; // xmm8_4
		  const MethodInfo *v11; // r8
		  __m128 y_low; // xmm6
		  __m128 x_low; // xmm7
		  Vector2 v14; // r8
		  int32_t v15; // r9d
		  Beyond::DampingMath *v16; // rcx
		  __m128 v17; // xmm10
		  Beyond::DampingMath *v18; // rcx
		  Beyond::DampingMath *v19; // rcx
		  Beyond::DampingMath *v20; // rcx
		  __m128 v21; // xmm6
		  Beyond::DampingMath *v22; // rcx
		  unsigned __int64 v23; // xmm0_8
		  float z; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v27; // rax
		  __int64 v28; // xmm0_8
		  ILFixDynamicMethodWrapper *v29; // rax
		  ILFixDynamicMethodWrapper *v30; // rax
		  Vector3 *forward; // rax
		  __int64 v32; // xmm0_8
		  float v33; // xmm7_4
		  __int64 v34; // rax
		  __m128 v35; // xmm0
		  __m128 v36; // xmm0
		  ILFixDynamicMethodWrapper_2 *v37; // rax
		  Vector3 *v38; // rax
		  Quaternion v39; // [rsp+30h] [rbp-78h] BYREF
		  Quaternion v40; // [rsp+40h] [rbp-68h] BYREF
		  __int64 v41; // [rsp+B0h] [rbp+8h]
		  Vector2 v42; // [rsp+B0h] [rbp+8h]
		  Vector2 v43; // [rsp+B0h] [rbp+8h]
		  float v44; // [rsp+B0h] [rbp+8h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( wrapperArray->max_length.size > 908 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGCharacterVolume *)v6->static_fields->wrapperArray;
		    if ( !this )
		      goto LABEL_23;
		    if ( *(_DWORD *)&this->fields._.active <= 0x38Cu )
		      goto LABEL_48;
		    if ( this[16].fields.charSkinShadowTintColor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(908, 0LL);
		      if ( Patch )
		      {
		        v27 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_364(
		                (Vector3 *)&v39,
		                Patch,
		                (Object *)v7,
		                (Object *)cameraTransform,
		                0LL);
		        v28 = *(_QWORD *)&v27->x;
		        *(float *)&v27 = v27->z;
		        *(_QWORD *)&retstr->x = v28;
		        LODWORD(retstr->z) = (_DWORD)v27;
		        return retstr;
		      }
		      goto LABEL_23;
		    }
		  }
		  charCustomMainLightDir = v7->fields.charCustomMainLightDir;
		  if ( !charCustomMainLightDir )
		    goto LABEL_23;
		  sub_1800049A0(charCustomMainLightDir->klass);
		  v10 = 0.0;
		  v11 = charCustomMainLightDir->klass->vtable.get_value.method;
		  if ( v11 == (const MethodInfo *)Beyond::Gameplay::Core::PQSFilter::get_factorRange )
		  {
		    if ( IFix::WrappersManagerImpl::IsPatched(3547, 0LL) )
		    {
		      v29 = IFix::WrappersManagerImpl::GetPatch(3547, 0LL);
		      if ( !v29 )
		        goto LABEL_23;
		      x_low = (__m128)(unsigned __int64)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(
		                                          v29,
		                                          (Object *)charCustomMainLightDir,
		                                          0LL);
		    }
		    else
		    {
		      x_low = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL);
		    }
		    y_low = _mm_shuffle_ps(x_low, x_low, 85);
		  }
		  else if ( v11 == (const MethodInfo *)Beyond::Gameplay::Core::PQSEvaluator::get_factorRange )
		  {
		    if ( IFix::WrappersManagerImpl::IsPatched(58313, 0LL) )
		    {
		      v30 = IFix::WrappersManagerImpl::GetPatch(58313, 0LL);
		      if ( !v30 )
		        goto LABEL_23;
		      v43 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(v30, (Object *)charCustomMainLightDir, 0LL);
		      x_low = (__m128)LODWORD(v43.x);
		      y_low = (__m128)LODWORD(v43.y);
		    }
		    else
		    {
		      x_low = (__m128)HIDWORD(charCustomMainLightDir[3].monitor);
		      y_low = (__m128)*(unsigned int *)&charCustomMainLightDir[3].fields._._.overrideState;
		    }
		  }
		  else
		  {
		    v41 = ((__int64 (__fastcall *)(Vector2Parameter *, Il2CppMethodPointer))v11)(
		            charCustomMainLightDir,
		            charCustomMainLightDir->klass->vtable.set_value.methodPtr);
		    y_low = (__m128)HIDWORD(v41);
		    x_low = (__m128)(unsigned int)v41;
		  }
		  this = (HGCharacterVolume *)v7->fields.charMainLightMode;
		  if ( !this )
		    goto LABEL_23;
		  if ( (unsigned int)sub_180002F70(10LL, this) == 1 )
		  {
		    if ( !cameraTransform )
		      goto LABEL_23;
		    forward = UnityEngine::Transform::get_forward((Vector3 *)&v40, cameraTransform, 0LL);
		    v32 = *(_QWORD *)&forward->x;
		    *(float *)&forward = forward->z;
		    *(_QWORD *)&v39.x = v32;
		    LODWORD(v39.z) = (_DWORD)forward;
		    v39 = *UnityEngine::Quaternion::LookRotation(&v40, (Vector3 *)&v39, 0LL);
		    *(_QWORD *)&v39.x = *(_QWORD *)sub_182F3F6C0(&v40, &v39);
		    if ( v39.x > 180.0 )
		      v10 = 360.0;
		    this = (HGCharacterVolume *)v7->fields.charCameraFollowMainLightBias;
		    v33 = v39.x - v10;
		    if ( !this )
		      goto LABEL_23;
		    v34 = sub_180041350(10LL);
		    v35 = (__m128)LODWORD(v39.y);
		    this = (HGCharacterVolume *)v7->fields.charCameraFollowMainLightBias;
		    v35.m128_f32[0] = v39.y + *((float *)&v34 + 1);
		    y_low = v35;
		    if ( !this )
		      goto LABEL_23;
		    LODWORD(v44) = sub_180041350(10LL);
		    v36 = (__m128)LODWORD(v44);
		    v36.m128_f32[0] = fmaxf(v44, v33);
		    x_low = v36;
		  }
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGCharacterVolume *)v6->static_fields->wrapperArray;
		  if ( !this )
		    goto LABEL_23;
		  if ( *(int *)&this->fields._.active > 909 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		      goto LABEL_23;
		    if ( LODWORD(v6->_0.namespaze) > 0x38D )
		    {
		      if ( !v6[19]._0.nestedTypes )
		        goto LABEL_15;
		      v37 = IFix::WrappersManagerImpl::GetPatch(909, 0LL);
		      if ( v37 )
		      {
		        v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_363(
		                (Vector3 *)&v40,
		                v37,
		                (Object *)v7,
		                (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                0LL);
		        v23 = *(_QWORD *)&v38->x;
		        z = v38->z;
		        goto LABEL_16;
		      }
		LABEL_23:
		      sub_1800D8260(v6, this);
		    }
		LABEL_48:
		    sub_1800D2AB0(v6, this);
		  }
		LABEL_15:
		  v42 = sub_1858CACF0(_mm_unpacklo_ps(x_low, y_low).m128_u64[0], (Vector2)this, v14, v15);
		  Beyond::DampingMath::sinf(v16, 0.017453292);
		  v17 = (__m128)LODWORD(v42.y);
		  Beyond::DampingMath::cosf(v18, 0.017453292);
		  v17.m128_f32[0] = v42.y * v42.x;
		  Beyond::DampingMath::sinf(v19, 0.017453292);
		  Beyond::DampingMath::cosf(v20, 0.017453292);
		  v21 = (__m128)LODWORD(v42.y);
		  Beyond::DampingMath::cosf(v22, 0.017453292);
		  v21.m128_f32[0] = v42.y * v42.x;
		  v23 = _mm_unpacklo_ps(
		          _mm_xor_ps(v17, (__m128)0x80000000),
		          _mm_xor_ps(_mm_xor_ps((__m128)LODWORD(v42.x), (__m128)0x80000000), (__m128)0x80000000)).m128_u64[0];
		  z = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)_mm_xor_ps(v21, (__m128)0x80000000)));
		LABEL_16:
		  *(_QWORD *)&retstr->x = v23;
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(0)]
		public Vector3 GetCharLightVector(Vector2 rotation) => default; // 0x0000000183B720E0-0x0000000183B72210
		// Vector3 GetCharLightVector(Vector2)
		Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVector(
		        Vector3 *__return_ptr retstr,
		        HGCharacterVolume *this,
		        Vector2 rotation,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  Vector2 wrapperArray; // rdx
		  Beyond::DampingMath *v9; // rcx
		  Beyond::DampingMath *v10; // rcx
		  Beyond::DampingMath *v11; // rcx
		  Beyond::DampingMath *v12; // rcx
		  Beyond::DampingMath *v13; // rcx
		  Vector3 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v16; // rax
		  __int64 v17; // xmm0_8
		  Vector3 v18; // [rsp+30h] [rbp-58h] BYREF
		  Vector2 v19; // [rsp+90h] [rbp+8h]
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (Vector2)v5->static_fields->wrapperArray;
		  if ( !*(_QWORD *)&wrapperArray )
		    goto LABEL_6;
		  if ( *(int *)(*(_QWORD *)&wrapperArray + 24LL) <= 909 )
		  {
		LABEL_5:
		    v19 = sub_1858CACF0(rotation, wrapperArray, rotation, (int32_t)method);
		    Beyond::DampingMath::sinf(v9, 0.017453292);
		    Beyond::DampingMath::cosf(v10, 0.017453292);
		    retstr->x = -(float)(v19.y * v19.x);
		    Beyond::DampingMath::sinf(v11, 0.017453292);
		    retstr->y = v19.x;
		    Beyond::DampingMath::cosf(v12, 0.017453292);
		    Beyond::DampingMath::cosf(v13, 0.017453292);
		    result = retstr;
		    retstr->z = -(float)(v19.y * v19.x);
		    return result;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x38D )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( !v5[19]._0.nestedTypes )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(909, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, wrapperArray);
		  v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_363(&v18, Patch, (Object *)this, rotation, 0LL);
		  v17 = *(_QWORD *)&v16->x;
		  *(float *)&v16 = v16->z;
		  *(_QWORD *)&retstr->x = v17;
		  LODWORD(retstr->z) = (_DWORD)v16;
		  return retstr;
		}
		
		public Vector3 GetCharAutoRimVector(float directionAngle) => default; // 0x0000000183C01730-0x0000000183C017D0
		// Vector3 GetCharAutoRimVector(Single)
		Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharAutoRimVector(
		        Vector3 *__return_ptr retstr,
		        HGCharacterVolume *this,
		        float directionAngle,
		        MethodInfo *method)
		{
		  float v4; // xmm1_4
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Beyond::DampingMath *v9; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v12; // rax
		  __int64 v13; // xmm0_8
		  Vector3 v14; // [rsp+30h] [rbp-28h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 907 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x38B )
		        sub_1800D2AB0(v6, this);
		      if ( !v6[19]._0.properties )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(907, 0LL);
		      if ( Patch )
		      {
		        v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_362(&v14, Patch, (Object *)this, directionAngle, 0LL);
		        v13 = *(_QWORD *)&v12->x;
		        *(float *)&v12 = v12->z;
		        *(_QWORD *)&retstr->x = v13;
		        LODWORD(retstr->z) = (_DWORD)v12;
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v6, this);
		  }
		LABEL_5:
		  Beyond::DampingMath::sinf((Beyond::DampingMath *)v6, v4);
		  retstr->x = (float)((float)(directionAngle * 3.1415927) + (float)(directionAngle * 3.1415927)) - 3.1415927;
		  Beyond::DampingMath::cosf(v9, v4);
		  retstr->y = (float)((float)(directionAngle * 3.1415927) + (float)(directionAngle * 3.1415927)) - 3.1415927;
		  retstr->z = 0.0;
		  return retstr;
		}
		
		public Vector3 GetCharFaceRimVector(float directionAngle) => default; // 0x0000000183C01680-0x0000000183C01730
		// Vector3 GetCharFaceRimVector(Single)
		Vector3 *HG::Rendering::Runtime::HGCharacterVolume::GetCharFaceRimVector(
		        Vector3 *__return_ptr retstr,
		        HGCharacterVolume *this,
		        float directionAngle,
		        MethodInfo *method)
		{
		  float v4; // xmm1_4
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Beyond::DampingMath *v9; // rcx
		  Vector3 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v12; // rax
		  __int64 v13; // xmm0_8
		  Vector3 v14; // [rsp+30h] [rbp-38h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 910 )
		  {
		LABEL_5:
		    Beyond::DampingMath::sinf((Beyond::DampingMath *)v6, v4);
		    retstr->x = -(float)(directionAngle * 3.1415927);
		    retstr->y = 0.001;
		    Beyond::DampingMath::cosf(v9, v4);
		    result = retstr;
		    retstr->z = -(float)(directionAngle * 3.1415927);
		    return result;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x38E )
		    sub_1800D2AB0(v6, this);
		  if ( !v6[19]._0.implementedInterfaces )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(910, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, this);
		  v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_362(&v14, Patch, (Object *)this, directionAngle, 0LL);
		  v13 = *(_QWORD *)&v12->x;
		  *(float *)&v12 = v12->z;
		  *(_QWORD *)&retstr->x = v13;
		  LODWORD(retstr->z) = (_DWORD)v12;
		  return retstr;
		}
		
		public bool GetRainEffectPreviewEnabled() => default; // 0x0000000183D24230-0x0000000183D24360
		// Boolean GetRainEffectPreviewEnabled()
		bool HG::Rendering::Runtime::HGCharacterVolume::GetRainEffectPreviewEnabled(
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  BoolParameter *charRainEffectPreviewEnable; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rcx
		  __int64 v12; // rax
		  VolumeParameter__Fields v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_24;
		  if ( wrapperArray->max_length.size <= 912 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_24;
		  if ( LODWORD(v3->_0.namespaze) <= 0x390 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[19].static_fields )
		  {
		LABEL_5:
		    charRainEffectPreviewEnable = this->fields.charRainEffectPreviewEnable;
		    if ( charRainEffectPreviewEnable )
		    {
		      sub_1800049A0(charRainEffectPreviewEnable->klass);
		      v6 = (bool (*)(RuntimeType *, MethodInfo *))charRainEffectPreviewEnable->klass->vtable.get_value.method;
		      methodPtr = charRainEffectPreviewEnable->klass->vtable.set_value.methodPtr;
		      if ( v6 == System::RuntimeType::HasElementTypeImpl )
		      {
		        v9 = charRainEffectPreviewEnable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v9 + 8LL) & 0x20000000) == 0 )
		        {
		          v10 = *(_BYTE *)(*(_QWORD *)&v9 + 10LL);
		          if ( v10 != 29 && v10 != 16 && v10 != 20 && v10 != 15 )
		            return 0;
		        }
		      }
		      else
		      {
		        if ( v6 != System::RuntimeType::get_IsGenericType )
		        {
		          if ( v6 != System::RuntimeType::get_IsGenericParameter )
		            return ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(
		                     charRainEffectPreviewEnable,
		                     methodPtr);
		          v13 = charRainEffectPreviewEnable->fields._._;
		          return (*(_DWORD *)(*(_QWORD *)&v13 + 8LL) & 0x20000000) == 0
		              && (*(_BYTE *)(*(_QWORD *)&v13 + 10LL) == 19 || *(_BYTE *)(*(_QWORD *)&v13 + 10LL) == 30);
		        }
		        v11 = charRainEffectPreviewEnable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v11 + 8LL) & 0x20000000) != 0 )
		          return 0;
		        LOBYTE(methodPtr) = 1;
		        v12 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_180028750)(v11, methodPtr);
		        if ( (*(_BYTE *)(v12 + 312) & 0x10) == 0 && !*(_QWORD *)(v12 + 96) )
		          return 0;
		      }
		      return 1;
		    }
		LABEL_24:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(912, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public float GetPackedEnvironmentEffectIntensity() => default; // 0x0000000183523AD0-0x0000000183523C10
		// Single GetPackedEnvironmentEffectIntensity()
		float HG::Rendering::Runtime::HGCharacterVolume::GetPackedEnvironmentEffectIntensity(
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ClampedFloatParameter *wrapperArray; // rdx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int v7; // edi
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int v10; // esi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // ebp
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  int v16; // ebx
		  float result; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (ClampedFloatParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( SLODWORD(wrapperArray->fields._._.m_Value) <= 913 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_10:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x391 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[19].rgctx_data )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(913, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		    goto LABEL_10;
		  }
		LABEL_5:
		  wrapperArray = this->fields.charRainEffectPreviewIntensity;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  sub_1800057D0(10LL, wrapperArray);
		  wrapperArray = this->fields.charSnowEffectPreviewIntensity;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  sub_1800057D0(10LL, wrapperArray);
		  v7 = sub_182F3EA70(v6, v5);
		  v10 = sub_182F3EA70(v9, v8);
		  v13 = sub_182F3EA70(v12, v11);
		  v16 = sub_182F3EA70(v15, v14);
		  if ( !TypeInfo::System::BitConverter->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::BitConverter);
		  LODWORD(result) = v7 | ((v10 | ((v13 | (v16 << 8)) << 8)) << 8);
		  return result;
		}
		
		private UnityEngine.Color AutoTintColor(UnityEngine.Color color) => default; // 0x0000000183281910-0x0000000183281A30
		// Color AutoTintColor(Color)
		Color *HG::Rendering::Runtime::HGCharacterVolume::AutoTintColor(
		        Color *__return_ptr retstr,
		        HGCharacterVolume *this,
		        Color *color,
		        MethodInfo *method)
		{
		  Color v7; // xmm0
		  Color v8; // xmm1
		  float v9; // xmm4_4
		  Color v10; // xmm3
		  Color v11; // xmm2
		  float v12; // xmm0_4
		  Color *v13; // rax
		  Color v14; // xmm0
		  Color *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  float H; // [rsp+40h] [rbp-48h] BYREF
		  float V[3]; // [rsp+44h] [rbp-44h] BYREF
		  Color v21; // [rsp+50h] [rbp-38h] BYREF
		  Color v22; // [rsp+60h] [rbp-28h] BYREF
		  float S; // [rsp+90h] [rbp+8h] BYREF
		
		  H = 0.0;
		  S = 0.0;
		  V[0] = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(905, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(905, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v18, v17);
		    v21 = *color;
		    v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_360(&v22, Patch, (Object *)this, &v21, 0LL);
		  }
		  else
		  {
		    v7 = *color;
		    v8.r = _mm_shuffle_ps((__m128)v7, (__m128)v7, 170).m128_f32[0];
		    v9 = _mm_shuffle_ps(*(__m128 *)color, *(__m128 *)color, 85).m128_f32[0];
		    if ( v8.r <= v9 || v8.r <= v7.r )
		    {
		      if ( v9 > v7.r )
		      {
		        v10 = *color;
		        v11.r = v8.r;
		        v8.r = v9;
		        v12 = 2.0;
		      }
		      else
		      {
		        v10.r = v8.r;
		        v11.r = v9;
		        v8 = *color;
		        v12 = 0.0;
		      }
		    }
		    else
		    {
		      v11 = *color;
		      v10.r = v9;
		      v12 = 4.0;
		    }
		    UnityEngine::Color::RGBToHSVHelper(v12, v8.r, v11.r, v10.r, &H, &S, V, 0LL);
		    v13 = UnityEngine::Color::HSVToRGB(&v21, H, S, 2.0 / (float)(2.0 - S), 1, 0LL);
		  }
		  v14 = *v13;
		  result = retstr;
		  *retstr = v14;
		  return result;
		}
		
		public UnityEngine.Color GetShadowTintColor() => default; // 0x0000000183281770-0x0000000183281840
		// Color GetShadowTintColor()
		Color *HG::Rendering::Runtime::HGCharacterVolume::GetShadowTintColor(
		        Color *__return_ptr retstr,
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  HGCharacterVolume *v4; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Color *one; // rax
		  Color v8; // xmm0
		  Color *result; // rax
		  ColorParameter *charShadowTintColor; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  v4 = this;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 904 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_11;
		    if ( LODWORD(v5->_0.namespaze) <= 0x388 )
		      sub_1800D2AB0(v5, this);
		    if ( v5[19]._0.klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(904, 0LL);
		      if ( Patch )
		      {
		        one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_361(&v12, Patch, (Object *)v4, 0LL);
		        goto LABEL_8;
		      }
		      goto LABEL_11;
		    }
		  }
		  this = (HGCharacterVolume *)v4->fields.charShadowTintControl;
		  if ( !this )
		    goto LABEL_11;
		  if ( (unsigned int)sub_180002F70(10LL, this) == 1 )
		  {
		    charShadowTintColor = v4->fields.charShadowTintColor;
		    if ( charShadowTintColor )
		    {
		      v12 = *(Color *)sub_180032E40(&v12, 10LL, charShadowTintColor);
		      one = HG::Rendering::Runtime::HGCharacterVolume::AutoTintColor(&v13, v4, &v12, 0LL);
		      goto LABEL_8;
		    }
		LABEL_11:
		    sub_1800D8260(v5, this);
		  }
		  one = (Color *)UnityEngine::Vector4::get_one((Vector4 *)&v13, (MethodInfo *)this);
		LABEL_8:
		  v8 = *one;
		  result = retstr;
		  *retstr = v8;
		  return result;
		}
		
		public UnityEngine.Color GetSkinShadowTintColor() => default; // 0x0000000183281840-0x0000000183281910
		// Color GetSkinShadowTintColor()
		Color *HG::Rendering::Runtime::HGCharacterVolume::GetSkinShadowTintColor(
		        Color *__return_ptr retstr,
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  HGCharacterVolume *v4; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Color *one; // rax
		  Color v8; // xmm0
		  Color *result; // rax
		  ColorParameter *charSkinShadowTintColor; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  v4 = this;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 906 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_11;
		    if ( LODWORD(v5->_0.namespaze) <= 0x38A )
		      sub_1800D2AB0(v5, this);
		    if ( v5[19]._0.events )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(906, 0LL);
		      if ( Patch )
		      {
		        one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_361(&v12, Patch, (Object *)v4, 0LL);
		        goto LABEL_8;
		      }
		      goto LABEL_11;
		    }
		  }
		  this = (HGCharacterVolume *)v4->fields.charShadowTintControl;
		  if ( !this )
		    goto LABEL_11;
		  if ( (unsigned int)sub_180002F70(10LL, this) == 1 )
		  {
		    charSkinShadowTintColor = v4->fields.charSkinShadowTintColor;
		    if ( charSkinShadowTintColor )
		    {
		      v12 = *(Color *)sub_180032E40(&v12, 10LL, charSkinShadowTintColor);
		      one = HG::Rendering::Runtime::HGCharacterVolume::AutoTintColor(&v13, v4, &v12, 0LL);
		      goto LABEL_8;
		    }
		LABEL_11:
		    sub_1800D8260(v5, this);
		  }
		  one = (Color *)UnityEngine::Vector4::get_one((Vector4 *)&v13, (MethodInfo *)this);
		LABEL_8:
		  v8 = *one;
		  result = retstr;
		  *retstr = v8;
		  return result;
		}
		
		public CharacterShadowMode GetCharacterSelfShadowMode() => default; // 0x0000000183E45860-0x0000000183E458D0
		// HGCharacterVolume+CharacterShadowMode GetCharacterSelfShadowMode()
		HGCharacterVolume_CharacterShadowMode__Enum HG::Rendering::Runtime::HGCharacterVolume::GetCharacterSelfShadowMode(
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  HGCharacterVolume_CharacterModeParameter *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (HGCharacterVolume_CharacterModeParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->fields._.m_Value <= 2111 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x83F )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[45]._0.image )
		  {
		LABEL_5:
		    wrapperArray = this->fields.charShadowMode;
		    if ( wrapperArray )
		      return (unsigned int)sub_180002F70(10LL, wrapperArray);
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2111, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public static void SetValueAndState(VolumeParameter srcParameter, VolumeParameter tarParam) {} // 0x0000000189B69A08-0x0000000189B69A78
		// Void SetValueAndState(VolumeParameter, VolumeParameter)
		void HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        VolumeParameter *srcParameter,
		        VolumeParameter *tarParam,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2434, 0LL) )
		  {
		    if ( tarParam && srcParameter )
		    {
		      srcParameter->fields.overrideState = tarParam->fields.overrideState;
		      sub_180045970(v6, srcParameter, tarParam);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2434, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)srcParameter,
		    (Object *)tarParam,
		    0LL);
		}
		
		public CharLightVolumeData GetCharLightVolumeData() => default; // 0x0000000189B693A0-0x0000000189B696CC
		// CharLightVolumeData GetCharLightVolumeData()
		CharLightVolumeData *HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVolumeData(
		        HGCharacterVolume *this,
		        MethodInfo *method)
		{
		  CharLightVolumeData *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  CharLightVolumeData *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Int32__Array **charMainLightMultiplier; // r9
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **charEnvLightMultiplier; // r9
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **charEnvShadowMultiplier; // r9
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **charMainLightSpecularMultiplier; // r9
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **charEyeBaseLightMultiplier; // r9
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **charEyeHighlightMultiplier; // r9
		  Type *v26; // rdx
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **charEyeScatteringMultiplier; // r9
		  Type *v29; // rdx
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **charMainLightRangeBias; // r9
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **charIgnoreMainLightShadow; // r9
		  Type *v35; // rdx
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **charMainLightMode; // r9
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **charCameraFollowMainLightBias; // r9
		  Type *v41; // rdx
		  PropertyInfo_1 *v42; // r8
		  Int32__Array **charCustomMainLightDir; // r9
		  Type *v44; // rdx
		  PropertyInfo_1 *v45; // r8
		  Int32__Array **charMainLightOverrideColor; // r9
		  Type *v47; // rdx
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **charSkinMainLightOverrideColor; // r9
		  Type *v50; // rdx
		  PropertyInfo_1 *v51; // r8
		  Int32__Array **charLightDialogMode; // r9
		  Type *v53; // rdx
		  PropertyInfo_1 *v54; // r8
		  Int32__Array **charShadowTintControl; // r9
		  Type *v56; // rdx
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **charShadowTintColor; // r9
		  Type *v59; // rdx
		  PropertyInfo_1 *v60; // r8
		  Int32__Array **charSkinShadowTintColor; // r9
		  Type *v62; // rdx
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **charAutoRimEnable; // r9
		  Type *v65; // rdx
		  PropertyInfo_1 *v66; // r8
		  Int32__Array **charAutoRimColor; // r9
		  Type *v68; // rdx
		  PropertyInfo_1 *v69; // r8
		  Int32__Array **charAutoRimDir; // r9
		  Type *v71; // rdx
		  PropertyInfo_1 *v72; // r8
		  Int32__Array **charAutoRimIntensity; // r9
		  Type *v74; // rdx
		  PropertyInfo_1 *v75; // r8
		  Int32__Array **charAutoRimWidth; // r9
		  Type *v77; // rdx
		  PropertyInfo_1 *v78; // r8
		  Int32__Array **charFaceRimEnable; // r9
		  Type *v80; // rdx
		  PropertyInfo_1 *v81; // r8
		  Int32__Array **charFaceRimColor; // r9
		  Type *v83; // rdx
		  PropertyInfo_1 *v84; // r8
		  Int32__Array **charFaceRimDir; // r9
		  Type *v86; // rdx
		  PropertyInfo_1 *v87; // r8
		  Int32__Array **charFaceRimIntensity; // r9
		  Type *v89; // rdx
		  PropertyInfo_1 *v90; // r8
		  Int32__Array **charIgnoreSceneAdditionalLights; // r9
		  Type *v92; // rdx
		  PropertyInfo_1 *v93; // r8
		  Int32__Array **charIgnoreSceneEnv; // r9
		  Type *v95; // rdx
		  PropertyInfo_1 *v96; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v99; // [rsp+20h] [rbp-8h]
		  MethodInfo *v100; // [rsp+20h] [rbp-8h]
		  MethodInfo *v101; // [rsp+20h] [rbp-8h]
		  MethodInfo *v102; // [rsp+20h] [rbp-8h]
		  MethodInfo *v103; // [rsp+20h] [rbp-8h]
		  MethodInfo *v104; // [rsp+20h] [rbp-8h]
		  MethodInfo *v105; // [rsp+20h] [rbp-8h]
		  MethodInfo *v106; // [rsp+20h] [rbp-8h]
		  MethodInfo *v107; // [rsp+20h] [rbp-8h]
		  MethodInfo *v108; // [rsp+20h] [rbp-8h]
		  MethodInfo *v109; // [rsp+20h] [rbp-8h]
		  MethodInfo *v110; // [rsp+20h] [rbp-8h]
		  MethodInfo *v111; // [rsp+20h] [rbp-8h]
		  MethodInfo *v112; // [rsp+20h] [rbp-8h]
		  MethodInfo *v113; // [rsp+20h] [rbp-8h]
		  MethodInfo *v114; // [rsp+20h] [rbp-8h]
		  MethodInfo *v115; // [rsp+20h] [rbp-8h]
		  MethodInfo *v116; // [rsp+20h] [rbp-8h]
		  MethodInfo *v117; // [rsp+20h] [rbp-8h]
		  MethodInfo *v118; // [rsp+20h] [rbp-8h]
		  MethodInfo *v119; // [rsp+20h] [rbp-8h]
		  MethodInfo *v120; // [rsp+20h] [rbp-8h]
		  MethodInfo *v121; // [rsp+20h] [rbp-8h]
		  MethodInfo *v122; // [rsp+20h] [rbp-8h]
		  MethodInfo *v123; // [rsp+20h] [rbp-8h]
		  MethodInfo *v124; // [rsp+20h] [rbp-8h]
		  MethodInfo *v125; // [rsp+20h] [rbp-8h]
		  MethodInfo *v126; // [rsp+20h] [rbp-8h]
		  MethodInfo *v127; // [rsp+20h] [rbp-8h]
		  MethodInfo *v128; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2680, 0LL) )
		  {
		    v3 = (CharLightVolumeData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CharLightVolumeData);
		    v6 = v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::CharLightVolumeData::CharLightVolumeData(v3, 0LL);
		      v6->fields.charMainLightControl = this->fields.charMainLightControl;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields, v7, v8, v9, v99);
		      charMainLightMultiplier = (Int32__Array **)this->fields.charMainLightMultiplier;
		      v6->fields.charMainLightMultiplier = (ClampedFloatParameter *)charMainLightMultiplier;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charMainLightMultiplier, v11, v12, charMainLightMultiplier, v100);
		      charEnvLightMultiplier = (Int32__Array **)this->fields.charEnvLightMultiplier;
		      v6->fields.charEnvLightMultiplier = (ClampedFloatParameter *)charEnvLightMultiplier;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charEnvLightMultiplier, v14, v15, charEnvLightMultiplier, v101);
		      charEnvShadowMultiplier = (Int32__Array **)this->fields.charEnvShadowMultiplier;
		      v6->fields.charEnvShadowMultiplier = (ClampedFloatParameter *)charEnvShadowMultiplier;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charEnvShadowMultiplier, v17, v18, charEnvShadowMultiplier, v102);
		      charMainLightSpecularMultiplier = (Int32__Array **)this->fields.charMainLightSpecularMultiplier;
		      v6->fields.charMainLightSpecularMultiplier = (ClampedFloatParameter *)charMainLightSpecularMultiplier;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charMainLightSpecularMultiplier,
		        v20,
		        v21,
		        charMainLightSpecularMultiplier,
		        v103);
		      charEyeBaseLightMultiplier = (Int32__Array **)this->fields.charEyeBaseLightMultiplier;
		      v6->fields.charEyeBaseLightMultiplier = (ClampedFloatParameter *)charEyeBaseLightMultiplier;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charEyeBaseLightMultiplier,
		        v23,
		        v24,
		        charEyeBaseLightMultiplier,
		        v104);
		      charEyeHighlightMultiplier = (Int32__Array **)this->fields.charEyeHighlightMultiplier;
		      v6->fields.charEyeHighlightMultiplier = (ClampedFloatParameter *)charEyeHighlightMultiplier;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charEyeHighlightMultiplier,
		        v26,
		        v27,
		        charEyeHighlightMultiplier,
		        v105);
		      charEyeScatteringMultiplier = (Int32__Array **)this->fields.charEyeScatteringMultiplier;
		      v6->fields.charEyeScatteringMultiplier = (ClampedFloatParameter *)charEyeScatteringMultiplier;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charEyeScatteringMultiplier,
		        v29,
		        v30,
		        charEyeScatteringMultiplier,
		        v106);
		      charMainLightRangeBias = (Int32__Array **)this->fields.charMainLightRangeBias;
		      v6->fields.charMainLightRangeBias = (ClampedFloatParameter *)charMainLightRangeBias;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charMainLightRangeBias, v32, v33, charMainLightRangeBias, v107);
		      charIgnoreMainLightShadow = (Int32__Array **)this->fields.charIgnoreMainLightShadow;
		      v6->fields.charIgnoreMainLightShadow = (BoolParameter *)charIgnoreMainLightShadow;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charIgnoreMainLightShadow,
		        v35,
		        v36,
		        charIgnoreMainLightShadow,
		        v108);
		      charMainLightMode = (Int32__Array **)this->fields.charMainLightMode;
		      v6->fields.charMainLightMode = (HGCharacterVolume_CharacterLightModeParameter *)charMainLightMode;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charMainLightMode, v38, v39, charMainLightMode, v109);
		      charCameraFollowMainLightBias = (Int32__Array **)this->fields.charCameraFollowMainLightBias;
		      v6->fields.charCameraFollowMainLightBias = (Vector2Parameter *)charCameraFollowMainLightBias;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charCameraFollowMainLightBias,
		        v41,
		        v42,
		        charCameraFollowMainLightBias,
		        v110);
		      charCustomMainLightDir = (Int32__Array **)this->fields.charCustomMainLightDir;
		      v6->fields.charCustomMainLightDir = (Vector2Parameter *)charCustomMainLightDir;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charCustomMainLightDir, v44, v45, charCustomMainLightDir, v111);
		      charMainLightOverrideColor = (Int32__Array **)this->fields.charMainLightOverrideColor;
		      v6->fields.charMainLightOverrideColor = (ColorParameter *)charMainLightOverrideColor;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charMainLightOverrideColor,
		        v47,
		        v48,
		        charMainLightOverrideColor,
		        v112);
		      charSkinMainLightOverrideColor = (Int32__Array **)this->fields.charSkinMainLightOverrideColor;
		      v6->fields.charSkinMainLightOverrideColor = (ColorParameter *)charSkinMainLightOverrideColor;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charSkinMainLightOverrideColor,
		        v50,
		        v51,
		        charSkinMainLightOverrideColor,
		        v113);
		      charLightDialogMode = (Int32__Array **)this->fields.charLightDialogMode;
		      v6->fields.charLightDialogMode = (BoolParameter *)charLightDialogMode;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charLightDialogMode, v53, v54, charLightDialogMode, v114);
		      charShadowTintControl = (Int32__Array **)this->fields.charShadowTintControl;
		      v6->fields.charShadowTintControl = (HGCharacterVolume_CharacterShadowTintModeParameter *)charShadowTintControl;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charShadowTintControl, v56, v57, charShadowTintControl, v115);
		      charShadowTintColor = (Int32__Array **)this->fields.charShadowTintColor;
		      v6->fields.charShadowTintColor = (ColorParameter *)charShadowTintColor;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charShadowTintColor, v59, v60, charShadowTintColor, v116);
		      charSkinShadowTintColor = (Int32__Array **)this->fields.charSkinShadowTintColor;
		      v6->fields.charSkinShadowTintColor = (ColorParameter *)charSkinShadowTintColor;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charSkinShadowTintColor, v62, v63, charSkinShadowTintColor, v117);
		      charAutoRimEnable = (Int32__Array **)this->fields.charAutoRimEnable;
		      v6->fields.charAutoRimEnable = (BoolParameter *)charAutoRimEnable;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charAutoRimEnable, v65, v66, charAutoRimEnable, v118);
		      charAutoRimColor = (Int32__Array **)this->fields.charAutoRimColor;
		      v6->fields.charAutoRimColor = (ColorParameter *)charAutoRimColor;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charAutoRimColor, v68, v69, charAutoRimColor, v119);
		      charAutoRimDir = (Int32__Array **)this->fields.charAutoRimDir;
		      v6->fields.charAutoRimDir = (ClampedFloatParameter *)charAutoRimDir;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charAutoRimDir, v71, v72, charAutoRimDir, v120);
		      charAutoRimIntensity = (Int32__Array **)this->fields.charAutoRimIntensity;
		      v6->fields.charAutoRimIntensity = (ClampedFloatParameter *)charAutoRimIntensity;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charAutoRimIntensity, v74, v75, charAutoRimIntensity, v121);
		      charAutoRimWidth = (Int32__Array **)this->fields.charAutoRimWidth;
		      v6->fields.charAutoRimWidth = (ClampedFloatParameter *)charAutoRimWidth;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charAutoRimWidth, v77, v78, charAutoRimWidth, v122);
		      charFaceRimEnable = (Int32__Array **)this->fields.charFaceRimEnable;
		      v6->fields.charFaceRimEnable = (BoolParameter *)charFaceRimEnable;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charFaceRimEnable, v80, v81, charFaceRimEnable, v123);
		      charFaceRimColor = (Int32__Array **)this->fields.charFaceRimColor;
		      v6->fields.charFaceRimColor = (ColorParameter *)charFaceRimColor;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charFaceRimColor, v83, v84, charFaceRimColor, v124);
		      charFaceRimDir = (Int32__Array **)this->fields.charFaceRimDir;
		      v6->fields.charFaceRimDir = (ClampedFloatParameter *)charFaceRimDir;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charFaceRimDir, v86, v87, charFaceRimDir, v125);
		      charFaceRimIntensity = (Int32__Array **)this->fields.charFaceRimIntensity;
		      v6->fields.charFaceRimIntensity = (ClampedFloatParameter *)charFaceRimIntensity;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charFaceRimIntensity, v89, v90, charFaceRimIntensity, v126);
		      charIgnoreSceneAdditionalLights = (Int32__Array **)this->fields.charIgnoreSceneAdditionalLights;
		      v6->fields.charIgnoreSceneAdditionalLights = (BoolParameter *)charIgnoreSceneAdditionalLights;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v6->fields.charIgnoreSceneAdditionalLights,
		        v92,
		        v93,
		        charIgnoreSceneAdditionalLights,
		        v127);
		      charIgnoreSceneEnv = (Int32__Array **)this->fields.charIgnoreSceneEnv;
		      v6->fields.charIgnoreSceneEnv = (BoolParameter *)charIgnoreSceneEnv;
		      sub_18002D1B0((SingleFieldAccessor *)&v6->fields.charIgnoreSceneEnv, v95, v96, charIgnoreSceneEnv, v128);
		      return v6;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2680, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_986(Patch, (Object *)this, 0LL);
		}
		
		public bool SetCharLightVolumeData(CharLightVolumeData charLightVolumeData) => default; // 0x0000000189B696CC-0x0000000189B69994
		// Boolean SetCharLightVolumeData(CharLightVolumeData)
		bool HG::Rendering::Runtime::HGCharacterVolume::SetCharLightVolumeData(
		        HGCharacterVolume *this,
		        CharLightVolumeData *charLightVolumeData,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2433, 0LL) )
		  {
		    if ( charLightVolumeData )
		    {
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charMainLightControl,
		        (VolumeParameter *)charLightVolumeData->fields.charMainLightControl,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charMainLightMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charMainLightMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charEnvLightMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charEnvLightMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charEnvShadowMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charEnvShadowMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charMainLightSpecularMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charMainLightSpecularMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charEyeBaseLightMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charEyeBaseLightMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charEyeHighlightMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charEyeHighlightMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charEyeScatteringMultiplier,
		        (VolumeParameter *)charLightVolumeData->fields.charEyeScatteringMultiplier,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charMainLightRangeBias,
		        (VolumeParameter *)charLightVolumeData->fields.charMainLightRangeBias,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charIgnoreMainLightShadow,
		        (VolumeParameter *)charLightVolumeData->fields.charIgnoreMainLightShadow,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charMainLightMode,
		        (VolumeParameter *)charLightVolumeData->fields.charMainLightMode,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charCameraFollowMainLightBias,
		        (VolumeParameter *)charLightVolumeData->fields.charCameraFollowMainLightBias,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charCustomMainLightDir,
		        (VolumeParameter *)charLightVolumeData->fields.charCustomMainLightDir,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charMainLightOverrideColor,
		        (VolumeParameter *)charLightVolumeData->fields.charMainLightOverrideColor,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charSkinMainLightOverrideColor,
		        (VolumeParameter *)charLightVolumeData->fields.charSkinMainLightOverrideColor,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charLightDialogMode,
		        (VolumeParameter *)charLightVolumeData->fields.charLightDialogMode,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charShadowTintControl,
		        (VolumeParameter *)charLightVolumeData->fields.charShadowTintControl,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charShadowTintColor,
		        (VolumeParameter *)charLightVolumeData->fields.charShadowTintColor,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charSkinShadowTintColor,
		        (VolumeParameter *)charLightVolumeData->fields.charSkinShadowTintColor,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charAutoRimEnable,
		        (VolumeParameter *)charLightVolumeData->fields.charAutoRimEnable,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charAutoRimColor,
		        (VolumeParameter *)charLightVolumeData->fields.charAutoRimColor,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charAutoRimDir,
		        (VolumeParameter *)charLightVolumeData->fields.charAutoRimDir,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charAutoRimIntensity,
		        (VolumeParameter *)charLightVolumeData->fields.charAutoRimIntensity,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charAutoRimWidth,
		        (VolumeParameter *)charLightVolumeData->fields.charAutoRimWidth,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charFaceRimEnable,
		        (VolumeParameter *)charLightVolumeData->fields.charFaceRimEnable,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charFaceRimIntensity,
		        (VolumeParameter *)charLightVolumeData->fields.charFaceRimIntensity,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charFaceRimColor,
		        (VolumeParameter *)charLightVolumeData->fields.charFaceRimColor,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charFaceRimDir,
		        (VolumeParameter *)charLightVolumeData->fields.charFaceRimDir,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charIgnoreSceneAdditionalLights,
		        (VolumeParameter *)charLightVolumeData->fields.charIgnoreSceneAdditionalLights,
		        0LL);
		      HG::Rendering::Runtime::HGCharacterVolume::SetValueAndState(
		        (VolumeParameter *)this->fields.charIgnoreSceneEnv,
		        (VolumeParameter *)charLightVolumeData->fields.charIgnoreSceneEnv,
		        0LL);
		      return 1;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2433, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)charLightVolumeData,
		           0LL);
		}
		
	}
}
