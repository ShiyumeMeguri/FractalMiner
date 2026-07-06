using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class GPUDrivenCullingPassConstructor : IPassConstructor
	{
		public GPUDrivenCullingPassConstructor()
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
			// void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         GPUDrivenCullingPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2670, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2670, 0LL);
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
			// void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         GPUDrivenCullingPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2671, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2671, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref GPUDrivenCullingPassConstructor.PassInput input, ref GPUDrivenCullingPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(GPUDrivenCullingPassConstructor+PassInput ByRef, GPUDrivenCullingPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::ConstructPass(
			//         GPUDrivenCullingPassConstructor *this,
			//         GPUDrivenCullingPassConstructor_PassInput *input,
			//         GPUDrivenCullingPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   Object *v14; // rax
			//   Object__Class *initShader; // rcx
			//   __int64 v16; // rcx
			//   unsigned __int64 v17; // r9
			//   signed __int64 v18; // rtt
			//   Object *v19; // r8
			//   unsigned __int64 v20; // r8
			//   unsigned __int64 v21; // r9
			//   char v22; // r8
			//   signed __int64 v23; // rtt
			//   Object *v24; // r9
			//   unsigned __int64 v25; // r9
			//   unsigned __int64 v26; // r8
			//   char v27; // r9
			//   signed __int64 v28; // rtt
			//   Object *v29; // rbx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   Object v32; // xmm0
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   Object *v35; // rbx
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   TextureHandle v38; // xmm0
			//   TextureDesc *TextureDescRef; // rax
			//   __int64 width; // rdx
			//   __int64 height; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   Object *v45; // [rsp+40h] [rbp-68h] BYREF
			//   TextureHandle v46; // [rsp+48h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v47; // [rsp+58h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v48; // [rsp+60h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v49; // [rsp+80h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91956B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD6A8);
			//     byte_18D91956B = 1;
			//   }
			//   v45 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2672, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2672, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v44, v43);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_979(
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
			//             (Int32Enum__Enum)0xD3u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v48,
			//       renderGraph,
			//       (String *)"CullingPass",
			//       &v45,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
			//     v49 = v48;
			//     v48.m_RenderPass = 0LL;
			//     v48.m_Resources = (HGRenderGraphResourceRegistry *)&v49;
			//     try
			//     {
			//       v14 = v45;
			//       initShader = (Object__Class *)input.initShader;
			//       if ( !v45 )
			//         sub_1802DC2C8(initShader, v13);
			//       v45[1].klass = initShader;
			//       v16 = (unsigned int)dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v17 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v17 + 36190]);
			//         do
			//           v18 = qword_18D6405E0[v17 + 36190];
			//         while ( v18 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v17 + 36190],
			//                          v18 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
			//                          v18) );
			//         v16 = (unsigned int)dword_18D8E43F8;
			//       }
			//       v19 = v45;
			//       if ( !v45 )
			//         sub_1802DC2C8(v16, qword_18D6405E0);
			//       v45[1].monitor = (MonitorData *)input.cullingShader;
			//       if ( (_DWORD)v16 )
			//       {
			//         v20 = ((unsigned __int64)&v19[1].monitor >> 12) & 0x1FFFFF;
			//         v21 = v20 >> 6;
			//         v22 = v20 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v21 + 36190]);
			//         do
			//           v23 = qword_18D6405E0[v21 + 36190];
			//         while ( v23 != _InterlockedCompareExchange64(&qword_18D6405E0[v21 + 36190], v23 | (1LL << v22), v23) );
			//         v16 = (unsigned int)dword_18D8E43F8;
			//       }
			//       v24 = v45;
			//       if ( !v45 )
			//         sub_1802DC2C8(v16, qword_18D6405E0);
			//       v45[3].monitor = (MonitorData *)camera;
			//       if ( (_DWORD)v16 )
			//       {
			//         v25 = ((unsigned __int64)&v24[3].monitor >> 12) & 0x1FFFFF;
			//         v26 = v25 >> 6;
			//         v27 = v25 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v26 + 36190]);
			//         do
			//           v28 = qword_18D6405E0[v26 + 36190];
			//         while ( v28 != _InterlockedCompareExchange64(&qword_18D6405E0[v26 + 36190], v28 | (1LL << v27), v28) );
			//       }
			//       v29 = v45;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v32 = *(Object *)sub_182E7CCD0(&v46);
			//       if ( !v29 )
			//         sub_1802DC2C8(v31, v30);
			//       v29[2] = v32;
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.hzb, 0LL) )
			//       {
			//         v35 = v45;
			//         v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v46, &v49, &input.hzb, 0LL);
			//         if ( !v35 )
			//           sub_1802DC2C8(v37, v36);
			//         v35[2] = (Object)v38;
			//         if ( !v45 )
			//           sub_1802DC2C8(v37, v36);
			//         TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                            renderGraph,
			//                            (TextureHandle *)&v45[2],
			//                            0LL);
			//         width = (unsigned int)TextureDescRef.width;
			//         if ( !v45 )
			//           sub_1802DC2C8(0LL, width);
			//         LODWORD(v45[3].klass) = width;
			//         height = (unsigned int)TextureDescRef.height;
			//         if ( !v45 )
			//           sub_1802DC2C8(height, width);
			//         HIDWORD(v45[3].klass) = height;
			//       }
			//       else
			//       {
			//         if ( !v45 )
			//           sub_1802DC2C8(v34, v33);
			//         LODWORD(v45[3].klass) = 0;
			//         if ( !v45 )
			//           sub_1802DC2C8(v34, v33);
			//         HIDWORD(v45[3].klass) = 0;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v49,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor.static_fields.s_cullingPassRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v47 )
			//     {
			//       v48.m_RenderPass = (HGRenderGraphPass *)v47.ex;
			//     }
			//     sub_180222690(&v48);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         GPUDrivenCullingPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2673, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2673, 0LL);
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
			// void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         GPUDrivenCullingPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2674, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2674, 0LL);
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
		private static readonly RenderFunc<GPUDrivenCullingPassConstructor.CullingPassData> s_cullingPassRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			public ComputeShader initShader;

			public ComputeShader cullingShader;

			public ComputeShader cmdGenShader;

			public TextureHandle hzb;

			public bool usePrevVP;
		}

		internal struct PassOutput
		{
		}

		private class CullingPassData
		{
			public CullingPassData()
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

			public ComputeShader initShader;

			public ComputeShader cullingShader;

			public TextureHandle hzb;

			public uint hzbWidth;

			public uint hzbHeight;

			public HGCamera camera;

			public bool usePrevVP;
		}
	}
}
