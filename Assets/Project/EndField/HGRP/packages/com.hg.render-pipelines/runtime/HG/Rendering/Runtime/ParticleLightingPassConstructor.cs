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
	public class ParticleLightingPassConstructor : IPassConstructor // TypeDefIndex: 38377
	{
		// Fields
		internal static readonly int LIGHTING_PARTICLE_POSITIONS; // 0x00
		internal static readonly int COMPUTE_LIGHTING_RESULTS; // 0x04
		internal static readonly int BINNING_BUFFER; // 0x08
		internal static readonly int OUT_LIGHTING_RESULTS; // 0x0C
		internal static readonly int IV_INPUT; // 0x10
		private const int THREAD_COUNT = 64; // Metadata: 0x02303CBF
		private const int MAX_PARTICLE_COUNT = 4096; // Metadata: 0x02303CC1
		private ComputeShader m_lightingCS; // 0x10
		private int m_lightingKernel; // 0x18
		private static readonly RenderFunc<ParticleLightingPassData> s_renderFunc; // 0x18
	
		// Nested types
		public struct PassInput // TypeDefIndex: 38373
		{
			// Fields
			internal ComputeBufferHandle binningBufferHandle; // 0x00
			internal ParticleLightingIVInput ivInput; // 0x08
		}
	
		public struct PassOutput // TypeDefIndex: 38374
		{
		}
	
		public class ParticleLightingPassData // TypeDefIndex: 38375
		{
			// Fields
			internal ComputeShader lightingCS; // 0x10
			internal int lightingKernel; // 0x18
			internal RTHandle asmShadowMapRT; // 0x20
			internal ComputeBufferHandle lightingResultBuffer; // 0x28
			internal ComputeBufferHandle binningBufferHandle; // 0x30
			internal CBHandle ivInputCBHandle; // 0x38
	
			// Constructors
			public ParticleLightingPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public ParticleLightingPassConstructor() {} // Dummy constructor
		internal ParticleLightingPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x000000018454A6D0-0x000000018454A730
		// ParticleLightingPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassConstructor(
		        ParticleLightingPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  ParticleLightingPassConstructor *v4; // rbx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  MethodInfo *v6; // [rsp+20h] [rbp-8h]
		
		  v4 = this;
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || (this->fields.m_lightingCS = shaders->fields.particleLightingCS,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields,
		          (HGRuntimeGrassQuery_Node *)resources,
		          (HGRuntimeGrassQuery_Node *)method,
		          v3,
		          v6),
		        (this = (ParticleLightingPassConstructor *)v4->fields.m_lightingCS) == 0LL) )
		  {
		    sub_1800D8260(this, resources);
		  }
		  v4->fields.m_lightingKernel = UnityEngine::ComputeShader::FindKernel(
		                                  (ComputeShader *)this,
		                                  (String *)"ParticleLightingMain",
		                                  0LL);
		}
		
		static ParticleLightingPassConstructor() {} // 0x0000000184B69540-0x0000000184B69670
		// ParticleLightingPassConstructor()
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::cctor(MethodInfo *method)
		{
		  struct ParticleLightingPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ParticleLightingPassConstructor_ParticleLightingPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->LIGHTING_PARTICLE_POSITIONS = UnityEngine::Shader::PropertyToID((String *)"LightingPositionsCBuffer", 0LL);
		  TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->COMPUTE_LIGHTING_RESULTS = UnityEngine::Shader::PropertyToID((String *)"_ComputeLightingResult", 0LL);
		  TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->BINNING_BUFFER = UnityEngine::Shader::PropertyToID((String *)"_GlobalBinningBuffer", 0LL);
		  TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->OUT_LIGHTING_RESULTS = UnityEngine::Shader::PropertyToID((String *)"_OutParticleLightingResult", 0LL);
		  TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->IV_INPUT = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"ParticleLightingIVInput",
		                                                                                                 0LL);
		  v1 = TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_ParticleLightingPassConstructor_ParticleLightingPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor::__c::__cctor_b__21_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->s_renderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->s_renderFunc,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		internal static void SwitchParticleLightingKeywords(bool enabled) {} // 0x0000000189BCF5B0-0x0000000189BCF610
		// Void SwitchParticleLightingKeywords(Boolean)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::SwitchParticleLightingKeywords(
		        bool enabled,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3284, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3284, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_30 *)Patch, enabled, 0LL);
		  }
		  else if ( enabled )
		  {
		    UnityEngine::Shader::EnableKeyword((String *)"PER_PARTICLE_SYSTEM_LIGHTING", 0LL);
		  }
		  else
		  {
		    UnityEngine::Shader::DisableKeyword((String *)"PER_PARTICLE_SYSTEM_LIGHTING", 0LL);
		  }
		}
		
		internal static void SwitchEnableRaytracing(bool enabled) {} // 0x0000000189BCF560-0x0000000189BCF5B0
		// Void SwitchEnableRaytracing(Boolean)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::SwitchEnableRaytracing(bool enabled, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3285, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3285, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_30 *)Patch, enabled, 0LL);
		  }
		  else
		  {
		    UnityEngine::HyperGryph::HGGraphicsUtils::set_enableRayTracing(enabled, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BCEF64-0x0000000189BCF464
		// Void ConstructPass(ParticleLightingPassConstructor+PassInput ByRef, ParticleLightingPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::ConstructPass(
		        ParticleLightingPassConstructor *this,
		        ParticleLightingPassConstructor_PassInput *input,
		        ParticleLightingPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  ComputeBufferHandle v12; // rdx
		  ComputeBufferHandle v13; // rcx
		  HGCamera *v14; // r14
		  ProfilingSampler *v15; // rax
		  unsigned __int64 v16; // rdx
		  Object *v17; // rax
		  Object__Class *m_lightingCS; // rcx
		  unsigned __int64 v19; // r8
		  signed __int64 v20; // rtt
		  __int64 m_lightingKernel; // rcx
		  ComputeBufferHandle *v22; // r15
		  ComputeBufferHandle v23; // rax
		  ComputeBufferHandle v24; // rdx
		  ComputeBufferHandle v25; // rcx
		  ComputeBufferHandle *v26; // r15
		  ComputeBufferHandle v27; // rax
		  ComputeBufferHandle v28; // rdx
		  ComputeBufferHandle v29; // rcx
		  Object *v30; // r15
		  HGRenderGraphContext *HGContext; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  ScriptableRenderContext *p_renderContext; // rsi
		  CBHandle *ConstantBuffer; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  MonitorData *ptr; // xmm1_8
		  Void *p_ivInput; // rdx
		  __int64 *v40; // rdx
		  __int64 v41; // rcx
		  Camera *v42; // rsi
		  HGASMManager *ASMManager; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  Object *v46; // rsi
		  RTHandle *ASMShadowMapRT; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  __int64 v55; // [rsp+0h] [rbp-D8h] BYREF
		  Object *v56; // [rsp+40h] [rbp-98h] BYREF
		  ParticleLightingIVInput *v57; // [rsp+48h] [rbp-90h] BYREF
		  ComputeBufferDesc desc; // [rsp+50h] [rbp-88h] BYREF
		  HGRenderGraphBuilder v59; // [rsp+70h] [rbp-68h] BYREF
		  ComputeBufferHandle inputa; // [rsp+90h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v61; // [rsp+98h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v62; // [rsp+B8h] [rbp-20h] BYREF
		  Il2CppExceptionWrapper *v63; // [rsp+C0h] [rbp-18h] BYREF
		
		  v56 = 0LL;
		  v57 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3286, 0LL) )
		  {
		    *(HGRenderGraphResourceRegistry **)((char *)&v59.m_Resources + 4) = 0LL;
		    HIDWORD(v59.m_RenderGraph) = 0;
		    v59.m_RenderPass = (HGRenderGraphPass *)0x1000001000LL;
		    LODWORD(v59.m_Resources) = 16;
		    *(_OWORD *)&desc.count = *(_OWORD *)&v59.m_RenderPass;
		    desc.name = 0LL;
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(renderGraph, &desc, 0LL);
		    v14 = camera;
		    if ( !camera )
		      sub_1800D8260(v13, v12);
		    *(_QWORD *)&desc.count = *(_QWORD *)&camera->fields.mainViewConstants.worldSpaceCameraPos.x;
		    desc.type = LODWORD(camera->fields.mainViewConstants.worldSpaceCameraPos.z);
		    UnityEngine::HyperGryph::HGRendererSystem::set_PerRendererLightingFallbackPosition_Injected((Vector3 *)&desc, 0LL);
		    v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xBBu,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v59,
		      renderGraph,
		      (String *)"Particle Lighting",
		      &v56,
		      v15,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
		    v61 = v59;
		    v59.m_RenderPass = 0LL;
		    v59.m_Resources = (HGRenderGraphResourceRegistry *)&v61;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v61, 0, 0LL);
		      v17 = v56;
		      m_lightingCS = (Object__Class *)this->fields.m_lightingCS;
		      if ( !v56 )
		        sub_1800D8250(m_lightingCS, v16);
		      v56[1].klass = m_lightingCS;
		      if ( dword_18F35FD08 )
		      {
		        v19 = (((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF) >> 6;
		        v16 = ((unsigned __int64)&v17[1] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		        do
		          v20 = qword_18F0BCBA0[v19 + 36190];
		        while ( v20 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v20 | (1LL << v16), v20) );
		      }
		      m_lightingKernel = (unsigned int)this->fields.m_lightingKernel;
		      if ( !v56 )
		        sub_1800D8250(m_lightingKernel, v16);
		      LODWORD(v56[1].monitor) = m_lightingKernel;
		      v22 = (ComputeBufferHandle *)v56;
		      v23 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		              &v61,
		              &input->binningBufferHandle,
		              0LL);
		      if ( !v22 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v25, v24);
		      v22[6] = v23;
		      v26 = (ComputeBufferHandle *)v56;
		      v27 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v61, &inputa, 0LL);
		      if ( !v26 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v29, v28);
		      v26[5] = v27;
		      v30 = v56;
		      HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		      if ( !HGContext )
		        sub_1800D8250(v33, v32);
		      p_renderContext = &HGContext->fields.renderContext;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                         (CBHandle *)&desc,
		                         p_renderContext,
		                         160,
		                         0LL);
		      ptr = (MonitorData *)ConstantBuffer->ptr;
		      if ( !v30 )
		        sub_1800D8250(v37, v36);
		      *(Object *)((char *)v30 + 56) = *(Object *)&ConstantBuffer->bufferId;
		      v30[4].monitor = ptr;
		      *(_QWORD *)&desc.count = 0LL;
		      *(_QWORD *)&desc.type = &v57;
		      try
		      {
		        p_ivInput = (Void *)&input->ivInput;
		        v57 = &input->ivInput;
		        if ( !v56 )
		          sub_1800D8250(0LL, p_ivInput);
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v56[4].monitor, p_ivInput, 160LL, 0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v62 )
		      {
		        v40 = &v55;
		        *(Il2CppExceptionWrapper *)&desc.count = (Il2CppExceptionWrapper)v62->ex;
		        v57 = 0LL;
		        v41 = *(_QWORD *)&desc.count;
		        if ( *(_QWORD *)&desc.count )
		          sub_18007E1E0(*(_QWORD *)&desc.count);
		        v14 = camera;
		        goto LABEL_20;
		      }
		      v57 = 0LL;
		LABEL_20:
		      if ( !v14 )
		        sub_1800D8250(v41, v40);
		      v42 = v14->fields.camera;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      ASMManager = HG::Rendering::Runtime::HGASMManager::GetASMManager(v42, 0LL);
		      v46 = v56;
		      if ( !ASMManager )
		        sub_1800D8250(v45, v44);
		      ASMShadowMapRT = HG::Rendering::Runtime::HGASMManager::get_ASMShadowMapRT(ASMManager, 0LL);
		      if ( !v46 )
		        sub_1800D8250(v49, v48);
		      v46[2].klass = (Object__Class *)ASMShadowMapRT;
		      if ( dword_18F35FD08 )
		      {
		        v50 = (((unsigned __int64)&v46[2] >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		        do
		          v51 = qword_18F0BCBA0[v50 + 36190];
		        while ( v51 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v50 + 36190],
		                         v51 | (1LL << (((unsigned __int64)&v46[2] >> 12) & 0x3F)),
		                         v51) );
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v61,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor->static_fields->s_renderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v63 )
		    {
		      v59.m_RenderPass = (HGRenderGraphPass *)v63->ex;
		      sub_180268AE0(&v59);
		      return;
		    }
		    sub_180268AE0(&v59);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3286, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v54, v53);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1209(
		    Patch,
		    (Object *)this,
		    input,
		    output,
		    (Object *)renderGraph,
		    (Object *)camera,
		    0LL);
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCF4B8-0x0000000189BCF50C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ParticleLightingPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3287, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3287, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BCF50C-0x0000000189BCF560
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ParticleLightingPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3288, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3288, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCF464-0x0000000189BCF4B8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ParticleLightingPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3289, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3289, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FF90-0x0000000184D7FFC0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ParticleLightingPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3290, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3290, 0LL);
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
