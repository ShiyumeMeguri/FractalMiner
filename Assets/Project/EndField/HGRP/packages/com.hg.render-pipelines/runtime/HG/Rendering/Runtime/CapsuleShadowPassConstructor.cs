using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class CapsuleShadowPassConstructor : IPassConstructor // TypeDefIndex: 37833
	{
		// Fields
		private Shader m_visibilitySHShader; // 0x10
		private Mesh m_sphereMesh; // 0x18
		private Texture2D m_visibilityABLut; // 0x20
		private Texture2D m_visibilitySHLut; // 0x28
		private static readonly RenderFunc<CapsuleShadowPassDataV2> s_CapsuleShadowRenderFuncV2; // 0x00
		private static readonly RenderFunc<CapsuleShadowPassDataV2> s_CapsuleShadowRenderFuncEmptyV2; // 0x08
		private static readonly RenderFunc<DownSampleDepthPassData> s_DonwSampleDepthRenderFunc; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 37826
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal TextureHandle sceneDepthCopied; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal CullingResults cullingResults; // 0x30
			internal LightCullResult lightCullResult; // 0x40
			internal GBufferOutput gBufferOutput; // 0x50
			internal int directionalLightIndex; // 0x70
			internal float sphereIntervalScale; // 0x74
			internal float sphereRangeScale; // 0x78
			internal bool enabled; // 0x7C
			internal bool enableHalfRez; // 0x7D
			internal GraphicsFormat depthFormat; // 0x80
			internal DepthBits depthBufferBits; // 0x84
			internal Material visibilitySHMaterial; // 0x88
		}
	
		internal struct PassOutput // TypeDefIndex: 37827
		{
		}
	
		private class CapsuleShadowPassData // TypeDefIndex: 37828
		{
			// Fields
			public TextureHandle gbufferNormalTexture; // 0x10
	
			// Constructors
			public CapsuleShadowPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class DownSampleDepthPassData // TypeDefIndex: 37829
		{
			// Fields
			public TextureHandle srcDepth; // 0x10
			public Material visibilitySHMaterial; // 0x20
	
			// Constructors
			public DownSampleDepthPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class CapsuleShadowPassDataV2 // TypeDefIndex: 37830
		{
			// Fields
			public CBHandle visibilitySHCB; // 0x10
			public CBHandle capsuleCBHandle; // 0x28
			public TextureHandle visibilitySHRT; // 0x40
			public Texture2D visibilitySHRTDefault; // 0x50
			public Texture2D visibilitySHLut; // 0x58
			public Texture2D visibilityABLut; // 0x60
			public TextureHandle gBufferB; // 0x68
			public TextureHandle sceneDepthCopied; // 0x78
			public Material visibilitySHMaterial; // 0x88
			public Mesh sphereMesh; // 0x90
			public int capsuleNum; // 0x98
	
			// Constructors
			public CapsuleShadowPassDataV2() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private struct VisibilitySHConstData // TypeDefIndex: 37831
		{
			// Fields
			public Vector4 logSHParams; // 0x00
			public Vector4 gStarParams; // 0x10
			public Vector4 abParams; // 0x20
			public Vector4 fHatParams; // 0x30
			public Vector4 sphereParams; // 0x40
			public Vector4Int tileParam0; // 0x50
			public Vector4 tileParam1; // 0x60
			public Vector4 tileParam2; // 0x70
		}
	
		// Constructors
		public CapsuleShadowPassConstructor() {} // Dummy constructor
		internal CapsuleShadowPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184A27300-0x0000000184A273A0
		// CapsuleShadowPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassConstructor(
		        CapsuleShadowPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  PropertyInfo_1 *v5; // r8
		  __int64 v6; // r9
		  __int64 v7; // r10
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  __int64 v10; // r9
		  __int64 v11; // r10
		  __int64 v12; // rax
		  PropertyInfo_1 *v13; // r8
		  __int64 v14; // r9
		  __int64 v15; // r10
		  __int64 v16; // rax
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_2;
		  this->fields.m_visibilitySHShader = shaders->fields.visibilitySHPS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields,
		    (Type *)materialCollector,
		    (PropertyInfo_1 *)resources,
		    (Int32__Array **)this,
		    v17);
		  if ( !*(_QWORD *)v7
		    || (v8 = *(_QWORD *)(*(_QWORD *)v7 + 40LL)) == 0
		    || (*(_QWORD *)(v6 + 32) = *(_QWORD *)(v8 + 88),
		        sub_18002D1B0((SingleFieldAccessor *)(v6 + 32), (Type *)materialCollector, v5, (Int32__Array **)v6, v18),
		        !*(_QWORD *)v11)
		    || (v12 = *(_QWORD *)(*(_QWORD *)v11 + 40LL)) == 0
		    || (*(_QWORD *)(v10 + 40) = *(_QWORD *)(v12 + 96),
		        sub_18002D1B0((SingleFieldAccessor *)(v10 + 40), (Type *)materialCollector, v9, (Int32__Array **)v10, v19),
		        !*(_QWORD *)v15)
		    || (v16 = *(_QWORD *)(*(_QWORD *)v15 + 48LL)) == 0 )
		  {
		LABEL_2:
		    sub_1800D8260(this, materialCollector);
		  }
		  *(_QWORD *)(v14 + 24) = *(_QWORD *)(v16 + 16);
		  sub_18002D1B0((SingleFieldAccessor *)(v14 + 24), (Type *)materialCollector, v13, (Int32__Array **)v14, v20);
		}
		
		static CapsuleShadowPassConstructor() {} // 0x0000000184B357F0-0x0000000184B35950
		// CapsuleShadowPassConstructor()
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::cctor(MethodInfo *method)
		{
		  struct CapsuleShadowPassConstructor_c__Class *v1; // rax
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
		
		  v1 = TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
		  v6 = (Type__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c::__cctor_b__19_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v22);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
		  v12 = (MonitorData *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c::__cctor_b__19_1,
		          0LL),
		        v13 = (Type *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields,
		        v13->monitor = v12,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields->s_CapsuleShadowRenderFuncEmptyV2,
		          v13,
		          v14,
		          v15,
		          v23),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>),
		        (v18 = v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor::__c::__cctor_b__19_2,
		    0LL);
		  v19 = (Type *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields;
		  v19->fields._impl.value = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields->s_DonwSampleDepthRenderFunc,
		    v19,
		    v20,
		    v21,
		    v24);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189D16AF0-0x0000000189D16B44
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        CapsuleShadowPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2096, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2096, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189D16A9C-0x0000000189D16AF0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        CapsuleShadowPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2097, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2097, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass_VisibilitySH(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189D15978-0x0000000189D16A48
		// Void ConstructPass_VisibilitySH(CapsuleShadowPassConstructor+PassInput ByRef, CapsuleShadowPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2 #try_helpers=1
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::ConstructPass_VisibilitySH(
		        CapsuleShadowPassConstructor *this,
		        CapsuleShadowPassConstructor_PassInput *input,
		        CapsuleShadowPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGRenderGraph *v6; // r14
		  CapsuleShadowPassConstructor_PassInput *v8; // rsi
		  CapsuleShadowPassConstructor *v9; // r13
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rcx
		  int32_t m_X; // r12d
		  unsigned __int64 v14; // rcx
		  int32_t v15; // edi
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int128 v18; // xmm2
		  __int128 v19; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v21; // r8
		  signed __int64 v22; // rtt
		  Object *v23; // r12
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  TextureHandle v26; // xmm0
		  Object *v27; // rdx
		  unsigned __int64 v28; // rdx
		  unsigned __int64 v29; // r8
		  char v30; // dl
		  signed __int64 v31; // rtt
		  ProfilingSampler *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rcx
		  Object *v36; // rdx
		  unsigned __int64 v37; // rdx
		  unsigned __int64 v38; // r8
		  char v39; // dl
		  signed __int64 v40; // rtt
		  Object *v41; // r12
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  TextureHandle v44; // xmm0
		  Object *v45; // r12
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  TextureHandle v48; // xmm0
		  Object *v49; // rdx
		  int v50; // eax
		  unsigned __int64 v51; // rdx
		  unsigned __int64 v52; // r8
		  char v53; // dl
		  signed __int64 v54; // rtt
		  Object *v55; // rdx
		  Object__Class *m_visibilityABLut; // rcx
		  unsigned __int64 v57; // rdx
		  unsigned __int64 v58; // r8
		  char v59; // dl
		  signed __int64 v60; // rtt
		  Object *v61; // rdx
		  MonitorData *m_visibilitySHLut; // rcx
		  unsigned __int64 v63; // rdx
		  unsigned __int64 v64; // r8
		  char v65; // dl
		  signed __int64 v66; // rtt
		  signed int RenderCapsuleNum; // r12d
		  float v68; // xmm1_4
		  uint32_t v69; // r12d
		  HGRenderGraphContext *HGContext; // rax
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  ScriptableRenderContext *p_renderContext; // r13
		  CBHandle *v74; // rax
		  __int128 v75; // xmm7
		  Void *ptr; // xmm6_8
		  signed int RenderCapsuleData; // r12d
		  __int64 v78; // rdx
		  __int64 v79; // rcx
		  Object *v80; // rax
		  float sphereIntervalScale; // xmm0_4
		  int v82; // xmm8_4
		  float sphereRangeScale; // xmm0_4
		  int v84; // xmm7_4
		  int32_t v85; // r12d
		  int32_t v86; // r13d
		  HGRenderGraphContext *v87; // rax
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  ScriptableRenderContext *v90; // rdi
		  CBHandle *ConstantBuffer; // rax
		  Object v92; // xmm7
		  HGRenderGraph *v93; // xmm6_8
		  __int64 v94; // rdx
		  __int64 v95; // rcx
		  Object *v96; // rax
		  Object *v97; // rdi
		  __int64 v98; // rdx
		  __int64 v99; // rcx
		  TextureHandle v100; // xmm0
		  Object *v101; // rsi
		  HGRenderGraphContext *v102; // rax
		  __int64 v103; // rdx
		  __int64 v104; // rcx
		  ScriptableRenderContext *v105; // r14
		  CBHandle *v106; // rax
		  __int64 v107; // rdx
		  __int64 v108; // rcx
		  Object__Class *v109; // xmm1_8
		  Object *v110; // rsi
		  Object *v111; // rsi
		  Texture2D *blackTexture; // rax
		  __int64 v113; // rdx
		  __int64 v114; // rcx
		  unsigned __int64 v115; // r8
		  signed __int64 v116; // rtt
		  Object *v117; // rsi
		  HGRenderGraphContext *v118; // rax
		  __int64 v119; // rdx
		  __int64 v120; // rcx
		  ScriptableRenderContext *v121; // r14
		  CBHandle *v122; // rax
		  __int64 v123; // rdx
		  __int64 v124; // rcx
		  Object__Class *v125; // xmm1_8
		  Object *v126; // rsi
		  Object *v127; // rsi
		  Texture2D *v128; // rax
		  __int64 v129; // rdx
		  __int64 v130; // rcx
		  unsigned __int64 v131; // r8
		  signed __int64 v132; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v134; // rdx
		  __int64 v135; // rcx
		  Object *v136; // [rsp+50h] [rbp-3F8h] BYREF
		  int32_t width; // [rsp+58h] [rbp-3F0h]
		  int32_t height; // [rsp+5Ch] [rbp-3ECh]
		  Il2CppException *ex; // [rsp+60h] [rbp-3E8h] BYREF
		  HGRenderGraphBuilder *v140; // [rsp+68h] [rbp-3E0h]
		  CBHandle v141; // [rsp+70h] [rbp-3D8h] BYREF
		  HGRenderGraphBuilder v142; // [rsp+90h] [rbp-3B8h] BYREF
		  int32_t v143; // [rsp+B0h] [rbp-398h]
		  int32_t v144; // [rsp+B4h] [rbp-394h]
		  Object *v145; // [rsp+B8h] [rbp-390h] BYREF
		  TextureHandle v146; // [rsp+C0h] [rbp-388h] BYREF
		  Void *destination; // [rsp+D0h] [rbp-378h]
		  HGRenderGraphBuilder v148; // [rsp+D8h] [rbp-370h] BYREF
		  Void source[16]; // [rsp+F8h] [rbp-350h] BYREF
		  TextureDesc v150; // [rsp+110h] [rbp-338h] BYREF
		  TextureHandle v151; // [rsp+170h] [rbp-2D8h] BYREF
		  HGRenderGraphBuilder v152; // [rsp+180h] [rbp-2C8h] BYREF
		  TextureDesc v153; // [rsp+1A0h] [rbp-2A8h] BYREF
		  Il2CppExceptionWrapper *v154; // [rsp+200h] [rbp-248h] BYREF
		  _BYTE v155[48]; // [rsp+210h] [rbp-238h] BYREF
		  __int128 v156; // [rsp+240h] [rbp-208h]
		  __int128 v157; // [rsp+250h] [rbp-1F8h]
		  __int128 v158; // [rsp+260h] [rbp-1E8h]
		  __int128 v159; // [rsp+270h] [rbp-1D8h]
		  __int128 v160; // [rsp+280h] [rbp-1C8h]
		  TextureDesc v161; // [rsp+290h] [rbp-1B8h] BYREF
		  TextureDesc v162; // [rsp+2F0h] [rbp-158h] BYREF
		  Void v163[16]; // [rsp+350h] [rbp-F8h] BYREF
		  __m128i si128; // [rsp+360h] [rbp-E8h]
		  __m128i v165; // [rsp+370h] [rbp-D8h]
		  __int128 v166; // [rsp+380h] [rbp-C8h]
		  __int128 v167; // [rsp+390h] [rbp-B8h]
		  __int128 v168; // [rsp+3A0h] [rbp-A8h]
		  __int128 v169; // [rsp+3B0h] [rbp-98h]
		  __int128 v170; // [rsp+3C0h] [rbp-88h]
		
		  v6 = renderGraph;
		  v8 = input;
		  v9 = this;
		  memset(&v152, 0, sizeof(v152));
		  v145 = 0LL;
		  sub_18033B9D0(&v161, 0LL, 96LL);
		  sub_18033B9D0(&v150, 0LL, 96LL);
		  memset(&v148, 0, sizeof(v148));
		  v136 = 0LL;
		  sub_18033B9D0(v163, 0LL, 128LL);
		  sub_18033B9D0(&v162, 0LL, 96LL);
		  *(_OWORD *)source = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2098, 0LL) )
		  {
		    if ( !camera )
		      sub_1800D8260(v11, v10);
		    sceneRTSize_k__BackingField = camera->fields._sceneRTSize_k__BackingField;
		    m_X = sceneRTSize_k__BackingField.m_X / 2;
		    if ( !v8->enableHalfRez )
		      m_X = sceneRTSize_k__BackingField.m_X;
		    width = m_X;
		    v143 = m_X;
		    v14 = HIDWORD(*(unsigned __int64 *)&sceneRTSize_k__BackingField);
		    v15 = (int)v14 / 2;
		    if ( !v8->enableHalfRez )
		      v15 = v14;
		    height = v15;
		    v144 = v15;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v151 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v146, 0LL);
		    if ( v8->enableHalfRez )
		    {
		      if ( !v6 )
		        sub_1800D8260(v17, v16);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v142,
		        v6,
		        (String *)"DownSampleDepth",
		        &v145,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>);
		      v152 = v142;
		      ex = 0LL;
		      v140 = &v152;
		      try
		      {
		        sub_18033B9D0(&v153, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v153, m_X, v15, 0LL);
		        v150 = v153;
		        v18 = *(_OWORD *)&v153.enableRandomWrite;
		        v19 = *(_OWORD *)&v153.fastMemoryDesc.inFastMemory;
		        clearColor = v153.clearColor;
		        v150.colorFormat = v8->depthFormat;
		        v150.depthBufferBits = v8->depthBufferBits;
		        v150.name = (String *)"LowRez Depth";
		        if ( dword_18F35FD08 )
		        {
		          v21 = (((unsigned __int64)&v150.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v21 + 36190]);
		          do
		            v22 = qword_18F0BCBA0[v21 + 36190];
		          while ( v22 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v21 + 36190],
		                           v22 | (1LL << (((unsigned __int64)&v150.name >> 12) & 0x3F)),
		                           v22) );
		          clearColor = v150.clearColor;
		          v19 = *(_OWORD *)&v150.fastMemoryDesc.inFastMemory;
		          v18 = *(_OWORD *)&v150.enableRandomWrite;
		        }
		        *(_OWORD *)&v161.width = *(_OWORD *)&v150.width;
		        *(_OWORD *)&v161.colorFormat = *(_OWORD *)&v150.colorFormat;
		        *(_OWORD *)&v161.enableRandomWrite = v18;
		        *(_OWORD *)&v161.bindTextureMS = *(_OWORD *)&v150.bindTextureMS;
		        *(_OWORD *)&v161.fastMemoryDesc.inFastMemory = v19;
		        v161.clearColor = clearColor;
		        v151 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v146, v6, &v161, 0LL);
		        v23 = v145;
		        v26 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v146, &v152, &v8->sceneDepth, 0LL);
		        if ( !v23 )
		          sub_1800D8250(v25, v24);
		        v23[1] = (Object)v26;
		        v27 = v145;
		        if ( !v145 )
		          sub_1800D8250(v25, 0LL);
		        v145[2].klass = (Object__Class *)v8->visibilitySHMaterial;
		        if ( dword_18F35FD08 )
		        {
		          v28 = ((unsigned __int64)&v27[2] >> 12) & 0x1FFFFF;
		          v29 = v28 >> 6;
		          v30 = v28 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v29 + 36190]);
		          do
		            v31 = qword_18F0BCBA0[v29 + 36190];
		          while ( v31 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v29 + 36190], v31 | (1LL << v30), v31) );
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          &v146,
		          &v152,
		          &v151,
		          DepthAccess__Enum_Write,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          0.0,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v152,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields->s_DonwSampleDepthRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v154 )
		      {
		        ex = v154->ex;
		        sub_180268AE0(&ex);
		        v6 = renderGraph;
		        v8 = input;
		        v9 = this;
		        width = v143;
		        height = v144;
		        goto LABEL_21;
		      }
		      sub_180268AE0(&ex);
		    }
		LABEL_21:
		    v32 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x6Bu,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v6 )
		      sub_1800D8250(v34, v33);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v142,
		      v6,
		      (String *)"Capsule Shadow",
		      &v136,
		      v32,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
		    v148 = v142;
		    ex = 0LL;
		    v140 = &v148;
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v148, 0, 0LL);
		    v36 = v136;
		    if ( !v136 )
		      sub_1800D8250(v35, 0LL);
		    v136[9].klass = (Object__Class *)v9->fields.m_sphereMesh;
		    if ( dword_18F35FD08 )
		    {
		      v37 = ((unsigned __int64)&v36[9] >> 12) & 0x1FFFFF;
		      v38 = v37 >> 6;
		      v39 = v37 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		      do
		        v40 = qword_18F0BCBA0[v38 + 36190];
		      while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v38 + 36190], v40 | (1LL << v39), v40) );
		    }
		    v41 = v136;
		    v44 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v146, &v148, &v8->sceneDepthCopied, 0LL);
		    if ( !v41 )
		      sub_1800D8250(v43, v42);
		    *(TextureHandle *)&v41[7].monitor = v44;
		    *(TextureHandle *)&v141.bufferId = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                                          &v146,
		                                          &v8->gBufferOutput,
		                                          GBufferID__Enum_GBufferB,
		                                          0LL);
		    v45 = v136;
		    v48 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		             &v146,
		             &v148,
		             (TextureHandle *)&v141,
		             0LL);
		    if ( !v45 )
		      sub_1800D8250(v47, v46);
		    *(TextureHandle *)&v45[6].monitor = v48;
		    v49 = v136;
		    if ( !v136 )
		      sub_1800D8250(v47, 0LL);
		    v136[8].monitor = (MonitorData *)v8->visibilitySHMaterial;
		    v50 = dword_18F35FD08;
		    if ( dword_18F35FD08 )
		    {
		      v51 = ((unsigned __int64)&v49[8].monitor >> 12) & 0x1FFFFF;
		      v52 = v51 >> 6;
		      v53 = v51 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v52 + 36190]);
		      do
		        v54 = qword_18F0BCBA0[v52 + 36190];
		      while ( v54 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v52 + 36190], v54 | (1LL << v53), v54) );
		      v50 = dword_18F35FD08;
		    }
		    v55 = v136;
		    m_visibilityABLut = (Object__Class *)v9->fields.m_visibilityABLut;
		    if ( !v136 )
		      sub_1800D8250(m_visibilityABLut, 0LL);
		    v136[6].klass = m_visibilityABLut;
		    if ( v50 )
		    {
		      v57 = ((unsigned __int64)&v55[6] >> 12) & 0x1FFFFF;
		      v58 = v57 >> 6;
		      v59 = v57 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v58 + 36190]);
		      do
		        v60 = qword_18F0BCBA0[v58 + 36190];
		      while ( v60 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v58 + 36190], v60 | (1LL << v59), v60) );
		      v50 = dword_18F35FD08;
		    }
		    v61 = v136;
		    m_visibilitySHLut = (MonitorData *)v9->fields.m_visibilitySHLut;
		    if ( !v136 )
		      sub_1800D8250(m_visibilitySHLut, 0LL);
		    v136[5].monitor = m_visibilitySHLut;
		    if ( v50 )
		    {
		      v63 = ((unsigned __int64)&v61[5].monitor >> 12) & 0x1FFFFF;
		      v64 = v63 >> 6;
		      v65 = v63 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v64 + 36190]);
		      do
		        v66 = qword_18F0BCBA0[v64 + 36190];
		      while ( v66 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v64 + 36190], v66 | (1LL << v65), v66) );
		    }
		    RenderCapsuleNum = UnityEngine::HyperGryph::HGCapsuleShadowManager::GetRenderCapsuleNum(0LL);
		    if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		      sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		    if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>->rgctx_data )
		      sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>);
		    v68 = (float)RenderCapsuleNum;
		    if ( v68 >= 1365.0 )
		      v68 = 1365.0;
		    v69 = (int)v68;
		    if ( v8->enabled && v69 )
		    {
		      HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v6, 0LL);
		      if ( !HGContext )
		        sub_1800D8250(v72, v71);
		      p_renderContext = &HGContext->fields.renderContext;
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v74 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              &v141,
		              p_renderContext,
		              48 * v69 + 16,
		              0LL);
		      v75 = *(_OWORD *)&v74->bufferId;
		      ptr = (Void *)v74->ptr;
		      destination = ptr;
		      *(_OWORD *)&v142.m_RenderPass = v75;
		      v142.m_RenderGraph = (HGRenderGraph *)ptr;
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      RenderCapsuleData = UnityEngine::HyperGryph::HGCapsuleShadowManager::CullAndGetRenderCapsuleData(
		                            camera->fields.cullingViewHandle,
		                            &v142.m_RenderGraph->fields,
		                            v69,
		                            0LL);
		      *(float *)source = (float)RenderCapsuleData;
		      *(_DWORD *)&source[4] = 0;
		      *(_DWORD *)&source[8] = 0;
		      *(_DWORD *)&source[12] = 0;
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
		      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, source, 16LL, 0LL);
		      v80 = v136;
		      if ( !v136 )
		        sub_1800D8250(v79, v78);
		      *(_OWORD *)&v136[2].monitor = v75;
		      v80[3].monitor = (MonitorData *)ptr;
		      if ( RenderCapsuleData )
		      {
		        if ( !v136 )
		          sub_1800D8250(v79, v78);
		        LODWORD(v136[9].monitor) = RenderCapsuleData;
		        sphereIntervalScale = 2.0;
		        if ( v8->sphereIntervalScale <= 2.0 )
		          sphereIntervalScale = v8->sphereIntervalScale;
		        v82 = 1061997773;
		        if ( sphereIntervalScale >= 0.80000001 )
		          v82 = LODWORD(sphereIntervalScale);
		        sphereRangeScale = 5.0;
		        if ( v8->sphereRangeScale <= 5.0 )
		          sphereRangeScale = v8->sphereRangeScale;
		        v84 = 1008981770;
		        if ( sphereRangeScale >= 0.0099999998 )
		          v84 = LODWORD(sphereRangeScale);
		        sub_18033B9D0(v155, 0LL, 128LL);
		        v85 = width;
		        v86 = height;
		        *(_QWORD *)&v156 = 1046173638LL;
		        *((float *)&v156 + 2) = (float)width;
		        *((float *)&v156 + 3) = (float)height;
		        *(_QWORD *)&v157 = __PAIR64__(v84, v82);
		        *((float *)&v157 + 2) = 1.0 / (float)width;
		        *((float *)&v157 + 3) = 1.0 / (float)height;
		        *(__m128i *)v163 = _mm_load_si128((const __m128i *)&xmmword_18DC816F0);
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18DC81740);
		        v165 = _mm_load_si128((const __m128i *)&xmmword_18DC814A0);
		        v166 = v156;
		        v167 = v157;
		        v168 = v158;
		        v169 = v159;
		        v170 = v160;
		        v87 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v6, 0LL);
		        if ( !v87 )
		          sub_1800D8250(v89, v88);
		        v90 = &v87->fields.renderContext;
		        if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>->rgctx_data )
		          sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                           (CBHandle *)&v142,
		                           v90,
		                           128,
		                           0LL);
		        v92 = *(Object *)&ConstantBuffer->bufferId;
		        v93 = (HGRenderGraph *)ConstantBuffer->ptr;
		        v142.m_RenderGraph = v93;
		        if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>->rgctx_data )
		          sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v142.m_RenderGraph, v163, 128LL, 0LL);
		        v96 = v136;
		        if ( !v136 )
		          sub_1800D8250(v95, v94);
		        v136[1] = v92;
		        v96[2].klass = (Object__Class *)v93;
		        sub_18033B9D0(&v153, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v153, v85, v86, 0LL);
		        *(_OWORD *)&v150.width = *(_OWORD *)&v153.width;
		        v150.dimension = v153.dimension;
		        *(_OWORD *)&v150.enableRandomWrite = *(_OWORD *)&v153.enableRandomWrite;
		        *(_OWORD *)&v150.bindTextureMS = *(_OWORD *)&v153.bindTextureMS;
		        *(_OWORD *)&v150.fastMemoryDesc.inFastMemory = *(_OWORD *)&v153.fastMemoryDesc.inFastMemory;
		        v150.clearColor = v153.clearColor;
		        v150.colorFormat = 48;
		        v150.useMipMap = 0;
		        *(_QWORD *)&v150.filterMode = 0x100000001LL;
		        *(_OWORD *)&v162.width = *(_OWORD *)&v153.width;
		        *(_OWORD *)&v162.colorFormat = *(_OWORD *)&v150.colorFormat;
		        *(_OWORD *)&v162.enableRandomWrite = *(_OWORD *)&v150.enableRandomWrite;
		        *(_OWORD *)&v162.bindTextureMS = *(_OWORD *)&v153.bindTextureMS;
		        *(_OWORD *)&v162.fastMemoryDesc.inFastMemory = *(_OWORD *)&v153.fastMemoryDesc.inFastMemory;
		        v162.clearColor = v153.clearColor;
		        v146 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v146, v6, &v162, 0LL);
		        v97 = v136;
		        *(_OWORD *)&v141.bufferId = 0LL;
		        v100 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		                  (TextureHandle *)&v142,
		                  &v148,
		                  &v146,
		                  0,
		                  RenderBufferLoadAction__Enum_Clear,
		                  RenderBufferStoreAction__Enum_Store,
		                  (Color *)&v141,
		                  0,
		                  0LL);
		        if ( !v97 )
		          sub_1800D8250(v99, v98);
		        v97[4] = (Object)v100;
		        if ( v8->enableHalfRez )
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            (TextureHandle *)&v142,
		            &v148,
		            &v151,
		            DepthAccess__Enum_Read,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            0.0,
		            0,
		            0,
		            0LL);
		        else
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            (TextureHandle *)&v142,
		            &v148,
		            &v8->sceneDepth,
		            DepthAccess__Enum_Read,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            0.0,
		            0,
		            0,
		            0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v148,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields->s_CapsuleShadowRenderFuncV2,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
		        sub_180268AE0(&ex);
		        return;
		      }
		      v101 = v136;
		      v102 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v6, 0LL);
		      if ( !v102 )
		        sub_1800D8250(v104, v103);
		      v105 = &v102->fields.renderContext;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v106 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer((CBHandle *)&v142, v105, 0, 0LL);
		      v109 = (Object__Class *)v106->ptr;
		      if ( !v101 )
		        sub_1800D8250(v108, v107);
		      v101[1] = *(Object *)&v106->bufferId;
		      v101[2].klass = v109;
		      v110 = v136;
		      if ( !v136 )
		        sub_1800D8250(v108, v107);
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
		      LODWORD(v110[1].monitor) = 128;
		      v111 = v136;
		      blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
		      if ( !v111 )
		        sub_1800D8250(v114, v113);
		      v111[5].klass = (Object__Class *)blackTexture;
		      if ( dword_18F35FD08 )
		      {
		        v115 = (((unsigned __int64)&v111[5] >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v115 + 36190]);
		        do
		          v116 = qword_18F0BCBA0[v115 + 36190];
		        while ( v116 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v115 + 36190],
		                          v116 | (1LL << (((unsigned __int64)&v111[5] >> 12) & 0x3F)),
		                          v116) );
		      }
		    }
		    else
		    {
		      v117 = v136;
		      v118 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v6, 0LL);
		      if ( !v118 )
		        sub_1800D8250(v120, v119);
		      v121 = &v118->fields.renderContext;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v122 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer((CBHandle *)&v142, v121, 0, 0LL);
		      v125 = (Object__Class *)v122->ptr;
		      if ( !v117 )
		        sub_1800D8250(v124, v123);
		      v117[1] = *(Object *)&v122->bufferId;
		      v117[2].klass = v125;
		      v126 = v136;
		      if ( !v136 )
		        sub_1800D8250(v124, v123);
		      if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>->rgctx_data )
		        sub_1800430B0(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
		      LODWORD(v126[1].monitor) = 128;
		      v127 = v136;
		      v128 = UnityEngine::Texture2D::get_blackTexture(0LL);
		      if ( !v127 )
		        sub_1800D8250(v130, v129);
		      v127[5].klass = (Object__Class *)v128;
		      if ( dword_18F35FD08 )
		      {
		        v131 = (((unsigned __int64)&v127[5] >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v131 + 36190]);
		        do
		          v132 = qword_18F0BCBA0[v131 + 36190];
		        while ( v132 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v131 + 36190],
		                          v132 | (1LL << (((unsigned __int64)&v127[5] >> 12) & 0x3F)),
		                          v132) );
		      }
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v148,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor->static_fields->s_CapsuleShadowRenderFuncEmptyV2,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
		    sub_180268AE0(&ex);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2098, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v135, v134);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_845(Patch, (Object *)v9, v8, output, (Object *)v6, (Object *)camera, 0LL);
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189D16A48-0x0000000189D16A9C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        CapsuleShadowPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2101, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2101, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80800-0x0000000184D80830
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        CapsuleShadowPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2102, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2102, 0LL);
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
