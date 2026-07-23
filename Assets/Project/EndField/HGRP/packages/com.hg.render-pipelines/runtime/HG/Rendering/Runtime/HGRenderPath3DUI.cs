using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGRenderPath3DUI : HGRenderPathBase // TypeDefIndex: 38520
	{
		// Fields
		private UIImageBlurPassConstructor m_uiImageBlurPassConstructor; // 0x1268
		private UIPassConstructor m_uiPassConstructor; // 0x1270
		private UIPostProcessConstructor m_uiPostProcessConstructor; // 0x1278
		private MultiblurPassConstructor m_multiblurPassConstructor; // 0x1280
		private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor; // 0x1288
	
		// Constructors
		public HGRenderPath3DUI() {} // Dummy constructor
		internal HGRenderPath3DUI(HGRenderPathResources resources, HGCamera camera) {} // 0x0000000182ED91C0-0x0000000182ED9370
		// HGRenderPath3DUI(HGRenderPathBase+HGRenderPathResources, HGCamera)
		void HG::Rendering::Runtime::HGRenderPath3DUI::HGRenderPath3DUI(
		        HGRenderPath3DUI *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  PassConstructorID__Enum__Array *v7; // rax
		  IPassConstructor *PassConstructor; // rbx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  IPassConstructor *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  IPassConstructor *v16; // rbx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  IPassConstructor *v20; // rbx
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  IPassConstructor *v24; // rbx
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  MethodInfo *v28; // [rsp+20h] [rbp-28h]
		  MethodInfo *v29; // [rsp+20h] [rbp-28h]
		  MethodInfo *v30; // [rsp+20h] [rbp-28h]
		  MethodInfo *v31; // [rsp+20h] [rbp-28h]
		  HGRenderPathBase_HGRenderPathResources v32; // [rsp+30h] [rbp-18h] BYREF
		  MethodInfo *v33; // [rsp+70h] [rbp+28h]
		
		  v7 = HG::Rendering::Runtime::HGRenderPath3DUI::PopulatePassConstructorIds(0LL);
		  v32 = *resources;
		  HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
		    (HGRenderPathBase *)this,
		    &v32,
		    v7,
		    camera,
		    HGRenderPathInternal__Enum_UI3D,
		    0LL);
		  PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                      (HGRenderPathBase *)this,
		                      PassConstructorID__Enum_UIImageBlur,
		                      0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = sub_180005050(
		                                                                                        PassConstructor,
		                                                                                        TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		  sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m23,
		    v9,
		    v10,
		    v11,
		    v28);
		  v12 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_UI,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = sub_180005050(
		                                                                                                   v12,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		  sub_180005050(v12, TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix,
		    v13,
		    v14,
		    v15,
		    v29);
		  v16 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_UIPP,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = sub_180005050(
		                                                                                                   v16,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
		  sub_180005050(v16, TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20,
		    v17,
		    v18,
		    v19,
		    v30);
		  v20 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Multiblur,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = sub_180005050(
		                                                                                                   v20,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		  sub_180005050(v20, TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01,
		    v21,
		    v22,
		    v23,
		    v31);
		  v24 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ScreenSpaceOverlay,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 = sub_180005050(
		                                                                                                   v24,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		  sub_180005050(v24, TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21,
		    v25,
		    v26,
		    v27,
		    v33);
		}
		
	
		// Methods
		private static PassConstructorID[] PopulatePassConstructorIds() => default; // 0x0000000182ED9050-0x0000000182ED90A0
		// PassConstructorID[] PopulatePassConstructorIds()
		PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPath3DUI::PopulatePassConstructorIds(
		        MethodInfo *method)
		{
		  Array *v1; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3561, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3561, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1269(Patch, 0LL);
		  }
		  else
		  {
		    v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 5LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v1,
		      45394B168F330187244267C78B7D937B94C1E6456EB140F6DA76F3A3478609AD_Field,
		      0LL);
		    return (PassConstructorID__Enum__Array *)v1;
		  }
		}
		
		protected override PassConstructorID FindFirstBackbufferPass() => default; // 0x0000000189BEF680-0x0000000189BEF81C
		// PassConstructorID FindFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPath3DUI::FindFirstBackbufferPass(
		        HGRenderPath3DUI *this,
		        MethodInfo *method)
		{
		  HGCamera *v3; // rcx
		  HGCamera *m_Length; // rdx
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *RTForExtraction; // rax
		  __m128i v6; // xmm6
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *v7; // rax
		  __m128i v8; // xmm7
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
		  _BOOL8 v10; // rdi
		  _BOOL8 v11; // rbp
		  _BOOL8 v12; // rsi
		  unsigned __int64 v13; // xmm6_8
		  unsigned __int64 v14; // xmm7_8
		  PassConstructorID__Enum result; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v17; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3562, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3562, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_25;
		  }
		  m_Length = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		  if ( !m_Length )
		    goto LABEL_25;
		  RTForExtraction = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
		                      &v17,
		                      m_Length,
		                      RTExtractionType__Enum_SceneColorPS,
		                      0LL);
		  m_Length = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		  v6 = *(__m128i *)RTForExtraction;
		  if ( !m_Length )
		    goto LABEL_25;
		  v7 = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(&v17, m_Length, RTExtractionType__Enum_FinalResult, 0LL);
		  v3 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		  v8 = *(__m128i *)v7;
		  if ( !v3 )
		    goto LABEL_25;
		  InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(v3, 0LL);
		  v3 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		  if ( !v3 )
		    goto LABEL_25;
		  m_Length = (HGCamera *)(unsigned int)v3->fields.sortingOrdersToBlurInternal.m_Length;
		  v3 = (HGCamera *)v6.m128i_i64[0];
		  if ( !v6.m128i_i64[0] )
		    goto LABEL_25;
		  LOBYTE(v10) = 1;
		  if ( *(int *)(v6.m128i_i64[0] + 32) <= 0 )
		  {
		    v13 = _mm_srli_si128(v6, 8).m128i_u64[0];
		    if ( !v13 )
		      goto LABEL_25;
		    v12 = (int)m_Length > 0;
		    v11 = *(_DWORD *)(v13 + 32) > 0;
		  }
		  else
		  {
		    LODWORD(v11) = 1;
		    v12 = (int)m_Length > 0;
		  }
		  if ( !v8.m128i_i64[0] )
		LABEL_25:
		    sub_1800D8260(v3, m_Length);
		  if ( *(int *)(v8.m128i_i64[0] + 32) <= 0 )
		  {
		    v14 = _mm_srli_si128(v8, 8).m128i_u64[0];
		    if ( !v14 )
		      goto LABEL_25;
		    if ( *(int *)(v14 + 32) <= 0 )
		    {
		      if ( InplaceWaterMarkRTs )
		      {
		        v10 = InplaceWaterMarkRTs->fields._size > 0;
		        goto LABEL_17;
		      }
		      goto LABEL_25;
		    }
		  }
		LABEL_17:
		  result = (unsigned int)sub_180002F70(6LL, this);
		  if ( v11 )
		    result = PassConstructorID__Enum_UI;
		  if ( v12 )
		    result = PassConstructorID__Enum_ScreenSpaceOverlay;
		  if ( v10 )
		    return 60;
		  return result;
		}
		
		protected override void RenderInternal(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BEF86C-0x0000000189BF05A8
		// Void RenderInternal(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::Runtime::HGRenderPath3DUI::RenderInternal(
		        HGRenderPath3DUI *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPath3DUI *v4; // r14
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r13
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGRenderGraph *renderGraph; // r12
		  HGCamera *v11; // r15
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  bool msaaEnabled; // di
		  Vector2Int finalRTSize; // rbx
		  TextureHandle v16; // xmm6
		  unsigned __int64 v17; // rdx
		  UIImageBlurManager *instance; // rax
		  unsigned __int64 v19; // r8
		  signed __int64 v20; // rtt
		  UIImageBlurPassConstructor *v21; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  unsigned __int64 v23; // rdx
		  MultiblurPassConstructor *handle; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rdi
		  Shader *blitPS; // rdi
		  void *ptr; // rbx
		  HGCamera *v28; // rbx
		  HGRenderPipelineRuntimeResources *v29; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *v30; // r8
		  unsigned __int64 v31; // r8
		  signed __int64 v32; // rtt
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  HGCamera *v35; // rbx
		  __int64 v36; // rdx
		  UIPassConstructor *v37; // rcx
		  HGSettingParameters *v38; // rdi
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  Rect v41; // xmm9
		  CullingResults v42; // xmm8
		  __int64 v43; // rdx
		  UIPostProcessConstructor *v44; // rcx
		  __int64 v45; // rdx
		  UIPassConstructor *v46; // rcx
		  __int64 v47; // rax
		  TextureHandle v48; // xmm8
		  unsigned __int64 v49; // r8
		  signed __int64 v50; // rtt
		  CullingResults backBufferColor_k__BackingField; // xmm7
		  TextureHandle v52; // xmm8
		  TextureHandle v53; // xmm0
		  unsigned __int64 v54; // r8
		  signed __int64 v55; // rtt
		  HGCamera *v56; // rbx
		  CullingResults v57; // xmm7
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  __int64 v61; // [rsp+0h] [rbp-338h] BYREF
		  UIImageBlurPassConstructor_PassOutput output; // [rsp+50h] [rbp-2E8h] BYREF
		  UIPassConstructor_PassOutput v63; // [rsp+51h] [rbp-2E7h] BYREF
		  TextureHandle v64; // [rsp+60h] [rbp-2D8h] BYREF
		  TextureHandle v65; // [rsp+70h] [rbp-2C8h] BYREF
		  HGCamera *uiCamera; // [rsp+80h] [rbp-2B8h]
		  char *v67; // [rsp+88h] [rbp-2B0h]
		  HGSettingParameters *settingParameters; // [rsp+90h] [rbp-2A8h]
		  HGCamera *hgCamera; // [rsp+98h] [rbp-2A0h]
		  HGRenderPipeline *v70; // [rsp+A0h] [rbp-298h]
		  HGRenderGraph *v71; // [rsp+A8h] [rbp-290h]
		  _QWORD v72[2]; // [rsp+B0h] [rbp-288h] BYREF
		  CullingResults cullingResults; // [rsp+C0h] [rbp-278h] BYREF
		  UIImageBlurPassConstructor_PassInput input; // [rsp+D0h] [rbp-268h] BYREF
		  MultiblurPassConstructor_PassInput v75; // [rsp+D8h] [rbp-260h] BYREF
		  TextureHandle v76; // [rsp+110h] [rbp-228h]
		  HGCamera *v77; // [rsp+120h] [rbp-218h] BYREF
		  ScreenSpaceOverlayPassConstructor_PassInput v78; // [rsp+128h] [rbp-210h] BYREF
		  UIPassConstructor_PassInput v79; // [rsp+140h] [rbp-1F8h] BYREF
		  MultiblurPassConstructor_PassInput v80; // [rsp+190h] [rbp-1A8h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+1C8h] [rbp-170h] BYREF
		  Il2CppExceptionWrapper *v82; // [rsp+1D0h] [rbp-168h] BYREF
		  Il2CppExceptionWrapper *v83; // [rsp+1D8h] [rbp-160h] BYREF
		  Il2CppExceptionWrapper *v84; // [rsp+1E0h] [rbp-158h] BYREF
		  UIPassConstructor_PassInput v85; // [rsp+1F0h] [rbp-148h] BYREF
		  __int128 v86; // [rsp+270h] [rbp-C8h]
		  UIPostProcessConstructor_PassInput v87; // [rsp+280h] [rbp-B8h] BYREF
		  char v90; // [rsp+358h] [rbp+20h] BYREF
		
		  v4 = this;
		  sub_18033B9D0(&v85, 0LL, 80LL);
		  v63 = 0;
		  v90 = 0;
		  input.uiImageBlurMgr = 0LL;
		  sub_18033B9D0(&v79, 0LL, 80LL);
		  memset(&v80, 0, sizeof(v80));
		  memset(&v75, 0, sizeof(v75));
		  memset(&v78, 0, sizeof(v78));
		  v76 = 0LL;
		  v77 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3563, 0LL) )
		  {
		    hgrp = renderPathParams->hgrp;
		    v70 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v71 = renderGraph;
		    cullingResults = renderPathParams->renderRequest.cullingResults.cullingResults;
		    settingParameters = hgrp->fields._settingParameters_k__BackingField;
		    hgCamera = renderPathParams->renderRequest.hgCamera;
		    v11 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		    if ( !v11 )
		      sub_1800D8260(v9, v8);
		    msaaEnabled = HG::Rendering::Runtime::HGCamera::get_msaaEnabled(
		                    *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                    0LL);
		    if ( !*(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01 )
		      sub_1800D8260(v13, v12);
		    finalRTSize = HG::Rendering::Runtime::HGCamera::get_finalRTSize(
		                    *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                    0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v16 = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
		             &v65,
		             renderGraph,
		             v11,
		             msaaEnabled,
		             GraphicsFormat__Enum_B10G11R11_UFloatPack32,
		             finalRTSize,
		             0LL);
		    v65 = v16;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    uiCamera = 0LL;
		    v67 = &v90;
		    try
		    {
		      v72[0] = 0LL;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		      instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		      v72[0] = instance;
		      if ( dword_18F35FD08 )
		      {
		        v19 = (((unsigned __int64)v72 >> 12) & 0x1FFFFF) >> 6;
		        v17 = ((unsigned __int64)v72 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		        do
		          v20 = qword_18F0BCBA0[v19 + 36190];
		        while ( v20 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v20 | (1LL << v17), v20) );
		        instance = (UIImageBlurManager *)v72[0];
		      }
		      input.uiImageBlurMgr = instance;
		      output = 0;
		      v21 = *(UIImageBlurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		      if ( !v21 )
		        sub_1800D8250(0LL, v17);
		      HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
		        v21,
		        &input,
		        &output,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v81 )
		    {
		      uiCamera = (HGCamera *)v81->ex;
		      if ( uiCamera )
		        sub_18007E1E0(uiCamera);
		      v4 = this;
		      hgrp = v70;
		      renderGraph = v71;
		      v16 = v65;
		    }
		    uiCamera = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		    defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		    if ( defaultResources )
		    {
		      shaders = defaultResources->fields.shaders;
		      if ( shaders )
		      {
		        blitPS = shaders->fields.blitPS;
		        ptr = renderPathParams->renderRequest.cullingResults.cullingResults.ptr;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(
		          uiCamera,
		          uiCamera,
		          blitPS,
		          ptr,
		          renderGraph,
		          renderPathParams,
		          0LL);
		        v28 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		        v29 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		        if ( v29 )
		        {
		          v30 = v29->fields.shaders;
		          if ( v30 )
		          {
		            HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
		              v28,
		              v28,
		              v30->fields.blitPS,
		              renderPathParams->renderRequest.cullingResults.cullingResults.ptr,
		              renderGraph,
		              renderPathParams,
		              0LL);
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x37u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		            uiCamera = 0LL;
		            v67 = &v90;
		            try
		            {
		              sub_18033B9D0(&v79, 0LL, 80LL);
		              v79.target = v16;
		              v79.hgrp = hgrp;
		              if ( dword_18F35FD08 )
		              {
		                v31 = (((unsigned __int64)&v79.hgrp >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		                do
		                  v32 = qword_18F0BCBA0[v31 + 36190];
		                while ( v32 != _InterlockedCompareExchange64(
		                                 &qword_18F0BCBA0[v31 + 36190],
		                                 v32 | (1LL << (((unsigned __int64)&v79.hgrp >> 12) & 0x3F)),
		                                 v32) );
		              }
		              v79.cullingResults = cullingResults;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              v79.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_3D_LAYER.m_Mask;
		              v79.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(hgrp, 0LL);
		              v35 = hgCamera;
		              if ( !hgCamera )
		                sub_1800D8250(v34, v33);
		              *(_QWORD *)&v79.screenCullingRatio = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		              v79.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		              v85 = v79;
		              v63 = 0;
		              v37 = *(UIPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		              if ( !v37 )
		                sub_1800D8250(0LL, v36);
		              v38 = settingParameters;
		              HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
		                v37,
		                &v85,
		                &v63,
		                renderGraph,
		                *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                settingParameters,
		                0LL);
		              v64 = v16;
		              HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		                RTExtractionType__Enum_SceneColorLS,
		                &v64,
		                *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                renderGraph,
		                0LL);
		            }
		            catch ( Il2CppExceptionWrapper *v82 )
		            {
		              uiCamera = (HGCamera *)v82->ex;
		              if ( uiCamera )
		                sub_18007E1E0(uiCamera);
		              v4 = this;
		              hgrp = v70;
		              renderGraph = v71;
		              v38 = settingParameters;
		              v35 = hgCamera;
		              v16 = v65;
		            }
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x36u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		            uiCamera = 0LL;
		            v67 = &v90;
		            try
		            {
		              v41 = (Rect)*HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                             &v65,
		                             (HGRenderPathBase *)v4,
		                             PassConstructorID__Enum_UIPP,
		                             0LL);
		              HIDWORD(v86) = 0;
		              v42 = cullingResults;
		              if ( !v38 )
		                sub_1800D8250(v40, v39);
		              LODWORD(v86) = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                               (SettingParameter_1_System_Int32Enum_ *)v38->fields._taauQuality_k__BackingField,
		                               MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
		              DWORD2(v86) = 74;
		              DWORD1(v86) = v4->fields._._renderPath_k__BackingField;
		              v87.source = v16;
		              v87.target = (TextureHandle)v41;
		              v87.cullingResults = v42;
		              *(_OWORD *)&v87.taauQuality = v86;
		              output = 0;
		              v44 = *(UIPostProcessConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20;
		              if ( !v44 )
		                sub_1800D8250(0LL, v43);
		              HG::Rendering::Runtime::UIPostProcessConstructor::ConstructPass(
		                v44,
		                &v87,
		                (UIPostProcessConstructor_PassOutput *)&output,
		                renderGraph,
		                *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                v38,
		                0LL);
		              v64.handle = *(ResourceHandle *)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              v65 = (TextureHandle)v41;
		              HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		                RTExtractionType__Enum_SceneColorPS,
		                &v65,
		                *(HGCamera **)&v64.handle,
		                renderGraph,
		                0LL);
		            }
		            catch ( Il2CppExceptionWrapper *v83 )
		            {
		              uiCamera = (HGCamera *)v83->ex;
		              if ( uiCamera )
		                sub_18007E1E0(uiCamera);
		              v4 = this;
		              hgrp = v70;
		              renderGraph = v71;
		              v38 = settingParameters;
		              v35 = hgCamera;
		            }
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x37u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		            v64.handle = 0LL;
		            v64.fallBackResource = (ResourceHandle)&v90;
		            try
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              v85.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_2D_LAYER.m_Mask;
		              v85.target = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                              &v65,
		                              (HGRenderPathBase *)v4,
		                              PassConstructorID__Enum_UI,
		                              0LL);
		              v46 = *(UIPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		              if ( !v46 )
		                sub_1800D8250(0LL, v45);
		              HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
		                v46,
		                &v85,
		                &v63,
		                renderGraph,
		                *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                v38,
		                0LL);
		            }
		            catch ( Il2CppExceptionWrapper *v84 )
		            {
		              v23 = (unsigned __int64)&v61;
		              v64.handle = (ResourceHandle)v84->ex;
		              handle = (MultiblurPassConstructor *)v64.handle;
		              if ( v64.handle )
		                sub_18007E1E0(*(_QWORD *)&v64.handle);
		              v4 = this;
		              hgrp = v70;
		              renderGraph = v71;
		              v38 = settingParameters;
		              v35 = hgCamera;
		            }
		            v47 = *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		            if ( v47 )
		            {
		              if ( *(int *)(v47 + 2424) > 0 )
		              {
		                v48 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                         &v65,
		                         (HGRenderPathBase *)v4,
		                         PassConstructorID__Enum_Multiblur,
		                         0LL);
		                memset(&v75.cullingResults, 0, 32);
		                v75.target = v48;
		                v75.hgrp = hgrp;
		                if ( dword_18F35FD08 )
		                {
		                  v49 = (((unsigned __int64)&v75.hgrp >> 12) & 0x1FFFFF) >> 6;
		                  v23 = ((unsigned __int64)&v75.hgrp >> 12) & 0x3F;
		                  _m_prefetchw(&qword_18F0BCBA0[v49 + 36190]);
		                  do
		                  {
		                    handle = (MultiblurPassConstructor *)(qword_18F0BCBA0[v49 + 36190] | (1LL << v23));
		                    v50 = qword_18F0BCBA0[v49 + 36190];
		                  }
		                  while ( v50 != _InterlockedCompareExchange64(
		                                   &qword_18F0BCBA0[v49 + 36190],
		                                   (signed __int64)handle,
		                                   v50) );
		                }
		                v75.cullingResults = cullingResults;
		                if ( !v35 )
		                  goto LABEL_70;
		                *(_QWORD *)&v75.screenCullingRatio = *(_QWORD *)&v35->fields.screenCullingRatio;
		                v75.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(v35, 0LL);
		                v80 = v75;
		                output = 0;
		                handle = *(MultiblurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		                if ( !handle )
		                  goto LABEL_70;
		                HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
		                  handle,
		                  &v80,
		                  (MultiblurPassConstructor_PassOutput *)&output,
		                  renderGraph,
		                  *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                  v38,
		                  0LL);
		                if ( v4->fields._._firstBackbufferPass_k__BackingField == 57 )
		                {
		                  backBufferColor_k__BackingField = (CullingResults)v4->fields._._backBufferColor_k__BackingField;
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		                  v65 = 0LL;
		                  cullingResults = backBufferColor_k__BackingField;
		                  v64 = v48;
		                  HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		                    renderGraph,
		                    &v64,
		                    (TextureHandle *)&cullingResults,
		                    0,
		                    -1,
		                    1,
		                    (Rect *)&v65,
		                    0,
		                    0LL);
		                }
		              }
		              v52 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                       &v65,
		                       (HGRenderPathBase *)v4,
		                       PassConstructorID__Enum_ScreenSpaceOverlay,
		                       0LL);
		              v53 = v52;
		              v76 = v52;
		              v77 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		              if ( dword_18F35FD08 )
		              {
		                v54 = (((unsigned __int64)&v77 >> 12) & 0x1FFFFF) >> 6;
		                v23 = ((unsigned __int64)&v77 >> 12) & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v54 + 36190]);
		                do
		                  v55 = qword_18F0BCBA0[v54 + 36190];
		                while ( v55 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v54 + 36190], v55 | (1LL << v23), v55) );
		                v53 = v76;
		              }
		              v78.target = v53;
		              v78.camera = v77;
		              output = 0;
		              handle = *(MultiblurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21;
		              if ( handle )
		              {
		                HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
		                  (ScreenSpaceOverlayPassConstructor *)handle,
		                  &v78,
		                  (ScreenSpaceOverlayPassConstructor_PassOutput *)&output,
		                  renderGraph,
		                  *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                  v38,
		                  0LL);
		                v56 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                v65 = v52;
		                HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		                  RTExtractionType__Enum_FinalResult,
		                  &v65,
		                  v56,
		                  renderGraph,
		                  0LL);
		                v65 = v52;
		                HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
		                  &v65,
		                  *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		                  renderGraph,
		                  0LL);
		                if ( v4->fields._._firstBackbufferPass_k__BackingField > 57 )
		                {
		                  v57 = (CullingResults)v4->fields._._backBufferColor_k__BackingField;
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		                  v65 = 0LL;
		                  cullingResults = v57;
		                  v64 = v52;
		                  HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		                    renderGraph,
		                    &v64,
		                    (TextureHandle *)&cullingResults,
		                    0,
		                    -1,
		                    1,
		                    (Rect *)&v65,
		                    0,
		                    0LL);
		                }
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_70:
		    sub_1800D8250(handle, v23);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3563, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v60, v59);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, renderPathParams, 0LL);
		}
		
		protected override PassConstructorID GetDefaultFirstBackbufferPass() => default; // 0x0000000189BEF81C-0x0000000189BEF86C
		// PassConstructorID GetDefaultFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPath3DUI::GetDefaultFirstBackbufferPass(
		        HGRenderPath3DUI *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3570, 0LL) )
		    return 54;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3570, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public PassConstructorID __iFixBaseProxy_FindFirstBackbufferPass() => default; // 0x0000000189BF05A8-0x0000000189BF05B0
		// PassConstructorID <>iFixBaseProxy_FindFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::__iFixBaseProxy_FindFirstBackbufferPass(
		        HGRenderPathUI *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::HGRenderPathBase::FindFirstBackbufferPass((HGRenderPathBase *)this, 0LL);
		}
		
		public PassConstructorID __iFixBaseProxy_GetDefaultFirstBackbufferPass() => default; // 0x0000000189BF05B0-0x0000000189BF05B8
		// PassConstructorID <>iFixBaseProxy_GetDefaultFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::__iFixBaseProxy_GetDefaultFirstBackbufferPass(
		        HGRenderPathUI *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::HGRenderPathBase::GetDefaultFirstBackbufferPass((HGRenderPathBase *)this, 0LL);
		}
		
	}
}
