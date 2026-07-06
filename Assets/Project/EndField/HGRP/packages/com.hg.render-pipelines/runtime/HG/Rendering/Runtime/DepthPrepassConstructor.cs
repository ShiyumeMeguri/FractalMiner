using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class DepthPrepassConstructor : IPassConstructor
	{
		public DepthPrepassConstructor()
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

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DepthPrepassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2565, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2565, 0LL);
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
			// void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DepthPrepassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2566, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2566, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref DepthPrepassConstructor.PassInput input, ref DepthPrepassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(DepthPrepassConstructor+PassInput ByRef, DepthPrepassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::DepthPrepassConstructor::ConstructPass(
			//         DepthPrepassConstructor *this,
			//         DepthPrepassConstructor_PassInput *input,
			//         DepthPrepassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *preZ; // rax
			//   MonitorData *v16; // xmm1_8
			//   Object *v17; // rax
			//   HGRenderPipeline *hgrp; // rax
			//   ShaderTagId__Array *depthOnlyPassNames; // r15
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // ebx
			//   RendererListDesc *v23; // rax
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle *v25; // rbx
			//   RendererListHandle v26; // rax
			//   RendererListHandle v27; // rdx
			//   RendererListHandle v28; // rcx
			//   Object *v29; // rbx
			//   Object_1 *v30; // rcx
			//   int32_t InstanceID; // eax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   Object *v34; // rbx
			//   Camera *v35; // rcx
			//   int32_t cullingMask; // eax
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   __int64 deferredOpaquePreZGPUDrivenList; // rcx
			//   __int64 deferredOpaqueGPUDrivenList; // rcx
			//   __int64 deferredOpaquePreZECSList; // rcx
			//   __int64 forwardOpaquePreZECSList; // rcx
			//   __int64 deferredGrassPreZECSList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   Object *v47; // [rsp+70h] [rbp-278h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderQueueRange_ inputa; // [rsp+80h] [rbp-268h] BYREF
			//   _QWORD v49[2]; // [rsp+90h] [rbp-258h] BYREF
			//   HGRenderGraphBuilder v50; // [rsp+A0h] [rbp-248h] BYREF
			//   HGRenderGraphBuilder v51; // [rsp+C0h] [rbp-228h] BYREF
			//   Il2CppExceptionWrapper *v52; // [rsp+E0h] [rbp-208h] BYREF
			//   RendererListDesc desc; // [rsp+F0h] [rbp-1F8h] BYREF
			//   RendererListDesc v54; // [rsp+1D0h] [rbp-118h] BYREF
			// 
			//   if ( !byte_18D91952E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FA288);
			//     byte_18D91952E = 1;
			//   }
			//   v47 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2567, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2567, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v46, v45);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_941(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x14u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v50,
			//       renderGraph,
			//       (String *)"DepthPrepass",
			//       &v47,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_PreDepth,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
			//     v51 = v50;
			//     v49[0] = 0LL;
			//     v49[1] = &v51;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v50,
			//         &v51,
			//         &input.sceneDepth,
			//         DepthAccess__Enum_Write,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.gBufferDepth, 0LL) )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v50,
			//           &v51,
			//           &input.gBufferDepth,
			//           0,
			//           0,
			//           0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       preZ = static_fields.preZ;
			//       if ( !preZ )
			//         sub_1802DC2C8(static_fields, v13);
			//       LOBYTE(static_fields) = preZ.fields.m_defaultValue;
			//       if ( !camera )
			//         sub_1802DC2C8(static_fields, v13);
			//       v16 = *(MonitorData **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       v17 = v47;
			//       if ( !v47 )
			//         sub_1802DC2C8(static_fields, v13);
			//       *(BitArray128 *)((char *)v47 + 24) = camera.fields._frameSettings_k__BackingField.bitDatas;
			//       v17[2].monitor = v16;
			//       hgrp = input.hgrp;
			//       if ( !hgrp )
			//         sub_1802DC2C8(static_fields, v13);
			//       depthOnlyPassNames = hgrp.fields.depthOnlyPassNames;
			//       if ( (_BYTE)static_fields )
			//       {
			//         screenCullingRatio = input.screenCullingRatio;
			//         screenCullingRatioDistance = input.screenCullingRatioDistance;
			//         screenCullingLayerMask = input.screenCullingLayerMask;
			//         *(_QWORD *)&inputa.hasValue = 0LL;
			//         sub_1802F01E0(&desc, 0LL, 112LL);
			//         inputa.value.m_UpperBound = 0;
			//         *(CullingResults *)&v50.m_RenderPass = input.cullingResults;
			//         v23 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                 &v54,
			//                 (CullingResults *)&v50,
			//                 camera.fields.camera,
			//                 depthOnlyPassNames,
			//                 screenCullingRatio,
			//                 screenCullingRatioDistance,
			//                 screenCullingLayerMask,
			//                 PerObjectData__Enum_None,
			//                 &inputa,
			//                 (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
			//                 0LL,
			//                 0,
			//                 0LL);
			//         *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v23.sortingCriteria;
			//         desc.stateBlock = v23.stateBlock;
			//         v23 = (RendererListDesc *)((char *)v23 + 128);
			//         *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v23.sortingCriteria;
			//         *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v23.stateBlock.hasValue;
			//         *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v23.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v23.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v23.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v23.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//       }
			//       else
			//       {
			//         InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//       }
			//       *(RendererListHandle *)&inputa.hasValue = InvalidHandle;
			//       v25 = (RendererListHandle *)v47;
			//       v26 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//               &v51,
			//               (RendererListHandle *)&inputa,
			//               0LL);
			//       if ( !v25 )
			//         sub_1802DC2C8(v28, v27);
			//       v25[6] = v26;
			//       v29 = v47;
			//       v30 = (Object_1 *)camera.fields.camera;
			//       if ( !v30 )
			//         sub_1802DC2C8(0LL, v27);
			//       InstanceID = UnityEngine::Object::GetInstanceID(v30, 0LL);
			//       if ( !v29 )
			//         sub_1802DC2C8(v33, v32);
			//       LODWORD(v29[1].klass) = InstanceID;
			//       v34 = v47;
			//       v35 = camera.fields.camera;
			//       if ( !v35 )
			//         sub_1802DC2C8(0LL, v32);
			//       cullingMask = UnityEngine::Camera::get_cullingMask(v35, 0LL);
			//       if ( !v34 )
			//         sub_1802DC2C8(v38, v37);
			//       HIDWORD(v34[1].klass) = cullingMask;
			//       deferredOpaquePreZGPUDrivenList = input.deferredOpaquePreZGPUDrivenList;
			//       if ( !v47 )
			//         sub_1802DC2C8(deferredOpaquePreZGPUDrivenList, v37);
			//       LODWORD(v47[3].monitor) = deferredOpaquePreZGPUDrivenList;
			//       deferredOpaqueGPUDrivenList = input.deferredOpaqueGPUDrivenList;
			//       if ( !v47 )
			//         sub_1802DC2C8(deferredOpaqueGPUDrivenList, v37);
			//       HIDWORD(v47[3].monitor) = deferredOpaqueGPUDrivenList;
			//       deferredOpaquePreZECSList = input.deferredOpaquePreZECSList;
			//       if ( !v47 )
			//         sub_1802DC2C8(deferredOpaquePreZECSList, v37);
			//       LODWORD(v47[4].klass) = deferredOpaquePreZECSList;
			//       forwardOpaquePreZECSList = input.forwardOpaquePreZECSList;
			//       if ( !v47 )
			//         sub_1802DC2C8(forwardOpaquePreZECSList, v37);
			//       HIDWORD(v47[4].klass) = forwardOpaquePreZECSList;
			//       deferredGrassPreZECSList = input.deferredGrassPreZECSList;
			//       if ( !v47 )
			//         sub_1802DC2C8(deferredGrassPreZECSList, v37);
			//       LODWORD(v47[4].monitor) = deferredGrassPreZECSList;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v51,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor.static_fields.s_depthPrepassRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v52 )
			//     {
			//       v49[0] = v52.ex;
			//     }
			//     sub_180222690(v49);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DepthPrepassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2568, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2568, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DepthPrepassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2569, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2569, 0LL);
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

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<DepthPrepassConstructor.DepthPrepassData> s_depthPrepassRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal TextureHandle gBufferDepth;

			internal HGRenderPipeline hgrp;

			internal CullingResults cullingResults;

			internal bool characterDepthOnlyEnable;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal uint deferredOpaquePreZGPUDrivenList;

			internal uint deferredOpaqueGPUDrivenList;

			internal uint deferredOpaquePreZECSList;

			internal uint forwardOpaquePreZECSList;

			internal uint deferredGrassPreZECSList;
		}

		internal struct PassOutput
		{
		}

		private class DepthPrepassData
		{
			public DepthPrepassData()
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

			public int cameraGuid;

			public int cameraCullingMask;

			public FrameSettings frameSettings;

			public RendererListHandle rendererList;

			internal uint deferredOpaquePreZGPUDrivenList;

			internal uint deferredOpaqueGPUDrivenList;

			internal uint deferredOpaquePreZECSList;

			internal uint forwardOpaquePreZECSList;

			internal uint deferredGrassPreZECSList;
		}
	}
}
