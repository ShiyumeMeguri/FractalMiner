using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.TerrainV2;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTerrainDeformManager // TypeDefIndex: 38647
	{
		// Fields
		public const int TEXTURE_SIZE = 1024; // Metadata: 0x02304045
		public const int HALF_EXTENT = 32; // Metadata: 0x02304047
		public const int HALF_DEPTH_RANGE = 32; // Metadata: 0x02304048
		public Vector3 prevCenter; // 0x10
		public Vector3 curCenter; // 0x1C
		private float m_remainDeltaTime; // 0x28
		public float deltaTime; // 0x2C
		private const int kMaxSubdWidth = 64; // Metadata: 0x02304049
		private Vector2 subdCenter; // 0x30
		private int subdWidth; // 0x38
		public HGTerrainDeformConfig deformConfig; // 0x3C
		private TerrainDeformRenderData m_terrainDeformRenderData; // 0x48
		private HGTerrainGroundLayer terrainGroundLayer; // 0x88
		public static ComputeShader s_groundLayerCS; // 0x00
	
		// Constructors
		public HGTerrainDeformManager() {} // 0x0000000182ED8480-0x0000000182ED8520
		// HGTerrainDeformManager()
		void HG::Rendering::Runtime::HGTerrainDeformManager::HGTerrainDeformManager(
		        HGTerrainDeformManager *this,
		        MethodInfo *method)
		{
		  HGTerrainGroundLayer *v3; // rax
		  __int64 v4; // rdx
		  HGTerrainGroundLayer *terrainGroundLayer; // rcx
		  HGTerrainGroundLayer *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  *(_QWORD *)&this->fields.prevCenter.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.prevCenter.z = 0.0;
		  *(_QWORD *)&this->fields.curCenter.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.curCenter.z = 0.0;
		  this->fields.subdWidth = 64;
		  this->fields.subdCenter = 0LL;
		  v3 = (HGTerrainGroundLayer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer);
		  v6 = v3;
		  if ( !v3
		    || (HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::HGTerrainGroundLayer(v3, 0LL),
		        this->fields.terrainGroundLayer = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.terrainGroundLayer, v7, v8, v9, v10),
		        (terrainGroundLayer = this->fields.terrainGroundLayer) == 0LL) )
		  {
		    sub_1800D8260(terrainGroundLayer, v4);
		  }
		  HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Initialize(terrainGroundLayer, 0LL);
		}
		
	
		// Methods
		public static void InitStaticParams(ComputeShader terrainGroundLayerCS) {} // 0x0000000184D1A3E0-0x0000000184D1A430
		// Void InitStaticParams(ComputeShader)
		void HG::Rendering::Runtime::HGTerrainDeformManager::InitStaticParams(
		        ComputeShader *terrainGroundLayerCS,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4049, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4049, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)terrainGroundLayerCS,
		      0LL);
		  }
		  else
		  {
		    TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager->static_fields->s_groundLayerCS = terrainGroundLayerCS;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager->static_fields,
		      v3,
		      v4,
		      v5,
		      v9);
		  }
		}
		
		public void Dispose() {} // 0x0000000189C216B8-0x0000000189C21714
		// Void Dispose()
		void HG::Rendering::Runtime::HGTerrainDeformManager::Dispose(HGTerrainDeformManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGTerrainGroundLayer *terrainGroundLayer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2280, 0LL) )
		  {
		    terrainGroundLayer = this->fields.terrainGroundLayer;
		    if ( terrainGroundLayer )
		    {
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Release(terrainGroundLayer, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(terrainGroundLayer, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2280, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void Tick(float deltaTime) {} // 0x00000001832E0F40-0x00000001832E0FE0
		// Void Tick(Single)
		void HG::Rendering::Runtime::HGTerrainDeformManager::Tick(
		        HGTerrainDeformManager *this,
		        float deltaTime,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float v6; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 2298 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		    if ( v4 )
		    {
		      if ( LODWORD(v4->_0.namespaze) <= 0x8FA )
		        sub_1800D2AB0(v4, wrapperArray);
		      if ( !v4[48].vtable.ToString.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2298, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		          (ILFixDynamicMethodWrapper_18 *)Patch,
		          (Object *)this,
		          deltaTime,
		          0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v4, wrapperArray);
		  }
		LABEL_5:
		  v6 = deltaTime + this->fields.m_remainDeltaTime;
		  this->fields.deltaTime = 0.0;
		  this->fields.m_remainDeltaTime = v6;
		  if ( v6 >= 0.15000001 )
		  {
		    this->fields.deltaTime = 0.15000001;
		    this->fields.m_remainDeltaTime = v6 - 0.15000001;
		  }
		}
		
		public void UpdateDeformConfig(ref HGTerrainDeformConfig config) {} // 0x0000000183C81FA0-0x0000000183C820A0
		// Void UpdateDeformConfig(HGTerrainDeformConfig ByRef)
		void HG::Rendering::Runtime::HGTerrainDeformManager::UpdateDeformConfig(
		        HGTerrainDeformManager *this,
		        HGTerrainDeformConfig *config,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  int v7; // eax
		  void (__fastcall *v8)(unsigned __int64 *); // rax
		  unsigned __int64 v9; // xmm6_8
		  void (__fastcall *v10)(unsigned __int64 *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rax
		  __int64 v13; // rax
		  unsigned __int64 v14; // [rsp+20h] [rbp-28h] BYREF
		  unsigned __int64 v15; // [rsp+68h] [rbp+20h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_12;
		  if ( wrapperArray->max_length.size > 677 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x2A5 )
		        sub_1800D2AB0(v5, config);
		      if ( !v5[14].static_fields )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(677, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_265(Patch, (Object *)this, config, 0LL);
		        return;
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v5, config);
		  }
		LABEL_5:
		  v7 = *(_DWORD *)&config->m_active;
		  *(_QWORD *)&this->fields.deformConfig.deformGlobalStrength = *(_QWORD *)&config->deformGlobalStrength;
		  *(_DWORD *)&this->fields.deformConfig.m_active = v7;
		  v8 = (void (__fastcall *)(unsigned __int64 *))qword_18F370A20;
		  v9 = _mm_unpacklo_ps((__m128)LODWORD(config->deformGlobalStrength), (__m128)LODWORD(config->latency)).m128_u64[0];
		  v15 = v9;
		  if ( !qword_18F370A20 )
		  {
		    v8 = (void (__fastcall *)(unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                    "UnityEngine.HyperGryph.HGTerrainDeformManagerV2::UpdateDeformConfig_"
		                                                    "Injected(UnityEngine.HyperGryph.HGTerrainDeformConfigV2&)");
		    if ( !v8 )
		    {
		      v12 = sub_1802EE1B8(
		              "UnityEngine.HyperGryph.HGTerrainDeformManagerV2::UpdateDeformConfig_Injected(UnityEngine.HyperGryph.HGTerr"
		              "ainDeformConfigV2&)");
		      sub_18007E1B0(v12, 0LL);
		    }
		    qword_18F370A20 = (__int64)v8;
		  }
		  v8(&v15);
		  v10 = (void (__fastcall *)(unsigned __int64 *))qword_18F370A30;
		  v14 = v9;
		  if ( !qword_18F370A30 )
		  {
		    v10 = (void (__fastcall *)(unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                     "UnityEngine.HyperGryph.HGTerrainManagerV3::UpdateDeformConfig_Injec"
		                                                     "ted(UnityEngine.HyperGryph.HGTerrainDeformConfigV2&)");
		    if ( !v10 )
		    {
		      v13 = sub_1802EE1B8(
		              "UnityEngine.HyperGryph.HGTerrainManagerV3::UpdateDeformConfig_Injected(UnityEngine.HyperGryph.HGTerrainDeformConfigV2&)");
		      sub_18007E1B0(v13, 0LL);
		    }
		    qword_18F370A30 = (__int64)v10;
		  }
		  v10(&v14);
		}
		
		public void GetTerrainDeformParams(ref ShaderVariablesGlobal cb) {} // 0x0000000189C217D0-0x0000000189C218E4
		// Void GetTerrainDeformParams(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGTerrainDeformManager::GetTerrainDeformParams(
		        HGTerrainDeformManager *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  __int64 v6; // rdx
		  HGTerrainGroundLayer *terrainGroundLayer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v9; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3410, 0LL) )
		  {
		    *(float *)&v9 = this->fields.deformConfig.deformGlobalStrength;
		    DWORD1(v9) = 1015021568;
		    *((float *)&v9 + 2) = (float)((float)-this->fields.curCenter.x * 0.015625) + 0.5;
		    *((float *)&v9 + 3) = (float)((float)-this->fields.curCenter.z * 0.015625) + 0.5;
		    v5 = v9;
		    HIDWORD(v9) = 0;
		    *(_OWORD *)&cb->_FakeSphericalLightSource.y = v5;
		    v6 = (unsigned int)(this->fields.subdWidth >> 31);
		    LODWORD(v6) = this->fields.subdWidth % 2;
		    *(Vector2 *)&v9 = this->fields.subdCenter;
		    *((float *)&v9 + 2) = (float)(this->fields.subdWidth / 2);
		    *(_OWORD *)&cb->_VolumetricComposeParams.y = v9;
		    terrainGroundLayer = this->fields.terrainGroundLayer;
		    if ( terrainGroundLayer )
		    {
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::GetTerrainDeformParams(terrainGroundLayer, cb, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(terrainGroundLayer, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3410, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		}
		
		public void SetDeformCenter(Vector3 centerPosition) {} // 0x00000001833399A0-0x0000000183339AD0
		// Void SetDeformCenter(Vector3)
		void HG::Rendering::Runtime::HGTerrainDeformManager::SetDeformCenter(
		        HGTerrainDeformManager *this,
		        Vector3 *centerPosition,
		        MethodInfo *method)
		{
		  Camera *main; // rax
		  struct Object_1__Class *v6; // rcx
		  Camera *v7; // rdi
		  __int64 (__fastcall *v8)(Camera *); // rax
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v11; // rdi
		  void (__fastcall *v12)(__int64, Vector3 *); // rax
		  float z; // eax
		  float v14; // eax
		  __int64 v15; // rax
		  __int64 v16; // rax
		  float v17; // eax
		  Vector3 v18[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4050, 0LL) )
		  {
		    main = UnityEngine::Camera::get_main(0LL);
		    v6 = TypeInfo::UnityEngine::Object;
		    v7 = main;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v6 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !v7 )
		      goto LABEL_11;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v6);
		    if ( !v7->fields._._._.m_CachedPtr )
		      goto LABEL_11;
		    v8 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v8 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v8 )
		      {
		        v15 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v15, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v8;
		    }
		    v11 = v8(v7);
		    if ( v11 )
		    {
		      *(_QWORD *)&v18[0].x = 0LL;
		      v18[0].z = 0.0;
		      v12 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v12 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        if ( !v12 )
		        {
		          v16 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v16, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v12;
		      }
		      v12(v11, v18);
		      z = v18[0].z;
		      *(_QWORD *)&centerPosition->x = *(_QWORD *)&v18[0].x;
		      centerPosition->z = z;
		LABEL_11:
		      v14 = centerPosition->z;
		      *(_QWORD *)&v18[0].x = *(_QWORD *)&centerPosition->x;
		      v18[0].z = v14;
		      HG::Rendering::Runtime::HGTerrainDeformManager::SetPlayerCenter(this, v18, 0LL);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(Patch, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4050, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  v17 = centerPosition->z;
		  *(_QWORD *)&v18[0].x = *(_QWORD *)&centerPosition->x;
		  v18[0].z = v17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, v18, 0LL);
		}
		
		public void SetPlayerCenter(Vector3 centerPosition) {} // 0x0000000183339AD0-0x0000000183339CB0
		// Void SetPlayerCenter(Vector3)
		void HG::Rendering::Runtime::HGTerrainDeformManager::SetPlayerCenter(
		        HGTerrainDeformManager *this,
		        Vector3 *centerPosition,
		        MethodInfo *method)
		{
		  float v3; // xmm1_4
		  System::MathF *v6; // rcx
		  float v7; // eax
		  __m128 x_low; // xmm0
		  __m128 v9; // xmm7
		  __int128 y_low; // xmm0
		  System::MathF *v11; // rcx
		  __m128 v12; // xmm6
		  System::MathF *v13; // rcx
		  System::MathF *v14; // rcx
		  System::MathF *v15; // rcx
		  float v16; // xmm0_4
		  __int64 (__fastcall *v17)(_QWORD); // rax
		  int v18; // eax
		  __int64 v19; // rdx
		  int32_t v20; // ecx
		  HGTerrainGroundLayer *terrainGroundLayer; // rcx
		  float v22; // eax
		  __int64 v23; // xmm0_8
		  void (__fastcall *v24)(__int64 *); // rax
		  __int64 v25; // xmm0_8
		  void (__fastcall *v26)(Vector3 *); // rax
		  __int64 v27; // rax
		  __int64 v28; // rax
		  __int64 v29; // rax
		  __int64 v30; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v33; // [rsp+20h] [rbp-68h] BYREF
		  __int64 v34; // [rsp+30h] [rbp-58h] BYREF
		  float v35; // [rsp+38h] [rbp-50h]
		  Vector3 v36; // [rsp+40h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4051, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4051, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v30);
		    z = centerPosition->z;
		    *(_QWORD *)&v36.x = *(_QWORD *)&centerPosition->x;
		    v36.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, &v36, 0LL);
		  }
		  else
		  {
		    v7 = this->fields.curCenter.z;
		    *(_QWORD *)&this->fields.prevCenter.x = *(_QWORD *)&this->fields.curCenter.x;
		    x_low = (__m128)LODWORD(centerPosition->x);
		    x_low.m128_f32[0] = x_low.m128_f32[0] / 6.25;
		    this->fields.prevCenter.z = v7;
		    System::MathF::Floor(v6, v3);
		    v9 = x_low;
		    y_low = LODWORD(centerPosition->y);
		    *(float *)&y_low = *(float *)&y_low / 6.25;
		    v9.m128_f32[0] = v9.m128_f32[0] * 6.25;
		    System::MathF::Floor(v11, v3);
		    v12 = (__m128)y_low;
		    *(float *)&y_low = centerPosition->z / 6.25;
		    v12.m128_f32[0] = v12.m128_f32[0] * 6.25;
		    System::MathF::Floor(v13, v3);
		    *(_QWORD *)&this->fields.curCenter.x = _mm_unpacklo_ps(v9, v12).m128_u64[0];
		    this->fields.curCenter.z = *(float *)&y_low * 6.25;
		    *(float *)&y_low = this->fields.curCenter.x;
		    System::MathF::Floor(v14, v3);
		    v12.m128_i32[0] = y_low;
		    *(float *)&y_low = this->fields.curCenter.z;
		    System::MathF::Floor(v15, v3);
		    LODWORD(this->fields.subdCenter.y) = y_low;
		    LODWORD(this->fields.subdCenter.x) = v12.m128_i32[0];
		    v16 = sub_1801D3680();
		    v17 = (__int64 (__fastcall *)(_QWORD))qword_18F36FAE8;
		    if ( !qword_18F36FAE8 )
		    {
		      v17 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Mathf::NextPowerOfTwo(System.Int32)");
		      if ( !v17 )
		      {
		        v27 = sub_1802EE1B8("UnityEngine.Mathf::NextPowerOfTwo(System.Int32)");
		        sub_18007E1B0(v27, 0LL);
		      }
		      qword_18F36FAE8 = (__int64)v17;
		    }
		    v18 = v17((unsigned int)(int)v16);
		    v20 = 64;
		    if ( v18 < 64 )
		      v20 = v18;
		    this->fields.subdWidth = v20;
		    terrainGroundLayer = this->fields.terrainGroundLayer;
		    if ( !terrainGroundLayer )
		      sub_1800D8260(0LL, v19);
		    v22 = centerPosition->z;
		    *(_QWORD *)&v33.x = *(_QWORD *)&centerPosition->x;
		    v33.z = v22;
		    HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::SetPlayerCenter(terrainGroundLayer, &v33, 0LL);
		    v23 = *(_QWORD *)&centerPosition->x;
		    v35 = centerPosition->z;
		    v24 = (void (__fastcall *)(__int64 *))qword_18F370A18;
		    v34 = v23;
		    if ( !qword_18F370A18 )
		    {
		      v24 = (void (__fastcall *)(__int64 *))il2cpp_resolve_icall_1(
		                                              "UnityEngine.HyperGryph.HGTerrainDeformManagerV2::SetPlayerCenter_Injected("
		                                              "UnityEngine.Vector3&)");
		      if ( !v24 )
		      {
		        v28 = sub_1802EE1B8("UnityEngine.HyperGryph.HGTerrainDeformManagerV2::SetPlayerCenter_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v28, 0LL);
		      }
		      qword_18F370A18 = (__int64)v24;
		    }
		    v24(&v34);
		    v25 = *(_QWORD *)&centerPosition->x;
		    v36.z = centerPosition->z;
		    v26 = (void (__fastcall *)(Vector3 *))qword_18F370A28;
		    *(_QWORD *)&v36.x = v25;
		    if ( !qword_18F370A28 )
		    {
		      v26 = (void (__fastcall *)(Vector3 *))il2cpp_resolve_icall_1(
		                                              "UnityEngine.HyperGryph.HGTerrainManagerV3::SetPlayerCenter_Injected(UnityEngine.Vector3&)");
		      if ( !v26 )
		      {
		        v29 = sub_1802EE1B8("UnityEngine.HyperGryph.HGTerrainManagerV3::SetPlayerCenter_Injected(UnityEngine.Vector3&)");
		        sub_18007E1B0(v29, 0LL);
		      }
		      qword_18F370A28 = (__int64)v26;
		    }
		    v26(&v36);
		  }
		}
		
		public void RenderGroundLayer(HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189C218E4-0x0000000189C21968
		// Void RenderGroundLayer(HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::HGTerrainDeformManager::RenderGroundLayer(
		        HGTerrainDeformManager *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGTerrainGroundLayer *terrainGroundLayer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3420, 0LL) )
		  {
		    terrainGroundLayer = this->fields.terrainGroundLayer;
		    if ( terrainGroundLayer )
		    {
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Render(terrainGroundLayer, renderGraph, hgCamera, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(terrainGroundLayer, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3420, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    0LL);
		}
		
		internal TerrainDeformRenderData GetRenderData() => default; // 0x0000000189C21714-0x0000000189C217D0
		// TerrainDeformRenderData GetRenderData()
		TerrainDeformRenderData *HG::Rendering::Runtime::HGTerrainDeformManager::GetRenderData(
		        TerrainDeformRenderData *__return_ptr retstr,
		        HGTerrainDeformManager *this,
		        MethodInfo *method)
		{
		  float z; // eax
		  Vector4 v6; // xmm1
		  Vector4 param2; // xmm0
		  __int64 v8; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  TerrainDeformRenderData *v12; // rax
		  Vector4 param1; // xmm1
		  TerrainDeformRenderData v15; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3417, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3417, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1234(&v15, Patch, (Object *)this, 0LL);
		    param1 = v12->constData.param1;
		    retstr->constData.param0 = v12->constData.param0;
		    param2 = v12->constData.param2;
		    retstr->constData.param1 = param1;
		    v8 = *(_QWORD *)&v12->curCenter.x;
		    z = v12->curCenter.z;
		  }
		  else
		  {
		    HG::Rendering::Runtime::TerrainDeformConstData::SetConstData(
		      &this->fields.m_terrainDeformRenderData.constData,
		      this,
		      0LL);
		    z = this->fields.curCenter.z;
		    *(_QWORD *)&this->fields.m_terrainDeformRenderData.curCenter.x = *(_QWORD *)&this->fields.curCenter.x;
		    this->fields.m_terrainDeformRenderData.curCenter.z = z;
		    v6 = this->fields.m_terrainDeformRenderData.constData.param1;
		    retstr->constData.param0 = this->fields.m_terrainDeformRenderData.constData.param0;
		    param2 = this->fields.m_terrainDeformRenderData.constData.param2;
		    retstr->constData.param1 = v6;
		    v8 = *(_QWORD *)&this->fields.m_terrainDeformRenderData.curCenter.x;
		  }
		  retstr->constData.param2 = param2;
		  *(_QWORD *)&retstr->curCenter.x = v8;
		  retstr->curCenter.z = z;
		  return retstr;
		}
		
	}
}
