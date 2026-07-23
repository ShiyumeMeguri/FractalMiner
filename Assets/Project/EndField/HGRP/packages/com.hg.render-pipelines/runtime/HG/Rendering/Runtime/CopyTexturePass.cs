using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class CopyTexturePass // TypeDefIndex: 38200
	{
		// Fields
		private static readonly RenderFunc<CopyTextureData> s_copyTextureFunc; // 0x00
		private static readonly RenderFunc<CopyDepthPassData> s_copyDepthFunc; // 0x08
		private static readonly RenderFunc<BlitMotionVectorPassData> s_blitMotionVectorFunc; // 0x10
	
		// Nested types
		private class CopyTextureData // TypeDefIndex: 38196
		{
			// Fields
			public TextureHandle srcTexture; // 0x10
			public TextureHandle dstTexture; // 0x20
			public int copyPassIndex; // 0x30
			public int dstTextureShaderID; // 0x34
			public bool useNativeBlit; // 0x38
			public bool isFP32Output; // 0x39
			public Rect viewport; // 0x3C
	
			// Constructors
			public CopyTextureData() {} // 0x0000000184DA17B0-0x0000000184DA17C0
			// CopyTexturePass+CopyTextureData()
			void HG::Rendering::Runtime::CopyTexturePass::CopyTextureData::CopyTextureData(
			        CopyTexturePass_CopyTextureData *this,
			        MethodInfo *method)
			{
			  this->fields.dstTextureShaderID = -1;
			  this->fields.viewport = 0LL;
			}
			
		}
	
		private class CopyDepthPassData // TypeDefIndex: 38197
		{
			// Fields
			public TextureHandle srcTexture; // 0x10
			public TextureHandle destTexture; // 0x20
	
			// Constructors
			public CopyDepthPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class BlitMotionVectorPassData // TypeDefIndex: 38198
		{
			// Fields
			public TextureHandle srcTexture; // 0x10
			public TextureHandle dstTexture; // 0x20
	
			// Constructors
			public BlitMotionVectorPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		static CopyTexturePass() {} // 0x0000000189B92340-0x0000000189B92494
		// CopyTexturePass()
		void HG::Rendering::Runtime::CopyTexturePass::cctor(MethodInfo *method)
		{
		  Object *v1; // rdi
		  RenderFunc_1_System_Object_ *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Type__Class *v5; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Object *v9; // rdi
		  RenderFunc_1_System_Object_ *v10; // rax
		  MonitorData *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Object *v15; // rdi
		  RenderFunc_1_System_Object_ *v16; // rax
		  RenderFunc_1_System_Object_ *v17; // rbx
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+50h] [rbp+28h]
		
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass::__c);
		  v1 = (Object *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass::__c->static_fields->__9;
		  v2 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
		  v5 = (Type__Class *)v2;
		  if ( !v2 )
		    goto LABEL_5;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v2,
		    v1,
		    MethodInfo::HG::Rendering::Runtime::CopyTexturePass::__c::__cctor_b__9_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields;
		  static_fields->klass = v5;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields,
		    static_fields,
		    v7,
		    v8,
		    v21);
		  v9 = (Object *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass::__c->static_fields->__9;
		  v10 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
		  v11 = (MonitorData *)v10;
		  if ( !v10
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v10,
		          v9,
		          MethodInfo::HG::Rendering::Runtime::CopyTexturePass::__c::__cctor_b__9_1,
		          0LL),
		        v12 = (Type *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields,
		        v12->monitor = v11,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields->s_copyDepthFunc,
		          v12,
		          v13,
		          v14,
		          v22),
		        v15 = (Object *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass::__c->static_fields->__9,
		        v16 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>),
		        (v17 = v16) == 0LL) )
		  {
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v16,
		    v15,
		    MethodInfo::HG::Rendering::Runtime::CopyTexturePass::__c::__cctor_b__9_2,
		    0LL);
		  v18 = (Type *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields;
		  v18->fields._impl.value = v17;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields->s_blitMotionVectorFunc,
		    v18,
		    v19,
		    v20,
		    v23);
		}
		
	
		// Methods
		internal static void BlitTexture(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle dstTexture, int copyPassIndex = 0 /* Metadata: 0x02303BF2 */, int dstTextureShaderID = -1 /* Metadata: 0x02303BF3 */, bool useNativeBlit = false /* Metadata: 0x02303BF4 */, Rect viewport = default, bool loadRT = false /* Metadata: 0x02303BF5 */) {} // 0x0000000189B91D50-0x0000000189B92120
		// Void BlitTexture(HGRenderGraph, TextureHandle, TextureHandle, Int32, Int32, Boolean, Rect, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		        HGRenderGraph *renderGraph,
		        TextureHandle *srcTexture,
		        TextureHandle *dstTexture,
		        int32_t copyPassIndex,
		        int32_t dstTextureShaderID,
		        bool useNativeBlit,
		        Rect *viewport,
		        bool loadRT,
		        MethodInfo *method)
		{
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Object *v16; // rbx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  TextureHandle v19; // xmm0
		  Object *v20; // rbx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  TextureHandle v23; // xmm0
		  Object *v24; // rcx
		  Object *v25; // rbx
		  TextureDesc *TextureDescRef; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Object *v32; // [rsp+50h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v33; // [rsp+58h] [rbp-70h] BYREF
		  TextureHandle v34; // [rsp+60h] [rbp-68h] BYREF
		  Rect si128; // [rsp+70h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v36; // [rsp+80h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v37; // [rsp+A0h] [rbp-28h] BYREF
		
		  v32 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3036, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3036, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v30, v29);
		    si128 = *viewport;
		    v34 = *dstTexture;
		    *(TextureHandle *)&v36.m_RenderPass = *srcTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1127(
		      Patch,
		      (Object *)renderGraph,
		      (TextureHandle *)&v36,
		      &v34,
		      copyPassIndex,
		      dstTextureShaderID,
		      useNativeBlit,
		      &si128,
		      loadRT,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(srcTexture, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(dstTexture, 0LL) )
		      {
		        v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0x1Fu,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        if ( !renderGraph )
		          sub_1800D8260(v15, v14);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          &v36,
		          renderGraph,
		          (String *)"Blit Texture",
		          &v32,
		          v13,
		          1,
		          ProfilingHGPass__Enum_None,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
		        v37 = v36;
		        v34.handle = 0LL;
		        v34.fallBackResource = (ResourceHandle)&v37;
		        try
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v37, 0, 0LL);
		          v16 = v32;
		          v19 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&v36,
		                   &v37,
		                   srcTexture,
		                   0LL);
		          if ( !v16 )
		            sub_1800D8250(v18, v17);
		          v16[1] = (Object)v19;
		          v20 = v32;
		          v23 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                   (TextureHandle *)&v36,
		                   &v37,
		                   dstTexture,
		                   0LL);
		          if ( !v20 )
		            sub_1800D8250(v22, v21);
		          v20[2] = (Object)v23;
		          v24 = v32;
		          if ( !v32 )
		            sub_1800D8250(0LL, v21);
		          HIDWORD(v32[3].klass) = dstTextureShaderID;
		          if ( !v32 )
		            sub_1800D8250(v24, v21);
		          LOBYTE(v32[3].monitor) = useNativeBlit;
		          if ( !v32 )
		            sub_1800D8250(v24, v21);
		          LODWORD(v32[3].klass) = copyPassIndex;
		          v25 = v32;
		          TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                             renderGraph,
		                             dstTexture,
		                             0LL);
		          if ( !v25 )
		            sub_1800D8250(v28, v27);
		          BYTE1(v25[3].monitor) = TextureDescRef->colorFormat == 49;
		          if ( !v32 )
		            sub_1800D8250(0LL, v27);
		          *(Object *)((char *)v32 + 60) = *(Object *)viewport;
		          if ( !useNativeBlit )
		          {
		            si128 = (Rect)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		              (TextureHandle *)&v36,
		              &v37,
		              dstTexture,
		              0,
		              (RenderBufferLoadAction__Enum)!loadRT,
		              RenderBufferStoreAction__Enum_Store,
		              (Color *)&si128,
		              0,
		              0LL);
		          }
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v37,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields->s_copyTextureFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyTextureData>);
		        }
		        catch ( Il2CppExceptionWrapper *v33 )
		        {
		          v34.handle = (ResourceHandle)v33->ex;
		        }
		        sub_180268AE0(&v34);
		      }
		    }
		  }
		}
		
		internal static void CopyDepth(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle destTexture) {} // 0x0000000189B92120-0x0000000189B92340
		// Void CopyDepth(HGRenderGraph, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CopyTexturePass::CopyDepth(
		        HGRenderGraph *renderGraph,
		        TextureHandle *srcTexture,
		        TextureHandle *destTexture,
		        MethodInfo *method)
		{
		  ProfilingSampler *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *v10; // rbx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  TextureHandle v13; // xmm0
		  Object *v14; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  TextureHandle v17; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Object *v21; // [rsp+40h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v22; // [rsp+48h] [rbp-60h] BYREF
		  TextureHandle v23; // [rsp+50h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v24; // [rsp+60h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+80h] [rbp-28h] BYREF
		
		  v21 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3037, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3037, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    v23 = *destTexture;
		    *(TextureHandle *)&v24.m_RenderPass = *srcTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1128(Patch, (Object *)renderGraph, (TextureHandle *)&v24, &v23, 0LL);
		  }
		  else
		  {
		    v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)1u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v24,
		      renderGraph,
		      (String *)"Copy Depth Buffer",
		      &v21,
		      v7,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
		    v25 = v24;
		    v23.handle = 0LL;
		    v23.fallBackResource = (ResourceHandle)&v25;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v25, 0, 0LL);
		      v10 = v21;
		      v13 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v24,
		               &v25,
		               srcTexture,
		               0LL);
		      if ( !v10 )
		        sub_1800D8250(v12, v11);
		      v10[1] = (Object)v13;
		      v14 = v21;
		      v17 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		               (TextureHandle *)&v24,
		               &v25,
		               destTexture,
		               0LL);
		      if ( !v14 )
		        sub_1800D8250(v16, v15);
		      v14[2] = (Object)v17;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v25,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields->s_copyDepthFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::CopyDepthPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v22 )
		    {
		      v23.handle = (ResourceHandle)v22->ex;
		    }
		    sub_180268AE0(&v23);
		  }
		}
		
		internal static void BlitMotionVector(HGRenderGraph renderGraph, TextureHandle srcTexture, TextureHandle dstTexture) {} // 0x0000000189B91ADC-0x0000000189B91D50
		// Void BlitMotionVector(HGRenderGraph, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CopyTexturePass::BlitMotionVector(
		        HGRenderGraph *renderGraph,
		        TextureHandle *srcTexture,
		        TextureHandle *dstTexture,
		        MethodInfo *method)
		{
		  ProfilingSampler *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *v10; // rbx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  TextureHandle v13; // xmm0
		  Object *v14; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  TextureHandle v17; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Object *v21; // [rsp+50h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v22; // [rsp+58h] [rbp-70h] BYREF
		  TextureHandle v23; // [rsp+60h] [rbp-68h] BYREF
		  TextureHandle si128; // [rsp+70h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+80h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v26; // [rsp+A0h] [rbp-28h] BYREF
		
		  v21 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3038, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3038, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    si128 = *dstTexture;
		    v23 = *srcTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1128(Patch, (Object *)renderGraph, &v23, &si128, 0LL);
		  }
		  else
		  {
		    v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x53u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v25,
		      renderGraph,
		      (String *)"Blit Motion Vector",
		      &v21,
		      v7,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>);
		    v26 = v25;
		    v23.handle = 0LL;
		    v23.fallBackResource = (ResourceHandle)&v26;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v26, 0, 0LL);
		      v10 = v21;
		      v13 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v26, srcTexture, 0LL);
		      if ( !v10 )
		        sub_1800D8250(v12, v11);
		      v10[1] = (Object)v13;
		      v14 = v21;
		      v17 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&si128, &v26, dstTexture, 0LL);
		      if ( !v14 )
		        sub_1800D8250(v16, v15);
		      v14[2] = (Object)v17;
		      si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v25,
		        &v26,
		        dstTexture,
		        0,
		        RenderBufferLoadAction__Enum_Clear,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v26,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CopyTexturePass->static_fields->s_blitMotionVectorFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CopyTexturePass::BlitMotionVectorPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v22 )
		    {
		      v23.handle = (ResourceHandle)v22->ex;
		    }
		    sub_180268AE0(&v23);
		  }
		}
		
	}
}
