using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ScreenSpaceShadowMaskPassConstructor : IPassConstructor // TypeDefIndex: 37865
	{
		// Fields
		private Material m_screenSpaceShadowResolveMaterial; // 0x10
		private HGLowResDirectionalShadowPass m_lowResDirectionalShadowPass; // 0x18
		private static readonly RenderFunc<HGScreenSpaceShadowResolvePassData> s_screenSpaceShadowResolvePassRenderFunc; // 0x00
		private static readonly RenderFunc<HGHDPLSScreenSpaceShadowResolvePassData> s_hdplsScreenSpaceShadowResolvePassRenderFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 37860
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal TextureHandle sceneDepthCopied; // 0x10
			internal TextureHandle gbuffer0; // 0x20
			internal TextureHandle gbuffer1; // 0x30
			internal bool screenSpaceShadowMaskEnabled; // 0x40
			internal bool hdplsReduceResolution; // 0x41
			internal float renderingScale; // 0x44
		}
	
		internal struct PassOutput // TypeDefIndex: 37861
		{
		}
	
		internal class HGScreenSpaceShadowResolvePassData // TypeDefIndex: 37862
		{
			// Fields
			public Material screenSpaceShadowResolveMat; // 0x10
			public TextureHandle depthBuffer; // 0x18
			public TextureHandle depthTexture; // 0x28
			public TextureHandle gbuffer0; // 0x38
			public TextureHandle gbuffer1; // 0x48
			public TextureHandle lowResShadowTexture; // 0x58
			public TextureHandle screenSpaceShadowResolveTexture; // 0x68
	
			// Constructors
			public HGScreenSpaceShadowResolvePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal class HGHDPLSScreenSpaceShadowResolvePassData // TypeDefIndex: 37863
		{
			// Fields
			public Material screenSpaceShadowResolveMat; // 0x10
			public TextureHandle depthBuffer; // 0x18
			public TextureHandle depthTexture; // 0x28
			public TextureHandle hdplsAtlas; // 0x38
			public TextureHandle hdplsScreenSpaceShadowTexture; // 0x48
	
			// Constructors
			public HGHDPLSScreenSpaceShadowResolvePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public ScreenSpaceShadowMaskPassConstructor() {} // Dummy constructor
		internal ScreenSpaceShadowMaskPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x000000018495A640-0x000000018495A6F0
		// ScreenSpaceShadowMaskPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ScreenSpaceShadowMaskPassConstructor(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGLowResDirectionalShadowPass *v11; // rax
		  HGLowResDirectionalShadowPass *v12; // rbp
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector
		    || (this->fields.m_screenSpaceShadowResolveMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                            materialCollector,
		                                                            shaders->fields.screenSpaceShadowResolvePS,
		                                                            0,
		                                                            0LL),
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v8, v9, v10, v16),
		        v11 = (HGLowResDirectionalShadowPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass),
		        (v12 = v11) == 0LL) )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPass(
		    v11,
		    materialCollector,
		    resources->defaultResources,
		    0LL);
		  this->fields.m_lowResDirectionalShadowPass = v12;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_lowResDirectionalShadowPass, v13, v14, v15, v17);
		}
		
		static ScreenSpaceShadowMaskPassConstructor() {} // 0x0000000184CB3F40-0x0000000184CB4040
		// ScreenSpaceShadowMaskPassConstructor()
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::cctor(MethodInfo *method)
		{
		  struct ScreenSpaceShadowMaskPassConstructor_c__Class *v1; // rax
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
		
		  v1 = TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c::__cctor_b__17_0,
		          0LL),
		        static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGHDPLSScreenSpaceShadowResolvePassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::__c::__cctor_b__17_1,
		    0LL);
		  v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor->static_fields->s_hdplsScreenSpaceShadowResolvePassRenderFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		internal static bool IsScreenSpaceShadowMaskEnabled(bool screenSpaceShadowMaskEnabled) => default; // 0x0000000183E02240-0x0000000183E022F0
		// Boolean IsScreenSpaceShadowMaskEnabled(Boolean)
		bool HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
		        bool screenSpaceShadowMaskEnabled,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  __int64 (*v5)(void); // rax
		  unsigned int v6; // edi
		  unsigned __int8 (__fastcall *v7)(_QWORD, __int64); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		  __int64 v11; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_12;
		  if ( wrapperArray->max_length.size > 570 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields->wrapperArray;
		    if ( wrapperArray )
		    {
		      if ( wrapperArray->max_length.size <= 0x23Au )
		        sub_1800D2AB0(wrapperArray, v2);
		      if ( !wrapperArray[15].vector[30] )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(570, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_234(Patch, screenSpaceShadowMaskEnabled, 0LL);
		    }
		LABEL_12:
		    sub_1800D8260(wrapperArray, v2);
		  }
		LABEL_5:
		  if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		  v5 = (__int64 (*)(void))qword_18F36F380;
		  if ( !qword_18F36F380 )
		  {
		    v5 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Graphics::get_activeTier()");
		    if ( !v5 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.Graphics::get_activeTier()");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F36F380 = (__int64)v5;
		  }
		  v6 = v5();
		  v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18F370308;
		  if ( !qword_18F370308 )
		  {
		    v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(Unit"
		                                                            "yEngine.Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)");
		    if ( !v7 )
		    {
		      v11 = sub_1802EE1B8(
		              "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Ren"
		              "dering.BuiltinShaderDefine)");
		      sub_18007E1B0(v11, 0LL);
		    }
		    qword_18F370308 = (__int64)v7;
		  }
		  if ( v7(v6, 33LL) )
		    return 0;
		  return screenSpaceShadowMaskEnabled;
		}
		
		private void RenderHDPLSScreenSpaceShadowResolve(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthRT, TextureHandle depthRTCopied, bool reduceResolution) {} // 0x0000000189B53030-0x0000000189B53608
		// Void RenderHDPLSScreenSpaceShadowResolve(HGRenderGraph, HGCamera, TextureHandle, TextureHandle, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::RenderHDPLSScreenSpaceShadowResolve(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *depthRT,
		        TextureHandle *depthRTCopied,
		        bool reduceResolution,
		        MethodInfo *method)
		{
		  ProfilingSampler *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // rcx
		  Object *v15; // rdx
		  unsigned int v16; // edx
		  unsigned __int64 v17; // r8
		  char v18; // dl
		  signed __int64 v19; // rtt
		  Object *v20; // rdi
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  TextureHandle v23; // xmm0
		  Object *v24; // rdi
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  TextureHandle v27; // xmm0
		  Object *v28; // rdi
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  TextureHandle v31; // xmm0
		  __int64 v32; // rdx
		  int v33; // edi
		  int v34; // eax
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  TextureHandle v38; // xmm0
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdi
		  Object *v46; // [rsp+50h] [rbp-1C8h] BYREF
		  TextureHandle si128; // [rsp+60h] [rbp-1B8h] BYREF
		  HGRenderGraphBuilder v48; // [rsp+70h] [rbp-1A8h] BYREF
		  TextureHandle size; // [rsp+90h] [rbp-188h] BYREF
		  HGRenderGraphBuilder v50; // [rsp+A0h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v51; // [rsp+C0h] [rbp-158h] BYREF
		  TextureDesc v52; // [rsp+D0h] [rbp-148h] BYREF
		  __int128 v53; // [rsp+140h] [rbp-D8h]
		  __int128 v54; // [rsp+150h] [rbp-C8h]
		  TextureDesc v55; // [rsp+190h] [rbp-88h] BYREF
		
		  v46 = 0LL;
		  size.handle = 0LL;
		  sub_18033B9D0(&v55, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2192, 0LL) )
		  {
		    v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x88u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v13, v12);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v50,
		      renderGraph,
		      (String *)"HDPLS Screen Space Shadow Resolve",
		      &v46,
		      v11,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGHDPLSScreenSpaceShadowResolvePassData>);
		    v48 = v50;
		    v50.m_RenderPass = 0LL;
		    v50.m_Resources = (HGRenderGraphResourceRegistry *)&v48;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v48, 0, 0LL);
		      v15 = v46;
		      if ( !v46 )
		        sub_1800D8250(v14, 0LL);
		      v46[1].klass = (Object__Class *)this->fields.m_screenSpaceShadowResolveMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v16 = ((unsigned __int64)&v15[1] >> 12) & 0x1FFFFF;
		        v17 = (unsigned __int64)v16 >> 6;
		        v18 = v16 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v17]);
		        do
		          v19 = qword_18F103690[v17];
		        while ( v19 != _InterlockedCompareExchange64(&qword_18F103690[v17], v19 | (1LL << v18), v19) );
		      }
		      v20 = v46;
		      v23 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v48, depthRT, 0LL);
		      if ( !v20 )
		        sub_1800D8250(v22, v21);
		      *(TextureHandle *)&v20[1].monitor = v23;
		      v24 = v46;
		      v27 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v48, depthRTCopied, 0LL);
		      if ( !v24 )
		        sub_1800D8250(v26, v25);
		      *(TextureHandle *)&v24[2].monitor = v27;
		      v28 = v46;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		      v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               &si128,
		               &v48,
		               &TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsAtlas,
		               0LL);
		      if ( !v28 )
		        sub_1800D8250(v30, v29);
		      *(TextureHandle *)&v28[3].monitor = v31;
		      if ( reduceResolution )
		      {
		        if ( !hgCamera )
		          sub_1800D8250(v30, v29);
		        if ( hgCamera->fields._sceneRTSize_k__BackingField.m_X > 1920
		          || (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) > 1080 )
		        {
		          v33 = sub_182F3EA70(v30, v29);
		          if ( v33 < 1 )
		            v33 = 1;
		          v34 = sub_182F3EA70(HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField), v32);
		          if ( v34 < 1 )
		            v34 = 1;
		          size.handle = (ResourceHandle)__PAIR64__(v34, v33);
		          sceneRTSize_k__BackingField = (Vector2Int)__PAIR64__(v34, v33);
		          goto LABEL_22;
		        }
		      }
		      else if ( !hgCamera )
		      {
		        sub_1800D8250(v30, v29);
		      }
		      sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		LABEL_22:
		      sub_18033B9D0(&v52, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v52, sceneRTSize_k__BackingField, 0LL);
		      HIDWORD(v53) = v52.dimension;
		      v54 = *(_OWORD *)&v52.enableRandomWrite;
		      LODWORD(v53) = 8;
		      BYTE1(v54) = 0;
		      *(_QWORD *)((char *)&v53 + 4) = 0x100000001LL;
		      *(_OWORD *)&v55.width = *(_OWORD *)&v52.width;
		      *(_OWORD *)&v55.colorFormat = v53;
		      *(_OWORD *)&v55.enableRandomWrite = v54;
		      *(_OWORD *)&v55.bindTextureMS = *(_OWORD *)&v52.bindTextureMS;
		      *(_OWORD *)&v55.fastMemoryDesc.inFastMemory = *(_OWORD *)&v52.fastMemoryDesc.inFastMemory;
		      v55.clearColor = v52.clearColor;
		      v38 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&si128, renderGraph, &v55, 0LL);
		      if ( !v46 )
		        sub_1800D8250(v37, v36);
		      *(TextureHandle *)&v46[4].monitor = v38;
		      if ( !v46 )
		        sub_1800D8250(v37, v36);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		        &si128,
		        &v48,
		        (TextureHandle *)&v46[4].monitor,
		        0LL);
		      if ( !v46 )
		        sub_1800D8250(v40, v39);
		      si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959780);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        &size,
		        &v48,
		        (TextureHandle *)&v46[4].monitor,
		        0,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_DontCare,
		        (Color *)&si128,
		        0,
		        0LL);
		      if ( !v46 )
		        sub_1800D8250(v42, v41);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        &si128,
		        &v48,
		        (TextureHandle *)&v46[1].monitor,
		        DepthAccess__Enum_Read,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v48,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor->static_fields->s_hdplsScreenSpaceShadowResolvePassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGHDPLSScreenSpaceShadowResolvePassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v51 )
		    {
		      v50.m_RenderPass = (HGRenderGraphPass *)v51->ex;
		    }
		    sub_180268AE0(&v50);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2192, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v44, v43);
		  *(TextureHandle *)&v50.m_RenderPass = *depthRTCopied;
		  si128 = *depthRT;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_883(
		    Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    &si128,
		    (TextureHandle *)&v50,
		    reduceResolution,
		    0LL);
		}
		
		private void RenderScreenSpaceShadowResolve(HGRenderGraph renderGraph, HGCamera hgCamera, float renderingScale, TextureHandle depthRT, TextureHandle depthRTCopied, TextureHandle gbuffer0, TextureHandle gbuffer1, TextureHandle lowResShadowTexture) {} // 0x0000000189B53608-0x0000000189B53BF8
		// Void RenderScreenSpaceShadowResolve(HGRenderGraph, HGCamera, Single, TextureHandle, TextureHandle, TextureHandle, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::RenderScreenSpaceShadowResolve(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        float renderingScale,
		        TextureHandle *depthRT,
		        TextureHandle *depthRTCopied,
		        TextureHandle *gbuffer0,
		        TextureHandle *gbuffer1,
		        TextureHandle *lowResShadowTexture,
		        MethodInfo *method)
		{
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rcx
		  Object *v17; // rdx
		  unsigned int v18; // edx
		  unsigned __int64 v19; // r8
		  char v20; // dl
		  signed __int64 v21; // rtt
		  Object *v22; // rbx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  TextureHandle v25; // xmm0
		  Object *v26; // rbx
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  TextureHandle v29; // xmm0
		  Object *v30; // rbx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  TextureHandle v33; // xmm0
		  Object *v34; // rbx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  TextureHandle v37; // xmm0
		  Object *v38; // rbx
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  TextureHandle v41; // xmm0
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  TextureHandle v44; // xmm0
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Object *v52; // [rsp+60h] [rbp-1D8h] BYREF
		  TextureHandle v53; // [rsp+70h] [rbp-1C8h] BYREF
		  HGRenderGraphBuilder v54; // [rsp+80h] [rbp-1B8h] BYREF
		  HGRenderGraphBuilder v55; // [rsp+A0h] [rbp-198h] BYREF
		  TextureHandle v56; // [rsp+C0h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v57; // [rsp+D0h] [rbp-168h] BYREF
		  TextureHandle v58; // [rsp+E0h] [rbp-158h] BYREF
		  TextureHandle v59; // [rsp+F0h] [rbp-148h] BYREF
		  TextureDesc v60; // [rsp+100h] [rbp-138h] BYREF
		  __int128 v61; // [rsp+170h] [rbp-C8h]
		  __int128 v62; // [rsp+180h] [rbp-B8h]
		  TextureDesc v63; // [rsp+1C0h] [rbp-78h] BYREF
		
		  v52 = 0LL;
		  sub_18033B9D0(&v63, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2193, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2193, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v50, v49);
		    v53 = *lowResShadowTexture;
		    v56 = *gbuffer1;
		    v58 = *gbuffer0;
		    v59 = *depthRTCopied;
		    *(TextureHandle *)&v54.m_RenderPass = *depthRT;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_884(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      renderingScale,
		      (TextureHandle *)&v54,
		      &v59,
		      &v58,
		      &v56,
		      &v53,
		      0LL);
		  }
		  else
		  {
		    v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x88u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v54,
		      renderGraph,
		      (String *)"Screen Space Shadow Resolve",
		      &v52,
		      v13,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
		    v55 = v54;
		    v53.handle = 0LL;
		    v53.fallBackResource = (ResourceHandle)&v55;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v55, 0, 0LL);
		      v17 = v52;
		      if ( !v52 )
		        sub_1800D8250(v16, 0LL);
		      v52[1].klass = (Object__Class *)this->fields.m_screenSpaceShadowResolveMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v18 = ((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF;
		        v19 = (unsigned __int64)v18 >> 6;
		        v20 = v18 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v19]);
		        do
		          v21 = qword_18F103690[v19];
		        while ( v21 != _InterlockedCompareExchange64(&qword_18F103690[v19], v21 | (1LL << v20), v21) );
		      }
		      v22 = v52;
		      v25 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v55,
		               depthRT,
		               0LL);
		      if ( !v22 )
		        sub_1800D8250(v24, v23);
		      *(TextureHandle *)&v22[1].monitor = v25;
		      v26 = v52;
		      v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v55,
		               depthRTCopied,
		               0LL);
		      if ( !v26 )
		        sub_1800D8250(v28, v27);
		      *(TextureHandle *)&v26[2].monitor = v29;
		      v30 = v52;
		      v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v55,
		               gbuffer0,
		               0LL);
		      if ( !v30 )
		        sub_1800D8250(v32, v31);
		      *(TextureHandle *)&v30[3].monitor = v33;
		      v34 = v52;
		      v37 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v55,
		               gbuffer1,
		               0LL);
		      if ( !v34 )
		        sub_1800D8250(v36, v35);
		      *(TextureHandle *)&v34[4].monitor = v37;
		      v38 = v52;
		      v41 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v54,
		               &v55,
		               lowResShadowTexture,
		               0LL);
		      if ( !v38 )
		        sub_1800D8250(v40, v39);
		      *(TextureHandle *)&v38[5].monitor = v41;
		      if ( !hgCamera )
		        sub_1800D8250(v40, v39);
		      sub_18033B9D0(&v60, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v60,
		        hgCamera->fields._sceneRTSize_k__BackingField,
		        0LL);
		      HIDWORD(v61) = v60.dimension;
		      v62 = *(_OWORD *)&v60.enableRandomWrite;
		      LODWORD(v61) = 6;
		      BYTE1(v62) = 0;
		      *(_QWORD *)((char *)&v61 + 4) = 0x100000001LL;
		      *(_OWORD *)&v63.width = *(_OWORD *)&v60.width;
		      *(_OWORD *)&v63.colorFormat = v61;
		      *(_OWORD *)&v63.enableRandomWrite = v62;
		      *(_OWORD *)&v63.bindTextureMS = *(_OWORD *)&v60.bindTextureMS;
		      *(_OWORD *)&v63.fastMemoryDesc.inFastMemory = *(_OWORD *)&v60.fastMemoryDesc.inFastMemory;
		      v63.clearColor = v60.clearColor;
		      v44 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		               (TextureHandle *)&v54,
		               renderGraph,
		               &v63,
		               0LL);
		      if ( !v52 )
		        sub_1800D8250(v43, v42);
		      *(TextureHandle *)&v52[6].monitor = v44;
		      if ( !v52 )
		        sub_1800D8250(v43, v42);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		        (TextureHandle *)&v54,
		        &v55,
		        (TextureHandle *)&v52[6].monitor,
		        0LL);
		      if ( !v52 )
		        sub_1800D8250(v46, v45);
		      v56 = 0LL;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v54,
		        &v55,
		        (TextureHandle *)&v52[6].monitor,
		        0,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_DontCare,
		        (Color *)&v56,
		        0,
		        0LL);
		      if ( !v52 )
		        sub_1800D8250(v48, v47);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        (TextureHandle *)&v54,
		        &v55,
		        (TextureHandle *)&v52[1].monitor,
		        DepthAccess__Enum_Read,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v55,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor->static_fields->s_screenSpaceShadowResolvePassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v57 )
		    {
		      v53.handle = (ResourceHandle)v57->ex;
		    }
		    sub_180268AE0(&v53);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B52FDC-0x0000000189B53030
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2194, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2194, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B52F88-0x0000000189B52FDC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2195, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2195, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B52CAC-0x0000000189B52F34
		// Void ConstructPass(ScreenSpaceShadowMaskPassConstructor+PassInput ByRef, ScreenSpaceShadowMaskPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ConstructPass(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        ScreenSpaceShadowMaskPassConstructor_PassInput *input,
		        ScreenSpaceShadowMaskPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  bool screenSpaceShadowMaskEnabled; // bl
		  ProfilingSampler *v11; // rax
		  __int64 v12; // rcx
		  HGLowResDirectionalShadowPass *m_lowResDirectionalShadowPass; // rdx
		  float renderingScale; // xmm1_4
		  MethodInfo *v15; // rcx
		  bool hdplsReduceResolution; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  _QWORD v20[2]; // [rsp+50h] [rbp-88h] BYREF
		  TextureHandle v21; // [rsp+60h] [rbp-78h] BYREF
		  TextureHandle sceneDepth; // [rsp+70h] [rbp-68h] BYREF
		  TextureHandle sceneDepthCopied; // [rsp+80h] [rbp-58h] BYREF
		  HGRenderGraphProfilingScope v24; // [rsp+90h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v25; // [rsp+A8h] [rbp-30h] BYREF
		  TextureHandle gbuffer1; // [rsp+B0h] [rbp-28h] BYREF
		  TextureHandle gbuffer0; // [rsp+C0h] [rbp-18h] BYREF
		
		  memset(&v24, 0, sizeof(v24));
		  if ( IFix::WrappersManagerImpl::IsPatched(2196, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2196, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_885(
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
		    screenSpaceShadowMaskEnabled = input->screenSpaceShadowMaskEnabled;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		    if ( HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
		           screenSpaceShadowMaskEnabled,
		           0LL) )
		    {
		      v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x89u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		        &v24,
		        renderGraph,
		        v11,
		        0LL);
		      v20[0] = 0LL;
		      v20[1] = &v24;
		      try
		      {
		        m_lowResDirectionalShadowPass = this->fields.m_lowResDirectionalShadowPass;
		        renderingScale = input->renderingScale;
		        if ( !m_lowResDirectionalShadowPass )
		          sub_1800D8250(v12, 0LL);
		        sceneDepth = input->sceneDepth;
		        sceneDepth = *HG::Rendering::Runtime::HGLowResDirectionalShadowPass::Render(
		                        &v21,
		                        m_lowResDirectionalShadowPass,
		                        renderGraph,
		                        camera,
		                        renderingScale,
		                        &sceneDepth,
		                        0LL);
		        gbuffer1 = input->gbuffer1;
		        gbuffer0 = input->gbuffer0;
		        sceneDepthCopied = input->sceneDepthCopied;
		        v21 = input->sceneDepth;
		        HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::RenderScreenSpaceShadowResolve(
		          this,
		          renderGraph,
		          camera,
		          input->renderingScale,
		          &v21,
		          &sceneDepthCopied,
		          &gbuffer0,
		          &gbuffer1,
		          &sceneDepth,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		        if ( HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::get_isActive(v15) )
		        {
		          hdplsReduceResolution = input->hdplsReduceResolution;
		          v21 = input->sceneDepthCopied;
		          sceneDepthCopied = input->sceneDepth;
		          HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::RenderHDPLSScreenSpaceShadowResolve(
		            this,
		            renderGraph,
		            camera,
		            &sceneDepthCopied,
		            &v21,
		            hdplsReduceResolution,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v25 )
		      {
		        v20[0] = v25->ex;
		      }
		      sub_180269330(v20);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B52F34-0x0000000189B52F88
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2197, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2197, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FF30-0x0000000184D7FF60
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ScreenSpaceShadowMaskPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2198, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2198, 0LL);
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
