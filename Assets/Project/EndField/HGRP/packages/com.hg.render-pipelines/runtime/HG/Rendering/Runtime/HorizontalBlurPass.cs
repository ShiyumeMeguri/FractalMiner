using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class HorizontalBlurPass // TypeDefIndex: 38381
	{
		// Fields
		private static readonly RenderFunc<PassData> s_RenderFunc; // 0x00
	
		// Nested types
		internal struct HorizontalBlurCBData // TypeDefIndex: 38378
		{
			// Fields
			public Vector4 horizontalBlurSize; // 0x00
			public Vector4 horizontalBlurParams0; // 0x10
			public Vector4 horizontalBlurParams1; // 0x20
		}
	
		internal class PassData // TypeDefIndex: 38379
		{
			// Fields
			public TextureHandle source; // 0x10
			public Vector2Int renderSize; // 0x20
			public bool useBlurTarget; // 0x28
			public bool useBlurCenter; // 0x29
			public float radius; // 0x2C
			public float blurTargetAngleDeg; // 0x30
			public float blurCenterFadeWidth; // 0x34
			public Vector2 blurCenterUV; // 0x38
			public Material horizontalBlurMaterial; // 0x40
			public MaterialPropertyBlock mpb; // 0x48
	
			// Constructors
			public PassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		static HorizontalBlurPass() {} // 0x0000000189BC9F90-0x0000000189BCA014
		// HorizontalBlurPass()
		void HG::Rendering::Runtime::HorizontalBlurPass::cctor(MethodInfo *method)
		{
		  Object *v1; // rdi
		  RenderFunc_1_System_Object_ *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_HorizontalBlurPass_PassData_ *v5; // rbx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass::__c);
		  v1 = (Object *)TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass::__c->static_fields->__9;
		  v2 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HorizontalBlurPass::PassData>);
		  v5 = (RenderFunc_1_HG_Rendering_Runtime_HorizontalBlurPass_PassData_ *)v2;
		  if ( !v2 )
		    sub_1800D8260(v4, v3);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v2,
		    v1,
		    MethodInfo::HG::Rendering::Runtime::HorizontalBlurPass::__c::__cctor_b__4_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass->static_fields->s_RenderFunc = v5;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass->static_fields,
		    v6,
		    v7,
		    v8,
		    v9);
		}
		
	
		// Methods
		internal static TextureHandle Render(HGRenderGraph renderGraph, HGCamera camera, TextureHandle source, float radius, bool useBlurTarget, float blurTargetAngleDeg, bool useBlurCenter, Vector2 blurCenterUV, float blurCenterFadeWidth, Material horizontalBlurMaterial, MaterialPropertyBlock mpb, ProfilingSampler profilingSampler) => default; // 0x0000000189BC9854-0x0000000189BC9F90
		// TextureHandle Render(HGRenderGraph, HGCamera, TextureHandle, Single, Boolean, Single, Boolean, Vector2, Single, Material, MaterialPropertyBlock, ProfilingSampler)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::HorizontalBlurPass::Render(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        TextureHandle *source,
		        float radius,
		        bool useBlurTarget,
		        float blurTargetAngleDeg,
		        bool useBlurCenter,
		        Vector2 blurCenterUV,
		        float blurCenterFadeWidth,
		        Material *horizontalBlurMaterial,
		        MaterialPropertyBlock *mpb,
		        ProfilingSampler *profilingSampler,
		        MethodInfo *method)
		{
		  TextureHandle *v17; // rdi
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  GraphicsFormat__Enum ColorBufferFormat; // eax
		  Color clearColor; // xmm2
		  unsigned __int64 v27; // r8
		  signed __int64 v28; // rtt
		  Object *v29; // rsi
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  TextureHandle v32; // xmm0
		  Object *v33; // rcx
		  Object *v34; // rcx
		  Object *v35; // rcx
		  Object *v36; // rax
		  Object *v37; // rdx
		  __int64 v38; // rcx
		  unsigned __int64 v39; // rdx
		  unsigned __int64 v40; // r8
		  char v41; // dl
		  signed __int64 v42; // rtt
		  Object *v43; // rdx
		  unsigned __int64 v44; // rdx
		  unsigned __int64 v45; // r8
		  char v46; // dl
		  signed __int64 v47; // rtt
		  TextureHandle v48; // xmm6
		  TextureHandle v49; // xmm0
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Object *v54; // [rsp+80h] [rbp-1D8h] BYREF
		  TextureHandle v55; // [rsp+90h] [rbp-1C8h] BYREF
		  TextureHandle v56; // [rsp+A0h] [rbp-1B8h] BYREF
		  _QWORD v57[2]; // [rsp+B0h] [rbp-1A8h] BYREF
		  HGRenderGraphBuilder v58; // [rsp+C0h] [rbp-198h] BYREF
		  HGRenderGraphBuilder v59; // [rsp+E0h] [rbp-178h] BYREF
		  TextureDesc v60; // [rsp+100h] [rbp-158h] BYREF
		  Il2CppExceptionWrapper *v61; // [rsp+160h] [rbp-F8h] BYREF
		  TextureDesc v62; // [rsp+170h] [rbp-E8h] BYREF
		  TextureDesc v63; // [rsp+1D0h] [rbp-88h] BYREF
		
		  v17 = retstr;
		  v54 = 0LL;
		  sub_18033B9D0(&v63, 0LL, 96LL);
		  sub_18033B9D0(&v60, 0LL, 96LL);
		  v55 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2942, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2942, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v51, v50);
		    *(TextureHandle *)&v58.m_RenderPass = *source;
		    v49 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1088(
		             &v55,
		             Patch,
		             (Object *)renderGraph,
		             (Object *)camera,
		             (TextureHandle *)&v58,
		             radius,
		             useBlurTarget,
		             blurTargetAngleDeg,
		             useBlurCenter,
		             blurCenterUV,
		             blurCenterFadeWidth,
		             (Object *)horizontalBlurMaterial,
		             (Object *)mpb,
		             (Object *)profilingSampler,
		             0LL);
		    goto LABEL_37;
		  }
		  if ( radius <= 0.0 )
		  {
		    v49 = *source;
		LABEL_37:
		    *v17 = v49;
		    return v17;
		  }
		  if ( !renderGraph )
		    sub_1800D8260(v19, v18);
		  HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		    &v58,
		    renderGraph,
		    (String *)"PreTAAU Horizontal Blur",
		    &v54,
		    profilingSampler,
		    1,
		    ProfilingHGPass__Enum_None,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HorizontalBlurPass::PassData>);
		  v59 = v58;
		  v57[0] = 0LL;
		  v57[1] = &v59;
		  try
		  {
		    if ( !camera )
		      sub_1800D8250(v21, v20);
		    sub_18033B9D0(&v62, 0LL, 96LL);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v62, camera->fields._sceneRTSize_k__BackingField, 0LL);
		    v60 = v62;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !currentPipeline )
		        sub_1800D8250(v24, v23);
		      ColorBufferFormat = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(currentPipeline, camera, 0LL);
		    }
		    else
		    {
		      ColorBufferFormat = GraphicsFormat__Enum_B10G11R11_UFloatPack32;
		    }
		    v60.colorFormat = ColorBufferFormat;
		    clearColor = 0LL;
		    v60.clearColor = 0LL;
		    v60.dimension = 2;
		    v60.slices = 1;
		    v60.msaaSamples = 1;
		    v60.name = (String *)"PreTAAU.HorizontalBlur";
		    if ( dword_18F35FD08 )
		    {
		      v27 = (((unsigned __int64)&v60.name >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v27 + 36190]);
		      do
		        v28 = qword_18F0BCBA0[v27 + 36190];
		      while ( v28 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v27 + 36190],
		                       v28 | (1LL << (((unsigned __int64)&v60.name >> 12) & 0x3F)),
		                       v28) );
		      clearColor = v60.clearColor;
		    }
		    *(_OWORD *)&v63.width = *(_OWORD *)&v60.width;
		    *(_OWORD *)&v63.colorFormat = *(_OWORD *)&v60.colorFormat;
		    *(_OWORD *)&v63.enableRandomWrite = *(_OWORD *)&v60.enableRandomWrite;
		    *(_OWORD *)&v63.bindTextureMS = *(_OWORD *)&v60.bindTextureMS;
		    *(_OWORD *)&v63.fastMemoryDesc.inFastMemory = *(_OWORD *)&v60.fastMemoryDesc.inFastMemory;
		    v63.clearColor = clearColor;
		    v55 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture((TextureHandle *)&v58, renderGraph, &v63, 0LL);
		    *(TextureHandle *)&v58.m_RenderPass = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                                             (TextureHandle *)&v58,
		                                             &v59,
		                                             &v55,
		                                             0LL);
		    v29 = v54;
		    v32 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v56, &v59, source, 0LL);
		    if ( !v29 )
		      sub_1800D8250(v31, v30);
		    v29[1] = (Object)v32;
		    v33 = v54;
		    if ( !v54 )
		      sub_1800D8250(0LL, v30);
		    v54[2].klass = (Object__Class *)camera->fields._sceneRTSize_k__BackingField;
		    if ( !v54 )
		      sub_1800D8250(v33, v30);
		    *((float *)&v54[2].monitor + 1) = radius;
		    v34 = v54;
		    if ( !v54 )
		      sub_1800D8250(0LL, v30);
		    LOBYTE(v54[2].monitor) = useBlurTarget;
		    if ( !v54 )
		      sub_1800D8250(v34, v30);
		    *(float *)&v54[3].klass = blurTargetAngleDeg;
		    v35 = v54;
		    if ( !v54 )
		      sub_1800D8250(0LL, v30);
		    BYTE1(v54[2].monitor) = useBlurCenter;
		    v36 = v54;
		    if ( !v54 )
		      sub_1800D8250(v35, v30);
		    *(float *)&v54[3].monitor = blurCenterUV.x;
		    HIDWORD(v36[3].monitor) = LODWORD(blurCenterUV.y);
		    if ( !v54 )
		      sub_1800D8250(v35, v30);
		    *((float *)&v54[3].klass + 1) = blurCenterFadeWidth;
		    v37 = v54;
		    if ( !v54 )
		      sub_1800D8250(v35, 0LL);
		    v54[4].klass = (Object__Class *)horizontalBlurMaterial;
		    v38 = (unsigned int)dword_18F35FD08;
		    if ( dword_18F35FD08 )
		    {
		      v39 = ((unsigned __int64)&v37[4] >> 12) & 0x1FFFFF;
		      v40 = v39 >> 6;
		      v41 = v39 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v40 + 36190]);
		      do
		        v42 = qword_18F0BCBA0[v40 + 36190];
		      while ( v42 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v40 + 36190], v42 | (1LL << v41), v42) );
		      v38 = (unsigned int)dword_18F35FD08;
		    }
		    v43 = v54;
		    if ( !v54 )
		      sub_1800D8250(v38, 0LL);
		    v54[4].monitor = (MonitorData *)mpb;
		    if ( (_DWORD)v38 )
		    {
		      v44 = ((unsigned __int64)&v43[4].monitor >> 12) & 0x1FFFFF;
		      v45 = v44 >> 6;
		      v46 = v44 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v45 + 36190]);
		      do
		        v47 = qword_18F0BCBA0[v45 + 36190];
		      while ( v47 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v45 + 36190], v47 | (1LL << v46), v47) );
		    }
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		      &v56,
		      &v59,
		      (TextureHandle *)&v58,
		      0,
		      0,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v59,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HorizontalBlurPass->static_fields->s_RenderFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HorizontalBlurPass::PassData>);
		    v48 = *(TextureHandle *)&v58.m_RenderPass;
		    v55 = *(TextureHandle *)&v58.m_RenderPass;
		  }
		  catch ( Il2CppExceptionWrapper *v61 )
		  {
		    v57[0] = v61->ex;
		    sub_180268AE0(v57);
		    v17 = retstr;
		    v48 = v55;
		    goto LABEL_33;
		  }
		  sub_180268AE0(v57);
		LABEL_33:
		  *v17 = v48;
		  return v17;
		}
		
	}
}
