using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class DeferredLightingPassConstructor : IPassConstructor // TypeDefIndex: 38214
	{
		// Fields
		private Material m_deferredLightingMaterial; // 0x10
		private Material m_deferredLightingWriteAlphaMaterial; // 0x18
		private static readonly RenderFunc<DeferredLightingPassData> s_fromDeferredLightingToForwardOpaqueRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38210
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneDepthCopied; // 0x20
			internal TextureHandle historySceneColor; // 0x30
			internal TextureHandle indirectAmbientOcclusionTexture; // 0x40
			internal TextureHandle ssrLightingTexture; // 0x50
			internal TextureHandle ssrFadenessTexture; // 0x60
			internal TextureHandle planarReflectionTexture; // 0x70
			internal TextureHandle fogBakeLutTexture; // 0x80
			internal TextureHandle waterWetnessMaskTexture; // 0x90
			internal HGRenderPipeline hgrp; // 0xA0
			internal GBufferOutput gBufferOutput; // 0xA8
			internal ShadowResult shadowResult; // 0xC8
			internal GraphicsFormat sceneColorFormat; // 0x104
		}
	
		internal struct PassOutput // TypeDefIndex: 38211
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
		}
	
		private class DeferredLightingPassData // TypeDefIndex: 38212
		{
			// Fields
			public TextureHandle colorBuffer; // 0x10
			public TextureHandle depthBuffer; // 0x20
			public TextureHandle depthTexture; // 0x30
			public TextureHandle previousSceneColorTexture; // 0x40
			public TextureHandle indirectAmbientOcclusionTexture; // 0x50
			public TextureHandle ssrLightingTexture; // 0x60
			public TextureHandle ssrFadenessTexture; // 0x70
			public TextureHandle planarReflectionTexture; // 0x80
			public TextureHandle fogBakeLutTexture; // 0x90
			public TextureHandle waterWetnessMaskTexture; // 0xA0
			public TextureHandle[] gbuffer; // 0xB0
			public HGCamera hgCamera; // 0xB8
			public Material deferredLightingMaterial; // 0xC0
			public Material deferredLightingWriteAlphaMaterial; // 0xC8
	
			// Constructors
			public DeferredLightingPassData() {} // 0x0000000189B935BC-0x0000000189B93614
			// DeferredLightingPassConstructor+DeferredLightingPassData()
			void HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData::DeferredLightingPassData(
			        DeferredLightingPassConstructor_DeferredLightingPassData *this,
			        MethodInfo *method)
			{
			  struct HGRenderGraph__Class *v2; // rax
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Int32__Array **v6; // r9
			  MethodInfo *v7; // [rsp+50h] [rbp+28h]
			
			  v2 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
			  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			    v2 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
			  }
			  this->fields.gbuffer = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                   TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                   v2->static_fields->kMaxMRTCount);
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields.gbuffer, v4, v5, v6, v7);
			}
			
		}
	
		// Constructors
		public DeferredLightingPassConstructor() {} // Dummy constructor
		internal DeferredLightingPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184814C10-0x0000000184814CE0
		// DeferredLightingPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassConstructor(
		        DeferredLightingPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineMaterialCollector *v5; // rbx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v14; // rax
		  Shader *skillScanLinePS; // rbx
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		
		  v5 = materialCollector;
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders
		    || !materialCollector
		    || (this->fields.m_deferredLightingMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                    materialCollector,
		                                                    shaders->fields.deferredPS,
		                                                    0,
		                                                    0LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v8, v9, v10, v16),
		        (materialCollector = (HGRenderPipelineMaterialCollector *)resources->defaultResources) == 0LL)
		    || (materialCollector = (HGRenderPipelineMaterialCollector *)materialCollector[1].klass) == 0LL
		    || (this->fields.m_deferredLightingWriteAlphaMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                              v5,
		                                                              (Shader *)materialCollector[3].klass,
		                                                              0,
		                                                              0LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_deferredLightingWriteAlphaMaterial, v11, v12, v13, v17),
		        !resources->defaultResources)
		    || (v14 = resources->defaultResources->fields.shaders) == 0LL )
		  {
		LABEL_2:
		    sub_1800D8260(this, materialCollector);
		  }
		  skillScanLinePS = v14->fields.skillScanLinePS;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		  HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(skillScanLinePS, 0LL);
		}
		
		static DeferredLightingPassConstructor() {} // 0x0000000184D2D0C0-0x0000000184D2D150
		// DeferredLightingPassConstructor()
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::cctor(MethodInfo *method)
		{
		  struct DeferredLightingPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_DeferredLightingPassConstructor_DeferredLightingPassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_DeferredLightingPassConstructor_DeferredLightingPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor::__c::__cctor_b__13_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor->static_fields->s_fromDeferredLightingToForwardOpaqueRenderFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		private void PrepareDeferredLightingPass(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, DeferredLightingPassData passData, bool changeColorRT) {} // 0x0000000189B92F58-0x0000000189B935BC
		// Void PrepareDeferredLightingPass(DeferredLightingPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, DeferredLightingPassConstructor+DeferredLightingPassData, Boolean)
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::PrepareDeferredLightingPass(
		        DeferredLightingPassConstructor *this,
		        DeferredLightingPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGRenderGraphBuilder *builder,
		        DeferredLightingPassConstructor_DeferredLightingPassData *passData,
		        bool changeColorRT,
		        MethodInfo *method)
		{
		  TextureHandle *nullHandle; // rax
		  __int64 v13; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle *v15; // rax
		  MethodInfo *v16; // rdx
		  TextureHandle *v17; // rax
		  Color v18; // xmm0
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // r10
		  int32_t v23; // ebx
		  TextureHandle v24; // xmm0
		  GBufferOutput *p_gBufferOutput; // rax
		  TextureHandle__Array *gbuffer; // r12
		  TextureHandle *GBufferAttachment; // rax
		  TextureHandle__Array *v28; // r12
		  TextureHandle *v29; // rax
		  TextureHandle *v30; // rax
		  TextureHandle v31; // xmm0
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  Shader *shader; // rbx
		  Material *m_deferredLightingMaterial; // rbx
		  bool HasTerrainSimpleSubsurface; // al
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  Material *m_deferredLightingWriteAlphaMaterial; // r9
		  Type *v42; // rdx
		  PropertyInfo_1 *v43; // r8
		  HGRenderGraph *v44; // xmm1_8
		  HGRenderGraph *v45; // xmm1_8
		  __int128 v46; // xmm6
		  __int128 v47; // xmm7
		  __int128 v48; // xmm1
		  MethodInfo *v49; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v50; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v51; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v52; // [rsp+28h] [rbp-E0h]
		  TextureHandle v53; // [rsp+58h] [rbp-B0h] BYREF
		  HGRenderGraphBuilder v54; // [rsp+68h] [rbp-A0h] BYREF
		  Color v55; // [rsp+88h] [rbp-80h] BYREF
		  TextureDesc v56; // [rsp+98h] [rbp-70h] BYREF
		  LocalKeyword keyword; // [rsp+F8h] [rbp-10h] BYREF
		  TextureDesc v58; // [rsp+118h] [rbp+10h] BYREF
		  ShadowResult v59; // [rsp+178h] [rbp+70h] BYREF
		
		  memset(&keyword, 0, sizeof(keyword));
		  sub_18033B9D0(&v58, 0LL, 96LL);
		  sub_18033B9D0(&v56, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3048, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3048, 0LL);
		    if ( Patch )
		    {
		      v48 = *(_OWORD *)&builder->m_RenderGraph;
		      *(_OWORD *)&v54.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		      *(_OWORD *)&v54.m_RenderGraph = v48;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1134(
		        Patch,
		        (Object *)this,
		        input,
		        (Object *)renderGraph,
		        (Object *)camera,
		        &v54,
		        (Object *)passData,
		        changeColorRT,
		        0LL);
		      return;
		    }
		    goto LABEL_33;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->historySceneColor, 0LL) )
		  {
		    nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   &v53,
		                   builder,
		                   &input->historySceneColor,
		                   0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v53, 0LL);
		  }
		  if ( !passData )
		    goto LABEL_33;
		  passData->fields.previousSceneColorTexture = *nullHandle;
		  if ( !camera )
		    goto LABEL_33;
		  if ( HG::Rendering::Runtime::HGCamera::get_ssrEnable(camera, 0LL) )
		  {
		    passData->fields.ssrLightingTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                             &v53,
		                                             builder,
		                                             &input->ssrLightingTexture,
		                                             0LL);
		    passData->fields.ssrFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                             &v53,
		                                             builder,
		                                             &input->ssrFadenessTexture,
		                                             0LL);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->indirectAmbientOcclusionTexture, 0LL) )
		    passData->fields.indirectAmbientOcclusionTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                          &v53,
		                                                          builder,
		                                                          &input->indirectAmbientOcclusionTexture,
		                                                          0LL);
		  passData->fields.planarReflectionTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                &v53,
		                                                builder,
		                                                &input->planarReflectionTexture,
		                                                0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->fogBakeLutTexture, 0LL) )
		    passData->fields.fogBakeLutTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                            &v53,
		                                            builder,
		                                            &input->fogBakeLutTexture,
		                                            0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->waterWetnessMaskTexture, 0LL) )
		  {
		    v15 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		            &v53,
		            builder,
		            &input->waterWetnessMaskTexture,
		            0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v15 = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v53, 0LL);
		  }
		  passData->fields.waterWetnessMaskTexture = *v15;
		  if ( changeColorRT )
		  {
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v56, camera->fields._sceneRTSize_k__BackingField, 0LL);
		    v56.colorFormat = input->sceneColorFormat;
		    v56.enableRandomWrite = 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v56.clearBuffer = HG::Rendering::Runtime::HGRenderPipeline::NeedClearColorBuffer(camera, 0LL);
		    v18 = *HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferClearColor(&v55, camera, 0LL);
		    v56.filterMode = 1;
		    v56.clearColor = v18;
		    v56.wrapMode = 1;
		    v56.name = (String *)"SceneColorCreatedByDeferredLightingPass";
		    sub_18002D1B0((SingleFieldAccessor *)&v56.name, v19, v20, v21, v49);
		    v56.fastMemoryDesc.residencyFraction = 1.0;
		    v58 = v56;
		    *(_QWORD *)&v53.handle._type_k__BackingField = v22;
		    v53.handle.m_Value = (unsigned __int8)v22;
		    *(ResourceHandle *)&v56.fastMemoryDesc.inFastMemory = v53.handle;
		    if ( !renderGraph )
		      goto LABEL_33;
		    v53 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture((TextureHandle *)&v55, renderGraph, &v58, 0LL);
		    v17 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v55,
		            builder,
		            &v53,
		            0,
		            0,
		            0LL);
		  }
		  else
		  {
		    v53 = (TextureHandle)*UnityEngine::Quaternion::get_identity((Quaternion *)&v53, v16);
		    v17 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v55,
		            builder,
		            &input->sceneColor,
		            0,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&v53,
		            0,
		            0LL);
		  }
		  passData->fields.colorBuffer = *v17;
		  v23 = 0;
		  v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		           (TextureHandle *)&v55,
		           builder,
		           &input->sceneDepth,
		           DepthAccess__Enum_Read,
		           0,
		           0LL);
		  p_gBufferOutput = &input->gBufferOutput;
		  passData->fields.depthBuffer = v24;
		  do
		  {
		    gbuffer = passData->fields.gbuffer;
		    GBufferAttachment = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                          (TextureHandle *)&v55,
		                          p_gBufferOutput,
		                          v23,
		                          0LL);
		    if ( !gbuffer )
		      goto LABEL_33;
		    v53 = *GBufferAttachment;
		    sub_180430AC4(gbuffer, v23, &v53);
		    v28 = passData->fields.gbuffer;
		    if ( !v28 )
		      goto LABEL_33;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v29 = (TextureHandle *)sub_1803C0774(v28, v23);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v29, 0LL) )
		    {
		      Patch = (ILFixDynamicMethodWrapper_2 *)passData->fields.gbuffer;
		      if ( !Patch )
		        goto LABEL_33;
		      v30 = (TextureHandle *)sub_1803C0774(Patch, v23);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v54, builder, v30, 0LL);
		    }
		    ++v23;
		    p_gBufferOutput = &input->gBufferOutput;
		  }
		  while ( v23 < 4 );
		  v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		           (TextureHandle *)&v54,
		           builder,
		           &input->sceneDepthCopied,
		           0LL);
		  passData->fields.hgCamera = camera;
		  passData->fields.depthTexture = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&passData->fields.hgCamera, v32, v33, v34, v50);
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_deferredLightingMaterial;
		  if ( !Patch
		    || (shader = UnityEngine::Material::get_shader((Material *)Patch, 0LL),
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		          &keyword,
		          shader,
		          TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfileSimple,
		          0LL),
		        m_deferredLightingMaterial = this->fields.m_deferredLightingMaterial,
		        HasTerrainSimpleSubsurface = HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::HasTerrainSimpleSubsurface(0LL),
		        !m_deferredLightingMaterial) )
		  {
		LABEL_33:
		    sub_1800D8260(Patch, v13);
		  }
		  UnityEngine::Material::SetKeyword(m_deferredLightingMaterial, &keyword, HasTerrainSimpleSubsurface, 0LL);
		  passData->fields.deferredLightingMaterial = this->fields.m_deferredLightingMaterial;
		  sub_18002D1B0((SingleFieldAccessor *)&passData->fields.deferredLightingMaterial, v38, v39, v40, v51);
		  m_deferredLightingWriteAlphaMaterial = this->fields.m_deferredLightingWriteAlphaMaterial;
		  passData->fields.deferredLightingWriteAlphaMaterial = m_deferredLightingWriteAlphaMaterial;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&passData->fields.deferredLightingWriteAlphaMaterial,
		    v42,
		    v43,
		    (Int32__Array **)m_deferredLightingWriteAlphaMaterial,
		    v52);
		  v44 = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		  *(BitArray128 *)&v54.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		  v54.m_RenderGraph = v44;
		  if ( HG::Rendering::Runtime::FrameSettings::IsEnabled((FrameSettings *)&v54, FrameSettingsField__Enum_ShadowMaps, 0LL)
		    || (v45 = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality,
		        *(BitArray128 *)&v54.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas,
		        v54.m_RenderGraph = v45,
		        HG::Rendering::Runtime::FrameSettings::IsEnabled(
		          (FrameSettings *)&v54,
		          FrameSettingsField__Enum_CharacterShadowMaps,
		          0LL)) )
		  {
		    v46 = *(_OWORD *)&builder->m_RenderPass;
		    v47 = *(_OWORD *)&builder->m_RenderGraph;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    *(_OWORD *)&v54.m_RenderPass = v46;
		    *(_OWORD *)&v54.m_RenderGraph = v47;
		    HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v59, &input->shadowResult, &v54, 0LL);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B92F04-0x0000000189B92F58
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DeferredLightingPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3049, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3049, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B92EB0-0x0000000189B92F04
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DeferredLightingPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3050, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3050, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B92C50-0x0000000189B92E5C
		// Void ConstructPass(DeferredLightingPassConstructor+PassInput ByRef, DeferredLightingPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::ConstructPass(
		        DeferredLightingPassConstructor *this,
		        DeferredLightingPassConstructor_PassInput *input,
		        DeferredLightingPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  DeferredLightingPassConstructor_DeferredLightingPassData *v18; // [rsp+40h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v19; // [rsp+48h] [rbp-70h] BYREF
		  HGRenderGraphBuilder v20; // [rsp+50h] [rbp-68h] BYREF
		  HGRenderGraphBuilder v21; // [rsp+70h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v22; // [rsp+90h] [rbp-28h] BYREF
		
		  v18 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3051, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3051, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1135(
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
		            (Int32Enum__Enum)0x90u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v20,
		      renderGraph,
		      (String *)"Deferred Lighting",
		      (Object **)&v18,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
		    v21 = v20;
		    v20.m_RenderPass = 0LL;
		    v20.m_Resources = (HGRenderGraphResourceRegistry *)&v21;
		    try
		    {
		      v22 = v21;
		      HG::Rendering::Runtime::DeferredLightingPassConstructor::PrepareDeferredLightingPass(
		        this,
		        input,
		        renderGraph,
		        camera,
		        &v22,
		        v18,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v21,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor->static_fields->s_fromDeferredLightingToForwardOpaqueRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
		      if ( !v18 )
		        sub_1800D8250(v14, v13);
		      *output = (DeferredLightingPassConstructor_PassOutput)v18->fields.colorBuffer;
		    }
		    catch ( Il2CppExceptionWrapper *v19 )
		    {
		      v20.m_RenderPass = (HGRenderGraphPass *)v19->ex;
		    }
		    sub_180268AE0(&v20);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B92E5C-0x0000000189B92EB0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DeferredLightingPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3052, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3052, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80770-0x0000000184D807A0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DeferredLightingPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3053, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3053, 0LL);
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
