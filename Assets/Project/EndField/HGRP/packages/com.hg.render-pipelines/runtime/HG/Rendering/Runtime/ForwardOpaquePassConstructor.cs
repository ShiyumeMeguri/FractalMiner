using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ForwardOpaquePassConstructor : IPassConstructor // TypeDefIndex: 38281
	{
		// Fields
		private static string s_forwardOpaquePassName; // 0x00
		private static readonly RenderFunc<ForwardPassUtils.ForwardPassData> s_forwardOpaqueRenderFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38278
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal TextureHandle terrainDepthBuffer; // 0x30
			internal HGRenderPipeline hgrp; // 0x40
			internal uint forwardOpaqueECSRendererList; // 0x48
			internal uint forwardOpaqueEqualECSRendererList; // 0x4C
			internal uint characterOpaqueECSRendererList; // 0x50
			internal uint characterOutlineOpaqueECSRendererList; // 0x54
			internal uint characterOutlineOpaqueEqualECSRendererList; // 0x58
			internal uint forwardOccludedDisplayECSRendererList; // 0x5C
			internal ShadowResult shadowResult; // 0x60
			internal CullingResults cullingResults; // 0xA0
			internal PerObjectData bakedLightingConfig; // 0xB0
			internal float screenCullingRatio; // 0xB4
			internal float screenCullingRatioDistance; // 0xB8
			internal uint screenCullingLayerMask; // 0xBC
			internal bool characterOutlineEnabled; // 0xC0
		}
	
		internal struct PassOutput // TypeDefIndex: 38279
		{
		}
	
		// Constructors
		internal ForwardOpaquePassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static ForwardOpaquePassConstructor() {} // 0x0000000184CEC270-0x0000000184CEC340
		// ForwardOpaquePassConstructor()
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  struct ForwardOpaquePassConstructor_c__Class *v4; // r9
		  Object *v5; // rdi
		  RenderFunc_1_System_Object_ *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardPassData_ *v9; // rbx
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor->static_fields->s_forwardOpaquePassName = (String *)"Forward Opaque";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor->static_fields,
		    v1,
		    v2,
		    v3,
		    v13);
		  v4 = TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor::__c);
		    v4 = TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor::__c;
		  }
		  v5 = (Object *)v4->static_fields->__9;
		  v6 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
		  v9 = (RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardPassData_ *)v6;
		  if ( !v6 )
		    sub_1800D8260(v8, v7);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v6,
		    v5,
		    MethodInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor::__c::__cctor_b__11_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor->static_fields->s_forwardOpaqueRenderFunc = v9;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor->static_fields->s_forwardOpaqueRenderFunc,
		    v10,
		    v11,
		    v12,
		    v14);
		}
		
	
		// Methods
		private void PrepareForwardOpaquePassData(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, ForwardPassUtils.ForwardPassData passData) {} // 0x0000000189BAA724-0x0000000189BAA8D0
		// Void PrepareForwardOpaquePassData(ForwardOpaquePassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, ForwardPassUtils+ForwardPassData)
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::PrepareForwardOpaquePassData(
		        ForwardOpaquePassConstructor *this,
		        ForwardOpaquePassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGRenderGraphBuilder *builder,
		        ForwardPassUtils_ForwardPassData *passData,
		        MethodInfo *method)
		{
		  __int64 bakedLightingConfig; // rdx
		  uint32_t forwardOpaqueECSRendererList; // r8d
		  uint32_t forwardOpaqueEqualECSRendererList; // r9d
		  uint32_t characterOpaqueECSRendererList; // r10d
		  uint32_t characterOutlineOpaqueECSRendererList; // r11d
		  uint32_t characterOutlineOpaqueEqualECSRendererList; // ebp
		  bool characterOutlineEnabled; // r14
		  float screenCullingRatio; // xmm2_4
		  float screenCullingRatioDistance; // xmm3_4
		  uint32_t screenCullingLayerMask; // r15d
		  __int128 v21; // xmm0
		  HGRenderPipeline *hgrp; // rcx
		  __int64 v23; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v25; // xmm1
		  ForwardPassUtils_ForwardOpaquePassData *opaqueData; // [rsp+78h] [rbp-60h]
		  CullingResults cullingResults; // [rsp+90h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v28; // [rsp+A0h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3171, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3171, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v23);
		    v25 = *(_OWORD *)&builder->m_RenderGraph;
		    *(_OWORD *)&v28.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v28.m_RenderGraph = v25;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1173(
		      Patch,
		      (Object *)this,
		      input,
		      (Object *)renderGraph,
		      (Object *)camera,
		      &v28,
		      (Object *)passData,
		      0LL);
		  }
		  else
		  {
		    bakedLightingConfig = (unsigned int)input->bakedLightingConfig;
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
		      sub_1800D8260(0LL, bakedLightingConfig);
		    cullingResults = input->cullingResults;
		    v21 = *(_OWORD *)&builder->m_RenderGraph;
		    hgrp = input->hgrp;
		    opaqueData = passData->fields.opaqueData;
		    *(_OWORD *)&v28.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v28.m_RenderGraph = v21;
		    HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
		      hgrp,
		      renderGraph,
		      camera,
		      &v28,
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
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BAA6D0-0x0000000189BAA724
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ForwardOpaquePassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3172, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3172, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BAA67C-0x0000000189BAA6D0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ForwardOpaquePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3173, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3173, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BAA268-0x0000000189BAA628
		// Void ConstructPass(ForwardOpaquePassConstructor+PassInput ByRef, ForwardOpaquePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::ConstructPass(
		        ForwardOpaquePassConstructor *this,
		        ForwardOpaquePassConstructor_PassInput *input,
		        ForwardOpaquePassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  String *s_forwardOpaquePassName; // rsi
		  ProfilingSampler *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int128 v18; // xmm6
		  __int128 v19; // xmm7
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  HGRenderGraphBuilder v23; // [rsp+50h] [rbp-F8h] BYREF
		  ForwardPassUtils_ForwardPassData *v24; // [rsp+70h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+80h] [rbp-C8h] BYREF
		  _QWORD v26[2]; // [rsp+A0h] [rbp-A8h] BYREF
		  __m128i si128; // [rsp+B0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v28; // [rsp+C0h] [rbp-88h] BYREF
		  ShadowResult v29; // [rsp+C8h] [rbp-80h] BYREF
		
		  memset(&v23, 0, sizeof(v23));
		  v24 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3174, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3174, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, v21);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1174(
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
		    *(BitArray128 *)&v25.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		    v25.m_RenderGraph = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v25,
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
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
		      s_forwardOpaquePassName = TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor->static_fields->s_forwardOpaquePassName;
		      v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x22u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v17, v16);
		      v23 = *(HGRenderGraphBuilder *)sub_1808AF3B4(
		                                       (unsigned int)&v25,
		                                       (_DWORD)renderGraph,
		                                       (_DWORD)s_forwardOpaquePassName,
		                                       (unsigned int)&v24,
		                                       (__int64)v15);
		      v26[0] = 0LL;
		      v26[1] = &v23;
		      try
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->terrainDepthBuffer, 0LL) )
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		            (TextureHandle *)&si128,
		            &v23,
		            &input->terrainDepthBuffer,
		            0LL);
		        v18 = *(_OWORD *)&v23.m_RenderPass;
		        v19 = *(_OWORD *)&v23.m_RenderGraph;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v25.m_RenderPass = v18;
		        *(_OWORD *)&v25.m_RenderGraph = v19;
		        HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v29, &input->shadowResult, &v25, 0LL);
		        v25 = v23;
		        HG::Rendering::Runtime::ForwardOpaquePassConstructor::PrepareForwardOpaquePassData(
		          this,
		          input,
		          renderGraph,
		          camera,
		          &v25,
		          v24,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&si128,
		          &v23,
		          &input->sceneColor,
		          0,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&si128,
		          &v23,
		          &input->sceneDepth,
		          DepthAccess__Enum_ReadWrite,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		        {
		          si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v25,
		            &v23,
		            &input->sceneMV,
		            1,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&si128,
		            0,
		            0LL);
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v23,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor->static_fields->s_forwardOpaqueRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v28 )
		      {
		        v26[0] = v28->ex;
		      }
		      sub_180268AE0(v26);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BAA628-0x0000000189BAA67C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ForwardOpaquePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3175, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3175, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D804A0-0x0000000184D804D0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ForwardOpaquePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3176, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3176, 0LL);
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
