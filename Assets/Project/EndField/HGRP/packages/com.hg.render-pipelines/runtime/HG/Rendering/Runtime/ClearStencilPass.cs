using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class ClearStencilPass
	{
		internal ClearStencilPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPipelineRuntimeResources defaultResources)
		{
			// // ClearStencilPass(HGRenderPipelineMaterialCollector, HGRenderPipelineRuntimeResources)
			// void HG::Rendering::Runtime::ClearStencilPass::ClearStencilPass(
			//         ClearStencilPass *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPipelineRuntimeResources *defaultResources,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   OneofDescriptorProto *v6; // rdx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   String__Array *v9; // [rsp+50h] [rbp+28h]
			//   String *v10; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v11; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !defaultResources || (shaders = defaultResources.fields.shaders) == 0LL || !materialCollector )
			//     sub_180B536AC(this, materialCollector);
			//   this.fields.m_ClearStencilBufferMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                 materialCollector,
			//                                                 shaders.fields.clearStencilBufferPS,
			//                                                 0,
			//                                                 0LL);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v6, v7, v8, v9, v10, v11);
			// }
			// 
		}

		internal void ClearStencilBuffer(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthBuffer)
		{
			// // Void ClearStencilBuffer(HGRenderGraph, HGCamera, TextureHandle)
			// void HG::Rendering::Runtime::ClearStencilPass::ClearStencilBuffer(
			//         ClearStencilPass *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         TextureHandle *depthBuffer,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2515, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2515, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = *depthBuffer;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_902(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       &v12,
			//       0LL);
			//   }
			// }
			// 
		}

		private Material m_ClearStencilBufferMaterial;

		private class ClearStencilPassData
		{
			public ClearStencilPassData()
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

			public Material clearStencilMaterial;

			public TextureHandle depthBuffer;
		}
	}
}
