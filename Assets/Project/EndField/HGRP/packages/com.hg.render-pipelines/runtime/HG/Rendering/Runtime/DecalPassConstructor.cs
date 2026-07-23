using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class DecalPassConstructor : IPassConstructor // TypeDefIndex: 38205
	{
		// Fields
		private readonly RenderFunc<DecalPassData> s_decalRenderFunc; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38201
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal TextureHandle sceneDepthCopied; // 0x30
			internal TextureHandle sceneNormalCopied; // 0x40
			internal GBufferOutput gBufferOutput; // 0x50
			internal CullingResults cullingResults; // 0x70
			internal PerObjectData bakedLightConfig; // 0x80
			internal float screenCullingRatio; // 0x84
			internal float screenCullingRatioDistance; // 0x88
			internal uint screenCullingLayerMask; // 0x8C
			internal uint deferredDecalECSList; // 0x90
			internal uint deferredErosionECSList; // 0x94
			internal uint deferredSludgeECSList; // 0x98
			internal uint editorTerrainCullViewHandle; // 0x9C
			internal bool enableTerrainTessellation; // 0xA0
			internal bool enableTerrainWetRipple; // 0xA1
			internal bool enableTerrainPOM; // 0xA2
		}
	
		internal struct PassOutput // TypeDefIndex: 38202
		{
		}
	
		private class DecalPassData // TypeDefIndex: 38203
		{
			// Fields
			public FrameSettings frameSettings; // 0x10
			public RendererListHandle erosionRendererList; // 0x28
			public uint deferredDecalECSList; // 0x30
			public uint deferredErosionECSList; // 0x34
			public uint deferredSludgeECSList; // 0x38
			public uint editorTerrainCullViewHandle; // 0x3C
			public bool enableTerrainTessellation; // 0x40
			public bool enableTerrainWetRipple; // 0x41
			public bool enableTerrainPOM; // 0x42
			public TextureHandle sceneDepthCopied; // 0x44
			public TextureHandle sceneNormalCopied; // 0x54
	
			// Constructors
			public DecalPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public DecalPassConstructor() {} // Dummy constructor
		internal DecalPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CA4810-0x0000000184CA48F0
		// DecalPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::DecalPassConstructor::DecalPassConstructor(
		        DecalPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  struct DecalPassConstructor_c__Class *v4; // rax
		  Type *static_fields; // rdx
		  RenderFunc_1_HG_Rendering_Runtime_DecalPassConstructor_DecalPassData_ *monitor; // rbx
		  Object *v8; // rsi
		  RenderFunc_1_System_Object_ *v9; // rax
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  v4 = TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c);
		    v4 = TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c;
		  }
		  static_fields = (Type *)v4->static_fields;
		  monitor = (RenderFunc_1_HG_Rendering_Runtime_DecalPassConstructor_DecalPassData_ *)static_fields->monitor;
		  if ( !monitor )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c;
		    }
		    v8 = (Object *)v4->static_fields->__9;
		    v9 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
		    monitor = (RenderFunc_1_HG_Rendering_Runtime_DecalPassConstructor_DecalPassData_ *)v9;
		    if ( !v9 )
		LABEL_9:
		      sub_1800D8260(this, static_fields);
		    HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		      v9,
		      v8,
		      MethodInfo::HG::Rendering::Runtime::DecalPassConstructor::__c::__ctor_b__0_0,
		      0LL);
		    v10 = (Type *)TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c->static_fields;
		    v10->monitor = (MonitorData *)monitor;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DecalPassConstructor::__c->static_fields->__9__0_0,
		      v10,
		      v11,
		      v12,
		      v13);
		  }
		  if ( !this )
		    goto LABEL_9;
		  this->fields.s_decalRenderFunc = monitor;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields,
		    static_fields,
		    (PropertyInfo_1 *)resources,
		    (Int32__Array **)method,
		    v14);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B92BFC-0x0000000189B92C50
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DecalPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3039, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3039, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B92BA8-0x0000000189B92BFC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DecalPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3040, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3040, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B92494-0x0000000189B92B54
		// Void ConstructPass(DecalPassConstructor+PassInput ByRef, DecalPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DecalPassConstructor::ConstructPass(
		        DecalPassConstructor *this,
		        DecalPassConstructor_PassInput *input,
		        DecalPassConstructor_PassOutput *output,
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
		  Object *v16; // rbx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  TextureHandle v19; // xmm0
		  Object *v20; // rbx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  TextureHandle v23; // xmm0
		  Object__Class *v24; // xmm1_8
		  Object *v25; // rax
		  __int64 v26; // rdx
		  HGGraphicsFeatureSwitch *deferredErosion; // rcx
		  bool enabledForCPUCommands; // di
		  PerObjectData__Enum v29; // r15d
		  CullingResults cullingResults; // xmm8
		  Camera *v31; // r12
		  HGShaderPassNames__StaticFields *static_fields; // rbx
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // edi
		  RendererListDesc *v36; // rax
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle *v38; // rbx
		  RendererListHandle v39; // rax
		  RendererListHandle v40; // rdx
		  RendererListHandle v41; // rcx
		  __int64 deferredDecalECSList; // rcx
		  __int64 deferredErosionECSList; // rcx
		  __int64 deferredSludgeECSList; // rcx
		  __int64 editorTerrainCullViewHandle; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  Object *v49; // [rsp+70h] [rbp-298h] BYREF
		  TextureHandle si128; // [rsp+80h] [rbp-288h] BYREF
		  RendererListHandle inputa[2]; // [rsp+90h] [rbp-278h] BYREF
		  HGRenderGraphBuilder v52; // [rsp+A0h] [rbp-268h] BYREF
		  _QWORD v53[2]; // [rsp+C0h] [rbp-248h] BYREF
		  HGRenderGraphBuilder v54; // [rsp+D0h] [rbp-238h] BYREF
		  Il2CppExceptionWrapper *v55; // [rsp+F0h] [rbp-218h] BYREF
		  RendererListDesc desc; // [rsp+100h] [rbp-208h] BYREF
		  RendererListDesc v57; // [rsp+1E0h] [rbp-128h] BYREF
		
		  v49 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3041, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3041, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v48, v47);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1129(
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
		            (Int32Enum__Enum)0x18u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v54,
		      renderGraph,
		      (String *)"Decal",
		      &v49,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
		    v52 = v54;
		    v53[0] = 0LL;
		    v53[1] = &v52;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(&v52, 0, 0LL);
		      v13 = 1;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        &si128,
		        &v52,
		        &input->sceneColor,
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		      {
		        v13 = 2;
		        si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)inputa,
		          &v52,
		          &input->sceneMV,
		          1,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&si128,
		          0,
		          0LL);
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        &si128,
		        &v52,
		        &input->sceneDepth,
		        DepthAccess__Enum_Write,
		        0,
		        0LL);
		      for ( i = 0; i < 4; ++i )
		      {
		        si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                   (TextureHandle *)inputa,
		                   &input->gBufferOutput,
		                   i,
		                   0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&si128, 0LL) )
		        {
		          v15 = v13++;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v54,
		            &v52,
		            &si128,
		            v15,
		            0,
		            0LL);
		        }
		      }
		      v16 = v49;
		      v19 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v52,
		               &input->sceneDepthCopied,
		               0LL);
		      if ( !v16 )
		        sub_1800D8250(v18, v17);
		      *(TextureHandle *)((char *)&v16[4] + 4) = v19;
		      v20 = v49;
		      v23 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v52,
		               &input->sceneNormalCopied,
		               0LL);
		      if ( !v20 )
		        sub_1800D8250(v22, v21);
		      *(TextureHandle *)((char *)&v20[5] + 4) = v23;
		      if ( !camera )
		        sub_1800D8250(v22, v21);
		      v24 = *(Object__Class **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		      v25 = v49;
		      if ( !v49 )
		        sub_1800D8250(v22, v21);
		      v49[1] = (Object)camera->fields._frameSettings_k__BackingField.bitDatas;
		      v25[2].klass = v24;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      deferredErosion = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredErosion;
		      if ( !deferredErosion )
		        sub_1800D8250(0LL, v26);
		      enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                deferredErosion,
		                                0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v29 = input->bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		      if ( enabledForCPUCommands )
		      {
		        cullingResults = input->cullingResults;
		        v31 = camera->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		        screenCullingRatio = input->screenCullingRatio;
		        screenCullingRatioDistance = input->screenCullingRatioDistance;
		        screenCullingLayerMask = input->screenCullingLayerMask;
		        inputa[0] = 0LL;
		        sub_18033B9D0(&desc, 0LL, 112LL);
		        si128.handle = (ResourceHandle)inputa[0];
		        si128.fallBackResource.m_Value = *(_DWORD *)&inputa[0].m_IsValid;
		        *(CullingResults *)&inputa[0].m_IsValid = cullingResults;
		        v36 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                &v57,
		                (CullingResults *)inputa,
		                v31,
		                static_fields->s_ErosionName,
		                screenCullingRatio,
		                screenCullingRatioDistance,
		                screenCullingLayerMask,
		                v29,
		                (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&si128,
		                (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
		                0LL,
		                0,
		                0LL,
		                0LL);
		        *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v36->sortingCriteria;
		        desc.stateBlock = v36->stateBlock;
		        v36 = (RendererListDesc *)((char *)v36 + 128);
		        *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v36->sortingCriteria;
		        *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v36->stateBlock.hasValue;
		        *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v36->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v36->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v36->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v36->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		      }
		      else
		      {
		        InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		      }
		      inputa[0] = InvalidHandle;
		      v38 = (RendererListHandle *)v49;
		      v39 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v52, inputa, 0LL);
		      if ( !v38 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v41, v40);
		      v38[5] = v39;
		      deferredDecalECSList = input->deferredDecalECSList;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredDecalECSList, v40);
		      LODWORD(v49[3].klass) = deferredDecalECSList;
		      deferredErosionECSList = input->deferredErosionECSList;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredErosionECSList, v40);
		      HIDWORD(v49[3].klass) = deferredErosionECSList;
		      deferredSludgeECSList = input->deferredSludgeECSList;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(deferredSludgeECSList, v40);
		      LODWORD(v49[3].monitor) = deferredSludgeECSList;
		      editorTerrainCullViewHandle = input->editorTerrainCullViewHandle;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(editorTerrainCullViewHandle, v40);
		      HIDWORD(v49[3].monitor) = editorTerrainCullViewHandle;
		      LOBYTE(editorTerrainCullViewHandle) = input->enableTerrainTessellation;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(editorTerrainCullViewHandle, v40);
		      LOBYTE(v49[4].klass) = editorTerrainCullViewHandle;
		      LOBYTE(editorTerrainCullViewHandle) = input->enableTerrainWetRipple;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(editorTerrainCullViewHandle, v40);
		      BYTE1(v49[4].klass) = editorTerrainCullViewHandle;
		      LOBYTE(editorTerrainCullViewHandle) = input->enableTerrainPOM;
		      if ( !v49 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(editorTerrainCullViewHandle, v40);
		      BYTE2(v49[4].klass) = editorTerrainCullViewHandle;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v52,
		        (RenderFunc_1_System_Object_ *)this->fields.s_decalRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v55 )
		    {
		      v53[0] = v55->ex;
		    }
		    sub_180268AE0(v53);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B92B54-0x0000000189B92BA8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DecalPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3042, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3042, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D807A0-0x0000000184D807D0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DecalPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3043, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3043, 0LL);
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
