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
	internal class PostProcessPassConstructor : ComposablePass, IPassConstructor // TypeDefIndex: 38143
	{
		// Fields
		private Material m_FinalPassMaterial; // 0x10
		private Material m_UberPostMaterial; // 0x18
		private Material m_FisheyeEffectMaterial; // 0x20
		private Material m_FisheyeEffectDepthMaterial; // 0x28
		private Material m_LutBuilder2DMaterial; // 0x30
		private Material m_SharpenMaterial; // 0x38
		private Material m_SMAAMaterial; // 0x40
		private Material m_HorizontalBlurMaterial; // 0x48
		private MaterialPropertyBlock m_HorizontalBlurMPB; // 0x50
		private RTHandle[] m_sceneFrostedGlassRTs; // 0x58
		private Vector2Int[] m_sceneFrostedGlassRTSizes; // 0x60
		private UberPostPassUtils.FrostedGlassPSMaterials m_frostedGlassPSMaterials; // 0x68
		private Vector4 m_BloomBicubicParams; // 0x78
		internal UberPostPassUtils.BloomPSMaterials m_bloomPSMaterials; // 0x88
		private RTHandle m_cachedColorLut; // 0xA8
		private UberPostPassUtils.CachedColorGradingData m_cachedColorGradingPassData; // 0xB0
		private int m_LutSize; // 0x220
		private GraphicsFormat m_LutFormat; // 0x224
		private Bloom m_Bloom; // 0x228
		private Vignette m_Vignette; // 0x230
		private HGVignette m_HGVignette; // 0x238
		private HGDirtyLens m_HGDirtyLens; // 0x240
		private HGSharpen m_Sharpen; // 0x248
		private HGRadialBlur m_RadialBlur; // 0x250
		private HGBWFlash m_BWFlash; // 0x258
		private HGFisheyeEffect m_FisheyeEffect; // 0x260
		private HGChromaticAbberation m_chromaticAbberation; // 0x268
		private bool m_EnableAlpha; // 0x270
		private bool m_KeepAlpha; // 0x271
		private bool m_EnableAlphaForUI; // 0x272
		private bool m_NonRenderGraphResourcesAvailable; // 0x273
		internal const int k_RTGuardBandSize = 4; // Metadata: 0x02303A5A
		private HGRenderGraphBuilder m_renderGraphBuilder; // 0x278
		private static readonly RenderFunc<UberPostPassUtils.UberPostPassData> s_uberRenderFunc; // 0x00
		private static UberPostPassUtils.UberPostPassData s_uberPostDataCPP; // 0x08
		private const float kWorldUICullingDistance = 5000f; // Metadata: 0x02303A5B
		private static readonly RenderFunc<FinalPassData> s_finalRenderFunc; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38139
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal TextureHandle target; // 0x30
			internal CullingResults cullingResults; // 0x40
			internal TAAUQuality taauQuality; // 0x50
			internal DepthBits depthBits; // 0x54
			internal GraphicsFormat depthFormat; // 0x58
			internal HGRenderPathInternal renderPath; // 0x5C
			internal HGRenderPipeline hgrp; // 0x60
			internal bool render3DUI; // 0x68
			internal float renderingScale; // 0x6C
			internal float screenCullingRatio; // 0x70
			internal float screenCullingRatioDistance; // 0x74
			internal uint screenCullingLayerMask; // 0x78
		}
	
		internal struct PassOutput // TypeDefIndex: 38140
		{
			// Fields
			internal TextureHandle output; // 0x00
			internal TextureHandle frostedGlassRT; // 0x10
		}
	
		private class FinalPassData // TypeDefIndex: 38141
		{
			// Fields
			public Material finalPassMaterial; // 0x10
			public Rect backBufferRect; // 0x18
			public Vector4 viewPortSize; // 0x28
			public TextureHandle source; // 0x38
	
			// Constructors
			public FinalPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public PostProcessPassConstructor() {} // Dummy constructor
		internal PostProcessPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000183D75990-0x0000000183D75C90
		// PostProcessPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::PostProcessPassConstructor::PostProcessPassConstructor(
		        PostProcessPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 v10; // rax
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Shader **v13; // rdx
		  Vector2Int s_One; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rdi
		  HGSettingParameters *settingParameters; // rbp
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  HGRuntimeGrassQuery_Node *v30; // rdx
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  HGRuntimeGrassQuery_Node *v36; // rdx
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  MaterialPropertyBlock *v39; // r14
		  HGRuntimeGrassQuery_Node *v40; // rdx
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  SettingParameter_1_System_Int32_ *lutSize_k__BackingField; // rax
		  MethodInfo *v44; // [rsp+20h] [rbp-8h]
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+20h] [rbp-8h]
		  MethodInfo *v47; // [rsp+20h] [rbp-8h]
		  MethodInfo *v48; // [rsp+20h] [rbp-8h]
		  MethodInfo *v49; // [rsp+20h] [rbp-8h]
		  MethodInfo *v50; // [rsp+20h] [rbp-8h]
		  MethodInfo *v51; // [rsp+20h] [rbp-8h]
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_sceneFrostedGlassRTs = (RTHandle__Array *)il2cpp_array_new_specific_1(
		                                                             TypeInfo::UnityEngine::Rendering::RTHandle,
		                                                             3LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sceneFrostedGlassRTs, v7, v8, v9, v44);
		  v10 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 3LL);
		  v13 = (Shader **)v10;
		  s_One = TypeInfo::UnityEngine::Vector2Int->static_fields->s_One;
		  if ( !v10 )
		    goto LABEL_2;
		  if ( !*(_DWORD *)(v10 + 24)
		    || (*(Vector2Int *)(v10 + 32) = s_One,
		        s_One = TypeInfo::UnityEngine::Vector2Int->static_fields->s_One,
		        *(_DWORD *)(v10 + 24) <= 1u)
		    || (*(Vector2Int *)(v10 + 40) = s_One, *(_DWORD *)(v10 + 24) <= 2u) )
		  {
		    sub_1800D2AB0(s_One, v10);
		  }
		  *(Vector2Int *)(v10 + 48) = TypeInfo::UnityEngine::Vector2Int->static_fields->s_One;
		  this->fields.m_sceneFrostedGlassRTSizes = (Vector2Int__Array *)v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_sceneFrostedGlassRTSizes,
		    (HGRuntimeGrassQuery_Node *)v10,
		    v11,
		    v12,
		    v45);
		  defaultResources = resources->defaultResources;
		  settingParameters = resources->settingParameters;
		  if ( !defaultResources )
		    goto LABEL_2;
		  shaders = defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_2;
		  if ( !materialCollector )
		    goto LABEL_2;
		  this->fields.m_FinalPassMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                       materialCollector,
		                                       shaders->fields.finalPassPS,
		                                       0,
		                                       0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v18, v19, v20, v46);
		  v13 = (Shader **)defaultResources->fields.shaders;
		  if ( !v13 )
		    goto LABEL_2;
		  this->fields.m_UberPostMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                      materialCollector,
		                                      v13[93],
		                                      0,
		                                      0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_UberPostMaterial, v21, v22, v23, v47);
		  v13 = (Shader **)defaultResources->fields.shaders;
		  if ( !v13 )
		    goto LABEL_2;
		  this->fields.m_FisheyeEffectMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                           materialCollector,
		                                           v13[93],
		                                           0,
		                                           0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FisheyeEffectMaterial, v24, v25, v26, v48);
		  v13 = (Shader **)defaultResources->fields.shaders;
		  if ( !v13 )
		    goto LABEL_2;
		  this->fields.m_FisheyeEffectDepthMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                materialCollector,
		                                                v13[93],
		                                                0,
		                                                0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FisheyeEffectDepthMaterial, v27, v28, v29, v49);
		  v13 = (Shader **)defaultResources->fields.shaders;
		  if ( !v13 )
		    goto LABEL_2;
		  this->fields.m_LutBuilder2DMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                          materialCollector,
		                                          v13[91],
		                                          0,
		                                          0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_LutBuilder2DMaterial, v30, v31, v32, v50);
		  v13 = (Shader **)defaultResources->fields.shaders;
		  if ( !v13 )
		    goto LABEL_2;
		  this->fields.m_SharpenMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                     materialCollector,
		                                     v13[96],
		                                     0,
		                                     0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_SharpenMaterial, v33, v34, v35, v51);
		  v13 = (Shader **)defaultResources->fields.shaders;
		  if ( !v13 )
		    goto LABEL_2;
		  this->fields.m_HorizontalBlurMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                            materialCollector,
		                                            v13[44],
		                                            0,
		                                            0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_HorizontalBlurMaterial, v36, v37, v38, v52);
		  v39 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v39 )
		    goto LABEL_2;
		  v39->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_HorizontalBlurMPB = v39;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_HorizontalBlurMPB, v40, v41, v42, v53);
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  HG::Rendering::Runtime::UberPostPassUtils::PrepareBloomPSMaterials(
		    materialCollector,
		    &this->fields.m_bloomPSMaterials,
		    defaultResources,
		    0LL);
		  HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassPSMaterials(
		    materialCollector,
		    &this->fields.m_frostedGlassPSMaterials,
		    defaultResources,
		    0LL);
		  if ( !settingParameters || (lutSize_k__BackingField = settingParameters->fields._lutSize_k__BackingField) == 0LL )
		LABEL_2:
		    sub_1800D8260(s_One, v13);
		  this->fields.m_LutSize = lutSize_k__BackingField->fields._paramValue_k__BackingField;
		  this->fields.m_LutFormat = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                               (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._lutFormat_k__BackingField,
		                               MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit);
		  this->fields.m_cachedColorGradingPassData.lutSize = -1;
		}
		
		static PostProcessPassConstructor() {} // 0x0000000184A43350-0x0000000184A43490
		// PostProcessPassConstructor()
		void HG::Rendering::Runtime::PostProcessPassConstructor::cctor(MethodInfo *method)
		{
		  struct PostProcessPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node__Class *v6; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  UberPostPassUtils_UberPostPassData *v10; // rax
		  MonitorData *v11; // rbx
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  Object *v15; // rdi
		  RenderFunc_1_System_Object_ *v16; // rax
		  RenderFunc_1_HG_Rendering_Runtime_PostProcessPassConstructor_FinalPassData_ *v17; // rbx
		  PostProcessPassConstructor__StaticFields *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c::__cctor_b__51_0,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v21);
		  v10 = (UberPostPassUtils_UberPostPassData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData);
		  v11 = (MonitorData *)v10;
		  if ( !v10
		    || (HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData::UberPostPassData(v10, 0LL),
		        v12 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields,
		        v12->monitor = v11,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields->s_uberPostDataCPP,
		          v12,
		          v13,
		          v14,
		          v22),
		        v15 = (Object *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c->static_fields->__9,
		        v16 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>),
		        (v17 = (RenderFunc_1_HG_Rendering_Runtime_PostProcessPassConstructor_FinalPassData_ *)v16) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v16,
		    v15,
		    MethodInfo::HG::Rendering::Runtime::PostProcessPassConstructor::__c::__cctor_b__51_1,
		    0LL);
		  v18 = TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields;
		  v18->s_finalRenderFunc = v17;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields->s_finalRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v18,
		    v19,
		    v20,
		    v23);
		}
		
	
		// Methods
		internal TextureHandle HorizontalBlurPassPreTAAU(HGRenderGraph renderGraph, HGCamera camera, TextureHandle source, float radius, bool useBlurTarget, float blurTargetAngleDeg, bool useBlurCenter, Vector2 blurCenterUV, float blurCenterFadeWidth) => default; // 0x0000000189B8D61C-0x0000000189B8D7E0
		// TextureHandle HorizontalBlurPassPreTAAU(HGRenderGraph, HGCamera, TextureHandle, Single, Boolean, Single, Boolean, Vector2, Single)
		TextureHandle *HG::Rendering::Runtime::PostProcessPassConstructor::HorizontalBlurPassPreTAAU(
		        TextureHandle *__return_ptr retstr,
		        PostProcessPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        TextureHandle *source,
		        float radius,
		        bool useBlurTarget,
		        float blurTargetAngleDeg,
		        bool useBlurCenter,
		        Vector2 blurCenterUV,
		        float blurCenterFadeWidth,
		        MethodInfo *method)
		{
		  Material *m_HorizontalBlurMaterial; // rsi
		  MaterialPropertyBlock *m_HorizontalBlurMPB; // rdi
		  ProfilingSampler *v18; // rbx
		  TextureHandle *v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v21; // rcx
		  TextureHandle v22; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v24; // [rsp+70h] [rbp-38h] BYREF
		  TextureHandle v25; // [rsp+80h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2941, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2941, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, 0LL);
		    v24 = *source;
		    v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1089(
		            &v25,
		            Patch,
		            (Object *)this,
		            (Object *)renderGraph,
		            (Object *)camera,
		            &v24,
		            radius,
		            useBlurTarget,
		            blurTargetAngleDeg,
		            useBlurCenter,
		            blurCenterUV,
		            blurCenterFadeWidth,
		            0LL);
		  }
		  else
		  {
		    m_HorizontalBlurMaterial = this->fields.m_HorizontalBlurMaterial;
		    m_HorizontalBlurMPB = this->fields.m_HorizontalBlurMPB;
		    v18 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x8Eu,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass);
		    v24 = *source;
		    v19 = HG::Rendering::Runtime::HorizontalBlurPass::Render(
		            &v25,
		            renderGraph,
		            camera,
		            &v24,
		            radius,
		            useBlurTarget,
		            blurTargetAngleDeg,
		            useBlurCenter,
		            blurCenterUV,
		            blurCenterFadeWidth,
		            m_HorizontalBlurMaterial,
		            m_HorizontalBlurMPB,
		            v18,
		            0LL);
		  }
		  v22 = *v19;
		  result = retstr;
		  *retstr = v22;
		  return result;
		}
		
		protected override HGRenderGraphBuilder? GetRenderGraphBuilder(HGRenderGraph renderGraph) => default; // 0x0000000189B8D15C-0x0000000189B8D218
		// Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
		Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::PostProcessPassConstructor::GetRenderGraphBuilder(
		        Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
		        PostProcessPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v12; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2943, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2943, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1090(&v12, Patch, (Object *)this, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    v7 = *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderGraph;
		    *(_OWORD *)&v12.hasValue = *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderPass;
		    *(_OWORD *)&retstr->hasValue = 0LL;
		    *(_OWORD *)&retstr->value.m_Resources = 0LL;
		    *(_QWORD *)&retstr->value.m_Disposed = 0LL;
		    *(_OWORD *)&v12.value.m_Resources = v7;
		    sub_1803683D4(retstr, &v12);
		  }
		  return retstr;
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B8D5C8-0x0000000189B8D61C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        PostProcessPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2944, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2944, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B8D26C-0x0000000189B8D5C8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        PostProcessPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  RTHandle__Array *v5; // rdx
		  void *renderGraph; // rcx
		  RTHandle__Array *m_sceneFrostedGlassRTs; // rax
		  HGRenderGraphContext *HGContext; // rax
		  CommandBuffer *cmd; // rdi
		  int32_t v10; // esi
		  RenderTargetIdentifier *v11; // rax
		  RTHandle__Array *v12; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  __int128 v14; // xmm1
		  int32_t FrostedGlassTexMedium; // esi
		  RenderTargetIdentifier *v16; // rax
		  __int128 v17; // xmm1
		  RTHandle__Array *v18; // rdx
		  HGShaderIDs__StaticFields *v19; // rcx
		  int32_t FrostedGlassTexHeavy; // esi
		  RenderTargetIdentifier *v21; // rax
		  __int128 v22; // xmm1
		  RTHandle__Array *v23; // rdx
		  HGShaderIDs__StaticFields *v24; // rcx
		  int32_t FrostedGlassTexLightScene; // esi
		  RenderTargetIdentifier *v26; // rax
		  __int128 v27; // xmm1
		  RTHandle__Array *v28; // rdx
		  HGShaderIDs__StaticFields *v29; // rcx
		  int32_t FrostedGlassTexMediumScene; // esi
		  RenderTargetIdentifier *v31; // rax
		  __int128 v32; // xmm1
		  RTHandle__Array *v33; // rdx
		  HGShaderIDs__StaticFields *v34; // rcx
		  int32_t FrostedGlassTexHeavyScene; // esi
		  RenderTargetIdentifier *v36; // rax
		  __int128 v37; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderTargetIdentifier v39; // [rsp+20h] [rbp-60h] BYREF
		  RenderTargetIdentifier v40; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2945, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2945, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		      return;
		    }
		    goto LABEL_33;
		  }
		  *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderPass = 0LL;
		  *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderGraph = 0LL;
		  m_sceneFrostedGlassRTs = this->fields.m_sceneFrostedGlassRTs;
		  if ( !m_sceneFrostedGlassRTs )
		    goto LABEL_33;
		  if ( !m_sceneFrostedGlassRTs->max_length.size )
		    goto LABEL_31;
		  if ( !m_sceneFrostedGlassRTs->vector[0] )
		    return;
		  renderGraph = input->renderGraph;
		  if ( !renderGraph
		    || (HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext((HGRenderGraph *)renderGraph, 0LL)) == 0LL
		    || (cmd = HGContext->fields.cmd,
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
		        v5 = this->fields.m_sceneFrostedGlassRTs,
		        renderGraph = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields,
		        v10 = *((_DWORD *)renderGraph + 450),
		        !v5) )
		  {
		LABEL_33:
		    sub_1800D8260(renderGraph, v5);
		  }
		  if ( !v5->max_length.size )
		LABEL_31:
		    sub_1800D2AB0(renderGraph, v5);
		  v11 = UnityEngine::Rendering::RTHandle::op_Implicit(&v40, v5->vector[0], 0LL);
		  if ( !cmd )
		    goto LABEL_30;
		  v14 = *(_OWORD *)&v11->m_BufferPointer;
		  *(_OWORD *)&v39.m_Type = *(_OWORD *)&v11->m_Type;
		  *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v11->m_DepthSlice;
		  *(_OWORD *)&v39.m_BufferPointer = v14;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v10, &v39, 0LL);
		  v12 = this->fields.m_sceneFrostedGlassRTs;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  FrostedGlassTexMedium = static_fields->_FrostedGlassTexMedium;
		  if ( !v12 )
		LABEL_30:
		    sub_1800D8260(static_fields, v12);
		  if ( v12->max_length.size <= 1u )
		    sub_1800D2AB0(static_fields, v12);
		  v16 = UnityEngine::Rendering::RTHandle::op_Implicit(&v40, v12->vector[1], 0LL);
		  v17 = *(_OWORD *)&v16->m_BufferPointer;
		  *(_OWORD *)&v39.m_Type = *(_OWORD *)&v16->m_Type;
		  *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v16->m_DepthSlice;
		  *(_OWORD *)&v39.m_BufferPointer = v17;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexMedium, &v39, 0LL);
		  v18 = this->fields.m_sceneFrostedGlassRTs;
		  v19 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  FrostedGlassTexHeavy = v19->_FrostedGlassTexHeavy;
		  if ( !v18 )
		    sub_1800D8260(v19, 0LL);
		  if ( v18->max_length.size <= 2u )
		    sub_1800D2AB0(v19, v18);
		  v21 = UnityEngine::Rendering::RTHandle::op_Implicit(&v40, v18->vector[2], 0LL);
		  v22 = *(_OWORD *)&v21->m_BufferPointer;
		  *(_OWORD *)&v39.m_Type = *(_OWORD *)&v21->m_Type;
		  *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v21->m_DepthSlice;
		  *(_OWORD *)&v39.m_BufferPointer = v22;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexHeavy, &v39, 0LL);
		  v23 = this->fields.m_sceneFrostedGlassRTs;
		  v24 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  FrostedGlassTexLightScene = v24->_FrostedGlassTexLightScene;
		  if ( !v23 )
		    sub_1800D8260(v24, 0LL);
		  if ( !v23->max_length.size )
		    sub_1800D2AB0(v24, v23);
		  v26 = UnityEngine::Rendering::RTHandle::op_Implicit(&v40, v23->vector[0], 0LL);
		  v27 = *(_OWORD *)&v26->m_BufferPointer;
		  *(_OWORD *)&v39.m_Type = *(_OWORD *)&v26->m_Type;
		  *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v26->m_DepthSlice;
		  *(_OWORD *)&v39.m_BufferPointer = v27;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexLightScene, &v39, 0LL);
		  v28 = this->fields.m_sceneFrostedGlassRTs;
		  v29 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  FrostedGlassTexMediumScene = v29->_FrostedGlassTexMediumScene;
		  if ( !v28 )
		    sub_1800D8260(v29, 0LL);
		  if ( v28->max_length.size <= 1u )
		    sub_1800D2AB0(v29, v28);
		  v31 = UnityEngine::Rendering::RTHandle::op_Implicit(&v40, v28->vector[1], 0LL);
		  v32 = *(_OWORD *)&v31->m_BufferPointer;
		  *(_OWORD *)&v39.m_Type = *(_OWORD *)&v31->m_Type;
		  *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v31->m_DepthSlice;
		  *(_OWORD *)&v39.m_BufferPointer = v32;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexMediumScene, &v39, 0LL);
		  v33 = this->fields.m_sceneFrostedGlassRTs;
		  v34 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  FrostedGlassTexHeavyScene = v34->_FrostedGlassTexHeavyScene;
		  if ( !v33 )
		    sub_1800D8260(v34, 0LL);
		  if ( v33->max_length.size <= 2u )
		    sub_1800D2AB0(v34, v33);
		  v36 = UnityEngine::Rendering::RTHandle::op_Implicit(&v40, v33->vector[2], 0LL);
		  v37 = *(_OWORD *)&v36->m_BufferPointer;
		  *(_OWORD *)&v39.m_Type = *(_OWORD *)&v36->m_Type;
		  *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v36->m_DepthSlice;
		  *(_OWORD *)&v39.m_BufferPointer = v37;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FrostedGlassTexHeavyScene, &v39, 0LL);
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters) {} // 0x0000000189B8C79C-0x0000000189B8CDA0
		// Void ConstructPass(PostProcessPassConstructor+PassInput ByRef, PostProcessPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		void HG::Rendering::Runtime::PostProcessPassConstructor::ConstructPass(
		        PostProcessPassConstructor *this,
		        PostProcessPassConstructor_PassInput *input,
		        PostProcessPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // r10
		  Vignette *v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  __int64 v20; // r10
		  HGVignette *v21; // r9
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  __int64 v24; // r10
		  HGDirtyLens *v25; // r9
		  HGRuntimeGrassQuery_Node *v26; // rdx
		  HGRuntimeGrassQuery_Node *v27; // r8
		  __int64 v28; // r10
		  HGSharpen *v29; // r9
		  HGRuntimeGrassQuery_Node *v30; // rdx
		  HGRuntimeGrassQuery_Node *v31; // r8
		  __int64 v32; // r10
		  HGRadialBlur *v33; // r9
		  HGRuntimeGrassQuery_Node *v34; // rdx
		  HGRuntimeGrassQuery_Node *v35; // r8
		  __int64 v36; // r10
		  HGBWFlash *v37; // r9
		  HGRuntimeGrassQuery_Node *v38; // rdx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  __int64 v40; // r10
		  HGFisheyeEffect *v41; // r9
		  HGRuntimeGrassQuery_Node *v42; // rdx
		  HGRuntimeGrassQuery_Node *v43; // r8
		  __int64 v44; // r10
		  HGChromaticAbberation *v45; // r9
		  HGRuntimeGrassQuery_Node *v46; // rdx
		  HGRuntimeGrassQuery_Node *v47; // r8
		  TextureHandle sceneColor; // xmm7
		  TextureHandle target; // xmm0
		  HGSharpen *m_Sharpen; // rdi
		  Material *m_SharpenMaterial; // rbx
		  BOOL v52; // eax
		  TextureHandle sceneDepth; // xmm8
		  HGFisheyeEffect *m_FisheyeEffect; // rsi
		  Material *m_FisheyeEffectMaterial; // rdi
		  Material *m_FisheyeEffectDepthMaterial; // rbx
		  TextureHandle *v57; // rax
		  int32_t m_LutSize; // esi
		  unsigned int m_LutFormat; // edi
		  Material *m_LutBuilder2DMaterial; // rbx
		  TextureHandle v61; // xmm9
		  Bloom *m_Bloom; // rsi
		  TextureHandle sceneMV; // xmm6
		  unsigned int taauQuality; // edi
		  unsigned int renderPath; // ebx
		  TextureHandle *v66; // rax
		  int32_t v67; // r8d
		  TextureHandle v68; // xmm10
		  TextureHandle *v69; // rax
		  TextureHandle v70; // xmm11
		  TextureHandle v71; // xmm6
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3a; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3b; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3c; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3d; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3e; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3f; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3g; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3h; // [rsp+28h] [rbp-E0h]
		  BOOL v81; // [rsp+78h] [rbp-90h]
		  TextureHandle v82; // [rsp+88h] [rbp-80h] BYREF
		  TextureHandle v83; // [rsp+98h] [rbp-70h] BYREF
		  TextureHandle v84; // [rsp+A8h] [rbp-60h] BYREF
		  TextureHandle v85[7]; // [rsp+B8h] [rbp-50h] BYREF
		
		  v82 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2946, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2946, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1096(
		        Patch,
		        (Object *)this,
		        input,
		        output,
		        (Object *)renderGraph,
		        (Object *)camera,
		        (Object *)settingParameters,
		        0LL);
		      return;
		    }
		    goto LABEL_26;
		  }
		  if ( !camera )
		    goto LABEL_26;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_26;
		  this->fields.m_Bloom = volumeComponentsData->fields.m_bloom;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_Bloom, v11, v14, v15, P3);
		  v17 = *(Vignette **)(v16 + 24);
		  this->fields.m_Vignette = v17;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_Vignette, v18, v19, (Int32__Array **)v17, P3a);
		  v21 = *(HGVignette **)(v20 + 32);
		  this->fields.m_HGVignette = v21;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_HGVignette, v22, v23, (Int32__Array **)v21, P3b);
		  v25 = *(HGDirtyLens **)(v24 + 40);
		  this->fields.m_HGDirtyLens = v25;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_HGDirtyLens, v26, v27, (Int32__Array **)v25, P3c);
		  v29 = *(HGSharpen **)(v28 + 48);
		  this->fields.m_Sharpen = v29;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_Sharpen, v30, v31, (Int32__Array **)v29, P3d);
		  v33 = *(HGRadialBlur **)(v32 + 56);
		  this->fields.m_RadialBlur = v33;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_RadialBlur, v34, v35, (Int32__Array **)v33, P3e);
		  v37 = *(HGBWFlash **)(v36 + 72);
		  this->fields.m_BWFlash = v37;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_BWFlash, v38, v39, (Int32__Array **)v37, P3f);
		  v41 = *(HGFisheyeEffect **)(v40 + 80);
		  this->fields.m_FisheyeEffect = v41;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FisheyeEffect, v42, v43, (Int32__Array **)v41, P3g);
		  v45 = *(HGChromaticAbberation **)(v44 + 88);
		  this->fields.m_chromaticAbberation = v45;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_chromaticAbberation, v46, v47, (Int32__Array **)v45, P3h);
		  this->fields.m_EnableAlphaForUI = input->render3DUI;
		  sceneColor = input->sceneColor;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  if ( !HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(camera, 0LL) )
		  {
		    target = input->target;
		    v82 = sceneColor;
		    v83 = target;
		    HG::Rendering::Runtime::PostProcessPassConstructor::FinalPass(this, renderGraph, camera, &v83, &v82, 0LL);
		    return;
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_Sharpen;
		  if ( !Patch )
		    goto LABEL_26;
		  if ( HG::Rendering::Runtime::HGSharpen::IsActive((HGSharpen *)Patch, 0LL) )
		  {
		    if ( !settingParameters )
		      goto LABEL_26;
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParameters->fields._sharpenEnabled_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      m_Sharpen = this->fields.m_Sharpen;
		      m_SharpenMaterial = this->fields.m_SharpenMaterial;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v83 = sceneColor;
		      sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::SharpenPass(
		                      &v84,
		                      renderGraph,
		                      camera,
		                      &v83,
		                      m_Sharpen,
		                      m_SharpenMaterial,
		                      0LL);
		    }
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_FisheyeEffect;
		  if ( !Patch )
		LABEL_26:
		    sub_1800D8260(Patch, v11);
		  if ( HG::Rendering::Runtime::HGFisheyeEffect::IsActive((HGFisheyeEffect *)Patch, 0LL) )
		  {
		    if ( settingParameters )
		    {
		      v52 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              settingParameters->fields._fisheyeEffectEnabled_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      goto LABEL_16;
		    }
		    goto LABEL_26;
		  }
		  v52 = 0;
		LABEL_16:
		  sceneDepth = input->sceneDepth;
		  if ( v52 )
		  {
		    m_FisheyeEffect = this->fields.m_FisheyeEffect;
		    m_FisheyeEffectMaterial = this->fields.m_FisheyeEffectMaterial;
		    m_FisheyeEffectDepthMaterial = this->fields.m_FisheyeEffectDepthMaterial;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    v83 = sceneDepth;
		    v84 = sceneColor;
		    v57 = HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectPass(
		            v85,
		            settingParameters,
		            renderGraph,
		            camera,
		            m_FisheyeEffect,
		            m_FisheyeEffectMaterial,
		            m_FisheyeEffectDepthMaterial,
		            &v84,
		            &v83,
		            &v82,
		            0LL);
		    sceneDepth = v82;
		    sceneColor = *v57;
		  }
		  m_LutSize = this->fields.m_LutSize;
		  m_LutFormat = this->fields.m_LutFormat;
		  m_LutBuilder2DMaterial = this->fields.m_LutBuilder2DMaterial;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  v61 = *HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPass(
		           v85,
		           renderGraph,
		           camera,
		           m_LutSize,
		           (GraphicsFormat__Enum)m_LutFormat,
		           m_LutBuilder2DMaterial,
		           &this->fields.m_cachedColorGradingPassData,
		           &this->fields.m_cachedColorLut,
		           0LL);
		  v81 = this->fields.m_EnableAlpha || this->fields.m_EnableAlphaForUI;
		  m_Bloom = this->fields.m_Bloom;
		  sceneMV = input->sceneMV;
		  taauQuality = input->taauQuality;
		  renderPath = input->renderPath;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  v84 = sceneMV;
		  v83 = sceneColor;
		  v66 = HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
		          v85,
		          renderGraph,
		          camera,
		          settingParameters,
		          m_Bloom,
		          v81,
		          &v83,
		          &v84,
		          (TAAUQuality__Enum)taauQuality,
		          (HGRenderPathInternal__Enum)renderPath,
		          &this->fields.m_bloomPSMaterials,
		          &this->fields.m_BloomBicubicParams,
		          0LL);
		  v67 = this->fields.m_LutSize;
		  v84 = v61;
		  v83 = sceneColor;
		  v68 = *v66;
		  v69 = HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPass(
		          v85,
		          renderGraph,
		          camera,
		          settingParameters,
		          &v83,
		          &v84,
		          v67,
		          &this->fields.m_frostedGlassPSMaterials,
		          &this->fields.m_sceneFrostedGlassRTs,
		          &this->fields.m_sceneFrostedGlassRTSizes,
		          0LL);
		  v84 = sceneColor;
		  v70 = *v69;
		  HG::Rendering::Runtime::UberPostPassUtils::ExecuteAutoExposure(renderGraph, &v84, camera, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		  if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_useCutsceneEffsectShader )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_enableCompatibilityMode )
		    {
		      v71 = input->target;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v84 = sceneColor;
		      v83 = sceneDepth;
		      v82 = v71;
		      sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectPass(
		                      v85,
		                      settingParameters,
		                      renderGraph,
		                      camera,
		                      &v82,
		                      &v83,
		                      &v84,
		                      0LL);
		    }
		  }
		  v84 = v68;
		  v83 = v61;
		  v82 = sceneColor;
		  HG::Rendering::Runtime::PostProcessPassConstructor::UberPass(
		    v85,
		    this,
		    input,
		    settingParameters,
		    renderGraph,
		    camera,
		    &v82,
		    &v83,
		    &v84,
		    0LL);
		  camera->fields.didResetPostProcessingHistoryInLastFrame = camera->fields.resetPostProcessingHistory;
		  camera->fields.resetPostProcessingHistory = 0;
		  output->frostedGlassRT = v70;
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B8D218-0x0000000189B8D26C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        PostProcessPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2954, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2954, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x00000001837DC340-0x00000001837DC4E0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::PostProcessPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        PostProcessPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object_1 *m_FinalPassMaterial; // rbx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  int i; // ebx
		  RTHandle__Array *m_sceneFrostedGlassRTs; // rcx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  HGRuntimeGrassQuery_Node *v26; // rdx
		  HGRuntimeGrassQuery_Node *v27; // r8
		  Int32__Array **v28; // r9
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  HGRuntimeGrassQuery_Node *v35; // rdx
		  HGRuntimeGrassQuery_Node *v36; // r8
		  Int32__Array **v37; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		  MethodInfo *v41; // [rsp+20h] [rbp-8h]
		  MethodInfo *v42; // [rsp+20h] [rbp-8h]
		  MethodInfo *v43; // [rsp+20h] [rbp-8h]
		  MethodInfo *v44; // [rsp+20h] [rbp-8h]
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+20h] [rbp-8h]
		  MethodInfo *v47; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2955, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2955, 0LL);
		    if ( !Patch )
		LABEL_14:
		      sub_1800D8260(m_sceneFrostedGlassRTs, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    m_FinalPassMaterial = (Object_1 *)this->fields.m_FinalPassMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_FinalPassMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_UberPostMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_FisheyeEffectMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_FisheyeEffectDepthMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_LutBuilder2DMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_SharpenMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_SMAAMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_HorizontalBlurMaterial, 0LL);
		    for ( i = 0; i < 3; ++i )
		    {
		      m_sceneFrostedGlassRTs = this->fields.m_sceneFrostedGlassRTs;
		      if ( !m_sceneFrostedGlassRTs )
		        goto LABEL_14;
		      if ( (unsigned int)i >= m_sceneFrostedGlassRTs->max_length.size )
		        sub_1800D2AB0(m_sceneFrostedGlassRTs, v6);
		      if ( m_sceneFrostedGlassRTs->vector[i] )
		      {
		        UnityEngine::Rendering::RTHandle::Release(m_sceneFrostedGlassRTs->vector[i], 0LL);
		        m_sceneFrostedGlassRTs = this->fields.m_sceneFrostedGlassRTs;
		        if ( !m_sceneFrostedGlassRTs )
		          goto LABEL_14;
		        sub_180378FEC(m_sceneFrostedGlassRTs, i, 0LL);
		      }
		    }
		    if ( this->fields.m_cachedColorLut )
		    {
		      UnityEngine::Rendering::RTHandle::Release(this->fields.m_cachedColorLut, 0LL);
		      this->fields.m_cachedColorLut = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_cachedColorLut, v35, v36, v37, v39);
		    }
		    this->fields.m_FinalPassMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v39);
		    this->fields.m_UberPostMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_UberPostMaterial, v11, v12, v13, v40);
		    this->fields.m_FisheyeEffectMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FisheyeEffectMaterial, v14, v15, v16, v41);
		    this->fields.m_FisheyeEffectDepthMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FisheyeEffectDepthMaterial, v17, v18, v19, v42);
		    this->fields.m_LutBuilder2DMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_LutBuilder2DMaterial, v20, v21, v22, v43);
		    this->fields.m_SharpenMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_SharpenMaterial, v23, v24, v25, v44);
		    this->fields.m_SMAAMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_SMAAMaterial, v26, v27, v28, v45);
		    this->fields.m_HorizontalBlurMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_HorizontalBlurMaterial, v29, v30, v31, v46);
		    this->fields.m_HorizontalBlurMPB = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_HorizontalBlurMPB, v32, v33, v34, v47);
		    if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::DisposeBloomPSMaterials(&this->fields.m_bloomPSMaterials, 0LL);
		    HG::Rendering::Runtime::UberPostPassUtils::DisposeFrostedGlassPSMaterials(
		      &this->fields.m_frostedGlassPSMaterials,
		      0LL);
		  }
		}
		
		private void PrepareWorldUIData(UberPostPassUtils.UberPostPassData data, HGCamera hgCamera, TextureHandle depthRT) {} // 0x0000000189B8D7E0-0x0000000189B8D878
		// Void PrepareWorldUIData(UberPostPassUtils+UberPostPassData, HGCamera, TextureHandle)
		void HG::Rendering::Runtime::PostProcessPassConstructor::PrepareWorldUIData(
		        PostProcessPassConstructor *this,
		        UberPostPassUtils_UberPostPassData *data,
		        HGCamera *hgCamera,
		        TextureHandle *depthRT,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2950, 0LL) )
		  {
		    if ( data )
		    {
		      data->fields.sceneDepthBuffer = *depthRT;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2950, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v12 = *depthRT;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1092(Patch, (Object *)this, (Object *)data, (Object *)hgCamera, &v12, 0LL);
		}
		
		private TextureHandle UberPass(ref PassInput input, HGSettingParameters settingParameters, HGRenderGraph renderGraph, HGCamera camera, TextureHandle source, TextureHandle logLut, TextureHandle bloomTexture) => default; // 0x0000000189B8D8B0-0x0000000189B8F4D4
		// TextureHandle UberPass(PostProcessPassConstructor+PassInput ByRef, HGSettingParameters, HGRenderGraph, HGCamera, TextureHandle, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::PostProcessPassConstructor::UberPass(
		        TextureHandle *__return_ptr retstr,
		        PostProcessPassConstructor *this,
		        PostProcessPassConstructor_PassInput *input,
		        HGSettingParameters *settingParameters,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        TextureHandle *source,
		        TextureHandle *logLut,
		        TextureHandle *bloomTexture,
		        MethodInfo *method)
		{
		  PostProcessPassConstructor *v12; // r13
		  ProfilingSampler *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  int v17; // eax
		  unsigned __int64 v18; // r8
		  signed __int64 v19; // rtt
		  UberPostPassUtils_UberPostPassData *v20; // rdx
		  Material *m_UberPostMaterial; // rcx
		  unsigned __int64 v22; // rdx
		  unsigned __int64 v23; // r8
		  signed __int64 v24; // rtt
		  Material *uberPostMaterial; // rcx
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  HGCamera *v28; // rbx
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  Material *v31; // rbx
		  __int64 v32; // rcx
		  HGShaderKeyWords__StaticFields *static_fields; // rdx
		  __int64 v34; // rdx
		  float PostExposureLinear; // xmm0_4
		  __int64 m_LutSize; // rcx
		  float v37; // xmm3_4
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  HGColorGradingConfig *p_colorGradingConfig; // rax
		  HGColorGradingConfig *v42; // rcx
		  __int64 v43; // rdx
		  __int128 v44; // xmm1
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  UberPostPassUtils_UberPostPassData *v47; // rbx
		  Texture2D *blackTexture; // rax
		  unsigned __int64 v49; // rdx
		  signed __int64 v50; // rcx
		  unsigned __int64 v51; // r8
		  signed __int64 v52; // rtt
		  Material *v53; // rbx
		  __int64 v54; // rcx
		  HGShaderKeyWords__StaticFields *v55; // rdx
		  signed __int64 v56; // rcx
		  UberPostPassUtils_UberPostPassData *v57; // rdx
		  unsigned __int64 v58; // rdx
		  unsigned __int64 v59; // r8
		  char v60; // dl
		  signed __int64 v61; // rtt
		  UberPostPassUtils_UberPostPassData *v62; // rbx
		  __int64 v63; // rcx
		  int v64; // r14d
		  __int64 v65; // rcx
		  int v66; // esi
		  int v67; // eax
		  UberPostPassUtils_PPVignetteData *vignetteData; // r15
		  Object *m_Vignette; // rbx
		  Object *m_HGVignette; // r14
		  Object *P4; // rsi
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  bool IsActive; // si
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  bool v79; // r12
		  unsigned __int64 v80; // rdx
		  signed __int64 v81; // rcx
		  Object__Class *klass; // rdx
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  int v85; // r13d
		  MonitorData *monitor; // rsi
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  double v89; // xmm0_8
		  float v90; // xmm14_4
		  Object__Class *v91; // rsi
		  __int64 v92; // rax
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  int v95; // xmm15_4
		  MonitorData *v96; // rsi
		  __int64 v97; // rdx
		  __int64 v98; // rcx
		  double v99; // xmm0_8
		  float v100; // xmm13_4
		  Object__Class *v101; // rsi
		  __int64 v102; // rdx
		  __int64 v103; // rcx
		  double v104; // xmm0_8
		  float v105; // xmm10_4
		  Object__Class *v106; // rsi
		  __int64 v107; // rdx
		  __int64 v108; // rcx
		  MonitorData *v109; // rsi
		  __int64 v110; // rdx
		  __int64 v111; // rcx
		  __m128 v112; // xmm7
		  float v113; // xmm8_4
		  float v114; // xmm9_4
		  Object__Class *v115; // rsi
		  __int64 v116; // rdx
		  __int64 v117; // rcx
		  __int64 v118; // rsi
		  MonitorData *v119; // rbx
		  __int64 v120; // rdx
		  __int64 v121; // rcx
		  double v122; // xmm0_8
		  float v123; // xmm6_4
		  MonitorData *v124; // rbx
		  __int64 v125; // rdx
		  __int64 v126; // rcx
		  char v127; // r13
		  Object__Class *v128; // rbx
		  __int64 v129; // rdx
		  __int64 v130; // rcx
		  char v131; // r12
		  Object__Class *v132; // rbx
		  __int64 v133; // rdx
		  __int64 v134; // rcx
		  __m128 v135; // xmm6
		  int32_t v136; // xmm11_4
		  MonitorData *v137; // rbx
		  __int64 v138; // rdx
		  __int64 v139; // rcx
		  double v140; // xmm0_8
		  Object__Class *v141; // rbx
		  double v142; // xmm0_8
		  double v143; // xmm0_8
		  __int64 v144; // rdx
		  __int64 v145; // rcx
		  Object__Class *v146; // rbx
		  __int64 v147; // rcx
		  HGShaderKeyWords__StaticFields *v148; // rdx
		  Beyond::JobMathf *v149; // rcx
		  __int64 v150; // rdx
		  __int64 v151; // rcx
		  __m128i si128; // xmm0
		  unsigned __int64 v153; // r8
		  signed __int64 v154; // rtt
		  UberPostPassUtils_PPBloomData *bloomData; // r14
		  Bloom *m_Bloom; // rbx
		  Material *v157; // r13
		  __m128i v158; // xmm13
		  __int64 v159; // rdx
		  __int64 v160; // rcx
		  __int64 v161; // rdx
		  __int64 v162; // rcx
		  __int64 v163; // rdx
		  __int64 v164; // rcx
		  double v165; // xmm0_8
		  float v166; // xmm9_4
		  ColorParameter *tint; // rsi
		  __m128 v168; // xmm6
		  float v169; // xmm3_4
		  Vector4 *one; // rax
		  __int64 v171; // rdx
		  __int64 v172; // rcx
		  __int64 v173; // rdx
		  HGShaderKeyWords__StaticFields *v174; // rcx
		  __int64 v175; // rdx
		  __int64 v176; // rcx
		  int32_t v177; // xmm0_4
		  int32_t v178; // xmm0_4
		  unsigned __int64 v179; // r8
		  signed __int64 v180; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v182; // rdx
		  __int64 v183; // rcx
		  __m128i v184; // xmm10
		  Texture2DParameter *dirtTexture; // rsi
		  Object_1 *v186; // rsi
		  __int64 v187; // rdx
		  __int64 v188; // rcx
		  Texture2D *v189; // rsi
		  Texture2DParameter *v190; // rsi
		  __int64 v191; // rdx
		  __int64 v192; // rcx
		  bool dirtEnabled; // r12
		  int v194; // r15d
		  __int64 v195; // rdx
		  float v196; // xmm6_4
		  float v197; // xmm7_4
		  MinFloatParameter *dirtIntensity; // r15
		  __int64 v199; // rdx
		  __int64 v200; // rcx
		  double v201; // xmm0_8
		  unsigned __int64 v202; // r9
		  signed __int64 v203; // rtt
		  BloomBlendModeParameter *blendMode; // rdx
		  int v205; // xmm1_4
		  __int64 v206; // rdx
		  __int64 v207; // rcx
		  HGShaderKeyWords__StaticFields *v208; // rdx
		  String *s_BloomDirt; // rdx
		  HGSettingParameters *v210; // rbx
		  HGCamera *v211; // r13
		  UberPostPassUtils_UberPostPassData *v212; // rbx
		  TextureHandle *v213; // rdi
		  __int64 v214; // rdx
		  __int64 v215; // rcx
		  TextureHandle v216; // xmm0
		  UberPostPassUtils_PPBloomData *v217; // rbx
		  __int64 v218; // rdx
		  __int64 v219; // rcx
		  TextureHandle v220; // xmm0
		  UberPostPassUtils_UberPostPassData *v221; // rbx
		  __int64 v222; // rdx
		  __int64 v223; // rcx
		  TextureHandle v224; // xmm0
		  UberPostPassUtils_UberPostPassData *v225; // rbx
		  __int64 v226; // rdx
		  __int64 v227; // rcx
		  TextureHandle v228; // xmm0
		  TextureHandle target; // xmm6
		  __int64 v230; // rdx
		  __int64 v231; // rcx
		  CullingResults cullingResults; // xmm6
		  Camera *v233; // rsi
		  HGRenderPipeline *hgrp; // rax
		  ShaderTagId__Array *uiPassNames; // r14
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm8_4
		  uint32_t screenCullingLayerMask; // r15d
		  RendererListDesc *v239; // rax
		  UberPostPassUtils_UberPostPassData *v240; // rbx
		  RendererListHandle v241; // rax
		  RendererListHandle v242; // rdx
		  RendererListHandle v243; // rcx
		  uint32_t cullingLayerMask; // r15d
		  UberPostPassUtils_UberPostPassData *v245; // rbx
		  uint32_t cullingViewHandle; // r14d
		  __int64 v247; // rdx
		  __int64 v248; // rcx
		  HGRenderGraphContext *HGContext; // rsi
		  uint32_t RendererList; // eax
		  __int64 v251; // rdx
		  __int64 v252; // rcx
		  UberPostPassUtils_UberPostPassData *v253; // rbx
		  Camera *v254; // rcx
		  __int64 v255; // rdx
		  int32_t cullingMask; // esi
		  Object_1 *v257; // rcx
		  int32_t InstanceID; // r12d
		  __int64 v259; // rdx
		  __int64 v260; // rcx
		  HGRenderGraphContext *v261; // r14
		  uint32_t v262; // eax
		  __int64 v263; // rdx
		  __int64 v264; // rcx
		  TextureHandle *p_sceneDepthBuffer; // rbx
		  __int64 v266; // rdx
		  __int64 v267; // rcx
		  __int64 v268; // rdx
		  __int64 v269; // rcx
		  HGShaderKeyWords__StaticFields *v270; // rcx
		  ILFixDynamicMethodWrapper_2 *v271; // rax
		  __int64 v272; // rdx
		  __int64 v273; // rcx
		  Object *v274; // r9
		  TextureHandle *result; // rax
		  __int64 v276; // rdx
		  __int64 v277; // rcx
		  ILFixDynamicMethodWrapper_2 *v278; // rbx
		  HGRenderKeyword__Enum P3; // [rsp+20h] [rbp-508h]
		  MethodInfo *methoda; // [rsp+30h] [rbp-4F8h]
		  UberPostPassUtils_UberPostPassData *data; // [rsp+70h] [rbp-4B8h] BYREF
		  Vector4 sceneDepth; // [rsp+80h] [rbp-4A8h] BYREF
		  RendererListHandle inputa[2]; // [rsp+90h] [rbp-498h] BYREF
		  char v284; // [rsp+A0h] [rbp-488h]
		  __int128 v285; // [rsp+A8h] [rbp-480h] BYREF
		  HGRenderGraphBuilder v286; // [rsp+B8h] [rbp-470h] BYREF
		  HGRenderGraphBuilder v287; // [rsp+D8h] [rbp-450h] BYREF
		  TextureHandle v288; // [rsp+100h] [rbp-428h] BYREF
		  Il2CppExceptionWrapper *v289; // [rsp+110h] [rbp-418h] BYREF
		  HGColorGradingConfig v290; // [rsp+120h] [rbp-408h] BYREF
		  RendererListDesc desc; // [rsp+290h] [rbp-298h] BYREF
		  RendererListDesc v292; // [rsp+370h] [rbp-1B8h] BYREF
		
		  v12 = this;
		  data = 0LL;
		  sub_18033B9D0(&v290, 0LL, 368LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2948, 0LL) )
		  {
		    v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xA0u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v16, v15);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v286,
		      renderGraph,
		      (String *)"Uber Post",
		      (Object **)&data,
		      v14,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
		    v287 = v286;
		    v288.handle = 0LL;
		    v288.fallBackResource = (ResourceHandle)&v287;
		    try
		    {
		      v12->fields.m_renderGraphBuilder = v287;
		      v17 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v18 = (((unsigned __int64)&v12->fields.m_renderGraphBuilder >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v18 + 36190]);
		        do
		          v19 = qword_18F0BCBA0[v18 + 36190];
		        while ( v19 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v18 + 36190],
		                         v19 | (1LL << (((unsigned __int64)&v12->fields.m_renderGraphBuilder >> 12) & 0x3F)),
		                         v19) );
		        v17 = dword_18F35FD08;
		      }
		      v20 = data;
		      m_UberPostMaterial = v12->fields.m_UberPostMaterial;
		      if ( !data )
		        sub_1800D8250(m_UberPostMaterial, 0LL);
		      data->fields.uberPostMaterial = m_UberPostMaterial;
		      if ( v17 )
		      {
		        v22 = ((unsigned __int64)&v20->fields >> 12) & 0x1FFFFF;
		        v23 = v22 >> 6;
		        v20 = (UberPostPassUtils_UberPostPassData *)(v22 & 0x3F);
		        _m_prefetchw(&qword_18F0BCBA0[v23 + 36190]);
		        do
		        {
		          m_UberPostMaterial = (Material *)(qword_18F0BCBA0[v23 + 36190] | (1LL << (char)v20));
		          v24 = qword_18F0BCBA0[v23 + 36190];
		        }
		        while ( v24 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v23 + 36190],
		                         (signed __int64)m_UberPostMaterial,
		                         v24) );
		      }
		      if ( !data )
		        sub_1800D8250(m_UberPostMaterial, v20);
		      uberPostMaterial = data->fields.uberPostMaterial;
		      if ( !uberPostMaterial )
		        sub_1800D8250(0LL, v20);
		      UnityEngine::Material::SetEnabledKeywords(uberPostMaterial, 0LL, 0LL);
		      v28 = camera;
		      if ( !camera )
		        sub_1800D8250(v27, v26);
		      if ( (HG::Rendering::Runtime::HGCamera::get_enableTAAU(camera, 0LL)
		         || HG::Rendering::Runtime::HGCamera::get_enableMetalFXTemporalScaler(camera, 0LL))
		        && !HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler(camera, 0LL) )
		      {
		        if ( !data )
		          sub_1800D8250(v30, v29);
		        v31 = data->fields.uberPostMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !v31 )
		          sub_1800D8250(v32, static_fields);
		        UnityEngine::Material::EnableKeyword(v31, static_fields->s_PerformSharpen, 0LL);
		        v28 = camera;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      PostExposureLinear = HG::Rendering::Runtime::UberPostPassUtils::GetPostExposureLinear(v28, 0LL);
		      m_LutSize = (unsigned int)v12->fields.m_LutSize;
		      v37 = 1.0 / (float)v12->fields.m_LutSize;
		      sceneDepth.x = 1.0 / (float)(v12->fields.m_LutSize * v12->fields.m_LutSize);
		      sceneDepth.y = v37;
		      sceneDepth.z = (float)(int)m_LutSize - 1.0;
		      sceneDepth.w = PostExposureLinear;
		      if ( !data )
		        sub_1800D8250(m_LutSize, v34);
		      data->fields.logLutSettings = sceneDepth;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v28, 0LL);
		      if ( !InterpolatedPhase )
		        sub_1800D8250(v40, v39);
		      p_colorGradingConfig = &InterpolatedPhase->fields.colorGradingConfig;
		      v42 = &v290;
		      v43 = 2LL;
		      do
		      {
		        *(_OWORD *)&v42->tonemappingMode = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		        *(_OWORD *)&v42->colorLookupContribution = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		        *(_OWORD *)&v42->colorAdjustmentsEnabled = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		        *(_OWORD *)&v42->colorAdjustmentsColorFilter.g = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		        *(_OWORD *)&v42->colorAdjustmentsSaturation = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		        *(_OWORD *)&v42->channelMixerRedOutBlueIn = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		        *(_OWORD *)&v42->channelMixerBlueOutRedIn = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		        v42 = (HGColorGradingConfig *)((char *)v42 + 128);
		        *(Vector4 *)&v42[-1].colorCurves.masterOverriding = p_colorGradingConfig->shadowsMidtonesHighlights.shadows;
		        p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		        --v43;
		      }
		      while ( v43 );
		      *(_OWORD *)&v42->tonemappingMode = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		      *(_OWORD *)&v42->colorLookupContribution = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		      *(_OWORD *)&v42->colorAdjustmentsEnabled = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		      *(_OWORD *)&v42->colorAdjustmentsColorFilter.g = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		      *(_OWORD *)&v42->colorAdjustmentsSaturation = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		      v44 = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		      *(_OWORD *)&v42->channelMixerRedOutBlueIn = v44;
		      *(_OWORD *)&v42->channelMixerBlueOutRedIn = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		      if ( HG::Rendering::Runtime::HGColorGradingConfig::IsColorLookupEnabled(&v290, 0LL) )
		      {
		        if ( !data )
		          sub_1800D8250(v46, v45);
		        v53 = data->fields.uberPostMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        v55 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !v53 )
		          sub_1800D8250(v54, v55);
		        UnityEngine::Material::EnableKeyword(v53, v55->s_UserLUT, 0LL);
		        v57 = data;
		        if ( !data )
		          sub_1800D8250(v56, 0LL);
		        data->fields.userLut = (Texture *)v290.colorLookupTexture;
		        if ( dword_18F35FD08 )
		        {
		          v58 = ((unsigned __int64)&v57->fields.userLut >> 12) & 0x1FFFFF;
		          v59 = v58 >> 6;
		          v60 = v58 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v59 + 36190]);
		          do
		          {
		            v56 = qword_18F0BCBA0[v59 + 36190] | (1LL << v60);
		            v61 = qword_18F0BCBA0[v59 + 36190];
		          }
		          while ( v61 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v59 + 36190], v56, v61) );
		        }
		        v62 = data;
		        if ( !v290.colorLookupTexture )
		          sub_1800D8250(v56, 0LL);
		        v64 = sub_180002F70(5LL, v290.colorLookupTexture);
		        if ( !v290.colorLookupTexture )
		          sub_1800D8250(v63, 0LL);
		        v66 = sub_180002F70(7LL, v290.colorLookupTexture);
		        if ( !v290.colorLookupTexture )
		          sub_1800D8250(v65, 0LL);
		        v67 = sub_180002F70(7LL, v290.colorLookupTexture);
		        sceneDepth.x = 1.0 / (float)v64;
		        sceneDepth.y = 1.0 / (float)v66;
		        *(float *)&v44 = (float)v67 - 1.0;
		        sceneDepth.z = *(float *)&v44;
		        sceneDepth.w = v290.colorLookupContribution;
		        if ( !v62 )
		          sub_1800D8250(v50, v49);
		        v62->fields.userLogLutSettings = sceneDepth;
		      }
		      else
		      {
		        v47 = data;
		        blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
		        if ( !v47 )
		          sub_1800D8250(v50, v49);
		        v47->fields.userLut = (Texture *)blackTexture;
		        if ( dword_18F35FD08 )
		        {
		          v51 = (((unsigned __int64)&v47->fields.userLut >> 12) & 0x1FFFFF) >> 6;
		          v49 = ((unsigned __int64)&v47->fields.userLut >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v51 + 36190]);
		          do
		          {
		            v50 = qword_18F0BCBA0[v51 + 36190] | (1LL << v49);
		            v52 = qword_18F0BCBA0[v51 + 36190];
		          }
		          while ( v52 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v51 + 36190], v50, v52) );
		        }
		        if ( !data )
		          sub_1800D8250(v50, v49);
		        data->fields.userLogLutSettings = 0LL;
		      }
		      if ( !data )
		        sub_1800D8250(v50, v49);
		      vignetteData = data->fields.vignetteData;
		      m_Vignette = (Object *)v12->fields.m_Vignette;
		      m_HGVignette = (Object *)v12->fields.m_HGVignette;
		      P4 = (Object *)v12->fields.m_UberPostMaterial;
		      inputa[0] = (RendererListHandle)P4;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      sceneDepth = 0LL;
		      if ( IFix::WrappersManagerImpl::IsPatched(2933, 0LL) )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(2933, 0LL);
		        if ( !Patch )
		          sub_1800D8250(v183, v182);
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
		          (ILFixDynamicMethodWrapper_19 *)Patch,
		          (Object *)settingParameters,
		          (Object *)vignetteData,
		          m_Vignette,
		          m_HGVignette,
		          P4,
		          0LL);
		      }
		      else
		      {
		        if ( !m_Vignette )
		          sub_1800D8250(v73, v72);
		        IsActive = HG::Rendering::Runtime::Vignette::IsActive((Vignette *)m_Vignette, 0LL);
		        if ( !m_HGVignette )
		          sub_1800D8250(v75, v74);
		        v79 = HG::Rendering::Runtime::HGVignette::IsActive((HGVignette *)m_HGVignette, 0LL);
		        if ( !settingParameters )
		          sub_1800D8250(v78, v77);
		        if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		               settingParameters->fields._vignetteEnabled_k__BackingField,
		               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		          && (IsActive || v79) )
		        {
		          klass = m_Vignette[3].klass;
		          if ( !klass )
		            sub_1800D8250(v81, 0LL);
		          v85 = sub_180002F70(10LL, klass);
		          monitor = m_Vignette[5].monitor;
		          if ( !monitor )
		            sub_1800D8250(v84, v83);
		          sub_1800049A0(*(_QWORD *)monitor);
		          v89 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)monitor + 480LL))(
		                  monitor,
		                  *(_QWORD *)(*(_QWORD *)monitor + 488LL));
		          v90 = *(float *)&v89;
		          v91 = m_Vignette[4].klass;
		          if ( !v91 )
		            sub_1800D8250(v88, v87);
		          sub_1800049A0(v91->_0.image);
		          v92 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v91->_0.image[6].nameToClassHashTable)(
		                  v91,
		                  v91->_0.image[6].codeGenModule);
		          DWORD1(v285) = HIDWORD(v92);
		          v95 = v92;
		          LODWORD(v285) = HIDWORD(v92);
		          v96 = m_Vignette[4].monitor;
		          if ( !v96 )
		            sub_1800D8250(v94, v93);
		          sub_1800049A0(*(_QWORD *)v96);
		          v99 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v96 + 480LL))(
		                  v96,
		                  *(_QWORD *)(*(_QWORD *)v96 + 488LL));
		          v100 = *(float *)&v99;
		          v101 = m_Vignette[5].klass;
		          if ( !v101 )
		            sub_1800D8250(v98, v97);
		          sub_1800049A0(v101->_0.image);
		          v104 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v101->_0.image[6].nameToClassHashTable)(
		                   v101,
		                   v101->_0.image[6].codeGenModule);
		          v105 = *(float *)&v104;
		          v106 = m_Vignette[6].klass;
		          if ( !v106 )
		            sub_1800D8250(v103, v102);
		          sub_1800049A0(v106->_0.image);
		          v284 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v106->_0.image[6].nameToClassHashTable)(
		                   v106,
		                   v106->_0.image[6].codeGenModule);
		          v109 = m_Vignette[3].monitor;
		          if ( !v109 )
		            sub_1800D8250(v108, v107);
		          sub_1800049A0(*(_QWORD *)v109);
		          v112 = (__m128)_mm_loadu_si128((const __m128i *)(*(__int64 (__fastcall **)(HGRenderGraphBuilder *, MonitorData *, _QWORD))(*(_QWORD *)v109 + 480LL))(
		                                                            &v286,
		                                                            v109,
		                                                            *(_QWORD *)(*(_QWORD *)v109 + 488LL)));
		          LODWORD(sceneDepth.x) = v112.m128_i32[0];
		          LODWORD(v113) = _mm_shuffle_ps(v112, v112, 85).m128_u32[0];
		          sceneDepth.y = v113;
		          LODWORD(v114) = _mm_shuffle_ps(v112, v112, 170).m128_u32[0];
		          sceneDepth.z = v114;
		          LODWORD(sceneDepth.w) = _mm_shuffle_ps(v112, v112, 255).m128_u32[0];
		          v115 = m_Vignette[7].klass;
		          if ( !v115 )
		            sub_1800D8250(v111, v110);
		          sub_1800049A0(v115->_0.image);
		          v118 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v115->_0.image[6].nameToClassHashTable)(
		                   v115,
		                   v115->_0.image[6].codeGenModule);
		          v119 = m_Vignette[7].monitor;
		          if ( !v119 )
		            sub_1800D8250(v117, v116);
		          sub_1800049A0(*(_QWORD *)v119);
		          v122 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v119 + 480LL))(
		                   v119,
		                   *(_QWORD *)(*(_QWORD *)v119 + 488LL));
		          v123 = *(float *)&v122;
		          if ( v79 )
		          {
		            v124 = m_HGVignette[4].monitor;
		            if ( !v124 )
		              sub_1800D8250(v121, v120);
		            sub_1800049A0(*(_QWORD *)v124);
		            v127 = (*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v124 + 480LL))(
		                     v124,
		                     *(_QWORD *)(*(_QWORD *)v124 + 488LL));
		            v90 = 1.0;
		            v128 = m_HGVignette[5].klass;
		            if ( !v128 )
		              sub_1800D8250(v126, v125);
		            sub_1800049A0(v128->_0.image);
		            v131 = ((__int64 (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v128->_0.image[6].nameToClassHashTable)(
		                     v128,
		                     v128->_0.image[6].codeGenModule);
		            v95 = 1056964608;
		            LODWORD(v285) = 1056964608;
		            v132 = m_HGVignette[3].klass;
		            if ( !v132 )
		              sub_1800D8250(v130, v129);
		            sub_1800049A0(v132->_0.image);
		            v135 = (__m128)_mm_loadu_si128((const __m128i *)((__int64 (__fastcall *)(HGRenderGraphBuilder *, Object__Class *, const Il2CppCodeGenModule *))v132->_0.image[6].nameToClassHashTable)(
		                                                              &v286,
		                                                              v132,
		                                                              v132->_0.image[6].codeGenModule));
		            v136 = 0;
		            if ( v100 > 0.0 )
		            {
		              sceneDepth.x = UnityEngine::Mathf::Min(v112.m128_f32[0], v135.m128_f32[0], 0LL);
		              sceneDepth.y = UnityEngine::Mathf::Min(v113, _mm_shuffle_ps(v135, v135, 85).m128_f32[0], 0LL);
		              sceneDepth.z = UnityEngine::Mathf::Min(v114, _mm_shuffle_ps(v135, v135, 170).m128_f32[0], 0LL);
		            }
		            else
		            {
		              LODWORD(sceneDepth.x) = v135.m128_i32[0];
		              LODWORD(sceneDepth.y) = _mm_shuffle_ps(v135, v135, 85).m128_u32[0];
		              LODWORD(sceneDepth.z) = _mm_shuffle_ps(v135, v135, 170).m128_u32[0];
		              LODWORD(sceneDepth.w) = _mm_shuffle_ps(v135, v135, 255).m128_u32[0];
		            }
		            v137 = m_HGVignette[3].monitor;
		            if ( v131 )
		            {
		              if ( !v137 )
		                sub_1800D8250(v134, v133);
		              sub_1800049A0(*(_QWORD *)v137);
		              v140 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v137 + 480LL))(
		                       v137,
		                       *(_QWORD *)(*(_QWORD *)v137 + 488LL));
		              v100 = *(float *)&v140;
		              v141 = m_HGVignette[4].klass;
		              if ( !v141 )
		                sub_1800D8250(v139, v138);
		              sub_1800049A0(v141->_0.image);
		              v142 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v141->_0.image[6].nameToClassHashTable)(
		                       v141,
		                       v141->_0.image[6].codeGenModule);
		            }
		            else
		            {
		              if ( !v137 )
		                sub_1800D8250(v134, v133);
		              sub_1800049A0(*(_QWORD *)v137);
		              v143 = (*(double (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v137 + 480LL))(
		                       v137,
		                       *(_QWORD *)(*(_QWORD *)v137 + 488LL));
		              v100 = UnityEngine::Mathf::Max(v100, *(float *)&v143, 0LL);
		              v146 = m_HGVignette[4].klass;
		              if ( !v146 )
		                sub_1800D8250(v145, v144);
		              sub_1800049A0(v146->_0.image);
		              v142 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v146->_0.image[6].nameToClassHashTable)(
		                       v146,
		                       v146->_0.image[6].codeGenModule);
		              *(float *)&v142 = UnityEngine::Mathf::Max(v105, *(float *)&v142, 0LL);
		            }
		            v105 = *(float *)&v142;
		          }
		          else
		          {
		            v131 = 0;
		            if ( v85 )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		              v148 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		              if ( !*(_QWORD *)inputa )
		                sub_1800D8250(v147, v148);
		              UnityEngine::Material::EnableKeyword(*(Material **)inputa, v148->s_VignetteMask, 0LL);
		              LODWORD(sceneDepth.x) = v112.m128_i32[0];
		              sceneDepth.y = v113;
		              sceneDepth.z = v114;
		              Beyond::JobMathf::Clamp01(v149, *(float *)&v44);
		              sceneDepth.w = v123;
		              si128 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		              if ( !vignetteData )
		                sub_1800D8250(v151, v150);
		              vignetteData->fields.vignetteParams1 = (Vector4)si128;
		              vignetteData->fields.vignetteColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                               (Color *)&v286,
		                                                                                               &sceneDepth,
		                                                                                               0LL));
		              vignetteData->fields.vignetteMask = (Texture *)v118;
		              if ( dword_18F35FD08 )
		              {
		                v153 = (((unsigned __int64)&vignetteData->fields.vignetteMask >> 12) & 0x1FFFFF) >> 6;
		                v80 = ((unsigned __int64)&vignetteData->fields.vignetteMask >> 12) & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v153 + 36190]);
		                do
		                {
		                  v81 = qword_18F0BCBA0[v153 + 36190] | (1LL << v80);
		                  v154 = qword_18F0BCBA0[v153 + 36190];
		                }
		                while ( v154 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v153 + 36190], v81, v154) );
		              }
		              v136 = 0;
		              goto LABEL_82;
		            }
		            v136 = 0;
		            v127 = v284;
		          }
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          v174 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		          if ( !*(_QWORD *)inputa )
		            sub_1800D8250(v174, v173);
		          UnityEngine::Material::EnableKeyword(*(Material **)inputa, v174->s_Vignette, 0LL);
		          if ( v131 )
		            v177 = 1065353216;
		          else
		            v177 = 0;
		          *(_DWORD *)&inputa[0].m_IsValid = v95;
		          inputa[0]._handle_k__BackingField = v285;
		          *(_DWORD *)&inputa[1].m_IsValid = 0;
		          inputa[1]._handle_k__BackingField = v177;
		          if ( !vignetteData )
		            sub_1800D8250(v176, v175);
		          vignetteData->fields.vignetteParams1 = *(Vector4 *)&inputa[0].m_IsValid;
		          if ( v127 )
		            v178 = 1065353216;
		          else
		            v178 = 0;
		          *(float *)&inputa[0].m_IsValid = v100 * 3.0;
		          *(float *)&inputa[0]._handle_k__BackingField = v105 * 5.0;
		          *(float *)&inputa[1].m_IsValid = v90 + (float)((float)(1.0 - v90) * 6.0);
		          inputa[1]._handle_k__BackingField = v178;
		          vignetteData->fields.vignetteParams2 = *(Vector4 *)&inputa[0].m_IsValid;
		          vignetteData->fields.vignetteColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                           (Color *)&v286,
		                                                                                           &sceneDepth,
		                                                                                           0LL));
		          vignetteData->fields.vignetteMask = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		          if ( dword_18F35FD08 )
		          {
		            v179 = (((unsigned __int64)&vignetteData->fields.vignetteMask >> 12) & 0x1FFFFF) >> 6;
		            v80 = ((unsigned __int64)&vignetteData->fields.vignetteMask >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v179 + 36190]);
		            do
		            {
		              v81 = qword_18F0BCBA0[v179 + 36190] | (1LL << v80);
		              v180 = qword_18F0BCBA0[v179 + 36190];
		            }
		            while ( v180 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v179 + 36190], v81, v180) );
		          }
		LABEL_82:
		          v12 = this;
		LABEL_83:
		          if ( !data )
		            sub_1800D8250(v81, v80);
		          bloomData = data->fields.bloomData;
		          m_Bloom = v12->fields.m_Bloom;
		          v157 = v12->fields.m_UberPostMaterial;
		          v158 = _mm_loadu_si128((const __m128i *)&this->fields.m_BloomBicubicParams);
		          v285 = 0LL;
		          if ( IFix::WrappersManagerImpl::IsPatched(2895, 0LL) )
		          {
		            v271 = IFix::WrappersManagerImpl::GetPatch(2895, 0LL);
		            if ( !v271 )
		              sub_1800D8250(v273, v272);
		            sceneDepth = (Vector4)v158;
		            methoda = (MethodInfo *)v157;
		            v211 = camera;
		            v274 = (Object *)m_Bloom;
		            v210 = settingParameters;
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1058(
		              v271,
		              (Object *)settingParameters,
		              (Object *)bloomData,
		              v274,
		              &sceneDepth,
		              (Object *)camera,
		              (Object *)methoda,
		              0LL);
		          }
		          else
		          {
		            if ( !m_Bloom )
		              sub_1800D8250(v160, v159);
		            if ( HG::Rendering::Runtime::Bloom::IsActive(m_Bloom, 0LL) )
		            {
		              if ( !settingParameters )
		                sub_1800D8250(v162, v161);
		              if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                     settingParameters->fields._bloomEnabled_k__BackingField,
		                     MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		              {
		                HG::Rendering::Runtime::Bloom::get_intensity(m_Bloom, 0LL);
		                v165 = sub_1803369A0();
		                v166 = *(float *)&v165 - 1.0;
		                tint = m_Bloom->fields.tint;
		                if ( !tint )
		                  sub_1800D8250(v164, v163);
		                sub_1800049A0(tint->klass);
		                v285 = *(_OWORD *)((__int64 (__fastcall *)(HGRenderGraphBuilder *, ColorParameter *, Il2CppMethodPointer))tint->klass->vtable.get_value.method)(
		                                    &v286,
		                                    tint,
		                                    tint->klass->vtable.set_value.methodPtr);
		                v168 = (__m128)_mm_loadu_si128((const __m128i *)sub_183C6CBA0(&v286, &v285));
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		                v169 = (float)(_mm_shuffle_ps(v168, v168, 170).m128_f32[0] * 0.072175004)
		                     + (float)((float)(_mm_shuffle_ps(v168, v168, 85).m128_f32[0] * 0.7151522)
		                             + (float)(v168.m128_f32[0] * 0.2126729));
		                if ( v169 <= 0.0 )
		                {
		                  one = UnityEngine::Vector4::get_one((Vector4 *)&v286, 0LL);
		                }
		                else
		                {
		                  sceneDepth = (Vector4)v168;
		                  one = UnityEngine::Vector4::op_Multiply((Vector4 *)&v286, &sceneDepth, 1.0 / v169, 0LL);
		                }
		                v184 = _mm_loadu_si128((const __m128i *)one);
		                dirtTexture = m_Bloom->fields.dirtTexture;
		                if ( !dirtTexture )
		                  sub_1800D8250(v172, v171);
		                sub_1800049A0(dirtTexture->klass);
		                v186 = (Object_1 *)((__int64 (__fastcall *)(Texture2DParameter *, Il2CppMethodPointer))dirtTexture->klass->vtable.get_value.method)(
		                                     dirtTexture,
		                                     dirtTexture->klass->vtable.set_value.methodPtr);
		                sub_1800036A0(TypeInfo::UnityEngine::Object);
		                if ( UnityEngine::Object::op_Equality(v186, 0LL, 0LL) )
		                {
		                  v189 = UnityEngine::Texture2D::get_blackTexture(0LL);
		                }
		                else
		                {
		                  v190 = m_Bloom->fields.dirtTexture;
		                  if ( !v190 )
		                    sub_1800D8250(v188, v187);
		                  sub_1800049A0(v190->klass);
		                  v189 = (Texture2D *)((__int64 (__fastcall *)(Texture2DParameter *, Il2CppMethodPointer))v190->klass->vtable.get_value.method)(
		                                        v190,
		                                        v190->klass->vtable.set_value.methodPtr);
		                }
		                dirtEnabled = HG::Rendering::Runtime::Bloom::get_dirtEnabled(m_Bloom, 0LL);
		                if ( !v189 )
		                  sub_1800D8250(v192, v191);
		                v194 = sub_180002F70(5LL, v189);
		                v196 = (float)v194 / (float)(int)sub_180002F70(7LL, v189);
		                v197 = (float)camera->fields._taauRTSize_k__BackingField.m_X
		                     / (float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		                sceneDepth = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
		                dirtIntensity = m_Bloom->fields.dirtIntensity;
		                if ( !dirtIntensity )
		                  sub_1800D8250(camera, v195);
		                sub_1800049A0(dirtIntensity->klass);
		                v201 = ((double (__fastcall *)(MinFloatParameter *, Il2CppMethodPointer))dirtIntensity->klass->vtable.get_value.method)(
		                         dirtIntensity,
		                         dirtIntensity->klass->vtable.set_value.methodPtr);
		                if ( v196 > v197 )
		                {
		                  sceneDepth.x = v197 / v196;
		                  sceneDepth.z = (float)(1.0 - (float)(v197 / v196)) * 0.5;
		                }
		                else if ( v197 > v196 )
		                {
		                  sceneDepth.y = v196 / v197;
		                  sceneDepth.w = (float)(1.0 - (float)(v196 / v197)) * 0.5;
		                }
		                if ( !bloomData )
		                  sub_1800D8250(v200, v199);
		                bloomData->fields.bloomDirtTexture = (Texture *)v189;
		                if ( dword_18F35FD08 )
		                {
		                  v202 = (((unsigned __int64)&bloomData->fields.bloomDirtTexture >> 12) & 0x1FFFFF) >> 6;
		                  _m_prefetchw(&qword_18F0BCBA0[v202 + 36190]);
		                  do
		                    v203 = qword_18F0BCBA0[v202 + 36190];
		                  while ( v203 != _InterlockedCompareExchange64(
		                                    &qword_18F0BCBA0[v202 + 36190],
		                                    v203 | (1LL << (((unsigned __int64)&bloomData->fields.bloomDirtTexture >> 12) & 0x3F)),
		                                    v203) );
		                }
		                blendMode = m_Bloom->fields.blendMode;
		                if ( !blendMode )
		                  sub_1800D8250(v200, 0LL);
		                if ( (unsigned int)sub_180002F70(10LL, blendMode) )
		                  v205 = 1065353216;
		                else
		                  v205 = 0;
		                if ( dirtEnabled )
		                  v136 = 1065353216;
		                *(float *)&inputa[0].m_IsValid = v166;
		                *(float *)&inputa[0]._handle_k__BackingField = v166 * *(float *)&v201;
		                *(_DWORD *)&inputa[1].m_IsValid = v205;
		                inputa[1]._handle_k__BackingField = v136;
		                bloomData->fields.bloomParams = *(Vector4 *)&inputa[0].m_IsValid;
		                *(__m128i *)&inputa[0].m_IsValid = v184;
		                bloomData->fields.bloomTint = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                          (Color *)&v286,
		                                                                                          (Vector4 *)inputa,
		                                                                                          0LL));
		                bloomData->fields.bloomDirtTileOffset = sceneDepth;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                bloomData->fields.bloomThreshold = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
		                                                                                               (Vector4 *)&v286,
		                                                                                               m_Bloom,
		                                                                                               0LL));
		                bloomData->fields.bloomBicubicParams = (Vector4)v158;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                if ( dirtEnabled )
		                {
		                  v270 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                  if ( !v157 )
		                    sub_1800D8250(v270, v206);
		                  s_BloomDirt = v270->s_BloomDirt;
		                }
		                else
		                {
		                  v208 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                  if ( !v157 )
		                    sub_1800D8250(v207, v208);
		                  s_BloomDirt = v208->s_Bloom;
		                }
		                UnityEngine::Material::EnableKeyword(v157, s_BloomDirt, 0LL);
		              }
		            }
		            v210 = settingParameters;
		            v211 = camera;
		          }
		          HG::Rendering::Runtime::UberPostPassUtils::PrepareDirtyLensParameters(
		            v210,
		            data,
		            this->fields.m_HGDirtyLens,
		            0LL);
		          HG::Rendering::Runtime::UberPostPassUtils::PrepareRadialBlurAndChromaticAberrationParameters(
		            v210,
		            data,
		            v211,
		            this->fields.m_RadialBlur,
		            this->fields.m_chromaticAbberation,
		            0LL);
		          HG::Rendering::Runtime::UberPostPassUtils::PrepareBWFlashParameters(data, v211, this->fields.m_BWFlash, 0LL);
		          v212 = data;
		          v213 = source;
		          v216 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                    (TextureHandle *)&v286,
		                    &v287,
		                    source,
		                    0LL);
		          if ( !v212 )
		            sub_1800D8250(v215, v214);
		          v212->fields.source = v216;
		          if ( !data )
		            sub_1800D8250(v215, v214);
		          v217 = data->fields.bloomData;
		          v220 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                    (TextureHandle *)&v286,
		                    &v287,
		                    bloomTexture,
		                    0LL);
		          if ( !v217 )
		            sub_1800D8250(v219, v218);
		          v217->fields.bloomTexture = v220;
		          v221 = data;
		          v224 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                    (TextureHandle *)&v286,
		                    &v287,
		                    logLut,
		                    0LL);
		          if ( !v221 )
		            sub_1800D8250(v223, v222);
		          v221->fields.logLut = v224;
		          v225 = data;
		          v228 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                    (TextureHandle *)&v286,
		                    &v287,
		                    &input->target,
		                    0LL);
		          if ( !v225 )
		            sub_1800D8250(v227, v226);
		          v225->fields.destination = v228;
		          target = input->target;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          sceneDepth = (Vector4)target;
		          sceneDepth = (Vector4)*HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
		                                   (TextureHandle *)&v286,
		                                   renderGraph,
		                                   v211,
		                                   (TextureHandle *)&sceneDepth,
		                                   0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v286,
		            &v287,
		            &input->target,
		            0,
		            0,
		            0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            (TextureHandle *)&v286,
		            &v287,
		            (TextureHandle *)&sceneDepth,
		            DepthAccess__Enum_ReadWrite,
		            RenderBufferLoadAction__Enum_Clear,
		            RenderBufferStoreAction__Enum_DontCare,
		            1.0,
		            0,
		            0,
		            0LL);
		          sceneDepth = (Vector4)input->sceneDepth;
		          HG::Rendering::Runtime::PostProcessPassConstructor::PrepareWorldUIData(
		            this,
		            data,
		            v211,
		            (TextureHandle *)&sceneDepth,
		            0LL);
		          cullingResults = input->cullingResults;
		          v233 = v211->fields.camera;
		          hgrp = input->hgrp;
		          if ( !hgrp )
		            sub_1800D8250(v231, v230);
		          uiPassNames = hgrp->fields.uiPassNames;
		          screenCullingRatio = input->screenCullingRatio;
		          screenCullingRatioDistance = input->screenCullingRatioDistance;
		          screenCullingLayerMask = input->screenCullingLayerMask;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		          *(_QWORD *)&v285 = 0x138800000000LL;
		          inputa[0] = (RendererListHandle)1LL;
		          *(_DWORD *)&inputa[1].m_IsValid = 0;
		          sub_18033B9D0(&desc, 0LL, 112LL);
		          *(_DWORD *)&inputa[1].m_IsValid = 5000;
		          sceneDepth = (Vector4)cullingResults;
		          v239 = HG::Rendering::Runtime::HGRendererListUtils::CreateWorldUIRendererListDesc(
		                   &v292,
		                   (CullingResults *)&sceneDepth,
		                   v233,
		                   uiPassNames,
		                   screenCullingRatio,
		                   screenCullingRatioDistance,
		                   screenCullingLayerMask,
		                   PerObjectData__Enum_None,
		                   (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)inputa,
		                   (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
		                   0LL,
		                   0,
		                   0LL);
		          *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v239->sortingCriteria;
		          desc.stateBlock = v239->stateBlock;
		          v239 = (RendererListDesc *)((char *)v239 + 128);
		          *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v239->sortingCriteria;
		          *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v239->stateBlock.hasValue;
		          *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v239->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v239->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v239->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v239->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		          inputa[0] = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		          v240 = data;
		          v241 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v287, inputa, 0LL);
		          if ( !v240 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v243, v242);
		          v240->fields.worldUIRenderList = v241;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		          cullingLayerMask = HG::Rendering::Runtime::HGCamera::AddWorldUILayer(0, 0LL);
		          v245 = data;
		          cullingViewHandle = v211->fields.cullingViewHandle;
		          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !HGContext )
		            sub_1800D8250(v248, v247);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          LOWORD(P3) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           cullingViewHandle,
		                           HGRenderFlags__Enum_Transparent,
		                           HGRenderFlags__Enum_Transparent,
		                           HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
		                           P3,
		                           HGContext->fields.renderContext.m_Ptr,
		                           1,
		                           1,
		                           cullingLayerMask,
		                           0,
		                           0,
		                           0LL);
		          if ( !v245 )
		            sub_1800D8250(v252, v251);
		          v245->fields.worldUIECSRenderList = RendererList;
		          v253 = data;
		          v254 = v211->fields.camera;
		          if ( !v254 )
		            sub_1800D8250(0LL, v251);
		          cullingMask = UnityEngine::Camera::get_cullingMask(v254, 0LL);
		          v257 = (Object_1 *)v211->fields.camera;
		          if ( !v257 )
		            sub_1800D8250(0LL, v255);
		          InstanceID = UnityEngine::Object::GetInstanceID(v257, 0LL);
		          v261 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !v261 )
		            sub_1800D8250(v260, v259);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v262 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                   cullingLayerMask & cullingMask,
		                   0x200u,
		                   0x200u,
		                   0x2002060u,
		                   0x8000,
		                   0x7FFF,
		                   InstanceID,
		                   v261->fields.renderContext.m_Ptr,
		                   1,
		                   5000.0,
		                   0LL);
		          if ( !v253 )
		            sub_1800D8250(v264, v263);
		          v253->fields.hgUIRenderList = v262;
		          if ( !data )
		            sub_1800D8250(v264, v263);
		          p_sceneDepthBuffer = &data->fields.sceneDepthBuffer;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(p_sceneDepthBuffer, 0LL) )
		          {
		            if ( !data )
		              sub_1800D8250(v267, v266);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v286,
		              &v287,
		              &data->fields.sceneDepthBuffer,
		              0LL);
		          }
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v287, 0, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v287,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields->s_uberRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData>);
		          if ( !data )
		            sub_1800D8250(v269, v268);
		          *source = data->fields.destination;
		          goto LABEL_237;
		        }
		      }
		      v136 = 0;
		      goto LABEL_83;
		    }
		    catch ( Il2CppExceptionWrapper *v289 )
		    {
		      v288.handle = (ResourceHandle)v289->ex;
		      sub_180268AE0(&v288);
		      v213 = source;
		      goto LABEL_159;
		    }
		LABEL_237:
		    sub_180268AE0(&v288);
		LABEL_159:
		    result = retstr;
		    *retstr = *v213;
		    return result;
		  }
		  v278 = IFix::WrappersManagerImpl::GetPatch(2948, 0LL);
		  if ( !v278 )
		    sub_1800D8260(v277, v276);
		  v288 = *bloomTexture;
		  sceneDepth = (Vector4)*logLut;
		  *(TextureHandle *)&inputa[0].m_IsValid = *source;
		  *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1094(
		               (TextureHandle *)&v286,
		               v278,
		               (Object *)v12,
		               input,
		               (Object *)settingParameters,
		               (Object *)renderGraph,
		               (Object *)camera,
		               (TextureHandle *)inputa,
		               (TextureHandle *)&sceneDepth,
		               &v288,
		               0LL);
		  return retstr;
		}
		
		private void FinalPass(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle finalRT, TextureHandle source) {} // 0x0000000189B8CDA0-0x0000000189B8D15C
		// Void FinalPass(HGRenderGraph, HGCamera, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::PostProcessPassConstructor::FinalPass(
		        PostProcessPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *finalRT,
		        TextureHandle *source,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // eax
		  unsigned __int64 v14; // r9
		  signed __int64 v15; // rtt
		  Object *v16; // r9
		  Object__Class *m_FinalPassMaterial; // rcx
		  unsigned int v18; // r9d
		  unsigned __int64 v19; // r8
		  char v20; // r9
		  signed __int64 v21; // rtt
		  __m128i v22; // xmm0
		  Object *v23; // rax
		  float m_Height; // xmm2_4
		  uint32_t v25; // xmm1_4
		  Object *v26; // rbx
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  TextureHandle v29; // xmm0
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  Object *v33; // [rsp+40h] [rbp-78h] BYREF
		  TextureHandle v34; // [rsp+50h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v35; // [rsp+60h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v36; // [rsp+70h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v37; // [rsp+90h] [rbp-28h] BYREF
		
		  v33 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2953, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2953, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, v30);
		    *(TextureHandle *)&v36.m_RenderPass = *source;
		    v34 = *finalRT;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1095(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      &v34,
		      (TextureHandle *)&v36,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xA2u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v36,
		      renderGraph,
		      (String *)"Final Pass",
		      &v33,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>);
		    v37 = v36;
		    v36.m_RenderPass = 0LL;
		    v36.m_Resources = (HGRenderGraphResourceRegistry *)&v37;
		    try
		    {
		      this->fields.m_renderGraphBuilder = v37;
		      v13 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v14 = (((unsigned __int64)&this->fields.m_renderGraphBuilder >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v14 + 36190]);
		        do
		          v15 = qword_18F0BCBA0[v14 + 36190];
		        while ( v15 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v14 + 36190],
		                         v15 | (1LL << (((unsigned __int64)&this->fields.m_renderGraphBuilder >> 12) & 0x3F)),
		                         v15) );
		        v13 = dword_18F35FD08;
		      }
		      v16 = v33;
		      m_FinalPassMaterial = (Object__Class *)this->fields.m_FinalPassMaterial;
		      if ( !v33 )
		        sub_1800D8250(m_FinalPassMaterial, qword_18F0BCBA0);
		      v33[1].klass = m_FinalPassMaterial;
		      if ( v13 )
		      {
		        v18 = ((unsigned __int64)&v16[1] >> 12) & 0x1FFFFF;
		        v19 = (unsigned __int64)v18 >> 6;
		        v20 = v18 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		        do
		        {
		          m_FinalPassMaterial = (Object__Class *)(qword_18F0BCBA0[v19 + 36190] | (1LL << v20));
		          v21 = qword_18F0BCBA0[v19 + 36190];
		        }
		        while ( v21 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v19 + 36190],
		                         (signed __int64)m_FinalPassMaterial,
		                         v21) );
		      }
		      if ( !hgCamera )
		        sub_1800D8250(m_FinalPassMaterial, qword_18F0BCBA0);
		      v22 = _mm_loadu_si128((const __m128i *)&hgCamera->fields.finalViewport);
		      if ( !v33 )
		        sub_1800D8250(m_FinalPassMaterial, qword_18F0BCBA0);
		      *(__m128i *)((char *)v33 + 24) = v22;
		      v23 = v33;
		      if ( !v33 )
		        sub_1800D8250(m_FinalPassMaterial, qword_18F0BCBA0);
		      HIDWORD(v33[1].monitor) = 0;
		      LODWORD(v23[1].monitor) = 0;
		      m_Height = hgCamera->fields.finalViewport.m_Height;
		      *(float *)&v25 = 1.0 / hgCamera->fields.finalViewport.m_Width;
		      v34.handle.m_Value = LODWORD(hgCamera->fields.finalViewport.m_Width);
		      *(float *)&v34.handle._type_k__BackingField = m_Height;
		      v34.fallBackResource.m_Value = v25;
		      *(float *)&v34.fallBackResource._type_k__BackingField = 1.0 / m_Height;
		      if ( !v33 )
		        sub_1800D8250(m_FinalPassMaterial, qword_18F0BCBA0);
		      *(TextureHandle *)&v33[2].monitor = v34;
		      v26 = v33;
		      v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v34, &v37, source, 0LL);
		      if ( !v26 )
		        sub_1800D8250(v28, v27);
		      *(TextureHandle *)&v26[3].monitor = v29;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v34, &v37, finalRT, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&v34, &v37, finalRT, 0, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v37,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor->static_fields->s_finalRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::PostProcessPassConstructor::FinalPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v35 )
		    {
		      v36.m_RenderPass = (HGRenderGraphPass *)v35->ex;
		    }
		    sub_180268AE0(&v36);
		  }
		}
		
		public HGRenderGraphBuilder? __iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph P0) => default; // 0x0000000189B8D878-0x0000000189B8D8B0
		// Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph)
		Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__iFixBaseProxy_GetRenderGraphBuilder(
		        Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
		        ScreenSpaceOverlayPassConstructor *this,
		        HGRenderGraph *P0,
		        MethodInfo *method)
		{
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *RenderGraphBuilder; // rax
		  __int128 v6; // xmm1
		  __int64 v7; // xmm0_8
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *result; // rax
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v9; // [rsp+20h] [rbp-38h] BYREF
		
		  RenderGraphBuilder = HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
		                         &v9,
		                         (ComposablePass *)this,
		                         P0,
		                         0LL);
		  v6 = *(_OWORD *)&RenderGraphBuilder->value.m_Resources;
		  *(_OWORD *)&retstr->hasValue = *(_OWORD *)&RenderGraphBuilder->hasValue;
		  v7 = *(_QWORD *)&RenderGraphBuilder->value.m_Disposed;
		  result = retstr;
		  *(_OWORD *)&retstr->value.m_Resources = v6;
		  *(_QWORD *)&retstr->value.m_Disposed = v7;
		  return result;
		}
		
	}
}
