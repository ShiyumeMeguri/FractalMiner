using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathForward : HGRenderPathScene // TypeDefIndex: 38523
	{
		// Fields
		private BinningPass m_binningPassConstructor; // 0x1390
		private FoliageOccluderPassConstructor m_foliageOccluderPassConstructor; // 0x1398
		private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor; // 0x13A0
		private LightClusteringPassConstructor m_lightClusteringPassConstructor; // 0x13A8
		private ShadowMapPassConstructor m_shadowMapPassConstructor; // 0x13B0
		private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor; // 0x13B8
		private TerrainDeformPassConstructor m_terrainDeformPassConstructor; // 0x13C0
		private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor; // 0x13C8
		private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor; // 0x13D0
		private DepthPrepassConstructor m_depthPrepassConstructor; // 0x13D8
		private ForwardPassConstructor m_forwardPassConstructor; // 0x13E0
		protected uint m_forwardOpaquePreZECSList; // 0x13E8
		protected uint m_characterOpaqueOutlinePreZECSList; // 0x13EC
		protected uint m_forwardOpaqueECSList; // 0x13F0
		protected uint m_forwardOpaqueEqualECSList; // 0x13F4
		protected uint m_characterOpaqueECSList; // 0x13F8
		protected uint m_characterOpaqueOutlineECSList; // 0x13FC
		protected uint m_characterOpaqueOutlineEqualECSList; // 0x1400
		protected uint m_forwardTransparentECSList; // 0x1404
	
		// Constructors
		public HGRenderPathForward() {} // Dummy constructor
		internal HGRenderPathForward(HGRenderPathResources resources, HGCamera camera) {} // 0x0000000189BF92F4-0x0000000189BF9678
		// HGRenderPathForward(HGRenderPathBase+HGRenderPathResources, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathForward::HGRenderPathForward(
		        HGRenderPathForward *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  PassConstructorID__Enum__Array *v7; // rbx
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
		  IPassConstructor *v24; // rbx
		  HGRenderPathBase_HGRenderPathResources *v25; // rdx
		  PassConstructorID__Enum__Array *v26; // r8
		  Int32__Array **v27; // r9
		  IPassConstructor *v28; // rbx
		  HGRenderPathBase_HGRenderPathResources *v29; // rdx
		  PassConstructorID__Enum__Array *v30; // r8
		  Int32__Array **v31; // r9
		  IPassConstructor *v32; // rbx
		  HGRenderPathBase_HGRenderPathResources *v33; // rdx
		  PassConstructorID__Enum__Array *v34; // r8
		  Int32__Array **v35; // r9
		  IPassConstructor *v36; // rbx
		  HGRenderPathBase_HGRenderPathResources *v37; // rdx
		  PassConstructorID__Enum__Array *v38; // r8
		  Int32__Array **v39; // r9
		  IPassConstructor *v40; // rbx
		  HGRenderPathBase_HGRenderPathResources *v41; // rdx
		  PassConstructorID__Enum__Array *v42; // r8
		  Int32__Array **v43; // r9
		  IPassConstructor *v44; // rbx
		  HGRenderPathBase_HGRenderPathResources *v45; // rdx
		  PassConstructorID__Enum__Array *v46; // r8
		  Int32__Array **v47; // r9
		  IPassConstructor *v48; // rbx
		  HGRenderPathBase_HGRenderPathResources *v49; // rdx
		  PassConstructorID__Enum__Array *v50; // r8
		  Int32__Array **v51; // r9
		  MethodInfo *v52; // [rsp+20h] [rbp-28h]
		  MethodInfo *v53; // [rsp+20h] [rbp-28h]
		  MethodInfo *v54; // [rsp+20h] [rbp-28h]
		  MethodInfo *v55; // [rsp+20h] [rbp-28h]
		  MethodInfo *v56; // [rsp+20h] [rbp-28h]
		  MethodInfo *v57; // [rsp+20h] [rbp-28h]
		  MethodInfo *v58; // [rsp+20h] [rbp-28h]
		  MethodInfo *v59; // [rsp+20h] [rbp-28h]
		  MethodInfo *v60; // [rsp+20h] [rbp-28h]
		  MethodInfo *v61; // [rsp+20h] [rbp-28h]
		  MethodInfo *v62; // [rsp+28h] [rbp-20h]
		  MethodInfo *v63; // [rsp+28h] [rbp-20h]
		  MethodInfo *v64; // [rsp+28h] [rbp-20h]
		  MethodInfo *v65; // [rsp+28h] [rbp-20h]
		  MethodInfo *v66; // [rsp+28h] [rbp-20h]
		  MethodInfo *v67; // [rsp+28h] [rbp-20h]
		  MethodInfo *v68; // [rsp+28h] [rbp-20h]
		  MethodInfo *v69; // [rsp+28h] [rbp-20h]
		  MethodInfo *v70; // [rsp+28h] [rbp-20h]
		  MethodInfo *v71; // [rsp+28h] [rbp-20h]
		  HGRenderPathBase_HGRenderPathResources v72; // [rsp+30h] [rbp-18h] BYREF
		  MethodInfo *v73; // [rsp+70h] [rbp+28h]
		  MethodInfo *v74; // [rsp+78h] [rbp+30h]
		
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m10 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m30 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 = NAN;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m31 = NAN;
		  v7 = HG::Rendering::Runtime::HGRenderPathForward::PopulatePassConstructorIds(0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		  v72 = *resources;
		  HG::Rendering::Runtime::HGRenderPathScene::HGRenderPathScene(
		    (HGRenderPathScene *)this,
		    &v72,
		    v7,
		    camera,
		    HGRenderPathInternal__Enum_Forward,
		    0LL);
		  PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                      (HGRenderPathBase *)this,
		                      PassConstructorID__Enum_BinningPass,
		                      0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22 = sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
		  sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22,
		    v9,
		    v10,
		    v11,
		    v52,
		    v62);
		  v12 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_FoliageOccluder,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 = sub_180005050(v12, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		  sub_180005050(v12, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03,
		    v13,
		    v14,
		    v15,
		    v53,
		    v63);
		  v16 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_GpuClothSimulation,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = sub_180005050(v16, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		  sub_180005050(v16, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23,
		    v17,
		    v18,
		    v19,
		    v54,
		    v64);
		  v20 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_LightClustering,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00 = sub_180005050(
		                                                                                          v20,
		                                                                                          TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		  sub_180005050(v20, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix,
		    v21,
		    v22,
		    v23,
		    v55,
		    v65);
		  v24 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ShadowMap,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20 = sub_180005050(
		                                                                                          v24,
		                                                                                          TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		  sub_180005050(v24, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20,
		    v25,
		    v26,
		    v27,
		    v56,
		    v66);
		  v28 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Atmosphere,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01 = sub_180005050(
		                                                                                          v28,
		                                                                                          TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		  sub_180005050(v28, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01,
		    v29,
		    v30,
		    v31,
		    v57,
		    v67);
		  v32 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainDeform,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21 = sub_180005050(
		                                                                                          v32,
		                                                                                          TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		  sub_180005050(v32, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21,
		    v33,
		    v34,
		    v35,
		    v58,
		    v68);
		  v36 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainVTBake,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02 = sub_180005050(
		                                                                                          v36,
		                                                                                          TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		  sub_180005050(v36, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02,
		    v37,
		    v38,
		    v39,
		    v59,
		    v69);
		  v40 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainDepthPrepass,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22 = sub_180005050(
		                                                                                          v40,
		                                                                                          TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		  sub_180005050(v40, TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22,
		    v41,
		    v42,
		    v43,
		    v60,
		    v70);
		  v44 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_DepthPrepass,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03 = sub_180005050(
		                                                                                          v44,
		                                                                                          TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
		  sub_180005050(v44, TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03,
		    v45,
		    v46,
		    v47,
		    v61,
		    v71);
		  v48 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Forward,
		          0LL);
		  *(_QWORD *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = sub_180005050(
		                                                                                          v48,
		                                                                                          TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
		  sub_180005050(v48, TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
		  sub_18002D1B0(
		    (HGRenderPathDeferred *)&this[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23,
		    v49,
		    v50,
		    v51,
		    v73,
		    v74);
		}
		
	
		// Methods
		private static PassConstructorID[] PopulatePassConstructorIds() => default; // 0x0000000189BF7F2C-0x0000000189BF7F98
		// PassConstructorID[] PopulatePassConstructorIds()
		PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathForward::PopulatePassConstructorIds(
		        MethodInfo *method)
		{
		  Array *v1; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3607, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3607, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1269(Patch, 0LL);
		  }
		  else
		  {
		    v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 26LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v1,
		      3B86DEBEF62F07660D210D7EF39C087A54CA71A2C9F73A4A530348767A56AF78_Field,
		      0LL);
		    return (PassConstructorID__Enum__Array *)v1;
		  }
		}
		
		protected override void OnPreRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF7BDC-0x0000000189BF7F2C
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathForward::OnPreRendering(
		        HGRenderPathForward *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPipeline *hgrp; // rcx
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  __int64 v7; // r8
		  HGCamera **v8; // rdx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  CullingResults cullingResults; // xmm0
		  __int128 v15; // xmm1
		  HGRenderGraph *renderGraph; // rax
		  HGCamera *v17; // rbx
		  HGRenderGraph *v18; // rsi
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  bool CharOutlinePassEnableState; // r13
		  float v21; // ebp
		  uint32_t v22; // eax
		  uint32_t cullingViewHandle; // r12d
		  uint32_t cullingLayerMask; // r15d
		  HGRenderGraphContext *HGContext; // r14
		  uint32_t v26; // r14d
		  HGRenderGraphContext *v27; // rax
		  void *m_Ptr; // r9
		  uint32_t v29; // r14d
		  HGRenderGraphContext *v30; // rax
		  uint32_t v31; // ebx
		  HGRenderGraphContext *v32; // rax
		  void *v33; // rax
		  float v34; // eax
		  float v35; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-2F8h]
		  HGRenderKeyword__Enum globalKeywordsa; // [rsp+20h] [rbp-2F8h]
		  uint32_t preZPart0List; // [rsp+60h] [rbp-2B8h] BYREF
		  uint32_t preZPart1List[3]; // [rsp+64h] [rbp-2B4h] BYREF
		  HGCamera *v41; // [rsp+70h] [rbp-2A8h] BYREF
		  uint32_t normalList; // [rsp+338h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3608, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3608, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		      return;
		    }
		LABEL_19:
		    sub_1800D8260(hgrp, v8);
		  }
		  HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering((HGRenderPathScene *)this, renderPathParams, 0LL);
		  hgrp = renderPathParams->hgrp;
		  p_renderRequest = &renderPathParams->renderRequest;
		  v7 = 5LL;
		  v8 = &v41;
		  do
		  {
		    v9 = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		    *(_OWORD *)v8 = *(_OWORD *)&p_renderRequest->hgCamera;
		    v10 = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		    *((_OWORD *)v8 + 1) = v9;
		    v11 = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		    *((_OWORD *)v8 + 2) = v10;
		    v12 = *(_OWORD *)&p_renderRequest->target.face;
		    *((_OWORD *)v8 + 3) = v11;
		    v13 = *(_OWORD *)&p_renderRequest->target.targetDepth;
		    *((_OWORD *)v8 + 4) = v12;
		    cullingResults = p_renderRequest->cullingResults.cullingResults;
		    *((_OWORD *)v8 + 5) = v13;
		    v15 = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		    p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		    *((CullingResults *)v8 + 6) = cullingResults;
		    v8 += 16;
		    *((_OWORD *)v8 - 1) = v15;
		    --v7;
		  }
		  while ( v7 );
		  if ( !hgrp )
		    goto LABEL_19;
		  renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		  v17 = v41;
		  v18 = renderGraph;
		  if ( !v41 )
		    goto LABEL_19;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(v41, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_19;
		  hgrp = (HGRenderPipeline *)volumeComponentsData->fields.m_hgCharacterVolume;
		  if ( !hgrp )
		    goto LABEL_19;
		  CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                                 (HGCharacterVolume *)hgrp,
		                                 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v21 = NAN;
		  v22 = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(0xFFFFFFFF, 0LL);
		  cullingViewHandle = v17->fields.cullingViewHandle;
		  cullingLayerMask = v22;
		  if ( !v18 )
		    goto LABEL_19;
		  HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		  if ( !HGContext )
		    goto LABEL_19;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  LOWORD(globalKeywords) = 0;
		  LODWORD(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m31) = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                                                                  cullingViewHandle,
		                                                                                                  HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		                                                                                                  HGRenderFlags__Enum_Transparent,
		                                                                                                  HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_ForwardCharacterOnly|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
		                                                                                                  globalKeywords,
		                                                                                                  HGContext->fields.renderContext.m_Ptr,
		                                                                                                  1,
		                                                                                                  1,
		                                                                                                  cullingLayerMask,
		                                                                                                  0,
		                                                                                                  0,
		                                                                                                  0LL);
		  v26 = v17->fields.cullingViewHandle;
		  v27 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		  if ( !v27 )
		    goto LABEL_19;
		  m_Ptr = v27->fields.renderContext.m_Ptr;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = 0.0;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = 0.0;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m30 = 0.0;
		  UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
		    v26,
		    0x500u,
		    0x100u,
		    0x2260u,
		    m_Ptr,
		    (uint32_t *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20,
		    (uint32_t *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix,
		    (uint32_t *)&this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m30,
		    0,
		    0LL);
		  v29 = v17->fields.cullingViewHandle;
		  v30 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		  if ( !v30 )
		    goto LABEL_19;
		  LOWORD(globalKeywordsa) = 0;
		  LODWORD(this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01) = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                                                                                  v29,
		                                                                                                  HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                                                                                                  HGRenderFlags__Enum_Opaque,
		                                                                                                  HGShaderLightMode__Enum_ForwardCharacterOnly,
		                                                                                                  globalKeywordsa,
		                                                                                                  v30->fields.renderContext.m_Ptr,
		                                                                                                  0,
		                                                                                                  0,
		                                                                                                  0xFFFFFFFF,
		                                                                                                  0,
		                                                                                                  0,
		                                                                                                  0LL);
		  v31 = v17->fields.cullingViewHandle;
		  v32 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v18, 0LL);
		  if ( !v32 )
		    goto LABEL_19;
		  v33 = v32->fields.renderContext.m_Ptr;
		  normalList = 0;
		  preZPart0List = 0;
		  preZPart1List[0] = 0;
		  UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
		    v31,
		    0x500u,
		    0x100u,
		    0x200u,
		    v33,
		    &normalList,
		    &preZPart0List,
		    preZPart1List,
		    0,
		    0LL);
		  v34 = NAN;
		  if ( CharOutlinePassEnableState )
		    v34 = *(float *)&normalList;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11 = v34;
		  v35 = NAN;
		  if ( CharOutlinePassEnableState )
		  {
		    v35 = *(float *)&preZPart0List;
		    v21 = *(float *)preZPart1List;
		  }
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m10 = v35;
		  this[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 = v21;
		}
		
		protected override void RenderScene(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF7F98-0x0000000189BF92F4
		// Void RenderScene(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=9
		void HG::Rendering::Runtime::HGRenderPathForward::RenderScene(
		        HGRenderPathForward *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v3; // r13
		  HGRenderPathForward *v4; // rdi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r14
		  HGRenderGraph *renderGraph; // r15
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  char *v10; // rcx
		  __int64 v11; // rdx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rcx
		  BinningPass *v18; // rdx
		  __int64 v19; // rdx
		  BinningPass *v20; // rcx
		  unsigned __int64 v21; // rdx
		  unsigned __int64 v22; // r8
		  signed __int64 v23; // rtt
		  LightClusteringPassConstructor *v24; // rcx
		  __int64 v25; // rdx
		  BinningPass *v26; // rcx
		  __int64 v27; // rdx
		  FoliageOccluderPassConstructor *v28; // rcx
		  __int64 v29; // rdx
		  GpuClothSimulationPassConstructor *v30; // rcx
		  unsigned __int64 v31; // rdx
		  __int64 v32; // rcx
		  __int64 v33; // rax
		  int v34; // ecx
		  unsigned __int64 v35; // r8
		  signed __int64 v36; // rtt
		  unsigned __int64 v37; // r8
		  signed __int64 v38; // rtt
		  ShadowMapPassConstructor *v39; // rcx
		  unsigned __int64 v40; // rdx
		  __int64 v41; // rcx
		  HGSettingParameters *v42; // rax
		  HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
		  unsigned __int64 v44; // r8
		  signed __int64 v45; // rtt
		  SkyAtmospherePassConstructor *v46; // rcx
		  unsigned __int64 v47; // rdx
		  __int64 v48; // rcx
		  CullingResults v49; // xmm0
		  char v50; // r12
		  HGRenderPipeline *v51; // rax
		  unsigned __int64 v52; // r8
		  signed __int64 v53; // rtt
		  TerrainDeformPassConstructor *v54; // rcx
		  TextureHandle v55; // xmm6
		  CullingResults v56; // xmm7
		  __int64 v57; // rdx
		  TerrainDepthPrepassConstructor *v58; // rcx
		  unsigned __int64 v59; // rdx
		  unsigned __int64 v60; // r8
		  signed __int64 v61; // rtt
		  __int64 v62; // rdx
		  DepthPrepassConstructor *v63; // rcx
		  unsigned __int64 v64; // r8
		  signed __int64 v65; // rtt
		  __int64 v66; // rdx
		  HGCamera *v67; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v69; // rdx
		  __int64 v70; // rcx
		  GpuClothSimulationPassConstructor_PassInput v71; // [rsp+30h] [rbp-CB8h] BYREF
		  ForwardPassConstructor_PassOutput CharOutlinePassEnableState; // [rsp+31h] [rbp-CB7h] BYREF
		  FoliageOccluderPassConstructor_PassInput v73; // [rsp+32h] [rbp-CB6h] BYREF
		  TerrainDeformPassConstructor_PassOutput v74; // [rsp+33h] [rbp-CB5h] BYREF
		  FoliageOccluderPassConstructor_PassOutput v75; // [rsp+34h] [rbp-CB4h] BYREF
		  Il2CppException *ex; // [rsp+38h] [rbp-CB0h]
		  char *v77; // [rsp+40h] [rbp-CA8h]
		  GpuClothSimulationPassConstructor_PassOutput v78; // [rsp+48h] [rbp-CA0h] BYREF
		  HGRenderPipeline *v79; // [rsp+50h] [rbp-C98h]
		  HGRenderGraph *v80; // [rsp+58h] [rbp-C90h]
		  HGAtmosphereSettingParameters *v81; // [rsp+68h] [rbp-C80h] BYREF
		  CullingResults cullingResults; // [rsp+70h] [rbp-C78h]
		  SkyAtmospherePassConstructor_PassInput v83; // [rsp+80h] [rbp-C68h] BYREF
		  void *m_Ptr; // [rsp+88h] [rbp-C60h]
		  HGCamera *hgCamera; // [rsp+90h] [rbp-C58h]
		  TerrainDepthPrepassConstructor_PassOutput lightCullResult; // [rsp+98h] [rbp-C50h] BYREF
		  CullingResults v87; // [rsp+A8h] [rbp-C40h]
		  _BYTE v88[24]; // [rsp+B8h] [rbp-C30h] BYREF
		  ShadowMapPassConstructor_PassOutput v89; // [rsp+D0h] [rbp-C18h] BYREF
		  HGSettingParameters *settingParameters_k__BackingField; // [rsp+110h] [rbp-BD8h]
		  ShadowMapPassConstructor_PassInput v91; // [rsp+120h] [rbp-BC8h] BYREF
		  DepthPrepassConstructor_PassInput v92; // [rsp+170h] [rbp-B78h] BYREF
		  TerrainDeformPassConstructor_PassInput v93; // [rsp+1D0h] [rbp-B18h] BYREF
		  LightClusteringPassConstructor_PassInput v94; // [rsp+200h] [rbp-AE8h] BYREF
		  ForwardPassConstructor_PassInput v95; // [rsp+260h] [rbp-A88h] BYREF
		  Il2CppExceptionWrapper *v96; // [rsp+310h] [rbp-9D8h] BYREF
		  Il2CppExceptionWrapper *v97; // [rsp+318h] [rbp-9D0h] BYREF
		  Il2CppExceptionWrapper *v98; // [rsp+320h] [rbp-9C8h] BYREF
		  Il2CppExceptionWrapper *v99; // [rsp+328h] [rbp-9C0h] BYREF
		  Il2CppExceptionWrapper *v100; // [rsp+330h] [rbp-9B8h] BYREF
		  Il2CppExceptionWrapper *v101; // [rsp+338h] [rbp-9B0h] BYREF
		  Il2CppExceptionWrapper *v102; // [rsp+340h] [rbp-9A8h] BYREF
		  Il2CppExceptionWrapper *v103; // [rsp+348h] [rbp-9A0h] BYREF
		  Il2CppExceptionWrapper *v104; // [rsp+350h] [rbp-998h] BYREF
		  LightClusteringPassConstructor_PassInput input; // [rsp+360h] [rbp-988h] BYREF
		  ShadowMapPassConstructor_PassInput v106; // [rsp+3C0h] [rbp-928h] BYREF
		  TerrainDepthPrepassConstructor_PassInput v107; // [rsp+410h] [rbp-8D8h] BYREF
		  DepthPrepassConstructor_PassInput v108; // [rsp+460h] [rbp-888h] BYREF
		  _BYTE v109[32]; // [rsp+4C0h] [rbp-828h] BYREF
		  __int128 v110; // [rsp+4E0h] [rbp-808h]
		  __int128 v111; // [rsp+4F0h] [rbp-7F8h]
		  ResourceHandle v112; // [rsp+500h] [rbp-7E8h]
		  BinningPass_BinningData v113; // [rsp+510h] [rbp-7D8h] BYREF
		  ForwardPassConstructor_PassInput v114; // [rsp+530h] [rbp-7B8h] BYREF
		  char v115; // [rsp+5E0h] [rbp-708h] BYREF
		  char v116; // [rsp+768h] [rbp-580h]
		  LightClusteringPassConstructor_PassOutput output; // [rsp+860h] [rbp-488h] BYREF
		  int32_t v118; // [rsp+C70h] [rbp-78h]
		  int32_t v119; // [rsp+C74h] [rbp-74h]
		  char v122; // [rsp+D08h] [rbp+20h] BYREF
		
		  v3 = renderPathParams;
		  v4 = this;
		  v122 = 0;
		  sub_18033B9D0(&input, 0LL, 88LL);
		  v73 = 0;
		  v75 = 0;
		  sub_18033B9D0(&v106, 0LL, 80LL);
		  memset(&v89, 0, sizeof(v89));
		  sub_18033B9D0(&v91, 0LL, 80LL);
		  v83.atmosphereParams = 0LL;
		  v81 = 0LL;
		  memset(&v93, 0, sizeof(v93));
		  v74 = 0;
		  v87 = 0LL;
		  memset(v88, 0, sizeof(v88));
		  sub_18033B9D0(&v108, 0LL, 96LL);
		  sub_18033B9D0(&v92, 0LL, 96LL);
		  sub_18033B9D0(&v114, 0LL, 168LL);
		  sub_18033B9D0(&v95, 0LL, 168LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3609, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3609, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v70, v69);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, v3, 0LL);
		  }
		  else
		  {
		    hgrp = v3->hgrp;
		    v79 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v80 = renderGraph;
		    m_Ptr = v3->renderGraphParams.scriptableRenderContext.m_Ptr;
		    cullingResults = v3->renderRequest.cullingResults.cullingResults;
		    lightCullResult = (TerrainDepthPrepassConstructor_PassOutput)v3->renderRequest.cullingResults.lightCullResult;
		    hgCamera = v3->renderRequest.hgCamera;
		    settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		    p_renderRequest = &v3->renderRequest;
		    v10 = &v115;
		    v11 = 5LL;
		    do
		    {
		      *(_OWORD *)v10 = *(_OWORD *)&p_renderRequest->hgCamera;
		      *((_OWORD *)v10 + 1) = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		      *((_OWORD *)v10 + 2) = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		      *((_OWORD *)v10 + 3) = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		      *((_OWORD *)v10 + 4) = *(_OWORD *)&p_renderRequest->target.face;
		      *((_OWORD *)v10 + 5) = *(_OWORD *)&p_renderRequest->target.targetDepth;
		      *((_OWORD *)v10 + 6) = p_renderRequest->cullingResults.cullingResults;
		      v10 += 128;
		      *((_OWORD *)v10 - 1) = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		      p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		      --v11;
		    }
		    while ( v11 );
		    if ( !*(_QWORD *)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22 )
		      sub_1800D8260(v10, 0LL);
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(
		                             *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		                             0LL);
		    if ( !volumeComponentsData )
		      sub_1800D8260(v14, v13);
		    if ( !volumeComponentsData->fields.m_hgCharacterVolume )
		      sub_1800D8260(v14, v13);
		    CharOutlinePassEnableState = (ForwardPassConstructor_PassOutput)HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                                                                      volumeComponentsData->fields.m_hgCharacterVolume,
		                                                                      0LL);
		    if ( !*(_QWORD *)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22 )
		      sub_1800D8260(v16, v15);
		    HG::Rendering::Runtime::BinningPass::Prepare(
		      *(BinningPass **)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22,
		      renderGraph,
		      0LL);
		    sub_18033B9D0(&output, 0LL, 1072LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)7u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      sub_18033B9D0(&v94, 0LL, 88LL);
		      v94.cullingResults = cullingResults;
		      v94.lightCullResult = (LightCullResult)lightCullResult;
		      v18 = *(BinningPass **)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		      if ( !v18 )
		        sub_1800D8250(v17, 0LL);
		      v94.binningData = *HG::Rendering::Runtime::BinningPass::get_lightBinningData(&v113, v18, 0LL);
		      v20 = *(BinningPass **)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		      if ( !v20 )
		        sub_1800D8250(0LL, v19);
		      v94.binningBuffer = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v20, 0LL);
		      v94.settingParams = hgrp->fields._settingParameters_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v22 = (((unsigned __int64)&v94.settingParams >> 12) & 0x1FFFFF) >> 6;
		        v21 = ((unsigned __int64)&v94.settingParams >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v22 + 36190]);
		        do
		          v23 = qword_18F0BCBA0[v22 + 36190];
		        while ( v23 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v22 + 36190], v23 | (1LL << v21), v23) );
		      }
		      input = v94;
		      v24 = *(LightClusteringPassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		      if ( !v24 )
		        sub_1800D8250(0LL, v21);
		      HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
		        v24,
		        &input,
		        &output,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v104 )
		    {
		      ex = v104->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)1u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      v26 = *(BinningPass **)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		      if ( !v26 )
		        sub_1800D8250(0LL, v25);
		      HG::Rendering::Runtime::BinningPass::ConstructPass(
		        v26,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v96 )
		    {
		      ex = v96->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)3u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      v73 = 0;
		      v75 = 0;
		      v28 = *(FoliageOccluderPassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		      if ( !v28 )
		        sub_1800D8250(0LL, v27);
		      HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
		        v28,
		        &v73,
		        &v75,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v97 )
		    {
		      ex = v97->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)6u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      v71 = 0;
		      v78 = 0;
		      v30 = *(GpuClothSimulationPassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		      if ( !v30 )
		        sub_1800D8250(0LL, v29);
		      HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
		        v30,
		        &v71,
		        &v78,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v98 )
		    {
		      ex = v98->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xCu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      sub_18033B9D0(&v91, 0LL, 80LL);
		      v91.cullingResults = cullingResults;
		      v91.lightCullResult = (LightCullResult)lightCullResult;
		      v91.srpContext.m_Ptr = m_Ptr;
		      v33 = *(_QWORD *)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22;
		      if ( !v33 )
		        sub_1800D8250(v32, v31);
		      v91.shadowManager = *(HGShadowManager **)(v33 + 1848);
		      v34 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v35 = (((unsigned __int64)&v91 >> 12) & 0x1FFFFF) >> 6;
		        v31 = ((unsigned __int64)&v91 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v35 + 36190]);
		        do
		          v36 = qword_18F0BCBA0[v35 + 36190];
		        while ( v36 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v35 + 36190], v36 | (1LL << v31), v36) );
		        v34 = dword_18F35FD08;
		      }
		      v91.directionalLightIndex = v119;
		      v91.settingParams = settingParameters_k__BackingField;
		      if ( v34 )
		      {
		        v37 = (((unsigned __int64)&v91.settingParams >> 12) & 0x1FFFFF) >> 6;
		        v31 = ((unsigned __int64)&v91.settingParams >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v37 + 36190]);
		        do
		          v38 = qword_18F0BCBA0[v37 + 36190];
		        while ( v38 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v37 + 36190], v38 | (1LL << v31), v38) );
		      }
		      v91.settingParamsCpp = v3->perFrameSetup.settingParametersCpp;
		      v91.punctualLightCount = v118;
		      v91.punctualLightIndices = &output.punctualLightIndices.FixedElementField;
		      v106 = v91;
		      memset(&v89, 0, sizeof(v89));
		      v39 = *(ShadowMapPassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20;
		      if ( !v39 )
		        sub_1800D8250(0LL, v31);
		      HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
		        v39,
		        &v106,
		        &v89,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		      *(ShadowMapPassConstructor_PassOutput *)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m01 = v89;
		    }
		    catch ( Il2CppExceptionWrapper *v99 )
		    {
		      ex = v99->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xDu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      v81 = 0LL;
		      v42 = hgrp->fields._settingParameters_k__BackingField;
		      if ( !v42 )
		        sub_1800D8250(v41, v40);
		      atmosphereParams_k__BackingField = v42->fields._atmosphereParams_k__BackingField;
		      v81 = atmosphereParams_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v44 = (((unsigned __int64)&v81 >> 12) & 0x1FFFFF) >> 6;
		        v40 = ((unsigned __int64)&v81 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v44 + 36190]);
		        do
		          v45 = qword_18F0BCBA0[v44 + 36190];
		        while ( v45 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v44 + 36190], v45 | (1LL << v40), v45) );
		        atmosphereParams_k__BackingField = v81;
		      }
		      v83.atmosphereParams = atmosphereParams_k__BackingField;
		      v71 = 0;
		      v46 = *(SkyAtmospherePassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		      if ( !v46 )
		        sub_1800D8250(0LL, v40);
		      HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
		        v46,
		        &v83,
		        (SkyAtmospherePassConstructor_PassOutput *)&v71,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v100 )
		    {
		      ex = v100->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x11u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      *(_QWORD *)&v88[9] = 0LL;
		      *(_DWORD *)&v88[17] = 0;
		      *(_WORD *)&v88[21] = 0;
		      v88[23] = 0;
		      v49 = cullingResults;
		      v87 = cullingResults;
		      *(_QWORD *)v88 = m_Ptr;
		      v50 = v116;
		      v88[8] = v116;
		      v51 = v3->hgrp;
		      if ( !v51 )
		        sub_1800D8250(v48, v47);
		      *(_QWORD *)&v88[16] = v51->fields.drawInteractionNodeMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v52 = (((unsigned __int64)&v88[16] >> 12) & 0x1FFFFF) >> 6;
		        v47 = ((unsigned __int64)&v88[16] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v52 + 36190]);
		        do
		          v53 = qword_18F0BCBA0[v52 + 36190];
		        while ( v53 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v52 + 36190], v53 | (1LL << v47), v53) );
		        v49 = v87;
		      }
		      v93.cullingResults = v49;
		      *(_OWORD *)&v93.renderContext.m_Ptr = *(_OWORD *)v88;
		      v93.drawInteractionNodeMaterial = *(Material **)&v88[16];
		      v74 = 0;
		      v54 = *(TerrainDeformPassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		      if ( !v54 )
		        sub_1800D8250(0LL, v47);
		      HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
		        v54,
		        &v93,
		        &v74,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v101 )
		    {
		      ex = v101->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		      v50 = v116;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x14u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      sub_18033B9D0(v109, 0LL, 72LL);
		      v55 = *(TextureHandle *)&v4[1].fields._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20;
		      v56 = cullingResults;
		      LODWORD(v110) = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(hgrp, 0LL);
		      BYTE4(v110) = v50;
		      v107.sceneDepth = v55;
		      v107.cullingResults = v56;
		      *(_OWORD *)&v107.bakedLightingConfig = v110;
		      *(_OWORD *)&v107.terrainGpuSubd = v111;
		      v107.HZBTexture.fallBackResource = v112;
		      lightCullResult = 0LL;
		      v58 = *(TerrainDepthPrepassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22;
		      if ( !v58 )
		        sub_1800D8250(0LL, v57);
		      HG::Rendering::Runtime::TerrainDepthPrepassConstructor::ConstructPass(
		        v58,
		        &v107,
		        &lightCullResult,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v102 )
		    {
		      ex = v102->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x15u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v77 = &v122;
		    try
		    {
		      sub_18033B9D0(&v92, 0LL, 96LL);
		      v92.sceneDepth = *(TextureHandle *)&v4[1].fields._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v92.gBufferDepth = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                            &lightCullResult.terrainDepthBuffer,
		                            0LL);
		      v92.hgrp = hgrp;
		      if ( dword_18F35FD08 )
		      {
		        v60 = (((unsigned __int64)&v92.hgrp >> 12) & 0x1FFFFF) >> 6;
		        v59 = ((unsigned __int64)&v92.hgrp >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v60 + 36190]);
		        do
		          v61 = qword_18F0BCBA0[v60 + 36190];
		        while ( v61 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v60 + 36190], v61 | (1LL << v59), v61) );
		      }
		      v92.cullingResults = cullingResults;
		      v92.characterDepthOnlyEnable = hgrp->fields.characterDepthOnlyEnable;
		      if ( !hgCamera )
		        sub_1800D8250(0LL, v59);
		      v92.screenCullingRatio = hgCamera->fields.screenCullingRatio;
		      v92.screenCullingRatioDistance = hgCamera->fields.screenRatioCullingDistance;
		      v92.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		      v92.forwardOpaquePreZECSList = LODWORD(v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00);
		      v92.deferredOpaquePreZECSList = -1;
		      *(_QWORD *)&v92.deferredGrassPreZECSList = -1LL;
		      v108 = v92;
		      v71 = 0;
		      v63 = *(DepthPrepassConstructor **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03;
		      if ( !v63 )
		        sub_1800D8250(0LL, v62);
		      HG::Rendering::Runtime::DepthPrepassConstructor::ConstructPass(
		        v63,
		        &v108,
		        (DepthPrepassConstructor_PassOutput *)&v71,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v103 )
		    {
		      ex = v103->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = this;
		      hgrp = v79;
		      renderGraph = v80;
		    }
		    sub_18033B9D0(&v95, 0LL, 168LL);
		    v95.sceneColor = *(TextureHandle *)&v4[1].fields._._.m_basicTransformConstants._PrevViewProjMatrix.m23;
		    v95.sceneDepth = *(TextureHandle *)&v4[1].fields._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20;
		    v95.hgrp = hgrp;
		    if ( dword_18F35FD08 )
		    {
		      v64 = (((unsigned __int64)&v95.hgrp >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v64 + 36190]);
		      do
		        v65 = qword_18F0BCBA0[v64 + 36190];
		      while ( v65 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v64 + 36190],
		                       v65 | (1LL << (((unsigned __int64)&v95.hgrp >> 12) & 0x3F)),
		                       v65) );
		    }
		    *(_QWORD *)&v95.forwardOpaqueECSRendererList = *(_QWORD *)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20;
		    *(_OWORD *)&v95.characterOpaqueECSRendererList = *(_OWORD *)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		    v95.shadowResult = *(ShadowResult *)&v4[1].fields._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m01;
		    v95.cullingResults = cullingResults;
		    v95.bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(hgrp, 0LL);
		    v67 = hgCamera;
		    if ( !hgCamera
		      || (*(_QWORD *)&v95.screenCullingRatio = *(_QWORD *)&hgCamera->fields.screenCullingRatio,
		          v95.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL),
		          v95.characterOutlineEnabled = (bool)CharOutlinePassEnableState,
		          v114 = v95,
		          CharOutlinePassEnableState = 0,
		          (v67 = *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23) == 0LL) )
		    {
		      sub_1800D8250(v67, v66);
		    }
		    HG::Rendering::Runtime::ForwardPassConstructor::ConstructPass(
		      (ForwardPassConstructor *)v67,
		      &v114,
		      &CharOutlinePassEnableState,
		      renderGraph,
		      *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22,
		      0LL);
		  }
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
		
	}
}
