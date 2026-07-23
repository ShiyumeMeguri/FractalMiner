using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Profiling;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ShadowMapPassConstructor : IPassConstructor // TypeDefIndex: 37888
	{
		// Fields
		private ProfilerMarker m_samplerCSM; // 0x10
		private ProfilerMarker m_samplerCharacter; // 0x18
		private ProfilerMarker m_samplerASM; // 0x20
		private ProfilerMarker m_samplerPunctual; // 0x28
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 37886
		{
			// Fields
			internal HGShadowManager shadowManager; // 0x00
			internal ScriptableRenderContext srpContext; // 0x08
			internal CullingResults cullingResults; // 0x10
			internal LightCullResult lightCullResult; // 0x20
			internal int directionalLightIndex; // 0x30
			internal int punctualLightCount; // 0x34
			internal unsafe int* punctualLightIndices; // 0x38
			internal HGSettingParameters settingParams; // 0x40
			internal unsafe HGSettingParametersCpp* settingParamsCpp; // 0x48
		}
	
		internal struct PassOutput // TypeDefIndex: 37887
		{
			// Fields
			internal ShadowResult shadowResult; // 0x00
		}
	
		// Constructors
		public ShadowMapPassConstructor() {} // 0x0000000184B396E0-0x0000000184B39780
		// ShadowMapPassConstructor()
		void HG::Rendering::Runtime::ShadowMapPassConstructor::ShadowMapPassConstructor(
		        ShadowMapPassConstructor *this,
		        MethodInfo *method)
		{
		  this->fields.m_samplerCSM.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
		                                      (String *)"ShadowMap.CSM",
		                                      1u,
		                                      MarkerFlags__Enum_Default,
		                                      0,
		                                      0LL);
		  this->fields.m_samplerCharacter.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
		                                            (String *)"ShadowMap.Character",
		                                            1u,
		                                            MarkerFlags__Enum_Default,
		                                            0,
		                                            0LL);
		  this->fields.m_samplerASM.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
		                                      (String *)"ShadowMap.ASM",
		                                      1u,
		                                      MarkerFlags__Enum_Default,
		                                      0,
		                                      0LL);
		  this->fields.m_samplerPunctual.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
		                                           (String *)"ShadowMap.Punctual",
		                                           1u,
		                                           MarkerFlags__Enum_Default,
		                                           0,
		                                           0LL);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B550B8-0x0000000189B5510C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ShadowMapPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2215, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2215, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B55064-0x0000000189B550B8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ShadowMapPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2216, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2216, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B53BF8-0x0000000189B55010
		// Void ConstructPass(ShadowMapPassConstructor+PassInput ByRef, ShadowMapPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=4 #try_helpers=1
		void HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
		        ShadowMapPassConstructor *this,
		        ShadowMapPassConstructor_PassInput *input,
		        ShadowMapPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ShadowMapPassConstructor_PassInput *v7; // r15
		  ShadowMapPassConstructor *v8; // rsi
		  HGShadowManager *shadowManager; // r12
		  HGSettingParameters *settingParams; // r13
		  ScriptableRenderContext v11; // rbx
		  MethodInfo *v12; // rdx
		  ProfilerMarker_AutoScope v13; // rdx
		  ProfilerMarker_AutoScope v14; // rcx
		  HGCamera *v15; // r14
		  int32_t directionalLightIndex; // ecx
		  HGRenderGraph *v17; // rbx
		  MethodInfo *v18; // rdx
		  ProfilerMarker_AutoScope v19; // rdx
		  ProfilerMarker_AutoScope v20; // rcx
		  int32_t v21; // eax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  MethodInfo *v24; // rdx
		  float v25; // ecx
		  ProfilerMarker_AutoScope v26; // rdx
		  ProfilerMarker_AutoScope v27; // rcx
		  HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // rcx
		  MethodInfo *v29; // rdx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  Camera *v33; // rbx
		  HGASMManager *v34; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  HGASMManager *v37; // rbx
		  Camera *v38; // rsi
		  Camera *v39; // rsi
		  HGASMManager *CachedASMManager; // rax
		  HGASMManager *v41; // rsi
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  Component *v44; // rbx
		  Transform *transform; // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  Vector3 *position; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  __int64 v51; // xmm10_8
		  float z; // r12d
		  __int128 v53; // xmm1
		  void (__fastcall *v54)(Matrix4x4 *, __int128 *); // rax
		  __int128 v55; // xmm11
		  __int128 v56; // xmm12
		  __int128 v57; // xmm13
		  __int128 v58; // xmm14
		  float (__fastcall *v59)(Component *); // rax
		  float v60; // xmm0_4
		  Beyond::DampingMath *v61; // rcx
		  float v62; // xmm7_4
		  void (__fastcall *v63)(Component *); // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  __int64 v66; // r8
		  __int64 v67; // r9
		  float v68; // xmm6_4
		  __int64 (__fastcall *v69)(Component *); // rax
		  int v70; // r12d
		  int (__fastcall *v71)(Component *); // rax
		  float v72; // xmm1_4
		  Beyond::DampingMath *v73; // rcx
		  Beyond::DampingMath *v74; // rcx
		  float v75; // xmm6_4
		  __m128i si128; // xmm8
		  Vector3__Array *m_frustumCorners; // rax
		  float v78; // xmm7_4
		  __m128i v79; // xmm6
		  float (__fastcall *v80)(Component *); // rax
		  float v81; // xmm0_4
		  Vector3__Array *m_frustumCornersForIndirect; // rax
		  float v83; // r12d
		  __m128 v84; // xmm0
		  __int64 v85; // rdx
		  __int64 v86; // rcx
		  Transform *v87; // rbx
		  void (__fastcall *v88)(Transform *, Vector4 *); // rax
		  void (__fastcall *v89)(Vector4 *, Vector4 *, Vector4 *, __int128 *); // rax
		  Vector3__Array *v90; // rdx
		  Vector2__Array *v91; // rcx
		  __int64 v92; // r8
		  __int128 v93; // xmm6
		  __int128 v94; // xmm7
		  __int128 v95; // xmm8
		  __int128 v96; // xmm9
		  Vector2__Array *m_frustumVerts; // rax
		  float y; // xmm1_4
		  Vector2__Array *m_frustumVertsForIndirect; // rax
		  float v100; // xmm1_4
		  int i; // ebx
		  Vector3__Array *v102; // r12
		  float v103; // xmm1_4
		  float v104; // xmm0_4
		  __int64 v105; // rdx
		  __int64 v106; // rcx
		  __int64 v107; // r8
		  __m128 v108; // xmm0
		  __m128 v109; // xmm1
		  unsigned __int32 v110; // xmm2_4
		  __int64 v111; // rcx
		  Vector3__Array *m_frustumCornersLightSpace; // r12
		  Vector3__Array *v113; // rcx
		  float v114; // xmm1_4
		  float v115; // xmm0_4
		  __int64 v116; // rdx
		  __int64 v117; // rcx
		  __int64 v118; // r8
		  __m128 v119; // xmm0
		  __m128 v120; // xmm1
		  unsigned __int32 v121; // xmm2_4
		  __int64 v122; // rcx
		  Vector2__Array *v123; // rcx
		  Vector3__Array *v124; // rdx
		  float v125; // xmm0_4
		  __int64 v126; // rax
		  Vector3__Array *v127; // r12
		  float v128; // xmm1_4
		  float v129; // xmm0_4
		  __int64 v130; // rdx
		  __int64 v131; // rcx
		  __int64 v132; // r8
		  __m128 v133; // xmm0
		  __m128 v134; // xmm1
		  unsigned __int32 v135; // xmm2_4
		  __int64 v136; // rcx
		  Vector3__Array *m_frustumCornersLightSpaceForIndirect; // r12
		  Vector3__Array *v138; // rcx
		  float v139; // xmm1_4
		  float v140; // xmm0_4
		  __int64 v141; // rdx
		  __int64 v142; // rcx
		  __m128 v143; // xmm0
		  __m128 v144; // xmm1
		  unsigned __int32 v145; // xmm2_4
		  __int64 v146; // rcx
		  float v147; // xmm0_4
		  __int64 v148; // rax
		  ASMTileManager *m_asmTileManager; // rcx
		  ILFixDynamicMethodWrapper_2 *v150; // rax
		  __int64 v151; // rdx
		  __int64 v152; // rcx
		  Camera *v153; // rbx
		  HGASMManager *ASMManager; // rax
		  __int64 v155; // rdx
		  __int64 v156; // rcx
		  HGHDPLSCharacterShadowManager *m_hdplsCharacterShadowManager; // rsi
		  float v158; // ecx
		  int32_t *punctualLightIndices; // r12
		  int32_t punctualLightCount; // r15d
		  bool v161; // bl
		  bool IsScreenSpaceShadowMaskEnabled; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v164; // rdx
		  __int64 v165; // rcx
		  bool shouldRenderCSMShadowMap; // [rsp+50h] [rbp-288h] BYREF
		  Vector4 lightCullResult; // [rsp+60h] [rbp-278h] BYREF
		  Il2CppException *ex; // [rsp+70h] [rbp-268h] BYREF
		  _QWORD *v169; // [rsp+78h] [rbp-260h]
		  _QWORD v170[2]; // [rsp+80h] [rbp-258h] BYREF
		  Vector4 cullingResults; // [rsp+90h] [rbp-248h] BYREF
		  HGShadowManager *v172; // [rsp+A0h] [rbp-238h]
		  Vector4 v173; // [rsp+B0h] [rbp-228h] BYREF
		  Vector4 v174; // [rsp+C0h] [rbp-218h] BYREF
		  Vector4 v175; // [rsp+D0h] [rbp-208h] BYREF
		  HGSettingParameters *v176; // [rsp+E0h] [rbp-1F8h]
		  float v177; // [rsp+E8h] [rbp-1F0h]
		  Matrix4x4 v178; // [rsp+F0h] [rbp-1E8h] BYREF
		  ShadowResult shadowResult; // [rsp+130h] [rbp-1A8h] BYREF
		  __int128 v180; // [rsp+170h] [rbp-168h] BYREF
		  __int128 v181; // [rsp+180h] [rbp-158h]
		  __int128 v182; // [rsp+190h] [rbp-148h]
		  __int128 v183; // [rsp+1A0h] [rbp-138h]
		  Il2CppExceptionWrapper *v184; // [rsp+1B0h] [rbp-128h] BYREF
		  Il2CppExceptionWrapper *v185; // [rsp+1B8h] [rbp-120h] BYREF
		  Il2CppExceptionWrapper *v186; // [rsp+1C0h] [rbp-118h] BYREF
		  Vector4 v187; // [rsp+1D0h] [rbp-108h] BYREF
		  Vector4 v188; // [rsp+1E0h] [rbp-F8h] BYREF
		  Vector4 v189; // [rsp+1F0h] [rbp-E8h] BYREF
		  Vector4 v190; // [rsp+200h] [rbp-D8h] BYREF
		
		  v7 = input;
		  v8 = this;
		  shouldRenderCSMShadowMap = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2217, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2217, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v165, v164);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_890(
		      Patch,
		      (Object *)v8,
		      v7,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    shadowManager = v7->shadowManager;
		    v172 = v7->shadowManager;
		    settingParams = v7->settingParams;
		    v176 = settingParams;
		    v11.m_Ptr = v7->srpContext.m_Ptr;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    HG::Rendering::Runtime::HGShadowConstantBufferUtils::AllocateShadowBuffer(v11, 0LL);
		    memset(&shadowResult, 0, sizeof(shadowResult));
		    v170[0] = Unity::Profiling::ProfilerMarker::Auto(&v8->fields.m_samplerCSM, v12).m_Ptr;
		    ex = 0LL;
		    v169 = v170;
		    try
		    {
		      if ( !shadowManager )
		        sub_1800D8250(v14.m_Ptr, v13.m_Ptr);
		      v15 = camera;
		      HG::Rendering::Runtime::HGShadowManager::FrameSetup(shadowManager, v7, &shouldRenderCSMShadowMap, camera, 0LL);
		      HG::Rendering::Runtime::HGShadowManager::ConfigureDirectionalShadowMapTextures(
		        shadowManager,
		        settingParams,
		        camera,
		        shouldRenderCSMShadowMap,
		        0LL);
		      directionalLightIndex = v7->directionalLightIndex;
		      lightCullResult = (Vector4)v7->lightCullResult;
		      cullingResults = (Vector4)v7->cullingResults;
		      v17 = renderGraph;
		      HG::Rendering::Runtime::HGShadowManager::RenderShadows(
		        shadowManager,
		        renderGraph,
		        camera,
		        (CullingResults *)&cullingResults,
		        (LightCullResult *)&lightCullResult,
		        directionalLightIndex,
		        shouldRenderCSMShadowMap,
		        &shadowResult,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v184 )
		    {
		      ex = v184->ex;
		      sub_180205890(&ex);
		      v15 = camera;
		      v7 = input;
		      v8 = this;
		      shadowManager = v172;
		      settingParams = v176;
		      v17 = renderGraph;
		      goto LABEL_6;
		    }
		    sub_180205890(&ex);
		LABEL_6:
		    v170[0] = Unity::Profiling::ProfilerMarker::Auto(&v8->fields.m_samplerCharacter, v18).m_Ptr;
		    ex = 0LL;
		    v169 = v170;
		    try
		    {
		      if ( !shadowManager )
		        sub_1800D8250(v20.m_Ptr, v19.m_Ptr);
		      HG::Rendering::Runtime::HGShadowManager::CharacterShadowFrameSetup(shadowManager, settingParams, 0LL);
		      v21 = v7->directionalLightIndex;
		      lightCullResult = (Vector4)v7->lightCullResult;
		      cullingResults = (Vector4)v7->cullingResults;
		      HG::Rendering::Runtime::HGShadowManager::RenderCharacterShadows(
		        shadowManager,
		        v17,
		        v15,
		        (CullingResults *)&cullingResults,
		        (LightCullResult *)&lightCullResult,
		        v21,
		        &shadowResult,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v185 )
		    {
		      ex = v185->ex;
		      sub_180205890(&ex);
		      v15 = camera;
		      v7 = input;
		      v8 = this;
		      shadowManager = v172;
		      settingParams = v176;
		      v17 = renderGraph;
		      goto LABEL_10;
		    }
		    sub_180205890(&ex);
		LABEL_10:
		    if ( !settingParams )
		      goto LABEL_142;
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._hdplsCharacterShadowEnabled_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		      && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._enableScreenSpaceShadowMask_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      if ( TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->instance )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        if ( HG::Rendering::Runtime::HGCharacters::get_hdplsRenderCount(0LL) > 0 )
		        {
		          v25 = *(float *)&v7->lightCullResult.visibleLightCount;
		          *(_QWORD *)&lightCullResult.x = v7->lightCullResult.visibleLightsPtr;
		          lightCullResult.z = v25;
		          LODWORD(lightCullResult.w) = 1;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		          HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::ScanHDPLSCandidateLights(
		            (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&lightCullResult,
		            v15,
		            settingParams,
		            0LL);
		        }
		      }
		    }
		    v170[0] = Unity::Profiling::ProfilerMarker::Auto(&v8->fields.m_samplerPunctual, v24).m_Ptr;
		    ex = 0LL;
		    v169 = v170;
		    try
		    {
		      if ( !v7->shadowManager )
		        sub_1800D8250(v27.m_Ptr, v26.m_Ptr);
		      m_punctualLightShadowManagerV2 = v7->shadowManager->fields.m_punctualLightShadowManagerV2;
		      if ( !m_punctualLightShadowManagerV2 )
		        sub_1800D8250(0LL, v26.m_Ptr);
		      HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::RenderPunctualLightShadows(
		        m_punctualLightShadowManagerV2,
		        v17,
		        v15,
		        settingParams,
		        &shadowResult,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v186 )
		    {
		      ex = v186->ex;
		      sub_180205890(&ex);
		      v15 = camera;
		      v7 = input;
		      v8 = this;
		      shadowManager = v172;
		      settingParams = v176;
		      goto LABEL_21;
		    }
		    sub_180205890(&ex);
		LABEL_21:
		    v170[0] = Unity::Profiling::ProfilerMarker::Auto(&v8->fields.m_samplerASM, v29).m_Ptr;
		    ex = 0LL;
		    v169 = v170;
		    if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            settingParams->fields._asmEnabled_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		      goto LABEL_164;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v15, 0LL);
		    if ( !InterpolatedPhase )
		      sub_1800D8250(v31, v30);
		    if ( InterpolatedPhase->fields.shadowConfig.disableAsm )
		    {
		LABEL_164:
		      if ( !v15 )
		        sub_1800D8250(v31, v30);
		      v153 = v15->fields.camera;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      ASMManager = HG::Rendering::Runtime::HGASMManager::GetASMManager(v153, 0LL);
		      if ( !ASMManager )
		        sub_1800D8250(v156, v155);
		      HG::Rendering::Runtime::HGASMManager::SkipRenderASM(ASMManager, renderGraph, 0LL);
		      sub_180205890(&ex);
		    }
		    else
		    {
		      if ( !v15 )
		        sub_1800D8250(v31, v30);
		      v33 = v15->fields.camera;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v34 = HG::Rendering::Runtime::HGASMManager::GetASMManager(v33, 0LL);
		      v37 = v34;
		      if ( !v34 )
		        sub_1800D8250(v36, v35);
		      HG::Rendering::Runtime::HGASMManager::BeginFrame(v34, v15, settingParams, 0LL);
		      HG::Rendering::Runtime::HGASMManager::Render(v37, renderGraph, v7->srpContext, v15, 0LL);
		      if ( v37->fields.shouldSwapManagers )
		      {
		        v38 = v15->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		        HG::Rendering::Runtime::HGASMManager::SwapASMManager(v38, 0LL);
		      }
		      v39 = v15->fields.camera;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      CachedASMManager = HG::Rendering::Runtime::HGASMManager::GetCachedASMManager(v39, 0LL);
		      v41 = v37;
		      if ( CachedASMManager )
		        v41 = CachedASMManager;
		      if ( HG::Rendering::Runtime::HGASMManager::GetASMUpdateMode(v37, 0LL) == HGASMManager_ASMUpdateMode__Enum_Slow
		        || HG::Rendering::Runtime::HGASMManager::GetASMUpdateMode(v37, 0LL) == HGASMManager_ASMUpdateMode__Enum_Stop )
		      {
		        if ( v41 == v37 )
		        {
		          if ( !v41 )
		            sub_1800D8250(v43, v42);
		        }
		        else
		        {
		          v44 = (Component *)v15->fields.camera;
		          if ( !v44 )
		            sub_1800D8250(0LL, v42);
		          transform = UnityEngine::Component::get_transform(v44, 0LL);
		          if ( !transform )
		            sub_1800D8250(v47, v46);
		          position = UnityEngine::Transform::get_position((Vector3 *)&v173, transform, 0LL);
		          if ( !v41 )
		            sub_1800D8250(v50, v49);
		          v51 = *(_QWORD *)&position->x;
		          *(_QWORD *)&v174.x = *(_QWORD *)&position->x;
		          z = position->z;
		          v177 = z;
		          if ( IFix::WrappersManagerImpl::IsPatched(2075, 0LL) )
		          {
		            v150 = IFix::WrappersManagerImpl::GetPatch(2075, 0LL);
		            if ( !v150 )
		              sub_1800D8250(v152, v151);
		            *(_QWORD *)&v173.x = v51;
		            v173.z = z;
		            IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_836(v150, (Object *)v41, (Object *)v44, (Vector3 *)&v173, 0LL);
		          }
		          else
		          {
		            *(_OWORD *)&v178.m00 = *(_OWORD *)&v41->fields.m_lightToWorld.m00;
		            *(_OWORD *)&v178.m01 = *(_OWORD *)&v41->fields.m_lightToWorld.m01;
		            *(_OWORD *)&v178.m02 = *(_OWORD *)&v41->fields.m_lightToWorld.m02;
		            v53 = *(_OWORD *)&v41->fields.m_lightToWorld.m03;
		            *(_OWORD *)&v178.m03 = v53;
		            sub_18033B9D0(&v180, 0LL, 64LL);
		            v54 = (void (__fastcall *)(Matrix4x4 *, __int128 *))qword_18F36FA60;
		            if ( !qword_18F36FA60 )
		            {
		              v54 = (void (__fastcall *)(Matrix4x4 *, __int128 *))sub_180059EA0(
		                                                                    "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine."
		                                                                    "Matrix4x4&,UnityEngine.Matrix4x4&)");
		              qword_18F36FA60 = (__int64)v54;
		            }
		            v54(&v178, &v180);
		            v55 = v180;
		            v56 = v181;
		            v57 = v182;
		            v58 = v183;
		            v59 = (float (__fastcall *)(Component *))qword_18F36F0D0;
		            if ( !qword_18F36F0D0 )
		            {
		              v59 = (float (__fastcall *)(Component *))sub_180059EA0("UnityEngine.Camera::get_fieldOfView()");
		              qword_18F36F0D0 = (__int64)v59;
		            }
		            v60 = (float)((float)(v59(v44) * 0.5) / 180.0) * 3.1415927;
		            Beyond::DampingMath::cosf(v61, *(float *)&v53);
		            v62 = v60;
		            v63 = (void (__fastcall *)(Component *))qword_18F36F0D0;
		            if ( !qword_18F36F0D0 )
		            {
		              v63 = (void (__fastcall *)(Component *))sub_180059EA0("UnityEngine.Camera::get_fieldOfView()");
		              qword_18F36F0D0 = (__int64)v63;
		            }
		            v63(v44);
		            v68 = sub_180338A80(v65, v64, v66, v67);
		            v69 = (__int64 (__fastcall *)(Component *))qword_18F36F180;
		            if ( !qword_18F36F180 )
		            {
		              v69 = (__int64 (__fastcall *)(Component *))sub_180059EA0("UnityEngine.Camera::get_pixelWidth()");
		              qword_18F36F180 = (__int64)v69;
		            }
		            v70 = v69(v44);
		            v71 = (int (__fastcall *)(Component *))qword_18F36F188;
		            if ( !qword_18F36F188 )
		            {
		              v71 = (int (__fastcall *)(Component *))sub_180059EA0("UnityEngine.Camera::get_pixelHeight()");
		              qword_18F36F188 = (__int64)v71;
		            }
		            v72 = (float)v71(v44);
		            Beyond::DampingMath::fast_atan(v73, v72);
		            Beyond::DampingMath::cosf(v74, v72);
		            v75 = (float)((float)v70 * v68) / v72;
		            si128 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		            if ( v75 <= v62 )
		              v62 = v75;
		            m_frustumCorners = v41->fields.m_frustumCorners;
		            v78 = v62 * TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius;
		            lightCullResult = (Vector4)si128;
		            UnityEngine::Camera::CalculateFrustumCorners(
		              (Camera *)v44,
		              (Rect *)&lightCullResult,
		              v78,
		              Camera_MonoOrStereoscopicEye__Enum_Mono,
		              m_frustumCorners,
		              0LL);
		            v79 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		            v80 = (float (__fastcall *)(Component *))qword_18F36F0C0;
		            if ( !qword_18F36F0C0 )
		            {
		              v80 = (float (__fastcall *)(Component *))sub_180059EA0("UnityEngine.Camera::get_farClipPlane()");
		              qword_18F36F0C0 = (__int64)v80;
		            }
		            v81 = v80(v44);
		            m_frustumCornersForIndirect = v41->fields.m_frustumCornersForIndirect;
		            lightCullResult = (Vector4)v79;
		            UnityEngine::Camera::CalculateFrustumCorners(
		              (Camera *)v44,
		              (Rect *)&lightCullResult,
		              v81,
		              Camera_MonoOrStereoscopicEye__Enum_Mono,
		              m_frustumCornersForIndirect,
		              0LL);
		            *(_QWORD *)&cullingResults.x = *(_QWORD *)&v174.x;
		            v83 = v177;
		            *(_QWORD *)&cullingResults.z = LODWORD(v177) | 0x3F80000000000000LL;
		            lightCullResult = cullingResults;
		            *(_OWORD *)&v178.m00 = v55;
		            *(_OWORD *)&v178.m01 = v56;
		            *(_OWORD *)&v178.m02 = v57;
		            *(_OWORD *)&v178.m03 = v58;
		            v84 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
		                                                             &v175,
		                                                             &v178,
		                                                             &lightCullResult,
		                                                             0LL));
		            *(_QWORD *)&v41->fields.m_cameraPosLightSpace.x = _mm_unpacklo_ps(v84, _mm_shuffle_ps(v84, v84, 85)).m128_u64[0];
		            LODWORD(v41->fields.m_cameraPosLightSpace.z) = _mm_shuffle_ps(v84, v84, 170).m128_u32[0];
		            v87 = UnityEngine::Component::get_transform(v44, 0LL);
		            if ( !v87 )
		              sub_1800D8250(v86, v85);
		            lightCullResult = 0LL;
		            v88 = (void (__fastcall *)(Transform *, Vector4 *))qword_18F370120;
		            if ( !qword_18F370120 )
		            {
		              v88 = (void (__fastcall *)(Transform *, Vector4 *))sub_180059EA0(
		                                                                   "UnityEngine.Transform::get_localRotation_Injected(Uni"
		                                                                   "tyEngine.Quaternion&)");
		              qword_18F370120 = (__int64)v88;
		            }
		            v88(v87, &lightCullResult);
		            *(Vector3 *)&v174.x = *UnityEngine::Vector3::get_one((Vector3 *)&cullingResults, 0LL);
		            *(_QWORD *)&v173.x = v51;
		            v173.z = v83;
		            sub_18033B9D0(&v180, 0LL, 64LL);
		            v89 = (void (__fastcall *)(Vector4 *, Vector4 *, Vector4 *, __int128 *))qword_18F36FA58;
		            if ( !qword_18F36FA58 )
		            {
		              v89 = (void (__fastcall *)(Vector4 *, Vector4 *, Vector4 *, __int128 *))sub_180059EA0(
		                                                                                        "UnityEngine.Matrix4x4::TRS_Injec"
		                                                                                        "ted(UnityEngine.Vector3&,UnityEn"
		                                                                                        "gine.Quaternion&,UnityEngine.Vec"
		                                                                                        "tor3&,UnityEngine.Matrix4x4&)");
		              qword_18F36FA58 = (__int64)v89;
		            }
		            v89(&v173, &lightCullResult, &v174, &v180);
		            v93 = v180;
		            v94 = v181;
		            v95 = v182;
		            v96 = v183;
		            m_frustumVerts = v41->fields.m_frustumVerts;
		            y = v41->fields.m_cameraPosLightSpace.y;
		            if ( !m_frustumVerts )
		              sub_1800D8250(v91, v90);
		            if ( !m_frustumVerts->max_length.size )
		              sub_1800D2AA0(v91, v90, v92);
		            m_frustumVerts->vector[0].x = v41->fields.m_cameraPosLightSpace.x;
		            m_frustumVerts->vector[0].y = y;
		            m_frustumVertsForIndirect = v41->fields.m_frustumVertsForIndirect;
		            v100 = v41->fields.m_cameraPosLightSpace.y;
		            if ( !m_frustumVertsForIndirect )
		              sub_1800D8250(v91, v90);
		            if ( !m_frustumVertsForIndirect->max_length.size )
		              sub_1800D2AA0(v91, v90, v92);
		            m_frustumVertsForIndirect->vector[0].x = v41->fields.m_cameraPosLightSpace.x;
		            m_frustumVertsForIndirect->vector[0].y = v100;
		            for ( i = 0; i < 4; ++i )
		            {
		              v102 = v41->fields.m_frustumCorners;
		              if ( !v102 )
		                sub_1800D8250(v91, v90);
		              if ( (unsigned int)i >= v102->max_length.size )
		                sub_1800D2AA0(v91, v90, v92);
		              v103 = v102->vector[i].y;
		              v104 = v102->vector[i].z;
		              cullingResults.x = v102->vector[i].x;
		              cullingResults.y = v103;
		              *(_QWORD *)&cullingResults.z = LODWORD(v104) | 0x3F80000000000000LL;
		              v175 = cullingResults;
		              *(_OWORD *)&v178.m00 = v93;
		              *(_OWORD *)&v178.m01 = v94;
		              *(_OWORD *)&v178.m02 = v95;
		              *(_OWORD *)&v178.m03 = v96;
		              v108 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
		                                                                &v187,
		                                                                &v178,
		                                                                &v175,
		                                                                0LL));
		              v109 = _mm_shuffle_ps(v108, v108, 85);
		              v110 = _mm_shuffle_ps(v108, v108, 170).m128_u32[0];
		              if ( (unsigned int)i >= v102->max_length.size )
		                sub_1800D2AA0(v106, v105, v107);
		              v111 = i;
		              *(_QWORD *)&v102->vector[v111].x = _mm_unpacklo_ps(v108, v109).m128_u64[0];
		              LODWORD(v102->vector[v111].z) = v110;
		              m_frustumCornersLightSpace = v41->fields.m_frustumCornersLightSpace;
		              v113 = v41->fields.m_frustumCorners;
		              if ( !v113 )
		                sub_1800D8250(0LL, v105);
		              if ( (unsigned int)i >= v113->max_length.size )
		                sub_1800D2AA0(v113, v105, v107);
		              v114 = v113->vector[i].y;
		              v115 = v113->vector[i].z;
		              v173.x = v113->vector[i].x;
		              *(_QWORD *)&v173.y = __PAIR64__(LODWORD(v115), LODWORD(v114));
		              v173.w = 1.0;
		              v175 = v173;
		              *(_OWORD *)&v178.m00 = v55;
		              *(_OWORD *)&v178.m01 = v56;
		              *(_OWORD *)&v178.m02 = v57;
		              *(_OWORD *)&v178.m03 = v58;
		              v119 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
		                                                                &v188,
		                                                                &v178,
		                                                                &v175,
		                                                                0LL));
		              v120 = _mm_shuffle_ps(v119, v119, 85);
		              v121 = _mm_shuffle_ps(v119, v119, 170).m128_u32[0];
		              if ( !m_frustumCornersLightSpace )
		                sub_1800D8250(v117, v116);
		              if ( (unsigned int)i >= m_frustumCornersLightSpace->max_length.size )
		                sub_1800D2AA0(v117, v116, v118);
		              v122 = i;
		              *(_QWORD *)&m_frustumCornersLightSpace->vector[v122].x = _mm_unpacklo_ps(v119, v120).m128_u64[0];
		              LODWORD(m_frustumCornersLightSpace->vector[v122].z) = v121;
		              v123 = v41->fields.m_frustumVerts;
		              v124 = v41->fields.m_frustumCornersLightSpace;
		              if ( !v124 )
		                sub_1800D8250(v123, 0LL);
		              if ( (unsigned int)i >= v124->max_length.size )
		                sub_1800D2AA0(v123, v124, v118);
		              v125 = v124->vector[i].y;
		              if ( !v123 )
		                sub_1800D8250(0LL, v124);
		              v126 = i + 1LL;
		              if ( (unsigned int)v126 >= v123->max_length.size )
		                sub_1800D2AA0(v123, v124, v118);
		              v123->vector[v126].x = v124->vector[i].x;
		              v123->vector[v126].y = v125;
		              v127 = v41->fields.m_frustumCornersForIndirect;
		              if ( !v127 )
		                sub_1800D8250(v123, v124);
		              if ( (unsigned int)i >= v127->max_length.size )
		                sub_1800D2AA0(v123, v124, v118);
		              v128 = v127->vector[i].y;
		              v129 = v127->vector[i].z;
		              v174.x = v127->vector[i].x;
		              *(_QWORD *)&v174.y = __PAIR64__(LODWORD(v129), LODWORD(v128));
		              v174.w = 1.0;
		              v175 = v174;
		              *(_OWORD *)&v178.m00 = v93;
		              *(_OWORD *)&v178.m01 = v94;
		              *(_OWORD *)&v178.m02 = v95;
		              *(_OWORD *)&v178.m03 = v96;
		              v133 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
		                                                                &v189,
		                                                                &v178,
		                                                                &v175,
		                                                                0LL));
		              v134 = _mm_shuffle_ps(v133, v133, 85);
		              v135 = _mm_shuffle_ps(v133, v133, 170).m128_u32[0];
		              if ( (unsigned int)i >= v127->max_length.size )
		                sub_1800D2AA0(v131, v130, v132);
		              v136 = i;
		              *(_QWORD *)&v127->vector[v136].x = _mm_unpacklo_ps(v133, v134).m128_u64[0];
		              LODWORD(v127->vector[v136].z) = v135;
		              m_frustumCornersLightSpaceForIndirect = v41->fields.m_frustumCornersLightSpaceForIndirect;
		              v138 = v41->fields.m_frustumCornersForIndirect;
		              if ( !v138 )
		                sub_1800D8250(0LL, v130);
		              if ( (unsigned int)i >= v138->max_length.size )
		                sub_1800D2AA0(v138, v130, v132);
		              v139 = v138->vector[i].y;
		              v140 = v138->vector[i].z;
		              lightCullResult.x = v138->vector[i].x;
		              lightCullResult.y = v139;
		              lightCullResult.z = v140;
		              lightCullResult.w = 1.0;
		              v175 = lightCullResult;
		              *(_OWORD *)&v178.m00 = v55;
		              *(_OWORD *)&v178.m01 = v56;
		              *(_OWORD *)&v178.m02 = v57;
		              *(_OWORD *)&v178.m03 = v58;
		              v143 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
		                                                                &v190,
		                                                                &v178,
		                                                                &v175,
		                                                                0LL));
		              v144 = _mm_shuffle_ps(v143, v143, 85);
		              v145 = _mm_shuffle_ps(v143, v143, 170).m128_u32[0];
		              if ( !m_frustumCornersLightSpaceForIndirect )
		                sub_1800D8250(v142, v141);
		              if ( (unsigned int)i >= m_frustumCornersLightSpaceForIndirect->max_length.size )
		                sub_1800D2AA0(v142, v141, v92);
		              v146 = i;
		              *(_QWORD *)&m_frustumCornersLightSpaceForIndirect->vector[v146].x = _mm_unpacklo_ps(v143, v144).m128_u64[0];
		              LODWORD(m_frustumCornersLightSpaceForIndirect->vector[v146].z) = v145;
		              v91 = v41->fields.m_frustumVertsForIndirect;
		              v90 = v41->fields.m_frustumCornersLightSpaceForIndirect;
		              if ( !v90 )
		                sub_1800D8250(v91, 0LL);
		              if ( (unsigned int)i >= v90->max_length.size )
		                sub_1800D2AA0(v91, v90, v92);
		              v147 = v90->vector[i].y;
		              if ( !v91 )
		                sub_1800D8250(0LL, v90);
		              v148 = i + 1LL;
		              if ( (unsigned int)v148 >= v91->max_length.size )
		                sub_1800D2AA0(v91, v90, v92);
		              v91->vector[v148].x = v90->vector[i].x;
		              v91->vector[v148].y = v147;
		            }
		            m_asmTileManager = v41->fields.m_asmTileManager;
		            if ( !m_asmTileManager )
		              sub_1800D8250(0LL, v90);
		            HG::Rendering::Runtime::ASMTileManager::SetFrustumVerts(
		              m_asmTileManager,
		              v41->fields.m_frustumVerts,
		              v41->fields.m_frustumVertsForIndirect,
		              0LL);
		          }
		        }
		      }
		      else
		      {
		        v41 = v37;
		      }
		      HG::Rendering::Runtime::HGASMManager::SetCachedData(v41, renderGraph, 0LL);
		      sub_180205890(&ex);
		      shadowManager = v172;
		    }
		    if ( !shadowManager )
		      goto LABEL_142;
		    m_hdplsCharacterShadowManager = shadowManager->fields.m_hdplsCharacterShadowManager;
		    v158 = *(float *)&v7->lightCullResult.visibleLightCount;
		    *(_QWORD *)&lightCullResult.x = v7->lightCullResult.visibleLightsPtr;
		    lightCullResult.z = v158;
		    LODWORD(lightCullResult.w) = 1;
		    punctualLightIndices = v7->punctualLightIndices;
		    punctualLightCount = v7->punctualLightCount;
		    v161 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             settingParams->fields._enableScreenSpaceShadowMask_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		    IsScreenSpaceShadowMaskEnabled = HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
		                                       v161,
		                                       0LL);
		    if ( !m_hdplsCharacterShadowManager )
		LABEL_142:
		      sub_1800D8250(v23, v22);
		    v175 = lightCullResult;
		    HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::FrameSetup(
		      m_hdplsCharacterShadowManager,
		      renderGraph,
		      settingParams,
		      (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v175,
		      v15,
		      punctualLightIndices,
		      punctualLightCount,
		      IsScreenSpaceShadowMaskEnabled,
		      0LL);
		    output->shadowResult = shadowResult;
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B55010-0x0000000189B55064
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ShadowMapPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2220, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2220, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FED0-0x0000000184D7FF00
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ShadowMapPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2221, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2221, 0LL);
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
