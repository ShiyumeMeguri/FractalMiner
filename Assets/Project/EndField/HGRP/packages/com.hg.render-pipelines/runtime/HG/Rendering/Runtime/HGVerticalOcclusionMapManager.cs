using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGVerticalOcclusionMapManager // TypeDefIndex: 37920
	{
		// Fields
		private const float s_snappedYThreshold = 1f; // Metadata: 0x023035C1
		private RequestUsageType m_requestType; // 0x10
		private CustomDepthOnlyRequestManager.Handle m_depthOnlySysHandle; // 0x14
		private float m_depthOnlyYCache; // 0x18
		private float m_occlusionRange; // 0x1C
		private int m_occlusionMapSize; // 0x20
		private static readonly int OCCLUSION_MAP_HEIGHT; // 0x00
		private static readonly int OCCLUSION_MAP_PAGE_ROWCOLUMN_COUNT; // 0x04
	
		// Nested types
		[Flags]
		public enum RequestUsageType // TypeDefIndex: 37919
		{
			None = 0,
			RainWetnessOcclusion = 1,
			ScanlineHighlight = 2,
			SnowOcclusion = 4
		}
	
		// Constructors
		public HGVerticalOcclusionMapManager() {} // 0x0000000184DA1470-0x0000000184DA1480
		// HGVerticalOcclusionMapManager()
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::HGVerticalOcclusionMapManager(
		        HGVerticalOcclusionMapManager *this,
		        MethodInfo *method)
		{
		  this->fields.m_occlusionRange = 1.0;
		  this->fields.m_occlusionMapSize = 1;
		}
		
		static HGVerticalOcclusionMapManager() {} // 0x0000000184D81440-0x0000000184D81470
		// HGVerticalOcclusionMapManager()
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager->static_fields->OCCLUSION_MAP_HEIGHT = 256;
		  TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager->static_fields->OCCLUSION_MAP_PAGE_ROWCOLUMN_COUNT = 8;
		}
		
	
		// Methods
		internal void GetVerticalOcclusionMapShaderVariables(out Vector4 param, out bool enabled) {
			param = default;
			enabled = default;
		} // 0x0000000183BF51C0-0x0000000183BF5390
		// Void GetVerticalOcclusionMapShaderVariables(Vector4 ByRef, Boolean ByRef)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::GetVerticalOcclusionMapShaderVariables(
		        HGVerticalOcclusionMapManager *this,
		        Vector4 *param,
		        bool *enabled,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  Vector4 *v7; // rsi
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  int32_t m_occlusionMapSize; // ebp
		  float m_occlusionRange; // xmm6_4
		  float v11; // xmm6_4
		  float v12; // xmm7_4
		  float v13; // xmm8_4
		  __m128 v14; // xmm0
		  __m128 v15; // xmm0
		  __m128 v16; // xmm0
		  Vector4 v17; // xmm0
		  bool v18; // al
		  ILFixDynamicMethodWrapper_2 *v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v21; // rax
		  __m128 v22; // [rsp+30h] [rbp-58h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = param;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size <= 938 )
		    goto LABEL_5;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  param = (Vector4 *)v6->static_fields->wrapperArray;
		  if ( !param )
		    goto LABEL_18;
		  if ( LODWORD(param[1].z) <= 0x3AA )
		    goto LABEL_40;
		  if ( !*(_QWORD *)&param[471].x )
		  {
		LABEL_5:
		    m_occlusionMapSize = this->fields.m_occlusionMapSize;
		    m_occlusionRange = this->fields.m_occlusionRange;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v11 = (float)(m_occlusionRange + m_occlusionRange) / (float)m_occlusionMapSize;
		    v12 = 1.0 / (float)m_occlusionMapSize;
		    v13 = (float)m_occlusionMapSize;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    param = (Vector4 *)v6->static_fields->wrapperArray;
		    if ( !param )
		      goto LABEL_18;
		    if ( SLODWORD(param[1].z) <= 939 )
		      goto LABEL_11;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    param = (Vector4 *)v6->static_fields->wrapperArray;
		    if ( !param )
		      goto LABEL_18;
		    if ( LODWORD(param[1].z) <= 0x3AB )
		      goto LABEL_40;
		    if ( *(_QWORD *)&param[471].z )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(939, 0LL);
		      if ( !Patch )
		        goto LABEL_18;
		      v17 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_376((Vector4 *)&v22, Patch, v13, v12, v11, 0LL);
		    }
		    else
		    {
		LABEL_11:
		      v22.m128_i32[3] = 0;
		      v14 = v22;
		      v14.m128_f32[0] = v13;
		      v15 = _mm_shuffle_ps(v14, v14, 225);
		      v15.m128_f32[0] = v12;
		      v16 = _mm_shuffle_ps(v15, v15, 198);
		      v16.m128_f32[0] = v11;
		      v17 = (Vector4)_mm_shuffle_ps(v16, v16, 201);
		    }
		    *v7 = v17;
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    param = (Vector4 *)v6->static_fields->wrapperArray;
		    if ( !param )
		      goto LABEL_18;
		    if ( SLODWORD(param[1].z) <= 846 )
		    {
		LABEL_16:
		      v18 = this->fields.m_requestType > 0;
		LABEL_17:
		      *enabled = v18;
		      return;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		LABEL_18:
		      sub_1800D8260(v6, param);
		    if ( LODWORD(v6->_0.namespaze) > 0x34E )
		    {
		      if ( !v6[18]._0.byval_arg.data.dummy )
		        goto LABEL_16;
		      v21 = IFix::WrappersManagerImpl::GetPatch(846, 0LL);
		      if ( v21 )
		      {
		        v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v21, (Object *)this, 0LL);
		        goto LABEL_17;
		      }
		      goto LABEL_18;
		    }
		LABEL_40:
		    sub_1800D2AB0(v6, param);
		  }
		  v19 = IFix::WrappersManagerImpl::GetPatch(938, 0LL);
		  if ( !v19 )
		    goto LABEL_18;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_377(v19, (Object *)this, v7, enabled, 0LL);
		}
		
		internal void UpdateOcclusionMapParamsAndRequests(HGCamera hgCamera, HGVerticalOcclusionMapSettingParameters settingParameters, CustomDepthOnlyRequestManager mgr) {} // 0x0000000189B5B0E4-0x0000000189B5B1D4
		// Void UpdateOcclusionMapParamsAndRequests(HGCamera, HGVerticalOcclusionMapSettingParameters, CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::UpdateOcclusionMapParamsAndRequests(
		        HGVerticalOcclusionMapManager *this,
		        HGCamera *hgCamera,
		        HGVerticalOcclusionMapSettingParameters *settingParameters,
		        CustomDepthOnlyRequestManager *mgr,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  bool needRefresh; // [rsp+30h] [rbp-18h] BYREF
		
		  needRefresh = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(836, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(836, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		      (ILFixDynamicMethodWrapper_10 *)Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      (Object *)settingParameters,
		      (Object *)mgr,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_UpdateQualitySettings(
		      this,
		      settingParameters,
		      &needRefresh,
		      0LL);
		    if ( needRefresh || HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_HandleInValid(this, mgr, 0LL) )
		      HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RefreshOcclusionMapRequest(this, mgr, 0LL);
		    if ( !HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_ShouldRequestOcclusionMap(this, 0LL) )
		    {
		      if ( mgr )
		      {
		        HG::Rendering::Runtime::CustomDepthOnlyRequestManager::TogglePass(
		          mgr,
		          this->fields.m_depthOnlySysHandle,
		          0,
		          0LL);
		        return;
		      }
		LABEL_10:
		      sub_1800D8260(v10, v9);
		    }
		    HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RequestOcclusionMap(this, hgCamera, mgr, 0LL);
		  }
		}
		
		internal void Dispose(CustomDepthOnlyRequestManager customDepthOnlyRequestMgr) {} // 0x00000001849E4190-0x00000001849E41D0
		// Void Dispose(CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::Dispose(
		        HGVerticalOcclusionMapManager *this,
		        CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(534, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(534, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)customDepthOnlyRequestMgr,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgr(
		      this,
		      customDepthOnlyRequestMgr,
		      0LL);
		  }
		}
		
		protected void _DisposeCustomDepthOnlyRequestMgr(CustomDepthOnlyRequestManager customDepthOnlyRequestMgr) {} // 0x00000001849E41D0-0x00000001849E4220
		// Void _DisposeCustomDepthOnlyRequestMgr(CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgr(
		        HGVerticalOcclusionMapManager *this,
		        CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(535, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(535, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)customDepthOnlyRequestMgr,
		      0LL);
		  }
		  else if ( customDepthOnlyRequestMgr )
		  {
		    HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RemoveSystem(
		      customDepthOnlyRequestMgr,
		      this->fields.m_depthOnlySysHandle,
		      0LL);
		  }
		}
		
		internal void RegisterRequestUsage(RequestUsageType requestType) {} // 0x0000000189B5B08C-0x0000000189B5B0E4
		// Void RegisterRequestUsage(HGVerticalOcclusionMapManager+RequestUsageType)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
		        HGVerticalOcclusionMapManager *this,
		        HGVerticalOcclusionMapManager_RequestUsageType__Enum requestType,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(815, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(815, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      requestType,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_requestType |= requestType;
		  }
		}
		
		internal void UnregisterRequestUsage(RequestUsageType requestType) {} // 0x00000001832DDA70-0x00000001832DDAD0
		// Void UnregisterRequestUsage(HGVerticalOcclusionMapManager+RequestUsageType)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::UnregisterRequestUsage(
		        HGVerticalOcclusionMapManager *this,
		        HGVerticalOcclusionMapManager_RequestUsageType__Enum requestType,
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
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 816 )
		  {
		LABEL_5:
		    this->fields.m_requestType &= ~requestType;
		    return;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x330 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( !v5[17]._0.implementedInterfaces )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(816, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, wrapperArray);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, requestType, 0LL);
		}
		
		private bool _ShouldRequestOcclusionMap() => default; // 0x0000000183BF5420-0x0000000183BF5480
		// Boolean _ShouldRequestOcclusionMap()
		bool HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_ShouldRequestOcclusionMap(
		        HGVerticalOcclusionMapManager *this,
		        MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 846 )
		    return this->fields.m_requestType > 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x34E )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[18]._0.byval_arg.data.dummy )
		    return this->fields.m_requestType > 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(846, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		private bool _HandleInValid(CustomDepthOnlyRequestManager mgr) => default; // 0x0000000189B5B1D4-0x0000000189B5B240
		// Boolean _HandleInValid(CustomDepthOnlyRequestManager)
		bool HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_HandleInValid(
		        HGVerticalOcclusionMapManager *this,
		        CustomDepthOnlyRequestManager *mgr,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(839, 0LL) )
		  {
		    if ( mgr )
		      return !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(
		                mgr,
		                this->fields.m_depthOnlySysHandle,
		                0LL);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(839, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)mgr,
		           0LL);
		}
		
		private void _RequestOcclusionMap(HGCamera hgCamera, CustomDepthOnlyRequestManager mgr) {} // 0x0000000189B5B464-0x0000000189B5B5A8
		// Void _RequestOcclusionMap(HGCamera, CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RequestOcclusionMap(
		        HGVerticalOcclusionMapManager *this,
		        HGCamera *hgCamera,
		        CustomDepthOnlyRequestManager *mgr,
		        MethodInfo *method)
		{
		  Object_1 *camera; // rdi
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  System::MathF *v12; // rcx
		  float z; // edi
		  float v14; // xmm1_4
		  int32_t index; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v17; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v18[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(847, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(847, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)hgCamera,
		        (Object *)mgr,
		        0LL);
		      return;
		    }
		    goto LABEL_11;
		  }
		  if ( !hgCamera )
		    return;
		  camera = (Object_1 *)hgCamera->fields.camera;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
		    return;
		  if ( !camera || (transform = UnityEngine::Component::get_transform((Component *)camera, 0LL)) == 0LL )
		LABEL_11:
		    sub_1800D8260(v9, v8);
		  position = UnityEngine::Transform::get_position(v18, transform, 0LL);
		  z = position->z;
		  *(_QWORD *)&v17.x = *(_QWORD *)&position->x;
		  v14 = fabs(v17.y - this->fields.m_depthOnlyYCache);
		  if ( v14 > 1.0 )
		  {
		    System::MathF::Floor(v12, v14);
		    this->fields.m_depthOnlyYCache = v17.y;
		  }
		  v17.y = this->fields.m_depthOnlyYCache;
		  if ( mgr )
		  {
		    HG::Rendering::Runtime::CustomDepthOnlyRequestManager::TogglePass(mgr, this->fields.m_depthOnlySysHandle, 1, 0LL);
		    index = this->fields.m_depthOnlySysHandle.index;
		    v17.z = z;
		    HG::Rendering::Runtime::CustomDepthOnlyRequestManager::UpdateSystem(
		      mgr,
		      (CustomDepthOnlyRequestManager_Handle)index,
		      &v17,
		      0LL);
		  }
		}
		
		private void _RegisterOcclusionMapRequest(CustomDepthOnlyRequestManager mgr) {} // 0x0000000189B5B2B4-0x0000000189B5B464
		// Void _RegisterOcclusionMapRequest(CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RegisterOcclusionMapRequest(
		        HGVerticalOcclusionMapManager *this,
		        CustomDepthOnlyRequestManager *mgr,
		        MethodInfo *method)
		{
		  float m_occlusionRange; // xmm7_4
		  HGVerticalOcclusionMapManager__StaticFields *static_fields; // rcx
		  __m128i v7; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int128 v11; // [rsp+28h] [rbp-49h]
		  __int128 v12; // [rsp+38h] [rbp-39h]
		  __int128 v13; // [rsp+48h] [rbp-29h]
		  __int64 v14; // [rsp+58h] [rbp-19h]
		  CustomDepthOnlyRequestManager_Request request; // [rsp+68h] [rbp-9h] BYREF
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_ v16; // [rsp+F0h] [rbp+7Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(841, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(841, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)mgr,
		      0LL);
		  }
		  else if ( mgr )
		  {
		    m_occlusionRange = this->fields.m_occlusionRange;
		    *(_QWORD *)&v11 = 0LL;
		    DWORD2(v11) = 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager);
		    *((_QWORD *)&v13 + 1) = 0x5D00000020LL;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager->static_fields;
		    *((float *)&v11 + 3) = m_occlusionRange + m_occlusionRange;
		    *(float *)&v12 = m_occlusionRange + m_occlusionRange;
		    v7 = _mm_cvtsi32_si128(static_fields->OCCLUSION_MAP_HEIGHT);
		    *(_DWORD *)&v16.hasValue = this->fields.m_occlusionMapSize;
		    v16.value.shaderID = *(_DWORD *)&v16.hasValue;
		    *((Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_ *)&v12 + 1) = v16;
		    *(_DWORD *)&v16.hasValue = this->fields.m_occlusionMapSize / static_fields->OCCLUSION_MAP_PAGE_ROWCOLUMN_COUNT;
		    v16.value.shaderID = this->fields.m_occlusionMapSize / static_fields->OCCLUSION_MAP_PAGE_ROWCOLUMN_COUNT;
		    *(Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_ *)&v13 = v16;
		    DWORD1(v12) = _mm_cvtepi32_ps(v7).m128_u32[0];
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v14 = *(_QWORD *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalOcclusionMap;
		    *(_OWORD *)&request.rootPosition.x = v11;
		    *(_DWORD *)&request.includeDynamicObjects = 1;
		    *(_OWORD *)&request.frustumSize.y = v12;
		    *(_OWORD *)&request.pageSize.m_X = v13;
		    *(_QWORD *)&request.depthRTShaderID = v14;
		    v16 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_)HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RequestCustomDepthOnlyPassV1(
		                                                                                       mgr,
		                                                                                       &request,
		                                                                                       0LL);
		    if ( v16.hasValue )
		      this->fields.m_depthOnlySysHandle.index = System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::VSMSupport>::get_Value(
		                                                  &v16,
		                                                  MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Handle>::get_Value).shaderID;
		  }
		}
		
		private void _UpdateQualitySettings(HGVerticalOcclusionMapSettingParameters settingParameters, out bool needRefresh) {
			needRefresh = default;
		} // 0x0000000189B5B5A8-0x0000000189B5B68C
		// Void _UpdateQualitySettings(HGVerticalOcclusionMapSettingParameters, Boolean ByRef)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_UpdateQualitySettings(
		        HGVerticalOcclusionMapManager *this,
		        HGVerticalOcclusionMapSettingParameters *settingParameters,
		        bool *needRefresh,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Int32Enum__Enum v9; // eax
		  bool v10; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(837, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(837, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(
		        Patch,
		        (Object *)this,
		        (Object *)settingParameters,
		        needRefresh,
		        0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !settingParameters )
		    goto LABEL_8;
		  v9 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._DepthOcclusionMapRange_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v10 = !System::Single::Equals((Single *)&this->fields.m_occlusionRange, (float)(int)v9, 0LL)
		     || this->fields.m_occlusionMapSize != HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                             (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._DepthOcclusionMapSize_k__BackingField,
		                                             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  *needRefresh = v10;
		  this->fields.m_occlusionRange = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                                (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._DepthOcclusionMapRange_k__BackingField,
		                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  this->fields.m_occlusionMapSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                      (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._DepthOcclusionMapSize_k__BackingField,
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		}
		
		private void _RefreshOcclusionMapRequest(CustomDepthOnlyRequestManager mgr) {} // 0x0000000189B5B240-0x0000000189B5B2B4
		// Void _RefreshOcclusionMapRequest(CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RefreshOcclusionMapRequest(
		        HGVerticalOcclusionMapManager *this,
		        CustomDepthOnlyRequestManager *mgr,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(840, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(840, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)mgr,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgr(this, mgr, 0LL);
		    HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RegisterOcclusionMapRequest(this, mgr, 0LL);
		  }
		}
		
	}
}
