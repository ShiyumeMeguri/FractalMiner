using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class UIPostProcessConstructor : IPassConstructor // TypeDefIndex: 38467
	{
		// Fields
		private Material m_uiPPMaterial; // 0x10
		private UberPostPassUtils.BloomPSMaterials m_bloomPSMaterials; // 0x18
		private UberPostPassUtils.PPVignetteData m_vignetteData; // 0x38
		private UberPostPassUtils.PPBloomData m_ppBloomData; // 0x40
		private static readonly RenderFunc<UIPPPassData> s_uiUberRenderFunc; // 0x00
		private static readonly RenderFunc<UIDistortionPassData> s_copyUIRTFunc; // 0x08
		private static readonly RenderFunc<UIDistortionPassData> m_uiDistortionRenderFunc; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38462
		{
			// Fields
			internal TextureHandle source; // 0x00
			internal TextureHandle target; // 0x10
			internal CullingResults cullingResults; // 0x20
			internal TAAUQuality taauQuality; // 0x30
			internal HGRenderPathInternal renderPath; // 0x34
			internal GraphicsFormat uiPPFormat; // 0x38
		}
	
		internal struct PassOutput // TypeDefIndex: 38463
		{
		}
	
		private class UIPPPassData // TypeDefIndex: 38464
		{
			// Fields
			public TextureHandle source; // 0x10
			public Material uberPostMaterial; // 0x20
			public UberPostPassUtils.PPVignetteData vignetteData; // 0x28
			public UberPostPassUtils.PPBloomData bloomData; // 0x30
	
			// Constructors
			public UIPPPassData() {} // 0x0000000189BE3824-0x0000000189BE3874
			// UIPostProcessConstructor+UIPPPassData()
			void HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData::UIPPPassData(
			        UIPostProcessConstructor_UIPPPassData *this,
			        MethodInfo *method)
			{
			  UberPostPassUtils_PPVignetteData *v3; // rax
			  HGRuntimeGrassQuery_Node *v4; // rdx
			  __int64 v5; // rcx
			  HGRuntimeGrassQuery_Node *v6; // r8
			  Int32__Array **v7; // r9
			  UberPostPassUtils_PPBloomData *v8; // rax
			  HGRuntimeGrassQuery_Node *v9; // r8
			  Int32__Array **v10; // r9
			  MethodInfo *v11; // [rsp+20h] [rbp-8h]
			  MethodInfo *v12; // [rsp+50h] [rbp+28h]
			
			  v3 = (UberPostPassUtils_PPVignetteData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::PPVignetteData);
			  if ( !v3
			    || (this->fields.vignetteData = v3,
			        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.vignetteData, v4, v6, v7, v11),
			        (v8 = (UberPostPassUtils_PPBloomData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::PPBloomData)) == 0LL) )
			  {
			    sub_1800D8260(v5, v4);
			  }
			  this->fields.bloomData = v8;
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.bloomData, v4, v9, v10, v12);
			}
			
		}
	
		internal class UIDistortionPassData // TypeDefIndex: 38465
		{
			// Fields
			internal HGCamera camera; // 0x10
			internal TextureHandle colorAttachment; // 0x18
			internal TextureHandle colorAttachmentCopy; // 0x28
			internal RendererListHandle uiDistortionRendererListHandle; // 0x38
	
			// Constructors
			public UIDistortionPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		// Constructors
		public UIPostProcessConstructor() {} // Dummy constructor
		internal UIPostProcessConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CAF340-0x0000000184CAF410
		// UIPostProcessConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::UIPostProcessConstructor::UIPostProcessConstructor(
		        UIPostProcessConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  UberPostPassUtils_PPVignetteData *v7; // rax
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  __int64 v9; // rcx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  UberPostPassUtils_PPBloomData *v12; // rax
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		
		  v7 = (UberPostPassUtils_PPVignetteData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::PPVignetteData);
		  if ( !v7
		    || (this->fields.m_vignetteData = v7,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_vignetteData, v8, v10, v11, v19),
		        (v12 = (UberPostPassUtils_PPBloomData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::PPBloomData)) == 0LL)
		    || (this->fields.m_ppBloomData = v12,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_ppBloomData, v8, v13, v14, v20),
		        !resources->defaultResources)
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		    sub_1800D8260(v9, v8);
		  }
		  this->fields.m_uiPPMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                  materialCollector,
		                                  shaders->fields.uberPostPS,
		                                  0,
		                                  0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v16, v17, v18, v21);
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  HG::Rendering::Runtime::UberPostPassUtils::PrepareBloomPSMaterials(
		    materialCollector,
		    &this->fields.m_bloomPSMaterials,
		    resources->defaultResources,
		    0LL);
		}
		
		static UIPostProcessConstructor() {} // 0x0000000184B35270-0x0000000184B353D0
		// UIPostProcessConstructor()
		void HG::Rendering::Runtime::UIPostProcessConstructor::cctor(MethodInfo *method)
		{
		  struct UIPostProcessConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node__Class *v6; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  RenderFunc_1_HG_Rendering_Runtime_UIPostProcessConstructor_UIDistortionPassData_ *v18; // rbx
		  UIPostProcessConstructor__StaticFields *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c::__cctor_b__20_0,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v22);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
		  v12 = (MonitorData *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c::__cctor_b__20_1,
		          0LL),
		        v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields,
		        v13->monitor = v12,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields->s_copyUIRTFunc,
		          v13,
		          v14,
		          v15,
		          v23),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>),
		        (v18 = (RenderFunc_1_HG_Rendering_Runtime_UIPostProcessConstructor_UIDistortionPassData_ *)v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::UIPostProcessConstructor::__c::__cctor_b__20_2,
		    0LL);
		  v19 = TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields;
		  v19->m_uiDistortionRenderFunc = v18;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields->m_uiDistortionRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v19,
		    v20,
		    v21,
		    v24);
		}
		
	
		// Methods
		private void UIUberPass(ref PassInput input, HGSettingParameters settingParameters, HGRenderGraph renderGraph, HGCamera camera, TextureHandle bloomTexture, Vector4 bloomBicubicParams) {} // 0x0000000189BE43E0-0x0000000189BE4E4C
		// Void UIUberPass(UIPostProcessConstructor+PassInput ByRef, HGSettingParameters, HGRenderGraph, HGCamera, TextureHandle, Vector4)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::UIPostProcessConstructor::UIUberPass(
		        UIPostProcessConstructor *this,
		        UIPostProcessConstructor_PassInput *input,
		        HGSettingParameters *settingParameters,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        TextureHandle *bloomTexture,
		        Vector4 *bloomBicubicParams,
		        MethodInfo *method)
		{
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  HGCamera_VolumeComponentsData *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  HGCamera_VolumeComponentsData *v20; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Object *m_bloom; // r14
		  ProfilingSampler *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  signed __int64 v27; // rcx
		  Object *v28; // rdx
		  unsigned int v29; // edx
		  unsigned __int64 v30; // r8
		  signed __int64 v31; // rtt
		  Object__Class *klass; // rcx
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  MonitorData *monitor; // rdi
		  Material *ppMaterial; // rsi
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  Object__Class *v39; // rsi
		  Object *m_uiPPMaterial; // r13
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  double v47; // xmm0_8
		  float v48; // xmm9_4
		  float v49; // xmm10_4
		  MonitorData *v50; // rdi
		  __m128 v51; // xmm6
		  float v52; // xmm3_4
		  Vector4 *one; // rax
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  __m128i v56; // xmm11
		  MonitorData *v57; // rdi
		  Object_1 *v58; // rdi
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  __int64 (*v61)(void); // rax
		  _QWORD *v62; // rdi
		  MonitorData *v63; // rdi
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  int v66; // r15d
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  float v69; // xmm6_4
		  float v70; // xmm7_4
		  Object__Class *v71; // rbx
		  unsigned __int64 v72; // rdx
		  signed __int64 v73; // rcx
		  double v74; // xmm0_8
		  float v75; // xmm8_4
		  unsigned __int64 v76; // r8
		  signed __int64 v77; // rtt
		  Object__Class *v78; // rbx
		  float v79; // xmm0_4
		  __int64 v80; // rdx
		  HGShaderKeyWords__StaticFields *v81; // rcx
		  String *s_BloomDirt; // rbx
		  void (__fastcall *v83)(Object *, String *); // rax
		  HGShaderKeyWords__StaticFields *static_fields; // rcx
		  __int64 v85; // rdx
		  ILFixDynamicMethodWrapper_2 *v86; // rcx
		  Object *v87; // rbx
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  TextureHandle v90; // xmm0
		  Object__Class *v91; // rbx
		  __int64 v92; // rdx
		  __int64 v93; // rcx
		  TextureHandle v94; // xmm0
		  __int64 v95; // rdx
		  __int64 v96; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  bool dirtEnabled; // [rsp+50h] [rbp-138h]
		  Vector4 si128; // [rsp+60h] [rbp-128h] BYREF
		  Object *v100; // [rsp+70h] [rbp-118h] BYREF
		  Vignette *vignette[2]; // [rsp+78h] [rbp-110h] BYREF
		  Vector4 v102; // [rsp+90h] [rbp-F8h] BYREF
		  HGRenderGraphBuilder v103; // [rsp+A0h] [rbp-E8h] BYREF
		  HGVignette *hgVignette[2]; // [rsp+C0h] [rbp-C8h] BYREF
		  HGRenderGraphBuilder v105; // [rsp+D0h] [rbp-B8h] BYREF
		
		  v100 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3440, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3440, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v96, v95);
		    v102 = *bloomBicubicParams;
		    si128 = (Vector4)*bloomTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1241(
		      Patch,
		      (Object *)this,
		      input,
		      (Object *)settingParameters,
		      (Object *)renderGraph,
		      (Object *)camera,
		      (TextureHandle *)&si128,
		      &v102,
		      0LL);
		  }
		  else
		  {
		    if ( !camera )
		      sub_1800D8260(v13, v12);
		    *(BitArray128 *)&v103.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		    v103.m_RenderGraph = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v103,
		           FrameSettingsField__Enum_Postprocess,
		           0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    }
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		    if ( !volumeComponentsData )
		      sub_1800D8260(v16, v15);
		    vignette[0] = volumeComponentsData->fields.m_vignette;
		    v17 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		    if ( !v17 )
		      sub_1800D8260(v19, v18);
		    hgVignette[0] = v17->fields.m_hgVignette;
		    *(BitArray128 *)&v103.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		    v103.m_RenderGraph = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    HG::Rendering::Runtime::FrameSettings::IsEnabled((FrameSettings *)&v103, FrameSettingsField__Enum_Vignette, 0LL);
		    v20 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		    if ( !v20 )
		      sub_1800D8260(v22, v21);
		    m_bloom = (Object *)v20->fields.m_bloom;
		    if ( !camera->fields.camera )
		      sub_1800D8260(v22, v21);
		    UnityEngine::Camera::get_cameraType(camera->fields.camera, 0LL);
		    v24 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xA0u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v26, v25);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v103,
		      renderGraph,
		      (String *)"UI Uber Post",
		      &v100,
		      v24,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
		    v105 = v103;
		    *(_QWORD *)&v102.x = 0LL;
		    *(_QWORD *)&v102.z = &v105;
		    v28 = v100;
		    if ( !v100 )
		      sub_1800D8250(v27, 0LL);
		    v100[2].klass = (Object__Class *)this->fields.m_uiPPMaterial;
		    if ( dword_18F35FD08 )
		    {
		      v29 = ((unsigned __int64)&v28[2] >> 12) & 0x1FFFFF;
		      v30 = (unsigned __int64)v29 >> 6;
		      v28 = (Object *)(v29 & 0x3F);
		      _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
		      do
		      {
		        v27 = qword_18F0BCBA0[v30 + 36190] | (1LL << (char)v28);
		        v31 = qword_18F0BCBA0[v30 + 36190];
		      }
		      while ( v31 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v30 + 36190], v27, v31) );
		    }
		    if ( !v100 )
		      sub_1800D8250(v27, v28);
		    klass = v100[2].klass;
		    if ( !klass )
		      sub_1800D8250(0LL, v28);
		    UnityEngine::Material::SetEnabledKeywords((Material *)klass, 0LL, 0LL);
		    if ( !v100 )
		      sub_1800D8250(v34, v33);
		    monitor = v100[2].monitor;
		    ppMaterial = this->fields.m_uiPPMaterial;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareVignetteParameters(
		      settingParameters,
		      (UberPostPassUtils_PPVignetteData *)monitor,
		      vignette[0],
		      hgVignette[0],
		      ppMaterial,
		      0LL);
		    if ( !v100 )
		      sub_1800D8250(v38, v37);
		    v39 = v100[3].klass;
		    m_uiPPMaterial = (Object *)this->fields.m_uiPPMaterial;
		    *(_OWORD *)hgVignette = 0LL;
		    if ( IFix::WrappersManagerImpl::IsPatched(2895, 0LL) )
		    {
		      v86 = IFix::WrappersManagerImpl::GetPatch(2895, 0LL);
		      if ( !v86 )
		        sub_1800D8250(0LL, v85);
		      si128 = *bloomBicubicParams;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1058(
		        v86,
		        (Object *)settingParameters,
		        (Object *)v39,
		        m_bloom,
		        &si128,
		        (Object *)camera,
		        m_uiPPMaterial,
		        0LL);
		    }
		    else
		    {
		      if ( !m_bloom )
		        sub_1800D8250(v42, v41);
		      if ( HG::Rendering::Runtime::Bloom::IsActive((Bloom *)m_bloom, 0LL) )
		      {
		        if ( !settingParameters )
		          sub_1800D8250(v44, v43);
		        if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		               settingParameters->fields._bloomEnabled_k__BackingField,
		               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		        {
		          HG::Rendering::Runtime::Bloom::get_intensity((Bloom *)m_bloom, 0LL);
		          v47 = sub_1803369A0();
		          v48 = 1.0;
		          v49 = *(float *)&v47 - 1.0;
		          v50 = m_bloom[9].monitor;
		          if ( !v50 )
		            sub_1800D8250(v46, v45);
		          sub_1800049A0(*(_QWORD *)v50);
		          *(_OWORD *)hgVignette = *(_OWORD *)(*(__int64 (__fastcall **)(Vector4 *, MonitorData *, _QWORD))(*(_QWORD *)v50 + 480LL))(
		                                               &si128,
		                                               v50,
		                                               *(_QWORD *)(*(_QWORD *)v50 + 488LL));
		          v51 = (__m128)_mm_loadu_si128((const __m128i *)sub_183C6CBA0(&si128, hgVignette));
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		          v52 = (float)(_mm_shuffle_ps(v51, v51, 170).m128_f32[0] * 0.072175004)
		              + (float)((float)(_mm_shuffle_ps(v51, v51, 85).m128_f32[0] * 0.7151522)
		                      + (float)(v51.m128_f32[0] * 0.2126729));
		          if ( v52 <= 0.0 )
		          {
		            one = UnityEngine::Vector4::get_one(&si128, 0LL);
		          }
		          else
		          {
		            si128 = (Vector4)v51;
		            one = UnityEngine::Vector4::op_Multiply((Vector4 *)vignette, &si128, 1.0 / v52, 0LL);
		          }
		          v56 = _mm_loadu_si128((const __m128i *)one);
		          v57 = m_bloom[12].monitor;
		          if ( !v57 )
		            sub_1800D8250(v55, v54);
		          sub_1800049A0(*(_QWORD *)v57);
		          v58 = (Object_1 *)(*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v57 + 480LL))(
		                              v57,
		                              *(_QWORD *)(*(_QWORD *)v57 + 488LL));
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Equality(v58, 0LL, 0LL) )
		          {
		            v61 = (__int64 (*)(void))qword_18F36F8D8;
		            if ( !qword_18F36F8D8 )
		            {
		              v61 = (__int64 (*)(void))sub_180059EA0("UnityEngine.Texture2D::get_blackTexture()");
		              qword_18F36F8D8 = (__int64)v61;
		            }
		            v62 = (_QWORD *)v61();
		          }
		          else
		          {
		            v63 = m_bloom[12].monitor;
		            if ( !v63 )
		              sub_1800D8250(v60, v59);
		            sub_1800049A0(*(_QWORD *)v63);
		            v62 = (_QWORD *)(*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v63 + 480LL))(
		                              v63,
		                              *(_QWORD *)(*(_QWORD *)v63 + 488LL));
		          }
		          dirtEnabled = HG::Rendering::Runtime::Bloom::get_dirtEnabled((Bloom *)m_bloom, 0LL);
		          if ( !v62 )
		            sub_1800D8250(v65, v64);
		          sub_1800049A0(*v62);
		          v66 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*v62 + 400LL))(v62, *(_QWORD *)(*v62 + 408LL));
		          sub_1800049A0(*v62);
		          v69 = (float)v66
		              / (float)(*(int (__fastcall **)(_QWORD *, _QWORD))(*v62 + 432LL))(v62, *(_QWORD *)(*v62 + 440LL));
		          v70 = (float)camera->fields._taauRTSize_k__BackingField.m_X
		              / (float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		          *(__m128i *)vignette = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		          v71 = m_bloom[13].klass;
		          if ( !v71 )
		            sub_1800D8250(v68, v67);
		          sub_1800049A0(v71->_0.image);
		          v74 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v71->_0.image[6].nameToClassHashTable)(
		                  v71,
		                  v71->_0.image[6].codeGenModule);
		          v75 = *(float *)&v74;
		          if ( v69 > v70 )
		          {
		            *(float *)vignette = v70 / v69;
		            *(float *)&vignette[1] = (float)(1.0 - (float)(v70 / v69)) * 0.5;
		          }
		          else if ( v70 > v69 )
		          {
		            *((float *)vignette + 1) = v69 / v70;
		            *((float *)&vignette[1] + 1) = (float)(1.0 - (float)(v69 / v70)) * 0.5;
		          }
		          if ( !v39 )
		            sub_1800D8250(v73, v72);
		          v39->_0.byval_arg.data.dummy = v62;
		          if ( dword_18F35FD08 )
		          {
		            v76 = (((unsigned __int64)&v39->_0.byval_arg >> 12) & 0x1FFFFF) >> 6;
		            v72 = ((unsigned __int64)&v39->_0.byval_arg >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v76 + 36190]);
		            do
		            {
		              v73 = qword_18F0BCBA0[v76 + 36190] | (1LL << v72);
		              v77 = qword_18F0BCBA0[v76 + 36190];
		            }
		            while ( v77 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v76 + 36190], v73, v77) );
		          }
		          v78 = m_bloom[10].klass;
		          if ( !v78 )
		            sub_1800D8250(v73, v72);
		          sub_1800049A0(v78->_0.image);
		          if ( ((unsigned int (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v78->_0.image[6].nameToClassHashTable)(
		                 v78,
		                 v78->_0.image[6].codeGenModule) )
		          {
		            v79 = 1.0;
		          }
		          else
		          {
		            v79 = 0.0;
		          }
		          if ( !dirtEnabled )
		            v48 = 0.0;
		          si128.x = v49;
		          si128.y = v75 * v49;
		          si128.z = v79;
		          si128.w = v48;
		          *(Vector4 *)((char *)&v39->_0.byval_arg + 8) = si128;
		          si128 = (Vector4)v56;
		          *(__m128i *)((char *)&v39->_0.this_arg + 8) = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                           (Color *)&v103,
		                                                                                           &si128,
		                                                                                           0LL));
		          *(_OWORD *)&v39->_0.parent = *(_OWORD *)vignette;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          *(__m128i *)&v39->_0.typeMetadataHandle = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
		                                                                                       (Vector4 *)&v103,
		                                                                                       (Bloom *)m_bloom,
		                                                                                       0LL));
		          *(Vector4 *)&v39->_0.castClass = *bloomBicubicParams;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          if ( dirtEnabled )
		          {
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		            s_BloomDirt = static_fields->s_BloomDirt;
		            if ( !m_uiPPMaterial )
		              sub_1800D8250(static_fields, v80);
		          }
		          else
		          {
		            v81 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		            s_BloomDirt = v81->s_Bloom;
		            if ( !m_uiPPMaterial )
		              sub_1800D8250(v81, v80);
		          }
		          v83 = (void (__fastcall *)(Object *, String *))qword_18F36F650;
		          if ( !qword_18F36F650 )
		          {
		            v83 = (void (__fastcall *)(Object *, String *))sub_180059EA0("UnityEngine.Material::EnableKeyword(System.String)");
		            qword_18F36F650 = (__int64)v83;
		          }
		          v83(m_uiPPMaterial, s_BloomDirt);
		        }
		      }
		    }
		    v87 = v100;
		    v90 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		             (TextureHandle *)&v103,
		             &v105,
		             &input->source,
		             0LL);
		    if ( !v87 )
		      sub_1800D8250(v89, v88);
		    v87[1] = (Object)v90;
		    if ( !v100 )
		      sub_1800D8250(v89, v88);
		    v91 = v100[3].klass;
		    v94 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		             (TextureHandle *)&v103,
		             &v105,
		             bloomTexture,
		             0LL);
		    if ( !v91 )
		      sub_1800D8250(v93, v92);
		    *(TextureHandle *)&v91->_0.name = v94;
		    si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		      (TextureHandle *)&v103,
		      &v105,
		      &input->target,
		      0,
		      RenderBufferLoadAction__Enum_Load,
		      RenderBufferStoreAction__Enum_Store,
		      (Color *)&si128,
		      0,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v105,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields->s_uiUberRenderFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
		    sub_180268AE0(&v102);
		  }
		}
		
		private void CopyUIRT(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BE3BCC-0x0000000189BE3E44
		// Void CopyUIRT(UIPostProcessConstructor+PassInput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UIPostProcessConstructor::CopyUIRT(
		        UIPostProcessConstructor *this,
		        UIPostProcessConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // rsi
		  unsigned int uiPPFormat; // r15d
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  TextureHandle v19; // xmm0
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int64 v27; // [rsp+40h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v28; // [rsp+48h] [rbp-60h] BYREF
		  _QWORD v29[2]; // [rsp+50h] [rbp-58h] BYREF
		  TextureHandle v30[2]; // [rsp+60h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v31; // [rsp+80h] [rbp-28h] BYREF
		
		  memset(&v31, 0, sizeof(v31));
		  v27 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3441, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3441, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v26, v25);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1242(
		      Patch,
		      (Object *)this,
		      input,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)8u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    v31 = *(HGRenderGraphBuilder *)sub_1808AFD08(
		                                     (unsigned int)v30,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"UI RT Copy",
		                                     (unsigned int)&v27,
		                                     (__int64)v9);
		    v29[0] = 0LL;
		    v29[1] = &v31;
		    try
		    {
		      if ( !v27 )
		        sub_1800D8250(v13, v12);
		      *(TextureHandle *)(v27 + 24) = input->source;
		      v14 = v27;
		      uiPPFormat = input->uiPPFormat;
		      if ( !camera )
		        sub_1800D8250(v13, v12);
		      sceneRTSize_k__BackingField = camera->fields._sceneRTSize_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v19 = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
		               v30,
		               renderGraph,
		               camera,
		               0,
		               (GraphicsFormat__Enum)uiPPFormat,
		               sceneRTSize_k__BackingField,
		               0LL);
		      if ( !v14 )
		        sub_1800D8250(v18, v17);
		      *(TextureHandle *)(v14 + 40) = v19;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v31, 0, 0LL);
		      if ( !v27 )
		        sub_1800D8250(v21, v20);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v30, &v31, (TextureHandle *)(v27 + 24), 0LL);
		      if ( !v27 )
		        sub_1800D8250(v23, v22);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(v30, &v31, (TextureHandle *)(v27 + 40), 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v31,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields->s_copyUIRTFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v28 )
		    {
		      v29[0] = v28->ex;
		    }
		    sub_180268AE0(v29);
		  }
		}
		
		private void RenderUIDistortion(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BE3FAC-0x0000000189BE43E0
		// Void RenderUIDistortion(UIPostProcessConstructor+PassInput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UIPostProcessConstructor::RenderUIDistortion(
		        UIPostProcessConstructor *this,
		        UIPostProcessConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  HGGraphicsFeatureSwitch *UIDistortion; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  int32_t m_Id; // ebx
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle *v18; // rbx
		  RendererListHandle v19; // rax
		  RendererListHandle v20; // rdx
		  RendererListHandle v21; // rcx
		  __int64 v22; // rdx
		  unsigned int v23; // edx
		  unsigned __int64 v24; // r8
		  char v25; // dl
		  signed __int64 v26; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // [rsp+50h] [rbp-248h] BYREF
		  RendererListHandle inputa[2]; // [rsp+60h] [rbp-238h] BYREF
		  _QWORD v32[2]; // [rsp+70h] [rbp-228h] BYREF
		  HGRenderGraphBuilder v33; // [rsp+80h] [rbp-218h] BYREF
		  Il2CppExceptionWrapper *v34; // [rsp+A0h] [rbp-1F8h] BYREF
		  TextureHandle v35[2]; // [rsp+A8h] [rbp-1F0h] BYREF
		  RendererListDesc desc; // [rsp+D0h] [rbp-1C8h] BYREF
		  RendererListDesc v37; // [rsp+1B0h] [rbp-E8h] BYREF
		
		  memset(&v33, 0, sizeof(v33));
		  v30 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3442, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3442, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v29, v28);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1242(
		      Patch,
		      (Object *)this,
		      input,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0xAu,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    v33 = *(HGRenderGraphBuilder *)sub_1808AFD08(
		                                     (unsigned int)v35,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"UI Distortion",
		                                     (unsigned int)&v30,
		                                     (__int64)v9);
		    v32[0] = 0LL;
		    v32[1] = &v33;
		    try
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      UIDistortion = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UIDistortion;
		      if ( !UIDistortion )
		        sub_1800D8250(0LL, v12);
		      if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(UIDistortion, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		        m_Id = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DistortionName.m_Id;
		        if ( !camera )
		          sub_1800D8250(v15, v14);
		        sub_18033B9D0(&v37, 0LL, 224LL);
		        *(CullingResults *)&inputa[0].m_IsValid = input->cullingResults;
		        UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
		          &v37,
		          (ShaderTagId)m_Id,
		          (CullingResults *)inputa,
		          camera->fields.camera,
		          0LL);
		        desc = v37;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		        desc.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque;
		        desc.sortingCriteria = 59;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        desc.layerMask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_3D_LAYER.m_Mask;
		        InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		      }
		      else
		      {
		        InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		      }
		      inputa[0] = InvalidHandle;
		      v18 = (RendererListHandle *)v30;
		      v19 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v33, inputa, 0LL);
		      if ( !v18 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v21, v20);
		      v18[7] = v19;
		      v22 = v30;
		      if ( !v30 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v21, 0LL);
		      *(_QWORD *)(v30 + 16) = camera;
		      if ( dword_18F35FD08 )
		      {
		        v23 = ((unsigned __int64)(v22 + 16) >> 12) & 0x1FFFFF;
		        v24 = (unsigned __int64)v23 >> 6;
		        v25 = v23 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v24]);
		        do
		          v26 = qword_18F103690[v24];
		        while ( v26 != _InterlockedCompareExchange64(&qword_18F103690[v24], v26 | (1LL << v25), v26) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v33, 0, 0LL);
		      *(__m128i *)&inputa[0].m_IsValid = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        v35,
		        &v33,
		        &input->target,
		        0,
		        RenderBufferLoadAction__Enum_Load,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)inputa,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v33,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor->static_fields->m_uiDistortionRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v34 )
		    {
		      v32[0] = v34->ex;
		    }
		    sub_180268AE0(v32);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BE3F58-0x0000000189BE3FAC
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        UIPostProcessConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3443, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3443, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BE3F04-0x0000000189BE3F58
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        UIPostProcessConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3444, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3444, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters) {} // 0x0000000189BE3874-0x0000000189BE3BCC
		// Void ConstructPass(UIPostProcessConstructor+PassInput ByRef, UIPostProcessConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UIPostProcessConstructor::ConstructPass(
		        UIPostProcessConstructor *this,
		        UIPostProcessConstructor_PassInput *input,
		        UIPostProcessConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  ProfilingSampler *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  BitArray128 source; // xmm6
		  TextureHandle v22; // xmm7
		  unsigned int taauQuality; // r15d
		  unsigned int renderPath; // r12d
		  TextureHandle *v25; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  FrameSettings frameSettings_k__BackingField; // [rsp+70h] [rbp-B8h] BYREF
		  _QWORD v30[2]; // [rsp+90h] [rbp-98h] BYREF
		  TextureHandle v31; // [rsp+A0h] [rbp-88h] BYREF
		  TextureHandle v32; // [rsp+B0h] [rbp-78h] BYREF
		  BitArray128 v33; // [rsp+C0h] [rbp-68h] BYREF
		  HGRenderGraphProfilingScope v34; // [rsp+D0h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v35; // [rsp+E8h] [rbp-40h] BYREF
		
		  memset(&v34, 0, sizeof(v34));
		  v33 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3445, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3445, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v28, v27);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1243(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      (Object *)settingParameters,
		      0LL);
		  }
		  else
		  {
		    v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x27u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		      &v34,
		      renderGraph,
		      v11,
		      0LL);
		    v30[0] = 0LL;
		    v30[1] = &v34;
		    try
		    {
		      if ( !camera )
		        sub_1800D8250(v13, v12);
		      frameSettings_k__BackingField = camera->fields._frameSettings_k__BackingField;
		      if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		             &frameSettings_k__BackingField,
		             FrameSettingsField__Enum_Postprocess,
		             0LL) )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      }
		      if ( !HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL) )
		        sub_1800D8250(v15, v14);
		      if ( !HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL) )
		        sub_1800D8250(v17, v16);
		      volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		      if ( !volumeComponentsData )
		        sub_1800D8250(v20, v19);
		      v32.handle = (ResourceHandle)volumeComponentsData->fields.m_bloom;
		      HG::Rendering::Runtime::UIPostProcessConstructor::CopyUIRT(this, input, renderGraph, camera, 0LL);
		      HG::Rendering::Runtime::UIPostProcessConstructor::RenderUIDistortion(this, input, renderGraph, camera, 0LL);
		      source = (BitArray128)input->source;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v22 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		               (TextureHandle *)&frameSettings_k__BackingField,
		               0LL);
		      taauQuality = input->taauQuality;
		      renderPath = input->renderPath;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v31 = v22;
		      frameSettings_k__BackingField.bitDatas = source;
		      v25 = HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
		              &v32,
		              renderGraph,
		              camera,
		              settingParameters,
		              *(Bloom **)&v32.handle,
		              1,
		              (TextureHandle *)&frameSettings_k__BackingField,
		              &v31,
		              (TAAUQuality__Enum)taauQuality,
		              (HGRenderPathInternal__Enum)renderPath,
		              &this->fields.m_bloomPSMaterials,
		              (Vector4 *)&v33,
		              0LL);
		      frameSettings_k__BackingField.bitDatas = v33;
		      v31 = *v25;
		      HG::Rendering::Runtime::UIPostProcessConstructor::UIUberPass(
		        this,
		        input,
		        settingParameters,
		        renderGraph,
		        camera,
		        &v31,
		        (Vector4 *)&frameSettings_k__BackingField,
		        0LL);
		      camera->fields.didResetPostProcessingHistoryInLastFrame = camera->fields.resetPostProcessingHistory;
		      camera->fields.resetPostProcessingHistory = 0;
		    }
		    catch ( Il2CppExceptionWrapper *v35 )
		    {
		      v30[0] = v35->ex;
		    }
		    sub_180269330(v30);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BE3EB0-0x0000000189BE3F04
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        UIPostProcessConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3446, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3446, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000189BE3E44-0x0000000189BE3EB0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        UIPostProcessConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3447, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3447, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::DisposeBloomPSMaterials(&this->fields.m_bloomPSMaterials, 0LL);
		  }
		}
		
	}
}
