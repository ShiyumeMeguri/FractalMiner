using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal static class CopyTexturePass
	{
		internal static void BlitTexture(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle dstTexture, [MetadataOffset(Offset = "0x01F917BE")] int copyPassIndex = 0, [MetadataOffset(Offset = "0x01F917BF")] int dstTextureShaderID = -1, [MetadataOffset(Offset = "0x01F917C0")] bool useNativeBlit = false, Rect viewport = null, [MetadataOffset(Offset = "0x01F917C1")] bool loadRT = false)
		{
			// // Void BlitTexture(HGRenderGraph, TextureHandle, TextureHandle, Int32, Int32, Boolean, Rect, Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *srcTexture,
			//         TextureHandle *dstTexture,
			//         int32_t copyPassIndex,
			//         int32_t dstTextureShaderID,
			//         bool useNativeBlit,
			//         Rect *viewport,
			//         bool loadRT,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Object *v16; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   TextureHandle v19; // xmm0
			//   Object *v20; // rbx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   TextureHandle v23; // xmm0
			//   Object *v24; // rcx
			//   Object *v25; // rbx
			//   TextureDesc *TextureDescRef; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Object *v32; // [rsp+50h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v33; // [rsp+58h] [rbp-70h] BYREF
			//   TextureHandle v34; // [rsp+60h] [rbp-68h] BYREF
			//   Rect si128; // [rsp+70h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+80h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v37; // [rsp+A0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91950C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FB310);
			//     byte_18D91950C = 1;
			//   }
			//   v32 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2524, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2524, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v30, v29);
			//     si128 = *viewport;
			//     v34 = *dstTexture;
			//     *(TextureHandle *)&v36.m_RenderPass = *srcTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_926(
			//       Patch,
			//       (Object *)renderGraph,
			//       (TextureHandle *)&v36,
			//       &v34,
			//       copyPassIndex,
			//       dstTextureShaderID,
			//       useNativeBlit,
			//       &si128,
			//       loadRT,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(srcTexture, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(dstTexture, 0LL) )
			//       {
			//         v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                 (Int32Enum__Enum)0x1Fu,
			//                 MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         if ( !renderGraph )
			//           sub_180B536AC(v15, v14);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v36,
			//           renderGraph,
			//           (String *)"Blit Texture",
			//           &v32,
			//           v13,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
			//         v37 = v36;
			//         v34.handle = 0LL;
			//         v34.fallBackResource = (ResourceHandle)&v37;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v37, 0, 0LL);
			//           v16 = v32;
			//           v19 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&v36,
			//                    &v37,
			//                    srcTexture,
			//                    0LL);
			//           if ( !v16 )
			//             sub_1802DC2C8(v18, v17);
			//           v16[1] = (Object)v19;
			//           v20 = v32;
			//           v23 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                    (TextureHandle *)&v36,
			//                    &v37,
			//                    dstTexture,
			//                    0LL);
			//           if ( !v20 )
			//             sub_1802DC2C8(v22, v21);
			//           v20[2] = (Object)v23;
			//           v24 = v32;
			//           if ( !v32 )
			//             sub_1802DC2C8(0LL, v21);
			//           HIDWORD(v32[3].klass) = dstTextureShaderID;
			//           if ( !v32 )
			//             sub_1802DC2C8(v24, v21);
			//           LOBYTE(v32[3].monitor) = useNativeBlit;
			//           if ( !v32 )
			//             sub_1802DC2C8(v24, v21);
			//           LODWORD(v32[3].klass) = copyPassIndex;
			//           v25 = v32;
			//           TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                              renderGraph,
			//                              dstTexture,
			//                              0LL);
			//           if ( !v25 )
			//             sub_1802DC2C8(v28, v27);
			//           BYTE1(v25[3].monitor) = TextureDescRef.colorFormat == 49;
			//           if ( !v32 )
			//             sub_1802DC2C8(0LL, v27);
			//           *(Object *)((char *)v32 + 60) = *(Object *)viewport;
			//           if ( !useNativeBlit )
			//           {
			//             si128 = (Rect)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//               (TextureHandle *)&v36,
			//               &v37,
			//               dstTexture,
			//               0,
			//               (RenderBufferLoadAction__Enum)!loadRT,
			//               RenderBufferStoreAction__Enum_Store,
			//               (Color *)&si128,
			//               0,
			//               0LL);
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v37,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass.static_fields.s_copyTextureFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v33 )
			//         {
			//           v34.handle = (ResourceHandle)v33.ex;
			//         }
			//         sub_180222690(&v34);
			//       }
			//     }
			//   }
			// }
			// 
		}

		internal static void CopyDepth(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle destTexture)
		{
			// // Void CopyDepth(HGRenderGraph, TextureHandle, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::CopyTexturePass::CopyDepth(
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *srcTexture,
			//         TextureHandle *destTexture,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Object *v10; // rbx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   TextureHandle v13; // xmm0
			//   Object *v14; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   TextureHandle v17; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   Object *v21; // [rsp+40h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v22; // [rsp+48h] [rbp-60h] BYREF
			//   TextureHandle v23; // [rsp+50h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v24; // [rsp+60h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+80h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91950D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4FB2F8);
			//     byte_18D91950D = 1;
			//   }
			//   v21 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2525, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2525, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     v23 = *destTexture;
			//     *(TextureHandle *)&v24.m_RenderPass = *srcTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_927(Patch, (Object *)renderGraph, (TextureHandle *)&v24, &v23, 0LL);
			//   }
			//   else
			//   {
			//     v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)1u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v24,
			//       renderGraph,
			//       (String *)"Copy Depth Buffer",
			//       &v21,
			//       v7,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
			//     v25 = v24;
			//     v23.handle = 0LL;
			//     v23.fallBackResource = (ResourceHandle)&v25;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v25, 0, 0LL);
			//       v10 = v21;
			//       v13 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v24,
			//                &v25,
			//                srcTexture,
			//                0LL);
			//       if ( !v10 )
			//         sub_1802DC2C8(v12, v11);
			//       v10[1] = (Object)v13;
			//       v14 = v21;
			//       v17 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                (TextureHandle *)&v24,
			//                &v25,
			//                destTexture,
			//                0LL);
			//       if ( !v14 )
			//         sub_1802DC2C8(v16, v15);
			//       v14[2] = (Object)v17;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v25,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass.static_fields.s_copyDepthFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v22 )
			//     {
			//       v23.handle = (ResourceHandle)v22.ex;
			//     }
			//     sub_180222690(&v23);
			//   }
			// }
			// 
		}

		internal static void BlitMotionVector(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle dstTexture)
		{
			// // Void BlitMotionVector(HGRenderGraph, TextureHandle, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::CopyTexturePass::BlitMotionVector(
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *srcTexture,
			//         TextureHandle *dstTexture,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Object *v10; // rbx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   TextureHandle v13; // xmm0
			//   Object *v14; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   TextureHandle v17; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   Object *v21; // [rsp+50h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v22; // [rsp+58h] [rbp-70h] BYREF
			//   TextureHandle v23; // [rsp+60h] [rbp-68h] BYREF
			//   TextureHandle si128; // [rsp+70h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+80h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v26; // [rsp+A0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91950E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4FAC48);
			//     byte_18D91950E = 1;
			//   }
			//   v21 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2526, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2526, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     si128 = *dstTexture;
			//     v23 = *srcTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_927(Patch, (Object *)renderGraph, &v23, &si128, 0LL);
			//   }
			//   else
			//   {
			//     v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x52u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v25,
			//       renderGraph,
			//       (String *)"Blit Motion Vector",
			//       &v21,
			//       v7,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>);
			//     v26 = v25;
			//     v23.handle = 0LL;
			//     v23.fallBackResource = (ResourceHandle)&v26;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v26, 0, 0LL);
			//       v10 = v21;
			//       v13 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v26, srcTexture, 0LL);
			//       if ( !v10 )
			//         sub_1802DC2C8(v12, v11);
			//       v10[1] = (Object)v13;
			//       v14 = v21;
			//       v17 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&si128, &v26, dstTexture, 0LL);
			//       if ( !v14 )
			//         sub_1802DC2C8(v16, v15);
			//       v14[2] = (Object)v17;
			//       si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v25,
			//         &v26,
			//         dstTexture,
			//         0,
			//         RenderBufferLoadAction__Enum_Clear,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v26,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass.static_fields.s_blitMotionVectorFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v22 )
			//     {
			//       v23.handle = (ResourceHandle)v22.ex;
			//     }
			//     sub_180222690(&v23);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<CopyTexturePass.CopyTextureData> s_copyTextureFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<CopyTexturePass.CopyDepthPassData> s_copyDepthFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<CopyTexturePass.BlitMotionVectorPassData> s_blitMotionVectorFunc;

		private class CopyTextureData
		{
			public CopyTextureData()
			{
				// // CopyTexturePass+CopyTextureData()
				// void HG::Rendering::Runtime::CopyTexturePass::CopyTextureData::CopyTextureData(
				//         CopyTexturePass_CopyTextureData *this,
				//         MethodInfo *method)
				// {
				//   this.fields.dstTextureShaderID = -1;
				//   this.fields.viewport = 0LL;
				// }
				// 
			}

			public TextureHandle srcTexture;

			public TextureHandle dstTexture;

			public int copyPassIndex;

			public int dstTextureShaderID;

			public bool useNativeBlit;

			public bool isFP32Output;

			public Rect viewport;
		}

		private class CopyDepthPassData
		{
			public CopyDepthPassData()
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

			public TextureHandle destTexture;
		}

		private class BlitMotionVectorPassData
		{
			public BlitMotionVectorPassData()
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

			public TextureHandle dstTexture;
		}
	}
}
