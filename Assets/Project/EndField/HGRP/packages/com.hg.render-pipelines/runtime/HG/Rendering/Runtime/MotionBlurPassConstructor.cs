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
	internal class MotionBlurPassConstructor : IPassConstructor // TypeDefIndex: 38360
	{
		// Fields
		public uint frameIndex; // 0x10
		private const uint FRAME_MOD = 5; // Metadata: 0x02303C83
		private const int PARAMETERS_FLOAT_NUM = 16; // Metadata: 0x02303C84
		private int m_packingKernel; // 0x14
		private int m_tileMaxKernel; // 0x18
		private int m_tileNeighborKernel; // 0x1C
		private int m_motionBlurKernel; // 0x20
		private int m_blendMotionBlurKernel; // 0x24
		private float[] m_parameters; // 0x28
		private float[] m_historyTimes; // 0x30
		private Vector2Int m_historyScreenSize; // 0x38
		private TextureHandle[] m_historyTextures; // 0x40
		private CBHandle m_cb; // 0x48
		private ComputeShader m_motionBlurCS; // 0x60
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38357
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal HGSettingParameters settingParameters; // 0x30
		}
	
		internal struct PassOutput // TypeDefIndex: 38358
		{
			// Fields
			internal TextureHandle result; // 0x00
		}
	
		private class MotionBlurPassData // TypeDefIndex: 38359
		{
			// Fields
			public int packKernel; // 0x10
			public int tileMaxKernel; // 0x14
			public int tileNeighborKernel; // 0x18
			public int motionBlurKernel; // 0x1C
			public int blendMotionBlurKernel; // 0x20
			public int packingThreadX; // 0x24
			public int packingThreadY; // 0x28
			public int tileMaxThreadX; // 0x2C
			public int tileMaxThreadY; // 0x30
			public int tileNeighborThreadX; // 0x34
			public int tileNeighborThreadY; // 0x38
			public int motionBlurThreadX; // 0x3C
			public int motionBlurThreadY; // 0x40
			public uint frameIndex; // 0x44
			public float blendFrame; // 0x48
			public float[] historyWeights; // 0x50
			public float[] parameters; // 0x58
			public TextureHandle currSceneColorTexture; // 0x60
			public TextureHandle currSceneDepthTexture; // 0x70
			public TextureHandle currMVTexture; // 0x80
			public TextureHandle packingTexture; // 0x90
			public TextureHandle tileMaxTexture; // 0xA0
			public TextureHandle tileNeighborTexture; // 0xB0
			public TextureHandle motionBlurTexture; // 0xC0
			public TextureHandle blendMotionBlurTexture; // 0xD0
			public TextureHandle[] historyMotionBlurTextures; // 0xE0
			public ComputeShader computeShader; // 0xE8
			public TextureHandle debugTexture0; // 0xF0
	
			// Constructors
			public MotionBlurPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public MotionBlurPassConstructor() {} // Dummy constructor
		internal MotionBlurPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184B0DD90-0x0000000184B0DE50
		// MotionBlurPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassConstructor(
		        MotionBlurPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  __int64 v15; // rcx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_parameters = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 16LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_parameters, v5, v6, v7, v19);
		  this->fields.m_historyTimes = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 5LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_historyTimes, v8, v9, v10, v20);
		  this->fields.m_historyScreenSize = TypeInfo::UnityEngine::Vector2Int->static_fields->s_Zero;
		  this->fields.m_historyTextures = (TextureHandle__Array *)il2cpp_array_new_specific_1(
		                                                             TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
		                                                             5LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_historyTextures, v11, v12, v13, v21);
		  if ( !resources->defaultResources || (shaders = resources->defaultResources->fields.shaders) == 0LL )
		    sub_1800D8260(v15, v14);
		  this->fields.m_motionBlurCS = shaders->fields.motionBlurCS;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_motionBlurCS, v14, v16, v17, v22);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBDD74-0x0000000189BBDDC8
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        MotionBlurPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3255, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3255, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBDD20-0x0000000189BBDD74
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        MotionBlurPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3256, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3256, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		private void Reset() {} // 0x0000000189BBDDC8-0x0000000189BBDE7C
		// Void Reset()
		void HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(MotionBlurPassConstructor *this, MethodInfo *method)
		{
		  int i; // edi
		  TextureHandle__Array *m_historyTextures; // rsi
		  TextureHandle *nullHandle; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+20h] [rbp-28h] BYREF
		  TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3257, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3257, 0LL);
		    if ( !Patch )
		LABEL_7:
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_historyScreenSize = TypeInfo::UnityEngine::Vector2Int->static_fields->s_Zero;
		    for ( i = 0; i < 5; ++i )
		    {
		      m_historyTextures = this->fields.m_historyTextures;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		      if ( !m_historyTextures )
		        goto LABEL_7;
		      v9 = *nullHandle;
		      sub_180430AC4(m_historyTextures, i, &v9);
		    }
		    this->fields.frameIndex = 0;
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBC878-0x0000000189BBDBF8
		// Void ConstructPass(MotionBlurPassConstructor+PassInput ByRef, MotionBlurPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::MotionBlurPassConstructor::ConstructPass(
		        MotionBlurPassConstructor *this,
		        MotionBlurPassConstructor_PassInput *input,
		        MotionBlurPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGSettingParameters *settingParameters; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  ProfilingSampler *v25; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rdi
		  int32_t v29; // r15d
		  int32_t v30; // r13d
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  HGMotionBlur *m_motionBlur; // r12
		  Single__Array *m_parameters; // r14
		  ClampedFloatParameter *shutterAngle; // rdx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // r8
		  double v40; // xmm0_8
		  float v41; // xmm0_4
		  Single__Array *v42; // rcx
		  __int64 m_X; // rdx
		  __int64 v44; // rdx
		  Single__Array *v45; // rcx
		  Single__Array *v46; // r14
		  ClampedIntParameter *sampleCount; // rdx
		  int v48; // eax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  __int64 v51; // r8
		  Single__Array *v52; // rax
		  Single__Array *v53; // rax
		  Single__Array *v54; // rax
		  Single__Array *v55; // rax
		  Object *v56; // r14
		  int v57; // eax
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  Object *v60; // r14
		  int v61; // eax
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  __int128 v64; // xmm2
		  __int128 v65; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v67; // r8
		  signed __int64 v68; // rtt
		  Object *v69; // r12
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  TextureHandle v72; // xmm0
		  __int128 v73; // xmm2
		  __int128 v74; // xmm3
		  Color v75; // xmm4
		  unsigned __int64 v76; // r8
		  signed __int64 v77; // rtt
		  Object *v78; // r12
		  __int64 v79; // rdx
		  __int64 v80; // rcx
		  TextureHandle v81; // xmm0
		  Object *v82; // r13
		  int v83; // eax
		  __int64 v84; // rdx
		  __int64 v85; // rcx
		  Object *v86; // r13
		  int32_t v87; // r12d
		  int v88; // eax
		  __int64 v89; // rdx
		  __int64 v90; // rcx
		  __int128 v91; // xmm2
		  __int128 v92; // xmm3
		  Color v93; // xmm4
		  unsigned __int64 v94; // r8
		  signed __int64 v95; // rtt
		  Object *v96; // r15
		  __int64 v97; // rdx
		  __int64 v98; // rcx
		  TextureHandle v99; // xmm0
		  Object *v100; // r15
		  int v101; // eax
		  __int64 v102; // rdx
		  __int64 v103; // rcx
		  Object *v104; // rdi
		  int v105; // eax
		  __int64 v106; // rdx
		  __int64 v107; // rcx
		  MotionBlurPassConstructor_PassInput *v108; // r15
		  Object *v109; // rbx
		  __int64 v110; // rdx
		  __int64 v111; // rcx
		  TextureHandle v112; // xmm0
		  Object *v113; // rbx
		  MotionBlurPassConstructor_PassOutput v114; // xmm6
		  ClampedFloatParameter *blendFrame; // rdx
		  __int64 v116; // rdx
		  __int64 v117; // rcx
		  double v118; // xmm0_8
		  __int64 v119; // rdx
		  Object *v120; // rcx
		  __int64 v121; // rdx
		  __int64 v122; // rcx
		  __int64 v123; // r12
		  TextureHandle__Array *m_historyTextures; // rbx
		  TextureHandle *v125; // rax
		  __int64 v126; // rdx
		  __int64 v127; // rcx
		  Single__Array *m_historyTimes; // rbx
		  __int64 v129; // rdx
		  Single__Array *v130; // rcx
		  __int64 v131; // r8
		  __int64 v132; // r9
		  float time; // xmm0_4
		  signed int i; // r15d
		  unsigned int v135; // ebx
		  __int64 v136; // rdx
		  unsigned int v137; // ebx
		  TextureHandle__Array *v138; // rdi
		  TextureHandle *v139; // rax
		  Vector2Int m_historyScreenSize; // rax
		  Vector2Int v141; // rcx
		  unsigned __int64 v142; // rcx
		  ClampedFloatParameter *v143; // rdx
		  double v144; // xmm0_8
		  Beyond::JobMathf *v145; // rcx
		  __int64 v146; // rdx
		  TextureHandle__Array *v147; // rdi
		  TextureHandle *v148; // rax
		  __int64 v149; // rdx
		  __int64 v150; // rcx
		  __int64 v151; // r8
		  Single__Array *v152; // rdi
		  Single__Array *v153; // rax
		  __int64 v154; // r8
		  float v155; // xmm0_4
		  __int64 v156; // rax
		  TextureHandle__Array *v157; // rdi
		  TextureHandle *nullHandle; // rax
		  __int64 v159; // rdx
		  __int64 v160; // rcx
		  __int64 v161; // r8
		  __int64 v162; // rax
		  Object *v163; // rdx
		  unsigned int v164; // edx
		  unsigned __int64 v165; // r8
		  signed __int64 v166; // rtt
		  TextureHandle *v167; // rbx
		  TextureHandle__Array *v168; // rcx
		  __int64 v169; // rcx
		  __int64 m_tileMaxKernel; // rcx
		  __int64 m_tileNeighborKernel; // rcx
		  __int64 m_motionBlurKernel; // rcx
		  __int64 m_blendMotionBlurKernel; // rcx
		  Object *v174; // rdx
		  int v175; // eax
		  unsigned int v176; // edx
		  unsigned __int64 v177; // r8
		  char v178; // dl
		  signed __int64 v179; // rtt
		  Object *v180; // rdx
		  MonitorData *m_motionBlurCS; // rcx
		  unsigned int v182; // edx
		  unsigned __int64 v183; // r8
		  char v184; // dl
		  signed __int64 v185; // rtt
		  Object *v186; // rbx
		  __int64 v187; // rdx
		  __int64 v188; // rcx
		  TextureHandle v189; // xmm0
		  Object *v190; // rbx
		  __int64 v191; // rdx
		  __int64 v192; // rcx
		  TextureHandle v193; // xmm0
		  Object *v194; // rbx
		  __int64 v195; // rdx
		  __int64 v196; // rcx
		  TextureHandle v197; // xmm0
		  RenderFunc_1_System_Object_ *v198; // rax
		  __int64 v199; // rdx
		  __int64 v200; // rcx
		  RenderFunc_1_System_Object_ *v201; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v203; // rdx
		  __int64 v204; // rcx
		  Object *v205; // [rsp+40h] [rbp-458h] BYREF
		  TextureHandle v206; // [rsp+50h] [rbp-448h] BYREF
		  __int128 v207; // [rsp+60h] [rbp-438h] BYREF
		  __int128 v208; // [rsp+70h] [rbp-428h]
		  __int128 v209; // [rsp+80h] [rbp-418h]
		  __int128 v210; // [rsp+90h] [rbp-408h] BYREF
		  __int128 v211; // [rsp+A0h] [rbp-3F8h]
		  Color v212; // [rsp+B0h] [rbp-3E8h]
		  int32_t height; // [rsp+C0h] [rbp-3D8h]
		  HGRenderGraphBuilder v214; // [rsp+C8h] [rbp-3D0h] BYREF
		  HGMotionBlur *v215; // [rsp+E8h] [rbp-3B0h]
		  _QWORD v216[2]; // [rsp+F0h] [rbp-3A8h] BYREF
		  TextureHandle sceneColor; // [rsp+100h] [rbp-398h]
		  TextureHandle v218; // [rsp+110h] [rbp-388h] BYREF
		  HGRenderGraphBuilder v219; // [rsp+120h] [rbp-378h] BYREF
		  Il2CppExceptionWrapper *v220; // [rsp+140h] [rbp-358h] BYREF
		  TextureDesc v221; // [rsp+150h] [rbp-348h] BYREF
		  TextureDesc v222; // [rsp+1B0h] [rbp-2E8h] BYREF
		  TextureDesc v223; // [rsp+210h] [rbp-288h] BYREF
		  TextureDesc v224; // [rsp+270h] [rbp-228h] BYREF
		  TextureDesc v225; // [rsp+2D0h] [rbp-1C8h] BYREF
		  TextureDesc v226; // [rsp+330h] [rbp-168h] BYREF
		  TextureDesc v227; // [rsp+390h] [rbp-108h] BYREF
		  TextureDesc v228; // [rsp+3F0h] [rbp-A8h] BYREF
		
		  v205 = 0LL;
		  sub_18033B9D0(&v224, 0LL, 96LL);
		  sub_18033B9D0(&v207, 0LL, 96LL);
		  sub_18033B9D0(&v226, 0LL, 96LL);
		  sub_18033B9D0(&v228, 0LL, 96LL);
		  sub_18033B9D0(&v221, 0LL, 96LL);
		  sub_18033B9D0(&v222, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3258, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3258, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v204, v203);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1198(
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
		    if ( !HG::Rendering::Runtime::HGCamera::get_enableMotionBlur(camera, 0LL) )
		      goto LABEL_124;
		    settingParameters = input->settingParameters;
		    if ( !settingParameters )
		      sub_1800D8260(v13, v12);
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParameters->fields._motionBlurEnable_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      if ( !this->fields.m_motionBlurCS )
		        sub_1800D8260(v16, v15);
		      this->fields.m_packingKernel = UnityEngine::ComputeShader::FindKernel(
		                                       this->fields.m_motionBlurCS,
		                                       (String *)"Packing",
		                                       0LL);
		      if ( !this->fields.m_motionBlurCS )
		        sub_1800D8260(v18, v17);
		      this->fields.m_tileMaxKernel = UnityEngine::ComputeShader::FindKernel(
		                                       this->fields.m_motionBlurCS,
		                                       (String *)"TileMax",
		                                       0LL);
		      if ( !this->fields.m_motionBlurCS )
		        sub_1800D8260(v20, v19);
		      this->fields.m_tileNeighborKernel = UnityEngine::ComputeShader::FindKernel(
		                                            this->fields.m_motionBlurCS,
		                                            (String *)"TileNeighbor",
		                                            0LL);
		      if ( !this->fields.m_motionBlurCS )
		        sub_1800D8260(v22, v21);
		      this->fields.m_motionBlurKernel = UnityEngine::ComputeShader::FindKernel(
		                                          this->fields.m_motionBlurCS,
		                                          (String *)"MotionBlur",
		                                          0LL);
		      if ( !this->fields.m_motionBlurCS )
		        sub_1800D8260(v24, v23);
		      this->fields.m_blendMotionBlurKernel = UnityEngine::ComputeShader::FindKernel(
		                                               this->fields.m_motionBlurCS,
		                                               (String *)"BlendMotionBlur",
		                                               0LL);
		      sceneColor = input->sceneColor;
		      v25 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0xA7u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v27, v26);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v219,
		        renderGraph,
		        (String *)"Motion Blur Pass",
		        &v205,
		        v25,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
		      v214 = v219;
		      v216[0] = 0LL;
		      v216[1] = &v214;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v214, 0, 0LL);
		        sceneRTSize_k__BackingField = camera->fields._sceneRTSize_k__BackingField;
		        v29 = sub_1832DBD50();
		        if ( v29 < 1 )
		          v29 = 1;
		        v30 = sub_1832DBD50();
		        if ( v30 < 1 )
		          v30 = 1;
		        height = v30;
		        volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		        if ( !volumeComponentsData )
		          sub_1800D8250(v33, v32);
		        m_motionBlur = volumeComponentsData->fields.m_motionBlur;
		        v215 = m_motionBlur;
		        m_parameters = this->fields.m_parameters;
		        if ( !m_motionBlur )
		          sub_1800D8250(v33, v32);
		        shutterAngle = m_motionBlur->fields.shutterAngle;
		        if ( !shutterAngle )
		          sub_1800D8250(v33, 0LL);
		        v40 = sub_1800057D0(10LL, shutterAngle);
		        if ( !m_parameters )
		          sub_1800D8250(v38, v37);
		        v41 = *(float *)&v40 / 360.0;
		        if ( !m_parameters->max_length.size )
		          sub_1800D2AA0(v38, v37, v39);
		        m_parameters->vector[0] = v41;
		        v42 = this->fields.m_parameters;
		        m_X = (unsigned int)sceneRTSize_k__BackingField.m_X;
		        if ( sceneRTSize_k__BackingField.m_X >= sceneRTSize_k__BackingField.m_Y )
		          m_X = (unsigned int)sceneRTSize_k__BackingField.m_Y;
		        if ( !v42 )
		          sub_1800D8250(0LL, m_X);
		        if ( v42->max_length.size <= 1u )
		          sub_1800D2AA0(v42, m_X, v39);
		        v44 = (unsigned int)((int)m_X / 20);
		        v42->vector[1] = (float)(int)v44;
		        v45 = this->fields.m_parameters;
		        if ( !v45 )
		          sub_1800D8250(0LL, v44);
		        if ( v45->max_length.size <= 1u )
		          sub_1800D2AA0(v45, v44, v39);
		        if ( v45->max_length.size <= 2u )
		          sub_1800D2AA0(v45, v44, v39);
		        v45->vector[2] = 1.0 / v45->vector[1];
		        v46 = this->fields.m_parameters;
		        sampleCount = m_motionBlur->fields.sampleCount;
		        if ( !sampleCount )
		          sub_1800D8250(v45, 0LL);
		        v48 = sub_180002F70(10LL, sampleCount);
		        if ( !v46 )
		          sub_1800D8250(v50, v49);
		        if ( v46->max_length.size <= 3u )
		          sub_1800D2AA0(v50, v49, v51);
		        v46->vector[3] = (float)v48;
		        v52 = this->fields.m_parameters;
		        if ( !v52 )
		          sub_1800D8250(v50, v49);
		        if ( v52->max_length.size <= 4u )
		          sub_1800D2AA0(v50, v49, v51);
		        v52->vector[4] = (float)v29;
		        v53 = this->fields.m_parameters;
		        if ( !v53 )
		          sub_1800D8250(v50, v49);
		        if ( v53->max_length.size <= 5u )
		          sub_1800D2AA0(v50, v49, v51);
		        v53->vector[5] = (float)v30;
		        v54 = this->fields.m_parameters;
		        if ( !v54 )
		          sub_1800D8250(v50, v49);
		        if ( v54->max_length.size <= 6u )
		          sub_1800D2AA0(v50, v49, v51);
		        v54->vector[6] = 1.0 / (float)v29;
		        v55 = this->fields.m_parameters;
		        if ( !v55 )
		          sub_1800D8250(v50, v49);
		        if ( v55->max_length.size <= 7u )
		          sub_1800D2AA0(v50, v49, v51);
		        v55->vector[7] = 1.0 / (float)v30;
		        v56 = v205;
		        v57 = sub_1832DBD50();
		        if ( !v56 )
		          sub_1800D8250(v59, v58);
		        HIDWORD(v56[2].klass) = v57;
		        v60 = v205;
		        v61 = sub_1832DBD50();
		        if ( !v60 )
		          sub_1800D8250(v63, v62);
		        LODWORD(v60[2].monitor) = v61;
		        sub_18033B9D0(&v223, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		          &v223,
		          sceneRTSize_k__BackingField.m_X,
		          sceneRTSize_k__BackingField.m_Y,
		          0LL);
		        v64 = *(_OWORD *)&v223.width;
		        v207 = *(_OWORD *)&v223.width;
		        v208 = *(_OWORD *)&v223.colorFormat;
		        v209 = *(_OWORD *)&v223.enableRandomWrite;
		        *(_QWORD *)&v210 = *(_QWORD *)&v223.bindTextureMS;
		        v65 = *(_OWORD *)&v223.fastMemoryDesc.inFastMemory;
		        v211 = *(_OWORD *)&v223.fastMemoryDesc.inFastMemory;
		        clearColor = v223.clearColor;
		        v212 = v223.clearColor;
		        LODWORD(v208) = 75;
		        LOBYTE(v209) = 1;
		        *((_QWORD *)&v210 + 1) = "Motion Blur Packing";
		        if ( dword_18F35FD08 )
		        {
		          v67 = ((((unsigned __int64)&v210 + 8) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v67 + 36190]);
		          do
		            v68 = qword_18F0BCBA0[v67 + 36190];
		          while ( v68 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v67 + 36190],
		                           v68 | (1LL << ((((unsigned __int64)&v210 + 8) >> 12) & 0x3F)),
		                           v68) );
		          clearColor = v212;
		          v65 = v211;
		          v64 = v207;
		        }
		        *(_WORD *)((char *)&v209 + 1) = 0;
		        *(_OWORD *)&v224.width = v64;
		        *(_OWORD *)&v224.colorFormat = v208;
		        *(_OWORD *)&v224.enableRandomWrite = v209;
		        *(_OWORD *)&v224.bindTextureMS = v210;
		        *(_OWORD *)&v224.fastMemoryDesc.inFastMemory = v65;
		        v224.clearColor = clearColor;
		        v69 = v205;
		        v72 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v206, &v214, &v224, 0LL);
		        if ( !v69 )
		          sub_1800D8250(v71, v70);
		        v69[9] = (Object)v72;
		        if ( !v205 )
		          sub_1800D8250(v71, v70);
		        HIDWORD(v205[2].monitor) = v29;
		        if ( !v205 )
		          sub_1800D8250(v71, v70);
		        LODWORD(v205[3].klass) = v30;
		        sub_18033B9D0(&v225, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v225, v29, v30, 0LL);
		        v73 = *(_OWORD *)&v225.width;
		        v207 = *(_OWORD *)&v225.width;
		        v208 = *(_OWORD *)&v225.colorFormat;
		        v209 = *(_OWORD *)&v225.enableRandomWrite;
		        *(_QWORD *)&v210 = *(_QWORD *)&v225.bindTextureMS;
		        v74 = *(_OWORD *)&v225.fastMemoryDesc.inFastMemory;
		        v211 = *(_OWORD *)&v225.fastMemoryDesc.inFastMemory;
		        v75 = v225.clearColor;
		        v212 = v225.clearColor;
		        LODWORD(v208) = 46;
		        LOBYTE(v209) = 1;
		        *((_QWORD *)&v210 + 1) = "Motion Blur Tile Max";
		        if ( dword_18F35FD08 )
		        {
		          v76 = ((((unsigned __int64)&v210 + 8) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v76 + 36190]);
		          do
		            v77 = qword_18F0BCBA0[v76 + 36190];
		          while ( v77 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v76 + 36190],
		                           v77 | (1LL << ((((unsigned __int64)&v210 + 8) >> 12) & 0x3F)),
		                           v77) );
		          v75 = v212;
		          v74 = v211;
		          v73 = v207;
		        }
		        *(_WORD *)((char *)&v209 + 1) = 0;
		        *(_OWORD *)&v226.width = v73;
		        *(_OWORD *)&v226.colorFormat = v208;
		        *(_OWORD *)&v226.enableRandomWrite = v209;
		        *(_OWORD *)&v226.bindTextureMS = v210;
		        *(_OWORD *)&v226.fastMemoryDesc.inFastMemory = v74;
		        v226.clearColor = v75;
		        v78 = v205;
		        v81 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v206, &v214, &v226, 0LL);
		        if ( !v78 )
		          sub_1800D8250(v80, v79);
		        v78[10] = (Object)v81;
		        v82 = v205;
		        v83 = sub_1832DBD50();
		        if ( !v82 )
		          sub_1800D8250(v85, v84);
		        HIDWORD(v82[3].klass) = v83;
		        v86 = v205;
		        v87 = height;
		        v88 = sub_1832DBD50();
		        if ( !v86 )
		          sub_1800D8250(v90, v89);
		        LODWORD(v86[3].monitor) = v88;
		        sub_18033B9D0(&v227, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v227, v29, v87, 0LL);
		        v91 = *(_OWORD *)&v227.width;
		        v207 = *(_OWORD *)&v227.width;
		        v208 = *(_OWORD *)&v227.colorFormat;
		        v209 = *(_OWORD *)&v227.enableRandomWrite;
		        *(_QWORD *)&v210 = *(_QWORD *)&v227.bindTextureMS;
		        v92 = *(_OWORD *)&v227.fastMemoryDesc.inFastMemory;
		        v211 = *(_OWORD *)&v227.fastMemoryDesc.inFastMemory;
		        v93 = v227.clearColor;
		        v212 = v227.clearColor;
		        LODWORD(v208) = 46;
		        LOBYTE(v209) = 1;
		        *((_QWORD *)&v210 + 1) = "Motion Blur Target";
		        if ( dword_18F35FD08 )
		        {
		          v94 = ((((unsigned __int64)&v210 + 8) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v94 + 36190]);
		          do
		            v95 = qword_18F0BCBA0[v94 + 36190];
		          while ( v95 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v94 + 36190],
		                           v95 | (1LL << ((((unsigned __int64)&v210 + 8) >> 12) & 0x3F)),
		                           v95) );
		          v93 = v212;
		          v92 = v211;
		          v91 = v207;
		        }
		        *(_WORD *)((char *)&v209 + 1) = 0;
		        *(_OWORD *)&v228.width = v91;
		        *(_OWORD *)&v228.colorFormat = v208;
		        *(_OWORD *)&v228.enableRandomWrite = v209;
		        *(_OWORD *)&v228.bindTextureMS = v210;
		        *(_OWORD *)&v228.fastMemoryDesc.inFastMemory = v92;
		        v228.clearColor = v93;
		        v96 = v205;
		        v99 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v206, &v214, &v228, 0LL);
		        if ( !v96 )
		          sub_1800D8250(v98, v97);
		        v96[11] = (Object)v99;
		        v100 = v205;
		        v101 = sub_1832DBD50();
		        if ( !v100 )
		          sub_1800D8250(v103, v102);
		        HIDWORD(v100[3].monitor) = v101;
		        v104 = v205;
		        v105 = sub_1832DBD50();
		        if ( !v104 )
		          sub_1800D8250(v107, v106);
		        LODWORD(v104[4].klass) = v105;
		        if ( !renderGraph )
		          sub_1800D8250(v107, v106);
		        v108 = input;
		        v221 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, &input->sceneColor, 0LL);
		        v221.enableRandomWrite = 1;
		        v109 = v205;
		        v206 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v206, renderGraph, &v221, 0LL);
		        v112 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v218, &v214, &v206, 0LL);
		        if ( !v109 )
		          sub_1800D8250(v111, v110);
		        v109[12] = (Object)v112;
		        v113 = v205;
		        if ( !v205 )
		          sub_1800D8250(v111, v110);
		        v114 = (MotionBlurPassConstructor_PassOutput)v205[12];
		        sceneColor = v114.result;
		        blendFrame = v215->fields.blendFrame;
		        if ( !blendFrame )
		          sub_1800D8250(v111, 0LL);
		        v118 = sub_1800057D0(10LL, blendFrame);
		        if ( !v113 )
		          sub_1800D8250(v117, v116);
		        LODWORD(v113[4].monitor) = LODWORD(v118);
		        if ( !v205 )
		          sub_1800D8250(0LL, v116);
		        if ( *(float *)&v205[4].monitor > 0.0 )
		        {
		          HIDWORD(v205[4].klass) = this->fields.frameIndex;
		          v222 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                    renderGraph,
		                    &input->sceneColor,
		                    0LL);
		          v222.enableRandomWrite = 1;
		          if ( !v205 )
		            sub_1800D8250(v122, v121);
		          v123 = HIDWORD(v205[4].klass) % 5;
		          m_historyTextures = this->fields.m_historyTextures;
		          v206 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v218, renderGraph, &v222, 0LL);
		          v125 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v218, &v214, &v206, 0LL);
		          if ( !m_historyTextures )
		            sub_1800D8250(v127, v126);
		          v206 = *v125;
		          sub_180430AC4(m_historyTextures, (unsigned int)v123, &v206);
		          m_historyTimes = this->fields.m_historyTimes;
		          time = UnityEngine::Time::get_time(0LL);
		          if ( !m_historyTimes )
		            sub_1800D8250(v130, v129);
		          if ( (unsigned int)v123 >= m_historyTimes->max_length.size )
		            sub_1800D2AA0(v130, v129, v131);
		          m_historyTimes->vector[v123] = time;
		          for ( i = 1; (unsigned int)i <= 4; ++i )
		          {
		            if ( !v205 )
		              sub_1800D8250(v130, v129);
		            v135 = HIDWORD(v205[4].klass) - i + 5;
		            v136 = v135 / 5;
		            v137 = v135 % 5;
		            v138 = this->fields.m_historyTextures;
		            if ( !v138 )
		              sub_1800D8250(v130, v136);
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		            v139 = (TextureHandle *)sub_1803C0774(v138, v137);
		            if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v139, 0LL)
		              && (m_historyScreenSize = this->fields.m_historyScreenSize,
		                  v141 = camera->fields._sceneRTSize_k__BackingField,
		                  m_historyScreenSize.m_X == v141.m_X)
		              && (v142 = HIDWORD(*(unsigned __int64 *)&v141), m_historyScreenSize.m_Y == (_DWORD)v142) )
		            {
		              v143 = v215->fields.blendFrame;
		              if ( !v143 )
		                sub_1800D8250(v142, 0LL);
		              v144 = sub_1800057D0(10LL, v143);
		              Beyond::JobMathf::ClampedLerp(v145, 16.0, *(float *)&v144, *(float *)&v92);
		              v147 = this->fields.m_historyTextures;
		              if ( !v147 )
		                sub_1800D8250(0LL, v146);
		              v148 = (TextureHandle *)sub_1803C0774(v147, v137);
		              v206 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v218, &v214, v148, 0LL);
		              sub_180430AC4(v147, v137, &v206);
		              v152 = this->fields.m_parameters;
		              v153 = this->fields.m_historyTimes;
		              if ( !v153 )
		                sub_1800D8250(v150, v149);
		              if ( v137 >= v153->max_length.size )
		                sub_1800D2AA0(v150, v149, v151);
		              if ( (unsigned int)v123 >= v153->max_length.size )
		                sub_1800D2AA0(v150, v149, v151);
		              v155 = sub_180335960();
		              if ( !v152 )
		                sub_1800D8250(v130, v129);
		              v156 = i + 7LL;
		              if ( (unsigned int)v156 >= v152->max_length.size )
		                sub_1800D2AA0(v130, v129, v154);
		              v152->vector[v156] = v155;
		            }
		            else
		            {
		              v157 = this->fields.m_historyTextures;
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		              nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)&v219, 0LL);
		              if ( !v157 )
		                sub_1800D8250(v160, v159);
		              v206 = *nullHandle;
		              sub_180430AC4(v157, v137, &v206);
		              v130 = this->fields.m_parameters;
		              if ( !v130 )
		                sub_1800D8250(0LL, v129);
		              v162 = i + 7LL;
		              if ( (unsigned int)v162 >= v130->max_length.size )
		                sub_1800D2AA0(v130, v129, v161);
		              v130->vector[v162] = 0.0;
		            }
		          }
		          this->fields.m_historyScreenSize = camera->fields._sceneRTSize_k__BackingField;
		          v163 = v205;
		          if ( !v205 )
		            sub_1800D8250(v130, 0LL);
		          v205[14].klass = (Object__Class *)this->fields.m_historyTextures;
		          if ( dword_18F35FD08 )
		          {
		            v164 = ((unsigned __int64)&v163[14] >> 12) & 0x1FFFFF;
		            v165 = (unsigned __int64)v164 >> 6;
		            v163 = (Object *)(v164 & 0x3F);
		            _m_prefetchw(&qword_18F0BCBA0[v165 + 36190]);
		            do
		              v166 = qword_18F0BCBA0[v165 + 36190];
		            while ( v166 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v165 + 36190],
		                              v166 | (1LL << (char)v163),
		                              v166) );
		          }
		          v167 = (TextureHandle *)v205;
		          v168 = this->fields.m_historyTextures;
		          if ( !v168 )
		            sub_1800D8250(0LL, v163);
		          sub_1803C0830(v168, &v206, (unsigned int)v123, v132);
		          if ( !v167 )
		            sub_1800D8250(v169, v119);
		          v167[13] = v206;
		          v120 = v205;
		          if ( !v205 )
		            sub_1800D8250(0LL, v119);
		          v114 = (MotionBlurPassConstructor_PassOutput)v205[13];
		          sceneColor = v114.result;
		          ++this->fields.frameIndex;
		          v108 = input;
		        }
		        else
		        {
		          HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(this, 0LL);
		          v120 = v205;
		        }
		        if ( !v120 )
		          sub_1800D8250(0LL, v119);
		        LODWORD(v120[1].klass) = this->fields.m_packingKernel;
		        m_tileMaxKernel = (unsigned int)this->fields.m_tileMaxKernel;
		        if ( !v205 )
		          sub_1800D8250(m_tileMaxKernel, v119);
		        HIDWORD(v205[1].klass) = m_tileMaxKernel;
		        m_tileNeighborKernel = (unsigned int)this->fields.m_tileNeighborKernel;
		        if ( !v205 )
		          sub_1800D8250(m_tileNeighborKernel, v119);
		        LODWORD(v205[1].monitor) = m_tileNeighborKernel;
		        m_motionBlurKernel = (unsigned int)this->fields.m_motionBlurKernel;
		        if ( !v205 )
		          sub_1800D8250(m_motionBlurKernel, v119);
		        HIDWORD(v205[1].monitor) = m_motionBlurKernel;
		        m_blendMotionBlurKernel = (unsigned int)this->fields.m_blendMotionBlurKernel;
		        if ( !v205 )
		          sub_1800D8250(m_blendMotionBlurKernel, v119);
		        LODWORD(v205[2].klass) = m_blendMotionBlurKernel;
		        v174 = v205;
		        if ( !v205 )
		          sub_1800D8250(m_blendMotionBlurKernel, 0LL);
		        v205[5].monitor = (MonitorData *)this->fields.m_parameters;
		        v175 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v176 = ((unsigned __int64)&v174[5].monitor >> 12) & 0x1FFFFF;
		          v177 = (unsigned __int64)v176 >> 6;
		          v178 = v176 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v177 + 36190]);
		          do
		            v179 = qword_18F0BCBA0[v177 + 36190];
		          while ( v179 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v177 + 36190], v179 | (1LL << v178), v179) );
		          v175 = dword_18F35FD08;
		        }
		        v180 = v205;
		        m_motionBlurCS = (MonitorData *)this->fields.m_motionBlurCS;
		        if ( !v205 )
		          sub_1800D8250(m_motionBlurCS, 0LL);
		        v205[14].monitor = m_motionBlurCS;
		        if ( v175 )
		        {
		          v182 = ((unsigned __int64)&v180[14].monitor >> 12) & 0x1FFFFF;
		          v183 = (unsigned __int64)v182 >> 6;
		          v184 = v182 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v183 + 36190]);
		          do
		            v185 = qword_18F0BCBA0[v183 + 36190];
		          while ( v185 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v183 + 36190], v185 | (1LL << v184), v185) );
		        }
		        v186 = v205;
		        v189 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v219,
		                  &v214,
		                  &v108->sceneColor,
		                  0LL);
		        if ( !v186 )
		          sub_1800D8250(v188, v187);
		        v186[6] = (Object)v189;
		        v190 = v205;
		        v193 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v219,
		                  &v214,
		                  &v108->sceneDepth,
		                  0LL);
		        if ( !v190 )
		          sub_1800D8250(v192, v191);
		        v190[7] = (Object)v193;
		        v194 = v205;
		        v197 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v219,
		                  &v214,
		                  &v108->sceneMV,
		                  0LL);
		        if ( !v194 )
		          sub_1800D8250(v196, v195);
		        v194[8] = (Object)v197;
		        v198 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
		        v201 = v198;
		        if ( !v198 )
		          sub_1800D8250(v200, v199);
		        HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v198,
		          (Object *)this,
		          MethodInfo::HG::Rendering::Runtime::MotionBlurPassConstructor::_ConstructPass_b__21_0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v214,
		          v201,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v220 )
		      {
		        v216[0] = v220->ex;
		        sub_180268AE0(v216);
		        v114 = (MotionBlurPassConstructor_PassOutput)sceneColor;
		        goto LABEL_123;
		      }
		      sub_180268AE0(v216);
		LABEL_123:
		      *output = v114;
		    }
		    else
		    {
		LABEL_124:
		      HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(this, 0LL);
		      *output = (MotionBlurPassConstructor_PassOutput)input->sceneColor;
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBDBF8-0x0000000189BBDD20
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        MotionBlurPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  TextureHandle__Array *v6; // rcx
		  int32_t i; // esi
		  TextureHandle__Array *m_historyTextures; // rax
		  TextureHandle__Array *v9; // rbx
		  TextureHandle *v10; // rax
		  TextureHandle__Array *v11; // r15
		  HGRenderGraph *renderGraph; // r14
		  TextureHandle *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v15; // [rsp+30h] [rbp-38h] BYREF
		  TextureHandle v16; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3261, 0LL) )
		  {
		    if ( input->passSkipped )
		      HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(this, 0LL);
		    for ( i = 0; ; ++i )
		    {
		      m_historyTextures = this->fields.m_historyTextures;
		      if ( !m_historyTextures )
		        break;
		      if ( i >= m_historyTextures->max_length.size )
		        return;
		      v9 = this->fields.m_historyTextures;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v10 = (TextureHandle *)sub_1803C0774(v9, i);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v10, 0LL) )
		      {
		        v11 = this->fields.m_historyTextures;
		        v6 = v11;
		        if ( !v11 )
		          break;
		        renderGraph = input->renderGraph;
		        if ( !renderGraph )
		          break;
		        v13 = (TextureHandle *)sub_1803C0774(v11, i);
		        v15 = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                 &v16,
		                 renderGraph,
		                 v13,
		                 1,
		                 (String *)"MotionBlurPass",
		                 0LL);
		        sub_180430AC4(v11, i, &v15);
		      }
		    }
		LABEL_13:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3261, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80050-0x0000000184D80080
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        MotionBlurPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3262, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3262, 0LL);
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
