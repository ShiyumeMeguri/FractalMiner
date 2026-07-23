using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(Camera))]
	public class HGAdditionalCameraData : MonoBehaviour, IFrameSettingsHistoryContainer, IAdditionalData, IVersionable<HG.Rendering.Runtime.HGAdditionalCameraData.Version> // TypeDefIndex: 38091
	{
		// Fields
		[ExcludeCopy]
		private Camera m_Camera; // 0x18
		public ClearColorMode clearColorMode; // 0x20
		[ColorUsage(true, true)]
		public UnityEngine.Color backgroundColorHDR; // 0x24
		public bool clearDepth; // 0x34
		public bool enableAlpha; // 0x35
		[Tooltip("LayerMask HGRP uses for Volume interpolation for this Camera.")]
		public LayerMask volumeLayerMask; // 0x38
		public Transform volumeAnchorOverride; // 0x40
		public AntialiasingMode antialiasing; // 0x48
		public HGRenderPath hgRenderPath; // 0x4C
		[ValueCopy]
		public HGPhysicalCamera physicalParameters; // 0x50
		public FlipYMode flipYMode; // 0x74
		[Tooltip("If the fov value for culling should get override.")]
		public bool overrideCullingFOV; // 0x78
		public float cullingFOVValue; // 0x7C
		[Tooltip("Skips rendering settings to directly render in fullscreen (Useful for video).")]
		public bool fullscreenPassthrough; // 0x80
		[Tooltip("Allows dynamic resolution on buffers linked to this camera.")]
		public bool allowDynamicResolution; // 0x81
		[Tooltip("Allows you to override the default settings for this camera.")]
		public bool customRenderingSettings; // 0x82
		public bool invertFaceCulling; // 0x83
		public LayerMask probeLayerMask; // 0x84
		public bool hasPersistentHistory; // 0x88
		public float materialMipBias; // 0xA0
		internal float probeCustomFixedExposure; // 0xA4
		[ExcludeCopy]
		internal float deExposureMultiplier; // 0xA8
		[FormerlySerializedAs("renderingPathCustomFrameSettings")]
		[SerializeField]
		private FrameSettings m_RenderingPathCustomFrameSettings; // 0xB0
		public FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // 0xC8
		public FrameSettingsRenderType defaultFrameSettings; // 0xD8
		[ExcludeCopy]
		private FrameSettingsHistory m_RenderingPathHistory; // 0xE0
		[ExcludeCopy]
		internal ProfilingSampler profilingSampler; // 0x148
		[ExcludeCopy]
		private bool m_IsDebugRegistered; // 0x150
		[ExcludeCopy]
		private string m_CameraRegisterName; // 0x158
		[ExcludeCopy]
		public NonObliqueProjectionGetter nonObliqueProjectionGetter; // 0x168
		[ExcludeCopy]
		[FormerlySerializedAs("version")]
		[SerializeField]
		private Version m_Version; // 0x170
		private static readonly MigrationDescription<Version, HGAdditionalCameraData> k_Migration; // 0x00
		[ExcludeCopy]
		[FormerlySerializedAs("renderingPath")]
		[Obsolete("For Data Migration")]
		[SerializeField]
		private int m_ObsoleteRenderingPath; // 0x174
		[ExcludeCopy]
		[FormerlySerializedAs("m_FrameSettings")]
		[FormerlySerializedAs("serializedFrameSettings")]
		[SerializeField]
		private ObsoleteFrameSettings m_ObsoleteFrameSettings; // 0x178
	
		// Properties
		public bool hasCustomRender { get => default; } // 0x0000000183CCE9F0-0x0000000183CCEA50 
		// Boolean get_hasCustomRender()
		bool HG::Rendering::Runtime::HGAdditionalCameraData::get_hasCustomRender(
		        HGAdditionalCameraData *this,
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
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 780 )
		    return this->fields.customRender != 0LL;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x30C )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[16]._1.element_size )
		    return this->fields.customRender != 0LL;
		  Patch = IFix::WrappersManagerImpl::GetPatch(780, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public ref FrameSettings renderingPathCustomFrameSettings { get => default; } // 0x000000018324CAA0-0x000000018324CB00 
		// FrameSettings& get_renderingPathCustomFrameSettings()
		FrameSettings *HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(
		        HGAdditionalCameraData *this,
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
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 695 )
		    return &this->fields.m_RenderingPathCustomFrameSettings;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2B7 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[14].vtable.Finalize.methodPtr )
		    return &this->fields.m_RenderingPathCustomFrameSettings;
		  Patch = IFix::WrappersManagerImpl::GetPatch(695, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_274(Patch, (Object *)this, 0LL);
		}
		
		bool IFrameSettingsHistoryContainer.hasCustomFrameSettings { get => default; } // 0x0000000189B719E8-0x0000000189B71A38 
		// Boolean HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_hasCustomFrameSettings()
		bool HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_hasCustomFrameSettings(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2761, 0LL) )
		    return this->fields.customRenderingSettings;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2761, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		FrameSettingsOverrideMask IFrameSettingsHistoryContainer.frameSettingsMask { get => default; } // 0x0000000189B71904-0x0000000189B7196C 
		// FrameSettingsOverrideMask HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_frameSettingsMask()
		FrameSettingsOverrideMask *HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_frameSettingsMask(
		        FrameSettingsOverrideMask *__return_ptr retstr,
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  FrameSettingsOverrideMask *result; // rax
		  FrameSettingsOverrideMask v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2762, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2762, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    renderingPathCustomFrameSettingsOverrideMask = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1009(
		                                                      &v10,
		                                                      Patch,
		                                                      (Object *)this,
		                                                      0LL);
		  }
		  else
		  {
		    renderingPathCustomFrameSettingsOverrideMask = this->fields.renderingPathCustomFrameSettingsOverrideMask;
		  }
		  result = retstr;
		  *retstr = renderingPathCustomFrameSettingsOverrideMask;
		  return result;
		}
		
		FrameSettings IFrameSettingsHistoryContainer.frameSettings { get => default; } // 0x0000000189B7196C-0x0000000189B719E8 
		// FrameSettings HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_frameSettings()
		FrameSettings *HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_frameSettings(
		        FrameSettings *__return_ptr retstr,
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  BitArray128 bitDatas; // xmm0
		  __int64 v6; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  FrameSettings *v10; // rax
		  FrameSettings *result; // rax
		  FrameSettings v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2763, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2763, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1010(&v12, Patch, (Object *)this, 0LL);
		    bitDatas = v10->bitDatas;
		    v6 = *(_QWORD *)&v10->materialQuality;
		  }
		  else
		  {
		    bitDatas = this->fields.m_RenderingPathCustomFrameSettings.bitDatas;
		    v6 = *(_QWORD *)&this->fields.m_RenderingPathCustomFrameSettings.materialQuality;
		  }
		  retstr->bitDatas = bitDatas;
		  result = retstr;
		  *(_QWORD *)&retstr->materialQuality = v6;
		  return result;
		}
		
		FrameSettingsHistory IFrameSettingsHistoryContainer.frameSettingsHistory { get => default; set {} } // 0x0000000189B71824-0x0000000189B71904 0x0000000189B71A88-0x0000000189B71B7C
		// FrameSettingsHistory HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_frameSettingsHistory()
		FrameSettingsHistory *HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_frameSettingsHistory(
		        FrameSettingsHistory *__return_ptr retstr,
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  FrameSettingsOverrideMask v6; // xmm0
		  BitArray128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int64 v10; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  FrameSettingsHistory *v14; // rax
		  __int128 v15; // xmm1
		  FrameSettingsOverrideMask customMask; // xmm0
		  BitArray128 bitDatas; // xmm1
		  __int128 v18; // xmm0
		  FrameSettingsHistory *result; // rax
		  FrameSettingsHistory v20; // [rsp+20h] [rbp-78h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2764, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2764, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1011(&v20, Patch, (Object *)this, 0LL);
		    v15 = *(_OWORD *)&v14->overridden.bitDatas.data2;
		    *(_OWORD *)&retstr->defaultType = *(_OWORD *)&v14->defaultType;
		    customMask = v14->customMask;
		    *(_OWORD *)&retstr->overridden.bitDatas.data2 = v15;
		    bitDatas = v14->sanitazed.bitDatas;
		    retstr->customMask = customMask;
		    v18 = *(_OWORD *)&v14->sanitazed.materialQuality;
		    retstr->sanitazed.bitDatas = bitDatas;
		    v9 = *(_OWORD *)&v14->debug.bitDatas.data2;
		    *(_OWORD *)&retstr->sanitazed.materialQuality = v18;
		    v10 = *(_QWORD *)&v14->hasDebug;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_RenderingPathHistory.overridden.bitDatas.data2;
		    *(_OWORD *)&retstr->defaultType = *(_OWORD *)&this->fields.m_RenderingPathHistory.defaultType;
		    v6 = this->fields.m_RenderingPathHistory.customMask;
		    *(_OWORD *)&retstr->overridden.bitDatas.data2 = v5;
		    v7 = this->fields.m_RenderingPathHistory.sanitazed.bitDatas;
		    retstr->customMask = v6;
		    v8 = *(_OWORD *)&this->fields.m_RenderingPathHistory.sanitazed.materialQuality;
		    retstr->sanitazed.bitDatas = v7;
		    v9 = *(_OWORD *)&this->fields.m_RenderingPathHistory.debug.bitDatas.data2;
		    *(_OWORD *)&retstr->sanitazed.materialQuality = v8;
		    v10 = *(_QWORD *)&this->fields.m_RenderingPathHistory.hasDebug;
		  }
		  *(_OWORD *)&retstr->debug.bitDatas.data2 = v9;
		  result = retstr;
		  *(_QWORD *)&retstr->hasDebug = v10;
		  return result;
		}
		

		// Void HG.Rendering.Runtime.IFrameSettingsHistoryContainer.set_frameSettingsHistory(FrameSettingsHistory)
		void HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_set_frameSettingsHistory(
		        HGAdditionalCameraData *this,
		        FrameSettingsHistory *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  FrameSettingsOverrideMask v6; // xmm0
		  BitArray128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int128 v13; // xmm1
		  FrameSettingsOverrideMask customMask; // xmm0
		  BitArray128 bitDatas; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  FrameSettingsHistory v18; // [rsp+20h] [rbp-78h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2765, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2765, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v13 = *(_OWORD *)&value->overridden.bitDatas.data2;
		    *(_OWORD *)&v18.defaultType = *(_OWORD *)&value->defaultType;
		    customMask = value->customMask;
		    *(_OWORD *)&v18.overridden.bitDatas.data2 = v13;
		    bitDatas = value->sanitazed.bitDatas;
		    v18.customMask = customMask;
		    v16 = *(_OWORD *)&value->sanitazed.materialQuality;
		    v18.sanitazed.bitDatas = bitDatas;
		    v17 = *(_OWORD *)&value->debug.bitDatas.data2;
		    *(_OWORD *)&v18.sanitazed.materialQuality = v16;
		    *(_QWORD *)&v18.hasDebug = *(_QWORD *)&value->hasDebug;
		    *(_OWORD *)&v18.debug.bitDatas.data2 = v17;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1012(Patch, (Object *)this, &v18, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->overridden.bitDatas.data2;
		    *(_OWORD *)&this->fields.m_RenderingPathHistory.defaultType = *(_OWORD *)&value->defaultType;
		    v6 = value->customMask;
		    *(_OWORD *)&this->fields.m_RenderingPathHistory.overridden.bitDatas.data2 = v5;
		    v7 = value->sanitazed.bitDatas;
		    this->fields.m_RenderingPathHistory.customMask = v6;
		    v8 = *(_OWORD *)&value->sanitazed.materialQuality;
		    this->fields.m_RenderingPathHistory.sanitazed.bitDatas = v7;
		    v9 = *(_OWORD *)&value->debug.bitDatas.data2;
		    *(_OWORD *)&this->fields.m_RenderingPathHistory.sanitazed.materialQuality = v8;
		    *(_QWORD *)&v8 = *(_QWORD *)&value->hasDebug;
		    *(_OWORD *)&this->fields.m_RenderingPathHistory.debug.bitDatas.data2 = v9;
		    *(_QWORD *)&this->fields.m_RenderingPathHistory.hasDebug = v8;
		  }
		}
		
		string IFrameSettingsHistoryContainer.panelName { get => default; } // 0x0000000189B71A38-0x0000000189B71A88 
		// String HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_panelName()
		String *HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_panelName(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2766, 0LL) )
		    return this->fields.m_CameraRegisterName;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2766, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public bool isEditorCameraPreview { get; internal set; } // 0x0000000184D8E6A0-0x0000000184D8E6B0 0x0000000184D90350-0x0000000184D90360
		// Boolean get_isNaviTarget()
		bool UnityEngine::UI::Selectable::get_isNaviTarget(Selectable *this, MethodInfo *method)
		{
		  return this->fields._isNaviTarget_k__BackingField;
		}
		

		// Void set_isNaviTarget(Boolean)
		void UnityEngine::UI::Selectable::set_isNaviTarget(Selectable *this, bool value, MethodInfo *method)
		{
		  this->fields._isNaviTarget_k__BackingField = value;
		}
		
		Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGAdditionalCameraData.Version>.version { get => default; set {} } // 0x0000000184CA2F80-0x0000000184CA2FB0 0x0000000189B71B7C-0x0000000189B71BD8
		// HGAdditionalCameraData+Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGAdditionalCameraData.Version>.get_version()
		HGAdditionalCameraData_Version__Enum HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGAdditionalCameraData_Version__get_version(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2781, 0LL) )
		    return this->fields.m_Version;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2781, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGAdditionalCameraData.Version>.set_version(HGAdditionalCameraData+Version)
		void HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGAdditionalCameraData_Version__set_version(
		        HGAdditionalCameraData *this,
		        HGAdditionalCameraData_Version__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2782, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2782, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_Version = value;
		  }
		}
		
	
		// Events
		public event Action<ScriptableRenderContext, HGCamera> customRender;
		public event RequestAccessDelegate requestGraphicsBuffer;
	
		// Nested types
		public enum FlipYMode // TypeDefIndex: 38080
		{
			Automatic = 0,
			ForceFlipY = 1
		}
	
		[Flags]
		public enum BufferAccessType // TypeDefIndex: 38081
		{
			Depth = 1,
			Normal = 2,
			Color = 4
		}
	
		public struct BufferAccess // TypeDefIndex: 38082
		{
			// Fields
			internal BufferAccessType bufferAccess; // 0x00
	
			// Methods
			internal void Reset() {} // 0x0000000189B714AC-0x0000000189B714F8
			// Void Reset()
			void HG::Rendering::Runtime::HGAdditionalCameraData::BufferAccess::Reset(
			        HGAdditionalCameraData_BufferAccess *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2784, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2784, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1018(Patch, this, 0LL);
			  }
			  else
			  {
			    this->bufferAccess = 0;
			  }
			}
			
			public void RequestAccess(BufferAccessType flags) {} // 0x0000000189B71454-0x0000000189B714AC
			// Void RequestAccess(HGAdditionalCameraData+BufferAccessType)
			void HG::Rendering::Runtime::HGAdditionalCameraData::BufferAccess::RequestAccess(
			        HGAdditionalCameraData_BufferAccess *this,
			        HGAdditionalCameraData_BufferAccessType__Enum flags,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2785, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2785, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1019(Patch, this, flags, 0LL);
			  }
			  else
			  {
			    this->bufferAccess |= flags;
			  }
			}
			
		}
	
		public delegate Matrix4x4 NonObliqueProjectionGetter(Camera camera); // TypeDefIndex: 38083; 0x0000000186222C88-0x0000000186222CCC
	
		public enum ClearColorMode // TypeDefIndex: 38084
		{
			Sky = 0,
			Color = 1,
			None = 2
		}
	
		[Flags]
		public enum AntialiasingMode // TypeDefIndex: 38085
		{
			None = 0,
			FastApproximateAntialiasing = 1,
			TemporalAntialiasing = 2,
			MetalFXSpatial = 4,
			TemporalAntialiasingWithMetalFXSpatial = 6,
			MetalFXTemporal = 8,
			MetalFXTemporalWithMetalFXSpatial = 12,
			PSSR = 16,
			DLSS = 32,
			FSR3 = 64
		}
	
		public enum SMAAQualityLevel // TypeDefIndex: 38086
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		public enum TAAQualityLevel // TypeDefIndex: 38087
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		public delegate void RequestAccessDelegate(ref BufferAccess bufferAccess); // TypeDefIndex: 38088; 0x0000000182B46B90-0x0000000182B46BA0
	
		protected enum Version // TypeDefIndex: 38089
		{
			None = 0,
			First = 1,
			SeparatePassThrough = 2,
			UpgradingFrameSettingsToStruct = 3,
			AddAfterPostProcessFrameSetting = 4,
			AddFrameSettingSpecularLighting = 5,
			AddReflectionSettings = 6,
			AddCustomPostprocessAndCustomPass = 7,
			UpdateMSAA = 8
		}
	
		// Constructors
		public HGAdditionalCameraData() {} // 0x00000001837DA560-0x00000001837DA710
		// HGAdditionalCameraData()
		void HG::Rendering::Runtime::HGAdditionalCameraData::HGAdditionalCameraData(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  Vector3Int *v2; // r8
		  ITilemap *v3; // r9
		  Color v5; // xmm1
		  HGPhysicalCamera *Defaults; // rax
		  __int128 v7; // xmm0
		  float m_Anamorphism; // ecx
		  __int128 v9; // xmm1
		  BitArray128 *v10; // rax
		  HGAdditionalCameraData_NonObliqueProjectionGetter *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGAdditionalCameraData_NonObliqueProjectionGetter *v14; // rdi
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  _BYTE v18[100]; // [rsp+20h] [rbp-A8h] BYREF
		  HGPhysicalCamera v19; // [rsp+90h] [rbp-38h] BYREF
		
		  v5 = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                 (TileAnimationData *)&v19,
		                 (TileBase *)method,
		                 v2,
		                 v3,
		                 *(MethodInfo **)v18);
		  this->fields.clearDepth = 1;
		  this->fields.backgroundColorHDR = v5;
		  this->fields.volumeLayerMask.m_Mask = -1;
		  this->fields.hgRenderPath = 3;
		  Defaults = HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults(&v19, 0LL);
		  v7 = *(_OWORD *)&Defaults->m_Iso;
		  m_Anamorphism = Defaults->m_Anamorphism;
		  v9 = *(_OWORD *)&Defaults->m_BladeCount;
		  this->fields.cullingFOVValue = 50.0;
		  *(_OWORD *)&this->fields.physicalParameters.m_Iso = v7;
		  *(_OWORD *)&this->fields.physicalParameters.m_BladeCount = v9;
		  this->fields.physicalParameters.m_Anamorphism = m_Anamorphism;
		  this->fields.probeLayerMask.m_Mask = -1;
		  this->fields.probeCustomFixedExposure = 1.0;
		  this->fields.deExposureMultiplier = 1.0;
		  v10 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultCamera((FrameSettings *)&v19, 0LL);
		  *(_QWORD *)&v7 = v10[1].data1;
		  this->fields.m_RenderingPathCustomFrameSettings.bitDatas = *v10;
		  memset(v18, 0, sizeof(v18));
		  *(_QWORD *)&this->fields.m_RenderingPathCustomFrameSettings.materialQuality = v7;
		  *(_OWORD *)&this->fields.m_RenderingPathHistory.defaultType = *(_OWORD *)v18;
		  *(_OWORD *)&this->fields.m_RenderingPathHistory.overridden.bitDatas.data2 = *(_OWORD *)&v18[16];
		  this->fields.m_RenderingPathHistory.customMask = *(FrameSettingsOverrideMask *)&v18[32];
		  this->fields.m_RenderingPathHistory.sanitazed.bitDatas = *(BitArray128 *)&v18[48];
		  *(_OWORD *)&this->fields.m_RenderingPathHistory.sanitazed.materialQuality = *(_OWORD *)&v18[64];
		  *(_OWORD *)&this->fields.m_RenderingPathHistory.debug.bitDatas.data2 = *(_OWORD *)&v18[80];
		  *(_QWORD *)&this->fields.m_RenderingPathHistory.hasDebug = 0LL;
		  v11 = (HGAdditionalCameraData_NonObliqueProjectionGetter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::NonObliqueProjectionGetter);
		  v14 = v11;
		  if ( !v11 )
		    sub_1800D8260(v13, v12);
		  HG::Rendering::Runtime::HGAdditionalCameraData::NonObliqueProjectionGetter::NonObliqueProjectionGetter(
		    v11,
		    0LL,
		    MethodInfo::HG::Rendering::Runtime::GeometryUtils::CalculateProjectionMatrix,
		    0LL);
		  this->fields.nonObliqueProjectionGetter = v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.nonObliqueProjectionGetter, v15, v16, v17, *(MethodInfo **)v18);
		  this->fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGAdditionalCameraData::Version>);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
		static HGAdditionalCameraData() {} // 0x00000001847D98A0-0x00000001847D9C50
		// HGAdditionalCameraData()
		void HG::Rendering::Runtime::HGAdditionalCameraData::cctor(MethodInfo *method)
		{
		  __int64 v1; // rbx
		  struct HGAdditionalCameraData_c__Class *v2; // rax
		  Object *v3; // rsi
		  Action_1_Object_ *v4; // rax
		  Type *v5; // rdx
		  __int64 v6; // rcx
		  Action_1_Object_ *v7; // rdi
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  Object *v13; // rsi
		  Action_1_Object_ *v14; // rax
		  Action_1_Object_ *v15; // rdi
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Object *v21; // rsi
		  Action_1_Object_ *v22; // rax
		  Action_1_Object_ *v23; // rdi
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  Object *v29; // rsi
		  Action_1_Object_ *v30; // rax
		  Action_1_Object_ *v31; // rdi
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  Object *v37; // rsi
		  Action_1_Object_ *v38; // rax
		  Action_1_Object_ *v39; // rdi
		  Type *v40; // rdx
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  Object *v45; // rsi
		  Action_1_Object_ *v46; // rax
		  Action_1_Object_ *v47; // rdi
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  PropertyInfo_1 *v51; // r8
		  Int32__Array **v52; // r9
		  MigrationDescription_2_System_Int32Enum_System_Object_ v53; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  __int128 v57; // [rsp+20h] [rbp-10h] BYREF
		  MethodInfo *v58; // [rsp+60h] [rbp+30h]
		
		  v1 = il2cpp_array_new_specific_1(
		         TypeInfo::HG::Rendering::Runtime::MigrationStep<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>,
		         6LL);
		  v2 = TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c;
		  }
		  v3 = (Object *)v2->static_fields->__9;
		  v4 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v7 = v4;
		  if ( !v4 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v4,
		    v3,
		    MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c::__cctor_b__85_0,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>);
		  *((_QWORD *)&v57 + 1) = 2LL;
		  *(_QWORD *)&v57 = v7;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v57,
		    v8,
		    v9,
		    v10);
		  if ( !v1 )
		    goto LABEL_4;
		  if ( !*(_DWORD *)(v1 + 24) )
		    goto LABEL_30;
		  *(_OWORD *)(v1 + 32) = v57;
		  sub_18002D1B0((SingleFieldAccessor *)(v1 + 32), v5, v11, v12, (MethodInfo *)v57);
		  v13 = (Object *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c->static_fields->__9;
		  v14 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v15 = v14;
		  if ( !v14 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v14,
		    v13,
		    MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c::__cctor_b__85_1,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>);
		  *((_QWORD *)&v57 + 1) = 3LL;
		  *(_QWORD *)&v57 = v15;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v57,
		    v16,
		    v17,
		    v18);
		  if ( *(_DWORD *)(v1 + 24) <= 1u )
		    goto LABEL_30;
		  *(_OWORD *)(v1 + 48) = v57;
		  sub_18002D1B0((SingleFieldAccessor *)(v1 + 48), v5, v19, v20, (MethodInfo *)v57);
		  v21 = (Object *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c->static_fields->__9;
		  v22 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v23 = v22;
		  if ( !v22 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v22,
		    v21,
		    MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c::__cctor_b__85_2,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>);
		  *((_QWORD *)&v57 + 1) = 4LL;
		  *(_QWORD *)&v57 = v23;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v57,
		    v24,
		    v25,
		    v26);
		  if ( *(_DWORD *)(v1 + 24) <= 2u )
		    goto LABEL_30;
		  *(_OWORD *)(v1 + 64) = v57;
		  sub_18002D1B0((SingleFieldAccessor *)(v1 + 64), v5, v27, v28, (MethodInfo *)v57);
		  v29 = (Object *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c->static_fields->__9;
		  v30 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v31 = v30;
		  if ( !v30 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v30,
		    v29,
		    MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c::__cctor_b__85_3,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>);
		  *((_QWORD *)&v57 + 1) = 6LL;
		  *(_QWORD *)&v57 = v31;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v57,
		    v32,
		    v33,
		    v34);
		  if ( *(_DWORD *)(v1 + 24) <= 3u )
		    goto LABEL_30;
		  *(_OWORD *)(v1 + 80) = v57;
		  sub_18002D1B0((SingleFieldAccessor *)(v1 + 80), v5, v35, v36, (MethodInfo *)v57);
		  v37 = (Object *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c->static_fields->__9;
		  v38 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v39 = v38;
		  if ( !v38 )
		    goto LABEL_4;
		  System::Action<System::Object>::Action(
		    v38,
		    v37,
		    MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c::__cctor_b__85_4,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>);
		  *((_QWORD *)&v57 + 1) = 7LL;
		  *(_QWORD *)&v57 = v39;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v57,
		    v40,
		    v41,
		    v42);
		  if ( *(_DWORD *)(v1 + 24) <= 4u )
		LABEL_30:
		    sub_1800D2AB0(v6, v5);
		  *(_OWORD *)(v1 + 96) = v57;
		  sub_18002D1B0((SingleFieldAccessor *)(v1 + 96), v5, v43, v44, (MethodInfo *)v57);
		  v45 = (Object *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c->static_fields->__9;
		  v46 = (Action_1_Object_ *)sub_1800368D0(TypeInfo::System::Action<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v47 = v46;
		  if ( !v46 )
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  System::Action<System::Object>::Action(
		    v46,
		    v45,
		    MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::__c::__cctor_b__85_5,
		    0LL);
		  if ( !MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::MigrationStep::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>);
		  *((_QWORD *)&v57 + 1) = 8LL;
		  *(_QWORD *)&v57 = v47;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v57,
		    v48,
		    v49,
		    v50);
		  if ( *(_DWORD *)(v1 + 24) <= 5u )
		    goto LABEL_30;
		  *(_OWORD *)(v1 + 112) = v57;
		  sub_18002D1B0((SingleFieldAccessor *)(v1 + 112), v5, v51, v52, (MethodInfo *)v57);
		  v53.Steps = HG::Rendering::Runtime::MigrationDescription::New<System::Int32Enum,System::Object>(
		                (MigrationStep_2_System_Int32Enum_System_Object___Array *)v1,
		                MethodInfo::HG::Rendering::Runtime::MigrationDescription::New<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>).Steps;
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData->static_fields;
		  static_fields->klass = (Type__Class *)v53.Steps;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData->static_fields,
		    static_fields,
		    v55,
		    v56,
		    v58);
		}
		
	
		// Methods
		Action IDebugData.GetReset() => default; // 0x0000000189B71CC8-0x0000000189B71D44
		// Action UnityEngine.Rendering.IDebugData.GetReset()
		Action *HG::Rendering::Runtime::HGAdditionalCameraData::UnityEngine_Rendering_IDebugData_GetReset(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  Action *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2767, 0LL) )
		  {
		    v3 = (Action *)sub_18002C620(TypeInfo::System::Action);
		    v6 = v3;
		    if ( v3 )
		    {
		      System::Action::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::_UnityEngine_Rendering_IDebugData_GetReset_b__56_0,
		        0LL);
		      return v6;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2767, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1014(Patch, (Object *)this, 0LL);
		}
		
		public void CopyTo(HGAdditionalCameraData data) {} // 0x0000000189B714F8-0x0000000189B71674
		// Void CopyTo(HGAdditionalCameraData)
		void HG::Rendering::Runtime::HGAdditionalCameraData::CopyTo(
		        HGAdditionalCameraData *this,
		        HGAdditionalCameraData *data,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  __int64 v6; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  float m_Anamorphism; // eax
		  FrameSettings *renderingPathCustomFrameSettings; // rbx
		  FrameSettings *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2770, 0LL) )
		  {
		    if ( data )
		    {
		      data->fields.clearColorMode = this->fields.clearColorMode;
		      data->fields.backgroundColorHDR = (Color)_mm_loadu_si128((const __m128i *)&this->fields.backgroundColorHDR);
		      data->fields.clearDepth = this->fields.clearDepth;
		      data->fields.customRenderingSettings = this->fields.customRenderingSettings;
		      data->fields.volumeLayerMask.m_Mask = this->fields.volumeLayerMask.m_Mask;
		      data->fields.volumeAnchorOverride = this->fields.volumeAnchorOverride;
		      sub_18002D1B0((SingleFieldAccessor *)&data->fields.volumeAnchorOverride, v5, v7, v8, v15);
		      v9 = *(_OWORD *)&data->fields.physicalParameters.m_BladeCount;
		      data->fields.antialiasing = this->fields.antialiasing;
		      data->fields.hgRenderPath = this->fields.hgRenderPath;
		      data->fields.flipYMode = this->fields.flipYMode;
		      data->fields.overrideCullingFOV = this->fields.overrideCullingFOV;
		      data->fields.cullingFOVValue = this->fields.cullingFOVValue;
		      v10 = *(_OWORD *)&data->fields.physicalParameters.m_Iso;
		      data->fields.fullscreenPassthrough = this->fields.fullscreenPassthrough;
		      data->fields.allowDynamicResolution = this->fields.allowDynamicResolution;
		      data->fields.invertFaceCulling = this->fields.invertFaceCulling;
		      data->fields.probeLayerMask.m_Mask = this->fields.probeLayerMask.m_Mask;
		      data->fields.hasPersistentHistory = this->fields.hasPersistentHistory;
		      m_Anamorphism = data->fields.physicalParameters.m_Anamorphism;
		      *(_OWORD *)&this->fields.physicalParameters.m_Iso = v10;
		      *(_OWORD *)&this->fields.physicalParameters.m_BladeCount = v9;
		      this->fields.physicalParameters.m_Anamorphism = m_Anamorphism;
		      renderingPathCustomFrameSettings = HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(
		                                           data,
		                                           0LL);
		      v13 = HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(this, 0LL);
		      *(_QWORD *)&v10 = *(_QWORD *)&v13->materialQuality;
		      renderingPathCustomFrameSettings->bitDatas = v13->bitDatas;
		      *(_QWORD *)&renderingPathCustomFrameSettings->materialQuality = v10;
		      data->fields.renderingPathCustomFrameSettingsOverrideMask = this->fields.renderingPathCustomFrameSettingsOverrideMask;
		      data->fields.defaultFrameSettings = this->fields.defaultFrameSettings;
		      data->fields.probeCustomFixedExposure = this->fields.probeCustomFixedExposure;
		      data->fields.materialMipBias = this->fields.materialMipBias;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2770, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public Matrix4x4 GetNonObliqueProjection(Camera camera) => default; // 0x0000000189B71774-0x0000000189B71824
		// Matrix4x4 GetNonObliqueProjection(Camera)
		Matrix4x4 *HG::Rendering::Runtime::HGAdditionalCameraData::GetNonObliqueProjection(
		        Matrix4x4 *__return_ptr retstr,
		        HGAdditionalCameraData *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  __int64 v7; // rcx
		  HGAdditionalCameraData_NonObliqueProjectionGetter *nonObliqueProjectionGetter; // rdx
		  Matrix4x4 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v15; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2771, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2771, 0LL);
		    if ( Patch )
		    {
		      v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_298(&v15, Patch, (Object *)this, (Object *)camera, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, nonObliqueProjectionGetter);
		  }
		  nonObliqueProjectionGetter = this->fields.nonObliqueProjectionGetter;
		  if ( !nonObliqueProjectionGetter )
		    goto LABEL_5;
		  v9 = (Matrix4x4 *)((__int64 (__fastcall *)(Matrix4x4 *, void *, Camera *, void *))nonObliqueProjectionGetter->fields._._.invoke_impl)(
		                      &v15,
		                      nonObliqueProjectionGetter->fields._._.method_code,
		                      camera,
		                      nonObliqueProjectionGetter->fields._._.method);
		LABEL_7:
		  v11 = *(_OWORD *)&v9->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v9->m00;
		  v12 = *(_OWORD *)&v9->m02;
		  *(_OWORD *)&retstr->m01 = v11;
		  v13 = *(_OWORD *)&v9->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v12;
		  *(_OWORD *)&retstr->m03 = v13;
		  return result;
		}
		
		private void RegisterDebug() {} // 0x000000018391BB40-0x000000018391BB90
		// Void RegisterDebug()
		void HG::Rendering::Runtime::HGAdditionalCameraData::RegisterDebug(HGAdditionalCameraData *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2772, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2772, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields.m_IsDebugRegistered )
		  {
		    this->fields.m_CameraRegisterName = UnityEngine::Object::get_name((Object_1 *)this, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CameraRegisterName, v3, v4, v5, v9);
		    this->fields.m_IsDebugRegistered = 1;
		  }
		}
		
		private void UnRegisterDebug() {} // 0x0000000184A35510-0x0000000184A35550
		// Void UnRegisterDebug()
		void HG::Rendering::Runtime::HGAdditionalCameraData::UnRegisterDebug(HGAdditionalCameraData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2773, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2773, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_IsDebugRegistered )
		  {
		    this->fields.m_IsDebugRegistered = 0;
		  }
		}
		
		private void OnEnable() {} // 0x000000018391BAC0-0x000000018391BB40
		// Void OnEnable()
		void HG::Rendering::Runtime::HGAdditionalCameraData::OnEnable(HGAdditionalCameraData *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Camera *m_Camera; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2774, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2774, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( UnityEngine::Component::TryGetComponent<System::Object>(
		              (Component *)this,
		              (Object **)&this->fields.m_Camera,
		              MethodInfo::UnityEngine::Component::TryGetComponent<UnityEngine::Camera>) )
		  {
		    m_Camera = this->fields.m_Camera;
		    if ( m_Camera )
		    {
		      UnityEngine::Camera::set_allowMSAA(m_Camera, 0, 0LL);
		      m_Camera = this->fields.m_Camera;
		      if ( m_Camera )
		      {
		        UnityEngine::Camera::set_allowHDR(m_Camera, 0, 0LL);
		        HG::Rendering::Runtime::HGAdditionalCameraData::RegisterDebug(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(m_Camera, v3);
		  }
		}
		
		private void UpdateDebugCameraName() {} // 0x0000000189B71D44-0x0000000189B71E30
		// Void UpdateDebugCameraName()
		void HG::Rendering::Runtime::HGAdditionalCameraData::UpdateDebugCameraName(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  String *name; // rbx
		  String *v4; // rsi
		  ProfilingSampler *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ProfilingSampler *v8; // rbx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  String *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2775, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2775, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  name = UnityEngine::Object::get_name((Object_1 *)this, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v4 = HG::Rendering::Runtime::HGUtils::ComputeCameraName(name, 0LL);
		  v5 = (ProfilingSampler *)sub_18002C620(TypeInfo::UnityEngine::Rendering::ProfilingSampler);
		  v8 = v5;
		  if ( !v5 )
		    goto LABEL_6;
		  UnityEngine::Rendering::ProfilingSampler::ProfilingSampler(v5, v4, 0LL);
		  this->fields.profilingSampler = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.profilingSampler, v9, v10, v11, v14);
		  v12 = UnityEngine::Object::get_name((Object_1 *)this, 0LL);
		  if ( System::String::op_Inequality(v12, this->fields.m_CameraRegisterName, 0LL) )
		  {
		    HG::Rendering::Runtime::HGAdditionalCameraData::UnRegisterDebug(this, 0LL);
		    HG::Rendering::Runtime::HGAdditionalCameraData::RegisterDebug(this, 0LL);
		  }
		}
		
		private void OnDisable() {} // 0x0000000184A354D0-0x0000000184A35510
		// Void OnDisable()
		void HG::Rendering::Runtime::HGAdditionalCameraData::OnDisable(HGAdditionalCameraData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2777, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2777, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGAdditionalCameraData::UnRegisterDebug(this, 0LL);
		  }
		}
		
		internal static void InitDefaultHGAdditionalCameraData(HGAdditionalCameraData cameraData) {} // 0x0000000189B71BD8-0x0000000189B71C94
		// Void InitDefaultHGAdditionalCameraData(HGAdditionalCameraData)
		void HG::Rendering::Runtime::HGAdditionalCameraData::InitDefaultHGAdditionalCameraData(
		        HGAdditionalCameraData *cameraData,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int32_t v5; // ebx
		  GameObject *gameObject; // rax
		  Object *v7; // rax
		  Camera *v8; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2778, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2778, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)cameraData, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !cameraData )
		    goto LABEL_9;
		  gameObject = UnityEngine::Component::get_gameObject((Component *)cameraData, 0LL);
		  if ( !gameObject )
		    goto LABEL_9;
		  v7 = UnityEngine::GameObject::GetComponent<System::Object>(
		         gameObject,
		         MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Camera>);
		  v8 = (Camera *)v7;
		  if ( !v7 )
		    goto LABEL_9;
		  cameraData->fields.clearDepth = UnityEngine::Camera::get_clearFlags((Camera *)v7, 0LL) != CameraClearFlags__Enum_Nothing;
		  if ( UnityEngine::Camera::get_clearFlags(v8, 0LL) != CameraClearFlags__Enum_Skybox )
		  {
		    LOBYTE(v5) = UnityEngine::Camera::get_clearFlags(v8, 0LL) != CameraClearFlags__Enum_Color;
		    ++v5;
		  }
		  cameraData->fields.clearColorMode = v5;
		}
		
		internal void ExecuteCustomRender(ScriptableRenderContext renderContext, HGCamera hgCamera) {} // 0x0000000189B71674-0x0000000189B716FC
		// Void ExecuteCustomRender(ScriptableRenderContext, HGCamera)
		void HG::Rendering::Runtime::HGAdditionalCameraData::ExecuteCustomRender(
		        HGAdditionalCameraData *this,
		        ScriptableRenderContext renderContext,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2779, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2779, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, renderContext, (Object *)hgCamera, 0LL);
		  }
		  else if ( this->fields.customRender )
		  {
		    sub_1833F5950(this->fields.customRender, renderContext.m_Ptr, hgCamera, 0LL);
		  }
		}
		
		internal BufferAccessType GetBufferAccess() => default; // 0x0000000189B716FC-0x0000000189B71774
		// HGAdditionalCameraData+BufferAccessType GetBufferAccess()
		HGAdditionalCameraData_BufferAccessType__Enum HG::Rendering::Runtime::HGAdditionalCameraData::GetBufferAccess(
		        HGAdditionalCameraData *this,
		        MethodInfo *method)
		{
		  HGAdditionalCameraData_BufferAccessType__Enum v3; // ebx
		  HGAdditionalCameraData_RequestAccessDelegate *requestGraphicsBuffer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  HGAdditionalCameraData_BufferAccessType__Enum v9; // [rsp+40h] [rbp+18h] BYREF
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2780, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2780, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    requestGraphicsBuffer = this->fields.requestGraphicsBuffer;
		    v9 = 0;
		    if ( requestGraphicsBuffer )
		    {
		      ((void (__fastcall *)(void *, HGAdditionalCameraData_BufferAccessType__Enum *, void *))requestGraphicsBuffer->fields._._.invoke_impl)(
		        requestGraphicsBuffer->fields._._.method_code,
		        &v9,
		        requestGraphicsBuffer->fields._._.method);
		      return v9;
		    }
		    return v3;
		  }
		}
		
		private void Awake() {} // 0x00000001849DD580-0x00000001849DD5F0
		// Void Awake()
		void HG::Rendering::Runtime::HGAdditionalCameraData::Awake(HGAdditionalCameraData *this, MethodInfo *method)
		{
		  struct HGAdditionalCameraData__Class *v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  MigrationDescription_2_System_Int32Enum_System_Object_ v7; // [rsp+40h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2783, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2783, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData;
		    }
		    v7.Steps = (MigrationStep_2_System_Int32Enum_System_Object___Array *)v3->static_fields->k_Migration.Steps;
		    HG::Rendering::Runtime::MigrationDescription<System::Int32Enum,System::Object>::Migrate(
		      &v7,
		      (Object *)this,
		      MethodInfo::HG::Rendering::Runtime::MigrationDescription<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>::Migrate);
		  }
		}
		
	}
}
