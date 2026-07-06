using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class BakeFogLutPassConstructor : IPassConstructor
	{
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle FogBakeLutTexture
		{
			get
			{
				// // Vector4 get_value()
				// Vector4 *UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::get_value(
				//         Vector4 *__return_ptr retstr,
				//         VolumeParameter_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_Value;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal BakeFogLutPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // BakeFogLutPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassConstructor(
			//         BakeFogLutPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
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
			//   if ( !resources.defaultResources
			//     || (shaders = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector )
			//   {
			//     sub_180B536AC(this, materialCollector);
			//   }
			//   this.fields.m_bakeFogLutMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                         materialCollector,
			//                                         shaders.fields.bakeFogLutPS,
			//                                         0,
			//                                         0LL);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v6, v7, v8, v9, v10, v11);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         BakeFogLutPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2495, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2495, 0LL);
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
			// void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         BakeFogLutPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2496, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2496, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref BakeFogLutPassConstructor.PassInput input, ref BakeFogLutPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(BakeFogLutPassConstructor+PassInput ByRef, BakeFogLutPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::BakeFogLutPassConstructor::ConstructPass(
			//         BakeFogLutPassConstructor *this,
			//         BakeFogLutPassConstructor_PassInput *input,
			//         BakeFogLutPassConstructor_PassOutput *output,
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
			//   Object *v18; // r9
			//   MonitorData *m_bakeFogLutMaterial; // rcx
			//   unsigned int v20; // r9d
			//   unsigned __int64 v21; // r8
			//   char v22; // r9
			//   signed __int64 v23; // rtt
			//   HGAtmosphereSettingParameters *atmosphereParams; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   Object *v28; // [rsp+40h] [rbp-128h] BYREF
			//   TextureHandle v29; // [rsp+48h] [rbp-120h] BYREF
			//   HGRenderGraphBuilder v30; // [rsp+58h] [rbp-110h] BYREF
			//   HGRenderGraphBuilder v31; // [rsp+78h] [rbp-F0h] BYREF
			//   Il2CppExceptionWrapper *v32; // [rsp+98h] [rbp-D0h] BYREF
			//   TextureDesc v33; // [rsp+A0h] [rbp-C8h] BYREF
			//   TextureDesc v34; // [rsp+100h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D9194FE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4F5A00);
			//     byte_18D9194FE = 1;
			//   }
			//   v28 = 0LL;
			//   sub_1802F01E0(&v33, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2497, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2497, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v27, v26);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_918(
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
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(camera, 0LL) )
			//     {
			//       v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x2Fu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v12, v11);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v30,
			//         renderGraph,
			//         (String *)"Bake Fog LUT",
			//         &v28,
			//         v10,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
			//       v31 = v30;
			//       v30.m_RenderPass = 0LL;
			//       v30.m_Resources = (HGRenderGraphResourceRegistry *)&v31;
			//       try
			//       {
			//         v14 = v28;
			//         if ( !v28 )
			//           sub_1802DC2C8(0LL, v13);
			//         v28[1].klass = (Object__Class *)camera;
			//         v15 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v16 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v16 + 36190]);
			//           do
			//             v17 = qword_18D6405E0[v16 + 36190];
			//           while ( v17 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v16 + 36190],
			//                            v17 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
			//                            v17) );
			//           v15 = dword_18D8E43F8;
			//         }
			//         v18 = v28;
			//         m_bakeFogLutMaterial = (MonitorData *)this.fields.m_bakeFogLutMaterial;
			//         if ( !v28 )
			//           sub_1802DC2C8(m_bakeFogLutMaterial, qword_18D6405E0);
			//         v28[1].monitor = m_bakeFogLutMaterial;
			//         if ( v15 )
			//         {
			//           v20 = ((unsigned __int64)&v18[1].monitor >> 12) & 0x1FFFFF;
			//           v21 = (unsigned __int64)v20 >> 6;
			//           v22 = v20 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v21 + 36190]);
			//           do
			//             v23 = qword_18D6405E0[v21 + 36190];
			//           while ( v23 != _InterlockedCompareExchange64(&qword_18D6405E0[v21 + 36190], v23 | (1LL << v22), v23) );
			//         }
			//         atmosphereParams = input.atmosphereParams;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//         v33 = *HG::Rendering::Runtime::HGAtmosphereRenderer::CreateBakeFogLutDesc(&v34, atmosphereParams, 0LL);
			//         this.fields.m_fogBakeLutTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                               &v29,
			//                                               renderGraph,
			//                                               &v33,
			//                                               0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v29,
			//           &v31,
			//           &this.fields.m_fogBakeLutTexture,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v31,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor.static_fields.s_bakeFogLutFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v32 )
			//       {
			//         v30.m_RenderPass = (HGRenderGraphPass *)v32.ex;
			//       }
			//       sub_180222690(&v30);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         BakeFogLutPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2498, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2498, 0LL);
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
			// void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         BakeFogLutPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2499, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2499, 0LL);
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

		private Material m_bakeFogLutMaterial;

		private TextureHandle m_fogBakeLutTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<BakeFogLutPassConstructor.BakeFogLutPassData> s_bakeFogLutFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal HGAtmosphereSettingParameters atmosphereParams;
		}

		internal struct PassOutput
		{
		}

		private class BakeFogLutPassData
		{
			public BakeFogLutPassData()
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

			public Material bakeFogLutMaterial;
		}
	}
}
