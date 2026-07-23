using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HyperScreenSpaceReflectionRenderingPass : IPassConstructor // TypeDefIndex: 38411
	{
		// Fields
		private bool m_shouldRender; // 0x10
		private bool m_shouldDeferredRender; // 0x11
		private bool m_firstFrame; // 0x12
		private bool m_deferredFirstFrame; // 0x13
		private bool m_prevFrameWasReset; // 0x14
		private int m_frameIndex; // 0x18
		private Vector2Int m_previousRenderSize; // 0x1C
		private TextureHandle m_previousFadenessTexture; // 0x24
		private TextureHandle m_currentFadenessTexture; // 0x34
		private TextureHandle m_previousTemporalColorTexture; // 0x44
		private TextureHandle m_currentTemporalColorTexture; // 0x54
		private TextureHandle m_previousDeferredTemporalColorTexture; // 0x64
		private TextureHandle m_currentDeferredTemporalColorTexture; // 0x74
		private TextureHandle m_ssrLightingTexture; // 0x84
		private TextureHandle m_ssrFadenessTexture; // 0x94
		private RTHandle m_defaultTexutre; // 0xA8
		private ComputeShader m_computeShader; // 0xB0
		private Material m_pixelShader; // 0xB8
		private static readonly RenderFunc<PassData> s_RenderFunc; // 0x00
		private long m_impl; // 0xC0
		private MaterialPropertyBlock m_transparentMBP; // 0xC8
		private static readonly RenderFunc<TransparentPassData> s_RenderTransparentFunc; // 0x08
	
		// Properties
		public TextureHandle ssrLightingTexture { get => default; } // 0x0000000189BCD0A4-0x0000000189BCD10C 
		// TextureHandle get_ssrLightingTexture()
		TextureHandle *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrLightingTexture(
		        TextureHandle *__return_ptr retstr,
		        HyperScreenSpaceReflectionRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_ssrLightingTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3318, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3318, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_ssrLightingTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_ssrLightingTexture = this->fields.m_ssrLightingTexture;
		  }
		  result = retstr;
		  *retstr = m_ssrLightingTexture;
		  return result;
		}
		
		public TextureHandle ssrFadenessTexture { get => default; } // 0x0000000189BCD03C-0x0000000189BCD0A4 
		// TextureHandle get_ssrFadenessTexture()
		TextureHandle *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrFadenessTexture(
		        TextureHandle *__return_ptr retstr,
		        HyperScreenSpaceReflectionRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_ssrFadenessTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3319, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3319, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_ssrFadenessTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_ssrFadenessTexture = this->fields.m_ssrFadenessTexture;
		  }
		  result = retstr;
		  *retstr = m_ssrFadenessTexture;
		  return result;
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38405
		{
			// Fields
			internal bool needCopyGBufferAndDepth; // 0x00
			internal int ssrRayMarchingSampleCount; // 0x04
			internal uint forwardReflectionECSList; // 0x08
			internal TextureHandle previousSceneColorTexture; // 0x0C
			internal TextureHandle previousSceneDepthPyramidTexture; // 0x1C
			internal TextureHandle currentSceneColorTexture; // 0x2C
			internal TextureHandle currentSceneDepthTexture; // 0x3C
			internal TextureHandle currentSceneDepthTextureCopy; // 0x4C
			internal TextureHandle currentSceneDepthPyramidTexture; // 0x5C
			internal TextureHandle gbufferNormalRoughenssTexture; // 0x6C
			internal TextureHandle normalRoughnessTexture; // 0x7C
			internal TextureHandle normalRoughnessTextureCopy; // 0x8C
			internal TextureHandle motionVectorTexture; // 0x9C
			internal TextureHandle waterWetnessMaskTexture; // 0xAC
			internal ScriptableRenderContext renderContext; // 0xC0
			internal HGSettingParameters settingParameters; // 0xC8
		}
	
		internal struct PassOutput // TypeDefIndex: 38406
		{
		}
	
		public struct ScreenSpaceReflectionData // TypeDefIndex: 38407
		{
			// Fields
			public Vector4 param0; // 0x00
			public Vector4 param1; // 0x10
			public Vector4 param2; // 0x20
			public Vector4 param3; // 0x30
			public Vector4 param4; // 0x40
			public Vector4 param5; // 0x50
			public Vector4 param6; // 0x60
			public Vector4 param7; // 0x70
			public Vector4 previousColorPyramidRenderSize; // 0x80
			public Vector4 currentColorPyramidRenderSize; // 0x90
		}
	
		private class PassData // TypeDefIndex: 38408
		{
			// Fields
			public bool firstFrame; // 0x10
			public bool upsample; // 0x11
			public bool importanceSample; // 0x12
			public int maxMipCount; // 0x14
			public Vector2Int renderSize; // 0x18
			public Vector2Int ssrRenderSize; // 0x20
			public Vector2Int temporalRenderSize; // 0x28
			public ScreenSpaceReflectionData cbData; // 0x30
			public CBHandle cbHandle; // 0xD0
			public TextureHandle previousSceneColorTexture; // 0xE8
			public TextureHandle previousSceneDepthPyramidTexture; // 0xF8
			public TextureHandle currentSceneColorTexture; // 0x108
			public TextureHandle currentSceneDepthTexture; // 0x118
			public TextureHandle currentSceneDepthPyramidTexture; // 0x128
			public TextureHandle gbufferNormalRoughenssTexture; // 0x138
			public TextureHandle normalRoughnessTexture; // 0x148
			public TextureHandle motionVectorTexture; // 0x158
			public TextureHandle waterWetnessMaskTexture; // 0x168
			public TextureHandle rayMarchingColorTexture; // 0x178
			public TextureHandle rayMarchingHitUVTexture; // 0x188
			public TextureHandle filterWeightTexture; // 0x198
			public TextureHandle fadenessTexture; // 0x1A8
			public TextureHandle fadenessBlurTexture0; // 0x1B8
			public TextureHandle fadenessBlurTexture1; // 0x1C8
			public TextureHandle previousFadenessTexture; // 0x1D8
			public TextureHandle currentFadenessTexture; // 0x1E8
			public TextureHandle previousTemporalColorTexture; // 0x1F8
			public TextureHandle currentTemporalColorTexture; // 0x208
			public TextureHandle currentColorPyramidTexture; // 0x218
			public TextureHandle currentColorResolveTexture; // 0x228
			public TextureHandle currentColorUpsampleTexture; // 0x238
			public TextureHandle sampleSceneColorTexture; // 0x248
			public ComputeShader computeShader; // 0x258
			public bool ssrRenderWetness; // 0x260
	
			// Constructors
			public PassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class TransparentPassData // TypeDefIndex: 38409
		{
			// Fields
			public bool needCopyGBufferAndDepth; // 0x10
			public uint forwardReflectionECSList; // 0x14
			public TextureHandle normalRoughnessTexture; // 0x18
			public TextureHandle currentSceneDepthTexture; // 0x28
			public MaterialPropertyBlock transparentMBP; // 0x38
	
			// Constructors
			public TransparentPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public HyperScreenSpaceReflectionRenderingPass() {} // Dummy constructor
		public HyperScreenSpaceReflectionRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB580-0x0000000182EDB700
		// HyperScreenSpaceReflectionRenderingPass(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HyperScreenSpaceReflectionRenderingPass(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  __int64 v8; // rcx
		  MaterialPropertyBlock *v9; // rsi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Texture *blackTexture; // rsi
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *v20; // rax
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  TextureHandle v24; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v25; // [rsp+60h] [rbp+28h]
		
		  *(_WORD *)&this->fields.m_firstFrame = 257;
		  this->fields.m_previousRenderSize = TypeInfo::UnityEngine::Vector2Int->static_fields->s_Zero;
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_ssrLightingTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v24, 0LL);
		  this->fields.m_ssrFadenessTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v24, 0LL);
		  v9 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v9 )
		    goto LABEL_4;
		  v9->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_transparentMBP = v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_transparentMBP, v10, v11, v12, *(MethodInfo **)&v24.handle);
		  blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RTHandles->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RTHandles);
		  this->fields.m_defaultTexutre = UnityEngine::Rendering::RTHandleSystem::Alloc(blackTexture, 0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultTexutre, v14, v15, v16, *(MethodInfo **)&v24.handle);
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || (this->fields.m_computeShader = shaders->fields.screenSpaceReflectionCS,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_computeShader,
		          v7,
		          v17,
		          v18,
		          *(MethodInfo **)&v24.handle),
		        !resources->defaultResources)
		    || (v20 = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		LABEL_4:
		    sub_1800D8260(v8, v7);
		  }
		  this->fields.m_pixelShader = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                 materialCollector,
		                                 v20->fields.screenSpaceReflectionPS,
		                                 0,
		                                 0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_pixelShader, v21, v22, v23, v25);
		}
		
		static HyperScreenSpaceReflectionRenderingPass() {} // 0x0000000184CB4040-0x0000000184CB4140
		// HyperScreenSpaceReflectionRenderingPass()
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::cctor(MethodInfo *method)
		{
		  struct HyperScreenSpaceReflectionRenderingPass_c__Class *v1; // rax
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
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c::__cctor_b__41_0,
		          0LL),
		        static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::__c::__cctor_b__41_1,
		    0LL);
		  v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass->static_fields->s_RenderTransparentFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		public bool ShouldRender(ref PassInput input, HGCamera hgCamera) => default; // 0x0000000189BCCF68-0x0000000189BCD03C
		// Boolean ShouldRender(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HGCamera)
		bool HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRender(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HyperScreenSpaceReflectionRenderingPass_PassInput *input,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3320, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3320, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1219(Patch, (Object *)this, input, (Object *)hgCamera, 0LL);
		LABEL_9:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !hgCamera )
		    goto LABEL_9;
		  if ( !HG::Rendering::Runtime::HGCamera::get_ssrEnable(hgCamera, 0LL) )
		    return 0;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->previousSceneColorTexture, 0LL) )
		    return 0;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->previousSceneDepthPyramidTexture, 0LL) )
		    return 0;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  return HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->currentSceneDepthPyramidTexture, 0LL);
		}
		
		private void PreparePassData(ref PassInput input, HGCamera hgCamera, PassData passData, bool wetnessEnabled = false /* Metadata: 0x02303CD3 */) {} // 0x0000000189BCA314-0x0000000189BCA850
		// Void PreparePassData(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HGCamera, HyperScreenSpaceReflectionRenderingPass+PassData, Boolean)
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PreparePassData(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HyperScreenSpaceReflectionRenderingPass_PassInput *input,
		        HGCamera *hgCamera,
		        HyperScreenSpaceReflectionRenderingPass_PassData *passData,
		        bool wetnessEnabled,
		        MethodInfo *method)
		{
		  void *fadenessOnScreen; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  ScreenSpaceReflectionVolume *m_hgssrVolume; // rax
		  double v15; // xmm0_8
		  unsigned int v16; // xmm10_4
		  HGCamera_VolumeComponentsData *v17; // rax
		  ScreenSpaceReflectionVolume *v18; // rax
		  double v19; // xmm0_8
		  float v20; // xmm7_4
		  HGCamera_VolumeComponentsData *v21; // rax
		  ScreenSpaceReflectionVolume *v22; // rax
		  double v23; // xmm0_8
		  float v24; // xmm6_4
		  HGCamera_VolumeComponentsData *v25; // rax
		  ScreenSpaceReflectionVolume *v26; // rax
		  double v27; // xmm0_8
		  unsigned int v28; // xmm9_4
		  HGCamera_VolumeComponentsData *v29; // rax
		  ScreenSpaceReflectionVolume *v30; // rax
		  double v31; // xmm0_8
		  float v32; // xmm8_4
		  char v33; // dl
		  __int64 v34; // rcx
		  int v35; // r8d
		  BOOL useWetnessMask; // r15d
		  int v37; // eax
		  int32_t v38; // r12d
		  Vector3Int *v39; // r8
		  ITilemap *v40; // r9
		  int32_t m_frameIndex; // eax
		  __m128i v42; // xmm2
		  uint32_t v43; // xmm0_4
		  float m_Y; // xmm1_4
		  uint32_t v45; // xmm0_4
		  __m128i v46; // xmm1
		  unsigned int v47; // edx
		  int v48; // eax
		  TileBase *v49; // rdx
		  __int64 v50; // rt2
		  bool v51; // zf
		  uint32_t v52; // xmm2_4
		  __m128i v53; // xmm2
		  __m128i v54; // xmm1
		  float v55; // xmm6_4
		  float v56; // xmm0_4
		  TileBase *v57; // rdx
		  Vector3Int *v58; // r8
		  ITilemap *v59; // r9
		  TileBase *v60; // rdx
		  Vector3Int *v61; // r8
		  ITilemap *v62; // r9
		  TileBase *v63; // rdx
		  Vector3Int *v64; // r8
		  ITilemap *v65; // r9
		  Vector4 v66; // xmm1
		  Vector4 v67; // xmm0
		  Vector4 v68; // xmm1
		  Vector4 v69; // xmm0
		  Vector4 v70; // xmm1
		  Vector4 v71; // xmm0
		  Vector4 v72; // xmm1
		  Vector4 v73; // xmm0
		  Vector4 v74; // xmm1
		  CBHandle *v75; // rax
		  HGRuntimeGrassQuery_Node *v76; // rdx
		  HGRuntimeGrassQuery_Node *v77; // r8
		  Int32__Array **v78; // r9
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3a; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3b; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3c; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3d; // [rsp+28h] [rbp-E0h]
		  CBHandle v84; // [rsp+48h] [rbp-C0h] BYREF
		  _QWORD v85[3]; // [rsp+60h] [rbp-A8h] BYREF
		  Vector4 v86; // [rsp+78h] [rbp-90h]
		  Vector4 v87; // [rsp+88h] [rbp-80h]
		  Vector4 v88; // [rsp+98h] [rbp-70h]
		  Vector4 v89; // [rsp+A8h] [rbp-60h]
		  Vector4 v90; // [rsp+B8h] [rbp-50h]
		  TileAnimationData v91; // [rsp+C8h] [rbp-40h]
		  TileAnimationData v92; // [rsp+D8h] [rbp-30h]
		  TileAnimationData v93; // [rsp+E8h] [rbp-20h]
		  TileAnimationData v94; // [rsp+F8h] [rbp-10h]
		  _OWORD source[15]; // [rsp+108h] [rbp+0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3321, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3321, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1220(
		        Patch,
		        (Object *)this,
		        input,
		        (Object *)hgCamera,
		        (Object *)passData,
		        wetnessEnabled,
		        0LL);
		      return;
		    }
		LABEL_29:
		    sub_1800D8260(Patch, fadenessOnScreen);
		  }
		  if ( !hgCamera )
		    goto LABEL_29;
		  sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_29;
		  m_hgssrVolume = volumeComponentsData->fields.m_hgssrVolume;
		  if ( !m_hgssrVolume )
		    goto LABEL_29;
		  fadenessOnScreen = m_hgssrVolume->fields.fadenessOnScreen;
		  if ( !fadenessOnScreen )
		    goto LABEL_29;
		  v15 = sub_1800057D0(10LL, fadenessOnScreen);
		  v16 = LODWORD(v15);
		  v17 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !v17 )
		    goto LABEL_29;
		  v18 = v17->fields.m_hgssrVolume;
		  if ( !v18 )
		    goto LABEL_29;
		  fadenessOnScreen = v18->fields.fadenessOnDepth;
		  if ( !fadenessOnScreen )
		    goto LABEL_29;
		  v19 = sub_1800057D0(10LL, fadenessOnScreen);
		  v20 = *(float *)&v19;
		  v21 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !v21 )
		    goto LABEL_29;
		  v22 = v21->fields.m_hgssrVolume;
		  if ( !v22 )
		    goto LABEL_29;
		  fadenessOnScreen = v22->fields.fadenessOnDepthFactor;
		  if ( !fadenessOnScreen )
		    goto LABEL_29;
		  v23 = sub_1800057D0(10LL, fadenessOnScreen);
		  v24 = *(float *)&v23;
		  v25 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !v25 )
		    goto LABEL_29;
		  v26 = v25->fields.m_hgssrVolume;
		  if ( !v26 )
		    goto LABEL_29;
		  fadenessOnScreen = v26->fields.fadenessOnMirrorMul;
		  if ( !fadenessOnScreen )
		    goto LABEL_29;
		  v27 = sub_1800057D0(10LL, fadenessOnScreen);
		  v28 = LODWORD(v27);
		  v29 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !v29 )
		    goto LABEL_29;
		  v30 = v29->fields.m_hgssrVolume;
		  if ( !v30 )
		    goto LABEL_29;
		  fadenessOnScreen = v30->fields.fadenessOnMirrorAdd;
		  if ( !fadenessOnScreen )
		    goto LABEL_29;
		  v31 = sub_1800057D0(10LL, fadenessOnScreen);
		  v32 = *(float *)&v31;
		  if ( !passData )
		    goto LABEL_29;
		  sub_1803367D0();
		  useWetnessMask = 1;
		  v37 = sub_1834464B0(v34, v33, v35) + 1;
		  v38 = 7;
		  if ( v37 < 7 )
		    v38 = v37;
		  passData->fields.maxMipCount = v38;
		  sub_18033B9D0(&v85[1], 0LL, 160LL);
		  m_frameIndex = this->fields.m_frameIndex;
		  v42 = _mm_cvtsi32_si128(passData->fields.ssrRenderSize.m_X);
		  *(float *)&v43 = (float)passData->fields.ssrRenderSize.m_X;
		  *(float *)&v84.offset = (float)passData->fields.ssrRenderSize.m_Y;
		  m_Y = (float)passData->fields.ssrRenderSize.m_Y;
		  v84.bufferId = v43;
		  *(float *)&v45 = 1.0 / _mm_cvtepi32_ps(v42).m128_f32[0];
		  *(_QWORD *)&v86.y = __PAIR64__(v28, v16);
		  *(float *)v42.m128i_i32 = 1.0 / m_Y;
		  v46 = _mm_cvtsi32_si128(m_frameIndex);
		  *(&v84.size + 1) = v42.m128i_i32[0];
		  v84.size = v45;
		  v47 = (m_frameIndex % 4) >> 31;
		  m_frameIndex %= 4;
		  v49 = (TileBase *)v47;
		  v50 = __SPAIR64__(v47, m_frameIndex) % 2;
		  v48 = __SPAIR64__(v47, m_frameIndex) / 2;
		  LODWORD(v49) = v50;
		  v51 = !this->fields.m_firstFrame;
		  v52 = 0;
		  LODWORD(v86.x) = _mm_cvtepi32_ps(v46).m128_u32[0];
		  v86.w = v32;
		  *(_OWORD *)&v85[1] = *(_OWORD *)&v84.bufferId;
		  if ( !v51 )
		    v52 = 1065353216;
		  *(&v84.size + 1) = 0;
		  *(_QWORD *)&v88.z = 0LL;
		  v84.size = v52;
		  v53 = _mm_cvtsi32_si128(input->ssrRayMarchingSampleCount);
		  *(float *)&v84.offset = (float)(int)v49;
		  v54 = _mm_cvtsi32_si128(input->ssrRayMarchingSampleCount);
		  *(float *)&v84.bufferId = (float)v48;
		  v87 = *(Vector4 *)&v84.bufferId;
		  v55 = v24 * v20;
		  v88.y = 1.0 / _mm_cvtepi32_ps(v54).m128_f32[0];
		  v56 = 0.0099999998;
		  LODWORD(v88.x) = _mm_cvtepi32_ps(v53).m128_u32[0];
		  if ( v55 >= 0.0099999998 )
		    v56 = v55;
		  *(_QWORD *)&v89.z = 0LL;
		  v90.x = 0.0;
		  *(_QWORD *)&v90.z = 0LL;
		  v89.y = 1.0 / v56;
		  v89.x = v20;
		  v90.y = (float)(v38 - 1);
		  v91 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v84, v49, v39, v40, P3);
		  v92 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v84, v57, v58, v59, P3a);
		  v93 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v84, v60, v61, v62, P3b);
		  v94 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v84, v63, v64, v65, P3c);
		  source[0] = *(_OWORD *)&v85[1];
		  source[1] = v86;
		  source[2] = v87;
		  source[3] = v88;
		  source[4] = v89;
		  source[5] = v90;
		  source[6] = v91;
		  source[7] = v92;
		  source[8] = v93;
		  v66 = v86;
		  source[9] = v94;
		  passData->fields.cbData.param0 = *(Vector4 *)&v85[1];
		  v67 = v87;
		  passData->fields.cbData.param1 = v66;
		  v68 = v88;
		  passData->fields.cbData.param2 = v67;
		  v69 = v89;
		  passData->fields.cbData.param3 = v68;
		  v70 = v90;
		  passData->fields.cbData.param4 = v69;
		  v71 = (Vector4)v91;
		  passData->fields.cbData.param5 = v70;
		  v72 = (Vector4)v92;
		  passData->fields.cbData.param6 = v71;
		  v73 = (Vector4)v93;
		  passData->fields.cbData.param7 = v72;
		  v74 = (Vector4)v94;
		  passData->fields.cbData.previousColorPyramidRenderSize = v73;
		  passData->fields.cbData.currentColorPyramidRenderSize = v74;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  v75 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v84, &input->renderContext, 160, 0LL);
		  *(_QWORD *)&v73.x = v75->ptr;
		  *(_OWORD *)&passData->fields.cbHandle.bufferId = *(_OWORD *)&v75->bufferId;
		  passData->fields.cbHandle.ptr = *(void **)&v73.x;
		  Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		    (Void *)passData->fields.cbHandle.ptr,
		    (Void *)source,
		    160LL,
		    0LL);
		  passData->fields.firstFrame = this->fields.m_firstFrame;
		  passData->fields.renderSize = sceneRTSize_k__BackingField;
		  passData->fields.computeShader = this->fields.m_computeShader;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.computeShader, v76, v77, v78, P3d);
		  if ( !wetnessEnabled )
		    useWetnessMask = hgCamera->fields.useWetnessMask;
		  passData->fields.ssrRenderWetness = useWetnessMask;
		}
		
		internal void Render(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, bool enableWetness = false /* Metadata: 0x02303CD4 */) {} // 0x0000000189BCABE0-0x0000000189BCCF04
		// Void Render(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HyperScreenSpaceReflectionRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, Boolean)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::Render(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HyperScreenSpaceReflectionRenderingPass_PassInput *input,
		        HyperScreenSpaceReflectionRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        bool enableWetness,
		        MethodInfo *method)
		{
		  HyperScreenSpaceReflectionRenderingPass_PassInput *v9; // rbx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rcx
		  __int64 v17; // rdx
		  Object *v18; // rdi
		  HGSettingParameters *settingParameters; // rcx
		  bool v20; // al
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Object *v23; // rdi
		  HGSettingParameters *v24; // rcx
		  bool v25; // al
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  HGRenderPipelineSettingHub *instance; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  __int64 v31; // rdx
		  Object *v32; // rdi
		  Vector2Int v33; // rbx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  ScreenSpaceReflectionVolume *m_hgssrVolume; // r14
		  ClampedFloatParameter *fadenessOnScreen; // r14
		  double v39; // xmm0_8
		  int32_t v40; // xmm11_4
		  HGCamera_VolumeComponentsData *v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  ScreenSpaceReflectionVolume *v44; // r14
		  FloatParameter *fadenessOnDepth; // r14
		  double v46; // xmm0_8
		  float v47; // xmm9_4
		  HGCamera_VolumeComponentsData *v48; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  ScreenSpaceReflectionVolume *v51; // r14
		  ClampedFloatParameter *fadenessOnDepthFactor; // r14
		  double v53; // xmm0_8
		  float v54; // xmm7_4
		  HGCamera_VolumeComponentsData *v55; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  ScreenSpaceReflectionVolume *v58; // r14
		  FloatParameter *fadenessOnMirrorMul; // r14
		  double v60; // xmm0_8
		  int32_t v61; // xmm10_4
		  HGCamera_VolumeComponentsData *v62; // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  ScreenSpaceReflectionVolume *v65; // r14
		  FloatParameter *fadenessOnMirrorAdd; // r14
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  double v69; // xmm0_8
		  int32_t v70; // xmm8_4
		  __int64 v71; // rcx
		  int v72; // r8d
		  int v73; // eax
		  float v74; // xmm3_4
		  uint32_t v75; // xmm2_4
		  int32_t m_frameIndex; // eax
		  int v77; // eax
		  int v78; // edx
		  unsigned int v79; // xmm2_4
		  int32_t v80; // xmm1_4
		  int32_t v81; // xmm6_4
		  Vector3Int *v82; // r8
		  ITilemap *v83; // r9
		  Vector3Int *v84; // r8
		  ITilemap *v85; // r9
		  Vector3Int *v86; // r8
		  ITilemap *v87; // r9
		  Vector3Int *v88; // r8
		  ITilemap *v89; // r9
		  CBHandle *v90; // rax
		  Object__Class *ptr; // xmm0_8
		  Object__Class *klass; // r14
		  void (__fastcall *v93)(Object__Class *, TextureDesc *, __int64); // rax
		  unsigned __int64 v94; // r8
		  signed __int64 v95; // rtt
		  BOOL useWetnessMask; // eax
		  __int64 v97; // rdx
		  ILFixDynamicMethodWrapper_2 *v98; // rcx
		  Object *v99; // rdi
		  __int64 v100; // rdx
		  __int64 v101; // rcx
		  TextureHandle v102; // xmm0
		  Object *v103; // rdi
		  __int64 v104; // rdx
		  __int64 v105; // rcx
		  TextureHandle v106; // xmm0
		  Object *v107; // rdi
		  __int64 v108; // rdx
		  __int64 v109; // rcx
		  TextureHandle v110; // xmm0
		  Object *v111; // rdi
		  __int64 v112; // rdx
		  __int64 v113; // rcx
		  TextureHandle v114; // xmm0
		  Object *v115; // rdi
		  __int64 v116; // rdx
		  __int64 v117; // rcx
		  TextureHandle v118; // xmm0
		  Object *v119; // rdi
		  __int64 v120; // rdx
		  __int64 v121; // rcx
		  TextureHandle v122; // xmm0
		  Object *v123; // rdi
		  __int64 v124; // rdx
		  __int64 v125; // rcx
		  TextureHandle v126; // xmm0
		  Object *v127; // rdi
		  TextureHandle *nullHandle; // rax
		  __int64 v129; // rdx
		  __int64 v130; // rcx
		  int32_t v131; // edi
		  int32_t v132; // ebx
		  __int128 v133; // xmm2
		  __int128 v134; // xmm3
		  Color v135; // xmm4
		  unsigned __int64 v136; // r8
		  signed __int64 v137; // rtt
		  Object *v138; // rbx
		  __int64 v139; // rdx
		  __int64 v140; // rcx
		  TextureHandle v141; // xmm0
		  Vector2Int v142; // rbx
		  __int128 v143; // xmm2
		  __int128 v144; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v146; // r8
		  signed __int64 v147; // rtt
		  Object *v148; // rbx
		  __int64 v149; // rdx
		  __int64 v150; // rcx
		  TextureHandle v151; // xmm0
		  int32_t v152; // edi
		  int32_t klass_high; // ebx
		  __int128 v154; // xmm2
		  __int128 v155; // xmm3
		  Color v156; // xmm4
		  unsigned __int64 v157; // r8
		  signed __int64 v158; // rtt
		  Object *v159; // rbx
		  TextureHandle v160; // xmm0
		  int32_t v161; // edi
		  int32_t v162; // ebx
		  __int128 v163; // xmm2
		  __int128 v164; // xmm3
		  Color v165; // xmm4
		  unsigned __int64 v166; // r8
		  signed __int64 v167; // rtt
		  Object *v168; // rbx
		  __int64 v169; // rdx
		  __int64 v170; // rcx
		  TextureHandle v171; // xmm0
		  int32_t v172; // edi
		  int32_t v173; // ebx
		  __int128 v174; // xmm2
		  __int128 v175; // xmm3
		  Color v176; // xmm4
		  unsigned __int64 v177; // r8
		  signed __int64 v178; // rtt
		  Object *v179; // rbx
		  __int64 v180; // rdx
		  __int64 v181; // rcx
		  TextureHandle v182; // xmm0
		  int32_t v183; // edi
		  int32_t v184; // ebx
		  __int128 v185; // xmm2
		  __int128 v186; // xmm3
		  Color v187; // xmm4
		  unsigned __int64 v188; // r8
		  signed __int64 v189; // rtt
		  Object *v190; // rbx
		  __int64 v191; // rdx
		  __int64 v192; // rcx
		  TextureHandle v193; // xmm0
		  Object *v194; // rbx
		  __int64 v195; // rdx
		  __int64 v196; // rcx
		  TextureHandle v197; // xmm0
		  Object *v198; // rbx
		  int32_t v199; // edi
		  int32_t v200; // ebx
		  __int128 v201; // xmm2
		  __int128 v202; // xmm3
		  Color v203; // xmm4
		  unsigned __int64 v204; // r8
		  signed __int64 v205; // rtt
		  Object *v206; // rbx
		  __int64 v207; // rdx
		  __int64 v208; // rcx
		  TextureHandle v209; // xmm0
		  int32_t v210; // edi
		  int32_t v211; // ebx
		  __int128 v212; // xmm2
		  __int128 v213; // xmm3
		  Color v214; // xmm4
		  unsigned __int64 v215; // r8
		  signed __int64 v216; // rtt
		  Object *v217; // rbx
		  __int64 v218; // rdx
		  __int64 v219; // rcx
		  TextureHandle v220; // xmm0
		  Vector2Int v221; // rbx
		  __int128 v222; // xmm2
		  __int128 v223; // xmm3
		  Color v224; // xmm4
		  unsigned __int64 v225; // r8
		  signed __int64 v226; // rtt
		  Object *v227; // rbx
		  __int64 v228; // rdx
		  __int64 v229; // rcx
		  TextureHandle v230; // xmm0
		  Object *v231; // rbx
		  __int64 v232; // rdx
		  __int64 v233; // rcx
		  TextureHandle v234; // xmm0
		  __int64 v235; // rdx
		  __int64 v236; // rcx
		  TextureHandle v237; // xmm0
		  __int64 v238; // rdx
		  __int64 v239; // rcx
		  TextureHandle v240; // xmm0
		  Object *v241; // rbx
		  TextureHandle v242; // xmm0
		  int32_t v243; // edi
		  int32_t v244; // ebx
		  __int128 v245; // xmm2
		  __int128 v246; // xmm3
		  Color v247; // xmm4
		  unsigned __int64 v248; // r8
		  signed __int64 v249; // rtt
		  int32_t v250; // edi
		  int32_t v251; // ebx
		  __int128 v252; // xmm2
		  __int128 v253; // xmm3
		  Color v254; // xmm4
		  unsigned __int64 v255; // r8
		  signed __int64 v256; // rtt
		  Object *v257; // rbx
		  __int64 v258; // rdx
		  __int64 v259; // rcx
		  TextureHandle v260; // xmm0
		  TextureHandle v261; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v263; // rdx
		  __int64 v264; // rcx
		  __int64 v265; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-7B8h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-7B8h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-7B8h]
		  MethodInfo *P3c; // [rsp+20h] [rbp-7B8h]
		  Object *v270; // [rsp+40h] [rbp-798h] BYREF
		  TextureHandle v271; // [rsp+48h] [rbp-790h] BYREF
		  CBHandle v272; // [rsp+58h] [rbp-780h] BYREF
		  __int128 v273; // [rsp+70h] [rbp-768h] BYREF
		  __int128 v274; // [rsp+80h] [rbp-758h]
		  __int128 v275; // [rsp+90h] [rbp-748h]
		  __int128 v276; // [rsp+A0h] [rbp-738h] BYREF
		  __int128 v277; // [rsp+B0h] [rbp-728h]
		  Color v278; // [rsp+C0h] [rbp-718h]
		  HGRenderGraphBuilder v279; // [rsp+D0h] [rbp-708h] BYREF
		  HGRenderGraphBuilder v280; // [rsp+F0h] [rbp-6E8h] BYREF
		  TextureDesc v281; // [rsp+110h] [rbp-6C8h] BYREF
		  TileAnimationData v282; // [rsp+170h] [rbp-668h]
		  TileAnimationData v283; // [rsp+180h] [rbp-658h]
		  TileAnimationData v284; // [rsp+190h] [rbp-648h]
		  TileAnimationData v285; // [rsp+1A0h] [rbp-638h]
		  TextureDesc v286; // [rsp+1B0h] [rbp-628h] BYREF
		  TextureDesc v287; // [rsp+210h] [rbp-5C8h] BYREF
		  TextureDesc v288; // [rsp+280h] [rbp-558h] BYREF
		  TextureDesc v289; // [rsp+2E0h] [rbp-4F8h] BYREF
		  TextureDesc v290; // [rsp+340h] [rbp-498h] BYREF
		  TextureDesc v291; // [rsp+3A0h] [rbp-438h] BYREF
		  TextureDesc v292; // [rsp+400h] [rbp-3D8h] BYREF
		  TextureDesc v293; // [rsp+460h] [rbp-378h] BYREF
		  TextureDesc v294; // [rsp+4C0h] [rbp-318h] BYREF
		  TextureDesc v295; // [rsp+520h] [rbp-2B8h] BYREF
		  TextureDesc v296; // [rsp+580h] [rbp-258h] BYREF
		  TextureDesc v297; // [rsp+5E0h] [rbp-1F8h] BYREF
		  TextureDesc v298; // [rsp+640h] [rbp-198h] BYREF
		  TextureDesc v299; // [rsp+6A0h] [rbp-138h] BYREF
		  TileAnimationData v300; // [rsp+700h] [rbp-D8h]
		  TileAnimationData v301; // [rsp+710h] [rbp-C8h]
		  TileAnimationData v302; // [rsp+720h] [rbp-B8h]
		  TileAnimationData v303; // [rsp+730h] [rbp-A8h]
		
		  v9 = input;
		  v270 = 0LL;
		  sub_18033B9D0(&v292, 0LL, 96LL);
		  sub_18033B9D0(&v293, 0LL, 96LL);
		  sub_18033B9D0(&v288, 0LL, 96LL);
		  sub_18033B9D0(&v290, 0LL, 96LL);
		  sub_18033B9D0(&v291, 0LL, 96LL);
		  sub_18033B9D0(&v273, 0LL, 96LL);
		  sub_18033B9D0(&v289, 0LL, 96LL);
		  sub_18033B9D0(&v294, 0LL, 96LL);
		  sub_18033B9D0(&v296, 0LL, 96LL);
		  sub_18033B9D0(&v295, 0LL, 96LL);
		  sub_18033B9D0(&v297, 0LL, 96LL);
		  sub_18033B9D0(&v298, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3322, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3322, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v264, v263);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1221(
		      Patch,
		      (Object *)this,
		      v9,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      enableWetness,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRender(this, v9, hgCamera, 0LL) )
		  {
		    this->fields.m_shouldRender = 1;
		    if ( !hgCamera )
		      sub_1800D8260(v12, v11);
		    if ( hgCamera->fields.prevTransformReset )
		      this->fields.m_firstFrame = 1;
		    v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x56u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v280,
		      renderGraph,
		      (String *)"Screen Space Reflection",
		      &v270,
		      v13,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
		    v279 = v280;
		    v280.m_RenderPass = 0LL;
		    v280.m_Resources = (HGRenderGraphResourceRegistry *)&v279;
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v279, 0, 0LL);
		    sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		    v271.handle.m_Value = sceneRTSize_k__BackingField.m_X / 2;
		    v17 = (unsigned int)(sceneRTSize_k__BackingField.m_Y >> 31);
		    v271.handle._type_k__BackingField = sceneRTSize_k__BackingField.m_Y / 2;
		    if ( !v270 )
		      sub_1800D8250(0LL, v17);
		    v270[2].klass = (Object__Class *)v271.handle;
		    v18 = v270;
		    settingParameters = v9->settingParameters;
		    if ( !settingParameters )
		      sub_1800D8250(0LL, v17);
		    v20 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            settingParameters->fields._ssrV2Upsample_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    if ( !v18 )
		      sub_1800D8250(v22, v21);
		    BYTE1(v18[1].klass) = v20;
		    v23 = v270;
		    v24 = v9->settingParameters;
		    if ( !v24 )
		      sub_1800D8250(0LL, v21);
		    v25 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            v24->fields._ssrImportanceSample_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    if ( !v23 )
		      sub_1800D8250(v27, v26);
		    BYTE2(v23[1].klass) = v25;
		    instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		    if ( !instance )
		      sub_1800D8250(v30, v29);
		    if ( HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(instance, 0LL) == HGDeviceType__Enum_Cinematic )
		    {
		      if ( !v270 )
		        sub_1800D8250(0LL, v31);
		      v270[2].klass = (Object__Class *)hgCamera->fields._sceneRTSize_k__BackingField;
		    }
		    v32 = v270;
		    if ( IFix::WrappersManagerImpl::IsPatched(3321, 0LL) )
		    {
		      v98 = IFix::WrappersManagerImpl::GetPatch(3321, 0LL);
		      if ( !v98 )
		        sub_1800D8250(0LL, v97);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1220(
		        v98,
		        (Object *)this,
		        v9,
		        (Object *)hgCamera,
		        v32,
		        enableWetness,
		        0LL);
		    }
		    else
		    {
		      v33 = hgCamera->fields._sceneRTSize_k__BackingField;
		      volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		      if ( !volumeComponentsData )
		        sub_1800D8250(v36, v35);
		      m_hgssrVolume = volumeComponentsData->fields.m_hgssrVolume;
		      if ( !m_hgssrVolume )
		        sub_1800D8250(v36, v35);
		      fadenessOnScreen = m_hgssrVolume->fields.fadenessOnScreen;
		      if ( !fadenessOnScreen )
		        sub_1800D8250(v36, v35);
		      sub_1800049A0(fadenessOnScreen->klass);
		      v39 = ((double (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))fadenessOnScreen->klass->vtable.get_value.method)(
		              fadenessOnScreen,
		              fadenessOnScreen->klass->vtable.set_value.methodPtr);
		      v40 = LODWORD(v39);
		      v41 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		      if ( !v41 )
		        sub_1800D8250(v43, v42);
		      v44 = v41->fields.m_hgssrVolume;
		      if ( !v44 )
		        sub_1800D8250(v43, v42);
		      fadenessOnDepth = v44->fields.fadenessOnDepth;
		      if ( !fadenessOnDepth )
		        sub_1800D8250(v43, v42);
		      sub_1800049A0(fadenessOnDepth->klass);
		      v46 = ((double (__fastcall *)(FloatParameter *, Il2CppMethodPointer))fadenessOnDepth->klass->vtable.get_value.method)(
		              fadenessOnDepth,
		              fadenessOnDepth->klass->vtable.set_value.methodPtr);
		      v47 = *(float *)&v46;
		      v48 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		      if ( !v48 )
		        sub_1800D8250(v50, v49);
		      v51 = v48->fields.m_hgssrVolume;
		      if ( !v51 )
		        sub_1800D8250(v50, v49);
		      fadenessOnDepthFactor = v51->fields.fadenessOnDepthFactor;
		      if ( !fadenessOnDepthFactor )
		        sub_1800D8250(v50, v49);
		      sub_1800049A0(fadenessOnDepthFactor->klass);
		      v53 = ((double (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))fadenessOnDepthFactor->klass->vtable.get_value.method)(
		              fadenessOnDepthFactor,
		              fadenessOnDepthFactor->klass->vtable.set_value.methodPtr);
		      v54 = *(float *)&v53;
		      v55 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		      if ( !v55 )
		        sub_1800D8250(v57, v56);
		      v58 = v55->fields.m_hgssrVolume;
		      if ( !v58 )
		        sub_1800D8250(v57, v56);
		      fadenessOnMirrorMul = v58->fields.fadenessOnMirrorMul;
		      if ( !fadenessOnMirrorMul )
		        sub_1800D8250(v57, v56);
		      sub_1800049A0(fadenessOnMirrorMul->klass);
		      v60 = ((double (__fastcall *)(FloatParameter *, Il2CppMethodPointer))fadenessOnMirrorMul->klass->vtable.get_value.method)(
		              fadenessOnMirrorMul,
		              fadenessOnMirrorMul->klass->vtable.set_value.methodPtr);
		      v61 = LODWORD(v60);
		      v62 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		      if ( !v62 )
		        sub_1800D8250(v64, v63);
		      v65 = v62->fields.m_hgssrVolume;
		      if ( !v65 )
		        sub_1800D8250(v64, v63);
		      fadenessOnMirrorAdd = v65->fields.fadenessOnMirrorAdd;
		      if ( !fadenessOnMirrorAdd )
		        sub_1800D8250(v64, v63);
		      sub_1800049A0(fadenessOnMirrorAdd->klass);
		      v69 = ((double (__fastcall *)(FloatParameter *, Il2CppMethodPointer))fadenessOnMirrorAdd->klass->vtable.get_value.method)(
		              fadenessOnMirrorAdd,
		              fadenessOnMirrorAdd->klass->vtable.set_value.methodPtr);
		      v70 = LODWORD(v69);
		      if ( !v32 )
		        sub_1800D8250(v68, v67);
		      UnityEngine::Mathf::Min((int32_t)v32[2].klass, HIDWORD(v32[2].klass), 0LL);
		      sub_1803367D0();
		      v73 = sub_1834464B0(v71, 0, v72);
		      v271.handle.m_Value = UnityEngine::Mathf::Min(v73 + 1, 7, 0LL);
		      HIDWORD(v32[1].klass) = v271.handle.m_Value;
		      sub_18033B9D0(&v281, 0LL, 160LL);
		      v74 = 1.0 / (float)SHIDWORD(v32[2].klass);
		      *(float *)&v75 = 1.0 / (float)SLODWORD(v32[2].klass);
		      *(float *)&v272.bufferId = (float)SLODWORD(v32[2].klass);
		      *(float *)&v272.offset = (float)SHIDWORD(v32[2].klass);
		      v272.size = v75;
		      *((float *)&v272.size + 1) = v74;
		      *(_OWORD *)&v281.width = *(_OWORD *)&v272.bufferId;
		      m_frameIndex = this->fields.m_frameIndex;
		      *(float *)&v281.colorFormat = (float)m_frameIndex;
		      v281.filterMode = v40;
		      v281.wrapMode = v61;
		      v281.dimension = v70;
		      m_frameIndex %= 4;
		      v78 = m_frameIndex % 2;
		      v77 = m_frameIndex / 2;
		      if ( this->fields.m_firstFrame )
		        v79 = 1065353216;
		      else
		        v79 = 0;
		      *(float *)&v272.bufferId = (float)v77;
		      *(float *)&v272.offset = (float)v78;
		      *(_QWORD *)&v272.size = v79;
		      *(_OWORD *)&v281.enableRandomWrite = *(_OWORD *)&v272.bufferId;
		      *(float *)&v80 = 1.0 / (float)input->ssrRayMarchingSampleCount;
		      *(float *)&v281.bindTextureMS = (float)input->ssrRayMarchingSampleCount;
		      v281.memoryless = v80;
		      v281.name = 0LL;
		      *(float *)&v81 = 1.0 / UnityEngine::Mathf::Max(0.0099999998, v54 * v47, 0LL);
		      *(float *)&v281.fastMemoryDesc.inFastMemory = v47;
		      v281.fastMemoryDesc.flags = v81;
		      v281.fastMemoryDesc.residencyFraction = 0.0;
		      *(_DWORD *)&v281.fallBackToBlackTexture = 0;
		      v281.clearColor.r = 0.0;
		      v281.clearColor.g = (float)(v271.handle.m_Value - 1);
		      v281.clearColor.b = 0.0;
		      v281.clearColor.a = 0.0;
		      v282 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v272, 0LL, v82, v83, P3);
		      v283 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v272, 0LL, v84, v85, P3a);
		      v284 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v272, 0LL, v86, v87, P3b);
		      v285 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v272, 0LL, v88, v89, P3c);
		      v299 = v281;
		      v300 = v282;
		      v301 = v283;
		      v302 = v284;
		      v303 = v285;
		      *(TextureDesc *)&v32[3].klass = v281;
		      v32[9] = (Object)v282;
		      v32[10] = (Object)v283;
		      v32[11] = (Object)v284;
		      v32[12] = (Object)v285;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v90 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              &v272,
		              &input->renderContext,
		              160,
		              0LL);
		      ptr = (Object__Class *)v90->ptr;
		      v32[13] = *(Object *)&v90->bufferId;
		      v32[14].klass = ptr;
		      klass = v32[14].klass;
		      v93 = (void (__fastcall *)(Object__Class *, TextureDesc *, __int64))qword_18F36EF28;
		      if ( !qword_18F36EF28 )
		      {
		        v93 = (void (__fastcall *)(Object__Class *, TextureDesc *, __int64))il2cpp_resolve_icall_1(
		                                                                              "Unity.Collections.LowLevel.Unsafe.UnsafeUt"
		                                                                              "ility::MemCpy(System.Void*,System.Void*,System.Int64)");
		        if ( !v93 )
		        {
		          v265 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
		          sub_18007E1B0(v265, 0LL);
		        }
		        qword_18F36EF28 = (__int64)v93;
		      }
		      v93(klass, &v299, 160LL);
		      LOBYTE(v32[1].klass) = this->fields.m_firstFrame;
		      v32[1].monitor = (MonitorData *)v33;
		      v32[37].monitor = (MonitorData *)this->fields.m_computeShader;
		      if ( dword_18F35FD08 )
		      {
		        v94 = (((unsigned __int64)&v32[37].monitor >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v94 + 36190]);
		        do
		          v95 = qword_18F0BCBA0[v94 + 36190];
		        while ( v95 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v94 + 36190],
		                         v95 | (1LL << (((unsigned __int64)&v32[37].monitor >> 12) & 0x3F)),
		                         v95) );
		      }
		      useWetnessMask = 1;
		      if ( !enableWetness )
		        useWetnessMask = hgCamera->fields.useWetnessMask;
		      LOBYTE(v32[38].klass) = useWetnessMask;
		      v9 = input;
		    }
		    v99 = v270;
		    v102 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->previousSceneColorTexture,
		              0LL);
		    if ( !v99 )
		      sub_1800D8250(v101, v100);
		    *(TextureHandle *)&v99[14].monitor = v102;
		    v103 = v270;
		    v106 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->previousSceneDepthPyramidTexture,
		              0LL);
		    if ( !v103 )
		      sub_1800D8250(v105, v104);
		    *(TextureHandle *)&v103[15].monitor = v106;
		    v107 = v270;
		    v110 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->currentSceneDepthTexture,
		              0LL);
		    if ( !v107 )
		      sub_1800D8250(v109, v108);
		    *(TextureHandle *)&v107[17].monitor = v110;
		    v111 = v270;
		    v114 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->currentSceneDepthPyramidTexture,
		              0LL);
		    if ( !v111 )
		      sub_1800D8250(v113, v112);
		    *(TextureHandle *)&v111[18].monitor = v114;
		    v115 = v270;
		    v118 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->gbufferNormalRoughenssTexture,
		              0LL);
		    if ( !v115 )
		      sub_1800D8250(v117, v116);
		    *(TextureHandle *)&v115[19].monitor = v118;
		    v119 = v270;
		    v122 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->normalRoughnessTexture,
		              0LL);
		    if ( !v119 )
		      sub_1800D8250(v121, v120);
		    *(TextureHandle *)&v119[20].monitor = v122;
		    v123 = v270;
		    v126 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v9->motionVectorTexture,
		              0LL);
		    if ( !v123 )
		      sub_1800D8250(v125, v124);
		    *(TextureHandle *)&v123[21].monitor = v126;
		    v127 = v270;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v9->waterWetnessMaskTexture, 0LL) )
		    {
		      nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                     (TextureHandle *)&v272,
		                     &v279,
		                     &v9->waterWetnessMaskTexture,
		                     0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)&v272, 0LL);
		    }
		    if ( !v127 )
		      sub_1800D8250(v130, v129);
		    *(Object *)((char *)v127 + 360) = *(Object *)nullHandle;
		    if ( !v270 )
		      sub_1800D8250(v130, v129);
		    if ( BYTE1(v270[1].klass) )
		    {
		      v142 = hgCamera->fields._sceneRTSize_k__BackingField;
		      sub_18033B9D0(&v286, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v286,
		        hgCamera->fields._sceneRTSize_k__BackingField.m_X,
		        v142.m_Y,
		        0LL);
		      v143 = *(_OWORD *)&v286.width;
		      v273 = *(_OWORD *)&v286.width;
		      v274 = *(_OWORD *)&v286.colorFormat;
		      v275 = *(_OWORD *)&v286.enableRandomWrite;
		      *(_QWORD *)&v276 = *(_QWORD *)&v286.bindTextureMS;
		      v144 = *(_OWORD *)&v286.fastMemoryDesc.inFastMemory;
		      v277 = *(_OWORD *)&v286.fastMemoryDesc.inFastMemory;
		      clearColor = v286.clearColor;
		      v278 = v286.clearColor;
		      *((_QWORD *)&v276 + 1) = "Screen Space Reflection Ray Marching Color Texture";
		      if ( dword_18F35FD08 )
		      {
		        v146 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v146 + 36190]);
		        do
		          v147 = qword_18F0BCBA0[v146 + 36190];
		        while ( v147 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v146 + 36190],
		                          v147 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                          v147) );
		        clearColor = v278;
		        v144 = v277;
		        v143 = v273;
		      }
		      LODWORD(v274) = 74;
		      LOBYTE(v275) = 1;
		      *(_OWORD *)&v290.width = v143;
		      *(_OWORD *)&v290.colorFormat = v274;
		      *(_OWORD *)&v290.enableRandomWrite = v275;
		      *(_OWORD *)&v290.bindTextureMS = v276;
		      *(_OWORD *)&v290.fastMemoryDesc.inFastMemory = v144;
		      v290.clearColor = clearColor;
		      v148 = v270;
		      v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&v272,
		                renderGraph,
		                &v290,
		                0LL);
		      v151 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &v271,
		                0LL);
		      if ( !v148 )
		        sub_1800D8250(v150, v149);
		      *(TextureHandle *)&v148[23].monitor = v151;
		      if ( !v270 )
		        sub_1800D8250(v150, v149);
		      v152 = (int32_t)v270[2].klass;
		      klass_high = HIDWORD(v270[2].klass);
		      sub_18033B9D0(&v287, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v287, v152, klass_high, 0LL);
		      v154 = *(_OWORD *)&v287.width;
		      v273 = *(_OWORD *)&v287.width;
		      v274 = *(_OWORD *)&v287.colorFormat;
		      v275 = *(_OWORD *)&v287.enableRandomWrite;
		      *(_QWORD *)&v276 = *(_QWORD *)&v287.bindTextureMS;
		      v155 = *(_OWORD *)&v287.fastMemoryDesc.inFastMemory;
		      v277 = *(_OWORD *)&v287.fastMemoryDesc.inFastMemory;
		      v156 = v287.clearColor;
		      v278 = v287.clearColor;
		      *((_QWORD *)&v276 + 1) = "Screen Space Reflection Ray Marching Hit UV Texture";
		      if ( dword_18F35FD08 )
		      {
		        v157 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v157 + 36190]);
		        do
		          v158 = qword_18F0BCBA0[v157 + 36190];
		        while ( v158 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v157 + 36190],
		                          v158 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                          v158) );
		        v156 = v278;
		        v155 = v277;
		        v154 = v273;
		      }
		      LODWORD(v274) = 22;
		      LOBYTE(v275) = 1;
		      *(_OWORD *)&v291.width = v154;
		      *(_OWORD *)&v291.colorFormat = v274;
		      *(_OWORD *)&v291.enableRandomWrite = v275;
		      *(_OWORD *)&v291.bindTextureMS = v276;
		      *(_OWORD *)&v291.fastMemoryDesc.inFastMemory = v155;
		      v291.clearColor = v156;
		      v159 = v270;
		      v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&v272,
		                renderGraph,
		                &v291,
		                0LL);
		      v160 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &v271,
		                0LL);
		      if ( !v159 )
		        sub_1800D8250(v140, v139);
		      *(TextureHandle *)&v159[24].monitor = v160;
		    }
		    else
		    {
		      v131 = (int32_t)v270[2].klass;
		      v132 = HIDWORD(v270[2].klass);
		      sub_18033B9D0(&v286, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v286, v131, v132, 0LL);
		      v133 = *(_OWORD *)&v286.width;
		      v273 = *(_OWORD *)&v286.width;
		      v274 = *(_OWORD *)&v286.colorFormat;
		      v275 = *(_OWORD *)&v286.enableRandomWrite;
		      *(_QWORD *)&v276 = *(_QWORD *)&v286.bindTextureMS;
		      v134 = *(_OWORD *)&v286.fastMemoryDesc.inFastMemory;
		      v277 = *(_OWORD *)&v286.fastMemoryDesc.inFastMemory;
		      v135 = v286.clearColor;
		      v278 = v286.clearColor;
		      *((_QWORD *)&v276 + 1) = "Screen Space Reflection Ray Marching Color Texture";
		      if ( dword_18F35FD08 )
		      {
		        v136 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v136 + 36190]);
		        do
		          v137 = qword_18F0BCBA0[v136 + 36190];
		        while ( v137 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v136 + 36190],
		                          v137 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                          v137) );
		        v135 = v278;
		        v134 = v277;
		        v133 = v273;
		      }
		      LODWORD(v274) = 74;
		      LOBYTE(v275) = 1;
		      *(_OWORD *)&v289.width = v133;
		      *(_OWORD *)&v289.colorFormat = v274;
		      *(_OWORD *)&v289.enableRandomWrite = v275;
		      *(_OWORD *)&v289.bindTextureMS = v276;
		      *(_OWORD *)&v289.fastMemoryDesc.inFastMemory = v134;
		      v289.clearColor = v135;
		      v138 = v270;
		      v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&v272,
		                renderGraph,
		                &v289,
		                0LL);
		      v141 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &v271,
		                0LL);
		      if ( !v138 )
		        sub_1800D8250(v140, v139);
		      *(TextureHandle *)&v138[23].monitor = v141;
		    }
		    if ( !v270 )
		      sub_1800D8250(v140, v139);
		    v161 = (int32_t)v270[2].klass;
		    v162 = HIDWORD(v270[2].klass);
		    sub_18033B9D0(&v287, 0LL, 96LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v287, v161, v162, 0LL);
		    v163 = *(_OWORD *)&v287.width;
		    v273 = *(_OWORD *)&v287.width;
		    v274 = *(_OWORD *)&v287.colorFormat;
		    v275 = *(_OWORD *)&v287.enableRandomWrite;
		    *(_QWORD *)&v276 = *(_QWORD *)&v287.bindTextureMS;
		    v164 = *(_OWORD *)&v287.fastMemoryDesc.inFastMemory;
		    v277 = *(_OWORD *)&v287.fastMemoryDesc.inFastMemory;
		    v165 = v287.clearColor;
		    v278 = v287.clearColor;
		    *((_QWORD *)&v276 + 1) = "Screen Space Reflection Filter Weight Texture";
		    if ( dword_18F35FD08 )
		    {
		      v166 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v166 + 36190]);
		      do
		        v167 = qword_18F0BCBA0[v166 + 36190];
		      while ( v167 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v166 + 36190],
		                        v167 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                        v167) );
		      v165 = v278;
		      v164 = v277;
		      v163 = v273;
		    }
		    LODWORD(v274) = 22;
		    LOBYTE(v275) = 1;
		    *(_OWORD *)&v292.width = v163;
		    *(_OWORD *)&v292.colorFormat = v274;
		    *(_OWORD *)&v292.enableRandomWrite = v275;
		    *(_OWORD *)&v292.bindTextureMS = v276;
		    *(_OWORD *)&v292.fastMemoryDesc.inFastMemory = v164;
		    v292.clearColor = v165;
		    v168 = v270;
		    v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		              (TextureHandle *)&v272,
		              renderGraph,
		              &v292,
		              0LL);
		    v171 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v271,
		              0LL);
		    if ( !v168 )
		      sub_1800D8250(v170, v169);
		    *(TextureHandle *)&v168[25].monitor = v171;
		    if ( !v270 )
		      sub_1800D8250(v170, v169);
		    v172 = (int32_t)v270[2].klass;
		    v173 = HIDWORD(v270[2].klass);
		    sub_18033B9D0(&v286, 0LL, 96LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v286, v172, v173, 0LL);
		    v174 = *(_OWORD *)&v286.width;
		    v273 = *(_OWORD *)&v286.width;
		    v274 = *(_OWORD *)&v286.colorFormat;
		    v275 = *(_OWORD *)&v286.enableRandomWrite;
		    *(_QWORD *)&v276 = *(_QWORD *)&v286.bindTextureMS;
		    v175 = *(_OWORD *)&v286.fastMemoryDesc.inFastMemory;
		    v277 = *(_OWORD *)&v286.fastMemoryDesc.inFastMemory;
		    v176 = v286.clearColor;
		    v278 = v286.clearColor;
		    *((_QWORD *)&v276 + 1) = "Screen Space Reflection Fadeness Texture";
		    if ( dword_18F35FD08 )
		    {
		      v177 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v177 + 36190]);
		      do
		        v178 = qword_18F0BCBA0[v177 + 36190];
		      while ( v178 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v177 + 36190],
		                        v178 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                        v178) );
		      v176 = v278;
		      v175 = v277;
		      v174 = v273;
		    }
		    LODWORD(v274) = 5;
		    LOBYTE(v275) = 1;
		    *(_OWORD *)&v293.width = v174;
		    *(_OWORD *)&v293.colorFormat = v274;
		    *(_OWORD *)&v293.enableRandomWrite = v275;
		    *(_OWORD *)&v293.bindTextureMS = v276;
		    *(_OWORD *)&v293.fastMemoryDesc.inFastMemory = v175;
		    v293.clearColor = v176;
		    v179 = v270;
		    v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		              (TextureHandle *)&v272,
		              renderGraph,
		              &v293,
		              0LL);
		    v182 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v271,
		              0LL);
		    if ( !v179 )
		      sub_1800D8250(v181, v180);
		    *(TextureHandle *)&v179[26].monitor = v182;
		    if ( !v270 )
		      sub_1800D8250(v181, v180);
		    v183 = (int32_t)v270[2].klass;
		    v184 = HIDWORD(v270[2].klass);
		    sub_18033B9D0(&v299, 0LL, 96LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v299, v183, v184, 0LL);
		    v185 = *(_OWORD *)&v299.width;
		    v273 = *(_OWORD *)&v299.width;
		    v274 = *(_OWORD *)&v299.colorFormat;
		    v275 = *(_OWORD *)&v299.enableRandomWrite;
		    *(_QWORD *)&v276 = *(_QWORD *)&v299.bindTextureMS;
		    v186 = *(_OWORD *)&v299.fastMemoryDesc.inFastMemory;
		    v277 = *(_OWORD *)&v299.fastMemoryDesc.inFastMemory;
		    v187 = v299.clearColor;
		    v278 = v299.clearColor;
		    *((_QWORD *)&v276 + 1) = "Screen Space Reflection Fadeness Resolve Texture";
		    if ( dword_18F35FD08 )
		    {
		      v188 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v188 + 36190]);
		      do
		        v189 = qword_18F0BCBA0[v188 + 36190];
		      while ( v189 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v188 + 36190],
		                        v189 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                        v189) );
		      v187 = v278;
		      v186 = v277;
		      v185 = v273;
		    }
		    LODWORD(v274) = 5;
		    LOBYTE(v275) = 1;
		    *(_OWORD *)&v288.width = v185;
		    *(_OWORD *)&v288.colorFormat = v274;
		    *(_OWORD *)&v288.enableRandomWrite = v275;
		    *(_OWORD *)&v288.bindTextureMS = v276;
		    *(_OWORD *)&v288.fastMemoryDesc.inFastMemory = v186;
		    v288.clearColor = v187;
		    v190 = v270;
		    v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		              (TextureHandle *)&v272,
		              renderGraph,
		              &v288,
		              0LL);
		    v193 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v271,
		              0LL);
		    if ( !v190 )
		      sub_1800D8250(v192, v191);
		    *(TextureHandle *)&v190[27].monitor = v193;
		    v194 = v270;
		    v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		              (TextureHandle *)&v272,
		              renderGraph,
		              &v288,
		              0LL);
		    v197 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v271,
		              0LL);
		    if ( !v194 )
		      sub_1800D8250(v196, v195);
		    *(TextureHandle *)&v194[28].monitor = v197;
		    v198 = v270;
		    if ( !v270 )
		      sub_1800D8250(v196, v195);
		    this->fields.m_ssrFadenessTexture = *(TextureHandle *)((char *)v270 + 440);
		    v199 = (int32_t)v198[2].klass;
		    v200 = HIDWORD(v198[2].klass);
		    sub_18033B9D0(&v281, 0LL, 96LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v281, v199, v200, 0LL);
		    v201 = *(_OWORD *)&v281.width;
		    v273 = *(_OWORD *)&v281.width;
		    v274 = *(_OWORD *)&v281.colorFormat;
		    v275 = *(_OWORD *)&v281.enableRandomWrite;
		    *(_QWORD *)&v276 = *(_QWORD *)&v281.bindTextureMS;
		    v202 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		    v277 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		    v203 = v281.clearColor;
		    v278 = v281.clearColor;
		    *((_QWORD *)&v276 + 1) = "Screen Space Reflection Current Fadeness Texture";
		    if ( dword_18F35FD08 )
		    {
		      v204 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v204 + 36190]);
		      do
		        v205 = qword_18F0BCBA0[v204 + 36190];
		      while ( v205 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v204 + 36190],
		                        v205 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                        v205) );
		      v203 = v278;
		      v202 = v277;
		      v201 = v273;
		    }
		    LODWORD(v274) = 5;
		    LOWORD(v275) = 257;
		    BYTE2(v275) = 0;
		    *(_OWORD *)&v294.width = v201;
		    *(_OWORD *)&v294.colorFormat = v274;
		    *(_OWORD *)&v294.enableRandomWrite = v275;
		    *(_OWORD *)&v294.bindTextureMS = v276;
		    *(_OWORD *)&v294.fastMemoryDesc.inFastMemory = v202;
		    v294.clearColor = v203;
		    v206 = v270;
		    v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		              (TextureHandle *)&v272,
		              renderGraph,
		              &v294,
		              0LL);
		    v209 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v271,
		              0LL);
		    if ( !v206 )
		      sub_1800D8250(v208, v207);
		    *(TextureHandle *)&v206[30].monitor = v209;
		    if ( !v270 )
		      sub_1800D8250(v208, v207);
		    if ( BYTE1(v270[1].klass) )
		    {
		      v221 = hgCamera->fields._sceneRTSize_k__BackingField;
		      sub_18033B9D0(&v281, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v281,
		        hgCamera->fields._sceneRTSize_k__BackingField.m_X,
		        v221.m_Y,
		        0LL);
		      v222 = *(_OWORD *)&v281.width;
		      v273 = *(_OWORD *)&v281.width;
		      v274 = *(_OWORD *)&v281.colorFormat;
		      v275 = *(_OWORD *)&v281.enableRandomWrite;
		      *(_QWORD *)&v276 = *(_QWORD *)&v281.bindTextureMS;
		      v223 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		      v277 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		      v224 = v281.clearColor;
		      v278 = v281.clearColor;
		      *((_QWORD *)&v276 + 1) = "Screen Space Reflection Temporal Texture";
		      if ( dword_18F35FD08 )
		      {
		        v225 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v225 + 36190]);
		        do
		          v226 = qword_18F0BCBA0[v225 + 36190];
		        while ( v226 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v225 + 36190],
		                          v226 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                          v226) );
		        v224 = v278;
		        v223 = v277;
		        v222 = v273;
		      }
		      LODWORD(v274) = 74;
		      LOBYTE(v275) = 1;
		      *(_OWORD *)&v296.width = v222;
		      *(_OWORD *)&v296.colorFormat = v274;
		      *(_OWORD *)&v296.enableRandomWrite = v275;
		      *(_OWORD *)&v296.bindTextureMS = v276;
		      *(_OWORD *)&v296.fastMemoryDesc.inFastMemory = v223;
		      v296.clearColor = v224;
		      v217 = v270;
		      v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&v272,
		                renderGraph,
		                &v296,
		                0LL);
		      v220 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &v271,
		                0LL);
		      if ( !v217 )
		        sub_1800D8250(v219, v218);
		    }
		    else
		    {
		      v210 = (int32_t)v270[2].klass;
		      v211 = HIDWORD(v270[2].klass);
		      sub_18033B9D0(&v281, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v281, v210, v211, 0LL);
		      v212 = *(_OWORD *)&v281.width;
		      v273 = *(_OWORD *)&v281.width;
		      v274 = *(_OWORD *)&v281.colorFormat;
		      v275 = *(_OWORD *)&v281.enableRandomWrite;
		      *(_QWORD *)&v276 = *(_QWORD *)&v281.bindTextureMS;
		      v213 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		      v277 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		      v214 = v281.clearColor;
		      v278 = v281.clearColor;
		      *((_QWORD *)&v276 + 1) = "Screen Space Reflection Temporal Texture";
		      if ( dword_18F35FD08 )
		      {
		        v215 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v215 + 36190]);
		        do
		          v216 = qword_18F0BCBA0[v215 + 36190];
		        while ( v216 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v215 + 36190],
		                          v216 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                          v216) );
		        v214 = v278;
		        v213 = v277;
		        v212 = v273;
		      }
		      LODWORD(v274) = 74;
		      LOWORD(v275) = 257;
		      BYTE2(v275) = 0;
		      *(_OWORD *)&v295.width = v212;
		      *(_OWORD *)&v295.colorFormat = v274;
		      *(_OWORD *)&v295.enableRandomWrite = v275;
		      *(_OWORD *)&v295.bindTextureMS = v276;
		      *(_OWORD *)&v295.fastMemoryDesc.inFastMemory = v213;
		      v295.clearColor = v214;
		      v217 = v270;
		      v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&v272,
		                renderGraph,
		                &v295,
		                0LL);
		      v220 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &v271,
		                0LL);
		      if ( !v217 )
		        sub_1800D8250(v219, v218);
		    }
		    *(TextureHandle *)&v217[32].monitor = v220;
		    v227 = v270;
		    if ( !v270 )
		      sub_1800D8250(v219, v218);
		    this->fields.m_currentFadenessTexture = *(TextureHandle *)((char *)v270 + 488);
		    this->fields.m_currentTemporalColorTexture = *(TextureHandle *)((char *)v227 + 520);
		    if ( this->fields.m_firstFrame )
		    {
		      v240 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                (TextureHandle *)&v227[26].monitor,
		                0LL);
		      if ( !v227 )
		        sub_1800D8250(v239, v238);
		      *(TextureHandle *)&v227[29].monitor = v240;
		      v231 = v270;
		      if ( !v270 )
		        sub_1800D8250(v239, v238);
		      v234 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                (TextureHandle *)&v270[23].monitor,
		                0LL);
		    }
		    else if ( this->fields.m_prevFrameWasReset )
		    {
		      v237 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                (TextureHandle *)&v227[26].monitor,
		                0LL);
		      if ( !v227 )
		        sub_1800D8250(v236, v235);
		      *(TextureHandle *)&v227[29].monitor = v237;
		      v231 = v270;
		      v234 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &input->previousSceneColorTexture,
		                0LL);
		      if ( !v231 )
		        sub_1800D8250(v233, v232);
		    }
		    else
		    {
		      v230 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &this->fields.m_previousFadenessTexture,
		                0LL);
		      if ( !v227 )
		        sub_1800D8250(v229, v228);
		      *(TextureHandle *)&v227[29].monitor = v230;
		      v231 = v270;
		      v234 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &this->fields.m_previousTemporalColorTexture,
		                0LL);
		      if ( !v231 )
		        sub_1800D8250(v233, v232);
		    }
		    *(TextureHandle *)&v231[31].monitor = v234;
		    v241 = v270;
		    if ( !v270 )
		      sub_1800D8250(v233, v232);
		    if ( BYTE1(v270[1].klass) )
		    {
		      v243 = (int32_t)v270[2].klass;
		      v244 = HIDWORD(v270[2].klass);
		      sub_18033B9D0(&v281, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v281, v243, v244, 0LL);
		      v245 = *(_OWORD *)&v281.width;
		      v273 = *(_OWORD *)&v281.width;
		      v274 = *(_OWORD *)&v281.colorFormat;
		      v275 = *(_OWORD *)&v281.enableRandomWrite;
		      *(_QWORD *)&v276 = *(_QWORD *)&v281.bindTextureMS;
		      v246 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		      v277 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		      v247 = v281.clearColor;
		      v278 = v281.clearColor;
		      *((_QWORD *)&v276 + 1) = "Screen Space Reflection Temporal Texture";
		      if ( dword_18F35FD08 )
		      {
		        v248 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v248 + 36190]);
		        do
		          v249 = qword_18F0BCBA0[v248 + 36190];
		        while ( v249 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v248 + 36190],
		                          v249 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                          v249) );
		        v247 = v278;
		        v246 = v277;
		        v245 = v273;
		      }
		      LODWORD(v274) = 74;
		      LOWORD(v275) = 257;
		      BYTE2(v275) = 0;
		      *(_OWORD *)&v297.width = v245;
		      *(_OWORD *)&v297.colorFormat = v274;
		      *(_OWORD *)&v297.enableRandomWrite = v275;
		      *(_OWORD *)&v297.bindTextureMS = v276;
		      *(_OWORD *)&v297.fastMemoryDesc.inFastMemory = v246;
		      v297.clearColor = v247;
		      v241 = v270;
		      v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&v272,
		                renderGraph,
		                &v297,
		                0LL);
		      v242 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v272,
		                &v279,
		                &v271,
		                0LL);
		      if ( !v241 )
		        sub_1800D8250(v233, v232);
		    }
		    else
		    {
		      v242 = *(TextureHandle *)&v270[32].monitor;
		    }
		    *(TextureHandle *)&v241[33].monitor = v242;
		    if ( !v270 )
		      sub_1800D8250(v233, v232);
		    v250 = (int32_t)v270[2].klass;
		    v251 = HIDWORD(v270[2].klass);
		    sub_18033B9D0(&v281, 0LL, 96LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v281, v250, v251, 0LL);
		    v252 = *(_OWORD *)&v281.width;
		    v273 = *(_OWORD *)&v281.width;
		    v274 = *(_OWORD *)&v281.colorFormat;
		    v275 = *(_OWORD *)&v281.enableRandomWrite;
		    *(_QWORD *)&v276 = *(_QWORD *)&v281.bindTextureMS;
		    v253 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		    v277 = *(_OWORD *)&v281.fastMemoryDesc.inFastMemory;
		    v254 = v281.clearColor;
		    v278 = v281.clearColor;
		    *((_QWORD *)&v276 + 1) = "Screen Space Reflection Color Resolve Texture";
		    if ( dword_18F35FD08 )
		    {
		      v255 = ((((unsigned __int64)&v276 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v255 + 36190]);
		      do
		        v256 = qword_18F0BCBA0[v255 + 36190];
		      while ( v256 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v255 + 36190],
		                        v256 | (1LL << ((((unsigned __int64)&v276 + 8) >> 12) & 0x3F)),
		                        v256) );
		      v254 = v278;
		      v253 = v277;
		      v252 = v273;
		    }
		    LODWORD(v274) = 74;
		    LOBYTE(v275) = 1;
		    *(_OWORD *)&v298.width = v252;
		    *(_OWORD *)&v298.colorFormat = v274;
		    *(_OWORD *)&v298.enableRandomWrite = v275;
		    *(_OWORD *)&v298.bindTextureMS = v276;
		    *(_OWORD *)&v298.fastMemoryDesc.inFastMemory = v253;
		    v298.clearColor = v254;
		    v257 = v270;
		    v271 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		              (TextureHandle *)&v272,
		              renderGraph,
		              &v298,
		              0LL);
		    v260 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		              (TextureHandle *)&v272,
		              &v279,
		              &v271,
		              0LL);
		    if ( !v257 )
		      sub_1800D8250(v259, v258);
		    *(TextureHandle *)&v257[34].monitor = v260;
		    if ( !v270 )
		      sub_1800D8250(v259, v258);
		    if ( BYTE1(v270[1].klass) )
		      v261 = *(TextureHandle *)&v270[23].monitor;
		    else
		      v261 = *(TextureHandle *)&v270[34].monitor;
		    this->fields.m_ssrLightingTexture = v261;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v279,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass->static_fields->s_RenderFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
		    sub_180268AE0(&v280);
		    if ( hgCamera->fields.prevTransformReset )
		      this->fields.m_ssrFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                             (TextureHandle *)&v280,
		                                             renderGraph,
		                                             this->fields.m_defaultTexutre,
		                                             0LL);
		    this->fields.m_prevFrameWasReset = hgCamera->fields.prevTransformReset;
		  }
		  else
		  {
		    this->fields.m_shouldRender = 0;
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    this->fields.m_ssrLightingTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                           (TextureHandle *)&v280,
		                                           renderGraph,
		                                           this->fields.m_defaultTexutre,
		                                           0LL);
		    this->fields.m_ssrFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                           (TextureHandle *)&v280,
		                                           renderGraph,
		                                           this->fields.m_defaultTexutre,
		                                           0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_currentFadenessTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                               (TextureHandle *)&v280,
		                                               0LL);
		    this->fields.m_currentTemporalColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                    (TextureHandle *)&v280,
		                                                    0LL);
		  }
		}
		
		public bool ShouldRenderTBuffer(HGCamera hgCamera) => default; // 0x0000000189BCCF04-0x0000000189BCCF68
		// Boolean ShouldRenderTBuffer(HGCamera)
		bool HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRenderTBuffer(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3325, 0LL) )
		  {
		    if ( hgCamera )
		      return HG::Rendering::Runtime::HGCamera::get_ssrEnable(hgCamera, 0LL);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3325, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)hgCamera,
		           0LL);
		}
		
		internal void RenderTBuffer(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BCA850-0x0000000189BCABE0
		// Void RenderTBuffer(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HyperScreenSpaceReflectionRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::RenderTBuffer(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HyperScreenSpaceReflectionRenderingPass_PassInput *input,
		        HyperScreenSpaceReflectionRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  bool v10; // zf
		  TextureHandle normalRoughnessTextureCopy; // xmm0
		  TextureHandle currentSceneDepthTexture; // xmm0
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  __int64 forwardReflectionECSList; // rcx
		  Object *v18; // rdi
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  TextureHandle v21; // xmm0
		  Object *v22; // rdi
		  __int64 v23; // rdx
		  TextureHandle v24; // xmm0
		  Object *v25; // rdx
		  unsigned int v26; // edx
		  unsigned __int64 v27; // r8
		  char v28; // dl
		  signed __int64 v29; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  Object *v33; // [rsp+50h] [rbp-B8h] BYREF
		  __m128i si128; // [rsp+60h] [rbp-A8h] BYREF
		  _QWORD v35[2]; // [rsp+70h] [rbp-98h] BYREF
		  HGRenderGraphBuilder v36; // [rsp+80h] [rbp-88h] BYREF
		  HGRenderGraphBuilder v37; // [rsp+A0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v38; // [rsp+C0h] [rbp-48h] BYREF
		  TextureHandle v39; // [rsp+D0h] [rbp-38h] BYREF
		  TextureHandle v40; // [rsp+E0h] [rbp-28h] BYREF
		
		  v33 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3326, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3326, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v32, v31);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1222(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    v10 = !input->needCopyGBufferAndDepth;
		    if ( input->needCopyGBufferAndDepth )
		      normalRoughnessTextureCopy = input->normalRoughnessTextureCopy;
		    else
		      normalRoughnessTextureCopy = input->normalRoughnessTexture;
		    v39 = normalRoughnessTextureCopy;
		    if ( v10 )
		      currentSceneDepthTexture = input->currentSceneDepthTexture;
		    else
		      currentSceneDepthTexture = input->currentSceneDepthTextureCopy;
		    v40 = currentSceneDepthTexture;
		    v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x5Fu,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v37,
		      renderGraph,
		      (String *)"Screen Space Reflection",
		      &v33,
		      v13,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>);
		    v36 = v37;
		    v35[0] = 0LL;
		    v35[1] = &v36;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v36, 0, 0LL);
		      forwardReflectionECSList = input->forwardReflectionECSList;
		      if ( !v33 )
		        sub_1800D8250(forwardReflectionECSList, v16);
		      HIDWORD(v33[1].klass) = forwardReflectionECSList;
		      LOBYTE(forwardReflectionECSList) = input->needCopyGBufferAndDepth;
		      if ( !v33 )
		        sub_1800D8250(forwardReflectionECSList, v16);
		      LOBYTE(v33[1].klass) = forwardReflectionECSList;
		      if ( input->needCopyGBufferAndDepth )
		      {
		        v18 = v33;
		        v21 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&si128,
		                 &v36,
		                 &input->normalRoughnessTexture,
		                 0LL);
		        if ( !v18 )
		          sub_1800D8250(v20, v19);
		        *(TextureHandle *)&v18[1].monitor = v21;
		        v22 = v33;
		        v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&si128,
		                 &v36,
		                 &input->currentSceneDepthTexture,
		                 0LL);
		        if ( !v22 )
		          sub_1800D8250(forwardReflectionECSList, v23);
		        *(TextureHandle *)&v22[2].monitor = v24;
		      }
		      v25 = v33;
		      if ( !v33 )
		        sub_1800D8250(forwardReflectionECSList, 0LL);
		      v33[3].monitor = (MonitorData *)this->fields.m_transparentMBP;
		      if ( dword_18F35FD08 )
		      {
		        v26 = ((unsigned __int64)&v25[3].monitor >> 12) & 0x1FFFFF;
		        v27 = (unsigned __int64)v26 >> 6;
		        v28 = v26 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v27]);
		        do
		          v29 = qword_18F103690[v27];
		        while ( v29 != _InterlockedCompareExchange64(&qword_18F103690[v27], v29 | (1LL << v28), v29) );
		      }
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v37,
		        &v36,
		        &v39,
		        0,
		        RenderBufferLoadAction__Enum_Load,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        (TextureHandle *)&v37,
		        &v36,
		        &v40,
		        DepthAccess__Enum_Write,
		        RenderBufferLoadAction__Enum_Load,
		        RenderBufferStoreAction__Enum_Store,
		        1.0,
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v36,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass->static_fields->s_RenderTransparentFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v38 )
		    {
		      v35[0] = v38->ex;
		    }
		    sub_180268AE0(v35);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BCA2C0-0x0000000189BCA314
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3327, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3327, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCA26C-0x0000000189BCA2C0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3328, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3328, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCA014-0x0000000189BCA26C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  bool v6; // si
		  TextureHandle *nullHandle; // rax
		  HGRenderGraph *renderGraph; // rdx
		  TextureHandle *v9; // rax
		  TextureHandle *v10; // rax
		  int32_t v11; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3329, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3329, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		      return;
		    }
		    goto LABEL_21;
		  }
		  if ( input->passSkipped )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_currentFadenessTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v13, 0LL);
		    this->fields.m_currentTemporalColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                    &v13,
		                                                    0LL);
		    this->fields.m_currentDeferredTemporalColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                            &v13,
		                                                            0LL);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  v6 = 1;
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currentFadenessTexture, 0LL) )
		  {
		    renderGraph = input->renderGraph;
		    if ( !renderGraph )
		      goto LABEL_21;
		    nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                   &v13,
		                   renderGraph,
		                   &this->fields.m_currentFadenessTexture,
		                   1,
		                   (String *)"SSRPass",
		                   0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v13, 0LL);
		  }
		  this->fields.m_previousFadenessTexture = *nullHandle;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currentTemporalColorTexture, 0LL) )
		  {
		    renderGraph = input->renderGraph;
		    if ( !renderGraph )
		      goto LABEL_21;
		    v9 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		           &v13,
		           renderGraph,
		           &this->fields.m_currentTemporalColorTexture,
		           1,
		           (String *)"SSRPass",
		           0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v9 = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v13, 0LL);
		  }
		  this->fields.m_previousTemporalColorTexture = *v9;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
		         &this->fields.m_currentDeferredTemporalColorTexture,
		         0LL) )
		  {
		    renderGraph = input->renderGraph;
		    if ( renderGraph )
		    {
		      v10 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		              &v13,
		              renderGraph,
		              &this->fields.m_currentDeferredTemporalColorTexture,
		              1,
		              (String *)"SSRPass",
		              0LL);
		      goto LABEL_16;
		    }
		LABEL_21:
		    sub_1800D8260(v5, renderGraph);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  v10 = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v13, 0LL);
		LABEL_16:
		  this->fields.m_previousDeferredTemporalColorTexture = *v10;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currentTemporalColorTexture, 0LL) )
		  {
		    v11 = (this->fields.m_frameIndex + 1) % 64;
		    v6 = 0;
		  }
		  else
		  {
		    v11 = 0;
		  }
		  this->fields.m_firstFrame = v6;
		  this->fields.m_frameIndex = v11;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_deferredFirstFrame = !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
		                                         &this->fields.m_currentDeferredTemporalColorTexture,
		                                         0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D801A0-0x0000000184D801D0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        HyperScreenSpaceReflectionRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3330, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3330, 0LL);
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
