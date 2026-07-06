using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class WaterOnePassDeferredRenderingPass : IPassConstructor
	{
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00002608 File Offset: 0x00000808
		public int waterVRRx
		{
			get
			{
				// // LayerMask get_value()
				// LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
				//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
				//         MethodInfo *method)
				// {
				//   return (LayerMask)this.fields.m_Value.m_Mask;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00002608 File Offset: 0x00000808
		public int waterVRRy
		{
			get
			{
				// // Int32 get_rolloverSize()
				// int32_t TMPro::TMP_TextProcessingStack<System::Object>::get_rolloverSize(
				//         TMP_TextProcessingStack_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_RolloverSize;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000025D2 File Offset: 0x000007D2
		public CBHandle cbHandle
		{
			get
			{
				// // WorldEnergyPointConst get_data()
				// WorldEnergyPointConst *Beyond::Cfg::SparkBeanTable<Beyond::Cfg::WorldEnergyPointConst>::get_data(
				//         WorldEnergyPointConst *__return_ptr retstr,
				//         SparkBeanTable_1_WorldEnergyPointConst_ *this,
				//         MethodInfo *method)
				// {
				//   WorldEnergyPointConst *result; // rax
				//   __int64 v4; // xmm1_8
				// 
				//   result = retstr;
				//   v4 = *(_QWORD *)&this.fields.m_data.m_bean.m_dataOffset;
				//   *(_OWORD *)&retstr.m_bean.m_beanType = *(_OWORD *)&this.fields.m_data.m_bean.m_beanType;
				//   *(_QWORD *)&retstr.m_bean.m_dataOffset = v4;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle sectorTexture
		{
			get
			{
				// // Nullable`1[Int64] get_To()
				// Nullable_1_Int64_ *System::Net::Http::Headers::ContentRangeHeaderValue::get_To(
				//         Nullable_1_Int64_ *__return_ptr retstr,
				//         ContentRangeHeaderValue *this,
				//         MethodInfo *method)
				// {
				//   Nullable_1_Int64_ *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields._To_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle interactionTexture
		{
			get
			{
				// // JXtFhzUqozCGLAAgSlsxdSapKppi+xzMuoUlvKGCyuZtipJBdZbVUadLB phfxSRReOuQPnaNdTkXaBXrplmKF()
				// JXtFhzUqozCGLAAgSlsxdSapKppi_xzMuoUlvKGCyuZtipJBdZbVUadLB *JXtFhzUqozCGLAAgSlsxdSapKppi::phfxSRReOuQPnaNdTkXaBXrplmKF(
				//         JXtFhzUqozCGLAAgSlsxdSapKppi_xzMuoUlvKGCyuZtipJBdZbVUadLB *__return_ptr retstr,
				//         JXtFhzUqozCGLAAgSlsxdSapKppi *this,
				//         MethodInfo *method)
				// {
				//   JXtFhzUqozCGLAAgSlsxdSapKppi_xzMuoUlvKGCyuZtipJBdZbVUadLB *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.GFPiBctkpLainibUgLYxBOCTbeWVA;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x000025D0 File Offset: 0x000007D0
		public TextureHandle reflectionLightingTexture
		{
			get
			{
				// // FloatProperty get_jobWeight()
				// FloatProperty *UnityEngine::Animations::Rigging::TwistCorrectionJob::get_jobWeight(
				//         FloatProperty *__return_ptr retstr,
				//         TwistCorrectionJob *this,
				//         MethodInfo *method)
				// {
				//   FloatProperty *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this._jobWeight_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_jobWeight(FloatProperty)
				// void UnityEngine::Animations::Rigging::TwistCorrectionJob::set_jobWeight(
				//         TwistCorrectionJob *this,
				//         FloatProperty *value,
				//         MethodInfo *method)
				// {
				//   this._jobWeight_k__BackingField = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600123E RID: 4670 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle reflectionFadenessTexture
		{
			get
			{
				// // FloatProperty get_jobWeight()
				// FloatProperty *UnityEngine::Animations::Rigging::DampedTransformJob::get_jobWeight(
				//         FloatProperty *__return_ptr retstr,
				//         DampedTransformJob *this,
				//         MethodInfo *method)
				// {
				//   FloatProperty *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this._jobWeight_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle gBufferATexture
		{
			get
			{
				// // CullingResults get_cullingResult()
				// CullingResults *UnityEngine::Experimental::Rendering::RendererListDesc::get_cullingResult(
				//         CullingResults *__return_ptr retstr,
				//         RendererListDesc_1 *this,
				//         MethodInfo *method)
				// {
				//   CullingResults *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this._cullingResult_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle gBufferMVTexture
		{
			get
			{
				// // TextureHandle get_gBufferMVTexture()
				// TextureHandle *HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::get_gBufferMVTexture(
				//         TextureHandle *__return_ptr retstr,
				//         WaterOnePassDeferredRenderingPass *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_gBufferMVTexture;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle prepassDepthTexture
		{
			get
			{
				// // CullingResults get_cullingResult()
				// CullingResults *UnityEngine::Rendering::RendererUtils::RendererListDesc::get_cullingResult(
				//         CullingResults *__return_ptr retstr,
				//         RendererListDesc *this,
				//         MethodInfo *method)
				// {
				//   CullingResults *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this._cullingResult_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001242 RID: 4674 RVA: 0x000025D2 File Offset: 0x000007D2
		public Material waterRenderingMaterial
		{
			get
			{
				// // Object <RegisterPorts>b__9_2()
				// Object *FlowCanvas::Nodes::CustomEvent<System::Object>::_RegisterPorts_b__9_2(
				//         CustomEvent_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.receivedValue;
				// }
				// 
				return null;
			}
		}

		internal WaterOnePassDeferredRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		public void Prepare(HGCamera hgCamera, HGSettingParameters settingParameters, ScriptableRenderContext renderContext)
		{
			// // Void Prepare(HGCamera, HGSettingParameters, ScriptableRenderContext)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::Prepare(
			//         WaterOnePassDeferredRenderingPass *this,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameters,
			//         ScriptableRenderContext renderContext,
			//         MethodInfo *method)
			// {
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   bool ShouldRenderWater; // al
			//   HGManagerContext *currentManagerContext; // rax
			//   HGWaterManager *waterManager_k__BackingField; // r15
			//   HGManagerContext *v13; // rax
			//   HGWaterGlobalConfig *globalConfig; // rax
			//   HGWaterGlobalConfig *v15; // r14
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v16; // rdx
			//   VolumetricRenderer_VolumetricBounds *v17; // r8
			//   Material *v18; // r9
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v19; // rdx
			//   VolumetricRenderer_VolumetricBounds *v20; // r8
			//   Material *v21; // r9
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v22; // rdx
			//   VolumetricRenderer_VolumetricBounds *v23; // r8
			//   Material *v24; // r9
			//   _OWORD *v25; // rax
			//   CBHandle *v26; // rax
			//   void *ptr; // xmm0_8
			//   MethodInfo *orthoViewProj; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *orthoViewProja; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *orthoViewProjb; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *orthoDeviceViewProj; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *orthoDeviceViewProja; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *orthoDeviceViewProjb; // [rsp+30h] [rbp-D8h]
			//   int32_t orthoDeviceInvViewProj; // [rsp+38h] [rbp-D0h]
			//   int32_t orthoDeviceInvViewProja; // [rsp+38h] [rbp-D0h]
			//   int32_t orthoDeviceInvViewProjb; // [rsp+38h] [rbp-D0h]
			//   _QWORD v37[9]; // [rsp+40h] [rbp-C8h] BYREF
			//   Matrix4x4 v38; // [rsp+88h] [rbp-80h] BYREF
			//   Matrix4x4 v39; // [rsp+C8h] [rbp-40h] BYREF
			//   _BYTE v40[64]; // [rsp+108h] [rbp+0h] BYREF
			//   CBHandle v41; // [rsp+148h] [rbp+40h] BYREF
			//   ScriptableRenderContext P3; // [rsp+1A0h] [rbp+98h] BYREF
			// 
			//   P3.m_Ptr = renderContext.m_Ptr;
			//   if ( !byte_18D919634 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919634 = 1;
			//   }
			//   sub_1802F01E0(&v39, 0LL, 64LL);
			//   sub_1802F01E0(&v38, 0LL, 64LL);
			//   sub_1802F01E0(&v37[1], 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2947, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2947, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1058(
			//       Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)settingParameters,
			//       P3,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       goto LABEL_14;
			//     ShouldRenderWater = HG::Rendering::Runtime::HGCamera::ShouldRenderWater(hgCamera, 0LL);
			//     this.fields.m_isRendering = ShouldRenderWater;
			//     if ( ShouldRenderWater )
			//     {
			//       this.fields.m_cullHandle = hgCamera.fields.waterProxyCullHandle;
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( currentManagerContext )
			//       {
			//         waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//         v13 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//         if ( v13 )
			//         {
			//           Patch = (ILFixDynamicMethodWrapper_2 *)v13.fields._waterManager_k__BackingField;
			//           if ( Patch )
			//           {
			//             globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)Patch, 0LL);
			//             v15 = globalConfig;
			//             if ( globalConfig )
			//             {
			//               this.fields.m_globalFlowmapTexture = HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(
			//                                                       globalConfig,
			//                                                       0LL);
			//               sub_1800054D0(
			//                 (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_globalFlowmapTexture,
			//                 v16,
			//                 v17,
			//                 v18,
			//                 orthoViewProj,
			//                 orthoDeviceViewProj,
			//                 orthoDeviceInvViewProj,
			//                 v37[0],
			//                 *(float *)&v37[1],
			//                 v37[2],
			//                 v37[3],
			//                 v37[4],
			//                 (MethodInfo *)v37[5]);
			//               this.fields.m_globalCausticTexture = HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(
			//                                                       v15,
			//                                                       0LL);
			//               sub_1800054D0(
			//                 (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_globalCausticTexture,
			//                 v19,
			//                 v20,
			//                 v21,
			//                 orthoViewProja,
			//                 orthoDeviceViewProja,
			//                 orthoDeviceInvViewProja,
			//                 v37[0],
			//                 *(float *)&v37[1],
			//                 v37[2],
			//                 v37[3],
			//                 v37[4],
			//                 (MethodInfo *)v37[5]);
			//               this.fields.m_globalNormalTextureArray = HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
			//                                                           v15,
			//                                                           0LL);
			//               sub_1800054D0(
			//                 (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_globalNormalTextureArray,
			//                 v22,
			//                 v23,
			//                 v24,
			//                 orthoViewProjb,
			//                 orthoDeviceViewProjb,
			//                 orthoDeviceInvViewProjb,
			//                 v37[0],
			//                 *(float *)&v37[1],
			//                 v37[2],
			//                 v37[3],
			//                 v37[4],
			//                 (MethodInfo *)v37[5]);
			//               v39 = *(Matrix4x4 *)sub_182805160(v40);
			//               v38 = *(Matrix4x4 *)sub_182805160(v40);
			//               v25 = (_OWORD *)sub_182805160(v40);
			//               *(_OWORD *)&v37[1] = *v25;
			//               *(_OWORD *)&v37[3] = v25[1];
			//               *(_OWORD *)&v37[5] = v25[2];
			//               *(_OWORD *)&v37[7] = v25[3];
			//               sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//               v26 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v41, &P3, 20768, 0LL);
			//               ptr = v26.ptr;
			//               *(_OWORD *)&this.fields.m_cbHandle.bufferId = *(_OWORD *)&v26.bufferId;
			//               this.fields.m_cbHandle.ptr = ptr;
			//               if ( waterManager_k__BackingField )
			//               {
			//                 HG::Rendering::Runtime::HGWaterManager::SetWaterDataCB(
			//                   waterManager_k__BackingField,
			//                   hgCamera,
			//                   settingParameters,
			//                   &this.fields.m_cbHandle,
			//                   &v39,
			//                   &v38,
			//                   (Matrix4x4 *)&v37[1],
			//                   0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_14:
			//       sub_180B536AC(Patch, v8);
			//     }
			//     this.fields.m_cullHandle = 0;
			//   }
			// }
			// 
		}

		internal void RenderReflectPass(ref WaterOnePassDeferredRenderingPass.PassInput input, ref WaterOnePassDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameters)
		{
			// // Void RenderReflectPass(WaterOnePassDeferredRenderingPass+PassInput ByRef, WaterOnePassDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderReflectPass(
			//         WaterOnePassDeferredRenderingPass *this,
			//         WaterOnePassDeferredRenderingPass_PassInput *input,
			//         WaterOnePassDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   Object *v7; // r14
			//   WaterOnePassDeferredRenderingPass *v10; // rdi
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   MonitorData *v15; // r15
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   TextureHandle v18; // xmm0
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   ProfilingSampler *v21; // rax
			//   int v22; // r8d
			//   __int64 v23; // rcx
			//   __int64 v24; // rdx
			//   int v25; // eax
			//   unsigned __int64 v26; // rdx
			//   unsigned __int64 v27; // r8
			//   char v28; // dl
			//   signed __int64 v29; // rtt
			//   __int64 v30; // rdx
			//   MaterialPropertyBlock *m_mpb; // rcx
			//   unsigned __int64 v32; // rdx
			//   unsigned __int64 v33; // r8
			//   char v34; // dl
			//   signed __int64 v35; // rtt
			//   __int64 v36; // r13
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   TextureHandle v39; // xmm0
			//   ProfilingSampler *v40; // rax
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   __int64 v43; // rdx
			//   __int64 m_cullHandle; // rcx
			//   Object *v45; // rdx
			//   int v46; // eax
			//   unsigned __int64 v47; // rdx
			//   unsigned __int64 v48; // r8
			//   char v49; // dl
			//   signed __int64 v50; // rtt
			//   Object *v51; // rdx
			//   Object__Class *m_waterRenderingMaterial; // rcx
			//   unsigned __int64 v53; // rdx
			//   unsigned __int64 v54; // r8
			//   char v55; // dl
			//   signed __int64 v56; // rtt
			//   Object *v57; // rdx
			//   MonitorData *v58; // rcx
			//   unsigned __int64 v59; // rdx
			//   unsigned __int64 v60; // r8
			//   signed __int64 v61; // rtt
			//   Object__Class *ptr; // xmm1_8
			//   Object *v63; // rax
			//   Object *v64; // rsi
			//   __int64 v65; // rdx
			//   __int64 v66; // rcx
			//   TextureHandle v67; // xmm0
			//   Object *v68; // rsi
			//   __int64 v69; // rdx
			//   __int64 v70; // rcx
			//   TextureHandle v71; // xmm0
			//   Object *v72; // rsi
			//   __int64 v73; // rdx
			//   __int64 v74; // rcx
			//   TextureHandle v75; // xmm0
			//   Object *v76; // rsi
			//   Color m_previousReflectLightingTexture; // xmm0
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   TextureHandle v80; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v82; // rdx
			//   __int64 v83; // rcx
			//   Object *v84; // [rsp+50h] [rbp-398h] BYREF
			//   TextureHandle v85; // [rsp+58h] [rbp-390h] BYREF
			//   __int64 v86; // [rsp+68h] [rbp-380h] BYREF
			//   TextureHandle sceneMV; // [rsp+70h] [rbp-378h] BYREF
			//   TextureHandle lowResSceneDepth; // [rsp+80h] [rbp-368h] BYREF
			//   HGRenderGraphBuilder v89; // [rsp+A0h] [rbp-348h] BYREF
			//   HGRenderGraphBuilder v90; // [rsp+C0h] [rbp-328h] BYREF
			//   HGRenderGraphBuilder v91; // [rsp+E0h] [rbp-308h] BYREF
			//   TextureDesc v92; // [rsp+100h] [rbp-2E8h] BYREF
			//   Color sceneColor; // [rsp+160h] [rbp-288h] BYREF
			//   Il2CppExceptionWrapper *v94; // [rsp+170h] [rbp-278h] BYREF
			//   Il2CppExceptionWrapper *v95; // [rsp+178h] [rbp-270h] BYREF
			//   TextureDesc v96; // [rsp+180h] [rbp-268h] BYREF
			//   TextureDesc v97; // [rsp+1E0h] [rbp-208h] BYREF
			//   TextureDesc v98; // [rsp+240h] [rbp-1A8h] BYREF
			//   TextureDesc v99; // [rsp+2A0h] [rbp-148h] BYREF
			//   TextureDesc v100; // [rsp+360h] [rbp-88h] BYREF
			// 
			//   v7 = (Object *)renderGraph;
			//   v10 = this;
			//   if ( !byte_18D919635 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//     sub_18003C530(&off_18CDB14F8);
			//     byte_18D919635 = 1;
			//   }
			//   sub_1802F01E0(&v97, 0LL, 96LL);
			//   sub_1802F01E0(&v92, 0LL, 96LL);
			//   sub_1802F01E0(&v96.slices, 0LL, 88LL);
			//   memset(&v91, 0, sizeof(v91));
			//   v86 = 0LL;
			//   memset(&v89, 0, sizeof(v89));
			//   v84 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2948, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2948, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v83, v82);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1060(
			//       Patch,
			//       (Object *)v10,
			//       input,
			//       output,
			//       v7,
			//       (Object *)hgCamera,
			//       (Object *)settingParameters,
			//       0LL);
			//   }
			//   else if ( v10.fields.m_isRendering )
			//   {
			//     v10.fields.m_sectorTexture = input.sectorTexture;
			//     v10.fields.m_interactionTexture = input.interactionTexture;
			//     if ( !settingParameters )
			//       sub_180B536AC(v12, v11);
			//     v10.fields.m_waterVRRx = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                 (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterVRRx_k__BackingField,
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     v10.fields.m_waterVRRy = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                 (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterVRRy_k__BackingField,
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sceneColor = (Color)input.sceneColor;
			//     *(TextureHandle *)&v90.m_RenderPass = input.sceneDepth;
			//     sceneMV = input.sceneMV;
			//     lowResSceneDepth = input.lowResSceneDepth;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v15 = (MonitorData *)hgCamera;
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&lowResSceneDepth, 0LL) )
			//     {
			//       v18 = input.lowResSceneDepth;
			//     }
			//     else
			//     {
			//       if ( !hgCamera )
			//         sub_180B536AC(v14, v13);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v92,
			//         hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2,
			//         (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2,
			//         0LL);
			//       v92.colorFormat = 49;
			//       v97 = v92;
			//       if ( !v7 )
			//         sub_180B536AC(v17, v16);
			//       v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v85, (HGRenderGraph *)v7, &v97, 0LL);
			//     }
			//     v10.fields.m_lowSceneDepthTexture = v18;
			//     if ( !hgCamera )
			//       sub_180B536AC(v14, v13);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//       &v92,
			//       hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2,
			//       (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2,
			//       0LL);
			//     if ( !v7 )
			//       sub_180B536AC(v20, v19);
			//     v92.colorFormat = _mm_cvtsi128_si32(*(__m128i *)&HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
			//                                                        &v100,
			//                                                        (HGRenderGraph *)v7,
			//                                                        (TextureHandle *)&sceneColor,
			//                                                        0LL).colorFormat);
			//     v98 = v92;
			//     v10.fields.m_reflectLightingTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               &v85,
			//                                               (HGRenderGraph *)v7,
			//                                               &v98,
			//                                               0LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//       &v92,
			//       hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2,
			//       (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2,
			//       0LL);
			//     v92.colorFormat = 5;
			//     v99 = v92;
			//     v10.fields.m_reflectFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               &v85,
			//                                               (HGRenderGraph *)v7,
			//                                               &v99,
			//                                               0LL);
			//     v96 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
			//              &v100,
			//              (HGRenderGraph *)v7,
			//              (TextureHandle *)&v90,
			//              0LL);
			//     v96.width = hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2;
			//     v96.height = (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2;
			//     v10.fields.m_prepassDepthTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                            &v85,
			//                                            (HGRenderGraph *)v7,
			//                                            &v96,
			//                                            0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&lowResSceneDepth, 0LL) )
			//     {
			//       v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x26u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       v91 = *(HGRenderGraphBuilder *)sub_18083118C(
			//                                        (unsigned int)&lowResSceneDepth,
			//                                        (_DWORD)v7,
			//                                        v22,
			//                                        (unsigned int)&v86,
			//                                        (__int64)v21);
			//       lowResSceneDepth.handle = 0LL;
			//       lowResSceneDepth.fallBackResource = (ResourceHandle)&v91;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v91, 0, 0LL);
			//         v24 = v86;
			//         if ( !v86 )
			//           sub_1802DC2C8(v23, 0LL);
			//         *(_QWORD *)(v86 + 32) = v10.fields.m_waterRenderingMaterial;
			//         v25 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v26 = ((unsigned __int64)(v24 + 32) >> 12) & 0x1FFFFF;
			//           v27 = v26 >> 6;
			//           v28 = v26 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v27 + 36190]);
			//           do
			//             v29 = qword_18D6405E0[v27 + 36190];
			//           while ( v29 != _InterlockedCompareExchange64(&qword_18D6405E0[v27 + 36190], v29 | (1LL << v28), v29) );
			//           v25 = dword_18D8E43F8;
			//         }
			//         v30 = v86;
			//         m_mpb = v10.fields.m_mpb;
			//         if ( !v86 )
			//           sub_1802DC2C8(m_mpb, 0LL);
			//         *(_QWORD *)(v86 + 40) = m_mpb;
			//         if ( v25 )
			//         {
			//           v32 = ((unsigned __int64)(v30 + 40) >> 12) & 0x1FFFFF;
			//           v33 = v32 >> 6;
			//           v34 = v32 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v33 + 36190]);
			//           do
			//             v35 = qword_18D6405E0[v33 + 36190];
			//           while ( v35 != _InterlockedCompareExchange64(&qword_18D6405E0[v33 + 36190], v35 | (1LL << v34), v35) );
			//         }
			//         v36 = v86;
			//         v39 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  &v85,
			//                  &v91,
			//                  (TextureHandle *)&v90,
			//                  0LL);
			//         if ( !v36 )
			//           sub_1802DC2C8(v38, v37);
			//         *(TextureHandle *)(v36 + 88) = v39;
			//         *(_OWORD *)&v90.m_RenderPass = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v85,
			//           &v91,
			//           &v10.fields.m_lowSceneDepthTexture,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v90,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v91,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass.static_fields.s_depthDownsampleRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v94 )
			//       {
			//         lowResSceneDepth.handle = (ResourceHandle)v94.ex;
			//         sub_180222690(&lowResSceneDepth);
			//         v15 = (MonitorData *)hgCamera;
			//         v7 = (Object *)renderGraph;
			//         v10 = this;
			//         goto LABEL_27;
			//       }
			//       sub_180222690(&lowResSceneDepth);
			//     }
			// LABEL_27:
			//     v40 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x36u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v7 )
			//       sub_1802DC2C8(v42, v41);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v90,
			//       (HGRenderGraph *)v7,
			//       (String *)"Water Prepass",
			//       &v84,
			//       v40,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     v89 = v90;
			//     lowResSceneDepth.handle = 0LL;
			//     lowResSceneDepth.fallBackResource = (ResourceHandle)&v89;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v89, 0, 0LL);
			//       m_cullHandle = v10.fields.m_cullHandle;
			//       if ( !v84 )
			//         sub_1802DC2C8(m_cullHandle, v43);
			//       HIDWORD(v84[1].klass) = m_cullHandle;
			//       v45 = v84;
			//       if ( !v84 )
			//         sub_1802DC2C8(m_cullHandle, 0LL);
			//       v84[1].monitor = v15;
			//       v46 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v47 = ((unsigned __int64)&v45[1].monitor >> 12) & 0x1FFFFF;
			//         v48 = v47 >> 6;
			//         v49 = v47 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v48 + 36190]);
			//         do
			//           v50 = qword_18D6405E0[v48 + 36190];
			//         while ( v50 != _InterlockedCompareExchange64(&qword_18D6405E0[v48 + 36190], v50 | (1LL << v49), v50) );
			//         v46 = dword_18D8E43F8;
			//       }
			//       v51 = v84;
			//       m_waterRenderingMaterial = (Object__Class *)v10.fields.m_waterRenderingMaterial;
			//       if ( !v84 )
			//         sub_1802DC2C8(m_waterRenderingMaterial, 0LL);
			//       v84[2].klass = m_waterRenderingMaterial;
			//       if ( v46 )
			//       {
			//         v53 = ((unsigned __int64)&v51[2] >> 12) & 0x1FFFFF;
			//         v54 = v53 >> 6;
			//         v55 = v53 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v54 + 36190]);
			//         do
			//           v56 = qword_18D6405E0[v54 + 36190];
			//         while ( v56 != _InterlockedCompareExchange64(&qword_18D6405E0[v54 + 36190], v56 | (1LL << v55), v56) );
			//         v46 = dword_18D8E43F8;
			//       }
			//       v57 = v84;
			//       v58 = (MonitorData *)v10.fields.m_mpb;
			//       if ( !v84 )
			//         sub_1802DC2C8(v58, 0LL);
			//       v84[2].monitor = v58;
			//       if ( v46 )
			//       {
			//         v59 = ((unsigned __int64)&v57[2].monitor >> 12) & 0x1FFFFF;
			//         v60 = v59 >> 6;
			//         v57 = (Object *)(v59 & 0x3F);
			//         _m_prefetchw(&qword_18D6405E0[v60 + 36190]);
			//         do
			//         {
			//           v58 = (MonitorData *)(qword_18D6405E0[v60 + 36190] | (1LL << (char)v57));
			//           v61 = qword_18D6405E0[v60 + 36190];
			//         }
			//         while ( v61 != _InterlockedCompareExchange64(&qword_18D6405E0[v60 + 36190], (signed __int64)v58, v61) );
			//       }
			//       ptr = (Object__Class *)v10.fields.m_cbHandle.ptr;
			//       v63 = v84;
			//       if ( !v84 )
			//         sub_1802DC2C8(v58, v57);
			//       v84[3] = *(Object *)&v10.fields.m_cbHandle.bufferId;
			//       v63[4].klass = ptr;
			//       v64 = v84;
			//       v67 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v90,
			//                &v89,
			//                (TextureHandle *)&sceneColor,
			//                0LL);
			//       if ( !v64 )
			//         sub_1802DC2C8(v66, v65);
			//       *(TextureHandle *)&v64[4].monitor = v67;
			//       v68 = v84;
			//       v71 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v90,
			//                &v89,
			//                &sceneMV,
			//                0LL);
			//       if ( !v68 )
			//         sub_1802DC2C8(v70, v69);
			//       *(TextureHandle *)&v68[6].monitor = v71;
			//       v72 = v84;
			//       v75 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                &sceneMV,
			//                &v89,
			//                &v10.fields.m_lowSceneDepthTexture,
			//                0LL);
			//       if ( !v72 )
			//         sub_1802DC2C8(v74, v73);
			//       *(TextureHandle *)&v72[7].monitor = v75;
			//       v76 = v84;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v10.fields.m_previousReflectLightingTexture, 0LL) )
			//         m_previousReflectLightingTexture = (Color)v10.fields.m_previousReflectLightingTexture;
			//       else
			//         m_previousReflectLightingTexture = sceneColor;
			//       sceneMV = (TextureHandle)m_previousReflectLightingTexture;
			//       v80 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v90,
			//                &v89,
			//                &sceneMV,
			//                0LL);
			//       if ( !v76 )
			//         sub_1802DC2C8(v79, v78);
			//       *(TextureHandle *)&v76[8].monitor = v80;
			//       sceneMV = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v90,
			//         &v89,
			//         &v10.fields.m_reflectLightingTexture,
			//         0,
			//         RenderBufferLoadAction__Enum_Clear,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&sceneMV,
			//         0,
			//         0LL);
			//       sceneMV = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v90,
			//         &v89,
			//         &v10.fields.m_reflectFadenessTexture,
			//         1,
			//         RenderBufferLoadAction__Enum_Clear,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&sceneMV,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         &sceneMV,
			//         &v89,
			//         &v10.fields.m_prepassDepthTexture,
			//         DepthAccess__Enum_Write,
			//         RenderBufferLoadAction__Enum_Clear,
			//         RenderBufferStoreAction__Enum_Store,
			//         1.0,
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v89,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass.static_fields.s_waterReflectiLightingRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v95 )
			//     {
			//       lowResSceneDepth.handle = (ResourceHandle)v95.ex;
			//     }
			//     sub_180222690(&lowResSceneDepth);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderFallback(
			//       v10,
			//       input,
			//       output,
			//       (HGRenderGraph *)v7,
			//       hgCamera,
			//       0LL);
			//   }
			// }
			// 
		}

		public void PrepareInTransparentPass(HGRenderGraphBuilder builder)
		{
			// // Void PrepareInTransparentPass(HGRenderGraphBuilder)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PrepareInTransparentPass(
			//         WaterOnePassDeferredRenderingPass *this,
			//         HGRenderGraphBuilder *builder,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int128 v8; // xmm1
			//   HGRenderGraphBuilder v9; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2619, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2619, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&v9.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v9.m_RenderGraph = v8;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_957(Patch, (Object *)this, &v9, 0LL);
			//   }
			//   else if ( this.fields.m_isRendering )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//       (TextureHandle *)&v9,
			//       builder,
			//       &this.fields.m_sectorTexture,
			//       0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//       (TextureHandle *)&v9,
			//       builder,
			//       &this.fields.m_interactionTexture,
			//       0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//       (TextureHandle *)&v9,
			//       builder,
			//       &this.fields.m_prepassDepthTexture,
			//       0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//       (TextureHandle *)&v9,
			//       builder,
			//       &this.fields.m_reflectLightingTexture,
			//       0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//       (TextureHandle *)&v9,
			//       builder,
			//       &this.fields.m_reflectFadenessTexture,
			//       0LL);
			//   }
			// }
			// 
		}

		public void RenderLighting(HGRenderGraphContext ctx, HGCamera hgCamera)
		{
			// // Void RenderLighting(HGRenderGraphContext, HGCamera)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderLighting(
			//         WaterOnePassDeferredRenderingPass *this,
			//         HGRenderGraphContext *ctx,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   CommandBuffer *cmd; // rcx
			//   Material *m_waterRenderingMaterial; // rsi
			//   Material *v10; // rsi
			//   TextureHandle m_sectorTexture; // xmm6
			//   int32_t WaterLocalFlowmapTexture; // r14d
			//   Texture *v13; // rax
			//   Material *v14; // rsi
			//   HGShaderIDs__StaticFields *v15; // rdx
			//   int32_t WaterRippleTexture; // r14d
			//   Texture *v17; // rax
			//   Material *v18; // rsi
			//   int32_t WaterGlobalSmallWaveNormalTexture; // r14d
			//   Texture2D *normalTexture; // rax
			//   Material *v21; // rsi
			//   int32_t WaterGlobalLargeWaveNormalTexture; // r14d
			//   Texture2D *v23; // rax
			//   Shader *shader; // rax
			//   Material *v25; // rsi
			//   HGManagerContext *currentManagerContext; // rax
			//   bool ShouldRenderRippleState; // al
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int128 v29; // xmm6
			//   Shader *v30; // rax
			//   bool v31; // r8
			//   CommandBuffer *v32; // rsi
			//   TextureHandle m_prepassDepthTexture; // xmm6
			//   int32_t WaterPrepassDepthGlobalTexture; // r14d
			//   RenderTargetIdentifier *v35; // rax
			//   __int64 v36; // rcx
			//   __int128 v37; // xmm1
			//   Material *v38; // rsi
			//   HGShaderIDs__StaticFields *v39; // rdx
			//   int32_t WaterReflectLightingTexture; // r14d
			//   Texture *v41; // rax
			//   Material *v42; // rsi
			//   HGShaderIDs__StaticFields *v43; // rdx
			//   int32_t WaterReflectFadenessTexture; // r14d
			//   Texture *v45; // rax
			//   void *m_Ptr; // r14
			//   CommandBuffer *v47; // rsi
			//   uint32_t waterDecalCullHandle; // edi
			//   MaterialPropertyBlock *m_mpb; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _QWORD v51[5]; // [rsp+60h] [rbp-A8h] BYREF
			//   LocalKeyword keyword; // [rsp+88h] [rbp-80h] BYREF
			//   LocalKeyword v53; // [rsp+A0h] [rbp-68h] BYREF
			//   RenderTargetIdentifier v54; // [rsp+B8h] [rbp-50h] BYREF
			//   RenderTargetIdentifier v55; // [rsp+E8h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919636 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18CDB1508);
			//     sub_18003C530(&off_18D50A5C8);
			//     byte_18D919636 = 1;
			//   }
			//   memset(&keyword, 0, sizeof(keyword));
			//   memset(&v53, 0, sizeof(v53));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2629, 0LL) )
			//   {
			//     if ( !this.fields.m_isRendering )
			//       return;
			//     if ( ctx )
			//     {
			//       cmd = ctx.fields.cmd;
			//       if ( cmd )
			//       {
			//         UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate(
			//           cmd,
			//           this.fields.m_waterVRRx,
			//           this.fields.m_waterVRRy,
			//           0LL);
			//         m_waterRenderingMaterial = this.fields.m_waterRenderingMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( m_waterRenderingMaterial )
			//         {
			//           UnityEngine::Material::SetConstantBufferImpl0(
			//             m_waterRenderingMaterial,
			//             static_fields._WaterData,
			//             this.fields.m_cbHandle.bufferId,
			//             this.fields.m_cbHandle.offset,
			//             this.fields.m_cbHandle.size,
			//             0LL);
			//           v10 = this.fields.m_waterRenderingMaterial;
			//           m_sectorTexture = this.fields.m_sectorTexture;
			//           WaterLocalFlowmapTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._WaterLocalFlowmapTexture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           *(TextureHandle *)&v51[1] = m_sectorTexture;
			//           v13 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit((TextureHandle *)&v51[1], 0LL);
			//           if ( v10 )
			//           {
			//             UnityEngine::Material::SetTextureImpl(v10, WaterLocalFlowmapTexture, v13, 0LL);
			//             v14 = this.fields.m_waterRenderingMaterial;
			//             v15 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             *(TextureHandle *)&v51[1] = this.fields.m_interactionTexture;
			//             WaterRippleTexture = v15._WaterRippleTexture;
			//             v17 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit((TextureHandle *)&v51[1], 0LL);
			//             if ( v14 )
			//             {
			//               UnityEngine::Material::SetTextureImpl(v14, WaterRippleTexture, v17, 0LL);
			//               cmd = (CommandBuffer *)this.fields.m_waterRenderingMaterial;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               if ( cmd )
			//               {
			//                 UnityEngine::Material::SetTextureImpl(
			//                   (Material *)cmd,
			//                   static_fields._WaterGlobalNormalTextureArray,
			//                   (Texture *)this.fields.m_globalNormalTextureArray,
			//                   0LL);
			//                 cmd = (CommandBuffer *)this.fields.m_waterRenderingMaterial;
			//                 static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                 if ( cmd )
			//                 {
			//                   UnityEngine::Material::SetTextureImpl(
			//                     (Material *)cmd,
			//                     static_fields._WaterGlobalFlowmapTexture,
			//                     (Texture *)this.fields.m_globalFlowmapTexture,
			//                     0LL);
			//                   cmd = (CommandBuffer *)this.fields.m_waterRenderingMaterial;
			//                   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                   if ( cmd )
			//                   {
			//                     UnityEngine::Material::SetTextureImpl(
			//                       (Material *)cmd,
			//                       static_fields._WaterGlobalCausticTexture,
			//                       (Texture *)this.fields.m_globalCausticTexture,
			//                       0LL);
			//                     v18 = this.fields.m_waterRenderingMaterial;
			//                     WaterGlobalSmallWaveNormalTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._WaterGlobalSmallWaveNormalTexture;
			//                     normalTexture = UnityEngine::Texture2D::get_normalTexture(0LL);
			//                     if ( v18 )
			//                     {
			//                       UnityEngine::Material::SetTextureImpl(
			//                         v18,
			//                         WaterGlobalSmallWaveNormalTexture,
			//                         (Texture *)normalTexture,
			//                         0LL);
			//                       v21 = this.fields.m_waterRenderingMaterial;
			//                       WaterGlobalLargeWaveNormalTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._WaterGlobalLargeWaveNormalTexture;
			//                       v23 = UnityEngine::Texture2D::get_normalTexture(0LL);
			//                       if ( v21 )
			//                       {
			//                         UnityEngine::Material::SetTextureImpl(
			//                           v21,
			//                           WaterGlobalLargeWaveNormalTexture,
			//                           (Texture *)v23,
			//                           0LL);
			//                         cmd = (CommandBuffer *)this.fields.m_waterRenderingMaterial;
			//                         if ( cmd )
			//                         {
			//                           shader = UnityEngine::Material::get_shader((Material *)cmd, 0LL);
			//                           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//                             &keyword,
			//                             shader,
			//                             (String *)"ENABLE_WATER_RIPPLE",
			//                             0LL);
			//                           v25 = this.fields.m_waterRenderingMaterial;
			//                           currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//                           if ( currentManagerContext )
			//                           {
			//                             cmd = (CommandBuffer *)currentManagerContext.fields._waterManager_k__BackingField;
			//                             if ( cmd )
			//                             {
			//                               ShouldRenderRippleState = HG::Rendering::Runtime::HGWaterManager::GetShouldRenderRippleState(
			//                                                           (HGWaterManager *)cmd,
			//                                                           0LL);
			//                               if ( v25 )
			//                               {
			//                                 UnityEngine::Material::SetKeyword(v25, &keyword, ShouldRenderRippleState, 0LL);
			//                                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//                                 InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(
			//                                                       hgCamera,
			//                                                       0LL);
			//                                 if ( InterpolatedPhase )
			//                                 {
			//                                   cmd = (CommandBuffer *)this.fields.m_waterRenderingMaterial;
			//                                   v51[3] = *(_QWORD *)&InterpolatedPhase.fields.inkSimulationConfig.m_active;
			//                                   v29 = *(_OWORD *)&InterpolatedPhase.fields.inkSimulationConfig.influence;
			//                                   if ( cmd )
			//                                   {
			//                                     v30 = UnityEngine::Material::get_shader((Material *)cmd, 0LL);
			//                                     UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//                                       &v53,
			//                                       v30,
			//                                       (String *)"ENABLE_INK_RENDER",
			//                                       0LL);
			//                                     cmd = (CommandBuffer *)this.fields.m_waterRenderingMaterial;
			//                                     v31 = *(float *)&v29 > 0.0 && BYTE4(v29) == 0;
			//                                     if ( cmd )
			//                                     {
			//                                       UnityEngine::Material::SetKeyword((Material *)cmd, &v53, v31, 0LL);
			//                                       v32 = ctx.fields.cmd;
			//                                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                       m_prepassDepthTexture = this.fields.m_prepassDepthTexture;
			//                                       WaterPrepassDepthGlobalTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._WaterPrepassDepthGlobalTexture;
			//                                       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//                                       *(TextureHandle *)&v51[1] = m_prepassDepthTexture;
			//                                       v35 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                                               &v55,
			//                                               (TextureHandle *)&v51[1],
			//                                               0LL);
			//                                       if ( !v32 )
			//                                         goto LABEL_33;
			//                                       v37 = *(_OWORD *)&v35.m_BufferPointer;
			//                                       *(_OWORD *)&v54.m_Type = *(_OWORD *)&v35.m_Type;
			//                                       *(_QWORD *)&v54.m_DepthSlice = *(_QWORD *)&v35.m_DepthSlice;
			//                                       *(_OWORD *)&v54.m_BufferPointer = v37;
			//                                       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//                                         v32,
			//                                         WaterPrepassDepthGlobalTexture,
			//                                         &v54,
			//                                         0LL);
			//                                       v38 = this.fields.m_waterRenderingMaterial;
			//                                       v39 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                       *(TextureHandle *)&v51[1] = this.fields.m_reflectLightingTexture;
			//                                       WaterReflectLightingTexture = v39._WaterReflectLightingTexture;
			//                                       v41 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                                               (TextureHandle *)&v51[1],
			//                                               0LL);
			//                                       if ( !v38 )
			//                                         goto LABEL_33;
			//                                       UnityEngine::Material::SetTextureImpl(v38, WaterReflectLightingTexture, v41, 0LL);
			//                                       v42 = this.fields.m_waterRenderingMaterial;
			//                                       v43 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                                       *(TextureHandle *)&v51[1] = this.fields.m_reflectFadenessTexture;
			//                                       WaterReflectFadenessTexture = v43._WaterReflectFadenessTexture;
			//                                       v45 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                                               (TextureHandle *)&v51[1],
			//                                               0LL);
			//                                       if ( !v42
			//                                         || (UnityEngine::Material::SetTextureImpl(
			//                                               v42,
			//                                               WaterReflectFadenessTexture,
			//                                               v45,
			//                                               0LL),
			//                                             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext),
			//                                             UnityEngine::HyperGryph::HGWaterRender::DrawWaterProxy(
			//                                               ctx.fields.renderContext.m_Ptr,
			//                                               ctx.fields.cmd,
			//                                               this.fields.m_cullHandle,
			//                                               this.fields.m_waterRenderingMaterial,
			//                                               this.fields.m_mpb,
			//                                               4,
			//                                               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._UnityInstancing_ECSPerDraw,
			//                                               1,
			//                                               3u,
			//                                               -1,
			//                                               0LL),
			//                                             !hgCamera) )
			//                                       {
			// LABEL_33:
			//                                         sub_180B536AC(v36, static_fields);
			//                                       }
			//                                       if ( hgCamera.fields.waterDecalVisibleCount )
			//                                       {
			//                                         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                                         m_Ptr = ctx.fields.renderContext.m_Ptr;
			//                                         v47 = ctx.fields.cmd;
			//                                         waterDecalCullHandle = hgCamera.fields.waterDecalCullHandle;
			//                                         m_mpb = this.fields.m_mpb;
			//                                         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                         UnityEngine::HyperGryph::HGWaterRender::DrawWaterDecals(
			//                                           m_Ptr,
			//                                           v47,
			//                                           waterDecalCullHandle,
			//                                           m_mpb,
			//                                           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._WaterDecal,
			//                                           0,
			//                                           0,
			//                                           3u,
			//                                           -1,
			//                                           0LL);
			//                                       }
			//                                       cmd = ctx.fields.cmd;
			//                                       if ( cmd )
			//                                       {
			//                                         UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate(
			//                                           cmd,
			//                                           1u,
			//                                           1u,
			//                                           0LL);
			//                                         return;
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
			// LABEL_35:
			//     sub_180B536AC(cmd, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2629, 0LL);
			//   if ( !Patch )
			//     goto LABEL_35;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)ctx,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		internal void RenderFallback(ref WaterOnePassDeferredRenderingPass.PassInput input, ref WaterOnePassDeferredRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void RenderFallback(WaterOnePassDeferredRenderingPass+PassInput ByRef, WaterOnePassDeferredRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderFallback(
			//         WaterOnePassDeferredRenderingPass *this,
			//         WaterOnePassDeferredRenderingPass_PassInput *input,
			//         WaterOnePassDeferredRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // [rsp+40h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v18; // [rsp+48h] [rbp-50h] BYREF
			//   _QWORD v19[4]; // [rsp+50h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v20; // [rsp+70h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919637 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//     sub_18003C530(&off_18CDB14F8);
			//     byte_18D919637 = 1;
			//   }
			//   memset(&v20, 0, sizeof(v20));
			//   v17 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2949, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2949, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1059(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x36u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     v20 = *(HGRenderGraphBuilder *)sub_18083118C(
			//                                      (unsigned int)v19,
			//                                      (_DWORD)renderGraph,
			//                                      v13,
			//                                      (unsigned int)&v17,
			//                                      (__int64)v10);
			//     v19[0] = 0LL;
			//     v19[1] = &v20;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v20, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v20,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass.static_fields.s_RenderFallbackFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v18 )
			//     {
			//       v19[0] = v18.ex;
			//     }
			//     sub_180222690(v19);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         WaterOnePassDeferredRenderingPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2950, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2950, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         WaterOnePassDeferredRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2951, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2951, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         WaterOnePassDeferredRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   TextureHandle *v6; // rax
			//   HGRenderGraph *renderGraph; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919638 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D50A6C8);
			//     byte_18D919638 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2952, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_reflectLightingTexture = *(TextureHandle *)sub_182E7CCD0(&v9);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_reflectLightingTexture, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v6 = (TextureHandle *)sub_182E7CCD0(&v9);
			// LABEL_10:
			//       this.fields.m_previousReflectLightingTexture = *v6;
			//       return;
			//     }
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       v6 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//              &v9,
			//              renderGraph,
			//              &this.fields.m_reflectLightingTexture,
			//              1,
			//              (String *)"WaterReflectLighting",
			//              0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v5, renderGraph);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2952, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         WaterOnePassDeferredRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2953, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2953, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		private bool m_isRendering;

		private uint m_cullHandle;

		private int m_waterVRRx;

		private int m_waterVRRy;

		private CBHandle m_cbHandle;

		private TextureHandle m_sectorTexture;

		private TextureHandle m_interactionTexture;

		private TextureHandle m_lowSceneDepthTexture;

		private TextureHandle m_previousReflectLightingTexture;

		private TextureHandle m_reflectLightingTexture;

		private TextureHandle m_reflectFadenessTexture;

		private TextureHandle m_gBufferATexture;

		private TextureHandle m_gBufferMVTexture;

		private TextureHandle m_prepassDepthTexture;

		private Texture2D m_globalFlowmapTexture;

		private Texture2D m_globalCausticTexture;

		private Texture2DArray m_globalNormalTextureArray;

		private MaterialPropertyBlock m_mpb;

		private Material m_waterRenderingMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<WaterOnePassDeferredRenderingPass.PassData> s_depthDownsampleRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<WaterOnePassDeferredRenderingPass.PassData> s_waterReflectiLightingRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<WaterOnePassDeferredRenderingPass.PassData> s_RenderFallbackFunc;

		public enum WaterShaderForwardPassName
		{
			GBufferBlit,
			GBuffer,
			DepthBlit,
			Reflect,
			Lighting,
			FullScreenDebug
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 152)]
		internal struct PassInput
		{
			internal TextureHandle sectorTexture;

			internal TextureHandle interactionTexture;

			internal TextureHandle sceneColor;

			internal TextureHandle sceneColorCopied;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle lowResSceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle gBufferATexture;

			internal ScriptableRenderContext srpContext;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		internal struct PassOutput
		{
			internal TextureHandle gbufferBWithWaterTexture;

			internal TextureHandle depthWithWaterTexture;
		}

		private class PassData
		{
			public PassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public bool isRendering;

			public uint cullHandle;

			public HGCamera hgCamera;

			public Material material;

			public MaterialPropertyBlock proxyMPB;

			public CBHandle cbHandle;

			public TextureHandle currentSceneColorTexture;

			public TextureHandle currentSceneDepthTexture;

			public TextureHandle currentMotionVectorTexture;

			public TextureHandle lowSceneDepthTexture;

			public TextureHandle previousReflectLightingTexture;

			public TextureHandle gBufferATexture;

			public TextureHandle gBufferMVTexture;
		}
	}
}
