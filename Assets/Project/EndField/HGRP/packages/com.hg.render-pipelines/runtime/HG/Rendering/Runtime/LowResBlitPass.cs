using System;
using HG.Rendering.RenderGraphModule;

namespace HG.Rendering.Runtime
{
	internal static class LowResBlitPass
	{
		internal static void DownsampleDepth(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle lowResMinTexture, TextureHandle lowResMaxTexture, DownsampleDepthOutput outputType)
		{
			// // Void DownsampleDepth(HGRenderGraph, TextureHandle, TextureHandle, TextureHandle, DownsampleDepthOutput)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::LowResBlitPass::DownsampleDepth(
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *srcTexture,
			//         TextureHandle *lowResMinTexture,
			//         TextureHandle *lowResMaxTexture,
			//         DownsampleDepthOutput__Enum outputType,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Object *v13; // rbx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   TextureHandle v16; // xmm0
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Object *v20; // [rsp+50h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v21; // [rsp+58h] [rbp-80h] BYREF
			//   TextureHandle v22; // [rsp+60h] [rbp-78h] BYREF
			//   TextureHandle v23; // [rsp+70h] [rbp-68h] BYREF
			//   HGRenderGraphBuilder v24; // [rsp+80h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+A0h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919583 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LowResBlitPass::DownsampleDepthPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LowResBlitPass::DownsampleDepthPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D500F98);
			//     byte_18D919583 = 1;
			//   }
			//   v20 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2706, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2706, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     v23 = *lowResMaxTexture;
			//     v22 = *lowResMinTexture;
			//     *(TextureHandle *)&v24.m_RenderPass = *srcTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_989(
			//       Patch,
			//       (Object *)renderGraph,
			//       (TextureHandle *)&v24,
			//       &v22,
			//       &v23,
			//       outputType,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x26u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v24,
			//       renderGraph,
			//       (String *)"Downsample Depth Buffer",
			//       &v20,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LowResBlitPass::DownsampleDepthPassData>);
			//     v25 = v24;
			//     v22.handle = 0LL;
			//     v22.fallBackResource = (ResourceHandle)&v25;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v25, 0, 0LL);
			//       v13 = v20;
			//       v16 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v24,
			//                &v25,
			//                srcTexture,
			//                0LL);
			//       if ( !v13 )
			//         sub_1802DC2C8(v15, v14);
			//       v13[1] = (Object)v16;
			//       if ( !v20 )
			//         sub_1802DC2C8(0LL, v14);
			//       LODWORD(v20[2].klass) = outputType;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(lowResMaxTexture, 0LL) )
			//       {
			//         v23 = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v24,
			//           &v25,
			//           lowResMaxTexture,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v23,
			//           0,
			//           0LL);
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(lowResMinTexture, 0LL) )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v24,
			//           &v25,
			//           lowResMinTexture,
			//           DepthAccess__Enum_Write,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           0.0,
			//           0,
			//           0,
			//           0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v25,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LowResBlitPass.static_fields.s_downsampleDepthFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LowResBlitPass::DownsampleDepthPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v21 )
			//     {
			//       v22.handle = (ResourceHandle)v21.ex;
			//     }
			//     sub_180222690(&v22);
			//   }
			// }
			// 
		}

		internal static void UpsampleColorAndMV(HGRenderGraph renderGraph, TextureHandle lowResColorTexture, TextureHandle lowResMVTexture, TextureHandle dstColorTexture, TextureHandle dstMVTexture, TextureHandle sceneDepth, HGCamera camera)
		{
			// // Void UpsampleColorAndMV(HGRenderGraph, TextureHandle, TextureHandle, TextureHandle, TextureHandle, TextureHandle, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::LowResBlitPass::UpsampleColorAndMV(
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *lowResColorTexture,
			//         TextureHandle *lowResMVTexture,
			//         TextureHandle *dstColorTexture,
			//         TextureHandle *dstMVTexture,
			//         TextureHandle *sceneDepth,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v12; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // rcx
			//   Object *v16; // rdx
			//   unsigned int v17; // edx
			//   unsigned __int64 v18; // r8
			//   char v19; // dl
			//   signed __int64 v20; // rtt
			//   Object *v21; // rbx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   TextureHandle v24; // xmm0
			//   Object *v25; // rbx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   TextureHandle v28; // xmm0
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdi
			//   Object *v32; // [rsp+50h] [rbp-B8h] BYREF
			//   TextureHandle v33; // [rsp+60h] [rbp-A8h] BYREF
			//   TextureHandle v34; // [rsp+70h] [rbp-98h] BYREF
			//   HGRenderGraphBuilder v35; // [rsp+80h] [rbp-88h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+A0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v37; // [rsp+C0h] [rbp-48h] BYREF
			//   TextureHandle v38; // [rsp+D0h] [rbp-38h] BYREF
			//   TextureHandle v39; // [rsp+E0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919584 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LowResBlitPass::MergeLowResPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LowResBlitPass::MergeLowResPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500FF8);
			//     byte_18D919584 = 1;
			//   }
			//   v32 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2707, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2707, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v30, v29);
			//     v34 = *sceneDepth;
			//     v33 = *dstMVTexture;
			//     v38 = *dstColorTexture;
			//     v39 = *lowResMVTexture;
			//     *(TextureHandle *)&v35.m_RenderPass = *lowResColorTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_990(
			//       Patch,
			//       (Object *)renderGraph,
			//       (TextureHandle *)&v35,
			//       &v39,
			//       &v38,
			//       &v33,
			//       &v34,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v12 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x26u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v14, v13);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v35,
			//       renderGraph,
			//       (String *)"Merge LowRes Color and MV",
			//       &v32,
			//       v12,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LowResBlitPass::MergeLowResPassData>);
			//     v36 = v35;
			//     v34.handle = 0LL;
			//     v34.fallBackResource = (ResourceHandle)&v36;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v36, 0, 0LL);
			//       v16 = v32;
			//       if ( !v32 )
			//         sub_1802DC2C8(v15, 0LL);
			//       v32[1].klass = (Object__Class *)camera;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v17 = ((unsigned __int64)&v16[1] >> 12) & 0x1FFFFF;
			//         v18 = (unsigned __int64)v17 >> 6;
			//         v19 = v17 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v18]);
			//         do
			//           v20 = qword_18D6870D0[v18];
			//         while ( v20 != _InterlockedCompareExchange64(&qword_18D6870D0[v18], v20 | (1LL << v19), v20) );
			//       }
			//       v21 = v32;
			//       v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v35,
			//                &v36,
			//                lowResColorTexture,
			//                0LL);
			//       if ( !v21 )
			//         sub_1802DC2C8(v23, v22);
			//       *(TextureHandle *)&v21[1].monitor = v24;
			//       v25 = v32;
			//       v28 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v35,
			//                &v36,
			//                lowResMVTexture,
			//                0LL);
			//       if ( !v25 )
			//         sub_1802DC2C8(v27, v26);
			//       *(TextureHandle *)&v25[2].monitor = v28;
			//       v33 = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v35,
			//         &v36,
			//         dstColorTexture,
			//         0,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&v33,
			//         0,
			//         0LL);
			//       v33 = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v35,
			//         &v36,
			//         dstMVTexture,
			//         1,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&v33,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v35,
			//         &v36,
			//         sceneDepth,
			//         DepthAccess__Enum_Read,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v36,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LowResBlitPass.static_fields.s_mergeLowResFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LowResBlitPass::MergeLowResPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v37 )
			//     {
			//       v34.handle = (ResourceHandle)v37.ex;
			//     }
			//     sub_180222690(&v34);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<LowResBlitPass.DownsampleDepthPassData> s_downsampleDepthFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<LowResBlitPass.MergeLowResPassData> s_mergeLowResFunc;

		private class DownsampleDepthPassData
		{
			public DownsampleDepthPassData()
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

			public TextureHandle srcTexture;

			public DownsampleDepthOutput outputType;
		}

		private class MergeLowResPassData
		{
			public MergeLowResPassData()
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

			public HGCamera camera;

			public TextureHandle lowResColorTexture;

			public TextureHandle lowResMVTexture;
		}
	}
}
