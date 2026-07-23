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
	public class WaterInteractionRenderingPass : IPassConstructor // TypeDefIndex: 38494
	{
		// Fields
		private const string PASS_NAME = "WaterInteractionRenderingPass"; // Metadata: 0x02303D4C
		private int[] m_rippleTextureSize; // 0x10
		private CBHandle m_cb; // 0x18
		private TextureDesc m_desc; // 0x30
		private TextureDesc m_normalDesc; // 0x90
		private TextureHandle m_prevAddTexture; // 0xF0
		private TextureHandle m_currAddTexture; // 0x100
		private TextureHandle m_prevSimulateTexture; // 0x110
		private TextureHandle m_currSimulateTexture; // 0x120
		private TextureHandle m_currNormalTexture; // 0x130
		private RTHandle m_defaultTexture; // 0x140
		private Material m_interactionAddMaterial; // 0x148
		private Material m_interactionSimulateMaterial; // 0x150
		private Material m_interactionHeightConvertMaterial; // 0x158
		private bool m_shouldRender; // 0x160
		private float waterInteractionSafeDeltaTime; // 0x164
		private static readonly RenderFunc<InteractionAddData> s_interactionAddRenderFunc; // 0x00
		private static readonly RenderFunc<InteractionSimulateData> s_interactionSimulateRenderFunc; // 0x08
		private static readonly RenderFunc<InteractionHeightConvertData> s_interactionNormalConvertRenderFunc; // 0x10
		private static readonly RenderFunc<InteractionSimulateData> s_fallbackRenderFunc; // 0x18
	
		// Properties
		public TextureHandle interactionTexture { get => default; } // 0x0000000189BEBEFC-0x0000000189BEBF64 
		// TextureHandle get_interactionTexture()
		TextureHandle *HG::Rendering::Runtime::WaterInteractionRenderingPass::get_interactionTexture(
		        TextureHandle *__return_ptr retstr,
		        WaterInteractionRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_currNormalTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3493, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3493, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_currNormalTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_currNormalTexture = this->fields.m_currNormalTexture;
		  }
		  result = retstr;
		  *retstr = m_currNormalTexture;
		  return result;
		}
		
	
		// Nested types
		private class InteractionAddData // TypeDefIndex: 38490
		{
			// Fields
			public CBHandle cb; // 0x10
			public TextureHandle prevSimulationTexture; // 0x28
			public Material material; // 0x38
	
			// Constructors
			public InteractionAddData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class InteractionSimulateData // TypeDefIndex: 38491
		{
			// Fields
			public CBHandle cb; // 0x10
			public TextureHandle prevAddTexture; // 0x28
			public TextureHandle currAddTexture; // 0x38
			public TextureHandle currSimulateTexture; // 0x48
			public Material material; // 0x58
	
			// Constructors
			public InteractionSimulateData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class InteractionHeightConvertData // TypeDefIndex: 38492
		{
			// Fields
			public CBHandle cb; // 0x10
			public TextureHandle currSimulateTexture; // 0x28
			public TextureHandle currSimulateNormalTexture; // 0x38
			public Material material; // 0x48
	
			// Constructors
			public InteractionHeightConvertData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public WaterInteractionRenderingPass() {} // Dummy constructor
		internal WaterInteractionRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDBA40-0x0000000182EDBDD0
		// WaterInteractionRenderingPass(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::WaterInteractionRenderingPass(
		        WaterInteractionRenderingPass *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Array *v7; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  VolumetricRenderer_VolumetricBounds *v9; // r8
		  Int32__Array **v10; // r9
		  TextureHandle *nullHandle; // rax
		  __int64 v12; // rcx
		  void *m_rippleTextureSize; // rdx
		  TextureHandle v14; // xmm0
		  int32_t v15; // edx
		  int32_t v16; // ecx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v17; // rdx
		  VolumetricRenderer_VolumetricBounds *v18; // r8
		  Int32__Array **v19; // r9
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  Color clearColor; // xmm1
		  int32_t v23; // edx
		  int32_t v24; // ecx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v25; // rdx
		  VolumetricRenderer_VolumetricBounds *v26; // r8
		  Int32__Array **v27; // r9
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  Color v30; // xmm1
		  Texture *blackTexture; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v32; // rdx
		  VolumetricRenderer_VolumetricBounds *v33; // r8
		  Int32__Array **v34; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v36; // rdx
		  VolumetricRenderer_VolumetricBounds *v37; // r8
		  Int32__Array **v38; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v39; // rdx
		  VolumetricRenderer_VolumetricBounds *v40; // r8
		  Int32__Array **v41; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v42; // rdx
		  VolumetricRenderer_VolumetricBounds *v43; // r8
		  Int32__Array **v44; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v46; // rax
		  TextureHandle v47; // [rsp+20h] [rbp-19h] BYREF
		  TextureDesc P0; // [rsp+30h] [rbp-9h] BYREF
		
		  v7 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 3LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v7,
		    754109DB83C63E9C8C98A7C53D99E3E46F31281B7998A3A4D3D0A1A4A60508D5_Field,
		    0LL);
		  this->fields.m_rippleTextureSize = (Int32__Array *)v7;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields,
		    v8,
		    v9,
		    v10,
		    *(MethodInfo **)&v47.handle,
		    v47.fallBackResource.m_Value,
		    P0.width,
		    P0.slices,
		    *(float *)&P0.colorFormat,
		    P0.wrapMode,
		    P0.enableRandomWrite,
		    SLOBYTE(P0.mipMapBias),
		    *(MethodInfo **)&P0.bindTextureMS);
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_prevAddTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v47, 0LL);
		  this->fields.m_currAddTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v47, 0LL);
		  this->fields.m_prevSimulateTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v47, 0LL);
		  this->fields.m_currSimulateTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v47, 0LL);
		  nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v47, 0LL);
		  m_rippleTextureSize = this->fields.m_rippleTextureSize;
		  v14 = *nullHandle;
		  this->fields.m_shouldRender = 1;
		  this->fields.waterInteractionSafeDeltaTime = 0.01667;
		  this->fields.m_currNormalTexture = v14;
		  if ( !m_rippleTextureSize )
		    goto LABEL_4;
		  if ( *((_DWORD *)m_rippleTextureSize + 6) <= 1u )
		    goto LABEL_10;
		  v15 = *((_DWORD *)m_rippleTextureSize + 9);
		  v16 = this->fields.m_rippleTextureSize->vector[1];
		  memset(&P0.slices, 0, 88);
		  P0.width = v15;
		  P0.height = v16;
		  P0.msaaSamples = 1;
		  if ( IFix::WrappersManagerImpl::IsPatched(325, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(325, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_154(Patch, &P0, 0LL);
		  }
		  else
		  {
		    P0.slices = 1;
		    P0.dimension = 2;
		  }
		  *(_OWORD *)&this->fields.m_desc.width = *(_OWORD *)&P0.width;
		  P0.colorFormat = 5;
		  *(_OWORD *)&this->fields.m_desc.colorFormat = *(_OWORD *)&P0.colorFormat;
		  *(_WORD *)&P0.useMipMap = 0;
		  v20 = *(_OWORD *)&P0.bindTextureMS;
		  *(_OWORD *)&this->fields.m_desc.enableRandomWrite = *(_OWORD *)&P0.enableRandomWrite;
		  v21 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&this->fields.m_desc.bindTextureMS = v20;
		  clearColor = P0.clearColor;
		  *(_OWORD *)&this->fields.m_desc.fastMemoryDesc.inFastMemory = v21;
		  this->fields.m_desc.clearColor = clearColor;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_desc.name,
		    v17,
		    v18,
		    v19,
		    *(MethodInfo **)&v47.handle,
		    v47.fallBackResource.m_Value,
		    P0.width,
		    P0.slices,
		    *(float *)&P0.colorFormat,
		    P0.wrapMode,
		    P0.enableRandomWrite,
		    SLOBYTE(P0.mipMapBias),
		    *(MethodInfo **)&P0.bindTextureMS);
		  m_rippleTextureSize = this->fields.m_rippleTextureSize;
		  if ( !m_rippleTextureSize )
		    goto LABEL_4;
		  if ( *((_DWORD *)m_rippleTextureSize + 6) <= 1u )
		LABEL_10:
		    sub_1800D2AB0(v12, m_rippleTextureSize);
		  v23 = *((_DWORD *)m_rippleTextureSize + 9);
		  v24 = this->fields.m_rippleTextureSize->vector[1];
		  memset(&P0.slices, 0, 88);
		  P0.width = v23;
		  P0.height = v24;
		  P0.msaaSamples = 1;
		  if ( IFix::WrappersManagerImpl::IsPatched(325, 0LL) )
		  {
		    v46 = IFix::WrappersManagerImpl::GetPatch(325, 0LL);
		    if ( !v46 )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_154(v46, &P0, 0LL);
		  }
		  else
		  {
		    P0.slices = 1;
		    P0.dimension = 2;
		  }
		  *(_OWORD *)&this->fields.m_normalDesc.width = *(_OWORD *)&P0.width;
		  P0.colorFormat = 8;
		  *(_OWORD *)&this->fields.m_normalDesc.colorFormat = *(_OWORD *)&P0.colorFormat;
		  *(_WORD *)&P0.useMipMap = 0;
		  v28 = *(_OWORD *)&P0.bindTextureMS;
		  *(_OWORD *)&this->fields.m_normalDesc.enableRandomWrite = *(_OWORD *)&P0.enableRandomWrite;
		  v29 = *(_OWORD *)&P0.fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&this->fields.m_normalDesc.bindTextureMS = v28;
		  v30 = P0.clearColor;
		  *(_OWORD *)&this->fields.m_normalDesc.fastMemoryDesc.inFastMemory = v29;
		  this->fields.m_normalDesc.clearColor = v30;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_normalDesc.name,
		    v25,
		    v26,
		    v27,
		    *(MethodInfo **)&v47.handle,
		    v47.fallBackResource.m_Value,
		    P0.width,
		    P0.slices,
		    *(float *)&P0.colorFormat,
		    P0.wrapMode,
		    P0.enableRandomWrite,
		    SLOBYTE(P0.mipMapBias),
		    *(MethodInfo **)&P0.bindTextureMS);
		  blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RTHandles->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RTHandles);
		  this->fields.m_defaultTexture = UnityEngine::Rendering::RTHandleSystem::Alloc(blackTexture, 0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_defaultTexture,
		    v32,
		    v33,
		    v34,
		    *(MethodInfo **)&v47.handle,
		    v47.fallBackResource.m_Value,
		    P0.width,
		    P0.slices,
		    *(float *)&P0.colorFormat,
		    P0.wrapMode,
		    P0.enableRandomWrite,
		    SLOBYTE(P0.mipMapBias),
		    *(MethodInfo **)&P0.bindTextureMS);
		  if ( !resources->defaultResources )
		    goto LABEL_4;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_4;
		  if ( !materialCollector )
		    goto LABEL_4;
		  this->fields.m_interactionAddMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                            materialCollector,
		                                            shaders->fields.rippleRangePS,
		                                            0,
		                                            0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_interactionAddMaterial,
		    v36,
		    v37,
		    v38,
		    *(MethodInfo **)&v47.handle,
		    v47.fallBackResource.m_Value,
		    P0.width,
		    P0.slices,
		    *(float *)&P0.colorFormat,
		    P0.wrapMode,
		    P0.enableRandomWrite,
		    SLOBYTE(P0.mipMapBias),
		    *(MethodInfo **)&P0.bindTextureMS);
		  m_rippleTextureSize = resources->defaultResources;
		  if ( !resources->defaultResources
		    || (m_rippleTextureSize = (void *)*((_QWORD *)m_rippleTextureSize + 3)) == 0LL
		    || (this->fields.m_interactionSimulateMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                       materialCollector,
		                                                       *((Shader **)m_rippleTextureSize + 132),
		                                                       0,
		                                                       0LL),
		        sub_18002D1B0(
		          (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_interactionSimulateMaterial,
		          v39,
		          v40,
		          v41,
		          *(MethodInfo **)&v47.handle,
		          v47.fallBackResource.m_Value,
		          P0.width,
		          P0.slices,
		          *(float *)&P0.colorFormat,
		          P0.wrapMode,
		          P0.enableRandomWrite,
		          SLOBYTE(P0.mipMapBias),
		          *(MethodInfo **)&P0.bindTextureMS),
		        (m_rippleTextureSize = resources->defaultResources) == 0LL)
		    || (m_rippleTextureSize = (void *)*((_QWORD *)m_rippleTextureSize + 3)) == 0LL )
		  {
		LABEL_4:
		    sub_1800D8260(v12, m_rippleTextureSize);
		  }
		  this->fields.m_interactionHeightConvertMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                      materialCollector,
		                                                      *((Shader **)m_rippleTextureSize + 133),
		                                                      0,
		                                                      0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_interactionHeightConvertMaterial,
		    v42,
		    v43,
		    v44,
		    *(MethodInfo **)&v47.handle,
		    v47.fallBackResource.m_Value,
		    P0.width,
		    P0.slices,
		    *(float *)&P0.colorFormat,
		    P0.wrapMode,
		    P0.enableRandomWrite,
		    SLOBYTE(P0.mipMapBias),
		    *(MethodInfo **)&P0.bindTextureMS);
		}
		
		static WaterInteractionRenderingPass() {} // 0x0000000184A31D90-0x0000000184A31F60
	
		// Methods
		private bool ShouldRender(HGSettingParameters settingParameters) => default; // 0x0000000189BEBDAC-0x0000000189BEBE44
		// Boolean ShouldRender(HGSettingParameters)
		bool HG::Rendering::Runtime::WaterInteractionRenderingPass::ShouldRender(
		        WaterInteractionRenderingPass *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3494, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		      if ( waterManager_k__BackingField )
		      {
		        result = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(waterManager_k__BackingField, 0LL);
		        this->fields.m_shouldRender = result;
		        if ( !result )
		          return result;
		        if ( settingParameters )
		          return HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                   settingParameters->fields._waterInteractiveEnable_k__BackingField,
		                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      }
		    }
		LABEL_8:
		    sub_1800D8260(waterManager_k__BackingField, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3494, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)settingParameters,
		           0LL);
		}
		
		private void Initialize() {} // 0x0000000189BEB244-0x0000000189BEB288
		// Void Initialize()
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::Initialize(
		        WaterInteractionRenderingPass *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3495, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3495, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		private void Release() {} // 0x0000000182EDAD30-0x0000000182EDADA0
		// Void Release()
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::Release(
		        WaterInteractionRenderingPass *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  TextureHandle v6; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3496, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3496, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_prevAddTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v6, 0LL);
		    this->fields.m_prevSimulateTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v6, 0LL);
		  }
		}
		
		public void Render(HGRenderGraph renderGraph, ScriptableRenderContext renderContext, HGSettingParameters settingParameters, float deltaTime, HGCamera hgCamera) {} // 0x0000000189BEB288-0x0000000189BEBDAC
		// Void Render(HGRenderGraph, ScriptableRenderContext, HGSettingParameters, Single, HGCamera)
		// Hidden C++ exception states: #wind=4 #try_helpers=1
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::Render(
		        WaterInteractionRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        ScriptableRenderContext renderContext,
		        HGSettingParameters *settingParameters,
		        float deltaTime,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object *v8; // r14
		  WaterInteractionRenderingPass *v9; // rsi
		  ProfilingSampler *v10; // rax
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGWaterManager *waterManager_k__BackingField; // rbx
		  CBHandle *v15; // rax
		  void *ptr; // xmm0_8
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  _DWORD *v21; // rax
		  TextureHandle m_prevAddTexture; // xmm0
		  TextureHandle m_prevSimulateTexture; // xmm0
		  ProfilingSampler *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  Object__Class *v27; // xmm1_8
		  Object *v28; // rax
		  Object *v29; // rbx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  TextureHandle v32; // xmm0
		  Object *v33; // rdx
		  unsigned int v34; // edx
		  unsigned __int64 v35; // r8
		  char v36; // dl
		  signed __int64 v37; // rtt
		  ProfilingSampler *v38; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  Object__Class *v41; // xmm1_8
		  Object *v42; // rax
		  Object *v43; // r15
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  TextureHandle v46; // xmm0
		  Object *v47; // r15
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  TextureHandle v50; // xmm0
		  Object *v51; // rdx
		  unsigned int v52; // edx
		  unsigned __int64 v53; // r8
		  char v54; // dl
		  signed __int64 v55; // rtt
		  Object *v56; // r15
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  TextureHandle v59; // xmm0
		  ProfilingSampler *v60; // rax
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  Object__Class *v63; // xmm1_8
		  Object *v64; // rax
		  Object *v65; // r14
		  __int64 v66; // rdx
		  __int64 v67; // rcx
		  TextureHandle v68; // xmm0
		  Object *v69; // rdx
		  unsigned int v70; // edx
		  unsigned __int64 v71; // r8
		  char v72; // dl
		  signed __int64 v73; // rtt
		  Object *v74; // rbx
		  __int64 v75; // rdx
		  __int64 v76; // rcx
		  TextureHandle v77; // xmm0
		  __int64 v78; // rdx
		  __int64 v79; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v81; // rdx
		  __int64 v82; // rcx
		  TextureHandle v83; // [rsp+50h] [rbp-138h] BYREF
		  Object *v84; // [rsp+60h] [rbp-128h] BYREF
		  Object *v85; // [rsp+68h] [rbp-120h] BYREF
		  Object *v86; // [rsp+70h] [rbp-118h] BYREF
		  Color v87; // [rsp+80h] [rbp-108h] BYREF
		  HGRenderGraphBuilder v88; // [rsp+90h] [rbp-F8h] BYREF
		  _QWORD v89[2]; // [rsp+B0h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v90; // [rsp+C0h] [rbp-C8h] BYREF
		  HGRenderGraphBuilder v91; // [rsp+E0h] [rbp-A8h] BYREF
		  HGRenderGraphBuilder v92; // [rsp+100h] [rbp-88h] BYREF
		  HGRenderGraphProfilingScope v93; // [rsp+120h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v94; // [rsp+138h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v95; // [rsp+140h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v96; // [rsp+148h] [rbp-40h] BYREF
		  ScriptableRenderContext P2; // [rsp+1A0h] [rbp+18h] BYREF
		
		  P2.m_Ptr = renderContext.m_Ptr;
		  v8 = (Object *)renderGraph;
		  v9 = this;
		  memset(&v93, 0, sizeof(v93));
		  memset(&v91, 0, sizeof(v91));
		  v86 = 0LL;
		  memset(&v90, 0, sizeof(v90));
		  v84 = 0LL;
		  memset(&v92, 0, sizeof(v92));
		  v85 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3497, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3497, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v82, v81);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1255(
		      Patch,
		      (Object *)v9,
		      v8,
		      P2,
		      (Object *)settingParameters,
		      deltaTime,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x32u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		      &v93,
		      (HGRenderGraph *)v8,
		      v10,
		      0LL);
		    v89[0] = 0LL;
		    v89[1] = &v93;
		    if ( HG::Rendering::Runtime::WaterInteractionRenderingPass::ShouldRender(v9, settingParameters, 0LL) )
		    {
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( !currentManagerContext )
		        sub_1800D8250(v13, v12);
		      waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v15 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer((CBHandle *)&v88, &P2, 320, 0LL);
		      ptr = v15->ptr;
		      *(_OWORD *)&v9->fields.m_cb.bufferId = *(_OWORD *)&v15->bufferId;
		      v9->fields.m_cb.ptr = ptr;
		      HG::Rendering::Runtime::WaterInteractionRenderingPass::UpdateWaterInteractionSafeDeltaTime(v9, deltaTime, 0LL);
		      if ( !waterManager_k__BackingField )
		        sub_1800D8250(v18, v17);
		      HG::Rendering::Runtime::HGWaterManager::PrepareWaterEnvParams(waterManager_k__BackingField, hgCamera, 0LL);
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		        (Void *)v9->fields.m_cb.ptr,
		        waterManager_k__BackingField->fields.waterRippleData.m_Buffer,
		        16 * waterManager_k__BackingField->fields.waterRippleData.m_Length,
		        0LL);
		      v21 = v9->fields.m_cb.ptr;
		      if ( !v21 )
		        sub_1800D8250(v20, v19);
		      v21[3] = LODWORD(v9->fields.waterInteractionSafeDeltaTime);
		      if ( !v8 )
		        sub_1800D8250(v20, v19);
		      v9->fields.m_currAddTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                       &v83,
		                                       (HGRenderGraph *)v8,
		                                       &v9->fields.m_desc,
		                                       0LL);
		      v9->fields.m_currSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                            &v83,
		                                            (HGRenderGraph *)v8,
		                                            &v9->fields.m_desc,
		                                            0LL);
		      v9->fields.m_currNormalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                          &v83,
		                                          (HGRenderGraph *)v8,
		                                          &v9->fields.m_normalDesc,
		                                          0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v9->fields.m_prevAddTexture, 0LL) )
		        m_prevAddTexture = v9->fields.m_prevAddTexture;
		      else
		        m_prevAddTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                              &v83,
		                              (HGRenderGraph *)v8,
		                              v9->fields.m_defaultTexture,
		                              0LL);
		      v9->fields.m_prevAddTexture = m_prevAddTexture;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v9->fields.m_prevSimulateTexture, 0LL) )
		        m_prevSimulateTexture = v9->fields.m_prevSimulateTexture;
		      else
		        m_prevSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                   &v83,
		                                   (HGRenderGraph *)v8,
		                                   v9->fields.m_defaultTexture,
		                                   0LL);
		      v9->fields.m_prevSimulateTexture = m_prevSimulateTexture;
		      v24 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x33u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v88,
		        (HGRenderGraph *)v8,
		        (String *)"Interaction Add",
		        &v86,
		        v24,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionAddData>);
		      v91 = v88;
		      v83.handle = 0LL;
		      v83.fallBackResource = (ResourceHandle)&v91;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v91, 0, 0LL);
		        v27 = (Object__Class *)v9->fields.m_cb.ptr;
		        v28 = v86;
		        if ( !v86 )
		          sub_1800D8250(v26, v25);
		        v86[1] = *(Object *)&v9->fields.m_cb.bufferId;
		        v28[2].klass = v27;
		        v29 = v86;
		        v32 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&v87,
		                 &v91,
		                 &v9->fields.m_prevSimulateTexture,
		                 0LL);
		        if ( !v29 )
		          sub_1800D8250(v31, v30);
		        *(TextureHandle *)&v29[2].monitor = v32;
		        v33 = v86;
		        if ( !v86 )
		          sub_1800D8250(v31, 0LL);
		        v86[3].monitor = (MonitorData *)v9->fields.m_interactionAddMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v34 = ((unsigned __int64)&v33[3].monitor >> 12) & 0x1FFFFF;
		          v35 = (unsigned __int64)v34 >> 6;
		          v36 = v34 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v35 + 36190]);
		          do
		            v37 = qword_18F0BCBA0[v35 + 36190];
		          while ( v37 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v35 + 36190], v37 | (1LL << v36), v37) );
		        }
		        v87 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v88,
		          &v91,
		          &v9->fields.m_currAddTexture,
		          0,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          &v87,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v91,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass->static_fields->s_interactionAddRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionAddData>);
		      }
		      catch ( Il2CppExceptionWrapper *v94 )
		      {
		        v83.handle = (ResourceHandle)v94->ex;
		        sub_180268AE0(&v83);
		        v8 = (Object *)renderGraph;
		        v9 = this;
		        goto LABEL_24;
		      }
		      sub_180268AE0(&v83);
		LABEL_24:
		      v38 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x34u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v88,
		        (HGRenderGraph *)v8,
		        (String *)"RippleSimulate",
		        &v84,
		        v38,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
		      v90 = v88;
		      v83.handle = 0LL;
		      v83.fallBackResource = (ResourceHandle)&v90;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v90, 0, 0LL);
		        v41 = (Object__Class *)v9->fields.m_cb.ptr;
		        v42 = v84;
		        if ( !v84 )
		          sub_1800D8250(v40, v39);
		        v84[1] = *(Object *)&v9->fields.m_cb.bufferId;
		        v42[2].klass = v41;
		        v43 = v84;
		        v46 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&v88,
		                 &v90,
		                 &v9->fields.m_prevAddTexture,
		                 0LL);
		        if ( !v43 )
		          sub_1800D8250(v45, v44);
		        *(TextureHandle *)&v43[2].monitor = v46;
		        v47 = v84;
		        v50 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&v88,
		                 &v90,
		                 &v9->fields.m_currAddTexture,
		                 0LL);
		        if ( !v47 )
		          sub_1800D8250(v49, v48);
		        *(TextureHandle *)&v47[3].monitor = v50;
		        v51 = v84;
		        if ( !v84 )
		          sub_1800D8250(v49, 0LL);
		        v84[5].monitor = (MonitorData *)v9->fields.m_interactionSimulateMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v52 = ((unsigned __int64)&v51[5].monitor >> 12) & 0x1FFFFF;
		          v53 = (unsigned __int64)v52 >> 6;
		          v54 = v52 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v53 + 36190]);
		          do
		            v55 = qword_18F0BCBA0[v53 + 36190];
		          while ( v55 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v53 + 36190], v55 | (1LL << v54), v55) );
		        }
		        v56 = v84;
		        v87 = 0LL;
		        v59 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                 (TextureHandle *)&v88,
		                 &v90,
		                 &v9->fields.m_currSimulateTexture,
		                 0,
		                 RenderBufferLoadAction__Enum_Clear,
		                 RenderBufferStoreAction__Enum_Store,
		                 &v87,
		                 0,
		                 0LL);
		        if ( !v56 )
		          sub_1800D8250(v58, v57);
		        *(TextureHandle *)&v56[4].monitor = v59;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v90,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass->static_fields->s_interactionSimulateRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
		      }
		      catch ( Il2CppExceptionWrapper *v95 )
		      {
		        v83.handle = (ResourceHandle)v95->ex;
		        sub_180268AE0(&v83);
		        v8 = (Object *)renderGraph;
		        v9 = this;
		        goto LABEL_35;
		      }
		      sub_180268AE0(&v83);
		LABEL_35:
		      v60 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x35u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v88,
		        (HGRenderGraph *)v8,
		        (String *)"RippleHeightConvertToNormal",
		        &v85,
		        v60,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionHeightConvertData>);
		      v92 = v88;
		      v83.handle = 0LL;
		      v83.fallBackResource = (ResourceHandle)&v92;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v92, 0, 0LL);
		        v63 = (Object__Class *)v9->fields.m_cb.ptr;
		        v64 = v85;
		        if ( !v85 )
		          sub_1800D8250(v62, v61);
		        v85[1] = *(Object *)&v9->fields.m_cb.bufferId;
		        v64[2].klass = v63;
		        v65 = v85;
		        v68 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&v88,
		                 &v92,
		                 &v9->fields.m_currSimulateTexture,
		                 0LL);
		        if ( !v65 )
		          sub_1800D8250(v67, v66);
		        *(TextureHandle *)&v65[2].monitor = v68;
		        v69 = v85;
		        if ( !v85 )
		          sub_1800D8250(v67, 0LL);
		        v85[4].monitor = (MonitorData *)v9->fields.m_interactionHeightConvertMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v70 = ((unsigned __int64)&v69[4].monitor >> 12) & 0x1FFFFF;
		          v71 = (unsigned __int64)v70 >> 6;
		          v72 = v70 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v71 + 36190]);
		          do
		            v73 = qword_18F0BCBA0[v71 + 36190];
		          while ( v73 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v71 + 36190], v73 | (1LL << v72), v73) );
		        }
		        v74 = v85;
		        v87 = 0LL;
		        v77 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                 (TextureHandle *)&v88,
		                 &v92,
		                 &v9->fields.m_currNormalTexture,
		                 0,
		                 RenderBufferLoadAction__Enum_Clear,
		                 RenderBufferStoreAction__Enum_Store,
		                 &v87,
		                 0,
		                 0LL);
		        if ( !v74 )
		          sub_1800D8250(v76, v75);
		        *(TextureHandle *)&v74[3].monitor = v77;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v92,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass->static_fields->s_interactionNormalConvertRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionHeightConvertData>);
		      }
		      catch ( Il2CppExceptionWrapper *v96 )
		      {
		        v83.handle = (ResourceHandle)v96->ex;
		        sub_180268AE0(&v83);
		        sub_180269330(v89);
		        return;
		      }
		      sub_180268AE0(&v83);
		      sub_180269330(v89);
		    }
		    else
		    {
		      HG::Rendering::Runtime::WaterInteractionRenderingPass::Release(v9, 0LL);
		      if ( !v8 )
		        sub_1800D8250(v79, v78);
		      v9->fields.m_currSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                            (TextureHandle *)&v88,
		                                            (HGRenderGraph *)v8,
		                                            v9->fields.m_defaultTexture,
		                                            0LL);
		      v9->fields.m_currNormalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                          (TextureHandle *)&v88,
		                                          (HGRenderGraph *)v8,
		                                          v9->fields.m_defaultTexture,
		                                          0LL);
		      HG::Rendering::Runtime::WaterInteractionRenderingPass::FallbackRender(v9, (HGRenderGraph *)v8, 0LL);
		      sub_180269330(v89);
		    }
		  }
		}
		
		private void UpdateWaterInteractionSafeDeltaTime(float dt) {} // 0x0000000189BEBE44-0x0000000189BEBEFC
		// Void UpdateWaterInteractionSafeDeltaTime(Single)
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::UpdateWaterInteractionSafeDeltaTime(
		        WaterInteractionRenderingPass *this,
		        float dt,
		        MethodInfo *method)
		{
		  float v4; // xmm6_4
		  int v5; // xmm0_4
		  float v6; // xmm0_4
		  float v7; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  v4 = dt;
		  if ( IFix::WrappersManagerImpl::IsPatched(3499, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3499, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, dt, 0LL);
		  }
		  else
		  {
		    v5 = 1007192201;
		    if ( dt < 0.0083333338 || (v5 = 1023969417, dt > 0.033333335) )
		      v4 = *(float *)&v5;
		    v6 = this->fields.waterInteractionSafeDeltaTime * 0.1;
		    v7 = v4 - this->fields.waterInteractionSafeDeltaTime;
		    if ( (float)-v6 > v7 )
		    {
		      v7 = -v6;
		    }
		    else if ( v7 > v6 )
		    {
		      v7 = this->fields.waterInteractionSafeDeltaTime * 0.1;
		    }
		    this->fields.waterInteractionSafeDeltaTime = v7 + this->fields.waterInteractionSafeDeltaTime;
		  }
		}
		
		public void FallbackRender(HGRenderGraph renderGraph) {} // 0x0000000189BEAEFC-0x0000000189BEB068
		// Void FallbackRender(HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::FallbackRender(
		        WaterInteractionRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ProfilingSampler *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  int v8; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Il2CppExceptionWrapper *v12; // [rsp+40h] [rbp-58h] BYREF
		  _QWORD v13[4]; // [rsp+48h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v14; // [rsp+68h] [rbp-30h] BYREF
		  __int64 v15; // [rsp+B8h] [rbp+20h] BYREF
		
		  memset(&v14, 0, sizeof(v14));
		  v15 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3498, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3498, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    v5 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x34u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v7, v6);
		    v14 = *(HGRenderGraphBuilder *)sub_1808AFC00(
		                                     (unsigned int)v13,
		                                     (_DWORD)renderGraph,
		                                     v8,
		                                     (unsigned int)&v15,
		                                     (__int64)v5);
		    v13[0] = 0LL;
		    v13[1] = &v14;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v14, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v14,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass->static_fields->s_fallbackRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterInteractionRenderingPass::InteractionSimulateData>);
		    }
		    catch ( Il2CppExceptionWrapper *v12 )
		    {
		      v13[0] = v12->ex;
		    }
		    sub_180268AE0(v13);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BEB1F0-0x0000000189BEB244
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        WaterInteractionRenderingPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3500, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3500, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BEB178-0x0000000189BEB1F0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        WaterInteractionRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3501, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3501, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_currAddTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v8, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BEB068-0x0000000189BEB178
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::WaterInteractionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        WaterInteractionRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  HGRenderGraph *renderGraph; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v8; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3502, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3502, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		  else
		  {
		    if ( !input->passSkipped )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currAddTexture, 0LL) )
		      {
		        renderGraph = input->renderGraph;
		        if ( renderGraph )
		        {
		          this->fields.m_prevAddTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                             &v8,
		                                             renderGraph,
		                                             &this->fields.m_currAddTexture,
		                                             1,
		                                             (String *)"WaterInteractionRenderingPass",
		                                             0LL);
		          renderGraph = input->renderGraph;
		          if ( renderGraph )
		          {
		            this->fields.m_prevSimulateTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                    &v8,
		                                                    renderGraph,
		                                                    &this->fields.m_currSimulateTexture,
		                                                    1,
		                                                    (String *)"WaterInteractionRenderingPass",
		                                                    0LL);
		            return;
		          }
		        }
		LABEL_9:
		        sub_1800D8260(v5, renderGraph);
		      }
		    }
		    HG::Rendering::Runtime::WaterInteractionRenderingPass::Release(this, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184B20840-0x0000000184B20A30
	}
}
