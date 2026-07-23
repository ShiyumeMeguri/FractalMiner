using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSkyRenderer // TypeDefIndex: 37652
	{
		// Fields
		private const float PROCEDURAL_SKY_SCALE = 2000f; // Metadata: 0x02303020
		private readonly Mesh m_IcosphereMesh; // 0x10
		private readonly Vector3[] starQuadPoints; // 0x18
		private static readonly Vector3[] quadWorld; // 0x00
		private static readonly List<Vector3> clippedPoints; // 0x08
		private Material m_renderAtmosphereLutMaterial; // 0x20
		private Material m_proceduralSkyMaterial; // 0x28
		private Material m_skyBoxCubemapMaterial; // 0x30
		private readonly MaterialPropertyBlock m_propertyBlock; // 0x38
		private Material m_skyboxMaterialCPP; // 0x40
		private Material m_skyCloudMaterialCPP; // 0x48
		public const int TALOS_RT_RESOLUTION = 2048; // Metadata: 0x02303024
		public const int PLANET_ALPHA_RT_RESOLUTION = 1024; // Metadata: 0x02303026
		private const float PLANET_RADIUS_TO_ATMOSPHERE_SCALE = 2000f; // Metadata: 0x02303028
		private const float ATMOSPHERE_HEIGHT_INVERT_NUMBER = 30f; // Metadata: 0x0230302C
		private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_PC = 10f; // Metadata: 0x02303030
		private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_PC = 5f; // Metadata: 0x02303034
		private const float ATMOSPHERE_OUTER_SCATTER_SAMPLE_STEP_MOBILE = 5f; // Metadata: 0x02303038
		private const float ATMOSPHERE_INNER_SCATTER_SAMPLE_STEP_MOBILE = 2f; // Metadata: 0x0230303C
	
		// Nested types
		public struct PlanetBillBoardConstants // TypeDefIndex: 37651
		{
			// Fields
			public float _RealPlanetRadius; // 0x00
			public float _AtmosphereRatios; // 0x04
			public float _GlobalRadiusOffset; // 0x08
			public float _Density_Multiplier; // 0x0C
			public float _g; // 0x10
			public float _StepsI; // 0x14
			public float _StepsL; // 0x18
			public float _Mie_Height_Scale; // 0x1C
			public float _Pitch; // 0x20
			public float _Roll; // 0x24
			public float _Phi2; // 0x28
			public float _Theta2; // 0x2C
			public float _Dist; // 0x30
			public float _CapThreshold; // 0x34
			public float _Roughness; // 0x38
			public float _BBRadius; // 0x3C
			public float _Erosion; // 0x40
			public float _ErosionThreshold; // 0x44
			public float _CloudsAlphaMain; // 0x48
			public float _CloudsSpeedMain; // 0x4C
			public float _IndirectIntensity; // 0x50
			public float _DirectLightIntensityBillboard; // 0x54
			public float _Light_Intensity_Multiplier; // 0x58
			public float _Light_Intensity_Clouds_Multiplier; // 0x5C
			public float _PlanetRotateStart; // 0x60
			public float _PlanetRotateSpeed; // 0x64
			public float _CapTransition; // 0x68
			public float _CloudsFlowStrength; // 0x6C
			public float _CloudsHeight; // 0x70
			public float _CloudsFlowSpeed; // 0x74
			public float _Use_Lut; // 0x78
			public float _CustomLightColorPla; // 0x7C
			public float _CustomLightDirection; // 0x80
			public float _UseRoughnessMap; // 0x84
			public float _EnablePolarCap; // 0x88
			public float _UseErosionMap; // 0x8C
			public Vector4 _Ray; // 0x90
			public Vector4 _Mie; // 0xA0
			public Vector4 _Ambient; // 0xB0
			public Vector4 _PlanetWSBase; // 0xC0
			public Vector4 _BBWSBase; // 0xD0
			public Vector4 _PlanetScale; // 0xE0
			public Vector4 _FresnelColor; // 0xF0
			public Vector4 _TintColor; // 0x100
			public Vector4 _SeaDeep; // 0x110
			public Vector4 _SeaShallow; // 0x120
			public Vector4 _IndirectColor; // 0x130
			public Vector4 _CustomLightDir; // 0x140
			public Vector4 _CustomLightColPla; // 0x150
			public Vector4 _CloudsShadowColor; // 0x160
			public Vector4 _BaseColorMap_ST; // 0x170
			public Vector4 _ErosionMap_ST; // 0x180
		}
	
		// Constructors
		public HGSkyRenderer() {} // 0x00000001831D3D40-0x00000001831D3E50
		// HGSkyRenderer()
		void HG::Rendering::Runtime::HGSkyRenderer::HGSkyRenderer(HGSkyRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MaterialPropertyBlock *v8; // rdi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v3 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		  if ( !v3 )
		    goto LABEL_7;
		  if ( !*(_DWORD *)(v3 + 24)
		    || (*(_QWORD *)(v3 + 32) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0],
		        *(_DWORD *)(v3 + 40) = 0,
		        *(_DWORD *)(v3 + 24) <= 1u)
		    || (*(_QWORD *)(v3 + 44) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0],
		        *(_DWORD *)(v3 + 52) = 0,
		        *(_DWORD *)(v3 + 24) <= 2u)
		    || (*(_QWORD *)(v3 + 56) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0xBF800000).m128_u64[0],
		        *(_DWORD *)(v3 + 64) = 0,
		        *(_DWORD *)(v3 + 24) <= 3u) )
		  {
		    sub_1800D2AB0(v5, v4);
		  }
		  *(_QWORD *)(v3 + 68) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  *(_DWORD *)(v3 + 76) = 0;
		  this->fields.starQuadPoints = (Vector3__Array *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.starQuadPoints, v4, v6, v7, v15);
		  v8 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v8 )
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  v8->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_propertyBlock = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_propertyBlock, v9, v10, v11, v16);
		  this->fields.m_IcosphereMesh = HG::Rendering::Runtime::HGEnvironmentUtils::CreateGoldbergPolyhedron(1, 0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v12, v13, v14, v17);
		}
		
		static HGSkyRenderer() {} // 0x0000000184D21400-0x0000000184D214A0
		// HGSkyRenderer()
		void HG::Rendering::Runtime::HGSkyRenderer::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  LowLevelList_1_System_Object_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_UnityEngine_Vector3_ *v8; // rbx
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v12);
		  v5 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
		  v8 = (List_1_UnityEngine_Vector3_ *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v5,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		  TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->clippedPoints = v8;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->clippedPoints,
		    v9,
		    v10,
		    v11,
		    v13);
		}
		
	
		// Methods
		public static float GetSkyDistance(HGCamera camera) => default; // 0x000000018344D4E0-0x000000018344D560
		// Single GetSkyDistance(HGCamera)
		float HG::Rendering::Runtime::HGSkyRenderer::GetSkyDistance(HGCamera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 1440 )
		    goto LABEL_20;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_9;
		  if ( LODWORD(v3->_0.namespaze) <= 0x5A0 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[30]._1.thread_static_fields_offset )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    if ( InterpolatedPhase )
		      return InterpolatedPhase->fields.skyConfig.skyDistance;
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1440, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)camera, 0LL);
		}
		
		public static Vector3 GetSkyScale(HGCamera camera) => default; // 0x000000018344D3D0-0x000000018344D4E0
		// Vector3 GetSkyScale(HGCamera)
		Vector3 *HG::Rendering::Runtime::HGSkyRenderer::GetSkyScale(
		        Vector3 *__return_ptr retstr,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v4; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  float skyDistance; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v11; // rax
		  __int64 v12; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v13; // rax
		  Vector3 v14[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v4 = (Object *)camera;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_17;
		  if ( wrapperArray->max_length.size > 1502 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    camera = (HGCamera *)v5->static_fields->wrapperArray;
		    if ( !camera )
		      goto LABEL_17;
		    if ( camera->fields._taauRTSize_k__BackingField.m_X <= 0x5DEu )
		      goto LABEL_32;
		    if ( *(_QWORD *)&camera[4].fields.mainViewConstants.prevViewMatrix.m21 )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1502, 0LL);
		      if ( Patch )
		      {
		        v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v14, Patch, v4, 0LL);
		        v12 = *(_QWORD *)&v11->x;
		        *(float *)&v11 = v11->z;
		        *(_QWORD *)&retstr->x = v12;
		        LODWORD(retstr->z) = (_DWORD)v11;
		        return retstr;
		      }
		      goto LABEL_17;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  camera = (HGCamera *)v5->static_fields->wrapperArray;
		  if ( !camera )
		    goto LABEL_17;
		  if ( camera->fields._taauRTSize_k__BackingField.m_X <= 1440 )
		    goto LABEL_11;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_17:
		    sub_1800D8260(v5, camera);
		  if ( LODWORD(v5->_0.namespaze) <= 0x5A0 )
		LABEL_32:
		    sub_1800D2AB0(v5, camera);
		  if ( *(_QWORD *)&v5[30]._1.thread_static_fields_offset )
		  {
		    v13 = IFix::WrappersManagerImpl::GetPatch(1440, 0LL);
		    if ( v13 )
		    {
		      skyDistance = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v13, v4, 0LL);
		      goto LABEL_15;
		    }
		    goto LABEL_17;
		  }
		LABEL_11:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase((HGCamera *)v4, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_17;
		  skyDistance = InterpolatedPhase->fields.skyConfig.skyDistance;
		LABEL_15:
		  retstr->x = skyDistance;
		  retstr->y = skyDistance;
		  retstr->z = skyDistance;
		  return retstr;
		}
		
		public static float GetProceduralSkyMeshRadius() => default; // 0x0000000189CE567C-0x0000000189CE56C4
		// Single GetProceduralSkyMeshRadius()
		float HG::Rendering::Runtime::HGSkyRenderer::GetProceduralSkyMeshRadius(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1500, 0LL) )
		    return 2000.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1500, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		
		internal void PrepareMaterials(HGRenderPipelineRuntimeResources defaultResources) {} // 0x00000001848AA000-0x00000001848AA220
		// Void PrepareMaterials(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGSkyRenderer::PrepareMaterials(
		        HGSkyRenderer *this,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Material *m_renderAtmosphereLutMaterial; // rsi
		  struct Object_1__Class *v7; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Shader *renderAtmosphereLutPS; // rsi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Material *m_proceduralSkyMaterial; // rsi
		  HGRenderPipelineRuntimeResources_ShaderResources *v14; // rax
		  Shader *proceduralSkyPS; // rsi
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  Material *m_skyBoxCubemapMaterial; // rsi
		  HGRenderPipelineRuntimeResources_ShaderResources *v20; // rax
		  Shader *skyBoxCubemapPS; // rbx
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1503, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1503, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)defaultResources,
		        0LL);
		      return;
		    }
		    goto LABEL_11;
		  }
		  m_renderAtmosphereLutMaterial = this->fields.m_renderAtmosphereLutMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !m_renderAtmosphereLutMaterial )
		    goto LABEL_47;
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !m_renderAtmosphereLutMaterial->fields._.m_CachedPtr )
		  {
		LABEL_47:
		    if ( !defaultResources )
		      goto LABEL_11;
		    shaders = defaultResources->fields.shaders;
		    if ( !shaders )
		      goto LABEL_11;
		    renderAtmosphereLutPS = shaders->fields.renderAtmosphereLutPS;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_renderAtmosphereLutMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                                   renderAtmosphereLutPS,
		                                                   0,
		                                                   0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderAtmosphereLutMaterial, v10, v11, v12, v26);
		  }
		  m_proceduralSkyMaterial = this->fields.m_proceduralSkyMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !m_proceduralSkyMaterial )
		    goto LABEL_48;
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !m_proceduralSkyMaterial->fields._.m_CachedPtr )
		  {
		LABEL_48:
		    if ( !defaultResources )
		      goto LABEL_11;
		    v14 = defaultResources->fields.shaders;
		    if ( !v14 )
		      goto LABEL_11;
		    proceduralSkyPS = v14->fields.proceduralSkyPS;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_proceduralSkyMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                             proceduralSkyPS,
		                                             0,
		                                             0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_proceduralSkyMaterial, v16, v17, v18, v26);
		  }
		  m_skyBoxCubemapMaterial = this->fields.m_skyBoxCubemapMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !m_skyBoxCubemapMaterial )
		    goto LABEL_49;
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !m_skyBoxCubemapMaterial->fields._.m_CachedPtr )
		  {
		LABEL_49:
		    if ( defaultResources )
		    {
		      v20 = defaultResources->fields.shaders;
		      if ( v20 )
		      {
		        skyBoxCubemapPS = v20->fields.skyBoxCubemapPS;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		        this->fields.m_skyBoxCubemapMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                                 skyBoxCubemapPS,
		                                                 0,
		                                                 0LL);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_skyBoxCubemapMaterial, v22, v23, v24, v26);
		        return;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v7, v5);
		  }
		}
		
		private void SetCloudKeyword(Material mat, HGCloudConfig.CloudFlowType cloudFlowType, HGCamera hgCamera) {} // 0x0000000189CE5D70-0x0000000189CE5F50
		// Void SetCloudKeyword(Material, HGCloudConfig+CloudFlowType, HGCamera)
		void HG::Rendering::Runtime::HGSkyRenderer::SetCloudKeyword(
		        HGSkyRenderer *this,
		        Material *mat,
		        HGCloudConfig_CloudFlowType__Enum cloudFlowType,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  bool v9; // di
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  bool enable; // r14
		  bool v14; // bp
		  int v15; // esi
		  bool v16; // cl
		  bool v17; // r15
		  Object_1 *cloudFlowMap; // rbx
		  bool v19; // cl
		  bool v20; // si
		  String *s_Cloud; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v9 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1504, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1504, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_30(
		        (ILFixDynamicMethodWrapper_9 *)Patch,
		        (Object *)this,
		        (Object *)mat,
		        cloudFlowType,
		        (Object *)hgCamera,
		        0LL);
		      return;
		    }
		LABEL_20:
		    sub_1800D8260(v12, v11);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_20;
		  enable = InterpolatedPhase->fields.cloudConfig.enable;
		  v14 = InterpolatedPhase->fields.cloudConfig.flowSpeed != 0.0;
		  if ( InterpolatedPhase->fields.cloudConfig.flowDirectionX != 0.0
		    || (v15 = 0, InterpolatedPhase->fields.cloudConfig.flowDirectionY != 0.0) )
		  {
		    v15 = 1;
		  }
		  v16 = enable && cloudFlowType == HGCloudConfig_CloudFlowType__Enum_FlowMap;
		  if ( v14 && v16 )
		  {
		    cloudFlowMap = (Object_1 *)InterpolatedPhase->fields.cloudConfig.cloudFlowMap;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    v17 = UnityEngine::Object::op_Inequality(cloudFlowMap, 0LL, 0LL);
		  }
		  else
		  {
		    v17 = 0;
		  }
		  v19 = enable && cloudFlowType == HGCloudConfig_CloudFlowType__Enum_Procedural;
		  v20 = v14 && v15 != 0 && v19;
		  if ( enable && !v17 )
		    v9 = !v20;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		  s_Cloud = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Cloud;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  VLB::Utils::SetKeywordEnabled(mat, s_Cloud, v9, 0LL);
		  VLB::Utils::SetKeywordEnabled(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudFlowMap,
		    v17,
		    0LL);
		  VLB::Utils::SetKeywordEnabled(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudProceduralFlow,
		    v20,
		    0LL);
		}
		
		internal bool ShouldRenderSkybox() => default; // 0x000000018344CEA0-0x000000018344CF00
		// Boolean ShouldRenderSkybox()
		bool HG::Rendering::Runtime::HGSkyRenderer::ShouldRenderSkybox(HGSkyRenderer *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1505 )
		    return 1;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x5E1 )
		    sub_1800D2AB0(v3, method);
		  if ( !*((_QWORD *)&v3[32]._0.byval_arg + 1) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1505, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool ShouldRenderSkyCelestial() => default; // 0x000000018344CF00-0x000000018344CF60
		// Boolean ShouldRenderSkyCelestial()
		bool HG::Rendering::Runtime::HGSkyRenderer::ShouldRenderSkyCelestial(HGSkyRenderer *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1506 )
		    return 1;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x5E2 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[32]._0.this_arg.data.dummy )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1506, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool ShouldRenderSkyCloud(HGEnvironmentPhase phase) => default; // 0x000000018344CE10-0x000000018344CEA0
		// Boolean ShouldRenderSkyCloud(HGEnvironmentPhase)
		bool HG::Rendering::Runtime::HGSkyRenderer::ShouldRenderSkyCloud(
		        HGSkyRenderer *this,
		        HGEnvironmentPhase *phase,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size <= 1507 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_11:
		    sub_1800D8260(v5, wrapperArray);
		  if ( LODWORD(v5->_0.namespaze) <= 0x5E3 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( *((_QWORD *)&v5[32]._0.this_arg + 1) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1507, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		               (ILFixDynamicMethodWrapper_33 *)Patch,
		               (Object *)this,
		               (Object *)phase,
		               0LL);
		    goto LABEL_11;
		  }
		LABEL_5:
		  if ( !phase )
		    goto LABEL_11;
		  return phase->fields.cloudConfig.enable
		      && phase->fields.cloudConfig.drawCloudAfterPlanet
		      && phase->fields.celestialConfig.planetConfig.drawPlanetInSkydome;
		}
		
		public unsafe SkyRendererInput* PrepareCPPInput(HGCamera hgCamera, Shader proceduralSkyPS, Shader skyBoxCubemapPS) => default; // 0x000000018344E5D0-0x000000018344ED70
		// SkyRendererInput* PrepareCPPInput(HGCamera, Shader, Shader)
		SkyRendererInput *HG::Rendering::Runtime::HGSkyRenderer::PrepareCPPInput(
		        HGSkyRenderer *this,
		        HGCamera *hgCamera,
		        Shader *proceduralSkyPS,
		        Shader *skyBoxCubemapPS,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v5)(__int64); // rax
		  __int64 v10; // rbx
		  Camera *camera; // rcx
		  __int64 v12; // rdx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rsi
		  HGAdditionalCameraData *v14; // rax
		  int32_t clearColorMode; // eax
		  SkyRendererInput *result; // rax
		  Mesh *m_IcosphereMesh; // rax
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGEnvironmentPhase *v19; // r14
		  Material *m_skyboxMaterialCPP; // rsi
		  Material *v21; // rax
		  Material *m_skyCloudMaterialCPP; // rsi
		  Material *v23; // rax
		  Camera *v24; // rsi
		  __int64 (__fastcall *v25)(Camera *); // rax
		  __int64 v26; // rsi
		  void (__fastcall *v27)(__int64, MethodInfo **); // rax
		  MethodInfo *v28; // rdx
		  Quaternion v29; // xmm6
		  Vector3 *SkyScale; // rax
		  MethodInfo *v31; // xmm0_8
		  void (__fastcall *v32)(MethodInfo **, Quaternion *, MethodInfo **, __int128 *); // rax
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  Camera *v36; // rsi
		  __int64 (__fastcall *v37)(Camera *); // rax
		  __int64 v38; // rsi
		  void (__fastcall *v39)(__int64, MethodInfo **); // rax
		  int v40; // eax
		  Camera *v41; // rsi
		  __int64 (__fastcall *v42)(Camera *); // rax
		  __int64 v43; // rsi
		  void (__fastcall *v44)(__int64, MethodInfo **); // rax
		  MethodInfo *v45; // rdx
		  Quaternion v46; // xmm6
		  Vector3 *v47; // rax
		  MethodInfo *v48; // xmm0_8
		  void (__fastcall *v49)(MethodInfo **, Quaternion *, MethodInfo **, __int128 *); // rax
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  HGRuntimeGrassQuery_Node *v53; // rdx
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  HGRuntimeGrassQuery_Node *v56; // rdx
		  HGRuntimeGrassQuery_Node *v57; // r8
		  Int32__Array **v58; // r9
		  __int64 v59; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v61; // rax
		  ILFixDynamicMethodWrapper_2 *v62; // rax
		  __int64 v63; // rax
		  __int64 v64; // rax
		  ILFixDynamicMethodWrapper_2 *v65; // rax
		  __int64 v66; // rax
		  ILFixDynamicMethodWrapper_2 *v67; // rax
		  __int64 v68; // rax
		  __int64 v69; // rax
		  MethodInfo *v70; // [rsp+20h] [rbp-81h] BYREF
		  int v71; // [rsp+28h] [rbp-79h]
		  MethodInfo *v72; // [rsp+30h] [rbp-71h] BYREF
		  int v73; // [rsp+38h] [rbp-69h]
		  MethodInfo *v74; // [rsp+40h] [rbp-61h] BYREF
		  int v75; // [rsp+48h] [rbp-59h]
		  Quaternion v76; // [rsp+50h] [rbp-51h] BYREF
		  __int128 v77; // [rsp+60h] [rbp-41h] BYREF
		  __int128 v78; // [rsp+70h] [rbp-31h]
		  __int128 v79; // [rsp+80h] [rbp-21h]
		  __int128 v80; // [rsp+90h] [rbp-11h]
		  Vector3 v81[2]; // [rsp+A8h] [rbp+7h] BYREF
		
		  v5 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v5 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v5 )
		    {
		      v59 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v59, 0LL);
		    }
		    qword_18F370618 = (__int64)v5;
		  }
		  v10 = v5(176LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(int *)(v12 + 24) > 1077 )
		  {
		    if ( !LODWORD(camera[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(camera);
		      camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		    if ( !v12 )
		      goto LABEL_90;
		    if ( *(_DWORD *)(v12 + 24) <= 0x435u )
		      goto LABEL_152;
		    if ( *(_QWORD *)(v12 + 8648) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1077, 0LL);
		      if ( !Patch )
		        goto LABEL_90;
		      if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		              (ILFixDynamicMethodWrapper_20 *)Patch,
		              (Object *)hgCamera,
		              0LL) )
		        goto LABEL_21;
		      goto LABEL_24;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_90;
		  if ( !LODWORD(camera[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(camera);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(int *)(v12 + 24) > 741 )
		  {
		    if ( !LODWORD(camera[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(camera);
		      camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		    if ( !v12 )
		      goto LABEL_90;
		    if ( *(_DWORD *)(v12 + 24) <= 0x2E5u )
		      goto LABEL_152;
		    if ( *(_QWORD *)(v12 + 5960) )
		    {
		      v61 = IFix::WrappersManagerImpl::GetPatch(741, 0LL);
		      if ( !v61 )
		        goto LABEL_90;
		      clearColorMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
		                         (ILFixDynamicMethodWrapper_26 *)v61,
		                         (Object *)hgCamera,
		                         0LL);
		LABEL_20:
		      if ( clearColorMode )
		      {
		LABEL_21:
		        if ( v10 )
		        {
		          *(_BYTE *)v10 = 0;
		          goto LABEL_23;
		        }
		LABEL_90:
		        sub_1800D8260(camera, v12);
		      }
		      goto LABEL_24;
		    }
		  }
		  camera = (Camera *)TypeInfo::UnityEngine::Object;
		  m_AdditionalCameraData = hgCamera->fields.m_AdditionalCameraData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    camera = (Camera *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      camera = (Camera *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_AdditionalCameraData )
		  {
		    if ( !LODWORD(camera[9].monitor) )
		      il2cpp_runtime_class_init_1(camera);
		    if ( m_AdditionalCameraData->fields._._._._.m_CachedPtr )
		    {
		      v14 = hgCamera->fields.m_AdditionalCameraData;
		      if ( !v14 )
		        goto LABEL_90;
		      clearColorMode = v14->fields.clearColorMode;
		      goto LABEL_20;
		    }
		  }
		  camera = hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_90;
		  if ( UnityEngine::Camera::get_clearFlags(camera, 0LL) != CameraClearFlags__Enum_Skybox )
		  {
		    camera = hgCamera->fields.camera;
		    if ( !camera )
		      goto LABEL_90;
		    UnityEngine::Camera::get_clearFlags(camera, 0LL);
		    goto LABEL_21;
		  }
		LABEL_24:
		  if ( !v10 )
		    goto LABEL_90;
		  *(_BYTE *)v10 = 1;
		  m_IcosphereMesh = this->fields.m_IcosphereMesh;
		  if ( !m_IcosphereMesh )
		    goto LABEL_90;
		  *(_QWORD *)(v10 + 168) = m_IcosphereMesh->fields._.m_CachedPtr;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  camera = (Camera *)TypeInfo::UnityEngine::Object;
		  v19 = InterpolatedPhase;
		  m_skyboxMaterialCPP = this->fields.m_skyboxMaterialCPP;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    camera = (Camera *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      camera = (Camera *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_skyboxMaterialCPP )
		    goto LABEL_161;
		  if ( !LODWORD(camera[9].monitor) )
		    il2cpp_runtime_class_init_1(camera);
		  if ( !m_skyboxMaterialCPP->fields._.m_CachedPtr )
		  {
		LABEL_161:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_skyboxMaterialCPP = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                         skyBoxCubemapPS,
		                                         0,
		                                         0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_skyboxMaterialCPP, v53, v54, v55, v70);
		  }
		  v21 = this->fields.m_skyboxMaterialCPP;
		  if ( !v21 )
		    goto LABEL_90;
		  *(_QWORD *)(v10 + 152) = v21->fields._.m_CachedPtr;
		  camera = (Camera *)TypeInfo::UnityEngine::Object;
		  m_skyCloudMaterialCPP = this->fields.m_skyCloudMaterialCPP;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    camera = (Camera *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      camera = (Camera *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_skyCloudMaterialCPP )
		    goto LABEL_162;
		  if ( !LODWORD(camera[9].monitor) )
		    il2cpp_runtime_class_init_1(camera);
		  if ( !m_skyCloudMaterialCPP->fields._.m_CachedPtr )
		  {
		LABEL_162:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    this->fields.m_skyCloudMaterialCPP = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                                           proceduralSkyPS,
		                                           0,
		                                           0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_skyCloudMaterialCPP, v56, v57, v58, v70);
		  }
		  v23 = this->fields.m_skyCloudMaterialCPP;
		  if ( !v23 )
		    goto LABEL_90;
		  *(_QWORD *)(v10 + 160) = v23->fields._.m_CachedPtr;
		  camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(int *)(v12 + 24) <= 1505 )
		    goto LABEL_44;
		  if ( !LODWORD(camera[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(camera);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(_DWORD *)(v12 + 24) <= 0x5E1u )
		    goto LABEL_152;
		  if ( !*(_QWORD *)(v12 + 12072) )
		    goto LABEL_44;
		  v62 = IFix::WrappersManagerImpl::GetPatch(1505, 0LL);
		  if ( !v62 )
		    goto LABEL_90;
		  if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v62, (Object *)this, 0LL) )
		  {
		LABEL_44:
		    *(_BYTE *)(v10 + 1) = 1;
		    if ( !hgCamera )
		      goto LABEL_90;
		    v24 = hgCamera->fields.camera;
		    if ( !v24 )
		      goto LABEL_90;
		    v25 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v25 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		      qword_18F36FBC0 = (__int64)v25;
		    }
		    v26 = v25(v24);
		    if ( !v26 )
		      goto LABEL_90;
		    v70 = 0LL;
		    v71 = 0;
		    v27 = (void (__fastcall *)(__int64, MethodInfo **))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v27 = (void (__fastcall *)(__int64, MethodInfo **))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v27 )
		      {
		        v63 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v63, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v27;
		    }
		    v27(v26, &v70);
		    v29 = *UnityEngine::Quaternion::get_identity(&v76, v28);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		    SkyScale = HG::Rendering::Runtime::HGSkyRenderer::GetSkyScale(v81, hgCamera, 0LL);
		    v76 = v29;
		    v31 = *(MethodInfo **)&SkyScale->x;
		    *(float *)&SkyScale = SkyScale->z;
		    v72 = v31;
		    v73 = (int)SkyScale;
		    v75 = v71;
		    v32 = (void (__fastcall *)(MethodInfo **, Quaternion *, MethodInfo **, __int128 *))qword_18F36FA58;
		    v74 = v70;
		    v77 = 0LL;
		    v78 = 0LL;
		    v79 = 0LL;
		    v80 = 0LL;
		    if ( !qword_18F36FA58 )
		    {
		      v32 = (void (__fastcall *)(MethodInfo **, Quaternion *, MethodInfo **, __int128 *))il2cpp_resolve_icall_1(
		                                                                                           "UnityEngine.Matrix4x4::TRS_In"
		                                                                                           "jected(UnityEngine.Vector3&,U"
		                                                                                           "nityEngine.Quaternion&,UnityE"
		                                                                                           "ngine.Vector3&,UnityEngine.Matrix4x4&)");
		      if ( !v32 )
		      {
		        v64 = sub_1802EE1B8(
		                "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
		                "ityEngine.Matrix4x4&)");
		        sub_18007E1B0(v64, 0LL);
		      }
		      qword_18F36FA58 = (__int64)v32;
		    }
		    v32(&v74, &v76, &v72, &v77);
		    v33 = v78;
		    *(_OWORD *)(v10 + 20) = v77;
		    v34 = v79;
		    *(_OWORD *)(v10 + 36) = v33;
		    v35 = v80;
		    *(_OWORD *)(v10 + 52) = v34;
		    *(_OWORD *)(v10 + 68) = v35;
		  }
		  else
		  {
		    *(_BYTE *)(v10 + 1) = 0;
		  }
		  camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(int *)(v12 + 24) <= 1506 )
		    goto LABEL_58;
		  if ( !LODWORD(camera[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(camera);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(_DWORD *)(v12 + 24) <= 0x5E2u )
		    goto LABEL_152;
		  if ( !*(_QWORD *)(v12 + 12080) )
		    goto LABEL_58;
		  v65 = IFix::WrappersManagerImpl::GetPatch(1506, 0LL);
		  if ( !v65 )
		    goto LABEL_90;
		  if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v65, (Object *)this, 0LL) )
		  {
		LABEL_58:
		    *(_BYTE *)(v10 + 2) = 1;
		    if ( !hgCamera )
		      goto LABEL_90;
		    v36 = hgCamera->fields.camera;
		    if ( !v36 )
		      goto LABEL_90;
		    v37 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v37 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		      qword_18F36FBC0 = (__int64)v37;
		    }
		    v38 = v37(v36);
		    if ( !v38 )
		      goto LABEL_90;
		    v70 = 0LL;
		    v71 = 0;
		    v39 = (void (__fastcall *)(__int64, MethodInfo **))qword_18F3700F0;
		    if ( !qword_18F3700F0 )
		    {
		      v39 = (void (__fastcall *)(__int64, MethodInfo **))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      if ( !v39 )
		      {
		        v66 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v66, 0LL);
		      }
		      qword_18F3700F0 = (__int64)v39;
		    }
		    v39(v38, &v70);
		    v40 = v71;
		    *(_QWORD *)(v10 + 8) = v70;
		    *(_DWORD *)(v10 + 16) = v40;
		  }
		  else
		  {
		    *(_BYTE *)(v10 + 2) = 0;
		  }
		  camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v12 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
		  if ( !v12 )
		    goto LABEL_90;
		  if ( *(int *)(v12 + 24) <= 1507 )
		  {
		LABEL_69:
		    if ( !v19 )
		      goto LABEL_90;
		    if ( v19->fields.cloudConfig.enable
		      && v19->fields.cloudConfig.drawCloudAfterPlanet
		      && v19->fields.celestialConfig.planetConfig.drawPlanetInSkydome )
		    {
		      goto LABEL_73;
		    }
		LABEL_83:
		    *(_BYTE *)(v10 + 3) = 0;
		    goto LABEL_23;
		  }
		  if ( !LODWORD(camera[9].monitor) )
		  {
		    il2cpp_runtime_class_init_1(camera);
		    camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  camera = *(Camera **)camera[7].fields._._._.m_CachedPtr;
		  if ( !camera )
		    goto LABEL_90;
		  if ( LODWORD(camera[1].klass) <= 0x5E3 )
		LABEL_152:
		    sub_1800D2AB0(camera, v12);
		  if ( !camera[503].fields._._._.m_CachedPtr )
		    goto LABEL_69;
		  v67 = IFix::WrappersManagerImpl::GetPatch(1507, 0LL);
		  if ( !v67 )
		    goto LABEL_90;
		  if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		          (ILFixDynamicMethodWrapper_33 *)v67,
		          (Object *)this,
		          (Object *)v19,
		          0LL) )
		    goto LABEL_83;
		LABEL_73:
		  *(_BYTE *)(v10 + 3) = 1;
		  if ( !hgCamera )
		    goto LABEL_90;
		  v41 = hgCamera->fields.camera;
		  if ( !v41 )
		    goto LABEL_90;
		  v42 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v42 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		    qword_18F36FBC0 = (__int64)v42;
		  }
		  v43 = v42(v41);
		  if ( !v43 )
		    goto LABEL_90;
		  v70 = 0LL;
		  v71 = 0;
		  v44 = (void (__fastcall *)(__int64, MethodInfo **))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v44 = (void (__fastcall *)(__int64, MethodInfo **))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v44 )
		    {
		      v68 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v68, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v44;
		  }
		  v44(v43, &v70);
		  v46 = *UnityEngine::Quaternion::get_identity(&v76, v45);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		  v47 = HG::Rendering::Runtime::HGSkyRenderer::GetSkyScale(v81, hgCamera, 0LL);
		  v76 = v46;
		  v48 = *(MethodInfo **)&v47->x;
		  *(float *)&v47 = v47->z;
		  v74 = v48;
		  v75 = (int)v47;
		  v73 = v71;
		  v49 = (void (__fastcall *)(MethodInfo **, Quaternion *, MethodInfo **, __int128 *))qword_18F36FA58;
		  v72 = v70;
		  v77 = 0LL;
		  v78 = 0LL;
		  v79 = 0LL;
		  v80 = 0LL;
		  if ( !qword_18F36FA58 )
		  {
		    v49 = (void (__fastcall *)(MethodInfo **, Quaternion *, MethodInfo **, __int128 *))il2cpp_resolve_icall_1(
		                                                                                         "UnityEngine.Matrix4x4::TRS_Inje"
		                                                                                         "cted(UnityEngine.Vector3&,Unity"
		                                                                                         "Engine.Quaternion&,UnityEngine."
		                                                                                         "Vector3&,UnityEngine.Matrix4x4&)");
		    if ( !v49 )
		    {
		      v69 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v69, 0LL);
		    }
		    qword_18F36FA58 = (__int64)v49;
		  }
		  v49(&v72, &v76, &v74, &v77);
		  v50 = v78;
		  *(_OWORD *)(v10 + 84) = v77;
		  v51 = v79;
		  *(_OWORD *)(v10 + 100) = v50;
		  v52 = v80;
		  *(_OWORD *)(v10 + 116) = v51;
		  *(_OWORD *)(v10 + 132) = v52;
		LABEL_23:
		  result = (SkyRendererInput *)v10;
		  *(_BYTE *)(v10 + 4) = 0;
		  return result;
		}
		
		internal void Render(CommandBuffer cmd, HGCamera hgCamera, ScriptableRenderContext renderContext, bool useFullScreenDebug = false /* Metadata: 0x0230301F */) {} // 0x0000000189CE5C14-0x0000000189CE5D70
		// Void Render(CommandBuffer, HGCamera, ScriptableRenderContext, Boolean)
		void HG::Rendering::Runtime::HGSkyRenderer::Render(
		        HGSkyRenderer *this,
		        CommandBuffer *cmd,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        bool useFullScreenDebug,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGEnvironmentPhase *v13; // rbp
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1508, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1508, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_621(
		        Patch,
		        (Object *)this,
		        (Object *)cmd,
		        (Object *)hgCamera,
		        renderContext,
		        useFullScreenDebug,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(Patch, v11);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  if ( !HG::Rendering::Runtime::HGUtils::IsSkyboxRenderingEnabled(hgCamera, 0LL) )
		    return;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  v13 = InterpolatedPhase;
		  if ( !InterpolatedPhase )
		    goto LABEL_10;
		  HG::Rendering::Runtime::HGSkyRenderer::SetCloudKeyword(
		    this,
		    this->fields.m_proceduralSkyMaterial,
		    (HGCloudConfig_CloudFlowType__Enum)InterpolatedPhase->fields.cloudConfig.cloudFlowType,
		    hgCamera,
		    0LL);
		  if ( HG::Rendering::Runtime::HGSkyRenderer::ShouldRenderSkybox(this, 0LL) )
		  {
		    if ( v13->fields.skyConfig.skyMaterialType )
		    {
		      if ( v13->fields.skyConfig.skyMaterialType == 1 )
		        HG::Rendering::Runtime::HGSkyRenderer::RenderSkybox(
		          this,
		          cmd,
		          this->fields.m_skyBoxCubemapMaterial,
		          hgCamera,
		          useFullScreenDebug,
		          0LL);
		    }
		    else
		    {
		      HG::Rendering::Runtime::HGSkyRenderer::RenderProceduralSky(
		        this,
		        cmd,
		        this->fields.m_proceduralSkyMaterial,
		        hgCamera,
		        renderContext,
		        useFullScreenDebug,
		        0LL);
		    }
		  }
		}
		
		private void RenderProceduralSky(CommandBuffer cmd, Material mat, HGCamera hgCamera, ScriptableRenderContext context, bool useFullScreenDebug) {} // 0x0000000189CE56C4-0x0000000189CE5954
		// Void RenderProceduralSky(CommandBuffer, Material, HGCamera, ScriptableRenderContext, Boolean)
		void HG::Rendering::Runtime::HGSkyRenderer::RenderProceduralSky(
		        HGSkyRenderer *this,
		        CommandBuffer *cmd,
		        Material *mat,
		        HGCamera *hgCamera,
		        ScriptableRenderContext context,
		        bool useFullScreenDebug,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  Component *camera; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v15; // xmm7_8
		  float z; // ebx
		  MethodInfo *v17; // rdx
		  __m128i v18; // xmm6
		  Vector3 *SkyScale; // rax
		  __int64 v20; // xmm0_8
		  Matrix4x4 *v21; // rax
		  __int128 v22; // xmm6
		  __int128 v23; // xmm7
		  __int128 v24; // xmm8
		  __int128 v25; // xmm9
		  MaterialPropertyBlock *m_propertyBlock; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rbx
		  MaterialPropertyBlock *v28; // rax
		  Mesh *m_IcosphereMesh; // rdx
		  Vector3 v30; // [rsp+48h] [rbp-81h] BYREF
		  Vector3 v31; // [rsp+58h] [rbp-71h] BYREF
		  __m128i v32; // [rsp+68h] [rbp-61h] BYREF
		  Matrix4x4 v33[2]; // [rsp+78h] [rbp-51h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1509, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = (Component *)hgCamera->fields.camera;
		      if ( camera )
		      {
		        transform = UnityEngine::Component::get_transform(camera, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position(&v31, transform, 0LL);
		          v15 = *(_QWORD *)&position->x;
		          z = position->z;
		          v18 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity((Quaternion *)&v32, v17));
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		          SkyScale = HG::Rendering::Runtime::HGSkyRenderer::GetSkyScale(&v31, hgCamera, 0LL);
		          v32 = v18;
		          v20 = *(_QWORD *)&SkyScale->x;
		          *(float *)&SkyScale = SkyScale->z;
		          *(_QWORD *)&v30.x = v20;
		          LODWORD(v30.z) = (_DWORD)SkyScale;
		          *(_QWORD *)&v31.x = v15;
		          v31.z = z;
		          v21 = UnityEngine::Matrix4x4::TRS(v33, &v31, (Quaternion *)&v32, &v30, 0LL);
		          camera = (Component *)this->fields.m_propertyBlock;
		          v22 = *(_OWORD *)&v21->m00;
		          v23 = *(_OWORD *)&v21->m01;
		          v24 = *(_OWORD *)&v21->m02;
		          v25 = *(_OWORD *)&v21->m03;
		          if ( camera )
		          {
		            UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)camera, 1, 0LL);
		            m_propertyBlock = this->fields.m_propertyBlock;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		              m_propertyBlock,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyViewLut,
		              (Texture *)hgCamera->fields.atmosphereSkyViewLutTexture,
		              0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		            InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		            HG::Rendering::Runtime::HGSkyRenderer::SetupCloudParam(
		              this,
		              this->fields.m_propertyBlock,
		              InterpolatedPhase,
		              0LL);
		            HG::Rendering::Runtime::HGSkyRenderer::SetProceduralRingMaterial(
		              this,
		              this->fields.m_propertyBlock,
		              InterpolatedPhase,
		              0LL);
		            HG::Rendering::Runtime::HGSkyRenderer::SetupSunDiscParam(
		              this,
		              this->fields.m_propertyBlock,
		              InterpolatedPhase,
		              mat,
		              0LL);
		            HG::Rendering::Runtime::HGSkyRenderer::SetupStarParam(
		              this,
		              this->fields.m_propertyBlock,
		              InterpolatedPhase,
		              mat,
		              0LL);
		            HG::Rendering::Runtime::HGSkyRenderer::SetupPlanets(
		              this,
		              context,
		              hgCamera,
		              this->fields.m_propertyBlock,
		              mat,
		              0LL);
		            v28 = this->fields.m_propertyBlock;
		            if ( cmd )
		            {
		              m_IcosphereMesh = this->fields.m_IcosphereMesh;
		              *(_OWORD *)&v33[0].m00 = v22;
		              *(_OWORD *)&v33[0].m01 = v23;
		              *(_OWORD *)&v33[0].m02 = v24;
		              *(_OWORD *)&v33[0].m03 = v25;
		              UnityEngine::Rendering::CommandBuffer::DrawMesh(cmd, m_IcosphereMesh, v33, mat, 0, 0, v28, 0LL);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(camera, v11);
		  }
		  camera = (Component *)IFix::WrappersManagerImpl::GetPatch(1509, 0LL);
		  if ( !camera )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_619(
		    (ILFixDynamicMethodWrapper_2 *)camera,
		    (Object *)this,
		    (Object *)cmd,
		    (Object *)mat,
		    (Object *)hgCamera,
		    context,
		    useFullScreenDebug,
		    0LL);
		}
		
		private void SetupCloudParamCPP(Material mat, HGEnvironmentPhase envPhase) {} // 0x0000000189CE7C0C-0x0000000189CE7FB0
		// Void SetupCloudParamCPP(Material, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupCloudParamCPP(
		        HGSkyRenderer *this,
		        Material *mat,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  Texture *cloudTexture; // rbx
		  MethodInfo *v10; // r9
		  __m128i v11; // xmm5
		  float proceduralSkyLuxFactor; // xmm7_4
		  float cloudAbsoluteBrightness; // xmm6_4
		  float cloudFadeAlpha; // xmm2_4
		  MethodInfo *v15; // r9
		  MethodInfo *v16; // r9
		  Vector4 *v17; // rax
		  __m128 v18; // xmm5
		  bool v19; // zf
		  __m128 v20; // xmm4
		  unsigned __int32 v21; // xmm4_4
		  MethodInfo *v22; // r8
		  Color *v23; // rax
		  int32_t v24; // r10d
		  MethodInfo *v25; // rdx
		  int v26; // ebx
		  float cloudOpacityG; // xmm1_4
		  __m128i v28; // xmm6
		  float cloudContrast; // xmm1_4
		  int32_t CloudParam; // edx
		  int32_t rotation; // ebx
		  float flowSpeed; // xmm8_4
		  float flowDirectionX; // xmm6_4
		  float flowDirectionY; // xmm7_4
		  int32_t CloudFlowParam; // edx
		  Object_1 *cloudFlowMap; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v38; // [rsp+30h] [rbp-50h] BYREF
		  Vector4 v39[2]; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1520, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1520, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)mat,
		        (Object *)envPhase,
		        0LL);
		      return;
		    }
		    goto LABEL_20;
		  }
		  if ( !envPhase )
		    goto LABEL_20;
		  cloudTexture = envPhase->fields.cloudConfig.cloudTexture;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality((Object_1 *)cloudTexture, 0LL, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    if ( !mat )
		      goto LABEL_20;
		    UnityEngine::Material::SetTextureImpl(mat, static_fields->_CloudTexture, cloudTexture, 0LL);
		  }
		  v11 = _mm_loadu_si128((const __m128i *)&envPhase->fields.cloudConfig.cloudTint);
		  proceduralSkyLuxFactor = 1.0;
		  if ( envPhase->fields.cloudConfig.lightAffectCloud )
		  {
		    cloudAbsoluteBrightness = envPhase->fields.lightConfig.directIntensityDividePi
		                            + envPhase->fields.cloudConfig.cloudBrightness;
		    proceduralSkyLuxFactor = envPhase->fields.skyConfig.proceduralSkyLuxFactor;
		  }
		  else
		  {
		    cloudAbsoluteBrightness = envPhase->fields.cloudConfig.cloudAbsoluteBrightness;
		  }
		  cloudFadeAlpha = envPhase->fields.cloudConfig.cloudFadeAlpha;
		  v38 = v11;
		  v38 = *(__m128i *)UnityEngine::Vector4::op_Multiply(v39, (Vector4 *)&v38, cloudFadeAlpha, v10);
		  v38 = *(__m128i *)UnityEngine::Vector4::op_Multiply(v39, (Vector4 *)&v38, proceduralSkyLuxFactor, v15);
		  v17 = UnityEngine::Vector4::op_Multiply(v39, (Vector4 *)&v38, cloudAbsoluteBrightness, v16);
		  v19 = !envPhase->fields.cloudConfig.brightnessAffectCloudAlpha;
		  v20 = (__m128)_mm_loadu_si128((const __m128i *)v17);
		  v38 = (__m128i)v20;
		  if ( v19 )
		    v21 = _mm_shuffle_ps(v18, v18, 255).m128_u32[0];
		  else
		    v21 = _mm_shuffle_ps(v20, v20, 255).m128_u32[0];
		  v38.m128i_i32[3] = v21;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v23 = UnityEngine::Color::op_Implicit((Color *)v39, (Vector4 *)&v38, v22);
		  if ( !mat )
		LABEL_20:
		    sub_1800D8260(static_fields, v7);
		  v38 = *(__m128i *)v23;
		  UnityEngine::Material::SetVector(mat, v24, (Vector4 *)&v38, 0LL);
		  if ( envPhase->fields.cloudConfig.cloudTextureMode )
		  {
		    v26 = 0;
		    v28 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v39, v25));
		  }
		  else
		  {
		    v26 = 1;
		    cloudOpacityG = envPhase->fields.cloudConfig.cloudOpacityG;
		    v38.m128i_i32[0] = LODWORD(envPhase->fields.cloudConfig.cloudOpacityR);
		    *(float *)&v38.m128i_i32[1] = cloudOpacityG;
		    v38.m128i_i64[1] = 0x3F8000003F800000LL;
		    v28 = v38;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v38 = v28;
		  UnityEngine::Material::SetVector(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudOpacities,
		    (Vector4 *)&v38,
		    0LL);
		  cloudContrast = envPhase->fields.cloudConfig.cloudContrast;
		  v38.m128i_i32[3] = 0;
		  *(__int64 *)((char *)v38.m128i_i64 + 4) = LODWORD(cloudContrast);
		  CloudParam = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudParam;
		  *(float *)v38.m128i_i32 = (float)v26;
		  UnityEngine::Material::SetVector(mat, CloudParam, (Vector4 *)&v38, 0LL);
		  rotation = envPhase->fields.cloudConfig.rotation;
		  flowSpeed = envPhase->fields.cloudConfig.flowSpeed;
		  flowDirectionX = envPhase->fields.cloudConfig.flowDirectionX;
		  flowDirectionY = envPhase->fields.cloudConfig.flowDirectionY;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  *(float *)v38.m128i_i32 = flowDirectionX;
		  *(float *)&v38.m128i_i32[1] = flowDirectionY;
		  *(float *)&v38.m128i_i32[2] = flowSpeed;
		  CloudFlowParam = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudFlowParam;
		  *(float *)&v38.m128i_i32[3] = (float)rotation;
		  UnityEngine::Material::SetVector(mat, CloudFlowParam, (Vector4 *)&v38, 0LL);
		  if ( envPhase->fields.cloudConfig.cloudFlowType == 2 )
		  {
		    cloudFlowMap = (Object_1 *)envPhase->fields.cloudConfig.cloudFlowMap;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(cloudFlowMap, 0LL, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      UnityEngine::Material::SetTextureImpl(
		        mat,
		        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudFlowMap,
		        envPhase->fields.cloudConfig.cloudFlowMap,
		        0LL);
		    }
		  }
		}
		
		private void SetupCloudParam(MaterialPropertyBlock propertyBlock, HGEnvironmentPhase envPhase) {} // 0x0000000189CE7FB0-0x0000000189CE8314
		// Void SetupCloudParam(MaterialPropertyBlock, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupCloudParam(
		        HGSkyRenderer *this,
		        MaterialPropertyBlock *propertyBlock,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int v9; // esi
		  Texture *cloudTexture; // rbx
		  MethodInfo *v11; // r9
		  __m128i v12; // xmm5
		  float proceduralSkyLuxFactor; // xmm7_4
		  float cloudAbsoluteBrightness; // xmm6_4
		  float cloudFadeAlpha; // xmm2_4
		  MethodInfo *v16; // r9
		  MethodInfo *v17; // r9
		  __m128 v18; // xmm4
		  __m128 v19; // xmm5
		  float v20; // xmm4_4
		  MethodInfo *v21; // r8
		  Color *v22; // rax
		  int32_t v23; // r10d
		  MethodInfo *v24; // rdx
		  float cloudOpacityG; // xmm1_4
		  __m128i v26; // xmm6
		  float cloudContrast; // xmm1_4
		  int32_t CloudParam; // edx
		  int32_t rotation; // ebx
		  float flowSpeed; // xmm8_4
		  float flowDirectionX; // xmm6_4
		  float flowDirectionY; // xmm7_4
		  int32_t CloudFlowParam; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v35; // [rsp+30h] [rbp-50h] BYREF
		  Vector4 v36[2]; // [rsp+40h] [rbp-40h] BYREF
		
		  v9 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1510, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1510, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)propertyBlock,
		        (Object *)envPhase,
		        0LL);
		      return;
		    }
		LABEL_16:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !envPhase )
		    goto LABEL_16;
		  cloudTexture = envPhase->fields.cloudConfig.cloudTexture;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		    propertyBlock,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudTexture,
		    cloudTexture,
		    0LL);
		  v12 = _mm_loadu_si128((const __m128i *)&envPhase->fields.cloudConfig.cloudTint);
		  proceduralSkyLuxFactor = 1.0;
		  if ( envPhase->fields.cloudConfig.lightAffectCloud )
		  {
		    cloudAbsoluteBrightness = envPhase->fields.lightConfig.directIntensityDividePi
		                            + envPhase->fields.cloudConfig.cloudBrightness;
		    proceduralSkyLuxFactor = envPhase->fields.skyConfig.proceduralSkyLuxFactor;
		  }
		  else
		  {
		    cloudAbsoluteBrightness = envPhase->fields.cloudConfig.cloudAbsoluteBrightness;
		  }
		  cloudFadeAlpha = envPhase->fields.cloudConfig.cloudFadeAlpha;
		  v35 = v12;
		  v35 = *(__m128i *)UnityEngine::Vector4::op_Multiply(v36, (Vector4 *)&v35, cloudFadeAlpha, v11);
		  v35 = *(__m128i *)UnityEngine::Vector4::op_Multiply(v36, (Vector4 *)&v35, proceduralSkyLuxFactor, v16);
		  v18 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
		                                                   v36,
		                                                   (Vector4 *)&v35,
		                                                   cloudAbsoluteBrightness,
		                                                   v17));
		  v35 = (__m128i)v18;
		  if ( envPhase->fields.cloudConfig.brightnessAffectCloudAlpha )
		    LODWORD(v20) = _mm_shuffle_ps(v18, v18, 255).m128_u32[0];
		  else
		    v20 = _mm_shuffle_ps(v19, v19, 255).m128_f32[0] * envPhase->fields.cloudConfig.cloudFadeAlpha;
		  *(float *)&v35.m128i_i32[3] = v20;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v22 = UnityEngine::Color::op_Implicit((Color *)v36, (Vector4 *)&v35, v21);
		  if ( !propertyBlock )
		    goto LABEL_16;
		  v35 = *(__m128i *)v22;
		  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v23, (Vector4 *)&v35, 0LL);
		  if ( envPhase->fields.cloudConfig.cloudTextureMode )
		  {
		    v26 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(v36, v24));
		  }
		  else
		  {
		    v9 = 1;
		    cloudOpacityG = envPhase->fields.cloudConfig.cloudOpacityG;
		    v35.m128i_i32[0] = LODWORD(envPhase->fields.cloudConfig.cloudOpacityR);
		    *(float *)&v35.m128i_i32[1] = cloudOpacityG;
		    v35.m128i_i64[1] = 0x3F8000003F800000LL;
		    v26 = v35;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v35 = v26;
		  UnityEngine::MaterialPropertyBlock::SetVector(
		    propertyBlock,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudOpacities,
		    (Vector4 *)&v35,
		    0LL);
		  cloudContrast = envPhase->fields.cloudConfig.cloudContrast;
		  v35.m128i_i32[3] = 0;
		  *(__int64 *)((char *)v35.m128i_i64 + 4) = LODWORD(cloudContrast);
		  CloudParam = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudParam;
		  *(float *)v35.m128i_i32 = (float)v9;
		  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, CloudParam, (Vector4 *)&v35, 0LL);
		  rotation = envPhase->fields.cloudConfig.rotation;
		  flowSpeed = envPhase->fields.cloudConfig.flowSpeed;
		  flowDirectionX = envPhase->fields.cloudConfig.flowDirectionX;
		  flowDirectionY = envPhase->fields.cloudConfig.flowDirectionY;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  *(float *)v35.m128i_i32 = flowDirectionX;
		  *(float *)&v35.m128i_i32[1] = flowDirectionY;
		  *(float *)&v35.m128i_i32[2] = flowSpeed;
		  CloudFlowParam = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudFlowParam;
		  *(float *)&v35.m128i_i32[3] = (float)rotation;
		  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, CloudFlowParam, (Vector4 *)&v35, 0LL);
		  if ( envPhase->fields.cloudConfig.cloudFlowType == 2 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		      propertyBlock,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudFlowMap,
		      envPhase->fields.cloudConfig.cloudFlowMap,
		      0LL);
		  }
		}
		
		private void SetupSunDiscParam(MaterialPropertyBlock propertyBlock, HGEnvironmentPhase envPhase, Material mat) {} // 0x0000000189CEA384-0x0000000189CEA628
		// Void SetupSunDiscParam(MaterialPropertyBlock, HGEnvironmentPhase, Material)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupSunDiscParam(
		        HGSkyRenderer *this,
		        MaterialPropertyBlock *propertyBlock,
		        HGEnvironmentPhase *envPhase,
		        Material *mat,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  float sunDiscRampIntensity; // xmm8_4
		  __m128 v12; // xmm7
		  float sunDiscRadius; // xmm6_4
		  float proceduralSkyLuxFactor; // xmm9_4
		  float directIntensityDividePi; // xmm10_4
		  int32_t SunDiscParam0; // ebx
		  Vector4 *v17; // rax
		  int32_t SunDiscParam1; // ebx
		  int32_t SunDiscParam2; // ebx
		  MethodInfo *v20; // rdx
		  Vector3 *fwd; // rax
		  Quaternion rotationSunDisc; // xmm0
		  __int64 v23; // xmm3_8
		  Vector3 *v24; // rax
		  MethodInfo *v25; // r8
		  Vector3 *v26; // rax
		  __int64 v27; // xmm4_8
		  String *SUNDISC_HQ; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v30; // [rsp+38h] [rbp-31h] BYREF
		  Vector4 v31; // [rsp+48h] [rbp-21h] BYREF
		  Quaternion v32[6]; // [rsp+58h] [rbp-11h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1512, 0LL) )
		  {
		    if ( envPhase )
		    {
		      sunDiscRampIntensity = envPhase->fields.skyConfig.sunDiscRampIntensity;
		      v12 = (__m128)_mm_loadu_si128((const __m128i *)&envPhase->fields.skyConfig.sunDiscColor);
		      sunDiscRadius = envPhase->fields.skyConfig.sunDiscRadius;
		      proceduralSkyLuxFactor = envPhase->fields.skyConfig.proceduralSkyLuxFactor;
		      directIntensityDividePi = envPhase->fields.lightConfig.directIntensityDividePi;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      SunDiscParam0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam0;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v17 = HG::Rendering::Runtime::HGUtils::PackVector4(
		              (Vector4 *)v32,
		              v12.m128_f32[0],
		              _mm_shuffle_ps(v12, v12, 85).m128_f32[0],
		              _mm_shuffle_ps(v12, v12, 170).m128_f32[0],
		              sunDiscRadius,
		              0LL);
		      if ( propertyBlock )
		      {
		        v31 = *v17;
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, SunDiscParam0, &v31, 0LL);
		        SunDiscParam1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam1;
		        v31 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 (Vector4 *)v32,
		                 20.0,
		                 sunDiscRampIntensity,
		                 0.0,
		                 directIntensityDividePi,
		                 0LL);
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, SunDiscParam1, &v31, 0LL);
		        SunDiscParam2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam2;
		        fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v31, v20);
		        rotationSunDisc = envPhase->fields.lightConfig.rotationSunDisc;
		        v23 = *(_QWORD *)&fwd->x;
		        *(float *)&fwd = fwd->z;
		        *(_QWORD *)&v30.x = v23;
		        LODWORD(v30.z) = (_DWORD)fwd;
		        v32[0] = rotationSunDisc;
		        v24 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v31, v32, &v30, 0LL);
		        *(_QWORD *)&rotationSunDisc.x = *(_QWORD *)&v24->x;
		        *(float *)&v24 = v24->z;
		        *(_QWORD *)&v30.x = *(_QWORD *)&rotationSunDisc.x;
		        LODWORD(v30.z) = (_DWORD)v24;
		        v26 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v31, &v30, v25);
		        v27 = *(_QWORD *)&v26->x;
		        *(float *)&v26 = v26->z;
		        *(_QWORD *)&v30.x = v27;
		        LODWORD(v30.z) = (_DWORD)v26;
		        v32[0] = *(Quaternion *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                  (Vector4 *)v32,
		                                  &v30,
		                                  proceduralSkyLuxFactor,
		                                  0LL);
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, SunDiscParam2, (Vector4 *)v32, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        LOBYTE(SunDiscParam2) = envPhase->fields.skyConfig.enableSunDisc;
		        SUNDISC_HQ = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->SUNDISC_HQ;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        VLB::Utils::SetKeywordEnabled(mat, SUNDISC_HQ, SunDiscParam2, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1512, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		    (ILFixDynamicMethodWrapper_10 *)Patch,
		    (Object *)this,
		    (Object *)propertyBlock,
		    (Object *)envPhase,
		    (Object *)mat,
		    0LL);
		}
		
		private void SetupSunDiscParamCPP(Material mat, HGEnvironmentPhase envPhase) {} // 0x0000000189CEA0E8-0x0000000189CEA384
		// Void SetupSunDiscParamCPP(Material, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupSunDiscParamCPP(
		        HGSkyRenderer *this,
		        Material *mat,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float sunDiscRampIntensity; // xmm8_4
		  __m128 v10; // xmm7
		  float sunDiscRadius; // xmm6_4
		  float proceduralSkyLuxFactor; // xmm9_4
		  float directIntensityDividePi; // xmm10_4
		  int32_t SunDiscParam0; // ebx
		  Vector4 *v15; // rax
		  int32_t SunDiscParam1; // ebx
		  int32_t SunDiscParam2; // ebx
		  MethodInfo *v18; // rdx
		  Vector3 *fwd; // rax
		  Quaternion rotationSunDisc; // xmm0
		  __int64 v21; // xmm3_8
		  Vector3 *v22; // rax
		  MethodInfo *v23; // r8
		  Vector3 *v24; // rax
		  __int64 v25; // xmm4_8
		  String *SUNDISC_HQ; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v28; // [rsp+38h] [rbp-29h] BYREF
		  Vector4 v29; // [rsp+48h] [rbp-19h] BYREF
		  Quaternion v30[6]; // [rsp+58h] [rbp-9h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1521, 0LL) )
		  {
		    if ( envPhase )
		    {
		      sunDiscRampIntensity = envPhase->fields.skyConfig.sunDiscRampIntensity;
		      v10 = (__m128)_mm_loadu_si128((const __m128i *)&envPhase->fields.skyConfig.sunDiscColor);
		      sunDiscRadius = envPhase->fields.skyConfig.sunDiscRadius;
		      proceduralSkyLuxFactor = envPhase->fields.skyConfig.proceduralSkyLuxFactor;
		      directIntensityDividePi = envPhase->fields.lightConfig.directIntensityDividePi;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      SunDiscParam0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam0;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v15 = HG::Rendering::Runtime::HGUtils::PackVector4(
		              (Vector4 *)v30,
		              v10.m128_f32[0],
		              _mm_shuffle_ps(v10, v10, 85).m128_f32[0],
		              _mm_shuffle_ps(v10, v10, 170).m128_f32[0],
		              sunDiscRadius,
		              0LL);
		      if ( mat )
		      {
		        v29 = *v15;
		        UnityEngine::Material::SetVector(mat, SunDiscParam0, &v29, 0LL);
		        SunDiscParam1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam1;
		        v29 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 (Vector4 *)v30,
		                 20.0,
		                 sunDiscRampIntensity,
		                 0.0,
		                 directIntensityDividePi,
		                 0LL);
		        UnityEngine::Material::SetVector(mat, SunDiscParam1, &v29, 0LL);
		        SunDiscParam2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam2;
		        fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v29, v18);
		        rotationSunDisc = envPhase->fields.lightConfig.rotationSunDisc;
		        v21 = *(_QWORD *)&fwd->x;
		        *(float *)&fwd = fwd->z;
		        *(_QWORD *)&v28.x = v21;
		        LODWORD(v28.z) = (_DWORD)fwd;
		        v30[0] = rotationSunDisc;
		        v22 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v29, v30, &v28, 0LL);
		        *(_QWORD *)&rotationSunDisc.x = *(_QWORD *)&v22->x;
		        *(float *)&v22 = v22->z;
		        *(_QWORD *)&v28.x = *(_QWORD *)&rotationSunDisc.x;
		        LODWORD(v28.z) = (_DWORD)v22;
		        v24 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v29, &v28, v23);
		        v25 = *(_QWORD *)&v24->x;
		        *(float *)&v24 = v24->z;
		        *(_QWORD *)&v28.x = v25;
		        LODWORD(v28.z) = (_DWORD)v24;
		        v30[0] = *(Quaternion *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                  (Vector4 *)v30,
		                                  &v28,
		                                  proceduralSkyLuxFactor,
		                                  0LL);
		        UnityEngine::Material::SetVector(mat, SunDiscParam2, (Vector4 *)v30, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        LOBYTE(SunDiscParam2) = envPhase->fields.skyConfig.enableSunDisc;
		        SUNDISC_HQ = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->SUNDISC_HQ;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        VLB::Utils::SetKeywordEnabled(mat, SUNDISC_HQ, SunDiscParam2, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1521, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)mat,
		    (Object *)envPhase,
		    0LL);
		}
		
		private void SetupStarParamCPP(Material mat, HGEnvironmentPhase envPhase) {} // 0x0000000189CE97DC-0x0000000189CE9C5C
		// Void SetupStarParamCPP(Material, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupStarParamCPP(
		        HGSkyRenderer *this,
		        Material *mat,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  bool enableStars; // bl
		  String *HG_SKYBOX_STAR; // rdi
		  float starsDensity; // xmm7_4
		  float starsExposure; // xmm9_4
		  float starsTilling; // xmm8_4
		  float starsFlickerSpeed; // xmm6_4
		  int32_t SkyBoxStarParam0; // ebx
		  Vector4 *v16; // rax
		  float thresholdSoftness; // xmm2_4
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  int32_t SkyBoxStarParam1; // ebx
		  float starDensityMapMaskThres; // xmm2_4
		  HGShaderIDs__StaticFields *v21; // rcx
		  int32_t SkyBoxStarParam2; // ebx
		  int32_t SkyBoxStarParam3; // ebx
		  int32_t SkyBoxStarParam4; // ebx
		  int32_t SkyBoxStarParam5; // ebx
		  float starRingStarCoverage; // xmm2_4
		  int32_t SkyBoxStarParam6; // ebx
		  Object_1 *skyBoxStarRangeMap; // rbx
		  int32_t SkyBoxStarDensityTexture; // edi
		  Texture *blackTexture; // rax
		  Object_1 *nebulaMap; // rbx
		  int32_t SkyBoxNebulaTexture; // edi
		  Texture *v33; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 starsTint; // [rsp+38h] [rbp-9h] BYREF
		  Vector4 v36[2]; // [rsp+48h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1522, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1522, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)mat,
		        (Object *)envPhase,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !envPhase )
		    goto LABEL_12;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		  enableStars = envPhase->fields.starConfig.enableStars;
		  HG_SKYBOX_STAR = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_STAR;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  VLB::Utils::SetKeywordEnabled(mat, HG_SKYBOX_STAR, enableStars, 0LL);
		  VLB::Utils::SetKeywordEnabled(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_NEBULA,
		    envPhase->fields.starConfig.enableNebula,
		    0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  starsDensity = envPhase->fields.starConfig.starsDensity;
		  starsExposure = envPhase->fields.starConfig.starsExposure;
		  starsTilling = envPhase->fields.starConfig.starsTilling;
		  starsFlickerSpeed = envPhase->fields.starConfig.starsFlickerSpeed;
		  SkyBoxStarParam0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v16 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          &starsTint,
		          1.0 - starsDensity,
		          starsExposure,
		          starsTilling,
		          starsFlickerSpeed,
		          0LL);
		  if ( !mat )
		    goto LABEL_12;
		  starsTint = *v16;
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam0, &starsTint, 0LL);
		  thresholdSoftness = envPhase->fields.starConfig.thresholdSoftness;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  starsTint = (Vector4)envPhase->fields.starConfig.starsTint;
		  SkyBoxStarParam1 = static_fields->_SkyBoxStarParam1;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(v36, (Color *)&starsTint, thresholdSoftness, 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam1, &starsTint, 0LL);
		  starDensityMapMaskThres = envPhase->fields.starConfig.starDensityMapMaskThres;
		  v21 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  starsTint = (Vector4)envPhase->fields.starConfig.starsTint1;
		  SkyBoxStarParam2 = v21->_SkyBoxStarParam2;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(v36, (Color *)&starsTint, starDensityMapMaskThres, 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam2, &starsTint, 0LL);
		  SkyBoxStarParam3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam3;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 v36,
		                 envPhase->fields.starConfig.minMaxRange.x,
		                 envPhase->fields.starConfig.minMaxRange.y,
		                 envPhase->fields.starConfig.cloudRingStarCoverage,
		                 envPhase->fields.starConfig.skyBoxStarDensityMapRotation,
		                 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam3, &starsTint, 0LL);
		  SkyBoxStarParam4 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam4;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 v36,
		                 envPhase->fields.starConfig.brightnessRandomSeed,
		                 (float)envPhase->fields.starConfig.debugMode,
		                 envPhase->fields.starConfig.nebulaMapRotation,
		                 envPhase->fields.starConfig.nebulaStarConverage,
		                 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam4, &starsTint, 0LL);
		  SkyBoxStarParam5 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam5;
		  starRingStarCoverage = envPhase->fields.starConfig.starRingStarCoverage;
		  starsTint = (Vector4)envPhase->fields.starConfig.nebulaTint;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(v36, (Color *)&starsTint, starRingStarCoverage, 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam5, &starsTint, 0LL);
		  SkyBoxStarParam6 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam6;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 v36,
		                 envPhase->fields.starConfig.colorRandomSeed,
		                 envPhase->fields.starConfig.distributionRandomSeed,
		                 0.0,
		                 0.0,
		                 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam6, &starsTint, 0LL);
		  skyBoxStarRangeMap = (Object_1 *)envPhase->fields.starConfig.skyBoxStarRangeMap;
		  SkyBoxStarDensityTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarDensityTexture;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit(skyBoxStarRangeMap, 0LL) )
		    blackTexture = envPhase->fields.starConfig.skyBoxStarRangeMap;
		  else
		    blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  UnityEngine::Material::SetTextureImpl(mat, SkyBoxStarDensityTexture, blackTexture, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  nebulaMap = (Object_1 *)envPhase->fields.starConfig.nebulaMap;
		  SkyBoxNebulaTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxNebulaTexture;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit(nebulaMap, 0LL) )
		    v33 = envPhase->fields.starConfig.nebulaMap;
		  else
		    v33 = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  UnityEngine::Material::SetTextureImpl(mat, SkyBoxNebulaTexture, v33, 0LL);
		}
		
		private void SetupStarParam(MaterialPropertyBlock propertyBlock, HGEnvironmentPhase envPhase, Material mat) {} // 0x0000000189CE9C5C-0x0000000189CEA0E8
		// Void SetupStarParam(MaterialPropertyBlock, HGEnvironmentPhase, Material)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupStarParam(
		        HGSkyRenderer *this,
		        MaterialPropertyBlock *propertyBlock,
		        HGEnvironmentPhase *envPhase,
		        Material *mat,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  bool enableStars; // bl
		  String *HG_SKYBOX_STAR; // rdi
		  float starsDensity; // xmm7_4
		  float starsExposure; // xmm9_4
		  float starsTilling; // xmm8_4
		  float starsFlickerSpeed; // xmm6_4
		  int32_t SkyBoxStarParam0; // ebx
		  Vector4 *v18; // rax
		  float thresholdSoftness; // xmm2_4
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  int32_t SkyBoxStarParam1; // ebx
		  float starDensityMapMaskThres; // xmm2_4
		  HGShaderIDs__StaticFields *v23; // rcx
		  int32_t SkyBoxStarParam2; // ebx
		  int32_t SkyBoxStarParam3; // ebx
		  int32_t SkyBoxStarParam4; // ebx
		  int32_t SkyBoxStarParam5; // ebx
		  float starRingStarCoverage; // xmm2_4
		  int32_t SkyBoxStarParam6; // ebx
		  Object_1 *skyBoxStarRangeMap; // rbx
		  int32_t SkyBoxStarDensityTexture; // edi
		  Texture *blackTexture; // rax
		  Object_1 *nebulaMap; // rbx
		  int32_t SkyBoxNebulaTexture; // edi
		  Texture *v35; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 starsTint; // [rsp+38h] [rbp-11h] BYREF
		  Vector4 v38[2]; // [rsp+48h] [rbp-1h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1513, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1513, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		        (ILFixDynamicMethodWrapper_10 *)Patch,
		        (Object *)this,
		        (Object *)propertyBlock,
		        (Object *)envPhase,
		        (Object *)mat,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v10, v9);
		  }
		  if ( !envPhase )
		    goto LABEL_12;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		  enableStars = envPhase->fields.starConfig.enableStars;
		  HG_SKYBOX_STAR = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_STAR;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  VLB::Utils::SetKeywordEnabled(mat, HG_SKYBOX_STAR, enableStars, 0LL);
		  VLB::Utils::SetKeywordEnabled(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_NEBULA,
		    envPhase->fields.starConfig.enableNebula,
		    0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  starsDensity = envPhase->fields.starConfig.starsDensity;
		  starsExposure = envPhase->fields.starConfig.starsExposure;
		  starsTilling = envPhase->fields.starConfig.starsTilling;
		  starsFlickerSpeed = envPhase->fields.starConfig.starsFlickerSpeed;
		  SkyBoxStarParam0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v18 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          &starsTint,
		          1.0 - starsDensity,
		          starsExposure,
		          starsTilling,
		          starsFlickerSpeed,
		          0LL);
		  if ( !mat )
		    goto LABEL_12;
		  starsTint = *v18;
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam0, &starsTint, 0LL);
		  thresholdSoftness = envPhase->fields.starConfig.thresholdSoftness;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  starsTint = (Vector4)envPhase->fields.starConfig.starsTint;
		  SkyBoxStarParam1 = static_fields->_SkyBoxStarParam1;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(v38, (Color *)&starsTint, thresholdSoftness, 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam1, &starsTint, 0LL);
		  starDensityMapMaskThres = envPhase->fields.starConfig.starDensityMapMaskThres;
		  v23 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  starsTint = (Vector4)envPhase->fields.starConfig.starsTint1;
		  SkyBoxStarParam2 = v23->_SkyBoxStarParam2;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(v38, (Color *)&starsTint, starDensityMapMaskThres, 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam2, &starsTint, 0LL);
		  SkyBoxStarParam3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam3;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 v38,
		                 envPhase->fields.starConfig.minMaxRange.x,
		                 envPhase->fields.starConfig.minMaxRange.y,
		                 envPhase->fields.starConfig.cloudRingStarCoverage,
		                 envPhase->fields.starConfig.skyBoxStarDensityMapRotation,
		                 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam3, &starsTint, 0LL);
		  SkyBoxStarParam4 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam4;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 v38,
		                 envPhase->fields.starConfig.brightnessRandomSeed,
		                 (float)envPhase->fields.starConfig.debugMode,
		                 envPhase->fields.starConfig.nebulaMapRotation,
		                 envPhase->fields.starConfig.nebulaStarConverage,
		                 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam4, &starsTint, 0LL);
		  SkyBoxStarParam5 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam5;
		  starRingStarCoverage = envPhase->fields.starConfig.starRingStarCoverage;
		  starsTint = (Vector4)envPhase->fields.starConfig.nebulaTint;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(v38, (Color *)&starsTint, starRingStarCoverage, 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam5, &starsTint, 0LL);
		  SkyBoxStarParam6 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam6;
		  starsTint = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                 v38,
		                 envPhase->fields.starConfig.colorRandomSeed,
		                 envPhase->fields.starConfig.distributionRandomSeed,
		                 0.0,
		                 0.0,
		                 0LL);
		  UnityEngine::Material::SetVector(mat, SkyBoxStarParam6, &starsTint, 0LL);
		  skyBoxStarRangeMap = (Object_1 *)envPhase->fields.starConfig.skyBoxStarRangeMap;
		  SkyBoxStarDensityTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarDensityTexture;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit(skyBoxStarRangeMap, 0LL) )
		    blackTexture = envPhase->fields.starConfig.skyBoxStarRangeMap;
		  else
		    blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  UnityEngine::Material::SetTextureImpl(mat, SkyBoxStarDensityTexture, blackTexture, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  nebulaMap = (Object_1 *)envPhase->fields.starConfig.nebulaMap;
		  SkyBoxNebulaTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxNebulaTexture;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit(nebulaMap, 0LL) )
		    v35 = envPhase->fields.starConfig.nebulaMap;
		  else
		    v35 = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  UnityEngine::Material::SetTextureImpl(mat, SkyBoxNebulaTexture, v35, 0LL);
		}
		
		private void SetupPlanets(ScriptableRenderContext context, HGCamera hgCamera, MaterialPropertyBlock propertyBlock, Material mat) {} // 0x0000000189CE9228-0x0000000189CE9404
		// Void SetupPlanets(ScriptableRenderContext, HGCamera, MaterialPropertyBlock, Material)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupPlanets(
		        HGSkyRenderer *this,
		        ScriptableRenderContext context,
		        HGCamera *hgCamera,
		        MaterialPropertyBlock *propertyBlock,
		        Material *mat,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v12; // rax
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGCelestialConfig *moon; // rsi
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1514, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1514, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_618(
		        Patch,
		        (Object *)this,
		        context,
		        (Object *)hgCamera,
		        (Object *)propertyBlock,
		        (Object *)mat,
		        0LL);
		      return;
		    }
		    goto LABEL_16;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  v12 = *(_QWORD *)&Patch[33].fields.methodId;
		  if ( !v12 )
		    goto LABEL_16;
		  if ( !*(_DWORD *)(v12 + 24) )
		    goto LABEL_14;
		  if ( !mat )
		    goto LABEL_16;
		  UnityEngine::Material::SetFloatImpl(mat, *(_DWORD *)(v12 + 32), 0.0, 0LL);
		  Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  v10 = *(_QWORD *)&Patch[33].fields.methodId;
		  if ( !v10 )
		    goto LABEL_16;
		  if ( *(_DWORD *)(v10 + 24) <= 1u )
		LABEL_14:
		    sub_1800D2AB0(Patch, v10);
		  UnityEngine::Material::SetFloatImpl(mat, *(_DWORD *)(v10 + 36), 0.0, 0LL);
		  if ( !HG::Rendering::Runtime::HGSkyRenderer::ShouldRenderSkyCelestial(this, 0LL) )
		    return;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		LABEL_16:
		    sub_1800D8260(Patch, v10);
		  moon = &InterpolatedPhase->fields.celestialConfig;
		  if ( InterpolatedPhase->fields.celestialConfig.planetConfig.drawPlanetInSkydome )
		    HG::Rendering::Runtime::HGSkyRenderer::SetupPlanet(
		      this,
		      hgCamera,
		      mat,
		      &InterpolatedPhase->fields.celestialConfig.planetConfig,
		      &InterpolatedPhase->fields.celestialConfig.moonConfig,
		      0,
		      0LL);
		  if ( moon->talosAlphaConfig.drawPlanetInSkydome )
		    HG::Rendering::Runtime::HGSkyRenderer::SetupPlanet(
		      this,
		      hgCamera,
		      mat,
		      &moon->talosAlphaConfig,
		      &moon->moonConfig,
		      1,
		      0LL);
		  HG::Rendering::Runtime::HGSkyRenderer::SetupAdvancedPlanet(this, propertyBlock, context, hgCamera, mat, 0LL);
		}
		
		private void SetupPlanet(HGCamera hgCamera, Material mat, ref HGCelestialConfig.HGCelestialAtmosphereObjectConfig planet, ref HGCelestialConfig.HGCelestialObjectConfig moon, int i) {} // 0x0000000189CE8314-0x0000000189CE9228
		// Void SetupPlanet(HGCamera, Material, HGCelestialConfig+HGCelestialAtmosphereObjectConfig ByRef, HGCelestialConfig+HGCelestialObjectConfig ByRef, Int32)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupPlanet(
		        HGSkyRenderer *this,
		        HGCamera *hgCamera,
		        Material *mat,
		        HGCelestialConfig_HGCelestialAtmosphereObjectConfig *planet,
		        HGCelestialConfig_HGCelestialObjectConfig *moon,
		        int32_t i,
		        MethodInfo *method)
		{
		  Int32__Array *PlanetBaseMap01; // rdx
		  void *static_fields; // rcx
		  Quaternion v13; // xmm8
		  Component *camera; // rdi
		  Object_1 *v15; // r12
		  __m128i v16; // xmm10
		  MethodInfo *v17; // rdx
		  Vector3 *fwd; // rax
		  __int64 v19; // xmm3_8
		  Vector3 *v20; // rax
		  __int64 v21; // xmm9_8
		  MethodInfo *v22; // rax
		  Vector3 *v23; // rax
		  Quaternion *v24; // rdx
		  Quaternion v25; // xmm0
		  __int64 v26; // xmm3_8
		  Vector3 *v27; // rax
		  MethodInfo *v28; // r9
		  float ProceduralSkyMeshRadius; // xmm7_4
		  float outerRadius; // xmm12_4
		  float radius; // xmm6_4
		  Vector3 *v32; // rax
		  __int64 v33; // xmm15_8
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float v36; // xmm1_4
		  __int64 v37; // xmm8_8
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  float v40; // xmm0_4
		  float v41; // edi
		  MethodInfo *v42; // rdx
		  Vector3 *one; // rax
		  __int64 v44; // xmm1_8
		  MethodInfo *v45; // r9
		  Vector3 *v46; // rax
		  __int64 v47; // xmm3_8
		  MethodInfo *v48; // r9
		  float v49; // xmm4_4
		  Vector3 *v50; // rax
		  __int64 v51; // xmm3_8
		  MethodInfo *v52; // r9
		  Vector3 *v53; // rax
		  __int64 v54; // xmm3_8
		  Matrix4x4 *v55; // rax
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  float width; // xmm7_4
		  float v60; // xmm9_4
		  float v61; // xmm10_4
		  Vector4 *v62; // rax
		  __m128i v63; // xmm10
		  MethodInfo *v64; // r9
		  Vector3 *v65; // rax
		  __int64 v66; // xmm3_8
		  __m128i v67; // xmm9
		  Animator *v68; // rdx
		  int32_t v69; // r8d
		  MethodInfo *v70; // r9
		  Vector3 *Vector; // rax
		  __int64 v72; // xmm1_8
		  Animator *v73; // rdx
		  int32_t v74; // r8d
		  MethodInfo *v75; // r9
		  Vector3 *v76; // rax
		  __int64 v77; // xmm1_8
		  Animator *v78; // rdx
		  int32_t v79; // r8d
		  MethodInfo *v80; // r9
		  Vector3 *v81; // rax
		  __m128 selfTiltX_low; // xmm6
		  __m128 selfRotationY_low; // xmm7
		  __int64 v84; // xmm1_8
		  float selfTiltZ; // xmm8_4
		  __m128i v86; // xmm6
		  Vector4 *v87; // rax
		  __m128i v88; // xmm7
		  Vector4 *v89; // rax
		  __m128i v90; // xmm8
		  Vector4 *v91; // rax
		  __m128i v92; // xmm12
		  __m128i v93; // xmm15
		  __int64 v94; // rdi
		  String *v95; // rdi
		  bool enableRing; // bl
		  __int64 v97; // rax
		  int32_t v98; // edx
		  int32_t v99; // edx
		  int32_t v100; // edx
		  int32_t v101; // edx
		  int32_t v102; // edx
		  int32_t v103; // edx
		  int32_t v104; // edx
		  int32_t v105; // ebx
		  float Float; // xmm0_4
		  __int64 v107; // rbx
		  int32_t v108; // ebx
		  __int64 v109; // rbx
		  int32_t v110; // ebx
		  float v111; // xmm0_4
		  __int64 v112; // rbx
		  int32_t v113; // ebx
		  __int64 v114; // rbx
		  int32_t v115; // ebx
		  float v116; // xmm0_4
		  __int64 v117; // rbx
		  int32_t v118; // ebx
		  float v119; // xmm0_4
		  Texture *Texture; // rbx
		  Object_1 *blackTexture; // rbx
		  int32_t v122; // edi
		  int32_t v123; // edx
		  Texture *v124; // rbx
		  float numInscatteredSamplePoints; // xmm8_4
		  float numOpticalDepthSamplePoints; // xmm9_4
		  float atmosphereHeight; // xmm7_4
		  float coff_R; // xmm6_4
		  Vector4 *v129; // rax
		  float v130; // xmm2_4
		  __m128i v131; // xmm8
		  Vector4 *v132; // rax
		  bool enableAtmosphere; // bl
		  __m128i v134; // xmm9
		  float bakeFaceVisibility; // xmm7_4
		  float drawPlanetBelowHorizon; // xmm6_4
		  __m128i v137; // xmm6
		  int32_t v138; // edx
		  int32_t v139; // edx
		  int32_t v140; // edx
		  Vector3 v141; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v142; // [rsp+58h] [rbp-B0h] BYREF
		  Quaternion v143[2]; // [rsp+68h] [rbp-A0h] BYREF
		  float v144; // [rsp+88h] [rbp-80h]
		  float v145; // [rsp+8Ch] [rbp-7Ch]
		  __m128i v146; // [rsp+98h] [rbp-70h] BYREF
		  Vector3 v147; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v148; // [rsp+B8h] [rbp-50h] BYREF
		  float z; // [rsp+C8h] [rbp-40h]
		  float v150; // [rsp+CCh] [rbp-3Ch]
		  float v151; // [rsp+D0h] [rbp-38h]
		  __int64 v152; // [rsp+D8h] [rbp-30h]
		  __int64 v153; // [rsp+E0h] [rbp-28h]
		  Matrix4x4 v154; // [rsp+E8h] [rbp-20h] BYREF
		  Matrix4x4 v155[3]; // [rsp+128h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1515, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      v13 = *(Quaternion *)&planet->skydomeDrawer.pitchYaw.x;
		      camera = (Component *)hgCamera->fields.camera;
		      v143[0] = *(Quaternion *)&planet->skydomeDrawer.drawMode;
		      v143[1] = v13;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      v15 = (Object_1 *)_mm_srli_si128((__m128i)v143[0], 8).m128i_u64[0];
		      if ( UnityEngine::Object::op_Equality(v15, 0LL, 0LL) )
		        return;
		      v16 = _mm_loadu_si128((const __m128i *)sub_182FA5990(v143));
		      fwd = UnityEngine::Vector3::get_fwd(&v141, v17);
		      v146 = v16;
		      v19 = *(_QWORD *)&fwd->x;
		      v142.z = fwd->z;
		      *(_QWORD *)&v142.x = v19;
		      v20 = UnityEngine::Quaternion::op_Multiply(&v141, (Quaternion *)&v146, &v142, 0LL);
		      v21 = *(_QWORD *)&v20->x;
		      *(float *)&v20 = v20->z;
		      v152 = v21;
		      v145 = *(float *)&v20;
		      v22 = (MethodInfo *)sub_182FA5990(v143);
		      v23 = UnityEngine::Vector3::get_fwd(&v141, v22);
		      v25 = *v24;
		      v26 = *(_QWORD *)&v23->x;
		      v142.z = v23->z;
		      *(_QWORD *)&v142.x = v26;
		      v146 = (__m128i)v25;
		      v27 = UnityEngine::Quaternion::op_Multiply(&v141, (Quaternion *)&v146, &v142, 0LL);
		      *(_QWORD *)&v25.x = *(_QWORD *)&v27->x;
		      *(float *)&v27 = v27->z;
		      v153 = *(_QWORD *)&v25.x;
		      v150 = *(float *)&v27;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		      ProceduralSkyMeshRadius = HG::Rendering::Runtime::HGSkyRenderer::GetProceduralSkyMeshRadius(0LL);
		      outerRadius = planet->ring.outerRadius;
		      if ( (float)((float)(moon->orbitRadius - moon->radius) - 10.0) <= outerRadius )
		        outerRadius = (float)(moon->orbitRadius - moon->radius) - 10.0;
		      if ( planet->enableRing )
		        radius = outerRadius;
		      else
		        radius = planet->objectProperty.radius;
		      if ( (float)((float)((float)((float)(moon->orbitRadius / 5000.0) * planet->atmosphere.atmosphereHeight)
		                         * (float)((float)(planet->atmosphere.heightScale_R / 15.0) + 1.0))
		                 + planet->objectProperty.radius) > radius )
		        radius = (float)((float)((float)(moon->orbitRadius / 5000.0) * planet->atmosphere.atmosphereHeight)
		                       * (float)((float)(planet->atmosphere.heightScale_R / 15.0) + 1.0))
		               + planet->objectProperty.radius;
		      v142.z = v145;
		      *(_QWORD *)&v142.x = v21;
		      v32 = UnityEngine::Vector3::op_Multiply(&v141, &v142, ProceduralSkyMeshRadius, v28);
		      v33 = *(_QWORD *)&v32->x;
		      z = v32->z;
		      if ( camera )
		      {
		        transform = UnityEngine::Component::get_transform(camera, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position(&v141, transform, 0LL);
		          v36 = moon->orbitRadius - moon->radius;
		          v37 = *(_QWORD *)&position->x;
		          *(float *)&position = position->z;
		          *(_QWORD *)&v148.x = v37;
		          v144 = *(float *)&position;
		          HG::Rendering::Runtime::HGEnvironmentUtils::SkydomeStarHalfFovCos(radius, v36, 0LL);
		          v40 = sub_1803386C0(v39, v38);
		          v41 = z;
		          v151 = v40;
		          *(_QWORD *)&v147.x = v33;
		          v147.z = z;
		          *(_QWORD *)&v141.x = v37;
		          v141.z = v144;
		          one = UnityEngine::Vector3::get_one((Vector3 *)&v146, v42);
		          v44 = *(_QWORD *)&one->x;
		          *(float *)&one = one->z;
		          *(_QWORD *)&v142.x = v44;
		          LODWORD(v142.z) = (_DWORD)one;
		          v46 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v146, &v142, ProceduralSkyMeshRadius, v45);
		          v47 = *(_QWORD *)&v46->x;
		          *(float *)&v46 = v46->z;
		          *(_QWORD *)&v142.x = v47;
		          LODWORD(v142.z) = (_DWORD)v46;
		          v50 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v146, &v142, v49, v48);
		          v143[0] = (Quaternion)v16;
		          v51 = *(_QWORD *)&v50->x;
		          *(float *)&v50 = v50->z;
		          *(_QWORD *)&v142.x = v51;
		          LODWORD(v142.z) = (_DWORD)v50;
		          v53 = UnityEngine::Vector3::op_Addition((Vector3 *)&v146, &v141, &v147, v52);
		          v54 = *(_QWORD *)&v53->x;
		          *(float *)&v53 = v53->z;
		          *(_QWORD *)&v141.x = v54;
		          LODWORD(v141.z) = (_DWORD)v53;
		          v55 = UnityEngine::Matrix4x4::TRS(v155, &v141, v143, &v142, 0LL);
		          v56 = *(_OWORD *)&v55->m01;
		          *(_OWORD *)&v154.m00 = *(_OWORD *)&v55->m00;
		          v57 = *(_OWORD *)&v55->m02;
		          *(_OWORD *)&v154.m01 = v56;
		          v58 = *(_OWORD *)&v55->m03;
		          *(_OWORD *)&v154.m02 = v57;
		          *(_OWORD *)&v154.m03 = v58;
		          if ( !HG::Rendering::Runtime::HGSkyRenderer::CheckPlanetVisibility(this, hgCamera, &v154, 0LL) )
		            return;
		          width = planet->ring.width;
		          v60 = moon->orbitRadius - moon->radius;
		          v61 = planet->objectProperty.radius;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          v62 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                  (Vector4 *)v143,
		                  v61 / v60,
		                  v60 / outerRadius,
		                  v60 / width,
		                  (float)(width - outerRadius) / width,
		                  0LL);
		          *(_QWORD *)&v141.x = v33;
		          v141.z = v41;
		          v63 = _mm_loadu_si128((const __m128i *)v62);
		          v142.z = v144;
		          *(_QWORD *)&v142.x = *(_QWORD *)&v148.x;
		          v65 = UnityEngine::Vector3::op_Addition((Vector3 *)&v146, &v142, &v141, v64);
		          v66 = *(_QWORD *)&v65->x;
		          *(float *)&v65 = v65->z;
		          *(_QWORD *)&v141.x = v66;
		          LODWORD(v141.z) = (_DWORD)v65;
		          v67 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                   (Vector4 *)v143,
		                                                   &v141,
		                                                   0.0,
		                                                   0LL));
		          Vector = UnityEngine::Animator::GetVector((Vector3 *)&v146, v68, v69, v70);
		          v72 = *(_QWORD *)&Vector->x;
		          *(float *)&Vector = Vector->z;
		          *(_QWORD *)&v148.x = v72;
		          LODWORD(v148.z) = (_DWORD)Vector;
		          v76 = UnityEngine::Animator::GetVector((Vector3 *)&v146, v73, v74, v75);
		          v77 = *(_QWORD *)&v76->x;
		          *(float *)&v76 = v76->z;
		          *(_QWORD *)&v142.x = v77;
		          LODWORD(v142.z) = (_DWORD)v76;
		          v81 = UnityEngine::Animator::GetVector((Vector3 *)&v146, v78, v79, v80);
		          selfTiltX_low = (__m128)LODWORD(planet->objectProperty.selfTiltX);
		          selfRotationY_low = (__m128)LODWORD(planet->objectProperty.selfRotationY);
		          v84 = *(_QWORD *)&v81->x;
		          *(float *)&v81 = v81->z;
		          selfTiltZ = planet->objectProperty.selfTiltZ;
		          *(_QWORD *)&v147.x = v84;
		          LODWORD(v147.z) = (_DWORD)v81;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		          *(_QWORD *)&v141.x = _mm_unpacklo_ps(selfTiltX_low, selfRotationY_low).m128_u64[0];
		          v141.z = selfTiltZ;
		          HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(&v141, &v148, &v147, &v142, 0LL);
		          *(_QWORD *)&v141.x = v152;
		          v141.z = v145;
		          v86 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                   (Vector4 *)v143,
		                                                   &v141,
		                                                   0.0,
		                                                   0LL));
		          *(_QWORD *)&v141.x = v153;
		          v141.z = v150;
		          v87 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)v143, &v141, 0.0, 0LL);
		          *(_QWORD *)&v141.x = *(_QWORD *)&v148.x;
		          v88 = _mm_loadu_si128((const __m128i *)v87);
		          v141.z = v148.z;
		          v89 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)v143, &v141, 0.0, 0LL);
		          *(_QWORD *)&v141.x = *(_QWORD *)&v147.x;
		          v90 = _mm_loadu_si128((const __m128i *)v89);
		          v141.z = v147.z;
		          v91 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)v143, &v141, 0.0, 0LL);
		          *(_QWORD *)&v141.x = *(_QWORD *)&v142.x;
		          v92 = _mm_loadu_si128((const __m128i *)v91);
		          v141.z = v142.z;
		          v93 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                   (Vector4 *)v143,
		                                                   &v141,
		                                                   0.0,
		                                                   0LL));
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 168);
		          if ( PlanetBaseMap01 )
		          {
		            if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		              goto LABEL_79;
		            if ( mat )
		            {
		              UnityEngine::Material::SetFloatImpl(mat, PlanetBaseMap01->vector[i], 1.0, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		              v94 = *((_QWORD *)static_fields + 62);
		              if ( v94 )
		              {
		                if ( (unsigned int)i >= *(_DWORD *)(v94 + 24) )
		                  goto LABEL_79;
		                v95 = *(String **)(v94 + 8LL * i + 32);
		                enableRing = planet->enableRing;
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		                VLB::Utils::SetKeywordEnabled(mat, v95, enableRing, 0LL);
		                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                v97 = *((_QWORD *)static_fields + 63);
		                if ( v97 )
		                {
		                  if ( (unsigned int)i >= *(_DWORD *)(v97 + 24) )
		                    goto LABEL_79;
		                  VLB::Utils::SetKeywordEnabled(mat, *(String **)(v97 + 8LL * i + 32), planet->enableAtmosphere, 0LL);
		                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 169);
		                  if ( PlanetBaseMap01 )
		                  {
		                    if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                      goto LABEL_79;
		                    v98 = PlanetBaseMap01->vector[i];
		                    v143[0] = (Quaternion)v67;
		                    UnityEngine::Material::SetVector(mat, v98, (Vector4 *)v143, 0LL);
		                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                    PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 170);
		                    if ( PlanetBaseMap01 )
		                    {
		                      if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                        goto LABEL_79;
		                      v99 = PlanetBaseMap01->vector[i];
		                      v143[0] = (Quaternion)v86;
		                      UnityEngine::Material::SetVector(mat, v99, (Vector4 *)v143, 0LL);
		                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                      PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 171);
		                      if ( PlanetBaseMap01 )
		                      {
		                        if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                          goto LABEL_79;
		                        v100 = PlanetBaseMap01->vector[i];
		                        v143[0] = (Quaternion)v88;
		                        UnityEngine::Material::SetVector(mat, v100, (Vector4 *)v143, 0LL);
		                        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                        PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 172);
		                        if ( PlanetBaseMap01 )
		                        {
		                          if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                            goto LABEL_79;
		                          v101 = PlanetBaseMap01->vector[i];
		                          v143[0] = (Quaternion)v63;
		                          UnityEngine::Material::SetVector(mat, v101, (Vector4 *)v143, 0LL);
		                          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                          PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 173);
		                          if ( PlanetBaseMap01 )
		                          {
		                            if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                              goto LABEL_79;
		                            v102 = PlanetBaseMap01->vector[i];
		                            v143[0] = (Quaternion)v90;
		                            UnityEngine::Material::SetVector(mat, v102, (Vector4 *)v143, 0LL);
		                            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                            PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 174);
		                            if ( PlanetBaseMap01 )
		                            {
		                              if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                goto LABEL_79;
		                              v103 = PlanetBaseMap01->vector[i];
		                              v143[0] = (Quaternion)v92;
		                              UnityEngine::Material::SetVector(mat, v103, (Vector4 *)v143, 0LL);
		                              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                              PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 175);
		                              if ( PlanetBaseMap01 )
		                              {
		                                if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                  goto LABEL_79;
		                                v104 = PlanetBaseMap01->vector[i];
		                                v143[0] = (Quaternion)v93;
		                                UnityEngine::Material::SetVector(mat, v104, (Vector4 *)v143, 0LL);
		                                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 185);
		                                if ( PlanetBaseMap01 )
		                                {
		                                  if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                    goto LABEL_79;
		                                  v105 = PlanetBaseMap01->vector[i];
		                                  if ( v15 )
		                                  {
		                                    Float = UnityEngine::Material::GetFloat(
		                                              (Material *)v15,
		                                              (String *)"_BlendMode",
		                                              0LL);
		                                    UnityEngine::Material::SetFloatImpl(mat, v105, Float, 0LL);
		                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                    v107 = *((_QWORD *)static_fields + 176);
		                                    if ( v107 )
		                                    {
		                                      if ( (unsigned int)i >= *(_DWORD *)(v107 + 24) )
		                                        goto LABEL_79;
		                                      v108 = *(_DWORD *)(v107 + 4LL * i + 32);
		                                      v143[0] = *(Quaternion *)UnityEngine::Material::GetColor(
		                                                                 (Color *)v143,
		                                                                 (Material *)v15,
		                                                                 (String *)"_Color",
		                                                                 0LL);
		                                      UnityEngine::Material::SetColor(mat, v108, (Color *)v143, 0LL);
		                                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                      v109 = *((_QWORD *)static_fields + 177);
		                                      if ( v109 )
		                                      {
		                                        if ( (unsigned int)i >= *(_DWORD *)(v109 + 24) )
		                                          goto LABEL_79;
		                                        v110 = *(_DWORD *)(v109 + 4LL * i + 32);
		                                        v111 = UnityEngine::Material::GetFloat(
		                                                 (Material *)v15,
		                                                 (String *)"_RingShadowSoftness",
		                                                 0LL);
		                                        UnityEngine::Material::SetFloatImpl(mat, v110, v111, 0LL);
		                                        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                        v112 = *((_QWORD *)static_fields + 179);
		                                        if ( v112 )
		                                        {
		                                          if ( (unsigned int)i >= *(_DWORD *)(v112 + 24) )
		                                            goto LABEL_79;
		                                          v113 = *(_DWORD *)(v112 + 4LL * i + 32);
		                                          v143[0] = *(Quaternion *)UnityEngine::Material::GetColor(
		                                                                     (Color *)v143,
		                                                                     (Material *)v15,
		                                                                     (String *)"_PlanetEmissive",
		                                                                     0LL);
		                                          UnityEngine::Material::SetColor(mat, v113, (Color *)v143, 0LL);
		                                          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                          v114 = *((_QWORD *)static_fields + 180);
		                                          if ( v114 )
		                                          {
		                                            if ( (unsigned int)i >= *(_DWORD *)(v114 + 24) )
		                                              goto LABEL_79;
		                                            v115 = *(_DWORD *)(v114 + 4LL * i + 32);
		                                            v116 = UnityEngine::Material::GetFloat(
		                                                     (Material *)v15,
		                                                     (String *)"_StarNdlSharp",
		                                                     0LL);
		                                            UnityEngine::Material::SetFloatImpl(mat, v115, v116, 0LL);
		                                            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                            v117 = *((_QWORD *)static_fields + 181);
		                                            if ( v117 )
		                                            {
		                                              if ( (unsigned int)i >= *(_DWORD *)(v117 + 24) )
		                                                goto LABEL_79;
		                                              v118 = *(_DWORD *)(v117 + 4LL * i + 32);
		                                              v119 = UnityEngine::Material::GetFloat(
		                                                       (Material *)v15,
		                                                       (String *)"_StarBackFaceAlpha",
		                                                       0LL);
		                                              UnityEngine::Material::SetFloatImpl(mat, v118, v119, 0LL);
		                                              Texture = UnityEngine::Material::GetTexture(
		                                                          (Material *)v15,
		                                                          (String *)"_MainTex",
		                                                          0LL);
		                                              sub_1800036A0(TypeInfo::UnityEngine::Object);
		                                              if ( UnityEngine::Object::op_Inequality((Object_1 *)Texture, 0LL, 0LL) )
		                                              {
		                                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		                                                PlanetBaseMap01 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetBaseMap01;
		                                                if ( !PlanetBaseMap01 )
		                                                  goto LABEL_81;
		                                                if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                                  goto LABEL_79;
		                                                UnityEngine::Material::SetTextureImpl(
		                                                  mat,
		                                                  PlanetBaseMap01->vector[i],
		                                                  Texture,
		                                                  0LL);
		                                              }
		                                              blackTexture = (Object_1 *)UnityEngine::Material::GetTexture(
		                                                                           (Material *)v15,
		                                                                           (String *)"_EmissiveTex",
		                                                                           0LL);
		                                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                              PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 183);
		                                              if ( PlanetBaseMap01 )
		                                              {
		                                                if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                                  goto LABEL_79;
		                                                v122 = PlanetBaseMap01->vector[i];
		                                                sub_1800036A0(TypeInfo::UnityEngine::Object);
		                                                if ( !UnityEngine::Object::op_Inequality(blackTexture, 0LL, 0LL) )
		                                                  blackTexture = (Object_1 *)UnityEngine::Texture2D::get_blackTexture(0LL);
		                                                UnityEngine::Material::SetTextureImpl(
		                                                  mat,
		                                                  v122,
		                                                  (Texture *)blackTexture,
		                                                  0LL);
		                                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 178);
		                                                if ( PlanetBaseMap01 )
		                                                {
		                                                  if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                                    goto LABEL_79;
		                                                  v123 = PlanetBaseMap01->vector[i];
		                                                  v143[0] = (Quaternion)planet->ring.ringColor;
		                                                  UnityEngine::Material::SetColor(mat, v123, (Color *)v143, 0LL);
		                                                  v124 = UnityEngine::Material::GetTexture(
		                                                           (Material *)v15,
		                                                           (String *)"_RingTex",
		                                                           0LL);
		                                                  sub_1800036A0(TypeInfo::UnityEngine::Object);
		                                                  if ( UnityEngine::Object::op_Inequality((Object_1 *)v124, 0LL, 0LL) )
		                                                  {
		                                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		                                                    PlanetBaseMap01 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRingTex01;
		                                                    if ( !PlanetBaseMap01 )
		                                                      goto LABEL_81;
		                                                    if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                                      goto LABEL_79;
		                                                    UnityEngine::Material::SetTextureImpl(
		                                                      mat,
		                                                      PlanetBaseMap01->vector[i],
		                                                      v124,
		                                                      0LL);
		                                                  }
		                                                  numInscatteredSamplePoints = (float)planet->atmosphere.numInscatteredSamplePoints;
		                                                  if ( numInscatteredSamplePoints < 0.0 )
		                                                  {
		                                                    numInscatteredSamplePoints = 0.0;
		                                                  }
		                                                  else if ( numInscatteredSamplePoints > 10.0 )
		                                                  {
		                                                    numInscatteredSamplePoints = 10.0;
		                                                  }
		                                                  numOpticalDepthSamplePoints = (float)planet->atmosphere.numOpticalDepthSamplePoints;
		                                                  if ( numOpticalDepthSamplePoints < 0.0 )
		                                                  {
		                                                    numOpticalDepthSamplePoints = 0.0;
		                                                  }
		                                                  else if ( numOpticalDepthSamplePoints > 5.0 )
		                                                  {
		                                                    numOpticalDepthSamplePoints = 5.0;
		                                                  }
		                                                  atmosphereHeight = planet->atmosphere.atmosphereHeight;
		                                                  coff_R = planet->atmosphere.coff_R;
		                                                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                                                  v129 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                           (Vector4 *)v143,
		                                                           atmosphereHeight,
		                                                           numInscatteredSamplePoints,
		                                                           coff_R,
		                                                           *(float *)v63.m128i_i32 * 2000.0,
		                                                           0LL);
		                                                  v130 = 30.0 - planet->atmosphere.heightScale_R;
		                                                  v131 = _mm_loadu_si128((const __m128i *)v129);
		                                                  if ( v130 <= 0.000099999997 )
		                                                    v130 = 0.000099999997;
		                                                  v132 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                           (Vector4 *)v143,
		                                                           numOpticalDepthSamplePoints,
		                                                           v130,
		                                                           planet->atmosphere.atmosphereBrightness,
		                                                           planet->atmosphere.atmosphereHueshift,
		                                                           0LL);
		                                                  enableAtmosphere = planet->enableAtmosphere;
		                                                  v134 = _mm_loadu_si128((const __m128i *)v132);
		                                                  bakeFaceVisibility = planet->atmosphere.bakeFaceVisibility;
		                                                  drawPlanetBelowHorizon = planet->drawPlanetBelowHorizon;
		                                                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                                                  v137 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                            (Vector4 *)v143,
		                                                                                            (float)enableAtmosphere,
		                                                                                            bakeFaceVisibility,
		                                                                                            v151,
		                                                                                            drawPlanetBelowHorizon,
		                                                                                            0LL));
		                                                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                  PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 216);
		                                                  if ( PlanetBaseMap01 )
		                                                  {
		                                                    if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                                      goto LABEL_79;
		                                                    v138 = PlanetBaseMap01->vector[i];
		                                                    v143[0] = (Quaternion)v131;
		                                                    UnityEngine::Material::SetVector(mat, v138, (Vector4 *)v143, 0LL);
		                                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                    PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 217);
		                                                    if ( PlanetBaseMap01 )
		                                                    {
		                                                      if ( (unsigned int)i >= PlanetBaseMap01->max_length.size )
		                                                        goto LABEL_79;
		                                                      v139 = PlanetBaseMap01->vector[i];
		                                                      v143[0] = (Quaternion)v134;
		                                                      UnityEngine::Material::SetVector(mat, v139, (Vector4 *)v143, 0LL);
		                                                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                      PlanetBaseMap01 = (Int32__Array *)*((_QWORD *)static_fields + 218);
		                                                      if ( PlanetBaseMap01 )
		                                                      {
		                                                        if ( (unsigned int)i < PlanetBaseMap01->max_length.size )
		                                                        {
		                                                          v140 = PlanetBaseMap01->vector[i];
		                                                          v143[0] = (Quaternion)v137;
		                                                          UnityEngine::Material::SetVector(
		                                                            mat,
		                                                            v140,
		                                                            (Vector4 *)v143,
		                                                            0LL);
		                                                          return;
		                                                        }
		LABEL_79:
		                                                        sub_1800D2AB0(static_fields, PlanetBaseMap01);
		                                                      }
		                                                    }
		                                                  }
		                                                }
		                                              }
		                                            }
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_81:
		    sub_1800D8260(static_fields, PlanetBaseMap01);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(1515, 0LL);
		  if ( !static_fields )
		    goto LABEL_81;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_616(
		    (ILFixDynamicMethodWrapper_2 *)static_fields,
		    (Object *)this,
		    (Object *)hgCamera,
		    (Object *)mat,
		    planet,
		    moon,
		    i,
		    0LL);
		}
		
		private List<Vector3> ClipQuadWithNearPlane(Vector3[] quadPos, Camera camera) => default; // 0x0000000189CE51F4-0x0000000189CE567C
		// List`1[UnityEngine.Vector3] ClipQuadWithNearPlane(Vector3[], Camera)
		List_1_UnityEngine_Vector3_ *HG::Rendering::Runtime::HGSkyRenderer::ClipQuadWithNearPlane(
		        HGSkyRenderer *this,
		        Vector3__Array *quadPos,
		        Camera *camera,
		        MethodInfo *method)
		{
		  _QWORD *p_quadWorld; // rcx
		  __int64 v8; // rdx
		  Transform *transform; // rax
		  Vector3 *forward; // rax
		  __int64 v11; // xmm8_8
		  float z; // r15d
		  Transform *v13; // rax
		  Vector3 *position; // rax
		  __int64 v15; // xmm7_8
		  float v16; // r14d
		  Transform *v17; // rax
		  Vector3 *v18; // rax
		  __int64 v19; // xmm6_8
		  float v20; // ebx
		  float v21; // xmm0_4
		  MethodInfo *v22; // r9
		  Vector3 *v23; // rax
		  __int64 v24; // xmm3_8
		  MethodInfo *v25; // r9
		  Vector3 *v26; // rax
		  __int64 v27; // xmm3_8
		  int32_t v28; // ebx
		  __int64 v29; // xmm6_8
		  __int64 v30; // xmm7_8
		  float v31; // r14d
		  float v32; // r12d
		  char Side; // r15
		  char v34; // di
		  MethodInfo *v35; // r9
		  __int64 v36; // r9
		  Vector3 *v37; // rax
		  __int64 v38; // xmm3_8
		  __int64 v39; // rax
		  __int64 v40; // xmm0_8
		  MethodInfo *v41; // r9
		  Vector3 *v42; // rax
		  __int64 v43; // xmm3_8
		  __int64 v44; // rax
		  __int64 v45; // xmm0_8
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  __int64 v51; // xmm6_8
		  float v52; // edi
		  __int64 v53; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v56; // [rsp+38h] [rbp-D0h] BYREF
		  float v57[4]; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v58; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v59; // [rsp+68h] [rbp-A0h] BYREF
		  Plane v60; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v61; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v62; // [rsp+98h] [rbp-70h] BYREF
		  Vector3 v63; // [rsp+A8h] [rbp-60h] BYREF
		  __int64 v64; // [rsp+B8h] [rbp-50h] BYREF
		  float v65; // [rsp+C0h] [rbp-48h]
		  Vector3 v66; // [rsp+C8h] [rbp-40h] BYREF
		  Vector3 v67; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v68; // [rsp+E8h] [rbp-20h] BYREF
		  Vector3 v69; // [rsp+F8h] [rbp-10h] BYREF
		  Vector3 v70; // [rsp+108h] [rbp+0h] BYREF
		  Vector3 v71; // [rsp+118h] [rbp+10h] BYREF
		  Vector3 v72; // [rsp+128h] [rbp+20h] BYREF
		  Vector3 v73; // [rsp+138h] [rbp+30h] BYREF
		  Vector3 v74; // [rsp+148h] [rbp+40h] BYREF
		  Ray v75; // [rsp+158h] [rbp+50h] BYREF
		  Ray v76; // [rsp+178h] [rbp+70h] BYREF
		  Vector3 v77; // [rsp+198h] [rbp+90h] BYREF
		  _BYTE v78[16]; // [rsp+1A8h] [rbp+A0h] BYREF
		  Vector3 v79; // [rsp+1B8h] [rbp+B0h] BYREF
		  _BYTE v80[16]; // [rsp+1C8h] [rbp+C0h] BYREF
		  Vector3 v81; // [rsp+1D8h] [rbp+D0h] BYREF
		  Vector3 v82[5]; // [rsp+1E8h] [rbp+E0h] BYREF
		
		  v57[0] = 0.0;
		  v60 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1517, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1517, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_614(
		               Patch,
		               (Object *)this,
		               (Object *)quadPos,
		               (Object *)camera,
		               0LL);
		LABEL_18:
		    sub_1800D8260(p_quadWorld, v8);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		  p_quadWorld = &TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->quadWorld;
		  v8 = p_quadWorld[1];
		  if ( !v8 )
		    goto LABEL_18;
		  ++*(_DWORD *)(v8 + 28);
		  *(_DWORD *)(v8 + 24) = 0;
		  if ( !camera )
		    goto LABEL_18;
		  transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !transform )
		    goto LABEL_18;
		  forward = UnityEngine::Transform::get_forward(&v59, transform, 0LL);
		  v11 = *(_QWORD *)&forward->x;
		  z = forward->z;
		  v13 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v13 )
		    goto LABEL_18;
		  position = UnityEngine::Transform::get_position(&v59, v13, 0LL);
		  v15 = *(_QWORD *)&position->x;
		  v16 = position->z;
		  v17 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !v17 )
		    goto LABEL_18;
		  v18 = UnityEngine::Transform::get_forward(&v59, v17, 0LL);
		  v19 = *(_QWORD *)&v18->x;
		  v20 = v18->z;
		  v21 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		  *(_QWORD *)&v56.x = v19;
		  v56.z = v20;
		  v23 = UnityEngine::Vector3::op_Multiply(&v59, &v56, v21, v22);
		  *(_QWORD *)&v58.x = v15;
		  v58.z = v16;
		  v24 = *(_QWORD *)&v23->x;
		  *(float *)&v23 = v23->z;
		  *(_QWORD *)&v56.x = v24;
		  LODWORD(v56.z) = (_DWORD)v23;
		  v26 = UnityEngine::Vector3::op_Addition(&v59, &v58, &v56, v25);
		  *(_QWORD *)&v56.x = v11;
		  v56.z = z;
		  v27 = *(_QWORD *)&v26->x;
		  *(float *)&v26 = v26->z;
		  *(_QWORD *)&v58.x = v27;
		  LODWORD(v58.z) = (_DWORD)v26;
		  UnityEngine::Plane::Plane(&v60, &v56, &v58, 0LL);
		  v28 = 0;
		  if ( !quadPos )
		    goto LABEL_18;
		  while ( v28 < quadPos->max_length.size )
		  {
		    sub_180049C60(quadPos, &v58, v28);
		    sub_180049C60(quadPos, &v61, (v28 + 1) % quadPos->max_length.size);
		    v29 = *(_QWORD *)&v58.x;
		    v30 = *(_QWORD *)&v61.x;
		    v31 = v58.z;
		    v32 = v61.z;
		    v63 = v58;
		    v62 = v61;
		    Side = UnityEngine::Plane::GetSide(&v60, &v62, 0LL);
		    v34 = UnityEngine::Plane::GetSide(&v60, &v63, 0LL);
		    if ( v34 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		      p_quadWorld = &TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->clippedPoints->klass;
		      if ( !p_quadWorld )
		        goto LABEL_18;
		      v64 = v29;
		      v65 = v31;
		      sub_18036459C(p_quadWorld, &v64, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v36);
		    }
		    if ( v34 != Side )
		    {
		      *(_QWORD *)&v66.x = v29;
		      v66.z = v31;
		      *(_QWORD *)&v67.x = v30;
		      v67.z = v32;
		      v37 = UnityEngine::Vector3::op_Subtraction(&v77, &v67, &v66, v35);
		      memset(&v75, 0, sizeof(v75));
		      v38 = *(_QWORD *)&v37->x;
		      v56.z = v37->z;
		      *(_QWORD *)&v56.x = v38;
		      v39 = sub_182FAE2B0(v78, &v56);
		      *(_QWORD *)&v69.x = v29;
		      v69.z = v31;
		      v40 = *(_QWORD *)v39;
		      LODWORD(v39) = *(_DWORD *)(v39 + 8);
		      *(_QWORD *)&v68.x = v40;
		      LODWORD(v68.z) = v39;
		      UnityEngine::Ray::Ray(&v75, &v69, &v68, 0LL);
		      v76 = v75;
		      UnityEngine::Plane::Raycast(&v60, &v76, v57, 0LL);
		      *(_QWORD *)&v70.x = v29;
		      v70.z = v31;
		      *(_QWORD *)&v71.x = v30;
		      v71.z = v32;
		      v42 = UnityEngine::Vector3::op_Subtraction(&v79, &v71, &v70, v41);
		      v43 = *(_QWORD *)&v42->x;
		      *(float *)&v42 = v42->z;
		      *(_QWORD *)&v56.x = v43;
		      LODWORD(v56.z) = (_DWORD)v42;
		      v44 = sub_182FAE2B0(v80, &v56);
		      v45 = *(_QWORD *)v44;
		      LODWORD(v44) = *(_DWORD *)(v44 + 8);
		      *(_QWORD *)&v72.x = v45;
		      LODWORD(v72.z) = v44;
		      v47 = UnityEngine::Vector3::op_Multiply(&v81, &v72, v57[0], v46);
		      *(_QWORD *)&v74.x = v29;
		      v74.z = v31;
		      v48 = *(_QWORD *)&v47->x;
		      *(float *)&v47 = v47->z;
		      *(_QWORD *)&v73.x = v48;
		      LODWORD(v73.z) = (_DWORD)v47;
		      v50 = UnityEngine::Vector3::op_Addition(v82, &v74, &v73, v49);
		      v51 = *(_QWORD *)&v50->x;
		      v52 = v50->z;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		      p_quadWorld = &TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->clippedPoints->klass;
		      if ( !p_quadWorld )
		        goto LABEL_18;
		      *(_QWORD *)&v59.x = v51;
		      v59.z = v52;
		      sub_18036459C(p_quadWorld, &v59, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add, v53);
		    }
		    ++v28;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		  return TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->clippedPoints;
		}
		
		private bool CheckPlanetVisibility(HGCamera hgCamera, Matrix4x4 matrix) => default; // 0x0000000189CE4E54-0x0000000189CE51F4
		// Boolean CheckPlanetVisibility(HGCamera, Matrix4x4)
		// Hidden C++ exception states: #wind=1
		bool HG::Rendering::Runtime::HGSkyRenderer::CheckPlanetVisibility(
		        HGSkyRenderer *this,
		        HGCamera *hgCamera,
		        Matrix4x4 *matrix,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Camera *camera; // rsi
		  __int64 v10; // rbx
		  __int64 v11; // r15
		  __int64 v12; // rdx
		  HGSkyRenderer__StaticFields *static_fields; // rcx
		  Vector3__Array *quadWorld; // r13
		  Vector3 *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  float z; // r12d
		  List_1_UnityEngine_Vector3_ *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  float v22; // xmm7_4
		  float v23; // xmm9_4
		  float v24; // xmm6_4
		  float v25; // xmm8_4
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  int v32; // [rsp+30h] [rbp-108h]
		  int v33; // [rsp+34h] [rbp-104h]
		  int v34; // [rsp+38h] [rbp-100h]
		  int v35; // [rsp+3Ch] [rbp-FCh]
		  __int64 v36; // [rsp+40h] [rbp-F8h] BYREF
		  float v37; // [rsp+48h] [rbp-F0h]
		  Vector3 v38; // [rsp+50h] [rbp-E8h] BYREF
		  Matrix4x4 v39; // [rsp+60h] [rbp-D8h] BYREF
		  Vector3 v40; // [rsp+A0h] [rbp-98h] BYREF
		  List_1_T_Enumerator_UnityEngine_Vector3_ v41; // [rsp+B0h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v42; // [rsp+D0h] [rbp-68h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1516, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1516, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, v30);
		    v39 = *matrix;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_615(Patch, (Object *)this, (Object *)hgCamera, &v39, 0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      sub_1800D8260(v8, v7);
		    camera = hgCamera->fields.camera;
		    v10 = 0LL;
		    v11 = 4LL;
		    do
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields;
		      quadWorld = static_fields->quadWorld;
		      if ( !this->fields.starQuadPoints )
		        sub_1800D8260(static_fields, v12);
		      sub_180049C60(this->fields.starQuadPoints, &v36, v10);
		      *(_QWORD *)&v39.m00 = v36;
		      v39.m20 = v37;
		      v15 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v40, matrix, (Vector3 *)&v39, 0LL);
		      z = v15->z;
		      if ( !quadWorld )
		        sub_1800D8260(v17, v16);
		      *(_QWORD *)&v38.x = *(_QWORD *)&v15->x;
		      v38.z = z;
		      sub_180049BD0(quadWorld, v10++, &v38);
		      --v11;
		    }
		    while ( v11 );
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		    v19 = HG::Rendering::Runtime::HGSkyRenderer::ClipQuadWithNearPlane(
		            this,
		            TypeInfo::HG::Rendering::Runtime::HGSkyRenderer->static_fields->quadWorld,
		            camera,
		            0LL);
		    if ( !v19 )
		      sub_1800D8260(v21, v20);
		    if ( !v19->fields._size )
		      return 0;
		    v22 = 3.4028235e38;
		    *(float *)&v32 = 3.4028235e38;
		    v23 = 3.4028235e38;
		    *(float *)&v33 = 3.4028235e38;
		    v24 = -3.4028235e38;
		    *(float *)&v34 = -3.4028235e38;
		    v25 = -3.4028235e38;
		    *(float *)&v35 = -3.4028235e38;
		    System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator(
		      (List_1_T_Enumerator_UnityEngine_Vector3_ *)&v39,
		      v19,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
		    *(_OWORD *)&v41._list = *(_OWORD *)&v39.m00;
		    *(_OWORD *)&v41._current.x = *(_OWORD *)&v39.m01;
		    *(_QWORD *)&v39.m00 = 0LL;
		    *(_QWORD *)&v39.m20 = &v41;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext(
		                &v41,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
		      {
		        if ( !camera )
		          sub_1800D8250(v27, v26);
		        *(_QWORD *)&v38.x = *(_QWORD *)&v41._current.x;
		        LODWORD(v38.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v41._current.x, 8));
		        v36 = *(_QWORD *)&UnityEngine::Camera::WorldToViewportPoint(&v40, camera, &v38, 0LL)->x;
		        if ( *(float *)&v36 <= v22 )
		          v22 = *(float *)&v36;
		        *(float *)&v32 = v22;
		        if ( v24 <= *(float *)&v36 )
		          v24 = *(float *)&v36;
		        *(float *)&v34 = v24;
		        if ( *((float *)&v36 + 1) <= v23 )
		          v23 = *((float *)&v36 + 1);
		        *(float *)&v33 = v23;
		        if ( v25 <= *((float *)&v36 + 1) )
		          v25 = *((float *)&v36 + 1);
		        *(float *)&v35 = v25;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v42 )
		    {
		      *(Il2CppExceptionWrapper *)&v39.m00 = (Il2CppExceptionWrapper)v42->ex;
		      if ( *(_QWORD *)&v39.m00 )
		        sub_18007E1E0(*(_QWORD *)&v39.m00);
		      v22 = *(float *)&v32;
		      v23 = *(float *)&v33;
		      v24 = *(float *)&v34;
		      v25 = *(float *)&v35;
		    }
		    return v24 >= 0.0 && v22 <= 1.0 && v25 >= 0.0 && v23 <= 1.0;
		  }
		}
		
		private void SetupAdvancedPlanet(MaterialPropertyBlock propertyBlock, ScriptableRenderContext context, HGCamera hgCamera, Material mat) {} // 0x0000000189CE6AA0-0x0000000189CE7C0C
		// Void SetupAdvancedPlanet(MaterialPropertyBlock, ScriptableRenderContext, HGCamera, Material)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupAdvancedPlanet(
		        HGSkyRenderer *this,
		        MaterialPropertyBlock *propertyBlock,
		        ScriptableRenderContext context,
		        HGCamera *hgCamera,
		        Material *mat,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  void *static_fields; // rdx
		  void *Patch; // rcx
		  HGEnvironmentPhase *v12; // rdi
		  Object_1 *advancedPlanetMat; // rbx
		  Material *v14; // rbx
		  float FloatImpl; // xmm0_4
		  float v16; // xmm0_4
		  float v17; // xmm0_4
		  float v18; // xmm0_4
		  float v19; // xmm0_4
		  float v20; // xmm0_4
		  float v21; // xmm0_4
		  float v22; // xmm0_4
		  float v23; // xmm0_4
		  float v24; // xmm0_4
		  float v25; // xmm0_4
		  float v26; // xmm0_4
		  float v27; // xmm0_4
		  float v28; // xmm0_4
		  float v29; // xmm0_4
		  float v30; // xmm0_4
		  float v31; // xmm0_4
		  float v32; // xmm0_4
		  float v33; // xmm0_4
		  float v34; // xmm0_4
		  float v35; // xmm0_4
		  float v36; // xmm0_4
		  float v37; // xmm0_4
		  float v38; // xmm0_4
		  float v39; // xmm0_4
		  float v40; // xmm0_4
		  float v41; // xmm0_4
		  float v42; // xmm0_4
		  float v43; // xmm0_4
		  float v44; // xmm0_4
		  float v45; // xmm0_4
		  float v46; // xmm0_4
		  float v47; // xmm0_4
		  float v48; // xmm0_4
		  float v49; // xmm0_4
		  float v50; // xmm0_4
		  MethodInfo *v51; // r8
		  Color *v52; // rax
		  MethodInfo *v53; // r8
		  Color *v54; // rax
		  MethodInfo *v55; // r8
		  Color *v56; // rax
		  Vector4 *Vector; // rax
		  Vector4 *v58; // rax
		  Vector4 *v59; // rax
		  MethodInfo *v60; // r8
		  Color *v61; // rax
		  MethodInfo *v62; // r8
		  Color *v63; // rax
		  MethodInfo *v64; // r8
		  Color *v65; // rax
		  MethodInfo *v66; // r8
		  Color *v67; // rax
		  MethodInfo *v68; // r8
		  Color *v69; // rax
		  Vector4 *v70; // rax
		  MethodInfo *v71; // r8
		  Color *v72; // rax
		  MethodInfo *v73; // r8
		  Color *v74; // rax
		  Vector4 *v75; // rax
		  Vector4 *v76; // rax
		  __int64 v77; // rdx
		  _OWORD *v78; // rcx
		  Vector4 v79; // xmm0
		  Void *p_source; // rax
		  __int128 v81; // xmm1
		  __int128 v82; // xmm0
		  __int128 v83; // xmm1
		  __int128 v84; // xmm0
		  __int128 v85; // xmm1
		  __int128 v86; // xmm0
		  __int128 v87; // xmm1
		  __int128 v88; // xmm0
		  struct ScriptableRenderContext__Class *v89; // rcx
		  CBHandle *v90; // rax
		  __m128i v91; // xmm6
		  __m128i v92; // xmm1
		  int32_t TransmittanceLLUT; // ebx
		  Texture *TextureImpl; // rax
		  int32_t BaseColorMap; // ebx
		  Texture *v96; // rax
		  int32_t RSM; // ebx
		  Texture *v98; // rax
		  int32_t CloudsTexMain; // ebx
		  Texture *v100; // rax
		  int32_t CloudsCap; // ebx
		  Texture *v102; // rax
		  int32_t CloudsFlowMap; // ebx
		  Texture *v104; // rax
		  int32_t ErosionMap; // ebx
		  Texture *v106; // rax
		  HGShaderKeyWords__StaticFields *v107; // rax
		  String *DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP; // rsi
		  bool IsKeywordEnabled; // bl
		  bool v110; // r8
		  Material *v111; // rbx
		  HGShaderKeyWords__StaticFields *v112; // rax
		  String *DRAW_ADVANCED_PLANET_CLOUDS_SHADOW; // rsi
		  bool v114; // al
		  String *DRAW_ADVANCED_PLANET; // rbx
		  CBHandle v116; // [rsp+48h] [rbp-C0h] BYREF
		  Vector4 v117; // [rsp+68h] [rbp-A0h] BYREF
		  Void *destination; // [rsp+78h] [rbp-90h]
		  _DWORD v119[36]; // [rsp+88h] [rbp-80h] BYREF
		  _OWORD v120[16]; // [rsp+118h] [rbp+10h] BYREF
		  Void source; // [rsp+218h] [rbp+110h] BYREF
		  ScriptableRenderContext P2; // [rsp+3D8h] [rbp+2D0h] BYREF
		
		  P2.m_Ptr = context.m_Ptr;
		  if ( IFix::WrappersManagerImpl::IsPatched(1518, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1518, 0LL);
		    if ( !Patch )
		      goto LABEL_73;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      (ILFixDynamicMethodWrapper_2 *)Patch,
		      (Object *)this,
		      (Object *)propertyBlock,
		      P2,
		      (Object *)hgCamera,
		      (Object *)mat,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    v12 = InterpolatedPhase;
		    if ( !InterpolatedPhase )
		      goto LABEL_73;
		    if ( InterpolatedPhase->fields.celestialConfig.advancedPlanetConfig.drawAdvancedPlanet )
		    {
		      advancedPlanetMat = (Object_1 *)InterpolatedPhase->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(advancedPlanetMat, 0LL, 0LL) )
		      {
		        sub_18033B9D0(v120, 0LL, 256LL);
		        v14 = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( v14 )
		        {
		          FloatImpl = UnityEngine::Material::GetFloatImpl(v14, *((_DWORD *)static_fields + 373), 0LL);
		          Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		          *(float *)v119 = FloatImpl;
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          if ( Patch )
		          {
		            v16 = UnityEngine::Material::GetFloatImpl((Material *)Patch, *((_DWORD *)static_fields + 374), 0LL);
		            Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		            *(float *)&v119[1] = v16;
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( Patch )
		            {
		              v17 = UnityEngine::Material::GetFloatImpl((Material *)Patch, *((_DWORD *)static_fields + 375), 0LL);
		              Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		              *(float *)&v119[2] = v17;
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              if ( Patch )
		              {
		                v18 = UnityEngine::Material::GetFloatImpl((Material *)Patch, *((_DWORD *)static_fields + 376), 0LL);
		                Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                *(float *)&v119[3] = v18;
		                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                if ( Patch )
		                {
		                  v19 = UnityEngine::Material::GetFloatImpl((Material *)Patch, *((_DWORD *)static_fields + 377), 0LL);
		                  Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                  *(float *)&v119[4] = v19;
		                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  if ( Patch )
		                  {
		                    v20 = UnityEngine::Material::GetFloatImpl((Material *)Patch, *((_DWORD *)static_fields + 378), 0LL);
		                    Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                    *(float *)&v119[5] = v20;
		                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                    if ( Patch )
		                    {
		                      v21 = UnityEngine::Material::GetFloatImpl(
		                              (Material *)Patch,
		                              *((_DWORD *)static_fields + 379),
		                              0LL);
		                      Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                      *(float *)&v119[6] = v21;
		                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                      if ( Patch )
		                      {
		                        v22 = UnityEngine::Material::GetFloatImpl(
		                                (Material *)Patch,
		                                *((_DWORD *)static_fields + 380),
		                                0LL);
		                        Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                        *(float *)&v119[7] = v22;
		                        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                        if ( Patch )
		                        {
		                          v23 = UnityEngine::Material::GetFloatImpl(
		                                  (Material *)Patch,
		                                  *((_DWORD *)static_fields + 381),
		                                  0LL);
		                          Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                          *(float *)&v119[8] = v23;
		                          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                          if ( Patch )
		                          {
		                            v24 = UnityEngine::Material::GetFloatImpl(
		                                    (Material *)Patch,
		                                    *((_DWORD *)static_fields + 382),
		                                    0LL);
		                            Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                            *(float *)&v119[9] = v24;
		                            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                            if ( Patch )
		                            {
		                              v25 = UnityEngine::Material::GetFloatImpl(
		                                      (Material *)Patch,
		                                      *((_DWORD *)static_fields + 383),
		                                      0LL);
		                              Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                              *(float *)&v119[10] = v25;
		                              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                              if ( Patch )
		                              {
		                                v26 = UnityEngine::Material::GetFloatImpl(
		                                        (Material *)Patch,
		                                        *((_DWORD *)static_fields + 384),
		                                        0LL);
		                                Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                *(float *)&v119[11] = v26;
		                                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                if ( Patch )
		                                {
		                                  v27 = UnityEngine::Material::GetFloatImpl(
		                                          (Material *)Patch,
		                                          *((_DWORD *)static_fields + 385),
		                                          0LL);
		                                  Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                  *(float *)&v119[12] = v27;
		                                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                  if ( Patch )
		                                  {
		                                    v28 = UnityEngine::Material::GetFloatImpl(
		                                            (Material *)Patch,
		                                            *((_DWORD *)static_fields + 386),
		                                            0LL);
		                                    Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                    *(float *)&v119[13] = v28;
		                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                    if ( Patch )
		                                    {
		                                      v29 = UnityEngine::Material::GetFloatImpl(
		                                              (Material *)Patch,
		                                              *((_DWORD *)static_fields + 387),
		                                              0LL);
		                                      Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                      *(float *)&v119[14] = v29;
		                                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                      if ( Patch )
		                                      {
		                                        v30 = UnityEngine::Material::GetFloatImpl(
		                                                (Material *)Patch,
		                                                *((_DWORD *)static_fields + 388),
		                                                0LL);
		                                        Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                        *(float *)&v119[15] = v30;
		                                        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                        if ( Patch )
		                                        {
		                                          v31 = UnityEngine::Material::GetFloatImpl(
		                                                  (Material *)Patch,
		                                                  *((_DWORD *)static_fields + 389),
		                                                  0LL);
		                                          Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                          *(float *)&v119[16] = v31;
		                                          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                          if ( Patch )
		                                          {
		                                            v32 = UnityEngine::Material::GetFloatImpl(
		                                                    (Material *)Patch,
		                                                    *((_DWORD *)static_fields + 390),
		                                                    0LL);
		                                            Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                            *(float *)&v119[17] = v32;
		                                            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                            if ( Patch )
		                                            {
		                                              v33 = UnityEngine::Material::GetFloatImpl(
		                                                      (Material *)Patch,
		                                                      *((_DWORD *)static_fields + 391),
		                                                      0LL);
		                                              Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                              *(float *)&v119[18] = v33;
		                                              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                              if ( Patch )
		                                              {
		                                                v34 = UnityEngine::Material::GetFloatImpl(
		                                                        (Material *)Patch,
		                                                        *((_DWORD *)static_fields + 392),
		                                                        0LL);
		                                                Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                *(float *)&v119[19] = v34;
		                                                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                if ( Patch )
		                                                {
		                                                  v35 = UnityEngine::Material::GetFloatImpl(
		                                                          (Material *)Patch,
		                                                          *((_DWORD *)static_fields + 393),
		                                                          0LL);
		                                                  Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                  *(float *)&v119[20] = v35;
		                                                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                  if ( Patch )
		                                                  {
		                                                    v36 = UnityEngine::Material::GetFloatImpl(
		                                                            (Material *)Patch,
		                                                            *((_DWORD *)static_fields + 394),
		                                                            0LL);
		                                                    Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                    *(float *)&v119[21] = v36;
		                                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                    if ( Patch )
		                                                    {
		                                                      v37 = UnityEngine::Material::GetFloatImpl(
		                                                              (Material *)Patch,
		                                                              *((_DWORD *)static_fields + 395),
		                                                              0LL);
		                                                      Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                      *(float *)&v119[22] = v37;
		                                                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                      if ( Patch )
		                                                      {
		                                                        v38 = UnityEngine::Material::GetFloatImpl(
		                                                                (Material *)Patch,
		                                                                *((_DWORD *)static_fields + 396),
		                                                                0LL);
		                                                        Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                        *(float *)&v119[23] = v38;
		                                                        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                        if ( Patch )
		                                                        {
		                                                          v39 = UnityEngine::Material::GetFloatImpl(
		                                                                  (Material *)Patch,
		                                                                  *((_DWORD *)static_fields + 397),
		                                                                  0LL);
		                                                          Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                          *(float *)&v119[24] = v39;
		                                                          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                          if ( Patch )
		                                                          {
		                                                            v40 = UnityEngine::Material::GetFloatImpl(
		                                                                    (Material *)Patch,
		                                                                    *((_DWORD *)static_fields + 398),
		                                                                    0LL);
		                                                            Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                            *(float *)&v119[25] = v40;
		                                                            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                            if ( Patch )
		                                                            {
		                                                              v41 = UnityEngine::Material::GetFloatImpl(
		                                                                      (Material *)Patch,
		                                                                      *((_DWORD *)static_fields + 399),
		                                                                      0LL);
		                                                              Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                              *(float *)&v119[26] = v41;
		                                                              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                              if ( Patch )
		                                                              {
		                                                                v42 = UnityEngine::Material::GetFloatImpl(
		                                                                        (Material *)Patch,
		                                                                        *((_DWORD *)static_fields + 400),
		                                                                        0LL);
		                                                                Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                *(float *)&v119[27] = v42;
		                                                                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                if ( Patch )
		                                                                {
		                                                                  v43 = UnityEngine::Material::GetFloatImpl(
		                                                                          (Material *)Patch,
		                                                                          *((_DWORD *)static_fields + 401),
		                                                                          0LL);
		                                                                  Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                  *(float *)&v119[28] = v43;
		                                                                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                  if ( Patch )
		                                                                  {
		                                                                    v44 = UnityEngine::Material::GetFloatImpl(
		                                                                            (Material *)Patch,
		                                                                            *((_DWORD *)static_fields + 402),
		                                                                            0LL);
		                                                                    Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                    *(float *)&v119[29] = v44;
		                                                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                    if ( Patch )
		                                                                    {
		                                                                      v45 = UnityEngine::Material::GetFloatImpl(
		                                                                              (Material *)Patch,
		                                                                              *((_DWORD *)static_fields + 403),
		                                                                              0LL);
		                                                                      Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                      *(float *)&v119[30] = v45;
		                                                                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                      if ( Patch )
		                                                                      {
		                                                                        v46 = UnityEngine::Material::GetFloatImpl(
		                                                                                (Material *)Patch,
		                                                                                *((_DWORD *)static_fields + 404),
		                                                                                0LL);
		                                                                        Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                        *(float *)&v119[31] = v46;
		                                                                        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                        if ( Patch )
		                                                                        {
		                                                                          v47 = UnityEngine::Material::GetFloatImpl(
		                                                                                  (Material *)Patch,
		                                                                                  *((_DWORD *)static_fields + 405),
		                                                                                  0LL);
		                                                                          Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                          *(float *)&v119[32] = v47;
		                                                                          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                          if ( Patch )
		                                                                          {
		                                                                            v48 = UnityEngine::Material::GetFloatImpl(
		                                                                                    (Material *)Patch,
		                                                                                    *((_DWORD *)static_fields + 406),
		                                                                                    0LL);
		                                                                            Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                            *(float *)&v119[33] = v48;
		                                                                            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                            if ( Patch )
		                                                                            {
		                                                                              v49 = UnityEngine::Material::GetFloatImpl(
		                                                                                      (Material *)Patch,
		                                                                                      *((_DWORD *)static_fields + 407),
		                                                                                      0LL);
		                                                                              Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                              *(float *)&v119[34] = v49;
		                                                                              static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                              if ( Patch )
		                                                                              {
		                                                                                v50 = UnityEngine::Material::GetFloatImpl(
		                                                                                        (Material *)Patch,
		                                                                                        *((_DWORD *)static_fields + 408),
		                                                                                        0LL);
		                                                                                static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                *(float *)&v119[35] = v50;
		                                                                                Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                if ( static_fields )
		                                                                                {
		                                                                                  *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v116, (Material *)static_fields, *((_DWORD *)Patch + 409), 0LL);
		                                                                                  *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                  v52 = UnityEngine::Color::op_Implicit(
		                                                                                          (Color *)&v117,
		                                                                                          (Vector4 *)&v116,
		                                                                                          v51);
		                                                                                  static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                  v120[0] = *v52;
		                                                                                  Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                  if ( static_fields )
		                                                                                  {
		                                                                                    *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 410), 0LL);
		                                                                                    *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                    v54 = UnityEngine::Color::op_Implicit(
		                                                                                            (Color *)&v117,
		                                                                                            (Vector4 *)&v116,
		                                                                                            v53);
		                                                                                    static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                    v120[1] = *v54;
		                                                                                    Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                    if ( static_fields )
		                                                                                    {
		                                                                                      *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 411), 0LL);
		                                                                                      *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                      v56 = UnityEngine::Color::op_Implicit(
		                                                                                              (Color *)&v117,
		                                                                                              (Vector4 *)&v116,
		                                                                                              v55);
		                                                                                      static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                      v120[2] = *v56;
		                                                                                      Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                      if ( static_fields )
		                                                                                      {
		                                                                                        Vector = UnityEngine::Material::GetVector(
		                                                                                                   &v117,
		                                                                                                   (Material *)static_fields,
		                                                                                                   *((_DWORD *)Patch + 412),
		                                                                                                   0LL);
		                                                                                        static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                        v120[3] = *Vector;
		                                                                                        Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                        if ( static_fields )
		                                                                                        {
		                                                                                          v58 = UnityEngine::Material::GetVector(
		                                                                                                  &v117,
		                                                                                                  (Material *)static_fields,
		                                                                                                  *((_DWORD *)Patch + 413),
		                                                                                                  0LL);
		                                                                                          static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                          v120[4] = *v58;
		                                                                                          Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                          if ( static_fields )
		                                                                                          {
		                                                                                            v59 = UnityEngine::Material::GetVector(
		                                                                                                    &v117,
		                                                                                                    (Material *)static_fields,
		                                                                                                    *((_DWORD *)Patch + 414),
		                                                                                                    0LL);
		                                                                                            static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                            v120[5] = *v59;
		                                                                                            Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                            if ( static_fields )
		                                                                                            {
		                                                                                              *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 415), 0LL);
		                                                                                              *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                              v61 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v60);
		                                                                                              static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                              v120[6] = *v61;
		                                                                                              Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                              if ( static_fields )
		                                                                                              {
		                                                                                                *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 416), 0LL);
		                                                                                                *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                                v63 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v62);
		                                                                                                static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                v120[7] = *v63;
		                                                                                                Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                if ( static_fields )
		                                                                                                {
		                                                                                                  *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 417), 0LL);
		                                                                                                  *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                                  v65 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v64);
		                                                                                                  static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                  v120[8] = *v65;
		                                                                                                  Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                  if ( static_fields )
		                                                                                                  {
		                                                                                                    *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 418), 0LL);
		                                                                                                    *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                                    v67 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v66);
		                                                                                                    static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                    v120[9] = *v67;
		                                                                                                    Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                    if ( static_fields )
		                                                                                                    {
		                                                                                                      *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 419), 0LL);
		                                                                                                      *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                                      v69 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v68);
		                                                                                                      static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                      v120[10] = *v69;
		                                                                                                      Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                      if ( static_fields )
		                                                                                                      {
		                                                                                                        v70 = UnityEngine::Material::GetVector(&v117, (Material *)static_fields, *((_DWORD *)Patch + 420), 0LL);
		                                                                                                        static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                        v120[11] = *v70;
		                                                                                                        Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                        if ( static_fields )
		                                                                                                        {
		                                                                                                          *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 421), 0LL);
		                                                                                                          *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                                          v72 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v71);
		                                                                                                          static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                          v120[12] = *v72;
		                                                                                                          Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                          if ( static_fields )
		                                                                                                          {
		                                                                                                            *(Color *)&v116.bufferId = *UnityEngine::Material::GetColor((Color *)&v117, (Material *)static_fields, *((_DWORD *)Patch + 422), 0LL);
		                                                                                                            *(_OWORD *)&v116.bufferId = *(_OWORD *)sub_183C6CBA0(&v117, &v116);
		                                                                                                            v74 = UnityEngine::Color::op_Implicit((Color *)&v117, (Vector4 *)&v116, v73);
		                                                                                                            static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                            v120[13] = *v74;
		                                                                                                            Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                            if ( static_fields )
		                                                                                                            {
		                                                                                                              v75 = UnityEngine::Material::GetVector(&v117, (Material *)static_fields, *((_DWORD *)Patch + 423), 0LL);
		                                                                                                              static_fields = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                              v120[14] = *v75;
		                                                                                                              Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                              if ( static_fields )
		                                                                                                              {
		                                                                                                                v76 = UnityEngine::Material::GetVector(&v117, (Material *)static_fields, *((_DWORD *)Patch + 424), 0LL);
		                                                                                                                v77 = 3LL;
		                                                                                                                v78 = v119;
		                                                                                                                v79 = *v76;
		                                                                                                                p_source = &source;
		                                                                                                                v120[15] = v79;
		                                                                                                                do
		                                                                                                                {
		                                                                                                                  v81 = v78[1];
		                                                                                                                  *(_OWORD *)p_source = *v78;
		                                                                                                                  v82 = v78[2];
		                                                                                                                  *(_OWORD *)&p_source[16] = v81;
		                                                                                                                  v83 = v78[3];
		                                                                                                                  *(_OWORD *)&p_source[32] = v82;
		                                                                                                                  v84 = v78[4];
		                                                                                                                  *(_OWORD *)&p_source[48] = v83;
		                                                                                                                  v85 = v78[5];
		                                                                                                                  *(_OWORD *)&p_source[64] = v84;
		                                                                                                                  v86 = v78[6];
		                                                                                                                  *(_OWORD *)&p_source[80] = v85;
		                                                                                                                  v87 = v78[7];
		                                                                                                                  v78 += 8;
		                                                                                                                  *(_OWORD *)&p_source[96] = v86;
		                                                                                                                  p_source += 128;
		                                                                                                                  *(_OWORD *)&p_source[-16] = v87;
		                                                                                                                  --v77;
		                                                                                                                }
		                                                                                                                while ( v77 );
		                                                                                                                v88 = *v78;
		                                                                                                                v89 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
		                                                                                                                *(_OWORD *)p_source = v88;
		                                                                                                                sub_1800036A0(v89);
		                                                                                                                v90 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v116, &P2, 400, 0LL);
		                                                                                                                v91 = *(__m128i *)&v90->bufferId;
		                                                                                                                v92 = *(__m128i *)&v90->bufferId;
		                                                                                                                destination = (Void *)v90->ptr;
		                                                                                                                Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, &source, (unsigned int)_mm_cvtsi128_si32(_mm_srli_si128(v92, 8)), 0LL);
		                                                                                                                Patch = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                                                                                                                if ( propertyBlock )
		                                                                                                                {
		                                                                                                                  UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(propertyBlock, *((_DWORD *)Patch + 372), _mm_cvtsi128_si32(v91), _mm_cvtsi128_si32(_mm_srli_si128(v91, 4)), _mm_cvtsi128_si32(_mm_srli_si128(v91, 8)), 0LL);
		                                                                                                                  Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                  TransmittanceLLUT = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLLUT;
		                                                                                                                  if ( Patch )
		                                                                                                                  {
		                                                                                                                    TextureImpl = UnityEngine::Material::GetTextureImpl((Material *)Patch, TransmittanceLLUT, 0LL);
		                                                                                                                    HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, TransmittanceLLUT, TextureImpl, 0LL);
		                                                                                                                    Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                    BaseColorMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BaseColorMap;
		                                                                                                                    if ( Patch )
		                                                                                                                    {
		                                                                                                                      v96 = UnityEngine::Material::GetTextureImpl((Material *)Patch, BaseColorMap, 0LL);
		                                                                                                                      HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, BaseColorMap, v96, 0LL);
		                                                                                                                      Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                      RSM = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RSM;
		                                                                                                                      if ( Patch )
		                                                                                                                      {
		                                                                                                                        v98 = UnityEngine::Material::GetTextureImpl((Material *)Patch, RSM, 0LL);
		                                                                                                                        HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, RSM, v98, 0LL);
		                                                                                                                        Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                        CloudsTexMain = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsTexMain;
		                                                                                                                        if ( Patch )
		                                                                                                                        {
		                                                                                                                          v100 = UnityEngine::Material::GetTextureImpl((Material *)Patch, CloudsTexMain, 0LL);
		                                                                                                                          HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, CloudsTexMain, v100, 0LL);
		                                                                                                                          Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                          CloudsCap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsCap;
		                                                                                                                          if ( Patch )
		                                                                                                                          {
		                                                                                                                            v102 = UnityEngine::Material::GetTextureImpl((Material *)Patch, CloudsCap, 0LL);
		                                                                                                                            HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, CloudsCap, v102, 0LL);
		                                                                                                                            Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                            CloudsFlowMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsFlowMap;
		                                                                                                                            if ( Patch )
		                                                                                                                            {
		                                                                                                                              v104 = UnityEngine::Material::GetTextureImpl((Material *)Patch, CloudsFlowMap, 0LL);
		                                                                                                                              HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, CloudsFlowMap, v104, 0LL);
		                                                                                                                              Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                              ErosionMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ErosionMap;
		                                                                                                                              if ( Patch )
		                                                                                                                              {
		                                                                                                                                v106 = UnityEngine::Material::GetTextureImpl((Material *)Patch, ErosionMap, 0LL);
		                                                                                                                                HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(propertyBlock, ErosionMap, v106, 0LL);
		                                                                                                                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                                                                                                                                Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                                v107 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                                                                                                                                DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP = v107->DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP;
		                                                                                                                                if ( Patch )
		                                                                                                                                {
		                                                                                                                                  IsKeywordEnabled = UnityEngine::Material::IsKeywordEnabled((Material *)Patch, v107->CLOUDS_FLOWMAP, 0LL);
		                                                                                                                                  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		                                                                                                                                  v110 = IsKeywordEnabled;
		                                                                                                                                  v111 = mat;
		                                                                                                                                  VLB::Utils::SetKeywordEnabled(mat, DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP, v110, 0LL);
		                                                                                                                                  Patch = v12->fields.celestialConfig.advancedPlanetConfig.advancedPlanetMat;
		                                                                                                                                  v112 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                                                                                                                                  DRAW_ADVANCED_PLANET_CLOUDS_SHADOW = v112->DRAW_ADVANCED_PLANET_CLOUDS_SHADOW;
		                                                                                                                                  if ( Patch )
		                                                                                                                                  {
		                                                                                                                                    v114 = UnityEngine::Material::IsKeywordEnabled((Material *)Patch, v112->ENABLE_CLOUDS_SHADOW, 0LL);
		                                                                                                                                    VLB::Utils::SetKeywordEnabled(v111, DRAW_ADVANCED_PLANET_CLOUDS_SHADOW, v114, 0LL);
		                                                                                                                                    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                                                                                                                                    if ( v111 )
		                                                                                                                                    {
		                                                                                                                                      UnityEngine::Material::EnableKeyword(v111, *((String **)static_fields + 66), 0LL);
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
		                                                                                                                  }
		                                                                                                                }
		                                                                                                              }
		                                                                                                            }
		                                                                                                          }
		                                                                                                        }
		                                                                                                      }
		                                                                                                    }
		                                                                                                  }
		                                                                                                }
		                                                                                              }
		                                                                                            }
		                                                                                          }
		                                                                                        }
		                                                                                      }
		                                                                                    }
		                                                                                  }
		                                                                                }
		                                                                              }
		                                                                            }
		                                                                          }
		                                                                        }
		                                                                      }
		                                                                    }
		                                                                  }
		                                                                }
		                                                              }
		                                                            }
		                                                          }
		                                                        }
		                                                      }
		                                                    }
		                                                  }
		                                                }
		                                              }
		                                            }
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_73:
		        sub_1800D8260(Patch, static_fields);
		      }
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    DRAW_ADVANCED_PLANET = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    VLB::Utils::SetKeywordEnabled(mat, DRAW_ADVANCED_PLANET, 0, 0LL);
		  }
		}
		
		private void RenderSkybox(CommandBuffer cmd, Material skyBoxMaterial, HGCamera hgCamera, bool useFullScreenDebug) {} // 0x0000000189CE5954-0x0000000189CE5C14
		// Void RenderSkybox(CommandBuffer, Material, HGCamera, Boolean)
		void HG::Rendering::Runtime::HGSkyRenderer::RenderSkybox(
		        HGSkyRenderer *this,
		        CommandBuffer *cmd,
		        Material *skyBoxMaterial,
		        HGCamera *hgCamera,
		        bool useFullScreenDebug,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *Tint; // rdx
		  Component *camera; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v14; // xmm7_8
		  float z; // ebx
		  MethodInfo *v16; // rdx
		  __m128i v17; // xmm6
		  Vector3 *SkyScale; // rax
		  __int64 v19; // xmm0_8
		  Matrix4x4 *v20; // rax
		  __int128 v21; // xmm6
		  __int128 v22; // xmm7
		  __int128 v23; // xmm8
		  __int128 v24; // xmm9
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGEnvironmentPhase *v26; // rbx
		  MaterialPropertyBlock *m_propertyBlock; // rsi
		  MaterialPropertyBlock *v28; // rax
		  Mesh *m_IcosphereMesh; // rdx
		  Vector3 v30; // [rsp+48h] [rbp-79h] BYREF
		  Vector3 v31; // [rsp+58h] [rbp-69h] BYREF
		  __m128i skyboxTintColor; // [rsp+68h] [rbp-59h] BYREF
		  Matrix4x4 v33[2]; // [rsp+78h] [rbp-49h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1519, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = (Component *)hgCamera->fields.camera;
		      if ( camera )
		      {
		        transform = UnityEngine::Component::get_transform(camera, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position(&v31, transform, 0LL);
		          v14 = *(_QWORD *)&position->x;
		          z = position->z;
		          v17 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity(
		                                                   (Quaternion *)&skyboxTintColor,
		                                                   v16));
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		          SkyScale = HG::Rendering::Runtime::HGSkyRenderer::GetSkyScale(&v31, hgCamera, 0LL);
		          skyboxTintColor = v17;
		          v19 = *(_QWORD *)&SkyScale->x;
		          *(float *)&SkyScale = SkyScale->z;
		          *(_QWORD *)&v30.x = v19;
		          LODWORD(v30.z) = (_DWORD)SkyScale;
		          *(_QWORD *)&v31.x = v14;
		          v31.z = z;
		          v20 = UnityEngine::Matrix4x4::TRS(v33, &v31, (Quaternion *)&skyboxTintColor, &v30, 0LL);
		          v21 = *(_OWORD *)&v20->m00;
		          v22 = *(_OWORD *)&v20->m01;
		          v23 = *(_OWORD *)&v20->m02;
		          v24 = *(_OWORD *)&v20->m03;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		          InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		          camera = (Component *)this->fields.m_propertyBlock;
		          v26 = InterpolatedPhase;
		          if ( camera )
		          {
		            UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)camera, 1, 0LL);
		            m_propertyBlock = this->fields.m_propertyBlock;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            Tint = (HGShaderIDs__StaticFields *)(unsigned int)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Tint;
		            if ( v26 )
		            {
		              if ( m_propertyBlock )
		              {
		                skyboxTintColor = (__m128i)v26->fields.skyConfig.skyboxTintColor;
		                UnityEngine::MaterialPropertyBlock::SetColor(
		                  m_propertyBlock,
		                  (int32_t)Tint,
		                  (Color *)&skyboxTintColor,
		                  0LL);
		                camera = (Component *)this->fields.m_propertyBlock;
		                Tint = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                if ( camera )
		                {
		                  UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                    (MaterialPropertyBlock *)camera,
		                    Tint->_Exposure,
		                    v26->fields.lightConfig.preExposure * v26->fields.skyConfig.skyboxBrightness,
		                    0LL);
		                  camera = (Component *)this->fields.m_propertyBlock;
		                  Tint = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  if ( camera )
		                  {
		                    UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                      (MaterialPropertyBlock *)camera,
		                      Tint->_Rotation,
		                      v26->fields.skyConfig.skyboxRotation,
		                      0LL);
		                    HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		                      this->fields.m_propertyBlock,
		                      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Tex,
		                      (Texture *)v26->fields.skyConfig.skyboxCubeMap,
		                      0LL);
		                    v28 = this->fields.m_propertyBlock;
		                    if ( cmd )
		                    {
		                      m_IcosphereMesh = this->fields.m_IcosphereMesh;
		                      *(_OWORD *)&v33[0].m00 = v21;
		                      *(_OWORD *)&v33[0].m01 = v22;
		                      *(_OWORD *)&v33[0].m02 = v23;
		                      *(_OWORD *)&v33[0].m03 = v24;
		                      UnityEngine::Rendering::CommandBuffer::DrawMesh(
		                        cmd,
		                        m_IcosphereMesh,
		                        v33,
		                        skyBoxMaterial,
		                        0,
		                        0,
		                        v28,
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
		    }
		LABEL_13:
		    sub_1800D8260(camera, Tint);
		  }
		  camera = (Component *)IFix::WrappersManagerImpl::GetPatch(1519, 0LL);
		  if ( !camera )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_620(
		    (ILFixDynamicMethodWrapper_2 *)camera,
		    (Object *)this,
		    (Object *)cmd,
		    (Object *)skyBoxMaterial,
		    (Object *)hgCamera,
		    useFullScreenDebug,
		    0LL);
		}
		
		private void SetProceduralRingMaterial(MaterialPropertyBlock propertyBlock, HGEnvironmentPhase envPhase) {} // 0x0000000189CE6514-0x0000000189CE6AA0
		// Void SetProceduralRingMaterial(MaterialPropertyBlock, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetProceduralRingMaterial(
		        HGSkyRenderer *this,
		        MaterialPropertyBlock *propertyBlock,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  MethodInfo *v7; // rdx
		  __int64 v8; // rcx
		  __m128 v9; // xmm6
		  __m128i v10; // xmm7
		  __m128 v11; // xmm11
		  float width; // xmm2_4
		  Quaternion v13; // xmm1
		  int v14; // r8d
		  Material *m_proceduralSkyMaterial; // rdi
		  String *s_Ring; // rsi
		  TileBase *v17; // rdx
		  Vector3Int *v18; // r8
		  ITilemap *v19; // r9
		  float v20; // xmm1_4
		  MethodInfo *v21; // r8
		  Color *v22; // rax
		  int32_t v23; // r10d
		  __int64 v24; // xmm9_8
		  __int64 v25; // xmm8_8
		  float z; // r14d
		  float v27; // esi
		  __int64 v28; // xmm7_8
		  float v29; // edi
		  MethodInfo *v30; // rdx
		  Vector3 *v31; // rax
		  __int64 v32; // xmm3_8
		  Vector3 *v33; // rax
		  __int64 v34; // xmm10_8
		  float v35; // r15d
		  MethodInfo *v36; // rdx
		  Vector3 *fwd; // rax
		  __int64 v38; // xmm3_8
		  Vector3 *v39; // rax
		  __int64 v40; // xmm6_8
		  float v41; // ebx
		  MethodInfo *v42; // rdx
		  Vector3 *v43; // rax
		  __int64 v44; // xmm1_8
		  Vector3 *v45; // rax
		  __int64 v46; // xmm7_8
		  float v47; // edi
		  __m128i v48; // xmm6
		  int32_t RingUpWithBelow; // ebx
		  MethodInfo *v50; // r8
		  int32_t v51; // r10d
		  String *v52; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v54; // [rsp+20h] [rbp-E0h]
		  Vector4 v55; // [rsp+30h] [rbp-D0h] BYREF
		  Color v56; // [rsp+40h] [rbp-C0h] BYREF
		  Vector3 right; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 forward; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 up; // [rsp+70h] [rbp-90h] BYREF
		  Vector4 v60[3]; // [rsp+80h] [rbp-80h] BYREF
		  __m256i v61; // [rsp+B0h] [rbp-50h]
		  __m256i v62; // [rsp+F0h] [rbp-10h]
		
		  *(_QWORD *)&up.x = 0LL;
		  up.z = 0.0;
		  *(_QWORD *)&forward.x = 0LL;
		  forward.z = 0.0;
		  *(_QWORD *)&right.x = 0LL;
		  right.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1511, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1511, 0LL);
		    if ( !Patch )
		      goto LABEL_13;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)propertyBlock,
		      (Object *)envPhase,
		      0LL);
		  }
		  else
		  {
		    if ( !envPhase )
		      goto LABEL_13;
		    v9 = *(__m128 *)&envPhase->fields.celestialConfig.moonConfig.ring.outerRadius;
		    v10 = *(__m128i *)&envPhase->fields.celestialConfig.moonConfig.ring.ringColor.b;
		    v11 = *(__m128 *)&envPhase->fields.celestialConfig.moonConfig.radius;
		    *(__m128 *)v62.m256i_i8 = v9;
		    *(__m128i *)&v62.m256i_u64[2] = v10;
		    *(__m128 *)v61.m256i_i8 = v9;
		    *(__m128i *)&v61.m256i_u64[2] = v10;
		    if ( !envPhase->fields.celestialConfig.moonConfig.enableRing
		      || (width = envPhase->fields.celestialConfig.moonConfig.ring.width,
		          *(__m128i *)&v61.m256i_u64[2] = v10,
		          width == 0.0) )
		    {
		      v14 = 0;
		    }
		    else
		    {
		      *(__m128 *)v61.m256i_i8 = v9;
		      *(__m128i *)&v61.m256i_u64[2] = v10;
		      v13 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v55, v7);
		      v60[0] = *(Vector4 *)&v61.m256i_u64[1];
		      v55 = (Vector4)v13;
		      v14 = (unsigned __int8)sub_182FA61B0(v60, &v55) ^ 1;
		    }
		    m_proceduralSkyMaterial = this->fields.m_proceduralSkyMaterial;
		    if ( v14 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      s_Ring = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      if ( m_proceduralSkyMaterial )
		      {
		        UnityEngine::Material::EnableKeyword(m_proceduralSkyMaterial, s_Ring, 0LL);
		        UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v55, v17, v18, v19, v54);
		        *(_QWORD *)&v55.z = 0x3F8000003F800000LL;
		        v20 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
		        v55.x = v11.m128_f32[0] / v20;
		        v55.y = (float)-(float)(v9.m128_f32[0] - v20) / v20;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        v60[0] = *(Vector4 *)&v62.m256i_u64[1];
		        v22 = UnityEngine::Color::op_Implicit(&v56, v60, v21);
		        if ( propertyBlock )
		        {
		          v60[0] = *(Vector4 *)v22;
		          UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v23, v60, 0LL);
		          HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		            propertyBlock,
		            TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingAlbedoTexture,
		            (Texture *)_mm_srli_si128(v10, 8).m128i_i64[0],
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		          HG::Rendering::Runtime::HGCelestialConfig::GetMapWorldSpaceBasisInPlanetSpace(
		            &envPhase->fields.celestialConfig,
		            &up,
		            &forward,
		            &right,
		            0LL);
		          v24 = *(_QWORD *)&right.x;
		          v25 = *(_QWORD *)&forward.x;
		          z = right.z;
		          v27 = forward.z;
		          v28 = *(_QWORD *)&up.x;
		          v29 = up.z;
		          *(_QWORD *)&v56.r = *(_QWORD *)&right.x;
		          v56.b = right.z;
		          right = forward;
		          forward = up;
		          v31 = UnityEngine::Vector3::get_up((Vector3 *)v60, v30);
		          v32 = *(_QWORD *)&v31->x;
		          up.z = v31->z;
		          *(_QWORD *)&up.x = v32;
		          v33 = HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		                  (Vector3 *)v60,
		                  &up,
		                  &forward,
		                  &right,
		                  (Vector3 *)&v56,
		                  0LL);
		          *(_QWORD *)&v56.r = v24;
		          v56.b = z;
		          *(_QWORD *)&up.x = v25;
		          v34 = *(_QWORD *)&v33->x;
		          v35 = v33->z;
		          up.z = v27;
		          *(_QWORD *)&forward.x = v28;
		          forward.z = v29;
		          fwd = UnityEngine::Vector3::get_fwd((Vector3 *)v60, v36);
		          v38 = *(_QWORD *)&fwd->x;
		          right.z = fwd->z;
		          *(_QWORD *)&right.x = v38;
		          v39 = HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		                  (Vector3 *)v60,
		                  &right,
		                  &forward,
		                  &up,
		                  (Vector3 *)&v56,
		                  0LL);
		          *(_QWORD *)&v56.r = v24;
		          v56.b = z;
		          *(_QWORD *)&up.x = v25;
		          v40 = *(_QWORD *)&v39->x;
		          v41 = v39->z;
		          up.z = v27;
		          *(_QWORD *)&forward.x = v28;
		          forward.z = v29;
		          v43 = UnityEngine::Vector3::get_right((Vector3 *)v60, v42);
		          v44 = *(_QWORD *)&v43->x;
		          right.z = v43->z;
		          *(_QWORD *)&right.x = v44;
		          v45 = HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		                  (Vector3 *)v60,
		                  &right,
		                  &forward,
		                  &up,
		                  (Vector3 *)&v56,
		                  0LL);
		          v46 = *(_QWORD *)&v45->x;
		          v47 = v45->z;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          *(_QWORD *)&v56.r = v40;
		          v56.b = v41;
		          v48 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                   v60,
		                                                   (Vector3 *)&v56,
		                                                   1.0,
		                                                   0LL));
		          UnityEngine::MaterialPropertyBlock::SetVector(
		            propertyBlock,
		            TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingParams,
		            &v55,
		            0LL);
		          *(_QWORD *)&v56.r = v34;
		          v56.b = v35;
		          RingUpWithBelow = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingUpWithBelow;
		          v55 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                   &v55,
		                   (Vector3 *)&v56,
		                   _mm_shuffle_ps(v11, v11, 255).m128_f32[0],
		                   0LL);
		          UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, RingUpWithBelow, &v55, 0LL);
		          v55 = (Vector4)v48;
		          UnityEngine::MaterialPropertyBlock::SetVector(
		            propertyBlock,
		            TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingFoward,
		            &v55,
		            0LL);
		          *(_QWORD *)&v56.r = v46;
		          v56.b = v47;
		          v55 = *UnityEngine::Vector4::op_Implicit(&v55, (Vector3 *)&v56, v50);
		          UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v51, &v55, 0LL);
		          return;
		        }
		      }
		LABEL_13:
		      sub_1800D8260(v8, v7);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    v52 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    VLB::Utils::SetKeywordEnabled(m_proceduralSkyMaterial, v52, 0, 0LL);
		  }
		}
		
		private void SetProceduralRingMaterialCPP(Material mat, HGEnvironmentPhase envPhase) {} // 0x0000000189CE5F50-0x0000000189CE6514
		// Void SetProceduralRingMaterialCPP(Material, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetProceduralRingMaterialCPP(
		        HGSkyRenderer *this,
		        Material *mat,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  MethodInfo *v7; // rdx
		  __int64 v8; // rcx
		  __m128 v9; // xmm6
		  __m128i v10; // xmm7
		  __m128 v11; // xmm11
		  float width; // xmm2_4
		  Quaternion v13; // xmm1
		  int v14; // r8d
		  Material *m_proceduralSkyMaterial; // rdi
		  String *v16; // rsi
		  TileBase *v17; // rdx
		  Vector3Int *v18; // r8
		  ITilemap *v19; // r9
		  float v20; // xmm1_4
		  MethodInfo *v21; // r8
		  Color *v22; // rax
		  int32_t v23; // r10d
		  Texture *v24; // xmm7_8
		  __int64 v25; // xmm9_8
		  __int64 v26; // xmm8_8
		  float z; // r14d
		  float v28; // esi
		  __int64 v29; // xmm7_8
		  float v30; // edi
		  MethodInfo *v31; // rdx
		  Vector3 *v32; // rax
		  __int64 v33; // xmm3_8
		  Vector3 *v34; // rax
		  __int64 v35; // xmm10_8
		  float v36; // r15d
		  MethodInfo *v37; // rdx
		  Vector3 *fwd; // rax
		  __int64 v39; // xmm3_8
		  Vector3 *v40; // rax
		  __int64 v41; // xmm6_8
		  float v42; // ebx
		  MethodInfo *v43; // rdx
		  Vector3 *v44; // rax
		  __int64 v45; // xmm1_8
		  Vector3 *v46; // rax
		  __int64 v47; // xmm7_8
		  float v48; // edi
		  __m128i v49; // xmm6
		  int32_t RingUpWithBelow; // ebx
		  MethodInfo *v51; // r8
		  int32_t v52; // r10d
		  String *s_Ring; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v55; // [rsp+20h] [rbp-E0h]
		  Vector4 v56; // [rsp+30h] [rbp-D0h] BYREF
		  Color v57; // [rsp+40h] [rbp-C0h] BYREF
		  Vector3 right; // [rsp+50h] [rbp-B0h] BYREF
		  Vector3 forward; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 up; // [rsp+70h] [rbp-90h] BYREF
		  Vector4 v61[3]; // [rsp+80h] [rbp-80h] BYREF
		  __m256i v62; // [rsp+B0h] [rbp-50h]
		  __m256i v63; // [rsp+F0h] [rbp-10h]
		
		  *(_QWORD *)&up.x = 0LL;
		  up.z = 0.0;
		  *(_QWORD *)&forward.x = 0LL;
		  forward.z = 0.0;
		  *(_QWORD *)&right.x = 0LL;
		  right.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1523, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1523, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)mat,
		        (Object *)envPhase,
		        0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !envPhase )
		    goto LABEL_15;
		  v9 = *(__m128 *)&envPhase->fields.celestialConfig.moonConfig.ring.outerRadius;
		  v10 = *(__m128i *)&envPhase->fields.celestialConfig.moonConfig.ring.ringColor.b;
		  v11 = *(__m128 *)&envPhase->fields.celestialConfig.moonConfig.radius;
		  *(__m128 *)v63.m256i_i8 = v9;
		  *(__m128i *)&v63.m256i_u64[2] = v10;
		  *(__m128 *)v62.m256i_i8 = v9;
		  *(__m128i *)&v62.m256i_u64[2] = v10;
		  if ( !envPhase->fields.celestialConfig.moonConfig.enableRing
		    || (width = envPhase->fields.celestialConfig.moonConfig.ring.width, *(__m128i *)&v62.m256i_u64[2] = v10,
		                                                                        width == 0.0) )
		  {
		    v14 = 0;
		  }
		  else
		  {
		    *(__m128 *)v62.m256i_i8 = v9;
		    *(__m128i *)&v62.m256i_u64[2] = v10;
		    v13 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v56, v7);
		    v61[0] = *(Vector4 *)&v62.m256i_u64[1];
		    v56 = (Vector4)v13;
		    v14 = (unsigned __int8)sub_182FA61B0(v61, &v56) ^ 1;
		  }
		  m_proceduralSkyMaterial = this->fields.m_proceduralSkyMaterial;
		  if ( !v14 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    s_Ring = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    VLB::Utils::SetKeywordEnabled(m_proceduralSkyMaterial, s_Ring, 0, 0LL);
		    return;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		  v16 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  if ( !m_proceduralSkyMaterial )
		    goto LABEL_15;
		  UnityEngine::Material::EnableKeyword(m_proceduralSkyMaterial, v16, 0LL);
		  UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v56, v17, v18, v19, v55);
		  *(_QWORD *)&v56.z = 0x3F8000003F800000LL;
		  v20 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
		  v56.x = v11.m128_f32[0] / v20;
		  v56.y = (float)-(float)(v9.m128_f32[0] - v20) / v20;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v61[0] = *(Vector4 *)&v63.m256i_u64[1];
		  v22 = UnityEngine::Color::op_Implicit(&v57, v61, v21);
		  if ( !mat )
		    goto LABEL_15;
		  v61[0] = *(Vector4 *)v22;
		  UnityEngine::Material::SetVector(mat, v23, v61, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  v24 = (Texture *)_mm_srli_si128(v10, 8).m128i_u64[0];
		  if ( UnityEngine::Object::op_Inequality((Object_1 *)v24, 0LL, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    UnityEngine::Material::SetTextureImpl(
		      mat,
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingAlbedoTexture,
		      v24,
		      0LL);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		  HG::Rendering::Runtime::HGCelestialConfig::GetMapWorldSpaceBasisInPlanetSpace(
		    &envPhase->fields.celestialConfig,
		    &up,
		    &forward,
		    &right,
		    0LL);
		  v25 = *(_QWORD *)&right.x;
		  v26 = *(_QWORD *)&forward.x;
		  z = right.z;
		  v28 = forward.z;
		  v29 = *(_QWORD *)&up.x;
		  v30 = up.z;
		  *(_QWORD *)&v57.r = *(_QWORD *)&right.x;
		  v57.b = right.z;
		  right = forward;
		  forward = up;
		  v32 = UnityEngine::Vector3::get_up((Vector3 *)v61, v31);
		  v33 = *(_QWORD *)&v32->x;
		  up.z = v32->z;
		  *(_QWORD *)&up.x = v33;
		  v34 = HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		          (Vector3 *)v61,
		          &up,
		          &forward,
		          &right,
		          (Vector3 *)&v57,
		          0LL);
		  *(_QWORD *)&v57.r = v25;
		  v57.b = z;
		  *(_QWORD *)&up.x = v26;
		  v35 = *(_QWORD *)&v34->x;
		  v36 = v34->z;
		  up.z = v28;
		  *(_QWORD *)&forward.x = v29;
		  forward.z = v30;
		  fwd = UnityEngine::Vector3::get_fwd((Vector3 *)v61, v37);
		  v39 = *(_QWORD *)&fwd->x;
		  right.z = fwd->z;
		  *(_QWORD *)&right.x = v39;
		  v40 = HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		          (Vector3 *)v61,
		          &right,
		          &forward,
		          &up,
		          (Vector3 *)&v57,
		          0LL);
		  *(_QWORD *)&v57.r = v25;
		  v57.b = z;
		  *(_QWORD *)&up.x = v26;
		  v41 = *(_QWORD *)&v40->x;
		  v42 = v40->z;
		  up.z = v28;
		  *(_QWORD *)&forward.x = v29;
		  forward.z = v30;
		  v44 = UnityEngine::Vector3::get_right((Vector3 *)v61, v43);
		  v45 = *(_QWORD *)&v44->x;
		  right.z = v44->z;
		  *(_QWORD *)&right.x = v45;
		  v46 = HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		          (Vector3 *)v61,
		          &right,
		          &forward,
		          &up,
		          (Vector3 *)&v57,
		          0LL);
		  v47 = *(_QWORD *)&v46->x;
		  v48 = v46->z;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_QWORD *)&v57.r = v41;
		  v57.b = v42;
		  v49 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(v61, (Vector3 *)&v57, 1.0, 0LL));
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  UnityEngine::Material::SetVector(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingParams,
		    &v56,
		    0LL);
		  *(_QWORD *)&v57.r = v35;
		  v57.b = v36;
		  RingUpWithBelow = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingUpWithBelow;
		  v56 = *HG::Rendering::Runtime::HGUtils::PackVector4(
		           &v56,
		           (Vector3 *)&v57,
		           _mm_shuffle_ps(v11, v11, 255).m128_f32[0],
		           0LL);
		  UnityEngine::Material::SetVector(mat, RingUpWithBelow, &v56, 0LL);
		  v56 = (Vector4)v49;
		  UnityEngine::Material::SetVector(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingFoward,
		    &v56,
		    0LL);
		  *(_QWORD *)&v57.r = v47;
		  v57.b = v48;
		  v56 = *UnityEngine::Vector4::op_Implicit(&v56, (Vector3 *)&v57, v51);
		  UnityEngine::Material::SetVector(mat, v52, &v56, 0LL);
		}
		
		internal void SetupShaderVariablesGlobalCloudShadow(ref ShaderVariablesGlobal cb, HGEnvironmentPhase envPhase) {} // 0x0000000189CE9404-0x0000000189CE97DC
		// Void SetupShaderVariablesGlobalCloudShadow(ShaderVariablesGlobal ByRef, HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGSkyRenderer::SetupShaderVariablesGlobalCloudShadow(
		        HGSkyRenderer *this,
		        ShaderVariablesGlobal *cb,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  float v4; // xmm1_4
		  TileBase *v8; // rdx
		  Beyond::DampingMath *v9; // rcx
		  Vector3Int *v10; // r8
		  ITilemap *v11; // r9
		  float x; // xmm0_4
		  MethodInfo *v13; // rdx
		  float v14; // xmm0_4
		  float v15; // xmm15_4
		  Vector3 *fwd; // rax
		  __int64 v17; // xmm3_8
		  Quaternion rotationCloudShadow; // xmm0
		  Vector3 *v19; // rax
		  MethodInfo *v20; // r9
		  Vector3 *v21; // rax
		  __m128 v22; // xmm14
		  float z; // ebx
		  Vector2 v24; // rdx
		  Vector2 v25; // r8
		  int32_t v26; // r9d
		  Vector2 v27; // rax
		  float cloudShadowCoverage; // xmm2_4
		  __int64 v29; // xmm1_8
		  __m128 x_low; // xmm13
		  __m128 y_low; // xmm12
		  __int64 v32; // rcx
		  __m128 v33; // xmm11
		  __m128 v34; // xmm10
		  __m128d v35; // xmm6
		  __m128i v36; // xmm7
		  Vector4 *v37; // rax
		  float v38; // xmm2_4
		  Vector4 *v39; // rax
		  __m128i v40; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v42; // [rsp+28h] [rbp-E0h]
		  Vector3 v43; // [rsp+38h] [rbp-D0h] BYREF
		  Vector3 v44; // [rsp+48h] [rbp-C0h] BYREF
		  Quaternion v45[4]; // [rsp+58h] [rbp-B0h] BYREF
		  float v46[56]; // [rsp+98h] [rbp-70h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1524, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1524, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)envPhase, 0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(v9, v8);
		  }
		  if ( !envPhase )
		    goto LABEL_15;
		  if ( envPhase->fields.cloudConfig.enable && envPhase->fields.cloudConfig.enableCloudShadow )
		  {
		    if ( envPhase->fields.lightConfig.cloudShadowPitchYawMode == 1 )
		      x = envPhase->fields.lightConfig.cloudShadowPitchYaw.x;
		    else
		      x = envPhase->fields.lightConfig.directPitchYawRuntime.x;
		    Beyond::DampingMath::cosf(v9, v4);
		    v14 = fabs(x / 360.0);
		    if ( v14 < 0.001 )
		    {
		      v14 = 0.001;
		    }
		    else if ( v14 > 1.0 )
		    {
		      v14 = 1.0;
		    }
		    v15 = 1.0 / v14;
		    fwd = UnityEngine::Vector3::get_fwd(&v43, v13);
		    v17 = *(_QWORD *)&fwd->x;
		    rotationCloudShadow = envPhase->fields.lightConfig.rotationCloudShadow;
		    *(float *)&fwd = fwd->z;
		    *(_QWORD *)&v44.x = v17;
		    LODWORD(v44.z) = (_DWORD)fwd;
		    v45[0] = rotationCloudShadow;
		    v19 = UnityEngine::Quaternion::op_Multiply(&v43, v45, &v44, 0LL);
		    *(_QWORD *)&rotationCloudShadow.x = *(_QWORD *)&v19->x;
		    *(float *)&v19 = v19->z;
		    *(_QWORD *)&v44.x = *(_QWORD *)&rotationCloudShadow.x;
		    LODWORD(v44.z) = (_DWORD)v19;
		    v21 = UnityEngine::Vector3::op_Multiply(&v43, v15, &v44, v20);
		    v22 = *(__m128 *)&envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
		    z = v21->z;
		    *(_QWORD *)&v44.x = *(_QWORD *)&v21->x;
		    *(_QWORD *)v46 = *(_QWORD *)&envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		    v27 = sub_1858CACF0(_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0], v24, v25, v26);
		    cloudShadowCoverage = envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowCoverage;
		    v29 = *(_QWORD *)&envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		    *(Vector2 *)&v43.x = v27;
		    x_low = (__m128)LODWORD(v27.x);
		    y_low = (__m128)LODWORD(v27.y);
		    x_low.m128_f32[0] = v27.x / cloudShadowCoverage;
		    y_low.m128_f32[0] = v27.y / cloudShadowCoverage;
		    *(_QWORD *)v46 = v29;
		    *(_QWORD *)&v43.x = sub_185EDD110(
		                          v32,
		                          _mm_unpacklo_ps(
		                            (__m128)LODWORD(envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.x),
		                            v22).m128_u64[0]);
		    v33 = (__m128)LODWORD(v43.x);
		    v34 = (__m128)LODWORD(v43.y);
		    v33.m128_f32[0] = v43.x / 1000.0;
		    v34.m128_f32[0] = v43.y / 1000.0;
		    v35 = *(__m128d *)&envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture;
		    v36 = *(__m128i *)&envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
		    *(_QWORD *)v46 = *(_QWORD *)&envPhase->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(_QWORD *)&v43.x = *(_OWORD *)&_mm_unpackhi_pd(v35, v35);
		    LODWORD(v43.z) = _mm_cvtsi128_si32(v36);
		    v37 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)v45, &v43, v15, 0LL);
		    v38 = v46[0] + _mm_shuffle_ps(v22, v22, 255).m128_f32[0];
		    *(__m128i *)&cb->_IVParam2.y = _mm_loadu_si128((const __m128i *)v37);
		    *(__m128i *)&cb->_IVDefaultSHAr.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                           (Vector4 *)v45,
		                                                                           _mm_shuffle_ps(v22, v22, 255).m128_f32[0],
		                                                                           v38,
		                                                                           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
		                                                                                                  x_low,
		                                                                                                  y_low),
		                                                                           0LL));
		    v39 = HG::Rendering::Runtime::HGUtils::PackVector4(
		            (Vector4 *)v45,
		            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v33, v34),
		            _mm_shuffle_ps(v22, v22, 85).m128_f32[0],
		            1.0 / _mm_shuffle_ps(v22, v22, 170).m128_f32[0],
		            0LL);
		    v44.z = z;
		    *(__m128i *)&cb->_IVDefaultshAg.y = _mm_loadu_si128((const __m128i *)v39);
		    *(__m128i *)&cb->_IVDefaultshAb.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                           (Vector4 *)v45,
		                                                                           &v44,
		                                                                           1.0,
		                                                                           0LL));
		  }
		  else
		  {
		    *(__m128i *)&cb->_IVParam2.y = _mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		    v40 = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                             (TileAnimationData *)v45,
		                                             v8,
		                                             v10,
		                                             v11,
		                                             v42));
		    *(__m128i *)&cb->_IVDefaultshAg.y = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		    *(__m128i *)&cb->_IVDefaultSHAr.y = v40;
		  }
		}
		
	}
}
