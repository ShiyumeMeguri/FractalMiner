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
	public class WaterDefaultDeferredRenderingPass : IPassConstructor // TypeDefIndex: 38502
	{
		// Fields
		private bool m_isRendering; // 0x10
		private const int INDIRECT_NUM = 6; // Metadata: 0x02303D6D
		private const int WATER_DISPLACEMENT_TEXTURE_SIZE = 512; // Metadata: 0x02303D6E
		private bool m_isFirstTime; // 0x11
		private uint m_frameIndex; // 0x14
		private ComputeBuffer m_indirectBuffer; // 0x18
		private const int INDIRECT_ARGS_NUM_V2 = 8; // Metadata: 0x02303D70
		private const int INDIRECT_NUM_V2 = 32; // Metadata: 0x02303D71
		private bool m_isFirstTimeV2; // 0x20
		private uint m_frameIndexV2; // 0x24
		private ComputeBuffer m_indirectBufferV2; // 0x28
		private CBHandle m_cbHandle; // 0x30
		private Texture3D m_wetnessMask3DNoise; // 0x48
		private Material m_waterProxyMaterial; // 0x50
		private Material m_waterTextureProcessMaterial; // 0x58
		private Material m_renderingMaterial; // 0x60
		private MaterialPropertyBlock m_waterProxyMPB; // 0x68
		private MaterialPropertyBlock m_waterProxyDisplacementMPB; // 0x70
		private MaterialPropertyBlock m_waterDecalDeferredMPB; // 0x78
		private MaterialPropertyBlock m_waterTesellationMPB; // 0x80
		private MaterialPropertyBlock m_waterLightingMPB; // 0x88
		private Material m_waterProxyMaterial_V2; // 0x90
		private Material m_waterTextureProcessMaterial_V2; // 0x98
		private Material m_waterTessellationMaterial; // 0xA0
		private MaterialPropertyBlock m_waterCopyMPB; // 0xA8
		private MaterialPropertyBlock m_waterProxyMPB_V2; // 0xB0
		private MaterialPropertyBlock m_waterHeightDecalMPB; // 0xB8
		private MaterialPropertyBlock m_waterTessellationMPB; // 0xC0
		private ComputeShader m_waterOcclusionCS; // 0xC8
		private TextureHandle m_normalRoughnessWithWaterTexture; // 0xD0
		private TextureHandle m_depthWithWaterTexture; // 0xE0
		private TextureHandle m_waterTessellationDataTexture; // 0xF0
		private TextureHandle m_waterWetnessMaskTexture; // 0x100
		private uint m_decalFeedbackID; // 0x110
		private uint m_objFeedbackID; // 0x114
		private static readonly RenderFunc<PassData> s_RenderFallbackFunc; // 0x00
		private static readonly RenderFunc<PassData> s_waterProxyRenderFunc; // 0x08
		private static readonly RenderFunc<PassData> s_waterWetnessMaskRenderFunc; // 0x10
		private static readonly RenderFunc<PassData> s_waterCopyRenderFunc; // 0x18
		private static readonly RenderFunc<PassData> s_waterHeightRenderFunc; // 0x20
		private static readonly RenderFunc<PassData> s_waterDecalRenderFunc; // 0x28
		private static readonly RenderFunc<PassData> s_waterOcclustionRenderFuncV2; // 0x30
		private static readonly RenderFunc<PassData> s_waterTessellationRenderFuncV2; // 0x38
		private static readonly RenderFunc<PassData> s_waterGBufferRenderFuncV2; // 0x40
		private static readonly RenderFunc<PassData> s_waterLightingRenderFunc; // 0x48
	
		// Properties
		public bool isRendering { get => default; } // 0x0000000189BEADE0-0x0000000189BEAE2C 
		// Boolean get_isRendering()
		bool HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_isRendering(
		        WaterDefaultDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3504, 0LL) )
		    return this->fields.m_isRendering;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3504, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public TextureHandle normalRoughnessWithWaterTexture { get => default; } // 0x0000000189BEAE2C-0x0000000189BEAE94 
		// TextureHandle get_normalRoughnessWithWaterTexture()
		TextureHandle *HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_normalRoughnessWithWaterTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterDefaultDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_normalRoughnessWithWaterTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3505, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3505, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_normalRoughnessWithWaterTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(
		                                           &v10,
		                                           Patch,
		                                           (Object *)this,
		                                           0LL);
		  }
		  else
		  {
		    m_normalRoughnessWithWaterTexture = this->fields.m_normalRoughnessWithWaterTexture;
		  }
		  result = retstr;
		  *retstr = m_normalRoughnessWithWaterTexture;
		  return result;
		}
		
		public TextureHandle depthWithWaterTexture { get => default; } // 0x0000000189BEAD78-0x0000000189BEADE0 
		// TextureHandle get_depthWithWaterTexture()
		TextureHandle *HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_depthWithWaterTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterDefaultDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_depthWithWaterTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3506, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3506, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_depthWithWaterTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_depthWithWaterTexture = this->fields.m_depthWithWaterTexture;
		  }
		  result = retstr;
		  *retstr = m_depthWithWaterTexture;
		  return result;
		}
		
		public TextureHandle waterWetnessMaskTexture { get => default; } // 0x0000000189BEAE94-0x0000000189BEAEFC 
		// TextureHandle get_waterWetnessMaskTexture()
		TextureHandle *HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_waterWetnessMaskTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterDefaultDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_waterWetnessMaskTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3507, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3507, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_waterWetnessMaskTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_waterWetnessMaskTexture = this->fields.m_waterWetnessMaskTexture;
		  }
		  result = retstr;
		  *retstr = m_waterWetnessMaskTexture;
		  return result;
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38496
		{
			// Fields
			internal bool enableIndirect; // 0x00
			internal GraphicsFormat depthFormat; // 0x04
			internal DepthBits depthBits; // 0x08
			internal TextureHandle sectorTexture; // 0x0C
			internal TextureHandle interactionTexture; // 0x1C
			internal TextureHandle sceneColor; // 0x2C
			internal TextureHandle sceneColorCopied; // 0x3C
			internal TextureHandle sceneDepth; // 0x4C
			internal TextureHandle sceneDepthCopied; // 0x5C
			internal TextureHandle sceneMV; // 0x6C
			internal TextureHandle deferredSSRLightingTexture; // 0x7C
			internal TextureHandle ssrFadenessTexture; // 0x8C
			internal ScriptableRenderContext srpContext; // 0xA0
			internal GBufferOutput gBufferOutput; // 0xA8
			internal HGSettingParameters settingParameters; // 0xC8
		}
	
		internal struct PassOutput // TypeDefIndex: 38497
		{
			// Fields
			internal TextureHandle gbufferBWithWaterTexture; // 0x00
			internal TextureHandle depthWithWaterTexture; // 0x10
		}
	
		private struct WaterOcclusionData // TypeDefIndex: 38498
		{
			// Fields
			public Vector4 param0; // 0x00
			public Vector4 param1; // 0x10
			public Vector4 param2; // 0x20
			public Vector4 param3; // 0x30
		}
	
		private struct WaterEdgeDampenData // TypeDefIndex: 38499
		{
			// Fields
			public Vector4 param0; // 0x00
			public Vector4 param1; // 0x10
		}
	
		private class PassData // TypeDefIndex: 38500
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public uint cullHandle; // 0x18
			public uint waterHeightVisibleCount; // 0x1C
			public uint waterHeightCullingHandle; // 0x20
			public int heightLayer; // 0x24
			public int lastHeightLayer; // 0x28
			public int waterOcclusionGroupXYNum; // 0x2C
			public int waterOcclusionGroupZNum; // 0x30
			public Mesh waterScreenSpaceMesh; // 0x38
			public Material waterProxyMaterial; // 0x40
			public Material waterTextureProcessMaterial; // 0x48
			public Material waterRenderingMaterial; // 0x50
			public MaterialPropertyBlock waterProxyMPB; // 0x58
			public MaterialPropertyBlock waterDecalMPB; // 0x60
			public MaterialPropertyBlock waterTesellationMPB; // 0x68
			public MaterialPropertyBlock waterLightingMPB; // 0x70
			public Material waterTessellationMaterial; // 0x78
			public MaterialPropertyBlock waterCopyMPB; // 0x80
			public MaterialPropertyBlock waterHeightDecalMPB; // 0x88
			public MaterialPropertyBlock waterTessellationMPB; // 0x90
			public Texture2D globalFlowmapTexture; // 0x98
			public Texture2D globalCausticTexture; // 0xA0
			public Texture2D globalRainTexture; // 0xA8
			public Texture3D wetnessMask3DNoise; // 0xB0
			public Texture2DArray globalNormalTextureArray; // 0xB8
			public CBHandle cbHandle; // 0xC0
			public TextureHandle waterLocalFlowmapTexture; // 0xD8
			public TextureHandle waterInteractionTexture; // 0xE8
			public TextureHandle waterProxyDataTexture; // 0xF8
			public TextureHandle waterProxyNormalTexture; // 0x108
			public TextureHandle waterProxyDepthTexture; // 0x118
			public TextureHandle waterWetnessMaskTexture; // 0x128
			public TextureHandle gbufferATexture; // 0x138
			public TextureHandle gbufferBTexture; // 0x148
			public TextureHandle waterDecalDataTexture; // 0x158
			public TextureHandle waterDecalNormalTexture; // 0x168
			public TextureHandle waterDecalDisplacementTexture; // 0x178
			public TextureHandle waterDecalSmoothDisplacementTexture; // 0x188
			public TextureHandle waterDecalDepthTexture; // 0x198
			public bool firstTime; // 0x1A8
			public bool enableIndirect; // 0x1A9
			public uint useOffset; // 0x1AC
			public uint clearOffset; // 0x1B0
			public CBHandle occlusionCB; // 0x1B8
			public ComputeBufferHandle tileBuffer; // 0x1D0
			public ComputeBufferHandle indirectBuffer; // 0x1D8
			public Vector2Int waterProxyTextureSize; // 0x1E0
			public ComputeShader waterOcclusionCS; // 0x1E8
			public TextureHandle waterPrepassDataTexture; // 0x1F0
			public TextureHandle waterPrepassNormalTexture; // 0x200
			public TextureHandle waterPrepassDisplacementTexture; // 0x210
			public TextureHandle waterPrepassDepthTexture; // 0x220
			public TextureHandle normalRoughnessTexture; // 0x230
			public TextureHandle sceneDepthTexture; // 0x240
			public TextureHandle sceneDepthTextureCopy; // 0x250
			public TextureHandle sceneDepthWithWaterTextureCopy; // 0x260
			public TextureHandle reflectionLightingTexture; // 0x270
			public TextureHandle reflectionFadenessTexture; // 0x280
			public TextureHandle waterTessellationDataTexture; // 0x290
			public uint wetnessDecalECSList; // 0x2A0
			public uint wetnessObjECSList; // 0x2A4
			public bool renderWetnessDecal; // 0x2A8
			public bool renderWetnessObj; // 0x2A9
			public bool renderWaterProxy; // 0x2AA
			public int waterLODInstanceCount; // 0x2AC
	
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
	
		// Constructors
		public WaterDefaultDeferredRenderingPass() {} // Dummy constructor
		internal WaterDefaultDeferredRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000183523E80-0x00000001835242B0
		static WaterDefaultDeferredRenderingPass() {} // 0x0000000184844000-0x0000000184844430
	
		// Methods
		private void UpdateWaterQualityKeywords() {} // 0x0000000189BEAB7C-0x0000000189BEAD78
		// Void UpdateWaterQualityKeywords()
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::UpdateWaterQualityKeywords(
		        WaterDefaultDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  bool ShouldUseWaterQualityLow; // al
		  __int64 v4; // rdx
		  Material *m_renderingMaterial; // rsi
		  bool v6; // di
		  Material *v7; // rcx
		  Shader *shader; // rax
		  Material *m_waterTessellationMaterial; // rsi
		  Shader *v10; // rax
		  Material *m_waterTextureProcessMaterial; // rsi
		  Shader *v12; // rax
		  Material *m_waterTextureProcessMaterial_V2; // rsi
		  Shader *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  LocalKeyword keyword; // [rsp+28h] [rbp-29h] BYREF
		  LocalKeyword v19; // [rsp+40h] [rbp-11h] BYREF
		  LocalKeyword v20; // [rsp+58h] [rbp+7h] BYREF
		  LocalKeyword v21; // [rsp+70h] [rbp+1Fh] BYREF
		  LocalKeyword v22; // [rsp+88h] [rbp+37h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3508, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3508, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    ShouldUseWaterQualityLow = HG::Rendering::Runtime::WaterQualityHelper::ShouldUseWaterQualityLow(0LL);
		    m_renderingMaterial = this->fields.m_renderingMaterial;
		    v6 = ShouldUseWaterQualityLow;
		    v7 = m_renderingMaterial;
		    if ( !m_renderingMaterial )
		      goto LABEL_7;
		    shader = UnityEngine::Material::get_shader(m_renderingMaterial, 0LL);
		    memset(&v19, 0, sizeof(v19));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v19, shader, (String *)"HG_WATER_DESKTOP_QUALITY_LOW", 0LL);
		    keyword = v19;
		    UnityEngine::Material::SetKeyword(m_renderingMaterial, &keyword, v6, 0LL);
		    m_waterTessellationMaterial = this->fields.m_waterTessellationMaterial;
		    v7 = m_waterTessellationMaterial;
		    if ( !m_waterTessellationMaterial )
		      goto LABEL_7;
		    v10 = UnityEngine::Material::get_shader(m_waterTessellationMaterial, 0LL);
		    memset(&v20, 0, sizeof(v20));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v20, v10, (String *)"HG_WATER_DESKTOP_QUALITY_LOW", 0LL);
		    keyword = v20;
		    UnityEngine::Material::SetKeyword(m_waterTessellationMaterial, &keyword, v6, 0LL);
		    m_waterTextureProcessMaterial = this->fields.m_waterTextureProcessMaterial;
		    v7 = m_waterTextureProcessMaterial;
		    if ( !m_waterTextureProcessMaterial
		      || (v12 = UnityEngine::Material::get_shader(m_waterTextureProcessMaterial, 0LL),
		          memset(&v21, 0, sizeof(v21)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v21, v12, (String *)"HG_WATER_DESKTOP_QUALITY_LOW", 0LL),
		          keyword = v21,
		          UnityEngine::Material::SetKeyword(m_waterTextureProcessMaterial, &keyword, v6, 0LL),
		          m_waterTextureProcessMaterial_V2 = this->fields.m_waterTextureProcessMaterial_V2,
		          (v7 = m_waterTextureProcessMaterial_V2) == 0LL) )
		    {
		LABEL_7:
		      sub_1800D8260(v7, v4);
		    }
		    v14 = UnityEngine::Material::get_shader(m_waterTextureProcessMaterial_V2, 0LL);
		    memset(&v22, 0, sizeof(v22));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v22, v14, (String *)"HG_WATER_DESKTOP_QUALITY_LOW", 0LL);
		    keyword = v22;
		    UnityEngine::Material::SetKeyword(m_waterTextureProcessMaterial_V2, &keyword, v6, 0LL);
		  }
		}
		
		internal void RenderPrepassV2(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, bool wetnessHighQualityEnabled = false /* Metadata: 0x02303D6C */) {} // 0x0000000189BE6C94-0x0000000189BEA2A0
		// Void RenderPrepassV2(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, Boolean)
		// Hidden C++ exception states: #wind=8 #try_helpers=2
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderPrepassV2(
		        WaterDefaultDeferredRenderingPass *this,
		        WaterDefaultDeferredRenderingPass_PassInput *input,
		        WaterDefaultDeferredRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        bool wetnessHighQualityEnabled,
		        MethodInfo *method)
		{
		  Object *v7; // r15
		  WaterDefaultDeferredRenderingPass *v10; // rsi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Object__Class *v13; // r13
		  ProfilingSampler *v14; // rax
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  HGWaterManager *waterManager_k__BackingField; // rdi
		  HGManagerContext *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  HGWaterManager *v22; // rcx
		  Matrix4x4__StaticFields *static_fields; // rax
		  __int128 v24; // xmm1
		  __int128 v25; // xmm2
		  __int128 v26; // xmm3
		  Matrix4x4__StaticFields *v27; // rax
		  __int128 v28; // xmm1
		  __int128 v29; // xmm2
		  __int128 v30; // xmm3
		  Matrix4x4__StaticFields *v31; // rax
		  __int128 v32; // xmm1
		  __int128 v33; // xmm2
		  __int128 v34; // xmm3
		  CBHandle *v35; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  void *ptr; // xmm0_8
		  __int64 v39; // rdx
		  HGSettingParameters *settingParameters; // rcx
		  __int64 v41; // rdx
		  Int32Enum__Enum v42; // edi
		  HGSettingParameters *v43; // rcx
		  Int32Enum__Enum v44; // r12d
		  unsigned __int64 v45; // rdx
		  signed __int64 v46; // rcx
		  __int128 v47; // xmm2
		  __int128 v48; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  ProfilingSampler *v52; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  TextureHandle v55; // xmm0
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  TextureHandle v58; // xmm0
		  Object *v59; // rdx
		  int v60; // eax
		  unsigned __int64 v61; // rdx
		  unsigned __int64 v62; // r8
		  char v63; // dl
		  signed __int64 v64; // rtt
		  Object *v65; // rdx
		  MonitorData *m_waterTextureProcessMaterial; // rcx
		  unsigned __int64 v67; // rdx
		  unsigned __int64 v68; // r8
		  char v69; // dl
		  signed __int64 v70; // rtt
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  HGWaterGlobalConfig *m_KeywordSpace; // rax
		  ProfilingSampler *v74; // rax
		  signed __int64 v75; // rcx
		  Object *v76; // rdx
		  unsigned __int64 v77; // rdx
		  unsigned __int64 v78; // r8
		  signed __int64 v79; // rtt
		  Object__Class *v80; // xmm1_8
		  Object *v81; // rax
		  Object *v82; // r15
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  TextureHandle v85; // xmm0
		  Object *v86; // r15
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  TextureHandle v89; // xmm0
		  Object *v90; // r15
		  HGWaterGlobalConfig *v91; // r13
		  Texture2D *v92; // rax
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  unsigned __int64 v95; // r8
		  signed __int64 v96; // rtt
		  Object *v97; // r15
		  Texture2D *v98; // rax
		  __int64 v99; // rdx
		  __int64 v100; // rcx
		  unsigned __int64 v101; // r9
		  signed __int64 v102; // rtt
		  Object *v103; // r15
		  Texture2DArray *v104; // rax
		  __int64 v105; // rdx
		  __int64 v106; // rcx
		  int v107; // eax
		  unsigned __int64 v108; // r8
		  signed __int64 v109; // rtt
		  Object *v110; // rdx
		  Object__Class *v111; // rcx
		  unsigned __int64 v112; // rdx
		  unsigned __int64 v113; // r8
		  char v114; // dl
		  signed __int64 v115; // rtt
		  Object *v116; // rdx
		  MonitorData *v117; // rcx
		  unsigned __int64 v118; // rdx
		  unsigned __int64 v119; // r8
		  signed __int64 v120; // rtt
		  Material *v121; // rcx
		  Shader *v122; // rax
		  __int64 v123; // rdx
		  Material *v124; // rcx
		  __int64 v125; // rdx
		  Material *v126; // rcx
		  Shader *v127; // rax
		  Material *v128; // rdi
		  bool v129; // al
		  __int64 v130; // rdx
		  __int64 v131; // rcx
		  ComputeBuffer *v132; // rax
		  __int64 v133; // rdx
		  __int64 v134; // rcx
		  ComputeBuffer *v135; // r13
		  unsigned __int64 v136; // r8
		  signed __int64 v137; // rtt
		  int32_t i; // r13d
		  int32_t v139; // r13d
		  ProfilingSampler *v140; // rax
		  ProfilingSampler *v141; // rax
		  __int64 v142; // rdx
		  Object *v143; // rcx
		  Object *v144; // rdx
		  Object__Class *v145; // r13
		  int v146; // eax
		  unsigned __int64 v147; // rdx
		  unsigned __int64 v148; // r8
		  char v149; // dl
		  signed __int64 v150; // rtt
		  Object *v151; // rdx
		  Object__Class *m_waterProxyMaterial_V2; // rcx
		  unsigned __int64 v153; // rdx
		  unsigned __int64 v154; // r8
		  char v155; // dl
		  signed __int64 v156; // rtt
		  Object *v157; // rdx
		  MonitorData *m_waterProxyMPB_V2; // rcx
		  unsigned __int64 v159; // rdx
		  unsigned __int64 v160; // r8
		  signed __int64 v161; // rtt
		  MonitorData *monitor; // rcx
		  __int64 v163; // rdx
		  __int64 v164; // rcx
		  MonitorData *v165; // rcx
		  ProfilingSampler *v166; // rax
		  __int64 v167; // rdx
		  __int64 v168; // rcx
		  ProfilingSampler *v169; // xmm1_8
		  HGRenderGraphPass *v170; // rax
		  HGRenderGraphPass *v171; // rdx
		  unsigned __int64 v172; // rdx
		  unsigned __int64 v173; // r8
		  signed __int64 v174; // rtt
		  __int64 v175; // rdx
		  __int64 v176; // rcx
		  Color v177; // xmm0
		  __int64 v178; // rdx
		  __int64 v179; // rcx
		  TextureHandle v180; // xmm0
		  __int64 v181; // rdx
		  __int64 v182; // rcx
		  TextureHandle v183; // xmm0
		  __int64 v184; // rdx
		  __int64 v185; // rcx
		  TextureHandle v186; // xmm0
		  __int64 v187; // rdx
		  __int64 v188; // rcx
		  TextureHandle v189; // xmm0
		  __int64 v190; // rdx
		  Texture2D *flowMap; // rcx
		  HGRenderGraphPass *m_RenderPass; // rax
		  unsigned __int64 v193; // r8
		  signed __int64 v194; // rtt
		  MonitorData *normalMapArray; // rax
		  __int64 v196; // rdx
		  HGRenderGraphPass *v197; // rcx
		  int v198; // eax
		  unsigned __int64 v199; // r8
		  signed __int64 v200; // rtt
		  HGRenderGraphPass *v201; // rdx
		  MonitorData *m_waterTextureProcessMaterial_V2; // rcx
		  unsigned __int64 v203; // rdx
		  unsigned __int64 v204; // r8
		  char v205; // dl
		  signed __int64 v206; // rtt
		  HGRenderGraphPass *v207; // rdx
		  MonitorData *m_waterHeightDecalMPB; // rcx
		  unsigned __int64 v209; // rdx
		  unsigned __int64 v210; // r8
		  char v211; // dl
		  signed __int64 v212; // rtt
		  ProfilingSampler *v213; // rax
		  Mesh *screenSpaceMesh; // rax
		  __int64 v215; // rdx
		  __int64 v216; // rcx
		  Mesh *v217; // rax
		  __int64 v218; // rdx
		  __int64 v219; // rcx
		  signed int BaseVertex; // eax
		  float m_RenderPass_low; // xmm1_4
		  float v222; // xmm1_4
		  unsigned int v223; // xmm4_4
		  unsigned int v224; // xmm0_4
		  CBHandle *ConstantBuffer; // rax
		  __int128 v226; // xmm7
		  Void *v227; // xmm6_8
		  signed __int64 v228; // rcx
		  HGRenderGraphPass *v229; // rdx
		  unsigned __int64 v230; // rdx
		  unsigned __int64 v231; // r8
		  signed __int64 v232; // rtt
		  __int64 v233; // rcx
		  __int64 v234; // rcx
		  ProfilingSampler *v235; // xmm1_8
		  HGRenderGraphPass *v236; // rax
		  HGRenderGraphPass *v237; // rax
		  ComputeBufferHandle v238; // rax
		  ComputeBufferHandle v239; // rdx
		  ComputeBufferHandle v240; // rax
		  ComputeBufferHandle v241; // rdx
		  __int64 v242; // rdx
		  __int64 v243; // rcx
		  TextureHandle v244; // xmm0
		  __int64 v245; // rdx
		  __int64 v246; // rcx
		  TextureHandle v247; // xmm0
		  __int64 v248; // rdx
		  __int64 v249; // rcx
		  TextureHandle v250; // xmm0
		  HGRenderGraphPass *v251; // rdx
		  unsigned __int64 v252; // rdx
		  unsigned __int64 v253; // r8
		  char v254; // dl
		  signed __int64 v255; // rtt
		  ProfilingSampler *v256; // rax
		  signed __int64 v257; // rcx
		  Object *v258; // rdx
		  unsigned __int64 v259; // rdx
		  unsigned __int64 v260; // r8
		  signed __int64 v261; // rtt
		  Object__Class *v262; // xmm1_8
		  Object *v263; // rax
		  __int64 v264; // rcx
		  ComputeBufferHandle *v265; // r13
		  ComputeBufferHandle v266; // rax
		  ComputeBufferHandle v267; // rdx
		  ComputeBufferHandle v268; // rcx
		  ComputeBufferHandle *v269; // r15
		  ComputeBufferHandle v270; // rax
		  ComputeBufferHandle v271; // rdx
		  ComputeBufferHandle v272; // rcx
		  Object *v273; // r15
		  __int64 v274; // rdx
		  __int64 v275; // rcx
		  TextureHandle v276; // xmm0
		  Object *v277; // r15
		  __int64 v278; // rdx
		  __int64 v279; // rcx
		  TextureHandle v280; // xmm0
		  Object *v281; // r15
		  __int64 v282; // rdx
		  __int64 v283; // rcx
		  TextureHandle v284; // xmm0
		  Object *v285; // r15
		  __int64 v286; // rdx
		  __int64 v287; // rcx
		  TextureHandle v288; // xmm0
		  Object *v289; // r15
		  __int64 v290; // rdx
		  __int64 v291; // rcx
		  TextureHandle v292; // xmm0
		  Object *v293; // r15
		  __int64 v294; // rdx
		  __int64 v295; // rcx
		  TextureHandle v296; // xmm0
		  Object *v297; // r15
		  HGWaterGlobalConfig *v298; // r13
		  Texture2D *v299; // rax
		  __int64 v300; // rdx
		  __int64 v301; // rcx
		  unsigned __int64 v302; // r8
		  signed __int64 v303; // rtt
		  Object *v304; // r15
		  Texture2D *rainMap; // rax
		  __int64 v306; // rdx
		  __int64 v307; // rcx
		  unsigned __int64 v308; // r8
		  signed __int64 v309; // rtt
		  Object *v310; // r15
		  Texture2DArray *v311; // rax
		  __int64 v312; // rdx
		  __int64 v313; // rcx
		  unsigned __int64 v314; // r8
		  signed __int64 v315; // rtt
		  Object *v316; // r15
		  HGWaterManager *v317; // r13
		  Mesh *v318; // rax
		  __int64 v319; // rdx
		  __int64 v320; // rcx
		  int v321; // eax
		  unsigned __int64 v322; // r8
		  signed __int64 v323; // rtt
		  Object *v324; // rdx
		  Object__Class *m_waterTessellationMPB; // rcx
		  unsigned __int64 v326; // rdx
		  unsigned __int64 v327; // r8
		  char v328; // dl
		  signed __int64 v329; // rtt
		  Object *v330; // rdx
		  MonitorData *m_waterTessellationMaterial; // rcx
		  unsigned __int64 v332; // rdx
		  unsigned __int64 v333; // r8
		  signed __int64 v334; // rtt
		  Material *v335; // rcx
		  Shader *shader; // rax
		  __int64 v337; // rdx
		  Material *v338; // rcx
		  __int64 v339; // rdx
		  Material *v340; // rcx
		  Shader *v341; // rax
		  Material *v342; // rdi
		  bool ShouldRenderRippleState; // al
		  __int64 v344; // rdx
		  __int64 v345; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v347; // rdx
		  __int64 v348; // rcx
		  unsigned int width; // [rsp+50h] [rbp-C78h]
		  Object *v350; // [rsp+58h] [rbp-C70h] BYREF
		  HGRenderGraphBuilder inputa; // [rsp+60h] [rbp-C68h] BYREF
		  int32_t RealLODNum; // [rsp+80h] [rbp-C48h]
		  GraphicsFormat__Enum SupportedFormatForDepth; // [rsp+84h] [rbp-C44h]
		  int32_t height; // [rsp+88h] [rbp-C40h]
		  HGRenderGraphPass *v355; // [rsp+90h] [rbp-C38h] BYREF
		  HGRenderGraphPass *v356; // [rsp+98h] [rbp-C30h] BYREF
		  Vector3 viewPosition; // [rsp+A0h] [rbp-C28h] BYREF
		  DepthBits__Enum depthBits[2]; // [rsp+B0h] [rbp-C18h] BYREF
		  uint32_t cullHandle; // [rsp+B8h] [rbp-C10h] BYREF
		  Object *v360; // [rsp+C0h] [rbp-C08h] BYREF
		  Object *v361; // [rsp+C8h] [rbp-C00h] BYREF
		  LocalKeyword v362; // [rsp+D0h] [rbp-BF8h] BYREF
		  HGWaterManager *v363; // [rsp+F0h] [rbp-BD8h]
		  TextureHandle v364; // [rsp+F8h] [rbp-BD0h] BYREF
		  uint32_t visibleCount; // [rsp+108h] [rbp-BC0h] BYREF
		  TextureHandle v366; // [rsp+110h] [rbp-BB8h] BYREF
		  TextureDesc v367; // [rsp+120h] [rbp-BA8h] BYREF
		  int v368; // [rsp+180h] [rbp-B48h]
		  int v369; // [rsp+184h] [rbp-B44h]
		  Object *v370; // [rsp+188h] [rbp-B40h] BYREF
		  _QWORD v371[2]; // [rsp+190h] [rbp-B38h] BYREF
		  TextureHandle v372; // [rsp+1A0h] [rbp-B28h] BYREF
		  TextureHandle si128; // [rsp+1B0h] [rbp-B18h] BYREF
		  HGRenderGraphBuilder v374; // [rsp+1C0h] [rbp-B08h] BYREF
		  int v375; // [rsp+1E0h] [rbp-AE8h]
		  LocalKeyword keyword; // [rsp+1F0h] [rbp-AD8h] BYREF
		  HGRenderGraphBuilder v377; // [rsp+210h] [rbp-AB8h] BYREF
		  HGRenderGraphBuilder v378; // [rsp+230h] [rbp-A98h] BYREF
		  ScriptableRenderContext v379; // [rsp+250h] [rbp-A78h] BYREF
		  _QWORD v380[2]; // [rsp+258h] [rbp-A70h] BYREF
		  HGRenderGraphBuilder v381; // [rsp+268h] [rbp-A60h] BYREF
		  HGRenderGraphBuilder v382; // [rsp+288h] [rbp-A40h] BYREF
		  _QWORD v383[2]; // [rsp+2A8h] [rbp-A20h] BYREF
		  TextureHandle v384; // [rsp+2B8h] [rbp-A10h] BYREF
		  TextureHandle v385; // [rsp+2C8h] [rbp-A00h] BYREF
		  _QWORD v386[2]; // [rsp+2D8h] [rbp-9F0h] BYREF
		  _QWORD v387[2]; // [rsp+2E8h] [rbp-9E0h] BYREF
		  __int128 v388; // [rsp+2F8h] [rbp-9D0h]
		  HGRenderGraphBuilder v389; // [rsp+308h] [rbp-9C0h] BYREF
		  ComputeBufferDesc desc; // [rsp+328h] [rbp-9A0h] BYREF
		  TextureHandle sectorTexture; // [rsp+340h] [rbp-988h] BYREF
		  TextureHandle v392; // [rsp+350h] [rbp-978h] BYREF
		  TextureHandle interactionTexture; // [rsp+360h] [rbp-968h] BYREF
		  Matrix4x4 viewProj; // [rsp+370h] [rbp-958h] BYREF
		  LocalKeyword v395; // [rsp+3B0h] [rbp-918h] BYREF
		  LocalKeyword v396; // [rsp+3C8h] [rbp-900h] BYREF
		  LocalKeyword v397; // [rsp+3E0h] [rbp-8E8h] BYREF
		  LocalKeyword v398; // [rsp+3F8h] [rbp-8D0h] BYREF
		  HGRenderGraphProfilingScope v399; // [rsp+410h] [rbp-8B8h] BYREF
		  HGRenderGraphProfilingScope v400; // [rsp+428h] [rbp-8A0h] BYREF
		  Matrix4x4 orthoViewProj; // [rsp+440h] [rbp-888h] BYREF
		  Matrix4x4 orthoDeviceViewProj; // [rsp+480h] [rbp-848h] BYREF
		  Matrix4x4 orthoDeviceInvViewProj; // [rsp+4C0h] [rbp-808h] BYREF
		  Il2CppExceptionWrapper *v404; // [rsp+508h] [rbp-7C0h] BYREF
		  Il2CppExceptionWrapper *v405; // [rsp+518h] [rbp-7B0h] BYREF
		  Il2CppExceptionWrapper *v406; // [rsp+520h] [rbp-7A8h] BYREF
		  Il2CppExceptionWrapper *v407; // [rsp+528h] [rbp-7A0h] BYREF
		  Il2CppExceptionWrapper *v408; // [rsp+530h] [rbp-798h] BYREF
		  Il2CppExceptionWrapper *v409; // [rsp+538h] [rbp-790h] BYREF
		  _BYTE v410[16]; // [rsp+540h] [rbp-788h] BYREF
		  __int128 v411; // [rsp+550h] [rbp-778h]
		  Void v412[16]; // [rsp+580h] [rbp-748h] BYREF
		  __int128 v413; // [rsp+590h] [rbp-738h]
		  __int128 v414; // [rsp+5A0h] [rbp-728h]
		  __int128 v415; // [rsp+5B0h] [rbp-718h]
		  TextureDesc v416; // [rsp+5C0h] [rbp-708h] BYREF
		  TextureDesc v417; // [rsp+620h] [rbp-6A8h] BYREF
		  TextureDesc v418; // [rsp+680h] [rbp-648h] BYREF
		  TextureDesc v419; // [rsp+6E0h] [rbp-5E8h] BYREF
		  TextureDesc v420; // [rsp+740h] [rbp-588h] BYREF
		  TextureDesc v421; // [rsp+7A0h] [rbp-528h] BYREF
		  TextureDesc v422; // [rsp+800h] [rbp-4C8h] BYREF
		  TextureDesc v423; // [rsp+860h] [rbp-468h] BYREF
		  TextureDesc v424; // [rsp+8C0h] [rbp-408h] BYREF
		  TextureDesc v425; // [rsp+920h] [rbp-3A8h] BYREF
		  TextureDesc v426; // [rsp+980h] [rbp-348h] BYREF
		  TextureDesc v427; // [rsp+9E0h] [rbp-2E8h] BYREF
		  TextureHandle v428; // [rsp+A40h] [rbp-288h] BYREF
		  TextureHandle v429; // [rsp+A50h] [rbp-278h] BYREF
		  TextureHandle v430; // [rsp+A60h] [rbp-268h] BYREF
		  TextureHandle v431; // [rsp+A70h] [rbp-258h] BYREF
		  TextureHandle v432; // [rsp+A80h] [rbp-248h] BYREF
		  TextureHandle v433; // [rsp+A90h] [rbp-238h] BYREF
		  TextureHandle v434; // [rsp+AA0h] [rbp-228h] BYREF
		  TextureHandle v435; // [rsp+AB0h] [rbp-218h] BYREF
		  TextureHandle v436; // [rsp+AC0h] [rbp-208h] BYREF
		  TextureHandle v437; // [rsp+AD0h] [rbp-1F8h] BYREF
		  TextureHandle v438; // [rsp+AE0h] [rbp-1E8h] BYREF
		  TextureHandle v439; // [rsp+AF0h] [rbp-1D8h] BYREF
		  TextureHandle v440; // [rsp+B00h] [rbp-1C8h] BYREF
		  TextureHandle v441; // [rsp+B10h] [rbp-1B8h] BYREF
		  TextureHandle v442; // [rsp+B20h] [rbp-1A8h] BYREF
		  TextureHandle v443; // [rsp+B30h] [rbp-198h] BYREF
		  TextureHandle v444; // [rsp+B40h] [rbp-188h] BYREF
		  TextureHandle v445; // [rsp+B50h] [rbp-178h] BYREF
		  TextureHandle v446; // [rsp+B60h] [rbp-168h] BYREF
		  TextureHandle v447; // [rsp+B70h] [rbp-158h] BYREF
		  TextureHandle v448; // [rsp+B80h] [rbp-148h] BYREF
		  TextureHandle v449; // [rsp+B90h] [rbp-138h] BYREF
		  Void source[16]; // [rsp+BA0h] [rbp-128h] BYREF
		  __int128 v451; // [rsp+BB0h] [rbp-118h]
		  __int128 v452; // [rsp+BC0h] [rbp-108h]
		  __int128 v453; // [rsp+BD0h] [rbp-F8h]
		  Matrix4x4 v454; // [rsp+BE0h] [rbp-E8h]
		
		  v7 = (Object *)renderGraph;
		  v10 = this;
		  memset(&v399, 0, sizeof(v399));
		  v379.m_Ptr = 0LL;
		  sub_18033B9D0(&orthoViewProj, 0LL, 64LL);
		  sub_18033B9D0(&orthoDeviceViewProj, 0LL, 64LL);
		  sub_18033B9D0(&orthoDeviceInvViewProj, 0LL, 64LL);
		  visibleCount = 0;
		  cullHandle = 0;
		  sub_18033B9D0(&v417, 0LL, 96LL);
		  sub_18033B9D0(&v419, 0LL, 96LL);
		  depthBits[0] = DepthBits__Enum_None;
		  sub_18033B9D0(&v421, 0LL, 96LL);
		  sub_18033B9D0(&v423, 0LL, 96LL);
		  sub_18033B9D0(&v425, 0LL, 96LL);
		  sub_18033B9D0(&v367, 0LL, 96LL);
		  sub_18033B9D0(&v427, 0LL, 96LL);
		  memset(&v381, 0, sizeof(v381));
		  v370 = 0LL;
		  sub_18033B9D0(source, 0LL, 192LL);
		  memset(&v400, 0, sizeof(v400));
		  memset(&v389, 0, sizeof(v389));
		  v361 = 0LL;
		  memset(&v377, 0, sizeof(v377));
		  v355 = 0LL;
		  memset(&v382, 0, sizeof(v382));
		  v356 = 0LL;
		  sub_18033B9D0(v412, 0LL, 64LL);
		  sub_18033B9D0(v410, 0LL, 64LL);
		  memset(&v374, 0, sizeof(v374));
		  v350 = 0LL;
		  memset(&v396, 0, sizeof(v396));
		  memset(&v395, 0, sizeof(v395));
		  memset(&v378, 0, sizeof(v378));
		  v360 = 0LL;
		  memset(&v398, 0, sizeof(v398));
		  memset(&v397, 0, sizeof(v397));
		  if ( IFix::WrappersManagerImpl::IsPatched(3509, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3509, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v348, v347);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1257(
		      Patch,
		      (Object *)v10,
		      input,
		      output,
		      v7,
		      (Object *)hgCamera,
		      wetnessHighQualityEnabled,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::UpdateWaterQualityKeywords(v10, 0LL);
		    v13 = (Object__Class *)hgCamera;
		    if ( !hgCamera )
		      sub_1800D8260(v12, v11);
		    v10->fields.m_isRendering = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
		    if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL) )
		    {
		      v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x36u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		        &v399,
		        (HGRenderGraph *)v7,
		        v14,
		        0LL);
		      v380[0] = 0LL;
		      v380[1] = &v399;
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( !currentManagerContext )
		        sub_1800D8250(v17, v16);
		      waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		      v363 = waterManager_k__BackingField;
		      v19 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( !v19 )
		        sub_1800D8250(v21, v20);
		      v22 = v19->fields._waterManager_k__BackingField;
		      if ( !v22 )
		        sub_1800D8250(0LL, v20);
		      v362.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(v22, 0LL);
		      v371[0] = v362.m_SpaceInfo.m_KeywordSpace;
		      v379.m_Ptr = input->srpContext.m_Ptr;
		      static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v24 = *(_OWORD *)&static_fields->identityMatrix.m01;
		      v25 = *(_OWORD *)&static_fields->identityMatrix.m02;
		      v26 = *(_OWORD *)&static_fields->identityMatrix.m03;
		      *(_OWORD *)&orthoViewProj.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		      *(_OWORD *)&orthoViewProj.m01 = v24;
		      *(_OWORD *)&orthoViewProj.m02 = v25;
		      *(_OWORD *)&orthoViewProj.m03 = v26;
		      v27 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v28 = *(_OWORD *)&v27->identityMatrix.m01;
		      v29 = *(_OWORD *)&v27->identityMatrix.m02;
		      v30 = *(_OWORD *)&v27->identityMatrix.m03;
		      *(_OWORD *)&orthoDeviceViewProj.m00 = *(_OWORD *)&v27->identityMatrix.m00;
		      *(_OWORD *)&orthoDeviceViewProj.m01 = v28;
		      *(_OWORD *)&orthoDeviceViewProj.m02 = v29;
		      *(_OWORD *)&orthoDeviceViewProj.m03 = v30;
		      v31 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v32 = *(_OWORD *)&v31->identityMatrix.m01;
		      v33 = *(_OWORD *)&v31->identityMatrix.m02;
		      v34 = *(_OWORD *)&v31->identityMatrix.m03;
		      *(_OWORD *)&orthoDeviceInvViewProj.m00 = *(_OWORD *)&v31->identityMatrix.m00;
		      *(_OWORD *)&orthoDeviceInvViewProj.m01 = v32;
		      *(_OWORD *)&orthoDeviceInvViewProj.m02 = v33;
		      *(_OWORD *)&orthoDeviceInvViewProj.m03 = v34;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v35 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              (CBHandle *)&viewProj,
		              &v379,
		              20768,
		              0LL);
		      ptr = v35->ptr;
		      *(_OWORD *)&v10->fields.m_cbHandle.bufferId = *(_OWORD *)&v35->bufferId;
		      v10->fields.m_cbHandle.ptr = ptr;
		      if ( !waterManager_k__BackingField )
		        sub_1800D8250(v37, v36);
		      HG::Rendering::Runtime::HGWaterManager::SetWaterDataCB(
		        waterManager_k__BackingField,
		        hgCamera,
		        input->settingParameters,
		        &v10->fields.m_cbHandle,
		        &orthoViewProj,
		        &orthoDeviceViewProj,
		        &orthoDeviceInvViewProj,
		        0LL);
		      cullHandle = -1;
		      inputa.m_RenderPass = 0LL;
		      *(_QWORD *)&viewPosition.x = 0LL;
		      viewPosition.z = 0.0;
		      viewProj = orthoViewProj;
		      UnityEngine::HyperGryph::HGWaterRender::CullWaterProxy_Injected(
		        hgCamera->fields.cullingViewHandle,
		        &viewProj,
		        2u,
		        0,
		        &visibleCount,
		        &cullHandle,
		        0,
		        &viewPosition,
		        0LL);
		      settingParameters = input->settingParameters;
		      if ( !settingParameters )
		        sub_1800D8250(0LL, v39);
		      v42 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		              (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._waterHeightTextureSize_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      v43 = input->settingParameters;
		      if ( !v43 )
		        sub_1800D8250(0LL, v41);
		      v44 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		              (SettingParameter_1_System_Int32Enum_ *)v43->fields._waterHeightTextureSize_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      height = v44;
		      sectorTexture = input->sectorTexture;
		      interactionTexture = input->interactionTexture;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v364, 0LL);
		      HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v364, 0LL);
		      HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v364, 0LL);
		      HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v364, 0LL);
		      HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v364, 0LL);
		      sub_18033B9D0(&v416, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v416, v42, v44, 0LL);
		      v47 = *(_OWORD *)&v416.width;
		      *(_OWORD *)&v367.width = *(_OWORD *)&v416.width;
		      *(_OWORD *)&v367.colorFormat = *(_OWORD *)&v416.colorFormat;
		      *(_OWORD *)&v367.enableRandomWrite = *(_OWORD *)&v416.enableRandomWrite;
		      *(_QWORD *)&v367.bindTextureMS = *(_QWORD *)&v416.bindTextureMS;
		      v48 = *(_OWORD *)&v416.fastMemoryDesc.inFastMemory;
		      *(_OWORD *)&v367.fastMemoryDesc.inFastMemory = *(_OWORD *)&v416.fastMemoryDesc.inFastMemory;
		      clearColor = v416.clearColor;
		      v367.clearColor = v416.clearColor;
		      v367.name = (String *)"Water Proxy Data Texture";
		      if ( dword_18F35FD08 )
		      {
		        v50 = (((unsigned __int64)&v367.name >> 12) & 0x1FFFFF) >> 6;
		        v45 = ((unsigned __int64)&v367.name >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		        do
		        {
		          v46 = qword_18F0BCBA0[v50 + 36190] | (1LL << v45);
		          v51 = qword_18F0BCBA0[v50 + 36190];
		        }
		        while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v46, v51) );
		        clearColor = v367.clearColor;
		        v48 = *(_OWORD *)&v367.fastMemoryDesc.inFastMemory;
		        v47 = *(_OWORD *)&v367.width;
		      }
		      v367.colorFormat = 8;
		      *(_WORD *)&v367.useMipMap = 0;
		      *(_OWORD *)&v417.width = v47;
		      *(_OWORD *)&v417.colorFormat = *(_OWORD *)&v367.colorFormat;
		      *(_OWORD *)&v417.enableRandomWrite = *(_OWORD *)&v367.enableRandomWrite;
		      *(_OWORD *)&v417.bindTextureMS = *(_OWORD *)&v367.bindTextureMS;
		      *(_OWORD *)&v417.fastMemoryDesc.inFastMemory = v48;
		      v417.clearColor = clearColor;
		      if ( !v7 )
		        sub_1800D8250(v46, v45);
		      v392 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v364, (HGRenderGraph *)v7, &v417, 0LL);
		      sub_18033B9D0(&v418, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v418, v42, v44, 0LL);
		      v367 = v418;
		      v367.colorFormat = 75;
		      *(_WORD *)&v367.useMipMap = 0;
		      *(_OWORD *)&v419.width = *(_OWORD *)&v418.width;
		      *(_OWORD *)&v419.colorFormat = *(_OWORD *)&v367.colorFormat;
		      *(_OWORD *)&v419.enableRandomWrite = *(_OWORD *)&v367.enableRandomWrite;
		      *(_OWORD *)&v419.bindTextureMS = *(_OWORD *)&v418.bindTextureMS;
		      *(_OWORD *)&v419.fastMemoryDesc.inFastMemory = *(_OWORD *)&v418.fastMemoryDesc.inFastMemory;
		      v419.clearColor = v418.clearColor;
		      v384 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v364, (HGRenderGraph *)v7, &v419, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      SupportedFormatForDepth = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
		                                  GraphicsFormat__Enum_D24_UNorm_S8_UInt,
		                                  depthBits,
		                                  0LL);
		      sub_18033B9D0(&v420, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v420, v42, v44, 0LL);
		      *(_OWORD *)&v367.width = *(_OWORD *)&v420.width;
		      v367.dimension = v420.dimension;
		      *(_OWORD *)&v367.enableRandomWrite = *(_OWORD *)&v420.enableRandomWrite;
		      *(_OWORD *)&v367.bindTextureMS = *(_OWORD *)&v420.bindTextureMS;
		      *(_OWORD *)&v367.fastMemoryDesc.inFastMemory = *(_OWORD *)&v420.fastMemoryDesc.inFastMemory;
		      v367.clearColor = v420.clearColor;
		      *(_QWORD *)&v367.colorFormat = SupportedFormatForDepth;
		      v367.depthBufferBits = depthBits[0];
		      v367.clearBuffer = 1;
		      v367.wrapMode = 1;
		      *(_OWORD *)&v421.width = *(_OWORD *)&v367.width;
		      *(_OWORD *)&v421.colorFormat = *(_OWORD *)&v367.colorFormat;
		      *(_OWORD *)&v421.enableRandomWrite = *(_OWORD *)&v420.enableRandomWrite;
		      *(_OWORD *)&v421.bindTextureMS = *(_OWORD *)&v420.bindTextureMS;
		      *(_OWORD *)&v421.fastMemoryDesc.inFastMemory = *(_OWORD *)&v367.fastMemoryDesc.inFastMemory;
		      v421.clearColor = v420.clearColor;
		      v385 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v364, (HGRenderGraph *)v7, &v421, 0LL);
		      sub_18033B9D0(&v422, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v422, v42, height, 0LL);
		      v367 = v422;
		      v367.colorFormat = 45;
		      *(_WORD *)&v367.useMipMap = 0;
		      *(_OWORD *)&v423.width = *(_OWORD *)&v422.width;
		      *(_OWORD *)&v423.colorFormat = *(_OWORD *)&v367.colorFormat;
		      *(_OWORD *)&v423.enableRandomWrite = *(_OWORD *)&v367.enableRandomWrite;
		      *(_OWORD *)&v423.bindTextureMS = *(_OWORD *)&v422.bindTextureMS;
		      *(_OWORD *)&v423.fastMemoryDesc.inFastMemory = *(_OWORD *)&v422.fastMemoryDesc.inFastMemory;
		      v423.clearColor = v422.clearColor;
		      si128 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v364, (HGRenderGraph *)v7, &v423, 0LL);
		      sub_18033B9D0(&v424, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v424, v42, height, 0LL);
		      *(_OWORD *)&v367.width = *(_OWORD *)&v424.width;
		      v367.dimension = v424.dimension;
		      *(_OWORD *)&v367.enableRandomWrite = *(_OWORD *)&v424.enableRandomWrite;
		      *(_OWORD *)&v367.bindTextureMS = *(_OWORD *)&v424.bindTextureMS;
		      *(_OWORD *)&v367.fastMemoryDesc.inFastMemory = *(_OWORD *)&v424.fastMemoryDesc.inFastMemory;
		      v367.clearColor = v424.clearColor;
		      *(_QWORD *)&v367.colorFormat = SupportedFormatForDepth;
		      v367.depthBufferBits = depthBits[0];
		      v367.clearBuffer = 1;
		      v367.wrapMode = 1;
		      *(_OWORD *)&v425.width = *(_OWORD *)&v367.width;
		      *(_OWORD *)&v425.colorFormat = *(_OWORD *)&v367.colorFormat;
		      *(_OWORD *)&v425.enableRandomWrite = *(_OWORD *)&v424.enableRandomWrite;
		      *(_OWORD *)&v425.bindTextureMS = *(_OWORD *)&v424.bindTextureMS;
		      *(_OWORD *)&v425.fastMemoryDesc.inFastMemory = *(_OWORD *)&v367.fastMemoryDesc.inFastMemory;
		      v425.clearColor = v424.clearColor;
		      v364 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v364, (HGRenderGraph *)v7, &v425, 0LL);
		      v366 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                &v366,
		                &input->gBufferOutput,
		                GBufferID__Enum_GBufferB,
		                0LL);
		      v10->fields.m_normalRoughnessWithWaterTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                         &v372,
		                                                         (HGRenderGraph *)v7,
		                                                         &v366,
		                                                         0LL);
		      v10->fields.m_depthWithWaterTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                               &v372,
		                                               (HGRenderGraph *)v7,
		                                               &input->sceneDepth,
		                                               0LL);
		      sub_18033B9D0(&v426, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v426,
		        hgCamera->fields._sceneRTSize_k__BackingField,
		        0LL);
		      v367 = v426;
		      v367.colorFormat = 8;
		      *(_WORD *)&v367.useMipMap = 0;
		      *(_OWORD *)&v427.width = *(_OWORD *)&v426.width;
		      *(_OWORD *)&v427.colorFormat = *(_OWORD *)&v367.colorFormat;
		      *(_OWORD *)&v427.enableRandomWrite = *(_OWORD *)&v367.enableRandomWrite;
		      *(_OWORD *)&v427.bindTextureMS = *(_OWORD *)&v426.bindTextureMS;
		      *(_OWORD *)&v427.fastMemoryDesc.inFastMemory = *(_OWORD *)&v426.fastMemoryDesc.inFastMemory;
		      v427.clearColor = v426.clearColor;
		      v10->fields.m_waterTessellationDataTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                      &v372,
		                                                      (HGRenderGraph *)v7,
		                                                      &v427,
		                                                      0LL);
		      v52 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x48u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        (HGRenderGraphBuilder *)&viewProj,
		        (HGRenderGraph *)v7,
		        (String *)"Water Tessellation",
		        &v370,
		        v52,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		      *(_OWORD *)&v381.m_RenderPass = *(_OWORD *)&viewProj.m00;
		      *(_OWORD *)&v381.m_RenderGraph = *(_OWORD *)&viewProj.m01;
		      inputa.m_RenderPass = 0LL;
		      inputa.m_Resources = (HGRenderGraphResourceRegistry *)&v381;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v381, 0, 0LL);
		        *(_QWORD *)&viewPosition.x = v370;
		        v55 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v372, &v381, &v366, 0LL);
		        if ( !*(_QWORD *)&viewPosition.x )
		          sub_1800D8250(v54, v53);
		        *(TextureHandle *)(*(_QWORD *)&viewPosition.x + 560LL) = v55;
		        *(_QWORD *)&viewPosition.x = v370;
		        v58 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 &v366,
		                 &v381,
		                 &input->sceneDepth,
		                 0LL);
		        if ( !*(_QWORD *)&viewPosition.x )
		          sub_1800D8250(v57, v56);
		        *(TextureHandle *)(*(_QWORD *)&viewPosition.x + 576LL) = v58;
		        v59 = v370;
		        if ( !v370 )
		          sub_1800D8250(v57, 0LL);
		        v370[8].klass = (Object__Class *)v10->fields.m_waterCopyMPB;
		        v60 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v61 = ((unsigned __int64)&v59[8] >> 12) & 0x1FFFFF;
		          v62 = v61 >> 6;
		          v63 = v61 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v62 + 36190]);
		          do
		            v64 = qword_18F0BCBA0[v62 + 36190];
		          while ( v64 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v62 + 36190], v64 | (1LL << v63), v64) );
		          v60 = dword_18F35FD08;
		        }
		        v65 = v370;
		        m_waterTextureProcessMaterial = (MonitorData *)v10->fields.m_waterTextureProcessMaterial;
		        if ( !v370 )
		          sub_1800D8250(m_waterTextureProcessMaterial, 0LL);
		        v370[4].monitor = m_waterTextureProcessMaterial;
		        if ( v60 )
		        {
		          v67 = ((unsigned __int64)&v65[4].monitor >> 12) & 0x1FFFFF;
		          v68 = v67 >> 6;
		          v69 = v67 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v68 + 36190]);
		          do
		            v70 = qword_18F0BCBA0[v68 + 36190];
		          while ( v70 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v68 + 36190], v70 | (1LL << v69), v70) );
		        }
		        v366 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v372,
		          &v381,
		          &v10->fields.m_normalRoughnessWithWaterTexture,
		          0,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v366,
		          0,
		          0LL);
		        v366 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v372,
		          &v381,
		          &v10->fields.m_waterTessellationDataTexture,
		          1,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v366,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          &v366,
		          &v381,
		          &v10->fields.m_depthWithWaterTexture,
		          DepthAccess__Enum_Write,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          1.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v381,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterCopyRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v409 )
		      {
		        inputa.m_RenderPass = (HGRenderGraphPass *)v409->ex;
		        sub_180268AE0(&inputa);
		        v7 = (Object *)renderGraph;
		        v10 = this;
		        m_KeywordSpace = (HGWaterGlobalConfig *)v371[0];
		        v362.m_SpaceInfo.m_KeywordSpace = (void *)v371[0];
		        v13 = (Object__Class *)hgCamera;
		        goto LABEL_29;
		      }
		      sub_180268AE0(&inputa);
		      m_KeywordSpace = (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace;
		LABEL_29:
		      if ( visibleCount )
		      {
		        if ( !m_KeywordSpace )
		          sub_1800D8250(v72, v71);
		        RealLODNum = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealLODNum(
		                       m_KeywordSpace,
		                       input->settingParameters,
		                       0LL);
		        SupportedFormatForDepth = RealLODNum;
		        depthBits[0] = HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(
		                         (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace,
		                         input->settingParameters,
		                         0LL);
		        height = depthBits[0];
		        v368 = 32 * (v10->fields.m_frameIndexV2 & 1);
		        v375 = 32 * ((v10->fields.m_frameIndexV2 - 1) & 1);
		        if ( !v10->fields.m_indirectBufferV2 )
		        {
		          v132 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		          v135 = v132;
		          if ( !v132 )
		            sub_1800D8250(v134, v133);
		          UnityEngine::ComputeBuffer::ComputeBuffer(
		            v132,
		            64,
		            4,
		            ComputeBufferType__Enum_DrawIndirect,
		            ComputeBufferMode__Enum_Immutable,
		            3,
		            0LL);
		          v10->fields.m_indirectBufferV2 = v135;
		          if ( dword_18F35FD08 )
		          {
		            v136 = (((unsigned __int64)&v10->fields.m_indirectBufferV2 >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v136 + 36190]);
		            do
		              v137 = qword_18F0BCBA0[v136 + 36190];
		            while ( v137 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v136 + 36190],
		                              v137 | (1LL << (((unsigned __int64)&v10->fields.m_indirectBufferV2 >> 12) & 0x3F)),
		                              v137) );
		          }
		        }
		        *(_QWORD *)(&desc.type + 1) = 0LL;
		        HIDWORD(desc.name) = 0;
		        desc.count = 4 * RealLODNum * depthBits[0] * depthBits[0];
		        desc.stride = 4;
		        desc.type = 16;
		        *(ComputeBufferHandle *)&viewPosition.x = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		                                                    (HGRenderGraph *)v7,
		                                                    &desc,
		                                                    0LL);
		        v369 = -1;
		        for ( i = 0; i < 4; ++i )
		        {
		          if ( UnityEngine::HyperGryph::HGWaterRender::IsHeightLayerVisible(cullHandle, 3u, i, 0LL) )
		          {
		            v369 = i;
		            break;
		          }
		        }
		        sub_18033B9D0(source, 0LL, 192LL);
		        *(_OWORD *)source = *(_OWORD *)&orthoDeviceViewProj.m00;
		        v451 = *(_OWORD *)&orthoDeviceViewProj.m01;
		        v452 = *(_OWORD *)&orthoDeviceViewProj.m02;
		        v453 = *(_OWORD *)&orthoDeviceViewProj.m03;
		        v454 = orthoDeviceInvViewProj;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        keyword = *(LocalKeyword *)UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                                     (CBHandle *)&viewProj,
		                                     &input->srpContext,
		                                     192,
		                                     0LL);
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(*(Void **)&keyword.m_Index, source, 192LL, 0LL);
		        v139 = 0;
		        while ( 2 )
		        {
		          width = v139;
		          if ( v139 < 4 )
		          {
		            if ( !UnityEngine::HyperGryph::HGWaterRender::IsHeightLayerVisible(cullHandle, 3u, v139, 0LL) )
		              goto LABEL_213;
		            v140 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                     (Int32Enum__Enum)0x36u,
		                     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		            HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		              &v400,
		              (HGRenderGraph *)v7,
		              v140,
		              0LL);
		            v366.handle = 0LL;
		            v366.fallBackResource = (ResourceHandle)&v400;
		            v141 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                     (Int32Enum__Enum)0x37u,
		                     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		            HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		              &inputa,
		              (HGRenderGraph *)v7,
		              (String *)"Water Prepass",
		              &v361,
		              v141,
		              1,
		              ProfilingHGPass__Enum_None,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            v389 = inputa;
		            v386[0] = 0LL;
		            v386[1] = &v389;
		            try
		            {
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v389, 0, 0LL);
		              if ( !v361 )
		                sub_1800D8250(0LL, v142);
		              HIDWORD(v361[1].monitor) = visibleCount;
		              v143 = v361;
		              if ( !v361 )
		                sub_1800D8250(0LL, v142);
		              LODWORD(v361[2].klass) = cullHandle;
		              if ( !v361 )
		                sub_1800D8250(v143, v142);
		              HIDWORD(v361[2].klass) = v139;
		              v144 = v361;
		              if ( !v361 )
		                sub_1800D8250(v143, 0LL);
		              v145 = (Object__Class *)hgCamera;
		              v361[1].klass = (Object__Class *)hgCamera;
		              v146 = dword_18F35FD08;
		              if ( dword_18F35FD08 )
		              {
		                v147 = ((unsigned __int64)&v144[1] >> 12) & 0x1FFFFF;
		                v148 = v147 >> 6;
		                v149 = v147 & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v148 + 36190]);
		                do
		                  v150 = qword_18F0BCBA0[v148 + 36190];
		                while ( v150 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v148 + 36190],
		                                  v150 | (1LL << v149),
		                                  v150) );
		                v146 = dword_18F35FD08;
		              }
		              v151 = v361;
		              m_waterProxyMaterial_V2 = (Object__Class *)v10->fields.m_waterProxyMaterial_V2;
		              if ( !v361 )
		                sub_1800D8250(m_waterProxyMaterial_V2, 0LL);
		              v361[4].klass = m_waterProxyMaterial_V2;
		              if ( v146 )
		              {
		                v153 = ((unsigned __int64)&v151[4] >> 12) & 0x1FFFFF;
		                v154 = v153 >> 6;
		                v155 = v153 & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v154 + 36190]);
		                do
		                  v156 = qword_18F0BCBA0[v154 + 36190];
		                while ( v156 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v154 + 36190],
		                                  v156 | (1LL << v155),
		                                  v156) );
		                v146 = dword_18F35FD08;
		              }
		              v157 = v361;
		              m_waterProxyMPB_V2 = (MonitorData *)v10->fields.m_waterProxyMPB_V2;
		              if ( !v361 )
		                sub_1800D8250(m_waterProxyMPB_V2, 0LL);
		              v361[5].monitor = m_waterProxyMPB_V2;
		              if ( v146 )
		              {
		                v159 = ((unsigned __int64)&v157[5].monitor >> 12) & 0x1FFFFF;
		                v160 = v159 >> 6;
		                v157 = (Object *)(v159 & 0x3F);
		                _m_prefetchw(&qword_18F0BCBA0[v160 + 36190]);
		                do
		                {
		                  m_waterProxyMPB_V2 = (MonitorData *)(qword_18F0BCBA0[v160 + 36190] | (1LL << (char)v157));
		                  v161 = qword_18F0BCBA0[v160 + 36190];
		                }
		                while ( v161 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v160 + 36190],
		                                  (signed __int64)m_waterProxyMPB_V2,
		                                  v161) );
		              }
		              if ( !v361 )
		                sub_1800D8250(m_waterProxyMPB_V2, v157);
		              monitor = v361[5].monitor;
		              if ( !monitor )
		                sub_1800D8250(0LL, v157);
		              UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)monitor, 1, 0LL);
		              if ( !v361 )
		                sub_1800D8250(v164, v163);
		              v165 = v361[5].monitor;
		              if ( !v165 )
		                sub_1800D8250(0LL, v163);
		              UnityEngine::MaterialPropertyBlock::SetConstantBuffer(
		                (MaterialPropertyBlock *)v165,
		                (String *)"_WaterProxyPerDrawData",
		                (uint32_t)keyword.m_SpaceInfo.m_KeywordSpace,
		                SHIDWORD(keyword.m_SpaceInfo.m_KeywordSpace),
		                (int32_t)keyword.m_Name,
		                0LL);
		              *(_OWORD *)&inputa.m_RenderPass = 0LL;
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                &v444,
		                &v389,
		                &v392,
		                0,
		                RenderBufferLoadAction__Enum_Clear,
		                RenderBufferStoreAction__Enum_Store,
		                (Color *)&inputa,
		                0,
		                0LL);
		              *(_OWORD *)&inputa.m_RenderPass = 0LL;
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                &v443,
		                &v389,
		                &v384,
		                1,
		                RenderBufferLoadAction__Enum_Clear,
		                RenderBufferStoreAction__Enum_Store,
		                (Color *)&inputa,
		                0,
		                0LL);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                &v442,
		                &v389,
		                &v385,
		                DepthAccess__Enum_Write,
		                RenderBufferLoadAction__Enum_Clear,
		                RenderBufferStoreAction__Enum_Store,
		                1.0,
		                0,
		                0,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                &v389,
		                (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterHeightRenderFunc,
		                0LL,
		                0,
		                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            }
		            catch ( Il2CppExceptionWrapper *v404 )
		            {
		              v386[0] = v404->ex;
		              sub_180268AE0(v386);
		              v7 = (Object *)renderGraph;
		              v10 = this;
		              v362.m_SpaceInfo.m_KeywordSpace = (void *)v371[0];
		              RealLODNum = SupportedFormatForDepth;
		              depthBits[0] = height;
		              v145 = (Object__Class *)hgCamera;
		              goto LABEL_106;
		            }
		            sub_180268AE0(v386);
		LABEL_106:
		            v166 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                     (Int32Enum__Enum)0x3Cu,
		                     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		            HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		              &inputa,
		              (HGRenderGraph *)v7,
		              (String *)"Water Decal",
		              (Object **)&v355,
		              v166,
		              1,
		              ProfilingHGPass__Enum_None,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            v377 = inputa;
		            v387[0] = 0LL;
		            v387[1] = &v377;
		            try
		            {
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v377, 0, 0LL);
		              v169 = (ProfilingSampler *)v10->fields.m_cbHandle.ptr;
		              v170 = v355;
		              if ( !v355 )
		                sub_1800D8250(v168, v167);
		              *(_OWORD *)&v355[1].fields._name_k__BackingField = *(_OWORD *)&v10->fields.m_cbHandle.bufferId;
		              v170[1].fields._customSampler_k__BackingField = v169;
		              v171 = v355;
		              if ( !v355 )
		                sub_1800D8250(v168, 0LL);
		              v355->fields._name_k__BackingField = (String *)v145;
		              if ( dword_18F35FD08 )
		              {
		                v172 = ((unsigned __int64)&v171->fields >> 12) & 0x1FFFFF;
		                v173 = v172 >> 6;
		                v171 = (HGRenderGraphPass *)(v172 & 0x3F);
		                _m_prefetchw(&qword_18F0BCBA0[v173 + 36190]);
		                do
		                  v174 = qword_18F0BCBA0[v173 + 36190];
		                while ( v174 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v173 + 36190],
		                                  v174 | (1LL << (char)v171),
		                                  v174) );
		              }
		              if ( !v355 )
		                sub_1800D8250(0LL, v171);
		              HIDWORD(v355->fields._customSampler_k__BackingField) = width;
		              inputa.m_RenderPass = v355;
		              v177 = (Color)*HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                               &v441,
		                               &v377,
		                               &v392,
		                               0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v176, v175);
		              inputa.m_RenderPass[1].fields.depthAttachment.clearColor = v177;
		              inputa.m_RenderPass = v355;
		              v180 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v440, &v377, &v384, 0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v179, v178);
		              *(TextureHandle *)&inputa.m_RenderPass[1].fields.depthAttachment.depthSlice = v180;
		              inputa.m_RenderPass = v355;
		              v183 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v439, &v377, &v385, 0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v182, v181);
		              *(TextureHandle *)&inputa.m_RenderPass[1].fields.colorAttachments = v183;
		              inputa.m_RenderPass = v355;
		              v186 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                        &v438,
		                        &v377,
		                        &sectorTexture,
		                        0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v185, v184);
		              *(TextureHandle *)&inputa.m_RenderPass[1].fields._profilingHgPass_k__BackingField = v186;
		              inputa.m_RenderPass = v355;
		              v189 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                        &v445,
		                        &v377,
		                        &interactionTexture,
		                        0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v188, v187);
		              *(TextureHandle *)&inputa.m_RenderPass[1].fields.depthAttachment.textureHandle.fallBackResource.m_Value = v189;
		              inputa.m_RenderPass = v355;
		              flowMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
		                          (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace,
		                          0LL);
		              m_RenderPass = inputa.m_RenderPass;
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(flowMap, v190);
		              inputa.m_RenderPass->fields.dependsOnRendererListList = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)flowMap;
		              if ( dword_18F35FD08 )
		              {
		                v193 = (((unsigned __int64)&m_RenderPass->fields.dependsOnRendererListList >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v193 + 36190]);
		                do
		                  v194 = qword_18F0BCBA0[v193 + 36190];
		                while ( v194 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v193 + 36190],
		                                  v194 | (1LL << (((unsigned __int64)&m_RenderPass->fields.dependsOnRendererListList >> 12) & 0x3F)),
		                                  v194) );
		              }
		              inputa.m_RenderPass = v355;
		              normalMapArray = (MonitorData *)HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
		                                                (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace,
		                                                0LL);
		              v197 = inputa.m_RenderPass;
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(0LL, v196);
		              inputa.m_RenderPass[1].monitor = normalMapArray;
		              v198 = dword_18F35FD08;
		              if ( dword_18F35FD08 )
		              {
		                v199 = (((unsigned __int64)&v197[1].monitor >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v199 + 36190]);
		                do
		                  v200 = qword_18F0BCBA0[v199 + 36190];
		                while ( v200 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v199 + 36190],
		                                  v200 | (1LL << (((unsigned __int64)&v197[1].monitor >> 12) & 0x3F)),
		                                  v200) );
		                v198 = dword_18F35FD08;
		              }
		              v201 = v355;
		              m_waterTextureProcessMaterial_V2 = (MonitorData *)v10->fields.m_waterTextureProcessMaterial_V2;
		              if ( !v355 )
		                sub_1800D8250(m_waterTextureProcessMaterial_V2, 0LL);
		              *(_QWORD *)&v355->fields.depthAttachment.clearColor.r = m_waterTextureProcessMaterial_V2;
		              if ( v198 )
		              {
		                v203 = ((unsigned __int64)&v201->fields.depthAttachment.clearColor >> 12) & 0x1FFFFF;
		                v204 = v203 >> 6;
		                v205 = v203 & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v204 + 36190]);
		                do
		                  v206 = qword_18F0BCBA0[v204 + 36190];
		                while ( v206 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v204 + 36190],
		                                  v206 | (1LL << v205),
		                                  v206) );
		                v198 = dword_18F35FD08;
		              }
		              v207 = v355;
		              m_waterHeightDecalMPB = (MonitorData *)v10->fields.m_waterHeightDecalMPB;
		              if ( !v355 )
		                sub_1800D8250(m_waterHeightDecalMPB, 0LL);
		              v355->fields.transientResourceList = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)m_waterHeightDecalMPB;
		              if ( v198 )
		              {
		                v209 = ((unsigned __int64)&v207->fields.transientResourceList >> 12) & 0x1FFFFF;
		                v210 = v209 >> 6;
		                v211 = v209 & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v210 + 36190]);
		                do
		                  v212 = qword_18F0BCBA0[v210 + 36190];
		                while ( v212 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v210 + 36190],
		                                  v212 | (1LL << v211),
		                                  v212) );
		              }
		              *(_OWORD *)&inputa.m_RenderPass = 0LL;
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                &v446,
		                &v377,
		                &si128,
		                0,
		                RenderBufferLoadAction__Enum_Load,
		                RenderBufferStoreAction__Enum_Store,
		                (Color *)&inputa,
		                0,
		                0LL);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                &v447,
		                &v377,
		                &v364,
		                DepthAccess__Enum_Write,
		                RenderBufferLoadAction__Enum_Load,
		                RenderBufferStoreAction__Enum_Store,
		                1.0,
		                0,
		                0,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                &v377,
		                (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterDecalRenderFunc,
		                0LL,
		                0,
		                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            }
		            catch ( Il2CppExceptionWrapper *v407 )
		            {
		              v387[0] = v407->ex;
		              sub_180268AE0(v387);
		              v7 = (Object *)renderGraph;
		              v10 = this;
		              v362.m_SpaceInfo.m_KeywordSpace = (void *)v371[0];
		              RealLODNum = SupportedFormatForDepth;
		              depthBits[0] = height;
		              v145 = (Object__Class *)hgCamera;
		              goto LABEL_138;
		            }
		            sub_180268AE0(v387);
		LABEL_138:
		            v213 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                     (Int32Enum__Enum)0x39u,
		                     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		            HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		              &inputa,
		              (HGRenderGraph *)v7,
		              (String *)"Water Occlusion",
		              (Object **)&v356,
		              v213,
		              1,
		              ProfilingHGPass__Enum_None,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            v382 = inputa;
		            v383[0] = 0LL;
		            v383[1] = &v382;
		            try
		            {
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v382, 0, 0LL);
		              sub_18033B9D0(v410, 0LL, 64LL);
		              screenSpaceMesh = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(v363, 0LL);
		              if ( !screenSpaceMesh )
		                sub_1800D8250(v216, v215);
		              LODWORD(inputa.m_RenderPass) = UnityEngine::Mesh::GetIndexCount(screenSpaceMesh, 0, 0LL);
		              v217 = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(v363, 0LL);
		              if ( !v217 )
		                sub_1800D8250(v219, v218);
		              BaseVertex = UnityEngine::Mesh::GetBaseVertex(v217, 0, 0LL);
		              m_RenderPass_low = (float)SLODWORD(inputa.m_RenderPass);
		              *(float *)&v388 = m_RenderPass_low;
		              v222 = (float)BaseVertex;
		              *((float *)&v388 + 1) = v222;
		              *((_QWORD *)&v388 + 1) = COERCE_UNSIGNED_INT((float)(int)width);
		              *(float *)&v223 = (float)v368;
		              *(float *)&v224 = (float)v375;
		              *(_QWORD *)&v411 = __PAIR64__(v224, v223);
		              *((float *)&v411 + 2) = (float)RealLODNum;
		              *((float *)&v411 + 3) = (float)(int)depthBits[0];
		              *(_OWORD *)v412 = v388;
		              v413 = v411;
		              v414 = 0LL;
		              v415 = 0LL;
		              inputa.m_RenderPass = (HGRenderGraphPass *)&input->srpContext;
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		              ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                                 (CBHandle *)&inputa,
		                                 (ScriptableRenderContext *)inputa.m_RenderPass,
		                                 64,
		                                 0LL);
		              v226 = *(_OWORD *)&ConstantBuffer->bufferId;
		              v227 = (Void *)ConstantBuffer->ptr;
		              *(_QWORD *)&viewProj.m01 = v227;
		              Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v227, v412, 64LL, 0LL);
		              v229 = v356;
		              if ( !v356 )
		                sub_1800D8250(v228, 0LL);
		              v356->fields._name_k__BackingField = (String *)v145;
		              if ( dword_18F35FD08 )
		              {
		                v230 = ((unsigned __int64)&v229->fields >> 12) & 0x1FFFFF;
		                v231 = v230 >> 6;
		                v229 = (HGRenderGraphPass *)(v230 & 0x3F);
		                _m_prefetchw(&qword_18F0BCBA0[v231 + 36190]);
		                do
		                {
		                  v228 = qword_18F0BCBA0[v231 + 36190] | (1LL << (char)v229);
		                  v232 = qword_18F0BCBA0[v231 + 36190];
		                }
		                while ( v232 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v231 + 36190], v228, v232) );
		              }
		              if ( !v356 )
		                sub_1800D8250(v228, v229);
		              v233 = depthBits[0];
		              *(DepthBits__Enum *)&v356->fields._enableAsyncCompute_k__BackingField = depthBits[0];
		              if ( !v356 )
		                sub_1800D8250(v233, v229);
		              v234 = (unsigned int)RealLODNum;
		              v356->fields.depthAttachment.textureHandle.handle.m_Value = RealLODNum;
		              LOBYTE(v234) = v10->fields.m_isFirstTimeV2;
		              if ( !v356 )
		                sub_1800D8250(v234, v229);
		              LOBYTE(v356[2].fields.depthAttachment.clearColor.r) = v234;
		              v235 = (ProfilingSampler *)v10->fields.m_cbHandle.ptr;
		              v236 = v356;
		              if ( !v356 )
		                sub_1800D8250(v234, v229);
		              *(_OWORD *)&v356[1].fields._name_k__BackingField = *(_OWORD *)&v10->fields.m_cbHandle.bufferId;
		              v236[1].fields._customSampler_k__BackingField = v235;
		              v237 = v356;
		              if ( !v356 )
		                sub_1800D8250(v234, v229);
		              *(_OWORD *)&v356[2].fields.depthAttachment.depthSlice = v226;
		              v237[2].fields.colorAttachments = (DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *)v227;
		              *(_QWORD *)depthBits = v356;
		              inputa.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
		                                                           (HGRenderGraph *)v7,
		                                                           v10->fields.m_indirectBufferV2,
		                                                           0LL);
		              v238 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
		                       &v382,
		                       (ComputeBufferHandle *)&inputa,
		                       0LL);
		              if ( !*(_QWORD *)depthBits )
		                ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v239);
		              *(ComputeBufferHandle *)(*(_QWORD *)depthBits + 472LL) = v238;
		              inputa.m_RenderPass = v356;
		              v240 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
		                       &v382,
		                       (ComputeBufferHandle *)&viewPosition,
		                       0LL);
		              if ( !inputa.m_RenderPass )
		                ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v241);
		              *(ComputeBufferHandle *)&inputa.m_RenderPass[2].fields._refCount_k__BackingField = v240;
		              inputa.m_RenderPass = v356;
		              v244 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v448, &v382, &v385, 0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v243, v242);
		              *(TextureHandle *)&inputa.m_RenderPass[2].fields.depthAttachment.textureHandle.fallBackResource.m_Value = v244;
		              inputa.m_RenderPass = v356;
		              v247 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v449, &v382, &si128, 0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v246, v245);
		              *(TextureHandle *)&inputa.m_RenderPass[2].fields._index_k__BackingField = v247;
		              inputa.m_RenderPass = v356;
		              v250 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v428, &v382, &v384, 0LL);
		              if ( !inputa.m_RenderPass )
		                sub_1800D8250(v249, v248);
		              *(TextureHandle *)&inputa.m_RenderPass[2].fields.m_childPasses = v250;
		              v251 = v356;
		              if ( !v356 )
		                sub_1800D8250(v249, 0LL);
		              v356[2].fields.transientResourceList = (List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *)v10->fields.m_waterOcclusionCS;
		              if ( dword_18F35FD08 )
		              {
		                v252 = ((unsigned __int64)&v251[2].fields.transientResourceList >> 12) & 0x1FFFFF;
		                v253 = v252 >> 6;
		                v254 = v252 & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v253 + 36190]);
		                do
		                  v255 = qword_18F0BCBA0[v253 + 36190];
		                while ( v255 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v253 + 36190],
		                                  v255 | (1LL << v254),
		                                  v255) );
		              }
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                &v382,
		                (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterOcclustionRenderFuncV2,
		                0LL,
		                0,
		                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            }
		            catch ( Il2CppExceptionWrapper *v406 )
		            {
		              v383[0] = v406->ex;
		              sub_180268AE0(v383);
		              v7 = (Object *)renderGraph;
		              v10 = this;
		              v362.m_SpaceInfo.m_KeywordSpace = (void *)v371[0];
		              v145 = (Object__Class *)hgCamera;
		              goto LABEL_161;
		            }
		            sub_180268AE0(v383);
		LABEL_161:
		            v256 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                     (Int32Enum__Enum)0x41u,
		                     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		            HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		              &inputa,
		              (HGRenderGraph *)v7,
		              (String *)"Water Tessellation",
		              &v350,
		              v256,
		              1,
		              ProfilingHGPass__Enum_None,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            v374 = inputa;
		            v372.handle = 0LL;
		            v372.fallBackResource = (ResourceHandle)&v374;
		            try
		            {
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v374, 0, 0LL);
		              v258 = v350;
		              if ( !v350 )
		                sub_1800D8250(v257, 0LL);
		              v350[1].klass = v145;
		              if ( dword_18F35FD08 )
		              {
		                v259 = ((unsigned __int64)&v258[1] >> 12) & 0x1FFFFF;
		                v260 = v259 >> 6;
		                v258 = (Object *)(v259 & 0x3F);
		                _m_prefetchw(&qword_18F0BCBA0[v260 + 36190]);
		                do
		                {
		                  v257 = qword_18F0BCBA0[v260 + 36190] | (1LL << (char)v258);
		                  v261 = qword_18F0BCBA0[v260 + 36190];
		                }
		                while ( v261 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v260 + 36190], v257, v261) );
		              }
		              v262 = (Object__Class *)v10->fields.m_cbHandle.ptr;
		              v263 = v350;
		              if ( !v350 )
		                sub_1800D8250(v257, v258);
		              v350[12] = *(Object *)&v10->fields.m_cbHandle.bufferId;
		              v263[13].klass = v262;
		              if ( !v350 )
		                sub_1800D8250(v257, v258);
		              v264 = v368 + 8 * width;
		              HIDWORD(v350[26].monitor) = v264;
		              if ( !v350 )
		                sub_1800D8250(v264, width);
		              HIDWORD(v350[2].klass) = width;
		              if ( !v350 )
		                sub_1800D8250(0LL, width);
		              LODWORD(v350[2].monitor) = v369;
		              v265 = (ComputeBufferHandle *)v350;
		              inputa.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
		                                                           (HGRenderGraph *)v7,
		                                                           v10->fields.m_indirectBufferV2,
		                                                           0LL);
		              v266 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		                       &v374,
		                       (ComputeBufferHandle *)&inputa,
		                       0LL);
		              if ( !v265 )
		                ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v268, v267);
		              v265[59] = v266;
		              v269 = (ComputeBufferHandle *)v350;
		              v270 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		                       &v374,
		                       (ComputeBufferHandle *)&viewPosition,
		                       0LL);
		              if ( !v269 )
		                ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v272, v271);
		              v269[58] = v270;
		              v273 = v350;
		              v276 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                        &v429,
		                        &v374,
		                        &sectorTexture,
		                        0LL);
		              if ( !v273 )
		                sub_1800D8250(v275, v274);
		              *(TextureHandle *)&v273[13].monitor = v276;
		              v277 = v350;
		              v280 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                        &v430,
		                        &v374,
		                        &interactionTexture,
		                        0LL);
		              if ( !v277 )
		                sub_1800D8250(v279, v278);
		              *(TextureHandle *)&v277[14].monitor = v280;
		              v281 = v350;
		              v284 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v431, &v374, &v392, 0LL);
		              if ( !v281 )
		                sub_1800D8250(v283, v282);
		              v281[31] = (Object)v284;
		              v285 = v350;
		              v288 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v432, &v374, &v384, 0LL);
		              if ( !v285 )
		                sub_1800D8250(v287, v286);
		              v285[32] = (Object)v288;
		              v289 = v350;
		              v292 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v433, &v374, &si128, 0LL);
		              if ( !v289 )
		                sub_1800D8250(v291, v290);
		              v289[33] = (Object)v292;
		              v293 = v350;
		              v296 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v434, &v374, &v385, 0LL);
		              if ( !v293 )
		                sub_1800D8250(v295, v294);
		              v293[34] = (Object)v296;
		              v297 = v350;
		              v298 = (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace;
		              v299 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
		                       (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace,
		                       0LL);
		              if ( !v297 )
		                sub_1800D8250(v301, v300);
		              v297[9].monitor = (MonitorData *)v299;
		              if ( dword_18F35FD08 )
		              {
		                v302 = (((unsigned __int64)&v297[9].monitor >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v302 + 36190]);
		                do
		                  v303 = qword_18F0BCBA0[v302 + 36190];
		                while ( v303 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v302 + 36190],
		                                  v303 | (1LL << (((unsigned __int64)&v297[9].monitor >> 12) & 0x3F)),
		                                  v303) );
		              }
		              v304 = v350;
		              rainMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(v298, 0LL);
		              if ( !v304 )
		                sub_1800D8250(v307, v306);
		              v304[10].monitor = (MonitorData *)rainMap;
		              if ( dword_18F35FD08 )
		              {
		                v308 = (((unsigned __int64)&v304[10].monitor >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v308 + 36190]);
		                do
		                  v309 = qword_18F0BCBA0[v308 + 36190];
		                while ( v309 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v308 + 36190],
		                                  v309 | (1LL << (((unsigned __int64)&v304[10].monitor >> 12) & 0x3F)),
		                                  v309) );
		              }
		              v310 = v350;
		              v311 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v298, 0LL);
		              if ( !v310 )
		                sub_1800D8250(v313, v312);
		              v310[11].monitor = (MonitorData *)v311;
		              if ( dword_18F35FD08 )
		              {
		                v314 = (((unsigned __int64)&v310[11].monitor >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v314 + 36190]);
		                do
		                  v315 = qword_18F0BCBA0[v314 + 36190];
		                while ( v315 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v314 + 36190],
		                                  v315 | (1LL << (((unsigned __int64)&v310[11].monitor >> 12) & 0x3F)),
		                                  v315) );
		              }
		              v316 = v350;
		              v317 = v363;
		              v318 = HG::Rendering::Runtime::HGWaterManager::get_screenSpaceMesh(v363, 0LL);
		              if ( !v316 )
		                sub_1800D8250(v320, v319);
		              v316[3].monitor = (MonitorData *)v318;
		              v321 = dword_18F35FD08;
		              if ( dword_18F35FD08 )
		              {
		                v322 = (((unsigned __int64)&v316[3].monitor >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v322 + 36190]);
		                do
		                  v323 = qword_18F0BCBA0[v322 + 36190];
		                while ( v323 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v322 + 36190],
		                                  v323 | (1LL << (((unsigned __int64)&v316[3].monitor >> 12) & 0x3F)),
		                                  v323) );
		                v321 = dword_18F35FD08;
		              }
		              v324 = v350;
		              m_waterTessellationMPB = (Object__Class *)v10->fields.m_waterTessellationMPB;
		              if ( !v350 )
		                sub_1800D8250(m_waterTessellationMPB, 0LL);
		              v350[9].klass = m_waterTessellationMPB;
		              if ( v321 )
		              {
		                v326 = ((unsigned __int64)&v324[9] >> 12) & 0x1FFFFF;
		                v327 = v326 >> 6;
		                v328 = v326 & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v327 + 36190]);
		                do
		                  v329 = qword_18F0BCBA0[v327 + 36190];
		                while ( v329 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v327 + 36190],
		                                  v329 | (1LL << v328),
		                                  v329) );
		                v321 = dword_18F35FD08;
		              }
		              v330 = v350;
		              m_waterTessellationMaterial = (MonitorData *)v10->fields.m_waterTessellationMaterial;
		              if ( !v350 )
		                sub_1800D8250(m_waterTessellationMaterial, 0LL);
		              v350[7].monitor = m_waterTessellationMaterial;
		              if ( v321 )
		              {
		                v332 = ((unsigned __int64)&v330[7].monitor >> 12) & 0x1FFFFF;
		                v333 = v332 >> 6;
		                v330 = (Object *)(v332 & 0x3F);
		                _m_prefetchw(&qword_18F0BCBA0[v333 + 36190]);
		                do
		                  v334 = qword_18F0BCBA0[v333 + 36190];
		                while ( v334 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v333 + 36190],
		                                  v334 | (1LL << (char)v330),
		                                  v334) );
		              }
		              v335 = v10->fields.m_waterTessellationMaterial;
		              if ( !v335 )
		                sub_1800D8250(0LL, v330);
		              shader = UnityEngine::Material::get_shader(v335, 0LL);
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v396, shader, (String *)"ENABLE_RAIN", 0LL);
		              v338 = v10->fields.m_waterTessellationMaterial;
		              if ( !v338 )
		                sub_1800D8250(0LL, v337);
		              v362 = v396;
		              UnityEngine::Material::SetLocalKeyword_Injected(v338, &v362, wetnessHighQualityEnabled, 0LL);
		              v340 = v10->fields.m_waterTessellationMaterial;
		              if ( !v340 )
		                sub_1800D8250(0LL, v339);
		              v341 = UnityEngine::Material::get_shader(v340, 0LL);
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v395, v341, (String *)"ENABLE_WATER_RIPPLE", 0LL);
		              v342 = v10->fields.m_waterTessellationMaterial;
		              ShouldRenderRippleState = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(v317, 0LL);
		              if ( !v342 )
		                sub_1800D8250(v345, v344);
		              v362 = v395;
		              UnityEngine::Material::SetLocalKeyword_Injected(v342, &v362, ShouldRenderRippleState, 0LL);
		              *(_OWORD *)&v362.m_SpaceInfo.m_KeywordSpace = 0LL;
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                &v435,
		                &v374,
		                &v10->fields.m_normalRoughnessWithWaterTexture,
		                0,
		                RenderBufferLoadAction__Enum_Load,
		                RenderBufferStoreAction__Enum_Store,
		                (Color *)&v362,
		                0,
		                0LL);
		              *(_OWORD *)&v362.m_SpaceInfo.m_KeywordSpace = 0LL;
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                &v436,
		                &v374,
		                &v10->fields.m_waterTessellationDataTexture,
		                1,
		                RenderBufferLoadAction__Enum_Load,
		                RenderBufferStoreAction__Enum_Store,
		                (Color *)&v362,
		                0,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		              if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		              {
		                *(__m128i *)&v362.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18DC80F80);
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                  &v437,
		                  &v374,
		                  &input->sceneMV,
		                  2,
		                  RenderBufferLoadAction__Enum_Load,
		                  RenderBufferStoreAction__Enum_Store,
		                  (Color *)&v362,
		                  0,
		                  0LL);
		              }
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                (TextureHandle *)&desc,
		                &v374,
		                &v10->fields.m_depthWithWaterTexture,
		                DepthAccess__Enum_Write,
		                RenderBufferLoadAction__Enum_Load,
		                RenderBufferStoreAction__Enum_Store,
		                1.0,
		                0,
		                0,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		              HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                &v374,
		                (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterTessellationRenderFuncV2,
		                0LL,
		                0,
		                MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            }
		            catch ( Il2CppExceptionWrapper *v405 )
		            {
		              v372.handle = (ResourceHandle)v405->ex;
		              sub_180268AE0(&v372);
		              sub_180269330(&v366);
		              v7 = (Object *)renderGraph;
		              v10 = this;
		              v362.m_SpaceInfo.m_KeywordSpace = (void *)v371[0];
		              RealLODNum = SupportedFormatForDepth;
		              depthBits[0] = height;
		              v139 = width;
		LABEL_213:
		              ++v139;
		              continue;
		            }
		            sub_180268AE0(&v372);
		            sub_180269330(&v366);
		          }
		          break;
		        }
		        v10->fields.m_frameIndexV2 = ((unsigned __int8)v10->fields.m_frameIndexV2 + 1) & 0x3F;
		        v10->fields.m_isFirstTimeV2 = 0;
		        sub_180269330(v380);
		      }
		      else
		      {
		        v74 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0x41u,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          (HGRenderGraphBuilder *)&viewProj,
		          (HGRenderGraph *)v7,
		          (String *)"Water Tessellation",
		          &v360,
		          v74,
		          1,
		          ProfilingHGPass__Enum_None,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		        *(_OWORD *)&v378.m_RenderPass = *(_OWORD *)&viewProj.m00;
		        *(_OWORD *)&v378.m_RenderGraph = *(_OWORD *)&viewProj.m01;
		        v371[0] = 0LL;
		        v371[1] = &v378;
		        try
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v378, 0, 0LL);
		          v76 = v360;
		          if ( !v360 )
		            sub_1800D8250(v75, 0LL);
		          v360[1].klass = v13;
		          if ( dword_18F35FD08 )
		          {
		            v77 = ((unsigned __int64)&v76[1] >> 12) & 0x1FFFFF;
		            v78 = v77 >> 6;
		            v76 = (Object *)(v77 & 0x3F);
		            _m_prefetchw(&qword_18F0BCBA0[v78 + 36190]);
		            do
		            {
		              v75 = qword_18F0BCBA0[v78 + 36190] | (1LL << (char)v76);
		              v79 = qword_18F0BCBA0[v78 + 36190];
		            }
		            while ( v79 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v78 + 36190], v75, v79) );
		          }
		          v80 = (Object__Class *)v10->fields.m_cbHandle.ptr;
		          v81 = v360;
		          if ( !v360 )
		            sub_1800D8250(v75, v76);
		          v360[12] = *(Object *)&v10->fields.m_cbHandle.bufferId;
		          v81[13].klass = v80;
		          v82 = v360;
		          v85 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v364, &v378, &sectorTexture, 0LL);
		          if ( !v82 )
		            sub_1800D8250(v84, v83);
		          *(TextureHandle *)&v82[13].monitor = v85;
		          v86 = v360;
		          v89 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   &v364,
		                   &v378,
		                   &interactionTexture,
		                   0LL);
		          if ( !v86 )
		            sub_1800D8250(v88, v87);
		          *(TextureHandle *)&v86[14].monitor = v89;
		          v90 = v360;
		          v91 = (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace;
		          if ( !v362.m_SpaceInfo.m_KeywordSpace )
		            sub_1800D8250(v88, v87);
		          v92 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
		                  (HGWaterGlobalConfig *)v362.m_SpaceInfo.m_KeywordSpace,
		                  0LL);
		          if ( !v90 )
		            sub_1800D8250(v94, v93);
		          v90[9].monitor = (MonitorData *)v92;
		          if ( dword_18F35FD08 )
		          {
		            v95 = (((unsigned __int64)&v90[9].monitor >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v95 + 36190]);
		            do
		              v96 = qword_18F0BCBA0[v95 + 36190];
		            while ( v96 != _InterlockedCompareExchange64(
		                             &qword_18F0BCBA0[v95 + 36190],
		                             v96 | (1LL << (((unsigned __int64)&v90[9].monitor >> 12) & 0x3F)),
		                             v96) );
		          }
		          v97 = v360;
		          v98 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(v91, 0LL);
		          if ( !v97 )
		            sub_1800D8250(v100, v99);
		          v97[10].monitor = (MonitorData *)v98;
		          if ( dword_18F35FD08 )
		          {
		            v101 = (((unsigned __int64)&v97[10].monitor >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v101 + 36190]);
		            do
		              v102 = qword_18F0BCBA0[v101 + 36190];
		            while ( v102 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v101 + 36190],
		                              v102 | (1LL << (((unsigned __int64)&v97[10].monitor >> 12) & 0x3F)),
		                              v102) );
		          }
		          v103 = v360;
		          v104 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(v91, 0LL);
		          if ( !v103 )
		            sub_1800D8250(v106, v105);
		          v103[11].monitor = (MonitorData *)v104;
		          v107 = dword_18F35FD08;
		          if ( dword_18F35FD08 )
		          {
		            v108 = (((unsigned __int64)&v103[11].monitor >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v108 + 36190]);
		            do
		              v109 = qword_18F0BCBA0[v108 + 36190];
		            while ( v109 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v108 + 36190],
		                              v109 | (1LL << (((unsigned __int64)&v103[11].monitor >> 12) & 0x3F)),
		                              v109) );
		            v107 = dword_18F35FD08;
		          }
		          v110 = v360;
		          v111 = (Object__Class *)v10->fields.m_waterTessellationMPB;
		          if ( !v360 )
		            sub_1800D8250(v111, 0LL);
		          v360[9].klass = v111;
		          if ( v107 )
		          {
		            v112 = ((unsigned __int64)&v110[9] >> 12) & 0x1FFFFF;
		            v113 = v112 >> 6;
		            v114 = v112 & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v113 + 36190]);
		            do
		              v115 = qword_18F0BCBA0[v113 + 36190];
		            while ( v115 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v113 + 36190], v115 | (1LL << v114), v115) );
		            v107 = dword_18F35FD08;
		          }
		          v116 = v360;
		          v117 = (MonitorData *)v10->fields.m_waterTessellationMaterial;
		          if ( !v360 )
		            sub_1800D8250(v117, 0LL);
		          v360[7].monitor = v117;
		          if ( v107 )
		          {
		            v118 = ((unsigned __int64)&v116[7].monitor >> 12) & 0x1FFFFF;
		            v119 = v118 >> 6;
		            v116 = (Object *)(v118 & 0x3F);
		            _m_prefetchw(&qword_18F0BCBA0[v119 + 36190]);
		            do
		              v120 = qword_18F0BCBA0[v119 + 36190];
		            while ( v120 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v119 + 36190],
		                              v120 | (1LL << (char)v116),
		                              v120) );
		          }
		          v121 = v10->fields.m_waterTessellationMaterial;
		          if ( !v121 )
		            sub_1800D8250(0LL, v116);
		          v122 = UnityEngine::Material::get_shader(v121, 0LL);
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v398, v122, (String *)"ENABLE_RAIN", 0LL);
		          v124 = v10->fields.m_waterTessellationMaterial;
		          if ( !v124 )
		            sub_1800D8250(0LL, v123);
		          keyword = v398;
		          UnityEngine::Material::SetLocalKeyword_Injected(v124, &keyword, wetnessHighQualityEnabled, 0LL);
		          v126 = v10->fields.m_waterTessellationMaterial;
		          if ( !v126 )
		            sub_1800D8250(0LL, v125);
		          v127 = UnityEngine::Material::get_shader(v126, 0LL);
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v397, v127, (String *)"ENABLE_WATER_RIPPLE", 0LL);
		          v128 = v10->fields.m_waterTessellationMaterial;
		          v129 = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(v363, 0LL);
		          if ( !v128 )
		            sub_1800D8250(v131, v130);
		          keyword = v397;
		          UnityEngine::Material::SetLocalKeyword_Injected(v128, &keyword, v129, 0LL);
		          si128 = 0LL;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v364,
		            &v378,
		            &v10->fields.m_normalRoughnessWithWaterTexture,
		            0,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&si128,
		            0,
		            0LL);
		          si128 = 0LL;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v364,
		            &v378,
		            &v10->fields.m_waterTessellationDataTexture,
		            1,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&si128,
		            0,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		          {
		            si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18DC80F80);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		              &v364,
		              &v378,
		              &input->sceneMV,
		              2,
		              RenderBufferLoadAction__Enum_Load,
		              RenderBufferStoreAction__Enum_Store,
		              (Color *)&si128,
		              0,
		              0LL);
		          }
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            &v364,
		            &v378,
		            &v10->fields.m_depthWithWaterTexture,
		            DepthAccess__Enum_Write,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            1.0,
		            0,
		            0,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v378,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterGBufferRenderFuncV2,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v408 )
		        {
		          v371[0] = v408->ex;
		        }
		        sub_180268AE0(v371);
		        sub_180269330(v380);
		      }
		    }
		    else
		    {
		      HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderFallback(
		        v10,
		        input,
		        output,
		        (HGRenderGraph *)v7,
		        hgCamera,
		        0LL);
		    }
		  }
		}
		
		internal void RenderLighting(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BE6130-0x0000000189BE6C94
		// Void RenderLighting(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderLighting(
		        WaterDefaultDeferredRenderingPass *this,
		        WaterDefaultDeferredRenderingPass_PassInput *input,
		        WaterDefaultDeferredRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object *v6; // r15
		  WaterDefaultDeferredRenderingPass *v9; // rsi
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object__Class *v12; // r13
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  TextureHandle v19; // xmm8
		  TextureHandle m_depthWithWaterTexture; // xmm7
		  ProfilingSampler *v21; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  int v26; // eax
		  unsigned int v27; // edx
		  unsigned __int64 v28; // r8
		  char v29; // dl
		  signed __int64 v30; // rtt
		  __int64 v31; // rdx
		  MaterialPropertyBlock *m_waterDecalDeferredMPB; // rcx
		  unsigned int v33; // edx
		  unsigned __int64 v34; // r8
		  char v35; // dl
		  signed __int64 v36; // rtt
		  TextureHandle *v37; // r14
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  TextureHandle v40; // xmm0
		  TextureHandle *v41; // r14
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  TextureHandle v44; // xmm0
		  RenderFunc_1_HG_Rendering_Runtime_WaterDefaultDeferredRenderingPass_PassData_ *_9__51_0; // r14
		  Object *v46; // r12
		  RenderFunc_1_System_Object_ *v47; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  unsigned __int64 v50; // rdx
		  unsigned __int64 v51; // r8
		  signed __int64 v52; // rtt
		  ProfilingSampler *v53; // rax
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  Object__Class *ptr; // xmm1_8
		  Object *v59; // rax
		  Object *v60; // rdx
		  unsigned __int64 v61; // rdx
		  unsigned __int64 v62; // r8
		  char v63; // dl
		  signed __int64 v64; // rtt
		  Object *v65; // r14
		  __int64 v66; // rdx
		  __int64 v67; // rcx
		  TextureHandle v68; // xmm0
		  Object *v69; // r14
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  TextureHandle v72; // xmm0
		  Object *v73; // r14
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  TextureHandle v76; // xmm0
		  Object *v77; // r14
		  __int64 v78; // rdx
		  __int64 v79; // rcx
		  TextureHandle v80; // xmm0
		  Object *v81; // r14
		  __int64 v82; // rdx
		  __int64 v83; // rcx
		  TextureHandle v84; // xmm0
		  Object *v85; // r14
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  TextureHandle v88; // xmm0
		  Object *v89; // r14
		  Texture2D *causticMap; // rax
		  unsigned __int64 v91; // rdx
		  __int64 v92; // rcx
		  int v93; // eax
		  unsigned __int64 v94; // r8
		  signed __int64 v95; // rtt
		  Object *v96; // r8
		  Object__Class *m_renderingMaterial; // rcx
		  unsigned __int64 v98; // r8
		  unsigned __int64 v99; // r9
		  char v100; // r8
		  signed __int64 v101; // rtt
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v103; // rdx
		  __int64 v104; // rcx
		  __m128i v105; // xmm6
		  Material *v106; // rcx
		  Shader *shader; // rax
		  __int64 v108; // rdx
		  Material *v109; // rcx
		  bool v110; // r8
		  __int64 v111; // rcx
		  Object *v112; // rdx
		  unsigned __int64 v113; // rdx
		  unsigned __int64 v114; // r8
		  char v115; // dl
		  signed __int64 v116; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v118; // rdx
		  __int64 v119; // rcx
		  Object *v120; // [rsp+50h] [rbp-1C8h] BYREF
		  __int64 v121; // [rsp+58h] [rbp-1C0h] BYREF
		  Rect v122; // [rsp+60h] [rbp-1B8h] BYREF
		  HGRenderGraphBuilder keyword; // [rsp+70h] [rbp-1A8h] BYREF
		  TextureHandle v124; // [rsp+90h] [rbp-188h] BYREF
		  HGRenderGraphBuilder v125; // [rsp+A0h] [rbp-178h] BYREF
		  HGRenderGraphBuilder v126; // [rsp+C0h] [rbp-158h] BYREF
		  HGWaterGlobalConfig *globalConfig; // [rsp+E0h] [rbp-138h]
		  TextureHandle v128; // [rsp+F0h] [rbp-128h] BYREF
		  LocalKeyword v129; // [rsp+100h] [rbp-118h] BYREF
		  Il2CppExceptionWrapper *v130; // [rsp+118h] [rbp-100h] BYREF
		  Il2CppExceptionWrapper *v131; // [rsp+120h] [rbp-F8h] BYREF
		
		  v6 = (Object *)renderGraph;
		  v9 = this;
		  memset(&v126, 0, sizeof(v126));
		  v121 = 0LL;
		  memset(&v125, 0, sizeof(v125));
		  v120 = 0LL;
		  memset(&v129, 0, sizeof(v129));
		  if ( IFix::WrappersManagerImpl::IsPatched(3512, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3512, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v119, v118);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1256(Patch, (Object *)v9, input, output, v6, (Object *)hgCamera, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::UpdateWaterQualityKeywords(v9, 0LL);
		    v12 = (Object__Class *)hgCamera;
		    if ( !hgCamera )
		      sub_1800D8260(v11, v10);
		    if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL) )
		    {
		      if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		        sub_1800D8260(v14, v13);
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( !currentManagerContext )
		        sub_1800D8260(v17, v16);
		      if ( !currentManagerContext->fields._waterManager_k__BackingField )
		        sub_1800D8260(v17, v16);
		      globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig(
		                       currentManagerContext->fields._waterManager_k__BackingField,
		                       0LL);
		      sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v19 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
		               (TextureHandle *)&keyword,
		               (HGRenderGraph *)v6,
		               sceneRTSize_k__BackingField,
		               0LL);
		      v128 = v19;
		      m_depthWithWaterTexture = v9->fields.m_depthWithWaterTexture;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		      v122 = 0LL;
		      v124 = v19;
		      *(TextureHandle *)&keyword.m_RenderPass = m_depthWithWaterTexture;
		      HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		        (HGRenderGraph *)v6,
		        (TextureHandle *)&keyword,
		        &v124,
		        0,
		        -1,
		        0,
		        &v122,
		        0,
		        0LL);
		      if ( hgCamera->fields.waterDecalVisibleCount )
		      {
		        v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0x3Cu,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        if ( !v6 )
		          sub_1800D8260(v23, v22);
		        v126 = *(HGRenderGraphBuilder *)sub_1808AFC44(
		                                          (unsigned int)&keyword,
		                                          (_DWORD)v6,
		                                          (unsigned int)"WaterLighting",
		                                          (unsigned int)&v121,
		                                          (__int64)v21);
		        *(_QWORD *)&v122.m_XMin = 0LL;
		        *(_QWORD *)&v122.m_Width = &v126;
		        try
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v126, 0, 0LL);
		          v25 = v121;
		          if ( !v121 )
		            sub_1800D8250(v24, 0LL);
		          *(_QWORD *)(v121 + 16) = hgCamera;
		          v26 = dword_18F35FD08;
		          if ( dword_18F35FD08 )
		          {
		            v27 = ((unsigned __int64)(v25 + 16) >> 12) & 0x1FFFFF;
		            v28 = (unsigned __int64)v27 >> 6;
		            v29 = v27 & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v28 + 36190]);
		            do
		              v30 = qword_18F0BCBA0[v28 + 36190];
		            while ( v30 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v28 + 36190], v30 | (1LL << v29), v30) );
		            v26 = dword_18F35FD08;
		          }
		          v31 = v121;
		          m_waterDecalDeferredMPB = v9->fields.m_waterDecalDeferredMPB;
		          if ( !v121 )
		            sub_1800D8250(m_waterDecalDeferredMPB, 0LL);
		          *(_QWORD *)(v121 + 96) = m_waterDecalDeferredMPB;
		          if ( v26 )
		          {
		            v33 = ((unsigned __int64)(v31 + 96) >> 12) & 0x1FFFFF;
		            v34 = (unsigned __int64)v33 >> 6;
		            v35 = v33 & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v34 + 36190]);
		            do
		              v36 = qword_18F0BCBA0[v34 + 36190];
		            while ( v36 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v34 + 36190], v36 | (1LL << v35), v36) );
		          }
		          v37 = (TextureHandle *)v121;
		          v40 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&keyword,
		                   &v126,
		                   &v128,
		                   0LL);
		          if ( !v37 )
		            sub_1800D8250(v39, v38);
		          v37[38] = v40;
		          v41 = (TextureHandle *)v121;
		          v44 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&keyword,
		                   &v126,
		                   &v9->fields.m_normalRoughnessWithWaterTexture,
		                   0LL);
		          if ( !v41 )
		            sub_1800D8250(v43, v42);
		          v41[35] = v44;
		          *(_OWORD *)&keyword.m_RenderPass = 0LL;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v124,
		            &v126,
		            &v9->fields.m_waterTessellationDataTexture,
		            0,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&keyword,
		            0,
		            0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            (TextureHandle *)&keyword,
		            &v126,
		            &v9->fields.m_depthWithWaterTexture,
		            DepthAccess__Enum_Read,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_DontCare,
		            1.0,
		            0,
		            0,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c);
		          _9__51_0 = TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c->static_fields->__9__51_0;
		          if ( !_9__51_0 )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c);
		            v46 = (Object *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c->static_fields->__9;
		            v47 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		            _9__51_0 = (RenderFunc_1_HG_Rendering_Runtime_WaterDefaultDeferredRenderingPass_PassData_ *)v47;
		            if ( !v47 )
		              sub_1800D8250(v49, v48);
		            HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		              v47,
		              v46,
		              MethodInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c::_RenderLighting_b__51_0,
		              0LL);
		            TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c->static_fields->__9__51_0 = _9__51_0;
		            if ( dword_18F35FD08 )
		            {
		              v50 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c->static_fields->__9__51_0 >> 12) & 0x1FFFFF) >> 6;
		              v51 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::__c->static_fields->__9__51_0 >> 12) & 0x3F;
		              _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		              do
		                v52 = qword_18F0BCBA0[v50 + 36190];
		              while ( v52 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v52 | (1LL << v51), v52) );
		            }
		          }
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v126,
		            (RenderFunc_1_System_Object_ *)_9__51_0,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v130 )
		        {
		          *(Il2CppExceptionWrapper *)&v122.m_XMin = (Il2CppExceptionWrapper)v130->ex;
		          sub_180268AE0(&v122);
		          v12 = (Object__Class *)hgCamera;
		          v6 = (Object *)renderGraph;
		          v9 = this;
		          goto LABEL_28;
		        }
		        sub_180268AE0(&v122);
		      }
		LABEL_28:
		      v53 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x42u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		        sub_1800D8250(v55, v54);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &keyword,
		        (HGRenderGraph *)v6,
		        (String *)"WaterLighting",
		        &v120,
		        v53,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		      v125 = keyword;
		      *(_QWORD *)&v122.m_XMin = 0LL;
		      *(_QWORD *)&v122.m_Width = &v125;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v125, 0, 0LL);
		        ptr = (Object__Class *)v9->fields.m_cbHandle.ptr;
		        v59 = v120;
		        if ( !v120 )
		          sub_1800D8250(v57, v56);
		        v120[12] = *(Object *)&v9->fields.m_cbHandle.bufferId;
		        v59[13].klass = ptr;
		        v60 = v120;
		        if ( !v120 )
		          sub_1800D8250(v57, 0LL);
		        v120[1].klass = v12;
		        if ( dword_18F35FD08 )
		        {
		          v61 = ((unsigned __int64)&v60[1] >> 12) & 0x1FFFFF;
		          v62 = v61 >> 6;
		          v63 = v61 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v62 + 36190]);
		          do
		            v64 = qword_18F0BCBA0[v62 + 36190];
		          while ( v64 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v62 + 36190], v64 | (1LL << v63), v64) );
		        }
		        v65 = v120;
		        v68 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&keyword,
		                 &v125,
		                 &input->sceneDepthCopied,
		                 0LL);
		        if ( !v65 )
		          sub_1800D8250(v67, v66);
		        v65[37] = (Object)v68;
		        v69 = v120;
		        v72 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&keyword,
		                 &v125,
		                 &v128,
		                 0LL);
		        if ( !v69 )
		          sub_1800D8250(v71, v70);
		        v69[38] = (Object)v72;
		        v73 = v120;
		        v76 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&keyword,
		                 &v125,
		                 &v9->fields.m_normalRoughnessWithWaterTexture,
		                 0LL);
		        if ( !v73 )
		          sub_1800D8250(v75, v74);
		        v73[35] = (Object)v76;
		        v77 = v120;
		        v80 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&keyword,
		                 &v125,
		                 &input->deferredSSRLightingTexture,
		                 0LL);
		        if ( !v77 )
		          sub_1800D8250(v79, v78);
		        v77[39] = (Object)v80;
		        v81 = v120;
		        v84 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&keyword,
		                 &v125,
		                 &input->ssrFadenessTexture,
		                 0LL);
		        if ( !v81 )
		          sub_1800D8250(v83, v82);
		        v81[40] = (Object)v84;
		        v85 = v120;
		        v88 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&keyword,
		                 &v125,
		                 &v9->fields.m_waterTessellationDataTexture,
		                 0LL);
		        if ( !v85 )
		          sub_1800D8250(v87, v86);
		        v85[41] = (Object)v88;
		        v89 = v120;
		        if ( !globalConfig )
		          sub_1800D8250(0LL, v86);
		        causticMap = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(globalConfig, 0LL);
		        if ( !v89 )
		          sub_1800D8250(v92, v91);
		        v89[10].klass = (Object__Class *)causticMap;
		        v93 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v94 = (((unsigned __int64)&v89[10] >> 12) & 0x1FFFFF) >> 6;
		          v91 = ((unsigned __int64)&v89[10] >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v94 + 36190]);
		          do
		            v95 = qword_18F0BCBA0[v94 + 36190];
		          while ( v95 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v94 + 36190], v95 | (1LL << v91), v95) );
		          v93 = dword_18F35FD08;
		        }
		        v96 = v120;
		        m_renderingMaterial = (Object__Class *)v9->fields.m_renderingMaterial;
		        if ( !v120 )
		          sub_1800D8250(m_renderingMaterial, v91);
		        v120[5].klass = m_renderingMaterial;
		        if ( v93 )
		        {
		          v98 = ((unsigned __int64)&v96[5] >> 12) & 0x1FFFFF;
		          v99 = v98 >> 6;
		          v100 = v98 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v99 + 36190]);
		          do
		            v101 = qword_18F0BCBA0[v99 + 36190];
		          while ( v101 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v99 + 36190], v101 | (1LL << v100), v101) );
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase((HGCamera *)v12, 0LL);
		        if ( !InterpolatedPhase )
		          sub_1800D8250(v104, v103);
		        v105 = *(__m128i *)&InterpolatedPhase->fields.inkSimulationConfig.influence;
		        v106 = v9->fields.m_renderingMaterial;
		        if ( !v106 )
		          sub_1800D8250(0LL, v103);
		        shader = UnityEngine::Material::get_shader(v106, 0LL);
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v129, shader, (String *)"ENABLE_INK_RENDER", 0LL);
		        v109 = v9->fields.m_renderingMaterial;
		        v110 = *(float *)v105.m128i_i32 > 0.0 && (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v105, 8)) == 0;
		        if ( !v109 )
		          sub_1800D8250(0LL, v108);
		        *(_OWORD *)&keyword.m_RenderPass = *(_OWORD *)&v129.m_SpaceInfo.m_KeywordSpace;
		        keyword.m_RenderGraph = *(HGRenderGraph **)&v129.m_Index;
		        UnityEngine::Material::SetLocalKeyword_Injected(v109, (LocalKeyword *)&keyword, v110, 0LL);
		        v112 = v120;
		        if ( !v120 )
		          sub_1800D8250(v111, 0LL);
		        v120[7].klass = (Object__Class *)v9->fields.m_waterLightingMPB;
		        if ( dword_18F35FD08 )
		        {
		          v113 = ((unsigned __int64)&v112[7] >> 12) & 0x1FFFFF;
		          v114 = v113 >> 6;
		          v115 = v113 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v114 + 36190]);
		          do
		            v116 = qword_18F0BCBA0[v114 + 36190];
		          while ( v116 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v114 + 36190], v116 | (1LL << v115), v116) );
		        }
		        *(__m128i *)&keyword.m_RenderPass = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v128,
		          &v125,
		          &input->sceneColor,
		          0,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&keyword,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&keyword,
		          &v125,
		          &v9->fields.m_depthWithWaterTexture,
		          DepthAccess__Enum_Read,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_DontCare,
		          1.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v125,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterLightingRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v131 )
		      {
		        *(Il2CppExceptionWrapper *)&v122.m_XMin = (Il2CppExceptionWrapper)v131->ex;
		      }
		      sub_180268AE0(&v122);
		    }
		  }
		}
		
		internal void RenderFallback(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BE5F8C-0x0000000189BE6130
		// Void RenderFallback(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderFallback(
		        WaterDefaultDeferredRenderingPass *this,
		        WaterDefaultDeferredRenderingPass_PassInput *input,
		        WaterDefaultDeferredRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // [rsp+40h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v17; // [rsp+48h] [rbp-50h] BYREF
		  _QWORD v18[4]; // [rsp+50h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v19; // [rsp+70h] [rbp-28h] BYREF
		
		  memset(&v19, 0, sizeof(v19));
		  v16 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3510, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3510, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1256(
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
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x44u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v19 = *(HGRenderGraphBuilder *)sub_1808AFC44(
		                                     (unsigned int)v18,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"Water Fallback",
		                                     (unsigned int)&v16,
		                                     (__int64)v10);
		    v18[0] = 0LL;
		    v18[1] = &v19;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v19, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v19,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_RenderFallbackFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      v18[0] = v17->ex;
		    }
		    sub_180268AE0(v18);
		  }
		}
		
		internal void RenderWaterWetnessMask(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, [IsReadOnly] in GBufferOutput gbufferOutput) {} // 0x0000000189BEA2A0-0x0000000189BEAB7C
		// Void RenderWaterWetnessMask(WaterDefaultDeferredRenderingPass+PassInput ByRef, WaterDefaultDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, GBufferOutput ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderWaterWetnessMask(
		        WaterDefaultDeferredRenderingPass *this,
		        WaterDefaultDeferredRenderingPass_PassInput *input,
		        WaterDefaultDeferredRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        GBufferOutput *gbufferOutput,
		        MethodInfo *method)
		{
		  bool v11; // r13
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  bool IsCompoundRendererListDrawable; // r12
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  uint32_t cullingViewHandle; // r15d
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  HGRenderGraphContext *HGContext; // r14
		  uint32_t v21; // r15d
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  HGRenderGraphContext *v24; // r14
		  uint32_t v25; // r15d
		  bool v26; // dl
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v27; // rdx
		  VolumetricRenderer_VolumetricBounds *v28; // r8
		  Int32__Array **v29; // r9
		  ProfilingSampler *v30; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  __int64 v33; // r8
		  int v34; // eax
		  unsigned __int64 v35; // r8
		  unsigned __int64 v36; // r9
		  char v37; // r8
		  signed __int64 v38; // rtt
		  __int64 v39; // r8
		  Material *m_waterProxyMaterial; // rcx
		  unsigned __int64 v41; // r8
		  unsigned __int64 v42; // r9
		  char v43; // r8
		  signed __int64 v44; // rtt
		  __int64 v45; // r8
		  MaterialPropertyBlock *m_waterProxyMPB; // rcx
		  unsigned __int64 v47; // r8
		  unsigned __int64 v48; // r9
		  char v49; // r8
		  signed __int64 v50; // rtt
		  __int64 v51; // r8
		  Texture3D *m_wetnessMask3DNoise; // rcx
		  unsigned __int64 v53; // r8
		  unsigned __int64 v54; // r9
		  char v55; // r8
		  signed __int64 v56; // rtt
		  __int64 v57; // rsi
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  TextureHandle v60; // xmm0
		  __int64 v61; // rsi
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  TextureHandle v64; // xmm0
		  __int64 v65; // rcx
		  TextureHandle *v66; // rbx
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  TextureHandle v69; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-1E8h]
		  MethodInfo *globalKeywordsa; // [rsp+20h] [rbp-1E8h]
		  bool context; // [rsp+28h] [rbp-1E0h]
		  int32_t drawableFeedbackPtr; // [rsp+30h] [rbp-1D8h]
		  int32_t multiDraw; // [rsp+38h] [rbp-1D0h]
		  float transparentSorting; // [rsp+40h] [rbp-1C8h]
		  int32_t v79; // [rsp+48h] [rbp-1C0h]
		  bool noAlphaTest; // [rsp+50h] [rbp-1B8h]
		  bool excludeGPUDriven; // [rsp+58h] [rbp-1B0h]
		  MethodInfo *v82; // [rsp+60h] [rbp-1A8h]
		  bool ShouldRenderWater; // [rsp+70h] [rbp-198h]
		  __int64 v84; // [rsp+78h] [rbp-190h] BYREF
		  TextureHandle si128; // [rsp+80h] [rbp-188h] BYREF
		  uint32_t RendererList; // [rsp+90h] [rbp-178h]
		  TextureHandle v87; // [rsp+98h] [rbp-170h] BYREF
		  void *outPtr; // [rsp+A8h] [rbp-160h] BYREF
		  void *v89; // [rsp+B0h] [rbp-158h] BYREF
		  TextureHandle v90; // [rsp+B8h] [rbp-150h] BYREF
		  HGRenderGraphBuilder v91; // [rsp+C8h] [rbp-140h] BYREF
		  GBufferOutput v92; // [rsp+E8h] [rbp-120h] BYREF
		  TextureDesc v93; // [rsp+110h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v94; // [rsp+170h] [rbp-98h] BYREF
		  TextureDesc v95; // [rsp+180h] [rbp-88h] BYREF
		
		  sub_18033B9D0(&v93, 0LL, 96LL);
		  memset(&v91, 0, sizeof(v91));
		  v11 = 0;
		  v84 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3526, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3526, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v72, v71);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      gbufferOutput,
		      0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      sub_1800D8260(v13, v12);
		    hgCamera->fields.useWetnessMask = 0;
		    IsCompoundRendererListDrawable = 0;
		    if ( this->fields.m_decalFeedbackID )
		    {
		      IsCompoundRendererListDrawable = UnityEngine::HyperGryph::HGGraphicsUtils::IsCompoundRendererListDrawable(
		                                         this->fields.m_decalFeedbackID,
		                                         0LL);
		      hgCamera->fields.useWetnessMask = IsCompoundRendererListDrawable || hgCamera->fields.useWetnessMask;
		    }
		    outPtr = 0LL;
		    this->fields.m_decalFeedbackID = UnityEngine::HyperGryph::HGGraphicsUtils::AllocateTempCompoundRendererListFromScript(
		                                       &outPtr,
		                                       0LL);
		    cullingViewHandle = hgCamera->fields.cullingViewHandle;
		    if ( !renderGraph )
		      sub_1800D8260(v16, v15);
		    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		    if ( !HGContext )
		      sub_1800D8260(v19, v18);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    RendererList = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
		                     cullingViewHandle,
		                     0x10000u,
		                     HGContext->fields.renderContext.m_Ptr,
		                     (uint32_t *)outPtr,
		                     0LL);
		    if ( this->fields.m_objFeedbackID )
		    {
		      v11 = UnityEngine::HyperGryph::HGGraphicsUtils::IsCompoundRendererListDrawable(this->fields.m_objFeedbackID, 0LL);
		      hgCamera->fields.useWetnessMask = v11 || hgCamera->fields.useWetnessMask;
		    }
		    v89 = 0LL;
		    this->fields.m_objFeedbackID = UnityEngine::HyperGryph::HGGraphicsUtils::AllocateTempCompoundRendererListFromScript(
		                                     &v89,
		                                     0LL);
		    v21 = hgCamera->fields.cullingViewHandle;
		    v24 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		    if ( !v24 )
		      sub_1800D8260(v23, v22);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    LOWORD(globalKeywords) = 0;
		    v25 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		            v21,
		            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		            HGRenderFlags__Enum_Transparent,
		            HGShaderLightMode__Enum_WetnessDecal,
		            globalKeywords,
		            v24->fields.renderContext.m_Ptr,
		            v89,
		            0,
		            0,
		            0xFFFFFFFF,
		            0,
		            0,
		            0LL);
		    ShouldRenderWater = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
		    v26 = ShouldRenderWater || hgCamera->fields.useWetnessMask;
		    hgCamera->fields.useWetnessMask = v26;
		    if ( v26 )
		    {
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v93,
		        hgCamera->fields._sceneRTSize_k__BackingField,
		        0LL);
		      v93.name = (String *)"Water Wetness Mask Texture";
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&v93.name,
		        v27,
		        v28,
		        v29,
		        globalKeywordsa,
		        context,
		        drawableFeedbackPtr,
		        multiDraw,
		        transparentSorting,
		        v79,
		        noAlphaTest,
		        excludeGPUDriven,
		        v82);
		      v93.colorFormat = 6;
		      *(_WORD *)&v93.useMipMap = 0;
		      v95 = v93;
		      this->fields.m_waterWetnessMaskTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                  &v90,
		                                                  renderGraph,
		                                                  &v95,
		                                                  0LL);
		      v30 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x47u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      v91 = *(HGRenderGraphBuilder *)sub_1808AFC44(
		                                       (unsigned int)&v92,
		                                       (_DWORD)renderGraph,
		                                       (unsigned int)"Water Wetness Mask",
		                                       (unsigned int)&v84,
		                                       (__int64)v30);
		      v90.handle = 0LL;
		      v90.fallBackResource = (ResourceHandle)&v91;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v91, 0, 0LL);
		        v33 = v84;
		        if ( !v84 )
		          sub_1800D8250(v32, v31);
		        *(_QWORD *)(v84 + 16) = hgCamera;
		        v34 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v35 = ((unsigned __int64)(v33 + 16) >> 12) & 0x1FFFFF;
		          v36 = v35 >> 6;
		          v37 = v35 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v36 + 36190]);
		          do
		            v38 = qword_18F0BCBA0[v36 + 36190];
		          while ( v38 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v36 + 36190], v38 | (1LL << v37), v38) );
		          v34 = dword_18F35FD08;
		        }
		        v39 = v84;
		        m_waterProxyMaterial = this->fields.m_waterProxyMaterial;
		        if ( !v84 )
		          sub_1800D8250(m_waterProxyMaterial, qword_18F0BCBA0);
		        *(_QWORD *)(v84 + 64) = m_waterProxyMaterial;
		        if ( v34 )
		        {
		          v41 = ((unsigned __int64)(v39 + 64) >> 12) & 0x1FFFFF;
		          v42 = v41 >> 6;
		          v43 = v41 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v42 + 36190]);
		          do
		            v44 = qword_18F0BCBA0[v42 + 36190];
		          while ( v44 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v42 + 36190], v44 | (1LL << v43), v44) );
		          v34 = dword_18F35FD08;
		        }
		        v45 = v84;
		        m_waterProxyMPB = this->fields.m_waterProxyMPB;
		        if ( !v84 )
		          sub_1800D8250(m_waterProxyMPB, qword_18F0BCBA0);
		        *(_QWORD *)(v84 + 88) = m_waterProxyMPB;
		        if ( v34 )
		        {
		          v47 = ((unsigned __int64)(v45 + 88) >> 12) & 0x1FFFFF;
		          v48 = v47 >> 6;
		          v49 = v47 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		          do
		            v50 = qword_18F0BCBA0[v48 + 36190];
		          while ( v50 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v48 + 36190], v50 | (1LL << v49), v50) );
		          v34 = dword_18F35FD08;
		        }
		        if ( !v84 )
		          sub_1800D8250(0LL, qword_18F0BCBA0);
		        *(TextureHandle *)(v84 + 296) = this->fields.m_waterWetnessMaskTexture;
		        v51 = v84;
		        m_wetnessMask3DNoise = this->fields.m_wetnessMask3DNoise;
		        if ( !v84 )
		          sub_1800D8250(m_wetnessMask3DNoise, qword_18F0BCBA0);
		        *(_QWORD *)(v84 + 176) = m_wetnessMask3DNoise;
		        if ( v34 )
		        {
		          v53 = ((unsigned __int64)(v51 + 176) >> 12) & 0x1FFFFF;
		          v54 = v53 >> 6;
		          v55 = v53 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v54 + 36190]);
		          do
		            v56 = qword_18F0BCBA0[v54 + 36190];
		          while ( v56 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v54 + 36190], v56 | (1LL << v55), v56) );
		        }
		        v57 = v84;
		        v92 = *gbufferOutput;
		        si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                   &si128,
		                   &v92,
		                   GBufferID__Enum_GBufferA,
		                   0LL);
		        v60 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v87, &v91, &si128, 0LL);
		        if ( !v57 )
		          sub_1800D8250(v59, v58);
		        *(TextureHandle *)(v57 + 312) = v60;
		        v61 = v84;
		        v92 = *gbufferOutput;
		        si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v87, &v92, GBufferID__Enum_GBufferB, 0LL);
		        v64 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v87, &v91, &si128, 0LL);
		        if ( !v61 )
		          sub_1800D8250(v63, v62);
		        *(TextureHandle *)(v61 + 328) = v64;
		        if ( !v84 )
		          sub_1800D8250(v63, v62);
		        v65 = RendererList;
		        *(_DWORD *)(v84 + 672) = RendererList;
		        if ( !v84 )
		          sub_1800D8250(v65, v62);
		        *(_DWORD *)(v84 + 676) = v25;
		        v66 = (TextureHandle *)v84;
		        v69 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 &v87,
		                 &v91,
		                 &input->sceneDepthCopied,
		                 0LL);
		        if ( !v66 )
		          sub_1800D8250(v68, v67);
		        v66[37] = v69;
		        if ( !v84 )
		          sub_1800D8250(v68, v67);
		        *(_BYTE *)(v84 + 680) = IsCompoundRendererListDrawable;
		        if ( !v84 )
		          sub_1800D8250(v68, v67);
		        *(_BYTE *)(v84 + 681) = v11;
		        if ( !v84 )
		          sub_1800D8250(v68, v67);
		        *(_BYTE *)(v84 + 682) = ShouldRenderWater;
		        si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959780);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v87,
		          &v91,
		          &this->fields.m_waterWetnessMaskTexture,
		          0,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&si128,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          &v87,
		          &v91,
		          &input->sceneDepth,
		          DepthAccess__Enum_Read,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          0.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v91,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass->static_fields->s_waterWetnessMaskRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v94 )
		      {
		        v90.handle = (ResourceHandle)v94->ex;
		      }
		      sub_180268AE0(&v90);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_waterWetnessMaskTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                  &v87,
		                                                  0LL);
		    }
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BE5F38-0x0000000189BE5F8C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        WaterDefaultDeferredRenderingPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3527, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3527, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BE5EE4-0x0000000189BE5F38
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        WaterDefaultDeferredRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3528, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3528, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BE5E90-0x0000000189BE5EE4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        WaterDefaultDeferredRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3529, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3529, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D5D1E0-0x0000000184D5D230
	}
}
