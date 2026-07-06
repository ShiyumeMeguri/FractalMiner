using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class SkyAtmospherePassConstructor : IPassConstructor
	{
		internal SkyAtmospherePassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         SkyAtmospherePassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2798, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2798, 0LL);
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
			// void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         SkyAtmospherePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2799, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2799, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref SkyAtmospherePassConstructor.PassInput input, ref SkyAtmospherePassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(SkyAtmospherePassConstructor+PassInput ByRef, SkyAtmospherePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
			//         SkyAtmospherePassConstructor *this,
			//         SkyAtmospherePassConstructor_PassInput *input,
			//         SkyAtmospherePassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGAtmosphereSettingParameters *atmosphereParams; // rbx
			//   bool ShouldRenderAtmosphereLutUsingCompute; // r12
			//   char *v12; // rbx
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   Object *v17; // rcx
			//   int v18; // eax
			//   unsigned __int64 v19; // r9
			//   signed __int64 v20; // rtt
			//   Object *v21; // r8
			//   MonitorData *m_renderAtmosphereLutMaterial; // rcx
			//   unsigned __int64 v23; // r8
			//   unsigned __int64 v24; // r9
			//   char v25; // r8
			//   signed __int64 v26; // rtt
			//   Object *v27; // r8
			//   Object__Class *m_renderAtmosphereLutCS; // rcx
			//   unsigned __int64 v29; // r8
			//   unsigned __int64 v30; // r9
			//   char v31; // r8
			//   signed __int64 v32; // rtt
			//   Object *v33; // r8
			//   MonitorData *v34; // rcx
			//   unsigned __int64 v35; // r8
			//   unsigned __int64 v36; // r9
			//   char v37; // r8
			//   signed __int64 v38; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   Object *v42; // [rsp+40h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v43; // [rsp+50h] [rbp-68h] BYREF
			//   HGRenderGraphBuilder v44; // [rsp+58h] [rbp-60h] BYREF
			//   HGRenderGraphBuilder v45; // [rsp+78h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D9195BD )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//     sub_18003C530(&off_18D503920);
			//     sub_18003C530(&off_18D503930);
			//     byte_18D9195BD = 1;
			//   }
			//   v42 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2800, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2800, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v41, v40);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1022(
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
			//     atmosphereParams = input.atmosphereParams;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     ShouldRenderAtmosphereLutUsingCompute = HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLutUsingCompute(
			//                                               atmosphereParams,
			//                                               0LL);
			//     v12 = "Render Sky Atmosphere";
			//     if ( ShouldRenderAtmosphereLutUsingCompute )
			//       v12 = "Compute Sky Atmosphere";
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x2Cu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v44,
			//       renderGraph,
			//       (String *)v12,
			//       &v42,
			//       v13,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
			//     v45 = v44;
			//     v44.m_RenderPass = 0LL;
			//     v44.m_Resources = (HGRenderGraphResourceRegistry *)&v45;
			//     try
			//     {
			//       v17 = v42;
			//       if ( !v42 )
			//         sub_1802DC2C8(0LL, v16);
			//       v42[1].klass = (Object__Class *)camera;
			//       v18 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v19 = (((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v19 + 36190]);
			//         do
			//           v20 = qword_18D6405E0[v19 + 36190];
			//         while ( v20 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v19 + 36190],
			//                          v20 | (1LL << (((unsigned __int64)&v17[1] >> 12) & 0x3F)),
			//                          v20) );
			//         v18 = dword_18D8E43F8;
			//       }
			//       v21 = v42;
			//       m_renderAtmosphereLutMaterial = (MonitorData *)this.fields.m_renderAtmosphereLutMaterial;
			//       if ( !v42 )
			//         sub_1802DC2C8(m_renderAtmosphereLutMaterial, qword_18D6405E0);
			//       v42[1].monitor = m_renderAtmosphereLutMaterial;
			//       if ( v18 )
			//       {
			//         v23 = ((unsigned __int64)&v21[1].monitor >> 12) & 0x1FFFFF;
			//         v24 = v23 >> 6;
			//         v25 = v23 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//         do
			//           v26 = qword_18D6405E0[v24 + 36190];
			//         while ( v26 != _InterlockedCompareExchange64(&qword_18D6405E0[v24 + 36190], v26 | (1LL << v25), v26) );
			//         v18 = dword_18D8E43F8;
			//       }
			//       v27 = v42;
			//       m_renderAtmosphereLutCS = (Object__Class *)this.fields.m_renderAtmosphereLutCS;
			//       if ( !v42 )
			//         sub_1802DC2C8(m_renderAtmosphereLutCS, qword_18D6405E0);
			//       v42[2].klass = m_renderAtmosphereLutCS;
			//       if ( v18 )
			//       {
			//         v29 = ((unsigned __int64)&v27[2] >> 12) & 0x1FFFFF;
			//         v30 = v29 >> 6;
			//         v31 = v29 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v30 + 36190]);
			//         do
			//           v32 = qword_18D6405E0[v30 + 36190];
			//         while ( v32 != _InterlockedCompareExchange64(&qword_18D6405E0[v30 + 36190], v32 | (1LL << v31), v32) );
			//         v18 = dword_18D8E43F8;
			//       }
			//       v33 = v42;
			//       v34 = (MonitorData *)input.atmosphereParams;
			//       if ( !v42 )
			//         sub_1802DC2C8(v34, qword_18D6405E0);
			//       v42[2].monitor = v34;
			//       if ( v18 )
			//       {
			//         v35 = ((unsigned __int64)&v33[2].monitor >> 12) & 0x1FFFFF;
			//         v36 = v35 >> 6;
			//         v37 = v35 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v36 + 36190]);
			//         do
			//           v38 = qword_18D6405E0[v36 + 36190];
			//         while ( v38 != _InterlockedCompareExchange64(&qword_18D6405E0[v36 + 36190], v38 | (1LL << v37), v38) );
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v45,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor.static_fields.s_skyAtmosphereRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::EnableAsyncCompute(
			//         &v45,
			//         ShouldRenderAtmosphereLutUsingCompute,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v43 )
			//     {
			//       v44.m_RenderPass = (HGRenderGraphPass *)v43.ex;
			//     }
			//     sub_180222690(&v44);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         SkyAtmospherePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2801, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2801, 0LL);
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
			// void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         SkyAtmospherePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2802, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2802, 0LL);
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

		private Material m_renderAtmosphereLutMaterial;

		private ComputeShader m_renderAtmosphereLutCS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<SkyAtmospherePassConstructor.SkyAtmospherePassData> s_skyAtmosphereRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal HGAtmosphereSettingParameters atmosphereParams;
		}

		internal struct PassOutput
		{
		}

		private class SkyAtmospherePassData
		{
			public SkyAtmospherePassData()
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

			public HGCamera hgCamera;

			public Material renderAtmosphereLutMaterial;

			public ComputeShader renderAtmosphereLutCS;

			public HGAtmosphereSettingParameters atmosphereParams;
		}
	}
}
