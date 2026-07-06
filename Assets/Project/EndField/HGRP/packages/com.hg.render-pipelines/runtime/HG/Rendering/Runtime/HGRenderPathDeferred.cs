using System;
using System.Runtime.CompilerServices;

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPathDeferred : HGRenderPathScene
	{
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected GBufferOutput gBufferOutput
		{
			[CompilerGenerated]
			protected get
			{
				// // GBufferOutput get_gBufferOutput()
				// GBufferOutput *HG::Rendering::Runtime::HGRenderPathDeferred::get_gBufferOutput(
				//         GBufferOutput *__return_ptr retstr,
				//         HGRenderPathDeferred *this,
				//         MethodInfo *method)
				// {
				//   GBufferOutput *result; // rax
				//   NativeArray_1_System_Int32_ v4; // xmm1
				// 
				//   result = retstr;
				//   v4 = *(NativeArray_1_System_Int32_ *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
				//   retstr.m_attachments = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
				//   retstr.m_gbufferMapping = v4;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_gBufferOutput(GBufferOutput)
				// void HG::Rendering::Runtime::HGRenderPathDeferred::set_gBufferOutput(
				//         HGRenderPathDeferred *this,
				//         GBufferOutput *value,
				//         MethodInfo *method)
				// {
				//   NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
				// 
				//   m_gbufferMapping = value.m_gbufferMapping;
				//   *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02 = value.m_attachments;
				//   *(NativeArray_1_System_Int32_ *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = m_gbufferMapping;
				// }
				// 
			}
		}

		// (get) Token: 0x0600129C RID: 4764 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected bool enableGPUDriven
		{
			[CompilerGenerated]
			protected get
			{
				// // Boolean get_enableGPUDriven()
				// bool HG::Rendering::Runtime::HGRenderPathDeferred::get_enableGPUDriven(HGRenderPathDeferred *this, MethodInfo *method)
				// {
				//   return LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21);
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_enableGPUDriven(Boolean)
				// void HG::Rendering::Runtime::HGRenderPathDeferred::set_enableGPUDriven(
				//         HGRenderPathDeferred *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected bool enableGPUDrivenInspection
		{
			[CompilerGenerated]
			protected get
			{
				// // Boolean get_enableGPUDrivenInspection()
				// bool HG::Rendering::Runtime::HGRenderPathDeferred::get_enableGPUDrivenInspection(
				//         HGRenderPathDeferred *this,
				//         MethodInfo *method)
				// {
				//   return BYTE1(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21);
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_enableGPUDrivenInspection(Boolean)
				// void HG::Rendering::Runtime::HGRenderPathDeferred::set_enableGPUDrivenInspection(
				//         HGRenderPathDeferred *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   BYTE1(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) = value;
				// }
				// 
			}
		}

		internal HGRenderPathDeferred(HGRenderPathBase.HGRenderPathResources resources, PassConstructorID[] passConstructorIDs, HGCamera camera, HGRenderPathInternal renderPath)
		{
			// // HGRenderPathDeferred(HGRenderPathBase+HGRenderPathResources, PassConstructorID[], HGCamera, HGRenderPathInternal)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGRenderPathDeferred::HGRenderPathDeferred(
			//         HGRenderPathDeferred *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         PassConstructorID__Enum__Array *passConstructorIDs,
			//         HGCamera *camera,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   GBufferProfileManager *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   GBufferProfileManager *v13; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   HGRenderPathBase_HGRenderPathResources v17; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB15 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GBufferProfileManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     byte_18D8EDB15 = 1;
			//   }
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = -1LL;
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = -1LL;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene, resources);
			//   v17 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathScene::HGRenderPathScene(
			//     (HGRenderPathScene *)this,
			//     &v17,
			//     passConstructorIDs,
			//     camera,
			//     renderPath,
			//     0LL);
			//   v10 = (GBufferProfileManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GBufferProfileManager);
			//   v13 = v10;
			//   if ( !v10 )
			//     sub_180B536AC(v12, v11);
			//   HG::Rendering::Runtime::GBufferProfileManager::GBufferProfileManager(v10, 0LL);
			//   *(_QWORD *)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00 = v13;
			//   sub_1800054D0((HGRenderPathDeferred *)((char *)this + 4976), v14, v15, v16, *(MethodInfo **)&renderPath, method);
			// }
			// 
		}

		protected override void OnPreRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering(
			//         HGRenderPathDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 characterPrePass; // rdx
			//   __int64 m_hgCharacterVolume; // rcx
			//   HGRenderPipeline *hgrp; // r15
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   HGRenderGraph *m_RenderGraph; // r15
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
			//   HGCamera *v20; // r14
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   bool v22; // al
			//   bool v23; // al
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   char v25; // si
			//   GBufferOutput *v26; // rax
			//   NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
			//   uint32_t cullingViewHandle; // r12d
			//   HGRenderGraphContext *m_RenderGraphContext; // rbx
			//   float v30; // esi
			//   float v31; // eax
			//   uint32_t v32; // r12d
			//   HGRenderGraphContext *v33; // rbx
			//   float v34; // eax
			//   float v35; // eax
			//   float v36; // eax
			//   uint32_t v37; // r12d
			//   HGRenderGraphContext *v38; // rbx
			//   float v39; // eax
			//   float v40; // eax
			//   char v41; // r13
			//   float v42; // eax
			//   uint32_t v43; // r12d
			//   HGRenderGraphContext *v44; // rbx
			//   void *m_Ptr; // rdx
			//   float v46; // eax
			//   float v47; // eax
			//   float v48; // eax
			//   HGRenderGraphContext *v49; // rbx
			//   uint32_t v50; // r12d
			//   float v51; // eax
			//   HGRenderGraphContext *v52; // rbx
			//   uint32_t v53; // r12d
			//   float v54; // eax
			//   Camera *camera; // r12
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   HGRenderGraphContext *v57; // r13
			//   uint32_t v58; // edx
			//   float v59; // eax
			//   uint32_t v60; // r13d
			//   bool enableTransparentAfterDOF; // bl
			//   bool v62; // al
			//   HGRenderFlags__Enum v63; // ebx
			//   int v64; // r12d
			//   float v65; // eax
			//   int v66; // ebx
			//   HGRenderGraphContext *v67; // r12
			//   float v68; // eax
			//   HGRenderGraphContext *v69; // rbx
			//   uint32_t v70; // r12d
			//   float v71; // eax
			//   HGRenderGraphContext *v72; // rbx
			//   uint32_t v73; // r12d
			//   float v74; // eax
			//   HGRenderGraphContext *v75; // rbx
			//   uint32_t v76; // r12d
			//   void *v77; // rax
			//   float v78; // eax
			//   float v79; // eax
			//   float v80; // eax
			//   HGRenderGraphContext *v81; // rbx
			//   uint32_t v82; // r14d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+28h] [rbp-E0h]
			//   HGRenderKeyword__Enum globalKeywordsa; // [rsp+28h] [rbp-E0h]
			//   HGRenderKeyword__Enum globalKeywordsb; // [rsp+28h] [rbp-E0h]
			//   char cullingLayerMask; // [rsp+48h] [rbp-C0h]
			//   char v88; // [rsp+68h] [rbp-A0h]
			//   char v89; // [rsp+69h] [rbp-9Fh]
			//   char v90; // [rsp+6Ah] [rbp-9Eh]
			//   bool CharOutlinePassEnableState; // [rsp+6Bh] [rbp-9Dh]
			//   char v92; // [rsp+6Ch] [rbp-9Ch]
			//   char v93; // [rsp+6Dh] [rbp-9Bh]
			//   char v94; // [rsp+6Eh] [rbp-9Ah]
			//   char v95; // [rsp+6Fh] [rbp-99h]
			//   char v96; // [rsp+70h] [rbp-98h]
			//   char v97; // [rsp+71h] [rbp-97h]
			//   char v98; // [rsp+72h] [rbp-96h]
			//   uint32_t normalList; // [rsp+74h] [rbp-94h] BYREF
			//   uint32_t preZPart0List; // [rsp+78h] [rbp-90h] BYREF
			//   uint32_t preZPart1List; // [rsp+7Ch] [rbp-8Ch] BYREF
			//   uint32_t v102; // [rsp+80h] [rbp-88h] BYREF
			//   uint32_t v103; // [rsp+84h] [rbp-84h] BYREF
			//   uint32_t v104; // [rsp+88h] [rbp-80h] BYREF
			//   uint32_t v105; // [rsp+8Ch] [rbp-7Ch] BYREF
			//   uint32_t v106; // [rsp+90h] [rbp-78h] BYREF
			//   uint32_t v107; // [rsp+94h] [rbp-74h] BYREF
			//   uint32_t v108; // [rsp+98h] [rbp-70h] BYREF
			//   uint32_t v109; // [rsp+9Ch] [rbp-6Ch] BYREF
			//   uint32_t v110; // [rsp+A0h] [rbp-68h] BYREF
			//   uint32_t viewHandle[2]; // [rsp+A8h] [rbp-60h]
			//   GBufferOutput v112; // [rsp+B0h] [rbp-58h] BYREF
			//   HGCamera *v113; // [rsp+D8h] [rbp-30h] BYREF
			//   char v114; // [rsp+3D0h] [rbp+2C8h]
			//   int32_t renderPath_k__BackingField; // [rsp+3D0h] [rbp+2C8h]
			//   uint32_t v116; // [rsp+3D0h] [rbp+2C8h]
			//   bool v117; // [rsp+3D0h] [rbp+2C8h]
			// 
			//   if ( !byte_18D91964E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D91964E = 1;
			//   }
			//   normalList = 0;
			//   preZPart0List = 0;
			//   preZPart1List = 0;
			//   v102 = 0;
			//   v103 = 0;
			//   v104 = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2978, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering((HGRenderPathScene *)this, renderPathParams, 0LL);
			//     hgrp = renderPathParams.hgrp;
			//     p_renderRequest = &renderPathParams.renderRequest;
			//     if ( hgrp )
			//     {
			//       m_RenderGraph = hgrp.fields.m_RenderGraph;
			//       m_hgCharacterVolume = (__int64)&v113;
			//       characterPrePass = 5LL;
			//       do
			//       {
			//         v10 = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//         *(_OWORD *)m_hgCharacterVolume = *(_OWORD *)&p_renderRequest.hgCamera;
			//         v11 = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//         *(_OWORD *)(m_hgCharacterVolume + 16) = v10;
			//         v12 = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//         *(_OWORD *)(m_hgCharacterVolume + 32) = v11;
			//         v13 = *(_OWORD *)&p_renderRequest.target.face;
			//         *(_OWORD *)(m_hgCharacterVolume + 48) = v12;
			//         v14 = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//         *(_OWORD *)(m_hgCharacterVolume + 64) = v13;
			//         cullingResults = p_renderRequest.cullingResults.cullingResults;
			//         *(_OWORD *)(m_hgCharacterVolume + 80) = v14;
			//         v16 = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//         p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//         *(CullingResults *)(m_hgCharacterVolume + 96) = cullingResults;
			//         m_hgCharacterVolume += 128LL;
			//         *(_OWORD *)(m_hgCharacterVolume - 16) = v16;
			//         --characterPrePass;
			//       }
			//       while ( characterPrePass );
			//       v17 = *(_OWORD *)&p_renderRequest.hgCamera;
			//       v18 = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//       v19 = *(_QWORD *)&p_renderRequest.target.id.m_InstanceID;
			//       *(_OWORD *)m_hgCharacterVolume = v17;
			//       *(_OWORD *)(m_hgCharacterVolume + 16) = v18;
			//       *(_QWORD *)(m_hgCharacterVolume + 32) = v19;
			//       v20 = v113;
			//       if ( v113 )
			//       {
			//         m_volumeComponentsData = v113.fields.m_volumeComponentsData;
			//         if ( m_volumeComponentsData )
			//         {
			//           m_hgCharacterVolume = (__int64)m_volumeComponentsData.fields.m_hgCharacterVolume;
			//           if ( m_hgCharacterVolume )
			//           {
			//             CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
			//                                            (HGCharacterVolume *)m_hgCharacterVolume,
			//                                            0LL);
			//             v22 = UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL)
			//                || UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL);
			//             if ( this )
			//             {
			//               LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) = v22;
			//               v23 = (UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL)
			//                   || UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL))
			//                  && UnityEngine::HyperGryph::GPUDrivenRendererV1::CullingInspectionMode(0LL);
			//               BYTE1(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) = v23;
			//               if ( LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) )
			//               {
			//                 if ( UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL) )
			//                   UnityEngine::HyperGryph::GPUDrivenRendererV1::AdvanceFrame(0LL);
			//                 if ( UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL) )
			//                   UnityEngine::HyperGryph::GPUDrivenRendererV2::AdvanceFrame(0LL);
			//               }
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//               m_hgCharacterVolume = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//               characterPrePass = (__int64)static_fields.characterPrePass;
			//               if ( characterPrePass )
			//               {
			//                 v25 = *(_BYTE *)(characterPrePass + 16);
			//                 characterPrePass = (__int64)static_fields.deferredOpaque;
			//                 if ( characterPrePass )
			//                 {
			//                   v89 = *(_BYTE *)(characterPrePass + 16);
			//                   characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredOpaquePreZ;
			//                   if ( characterPrePass )
			//                   {
			//                     v90 = *(_BYTE *)(characterPrePass + 16);
			//                     characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredOpaqueEqual;
			//                     if ( characterPrePass )
			//                     {
			//                       v114 = *(_BYTE *)(characterPrePass + 16);
			//                       characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredGrassPreZ;
			//                       if ( characterPrePass )
			//                       {
			//                         v92 = *(_BYTE *)(characterPrePass + 16);
			//                         characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredGrass;
			//                         if ( characterPrePass )
			//                         {
			//                           v93 = *(_BYTE *)(characterPrePass + 16);
			//                           characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredSludge;
			//                           if ( characterPrePass )
			//                           {
			//                             v94 = *(_BYTE *)(characterPrePass + 16);
			//                             characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.forwardTransparent;
			//                             if ( characterPrePass )
			//                             {
			//                               v88 = *(_BYTE *)(characterPrePass + 16);
			//                               characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.forwardOpaque;
			//                               if ( characterPrePass )
			//                               {
			//                                 v95 = *(_BYTE *)(characterPrePass + 16);
			//                                 characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.forwardOpaquePreZ;
			//                                 if ( characterPrePass )
			//                                 {
			//                                   v96 = *(_BYTE *)(characterPrePass + 16);
			//                                   characterPrePass = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.forwardOpaqueEqual;
			//                                   if ( characterPrePass )
			//                                   {
			//                                     v97 = *(_BYTE *)(characterPrePass + 16);
			//                                     m_hgCharacterVolume = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.forwardCharacter;
			//                                     if ( m_hgCharacterVolume )
			//                                     {
			//                                       v98 = *(_BYTE *)(m_hgCharacterVolume + 16);
			//                                       v26 = HG::Rendering::Runtime::HGRenderPathDeferred::PrepareGBufferOutput(
			//                                               &v112,
			//                                               this,
			//                                               renderPathParams,
			//                                               0LL);
			//                                       m_gbufferMapping = v26.m_gbufferMapping;
			//                                       *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02 = v26.m_attachments;
			//                                       *(NativeArray_1_System_Int32_ *)&this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = m_gbufferMapping;
			//                                       if ( v25 )
			//                                       {
			//                                         cullingViewHandle = v20.fields.cullingViewHandle;
			//                                         if ( !m_RenderGraph )
			//                                           goto LABEL_114;
			//                                         m_RenderGraphContext = m_RenderGraph.fields.m_RenderGraphContext;
			//                                         if ( !m_RenderGraphContext )
			//                                           goto LABEL_114;
			//                                         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                         v30 = NAN;
			//                                         LOWORD(globalKeywords) = 0;
			//                                         v31 = COERCE_FLOAT(
			//                                                 UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                   cullingViewHandle,
			//                                                   HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                                                   HGRenderFlags__Enum_Opaque,
			//                                                   HGShaderLightMode__Enum_DepthCharacterOnly,
			//                                                   globalKeywords,
			//                                                   m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                                                   0,
			//                                                   0,
			//                                                   0xFFFFFFFF,
			//                                                   0,
			//                                                   0,
			//                                                   0LL));
			//                                       }
			//                                       else
			//                                       {
			//                                         v30 = NAN;
			//                                         v31 = NAN;
			//                                       }
			//                                       this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21 = v31;
			//                                       this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = NAN;
			//                                       this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m30 = NAN;
			//                                       this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11 = NAN;
			//                                       if ( !LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) )
			//                                         goto LABEL_62;
			//                                       if ( UnityEngine::HyperGryph::GPUDrivenRendererV1::Valid(0LL) )
			//                                       {
			//                                         v32 = v20.fields.cullingViewHandle;
			//                                         if ( !m_RenderGraph )
			//                                           goto LABEL_114;
			//                                         v33 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                         if ( !v33 )
			//                                           goto LABEL_114;
			//                                         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                         UnityEngine::HyperGryph::GPUDrivenRendererV1::CreateRendererListWithPreZ(
			//                                           v32,
			//                                           0x500u,
			//                                           0x100u,
			//                                           1u,
			//                                           v33.fields.renderContext.m_Ptr,
			//                                           1,
			//                                           &normalList,
			//                                           &preZPart0List,
			//                                           &preZPart1List,
			//                                           &v20.fields.mainViewConstants.prevNonJitteredViewProjMatrix,
			//                                           0LL);
			//                                         v34 = NAN;
			//                                         if ( v89 )
			//                                           v34 = *(float *)&normalList;
			//                                         this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = v34;
			//                                         v35 = NAN;
			//                                         if ( v90 )
			//                                           v35 = *(float *)&preZPart0List;
			//                                         this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m30 = v35;
			//                                         v36 = NAN;
			//                                         if ( v114 )
			//                                           v36 = *(float *)&preZPart1List;
			//                                         this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11 = v36;
			//                                       }
			//                                       if ( LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21)
			//                                         && UnityEngine::HyperGryph::GPUDrivenRendererV2::Valid(0LL) )
			//                                       {
			//                                         v37 = v20.fields.cullingViewHandle;
			//                                         if ( !m_RenderGraph )
			//                                           goto LABEL_114;
			//                                         v38 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                         if ( !v38 )
			//                                           goto LABEL_114;
			//                                         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                         UnityEngine::HyperGryph::GPUDrivenRendererV2::CreateRendererListWithPreZ(
			//                                           v37,
			//                                           0x500u,
			//                                           0x100u,
			//                                           1u,
			//                                           v38.fields.renderContext.m_Ptr,
			//                                           1,
			//                                           &v102,
			//                                           &v103,
			//                                           &v104,
			//                                           &v20.fields.mainViewConstants.prevNonJitteredViewProjMatrix,
			//                                           0LL);
			//                                         v39 = NAN;
			//                                         if ( v89 )
			//                                           v39 = *(float *)&v102;
			//                                         this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = v39;
			//                                         v40 = NAN;
			//                                         if ( v90 )
			//                                           v40 = *(float *)&v103;
			//                                         v41 = v114;
			//                                         this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m30 = v40;
			//                                         v42 = NAN;
			//                                         if ( v114 )
			//                                           v42 = *(float *)&v104;
			//                                         this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11 = v42;
			//                                       }
			//                                       else
			//                                       {
			// LABEL_62:
			//                                         v41 = v114;
			//                                       }
			//                                       v43 = v20.fields.cullingViewHandle;
			//                                       if ( m_RenderGraph )
			//                                       {
			//                                         v44 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                         if ( v44 )
			//                                         {
			//                                           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                           m_Ptr = v44.fields.renderContext.m_Ptr;
			//                                           cullingLayerMask = LOBYTE(this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21);
			//                                           v105 = 0;
			//                                           v106 = 0;
			//                                           v107 = 0;
			//                                           UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
			//                                             v43,
			//                                             0x500u,
			//                                             0x100u,
			//                                             1u,
			//                                             m_Ptr,
			//                                             &v105,
			//                                             &v106,
			//                                             &v107,
			//                                             cullingLayerMask,
			//                                             0LL);
			//                                           v46 = NAN;
			//                                           if ( v89 )
			//                                             v46 = *(float *)&v105;
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m31 = v46;
			//                                           v47 = NAN;
			//                                           if ( v90 )
			//                                             v47 = *(float *)&v106;
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20 = v47;
			//                                           v48 = NAN;
			//                                           if ( v41 )
			//                                             v48 = *(float *)&v107;
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02 = v48;
			//                                           if ( v92 )
			//                                           {
			//                                             v49 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             v50 = v20.fields.cullingViewHandle;
			//                                             if ( !v49 )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             v51 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                                                       v50,
			//                                                       HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                                                       HGRenderFlags__Enum_Opaque,
			//                                                       HGShaderLightMode__Enum_DepthOnly,
			//                                                       v49.fields.renderContext.m_Ptr,
			//                                                       0,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v51 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m11 = v51;
			//                                           if ( v93 )
			//                                           {
			//                                             v52 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             v53 = v20.fields.cullingViewHandle;
			//                                             if ( !v52 )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             v54 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                                                       v53,
			//                                                       HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                                                       HGRenderFlags__Enum_Opaque,
			//                                                       HGShaderLightMode__Enum_GBuffer,
			//                                                       v52.fields.renderContext.m_Ptr,
			//                                                       0,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v54 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m12 = v54;
			//                                           if ( v94 )
			//                                           {
			//                                             camera = v20.fields.camera;
			//                                             sceneRTSize_k__BackingField = v20.fields._sceneRTSize_k__BackingField;
			//                                             viewHandle[0] = v20.fields.cullingViewHandle;
			//                                             renderPath_k__BackingField = this.fields._._._renderPath_k__BackingField;
			//                                             v57 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             if ( !v57 )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             v58 = 8;
			//                                             if ( renderPath_k__BackingField != 4 )
			//                                               v58 = 4;
			//                                             v59 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGSludgeRender::CreateRendererList(
			//                                                       camera,
			//                                                       sceneRTSize_k__BackingField,
			//                                                       viewHandle[0],
			//                                                       1u,
			//                                                       v58,
			//                                                       1200.0,
			//                                                       v57.fields.renderContext.m_Ptr,
			//                                                       1,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v59 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22 = v59;
			//                                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//                                           v60 = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(0xFFFFFFFF, 0LL);
			//                                           if ( v88 )
			//                                           {
			//                                             v116 = v20.fields.cullingViewHandle;
			//                                             enableTransparentAfterDOF = HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
			//                                                                           v20,
			//                                                                           0LL);
			//                                             v62 = HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
			//                                                     v20,
			//                                                     0LL);
			//                                             m_hgCharacterVolume = 1536LL;
			//                                             v63 = enableTransparentAfterDOF
			//                                                 ? HGRenderFlags__Enum_TransparentBeforeDistortion|HGRenderFlags__Enum_ShadowOnly
			//                                                 : HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent;
			//                                             v64 = v62 ? 0x600 : 0;
			//                                             *(_QWORD *)viewHandle = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             if ( !*(_QWORD *)viewHandle )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             LOWORD(globalKeywordsa) = 0;
			//                                             v65 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                       v116,
			//                                                       v63,
			//                                                       (HGRenderFlags__Enum)(v64 + 512),
			//                                                       (HGShaderLightMode__Enum)((CharOutlinePassEnableState << 9) + 8416),
			//                                                       globalKeywordsa,
			//                                                       *(void **)(*(_QWORD *)viewHandle + 16LL),
			//                                                       1,
			//                                                       1,
			//                                                       v60,
			//                                                       0,
			//                                                       0,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v65 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = v65;
			//                                           if ( v88 )
			//                                           {
			//                                             viewHandle[0] = v20.fields.cullingViewHandle;
			//                                             v66 = (!HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
			//                                                       v20,
			//                                                       0LL)
			//                                                  + 1) << 12;
			//                                             v117 = HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(
			//                                                      v20,
			//                                                      0LL);
			//                                             v67 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             if ( !v67 )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             LOWORD(globalKeywordsa) = 0;
			//                                             v68 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                       viewHandle[0],
			//                                                       (HGRenderFlags__Enum)(v66 | 0x400),
			//                                                       (HGRenderFlags__Enum)((!v117 + 1) << 12),
			//                                                       (HGShaderLightMode__Enum)((CharOutlinePassEnableState << 9) + 8416),
			//                                                       globalKeywordsa,
			//                                                       v67.fields.renderContext.m_Ptr,
			//                                                       1,
			//                                                       1,
			//                                                       v60,
			//                                                       0,
			//                                                       0,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v68 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m10 = v68;
			//                                           if ( v88
			//                                             && HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(v20, 0LL) )
			//                                           {
			//                                             v69 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             v70 = v20.fields.cullingViewHandle;
			//                                             if ( !v69 )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             LOWORD(globalKeywordsa) = 0;
			//                                             v71 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                       v70,
			//                                                       HGRenderFlags__Enum_TransparentAfterPP|HGRenderFlags__Enum_ShadowOnly,
			//                                                       HGRenderFlags__Enum_TransparentAfterPP,
			//                                                       (HGShaderLightMode__Enum)((CharOutlinePassEnableState << 9) + 8416),
			//                                                       globalKeywordsa,
			//                                                       v69.fields.renderContext.m_Ptr,
			//                                                       1,
			//                                                       1,
			//                                                       v60,
			//                                                       0,
			//                                                       0,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v71 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21 = v71;
			//                                           if ( v88 )
			//                                           {
			//                                             v72 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             v73 = v20.fields.cullingViewHandle;
			//                                             if ( !v72 )
			//                                               goto LABEL_114;
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             LOWORD(globalKeywordsa) = 0;
			//                                             v74 = COERCE_FLOAT(
			//                                                     UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                       v73,
			//                                                       HGRenderFlags__Enum_Transparent,
			//                                                       HGRenderFlags__Enum_Transparent,
			//                                                       HGShaderLightMode__Enum_ForwardReflection,
			//                                                       globalKeywordsa,
			//                                                       v72.fields.renderContext.m_Ptr,
			//                                                       1,
			//                                                       1,
			//                                                       v60,
			//                                                       0,
			//                                                       0,
			//                                                       0LL));
			//                                           }
			//                                           else
			//                                           {
			//                                             v74 = NAN;
			//                                           }
			//                                           this[1].fields._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = v74;
			//                                           v75 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                           v76 = v20.fields.cullingViewHandle;
			//                                           if ( v75 )
			//                                           {
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                             v77 = v75.fields.renderContext.m_Ptr;
			//                                             v108 = 0;
			//                                             v109 = 0;
			//                                             v110 = 0;
			//                                             UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
			//                                               v76,
			//                                               0x500u,
			//                                               0x100u,
			//                                               0x2020u,
			//                                               v77,
			//                                               &v108,
			//                                               &v109,
			//                                               &v110,
			//                                               0,
			//                                               0LL);
			//                                             v78 = NAN;
			//                                             if ( v95 )
			//                                               v78 = *(float *)&v108;
			//                                             this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m32 = v78;
			//                                             v79 = NAN;
			//                                             if ( v96 )
			//                                               v79 = *(float *)&v109;
			//                                             this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m30 = v79;
			//                                             v80 = NAN;
			//                                             if ( v97 )
			//                                               v80 = *(float *)&v110;
			//                                             this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03 = v80;
			//                                             if ( !v98 )
			//                                               goto LABEL_112;
			//                                             v81 = m_RenderGraph.fields.m_RenderGraphContext;
			//                                             v82 = v20.fields.cullingViewHandle;
			//                                             if ( v81 )
			//                                             {
			//                                               sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                               LOWORD(globalKeywordsb) = 0;
			//                                               v30 = COERCE_FLOAT(
			//                                                       UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                                         v82,
			//                                                         HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                                                         HGRenderFlags__Enum_Opaque,
			//                                                         HGShaderLightMode__Enum_ForwardCharacterOnly,
			//                                                         globalKeywordsb,
			//                                                         v81.fields.renderContext.m_Ptr,
			//                                                         0,
			//                                                         0,
			//                                                         0xFFFFFFFF,
			//                                                         0,
			//                                                         0,
			//                                                         0LL));
			// LABEL_112:
			//                                               this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m33 = v30;
			//                                               return;
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_114:
			//     sub_180B536AC(m_hgCharacterVolume, characterPrePass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2978, 0LL);
			//   if ( !Patch )
			//     goto LABEL_114;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			// }
			// 
		}

		protected abstract GBufferProfileManager.GBufferProfileConfig GetGBufferProfileConfig();

		private GBufferOutput PrepareGBufferOutput(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // GBufferOutput PrepareGBufferOutput(HGRenderPathBase+HGRenderPathParams ByRef)
			// GBufferOutput *HG::Rendering::Runtime::HGRenderPathDeferred::PrepareGBufferOutput(
			//         GBufferOutput *__return_ptr retstr,
			//         HGRenderPathDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   HGRenderPipeline *hgrp; // rax
			//   HGCamera *hgCamera; // r14
			//   HGSettingParameters *settingParameters_k__BackingField; // rbx
			//   HGRenderGraph *m_RenderGraph; // rbp
			//   SettingParameter_1_System_Single_ *copySceneRTScale_k__BackingField; // rbx
			//   GBufferProfileManager *v14; // r15
			//   GBufferProfileManager_GBufferProfileConfig__Enum v15; // esi
			//   float v16; // xmm0_4
			//   GBufferOutput *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ m_attachments; // xmm0
			//   NativeArray_1_System_Int32_ m_gbufferMapping; // xmm1
			//   GBufferOutput *result; // rax
			//   GBufferOutput v22; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D91964F )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D91964F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2988, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2988, 0LL);
			//     if ( Patch )
			//     {
			//       v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1070(&v22, Patch, (Object *)this, renderPathParams, 0LL);
			//       goto LABEL_11;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v8, v7);
			//   }
			//   hgrp = renderPathParams.hgrp;
			//   if ( !hgrp )
			//     goto LABEL_9;
			//   hgCamera = renderPathParams.renderRequest.hgCamera;
			//   settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//   m_RenderGraph = hgrp.fields.m_RenderGraph;
			//   if ( !settingParameters_k__BackingField )
			//     goto LABEL_9;
			//   copySceneRTScale_k__BackingField = settingParameters_k__BackingField.fields._copySceneRTScale_k__BackingField;
			//   v14 = *(GBufferProfileManager **)&this[1].fields._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//   v15 = (unsigned int)sub_18003ED00(18LL);
			//   v16 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           copySceneRTScale_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v14 )
			//     goto LABEL_9;
			//   v17 = HG::Rendering::Runtime::GBufferProfileManager::SetupGBufferOutput(
			//           &v22,
			//           v14,
			//           v15,
			//           m_RenderGraph,
			//           hgCamera,
			//           v16,
			//           0LL);
			// LABEL_11:
			//   m_attachments = v17.m_attachments;
			//   m_gbufferMapping = v17.m_gbufferMapping;
			//   result = retstr;
			//   retstr.m_attachments = m_attachments;
			//   retstr.m_gbufferMapping = m_gbufferMapping;
			//   return result;
			// }
			// 
			return null;
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

		internal const int MAX_GBUFFER_COUNT = 8;

		protected GBufferProfileManager m_gBufferProfileMgr;

		protected uint m_deferredOpaquePreZECSList;

		protected uint m_forwardOpaquePreZECSList;

		protected uint m_characterOpaqueOutlinePreZECSList;

		protected uint m_deferredGrassPreZECSList;

		protected uint m_characterPrePassECSList;

		protected uint m_deferredOpaqueECSList;

		protected uint m_deferredOpaqueEqualECSList;

		protected uint m_deferredGrassECSList;

		protected uint m_deferredSludgeECSList;

		protected uint m_forwardOpaqueECSList;

		protected uint m_forwardOpaqueEqualECSList;

		protected uint m_characterOpaqueOutlineECSList;

		protected uint m_characterOpaqueOutlineEqualECSList;

		protected uint m_characterOpaqueECSList;

		protected uint m_forwardTransparentECSList;

		protected uint m_forwardTransparentAfterDistortionECSList;

		protected uint m_forwardReflectionECSList;

		protected uint m_deferredOpaquePreZGPUDrivenList;

		protected uint m_deferredOpaqueGPUDrivenList;

		protected uint m_deferredOpaqueEqualGPUDrivenList;
	}
}
