using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class OnePassDeferredPassConstructor : IPassConstructor // TypeDefIndex: 38372
	{
		// Fields
		private const string HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED = "HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED"; // Metadata: 0x02303C87
		private int[] m_attachmentMapping; // 0x10
		private Material m_deferredLightingMaterial; // 0x18
		private Material m_deferredLightingPerLightMeshMaterial; // 0x20
		private Mesh m_sphereMesh; // 0x28
		private Mesh m_coneMesh; // 0x30
		private static DeferredLightingPass.LightMeshDrawRequest[] s_lightMeshDrawRequests; // 0x00
		private static readonly RenderFunc<OnePassDeferredData> s_preDepthRenderFunc; // 0x08
		private static readonly RenderFunc<OnePassDeferredData> s_gBufferRenderFunc; // 0x10
		private static readonly RenderFunc<OnePassDeferredData> s_decalRenderFunc; // 0x18
		private static readonly RenderFunc<OnePassDeferredData> s_deferredLightingRenderFunc; // 0x20
		private static readonly RenderFunc<OnePassDeferredData> s_optForwardOpaqueFunc; // 0x28
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38366
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneDepthCopied; // 0x20
			internal TextureHandle sceneMV; // 0x30
			internal TextureHandle planarReflectionTexture; // 0x40
			internal TextureHandle fogBakeLutTexture; // 0x50
			internal TextureHandle ssrLightingTexture; // 0x60
			internal CullingResults cullingResults; // 0x70
			internal LightCullResult lightCullResult; // 0x80
			internal ShadowResult shadowResult; // 0x90
			internal HGRenderPipeline hgrp; // 0xD0
			internal GBufferOutput gBufferOutput; // 0xD8
			internal bool characterOutlineEnabled; // 0xF8
			internal float screenCullingRatio; // 0xFC
			internal float screenCullingRatioDistance; // 0x100
			internal uint screenCullingLayerMask; // 0x104
			internal uint deferredOpaquePreZECSList; // 0x108
			internal uint forwardOpaquePreZECSList; // 0x10C
			internal uint deferredGrassPreZECSList; // 0x110
			internal uint deferredTreePreZECSList; // 0x114
			internal uint deferredOpaqueECSList; // 0x118
			internal uint deferredOpaqueEqualECSList; // 0x11C
			internal uint deferredGrassECSList; // 0x120
			internal uint deferredTreeECSList; // 0x124
			internal uint deferredSludgeECSList; // 0x128
			internal uint deferredDecalMobileECSList; // 0x12C
			internal uint deferredErosionMobileECSList; // 0x130
			internal uint forwardOpaqueECSList; // 0x134
			internal uint forwardOpaqueEqualECSList; // 0x138
			internal uint characterOpaqueECSList; // 0x13C
			internal uint characterPrePassECSList; // 0x140
			internal uint characterOutlineOpaqueECSRendererList; // 0x144
			internal uint characterOutlineOpaquePreZECSRendererList; // 0x148
			internal uint characterOutlineOpaqueEqualECSRendererList; // 0x14C
			internal ComputeBufferHandle drawTileArgs; // 0x150
			internal ComputeBufferHandle tileInstanceIndices; // 0x158
			internal GraphicsBuffer quadIndexBuffer; // 0x160
			internal int punctualLightCount; // 0x168
			internal unsafe int* punctualLightIndices; // 0x170
			internal bool enableTerrainDecalDeform; // 0x178
			internal bool enableTerrainWetRipple; // 0x179
			internal bool enableTerrainPOM; // 0x17A
		}
	
		internal struct PassOutput // TypeDefIndex: 38367
		{
		}
	
		private class OnePassDeferredData // TypeDefIndex: 38368
		{
			// Fields
			internal bool shouldSplitOnePass; // 0x10
			internal HGCamera camera; // 0x18
			public int vtFeedbackId; // 0x20
			internal int subdivisionHandle; // 0x24
			internal uint terrainCullViewHandle; // 0x28
			internal uint editorTerrainCullViewHandle; // 0x2C
			internal bool enableTerrainDecalDeform; // 0x30
			internal bool enableTerrainWetRipple; // 0x31
			internal bool enableTerrainPOM; // 0x32
			internal TextureHandle planarReflectionTexture; // 0x34
			internal TextureHandle fogBakeLutTexture; // 0x44
			internal TextureHandle ssrLightingTexture; // 0x54
			internal TextureHandle sceneDepthCopied; // 0x64
			internal TextureHandle[] gbuffer; // 0x78
			internal RendererListHandle preDepthRendererList; // 0x80
			internal RendererListHandle characterPrePassRendererList; // 0x88
			internal RendererListHandle gBufferRendererList; // 0x90
			internal RendererListHandle erosionMobileRendererList; // 0x98
			internal uint deferredOpaquePreZECSList; // 0xA0
			internal uint forwardOpaquePreZECSList; // 0xA4
			internal uint deferredGrassPreZECSList; // 0xA8
			internal uint deferredTreePreZECSList; // 0xAC
			internal uint deferredOpaqueECSList; // 0xB0
			internal uint deferredOpaqueEqualECSList; // 0xB4
			internal uint deferredGrassECSList; // 0xB8
			internal uint deferredTreeECSList; // 0xBC
			internal uint deferredSludgeECSList; // 0xC0
			internal uint deferredDecalMobileECSList; // 0xC4
			internal uint deferredErosionMobileECSList; // 0xC8
			internal uint characterOpaqueECSList; // 0xCC
			internal uint characterPrePassECSList; // 0xD0
			internal uint characterOutlineOpaqueECSRendererList; // 0xD4
			internal uint characterOutlineOpaquePreZECSRendererList; // 0xD8
			internal uint characterOutlineOpaqueEqualECSRendererList; // 0xDC
			internal DeferredLightingPass.DeferredLightingRenderParams deferredLightingParams; // 0xE0
			internal Material deferredLightingMaterial; // 0x108
			internal Material deferredLightingPerLightMaterial; // 0x110
			internal Mesh sphereMesh; // 0x118
			internal Mesh coneMesh; // 0x120
			internal int punctualLightCount; // 0x128
			internal DeferredLightingPass.LightMeshDrawRequest[] lightMeshDrawRequests; // 0x130
			internal ForwardPassUtils.ForwardOpaquePassData opaqueData; // 0x138
	
			// Constructors
			public OnePassDeferredData() {} // 0x0000000189BBEFA0-0x0000000189BBF010
			// OnePassDeferredPassConstructor+OnePassDeferredData()
			void HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData::OnePassDeferredData(
			        OnePassDeferredPassConstructor_OnePassDeferredData *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  ForwardPassUtils_ForwardOpaquePassData *v6; // rax
			  HGRuntimeGrassQuery_Node *v7; // rdx
			  __int64 v8; // rcx
			  HGRuntimeGrassQuery_Node *v9; // r8
			  Int32__Array **v10; // r9
			  MethodInfo *v11; // [rsp+20h] [rbp-8h]
			  MethodInfo *v12; // [rsp+50h] [rbp+28h]
			
			  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			  this->fields.gbuffer = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                   TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                   TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->static_fields->kMaxMRTCount);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.gbuffer, v3, v4, v5, v11);
			  v6 = (ForwardPassUtils_ForwardOpaquePassData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::ForwardPassUtils::ForwardOpaquePassData);
			  if ( !v6 )
			    sub_1800D8260(v8, v7);
			  this->fields.opaqueData = v6;
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.opaqueData, v7, v9, v10, v12);
			}
			
		}
	
		private enum OnePassDeferredSubpass // TypeDefIndex: 38369
		{
			PreDepth = 0,
			GBuffer = 1,
			Decal = 2,
			PostGBuffer = 3,
			DeferredLighting = 4,
			ForwardOpaque = 5,
			ForwardTransparent = 6,
			Count = 7
		}
	
		private enum FixedAttachment // TypeDefIndex: 38370
		{
			SceneColor = 0,
			MotionVector = 1,
			Count = 2
		}
	
		// Constructors
		public OnePassDeferredPassConstructor() {} // Dummy constructor
		internal OnePassDeferredPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000189BC220C-0x0000000189BC235C
		// OnePassDeferredPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredPassConstructor(
		        OnePassDeferredPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRenderPipelineRuntimeResources *defaultResources; // rdx
		  Material *m_deferredLightingPerLightMeshMaterial; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *v24; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *v25; // rbx
		  Shader *skillScanLinePS; // rbx
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+20h] [rbp-8h]
		  MethodInfo *v30; // [rsp+20h] [rbp-8h]
		  MethodInfo *v31; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_attachmentMapping = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v27);
		  if ( !resources->defaultResources )
		    goto LABEL_14;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_14;
		  if ( !materialCollector )
		    goto LABEL_14;
		  this->fields.m_deferredLightingMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                              materialCollector,
		                                              shaders->fields.deferredPS,
		                                              0,
		                                              0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_deferredLightingMaterial, v13, v14, v15, v28);
		  defaultResources = resources->defaultResources;
		  if ( !resources->defaultResources )
		    goto LABEL_14;
		  defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders;
		  if ( !defaultResources )
		    goto LABEL_14;
		  this->fields.m_deferredLightingPerLightMeshMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                          materialCollector,
		                                                          (Shader *)defaultResources[1].fields._._._._.m_CachedPtr,
		                                                          0,
		                                                          0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_deferredLightingPerLightMeshMaterial, v16, v17, v18, v29);
		  m_deferredLightingPerLightMeshMaterial = this->fields.m_deferredLightingPerLightMeshMaterial;
		  if ( !m_deferredLightingPerLightMeshMaterial )
		    goto LABEL_14;
		  UnityEngine::Material::set_enableInstancing(m_deferredLightingPerLightMeshMaterial, 1, 0LL);
		  if ( !resources->defaultResources
		    || (assets = resources->defaultResources->fields.assets) == 0LL
		    || (this->fields.m_sphereMesh = assets->fields.simpleSphereMesh,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_sphereMesh,
		          (HGRuntimeGrassQuery_Node *)defaultResources,
		          v19,
		          v20,
		          v30),
		        !resources->defaultResources)
		    || (v24 = resources->defaultResources->fields.assets) == 0LL
		    || (this->fields.m_coneMesh = v24->fields.defaultConeMesh,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_coneMesh,
		          (HGRuntimeGrassQuery_Node *)defaultResources,
		          v22,
		          v23,
		          v31),
		        !resources->defaultResources)
		    || (v25 = resources->defaultResources->fields.shaders) == 0LL )
		  {
		LABEL_14:
		    sub_1800D8260(m_deferredLightingPerLightMeshMaterial, defaultResources);
		  }
		  skillScanLinePS = v25->fields.skillScanLinePS;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		  HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(skillScanLinePS, 0LL);
		}
		
		static OnePassDeferredPassConstructor() {} // 0x0000000189BC1FB0-0x0000000189BC220C
		// OnePassDeferredPassConstructor()
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  Object *v5; // rdi
		  RenderFunc_1_System_Object_ *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MonitorData *v9; // rbx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Object *v13; // rdi
		  RenderFunc_1_System_Object_ *v14; // rax
		  RenderFunc_1_HG_Rendering_Runtime_OnePassDeferredPassConstructor_OnePassDeferredData_ *v15; // rbx
		  OnePassDeferredPassConstructor__StaticFields *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  Object *v19; // rdi
		  RenderFunc_1_System_Object_ *v20; // rax
		  RenderFunc_1_HG_Rendering_Runtime_OnePassDeferredPassConstructor_OnePassDeferredData_ *v21; // rbx
		  OnePassDeferredPassConstructor__StaticFields *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  Object *v25; // rdi
		  RenderFunc_1_System_Object_ *v26; // rax
		  RenderFunc_1_HG_Rendering_Runtime_OnePassDeferredPassConstructor_OnePassDeferredData_ *v27; // rbx
		  OnePassDeferredPassConstructor__StaticFields *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  Object *v31; // rdi
		  RenderFunc_1_System_Object_ *v32; // rax
		  HGRuntimeGrassQuery_Node *v33; // rbx
		  HGRuntimeGrassQuery_Node *v34; // rdx
		  HGRuntimeGrassQuery_Node *v35; // r8
		  Int32__Array **v36; // r9
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		  MethodInfo *v41; // [rsp+20h] [rbp-8h]
		  MethodInfo *v42; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass::LightMeshDrawRequest, 32LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v37);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c);
		  v5 = (Object *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c->static_fields->__9;
		  v6 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
		  v9 = (MonitorData *)v6;
		  if ( !v6 )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v6,
		    v5,
		    MethodInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c::__cctor_b__33_0,
		    0LL);
		  v10 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields;
		  v10->monitor = v9;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_preDepthRenderFunc,
		    v10,
		    v11,
		    v12,
		    v38);
		  v13 = (Object *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c->static_fields->__9;
		  v14 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
		  v15 = (RenderFunc_1_HG_Rendering_Runtime_OnePassDeferredPassConstructor_OnePassDeferredData_ *)v14;
		  if ( !v14 )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v14,
		    v13,
		    MethodInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c::__cctor_b__33_1,
		    0LL);
		  v16 = TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields;
		  v16->s_gBufferRenderFunc = v15;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_gBufferRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v16,
		    v17,
		    v18,
		    v39);
		  v19 = (Object *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c->static_fields->__9;
		  v20 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
		  v21 = (RenderFunc_1_HG_Rendering_Runtime_OnePassDeferredPassConstructor_OnePassDeferredData_ *)v20;
		  if ( !v20 )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v20,
		    v19,
		    MethodInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c::__cctor_b__33_2,
		    0LL);
		  v22 = TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields;
		  v22->s_decalRenderFunc = v21;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_decalRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v22,
		    v23,
		    v24,
		    v40);
		  v25 = (Object *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c->static_fields->__9;
		  v26 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
		  v27 = (RenderFunc_1_HG_Rendering_Runtime_OnePassDeferredPassConstructor_OnePassDeferredData_ *)v26;
		  if ( !v26
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v26,
		          v25,
		          MethodInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c::__cctor_b__33_3,
		          0LL),
		        v28 = TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields,
		        v28->s_deferredLightingRenderFunc = v27,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_deferredLightingRenderFunc,
		          (HGRuntimeGrassQuery_Node *)v28,
		          v29,
		          v30,
		          v41),
		        v31 = (Object *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c->static_fields->__9,
		        v32 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>),
		        (v33 = (HGRuntimeGrassQuery_Node *)v32) == 0LL) )
		  {
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v32,
		    v31,
		    MethodInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor::__c::__cctor_b__33_4,
		    0LL);
		  v34 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields;
		  v34->fields.parent = v33;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_optForwardOpaqueFunc,
		    v34,
		    v35,
		    v36,
		    v42);
		}
		
	
		// Methods
		private ValueTuple<int, int> SetupRenderTarget(ref PassInput input, HGRenderGraphBuilder builder, bool mvClearColor = false /* Metadata: 0x02303C85 */) => default; // 0x0000000189BBFEA4-0x0000000189BC00C4
		// ValueTuple`2[Int32,Int32] SetupRenderTarget(OnePassDeferredPassConstructor+PassInput ByRef, HGRenderGraphBuilder, Boolean)
		ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_PassInput *input,
		        HGRenderGraphBuilder *builder,
		        bool mvClearColor,
		        MethodInfo *method)
		{
		  unsigned int v9; // r12d
		  int32_t v10; // r14d
		  int v11; // r15d
		  int32_t v12; // r8d
		  TextureHandle *p_sceneMV; // r8
		  int32_t v14; // esi
		  GBufferOutput *p_gBufferOutput; // rdi
		  int32_t v16; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int128 v21; // xmm1
		  TextureHandle si128; // [rsp+40h] [rbp-40h] BYREF
		  TextureHandle v23; // [rsp+50h] [rbp-30h] BYREF
		  HGRenderGraphBuilder v24; // [rsp+60h] [rbp-20h] BYREF
		
		  v9 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3268, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3268, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    v21 = *(_OWORD *)&builder->m_RenderGraph;
		    *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v24.m_RenderGraph = v21;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1202(Patch, (Object *)this, input, &v24, mvClearColor, 0LL);
		  }
		  else
		  {
		    v10 = 1;
		    v11 = 1;
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		      &si128,
		      builder,
		      &input->sceneColor,
		      0,
		      0,
		      0LL);
		    HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		      this,
		      OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		      0,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		    {
		      p_sceneMV = &input->sceneMV;
		      if ( mvClearColor )
		      {
		        si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18DC80F80);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v23,
		          builder,
		          p_sceneMV,
		          1,
		          (Color *)&si128,
		          0,
		          0LL);
		      }
		      else
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &si128,
		          builder,
		          p_sceneMV,
		          1,
		          0,
		          0LL);
		      }
		      v11 = 2;
		      v10 = 2;
		      v12 = 1;
		    }
		    else
		    {
		      v12 = -1;
		    }
		    HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		      this,
		      OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		      v12,
		      0LL);
		    v14 = 0;
		    p_gBufferOutput = &input->gBufferOutput;
		    do
		    {
		      si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v23, p_gBufferOutput, v14, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&si128, 0LL) )
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v24,
		          builder,
		          &si128,
		          v10,
		          0,
		          0LL);
		        v16 = v10++;
		        ++v9;
		      }
		      else
		      {
		        v16 = -1;
		      }
		      HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(this, (GBufferID__Enum)v14++, v16, 0LL);
		    }
		    while ( v14 < 4 );
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		      (TextureHandle *)&v24,
		      builder,
		      &input->sceneDepth,
		      DepthAccess__Enum_ReadWrite,
		      0,
		      0LL);
		    si128.handle = (ResourceHandle)__PAIR64__(v9, v11);
		    return (ValueTuple_2_Int32_Int32_)__PAIR64__(v9, v11);
		  }
		}
		
		private void SetupSubpass(OnePassDeferredSubpass subpass, int fixedAttachmentCount, int gBufferAttachmentCount, out NativeArray<int> outputIndices, out NativeArray<int> inputIndices, out bool depthAsInput, bool shouldSplitOnePass = false /* Metadata: 0x02303C86 */) {
			outputIndices = default;
			inputIndices = default;
			depthAsInput = default;
		} // 0x0000000189BC00C4-0x0000000189BC05DC
		// Void SetupSubpass(OnePassDeferredPassConstructor+OnePassDeferredSubpass, Int32, Int32, NativeArray`1[System.Int32] ByRef, NativeArray`1[System.Int32] ByRef, Boolean ByRef, Boolean)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum subpass,
		        int32_t fixedAttachmentCount,
		        int32_t gBufferAttachmentCount,
		        NativeArray_1_System_Int32_ *outputIndices,
		        NativeArray_1_System_Int32_ *inputIndices,
		        bool *depthAsInput,
		        bool shouldSplitOnePass,
		        MethodInfo *method)
		{
		  GBufferID__Enum v13; // edi
		  unsigned __int32 v14; // ebx
		  unsigned __int32 v15; // ebx
		  unsigned __int32 v16; // ebx
		  unsigned __int32 v17; // ebx
		  unsigned __int32 v18; // ebx
		  int32_t AttachmentIndex; // eax
		  __int64 v20; // rbx
		  int32_t v21; // eax
		  __int64 v22; // rdx
		  int32_t v23; // eax
		  __int64 v24; // rbx
		  int32_t v25; // eax
		  __int64 v26; // rdx
		  int32_t v27; // edx
		  int32_t v28; // eax
		  __int64 v29; // rbx
		  int32_t v30; // eax
		  __int64 v31; // rdx
		  int32_t v32; // eax
		  __int64 v33; // rbx
		  int32_t v34; // eax
		  __int64 v35; // rdx
		  __int64 v36; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int32_t v38; // [rsp+50h] [rbp-20h]
		  NativeArray_1_System_Int32_ v39; // [rsp+58h] [rbp-18h] BYREF
		
		  v13 = GBufferID__Enum_GBufferA;
		  if ( IFix::WrappersManagerImpl::IsPatched(3271, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3271, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v36);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1205(
		      Patch,
		      (Object *)this,
		      subpass,
		      fixedAttachmentCount,
		      gBufferAttachmentCount,
		      outputIndices,
		      inputIndices,
		      depthAsInput,
		      shouldSplitOnePass,
		      0LL);
		  }
		  else
		  {
		    *depthAsInput = 0;
		    if ( subpass == OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_PreDepth )
		    {
		      v39 = 0LL;
		      Unity::Collections::NativeArray<int>::NativeArray(
		        &v39,
		        0,
		        Allocator__Enum_Temp,
		        NativeArrayOptions__Enum_ClearMemory,
		        MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		      goto LABEL_10;
		    }
		    v14 = subpass - 1;
		    if ( v14 )
		    {
		      v15 = v14 - 1;
		      if ( v15 && (v16 = v15 - 1) != 0 )
		      {
		        v17 = v16 - 1;
		        v39 = 0LL;
		        if ( v17 )
		        {
		          v18 = v17 - 1;
		          if ( v18 )
		          {
		            if ( v18 != 1 )
		            {
		              Unity::Collections::NativeArray<int>::NativeArray(
		                &v39,
		                0,
		                Allocator__Enum_Temp,
		                NativeArrayOptions__Enum_ClearMemory,
		                MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		LABEL_10:
		              *outputIndices = v39;
		              v39 = 0LL;
		              Unity::Collections::NativeArray<int>::NativeArray(
		                &v39,
		                0,
		                Allocator__Enum_Temp,
		                NativeArrayOptions__Enum_ClearMemory,
		                MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		              *inputIndices = v39;
		              return;
		            }
		            Unity::Collections::NativeArray<int>::NativeArray(
		              &v39,
		              fixedAttachmentCount,
		              Allocator__Enum_Temp,
		              NativeArrayOptions__Enum_ClearMemory,
		              MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		            *outputIndices = v39;
		            v39 = 0LL;
		            Unity::Collections::NativeArray<int>::NativeArray(
		              &v39,
		              gBufferAttachmentCount,
		              Allocator__Enum_Temp,
		              NativeArrayOptions__Enum_ClearMemory,
		              MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		            *inputIndices = v39;
		            *(_DWORD *)outputIndices->m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                                                   this,
		                                                   OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		                                                   0LL);
		            AttachmentIndex = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                                this,
		                                OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		                                0LL);
		            if ( AttachmentIndex != -1 )
		              *(_DWORD *)&outputIndices->m_Buffer[4] = AttachmentIndex;
		            v20 = 0LL;
		            do
		            {
		              v21 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v13, 0LL);
		              if ( v21 == -1 )
		              {
		                if ( v13 == GBufferID__Enum_GBufferDepth )
		                  goto LABEL_38;
		              }
		              else
		              {
		                v22 = v20++;
		                *(_DWORD *)&inputIndices->m_Buffer[4 * v22] = v21;
		              }
		              ++v13;
		            }
		            while ( (int)v13 < (int)GBufferID__Enum_Count );
		          }
		          else
		          {
		            Unity::Collections::NativeArray<int>::NativeArray(
		              &v39,
		              fixedAttachmentCount,
		              Allocator__Enum_Temp,
		              NativeArrayOptions__Enum_ClearMemory,
		              MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		            *outputIndices = v39;
		            v39 = 0LL;
		            Unity::Collections::NativeArray<int>::NativeArray(
		              &v39,
		              0,
		              Allocator__Enum_Temp,
		              NativeArrayOptions__Enum_ClearMemory,
		              MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		            *inputIndices = v39;
		            *(_DWORD *)outputIndices->m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                                                   this,
		                                                   OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		                                                   0LL);
		            v23 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                    this,
		                    OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		                    0LL);
		            if ( v23 != -1 )
		              *(_DWORD *)&outputIndices->m_Buffer[4] = v23;
		          }
		        }
		        else
		        {
		          Unity::Collections::NativeArray<int>::NativeArray(
		            &v39,
		            gBufferAttachmentCount,
		            Allocator__Enum_Temp,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		          *inputIndices = v39;
		          v39 = 0LL;
		          Unity::Collections::NativeArray<int>::NativeArray(
		            &v39,
		            1,
		            Allocator__Enum_Temp,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		          *outputIndices = v39;
		          *(_DWORD *)outputIndices->m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                                                 this,
		                                                 OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		                                                 0LL);
		          if ( !shouldSplitOnePass )
		          {
		            v24 = 0LL;
		            do
		            {
		              v25 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v13, 0LL);
		              if ( v25 == -1 )
		              {
		                if ( v13 == GBufferID__Enum_GBufferDepth )
		                  goto LABEL_38;
		              }
		              else
		              {
		                v26 = v24++;
		                *(_DWORD *)&inputIndices->m_Buffer[4 * v26] = v25;
		              }
		              ++v13;
		            }
		            while ( (int)v13 < (int)GBufferID__Enum_Count );
		          }
		        }
		      }
		      else
		      {
		        v38 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                this,
		                GBufferID__Enum_GBufferDepth,
		                0LL);
		        v27 = gBufferAttachmentCount + fixedAttachmentCount;
		        if ( v38 != -1 )
		          v27 = gBufferAttachmentCount + fixedAttachmentCount - 1;
		        v39 = 0LL;
		        Unity::Collections::NativeArray<int>::NativeArray(
		          &v39,
		          v27,
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		        *outputIndices = v39;
		        *(_DWORD *)outputIndices->m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                                               this,
		                                               OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		                                               0LL);
		        v28 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                this,
		                OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		                0LL);
		        v29 = 1LL;
		        if ( v28 != -1 )
		        {
		          v29 = 2LL;
		          *(_DWORD *)&outputIndices->m_Buffer[4] = v28;
		        }
		        do
		        {
		          if ( v13 != GBufferID__Enum_GBufferDepth )
		          {
		            v30 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v13, 0LL);
		            if ( v30 != -1 )
		            {
		              v31 = v29++;
		              *(_DWORD *)&outputIndices->m_Buffer[4 * v31] = v30;
		            }
		          }
		          ++v13;
		        }
		        while ( (int)v13 < (int)GBufferID__Enum_Count );
		        v39 = 0LL;
		        if ( v38 == -1 )
		        {
		          Unity::Collections::NativeArray<int>::NativeArray(
		            &v39,
		            0,
		            Allocator__Enum_Temp,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		          *inputIndices = v39;
		LABEL_38:
		          *depthAsInput = 1;
		        }
		        else
		        {
		          Unity::Collections::NativeArray<int>::NativeArray(
		            &v39,
		            1,
		            Allocator__Enum_Temp,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		          *inputIndices = v39;
		          *(_DWORD *)inputIndices->m_Buffer = v38;
		        }
		      }
		    }
		    else
		    {
		      v39 = 0LL;
		      Unity::Collections::NativeArray<int>::NativeArray(
		        &v39,
		        gBufferAttachmentCount + fixedAttachmentCount,
		        Allocator__Enum_Temp,
		        NativeArrayOptions__Enum_ClearMemory,
		        MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		      *outputIndices = v39;
		      v39 = 0LL;
		      Unity::Collections::NativeArray<int>::NativeArray(
		        &v39,
		        0,
		        Allocator__Enum_Temp,
		        NativeArrayOptions__Enum_ClearMemory,
		        MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		      *inputIndices = v39;
		      *(_DWORD *)outputIndices->m_Buffer = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		                                             this,
		                                             OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		                                             0LL);
		      v32 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		              this,
		              OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		              0LL);
		      v33 = 1LL;
		      if ( v32 != -1 )
		      {
		        v33 = 2LL;
		        *(_DWORD *)&outputIndices->m_Buffer[4] = v32;
		      }
		      do
		      {
		        v34 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(this, v13, 0LL);
		        if ( v34 != -1 )
		        {
		          v35 = v33++;
		          *(_DWORD *)&outputIndices->m_Buffer[4 * v35] = v34;
		        }
		        ++v13;
		      }
		      while ( (int)v13 < (int)GBufferID__Enum_Count );
		    }
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBFD4C-0x0000000189BBFDA0
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        OnePassDeferredPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3274, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3274, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBFCF8-0x0000000189BBFD4C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        OnePassDeferredPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3275, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3275, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBF424-0x0000000189BBFB6C
		// Void ConstructPass(OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPass(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_PassInput *input,
		        OnePassDeferredPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *P3; // r12
		  OnePassDeferredPassConstructor_PassInput *v8; // rsi
		  Object *v9; // r15
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rbx
		  bool v14; // r13
		  ProfilingSampler *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int v18; // r8d
		  ValueTuple_2_Int32_Int32_ v19; // rdx
		  ValueTuple_2_Int32_Int32_ v20; // rcx
		  ValueTuple_2_Int32_Int32_ v21; // rbx
		  TextureHandle sceneDepth; // xmm8
		  TextureHandle sceneDepthCopied; // xmm7
		  ProfilingSampler *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  OnePassDeferredPassConstructor_OnePassDeferredData *v29; // rbx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  TextureHandle v32; // xmm0
		  int32_t i; // ebx
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __int64 v36; // rdx
		  TextureHandle *v37; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  int32_t v41; // [rsp+64h] [rbp-144h] BYREF
		  unsigned int v42; // [rsp+68h] [rbp-140h]
		  int v43; // [rsp+6Ch] [rbp-13Ch]
		  int32_t v44; // [rsp+70h] [rbp-138h] BYREF
		  OnePassDeferredPassConstructor_OnePassDeferredData *v45; // [rsp+78h] [rbp-130h] BYREF
		  TextureHandle v46; // [rsp+80h] [rbp-128h] BYREF
		  OnePassDeferredPassConstructor_OnePassDeferredData *v47; // [rsp+90h] [rbp-118h] BYREF
		  TextureHandle v48; // [rsp+A0h] [rbp-108h] BYREF
		  HGRenderGraphBuilder v49; // [rsp+B0h] [rbp-F8h] BYREF
		  TextureHandle v50; // [rsp+D0h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v51; // [rsp+E0h] [rbp-C8h] BYREF
		  HGRenderGraphBuilder v52; // [rsp+100h] [rbp-A8h] BYREF
		  Il2CppExceptionWrapper *v53; // [rsp+120h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+128h] [rbp-80h] BYREF
		  TextureHandle v55; // [rsp+130h] [rbp-78h] BYREF
		
		  P3 = (Object *)renderGraph;
		  v8 = input;
		  v9 = (Object *)this;
		  memset(&v51, 0, sizeof(v51));
		  v47 = 0LL;
		  v41 = 0;
		  v45 = 0LL;
		  v44 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3276, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3276, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v40, v39);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1208(Patch, v9, v8, output, P3, (Object *)camera, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( !currentPipeline )
		      sub_1800D8260(v12, v11);
		    settingParameters_k__BackingField = currentPipeline->fields._settingParameters_k__BackingField;
		    if ( !settingParameters_k__BackingField )
		      sub_1800D8260(v12, v11);
		    v14 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            settingParameters_k__BackingField->fields._shouldSplitOnePass_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x17u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !P3 )
		      sub_1800D8260(v17, v16);
		    v51 = *(HGRenderGraphBuilder *)sub_1808AF7F8((unsigned int)&v49, (_DWORD)P3, v18, (unsigned int)&v47, (__int64)v15);
		    v48.handle = 0LL;
		    v48.fallBackResource = (ResourceHandle)&v51;
		    try
		    {
		      v49 = v51;
		      v21 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(
		              (OnePassDeferredPassConstructor *)v9,
		              v8,
		              &v49,
		              1,
		              0LL);
		      if ( !v47 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v20, v19);
		      v47->fields.shouldSplitOnePass = v14;
		      v49 = v51;
		      HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase0(
		        (OnePassDeferredPassConstructor *)v9,
		        &v49,
		        v8,
		        output,
		        &v41,
		        v47,
		        (HGRenderGraph *)P3,
		        camera,
		        v21,
		        0LL);
		      if ( !v14 )
		      {
		        v49 = v51;
		        HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
		          (OnePassDeferredPassConstructor *)v9,
		          &v49,
		          v8,
		          output,
		          &v41,
		          v47,
		          (HGRenderGraph *)P3,
		          camera,
		          v21,
		          0,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v53 )
		    {
		      v48.handle = (ResourceHandle)v53->ex;
		      sub_180268AE0(&v48);
		      P3 = (Object *)renderGraph;
		      v8 = input;
		      v9 = (Object *)this;
		      goto LABEL_10;
		    }
		    sub_180268AE0(&v48);
		LABEL_10:
		    if ( v14 )
		    {
		      sceneDepth = v8->sceneDepth;
		      sceneDepthCopied = v8->sceneDepthCopied;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		      v46 = 0LL;
		      v50 = sceneDepthCopied;
		      v48 = sceneDepth;
		      HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		        (HGRenderGraph *)P3,
		        &v48,
		        &v50,
		        0,
		        -1,
		        0,
		        (Rect *)&v46,
		        0,
		        0LL);
		      v24 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x17u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !P3 )
		        sub_1800D8250(v26, v25);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v49,
		        (HGRenderGraph *)P3,
		        (String *)"One Pass Deferred",
		        (Object **)&v45,
		        v24,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredData>);
		      v52 = v49;
		      v50.handle = 0LL;
		      v50.fallBackResource = (ResourceHandle)&v52;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v52, 0, 0LL);
		        v42 = 1;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v46,
		          &v52,
		          &v8->sceneColor,
		          0,
		          0,
		          0LL);
		        HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		          (OnePassDeferredPassConstructor *)v9,
		          OnePassDeferredPassConstructor_FixedAttachment__Enum_SceneColor,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v8->sceneMV, 0LL) )
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v46,
		            &v52,
		            &v8->sceneMV,
		            1,
		            0,
		            0LL);
		          v42 = 2;
		          HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		            (OnePassDeferredPassConstructor *)v9,
		            OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		            1,
		            0LL);
		        }
		        else
		        {
		          HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		            (OnePassDeferredPassConstructor *)v9,
		            OnePassDeferredPassConstructor_FixedAttachment__Enum_MotionVector,
		            -1,
		            0LL);
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          &v46,
		          &v52,
		          &v8->sceneDepth,
		          DepthAccess__Enum_ReadWrite,
		          0,
		          0LL);
		        if ( !v45 )
		          sub_1800D8250(v28, v27);
		        v45->fields.shouldSplitOnePass = v14;
		        v29 = v45;
		        v32 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 &v46,
		                 &v52,
		                 &v8->sceneDepthCopied,
		                 0LL);
		        if ( !v29 )
		          sub_1800D8250(v31, v30);
		        v29->fields.sceneDepthCopied = v32;
		        for ( i = 0; i < 4; ++i )
		        {
		          v46 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v55, &v8->gBufferOutput, i, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v46, 0LL) && i != 3 )
		          {
		            if ( !v45 )
		              sub_1800D8250(v35, v34);
		            v48.handle = (ResourceHandle)v45->fields.gbuffer;
		            v37 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                    (TextureHandle *)&v49,
		                    &v52,
		                    &v46,
		                    0LL);
		            if ( !*(_QWORD *)&v48.handle )
		              sub_1800D8250(v37, v36);
		            v46 = *v37;
		            sub_180430AC4(*(_QWORD *)&v48.handle, i, &v46);
		          }
		        }
		        v44 = 0;
		        v43 = 0;
		        v49 = v52;
		        HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
		          (OnePassDeferredPassConstructor *)v9,
		          &v49,
		          v8,
		          output,
		          &v44,
		          v45,
		          (HGRenderGraph *)P3,
		          camera,
		          (ValueTuple_2_Int32_Int32_)v42,
		          v14,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v54 )
		      {
		        v50.handle = (ResourceHandle)v54->ex;
		        sub_180268AE0(&v50);
		        return;
		      }
		      sub_180268AE0(&v50);
		    }
		  }
		}
		
		private void _ConstructPassPhase0(HGRenderGraphBuilder builder, ref PassInput input, ref PassOutput output, ref int subpassIndex, OnePassDeferredData passData, HGRenderGraph renderGraph, HGCamera camera, ValueTuple<int, int> count) {} // 0x0000000189BC05DC-0x0000000189BC1190
		// Void _ConstructPassPhase0(HGRenderGraphBuilder, OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, Int32 ByRef, OnePassDeferredPassConstructor+OnePassDeferredData, HGRenderGraph, HGCamera, ValueTuple`2[Int32,Int32])
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase0(
		        OnePassDeferredPassConstructor *this,
		        HGRenderGraphBuilder *builder,
		        OnePassDeferredPassConstructor_PassInput *input,
		        OnePassDeferredPassConstructor_PassOutput *output,
		        int32_t *subpassIndex,
		        OnePassDeferredPassConstructor_OnePassDeferredData *passData,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        ValueTuple_2_Int32_Int32_ count,
		        MethodInfo *method)
		{
		  __int64 static_fields; // rdx
		  void *preZ; // rcx
		  HGRenderGraph *v16; // xmm1_8
		  HGRenderGraph *v17; // xmm1_8
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  __int128 v20; // xmm6
		  __int128 v21; // xmm7
		  bool enabledForCPUCommands; // bl
		  bool v23; // si
		  bool v24; // al
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // ebx
		  Camera *v28; // r8
		  RendererListDesc *v29; // rax
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int128 v42; // xmm1
		  RendererListHandle InvalidHandle; // rax
		  CullingResults cullingResults; // xmm6
		  Camera *v45; // rsi
		  float v46; // xmm8_4
		  float v47; // xmm7_4
		  uint32_t v48; // edi
		  HGShaderPassNames__StaticFields *v49; // rbx
		  ShaderTagId v50; // r9d
		  RendererListDesc *v51; // rax
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  __int128 v54; // xmm1
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  __int128 v59; // xmm0
		  __int128 v60; // xmm1
		  __int128 v61; // xmm0
		  __int128 v62; // xmm1
		  __int128 v63; // xmm0
		  __int128 v64; // xmm1
		  RendererListHandle v65; // rax
		  PerObjectData__Enum PerObjectDataConfig; // eax
		  CullingResults v67; // xmm6
		  Camera *v68; // rsi
		  float v69; // xmm8_4
		  float v70; // xmm7_4
		  uint32_t v71; // edi
		  HGShaderPassNames__StaticFields *v72; // rbx
		  ShaderTagId v73; // r9d
		  RendererListDesc *v74; // rax
		  __int128 v75; // xmm1
		  __int128 v76; // xmm0
		  __int128 v77; // xmm1
		  __int128 v78; // xmm0
		  __int128 v79; // xmm1
		  __int128 v80; // xmm0
		  __int128 v81; // xmm1
		  __int128 v82; // xmm0
		  __int128 v83; // xmm1
		  __int128 v84; // xmm0
		  __int128 v85; // xmm1
		  __int128 v86; // xmm0
		  __int128 v87; // xmm1
		  RendererListHandle v88; // rax
		  RendererListHandle v89; // rax
		  bool v90; // zf
		  CullingResults v91; // xmm6
		  Camera *v92; // rsi
		  float v93; // xmm8_4
		  float v94; // xmm7_4
		  uint32_t v95; // edi
		  HGShaderPassNames__StaticFields *v96; // rbx
		  ShaderTagId v97; // r9d
		  RendererListDesc *v98; // rax
		  __int128 v99; // xmm1
		  __int128 v100; // xmm0
		  __int128 v101; // xmm1
		  __int128 v102; // xmm0
		  __int128 v103; // xmm1
		  __int128 v104; // xmm0
		  __int128 v105; // xmm1
		  __int128 v106; // xmm0
		  __int128 v107; // xmm1
		  __int128 v108; // xmm0
		  __int128 v109; // xmm1
		  __int128 v110; // xmm0
		  __int128 v111; // xmm1
		  RendererListHandle v112; // rax
		  NativeArray_1_System_Int32_ v113; // xmm7
		  NativeArray_1_System_Int32_ v114; // xmm6
		  char v115; // di
		  int32_t v116; // esi
		  int32_t v117; // edx
		  NativeArray_1_System_Int32_ v118; // xmm1
		  int32_t v119; // edx
		  NativeArray_1_System_Int32_ v120; // xmm1
		  __int128 v121; // xmm1
		  MethodInfo *outputIndices; // [rsp+28h] [rbp-E0h]
		  bool depthAsInput[8]; // [rsp+78h] [rbp-90h] BYREF
		  RendererListHandle inputa; // [rsp+80h] [rbp-88h] BYREF
		  NativeArray_1_System_Int32_ v125; // [rsp+88h] [rbp-80h] BYREF
		  Void *v126; // [rsp+98h] [rbp-70h]
		  HGRenderGraphBuilder v127; // [rsp+A8h] [rbp-60h] BYREF
		  PerObjectData__Enum v128; // [rsp+C8h] [rbp-40h]
		  NativeArray_1_System_Int32_ v129; // [rsp+D8h] [rbp-30h] BYREF
		  NativeArray_1_System_Int32_ inputIndices; // [rsp+E8h] [rbp-20h] BYREF
		  NativeArray_1_System_Int32_ v131; // [rsp+F8h] [rbp-10h] BYREF
		  NativeArray_1_System_Int32_ v132; // [rsp+108h] [rbp+0h] BYREF
		  NativeArray_1_System_Int32_ v133; // [rsp+118h] [rbp+10h] BYREF
		  NativeArray_1_System_Int32_ v134; // [rsp+128h] [rbp+20h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v135; // [rsp+138h] [rbp+30h] BYREF
		  RendererListDesc desc; // [rsp+1A8h] [rbp+A0h] BYREF
		  RendererListDesc v137; // [rsp+288h] [rbp+180h] BYREF
		
		  depthAsInput[0] = 0;
		  depthAsInput[1] = 0;
		  depthAsInput[2] = 0;
		  v129 = 0LL;
		  inputIndices = 0LL;
		  v132 = 0LL;
		  v131 = 0LL;
		  v134 = 0LL;
		  v133 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3278, 0LL) )
		  {
		    if ( camera )
		    {
		      v16 = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		      *(BitArray128 *)&v127.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		      v127.m_RenderGraph = v16;
		      if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		             (FrameSettings *)&v127,
		             FrameSettingsField__Enum_ShadowMaps,
		             0LL)
		        || (v17 = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality,
		            *(BitArray128 *)&v127.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas,
		            v127.m_RenderGraph = v17,
		            HG::Rendering::Runtime::FrameSettings::IsEnabled(
		              (FrameSettings *)&v127,
		              FrameSettingsField__Enum_CharacterShadowMaps,
		              0LL)) )
		      {
		        v20 = *(_OWORD *)&builder->m_RenderPass;
		        v21 = *(_OWORD *)&builder->m_RenderGraph;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v127.m_RenderPass = v20;
		        *(_OWORD *)&v127.m_RenderGraph = v21;
		        HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
		          (ShadowResult *)&v135,
		          &input->shadowResult,
		          &v127,
		          0LL);
		      }
		      if ( passData )
		      {
		        passData->fields.camera = camera;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&passData->fields.camera,
		          (HGRuntimeGrassQuery_Node *)static_fields,
		          v18,
		          v19,
		          outputIndices);
		        passData->fields.vtFeedbackId = camera->fields.vtFeedbackViewId;
		        passData->fields.subdivisionHandle = camera->fields.subdivisionHandle;
		        passData->fields.terrainCullViewHandle = camera->fields.terrainCullViewHandle;
		        passData->fields.editorTerrainCullViewHandle = camera->fields.editorTerrainCullViewHandle;
		        passData->fields.enableTerrainDecalDeform = input->enableTerrainDecalDeform;
		        passData->fields.enableTerrainWetRipple = input->enableTerrainWetRipple;
		        passData->fields.enableTerrainPOM = input->enableTerrainPOM;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        preZ = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->preZ;
		        if ( preZ )
		        {
		          enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                    (HGGraphicsFeatureSwitch *)preZ,
		                                    0LL);
		          static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		          preZ = *(void **)(static_fields + 72);
		          if ( preZ )
		          {
		            v23 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                    (HGGraphicsFeatureSwitch *)preZ,
		                    0LL);
		            static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		            preZ = *(void **)(static_fields + 88);
		            if ( preZ )
		            {
		              depthAsInput[3] = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  (HGGraphicsFeatureSwitch *)preZ,
		                                  0LL);
		              static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		              preZ = *(void **)(static_fields + 152);
		              if ( preZ )
		              {
		                v24 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                        (HGGraphicsFeatureSwitch *)preZ,
		                        0LL);
		                preZ = input->hgrp;
		                depthAsInput[4] = v24;
		                if ( preZ )
		                {
		                  inputa = (RendererListHandle)*((_QWORD *)preZ + 28);
		                  if ( enabledForCPUCommands )
		                  {
		                    screenCullingRatio = input->screenCullingRatio;
		                    screenCullingRatioDistance = input->screenCullingRatioDistance;
		                    screenCullingLayerMask = input->screenCullingLayerMask;
		                    v126 = 0LL;
		                    sub_18033B9D0(&v135, 0LL, 112LL);
		                    v28 = camera->fields.camera;
		                    v125.m_Length = 0;
		                    v125.m_Buffer = 0LL;
		                    *(CullingResults *)&v127.m_RenderPass = input->cullingResults;
		                    v29 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                            &v137,
		                            (CullingResults *)&v127,
		                            v28,
		                            *(ShaderTagId__Array **)&inputa,
		                            screenCullingRatio,
		                            screenCullingRatioDistance,
		                            screenCullingLayerMask,
		                            PerObjectData__Enum_None,
		                            (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v125,
		                            &v135,
		                            0LL,
		                            0,
		                            0LL);
		                    static_fields = 128LL;
		                    v30 = *(_OWORD *)&v29->stateBlock.hasValue;
		                    *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v29->sortingCriteria;
		                    v31 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.hasValue = v30;
		                    v32 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v31;
		                    v33 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v32;
		                    v34 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v33;
		                    v35 = *(_OWORD *)&v29->stateBlock.value.m_RasterState.m_OffsetFactor;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v34;
		                    v36 = *(_OWORD *)&v29->stateBlock.value.m_StencilState.m_FailOperationFront;
		                    v29 = (RendererListDesc *)((char *)v29 + 128);
		                    *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v35;
		                    preZ = &desc.overrideMaterial;
		                    v37 = *(_OWORD *)&v29->sortingCriteria;
		                    *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v36;
		                    v38 = *(_OWORD *)&v29->stateBlock.hasValue;
		                    *(_OWORD *)&desc.overrideMaterial = v37;
		                    v39 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.overrideMaterialPassIndex = v38;
		                    v40 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.sortingLayerMin = v39;
		                    v41 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.drawableFeedbackPtr = v40;
		                    v42 = *(_OWORD *)&v29->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v41;
		                    *(_OWORD *)&desc._passName_k__BackingField.m_Id = v42;
		                    if ( !renderGraph )
		                      goto LABEL_31;
		                    InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                      renderGraph,
		                                      &desc,
		                                      0LL);
		                  }
		                  else
		                  {
		                    InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		                  }
		                  inputa = InvalidHandle;
		                  passData->fields.preDepthRendererList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                                            builder,
		                                                            &inputa,
		                                                            0LL);
		                  if ( v23 )
		                  {
		                    cullingResults = input->cullingResults;
		                    v45 = camera->fields.camera;
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		                    v46 = input->screenCullingRatio;
		                    v47 = input->screenCullingRatioDistance;
		                    v48 = input->screenCullingLayerMask;
		                    v49 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		                    v126 = 0LL;
		                    sub_18033B9D0(&v135, 0LL, 112LL);
		                    v50.m_Id = v49->s_DepthCharacterOnlyName.m_Id;
		                    v125.m_Length = (int)v126;
		                    v125.m_Buffer = v126;
		                    *(CullingResults *)&v127.m_RenderPass = cullingResults;
		                    v51 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                            &v137,
		                            (CullingResults *)&v127,
		                            v45,
		                            v50,
		                            v46,
		                            v47,
		                            v48,
		                            PerObjectData__Enum_None,
		                            (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v125,
		                            &v135,
		                            0LL,
		                            0,
		                            0LL,
		                            0LL);
		                    v52 = *(_OWORD *)&v51->stateBlock.hasValue;
		                    *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v51->sortingCriteria;
		                    v53 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.hasValue = v52;
		                    v54 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v53;
		                    v55 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v54;
		                    v56 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v55;
		                    v57 = *(_OWORD *)&v51->stateBlock.value.m_RasterState.m_OffsetFactor;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v56;
		                    v58 = *(_OWORD *)&v51->stateBlock.value.m_StencilState.m_FailOperationFront;
		                    v51 = (RendererListDesc *)((char *)v51 + 128);
		                    *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v57;
		                    preZ = &desc.overrideMaterial;
		                    v59 = *(_OWORD *)&v51->sortingCriteria;
		                    *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v58;
		                    v60 = *(_OWORD *)&v51->stateBlock.hasValue;
		                    *(_OWORD *)&desc.overrideMaterial = v59;
		                    v61 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.overrideMaterialPassIndex = v60;
		                    v62 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.sortingLayerMin = v61;
		                    v63 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.drawableFeedbackPtr = v62;
		                    v64 = *(_OWORD *)&v51->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v63;
		                    *(_OWORD *)&desc._passName_k__BackingField.m_Id = v64;
		                    if ( !renderGraph )
		                      goto LABEL_31;
		                    v65 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		                  }
		                  else
		                  {
		                    v65 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		                  }
		                  inputa = v65;
		                  passData->fields.characterPrePassRendererList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                                                    builder,
		                                                                    &inputa,
		                                                                    0LL);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		                  PerObjectDataConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		                  preZ = input->hgrp;
		                  if ( preZ )
		                  {
		                    v128 = PerObjectDataConfig | HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(
		                                                   (HGRenderPipeline *)preZ,
		                                                   0LL);
		                    if ( depthAsInput[3] )
		                    {
		                      v67 = input->cullingResults;
		                      v68 = camera->fields.camera;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		                      v69 = input->screenCullingRatio;
		                      v70 = input->screenCullingRatioDistance;
		                      v71 = input->screenCullingLayerMask;
		                      v72 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		                      v126 = 0LL;
		                      sub_18033B9D0(&v135, 0LL, 112LL);
		                      v73.m_Id = v72->s_GBufferName.m_Id;
		                      v125.m_Length = (int)v126;
		                      v125.m_Buffer = v126;
		                      *(CullingResults *)&v127.m_RenderPass = v67;
		                      v74 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                              &v137,
		                              (CullingResults *)&v127,
		                              v68,
		                              v73,
		                              v69,
		                              v70,
		                              v71,
		                              v128,
		                              (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v125,
		                              &v135,
		                              0LL,
		                              0,
		                              0LL,
		                              0LL);
		                      static_fields = 128LL;
		                      v75 = *(_OWORD *)&v74->stateBlock.hasValue;
		                      *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v74->sortingCriteria;
		                      v76 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.stateBlock.hasValue = v75;
		                      v77 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v76;
		                      v78 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v77;
		                      v79 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v78;
		                      v80 = *(_OWORD *)&v74->stateBlock.value.m_RasterState.m_OffsetFactor;
		                      *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v79;
		                      v81 = *(_OWORD *)&v74->stateBlock.value.m_StencilState.m_FailOperationFront;
		                      v74 = (RendererListDesc *)((char *)v74 + 128);
		                      *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v80;
		                      preZ = &desc.overrideMaterial;
		                      v82 = *(_OWORD *)&v74->sortingCriteria;
		                      *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v81;
		                      v83 = *(_OWORD *)&v74->stateBlock.hasValue;
		                      *(_OWORD *)&desc.overrideMaterial = v82;
		                      v84 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.overrideMaterialPassIndex = v83;
		                      v85 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.sortingLayerMin = v84;
		                      v86 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc.drawableFeedbackPtr = v85;
		                      v87 = *(_OWORD *)&v74->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                      *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v86;
		                      *(_OWORD *)&desc._passName_k__BackingField.m_Id = v87;
		                      if ( !renderGraph )
		                        goto LABEL_31;
		                      v88 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		                    }
		                    else
		                    {
		                      v88 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		                    }
		                    inputa = v88;
		                    v89 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(builder, &inputa, 0LL);
		                    v90 = !depthAsInput[4];
		                    passData->fields.gBufferRendererList = v89;
		                    if ( v90 )
		                    {
		                      v112 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		                      goto LABEL_29;
		                    }
		                    v91 = input->cullingResults;
		                    v92 = camera->fields.camera;
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		                    v93 = input->screenCullingRatio;
		                    v94 = input->screenCullingRatioDistance;
		                    v95 = input->screenCullingLayerMask;
		                    v96 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		                    v126 = 0LL;
		                    sub_18033B9D0(&v135, 0LL, 112LL);
		                    v97.m_Id = v96->s_ErosionMobileName.m_Id;
		                    v125.m_Buffer = v126;
		                    v125.m_Length = 0;
		                    *(CullingResults *)&v127.m_RenderPass = v91;
		                    v98 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                            &v137,
		                            (CullingResults *)&v127,
		                            v92,
		                            v97,
		                            v93,
		                            v94,
		                            v95,
		                            v128,
		                            (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v125,
		                            &v135,
		                            0LL,
		                            0,
		                            0LL,
		                            0LL);
		                    v99 = *(_OWORD *)&v98->stateBlock.hasValue;
		                    *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v98->sortingCriteria;
		                    v100 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.hasValue = v99;
		                    v101 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v100;
		                    v102 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v101;
		                    v103 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v102;
		                    v104 = *(_OWORD *)&v98->stateBlock.value.m_RasterState.m_OffsetFactor;
		                    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v103;
		                    v105 = *(_OWORD *)&v98->stateBlock.value.m_StencilState.m_FailOperationFront;
		                    v98 = (RendererListDesc *)((char *)v98 + 128);
		                    *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v104;
		                    static_fields = (__int64)&desc.overrideMaterial;
		                    preZ = renderGraph;
		                    v106 = *(_OWORD *)&v98->sortingCriteria;
		                    *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v105;
		                    v107 = *(_OWORD *)&v98->stateBlock.hasValue;
		                    *(_OWORD *)&desc.overrideMaterial = v106;
		                    v108 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.overrideMaterialPassIndex = v107;
		                    v109 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.sortingLayerMin = v108;
		                    v110 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc.drawableFeedbackPtr = v109;
		                    v111 = *(_OWORD *)&v98->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                    *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v110;
		                    *(_OWORD *)&desc._passName_k__BackingField.m_Id = v111;
		                    if ( renderGraph )
		                    {
		                      v112 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                               renderGraph,
		                               &desc,
		                               0LL);
		LABEL_29:
		                      inputa = v112;
		                      passData->fields.erosionMobileRendererList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                                                     builder,
		                                                                     &inputa,
		                                                                     0LL);
		                      passData->fields.deferredOpaquePreZECSList = input->deferredOpaquePreZECSList;
		                      passData->fields.forwardOpaquePreZECSList = input->forwardOpaquePreZECSList;
		                      passData->fields.deferredGrassPreZECSList = input->deferredGrassPreZECSList;
		                      passData->fields.deferredTreePreZECSList = input->deferredTreePreZECSList;
		                      passData->fields.deferredOpaqueECSList = input->deferredOpaqueECSList;
		                      passData->fields.deferredOpaqueEqualECSList = input->deferredOpaqueEqualECSList;
		                      passData->fields.deferredGrassECSList = input->deferredGrassECSList;
		                      passData->fields.deferredTreeECSList = input->deferredTreeECSList;
		                      passData->fields.deferredDecalMobileECSList = input->deferredDecalMobileECSList;
		                      passData->fields.deferredSludgeECSList = input->deferredSludgeECSList;
		                      passData->fields.deferredErosionMobileECSList = input->deferredErosionMobileECSList;
		                      passData->fields.characterPrePassECSList = input->characterPrePassECSList;
		                      HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
		                        this,
		                        OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_PreDepth,
		                        count.Item1,
		                        count.Item2,
		                        &v129,
		                        &inputIndices,
		                        depthAsInput,
		                        0,
		                        0LL);
		                      v113 = v129;
		                      v114 = inputIndices;
		                      v115 = depthAsInput[0];
		                      v116 = (*subpassIndex)++;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		                      *(NativeArray_1_System_Int32_ *)&v127.m_RenderPass = v114;
		                      v125 = v113;
		                      sub_1808AF798(
		                        (_DWORD)builder,
		                        v116,
		                        (unsigned int)&v125,
		                        (unsigned int)&v127,
		                        v115,
		                        (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_preDepthRenderFunc,
		                        1);
		                      HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
		                        this,
		                        OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_GBuffer,
		                        count.Item1,
		                        count.Item2,
		                        &v132,
		                        &v131,
		                        &depthAsInput[1],
		                        0,
		                        0LL);
		                      v117 = *subpassIndex;
		                      v118 = v132;
		                      *(NativeArray_1_System_Int32_ *)&v127.m_RenderPass = v131;
		                      *subpassIndex = v117 + 1;
		                      v125 = v118;
		                      sub_1808AF798(
		                        (_DWORD)builder,
		                        v117,
		                        (unsigned int)&v125,
		                        (unsigned int)&v127,
		                        depthAsInput[1],
		                        (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_gBufferRenderFunc,
		                        2);
		                      HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
		                        this,
		                        OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_Decal,
		                        count.Item1,
		                        count.Item2,
		                        &v134,
		                        &v133,
		                        &depthAsInput[2],
		                        0,
		                        0LL);
		                      v119 = *subpassIndex;
		                      v120 = v134;
		                      *(NativeArray_1_System_Int32_ *)&v127.m_RenderPass = v133;
		                      *subpassIndex = v119 + 1;
		                      v125 = v120;
		                      sub_1808AF798(
		                        (_DWORD)builder,
		                        v119,
		                        (unsigned int)&v125,
		                        (unsigned int)&v127,
		                        depthAsInput[2],
		                        (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_decalRenderFunc,
		                        0);
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_31:
		    sub_1800D8260(preZ, static_fields);
		  }
		  preZ = IFix::WrappersManagerImpl::GetPatch(3278, 0LL);
		  if ( !preZ )
		    goto LABEL_31;
		  v121 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v127.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v127.m_RenderGraph = v121;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1206(
		    (ILFixDynamicMethodWrapper_2 *)preZ,
		    (Object *)this,
		    &v127,
		    input,
		    output,
		    subpassIndex,
		    (Object *)passData,
		    (Object *)renderGraph,
		    (Object *)camera,
		    count,
		    0LL);
		}
		
		private void _ConstructPassPhase1(HGRenderGraphBuilder builder, ref PassInput input, ref PassOutput output, ref int subpassIndex, OnePassDeferredData passData, HGRenderGraph renderGraph, HGCamera camera, ValueTuple<int, int> count, bool shouldSplitOnePass) {} // 0x0000000189BC1190-0x0000000189BC1FB0
		// Void _ConstructPassPhase1(HGRenderGraphBuilder, OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, Int32 ByRef, OnePassDeferredPassConstructor+OnePassDeferredData, HGRenderGraph, HGCamera, ValueTuple`2[Int32,Int32], Boolean)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
		        OnePassDeferredPassConstructor *this,
		        HGRenderGraphBuilder *builder,
		        OnePassDeferredPassConstructor_PassInput *input,
		        OnePassDeferredPassConstructor_PassOutput *output,
		        int32_t *subpassIndex,
		        OnePassDeferredPassConstructor_OnePassDeferredData *passData,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        ValueTuple_2_Int32_Int32_ count,
		        bool shouldSplitOnePass,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *i; // rdx
		  Material *m_deferredLightingMaterial; // rcx
		  __int64 v17; // xmm1_8
		  __int64 v18; // xmm1_8
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  __int128 v21; // xmm6
		  __int128 v22; // xmm7
		  TextureHandle *Texture; // rax
		  __int64 v24; // rdx
		  __int128 v25; // xmm6
		  __int128 v26; // xmm7
		  CullingResults cullingResults; // xmm8
		  PerObjectData__Enum bakedLightingConfig; // eax
		  DeferredLightingPass_DeferredLightingRenderParams *inited; // rax
		  __int128 v30; // xmm2
		  GraphicsBuffer *quadIndexBuffer; // xmm0_8
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  HGRuntimeGrassQuery_Node *v35; // rdx
		  HGRuntimeGrassQuery_Node *v36; // r8
		  Int32__Array **v37; // r9
		  bool HasTerrainSimpleSubsurface; // di
		  Shader *shader; // rbx
		  HGRuntimeGrassQuery_Node *v40; // rdx
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  __int128 v43; // xmm0
		  __int64 v44; // rax
		  GraphicsBuffer *v45; // xmm1_8
		  __int64 v46; // rax
		  __int64 v47; // rax
		  int32_t v48; // esi
		  int32_t m_AllocationInfo; // eax
		  MethodInfo *v50; // rdx
		  MethodInfo *v51; // rdx
		  Vector3 *one; // rax
		  __int64 v53; // xmm0_8
		  MethodInfo *v54; // r9
		  Vector3 *v55; // rax
		  __int64 v56; // xmm3_8
		  MethodInfo *v57; // r9
		  Vector3 *v58; // rax
		  __int64 v59; // xmm3_8
		  MethodInfo *v60; // r9
		  Vector3 *v61; // rax
		  Quaternion *v62; // r8
		  Quaternion v63; // xmm0
		  __int64 v64; // xmm3_8
		  Matrix4x4 *v65; // rax
		  __int128 v66; // xmm6
		  __int128 v67; // xmm7
		  __int128 v68; // xmm8
		  __int128 v69; // xmm9
		  __int64 v70; // rax
		  __int64 v71; // xmm6_8
		  float z; // ebx
		  Vector3 *Forward; // rax
		  __int64 v74; // xmm0_8
		  MethodInfo *v75; // r9
		  Vector3 *v76; // rax
		  __int64 v77; // xmm3_8
		  MethodInfo *v78; // r9
		  Vector3 *v79; // rax
		  __int64 v80; // xmm8_8
		  float v81; // edi
		  Vector3 *v82; // rax
		  __int64 v83; // xmm0_8
		  MethodInfo *v84; // r8
		  Vector3 *v85; // rbx
		  __m128 m_SpotAngle_low; // xmm0
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  __int64 v89; // r8
		  __int64 v90; // r9
		  float v91; // eax
		  __m128 v92; // xmm7
		  Quaternion *v93; // rax
		  __m128i v94; // xmm6
		  __int64 v95; // r8
		  __int64 v96; // r9
		  Quaternion *v97; // rax
		  MethodInfo *v98; // r9
		  __m128 v99; // xmm0
		  MethodInfo *v100; // r9
		  Vector3 *v101; // rax
		  NativeArray_1_System_Int32_ *v102; // r8
		  NativeArray_1_System_Int32_ v103; // xmm0
		  __int64 v104; // xmm3_8
		  Matrix4x4 *v105; // rax
		  __int128 v106; // xmm6
		  __int128 v107; // xmm7
		  __int128 v108; // xmm8
		  __int128 v109; // xmm9
		  __int64 v110; // rax
		  Shader *v111; // rbx
		  HGRuntimeGrassQuery_Node *v112; // rdx
		  HGRuntimeGrassQuery_Node *v113; // r8
		  Int32__Array **v114; // r9
		  Mesh *m_sphereMesh; // r9
		  HGRuntimeGrassQuery_Node *v116; // rdx
		  HGRuntimeGrassQuery_Node *v117; // r8
		  Mesh *m_coneMesh; // r9
		  HGRuntimeGrassQuery_Node *v119; // rdx
		  HGRuntimeGrassQuery_Node *v120; // r8
		  HGRuntimeGrassQuery_Node *v121; // rdx
		  HGRuntimeGrassQuery_Node *v122; // r8
		  Int32__Array **v123; // r9
		  NativeArray_1_System_Int32_ v124; // xmm7
		  NativeArray_1_System_Int32_ v125; // xmm6
		  char v126; // bl
		  int32_t v127; // edi
		  int32_t v128; // edx
		  NativeArray_1_System_Int32_ v129; // xmm1
		  __int128 v130; // xmm1
		  MethodInfo *outputIndices; // [rsp+28h] [rbp-F0h]
		  MethodInfo *outputIndicesc; // [rsp+28h] [rbp-F0h]
		  MethodInfo *outputIndicesa; // [rsp+28h] [rbp-F0h]
		  MethodInfo *outputIndicesb; // [rsp+28h] [rbp-F0h]
		  MethodInfo *outputIndicesd; // [rsp+28h] [rbp-F0h]
		  MethodInfo *outputIndicese; // [rsp+28h] [rbp-F0h]
		  MethodInfo *outputIndicesf; // [rsp+28h] [rbp-F0h]
		  uint32_t depthAsInput; // [rsp+38h] [rbp-E0h]
		  uint32_t shouldSplitOnePassa; // [rsp+40h] [rbp-D8h]
		  uint32_t methoda; // [rsp+48h] [rbp-D0h]
		  uint32_t characterOutlineOpaqueECSRendererList; // [rsp+50h] [rbp-C8h]
		  uint32_t characterOutlineOpaqueEqualECSRendererList; // [rsp+58h] [rbp-C0h]
		  bool characterOutlineEnabled; // [rsp+60h] [rbp-B8h]
		  float screenCullingRatio; // [rsp+68h] [rbp-B0h]
		  float screenCullingRatioDistance; // [rsp+70h] [rbp-A8h]
		  uint32_t screenCullingLayerMask; // [rsp+78h] [rbp-A0h]
		  ForwardPassUtils_ForwardOpaquePassData *opaqueData; // [rsp+80h] [rbp-98h]
		  bool v148; // [rsp+98h] [rbp-80h] BYREF
		  bool v149; // [rsp+99h] [rbp-7Fh] BYREF
		  bool value; // [rsp+9Ah] [rbp-7Eh]
		  NativeArray_1_System_Int32_ v151; // [rsp+A8h] [rbp-70h] BYREF
		  HGRenderPipeline *hgrp; // [rsp+B8h] [rbp-60h]
		  DeferredLightingPass_DeferredLightingRenderParams v153; // [rsp+C8h] [rbp-50h] BYREF
		  NativeArray_1_System_Int32_ v154; // [rsp+F8h] [rbp-20h] BYREF
		  CullingResults v155; // [rsp+108h] [rbp-10h] BYREF
		  Vector3 v156; // [rsp+118h] [rbp+0h] BYREF
		  Vector3 v157; // [rsp+128h] [rbp+10h] BYREF
		  Vector3 v158; // [rsp+138h] [rbp+20h] BYREF
		  Vector3 m_WorldPosition; // [rsp+148h] [rbp+30h] BYREF
		  Vector3 v160; // [rsp+158h] [rbp+40h] BYREF
		  Vector3 v161; // [rsp+168h] [rbp+50h] BYREF
		  Vector3 v162; // [rsp+178h] [rbp+60h] BYREF
		  Vector3 v163; // [rsp+188h] [rbp+70h] BYREF
		  Vector3 v164; // [rsp+198h] [rbp+80h] BYREF
		  unsigned __int64 v165; // [rsp+1A8h] [rbp+90h] BYREF
		  int v166; // [rsp+1B0h] [rbp+98h]
		  Vector3 v167; // [rsp+1B8h] [rbp+A0h] BYREF
		  Vector3 v168; // [rsp+1C8h] [rbp+B0h] BYREF
		  Vector3 v169; // [rsp+1D8h] [rbp+C0h] BYREF
		  Vector3 v170; // [rsp+1E8h] [rbp+D0h] BYREF
		  NativeArray_1_System_Int32_ v171; // [rsp+1F8h] [rbp+E0h] BYREF
		  NativeArray_1_System_Int32_ inputIndices; // [rsp+208h] [rbp+F0h] BYREF
		  NativeArray_1_System_Int32_ v173; // [rsp+218h] [rbp+100h] BYREF
		  NativeArray_1_System_Int32_ v174; // [rsp+228h] [rbp+110h] BYREF
		  LocalKeyword keyword; // [rsp+238h] [rbp+120h] BYREF
		  LocalKeyword v176; // [rsp+250h] [rbp+138h] BYREF
		  VisibleLight v177; // [rsp+268h] [rbp+150h] BYREF
		  Vector3 v178; // [rsp+308h] [rbp+1F0h] BYREF
		  Vector3 v179; // [rsp+318h] [rbp+200h] BYREF
		  Vector3 v180; // [rsp+328h] [rbp+210h] BYREF
		  Vector3 v181; // [rsp+338h] [rbp+220h] BYREF
		  Vector3 v182; // [rsp+348h] [rbp+230h] BYREF
		  Vector3 v183; // [rsp+358h] [rbp+240h] BYREF
		  Vector3 v184; // [rsp+368h] [rbp+250h] BYREF
		  Vector3 v185; // [rsp+378h] [rbp+260h] BYREF
		  Vector3 v186; // [rsp+388h] [rbp+270h] BYREF
		  Vector3 v187; // [rsp+398h] [rbp+280h] BYREF
		  Quaternion v188; // [rsp+3A8h] [rbp+290h] BYREF
		  Quaternion v189; // [rsp+3B8h] [rbp+2A0h] BYREF
		  char v190[16]; // [rsp+3C8h] [rbp+2B0h] BYREF
		  Matrix4x4 v191; // [rsp+3D8h] [rbp+2C0h] BYREF
		  VisibleLight v192; // [rsp+418h] [rbp+300h] BYREF
		
		  memset(&keyword, 0, sizeof(keyword));
		  memset(&v176, 0, sizeof(v176));
		  sub_18033B9D0(&v177, 0LL, 148LL);
		  v148 = 0;
		  v149 = 0;
		  v171 = 0LL;
		  inputIndices = 0LL;
		  v174 = 0LL;
		  v173 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3279, 0LL) )
		  {
		    if ( camera )
		    {
		      v17 = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality;
		      *(BitArray128 *)&v153.enableDeferredShadingDefaultLit = camera->fields._frameSettings_k__BackingField.bitDatas;
		      *(_QWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v17;
		      if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		             (FrameSettings *)&v153,
		             FrameSettingsField__Enum_ShadowMaps,
		             0LL)
		        || (v18 = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality,
		            *(BitArray128 *)&v153.enableDeferredShadingDefaultLit = camera->fields._frameSettings_k__BackingField.bitDatas,
		            *(_QWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v18,
		            HG::Rendering::Runtime::FrameSettings::IsEnabled(
		              (FrameSettings *)&v153,
		              FrameSettingsField__Enum_CharacterShadowMaps,
		              0LL)) )
		      {
		        v21 = *(_OWORD *)&builder->m_RenderPass;
		        v22 = *(_OWORD *)&builder->m_RenderGraph;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v153.enableDeferredShadingDefaultLit = v21;
		        *(_OWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v22;
		        HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
		          (ShadowResult *)&v191,
		          &input->shadowResult,
		          (HGRenderGraphBuilder *)&v153,
		          0LL);
		      }
		      if ( passData )
		      {
		        passData->fields.camera = camera;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.camera, i, v19, v20, outputIndices);
		        passData->fields.vtFeedbackId = camera->fields.vtFeedbackViewId;
		        passData->fields.subdivisionHandle = camera->fields.subdivisionHandle;
		        passData->fields.terrainCullViewHandle = camera->fields.terrainCullViewHandle;
		        passData->fields.editorTerrainCullViewHandle = camera->fields.editorTerrainCullViewHandle;
		        passData->fields.enableTerrainDecalDeform = input->enableTerrainDecalDeform;
		        passData->fields.planarReflectionTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                      (TextureHandle *)&v151,
		                                                      builder,
		                                                      &input->planarReflectionTexture,
		                                                      0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->ssrLightingTexture, 0LL) )
		        {
		          Texture = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                      (TextureHandle *)&v151,
		                      builder,
		                      &input->ssrLightingTexture,
		                      0LL);
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          Texture = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)&v151, 0LL);
		        }
		        passData->fields.ssrLightingTexture = *Texture;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->fogBakeLutTexture, 0LL) )
		          passData->fields.fogBakeLutTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                  (TextureHandle *)&v151,
		                                                  builder,
		                                                  &input->fogBakeLutTexture,
		                                                  0LL);
		        hgrp = input->hgrp;
		        v25 = *(_OWORD *)&builder->m_RenderPass;
		        v26 = *(_OWORD *)&builder->m_RenderGraph;
		        cullingResults = input->cullingResults;
		        if ( !hgrp )
		          sub_1800D8260(0LL, v24);
		        bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(hgrp, 0LL);
		        opaqueData = passData->fields.opaqueData;
		        screenCullingLayerMask = input->screenCullingLayerMask;
		        screenCullingRatioDistance = input->screenCullingRatioDistance;
		        screenCullingRatio = input->screenCullingRatio;
		        characterOutlineEnabled = input->characterOutlineEnabled;
		        characterOutlineOpaqueEqualECSRendererList = input->characterOutlineOpaqueEqualECSRendererList;
		        characterOutlineOpaqueECSRendererList = input->characterOutlineOpaqueECSRendererList;
		        methoda = input->characterOpaqueECSList;
		        shouldSplitOnePassa = input->forwardOpaqueEqualECSList;
		        depthAsInput = input->forwardOpaqueECSList;
		        v155 = cullingResults;
		        *(_OWORD *)&v153.enableDeferredShadingDefaultLit = v25;
		        *(_OWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v26;
		        HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
		          hgrp,
		          renderGraph,
		          camera,
		          (HGRenderGraphBuilder *)&v153,
		          &v155,
		          bakedLightingConfig,
		          depthAsInput,
		          shouldSplitOnePassa,
		          methoda,
		          characterOutlineOpaqueECSRendererList,
		          characterOutlineOpaqueEqualECSRendererList,
		          characterOutlineEnabled,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          opaqueData,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
		        inited = HG::Rendering::Runtime::DeferredLightingPass::InitDeferredLightingRenderParams(&v153, 1, 0LL);
		        v30 = *(_OWORD *)&inited->drawTileArgs.handle._type_k__BackingField;
		        quadIndexBuffer = inited->quadIndexBuffer;
		        *(_OWORD *)&passData->fields.deferredLightingParams.enableDeferredShadingDefaultLit = *(_OWORD *)&inited->enableDeferredShadingDefaultLit;
		        *(_OWORD *)&passData->fields.deferredLightingParams.drawTileArgs.handle._type_k__BackingField = v30;
		        passData->fields.deferredLightingParams.quadIndexBuffer = quadIndexBuffer;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&passData->fields.deferredLightingParams.quadIndexBuffer,
		          v32,
		          v33,
		          v34,
		          outputIndicesc);
		        if ( passData->fields.deferredLightingParams.enableDeferredShadingTileDraw )
		        {
		          passData->fields.deferredLightingParams.drawTileArgs = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		                                                                   builder,
		                                                                   &input->drawTileArgs,
		                                                                   0LL);
		          passData->fields.deferredLightingParams.tileInstanceIndices = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		                                                                          builder,
		                                                                          &input->tileInstanceIndices,
		                                                                          0LL);
		          passData->fields.deferredLightingParams.quadIndexBuffer = input->quadIndexBuffer;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&passData->fields.deferredLightingParams.quadIndexBuffer,
		            v35,
		            v36,
		            v37,
		            outputIndicesa);
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		        if ( !HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&input->drawTileArgs, 0LL)
		          || (sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle),
		              !HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&input->tileInstanceIndices, 0LL)) )
		        {
		          passData->fields.deferredLightingParams.enableDeferredShadingTileDraw = 0;
		        }
		        passData->fields.characterOpaqueECSList = input->characterOpaqueECSList;
		        passData->fields.characterOutlineOpaquePreZECSRendererList = input->characterOutlineOpaquePreZECSRendererList;
		        passData->fields.characterOutlineOpaqueECSRendererList = input->characterOutlineOpaqueECSRendererList;
		        passData->fields.characterOutlineOpaqueEqualECSRendererList = input->characterOutlineOpaqueEqualECSRendererList;
		        HasTerrainSimpleSubsurface = HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::HasTerrainSimpleSubsurface(0LL);
		        value = HasTerrainSimpleSubsurface;
		        m_deferredLightingMaterial = this->fields.m_deferredLightingMaterial;
		        if ( m_deferredLightingMaterial )
		        {
		          shader = UnityEngine::Material::get_shader(m_deferredLightingMaterial, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &keyword,
		            shader,
		            TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfileSimple,
		            0LL);
		          m_deferredLightingMaterial = this->fields.m_deferredLightingMaterial;
		          if ( m_deferredLightingMaterial )
		          {
		            UnityEngine::Material::SetKeyword(m_deferredLightingMaterial, &keyword, HasTerrainSimpleSubsurface, 0LL);
		            passData->fields.deferredLightingMaterial = this->fields.m_deferredLightingMaterial;
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&passData->fields.deferredLightingMaterial,
		              v40,
		              v41,
		              v42,
		              outputIndicesa);
		            v43 = *(_OWORD *)&passData->fields.deferredLightingParams.drawTileArgs.handle._type_k__BackingField;
		            v44 = *(_QWORD *)&passData->fields.deferredLightingParams.enableDeferredShadingDefaultLit >> 24;
		            v45 = passData->fields.deferredLightingParams.quadIndexBuffer;
		            v153.quadIndexBuffer = v45;
		            *(_OWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v43;
		            if ( !(_BYTE)v44 )
		              goto LABEL_41;
		            v46 = HIWORD(*(_QWORD *)&passData->fields.deferredLightingParams.enableDeferredShadingDefaultLit);
		            v153.quadIndexBuffer = v45;
		            *(_OWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v43;
		            if ( !(_BYTE)v46 )
		              goto LABEL_41;
		            v47 = HIDWORD(*(_QWORD *)&passData->fields.deferredLightingParams.enableDeferredShadingDefaultLit);
		            v153.quadIndexBuffer = v45;
		            *(_OWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v43;
		            if ( !(_BYTE)v47 )
		              goto LABEL_41;
		            passData->fields.punctualLightCount = input->punctualLightCount;
		            Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(
		              (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v155,
		              (Void *)input->lightCullResult.visibleLightsPtr,
		              input->lightCullResult.visibleLightCount,
		              Allocator__Enum_None,
		              MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<UnityEngine::Rendering::VisibleLight>);
		            v48 = 0;
		            for ( i = 0LL; ; i = (HGRuntimeGrassQuery_Node *)((char *)&hgrp->klass + 4) )
		            {
		              hgrp = (HGRenderPipeline *)i;
		              m_AllocationInfo = (int32_t)v155.m_AllocationInfo;
		              if ( SLODWORD(v155.m_AllocationInfo) >= input->punctualLightCount )
		                m_AllocationInfo = input->punctualLightCount;
		              if ( v48 >= m_AllocationInfo )
		                break;
		              v177 = *(VisibleLight *)((_BYTE *)v155.ptr
		                                     + *(int *)((char *)input->punctualLightIndices + (unsigned __int64)i));
		              if ( UnityEngine::HGSharedLightData::get_type_Injected(&v177.hgSharedLightData, 0LL) )
		              {
		                UnityEngine::Quaternion::get_identity(&v188, v50);
		                one = UnityEngine::Vector3::get_one(&v178, v51);
		                v53 = *(_QWORD *)&one->x;
		                v156.z = one->z;
		                *(_QWORD *)&v156.x = v53;
		                v55 = UnityEngine::Vector3::op_Multiply(&v186, &v156, v177.m_Range, v54);
		                v56 = *(_QWORD *)&v55->x;
		                *(float *)&v55 = v55->z;
		                *(_QWORD *)&v170.x = v56;
		                LODWORD(v170.z) = (_DWORD)v55;
		                v58 = UnityEngine::Vector3::op_Multiply(&v185, &v170, 2.0, v57);
		                v59 = *(_QWORD *)&v58->x;
		                *(float *)&v58 = v58->z;
		                *(_QWORD *)&v157.x = v59;
		                LODWORD(v157.z) = (_DWORD)v58;
		                v61 = UnityEngine::Vector3::op_Multiply(&v184, &v157, 1.0824, v60);
		                v63 = *v62;
		                v64 = *(_QWORD *)&v61->x;
		                v158.z = v61->z;
		                m_WorldPosition = v177.m_WorldPosition;
		                *(_QWORD *)&v158.x = v64;
		                v154 = (NativeArray_1_System_Int32_)v63;
		                v65 = UnityEngine::Matrix4x4::TRS(&v191, &m_WorldPosition, (Quaternion *)&v154, &v158, 0LL);
		                v66 = *(_OWORD *)&v65->m00;
		                v67 = *(_OWORD *)&v65->m01;
		                v68 = *(_OWORD *)&v65->m02;
		                v69 = *(_OWORD *)&v65->m03;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		                m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                if ( !m_deferredLightingMaterial )
		                  goto LABEL_43;
		                *(_DWORD *)(sub_1804A20EC(m_deferredLightingMaterial, v48) + 68) = v48;
		                m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                if ( !m_deferredLightingMaterial )
		                  goto LABEL_43;
		                v70 = sub_1804A20EC(m_deferredLightingMaterial, v48);
		                *(_OWORD *)(v70 + 4) = v66;
		                *(_OWORD *)(v70 + 20) = v67;
		                *(_OWORD *)(v70 + 36) = v68;
		                *(_OWORD *)(v70 + 52) = v69;
		                m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                if ( !m_deferredLightingMaterial )
		                  goto LABEL_43;
		                *(_DWORD *)sub_1804A20EC(m_deferredLightingMaterial, v48) = 1;
		              }
		              else
		              {
		                v71 = *(_QWORD *)&v177.m_WorldPosition.x;
		                z = v177.m_WorldPosition.z;
		                v192 = v177;
		                Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v187, &v192, 0LL);
		                v74 = *(_QWORD *)&Forward->x;
		                *(float *)&Forward = Forward->z;
		                *(_QWORD *)&v160.x = v74;
		                LODWORD(v160.z) = (_DWORD)Forward;
		                v76 = UnityEngine::Vector3::op_Multiply(&v179, &v160, v177.m_Range, v75);
		                *(_QWORD *)&v162.x = v71;
		                v162.z = z;
		                v77 = *(_QWORD *)&v76->x;
		                *(float *)&v76 = v76->z;
		                *(_QWORD *)&v161.x = v77;
		                LODWORD(v161.z) = (_DWORD)v76;
		                v79 = UnityEngine::Vector3::op_Addition(&v180, &v162, &v161, v78);
		                v80 = *(_QWORD *)&v79->x;
		                v81 = v79->z;
		                v192 = v177;
		                v82 = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v181, &v192, 0LL);
		                v83 = *(_QWORD *)&v82->x;
		                *(float *)&v82 = v82->z;
		                *(_QWORD *)&v163.x = v83;
		                LODWORD(v163.z) = (_DWORD)v82;
		                v85 = UnityEngine::Vector3::op_UnaryNegation(&v182, &v163, v84);
		                m_SpotAngle_low = (__m128)LODWORD(v177.m_SpotAngle);
		                m_SpotAngle_low.m128_f32[0] = sub_180338A80(v88, v87, v89, v90);
		                v91 = v85->z;
		                v92 = m_SpotAngle_low;
		                *(_QWORD *)&v164.x = *(_QWORD *)&v85->x;
		                v92.m128_f32[0] = m_SpotAngle_low.m128_f32[0] * v177.m_Range;
		                v164.z = v91;
		                v93 = UnityEngine::Quaternion::LookRotation(&v189, &v164, 0LL);
		                v165 = _mm_unpacklo_ps((__m128)0x42B40000u, (__m128)0LL).m128_u64[0];
		                v94 = _mm_loadu_si128((const __m128i *)v93);
		                v166 = 0;
		                v97 = (Quaternion *)sub_182FA5910(v190, &v165, v95, v96);
		                v151 = (NativeArray_1_System_Int32_)v94;
		                v154 = (NativeArray_1_System_Int32_)*v97;
		                UnityEngine::Quaternion::op_Multiply((Quaternion *)&v153, (Quaternion *)&v151, (Quaternion *)&v154, v98);
		                v99 = v92;
		                v99.m128_f32[0] = v92.m128_f32[0] + v92.m128_f32[0];
		                *(_QWORD *)&v167.x = _mm_unpacklo_ps(v99, (__m128)LODWORD(v177.m_Range)).m128_u64[0];
		                v167.z = v92.m128_f32[0] + v92.m128_f32[0];
		                v101 = UnityEngine::Vector3::op_Multiply(&v183, &v167, 1.0196, v100);
		                v103 = *v102;
		                *(_QWORD *)&v169.x = v80;
		                v104 = *(_QWORD *)&v101->x;
		                *(float *)&v101 = v101->z;
		                *(_QWORD *)&v168.x = v104;
		                LODWORD(v168.z) = (_DWORD)v101;
		                v151 = v103;
		                v169.z = v81;
		                v105 = UnityEngine::Matrix4x4::TRS(&v191, &v169, (Quaternion *)&v151, &v168, 0LL);
		                v106 = *(_OWORD *)&v105->m00;
		                v107 = *(_OWORD *)&v105->m01;
		                v108 = *(_OWORD *)&v105->m02;
		                v109 = *(_OWORD *)&v105->m03;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		                m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                if ( !m_deferredLightingMaterial )
		                  goto LABEL_43;
		                *(_DWORD *)(sub_1804A20EC(m_deferredLightingMaterial, v48) + 68) = v48;
		                m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                if ( !m_deferredLightingMaterial )
		                  goto LABEL_43;
		                v110 = sub_1804A20EC(m_deferredLightingMaterial, v48);
		                *(_OWORD *)(v110 + 4) = v106;
		                *(_OWORD *)(v110 + 20) = v107;
		                *(_OWORD *)(v110 + 36) = v108;
		                *(_OWORD *)(v110 + 52) = v109;
		                m_deferredLightingMaterial = (Material *)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                if ( !m_deferredLightingMaterial )
		                  goto LABEL_43;
		                *(_DWORD *)sub_1804A20EC(m_deferredLightingMaterial, v48) = 0;
		              }
		              ++v48;
		            }
		            m_deferredLightingMaterial = this->fields.m_deferredLightingPerLightMeshMaterial;
		            if ( m_deferredLightingMaterial )
		            {
		              v111 = UnityEngine::Material::get_shader(m_deferredLightingMaterial, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                &v176,
		                v111,
		                TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfileSimple,
		                0LL);
		              m_deferredLightingMaterial = this->fields.m_deferredLightingPerLightMeshMaterial;
		              if ( m_deferredLightingMaterial )
		              {
		                UnityEngine::Material::SetKeyword(m_deferredLightingMaterial, &v176, value, 0LL);
		                passData->fields.deferredLightingPerLightMaterial = this->fields.m_deferredLightingPerLightMeshMaterial;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&passData->fields.deferredLightingPerLightMaterial,
		                  v112,
		                  v113,
		                  v114,
		                  outputIndicesb);
		                m_sphereMesh = this->fields.m_sphereMesh;
		                passData->fields.sphereMesh = m_sphereMesh;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&passData->fields.sphereMesh,
		                  v116,
		                  v117,
		                  (Int32__Array **)m_sphereMesh,
		                  outputIndicesd);
		                m_coneMesh = this->fields.m_coneMesh;
		                passData->fields.coneMesh = m_coneMesh;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&passData->fields.coneMesh,
		                  v119,
		                  v120,
		                  (Int32__Array **)m_coneMesh,
		                  outputIndicese);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		                passData->fields.lightMeshDrawRequests = TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_lightMeshDrawRequests;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&passData->fields.lightMeshDrawRequests,
		                  v121,
		                  v122,
		                  v123,
		                  outputIndicesf);
		LABEL_41:
		                HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
		                  this,
		                  OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_DeferredLighting,
		                  count.Item1,
		                  count.Item2,
		                  &v171,
		                  &inputIndices,
		                  &v148,
		                  shouldSplitOnePass,
		                  0LL);
		                v124 = v171;
		                v125 = inputIndices;
		                v126 = v148;
		                v127 = (*subpassIndex)++;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		                v151 = v125;
		                v154 = v124;
		                sub_1808AF798(
		                  (_DWORD)builder,
		                  v127,
		                  (unsigned int)&v154,
		                  (unsigned int)&v151,
		                  v126,
		                  (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_deferredLightingRenderFunc,
		                  0);
		                HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupSubpass(
		                  this,
		                  OnePassDeferredPassConstructor_OnePassDeferredSubpass__Enum_ForwardOpaque,
		                  count.Item1,
		                  count.Item2,
		                  &v174,
		                  &v173,
		                  &v149,
		                  shouldSplitOnePass,
		                  0LL);
		                v128 = *subpassIndex;
		                v129 = v174;
		                v151 = v173;
		                *subpassIndex = v128 + 1;
		                v154 = v129;
		                sub_1808AF798(
		                  (_DWORD)builder,
		                  v128,
		                  (unsigned int)&v154,
		                  (unsigned int)&v151,
		                  v149,
		                  (__int64)TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor->static_fields->s_optForwardOpaqueFunc,
		                  4);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_43:
		    sub_1800D8260(m_deferredLightingMaterial, i);
		  }
		  m_deferredLightingMaterial = (Material *)IFix::WrappersManagerImpl::GetPatch(3279, 0LL);
		  if ( !m_deferredLightingMaterial )
		    goto LABEL_43;
		  v130 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v153.enableDeferredShadingDefaultLit = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v153.drawTileArgs.handle._type_k__BackingField = v130;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1207(
		    (ILFixDynamicMethodWrapper_2 *)m_deferredLightingMaterial,
		    (Object *)this,
		    (HGRenderGraphBuilder *)&v153,
		    input,
		    output,
		    subpassIndex,
		    (Object *)passData,
		    (Object *)renderGraph,
		    (Object *)camera,
		    count,
		    shouldSplitOnePass,
		    0LL);
		}
		
		internal void ConstructPassPhase0(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBF010-0x0000000189BBF208
		// Void ConstructPassPhase0(OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase0(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_PassInput *input,
		        OnePassDeferredPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // r8d
		  ValueTuple_2_Int32_Int32_ v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int32_t v18; // [rsp+50h] [rbp-78h] BYREF
		  OnePassDeferredPassConstructor_OnePassDeferredData *v19; // [rsp+58h] [rbp-70h] BYREF
		  Il2CppExceptionWrapper *v20; // [rsp+60h] [rbp-68h] BYREF
		  _QWORD v21[2]; // [rsp+68h] [rbp-60h] BYREF
		  HGRenderGraphBuilder v22; // [rsp+78h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v23; // [rsp+A0h] [rbp-28h] BYREF
		
		  memset(&v22, 0, sizeof(v22));
		  v19 = 0LL;
		  v18 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3280, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3280, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1208(
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
		            (Int32Enum__Enum)0x17u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v22 = *(HGRenderGraphBuilder *)sub_1808AF7F8(
		                                     (unsigned int)&v23,
		                                     (_DWORD)renderGraph,
		                                     v13,
		                                     (unsigned int)&v19,
		                                     (__int64)v10);
		    v21[0] = 0LL;
		    v21[1] = &v22;
		    try
		    {
		      v23 = v22;
		      v14 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(this, input, &v23, 1, 0LL);
		      v23 = v22;
		      HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase0(
		        this,
		        &v23,
		        input,
		        output,
		        &v18,
		        v19,
		        renderGraph,
		        camera,
		        v14,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v20 )
		    {
		      v21[0] = v20->ex;
		    }
		    sub_180268AE0(v21);
		  }
		}
		
		internal void ConstructPassPhase1(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBF208-0x0000000189BBF424
		// Void ConstructPassPhase1(OnePassDeferredPassConstructor+PassInput ByRef, OnePassDeferredPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase1(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_PassInput *input,
		        OnePassDeferredPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // r8d
		  ValueTuple_2_Int32_Int32_ v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int32_t v18; // [rsp+60h] [rbp-78h] BYREF
		  OnePassDeferredPassConstructor_OnePassDeferredData *v19; // [rsp+68h] [rbp-70h] BYREF
		  Il2CppExceptionWrapper *v20; // [rsp+70h] [rbp-68h] BYREF
		  _QWORD v21[2]; // [rsp+78h] [rbp-60h] BYREF
		  HGRenderGraphBuilder v22; // [rsp+88h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v23; // [rsp+B0h] [rbp-28h] BYREF
		
		  memset(&v22, 0, sizeof(v22));
		  v19 = 0LL;
		  v18 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3281, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3281, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1208(
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
		            (Int32Enum__Enum)0x17u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v22 = *(HGRenderGraphBuilder *)sub_1808AF7F8(
		                                     (unsigned int)&v23,
		                                     (_DWORD)renderGraph,
		                                     v13,
		                                     (unsigned int)&v19,
		                                     (__int64)v10);
		    v21[0] = 0LL;
		    v21[1] = &v22;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v22, 0, 0LL);
		      v23 = v22;
		      v14 = HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetupRenderTarget(this, input, &v23, 0, 0LL);
		      v23 = v22;
		      HG::Rendering::Runtime::OnePassDeferredPassConstructor::_ConstructPassPhase1(
		        this,
		        &v23,
		        input,
		        output,
		        &v18,
		        v19,
		        renderGraph,
		        camera,
		        v14,
		        1,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v20 )
		    {
		      v21[0] = v20->ex;
		    }
		    sub_180268AE0(v21);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBFCA4-0x0000000189BBFCF8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        OnePassDeferredPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3282, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3282, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000189BBFC50-0x0000000189BBFCA4
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        OnePassDeferredPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3283, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3283, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
		[IDTag(0)]
		private int GetAttachmentIndex(FixedAttachment fixedAttachment) => default; // 0x0000000189BBFBE0-0x0000000189BBFC50
		// Int32 GetAttachmentIndex(OnePassDeferredPassConstructor+FixedAttachment)
		int32_t HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_FixedAttachment__Enum fixedAttachment,
		        MethodInfo *method)
		{
		  __int64 v3; // rbx
		  __int64 v5; // rdx
		  Int32__Array *m_attachmentMapping; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (int)fixedAttachment;
		  if ( IFix::WrappersManagerImpl::IsPatched(3272, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3272, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		               (ILFixDynamicMethodWrapper_6 *)Patch,
		               (Object *)this,
		               (NaviDirection__Enum)v3,
		               0LL);
		LABEL_7:
		    sub_1800D8260(m_attachmentMapping, v5);
		  }
		  m_attachmentMapping = this->fields.m_attachmentMapping;
		  if ( !m_attachmentMapping )
		    goto LABEL_7;
		  if ( (unsigned int)v3 >= m_attachmentMapping->max_length.size )
		    sub_1800D2AB0(m_attachmentMapping, v5);
		  return m_attachmentMapping->vector[v3];
		}
		
		[IDTag(0)]
		private void SetAttachmentIndex(FixedAttachment fixedAttachment, int index) {} // 0x0000000189BBFE24-0x0000000189BBFEA4
		// Void SetAttachmentIndex(OnePassDeferredPassConstructor+FixedAttachment, Int32)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		        OnePassDeferredPassConstructor *this,
		        OnePassDeferredPassConstructor_FixedAttachment__Enum fixedAttachment,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v4; // rbx
		  __int64 v7; // rdx
		  Int32__Array *m_attachmentMapping; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = (int)fixedAttachment;
		  if ( IFix::WrappersManagerImpl::IsPatched(3269, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3269, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		        (ILFixDynamicMethodWrapper_6 *)Patch,
		        (Object *)this,
		        (UIInertiaViewPager_State__Enum)v4,
		        (UIInertiaViewPager_State__Enum)index,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_attachmentMapping, v7);
		  }
		  m_attachmentMapping = this->fields.m_attachmentMapping;
		  if ( !m_attachmentMapping )
		    goto LABEL_7;
		  if ( (unsigned int)v4 >= m_attachmentMapping->max_length.size )
		    sub_1800D2AB0(m_attachmentMapping, v7);
		  m_attachmentMapping->vector[v4] = index;
		}
		
		[IDTag(1)]
		private int GetAttachmentIndex(GBufferID gBufferID) => default; // 0x0000000189BBFB6C-0x0000000189BBFBE0
		// Int32 GetAttachmentIndex(GBufferID)
		int32_t HG::Rendering::Runtime::OnePassDeferredPassConstructor::GetAttachmentIndex(
		        OnePassDeferredPassConstructor *this,
		        GBufferID__Enum gBufferID,
		        MethodInfo *method)
		{
		  __int64 v3; // rdi
		  __int64 v5; // rdx
		  Int32__Array *m_attachmentMapping; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (int)gBufferID;
		  if ( IFix::WrappersManagerImpl::IsPatched(3273, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3273, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		               (ILFixDynamicMethodWrapper_6 *)Patch,
		               (Object *)this,
		               (NaviDirection__Enum)v3,
		               0LL);
		LABEL_7:
		    sub_1800D8260(m_attachmentMapping, v5);
		  }
		  m_attachmentMapping = this->fields.m_attachmentMapping;
		  if ( !m_attachmentMapping )
		    goto LABEL_7;
		  if ( (unsigned int)(v3 + 2) >= m_attachmentMapping->max_length.size )
		    sub_1800D2AB0(m_attachmentMapping, v5);
		  return m_attachmentMapping->vector[v3 + 2];
		}
		
		[IDTag(1)]
		private void SetAttachmentIndex(GBufferID gBufferID, int index) {} // 0x0000000189BBFDA0-0x0000000189BBFE24
		// Void SetAttachmentIndex(GBufferID, Int32)
		void HG::Rendering::Runtime::OnePassDeferredPassConstructor::SetAttachmentIndex(
		        OnePassDeferredPassConstructor *this,
		        GBufferID__Enum gBufferID,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v4; // rsi
		  __int64 v7; // rdx
		  Int32__Array *m_attachmentMapping; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = (int)gBufferID;
		  if ( IFix::WrappersManagerImpl::IsPatched(3270, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3270, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		        (ILFixDynamicMethodWrapper_6 *)Patch,
		        (Object *)this,
		        (UIInertiaViewPager_State__Enum)v4,
		        (UIInertiaViewPager_State__Enum)index,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_attachmentMapping, v7);
		  }
		  m_attachmentMapping = this->fields.m_attachmentMapping;
		  if ( !m_attachmentMapping )
		    goto LABEL_7;
		  if ( (unsigned int)(v4 + 2) >= m_attachmentMapping->max_length.size )
		    sub_1800D2AB0(m_attachmentMapping, v7);
		  m_attachmentMapping->vector[v4 + 2] = index;
		}
		
	}
}
