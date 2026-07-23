using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class MetalFXTemporalPassConstructor : IPassConstructor // TypeDefIndex: 38356
	{
		// Fields
		private bool m_prevTemporalScalerState; // 0x10
		private MetalFXTemporalScalerDesc m_temporalScalerDesc; // 0x14
		private uint m_temporalScalerHandle; // 0x34
		private static readonly RenderFunc<MetalFXTemporalPassData> s_metalFXTemporalRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38351
		{
			// Fields
			internal bool enableMetalFXTemporalScaler; // 0x00
			internal Vector2Int screenSize; // 0x04
			internal TextureHandle colorTexture; // 0x0C
			internal TextureHandle depthTexture; // 0x1C
			internal TextureHandle motionTexture; // 0x2C
		}
	
		internal struct PassOutput // TypeDefIndex: 38352
		{
			// Fields
			internal TextureHandle outputTexture; // 0x00
		}
	
		private class MetalFXTemporalPassData // TypeDefIndex: 38353
		{
			// Fields
			internal uint temporalScalerHandle; // 0x10
			internal bool resetHistory; // 0x14
			internal TextureHandle colorTexture; // 0x18
			internal TextureHandle depthTexture; // 0x28
			internal TextureHandle motionTexture; // 0x38
			internal TextureHandle outputTexture; // 0x48
			internal bool reversedDepth; // 0x58
			internal float jitterOffsetX; // 0x5C
			internal float jitterOffsetY; // 0x60
	
			// Constructors
			public MetalFXTemporalPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal struct MetalFXTemporalScalerDesc : IEquatable<MetalFXTemporalScalerDesc> // TypeDefIndex: 38354
		{
			// Fields
			internal int inputWidth; // 0x00
			internal int inputHeight; // 0x04
			internal int outputWidth; // 0x08
			internal int outputHeight; // 0x0C
			internal GraphicsFormat colorTextureFormat; // 0x10
			internal GraphicsFormat depthTextureFormat; // 0x14
			internal GraphicsFormat motionTextureFormat; // 0x18
			internal GraphicsFormat outputTextureFormat; // 0x1C
	
			// Methods
			public bool Equals(MetalFXTemporalScalerDesc other) => default; // 0x0000000189BBC7B8-0x0000000189BBC878
			// Boolean Equals(MetalFXTemporalPassConstructor+MetalFXTemporalScalerDesc)
			bool HG::Rendering::Runtime::MetalFXTemporalPassConstructor::MetalFXTemporalScalerDesc::Equals(
			        MetalFXTemporalPassConstructor_MetalFXTemporalScalerDesc *this,
			        MetalFXTemporalPassConstructor_MetalFXTemporalScalerDesc *other,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  __int128 v9; // xmm1
			  MetalFXTemporalPassConstructor_MetalFXTemporalScalerDesc v10; // [rsp+20h] [rbp-28h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3253, 0LL) )
			    return *(_QWORD *)&this->inputWidth == *(_QWORD *)&other->inputWidth
			        && *(_QWORD *)&this->outputWidth == *(_QWORD *)&other->outputWidth
			        && *(_QWORD *)&this->colorTextureFormat == *(_QWORD *)&other->colorTextureFormat
			        && this->motionTextureFormat == other->motionTextureFormat
			        && this->outputTextureFormat == HIDWORD(*(_QWORD *)&other->motionTextureFormat);
			  Patch = IFix::WrappersManagerImpl::GetPatch(3253, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v8, v7);
			  v9 = *(_OWORD *)&other->colorTextureFormat;
			  *(_OWORD *)&v10.inputWidth = *(_OWORD *)&other->inputWidth;
			  *(_OWORD *)&v10.colorTextureFormat = v9;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1195(Patch, this, &v10, 0LL);
			}
			
		}
	
		// Constructors
		public MetalFXTemporalPassConstructor() {} // Dummy constructor
		internal MetalFXTemporalPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static MetalFXTemporalPassConstructor() {} // 0x0000000184D2CA00-0x0000000184D2CA90
		// MetalFXTemporalPassConstructor()
		void HG::Rendering::Runtime::MetalFXTemporalPassConstructor::cctor(MethodInfo *method)
		{
		  struct MetalFXTemporalPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_MetalFXTemporalPassConstructor_MetalFXTemporalPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MetalFXTemporalPassConstructor::MetalFXTemporalPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_MetalFXTemporalPassConstructor_MetalFXTemporalPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor::__c::__cctor_b__14_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor->static_fields->s_metalFXTemporalRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBC764-0x0000000189BBC7B8
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::MetalFXTemporalPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        MetalFXTemporalPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3249, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3249, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBC710-0x0000000189BBC764
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MetalFXTemporalPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        MetalFXTemporalPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3250, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3250, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBC6BC-0x0000000189BBC710
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MetalFXTemporalPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        MetalFXTemporalPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3251, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3251, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BBBF80-0x0000000189BBC6BC
		// Void ConstructPass(MetalFXTemporalPassConstructor+PassInput ByRef, MetalFXTemporalPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::MetalFXTemporalPassConstructor::ConstructPass(
		        MetalFXTemporalPassConstructor *this,
		        MetalFXTemporalPassConstructor_PassInput *input,
		        MetalFXTemporalPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  char v10; // r12
		  ProfilingSampler *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  TextureDesc *TextureDescRef; // rax
		  __m128i v15; // xmm9
		  __m128i v16; // xmm6
		  __m128i v17; // xmm8
		  __m128i v18; // xmm7
		  __m128i v19; // xmm2
		  __int128 v20; // xmm3
		  Color clearColor; // xmm4
		  int v22; // ecx
		  unsigned __int64 v23; // r8
		  signed __int64 v24; // rtt
		  int32_t v25; // r8d
		  __m128i v26; // xmm1
		  __m128i v27; // xmm2
		  __m128i v28; // xmm2
		  __m128i depthTextureFormat; // xmm1
		  unsigned __int64 motionTextureFormat; // rbx
		  unsigned __int64 v31; // xmm0_8
		  uint32_t MetalFXTemporalScaler; // eax
		  __int64 v33; // rdx
		  __int64 m_temporalScalerHandle; // rcx
		  Object *v35; // rbx
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  TextureHandle v38; // xmm0
		  Object *v39; // rbx
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  TextureHandle v42; // xmm0
		  Object *v43; // rbx
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  TextureHandle v46; // xmm0
		  Object *v47; // rbx
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  TextureHandle v50; // xmm0
		  Object *v51; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  Object *v55; // [rsp+50h] [rbp-268h] BYREF
		  HGRenderGraphBuilder m_temporalScalerDesc; // [rsp+60h] [rbp-258h] BYREF
		  HGRenderGraphBuilder inputWidth; // [rsp+80h] [rbp-238h] BYREF
		  _QWORD v58[2]; // [rsp+A0h] [rbp-218h] BYREF
		  HGRenderGraphBuilder v59; // [rsp+B0h] [rbp-208h] BYREF
		  __m128i v60; // [rsp+D0h] [rbp-1E8h] BYREF
		  __int128 v61; // [rsp+E0h] [rbp-1D8h]
		  __int128 v62; // [rsp+F0h] [rbp-1C8h]
		  __int128 v63; // [rsp+100h] [rbp-1B8h] BYREF
		  __int128 v64; // [rsp+110h] [rbp-1A8h]
		  Color v65; // [rsp+120h] [rbp-198h]
		  Il2CppExceptionWrapper *v66; // [rsp+190h] [rbp-128h] BYREF
		  TextureDesc v67; // [rsp+1A0h] [rbp-118h] BYREF
		  TextureDesc v68; // [rsp+200h] [rbp-B8h] BYREF
		
		  v10 = 0;
		  v55 = 0LL;
		  sub_18033B9D0(&v68, 0LL, 96LL);
		  sub_18033B9D0(&v60, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3252, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3252, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v54, v53);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1196(
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
		    if ( input->enableMetalFXTemporalScaler )
		    {
		      v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x55u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v13, v12);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &m_temporalScalerDesc,
		        renderGraph,
		        (String *)"MetalFX Temporal Pass",
		        &v55,
		        v11,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MetalFXTemporalPassConstructor::MetalFXTemporalPassData>);
		      v59 = m_temporalScalerDesc;
		      v58[0] = 0LL;
		      v58[1] = &v59;
		      try
		      {
		        TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                           renderGraph,
		                           &input->colorTexture,
		                           0LL);
		        v15 = *(__m128i *)&TextureDescRef->width;
		        v16 = *(__m128i *)&TextureDescRef->colorFormat;
		        v17 = *(__m128i *)&HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                             renderGraph,
		                             &input->depthTexture,
		                             0LL)->colorFormat;
		        v18 = *(__m128i *)&HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                             renderGraph,
		                             &input->motionTexture,
		                             0LL)->colorFormat;
		        sub_18033B9D0(&v67, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v67, input->screenSize, 0LL);
		        v19 = *(__m128i *)&v67.width;
		        v60 = *(__m128i *)&v67.width;
		        v61 = *(_OWORD *)&v67.colorFormat;
		        v62 = *(_OWORD *)&v67.enableRandomWrite;
		        *(_QWORD *)&v63 = *(_QWORD *)&v67.bindTextureMS;
		        v20 = *(_OWORD *)&v67.fastMemoryDesc.inFastMemory;
		        v64 = *(_OWORD *)&v67.fastMemoryDesc.inFastMemory;
		        clearColor = v67.clearColor;
		        v65 = v67.clearColor;
		        v22 = _mm_cvtsi128_si32(v16);
		        LODWORD(v61) = v22;
		        LOWORD(v62) = 1;
		        BYTE2(v62) = 0;
		        *((_QWORD *)&v63 + 1) = "MetalFX Temporal Result";
		        if ( dword_18F35FD08 )
		        {
		          v23 = ((((unsigned __int64)&v63 + 8) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F103690[v23]);
		          do
		            v24 = qword_18F103690[v23];
		          while ( v24 != _InterlockedCompareExchange64(
		                           &qword_18F103690[v23],
		                           v24 | (1LL << ((((unsigned __int64)&v63 + 8) >> 12) & 0x3F)),
		                           v24) );
		          clearColor = v65;
		          v20 = v64;
		          v22 = v61;
		          v19 = v60;
		        }
		        *(__m128i *)&v68.width = v19;
		        *(_OWORD *)&v68.colorFormat = v61;
		        *(_OWORD *)&v68.enableRandomWrite = v62;
		        *(_OWORD *)&v68.bindTextureMS = v63;
		        *(_OWORD *)&v68.fastMemoryDesc.inFastMemory = v20;
		        v68.clearColor = clearColor;
		        m_temporalScalerDesc.m_RenderPass = (HGRenderGraphPass *)__PAIR64__(v15.m128i_u32[1], _mm_cvtsi128_si32(v15));
		        v25 = _mm_cvtsi128_si32(v19);
		        m_temporalScalerDesc.m_Resources = (HGRenderGraphResourceRegistry *)__PAIR64__(v19.m128i_u32[1], v25);
		        m_temporalScalerDesc.m_RenderGraph = (HGRenderGraph *)__PAIR64__(_mm_cvtsi128_si32(v17), _mm_cvtsi128_si32(v16));
		        *(_QWORD *)&m_temporalScalerDesc.m_Disposed = __PAIR64__(v22, _mm_cvtsi128_si32(v18));
		        v26 = *(__m128i *)&m_temporalScalerDesc.m_RenderPass;
		        inputWidth = m_temporalScalerDesc;
		        v27 = *(__m128i *)&m_temporalScalerDesc.m_RenderGraph;
		        if ( this->fields.m_temporalScalerHandle )
		        {
		          m_temporalScalerDesc = (HGRenderGraphBuilder)this->fields.m_temporalScalerDesc;
		          if ( HG::Rendering::Runtime::MetalFXTemporalPassConstructor::MetalFXTemporalScalerDesc::Equals(
		                 (MetalFXTemporalPassConstructor_MetalFXTemporalScalerDesc *)&inputWidth,
		                 (MetalFXTemporalPassConstructor_MetalFXTemporalScalerDesc *)&m_temporalScalerDesc,
		                 0LL) )
		          {
		LABEL_14:
		            *(TextureHandle *)&inputWidth.m_RenderPass = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                            (TextureHandle *)&inputWidth,
		                                                            renderGraph,
		                                                            &v68,
		                                                            0LL);
		            m_temporalScalerHandle = this->fields.m_temporalScalerHandle;
		            if ( !v55 )
		              sub_1800D8250(m_temporalScalerHandle, v33);
		            LODWORD(v55[1].klass) = m_temporalScalerHandle;
		            if ( !v55 )
		              sub_1800D8250(m_temporalScalerHandle, v33);
		            BYTE4(v55[1].klass) = v10;
		            v35 = v55;
		            v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                     (TextureHandle *)&m_temporalScalerDesc,
		                     &v59,
		                     &input->colorTexture,
		                     0LL);
		            if ( !v35 )
		              sub_1800D8250(v37, v36);
		            *(TextureHandle *)&v35[1].monitor = v38;
		            v39 = v55;
		            v42 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                     (TextureHandle *)&m_temporalScalerDesc,
		                     &v59,
		                     &input->depthTexture,
		                     0LL);
		            if ( !v39 )
		              sub_1800D8250(v41, v40);
		            *(TextureHandle *)&v39[2].monitor = v42;
		            v43 = v55;
		            v46 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                     (TextureHandle *)&m_temporalScalerDesc,
		                     &v59,
		                     &input->motionTexture,
		                     0LL);
		            if ( !v43 )
		              sub_1800D8250(v45, v44);
		            *(TextureHandle *)&v43[3].monitor = v46;
		            v47 = v55;
		            v50 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                     (TextureHandle *)&m_temporalScalerDesc,
		                     &v59,
		                     (TextureHandle *)&inputWidth,
		                     0LL);
		            if ( !v47 )
		              sub_1800D8250(v49, v48);
		            *(TextureHandle *)&v47[4].monitor = v50;
		            if ( !v55 )
		              sub_1800D8250(v49, v48);
		            LOBYTE(v55[5].monitor) = 1;
		            if ( !camera )
		              sub_1800D8250(v49, v48);
		            v51 = v55;
		            if ( !v55 )
		              sub_1800D8250(0LL, v48);
		            HIDWORD(v55[5].monitor) = LODWORD(camera->fields.taaJitter.x);
		            if ( !v55 )
		              sub_1800D8250(v51, v48);
		            *(float *)&v55[6].klass = -camera->fields.taaJitter.y;
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v59, 0, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		              &v59,
		              (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor->static_fields->s_metalFXTemporalRenderFunc,
		              0LL,
		              0,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MetalFXTemporalPassConstructor::MetalFXTemporalPassData>);
		            *output = *(MetalFXTemporalPassConstructor_PassOutput *)&inputWidth.m_RenderPass;
		            goto LABEL_44;
		          }
		          v10 = 1;
		          UnityEngine::HyperGryph::HGGraphicsUtils::DestroyMetalFXTemporalScaler(
		            this->fields.m_temporalScalerHandle,
		            0LL);
		          v28 = *(__m128i *)&inputWidth.m_RenderPass;
		          *(_OWORD *)&this->fields.m_temporalScalerDesc.inputWidth = *(_OWORD *)&inputWidth.m_RenderPass;
		          depthTextureFormat = *(__m128i *)&inputWidth.m_RenderGraph;
		          *(_OWORD *)&this->fields.m_temporalScalerDesc.colorTextureFormat = *(_OWORD *)&inputWidth.m_RenderGraph;
		          motionTextureFormat = _mm_srli_si128(depthTextureFormat, 8).m128i_u64[0];
		          v31 = _mm_srli_si128(v28, 8).m128i_u64[0];
		          MetalFXTemporalScaler = UnityEngine::HyperGryph::HGGraphicsUtils::CreateMetalFXTemporalScaler(
		                                    v28.m128i_i32[0],
		                                    v28.m128i_i32[1],
		                                    v31,
		                                    SHIDWORD(v31),
		                                    (GraphicsFormat__Enum)_mm_cvtsi128_si32(depthTextureFormat),
		                                    (GraphicsFormat__Enum)depthTextureFormat.m128i_i32[1],
		                                    (GraphicsFormat__Enum)motionTextureFormat,
		                                    HIDWORD(motionTextureFormat),
		                                    0LL);
		        }
		        else
		        {
		          v10 = 1;
		          *(_OWORD *)&this->fields.m_temporalScalerDesc.inputWidth = *(_OWORD *)&m_temporalScalerDesc.m_RenderPass;
		          *(__m128i *)&this->fields.m_temporalScalerDesc.colorTextureFormat = v27;
		          MetalFXTemporalScaler = UnityEngine::HyperGryph::HGGraphicsUtils::CreateMetalFXTemporalScaler(
		                                    _mm_cvtsi128_si32(v15),
		                                    v26.m128i_i32[1],
		                                    v25,
		                                    _mm_srli_si128(v26, 8).m128i_i32[1],
		                                    (GraphicsFormat__Enum)_mm_cvtsi128_si32(v16),
		                                    (GraphicsFormat__Enum)v27.m128i_i32[1],
		                                    (GraphicsFormat__Enum)_mm_cvtsi128_si32(v18),
		                                    (GraphicsFormat__Enum)_mm_srli_si128(v27, 8).m128i_i32[1],
		                                    0LL);
		        }
		        this->fields.m_temporalScalerHandle = MetalFXTemporalScaler;
		        goto LABEL_14;
		      }
		      catch ( Il2CppExceptionWrapper *v66 )
		      {
		        v58[0] = v66->ex;
		      }
		LABEL_44:
		      sub_180268AE0(v58);
		      return;
		    }
		    if ( this->fields.m_temporalScalerHandle )
		    {
		      UnityEngine::HyperGryph::HGGraphicsUtils::DestroyMetalFXTemporalScaler(this->fields.m_temporalScalerHandle, 0LL);
		      *(_OWORD *)&this->fields.m_temporalScalerDesc.inputWidth = 0LL;
		      *(_OWORD *)&this->fields.m_temporalScalerDesc.colorTextureFormat = 0LL;
		      this->fields.m_temporalScalerHandle = 0;
		    }
		    *output = (MetalFXTemporalPassConstructor_PassOutput)input->colorTexture;
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80080-0x0000000184D800B0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::MetalFXTemporalPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        MetalFXTemporalPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3254, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3254, 0LL);
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
