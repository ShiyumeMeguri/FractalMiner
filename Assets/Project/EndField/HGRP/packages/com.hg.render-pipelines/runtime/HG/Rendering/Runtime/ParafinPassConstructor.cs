using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ParafinPassConstructor : IPassConstructor // TypeDefIndex: 38399
	{
		// Fields
		private Material m_parafinMaterial; // 0x10
		private static Material[] s_parafinMaterials; // 0x00
		private static readonly RenderFunc<ParafinData> m_parafinFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38395
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal bool enableParafin; // 0x20
		}
	
		internal struct PassOutput // TypeDefIndex: 38396
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
		}
	
		private class ParafinData // TypeDefIndex: 38397
		{
			// Fields
			public TextureHandle sceneColor; // 0x10
			public TextureHandle depthRT; // 0x20
			public Mesh parafinDataMesh; // 0x30
			public Material blitMaterial; // 0x38
			public Material[] parafinMaterials; // 0x40
			public int parafinMaterialCount; // 0x48
	
			// Constructors
			public ParafinData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public ParafinPassConstructor() {} // Dummy constructor
		internal ParafinPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184B38DD0-0x0000000184B38EF0
		// ParafinPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::ParafinPassConstructor::ParafinPassConstructor(
		        ParafinPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  struct VFXPPCutsceneEffect__Class *v3; // rax
		  VFXPPCutsceneEffect__StaticFields *static_fields; // rcx
		  Material__Array *runtimeMaterial; // rdx
		  Material *v7; // rbx
		  struct Object_1__Class *v8; // rcx
		  Material__Array *v9; // rbx
		  Material *v10; // rax
		  Material *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  if ( !v3->static_fields->runtimeMaterial )
		    goto LABEL_8;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  static_fields = v3->static_fields;
		  runtimeMaterial = static_fields->runtimeMaterial;
		  if ( !runtimeMaterial )
		    goto LABEL_20;
		  if ( runtimeMaterial->max_length.value )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    static_fields = v3->static_fields;
		    v9 = static_fields->runtimeMaterial;
		    if ( !v9 )
		      goto LABEL_20;
		    if ( !v9->max_length.size )
		      sub_1800D2AB0(static_fields, runtimeMaterial);
		    v7 = v9->vector[0];
		  }
		  else
		  {
		LABEL_8:
		    v7 = 0LL;
		  }
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v8 = TypeInfo::UnityEngine::Object;
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		      v8 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v7 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v8);
		      v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		    }
		    if ( v7->fields._.m_CachedPtr )
		    {
		      v10 = (Material *)sub_1800368D0(TypeInfo::UnityEngine::Material);
		      v11 = v10;
		      if ( v10 )
		      {
		        UnityEngine::Material::Material(v10, v7, 0LL);
		        this->fields.m_parafinMaterial = v11;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v12, v13, v14, v15);
		        return;
		      }
		LABEL_20:
		      sub_1800D8260(static_fields, runtimeMaterial);
		    }
		  }
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
		  }
		  if ( v3->static_fields->m_useCutsceneEffsectShader )
		  {
		    if ( !TypeInfo::UnityEngine::Debug->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::LogError((Object *)"Failed to get Parafin base material", 0LL);
		  }
		}
		
		static ParafinPassConstructor() {} // 0x0000000184CE6810-0x0000000184CE68E0
		// ParafinPassConstructor()
		void HG::Rendering::Runtime::ParafinPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  struct ParafinPassConstructor_c__Class *v5; // r9
		  Object *v6; // rdi
		  RenderFunc_1_System_Object_ *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ParafinPassConstructor_ParafinData_ *v10; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 32LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v14);
		  v5 = TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor::__c);
		    v5 = TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor::__c;
		  }
		  v6 = (Object *)v5->static_fields->__9;
		  v7 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
		  v10 = (RenderFunc_1_HG_Rendering_Runtime_ParafinPassConstructor_ParafinData_ *)v7;
		  if ( !v7 )
		    sub_1800D8260(v9, v8);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v7,
		    v6,
		    MethodInfo::HG::Rendering::Runtime::ParafinPassConstructor::__c::__cctor_b__13_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields->m_parafinFunc = v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields->m_parafinFunc,
		    v11,
		    v12,
		    v13,
		    v15);
		}
		
	
		// Methods
		private void ParafinPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthRT, TextureHandle targetRT) {} // 0x0000000189BCEA40-0x0000000189BCEF64
		// Void ParafinPass(ParafinPassConstructor+PassInput ByRef, ParafinPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ParafinPassConstructor::ParafinPass(
		        ParafinPassConstructor *this,
		        ParafinPassConstructor_PassInput *input,
		        ParafinPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *depthRT,
		        TextureHandle *targetRT,
		        MethodInfo *method)
		{
		  HGRenderGraph *v8; // r14
		  ParafinPassConstructor_PassInput *v10; // r15
		  int32_t effectListCount; // ebx
		  __int64 v13; // rdi
		  int32_t v14; // esi
		  __int64 v15; // r13
		  Material__Array *s_parafinMaterials; // r12
		  __int64 v17; // rdx
		  VFXPPCutsceneEffect__StaticFields *v18; // rcx
		  Material__Array *runtimeMaterial; // r14
		  __int64 v20; // r15
		  MonitorData *BlitMaterial; // rsi
		  ProfilingSampler *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  Object *v26; // rcx
		  Object__Class *parafinMesh; // rdx
		  int v28; // eax
		  unsigned __int64 v29; // r8
		  unsigned __int64 v30; // rdx
		  signed __int64 v31; // rtt
		  Object *v32; // rdx
		  unsigned __int64 v33; // rdx
		  unsigned __int64 v34; // r8
		  char v35; // dl
		  signed __int64 v36; // rtt
		  Object *v37; // rsi
		  unsigned __int64 v38; // rdx
		  Object__Class **static_fields; // rcx
		  unsigned __int64 v40; // r8
		  signed __int64 v41; // rtt
		  Object *v42; // rbx
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  TextureHandle v45; // xmm0
		  Object *v46; // rbx
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  TextureHandle v49; // xmm0
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Object *v53; // [rsp+50h] [rbp-A8h] BYREF
		  TextureHandle si128; // [rsp+60h] [rbp-98h] BYREF
		  TextureHandle v55; // [rsp+70h] [rbp-88h] BYREF
		  HGRenderGraphBuilder v56; // [rsp+80h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v57; // [rsp+A0h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v58; // [rsp+A8h] [rbp-50h] BYREF
		
		  v8 = renderGraph;
		  v10 = input;
		  v53 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3306, 0LL) )
		  {
		    *output = (ParafinPassConstructor_PassOutput)v10->sceneColor;
		    if ( !v10->enableParafin )
		      return;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    effectListCount = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount;
		    v13 = 32LL;
		    v14 = 0;
		    if ( effectListCount >= 32 )
		    {
		      effectListCount = 32;
		    }
		    else if ( effectListCount <= 0 )
		    {
		LABEL_13:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      BlitMaterial = (MonitorData *)HG::Rendering::Runtime::HGUtils::GetBlitMaterial(
		                                      0,
		                                      TextureDimension__Enum_Tex2D,
		                                      0,
		                                      0LL);
		      v22 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x9Du,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v8 )
		        sub_1800D8260(v24, v23);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v58,
		        v8,
		        (String *)"Parafin",
		        &v53,
		        v22,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
		      v56 = v58;
		      v55.handle = 0LL;
		      v55.fallBackResource = (ResourceHandle)&v56;
		      try
		      {
		        v26 = v53;
		        if ( !hgCamera )
		          sub_1800D8250(v53, v25);
		        parafinMesh = (Object__Class *)hgCamera->fields.parafinMesh;
		        if ( !v53 )
		          sub_1800D8250(0LL, parafinMesh);
		        v53[3].klass = parafinMesh;
		        v28 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v29 = (((unsigned __int64)&v26[3] >> 12) & 0x1FFFFF) >> 6;
		          v30 = ((unsigned __int64)&v26[3] >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v29 + 36190]);
		          do
		          {
		            v26 = (Object *)(qword_18F0BCBA0[v29 + 36190] | (1LL << v30));
		            v31 = qword_18F0BCBA0[v29 + 36190];
		          }
		          while ( v31 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v29 + 36190], (signed __int64)v26, v31) );
		          v28 = dword_18F35FD08;
		        }
		        v32 = v53;
		        if ( !v53 )
		          sub_1800D8250(v26, 0LL);
		        v53[3].monitor = BlitMaterial;
		        if ( v28 )
		        {
		          v33 = ((unsigned __int64)&v32[3].monitor >> 12) & 0x1FFFFF;
		          v34 = v33 >> 6;
		          v35 = v33 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v34 + 36190]);
		          do
		            v36 = qword_18F0BCBA0[v34 + 36190];
		          while ( v36 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v34 + 36190], v36 | (1LL << v35), v36) );
		        }
		        v37 = v53;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
		        static_fields = (Object__Class **)TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields;
		        if ( !v37 )
		          sub_1800D8250(static_fields, v38);
		        v37[4].klass = *static_fields;
		        if ( dword_18F35FD08 )
		        {
		          v40 = (((unsigned __int64)&v37[4] >> 12) & 0x1FFFFF) >> 6;
		          v38 = ((unsigned __int64)&v37[4] >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v40 + 36190]);
		          do
		          {
		            static_fields = (Object__Class **)(qword_18F0BCBA0[v40 + 36190] | (1LL << v38));
		            v41 = qword_18F0BCBA0[v40 + 36190];
		          }
		          while ( v41 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v40 + 36190],
		                           (signed __int64)static_fields,
		                           v41) );
		        }
		        if ( !v53 )
		          sub_1800D8250(static_fields, v38);
		        LODWORD(v53[4].monitor) = effectListCount;
		        v42 = v53;
		        v45 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v56, targetRT, 0LL);
		        if ( !v42 )
		          sub_1800D8250(v44, v43);
		        v42[1] = (Object)v45;
		        v46 = v53;
		        v49 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v56, depthRT, 0LL);
		        if ( !v46 )
		          sub_1800D8250(v48, v47);
		        v46[2] = (Object)v49;
		        si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v58,
		          &v56,
		          &v10->sceneColor,
		          0,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&si128,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v56,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields->m_parafinFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ParafinPassConstructor::ParafinData>);
		      }
		      catch ( Il2CppExceptionWrapper *v57 )
		      {
		        v55.handle = (ResourceHandle)v57->ex;
		      }
		      sub_180268AE0(&v55);
		      return;
		    }
		    v15 = 0LL;
		    do
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
		      s_parafinMaterials = TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor->static_fields->s_parafinMaterials;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v18 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		      runtimeMaterial = v18->runtimeMaterial;
		      if ( !runtimeMaterial )
		        sub_1800D8260(v18, v17);
		      if ( (unsigned int)v14 >= runtimeMaterial->max_length.size )
		        sub_1800D2AB0(v18, v17);
		      v20 = *(__int64 *)((char *)&runtimeMaterial->klass + v13);
		      if ( !s_parafinMaterials )
		        sub_1800D8260(v18, v17);
		      sub_180031B10(s_parafinMaterials, *(Material__Array__Class **)((char *)&runtimeMaterial->klass + v13));
		      sub_1800020D0(s_parafinMaterials, v15, v20);
		      ++v14;
		      ++v15;
		      v13 += 8LL;
		    }
		    while ( v14 < effectListCount );
		    v8 = renderGraph;
		    v10 = input;
		    goto LABEL_13;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3306, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v51, v50);
		  v55 = *targetRT;
		  si128 = *depthRT;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1216(
		    Patch,
		    (Object *)this,
		    v10,
		    output,
		    (Object *)v8,
		    (Object *)hgCamera,
		    &si128,
		    &v55,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BCE9EC-0x0000000189BCEA40
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ParafinPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3307, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3307, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCE998-0x0000000189BCE9EC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ParafinPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3308, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3308, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BCE870-0x0000000189BCE944
		// Void ConstructPass(ParafinPassConstructor+PassInput ByRef, ParafinPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::ParafinPassConstructor::ConstructPass(
		        ParafinPassConstructor *this,
		        ParafinPassConstructor_PassInput *input,
		        ParafinPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  TextureHandle sceneDepth; // xmm1
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle sceneColor; // [rsp+40h] [rbp-28h] BYREF
		  TextureHandle v14; // [rsp+50h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3309, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3309, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v11);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1217(
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
		    sceneDepth = input->sceneDepth;
		    sceneColor = input->sceneColor;
		    v14 = sceneDepth;
		    HG::Rendering::Runtime::ParafinPassConstructor::ParafinPass(
		      this,
		      input,
		      output,
		      renderGraph,
		      camera,
		      &v14,
		      &sceneColor,
		      0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCE944-0x0000000189BCE998
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ParafinPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3310, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3310, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D3A1F0-0x0000000184D3A260
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ParafinPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ParafinPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object_1 *m_parafinMaterial; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3311, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3311, 0LL);
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
		    m_parafinMaterial = (Object_1 *)this->fields.m_parafinMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_parafinMaterial, 0LL);
		    this->fields.m_parafinMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v12);
		  }
		}
		
	}
}
