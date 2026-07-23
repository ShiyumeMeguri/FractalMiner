using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class GPUDrivenCullingPassConstructor : IPassConstructor // TypeDefIndex: 38306
	{
		// Fields
		private static readonly RenderFunc<CullingPassData> s_cullingPassRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38302
		{
			// Fields
			public ComputeShader initShader; // 0x00
			public ComputeShader cullingShader; // 0x08
			public ComputeShader cmdGenShader; // 0x10
			public TextureHandle hzb; // 0x18
			public bool usePrevVP; // 0x28
			public bool disableHZBCulling; // 0x29
		}
	
		internal struct PassOutput // TypeDefIndex: 38303
		{
		}
	
		private class CullingPassData // TypeDefIndex: 38304
		{
			// Fields
			public ComputeShader initShader; // 0x10
			public ComputeShader cullingShader; // 0x18
			public TextureHandle hzb; // 0x20
			public uint hzbWidth; // 0x30
			public uint hzbHeight; // 0x34
			public HGCamera camera; // 0x38
			public bool usePrevVP; // 0x40
			public bool debugNoCulling; // 0x41
			public bool disableHZBCulling; // 0x42
	
			// Constructors
			public CullingPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		// Constructors
		public GPUDrivenCullingPassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
		static GPUDrivenCullingPassConstructor() {} // 0x0000000184D2CE80-0x0000000184D2CF10
		// GPUDrivenCullingPassConstructor()
		void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::cctor(MethodInfo *method)
		{
		  struct GPUDrivenCullingPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_GPUDrivenCullingPassConstructor_CullingPassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_GPUDrivenCullingPassConstructor_CullingPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::__c::__cctor_b__10_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor->static_fields->s_cullingPassRenderFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BAEE40-0x0000000189BAEE94
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        GPUDrivenCullingPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3200, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3200, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BAEDEC-0x0000000189BAEE40
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        GPUDrivenCullingPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3201, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3201, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BAE96C-0x0000000189BAED98
		// Void ConstructPass(GPUDrivenCullingPassConstructor+PassInput ByRef, GPUDrivenCullingPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::ConstructPass(
		        GPUDrivenCullingPassConstructor *this,
		        GPUDrivenCullingPassConstructor_PassInput *input,
		        GPUDrivenCullingPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  Object *v14; // rax
		  Object__Class *initShader; // rcx
		  __int64 v16; // rcx
		  unsigned __int64 v17; // r9
		  signed __int64 v18; // rtt
		  Object *v19; // r8
		  unsigned __int64 v20; // r8
		  unsigned __int64 v21; // r9
		  char v22; // r8
		  signed __int64 v23; // rtt
		  Object *v24; // r9
		  unsigned __int64 v25; // r9
		  unsigned __int64 v26; // r8
		  char v27; // r9
		  signed __int64 v28; // rtt
		  Object *v29; // rdi
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  TextureHandle v32; // xmm0
		  __int64 width; // rdx
		  __int64 height; // rcx
		  Object *v35; // rdi
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  TextureHandle v38; // xmm0
		  TextureDesc *TextureDescRef; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  Object *v43; // [rsp+40h] [rbp-68h] BYREF
		  TextureHandle v44; // [rsp+48h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v45; // [rsp+58h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v46; // [rsp+60h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v47; // [rsp+80h] [rbp-28h] BYREF
		
		  v43 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3202, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3202, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v42, v41);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1182(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xD7u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v46,
		      renderGraph,
		      (String *)"CullingPass",
		      &v43,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
		    v47 = v46;
		    v46.m_RenderPass = 0LL;
		    v46.m_Resources = (HGRenderGraphResourceRegistry *)&v47;
		    try
		    {
		      v14 = v43;
		      initShader = (Object__Class *)input->initShader;
		      if ( !v43 )
		        sub_1800D8250(initShader, v13);
		      v43[1].klass = initShader;
		      v16 = (unsigned int)dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v17 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v17 + 36190]);
		        do
		          v18 = qword_18F0BCBA0[v17 + 36190];
		        while ( v18 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v17 + 36190],
		                         v18 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
		                         v18) );
		        v16 = (unsigned int)dword_18F35FD08;
		      }
		      v19 = v43;
		      if ( !v43 )
		        sub_1800D8250(v16, qword_18F0BCBA0);
		      v43[1].monitor = (MonitorData *)input->cullingShader;
		      if ( (_DWORD)v16 )
		      {
		        v20 = ((unsigned __int64)&v19[1].monitor >> 12) & 0x1FFFFF;
		        v21 = v20 >> 6;
		        v22 = v20 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v21 + 36190]);
		        do
		          v23 = qword_18F0BCBA0[v21 + 36190];
		        while ( v23 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v21 + 36190], v23 | (1LL << v22), v23) );
		        v16 = (unsigned int)dword_18F35FD08;
		      }
		      v24 = v43;
		      if ( !v43 )
		        sub_1800D8250(v16, qword_18F0BCBA0);
		      v43[3].monitor = (MonitorData *)camera;
		      if ( (_DWORD)v16 )
		      {
		        v25 = ((unsigned __int64)&v24[3].monitor >> 12) & 0x1FFFFF;
		        v26 = v25 >> 6;
		        v27 = v25 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v26 + 36190]);
		        do
		          v28 = qword_18F0BCBA0[v26 + 36190];
		        while ( v28 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v26 + 36190], v28 | (1LL << v27), v28) );
		      }
		      v29 = v43;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v32 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v44, 0LL);
		      if ( !v29 )
		        sub_1800D8250(v31, v30);
		      v29[2] = (Object)v32;
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->hzb, 0LL) )
		      {
		        v35 = v43;
		        v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v44, &v47, &input->hzb, 0LL);
		        if ( !v35 )
		          sub_1800D8250(v37, v36);
		        v35[2] = (Object)v38;
		        if ( !v43 )
		          sub_1800D8250(v37, v36);
		        TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                           renderGraph,
		                           (TextureHandle *)&v43[2],
		                           0LL);
		        width = (unsigned int)TextureDescRef->width;
		        if ( !v43 )
		          sub_1800D8250(0LL, width);
		        LODWORD(v43[3].klass) = width;
		        height = (unsigned int)TextureDescRef->height;
		        if ( !v43 )
		          sub_1800D8250(height, width);
		        HIDWORD(v43[3].klass) = height;
		      }
		      else
		      {
		        if ( !v43 )
		          sub_1800D8250(height, width);
		        LODWORD(v43[3].klass) = 0;
		        if ( !v43 )
		          sub_1800D8250(height, width);
		        HIDWORD(v43[3].klass) = 0;
		      }
		      LOBYTE(height) = input->usePrevVP;
		      if ( !v43 )
		        sub_1800D8250(height, width);
		      LOBYTE(v43[4].klass) = height;
		      if ( !v43 )
		        sub_1800D8250(height, width);
		      BYTE1(v43[4].klass) = 0;
		      LOBYTE(height) = input->disableHZBCulling;
		      if ( !v43 )
		        sub_1800D8250(height, width);
		      BYTE2(v43[4].klass) = height;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v47,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor->static_fields->s_cullingPassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::CullingPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v45 )
		    {
		      v46.m_RenderPass = (HGRenderGraphPass *)v45->ex;
		    }
		    sub_180268AE0(&v46);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BAED98-0x0000000189BAEDEC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        GPUDrivenCullingPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3203, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3203, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80440-0x0000000184D80470
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        GPUDrivenCullingPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3204, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3204, 0LL);
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
