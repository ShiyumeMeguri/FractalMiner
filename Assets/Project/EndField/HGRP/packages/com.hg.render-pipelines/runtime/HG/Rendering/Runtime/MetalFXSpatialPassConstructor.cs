using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class MetalFXSpatialPassConstructor : IPassConstructor // TypeDefIndex: 38350
	{
		// Fields
		private MetalFXSpatialScalerDesc m_spatialScalerDesc; // 0x10
		private uint m_spatialScalerHandle; // 0x28
		private static readonly RenderFunc<MetalFXSpatialPassData> s_metalFXSpatialRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38345
		{
			// Fields
			internal bool enableMetalFXSpatialScaler; // 0x00
			internal TextureHandle colorTexture; // 0x04
			internal TextureHandle outputTexture; // 0x14
		}
	
		internal struct PassOutput // TypeDefIndex: 38346
		{
		}
	
		private class MetalFXSpatialPassData // TypeDefIndex: 38347
		{
			// Fields
			internal uint spatialScalerHandle; // 0x10
			internal TextureHandle colorTexture; // 0x14
			internal TextureHandle outputTexture; // 0x24
	
			// Constructors
			public MetalFXSpatialPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal struct MetalFXSpatialScalerDesc : IEquatable<MetalFXSpatialScalerDesc> // TypeDefIndex: 38348
		{
			// Fields
			internal int inputWidth; // 0x00
			internal int inputHeight; // 0x04
			internal int outputWidth; // 0x08
			internal int outputHeight; // 0x0C
			internal GraphicsFormat colorTextureFormat; // 0x10
			internal GraphicsFormat outputTextureFormat; // 0x14
	
			// Methods
			public bool Equals(MetalFXSpatialScalerDesc other) => default; // 0x0000000189BBBEA4-0x0000000189BBBF80
			// Boolean Equals(MetalFXSpatialPassConstructor+MetalFXSpatialScalerDesc)
			bool HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialScalerDesc::Equals(
			        MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc *this,
			        MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc *other,
			        MethodInfo *method)
			{
			  __int64 v5; // xmm0_8
			  int32_t inputWidth; // eax
			  __int64 v7; // rax
			  int32_t outputWidth; // eax
			  __int64 v9; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  __int64 v14; // xmm1_8
			  MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc v15; // [rsp+20h] [rbp-20h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3247, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3247, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    v14 = *(_QWORD *)&other->colorTextureFormat;
			    *(_OWORD *)&v15.inputWidth = *(_OWORD *)&other->inputWidth;
			    *(_QWORD *)&v15.colorTextureFormat = v14;
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1193(Patch, this, &v15, 0LL);
			  }
			  else
			  {
			    v5 = *(_QWORD *)&other->colorTextureFormat;
			    inputWidth = other->inputWidth;
			    *(_QWORD *)&v15.colorTextureFormat = v5;
			    if ( this->inputWidth == inputWidth
			      && (v7 = HIDWORD(*(_QWORD *)&other->inputWidth),
			          *(_QWORD *)&v15.colorTextureFormat = v5,
			          this->inputHeight == (_DWORD)v7)
			      && (outputWidth = other->outputWidth, *(_QWORD *)&v15.colorTextureFormat = v5, this->outputWidth == outputWidth)
			      && (v9 = HIDWORD(*(_QWORD *)&other->outputWidth),
			          *(_QWORD *)&v15.colorTextureFormat = v5,
			          this->outputHeight == (_DWORD)v9)
			      && (*(_QWORD *)&v15.colorTextureFormat = v5, this->colorTextureFormat == (_DWORD)v5) )
			    {
			      *(_QWORD *)&v15.colorTextureFormat = v5;
			      return this->outputTextureFormat == HIDWORD(v5);
			    }
			    else
			    {
			      return 0;
			    }
			  }
			}
			
		}
	
		// Constructors
		public MetalFXSpatialPassConstructor() {} // Dummy constructor
		internal MetalFXSpatialPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static MetalFXSpatialPassConstructor() {} // 0x0000000184D2CA90-0x0000000184D2CB20
		// MetalFXSpatialPassConstructor()
		void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::cctor(MethodInfo *method)
		{
		  struct MetalFXSpatialPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_MetalFXSpatialPassConstructor_MetalFXSpatialPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_MetalFXSpatialPassConstructor_MetalFXSpatialPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor::__c::__cctor_b__13_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor->static_fields->s_metalFXSpatialRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBBE50-0x0000000189BBBEA4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        MetalFXSpatialPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3243, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3243, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBBDFC-0x0000000189BBBE50
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        MetalFXSpatialPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3244, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3244, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBBDA8-0x0000000189BBBDFC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        MetalFXSpatialPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3245, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3245, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBB9A0-0x0000000189BBBDA8
		// Void ConstructPass(MetalFXSpatialPassConstructor+PassInput ByRef, MetalFXSpatialPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::ConstructPass(
		        MetalFXSpatialPassConstructor *this,
		        MetalFXSpatialPassConstructor_PassInput *input,
		        MetalFXSpatialPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  TextureDesc *TextureDescRef; // rax
		  __m128i v14; // xmm6
		  __m128i v15; // xmm7
		  __m128i *v16; // rax
		  __m128i v17; // xmm2
		  int32_t v18; // r8d
		  __m128i v19; // xmm1
		  __int64 v20; // xmm0_8
		  __int64 v21; // rdx
		  __m128i v22; // xmm1
		  unsigned __int64 v23; // xmm0_8
		  uint32_t MetalFXSpatialScaler; // eax
		  __int64 m_spatialScalerHandle; // rcx
		  Object *v26; // rbx
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  TextureHandle v29; // xmm0
		  Object *v30; // rbx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  TextureHandle v33; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc outputTextureFormat; // [rsp+40h] [rbp-118h] BYREF
		  Object *v38; // [rsp+60h] [rbp-F8h] BYREF
		  _QWORD v39[2]; // [rsp+68h] [rbp-F0h] BYREF
		  HGRenderGraphBuilder inputWidth; // [rsp+78h] [rbp-E0h] BYREF
		  HGRenderGraphBuilder v41; // [rsp+98h] [rbp-C0h] BYREF
		  Il2CppExceptionWrapper *v42; // [rsp+120h] [rbp-38h] BYREF
		
		  v38 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3246, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3246, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v36, v35);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1194(
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
		    if ( input->enableMetalFXSpatialScaler )
		    {
		      v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x54u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v12, v11);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &inputWidth,
		        renderGraph,
		        (String *)"MetalFX Spatial Pass",
		        &v38,
		        v10,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
		      v41 = inputWidth;
		      v39[0] = 0LL;
		      v39[1] = &v41;
		      try
		      {
		        TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                           renderGraph,
		                           &input->colorTexture,
		                           0LL);
		        v14 = *(__m128i *)&TextureDescRef->width;
		        v15 = *(__m128i *)&TextureDescRef->colorFormat;
		        v16 = (__m128i *)HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                           renderGraph,
		                           &input->outputTexture,
		                           0LL);
		        *(_QWORD *)&outputTextureFormat.outputWidth = 0LL;
		        *(_QWORD *)&outputTextureFormat.colorTextureFormat = 0LL;
		        outputTextureFormat.inputWidth = _mm_cvtsi128_si32(v14);
		        outputTextureFormat.inputHeight = v14.m128i_i32[1];
		        v17 = *v16;
		        v18 = _mm_cvtsi128_si32(*v16);
		        outputTextureFormat.outputWidth = v18;
		        outputTextureFormat.outputHeight = v17.m128i_i32[1];
		        outputTextureFormat.colorTextureFormat = _mm_cvtsi128_si32(v15);
		        outputTextureFormat.outputTextureFormat = _mm_cvtsi128_si32(v16[1]);
		        v19 = *(__m128i *)&outputTextureFormat.inputWidth;
		        *(_OWORD *)&inputWidth.m_RenderPass = *(_OWORD *)&outputTextureFormat.inputWidth;
		        v20 = *(_QWORD *)&outputTextureFormat.colorTextureFormat;
		        inputWidth.m_RenderGraph = *(HGRenderGraph **)&outputTextureFormat.colorTextureFormat;
		        if ( this->fields.m_spatialScalerHandle )
		        {
		          outputTextureFormat = this->fields.m_spatialScalerDesc;
		          if ( HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialScalerDesc::Equals(
		                 (MetalFXSpatialPassConstructor_MetalFXSpatialScalerDesc *)&inputWidth,
		                 &outputTextureFormat,
		                 0LL) )
		          {
		LABEL_10:
		            m_spatialScalerHandle = this->fields.m_spatialScalerHandle;
		            if ( !v38 )
		              sub_1800D8250(m_spatialScalerHandle, v21);
		            LODWORD(v38[1].klass) = m_spatialScalerHandle;
		            v26 = v38;
		            v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                     (TextureHandle *)&outputTextureFormat,
		                     &v41,
		                     &input->colorTexture,
		                     0LL);
		            if ( !v26 )
		              sub_1800D8250(v28, v27);
		            *(TextureHandle *)((char *)&v26[1] + 4) = v29;
		            v30 = v38;
		            v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                     (TextureHandle *)&outputTextureFormat,
		                     &v41,
		                     &input->outputTexture,
		                     0LL);
		            if ( !v30 )
		              sub_1800D8250(v32, v31);
		            *(TextureHandle *)((char *)&v30[2] + 4) = v33;
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v41, 0, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		              &v41,
		              (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor->static_fields->s_metalFXSpatialRenderFunc,
		              0LL,
		              0,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MetalFXSpatialPassConstructor::MetalFXSpatialPassData>);
		            goto LABEL_25;
		          }
		          UnityEngine::HyperGryph::HGGraphicsUtils::DestroyMetalFXSpatialScaler(this->fields.m_spatialScalerHandle, 0LL);
		          v22 = *(__m128i *)&inputWidth.m_RenderPass;
		          *(_OWORD *)&this->fields.m_spatialScalerDesc.inputWidth = *(_OWORD *)&inputWidth.m_RenderPass;
		          *(_QWORD *)&this->fields.m_spatialScalerDesc.colorTextureFormat = inputWidth.m_RenderGraph;
		          v23 = _mm_srli_si128(v22, 8).m128i_u64[0];
		          MetalFXSpatialScaler = UnityEngine::HyperGryph::HGGraphicsUtils::CreateMetalFXSpatialScaler(
		                                   v22.m128i_i32[0],
		                                   v22.m128i_i32[1],
		                                   v23,
		                                   SHIDWORD(v23),
		                                   (GraphicsFormat__Enum)inputWidth.m_RenderGraph,
		                                   HIDWORD(inputWidth.m_RenderGraph),
		                                   0LL);
		        }
		        else
		        {
		          *(_OWORD *)&this->fields.m_spatialScalerDesc.inputWidth = *(_OWORD *)&outputTextureFormat.inputWidth;
		          *(_QWORD *)&this->fields.m_spatialScalerDesc.colorTextureFormat = v20;
		          MetalFXSpatialScaler = UnityEngine::HyperGryph::HGGraphicsUtils::CreateMetalFXSpatialScaler(
		                                   _mm_cvtsi128_si32(v14),
		                                   v19.m128i_i32[1],
		                                   v18,
		                                   _mm_srli_si128(v19, 8).m128i_i32[1],
		                                   (GraphicsFormat__Enum)_mm_cvtsi128_si32(v15),
		                                   (GraphicsFormat__Enum)outputTextureFormat.outputTextureFormat,
		                                   0LL);
		        }
		        this->fields.m_spatialScalerHandle = MetalFXSpatialScaler;
		        goto LABEL_10;
		      }
		      catch ( Il2CppExceptionWrapper *v42 )
		      {
		        v39[0] = v42->ex;
		      }
		LABEL_25:
		      sub_180268AE0(v39);
		      return;
		    }
		    if ( this->fields.m_spatialScalerHandle )
		    {
		      UnityEngine::HyperGryph::HGGraphicsUtils::DestroyMetalFXSpatialScaler(this->fields.m_spatialScalerHandle, 0LL);
		      *(_OWORD *)&this->fields.m_spatialScalerDesc.inputWidth = 0LL;
		      *(_QWORD *)&this->fields.m_spatialScalerDesc.colorTextureFormat = 0LL;
		      this->fields.m_spatialScalerHandle = 0;
		    }
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D800B0-0x0000000184D800E0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::MetalFXSpatialPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        MetalFXSpatialPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3248, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3248, 0LL);
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
