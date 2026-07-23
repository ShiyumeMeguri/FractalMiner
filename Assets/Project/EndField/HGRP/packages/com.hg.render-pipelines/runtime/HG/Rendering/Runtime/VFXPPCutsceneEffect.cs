using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("VFXPPCutsceneEffect")]
	[ExecuteInEditMode]
	public class VFXPPCutsceneEffect : VFXPPComponent // TypeDefIndex: 37954
	{
		// Fields
		[Range(-2f, 2f)]
		public float totalXOffset; // 0x48
		[Range(-2f, 2f)]
		public float totalYOffset; // 0x4C
		[Range(0f, 1f)]
		[Space(10f)]
		public float lightIntensity; // 0x50
		[Range(0f, 1f)]
		public float darkIntensity; // 0x54
		public bool enableCompatibilityMode; // 0x58
		public List<CutsceneEffectCfg> effectList; // 0x60
		private Renderer m_renderer; // 0x68
		private const string SHADER_CUTSCENE_EFFECT = "HGRP/CutsceneEffect"; // Metadata: 0x02303758
		public static bool m_useCutsceneEffsectShader; // 0x00
		public static bool m_enableCompatibilityMode; // 0x01
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x08
		public static int effectListCount; // 0x10
		[HideInInspector]
		[SerializeField]
		private Material m_baseMaterial; // 0x70
		public static Material[] runtimeMaterial; // 0x18
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184B2D370-0x0000000184B2D3A0 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPCutsceneEffect::get_m_VFXPPType(
		        VFXPPCutsceneEffect *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2482, 0LL) )
		    return 9;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2482, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public static bool cutsceneEffectMaterialValid { get => default; } // 0x0000000189B60F98-0x0000000189B60FF4 
		// Boolean get_cutsceneEffectMaterialValid()
		bool HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectMaterialValid(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2483, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2483, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    return TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_useCutsceneEffsectShader;
		  }
		}
		
		public static MaterialPropertyBlock cutsceneEffectPropertyBlock { get => default; } // 0x0000000184892AB0-0x0000000184892BB0 
		// MaterialPropertyBlock get_cutsceneEffectPropertyBlock()
		MaterialPropertyBlock *HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectPropertyBlock(MethodInfo *method)
		{
		  struct VFXPPCutsceneEffect__Class *v1; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rbx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  struct VFXPPCutsceneEffect__Class *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2487, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2487, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_429(Patch, 0LL);
		    goto LABEL_12;
		  }
		  v1 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v1 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  if ( v1->static_fields->s_materialPropertyBlock )
		    goto LABEL_5;
		  v5 = sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v5 )
		LABEL_12:
		    sub_1800D8260(v4, v3);
		  *(_QWORD *)(v5 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  v9 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v9 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  v9->static_fields->s_materialPropertyBlock = (MaterialPropertyBlock *)v5;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->s_materialPropertyBlock,
		    v6,
		    v7,
		    v8,
		    v11);
		  v1 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		LABEL_5:
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  return v1->static_fields->s_materialPropertyBlock;
		}
		
	
		// Nested types
		private static class ShaderConstants // TypeDefIndex: 37949
		{
			// Fields
			public static readonly int _BaseColor; // 0x00
			public static readonly int _ShapeOption; // 0x04
			public static readonly int _EnableAutoStretch; // 0x08
			public static readonly int _LightRange1; // 0x0C
			public static readonly int _LightRange2; // 0x10
			public static readonly int _LeftFadeRange; // 0x14
			public static readonly int _RightFadeRange; // 0x18
			public static readonly int _XOffset; // 0x1C
			public static readonly int _YOffset; // 0x20
			public static readonly int _Ration; // 0x24
			public static readonly int _Scale; // 0x28
			public static readonly int _LightIntensity; // 0x2C
			public static readonly int _DarkIntensity; // 0x30
			public static readonly int _TotalXOffset; // 0x34
			public static readonly int _TotalYOffset; // 0x38
			public static readonly int _SrcBlend; // 0x3C
			public static readonly int _DstBlend; // 0x40
			public static readonly int _EnableDepthFade; // 0x44
			public static readonly int _DepthFadePosition; // 0x48
			public static readonly int _NearFadeIntensity; // 0x4C
			public static readonly int _UseInvertFade; // 0x50
			public static readonly int _DepthFadeRange; // 0x54
			public static readonly int _ColorOption; // 0x58
	
			// Constructors
			static ShaderConstants() {} // 0x00000001849513F0-0x00000001849516D0
			// VFXPPCutsceneEffect+ShaderConstants()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants::cctor(MethodInfo *method)
			{
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_BaseColor = UnityEngine::Shader::PropertyToID((String *)"_BaseColor", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_ShapeOption = UnityEngine::Shader::PropertyToID((String *)"_ShapeOption", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_EnableAutoStretch = UnityEngine::Shader::PropertyToID((String *)"_EnableAutoStretch", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LightRange1 = UnityEngine::Shader::PropertyToID((String *)"_LightRange1", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LightRange2 = UnityEngine::Shader::PropertyToID((String *)"_LightRange2", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LeftFadeRange = UnityEngine::Shader::PropertyToID((String *)"_LeftFadeRange", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_RightFadeRange = UnityEngine::Shader::PropertyToID((String *)"_RightFadeRange", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_XOffset = UnityEngine::Shader::PropertyToID((String *)"_XOffset", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_YOffset = UnityEngine::Shader::PropertyToID((String *)"_YOffset", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_Ration = UnityEngine::Shader::PropertyToID(
			                                                                                                     (String *)"_Ration",
			                                                                                                     0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_Scale = UnityEngine::Shader::PropertyToID(
			                                                                                                    (String *)"_Scale",
			                                                                                                    0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LightIntensity = UnityEngine::Shader::PropertyToID((String *)"_LightIntensity", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DarkIntensity = UnityEngine::Shader::PropertyToID((String *)"_DarkIntensity", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_TotalXOffset = UnityEngine::Shader::PropertyToID((String *)"_TotalXOffset", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_TotalYOffset = UnityEngine::Shader::PropertyToID((String *)"_TotalYOffset", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_SrcBlend = UnityEngine::Shader::PropertyToID((String *)"_SrcBlend", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DstBlend = UnityEngine::Shader::PropertyToID((String *)"_DstBlend", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_EnableDepthFade = UnityEngine::Shader::PropertyToID((String *)"_EnableDepthFade", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DepthFadePosition = UnityEngine::Shader::PropertyToID((String *)"_DepthFadePosition", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_NearFadeIntensity = UnityEngine::Shader::PropertyToID((String *)"_NearFadeIntensity", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_UseInvertFade = UnityEngine::Shader::PropertyToID((String *)"_EnableuseInvertFade", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DepthFadeRange = UnityEngine::Shader::PropertyToID((String *)"_DepthFadeRange", 0LL);
			  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_ColorOption = UnityEngine::Shader::PropertyToID((String *)"_ColorOption", 0LL);
			}
			
		}
	
		[Serializable]
		public struct CutsceneEffectCfg // TypeDefIndex: 37953
		{
			// Fields
			public Options option; // 0x00
			public ShapeOptions shapeOption; // 0x04
			[ColorUsage(true, true)]
			public UnityEngine.Color color; // 0x08
			[Range(0f, 1f)]
			public float para1; // 0x18
			[Range(0f, 1f)]
			public float para2; // 0x1C
			[Range(0f, 0.5f)]
			public float leftFadeRange; // 0x20
			[Range(0f, 0.5f)]
			public float rightFadeRange; // 0x24
			[Range(-1f, 1f)]
			[Space(10f)]
			public float xOffset; // 0x28
			[Range(-1f, 1f)]
			public float yOffset; // 0x2C
			[Range(-90f, 90f)]
			public float rotation; // 0x30
			[Range(0.01f, 3f)]
			public float xScale; // 0x34
			[Range(0.01f, 3f)]
			public float yScale; // 0x38
			public AutoStretchMode autoStretchMode; // 0x3C
			[Space(10f)]
			public bool useDepthFade; // 0x40
			public float depthFadePosition; // 0x44
			[Range(0f, 1f)]
			public float nearFadeIntensity; // 0x48
			public bool useInvertFade; // 0x4C
			[Range(0f, 2f)]
			public float depthFadeRange; // 0x50
	
			// Nested types
			public enum Options // TypeDefIndex: 37950
			{
				Light = 0,
				Dark = 1
			}
	
			public enum ShapeOptions // TypeDefIndex: 37951
			{
				Squad = 0,
				Circle = 1
			}
	
			public enum AutoStretchMode // TypeDefIndex: 37952
			{
				Legacy = 0,
				Off = 1,
				On = 2
			}
	
			// Methods
			private void SetUp() {} // 0x0000000189B5F4C8-0x0000000189B5F53C
			// Void SetUp()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetUp(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2495, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2495, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para2 = 0.0;
			    this->xOffset = 0.0;
			    this->rotation = 0.0;
			    this->para1 = 1.0;
			    this->yOffset = 0.25;
			    this->xScale = 1.1;
			    this->yScale = 0.5;
			  }
			}
			
			private void SetDown() {} // 0x0000000189B5F194-0x0000000189B5F208
			// Void SetDown()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetDown(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2496, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2496, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para1 = 0.0;
			    this->xOffset = 0.0;
			    this->rotation = 0.0;
			    this->para2 = 1.0;
			    this->yOffset = -0.25;
			    this->xScale = 1.1;
			    this->yScale = 0.5;
			  }
			}
			
			private void SetLeft() {} // 0x0000000189B5F2F8-0x0000000189B5F368
			// Void SetLeft()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetLeft(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2497, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2497, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para2 = 0.0;
			    this->yOffset = 0.0;
			    this->para1 = 1.0;
			    this->xScale = 1.0;
			    this->yScale = 1.0;
			    this->xOffset = -0.27000001;
			    this->rotation = 90.0;
			  }
			}
			
			private void SetRight() {} // 0x0000000189B5F458-0x0000000189B5F4C8
			// Void SetRight()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetRight(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2498, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2498, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para1 = 0.0;
			    this->yOffset = 0.0;
			    this->para2 = 1.0;
			    this->xScale = 1.0;
			    this->yScale = 1.0;
			    this->xOffset = 0.27000001;
			    this->rotation = 90.0;
			  }
			}
			
			private void SetLeftUp() {} // 0x0000000189B5F280-0x0000000189B5F2F8
			// Void SetLeftUp()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetLeftUp(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2499, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2499, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para2 = 0.0;
			    this->para1 = 1.0;
			    this->xOffset = -0.44999999;
			    this->yOffset = 0.25999999;
			    this->rotation = 45.0;
			    this->xScale = 1.1;
			    this->yScale = 0.5;
			  }
			}
			
			private void SetLeftDown() {} // 0x0000000189B5F208-0x0000000189B5F280
			// Void SetLeftDown()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetLeftDown(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2500, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2500, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para1 = 0.0;
			    this->para2 = 1.0;
			    this->xOffset = -0.44999999;
			    this->yOffset = -0.25999999;
			    this->rotation = -45.0;
			    this->xScale = 1.1;
			    this->yScale = 0.5;
			  }
			}
			
			private void SetRightUp() {} // 0x0000000189B5F3E0-0x0000000189B5F458
			// Void SetRightUp()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetRightUp(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2501, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2501, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para2 = 0.0;
			    this->para1 = 1.0;
			    this->xOffset = 0.44999999;
			    this->yOffset = 0.25999999;
			    this->rotation = -45.0;
			    this->xScale = 1.1;
			    this->yScale = 0.5;
			  }
			}
			
			private void SetRightDown() {} // 0x0000000189B5F368-0x0000000189B5F3E0
			// Void SetRightDown()
			void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetRightDown(
			        VFXPPCutsceneEffect_CutsceneEffectCfg *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2502, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2502, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(Patch, this, 0LL);
			  }
			  else
			  {
			    this->para1 = 0.0;
			    this->para2 = 1.0;
			    this->xOffset = 0.44999999;
			    this->yOffset = -0.25999999;
			    this->rotation = 45.0;
			    this->xScale = 1.1;
			    this->yScale = 0.5;
			  }
			}
			
		}
	
		// Constructors
		public VFXPPCutsceneEffect() {} // 0x00000001844D8D30-0x00000001844D8DA0
		// VFXPPCutsceneEffect()
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::VFXPPCutsceneEffect(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  this->fields.lightIntensity = 1.0;
		  this->fields.darkIntensity = 1.0;
		  v3 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>);
		  v6 = (List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::List);
		  this->fields.effectList = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.effectList, v7, v8, v9, v10);
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
		static VFXPPCutsceneEffect() {} // 0x0000000184D6EE80-0x0000000184D6EEC0
		// VFXPPCutsceneEffect()
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  VFXPPCutsceneEffect__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 0LL);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		  static_fields->runtimeMaterial = (Material__Array *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->runtimeMaterial,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Methods
		public override void SetData(VFXPPData data) {} // 0x0000000189B60E8C-0x0000000189B60F34
		// Void SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::SetData(
		        VFXPPCutsceneEffect *this,
		        VFXPPData *data,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  __int64 v7; // rcx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 v10; // r10
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2484, 0LL) )
		  {
		    v5 = sub_180005050(data, TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffectData);
		    if ( v5 )
		    {
		      this->fields.effectList = *(List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ **)(v5 + 48);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.effectList, v6, v8, v9, v12);
		      this->fields._.m_priority = *(_DWORD *)(v10 + 16);
		      this->fields.totalXOffset = *(float *)(v10 + 24);
		      this->fields.totalYOffset = *(float *)(v10 + 28);
		      this->fields.lightIntensity = *(float *)(v10 + 32);
		      this->fields.darkIntensity = *(float *)(v10 + 36);
		      this->fields.enableCompatibilityMode = *(_BYTE *)(v10 + 40);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2484, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public override VFXPPData GetData() => default; // 0x0000000189B60B3C-0x0000000189B60BF4
		// VFXPPData GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPCutsceneEffect::GetData(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  VFXPPCutsceneEffectData *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  VFXPPCutsceneEffectData *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2485, 0LL) )
		  {
		    v3 = (VFXPPCutsceneEffectData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffectData);
		    v6 = v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::VFXPPCutsceneEffectData::VFXPPCutsceneEffectData(v3, 0LL);
		      v6->fields.effectList = this->fields.effectList;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v6->fields.effectList, v7, v8, v9, v12);
		      v6->fields._.priority = this->fields._.m_priority;
		      v6->fields.totalXOffset = this->fields.totalXOffset;
		      v6->fields.totalYOffset = this->fields.totalYOffset;
		      v6->fields.lightIntensity = this->fields.lightIntensity;
		      v6->fields.darkIntensity = this->fields.darkIntensity;
		      v6->fields.enableCompatibilityMode = this->fields.enableCompatibilityMode;
		      return (VFXPPData *)v6;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2485, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		private void OnEffectListChanged() {} // 0x0000000189B60C7C-0x0000000189B60E8C
		// Void OnEffectListChanged()
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::OnEffectListChanged(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *effectList; // rax
		  Object *v6; // rax
		  List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v7; // rdi
		  int32_t size; // ebx
		  MethodInfo *v9; // rdx
		  Color *red; // rax
		  Color v11; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m256i v13; // [rsp+20h] [rbp-E0h] BYREF
		  __int128 v14; // [rsp+40h] [rbp-C0h]
		  __int128 v15; // [rsp+50h] [rbp-B0h]
		  __int128 v16; // [rsp+60h] [rbp-A0h]
		  int v17; // [rsp+70h] [rbp-90h]
		  VFXPPCutsceneEffect_CutsceneEffectCfg v18; // [rsp+80h] [rbp-80h] BYREF
		  Object o1; // [rsp+E0h] [rbp-20h] BYREF
		  VFXPPCutsceneEffect_CutsceneEffectCfg v20; // [rsp+F0h] [rbp-10h]
		  Color v21; // [rsp+150h] [rbp+50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2486, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2486, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    effectList = this->fields.effectList;
		    if ( !effectList )
		      goto LABEL_8;
		    if ( effectList->fields._size > 0 )
		    {
		      System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item(
		        &v18,
		        this->fields.effectList,
		        effectList->fields._size - 1,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item);
		      sub_18033B9D0(&v13, 0LL, 84LL);
		      o1 = *(Object *)v13.m256i_i8;
		      *(_OWORD *)&v20.color.b = v14;
		      *(_OWORD *)&v20.option = *(_OWORD *)&v13.m256i_u64[2];
		      *(_OWORD *)&v20.rotation = v16;
		      *(_OWORD *)&v20.leftFadeRange = v15;
		      *(_DWORD *)&v20.useDepthFade = v17;
		      v6 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg, &o1);
		      o1.monitor = (MonitorData *)-1LL;
		      o1.klass = (Object__Class *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg;
		      v20 = v18;
		      if ( System::ValueType::DefaultEquals(&o1, v6, 0LL) )
		      {
		        v7 = this->fields.effectList;
		        if ( v7 )
		        {
		          size = v7->fields._size;
		          sub_18033B9D0(&v13, 0LL, 84LL);
		          red = UnityEngine::Color::get_red(&v21, v9);
		          *(_QWORD *)&v15 = 0x3F8CCCCD00000000LL;
		          v11 = *red;
		          v13.m256i_i64[3] = 1065353216LL;
		          *(Color *)&v13.m256i_u64[1] = v11;
		          *(_OWORD *)&v18.option = *(_OWORD *)v13.m256i_i8;
		          *(_OWORD *)&v18.color.b = *(_OWORD *)&v13.m256i_u64[2];
		          *((_QWORD *)&v15 + 1) = 0x13F000000LL;
		          LOBYTE(v16) = 0;
		          *(_QWORD *)((char *)&v16 + 4) = 0x3E8F5C293F666666LL;
		          BYTE12(v16) = 0;
		          *(_OWORD *)&v18.rotation = v15;
		          *(_OWORD *)&v18.useDepthFade = v16;
		          v18.depthFadeRange = 0.0;
		          *(__m128i *)&v18.leftFadeRange = _mm_load_si128((const __m128i *)&xmmword_18DC81260);
		          sub_1806924F4(
		            v7,
		            (unsigned int)(size - 1),
		            &v18,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::set_Item);
		          return;
		        }
		LABEL_8:
		        sub_1800D8260(v4, v3);
		      }
		    }
		  }
		}
		
		private void Awake() {} // 0x00000001848209B0-0x0000000184820B70
		// Void Awake()
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::Awake(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  struct VFXPPCutsceneEffect__Class *v3; // rax
		  VFXPPCutsceneEffect__StaticFields *static_fields; // rcx
		  List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *effectList; // rdx
		  struct Object_1__Class *v6; // rcx
		  Material *m_baseMaterial; // rdi
		  Component *transform; // rax
		  GameObject *gameObject; // rax
		  struct VFXPPCutsceneEffect__Class *v10; // rax
		  struct VFXPPCutsceneEffect__Class *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2488, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2488, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_21;
		  }
		  v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  v3->static_fields->m_useCutsceneEffsectShader = 0;
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		  static_fields->m_enableCompatibilityMode = 0;
		  effectList = this->fields.effectList;
		  if ( !effectList )
		    goto LABEL_21;
		  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount = effectList->fields._size;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount )
		    goto LABEL_27;
		  v6 = TypeInfo::UnityEngine::Object;
		  m_baseMaterial = this->fields.m_baseMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_baseMaterial )
		    goto LABEL_27;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v6);
		  if ( !m_baseMaterial->fields._.m_CachedPtr || !UnityEngine::Behaviour::get_enabled((Behaviour *)this, 0LL) )
		    goto LABEL_27;
		  transform = (Component *)UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform || (gameObject = UnityEngine::Component::get_gameObject(transform, 0LL)) == 0LL )
		LABEL_21:
		    sub_1800D8260(static_fields, effectList);
		  if ( UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
		  {
		    v10 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v10 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    v10->static_fields->m_useCutsceneEffsectShader = 1;
		    v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( this->fields.enableCompatibilityMode )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		        v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      v11->static_fields->m_enableCompatibilityMode = 1;
		    }
		    else
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		        v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      v11->static_fields->m_enableCompatibilityMode = 0;
		    }
		    return;
		  }
		LABEL_27:
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_useCutsceneEffsectShader = 0;
		}
		
		public override VFXPPData GetDefaultData() => default; // 0x0000000189B60BF4-0x0000000189B60C7C
		// VFXPPData GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPCutsceneEffect::GetDefaultData(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  VFXPPCutsceneEffectData *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  VFXPPCutsceneEffectData *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  VFXPPData *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2489, 0LL) )
		  {
		    v3 = (VFXPPCutsceneEffectData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffectData);
		    v6 = v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::VFXPPCutsceneEffectData::VFXPPCutsceneEffectData(v3, 0LL);
		      v6->fields.effectList = this->fields.effectList;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v6->fields.effectList, v7, v8, v9, v12);
		      result = (VFXPPData *)v6;
		      v6->fields._.priority = this->fields._.m_priority;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2489, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		protected override VFXPPData _GetLerpData(float value) => default; // 0x0000000189B60F3C-0x0000000189B60F98
		// VFXPPData _GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPCutsceneEffect::_GetLerpData(
		        VFXPPCutsceneEffect *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2490, 0LL) )
		    return this->fields._.m_targetData;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2490, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v7, v6);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_947(Patch, (Object *)this, value, 0LL);
		}
		
		public override void Apply(VolumeProfile volumeProfile) {} // 0x00000001835767C0-0x0000000183576FD0
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::Apply(
		        VFXPPCutsceneEffect *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  _DWORD *runtimeMaterial; // rcx
		  Transform *v7; // rbx
		  struct VFXPPCutsceneEffect__Class *v8; // rax
		  HGRuntimeGrassQuery_Node *effectList; // rdx
		  int32_t v10; // edi
		  struct Object_1__Class *v11; // rcx
		  Material *m_baseMaterial; // rbx
		  Int32__Array **v13; // r9
		  struct VFXPPCutsceneEffect__Class *v14; // rax
		  struct VFXPPCutsceneEffect__Class *v15; // rax
		  HGRuntimeGrassQuery_Node *parent; // rax
		  __int64 v17; // r8
		  Component *v18; // rax
		  GameObject *gameObject; // rax
		  struct VFXPPCutsceneEffect__Class *v20; // rax
		  __int64 v21; // rbx
		  __int64 v22; // rbp
		  Material *v23; // rbx
		  List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v24; // rax
		  Material *v25; // rbx
		  unsigned int i; // ebx
		  __int64 v27; // rbp
		  Object_1 *v28; // rbp
		  __int64 v29; // rax
		  VFXPPCutsceneEffect__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  int32_t j; // ebx
		  struct VFXPPCutsceneEffect__Class *v34; // rcx
		  Material *v35; // r15
		  Material__Array *v36; // r14
		  Material *v37; // rax
		  Material *v38; // rbp
		  __int64 v39; // rax
		  VFXPPCutsceneEffect__StaticFields *v40; // rdx
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  int32_t k; // ebp
		  struct VFXPPCutsceneEffect__Class *v44; // rcx
		  Material *v45; // r15
		  Material__Array *v46; // r14
		  Material *v47; // rax
		  Material *v48; // rbx
		  struct VFXPPCutsceneEffect__Class *v49; // rax
		  MaterialPropertyBlock *cutsceneEffectPropertyBlock; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  VFXPPCutsceneEffect_CutsceneEffectCfg cutsceneEffectCfg; // [rsp+20h] [rbp-D8h] BYREF
		  VFXPPCutsceneEffect_CutsceneEffectCfg v53; // [rsp+80h] [rbp-78h] BYREF
		
		  memset(&cutsceneEffectCfg, 0, sizeof(cutsceneEffectCfg));
		  if ( IFix::WrappersManagerImpl::IsPatched(2491, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2491, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_61;
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  runtimeMaterial = TypeInfo::UnityEngine::Object;
		  v7 = transform;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    runtimeMaterial = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      runtimeMaterial = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v7 )
		    return;
		  if ( !runtimeMaterial[56] )
		    il2cpp_runtime_class_init_1(runtimeMaterial);
		  if ( !v7->fields._._.m_CachedPtr )
		    return;
		  v8 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v8 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  v8->static_fields->m_useCutsceneEffsectShader = 0;
		  effectList = (HGRuntimeGrassQuery_Node *)this->fields.effectList;
		  if ( !effectList )
		LABEL_61:
		    sub_1800D8260(runtimeMaterial, effectList);
		  v10 = 0;
		  TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount = LODWORD(effectList->fields.bounds.m_Center.z);
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount )
		    goto LABEL_133;
		  v11 = TypeInfo::UnityEngine::Object;
		  m_baseMaterial = this->fields.m_baseMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v11 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v11 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_baseMaterial )
		    goto LABEL_133;
		  if ( !v11->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v11);
		  if ( m_baseMaterial->fields._.m_CachedPtr && UnityEngine::Behaviour::get_enabled((Behaviour *)this, 0LL) )
		  {
		    v14 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v14 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    v14->static_fields->m_useCutsceneEffsectShader = 1;
		    v15 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( this->fields.enableCompatibilityMode )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		        v15 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      v15->static_fields->m_enableCompatibilityMode = 1;
		    }
		    else
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		        v15 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      v15->static_fields->m_enableCompatibilityMode = 0;
		    }
		    effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    if ( *(_QWORD *)&effectList[2].fields.parent->fields.bounds.m_Center.z )
		    {
		      if ( !LODWORD(effectList[3].monitor) )
		      {
		        il2cpp_runtime_class_init_1(effectList);
		        effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      parent = effectList[2].fields.parent;
		      v17 = *(_QWORD *)&parent->fields.bounds.m_Center.z;
		      if ( !v17 )
		        goto LABEL_61;
		      if ( *(_DWORD *)(v17 + 24) != LODWORD(parent->fields.bounds.m_Center.x) )
		      {
		        for ( i = 0; ; ++i )
		        {
		          if ( !LODWORD(effectList[3].monitor) )
		          {
		            il2cpp_runtime_class_init_1(effectList);
		            effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          }
		          runtimeMaterial = *(_DWORD **)&effectList[2].fields.parent->fields.bounds.m_Center.z;
		          if ( !runtimeMaterial )
		            goto LABEL_61;
		          if ( (signed int)i >= runtimeMaterial[6] )
		            break;
		          if ( !LODWORD(effectList[3].monitor) )
		          {
		            il2cpp_runtime_class_init_1(effectList);
		            effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          }
		          runtimeMaterial = *(_DWORD **)&effectList[2].fields.parent->fields.bounds.m_Center.z;
		          if ( !runtimeMaterial )
		            goto LABEL_61;
		          if ( i >= runtimeMaterial[6] )
		            goto LABEL_103;
		          v27 = *(_QWORD *)&runtimeMaterial[2 * i + 8];
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          }
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          }
		          if ( v27 )
		          {
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		            }
		            if ( *(_QWORD *)(v27 + 16) )
		            {
		              if ( !LODWORD(effectList[3].monitor) )
		              {
		                il2cpp_runtime_class_init_1(effectList);
		                effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		              }
		              runtimeMaterial = *(_DWORD **)&effectList[2].fields.parent->fields.bounds.m_Center.z;
		              if ( !runtimeMaterial )
		                goto LABEL_61;
		              if ( i >= runtimeMaterial[6] )
		LABEL_103:
		                sub_1800D2AB0(runtimeMaterial, effectList);
		              v28 = *(Object_1 **)&runtimeMaterial[2 * i + 8];
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              UnityEngine::Object::DestroyImmediate(v28, 0LL);
		              runtimeMaterial = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->runtimeMaterial;
		              if ( !runtimeMaterial )
		                goto LABEL_61;
		              sub_1800020D0(runtimeMaterial, (int)i, 0LL);
		              effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		            }
		          }
		        }
		        if ( !LODWORD(effectList[3].monitor) )
		        {
		          il2cpp_runtime_class_init_1(effectList);
		          effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		        }
		        *(_QWORD *)&effectList[2].fields.parent->fields.bounds.m_Center.z = 0LL;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->runtimeMaterial,
		          effectList,
		          (HGRuntimeGrassQuery_Node *)v17,
		          v13,
		          *(MethodInfo **)&cutsceneEffectCfg.option);
		        v29 = il2cpp_array_new_specific_1(
		                TypeInfo::UnityEngine::Material,
		                (unsigned int)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		        static_fields->runtimeMaterial = (Material__Array *)v29;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->runtimeMaterial,
		          (HGRuntimeGrassQuery_Node *)static_fields,
		          v31,
		          v32,
		          *(MethodInfo **)&cutsceneEffectCfg.option);
		        for ( j = 0; ; ++j )
		        {
		          v34 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		            v34 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          }
		          if ( j >= v34->static_fields->effectListCount )
		            break;
		          if ( !v34->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v34);
		            v34 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		          }
		          v35 = this->fields.m_baseMaterial;
		          v36 = v34->static_fields->runtimeMaterial;
		          v37 = (Material *)sub_1800368D0(TypeInfo::UnityEngine::Material);
		          v38 = v37;
		          if ( !v37 )
		            goto LABEL_61;
		          UnityEngine::Material::Material(v37, v35, 0LL);
		          if ( !v36 )
		            goto LABEL_61;
		          sub_180031B10(v36, v38);
		          sub_1800020D0(v36, j, v38);
		        }
		      }
		    }
		    else
		    {
		      if ( !LODWORD(effectList[3].monitor) )
		      {
		        il2cpp_runtime_class_init_1(effectList);
		        effectList = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      v39 = il2cpp_array_new_specific_1(
		              TypeInfo::UnityEngine::Material,
		              LODWORD(effectList[2].fields.parent->fields.bounds.m_Center.x));
		      v40 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		      v40->runtimeMaterial = (Material__Array *)v39;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->runtimeMaterial,
		        (HGRuntimeGrassQuery_Node *)v40,
		        v41,
		        v42,
		        *(MethodInfo **)&cutsceneEffectCfg.option);
		      for ( k = 0; ; ++k )
		      {
		        v44 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		        if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		          v44 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		        }
		        if ( k >= v44->static_fields->effectListCount )
		          break;
		        if ( !v44->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v44);
		          v44 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		        }
		        v45 = this->fields.m_baseMaterial;
		        v46 = v44->static_fields->runtimeMaterial;
		        v47 = (Material *)sub_1800368D0(TypeInfo::UnityEngine::Material);
		        v48 = v47;
		        if ( !v47 )
		          goto LABEL_61;
		        UnityEngine::Material::Material(v47, v45, 0LL);
		        if ( !v46 )
		          goto LABEL_61;
		        sub_180031B10(v46, v48);
		        sub_1800020D0(v46, k, v48);
		      }
		    }
		  }
		  else
		  {
		LABEL_133:
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_useCutsceneEffsectShader = 0;
		  }
		  v18 = (Component *)UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !v18 )
		    goto LABEL_61;
		  gameObject = UnityEngine::Component::get_gameObject(v18, 0LL);
		  if ( !gameObject )
		    goto LABEL_61;
		  if ( !UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
		  {
		    v49 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v49 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    v49->static_fields->m_useCutsceneEffsectShader = 0;
		  }
		  v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  if ( !v20->static_fields->m_useCutsceneEffsectShader )
		  {
		    if ( !v20->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v20);
		    cutsceneEffectPropertyBlock = HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectPropertyBlock(0LL);
		    if ( cutsceneEffectPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::Clear(cutsceneEffectPropertyBlock, 1, 0LL);
		      return;
		    }
		    goto LABEL_61;
		  }
		  while ( 1 )
		  {
		    if ( !v20->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v20);
		      v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    if ( v10 >= v20->static_fields->effectListCount )
		      break;
		    if ( !v20->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v20);
		      v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    runtimeMaterial = &v20->static_fields->m_useCutsceneEffsectShader;
		    effectList = (HGRuntimeGrassQuery_Node *)*((_QWORD *)runtimeMaterial + 3);
		    if ( !effectList )
		      goto LABEL_61;
		    if ( (unsigned int)v10 >= LODWORD(effectList->fields.bounds.m_Center.z) )
		      goto LABEL_103;
		    v21 = *((_QWORD *)&effectList->fields.bounds.m_Extents.y + v10);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    if ( v21 )
		    {
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		      if ( *(_QWORD *)(v21 + 16) )
		      {
		        if ( !v20->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v20);
		          v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		        }
		        runtimeMaterial = &v20->static_fields->m_useCutsceneEffsectShader;
		        v22 = *((_QWORD *)runtimeMaterial + 3);
		        if ( !v22 )
		          goto LABEL_61;
		        if ( (unsigned int)v10 >= *(_DWORD *)(v22 + 24) )
		          goto LABEL_103;
		        v23 = *(Material **)(v22 + 8LL * v10 + 32);
		        v24 = this->fields.effectList;
		        if ( !v24 )
		          goto LABEL_61;
		        if ( (unsigned int)v10 >= v24->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        runtimeMaterial = v24->fields._items;
		        if ( !runtimeMaterial )
		          goto LABEL_61;
		        sub_1800A5FE0(runtimeMaterial, &v53, v10);
		        cutsceneEffectCfg = v53;
		        v25 = HG::Rendering::Runtime::VFXPPCutsceneEffect::SetMaterial(this, v23, &cutsceneEffectCfg, 0LL);
		        sub_180031B10(v22, v25);
		        sub_1800020D0(v22, v10, v25);
		        v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      }
		    }
		    ++v10;
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000184892A30-0x0000000184892AB0
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::ResetByVolumeProfile(
		        VFXPPCutsceneEffect *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct VFXPPCutsceneEffect__Class *v5; // rax
		  MaterialPropertyBlock *cutsceneEffectPropertyBlock; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2493, 0LL) )
		  {
		    v5 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v5 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    v5->static_fields->m_useCutsceneEffsectShader = 0;
		    cutsceneEffectPropertyBlock = HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectPropertyBlock(0LL);
		    if ( cutsceneEffectPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::Clear(cutsceneEffectPropertyBlock, 1, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2493, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
		}
		
		protected override void OnStop() {} // 0x00000001844C7F60-0x00000001844C7FD0
		// Void OnStop()
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::OnStop(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  struct VFXPPCutsceneEffect__Class *v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2494, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2494, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPComponent::OnStop((VFXPPComponent *)this, 0LL);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    v3->static_fields->m_useCutsceneEffsectShader = 0;
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_enableCompatibilityMode = 0;
		  }
		}
		
		public Material SetMaterial(Material material, [IsReadOnly] in CutsceneEffectCfg cutsceneEffectCfg) => default; // 0x0000000184176AA0-0x00000001841770D0
		// Material SetMaterial(Material, VFXPPCutsceneEffect+CutsceneEffectCfg ByRef)
		Material *HG::Rendering::Runtime::VFXPPCutsceneEffect::SetMaterial(
		        VFXPPCutsceneEffect *this,
		        Material *material,
		        VFXPPCutsceneEffect_CutsceneEffectCfg *cutsceneEffectCfg,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  struct VFXPPCutsceneEffect__Class *v8; // rax
		  Material__Array *runtimeMaterial; // rcx
		  struct Object_1__Class *v10; // rcx
		  struct VFXPPCutsceneEffect_ShaderConstants__Class *v11; // rax
		  unsigned int BaseColor; // ebp
		  void (__fastcall *v13)(Material *, _QWORD, LocalKeyword *); // rax
		  struct VFXPPCutsceneEffect_ShaderConstants__Class *v14; // rax
		  struct VFXPPCutsceneEffect_ShaderConstants__Class *v15; // rax
		  float yScale; // xmm1_4
		  VFXPPCutsceneEffect_ShaderConstants__StaticFields *static_fields; // rcx
		  float v18; // xmm2_4
		  struct VFXPPCutsceneEffect_ShaderConstants__Class *v19; // rax
		  struct VFXPPCutsceneEffect_ShaderConstants__Class *v20; // rax
		  float v21; // xmm2_4
		  struct VFXPPCutsceneEffect_ShaderConstants__Class *v23; // rax
		  Shader *shader; // rax
		  __int64 v25; // rax
		  Shader *v26; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LocalKeyword keyword; // [rsp+30h] [rbp-68h] BYREF
		  LocalKeyword v29; // [rsp+50h] [rbp-48h] BYREF
		  LocalKeyword v30; // [rsp+68h] [rbp-30h] BYREF
		
		  memset(&v29, 0, sizeof(v29));
		  memset(&v30, 0, sizeof(v30));
		  if ( IFix::WrappersManagerImpl::IsPatched(2492, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2492, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_953(
		               Patch,
		               (Object *)this,
		               (Object *)material,
		               cutsceneEffectCfg,
		               0LL);
		LABEL_42:
		    sub_1800D8260(runtimeMaterial, v7);
		  }
		  v8 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v8 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  runtimeMaterial = v8->static_fields->runtimeMaterial;
		  if ( !runtimeMaterial )
		    goto LABEL_42;
		  if ( !runtimeMaterial->max_length.value )
		    return 0LL;
		  v10 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v10 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !material )
		    return 0LL;
		  if ( !v10->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v10);
		  if ( !material->fields._.m_CachedPtr )
		    return 0LL;
		  v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		    v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		  }
		  BaseColor = v11->static_fields->_BaseColor;
		  v13 = (void (__fastcall *)(Material *, _QWORD, LocalKeyword *))qword_18F36F6B0;
		  *(Color *)&keyword.m_SpaceInfo.m_KeywordSpace = cutsceneEffectCfg->color;
		  if ( !qword_18F36F6B0 )
		  {
		    v13 = (void (__fastcall *)(Material *, _QWORD, LocalKeyword *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.Material::SetColorImpl_Injected(System."
		                                                                     "Int32,UnityEngine.Color&)");
		    if ( !v13 )
		    {
		      v25 = sub_1802EE1B8("UnityEngine.Material::SetColorImpl_Injected(System.Int32,UnityEngine.Color&)");
		      sub_18007E1B0(v25, 0LL);
		    }
		    qword_18F36F6B0 = (__int64)v13;
		  }
		  v13(material, BaseColor, &keyword);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LightRange1,
		    cutsceneEffectCfg->para1,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LightRange2,
		    cutsceneEffectCfg->para2,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_XOffset,
		    cutsceneEffectCfg->xOffset,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_YOffset,
		    cutsceneEffectCfg->yOffset,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LeftFadeRange,
		    cutsceneEffectCfg->leftFadeRange,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_RightFadeRange,
		    cutsceneEffectCfg->rightFadeRange,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_Ration,
		    cutsceneEffectCfg->rotation,
		    0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_ShapeOption,
		    (float)cutsceneEffectCfg->shapeOption,
		    0LL);
		  if ( !cutsceneEffectCfg->option )
		  {
		    v23 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		      v23 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    }
		    UnityEngine::Material::SetFloatImpl(material, v23->static_fields->_ColorOption, 0.0, 0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_LightIntensity,
		      this->fields.lightIntensity,
		      0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_SrcBlend,
		      1.0,
		      0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DstBlend,
		      1.0,
		      0LL);
		  }
		  if ( cutsceneEffectCfg->option == 1 )
		  {
		    v14 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		      v14 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    }
		    UnityEngine::Material::SetFloatImpl(material, v14->static_fields->_ColorOption, 1.0, 0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DarkIntensity,
		      this->fields.darkIntensity,
		      0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_SrcBlend,
		      2.0,
		      0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DstBlend,
		      0.0,
		      0LL);
		  }
		  v15 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		    v15 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		  }
		  UnityEngine::Material::SetFloatImpl(material, v15->static_fields->_TotalXOffset, this->fields.totalXOffset, 0LL);
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_TotalYOffset,
		    this->fields.totalYOffset,
		    0LL);
		  yScale = cutsceneEffectCfg->yScale;
		  *(float *)&keyword.m_SpaceInfo.m_KeywordSpace = cutsceneEffectCfg->xScale;
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields;
		  *((float *)&keyword.m_SpaceInfo.m_KeywordSpace + 1) = yScale;
		  keyword.m_Name = (String *)0x3F8000003F800000LL;
		  UnityEngine::Material::SetVector(material, static_fields->_Scale, (Vector4 *)&keyword, 0LL);
		  if ( cutsceneEffectCfg->autoStretchMode == 1 )
		    v18 = 0.0;
		  else
		    v18 = 1.0;
		  UnityEngine::Material::SetFloatImpl(
		    material,
		    TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_EnableAutoStretch,
		    v18,
		    0LL);
		  if ( cutsceneEffectCfg->useDepthFade )
		  {
		    if ( !UnityEngine::Material::IsKeywordEnabled(material, (String *)"_ENABLE_DEPTH_FADE", 0LL) )
		    {
		      shader = UnityEngine::Material::get_shader(material, 0LL);
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v29, shader, (String *)"_ENABLE_DEPTH_FADE", 0LL);
		      keyword = v29;
		      UnityEngine::Material::SetLocalKeyword_Injected(material, &keyword, 1, 0LL);
		    }
		    v19 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		      v19 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    }
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      v19->static_fields->_NearFadeIntensity,
		      cutsceneEffectCfg->nearFadeIntensity,
		      0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DepthFadePosition,
		      cutsceneEffectCfg->depthFadePosition,
		      0LL);
		    UnityEngine::Material::SetFloatImpl(
		      material,
		      TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->static_fields->_DepthFadeRange,
		      cutsceneEffectCfg->depthFadeRange,
		      0LL);
		    v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		    if ( cutsceneEffectCfg->useInvertFade )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		        v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		      }
		      v21 = 1.0;
		    }
		    else
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
		        v20 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants;
		      }
		      v21 = 0.0;
		    }
		    UnityEngine::Material::SetFloatImpl(material, v20->static_fields->_UseInvertFade, v21, 0LL);
		  }
		  else if ( UnityEngine::Material::IsKeywordEnabled(material, (String *)"_ENABLE_DEPTH_FADE", 0LL) )
		  {
		    v26 = UnityEngine::Material::get_shader(material, 0LL);
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v30, v26, (String *)"_ENABLE_DEPTH_FADE", 0LL);
		    UnityEngine::Material::SetKeyword(material, &v30, 0, 0LL);
		  }
		  return material;
		}
		
		public VFXPPType __iFixBaseProxy_get_m_VFXPPType() => default; // 0x0000000189B5D900-0x0000000189B5D908
		// VFXPPType <>iFixBaseProxy_get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_get_m_VFXPPType(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_m_VFXPPType((VFXPPComponent *)this, 0LL);
		}
		
		public void __iFixBaseProxy_SetData(VFXPPData P0) {} // 0x0000000189B5F0AC-0x0000000189B5F0B4
		// Void <>iFixBaseProxy_SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_SetData(
		        VFXPPVignette *this,
		        VFXPPData *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::SetData((VFXPPComponent *)this, P0, 0LL);
		}
		
		public VFXPPData __iFixBaseProxy_GetData() => default; // 0x0000000189B5F09C-0x0000000189B5F0A4
		// VFXPPData <>iFixBaseProxy_GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetData(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::GetData((VFXPPComponent *)this, 0LL);
		}
		
		public VFXPPData __iFixBaseProxy_GetDefaultData() => default; // 0x0000000189B5F0A4-0x0000000189B5F0AC
		// VFXPPData <>iFixBaseProxy_GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetDefaultData(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::GetDefaultData((VFXPPComponent *)this, 0LL);
		}
		
		public VFXPPData __iFixBaseProxy__GetLerpData(float P0) => default; // 0x0000000189B5F0B4-0x0000000189B5F0BC
		// VFXPPData <>iFixBaseProxy__GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy__GetLerpData(
		        VFXPPVignette *this,
		        float P0,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::_GetLerpData((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_Apply(VolumeProfile P0) {} // 0x0000000189B5D8E8-0x0000000189B5D8F0
		// Void <>iFixBaseProxy_Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0) {} // 0x0000000189B5D8F8-0x0000000189B5D900
		// Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_OnStop() {} // 0x0000000189B60F34-0x0000000189B60F3C
		// Void <>iFixBaseProxy_OnStop()
		void HG::Rendering::Runtime::VFXPPCutsceneEffect::__iFixBaseProxy_OnStop(VFXPPCutsceneEffect *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::OnStop((VFXPPComponent *)this, 0LL);
		}
		
	}
}
