using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ClearStencilPass // TypeDefIndex: 38188
	{
		// Fields
		private Material m_ClearStencilBufferMaterial; // 0x10
	
		// Nested types
		private class ClearStencilPassData // TypeDefIndex: 38187
		{
			// Fields
			public Material clearStencilMaterial; // 0x10
			public TextureHandle depthBuffer; // 0x18
	
			// Constructors
			public ClearStencilPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public ClearStencilPass() {} // Dummy constructor
		internal ClearStencilPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPipelineRuntimeResources defaultResources) {} // 0x0000000189B90B00-0x0000000189B90B4C
		// ClearStencilPass(HGRenderPipelineMaterialCollector, HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::ClearStencilPass::ClearStencilPass(
		        ClearStencilPass *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( !defaultResources || (shaders = defaultResources->fields.shaders) == 0LL || !materialCollector )
		    sub_1800D8260(this, materialCollector);
		  this->fields.m_ClearStencilBufferMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                materialCollector,
		                                                shaders->fields.clearStencilBufferPS,
		                                                0,
		                                                0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v6, v7, v8, v9);
		}
		
	
		// Methods
		internal void ClearStencilBuffer(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthBuffer) {} // 0x0000000189B90A78-0x0000000189B90B00
		// Void ClearStencilBuffer(HGRenderGraph, HGCamera, TextureHandle)
		void HG::Rendering::Runtime::ClearStencilPass::ClearStencilBuffer(
		        ClearStencilPass *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *depthBuffer,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3027, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3027, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = *depthBuffer;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1092(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      &v12,
		      0LL);
		  }
		}
		
	}
}
