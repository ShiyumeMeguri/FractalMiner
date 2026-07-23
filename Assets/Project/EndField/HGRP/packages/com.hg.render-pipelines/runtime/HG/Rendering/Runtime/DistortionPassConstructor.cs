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
	internal class DistortionPassConstructor : IPassConstructor // TypeDefIndex: 38252
	{
		// Fields
		private uint m_feedbackID; // 0x10
		private static readonly RenderFunc<DistortionPasssData> s_distortionUselessRenderFunc; // 0x00
		private static readonly RenderFunc<DistortionPasssData> s_distortionObjectsRenderFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38248
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal ShadowResult shadowResult; // 0x30
			internal CullingResults cullingResults; // 0x70
			internal PerObjectData bakedLightConfig; // 0x80
			internal float screenCullingRatio; // 0x84
			internal float screenCullingRatioDistance; // 0x88
			internal uint screenCullingLayerMask; // 0x8C
			internal uint transparentAfterDistortionECSList; // 0x90
		}
	
		internal struct PassOutput // TypeDefIndex: 38249
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
		}
	
		private class DistortionPasssData // TypeDefIndex: 38250
		{
			// Fields
			internal FrameSettings frameSettings; // 0x10
			internal HGCamera camera; // 0x28
			internal int cameraGuid; // 0x30
			internal int cameraCullingMask; // 0x34
			internal TextureHandle sceneColorToSample; // 0x38
			internal RendererListHandle distortionOpaqueRendererList; // 0x48
			internal RendererListHandle distortionTransparentRendererList; // 0x50
			internal uint distortionOpaqueECSList; // 0x58
			internal uint distortionTransparentECSList; // 0x5C
			internal uint transparentAfterDistortionECSList; // 0x60
			internal FullScreenVFXData fullScreenVFXData; // 0x68
	
			// Constructors
			public DistortionPasssData() {} // 0x0000000189BA5CFC-0x0000000189BA5D44
			// DistortionPassConstructor+DistortionPasssData()
			void HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData::DistortionPasssData(
			        DistortionPassConstructor_DistortionPasssData *this,
			        MethodInfo *method)
			{
			  FullScreenVFXData *v3; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			  FullScreenVFXData *v6; // rbx
			  Type *v7; // rdx
			  PropertyInfo_1 *v8; // r8
			  Int32__Array **v9; // r9
			  MethodInfo *v10; // [rsp+50h] [rbp+28h]
			
			  v3 = (FullScreenVFXData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::FullScreenVFXData);
			  v6 = v3;
			  if ( !v3 )
			    sub_1800D8260(v5, v4);
			  HG::Rendering::Runtime::FullScreenVFXData::FullScreenVFXData(v3, 0LL);
			  this->fields.fullScreenVFXData = v6;
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields.fullScreenVFXData, v7, v8, v9, v10);
			}
			
		}
	
		// Constructors
		public DistortionPassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static DistortionPassConstructor() {} // 0x0000000184CB4340-0x0000000184CB4440
		// DistortionPassConstructor()
		void HG::Rendering::Runtime::DistortionPassConstructor::cctor(MethodInfo *method)
		{
		  struct DistortionPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Type__Class *v6; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c::__cctor_b__13_0,
		          0LL),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::DistortionPassConstructor::__c::__cctor_b__13_1,
		    0LL);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor->static_fields->s_distortionObjectsRenderFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		private static Vector3[] GetFullScreenTriangleVertexPosition(float z) => default; // 0x0000000189BA5B00-0x0000000189BA5C00
		// Vector3[] GetFullScreenTriangleVertexPosition(Single)
		Vector3__Array *HG::Rendering::Runtime::DistortionPassConstructor::GetFullScreenTriangleVertexPosition(
		        float z,
		        MethodInfo *method)
		{
		  __int64 v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Vector3__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v8; // [rsp+20h] [rbp-48h] BYREF
		  float v9; // [rsp+28h] [rbp-40h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3113, 0LL) )
		  {
		    v2 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 3LL);
		    v5 = (Vector3__Array *)v2;
		    if ( v2 )
		    {
		      v9 = z;
		      v8 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      sub_180049BD0(v2, 0LL, &v8);
		      v9 = z;
		      v8 = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL).m128_u64[0];
		      sub_180049BD0(v5, 1LL, &v8);
		      v9 = z;
		      v8 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u).m128_u64[0];
		      sub_180049BD0(v5, 2LL, &v8);
		      return v5;
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3113, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_431(Patch, z, 0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BA5CA8-0x0000000189BA5CFC
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DistortionPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3114, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3114, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BA5C54-0x0000000189BA5CA8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DistortionPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3115, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3115, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BA4E10-0x0000000189BA5B00
		// Void ConstructPass(DistortionPassConstructor+PassInput ByRef, DistortionPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DistortionPassConstructor::ConstructPass(
		        DistortionPassConstructor *this,
		        DistortionPassConstructor_PassInput *input,
		        DistortionPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  HGGraphicsFeatureSwitch *distortionOpaque; // rcx
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rdx
		  HGGraphicsFeatureSwitch *distortionTransparent; // rcx
		  __int64 v17; // rdx
		  MonitorData *monitor; // rdi
		  bool fullScreenMeshRenderable; // al
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  HGRainRenderer *s_rainRenderer; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  HGSnowRenderer *s_snowRenderer; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  MonitorData *v30; // rcx
		  int v31; // eax
		  PerObjectData__Enum v32; // r12d
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  PerObjectData__Enum v35; // r13d
		  CullingResults cullingResults; // xmm8
		  HGShaderPassNames__StaticFields *v37; // rbx
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // edi
		  RendererListDesc *v41; // rax
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle v43; // rdx
		  RendererListHandle v44; // rcx
		  CullingResults v45; // xmm8
		  HGShaderPassNames__StaticFields *v46; // rbx
		  float v47; // xmm7_4
		  float v48; // xmm6_4
		  uint32_t v49; // edi
		  RendererListDesc *v50; // rax
		  RendererListHandle v51; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  uint32_t cullingViewHandle; // edi
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  HGRenderGraphContext *HGContext; // rbx
		  void *context; // rdx
		  uint32_t v59; // ebx
		  uint32_t RendererList; // r13d
		  uint32_t v61; // r12d
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  HGRenderGraphContext *v64; // rdi
		  Object *v65; // rdi
		  __int64 v66; // rdx
		  __int64 v67; // rcx
		  TextureHandle v68; // xmm0
		  TextureDesc *TextureDescRef; // rax
		  DistortionPassConstructor_PassOutput *Texture; // rax
		  TextureHandle sceneColor; // xmm0
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  __int128 v76; // xmm6
		  __int128 v77; // xmm7
		  Object__Class *v78; // xmm1_8
		  Object *v79; // rax
		  Object *v80; // rdi
		  Object_1 *v81; // rcx
		  int32_t InstanceID; // eax
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  Object *v85; // rdi
		  Camera *v86; // rcx
		  int32_t cullingMask; // eax
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  Object *v90; // rdx
		  unsigned int v91; // edx
		  unsigned __int64 v92; // r8
		  signed __int64 v93; // rtt
		  Object *v94; // rcx
		  __int64 transparentAfterDistortionECSList; // rcx
		  MonitorData *v96; // rax
		  Camera *v97; // rcx
		  __int64 v98; // rdx
		  float v99; // xmm0_4
		  float v100; // xmm2_4
		  float v101; // xmm2_4
		  MonitorData *v102; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-388h]
		  bool enabled; // [rsp+70h] [rbp-338h]
		  bool v106; // [rsp+71h] [rbp-337h]
		  char v107; // [rsp+72h] [rbp-336h]
		  Object *v108; // [rsp+78h] [rbp-330h] BYREF
		  RendererListHandle v109; // [rsp+80h] [rbp-328h] BYREF
		  void *outPtr; // [rsp+88h] [rbp-320h] BYREF
		  TextureHandle v111; // [rsp+90h] [rbp-318h] BYREF
		  __m128i si128; // [rsp+A0h] [rbp-308h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderQueueRange_ inputa; // [rsp+B0h] [rbp-2F8h] BYREF
		  HGRenderGraphBuilder v114; // [rsp+C0h] [rbp-2E8h] BYREF
		  HGRenderGraphBuilder v115; // [rsp+E0h] [rbp-2C8h] BYREF
		  _QWORD v116[4]; // [rsp+100h] [rbp-2A8h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v117; // [rsp+120h] [rbp-288h] BYREF
		  RendererListDesc desc; // [rsp+190h] [rbp-218h] BYREF
		  RendererListDesc v119; // [rsp+270h] [rbp-138h] BYREF
		
		  v108 = 0LL;
		  outPtr = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3116, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3116, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1148(
		        Patch,
		        (Object *)this,
		        input,
		        output,
		        (Object *)renderGraph,
		        (Object *)camera,
		        0LL);
		      return;
		    }
		LABEL_69:
		    sub_1800D8250(v12, v11);
		  }
		  v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)9u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  if ( !renderGraph )
		    goto LABEL_69;
		  HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		    &v114,
		    renderGraph,
		    (String *)"Distortion Pass",
		    &v108,
		    v10,
		    1,
		    ProfilingHGPass__Enum_Distortion,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
		  v115 = v114;
		  v116[0] = 0LL;
		  v116[1] = &v115;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		  distortionOpaque = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->distortionOpaque;
		  if ( !distortionOpaque )
		    sub_1800D8250(0LL, v13);
		  enabled = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(distortionOpaque, 0LL);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  distortionTransparent = static_fields->distortionTransparent;
		  if ( !distortionTransparent )
		    sub_1800D8250(0LL, static_fields);
		  v106 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(distortionTransparent, 0LL);
		  if ( !v108 )
		    sub_1800D8250(0LL, v17);
		  monitor = v108[6].monitor;
		  fullScreenMeshRenderable = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMeshRenderable(0LL);
		  if ( !monitor )
		    sub_1800D8250(v21, v20);
		  *((_BYTE *)monitor + 16) = fullScreenMeshRenderable;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		  if ( !s_rainRenderer )
		    sub_1800D8250(v24, v23);
		  if ( HG::Rendering::Runtime::HGRainRenderer::IsRainRenderingEnabled(s_rainRenderer, camera, 0LL) )
		    goto LABEL_14;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
		  if ( !s_snowRenderer )
		    sub_1800D8250(v27, v26);
		  if ( HG::Rendering::Runtime::HGSnowRenderer::IsSnowRenderingEnabled(s_snowRenderer, camera, 0LL) )
		  {
		LABEL_14:
		    v31 = 1;
		  }
		  else
		  {
		    if ( !v108 )
		      sub_1800D8250(v29, v28);
		    v30 = v108[6].monitor;
		    if ( !v30 )
		      sub_1800D8250(0LL, v28);
		    v31 = *((unsigned __int8 *)v30 + 16);
		  }
		  v107 = v31 != 0;
		  if ( this->fields.m_feedbackID )
		    v107 = (v31 != 0) | UnityEngine::HyperGryph::HGGraphicsUtils::IsCompoundRendererListDrawable(
		                          this->fields.m_feedbackID,
		                          0LL);
		  this->fields.m_feedbackID = UnityEngine::HyperGryph::HGGraphicsUtils::AllocateTempCompoundRendererListFromScript(
		                                &outPtr,
		                                0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  v32 = input->bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		  v35 = input->bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		  if ( enabled )
		  {
		    cullingResults = input->cullingResults;
		    if ( !camera )
		      sub_1800D8250(v34, v33);
		    v109 = (RendererListHandle)camera->fields.camera;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		    v37 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		    screenCullingRatio = input->screenCullingRatio;
		    screenCullingRatioDistance = input->screenCullingRatioDistance;
		    screenCullingLayerMask = input->screenCullingLayerMask;
		    v111.handle = 0LL;
		    sub_18033B9D0(&v117, 0LL, 112LL);
		    *(ResourceHandle *)&inputa.hasValue = v111.handle;
		    inputa.value.m_UpperBound = v111.handle.m_Value;
		    si128 = (__m128i)cullingResults;
		    v41 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		            &v119,
		            (CullingResults *)&si128,
		            *(Camera **)&v109,
		            v37->s_DistortionName,
		            screenCullingRatio,
		            screenCullingRatioDistance,
		            screenCullingLayerMask,
		            v32,
		            &inputa,
		            &v117,
		            0LL,
		            0,
		            outPtr,
		            0LL);
		    *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v41->sortingCriteria;
		    desc.stateBlock = v41->stateBlock;
		    v41 = (RendererListDesc *)((char *)v41 + 128);
		    *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v41->sortingCriteria;
		    *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v41->stateBlock.hasValue;
		    *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v41->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v41->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v41->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v41->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		    InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		  }
		  else
		  {
		    InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		  }
		  *(RendererListHandle *)&inputa.hasValue = InvalidHandle;
		  if ( v106 )
		  {
		    v45 = input->cullingResults;
		    if ( !camera )
		      ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v44, v43);
		    v109 = (RendererListHandle)camera->fields.camera;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		    v46 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		    v47 = input->screenCullingRatio;
		    v48 = input->screenCullingRatioDistance;
		    v49 = input->screenCullingLayerMask;
		    v111.handle = 0LL;
		    sub_18033B9D0(&v117, 0LL, 112LL);
		    si128.m128i_i64[0] = (__int64)v111.handle;
		    si128.m128i_i32[2] = v111.handle.m_Value;
		    v111 = (TextureHandle)v45;
		    v50 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
		            &v119,
		            (CullingResults *)&v111,
		            *(Camera **)&v109,
		            v46->s_DistortionName,
		            v47,
		            v48,
		            v49,
		            v35,
		            (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&si128,
		            &v117,
		            0LL,
		            0,
		            outPtr,
		            0LL);
		    *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v50->sortingCriteria;
		    desc.stateBlock = v50->stateBlock;
		    v50 = (RendererListDesc *)((char *)v50 + 128);
		    *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v50->sortingCriteria;
		    *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v50->stateBlock.hasValue;
		    *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v50->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v50->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v50->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v50->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		    v51 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		  }
		  else
		  {
		    v51 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		  }
		  v109 = v51;
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v115, (RendererListHandle *)&inputa, 0LL);
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v115, &v109, 0LL);
		  if ( enabled )
		  {
		    if ( !camera )
		      sub_1800D8250(v53, v52);
		    cullingViewHandle = camera->fields.cullingViewHandle;
		    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		    if ( !HGContext )
		      sub_1800D8250(v56, v55);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    context = HGContext->fields.renderContext.m_Ptr;
		    v59 = -1;
		    LOWORD(globalKeywords) = 0;
		    RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                     cullingViewHandle,
		                     HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                     HGRenderFlags__Enum_Opaque,
		                     HGShaderLightMode__Enum_Distortion,
		                     globalKeywords,
		                     context,
		                     outPtr,
		                     0,
		                     0,
		                     0xFFFFFFFF,
		                     0,
		                     0,
		                     0LL);
		  }
		  else
		  {
		    v59 = -1;
		    RendererList = -1;
		  }
		  if ( v106 )
		  {
		    if ( !camera )
		      sub_1800D8250(v53, v52);
		    v61 = camera->fields.cullingViewHandle;
		    v64 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		    if ( !v64 )
		      sub_1800D8250(v63, v62);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    LOWORD(globalKeywords) = 0;
		    v59 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		            v61,
		            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		            HGRenderFlags__Enum_Transparent,
		            HGShaderLightMode__Enum_Distortion,
		            globalKeywords,
		            v64->fields.renderContext.m_Ptr,
		            outPtr,
		            0,
		            0,
		            0xFFFFFFFF,
		            0,
		            0,
		            0LL);
		  }
		  if ( v107 )
		  {
		    v65 = v108;
		    v68 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		             (TextureHandle *)&si128,
		             &v115,
		             &input->sceneColor,
		             0LL);
		    if ( !v65 )
		      sub_1800D8250(v67, v66);
		    *(TextureHandle *)&v65[3].monitor = v68;
		    TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                       renderGraph,
		                       &input->sceneColor,
		                       0LL);
		    Texture = (DistortionPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                        (TextureHandle *)&si128,
		                                                        renderGraph,
		                                                        TextureDescRef,
		                                                        0LL);
		    sceneColor = Texture->sceneColor;
		    *output = *Texture;
		    v111 = sceneColor;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		      (TextureHandle *)&v114,
		      &v115,
		      &v111,
		      0,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      (Color *)&si128,
		      0,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		      (TextureHandle *)&v114,
		      &v115,
		      &input->sceneDepth,
		      DepthAccess__Enum_ReadWrite,
		      0,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v114,
		        &v115,
		        &input->sceneMV,
		        1,
		        0,
		        0LL);
		    if ( !camera )
		      sub_1800D8250(v73, v72);
		    *(BitArray128 *)&v114.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		    v114.m_RenderGraph = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v114,
		           FrameSettingsField__Enum_ShadowMaps,
		           0LL)
		      || (*(BitArray128 *)&v114.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas,
		          v114.m_RenderGraph = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality,
		          HG::Rendering::Runtime::FrameSettings::IsEnabled(
		            (FrameSettings *)&v114,
		            FrameSettingsField__Enum_CharacterShadowMaps,
		            0LL)) )
		    {
		      v76 = *(_OWORD *)&v115.m_RenderPass;
		      v77 = *(_OWORD *)&v115.m_RenderGraph;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		      *(_OWORD *)&v114.m_RenderPass = v76;
		      *(_OWORD *)&v114.m_RenderGraph = v77;
		      HG::Rendering::Runtime::HGShadowManager::ReadShadowResult((ShadowResult *)&v117, &input->shadowResult, &v114, 0LL);
		    }
		    v78 = *(Object__Class **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    v79 = v108;
		    if ( !v108 )
		      sub_1800D8250(v75, v74);
		    v108[1] = (Object)camera->fields._frameSettings_k__BackingField.bitDatas;
		    v79[2].klass = v78;
		    v80 = v108;
		    v81 = (Object_1 *)camera->fields.camera;
		    if ( !v81 )
		      sub_1800D8250(0LL, v74);
		    InstanceID = UnityEngine::Object::GetInstanceID(v81, 0LL);
		    if ( !v80 )
		      sub_1800D8250(v84, v83);
		    LODWORD(v80[3].klass) = InstanceID;
		    v85 = v108;
		    v86 = camera->fields.camera;
		    if ( !v86 )
		      sub_1800D8250(0LL, v83);
		    cullingMask = UnityEngine::Camera::get_cullingMask(v86, 0LL);
		    if ( !v85 )
		      sub_1800D8250(v89, v88);
		    HIDWORD(v85[3].klass) = cullingMask;
		    v90 = v108;
		    if ( !v108 )
		      sub_1800D8250(v89, 0LL);
		    v108[2].monitor = (MonitorData *)camera;
		    if ( dword_18F35FD08 )
		    {
		      v91 = ((unsigned __int64)&v90[2].monitor >> 12) & 0x1FFFFF;
		      v92 = (unsigned __int64)v91 >> 6;
		      v90 = (Object *)(v91 & 0x3F);
		      _m_prefetchw(&qword_18F103690[v92]);
		      do
		        v93 = qword_18F103690[v92];
		      while ( v93 != _InterlockedCompareExchange64(&qword_18F103690[v92], v93 | (1LL << (char)v90), v93) );
		    }
		    if ( !v108 )
		      sub_1800D8250(0LL, v90);
		    v108[4].monitor = *(MonitorData **)&inputa.hasValue;
		    v94 = v108;
		    if ( !v108 )
		      sub_1800D8250(0LL, v90);
		    v108[5].klass = (Object__Class *)v109;
		    if ( !v108 )
		      sub_1800D8250(v94, v90);
		    LODWORD(v108[5].monitor) = RendererList;
		    if ( !v108 )
		      sub_1800D8250(v94, v90);
		    HIDWORD(v108[5].monitor) = v59;
		    transparentAfterDistortionECSList = input->transparentAfterDistortionECSList;
		    if ( !v108 )
		      sub_1800D8250(transparentAfterDistortionECSList, v90);
		    LODWORD(v108[6].klass) = transparentAfterDistortionECSList;
		    if ( !v108 )
		      sub_1800D8250(transparentAfterDistortionECSList, v90);
		    v96 = v108[6].monitor;
		    if ( !v96 )
		      sub_1800D8250(transparentAfterDistortionECSList, v90);
		    if ( *((_BYTE *)v96 + 16) )
		    {
		      v97 = camera->fields.camera;
		      if ( !v97 )
		        sub_1800D8250(0LL, v90);
		      v99 = UnityEngine::Camera::get_nearClipPlane(v97, 0LL);
		      v100 = 0.1;
		      if ( v99 >= 0.1 )
		        v100 = v99;
		      v101 = (float)(v100 * 1.25) + 0.0099999998;
		      if ( !v108 )
		        sub_1800D8250(0LL, v98);
		      v102 = v108[6].monitor;
		      if ( !v102 )
		        sub_1800D8250(0LL, v98);
		      HG::Rendering::Runtime::FullScreenVFXData::UpdateMeshVertices(
		        (FullScreenVFXData *)v102,
		        camera->fields.camera,
		        v101,
		        0LL);
		    }
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(&v115, 0, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v115,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor->static_fields->s_distortionObjectsRenderFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
		    sub_180268AE0(v116);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v115, 0, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v115,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor->static_fields->s_distortionUselessRenderFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
		    *output = (DistortionPassConstructor_PassOutput)input->sceneColor;
		    sub_180268AE0(v116);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BA5C00-0x0000000189BA5C54
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DistortionPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3118, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3118, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80680-0x0000000184D806B0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DistortionPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3119, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3119, 0LL);
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
