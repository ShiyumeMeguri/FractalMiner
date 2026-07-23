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
	internal class LensFlarePassConstructor : IPassConstructor // TypeDefIndex: 38339
	{
		// Fields
		private Material m_lensFlareDataDrivenMaterial; // 0x10
		public const int LENS_FLARE_CB_VECTOR4_COUNT = 7; // Metadata: 0x02303C7F
		private static readonly RenderFunc<LensFlareDataDrivenData> s_lensFlareDataDrivenRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38333
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal ComputeBufferHandle debugFullscreenBuffer; // 0x10
		}
	
		internal struct PassOutput // TypeDefIndex: 38334
		{
		}
	
		private class LensFlareDataDrivenData // TypeDefIndex: 38335
		{
			// Fields
			public Material lensFlareDataDrivenMaterial; // 0x10
			public LensFlareCommonSRP lensFlares; // 0x18
			public Camera camera; // 0x20
			public bool debugFullscreen; // 0x28
			public ComputeBufferHandle debugFullscreenBuffer; // 0x2C
			public float actualWidth; // 0x34
			public float actualHeight; // 0x38
			public bool usePanini; // 0x3C
			public float paniniDistance; // 0x40
			public float paniniCropToFit; // 0x44
			public Vector3 cameraPositionWS; // 0x48
			public Matrix4x4 gpuVP; // 0x54
			public int flareOcclusionTex; // 0x94
			public int flareOcclusionIndex; // 0x98
			public int flareTex; // 0x9C
			public int flareColorValue; // 0xA0
			public int flareData0; // 0xA4
			public int flareData1; // 0xA8
			public int flareData2; // 0xAC
			public int flareData3; // 0xB0
			public int flareData4; // 0xB4
			public TextureHandle source; // 0xB8
			public LensFlareCommonSRP.SunSourceDirLightOverrideInfo dirLightOverrideInfo; // 0xC8
	
			// Constructors
			public LensFlareDataDrivenData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public LensFlarePassConstructor() {} // Dummy constructor
		internal LensFlarePassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184B44B00-0x0000000184B44BD0
		// LensFlarePassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::LensFlarePassConstructor::LensFlarePassConstructor(
		        LensFlarePassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Material *m_lensFlareDataDrivenMaterial; // rbx
		  Shader **shaders; // rcx
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  m_lensFlareDataDrivenMaterial = this->fields.m_lensFlareDataDrivenMaterial;
		  shaders = (Shader **)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    shaders = (Shader **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      shaders = (Shader **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_lensFlareDataDrivenMaterial )
		    goto LABEL_11;
		  if ( !*((_DWORD *)shaders + 56) )
		    il2cpp_runtime_class_init_1(shaders);
		  if ( !m_lensFlareDataDrivenMaterial->fields._.m_CachedPtr )
		  {
		LABEL_11:
		    if ( !resources->defaultResources
		      || (shaders = (Shader **)resources->defaultResources->fields.shaders) == 0LL
		      || !materialCollector )
		    {
		      sub_1800D8260(shaders, materialCollector);
		    }
		    this->fields.m_lensFlareDataDrivenMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                   materialCollector,
		                                                   shaders[107],
		                                                   0,
		                                                   0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v9, v10, v11, v12);
		  }
		}
		
		static LensFlarePassConstructor() {} // 0x0000000184D2CC40-0x0000000184D2CCD0
		// LensFlarePassConstructor()
		void HG::Rendering::Runtime::LensFlarePassConstructor::cctor(MethodInfo *method)
		{
		  struct LensFlarePassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_LensFlarePassConstructor_LensFlareDataDrivenData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_LensFlarePassConstructor_LensFlareDataDrivenData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::LensFlarePassConstructor::__c::__cctor_b__17_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->static_fields->s_lensFlareDataDrivenRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		private void Release() {} // 0x0000000184CD91C0-0x0000000184CD9280
		// Void Release()
		void HG::Rendering::Runtime::LensFlarePassConstructor::Release(LensFlarePassConstructor *this, MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  Material *m_lensFlareDataDrivenMaterial; // rdi
		  Object_1 *v5; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3233, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3233, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::UnityEngine::Object;
		    m_lensFlareDataDrivenMaterial = this->fields.m_lensFlareDataDrivenMaterial;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_lensFlareDataDrivenMaterial )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v3);
		      if ( m_lensFlareDataDrivenMaterial->fields._.m_CachedPtr )
		      {
		        v5 = (Object_1 *)this->fields.m_lensFlareDataDrivenMaterial;
		        if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        UnityEngine::Rendering::CoreUtils::Destroy(v5, 0LL);
		        this->fields.m_lensFlareDataDrivenMaterial = 0LL;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v12);
		      }
		    }
		  }
		}
		
		private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo) => default; // 0x0000000189BBA79C-0x0000000189BBAA1C
		// Single GetLensFlareLightAttenuation(Light, Camera, Vector3)
		float HG::Rendering::Runtime::LensFlarePassConstructor::GetLensFlareLightAttenuation(
		        Light *light,
		        Camera *cam,
		        Vector3 *wo,
		        MethodInfo *method)
		{
		  HGCamera *v7; // rax
		  __int64 v8; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGCamera *v10; // rbx
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rax
		  Transform *transform; // rax
		  Vector3 *forward; // rax
		  __int64 v14; // xmm6_8
		  float v15; // ebx
		  HGEnvironmentVolumeCameraComponent *v16; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  LightType__Enum type; // eax
		  unsigned __int32 v19; // eax
		  float v21; // eax
		  MethodInfo *v22; // r8
		  Transform *v23; // rax
		  Vector3 *v24; // rax
		  __int64 v25; // xmm7_8
		  float v26; // ebx
		  float spotAngle; // xmm8_4
		  float innerSpotAngle; // xmm6_4
		  float z; // eax
		  Vector3 v30; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 v31[2]; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3234, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3234, 0LL);
		    if ( Patch )
		    {
		      z = wo->z;
		      *(_QWORD *)&v31[0].x = *(_QWORD *)&wo->x;
		      v31[0].z = z;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1188(Patch, (Object *)light, (Object *)cam, v31, 0LL);
		    }
		LABEL_21:
		    sub_1800D8260(Patch, v8);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality((Object_1 *)light, 0LL, 0LL) )
		    return 1.0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v7 = HG::Rendering::Runtime::HGCamera::GetOrCreate(cam, 0, 0LL);
		  v10 = v7;
		  if ( !v7 )
		    goto LABEL_21;
		  envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(v7, 0LL);
		  if ( !envVolumeCameraComponent )
		    goto LABEL_21;
		  if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		         envVolumeCameraComponent,
		         light,
		         0LL) )
		  {
		    v16 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(v10, 0LL);
		    if ( !v16 )
		      goto LABEL_21;
		    interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v16, 0LL);
		    if ( !interpolatedPhase )
		      goto LABEL_21;
		    v14 = *(_QWORD *)&interpolatedPhase->fields.lightConfig.forwardDirect.x;
		    v15 = interpolatedPhase->fields.lightConfig.forwardDirect.z;
		    if ( !light )
		      goto LABEL_21;
		  }
		  else
		  {
		    if ( !light )
		      goto LABEL_21;
		    transform = UnityEngine::Component::get_transform((Component *)light, 0LL);
		    if ( !transform )
		      goto LABEL_21;
		    forward = UnityEngine::Transform::get_forward(v31, transform, 0LL);
		    v14 = *(_QWORD *)&forward->x;
		    v15 = forward->z;
		  }
		  type = UnityEngine::Light::get_type(light, 0LL);
		  if ( type == LightType__Enum_Spot )
		  {
		    v23 = UnityEngine::Component::get_transform((Component *)light, 0LL);
		    if ( v23 )
		    {
		      v24 = UnityEngine::Transform::get_forward(v31, v23, 0LL);
		      v25 = *(_QWORD *)&v24->x;
		      v26 = v24->z;
		      spotAngle = UnityEngine::Light::get_spotAngle(light, 0LL);
		      innerSpotAngle = UnityEngine::Light::get_innerSpotAngle(light, 0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		      v31[0].z = wo->z;
		      v30.z = v26;
		      *(_QWORD *)&v31[0].x = *(_QWORD *)&wo->x;
		      *(_QWORD *)&v30.x = v25;
		      return UnityEngine::Rendering::LensFlareCommonSRP::ShapeAttenuationSpotConeLight(
		               &v30,
		               v31,
		               spotAngle,
		               innerSpotAngle / 180.0,
		               0LL);
		    }
		    goto LABEL_21;
		  }
		  v19 = type - 1;
		  if ( v19 )
		  {
		    if ( v19 == 1 )
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		    return 1.0;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		  v21 = wo->z;
		  *(_QWORD *)&v30.x = *(_QWORD *)&wo->x;
		  v30.z = v21;
		  *(_QWORD *)&v31[0].x = v14;
		  v31[0].z = v15;
		  return fmaxf(UnityEngine::Vector3::Dot(v31, &v30, v22), 0.0);
		}
		
		public static int GetHGLensFlareCount() => default; // 0x0000000183AAE160-0x0000000183AAE370
		// Int32 GetHGLensFlareCount()
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::Runtime::LensFlarePassConstructor::GetHGLensFlareCount(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v4; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v9; // rdx
		  UnityEngine::Rendering::LensFlareCommonSRP *v10; // rcx
		  int32_t v11; // ebx
		  __int64 Data; // rax
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  __int64 v14; // rcx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rdi
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // r8
		  __int64 v21; // rcx
		  __int64 v22; // rcx
		  unsigned int v23; // eax
		  __int64 v24; // rdx
		  MethodInfo *v25; // [rsp+20h] [rbp-48h] BYREF
		  _BYTE v26[64]; // [rsp+28h] [rbp-40h] BYREF
		  int32_t v27; // [rsp+78h] [rbp+10h]
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v2, v1);
		  if ( wrapperArray->max_length.size <= 1115 )
		    goto LABEL_47;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = v2->static_fields->wrapperArray;
		  if ( !v4 )
		    sub_1800D8260(v2, v1);
		  if ( v4->max_length.size <= 0x45Bu )
		    sub_1800D2AB0(v2, v1);
		  if ( v4[31].max_length.value )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1115, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		LABEL_47:
		    if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		    v11 = 0;
		    v27 = 0;
		    if ( !UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL) )
		      sub_1800D8260(v10, v9);
		    Data = UnityEngine::Rendering::LensFlareCommonSRP::GetData(v10);
		    v17 = Data;
		    if ( !Data )
		      sub_1800D8260(v14, v13);
		    *(_OWORD *)&v26[8] = 0LL;
		    *(_QWORD *)v26 = Data;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)v26, v13, v15, v16, v25);
		    *(_DWORD *)&v26[8] = 0;
		    *(_DWORD *)&v26[12] = *(_DWORD *)(v17 + 28);
		    *(_QWORD *)&v26[16] = 0LL;
		    *(_OWORD *)&v26[24] = *(_OWORD *)v26;
		    *(_QWORD *)&v26[40] = 0LL;
		    *(_QWORD *)v26 = 0LL;
		    *(_QWORD *)&v26[8] = &v26[24];
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                (List_1_T_Enumerator_System_Object_ *)&v26[24],
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::MoveNext) )
		      {
		        if ( !*(_QWORD *)&v26[40] )
		          sub_1800D8250(v19, v18);
		        v21 = *(_QWORD *)(*(_QWORD *)&v26[40] + 24LL);
		        if ( !v21 )
		          sub_1800D8250(0LL, v18);
		        v22 = *(_QWORD *)(v21 + 24);
		        v23 = 0;
		        if ( !v22 )
		          sub_1800D8250(0LL, v18);
		        while ( (signed int)v23 < *(_DWORD *)(v22 + 24) )
		        {
		          if ( v23 >= *(_DWORD *)(v22 + 24) )
		            sub_1800D2AA0(v22, (int)v23, v20);
		          v24 = *(_QWORD *)(v22 + 8LL * (int)v23 + 32);
		          if ( !v24 )
		            sub_1800D8250(v22, 0LL);
		          v11 += *(_DWORD *)(v24 + 72);
		          v27 = v11;
		          ++v23;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v25 )
		    {
		      *(_QWORD *)v26 = v25->methodPointer;
		      if ( *(_QWORD *)v26 )
		        sub_18007E1E0(*(_QWORD *)v26);
		      return v27;
		    }
		    return v11;
		  }
		}
		
		public static unsafe void PrepareHGLensFlareDrawNode(Camera cam, Vector2Int renderSize, Vector3 cameraPositionWS, ref LensFlareCommonSRP.SunSourceDirLightOverrideInfo dirLightOverrideInfo, HGLensFlareDrawData* drawDataList, out int drawDataCount, HGSettingParameters settingParameters) {
			drawDataCount = default;
		} // 0x0000000183AAE850-0x0000000183AB1F50
		// Void PrepareHGLensFlareDrawNode(Camera, Vector2Int, Vector3, LensFlareCommonSRP+SunSourceDirLightOverrideInfo ByRef, HGLensFlareDrawData*, Int32 ByRef, HGSettingParameters)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::LensFlarePassConstructor::PrepareHGLensFlareDrawNode(
		        Camera *cam,
		        Vector2Int renderSize,
		        Vector3 *cameraPositionWS,
		        LensFlareCommonSRP_SunSourceDirLightOverrideInfo *dirLightOverrideInfo,
		        HGLensFlareDrawData *drawDataList,
		        int32_t *drawDataCount,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  int32_t m_X; // ebx
		  int32_t *v11; // r12
		  __int64 v12; // rdx
		  UnityEngine::Rendering::LensFlareCommonSRP *v13; // rcx
		  __int64 Data; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v18; // xmm6
		  __int128 v19; // xmm7
		  __int128 v20; // xmm8
		  __int128 v21; // xmm9
		  Matrix4x4 *v22; // rax
		  __int128 v23; // xmm7
		  __int128 v24; // xmm8
		  __int128 v25; // xmm11
		  __int128 v26; // xmm12
		  Object_1 *dirLightGameObject; // rbx
		  __int64 v28; // rdx
		  UnityEngine::Rendering::LensFlareCommonSRP *z_low; // rcx
		  Object *v30; // rbx
		  __int64 v31; // rdx
		  __m128 v32; // xmm15
		  Vector3 *v33; // rax
		  List_1_System_UInt64_ *v34; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  Object *current; // r15
		  struct Object_1__Class *v38; // rcx
		  MonitorData *monitor; // r13
		  GameObject *gameObject; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  GameObject *v43; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  struct Object_1__Class *v46; // rcx
		  Object_1 *v47; // rbx
		  char v48; // r14
		  struct Object_1__Class *v49; // rcx
		  Light *SunSourceLight; // rbx
		  struct Object_1__Class *v51; // rcx
		  int32_t InstanceID; // ebx
		  Object_1 *v53; // rax
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  struct Object_1__Class *v56; // rdx
		  __int64 v57; // rcx
		  MonitorData *v58; // xmm0_8
		  float z; // eax
		  GameObject *v60; // rbx
		  GameObject *v61; // r14
		  bool v62; // zf
		  Transform *transform; // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  Vector3 *forward; // rax
		  __m128 v67; // xmm6
		  __m128 v68; // xmm7
		  __m128i v69; // xmm8
		  float farClipPlane; // xmm0_4
		  float v71; // ebx
		  Transform *v72; // rax
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  Vector3 *v75; // rax
		  Vector3 *v76; // rax
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  float v79; // xmm12_4
		  float v80; // xmm7_4
		  __m128 v81; // xmm11
		  __m128 v82; // xmm6
		  __m128 v83; // xmm10
		  __m128 v84; // xmm8
		  Transform *v85; // rax
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  Vector3 *v88; // rax
		  float v89; // xmm7_4
		  float v90; // xmm0_4
		  bool v91; // cc
		  __int64 v92; // rdx
		  float v93; // xmm0_4
		  float v94; // xmm6_4
		  float v95; // xmm7_4
		  AnimationCurve *klass; // rcx
		  AnimationCurve *v97; // rcx
		  float v98; // xmm6_4
		  float v99; // xmm14_4
		  AnimationCurve *v100; // rcx
		  __int64 v101; // rdx
		  AnimationCurve *v102; // rcx
		  float v103; // xmm7_4
		  float v104; // xmm8_4
		  struct Object_1__Class *v105; // rcx
		  Light *v106; // rbx
		  char v107; // al
		  float *v108; // rax
		  __m128 v109; // xmm8
		  __m128 v110; // xmm7
		  __m128 v111; // xmm7
		  float v112; // xmm9_4
		  float LensFlareLightAttenuation; // xmm0_4
		  Transform *v114; // rax
		  __int64 v115; // rdx
		  __int64 v116; // rcx
		  Vector3 *position; // rax
		  float v118; // ebx
		  Transform *v119; // rax
		  __int64 v120; // rdx
		  __int64 v121; // rcx
		  Vector3 *v122; // rax
		  float v123; // xmm4_4
		  __m128 v124; // xmm2
		  __m128 v125; // xmm1
		  float *v126; // rax
		  float v127; // xmm7_4
		  float v128; // xmm0_4
		  float v129; // xmm7_4
		  __m128 v130; // xmm6
		  __m128 v131; // xmm8
		  __int128 v132; // xmm7
		  __int128 v133; // xmm8
		  Vector3 *v134; // rax
		  float v135; // r15d
		  LensFlareComponentSRP *v136; // rbx
		  float occlusionRadius; // xmm6_4
		  Transform *v138; // rax
		  __int64 v139; // rdx
		  __int64 v140; // rcx
		  Vector3 *up; // rax
		  float v142; // xmm3_4
		  float v143; // xmm2_4
		  float v144; // xmm12_4
		  __m128 v145; // xmm0
		  __m128 v146; // xmm1
		  __int64 v147; // rdx
		  __int64 v148; // rcx
		  __int32 v149; // xmm6_4
		  __int64 sampleCount; // r14
		  __int64 v151; // rbx
		  HGRuntimeGrassQuery_Node *v152; // r8
		  HGRuntimeGrassQuery_Node__Class *v153; // r9
		  __int64 v154; // rax
		  __int64 v155; // rbx
		  LensFlareComponentSRP *v156; // r14
		  HGRuntimeGrassQuery_Node *typeMetadataHandle_high; // rdx
		  RTHandle *parent; // rcx
		  RenderTexture *m_RT; // rax
		  unsigned __int64 v160; // rcx
		  unsigned int v161; // r15d
		  _QWORD *dummy; // rbx
		  struct Object_1__Class *v163; // rcx
		  char v164; // al
		  float v165; // xmm11_4
		  float v166; // xmm7_4
		  float v167; // xmm12_4
		  float v168; // xmm8_4
		  float v169; // xmm13_4
		  float v170; // xmm9_4
		  float v171; // xmm6_4
		  float v172; // xmm10_4
		  Object_1 *v173; // r13
		  struct Object_1__Class *v174; // rdx
		  __int64 v175; // rcx
		  __int64 v176; // rcx
		  GameObject *v177; // rbx
		  GameObject *v178; // r14
		  bool v179; // al
		  Color color; // xmm1
		  float v181; // xmm0_4
		  __m128 y_low; // xmm13
		  __m128 x_low; // xmm12
		  float v184; // xmm6_4
		  float v185; // xmm0_4
		  AnimationCurve *radialScreenAttenuationCurve; // rcx
		  __int64 v187; // rcx
		  AnimationCurve *v188; // rcx
		  float v189; // xmm0_4
		  Color v190; // xmm6
		  float colorTemperature; // xmm0_4
		  HGRuntimeGrassQuery_Node__Class *v192; // rax
		  float v193; // xmm6_4
		  void *v194; // rbx
		  int v195; // r14d
		  float v196; // xmm1_4
		  float v197; // xmm0_4
		  float v198; // xmm2_4
		  __m128 v199; // xmm0
		  __m128 v200; // xmm2
		  __m128 v201; // xmm1
		  __m128 v202; // xmm3
		  bool GraphicsUVStartsAtTop; // al
		  __int64 v204; // rdx
		  Beyond::DampingMath *v205; // rcx
		  HGRuntimeGrassQuery_Node__Class *v206; // rbx
		  float v207; // xmm6_4
		  float v208; // xmm11_4
		  Beyond::DampingMath *v209; // rcx
		  float globalSin0; // xmm14_4
		  float v211; // xmm10_4
		  Object_1 *v212; // rbx
		  bool v213; // al
		  __int64 v214; // rdx
		  Beyond::JobMathf *v215; // rcx
		  HGRuntimeGrassQuery_Node__Class *v216; // rbx
		  _QWORD *v217; // rax
		  Beyond::JobMathf *v218; // rcx
		  float v219; // xmm8_4
		  int v220; // xmm7_4
		  float v221; // xmm0_4
		  Beyond::JobMathf *v222; // rcx
		  unsigned int v223; // xmm6_4
		  unsigned int v224; // xmm5_4
		  Beyond::DampingMath *v225; // rcx
		  float v226; // xmm7_4
		  __int64 v227; // rdx
		  __int64 v228; // rcx
		  __int64 v229; // r8
		  __int64 v230; // r9
		  float v231; // xmm0_4
		  char v232; // r13
		  int32_t castClass; // r15d
		  int v234; // r15d
		  float v235; // xmm7_4
		  Gradient *v236; // rdx
		  __int64 v237; // rdx
		  __int64 v238; // rcx
		  Color v239; // xmm15
		  FieldInfo *fields; // rcx
		  __int64 v241; // rdx
		  __int64 v242; // rcx
		  FieldInfo *v243; // rcx
		  float v244; // xmm0_4
		  HGRuntimeGrassQuery_Node__Class *v245; // rbx
		  float v246; // xmm9_4
		  struct LensFlareCommonSRP__Class *v247; // r14
		  Vector2 v248; // rdx
		  Vector2 v249; // rcx
		  Vector2 v250; // xmm14_8
		  __m128 v251; // xmm10
		  __m128 v252; // xmm11
		  Vector2 v253; // rdx
		  Vector2 v254; // rcx
		  Vector2 v255; // xmm6_8
		  AnimationCurve *v256; // rbx
		  AnimationCurve *events; // rcx
		  __int64 v258; // rdx
		  __int64 v259; // rcx
		  AnimationCurve *v260; // rcx
		  float v261; // xmm6_4
		  float v262; // xmm8_4
		  float v263; // xmm6_4
		  AnimationCurve *cctor_thread; // rcx
		  __int64 v265; // rdx
		  __int64 v266; // rcx
		  float v267; // xmm0_4
		  float v268; // xmm7_4
		  __m128 v269; // xmm10
		  __m128 v270; // xmm11
		  __m128 v271; // xmm12
		  __m128 v272; // xmm13
		  char v273; // bl
		  Vector4 v274; // xmm7
		  __int64 v275; // rdx
		  __int64 v276; // rcx
		  __int64 v277; // rcx
		  __int64 v278; // rcx
		  __int64 v279; // rdx
		  __int64 v280; // rcx
		  __int64 v281; // rcx
		  __int64 v282; // rdx
		  __int64 v283; // rcx
		  __int64 v284; // rdx
		  __int64 v285; // rcx
		  __int64 v286; // rcx
		  _OWORD *v287; // rcx
		  __int64 v288; // rcx
		  __int64 v289; // rdx
		  __int64 v290; // rcx
		  __int64 v291; // rdx
		  __int64 v292; // rcx
		  HGRuntimeGrassQuery_Node__Class *v293; // rax
		  float v294; // xmm9_4
		  float v295; // xmm15_4
		  int v296; // r15d
		  __int64 v297; // rdx
		  __int64 v298; // rcx
		  float v299; // xmm0_4
		  HGRuntimeGrassQuery_Node__Class *v300; // rbx
		  float v301; // xmm13_4
		  struct LensFlareCommonSRP__Class *v302; // r14
		  __m128 v303; // xmm6
		  Vector2 v304; // rdx
		  Vector2 v305; // rcx
		  Vector2 v306; // xmm14_8
		  __m128 grassInstanceBounds_low; // xmm7
		  __m128 left_low; // xmm8
		  Vector2 v309; // rdx
		  Vector2 v310; // rcx
		  Vector2 v311; // xmm6_8
		  AnimationCurve *v312; // rbx
		  float v313; // xmm6_4
		  __m128 v314; // xmm0
		  __m128 v315; // xmm1
		  Vector2 v316; // r8
		  Vector2 v317; // r9
		  Vector2 v318; // rdx
		  Vector2 v319; // rcx
		  float v320; // xmm11_4
		  float v321; // xmm12_4
		  const MethodInfo **methods; // rbx
		  __int64 v323; // rdx
		  __int64 v324; // rcx
		  float v325; // xmm0_4
		  __int64 v326; // rdx
		  __int64 v327; // rcx
		  Color v328; // xmm10
		  __m128 v329; // xmm6
		  __m128 v330; // xmm7
		  __m128 v331; // xmm0
		  __m128 v332; // xmm1
		  Vector2 v333; // r8
		  Vector2 v334; // r9
		  Vector2 v335; // xmm9_8
		  __int64 v336; // rdx
		  __int64 v337; // rcx
		  float v338; // xmm0_4
		  float v339; // xmm6_4
		  __m128 v340; // xmm7
		  __m128 v341; // xmm8
		  char v342; // bl
		  Vector2 v343; // r8
		  float v344; // xmm8_4
		  float v345; // xmm7_4
		  Vector4 v346; // xmm6
		  __int64 v347; // rdx
		  __int64 v348; // rcx
		  __int64 v349; // rcx
		  __int64 v350; // rcx
		  __int64 v351; // rdx
		  __int64 v352; // rcx
		  __int64 v353; // rcx
		  __int64 v354; // rdx
		  __int64 v355; // rcx
		  __int64 v356; // rdx
		  __int64 v357; // rcx
		  __int64 v358; // rdx
		  __int64 v359; // rcx
		  _OWORD *v360; // rcx
		  __int64 v361; // rcx
		  __int64 v362; // rcx
		  float v363; // xmm6_4
		  float v364; // xmm10_4
		  float v365; // xmm0_4
		  float v366; // xmm14_4
		  int v367; // r15d
		  __int128 v368; // xmm15
		  __m128 v369; // xmm7
		  __m128 v370; // xmm11
		  __m128 v371; // xmm12
		  struct LensFlareCommonSRP__Class *v372; // r14
		  float v373; // xmm8_4
		  float v374; // xmm6_4
		  Vector2 v375; // rdx
		  Vector2 v376; // rcx
		  Vector2 v377; // xmm13_8
		  Vector2 v378; // rdx
		  Vector2 v379; // rcx
		  Vector2 v380; // xmm6_8
		  AnimationCurve *v381; // rbx
		  float v382; // xmm2_4
		  Gradient *v383; // rdx
		  __int64 v384; // rdx
		  __int64 v385; // rcx
		  Color v386; // xmm6
		  __m128 v387; // xmm7
		  __m128 v388; // xmm8
		  __m128 v389; // xmm9
		  __m128 v390; // xmm10
		  char v391; // bl
		  float v392; // xmm10_4
		  Vector2 v393; // r9
		  Vector2 v394; // r8
		  __int64 v395; // rdx
		  Vector4 v396; // xmm3
		  __int64 v397; // rcx
		  __int64 v398; // rcx
		  __int64 v399; // rcx
		  __int64 v400; // rdx
		  __int64 v401; // rcx
		  __int64 v402; // rcx
		  __int64 v403; // rdx
		  __int64 v404; // rcx
		  __int64 v405; // rdx
		  __int64 v406; // rcx
		  __int64 v407; // rcx
		  _OWORD *v408; // rcx
		  __int64 v409; // rcx
		  struct LensFlareCommonSRP__Class *v410; // r14
		  Vector2 v411; // rdx
		  Vector2 v412; // rcx
		  Vector2 LensFlareRayOffset; // xmm10_8
		  Vector2 v414; // rdx
		  Vector2 v415; // rcx
		  Vector2 v416; // xmm6_8
		  AnimationCurve *rgctx_data; // rbx
		  float y; // xmm14_4
		  float v419; // xmm11_4
		  __m128 type_high; // xmm6
		  __m128 v421; // xmm7
		  __m128 namespaze_low; // xmm8
		  __m128 namespaze_high; // xmm9
		  char typeMetadataHandle; // bl
		  __int64 v425; // rdx
		  Vector4 v426; // xmm0
		  __int64 v427; // rcx
		  __int64 v428; // rcx
		  __int64 v429; // rcx
		  __int64 cctor_started_low; // rdx
		  __int64 v431; // rcx
		  __int64 v432; // rcx
		  __int64 generic_class_high; // rdx
		  __int64 v434; // rcx
		  __int64 interopData_high; // rdx
		  __int64 v436; // rcx
		  __int64 v437; // rcx
		  _OWORD *ptr; // rcx
		  __int64 v439; // rcx
		  __int64 v440; // rcx
		  MethodInfo *methoda; // [rsp+20h] [rbp-5F8h]
		  Vector2 v442; // [rsp+40h] [rbp-5D8h]
		  Vector2 v443; // [rsp+40h] [rbp-5D8h]
		  HGRuntimeGrassQuery_Node param_0004ea56; // [rsp+60h] [rbp-5B8h] BYREF
		  LensFlareComponentSRP *v445; // [rsp+A8h] [rbp-570h]
		  LensFlarePassConstructor_c_DisplayClass9_1 globalCos0; // [rsp+B0h] [rbp-568h] BYREF
		  __int128 v447; // [rsp+D0h] [rbp-548h]
		  float v448; // [rsp+E0h] [rbp-538h]
		  float v449; // [rsp+E4h] [rbp-534h]
		  Vector2 v450; // [rsp+E8h] [rbp-530h]
		  int32_t v451; // [rsp+F4h] [rbp-524h]
		  unsigned __int64 v452; // [rsp+100h] [rbp-518h]
		  __int128 v453; // [rsp+110h] [rbp-508h]
		  int v454; // [rsp+120h] [rbp-4F8h]
		  float v455; // [rsp+124h] [rbp-4F4h]
		  float v456; // [rsp+128h] [rbp-4F0h]
		  __int64 v457; // [rsp+130h] [rbp-4E8h]
		  void *m_CachedPtr; // [rsp+138h] [rbp-4E0h]
		  void *v459; // [rsp+140h] [rbp-4D8h]
		  Object_1 *x; // [rsp+148h] [rbp-4D0h]
		  __int64 v461; // [rsp+150h] [rbp-4C8h]
		  Vector3 v462; // [rsp+160h] [rbp-4B8h] BYREF
		  __int128 v463; // [rsp+170h] [rbp-4A8h]
		  __int128 v464; // [rsp+180h] [rbp-498h]
		  __int128 v465; // [rsp+190h] [rbp-488h]
		  Random_State value; // [rsp+1A0h] [rbp-478h] BYREF
		  float v467; // [rsp+1B0h] [rbp-468h]
		  float v468; // [rsp+1B4h] [rbp-464h]
		  float v469; // [rsp+1B8h] [rbp-460h]
		  float v470; // [rsp+1BCh] [rbp-45Ch]
		  MonitorData *v471; // [rsp+1C0h] [rbp-458h]
		  Matrix4x4 v472; // [rsp+1D0h] [rbp-448h] BYREF
		  unsigned __int64 v473; // [rsp+210h] [rbp-408h]
		  Vector3 v474; // [rsp+220h] [rbp-3F8h] BYREF
		  __m128 v475; // [rsp+230h] [rbp-3E8h]
		  __m128 v476; // [rsp+240h] [rbp-3D8h]
		  __m128 v477; // [rsp+250h] [rbp-3C8h]
		  __int128 v478; // [rsp+260h] [rbp-3B8h]
		  __int128 v479; // [rsp+270h] [rbp-3A8h]
		  __int128 v480; // [rsp+280h] [rbp-398h]
		  __m128 v481; // [rsp+290h] [rbp-388h]
		  __int128 v482; // [rsp+2A0h] [rbp-378h]
		  Matrix4x4 v483; // [rsp+2B0h] [rbp-368h]
		  Il2CppException *ex; // [rsp+2F0h] [rbp-328h]
		  List_1_T_Enumerator_System_Object_ *v485; // [rsp+2F8h] [rbp-320h]
		  Vector3 v486; // [rsp+300h] [rbp-318h] BYREF
		  Vector3 v487; // [rsp+310h] [rbp-308h] BYREF
		  unsigned __int64 v488; // [rsp+320h] [rbp-2F8h] BYREF
		  float v489; // [rsp+328h] [rbp-2F0h]
		  __int64 v490; // [rsp+330h] [rbp-2E8h]
		  Vector3 v491; // [rsp+340h] [rbp-2D8h] BYREF
		  Matrix4x4 v492; // [rsp+350h] [rbp-2C8h] BYREF
		  List_1_T_Enumerator_System_Object_ v493; // [rsp+390h] [rbp-288h] BYREF
		  List_1_T_Enumerator_System_Object_ v494; // [rsp+3A8h] [rbp-270h] BYREF
		  Il2CppExceptionWrapper *v495; // [rsp+3C0h] [rbp-258h] BYREF
		  Vector3 v496; // [rsp+3C8h] [rbp-250h] BYREF
		  Vector3 v497; // [rsp+3D8h] [rbp-240h] BYREF
		  char v498[16]; // [rsp+3E8h] [rbp-230h] BYREF
		  Vector3 v499; // [rsp+3F8h] [rbp-220h] BYREF
		  Vector3 v500; // [rsp+408h] [rbp-210h] BYREF
		  Vector3 v501; // [rsp+418h] [rbp-200h] BYREF
		  Vector3 v502; // [rsp+428h] [rbp-1F0h] BYREF
		  Vector3 v503; // [rsp+438h] [rbp-1E0h] BYREF
		  char v504[16]; // [rsp+448h] [rbp-1D0h] BYREF
		  Vector3 v505; // [rsp+458h] [rbp-1C0h] BYREF
		  Vector3 v506; // [rsp+468h] [rbp-1B0h] BYREF
		  Vector4 v507; // [rsp+478h] [rbp-1A0h] BYREF
		  Color v508; // [rsp+488h] [rbp-190h] BYREF
		  Vector4 v509; // [rsp+498h] [rbp-180h] BYREF
		  Vector4 v510; // [rsp+4A8h] [rbp-170h] BYREF
		  Color v511; // [rsp+4B8h] [rbp-160h] BYREF
		  Color v512; // [rsp+4C8h] [rbp-150h] BYREF
		  Color v513; // [rsp+4D8h] [rbp-140h] BYREF
		  Color v514; // [rsp+4E8h] [rbp-130h] BYREF
		  Matrix4x4 v515[3]; // [rsp+4F8h] [rbp-120h] BYREF
		  int32_t m_Y; // [rsp+62Ch] [rbp+14h]
		
		  m_Y = renderSize.m_Y;
		  m_X = renderSize.m_X;
		  v465 = 0LL;
		  v463 = 0LL;
		  param_0004ea56.klass = 0LL;
		  memset(&globalCos0, 0, sizeof(globalCos0));
		  v464 = 0LL;
		  v447 = 0LL;
		  v453 = 0LL;
		  *(_QWORD *)&param_0004ea56.fields.bounds.m_Extents.y = 0LL;
		  v450 = 0LL;
		  v457 = 0LL;
		  v11 = drawDataCount;
		  *drawDataCount = 0;
		  if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		  if ( !UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL) )
		    sub_1800D8260(v13, v12);
		  Data = UnityEngine::Rendering::LensFlareCommonSRP::GetData(v13);
		  if ( !Data )
		    sub_1800D8260(v16, v15);
		  if ( *(_DWORD *)(Data + 24) )
		  {
		    if ( !cam )
		      sub_1800D8260(v16, v15);
		    v492 = *UnityEngine::Camera::get_worldToCameraMatrix(&v472, cam, 0LL);
		    v472 = *UnityEngine::Camera::get_projectionMatrix(v515, cam, 0LL);
		    GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v515, &v472, 1, 0LL);
		    v18 = *(_OWORD *)&GPUProjectionMatrix->m00;
		    v19 = *(_OWORD *)&GPUProjectionMatrix->m01;
		    v20 = *(_OWORD *)&GPUProjectionMatrix->m02;
		    v21 = *(_OWORD *)&GPUProjectionMatrix->m03;
		    value = (Random_State)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		    UnityEngine::Matrix4x4::SetColumn(&v492, 3, (Vector4 *)&value, 0LL);
		    v472 = v492;
		    *(_OWORD *)&v492.m00 = v18;
		    *(_OWORD *)&v492.m01 = v19;
		    *(_OWORD *)&v492.m02 = v20;
		    *(_OWORD *)&v492.m03 = v21;
		    v22 = UnityEngine::Matrix4x4::op_Multiply(v515, &v492, &v472, 0LL);
		    v23 = *(_OWORD *)&v22->m00;
		    *(_OWORD *)&v483.m00 = *(_OWORD *)&v22->m00;
		    v24 = *(_OWORD *)&v22->m01;
		    *(_OWORD *)&v483.m01 = v24;
		    v25 = *(_OWORD *)&v22->m02;
		    *(_OWORD *)&v483.m02 = v25;
		    v26 = *(_OWORD *)&v22->m03;
		    *(_OWORD *)&v483.m03 = v26;
		    v468 = (float)m_X;
		    v469 = (float)m_Y;
		    v449 = (float)m_X / (float)m_Y;
		    dirLightGameObject = (Object_1 *)dirLightOverrideInfo->dirLightGameObject;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Implicit(dirLightGameObject, 0LL) )
		      goto LABEL_17;
		    if ( !dirLightOverrideInfo->dirLightGameObject )
		      sub_1800D8260(z_low, v28);
		    v30 = UnityEngine::GameObject::GetComponent<System::Object>(
		            dirLightOverrideInfo->dirLightGameObject,
		            MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Rendering::LensFlareComponentSRP>);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)v30, 0LL, 0LL) && dirLightOverrideInfo->flareData.enable )
		    {
		      if ( !v30 )
		        sub_1800D8260(z_low, v31);
		      UnityEngine::Rendering::LensFlareComponentSRP::set_lensFlareData(
		        (LensFlareComponentSRP *)v30,
		        dirLightOverrideInfo->flareData.lensFlareData,
		        0LL);
		      *(float *)&v30[2].klass = dirLightOverrideInfo->flareData.intensity;
		      *(float *)&v30[6].klass = dirLightOverrideInfo->flareData.scale;
		      LOBYTE(v30[5].klass) = dirLightOverrideInfo->flareData.useOcclusion;
		      HIDWORD(v30[5].klass) = LODWORD(dirLightOverrideInfo->flareData.occlusionRadius);
		      LODWORD(v30[5].monitor) = dirLightOverrideInfo->flareData.sampleCount;
		      HIDWORD(v30[5].monitor) = LODWORD(dirLightOverrideInfo->flareData.occlusionOffset);
		      BYTE4(v30[6].klass) = dirLightOverrideInfo->flareData.allowOffScreen;
		      HIDWORD(v30[5].monitor) = LODWORD(dirLightOverrideInfo->flareData.occlusionOffset);
		      BYTE5(v30[6].klass) = 1;
		      *(_QWORD *)&v462.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      v32 = (__m128)0x3F800000u;
		      v462.z = 1.0;
		      value = (Random_State)dirLightOverrideInfo->lightData.rotationLensFlare;
		      v33 = UnityEngine::Quaternion::op_Multiply(&v474, (Quaternion *)&value, &v462, 0LL);
		      z_low = (UnityEngine::Rendering::LensFlareCommonSRP *)LODWORD(v33->z);
		      v30[6].monitor = *(MonitorData **)&v33->x;
		      LODWORD(v30[7].klass) = (_DWORD)z_low;
		    }
		    else
		    {
		LABEL_17:
		      v32 = (__m128)0x3F800000u;
		    }
		    v454 = 0;
		    v34 = (List_1_System_UInt64_ *)UnityEngine::Rendering::LensFlareCommonSRP::GetData(z_low);
		    if ( !v34 )
		      sub_1800D8260(v36, v35);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v494,
		      v34,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::LensFlareComponentSRP>::GetEnumerator);
		    v493 = v494;
		    ex = 0LL;
		    v485 = &v493;
		    try
		    {
		      while ( 1 )
		      {
		        while ( 1 )
		        {
		          if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v493,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::MoveNext) )
		            goto LABEL_560;
		          current = v493._current;
		          v445 = (LensFlareComponentSRP *)v493._current;
		          v38 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v38 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v38 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( current )
		          {
		            if ( !v38->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v38);
		            if ( current[1].klass )
		            {
		              monitor = current[1].monitor;
		              if ( UnityEngine::Behaviour::get_enabled((Behaviour *)current, 0LL) )
		              {
		                gameObject = UnityEngine::Component::get_gameObject((Component *)current, 0LL);
		                if ( !gameObject )
		                  sub_1800D8250(v42, v41);
		                if ( UnityEngine::GameObject::get_activeSelf(gameObject, 0LL) )
		                {
		                  v43 = UnityEngine::Component::get_gameObject((Component *)current, 0LL);
		                  if ( !v43 )
		                    sub_1800D8250(v45, v44);
		                  if ( UnityEngine::GameObject::get_activeInHierarchy(v43, 0LL) )
		                  {
		                    v46 = TypeInfo::UnityEngine::Object;
		                    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                    {
		                      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                      v46 = TypeInfo::UnityEngine::Object;
		                      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                      {
		                        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                        v46 = TypeInfo::UnityEngine::Object;
		                      }
		                    }
		                    if ( monitor )
		                    {
		                      if ( !v46->_1.cctor_finished_or_no_cctor )
		                        il2cpp_runtime_class_init_1(v46);
		                      if ( *((_QWORD *)monitor + 2)
		                        && *((_QWORD *)monitor + 3)
		                        && *(_QWORD *)(*((_QWORD *)monitor + 3) + 24LL)
		                        && *(float *)&current[2].klass > 0.0 )
		                      {
		                        break;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		        v47 = (Object_1 *)UnityEngine::Component::GetComponent<System::Object>(
		                            (Component *)current,
		                            MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Light>);
		        x = v47;
		        v48 = 0;
		        v49 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v49 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v49 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( !v47 )
		          break;
		        if ( !v49->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v49);
		        if ( !v47->fields.m_CachedPtr || UnityEngine::Light::get_type((Light *)v47, 0LL) != LightType__Enum_Directional )
		          break;
		        SunSourceLight = UnityEngine::Light::GetSunSourceLight(0LL);
		        v51 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v51 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v51 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( SunSourceLight )
		        {
		          if ( !v51->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v51);
		          if ( SunSourceLight->fields._._._.m_CachedPtr )
		          {
		            InstanceID = UnityEngine::Object::GetInstanceID(x, 0LL);
		            v53 = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
		            if ( !v53 )
		              sub_1800D8250(v55, v54);
		            if ( InstanceID == UnityEngine::Object::GetInstanceID(v53, 0LL) )
		            {
		              if ( BYTE5(current[6].klass) )
		              {
		                v58 = current[6].monitor;
		                z = *(float *)&current[7].klass;
		              }
		              else
		              {
		                v60 = UnityEngine::Component::get_gameObject((Component *)current, 0LL);
		                v61 = dirLightOverrideInfo->dirLightGameObject;
		                v56 = TypeInfo::UnityEngine::Object;
		                if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                  v56 = TypeInfo::UnityEngine::Object;
		                  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                    v56 = TypeInfo::UnityEngine::Object;
		                  }
		                }
		                LOBYTE(v57) = v61 == 0LL;
		                if ( v61 == 0LL && v60 == 0LL )
		                  goto LABEL_80;
		                if ( v61 )
		                {
		                  if ( v60 )
		                  {
		                    v62 = v60 == v61;
		                  }
		                  else
		                  {
		                    if ( !v56->_1.cctor_finished_or_no_cctor )
		                      il2cpp_runtime_class_init_1(v56);
		                    v62 = v61->fields._.m_CachedPtr == 0LL;
		                  }
		                }
		                else
		                {
		                  if ( !v56->_1.cctor_finished_or_no_cctor )
		                    il2cpp_runtime_class_init_1(v56);
		                  if ( !v60 )
		                    sub_1800D8250(v57, v56);
		                  v62 = v60->fields._.m_CachedPtr == 0LL;
		                }
		                if ( v62 )
		                {
		LABEL_80:
		                  v58 = *(MonitorData **)&dirLightOverrideInfo->lightData.dirLightFoward.x;
		                  z = dirLightOverrideInfo->lightData.dirLightFoward.z;
		                }
		                else
		                {
		                  transform = UnityEngine::Component::get_transform((Component *)x, 0LL);
		                  if ( !transform )
		                    sub_1800D8250(v65, v64);
		                  forward = UnityEngine::Transform::get_forward(&v503, transform, 0LL);
		                  v58 = *(MonitorData **)&forward->x;
		                  z = forward->z;
		                }
		              }
		              v471 = v58;
		              v67 = _mm_xor_ps((__m128)(unsigned int)v58, (__m128)0x80000000);
		              v68 = _mm_xor_ps((__m128)HIDWORD(v58), (__m128)0x80000000);
		              v69 = (__m128i)_mm_xor_ps((__m128)_mm_cvtsi32_si128(LODWORD(z)), (__m128)0x80000000);
		              if ( !cam )
		                sub_1800D8250(v57, v56);
		              farClipPlane = UnityEngine::Camera::get_farClipPlane(cam, 0LL);
		              *(float *)v69.m128i_i32 = *(float *)v69.m128i_i32 * farClipPlane;
		              v68.m128_f32[0] = v68.m128_f32[0] * farClipPlane;
		              v67.m128_f32[0] = v67.m128_f32[0] * farClipPlane;
		              v67.m128_u64[0] = _mm_unpacklo_ps(v67, v68).m128_u64[0];
		              v473 = v67.m128_u64[0];
		              v71 = COERCE_FLOAT(_mm_cvtsi128_si32(v69));
		              v48 = 1;
		              v23 = *(_OWORD *)&v483.m00;
		              v24 = *(_OWORD *)&v483.m01;
		LABEL_85:
		              if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		              *(_QWORD *)&v486.x = v67.m128_u64[0];
		              v486.z = v71;
		              *(_OWORD *)&v472.m00 = v23;
		              *(_OWORD *)&v472.m01 = v24;
		              *(_OWORD *)&v472.m02 = v25;
		              *(_OWORD *)&v472.m03 = v26;
		              v76 = UnityEngine::Rendering::LensFlareCommonSRP::WorldToViewport(
		                      &v505,
		                      cam,
		                      v48 != 1,
		                      1,
		                      &v472,
		                      &v486,
		                      0LL);
		              v461 = *(_QWORD *)&v76->x;
		              if ( v76->z >= 0.0
		                && (BYTE4(current[6].klass)
		                 || *(float *)&v461 >= 0.0
		                 && *(float *)&v461 <= v32.m128_f32[0]
		                 && *((float *)&v461 + 1) >= 0.0
		                 && *((float *)&v461 + 1) <= v32.m128_f32[0]) )
		              {
		                v79 = v71;
		                v80 = v71 - cameraPositionWS->z;
		                v81 = (__m128)HIDWORD(v473);
		                v82 = (__m128)HIDWORD(v473);
		                v82.m128_f32[0] = *((float *)&v473 + 1)
		                                - _mm_shuffle_ps(
		                                    (__m128)*(unsigned __int64 *)&cameraPositionWS->x,
		                                    (__m128)*(unsigned __int64 *)&cameraPositionWS->x,
		                                    85).m128_f32[0];
		                v83 = (__m128)(unsigned int)v473;
		                v84 = (__m128)(unsigned int)v473;
		                v452 = *(_QWORD *)&cameraPositionWS->x;
		                v84.m128_f32[0] = *(float *)&v473 - *(float *)&v452;
		                *(_QWORD *)&v462.x = _mm_unpacklo_ps(v84, v82).m128_u64[0];
		                v462.z = v80;
		                if ( !cam )
		                  sub_1800D8250(v78, v77);
		                v85 = UnityEngine::Component::get_transform((Component *)cam, 0LL);
		                if ( !v85 )
		                  sub_1800D8250(v87, v86);
		                v88 = UnityEngine::Transform::get_forward(&v506, v85, 0LL);
		                v89 = v80 * v88->z;
		                v90 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v88->x, (__m128)*(unsigned __int64 *)&v88->x, 85).m128_f32[0];
		                v452 = *(_QWORD *)&v88->x;
		                v91 = (float)(v89 + (float)((float)(v82.m128_f32[0] * v90) + (float)(v84.m128_f32[0] * *(float *)&v452))) >= 0.0;
		                v23 = *(_OWORD *)&v483.m00;
		                v24 = *(_OWORD *)&v483.m01;
		                if ( v91 )
		                {
		                  v93 = sub_182F9FF00(&v462);
		                  v94 = v93 / *((float *)&current[2].klass + 1);
		                  v95 = v93 / *(float *)&current[2].monitor;
		                  if ( v48 )
		                    goto LABEL_101;
		                  klass = (AnimationCurve *)current[3].klass;
		                  if ( !klass )
		                    sub_1800D8250(0LL, v92);
		                  if ( UnityEngine::AnimationCurve::get_length(klass, 0LL) <= 0 )
		                  {
		LABEL_101:
		                    v98 = v32.m128_f32[0];
		                    v99 = v32.m128_f32[0];
		                    LODWORD(param_0004ea56.fields.bounds.m_Center.x) = v32.m128_i32[0];
		                    if ( !v48 )
		                      goto LABEL_102;
		                  }
		                  else
		                  {
		                    v97 = (AnimationCurve *)current[3].klass;
		                    if ( !v97 )
		                      sub_1800D8250(0LL, v92);
		                    v98 = UnityEngine::AnimationCurve::Evaluate(v97, v94, 0LL);
		                    v99 = v98;
		                    param_0004ea56.fields.bounds.m_Center.x = v98;
		LABEL_102:
		                    v100 = (AnimationCurve *)current[3].monitor;
		                    if ( !v100 )
		                      sub_1800D8250(0LL, v92);
		                    if ( UnityEngine::AnimationCurve::get_length(v100, 0LL) >= 1 )
		                    {
		                      v102 = (AnimationCurve *)current[3].monitor;
		                      if ( !v102 )
		                        sub_1800D8250(0LL, v101);
		                      v455 = UnityEngine::AnimationCurve::Evaluate(v102, v95, 0LL);
		LABEL_107:
		                      v103 = v32.m128_f32[0];
		                      v104 = v32.m128_f32[0];
		                      LODWORD(param_0004ea56.fields.right) = v32.m128_i32[0];
		                      HIDWORD(param_0004ea56.fields.right) = v32.m128_i32[0];
		                      v105 = TypeInfo::UnityEngine::Object;
		                      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                      {
		                        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                        v105 = TypeInfo::UnityEngine::Object;
		                        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                        {
		                          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                          v105 = TypeInfo::UnityEngine::Object;
		                        }
		                      }
		                      v106 = (Light *)x;
		                      if ( !x )
		                        goto LABEL_121;
		                      if ( !v105->_1.cctor_finished_or_no_cctor )
		                        il2cpp_runtime_class_init_1(v105);
		                      param_0004ea56.fields.bounds.m_Center.x = v99;
		                      if ( v106->fields._._._.m_CachedPtr )
		                      {
		                        v107 = 0;
		                        param_0004ea56.fields.bounds.m_Center.x = v99;
		                      }
		                      else
		                      {
		                        v107 = 1;
		                      }
		                      if ( !v107 && LOBYTE(current[4].klass) )
		                      {
		                        v108 = (float *)sub_182FAE2B0(v504, &v462);
		                        v109 = _mm_xor_ps((__m128)*(unsigned __int64 *)v108, (__m128)0x80000000);
		                        v110 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)v108, (__m128)*(unsigned __int64 *)v108, 85);
		                        v452 = *(_QWORD *)v108;
		                        v111 = _mm_xor_ps(v110, (__m128)0x80000000);
		                        v112 = -v108[2];
		                        if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                        *(_QWORD *)&v491.x = _mm_unpacklo_ps(v109, v111).m128_u64[0];
		                        v491.z = v112;
		                        LensFlareLightAttenuation = HG::Rendering::Runtime::LensFlarePassConstructor::GetLensFlareLightAttenuation(
		                                                      v106,
		                                                      cam,
		                                                      &v491,
		                                                      0LL);
		                        v103 = LensFlareLightAttenuation;
		                        *((float *)&param_0004ea56.fields.right + 1) = LensFlareLightAttenuation;
		                        v104 = LensFlareLightAttenuation;
		                      }
		                      else
		                      {
		LABEL_121:
		                        LensFlareLightAttenuation = *(float *)&param_0004ea56.fields.right;
		                      }
		                      *((float *)&param_0004ea56.fields.right + 1) = *((float *)&param_0004ea56.fields.right + 1) * v98;
		                      *(float *)&param_0004ea56.fields.right = LensFlareLightAttenuation * v98;
		                      v467 = v104 * v98;
		                      v470 = v103 * v98;
		                      v114 = UnityEngine::Component::get_transform((Component *)cam, 0LL);
		                      if ( !v114 )
		                        sub_1800D8250(v116, v115);
		                      position = UnityEngine::Transform::get_position(&v496, v114, 0LL);
		                      v490 = *(_QWORD *)&position->x;
		                      v118 = position->z;
		                      v119 = UnityEngine::Component::get_transform((Component *)current, 0LL);
		                      if ( !v119 )
		                        sub_1800D8250(v121, v120);
		                      v122 = UnityEngine::Transform::get_position(&v497, v119, 0LL);
		                      v123 = v118 - v122->z;
		                      v124 = (__m128)HIDWORD(v490);
		                      v124.m128_f32[0] = *((float *)&v490 + 1)
		                                       - _mm_shuffle_ps(
		                                           (__m128)*(unsigned __int64 *)&v122->x,
		                                           (__m128)*(unsigned __int64 *)&v122->x,
		                                           85).m128_f32[0];
		                      v125 = (__m128)(unsigned int)v490;
		                      v452 = *(_QWORD *)&v122->x;
		                      v125.m128_f32[0] = *(float *)&v490 - *(float *)&v452;
		                      v488 = _mm_unpacklo_ps(v125, v124).m128_u64[0];
		                      v489 = v123;
		                      v126 = (float *)sub_182FAE2B0(v498, &v488);
		                      v124.m128_i32[0] = HIDWORD(current[5].monitor);
		                      v127 = v124.m128_f32[0] * v126[2];
		                      v130 = (__m128)v124.m128_u32[0];
		                      v128 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)v126, (__m128)*(unsigned __int64 *)v126, 85).m128_f32[0];
		                      v452 = *(_QWORD *)v126;
		                      v129 = v127 + v79;
		                      v130.m128_f32[0] = (float)(v124.m128_f32[0] * v128) + v81.m128_f32[0];
		                      v131 = v83;
		                      v131.m128_f32[0] = v83.m128_f32[0] + (float)(v124.m128_f32[0] * *(float *)&v452);
		                      if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                      *(_QWORD *)&v487.x = _mm_unpacklo_ps(v131, v130).m128_u64[0];
		                      v487.z = v129;
		                      v132 = *(_OWORD *)&v483.m00;
		                      v472 = v483;
		                      v133 = *(_OWORD *)&v483.m01;
		                      v134 = UnityEngine::Rendering::LensFlareCommonSRP::WorldToViewport(
		                               &v499,
		                               cam,
		                               v48 != 1,
		                               1,
		                               &v472,
		                               &v487,
		                               0LL);
		                      v452 = *(_QWORD *)&v134->x;
		                      v135 = v134->z;
		                      v136 = v445;
		                      if ( v48 )
		                        occlusionRadius = UnityEngine::Rendering::LensFlareComponentSRP::celestialProjectedOcclusionRadius(
		                                            v445,
		                                            cam,
		                                            0LL);
		                      else
		                        occlusionRadius = v445->fields.occlusionRadius;
		                      v138 = UnityEngine::Component::get_transform((Component *)cam, 0LL);
		                      if ( !v138 )
		                        sub_1800D8250(v140, v139);
		                      up = UnityEngine::Transform::get_up(&v500, v138, 0LL);
		                      v142 = occlusionRadius * up->z;
		                      v143 = occlusionRadius
		                           * _mm_shuffle_ps(
		                               (__m128)*(unsigned __int64 *)&up->x,
		                               (__m128)*(unsigned __int64 *)&up->x,
		                               85).m128_f32[0];
		                      v452 = *(_QWORD *)&up->x;
		                      v144 = v79 + v142;
		                      v81.m128_f32[0] = v81.m128_f32[0] + v143;
		                      v83.m128_f32[0] = v83.m128_f32[0] + (float)(occlusionRadius * *(float *)&v452);
		                      if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                      *(_QWORD *)&v474.x = _mm_unpacklo_ps(v83, v81).m128_u64[0];
		                      v474.z = v144;
		                      *(_OWORD *)&v472.m00 = v132;
		                      *(_OWORD *)&v472.m01 = v133;
		                      *(_OWORD *)&v472.m02 = *(_OWORD *)&v483.m02;
		                      *(_OWORD *)&v472.m03 = *(_OWORD *)&v483.m03;
		                      v145 = (__m128)*(unsigned __int64 *)&UnityEngine::Rendering::LensFlareCommonSRP::WorldToViewport(
		                                                             &v501,
		                                                             cam,
		                                                             v48 != 1,
		                                                             1,
		                                                             &v472,
		                                                             &v474,
		                                                             0LL)->x;
		                      v146 = _mm_shuffle_ps(v145, v145, 85);
		                      v146.m128_f32[0] = v146.m128_f32[0] - *((float *)&v461 + 1);
		                      v452 = v145.m128_u64[0];
		                      v145.m128_f32[0] = v145.m128_f32[0] - *(float *)&v461;
		                      drawDataCount = (int32_t *)_mm_unpacklo_ps(v145, v146).m128_u64[0];
		                      *(double *)v145.m128_u64 = sub_182FA2AF0(&drawDataCount);
		                      v149 = v145.m128_i32[0];
		                      sampleCount = v136->fields.sampleCount;
		                      if ( !settingParameters )
		                        sub_1800D8250(v148, v147);
		                      v151 = (int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                    (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._lensFlareOccSampleCount_k__BackingField,
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                      if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		                        il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		                      v154 = v151;
		                      v155 = sampleCount;
		                      if ( sampleCount > v154 )
		                        v155 = v154;
		                      LODWORD(v465) = v149;
		                      *((float *)&v465 + 1) = (float)(int)v155;
		                      *((float *)&v465 + 2) = v135;
		                      *((float *)&v465 + 3) = v469 / v468;
		                      v156 = v445;
		                      LOBYTE(drawDataCount) = v445->fields.useOcclusion;
		                      m_CachedPtr = 0LL;
		                      typeMetadataHandle_high = (HGRuntimeGrassQuery_Node *)TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                      if ( TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->static_fields->occlusionRT )
		                      {
		                        if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                        {
		                          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                          typeMetadataHandle_high = (HGRuntimeGrassQuery_Node *)TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                        }
		                        parent = (RTHandle *)typeMetadataHandle_high[2].fields.parent->fields.parent;
		                        if ( !parent )
		                          sub_1800D8250(0LL, typeMetadataHandle_high);
		                        m_RT = parent->fields.m_RT;
		                        if ( !m_RT )
		                          sub_1800D8250(parent, typeMetadataHandle_high);
		                        m_CachedPtr = m_RT->fields._._.m_CachedPtr;
		                      }
		                      if ( !LODWORD(typeMetadataHandle_high[3].monitor) )
		                      {
		                        il2cpp_runtime_class_init_1(typeMetadataHandle_high);
		                        typeMetadataHandle_high = (HGRuntimeGrassQuery_Node *)TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                      }
		                      *(float *)&v463 = (float)((float)v454
		                                              / (float)SLODWORD(typeMetadataHandle_high[2].fields.parent->fields.bounds.m_Center.z))
		                                      + (float)(0.5
		                                              / (float)SLODWORD(typeMetadataHandle_high[2].fields.parent->fields.bounds.m_Center.z));
		                      *(_QWORD *)((char *)&v463 + 4) = 1056964608LL;
		                      HIDWORD(v463) = 0;
		                      if ( v156->fields.useOcclusion && v155 > 0 )
		                        ++v454;
		                      v160 = *((_QWORD *)monitor + 3);
		                      v452 = v160;
		                      v161 = 0;
		                      LODWORD(param_0004ea56.monitor) = 0;
		                      if ( !v160 )
		                        sub_1800D8250(0LL, typeMetadataHandle_high);
		                      while ( 2 )
		                      {
		                        if ( (signed int)v161 >= *(_DWORD *)(v160 + 24) )
		                        {
		                          v23 = *(_OWORD *)&v483.m00;
		                          v24 = *(_OWORD *)&v483.m01;
		                          goto LABEL_20;
		                        }
		                        if ( v161 >= *(_DWORD *)(v160 + 24) )
		                          sub_1800D2AA0(v160, typeMetadataHandle_high, v152);
		                        param_0004ea56.klass = *(HGRuntimeGrassQuery_Node__Class **)(v160 + 8LL * (int)v161 + 32);
		                        sub_18002D1B0(&param_0004ea56, typeMetadataHandle_high, v152, (Int32__Array **)v153, methoda);
		                        v153 = param_0004ea56.klass;
		                        if ( !param_0004ea56.klass || !LOBYTE(param_0004ea56.klass->_0.name) )
		                          goto LABEL_414;
		                        dummy = param_0004ea56.klass->_0.this_arg.data.dummy;
		                        v163 = TypeInfo::UnityEngine::Object;
		                        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                        {
		                          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                          v163 = TypeInfo::UnityEngine::Object;
		                          v153 = param_0004ea56.klass;
		                          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                          {
		                            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                            v163 = TypeInfo::UnityEngine::Object;
		                            v153 = param_0004ea56.klass;
		                          }
		                        }
		                        if ( !dummy )
		                          goto LABEL_565;
		                        if ( !v163->_1.cctor_finished_or_no_cctor )
		                        {
		                          il2cpp_runtime_class_init_1(v163);
		                          v163 = TypeInfo::UnityEngine::Object;
		                          v153 = param_0004ea56.klass;
		                        }
		                        param_0004ea56.fields.bounds.m_Center.x = v99;
		                        LODWORD(param_0004ea56.monitor) = v161;
		                        if ( dummy[2] )
		                        {
		                          v164 = 0;
		                          LODWORD(param_0004ea56.monitor) = v161;
		                          param_0004ea56.fields.bounds.m_Center.x = v99;
		                        }
		                        else
		                        {
		                          v164 = 1;
		                        }
		                        if ( v164 )
		                        {
		LABEL_565:
		                          if ( !v153 )
		                            sub_1800D8250(v163, typeMetadataHandle_high);
		                          if ( !HIDWORD(v153->_0.typeMetadataHandle) )
		                            goto LABEL_414;
		                        }
		                        if ( !v153 )
		                          sub_1800D8250(v163, typeMetadataHandle_high);
		                        if ( *((float *)&v153->_0.byval_arg + 3) <= 0.0
		                          || SLODWORD(v153->_0.castClass) <= 0
		                          || *((float *)&v153->_0.byval_arg + 3) <= 0.0 )
		                        {
		                          goto LABEL_414;
		                        }
		                        v165 = v470;
		                        v166 = v470;
		                        v167 = v467;
		                        v168 = v467;
		                        v169 = *(float *)&param_0004ea56.fields.right;
		                        v170 = *(float *)&param_0004ea56.fields.right;
		                        v171 = *((float *)&param_0004ea56.fields.right + 1);
		                        v172 = *((float *)&param_0004ea56.fields.right + 1);
		                        if ( !v163->_1.cctor_finished_or_no_cctor )
		                          il2cpp_runtime_class_init_1(v163);
		                        v173 = x;
		                        if ( UnityEngine::Object::op_Inequality(x, 0LL, 0LL) )
		                        {
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v175, v174);
		                          if ( LOBYTE(param_0004ea56.klass->_0.interopData) )
		                          {
		                            if ( !v173 )
		                              sub_1800D8250(v175, v174);
		                            v177 = UnityEngine::Component::get_gameObject((Component *)v173, 0LL);
		                            v178 = dirLightOverrideInfo->dirLightGameObject;
		                            v174 = TypeInfo::UnityEngine::Object;
		                            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                            {
		                              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                              v174 = TypeInfo::UnityEngine::Object;
		                              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                              {
		                                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                                v174 = TypeInfo::UnityEngine::Object;
		                              }
		                            }
		                            LOBYTE(v176) = v178 == 0LL;
		                            if ( v178 == 0LL && v177 == 0LL )
		                              goto LABEL_206;
		                            if ( v178 )
		                            {
		                              if ( v177 )
		                              {
		                                v179 = v177 == v178;
		                                goto LABEL_189;
		                              }
		                              if ( !v174->_1.cctor_finished_or_no_cctor )
		                                il2cpp_runtime_class_init_1(v174);
		                              param_0004ea56.fields.bounds.m_Center.x = v99;
		                              LODWORD(param_0004ea56.monitor) = v161;
		                              if ( !v178->fields._.m_CachedPtr )
		                              {
		                                v179 = 1;
		                                goto LABEL_189;
		                              }
		                              param_0004ea56.fields.bounds.m_Center.x = v99;
		LABEL_187:
		                              v179 = 0;
		                            }
		                            else
		                            {
		                              if ( !v174->_1.cctor_finished_or_no_cctor )
		                                il2cpp_runtime_class_init_1(v174);
		                              if ( !v177 )
		                                sub_1800D8250(v176, v174);
		                              param_0004ea56.fields.bounds.m_Center.x = v99;
		                              if ( v177->fields._.m_CachedPtr )
		                                goto LABEL_187;
		                              v179 = 1;
		                            }
		                            LODWORD(param_0004ea56.monitor) = v161;
		LABEL_189:
		                            if ( v179 )
		                            {
		LABEL_206:
		                              color = dirLightOverrideInfo->lightData.color;
		LABEL_192:
		                              v172 = v171 * _mm_shuffle_ps((__m128)color, (__m128)color, 255).m128_f32[0];
		                              v170 = v169 * _mm_shuffle_ps((__m128)color, (__m128)color, 170).m128_f32[0];
		                              LODWORD(v181) = _mm_shuffle_ps((__m128)color, (__m128)color, 85).m128_u32[0];
		                              v166 = v165 * color.r;
		                            }
		                            else
		                            {
		                              if ( !UnityEngine::Light::get_useColorTemperature((Light *)v173, 0LL) )
		                              {
		                                color = *UnityEngine::Light::get_color(&v513, (Light *)v173, 0LL);
		                                goto LABEL_192;
		                              }
		                              v190 = *UnityEngine::Light::get_color(&v511, (Light *)v173, 0LL);
		                              colorTemperature = UnityEngine::Light::get_colorTemperature((Light *)v173, 0LL);
		                              *(_OWORD *)&param_0004ea56.fields.bounds.m_Extents.y = 0LL;
		                              UnityEngine::Mathf::CorrelatedColorTemperatureToRGB_Injected(
		                                colorTemperature,
		                                (Color *)&param_0004ea56.fields.bounds.m_Extents.y,
		                                0LL);
		                              v181 = _mm_shuffle_ps((__m128)v190, (__m128)v190, 85).m128_f32[0]
		                                   * param_0004ea56.fields.bounds.m_Extents.z;
		                              v172 = *((float *)&param_0004ea56.fields.right + 1)
		                                   * (float)(_mm_shuffle_ps((__m128)v190, (__m128)v190, 255).m128_f32[0]
		                                           * *((float *)&param_0004ea56.fields.parent + 1));
		                              v170 = v169
		                                   * (float)(_mm_shuffle_ps((__m128)v190, (__m128)v190, 170).m128_f32[0]
		                                           * *(float *)&param_0004ea56.fields.parent);
		                              v166 = v165 * (float)(v190.r * param_0004ea56.fields.bounds.m_Extents.y);
		                            }
		                            v168 = v167 * v181;
		                            v156 = v445;
		                          }
		                        }
		                        y_low = v32;
		                        y_low.m128_f32[0] = v32.m128_f32[0] - (float)(*((float *)&v461 + 1) * 2.0);
		                        param_0004ea56.fields.bounds.m_Center.z = y_low.m128_f32[0];
		                        x_low = (__m128)(unsigned int)v461;
		                        x_low.m128_f32[0] = (float)(*(float *)&v461 * 2.0) - v32.m128_f32[0];
		                        param_0004ea56.fields.bounds.m_Center.y = x_low.m128_f32[0];
		                        globalCos0.screenPos.x = x_low.m128_f32[0];
		                        globalCos0.screenPos.y = y_low.m128_f32[0];
		                        v184 = fabs(x_low.m128_f32[0]);
		                        v185 = fabs(y_low.m128_f32[0]);
		                        if ( v184 <= v185 )
		                          v184 = v185;
		                        radialScreenAttenuationCurve = v156->fields.radialScreenAttenuationCurve;
		                        if ( !radialScreenAttenuationCurve )
		                          sub_1800D8250(0LL, v174);
		                        if ( UnityEngine::AnimationCurve::get_length(radialScreenAttenuationCurve, 0LL) <= 0 )
		                        {
		                          v189 = v32.m128_f32[0];
		                        }
		                        else
		                        {
		                          v188 = v156->fields.radialScreenAttenuationCurve;
		                          if ( !v188 )
		                            sub_1800D8250(0LL, typeMetadataHandle_high);
		                          v189 = UnityEngine::AnimationCurve::Evaluate(v188, v184, 0LL);
		                        }
		                        v192 = param_0004ea56.klass;
		                        if ( !param_0004ea56.klass )
		                          sub_1800D8250(v187, typeMetadataHandle_high);
		                        v193 = (float)((float)(*((float *)&param_0004ea56.klass->_0.byval_arg + 3)
		                                             * v156->fields.intensity)
		                                     * v189)
		                             * v99;
		                        if ( v193 <= 0.0 )
		                          goto LABEL_414;
		                        v194 = param_0004ea56.klass->_0.this_arg.data.dummy;
		                        if ( HIDWORD(param_0004ea56.klass->_0.typeMetadataHandle)
		                          || !BYTE4(param_0004ea56.klass->_0.castClass) )
		                        {
		                          v196 = v32.m128_f32[0];
		                        }
		                        else
		                        {
		                          if ( !v194 )
		                            sub_1800D8250(v187, typeMetadataHandle_high);
		                          v195 = sub_180002F70(7LL, param_0004ea56.klass->_0.this_arg.data.dummy);
		                          v196 = (float)v195 / (float)(int)sub_180002F70(5LL, v194);
		                          v192 = param_0004ea56.klass;
		                          v156 = v445;
		                        }
		                        globalCos0.usedAspectRatio = v196;
		                        if ( !v192 )
		                          sub_1800D8250(v187, typeMetadataHandle_high);
		                        v448 = *(float *)&v192->_0.declaringType;
		                        v197 = *((float *)&v192->_0.this_arg + 3);
		                        if ( BYTE4(v192->_0.castClass) )
		                        {
		                          if ( v196 < v32.m128_f32[0] )
		                          {
		                            v198 = *(float *)&v192->_0.element_class * v196;
		                            goto LABEL_221;
		                          }
		                          v197 = v197 / v196;
		                        }
		                        v198 = *(float *)&v192->_0.element_class;
		LABEL_221:
		                        globalCos0.combinedScale = (float)((float)(v455 * 0.1) * *((float *)&v192->_0.this_arg + 2))
		                                                 * v156->fields.scale;
		                        *(float *)&param_0004ea56.fields.left = globalCos0.combinedScale * v198;
		                        *(float *)&param_0004ea56.fields.grassInstanceBounds = globalCos0.combinedScale * v197;
		                        v199 = *(__m128 *)((char *)&v192->_0.declaringType + 4);
		                        v201 = _mm_shuffle_ps(v199, v199, 255);
		                        v200 = _mm_shuffle_ps(v199, v199, 170);
		                        v202 = _mm_shuffle_ps(v199, v199, 85);
		                        v201.m128_f32[0] = (float)(v201.m128_f32[0] * v172) * v193;
		                        v481 = v201;
		                        v200.m128_f32[0] = (float)(v200.m128_f32[0] * v170) * v193;
		                        v477 = v200;
		                        v202.m128_f32[0] = (float)(v202.m128_f32[0] * v168) * v193;
		                        v476 = v202;
		                        v199.m128_f32[0] = (float)(v199.m128_f32[0] * v166) * v193;
		                        v475 = v199;
		                        GraphicsUVStartsAtTop = UnityEngine::SystemInfo::GetGraphicsUVStartsAtTop(0LL);
		                        v206 = param_0004ea56.klass;
		                        if ( GraphicsUVStartsAtTop )
		                        {
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v205, v204);
		                          v207 = *(float *)&param_0004ea56.klass->_0.byval_arg.data.__klassIndex;
		                        }
		                        else
		                        {
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v205, v204);
		                          v207 = -*(float *)&param_0004ea56.klass->_0.byval_arg.data.__klassIndex;
		                        }
		                        *((float *)&param_0004ea56.fields.left + 1) = v207;
		                        Beyond::DampingMath::cosf(v205, v201.m128_f32[0]);
		                        v208 = (float)-v207 * 0.017453292;
		                        globalCos0.globalCos0 = v208;
		                        Beyond::DampingMath::sinf(v209, v201.m128_f32[0]);
		                        globalSin0 = v208;
		                        globalCos0.globalSin0 = v208;
		                        v211 = *((float *)&v206->_0.name + 1) + *((float *)&v206->_0.name + 1);
		                        *((float *)&param_0004ea56.monitor + 1) = v211;
		                        globalCos0.position = v211;
		                        v459 = 0LL;
		                        v212 = (Object_1 *)v206->_0.this_arg.data.dummy;
		                        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                        v213 = UnityEngine::Object::op_Inequality(v212, 0LL, 0LL);
		                        v216 = param_0004ea56.klass;
		                        if ( v213 )
		                        {
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v215, v214);
		                          v217 = param_0004ea56.klass->_0.this_arg.data.dummy;
		                          if ( !v217 )
		                            sub_1800D8250(v215, v214);
		                          v459 = (void *)v217[2];
		                        }
		                        if ( !param_0004ea56.klass )
		                          sub_1800D8250(v215, v214);
		                        Beyond::JobMathf::Clamp01(v215, v201.m128_f32[0]);
		                        if ( HIDWORD(v216->_0.typeMetadataHandle) == 2 )
		                        {
		                          v201.m128_i32[0] = 1084227584;
		                          sub_1803369A0();
		                        }
		                        v219 = *(float *)&v216->_1.initializationExceptionGCHandle;
		                        if ( v156->fields.allowOffScreen )
		                          v220 = v32.m128_i32[0];
		                        else
		                          v220 = -1082130432;
		                        v221 = v32.m128_f32[0] - *((float *)&v216->_1.typeHierarchy + 1);
		                        Beyond::JobMathf::Clamp01(v218, v201.m128_f32[0]);
		                        Beyond::JobMathf::ClampedLerp(v222, 4.0, v221, v202.m128_f32[0]);
		                        *(float *)&v223 = v32.m128_f32[0] / (float)SHIDWORD(v216->_1.unity_user_data);
		                        *(_QWORD *)&v464 = __PAIR64__(v224, v220);
		                        *((_QWORD *)&v464 + 1) = __PAIR64__(v223, COERCE_UNSIGNED_INT(sub_180335960()));
		                        if ( HIDWORD(v216->_0.typeMetadataHandle) == 2 )
		                        {
		                          v226 = v32.m128_f32[0] / (float)SHIDWORD(v216->_1.unity_user_data);
		                          Beyond::DampingMath::cosf(v225, 4.0);
		                          v231 = sub_180338A80(v228, v227, v229, v230);
		                          *((float *)&v453 + 1) = (float)(v226 * 3.1415927) - (float)(v219 * (float)(v226 * 3.1415927));
		                          *((float *)&v453 + 2) = v226 * 6.2831855;
		                          *((float *)&v453 + 3) = *((float *)&v453 + 1) * v231;
		                        }
		                        else
		                        {
		                          *(_QWORD *)((char *)&v453 + 4) = 0LL;
		                          HIDWORD(v453) = 0;
		                        }
		                        *(float *)&v453 = v219;
		                        v232 = BYTE4(v216->_0.element_class);
		                        castClass = (int32_t)v216->_0.castClass;
		                        v451 = castClass;
		                        if ( !v232 || castClass == 1 )
		                        {
		                          v410 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                          if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                          {
		                            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                            v410 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                            v216 = param_0004ea56.klass;
		                          }
		                          LensFlareRayOffset = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                                                 v211,
		                                                 v208,
		                                                 v208,
		                                                 0LL);
		                          if ( !v216 )
		                            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v412, v411);
		                          if ( BYTE4(v216->interfaceOffsets) )
		                          {
		                            if ( !v410->_1.cctor_finished_or_no_cctor )
		                            {
		                              il2cpp_runtime_class_init_1(v410);
		                              v216 = param_0004ea56.klass;
		                            }
		                            v416 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                     (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                                     0.0,
		                                     v208,
		                                     v208,
		                                     0LL);
		                            if ( !v216 )
		                              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v415, v414);
		                            rgctx_data = (AnimationCurve *)v216->rgctx_data;
		                            if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                            *(Vector2 *)&param_0004ea56.fields.bounds.m_Extents.y = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
		                                                                                      LensFlareRayOffset,
		                                                                                      v416,
		                                                                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(param_0004ea56.fields.grassInstanceBounds), (__m128)LODWORD(param_0004ea56.fields.left)),
		                                                                                      rgctx_data,
		                                                                                      (LensFlarePassConstructor_c_DisplayClass9_0 *)&param_0004ea56,
		                                                                                      &globalCos0,
		                                                                                      0LL);
		                            y = param_0004ea56.fields.bounds.m_Extents.y;
		                            *(float *)&param_0004ea56.fields.left = param_0004ea56.fields.bounds.m_Extents.z;
		                            v410 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                            v216 = param_0004ea56.klass;
		                            v419 = globalCos0.position;
		                            y_low = (__m128)LODWORD(globalCos0.screenPos.y);
		                            x_low = (__m128)LODWORD(globalCos0.screenPos.x);
		                          }
		                          else
		                          {
		                            v419 = *((float *)&param_0004ea56.monitor + 1);
		                            y = *(float *)&param_0004ea56.fields.grassInstanceBounds;
		                          }
		                          if ( !v216 )
		                            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v412, v411);
		                          type_high = (__m128)HIDWORD(v216->_0.byval_arg.data.type);
		                          v421 = (__m128)*((unsigned int *)&v216->_0.byval_arg + 2);
		                          namespaze_low = (__m128)LODWORD(v216->_0.namespaze);
		                          namespaze_high = (__m128)HIDWORD(v216->_0.namespaze);
		                          typeMetadataHandle = (char)v216->_0.typeMetadataHandle;
		                          if ( !v410->_1.cctor_finished_or_no_cctor )
		                            il2cpp_runtime_class_init_1(v410);
		                          v426 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
		                                    (Vector4 *)&v494,
		                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(type_high, v421),
		                                    LensFlareRayOffset,
		                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v449), v32),
		                                    v448,
		                                    v419,
		                                    *((float *)&param_0004ea56.fields.left + 1),
		                                    (Vector2)*(_OWORD *)&_mm_unpacklo_ps(namespaze_low, namespaze_high),
		                                    typeMetadataHandle,
		                                    0LL);
		                          *(_QWORD *)&v447 = __PAIR64__(y_low.m128_u32[0], x_low.m128_u32[0]);
		                          *((_QWORD *)&v447 + 1) = __PAIR64__((unsigned int)param_0004ea56.fields.left, LODWORD(y));
		                          *(_QWORD *)&v482 = __PAIR64__(v476.m128_u32[0], v475.m128_u32[0]);
		                          *((_QWORD *)&v482 + 1) = __PAIR64__(v481.m128_u32[0], v477.m128_u32[0]);
		                          v427 = *v11;
		                          if ( !&drawDataList[v427] )
		                            sub_1800D8250(v427, v425);
		                          drawDataList[v427].useOcclusion = (char)drawDataCount;
		                          v428 = *v11;
		                          if ( !&drawDataList[v428] )
		                            sub_1800D8250(v428, v425);
		                          drawDataList[v428].allowMultipleElement = v232;
		                          v429 = *v11;
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v429, v425);
		                          cctor_started_low = LOBYTE(param_0004ea56.klass->_1.cctor_started);
		                          if ( !&drawDataList[v429] )
		                            sub_1800D8250(v429, cctor_started_low);
		                          drawDataList[v429].inverseSDF = cctor_started_low;
		                          v431 = *v11;
		                          if ( !&drawDataList[v431] )
		                            sub_1800D8250(v431, cctor_started_low);
		                          drawDataList[v431].elementCount = castClass;
		                          v432 = *v11;
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v432, cctor_started_low);
		                          generic_class_high = HIDWORD(param_0004ea56.klass->_0.generic_class);
		                          if ( !&drawDataList[v432] )
		                            sub_1800D8250(v432, generic_class_high);
		                          drawDataList[v432].blendMode = generic_class_high;
		                          v434 = *v11;
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v434, generic_class_high);
		                          interopData_high = HIDWORD(param_0004ea56.klass->_0.interopData);
		                          if ( !&drawDataList[v434] )
		                            sub_1800D8250(v434, interopData_high);
		                          drawDataList[v434].distribution = interopData_high;
		                          v436 = *v11;
		                          if ( !param_0004ea56.klass )
		                            sub_1800D8250(v436, interopData_high);
		                          typeMetadataHandle_high = (HGRuntimeGrassQuery_Node *)HIDWORD(param_0004ea56.klass->_0.typeMetadataHandle);
		                          if ( !&drawDataList[v436] )
		                            sub_1800D8250(v436, typeMetadataHandle_high);
		                          drawDataList[v436].flareType = (int)typeMetadataHandle_high;
		                          v437 = *v11;
		                          if ( !&drawDataList[v437] )
		                            sub_1800D8250(v437, typeMetadataHandle_high);
		                          ptr = drawDataList[v437].lensFlareCBHandle.ptr;
		                          *ptr = v426;
		                          ptr[1] = v465;
		                          ptr[2] = v447;
		                          ptr[3] = v464;
		                          ptr[4] = v453;
		                          ptr[5] = v463;
		                          ptr[6] = v482;
		                          v439 = *v11;
		                          if ( !&drawDataList[v439] )
		                            sub_1800D8250(v439, typeMetadataHandle_high);
		                          drawDataList[v439].flareOcclusionTexture = m_CachedPtr;
		                          v440 = *v11;
		                          if ( !&drawDataList[v440] )
		                            sub_1800D8250(v440, typeMetadataHandle_high);
		                          drawDataList[v440].flareTexture = v459;
		                          ++*v11;
		                        }
		                        else
		                        {
		                          v456 = (float)(*(float *)&v216->_0.klass + *(float *)&v216->_0.klass) / (float)(castClass - 1);
		                          if ( HIDWORD(v216->_0.interopData) )
		                          {
		                            if ( HIDWORD(v216->_0.interopData) == 2 )
		                            {
		                              value = 0LL;
		                              UnityEngine::Random::get_state_Injected(&value, 0LL);
		                              if ( !param_0004ea56.klass )
		                                sub_1800D8250(v290, v289);
		                              UnityEngine::Random::InitState((int32_t)param_0004ea56.klass->_0.properties, 0LL);
		                              v293 = param_0004ea56.klass;
		                              if ( !param_0004ea56.klass )
		                                sub_1800D8250(v292, v291);
		                              v294 = v208 * *(float *)&param_0004ea56.klass->_0.implementedInterfaces;
		                              *(float *)&v457 = v294;
		                              v295 = v294;
		                              v296 = 0;
		                              while ( 1 )
		                              {
		                                if ( !v293 )
		                                  sub_1800D8250(v292, v291);
		                                if ( v296 >= SLODWORD(v293->_0.castClass) )
		                                  break;
		                                if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                                v299 = UnityEngine::Random::Range(-1.0, 1.0, 0LL);
		                                v300 = param_0004ea56.klass;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v298, v297);
		                                v301 = (float)(v299 * *(float *)&param_0004ea56.klass->_0.nestedTypes) + 1.0;
		                                v302 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                                if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                                {
		                                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                                  v302 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                                  v300 = param_0004ea56.klass;
		                                }
		                                v303 = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z);
		                                v306 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                                x_low,
		                                                                (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z)),
		                                         v211,
		                                         v208,
		                                         globalSin0,
		                                         0LL);
		                                grassInstanceBounds_low = (__m128)LODWORD(param_0004ea56.fields.grassInstanceBounds);
		                                left_low = (__m128)LODWORD(param_0004ea56.fields.left);
		                                if ( !v300 )
		                                  ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v305, v304);
		                                if ( BYTE4(v300->interfaceOffsets) )
		                                {
		                                  if ( !v302->_1.cctor_finished_or_no_cctor )
		                                  {
		                                    il2cpp_runtime_class_init_1(v302);
		                                    v300 = param_0004ea56.klass;
		                                  }
		                                  v311 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, v303),
		                                           0.0,
		                                           v208,
		                                           globalCos0.globalSin0,
		                                           0LL);
		                                  if ( !v300 )
		                                    ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v310, v309);
		                                  v312 = (AnimationCurve *)v300->rgctx_data;
		                                  if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                                  v450 = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
		                                           v306,
		                                           v311,
		                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(grassInstanceBounds_low, left_low),
		                                           v312,
		                                           (LensFlarePassConstructor_c_DisplayClass9_0 *)&param_0004ea56,
		                                           &globalCos0,
		                                           0LL);
		                                  grassInstanceBounds_low = (__m128)LODWORD(v450.x);
		                                  left_low = (__m128)LODWORD(v450.y);
		                                  v300 = param_0004ea56.klass;
		                                  HIDWORD(param_0004ea56.monitor) = LODWORD(globalCos0.position);
		                                  *(Vector2 *)&param_0004ea56.fields.bounds.m_Center.y = globalCos0.screenPos;
		                                }
		                                if ( !v300 )
		                                  ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v305, v304);
		                                v313 = *((float *)&v300->_0.implementedInterfaces + 1);
		                                if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                                v314 = (__m128)0xBF800000;
		                                v314.m128_f32[0] = UnityEngine::Random::Range(-1.0, 1.0, 0LL) * v313;
		                                v315 = v314;
		                                v315.m128_f32[0] = v314.m128_f32[0] * left_low.m128_f32[0];
		                                v314.m128_f32[0] = v314.m128_f32[0] * grassInstanceBounds_low.m128_f32[0];
		                                *(Vector2 *)&param_0004ea56.fields.bounds.m_Extents.y = sub_1853DF234(
		                                                                                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(grassInstanceBounds_low, left_low),
		                                                                                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v314, v315),
		                                                                                          v316,
		                                                                                          v317);
		                                v320 = param_0004ea56.fields.bounds.m_Extents.y;
		                                v450 = *(Vector2 *)&param_0004ea56.fields.bounds.m_Extents.y;
		                                v321 = param_0004ea56.fields.bounds.m_Extents.z;
		                                if ( !param_0004ea56.klass )
		                                  ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v319, v318);
		                                methods = param_0004ea56.klass->_0.methods;
		                                v325 = UnityEngine::Random::Range(0.0, 1.0, 0LL);
		                                if ( !methods )
		                                  sub_1800D8250(v324, v323);
		                                v328 = *UnityEngine::Gradient::Evaluate(&v514, (Gradient *)methods, v325, 0LL);
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v327, v326);
		                                v329 = (__m128)LODWORD(param_0004ea56.klass->_0.namespaze);
		                                v330 = (__m128)HIDWORD(param_0004ea56.klass->_0.namespaze);
		                                v331 = (__m128)0xBF800000;
		                                v331.m128_f32[0] = UnityEngine::Random::Range(-1.0, 1.0, 0LL);
		                                v332 = v331;
		                                v332.m128_f32[0] = v331.m128_f32[0] * v294;
		                                v331.m128_f32[0] = v331.m128_f32[0] * v295;
		                                v335 = sub_1853DF234(
		                                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v329, v330),
		                                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v331, v332),
		                                         v333,
		                                         v334);
		                                v338 = UnityEngine::Random::Range(-3.1415927, 3.1415927, 0LL);
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v337, v336);
		                                v339 = (float)(v338 * *(float *)&param_0004ea56.klass->interfaceOffsets) + v448;
		                                if ( v301 > 0.0 )
		                                {
		                                  v340 = (__m128)HIDWORD(param_0004ea56.klass->_0.byval_arg.data.type);
		                                  v341 = (__m128)*((unsigned int *)&param_0004ea56.klass->_0.byval_arg + 2);
		                                  v342 = (char)param_0004ea56.klass->_0.typeMetadataHandle;
		                                  if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                                    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                                  v343 = (Vector2)_mm_unpacklo_ps(v340, v341).m128_u64[0];
		                                  v344 = param_0004ea56.fields.bounds.m_Center.y;
		                                  v345 = param_0004ea56.fields.bounds.m_Center.z;
		                                  v346 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
		                                            &v507,
		                                            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                                   (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y),
		                                                                   (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z)),
		                                            v343,
		                                            v306,
		                                            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                                   (__m128)LODWORD(v449),
		                                                                   (__m128)0x3F800000u),
		                                            v339,
		                                            *((float *)&param_0004ea56.monitor + 1),
		                                            *((float *)&param_0004ea56.fields.left + 1),
		                                            v335,
		                                            v342,
		                                            0LL);
		                                  *(_QWORD *)&v447 = __PAIR64__(LODWORD(v345), LODWORD(v344));
		                                  *((_QWORD *)&v447 + 1) = __PAIR64__(LODWORD(v321), LODWORD(v320));
		                                  *(_OWORD *)&param_0004ea56.fields.bounds.m_Extents.y = 0LL;
		                                  System::ValueTuple<float,float,float,float>::ValueTuple(
		                                    (ValueTuple_4_Single_Single_Single_Single_ *)&param_0004ea56.fields.bounds.m_Extents.y,
		                                    (float)(v475.m128_f32[0] * v328.r) * v301,
		                                    (float)(v476.m128_f32[0] * _mm_shuffle_ps((__m128)v328, (__m128)v328, 85).m128_f32[0])
		                                  * v301,
		                                    (float)(v477.m128_f32[0]
		                                          * _mm_shuffle_ps((__m128)v328, (__m128)v328, 170).m128_f32[0])
		                                  * v301,
		                                    (float)(v481.m128_f32[0]
		                                          * _mm_shuffle_ps((__m128)v328, (__m128)v328, 255).m128_f32[0])
		                                  * v301,
		                                    0LL);
		                                  v479 = *(_OWORD *)&param_0004ea56.fields.bounds.m_Extents.y;
		                                  v348 = *v11;
		                                  if ( !&drawDataList[v348] )
		                                    sub_1800D8250(v348, v347);
		                                  drawDataList[v348].useOcclusion = (char)drawDataCount;
		                                  v349 = *v11;
		                                  if ( !&drawDataList[v349] )
		                                    sub_1800D8250(v349, v347);
		                                  drawDataList[v349].allowMultipleElement = v232;
		                                  v350 = *v11;
		                                  if ( !param_0004ea56.klass )
		                                    sub_1800D8250(v350, v347);
		                                  v351 = LOBYTE(param_0004ea56.klass->_1.cctor_started);
		                                  if ( !&drawDataList[v350] )
		                                    sub_1800D8250(v350, v351);
		                                  drawDataList[v350].inverseSDF = v351;
		                                  v352 = *v11;
		                                  if ( !&drawDataList[v352] )
		                                    sub_1800D8250(v352, v351);
		                                  drawDataList[v352].elementCount = v451;
		                                  v353 = *v11;
		                                  if ( !param_0004ea56.klass )
		                                    sub_1800D8250(v353, v351);
		                                  v354 = HIDWORD(param_0004ea56.klass->_0.generic_class);
		                                  if ( !&drawDataList[v353] )
		                                    sub_1800D8250(v353, v354);
		                                  drawDataList[v353].blendMode = v354;
		                                  v355 = *v11;
		                                  if ( !param_0004ea56.klass )
		                                    sub_1800D8250(v355, v354);
		                                  v356 = HIDWORD(param_0004ea56.klass->_0.interopData);
		                                  if ( !&drawDataList[v355] )
		                                    sub_1800D8250(v355, v356);
		                                  drawDataList[v355].distribution = v356;
		                                  v357 = *v11;
		                                  if ( !param_0004ea56.klass )
		                                    sub_1800D8250(v357, v356);
		                                  v358 = HIDWORD(param_0004ea56.klass->_0.typeMetadataHandle);
		                                  if ( !&drawDataList[v357] )
		                                    sub_1800D8250(v357, v358);
		                                  drawDataList[v357].flareType = v358;
		                                  v359 = *v11;
		                                  if ( !&drawDataList[v359] )
		                                    sub_1800D8250(v359, v358);
		                                  v360 = drawDataList[v359].lensFlareCBHandle.ptr;
		                                  *v360 = v346;
		                                  v360[1] = v465;
		                                  v360[2] = v447;
		                                  v360[3] = v464;
		                                  v360[4] = v453;
		                                  v360[5] = v463;
		                                  v360[6] = v479;
		                                  v361 = *v11;
		                                  if ( !&drawDataList[v361] )
		                                    sub_1800D8250(v361, v358);
		                                  drawDataList[v361].flareOcclusionTexture = m_CachedPtr;
		                                  v362 = *v11;
		                                  if ( !&drawDataList[v362] )
		                                    sub_1800D8250(v362, v358);
		                                  drawDataList[v362].flareTexture = v459;
		                                  ++*v11;
		                                }
		                                v363 = v456;
		                                v364 = *((float *)&param_0004ea56.monitor + 1) + v456;
		                                if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                                v365 = UnityEngine::Random::Range(-1.0, 1.0, 0LL);
		                                v293 = param_0004ea56.klass;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v292, v291);
		                                v211 = v364
		                                     + (float)((float)((float)(v363 * 0.5) * v365)
		                                             * *((float *)&param_0004ea56.klass->_0.nestedTypes + 1));
		                                *((float *)&param_0004ea56.monitor + 1) = v211;
		                                globalCos0.position = v211;
		                                ++v296;
		                                v294 = *(float *)&v457;
		                                x_low = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y);
		                                v208 = globalCos0.globalCos0;
		                                globalSin0 = globalCos0.globalSin0;
		                              }
		                              UnityEngine::Random::set_state_Injected(&value, 0LL);
		                              v32 = (__m128)0x3F800000u;
		                              v156 = v445;
		                            }
		                            else if ( HIDWORD(v216->_0.interopData) == 1 )
		                            {
		                              v234 = 0;
		                              while ( 1 )
		                              {
		                                if ( !v216 )
		                                  sub_1800D8250(v225, typeMetadataHandle_high);
		                                if ( v234 >= SLODWORD(v216->_0.castClass) )
		                                  break;
		                                if ( SLODWORD(v216->_0.castClass) < 2 )
		                                  v235 = 0.5;
		                                else
		                                  v235 = (float)v234 / (float)(LODWORD(v216->_0.castClass) - 1);
		                                v236 = (Gradient *)v216->_0.methods;
		                                if ( !v236 )
		                                  sub_1800D8250(v225, 0LL);
		                                v239 = *UnityEngine::Gradient::Evaluate(&v512, v236, v235, 0LL);
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v238, v237);
		                                fields = param_0004ea56.klass->_0.fields;
		                                if ( !fields )
		                                  sub_1800D8250(0LL, v237);
		                                if ( UnityEngine::AnimationCurve::get_length((AnimationCurve *)fields, 0LL) <= 0 )
		                                {
		                                  v244 = 1.0;
		                                }
		                                else
		                                {
		                                  if ( !param_0004ea56.klass )
		                                    sub_1800D8250(v242, v241);
		                                  v243 = param_0004ea56.klass->_0.fields;
		                                  if ( !v243 )
		                                    sub_1800D8250(0LL, v241);
		                                  v244 = UnityEngine::AnimationCurve::Evaluate((AnimationCurve *)v243, v235, 0LL);
		                                }
		                                v245 = param_0004ea56.klass;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v242, v241);
		                                v246 = (float)((float)(*(float *)&param_0004ea56.klass->_0.klass
		                                                     + *(float *)&param_0004ea56.klass->_0.klass)
		                                             * v244)
		                                     + v211;
		                                v247 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                                if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                                {
		                                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                                  v247 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                                  v245 = param_0004ea56.klass;
		                                }
		                                v250 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                                         v246,
		                                         v208,
		                                         globalSin0,
		                                         0LL);
		                                v251 = (__m128)LODWORD(param_0004ea56.fields.grassInstanceBounds);
		                                v252 = (__m128)LODWORD(param_0004ea56.fields.left);
		                                if ( !v245 )
		                                  ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v249, v248);
		                                if ( BYTE4(v245->interfaceOffsets) )
		                                {
		                                  if ( !v247->_1.cctor_finished_or_no_cctor )
		                                  {
		                                    il2cpp_runtime_class_init_1(v247);
		                                    v245 = param_0004ea56.klass;
		                                  }
		                                  v255 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		                                           0.0,
		                                           globalCos0.globalCos0,
		                                           globalCos0.globalSin0,
		                                           0LL);
		                                  if ( !v245 )
		                                    ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v254, v253);
		                                  v256 = (AnimationCurve *)v245->rgctx_data;
		                                  if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                                  v450 = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
		                                           v250,
		                                           v255,
		                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v251, v252),
		                                           v256,
		                                           (LensFlarePassConstructor_c_DisplayClass9_0 *)&param_0004ea56,
		                                           &globalCos0,
		                                           0LL);
		                                  v251.m128_i32[0] = LODWORD(v450.x);
		                                  v252.m128_i32[0] = LODWORD(v450.y);
		                                  v245 = param_0004ea56.klass;
		                                  HIDWORD(param_0004ea56.monitor) = LODWORD(globalCos0.position);
		                                  *(Vector2 *)&param_0004ea56.fields.bounds.m_Center.y = globalCos0.screenPos;
		                                }
		                                if ( !v245 )
		                                  ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v249, v248);
		                                events = (AnimationCurve *)v245->_0.events;
		                                if ( !events )
		                                  ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v248);
		                                if ( UnityEngine::AnimationCurve::get_length(events, 0LL) <= 0 )
		                                {
		                                  v261 = 1.0;
		                                }
		                                else
		                                {
		                                  if ( !param_0004ea56.klass )
		                                    sub_1800D8250(v259, v258);
		                                  v260 = (AnimationCurve *)param_0004ea56.klass->_0.events;
		                                  if ( !v260 )
		                                    sub_1800D8250(0LL, v258);
		                                  v261 = UnityEngine::AnimationCurve::Evaluate(v260, v235, 0LL);
		                                }
		                                v262 = v261 * v252.m128_f32[0];
		                                v263 = v261 * v251.m128_f32[0];
		                                *(float *)&v457 = v263;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v259, v258);
		                                cctor_thread = (AnimationCurve *)param_0004ea56.klass->_1.cctor_thread;
		                                if ( !cctor_thread )
		                                  sub_1800D8250(0LL, v258);
		                                v267 = UnityEngine::AnimationCurve::Evaluate(cctor_thread, v235, 0LL);
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v266, v265);
		                                v268 = (float)(180.0
		                                             - (float)(180.0 / (float)SLODWORD(param_0004ea56.klass->_0.castClass)))
		                                     * v267;
		                                v269 = (__m128)HIDWORD(param_0004ea56.klass->_0.byval_arg.data.type);
		                                v270 = (__m128)*((unsigned int *)&param_0004ea56.klass->_0.byval_arg + 2);
		                                v271 = (__m128)LODWORD(param_0004ea56.klass->_0.namespaze);
		                                v272 = (__m128)HIDWORD(param_0004ea56.klass->_0.namespaze);
		                                v273 = (char)param_0004ea56.klass->_0.typeMetadataHandle;
		                                if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                                v442 = (Vector2)_mm_unpacklo_ps(v271, v272).m128_u64[0];
		                                x_low = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y);
		                                y_low = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z);
		                                v274 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
		                                          &v510,
		                                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                                 (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y),
		                                                                 (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z)),
		                                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v269, v270),
		                                          v250,
		                                          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                                 (__m128)LODWORD(v449),
		                                                                 (__m128)0x3F800000u),
		                                          v268 + v448,
		                                          v246,
		                                          *((float *)&param_0004ea56.fields.left + 1),
		                                          v442,
		                                          v273,
		                                          0LL);
		                                *(_QWORD *)&v447 = __PAIR64__(y_low.m128_u32[0], x_low.m128_u32[0]);
		                                *((_QWORD *)&v447 + 1) = __PAIR64__(LODWORD(v262), LODWORD(v263));
		                                *(_OWORD *)&param_0004ea56.fields.bounds.m_Extents.y = 0LL;
		                                System::ValueTuple<float,float,float,float>::ValueTuple(
		                                  (ValueTuple_4_Single_Single_Single_Single_ *)&param_0004ea56.fields.bounds.m_Extents.y,
		                                  v475.m128_f32[0] * v239.r,
		                                  v476.m128_f32[0] * _mm_shuffle_ps((__m128)v239, (__m128)v239, 85).m128_f32[0],
		                                  v477.m128_f32[0] * _mm_shuffle_ps((__m128)v239, (__m128)v239, 170).m128_f32[0],
		                                  v481.m128_f32[0] * _mm_shuffle_ps((__m128)v239, (__m128)v239, 255).m128_f32[0],
		                                  0LL);
		                                v478 = *(_OWORD *)&param_0004ea56.fields.bounds.m_Extents.y;
		                                v276 = *v11;
		                                if ( !&drawDataList[v276] )
		                                  sub_1800D8250(v276, v275);
		                                drawDataList[v276].useOcclusion = (char)drawDataCount;
		                                v277 = *v11;
		                                if ( !&drawDataList[v277] )
		                                  sub_1800D8250(v277, v275);
		                                drawDataList[v277].allowMultipleElement = v232;
		                                v278 = *v11;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v278, v275);
		                                v279 = LOBYTE(param_0004ea56.klass->_1.cctor_started);
		                                if ( !&drawDataList[v278] )
		                                  sub_1800D8250(v278, v279);
		                                drawDataList[v278].inverseSDF = v279;
		                                v280 = *v11;
		                                if ( !&drawDataList[v280] )
		                                  sub_1800D8250(v280, v279);
		                                drawDataList[v280].elementCount = v451;
		                                v281 = *v11;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v281, v279);
		                                v282 = HIDWORD(param_0004ea56.klass->_0.generic_class);
		                                if ( !&drawDataList[v281] )
		                                  sub_1800D8250(v281, v282);
		                                drawDataList[v281].blendMode = v282;
		                                v283 = *v11;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v283, v282);
		                                v284 = HIDWORD(param_0004ea56.klass->_0.interopData);
		                                if ( !&drawDataList[v283] )
		                                  sub_1800D8250(v283, v284);
		                                drawDataList[v283].distribution = v284;
		                                v285 = *v11;
		                                if ( !param_0004ea56.klass )
		                                  sub_1800D8250(v285, v284);
		                                typeMetadataHandle_high = (HGRuntimeGrassQuery_Node *)HIDWORD(param_0004ea56.klass->_0.typeMetadataHandle);
		                                if ( !&drawDataList[v285] )
		                                  sub_1800D8250(v285, typeMetadataHandle_high);
		                                drawDataList[v285].flareType = (int)typeMetadataHandle_high;
		                                v286 = *v11;
		                                if ( !&drawDataList[v286] )
		                                  sub_1800D8250(v286, typeMetadataHandle_high);
		                                v287 = drawDataList[v286].lensFlareCBHandle.ptr;
		                                *v287 = v274;
		                                v287[1] = v465;
		                                v287[2] = v447;
		                                v287[3] = v464;
		                                v287[4] = v453;
		                                v287[5] = v463;
		                                v287[6] = v478;
		                                v288 = *v11;
		                                if ( !&drawDataList[v288] )
		                                  sub_1800D8250(v288, typeMetadataHandle_high);
		                                drawDataList[v288].flareOcclusionTexture = m_CachedPtr;
		                                v225 = (Beyond::DampingMath *)*v11;
		                                if ( !&drawDataList[(_QWORD)v225] )
		                                  sub_1800D8250(v225, typeMetadataHandle_high);
		                                drawDataList[(_QWORD)v225].flareTexture = v459;
		                                ++*v11;
		                                ++v234;
		                                v216 = param_0004ea56.klass;
		                                v211 = *((float *)&param_0004ea56.monitor + 1);
		                                v208 = globalCos0.globalCos0;
		                                globalSin0 = globalCos0.globalSin0;
		                              }
		                              v32 = (__m128)0x3F800000u;
		                              break;
		                            }
		LABEL_413:
		                            v161 = (unsigned int)param_0004ea56.monitor;
		LABEL_414:
		                            LODWORD(param_0004ea56.monitor) = ++v161;
		                            v99 = param_0004ea56.fields.bounds.m_Center.x;
		                            v160 = v452;
		                            continue;
		                          }
		                          v366 = 0.0;
		                          v367 = 0;
		                          v368 = v464;
		                          v369 = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y);
		                          while ( 1 )
		                          {
		                            if ( !v216 )
		                              sub_1800D8250(v225, typeMetadataHandle_high);
		                            if ( v367 >= SLODWORD(v216->_0.castClass) )
		                              break;
		                            v370 = (__m128)LODWORD(param_0004ea56.fields.grassInstanceBounds);
		                            v371 = (__m128)LODWORD(param_0004ea56.fields.left);
		                            v372 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                            if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                            {
		                              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                              v372 = TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP;
		                              v216 = param_0004ea56.klass;
		                            }
		                            v373 = globalCos0.globalSin0;
		                            v374 = globalCos0.globalCos0;
		                            v377 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                     (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v369, y_low),
		                                     v211,
		                                     globalCos0.globalCos0,
		                                     globalCos0.globalSin0,
		                                     0LL);
		                            if ( !v216 )
		                              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v376, v375);
		                            if ( BYTE4(v216->interfaceOffsets) )
		                            {
		                              if ( !v372->_1.cctor_finished_or_no_cctor )
		                              {
		                                il2cpp_runtime_class_init_1(v372);
		                                v216 = param_0004ea56.klass;
		                              }
		                              v380 = UnityEngine::Rendering::LensFlareCommonSRP::GetLensFlareRayOffset(
		                                       (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                              v369,
		                                                              (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z)),
		                                       0.0,
		                                       v374,
		                                       v373,
		                                       0LL);
		                              if ( !v216 )
		                                ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v379, v378);
		                              v381 = (AnimationCurve *)v216->rgctx_data;
		                              if ( !TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->_1.cctor_finished_or_no_cctor )
		                                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		                              *(Vector2 *)&param_0004ea56.fields.bounds.m_Extents.y = HG::Rendering::Runtime::LensFlarePassConstructor::_PrepareHGLensFlareDrawNode_g__ComputeLocalSize_9_0(
		                                                                                        v377,
		                                                                                        v380,
		                                                                                        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v370, v371),
		                                                                                        v381,
		                                                                                        (LensFlarePassConstructor_c_DisplayClass9_0 *)&param_0004ea56,
		                                                                                        &globalCos0,
		                                                                                        0LL);
		                              v370.m128_i32[0] = LODWORD(param_0004ea56.fields.bounds.m_Extents.y);
		                              v371.m128_i32[0] = LODWORD(param_0004ea56.fields.bounds.m_Extents.z);
		                              v216 = param_0004ea56.klass;
		                              HIDWORD(param_0004ea56.monitor) = LODWORD(globalCos0.position);
		                              *(Vector2 *)&param_0004ea56.fields.bounds.m_Center.y = globalCos0.screenPos;
		                            }
		                            if ( !v216 )
		                              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v376, v375);
		                            if ( SLODWORD(v216->_0.castClass) < 2 )
		                              v382 = 0.5;
		                            else
		                              v382 = (float)v367 / (float)(LODWORD(v216->_0.castClass) - 1);
		                            v383 = (Gradient *)v216->_0.methods;
		                            if ( !v383 )
		                              ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v376, 0LL);
		                            v386 = *UnityEngine::Gradient::Evaluate(&v508, v383, v382, 0LL);
		                            if ( !param_0004ea56.klass )
		                              sub_1800D8250(v385, v384);
		                            v387 = (__m128)HIDWORD(param_0004ea56.klass->_0.byval_arg.data.type);
		                            v388 = (__m128)*((unsigned int *)&param_0004ea56.klass->_0.byval_arg + 2);
		                            v389 = (__m128)LODWORD(param_0004ea56.klass->_0.namespaze);
		                            v390 = (__m128)HIDWORD(param_0004ea56.klass->_0.namespaze);
		                            v391 = (char)param_0004ea56.klass->_0.typeMetadataHandle;
		                            if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		                              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		                            v443 = (Vector2)_mm_unpacklo_ps(v389, v390).m128_u64[0];
		                            v392 = *((float *)&param_0004ea56.monitor + 1);
		                            v393 = v377;
		                            v394 = (Vector2)_mm_unpacklo_ps(v387, v388).m128_u64[0];
		                            v369 = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y);
		                            y_low = (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z);
		                            v396 = *UnityEngine::Rendering::LensFlareCommonSRP::GetFlareData0(
		                                      &v509,
		                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                             (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.y),
		                                                             (__m128)LODWORD(param_0004ea56.fields.bounds.m_Center.z)),
		                                      v394,
		                                      v393,
		                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v449), (__m128)0x3F800000u),
		                                      v366 + v448,
		                                      *((float *)&param_0004ea56.monitor + 1),
		                                      *((float *)&param_0004ea56.fields.left + 1),
		                                      v443,
		                                      v391,
		                                      0LL);
		                            *(_QWORD *)&v447 = __PAIR64__(y_low.m128_u32[0], v369.m128_u32[0]);
		                            *((_QWORD *)&v447 + 1) = __PAIR64__(v371.m128_u32[0], v370.m128_u32[0]);
		                            *(float *)&v480 = v386.r * v475.m128_f32[0];
		                            *((float *)&v480 + 1) = _mm_shuffle_ps((__m128)v386, (__m128)v386, 85).m128_f32[0]
		                                                  * v476.m128_f32[0];
		                            *((float *)&v480 + 2) = _mm_shuffle_ps((__m128)v386, (__m128)v386, 170).m128_f32[0]
		                                                  * v477.m128_f32[0];
		                            *((float *)&v480 + 3) = _mm_shuffle_ps((__m128)v386, (__m128)v386, 255).m128_f32[0]
		                                                  * v481.m128_f32[0];
		                            v397 = *v11;
		                            if ( !&drawDataList[v397] )
		                              sub_1800D8250(v397, v395);
		                            drawDataList[v397].useOcclusion = (char)drawDataCount;
		                            v398 = *v11;
		                            if ( !&drawDataList[v398] )
		                              sub_1800D8250(v398, v395);
		                            drawDataList[v398].allowMultipleElement = v232;
		                            v399 = *v11;
		                            if ( !param_0004ea56.klass )
		                              sub_1800D8250(v399, v395);
		                            v400 = LOBYTE(param_0004ea56.klass->_1.cctor_started);
		                            if ( !&drawDataList[v399] )
		                              sub_1800D8250(v399, v400);
		                            drawDataList[v399].inverseSDF = v400;
		                            v401 = *v11;
		                            if ( !&drawDataList[v401] )
		                              sub_1800D8250(v401, v400);
		                            drawDataList[v401].elementCount = v451;
		                            v402 = *v11;
		                            if ( !param_0004ea56.klass )
		                              sub_1800D8250(v402, v400);
		                            v403 = HIDWORD(param_0004ea56.klass->_0.generic_class);
		                            if ( !&drawDataList[v402] )
		                              sub_1800D8250(v402, v403);
		                            drawDataList[v402].blendMode = v403;
		                            v404 = *v11;
		                            if ( !param_0004ea56.klass )
		                              sub_1800D8250(v404, v403);
		                            v405 = HIDWORD(param_0004ea56.klass->_0.interopData);
		                            if ( !&drawDataList[v404] )
		                              sub_1800D8250(v404, v405);
		                            drawDataList[v404].distribution = v405;
		                            v406 = *v11;
		                            if ( !param_0004ea56.klass )
		                              sub_1800D8250(v406, v405);
		                            typeMetadataHandle_high = (HGRuntimeGrassQuery_Node *)HIDWORD(param_0004ea56.klass->_0.typeMetadataHandle);
		                            if ( !&drawDataList[v406] )
		                              sub_1800D8250(v406, typeMetadataHandle_high);
		                            drawDataList[v406].flareType = (int)typeMetadataHandle_high;
		                            v407 = *v11;
		                            if ( !&drawDataList[v407] )
		                              sub_1800D8250(v407, typeMetadataHandle_high);
		                            v408 = drawDataList[v407].lensFlareCBHandle.ptr;
		                            *v408 = v396;
		                            v408[1] = v465;
		                            v408[2] = v447;
		                            v408[3] = v368;
		                            v408[4] = v453;
		                            v408[5] = v463;
		                            v408[6] = v480;
		                            v409 = *v11;
		                            if ( !&drawDataList[v409] )
		                              sub_1800D8250(v409, typeMetadataHandle_high);
		                            drawDataList[v409].flareOcclusionTexture = m_CachedPtr;
		                            v225 = (Beyond::DampingMath *)*v11;
		                            if ( !&drawDataList[(_QWORD)v225] )
		                              sub_1800D8250(v225, typeMetadataHandle_high);
		                            drawDataList[(_QWORD)v225].flareTexture = v459;
		                            ++*v11;
		                            v211 = v392 + v456;
		                            *((float *)&param_0004ea56.monitor + 1) = v211;
		                            globalCos0.position = v211;
		                            v216 = param_0004ea56.klass;
		                            if ( !param_0004ea56.klass )
		                              sub_1800D8250(v225, typeMetadataHandle_high);
		                            v366 = v366 + *(float *)&param_0004ea56.klass->_1.cctor_finished_or_no_cctor;
		                            ++v367;
		                          }
		                          v32 = (__m128)0x3F800000u;
		                        }
		                        break;
		                      }
		                      v156 = v445;
		                      goto LABEL_413;
		                    }
		                  }
		                  v455 = v32.m128_f32[0];
		                  goto LABEL_107;
		                }
		LABEL_20:
		                v26 = *(_OWORD *)&v483.m03;
		                v25 = *(_OWORD *)&v483.m02;
		              }
		            }
		          }
		        }
		      }
		      v72 = UnityEngine::Component::get_transform((Component *)current, 0LL);
		      if ( !v72 )
		        sub_1800D8250(v74, v73);
		      v75 = UnityEngine::Transform::get_position(&v502, v72, 0LL);
		      v67.m128_u64[0] = *(_QWORD *)&v75->x;
		      v473 = *(_QWORD *)&v75->x;
		      v71 = v75->z;
		      goto LABEL_85;
		    }
		    catch ( Il2CppExceptionWrapper *v495 )
		    {
		      ex = v495->ex;
		      mono_thread_suspend_all_other_threads(
		        v485,
		        MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::Dispose);
		      if ( ex )
		        sub_18007E1E0(ex);
		      return;
		    }
		LABEL_560:
		    mono_thread_suspend_all_other_threads(
		      &v493,
		      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Rendering::LensFlareComponentSRP>::Dispose);
		  }
		}
		
		private void Prepare(LensFlareDataDrivenData passData, HGRenderGraphBuilder builder, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BBAB18-0x0000000189BBB004
		// Void Prepare(LensFlarePassConstructor+LensFlareDataDrivenData, HGRenderGraphBuilder, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::LensFlarePassConstructor::Prepare(
		        LensFlarePassConstructor *this,
		        LensFlarePassConstructor_LensFlareDataDrivenData *passData,
		        HGRenderGraphBuilder *builder,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  Camera *camera; // rsi
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  __m128i v21; // xmm0
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // ecx
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  Matrix4x4 *projectionMatrix; // rax
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v34; // xmm6
		  __int128 v35; // xmm7
		  __int128 v36; // xmm8
		  __int128 v37; // xmm9
		  Matrix4x4 *v38; // rax
		  __int128 v39; // xmm1
		  __int128 v40; // xmm2
		  __int128 v41; // xmm3
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rsi
		  LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *v44; // rax
		  __int128 v45; // xmm1
		  __int128 v46; // xmm2
		  HGRuntimeGrassQuery_Node *v47; // rdx
		  HGRuntimeGrassQuery_Node *v48; // r8
		  Int32__Array **v49; // r9
		  HGEnvironmentVolumeCameraComponent *v50; // rax
		  HGRuntimeGrassQuery_Node *v51; // rdx
		  HGRuntimeGrassQuery_Node *v52; // r8
		  Int32__Array **v53; // r9
		  Component *SunSourceLight; // rax
		  GameObject *gameObject; // rax
		  HGEnvironmentVolumeCameraComponent *v56; // rax
		  HGEnvironmentPhase *v57; // rdi
		  LensFlareCommonSRP_SunSourceDirLightOverrideLightData *v58; // rax
		  float a; // ecx
		  __int128 v60; // xmm2
		  __int64 v61; // xmm0_8
		  __int128 v62; // xmm1
		  MethodInfo *v63; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v64; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v65; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v66; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v67; // [rsp+28h] [rbp-E0h]
		  Matrix4x4 v68; // [rsp+48h] [rbp-C0h] BYREF
		  Matrix4x4 v69; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v70[2]; // [rsp+C8h] [rbp-40h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3235, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( passData )
		      {
		        passData->fields.lensFlareDataDrivenMaterial = this->fields.m_lensFlareDataDrivenMaterial;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields, v10, v12, v13, v63);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		        passData->fields.lensFlares = UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.lensFlares, v15, v16, v17, v64);
		        passData->fields.camera = camera;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.camera, v18, v19, v20, v65);
		        passData->fields.actualWidth = (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X;
		        *(Vector2Int *)&v68.m00 = hgCamera->fields._sceneRTSize_k__BackingField;
		        v21 = _mm_cvtsi32_si128(LODWORD(v68.m10));
		        passData->fields.usePanini = 0;
		        passData->fields.paniniDistance = 1.0;
		        passData->fields.paniniCropToFit = 1.0;
		        LODWORD(passData->fields.actualHeight) = _mm_cvtepi32_ps(v21).m128_u32[0];
		        if ( camera )
		        {
		          transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		          if ( transform )
		          {
		            position = UnityEngine::Transform::get_position((Vector3 *)&v68, transform, 0LL);
		            z = position->z;
		            *(_QWORD *)&passData->fields.cameraPositionWS.x = *(_QWORD *)&position->x;
		            passData->fields.cameraPositionWS.z = z;
		            worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v68, camera, 0LL);
		            v26 = *(_OWORD *)&worldToCameraMatrix->m01;
		            *(_OWORD *)&v69.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		            v27 = *(_OWORD *)&worldToCameraMatrix->m02;
		            *(_OWORD *)&v69.m01 = v26;
		            v28 = *(_OWORD *)&worldToCameraMatrix->m03;
		            *(_OWORD *)&v69.m02 = v27;
		            *(_OWORD *)&v69.m03 = v28;
		            projectionMatrix = UnityEngine::Camera::get_projectionMatrix(v70, camera, 0LL);
		            v30 = *(_OWORD *)&projectionMatrix->m01;
		            *(_OWORD *)&v68.m00 = *(_OWORD *)&projectionMatrix->m00;
		            v31 = *(_OWORD *)&projectionMatrix->m02;
		            *(_OWORD *)&v68.m01 = v30;
		            v32 = *(_OWORD *)&projectionMatrix->m03;
		            *(_OWORD *)&v68.m02 = v31;
		            *(_OWORD *)&v68.m03 = v32;
		            GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v70, &v68, 1, 0LL);
		            v34 = *(_OWORD *)&GPUProjectionMatrix->m00;
		            v35 = *(_OWORD *)&GPUProjectionMatrix->m01;
		            v36 = *(_OWORD *)&GPUProjectionMatrix->m02;
		            v37 = *(_OWORD *)&GPUProjectionMatrix->m03;
		            *(__m128i *)&v68.m00 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		            UnityEngine::Matrix4x4::SetColumn(&v69, 3, (Vector4 *)&v68, 0LL);
		            v68 = v69;
		            *(_OWORD *)&v69.m00 = v34;
		            *(_OWORD *)&v69.m01 = v35;
		            *(_OWORD *)&v69.m02 = v36;
		            *(_OWORD *)&v69.m03 = v37;
		            v38 = UnityEngine::Matrix4x4::op_Multiply(v70, &v69, &v68, 0LL);
		            v39 = *(_OWORD *)&v38->m01;
		            v40 = *(_OWORD *)&v38->m02;
		            v41 = *(_OWORD *)&v38->m03;
		            *(_OWORD *)&passData->fields.gpuVP.m00 = *(_OWORD *)&v38->m00;
		            *(_OWORD *)&passData->fields.gpuVP.m01 = v39;
		            *(_OWORD *)&passData->fields.gpuVP.m02 = v40;
		            *(_OWORD *)&passData->fields.gpuVP.m03 = v41;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            passData->fields.flareOcclusionTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareOcclusionTex;
		            passData->fields.flareOcclusionIndex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareOcclusionIndex;
		            passData->fields.flareTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareTex;
		            passData->fields.flareColorValue = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareColorValue;
		            passData->fields.flareData0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData0;
		            passData->fields.flareData1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData1;
		            passData->fields.flareData2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData2;
		            passData->fields.flareData3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData3;
		            passData->fields.flareData4 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData4;
		            envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		            if ( envVolumeCameraComponent )
		            {
		              interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                                    envVolumeCameraComponent,
		                                    0LL);
		              if ( interpolatedPhase )
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		                v44 = HG::Rendering::Runtime::HGLensFlareConfig::ToDirLightOverrideData(
		                        (LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *)&v68,
		                        &interpolatedPhase->fields.lensFlareConfig,
		                        0LL);
		                v45 = *(_OWORD *)&v44->intensity;
		                v46 = *(_OWORD *)&v44->sampleCount;
		                *(_OWORD *)&passData->fields.dirLightOverrideInfo.flareData.enable = *(_OWORD *)&v44->enable;
		                *(_OWORD *)&passData->fields.dirLightOverrideInfo.flareData.intensity = v45;
		                *(_OWORD *)&passData->fields.dirLightOverrideInfo.flareData.sampleCount = v46;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&passData->fields.dirLightOverrideInfo.flareData.lensFlareData,
		                  v47,
		                  v48,
		                  v49,
		                  v66);
		                v50 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		                if ( v50 )
		                {
		                  if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_useEnvVolumeInterpolatedPhase(
		                         v50,
		                         0LL)
		                    && (SunSourceLight = (Component *)UnityEngine::Light::GetSunSourceLight(0LL)) != 0LL )
		                  {
		                    gameObject = UnityEngine::Component::get_gameObject(SunSourceLight, 0LL);
		                  }
		                  else
		                  {
		                    gameObject = 0LL;
		                  }
		                  passData->fields.dirLightOverrideInfo.dirLightGameObject = gameObject;
		                  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.dirLightOverrideInfo, v51, v52, v53, v67);
		                  v56 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		                  if ( v56 )
		                  {
		                    v57 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v56, 0LL);
		                    if ( v57 )
		                    {
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		                      v58 = HG::Rendering::Runtime::HGLightConfig::ToDirLightOverrideData(
		                              (LensFlareCommonSRP_SunSourceDirLightOverrideLightData *)&v68,
		                              &v57->fields.lightConfig,
		                              0LL);
		                      a = v58->color.a;
		                      v60 = *(_OWORD *)&v58->dirLightFoward.x;
		                      v61 = *(_QWORD *)&v58->color.g;
		                      passData->fields.dirLightOverrideInfo.lightData.rotationLensFlare = v58->rotationLensFlare;
		                      *(_OWORD *)&passData->fields.dirLightOverrideInfo.lightData.dirLightFoward.x = v60;
		                      *(_QWORD *)&passData->fields.dirLightOverrideInfo.lightData.color.g = v61;
		                      passData->fields.dirLightOverrideInfo.lightData.color.a = a;
		                      passData->fields.debugFullscreen = 0;
		                      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		                      passData->fields.debugFullscreenBuffer = HG::Rendering::RenderGraphModule::ComputeBufferHandle::get_nullHandle(0LL);
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(Patch, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3235, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  v62 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v68.m00 = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v68.m01 = v62;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1189(
		    Patch,
		    (Object *)this,
		    (Object *)passData,
		    (HGRenderGraphBuilder *)&v68,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBAAC4-0x0000000189BBAB18
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        LensFlarePassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3236, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3236, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBAA70-0x0000000189BBAAC4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        LensFlarePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3237, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3237, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBA4B0-0x0000000189BBA79C
		// Void ConstructPass(LensFlarePassConstructor+PassInput ByRef, LensFlarePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::LensFlarePassConstructor::ConstructPass(
		        LensFlarePassConstructor *this,
		        LensFlarePassConstructor_PassInput *input,
		        LensFlarePassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  LensFlareCommonSRP *Instance; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ProfilingSampler *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  LensFlarePassConstructor_LensFlareDataDrivenData *v23; // [rsp+50h] [rbp-88h] BYREF
		  _QWORD v24[3]; // [rsp+58h] [rbp-80h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+70h] [rbp-68h] BYREF
		  HGRenderGraphBuilder v26; // [rsp+90h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v27; // [rsp+B0h] [rbp-28h] BYREF
		  __m128i si128; // [rsp+C0h] [rbp-18h] BYREF
		
		  v23 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3238, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3238, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, v21);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1190(
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
		    *(BitArray128 *)&v25.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		    v25.m_RenderGraph = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v25,
		           FrameSettingsField__Enum_Postprocess,
		           0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      if ( !camera->fields.camera )
		        sub_1800D8260(v13, v12);
		      if ( UnityEngine::Camera::get_cameraType(camera->fields.camera, 0LL) != CameraType__Enum_Preview )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		        Instance = UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL);
		        if ( !Instance )
		          sub_1800D8260(v16, v15);
		        if ( !UnityEngine::Rendering::LensFlareCommonSRP::IsEmpty(Instance, 0LL) )
		        {
		          v17 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                  (Int32Enum__Enum)0x97u,
		                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		          if ( !renderGraph )
		            sub_1800D8260(v19, v18);
		          HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		            &v25,
		            renderGraph,
		            (String *)"LensFlareDataDriven",
		            (Object **)&v23,
		            v17,
		            1,
		            ProfilingHGPass__Enum_None,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
		          v26 = v25;
		          v24[0] = 0LL;
		          v24[1] = &v26;
		          try
		          {
		            v25 = v26;
		            HG::Rendering::Runtime::LensFlarePassConstructor::Prepare(this, v23, &v25, renderGraph, camera, 0LL);
		            si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		              (TextureHandle *)&v25,
		              &v26,
		              &input->sceneColor,
		              0,
		              RenderBufferLoadAction__Enum_Load,
		              RenderBufferStoreAction__Enum_Store,
		              (Color *)&si128,
		              0,
		              0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		              &v26,
		              (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor->static_fields->s_lensFlareDataDrivenRenderFunc,
		              0LL,
		              0,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LensFlarePassConstructor::LensFlareDataDrivenData>);
		          }
		          catch ( Il2CppExceptionWrapper *v27 )
		          {
		            v24[0] = v27->ex;
		          }
		          sub_180268AE0(v24);
		        }
		      }
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBAA1C-0x0000000189BBAA70
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        LensFlarePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3239, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3239, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CD9180-0x0000000184CD91C0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::LensFlarePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        LensFlarePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3240, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3240, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::LensFlarePassConstructor::Release(this, 0LL);
		  }
		}
		
	}
}
