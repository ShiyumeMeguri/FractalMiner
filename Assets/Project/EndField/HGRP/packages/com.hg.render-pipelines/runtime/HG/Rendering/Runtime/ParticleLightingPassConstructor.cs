using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class ParticleLightingPassConstructor : IPassConstructor
	{
		internal ParticleLightingPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		internal static void SwitchParticleLightingKeywords(bool enabled)
		{
			// // Void SwitchParticleLightingKeywords(Boolean)
			// void HG::Rendering::Runtime::ParticleLightingPassConstructor::SwitchParticleLightingKeywords(
			//         bool enabled,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D9195A3 )
			//   {
			//     sub_18003C530(&off_18D500C50);
			//     byte_18D9195A3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2749, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2749, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_28 *)Patch, enabled, 0LL);
			//   }
			//   else if ( enabled )
			//   {
			//     UnityEngine::Shader::EnableKeyword((String *)"PER_PARTICLE_SYSTEM_LIGHTING", 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Shader::DisableKeyword((String *)"PER_PARTICLE_SYSTEM_LIGHTING", 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ParticleLightingPassConstructor.PassInput input, ref ParticleLightingPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ParticleLightingPassConstructor+PassInput ByRef, ParticleLightingPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::ParticleLightingPassConstructor::ConstructPass(
			//         ParticleLightingPassConstructor *this,
			//         ParticleLightingPassConstructor_PassInput *input,
			//         ParticleLightingPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   ComputeBufferHandle v12; // rdx
			//   ComputeBufferHandle v13; // rcx
			//   HGCamera *v14; // r14
			//   ProfilingSampler *v15; // rax
			//   unsigned __int64 v16; // rdx
			//   Object *v17; // rax
			//   Object__Class *m_lightingCS; // rcx
			//   unsigned __int64 v19; // r8
			//   signed __int64 v20; // rtt
			//   __int64 m_lightingKernel; // rcx
			//   ComputeBufferHandle *v22; // r15
			//   ComputeBufferHandle v23; // rax
			//   ComputeBufferHandle v24; // rdx
			//   ComputeBufferHandle v25; // rcx
			//   ComputeBufferHandle *v26; // r15
			//   ComputeBufferHandle v27; // rax
			//   ComputeBufferHandle v28; // rdx
			//   ComputeBufferHandle v29; // rcx
			//   Object *v30; // r15
			//   HGRenderGraphContext *m_RenderGraphContext; // rax
			//   ScriptableRenderContext *p_renderContext; // rsi
			//   CBHandle *ConstantBuffer; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   MonitorData *ptr; // xmm1_8
			//   Void *p_ivInput; // rdx
			//   __int64 *v38; // rdx
			//   __int64 v39; // rcx
			//   Camera *v40; // rsi
			//   HGASMManager *ASMManager; // rax
			//   __int64 v42; // rcx
			//   Object *v43; // rdx
			//   Object__Class *m_asmShadowMapRT; // rcx
			//   unsigned int v45; // edx
			//   unsigned __int64 v46; // r8
			//   char v47; // dl
			//   signed __int64 v48; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   __int64 v52; // [rsp+0h] [rbp-D8h] BYREF
			//   Object *v53; // [rsp+40h] [rbp-98h] BYREF
			//   ParticleLightingIVInput *v54; // [rsp+48h] [rbp-90h] BYREF
			//   ComputeBufferDesc desc; // [rsp+50h] [rbp-88h] BYREF
			//   HGRenderGraphBuilder v56; // [rsp+70h] [rbp-68h] BYREF
			//   ComputeBufferHandle inputa; // [rsp+90h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v58; // [rsp+98h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v59; // [rsp+B8h] [rbp-20h] BYREF
			//   Il2CppExceptionWrapper *v60; // [rsp+C0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195A4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D500C40);
			//     byte_18D9195A4 = 1;
			//   }
			//   v53 = 0LL;
			//   v54 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2750, 0LL) )
			//   {
			//     *(HGRenderGraphResourceRegistry **)((char *)&v56.m_Resources + 4) = 0LL;
			//     HIDWORD(v56.m_RenderGraph) = 0;
			//     v56.m_RenderPass = (HGRenderGraphPass *)0x1000001000LL;
			//     LODWORD(v56.m_Resources) = 16;
			//     *(_OWORD *)&desc.count = *(_OWORD *)&v56.m_RenderPass;
			//     desc.name = 0LL;
			//     if ( !renderGraph )
			//       sub_180B536AC(v11, v10);
			//     inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(renderGraph, &desc, 0LL);
			//     v14 = camera;
			//     if ( !camera )
			//       sub_180B536AC(v13, v12);
			//     *(_QWORD *)&desc.count = *(_QWORD *)&camera.fields.mainViewConstants.worldSpaceCameraPos.x;
			//     desc.type = LODWORD(camera.fields.mainViewConstants.worldSpaceCameraPos.z);
			//     UnityEngine::HyperGryph::HGRendererSystem::set_PerRendererLightingFallbackPosition_Injected((Vector3 *)&desc, 0LL);
			//     v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0xB7u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v56,
			//       renderGraph,
			//       (String *)"Particle Lighting",
			//       &v53,
			//       v15,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
			//     v58 = v56;
			//     v56.m_RenderPass = 0LL;
			//     v56.m_Resources = (HGRenderGraphResourceRegistry *)&v58;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v58, 0, 0LL);
			//       v17 = v53;
			//       m_lightingCS = (Object__Class *)this.fields.m_lightingCS;
			//       if ( !v53 )
			//         sub_1802DC2C8(m_lightingCS, v16);
			//       v53[1].klass = m_lightingCS;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v19 = (((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF) >> 6;
			//         v16 = ((unsigned __int64)&v17[1] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v19 + 36190]);
			//         do
			//           v20 = qword_18D6405E0[v19 + 36190];
			//         while ( v20 != _InterlockedCompareExchange64(&qword_18D6405E0[v19 + 36190], v20 | (1LL << v16), v20) );
			//       }
			//       m_lightingKernel = (unsigned int)this.fields.m_lightingKernel;
			//       if ( !v53 )
			//         sub_1802DC2C8(m_lightingKernel, v16);
			//       LODWORD(v53[1].monitor) = m_lightingKernel;
			//       v22 = (ComputeBufferHandle *)v53;
			//       v23 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
			//               &v58,
			//               &input.binningBufferHandle,
			//               0LL);
			//       if ( !v22 )
			//         sub_1802DC2C8(v25, v24);
			//       v22[6] = v23;
			//       v26 = (ComputeBufferHandle *)v53;
			//       v27 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v58, &inputa, 0LL);
			//       if ( !v26 )
			//         sub_1802DC2C8(v29, v28);
			//       v26[5] = v27;
			//       v30 = v53;
			//       m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//       if ( !m_RenderGraphContext )
			//         sub_1802DC2C8(v29, v28);
			//       p_renderContext = &m_RenderGraphContext.fields.renderContext;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                          (CBHandle *)&desc,
			//                          p_renderContext,
			//                          160,
			//                          0LL);
			//       ptr = (MonitorData *)ConstantBuffer.ptr;
			//       if ( !v30 )
			//         sub_1802DC2C8(v35, v34);
			//       *(Object *)((char *)v30 + 56) = *(Object *)&ConstantBuffer.bufferId;
			//       v30[4].monitor = ptr;
			//       *(_QWORD *)&desc.count = 0LL;
			//       *(_QWORD *)&desc.type = &v54;
			//       try
			//       {
			//         p_ivInput = (Void *)&input.ivInput;
			//         v54 = &input.ivInput;
			//         if ( !v53 )
			//           sub_1802DC2C8(0LL, p_ivInput);
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v53[4].monitor, p_ivInput, 160LL, 0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v59 )
			//       {
			//         v38 = &v52;
			//         *(Il2CppExceptionWrapper *)&desc.count = (Il2CppExceptionWrapper)v59.ex;
			//         v54 = 0LL;
			//         v39 = *(_QWORD *)&desc.count;
			//         if ( *(_QWORD *)&desc.count )
			//           sub_18000F780(*(_QWORD *)&desc.count);
			//         v14 = camera;
			//         goto LABEL_22;
			//       }
			//       v54 = 0LL;
			// LABEL_22:
			//       if ( !v14 )
			//         sub_1802DC2C8(v39, v38);
			//       v40 = v14.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       ASMManager = HG::Rendering::Runtime::HGASMManager::GetASMManager(v40, 0LL);
			//       v43 = v53;
			//       if ( !ASMManager )
			//         sub_1802DC2C8(v42, v53);
			//       m_asmShadowMapRT = (Object__Class *)ASMManager.fields.m_asmShadowMapRT;
			//       if ( !v53 )
			//         sub_1802DC2C8(m_asmShadowMapRT, 0LL);
			//       v53[2].klass = m_asmShadowMapRT;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v45 = ((unsigned __int64)&v43[2] >> 12) & 0x1FFFFF;
			//         v46 = (unsigned __int64)v45 >> 6;
			//         v47 = v45 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v46 + 36190]);
			//         do
			//           v48 = qword_18D6405E0[v46 + 36190];
			//         while ( v48 != _InterlockedCompareExchange64(&qword_18D6405E0[v46 + 36190], v48 | (1LL << v47), v48) );
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v58,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor.static_fields.s_renderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v60 )
			//     {
			//       v56.m_RenderPass = (HGRenderGraphPass *)v60.ex;
			//       sub_180222690(&v56);
			//       return;
			//     }
			//     sub_180222690(&v56);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2750, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v51, v50);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1007(
			//     Patch,
			//     (Object *)this,
			//     input,
			//     output,
			//     (Object *)renderGraph,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ParticleLightingPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2751, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2751, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ParticleLightingPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2752, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2752, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ParticleLightingPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2753, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2753, 0LL);
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
			// void HG::Rendering::Runtime::ParticleLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ParticleLightingPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2754, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2754, 0LL);
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
		internal static readonly int LIGHTING_PARTICLE_POSITIONS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		internal static readonly int COMPUTE_LIGHTING_RESULTS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		internal static readonly int BINNING_BUFFER;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		internal static readonly int OUT_LIGHTING_RESULTS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		internal static readonly int IV_INPUT;

		private const int THREAD_COUNT = 64;

		private const int MAX_PARTICLE_COUNT = 4096;

		private ComputeShader m_lightingCS;

		private int m_lightingKernel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<ParticleLightingPassConstructor.ParticleLightingPassData> s_renderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 168)]
		public struct PassInput
		{
			internal ComputeBufferHandle binningBufferHandle;

			internal ParticleLightingIVInput ivInput;
		}

		public struct PassOutput
		{
		}

		public class ParticleLightingPassData
		{
			public ParticleLightingPassData()
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

			internal ComputeShader lightingCS;

			internal int lightingKernel;

			internal RTHandle asmShadowMapRT;

			internal ComputeBufferHandle lightingResultBuffer;

			internal ComputeBufferHandle binningBufferHandle;

			internal CBHandle ivInputCBHandle;
		}
	}
}
