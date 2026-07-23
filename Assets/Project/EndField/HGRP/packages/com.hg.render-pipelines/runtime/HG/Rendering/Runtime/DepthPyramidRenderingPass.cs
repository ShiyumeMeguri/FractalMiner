using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class DepthPyramidRenderingPass : IPassConstructor // TypeDefIndex: 38246
	{
		// Fields
		private DepthPyramidNoLDSRenderingPass m_depthPyramidNoLDSRenderingPass; // 0x10
		private DepthPyramidLDSRenderingPass m_depthPyramidLDSRenderingPass; // 0x18
		private DepthPyramidCustomMipsRenderingPass m_depthPyramidCustomMipsRenderingPass; // 0x20
		private TextureHandle m_depthPyramidTexture; // 0x28
		private TextureHandle m_prevDepthPyramidTexture; // 0x38
	
		// Properties
		public TextureHandle depthPyramidTexture { get => default; } // 0x0000000189BA4D40-0x0000000189BA4DA8 
		// TextureHandle get_depthPyramidTexture()
		TextureHandle *HG::Rendering::Runtime::DepthPyramidRenderingPass::get_depthPyramidTexture(
		        TextureHandle *__return_ptr retstr,
		        DepthPyramidRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_depthPyramidTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3106, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3106, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_depthPyramidTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_depthPyramidTexture = this->fields.m_depthPyramidTexture;
		  }
		  result = retstr;
		  *retstr = m_depthPyramidTexture;
		  return result;
		}
		
		public TextureHandle prevDepthPyramidTexture { get => default; } // 0x0000000189BA4DA8-0x0000000189BA4E10 
		// TextureHandle get_prevDepthPyramidTexture()
		TextureHandle *HG::Rendering::Runtime::DepthPyramidRenderingPass::get_prevDepthPyramidTexture(
		        TextureHandle *__return_ptr retstr,
		        DepthPyramidRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_prevDepthPyramidTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3107, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3107, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_prevDepthPyramidTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_prevDepthPyramidTexture = this->fields.m_prevDepthPyramidTexture;
		  }
		  result = retstr;
		  *retstr = m_prevDepthPyramidTexture;
		  return result;
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38244
		{
			// Fields
			public TextureHandle depthTexture; // 0x00
		}
	
		internal struct PassOutput // TypeDefIndex: 38245
		{
			// Fields
			public TextureHandle depthPyramidTexture; // 0x00
		}
	
		// Constructors
		public DepthPyramidRenderingPass() {} // Dummy constructor
		internal DepthPyramidRenderingPass(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB3F0-0x0000000182EDB500
		// DepthPyramidRenderingPass(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::DepthPyramidRenderingPass::DepthPyramidRenderingPass(
		        DepthPyramidRenderingPass *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  DepthPyramidCustomMipsRenderingPass *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  DepthPyramidNoLDSRenderingPass *v8; // rdi
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  DepthPyramidCustomMipsRenderingPass *v12; // rax
		  DepthPyramidLDSRenderingPass *v13; // rdi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  DepthPyramidCustomMipsRenderingPass *v17; // rax
		  DepthPyramidCustomMipsRenderingPass *v18; // rdi
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  HGRenderPathBase_HGRenderPathResources v22; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v23; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                          (TextureHandle *)&v22,
		                                          0LL);
		  this->fields.m_prevDepthPyramidTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                              (TextureHandle *)&v22,
		                                              0LL);
		  v5 = (DepthPyramidCustomMipsRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass);
		  v8 = (DepthPyramidNoLDSRenderingPass *)v5;
		  if ( !v5 )
		    goto LABEL_4;
		  v22 = *resources;
		  HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::DepthPyramidCustomMipsRenderingPass(v5, &v22, 0LL);
		  this->fields.m_depthPyramidNoLDSRenderingPass = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v9, v10, v11, (MethodInfo *)v22.defaultResources);
		  v12 = (DepthPyramidCustomMipsRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass);
		  v13 = (DepthPyramidLDSRenderingPass *)v12;
		  if ( !v12
		    || (v22 = *resources,
		        HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::DepthPyramidCustomMipsRenderingPass(v12, &v22, 0LL),
		        this->fields.m_depthPyramidLDSRenderingPass = v13,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this->fields.m_depthPyramidLDSRenderingPass,
		          v14,
		          v15,
		          v16,
		          (MethodInfo *)v22.defaultResources),
		        v17 = (DepthPyramidCustomMipsRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass),
		        (v18 = v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v7, v6);
		  }
		  v22 = *resources;
		  HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::DepthPyramidCustomMipsRenderingPass(v17, &v22, 0LL);
		  this->fields.m_depthPyramidCustomMipsRenderingPass = v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_depthPyramidCustomMipsRenderingPass, v19, v20, v21, v23);
		}
		
	
		// Methods
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BA4AB4-0x0000000189BA4B88
		// Void ConstructPass(DepthPyramidRenderingPass+PassInput ByRef, DepthPyramidRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::DepthPyramidRenderingPass::ConstructPass(
		        DepthPyramidRenderingPass *this,
		        DepthPyramidRenderingPass_PassInput *input,
		        DepthPyramidRenderingPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  DepthPyramidCustomMipsRenderingPass *v10; // rdx
		  DepthPyramidCustomMipsRenderingPass *m_depthPyramidCustomMipsRenderingPass; // rcx
		  TextureHandle depthTexture; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3108, 0LL) )
		  {
		    m_depthPyramidCustomMipsRenderingPass = this->fields.m_depthPyramidCustomMipsRenderingPass;
		    if ( m_depthPyramidCustomMipsRenderingPass )
		    {
		      depthTexture = input->depthTexture;
		      HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::Render(
		        m_depthPyramidCustomMipsRenderingPass,
		        renderGraph,
		        hgCamera,
		        &depthTexture,
		        0LL);
		      v10 = this->fields.m_depthPyramidCustomMipsRenderingPass;
		      if ( v10 )
		      {
		        this->fields.m_depthPyramidTexture = *HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::get_depthPyramidTexture(
		                                                &depthTexture,
		                                                v10,
		                                                0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_depthPyramidCustomMipsRenderingPass, v10);
		  }
		  m_depthPyramidCustomMipsRenderingPass = (DepthPyramidCustomMipsRenderingPass *)IFix::WrappersManagerImpl::GetPatch(
		                                                                                   3108,
		                                                                                   0LL);
		  if ( !m_depthPyramidCustomMipsRenderingPass )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(
		    (ILFixDynamicMethodWrapper_2 *)m_depthPyramidCustomMipsRenderingPass,
		    (Object *)this,
		    input,
		    output,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BA4CEC-0x0000000189BA4D40
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DepthPyramidRenderingPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3109, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3109, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BA4C98-0x0000000189BA4CEC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DepthPyramidRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3110, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3110, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BA4B88-0x0000000189BA4C98
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DepthPyramidRenderingPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  HGRenderGraph *renderGraph; // rdx
		  TextureHandle *p_m_prevDepthPyramidTexture; // r8
		  TextureHandle *nullHandle; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3111, 0LL) )
		  {
		    if ( input->passSkipped )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_prevDepthPyramidTexture, 0LL) )
		      {
		        renderGraph = input->renderGraph;
		        if ( renderGraph )
		        {
		          p_m_prevDepthPyramidTexture = &this->fields.m_prevDepthPyramidTexture;
		          goto LABEL_10;
		        }
		LABEL_13:
		        sub_1800D8260(v5, renderGraph);
		      }
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_depthPyramidTexture, 0LL) )
		      {
		        renderGraph = input->renderGraph;
		        if ( renderGraph )
		        {
		          p_m_prevDepthPyramidTexture = &this->fields.m_depthPyramidTexture;
		LABEL_10:
		          nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                         &v10,
		                         renderGraph,
		                         p_m_prevDepthPyramidTexture,
		                         1,
		                         (String *)"Depth Pyramid",
		                         0LL);
		          goto LABEL_11;
		        }
		        goto LABEL_13;
		      }
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		LABEL_11:
		    this->fields.m_prevDepthPyramidTexture = *nullHandle;
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3111, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D806B0-0x0000000184D806E0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DepthPyramidRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DepthPyramidRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3112, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3112, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
	}
}
