using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathUI : HGRenderPathBase // TypeDefIndex: 38529
	{
		// Fields
		private UIImageBlurPassConstructor m_uiImageBlurPassConstructor; // 0x1268
		private UIPassConstructor m_uiPassConstructor; // 0x1270
		private MultiblurPassConstructor m_multiblurPassConstructor; // 0x1278
		private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor; // 0x1280
	
		// Constructors
		public HGRenderPathUI() {} // Dummy constructor
		internal HGRenderPathUI(HGRenderPathResources resources, HGCamera camera) {} // 0x0000000182ED9370-0x0000000182ED94E0
		// HGRenderPathUI(HGRenderPathBase+HGRenderPathResources, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathUI::HGRenderPathUI(
		        HGRenderPathUI *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  PassConstructorID__Enum__Array *v7; // rax
		  IPassConstructor *PassConstructor; // rbx
		  HGRenderPathBase_HGRenderPathResources *v9; // rdx
		  PassConstructorID__Enum__Array *v10; // r8
		  Int32__Array **v11; // r9
		  IPassConstructor *v12; // rbx
		  HGRenderPathBase_HGRenderPathResources *v13; // rdx
		  PassConstructorID__Enum__Array *v14; // r8
		  Int32__Array **v15; // r9
		  IPassConstructor *v16; // rbx
		  HGRenderPathBase_HGRenderPathResources *v17; // rdx
		  PassConstructorID__Enum__Array *v18; // r8
		  Int32__Array **v19; // r9
		  IPassConstructor *v20; // rbx
		  HGRenderPathBase_HGRenderPathResources *v21; // rdx
		  PassConstructorID__Enum__Array *v22; // r8
		  Int32__Array **v23; // r9
		  MethodInfo *v24; // [rsp+20h] [rbp-28h]
		  MethodInfo *v25; // [rsp+20h] [rbp-28h]
		  MethodInfo *v26; // [rsp+20h] [rbp-28h]
		  MethodInfo *v27; // [rsp+28h] [rbp-20h]
		  MethodInfo *v28; // [rsp+28h] [rbp-20h]
		  MethodInfo *v29; // [rsp+28h] [rbp-20h]
		  HGRenderPathBase_HGRenderPathResources v30; // [rsp+30h] [rbp-18h] BYREF
		  MethodInfo *v31; // [rsp+70h] [rbp+28h]
		  MethodInfo *v32; // [rsp+78h] [rbp+30h]
		
		  v7 = HG::Rendering::Runtime::HGRenderPathUI::PopulatePassConstructorIds(0LL);
		  v30 = *resources;
		  HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
		    (HGRenderPathBase *)this,
		    &v30,
		    v7,
		    camera,
		    HGRenderPathInternal__Enum_UI,
		    0LL);
		  PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                      (HGRenderPathBase *)this,
		                      PassConstructorID__Enum_UIImageBlur,
		                      0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = sub_180005050(
		                                                                                                   PassConstructor,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		  sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix,
		    v9,
		    v10,
		    v11,
		    v24,
		    v27);
		  v12 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_UI,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = sub_180005050(
		                                                                                                   v12,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		  sub_180005050(v12, TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20,
		    v13,
		    v14,
		    v15,
		    v25,
		    v28);
		  v16 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Multiblur,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = sub_180005050(
		                                                                                                   v16,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		  sub_180005050(v16, TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01,
		    v17,
		    v18,
		    v19,
		    v26,
		    v29);
		  v20 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ScreenSpaceOverlay,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 = sub_180005050(
		                                                                                                   v20,
		                                                                                                   TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		  sub_180005050(v20, TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathScene *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21,
		    v21,
		    v22,
		    v23,
		    v31,
		    v32);
		}
		
	
		// Methods
		private static PassConstructorID[] PopulatePassConstructorIds() => default; // 0x0000000182EDA4A0-0x0000000182EDA4F0
		// PassConstructorID[] PopulatePassConstructorIds()
		PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathUI::PopulatePassConstructorIds(MethodInfo *method)
		{
		  Array *v1; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3664, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3664, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1269(Patch, 0LL);
		  }
		  else
		  {
		    v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 4LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v1,
		      F74BEF5ED2311F0F4C64600C019B15F7FF319703043A2EA35063E8E5134F2F73_Field,
		      0LL);
		    return (PassConstructorID__Enum__Array *)v1;
		  }
		}
		
		protected override PassConstructorID FindFirstBackbufferPass() => default; // 0x0000000189C077B8-0x0000000189C078B8
		// PassConstructorID FindFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::FindFirstBackbufferPass(
		        HGRenderPathUI *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGCamera *v4; // rcx
		  __int64 v5; // rax
		  int v6; // esi
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *RTForExtraction; // rax
		  __m128i v8; // xmm6
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
		  unsigned __int64 v10; // xmm6_8
		  _BOOL8 v11; // rbx
		  PassConstructorID__Enum result; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v14; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3665, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3665, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_17;
		  }
		  v5 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		  if ( !v5 )
		    goto LABEL_17;
		  v6 = *(_DWORD *)(v5 + 2424);
		  RTForExtraction = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
		                      &v14,
		                      *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		                      RTExtractionType__Enum_FinalResult,
		                      0LL);
		  v4 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		  v8 = *(__m128i *)RTForExtraction;
		  if ( !v4 )
		    goto LABEL_17;
		  InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(v4, 0LL);
		  v4 = (HGCamera *)v8.m128i_i64[0];
		  if ( !v8.m128i_i64[0] )
		    goto LABEL_17;
		  if ( *(int *)(v8.m128i_i64[0] + 32) > 0 )
		    goto LABEL_10;
		  v10 = _mm_srli_si128(v8, 8).m128i_u64[0];
		  v4 = (HGCamera *)v10;
		  if ( !v10 )
		    goto LABEL_17;
		  if ( *(int *)(v10 + 32) > 0 )
		  {
		LABEL_10:
		    LODWORD(v11) = 1;
		    goto LABEL_11;
		  }
		  if ( !InplaceWaterMarkRTs )
		LABEL_17:
		    sub_1800D8260(v4, v3);
		  v11 = InplaceWaterMarkRTs->fields._size > 0;
		LABEL_11:
		  result = (unsigned int)sub_180002F70(6LL, this);
		  if ( v6 > 0 )
		    result = PassConstructorID__Enum_ScreenSpaceOverlay;
		  if ( v11 )
		    return 60;
		  return result;
		}
		
		protected override void RenderInternal(ref HGRenderPathParams renderPathParams) {} // 0x0000000189C07908-0x0000000189C083BC
		// Void RenderInternal(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGRenderPathUI::RenderInternal(
		        HGRenderPathUI *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v3; // rbx
		  HGRenderPathUI *v4; // r14
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r13
		  HGCamera *renderGraph; // r12
		  CullingResults cullingResults; // xmm9
		  unsigned __int64 v10; // rdx
		  UIImageBlurManager *instance; // rax
		  unsigned __int64 v12; // r8
		  signed __int64 v13; // rtt
		  UIImageBlurPassConstructor *v14; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rdi
		  Shader *blitPS; // rdi
		  void *ptr; // rbx
		  HGCamera *v21; // rbx
		  HGRenderPipelineRuntimeResources *v22; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *v23; // r8
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  TextureHandle v26; // xmm8
		  HGCamera *v27; // rbx
		  __m128i v28; // xmm6
		  RTHandle *UICameraClearRT; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  TextureHandle v32; // xmm6
		  unsigned __int64 v33; // r8
		  signed __int64 v34; // rtt
		  __int64 v35; // rdx
		  UIPassConstructor *v36; // rcx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rax
		  TextureHandle v40; // xmm8
		  unsigned __int64 v41; // rcx
		  signed __int64 v42; // rtt
		  __int64 v43; // rdx
		  MultiblurPassConstructor *v44; // rcx
		  HGSettingParameters *v45; // rbx
		  TextureHandle backBufferColor_k__BackingField; // xmm6
		  unsigned __int64 v47; // rdx
		  TextureHandle v48; // xmm6
		  TextureHandle v49; // xmm0
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  ScreenSpaceOverlayPassConstructor *v52; // rcx
		  IPassConstructor *PassConstructor; // rbx
		  ComposablePass *v54; // rdi
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  ComposablePass *v57; // rax
		  HGCamera *v58; // rbx
		  TextureHandle v59; // xmm7
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  UIImageBlurPassConstructor_PassOutput output; // [rsp+50h] [rbp-258h] BYREF
		  CullingResults v64; // [rsp+60h] [rbp-248h] BYREF
		  HGSettingParameters *settingParameters; // [rsp+70h] [rbp-238h]
		  HGCamera *uiCamera[2]; // [rsp+80h] [rbp-228h] BYREF
		  TextureHandle v67; // [rsp+90h] [rbp-218h] BYREF
		  UIImageBlurManager *v68; // [rsp+A0h] [rbp-208h] BYREF
		  HGRenderPipeline *v69; // [rsp+A8h] [rbp-200h]
		  Il2CppException *ex; // [rsp+B0h] [rbp-1F8h]
		  char *v71; // [rsp+B8h] [rbp-1F0h]
		  UIImageBlurPassConstructor_PassInput input; // [rsp+C0h] [rbp-1E8h] BYREF
		  HGCamera *hgCamera; // [rsp+C8h] [rbp-1E0h]
		  MultiblurPassConstructor_PassInput v74; // [rsp+D0h] [rbp-1D8h] BYREF
		  TextureHandle v75; // [rsp+108h] [rbp-1A0h]
		  HGCamera *v76; // [rsp+118h] [rbp-190h] BYREF
		  ScreenSpaceOverlayPassConstructor_PassInput v77; // [rsp+120h] [rbp-188h] BYREF
		  UIPassConstructor_PassInput v78; // [rsp+140h] [rbp-168h] BYREF
		  MultiblurPassConstructor_PassInput v79; // [rsp+190h] [rbp-118h] BYREF
		  Il2CppExceptionWrapper *v80; // [rsp+1C8h] [rbp-E0h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+1D0h] [rbp-D8h] BYREF
		  UIPassConstructor_PassInput v82; // [rsp+1E0h] [rbp-C8h] BYREF
		  char v85; // [rsp+2C8h] [rbp+20h] BYREF
		
		  v3 = renderPathParams;
		  v4 = this;
		  v85 = 0;
		  input.uiImageBlurMgr = 0LL;
		  sub_18033B9D0(&v82, 0LL, 80LL);
		  sub_18033B9D0(&v78, 0LL, 80LL);
		  memset(&v79, 0, sizeof(v79));
		  memset(&v74, 0, sizeof(v74));
		  memset(&v77, 0, sizeof(v77));
		  v75 = 0LL;
		  v76 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3666, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3666, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v62, v61);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, v3, 0LL);
		  }
		  else
		  {
		    hgrp = v3->hgrp;
		    v69 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = (HGCamera *)HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    uiCamera[0] = renderGraph;
		    cullingResults = v3->renderRequest.cullingResults.cullingResults;
		    v64 = cullingResults;
		    settingParameters = hgrp->fields._settingParameters_k__BackingField;
		    hgCamera = v3->renderRequest.hgCamera;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v71 = &v85;
		    try
		    {
		      v68 = 0LL;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		      instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		      v68 = instance;
		      if ( dword_18F35FD08 )
		      {
		        v12 = (((unsigned __int64)&v68 >> 12) & 0x1FFFFF) >> 6;
		        v10 = ((unsigned __int64)&v68 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v12 + 36190]);
		        do
		          v13 = qword_18F0BCBA0[v12 + 36190];
		        while ( v13 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v12 + 36190], v13 | (1LL << v10), v13) );
		        instance = v68;
		      }
		      input.uiImageBlurMgr = instance;
		      output = 0;
		      v14 = *(UIImageBlurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		      if ( !v14 )
		        sub_1800D8250(0LL, v10);
		      HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
		        v14,
		        &input,
		        &output,
		        (HGRenderGraph *)renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v80 )
		    {
		      ex = v80->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = this;
		      hgrp = v69;
		      renderGraph = uiCamera[0];
		      cullingResults = v64;
		      v3 = renderPathParams;
		    }
		    uiCamera[0] = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		    defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		    if ( !defaultResources )
		      goto LABEL_59;
		    shaders = defaultResources->fields.shaders;
		    if ( !shaders
		      || (blitPS = shaders->fields.blitPS,
		          ptr = v3->renderRequest.cullingResults.cullingResults.ptr,
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils),
		          HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(
		            uiCamera[0],
		            uiCamera[0],
		            blitPS,
		            ptr,
		            (HGRenderGraph *)renderGraph,
		            renderPathParams,
		            0LL),
		          v21 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		          (v22 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL)) == 0LL)
		      || (v23 = v22->fields.shaders) == 0LL )
		    {
		LABEL_59:
		      sub_1800D8250(v17, v16);
		    }
		    HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
		      v21,
		      v21,
		      v23->fields.blitPS,
		      renderPathParams->renderRequest.cullingResults.cullingResults.ptr,
		      (HGRenderGraph *)renderGraph,
		      renderPathParams,
		      0LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x37u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v71 = &v85;
		    try
		    {
		      v26 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		               (TextureHandle *)&v64,
		               (HGRenderPathBase *)v4,
		               PassConstructorID__Enum_UI,
		               0LL);
		      v27 = hgCamera;
		      if ( !hgCamera )
		        sub_1800D8250(v25, v24);
		      if ( HG::Rendering::Runtime::HGCamera::get_clearColorMode(hgCamera, 0LL) == HGAdditionalCameraData_ClearColorMode__Enum_Color )
		      {
		        v28 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGCamera::get_backgroundColorHDR(
		                                                 (Color *)&v64,
		                                                 v27,
		                                                 0LL));
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v64 = (CullingResults)v28;
		        UICameraClearRT = HG::Rendering::Runtime::HGUtils::GetOrCreateUICameraClearRT((Color *)&v64, 0LL);
		        if ( !renderGraph )
		          sub_1800D8250(v31, v30);
		        v32 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                 (TextureHandle *)&v64,
		                 (HGRenderGraph *)renderGraph,
		                 UICameraClearRT,
		                 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		        v64 = 0LL;
		        v67 = v26;
		        *(TextureHandle *)uiCamera = v32;
		        HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		          (HGRenderGraph *)renderGraph,
		          (TextureHandle *)uiCamera,
		          &v67,
		          0,
		          -1,
		          0,
		          (Rect *)&v64,
		          0,
		          0LL);
		      }
		      sub_18033B9D0(&v78, 0LL, 80LL);
		      v78.target = v26;
		      v78.hgrp = hgrp;
		      if ( dword_18F35FD08 )
		      {
		        v33 = (((unsigned __int64)&v78.hgrp >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v33 + 36190]);
		        do
		          v34 = qword_18F0BCBA0[v33 + 36190];
		        while ( v34 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v33 + 36190],
		                         v34 | (1LL << (((unsigned __int64)&v78.hgrp >> 12) & 0x3F)),
		                         v34) );
		      }
		      v78.cullingResults = cullingResults;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v78.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_2D_LAYER.m_Mask;
		      v78.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(hgrp, 0LL);
		      *(_QWORD *)&v78.screenCullingRatio = *(_QWORD *)&v27->fields.screenCullingRatio;
		      v78.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(v27, 0LL);
		      v82 = v78;
		      output = 0;
		      v36 = *(UIPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20;
		      if ( !v36 )
		        sub_1800D8250(0LL, v35);
		      HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
		        v36,
		        &v82,
		        (UIPassConstructor_PassOutput *)&output,
		        (HGRenderGraph *)renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		        settingParameters,
		        0LL);
		      v39 = *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		      if ( !v39 )
		        sub_1800D8250(v38, v37);
		      if ( *(int *)(v39 + 2424) <= 0 )
		      {
		        v45 = settingParameters;
		      }
		      else
		      {
		        v40 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                 (TextureHandle *)&v64,
		                 (HGRenderPathBase *)v4,
		                 PassConstructorID__Enum_Multiblur,
		                 0LL);
		        memset(&v74.cullingResults, 0, 32);
		        v74.target = v40;
		        v74.hgrp = hgrp;
		        if ( dword_18F35FD08 )
		        {
		          v41 = (((unsigned __int64)&v74.hgrp >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v41 + 36190]);
		          do
		            v42 = qword_18F0BCBA0[v41 + 36190];
		          while ( v42 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v41 + 36190],
		                           v42 | (1LL << (((unsigned __int64)&v74.hgrp >> 12) & 0x3F)),
		                           v42) );
		        }
		        v74.cullingResults = cullingResults;
		        *(_QWORD *)&v74.screenCullingRatio = *(_QWORD *)&v27->fields.screenCullingRatio;
		        v74.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(v27, 0LL);
		        v79 = v74;
		        output = 0;
		        v44 = *(MultiblurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		        if ( !v44 )
		          sub_1800D8250(0LL, v43);
		        v45 = settingParameters;
		        HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
		          v44,
		          &v79,
		          (MultiblurPassConstructor_PassOutput *)&output,
		          (HGRenderGraph *)renderGraph,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		          settingParameters,
		          0LL);
		        if ( v4->fields._._firstBackbufferPass_k__BackingField == 57 )
		        {
		          backBufferColor_k__BackingField = v4->fields._._backBufferColor_k__BackingField;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          v64 = 0LL;
		          v67 = backBufferColor_k__BackingField;
		          *(TextureHandle *)uiCamera = v40;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		            (HGRenderGraph *)renderGraph,
		            (TextureHandle *)uiCamera,
		            &v67,
		            0,
		            -1,
		            1,
		            (Rect *)&v64,
		            0,
		            0LL);
		        }
		      }
		      v48 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		               (TextureHandle *)&v64,
		               (HGRenderPathBase *)v4,
		               PassConstructorID__Enum_ScreenSpaceOverlay,
		               0LL);
		      v49 = v48;
		      v75 = v48;
		      v76 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		      if ( dword_18F35FD08 )
		      {
		        v50 = (((unsigned __int64)&v76 >> 12) & 0x1FFFFF) >> 6;
		        v47 = ((unsigned __int64)&v76 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		        do
		          v51 = qword_18F0BCBA0[v50 + 36190];
		        while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v51 | (1LL << v47), v51) );
		        v49 = v75;
		      }
		      v77.target = v49;
		      v77.camera = v76;
		      output = 0;
		      v52 = *(ScreenSpaceOverlayPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21;
		      if ( !v52 )
		        sub_1800D8250(0LL, v47);
		      HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
		        v52,
		        &v77,
		        (ScreenSpaceOverlayPassConstructor_PassOutput *)&output,
		        (HGRenderGraph *)renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		        v45,
		        0LL);
		      if ( v4->fields._._firstBackbufferPass_k__BackingField < 57 )
		      {
		        PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                            (HGRenderPathBase *)v4,
		                            (PassConstructorID__Enum)v4->fields._._firstBackbufferPass_k__BackingField,
		                            0LL);
		        v54 = *(ComposablePass **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21;
		        if ( !sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass) )
		          sub_1800D8250(v56, v55);
		        v57 = (ComposablePass *)sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass);
		        HG::Rendering::Runtime::ComposablePass::SetChildPass(v57, (HGRenderGraph *)renderGraph, v54, 0LL);
		      }
		      v58 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v64 = (CullingResults)v48;
		      HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		        RTExtractionType__Enum_FinalResult,
		        (TextureHandle *)&v64,
		        v58,
		        (HGRenderGraph *)renderGraph,
		        0LL);
		      v64 = (CullingResults)v48;
		      HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
		        (TextureHandle *)&v64,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		        (HGRenderGraph *)renderGraph,
		        0LL);
		      if ( v4->fields._._firstBackbufferPass_k__BackingField > 57 )
		      {
		        v59 = v4->fields._._backBufferColor_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		        v64 = 0LL;
		        v67 = v59;
		        *(TextureHandle *)uiCamera = v48;
		        HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		          (HGRenderGraph *)renderGraph,
		          (TextureHandle *)uiCamera,
		          &v67,
		          0,
		          -1,
		          1,
		          (Rect *)&v64,
		          0,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v81 )
		    {
		      ex = v81->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		protected override PassConstructorID GetDefaultFirstBackbufferPass() => default; // 0x0000000189C078B8-0x0000000189C07908
		// PassConstructorID GetDefaultFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::GetDefaultFirstBackbufferPass(
		        HGRenderPathUI *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3669, 0LL) )
		    return 55;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3669, 0LL);
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
