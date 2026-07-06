using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class DepthPyramidRenderingPass : IPassConstructor
	{
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle depthPyramidTexture
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

		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle prevDepthPyramidTexture
		{
			get
			{
				// // Nullable`1[Int64] get_To()
				// Nullable_1_Int64_ *System::Net::Http::Headers::ContentRangeHeaderValue::get_To(
				//         Nullable_1_Int64_ *__return_ptr retstr,
				//         ContentRangeHeaderValue *this,
				//         MethodInfo *method)
				// {
				//   Nullable_1_Int64_ *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields._To_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal DepthPyramidRenderingPass(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // DepthPyramidRenderingPass(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::DepthPyramidRenderingPass::DepthPyramidRenderingPass(
			//         DepthPyramidRenderingPass *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   DepthPyramidNoLDSRenderingPass *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   DepthPyramidNoLDSRenderingPass *v8; // rsi
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   DepthPyramidLDSRenderingPass *v12; // rax
			//   DepthPyramidLDSRenderingPass *v13; // rsi
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   DepthPyramidCustomMipsRenderingPass *v17; // rax
			//   DepthPyramidCustomMipsRenderingPass *v18; // rsi
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   HGRenderPathBase_HGRenderPathResources v22; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v23; // [rsp+30h] [rbp-8h]
			//   String__Array *v24; // [rsp+60h] [rbp+28h]
			//   String *v25; // [rsp+68h] [rbp+30h]
			//   MethodInfo *v26; // [rsp+70h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDA70 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA70 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, resources);
			//   this.fields.m_depthPyramidTexture = *(TextureHandle *)sub_182E7CCD0(&v22);
			//   this.fields.m_prevDepthPyramidTexture = *(TextureHandle *)sub_182E7CCD0(&v22);
			//   v5 = (DepthPyramidNoLDSRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass);
			//   v8 = v5;
			//   if ( !v5 )
			//     goto LABEL_9;
			//   v22 = *resources;
			//   HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::DepthPyramidNoLDSRenderingPass(v5, &v22, 0LL);
			//   this.fields.m_depthPyramidNoLDSRenderingPass = v8;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields,
			//     v9,
			//     v10,
			//     v11,
			//     (String__Array *)v22.defaultResources,
			//     (String *)v22.settingParameters,
			//     v23);
			//   v12 = (DepthPyramidLDSRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass);
			//   v13 = v12;
			//   if ( !v12
			//     || (v22 = *resources,
			//         HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::DepthPyramidLDSRenderingPass(v12, &v22, 0LL),
			//         this.fields.m_depthPyramidLDSRenderingPass = v13,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_depthPyramidLDSRenderingPass,
			//           v14,
			//           v15,
			//           v16,
			//           (String__Array *)v22.defaultResources,
			//           (String *)v22.settingParameters,
			//           v23),
			//         v17 = (DepthPyramidCustomMipsRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass),
			//         (v18 = v17) == 0LL) )
			//   {
			// LABEL_9:
			//     sub_180B536AC(v7, v6);
			//   }
			//   v22 = *resources;
			//   HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::DepthPyramidCustomMipsRenderingPass(v17, &v22, 0LL);
			//   this.fields.m_depthPyramidCustomMipsRenderingPass = v18;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_depthPyramidCustomMipsRenderingPass, v19, v20, v21, v24, v25, v26);
			// }
			// 
		}

		internal void ConstructPass(ref DepthPyramidRenderingPass.PassInput input, ref DepthPyramidRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void ConstructPass(DepthPyramidRenderingPass+PassInput ByRef, DepthPyramidRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::DepthPyramidRenderingPass::ConstructPass(
			//         DepthPyramidRenderingPass *this,
			//         DepthPyramidRenderingPass_PassInput *input,
			//         DepthPyramidRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   DepthPyramidCustomMipsRenderingPass *m_depthPyramidCustomMipsRenderingPass; // rcx
			//   DepthPyramidCustomMipsRenderingPass *v12; // rax
			//   TextureHandle depthTexture; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2580, 0LL) )
			//   {
			//     m_depthPyramidCustomMipsRenderingPass = this.fields.m_depthPyramidCustomMipsRenderingPass;
			//     if ( m_depthPyramidCustomMipsRenderingPass )
			//     {
			//       depthTexture = input.depthTexture;
			//       HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::Render(
			//         m_depthPyramidCustomMipsRenderingPass,
			//         renderGraph,
			//         hgCamera,
			//         &depthTexture,
			//         0LL);
			//       v12 = this.fields.m_depthPyramidCustomMipsRenderingPass;
			//       if ( v12 )
			//       {
			//         this.fields.m_depthPyramidTexture = v12.fields.m_depthPyramidTexture;
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_depthPyramidCustomMipsRenderingPass, v10);
			//   }
			//   m_depthPyramidCustomMipsRenderingPass = (DepthPyramidCustomMipsRenderingPass *)IFix::WrappersManagerImpl::GetPatch(
			//                                                                                    2580,
			//                                                                                    0LL);
			//   if ( !m_depthPyramidCustomMipsRenderingPass )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_945(
			//     (ILFixDynamicMethodWrapper_2 *)m_depthPyramidCustomMipsRenderingPass,
			//     (Object *)this,
			//     input,
			//     output,
			//     (Object *)renderGraph,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DepthPyramidRenderingPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2581, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2581, 0LL);
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
			// void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DepthPyramidRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2582, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2582, 0LL);
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
			// void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DepthPyramidRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   HGRenderGraph *renderGraph; // rdx
			//   TextureHandle *p_m_prevDepthPyramidTexture; // r8
			//   TextureHandle *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919538 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FA068);
			//     byte_18D919538 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2583, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_depthPyramidTexture = *(TextureHandle *)sub_182E7CCD0(&v10);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_prevDepthPyramidTexture, 0LL) )
			//       {
			//         renderGraph = input.renderGraph;
			//         if ( renderGraph )
			//         {
			//           p_m_prevDepthPyramidTexture = &this.fields.m_prevDepthPyramidTexture;
			//           goto LABEL_12;
			//         }
			// LABEL_15:
			//         sub_180B536AC(v5, renderGraph);
			//       }
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_depthPyramidTexture, 0LL) )
			//       {
			//         renderGraph = input.renderGraph;
			//         if ( renderGraph )
			//         {
			//           p_m_prevDepthPyramidTexture = &this.fields.m_depthPyramidTexture;
			// LABEL_12:
			//           v8 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                  &v10,
			//                  renderGraph,
			//                  p_m_prevDepthPyramidTexture,
			//                  1,
			//                  (String *)"Depth Pyramid",
			//                  0LL);
			//           goto LABEL_13;
			//         }
			//         goto LABEL_15;
			//       }
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v8 = (TextureHandle *)sub_182E7CCD0(&v10);
			// LABEL_13:
			//     this.fields.m_prevDepthPyramidTexture = *v8;
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2583, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DepthPyramidRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2584, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2584, 0LL);
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

		private DepthPyramidNoLDSRenderingPass m_depthPyramidNoLDSRenderingPass;

		private DepthPyramidLDSRenderingPass m_depthPyramidLDSRenderingPass;

		private DepthPyramidCustomMipsRenderingPass m_depthPyramidCustomMipsRenderingPass;

		private TextureHandle m_depthPyramidTexture;

		private TextureHandle m_prevDepthPyramidTexture;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassInput
		{
			public TextureHandle depthTexture;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			public TextureHandle depthPyramidTexture;
		}
	}
}
