using System;

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathForward : HGRenderPathScene
	{
		internal HGRenderPathForward(HGRenderPathBase.HGRenderPathResources resources, HGCamera camera)
		{
			// // HGRenderPathForward(HGRenderPathBase+HGRenderPathResources, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathForward::HGRenderPathForward(
			//         HGRenderPathForward *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   PassConstructorID__Enum__Array *v7; // rbx
			//   IPassConstructor *PassConstructor; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   IPassConstructor *v12; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   IPassConstructor *v16; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   IPassConstructor *v20; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   IPassConstructor *v24; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   IPassConstructor *v28; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   IPassConstructor *v32; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   IPassConstructor *v36; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   IPassConstructor *v40; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v41; // rdx
			//   PassConstructorID__Enum__Array *v42; // r8
			//   HGCamera *v43; // r9
			//   IPassConstructor *v44; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v45; // rdx
			//   PassConstructorID__Enum__Array *v46; // r8
			//   HGCamera *v47; // r9
			//   IPassConstructor *v48; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v49; // rdx
			//   PassConstructorID__Enum__Array *v50; // r8
			//   HGCamera *v51; // r9
			//   MethodInfo *v52; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v53; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v54; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v55; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v56; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v57; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v58; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v59; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v60; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v61; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v62; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v63; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v64; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v65; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v66; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v67; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v68; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v69; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v70; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v71; // [rsp+28h] [rbp-20h]
			//   HGRenderPathBase_HGRenderPathResources v72; // [rsp+30h] [rbp-18h] BYREF
			//   MethodInfo *v73; // [rsp+70h] [rbp+28h]
			//   MethodInfo *v74; // [rsp+78h] [rbp+30h]
			// 
			//   if ( !byte_18D919651 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BinningPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//     byte_18D919651 = 1;
			//   }
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m10 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m30 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 = NAN;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m31 = NAN;
			//   v7 = HG::Rendering::Runtime::HGRenderPathForward::PopulatePassConstructorIds(0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//   v72 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathScene::HGRenderPathScene(
			//     (HGRenderPathScene *)this,
			//     &v72,
			//     v7,
			//     camera,
			//     HGRenderPathInternal__Enum_Forward,
			//     0LL);
			//   PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                       (HGRenderPathBase *)this,
			//                       PassConstructorID__Enum_BinningPass,
			//                       0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22 = sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
			//   sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22,
			//     v9,
			//     v10,
			//     v11,
			//     v52,
			//     v62);
			//   v12 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_FoliageOccluder,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = sub_18003F5A0(v12, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//   sub_18003F5A0(v12, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03,
			//     v13,
			//     v14,
			//     v15,
			//     v53,
			//     v63);
			//   v16 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_GpuClothSimulation,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23 = sub_18003F5A0(v16, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//   sub_18003F5A0(v16, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23,
			//     v17,
			//     v18,
			//     v19,
			//     v54,
			//     v64);
			//   v20 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_LightClustering,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                         v20,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//   sub_18003F5A0(v20, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix,
			//     v21,
			//     v22,
			//     v23,
			//     v55,
			//     v65);
			//   v24 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ShadowMap,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                         v24,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//   sub_18003F5A0(v24, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20,
			//     v25,
			//     v26,
			//     v27,
			//     v56,
			//     v66);
			//   v28 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Atmosphere,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                         v28,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//   sub_18003F5A0(v28, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//     v29,
			//     v30,
			//     v31,
			//     v57,
			//     v67);
			//   v32 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainDeform,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                         v32,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//   sub_18003F5A0(v32, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//     v33,
			//     v34,
			//     v35,
			//     v58,
			//     v68);
			//   v36 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainVTBake,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                         v36,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//   sub_18003F5A0(v36, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02,
			//     v37,
			//     v38,
			//     v39,
			//     v59,
			//     v69);
			//   v40 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainDepthPrepass,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                         v40,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//   sub_18003F5A0(v40, TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22,
			//     v41,
			//     v42,
			//     v43,
			//     v60,
			//     v70);
			//   v44 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_DepthPrepass,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03 = sub_18003F5A0(
			//                                                                                         v44,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//   sub_18003F5A0(v44, TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03,
			//     v45,
			//     v46,
			//     v47,
			//     v61,
			//     v71);
			//   v48 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Forward,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                         v48,
			//                                                                                         TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//   sub_18003F5A0(v48, TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathDeferred *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23,
			//     v49,
			//     v50,
			//     v51,
			//     v73,
			//     v74);
			// }
			// 
		}

		private static PassConstructorID[] PopulatePassConstructorIds()
		{
			// // PassConstructorID[] PopulatePassConstructorIds()
			// PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathForward::PopulatePassConstructorIds(
			//         MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   Array *v3; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D919650 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
			//     sub_18003C530(&3B86DEBEF62F07660D210D7EF39C087A54CA71A2C9F73A4A530348767A56AF78_Field);
			//     byte_18D919650 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3006, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3006, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1065(Patch, 0LL);
			//   }
			//   else
			//   {
			//     v3 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 26LL, v1, v2);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v3,
			//       3B86DEBEF62F07660D210D7EF39C087A54CA71A2C9F73A4A530348767A56AF78_Field,
			//       0LL);
			//     return (PassConstructorID__Enum__Array *)v3;
			//   }
			// }
			// 
			return null;
		}

		protected override void OnPreRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathForward::OnPreRendering(
			//         HGRenderPathForward *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 *v6; // rcx
			//   HGRenderPipeline *hgrp; // rsi
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   HGRenderGraph *m_RenderGraph; // rsi
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   CullingResults cullingResults; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int64 v19; // rax
			//   __int64 v20; // rbx
			//   __int64 v21; // rax
			//   bool CharOutlinePassEnableState; // r13
			//   float v23; // r14d
			//   uint32_t v24; // eax
			//   uint32_t v25; // r12d
			//   uint32_t cullingLayerMask; // r15d
			//   HGRenderGraphContext *m_RenderGraphContext; // rbp
			//   HGRenderGraphContext *v28; // r9
			//   void *m_Ptr; // r9
			//   HGRenderGraphContext *v30; // rax
			//   HGRenderGraphContext *v31; // rax
			//   void *v32; // rax
			//   float v33; // eax
			//   float v34; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-328h]
			//   HGRenderKeyword__Enum globalKeywordsa; // [rsp+20h] [rbp-328h]
			//   uint32_t preZPart0List; // [rsp+60h] [rbp-2E8h] BYREF
			//   uint32_t preZPart1List[3]; // [rsp+64h] [rbp-2E4h] BYREF
			//   __int64 v40; // [rsp+70h] [rbp-2D8h] BYREF
			//   uint32_t normalList; // [rsp+368h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919652 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919652 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3007, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3007, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			//       return;
			//     }
			// LABEL_21:
			//     sub_180B536AC(v6, v5);
			//   }
			//   HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering((HGRenderPathScene *)this, renderPathParams, 0LL);
			//   hgrp = renderPathParams.hgrp;
			//   p_renderRequest = &renderPathParams.renderRequest;
			//   if ( !hgrp )
			//     goto LABEL_21;
			//   m_RenderGraph = hgrp.fields.m_RenderGraph;
			//   v6 = &v40;
			//   v5 = 5LL;
			//   do
			//   {
			//     v10 = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//     *(_OWORD *)v6 = *(_OWORD *)&p_renderRequest.hgCamera;
			//     v11 = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//     *((_OWORD *)v6 + 1) = v10;
			//     v12 = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//     *((_OWORD *)v6 + 2) = v11;
			//     v13 = *(_OWORD *)&p_renderRequest.target.face;
			//     *((_OWORD *)v6 + 3) = v12;
			//     v14 = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//     *((_OWORD *)v6 + 4) = v13;
			//     cullingResults = p_renderRequest.cullingResults.cullingResults;
			//     *((_OWORD *)v6 + 5) = v14;
			//     v16 = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//     p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//     *((CullingResults *)v6 + 6) = cullingResults;
			//     v6 += 16;
			//     *((_OWORD *)v6 - 1) = v16;
			//     --v5;
			//   }
			//   while ( v5 );
			//   v17 = *(_OWORD *)&p_renderRequest.hgCamera;
			//   v18 = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//   v19 = *(_QWORD *)&p_renderRequest.target.id.m_InstanceID;
			//   *(_OWORD *)v6 = v17;
			//   *((_OWORD *)v6 + 1) = v18;
			//   v6[4] = v19;
			//   v20 = v40;
			//   if ( !v40 )
			//     goto LABEL_21;
			//   v21 = *(_QWORD *)(v40 + 2504);
			//   if ( !v21 )
			//     goto LABEL_21;
			//   v6 = *(__int64 **)(v21 + 104);
			//   if ( !v6 )
			//     goto LABEL_21;
			//   CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
			//                                  (HGCharacterVolume *)v6,
			//                                  0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//   v23 = NAN;
			//   v24 = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(0xFFFFFFFF, 0LL);
			//   v25 = *(_DWORD *)(v20 + 2592);
			//   cullingLayerMask = v24;
			//   if ( !m_RenderGraph )
			//     goto LABEL_21;
			//   m_RenderGraphContext = m_RenderGraph.fields.m_RenderGraphContext;
			//   if ( !m_RenderGraphContext )
			//     goto LABEL_21;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   LOWORD(globalKeywords) = 0;
			//   LODWORD(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m31) = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                                                                 v25,
			//                                                                                                 HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//                                                                                                 HGRenderFlags__Enum_Transparent,
			//                                                                                                 HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_ForwardCharacterOnly|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
			//                                                                                                 globalKeywords,
			//                                                                                                 m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                                                                                                 1,
			//                                                                                                 1,
			//                                                                                                 cullingLayerMask,
			//                                                                                                 0,
			//                                                                                                 0,
			//                                                                                                 0LL);
			//   v28 = m_RenderGraph.fields.m_RenderGraphContext;
			//   v6 = (__int64 *)*(unsigned int *)(v20 + 2592);
			//   if ( !v28 )
			//     goto LABEL_21;
			//   m_Ptr = v28.fields.renderContext.m_Ptr;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = 0.0;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = 0.0;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m30 = 0.0;
			//   UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
			//     (uint32_t)v6,
			//     0x500u,
			//     0x100u,
			//     0x2260u,
			//     m_Ptr,
			//     (uint32_t *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20,
			//     (uint32_t *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix,
			//     (uint32_t *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m30,
			//     0,
			//     0LL);
			//   v30 = m_RenderGraph.fields.m_RenderGraphContext;
			//   if ( !v30 )
			//     goto LABEL_21;
			//   LOWORD(globalKeywordsa) = 0;
			//   LODWORD(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01) = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                                                                 *(_DWORD *)(v20 + 2592),
			//                                                                                                 HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                                                                                                 HGRenderFlags__Enum_Opaque,
			//                                                                                                 HGShaderLightMode__Enum_ForwardCharacterOnly,
			//                                                                                                 globalKeywordsa,
			//                                                                                                 v30.fields.renderContext.m_Ptr,
			//                                                                                                 0,
			//                                                                                                 0,
			//                                                                                                 0xFFFFFFFF,
			//                                                                                                 0,
			//                                                                                                 0,
			//                                                                                                 0LL);
			//   v31 = m_RenderGraph.fields.m_RenderGraphContext;
			//   v6 = (__int64 *)*(unsigned int *)(v20 + 2592);
			//   if ( !v31 )
			//     goto LABEL_21;
			//   v32 = v31.fields.renderContext.m_Ptr;
			//   normalList = 0;
			//   preZPart0List = 0;
			//   preZPart1List[0] = 0;
			//   UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
			//     (uint32_t)v6,
			//     0x500u,
			//     0x100u,
			//     0x200u,
			//     v32,
			//     &normalList,
			//     &preZPart0List,
			//     preZPart1List,
			//     0,
			//     0LL);
			//   v33 = NAN;
			//   if ( CharOutlinePassEnableState )
			//     v33 = *(float *)&normalList;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11 = v33;
			//   v34 = NAN;
			//   if ( CharOutlinePassEnableState )
			//   {
			//     v34 = *(float *)&preZPart0List;
			//     v23 = *(float *)preZPart1List;
			//   }
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m10 = v34;
			//   this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 = v23;
			// }
			// 
		}

		protected override void RenderScene(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderScene(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=9
			// void HG::Rendering::Runtime::HGRenderPathForward::RenderScene(
			//         HGRenderPathForward *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v3; // r13
			//   HGRenderPathForward *v4; // rdi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // r15
			//   HGRenderGraph *m_RenderGraph; // r14
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   char *v10; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // rsi
			//   __int64 v13; // rsi
			//   HGCharacterVolume *v14; // rsi
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   unsigned __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   CullingResults v19; // xmm2
			//   LightCullResult v20; // xmm3
			//   __int64 v21; // rax
			//   __int128 v22; // xmm1
			//   __int64 v23; // rax
			//   unsigned __int64 v24; // r8
			//   signed __int64 v25; // rtt
			//   LightClusteringPassConstructor *v26; // rcx
			//   __int64 v27; // rdx
			//   BinningPass *v28; // rcx
			//   __int64 v29; // rdx
			//   FoliageOccluderPassConstructor *v30; // rcx
			//   __int64 v31; // rdx
			//   GpuClothSimulationPassConstructor *v32; // rcx
			//   unsigned __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rax
			//   int v36; // ecx
			//   unsigned __int64 v37; // r8
			//   signed __int64 v38; // rtt
			//   unsigned __int64 v39; // r8
			//   signed __int64 v40; // rtt
			//   ShadowMapPassConstructor *v41; // rcx
			//   unsigned __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   HGSettingParameters *v44; // rax
			//   HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
			//   unsigned __int64 v46; // r8
			//   signed __int64 v47; // rtt
			//   SkyAtmospherePassConstructor *v48; // rcx
			//   unsigned __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   CullingResults v51; // xmm0
			//   char v52; // r12
			//   HGRenderPipeline *v53; // rax
			//   unsigned __int64 v54; // r8
			//   signed __int64 v55; // rtt
			//   TerrainDeformPassConstructor *v56; // rcx
			//   __int64 v57; // rdx
			//   TextureHandle v58; // xmm0
			//   TerrainDepthPrepassConstructor *v59; // rcx
			//   unsigned __int64 v60; // rdx
			//   unsigned __int64 v61; // r8
			//   signed __int64 v62; // rtt
			//   __int64 v63; // rdx
			//   DepthPrepassConstructor *v64; // rcx
			//   unsigned __int64 v65; // rdx
			//   unsigned __int64 v66; // r8
			//   signed __int64 v67; // rtt
			//   HGCamera *v68; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   GpuClothSimulationPassConstructor_PassInput v72; // [rsp+30h] [rbp-C68h] BYREF
			//   ForwardPassConstructor_PassOutput CharOutlinePassEnableState; // [rsp+31h] [rbp-C67h] BYREF
			//   FoliageOccluderPassConstructor_PassOutput v74; // [rsp+32h] [rbp-C66h] BYREF
			//   FoliageOccluderPassConstructor_PassInput v75; // [rsp+33h] [rbp-C65h] BYREF
			//   TerrainDeformPassConstructor_PassOutput v76; // [rsp+34h] [rbp-C64h] BYREF
			//   Il2CppException *ex; // [rsp+38h] [rbp-C60h]
			//   char *v78; // [rsp+40h] [rbp-C58h]
			//   GpuClothSimulationPassConstructor_PassOutput v79; // [rsp+48h] [rbp-C50h] BYREF
			//   HGRenderPipeline *v80; // [rsp+50h] [rbp-C48h]
			//   HGRenderGraph *v81; // [rsp+58h] [rbp-C40h]
			//   HGAtmosphereSettingParameters *v82; // [rsp+68h] [rbp-C30h] BYREF
			//   CullingResults cullingResults; // [rsp+70h] [rbp-C28h]
			//   SkyAtmospherePassConstructor_PassInput v84; // [rsp+80h] [rbp-C18h] BYREF
			//   void *m_Ptr; // [rsp+88h] [rbp-C10h]
			//   HGCamera *hgCamera; // [rsp+90h] [rbp-C08h]
			//   TerrainDepthPrepassConstructor_PassOutput lightCullResult; // [rsp+98h] [rbp-C00h] BYREF
			//   CullingResults v88; // [rsp+A8h] [rbp-BF0h]
			//   _BYTE v89[24]; // [rsp+B8h] [rbp-BE0h] BYREF
			//   HGSettingParameters *settingParameters_k__BackingField; // [rsp+D0h] [rbp-BC8h]
			//   _BYTE v91[64]; // [rsp+E0h] [rbp-BB8h] BYREF
			//   ResourceHandle v92; // [rsp+120h] [rbp-B78h]
			//   ShadowMapPassConstructor_PassInput v93; // [rsp+130h] [rbp-B68h] BYREF
			//   DepthPrepassConstructor_PassInput v94; // [rsp+180h] [rbp-B18h] BYREF
			//   TerrainDeformPassConstructor_PassInput v95; // [rsp+1E0h] [rbp-AB8h] BYREF
			//   CullingResults v96; // [rsp+210h] [rbp-A88h] BYREF
			//   TerrainDepthPrepassConstructor_PassOutput v97; // [rsp+220h] [rbp-A78h]
			//   __int128 v98; // [rsp+230h] [rbp-A68h]
			//   __m256i v99; // [rsp+240h] [rbp-A58h] BYREF
			//   __int64 v100; // [rsp+260h] [rbp-A38h]
			//   ForwardPassConstructor_PassInput v101; // [rsp+270h] [rbp-A28h] BYREF
			//   Il2CppExceptionWrapper *v102; // [rsp+320h] [rbp-978h] BYREF
			//   Il2CppExceptionWrapper *v103; // [rsp+328h] [rbp-970h] BYREF
			//   Il2CppExceptionWrapper *v104; // [rsp+330h] [rbp-968h] BYREF
			//   Il2CppExceptionWrapper *v105; // [rsp+338h] [rbp-960h] BYREF
			//   Il2CppExceptionWrapper *v106; // [rsp+340h] [rbp-958h] BYREF
			//   Il2CppExceptionWrapper *v107; // [rsp+348h] [rbp-950h] BYREF
			//   Il2CppExceptionWrapper *v108; // [rsp+350h] [rbp-948h] BYREF
			//   Il2CppExceptionWrapper *v109; // [rsp+358h] [rbp-940h] BYREF
			//   Il2CppExceptionWrapper *v110; // [rsp+360h] [rbp-938h] BYREF
			//   LightClusteringPassConstructor_PassInput input; // [rsp+370h] [rbp-928h] BYREF
			//   ShadowMapPassConstructor_PassInput v112; // [rsp+3D0h] [rbp-8C8h] BYREF
			//   DepthPrepassConstructor_PassInput v113; // [rsp+420h] [rbp-878h] BYREF
			//   TerrainDepthPrepassConstructor_PassInput v114; // [rsp+480h] [rbp-818h] BYREF
			//   ForwardPassConstructor_PassInput v115; // [rsp+4D0h] [rbp-7C8h] BYREF
			//   char v116; // [rsp+580h] [rbp-718h] BYREF
			//   char v117; // [rsp+708h] [rbp-590h]
			//   LightClusteringPassConstructor_PassOutput output; // [rsp+830h] [rbp-468h] BYREF
			//   int32_t v119; // [rsp+C40h] [rbp-58h]
			//   int32_t v120; // [rsp+C44h] [rbp-54h]
			//   char v123; // [rsp+CB8h] [rbp+20h] BYREF
			// 
			//   v3 = renderPathParams;
			//   v4 = this;
			//   if ( !byte_18D919653 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919653 = 1;
			//   }
			//   v123 = 0;
			//   sub_1802F01E0(&input, 0LL, 88LL);
			//   v75 = 0;
			//   v74 = 0;
			//   sub_1802F01E0(&v112, 0LL, 80LL);
			//   sub_1802F01E0(&v93, 0LL, 80LL);
			//   v84.atmosphereParams = 0LL;
			//   v82 = 0LL;
			//   memset(&v95, 0, sizeof(v95));
			//   v76 = 0;
			//   v88 = 0LL;
			//   memset(v89, 0, sizeof(v89));
			//   sub_1802F01E0(&v113, 0LL, 96LL);
			//   sub_1802F01E0(&v94, 0LL, 96LL);
			//   sub_1802F01E0(&v115, 0LL, 168LL);
			//   sub_1802F01E0(&v101, 0LL, 168LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3008, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3008, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v71, v70);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v4, v3, 0LL);
			//   }
			//   else
			//   {
			//     hgrp = v3.hgrp;
			//     v80 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v81 = m_RenderGraph;
			//     m_Ptr = v3.renderGraphParams.scriptableRenderContext.m_Ptr;
			//     cullingResults = v3.renderRequest.cullingResults.cullingResults;
			//     lightCullResult = (TerrainDepthPrepassConstructor_PassOutput)v3.renderRequest.cullingResults.lightCullResult;
			//     hgCamera = v3.renderRequest.hgCamera;
			//     settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//     p_renderRequest = &v3.renderRequest;
			//     v10 = &v116;
			//     v11 = 5LL;
			//     do
			//     {
			//       *(_OWORD *)v10 = *(_OWORD *)&p_renderRequest.hgCamera;
			//       *((_OWORD *)v10 + 1) = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//       *((_OWORD *)v10 + 2) = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//       *((_OWORD *)v10 + 3) = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//       *((_OWORD *)v10 + 4) = *(_OWORD *)&p_renderRequest.target.face;
			//       *((_OWORD *)v10 + 5) = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//       *((_OWORD *)v10 + 6) = p_renderRequest.cullingResults.cullingResults;
			//       v10 += 128;
			//       *((_OWORD *)v10 - 1) = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//       p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//       --v11;
			//     }
			//     while ( v11 );
			//     *(_OWORD *)v10 = *(_OWORD *)&p_renderRequest.hgCamera;
			//     *((_OWORD *)v10 + 1) = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//     *((_QWORD *)v10 + 4) = *(_QWORD *)&p_renderRequest.target.id.m_InstanceID;
			//     v12 = *(_QWORD *)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//     if ( !v12 )
			//       sub_180B536AC(v10, 0LL);
			//     v13 = *(_QWORD *)(v12 + 2504);
			//     if ( !v13 )
			//       sub_180B536AC(v10, 0LL);
			//     v14 = *(HGCharacterVolume **)(v13 + 104);
			//     if ( !v14 )
			//       sub_180B536AC(v10, 0LL);
			//     CharOutlinePassEnableState = (ForwardPassConstructor_PassOutput)HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
			//                                                                       v14,
			//                                                                       0LL);
			//     if ( !*(_QWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22 )
			//       sub_180B536AC(v16, v15);
			//     HG::Rendering::Runtime::BinningPass::Prepare(
			//       *(BinningPass **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22,
			//       m_RenderGraph,
			//       0LL);
			//     sub_1802F01E0(&output, 0LL, 1072LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)7u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       sub_1802F01E0(&v96, 0LL, 88LL);
			//       v19 = cullingResults;
			//       v96 = cullingResults;
			//       v20 = (LightCullResult)lightCullResult;
			//       v97 = lightCullResult;
			//       v21 = *(_QWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v21 )
			//         sub_1802DC2C8(v18, v17);
			//       v22 = *(_OWORD *)(v21 + 16);
			//       v98 = v22;
			//       v99.m256i_i64[0] = *(_QWORD *)(v21 + 32);
			//       v99.m256i_i32[2] = *(_DWORD *)(v21 + 40);
			//       v23 = *(_QWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v23 )
			//         sub_1802DC2C8(v18, v17);
			//       *(__int64 *)((char *)&v99.m256i_i64[1] + 4) = *(_QWORD *)(v23 + 72);
			//       v99.m256i_i64[3] = (__int64)hgrp.fields._settingParameters_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v24 = (((unsigned __int64)&v99.m256i_u64[3] >> 12) & 0x1FFFFF) >> 6;
			//         v17 = ((unsigned __int64)&v99.m256i_u64[3] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//         do
			//           v25 = qword_18D6405E0[v24 + 36190];
			//         while ( v25 != _InterlockedCompareExchange64(&qword_18D6405E0[v24 + 36190], v25 | (1LL << v17), v25) );
			//         v22 = v98;
			//         v20 = (LightCullResult)v97;
			//         v19 = v96;
			//       }
			//       input.cullingResults = v19;
			//       input.lightCullResult = v20;
			//       *(_OWORD *)&input.binningData.tileSize = v22;
			//       *(__m256i *)&input.binningData.xyOffset = v99;
			//       *(_QWORD *)&input.outputTileResult = v100;
			//       v26 = *(LightClusteringPassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//       if ( !v26 )
			//         sub_1802DC2C8(0LL, v17);
			//       HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
			//         v26,
			//         &input,
			//         &output,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v110 )
			//     {
			//       ex = v110.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)1u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       v28 = *(BinningPass **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v28 )
			//         sub_1802DC2C8(0LL, v27);
			//       HG::Rendering::Runtime::BinningPass::ConstructPass(
			//         v28,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v102 )
			//     {
			//       ex = v102.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)3u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       v75 = 0;
			//       v74 = 0;
			//       v30 = *(FoliageOccluderPassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//       if ( !v30 )
			//         sub_1802DC2C8(0LL, v29);
			//       HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
			//         v30,
			//         &v75,
			//         &v74,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v103 )
			//     {
			//       ex = v103.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)6u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       v72 = 0;
			//       v79 = 0;
			//       v32 = *(GpuClothSimulationPassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23;
			//       if ( !v32 )
			//         sub_1802DC2C8(0LL, v31);
			//       HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
			//         v32,
			//         &v72,
			//         &v79,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v104 )
			//     {
			//       ex = v104.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xCu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       sub_1802F01E0(&v93, 0LL, 80LL);
			//       v93.cullingResults = cullingResults;
			//       v93.lightCullResult = (LightCullResult)lightCullResult;
			//       v93.srpContext.m_Ptr = m_Ptr;
			//       v35 = *(_QWORD *)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       if ( !v35 )
			//         sub_1802DC2C8(v34, v33);
			//       v93.shadowManager = *(HGShadowManager **)(v35 + 1848);
			//       v36 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v37 = (((unsigned __int64)&v93 >> 12) & 0x1FFFFF) >> 6;
			//         v33 = ((unsigned __int64)&v93 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v37 + 36190]);
			//         do
			//           v38 = qword_18D6405E0[v37 + 36190];
			//         while ( v38 != _InterlockedCompareExchange64(&qword_18D6405E0[v37 + 36190], v38 | (1LL << v33), v38) );
			//         v36 = dword_18D8E43F8;
			//       }
			//       v93.directionalLightIndex = v120;
			//       v93.settingParams = settingParameters_k__BackingField;
			//       if ( v36 )
			//       {
			//         v39 = (((unsigned __int64)&v93.settingParams >> 12) & 0x1FFFFF) >> 6;
			//         v33 = ((unsigned __int64)&v93.settingParams >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v39 + 36190]);
			//         do
			//           v40 = qword_18D6405E0[v39 + 36190];
			//         while ( v40 != _InterlockedCompareExchange64(&qword_18D6405E0[v39 + 36190], v40 | (1LL << v33), v40) );
			//       }
			//       v93.settingParamsCpp = v3.perFrameSetup.settingParametersCpp;
			//       v93.punctualLightCount = v119;
			//       v93.punctualLightIndices = &output.punctualLightIndices.FixedElementField;
			//       v112 = v93;
			//       memset(v91, 0, 60);
			//       v41 = *(ShadowMapPassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20;
			//       if ( !v41 )
			//         sub_1802DC2C8(0LL, v33);
			//       HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
			//         v41,
			//         &v112,
			//         (ShadowMapPassConstructor_PassOutput *)v91,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//       *(_OWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m01 = *(_OWORD *)v91;
			//       *(_OWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02 = *(_OWORD *)&v91[16];
			//       *(_OWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = *(_OWORD *)&v91[32];
			//       *(_QWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00 = *(_QWORD *)&v91[48];
			//       v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20 = *(float *)&v91[56];
			//     }
			//     catch ( Il2CppExceptionWrapper *v105 )
			//     {
			//       ex = v105.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xDu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       v82 = 0LL;
			//       v44 = hgrp.fields._settingParameters_k__BackingField;
			//       if ( !v44 )
			//         sub_1802DC2C8(v43, v42);
			//       atmosphereParams_k__BackingField = v44.fields._atmosphereParams_k__BackingField;
			//       v82 = atmosphereParams_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v46 = (((unsigned __int64)&v82 >> 12) & 0x1FFFFF) >> 6;
			//         v42 = ((unsigned __int64)&v82 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v46 + 36190]);
			//         do
			//           v47 = qword_18D6405E0[v46 + 36190];
			//         while ( v47 != _InterlockedCompareExchange64(&qword_18D6405E0[v46 + 36190], v47 | (1LL << v42), v47) );
			//         atmosphereParams_k__BackingField = v82;
			//       }
			//       v84.atmosphereParams = atmosphereParams_k__BackingField;
			//       v72 = 0;
			//       v48 = *(SkyAtmospherePassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//       if ( !v48 )
			//         sub_1802DC2C8(0LL, v42);
			//       HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
			//         v48,
			//         &v84,
			//         (SkyAtmospherePassConstructor_PassOutput *)&v72,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v106 )
			//     {
			//       ex = v106.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x11u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       *(_QWORD *)&v89[9] = 0LL;
			//       *(_DWORD *)&v89[17] = 0;
			//       *(_WORD *)&v89[21] = 0;
			//       v89[23] = 0;
			//       v51 = cullingResults;
			//       v88 = cullingResults;
			//       *(_QWORD *)v89 = m_Ptr;
			//       v52 = v117;
			//       v89[8] = v117;
			//       v53 = v3.hgrp;
			//       if ( !v53 )
			//         sub_1802DC2C8(v50, v49);
			//       *(_QWORD *)&v89[16] = v53.fields.drawInteractionNodeMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v54 = (((unsigned __int64)&v89[16] >> 12) & 0x1FFFFF) >> 6;
			//         v49 = ((unsigned __int64)&v89[16] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v54 + 36190]);
			//         do
			//           v55 = qword_18D6405E0[v54 + 36190];
			//         while ( v55 != _InterlockedCompareExchange64(&qword_18D6405E0[v54 + 36190], v55 | (1LL << v49), v55) );
			//         v51 = v88;
			//       }
			//       v95.cullingResults = v51;
			//       *(_OWORD *)&v95.renderContext.m_Ptr = *(_OWORD *)v89;
			//       v95.drawInteractionNodeMaterial = *(Material **)&v89[16];
			//       v76 = 0;
			//       v56 = *(TerrainDeformPassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//       if ( !v56 )
			//         sub_1802DC2C8(0LL, v49);
			//       HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
			//         v56,
			//         &v95,
			//         &v76,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v107 )
			//     {
			//       ex = v107.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//       v52 = v117;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x14u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       sub_1802F01E0(v91, 0LL, 72LL);
			//       v58 = *(TextureHandle *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20;
			//       *(_DWORD *)&v91[32] = hgrp.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v91[36] = v52;
			//       v114.sceneDepth = v58;
			//       v114.cullingResults = cullingResults;
			//       *(_OWORD *)&v114.bakedLightingConfig = *(_OWORD *)&v91[32];
			//       *(_OWORD *)&v114.terrainGpuSubd = *(_OWORD *)&v91[48];
			//       v114.HZBTexture.fallBackResource = v92;
			//       lightCullResult = 0LL;
			//       v59 = *(TerrainDepthPrepassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22;
			//       if ( !v59 )
			//         sub_1802DC2C8(0LL, v57);
			//       HG::Rendering::Runtime::TerrainDepthPrepassConstructor::ConstructPass(
			//         v59,
			//         &v114,
			//         &lightCullResult,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v108 )
			//     {
			//       ex = v108.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x15u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v78 = &v123;
			//     try
			//     {
			//       sub_1802F01E0(&v94, 0LL, 96LL);
			//       v94.sceneDepth = *(TextureHandle *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v94.gBufferDepth = *(TextureHandle *)sub_182E7CCD0(&lightCullResult);
			//       v94.hgrp = hgrp;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v61 = (((unsigned __int64)&v94.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         v60 = ((unsigned __int64)&v94.hgrp >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v61 + 36190]);
			//         do
			//           v62 = qword_18D6405E0[v61 + 36190];
			//         while ( v62 != _InterlockedCompareExchange64(&qword_18D6405E0[v61 + 36190], v62 | (1LL << v60), v62) );
			//       }
			//       v94.cullingResults = cullingResults;
			//       v94.characterDepthOnlyEnable = hgrp.fields.characterDepthOnlyEnable;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(0LL, v60);
			//       v94.screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//       v94.screenCullingRatioDistance = hgCamera.fields.screenRatioCullingDistance;
			//       v94.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       v94.forwardOpaquePreZECSList = LODWORD(v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00);
			//       v94.deferredOpaquePreZECSList = -1;
			//       v94.deferredGrassPreZECSList = -1;
			//       v113 = v94;
			//       v72 = 0;
			//       v64 = *(DepthPrepassConstructor **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03;
			//       if ( !v64 )
			//         sub_1802DC2C8(0LL, v63);
			//       HG::Rendering::Runtime::DepthPrepassConstructor::ConstructPass(
			//         v64,
			//         &v113,
			//         (DepthPrepassConstructor_PassOutput *)&v72,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v109 )
			//     {
			//       ex = v109.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v4 = this;
			//       hgrp = v80;
			//       m_RenderGraph = v81;
			//     }
			//     sub_1802F01E0(&v101, 0LL, 168LL);
			//     v101.sceneColor = *(TextureHandle *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m23;
			//     v101.sceneDepth = *(TextureHandle *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20;
			//     v101.hgrp = hgrp;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v66 = (((unsigned __int64)&v101.hgrp >> 12) & 0x1FFFFF) >> 6;
			//       v65 = ((unsigned __int64)&v101.hgrp >> 12) & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v66 + 36190]);
			//       do
			//         v67 = qword_18D6405E0[v66 + 36190];
			//       while ( v67 != _InterlockedCompareExchange64(&qword_18D6405E0[v66 + 36190], v67 | (1LL << v65), v67) );
			//     }
			//     *(_QWORD *)&v101.forwardOpaqueECSRendererList = *(_QWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20;
			//     *(_OWORD *)&v101.characterOpaqueECSRendererList = *(_OWORD *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//     v101.shadowResult = *(ShadowResult *)&v4[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m01;
			//     v101.cullingResults = cullingResults;
			//     v101.bakedLightingConfig = hgrp.fields.m_CurrentRendererConfigurationBakedLighting;
			//     v68 = hgCamera;
			//     if ( !hgCamera
			//       || (*(_QWORD *)&v101.screenCullingRatio = *(_QWORD *)&hgCamera.fields.screenCullingRatio,
			//           v101.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL),
			//           v101.characterOutlineEnabled = (bool)CharOutlinePassEnableState,
			//           v115 = v101,
			//           CharOutlinePassEnableState = 0,
			//           (v68 = *(HGCamera **)&v4[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23) == 0LL) )
			//     {
			//       sub_1802DC2C8(v68, v65);
			//     }
			//     HG::Rendering::Runtime::ForwardPassConstructor::ConstructPass(
			//       (ForwardPassConstructor *)v68,
			//       &v115,
			//       &CharOutlinePassEnableState,
			//       m_RenderGraph,
			//       *(HGCamera **)&v4[1].fields._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22,
			//       0LL);
			//   }
			// }
			// 
		}

		public new void <>iFixBaseProxy_OnPreRendering(ref HGRenderPathBase.HGRenderPathParams P0)
		{
			// // Void <>iFixBaseProxy_OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathForward::__iFixBaseProxy_OnPreRendering(
			//         HGRenderPathForward *this,
			//         HGRenderPathBase_HGRenderPathParams *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering((HGRenderPathScene *)this, P0, 0LL);
			// }
			// 
		}

		private BinningPass m_binningPassConstructor;

		private FoliageOccluderPassConstructor m_foliageOccluderPassConstructor;

		private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor;

		private LightClusteringPassConstructor m_lightClusteringPassConstructor;

		private ShadowMapPassConstructor m_shadowMapPassConstructor;

		private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor;

		private TerrainDeformPassConstructor m_terrainDeformPassConstructor;

		private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor;

		private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor;

		private DepthPrepassConstructor m_depthPrepassConstructor;

		private ForwardPassConstructor m_forwardPassConstructor;

		protected uint m_forwardOpaquePreZECSList;

		protected uint m_characterOpaqueOutlinePreZECSList;

		protected uint m_forwardOpaqueECSList;

		protected uint m_forwardOpaqueEqualECSList;

		protected uint m_characterOpaqueECSList;

		protected uint m_characterOpaqueOutlineECSList;

		protected uint m_characterOpaqueOutlineEqualECSList;

		protected uint m_forwardTransparentECSList;
	}
}
