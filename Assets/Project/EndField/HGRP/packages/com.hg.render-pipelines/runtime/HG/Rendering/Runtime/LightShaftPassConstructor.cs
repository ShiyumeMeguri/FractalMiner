using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class LightShaftPassConstructor : IPassConstructor // TypeDefIndex: 38389
	{
		// Fields
		private Material m_lightShaftMaterial; // 0x10
		private static readonly MaterialPropertyBlock s_lightShaftMaterialPropertyBlock; // 0x00
		private static readonly RenderFunc<LightShaftDownSamplePassData> s_lightShaftDownSampleRenderFunc; // 0x08
		private static readonly RenderFunc<LightShaftRadialBlurPassData> s_lightShaftRadialBlurRenderFunc; // 0x10
		private static readonly string[] s_lightShaftPingPongRTName; // 0x18
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38384
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal bool enableLightShaft; // 0x20
			internal float downSampleFactor; // 0x24
			internal int lightShaftSampleNum; // 0x28
			internal int lightShaftBlurPassCount; // 0x2C
		}
	
		internal struct PassOutput // TypeDefIndex: 38385
		{
			// Fields
			internal TextureHandle lightShaftBlurResult; // 0x00
			internal bool enableLightShaft; // 0x10
		}
	
		private class LightShaftDownSamplePassData // TypeDefIndex: 38386
		{
			// Fields
			public Material lightShaftMaterial; // 0x10
			public TextureHandle sceneColorRT; // 0x18
			public TextureHandle sceneDepthRT; // 0x28
			public TextureHandle targetRT; // 0x38
	
			// Constructors
			public LightShaftDownSamplePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class LightShaftRadialBlurPassData // TypeDefIndex: 38387
		{
			// Fields
			public Material lightShaftMaterial; // 0x10
			public TextureHandle sourceRT; // 0x18
			public TextureHandle targetRT; // 0x28
			public int lightShaftBlurPassIndex; // 0x38
	
			// Constructors
			public LightShaftRadialBlurPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public LightShaftPassConstructor() {} // Dummy constructor
		internal LightShaftPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CCB0C0-0x0000000184CCB110
		// LightShaftApplyPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassConstructor(
		        LightShaftApplyPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  this->fields.m_lightShaftMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                        materialCollector,
		                                        shaders->fields.lightShaftPS,
		                                        0,
		                                        0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v9);
		}
		
		static LightShaftPassConstructor() {} // 0x0000000184A37090-0x0000000184A373C0
		// LightShaftPassConstructor()
		void HG::Rendering::Runtime::LightShaftPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // rcx
		  MaterialPropertyBlock *v3; // rbx
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  struct LightShaftPassConstructor_c__Class *v7; // rax
		  Object *v8; // rdi
		  RenderFunc_1_System_Object_ *v9; // rax
		  MonitorData *v10; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  Object *v14; // rdi
		  RenderFunc_1_System_Object_ *v15; // rax
		  RenderFunc_1_HG_Rendering_Runtime_LightShaftPassConstructor_LightShaftRadialBlurPassData_ *v16; // rbx
		  LightShaftPassConstructor__StaticFields *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  String__Array *v21; // rbx
		  LightShaftPassConstructor__StaticFields *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+50h] [rbp+28h]
		
		  v3 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v3 )
		    goto LABEL_2;
		  v3->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields->s_lightShaftMaterialPropertyBlock = v3;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields,
		    v4,
		    v5,
		    v6,
		    v25);
		  v7 = TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c);
		    v7 = TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c;
		  }
		  v8 = (Object *)v7->static_fields->__9;
		  v9 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
		  v10 = (MonitorData *)v9;
		  if ( !v9 )
		    goto LABEL_2;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v9,
		    v8,
		    MethodInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c::__cctor_b__18_0,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields;
		  static_fields->monitor = v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields->s_lightShaftDownSampleRenderFunc,
		    static_fields,
		    v12,
		    v13,
		    v26);
		  v14 = (Object *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c->static_fields->__9;
		  v15 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
		  v16 = (RenderFunc_1_HG_Rendering_Runtime_LightShaftPassConstructor_LightShaftRadialBlurPassData_ *)v15;
		  if ( !v15
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v15,
		          v14,
		          MethodInfo::HG::Rendering::Runtime::LightShaftPassConstructor::__c::__cctor_b__18_1,
		          0LL),
		        v17 = TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields,
		        v17->s_lightShaftRadialBlurRenderFunc = v16,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields->s_lightShaftRadialBlurRenderFunc,
		          (HGRuntimeGrassQuery_Node *)v17,
		          v18,
		          v19,
		          v27),
		        v20 = il2cpp_array_new_specific_1(TypeInfo::System::String, 2LL),
		        (v21 = (String__Array *)v20) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v2, v1);
		  }
		  sub_180005370(v20, 0LL, "_LightShaftPingPongRT0");
		  sub_180005370(v21, 1LL, "_LightShaftPingPongRT1");
		  v22 = TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields;
		  v22->s_lightShaftPingPongRTName = v21;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields->s_lightShaftPingPongRTName,
		    (HGRuntimeGrassQuery_Node *)v22,
		    v23,
		    v24,
		    v28);
		}
		
	
		// Methods
		public static bool ShouldRenderLightShaft(ref HGLightShaftConfig config, bool enableLightShaft, HGCamera hgCamera) => default; // 0x0000000189BCE7D0-0x0000000189BCE870
		// Boolean ShouldRenderLightShaft(HGLightShaftConfig ByRef, Boolean, HGCamera)
		bool HG::Rendering::Runtime::LightShaftPassConstructor::ShouldRenderLightShaft(
		        HGLightShaftConfig *config,
		        bool enableLightShaft,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3291, 0LL) )
		    return config->enable
		        && enableLightShaft
		        && (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor),
		            HG::Rendering::Runtime::LightShaftPassConstructor::GetDirectionalLightScreenPos(&v11, config, hgCamera, 0LL)->w > 0.0);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3291, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1211(Patch, config, enableLightShaft, (Object *)hgCamera, 0LL);
		}
		
		public static Vector4 GetDirectionalLightScreenPos(ref HGLightShaftConfig config, HGCamera hgCamera) => default; // 0x0000000189BCD6F8-0x0000000189BCD8B0
		// Vector4 GetDirectionalLightScreenPos(HGLightShaftConfig ByRef, HGCamera)
		Vector4 *HG::Rendering::Runtime::LightShaftPassConstructor::GetDirectionalLightScreenPos(
		        Vector4 *__return_ptr retstr,
		        HGLightShaftConfig *config,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  MethodInfo *InterpolatedPhase; // rdx
		  __int64 v8; // rcx
		  Vector3 *fwd; // rax
		  __int64 v10; // rdx
		  Quaternion v11; // xmm0
		  __int64 v12; // xmm3_8
		  Vector3 *v13; // rax
		  MethodInfo *v14; // r8
		  __int64 v15; // xmm0_8
		  __int128 v16; // xmm7
		  __int128 v17; // xmm8
		  __int128 v18; // xmm9
		  __int128 v19; // xmm10
		  Vector3 *v20; // rax
		  __int64 v21; // xmm6_8
		  float z; // ebx
		  Vector4 *v23; // rax
		  Quaternion v24; // xmm0
		  Vector4 *v25; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v27; // xmm0
		  Vector4 *result; // rax
		  Vector3 v29; // [rsp+38h] [rbp-69h] BYREF
		  Vector4 v30; // [rsp+48h] [rbp-59h] BYREF
		  Quaternion v31; // [rsp+58h] [rbp-49h] BYREF
		  Matrix4x4 v32; // [rsp+68h] [rbp-39h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3292, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3292, 0LL);
		    if ( Patch )
		    {
		      v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1210((Vector4 *)&v31, Patch, config, (Object *)hgCamera, 0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(v8, InterpolatedPhase);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = (MethodInfo *)HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_6;
		  fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v30, InterpolatedPhase);
		  v11 = *(Quaternion *)(v10 + 312);
		  v12 = *(_QWORD *)&fwd->x;
		  v29.z = fwd->z;
		  *(_QWORD *)&v29.x = v12;
		  v31 = v11;
		  v13 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v30, &v31, &v29, 0LL);
		  if ( !hgCamera )
		    goto LABEL_6;
		  v15 = *(_QWORD *)&v13->x;
		  v16 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredViewProjMatrix.m00;
		  v29.z = v13->z;
		  v17 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredViewProjMatrix.m01;
		  v18 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredViewProjMatrix.m02;
		  v19 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredViewProjMatrix.m03;
		  *(_QWORD *)&v29.x = v15;
		  v20 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v30, &v29, v14);
		  v21 = *(_QWORD *)&v20->x;
		  z = v20->z;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_QWORD *)&v29.x = v21;
		  v29.z = z;
		  v23 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&v31, &v29, 0.0, 0LL);
		  *(_OWORD *)&v32.m00 = v16;
		  *(_OWORD *)&v32.m01 = v17;
		  *(_OWORD *)&v32.m02 = v18;
		  v24 = (Quaternion)*v23;
		  *(_OWORD *)&v32.m03 = v19;
		  v31 = v24;
		  v25 = UnityEngine::Matrix4x4::op_Multiply(&v30, &v32, (Vector4 *)&v31, 0LL);
		LABEL_8:
		  v27 = *v25;
		  result = retstr;
		  *retstr = v27;
		  return result;
		}
		
		private void LightShaftPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BCD9AC-0x0000000189BCE7D0
		// Void LightShaftPass(LightShaftPassConstructor+PassInput ByRef, LightShaftPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftPass(
		        LightShaftPassConstructor *this,
		        LightShaftPassConstructor_PassInput *input,
		        LightShaftPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v9; // r14
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGEnvironmentPhase *v13; // rsi
		  HGLightShaftConfig *p_lightShaftConfig; // r12
		  bool enableLightShaft; // bl
		  bool ShouldRenderLightShaft; // al
		  float v17; // xmm1_4
		  __m128 v18; // xmm13
		  __m128 v19; // xmm11
		  float downSampleFactor; // xmm12_4
		  Material *klass; // rbx
		  float occlusionDepthRange; // xmm7_4
		  float bloomScale; // xmm9_4
		  float occlusionMaskDarkness; // xmm8_4
		  float bloomMaxBrightness; // xmm6_4
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __m128i v28; // xmm6
		  Material *v29; // rbx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  __m128i v32; // xmm6
		  Material *v33; // rbx
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __m128i v36; // xmm6
		  Material *v37; // rbx
		  int32_t LightShaftParams3; // r12d
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  __m128i v41; // xmm6
		  Object_1 *lightShaftCloudMaskTexture; // rbx
		  Material *v43; // rbx
		  __int64 v44; // rcx
		  HGShaderKeyWords__StaticFields *static_fields; // rdx
		  Material *v46; // rbx
		  __int64 v47; // rdx
		  HGShaderIDs__StaticFields *v48; // rcx
		  Material *v49; // r12
		  int32_t LightShaftCloudMaskParams; // r13d
		  int rotation; // ebx
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  __m128i v54; // xmm6
		  Material *v55; // rbx
		  __int64 v56; // rcx
		  HGShaderKeyWords__StaticFields *v57; // rdx
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  int32_t v60; // r12d
		  Void *m_Buffer; // r13
		  unsigned int v62; // ebx
		  __int64 v63; // rdx
		  unsigned int v64; // eax
		  HGRuntimeGrassQuery_Node *v65; // rdx
		  HGRuntimeGrassQuery_Node *v66; // r8
		  Int32__Array **v67; // r9
		  LightShaftPassConstructor__StaticFields *v68; // rcx
		  String__Array *s_lightShaftPingPongRTName; // rbx
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  TextureHandle v72; // xmm0
		  Void *v73; // rax
		  ProfilingSampler *v74; // rax
		  ProfilingSampler *v75; // rax
		  __int64 v76; // rdx
		  __int64 v77; // rcx
		  __int64 v78; // rcx
		  Object *v79; // rdx
		  unsigned int v80; // edx
		  unsigned __int64 v81; // r8
		  char v82; // dl
		  signed __int64 v83; // rtt
		  Object *v84; // r12
		  __int64 v85; // rdx
		  __int64 v86; // rcx
		  TextureHandle v87; // xmm0
		  Object *v88; // r12
		  __int64 v89; // rdx
		  __int64 v90; // rcx
		  TextureHandle v91; // xmm0
		  Object *v92; // r15
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  TextureHandle v95; // xmm0
		  int32_t m_X; // r15d
		  int32_t i; // r12d
		  ProfilingSampler *v98; // rax
		  __int64 v99; // rcx
		  Object *v100; // rdx
		  unsigned int v101; // edx
		  unsigned __int64 v102; // r8
		  char v103; // dl
		  signed __int64 v104; // rtt
		  __int64 v105; // rdx
		  __int64 v106; // rcx
		  TextureHandle v107; // xmm0
		  __int64 v108; // rdx
		  __int64 v109; // rcx
		  TextureHandle v110; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v112; // rdx
		  __int64 v113; // rcx
		  MethodInfo *v114; // [rsp+20h] [rbp-2E8h]
		  __m128i bloomTint; // [rsp+50h] [rbp-2B8h] BYREF
		  Void *v116; // [rsp+60h] [rbp-2A8h]
		  _QWORD v117[2]; // [rsp+68h] [rbp-2A0h] BYREF
		  Object *v118; // [rsp+78h] [rbp-290h] BYREF
		  Object *v119; // [rsp+80h] [rbp-288h] BYREF
		  Vector2Int size; // [rsp+88h] [rbp-280h]
		  Vector4 v121; // [rsp+90h] [rbp-278h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v122; // [rsp+A0h] [rbp-268h] BYREF
		  HGRenderGraphBuilder v123; // [rsp+B0h] [rbp-258h] BYREF
		  HGRenderGraphBuilder v124; // [rsp+D0h] [rbp-238h] BYREF
		  HGRenderGraphBuilder v125; // [rsp+F0h] [rbp-218h] BYREF
		  HGRenderGraphProfilingScope v126; // [rsp+110h] [rbp-1F8h] BYREF
		  TextureDesc v127; // [rsp+130h] [rbp-1D8h] BYREF
		  Il2CppExceptionWrapper *v128; // [rsp+190h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v129; // [rsp+198h] [rbp-170h] BYREF
		  Il2CppExceptionWrapper *v130; // [rsp+1A0h] [rbp-168h] BYREF
		  HGRenderGraphBuilder v131; // [rsp+1A8h] [rbp-160h] BYREF
		  TextureDesc v132; // [rsp+1D0h] [rbp-138h] BYREF
		  TextureHandle v133; // [rsp+230h] [rbp-D8h] BYREF
		  TextureHandle v134; // [rsp+240h] [rbp-C8h] BYREF
		
		  v9 = (Object *)this;
		  v122 = 0LL;
		  sub_18033B9D0(&v132, 0LL, 96LL);
		  sub_18033B9D0(&v127, 0LL, 96LL);
		  memset(&v126, 0, sizeof(v126));
		  memset(&v124, 0, sizeof(v124));
		  v118 = 0LL;
		  memset(&v125, 0, sizeof(v125));
		  v119 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3293, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3293, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v113, v112);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1213(
		      Patch,
		      v9,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    v13 = InterpolatedPhase;
		    if ( !InterpolatedPhase )
		      sub_1800D8260(v12, v11);
		    p_lightShaftConfig = &InterpolatedPhase->fields.lightShaftConfig;
		    enableLightShaft = input->enableLightShaft;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		    ShouldRenderLightShaft = HG::Rendering::Runtime::LightShaftPassConstructor::ShouldRenderLightShaft(
		                               p_lightShaftConfig,
		                               enableLightShaft,
		                               camera,
		                               0LL);
		    output->enableLightShaft = ShouldRenderLightShaft;
		    if ( ShouldRenderLightShaft )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		      v19 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightShaftPassConstructor::GetDirectionalLightScreenPos(
		                                                       (Vector4 *)&bloomTint,
		                                                       p_lightShaftConfig,
		                                                       camera,
		                                                       0LL));
		      v17 = _mm_shuffle_ps(v19, v19, 255).m128_f32[0];
		      v18 = (__m128)0x3F000000u;
		      v18.m128_f32[0] = 0.5 - (float)((float)(_mm_shuffle_ps(v19, v19, 85).m128_f32[0] * 0.5) / v17);
		      v19.m128_f32[0] = (float)((float)(v19.m128_f32[0] * 0.5) / v17) + 0.5;
		      downSampleFactor = input->downSampleFactor;
		      klass = (Material *)v9[1].klass;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      LODWORD(v117[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams0;
		      occlusionDepthRange = p_lightShaftConfig->occlusionDepthRange;
		      bloomScale = p_lightShaftConfig->bloomScale;
		      occlusionMaskDarkness = p_lightShaftConfig->occlusionMaskDarkness;
		      bloomMaxBrightness = p_lightShaftConfig->bloomMaxBrightness;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v28 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                               (Vector4 *)&bloomTint,
		                                               1.0 / occlusionDepthRange,
		                                               bloomScale,
		                                               occlusionMaskDarkness,
		                                               bloomMaxBrightness,
		                                               0LL));
		      if ( !klass )
		        sub_1800D8260(v27, v26);
		      bloomTint = v28;
		      UnityEngine::Material::SetVector(klass, v117[0], (Vector4 *)&bloomTint, 0LL);
		      v29 = (Material *)v9[1].klass;
		      LODWORD(v117[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams1;
		      bloomTint = (__m128i)p_lightShaftConfig->bloomTint;
		      v32 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                               &v121,
		                                               (Color *)&bloomTint,
		                                               p_lightShaftConfig->bloomThreshold,
		                                               0LL));
		      if ( !v29 )
		        sub_1800D8260(v31, v30);
		      bloomTint = v32;
		      UnityEngine::Material::SetVector(v29, v117[0], (Vector4 *)&bloomTint, 0LL);
		      v33 = (Material *)v9[1].klass;
		      LODWORD(v117[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams2;
		      v36 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                               (Vector4 *)&bloomTint,
		                                               (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v19, v18),
		                                               (float)input->lightShaftSampleNum,
		                                               p_lightShaftConfig->blurIntensity,
		                                               0LL));
		      if ( !v33 )
		        sub_1800D8260(v35, v34);
		      bloomTint = v36;
		      UnityEngine::Material::SetVector(v33, v117[0], (Vector4 *)&bloomTint, 0LL);
		      v37 = (Material *)v9[1].klass;
		      LightShaftParams3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams3;
		      v41 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                               (Vector4 *)&bloomTint,
		                                               downSampleFactor,
		                                               1.0 / downSampleFactor,
		                                               0.0,
		                                               0.0,
		                                               0LL));
		      if ( !v37 )
		        sub_1800D8260(v40, v39);
		      bloomTint = v41;
		      UnityEngine::Material::SetVector(v37, LightShaftParams3, (Vector4 *)&bloomTint, 0LL);
		      if ( v13->fields.cloudConfig.enableLightShaftCloudMask
		        && (lightShaftCloudMaskTexture = (Object_1 *)v13->fields.cloudConfig.lightShaftCloudMaskTexture,
		            sub_1800036A0(TypeInfo::UnityEngine::Object),
		            UnityEngine::Object::op_Inequality(lightShaftCloudMaskTexture, 0LL, 0LL)) )
		      {
		        v43 = (Material *)v9[1].klass;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !v43 )
		          sub_1800D8260(v44, static_fields);
		        UnityEngine::Material::EnableKeyword(v43, static_fields->s_LightShaftCloudMask, 0LL);
		        v46 = (Material *)v9[1].klass;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        v48 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( !v46 )
		          sub_1800D8260(v48, v47);
		        UnityEngine::Material::SetTextureImpl(
		          v46,
		          v48->_LightShaftCloudMask,
		          v13->fields.cloudConfig.lightShaftCloudMaskTexture,
		          0LL);
		        v49 = (Material *)v9[1].klass;
		        LightShaftCloudMaskParams = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftCloudMaskParams;
		        rotation = v13->fields.cloudConfig.rotation;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v54 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                 (Vector4 *)&bloomTint,
		                                                 (float)rotation,
		                                                 0LL));
		        if ( !v49 )
		          sub_1800D8260(v53, v52);
		        bloomTint = v54;
		        UnityEngine::Material::SetVector(v49, LightShaftCloudMaskParams, (Vector4 *)&bloomTint, 0LL);
		      }
		      else
		      {
		        v55 = (Material *)v9[1].klass;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        v57 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !v55 )
		          sub_1800D8260(v56, v57);
		        UnityEngine::Material::DisableKeyword(v55, v57->s_LightShaftCloudMask, 0LL);
		      }
		      Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		        &v122,
		        2,
		        Allocator__Enum_Temp,
		        NativeArrayOptions__Enum_ClearMemory,
		        MethodInfo::Unity::Collections::NativeArray<HG::Rendering::RenderGraphModule::TextureHandle>::NativeArray);
		      v60 = 0;
		      m_Buffer = v122.m_Buffer;
		      if ( v122.m_Length > 0 )
		      {
		        v116 = v122.m_Buffer;
		        v117[0] = 32LL;
		        do
		        {
		          if ( !camera )
		            sub_1800D8260(v59, v58);
		          v62 = sub_182F3EA70(v59, v58);
		          v64 = sub_182F3EA70(HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField), v63);
		          size = (Vector2Int)__PAIR64__(v64, v62);
		          HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v127, (Vector2Int)__PAIR64__(v64, v62), 0LL);
		          v127.colorFormat = 74;
		          v127.enableRandomWrite = 0;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		          v68 = TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields;
		          s_lightShaftPingPongRTName = v68->s_lightShaftPingPongRTName;
		          if ( !s_lightShaftPingPongRTName )
		            sub_1800D8260(v68, v65);
		          if ( (unsigned int)v60 >= s_lightShaftPingPongRTName->max_length.size )
		            sub_1800D2AB0(v68, v65);
		          v127.name = *(String **)((char *)&s_lightShaftPingPongRTName->klass + v117[0]);
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v127.name, v65, v66, v67, v114);
		          v127.wrapMode = 1;
		          v127.filterMode = 1;
		          v132 = v127;
		          if ( !renderGraph )
		            sub_1800D8260(v71, v70);
		          v72 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                   (TextureHandle *)&bloomTint,
		                   renderGraph,
		                   &v132,
		                   0LL);
		          v73 = v116;
		          *(TextureHandle *)v116 = v72;
		          ++v60;
		          v117[0] += 8LL;
		          v116 = v73 + 16;
		        }
		        while ( v60 < v122.m_Length );
		        v9 = (Object *)this;
		        m_Buffer = v122.m_Buffer;
		      }
		      v74 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0xA3u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		        &v126,
		        renderGraph,
		        v74,
		        0LL);
		      bloomTint.m128i_i64[0] = 0LL;
		      bloomTint.m128i_i64[1] = (__int64)&v126;
		      try
		      {
		        v75 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0xA4u,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        if ( !renderGraph )
		          sub_1800D8250(v77, v76);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          &v131,
		          renderGraph,
		          (String *)"Light Shaft Down Sample",
		          &v118,
		          v75,
		          1,
		          ProfilingHGPass__Enum_None,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
		        v124 = v131;
		        v117[0] = 0LL;
		        v117[1] = &v124;
		        try
		        {
		          v79 = v118;
		          if ( !v118 )
		            sub_1800D8250(v78, 0LL);
		          v118[1].klass = v9[1].klass;
		          if ( dword_18F35FD08 )
		          {
		            v80 = ((unsigned __int64)&v79[1] >> 12) & 0x1FFFFF;
		            v81 = (unsigned __int64)v80 >> 6;
		            v82 = v80 & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v81 + 36190]);
		            do
		              v83 = qword_18F0BCBA0[v81 + 36190];
		            while ( v83 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v81 + 36190], v83 | (1LL << v82), v83) );
		          }
		          v84 = v118;
		          v87 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&v121,
		                   &v124,
		                   &input->sceneColor,
		                   0LL);
		          if ( !v84 )
		            sub_1800D8250(v86, v85);
		          *(TextureHandle *)&v84[1].monitor = v87;
		          v88 = v118;
		          v91 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&v121,
		                   &v124,
		                   &input->sceneDepth,
		                   0LL);
		          if ( !v88 )
		            sub_1800D8250(v90, v89);
		          *(TextureHandle *)&v88[2].monitor = v91;
		          v92 = v118;
		          *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)m_Buffer;
		          v95 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                   (TextureHandle *)&v121,
		                   &v124,
		                   (TextureHandle *)&v123,
		                   0LL);
		          if ( !v92 )
		            sub_1800D8250(v94, v93);
		          *(TextureHandle *)&v92[3].monitor = v95;
		          if ( !v118 )
		            sub_1800D8250(v94, v93);
		          v121 = 0LL;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v123,
		            &v124,
		            (TextureHandle *)&v118[3].monitor,
		            0,
		            RenderBufferLoadAction__Enum_DontCare,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&v121,
		            0,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v124,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields->s_lightShaftDownSampleRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v128 )
		        {
		          v117[0] = v128->ex;
		          sub_180268AE0(v117);
		          v9 = (Object *)this;
		          m_Buffer = v122.m_Buffer;
		          goto LABEL_37;
		        }
		        sub_180268AE0(v117);
		LABEL_37:
		        m_X = 1;
		        size.m_X = 1;
		        for ( i = 0; ; ++i )
		        {
		          LODWORD(v117[0]) = i;
		          if ( i >= input->lightShaftBlurPassCount )
		            break;
		          v98 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                  (Int32Enum__Enum)0xA5u,
		                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		          HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		            &v123,
		            renderGraph,
		            (String *)"Light Shaft Radial Blur",
		            &v119,
		            v98,
		            1,
		            ProfilingHGPass__Enum_None,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
		          v125 = v123;
		          *(_QWORD *)&v121.x = 0LL;
		          *(_QWORD *)&v121.z = &v125;
		          try
		          {
		            v100 = v119;
		            if ( !v119 )
		              sub_1800D8250(v99, 0LL);
		            v119[1].klass = v9[1].klass;
		            if ( dword_18F35FD08 )
		            {
		              v101 = ((unsigned __int64)&v100[1] >> 12) & 0x1FFFFF;
		              v102 = (unsigned __int64)v101 >> 6;
		              v103 = v101 & 0x3F;
		              _m_prefetchw(&qword_18F0BCBA0[v102 + 36190]);
		              do
		                v104 = qword_18F0BCBA0[v102 + 36190];
		              while ( v104 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v102 + 36190], v104 | (1LL << v103), v104) );
		            }
		            v116 = (Void *)v119;
		            *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)&m_Buffer[16 * (1 - m_X)];
		            v107 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                      &v133,
		                      &v125,
		                      (TextureHandle *)&v123,
		                      0LL);
		            if ( !v116 )
		              sub_1800D8250(v106, v105);
		            *(TextureHandle *)&v116[24] = v107;
		            v116 = (Void *)v119;
		            *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)&m_Buffer[16 * m_X];
		            v110 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                      &v134,
		                      &v125,
		                      (TextureHandle *)&v123,
		                      0LL);
		            if ( !v116 )
		              sub_1800D8250(v109, v108);
		            *(TextureHandle *)&v116[40] = v110;
		            if ( !v119 )
		              sub_1800D8250(v109, v108);
		            LODWORD(v119[3].monitor) = i;
		            if ( !v119 )
		              sub_1800D8250(v109, v108);
		            *(_OWORD *)&v123.m_RenderPass = 0LL;
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		              (TextureHandle *)&v131,
		              &v125,
		              (TextureHandle *)&v119[2].monitor,
		              0,
		              RenderBufferLoadAction__Enum_DontCare,
		              RenderBufferStoreAction__Enum_Store,
		              (Color *)&v123,
		              0,
		              0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		              &v125,
		              (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor->static_fields->s_lightShaftRadialBlurRenderFunc,
		              0LL,
		              0,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
		          }
		          catch ( Il2CppExceptionWrapper *v129 )
		          {
		            *(Il2CppExceptionWrapper *)&v121.x = (Il2CppExceptionWrapper)v129->ex;
		            sub_180268AE0(&v121);
		            v9 = (Object *)this;
		            m_Buffer = v122.m_Buffer;
		            m_X = size.m_X;
		            i = v117[0];
		            goto LABEL_50;
		          }
		          sub_180268AE0(&v121);
		LABEL_50:
		          m_X = 1 - m_X;
		          size.m_X = m_X;
		        }
		        output->lightShaftBlurResult = *(TextureHandle *)&m_Buffer[16 * (1 - m_X)];
		      }
		      catch ( Il2CppExceptionWrapper *v130 )
		      {
		        *(Il2CppExceptionWrapper *)bloomTint.m128i_i8 = (Il2CppExceptionWrapper)v130->ex;
		        sub_180269330(&bloomTint);
		        return;
		      }
		      sub_180269330(&bloomTint);
		    }
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BCD958-0x0000000189BCD9AC
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        LightShaftPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3295, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3295, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCD904-0x0000000189BCD958
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        LightShaftPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3296, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3296, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BCD62C-0x0000000189BCD6F8
		// Void ConstructPass(LightShaftPassConstructor+PassInput ByRef, LightShaftPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::LightShaftPassConstructor::ConstructPass(
		        LightShaftPassConstructor *this,
		        LightShaftPassConstructor_PassInput *input,
		        LightShaftPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3297, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3297, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1213(
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
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    if ( HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(camera, 0LL) )
		      HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftPass(this, input, output, renderGraph, camera, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCD8B0-0x0000000189BCD904
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        LightShaftPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3298, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3298, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D3AB90-0x0000000184D3AC00
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        LightShaftPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object_1 *m_lightShaftMaterial; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3299, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3299, 0LL);
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
		    m_lightShaftMaterial = (Object_1 *)this->fields.m_lightShaftMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_lightShaftMaterial, 0LL);
		    this->fields.m_lightShaftMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v12);
		  }
		}
		
	}
}
