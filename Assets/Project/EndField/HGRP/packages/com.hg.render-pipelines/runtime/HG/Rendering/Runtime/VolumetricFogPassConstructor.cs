using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class VolumetricFogPassConstructor : IPassConstructor
	{
		internal VolumetricFogPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         VolumetricFogPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2880, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2880, 0LL);
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
			// void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         VolumetricFogPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2881, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2881, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructSkipRender(bool prevTransformReset, HGCamera camera)
		{
			// // Void ConstructSkipRender(Boolean, HGCamera)
			// void HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructSkipRender(
			//         VolumetricFogPassConstructor *this,
			//         bool prevTransformReset,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9195ED )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9195ED = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1076, 0LL) )
			//   {
			//     if ( !prevTransformReset )
			//       return;
			//     if ( camera )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//         &camera.fields.historyVolumetricLightScatteringTexture,
			//         0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1076, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)this,
			//     prevTransformReset,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		internal void ConstructPass(ref VolumetricFogPassConstructor.PassInput input, ref VolumetricFogPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(VolumetricFogPassConstructor+PassInput ByRef, VolumetricFogPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructPass(
			//         VolumetricFogPassConstructor *this,
			//         VolumetricFogPassConstructor_PassInput *input,
			//         VolumetricFogPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   Object *v14; // rcx
			//   int v15; // eax
			//   unsigned __int64 v16; // r9
			//   signed __int64 v17; // rtt
			//   Object *v18; // r8
			//   MonitorData *m_volumetricFogGridInjectionCS; // rcx
			//   unsigned __int64 v20; // r8
			//   unsigned __int64 v21; // r9
			//   char v22; // r8
			//   signed __int64 v23; // rtt
			//   Object *v24; // r8
			//   Object__Class *m_volumetricFogLightScatteringCS; // rcx
			//   unsigned __int64 v26; // r8
			//   unsigned __int64 v27; // r9
			//   char v28; // r8
			//   signed __int64 v29; // rtt
			//   Object *v30; // r8
			//   MonitorData *m_volumetricFogFinalIntegrationCS; // rcx
			//   unsigned __int64 v32; // r8
			//   unsigned __int64 v33; // r9
			//   char v34; // r8
			//   signed __int64 v35; // rtt
			//   Object *v36; // rcx
			//   unsigned __int64 v37; // r9
			//   signed __int64 v38; // rtt
			//   Object *v39; // rcx
			//   unsigned __int64 v40; // r9
			//   signed __int64 v41; // rtt
			//   Object *v42; // rcx
			//   unsigned __int64 v43; // r9
			//   signed __int64 v44; // rtt
			//   Object *v45; // r8
			//   Object__Class *m_volumetricLight3DNoise; // rcx
			//   unsigned __int64 v47; // r8
			//   unsigned __int64 v48; // r9
			//   char v49; // r8
			//   signed __int64 v50; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   Object *v54; // [rsp+40h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v55; // [rsp+50h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v56; // [rsp+58h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v57; // [rsp+78h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9195EE )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//     sub_18003C530(&off_18D502B88);
			//     byte_18D9195EE = 1;
			//   }
			//   v54 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2882, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2882, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v53, v52);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1045(
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
			//             (Int32Enum__Enum)0x2Du,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v56,
			//       renderGraph,
			//       (String *)"Volumetric Fog",
			//       &v54,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
			//     v57 = v56;
			//     v56.m_RenderPass = 0LL;
			//     v56.m_Resources = (HGRenderGraphResourceRegistry *)&v57;
			//     try
			//     {
			//       v14 = v54;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, v13);
			//       v54[1].klass = (Object__Class *)camera;
			//       v15 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v16 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v16 + 36190]);
			//         do
			//           v17 = qword_18D6405E0[v16 + 36190];
			//         while ( v17 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v16 + 36190],
			//                          v17 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
			//                          v17) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       v18 = v54;
			//       m_volumetricFogGridInjectionCS = (MonitorData *)this.fields.m_volumetricFogGridInjectionCS;
			//       if ( !v54 )
			//         sub_1802DC2C8(m_volumetricFogGridInjectionCS, qword_18D6405E0);
			//       v54[1].monitor = m_volumetricFogGridInjectionCS;
			//       if ( v15 )
			//       {
			//         v20 = ((unsigned __int64)&v18[1].monitor >> 12) & 0x1FFFFF;
			//         v21 = v20 >> 6;
			//         v22 = v20 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v21 + 36190]);
			//         do
			//           v23 = qword_18D6405E0[v21 + 36190];
			//         while ( v23 != _InterlockedCompareExchange64(&qword_18D6405E0[v21 + 36190], v23 | (1LL << v22), v23) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       v24 = v54;
			//       m_volumetricFogLightScatteringCS = (Object__Class *)this.fields.m_volumetricFogLightScatteringCS;
			//       if ( !v54 )
			//         sub_1802DC2C8(m_volumetricFogLightScatteringCS, qword_18D6405E0);
			//       v54[2].klass = m_volumetricFogLightScatteringCS;
			//       if ( v15 )
			//       {
			//         v26 = ((unsigned __int64)&v24[2] >> 12) & 0x1FFFFF;
			//         v27 = v26 >> 6;
			//         v28 = v26 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v27 + 36190]);
			//         do
			//           v29 = qword_18D6405E0[v27 + 36190];
			//         while ( v29 != _InterlockedCompareExchange64(&qword_18D6405E0[v27 + 36190], v29 | (1LL << v28), v29) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       v30 = v54;
			//       m_volumetricFogFinalIntegrationCS = (MonitorData *)this.fields.m_volumetricFogFinalIntegrationCS;
			//       if ( !v54 )
			//         sub_1802DC2C8(m_volumetricFogFinalIntegrationCS, qword_18D6405E0);
			//       v54[2].monitor = m_volumetricFogFinalIntegrationCS;
			//       if ( v15 )
			//       {
			//         v32 = ((unsigned __int64)&v30[2].monitor >> 12) & 0x1FFFFF;
			//         v33 = v32 >> 6;
			//         v34 = v32 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v33 + 36190]);
			//         do
			//           v35 = qword_18D6405E0[v33 + 36190];
			//         while ( v35 != _InterlockedCompareExchange64(&qword_18D6405E0[v33 + 36190], v35 | (1LL << v34), v35) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       v36 = v54;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, qword_18D6405E0);
			//       v54[11].klass = 0LL;
			//       if ( v15 )
			//       {
			//         v37 = (((unsigned __int64)&v36[11] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v37 + 36190]);
			//         do
			//           v38 = qword_18D6405E0[v37 + 36190];
			//         while ( v38 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v37 + 36190],
			//                          v38 | (1LL << (((unsigned __int64)&v36[11] >> 12) & 0x3F)),
			//                          v38) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       v39 = v54;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, qword_18D6405E0);
			//       v54[11].monitor = 0LL;
			//       if ( v15 )
			//       {
			//         v40 = (((unsigned __int64)&v39[11].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v40 + 36190]);
			//         do
			//           v41 = qword_18D6405E0[v40 + 36190];
			//         while ( v41 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v40 + 36190],
			//                          v41 | (1LL << (((unsigned __int64)&v39[11].monitor >> 12) & 0x3F)),
			//                          v41) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       v42 = v54;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, qword_18D6405E0);
			//       v54[12].klass = 0LL;
			//       if ( v15 )
			//       {
			//         v43 = (((unsigned __int64)&v42[12] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v43 + 36190]);
			//         do
			//           v44 = qword_18D6405E0[v43 + 36190];
			//         while ( v44 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v43 + 36190],
			//                          v44 | (1LL << (((unsigned __int64)&v42[12] >> 12) & 0x3F)),
			//                          v44) );
			//         v15 = dword_18D8E43F8;
			//       }
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, qword_18D6405E0);
			//       LOBYTE(v54[12].monitor) = input.shadowResult.punctualLightShadowActive;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, qword_18D6405E0);
			//       *(TextureHandle *)((char *)v54 + 204) = input.shadowResult.punctualLightShadowResult;
			//       v45 = v54;
			//       m_volumetricLight3DNoise = (Object__Class *)this.fields.m_volumetricLight3DNoise;
			//       if ( !v54 )
			//         sub_1802DC2C8(m_volumetricLight3DNoise, qword_18D6405E0);
			//       v54[14].klass = m_volumetricLight3DNoise;
			//       if ( v15 )
			//       {
			//         v47 = ((unsigned __int64)&v45[14] >> 12) & 0x1FFFFF;
			//         v48 = v47 >> 6;
			//         v49 = v47 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v48 + 36190]);
			//         do
			//           v50 = qword_18D6405E0[v48 + 36190];
			//         while ( v50 != _InterlockedCompareExchange64(&qword_18D6405E0[v48 + 36190], v50 | (1LL << v49), v50) );
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v57,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor.static_fields.s_volumetricFogComputeFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::VolumetricFogPassConstructor::ComputeVolumetricFogPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v55 )
			//     {
			//       v56.m_RenderPass = (HGRenderGraphPass *)v55.ex;
			//     }
			//     sub_180222690(&v56);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         VolumetricFogPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2883, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2883, 0LL);
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
			// void HG::Rendering::Runtime::VolumetricFogPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         VolumetricFogPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2884, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2884, 0LL);
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

		private ComputeShader m_volumetricFogGridInjectionCS;

		private ComputeShader m_volumetricFogLightScatteringCS;

		private ComputeShader m_volumetricFogFinalIntegrationCS;

		private Texture3D m_volumetricLight3DNoise;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<VolumetricFogPassConstructor.ComputeVolumetricFogPassData> s_volumetricFogComputeFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
		internal struct PassInput
		{
			internal ShadowResult shadowResult;
		}

		internal struct PassOutput
		{
		}

		public class ComputeVolumetricFogPassData
		{
			public ComputeVolumetricFogPassData()
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

			public ComputeShader volumetricFogGridInjectionCS;

			public ComputeShader volumetricFogLightScatteringCS;

			public ComputeShader volumetricFogFinalIntegrationCS;

			public bool temporalHistoryIsValid;

			public float volumetricFogDistance;

			public Vector3Int volumetricFogGridSize;

			public Vector2Int volumetricFogGridToPixel;

			public Vector3 volumetricFogZParams;

			public Vector3 volumetricFogEmissive;

			public RenderTextureDescriptor volumeDesc;

			public int historyMissSuperSampleCount;

			public NativeArray<Vector4> frameJitterOffsetValues;

			public RenderTexture vBufferA;

			public RenderTexture vBufferB;

			public RenderTexture lightScattering;

			public bool punctualLightShadowActive;

			public TextureHandle punctualLightShadowResult;

			public Texture3D volumetricLight3DNoise;
		}
	}
}
