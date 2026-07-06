using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class LightShaftApplyPassConstructor : IPassConstructor
	{
		internal LightShaftApplyPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // LightShaftApplyPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassConstructor(
			//         LightShaftApplyPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !resources.defaultResources
			//     || (shaders = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector )
			//   {
			//     sub_180B536AC(this, materialCollector);
			//   }
			//   this.fields.m_lightShaftMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                         materialCollector,
			//                                         shaders.fields.lightShaftPS,
			//                                         0,
			//                                         0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v6, v7, v8, v9, v10);
			// }
			// 
		}

		private void LightShaftApplyPass(ref LightShaftApplyPassConstructor.PassInput input, HGRenderGraph renderGraph)
		{
			// // Void LightShaftApplyPass(LightShaftApplyPassConstructor+PassInput ByRef, HGRenderGraph)
			// // Hidden C++ exception states: #wind=2 #try_helpers=1
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPass(
			//         LightShaftApplyPassConstructor *this,
			//         LightShaftApplyPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v7; // rax
			//   ProfilingSampler *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rcx
			//   Object *v12; // rdx
			//   unsigned int v13; // edx
			//   unsigned __int64 v14; // r8
			//   char v15; // dl
			//   signed __int64 v16; // rtt
			//   Object *v17; // rbx
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   TextureHandle v20; // xmm0
			//   Object *v21; // rbx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   TextureHandle v24; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   Object *v28; // [rsp+50h] [rbp-B8h] BYREF
			//   Color v29; // [rsp+60h] [rbp-A8h] BYREF
			//   _QWORD v30[2]; // [rsp+70h] [rbp-98h] BYREF
			//   _QWORD v31[2]; // [rsp+80h] [rbp-88h] BYREF
			//   HGRenderGraphBuilder v32; // [rsp+90h] [rbp-78h] BYREF
			//   HGRenderGraphProfilingScope v33; // [rsp+B0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v34; // [rsp+C8h] [rbp-40h] BYREF
			//   HGRenderGraphBuilder v35; // [rsp+D8h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9195AC )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500CA0);
			//     byte_18D9195AC = 1;
			//   }
			//   memset(&v33, 0, sizeof(v33));
			//   memset(&v32, 0, sizeof(v32));
			//   v28 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2764, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2764, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v27, v26);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1012(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
			//   }
			//   else if ( input.enableLightShaft )
			//   {
			//     v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x9Fu,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//       &v33,
			//       renderGraph,
			//       v7,
			//       0LL);
			//     v31[0] = 0LL;
			//     v31[1] = &v33;
			//     v8 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0xA2u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_1802DC2C8(v10, v9);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v35,
			//       renderGraph,
			//       (String *)"Apply Light Shaft",
			//       &v28,
			//       v8,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
			//     v32 = v35;
			//     v30[0] = 0LL;
			//     v30[1] = &v32;
			//     try
			//     {
			//       v12 = v28;
			//       if ( !v28 )
			//         sub_1802DC2C8(v11, 0LL);
			//       v28[1].klass = (Object__Class *)this.fields.m_lightShaftMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v13 = ((unsigned __int64)&v12[1] >> 12) & 0x1FFFFF;
			//         v14 = (unsigned __int64)v13 >> 6;
			//         v15 = v13 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v14]);
			//         do
			//           v16 = qword_18D6870D0[v14];
			//         while ( v16 != _InterlockedCompareExchange64(&qword_18D6870D0[v14], v16 | (1LL << v15), v16) );
			//       }
			//       v17 = v28;
			//       v20 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v29,
			//                &v32,
			//                &input.lightShaftBlurResult,
			//                0LL);
			//       if ( !v17 )
			//         sub_1802DC2C8(v19, v18);
			//       *(TextureHandle *)&v17[1].monitor = v20;
			//       v21 = v28;
			//       v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                (TextureHandle *)&v29,
			//                &v32,
			//                &input.sceneColor,
			//                0LL);
			//       if ( !v21 )
			//         sub_1802DC2C8(v23, v22);
			//       *(TextureHandle *)&v21[2].monitor = v24;
			//       if ( !v28 )
			//         sub_1802DC2C8(v23, v22);
			//       v29 = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v35,
			//         &v32,
			//         (TextureHandle *)&v28[2].monitor,
			//         0,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         &v29,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v32,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor.static_fields.s_lightShaftApplyRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v34 )
			//     {
			//       v30[0] = v34.ex;
			//     }
			//     sub_180222690(v30);
			//     sub_180224750(v31);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         LightShaftApplyPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2765, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2765, 0LL);
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
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         LightShaftApplyPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2766, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2766, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref LightShaftApplyPassConstructor.PassInput input, ref LightShaftApplyPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(LightShaftApplyPassConstructor+PassInput ByRef, LightShaftApplyPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::ConstructPass(
			//         LightShaftApplyPassConstructor *this,
			//         LightShaftApplyPassConstructor_PassInput *input,
			//         LightShaftApplyPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !byte_18D9195AD )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     byte_18D9195AD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2767, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2767, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1013(
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
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     if ( HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(camera, 0LL) )
			//       HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPass(this, input, renderGraph, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         LightShaftApplyPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2768, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2768, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		private Material m_lightShaftMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly MaterialPropertyBlock s_lightShaftMaterialPropertyBlock;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<LightShaftApplyPassConstructor.LightShaftApplyPassData> s_lightShaftApplyRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly string[] s_lightShaftPingPongRTName;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle lightShaftBlurResult;

			internal bool enableLightShaft;
		}

		internal struct PassOutput
		{
		}

		private class LightShaftApplyPassData
		{
			public LightShaftApplyPassData()
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

			public Material lightShaftMaterial;

			public TextureHandle lightShaftBlurResult;

			public TextureHandle targetRT;
		}
	}
}
