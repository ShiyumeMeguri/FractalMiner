using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricCloudPassConstructor : IPassConstructor // TypeDefIndex: 38472
	{
		// Fields
		private TextureHandle m_currentSceneDepth; // 0x10
		private TextureHandle m_historySceneDepth; // 0x20
		private Material m_volumetricMaterial; // 0x30
		private VolumetricRenderer m_renderer; // 0x38
		private Material m_volumetricComposeMaterial; // 0x40
		private bool m_bHasCloud; // 0x48
		private bool m_bEnableDownRes; // 0x49
		private static readonly RenderFunc<VolumetricCloudPassPassData> s_volumetricCloudFunc; // 0x00
		private List<HGVolumetricRenderItem> m_renderItems; // 0x50
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38468
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneDepthCopied; // 0x20
			internal HGVolumetricCloudSettingParameters volumetricParameters; // 0x30
			internal List<IVolumetricRenderObject> volumetricRenderObjects; // 0x38
		}
	
		internal struct PassOutput // TypeDefIndex: 38469
		{
		}
	
		public class VolumetricCloudPassPassData // TypeDefIndex: 38470
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public TextureHandle sceneColor; // 0x18
			public TextureHandle sceneDepth; // 0x28
			public TextureHandle sceneDepthToSample; // 0x38
			public TextureHandle historySceneDepth; // 0x48
			public VolumetricRenderer renderer; // 0x58
			public Material volumetricComposeMaterial; // 0x60
			public HGVolumetricCloudSettingParameters volumetricParameters; // 0x68
			public List<IVolumetricRenderObject> volumetricRenderObjects; // 0x70
	
			// Constructors
			public VolumetricCloudPassPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public VolumetricCloudPassConstructor() {} // Dummy constructor
		internal VolumetricCloudPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB700-0x0000000182EDB850
		// VolumetricCloudPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassConstructor(
		        VolumetricCloudPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v7; // rax
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  __int64 v9; // rcx
		  List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *v10; // rdi
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRenderPipelineRuntimeResources_MaterialResources *materials; // rax
		  Material *m_volumetricMaterial; // r14
		  VolumetricRenderer *v18; // rax
		  VolumetricRenderer *v19; // rdi
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  TextureHandle v27; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v28; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_currentSceneDepth = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v27, 0LL);
		  this->fields.m_historySceneDepth = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v27, 0LL);
		  v7 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>);
		  v10 = (List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *)v7;
		  if ( !v7 )
		    goto LABEL_4;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v7,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::List);
		  this->fields.m_renderItems = v10;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderItems, v11, v12, v13, *(MethodInfo **)&v27.handle);
		  if ( !resources->defaultResources )
		    goto LABEL_4;
		  materials = resources->defaultResources->fields.materials;
		  if ( !materials )
		    goto LABEL_4;
		  this->fields.m_volumetricMaterial = materials->fields.volumetricMaterial;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_volumetricMaterial,
		    v8,
		    v14,
		    v15,
		    *(MethodInfo **)&v27.handle);
		  m_volumetricMaterial = this->fields.m_volumetricMaterial;
		  v18 = (VolumetricRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer);
		  v19 = v18;
		  if ( !v18
		    || (HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderer(v18, m_volumetricMaterial, 0LL),
		        this->fields.m_renderer = v19,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderer, v20, v21, v22, *(MethodInfo **)&v27.handle),
		        !resources->defaultResources)
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		LABEL_4:
		    sub_1800D8260(v9, v8);
		  }
		  this->fields.m_volumetricComposeMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                               materialCollector,
		                                               shaders->fields.volumetricComposePS,
		                                               0,
		                                               0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_volumetricComposeMaterial, v24, v25, v26, v28);
		}
		
		static VolumetricCloudPassConstructor() {} // 0x0000000184D2C340-0x0000000184D2C3D0
		// VolumetricCloudPassConstructor()
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::cctor(MethodInfo *method)
		{
		  struct VolumetricCloudPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_VolumetricCloudPassConstructor_VolumetricCloudPassPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_VolumetricCloudPassConstructor_VolumetricCloudPassPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor::__c::__cctor_b__19_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor->static_fields->s_volumetricCloudFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		internal bool ShouldRenderVolumetricCloud(ref PassInput input) => default; // 0x0000000189BE5720-0x0000000189BE578C
		// Boolean ShouldRenderVolumetricCloud(VolumetricCloudPassConstructor+PassInput ByRef)
		bool HG::Rendering::Runtime::VolumetricCloudPassConstructor::ShouldRenderVolumetricCloud(
		        VolumetricCloudPassConstructor *this,
		        VolumetricCloudPassConstructor_PassInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3448, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3448, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1244(Patch, (Object *)this, input, 0LL);
		  }
		  else
		  {
		    return input->volumetricRenderObjects && input->volumetricRenderObjects->fields._size != 0;
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BE4E4C-0x0000000189BE53EC
		// Void ConstructPass(VolumetricCloudPassConstructor+PassInput ByRef, VolumetricCloudPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::ConstructPass(
		        VolumetricCloudPassConstructor *this,
		        VolumetricCloudPassConstructor_PassInput *input,
		        VolumetricCloudPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  bool ShouldRenderVolumetricCloud; // al
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rbx
		  ProfilingSampler *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  unsigned __int64 v17; // rdx
		  Object *v18; // rcx
		  unsigned __int64 v19; // r8
		  signed __int64 v20; // rtt
		  Object *v21; // r14
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  TextureHandle v24; // xmm0
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  Object *v27; // r14
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  TextureHandle v30; // xmm0
		  Object *v31; // r14
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  TextureHandle v34; // xmm0
		  Object *v35; // r14
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  TextureHandle v38; // xmm0
		  __int64 v39; // rcx
		  Object *v40; // rdx
		  int v41; // eax
		  unsigned __int64 v42; // rdx
		  unsigned __int64 v43; // r8
		  char v44; // dl
		  signed __int64 v45; // rtt
		  Object *v46; // rdx
		  Object__Class *volumetricRenderObjects; // rcx
		  unsigned __int64 v48; // rdx
		  unsigned __int64 v49; // r8
		  char v50; // dl
		  signed __int64 v51; // rtt
		  Object *v52; // rdx
		  Object__Class *m_volumetricComposeMaterial; // rcx
		  unsigned __int64 v54; // rdx
		  unsigned __int64 v55; // r8
		  char v56; // dl
		  signed __int64 v57; // rtt
		  Object *v58; // rdx
		  MonitorData *v59; // rcx
		  unsigned __int64 v60; // rdx
		  unsigned __int64 v61; // r8
		  char v62; // dl
		  signed __int64 v63; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  Object *v67; // [rsp+50h] [rbp-88h] BYREF
		  __m128i si128; // [rsp+60h] [rbp-78h] BYREF
		  _QWORD v69[2]; // [rsp+70h] [rbp-68h] BYREF
		  HGRenderGraphBuilder v70; // [rsp+80h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v71; // [rsp+A0h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v72; // [rsp+C0h] [rbp-18h] BYREF
		
		  v67 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3449, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3449, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v66, v65);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1245(
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
		    ShouldRenderVolumetricCloud = HG::Rendering::Runtime::VolumetricCloudPassConstructor::ShouldRenderVolumetricCloud(
		                                    this,
		                                    input,
		                                    0LL);
		    this->fields.m_bHasCloud = ShouldRenderVolumetricCloud;
		    if ( ShouldRenderVolumetricCloud )
		    {
		      volumetricParameters = input->volumetricParameters;
		      if ( !volumetricParameters )
		        sub_1800D8260(v12, v11);
		      this->fields.m_bEnableDownRes = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                        volumetricParameters->fields.enableDownRes,
		                                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      this->fields.m_currentSceneDepth = input->sceneDepthCopied;
		      v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x30u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v16, v15);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v71,
		        renderGraph,
		        (String *)"Volumetric Cloud",
		        &v67,
		        v14,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
		      v70 = v71;
		      v69[0] = 0LL;
		      v69[1] = &v70;
		      try
		      {
		        v18 = v67;
		        if ( !v67 )
		          sub_1800D8250(0LL, v17);
		        v67[1].klass = (Object__Class *)camera;
		        if ( dword_18F35FD08 )
		        {
		          v19 = (((unsigned __int64)&v18[1] >> 12) & 0x1FFFFF) >> 6;
		          v17 = ((unsigned __int64)&v18[1] >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		          do
		          {
		            v18 = (Object *)(qword_18F0BCBA0[v19 + 36190] | (1LL << v17));
		            v20 = qword_18F0BCBA0[v19 + 36190];
		          }
		          while ( v20 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], (signed __int64)v18, v20) );
		        }
		        if ( !v67 )
		          sub_1800D8250(v18, v17);
		        *(TextureHandle *)((char *)v67 + 56) = input->sceneDepthCopied;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneDepthCopied, 0LL) )
		        {
		          v21 = v67;
		          v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&si128,
		                   &v70,
		                   &input->sceneDepthCopied,
		                   0LL);
		          if ( !v21 )
		            sub_1800D8250(v23, v22);
		          *(TextureHandle *)&v21[3].monitor = v24;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historySceneDepth, 0LL) )
		        {
		          v27 = v67;
		          v30 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&si128,
		                   &v70,
		                   &this->fields.m_historySceneDepth,
		                   0LL);
		          if ( !v27 )
		            sub_1800D8250(v29, v28);
		          *(TextureHandle *)&v27[4].monitor = v30;
		        }
		        else
		        {
		          if ( !v67 )
		            sub_1800D8250(v26, v25);
		          *(Object *)((char *)v67 + 72) = *(Object *)((char *)v67 + 56);
		        }
		        v31 = v67;
		        v34 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                 (TextureHandle *)&si128,
		                 &v70,
		                 &input->sceneColor,
		                 0LL);
		        if ( !v31 )
		          sub_1800D8250(v33, v32);
		        *(TextureHandle *)&v31[1].monitor = v34;
		        v35 = v67;
		        v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                 (TextureHandle *)&si128,
		                 &v70,
		                 &input->sceneDepth,
		                 0LL);
		        if ( !v35 )
		          sub_1800D8250(v37, v36);
		        *(TextureHandle *)&v35[2].monitor = v38;
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v71,
		          &v70,
		          &input->sceneColor,
		          0,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&si128,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v71,
		          &v70,
		          &input->sceneDepth,
		          DepthAccess__Enum_Read,
		          0,
		          0LL);
		        v40 = v67;
		        if ( !v67 )
		          sub_1800D8250(v39, 0LL);
		        v67[5].monitor = (MonitorData *)this->fields.m_renderer;
		        v41 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v42 = ((unsigned __int64)&v40[5].monitor >> 12) & 0x1FFFFF;
		          v43 = v42 >> 6;
		          v44 = v42 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v43 + 36190]);
		          do
		            v45 = qword_18F0BCBA0[v43 + 36190];
		          while ( v45 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v43 + 36190], v45 | (1LL << v44), v45) );
		          v41 = dword_18F35FD08;
		        }
		        v46 = v67;
		        volumetricRenderObjects = (Object__Class *)input->volumetricRenderObjects;
		        if ( !v67 )
		          sub_1800D8250(volumetricRenderObjects, 0LL);
		        v67[7].klass = volumetricRenderObjects;
		        if ( v41 )
		        {
		          v48 = ((unsigned __int64)&v46[7] >> 12) & 0x1FFFFF;
		          v49 = v48 >> 6;
		          v50 = v48 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v49 + 36190]);
		          do
		            v51 = qword_18F0BCBA0[v49 + 36190];
		          while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v49 + 36190], v51 | (1LL << v50), v51) );
		          v41 = dword_18F35FD08;
		        }
		        v52 = v67;
		        m_volumetricComposeMaterial = (Object__Class *)this->fields.m_volumetricComposeMaterial;
		        if ( !v67 )
		          sub_1800D8250(m_volumetricComposeMaterial, 0LL);
		        v67[6].klass = m_volumetricComposeMaterial;
		        if ( v41 )
		        {
		          v54 = ((unsigned __int64)&v52[6] >> 12) & 0x1FFFFF;
		          v55 = v54 >> 6;
		          v56 = v54 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v55 + 36190]);
		          do
		            v57 = qword_18F0BCBA0[v55 + 36190];
		          while ( v57 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v55 + 36190], v57 | (1LL << v56), v57) );
		          v41 = dword_18F35FD08;
		        }
		        v58 = v67;
		        v59 = (MonitorData *)input->volumetricParameters;
		        if ( !v67 )
		          sub_1800D8250(v59, 0LL);
		        v67[6].monitor = v59;
		        if ( v41 )
		        {
		          v60 = ((unsigned __int64)&v58[6].monitor >> 12) & 0x1FFFFF;
		          v61 = v60 >> 6;
		          v62 = v60 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v61 + 36190]);
		          do
		            v63 = qword_18F0BCBA0[v61 + 36190];
		          while ( v63 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v61 + 36190], v63 | (1LL << v62), v63) );
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v70,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor->static_fields->s_volumetricCloudFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v72 )
		      {
		        v69[0] = v72->ex;
		      }
		      sub_180268AE0(v69);
		    }
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BE5510-0x0000000189BE5720
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        VolumetricCloudPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  Material *m_volumetricMaterial; // rbp
		  HGManagerContext *currentManagerContext; // rax
		  VolumetricManager *volumetricManager_k__BackingField; // rcx
		  __int64 v8; // rdx
		  VolumetricShaderIDs__StaticFields *static_fields; // rcx
		  List_1_System_Object_ *VolumetricRenderObjects; // r14
		  Object_1 *v11; // rbx
		  int32_t v12; // edi
		  Object *Item; // rax
		  VolumetricCloudSDF *v14; // rax
		  VolumetricCloudSDF *v15; // rsi
		  int32_t volumePriority; // r12d
		  float FloatImpl; // xmm6_4
		  float v18; // xmm0_4
		  int v19; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v21; // [rsp+20h] [rbp-48h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3450, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3450, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		      return;
		    }
		    goto LABEL_22;
		  }
		  m_volumetricMaterial = this->fields.m_volumetricMaterial;
		  currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		  if ( currentManagerContext )
		  {
		    volumetricManager_k__BackingField = currentManagerContext->fields._volumetricManager_k__BackingField;
		    if ( volumetricManager_k__BackingField )
		    {
		      VolumetricRenderObjects = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricManager::get_VolumetricRenderObjects(
		                                                           volumetricManager_k__BackingField,
		                                                           0LL);
		      v11 = 0LL;
		      v12 = 0;
		      if ( !VolumetricRenderObjects )
		        goto LABEL_22;
		      while ( v12 < VolumetricRenderObjects->fields._size )
		      {
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 VolumetricRenderObjects,
		                 v12,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Item);
		        v14 = (VolumetricCloudSDF *)sub_180005050(Item, TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
		        v15 = v14;
		        if ( v14 && HG::Rendering::Runtime::VolumetricCloudSDF::get_HasComposeOverride(v14, 0LL) )
		        {
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Equality(v11, 0LL, 0LL) )
		            goto LABEL_11;
		          volumePriority = HG::Rendering::Runtime::VolumetricCloudSDF::get_volumePriority(v15, 0LL);
		          if ( !v11 )
		            goto LABEL_22;
		          if ( volumePriority > HG::Rendering::Runtime::VolumetricCloudSDF::get_volumePriority(
		                                  (VolumetricCloudSDF *)v11,
		                                  0LL) )
		LABEL_11:
		            v11 = (Object_1 *)v15;
		        }
		        ++v12;
		      }
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(v11, 0LL, 0LL) )
		      {
		        if ( !v11 )
		          goto LABEL_22;
		        m_volumetricMaterial = (Material *)v11[2].monitor;
		      }
		    }
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !m_volumetricMaterial )
		LABEL_22:
		    sub_1800D8260(static_fields, v8);
		  FloatImpl = UnityEngine::Material::GetFloatImpl(m_volumetricMaterial, static_fields->_ComposeDepthFadeOffset, 0LL);
		  v18 = UnityEngine::Material::GetFloatImpl(
		          m_volumetricMaterial,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ComposeDepthFadeDistance,
		          0LL);
		  if ( this->fields.m_bHasCloud )
		    v19 = 1065353216;
		  else
		    v19 = 0;
		  *(_QWORD *)&v21 = __PAIR64__(LODWORD(v18), v19);
		  *((float *)&v21 + 2) = 1.0 / v18;
		  *((float *)&v21 + 3) = FloatImpl;
		  *(_OWORD *)&shaderVariablesGlobal[1]._ExponentialFogParams0.w = v21;
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BE54BC-0x0000000189BE5510
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        VolumetricCloudPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3453, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3453, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BE53EC-0x0000000189BE54BC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        VolumetricCloudPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  HGRenderGraph *renderGraph; // rdx
		  TextureHandle *nullHandle; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3454, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currentSceneDepth, 0LL)
		      || this->fields.m_bEnableDownRes
		      || !this->fields.m_bHasCloud )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v9, 0LL);
		      goto LABEL_7;
		    }
		    renderGraph = input->renderGraph;
		    if ( renderGraph )
		    {
		      nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                     &v9,
		                     renderGraph,
		                     &this->fields.m_currentSceneDepth,
		                     1,
		                     (String *)"VolumericCloudPass",
		                     0LL);
		LABEL_7:
		      this->fields.m_historySceneDepth = *nullHandle;
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v5, renderGraph);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3454, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x000000018451DFA0-0x000000018451E000
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        VolumetricCloudPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3455, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3455, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else if ( this->fields.m_renderer )
		  {
		    HG::Rendering::Runtime::VolumetricRenderer::Release(this->fields.m_renderer, 0LL);
		    this->fields.m_renderer = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderer, v5, v6, v7, v11);
		  }
		}
		
	}
}
