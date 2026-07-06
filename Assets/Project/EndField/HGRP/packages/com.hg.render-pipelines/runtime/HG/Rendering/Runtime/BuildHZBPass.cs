using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class BuildHZBPass : IPassConstructor
	{
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle HZBTexture
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

		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle prevHZBTexture
		{
			get
			{
				// // UIRenderDevice+DeviceToFree get_Value()
				// UIRenderDevice_DeviceToFree *System::Collections::Generic::LinkedListNode<UnityEngine::UIElements::UIR::UIRenderDevice::DeviceToFree>::get_Value(
				//         UIRenderDevice_DeviceToFree *__return_ptr retstr,
				//         LinkedListNode_1_UnityEngine_UIElements_UIR_UIRenderDevice_DeviceToFree_ *this,
				//         MethodInfo *method)
				// {
				//   UIRenderDevice_DeviceToFree *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.item;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal BuildHZBPass(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // BuildHZBPass(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::BuildHZBPass::BuildHZBPass(
			//         BuildHZBPass *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   __int64 v6; // rcx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   TextureHandle v9; // xmm0
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   _BYTE v12[24]; // [rsp+20h] [rbp-18h] BYREF
			//   String__Array *v13; // [rsp+60h] [rbp+28h]
			//   String *v14; // [rsp+68h] [rbp+30h]
			//   MethodInfo *v15; // [rsp+70h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDA93 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA93 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, resources);
			//   this.fields.m_HZBTexture = *(TextureHandle *)sub_182E7CCD0(v12);
			//   v9 = *(TextureHandle *)sub_182E7CCD0(v12);
			//   defaultResources = resources.defaultResources;
			//   this.fields.m_prevHZBTexture = v9;
			//   if ( !defaultResources || (shaders = defaultResources.fields.shaders) == 0LL )
			//     sub_180B536AC(v6, v5);
			//   this.fields.m_computeShader = shaders.fields.buildHZBCS;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v5, v7, v8, v13, v14, v15);
			// }
			// 
		}

		internal void ConstructPass(ref BuildHZBPass.PassInput input, ref BuildHZBPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void ConstructPass(BuildHZBPass+PassInput ByRef, BuildHZBPass+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::BuildHZBPass::ConstructPass(
			//         BuildHZBPass *this,
			//         BuildHZBPass_PassInput *input,
			//         BuildHZBPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Object *v13; // rdi
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   TextureHandle v16; // xmm0
			//   Object *v17; // rcx
			//   ResourceHandle *v18; // rbx
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   int32_t PowerOfTwo; // edi
			//   int32_t v22; // eax
			//   unsigned __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   Object *v25; // rax
			//   Object__Class *m_computeShader; // rcx
			//   unsigned __int64 v27; // r8
			//   signed __int64 v28; // rtt
			//   int32_t monitor; // edi
			//   int32_t monitor_high; // ebx
			//   __int128 v31; // xmm2
			//   __int128 v32; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v34; // r8
			//   signed __int64 v35; // rtt
			//   Object *v36; // rbx
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   TextureHandle v39; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   Object *v43; // [rsp+40h] [rbp-1A8h] BYREF
			//   TextureHandle v44; // [rsp+48h] [rbp-1A0h] BYREF
			//   HGRenderGraphBuilder v45; // [rsp+58h] [rbp-190h] BYREF
			//   HGRenderGraphBuilder v46; // [rsp+78h] [rbp-170h] BYREF
			//   __int128 v47; // [rsp+A0h] [rbp-148h] BYREF
			//   __int128 v48; // [rsp+B0h] [rbp-138h]
			//   __int128 v49; // [rsp+C0h] [rbp-128h]
			//   __int128 v50; // [rsp+D0h] [rbp-118h] BYREF
			//   __int128 v51; // [rsp+E0h] [rbp-108h]
			//   Color v52; // [rsp+F0h] [rbp-F8h]
			//   Il2CppExceptionWrapper *v53; // [rsp+100h] [rbp-E8h] BYREF
			//   TextureDesc v54; // [rsp+110h] [rbp-D8h] BYREF
			//   TextureDesc v55; // [rsp+170h] [rbp-78h] BYREF
			// 
			//   if ( !byte_18D919578 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BuildHZBPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BuildHZBPass::PassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD438);
			//     sub_18003C530(&off_18D4FD420);
			//     byte_18D919578 = 1;
			//   }
			//   v43 = 0LL;
			//   sub_1802F01E0(&v55, 0LL, 96LL);
			//   sub_1802F01E0(&v47, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2688, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2688, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v42, v41);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_984(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			//   else if ( input.buildHZB )
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x25u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v45,
			//       renderGraph,
			//       (String *)"Build HZB",
			//       &v43,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BuildHZBPass::PassData>);
			//     v46 = v45;
			//     v45.m_RenderPass = 0LL;
			//     v45.m_Resources = (HGRenderGraphResourceRegistry *)&v46;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v46, 0, 0LL);
			//       v13 = v43;
			//       v16 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v44, &v46, &input.depthTexture, 0LL);
			//       if ( !v13 )
			//         sub_1802DC2C8(v15, v14);
			//       v13[2] = (Object)v16;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v15, v14);
			//       v17 = v43;
			//       if ( !v43 )
			//         sub_1802DC2C8(0LL, v14);
			//       v43[1].klass = (Object__Class *)hgCamera.fields._sceneRTSize_k__BackingField;
			//       v18 = (ResourceHandle *)v43;
			//       if ( !v43 )
			//         sub_1802DC2C8(v17, v14);
			//       PowerOfTwo = UnityEngine::Mathf::NextPowerOfTwo((LODWORD(v43[1].klass) + 1) / 2, 0LL);
			//       if ( !v43 )
			//         sub_1802DC2C8(v20, v19);
			//       v22 = UnityEngine::Mathf::NextPowerOfTwo((HIDWORD(v43[1].klass) + 1) / 2, 0LL);
			//       v44.handle.m_Value = PowerOfTwo;
			//       v44.handle._type_k__BackingField = v22;
			//       if ( !v18 )
			//         sub_1802DC2C8(v24, v23);
			//       v18[3] = v44.handle;
			//       v25 = v43;
			//       m_computeShader = (Object__Class *)this.fields.m_computeShader;
			//       if ( !v43 )
			//         sub_1802DC2C8(m_computeShader, v23);
			//       v43[4].klass = m_computeShader;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v27 = (((unsigned __int64)&v25[4] >> 12) & 0x1FFFFF) >> 6;
			//         v23 = ((unsigned __int64)&v25[4] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v27 + 36190]);
			//         do
			//         {
			//           m_computeShader = (Object__Class *)(qword_18D6405E0[v27 + 36190] | (1LL << v23));
			//           v28 = qword_18D6405E0[v27 + 36190];
			//         }
			//         while ( v28 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v27 + 36190],
			//                          (signed __int64)m_computeShader,
			//                          v28) );
			//       }
			//       if ( !v43 )
			//         sub_1802DC2C8(m_computeShader, v23);
			//       monitor = (int32_t)v43[1].monitor;
			//       monitor_high = HIDWORD(v43[1].monitor);
			//       sub_1802F01E0(&v54, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v54, monitor, monitor_high, 0LL);
			//       v31 = *(_OWORD *)&v54.width;
			//       v47 = *(_OWORD *)&v54.width;
			//       v48 = *(_OWORD *)&v54.colorFormat;
			//       v49 = *(_OWORD *)&v54.enableRandomWrite;
			//       *(_QWORD *)&v50 = *(_QWORD *)&v54.bindTextureMS;
			//       v32 = *(_OWORD *)&v54.fastMemoryDesc.inFastMemory;
			//       v51 = *(_OWORD *)&v54.fastMemoryDesc.inFastMemory;
			//       clearColor = v54.clearColor;
			//       v52 = v54.clearColor;
			//       *((_QWORD *)&v50 + 1) = "HZB";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v34 = ((((unsigned __int64)&v50 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v34 + 36190]);
			//         do
			//           v35 = qword_18D6405E0[v34 + 36190];
			//         while ( v35 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v34 + 36190],
			//                          v35 | (1LL << ((((unsigned __int64)&v50 + 8) >> 12) & 0x3F)),
			//                          v35) );
			//         clearColor = v52;
			//         v32 = v51;
			//         v31 = v47;
			//       }
			//       LODWORD(v48) = 49;
			//       LOWORD(v49) = 257;
			//       BYTE2(v49) = 0;
			//       *(_OWORD *)&v55.width = v31;
			//       *(_OWORD *)&v55.colorFormat = v48;
			//       *(_OWORD *)&v55.enableRandomWrite = v49;
			//       *(_OWORD *)&v55.bindTextureMS = v50;
			//       *(_OWORD *)&v55.fastMemoryDesc.inFastMemory = v32;
			//       v55.clearColor = clearColor;
			//       this.fields.m_HZBTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                      &v44,
			//                                      renderGraph,
			//                                      &v55,
			//                                      0LL);
			//       v36 = v43;
			//       v39 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//                &v44,
			//                &v46,
			//                &this.fields.m_HZBTexture,
			//                0LL);
			//       if ( !v36 )
			//         sub_1802DC2C8(v38, v37);
			//       v36[3] = (Object)v39;
			//       if ( !v43 )
			//         sub_1802DC2C8(v38, v37);
			//       *output = (BuildHZBPass_PassOutput)v43[3];
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v46,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::BuildHZBPass.static_fields.s_RenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BuildHZBPass::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v53 )
			//     {
			//       v45.m_RenderPass = (HGRenderGraphPass *)v53.ex;
			//     }
			//     sub_180222690(&v45);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     this.fields.m_HZBTexture = *(TextureHandle *)sub_182E7CCD0(&v45);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         BuildHZBPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2689, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2689, 0LL);
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
			// void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         BuildHZBPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   _BYTE v8[24]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919579 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919579 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2690, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2690, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     this.fields.m_HZBTexture = *(TextureHandle *)sub_182E7CCD0(v8);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         BuildHZBPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   HGRenderGraph *renderGraph; // rdx
			//   TextureHandle *p_m_HZBTexture; // r8
			//   TextureHandle *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91957A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD420);
			//     byte_18D91957A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2691, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_HZBTexture = *(TextureHandle *)sub_182E7CCD0(&v10);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_HZBTexture, 0LL) )
			//       {
			//         renderGraph = input.renderGraph;
			//         if ( renderGraph )
			//         {
			//           p_m_HZBTexture = &this.fields.m_HZBTexture;
			// LABEL_14:
			//           v8 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                  &v10,
			//                  renderGraph,
			//                  p_m_HZBTexture,
			//                  1,
			//                  (String *)"HZB",
			//                  0LL);
			//           goto LABEL_15;
			//         }
			// LABEL_17:
			//         sub_180B536AC(v5, renderGraph);
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     }
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_prevHZBTexture, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v8 = (TextureHandle *)sub_182E7CCD0(&v10);
			// LABEL_15:
			//       this.fields.m_prevHZBTexture = *v8;
			//       return;
			//     }
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       p_m_HZBTexture = &this.fields.m_prevHZBTexture;
			//       goto LABEL_14;
			//     }
			//     goto LABEL_17;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2691, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         BuildHZBPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2692, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2692, 0LL);
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

		private ComputeShader m_computeShader;

		private TextureHandle m_HZBTexture;

		private TextureHandle m_prevHZBTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<BuildHZBPass.PassData> s_RenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
		internal struct PassInput
		{
			public TextureHandle depthTexture;

			public bool buildHZB;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			public TextureHandle HZBTexture;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		public struct CBufferData
		{
			public Vector4 textureSize;

			public Vector4 parentSize;

			public Vector4 param0;
		}

		private class PassData
		{
			public PassData()
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

			public Vector2Int depthTextureSize;

			public Vector2Int HZBTextureSize;

			public TextureHandle depthTexture;

			public TextureHandle HZBTexture;

			public ComputeShader computeShader;
		}
	}
}
