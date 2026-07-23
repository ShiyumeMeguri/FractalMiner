using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class BuildHZBPass : IPassConstructor // TypeDefIndex: 38331
	{
		// Fields
		private ComputeShader m_computeShader; // 0x10
		private TextureHandle m_HZBTexture; // 0x18
		private TextureHandle m_prevHZBTexture; // 0x28
		private static readonly RenderFunc<PassData> s_RenderFunc; // 0x00
	
		// Properties
		public TextureHandle HZBTexture { get => default; } // 0x0000000189BB93D4-0x0000000189BB943C 
		// TextureHandle get_HZBTexture()
		TextureHandle *HG::Rendering::Runtime::BuildHZBPass::get_HZBTexture(
		        TextureHandle *__return_ptr retstr,
		        BuildHZBPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_HZBTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3219, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3219, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_HZBTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_HZBTexture = this->fields.m_HZBTexture;
		  }
		  result = retstr;
		  *retstr = m_HZBTexture;
		  return result;
		}
		
		public TextureHandle prevHZBTexture { get => default; } // 0x0000000189BB943C-0x0000000189BB94A4 
		// TextureHandle get_prevHZBTexture()
		TextureHandle *HG::Rendering::Runtime::BuildHZBPass::get_prevHZBTexture(
		        TextureHandle *__return_ptr retstr,
		        BuildHZBPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_prevHZBTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3220, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3220, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_prevHZBTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_prevHZBTexture = this->fields.m_prevHZBTexture;
		  }
		  result = retstr;
		  *retstr = m_prevHZBTexture;
		  return result;
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38326
		{
			// Fields
			public TextureHandle depthTexture; // 0x00
			public bool buildHZB; // 0x10
		}
	
		internal struct PassOutput // TypeDefIndex: 38327
		{
			// Fields
			public TextureHandle HZBTexture; // 0x00
		}
	
		public struct CBufferData // TypeDefIndex: 38328
		{
			// Fields
			public Vector4 textureSize; // 0x00
			public Vector4 parentSize; // 0x10
			public Vector4 param0; // 0x20
		}
	
		private class PassData // TypeDefIndex: 38329
		{
			// Fields
			public Vector2Int depthTextureSize; // 0x10
			public Vector2Int HZBTextureSize; // 0x18
			public TextureHandle depthTexture; // 0x20
			public TextureHandle HZBTexture; // 0x30
			public ComputeShader computeShader; // 0x40
	
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
		public BuildHZBPass() {} // Dummy constructor
		internal BuildHZBPass(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB500-0x0000000182EDB580
		// BuildHZBPass(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::BuildHZBPass::BuildHZBPass(
		        BuildHZBPass *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  __int64 v6; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  TextureHandle v9; // xmm0
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  TextureHandle v12; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v13; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_HZBTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v12, 0LL);
		  v9 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v12, 0LL);
		  defaultResources = resources->defaultResources;
		  this->fields.m_prevHZBTexture = v9;
		  if ( !defaultResources || (shaders = defaultResources->fields.shaders) == 0LL )
		    sub_1800D8260(v6, v5);
		  this->fields.m_computeShader = shaders->fields.buildHZBCS;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v5, v7, v8, v13);
		}
		
		static BuildHZBPass() {} // 0x0000000184D2D150-0x0000000184D2D1E0
		// BuildHZBPass()
		void HG::Rendering::Runtime::BuildHZBPass::cctor(MethodInfo *method)
		{
		  struct BuildHZBPass_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_BuildHZBPass_PassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::BuildHZBPass::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::BuildHZBPass::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::BuildHZBPass::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::BuildHZBPass::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::BuildHZBPass::PassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_BuildHZBPass_PassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::BuildHZBPass::__c::__cctor_b__20_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::BuildHZBPass->static_fields->s_RenderFunc = v6;
		  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::BuildHZBPass->static_fields, v7, v8, v9, v10);
		}
		
	
		// Methods
		private static int GetHZBSizeShiftBits() => default; // 0x0000000189BB91A8-0x0000000189BB91EC
		// Int32 GetHZBSizeShiftBits()
		int32_t HG::Rendering::Runtime::BuildHZBPass::GetHZBSizeShiftBits(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3221, 0LL) )
		    return 2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3221, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		private static int ApplyHZBSizeShiftBits(int size, int shiftBits) => default; // 0x0000000189BB8BE8-0x0000000189BB8C54
		// Int32 ApplyHZBSizeShiftBits(Int32, Int32)
		int32_t HG::Rendering::Runtime::BuildHZBPass::ApplyHZBSizeShiftBits(
		        int32_t size,
		        int32_t shiftBits,
		        MethodInfo *method)
		{
		  int32_t result; // eax
		  int v6; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3222, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3222, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_50((ILFixDynamicMethodWrapper_15 *)Patch, size, shiftBits, 0LL);
		  }
		  else
		  {
		    result = 1;
		    if ( size <= 1 )
		      size = 1;
		    v6 = size >> (shiftBits & 0x1F);
		    if ( v6 > 1 )
		      return v6;
		  }
		  return result;
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BB8C54-0x0000000189BB91A8
		// Void ConstructPass(BuildHZBPass+PassInput ByRef, BuildHZBPass+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::BuildHZBPass::ConstructPass(
		        BuildHZBPass *this,
		        BuildHZBPass_PassInput *input,
		        BuildHZBPass_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Object *v13; // rbx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  TextureHandle v16; // xmm0
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  int32_t HZBSizeShiftBits; // edi
		  ResourceHandle *v20; // rbx
		  int32_t PowerOfTwo; // eax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  int32_t v24; // esi
		  int32_t v25; // eax
		  int32_t v26; // eax
		  __int64 v27; // rdx
		  signed __int64 v28; // rcx
		  Object *v29; // rdx
		  unsigned int v30; // edx
		  unsigned __int64 v31; // r8
		  signed __int64 v32; // rtt
		  int32_t monitor; // edi
		  int32_t monitor_high; // ebx
		  __int128 v35; // xmm2
		  __int128 v36; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v38; // r8
		  signed __int64 v39; // rtt
		  Object *v40; // rbx
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  TextureHandle v43; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  Object *v47; // [rsp+40h] [rbp-1A8h] BYREF
		  TextureHandle v48; // [rsp+48h] [rbp-1A0h] BYREF
		  HGRenderGraphBuilder v49; // [rsp+58h] [rbp-190h] BYREF
		  HGRenderGraphBuilder v50; // [rsp+78h] [rbp-170h] BYREF
		  __int128 v51; // [rsp+A0h] [rbp-148h] BYREF
		  __int128 v52; // [rsp+B0h] [rbp-138h]
		  __int128 v53; // [rsp+C0h] [rbp-128h]
		  __int128 v54; // [rsp+D0h] [rbp-118h] BYREF
		  __int128 v55; // [rsp+E0h] [rbp-108h]
		  Color v56; // [rsp+F0h] [rbp-F8h]
		  Il2CppExceptionWrapper *v57; // [rsp+100h] [rbp-E8h] BYREF
		  TextureDesc v58; // [rsp+110h] [rbp-D8h] BYREF
		  TextureDesc v59; // [rsp+170h] [rbp-78h] BYREF
		
		  v47 = 0LL;
		  sub_18033B9D0(&v59, 0LL, 96LL);
		  sub_18033B9D0(&v51, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3223, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3223, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v46, v45);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1187(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else if ( input->buildHZB )
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x25u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v49,
		      renderGraph,
		      (String *)"Build HZB",
		      &v47,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BuildHZBPass::PassData>);
		    v50 = v49;
		    v49.m_RenderPass = 0LL;
		    v49.m_Resources = (HGRenderGraphResourceRegistry *)&v50;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v50, 0, 0LL);
		      v13 = v47;
		      v16 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v48, &v50, &input->depthTexture, 0LL);
		      if ( !v13 )
		        sub_1800D8250(v15, v14);
		      v13[2] = (Object)v16;
		      if ( !hgCamera )
		        sub_1800D8250(v15, v14);
		      if ( !v47 )
		        sub_1800D8250(0LL, v14);
		      v47[1].klass = (Object__Class *)hgCamera->fields._sceneRTSize_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
		      HZBSizeShiftBits = HG::Rendering::Runtime::BuildHZBPass::GetHZBSizeShiftBits(0LL);
		      v20 = (ResourceHandle *)v47;
		      if ( !v47 )
		        sub_1800D8250(v18, v17);
		      PowerOfTwo = UnityEngine::Mathf::NextPowerOfTwo((LODWORD(v47[1].klass) + 1) / 2, 0LL);
		      v24 = HG::Rendering::Runtime::BuildHZBPass::ApplyHZBSizeShiftBits(PowerOfTwo, HZBSizeShiftBits, 0LL);
		      if ( !v47 )
		        sub_1800D8250(v23, v22);
		      v25 = UnityEngine::Mathf::NextPowerOfTwo((HIDWORD(v47[1].klass) + 1) / 2, 0LL);
		      v26 = HG::Rendering::Runtime::BuildHZBPass::ApplyHZBSizeShiftBits(v25, HZBSizeShiftBits, 0LL);
		      v48.handle.m_Value = v24;
		      v48.handle._type_k__BackingField = v26;
		      if ( !v20 )
		        sub_1800D8250(v28, v27);
		      v20[3] = v48.handle;
		      v29 = v47;
		      if ( !v47 )
		        sub_1800D8250(v28, 0LL);
		      v47[4].klass = (Object__Class *)this->fields.m_computeShader;
		      if ( dword_18F35FD08 )
		      {
		        v30 = ((unsigned __int64)&v29[4] >> 12) & 0x1FFFFF;
		        v31 = (unsigned __int64)v30 >> 6;
		        v29 = (Object *)(v30 & 0x3F);
		        _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		        do
		        {
		          v28 = qword_18F0BCBA0[v31 + 36190] | (1LL << (char)v29);
		          v32 = qword_18F0BCBA0[v31 + 36190];
		        }
		        while ( v32 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v31 + 36190], v28, v32) );
		      }
		      if ( !v47 )
		        sub_1800D8250(v28, v29);
		      monitor = (int32_t)v47[1].monitor;
		      monitor_high = HIDWORD(v47[1].monitor);
		      sub_18033B9D0(&v58, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v58, monitor, monitor_high, 0LL);
		      v35 = *(_OWORD *)&v58.width;
		      v51 = *(_OWORD *)&v58.width;
		      v52 = *(_OWORD *)&v58.colorFormat;
		      v53 = *(_OWORD *)&v58.enableRandomWrite;
		      *(_QWORD *)&v54 = *(_QWORD *)&v58.bindTextureMS;
		      v36 = *(_OWORD *)&v58.fastMemoryDesc.inFastMemory;
		      v55 = *(_OWORD *)&v58.fastMemoryDesc.inFastMemory;
		      clearColor = v58.clearColor;
		      v56 = v58.clearColor;
		      *((_QWORD *)&v54 + 1) = "HZB";
		      if ( dword_18F35FD08 )
		      {
		        v38 = ((((unsigned __int64)&v54 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		        do
		          v39 = qword_18F0BCBA0[v38 + 36190];
		        while ( v39 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v38 + 36190],
		                         v39 | (1LL << ((((unsigned __int64)&v54 + 8) >> 12) & 0x3F)),
		                         v39) );
		        clearColor = v56;
		        v36 = v55;
		        v35 = v51;
		      }
		      LODWORD(v52) = 49;
		      LOWORD(v53) = 257;
		      BYTE2(v53) = 0;
		      *(_OWORD *)&v59.width = v35;
		      *(_OWORD *)&v59.colorFormat = v52;
		      *(_OWORD *)&v59.enableRandomWrite = v53;
		      *(_OWORD *)&v59.bindTextureMS = v54;
		      *(_OWORD *)&v59.fastMemoryDesc.inFastMemory = v36;
		      v59.clearColor = clearColor;
		      this->fields.m_HZBTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                     &v48,
		                                     renderGraph,
		                                     &v59,
		                                     0LL);
		      v40 = v47;
		      v43 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               &v48,
		               &v50,
		               &this->fields.m_HZBTexture,
		               0LL);
		      if ( !v40 )
		        sub_1800D8250(v42, v41);
		      v40[3] = (Object)v43;
		      if ( !v47 )
		        sub_1800D8250(v42, v41);
		      *output = (BuildHZBPass_PassOutput)v47[3];
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v50,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::BuildHZBPass->static_fields->s_RenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BuildHZBPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v57 )
		    {
		      v49.m_RenderPass = (HGRenderGraphPass *)v57->ex;
		    }
		    sub_180268AE0(&v49);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_HZBTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                   (TextureHandle *)&v49,
		                                   0LL);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BB9380-0x0000000189BB93D4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        BuildHZBPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3224, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3224, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BB9308-0x0000000189BB9380
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        BuildHZBPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3225, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3225, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_HZBTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v8, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BB91EC-0x0000000189BB9308
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        BuildHZBPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  HGRenderGraph *renderGraph; // rdx
		  TextureHandle *p_m_HZBTexture; // r8
		  TextureHandle *nullHandle; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3226, 0LL) )
		  {
		    if ( input->passSkipped )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_HZBTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_HZBTexture, 0LL) )
		      {
		        renderGraph = input->renderGraph;
		        if ( renderGraph )
		        {
		          p_m_HZBTexture = &this->fields.m_HZBTexture;
		LABEL_12:
		          nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                         &v10,
		                         renderGraph,
		                         p_m_HZBTexture,
		                         1,
		                         (String *)"HZB",
		                         0LL);
		          goto LABEL_13;
		        }
		LABEL_15:
		        sub_1800D8260(v5, renderGraph);
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    }
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_prevHZBTexture, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		LABEL_13:
		      this->fields.m_prevHZBTexture = *nullHandle;
		      return;
		    }
		    renderGraph = input->renderGraph;
		    if ( renderGraph )
		    {
		      p_m_HZBTexture = &this->fields.m_prevHZBTexture;
		      goto LABEL_12;
		    }
		    goto LABEL_15;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3226, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80830-0x0000000184D80860
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::BuildHZBPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        BuildHZBPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3227, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3227, 0LL);
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
