using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPathDeferred : HGRenderPathScene // TypeDefIndex: 38522
	{
		// Fields
		internal const int MAX_GBUFFER_COUNT = 8; // Metadata: 0x02303DB9
		protected GBufferProfileManager m_gBufferProfileMgr; // 0x13B0
		protected uint m_deferredOpaquePreZECSList; // 0x13C0
		protected uint m_forwardOpaquePreZECSList; // 0x13C4
		protected uint m_characterOpaqueOutlinePreZECSList; // 0x13C8
		protected uint m_deferredGrassPreZECSList; // 0x13CC
		protected uint m_deferredTreePreZECSList; // 0x13D0
		protected uint m_characterPrePassECSList; // 0x13D4
		protected uint m_deferredOpaqueECSList; // 0x13D8
		protected uint m_deferredOpaqueEqualECSList; // 0x13DC
		protected uint m_deferredGrassECSList; // 0x13E0
		protected uint m_deferredTreeECSList; // 0x13E4
		protected uint m_deferredSludgeECSList; // 0x13E8
		protected uint m_forwardOpaqueECSList; // 0x13EC
		protected uint m_forwardOpaqueEqualECSList; // 0x13F0
		protected uint m_characterOpaqueOutlineECSList; // 0x13F4
		protected uint m_characterOpaqueOutlineEqualECSList; // 0x13F8
		protected uint m_characterOpaqueECSList; // 0x13FC
		protected uint m_forwardTransparentECSList; // 0x1400
		protected uint m_forwardTransparentAfterDistortionECSList; // 0x1404
		protected uint m_forwardReflectionECSList; // 0x1408
		protected uint m_deferredOpaquePreZGPUDrivenList; // 0x140C
		protected uint m_deferredOpaqueGPUDrivenList; // 0x1410
		protected uint m_deferredOpaqueEqualGPUDrivenList; // 0x1414
	
		// Properties
		protected GBufferOutput gBufferOutput { get; private set; } // 0x0000000184DA1840-0x0000000184DA1860 0x0000000184DA1880-0x0000000184DA18A0
		// GBufferOutput get_gBufferOutput()
		GBufferOutput *HG::Rendering::Runtime::HGRenderPathDeferred::get_gBufferOutput(
		        GBufferOutput *__return_ptr retstr,
		        HGRenderPathDeferred *this,
		        MethodInfo *method)
		{
		  GBufferOutput *result; // rax
		  NativeArray_1_System_Int32_ v4; // xmm1
		
		  result = retstr;
		  v4 = *(NativeArray_1_System_Int32_ *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		  retstr->m_attachments = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		  retstr->m_gbufferMapping = v4;
		  return result;
		}
		

		// Void set_gBufferOutput(GBufferOutput)
		void HG::Rendering::Runtime::HGRenderPathDeferred::set_gBufferOutput(
		        HGRenderPathDeferred *this,
		        GBufferOutput *value,
		        MethodInfo *method)
		{
		  NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
		
		  m_gbufferMapping = value->m_gbufferMapping;
		  *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = value->m_attachments;
		  *(NativeArray_1_System_Int32_ *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02 = m_gbufferMapping;
		}
		
		internal CustomDepthOnlyRequestManager customDepthOnlyRequestMgr { get; private set; } // 0x0000000184DA1810-0x0000000184DA1820 0x0000000189BF7BC8-0x0000000189BF7BDC
		// CustomDepthOnlyRequestManager get_customDepthOnlyRequestMgr()
		CustomDepthOnlyRequestManager *HG::Rendering::Runtime::HGRenderPathDeferred::get_customDepthOnlyRequestMgr(
		        HGRenderPathDeferred *this,
		        MethodInfo *method)
		{
		  return *(CustomDepthOnlyRequestManager **)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		}
		

		// Void set_customDepthOnlyRequestMgr(CustomDepthOnlyRequestManager)
		void HG::Rendering::Runtime::HGRenderPathDeferred::set_customDepthOnlyRequestMgr(
		        HGRenderPathDeferred *this,
		        CustomDepthOnlyRequestManager *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = value;
		  sub_18002D1B0(
		    (HGRenderPathDefaultDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23,
		    (HGRenderPathBase_HGRenderPathResources *)value,
		    (HGCamera *)method,
		    v3,
		    v4);
		}
		
		protected bool enableGPUDriven { get; private set; } // 0x0000000184DA1830-0x0000000184DA1840 0x0000000184DA1870-0x0000000184DA1880
		// Boolean get_enableGPUDriven()
		bool HG::Rendering::Runtime::HGRenderPathDeferred::get_enableGPUDriven(HGRenderPathDeferred *this, MethodInfo *method)
		{
		  return LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21);
		}
		

		// Void set_enableGPUDriven(Boolean)
		void HG::Rendering::Runtime::HGRenderPathDeferred::set_enableGPUDriven(
		        HGRenderPathDeferred *this,
		        bool value,
		        MethodInfo *method)
		{
		  LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) = value;
		}
		
		protected bool enableGPUDrivenInspection { get; private set; } // 0x0000000184DA1820-0x0000000184DA1830 0x0000000184DA1860-0x0000000184DA1870
		// Boolean get_enableGPUDrivenInspection()
		bool HG::Rendering::Runtime::HGRenderPathDeferred::get_enableGPUDrivenInspection(
		        HGRenderPathDeferred *this,
		        MethodInfo *method)
		{
		  return BYTE1(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21);
		}
		

		// Void set_enableGPUDrivenInspection(Boolean)
		void HG::Rendering::Runtime::HGRenderPathDeferred::set_enableGPUDrivenInspection(
		        HGRenderPathDeferred *this,
		        bool value,
		        MethodInfo *method)
		{
		  BYTE1(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) = value;
		}
		
	
		// Constructors
		protected HGRenderPathDeferred() {} // Dummy constructor
		internal HGRenderPathDeferred(HGRenderPathResources resources, PassConstructorID[] passConstructorIDs, HGCamera camera, HGRenderPathInternal renderPath) {} // 0x0000000182EDA4F0-0x0000000182EDA650
		// HGRenderPathDeferred(HGRenderPathBase+HGRenderPathResources, PassConstructorID[], HGCamera, HGRenderPathInternal)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGRenderPathDeferred::HGRenderPathDeferred(
		        HGRenderPathDeferred *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        PassConstructorID__Enum__Array *passConstructorIDs,
		        HGCamera *camera,
		        HGRenderPathInternal__Enum renderPath,
		        MethodInfo *method)
		{
		  GBufferProfileManager *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  GBufferProfileManager *v13; // rdi
		  HGRenderPathBase_HGRenderPathResources *v14; // rdx
		  PassConstructorID__Enum__Array *v15; // r8
		  Int32__Array **v16; // r9
		  CustomDepthOnlyRequestManager *v17; // rax
		  CustomDepthOnlyRequestManager *v18; // rdi
		  HGRenderPathBase_HGRenderPathResources *v19; // rdx
		  PassConstructorID__Enum__Array *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *v22; // [rsp+20h] [rbp-28h]
		  MethodInfo *v23; // [rsp+28h] [rbp-20h]
		  HGRenderPathBase_HGRenderPathResources v24; // [rsp+30h] [rbp-18h] BYREF
		
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = -1LL;
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = -1LL;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		  v24 = *resources;
		  HG::Rendering::Runtime::HGRenderPathScene::HGRenderPathScene(
		    (HGRenderPathScene *)this,
		    &v24,
		    passConstructorIDs,
		    camera,
		    renderPath,
		    0LL);
		  v10 = (GBufferProfileManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GBufferProfileManager);
		  v13 = v10;
		  if ( !v10
		    || (HG::Rendering::Runtime::GBufferProfileManager::GBufferProfileManager(v10, 0LL),
		        *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 = v13,
		        sub_18002D1B0((HGRenderPathDeferred *)((char *)this + 5040), v14, v15, v16, v22, v23),
		        v17 = (CustomDepthOnlyRequestManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager),
		        (v18 = v17) == 0LL) )
		  {
		    sub_1800D8260(v12, v11);
		  }
		  HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CustomDepthOnlyRequestManager(v17, 0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = v18;
		  sub_18002D1B0((HGRenderPathDeferred *)((char *)this + 5048), v19, v20, v21, *(MethodInfo **)&renderPath, method);
		}
		
	
		// Methods
		internal override void Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CB0310-0x0000000184CB0360
		// Void Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::HGRenderPathDeferred::Dispose(
		        HGRenderPathDeferred *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  CustomDepthOnlyRequestManager *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3605, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3605, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    v5 = *(CustomDepthOnlyRequestManager **)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		    if ( v5 )
		      HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Dispose(v5, 0LL);
		    HG::Rendering::Runtime::HGRenderPathScene::Dispose((HGRenderPathScene *)this, renderGraph, 0LL);
		  }
		}
		
		protected override void OnPreRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF6CBC-0x0000000189BF7AA0
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering(
		        HGRenderPathDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPipeline *hgrp; // rcx
		  __int64 v6; // r8
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  char *static_fields; // rdx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  CullingResults cullingResults; // xmm0
		  __int128 v15; // xmm1
		  HGRenderGraph *renderGraph; // rax
		  HGCamera *v17; // r14
		  HGRenderGraph *v18; // r15
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  bool v20; // r12
		  bool v21; // si
		  bool v22; // al
		  bool enabledForCPUCommands; // si
		  GBufferOutput *v24; // rax
		  NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
		  uint32_t cullingViewHandle; // r12d
		  HGRenderGraphContext *HGContext; // rbx
		  float v28; // esi
		  float v29; // eax
		  uint32_t v30; // r12d
		  HGRenderGraphContext *v31; // rbx
		  float v32; // eax
		  float v33; // eax
		  float v34; // eax
		  uint32_t v35; // r12d
		  HGRenderGraphContext *v36; // rbx
		  float v37; // eax
		  float v38; // eax
		  bool v39; // r13
		  float v40; // eax
		  uint32_t v41; // r12d
		  HGRenderGraphContext *v42; // rbx
		  void *m_Ptr; // rdx
		  float v44; // eax
		  float v45; // eax
		  float v46; // eax
		  uint32_t v47; // r12d
		  HGRenderGraphContext *v48; // rbx
		  float v49; // eax
		  uint32_t v50; // r12d
		  HGRenderGraphContext *v51; // rbx
		  float v52; // eax
		  uint32_t v53; // ecx
		  uint32_t v54; // edx
		  uint32_t v55; // r12d
		  HGRenderGraphContext *v56; // rbx
		  float v57; // eax
		  float v58; // eax
		  Camera *camera; // r12
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  HGRenderGraphContext *v61; // r13
		  uint32_t v62; // edx
		  float v63; // eax
		  uint32_t v64; // r13d
		  HGRenderFlags__Enum v65; // ebx
		  int v66; // r12d
		  float v67; // eax
		  int v68; // ebx
		  HGRenderGraphContext *v69; // r12
		  float v70; // eax
		  uint32_t v71; // r12d
		  HGRenderGraphContext *v72; // rbx
		  float v73; // eax
		  uint32_t v74; // r12d
		  HGRenderGraphContext *v75; // rbx
		  float v76; // eax
		  uint32_t v77; // r12d
		  HGRenderGraphContext *v78; // rbx
		  void *v79; // rax
		  float v80; // eax
		  float v81; // eax
		  float v82; // eax
		  uint32_t v83; // r14d
		  HGRenderGraphContext *v84; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRenderKeyword__Enum globalKeywords; // [rsp+28h] [rbp-F0h]
		  HGRenderKeyword__Enum globalKeywordsa; // [rsp+28h] [rbp-F0h]
		  HGRenderKeyword__Enum globalKeywordsb; // [rsp+28h] [rbp-F0h]
		  char cullingLayerMask; // [rsp+48h] [rbp-D0h]
		  bool v90; // [rsp+98h] [rbp-80h]
		  bool v91; // [rsp+99h] [rbp-7Fh]
		  bool v92; // [rsp+9Ah] [rbp-7Eh]
		  bool CharOutlinePassEnableState; // [rsp+9Bh] [rbp-7Dh]
		  bool v94; // [rsp+9Ch] [rbp-7Ch]
		  bool v95; // [rsp+9Dh] [rbp-7Bh]
		  bool v96; // [rsp+9Eh] [rbp-7Ah]
		  bool v97; // [rsp+9Fh] [rbp-79h]
		  bool v98; // [rsp+A0h] [rbp-78h]
		  bool v99; // [rsp+A1h] [rbp-77h]
		  bool v100; // [rsp+A2h] [rbp-76h]
		  bool v101; // [rsp+A3h] [rbp-75h]
		  bool v102; // [rsp+A4h] [rbp-74h]
		  uint32_t normalList; // [rsp+A8h] [rbp-70h] BYREF
		  uint32_t preZPart0List; // [rsp+ACh] [rbp-6Ch] BYREF
		  uint32_t preZPart1List; // [rsp+B0h] [rbp-68h] BYREF
		  uint32_t v106; // [rsp+B4h] [rbp-64h] BYREF
		  uint32_t v107; // [rsp+B8h] [rbp-60h] BYREF
		  uint32_t v108; // [rsp+BCh] [rbp-5Ch] BYREF
		  uint32_t v109; // [rsp+C0h] [rbp-58h] BYREF
		  uint32_t v110; // [rsp+C4h] [rbp-54h] BYREF
		  uint32_t v111; // [rsp+C8h] [rbp-50h] BYREF
		  uint32_t v112; // [rsp+CCh] [rbp-4Ch] BYREF
		  uint32_t v113; // [rsp+D0h] [rbp-48h] BYREF
		  uint32_t v114; // [rsp+D4h] [rbp-44h] BYREF
		  uint32_t v115; // [rsp+D8h] [rbp-40h] BYREF
		  uint32_t v116; // [rsp+DCh] [rbp-3Ch] BYREF
		  uint32_t viewHandle[2]; // [rsp+E0h] [rbp-38h]
		  uint32_t v118; // [rsp+E8h] [rbp-30h] BYREF
		  GBufferOutput v119; // [rsp+F0h] [rbp-28h] BYREF
		  HGCamera *v120; // [rsp+118h] [rbp+0h] BYREF
		  bool v121; // [rsp+3E0h] [rbp+2C8h]
		  int32_t renderPath_k__BackingField; // [rsp+3E0h] [rbp+2C8h]
		  uint32_t v123; // [rsp+3E0h] [rbp+2C8h]
		  bool enableTransparentAfterDOF; // [rsp+3E0h] [rbp+2C8h]
		
		  normalList = 0;
		  preZPart0List = 0;
		  preZPart1List = 0;
		  v106 = 0;
		  v107 = 0;
		  v108 = 0;
		  v118 = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3574, 0LL) )
		  {
		    HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering((HGRenderPathScene *)this, renderPathParams, 0LL);
		    hgrp = renderPathParams->hgrp;
		    v6 = 5LL;
		    p_renderRequest = &renderPathParams->renderRequest;
		    static_fields = (char *)&v120;
		    do
		    {
		      v9 = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		      *(_OWORD *)static_fields = *(_OWORD *)&p_renderRequest->hgCamera;
		      v10 = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		      *((_OWORD *)static_fields + 1) = v9;
		      v11 = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		      *((_OWORD *)static_fields + 2) = v10;
		      v12 = *(_OWORD *)&p_renderRequest->target.face;
		      *((_OWORD *)static_fields + 3) = v11;
		      v13 = *(_OWORD *)&p_renderRequest->target.targetDepth;
		      *((_OWORD *)static_fields + 4) = v12;
		      cullingResults = p_renderRequest->cullingResults.cullingResults;
		      *((_OWORD *)static_fields + 5) = v13;
		      v15 = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		      p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		      *((CullingResults *)static_fields + 6) = cullingResults;
		      static_fields += 128;
		      *((_OWORD *)static_fields - 1) = v15;
		      --v6;
		    }
		    while ( v6 );
		    if ( hgrp )
		    {
		      renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		      v17 = v120;
		      v18 = renderGraph;
		      if ( v120 )
		      {
		        volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(v120, 0LL);
		        if ( volumeComponentsData )
		        {
		          hgrp = (HGRenderPipeline *)volumeComponentsData->fields.m_hgCharacterVolume;
		          if ( hgrp )
		          {
		            CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                                           (HGCharacterVolume *)hgrp,
		                                           0LL);
		            v20 = UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL);
		            v21 = UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL);
		            LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) = v20 || v21;
		            if ( v20 )
		              UnityEngine::HyperGryph::GPUDrivenRendererV1::ToggleCullingInspectionMode(0, 0LL);
		            if ( v21 )
		              UnityEngine::HyperGryph::GPUDrivenRendererV2::ToggleCullingInspectionMode(0, 0LL);
		            v22 = v20 && UnityEngine::HyperGryph::GPUDrivenRendererV1::CullingInspectionMode(0LL)
		               || v21 && UnityEngine::HyperGryph::GPUDrivenRendererV2::CullingInspectionMode(0LL);
		            BYTE1(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) = v22;
		            if ( LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) )
		            {
		              if ( UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL) )
		                UnityEngine::HyperGryph::GPUDrivenRendererV1::AdvanceFrame(0LL);
		              if ( UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL) )
		                UnityEngine::HyperGryph::GPUDrivenRendererV2::AdvanceFrame(0LL);
		            }
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		            hgrp = (HGRenderPipeline *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterPrePass;
		            if ( hgrp )
		            {
		              enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                        (HGGraphicsFeatureSwitch *)hgrp,
		                                        0LL);
		              static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		              hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 11);
		              if ( hgrp )
		              {
		                v91 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                        (HGGraphicsFeatureSwitch *)hgrp,
		                        0LL);
		                static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 12);
		                if ( hgrp )
		                {
		                  v92 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                          (HGGraphicsFeatureSwitch *)hgrp,
		                          0LL);
		                  static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                  hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 13);
		                  if ( hgrp )
		                  {
		                    v121 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                             (HGGraphicsFeatureSwitch *)hgrp,
		                             0LL);
		                    static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                    hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 14);
		                    if ( hgrp )
		                    {
		                      v95 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                              (HGGraphicsFeatureSwitch *)hgrp,
		                              0LL);
		                      static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                      hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 15);
		                      if ( hgrp )
		                      {
		                        v96 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                (HGGraphicsFeatureSwitch *)hgrp,
		                                0LL);
		                        static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                        hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 16);
		                        if ( hgrp )
		                        {
		                          v94 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  (HGGraphicsFeatureSwitch *)hgrp,
		                                  0LL);
		                          static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                          hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 17);
		                          if ( hgrp )
		                          {
		                            v97 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                    (HGGraphicsFeatureSwitch *)hgrp,
		                                    0LL);
		                            static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                            hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 20);
		                            if ( hgrp )
		                            {
		                              v98 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                      (HGGraphicsFeatureSwitch *)hgrp,
		                                      0LL);
		                              static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                              hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 22);
		                              if ( hgrp )
		                              {
		                                v90 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                        (HGGraphicsFeatureSwitch *)hgrp,
		                                        0LL);
		                                static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                                hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 23);
		                                if ( hgrp )
		                                {
		                                  v99 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                          (HGGraphicsFeatureSwitch *)hgrp,
		                                          0LL);
		                                  static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                                  hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 24);
		                                  if ( hgrp )
		                                  {
		                                    v100 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                             (HGGraphicsFeatureSwitch *)hgrp,
		                                             0LL);
		                                    static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                                    hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 25);
		                                    if ( hgrp )
		                                    {
		                                      v101 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                               (HGGraphicsFeatureSwitch *)hgrp,
		                                               0LL);
		                                      static_fields = (char *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		                                      hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 27);
		                                      if ( hgrp )
		                                      {
		                                        v102 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                                 (HGGraphicsFeatureSwitch *)hgrp,
		                                                 0LL);
		                                        v24 = HG::Rendering::Runtime::HGRenderPathDeferred::PrepareGBufferOutput(
		                                                &v119,
		                                                this,
		                                                renderPathParams,
		                                                0LL);
		                                        m_gbufferMapping = v24->m_gbufferMapping;
		                                        *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = v24->m_attachments;
		                                        *(NativeArray_1_System_Int32_ *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02 = m_gbufferMapping;
		                                        if ( enabledForCPUCommands )
		                                        {
		                                          cullingViewHandle = v17->fields.cullingViewHandle;
		                                          if ( !v18 )
		                                            goto LABEL_123;
		                                          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                        v18,
		                                                        0LL);
		                                          if ( !HGContext )
		                                            goto LABEL_123;
		                                          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                          v28 = NAN;
		                                          LOWORD(globalKeywords) = 0;
		                                          v29 = COERCE_FLOAT(
		                                                  UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                    cullingViewHandle,
		                                                    HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                                    HGRenderFlags__Enum_Opaque,
		                                                    HGShaderLightMode__Enum_DepthCharacterOnly,
		                                                    globalKeywords,
		                                                    HGContext->fields.renderContext.m_Ptr,
		                                                    0,
		                                                    0,
		                                                    0xFFFFFFFF,
		                                                    0,
		                                                    0,
		                                                    0LL));
		                                        }
		                                        else
		                                        {
		                                          v28 = NAN;
		                                          v29 = NAN;
		                                        }
		                                        this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m11 = v29;
		                                        this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = NAN;
		                                        this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m30 = NAN;
		                                        this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11 = NAN;
		                                        if ( !LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) )
		                                          goto LABEL_64;
		                                        if ( UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL) )
		                                        {
		                                          v30 = v17->fields.cullingViewHandle;
		                                          if ( !v18 )
		                                            goto LABEL_123;
		                                          v31 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		                                          if ( !v31 )
		                                            goto LABEL_123;
		                                          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                          UnityEngine::HyperGryph::GPUDrivenRendererV1::CreateRendererListWithPreZ(
		                                            v30,
		                                            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                            HGRenderFlags__Enum_Opaque,
		                                            HGShaderLightMode__Enum_GBuffer,
		                                            v31->fields.renderContext.m_Ptr,
		                                            1,
		                                            &normalList,
		                                            &preZPart0List,
		                                            &preZPart1List,
		                                            &v17->fields.mainViewConstants.viewMatrix,
		                                            &v17->fields.mainViewConstants.projMatrix,
		                                            &v17->fields.mainViewConstants.nonJitteredProjMatrix,
		                                            &v17->fields.zBufferParams,
		                                            &v17->fields.mainViewConstants.prevViewMatrix,
		                                            &v17->fields.mainViewConstants.prevViewProjMatrix,
		                                            &v17->fields.mainViewConstants.prevNonJitteredViewProjMatrix,
		                                            &v17->fields.mainViewConstants.worldSpaceCameraPos,
		                                            0LL);
		                                          v32 = NAN;
		                                          if ( v91 )
		                                            v32 = *(float *)&normalList;
		                                          this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = v32;
		                                          v33 = NAN;
		                                          if ( v92 )
		                                            v33 = *(float *)&preZPart0List;
		                                          this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m30 = v33;
		                                          v34 = NAN;
		                                          if ( v121 )
		                                            v34 = *(float *)&preZPart1List;
		                                          this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11 = v34;
		                                        }
		                                        if ( LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21)
		                                          && UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL) )
		                                        {
		                                          v35 = v17->fields.cullingViewHandle;
		                                          if ( !v18 )
		                                            goto LABEL_123;
		                                          v36 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		                                          if ( !v36 )
		                                            goto LABEL_123;
		                                          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                          UnityEngine::HyperGryph::GPUDrivenRendererV2::CreateRendererListWithPreZ(
		                                            v35,
		                                            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                            HGRenderFlags__Enum_Opaque,
		                                            HGShaderLightMode__Enum_GBuffer,
		                                            v36->fields.renderContext.m_Ptr,
		                                            &v106,
		                                            &v107,
		                                            &v108,
		                                            &v17->fields.mainViewConstants.viewMatrix,
		                                            &v17->fields.mainViewConstants.projMatrix,
		                                            &v17->fields.mainViewConstants.nonJitteredProjMatrix,
		                                            &v17->fields.zBufferParams,
		                                            &v17->fields.mainViewConstants.prevViewMatrix,
		                                            &v17->fields.mainViewConstants.prevViewProjMatrix,
		                                            &v17->fields.mainViewConstants.prevNonJitteredViewProjMatrix,
		                                            &v17->fields.mainViewConstants.worldSpaceCameraPos,
		                                            0LL);
		                                          v37 = NAN;
		                                          if ( v91 )
		                                            v37 = *(float *)&v106;
		                                          this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = v37;
		                                          v38 = NAN;
		                                          if ( v92 )
		                                            v38 = *(float *)&v107;
		                                          v39 = v121;
		                                          this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m30 = v38;
		                                          v40 = NAN;
		                                          if ( v121 )
		                                            v40 = *(float *)&v108;
		                                          this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11 = v40;
		                                        }
		                                        else
		                                        {
		LABEL_64:
		                                          v39 = v121;
		                                        }
		                                        v41 = v17->fields.cullingViewHandle;
		                                        if ( v18 )
		                                        {
		                                          v42 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		                                          if ( v42 )
		                                          {
		                                            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                            m_Ptr = v42->fields.renderContext.m_Ptr;
		                                            cullingLayerMask = LOBYTE(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21);
		                                            v109 = 0;
		                                            v110 = 0;
		                                            v111 = 0;
		                                            UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
		                                              v41,
		                                              0x500u,
		                                              0x100u,
		                                              1u,
		                                              m_Ptr,
		                                              &v109,
		                                              &v110,
		                                              &v111,
		                                              cullingLayerMask,
		                                              0LL);
		                                            v44 = NAN;
		                                            if ( v91 )
		                                              v44 = *(float *)&v109;
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21 = v44;
		                                            v45 = NAN;
		                                            if ( v92 )
		                                              v45 = *(float *)&v110;
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00 = v45;
		                                            v46 = NAN;
		                                            if ( v39 )
		                                              v46 = *(float *)&v111;
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m31 = v46;
		                                            if ( v95 )
		                                            {
		                                              v47 = v17->fields.cullingViewHandle;
		                                              v48 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v48 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              v49 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                                                        v47,
		                                                        HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                                        HGRenderFlags__Enum_Opaque,
		                                                        HGShaderLightMode__Enum_DepthOnly,
		                                                        v48->fields.renderContext.m_Ptr,
		                                                        0,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v49 = NAN;
		                                            }
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m30 = v49;
		                                            if ( v96 )
		                                            {
		                                              v50 = v17->fields.cullingViewHandle;
		                                              v51 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v51 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              v52 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                                                        v50,
		                                                        HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                                        HGRenderFlags__Enum_Opaque,
		                                                        HGShaderLightMode__Enum_GBuffer,
		                                                        v51->fields.renderContext.m_Ptr,
		                                                        0,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v52 = NAN;
		                                            }
		                                            v53 = -1;
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02 = v52;
		                                            v54 = -1;
		                                            v112 = -1;
		                                            v113 = -1;
		                                            if ( v94 || v97 )
		                                            {
		                                              v55 = v17->fields.cullingViewHandle;
		                                              v56 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v56 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              UnityEngine::HyperGryph::HGTreeRender::CreateRendererListWithPreZ(
		                                                v55,
		                                                HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                                HGRenderFlags__Enum_Opaque,
		                                                HGShaderLightMode__Enum_GBuffer,
		                                                v56->fields.renderContext.m_Ptr,
		                                                &v112,
		                                                &v113,
		                                                &v118,
		                                                0,
		                                                0LL);
		                                              v53 = v112;
		                                              v54 = v113;
		                                            }
		                                            v57 = NAN;
		                                            if ( v97 )
		                                              v57 = *(float *)&v53;
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m12 = v57;
		                                            v58 = NAN;
		                                            if ( v94 )
		                                              v58 = *(float *)&v54;
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01 = v58;
		                                            if ( v98 )
		                                            {
		                                              camera = v17->fields.camera;
		                                              sceneRTSize_k__BackingField = v17->fields._sceneRTSize_k__BackingField;
		                                              viewHandle[0] = v17->fields.cullingViewHandle;
		                                              renderPath_k__BackingField = this->fields._._._renderPath_k__BackingField;
		                                              v61 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v61 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              v62 = 8;
		                                              if ( renderPath_k__BackingField != 4 )
		                                                v62 = 4;
		                                              v63 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGSludgeRender::CreateRendererList(
		                                                        camera,
		                                                        sceneRTSize_k__BackingField,
		                                                        viewHandle[0],
		                                                        1u,
		                                                        v62,
		                                                        1200.0,
		                                                        v61->fields.renderContext.m_Ptr,
		                                                        1,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v63 = NAN;
		                                            }
		                                            this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22 = v63;
		                                            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		                                            v64 = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(0xFFFFFFFF, 0LL);
		                                            if ( v90 )
		                                            {
		                                              v123 = v17->fields.cullingViewHandle;
		                                              v65 = HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
		                                                      v17,
		                                                      0LL)
		                                                  ? HGRenderFlags__Enum_TransparentBeforeDistortion|HGRenderFlags__Enum_ShadowOnly
		                                                  : HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent;
		                                              v66 = HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
		                                                      v17,
		                                                      0LL)
		                                                  ? 0x600
		                                                  : 0;
		                                              *(_QWORD *)viewHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                                        v18,
		                                                                        0LL);
		                                              if ( !*(_QWORD *)viewHandle )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              LOWORD(globalKeywordsa) = 0;
		                                              v67 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                        v123,
		                                                        v65,
		                                                        (HGRenderFlags__Enum)(v66 + 512),
		                                                        (HGShaderLightMode__Enum)((CharOutlinePassEnableState << 9)
		                                                                                + 8416),
		                                                        globalKeywordsa,
		                                                        *(void **)(*(_QWORD *)viewHandle + 16LL),
		                                                        1,
		                                                        1,
		                                                        v64,
		                                                        0,
		                                                        0,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v67 = NAN;
		                                            }
		                                            this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = v67;
		                                            if ( v90 )
		                                            {
		                                              viewHandle[0] = v17->fields.cullingViewHandle;
		                                              v68 = (!HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
		                                                        v17,
		                                                        0LL)
		                                                   + 1) << 12;
		                                              enableTransparentAfterDOF = HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
		                                                                            v17,
		                                                                            0LL);
		                                              v69 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v69 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              LOWORD(globalKeywordsa) = 0;
		                                              v70 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                        viewHandle[0],
		                                                        (HGRenderFlags__Enum)(v68 | 0x400),
		                                                        (HGRenderFlags__Enum)((!enableTransparentAfterDOF + 1) << 12),
		                                                        (HGShaderLightMode__Enum)((CharOutlinePassEnableState << 9)
		                                                                                + 8416),
		                                                        globalKeywordsa,
		                                                        v69->fields.renderContext.m_Ptr,
		                                                        1,
		                                                        1,
		                                                        v64,
		                                                        0,
		                                                        0,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v70 = NAN;
		                                            }
		                                            this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m10 = v70;
		                                            if ( v90
		                                              && HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
		                                                   v17,
		                                                   0LL) )
		                                            {
		                                              v71 = v17->fields.cullingViewHandle;
		                                              v72 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v72 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              LOWORD(globalKeywordsa) = 0;
		                                              v73 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                        v71,
		                                                        HGRenderFlags__Enum_TransparentAfterPP|HGRenderFlags__Enum_ShadowOnly,
		                                                        HGRenderFlags__Enum_TransparentAfterPP,
		                                                        (HGShaderLightMode__Enum)((CharOutlinePassEnableState << 9)
		                                                                                + 8416),
		                                                        globalKeywordsa,
		                                                        v72->fields.renderContext.m_Ptr,
		                                                        1,
		                                                        1,
		                                                        v64,
		                                                        0,
		                                                        0,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v73 = NAN;
		                                            }
		                                            this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20 = v73;
		                                            if ( v90 )
		                                            {
		                                              v74 = v17->fields.cullingViewHandle;
		                                              v75 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( !v75 )
		                                                goto LABEL_123;
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              LOWORD(globalKeywordsa) = 0;
		                                              v76 = COERCE_FLOAT(
		                                                      UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                        v74,
		                                                        HGRenderFlags__Enum_Transparent,
		                                                        HGRenderFlags__Enum_Transparent,
		                                                        HGShaderLightMode__Enum_ForwardReflection,
		                                                        globalKeywordsa,
		                                                        v75->fields.renderContext.m_Ptr,
		                                                        1,
		                                                        1,
		                                                        v64,
		                                                        0,
		                                                        0,
		                                                        0LL));
		                                            }
		                                            else
		                                            {
		                                              v76 = NAN;
		                                            }
		                                            this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = v76;
		                                            v77 = v17->fields.cullingViewHandle;
		                                            v78 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                    v18,
		                                                    0LL);
		                                            if ( v78 )
		                                            {
		                                              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                              v79 = v78->fields.renderContext.m_Ptr;
		                                              v114 = 0;
		                                              v115 = 0;
		                                              v116 = 0;
		                                              UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
		                                                v77,
		                                                0x500u,
		                                                0x100u,
		                                                0x2020u,
		                                                v79,
		                                                &v114,
		                                                &v115,
		                                                &v116,
		                                                0,
		                                                0LL);
		                                              v80 = NAN;
		                                              if ( v99 )
		                                                v80 = *(float *)&v114;
		                                              this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m32 = v80;
		                                              v81 = NAN;
		                                              if ( v100 )
		                                                v81 = *(float *)&v115;
		                                              this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m10 = v81;
		                                              v82 = NAN;
		                                              if ( v101 )
		                                                v82 = *(float *)&v116;
		                                              this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03 = v82;
		                                              if ( !v102 )
		                                                goto LABEL_121;
		                                              v83 = v17->fields.cullingViewHandle;
		                                              v84 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                      v18,
		                                                      0LL);
		                                              if ( v84 )
		                                              {
		                                                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                                                LOWORD(globalKeywordsb) = 0;
		                                                v28 = COERCE_FLOAT(
		                                                        UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                          v83,
		                                                          HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                                          HGRenderFlags__Enum_Opaque,
		                                                          HGShaderLightMode__Enum_ForwardCharacterOnly,
		                                                          globalKeywordsb,
		                                                          v84->fields.renderContext.m_Ptr,
		                                                          0,
		                                                          0,
		                                                          0xFFFFFFFF,
		                                                          0,
		                                                          0,
		                                                          0LL));
		LABEL_121:
		                                                this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m33 = v28;
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
		LABEL_123:
		    sub_1800D8260(hgrp, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3574, 0LL);
		  if ( !Patch )
		    goto LABEL_123;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		}
		
		protected abstract GBufferProfileManager.GBufferProfileConfig GetGBufferProfileConfig();
		private GBufferOutput PrepareGBufferOutput(ref HGRenderPathParams renderPathParams) => default; // 0x0000000189BF7AA0-0x0000000189BF7BB8
		// GBufferOutput PrepareGBufferOutput(HGRenderPathBase+HGRenderPathParams ByRef)
		GBufferOutput *HG::Rendering::Runtime::HGRenderPathDeferred::PrepareGBufferOutput(
		        GBufferOutput *__return_ptr retstr,
		        HGRenderPathDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderPipeline *hgrp; // rcx
		  HGRenderGraph *renderGraph; // rax
		  HGRenderGraph *v10; // r14
		  HGCamera *hgCamera; // r15
		  HGSettingParameters *settingParameters_k__BackingField; // rbx
		  SettingParameter_1_System_Single_ *copySceneRTScale_k__BackingField; // rbx
		  GBufferProfileManager *v14; // rbp
		  GBufferProfileManager_GBufferProfileConfig__Enum v15; // esi
		  float v16; // xmm0_4
		  GBufferOutput *v17; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ m_attachments; // xmm0
		  NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
		  GBufferOutput *result; // rax
		  GBufferOutput v22; // [rsp+40h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3584, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3584, 0LL);
		    if ( Patch )
		    {
		      v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1274(&v22, Patch, (Object *)this, renderPathParams, 0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(hgrp, v7);
		  }
		  hgrp = renderPathParams->hgrp;
		  if ( !hgrp )
		    goto LABEL_8;
		  renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		  hgrp = renderPathParams->hgrp;
		  v10 = renderGraph;
		  hgCamera = renderPathParams->renderRequest.hgCamera;
		  if ( !hgrp )
		    goto LABEL_8;
		  settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		  if ( !settingParameters_k__BackingField )
		    goto LABEL_8;
		  copySceneRTScale_k__BackingField = settingParameters_k__BackingField->fields._copySceneRTScale_k__BackingField;
		  v14 = *(GBufferProfileManager **)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		  v15 = (unsigned int)sub_180002F70(18LL, this);
		  v16 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          copySceneRTScale_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v14 )
		    goto LABEL_8;
		  v17 = HG::Rendering::Runtime::GBufferProfileManager::SetupGBufferOutput(&v22, v14, v15, v10, hgCamera, v16, 0LL);
		LABEL_10:
		  m_attachments = v17->m_attachments;
		  m_gbufferMapping = v17->m_gbufferMapping;
		  result = retstr;
		  retstr->m_attachments = m_attachments;
		  retstr->m_gbufferMapping = m_gbufferMapping;
		  return result;
		}
		
		public void __iFixBaseProxy_OnPreRendering(ref HGRenderPathParams P0) {} // 0x0000000189BF7BC0-0x0000000189BF7BC8
		// Void <>iFixBaseProxy_OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathForward::__iFixBaseProxy_OnPreRendering(
		        HGRenderPathForward *this,
		        HGRenderPathBase_HGRenderPathParams *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering((HGRenderPathScene *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_Dispose(HGRenderGraph P0) {} // 0x0000000189BF7BB8-0x0000000189BF7BC0
		// Void <>iFixBaseProxy_Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::HGRenderPathDeferred::__iFixBaseProxy_Dispose(
		        HGRenderPathDeferred *this,
		        HGRenderGraph *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathScene::Dispose((HGRenderPathScene *)this, P0, 0LL);
		}
		
	}
}
