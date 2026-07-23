using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, IVersionable<HG.Rendering.Runtime.HGRenderPipelineGlobalSettings.Version>, IMigratableAsset // TypeDefIndex: 38152
	{
		// Fields
		private static HGRenderPipelineGlobalSettings cachedInstance; // 0x00
		private UnityEngine.Rendering.Volume s_DefaultVolume; // 0x18
		[FormerlySerializedAs("m_VolumeProfileDefault")]
		[SerializeField]
		private VolumeProfile m_DefaultVolumeProfile; // 0x20
		[SerializeField]
		private FrameSettings m_RenderingPathDefaultCameraFrameSettings; // 0x28
		[SerializeField]
		private FrameSettings m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings; // 0x40
		[SerializeField]
		private FrameSettings m_RenderingPathDefaultRealtimeReflectionFrameSettings; // 0x58
		[SerializeField]
		private HGRenderPipelineRuntimeResources m_RenderPipelineResources; // 0x70
		private static readonly string[] k_DefaultLightLayerNames; // 0x08
		public string lightLayerName0; // 0x78
		public string lightLayerName1; // 0x80
		public string lightLayerName2; // 0x88
		public string lightLayerName3; // 0x90
		public string lightLayerName4; // 0x98
		public string lightLayerName5; // 0xA0
		public string lightLayerName6; // 0xA8
		public string lightLayerName7; // 0xB0
		[NonSerialized]
		private string[] m_LightLayerNames; // 0xB8
		[NonSerialized]
		private string[] m_PrefixedLightLayerNames; // 0xC0
		[NonSerialized]
		private string[] m_RenderingLayerNames; // 0xC8
		[NonSerialized]
		private string[] m_PrefixedRenderingLayerNames; // 0xD0
		[SerializeField]
		internal ShaderVariantLogLevel shaderVariantLogLevel; // 0xD8
		[SerializeField]
		internal LensAttenuationMode lensAttenuationMode; // 0xDC
		[SerializeField]
		internal bool rendererListCulling; // 0xE0
		[SerializeField]
		private HGTAAUSettings m_desktopTAAUSettings; // 0xE8
		[SerializeField]
		private HGTAAUSettings m_mobileTAAUSettings; // 0xF0
		private static Version[] skipedStepWhenCreatedFromHGRPAsset; // 0x10
		[SerializeField]
		private Version m_Version; // 0xF8
	
		// Properties
		public static HGRenderPipelineGlobalSettings instance { get => default; } // 0x000000018344DCE0-0x000000018344DE70 
		internal VolumeProfile volumeProfile { get => default; set {} } // 0x0000000183AB3AA0-0x0000000183AB3B00 0x0000000189B8943C-0x0000000189B894A0
		// VolumeProfile get_volumeProfile()
		VolumeProfile *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_volumeProfile(
		        HGRenderPipelineGlobalSettings *this,
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
		  if ( wrapperArray->max_length.size <= 585 )
		    return this->fields.m_DefaultVolumeProfile;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x249 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[12]._1.typeHierarchy )
		    return this->fields.m_DefaultVolumeProfile;
		  Patch = IFix::WrappersManagerImpl::GetPatch(585, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_237(Patch, (Object *)this, 0LL);
		}
		
		internal HGRenderPipelineRuntimeResources renderPipelineResources { get => default; } // 0x0000000183105440-0x00000001831054A0 
		// HGRenderPipelineRuntimeResources get_renderPipelineResources()
		HGRenderPipelineRuntimeResources *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderPipelineResources(
		        HGRenderPipelineGlobalSettings *this,
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
		  if ( wrapperArray->max_length.size <= 417 )
		    return this->fields.m_RenderPipelineResources;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1A1 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[8].vtable.ToString.methodPtr )
		    return this->fields.m_RenderPipelineResources;
		  Patch = IFix::WrappersManagerImpl::GetPatch(417, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_202(Patch, (Object *)this, 0LL);
		}
		
		public string[] lightLayerNames { get => default; } // 0x0000000189B890A8-0x0000000189B89220 
		public string[] prefixedLightLayerNames { get => default; } // 0x0000000189B89270-0x0000000189B892D4 
		// String[] get_prefixedLightLayerNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedLightLayerNames(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2982, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2982, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_PrefixedLightLayerNames )
		      HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateRenderingLayerNames(this, 0LL);
		    return this->fields.m_PrefixedLightLayerNames;
		  }
		}
		
		private string[] renderingLayerNames { get => default; } // 0x0000000189B893D8-0x0000000189B8943C 
		// String[] get_renderingLayerNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerNames(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2963, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2963, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_RenderingLayerNames )
		      HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateRenderingLayerNames(this, 0LL);
		    return this->fields.m_RenderingLayerNames;
		  }
		}
		
		private string[] prefixedRenderingLayerNames { get => default; } // 0x0000000189B89324-0x0000000189B89388 
		// String[] get_prefixedRenderingLayerNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerNames(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2967, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2967, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_PrefixedRenderingLayerNames )
		      HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateRenderingLayerNames(this, 0LL);
		    return this->fields.m_PrefixedRenderingLayerNames;
		  }
		}
		
		public string[] renderingLayerMaskNames { get => default; } // 0x0000000189B89388-0x0000000189B893D8 
		// String[] get_renderingLayerMaskNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerMaskNames(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2962, 0LL) )
		    return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerNames(this, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2962, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		}
		
		public string[] prefixedRenderingLayerMaskNames { get => default; } // 0x0000000189B892D4-0x0000000189B89324 
		// String[] get_prefixedRenderingLayerMaskNames()
		String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerMaskNames(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2966, 0LL) )
		    return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerNames(this, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2966, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, (Object *)this, 0LL);
		}
		
		internal HGTAAUSettings desktopTAAUSettings { get => default; } // 0x0000000189B89058-0x0000000189B890A8 
		// HGTAAUSettings get_desktopTAAUSettings()
		HGTAAUSettings *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_desktopTAAUSettings(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2984, 0LL) )
		    return this->fields.m_desktopTAAUSettings;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2984, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1103(Patch, (Object *)this, 0LL);
		}
		
		internal HGTAAUSettings mobileTAAUSettings { get => default; } // 0x0000000189B89220-0x0000000189B89270 
		// HGTAAUSettings get_mobileTAAUSettings()
		HGTAAUSettings *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_mobileTAAUSettings(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2985, 0LL) )
		    return this->fields.m_mobileTAAUSettings;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2985, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1103(Patch, (Object *)this, 0LL);
		}
		
		Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineGlobalSettings.Version>.version { get => default; set {} } // 0x0000000189B88A7C-0x0000000189B88ACC 0x0000000189B88ACC-0x0000000189B88B28
		// HGRenderPipelineGlobalSettings+Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineGlobalSettings.Version>.get_version()
		HGRenderPipelineGlobalSettings_Version__Enum HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGRenderPipelineGlobalSettings_Version__get_version(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2986, 0LL) )
		    return this->fields.m_Version;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2986, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		

		// Void HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineGlobalSettings.Version>.set_version(HGRenderPipelineGlobalSettings+Version)
		void HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGRenderPipelineGlobalSettings_Version__set_version(
		        HGRenderPipelineGlobalSettings *this,
		        HGRenderPipelineGlobalSettings_Version__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2987, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2987, 0LL);
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
		private enum Version // TypeDefIndex: 38151
		{
			First = 0,
			UpdateMSAA = 1,
			UpdateLensFlare = 2,
			MovedSupportRuntimeDebugDisplayToGlobalSettings = 3
		}
	
		// Constructors
		public HGRenderPipelineGlobalSettings() {} // 0x00000001837D8B70-0x00000001837D8E10
		// HGRenderPipelineGlobalSettings()
		void HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::HGRenderPipelineGlobalSettings(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  BitArray128 *v3; // rax
		  uint64_t data1; // xmm0_8
		  BitArray128 *v5; // rax
		  uint64_t v6; // xmm0_8
		  BitArray128 *v7; // rax
		  HGRenderPathBase_HGRenderPathResources *v8; // rdx
		  __int64 v9; // rcx
		  PassConstructorID__Enum__Array *v10; // r8
		  Int32__Array **v11; // r9
		  uint64_t v12; // xmm0_8
		  struct HGRenderPipelineGlobalSettings__Class *v13; // rax
		  String__Array *k_DefaultLightLayerNames; // rax
		  PassConstructorID__Enum__Array *v15; // r8
		  Int32__Array **v16; // r9
		  String__Array *v17; // rax
		  PassConstructorID__Enum__Array *v18; // r8
		  Int32__Array **v19; // r9
		  String__Array *v20; // rax
		  PassConstructorID__Enum__Array *v21; // r8
		  Int32__Array **v22; // r9
		  String__Array *v23; // rax
		  PassConstructorID__Enum__Array *v24; // r8
		  Int32__Array **v25; // r9
		  String__Array *v26; // rax
		  PassConstructorID__Enum__Array *v27; // r8
		  Int32__Array **v28; // r9
		  String__Array *v29; // rax
		  PassConstructorID__Enum__Array *v30; // r8
		  Int32__Array **v31; // r9
		  String__Array *v32; // rax
		  PassConstructorID__Enum__Array *v33; // r8
		  Int32__Array **v34; // r9
		  String__Array *v35; // rax
		  HGRenderPathBase_HGRenderPathResources *v36; // rdx
		  PassConstructorID__Enum__Array *v37; // r8
		  Int32__Array **v38; // r9
		  HGRenderPathBase_HGRenderPathResources *v39; // rdx
		  PassConstructorID__Enum__Array *v40; // r8
		  Int32__Array **v41; // r9
		  FrameSettings v42; // [rsp+20h] [rbp-28h] BYREF
		
		  v3 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultCamera(&v42, 0LL);
		  data1 = v3[1].data1;
		  this->fields.m_RenderingPathDefaultCameraFrameSettings.bitDatas = *v3;
		  *(_QWORD *)&this->fields.m_RenderingPathDefaultCameraFrameSettings.materialQuality = data1;
		  v5 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultCustomOrBakeReflectionProbe(&v42, 0LL);
		  v6 = v5[1].data1;
		  this->fields.m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings.bitDatas = *v5;
		  *(_QWORD *)&this->fields.m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings.materialQuality = v6;
		  v7 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultRealtimeReflectionProbe(&v42, 0LL);
		  v12 = v7[1].data1;
		  this->fields.m_RenderingPathDefaultRealtimeReflectionFrameSettings.bitDatas = *v7;
		  *(_QWORD *)&this->fields.m_RenderingPathDefaultRealtimeReflectionFrameSettings.materialQuality = v12;
		  v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		    v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  }
		  k_DefaultLightLayerNames = v13->static_fields->k_DefaultLightLayerNames;
		  if ( !k_DefaultLightLayerNames )
		LABEL_4:
		    sub_1800D8260(v9, v8);
		  if ( !k_DefaultLightLayerNames->max_length.size )
		    goto LABEL_6;
		  this->fields.lightLayerName0 = k_DefaultLightLayerNames->vector[0];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName0,
		    v8,
		    v10,
		    v11,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v16 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v17 )
		    goto LABEL_4;
		  if ( v17->max_length.size <= 1u )
		    goto LABEL_6;
		  this->fields.lightLayerName1 = v17->vector[1];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName1,
		    v8,
		    v15,
		    v16,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v19 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v20 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v20 )
		    goto LABEL_4;
		  if ( v20->max_length.size <= 2u )
		    goto LABEL_6;
		  this->fields.lightLayerName2 = v20->vector[2];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName2,
		    v8,
		    v18,
		    v19,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v22 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v23 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v23 )
		    goto LABEL_4;
		  if ( v23->max_length.size <= 3u )
		    goto LABEL_6;
		  this->fields.lightLayerName3 = v23->vector[3];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName3,
		    v8,
		    v21,
		    v22,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v25 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v26 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v26 )
		    goto LABEL_4;
		  if ( v26->max_length.size <= 4u )
		    goto LABEL_6;
		  this->fields.lightLayerName4 = v26->vector[4];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName4,
		    v8,
		    v24,
		    v25,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v28 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v29 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v29 )
		    goto LABEL_4;
		  if ( v29->max_length.size <= 5u )
		    goto LABEL_6;
		  this->fields.lightLayerName5 = v29->vector[5];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName5,
		    v8,
		    v27,
		    v28,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v31 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v32 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v32 )
		    goto LABEL_4;
		  if ( v32->max_length.size <= 6u )
		    goto LABEL_6;
		  this->fields.lightLayerName6 = v32->vector[6];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName6,
		    v8,
		    v30,
		    v31,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  v34 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		  v35 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields->k_DefaultLightLayerNames;
		  if ( !v35 )
		    goto LABEL_4;
		  if ( v35->max_length.size <= 7u )
		LABEL_6:
		    sub_1800D2AB0(v9, v8);
		  this->fields.lightLayerName7 = v35->vector[7];
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.lightLayerName7,
		    v8,
		    v33,
		    v34,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  this->fields.m_desktopTAAUSettings = HG::Rendering::Runtime::HGTAAUSettings::DefaultTAAUSettings(0LL);
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.m_desktopTAAUSettings,
		    v36,
		    v37,
		    v38,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  this->fields.m_mobileTAAUSettings = HG::Rendering::Runtime::HGTAAUSettings::DefaultTAAUSettings(0LL);
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this->fields.m_mobileTAAUSettings,
		    v39,
		    v40,
		    v41,
		    (MethodInfo *)v42.bitDatas.data1,
		    (MethodInfo *)v42.bitDatas.data2);
		  this->fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::Version>);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
		static HGRenderPipelineGlobalSettings() {} // 0x0000000184A406E0-0x0000000184A40830
	
		// Methods
		public static void UpdateGraphicsSettings(HGRenderPipelineGlobalSettings newSettings) {} // 0x00000001841E4100-0x00000001841E4230
		// Void UpdateGraphicsSettings(HGRenderPipelineGlobalSettings)
		void HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateGraphicsSettings(
		        HGRenderPipelineGlobalSettings *newSettings,
		        MethodInfo *method)
		{
		  struct HGRenderPipelineGlobalSettings__Class *v3; // rax
		  Object_1 *cachedInstance; // rdi
		  struct Object_1__Class *v5; // rcx
		  HGRenderPathBase_HGRenderPathResources *v6; // rdx
		  PassConstructorID__Enum__Array *v7; // r8
		  Int32__Array **v8; // r9
		  struct HGRenderPipelineGlobalSettings__Class *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		  MethodInfo *v14; // [rsp+58h] [rbp+30h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2980, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2980, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)newSettings, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		    }
		    cachedInstance = (Object_1 *)v3->static_fields->cachedInstance;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)newSettings, cachedInstance, 0LL) )
		    {
		      v5 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v5 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v5 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !newSettings )
		        goto LABEL_19;
		      if ( !v5->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v5);
		      if ( newSettings->fields._._._.m_CachedPtr )
		        UnityEngine::Rendering::GraphicsSettings::RegisterRenderPipelineSettings<System::Object>(
		          (RenderPipelineGlobalSettings *)newSettings,
		          MethodInfo::UnityEngine::Rendering::GraphicsSettings::RegisterRenderPipelineSettings<HG::Rendering::Runtime::HGRenderPipeline>);
		      else
		LABEL_19:
		        UnityEngine::Rendering::GraphicsSettings::UnregisterRenderPipelineSettings<System::Object>(MethodInfo::UnityEngine::Rendering::GraphicsSettings::UnregisterRenderPipelineSettings<HG::Rendering::Runtime::HGRenderPipeline>);
		      v9 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		        v9 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
		      }
		      v9->static_fields->cachedInstance = newSettings;
		      sub_18002D1B0(
		        (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->static_fields,
		        v6,
		        v7,
		        v8,
		        v13,
		        v14);
		    }
		  }
		}
		
		internal UnityEngine.Rendering.Volume GetOrCreateDefaultVolume() => default; // 0x0000000183AB3600-0x0000000183AB3AA0
		internal VolumeProfile GetOrCreateDefaultVolumeProfile() => default; // 0x0000000183AB3BF0-0x0000000183AB3C30
		// VolumeProfile GetOrCreateDefaultVolumeProfile()
		VolumeProfile *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetOrCreateDefaultVolumeProfile(
		        HGRenderPipelineGlobalSettings *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(584, 0LL) )
		    return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_volumeProfile(this, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(584, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_237(Patch, (Object *)this, 0LL);
		}
		
		internal ref FrameSettings GetDefaultFrameSettings(FrameSettingsRenderType type) => ref _refReturnTypeForGetDefaultFrameSettings; // 0x000000018344DA40-0x000000018344DAB0
		// FrameSettings& GetDefaultFrameSettings(FrameSettingsRenderType)
		// local variable allocation has failed, the output may be wrong!
		FrameSettings *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings(
		        HGRenderPipelineGlobalSettings *this,
		        FrameSettingsRenderType__Enum type,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int32 v9; // ebx
		  __int64 v10; // rax
		  SystemException *v11; // rbx
		  String *v12; // rax
		  __int64 v13; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 684 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_7:
		    sub_1800D8260(v5, *(_QWORD *)&type);
		  if ( LODWORD(v5->_0.namespaze) <= 0x2AC )
		    sub_1800D2AB0(v5, *(_QWORD *)&type);
		  if ( v5[14]._1.genericContainerHandle )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(684, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_267(Patch, (Object *)this, type, 0LL);
		  }
		LABEL_5:
		  if ( type == FrameSettingsRenderType__Enum_Camera )
		    return &this->fields.m_RenderingPathDefaultCameraFrameSettings;
		  v9 = type - 1;
		  if ( !v9 )
		    return &this->fields.m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings;
		  if ( v9 != 1 )
		  {
		    v10 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		    v11 = (SystemException *)sub_1800368D0(v10);
		    if ( v11 )
		    {
		      v12 = (String *)sub_180035ED0(&off_18E2667C0);
		      System::SystemException::SystemException(v11, v12, 0LL);
		      v11->fields._._HResult = -2147024809;
		      v13 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings);
		      sub_18007E190(v11, v13);
		    }
		    goto LABEL_7;
		  }
		  return &this->fields.m_RenderingPathDefaultRealtimeReflectionFrameSettings;
		}
		
		private ref FrameSettings _refReturnTypeForGetDefaultFrameSettings; // Dummy field
		internal void UpdateRenderingLayerNames() {} // 0x0000000189B88D70-0x0000000189B89058
		internal void ResetRenderingLayerNames(bool lightLayers) {} // 0x0000000189B88B28-0x0000000189B88D70
	}
}
