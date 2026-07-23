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
	internal class DepthOnlyPassConstructor : IPassConstructor // TypeDefIndex: 38227
	{
		// Fields
		private Material m_clearDepth; // 0x10
		private static Plane[] s_tempPlanes; // 0x00
		private MaterialPropertyBlock m_waterMPB; // 0x18
		private Material m_waterProxyMaterial; // 0x20
		private static readonly RenderFunc<DepthOnlyPassData> s_depthOnlyPassFunc; // 0x08
		private static readonly RenderFunc<VSMPassData> s_vsmPassFunc; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38222
		{
			// Fields
			internal ScriptableRenderContext srpContext; // 0x00
			internal CustomDepthOnlyRequestManager customDepthOnlyRequestManger; // 0x08
		}
	
		internal struct PassOutput // TypeDefIndex: 38223
		{
		}
	
		private class DepthOnlyPassData // TypeDefIndex: 38224
		{
			// Fields
			internal Matrix4x4 viewProj; // 0x10
			internal RendererListHandle rendererList; // 0x50
			internal uint ecsRendererList; // 0x58
			internal uint terrainHandle; // 0x5C
			internal uint editorTerrainHandle; // 0x60
			internal TextureHandle currDepthOnlyRT; // 0x64
			internal TextureHandle prevDepthOnlyRT; // 0x74
			internal Material clearDepthMat; // 0x88
			internal CBHandle cameraHeightRefreshDataCB; // 0x90
			internal CBHandle transformCB; // 0xA8
			internal Rect clearViewport0; // 0xC0
			internal Rect clearViewport1; // 0xD0
			internal Rect clearViewport2; // 0xE0
			internal Rect clearViewport3; // 0xF0
			internal Rect pageViewport; // 0x100
			internal Rect wholeViewport; // 0x110
			internal int depthRTShaderID; // 0x120
			internal int transformCBShaderID; // 0x124
			internal bool includeDynamicObjects; // 0x128
			internal uint waterVisibleCount; // 0x12C
			internal uint waterCullHandle; // 0x130
			internal MaterialPropertyBlock waterMPB; // 0x138
			internal Material waterProxyMaterial; // 0x140
			internal HGCamera hgCamera; // 0x148
	
			// Constructors
			public DepthOnlyPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class VSMPassData // TypeDefIndex: 38225
		{
			// Fields
			internal int vsmRTID; // 0x10
			internal TextureHandle vsmRTHandle; // 0x14
			internal Material vsmMaterial; // 0x28
	
			// Constructors
			public VSMPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public DepthOnlyPassConstructor() {} // Dummy constructor
		internal DepthOnlyPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001849E5B50-0x00000001849E5C20
		// DepthOnlyPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassConstructor(
		        DepthOnlyPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources *defaultResources; // rdx
		  __int64 v8; // rcx
		  MaterialPropertyBlock *v9; // rdi
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+50h] [rbp+28h]
		
		  v9 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v9 )
		    goto LABEL_2;
		  v9->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_waterMPB = v9;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_waterMPB, v10, v11, v12, v20);
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector
		    || (this->fields.m_clearDepth = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                      materialCollector,
		                                      shaders->fields.clearDepth,
		                                      0,
		                                      0LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v14, v15, v16, v21),
		        (defaultResources = resources->defaultResources) == 0LL)
		    || (defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders) == 0LL )
		  {
		LABEL_2:
		    sub_1800D8260(v8, defaultResources);
		  }
		  this->fields.m_waterProxyMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                        materialCollector,
		                                        (Shader *)defaultResources[16].fields.assets,
		                                        0,
		                                        0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_waterProxyMaterial, v17, v18, v19, v22);
		}
		
		static DepthOnlyPassConstructor() {} // 0x0000000184B70010-0x0000000184B70140
		// DepthOnlyPassConstructor()
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  struct DepthOnlyPassConstructor_c__Class *v5; // r9
		  Object *v6; // rdi
		  RenderFunc_1_System_Object_ *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MonitorData *v10; // rbx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  Object *v14; // rdi
		  RenderFunc_1_System_Object_ *v15; // rax
		  RenderFunc_1_System_Object_ *v16; // rbx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v20);
		  v5 = TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c);
		    v5 = TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c;
		  }
		  v6 = (Object *)v5->static_fields->__9;
		  v7 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
		  v10 = (MonitorData *)v7;
		  if ( !v7
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v7,
		          v6,
		          MethodInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c::__cctor_b__16_0,
		          0LL),
		        v11 = (Type *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields,
		        v11->monitor = v10,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields->s_depthOnlyPassFunc,
		          v11,
		          v12,
		          v13,
		          v21),
		        v14 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c->static_fields->__9,
		        v15 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOnlyPassConstructor::VSMPassData>),
		        (v16 = v15) == 0LL) )
		  {
		    sub_1800D8260(v9, v8);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v15,
		    v14,
		    MethodInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor::__c::__cctor_b__16_1,
		    0LL);
		  v17 = (Type *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields;
		  v17->fields._impl.value = v16;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields->s_vsmPassFunc,
		    v17,
		    v18,
		    v19,
		    v22);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B9BBE8-0x0000000189B9BC3C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DepthOnlyPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3083, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3083, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B9BB94-0x0000000189B9BBE8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DepthOnlyPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3084, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3084, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B9AC60-0x0000000189B9BB40
		// Void ConstructPass(DepthOnlyPassConstructor+PassInput ByRef, DepthOnlyPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::ConstructPass(
		        DepthOnlyPassConstructor *this,
		        DepthOnlyPassConstructor_PassInput *input,
		        DepthOnlyPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v6; // r14
		  DepthOnlyPassConstructor_PassInput *v8; // r12
		  Object *v9; // r15
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  int v12; // eax
		  HGCamera *v13; // r13
		  int v14; // ecx
		  __int64 v15; // rdx
		  _OWORD *v16; // rax
		  Matrix4x4 *v17; // rcx
		  __int64 v18; // rdx
		  ProfilingSampler *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // rcx
		  Object *v23; // rdx
		  int v24; // eax
		  unsigned __int64 v25; // rdx
		  unsigned __int64 v26; // r8
		  char v27; // dl
		  signed __int64 v28; // rtt
		  Object *v29; // rdx
		  MonitorData *monitor; // rcx
		  unsigned __int64 v31; // rdx
		  unsigned __int64 v32; // r8
		  char v33; // dl
		  signed __int64 v34; // rtt
		  Object *v35; // rdx
		  Object__Class *klass; // rcx
		  unsigned __int64 v37; // rdx
		  unsigned __int64 v38; // r8
		  signed __int64 v39; // rtt
		  Object *v40; // rax
		  DepthOnlyPassConstructor__StaticFields *static_fields; // rcx
		  __int128 v42; // xmm7
		  __int128 v43; // xmm8
		  __int128 v44; // xmm9
		  __int128 v45; // xmm10
		  int v46; // ebx
		  Void *m_Buffer; // r14
		  __int64 v48; // rdx
		  __int64 v49; // r9
		  DepthOnlyPassConstructor__StaticFields *v50; // rcx
		  __int64 v51; // rdx
		  HGGraphicsFeatureSwitch *customDepthPass; // rcx
		  bool enabledForCPUCommands; // r15
		  Object *v54; // rbx
		  bool enableECSRenderer; // al
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  Camera *v58; // rcx
		  int32_t i; // ebx
		  __m128i v60; // xmm6
		  CullingResults v61; // xmm6
		  int32_t v62; // ebx
		  __int64 v63; // rdx
		  HGRenderGraphPass *InvalidHandle; // rax
		  RendererListHandle *v65; // rbx
		  RendererListHandle v66; // rax
		  RendererListHandle v67; // rdx
		  RendererListHandle v68; // rcx
		  Camera *v69; // rbx
		  __int64 v70; // rdx
		  uint64_t SceneCullingMaskFromCamera; // r14
		  Camera *v72; // rcx
		  int32_t cullingMask; // ebx
		  uint32_t COMPOUND_CHARACTER_LAYER_MASK; // r9d
		  uint32_t v75; // r14d
		  __int64 v76; // rdx
		  __int64 v77; // rcx
		  Object *v78; // rbx
		  uint32_t RendererList; // eax
		  Object *v80; // r14
		  Camera *v81; // r15
		  HGRenderGraphPass *sceneRTSize_k__BackingField; // rbx
		  void *m_Ptr; // rax
		  uint32_t v84; // eax
		  __int64 v85; // rdx
		  __int64 v86; // rcx
		  Object *v87; // rbx
		  HGRenderGraphPass *v88; // rax
		  void *v89; // rdx
		  uint32_t v90; // eax
		  __int64 v91; // rdx
		  __int64 v92; // rcx
		  __int64 v93; // rdx
		  signed __int64 v94; // rcx
		  Object *v95; // rdx
		  unsigned int v96; // edx
		  unsigned __int64 v97; // r8
		  signed __int64 v98; // rtt
		  Object *v99; // rax
		  Object *v100; // rax
		  Object *v101; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v103; // rdx
		  __int64 v104; // rcx
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-C08h]
		  Object *v106; // [rsp+60h] [rbp-BC8h] BYREF
		  __int32 v107; // [rsp+68h] [rbp-BC0h]
		  int v108; // [rsp+6Ch] [rbp-BBCh]
		  HGRenderGraphBuilder inputa; // [rsp+70h] [rbp-BB8h] BYREF
		  __int64 v110; // [rsp+90h] [rbp-B98h]
		  __int64 v111; // [rsp+98h] [rbp-B90h]
		  _QWORD v112[2]; // [rsp+A8h] [rbp-B80h] BYREF
		  HGRenderGraphBuilder v113; // [rsp+B8h] [rbp-B70h] BYREF
		  Vector3 viewPosition; // [rsp+E0h] [rbp-B48h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v115; // [rsp+F0h] [rbp-B38h] BYREF
		  Void customPayload[16]; // [rsp+100h] [rbp-B28h] BYREF
		  __m128i v117; // [rsp+110h] [rbp-B18h]
		  NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v118; // [rsp+120h] [rbp-B08h] BYREF
		  Matrix4x4 viewProj; // [rsp+130h] [rbp-AF8h] BYREF
		  Il2CppExceptionWrapper *v120; // [rsp+170h] [rbp-AB8h] BYREF
		  Matrix4x4 v121; // [rsp+180h] [rbp-AA8h] BYREF
		  Object v122; // [rsp+1C0h] [rbp-A68h]
		  Object v123; // [rsp+1D0h] [rbp-A58h]
		  Object v124; // [rsp+1E0h] [rbp-A48h]
		  Object v125; // [rsp+1F0h] [rbp-A38h]
		  Object v126; // [rsp+200h] [rbp-A28h]
		  TextureHandle v127[2]; // [rsp+210h] [rbp-A18h] BYREF
		  Object__Class *v128; // [rsp+230h] [rbp-9F8h]
		  __int128 v129; // [rsp+238h] [rbp-9F0h]
		  MonitorData *v130; // [rsp+248h] [rbp-9E0h]
		  Object v131; // [rsp+250h] [rbp-9D8h]
		  Object v132; // [rsp+260h] [rbp-9C8h]
		  Object v133; // [rsp+270h] [rbp-9B8h]
		  Object v134; // [rsp+280h] [rbp-9A8h]
		  Object v135; // [rsp+290h] [rbp-998h]
		  Object v136; // [rsp+2A0h] [rbp-988h]
		  int v137; // [rsp+2B0h] [rbp-978h]
		  int v138; // [rsp+2B4h] [rbp-974h]
		  unsigned __int8 v139; // [rsp+2B8h] [rbp-970h]
		  bool value; // [rsp+2B9h] [rbp-96Fh]
		  Matrix4x4 v141; // [rsp+2C0h] [rbp-968h] BYREF
		  Matrix4x4 v142; // [rsp+300h] [rbp-928h] BYREF
		  CullingResults v143; // [rsp+340h] [rbp-8E8h] BYREF
		  TextureHandle v144; // [rsp+350h] [rbp-8D8h] BYREF
		  TextureHandle v145; // [rsp+360h] [rbp-8C8h] BYREF
		  RendererListDesc desc; // [rsp+370h] [rbp-8B8h] BYREF
		  RendererListDesc v147; // [rsp+450h] [rbp-7D8h] BYREF
		  ScriptableCullingParameters cullingParameters; // [rsp+530h] [rbp-6F8h] BYREF
		
		  v6 = (Object *)renderGraph;
		  v8 = input;
		  v9 = (Object *)this;
		  memset(&v113, 0, sizeof(v113));
		  v106 = 0LL;
		  v115 = 0LL;
		  sub_18033B9D0(&cullingParameters, 0LL, 1592LL);
		  v111 = 0LL;
		  *(_OWORD *)customPayload = 0LL;
		  *(_OWORD *)&inputa.m_RenderPass = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3085, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3085, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v104, v103);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1142(Patch, v9, v8, output, v6, (Object *)camera, 0LL);
		  }
		  else
		  {
		    if ( !v8->customDepthOnlyRequestManger )
		      sub_1800D8260(v11, v10);
		    v117 = *(__m128i *)HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RetrieveAllSystemRenderData(
		                         &v118,
		                         v8->customDepthOnlyRequestManger,
		                         (HGRenderGraph *)v6,
		                         0LL);
		    v12 = 0;
		    v13 = camera;
		    v14 = _mm_cvtsi128_si32(_mm_srli_si128(v117, 8));
		    v107 = v14;
		    v15 = v117.m128i_i64[0];
		    v110 = v117.m128i_i64[0];
		    while ( 1 )
		    {
		      v108 = v12;
		      if ( v12 >= v14 )
		        break;
		      v16 = (_OWORD *)(v15 + 320LL * v12);
		      v17 = &v121;
		      v18 = 2LL;
		      do
		      {
		        *(_OWORD *)&v17->m00 = *v16;
		        *(_OWORD *)&v17->m01 = v16[1];
		        *(_OWORD *)&v17->m02 = v16[2];
		        *(_OWORD *)&v17->m03 = v16[3];
		        *(_OWORD *)&v17[1].m00 = v16[4];
		        *(_OWORD *)&v17[1].m01 = v16[5];
		        *(_OWORD *)&v17[1].m02 = v16[6];
		        v17 += 2;
		        *(_OWORD *)&v17[-1].m03 = v16[7];
		        v16 += 8;
		        --v18;
		      }
		      while ( v18 );
		      *(_OWORD *)&v17->m00 = *v16;
		      *(_OWORD *)&v17->m01 = v16[1];
		      *(_OWORD *)&v17->m02 = v16[2];
		      *(_OWORD *)&v17->m03 = v16[3];
		      v19 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x94u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		        sub_1800D8260(v21, v20);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &inputa,
		        (HGRenderGraph *)v6,
		        (String *)"Custom Depth Only Pass",
		        &v106,
		        v19,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
		      v113 = inputa;
		      v112[0] = 0LL;
		      v112[1] = &v113;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v113, 0, 0LL);
		        v23 = v106;
		        if ( !v106 )
		          sub_1800D8250(v22, 0LL);
		        v106[20].monitor = (MonitorData *)v13;
		        v24 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v25 = ((unsigned __int64)&v23[20].monitor >> 12) & 0x1FFFFF;
		          v26 = v25 >> 6;
		          v27 = v25 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v26 + 36190]);
		          do
		            v28 = qword_18F0BCBA0[v26 + 36190];
		          while ( v28 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v26 + 36190], v28 | (1LL << v27), v28) );
		          v24 = dword_18F35FD08;
		        }
		        v29 = v106;
		        monitor = v9[1].monitor;
		        if ( !v106 )
		          sub_1800D8250(monitor, 0LL);
		        v106[19].monitor = monitor;
		        if ( v24 )
		        {
		          v31 = ((unsigned __int64)&v29[19].monitor >> 12) & 0x1FFFFF;
		          v32 = v31 >> 6;
		          v33 = v31 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v32 + 36190]);
		          do
		            v34 = qword_18F0BCBA0[v32 + 36190];
		          while ( v34 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v32 + 36190], v34 | (1LL << v33), v34) );
		          v24 = dword_18F35FD08;
		        }
		        v35 = v106;
		        klass = v9[2].klass;
		        if ( !v106 )
		          sub_1800D8250(klass, 0LL);
		        v106[20].klass = klass;
		        if ( v24 )
		        {
		          v37 = ((unsigned __int64)&v35[20] >> 12) & 0x1FFFFF;
		          v38 = v37 >> 6;
		          v35 = (Object *)(v37 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		          do
		          {
		            klass = (Object__Class *)(qword_18F0BCBA0[v38 + 36190] | (1LL << (char)v35));
		            v39 = qword_18F0BCBA0[v38 + 36190];
		          }
		          while ( v39 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v38 + 36190], (signed __int64)klass, v39) );
		        }
		        v40 = v106;
		        if ( !v106 )
		          sub_1800D8250(klass, v35);
		        v106[1] = v122;
		        v40[2] = v123;
		        v40[3] = v124;
		        v40[4] = v125;
		        Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		          &v115,
		          6,
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		        static_fields = TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields;
		        v42 = *(_OWORD *)&v121.m00;
		        viewProj = v121;
		        v43 = *(_OWORD *)&v121.m01;
		        v44 = *(_OWORD *)&v121.m02;
		        v45 = *(_OWORD *)&v121.m03;
		        UnityEngine::GeometryUtility::CalculateFrustumPlanes(&viewProj, static_fields->s_tempPlanes, 0LL);
		        v46 = 0;
		        m_Buffer = v115.m_Buffer;
		        while ( v46 < 6 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		          v50 = TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields;
		          if ( !v50->s_tempPlanes )
		            sub_1800D8250(v50, v48);
		          sub_180002990(v50->s_tempPlanes, &v118, v46, v49);
		          *(NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *)&m_Buffer[16 * v46++] = v118;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        customDepthPass = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->customDepthPass;
		        if ( !customDepthPass )
		          sub_1800D8250(0LL, v51);
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  customDepthPass,
		                                  0LL);
		        v54 = v106;
		        enableECSRenderer = UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL);
		        v57 = 0LL;
		        if ( !enableECSRenderer )
		          v57 = v139;
		        if ( !v54 )
		          sub_1800D8250(v57, v56);
		        LOBYTE(v54[18].monitor) = (_DWORD)v57 != 0;
		        if ( !v106 )
		          sub_1800D8250(v57, v56);
		        if ( LOBYTE(v106[18].monitor) )
		        {
		          if ( !v13 )
		            sub_1800D8250(v57, v56);
		          v58 = v13->fields.camera;
		          if ( !v58 )
		            sub_1800D8250(0LL, v56);
		          UnityEngine::Camera::GetCullingParameters_Internal(v58, 0, &cullingParameters, 1592, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v42;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v43;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v44;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v45;
		          UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, value, 0LL);
		          cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
		          for ( i = 0; i < 6; ++i )
		          {
		            v60 = _mm_loadu_si128((const __m128i *)&m_Buffer[16 * i]);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		            *(__m128i *)&inputa.m_RenderPass = v60;
		            UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
		              &cullingParameters,
		              i,
		              (Plane *)&inputa,
		              0LL);
		          }
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v61 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(&v143, &v8->srpContext, &cullingParameters, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		          v62 = UnityEngine::Shader::TagToID(
		                  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		                  0LL);
		          if ( enabledForCPUCommands )
		          {
		            sub_18033B9D0(&v147, 0LL, 224LL);
		            *(CullingResults *)&inputa.m_RenderPass = v61;
		            UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
		              &v147,
		              (ShaderTagId)v62,
		              (CullingResults *)&inputa,
		              v13->fields.camera,
		              0LL);
		            desc = v147;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		            desc.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque;
		            desc.sortingCriteria = 59;
		            desc.rendererConfiguration = 6144;
		            if ( !renderGraph )
		              sub_1800D8250(0LL, v63);
		            InvalidHandle = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                                   renderGraph,
		                                                   &desc,
		                                                   0LL);
		          }
		          else
		          {
		            InvalidHandle = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		          }
		          inputa.m_RenderPass = InvalidHandle;
		          v65 = (RendererListHandle *)v106;
		          v66 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                  &v113,
		                  (RendererListHandle *)&inputa,
		                  0LL);
		          if ( !v65 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v68, v67);
		          v65[10] = v66;
		        }
		        else if ( !v13 )
		        {
		          sub_1800D8250(v57, v56);
		        }
		        v69 = v13->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v69, 0LL);
		        v72 = v13->fields.camera;
		        if ( !v72 )
		          sub_1800D8250(0LL, v70);
		        cullingMask = UnityEngine::Camera::get_cullingMask(v72, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		        COMPOUND_CHARACTER_LAYER_MASK = TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->COMPOUND_CHARACTER_LAYER_MASK;
		        *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&inputa.m_RenderPass = v115;
		        v75 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
		                (NativeArray_1_UnityEngine_Plane_ *)&inputa,
		                0,
		                SceneCullingMaskFromCamera,
		                cullingMask & ~COMPOUND_CHARACTER_LAYER_MASK,
		                0x4000002u,
		                0x4000002u,
		                &v13->fields.lodCrossFadeConfig,
		                0.0,
		                CameraType__Enum_Shadow,
		                0LL);
		        UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		        v78 = v106;
		        if ( enabledForCPUCommands )
		        {
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          LOWORD(globalKeywords) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           v75,
		                           HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow,
		                           HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow,
		                           HGShaderLightMode__Enum_ShadowCaster,
		                           globalKeywords,
		                           v8->srpContext.m_Ptr,
		                           0,
		                           0,
		                           0xFFFFFFFF,
		                           0,
		                           0,
		                           0LL);
		        }
		        else
		        {
		          RendererList = -1;
		        }
		        if ( !v78 )
		          sub_1800D8250(v77, v76);
		        LODWORD(v78[5].monitor) = RendererList;
		        v80 = v106;
		        v81 = v13->fields.camera;
		        sceneRTSize_k__BackingField = (HGRenderGraphPass *)v13->fields._sceneRTSize_k__BackingField;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        m_Ptr = v8->srpContext.m_Ptr;
		        *(_OWORD *)&viewProj.m00 = v42;
		        *(_OWORD *)&viewProj.m01 = v43;
		        *(_OWORD *)&viewProj.m02 = v44;
		        *(_OWORD *)&viewProj.m03 = v45;
		        inputa.m_RenderPass = sceneRTSize_k__BackingField;
		        v84 = UnityEngine::HyperGryph::HGTerrainManager::CullTerrain_Injected(
		                v81,
		                (Vector2Int *)&inputa,
		                &viewProj,
		                900.0,
		                0,
		                m_Ptr,
		                0LL);
		        if ( !v80 )
		          sub_1800D8250(v86, v85);
		        HIDWORD(v80[5].monitor) = v84;
		        v87 = v106;
		        v88 = (HGRenderGraphPass *)v13->fields._sceneRTSize_k__BackingField;
		        v89 = v8->srpContext.m_Ptr;
		        *(_OWORD *)&v141.m00 = v42;
		        *(_OWORD *)&v141.m01 = v43;
		        *(_OWORD *)&v141.m02 = v44;
		        *(_OWORD *)&v141.m03 = v45;
		        inputa.m_RenderPass = v88;
		        v90 = UnityEngine::HyperGryph::HGEditorTerrainManager::CullTerrain_Injected(
		                v13->fields.camera,
		                (Vector2Int *)&inputa,
		                &v141,
		                900.0,
		                0,
		                v89,
		                0LL);
		        if ( !v87 )
		          sub_1800D8250(v92, v91);
		        LODWORD(v87[6].klass) = v90;
		        if ( !v106 )
		          sub_1800D8250(v92, v91);
		        v111 = 0LL;
		        *(_QWORD *)&viewPosition.x = 0LL;
		        viewPosition.z = 0.0;
		        *(_OWORD *)&v142.m00 = v42;
		        *(_OWORD *)&v142.m01 = v43;
		        *(_OWORD *)&v142.m02 = v44;
		        *(_OWORD *)&v142.m03 = v45;
		        UnityEngine::HyperGryph::HGWaterRender::CullWaterProxy_Injected(
		          v13->fields.cullingViewHandle,
		          &v142,
		          3u,
		          0,
		          (uint32_t *)&v106[18].monitor + 1,
		          (uint32_t *)&v106[19],
		          0,
		          &viewPosition,
		          0LL);
		        if ( !v106 )
		          sub_1800D8250(v94, v93);
		        *(TextureHandle *)((char *)v106 + 100) = v127[0];
		        if ( !v106 )
		          sub_1800D8250(v94, v93);
		        *(Object *)((char *)v106 + 116) = v126;
		        v95 = v106;
		        v9 = (Object *)this;
		        if ( !v106 )
		          sub_1800D8250(v94, 0LL);
		        v106[8].monitor = (MonitorData *)this->fields.m_clearDepth;
		        if ( dword_18F35FD08 )
		        {
		          v96 = ((unsigned __int64)&v95[8].monitor >> 12) & 0x1FFFFF;
		          v97 = (unsigned __int64)v96 >> 6;
		          v95 = (Object *)(v96 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v97 + 36190]);
		          do
		          {
		            v94 = qword_18F0BCBA0[v97 + 36190] | (1LL << (char)v95);
		            v98 = qword_18F0BCBA0[v97 + 36190];
		          }
		          while ( v98 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v97 + 36190], v94, v98) );
		        }
		        v99 = v106;
		        if ( !v106 )
		          sub_1800D8250(v94, v95);
		        v106[9] = (Object)v127[1];
		        v99[10].klass = v128;
		        v100 = v106;
		        if ( !v106 )
		          sub_1800D8250(v94, v95);
		        *(_OWORD *)&v106[10].monitor = v129;
		        v100[11].monitor = v130;
		        if ( !v106 )
		          sub_1800D8250(0LL, v95);
		        LODWORD(v106[18].klass) = v137;
		        v101 = v106;
		        if ( !v106 )
		          sub_1800D8250(0LL, v95);
		        HIDWORD(v106[18].klass) = v138;
		        if ( !v106 )
		          sub_1800D8250(v101, v95);
		        v106[12] = v131;
		        if ( !v106 )
		          sub_1800D8250(v101, v95);
		        v106[13] = v132;
		        if ( !v106 )
		          sub_1800D8250(v101, v95);
		        v106[14] = v133;
		        if ( !v106 )
		          sub_1800D8250(v101, v95);
		        v106[15] = v134;
		        if ( !v106 )
		          sub_1800D8250(v101, v95);
		        v106[16] = v135;
		        if ( !v106 )
		          sub_1800D8250(v101, v95);
		        v106[17] = v136;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v144, &v113, v127, 0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          &v145,
		          &v113,
		          v127,
		          DepthAccess__Enum_Write,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          1.0,
		          0,
		          0,
		          0LL);
		        *(_OWORD *)&inputa.m_RenderPass = 0LL;
		        LODWORD(inputa.m_RenderPass) = 1065353216;
		        LODWORD(inputa.m_Resources) = 1065353216;
		        *(_OWORD *)customPayload = *(_OWORD *)&inputa.m_RenderPass;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v113,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor->static_fields->s_depthOnlyPassFunc,
		          0LL,
		          customPayload,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v120 )
		      {
		        v112[0] = v120->ex;
		        sub_180268AE0(v112);
		        v13 = camera;
		        v8 = input;
		        v14 = v117.m128i_i32[2];
		        v107 = v117.m128i_i32[2];
		        v15 = v117.m128i_i64[0];
		        v110 = v117.m128i_i64[0];
		        v9 = (Object *)this;
		        goto LABEL_72;
		      }
		      sub_180268AE0(v112);
		      v14 = v107;
		      v15 = v110;
		LABEL_72:
		      v12 = v108 + 1;
		      v6 = (Object *)renderGraph;
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B9BB40-0x0000000189B9BB94
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DepthOnlyPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3086, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3086, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80710-0x0000000184D80740
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DepthOnlyPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3087, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3087, 0LL);
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
