using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TransparentPassConstructor : IPassConstructor // TypeDefIndex: 38285
	{
		// Fields
		private static readonly RenderFunc<ForwardPassUtils.ForwardTransparentPassData> s_fromDeferredLightingToForwardTransparentRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38282
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal TextureHandle sceneDepthCopied; // 0x30
			internal TextureHandle sceneDepthWithWater; // 0x40
			internal HGRenderPipeline hgrp; // 0x50
			internal GBufferProfileManager.GBufferProfileConfig gBufferProfileConfig; // 0x58
			internal GBufferOutput gBufferOutput; // 0x60
			internal WaterOnePassDeferredRenderingPass waterRenderingPass; // 0x80
			internal ShadowResult shadowResult; // 0x88
			internal CullingResults cullingResults; // 0xC8
			internal PerObjectData bakedLightConfig; // 0xD8
			internal uint forwardTransparentECSRendererList; // 0xDC
			internal bool characterOutlineEnabled; // 0xE0
			internal float screenCullingRatio; // 0xE4
			internal float screenCullingRatioDistance; // 0xE8
			internal uint screenCullingLayerMask; // 0xEC
			internal bool transparentVRS; // 0xF0
			internal int transparentVRRx; // 0xF4
			internal int transparentVRRy; // 0xF8
			internal bool lowResRendering; // 0xFC
			internal BasicTransformConstants basicTransformConstants; // 0x100
			internal ShaderVariablesGlobal shaderVariablesGlobal; // 0x620
		}
	
		internal struct PassOutput // TypeDefIndex: 38283
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
		}
	
		// Constructors
		public TransparentPassConstructor() {} // Dummy constructor
		internal TransparentPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184814CE0-0x0000000184814D30
		// TransparentPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::TransparentPassConstructor::TransparentPassConstructor(
		        TransparentPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Shader *skillScanLinePS; // rbx
		
		  if ( !resources->defaultResources || (shaders = resources->defaultResources->fields.shaders) == 0LL )
		    sub_1800D8260(this, materialCollector);
		  skillScanLinePS = shaders->fields.skillScanLinePS;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		  HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(skillScanLinePS, 0LL);
		}
		
		static TransparentPassConstructor() {} // 0x0000000184D2C4F0-0x0000000184D2C580
		// TransparentPassConstructor()
		void HG::Rendering::Runtime::TransparentPassConstructor::cctor(MethodInfo *method)
		{
		  struct TransparentPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardTransparentPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardTransparentPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::TransparentPassConstructor::__c::__cctor_b__9_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor->static_fields->s_fromDeferredLightingToForwardTransparentRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BB4914-0x0000000189BB4968
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        TransparentPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3177, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3177, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BB48C0-0x0000000189BB4914
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        TransparentPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3178, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3178, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BB35A4-0x0000000189BB486C
		// Void ConstructPass(TransparentPassConstructor+PassInput ByRef, TransparentPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TransparentPassConstructor::ConstructPass(
		        TransparentPassConstructor *this,
		        TransparentPassConstructor_PassInput *input,
		        TransparentPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  TextureHandle v13; // xmm8
		  TextureDesc *TextureDescRef; // rax
		  TransparentPassConstructor_PassOutput *Texture; // rax
		  HGCamera *v16; // r14
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  TransparentPassConstructor_PassOutput v19; // xmm0
		  __int64 v20; // rdx
		  __int64 gBufferProfileConfig; // rcx
		  int32_t i; // edi
		  Object__Class *klass; // r15
		  BitArray128 *GBufferAttachment; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  Object__Class *v29; // r15
		  TextureHandle *v30; // rax
		  Object__Class *v31; // rcx
		  TextureHandle *v32; // rax
		  TextureHandle *p_sceneMV; // r8
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __int128 v36; // xmm6
		  __int128 v37; // xmm7
		  Object *hgrp; // r13
		  Object *waterRenderingPass; // r15
		  bool characterOutlineEnabled; // r12
		  float screenCullingRatio; // xmm9_4
		  float screenCullingRatioDistance; // xmm10_4
		  Object *v43; // rdi
		  BitArray128 cullingResults; // xmm11
		  TextureHandle sceneDepthWithWater; // xmm7
		  TextureHandle sceneDepthCopied; // xmm6
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  unsigned __int64 v49; // r8
		  signed __int64 v50; // rtt
		  unsigned __int64 v51; // r8
		  signed __int64 v52; // rtt
		  __int64 v53; // rdx
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
		  HGGraphicsFeatureSwitch *forwardTransparent; // rbx
		  bool m_defaultValue; // r15
		  ILFixDynamicMethodWrapper_2 *v57; // rax
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  HGGraphicsFeatureManager__StaticFields *v60; // rdx
		  HGGraphicsFeatureSwitch *forwardDecal; // rbx
		  bool v62; // r13
		  ILFixDynamicMethodWrapper_2 *v63; // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  HGGraphicsFeatureManager__StaticFields *v66; // rdx
		  HGGraphicsFeatureSwitch *vfxDecal; // rcx
		  bool enabledForCPUCommands; // r12
		  __int64 v69; // r15
		  RendererListDesc *v70; // rax
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle v72; // rdx
		  RendererListHandle v73; // rcx
		  Camera *v74; // r12
		  ShaderTagId__Array *v75; // r15
		  HGRenderGraphPass *k_RenderQueue_All; // rax
		  RendererListDesc *v77; // rax
		  RendererListHandle v78; // rax
		  RendererListHandle v79; // rdx
		  uint32_t cullingViewHandle; // r15d
		  __int64 v81; // rdx
		  __int64 v82; // rcx
		  HGRenderGraphContext *HGContext; // rbx
		  void *m_Ptr; // rbx
		  __int64 (__fastcall *v85)(_QWORD, __int64, void *, _QWORD); // rax
		  int v86; // eax
		  uint32_t v87; // r15d
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  HGRenderGraphContext *v90; // rbx
		  uint32_t RendererList; // eax
		  __int64 v92; // rcx
		  Camera *v93; // rbx
		  __int64 (__fastcall *v94)(Camera *); // rax
		  LayerMask v95; // ebx
		  __int64 v96; // rdx
		  LayerMask v97; // ebx
		  Object_1 *v98; // rcx
		  int32_t InstanceID; // r14d
		  __int64 v100; // rdx
		  __int64 v101; // rcx
		  HGRenderGraphContext *v102; // rsi
		  ILFixDynamicMethodWrapper_2 *v103; // rax
		  __int64 v104; // rdx
		  __int64 v105; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v107; // rdx
		  __int64 v108; // rcx
		  __int64 v109; // rax
		  __int64 v110; // rax
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-10C8h]
		  bool lowResRendering; // [rsp+C0h] [rbp-1028h]
		  bool transparentVRS; // [rsp+C1h] [rbp-1027h]
		  bool v114; // [rsp+C2h] [rbp-1026h]
		  bool v115; // [rsp+C3h] [rbp-1025h]
		  FrameSettings frameSettings_k__BackingField; // [rsp+D0h] [rbp-1018h] BYREF
		  uint32_t screenCullingLayerMask; // [rsp+F0h] [rbp-FF8h]
		  unsigned int bakedLightConfig; // [rsp+F4h] [rbp-FF4h]
		  Object *v119; // [rsp+F8h] [rbp-FF0h] BYREF
		  int32_t transparentVRRy; // [rsp+100h] [rbp-FE8h]
		  int32_t transparentVRRx; // [rsp+104h] [rbp-FE4h]
		  uint32_t forwardTransparentECSRendererList; // [rsp+108h] [rbp-FE0h]
		  TextureHandle v123; // [rsp+110h] [rbp-FD8h] BYREF
		  RendererListHandle inputa; // [rsp+120h] [rbp-FC8h] BYREF
		  HGRenderGraphBuilder v125; // [rsp+130h] [rbp-FB8h] BYREF
		  HGRenderGraphBuilder v126; // [rsp+150h] [rbp-F98h] BYREF
		  HGRenderGraphBuilder v127; // [rsp+170h] [rbp-F78h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v128; // [rsp+190h] [rbp-F58h] BYREF
		  TextureHandle v129; // [rsp+1A0h] [rbp-F48h] BYREF
		  ShaderVariablesGlobal *p_shaderVariablesGlobal; // [rsp+1B0h] [rbp-F38h]
		  BasicTransformConstants *p_basicTransformConstants; // [rsp+1B8h] [rbp-F30h]
		  _QWORD v132[2]; // [rsp+1C0h] [rbp-F28h] BYREF
		  Il2CppExceptionWrapper *v133; // [rsp+1D0h] [rbp-F18h] BYREF
		  TextureDesc v134; // [rsp+1E0h] [rbp-F08h] BYREF
		  TextureDesc v135; // [rsp+240h] [rbp-EA8h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v136; // [rsp+2A0h] [rbp-E48h] BYREF
		  RendererListDesc desc; // [rsp+310h] [rbp-DD8h] BYREF
		  RendererListDesc v138[14]; // [rsp+3F0h] [rbp-CF8h] BYREF
		
		  v119 = 0LL;
		  sub_18033B9D0(&v134, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3179, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3179, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v108, v107);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1175(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x91u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v127,
		      renderGraph,
		      (String *)"Forward Transparent",
		      &v119,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
		    v126 = v127;
		    v132[0] = 0LL;
		    v132[1] = &v126;
		    try
		    {
		      v13 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&frameSettings_k__BackingField,
		               &v126,
		               &input->sceneColor,
		               0LL);
		      if ( input->lowResRendering )
		      {
		        v134 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
		                  &v135,
		                  renderGraph,
		                  &input->sceneColor,
		                  0LL);
		        v16 = camera;
		        if ( !camera )
		          sub_1800D8250(v18, v17);
		        v134.width = camera->fields._sceneRTSize_k__BackingField.m_X / 2;
		        v134.height = (int)HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField) / 2;
		        v134.colorFormat = 48;
		        Texture = (TransparentPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                             (TextureHandle *)&frameSettings_k__BackingField,
		                                                             renderGraph,
		                                                             &v134,
		                                                             0LL);
		      }
		      else
		      {
		        TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                           renderGraph,
		                           &input->sceneColor,
		                           0LL);
		        Texture = (TransparentPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                             (TextureHandle *)&frameSettings_k__BackingField,
		                                                             renderGraph,
		                                                             TextureDescRef,
		                                                             0LL);
		        v16 = camera;
		      }
		      v19 = *Texture;
		      *output = *Texture;
		      *(TransparentPassConstructor_PassOutput *)&v125.m_RenderPass = v19;
		      frameSettings_k__BackingField.bitDatas = (BitArray128)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		      if ( input->lowResRendering )
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v123,
		          &v126,
		          (TextureHandle *)&v125,
		          0,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&frameSettings_k__BackingField,
		          0,
		          0LL);
		      else
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v123,
		          &v126,
		          (TextureHandle *)&v125,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&frameSettings_k__BackingField,
		          0,
		          0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        (TextureHandle *)&frameSettings_k__BackingField,
		        &v126,
		        &input->sceneDepth,
		        DepthAccess__Enum_Read,
		        0,
		        0LL);
		      gBufferProfileConfig = (unsigned int)input->gBufferProfileConfig;
		      if ( !v119 )
		        sub_1800D8250(gBufferProfileConfig, v20);
		      LODWORD(v119[4].monitor) = gBufferProfileConfig;
		      if ( !input->gBufferProfileConfig )
		      {
		        for ( i = 0; i < 4; ++i )
		        {
		          if ( !v119 )
		            sub_1800D8250(gBufferProfileConfig, v20);
		          klass = v119[5].klass;
		          GBufferAttachment = (BitArray128 *)HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                                               &v123,
		                                               &input->gBufferOutput,
		                                               i,
		                                               0LL);
		          if ( !klass )
		            sub_1800D8250(v26, v25);
		          frameSettings_k__BackingField.bitDatas = *GBufferAttachment;
		          sub_180430AC4(klass, i, &frameSettings_k__BackingField);
		          if ( !v119 )
		            sub_1800D8250(v28, v27);
		          v29 = v119[5].klass;
		          if ( !v29 )
		            sub_1800D8250(v28, v27);
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v30 = (TextureHandle *)sub_1803C0774(v29, i);
		          if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v30, 0LL) )
		          {
		            if ( !v119 )
		              sub_1800D8250(gBufferProfileConfig, v20);
		            v31 = v119[5].klass;
		            if ( !v31 )
		              sub_1800D8250(0LL, v20);
		            v32 = (TextureHandle *)sub_1803C0774(v31, i);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v129, &v126, v32, 0LL);
		          }
		        }
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		      {
		        p_sceneMV = &input->sceneMV;
		        if ( input->lowResRendering )
		        {
		          frameSettings_k__BackingField.bitDatas = (BitArray128)_mm_load_si128((const __m128i *)&xmmword_18DC80F80);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v123,
		            &v126,
		            p_sceneMV,
		            1,
		            RenderBufferLoadAction__Enum_Clear,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&frameSettings_k__BackingField,
		            0,
		            0LL);
		        }
		        else
		        {
		          frameSettings_k__BackingField.bitDatas = (BitArray128)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v123,
		            &v126,
		            p_sceneMV,
		            1,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&frameSettings_k__BackingField,
		            0,
		            0LL);
		        }
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        (TextureHandle *)&frameSettings_k__BackingField,
		        &v126,
		        &input->sceneDepthCopied,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneDepthWithWater, 0LL) )
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		          (TextureHandle *)&frameSettings_k__BackingField,
		          &v126,
		          &input->sceneDepthWithWater,
		          0LL);
		      if ( !v16 )
		        sub_1800D8250(v35, v34);
		      frameSettings_k__BackingField = v16->fields._frameSettings_k__BackingField;
		      if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		             &frameSettings_k__BackingField,
		             FrameSettingsField__Enum_ShadowMaps,
		             0LL)
		        || (frameSettings_k__BackingField = v16->fields._frameSettings_k__BackingField,
		            HG::Rendering::Runtime::FrameSettings::IsEnabled(
		              &frameSettings_k__BackingField,
		              FrameSettingsField__Enum_CharacterShadowMaps,
		              0LL)) )
		      {
		        v36 = *(_OWORD *)&v126.m_RenderPass;
		        v37 = *(_OWORD *)&v126.m_RenderGraph;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v127.m_RenderPass = v36;
		        *(_OWORD *)&v127.m_RenderGraph = v37;
		        HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
		          (ShadowResult *)&v135,
		          &input->shadowResult,
		          &v127,
		          0LL);
		      }
		      hgrp = (Object *)input->hgrp;
		      *(_QWORD *)&v128.hasValue = hgrp;
		      waterRenderingPass = (Object *)input->waterRenderingPass;
		      bakedLightConfig = input->bakedLightConfig;
		      forwardTransparentECSRendererList = input->forwardTransparentECSRendererList;
		      characterOutlineEnabled = input->characterOutlineEnabled;
		      v114 = characterOutlineEnabled;
		      screenCullingRatio = input->screenCullingRatio;
		      screenCullingRatioDistance = input->screenCullingRatioDistance;
		      screenCullingLayerMask = input->screenCullingLayerMask;
		      v43 = v119;
		      transparentVRS = input->transparentVRS;
		      transparentVRRx = input->transparentVRRx;
		      transparentVRRy = input->transparentVRRy;
		      lowResRendering = input->lowResRendering;
		      p_basicTransformConstants = &input->basicTransformConstants;
		      p_shaderVariablesGlobal = &input->shaderVariablesGlobal;
		      cullingResults = (BitArray128)input->cullingResults;
		      v127 = v126;
		      sceneDepthWithWater = input->sceneDepthWithWater;
		      frameSettings_k__BackingField.bitDatas = (BitArray128)sceneDepthWithWater;
		      sceneDepthCopied = input->sceneDepthCopied;
		      v123 = sceneDepthCopied;
		      v129 = v13;
		      inputa = 0LL;
		      sub_18033B9D0(&desc, 0LL, 224LL);
		      sub_18033B9D0(&v136, 0LL, 112LL);
		      if ( IFix::WrappersManagerImpl::IsPatched(3148, 0LL) )
		      {
		        v103 = IFix::WrappersManagerImpl::GetPatch(3148, 0LL);
		        if ( !v103 )
		          sub_1800D8250(v105, v104);
		        frameSettings_k__BackingField.bitDatas = cullingResults;
		        *(_OWORD *)&v135.width = *(_OWORD *)&v127.m_RenderPass;
		        *(_OWORD *)&v135.colorFormat = *(_OWORD *)&v127.m_RenderGraph;
		        v123 = sceneDepthWithWater;
		        v129 = sceneDepthCopied;
		        *(TextureHandle *)&v125.m_RenderPass = v13;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1163(
		          v103,
		          hgrp,
		          (Object *)renderGraph,
		          (TextureHandle *)&v125,
		          &v129,
		          &v123,
		          (Object *)v16,
		          waterRenderingPass,
		          (HGRenderGraphBuilder *)&v135,
		          (CullingResults *)&frameSettings_k__BackingField,
		          (PerObjectData__Enum)bakedLightConfig,
		          forwardTransparentECSRendererList,
		          characterOutlineEnabled,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          v43,
		          transparentVRS,
		          transparentVRRx,
		          transparentVRRy,
		          lowResRendering,
		          p_basicTransformConstants,
		          p_shaderVariablesGlobal,
		          0LL);
		      }
		      else
		      {
		        if ( !v43 )
		          sub_1800D8250(v48, v47);
		        v43[9].klass = (Object__Class *)waterRenderingPass;
		        if ( dword_18F35FD08 )
		        {
		          v49 = (((unsigned __int64)&v43[9] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v49 + 36190]);
		          do
		            v50 = qword_18F0BCBA0[v49 + 36190];
		          while ( v50 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v49 + 36190],
		                           v50 | (1LL << (((unsigned __int64)&v43[9] >> 12) & 0x3F)),
		                           v50) );
		        }
		        if ( waterRenderingPass )
		        {
		          v125 = v127;
		          HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PrepareInTransparentPass(
		            (WaterOnePassDeferredRenderingPass *)waterRenderingPass,
		            &v125,
		            0LL);
		        }
		        *(TextureHandle *)&v43[1].monitor = v13;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v129, 0LL) )
		          *(Object *)((char *)v43 + 24) = *(Object *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                       (TextureHandle *)&v125,
		                                                       &v127,
		                                                       &v129,
		                                                       0LL);
		        *(TextureHandle *)&v43[2].monitor = sceneDepthCopied;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v123, 0LL) )
		          *(Object *)((char *)v43 + 40) = *(Object *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                       &v129,
		                                                       &v127,
		                                                       &v123,
		                                                       0LL);
		        *(TextureHandle *)&v43[3].monitor = sceneDepthWithWater;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
		               (TextureHandle *)&frameSettings_k__BackingField,
		               0LL) )
		        {
		          *(Object *)((char *)v43 + 56) = *(Object *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                       &v123,
		                                                       &v127,
		                                                       (TextureHandle *)&frameSettings_k__BackingField,
		                                                       0LL);
		        }
		        v43[1].klass = (Object__Class *)v16;
		        if ( dword_18F35FD08 )
		        {
		          v51 = (((unsigned __int64)&v43[1] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v51 + 36190]);
		          do
		            v52 = qword_18F0BCBA0[v51 + 36190];
		          while ( v52 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v51 + 36190],
		                           v52 | (1LL << (((unsigned __int64)&v43[1] >> 12) & 0x3F)),
		                           v52) );
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        forwardTransparent = static_fields->forwardTransparent;
		        if ( !forwardTransparent )
		          sub_1800D8250(static_fields, v53);
		        if ( IFix::WrappersManagerImpl::IsPatched(413, 0LL) )
		        {
		          v57 = IFix::WrappersManagerImpl::GetPatch(413, 0LL);
		          if ( !v57 )
		            sub_1800D8250(v59, v58);
		          m_defaultValue = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                             (ILFixDynamicMethodWrapper_20 *)v57,
		                             (Object *)forwardTransparent,
		                             0LL);
		        }
		        else
		        {
		          m_defaultValue = forwardTransparent->fields.m_defaultValue;
		        }
		        v60 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        forwardDecal = v60->forwardDecal;
		        if ( !forwardDecal )
		          sub_1800D8250(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, v60);
		        if ( IFix::WrappersManagerImpl::IsPatched(413, 0LL) )
		        {
		          v63 = IFix::WrappersManagerImpl::GetPatch(413, 0LL);
		          if ( !v63 )
		            sub_1800D8250(v65, v64);
		          v62 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                  (ILFixDynamicMethodWrapper_20 *)v63,
		                  (Object *)forwardDecal,
		                  0LL);
		        }
		        else
		        {
		          v62 = forwardDecal->fields.m_defaultValue;
		        }
		        v66 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        vfxDecal = v66->vfxDecal;
		        if ( !vfxDecal )
		          sub_1800D8250(0LL, v66);
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  vfxDecal,
		                                  0LL);
		        v115 = enabledForCPUCommands;
		        LODWORD(v43[7].monitor) = -1;
		        HIDWORD(v43[7].monitor) = -1;
		        LODWORD(v43[8].klass) = -1;
		        frameSettings_k__BackingField = v16->fields._frameSettings_k__BackingField;
		        if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		               &frameSettings_k__BackingField,
		               FrameSettingsField__Enum_TransparentObjects,
		               0LL) )
		        {
		          if ( m_defaultValue )
		          {
		            frameSettings_k__BackingField.bitDatas = cullingResults;
		            v69 = *(_QWORD *)&v128.hasValue;
		            v70 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
		                    v138,
		                    *(HGRenderPipeline **)&v128.hasValue,
		                    v16,
		                    0,
		                    v114,
		                    (CullingResults *)&frameSettings_k__BackingField,
		                    (PerObjectData__Enum)bakedLightConfig,
		                    screenCullingRatio,
		                    screenCullingRatioDistance,
		                    screenCullingLayerMask,
		                    0LL);
		            *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v70->sortingCriteria;
		            desc.stateBlock = v70->stateBlock;
		            v70 = (RendererListDesc *)((char *)v70 + 128);
		            *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v70->sortingCriteria;
		            *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v70->stateBlock.hasValue;
		            *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v70->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v70->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v70->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v70->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		            InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		          }
		          else
		          {
		            InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		            v69 = *(_QWORD *)&v128.hasValue;
		          }
		          inputa = InvalidHandle;
		          v43[6].monitor = (MonitorData *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                            &v127,
		                                            &inputa,
		                                            0LL);
		          if ( enabledForCPUCommands )
		          {
		            v74 = v16->fields.camera;
		            if ( !v69 )
		              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v73, v72);
		            v75 = *(ShaderTagId__Array **)(v69 + 192);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		            k_RenderQueue_All = (HGRenderGraphPass *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_All;
		            LODWORD(v125.m_RenderPass) = 1;
		            *(HGRenderGraphPass **)((char *)&v125.m_RenderPass + 4) = k_RenderQueue_All;
		            sub_18033B9D0(&v136, 0LL, 112LL);
		            *(_QWORD *)&v128.hasValue = v125.m_RenderPass;
		            v128.value.m_UpperBound = (int32_t)v125.m_Resources;
		            frameSettings_k__BackingField.bitDatas = cullingResults;
		            v77 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
		                    v138,
		                    (CullingResults *)&frameSettings_k__BackingField,
		                    v74,
		                    v75,
		                    screenCullingRatio,
		                    screenCullingRatioDistance,
		                    screenCullingLayerMask,
		                    (PerObjectData__Enum)bakedLightConfig,
		                    &v128,
		                    &v136,
		                    0LL,
		                    0,
		                    0LL);
		            *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v77->sortingCriteria;
		            desc.stateBlock = v77->stateBlock;
		            v77 = (RendererListDesc *)((char *)v77 + 128);
		            *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v77->sortingCriteria;
		            *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v77->stateBlock.hasValue;
		            *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v77->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v77->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v77->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v77->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		            v78 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		            enabledForCPUCommands = v115;
		          }
		          else
		          {
		            v78 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		          }
		          inputa = v78;
		          v43[7].klass = (Object__Class *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                            &v127,
		                                            &inputa,
		                                            0LL);
		          if ( v62 )
		          {
		            cullingViewHandle = v16->fields.cullingViewHandle;
		            HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		            if ( !HGContext )
		              sub_1800D8250(v82, v81);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		            m_Ptr = HGContext->fields.renderContext.m_Ptr;
		            v85 = (__int64 (__fastcall *)(_QWORD, __int64, void *, _QWORD))qword_18F3ABAD0;
		            if ( !qword_18F3ABAD0 )
		            {
		              v85 = (__int64 (__fastcall *)(_QWORD, __int64, void *, _QWORD))il2cpp_resolve_icall_1(
		                                                                               "UnityEngine.HyperGryph.HGDecalRender::Cre"
		                                                                               "ateRendererList(System.UInt32,System.UInt"
		                                                                               "32,System.IntPtr,System.UInt32*)");
		              if ( !v85 )
		              {
		                v109 = sub_1802EE1B8(
		                         "UnityEngine.HyperGryph.HGDecalRender::CreateRendererList(System.UInt32,System.UInt32,System.Int"
		                         "Ptr,System.UInt32*)");
		                sub_18007E1B0(v109, 0LL);
		              }
		              qword_18F3ABAD0 = (__int64)v85;
		            }
		            v86 = v85(cullingViewHandle, 0x4000LL, m_Ptr, 0LL);
		          }
		          else
		          {
		            v86 = -1;
		          }
		          HIDWORD(v43[7].monitor) = v86;
		          if ( enabledForCPUCommands )
		          {
		            v87 = v16->fields.cullingViewHandle;
		            v90 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		            if ( !v90 )
		              sub_1800D8250(v89, v88);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		            LOWORD(globalKeywords) = 0;
		            RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                             v87,
		                             HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		                             HGRenderFlags__Enum_Transparent,
		                             HGShaderLightMode__Enum_VFXDecal,
		                             globalKeywords,
		                             v90->fields.renderContext.m_Ptr,
		                             0,
		                             1,
		                             0xFFFFFFFF,
		                             0,
		                             0,
		                             0LL);
		          }
		          else
		          {
		            RendererList = -1;
		          }
		          LODWORD(v43[8].klass) = RendererList;
		          v92 = forwardTransparentECSRendererList;
		          LODWORD(v43[7].monitor) = forwardTransparentECSRendererList;
		          v93 = v16->fields.camera;
		          if ( !v93 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v92, v79);
		          v94 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		          if ( !qword_18F36F120 )
		          {
		            v94 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cullingMask()");
		            if ( !v94 )
		            {
		              v110 = sub_1802EE1B8("UnityEngine.Camera::get_cullingMask()");
		              sub_18007E1B0(v110, 0LL);
		            }
		            qword_18F36F120 = (__int64)v94;
		          }
		          v95.m_Mask = v94(v93);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		          v97.m_Mask = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(v95, 0LL).m_Mask;
		          v98 = (Object_1 *)v16->fields.camera;
		          if ( !v98 )
		            sub_1800D8250(0LL, v96);
		          InstanceID = UnityEngine::Object::GetInstanceID(v98, 0LL);
		          v102 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !v102 )
		            sub_1800D8250(v101, v100);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          HIDWORD(v43[8].klass) = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                                    v97.m_Mask,
		                                    HGRenderFlags__Enum_None,
		                                    HGRenderFlags__Enum_None,
		                                    HGShaderLightMode__Enum_StencilAlphaBlend|HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
		                                    0x8000,
		                                    0x7FFF,
		                                    InstanceID,
		                                    v102->fields.renderContext.m_Ptr,
		                                    0,
		                                    3.4028235e38,
		                                    0LL);
		          LODWORD(v43[8].monitor) = -1;
		          LOBYTE(v43[9].monitor) = transparentVRS;
		          HIDWORD(v43[9].monitor) = transparentVRRx;
		          LODWORD(v43[10].klass) = transparentVRRy;
		          BYTE4(v43[10].klass) = lowResRendering;
		          sub_18033B330(v138, p_basicTransformConstants, 1312LL);
		          sub_18033B330(&v43[10].monitor, v138, 1312LL);
		          sub_18033B330(v138, p_shaderVariablesGlobal, 3200LL);
		          sub_18033B330(&v43[92].monitor, v138, 3200LL);
		        }
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v126,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor->static_fields->s_fromDeferredLightingToForwardTransparentRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v133 )
		    {
		      v132[0] = v133->ex;
		    }
		    sub_180268AE0(v132);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BB486C-0x0000000189BB48C0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        TransparentPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3180, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3180, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FD50-0x0000000184D7FD80
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        TransparentPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3181, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3181, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
	}
}
