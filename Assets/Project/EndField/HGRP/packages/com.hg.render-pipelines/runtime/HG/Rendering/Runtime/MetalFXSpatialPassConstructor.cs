using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class MetalFXSpatialPassConstructor : IPassConstructor
	{
		internal MetalFXSpatialPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
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
			// void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         MetalFXSpatialPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2708, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2708, 0LL);
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
			// void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         MetalFXSpatialPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2709, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2709, 0LL);
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
			// void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         MetalFXSpatialPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2710, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2710, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref MetalFXSpatialPassConstructor.PassInput input, ref MetalFXSpatialPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(MetalFXSpatialPassConstructor+PassInput ByRef, MetalFXSpatialPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::ConstructPass(
			//         MetalFXSpatialPassConstructor *this,
			//         MetalFXSpatialPassConstructor_PassInput *input,
			//         MetalFXSpatialPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   TextureDesc *TextureDescRef; // rax
			//   __m128i v14; // xmm6
			//   __m128i v15; // xmm7
			//   __m128i *v16; // rax
			//   __m128i v17; // xmm2
			//   int32_t v18; // r8d
			//   __m128i v19; // xmm1
			//   __int64 v20; // xmm0_8
			//   __int64 v21; // rdx
			//   __m128i v22; // xmm1
			//   unsigned __int64 v23; // xmm0_8
			//   uint32_t MetalFXSpatialScaler; // eax
			//   __int64 m_spatialScalerHandle; // rcx
			//   Object *v26; // rbx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   TextureHandle v29; // xmm0
			//   Object *v30; // rbx
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   TextureHandle v33; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc outputTextureFormat; // [rsp+40h] [rbp-118h] BYREF
			//   Object *v38; // [rsp+60h] [rbp-F8h] BYREF
			//   _QWORD v39[2]; // [rsp+68h] [rbp-F0h] BYREF
			//   HGRenderGraphBuilder inputWidth; // [rsp+78h] [rbp-E0h] BYREF
			//   HGRenderGraphBuilder v41; // [rsp+98h] [rbp-C0h] BYREF
			//   Il2CppExceptionWrapper *v42; // [rsp+120h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919589 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500F50);
			//     byte_18D919589 = 1;
			//   }
			//   v38 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2711, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2711, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v36, v35);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_992(
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
			//     if ( input.enableMetalFXSpatialScaler )
			//     {
			//       v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x53u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v12, v11);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &inputWidth,
			//         renderGraph,
			//         (String *)"MetalFX Spatial Pass",
			//         &v38,
			//         v10,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
			//       v41 = inputWidth;
			//       v39[0] = 0LL;
			//       v39[1] = &v41;
			//       try
			//       {
			//         TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                            renderGraph,
			//                            &input.colorTexture,
			//                            0LL);
			//         v14 = *(__m128i *)&TextureDescRef.width;
			//         v15 = *(__m128i *)&TextureDescRef.colorFormat;
			//         v16 = (__m128i *)HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                            renderGraph,
			//                            &input.outputTexture,
			//                            0LL);
			//         *(_QWORD *)&outputTextureFormat.outputWidth = 0LL;
			//         *(_QWORD *)&outputTextureFormat.colorTextureFormat = 0LL;
			//         outputTextureFormat.inputWidth = _mm_cvtsi128_si32(v14);
			//         outputTextureFormat.inputHeight = v14.m128i_i32[1];
			//         v17 = *v16;
			//         v18 = _mm_cvtsi128_si32(*v16);
			//         outputTextureFormat.outputWidth = v18;
			//         outputTextureFormat.outputHeight = v17.m128i_i32[1];
			//         outputTextureFormat.colorTextureFormat = _mm_cvtsi128_si32(v15);
			//         outputTextureFormat.outputTextureFormat = _mm_cvtsi128_si32(v16[1]);
			//         v19 = *(__m128i *)&outputTextureFormat.inputWidth;
			//         *(_OWORD *)&inputWidth.m_RenderPass = *(_OWORD *)&outputTextureFormat.inputWidth;
			//         v20 = *(_QWORD *)&outputTextureFormat.colorTextureFormat;
			//         inputWidth.m_RenderGraph = *(HGRenderGraph **)&outputTextureFormat.colorTextureFormat;
			//         if ( this.fields.m_spatialScalerHandle )
			//         {
			//           outputTextureFormat = this.fields.m_spatialScalerDesc;
			//           if ( HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialScalerDesc::Equals(
			//                  (MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc *)&inputWidth,
			//                  &outputTextureFormat,
			//                  0LL) )
			//           {
			// LABEL_12:
			//             m_spatialScalerHandle = this.fields.m_spatialScalerHandle;
			//             if ( !v38 )
			//               sub_1802DC2C8(m_spatialScalerHandle, v21);
			//             LODWORD(v38[1].klass) = m_spatialScalerHandle;
			//             v26 = v38;
			//             v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                      (TextureHandle *)&outputTextureFormat,
			//                      &v41,
			//                      &input.colorTexture,
			//                      0LL);
			//             if ( !v26 )
			//               sub_1802DC2C8(v28, v27);
			//             *(TextureHandle *)((char *)&v26[1] + 4) = v29;
			//             v30 = v38;
			//             v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                      (TextureHandle *)&outputTextureFormat,
			//                      &v41,
			//                      &input.outputTexture,
			//                      0LL);
			//             if ( !v30 )
			//               sub_1802DC2C8(v32, v31);
			//             *(TextureHandle *)((char *)&v30[2] + 4) = v33;
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v41, 0, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//               &v41,
			//               (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor.static_fields.s_metalFXSpatialRenderFunc,
			//               0LL,
			//               0,
			//               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
			//             goto LABEL_27;
			//           }
			//           UnityEngine::HyperGryph::HGGraphicsUtils::DestroyMetalFXSpatialScaler(this.fields.m_spatialScalerHandle, 0LL);
			//           v22 = *(__m128i *)&inputWidth.m_RenderPass;
			//           *(_OWORD *)&this.fields.m_spatialScalerDesc.inputWidth = *(_OWORD *)&inputWidth.m_RenderPass;
			//           *(_QWORD *)&this.fields.m_spatialScalerDesc.colorTextureFormat = inputWidth.m_RenderGraph;
			//           v23 = _mm_srli_si128(v22, 8).m128i_u64[0];
			//           MetalFXSpatialScaler = UnityEngine::HyperGryph::HGGraphicsUtils::CreateMetalFXSpatialScaler(
			//                                    v22.m128i_i32[0],
			//                                    v22.m128i_i32[1],
			//                                    v23,
			//                                    SHIDWORD(v23),
			//                                    (GraphicsFormat__Enum)inputWidth.m_RenderGraph,
			//                                    HIDWORD(inputWidth.m_RenderGraph),
			//                                    0LL);
			//         }
			//         else
			//         {
			//           *(_OWORD *)&this.fields.m_spatialScalerDesc.inputWidth = *(_OWORD *)&outputTextureFormat.inputWidth;
			//           *(_QWORD *)&this.fields.m_spatialScalerDesc.colorTextureFormat = v20;
			//           MetalFXSpatialScaler = UnityEngine::HyperGryph::HGGraphicsUtils::CreateMetalFXSpatialScaler(
			//                                    _mm_cvtsi128_si32(v14),
			//                                    v19.m128i_i32[1],
			//                                    v18,
			//                                    _mm_srli_si128(v19, 8).m128i_i32[1],
			//                                    (GraphicsFormat__Enum)_mm_cvtsi128_si32(v15),
			//                                    (GraphicsFormat__Enum)outputTextureFormat.outputTextureFormat,
			//                                    0LL);
			//         }
			//         this.fields.m_spatialScalerHandle = MetalFXSpatialScaler;
			//         goto LABEL_12;
			//       }
			//       catch ( Il2CppExceptionWrapper *v42 )
			//       {
			//         v39[0] = v42.ex;
			//       }
			// LABEL_27:
			//       sub_180222690(v39);
			//       return;
			//     }
			//     if ( this.fields.m_spatialScalerHandle )
			//     {
			//       UnityEngine::HyperGryph::HGGraphicsUtils::DestroyMetalFXSpatialScaler(this.fields.m_spatialScalerHandle, 0LL);
			//       *(_OWORD *)&this.fields.m_spatialScalerDesc.inputWidth = 0LL;
			//       *(_QWORD *)&this.fields.m_spatialScalerDesc.colorTextureFormat = 0LL;
			//       this.fields.m_spatialScalerHandle = 0;
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         MetalFXSpatialPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2713, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2713, 0LL);
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

		private MetalFXSpatialPassConstructor.MetalFXSpatialScalerDesc m_spatialScalerDesc;

		private uint m_spatialScalerHandle;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<MetalFXSpatialPassConstructor.MetalFXSpatialPassData> s_metalFXSpatialRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
		internal struct PassInput
		{
			internal bool enableMetalFXSpatialScaler;

			internal TextureHandle colorTexture;

			internal TextureHandle outputTexture;
		}

		internal struct PassOutput
		{
		}

		private class MetalFXSpatialPassData
		{
			public MetalFXSpatialPassData()
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

			internal uint spatialScalerHandle;

			internal TextureHandle colorTexture;

			internal TextureHandle outputTexture;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		internal struct MetalFXSpatialScalerDesc : IEquatable<MetalFXSpatialPassConstructor.MetalFXSpatialScalerDesc>
		{
			public bool Equals(MetalFXSpatialPassConstructor.MetalFXSpatialScalerDesc other)
			{
				// // Boolean Equals(MetalFXSpatialPassConstructor+MetalFXSpatialScalerDesc)
				// bool HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialScalerDesc::Equals(
				//         MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc *this,
				//         MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc *other,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // xmm0_8
				//   int32_t inputWidth; // eax
				//   __int64 v7; // rax
				//   int32_t outputWidth; // eax
				//   __int64 v9; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   __int64 v14; // xmm1_8
				//   MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc v15; // [rsp+20h] [rbp-20h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2712, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2712, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v13, v12);
				//     v14 = *(_QWORD *)&other.colorTextureFormat;
				//     *(_OWORD *)&v15.inputWidth = *(_OWORD *)&other.inputWidth;
				//     *(_QWORD *)&v15.colorTextureFormat = v14;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_991(Patch, this, &v15, 0LL);
				//   }
				//   else
				//   {
				//     v5 = *(_QWORD *)&other.colorTextureFormat;
				//     inputWidth = other.inputWidth;
				//     *(_QWORD *)&v15.colorTextureFormat = v5;
				//     if ( this.inputWidth == inputWidth
				//       && (v7 = HIDWORD(*(_QWORD *)&other.inputWidth),
				//           *(_QWORD *)&v15.colorTextureFormat = v5,
				//           this.inputHeight == (_DWORD)v7)
				//       && (outputWidth = other.outputWidth, *(_QWORD *)&v15.colorTextureFormat = v5, this.outputWidth == outputWidth)
				//       && (v9 = HIDWORD(*(_QWORD *)&other.outputWidth),
				//           *(_QWORD *)&v15.colorTextureFormat = v5,
				//           this.outputHeight == (_DWORD)v9)
				//       && (*(_QWORD *)&v15.colorTextureFormat = v5, this.colorTextureFormat == (_DWORD)v5) )
				//     {
				//       *(_QWORD *)&v15.colorTextureFormat = v5;
				//       return this.outputTextureFormat == HIDWORD(v5);
				//     }
				//     else
				//     {
				//       return 0;
				//     }
				//   }
				// }
				// 
				return default(bool);
			}

			internal int inputWidth;

			internal int inputHeight;

			internal int outputWidth;

			internal int outputHeight;

			internal GraphicsFormat colorTextureFormat;

			internal GraphicsFormat outputTextureFormat;
		}
	}
}
