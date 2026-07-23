using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineAsset : RenderPipelineAsset, IVirtualTexturingEnabledRenderPipeline, IVersionable<HG.Rendering.Runtime.HGRenderPipelineAsset.Version>, IMigratableAsset // TypeDefIndex: 38146
	{
		// Fields
		[NonSerialized]
		internal bool isInOnValidateCall; // 0x18
		[FormerlySerializedAs("renderPipelineSettings")]
		[SerializeField]
		private RenderPipelineSettings m_RenderPipelineSettings; // 0x20
		[SerializeField]
		internal bool allowShaderVariantStripping; // 0x90
		[SerializeField]
		internal bool enableSRPBatcher; // 0x91
		[SerializeField]
		internal bool enableSRPBatchInstancing; // 0x92
		[NonSerialized]
		public bool enableSimpleUIRenderPath; // 0x93
		[NonSerialized]
		public bool enableCppRenderPath; // 0x94
		[NonSerialized]
		public bool enableSrpDirectCall; // 0x95
		[SerializeField]
		private bool m_UseRenderGraph; // 0x96
		private static readonly MigrationDescription<Version, HGRenderPipelineAsset> k_Migration; // 0x00
		[SerializeField]
		private Version m_Version; // 0x98
		[FormerlySerializedAs("m_FrameSettings")]
		[FormerlySerializedAs("serializedFrameSettings")]
		[Obsolete("For data migration")]
		[SerializeField]
		private ObsoleteFrameSettings m_ObsoleteFrameSettings; // 0xA0
		[FormerlySerializedAs("m_BakedOrCustomReflectionFrameSettings")]
		[Obsolete("For data migration")]
		[SerializeField]
		private ObsoleteFrameSettings m_ObsoleteBakedOrCustomReflectionFrameSettings; // 0xA8
		[FormerlySerializedAs("m_RealtimeReflectionFrameSettings")]
		[Obsolete("For data migration")]
		[SerializeField]
		private ObsoleteFrameSettings m_ObsoleteRealtimeReflectionFrameSettings; // 0xB0
		[FormerlySerializedAs("m_DefaultVolumeProfile")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal VolumeProfile m_ObsoleteDefaultVolumeProfile; // 0xB8
		[FormerlySerializedAs("m_DefaultLookDevProfile")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal VolumeProfile m_ObsoleteDefaultLookDevProfile; // 0xC0
		[FormerlySerializedAs("m_RenderingPathDefaultCameraFrameSettings")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal FrameSettings m_ObsoleteFrameSettingsMovedToDefaultSettings; // 0xC8
		[FormerlySerializedAs("m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal FrameSettings m_ObsoleteBakedOrCustomReflectionFrameSettingsMovedToDefaultSettings; // 0xE0
		[FormerlySerializedAs("m_RenderingPathDefaultRealtimeReflectionFrameSettings")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal FrameSettings m_ObsoleteRealtimeReflectionFrameSettingsMovedToDefaultSettings; // 0xF8
		[FormerlySerializedAs("m_RenderPipelineResources")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal HGRenderPipelineRuntimeResources m_ObsoleteRenderPipelineResources; // 0x110
		[FormerlySerializedAs("beforeTransparentCustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal List<string> m_ObsoleteBeforeTransparentCustomPostProcesses; // 0x118
		[FormerlySerializedAs("beforePostProcessCustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal List<string> m_ObsoleteBeforePostProcessCustomPostProcesses; // 0x120
		[FormerlySerializedAs("afterPostProcessCustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal List<string> m_ObsoleteAfterPostProcessCustomPostProcesses; // 0x128
		[FormerlySerializedAs("beforeTAACustomPostProcesses")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal List<string> m_ObsoleteBeforeTAACustomPostProcesses; // 0x130
		[FormerlySerializedAs("shaderVariantLogLevel")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal ShaderVariantLogLevel m_ObsoleteShaderVariantLogLevel; // 0x138
		[FormerlySerializedAs("m_LensAttenuation")]
		[Obsolete("Moved from HGRPAsset to HDGlobal Settings")]
		[SerializeField]
		internal LensAttenuationMode m_ObsoleteLensAttenuation; // 0x13C
	
		// Properties
		private HGRenderPipelineGlobalSettings globalSettings { get => default; } // 0x000000018344DC60-0x000000018344DCE0 
		// HGRenderPipelineGlobalSettings get_globalSettings()
		HGRenderPipelineGlobalSettings *HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 2959 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0xB8F )
		        sub_1800D2AB0(v3, method);
		      if ( !v3[63]._0.name )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2959, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1098(Patch, (Object *)this, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v3, method);
		  }
		LABEL_5:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		  return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
		}
		
		internal HGRenderPipelineRuntimeResources renderPipelineResources { get => default; } // 0x000000018344DB60-0x000000018344DC60 
		// HGRenderPipelineRuntimeResources get_renderPipelineResources()
		HGRenderPipelineRuntimeResources *HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderPipelineResources(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGRenderPipelineAsset *v3; // rbx
		  int *static_fields; // rdx
		  HGRenderPipelineGlobalSettings *instance; // rax
		  __int64 v7; // r8
		  int32_t v8; // ecx
		  ILFixDynamicMethodWrapper_2 *v9; // rax
		  __int64 v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_18;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 2960 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (int *)v2->static_fields;
		    v7 = *(_QWORD *)static_fields;
		    if ( !*(_QWORD *)static_fields )
		      goto LABEL_18;
		    if ( *(_DWORD *)(v7 + 24) <= 0xB90u )
		      goto LABEL_40;
		    if ( *(_QWORD *)(v7 + 23712) )
		    {
		      v8 = 2960;
		      goto LABEL_25;
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGRenderPipelineAsset *)v2->static_fields;
		  static_fields = (int *)this->klass;
		  if ( !this->klass )
		    goto LABEL_18;
		  if ( static_fields[6] <= 2959 )
		    goto LABEL_43;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v10 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_18;
		  if ( *(_DWORD *)(v10 + 24) <= 0xB8Fu )
		    goto LABEL_40;
		  if ( *(_QWORD *)(v10 + 23704) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2959, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    instance = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1098(Patch, (Object *)v3, 0LL);
		  }
		  else
		  {
		LABEL_43:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		    instance = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
		  }
		  v3 = (HGRenderPipelineAsset *)instance;
		  if ( !instance )
		    goto LABEL_18;
		  this = (HGRenderPipelineAsset *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    this = (HGRenderPipelineAsset *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)this->fields.m_ObsoleteDefaultVolumeProfile->klass;
		  if ( !static_fields )
		    goto LABEL_18;
		  if ( static_fields[6] <= 417 )
		    return (HGRenderPipelineRuntimeResources *)v3->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
		  if ( !LODWORD(this->fields.m_ObsoleteBakedOrCustomReflectionFrameSettingsMovedToDefaultSettings.bitDatas.data1) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (HGRenderPipelineAsset *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGRenderPipelineAsset *)this->fields.m_ObsoleteDefaultVolumeProfile->klass;
		  if ( !this )
		LABEL_18:
		    sub_1800D8260(this, static_fields);
		  if ( *(_DWORD *)&this->fields.isInOnValidateCall <= 0x1A1u )
		LABEL_40:
		    sub_1800D2AB0(this, static_fields);
		  if ( !this[10].fields.m_ObsoleteBakedOrCustomReflectionFrameSettings )
		    return (HGRenderPipelineRuntimeResources *)v3->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
		  v8 = 417;
		LABEL_25:
		  v9 = IFix::WrappersManagerImpl::GetPatch(v8, 0LL);
		  if ( !v9 )
		    goto LABEL_18;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_202(v9, (Object *)v3, 0LL);
		}
		
		public RenderPipelineSettings currentPlatformRenderPipelineSettings { get => default; } // 0x000000018344DAB0-0x000000018344DB60 
		// RenderPipelineSettings get_currentPlatformRenderPipelineSettings()
		RenderPipelineSettings *HG::Rendering::Runtime::HGRenderPipelineAsset::get_currentPlatformRenderPipelineSettings(
		        RenderPipelineSettings *__return_ptr retstr,
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderPipelineSettings *v15; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  RenderPipelineSettings v21; // [rsp+20h] [rbp-78h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 459 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x1CB )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[9].vtable.Equals.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(459, 0LL);
		      if ( Patch )
		      {
		        v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(&v21, Patch, (Object *)this, 0LL);
		        v16 = *(_OWORD *)&v15->dynamicResolutionSettings.DLSSSharpness;
		        *(_OWORD *)&retstr->colorBufferFormat = *(_OWORD *)&v15->colorBufferFormat;
		        v17 = *(_OWORD *)&v15->dynamicResolutionSettings.forcedPercentage;
		        *(_OWORD *)&retstr->dynamicResolutionSettings.DLSSSharpness = v16;
		        v18 = *(_OWORD *)&v15->m_ObsoleteLightLayerName0;
		        *(_OWORD *)&retstr->dynamicResolutionSettings.forcedPercentage = v17;
		        v19 = *(_OWORD *)&v15->m_ObsoleteLightLayerName2;
		        *(_OWORD *)&retstr->m_ObsoleteLightLayerName0 = v18;
		        v20 = *(_OWORD *)&v15->m_ObsoleteLightLayerName4;
		        *(_OWORD *)&retstr->m_ObsoleteLightLayerName2 = v19;
		        v12 = *(_OWORD *)&v15->m_ObsoleteLightLayerName6;
		        *(_OWORD *)&retstr->m_ObsoleteLightLayerName4 = v20;
		        goto LABEL_6;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  v7 = *(_OWORD *)&this->fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness;
		  *(_OWORD *)&retstr->colorBufferFormat = *(_OWORD *)&this->fields.m_RenderPipelineSettings.colorBufferFormat;
		  v8 = *(_OWORD *)&this->fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage;
		  *(_OWORD *)&retstr->dynamicResolutionSettings.DLSSSharpness = v7;
		  v9 = *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0;
		  *(_OWORD *)&retstr->dynamicResolutionSettings.forcedPercentage = v8;
		  v10 = *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName0 = v9;
		  v11 = *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName2 = v10;
		  v12 = *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6;
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName4 = v11;
		LABEL_6:
		  *(_OWORD *)&retstr->m_ObsoleteLightLayerName6 = v12;
		  return retstr;
		}
		
		public override string[] renderingLayerMaskNames { get => default; } // 0x0000000189B888A4-0x0000000189B88904 
		// String[] get_renderingLayerMaskNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderingLayerMaskNames(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *globalSettings; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2961, 0LL) )
		  {
		    globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
		    if ( globalSettings )
		      return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerMaskNames(globalSettings, 0LL);
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2961, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		}
		
		public override string[] prefixedRenderingLayerMaskNames { get => default; } // 0x0000000189B88844-0x0000000189B888A4 
		// String[] get_prefixedRenderingLayerMaskNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineAsset::get_prefixedRenderingLayerMaskNames(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *globalSettings; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2965, 0LL) )
		  {
		    globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
		    if ( globalSettings )
		      return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerMaskNames(
		               globalSettings,
		               0LL);
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2965, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		}
		
		public string[] lightLayerNames { get => default; } // 0x0000000189B887E4-0x0000000189B88844 
		// String[] get_lightLayerNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineAsset::get_lightLayerNames(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *globalSettings; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2968, 0LL) )
		  {
		    globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
		    if ( globalSettings )
		      return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_lightLayerNames(globalSettings, 0LL);
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2968, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		}
		
		public override Shader defaultShader { get => default; } // 0x0000000189B886EC-0x0000000189B88768 
		// Shader get_defaultShader()
		Shader *HG::Rendering::Runtime::HGRenderPipelineAsset::get_defaultShader(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *globalSettings; // rax
		  HGRenderPipelineRuntimeResources *renderPipelineResources; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2970, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2970, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1100(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
		    if ( globalSettings )
		    {
		      renderPipelineResources = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderPipelineResources(
		                                  globalSettings,
		                                  0LL);
		      if ( renderPipelineResources )
		      {
		        shaders = renderPipelineResources->fields.shaders;
		        if ( shaders )
		          return shaders->fields.defaultPS;
		LABEL_8:
		        sub_1800D8260(v6, v5);
		      }
		    }
		    return 0LL;
		  }
		}
		
		public Shader defaultUnlitShader { get => default; } // 0x0000000189B88768-0x0000000189B887E4 
		// Shader get_defaultUnlitShader()
		Shader *HG::Rendering::Runtime::HGRenderPipelineAsset::get_defaultUnlitShader(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *globalSettings; // rax
		  HGRenderPipelineRuntimeResources *renderPipelineResources; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2971, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2971, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1100(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
		    if ( globalSettings )
		    {
		      renderPipelineResources = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderPipelineResources(
		                                  globalSettings,
		                                  0LL);
		      if ( renderPipelineResources )
		      {
		        shaders = renderPipelineResources->fields.shaders;
		        if ( shaders )
		          return shaders->fields.defaultUnlitPS;
		LABEL_8:
		        sub_1800D8260(v6, v5);
		      }
		    }
		    return 0LL;
		  }
		}
		
		public Shader singleColorShader { get => default; } // 0x0000000189B88904-0x0000000189B88984 
		// Shader get_singleColorShader()
		Shader *HG::Rendering::Runtime::HGRenderPipelineAsset::get_singleColorShader(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *globalSettings; // rax
		  HGRenderPipelineRuntimeResources *renderPipelineResources; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2972, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2972, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1100(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    globalSettings = HG::Rendering::Runtime::HGRenderPipelineAsset::get_globalSettings(this, 0LL);
		    if ( globalSettings )
		    {
		      renderPipelineResources = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderPipelineResources(
		                                  globalSettings,
		                                  0LL);
		      if ( renderPipelineResources )
		      {
		        shaders = renderPipelineResources->fields.shaders;
		        if ( shaders )
		          return shaders->fields.singleColorPS;
		LABEL_8:
		        sub_1800D8260(v6, v5);
		      }
		    }
		    return 0LL;
		  }
		}
		
		internal bool useRenderGraph { get => default; set {} } // 0x0000000189B88984-0x0000000189B889D4 0x0000000189B88A20-0x0000000189B88A7C
		// Boolean get_useRenderGraph()
		bool HG::Rendering::Runtime::HGRenderPipelineAsset::get_useRenderGraph(HGRenderPipelineAsset *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2973, 0LL) )
		    return this->fields.m_UseRenderGraph;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2973, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_useRenderGraph(Boolean)
		void HG::Rendering::Runtime::HGRenderPipelineAsset::set_useRenderGraph(
		        HGRenderPipelineAsset *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2974, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2974, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_UseRenderGraph = value;
		  }
		}
		
		public bool virtualTexturingEnabled { get => default; } // 0x0000000189B889D4-0x0000000189B88A20 
		// Boolean get_virtualTexturingEnabled()
		bool HG::Rendering::Runtime::HGRenderPipelineAsset::get_virtualTexturingEnabled(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2975, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2975, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineAsset.Version>.version { get => default; set {} } // 0x0000000184D51E20-0x0000000184D51E50 0x0000000189B885A8-0x0000000189B88604
		// HGRenderPipelineAsset+Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineAsset.Version>.get_version()
		HGRenderPipelineAsset_Version__Enum HG::Rendering::Runtime::HGRenderPipelineAsset::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGRenderPipelineAsset_Version__get_version(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2976, 0LL) )
		    return this->fields.m_Version;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2976, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineAsset.Version>.set_version(HGRenderPipelineAsset+Version)
		void HG::Rendering::Runtime::HGRenderPipelineAsset::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGRenderPipelineAsset_Version__set_version(
		        HGRenderPipelineAsset *this,
		        HGRenderPipelineAsset_Version__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2977, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2977, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_Version = value;
		  }
		}
		
	
		// Nested types
		private enum Version // TypeDefIndex: 38144
		{
			None = 0,
			First = 1,
			UpgradeFrameSettingsToStruct = 2,
			AddAfterPostProcessFrameSetting = 3,
			AddFrameSettingSpecularLighting = 5,
			AddReflectionSettings = 6,
			AddPostProcessFrameSettings = 7,
			AddRayTracingFrameSettings = 8,
			AddFrameSettingDirectSpecularLighting = 9,
			AddCustomPostprocessAndCustomPass = 10,
			ScalableSettingsRefactor = 11,
			ShadowFilteringVeryHighQualityRemoval = 12,
			SeparateColorGradingAndTonemappingFrameSettings = 13,
			ReplaceTextureArraysByAtlasForCookieAndPlanar = 14,
			AddedAdaptiveSSS = 15,
			RemoveCookieCubeAtlasToOctahedral2D = 16,
			RoughDistortion = 17,
			VirtualTexturing = 18,
			AddedHGRenderPipelineGlobalSettings = 19,
			DecalSurfaceGradient = 20,
			RemovalOfUpscaleFilter = 21
		}
	
		// Constructors
		private HGRenderPipelineAsset() {} // 0x00000001846717A0-0x0000000184671850
		// HGRenderPipelineAsset()
		void HG::Rendering::Runtime::HGRenderPipelineAsset::HGRenderPipelineAsset(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  RenderPipelineSettings *v3; // rax
		  __int128 v4; // xmm1
		  __int128 v5; // xmm2
		  __int128 v6; // xmm3
		  __int128 v7; // xmm4
		  __int128 v8; // xmm5
		  __int128 v9; // xmm6
		  HGRenderPathBase_HGRenderPathResources *v10; // rdx
		  PassConstructorID__Enum__Array *v11; // r8
		  Int32__Array **v12; // r9
		  RenderPipelineSettings v13; // [rsp+20h] [rbp-88h] BYREF
		
		  v3 = HG::Rendering::Runtime::RenderPipelineSettings::NewDefault(&v13, 0LL);
		  v4 = *(_OWORD *)&v3->dynamicResolutionSettings.DLSSSharpness;
		  v5 = *(_OWORD *)&v3->dynamicResolutionSettings.forcedPercentage;
		  v6 = *(_OWORD *)&v3->m_ObsoleteLightLayerName0;
		  v7 = *(_OWORD *)&v3->m_ObsoleteLightLayerName2;
		  v8 = *(_OWORD *)&v3->m_ObsoleteLightLayerName4;
		  v9 = *(_OWORD *)&v3->m_ObsoleteLightLayerName6;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.colorBufferFormat = *(_OWORD *)&v3->colorBufferFormat;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness = v4;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage = v5;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0 = v6;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2 = v7;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4 = v8;
		  *(_OWORD *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6 = v9;
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0,
		    v10,
		    v11,
		    v12,
		    *(MethodInfo **)&v13.colorBufferFormat,
		    *(MethodInfo **)&v13.dynamicResolutionSettings.DLSSPerfQualitySetting);
		  *(_WORD *)&this->fields.allowShaderVariantStripping = 257;
		  *(_WORD *)&this->fields.enableSrpDirectCall = 257;
		  this->fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineAsset::Version>);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
		static HGRenderPipelineAsset() {} // 0x0000000184667800-0x0000000184667ED0
		// HGRenderPipelineAsset()
		void HG::Rendering::Runtime::HGRenderPipelineAsset::cctor(MethodInfo *method)
		{
		  __int64 v1; // rbx
		  struct HGRenderPipelineAsset_c__Class *v2; // rax
		  Object *v3; // rsi
		  Action_1_Object_ *v4; // rax
		  HGRenderPathBase_HGRenderPathResources *v5; // rdx
		  __int64 v6; // rcx
		  Action_1_Object_ *v7; // rdi
		  HGRenderPathBase_HGRenderPathResources *v8; // rdx
		  PassConstructorID__Enum__Array *v9; // r8
		  Int32__Array **v10; // r9
		  PassConstructorID__Enum__Array *v11; // r8
		  Int32__Array **v12; // r9
		  Object *v13; // rsi
		  Action_1_Object_ *v14; // rax
		  Action_1_Object_ *v15; // rdi
		  HGRenderPathBase_HGRenderPathResources *v16; // rdx
		  PassConstructorID__Enum__Array *v17; // r8
		  Int32__Array **v18; // r9
		  PassConstructorID__Enum__Array *v19; // r8
		  Int32__Array **v20; // r9
		  Object *v21; // rsi
		  Action_1_Object_ *v22; // rax
		  Action_1_Object_ *v23; // rdi
		  HGRenderPathBase_HGRenderPathResources *v24; // rdx
		  PassConstructorID__Enum__Array *v25; // r8
		  Int32__Array **v26; // r9
		  PassConstructorID__Enum__Array *v27; // r8
		  Int32__Array **v28; // r9
		  Object *v29; // rsi
		  Action_1_Object_ *v30; // rax
		  Action_1_Object_ *v31; // rdi
		  HGRenderPathBase_HGRenderPathResources *v32; // rdx
		  PassConstructorID__Enum__Array *v33; // r8
		  Int32__Array **v34; // r9
		  PassConstructorID__Enum__Array *v35; // r8
		  Int32__Array **v36; // r9
		  Object *v37; // rsi
		  Action_1_Object_ *v38; // rax
		  Action_1_Object_ *v39; // rdi
		  HGRenderPathBase_HGRenderPathResources *v40; // rdx
		  PassConstructorID__Enum__Array *v41; // r8
		  Int32__Array **v42; // r9
		  PassConstructorID__Enum__Array *v43; // r8
		  Int32__Array **v44; // r9
		  Object *v45; // rsi
		  Action_1_Object_ *v46; // rax
		  Action_1_Object_ *v47; // rdi
		  HGRenderPathBase_HGRenderPathResources *v48; // rdx
		  PassConstructorID__Enum__Array *v49; // r8
		  Int32__Array **v50; // r9
		  PassConstructorID__Enum__Array *v51; // r8
		  Int32__Array **v52; // r9
		  Object *v53; // rsi
		  Action_1_Object_ *v54; // rax
		  Action_1_Object_ *v55; // rdi
		  HGRenderPathBase_HGRenderPathResources *v56; // rdx
		  PassConstructorID__Enum__Array *v57; // r8
		  Int32__Array **v58; // r9
		  PassConstructorID__Enum__Array *v59; // r8
		  Int32__Array **v60; // r9
		  Object *v61; // rsi
		  Action_1_Object_ *v62; // rax
		  Action_1_Object_ *v63; // rdi
		  HGRenderPathBase_HGRenderPathResources *v64; // rdx
		  PassConstructorID__Enum__Array *v65; // r8
		  Int32__Array **v66; // r9
		  PassConstructorID__Enum__Array *v67; // r8
		  Int32__Array **v68; // r9
		  Object *v69; // rsi
		  Action_1_Object_ *v70; // rax
		  Action_1_Object_ *v71; // rdi
		  HGRenderPathBase_HGRenderPathResources *v72; // rdx
		  PassConstructorID__Enum__Array *v73; // r8
		  Int32__Array **v74; // r9
		  PassConstructorID__Enum__Array *v75; // r8
		  Int32__Array **v76; // r9
		  Object *v77; // rsi
		  Action_1_Object_ *v78; // rax
		  Action_1_Object_ *v79; // rdi
		  HGRenderPathBase_HGRenderPathResources *v80; // rdx
		  PassConstructorID__Enum__Array *v81; // r8
		  Int32__Array **v82; // r9
		  PassConstructorID__Enum__Array *v83; // r8
		  Int32__Array **v84; // r9
		  Object *v85; // rsi
		  Action_1_Object_ *v86; // rax
		  Action_1_Object_ *v87; // rdi
		  HGRenderPathBase_HGRenderPathResources *v88; // rdx
		  PassConstructorID__Enum__Array *v89; // r8
		  Int32__Array **v90; // r9
		  PassConstructorID__Enum__Array *v91; // r8
		  Int32__Array **v92; // r9
		  Object *v93; // rsi
		  Action_1_Object_ *v94; // rax
		  Action_1_Object_ *v95; // rdi
		  HGRenderPathBase_HGRenderPathResources *v96; // rdx
		  PassConstructorID__Enum__Array *v97; // r8
		  Int32__Array **v98; // r9
		  PassConstructorID__Enum__Array *v99; // r8
		  Int32__Array **v100; // r9
		  MigrationDescription_2_System_Int32Enum_System_Object_ v101; // rax
		  HGRenderPathBase_HGRenderPathResources *static_fields; // rdx
		  PassConstructorID__Enum__Array *v103; // r8
		  Int32__Array **v104; // r9
		  __int128 v105; // [rsp+20h] [rbp-10h] BYREF
		  MethodInfo *v106; // [rsp+60h] [rbp+30h]
		  MethodInfo *v107; // [rsp+68h] [rbp+38h]
		
		  v1 = il2cpp_array_new_specific_1(
		         TypeInfo::HG::Rendering::Runtime::MigrationStep<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>,
		         12LL);
		  v2 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c;
		  }
		  v3 = (Object *)v2->static_fields->__9;
		  v4 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v7 = v4;
		  if ( !v4 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v4,
		    v3,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_0,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 2LL;
		  *(_QWORD *)&v105 = v7;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v8,
		    v9,
		    v10);
		  if ( !v1 )
		    goto LABEL_4;
		  if ( !*(_DWORD *)(v1 + 24) )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 32) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 32), v5, v11, v12, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v13 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v14 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v15 = v14;
		  if ( !v14 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v14,
		    v13,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_1,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 3LL;
		  *(_QWORD *)&v105 = v15;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v16,
		    v17,
		    v18);
		  if ( *(_DWORD *)(v1 + 24) <= 1u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 48) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 48), v5, v19, v20, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v21 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v22 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v23 = v22;
		  if ( !v22 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v22,
		    v21,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_2,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 6LL;
		  *(_QWORD *)&v105 = v23;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v24,
		    v25,
		    v26);
		  if ( *(_DWORD *)(v1 + 24) <= 2u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 64) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 64), v5, v27, v28, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v29 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v30 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v31 = v30;
		  if ( !v30 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v30,
		    v29,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_3,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 7LL;
		  *(_QWORD *)&v105 = v31;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v32,
		    v33,
		    v34);
		  if ( *(_DWORD *)(v1 + 24) <= 3u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 80) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 80), v5, v35, v36, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v37 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v38 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v39 = v38;
		  if ( !v38 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v38,
		    v37,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_4,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 9LL;
		  *(_QWORD *)&v105 = v39;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v40,
		    v41,
		    v42);
		  if ( *(_DWORD *)(v1 + 24) <= 4u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 96) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 96), v5, v43, v44, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v45 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v46 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v47 = v46;
		  if ( !v46 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v46,
		    v45,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_5,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 10LL;
		  *(_QWORD *)&v105 = v47;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v48,
		    v49,
		    v50);
		  if ( *(_DWORD *)(v1 + 24) <= 5u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 112) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 112), v5, v51, v52, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v53 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v54 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v55 = v54;
		  if ( !v54 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v54,
		    v53,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_6,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 13LL;
		  *(_QWORD *)&v105 = v55;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v56,
		    v57,
		    v58);
		  if ( *(_DWORD *)(v1 + 24) <= 6u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 128) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 128), v5, v59, v60, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v61 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v62 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v63 = v62;
		  if ( !v62 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v62,
		    v61,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_7,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 15LL;
		  *(_QWORD *)&v105 = v63;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v64,
		    v65,
		    v66);
		  if ( *(_DWORD *)(v1 + 24) <= 7u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 144) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 144), v5, v67, v68, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v69 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v70 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v71 = v70;
		  if ( !v70 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v70,
		    v69,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_8,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 17LL;
		  *(_QWORD *)&v105 = v71;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v72,
		    v73,
		    v74);
		  if ( *(_DWORD *)(v1 + 24) <= 8u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 160) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 160), v5, v75, v76, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v77 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v78 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v79 = v78;
		  if ( !v78 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v78,
		    v77,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_9,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 18LL;
		  *(_QWORD *)&v105 = v79;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v80,
		    v81,
		    v82);
		  if ( *(_DWORD *)(v1 + 24) <= 9u )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 176) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 176), v5, v83, v84, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v85 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v86 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v87 = v86;
		  if ( !v86 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v86,
		    v85,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_10,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 19LL;
		  *(_QWORD *)&v105 = v87;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v88,
		    v89,
		    v90);
		  if ( *(_DWORD *)(v1 + 24) <= 0xAu )
		LABEL_54:
		    sub_1800D2AB0(v6, v5);
		  *(_OWORD *)(v1 + 192) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 192), v5, v91, v92, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v93 = (Object *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c->static_fields->__9;
		  v94 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  v95 = v94;
		  if ( !v94 )
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  System::Action<System::Object>::Action(
		    v94,
		    v93,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPipelineAsset::__c::__cctor_b__59_11,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>);
		  *((_QWORD *)&v105 + 1) = 21LL;
		  *(_QWORD *)&v105 = v95;
		  ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **))sub_18002D1B0)(
		    (HGRenderPathScene *)&v105,
		    v96,
		    v97,
		    v98);
		  if ( *(_DWORD *)(v1 + 24) <= 0xBu )
		    goto LABEL_54;
		  *(_OWORD *)(v1 + 208) = v105;
		  sub_18002D1B0((HGRenderPathScene *)(v1 + 208), v5, v99, v100, (MethodInfo *)v105, *((MethodInfo **)&v105 + 1));
		  v101.Steps = HG::Rendering::Runtime::MigrationDescription::New<System::Int32Enum,System::Object>(
		                 (MigrationStep_2_System_Int32Enum_System_Object___Array *)v1,
		                 MethodInfo::HG::Rendering::Runtime::MigrationDescription::New<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>).Steps;
		  static_fields = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset->static_fields;
		  static_fields->defaultResources = (HGRenderPipelineRuntimeResources *)v101.Steps;
		  sub_18002D1B0(
		    (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset->static_fields,
		    static_fields,
		    v103,
		    v104,
		    v106,
		    v107);
		}
		
	
		// Methods
		private void Reset() {} // 0x0000000189B8868C-0x0000000189B886E4
		// Void Reset()
		void HG::Rendering::Runtime::HGRenderPipelineAsset::Reset(HGRenderPipelineAsset *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2956, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2956, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_180003290(31LL, this);
		  }
		}
		
		protected override UnityEngine.Rendering.RenderPipeline CreatePipeline() => default; // 0x0000000183945A90-0x0000000183945AF0
		// RenderPipeline CreatePipeline()
		RenderPipeline *HG::Rendering::Runtime::HGRenderPipelineAsset::CreatePipeline(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  HGRenderPipeline *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderPipeline *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2957, 0LL) )
		  {
		    v3 = (HGRenderPipeline *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v6 = (RenderPipeline *)v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::HGRenderPipeline::HGRenderPipeline(v3, this, 0LL);
		      return v6;
		    }
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2957, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1097(Patch, (Object *)this, 0LL);
		}
		
		protected override void OnValidate() {} // 0x0000000189B88604-0x0000000189B8868C
		// Void OnValidate()
		void HG::Rendering::Runtime::HGRenderPipelineAsset::OnValidate(HGRenderPipelineAsset *this, MethodInfo *method)
		{
		  Object_1 *currentRenderPipeline; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2958, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2958, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.isInOnValidateCall = 1;
		    currentRenderPipeline = (Object_1 *)UnityEngine::Rendering::GraphicsSettings::get_currentRenderPipeline(0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(currentRenderPipeline, (Object_1 *)this, 0LL) )
		      UnityEngine::Rendering::RenderPipelineAsset::OnValidate((RenderPipelineAsset *)this, 0LL);
		    this->fields.isInOnValidateCall = 0;
		  }
		}
		
		private bool Migrate() => default; // 0x0000000184B51320-0x0000000184B51390
		// Boolean Migrate()
		bool HG::Rendering::Runtime::HGRenderPipelineAsset::Migrate(HGRenderPipelineAsset *this, MethodInfo *method)
		{
		  struct HGRenderPipelineAsset__Class *v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  MigrationDescription_2_System_Int32Enum_System_Object_ v8; // [rsp+40h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2978, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2978, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineAsset;
		    }
		    v8.Steps = (MigrationStep_2_System_Int32Enum_System_Object___Array *)v3->static_fields->k_Migration.Steps;
		    return HG::Rendering::Runtime::MigrationDescription<System::Int32Enum,System::Object>::Migrate(
		             &v8,
		             (Object *)this,
		             MethodInfo::HG::Rendering::Runtime::MigrationDescription<HG::Rendering::Runtime::HGRenderPipelineAsset::Version,HG::Rendering::Runtime::HGRenderPipelineAsset>::Migrate);
		  }
		}
		
		private void OnEnable() {} // 0x0000000184B512E0-0x0000000184B51320
		// Void OnEnable()
		void HG::Rendering::Runtime::HGRenderPipelineAsset::OnEnable(HGRenderPipelineAsset *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2979, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2979, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGRenderPipelineAsset::Migrate(this, 0LL);
		  }
		}
		
		public void __iFixBaseProxy_OnValidate() {} // 0x0000000189B886E4-0x0000000189B886EC
		// Void <>iFixBaseProxy_OnValidate()
		void HG::Rendering::Runtime::HGRenderPipelineAsset::__iFixBaseProxy_OnValidate(
		        HGRenderPipelineAsset *this,
		        MethodInfo *method)
		{
		  UnityEngine::Rendering::RenderPipelineAsset::OnValidate((RenderPipelineAsset *)this, 0LL);
		}
		
		public string[] __iFixBaseProxy_get_renderingLayerMaskNames() => default; // 0x00000001811EC580-0x00000001811EC590
		// RuntimePhysicGroupData& NullRef[RuntimePhysicGroupData]()
		RuntimePhysicGroupData *System::Runtime::CompilerServices::Unsafe::NullRef<Beyond::Gameplay::Core::DynamicScene::RuntimePhysicGroupData>(
		        MethodInfo *method)
		{
		  return 0LL;
		}
		
		public string[] __iFixBaseProxy_get_prefixedRenderingLayerMaskNames() => default; // 0x00000001811EC580-0x00000001811EC590
		// RuntimePhysicGroupData& NullRef[RuntimePhysicGroupData]()
		RuntimePhysicGroupData *System::Runtime::CompilerServices::Unsafe::NullRef<Beyond::Gameplay::Core::DynamicScene::RuntimePhysicGroupData>(
		        MethodInfo *method)
		{
		  return 0LL;
		}
		
		public Shader __iFixBaseProxy_get_defaultShader() => default; // 0x00000001811EC580-0x00000001811EC590
		// RuntimePhysicGroupData& NullRef[RuntimePhysicGroupData]()
		RuntimePhysicGroupData *System::Runtime::CompilerServices::Unsafe::NullRef<Beyond::Gameplay::Core::DynamicScene::RuntimePhysicGroupData>(
		        MethodInfo *method)
		{
		  return 0LL;
		}
		
	}
}
