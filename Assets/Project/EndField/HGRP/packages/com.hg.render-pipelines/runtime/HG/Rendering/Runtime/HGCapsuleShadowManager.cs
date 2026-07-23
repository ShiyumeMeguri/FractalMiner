using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGCapsuleShadowManager // TypeDefIndex: 37825
	{
		// Fields
		private const int MAX_CAPSULE_NUM = 256; // Metadata: 0x0230317D
		private int m_capsuleHelperNum; // 0x10
		private int m_capsuleNum; // 0x14
		private NativeArray<Vector4> m_capsuleShadowData1; // 0x18
		private NativeArray<Vector4> m_capsuleShadowData2; // 0x28
		private NativeArray<Vector4> m_capsuleShadowData3; // 0x38
		private NativeArray<Vector4> m_capsuleShadowData4; // 0x48
		private List<HGCapsuleShadowHelper> m_capsuleShadowHelpers; // 0x58
		private NativeArray<Matrix4x4> m_capsuleStencilWriterMatrixes; // 0x60
		private Material m_capsuleShadowCasterMaterial; // 0x70
		private Mesh m_sphereMesh; // 0x78
		private MaterialPropertyBlock m_capsuleShadowPropertyBlock; // 0x80
		public Vector4 fakeSphericalLightSource; // 0x88
	
		// Properties
		public bool Enabled { get => default; } // 0x0000000189D1C9B4-0x0000000189D1CA38 
		// Boolean get_Enabled()
		bool HG::Rendering::Runtime::HGCapsuleShadowManager::get_Enabled(HGCapsuleShadowManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2083, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2083, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    if ( TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->instance )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		      return HG::Rendering::Runtime::HGCapsuleShadows::get_count(0LL) > 0;
		    }
		    else
		    {
		      return 0;
		    }
		  }
		}
		
	
		// Constructors
		public HGCapsuleShadowManager() {} // 0x0000000189D1C994-0x0000000189D1C9B4
		// HGCapsuleShadowManager()
		void HG::Rendering::Runtime::HGCapsuleShadowManager::HGCapsuleShadowManager(
		        HGCapsuleShadowManager *this,
		        MethodInfo *method)
		{
		  Vector3Int *v2; // r8
		  ITilemap *v3; // r9
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v5; // rdx
		  TileAnimationData v6; // [rsp+20h] [rbp-18h] BYREF
		
		  TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                             &v6,
		                             (TileBase *)this,
		                             v2,
		                             v3,
		                             (MethodInfo *)v6.m_AnimatedSprites);
		  *(TileAnimationData *)(v5 + 136) = *TileAnimationDataNoRef;
		}
		
	
		// Methods
		public void Initialize(Material capsuleShadowCasterMat, Mesh sphereMesh) {} // 0x0000000189D1C3F0-0x0000000189D1C5C0
		// Void Initialize(Material, Mesh)
		void HG::Rendering::Runtime::HGCapsuleShadowManager::Initialize(
		        HGCapsuleShadowManager *this,
		        Material *capsuleShadowCasterMat,
		        Mesh *sphereMesh,
		        MethodInfo *method)
		{
		  NativeArray_1_UnityEngine_Vector4_ v7; // xmm0
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  MaterialPropertyBlock *v13; // rsi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methodb; // [rsp+20h] [rbp-20h]
		  MethodInfo *methoda; // [rsp+20h] [rbp-20h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-20h]
		  NativeArray_1_UnityEngine_Vector4_ v24; // [rsp+30h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2086, 0LL) )
		  {
		    v24 = 0LL;
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		      &v24,
		      256,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		    this->fields.m_capsuleShadowData1 = v24;
		    v24 = 0LL;
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		      &v24,
		      256,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		    this->fields.m_capsuleShadowData2 = v24;
		    v24 = 0LL;
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		      &v24,
		      256,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		    this->fields.m_capsuleShadowData3 = v24;
		    v24 = 0LL;
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		      &v24,
		      256,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		    this->fields.m_capsuleShadowData4 = v24;
		    v24 = 0LL;
		    Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
		      (NativeArray_1_UnityEngine_Matrix4x4_ *)&v24,
		      256,
		      Allocator__Enum_Persistent,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
		    v7 = v24;
		    this->fields.m_capsuleShadowCasterMaterial = capsuleShadowCasterMat;
		    this->fields.m_capsuleStencilWriterMatrixes = (NativeArray_1_UnityEngine_Matrix4x4_)v7;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_capsuleShadowCasterMaterial, v8, v9, v10, methodb);
		    v13 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		    if ( v13 )
		    {
		      v13->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		      this->fields.m_capsuleShadowPropertyBlock = v13;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_capsuleShadowPropertyBlock, v14, v15, v16, methoda);
		      this->fields.m_sphereMesh = sphereMesh;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_sphereMesh, v17, v18, v19, methodc);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v12, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2086, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)capsuleShadowCasterMat,
		    (Object *)sphereMesh,
		    0LL);
		}
		
		public void Release() {} // 0x0000000189D1C5C0-0x0000000189D1C698
		// Void Release()
		void HG::Rendering::Runtime::HGCapsuleShadowManager::Release(HGCapsuleShadowManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  MaterialPropertyBlock *m_capsuleShadowPropertyBlock; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2087, 0LL) )
		  {
		    if ( this->fields.m_capsuleShadowData1.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.m_capsuleShadowData1,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.m_capsuleShadowData2.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.m_capsuleShadowData2,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.m_capsuleShadowData3.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.m_capsuleShadowData3,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.m_capsuleShadowData4.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.m_capsuleShadowData4,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.m_capsuleStencilWriterMatrixes.m_Buffer )
		      Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		        (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this->fields.m_capsuleStencilWriterMatrixes,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::Dispose);
		    m_capsuleShadowPropertyBlock = this->fields.m_capsuleShadowPropertyBlock;
		    if ( m_capsuleShadowPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::Clear(m_capsuleShadowPropertyBlock, 1, 0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(m_capsuleShadowPropertyBlock, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2087, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void FrameSetup(CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, HGCamera hgCamera) {} // 0x0000000189D1B974-0x0000000189D1C214
		// Void FrameSetup(CullingResults, LightCullResult, Int32, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGCapsuleShadowManager::FrameSetup(
		        HGCapsuleShadowManager *this,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        int32_t directionalLightIndex,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  int32_t v6; // esi
		  LightCullResult *v7; // r12
		  HGCapsuleShadowManager *v9; // rbx
		  __m128 v10; // xmm9
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo **v14; // rdx
		  Il2CppException *v15; // rcx
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *m_capsuleShadowHelpers; // rdi
		  int32_t v17; // edi
		  __m128 v18; // xmm12
		  Object *Item; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Object *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  HGCapsuleShadowHelper *v25; // r15
		  __m128 v26; // xmm6
		  __m128 v27; // xmm11
		  Matrix4x4 *CapsuleLocalToWorldMatrix; // rax
		  __m128 v29; // xmm13
		  __m128 v30; // xmm8
		  __m128 v31; // xmm6
		  __int64 v32; // rax
		  __int64 v33; // rcx
		  __int64 v34; // xmm15_8
		  __int64 v35; // rdx
		  float v36; // xmm4_4
		  float v37; // xmm5_4
		  unsigned int v38; // xmm7_4
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // r14
		  Light *light; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  __int64 v46; // xmm0_8
		  float z; // ecx
		  Vector3 *Forward; // rax
		  unsigned int v49; // xmm3_4
		  unsigned int v50; // xmm2_4
		  float m_ditherAlpha; // xmm0_4
		  Quaternion *v52; // rax
		  __m128 v53; // xmm1
		  Matrix4x4 *v54; // rax
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int128 v57; // xmm2
		  __int128 v58; // xmm3
		  __int64 v59; // rcx
		  Void *m_Buffer; // rax
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *v61; // rdx
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdi
		  MethodInfo *v65[5]; // [rsp+0h] [rbp-4A8h] BYREF
		  int32_t v66; // [rsp+40h] [rbp-468h]
		  int v67; // [rsp+44h] [rbp-464h]
		  __int64 v68; // [rsp+48h] [rbp-460h]
		  __int64 v69; // [rsp+58h] [rbp-450h]
		  __int128 v70; // [rsp+68h] [rbp-440h]
		  __int128 v71; // [rsp+78h] [rbp-430h]
		  __int128 v72; // [rsp+88h] [rbp-420h]
		  __int128 v73; // [rsp+98h] [rbp-410h]
		  Vector3 v74; // [rsp+B0h] [rbp-3F8h] BYREF
		  Vector3 v75; // [rsp+C0h] [rbp-3E8h] BYREF
		  Vector3 v76; // [rsp+D0h] [rbp-3D8h] BYREF
		  Vector3 v77; // [rsp+E0h] [rbp-3C8h] BYREF
		  Vector3 v78; // [rsp+F0h] [rbp-3B8h] BYREF
		  Il2CppException *ex; // [rsp+100h] [rbp-3A8h]
		  List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v80; // [rsp+108h] [rbp-3A0h]
		  CullingResults v81; // [rsp+110h] [rbp-398h] BYREF
		  Quaternion v82; // [rsp+120h] [rbp-388h] BYREF
		  List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ v83; // [rsp+130h] [rbp-378h] BYREF
		  Il2CppExceptionWrapper *v84; // [rsp+170h] [rbp-338h] BYREF
		  __m128 v85; // [rsp+180h] [rbp-328h]
		  HGCapsuleShadowContainer current; // [rsp+190h] [rbp-318h] BYREF
		  Vector3 v87; // [rsp+1D0h] [rbp-2D8h] BYREF
		  _BYTE v88[16]; // [rsp+1E0h] [rbp-2C8h] BYREF
		  Vector3 v89; // [rsp+1F0h] [rbp-2B8h] BYREF
		  Matrix4x4 v90; // [rsp+200h] [rbp-2A8h] BYREF
		  Quaternion v91; // [rsp+240h] [rbp-268h] BYREF
		  Matrix4x4 v92; // [rsp+250h] [rbp-258h] BYREF
		  VisibleLight v93; // [rsp+290h] [rbp-218h] BYREF
		  VisibleLight v94[2]; // [rsp+330h] [rbp-178h] BYREF
		
		  v6 = directionalLightIndex;
		  v7 = lightCullResult;
		  v9 = this;
		  sub_18033B9D0(&v83, 0LL, 64LL);
		  v10 = 0LL;
		  v68 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2088, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2088, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v63, v62);
		    v82 = (Quaternion)*v7;
		    v81 = *cullingResults;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_840(
		      Patch,
		      (Object *)v9,
		      &v81,
		      (LightCullResult *)&v82,
		      v6,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    v9->fields.m_capsuleShadowHelpers = HG::Rendering::Runtime::HGCapsuleShadows::get_capsuleShadowHelpers(0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&v9->fields.m_capsuleShadowHelpers, v11, v12, v13, v65[4]);
		    m_capsuleShadowHelpers = v9->fields.m_capsuleShadowHelpers;
		    if ( !m_capsuleShadowHelpers )
		      sub_1800D8260(v15, v14);
		    *(_QWORD *)&v9->fields.m_capsuleHelperNum = (unsigned int)m_capsuleShadowHelpers->fields._size;
		    v17 = 0;
		    v18 = (__m128)0x3F800000u;
		    while ( 1 )
		    {
		      v66 = v17;
		      if ( v17 >= v9->fields.m_capsuleHelperNum )
		        break;
		      if ( !v9->fields.m_capsuleShadowHelpers )
		        sub_1800D8260(v15, v14);
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               (List_1_System_Object_ *)v9->fields.m_capsuleShadowHelpers,
		               v17,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Item);
		      if ( !Item )
		        sub_1800D8260(v21, v20);
		      if ( UnityEngine::Behaviour::get_enabled((Behaviour *)Item, 0LL) )
		      {
		        if ( !v9->fields.m_capsuleShadowHelpers )
		          sub_1800D8260(v15, v14);
		        v22 = System::Collections::Generic::List<System::Object>::get_Item(
		                (List_1_System_Object_ *)v9->fields.m_capsuleShadowHelpers,
		                v17,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::get_Item);
		        v25 = (HGCapsuleShadowHelper *)v22;
		        if ( !v22 )
		          sub_1800D8260(v24, v23);
		        if ( !v22[1].monitor )
		          sub_1800D8260(v24, v23);
		        v83 = *(List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *)sub_1808B0EE4(
		                                                                                       &current,
		                                                                                       v22[1].monitor);
		        ex = 0LL;
		        v80 = &v83;
		        try
		        {
		          while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext(
		                    &v83,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext) )
		          {
		            v26 = *(__m128 *)&v83._current.rootTransform;
		            *(_OWORD *)&current.localOffset.x = *(_OWORD *)&v83._current.localOffset.x;
		            v27 = *(__m128 *)&v83._current.localRotation.y;
		            if ( (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v83._current.localRotation.y, 12)) )
		            {
		              if ( v9->fields.m_capsuleNum >= 256 )
		              {
		                v61 = v9->fields.m_capsuleShadowHelpers;
		                if ( !v61 )
		                  sub_1800D8250(v15, 0LL);
		                HG::Rendering::HGRPLogger::LogError<int>(
		                  (String *)"Shadow Capsule num is higher than max limit (256). Active HGCapsuleShadowHelper Num is: {0}",
		                  v61->fields._size,
		                  MethodInfo::HG::Rendering::HGRPLogger::LogError<int>);
		              }
		              else
		              {
		                if ( !v25 )
		                  sub_1800D8250(v15, v14);
		                current = v83._current;
		                CapsuleLocalToWorldMatrix = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetCapsuleLocalToWorldMatrix(
		                                              &v92,
		                                              v25,
		                                              &current,
		                                              0LL);
		                *(_OWORD *)&v90.m00 = *(_OWORD *)&CapsuleLocalToWorldMatrix->m00;
		                *(_OWORD *)&v90.m01 = *(_OWORD *)&CapsuleLocalToWorldMatrix->m01;
		                *(_OWORD *)&v90.m02 = *(_OWORD *)&CapsuleLocalToWorldMatrix->m02;
		                v29 = *(__m128 *)&CapsuleLocalToWorldMatrix->m03;
		                *(__m128 *)&v90.m03 = v29;
		                v30 = _mm_shuffle_ps(v26, v26, 170);
		                v31 = _mm_shuffle_ps(v26, v26, 255);
		                if ( v31.m128_f32[0] <= (float)(v30.m128_f32[0] + v30.m128_f32[0]) )
		                  v31 = v30;
		                *(_QWORD *)&v74.x = _mm_unpacklo_ps(v10, v18).m128_u64[0];
		                LODWORD(v74.z) = v10.m128_i32[0];
		                v75 = *UnityEngine::Matrix4x4::MultiplyVector(&v87, &v90, &v74, 0LL);
		                v32 = sub_182FAE2B0(v88, &v75);
		                v34 = *(_QWORD *)v32;
		                v68 = *(_QWORD *)v32;
		                v35 = *(unsigned int *)(v32 + 8);
		                v67 = *(_DWORD *)(v32 + 8);
		                if ( v6 == -1 )
		                {
		                  v36 = v10.m128_f32[0];
		                  v37 = v10.m128_f32[0];
		                  v38 = v18.m128_i32[0];
		                }
		                else
		                {
		                  if ( !hgCamera )
		                    sub_1800D8250(v33, v35);
		                  envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(
		                                               hgCamera,
		                                               0LL);
		                  v93 = *(VisibleLight *)((_BYTE *)v7->visibleLightsPtr + v6);
		                  light = UnityEngine::Rendering::VisibleLight::get_light(&v93, 0LL);
		                  if ( !envVolumeCameraComponent )
		                    sub_1800D8250(v42, v41);
		                  if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		                         envVolumeCameraComponent,
		                         light,
		                         0LL) )
		                  {
		                    interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                                          envVolumeCameraComponent,
		                                          0LL);
		                    if ( !interpolatedPhase )
		                      sub_1800D8250(v45, v44);
		                    v46 = *(_QWORD *)&interpolatedPhase->fields.lightConfig.forwardDirect.x;
		                    z = interpolatedPhase->fields.lightConfig.forwardDirect.z;
		                  }
		                  else
		                  {
		                    v94[0] = *(VisibleLight *)((_BYTE *)v7->visibleLightsPtr + v6);
		                    Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v89, v94, 0LL);
		                    v46 = *(_QWORD *)&Forward->x;
		                    z = Forward->z;
		                  }
		                  v69 = v46;
		                  v36 = -*(float *)&v46;
		                  v37 = -*((float *)&v46 + 1);
		                  v38 = LODWORD(z) ^ 0x80000000;
		                  LODWORD(v35) = v67;
		                }
		                LODWORD(v70) = v29.m128_i32[0];
		                v85 = _mm_shuffle_ps(v29, v29, 85);
		                DWORD1(v70) = v85.m128_i32[0];
		                v81 = (CullingResults)_mm_shuffle_ps(v29, v29, 170);
		                *((_QWORD *)&v70 + 1) = __PAIR64__(v30.m128_u32[0], (unsigned int)v81.ptr);
		                *(_OWORD *)&v9->fields.m_capsuleShadowData1.m_Buffer[16 * v9->fields.m_capsuleNum] = v70;
		                v49 = v68;
		                *(_QWORD *)&v71 = v68;
		                v50 = HIDWORD(v68);
		                DWORD2(v71) = v35;
		                *((float *)&v71 + 3) = v18.m128_f32[0] / v31.m128_f32[0];
		                *(_OWORD *)&v9->fields.m_capsuleShadowData2.m_Buffer[16 * v9->fields.m_capsuleNum] = v71;
		                m_ditherAlpha = v25->fields.m_ditherAlpha;
		                *(_QWORD *)&v72 = __PAIR64__(LODWORD(v37), LODWORD(v36));
		                DWORD2(v72) = v38;
		                *((float *)&v72 + 3) = (float)(m_ditherAlpha * v25->fields.m_intensity)
		                                     * _mm_shuffle_ps(v27, v27, 170).m128_f32[0];
		                *(_OWORD *)&v9->fields.m_capsuleShadowData3.m_Buffer[16 * v9->fields.m_capsuleNum] = v72;
		                *(_QWORD *)&v73 = __PAIR64__(v50, v49);
		                *((_QWORD *)&v73 + 1) = __PAIR64__(v31.m128_u32[0], v35);
		                *(_OWORD *)&v9->fields.m_capsuleShadowData4.m_Buffer[16 * v9->fields.m_capsuleNum] = v73;
		                *(_QWORD *)&v76.x = v34;
		                LODWORD(v76.z) = v35;
		                v52 = UnityEngine::Quaternion::LookRotation(&v91, &v76, 0LL);
		                v53 = v31;
		                v31.m128_f32[0] = v31.m128_f32[0] * 5.0;
		                v53.m128_f32[0] = v31.m128_f32[0];
		                *(_QWORD *)&v77.x = _mm_unpacklo_ps(v31, v53).m128_u64[0];
		                LODWORD(v77.z) = v31.m128_i32[0];
		                v82 = *v52;
		                *(_QWORD *)&v78.x = _mm_unpacklo_ps(v29, v85).m128_u64[0];
		                v78.z = *(float *)&v81.ptr;
		                v54 = UnityEngine::Matrix4x4::TRS(&v92, &v78, &v82, &v77, 0LL);
		                v55 = *(_OWORD *)&v54->m00;
		                v56 = *(_OWORD *)&v54->m01;
		                v57 = *(_OWORD *)&v54->m02;
		                v58 = *(_OWORD *)&v54->m03;
		                v59 = (__int64)v9->fields.m_capsuleNum << 6;
		                m_Buffer = v9->fields.m_capsuleStencilWriterMatrixes.m_Buffer;
		                *(_OWORD *)&m_Buffer[v59] = v55;
		                *(_OWORD *)&m_Buffer[v59 + 16] = v56;
		                *(_OWORD *)&m_Buffer[v59 + 32] = v57;
		                *(_OWORD *)&m_Buffer[v59 + 48] = v58;
		                ++v9->fields.m_capsuleNum;
		              }
		            }
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v84 )
		        {
		          v14 = v65;
		          ex = v84->ex;
		          v15 = ex;
		          if ( ex )
		            sub_18007E1E0(ex);
		          v6 = directionalLightIndex;
		          v7 = lightCullResult;
		          v9 = this;
		          v17 = v66;
		          v10 = 0LL;
		          v18 = (__m128)0x3F800000u;
		        }
		      }
		      ++v17;
		    }
		  }
		}
		
		public void GetCapsuleDatas(out int capsuleNum, out NativeArray<Vector4> data1, out NativeArray<Vector4> data2, out NativeArray<Vector4> data3, out NativeArray<Vector4> data4, out NativeArray<Matrix4x4> transforms) {
			capsuleNum = default;
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
			transforms = default;
		} // 0x0000000189D1C214-0x0000000189D1C300
		// Void GetCapsuleDatas(Int32 ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Vector4] ByRef, NativeArray`1[UnityEngine.Matrix4x4] ByRef)
		void HG::Rendering::Runtime::HGCapsuleShadowManager::GetCapsuleDatas(
		        HGCapsuleShadowManager *this,
		        int32_t *capsuleNum,
		        NativeArray_1_UnityEngine_Vector4_ *data1,
		        NativeArray_1_UnityEngine_Vector4_ *data2,
		        NativeArray_1_UnityEngine_Vector4_ *data3,
		        NativeArray_1_UnityEngine_Vector4_ *data4,
		        NativeArray_1_UnityEngine_Matrix4x4_ *transforms,
		        MethodInfo *method)
		{
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2091, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2091, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_841(
		      Patch,
		      (Object *)this,
		      capsuleNum,
		      data1,
		      data2,
		      data3,
		      data4,
		      transforms,
		      0LL);
		  }
		  else
		  {
		    *capsuleNum = this->fields.m_capsuleNum;
		    *data1 = this->fields.m_capsuleShadowData1;
		    *data2 = this->fields.m_capsuleShadowData2;
		    *data3 = this->fields.m_capsuleShadowData3;
		    *data4 = this->fields.m_capsuleShadowData4;
		    *transforms = this->fields.m_capsuleStencilWriterMatrixes;
		  }
		}
		
		public Mesh GetSphereMesh() => default; // 0x0000000189D1C3A0-0x0000000189D1C3F0
		// Mesh GetSphereMesh()
		Mesh *HG::Rendering::Runtime::HGCapsuleShadowManager::GetSphereMesh(HGCapsuleShadowManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2092, 0LL) )
		    return this->fields.m_sphereMesh;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2092, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, (Object *)this, 0LL);
		}
		
		public Material GetCapsuleShadowMaterial() => default; // 0x0000000189D1C300-0x0000000189D1C350
		// Material GetCapsuleShadowMaterial()
		Material *HG::Rendering::Runtime::HGCapsuleShadowManager::GetCapsuleShadowMaterial(
		        HGCapsuleShadowManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2093, 0LL) )
		    return this->fields.m_capsuleShadowCasterMaterial;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2093, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_641(Patch, (Object *)this, 0LL);
		}
		
		public MaterialPropertyBlock GetMaterialPropertyBlock() => default; // 0x0000000189D1C350-0x0000000189D1C3A0
		// MaterialPropertyBlock GetMaterialPropertyBlock()
		MaterialPropertyBlock *HG::Rendering::Runtime::HGCapsuleShadowManager::GetMaterialPropertyBlock(
		        HGCapsuleShadowManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2094, 0LL) )
		    return this->fields.m_capsuleShadowPropertyBlock;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2094, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_131(Patch, (Object *)this, 0LL);
		}
		
		public void RenderCapsuleShadow(CommandBuffer cmd, int shaderPass, TextureHandle gbufferNormalTexture) {} // 0x0000000189D1C698-0x0000000189D1C994
		// Void RenderCapsuleShadow(CommandBuffer, Int32, TextureHandle)
		void HG::Rendering::Runtime::HGCapsuleShadowManager::RenderCapsuleShadow(
		        HGCapsuleShadowManager *this,
		        CommandBuffer *cmd,
		        int32_t shaderPass,
		        TextureHandle *gbufferNormalTexture,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  MaterialPropertyBlock *m_capsuleShadowPropertyBlock; // rcx
		  MaterialPropertyBlock *v11; // rdi
		  int32_t CapsuleShadowData1; // edx
		  int32_t CapsuleShadowData2; // edx
		  int32_t CapsuleShadowData3; // edx
		  int32_t CapsuleShadowData4; // edx
		  MaterialPropertyBlock *v16; // rdi
		  MonitorData *monitor; // rax
		  int32_t v18; // r14d
		  Texture *v19; // rax
		  int32_t m_capsuleNum; // edi
		  MaterialPropertyBlock *v21; // rsi
		  Material *m_capsuleShadowCasterMaterial; // r9
		  Mesh *m_sphereMesh; // rdx
		  NativeArray_1_UnityEngine_Matrix4x4_ m_capsuleStencilWriterMatrixes; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle m_capsuleShadowData1; // [rsp+58h] [rbp-B0h] BYREF
		  _OWORD v27[7]; // [rsp+68h] [rbp-A0h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v28; // [rsp+D8h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2095, 0LL) )
		  {
		    if ( !this->fields.m_capsuleNum )
		      return;
		    m_capsuleShadowPropertyBlock = this->fields.m_capsuleShadowPropertyBlock;
		    if ( m_capsuleShadowPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::Clear(m_capsuleShadowPropertyBlock, 1, 0LL);
		      v11 = this->fields.m_capsuleShadowPropertyBlock;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( v11 )
		      {
		        CapsuleShadowData1 = static_fields->_CapsuleShadowData1;
		        m_capsuleShadowData1 = (TextureHandle)this->fields.m_capsuleShadowData1;
		        UnityEngine::MaterialPropertyBlock::SetVectorArray(
		          v11,
		          CapsuleShadowData1,
		          (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
		          0LL);
		        m_capsuleShadowPropertyBlock = this->fields.m_capsuleShadowPropertyBlock;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( m_capsuleShadowPropertyBlock )
		        {
		          CapsuleShadowData2 = static_fields->_CapsuleShadowData2;
		          m_capsuleShadowData1 = (TextureHandle)this->fields.m_capsuleShadowData2;
		          UnityEngine::MaterialPropertyBlock::SetVectorArray(
		            m_capsuleShadowPropertyBlock,
		            CapsuleShadowData2,
		            (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
		            0LL);
		          m_capsuleShadowPropertyBlock = this->fields.m_capsuleShadowPropertyBlock;
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          if ( m_capsuleShadowPropertyBlock )
		          {
		            CapsuleShadowData3 = static_fields->_CapsuleShadowData3;
		            m_capsuleShadowData1 = (TextureHandle)this->fields.m_capsuleShadowData3;
		            UnityEngine::MaterialPropertyBlock::SetVectorArray(
		              m_capsuleShadowPropertyBlock,
		              CapsuleShadowData3,
		              (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
		              0LL);
		            m_capsuleShadowPropertyBlock = this->fields.m_capsuleShadowPropertyBlock;
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( m_capsuleShadowPropertyBlock )
		            {
		              CapsuleShadowData4 = static_fields->_CapsuleShadowData4;
		              m_capsuleShadowData1 = (TextureHandle)this->fields.m_capsuleShadowData4;
		              UnityEngine::MaterialPropertyBlock::SetVectorArray(
		                m_capsuleShadowPropertyBlock,
		                CapsuleShadowData4,
		                (NativeArray_1_UnityEngine_Vector4_ *)&m_capsuleShadowData1,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		              if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(gbufferNormalTexture, 0LL) )
		              {
		                v16 = this->fields.m_capsuleShadowPropertyBlock;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                m_capsuleShadowPropertyBlock = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                monitor = m_capsuleShadowPropertyBlock[23].monitor;
		                if ( !monitor )
		                  goto LABEL_17;
		                if ( *((_DWORD *)monitor + 6) <= 1u )
		                  sub_1800D2AB0(m_capsuleShadowPropertyBlock, static_fields);
		                v18 = *((_DWORD *)monitor + 9);
		                sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		                m_capsuleShadowData1 = *gbufferNormalTexture;
		                v19 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&m_capsuleShadowData1, 0LL);
		                if ( !v16 )
		                  goto LABEL_17;
		                UnityEngine::MaterialPropertyBlock::SetTextureImpl(v16, v18, v19, 0LL);
		              }
		              m_capsuleNum = this->fields.m_capsuleNum;
		              v21 = this->fields.m_capsuleShadowPropertyBlock;
		              sub_18033B9D0(v27, 0LL, 112LL);
		              if ( cmd )
		              {
		                m_capsuleShadowCasterMaterial = this->fields.m_capsuleShadowCasterMaterial;
		                m_sphereMesh = this->fields.m_sphereMesh;
		                *(_OWORD *)&v28.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v27[1];
		                *(_OWORD *)&v28.hasValue = v27[0];
		                *(_OWORD *)&v28.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v27[3];
		                *(_OWORD *)&v28.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v27[2];
		                *(_OWORD *)&v28.value.m_RasterState.m_OffsetFactor = v27[5];
		                m_capsuleStencilWriterMatrixes = this->fields.m_capsuleStencilWriterMatrixes;
		                *(_OWORD *)&v28.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v27[4];
		                m_capsuleShadowData1 = (TextureHandle)m_capsuleStencilWriterMatrixes;
		                *(_OWORD *)&v28.value.m_StencilState.m_FailOperationFront = v27[6];
		                UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		                  cmd,
		                  m_sphereMesh,
		                  0,
		                  m_capsuleShadowCasterMaterial,
		                  shaderPass,
		                  (NativeArray_1_UnityEngine_Matrix4x4_ *)&m_capsuleShadowData1,
		                  m_capsuleNum,
		                  v21,
		                  &v28,
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(m_capsuleShadowPropertyBlock, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2095, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  m_capsuleShadowData1 = *gbufferNormalTexture;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_842(
		    Patch,
		    (Object *)this,
		    (Object *)cmd,
		    shaderPass,
		    &m_capsuleShadowData1,
		    0LL);
		}
		
	}
}
