using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class FakePlanarReflectionPass : IPassConstructor // TypeDefIndex: 38258
	{
		// Fields
		private const string COLOR_TEXTURE_NAME = "Fake Planar Reflection Color texture"; // Metadata: 0x02303C01
		private const string COLOR_BLUR_TEXTURE_NAME = "Fake Planar Reflection Color Blur texture"; // Metadata: 0x02303C26
		private const string DEPTH_TEXTURE_NAME = "Fake Planar Reflection Depth texture"; // Metadata: 0x02303C50
		private BasicTransformConstants m_basicTransformConstants; // 0x10
		private ShaderVariablesGlobal m_shaderVariablesGlobal; // 0x530
		private RTHandle m_defaultRTHandle; // 0x11B0
		private TextureHandle m_planarReflectionTexture; // 0x11B8
		private TextureHandle m_planarReflectionDepthTexture; // 0x11C8
		private TextureHandle m_planarReflectionBlurTexture; // 0x11D8
		private MaterialPropertyBlock m_mpb; // 0x11E8
		private Material m_blurMaterial; // 0x11F0
		private static readonly RenderFunc<PassData> s_DepthPrepassRenderFunc; // 0x00
		private static readonly RenderFunc<PassData> s_RenderFunc; // 0x08
		private static readonly RenderFunc<PassData> s_BlurRenderFunc; // 0x10
	
		// Properties
		public TextureHandle planarReflectionTexture { get => default; } // 0x0000000189BA89EC-0x0000000189BA8A54 
		// TextureHandle get_planarReflectionTexture()
		TextureHandle *HG::Rendering::Runtime::FakePlanarReflectionPass::get_planarReflectionTexture(
		        TextureHandle *__return_ptr retstr,
		        FakePlanarReflectionPass *this,
		        MethodInfo *method)
		{
		  TextureHandle v5; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3120, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3120, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v5 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = *(TextureHandle *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03;
		  }
		  result = retstr;
		  *retstr = v5;
		  return result;
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38253
		{
			// Fields
			public bool characterOutlineEnable; // 0x00
			public uint screenCullingLayerMask; // 0x04
			public float screenCullingRatio; // 0x08
			public float screenCullingRatioDistance; // 0x0C
			public PerObjectData bakedLightingConfig; // 0x10
			public CullingResults cullingResults; // 0x18
			public ShadowResult shadowResult; // 0x28
			public HGRenderPipeline hgrp; // 0x68
			public ScriptableRenderContext renderContext; // 0x70
			public uint characterPrePassECSList; // 0x78
			public uint forwardOpaquePreZECSList; // 0x7C
			public uint forwardOpaqueECSList; // 0x80
			public uint forwardOpaqueEqualECSList; // 0x84
			public uint characterOpaqueECSList; // 0x88
			public uint characterOutlineOpaquePreZECSList; // 0x8C
			public uint characterOutlineOpaqueECSList; // 0x90
			public uint characterOutlineOpaqueEqualECSList; // 0x94
			public TextureHandle sceneColorTexture; // 0x98
			public TextureHandle sceneDepthTexture; // 0xA8
		}
	
		internal struct PassOutput // TypeDefIndex: 38254
		{
		}
	
		public struct BlurData // TypeDefIndex: 38255
		{
			// Fields
			public Vector4 blurSize; // 0x00
			public Vector4 param0; // 0x10
		}
	
		private class PassData // TypeDefIndex: 38256
		{
			// Fields
			public int blurPass; // 0x10
			public float blurRadius; // 0x14
			public Vector2Int renderSize; // 0x18
			public BasicTransformConstants basicTransformConstants; // 0x20
			public ShaderVariablesGlobal shaderVariablesGlobal; // 0x540
			public RendererListHandle characterPrePassRendererList; // 0x11C0
			public RendererListHandle forwardOpaqueRenderList; // 0x11C8
			public RendererListHandle characterOutlineOpaqueRenderList; // 0x11D0
			public TextureHandle planarReflectionTexture; // 0x11D8
			public TextureHandle fakePlanarReflectionTexture; // 0x11E8
			public bool enableScreenSpaceShadowMask; // 0x11F8
			public uint characterPrePassECSList; // 0x11FC
			public uint forwardOpaquePreZECSList; // 0x1200
			public uint forwardOpaqueECSList; // 0x1204
			public uint forwardOpaqueEqualECSList; // 0x1208
			public uint characterOpaqueECSList; // 0x120C
			public uint characterOutlineOpaquePreZECSList; // 0x1210
			public uint characterOutlineOpaqueECSList; // 0x1214
			public uint characterOutlineOpaqueEqualECSList; // 0x1218
			public HGCamera hgCamera; // 0x1220
			public MaterialPropertyBlock mpb; // 0x1228
			public Material blurMaterial; // 0x1230
	
			// Constructors
			public PassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public FakePlanarReflectionPass() {} // Dummy constructor
		internal FakePlanarReflectionPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDAF20-0x0000000182EDB010
		// FakePlanarReflectionPass(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::FakePlanarReflectionPass::FakePlanarReflectionPass(
		        FakePlanarReflectionPass *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Texture *blackTexture; // rdi
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+50h] [rbp+28h]
		
		  blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RTHandles->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RTHandles);
		  *(_QWORD *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m22 = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                                                                                                 blackTexture,
		                                                                                                 0LL);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m22,
		    v8,
		    v9,
		    v10,
		    v21);
		  v13 = sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v13
		    || (*(_QWORD *)(v13 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL),
		        *(_QWORD *)&this[1].fields.m_basicTransformConstants._ReprojectionMatrix.m02 = v13,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._ReprojectionMatrix.m02,
		          v14,
		          v15,
		          v16,
		          v22),
		        !resources->defaultResources)
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		    sub_1800D8260(v12, v11);
		  }
		  *(_QWORD *)&this[1].fields.m_basicTransformConstants._ReprojectionMatrix.m22 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                                                   materialCollector,
		                                                                                   shaders->fields.blurPS,
		                                                                                   0,
		                                                                                   0LL);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields.m_basicTransformConstants._ReprojectionMatrix.m22,
		    v18,
		    v19,
		    v20,
		    v23);
		}
		
		static FakePlanarReflectionPass() {} // 0x0000000184B35530-0x0000000184B35690
		// FakePlanarReflectionPass()
		void HG::Rendering::Runtime::FakePlanarReflectionPass::cctor(MethodInfo *method)
		{
		  struct FakePlanarReflectionPass_c__Class *v1; // rax
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
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  RenderFunc_1_System_Object_ *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c::__cctor_b__29_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v22);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		  v12 = (MonitorData *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c::__cctor_b__29_1,
		          0LL),
		        v13 = (Type *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields,
		        v13->monitor = v12,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields->s_RenderFunc,
		          v13,
		          v14,
		          v15,
		          v23),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>),
		        (v18 = v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::FakePlanarReflectionPass::__c::__cctor_b__29_2,
		    0LL);
		  v19 = (Type *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields;
		  v19->fields._impl.value = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields->s_BlurRenderFunc,
		    v19,
		    v20,
		    v21,
		    v24);
		}
		
	
		// Methods
		internal void ConstructPass(ref PassInput input, ref PassOutput output, ref BasicTransformConstants basicTransformConstants, ref ShaderVariablesGlobal shaderVariablesGlobal, HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameters) {} // 0x0000000189BA5D44-0x0000000189BA8080
		// Void ConstructPass(FakePlanarReflectionPass+PassInput ByRef, FakePlanarReflectionPass+PassOutput ByRef, BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=5 #try_helpers=1
		void HG::Rendering::Runtime::FakePlanarReflectionPass::ConstructPass(
		        FakePlanarReflectionPass *this,
		        FakePlanarReflectionPass_PassInput *input,
		        FakePlanarReflectionPass_PassOutput *output,
		        BasicTransformConstants *basicTransformConstants,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  FakePlanarReflectionPass_PassInput *v11; // r13
		  FakePlanarReflectionPass *v12; // r12
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ProfilingSampler *v17; // rax
		  Component *camera; // rbx
		  __int64 v19; // rax
		  __int64 v20; // xmm9_8
		  float v21; // r15d
		  Vector3 *fakeReflectionPlanePos; // rax
		  Camera *v23; // xmm13_8
		  float y; // xmm7_4
		  float x; // xmm8_4
		  float v26; // xmm10_4
		  float v27; // xmm11_4
		  float v28; // xmm12_4
		  Vector3 *v29; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  float v32; // xmm6_4
		  Transform *transform; // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  Vector3 *position; // rax
		  __int64 v37; // xmm6_8
		  float z; // r15d
		  Transform *v39; // rax
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  Vector3 *v42; // rax
		  __int64 v43; // xmm8_8
		  Transform *v44; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  Vector3 *forward; // rax
		  float v48; // xmm2_4
		  __m128 y_low; // xmm14
		  __m128 v50; // xmm1
		  __m128 x_low; // xmm13
		  __m128 v52; // xmm0
		  Vector3 *v53; // rax
		  float v54; // xmm12_4
		  float v55; // xmm11_4
		  __m128 v56; // xmm10
		  __m128 v57; // xmm7
		  Transform *v58; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  Vector3 *up; // rax
		  float v62; // xmm15_4
		  Vector3 *v63; // rax
		  float v64; // xmm2_4
		  __m128 v65; // xmm1
		  __m128 v66; // xmm0
		  Quaternion v67; // xmm7
		  Transform *v68; // rax
		  __int64 v69; // rdx
		  __int64 v70; // rcx
		  Transform *v71; // rax
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  Matrix4x4 *v74; // rax
		  Transform *v75; // rax
		  __int64 v76; // rdx
		  __int64 v77; // rcx
		  Transform *v78; // rax
		  __int64 v79; // rdx
		  __int64 v80; // rcx
		  MonitorData *sceneRTSize_k__BackingField; // rbx
		  ProfilingSampler *v82; // rax
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  __int64 v85; // rdx
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  Object *v88; // rdx
		  unsigned int v89; // edx
		  unsigned __int64 v90; // r8
		  char v91; // dl
		  signed __int64 v92; // rtt
		  CullingResults cullingResults; // xmm8
		  HGShaderPassNames__StaticFields *static_fields; // rdi
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // esi
		  RendererListDesc *OpaqueRendererListDesc; // rax
		  HGRenderGraph *v99; // rdi
		  RendererListHandle v100; // rax
		  RendererListHandle v101; // rdx
		  __int64 characterPrePassECSList; // rcx
		  __int64 forwardOpaquePreZECSList; // rcx
		  unsigned __int64 v104; // r8
		  signed __int64 v105; // rtt
		  ProfilingSampler *v106; // rax
		  __int64 v107; // rdx
		  __int64 v108; // rdx
		  __int64 v109; // rcx
		  Object *v110; // rdx
		  HGCamera *v111; // rdi
		  unsigned int v112; // edx
		  unsigned __int64 v113; // r8
		  char v114; // dl
		  signed __int64 v115; // rtt
		  RendererListHandle *v116; // rsi
		  PerObjectData__Enum bakedLightingConfig; // ecx
		  float v118; // xmm2_4
		  float v119; // xmm1_4
		  uint32_t v120; // eax
		  RendererListDesc *v121; // rax
		  RendererListHandle v122; // rax
		  RendererListHandle v123; // rdx
		  RendererListHandle v124; // rcx
		  RendererListHandle *v125; // rsi
		  RendererListDesc *v126; // rax
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle v128; // rdx
		  RendererListHandle v129; // rcx
		  __int64 forwardOpaqueECSList; // rcx
		  __int64 forwardOpaqueEqualECSList; // rcx
		  __int64 characterOpaqueECSList; // rcx
		  __int64 characterOutlineOpaquePreZECSList; // rcx
		  __int64 characterOutlineOpaqueECSList; // rcx
		  __int64 characterOutlineOpaqueEqualECSList; // rcx
		  Object *v136; // rsi
		  HGRenderPipeline *hgrp; // rax
		  HGSettingParameters *settingParameters_k__BackingField; // rcx
		  bool IsScreenSpaceShadowMaskEnabled; // al
		  __int64 v140; // rdx
		  __int64 v141; // rcx
		  __int128 v142; // xmm1
		  __int128 v143; // xmm2
		  __int128 v144; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v146; // r8
		  signed __int64 v147; // rtt
		  HGRenderGraph *v148; // rsi
		  __int128 v149; // xmm6
		  __int128 v150; // xmm7
		  __int128 v151; // xmm1
		  __int128 v152; // xmm2
		  __int128 v153; // xmm3
		  Color v154; // xmm4
		  unsigned __int64 v155; // r8
		  signed __int64 v156; // rtt
		  ProfilingSampler *v157; // rax
		  __int64 v158; // rdx
		  __int64 v159; // rcx
		  Object *v160; // rsi
		  __int64 v161; // rdx
		  __int64 v162; // rcx
		  float fakePlanarReflectionBlur; // xmm0_4
		  __int64 v164; // rdx
		  __int64 v165; // rdx
		  __int64 v166; // rcx
		  Object *v167; // rdx
		  int v168; // eax
		  unsigned __int64 v169; // rdx
		  unsigned __int64 v170; // r8
		  char v171; // dl
		  signed __int64 v172; // rtt
		  Object *v173; // rdx
		  Object__Class *v174; // rcx
		  unsigned __int64 v175; // rdx
		  unsigned __int64 v176; // r8
		  char v177; // dl
		  signed __int64 v178; // rtt
		  Object *v179; // rsi
		  __int64 v180; // rdx
		  __int64 v181; // rcx
		  TextureHandle v182; // xmm0
		  Object *v183; // rsi
		  __int64 v184; // rdx
		  __int64 v185; // rcx
		  TextureHandle v186; // xmm0
		  ProfilingSampler *v187; // rax
		  __int64 v188; // rdx
		  __int64 v189; // rcx
		  Object *v190; // rsi
		  __int64 v191; // rdx
		  __int64 v192; // rcx
		  float v193; // xmm0_4
		  __int64 v194; // rdx
		  __int64 v195; // rdx
		  __int64 v196; // rcx
		  Object *v197; // rdx
		  int v198; // eax
		  unsigned __int64 v199; // rdx
		  unsigned __int64 v200; // r8
		  char v201; // dl
		  signed __int64 v202; // rtt
		  Object *v203; // rdx
		  Object__Class *v204; // rcx
		  unsigned __int64 v205; // rdx
		  unsigned __int64 v206; // r8
		  signed __int64 v207; // rtt
		  Object *v208; // rbx
		  __int64 v209; // rdx
		  __int64 v210; // rcx
		  TextureHandle v211; // xmm0
		  __int64 v212; // rdx
		  __int64 v213; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Vector3 value; // [rsp+70h] [rbp-1218h] BYREF
		  bool screenSpaceShadowMaskEnabled; // [rsp+80h] [rbp-1208h]
		  Vector4 v217; // [rsp+90h] [rbp-11F8h] BYREF
		  Object *v218; // [rsp+A0h] [rbp-11E8h] BYREF
		  Camera *v219; // [rsp+A8h] [rbp-11E0h]
		  Vector3 v220; // [rsp+B0h] [rbp-11D8h] BYREF
		  HGRenderGraphBuilder v221; // [rsp+C0h] [rbp-11C8h] BYREF
		  int32_t height[2]; // [rsp+E0h] [rbp-11A8h]
		  Object *v223; // [rsp+E8h] [rbp-11A0h] BYREF
		  Object *v224; // [rsp+F0h] [rbp-1198h] BYREF
		  Vector3 v225; // [rsp+100h] [rbp-1188h] BYREF
		  Vector3 inputa; // [rsp+110h] [rbp-1178h] BYREF
		  Object *v227; // [rsp+120h] [rbp-1168h] BYREF
		  Vector3 v228; // [rsp+130h] [rbp-1158h] BYREF
		  RendererListHandle *v229; // [rsp+140h] [rbp-1148h]
		  Quaternion v230; // [rsp+150h] [rbp-1138h] BYREF
		  TextureDesc v231; // [rsp+160h] [rbp-1128h] BYREF
		  HGRenderGraphBuilder v232; // [rsp+1C0h] [rbp-10C8h] BYREF
		  _QWORD v233[2]; // [rsp+1E0h] [rbp-10A8h] BYREF
		  HGRenderGraphBuilder v234; // [rsp+1F0h] [rbp-1098h] BYREF
		  HGRenderGraphBuilder v235; // [rsp+210h] [rbp-1078h] BYREF
		  HGRenderGraphBuilder v236; // [rsp+230h] [rbp-1058h] BYREF
		  TextureDesc v237; // [rsp+250h] [rbp-1038h] BYREF
		  HGRenderGraphProfilingScope v238; // [rsp+2B0h] [rbp-FD8h] BYREF
		  Il2CppExceptionWrapper *v239; // [rsp+2C8h] [rbp-FC0h] BYREF
		  Il2CppExceptionWrapper *v240; // [rsp+2D0h] [rbp-FB8h] BYREF
		  Il2CppExceptionWrapper *v241; // [rsp+2D8h] [rbp-FB0h] BYREF
		  Il2CppExceptionWrapper *v242; // [rsp+2E8h] [rbp-FA0h] BYREF
		  Matrix4x4 v243; // [rsp+2F0h] [rbp-F98h] BYREF
		  TextureDesc v244; // [rsp+330h] [rbp-F58h] BYREF
		  TextureDesc v245; // [rsp+390h] [rbp-EF8h] BYREF
		  TextureDesc v246; // [rsp+3F0h] [rbp-E98h] BYREF
		  RendererListDesc desc; // [rsp+450h] [rbp-E38h] BYREF
		  RendererListDesc v248[14]; // [rsp+530h] [rbp-D58h] BYREF
		
		  v11 = input;
		  v12 = this;
		  memset(&v238, 0, sizeof(v238));
		  memset(&v236, 0, sizeof(v236));
		  v227 = 0LL;
		  sub_18033B9D0(&v244, 0LL, 96LL);
		  sub_18033B9D0(&v231, 0LL, 96LL);
		  memset(&v232, 0, sizeof(v232));
		  v218 = 0LL;
		  sub_18033B9D0(&v245, 0LL, 96LL);
		  sub_18033B9D0(&v246, 0LL, 96LL);
		  memset(&v234, 0, sizeof(v234));
		  v223 = 0LL;
		  memset(&v235, 0, sizeof(v235));
		  v224 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3121, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3121, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v213, v212);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1154(
		      Patch,
		      (Object *)v12,
		      v11,
		      output,
		      basicTransformConstants,
		      shaderVariablesGlobal,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      (Object *)settingParameters,
		      0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      sub_1800D8260(v14, v13);
		    if ( !HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(hgCamera, 0LL) )
		      goto LABEL_105;
		    if ( !settingParameters )
		      sub_1800D8260(v16, v15);
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParameters->fields._fakePlanarReflectionEnable_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      v17 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x8Au,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		        &v238,
		        renderGraph,
		        v17,
		        0LL);
		      v233[0] = 0LL;
		      v233[1] = &v238;
		      camera = (Component *)hgCamera->fields.camera;
		      v220 = *HG::Rendering::Runtime::HGCamera::get_fakeReflectionProbeNormal(&value, hgCamera, 0LL);
		      v19 = sub_182FAE2B0(&value, &v220);
		      v20 = *(_QWORD *)v19;
		      *(_QWORD *)&v220.x = *(_QWORD *)v19;
		      height[0] = *(_DWORD *)(v19 + 8);
		      v21 = *(float *)height;
		      fakeReflectionPlanePos = HG::Rendering::Runtime::HGCamera::get_fakeReflectionPlanePos(&value, hgCamera, 0LL);
		      v23 = *(Camera **)&fakeReflectionPlanePos->x;
		      v219 = *(Camera **)&fakeReflectionPlanePos->x;
		      *(float *)&v229 = fakeReflectionPlanePos->z;
		      y = v220.y;
		      x = v220.x;
		      v26 = (float)(v21 * 0.0) + (float)((float)(v220.y * 0.0) + v220.x);
		      v27 = (float)(v21 * 0.0) + (float)(v220.y + (float)(v220.x * 0.0));
		      v28 = v21 + (float)((float)(v220.y * 0.0) + (float)(v220.x * 0.0));
		      v29 = HG::Rendering::Runtime::HGCamera::get_fakeReflectionPlanePos(&value, hgCamera, 0LL);
		      *(_QWORD *)&v220.x = *(_QWORD *)&v29->x;
		      v32 = (float)(v21 * v29->z) + (float)((float)(y * v220.y) + (float)(x * v220.x));
		      v217.x = v26;
		      v217.y = v27;
		      v217.z = v28;
		      v217.w = -v32;
		      if ( !camera )
		        sub_1800D8250(v31, v30);
		      transform = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !transform )
		        sub_1800D8250(v35, v34);
		      position = UnityEngine::Transform::get_position(&value, transform, 0LL);
		      v37 = *(_QWORD *)&position->x;
		      *(_QWORD *)&v225.x = *(_QWORD *)&position->x;
		      z = position->z;
		      v39 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v39 )
		        sub_1800D8250(v41, v40);
		      *(__m128i *)&v221.m_RenderPass = _mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_rotation(
		                                                                          (Quaternion *)&v221,
		                                                                          v39,
		                                                                          0LL));
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		      *(_QWORD *)&v220.x = v23;
		      LODWORD(v220.z) = (_DWORD)v229;
		      *(_QWORD *)&inputa.x = v20;
		      LODWORD(inputa.z) = height[0];
		      *(_QWORD *)&v228.x = v37;
		      v228.z = z;
		      v42 = HG::Rendering::Runtime::FakePlanarReflectionPass::Flip(&value, &v228, &inputa, &v220, 0LL);
		      v43 = *(_QWORD *)&v42->x;
		      *(_QWORD *)&v220.x = *(_QWORD *)&v42->x;
		      inputa.x = v42->z;
		      v44 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v44 )
		        sub_1800D8250(v46, v45);
		      forward = UnityEngine::Transform::get_forward(&value, v44, 0LL);
		      *(_QWORD *)&v228.x = *(_QWORD *)&forward->x;
		      v48 = z + forward->z;
		      y_low = (__m128)LODWORD(v225.y);
		      v50 = (__m128)LODWORD(v225.y);
		      v50.m128_f32[0] = v225.y + v228.y;
		      x_low = (__m128)LODWORD(v225.x);
		      v52 = (__m128)LODWORD(v225.x);
		      v52.m128_f32[0] = v225.x + v228.x;
		      *(_QWORD *)&v225.x = v219;
		      LODWORD(v225.z) = (_DWORD)v229;
		      *(_QWORD *)&v228.x = v20;
		      LODWORD(v228.z) = height[0];
		      *(_QWORD *)&value.x = _mm_unpacklo_ps(v52, v50).m128_u64[0];
		      value.z = v48;
		      v53 = HG::Rendering::Runtime::FakePlanarReflectionPass::Flip((Vector3 *)&v230, &value, &v228, &v225, 0LL);
		      *(_QWORD *)&value.x = *(_QWORD *)&v53->x;
		      v54 = inputa.x;
		      v55 = v53->z - inputa.x;
		      v56 = (__m128)LODWORD(value.y);
		      v56.m128_f32[0] = value.y - v220.y;
		      v57 = (__m128)LODWORD(value.x);
		      v57.m128_f32[0] = value.x - v220.x;
		      v58 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v58 )
		        sub_1800D8250(v60, v59);
		      up = UnityEngine::Transform::get_up((Vector3 *)&v230, v58, 0LL);
		      *(_QWORD *)&value.x = *(_QWORD *)&up->x;
		      v62 = z + up->z;
		      y_low.m128_f32[0] = y_low.m128_f32[0] + value.y;
		      x_low.m128_f32[0] = x_low.m128_f32[0] + value.x;
		      *(_QWORD *)&value.x = v219;
		      LODWORD(value.z) = (_DWORD)v229;
		      *(_QWORD *)&v225.x = v20;
		      LODWORD(v225.z) = height[0];
		      *(_QWORD *)&v228.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		      v228.z = v62;
		      v63 = HG::Rendering::Runtime::FakePlanarReflectionPass::Flip((Vector3 *)&v230, &v228, &v225, &value, 0LL);
		      *(_QWORD *)&value.x = *(_QWORD *)&v63->x;
		      v64 = v63->z - v54;
		      v65 = (__m128)LODWORD(value.y);
		      v65.m128_f32[0] = value.y - v220.y;
		      v66 = (__m128)LODWORD(value.x);
		      v66.m128_f32[0] = value.x - v220.x;
		      *(_QWORD *)&value.x = _mm_unpacklo_ps(v66, v65).m128_u64[0];
		      value.z = v64;
		      *(_QWORD *)&v225.x = _mm_unpacklo_ps(v57, v56).m128_u64[0];
		      v225.z = v55;
		      v67 = (Quaternion)_mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::LookRotation(
		                                                           &v230,
		                                                           &v225,
		                                                           &value,
		                                                           0LL));
		      v68 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v68 )
		        sub_1800D8250(v70, v69);
		      *(_QWORD *)&value.x = v43;
		      value.z = inputa.x;
		      UnityEngine::Transform::set_position_Injected(v68, &value, 0LL);
		      v71 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v71 )
		        sub_1800D8250(v73, v72);
		      v230 = v67;
		      UnityEngine::Transform::set_rotation_Injected(v71, &v230, 0LL);
		      v243 = *UnityEngine::Camera::get_cameraToWorldMatrix((Matrix4x4 *)&desc, (Camera *)camera, 0LL);
		      v74 = UnityEngine::Matrix4x4::Transpose((Matrix4x4 *)&v237, &v243, 0LL);
		      *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v74->m00;
		      *(_OWORD *)&desc.stateBlock.hasValue = *(_OWORD *)&v74->m01;
		      *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v74->m02;
		      *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v74->m03;
		      v217 = *UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v230, (Matrix4x4 *)&desc, &v217, 0LL);
		      HG::Rendering::Runtime::FakePlanarReflectionPass::UpdateBasicTransformConstants(
		        v12,
		        basicTransformConstants,
		        shaderVariablesGlobal,
		        (Camera *)camera,
		        &v217,
		        0LL);
		      v75 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v75 )
		        sub_1800D8250(v77, v76);
		      *(_QWORD *)&value.x = v37;
		      value.z = z;
		      UnityEngine::Transform::set_position_Injected(v75, &value, 0LL);
		      v78 = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !v78 )
		        sub_1800D8250(v80, v79);
		      v230 = *(Quaternion *)&v221.m_RenderPass;
		      UnityEngine::Transform::set_rotation_Injected(v78, &v230, 0LL);
		      sceneRTSize_k__BackingField = (MonitorData *)hgCamera->fields._sceneRTSize_k__BackingField;
		      *(_QWORD *)height = sceneRTSize_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      LODWORD(inputa.x) = v11->bakedLightingConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(
		                                                       hgCamera,
		                                                       0LL);
		      v82 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x8Bu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8250(v84, v83);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v221,
		        renderGraph,
		        (String *)"Fake Planar Reflection",
		        &v227,
		        v82,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      v236 = v221;
		      *(_QWORD *)&v217.x = 0LL;
		      *(_QWORD *)&v217.z = &v236;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v236, 0, 0LL);
		        sub_18033B330(v248, &v12->fields, 1312LL);
		        if ( !v227 )
		          sub_1800D8250(0LL, v85);
		        sub_18033B330(&v227[2], v248, 1312LL);
		        sub_18033B330(v248, &v12->fields.m_shaderVariablesGlobal, 3200LL);
		        if ( !v227 )
		          sub_1800D8250(0LL, v86);
		        sub_18033B330(&v227[84], v248, 3200LL);
		        v88 = v227;
		        if ( !v227 )
		          sub_1800D8250(v87, 0LL);
		        v227[290].klass = (Object__Class *)hgCamera;
		        if ( dword_18F35FD08 )
		        {
		          v89 = ((unsigned __int64)&v88[290] >> 12) & 0x1FFFFF;
		          v90 = (unsigned __int64)v89 >> 6;
		          v91 = v89 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v90 + 36190]);
		          do
		            v92 = qword_18F0BCBA0[v90 + 36190];
		          while ( v92 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v90 + 36190], v92 | (1LL << v91), v92) );
		        }
		        v229 = (RendererListHandle *)v227;
		        cullingResults = v11->cullingResults;
		        v219 = hgCamera->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields;
		        screenCullingRatio = v11->screenCullingRatio;
		        screenCullingRatioDistance = v11->screenCullingRatioDistance;
		        screenCullingLayerMask = v11->screenCullingLayerMask;
		        *(_QWORD *)&value.x = 0LL;
		        sub_18033B9D0(&desc, 0LL, 112LL);
		        *(_QWORD *)&v225.x = *(_QWORD *)&value.x;
		        v225.z = value.x;
		        *(CullingResults *)&v221.m_RenderPass = cullingResults;
		        OpaqueRendererListDesc = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                                   v248,
		                                   (CullingResults *)&v221,
		                                   v219,
		                                   static_fields->s_DepthCharacterOnlyName,
		                                   screenCullingRatio,
		                                   screenCullingRatioDistance,
		                                   screenCullingLayerMask,
		                                   LODWORD(inputa.x),
		                                   (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v225,
		                                   (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
		                                   0LL,
		                                   0,
		                                   0LL,
		                                   0LL);
		        *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&OpaqueRendererListDesc->sortingCriteria;
		        desc.stateBlock = OpaqueRendererListDesc->stateBlock;
		        OpaqueRendererListDesc = (RendererListDesc *)((char *)OpaqueRendererListDesc + 128);
		        *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&OpaqueRendererListDesc->sortingCriteria;
		        *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&OpaqueRendererListDesc->stateBlock.hasValue;
		        *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&OpaqueRendererListDesc->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&OpaqueRendererListDesc->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&OpaqueRendererListDesc->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&OpaqueRendererListDesc->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        v99 = renderGraph;
		        *(RendererListHandle *)&inputa.x = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                             renderGraph,
		                                             &desc,
		                                             0LL);
		        v100 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                 &v236,
		                 (RendererListHandle *)&inputa,
		                 0LL);
		        if ( !v229 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v101);
		        v229[568] = v100;
		        characterPrePassECSList = v11->characterPrePassECSList;
		        if ( !v227 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterPrePassECSList, v101);
		        HIDWORD(v227[287].monitor) = characterPrePassECSList;
		        forwardOpaquePreZECSList = v11->forwardOpaquePreZECSList;
		        if ( !v227 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(forwardOpaquePreZECSList, v101);
		        LODWORD(v227[288].klass) = forwardOpaquePreZECSList;
		        sub_18033B9D0(&v237, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		          &v237,
		          (int32_t)sceneRTSize_k__BackingField,
		          height[1],
		          0LL);
		        v231 = v237;
		        v231.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                             renderGraph,
		                             &v11->sceneDepthTexture,
		                             0LL)->colorFormat;
		        v231.depthBufferBits = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                                 renderGraph,
		                                 &v11->sceneDepthTexture,
		                                 0LL)->depthBufferBits;
		        v231.name = (String *)"Fake Planar Reflection Depth texture";
		        if ( dword_18F35FD08 )
		        {
		          v104 = (((unsigned __int64)&v231.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v104 + 36190]);
		          do
		            v105 = qword_18F0BCBA0[v104 + 36190];
		          while ( v105 != _InterlockedCompareExchange64(
		                            &qword_18F0BCBA0[v104 + 36190],
		                            v105 | (1LL << (((unsigned __int64)&v231.name >> 12) & 0x3F)),
		                            v105) );
		        }
		        v244 = v231;
		        *(TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m00 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                                                                (TextureHandle *)&v221,
		                                                                                                renderGraph,
		                                                                                                &v244,
		                                                                                                0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v221,
		          &v236,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix,
		          DepthAccess__Enum_ReadWrite,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_DontCare,
		          1.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v236,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields->s_DepthPrepassRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v239 )
		      {
		        *(Il2CppExceptionWrapper *)&v217.x = (Il2CppExceptionWrapper)v239->ex;
		        sub_180268AE0(&v217);
		        v11 = input;
		        v12 = this;
		        sceneRTSize_k__BackingField = *(MonitorData **)height;
		        v99 = renderGraph;
		        goto LABEL_31;
		      }
		      sub_180268AE0(&v217);
		LABEL_31:
		      v106 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0x8Cu,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v221,
		        v99,
		        (String *)"Fake Planar Reflection",
		        &v218,
		        v106,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      v232 = v221;
		      *(_QWORD *)&v217.x = 0LL;
		      *(_QWORD *)&v217.z = &v232;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v232, 0, 0LL);
		        sub_18033B330(v248, basicTransformConstants, 1312LL);
		        if ( !v218 )
		          sub_1800D8250(0LL, v107);
		        sub_18033B330(&v218[2], v248, 1312LL);
		        sub_18033B330(v248, shaderVariablesGlobal, 3200LL);
		        if ( !v218 )
		          sub_1800D8250(0LL, v108);
		        sub_18033B330(&v218[84], v248, 3200LL);
		        v110 = v218;
		        if ( !v218 )
		          sub_1800D8250(v109, 0LL);
		        v111 = hgCamera;
		        v218[290].klass = (Object__Class *)hgCamera;
		        if ( dword_18F35FD08 )
		        {
		          v112 = ((unsigned __int64)&v110[290] >> 12) & 0x1FFFFF;
		          v113 = (unsigned __int64)v112 >> 6;
		          v114 = v112 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v113 + 36190]);
		          do
		            v115 = qword_18F0BCBA0[v113 + 36190];
		          while ( v115 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v113 + 36190], v115 | (1LL << v114), v115) );
		        }
		        v116 = (RendererListHandle *)v218;
		        bakedLightingConfig = v11->bakedLightingConfig;
		        v118 = v11->screenCullingRatio;
		        v119 = v11->screenCullingRatioDistance;
		        v120 = v11->screenCullingLayerMask;
		        *(CullingResults *)&v221.m_RenderPass = v11->cullingResults;
		        v121 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueRendererList(
		                 v248,
		                 v11->hgrp,
		                 hgCamera,
		                 (CullingResults *)&v221,
		                 bakedLightingConfig,
		                 v118,
		                 v119,
		                 v120,
		                 0LL);
		        *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v121->sortingCriteria;
		        desc.stateBlock = v121->stateBlock;
		        v121 = (RendererListDesc *)((char *)v121 + 128);
		        *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v121->sortingCriteria;
		        *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v121->stateBlock.hasValue;
		        *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v121->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v121->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v121->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v121->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        *(RendererListHandle *)&inputa.x = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                             renderGraph,
		                                             &desc,
		                                             0LL);
		        v122 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                 &v232,
		                 (RendererListHandle *)&inputa,
		                 0LL);
		        if ( !v116 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v124, v123);
		        v116[569] = v122;
		        v125 = (RendererListHandle *)v218;
		        if ( v11->characterOutlineEnable )
		        {
		          v126 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueCharacterOutlineRendererList(
		                   v248,
		                   v11->hgrp,
		                   hgCamera,
		                   &v11->cullingResults,
		                   (PerObjectData__Enum)v11->bakedLightingConfig,
		                   v11->screenCullingRatio,
		                   v11->screenCullingRatioDistance,
		                   v11->screenCullingLayerMask,
		                   0LL);
		          *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v126->sortingCriteria;
		          desc.stateBlock = v126->stateBlock;
		          v126 = (RendererListDesc *)((char *)v126 + 128);
		          *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v126->sortingCriteria;
		          *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v126->stateBlock.hasValue;
		          *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v126->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v126->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v126->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v126->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		          *(RendererListHandle *)&inputa.x = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                               renderGraph,
		                                               &desc,
		                                               0LL);
		          InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                            &v232,
		                            (RendererListHandle *)&inputa,
		                            0LL);
		        }
		        else
		        {
		          InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		        }
		        if ( !v125 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v129, v128);
		        v125[570] = InvalidHandle;
		        forwardOpaqueECSList = v11->forwardOpaqueECSList;
		        if ( !v218 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(forwardOpaqueECSList, v128);
		        HIDWORD(v218[288].klass) = forwardOpaqueECSList;
		        forwardOpaqueEqualECSList = v11->forwardOpaqueEqualECSList;
		        if ( !v218 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(forwardOpaqueEqualECSList, v128);
		        LODWORD(v218[288].monitor) = forwardOpaqueEqualECSList;
		        characterOpaqueECSList = v11->characterOpaqueECSList;
		        if ( !v218 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOpaqueECSList, v128);
		        HIDWORD(v218[288].monitor) = characterOpaqueECSList;
		        characterOutlineOpaquePreZECSList = v11->characterOutlineOpaquePreZECSList;
		        if ( !v218 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlineOpaquePreZECSList, v128);
		        LODWORD(v218[289].klass) = characterOutlineOpaquePreZECSList;
		        characterOutlineOpaqueECSList = v11->characterOutlineOpaqueECSList;
		        if ( !v218 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlineOpaqueECSList, v128);
		        HIDWORD(v218[289].klass) = characterOutlineOpaqueECSList;
		        characterOutlineOpaqueEqualECSList = v11->characterOutlineOpaqueEqualECSList;
		        if ( !v218 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlineOpaqueEqualECSList, v128);
		        LODWORD(v218[289].monitor) = characterOutlineOpaqueEqualECSList;
		        v136 = v218;
		        hgrp = v11->hgrp;
		        if ( !hgrp )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(characterOutlineOpaqueEqualECSList, v128);
		        settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		        if ( !settingParameters_k__BackingField )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v128);
		        screenSpaceShadowMaskEnabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                         settingParameters_k__BackingField->fields._enableScreenSpaceShadowMask_k__BackingField,
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		        IsScreenSpaceShadowMaskEnabled = HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
		                                           screenSpaceShadowMaskEnabled,
		                                           0LL);
		        if ( !v136 )
		          sub_1800D8250(v141, v140);
		        LOBYTE(v136[287].monitor) = IsScreenSpaceShadowMaskEnabled;
		        sub_18033B9D0(&v237, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		          &v237,
		          (int32_t)sceneRTSize_k__BackingField,
		          height[1],
		          0LL);
		        v142 = *(_OWORD *)&v237.width;
		        *(_OWORD *)&v231.width = *(_OWORD *)&v237.width;
		        *(_OWORD *)&v231.colorFormat = *(_OWORD *)&v237.colorFormat;
		        v143 = *(_OWORD *)&v237.enableRandomWrite;
		        *(_OWORD *)&v231.enableRandomWrite = *(_OWORD *)&v237.enableRandomWrite;
		        *(_QWORD *)&v231.bindTextureMS = *(_QWORD *)&v237.bindTextureMS;
		        v144 = *(_OWORD *)&v237.fastMemoryDesc.inFastMemory;
		        *(_OWORD *)&v231.fastMemoryDesc.inFastMemory = *(_OWORD *)&v237.fastMemoryDesc.inFastMemory;
		        clearColor = v237.clearColor;
		        v231.clearColor = v237.clearColor;
		        v231.colorFormat = 48;
		        v231.name = (String *)"Fake Planar Reflection Color texture";
		        if ( dword_18F35FD08 )
		        {
		          v146 = (((unsigned __int64)&v231.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v146 + 36190]);
		          do
		            v147 = qword_18F0BCBA0[v146 + 36190];
		          while ( v147 != _InterlockedCompareExchange64(
		                            &qword_18F0BCBA0[v146 + 36190],
		                            v147 | (1LL << (((unsigned __int64)&v231.name >> 12) & 0x3F)),
		                            v147) );
		          clearColor = v231.clearColor;
		          v144 = *(_OWORD *)&v231.fastMemoryDesc.inFastMemory;
		          v143 = *(_OWORD *)&v231.enableRandomWrite;
		          v142 = *(_OWORD *)&v231.width;
		        }
		        *(_OWORD *)&v245.width = v142;
		        *(_OWORD *)&v245.colorFormat = *(_OWORD *)&v231.colorFormat;
		        *(_OWORD *)&v245.enableRandomWrite = v143;
		        *(_OWORD *)&v245.bindTextureMS = *(_OWORD *)&v231.bindTextureMS;
		        *(_OWORD *)&v245.fastMemoryDesc.inFastMemory = v144;
		        v245.clearColor = clearColor;
		        v148 = renderGraph;
		        *(TextureHandle *)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture((TextureHandle *)&v221, renderGraph, &v245, 0LL);
		        *(BitArray128 *)&v221.m_RenderPass = hgCamera->fields._frameSettings_k__BackingField.bitDatas;
		        v221.m_RenderGraph = *(HGRenderGraph **)&hgCamera->fields._frameSettings_k__BackingField.materialQuality;
		        if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		               (FrameSettings *)&v221,
		               FrameSettingsField__Enum_ShadowMaps,
		               0LL)
		          || (*(BitArray128 *)&v221.m_RenderPass = hgCamera->fields._frameSettings_k__BackingField.bitDatas,
		              v221.m_RenderGraph = *(HGRenderGraph **)&hgCamera->fields._frameSettings_k__BackingField.materialQuality,
		              HG::Rendering::Runtime::FrameSettings::IsEnabled(
		                (FrameSettings *)&v221,
		                FrameSettingsField__Enum_CharacterShadowMaps,
		                0LL)) )
		        {
		          v149 = *(_OWORD *)&v232.m_RenderPass;
		          v150 = *(_OWORD *)&v232.m_RenderGraph;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          *(_OWORD *)&v221.m_RenderPass = v149;
		          *(_OWORD *)&v221.m_RenderGraph = v150;
		          HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
		            (ShadowResult *)&v243,
		            &v11->shadowResult,
		            &v221,
		            0LL);
		        }
		        *(_OWORD *)&v221.m_RenderPass = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v230,
		          &v232,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03,
		          0,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v221,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v221,
		          &v232,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix,
		          DepthAccess__Enum_ReadWrite,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_DontCare,
		          1.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v232,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields->s_RenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v240 )
		      {
		        *(Il2CppExceptionWrapper *)&v217.x = (Il2CppExceptionWrapper)v240->ex;
		        sub_180268AE0(&v217);
		        v12 = this;
		        sceneRTSize_k__BackingField = *(MonitorData **)height;
		        v111 = hgCamera;
		        v148 = renderGraph;
		        goto LABEL_61;
		      }
		      sub_180268AE0(&v217);
		LABEL_61:
		      if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(v111, 0LL) <= 0.001 )
		      {
		LABEL_104:
		        sub_180269330(v233);
		        return;
		      }
		      sub_18033B9D0(&v237, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v237,
		        (int32_t)sceneRTSize_k__BackingField,
		        height[1],
		        0LL);
		      v151 = *(_OWORD *)&v237.width;
		      *(_OWORD *)&v231.width = *(_OWORD *)&v237.width;
		      *(_OWORD *)&v231.colorFormat = *(_OWORD *)&v237.colorFormat;
		      v152 = *(_OWORD *)&v237.enableRandomWrite;
		      *(_OWORD *)&v231.enableRandomWrite = *(_OWORD *)&v237.enableRandomWrite;
		      *(_QWORD *)&v231.bindTextureMS = *(_QWORD *)&v237.bindTextureMS;
		      v153 = *(_OWORD *)&v237.fastMemoryDesc.inFastMemory;
		      *(_OWORD *)&v231.fastMemoryDesc.inFastMemory = *(_OWORD *)&v237.fastMemoryDesc.inFastMemory;
		      v154 = v237.clearColor;
		      v231.clearColor = v237.clearColor;
		      v231.colorFormat = 48;
		      v231.name = (String *)"Fake Planar Reflection Color Blur texture";
		      if ( dword_18F35FD08 )
		      {
		        v155 = (((unsigned __int64)&v231.name >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v155 + 36190]);
		        do
		          v156 = qword_18F0BCBA0[v155 + 36190];
		        while ( v156 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v155 + 36190],
		                          v156 | (1LL << (((unsigned __int64)&v231.name >> 12) & 0x3F)),
		                          v156) );
		        v154 = v231.clearColor;
		        v153 = *(_OWORD *)&v231.fastMemoryDesc.inFastMemory;
		        v152 = *(_OWORD *)&v231.enableRandomWrite;
		        v151 = *(_OWORD *)&v231.width;
		      }
		      *(_OWORD *)&v246.width = v151;
		      *(_OWORD *)&v246.colorFormat = *(_OWORD *)&v231.colorFormat;
		      *(_OWORD *)&v246.enableRandomWrite = v152;
		      *(_OWORD *)&v246.bindTextureMS = *(_OWORD *)&v231.bindTextureMS;
		      *(_OWORD *)&v246.fastMemoryDesc.inFastMemory = v153;
		      v246.clearColor = v154;
		      *(TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m01 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                                                              (TextureHandle *)&v221,
		                                                                                              v148,
		                                                                                              &v246,
		                                                                                              0LL);
		      v157 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0x8Du,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v221,
		        v148,
		        (String *)"Fake Planar Reflection",
		        &v223,
		        v157,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      v234 = v221;
		      *(_QWORD *)&v217.x = 0LL;
		      *(_QWORD *)&v217.z = &v234;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v234, 0, 0LL);
		        if ( !v223 )
		          sub_1800D8250(v159, v158);
		        LODWORD(v223[1].klass) = 0;
		        v160 = v223;
		        fakePlanarReflectionBlur = HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(v111, 0LL);
		        if ( !v160 )
		          sub_1800D8250(v162, v161);
		        *((float *)&v160[1].klass + 1) = fakePlanarReflectionBlur;
		        if ( !v223 )
		          sub_1800D8250(v162, v161);
		        v223[1].monitor = sceneRTSize_k__BackingField;
		        sub_18033B330(v248, basicTransformConstants, 1312LL);
		        if ( !v223 )
		          sub_1800D8250(0LL, v164);
		        sub_18033B330(&v223[2], v248, 1312LL);
		        sub_18033B330(v248, shaderVariablesGlobal, 3200LL);
		        if ( !v223 )
		          sub_1800D8250(0LL, v165);
		        sub_18033B330(&v223[84], v248, 3200LL);
		        v167 = v223;
		        if ( !v223 )
		          sub_1800D8250(v166, 0LL);
		        v223[290].monitor = *(MonitorData **)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m02;
		        v168 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v169 = ((unsigned __int64)&v167[290].monitor >> 12) & 0x1FFFFF;
		          v170 = v169 >> 6;
		          v171 = v169 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v170 + 36190]);
		          do
		            v172 = qword_18F0BCBA0[v170 + 36190];
		          while ( v172 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v170 + 36190], v172 | (1LL << v171), v172) );
		          v168 = dword_18F35FD08;
		        }
		        v173 = v223;
		        v174 = *(Object__Class **)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m22;
		        if ( !v223 )
		          sub_1800D8250(v174, 0LL);
		        v223[291].klass = v174;
		        if ( v168 )
		        {
		          v175 = ((unsigned __int64)&v173[291] >> 12) & 0x1FFFFF;
		          v176 = v175 >> 6;
		          v177 = v175 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v176 + 36190]);
		          do
		            v178 = qword_18F0BCBA0[v176 + 36190];
		          while ( v178 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v176 + 36190], v178 | (1LL << v177), v178) );
		        }
		        v179 = v223;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v182 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)&v221, 0LL);
		        if ( !v179 )
		          sub_1800D8250(v181, v180);
		        *(TextureHandle *)&v179[286].monitor = v182;
		        v183 = v223;
		        v186 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v221,
		                  &v234,
		                  (TextureHandle *)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03,
		                  0LL);
		        if ( !v183 )
		          sub_1800D8250(v185, v184);
		        *(TextureHandle *)&v183[285].monitor = v186;
		        *(__m128i *)&v221.m_RenderPass = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v230,
		          &v234,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m01,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v221,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v221,
		          &v234,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix,
		          DepthAccess__Enum_ReadWrite,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_DontCare,
		          1.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v234,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields->s_BlurRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v241 )
		      {
		        *(Il2CppExceptionWrapper *)&v217.x = (Il2CppExceptionWrapper)v241->ex;
		        sub_180268AE0(&v217);
		        v12 = this;
		        sceneRTSize_k__BackingField = *(MonitorData **)height;
		        v111 = hgCamera;
		        goto LABEL_85;
		      }
		      sub_180268AE0(&v217);
		LABEL_85:
		      v187 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0x8Du,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v221,
		        renderGraph,
		        (String *)"Fake Planar Reflection",
		        &v224,
		        v187,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      v235 = v221;
		      *(_QWORD *)&v217.x = 0LL;
		      *(_QWORD *)&v217.z = &v235;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v235, 0, 0LL);
		        if ( !v224 )
		          sub_1800D8250(v189, v188);
		        LODWORD(v224[1].klass) = 1;
		        v190 = v224;
		        v193 = HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(v111, 0LL);
		        if ( !v190 )
		          sub_1800D8250(v192, v191);
		        *((float *)&v190[1].klass + 1) = v193;
		        if ( !v224 )
		          sub_1800D8250(v192, v191);
		        v224[1].monitor = sceneRTSize_k__BackingField;
		        sub_18033B330(v248, basicTransformConstants, 1312LL);
		        if ( !v224 )
		          sub_1800D8250(0LL, v194);
		        sub_18033B330(&v224[2], v248, 1312LL);
		        sub_18033B330(v248, shaderVariablesGlobal, 3200LL);
		        if ( !v224 )
		          sub_1800D8250(0LL, v195);
		        sub_18033B330(&v224[84], v248, 3200LL);
		        v197 = v224;
		        if ( !v224 )
		          sub_1800D8250(v196, 0LL);
		        v224[290].monitor = *(MonitorData **)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m02;
		        v198 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v199 = ((unsigned __int64)&v197[290].monitor >> 12) & 0x1FFFFF;
		          v200 = v199 >> 6;
		          v201 = v199 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v200 + 36190]);
		          do
		            v202 = qword_18F0BCBA0[v200 + 36190];
		          while ( v202 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v200 + 36190], v202 | (1LL << v201), v202) );
		          v198 = dword_18F35FD08;
		        }
		        v203 = v224;
		        v204 = *(Object__Class **)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m22;
		        if ( !v224 )
		          sub_1800D8250(v204, 0LL);
		        v224[291].klass = v204;
		        if ( v198 )
		        {
		          v205 = ((unsigned __int64)&v203[291] >> 12) & 0x1FFFFF;
		          v206 = v205 >> 6;
		          v203 = (Object *)(v205 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v206 + 36190]);
		          do
		          {
		            v204 = (Object__Class *)(qword_18F0BCBA0[v206 + 36190] | (1LL << (char)v203));
		            v207 = qword_18F0BCBA0[v206 + 36190];
		          }
		          while ( v207 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v206 + 36190], (signed __int64)v204, v207) );
		        }
		        if ( !v224 )
		          sub_1800D8250(v204, v203);
		        *(Object *)((char *)v224 + 4584) = *(Object *)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03;
		        v208 = v224;
		        v211 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v221,
		                  &v235,
		                  (TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix.m01,
		                  0LL);
		        if ( !v208 )
		          sub_1800D8250(v210, v209);
		        *(TextureHandle *)&v208[285].monitor = v211;
		        *(__m128i *)&v221.m_RenderPass = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v230,
		          &v235,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v221,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v221,
		          &v235,
		          (TextureHandle *)&v12[1].fields.m_basicTransformConstants._ReprojectionMatrix,
		          DepthAccess__Enum_ReadWrite,
		          RenderBufferLoadAction__Enum_Clear,
		          RenderBufferStoreAction__Enum_DontCare,
		          1.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v235,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass->static_fields->s_BlurRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v242 )
		      {
		        *(Il2CppExceptionWrapper *)&v217.x = (Il2CppExceptionWrapper)v242->ex;
		        sub_180268AE0(&v217);
		        goto LABEL_104;
		      }
		      sub_180268AE0(&v217);
		      sub_180269330(v233);
		    }
		    else
		    {
		LABEL_105:
		      if ( !renderGraph )
		        sub_1800D8260(v16, v15);
		      *(TextureHandle *)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m03 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture((TextureHandle *)&v221, renderGraph, *(RTHandle **)&v12[1].fields.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m22, 0LL);
		    }
		  }
		}
		
		private void UpdateBasicTransformConstants(ref BasicTransformConstants basicTransformConstants, ref ShaderVariablesGlobal shaderVariablesGlobal, Camera camera, Vector4 nearPlane) {} // 0x0000000189BA83DC-0x0000000189BA89EC
		// Void UpdateBasicTransformConstants(BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef, Camera, Vector4)
		void HG::Rendering::Runtime::FakePlanarReflectionPass::UpdateBasicTransformConstants(
		        FakePlanarReflectionPass *this,
		        BasicTransformConstants *basicTransformConstants,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        Camera *camera,
		        Vector4 *nearPlane,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // ebx
		  Matrix4x4 *v15; // rax
		  __int128 v16; // xmm6
		  __int128 v17; // xmm7
		  __int128 v18; // xmm8
		  __int128 v19; // xmm9
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v21; // xmm10
		  Vector4 v22; // xmm11
		  __int128 v23; // xmm0
		  Matrix4x4 *cameraToWorldMatrix; // rax
		  __int128 v25; // xmm14
		  __int128 v26; // xmm15
		  Vector4 v27; // xmm0
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v29; // xmm7
		  __int128 v30; // xmm6
		  __int128 v31; // xmm13
		  __int128 v32; // xmm12
		  Matrix4x4 *v33; // rax
		  __int128 v34; // xmm8
		  __int128 v35; // xmm9
		  __int128 v36; // xmm10
		  __int128 v37; // xmm11
		  Vector4 v38; // xmm1
		  __int128 v39; // xmm0
		  Matrix4x4 *v40; // rax
		  __int128 v41; // xmm1
		  __int128 v42; // xmm2
		  __int128 v43; // xmm3
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  Matrix4x4 *v52; // rax
		  __int128 v53; // xmm1
		  __int128 v54; // xmm2
		  __int128 v55; // xmm3
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  __int128 v59; // xmm0
		  __int128 v60; // xmm1
		  __int128 v61; // xmm0
		  __int128 v62; // xmm1
		  Matrix4x4 *v63; // rax
		  __int128 v64; // xmm1
		  __int128 v65; // xmm2
		  __int128 v66; // xmm3
		  __int128 v67; // xmm1
		  __int128 v68; // xmm2
		  __int128 v69; // xmm3
		  __int128 v70; // xmm1
		  __int128 v71; // xmm2
		  __int128 v72; // xmm3
		  __int128 v73; // xmm1
		  __int128 v74; // xmm2
		  __int128 v75; // xmm3
		  MethodInfo *v76; // r8
		  __int128 v77; // xmm1
		  __int128 v78; // xmm2
		  __int128 v79; // xmm3
		  Vector3 v80; // [rsp+48h] [rbp-C0h] BYREF
		  __int128 v81; // [rsp+58h] [rbp-B0h] BYREF
		  Vector4 v82; // [rsp+68h] [rbp-A0h] BYREF
		  Vector4 v83; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v84; // [rsp+88h] [rbp-80h] BYREF
		  __int128 v85; // [rsp+C8h] [rbp-40h]
		  Matrix4x4 v86; // [rsp+D8h] [rbp-30h] BYREF
		  Matrix4x4 v87; // [rsp+118h] [rbp+10h] BYREF
		  __int128 v88; // [rsp+158h] [rbp+50h]
		  Matrix4x4 v89; // [rsp+168h] [rbp+60h] BYREF
		  __m128i si128; // [rsp+1A8h] [rbp+A0h] BYREF
		  __int128 v91; // [rsp+1B8h] [rbp+B0h]
		  Matrix4x4 v92; // [rsp+1C8h] [rbp+C0h] BYREF
		  _BYTE v93[3360]; // [rsp+208h] [rbp+100h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3123, 0LL) )
		  {
		    if ( camera )
		    {
		      transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		      if ( transform )
		      {
		        position = UnityEngine::Transform::get_position((Vector3 *)&v81, transform, 0LL);
		        z = position->z;
		        *(_QWORD *)&v80.x = *(_QWORD *)&position->x;
		        v82 = *nearPlane;
		        v15 = UnityEngine::Camera::CalculateObliqueMatrix(&v84, camera, &v82, 0LL);
		        v16 = *(_OWORD *)&v15->m00;
		        v17 = *(_OWORD *)&v15->m01;
		        v18 = *(_OWORD *)&v15->m02;
		        v19 = *(_OWORD *)&v15->m03;
		        worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v84, camera, 0LL);
		        v21 = *(_OWORD *)&worldToCameraMatrix->m00;
		        v22 = *(Vector4 *)&worldToCameraMatrix->m01;
		        v81 = *(_OWORD *)&worldToCameraMatrix->m02;
		        v23 = *(_OWORD *)&worldToCameraMatrix->m03;
		        v88 = v21;
		        v85 = v23;
		        v82 = v22;
		        cameraToWorldMatrix = UnityEngine::Camera::get_cameraToWorldMatrix(&v84, camera, 0LL);
		        *(_OWORD *)&v87.m00 = v16;
		        *(_OWORD *)&v87.m01 = v17;
		        *(_OWORD *)&v87.m02 = v18;
		        v25 = *(_OWORD *)&cameraToWorldMatrix->m00;
		        v26 = *(_OWORD *)&cameraToWorldMatrix->m01;
		        v91 = *(_OWORD *)&cameraToWorldMatrix->m02;
		        v27 = *(Vector4 *)&cameraToWorldMatrix->m03;
		        *(_OWORD *)&v87.m03 = v19;
		        v83 = v27;
		        GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v92, &v87, 1, 0LL);
		        v29 = *(_OWORD *)&GPUProjectionMatrix->m02;
		        v30 = *(_OWORD *)&GPUProjectionMatrix->m03;
		        v31 = *(_OWORD *)&GPUProjectionMatrix->m00;
		        v32 = *(_OWORD *)&GPUProjectionMatrix->m01;
		        *(_OWORD *)&v86.m02 = v81;
		        *(_OWORD *)&v86.m03 = v85;
		        *(_OWORD *)&v84.m00 = v31;
		        *(_OWORD *)&v84.m01 = v32;
		        *(_OWORD *)&v89.m00 = v31;
		        *(_OWORD *)&v89.m01 = v32;
		        *(_OWORD *)&v89.m02 = v29;
		        *(_OWORD *)&v89.m03 = v30;
		        *(_OWORD *)&v86.m00 = v21;
		        *(Vector4 *)&v86.m01 = v22;
		        *(_OWORD *)&v84.m02 = v29;
		        *(_OWORD *)&v84.m03 = v30;
		        v33 = UnityEngine::Matrix4x4::op_Multiply(&v92, &v84, &v86, 0LL);
		        v34 = *(_OWORD *)&v33->m00;
		        v35 = *(_OWORD *)&v33->m01;
		        v36 = *(_OWORD *)&v33->m02;
		        v37 = *(_OWORD *)&v33->m03;
		        *(_OWORD *)&v87.m00 = v88;
		        *(Vector4 *)&v87.m01 = v82;
		        *(_OWORD *)&v87.m02 = v81;
		        *(_OWORD *)&v87.m03 = v85;
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        UnityEngine::Matrix4x4::SetColumn(&v87, 3, (Vector4 *)&si128, 0LL);
		        v38 = v83;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewMatrix.m00 = v88;
		        *(Vector4 *)&this->fields.m_basicTransformConstants.current._ViewMatrix.m01 = v82;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewMatrix.m02 = v81;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewMatrix.m03 = v85;
		        v39 = v91;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m00 = v25;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m01 = v26;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m02 = v39;
		        *(Vector4 *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m03 = v38;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ProjMatrix.m00 = v31;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ProjMatrix.m01 = v32;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ProjMatrix.m02 = v29;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ProjMatrix.m03 = v30;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		        v40 = HG::Rendering::Runtime::HGCamera::CalculateInvProjectionMatrix(&v92, &v89, 0LL);
		        v41 = *(_OWORD *)&v40->m01;
		        v42 = *(_OWORD *)&v40->m02;
		        v43 = *(_OWORD *)&v40->m03;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m00 = *(_OWORD *)&v40->m00;
		        v44 = *(_OWORD *)&v87.m00;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m01 = v41;
		        v45 = *(_OWORD *)&v87.m01;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m02 = v42;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m03 = v43;
		        *(_OWORD *)&v84.m01 = v45;
		        v46 = *(_OWORD *)&v87.m03;
		        *(_OWORD *)&v84.m00 = v44;
		        v47 = *(_OWORD *)&v87.m02;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m00 = v34;
		        *(_OWORD *)&v84.m03 = v46;
		        v48 = *(_OWORD *)&v89.m01;
		        *(_OWORD *)&v84.m02 = v47;
		        v49 = *(_OWORD *)&v89.m00;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m01 = v35;
		        *(_OWORD *)&v86.m01 = v48;
		        v50 = *(_OWORD *)&v89.m03;
		        *(_OWORD *)&v86.m00 = v49;
		        v51 = *(_OWORD *)&v89.m02;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m02 = v36;
		        *(_OWORD *)&v86.m03 = v50;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m03 = v37;
		        *(_OWORD *)&v86.m02 = v51;
		        v52 = UnityEngine::Matrix4x4::op_Multiply(&v92, &v86, &v84, 0LL);
		        v53 = *(_OWORD *)&v52->m01;
		        v54 = *(_OWORD *)&v52->m02;
		        v55 = *(_OWORD *)&v52->m03;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m00 = *(_OWORD *)&v52->m00;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m01 = v53;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m02 = v54;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m03 = v55;
		        v56 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m01;
		        *(_OWORD *)&v84.m00 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m00;
		        v57 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m02;
		        *(_OWORD *)&v84.m01 = v56;
		        v58 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvProjMatrix.m03;
		        *(_OWORD *)&v84.m02 = v57;
		        v59 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m00;
		        *(_OWORD *)&v84.m03 = v58;
		        v60 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m01;
		        *(_OWORD *)&v86.m00 = v59;
		        v61 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m02;
		        *(_OWORD *)&v86.m01 = v60;
		        v62 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewMatrix.m03;
		        *(_OWORD *)&v86.m02 = v61;
		        *(_OWORD *)&v86.m03 = v62;
		        v63 = UnityEngine::Matrix4x4::op_Multiply(&v92, &v86, &v84, 0LL);
		        v80.z = z;
		        v64 = *(_OWORD *)&v63->m01;
		        v65 = *(_OWORD *)&v63->m02;
		        v66 = *(_OWORD *)&v63->m03;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m00 = *(_OWORD *)&v63->m00;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m01 = v64;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m02 = v65;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m03 = v66;
		        v67 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m01;
		        v68 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m02;
		        v69 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m03;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m00 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m00;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m01 = v67;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m02 = v68;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m03 = v69;
		        v70 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m01;
		        v71 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m02;
		        v72 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m03;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewNoTransProjMatrix.m00;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m01 = v70;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m02 = v71;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m03 = v72;
		        v73 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m01;
		        v74 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m02;
		        v75 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m03;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m00 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvViewProjMatrix.m00;
		        *(_QWORD *)&v61 = *(_QWORD *)&v80.x;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m01 = v73;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m02 = v74;
		        *(_OWORD *)&this->fields.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m03 = v75;
		        *(_QWORD *)&v80.x = v61;
		        this->fields.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(&v83, &v80, v76));
		        sub_18033B330(v93, shaderVariablesGlobal, 3200LL);
		        sub_18033B330(&this->fields.m_shaderVariablesGlobal, v93, 3200LL);
		        this->fields.m_shaderVariablesGlobal._FoliageInteractiveParams0.x = 1.0;
		        v77 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m01;
		        v78 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m02;
		        v79 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m03;
		        *(_OWORD *)&this[1].fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21 = *(_OWORD *)&this->fields.m_basicTransformConstants.current._ViewProjMatrix.m00;
		        *(_OWORD *)&this[1].fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m22 = v77;
		        *(_OWORD *)&this[1].fields.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m23 = v78;
		        *(_OWORD *)&this[1].fields.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m20 = v79;
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(Patch, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3123, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  v83 = *nearPlane;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1150(
		    Patch,
		    (Object *)this,
		    basicTransformConstants,
		    shaderVariablesGlobal,
		    (Object *)camera,
		    &v83,
		    0LL);
		}
		
		[IDTag(1)]
		private static Vector3 Flip(Vector3 point, float height) => default; // 0x0000000189BA8080-0x0000000189BA8124
		// Vector3 Flip(Vector3, Single)
		Vector3 *HG::Rendering::Runtime::FakePlanarReflectionPass::Flip(
		        Vector3 *__return_ptr retstr,
		        Vector3 *point,
		        float height,
		        MethodInfo *method)
		{
		  float v6; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+30h] [rbp-38h] BYREF
		  Vector3 v14; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3127, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3127, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = point->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&point->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1155(&v14, Patch, &v13, height, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    v6 = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    retstr->x = point->x;
		    v6 = point->z;
		    retstr->y = (float)(height + height) - point->y;
		  }
		  retstr->z = v6;
		  return retstr;
		}
		
		[IDTag(0)]
		private static Vector3 Flip(Vector3 point, Vector3 planeNormal, Vector3 planePivot) => default; // 0x0000000189BA8124-0x0000000189BA82E0
		// Vector3 Flip(Vector3, Vector3, Vector3)
		Vector3 *HG::Rendering::Runtime::FakePlanarReflectionPass::Flip(
		        Vector3 *__return_ptr retstr,
		        Vector3 *point,
		        Vector3 *planeNormal,
		        Vector3 *planePivot,
		        MethodInfo *method)
		{
		  MethodInfo *v9; // r9
		  float v10; // eax
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  Vector3 *v13; // rax
		  __int64 v14; // xmm3_8
		  __int64 v15; // xmm0_8
		  MethodInfo *v16; // r8
		  Vector3 *v17; // rax
		  __int64 v18; // xmm0_8
		  __int64 v19; // xmm4_8
		  MethodInfo *v20; // r8
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  __int64 v23; // xmm3_8
		  MethodInfo *v24; // r9
		  Vector3 *v25; // rax
		  __int64 v26; // xmm0_8
		  __int64 v27; // xmm3_8
		  MethodInfo *v28; // r9
		  Vector3 *v29; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v31; // rcx
		  __int64 v32; // xmm0_8
		  float z; // eax
		  __int64 v34; // xmm0_8
		  float v35; // eax
		  __int64 v36; // xmm0_8
		  __int64 v37; // xmm0_8
		  float v38; // eax
		  Vector3 v40; // [rsp+30h] [rbp-40h] BYREF
		  Vector3 v41; // [rsp+40h] [rbp-30h] BYREF
		  Vector3 v42; // [rsp+50h] [rbp-20h] BYREF
		  Vector3 v43; // [rsp+60h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3122, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3122, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, 0LL);
		    v32 = *(_QWORD *)&planePivot->x;
		    v42.z = planePivot->z;
		    z = planeNormal->z;
		    *(_QWORD *)&v42.x = v32;
		    v34 = *(_QWORD *)&planeNormal->x;
		    v41.z = z;
		    v35 = point->z;
		    *(_QWORD *)&v41.x = v34;
		    v36 = *(_QWORD *)&point->x;
		    v40.z = v35;
		    *(_QWORD *)&v40.x = v36;
		    v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1149(&v43, Patch, &v40, &v41, &v42, 0LL);
		  }
		  else
		  {
		    v10 = point->z;
		    *(_QWORD *)&v40.x = *(_QWORD *)&point->x;
		    v11 = *(_QWORD *)&planePivot->x;
		    v40.z = v10;
		    v12 = planePivot->z;
		    *(_QWORD *)&v41.x = v11;
		    v41.z = v12;
		    v13 = UnityEngine::Vector3::op_Subtraction(&v42, &v41, &v40, v9);
		    v14 = *(_QWORD *)&planeNormal->x;
		    v41.z = planeNormal->z;
		    v15 = *(_QWORD *)&v13->x;
		    *(float *)&v13 = v13->z;
		    *(_QWORD *)&v40.x = v15;
		    LODWORD(v40.z) = (_DWORD)v13;
		    *(_QWORD *)&v41.x = v14;
		    v17 = UnityEngine::Vector3::op_UnaryNegation(&v42, &v41, v16);
		    v18 = *(_QWORD *)&planeNormal->x;
		    v19 = *(_QWORD *)&v17->x;
		    v41.z = v17->z;
		    v42.z = planeNormal->z;
		    *(_QWORD *)&v41.x = v19;
		    *(_QWORD *)&v42.x = v18;
		    *(float *)&v18 = UnityEngine::Vector3::Dot(&v41, &v40, v20);
		    v22 = UnityEngine::Vector3::op_Multiply(&v41, &v42, *(float *)&v18, v21);
		    v23 = *(_QWORD *)&v22->x;
		    *(float *)&v22 = v22->z;
		    *(_QWORD *)&v42.x = v23;
		    LODWORD(v42.z) = (_DWORD)v22;
		    v25 = UnityEngine::Vector3::op_Multiply(&v41, &v42, 2.0, v24);
		    v26 = *(_QWORD *)&point->x;
		    v27 = *(_QWORD *)&v25->x;
		    v42.z = v25->z;
		    v41.z = point->z;
		    *(_QWORD *)&v42.x = v27;
		    *(_QWORD *)&v41.x = v26;
		    v29 = UnityEngine::Vector3::op_Subtraction(&v40, &v41, &v42, v28);
		  }
		  v37 = *(_QWORD *)&v29->x;
		  v38 = v29->z;
		  *(_QWORD *)&retstr->x = v37;
		  retstr->z = v38;
		  return retstr;
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BA8388-0x0000000189BA83DC
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        FakePlanarReflectionPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3128, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3128, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BA8334-0x0000000189BA8388
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        FakePlanarReflectionPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3129, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3129, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BA82E0-0x0000000189BA8334
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        FakePlanarReflectionPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3130, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3130, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D804D0-0x0000000184D80500
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        FakePlanarReflectionPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3131, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3131, 0LL);
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
