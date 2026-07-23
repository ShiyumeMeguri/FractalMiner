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
	internal class GTAOPassConstructor : IPassConstructor // TypeDefIndex: 38325
	{
		// Fields
		private const int GTAO_DEPTH_MIP_LEVELS = 5; // Metadata: 0x02303C7C
		private const int GTAO_NUMTHREADS_X = 8; // Metadata: 0x02303C7D
		private const int GTAO_NUMTHREADS_Y = 8; // Metadata: 0x02303C7E
		private static string[] m_GTAmbientOcclusionMainPassKernel; // 0x00
		private int m_temporalTextureWidth; // 0x10
		private int m_temporalTextureHeight; // 0x14
		private TextureHandle m_prevTemporalTexture; // 0x18
		private TextureHandle m_currTemporalTexture; // 0x28
		private RTHandle m_defaultTexture; // 0x38
		private ComputeShader m_shader; // 0x40
		private static readonly RenderFunc<GTAmbientOcclusionPassData> s_GTAmbientOcclusionRenderFunc; // 0x08
	
		// Properties
		private static string m_GTAmbientOcclusioFeatureName { get => default; } // 0x0000000189BBA234-0x0000000189BBA27C 
		// String get_m_GTAmbientOcclusioFeatureName()
		String *HG::Rendering::Runtime::GTAOPassConstructor::get_m_GTAmbientOcclusioFeatureName(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3212, 0LL) )
		    return (String *)"GTAO";
		  Patch = IFix::WrappersManagerImpl::GetPatch(3212, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1106(Patch, 0LL);
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38320
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal TextureHandle sceneMV; // 0x10
			internal GBufferOutput gBufferOutput; // 0x20
			internal int qualityLevel; // 0x40
		}
	
		internal struct PassOutput // TypeDefIndex: 38321
		{
			// Fields
			internal TextureHandle indirectAmbientOcclusionTexture; // 0x00
		}
	
		private class GTAmbientOcclusionPassData // TypeDefIndex: 38322
		{
			// Fields
			public bool enableFP32Depths; // 0x10
			public bool enableBentNormals; // 0x11
			public bool enableUpsample; // 0x12
			public bool generateNormalsInplace; // 0x13
			public int denoisePassCount; // 0x14
			public int qualityLevel; // 0x18
			public Vector4 param0; // 0x1C
			public Vector4 param1; // 0x2C
			public Vector4 param2; // 0x3C
			public Vector4 halfScreenSize; // 0x4C
			public Vector2Int screenSizeInt; // 0x5C
			public Vector2Int halfScreenSizeInt; // 0x64
			public TextureHandle sceneDepthRT; // 0x6C
			public TextureHandle gBuffer1; // 0x7C
			public TextureHandle gBufferMV; // 0x8C
			public TextureHandle depthsMIP; // 0x9C
			public TextureHandle mainAOTermRT; // 0xAC
			public TextureHandle edgesRT; // 0xBC
			public TextureHandle previousAOTermRT; // 0xCC
			public TextureHandle currentAOTermRT; // 0xDC
			public TextureHandle blurAOTermRT; // 0xEC
			public TextureHandle upsampleAOTermRT; // 0xFC
			public TextureHandle debugRT; // 0x10C
			public ComputeShader GTAmbientOcclusionCS; // 0x120
	
			// Constructors
			public GTAmbientOcclusionPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		public struct GTAOData // TypeDefIndex: 38323
		{
			// Fields
			public Vector4 param0; // 0x00
			public Vector4 param1; // 0x10
			public Vector4 param2; // 0x20
			public Vector4 param3; // 0x30
			public Vector4 halfScreenSize; // 0x40
		}
	
		// Constructors
		public GTAOPassConstructor() {} // Dummy constructor
		internal GTAOPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB0E0-0x0000000182EDB190
		// GTAOPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::GTAOPassConstructor::GTAOPassConstructor(
		        GTAOPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Texture *whiteTexture; // rsi
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  __int64 v10; // rcx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  TextureHandle v14; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v15; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_prevTemporalTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v14, 0LL);
		  whiteTexture = (Texture *)UnityEngine::Texture2D::get_whiteTexture(0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RTHandles->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RTHandles);
		  this->fields.m_defaultTexture = UnityEngine::Rendering::RTHandleSystem::Alloc(whiteTexture, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_defaultTexture, v6, v7, v8, *(MethodInfo **)&v14.handle);
		  if ( !resources->defaultResources || (shaders = resources->defaultResources->fields.shaders) == 0LL )
		    sub_1800D8260(v10, v9);
		  this->fields.m_shader = shaders->fields.GTAmbientOcclusionCS;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_shader, v9, v11, v12, v15);
		}
		
		static GTAOPassConstructor() {} // 0x0000000184B49740-0x0000000184B49870
		// GTAOPassConstructor()
		void HG::Rendering::Runtime::GTAOPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  String__Array *v4; // rbx
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  struct GTAOPassConstructor_c__Class *v8; // r9
		  Object *v9; // rdi
		  RenderFunc_1_System_Object_ *v10; // rax
		  MonitorData *v11; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::System::String, 4LL);
		  v4 = (String__Array *)v1;
		  if ( !v1 )
		    goto LABEL_5;
		  sub_180005370(v1, 0LL, "GTAOLow");
		  sub_180005370(v4, 1LL, "GTAOMedium");
		  sub_180005370(v4, 2LL, "GTAOHigh");
		  sub_180005370(v4, 3LL, "GTAOUltra");
		  TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor->static_fields->m_GTAmbientOcclusionMainPassKernel = v4;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor->static_fields,
		    v5,
		    v6,
		    v7,
		    v15);
		  v8 = TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor::__c);
		    v8 = TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor::__c;
		  }
		  v9 = (Object *)v8->static_fields->__9;
		  v10 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
		  v11 = (MonitorData *)v10;
		  if ( !v10 )
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v10,
		    v9,
		    MethodInfo::HG::Rendering::Runtime::GTAOPassConstructor::__c::__cctor_b__24_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor->static_fields;
		  static_fields->monitor = v11;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor->static_fields->s_GTAmbientOcclusionRenderFunc,
		    static_fields,
		    v13,
		    v14,
		    v16);
		}
		
	
		// Methods
		private void Prepare(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, GTAmbientOcclusionPassData passData) {} // 0x0000000189BB9908-0x0000000189BBA234
		// Void Prepare(GTAOPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, GTAOPassConstructor+GTAmbientOcclusionPassData)
		void HG::Rendering::Runtime::GTAOPassConstructor::Prepare(
		        GTAOPassConstructor *this,
		        GTAOPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGRenderGraphBuilder *builder,
		        GTAOPassConstructor_GTAmbientOcclusionPassData *passData,
		        MethodInfo *method)
		{
		  unsigned __int64 enableFP32Depths; // rdx
		  signed __int64 v12; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  GTAmbientOcclusion *m_GTAmbientOcclusion; // rsi
		  char v15; // al
		  double v16; // xmm0_8
		  char CameraFrameCount; // al
		  double v18; // xmm0_8
		  __int64 v19; // rcx
		  int v20; // r8d
		  unsigned int v21; // xmm0_4
		  int v22; // eax
		  int v23; // edx
		  float v24; // xmm2_4
		  __m128i v25; // xmm0
		  __int64 v26; // rax
		  char v27; // dl
		  __int64 v28; // rcx
		  int v29; // r8d
		  bool v30; // cf
		  unsigned __int64 v31; // r8
		  signed __int64 v32; // rtt
		  __int64 v33; // xmm6_8
		  unsigned __int64 v34; // r8
		  signed __int64 v35; // rtt
		  unsigned __int64 v36; // r8
		  signed __int64 v37; // rtt
		  TextureHandle mainAOTermRT; // xmm0
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  TextureHandle *v41; // rax
		  bool v42; // zf
		  unsigned __int64 v43; // rdx
		  signed __int64 v44; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v46; // xmm1
		  Vector4 v47; // [rsp+48h] [rbp-C0h] BYREF
		  TextureDesc v48; // [rsp+58h] [rbp-B0h] BYREF
		  HGRenderGraphBuilder v49; // [rsp+B8h] [rbp-50h] BYREF
		  __int64 v50; // [rsp+D8h] [rbp-30h]
		  TextureDesc v51; // [rsp+E8h] [rbp-20h] BYREF
		  TextureDesc v52; // [rsp+148h] [rbp+40h] BYREF
		  TextureDesc v53; // [rsp+1A8h] [rbp+A0h] BYREF
		  TextureDesc v54; // [rsp+208h] [rbp+100h] BYREF
		  TextureDesc v55; // [rsp+268h] [rbp+160h] BYREF
		
		  v50 = 0LL;
		  sub_18033B9D0(&v52, 0LL, 96LL);
		  sub_18033B9D0(&v48, 0LL, 96LL);
		  sub_18033B9D0(&v51, 0LL, 96LL);
		  sub_18033B9D0(&v53, 0LL, 96LL);
		  sub_18033B9D0(&v54, 0LL, 96LL);
		  sub_18033B9D0(&v55, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3213, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3213, 0LL);
		    if ( Patch )
		    {
		      v46 = *(_OWORD *)&builder->m_RenderGraph;
		      *(_OWORD *)&v49.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		      *(_OWORD *)&v49.m_RenderGraph = v46;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1185(
		        Patch,
		        (Object *)this,
		        input,
		        (Object *)renderGraph,
		        (Object *)camera,
		        &v49,
		        (Object *)passData,
		        0LL);
		      return;
		    }
		LABEL_38:
		    sub_1800D8250(v12, enableFP32Depths);
		  }
		  if ( !camera )
		    goto LABEL_38;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_38;
		  m_GTAmbientOcclusion = volumeComponentsData->fields.m_GTAmbientOcclusion;
		  LOBYTE(v50) = 1;
		  HIDWORD(v50) = 1;
		  if ( !passData )
		    goto LABEL_38;
		  passData->fields.qualityLevel = input->qualityLevel;
		  if ( !m_GTAmbientOcclusion )
		    goto LABEL_38;
		  enableFP32Depths = (unsigned __int64)m_GTAmbientOcclusion->fields.enableFP32Depths;
		  if ( !enableFP32Depths )
		    goto LABEL_38;
		  passData->fields.enableFP32Depths = sub_180006280(10LL, enableFP32Depths);
		  passData->fields.enableBentNormals = 0;
		  passData->fields.enableUpsample = passData->fields.qualityLevel > 0;
		  enableFP32Depths = (unsigned __int64)m_GTAmbientOcclusion->fields.generateNormalsInplace;
		  if ( !enableFP32Depths )
		    goto LABEL_38;
		  v15 = sub_180006280(10LL, enableFP32Depths);
		  passData->fields.param0 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18DA45B50);
		  passData->fields.generateNormalsInplace = v15;
		  enableFP32Depths = (unsigned __int64)m_GTAmbientOcclusion->fields.finalValuePower;
		  if ( !enableFP32Depths )
		    goto LABEL_38;
		  v16 = sub_1800057D0(10LL, enableFP32Depths);
		  CameraFrameCount = HG::Rendering::Runtime::HGCamera::GetCameraFrameCount(camera, 0LL);
		  enableFP32Depths = (unsigned __int64)m_GTAmbientOcclusion->fields.depthMIPSamplingOffset;
		  if ( !enableFP32Depths )
		    goto LABEL_38;
		  v47.y = *(float *)&v16;
		  v47.x = 2.0;
		  v47.z = (float)(CameraFrameCount & 0x3F);
		  v18 = sub_1800057D0(10LL, enableFP32Depths);
		  v47.w = *(float *)&v18;
		  passData->fields.param1 = v47;
		  enableFP32Depths = (unsigned __int64)m_GTAmbientOcclusion->fields.denoisePasses;
		  if ( !enableFP32Depths )
		    goto LABEL_38;
		  if ( (unsigned int)sub_180002F70(10LL, enableFP32Depths) )
		    v21 = 1067030938;
		  else
		    v21 = 1176256512;
		  *(_QWORD *)&v47.x = v21;
		  v47.z = 0.050000001;
		  v47.w = 1.5;
		  passData->fields.param2 = v47;
		  v22 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  v23 = v22 >> 31;
		  v24 = 1.0 / (float)camera->fields._sceneRTSize_k__BackingField.m_X;
		  v47.x = (float)(camera->fields._sceneRTSize_k__BackingField.m_X / 2);
		  v25 = _mm_cvtsi32_si128(v22 / 2);
		  v26 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  v47.z = v24 + v24;
		  LODWORD(v47.y) = _mm_cvtepi32_ps(v25).m128_u32[0];
		  v47.w = (float)(1.0 / (float)(int)v26) + (float)(1.0 / (float)(int)v26);
		  passData->fields.halfScreenSize = v47;
		  passData->fields.screenSizeInt = camera->fields._sceneRTSize_k__BackingField;
		  LODWORD(v47.x) = sub_1834464B0(v19, v23, v20);
		  LODWORD(v47.y) = sub_1834464B0(v28, v27, v29);
		  passData->fields.halfScreenSizeInt = *(Vector2Int *)&v47.x;
		  passData->fields.sceneDepthRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                     (TextureHandle *)&v47,
		                                     builder,
		                                     &input->sceneDepth,
		                                     0LL);
		  v47 = (Vector4)*HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                    (TextureHandle *)&v47,
		                    &input->gBufferOutput,
		                    GBufferID__Enum_GBufferB,
		                    0LL);
		  passData->fields.gBuffer1 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                 (TextureHandle *)&v49,
		                                 builder,
		                                 (TextureHandle *)&v47,
		                                 0LL);
		  passData->fields.gBufferMV = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                  (TextureHandle *)&v49,
		                                  builder,
		                                  &input->sceneMV,
		                                  0LL);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v48,
		    passData->fields.halfScreenSizeInt.m_X,
		    passData->fields.halfScreenSizeInt.m_Y,
		    0LL);
		  v30 = passData->fields.enableFP32Depths;
		  *(_WORD *)&v48.enableRandomWrite = 257;
		  v48.autoGenerateMips = 0;
		  v48.name = (String *)"DepthBufferMipChain";
		  v12 = v30 ? 49 : 45;
		  v48.colorFormat = v30 ? 49 : 45;
		  if ( dword_18F35FD08 )
		  {
		    v31 = (((unsigned __int64)&v48.name >> 12) & 0x1FFFFF) >> 6;
		    enableFP32Depths = ((unsigned __int64)&v48.name >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		    do
		    {
		      v12 = qword_18F0BCBA0[v31 + 36190] | (1LL << enableFP32Depths);
		      v32 = qword_18F0BCBA0[v31 + 36190];
		    }
		    while ( v32 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v31 + 36190], v12, v32) );
		  }
		  v33 = v50;
		  v48.fastMemoryDesc.residencyFraction = 1.0;
		  *(_QWORD *)&v48.fastMemoryDesc.inFastMemory = v50;
		  v52 = v48;
		  if ( !renderGraph )
		    goto LABEL_38;
		  v47 = (Vector4)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                    (TextureHandle *)&v49,
		                    renderGraph,
		                    &v52,
		                    0LL);
		  passData->fields.depthsMIP = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                                  (TextureHandle *)&v49,
		                                  builder,
		                                  (TextureHandle *)&v47,
		                                  0LL);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v48,
		    passData->fields.halfScreenSizeInt.m_X,
		    passData->fields.halfScreenSizeInt.m_Y,
		    0LL);
		  v48.name = (String *)"OutAOTerm";
		  v48.colorFormat = 5;
		  *(_WORD *)&v48.enableRandomWrite = 1;
		  v48.autoGenerateMips = 0;
		  if ( dword_18F35FD08 )
		  {
		    v34 = (((unsigned __int64)&v48.name >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v34 + 36190]);
		    do
		      v35 = qword_18F0BCBA0[v34 + 36190];
		    while ( v35 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v34 + 36190],
		                     v35 | (1LL << (((unsigned __int64)&v48.name >> 12) & 0x3F)),
		                     v35) );
		  }
		  v48.fastMemoryDesc.residencyFraction = 1.0;
		  *(_QWORD *)&v48.fastMemoryDesc.inFastMemory = v33;
		  v51 = v48;
		  passData->fields.mainAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                     (TextureHandle *)&v49,
		                                     builder,
		                                     &v51,
		                                     0LL);
		  passData->fields.blurAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                     (TextureHandle *)&v49,
		                                     builder,
		                                     &v51,
		                                     0LL);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v48,
		    passData->fields.halfScreenSizeInt.m_X,
		    passData->fields.halfScreenSizeInt.m_Y,
		    0LL);
		  v48.name = (String *)"OutEdges";
		  v48.colorFormat = 5;
		  *(_WORD *)&v48.enableRandomWrite = 1;
		  v48.autoGenerateMips = 0;
		  if ( dword_18F35FD08 )
		  {
		    v36 = (((unsigned __int64)&v48.name >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v36 + 36190]);
		    do
		      v37 = qword_18F0BCBA0[v36 + 36190];
		    while ( v37 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v36 + 36190],
		                     v37 | (1LL << (((unsigned __int64)&v48.name >> 12) & 0x3F)),
		                     v37) );
		  }
		  v48.fastMemoryDesc.residencyFraction = 1.0;
		  *(_QWORD *)&v48.fastMemoryDesc.inFastMemory = v33;
		  v53 = v48;
		  passData->fields.edgesRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                (TextureHandle *)&v49,
		                                builder,
		                                &v53,
		                                0LL);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v48,
		    passData->fields.halfScreenSizeInt.m_X,
		    passData->fields.halfScreenSizeInt.m_Y,
		    0LL);
		  v48.wrapMode = 1;
		  v48.filterMode = 1;
		  v48.colorFormat = 48;
		  v54 = v48;
		  *(_WORD *)&v48.enableRandomWrite = 1;
		  v48.autoGenerateMips = 0;
		  this->fields.m_currTemporalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                          (TextureHandle *)&v49,
		                                          renderGraph,
		                                          &v54,
		                                          0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_prevTemporalTexture, 0LL)
		    && this->fields.m_temporalTextureWidth == passData->fields.halfScreenSizeInt.m_X
		    && this->fields.m_temporalTextureHeight == passData->fields.halfScreenSizeInt.m_Y )
		  {
		    passData->fields.param2.y = 1.0;
		    mainAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                      (TextureHandle *)&v49,
		                      builder,
		                      &this->fields.m_prevTemporalTexture,
		                      0LL);
		  }
		  else
		  {
		    passData->fields.param2.y = 0.0;
		    *(Vector2Int *)&this->fields.m_temporalTextureWidth = passData->fields.halfScreenSizeInt;
		    mainAOTermRT = passData->fields.mainAOTermRT;
		  }
		  passData->fields.previousAOTermRT = mainAOTermRT;
		  passData->fields.currentAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                                        (TextureHandle *)&v49,
		                                        builder,
		                                        &this->fields.m_currTemporalTexture,
		                                        0LL);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v48,
		    passData->fields.screenSizeInt.m_X,
		    passData->fields.screenSizeInt.m_Y,
		    0LL);
		  v48.name = (String *)"UpsampleAOTerm";
		  v48.colorFormat = 5;
		  *(_WORD *)&v48.enableRandomWrite = 1;
		  v48.autoGenerateMips = 0;
		  if ( dword_18F35FD08 )
		  {
		    v39 = (((unsigned __int64)&v48.name >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		    do
		      v40 = qword_18F0BCBA0[v39 + 36190];
		    while ( v40 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v39 + 36190],
		                     v40 | (1LL << (((unsigned __int64)&v48.name >> 12) & 0x3F)),
		                     v40) );
		  }
		  v48.fastMemoryDesc.residencyFraction = 1.0;
		  *(_QWORD *)&v48.fastMemoryDesc.inFastMemory = v33;
		  v55 = v48;
		  v47 = (Vector4)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                    (TextureHandle *)&v49,
		                    renderGraph,
		                    &v55,
		                    0LL);
		  v41 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		          (TextureHandle *)&v49,
		          builder,
		          (TextureHandle *)&v47,
		          0LL);
		  v42 = dword_18F35FD08 == 0;
		  passData->fields.upsampleAOTermRT = *v41;
		  passData->fields.GTAmbientOcclusionCS = this->fields.m_shader;
		  if ( !v42 )
		  {
		    v43 = (((unsigned __int64)&passData->fields.GTAmbientOcclusionCS >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v43 + 36190]);
		    do
		      v44 = qword_18F0BCBA0[v43 + 36190];
		    while ( v44 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v43 + 36190],
		                     v44 | (1LL << (((unsigned __int64)&passData->fields.GTAmbientOcclusionCS >> 12) & 0x3F)),
		                     v44) );
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BB98B4-0x0000000189BB9908
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        GTAOPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3214, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3214, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BB9860-0x0000000189BB98B4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        GTAOPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3215, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3215, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BB94A4-0x0000000189BB9774
		// Void ConstructPass(GTAOPassConstructor+PassInput ByRef, GTAOPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::GTAOPassConstructor::ConstructPass(
		        GTAOPassConstructor *this,
		        GTAOPassConstructor_PassInput *input,
		        GTAOPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  ProfilingSampler *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  GTAOPassConstructor_GTAmbientOcclusionPassData *v22; // [rsp+40h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v23; // [rsp+48h] [rbp-80h] BYREF
		  HGRenderGraphBuilder v24; // [rsp+50h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+70h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v26; // [rsp+90h] [rbp-38h] BYREF
		
		  v22 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3216, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3216, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1186(
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
		    if ( !HG::Rendering::Runtime::HGCamera::get_aoEnable(camera, 0LL) )
		      goto LABEL_10;
		    if ( !camera->fields.camera )
		      sub_1800D8260(v13, v12);
		    if ( UnityEngine::Camera::get_orthographic(camera->fields.camera, 0LL) )
		    {
		LABEL_10:
		      if ( !renderGraph )
		        sub_1800D8260(v13, v12);
		      *output = *(GTAOPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                     (TextureHandle *)&v24,
		                                                     renderGraph,
		                                                     this->fields.m_defaultTexture,
		                                                     0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_currTemporalTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                              (TextureHandle *)&v24,
		                                              0LL);
		    }
		    else
		    {
		      v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x49u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v16, v15);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v24,
		        renderGraph,
		        (String *)"GT Ambient Occlusion",
		        (Object **)&v22,
		        v14,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
		      v25 = v24;
		      v24.m_RenderPass = 0LL;
		      v24.m_Resources = (HGRenderGraphResourceRegistry *)&v25;
		      try
		      {
		        v26 = v25;
		        HG::Rendering::Runtime::GTAOPassConstructor::Prepare(this, input, renderGraph, camera, &v26, v22, 0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v25, 0, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v25,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor->static_fields->s_GTAmbientOcclusionRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
		        if ( !v22 )
		          sub_1800D8250(v18, v17);
		        *output = (GTAOPassConstructor_PassOutput)v22->fields.upsampleAOTermRT;
		      }
		      catch ( Il2CppExceptionWrapper *v23 )
		      {
		        v24.m_RenderPass = (HGRenderGraphPass *)v23->ex;
		      }
		      sub_180268AE0(&v24);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BB9774-0x0000000189BB9860
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        GTAOPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  TextureHandle *nullHandle; // rax
		  HGRenderGraph *renderGraph; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3217, 0LL) )
		  {
		    if ( input->passSkipped )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_currTemporalTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v9, 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currTemporalTexture, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v9, 0LL);
		LABEL_8:
		      this->fields.m_prevTemporalTexture = *nullHandle;
		      return;
		    }
		    renderGraph = input->renderGraph;
		    if ( renderGraph )
		    {
		      nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                     &v9,
		                     renderGraph,
		                     &this->fields.m_currTemporalTexture,
		                     1,
		                     (String *)"GTAOPass",
		                     0LL);
		      goto LABEL_8;
		    }
		LABEL_10:
		    sub_1800D8260(v5, renderGraph);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3217, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D803E0-0x0000000184D80410
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        GTAOPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3218, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3218, 0LL);
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
