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
	public class WaterOnePassDeferredRenderingPass : IPassConstructor // TypeDefIndex: 38508
	{
		// Fields
		private bool m_isRendering; // 0x10
		private uint m_cullHandle; // 0x14
		private int m_waterVRRx; // 0x18
		private int m_waterVRRy; // 0x1C
		private CBHandle m_cbHandle; // 0x20
		private TextureHandle m_sectorTexture; // 0x38
		private TextureHandle m_interactionTexture; // 0x48
		private TextureHandle m_lowSceneDepthTexture; // 0x58
		private TextureHandle m_previousReflectLightingTexture; // 0x68
		private TextureHandle m_reflectLightingTexture; // 0x78
		private TextureHandle m_reflectFadenessTexture; // 0x88
		private TextureHandle m_gBufferATexture; // 0x98
		private TextureHandle m_gBufferMVTexture; // 0xA8
		private TextureHandle m_prepassDepthTexture; // 0xB8
		private Texture2D m_globalFlowmapTexture; // 0xC8
		private Texture2D m_globalCausticTexture; // 0xD0
		private Texture2DArray m_globalNormalTextureArray; // 0xD8
		private MaterialPropertyBlock m_mpb; // 0xE0
		private Material m_waterRenderingMaterial; // 0xE8
		private static readonly RenderFunc<PassData> s_depthDownsampleRenderFunc; // 0x00
		private static readonly RenderFunc<PassData> s_waterReflectiLightingRenderFunc; // 0x08
		private static readonly RenderFunc<PassData> s_RenderFallbackFunc; // 0x10
	
		// Properties
		public int waterVRRx { get => default; } // 0x0000000189BEDEC8-0x0000000189BEDF14 
		// Int32 get_waterVRRx()
		int32_t HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_waterVRRx(
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3531, 0LL) )
		    return this->fields.m_waterVRRx;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3531, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int waterVRRy { get => default; } // 0x0000000189BEDF14-0x0000000189BEDF60 
		// Int32 get_waterVRRy()
		int32_t HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_waterVRRy(
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3532, 0LL) )
		    return this->fields.m_waterVRRy;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3532, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public CBHandle cbHandle { get => default; } // 0x0000000189BEDB2C-0x0000000189BEDBA0 
		// CBHandle get_cbHandle()
		CBHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_cbHandle(
		        CBHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  void *ptr; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  CBHandle *v10; // rax
		  CBHandle *result; // rax
		  CBHandle v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3533, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3533, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1260(&v12, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v10->bufferId;
		    ptr = v10->ptr;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_cbHandle.bufferId;
		    ptr = this->fields.m_cbHandle.ptr;
		  }
		  *(_OWORD *)&retstr->bufferId = v5;
		  result = retstr;
		  retstr->ptr = ptr;
		  return result;
		}
		
		public TextureHandle sectorTexture { get => default; } // 0x0000000189BEDE10-0x0000000189BEDE78 
		// TextureHandle get_sectorTexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_sectorTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_sectorTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3534, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3534, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_sectorTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_sectorTexture = this->fields.m_sectorTexture;
		  }
		  result = retstr;
		  *retstr = m_sectorTexture;
		  return result;
		}
		
		public TextureHandle interactionTexture { get => default; } // 0x0000000189BEDC70-0x0000000189BEDCD8 
		// TextureHandle get_interactionTexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_interactionTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_interactionTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3535, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3535, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_interactionTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_interactionTexture = this->fields.m_interactionTexture;
		  }
		  result = retstr;
		  *retstr = m_interactionTexture;
		  return result;
		}
		
		public TextureHandle reflectionLightingTexture { get => default; set {} } // 0x0000000189BEDDA8-0x0000000189BEDE10 0x0000000189BEDF60-0x0000000189BEDFC8
		// TextureHandle get_reflectionLightingTexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_reflectionLightingTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_reflectLightingTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3536, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3536, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_reflectLightingTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_reflectLightingTexture = this->fields.m_reflectLightingTexture;
		  }
		  result = retstr;
		  *retstr = m_reflectLightingTexture;
		  return result;
		}
		

		// Void set_reflectionLightingTexture(TextureHandle)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::set_reflectionLightingTexture(
		        WaterOnePassDeferredRenderingPass *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3537, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3537, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = *value;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_146(Patch, (Object *)this, &v8, 0LL);
		  }
		  else
		  {
		    this->fields.m_reflectLightingTexture = *value;
		  }
		}
		
		public TextureHandle reflectionFadenessTexture { get => default; } // 0x0000000189BEDD40-0x0000000189BEDDA8 
		// TextureHandle get_reflectionFadenessTexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_reflectionFadenessTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_reflectFadenessTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3538, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3538, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_reflectFadenessTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_reflectFadenessTexture = this->fields.m_reflectFadenessTexture;
		  }
		  result = retstr;
		  *retstr = m_reflectFadenessTexture;
		  return result;
		}
		
		public TextureHandle gBufferATexture { get => default; } // 0x0000000189BEDBA0-0x0000000189BEDC08 
		// TextureHandle get_gBufferATexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_gBufferATexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_gBufferATexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3539, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3539, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_gBufferATexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_gBufferATexture = this->fields.m_gBufferATexture;
		  }
		  result = retstr;
		  *retstr = m_gBufferATexture;
		  return result;
		}
		
		public TextureHandle gBufferMVTexture { get => default; } // 0x0000000189BEDC08-0x0000000189BEDC70 
		// TextureHandle get_gBufferMVTexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_gBufferMVTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_gBufferMVTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3540, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3540, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_gBufferMVTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_gBufferMVTexture = this->fields.m_gBufferMVTexture;
		  }
		  result = retstr;
		  *retstr = m_gBufferMVTexture;
		  return result;
		}
		
		public TextureHandle prepassDepthTexture { get => default; } // 0x0000000189BEDCD8-0x0000000189BEDD40 
		// TextureHandle get_prepassDepthTexture()
		TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_prepassDepthTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_prepassDepthTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3541, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3541, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_prepassDepthTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_prepassDepthTexture = this->fields.m_prepassDepthTexture;
		  }
		  result = retstr;
		  *retstr = m_prepassDepthTexture;
		  return result;
		}
		
		public Material waterRenderingMaterial { get => default; } // 0x0000000189BEDE78-0x0000000189BEDEC8 
		// Material get_waterRenderingMaterial()
		Material *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_waterRenderingMaterial(
		        WaterOnePassDeferredRenderingPass *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3542, 0LL) )
		    return this->fields.m_waterRenderingMaterial;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3542, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_641(Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public enum WaterShaderForwardPassName // TypeDefIndex: 38503
		{
			GBufferBlit = 0,
			GBuffer = 1,
			DepthBlit = 2,
			Reflect = 3,
			Lighting = 4,
			FullScreenDebug = 5
		}
	
		internal struct PassInput // TypeDefIndex: 38504
		{
			// Fields
			internal TextureHandle sectorTexture; // 0x00
			internal TextureHandle interactionTexture; // 0x10
			internal TextureHandle sceneColor; // 0x20
			internal TextureHandle sceneColorCopied; // 0x30
			internal TextureHandle sceneDepth; // 0x40
			internal TextureHandle sceneDepthCopied; // 0x50
			internal TextureHandle lowResSceneDepth; // 0x60
			internal TextureHandle sceneMV; // 0x70
			internal TextureHandle gBufferATexture; // 0x80
			internal ScriptableRenderContext srpContext; // 0x90
		}
	
		internal struct PassOutput // TypeDefIndex: 38505
		{
			// Fields
			internal TextureHandle gbufferBWithWaterTexture; // 0x00
			internal TextureHandle depthWithWaterTexture; // 0x10
		}
	
		private class PassData // TypeDefIndex: 38506
		{
			// Fields
			public bool isRendering; // 0x10
			public uint cullHandle; // 0x14
			public HGCamera hgCamera; // 0x18
			public Material material; // 0x20
			public MaterialPropertyBlock proxyMPB; // 0x28
			public CBHandle cbHandle; // 0x30
			public TextureHandle currentSceneColorTexture; // 0x48
			public TextureHandle currentSceneDepthTexture; // 0x58
			public TextureHandle currentMotionVectorTexture; // 0x68
			public TextureHandle lowSceneDepthTexture; // 0x78
			public TextureHandle previousReflectLightingTexture; // 0x88
			public TextureHandle gBufferATexture; // 0x98
			public TextureHandle gBufferMVTexture; // 0xA8
	
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
		public WaterOnePassDeferredRenderingPass() {} // Dummy constructor
		internal WaterOnePassDeferredRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000189BED9F0-0x0000000189BEDB2C
		static WaterOnePassDeferredRenderingPass() {} // 0x0000000189BED89C-0x0000000189BED9F0
	
		// Methods
		public void Prepare(HGCamera hgCamera, HGSettingParameters settingParameters, ScriptableRenderContext renderContext) {} // 0x0000000189BEC228-0x0000000189BEC474
		// Void Prepare(HGCamera, HGSettingParameters, ScriptableRenderContext)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::Prepare(
		        WaterOnePassDeferredRenderingPass *this,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        ScriptableRenderContext renderContext,
		        MethodInfo *method)
		{
		  __int64 v8; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  bool ShouldRenderWater; // al
		  HGManagerContext *currentManagerContext; // rax
		  HGWaterManager *waterManager_k__BackingField; // r15
		  HGManagerContext *v13; // rax
		  HGWaterGlobalConfig *globalConfig; // rax
		  HGWaterGlobalConfig *v15; // r14
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v16; // rdx
		  VolumetricRenderer_VolumetricBounds *v17; // r8
		  Int32__Array **v18; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v19; // rdx
		  VolumetricRenderer_VolumetricBounds *v20; // r8
		  Int32__Array **v21; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v22; // rdx
		  VolumetricRenderer_VolumetricBounds *v23; // r8
		  Int32__Array **v24; // r9
		  Matrix4x4__StaticFields *static_fields; // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm2
		  __int128 v28; // xmm3
		  Matrix4x4__StaticFields *v29; // rax
		  __int128 v30; // xmm1
		  __int128 v31; // xmm2
		  __int128 v32; // xmm3
		  Matrix4x4__StaticFields *v33; // rax
		  __int128 v34; // xmm1
		  __int128 v35; // xmm2
		  __int128 v36; // xmm3
		  CBHandle *v37; // rax
		  void *ptr; // xmm0_8
		  MethodInfo *orthoViewProj; // [rsp+28h] [rbp-E0h]
		  MethodInfo *orthoViewProja; // [rsp+28h] [rbp-E0h]
		  MethodInfo *orthoViewProjb; // [rsp+28h] [rbp-E0h]
		  bool orthoDeviceViewProj; // [rsp+30h] [rbp-D8h]
		  bool orthoDeviceViewProja; // [rsp+30h] [rbp-D8h]
		  bool orthoDeviceViewProjb; // [rsp+30h] [rbp-D8h]
		  int32_t orthoDeviceInvViewProj; // [rsp+38h] [rbp-D0h]
		  int32_t orthoDeviceInvViewProja; // [rsp+38h] [rbp-D0h]
		  int32_t orthoDeviceInvViewProjb; // [rsp+38h] [rbp-D0h]
		  _QWORD v48[9]; // [rsp+40h] [rbp-C8h] BYREF
		  Matrix4x4 v49; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v50; // [rsp+C8h] [rbp-40h] BYREF
		  CBHandle v51; // [rsp+108h] [rbp+0h] BYREF
		  ScriptableRenderContext P3; // [rsp+160h] [rbp+58h] BYREF
		
		  P3.m_Ptr = renderContext.m_Ptr;
		  if ( IFix::WrappersManagerImpl::IsPatched(3543, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3543, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1261(
		      Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      (Object *)settingParameters,
		      P3,
		      0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      goto LABEL_12;
		    ShouldRenderWater = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
		    this->fields.m_isRendering = ShouldRenderWater;
		    if ( ShouldRenderWater )
		    {
		      this->fields.m_cullHandle = hgCamera->fields.waterProxyCullHandle;
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( currentManagerContext )
		      {
		        waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		        v13 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		        if ( v13 )
		        {
		          Patch = (ILFixDynamicMethodWrapper_2 *)v13->fields._waterManager_k__BackingField;
		          if ( Patch )
		          {
		            globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)Patch, 0LL);
		            v15 = globalConfig;
		            if ( globalConfig )
		            {
		              this->fields.m_globalFlowmapTexture = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
		                                                      globalConfig,
		                                                      0LL);
		              sub_18002D1B0(
		                (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_globalFlowmapTexture,
		                v16,
		                v17,
		                v18,
		                orthoViewProj,
		                orthoDeviceViewProj,
		                orthoDeviceInvViewProj,
		                v48[0],
		                *(float *)&v48[1],
		                v48[2],
		                v48[3],
		                v48[4],
		                (MethodInfo *)v48[5]);
		              this->fields.m_globalCausticTexture = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(
		                                                      v15,
		                                                      0LL);
		              sub_18002D1B0(
		                (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_globalCausticTexture,
		                v19,
		                v20,
		                v21,
		                orthoViewProja,
		                orthoDeviceViewProja,
		                orthoDeviceInvViewProja,
		                v48[0],
		                *(float *)&v48[1],
		                v48[2],
		                v48[3],
		                v48[4],
		                (MethodInfo *)v48[5]);
		              this->fields.m_globalNormalTextureArray = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
		                                                          v15,
		                                                          0LL);
		              sub_18002D1B0(
		                (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_globalNormalTextureArray,
		                v22,
		                v23,
		                v24,
		                orthoViewProjb,
		                orthoDeviceViewProjb,
		                orthoDeviceInvViewProjb,
		                v48[0],
		                *(float *)&v48[1],
		                v48[2],
		                v48[3],
		                v48[4],
		                (MethodInfo *)v48[5]);
		              static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		              v26 = *(_OWORD *)&static_fields->identityMatrix.m01;
		              v27 = *(_OWORD *)&static_fields->identityMatrix.m02;
		              v28 = *(_OWORD *)&static_fields->identityMatrix.m03;
		              *(_OWORD *)&v50.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		              *(_OWORD *)&v50.m01 = v26;
		              *(_OWORD *)&v50.m02 = v27;
		              *(_OWORD *)&v50.m03 = v28;
		              v29 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		              v30 = *(_OWORD *)&v29->identityMatrix.m01;
		              v31 = *(_OWORD *)&v29->identityMatrix.m02;
		              v32 = *(_OWORD *)&v29->identityMatrix.m03;
		              *(_OWORD *)&v49.m00 = *(_OWORD *)&v29->identityMatrix.m00;
		              *(_OWORD *)&v49.m01 = v30;
		              *(_OWORD *)&v49.m02 = v31;
		              *(_OWORD *)&v49.m03 = v32;
		              v33 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		              v34 = *(_OWORD *)&v33->identityMatrix.m01;
		              v35 = *(_OWORD *)&v33->identityMatrix.m02;
		              v36 = *(_OWORD *)&v33->identityMatrix.m03;
		              *(_OWORD *)&v48[1] = *(_OWORD *)&v33->identityMatrix.m00;
		              *(_OWORD *)&v48[3] = v34;
		              *(_OWORD *)&v48[5] = v35;
		              *(_OWORD *)&v48[7] = v36;
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		              v37 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v51, &P3, 20768, 0LL);
		              ptr = v37->ptr;
		              *(_OWORD *)&this->fields.m_cbHandle.bufferId = *(_OWORD *)&v37->bufferId;
		              this->fields.m_cbHandle.ptr = ptr;
		              if ( waterManager_k__BackingField )
		              {
		                HG::Rendering::Runtime::HGWaterManager::SetWaterDataCB(
		                  waterManager_k__BackingField,
		                  hgCamera,
		                  settingParameters,
		                  &this->fields.m_cbHandle,
		                  &v50,
		                  &v49,
		                  (Matrix4x4 *)&v48[1],
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		LABEL_12:
		      sub_1800D8260(Patch, v8);
		    }
		    this->fields.m_cullHandle = 0;
		  }
		}
		
		internal void RenderReflectPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameters) {} // 0x0000000189BECC18-0x0000000189BED89C
		// Void RenderReflectPass(WaterOnePassDeferredRenderingPass+PassInput ByRef, WaterOnePassDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderReflectPass(
		        WaterOnePassDeferredRenderingPass *this,
		        WaterOnePassDeferredRenderingPass_PassInput *input,
		        WaterOnePassDeferredRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Object *v7; // r14
		  WaterOnePassDeferredRenderingPass *v10; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  MonitorData *v15; // r15
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  TextureHandle v18; // xmm0
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ProfilingSampler *v21; // rax
		  int v22; // r8d
		  __int64 v23; // rcx
		  __int64 v24; // rdx
		  int v25; // eax
		  unsigned __int64 v26; // rdx
		  unsigned __int64 v27; // r8
		  char v28; // dl
		  signed __int64 v29; // rtt
		  __int64 v30; // rdx
		  MaterialPropertyBlock *m_mpb; // rcx
		  unsigned __int64 v32; // rdx
		  unsigned __int64 v33; // r8
		  char v34; // dl
		  signed __int64 v35; // rtt
		  __int64 v36; // r13
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  TextureHandle v39; // xmm0
		  ProfilingSampler *v40; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  __int64 v43; // rdx
		  __int64 m_cullHandle; // rcx
		  Object *v45; // rdx
		  int v46; // eax
		  unsigned __int64 v47; // rdx
		  unsigned __int64 v48; // r8
		  char v49; // dl
		  signed __int64 v50; // rtt
		  Object *v51; // rdx
		  Object__Class *m_waterRenderingMaterial; // rcx
		  unsigned __int64 v53; // rdx
		  unsigned __int64 v54; // r8
		  char v55; // dl
		  signed __int64 v56; // rtt
		  Object *v57; // rdx
		  MonitorData *v58; // rcx
		  unsigned __int64 v59; // rdx
		  unsigned __int64 v60; // r8
		  signed __int64 v61; // rtt
		  Object__Class *ptr; // xmm1_8
		  Object *v63; // rax
		  Object *v64; // rsi
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  TextureHandle v67; // xmm0
		  Object *v68; // rsi
		  __int64 v69; // rdx
		  __int64 v70; // rcx
		  TextureHandle v71; // xmm0
		  Object *v72; // rsi
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  TextureHandle v75; // xmm0
		  Object *v76; // rsi
		  Color m_previousReflectLightingTexture; // xmm0
		  __int64 v78; // rdx
		  __int64 v79; // rcx
		  TextureHandle v80; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v82; // rdx
		  __int64 v83; // rcx
		  Object *v84; // [rsp+50h] [rbp-398h] BYREF
		  TextureHandle v85; // [rsp+58h] [rbp-390h] BYREF
		  __int64 v86; // [rsp+68h] [rbp-380h] BYREF
		  TextureHandle sceneMV; // [rsp+70h] [rbp-378h] BYREF
		  TextureHandle lowResSceneDepth; // [rsp+80h] [rbp-368h] BYREF
		  HGRenderGraphBuilder v89; // [rsp+A0h] [rbp-348h] BYREF
		  HGRenderGraphBuilder v90; // [rsp+C0h] [rbp-328h] BYREF
		  HGRenderGraphBuilder v91; // [rsp+E0h] [rbp-308h] BYREF
		  TextureDesc v92; // [rsp+100h] [rbp-2E8h] BYREF
		  Color sceneColor; // [rsp+160h] [rbp-288h] BYREF
		  Il2CppExceptionWrapper *v94; // [rsp+170h] [rbp-278h] BYREF
		  Il2CppExceptionWrapper *v95; // [rsp+178h] [rbp-270h] BYREF
		  TextureDesc v96; // [rsp+180h] [rbp-268h] BYREF
		  TextureDesc v97; // [rsp+1E0h] [rbp-208h] BYREF
		  TextureDesc v98; // [rsp+240h] [rbp-1A8h] BYREF
		  TextureDesc v99; // [rsp+2A0h] [rbp-148h] BYREF
		  TextureDesc v100; // [rsp+360h] [rbp-88h] BYREF
		
		  v7 = (Object *)renderGraph;
		  v10 = this;
		  sub_18033B9D0(&v97, 0LL, 96LL);
		  sub_18033B9D0(&v92, 0LL, 96LL);
		  sub_18033B9D0(&v96.slices, 0LL, 88LL);
		  memset(&v91, 0, sizeof(v91));
		  v86 = 0LL;
		  memset(&v89, 0, sizeof(v89));
		  v84 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3544, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3544, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v83, v82);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1263(
		      Patch,
		      (Object *)v10,
		      input,
		      output,
		      v7,
		      (Object *)hgCamera,
		      (Object *)settingParameters,
		      0LL);
		  }
		  else if ( v10->fields.m_isRendering )
		  {
		    v10->fields.m_sectorTexture = input->sectorTexture;
		    v10->fields.m_interactionTexture = input->interactionTexture;
		    if ( !settingParameters )
		      sub_1800D8260(v12, v11);
		    v10->fields.m_waterVRRx = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._waterVRRx_k__BackingField,
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v10->fields.m_waterVRRy = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._waterVRRy_k__BackingField,
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    sceneColor = (Color)input->sceneColor;
		    *(TextureHandle *)&v90.m_RenderPass = input->sceneDepth;
		    sceneMV = input->sceneMV;
		    lowResSceneDepth = input->lowResSceneDepth;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v15 = (MonitorData *)hgCamera;
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&lowResSceneDepth, 0LL) )
		    {
		      v18 = input->lowResSceneDepth;
		    }
		    else
		    {
		      if ( !hgCamera )
		        sub_1800D8260(v14, v13);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v92,
		        hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2,
		        (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2,
		        0LL);
		      v92.colorFormat = 49;
		      v97 = v92;
		      if ( !v7 )
		        sub_1800D8260(v17, v16);
		      v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v85, (HGRenderGraph *)v7, &v97, 0LL);
		    }
		    v10->fields.m_lowSceneDepthTexture = v18;
		    if ( !hgCamera )
		      sub_1800D8260(v14, v13);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		      &v92,
		      hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2,
		      (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2,
		      0LL);
		    if ( !v7 )
		      sub_1800D8260(v20, v19);
		    v92.colorFormat = _mm_cvtsi128_si32(*(__m128i *)&HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
		                                                       &v100,
		                                                       (HGRenderGraph *)v7,
		                                                       (TextureHandle *)&sceneColor,
		                                                       0LL)->colorFormat);
		    v98 = v92;
		    v10->fields.m_reflectLightingTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                              &v85,
		                                              (HGRenderGraph *)v7,
		                                              &v98,
		                                              0LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		      &v92,
		      hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2,
		      (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2,
		      0LL);
		    v92.colorFormat = 5;
		    v99 = v92;
		    v10->fields.m_reflectFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                              &v85,
		                                              (HGRenderGraph *)v7,
		                                              &v99,
		                                              0LL);
		    v96 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
		             &v100,
		             (HGRenderGraph *)v7,
		             (TextureHandle *)&v90,
		             0LL);
		    v96.width = hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2;
		    v96.height = (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2;
		    v10->fields.m_prepassDepthTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                           &v85,
		                                           (HGRenderGraph *)v7,
		                                           &v96,
		                                           0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&lowResSceneDepth, 0LL) )
		    {
		      v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x26u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      v91 = *(HGRenderGraphBuilder *)sub_1808AFC80(
		                                       (unsigned int)&lowResSceneDepth,
		                                       (_DWORD)v7,
		                                       v22,
		                                       (unsigned int)&v86,
		                                       (__int64)v21);
		      lowResSceneDepth.handle = 0LL;
		      lowResSceneDepth.fallBackResource = (ResourceHandle)&v91;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v91, 0, 0LL);
		        v24 = v86;
		        if ( !v86 )
		          sub_1800D8250(v23, 0LL);
		        *(_QWORD *)(v86 + 32) = v10->fields.m_waterRenderingMaterial;
		        v25 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v26 = ((unsigned __int64)(v24 + 32) >> 12) & 0x1FFFFF;
		          v27 = v26 >> 6;
		          v28 = v26 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v27 + 36190]);
		          do
		            v29 = qword_18F0BCBA0[v27 + 36190];
		          while ( v29 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v27 + 36190], v29 | (1LL << v28), v29) );
		          v25 = dword_18F35FD08;
		        }
		        v30 = v86;
		        m_mpb = v10->fields.m_mpb;
		        if ( !v86 )
		          sub_1800D8250(m_mpb, 0LL);
		        *(_QWORD *)(v86 + 40) = m_mpb;
		        if ( v25 )
		        {
		          v32 = ((unsigned __int64)(v30 + 40) >> 12) & 0x1FFFFF;
		          v33 = v32 >> 6;
		          v34 = v32 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v33 + 36190]);
		          do
		            v35 = qword_18F0BCBA0[v33 + 36190];
		          while ( v35 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v33 + 36190], v35 | (1LL << v34), v35) );
		        }
		        v36 = v86;
		        v39 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 &v85,
		                 &v91,
		                 (TextureHandle *)&v90,
		                 0LL);
		        if ( !v36 )
		          sub_1800D8250(v38, v37);
		        *(TextureHandle *)(v36 + 88) = v39;
		        *(_OWORD *)&v90.m_RenderPass = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v85,
		          &v91,
		          &v10->fields.m_lowSceneDepthTexture,
		          0,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v90,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v91,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass->static_fields->s_depthDownsampleRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v94 )
		      {
		        lowResSceneDepth.handle = (ResourceHandle)v94->ex;
		        sub_180268AE0(&lowResSceneDepth);
		        v15 = (MonitorData *)hgCamera;
		        v7 = (Object *)renderGraph;
		        v10 = this;
		        goto LABEL_25;
		      }
		      sub_180268AE0(&lowResSceneDepth);
		    }
		LABEL_25:
		    v40 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x36u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v7 )
		      sub_1800D8250(v42, v41);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v90,
		      (HGRenderGraph *)v7,
		      (String *)"Water Prepass",
		      &v84,
		      v40,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
		    v89 = v90;
		    lowResSceneDepth.handle = 0LL;
		    lowResSceneDepth.fallBackResource = (ResourceHandle)&v89;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v89, 0, 0LL);
		      m_cullHandle = v10->fields.m_cullHandle;
		      if ( !v84 )
		        sub_1800D8250(m_cullHandle, v43);
		      HIDWORD(v84[1].klass) = m_cullHandle;
		      v45 = v84;
		      if ( !v84 )
		        sub_1800D8250(m_cullHandle, 0LL);
		      v84[1].monitor = v15;
		      v46 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v47 = ((unsigned __int64)&v45[1].monitor >> 12) & 0x1FFFFF;
		        v48 = v47 >> 6;
		        v49 = v47 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		        do
		          v50 = qword_18F0BCBA0[v48 + 36190];
		        while ( v50 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v48 + 36190], v50 | (1LL << v49), v50) );
		        v46 = dword_18F35FD08;
		      }
		      v51 = v84;
		      m_waterRenderingMaterial = (Object__Class *)v10->fields.m_waterRenderingMaterial;
		      if ( !v84 )
		        sub_1800D8250(m_waterRenderingMaterial, 0LL);
		      v84[2].klass = m_waterRenderingMaterial;
		      if ( v46 )
		      {
		        v53 = ((unsigned __int64)&v51[2] >> 12) & 0x1FFFFF;
		        v54 = v53 >> 6;
		        v55 = v53 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v54 + 36190]);
		        do
		          v56 = qword_18F0BCBA0[v54 + 36190];
		        while ( v56 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v54 + 36190], v56 | (1LL << v55), v56) );
		        v46 = dword_18F35FD08;
		      }
		      v57 = v84;
		      v58 = (MonitorData *)v10->fields.m_mpb;
		      if ( !v84 )
		        sub_1800D8250(v58, 0LL);
		      v84[2].monitor = v58;
		      if ( v46 )
		      {
		        v59 = ((unsigned __int64)&v57[2].monitor >> 12) & 0x1FFFFF;
		        v60 = v59 >> 6;
		        v57 = (Object *)(v59 & 0x3F);
		        _m_prefetchw(&qword_18F0BCBA0[v60 + 36190]);
		        do
		        {
		          v58 = (MonitorData *)(qword_18F0BCBA0[v60 + 36190] | (1LL << (char)v57));
		          v61 = qword_18F0BCBA0[v60 + 36190];
		        }
		        while ( v61 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v60 + 36190], (signed __int64)v58, v61) );
		      }
		      ptr = (Object__Class *)v10->fields.m_cbHandle.ptr;
		      v63 = v84;
		      if ( !v84 )
		        sub_1800D8250(v58, v57);
		      v84[3] = *(Object *)&v10->fields.m_cbHandle.bufferId;
		      v63[4].klass = ptr;
		      v64 = v84;
		      v67 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v90,
		               &v89,
		               (TextureHandle *)&sceneColor,
		               0LL);
		      if ( !v64 )
		        sub_1800D8250(v66, v65);
		      *(TextureHandle *)&v64[4].monitor = v67;
		      v68 = v84;
		      v71 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v90,
		               &v89,
		               &sceneMV,
		               0LL);
		      if ( !v68 )
		        sub_1800D8250(v70, v69);
		      *(TextureHandle *)&v68[6].monitor = v71;
		      v72 = v84;
		      v75 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               &sceneMV,
		               &v89,
		               &v10->fields.m_lowSceneDepthTexture,
		               0LL);
		      if ( !v72 )
		        sub_1800D8250(v74, v73);
		      *(TextureHandle *)&v72[7].monitor = v75;
		      v76 = v84;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v10->fields.m_previousReflectLightingTexture, 0LL) )
		        m_previousReflectLightingTexture = (Color)v10->fields.m_previousReflectLightingTexture;
		      else
		        m_previousReflectLightingTexture = sceneColor;
		      sceneMV = (TextureHandle)m_previousReflectLightingTexture;
		      v80 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v90,
		               &v89,
		               &sceneMV,
		               0LL);
		      if ( !v76 )
		        sub_1800D8250(v79, v78);
		      *(TextureHandle *)&v76[8].monitor = v80;
		      sceneMV = 0LL;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v90,
		        &v89,
		        &v10->fields.m_reflectLightingTexture,
		        0,
		        RenderBufferLoadAction__Enum_Clear,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&sceneMV,
		        0,
		        0LL);
		      sceneMV = 0LL;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v90,
		        &v89,
		        &v10->fields.m_reflectFadenessTexture,
		        1,
		        RenderBufferLoadAction__Enum_Clear,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&sceneMV,
		        0,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        &sceneMV,
		        &v89,
		        &v10->fields.m_prepassDepthTexture,
		        DepthAccess__Enum_Write,
		        RenderBufferLoadAction__Enum_Clear,
		        RenderBufferStoreAction__Enum_Store,
		        1.0,
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v89,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass->static_fields->s_waterReflectiLightingRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v95 )
		    {
		      lowResSceneDepth.handle = (ResourceHandle)v95->ex;
		    }
		    sub_180268AE0(&lowResSceneDepth);
		  }
		  else
		  {
		    HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderFallback(
		      v10,
		      input,
		      output,
		      (HGRenderGraph *)v7,
		      hgCamera,
		      0LL);
		  }
		}
		
		public void PrepareInTransparentPass(HGRenderGraphBuilder builder) {} // 0x0000000189BEC14C-0x0000000189BEC228
		// Void PrepareInTransparentPass(HGRenderGraphBuilder)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PrepareInTransparentPass(
		        WaterOnePassDeferredRenderingPass *this,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int128 v8; // xmm1
		  HGRenderGraphBuilder v9; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3149, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3149, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = *(_OWORD *)&builder->m_RenderGraph;
		    *(_OWORD *)&v9.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v9.m_RenderGraph = v8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1160(Patch, (Object *)this, &v9, 0LL);
		  }
		  else if ( this->fields.m_isRendering )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		      (TextureHandle *)&v9,
		      builder,
		      &this->fields.m_sectorTexture,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		      (TextureHandle *)&v9,
		      builder,
		      &this->fields.m_interactionTexture,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		      (TextureHandle *)&v9,
		      builder,
		      &this->fields.m_prepassDepthTexture,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		      (TextureHandle *)&v9,
		      builder,
		      &this->fields.m_reflectLightingTexture,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		      (TextureHandle *)&v9,
		      builder,
		      &this->fields.m_reflectFadenessTexture,
		      0LL);
		  }
		}
		
		public void RenderLighting(HGRenderGraphContext ctx, HGCamera hgCamera) {} // 0x0000000189BEC610-0x0000000189BECC18
		// Void RenderLighting(HGRenderGraphContext, HGCamera)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderLighting(
		        WaterOnePassDeferredRenderingPass *this,
		        HGRenderGraphContext *ctx,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  CommandBuffer *cmd; // rcx
		  Material *m_waterRenderingMaterial; // rdi
		  Material *v10; // rdi
		  TextureHandle m_sectorTexture; // xmm6
		  int32_t WaterLocalFlowmapTexture; // esi
		  Texture *v13; // rax
		  Material *v14; // rdi
		  HGShaderIDs__StaticFields *v15; // rdx
		  int32_t WaterRippleTexture; // esi
		  Texture *v17; // rax
		  Material *v18; // rdi
		  int32_t WaterGlobalSmallWaveNormalTexture; // esi
		  Texture *normalTexture; // rax
		  Material *v21; // rdi
		  int32_t WaterGlobalLargeWaveNormalTexture; // esi
		  Texture *v23; // rax
		  Shader *shader; // rax
		  Material *v25; // rdi
		  HGManagerContext *currentManagerContext; // rax
		  bool ShouldRenderRippleState; // al
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __m128i v29; // xmm6
		  Shader *v30; // rax
		  bool v31; // r8
		  CommandBuffer *v32; // rdi
		  TextureHandle m_prepassDepthTexture; // xmm6
		  int32_t WaterPrepassDepthGlobalTexture; // esi
		  RenderTargetIdentifier *v35; // rax
		  __int64 v36; // rcx
		  __int128 v37; // xmm1
		  Material *v38; // rdi
		  HGShaderIDs__StaticFields *v39; // rdx
		  int32_t WaterReflectLightingTexture; // esi
		  Texture *v41; // rax
		  Material *v42; // rdi
		  HGShaderIDs__StaticFields *v43; // rdx
		  int32_t WaterReflectFadenessTexture; // esi
		  Texture *v45; // rax
		  void *m_Ptr; // r14
		  CommandBuffer *v47; // rsi
		  uint32_t waterDecalCullHandle; // edi
		  MaterialPropertyBlock *m_mpb; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle m_interactionTexture; // [rsp+68h] [rbp-A0h] BYREF
		  LocalKeyword keyword_8; // [rsp+78h] [rbp-90h] BYREF
		  LocalKeyword v53; // [rsp+90h] [rbp-78h] BYREF
		  RenderTargetIdentifier v54; // [rsp+A8h] [rbp-60h] BYREF
		  RenderTargetIdentifier v55; // [rsp+158h] [rbp+50h] BYREF
		
		  memset(&keyword_8, 0, sizeof(keyword_8));
		  memset(&v53, 0, sizeof(v53));
		  if ( !IFix::WrappersManagerImpl::IsPatched(3159, 0LL) )
		  {
		    if ( !this->fields.m_isRendering )
		      return;
		    if ( ctx )
		    {
		      cmd = ctx->fields.cmd;
		      if ( cmd )
		      {
		        UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate(
		          cmd,
		          this->fields.m_waterVRRx,
		          this->fields.m_waterVRRy,
		          0LL);
		        m_waterRenderingMaterial = this->fields.m_waterRenderingMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( m_waterRenderingMaterial )
		        {
		          UnityEngine::Material::SetConstantBufferImpl0(
		            m_waterRenderingMaterial,
		            static_fields->_WaterData,
		            this->fields.m_cbHandle.bufferId,
		            this->fields.m_cbHandle.offset,
		            this->fields.m_cbHandle.size,
		            0LL);
		          v10 = this->fields.m_waterRenderingMaterial;
		          m_sectorTexture = this->fields.m_sectorTexture;
		          WaterLocalFlowmapTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterLocalFlowmapTexture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          m_interactionTexture = m_sectorTexture;
		          v13 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&m_interactionTexture, 0LL);
		          if ( v10 )
		          {
		            UnityEngine::Material::SetTextureImpl(v10, WaterLocalFlowmapTexture, v13, 0LL);
		            v14 = this->fields.m_waterRenderingMaterial;
		            v15 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            m_interactionTexture = this->fields.m_interactionTexture;
		            WaterRippleTexture = v15->_WaterRippleTexture;
		            v17 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&m_interactionTexture, 0LL);
		            if ( v14 )
		            {
		              UnityEngine::Material::SetTextureImpl(v14, WaterRippleTexture, v17, 0LL);
		              cmd = (CommandBuffer *)this->fields.m_waterRenderingMaterial;
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              if ( cmd )
		              {
		                UnityEngine::Material::SetTextureImpl(
		                  (Material *)cmd,
		                  static_fields->_WaterGlobalNormalTextureArray,
		                  (Texture *)this->fields.m_globalNormalTextureArray,
		                  0LL);
		                cmd = (CommandBuffer *)this->fields.m_waterRenderingMaterial;
		                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                if ( cmd )
		                {
		                  UnityEngine::Material::SetTextureImpl(
		                    (Material *)cmd,
		                    static_fields->_WaterGlobalFlowmapTexture,
		                    (Texture *)this->fields.m_globalFlowmapTexture,
		                    0LL);
		                  cmd = (CommandBuffer *)this->fields.m_waterRenderingMaterial;
		                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  if ( cmd )
		                  {
		                    UnityEngine::Material::SetTextureImpl(
		                      (Material *)cmd,
		                      static_fields->_WaterGlobalCausticTexture,
		                      (Texture *)this->fields.m_globalCausticTexture,
		                      0LL);
		                    v18 = this->fields.m_waterRenderingMaterial;
		                    WaterGlobalSmallWaveNormalTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalSmallWaveNormalTexture;
		                    normalTexture = (Texture *)UnityEngine::Texture2D::get_normalTexture(0LL);
		                    if ( v18 )
		                    {
		                      UnityEngine::Material::SetTextureImpl(v18, WaterGlobalSmallWaveNormalTexture, normalTexture, 0LL);
		                      v21 = this->fields.m_waterRenderingMaterial;
		                      WaterGlobalLargeWaveNormalTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalLargeWaveNormalTexture;
		                      v23 = (Texture *)UnityEngine::Texture2D::get_normalTexture(0LL);
		                      if ( v21 )
		                      {
		                        UnityEngine::Material::SetTextureImpl(v21, WaterGlobalLargeWaveNormalTexture, v23, 0LL);
		                        cmd = (CommandBuffer *)this->fields.m_waterRenderingMaterial;
		                        if ( cmd )
		                        {
		                          shader = UnityEngine::Material::get_shader((Material *)cmd, 0LL);
		                          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                            &keyword_8,
		                            shader,
		                            (String *)"ENABLE_WATER_RIPPLE",
		                            0LL);
		                          v25 = this->fields.m_waterRenderingMaterial;
		                          currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		                          if ( currentManagerContext )
		                          {
		                            cmd = (CommandBuffer *)currentManagerContext->fields._waterManager_k__BackingField;
		                            if ( cmd )
		                            {
		                              ShouldRenderRippleState = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(
		                                                          (HGWaterManager *)cmd,
		                                                          0LL);
		                              if ( v25 )
		                              {
		                                UnityEngine::Material::SetKeyword(v25, &keyword_8, ShouldRenderRippleState, 0LL);
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		                                InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(
		                                                      hgCamera,
		                                                      0LL);
		                                if ( InterpolatedPhase )
		                                {
		                                  cmd = (CommandBuffer *)this->fields.m_waterRenderingMaterial;
		                                  v29 = *(__m128i *)&InterpolatedPhase->fields.inkSimulationConfig.influence;
		                                  if ( cmd )
		                                  {
		                                    v30 = UnityEngine::Material::get_shader((Material *)cmd, 0LL);
		                                    UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                                      &v53,
		                                      v30,
		                                      (String *)"ENABLE_INK_RENDER",
		                                      0LL);
		                                    cmd = (CommandBuffer *)this->fields.m_waterRenderingMaterial;
		                                    v31 = *(float *)v29.m128i_i32 > 0.0
		                                       && (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v29, 8)) == 0;
		                                    if ( cmd )
		                                    {
		                                      UnityEngine::Material::SetKeyword((Material *)cmd, &v53, v31, 0LL);
		                                      v32 = ctx->fields.cmd;
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                      m_prepassDepthTexture = this->fields.m_prepassDepthTexture;
		                                      WaterPrepassDepthGlobalTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassDepthGlobalTexture;
		                                      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		                                      m_interactionTexture = m_prepassDepthTexture;
		                                      v35 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                                              &v55,
		                                              &m_interactionTexture,
		                                              0LL);
		                                      if ( !v32 )
		                                        goto LABEL_31;
		                                      v37 = *(_OWORD *)&v35->m_BufferPointer;
		                                      *(_OWORD *)&v54.m_Type = *(_OWORD *)&v35->m_Type;
		                                      *(_QWORD *)&v54.m_DepthSlice = *(_QWORD *)&v35->m_DepthSlice;
		                                      *(_OWORD *)&v54.m_BufferPointer = v37;
		                                      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		                                        v32,
		                                        WaterPrepassDepthGlobalTexture,
		                                        &v54,
		                                        0LL);
		                                      v38 = this->fields.m_waterRenderingMaterial;
		                                      v39 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                      m_interactionTexture = this->fields.m_reflectLightingTexture;
		                                      WaterReflectLightingTexture = v39->_WaterReflectLightingTexture;
		                                      v41 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                                              &m_interactionTexture,
		                                              0LL);
		                                      if ( !v38 )
		                                        goto LABEL_31;
		                                      UnityEngine::Material::SetTextureImpl(v38, WaterReflectLightingTexture, v41, 0LL);
		                                      v42 = this->fields.m_waterRenderingMaterial;
		                                      v43 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                      m_interactionTexture = this->fields.m_reflectFadenessTexture;
		                                      WaterReflectFadenessTexture = v43->_WaterReflectFadenessTexture;
		                                      v45 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                                              &m_interactionTexture,
		                                              0LL);
		                                      if ( !v42
		                                        || (UnityEngine::Material::SetTextureImpl(
		                                              v42,
		                                              WaterReflectFadenessTexture,
		                                              v45,
		                                              0LL),
		                                            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext),
		                                            UnityEngine::HyperGryph::HGWaterRender::DrawWaterProxy(
		                                              ctx->fields.renderContext.m_Ptr,
		                                              ctx->fields.cmd,
		                                              this->fields.m_cullHandle,
		                                              this->fields.m_waterRenderingMaterial,
		                                              this->fields.m_mpb,
		                                              4,
		                                              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UnityInstancing_ECSPerDraw,
		                                              1,
		                                              3u,
		                                              -1,
		                                              0,
		                                              0LL),
		                                            !hgCamera) )
		                                      {
		LABEL_31:
		                                        sub_1800D8260(v36, static_fields);
		                                      }
		                                      if ( hgCamera->fields.waterDecalVisibleCount )
		                                      {
		                                        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                        m_Ptr = ctx->fields.renderContext.m_Ptr;
		                                        v47 = ctx->fields.cmd;
		                                        waterDecalCullHandle = hgCamera->fields.waterDecalCullHandle;
		                                        m_mpb = this->fields.m_mpb;
		                                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                        UnityEngine::HyperGryph::HGWaterRender::DrawWaterDecals(
		                                          m_Ptr,
		                                          v47,
		                                          waterDecalCullHandle,
		                                          m_mpb,
		                                          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterDecal,
		                                          0,
		                                          0,
		                                          3u,
		                                          -1,
		                                          0LL);
		                                      }
		                                      cmd = ctx->fields.cmd;
		                                      if ( cmd )
		                                      {
		                                        UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate(
		                                          cmd,
		                                          1u,
		                                          1u,
		                                          0LL);
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
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_33:
		    sub_1800D8260(cmd, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3159, 0LL);
		  if ( !Patch )
		    goto LABEL_33;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)ctx,
		    (Object *)hgCamera,
		    0LL);
		}
		
		internal void RenderFallback(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BEC474-0x0000000189BEC610
		// Void RenderFallback(WaterOnePassDeferredRenderingPass+PassInput ByRef, WaterOnePassDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderFallback(
		        WaterOnePassDeferredRenderingPass *this,
		        WaterOnePassDeferredRenderingPass_PassInput *input,
		        WaterOnePassDeferredRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // [rsp+40h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v18; // [rsp+48h] [rbp-50h] BYREF
		  _QWORD v19[4]; // [rsp+50h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v20; // [rsp+70h] [rbp-28h] BYREF
		
		  memset(&v20, 0, sizeof(v20));
		  v17 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3545, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3545, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1262(
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
		            (Int32Enum__Enum)0x36u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v20 = *(HGRenderGraphBuilder *)sub_1808AFC80(
		                                     (unsigned int)v19,
		                                     (_DWORD)renderGraph,
		                                     v13,
		                                     (unsigned int)&v17,
		                                     (__int64)v10);
		    v19[0] = 0LL;
		    v19[1] = &v20;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v20, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v20,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass->static_fields->s_RenderFallbackFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v18 )
		    {
		      v19[0] = v18->ex;
		    }
		    sub_180268AE0(v19);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BEC0F8-0x0000000189BEC14C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        WaterOnePassDeferredRenderingPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3546, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3546, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BEC0A4-0x0000000189BEC0F8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        WaterOnePassDeferredRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3547, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3547, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BEBFB8-0x0000000189BEC0A4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        WaterOnePassDeferredRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  TextureHandle *nullHandle; // rax
		  HGRenderGraph *renderGraph; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3548, 0LL) )
		  {
		    if ( input->passSkipped )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_reflectLightingTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v9, 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_reflectLightingTexture, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v9, 0LL);
		LABEL_8:
		      this->fields.m_previousReflectLightingTexture = *nullHandle;
		      return;
		    }
		    renderGraph = input->renderGraph;
		    if ( renderGraph )
		    {
		      nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                     &v9,
		                     renderGraph,
		                     &this->fields.m_reflectLightingTexture,
		                     1,
		                     (String *)"WaterReflectLighting",
		                     0LL);
		      goto LABEL_8;
		    }
		LABEL_10:
		    sub_1800D8260(v5, renderGraph);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3548, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000189BEBF64-0x0000000189BEBFB8
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        WaterOnePassDeferredRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3549, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3549, 0LL);
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
