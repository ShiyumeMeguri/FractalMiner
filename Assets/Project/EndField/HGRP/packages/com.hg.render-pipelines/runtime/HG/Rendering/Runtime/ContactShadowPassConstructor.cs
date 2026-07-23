using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ContactShadowPassConstructor : IPassConstructor // TypeDefIndex: 38195
	{
		// Fields
		private ContactShadowEnable m_contactShadowEnable; // 0x10
		private float m_contactShadowIntensity; // 0x14
		private float m_contactShadowSurfaceThickness; // 0x18
		private float m_contactShadowBilinearThreshold; // 0x1C
		private int m_contactShadowContrast; // 0x20
		private bool m_contactShadowIgnoreEdgePixels; // 0x24
		private uint m_contactShadowFrameIndex; // 0x28
		private readonly Vector4[] m_contactShadowParams; // 0x30
		private HGRenderPipelineRuntimeResources m_resources; // 0x38
		private const string CONTACT_SHADOW_RAY_TRACING_KERNEL = "RayTracing"; // Metadata: 0x02303BD1
		private const string CONTACT_SHADOW_RAY_TRACING_KERNEL_V2 = "RayTracingV2"; // Metadata: 0x02303BDC
		private readonly DispatchData[] m_contactShadowDispatchData; // 0x40
		private const int THREAD_COUNT = 64; // Metadata: 0x02303BE9
		private const float FP_LIMIT = 0.000128f; // Metadata: 0x02303BEB
		private static readonly ContactShadowPassDataV2 PASS_DATA_V2_CPP; // 0x00
		private static readonly RenderFunc<ContactShadowPassDataV2> s_contactShadowRenderFuncV2; // 0x08
		private static readonly RenderFunc<ContactShadowPassDataV2> s_contactShadowRenderFuncNoneV2; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38189
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal Vector4 lightDir; // 0x10
			internal float renderingScale; // 0x20
			internal bool contactShadowEnableParam; // 0x24
		}
	
		internal struct PassOutput // TypeDefIndex: 38190
		{
		}
	
		[Flags]
		private enum ContactShadowEnable // TypeDefIndex: 38191
		{
			PipelineEnable = 1,
			PlatformCapable = 2,
			AllEnable = 3
		}
	
		public struct DispatchData // TypeDefIndex: 38192
		{
			// Fields
			public Vector3Int workgroupCount; // 0x00
			public Vector2Int workgroupOffset; // 0x0C
		}
	
		internal class ContactShadowPassDataV2 // TypeDefIndex: 38193
		{
			// Fields
			public int rayTracingKernel; // 0x10
			public ComputeShader shader; // 0x18
			public Vector4[] dataParams; // 0x20
			public DispatchData[] dispatch; // 0x28
			public int dispatchCount; // 0x30
			public TextureHandle depthBufferHandle; // 0x34
			public TextureHandle contactShadowCurrHandle; // 0x44
	
			// Constructors
			public ContactShadowPassDataV2() {} // 0x00000001841E1670-0x00000001841E1680
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
		public ContactShadowPassConstructor() {} // Dummy constructor
		internal ContactShadowPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CAD360-0x0000000184CAD3F0
		// ContactShadowPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassConstructor(
		        ContactShadowPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Int32__Array **defaultResources; // r9
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_contactShadowIntensity = 0.5;
		  this->fields.m_contactShadowSurfaceThickness = 0.0080000004;
		  this->fields.m_contactShadowBilinearThreshold = 0.02;
		  this->fields.m_contactShadowContrast = 4;
		  this->fields.m_contactShadowParams = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                           TypeInfo::UnityEngine::Vector4,
		                                                           4LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_contactShadowParams, v5, v6, v7, v14);
		  this->fields.m_contactShadowDispatchData = (ContactShadowPassConstructor_DispatchData__Array *)il2cpp_array_new_specific_1(
		                                                                                                   TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::DispatchData,
		                                                                                                   8LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_contactShadowDispatchData, v8, v9, v10, v15);
		  defaultResources = (Int32__Array **)resources->defaultResources;
		  this->fields.m_resources = resources->defaultResources;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_resources, v12, v13, defaultResources, v16);
		}
		
		static ContactShadowPassConstructor() {} // 0x0000000184B518F0-0x0000000184B51A30
		// ContactShadowPassConstructor()
		void HG::Rendering::Runtime::ContactShadowPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *static_fields; // rdx
		  struct ContactShadowPassConstructor_c__Class *v7; // r9
		  Object *v8; // rdi
		  RenderFunc_1_System_Object_ *v9; // rax
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
		
		  v1 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2);
		  if ( !v1 )
		    goto LABEL_2;
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields,
		    static_fields,
		    v4,
		    v5,
		    v20);
		  v7 = TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c);
		    v7 = TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c;
		  }
		  v8 = (Object *)v7->static_fields->__9;
		  v9 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
		  v10 = (MonitorData *)v9;
		  if ( !v9
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v9,
		          v8,
		          MethodInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c::__cctor_b__31_0,
		          0LL),
		        v11 = (Type *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields,
		        v11->monitor = v10,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields->s_contactShadowRenderFuncV2,
		          v11,
		          v12,
		          v13,
		          v21),
		        v14 = (Object *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c->static_fields->__9,
		        v15 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>),
		        (v16 = v15) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v3, v2);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v15,
		    v14,
		    MethodInfo::HG::Rendering::Runtime::ContactShadowPassConstructor::__c::__cctor_b__31_1,
		    0LL);
		  v17 = (Type *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields;
		  v17->fields._impl.value = v16;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields->s_contactShadowRenderFuncNoneV2,
		    v17,
		    v18,
		    v19,
		    v22);
		}
		
	
		// Methods
		private void PrepareDataForContactShadow(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B91914-0x0000000189B919EC
		// Void PrepareDataForContactShadow(ContactShadowPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareDataForContactShadow(
		        ContactShadowPassConstructor *this,
		        ContactShadowPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  int v9; // ebx
		  _BOOL8 contactShadowEnableParam; // rdi
		  int32_t v11; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		
		  v9 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3028, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3028, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1124(
		      Patch,
		      (Object *)this,
		      input,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_contactShadowEnable = 0;
		    contactShadowEnableParam = input->contactShadowEnableParam;
		    this->fields.m_contactShadowEnable = contactShadowEnableParam;
		    if ( UnityEngine::SystemInfo::SupportsComputeShaders(0LL)
		      && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLCore
		      && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLES3 )
		    {
		      v9 = 2;
		    }
		    v11 = v9 | contactShadowEnableParam;
		    this->fields.m_contactShadowEnable = v11;
		    if ( v11 == 3 )
		      HG::Rendering::Runtime::ContactShadowPassConstructor::_InitContactShadowParams(this, camera, 0LL);
		  }
		}
		
		private void _InitContactShadowParams(HGCamera camera) {} // 0x0000000189B919EC-0x0000000189B91ADC
		// Void _InitContactShadowParams(HGCamera)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::_InitContactShadowParams(
		        ContactShadowPassConstructor *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __m128 v8; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3029, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    if ( InterpolatedPhase )
		    {
		      v8 = *(__m128 *)&InterpolatedPhase->fields.shadowConfig.contactShadowSurfaceThickness;
		      this->fields.m_contactShadowIntensity = InterpolatedPhase->fields.shadowConfig.contactShadowIntensity;
		      this->fields.m_contactShadowSurfaceThickness = v8.m128_f32[0] * 0.0099999998;
		      this->fields.m_contactShadowBilinearThreshold = _mm_shuffle_ps(v8, v8, 85).m128_f32[0] * 0.0099999998;
		      this->fields.m_contactShadowIgnoreEdgePixels = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v8, 12));
		      this->fields.m_contactShadowContrast = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v8, 8));
		      if ( camera )
		      {
		        this->fields.m_contactShadowFrameIndex = HG::Rendering::Runtime::HGCamera::GetCameraFrameCount(camera, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3029, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		internal void PrepareContactShadowPassDataV2(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera, ContactShadowPassDataV2 passData) {} // 0x0000000189B90EE4-0x0000000189B91914
		// Void PrepareContactShadowPassDataV2(ContactShadowPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, ContactShadowPassConstructor+ContactShadowPassDataV2)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareContactShadowPassDataV2(
		        ContactShadowPassConstructor *this,
		        ContactShadowPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        ContactShadowPassConstructor_ContactShadowPassDataV2 *passData,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  HGGraphicsFeatureSwitch *m_contactShadowParams; // rcx
		  int v12; // eax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  int v15; // r15d
		  int v16; // eax
		  int v17; // r12d
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __m128 v20; // xmm2
		  float v21; // xmm3_4
		  float v22; // xmm4_4
		  int v23; // xmm0_4
		  float v24; // xmm0_4
		  float v25; // xmm1_4
		  float v26; // xmm2_4
		  float v27; // xmm0_4
		  float v28; // xmm1_4
		  float *v29; // rax
		  int v30; // ebx
		  float v31; // xmm0_4
		  ContactShadowPassConstructor_ContactShadowPassDataV2 *v32; // r12
		  int v33; // r13d
		  int v34; // eax
		  int v35; // ecx
		  int v36; // r15d
		  int v37; // ebx
		  int v38; // edi
		  int v39; // eax
		  int v40; // ebx
		  int v41; // eax
		  int v42; // ebx
		  int v43; // eax
		  int v44; // edi
		  int v45; // ebx
		  int v46; // eax
		  int v47; // eax
		  int v48; // ecx
		  int v49; // edi
		  int v50; // ebx
		  int32_t dispatchCount; // eax
		  _DWORD *v52; // rax
		  int v53; // ecx
		  _DWORD *v54; // r15
		  int v55; // edx
		  int v56; // ebx
		  int v57; // eax
		  int v58; // eax
		  unsigned int v59; // edx
		  int v60; // eax
		  __int64 v61; // rt2
		  int32_t v62; // edi
		  __int64 v63; // rax
		  __int64 v64; // rax
		  MethodInfo *v65; // r8
		  int v66; // ecx
		  Vector3Int *v67; // r12
		  int32_t v68; // ebx
		  int v69; // ecx
		  int32_t v70; // ebx
		  int v71; // ecx
		  int32_t v72; // ebx
		  int32_t v73; // ebx
		  MethodInfo *v74; // r8
		  int32_t Item; // ebx
		  MethodInfo *v76; // r8
		  MethodInfo *v77; // r8
		  int32_t v78; // ebx
		  MethodInfo *v79; // r8
		  MethodInfo *v80; // r8
		  MethodInfo *v81; // r8
		  MethodInfo *v82; // r8
		  ContactShadowPassConstructor_DispatchData__Array *m_contactShadowDispatchData; // r8
		  char *v84; // rax
		  __int64 v85; // rcx
		  int32_t i; // ebx
		  __int64 v87; // rax
		  __int64 v88; // rax
		  float m_contactShadowIntensity; // xmm6_4
		  float m_contactShadowBilinearThreshold; // xmm1_4
		  __m128i v91; // xmm0
		  Vector4__Array *v92; // rdi
		  bool m_contactShadowIgnoreEdgePixels; // bl
		  signed int v94; // eax
		  HGRenderPipelineRuntimeResources *m_resources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  ComputeShader *contactShadowCS; // r14
		  Type *v98; // rdx
		  PropertyInfo_1 *v99; // r8
		  Int32__Array **v100; // r9
		  String *s_DisableTerrainContactShadow; // rdi
		  bool ShouldDisableContactShadow; // bl
		  Type *v103; // rdx
		  PropertyInfo_1 *v104; // r8
		  Int32__Array **v105; // r9
		  Int32__Array **v106; // r9
		  Type *v107; // rdx
		  PropertyInfo_1 *v108; // r8
		  MethodInfo *v109; // [rsp+10h] [rbp-30h]
		  MethodInfo *v110; // [rsp+10h] [rbp-30h]
		  MethodInfo *v111; // [rsp+10h] [rbp-30h]
		  int v112; // [rsp+30h] [rbp-10h]
		  int v113; // [rsp+34h] [rbp-Ch]
		  int v114; // [rsp+38h] [rbp-8h]
		  int v115; // [rsp+3Ch] [rbp-4h]
		  Vector4 lightDir; // [rsp+40h] [rbp+0h] BYREF
		  int v117; // [rsp+50h] [rbp+10h]
		  int v118; // [rsp+54h] [rbp+14h]
		  int v119; // [rsp+58h] [rbp+18h]
		  BOOL v120; // [rsp+5Ch] [rbp+1Ch]
		  int32_t v121; // [rsp+60h] [rbp+20h]
		  int v122; // [rsp+64h] [rbp+24h]
		  int v123; // [rsp+68h] [rbp+28h]
		  TextureDesc v124; // [rsp+70h] [rbp+30h] BYREF
		  Vector4 v125; // [rsp+D0h] [rbp+90h] BYREF
		  TextureDesc v126; // [rsp+E0h] [rbp+A0h] BYREF
		  Matrix4x4 v127; // [rsp+140h] [rbp+100h] BYREF
		
		  sub_18033B9D0(&v126, 0LL, 96LL);
		  sub_18033B9D0(&v124, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3030, 0LL) )
		  {
		    if ( !camera )
		      goto LABEL_108;
		    v12 = sub_182F3EA70(m_contactShadowParams, v10);
		    v15 = 1;
		    if ( v12 > 1 )
		      v15 = v12;
		    v122 = v15;
		    v16 = sub_182F3EA70(v14, v13);
		    v17 = 1;
		    if ( v16 > 1 )
		      v17 = v16;
		    v123 = v17;
		    v18 = *(_OWORD *)&camera->fields.mainViewConstants.viewProjMatrix.m00;
		    lightDir = input->lightDir;
		    lightDir.w = 0.0;
		    *(_OWORD *)&v127.m00 = v18;
		    v19 = *(_OWORD *)&camera->fields.mainViewConstants.viewProjMatrix.m01;
		    *(_OWORD *)&v127.m02 = *(_OWORD *)&camera->fields.mainViewConstants.viewProjMatrix.m02;
		    *(_OWORD *)&v127.m01 = v19;
		    *(_OWORD *)&v127.m03 = *(_OWORD *)&camera->fields.mainViewConstants.viewProjMatrix.m03;
		    v20 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(&v125, &v127, &lightDir, 0LL));
		    v21 = _mm_shuffle_ps(v20, v20, 255).m128_f32[0];
		    v22 = v21;
		    if ( v21 >= 0.0 && (*(float *)&v23 = 0.000128, v21 < 0.000128)
		      || v21 < 0.0 && (*(float *)&v23 = -0.000128, v21 > -0.000128) )
		    {
		      v22 = *(float *)&v23;
		    }
		    v24 = _mm_shuffle_ps(v20, v20, 85).m128_f32[0] / v22;
		    v25 = v20.m128_f32[0] / v22;
		    v26 = v21 == 0.0 ? 0.0 : _mm_shuffle_ps(v20, v20, 170).m128_f32[0] / v21;
		    v27 = (float)(v24 * -0.5) + 0.5;
		    v28 = (float)(v25 * 0.5) + 0.5;
		    v10 = v21 <= 0.0 ? 0xFFFFFFFFLL : 1LL;
		    m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowParams;
		    lightDir.z = v26;
		    lightDir.y = v27 * (float)v17;
		    lightDir.x = v28 * (float)v15;
		    lightDir.w = (float)(int)v10;
		    if ( !m_contactShadowParams )
		      goto LABEL_108;
		    sub_18003FEF0(m_contactShadowParams, 2LL, &lightDir);
		    m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowParams;
		    if ( !m_contactShadowParams )
		      goto LABEL_108;
		    v29 = (float *)sub_180002100(m_contactShadowParams, 2LL);
		    m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowParams;
		    if ( !m_contactShadowParams )
		      goto LABEL_108;
		    v30 = (int)(float)(*v29 + 0.5);
		    v31 = *(float *)(sub_180002100(m_contactShadowParams, 2LL) + 4) + 0.5;
		    v112 = -v30;
		    v113 = v17 - (int)v31;
		    v114 = v15 - v30;
		    v32 = passData;
		    m_contactShadowParams = (HGGraphicsFeatureSwitch *)(unsigned int)-(int)v31;
		    v115 = -(int)v31;
		    if ( !passData )
		      goto LABEL_108;
		    passData->fields.dispatchCount = 0;
		    v33 = 0;
		    while ( 1 )
		    {
		      if ( v33 )
		      {
		        if ( v33 == 3 )
		        {
		          v38 = 0;
		          v36 = 1;
		LABEL_33:
		          v37 = v112;
		          goto LABEL_26;
		        }
		        v34 = 0;
		        v36 = 0;
		        v38 = 1;
		        v35 = 1;
		        if ( (v33 & 1) != 0 )
		          goto LABEL_33;
		      }
		      else
		      {
		        v34 = 1;
		        v35 = 0;
		      }
		      v36 = v34;
		      v37 = -v114;
		      v38 = v35;
		LABEL_26:
		      sub_1800036A0(TypeInfo::System::Math);
		      v39 = 0;
		      if ( v37 > 0 )
		        v39 = v37;
		      v117 = v39 / 64;
		      if ( (v33 & 2) != 0 )
		        v40 = -v113;
		      else
		        v40 = v115;
		      sub_1800036A0(TypeInfo::System::Math);
		      v41 = 0;
		      if ( v40 > 0 )
		        v41 = v40;
		      v118 = v41 / 64;
		      if ( (v33 & 1) != 0 )
		        v42 = v114;
		      else
		        v42 = -v112;
		      sub_1800036A0(TypeInfo::System::Math);
		      v43 = 0;
		      if ( v42 + (v38 << 6) + 63 > 0 )
		        v43 = v42 + (v38 << 6) + 63;
		      v119 = v43 / 64;
		      v44 = v43 / 64;
		      if ( (v33 & 2) != 0 )
		        v45 = -v115;
		      else
		        v45 = v113;
		      sub_1800036A0(TypeInfo::System::Math);
		      v46 = 0;
		      if ( (v36 << 6) + v45 + 63 > 0 )
		        v46 = (v36 << 6) + v45 + 63;
		      v10 = (unsigned int)(v46 >> 31);
		      LODWORD(v10) = v46 % 64;
		      v47 = v46 / 64;
		      v48 = v44;
		      v49 = v117;
		      v50 = v47;
		      if ( v48 - v117 > 0 && v47 - v118 > 0 )
		      {
		        v117 = (unsigned int)(v33 - 2) <= 1;
		        v120 = ((v33 - 1) & 0xFFFFFFFD) == 0;
		        dispatchCount = v32->fields.dispatchCount;
		        m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowDispatchData;
		        v10 = dispatchCount;
		        v121 = dispatchCount;
		        v32->fields.dispatchCount = dispatchCount + 1;
		        if ( !m_contactShadowParams )
		          goto LABEL_108;
		        v52 = (_DWORD *)sub_18046BB4C(m_contactShadowParams, dispatchCount);
		        v53 = v119;
		        v54 = v52;
		        v55 = v118;
		        *v52 = 64;
		        v52[1] = v53 - v49;
		        v52[2] = v50 - v55;
		        if ( (v33 & 1) == 0 )
		          v49 = -v53;
		        v52[3] = v49 + v117;
		        v56 = (v33 & 2) != 0 ? -v50 : v55;
		        v52[4] = v56 + v120;
		        v57 = v113 + v112;
		        switch ( v33 )
		        {
		          case 1:
		            v57 = v114 - v113;
		            break;
		          case 2:
		            v57 = v115 - v112;
		            break;
		          case 3:
		            v57 = -(v114 + v115);
		            break;
		        }
		        v59 = (v57 + 63) >> 31;
		        v58 = v57 + 63;
		        v10 = v59;
		        v61 = __SPAIR64__(v59, v58) % 64;
		        v60 = __SPAIR64__(v59, v58) / 64;
		        LODWORD(v10) = v61;
		        v62 = v60;
		        if ( v60 > 0 )
		        {
		          v63 = v32->fields.dispatchCount;
		          m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowDispatchData;
		          v10 = (unsigned int)(v63 + 1);
		          v32->fields.dispatchCount = v10;
		          if ( !m_contactShadowParams )
		            goto LABEL_108;
		          v64 = sub_18046BB4C(m_contactShadowParams, v63);
		          v66 = v54[2];
		          v67 = (Vector3Int *)v64;
		          *(_QWORD *)v64 = *(_QWORD *)v54;
		          *(_DWORD *)(v64 + 8) = v66;
		          *(_QWORD *)(v64 + 12) = *(_QWORD *)(v54 + 3);
		          if ( v33 )
		          {
		            switch ( v33 )
		            {
		              case 1:
		                v70 = v54[1];
		                sub_1800036A0(TypeInfo::System::Math);
		                if ( v70 <= v62 )
		                  v62 = v70;
		                v67->m_Y = v62;
		                v71 = v54[1] - v62;
		                v54[1] = v71;
		                v67[1].m_X = v71 + v54[3];
		                ++v67->m_Z;
		                break;
		              case 2:
		                v72 = v54[1];
		                sub_1800036A0(TypeInfo::System::Math);
		                if ( v72 <= v62 )
		                  v62 = v72;
		                v67->m_Y = v62;
		                v54[1] -= v62;
		                v54[3] += v67->m_Y;
		                ++v67->m_Z;
		                --v67[1].m_Y;
		                break;
		              case 3:
		                v73 = v54[2];
		                sub_1800036A0(TypeInfo::System::Math);
		                if ( v73 <= v62 )
		                  v62 = v73;
		                v67->m_Z = v62;
		                Item = UnityEngine::Vector3Int::get_Item((Vector3Int *)v54, 2, v74);
		                v54[2] = Item - UnityEngine::Vector3Int::get_Item(v67, 2, v76);
		                v78 = UnityEngine::Vector2Int::get_Item((Vector2Int *)(v54 + 3), 1, v77);
		                v54[4] = v78 + UnityEngine::Vector3Int::get_Item(v67, 2, v79);
		                v67->m_Y = UnityEngine::Vector3Int::get_Item(v67, 1, v80) + 1;
		                break;
		            }
		          }
		          else
		          {
		            v68 = v54[2];
		            sub_1800036A0(TypeInfo::System::Math);
		            if ( v68 <= v62 )
		              v62 = v68;
		            v67->m_Z = v62;
		            v69 = v54[2] - v62;
		            v54[2] = v69;
		            v67[1].m_Y = v69 + v54[4];
		            --v67[1].m_X;
		            ++v67->m_Y;
		          }
		          if ( UnityEngine::Vector3Int::get_Item(v67, 1, v65) > 0 && UnityEngine::Vector3Int::get_Item(v67, 2, v81) > 0 )
		          {
		            v32 = passData;
		          }
		          else
		          {
		            v32 = passData;
		            --passData->fields.dispatchCount;
		          }
		          if ( UnityEngine::Vector3Int::get_Item((Vector3Int *)v54, 1, v81) <= 0
		            || UnityEngine::Vector3Int::get_Item((Vector3Int *)v54, 2, v82) <= 0 )
		          {
		            m_contactShadowParams = (HGGraphicsFeatureSwitch *)v32->fields.dispatchCount;
		            m_contactShadowDispatchData = this->fields.m_contactShadowDispatchData;
		            v32->fields.dispatchCount = (_DWORD)m_contactShadowParams - 1;
		            if ( !m_contactShadowDispatchData )
		              goto LABEL_108;
		            v84 = (char *)&m_contactShadowParams[-1].fields + 7;
		            if ( (unsigned int)((_DWORD)m_contactShadowParams - 1) >= m_contactShadowDispatchData->max_length.size
		              || (unsigned int)v121 >= m_contactShadowDispatchData->max_length.size )
		            {
		              sub_1800D2AB0(m_contactShadowParams, v10);
		            }
		            v85 = v121;
		            *(_OWORD *)&m_contactShadowDispatchData->vector[v85].workgroupCount.m_X = *(_OWORD *)&m_contactShadowDispatchData->vector[(_QWORD)v84].workgroupCount.m_X;
		            m_contactShadowDispatchData->vector[v85].workgroupOffset.m_Y = m_contactShadowDispatchData->vector[(_QWORD)v84].workgroupOffset.m_Y;
		          }
		        }
		      }
		      if ( ++v33 >= 4 )
		      {
		        for ( i = 0; i < v32->fields.dispatchCount; ++i )
		        {
		          m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowDispatchData;
		          if ( !m_contactShadowParams )
		            goto LABEL_108;
		          v87 = sub_18046BB4C(m_contactShadowParams, i);
		          *(_DWORD *)(v87 + 12) <<= 6;
		          m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowDispatchData;
		          if ( !m_contactShadowParams )
		            goto LABEL_108;
		          v88 = sub_18046BB4C(m_contactShadowParams, i);
		          *(_DWORD *)(v88 + 16) <<= 6;
		        }
		        m_contactShadowIntensity = this->fields.m_contactShadowIntensity;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        m_contactShadowParams = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->contactShadow;
		        if ( m_contactShadowParams )
		        {
		          if ( !HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(m_contactShadowParams, 0LL) )
		            m_contactShadowIntensity = 0.0;
		          m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowParams;
		          m_contactShadowBilinearThreshold = this->fields.m_contactShadowBilinearThreshold;
		          lightDir.x = this->fields.m_contactShadowSurfaceThickness;
		          v91 = _mm_cvtsi32_si128(this->fields.m_contactShadowContrast);
		          lightDir.y = m_contactShadowBilinearThreshold;
		          lightDir.w = m_contactShadowIntensity;
		          LODWORD(lightDir.z) = _mm_cvtepi32_ps(v91).m128_u32[0];
		          if ( m_contactShadowParams )
		          {
		            sub_18003FEF0(m_contactShadowParams, 0LL, &lightDir);
		            v92 = this->fields.m_contactShadowParams;
		            m_contactShadowIgnoreEdgePixels = this->fields.m_contactShadowIgnoreEdgePixels;
		            sub_1800036A0(TypeInfo::System::Convert);
		            *(_QWORD *)&lightDir.x = 0LL;
		            v94 = this->fields.m_contactShadowFrameIndex & 7;
		            lightDir.z = (float)m_contactShadowIgnoreEdgePixels;
		            lightDir.w = (float)v94;
		            if ( v92 )
		            {
		              sub_18003FEF0(v92, 1LL, &lightDir);
		              m_contactShadowParams = (HGGraphicsFeatureSwitch *)this->fields.m_contactShadowParams;
		              lightDir.x = (float)v122;
		              lightDir.y = (float)v123;
		              lightDir.z = 1.0 / (float)v122;
		              lightDir.w = 1.0 / (float)v123;
		              if ( m_contactShadowParams )
		              {
		                sub_18003FEF0(m_contactShadowParams, 3LL, &lightDir);
		                m_resources = this->fields.m_resources;
		                if ( m_resources )
		                {
		                  shaders = m_resources->fields.shaders;
		                  if ( shaders )
		                  {
		                    contactShadowCS = shaders->fields.contactShadowCS;
		                    if ( contactShadowCS )
		                    {
		                      v32->fields.rayTracingKernel = UnityEngine::ComputeShader::FindKernel(
		                                                       shaders->fields.contactShadowCS,
		                                                       (String *)"RayTracingV2",
		                                                       0LL);
		                      v32->fields.shader = contactShadowCS;
		                      sub_18002D1B0((SingleFieldAccessor *)&v32->fields.shader, v98, v99, v100, v109);
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                      s_DisableTerrainContactShadow = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableTerrainContactShadow;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		                      ShouldDisableContactShadow = HG::Rendering::Runtime::HGTerrainUtils::ShouldDisableContactShadow(0LL);
		                      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		                      UnityEngine::Rendering::CoreUtils::SetKeyword(
		                        contactShadowCS,
		                        s_DisableTerrainContactShadow,
		                        ShouldDisableContactShadow,
		                        0LL);
		                      v32->fields.dataParams = this->fields.m_contactShadowParams;
		                      sub_18002D1B0((SingleFieldAccessor *)&v32->fields.dataParams, v103, v104, v105, v110);
		                      v106 = (Int32__Array **)this->fields.m_contactShadowDispatchData;
		                      v32->fields.dispatch = (ContactShadowPassConstructor_DispatchData__Array *)v106;
		                      sub_18002D1B0((SingleFieldAccessor *)&v32->fields.dispatch, v107, v108, v106, v111);
		                      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		                        &v124,
		                        camera->fields._sceneRTSize_k__BackingField,
		                        0LL);
		                      v10 = (__int64)renderGraph;
		                      *(_WORD *)&v124.enableRandomWrite = 1;
		                      v124.colorFormat = 6;
		                      v124.wrapMode = 1;
		                      v124.filterMode = 1;
		                      v126 = v124;
		                      v32->fields.depthBufferHandle = input->sceneDepth;
		                      if ( renderGraph )
		                      {
		                        v32->fields.contactShadowCurrHandle = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                                 (TextureHandle *)&v125,
		                                                                 renderGraph,
		                                                                 &v126,
		                                                                 0LL);
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_108:
		        sub_1800D8260(m_contactShadowParams, v10);
		      }
		    }
		  }
		  m_contactShadowParams = (HGGraphicsFeatureSwitch *)IFix::WrappersManagerImpl::GetPatch(3030, 0LL);
		  if ( !m_contactShadowParams )
		    goto LABEL_108;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1125(
		    (ILFixDynamicMethodWrapper_2 *)m_contactShadowParams,
		    (Object *)this,
		    input,
		    (Object *)renderGraph,
		    (Object *)camera,
		    (Object *)passData,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B90E90-0x0000000189B90EE4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ContactShadowPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3031, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3031, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B90E3C-0x0000000189B90E90
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ContactShadowPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3032, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3032, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B90B4C-0x0000000189B90DE8
		// Void ConstructPass(ContactShadowPassConstructor+PassInput ByRef, ContactShadowPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::ContactShadowPassConstructor::ConstructPass(
		        ContactShadowPassConstructor *this,
		        ContactShadowPassConstructor_PassInput *input,
		        ContactShadowPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  ContactShadowPassConstructor_ContactShadowPassDataV2 *passData; // [rsp+40h] [rbp-68h] BYREF
		  _QWORD v19[2]; // [rsp+50h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v20; // [rsp+60h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v21; // [rsp+80h] [rbp-28h] BYREF
		
		  passData = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3033, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3033, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1126(
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
		    HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareDataForContactShadow(
		      this,
		      input,
		      renderGraph,
		      camera,
		      0LL);
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x6Au,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v20,
		      renderGraph,
		      (String *)"Contact Shadow",
		      (Object **)&passData,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
		    v21 = v20;
		    v19[0] = 0LL;
		    v19[1] = &v21;
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v21, 0, 0LL);
		    if ( this->fields.m_contactShadowEnable == 3 )
		    {
		      HG::Rendering::Runtime::ContactShadowPassConstructor::PrepareContactShadowPassDataV2(
		        this,
		        input,
		        renderGraph,
		        camera,
		        passData,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        (TextureHandle *)&v20,
		        &v21,
		        &input->sceneDepth,
		        0LL);
		      if ( !passData )
		        sub_1800D8250(v14, v13);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		        (TextureHandle *)&v20,
		        &v21,
		        &passData->fields.contactShadowCurrHandle,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v21,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields->s_contactShadowRenderFuncV2,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
		      sub_180268AE0(v19);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v21,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor->static_fields->s_contactShadowRenderFuncNoneV2,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassDataV2>);
		      sub_180268AE0(v19);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B90DE8-0x0000000189B90E3C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ContactShadowPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3034, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3034, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D807D0-0x0000000184D80800
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ContactShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ContactShadowPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3035, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3035, 0LL);
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
