using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ForwardPassConstructor : IPassConstructor // TypeDefIndex: 38277
	{
		// Fields
		private static string s_forwardPassName; // 0x00
		private static readonly RenderFunc<ForwardPassUtils.ForwardPassData> s_forwardRenderFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38274
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal HGRenderPipeline hgrp; // 0x20
			internal uint forwardOpaqueECSRendererList; // 0x28
			internal uint forwardOpaqueEqualECSRendererList; // 0x2C
			internal uint characterOpaqueECSRendererList; // 0x30
			internal uint characterOutlineOpaqueECSRendererList; // 0x34
			internal uint characterOutlineOpaqueEqualECSRendererList; // 0x38
			internal uint forwardTransparentECSRendererList; // 0x3C
			internal uint forwardOccludedDisplayECSRendererList; // 0x40
			internal ShadowResult shadowResult; // 0x44
			internal CullingResults cullingResults; // 0x80
			internal PerObjectData bakedLightingConfig; // 0x90
			internal float screenCullingRatio; // 0x94
			internal float screenCullingRatioDistance; // 0x98
			internal uint screenCullingLayerMask; // 0x9C
			internal bool characterOutlineEnabled; // 0xA0
		}
	
		internal struct PassOutput // TypeDefIndex: 38275
		{
		}
	
		// Constructors
		public ForwardPassConstructor() {} // Dummy constructor
		internal ForwardPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static ForwardPassConstructor() {} // 0x0000000189BAB090-0x0000000189BAB144
		// ForwardPassConstructor()
		void HG::Rendering::Runtime::ForwardPassConstructor::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  Object *v4; // rdi
		  RenderFunc_1_System_Object_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardPassData_ *v8; // rbx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor->static_fields->s_forwardPassName = (String *)"Forward (+ Emissive)";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor->static_fields,
		    v1,
		    v2,
		    v3,
		    v12);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor::__c);
		  v4 = (Object *)TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor::__c->static_fields->__9;
		  v5 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
		  v8 = (RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardPassData_ *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v5,
		    v4,
		    MethodInfo::HG::Rendering::Runtime::ForwardPassConstructor::__c::__cctor_b__11_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor->static_fields->s_forwardRenderFunc = v8;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor->static_fields->s_forwardRenderFunc,
		    v9,
		    v10,
		    v11,
		    v13);
		}
		
	
		// Methods
		private void PrepareForwardPassData(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, ForwardPassUtils.ForwardPassData passData) {} // 0x0000000189BAAD3C-0x0000000189BAB090
		// Void PrepareForwardPassData(ForwardPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, ForwardPassUtils+ForwardPassData)
		void HG::Rendering::Runtime::ForwardPassConstructor::PrepareForwardPassData(
		        ForwardPassConstructor *this,
		        ForwardPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGRenderGraphBuilder *builder,
		        ForwardPassUtils_ForwardPassData *passData,
		        MethodInfo *method)
		{
		  __int64 forwardOpaqueECSRendererList; // rdx
		  uint32_t forwardOpaqueEqualECSRendererList; // r8d
		  uint32_t characterOpaqueECSRendererList; // r9d
		  uint32_t characterOutlineOpaqueECSRendererList; // r10d
		  uint32_t characterOutlineOpaqueEqualECSRendererList; // r11d
		  bool characterOutlineEnabled; // si
		  float screenCullingRatio; // xmm2_4
		  float screenCullingRatioDistance; // xmm3_4
		  uint32_t screenCullingLayerMask; // r14d
		  __int128 v20; // xmm1
		  HGRenderPipeline *hgrp; // rcx
		  __int128 v22; // xmm0
		  HGRenderPipeline *v23; // r12
		  TextureHandle v24; // xmm10
		  TextureHandle v25; // xmm7
		  TextureHandle *nullHandle; // rax
		  unsigned int v27; // r14d
		  uint32_t forwardTransparentECSRendererList; // esi
		  bool v29; // di
		  TextureHandle v30; // xmm6
		  uint32_t v31; // ebx
		  float v32; // xmm9_4
		  float v33; // xmm8_4
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int64 v36; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v38; // xmm1
		  unsigned int bakedLightingConfig; // [rsp+28h] [rbp-118h]
		  ForwardPassUtils_ForwardOpaquePassData *opaqueData; // [rsp+78h] [rbp-C8h]
		  ForwardPassUtils_ForwardTransparentPassData *transparentData; // [rsp+78h] [rbp-C8h]
		  TextureHandle v42; // [rsp+C0h] [rbp-80h] BYREF
		  CullingResults cullingResults; // [rsp+D0h] [rbp-70h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+E0h] [rbp-60h] BYREF
		  TextureHandle v45; // [rsp+100h] [rbp-40h] BYREF
		  TextureHandle v46; // [rsp+110h] [rbp-30h] BYREF
		  HGRenderGraphBuilder v47; // [rsp+120h] [rbp-20h] BYREF
		  BasicTransformConstants v48; // [rsp+140h] [rbp+0h] BYREF
		  ShaderVariablesGlobal v49; // [rsp+660h] [rbp+520h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3165, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3165, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v36);
		    v38 = *(_OWORD *)&builder->m_RenderGraph;
		    *(_OWORD *)&v44.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v44.m_RenderGraph = v38;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1171(
		      Patch,
		      (Object *)this,
		      input,
		      (Object *)renderGraph,
		      (Object *)camera,
		      &v44,
		      (Object *)passData,
		      0LL);
		  }
		  else
		  {
		    forwardOpaqueECSRendererList = input->forwardOpaqueECSRendererList;
		    forwardOpaqueEqualECSRendererList = input->forwardOpaqueEqualECSRendererList;
		    characterOpaqueECSRendererList = input->characterOpaqueECSRendererList;
		    characterOutlineOpaqueECSRendererList = input->characterOutlineOpaqueECSRendererList;
		    characterOutlineOpaqueEqualECSRendererList = input->characterOutlineOpaqueEqualECSRendererList;
		    characterOutlineEnabled = input->characterOutlineEnabled;
		    screenCullingRatio = input->screenCullingRatio;
		    screenCullingRatioDistance = input->screenCullingRatioDistance;
		    screenCullingLayerMask = input->screenCullingLayerMask;
		    if ( !passData )
		      sub_1800D8260((unsigned int)input->bakedLightingConfig, forwardOpaqueECSRendererList);
		    opaqueData = passData->fields.opaqueData;
		    v20 = *(_OWORD *)&builder->m_RenderGraph;
		    bakedLightingConfig = input->bakedLightingConfig;
		    hgrp = input->hgrp;
		    cullingResults = input->cullingResults;
		    v22 = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v47.m_RenderGraph = v20;
		    *(_OWORD *)&v47.m_RenderPass = v22;
		    HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
		      hgrp,
		      renderGraph,
		      camera,
		      &v47,
		      &cullingResults,
		      (PerObjectData__Enum)bakedLightingConfig,
		      forwardOpaqueECSRendererList,
		      forwardOpaqueEqualECSRendererList,
		      characterOpaqueECSRendererList,
		      characterOutlineOpaqueECSRendererList,
		      characterOutlineOpaqueEqualECSRendererList,
		      characterOutlineEnabled,
		      screenCullingRatio,
		      screenCullingRatioDistance,
		      screenCullingLayerMask,
		      opaqueData,
		      0LL);
		    v23 = input->hgrp;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v24 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v42, 0LL);
		    v25 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v42, 0LL);
		    nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v42, 0LL);
		    v27 = input->bakedLightingConfig;
		    forwardTransparentECSRendererList = input->forwardTransparentECSRendererList;
		    v29 = input->characterOutlineEnabled;
		    v30 = *nullHandle;
		    v31 = input->screenCullingLayerMask;
		    v32 = input->screenCullingRatio;
		    v33 = input->screenCullingRatioDistance;
		    sub_18033B9D0(&v48, 0LL, 1312LL);
		    sub_18033B9D0(&v49, 0LL, 3200LL);
		    v34 = *(_OWORD *)&builder->m_RenderPass;
		    cullingResults = input->cullingResults;
		    v35 = *(_OWORD *)&builder->m_RenderGraph;
		    transparentData = passData->fields.transparentData;
		    *(_OWORD *)&v44.m_RenderPass = v34;
		    *(_OWORD *)&v44.m_RenderGraph = v35;
		    v45 = v30;
		    v46 = v25;
		    v42 = v24;
		    HG::Rendering::Runtime::ForwardPassUtils::PrepareTransparentPassData(
		      v23,
		      renderGraph,
		      &v42,
		      &v46,
		      &v45,
		      camera,
		      0LL,
		      &v44,
		      &cullingResults,
		      (PerObjectData__Enum)v27,
		      forwardTransparentECSRendererList,
		      v29,
		      v32,
		      v33,
		      v31,
		      transparentData,
		      0,
		      1,
		      1,
		      0,
		      &v48,
		      &v49,
		      0LL);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BAACE8-0x0000000189BAAD3C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ForwardPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3166, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3166, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BAAC94-0x0000000189BAACE8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ForwardPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3167, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3167, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BAA8D0-0x0000000189BAABEC
		// Void ConstructPass(ForwardPassConstructor+PassInput ByRef, ForwardPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ForwardPassConstructor::ConstructPass(
		        ForwardPassConstructor *this,
		        ForwardPassConstructor_PassInput *input,
		        ForwardPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  String *s_forwardPassName; // rsi
		  ProfilingSampler *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ForwardPassUtils_ForwardPassData *v21; // [rsp+40h] [rbp-C8h] BYREF
		  HGRenderGraphBuilder v22; // [rsp+48h] [rbp-C0h] BYREF
		  _QWORD v23[3]; // [rsp+68h] [rbp-A0h] BYREF
		  ShadowResult v24; // [rsp+80h] [rbp-88h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+C0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v26; // [rsp+E0h] [rbp-28h] BYREF
		
		  memset(&v22, 0, sizeof(v22));
		  v21 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3168, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3168, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1172(
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
		    if ( !camera )
		      sub_1800D8260(v11, v10);
		    *(BitArray128 *)&v24.directionalShadowActive = camera->fields._frameSettings_k__BackingField.bitDatas;
		    *(_QWORD *)&v24.directionalShadowResult.fallBackResource._type_k__BackingField = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v24,
		           FrameSettingsField__Enum_OpaqueObjects,
		           0LL) )
		    {
		      goto LABEL_6;
		    }
		    if ( !camera->fields.camera )
		      sub_1800D8260(v13, v12);
		    if ( UnityEngine::Camera::get_clearFlags(camera->fields.camera, 0LL) == CameraClearFlags__Enum_Skybox )
		    {
		LABEL_6:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
		      s_forwardPassName = TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor->static_fields->s_forwardPassName;
		      v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x21u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v17, v16);
		      v22 = *(HGRenderGraphBuilder *)sub_1808AF3B4(
		                                       (unsigned int)&v24,
		                                       (_DWORD)renderGraph,
		                                       (_DWORD)s_forwardPassName,
		                                       (unsigned int)&v21,
		                                       (__int64)v15);
		      v23[0] = 0LL;
		      v23[1] = &v22;
		      try
		      {
		        *(_OWORD *)&v25.m_RenderPass = *(_OWORD *)&v22.m_RenderPass;
		        *(_OWORD *)&v24.directionalShadowActive = *(_OWORD *)&v22.m_RenderGraph;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v25.m_RenderGraph = *(_OWORD *)&v24.directionalShadowActive;
		        HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v24, &input->shadowResult, &v25, 0LL);
		        *(_OWORD *)&v24.directionalShadowActive = *(_OWORD *)&v22.m_RenderPass;
		        *(_OWORD *)&v24.directionalShadowResult.fallBackResource._type_k__BackingField = *(_OWORD *)&v22.m_RenderGraph;
		        HG::Rendering::Runtime::ForwardPassConstructor::PrepareForwardPassData(
		          this,
		          input,
		          renderGraph,
		          camera,
		          (HGRenderGraphBuilder *)&v24,
		          v21,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v24,
		          &v22,
		          &input->sceneColor,
		          0,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v24,
		          &v22,
		          &input->sceneDepth,
		          DepthAccess__Enum_ReadWrite,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v22,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor->static_fields->s_forwardRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v26 )
		      {
		        v23[0] = v26->ex;
		      }
		      sub_180268AE0(v23);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BAAC40-0x0000000189BAAC94
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ForwardPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3169, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3169, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000189BAABEC-0x0000000189BAAC40
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ForwardPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3170, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3170, 0LL);
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
