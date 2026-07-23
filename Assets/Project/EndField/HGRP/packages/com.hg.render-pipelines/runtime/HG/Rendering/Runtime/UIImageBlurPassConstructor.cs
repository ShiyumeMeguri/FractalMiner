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
	internal class UIImageBlurPassConstructor : IPassConstructor // TypeDefIndex: 38461
	{
		// Fields
		private Material m_uiImageBlurMat; // 0x10
		private static readonly RenderFunc<UIImageBlurPassData> s_UIImageBlurRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38457
		{
			// Fields
			internal UIImageBlurManager uiImageBlurMgr; // 0x00
		}
	
		internal struct PassOutput // TypeDefIndex: 38458
		{
		}
	
		private class UIImageBlurPassData // TypeDefIndex: 38459
		{
			// Fields
			public Vector4 param0; // 0x10
			public Vector4 param1; // 0x20
			public Vector4 paramAtlas; // 0x30
			public RTHandle source; // 0x40
			public RTHandle target; // 0x48
			public TextureHandle tempRT; // 0x50
			public Material blurMat; // 0x60
	
			// Constructors
			public UIImageBlurPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public UIImageBlurPassConstructor() {} // Dummy constructor
		internal UIImageBlurPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000183B94B30-0x0000000183B94B80
		// UIImageBlurPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassConstructor(
		        UIImageBlurPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  this->fields.m_uiImageBlurMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                    materialCollector,
		                                    shaders->fields.uiImageBlurPS,
		                                    0,
		                                    0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v9);
		}
		
		static UIImageBlurPassConstructor() {} // 0x0000000184D2C460-0x0000000184D2C4F0
		// UIImageBlurPassConstructor()
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::cctor(MethodInfo *method)
		{
		  struct UIImageBlurPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_UIImageBlurPassConstructor_UIImageBlurPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_UIImageBlurPassConstructor_UIImageBlurPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor::__c::__cctor_b__12_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor->static_fields->s_UIImageBlurRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BE37D0-0x0000000189BE3824
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        UIImageBlurPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3434, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3434, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BE377C-0x0000000189BE37D0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        UIImageBlurPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3435, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3435, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BE2848-0x0000000189BE2FA8
		// Void ConstructPass(UIImageBlurPassConstructor+PassInput ByRef, UIImageBlurPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
		        UIImageBlurPassConstructor *this,
		        UIImageBlurPassConstructor_PassInput *input,
		        UIImageBlurPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  UIImageBlurPassConstructor_PassInput *v8; // r12
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  ProfilingSampler *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  int v15; // r8d
		  __int64 v16; // rdx
		  UIImageBlurManager *instance; // rcx
		  __int64 v18; // rdx
		  Texture *Source; // rsi
		  UIImageBlurManager *v20; // rcx
		  RenderTexture *Target; // r13
		  UIImageBlurManager__StaticFields *static_fields; // rcx
		  UIImageBlurManager *v23; // rdx
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __m128 v26; // xmm6
		  float v27; // xmm7_4
		  float v28; // xmm8_4
		  Rect *v29; // rdi
		  UIImageBlurManager *v30; // rcx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  Rect *v33; // rdi
		  int v34; // r15d
		  int v35; // r14d
		  int v36; // eax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rdx
		  unsigned __int64 v40; // rdx
		  unsigned __int64 v41; // r8
		  char v42; // dl
		  signed __int64 v43; // rtt
		  __int64 v44; // r14
		  RTHandle *v45; // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  unsigned __int64 v48; // r8
		  signed __int64 v49; // rtt
		  __int64 v50; // rsi
		  RTHandle *v51; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  unsigned __int64 v54; // r9
		  signed __int64 v55; // rtt
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  unsigned __int64 v58; // r8
		  signed __int64 v59; // rtt
		  TextureHandle *v60; // rdi
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  TextureHandle v63; // xmm0
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  unsigned __int128 v69; // [rsp+40h] [rbp-1E8h] BYREF
		  __int64 v70; // [rsp+50h] [rbp-1D8h] BYREF
		  HGRenderGraphBuilder v71; // [rsp+58h] [rbp-1D0h] BYREF
		  TextureDesc v72; // [rsp+80h] [rbp-1A8h] BYREF
		  _QWORD v73[4]; // [rsp+E0h] [rbp-148h] BYREF
		  Il2CppExceptionWrapper *v74; // [rsp+100h] [rbp-128h] BYREF
		  TextureDesc v75; // [rsp+110h] [rbp-118h] BYREF
		  TextureDesc v76; // [rsp+170h] [rbp-B8h] BYREF
		
		  v8 = input;
		  memset(&v71, 0, sizeof(v71));
		  v70 = 0LL;
		  sub_18033B9D0(&v76, 0LL, 96LL);
		  sub_18033B9D0(&v72, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3436, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3436, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v68, v67);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1239(
		      Patch,
		      (Object *)this,
		      v8,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    if ( !v8->uiImageBlurMgr )
		      sub_1800D8260(v11, v10);
		    if ( HG::Rendering::Runtime::UIImageBlurManager::ShouldRenderUIImageBlur(v8->uiImageBlurMgr, 0LL) )
		    {
		      v12 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x1Eu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v14, v13);
		      v71 = *(HGRenderGraphBuilder *)sub_1808AFD44(
		                                       (unsigned int)v73,
		                                       (_DWORD)renderGraph,
		                                       v15,
		                                       (unsigned int)&v70,
		                                       (__int64)v12);
		      v73[0] = 0LL;
		      v73[1] = &v71;
		      try
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		        instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		        if ( !instance )
		          sub_1800D8250(0LL, v16);
		        Source = HG::Rendering::Runtime::UIImageBlurManager::GetSource(instance, 0LL);
		        v20 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		        if ( !v20 )
		          sub_1800D8250(0LL, v18);
		        Target = HG::Rendering::Runtime::UIImageBlurManager::GetTarget(v20, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields;
		        v23 = static_fields->instance;
		        if ( !v23 )
		          sub_1800D8250(static_fields, 0LL);
		        v26 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UIImageBlurManager::GetRect(
		                                                         (Rect *)&v69,
		                                                         v23,
		                                                         0LL));
		        v27 = _mm_shuffle_ps(v26, v26, 255).m128_f32[0];
		        v28 = _mm_shuffle_ps(v26, v26, 170).m128_f32[0];
		        *(float *)&v69 = v28;
		        *((float *)&v69 + 1) = v27;
		        *((float *)&v69 + 2) = 1.0 / v28;
		        *((float *)&v69 + 3) = 1.0 / v27;
		        if ( !v70 )
		          sub_1800D8250(v25, v24);
		        *(_OWORD *)(v70 + 16) = v69;
		        v29 = (Rect *)v70;
		        v30 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		        if ( !v30 )
		          sub_1800D8250(0LL, v24);
		        v69 = COERCE_UNSIGNED_INT(HG::Rendering::Runtime::UIImageBlurManager::GetScale(v30, 0LL));
		        if ( !v29 )
		          sub_1800D8250(v32, v31);
		        v29[2] = (Rect)v69;
		        v33 = (Rect *)v70;
		        if ( !Source )
		          sub_1800D8250(v32, v31);
		        LODWORD(v69) = sub_180002F70(5LL, Source);
		        v34 = sub_180002F70(7LL, Source);
		        v35 = sub_180002F70(5LL, Source);
		        v36 = sub_180002F70(7LL, Source);
		        *(float *)&v69 = v26.m128_f32[0] / (float)(int)v69;
		        *((float *)&v69 + 1) = _mm_shuffle_ps(v26, v26, 85).m128_f32[0] / (float)v34;
		        *((float *)&v69 + 2) = v28 / (float)v35;
		        *((float *)&v69 + 3) = v27 / (float)v36;
		        if ( !v33 )
		          sub_1800D8250(v38, v37);
		        v33[3] = (Rect)v69;
		        v39 = v70;
		        if ( !v70 )
		          sub_1800D8250(v38, 0LL);
		        *(_QWORD *)(v70 + 96) = this->fields.m_uiImageBlurMat;
		        if ( dword_18F35FD08 )
		        {
		          v40 = ((unsigned __int64)(v39 + 96) >> 12) & 0x1FFFFF;
		          v41 = v40 >> 6;
		          v42 = v40 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v41 + 36190]);
		          do
		            v43 = qword_18F0BCBA0[v41 + 36190];
		          while ( v43 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v41 + 36190], v43 | (1LL << v42), v43) );
		        }
		        v44 = v70;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		        v45 = UnityEngine::Rendering::RTHandleSystem::Alloc(Source, 0LL);
		        if ( !v44 )
		          sub_1800D8250(v47, v46);
		        *(_QWORD *)(v44 + 64) = v45;
		        if ( dword_18F35FD08 )
		        {
		          v48 = (((unsigned __int64)(v44 + 64) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		          do
		            v49 = qword_18F0BCBA0[v48 + 36190];
		          while ( v49 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v48 + 36190],
		                           v49 | (1LL << (((unsigned __int64)(v44 + 64) >> 12) & 0x3F)),
		                           v49) );
		        }
		        v50 = v70;
		        v51 = UnityEngine::Rendering::RTHandleSystem::Alloc(Target, 0LL);
		        if ( !v50 )
		          sub_1800D8250(v53, v52);
		        *(_QWORD *)(v50 + 72) = v51;
		        if ( dword_18F35FD08 )
		        {
		          v54 = (((unsigned __int64)(v50 + 72) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v54 + 36190]);
		          do
		            v55 = qword_18F0BCBA0[v54 + 36190];
		          while ( v55 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v54 + 36190],
		                           v55 | (1LL << (((unsigned __int64)(v50 + 72) >> 12) & 0x3F)),
		                           v55) );
		        }
		        sub_18033B9D0(&v75, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v75, (int)v28, (int)v27, 0LL);
		        v72 = v75;
		        if ( !Target )
		          sub_1800D8250(v57, v56);
		        v72.colorFormat = UnityEngine::RenderTexture::get_graphicsFormat(Target, 0LL);
		        v72.enableRandomWrite = 0;
		        v72.name = (String *)"UI Image Blur Temp";
		        if ( dword_18F35FD08 )
		        {
		          v58 = (((unsigned __int64)&v72.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v58 + 36190]);
		          do
		            v59 = qword_18F0BCBA0[v58 + 36190];
		          while ( v59 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v58 + 36190],
		                           v59 | (1LL << (((unsigned __int64)&v72.name >> 12) & 0x3F)),
		                           v59) );
		        }
		        *(_QWORD *)&v72.filterMode = 0x100000001LL;
		        v76 = v72;
		        v60 = (TextureHandle *)v70;
		        v63 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                 (TextureHandle *)&v69,
		                 &v71,
		                 &v76,
		                 0LL);
		        if ( !v60 )
		          sub_1800D8250(v62, v61);
		        v60[5] = v63;
		        if ( !v70 )
		          sub_1800D8250(v62, v61);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v69,
		          &v71,
		          (TextureHandle *)(v70 + 80),
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v71,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor->static_fields->s_UIImageBlurRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v74 )
		      {
		        v73[0] = v74->ex;
		        sub_180268AE0(v73);
		        v8 = input;
		        goto LABEL_34;
		      }
		      sub_180268AE0(v73);
		LABEL_34:
		      if ( !v8->uiImageBlurMgr )
		        sub_1800D8250(v65, v64);
		      HG::Rendering::Runtime::UIImageBlurManager::CloseUIBlurPass(v8->uiImageBlurMgr, 0LL);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BE3728-0x0000000189BE377C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        UIImageBlurPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3437, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3437, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x00000001839460B0-0x00000001839460E0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        UIImageBlurPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3438, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3438, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
		internal void ConstructRenderPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph) {} // 0x0000000189BE2FA8-0x0000000189BE3728
		// Void ConstructRenderPass(UIImageBlurPassConstructor+PassInput ByRef, UIImageBlurPassConstructor+PassOutput ByRef, HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructRenderPass(
		        UIImageBlurPassConstructor *this,
		        UIImageBlurPassConstructor_PassInput *input,
		        UIImageBlurPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  UIImageBlurManager__StaticFields *static_fields; // rcx
		  ProfilingSampler *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  int v14; // r8d
		  __int64 v15; // rdx
		  UIImageBlurManager *instance; // rcx
		  __int64 v17; // rdx
		  Texture *Source; // rsi
		  UIImageBlurManager *v19; // rcx
		  RenderTexture *Target; // r12
		  UIImageBlurManager__StaticFields *v21; // rcx
		  UIImageBlurManager *v22; // rdx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __m128 v25; // xmm6
		  float v26; // xmm7_4
		  float v27; // xmm8_4
		  Rect *v28; // rdi
		  UIImageBlurManager *v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Rect *v32; // rdi
		  int v33; // r15d
		  int v34; // r13d
		  int v35; // r14d
		  int v36; // eax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rdx
		  unsigned __int64 v40; // rdx
		  unsigned __int64 v41; // r8
		  char v42; // dl
		  signed __int64 v43; // rtt
		  __int64 v44; // r14
		  RTHandle *v45; // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  unsigned __int64 v48; // r8
		  signed __int64 v49; // rtt
		  __int64 v50; // rsi
		  RTHandle *v51; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  unsigned __int64 v54; // r9
		  signed __int64 v55; // rtt
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  unsigned __int64 v58; // r8
		  signed __int64 v59; // rtt
		  TextureHandle *v60; // rdi
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  TextureHandle v63; // xmm0
		  __int64 v64; // rdx
		  UIImageBlurManager *v65; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  unsigned __int128 v69; // [rsp+40h] [rbp-1D8h] BYREF
		  __int64 v70; // [rsp+50h] [rbp-1C8h] BYREF
		  HGRenderGraphBuilder v71; // [rsp+58h] [rbp-1C0h] BYREF
		  TextureDesc v72; // [rsp+80h] [rbp-198h] BYREF
		  _QWORD v73[4]; // [rsp+E0h] [rbp-138h] BYREF
		  Il2CppExceptionWrapper *v74; // [rsp+100h] [rbp-118h] BYREF
		  TextureDesc v75; // [rsp+110h] [rbp-108h] BYREF
		  TextureDesc v76; // [rsp+170h] [rbp-A8h] BYREF
		
		  memset(&v71, 0, sizeof(v71));
		  v70 = 0LL;
		  sub_18033B9D0(&v76, 0LL, 96LL);
		  sub_18033B9D0(&v72, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3439, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3439, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v68, v67);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1240(Patch, (Object *)this, input, output, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields;
		    if ( !static_fields->instance )
		      sub_1800D8260(static_fields, v9);
		    if ( HG::Rendering::Runtime::UIImageBlurManager::ShouldRenderUIImageBlur(static_fields->instance, 0LL) )
		    {
		      v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x1Eu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v13, v12);
		      v71 = *(HGRenderGraphBuilder *)sub_1808AFD44(
		                                       (unsigned int)v73,
		                                       (_DWORD)renderGraph,
		                                       v14,
		                                       (unsigned int)&v70,
		                                       (__int64)v11);
		      v73[0] = 0LL;
		      v73[1] = &v71;
		      try
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		        instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		        if ( !instance )
		          sub_1800D8250(0LL, v15);
		        Source = HG::Rendering::Runtime::UIImageBlurManager::GetSource(instance, 0LL);
		        v19 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		        if ( !v19 )
		          sub_1800D8250(0LL, v17);
		        Target = HG::Rendering::Runtime::UIImageBlurManager::GetTarget(v19, 0LL);
		        v21 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields;
		        v22 = v21->instance;
		        if ( !v22 )
		          sub_1800D8250(v21, 0LL);
		        v25 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UIImageBlurManager::GetRect(
		                                                         (Rect *)&v69,
		                                                         v22,
		                                                         0LL));
		        v26 = _mm_shuffle_ps(v25, v25, 255).m128_f32[0];
		        v27 = _mm_shuffle_ps(v25, v25, 170).m128_f32[0];
		        *(float *)&v69 = v27;
		        *((float *)&v69 + 1) = v26;
		        *((float *)&v69 + 2) = 1.0 / v27;
		        *((float *)&v69 + 3) = 1.0 / v26;
		        if ( !v70 )
		          sub_1800D8250(v24, v23);
		        *(_OWORD *)(v70 + 16) = v69;
		        v28 = (Rect *)v70;
		        v29 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		        if ( !v29 )
		          sub_1800D8250(0LL, v23);
		        v69 = COERCE_UNSIGNED_INT(HG::Rendering::Runtime::UIImageBlurManager::GetScale(v29, 0LL));
		        if ( !v28 )
		          sub_1800D8250(v31, v30);
		        v28[2] = (Rect)v69;
		        v32 = (Rect *)v70;
		        if ( !Source )
		          sub_1800D8250(v31, v30);
		        v33 = sub_180002F70(5LL, Source);
		        v34 = sub_180002F70(7LL, Source);
		        v35 = sub_180002F70(5LL, Source);
		        v36 = sub_180002F70(7LL, Source);
		        *(float *)&v69 = v25.m128_f32[0] / (float)v33;
		        *((float *)&v69 + 1) = _mm_shuffle_ps(v25, v25, 85).m128_f32[0] / (float)v34;
		        *((float *)&v69 + 2) = v27 / (float)v35;
		        *((float *)&v69 + 3) = v26 / (float)v36;
		        if ( !v32 )
		          sub_1800D8250(v38, v37);
		        v32[3] = (Rect)v69;
		        v39 = v70;
		        if ( !v70 )
		          sub_1800D8250(v38, 0LL);
		        *(_QWORD *)(v70 + 96) = this->fields.m_uiImageBlurMat;
		        if ( dword_18F35FD08 )
		        {
		          v40 = ((unsigned __int64)(v39 + 96) >> 12) & 0x1FFFFF;
		          v41 = v40 >> 6;
		          v42 = v40 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v41 + 36190]);
		          do
		            v43 = qword_18F0BCBA0[v41 + 36190];
		          while ( v43 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v41 + 36190], v43 | (1LL << v42), v43) );
		        }
		        v44 = v70;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		        v45 = UnityEngine::Rendering::RTHandleSystem::Alloc(Source, 0LL);
		        if ( !v44 )
		          sub_1800D8250(v47, v46);
		        *(_QWORD *)(v44 + 64) = v45;
		        if ( dword_18F35FD08 )
		        {
		          v48 = (((unsigned __int64)(v44 + 64) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		          do
		            v49 = qword_18F0BCBA0[v48 + 36190];
		          while ( v49 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v48 + 36190],
		                           v49 | (1LL << (((unsigned __int64)(v44 + 64) >> 12) & 0x3F)),
		                           v49) );
		        }
		        v50 = v70;
		        v51 = UnityEngine::Rendering::RTHandleSystem::Alloc(Target, 0LL);
		        if ( !v50 )
		          sub_1800D8250(v53, v52);
		        *(_QWORD *)(v50 + 72) = v51;
		        if ( dword_18F35FD08 )
		        {
		          v54 = (((unsigned __int64)(v50 + 72) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v54 + 36190]);
		          do
		            v55 = qword_18F0BCBA0[v54 + 36190];
		          while ( v55 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v54 + 36190],
		                           v55 | (1LL << (((unsigned __int64)(v50 + 72) >> 12) & 0x3F)),
		                           v55) );
		        }
		        sub_18033B9D0(&v75, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v75, (int)v27, (int)v26, 0LL);
		        v72 = v75;
		        if ( !Target )
		          sub_1800D8250(v57, v56);
		        v72.colorFormat = UnityEngine::RenderTexture::get_graphicsFormat(Target, 0LL);
		        v72.enableRandomWrite = 0;
		        v72.name = (String *)"UI Image Blur Temp";
		        if ( dword_18F35FD08 )
		        {
		          v58 = (((unsigned __int64)&v72.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v58 + 36190]);
		          do
		            v59 = qword_18F0BCBA0[v58 + 36190];
		          while ( v59 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v58 + 36190],
		                           v59 | (1LL << (((unsigned __int64)&v72.name >> 12) & 0x3F)),
		                           v59) );
		        }
		        *(_QWORD *)&v72.filterMode = 0x100000001LL;
		        v76 = v72;
		        v60 = (TextureHandle *)v70;
		        v63 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                 (TextureHandle *)&v69,
		                 &v71,
		                 &v76,
		                 0LL);
		        if ( !v60 )
		          sub_1800D8250(v62, v61);
		        v60[5] = v63;
		        if ( !v70 )
		          sub_1800D8250(v62, v61);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v69,
		          &v71,
		          (TextureHandle *)(v70 + 80),
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v71,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor->static_fields->s_UIImageBlurRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v74 )
		      {
		        v73[0] = v74->ex;
		      }
		      sub_180268AE0(v73);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		      v65 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		      if ( !v65 )
		        sub_1800D8250(0LL, v64);
		      HG::Rendering::Runtime::UIImageBlurManager::CloseUIBlurPass(v65, 0LL);
		    }
		  }
		}
		
	}
}
