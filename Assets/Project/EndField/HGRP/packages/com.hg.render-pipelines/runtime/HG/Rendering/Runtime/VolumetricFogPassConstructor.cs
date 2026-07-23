using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricFogPassConstructor : IPassConstructor // TypeDefIndex: 38477
	{
		// Fields
		private ComputeShader m_volumetricFogGridInjectionCS; // 0x10
		private ComputeShader m_volumetricFogLightScatteringCS; // 0x18
		private ComputeShader m_volumetricFogFinalIntegrationCS; // 0x20
		private Texture3D m_volumetricLight3DNoise; // 0x28
		private Texture3D m_VolumetricLightPerturb3DNoise; // 0x30
		private static readonly RenderFunc<ComputeVolumetricFogPassData> s_volumetricFogComputeFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38473
		{
			// Fields
			internal ShadowResult shadowResult; // 0x00
		}
	
		internal struct PassOutput // TypeDefIndex: 38474
		{
		}
	
		public class ComputeVolumetricFogPassData // TypeDefIndex: 38475
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public ComputeShader volumetricFogGridInjectionCS; // 0x18
			public ComputeShader volumetricFogLightScatteringCS; // 0x20
			public ComputeShader volumetricFogFinalIntegrationCS; // 0x28
			public bool temporalHistoryIsValid; // 0x30
			public float volumetricFogDistance; // 0x34
			public Vector3Int volumetricFogGridSize; // 0x38
			public Vector2Int volumetricFogGridToPixel; // 0x44
			public Vector3 volumetricFogZParams; // 0x4C
			public Vector3 volumetricFogEmissive; // 0x58
			public RenderTextureDescriptor volumeDesc; // 0x64
			public int historyMissSuperSampleCount; // 0x98
			public NativeArray<Vector4> frameJitterOffsetValues; // 0xA0
			public RenderTexture vBufferA; // 0xB0
			public RenderTexture vBufferB; // 0xB8
			public RenderTexture lightScattering; // 0xC0
			public bool punctualLightShadowActive; // 0xC8
			public TextureHandle punctualLightShadowResult; // 0xCC
			public Texture3D volumetricLight3DNoise; // 0xE0
			public Texture3D volumetricLight3DNoisePerturb; // 0xE8
	
			// Constructors
			public ComputeVolumetricFogPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public VolumetricFogPassConstructor() {} // Dummy constructor
		internal VolumetricFogPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001849D66D0-0x00000001849D67A0
		// VolumetricFogPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::VolumetricFogPassConstructor(
		        VolumetricFogPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v4; // r8
		  __int64 v5; // r9
		  __int64 v6; // r10
		  __int64 v7; // rax
		  HGRuntimeGrassQuery_Node *v8; // r8
		  __int64 v9; // r9
		  __int64 v10; // r10
		  __int64 v11; // rax
		  HGRuntimeGrassQuery_Node *v12; // r8
		  __int64 v13; // r9
		  __int64 v14; // r10
		  __int64 v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // r8
		  __int64 v17; // r9
		  __int64 v18; // r10
		  __int64 v19; // rax
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_2;
		  this->fields.m_volumetricFogGridInjectionCS = shaders->fields.volumetricFogGridInjectionCS;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields,
		    (HGRuntimeGrassQuery_Node *)resources,
		    (HGRuntimeGrassQuery_Node *)method,
		    (Int32__Array **)this,
		    v20);
		  if ( !*(_QWORD *)v6 )
		    goto LABEL_2;
		  v7 = *(_QWORD *)(*(_QWORD *)v6 + 24LL);
		  if ( !v7 )
		    goto LABEL_2;
		  *(_QWORD *)(v5 + 24) = *(_QWORD *)(v7 + 552);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)(v5 + 24),
		    (HGRuntimeGrassQuery_Node *)resources,
		    v4,
		    (Int32__Array **)v5,
		    v21);
		  if ( !*(_QWORD *)v10
		    || (v11 = *(_QWORD *)(*(_QWORD *)v10 + 24LL)) == 0
		    || (*(_QWORD *)(v9 + 32) = *(_QWORD *)(v11 + 560),
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)(v9 + 32),
		          (HGRuntimeGrassQuery_Node *)resources,
		          v8,
		          (Int32__Array **)v9,
		          v22),
		        !*(_QWORD *)v14)
		    || (v15 = *(_QWORD *)(*(_QWORD *)v14 + 40LL)) == 0
		    || (*(_QWORD *)(v13 + 40) = *(_QWORD *)(v15 + 48),
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)(v13 + 40),
		          (HGRuntimeGrassQuery_Node *)resources,
		          v12,
		          (Int32__Array **)v13,
		          v23),
		        !*(_QWORD *)v18)
		    || (v19 = *(_QWORD *)(*(_QWORD *)v18 + 40LL)) == 0 )
		  {
		LABEL_2:
		    sub_1800D8260(this, resources);
		  }
		  *(_QWORD *)(v17 + 48) = *(_QWORD *)(v19 + 56);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)(v17 + 48),
		    (HGRuntimeGrassQuery_Node *)resources,
		    v16,
		    (Int32__Array **)v17,
		    v24);
		}
		
		static VolumetricFogPassConstructor() {} // 0x0000000184D2C2B0-0x0000000184D2C340
		// VolumetricFogPassConstructor()
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::cctor(MethodInfo *method)
		{
		  struct VolumetricFogPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_VolumetricFogPassConstructor_ComputeVolumetricFogPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_VolumetricFogPassConstructor_ComputeVolumetricFogPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor::__c::__cctor_b__16_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor->static_fields->s_volumetricFogComputeFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BE5E3C-0x0000000189BE5E90
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        VolumetricFogPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3462, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3462, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BE5DE8-0x0000000189BE5E3C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        VolumetricFogPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3463, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3463, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructSkipRender(bool prevTransformReset, HGCamera camera) {} // 0x0000000189BE5D08-0x0000000189BE5D94
		// Void ConstructSkipRender(Boolean, HGCamera)
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructSkipRender(
		        VolumetricFogPassConstructor *this,
		        bool prevTransformReset,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1203, 0LL) )
		  {
		    if ( !prevTransformReset )
		      return;
		    if ( camera )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		        &camera->fields.historyVolumetricLightScatteringTexture,
		        0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1203, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    prevTransformReset,
		    (Object *)camera,
		    0LL);
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BE578C-0x0000000189BE5D08
		// Void ConstructPass(VolumetricFogPassConstructor+PassInput ByRef, VolumetricFogPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructPass(
		        VolumetricFogPassConstructor *this,
		        VolumetricFogPassConstructor_PassInput *input,
		        VolumetricFogPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  Object *v14; // rcx
		  int v15; // eax
		  unsigned __int64 v16; // r8
		  signed __int64 v17; // rtt
		  Object *v18; // rdx
		  MonitorData *m_volumetricFogGridInjectionCS; // rcx
		  unsigned __int64 v20; // rdx
		  unsigned __int64 v21; // r8
		  char v22; // dl
		  signed __int64 v23; // rtt
		  Object *v24; // rdx
		  Object__Class *m_volumetricFogLightScatteringCS; // rcx
		  unsigned __int64 v26; // rdx
		  unsigned __int64 v27; // r8
		  char v28; // dl
		  signed __int64 v29; // rtt
		  unsigned __int64 v30; // rdx
		  MonitorData *m_volumetricFogFinalIntegrationCS; // rcx
		  unsigned __int64 v32; // rdx
		  unsigned __int64 v33; // r8
		  signed __int64 v34; // rtt
		  Object *v35; // rcx
		  unsigned __int64 v36; // r8
		  signed __int64 v37; // rtt
		  Object *v38; // rcx
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  Object *v41; // rcx
		  unsigned __int64 v42; // r8
		  signed __int64 v43; // rtt
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  Object *v46; // rdx
		  int v47; // eax
		  unsigned __int64 v48; // rdx
		  unsigned __int64 v49; // r8
		  char v50; // dl
		  signed __int64 v51; // rtt
		  Object *v52; // rdx
		  MonitorData *m_VolumetricLightPerturb3DNoise; // rcx
		  unsigned __int64 v54; // rdx
		  unsigned __int64 v55; // r8
		  char v56; // dl
		  signed __int64 v57; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  Object *v61; // [rsp+40h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v62; // [rsp+50h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v63; // [rsp+58h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v64; // [rsp+78h] [rbp-30h] BYREF
		
		  v61 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3464, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3464, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v60, v59);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1247(
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
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x2Du,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v63,
		      renderGraph,
		      (String *)"Volumetric Fog",
		      &v61,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
		    v64 = v63;
		    v63.m_RenderPass = 0LL;
		    v63.m_Resources = (HGRenderGraphResourceRegistry *)&v64;
		    try
		    {
		      v14 = v61;
		      if ( !v61 )
		        sub_1800D8250(0LL, v13);
		      v61[1].klass = (Object__Class *)camera;
		      v15 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v16 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v16 + 36190]);
		        do
		          v17 = qword_18F0BCBA0[v16 + 36190];
		        while ( v17 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v16 + 36190],
		                         v17 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
		                         v17) );
		        v15 = dword_18F35FD08;
		      }
		      v18 = v61;
		      m_volumetricFogGridInjectionCS = (MonitorData *)this->fields.m_volumetricFogGridInjectionCS;
		      if ( !v61 )
		        sub_1800D8250(m_volumetricFogGridInjectionCS, 0LL);
		      v61[1].monitor = m_volumetricFogGridInjectionCS;
		      if ( v15 )
		      {
		        v20 = ((unsigned __int64)&v18[1].monitor >> 12) & 0x1FFFFF;
		        v21 = v20 >> 6;
		        v22 = v20 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v21 + 36190]);
		        do
		          v23 = qword_18F0BCBA0[v21 + 36190];
		        while ( v23 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v21 + 36190], v23 | (1LL << v22), v23) );
		        v15 = dword_18F35FD08;
		      }
		      v24 = v61;
		      m_volumetricFogLightScatteringCS = (Object__Class *)this->fields.m_volumetricFogLightScatteringCS;
		      if ( !v61 )
		        sub_1800D8250(m_volumetricFogLightScatteringCS, 0LL);
		      v61[2].klass = m_volumetricFogLightScatteringCS;
		      if ( v15 )
		      {
		        v26 = ((unsigned __int64)&v24[2] >> 12) & 0x1FFFFF;
		        v27 = v26 >> 6;
		        v28 = v26 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v27 + 36190]);
		        do
		          v29 = qword_18F0BCBA0[v27 + 36190];
		        while ( v29 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v27 + 36190], v29 | (1LL << v28), v29) );
		        v15 = dword_18F35FD08;
		      }
		      v30 = (unsigned __int64)v61;
		      m_volumetricFogFinalIntegrationCS = (MonitorData *)this->fields.m_volumetricFogFinalIntegrationCS;
		      if ( !v61 )
		        sub_1800D8250(m_volumetricFogFinalIntegrationCS, 0LL);
		      v61[2].monitor = m_volumetricFogFinalIntegrationCS;
		      if ( v15 )
		      {
		        v32 = ((v30 + 40) >> 12) & 0x1FFFFF;
		        v33 = v32 >> 6;
		        v30 = v32 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v33 + 36190]);
		        do
		          v34 = qword_18F0BCBA0[v33 + 36190];
		        while ( v34 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v33 + 36190], v34 | (1LL << v30), v34) );
		        v15 = dword_18F35FD08;
		      }
		      v35 = v61;
		      if ( !v61 )
		        sub_1800D8250(0LL, v30);
		      v61[11].klass = 0LL;
		      if ( v15 )
		      {
		        v36 = (((unsigned __int64)&v35[11] >> 12) & 0x1FFFFF) >> 6;
		        v30 = ((unsigned __int64)&v35[11] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v36 + 36190]);
		        do
		          v37 = qword_18F0BCBA0[v36 + 36190];
		        while ( v37 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v36 + 36190], v37 | (1LL << v30), v37) );
		        v15 = dword_18F35FD08;
		      }
		      v38 = v61;
		      if ( !v61 )
		        sub_1800D8250(0LL, v30);
		      v61[11].monitor = 0LL;
		      if ( v15 )
		      {
		        v39 = (((unsigned __int64)&v38[11].monitor >> 12) & 0x1FFFFF) >> 6;
		        v30 = ((unsigned __int64)&v38[11].monitor >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		        do
		          v40 = qword_18F0BCBA0[v39 + 36190];
		        while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v39 + 36190], v40 | (1LL << v30), v40) );
		        v15 = dword_18F35FD08;
		      }
		      v41 = v61;
		      if ( !v61 )
		        sub_1800D8250(0LL, v30);
		      v61[12].klass = 0LL;
		      if ( v15 )
		      {
		        v42 = (((unsigned __int64)&v41[12] >> 12) & 0x1FFFFF) >> 6;
		        v30 = ((unsigned __int64)&v41[12] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v42 + 36190]);
		        do
		        {
		          v41 = (Object *)(qword_18F0BCBA0[v42 + 36190] | (1LL << v30));
		          v43 = qword_18F0BCBA0[v42 + 36190];
		        }
		        while ( v43 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v42 + 36190], (signed __int64)v41, v43) );
		      }
		      LOBYTE(v30) = input->shadowResult.punctualLightShadowActive;
		      if ( !v61 )
		        sub_1800D8250(v41, v30);
		      LOBYTE(v61[12].monitor) = v30;
		      if ( !v61 )
		        sub_1800D8250(v41, v30);
		      *(TextureHandle *)((char *)v61 + 204) = input->shadowResult.punctualLightShadowResult;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      if ( !HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL) )
		        sub_1800D8250(v45, v44);
		      v46 = v61;
		      if ( !v61 )
		        sub_1800D8250(v45, 0LL);
		      v61[14].klass = (Object__Class *)this->fields.m_volumetricLight3DNoise;
		      v47 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v48 = ((unsigned __int64)&v46[14] >> 12) & 0x1FFFFF;
		        v49 = v48 >> 6;
		        v50 = v48 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v49 + 36190]);
		        do
		          v51 = qword_18F0BCBA0[v49 + 36190];
		        while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v49 + 36190], v51 | (1LL << v50), v51) );
		        v47 = dword_18F35FD08;
		      }
		      v52 = v61;
		      m_VolumetricLightPerturb3DNoise = (MonitorData *)this->fields.m_VolumetricLightPerturb3DNoise;
		      if ( !v61 )
		        sub_1800D8250(m_VolumetricLightPerturb3DNoise, 0LL);
		      v61[14].monitor = m_VolumetricLightPerturb3DNoise;
		      if ( v47 )
		      {
		        v54 = ((unsigned __int64)&v52[14].monitor >> 12) & 0x1FFFFF;
		        v55 = v54 >> 6;
		        v56 = v54 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v55 + 36190]);
		        do
		          v57 = qword_18F0BCBA0[v55 + 36190];
		        while ( v57 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v55 + 36190], v57 | (1LL << v56), v57) );
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v64,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor->static_fields->s_volumetricFogComputeFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v62 )
		    {
		      v63.m_RenderPass = (HGRenderGraphPass *)v62->ex;
		    }
		    sub_180268AE0(&v63);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BE5D94-0x0000000189BE5DE8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        VolumetricFogPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3465, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3465, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FCF0-0x0000000184D7FD20
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        VolumetricFogPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3466, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3466, 0LL);
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
