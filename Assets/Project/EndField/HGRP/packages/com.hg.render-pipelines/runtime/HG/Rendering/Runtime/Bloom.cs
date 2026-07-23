using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Bloom", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class Bloom : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38002
	{
		// Fields
		[Header("Bloom")]
		public BloomQualityParameter quality; // 0x30
		public BloomResolutionParameter resolutionHighQuality; // 0x38
		public BloomResolutionParameter resolutionMedQuality; // 0x40
		public BloomResolutionParameter resolutionLowQuality; // 0x48
		[Tooltip("Set the level of brightness to filter out pixels under this level. This value is expressed in gamma-space. A value above 0 will disregard energy conservation rules.")]
		public MinFloatParameter thresholdHighQuality; // 0x50
		public MinFloatParameter thresholdMedQuality; // 0x58
		public MinFloatParameter thresholdLowQuality; // 0x60
		[Tooltip("Controls the strength of the bloom filter.")]
		public ClampedFloatParameter intensityHighQuality; // 0x68
		public ClampedFloatParameter intensityMedQuality; // 0x70
		public ClampedFloatParameter intensityLowQuality; // 0x78
		[Tooltip("Set the radius of the bloom effect")]
		public ClampedFloatParameter scatterHighQuality; // 0x80
		public ClampedFloatParameter scatterMedQuality; // 0x88
		public ClampedFloatParameter scatterLowQuality; // 0x90
		[Tooltip("Use the color picker to select a color for the Bloom effect to tint to.")]
		public ColorParameter tint; // 0x98
		[Tooltip("Determine the blend mode of scene color and bloom color.(Default is Add mode)")]
		public BloomBlendModeParameter blendMode; // 0xA0
		[Header("Character Bloom Control")]
		[Tooltip("When enabled, use character mask to control different params with env and character.")]
		public BoolParameter characterBloomControl; // 0xA8
		[Tooltip("Threshold of the character bloom")]
		public MinFloatParameter characterThreshold; // 0xB0
		[HideInInspector]
		[Tooltip("Softness of the character bloom")]
		public ClampedFloatParameter characterSoftness; // 0xB8
		[Tooltip("Intensity multiplier of the character bloom")]
		public ClampedFloatParameter characterIntensity; // 0xC0
		[Header("Lens Dirt")]
		[Tooltip("Specifies a Texture to add smudges or dust to the bloom effect.")]
		public Texture2DParameter dirtTexture; // 0xC8
		[Tooltip("Controls the strength of the lens dirt.")]
		public MinFloatParameter dirtIntensity; // 0xD0
		[AdditionalProperty]
		[Tooltip("When enabled, bloom stretches horizontally depending on the current physical Camera\'s Anamorphism property value.")]
		public BoolParameter anamorphic; // 0xD8
	
		// Properties
		public BloomResolution resolution { get => default; } // 0x00000001831B8B10-0x00000001831B8BA0 
		// BloomResolution get_resolution()
		BloomResolution__Enum HG::Rendering::Runtime::Bloom::get_resolution(Bloom *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  int *wrapperArray; // rdx
		  int v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray[6] <= 2664 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_10;
		  if ( LODWORD(v3->_0.namespaze) <= 0xA68 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[56]._1.field_count )
		  {
		LABEL_5:
		    wrapperArray = (int *)this->fields.quality;
		    if ( !wrapperArray )
		      goto LABEL_10;
		    v5 = sub_180002F70(10LL, wrapperArray);
		    if ( v5 == 2 )
		    {
		      wrapperArray = (int *)this->fields.resolutionHighQuality;
		    }
		    else if ( v5 )
		    {
		      if ( v5 != 1 )
		        return 2;
		      wrapperArray = (int *)this->fields.resolutionMedQuality;
		    }
		    else
		    {
		      wrapperArray = (int *)this->fields.resolutionLowQuality;
		    }
		    if ( wrapperArray )
		      return (unsigned int)sub_180002F70(10LL, wrapperArray);
		LABEL_10:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2664, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public float threshold { get => default; } // 0x00000001831B8420-0x00000001831B8670 
		// Single get_threshold()
		float HG::Rendering::Runtime::Bloom::get_threshold(Bloom *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  double v5; // xmm0_8
		  float (*namespaze)(AbilitySystem *, MethodInfo *); // r8
		  ClampedFloatParameter *intensityLowQuality; // rax
		  int32_t v8; // ecx
		  ILFixDynamicMethodWrapper_3 *v9; // rax
		  ILFixDynamicMethodWrapper_15 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_32;
		  if ( *(int *)(v4 + 24) > 2665 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(_DWORD *)(v4 + 24) <= 0xA69u )
		      goto LABEL_71;
		    if ( *(_QWORD *)(v4 + 21352) )
		    {
		      Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(2665, 0LL);
		      if ( Patch )
		        goto LABEL_73;
		      goto LABEL_32;
		    }
		  }
		  this = (Bloom *)this->fields.thresholdHighQuality;
		  if ( !this )
		    goto LABEL_32;
		  v5 = sub_1800049A0(this->klass);
		  namespaze = (float (*)(AbilitySystem *, MethodInfo *))this->klass[1]._0.namespaze;
		  if ( namespaze == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) <= 3314 )
		      goto LABEL_14;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(_DWORD *)(v4 + 24) <= 0xCF2u )
		      goto LABEL_71;
		    if ( !*(_QWORD *)(v4 + 26544) )
		    {
		LABEL_14:
		      intensityLowQuality = this[2].fields.intensityLowQuality;
		      if ( intensityLowQuality )
		      {
		        v3 = (_QWORD **)intensityLowQuality->fields._._._;
		        if ( v3 )
		        {
		          LODWORD(v5) = *((_DWORD *)v3 + 4);
		          return *(float *)&v5;
		        }
		      }
		      goto LABEL_32;
		    }
		    v8 = 3314;
		LABEL_72:
		    Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(v8, 0LL);
		    if ( Patch )
		    {
		LABEL_73:
		      *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(Patch, (Object *)this, 0LL);
		      return *(float *)&v5;
		    }
		LABEL_32:
		    sub_1800D8260(v3, v4);
		  }
		  if ( (char *)namespaze == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) > 927 )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(_DWORD *)(v4 + 24) <= 0x39Fu )
		        goto LABEL_71;
		      if ( *(_QWORD *)(v4 + 7448) )
		      {
		        v9 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( v9 )
		        {
		          *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v9, (Object *)this, 0LL);
		          return *(float *)&v5;
		        }
		        goto LABEL_32;
		      }
		    }
		    goto LABEL_21;
		  }
		  if ( (char *)namespaze == (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) > 2201 )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(_DWORD *)(v4 + 24) <= 0x899u )
		        goto LABEL_71;
		      if ( *(_QWORD *)(v4 + 17640) )
		      {
		        Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( Patch )
		          goto LABEL_73;
		        goto LABEL_32;
		      }
		    }
		    if ( this->fields._._displayName_k__BackingField )
		    {
		      this = (Bloom *)this->fields._._displayName_k__BackingField;
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(int *)(v4 + 24) <= 2202 )
		      {
		LABEL_31:
		        LODWORD(v5) = HIDWORD(this->fields.dirtTexture);
		        return *(float *)&v5;
		      }
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v3 = (_QWORD **)*v3[23];
		      if ( !v3 )
		        goto LABEL_32;
		      if ( *((_DWORD *)v3 + 6) <= 0x89Au )
		LABEL_71:
		        sub_1800D2AB0(v3, v4);
		      if ( !v3[2206] )
		        goto LABEL_31;
		      v8 = 2202;
		      goto LABEL_72;
		    }
		LABEL_21:
		    LODWORD(v5) = 0;
		    return *(float *)&v5;
		  }
		  ((void (__fastcall *)(Bloom *, void *))namespaze)(this, this->klass[1]._0.byval_arg.data.dummy);
		  return *(float *)&v5;
		}
		
		public float intensity { get => default; } // 0x00000001831B8670-0x00000001831B88C0 
		// Single get_intensity()
		float HG::Rendering::Runtime::Bloom::get_intensity(Bloom *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  double v5; // xmm0_8
		  float (*namespaze)(AbilitySystem *, MethodInfo *); // r8
		  ClampedFloatParameter *intensityLowQuality; // rax
		  int32_t v8; // ecx
		  ILFixDynamicMethodWrapper_3 *v9; // rax
		  ILFixDynamicMethodWrapper_15 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_32;
		  if ( *(int *)(v4 + 24) > 2666 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(_DWORD *)(v4 + 24) <= 0xA6Au )
		      goto LABEL_71;
		    if ( *(_QWORD *)(v4 + 21360) )
		    {
		      Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(2666, 0LL);
		      if ( Patch )
		        goto LABEL_73;
		      goto LABEL_32;
		    }
		  }
		  this = (Bloom *)this->fields.intensityHighQuality;
		  if ( !this )
		    goto LABEL_32;
		  v5 = sub_1800049A0(this->klass);
		  namespaze = (float (*)(AbilitySystem *, MethodInfo *))this->klass[1]._0.namespaze;
		  if ( namespaze == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) <= 3314 )
		      goto LABEL_14;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(_DWORD *)(v4 + 24) <= 0xCF2u )
		      goto LABEL_71;
		    if ( !*(_QWORD *)(v4 + 26544) )
		    {
		LABEL_14:
		      intensityLowQuality = this[2].fields.intensityLowQuality;
		      if ( intensityLowQuality )
		      {
		        v3 = (_QWORD **)intensityLowQuality->fields._._._;
		        if ( v3 )
		        {
		          LODWORD(v5) = *((_DWORD *)v3 + 4);
		          return *(float *)&v5;
		        }
		      }
		      goto LABEL_32;
		    }
		    v8 = 3314;
		LABEL_72:
		    Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(v8, 0LL);
		    if ( Patch )
		    {
		LABEL_73:
		      *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(Patch, (Object *)this, 0LL);
		      return *(float *)&v5;
		    }
		LABEL_32:
		    sub_1800D8260(v3, v4);
		  }
		  if ( (char *)namespaze == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) > 927 )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(_DWORD *)(v4 + 24) <= 0x39Fu )
		        goto LABEL_71;
		      if ( *(_QWORD *)(v4 + 7448) )
		      {
		        v9 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( v9 )
		        {
		          *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v9, (Object *)this, 0LL);
		          return *(float *)&v5;
		        }
		        goto LABEL_32;
		      }
		    }
		    goto LABEL_21;
		  }
		  if ( (char *)namespaze == (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) > 2201 )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(_DWORD *)(v4 + 24) <= 0x899u )
		        goto LABEL_71;
		      if ( *(_QWORD *)(v4 + 17640) )
		      {
		        Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( Patch )
		          goto LABEL_73;
		        goto LABEL_32;
		      }
		    }
		    if ( this->fields._._displayName_k__BackingField )
		    {
		      this = (Bloom *)this->fields._._displayName_k__BackingField;
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(int *)(v4 + 24) <= 2202 )
		      {
		LABEL_31:
		        LODWORD(v5) = HIDWORD(this->fields.dirtTexture);
		        return *(float *)&v5;
		      }
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v3 = (_QWORD **)*v3[23];
		      if ( !v3 )
		        goto LABEL_32;
		      if ( *((_DWORD *)v3 + 6) <= 0x89Au )
		LABEL_71:
		        sub_1800D2AB0(v3, v4);
		      if ( !v3[2206] )
		        goto LABEL_31;
		      v8 = 2202;
		      goto LABEL_72;
		    }
		LABEL_21:
		    LODWORD(v5) = 0;
		    return *(float *)&v5;
		  }
		  ((void (__fastcall *)(Bloom *, void *))namespaze)(this, this->klass[1]._0.byval_arg.data.dummy);
		  return *(float *)&v5;
		}
		
		public float scatter { get => default; } // 0x00000001831B88C0-0x00000001831B8B10 
		// Single get_scatter()
		float HG::Rendering::Runtime::Bloom::get_scatter(Bloom *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  __int64 v4; // rdx
		  double v5; // xmm0_8
		  float (*namespaze)(AbilitySystem *, MethodInfo *); // r8
		  ClampedFloatParameter *intensityLowQuality; // rax
		  int32_t v8; // ecx
		  ILFixDynamicMethodWrapper_3 *v9; // rax
		  ILFixDynamicMethodWrapper_15 *Patch; // rax
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *v3[23];
		  if ( !v4 )
		    goto LABEL_32;
		  if ( *(int *)(v4 + 24) > 2667 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(_DWORD *)(v4 + 24) <= 0xA6Bu )
		      goto LABEL_71;
		    if ( *(_QWORD *)(v4 + 21368) )
		    {
		      Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(2667, 0LL);
		      if ( Patch )
		        goto LABEL_73;
		      goto LABEL_32;
		    }
		  }
		  this = (Bloom *)this->fields.scatterHighQuality;
		  if ( !this )
		    goto LABEL_32;
		  v5 = sub_1800049A0(this->klass);
		  namespaze = (float (*)(AbilitySystem *, MethodInfo *))this->klass[1]._0.namespaze;
		  if ( namespaze == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) <= 3314 )
		      goto LABEL_14;
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(_DWORD *)(v4 + 24) <= 0xCF2u )
		      goto LABEL_71;
		    if ( !*(_QWORD *)(v4 + 26544) )
		    {
		LABEL_14:
		      intensityLowQuality = this[2].fields.intensityLowQuality;
		      if ( intensityLowQuality )
		      {
		        v3 = (_QWORD **)intensityLowQuality->fields._._._;
		        if ( v3 )
		        {
		          LODWORD(v5) = *((_DWORD *)v3 + 4);
		          return *(float *)&v5;
		        }
		      }
		      goto LABEL_32;
		    }
		    v8 = 3314;
		LABEL_72:
		    Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(v8, 0LL);
		    if ( Patch )
		    {
		LABEL_73:
		      *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(Patch, (Object *)this, 0LL);
		      return *(float *)&v5;
		    }
		LABEL_32:
		    sub_1800D8260(v3, v4);
		  }
		  if ( (char *)namespaze == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) > 927 )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(_DWORD *)(v4 + 24) <= 0x39Fu )
		        goto LABEL_71;
		      if ( *(_QWORD *)(v4 + 7448) )
		      {
		        v9 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( v9 )
		        {
		          *(float *)&v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v9, (Object *)this, 0LL);
		          return *(float *)&v5;
		        }
		        goto LABEL_32;
		      }
		    }
		    goto LABEL_21;
		  }
		  if ( (char *)namespaze == (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = *v3[23];
		    if ( !v4 )
		      goto LABEL_32;
		    if ( *(int *)(v4 + 24) > 2201 )
		    {
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(_DWORD *)(v4 + 24) <= 0x899u )
		        goto LABEL_71;
		      if ( *(_QWORD *)(v4 + 17640) )
		      {
		        Patch = (ILFixDynamicMethodWrapper_15 *)IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( Patch )
		          goto LABEL_73;
		        goto LABEL_32;
		      }
		    }
		    if ( this->fields._._displayName_k__BackingField )
		    {
		      this = (Bloom *)this->fields._._displayName_k__BackingField;
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v4 = *v3[23];
		      if ( !v4 )
		        goto LABEL_32;
		      if ( *(int *)(v4 + 24) <= 2202 )
		      {
		LABEL_31:
		        LODWORD(v5) = HIDWORD(this->fields.dirtTexture);
		        return *(float *)&v5;
		      }
		      if ( !*((_DWORD *)v3 + 56) )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v3 = (_QWORD **)*v3[23];
		      if ( !v3 )
		        goto LABEL_32;
		      if ( *((_DWORD *)v3 + 6) <= 0x89Au )
		LABEL_71:
		        sub_1800D2AB0(v3, v4);
		      if ( !v3[2206] )
		        goto LABEL_31;
		      v8 = 2202;
		      goto LABEL_72;
		    }
		LABEL_21:
		    LODWORD(v5) = 0;
		    return *(float *)&v5;
		  }
		  ((void (__fastcall *)(Bloom *, void *))namespaze)(this, this->klass[1]._0.byval_arg.data.dummy);
		  return *(float *)&v5;
		}
		
		public bool dirtEnabled { get => default; } // 0x00000001831B8BA0-0x00000001831B8C70 
		// Boolean get_dirtEnabled()
		bool HG::Rendering::Runtime::Bloom::get_dirtEnabled(Bloom *this, MethodInfo *method)
		{
		  _QWORD **v3; // rcx
		  int *dirtTexture; // rdx
		  __int64 v5; // rax
		  __int64 v6; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  double v9; // xmm0_8
		
		  v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  dirtTexture = (int *)*v3[23];
		  if ( !dirtTexture )
		    goto LABEL_12;
		  if ( dirtTexture[6] > 2668 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (_QWORD **)*v3[23];
		    if ( !v3 )
		      goto LABEL_12;
		    if ( *((_DWORD *)v3 + 6) <= 0xA6Cu )
		      sub_1800D2AB0(v3, dirtTexture);
		    if ( v3[2672] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2668, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		LABEL_12:
		      sub_1800D8260(v3, dirtTexture);
		    }
		  }
		  dirtTexture = (int *)this->fields.dirtTexture;
		  if ( !dirtTexture )
		    goto LABEL_12;
		  v5 = sub_1800460A0(10LL, dirtTexture);
		  v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  v6 = v5;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v6 )
		    return 0;
		  if ( !*((_DWORD *)v3 + 56) )
		    il2cpp_runtime_class_init_1(v3);
		  if ( !*(_QWORD *)(v6 + 16) )
		    return 0;
		  dirtTexture = (int *)this->fields.dirtIntensity;
		  if ( !dirtTexture )
		    goto LABEL_12;
		  v9 = sub_1800057D0(10LL, dirtTexture);
		  return *(float *)&v9 > 0.0;
		}
		
	
		// Constructors
		public Bloom() {} // 0x000000018402C6E0-0x000000018402CBD0
		// Bloom()
		void HG::Rendering::Runtime::Bloom::Bloom(Bloom *this, MethodInfo *method)
		{
		  BloomQualityParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  BloomResolutionParameter *v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  BloomResolutionParameter *v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  BloomResolutionParameter *v14; // rax
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
		  __int64 v32; // rax
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  __int64 v35; // rax
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  __int64 v38; // rax
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  __int64 v41; // rax
		  PropertyInfo_1 *v42; // r8
		  Int32__Array **v43; // r9
		  MethodInfo *v44; // rdx
		  __int64 v45; // rax
		  PropertyInfo_1 *v46; // r8
		  Int32__Array **v47; // r9
		  Vector4 v48; // xmm0
		  BloomBlendModeParameter *v49; // rax
		  PropertyInfo_1 *v50; // r8
		  Int32__Array **v51; // r9
		  BoolParameter *v52; // rax
		  PropertyInfo_1 *v53; // r8
		  Int32__Array **v54; // r9
		  __int64 v55; // rax
		  PropertyInfo_1 *v56; // r8
		  Int32__Array **v57; // r9
		  __int64 v58; // rax
		  PropertyInfo_1 *v59; // r8
		  Int32__Array **v60; // r9
		  __int64 v61; // rax
		  PropertyInfo_1 *v62; // r8
		  Int32__Array **v63; // r9
		  Texture2DParameter *v64; // rax
		  Texture2DParameter *v65; // rdi
		  Type *v66; // rdx
		  PropertyInfo_1 *v67; // r8
		  Int32__Array **v68; // r9
		  __int64 v69; // rax
		  PropertyInfo_1 *v70; // r8
		  Int32__Array **v71; // r9
		  BoolParameter *v72; // rax
		  PropertyInfo_1 *v73; // r8
		  Int32__Array **v74; // r9
		  Vector4 v75; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = (BloomQualityParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BloomQualityParameter);
		  if ( !v3 )
		    goto LABEL_24;
		  v3->fields._.m_Value = 2;
		  v3->fields._._.overrideState = 0;
		  this->fields.quality = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.quality, v4, v6, v7, *(MethodInfo **)&v75.x);
		  v8 = (BloomResolutionParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
		  if ( !v8 )
		    goto LABEL_24;
		  v8->fields._.m_Value = 2;
		  v8->fields._._.overrideState = 1;
		  this->fields.resolutionHighQuality = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.resolutionHighQuality, v4, v9, v10, *(MethodInfo **)&v75.x);
		  v11 = (BloomResolutionParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
		  if ( !v11 )
		    goto LABEL_24;
		  v11->fields._.m_Value = 4;
		  v11->fields._._.overrideState = 1;
		  this->fields.resolutionMedQuality = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.resolutionMedQuality, v4, v12, v13, *(MethodInfo **)&v75.x);
		  v14 = (BloomResolutionParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
		  if ( !v14 )
		    goto LABEL_24;
		  v14->fields._.m_Value = 4;
		  v14->fields._._.overrideState = 1;
		  this->fields.resolutionLowQuality = v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.resolutionLowQuality, v4, v15, v16, *(MethodInfo **)&v75.x);
		  v17 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v17 )
		    goto LABEL_24;
		  *(_BYTE *)(v17 + 16) = 1;
		  *(_DWORD *)(v17 + 24) = 0;
		  *(_DWORD *)(v17 + 32) = 0;
		  this->fields.thresholdHighQuality = (MinFloatParameter *)v17;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.thresholdHighQuality, v4, v18, v19, *(MethodInfo **)&v75.x);
		  v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v20 )
		    goto LABEL_24;
		  *(_DWORD *)(v20 + 24) = 0;
		  *(_BYTE *)(v20 + 16) = 1;
		  *(_DWORD *)(v20 + 32) = 0;
		  this->fields.thresholdMedQuality = (MinFloatParameter *)v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.thresholdMedQuality, v4, v21, v22, *(MethodInfo **)&v75.x);
		  v23 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v23 )
		    goto LABEL_24;
		  *(_DWORD *)(v23 + 24) = 0;
		  *(_BYTE *)(v23 + 16) = 1;
		  *(_DWORD *)(v23 + 32) = 0;
		  this->fields.thresholdLowQuality = (MinFloatParameter *)v23;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.thresholdLowQuality, v4, v24, v25, *(MethodInfo **)&v75.x);
		  v26 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v26 )
		    goto LABEL_24;
		  *(_DWORD *)(v26 + 24) = 0;
		  *(_BYTE *)(v26 + 16) = 1;
		  *(_DWORD *)(v26 + 32) = 0;
		  *(_DWORD *)(v26 + 36) = 1065353216;
		  *(_DWORD *)(v26 + 40) = 1065353216;
		  this->fields.intensityHighQuality = (ClampedFloatParameter *)v26;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.intensityHighQuality, v4, v27, v28, *(MethodInfo **)&v75.x);
		  v29 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v29 )
		    goto LABEL_24;
		  *(_DWORD *)(v29 + 24) = 0;
		  *(_BYTE *)(v29 + 16) = 1;
		  *(_DWORD *)(v29 + 32) = 0;
		  *(_DWORD *)(v29 + 36) = 1065353216;
		  *(_DWORD *)(v29 + 40) = 1065353216;
		  this->fields.intensityMedQuality = (ClampedFloatParameter *)v29;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.intensityMedQuality, v4, v30, v31, *(MethodInfo **)&v75.x);
		  v32 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v32 )
		    goto LABEL_24;
		  *(_DWORD *)(v32 + 24) = 0;
		  *(_BYTE *)(v32 + 16) = 1;
		  *(_DWORD *)(v32 + 32) = 0;
		  *(_DWORD *)(v32 + 36) = 1065353216;
		  *(_DWORD *)(v32 + 40) = 1065353216;
		  this->fields.intensityLowQuality = (ClampedFloatParameter *)v32;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.intensityLowQuality, v4, v33, v34, *(MethodInfo **)&v75.x);
		  v35 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v35 )
		    goto LABEL_24;
		  *(_DWORD *)(v35 + 24) = 1060320051;
		  *(_BYTE *)(v35 + 16) = 1;
		  *(_DWORD *)(v35 + 32) = 0;
		  *(_DWORD *)(v35 + 36) = 1065353216;
		  *(_DWORD *)(v35 + 40) = 1065353216;
		  this->fields.scatterHighQuality = (ClampedFloatParameter *)v35;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.scatterHighQuality, v4, v36, v37, *(MethodInfo **)&v75.x);
		  v38 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v38 )
		    goto LABEL_24;
		  *(_DWORD *)(v38 + 24) = 1060320051;
		  *(_BYTE *)(v38 + 16) = 1;
		  *(_DWORD *)(v38 + 32) = 0;
		  *(_DWORD *)(v38 + 36) = 1065353216;
		  *(_DWORD *)(v38 + 40) = 1065353216;
		  this->fields.scatterMedQuality = (ClampedFloatParameter *)v38;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.scatterMedQuality, v4, v39, v40, *(MethodInfo **)&v75.x);
		  v41 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v41 )
		    goto LABEL_24;
		  *(_DWORD *)(v41 + 24) = 1060320051;
		  *(_BYTE *)(v41 + 16) = 1;
		  *(_DWORD *)(v41 + 32) = 0;
		  *(_DWORD *)(v41 + 36) = 1065353216;
		  *(_DWORD *)(v41 + 40) = 1065353216;
		  this->fields.scatterLowQuality = (ClampedFloatParameter *)v41;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.scatterLowQuality, v4, v42, v43, *(MethodInfo **)&v75.x);
		  v75 = *UnityEngine::Vector4::get_one(&v75, v44);
		  v45 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v45 )
		    goto LABEL_24;
		  v48 = v75;
		  *(_WORD *)(v45 + 40) = 0;
		  *(_BYTE *)(v45 + 42) = 1;
		  *(Vector4 *)(v45 + 24) = v48;
		  *(_BYTE *)(v45 + 16) = 0;
		  this->fields.tint = (ColorParameter *)v45;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.tint, v4, v46, v47, *(MethodInfo **)&v75.x);
		  v49 = (BloomBlendModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BloomBlendModeParameter);
		  if ( !v49 )
		    goto LABEL_24;
		  v49->fields._.m_Value = 0;
		  v49->fields._._.overrideState = 0;
		  this->fields.blendMode = v49;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blendMode, v4, v50, v51, *(MethodInfo **)&v75.x);
		  v52 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v52 )
		    goto LABEL_24;
		  v52->fields._.m_Value = 0;
		  v52->fields._._.overrideState = 0;
		  this->fields.characterBloomControl = v52;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.characterBloomControl, v4, v53, v54, *(MethodInfo **)&v75.x);
		  v55 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v55 )
		    goto LABEL_24;
		  *(_DWORD *)(v55 + 24) = 1056964608;
		  *(_BYTE *)(v55 + 16) = 1;
		  *(_DWORD *)(v55 + 32) = 0;
		  this->fields.characterThreshold = (MinFloatParameter *)v55;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.characterThreshold, v4, v56, v57, *(MethodInfo **)&v75.x);
		  v58 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v58 )
		    goto LABEL_24;
		  *(_DWORD *)(v58 + 24) = 1056964608;
		  *(_BYTE *)(v58 + 16) = 1;
		  *(_DWORD *)(v58 + 32) = 0;
		  *(_DWORD *)(v58 + 36) = 1065353216;
		  *(_DWORD *)(v58 + 40) = 1065353216;
		  this->fields.characterSoftness = (ClampedFloatParameter *)v58;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.characterSoftness, v4, v59, v60, *(MethodInfo **)&v75.x);
		  v61 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v61 )
		    goto LABEL_24;
		  *(_DWORD *)(v61 + 24) = 1065353216;
		  *(_BYTE *)(v61 + 16) = 1;
		  *(_DWORD *)(v61 + 32) = 0;
		  *(_DWORD *)(v61 + 36) = 1084227584;
		  *(_DWORD *)(v61 + 40) = 1065353216;
		  this->fields.characterIntensity = (ClampedFloatParameter *)v61;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.characterIntensity, v4, v62, v63, *(MethodInfo **)&v75.x);
		  v64 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v65 = v64;
		  if ( !v64 )
		    goto LABEL_24;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v64, 0LL, 0, 0LL);
		  this->fields.dirtTexture = v65;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.dirtTexture, v66, v67, v68, *(MethodInfo **)&v75.x);
		  v69 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v69
		    || (*(_DWORD *)(v69 + 24) = 0,
		        *(_BYTE *)(v69 + 16) = 0,
		        *(_DWORD *)(v69 + 32) = 0,
		        this->fields.dirtIntensity = (MinFloatParameter *)v69,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.dirtIntensity, v4, v70, v71, *(MethodInfo **)&v75.x),
		        (v72 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter)) == 0LL) )
		  {
		LABEL_24:
		    sub_1800D8260(v5, v4);
		  }
		  v72->fields._.m_Value = 1;
		  v72->fields._._.overrideState = 0;
		  this->fields.anamorphic = v72;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.anamorphic, v4, v73, v74, *(MethodInfo **)&v75.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B68338-0x0000000189B68394
		// Boolean IsActive()
		bool HG::Rendering::Runtime::Bloom::IsActive(Bloom *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2669, 0LL) )
		    return HG::Rendering::Runtime::Bloom::get_intensity(this, 0LL) > 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2669, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
