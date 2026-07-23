using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGLowResDirectionalShadowPass // TypeDefIndex: 37850
	{
		// Fields
		internal const int LOW_RES_SHADOW_DOWNSAMPLE_SCALE = 4; // Metadata: 0x0230318D
		internal const float LOW_RES_SHADOW_INV_DOWNSAMPLE_SCALE = 0.25f; // Metadata: 0x0230318E
		private Material m_lowResDirectionalShadowMaterial; // 0x10
		private Material m_lowResShadowBlurMaterial; // 0x18
		private static readonly RenderFunc<HGLowResDirectionalShadowPassData> s_lowResDirectionalShadowPassRenderFunc; // 0x00
		private static readonly RenderFunc<HGLowResShadowBlurPassData> s_lowResShadowBlurPassRenderFunc; // 0x08
	
		// Nested types
		internal class HGLowResDirectionalShadowPassData // TypeDefIndex: 37847
		{
			// Fields
			public float downSampleScale; // 0x10
			public Material lowResDirectionalShadowMat; // 0x18
			public TextureHandle depthBuffer; // 0x20
			public TextureHandle lowResShadowTexture; // 0x30
	
			// Constructors
			public HGLowResDirectionalShadowPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal class HGLowResShadowBlurPassData // TypeDefIndex: 37848
		{
			// Fields
			public bool horizontalPass; // 0x10
			public Vector2Int rtResolution; // 0x14
			public Material lowResShadowBlurMat; // 0x20
			public TextureHandle lowResShadowTexture; // 0x28
			public TextureHandle lowResBlurredShadow; // 0x38
	
			// Constructors
			public HGLowResShadowBlurPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public HGLowResDirectionalShadowPass() {} // Dummy constructor
		internal HGLowResDirectionalShadowPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPipelineRuntimeResources defaultResources) {} // 0x000000018495A6F0-0x000000018495A780
		// HGLowResDirectionalShadowPass(HGRenderPipelineMaterialCollector, HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPass(
		        HGLowResDirectionalShadowPass *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  HGRenderPipelineMaterialCollector *v5; // rdi
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  v5 = materialCollector;
		  if ( !defaultResources
		    || (shaders = defaultResources->fields.shaders) == 0LL
		    || !materialCollector
		    || (this->fields.m_lowResDirectionalShadowMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                           materialCollector,
		                                                           shaders->fields.lowResDirectionalShadowPS,
		                                                           0,
		                                                           0LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v8, v9, v10, v14),
		        (materialCollector = (HGRenderPipelineMaterialCollector *)defaultResources->fields.shaders) == 0LL) )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  this->fields.m_lowResShadowBlurMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                              v5,
		                                              (Shader *)materialCollector[19].monitor,
		                                              0,
		                                              0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_lowResShadowBlurMaterial, v11, v12, v13, v15);
		}
		
		static HGLowResDirectionalShadowPass() {} // 0x0000000184CB4140-0x0000000184CB4240
		// HGLowResDirectionalShadowPass()
		void HG::Rendering::Runtime::HGLowResDirectionalShadowPass::cctor(MethodInfo *method)
		{
		  struct HGLowResDirectionalShadowPass_c__Class *v1; // rax
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
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c::__cctor_b__10_0,
		          0LL),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass::__c::__cctor_b__10_1,
		    0LL);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields->s_lowResShadowBlurPassRenderFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		internal TextureHandle Render(HGRenderGraph renderGraph, HGCamera hgCamera, float renderingScale, TextureHandle depthRT) => default; // 0x0000000189B4733C-0x0000000189B47EDC
		// TextureHandle Render(HGRenderGraph, HGCamera, Single, TextureHandle)
		// Hidden C++ exception states: #wind=4
		TextureHandle *HG::Rendering::Runtime::HGLowResDirectionalShadowPass::Render(
		        TextureHandle *__return_ptr retstr,
		        HGLowResDirectionalShadowPass *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        float renderingScale,
		        TextureHandle *depthRT,
		        MethodInfo *method)
		{
		  Object *v8; // r15
		  HGLowResDirectionalShadowPass *v9; // r13
		  TextureHandle *v10; // r12
		  ProfilingSampler *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Object__Class *v14; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  TextureHandle v17; // xmm6
		  TextureHandle v18; // xmm7
		  ProfilingSampler *v19; // rax
		  __int64 v20; // rcx
		  Object *v21; // rdx
		  unsigned int v22; // edx
		  unsigned __int64 v23; // r8
		  char v24; // dl
		  signed __int64 v25; // rtt
		  Object *v26; // r14
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  TextureHandle v29; // xmm0
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  ProfilingSampler *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  signed __int64 v35; // rcx
		  Object *v36; // rdx
		  unsigned int v37; // edx
		  unsigned __int64 v38; // r8
		  signed __int64 v39; // rtt
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  ProfilingSampler *v44; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  signed __int64 v47; // rcx
		  Object *v48; // rdx
		  unsigned int v49; // edx
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  TextureHandle v56; // xmm6
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  Object *v61; // [rsp+50h] [rbp-2C8h] BYREF
		  Object *v62; // [rsp+58h] [rbp-2C0h] BYREF
		  Il2CppException *ex; // [rsp+60h] [rbp-2B8h] BYREF
		  HGRenderGraphBuilder *v64; // [rsp+68h] [rbp-2B0h]
		  Object *v65; // [rsp+70h] [rbp-2A8h] BYREF
		  Vector2Int size; // [rsp+78h] [rbp-2A0h]
		  HGRenderGraphBuilder v67; // [rsp+80h] [rbp-298h] BYREF
		  Color v68; // [rsp+A0h] [rbp-278h] BYREF
		  TextureHandle v69; // [rsp+B0h] [rbp-268h] BYREF
		  TextureHandle v70; // [rsp+C0h] [rbp-258h] BYREF
		  _QWORD v71[2]; // [rsp+D0h] [rbp-248h] BYREF
		  TextureHandle v72; // [rsp+E0h] [rbp-238h] BYREF
		  HGRenderGraphBuilder v73; // [rsp+F0h] [rbp-228h] BYREF
		  HGRenderGraphBuilder v74; // [rsp+110h] [rbp-208h] BYREF
		  HGRenderGraphBuilder v75; // [rsp+130h] [rbp-1E8h] BYREF
		  TextureHandle v76; // [rsp+150h] [rbp-1C8h] BYREF
		  HGRenderGraphProfilingScope v77; // [rsp+160h] [rbp-1B8h] BYREF
		  Il2CppExceptionWrapper *v78; // [rsp+178h] [rbp-1A0h] BYREF
		  Il2CppExceptionWrapper *v79; // [rsp+180h] [rbp-198h] BYREF
		  Il2CppExceptionWrapper *v80; // [rsp+188h] [rbp-190h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+190h] [rbp-188h] BYREF
		  TextureDesc v82; // [rsp+1A0h] [rbp-178h] BYREF
		  TextureDesc v83; // [rsp+200h] [rbp-118h] BYREF
		  __int128 v84; // [rsp+270h] [rbp-A8h]
		  __int128 v85; // [rsp+280h] [rbp-98h]
		
		  v8 = (Object *)renderGraph;
		  v9 = this;
		  v10 = retstr;
		  memset(&v77, 0, sizeof(v77));
		  sub_18033B9D0(&v82, 0LL, 96LL);
		  memset(&v73, 0, sizeof(v73));
		  v65 = 0LL;
		  memset(&v74, 0, sizeof(v74));
		  v61 = 0LL;
		  memset(&v75, 0, sizeof(v75));
		  v62 = 0LL;
		  v72 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2174, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2174, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v58, v57);
		    v72 = *depthRT;
		    *v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_869(
		              (TextureHandle *)&v67,
		              Patch,
		              (Object *)v9,
		              v8,
		              (Object *)hgCamera,
		              renderingScale,
		              &v72,
		              0LL);
		  }
		  else
		  {
		    v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x83u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		      &v77,
		      (HGRenderGraph *)v8,
		      v11,
		      0LL);
		    v71[0] = 0LL;
		    v71[1] = &v77;
		    try
		    {
		      if ( !hgCamera )
		        sub_1800D8250(v13, v12);
		      size.m_X = sub_1832DBD50();
		      size.m_Y = sub_1832DBD50();
		      sub_18033B9D0(&v83, 0LL, 96LL);
		      v14 = (Object__Class *)size;
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v83, size, 0LL);
		      HIDWORD(v84) = v83.dimension;
		      v85 = *(_OWORD *)&v83.enableRandomWrite;
		      LODWORD(v84) = 5;
		      BYTE1(v85) = 0;
		      *(_QWORD *)((char *)&v84 + 4) = 0x100000001LL;
		      *(_OWORD *)&v82.width = *(_OWORD *)&v83.width;
		      *(_OWORD *)&v82.colorFormat = v84;
		      *(_OWORD *)&v82.enableRandomWrite = v85;
		      *(_OWORD *)&v82.bindTextureMS = *(_OWORD *)&v83.bindTextureMS;
		      *(_OWORD *)&v82.fastMemoryDesc.inFastMemory = *(_OWORD *)&v83.fastMemoryDesc.inFastMemory;
		      v82.clearColor = v83.clearColor;
		      if ( !v8 )
		        sub_1800D8250(v16, v15);
		      v17 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v70, (HGRenderGraph *)v8, &v82, 0LL);
		      v69 = v17;
		      v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v70, (HGRenderGraph *)v8, &v82, 0LL);
		      v76 = v18;
		      v70 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v70, (HGRenderGraph *)v8, &v82, 0LL);
		      v19 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x84u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v67,
		        (HGRenderGraph *)v8,
		        (String *)"Low Res Directional Shadow",
		        &v65,
		        v19,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
		      v73 = v67;
		      ex = 0LL;
		      v64 = &v73;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v73, 0, 0LL);
		        v21 = v65;
		        if ( !v65 )
		          sub_1800D8250(v20, 0LL);
		        v65[1].monitor = (MonitorData *)v9->fields.m_lowResDirectionalShadowMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v22 = ((unsigned __int64)&v21[1].monitor >> 12) & 0x1FFFFF;
		          v23 = (unsigned __int64)v22 >> 6;
		          v24 = v22 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v23 + 36190]);
		          do
		            v25 = qword_18F0BCBA0[v23 + 36190];
		          while ( v25 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v23 + 36190], v25 | (1LL << v24), v25) );
		        }
		        v26 = v65;
		        v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&v68,
		                 &v73,
		                 depthRT,
		                 0LL);
		        if ( !v26 )
		          sub_1800D8250(v28, v27);
		        v26[2] = (Object)v29;
		        if ( !v65 )
		          sub_1800D8250(v28, v27);
		        v65[3] = (Object)v17;
		        if ( !v65 )
		          sub_1800D8250(v28, v27);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		          (TextureHandle *)&v68,
		          &v73,
		          (TextureHandle *)&v65[3],
		          0LL);
		        if ( !v65 )
		          sub_1800D8250(v31, v30);
		        v68 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v67,
		          &v73,
		          (TextureHandle *)&v65[3],
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_DontCare,
		          &v68,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v73,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields->s_lowResDirectionalShadowPassRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v78 )
		      {
		        ex = v78->ex;
		        sub_180268AE0(&ex);
		        v8 = (Object *)renderGraph;
		        v9 = this;
		        v10 = retstr;
		        v17 = v69;
		        v18 = v76;
		        v14 = (Object__Class *)size;
		        goto LABEL_16;
		      }
		      sub_180268AE0(&ex);
		LABEL_16:
		      v32 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x85u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v67,
		        (HGRenderGraph *)v8,
		        (String *)"Low Res Directional Shadow Blur Horizontal",
		        &v61,
		        v32,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
		      v74 = v67;
		      ex = 0LL;
		      v64 = &v74;
		      try
		      {
		        if ( !v61 )
		          sub_1800D8250(v34, v33);
		        LOBYTE(v61[1].klass) = 1;
		        if ( !v61 )
		          sub_1800D8250(v34, v33);
		        *(Object__Class **)((char *)&v61[1].klass + 4) = v14;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v74, 0, 0LL);
		        v36 = v61;
		        if ( !v61 )
		          sub_1800D8250(v35, 0LL);
		        v61[2].klass = (Object__Class *)v9->fields.m_lowResShadowBlurMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v37 = ((unsigned __int64)&v36[2] >> 12) & 0x1FFFFF;
		          v38 = (unsigned __int64)v37 >> 6;
		          v36 = (Object *)(v37 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		          do
		          {
		            v35 = qword_18F0BCBA0[v38 + 36190] | (1LL << (char)v36);
		            v39 = qword_18F0BCBA0[v38 + 36190];
		          }
		          while ( v39 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v38 + 36190], v35, v39) );
		        }
		        if ( !v61 )
		          sub_1800D8250(v35, v36);
		        *(TextureHandle *)&v61[2].monitor = v17;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v67, &v74, &v69, 0LL);
		        if ( !v61 )
		          sub_1800D8250(v41, v40);
		        *(TextureHandle *)&v61[3].monitor = v18;
		        if ( !v61 )
		          sub_1800D8250(v41, v40);
		        v69 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v67,
		          &v74,
		          (TextureHandle *)&v61[3].monitor,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_DontCare,
		          (Color *)&v69,
		          0,
		          0LL);
		        if ( !v61 )
		          sub_1800D8250(v43, v42);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		          (TextureHandle *)&v67,
		          &v74,
		          (TextureHandle *)&v61[3].monitor,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v74,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields->s_lowResShadowBlurPassRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v79 )
		      {
		        ex = v79->ex;
		        sub_180268AE0(&ex);
		        v8 = (Object *)renderGraph;
		        v9 = this;
		        v10 = retstr;
		        v18 = v76;
		        v14 = (Object__Class *)size;
		        goto LABEL_29;
		      }
		      sub_180268AE0(&ex);
		LABEL_29:
		      v44 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x86u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v67,
		        (HGRenderGraph *)v8,
		        (String *)"Low Res Directional Shadow Blur Vertical",
		        &v62,
		        v44,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
		      v75 = v67;
		      ex = 0LL;
		      v64 = &v75;
		      try
		      {
		        if ( !v62 )
		          sub_1800D8250(v46, v45);
		        LOBYTE(v62[1].klass) = 0;
		        if ( !v62 )
		          sub_1800D8250(v46, v45);
		        *(Object__Class **)((char *)&v62[1].klass + 4) = v14;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v75, 0, 0LL);
		        v48 = v62;
		        if ( !v62 )
		          sub_1800D8250(v47, 0LL);
		        v62[2].klass = (Object__Class *)v9->fields.m_lowResShadowBlurMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v49 = ((unsigned __int64)&v48[2] >> 12) & 0x1FFFFF;
		          v50 = (unsigned __int64)v49 >> 6;
		          v48 = (Object *)(v49 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		          do
		          {
		            v47 = qword_18F0BCBA0[v50 + 36190] | (1LL << (char)v48);
		            v51 = qword_18F0BCBA0[v50 + 36190];
		          }
		          while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v47, v51) );
		        }
		        if ( !v62 )
		          sub_1800D8250(v47, v48);
		        *(TextureHandle *)&v62[2].monitor = v18;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v67, &v75, &v76, 0LL);
		        if ( !v62 )
		          sub_1800D8250(v53, v52);
		        *(TextureHandle *)&v62[3].monitor = v70;
		        if ( !v62 )
		          sub_1800D8250(v53, v52);
		        v69 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v67,
		          &v75,
		          (TextureHandle *)&v62[3].monitor,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_DontCare,
		          (Color *)&v69,
		          0,
		          0LL);
		        if ( !v62 )
		          sub_1800D8250(v55, v54);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		          (TextureHandle *)&v67,
		          &v75,
		          (TextureHandle *)&v62[3].monitor,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v75,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass->static_fields->s_lowResShadowBlurPassRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v80 )
		      {
		        ex = v80->ex;
		        sub_180268AE0(&ex);
		        v10 = retstr;
		        goto LABEL_42;
		      }
		      sub_180268AE0(&ex);
		LABEL_42:
		      v56 = v70;
		      v72 = v70;
		    }
		    catch ( Il2CppExceptionWrapper *v81 )
		    {
		      v71[0] = v81->ex;
		      sub_180269330(v71);
		      v10 = retstr;
		      v56 = v72;
		      goto LABEL_44;
		    }
		    sub_180269330(v71);
		LABEL_44:
		    *v10 = v56;
		  }
		  return v10;
		}
		
	}
}
