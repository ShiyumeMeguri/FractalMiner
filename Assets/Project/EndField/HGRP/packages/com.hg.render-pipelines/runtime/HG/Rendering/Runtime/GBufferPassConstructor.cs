using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class GBufferPassConstructor : IPassConstructor // TypeDefIndex: 38294
	{
		// Fields
		private static readonly RenderFunc<GBufferPassData> s_gBufferRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38290
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal TextureHandle sceneColorCopied; // 0x30
			internal TextureHandle sceneDepthCopied; // 0x40
			internal GBufferOutput gBufferOutput; // 0x50
			internal CullingResults cullingResults; // 0x70
			internal PerObjectData bakedLightConfig; // 0x80
			internal bool enableTerrainTessellation; // 0x84
			internal bool enableTerrainWetRipple; // 0x85
			internal bool enableTerrainPOM; // 0x86
			internal float screenCullingRatio; // 0x88
			internal float screenCullingRatioDistance; // 0x8C
			internal uint screenCullingLayerMask; // 0x90
			internal uint deferredOpaqueECSList; // 0x94
			internal uint deferredOpaqueEqualECSList; // 0x98
			internal uint deferredGrassECSList; // 0x9C
			internal uint deferredTreeECSList; // 0xA0
			internal uint deferredSludgeECSList; // 0xA4
			internal uint characterPrePassECSList; // 0xA8
			internal uint characterOutlinePrePassECSList; // 0xAC
			internal uint deferredOpaqueGPUDrivenList; // 0xB0
			internal uint deferredOpaqueEqualGPUDrivenList; // 0xB4
		}
	
		internal struct PassOutput // TypeDefIndex: 38291
		{
		}
	
		private class GBufferPassData // TypeDefIndex: 38292
		{
			// Fields
			public int vtFeedbackId; // 0x10
			public uint terrainCullViewHandle; // 0x14
			public uint editorTerrainCullViewHandle; // 0x18
			public int subdivisionHandle; // 0x1C
			public FrameSettings frameSettings; // 0x20
			public RendererListHandle rendererList; // 0x38
			public RendererListHandle characterPrePassRendererList; // 0x40
			public uint deferredOpaqueECSList; // 0x48
			public uint deferredOpaqueEqualECSList; // 0x4C
			public uint deferredGrassECSList; // 0x50
			public uint deferredTreeECSList; // 0x54
			public uint deferredSludgeECSList; // 0x58
			public uint characterPrePassECSList; // 0x5C
			public uint characterOutlinePrePassECSList; // 0x60
			public uint deferredOpaqueGPUDrivenList; // 0x64
			public uint deferredOpaqueEqualGPUDrivenList; // 0x68
			public bool enableTerrainTessellation; // 0x6C
			public bool enableTerrainWetRipple; // 0x6D
			public bool enableTerrainPOM; // 0x6E
	
			// Constructors
			public GBufferPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public GBufferPassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static GBufferPassConstructor() {} // 0x0000000184D2CF10-0x0000000184D2CFA0
		// GBufferPassConstructor()
		void HG::Rendering::Runtime::GBufferPassConstructor::cctor(MethodInfo *method)
		{
		  struct GBufferPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_GBufferPassConstructor_GBufferPassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_GBufferPassConstructor_GBufferPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::GBufferPassConstructor::__c::__cctor_b__10_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor->static_fields->s_gBufferRenderFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BAE918-0x0000000189BAE96C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        GBufferPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3187, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3187, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BAE8C4-0x0000000189BAE918
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        GBufferPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3188, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3188, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BADF00-0x0000000189BAE870
		// Void ConstructPass(GBufferPassConstructor+PassInput ByRef, GBufferPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::GBufferPassConstructor::ConstructPass(
		        GBufferPassConstructor *this,
		        GBufferPassConstructor_PassInput *input,
		        GBufferPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // edi
		  int32_t i; // ebx
		  int32_t v15; // r9d
		  __int64 v16; // rdx
		  HGGraphicsFeatureSwitch *characterPrePass; // rcx
		  bool enabledForCPUCommands; // di
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rdx
		  HGGraphicsFeatureSwitch *deferredOpaque; // rcx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  bool v23; // bl
		  Object__Class *v24; // xmm1_8
		  Object *v25; // rcx
		  PerObjectData__Enum v26; // r13d
		  TextureHandle cullingResults; // xmm8
		  Camera *v28; // r12
		  HGShaderPassNames__StaticFields *v29; // rbx
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // edi
		  RendererListDesc *v33; // rax
		  ResourceHandle InvalidHandle; // rax
		  RendererListHandle *v35; // rbx
		  RendererListHandle v36; // rax
		  RendererListHandle v37; // rdx
		  RendererListHandle v38; // rcx
		  CullingResults v39; // xmm8
		  HGShaderPassNames__StaticFields *v40; // rbx
		  float v41; // xmm7_4
		  float v42; // xmm6_4
		  uint32_t v43; // edi
		  RendererListDesc *v44; // rax
		  ResourceHandle v45; // rax
		  RendererListHandle *v46; // rbx
		  RendererListHandle v47; // rax
		  RendererListHandle v48; // rdx
		  RendererListHandle v49; // rcx
		  __int64 vtFeedbackViewId; // rcx
		  __int64 terrainCullViewHandle; // rcx
		  __int64 editorTerrainCullViewHandle; // rcx
		  __int64 subdivisionHandle; // rcx
		  __int64 deferredOpaqueECSList; // rcx
		  __int64 deferredOpaqueEqualECSList; // rcx
		  __int64 deferredGrassECSList; // rcx
		  __int64 deferredTreeECSList; // rcx
		  __int64 deferredSludgeECSList; // rcx
		  __int64 characterPrePassECSList; // rcx
		  __int64 characterOutlinePrePassECSList; // rcx
		  __int64 deferredOpaqueGPUDrivenList; // rcx
		  __int64 deferredOpaqueEqualGPUDrivenList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  Object *v66; // [rsp+70h] [rbp-308h] BYREF
		  bool v67; // [rsp+78h] [rbp-300h]
		  TextureHandle si128; // [rsp+80h] [rbp-2F8h] BYREF
		  TextureHandle inputa; // [rsp+90h] [rbp-2E8h] BYREF
		  CullingResults v70; // [rsp+A0h] [rbp-2D8h] BYREF
		  HGRenderGraphBuilder v71; // [rsp+B0h] [rbp-2C8h] BYREF
		  HGRenderGraphBuilder v72; // [rsp+D0h] [rbp-2A8h] BYREF
		  Il2CppExceptionWrapper *v73; // [rsp+F0h] [rbp-288h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v74; // [rsp+100h] [rbp-278h] BYREF
		  RendererListDesc desc; // [rsp+170h] [rbp-208h] BYREF
		  RendererListDesc v76; // [rsp+250h] [rbp-128h] BYREF
		
		  v66 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3189, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3189, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v65, v64);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1177(
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
		            (Int32Enum__Enum)0x16u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v72,
		      renderGraph,
		      (String *)"GBuffer",
		      &v66,
		      v10,
		      1,
		      ProfilingHGPass__Enum_GBuffer,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
		    v71 = v72;
		    v72.m_RenderPass = 0LL;
		    v72.m_Resources = (HGRenderGraphResourceRegistry *)&v71;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(&v71, 0, 0LL);
		      v13 = 1;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        &si128,
		        &v71,
		        &input->sceneColor,
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		      {
		        v13 = 2;
		        si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18DC80F80);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v70,
		          &v71,
		          &input->sceneMV,
		          1,
		          (Color *)&si128,
		          0,
		          0LL);
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        &si128,
		        &v71,
		        &input->sceneDepth,
		        DepthAccess__Enum_Write,
		        0,
		        0LL);
		      for ( i = 0; i < 4; ++i )
		      {
		        si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                   (TextureHandle *)&v70,
		                   &input->gBufferOutput,
		                   i,
		                   0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&si128, 0LL) )
		        {
		          v15 = v13++;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&inputa, &v71, &si128, v15, 0, 0LL);
		        }
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      characterPrePass = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterPrePass;
		      if ( !characterPrePass )
		        sub_1800D8250(0LL, v16);
		      enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                characterPrePass,
		                                0LL);
		      v67 = enabledForCPUCommands;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		      deferredOpaque = static_fields->deferredOpaque;
		      if ( !deferredOpaque )
		        sub_1800D8250(0LL, static_fields);
		      v23 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(deferredOpaque, 0LL);
		      if ( !camera )
		        sub_1800D8250(v22, v21);
		      v24 = *(Object__Class **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		      v25 = v66;
		      if ( !v66 )
		        sub_1800D8250(0LL, v21);
		      v66[2] = (Object)camera->fields._frameSettings_k__BackingField.bitDatas;
		      v25[3].klass = v24;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v26 = input->bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		      if ( v23 )
		      {
		        cullingResults = (TextureHandle)input->cullingResults;
		        v28 = camera->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		        v29 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		        screenCullingRatio = input->screenCullingRatio;
		        screenCullingRatioDistance = input->screenCullingRatioDistance;
		        screenCullingLayerMask = input->screenCullingLayerMask;
		        v70.ptr = 0LL;
		        sub_18033B9D0(&v74, 0LL, 112LL);
		        inputa.handle = (ResourceHandle)v70.ptr;
		        inputa.fallBackResource.m_Value = (uint32_t)v70.ptr;
		        si128 = cullingResults;
		        v33 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                &v76,
		                (CullingResults *)&si128,
		                v28,
		                v29->s_GBufferName,
		                screenCullingRatio,
		                screenCullingRatioDistance,
		                screenCullingLayerMask,
		                v26,
		                (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&inputa,
		                &v74,
		                0LL,
		                0,
		                0LL,
		                0LL);
		        *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v33->sortingCriteria;
		        desc.stateBlock = v33->stateBlock;
		        v33 = (RendererListDesc *)((char *)v33 + 128);
		        *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v33->sortingCriteria;
		        *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v33->stateBlock.hasValue;
		        *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v33->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v33->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v33->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v33->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        InvalidHandle = (ResourceHandle)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                          renderGraph,
		                                          &desc,
		                                          0LL);
		        enabledForCPUCommands = v67;
		      }
		      else
		      {
		        InvalidHandle = (ResourceHandle)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		      }
		      inputa.handle = InvalidHandle;
		      v35 = (RendererListHandle *)v66;
		      v36 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		              &v71,
		              (RendererListHandle *)&inputa,
		              0LL);
		      if ( !v35 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v38, v37);
		      v35[7] = v36;
		      if ( enabledForCPUCommands )
		      {
		        v39 = input->cullingResults;
		        inputa.handle = (ResourceHandle)camera->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		        v40 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		        v41 = input->screenCullingRatio;
		        v42 = input->screenCullingRatioDistance;
		        v43 = input->screenCullingLayerMask;
		        v70.ptr = 0LL;
		        sub_18033B9D0(&v74, 0LL, 112LL);
		        si128.handle = (ResourceHandle)v70.ptr;
		        si128.fallBackResource.m_Value = (uint32_t)v70.ptr;
		        v70 = v39;
		        v44 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                &v76,
		                &v70,
		                *(Camera **)&inputa.handle,
		                v40->s_DepthCharacterOnlyName,
		                v41,
		                v42,
		                v43,
		                v26,
		                (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&si128,
		                &v74,
		                0LL,
		                0,
		                0LL,
		                0LL);
		        *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v44->sortingCriteria;
		        desc.stateBlock = v44->stateBlock;
		        v44 = (RendererListDesc *)((char *)v44 + 128);
		        *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v44->sortingCriteria;
		        *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v44->stateBlock.hasValue;
		        *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v44->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v44->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v44->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v44->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        v45 = (ResourceHandle)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                renderGraph,
		                                &desc,
		                                0LL);
		      }
		      else
		      {
		        v45 = (ResourceHandle)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		      }
		      inputa.handle = v45;
		      v46 = (RendererListHandle *)v66;
		      v47 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		              &v71,
		              (RendererListHandle *)&inputa,
		              0LL);
		      if ( !v46 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v49, v48);
		      v46[8] = v47;
		      vtFeedbackViewId = (unsigned int)camera->fields.vtFeedbackViewId;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(vtFeedbackViewId, v48);
		      LODWORD(v66[1].klass) = vtFeedbackViewId;
		      terrainCullViewHandle = camera->fields.terrainCullViewHandle;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(terrainCullViewHandle, v48);
		      HIDWORD(v66[1].klass) = terrainCullViewHandle;
		      editorTerrainCullViewHandle = camera->fields.editorTerrainCullViewHandle;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(editorTerrainCullViewHandle, v48);
		      LODWORD(v66[1].monitor) = editorTerrainCullViewHandle;
		      subdivisionHandle = (unsigned int)camera->fields.subdivisionHandle;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(subdivisionHandle, v48);
		      HIDWORD(v66[1].monitor) = subdivisionHandle;
		      deferredOpaqueECSList = input->deferredOpaqueECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredOpaqueECSList, v48);
		      LODWORD(v66[4].monitor) = deferredOpaqueECSList;
		      deferredOpaqueEqualECSList = input->deferredOpaqueEqualECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredOpaqueEqualECSList, v48);
		      HIDWORD(v66[4].monitor) = deferredOpaqueEqualECSList;
		      deferredGrassECSList = input->deferredGrassECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredGrassECSList, v48);
		      LODWORD(v66[5].klass) = deferredGrassECSList;
		      deferredTreeECSList = input->deferredTreeECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredTreeECSList, v48);
		      HIDWORD(v66[5].klass) = deferredTreeECSList;
		      deferredSludgeECSList = input->deferredSludgeECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredSludgeECSList, v48);
		      LODWORD(v66[5].monitor) = deferredSludgeECSList;
		      characterPrePassECSList = input->characterPrePassECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterPrePassECSList, v48);
		      HIDWORD(v66[5].monitor) = characterPrePassECSList;
		      characterOutlinePrePassECSList = input->characterOutlinePrePassECSList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlinePrePassECSList, v48);
		      LODWORD(v66[6].klass) = characterOutlinePrePassECSList;
		      LOBYTE(characterOutlinePrePassECSList) = input->enableTerrainTessellation;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlinePrePassECSList, v48);
		      BYTE4(v66[6].monitor) = characterOutlinePrePassECSList;
		      LOBYTE(characterOutlinePrePassECSList) = input->enableTerrainWetRipple;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlinePrePassECSList, v48);
		      BYTE5(v66[6].monitor) = characterOutlinePrePassECSList;
		      LOBYTE(characterOutlinePrePassECSList) = input->enableTerrainPOM;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlinePrePassECSList, v48);
		      BYTE6(v66[6].monitor) = characterOutlinePrePassECSList;
		      deferredOpaqueGPUDrivenList = input->deferredOpaqueGPUDrivenList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredOpaqueGPUDrivenList, v48);
		      HIDWORD(v66[6].klass) = deferredOpaqueGPUDrivenList;
		      deferredOpaqueEqualGPUDrivenList = input->deferredOpaqueEqualGPUDrivenList;
		      if ( !v66 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredOpaqueEqualGPUDrivenList, v48);
		      LODWORD(v66[6].monitor) = deferredOpaqueEqualGPUDrivenList;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v71,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor->static_fields->s_gBufferRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v73 )
		    {
		      v72.m_RenderPass = (HGRenderGraphPass *)v73->ex;
		    }
		    sub_180268AE0(&v72);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BAE870-0x0000000189BAE8C4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        GBufferPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3190, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3190, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80470-0x0000000184D804A0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        GBufferPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3191, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3191, 0LL);
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
