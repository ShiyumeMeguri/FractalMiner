using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class BinningPass : IPassConstructor // TypeDefIndex: 38180
	{
		// Fields
		private BinningData m_lightBinningData; // 0x10
		private BinningData m_reflectionProbeBinningData; // 0x2C
		private ComputeBufferHandle m_binningBuffer; // 0x48
		private static RenderFunc<PassData> s_renderFunc; // 0x00
	
		// Properties
		public BinningData lightBinningData { get => default; } // 0x0000000189B90980-0x0000000189B909FC 
		// BinningPass+BinningData get_lightBinningData()
		BinningPass_BinningData *HG::Rendering::Runtime::BinningPass::get_lightBinningData(
		        BinningPass_BinningData *__return_ptr retstr,
		        BinningPass *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  int32_t uintCount; // eax
		  __int64 v7; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  BinningPass_BinningData *v11; // rax
		  BinningPass_BinningData v13; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3009, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3009, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1119(&v13, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v11->tileSize;
		    v7 = *(_QWORD *)&v11->xyOffset;
		    uintCount = v11->uintCount;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_lightBinningData.tileSize;
		    uintCount = this->fields.m_lightBinningData.uintCount;
		    v7 = *(_QWORD *)&this->fields.m_lightBinningData.xyOffset;
		  }
		  *(_OWORD *)&retstr->tileSize = v5;
		  *(_QWORD *)&retstr->xyOffset = v7;
		  retstr->uintCount = uintCount;
		  return retstr;
		}
		
		public BinningData reflectionProbeBinningData { get => default; } // 0x0000000189B909FC-0x0000000189B90A78 
		// BinningPass+BinningData get_reflectionProbeBinningData()
		BinningPass_BinningData *HG::Rendering::Runtime::BinningPass::get_reflectionProbeBinningData(
		        BinningPass_BinningData *__return_ptr retstr,
		        BinningPass *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  int32_t uintCount; // eax
		  __int64 v7; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  BinningPass_BinningData *v11; // rax
		  BinningPass_BinningData v13; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3010, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3010, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1119(&v13, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v11->tileSize;
		    v7 = *(_QWORD *)&v11->xyOffset;
		    uintCount = v11->uintCount;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_reflectionProbeBinningData.tileSize;
		    uintCount = this->fields.m_reflectionProbeBinningData.uintCount;
		    v7 = *(_QWORD *)&this->fields.m_reflectionProbeBinningData.xyOffset;
		  }
		  *(_OWORD *)&retstr->tileSize = v5;
		  *(_QWORD *)&retstr->xyOffset = v7;
		  retstr->uintCount = uintCount;
		  return retstr;
		}
		
		public ComputeBufferHandle binningBuffer { get => default; } // 0x0000000189B90930-0x0000000189B90980 
		// ComputeBufferHandle get_binningBuffer()
		ComputeBufferHandle HG::Rendering::Runtime::BinningPass::get_binningBuffer(BinningPass *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3011, 0LL) )
		    return this->fields.m_binningBuffer;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3011, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_764(Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public struct BinningData // TypeDefIndex: 38177
		{
			// Fields
			public int tileSize; // 0x00
			public int tileX; // 0x04
			public int tileY; // 0x08
			public int sliceZ; // 0x0C
			public int xyOffset; // 0x10
			public int zOffset; // 0x14
			public int uintCount; // 0x18
		}
	
		private class PassData // TypeDefIndex: 38178
		{
			// Fields
			public ComputeBufferHandle binningBuffer; // 0x10
	
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
		public BinningPass() {} // 0x0000000184CDE610-0x0000000184CDE640
		// BinningPass()
		void HG::Rendering::Runtime::BinningPass::BinningPass(BinningPass *this, MethodInfo *method)
		{
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		  this->fields.m_binningBuffer = HG::Rendering::RenderGraphModule::ComputeBufferHandle::get_nullHandle(0LL);
		}
		
		static BinningPass() {} // 0x0000000184D2D1E0-0x0000000184D2D270
		// BinningPass()
		void HG::Rendering::Runtime::BinningPass::cctor(MethodInfo *method)
		{
		  struct BinningPass_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_BinningPass_PassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::BinningPass::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::BinningPass::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::BinningPass::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::BinningPass::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::BinningPass::PassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_BinningPass_PassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::BinningPass::__c::__cctor_b__20_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::BinningPass->static_fields->s_renderFunc = v6;
		  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::BinningPass->static_fields, v7, v8, v9, v10);
		}
		
	
		// Methods
		public void Prepare(HGRenderGraph renderGraph) {} // 0x0000000189B90884-0x0000000189B90930
		// Void Prepare(HGRenderGraph)
		void HG::Rendering::Runtime::BinningPass::Prepare(BinningPass *this, HGRenderGraph *renderGraph, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _BYTE v8[20]; // [rsp+20h] [rbp-38h]
		  ComputeBufferDesc desc; // [rsp+38h] [rbp-20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3012, 0LL) )
		  {
		    *(_DWORD *)v8 = this->fields.m_lightBinningData.uintCount + this->fields.m_reflectionProbeBinningData.uintCount;
		    *(_OWORD *)&v8[4] = 0x1000000004uLL;
		    desc.name = 0LL;
		    *(_OWORD *)&desc.count = *(_OWORD *)v8;
		    if ( renderGraph )
		    {
		      this->fields.m_binningBuffer = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		                                       renderGraph,
		                                       &desc,
		                                       0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3012, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
		public void ConstructPass(HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B9039C-0x0000000189B90558
		// Void ConstructPass(HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::BinningPass::ConstructPass(
		        BinningPass *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  ComputeBufferHandle *v10; // rbx
		  ComputeBufferHandle v11; // rax
		  ComputeBufferHandle v12; // rdx
		  ComputeBufferHandle v13; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ComputeBufferHandle *v17; // [rsp+40h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v18; // [rsp+48h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v19; // [rsp+50h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v20; // [rsp+70h] [rbp-28h] BYREF
		
		  v17 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3013, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3013, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x20u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v19,
		      renderGraph,
		      (String *)"Binning Pass",
		      (Object **)&v17,
		      v7,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BinningPass::PassData>);
		    v20 = v19;
		    v19.m_RenderPass = 0LL;
		    v19.m_Resources = (HGRenderGraphResourceRegistry *)&v20;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v20, 0, 0LL);
		      v10 = v17;
		      v11 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		              &v20,
		              &this->fields.m_binningBuffer,
		              0LL);
		      if ( !v10 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v13, v12);
		      v10[2] = v11;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::BinningPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v20,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::BinningPass->static_fields->s_renderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BinningPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v18 )
		    {
		      v19.m_RenderPass = (HGRenderGraphPass *)v18->ex;
		    }
		    sub_180268AE0(&v19);
		  }
		}
		
		private BinningData GenerateBinningData(Vector2Int rtSize, int tileSize, int sliceZ, int uintCountPerBin, ref int baseOffset) => default; // 0x0000000189B90558-0x0000000189B90694
		// BinningPass+BinningData GenerateBinningData(Vector2Int, Int32, Int32, Int32, Int32 ByRef)
		BinningPass_BinningData *HG::Rendering::Runtime::BinningPass::GenerateBinningData(
		        BinningPass_BinningData *__return_ptr retstr,
		        BinningPass *this,
		        Vector2Int rtSize,
		        int32_t tileSize,
		        int32_t sliceZ,
		        int32_t uintCountPerBin,
		        int32_t *baseOffset,
		        MethodInfo *method)
		{
		  int32_t v10; // edi
		  int v13; // eax
		  int32_t v14; // r8d
		  __int64 v15; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v17; // rcx
		  BinningPass_BinningData *v18; // rax
		  __int128 v19; // xmm0
		  __int64 v20; // xmm1_8
		  BinningPass_BinningData v22; // [rsp+50h] [rbp-20h] BYREF
		  int32_t m_Y; // [rsp+A4h] [rbp+34h]
		
		  m_Y = rtSize.m_Y;
		  v10 = 0;
		  v22.tileY = 0;
		  v22.uintCount = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3014, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3014, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, 0LL);
		    v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1120(
		            &v22,
		            Patch,
		            (Object *)this,
		            rtSize,
		            tileSize,
		            sliceZ,
		            uintCountPerBin,
		            baseOffset,
		            0LL);
		    v19 = *(_OWORD *)&v18->tileSize;
		    v20 = *(_QWORD *)&v18->xyOffset;
		    LODWORD(v18) = v18->uintCount;
		    *(_OWORD *)&retstr->tileSize = v19;
		    *(_QWORD *)&retstr->xyOffset = v20;
		    retstr->uintCount = (int)v18;
		  }
		  else
		  {
		    v22.tileSize = tileSize;
		    if ( tileSize <= 0 )
		    {
		      v22.tileX = 0;
		    }
		    else
		    {
		      v22.tileX = (rtSize.m_X + tileSize - 1) / tileSize;
		      v10 = (tileSize + m_Y - 1) / tileSize;
		    }
		    v22.tileY = v10;
		    v22.xyOffset = *baseOffset;
		    v22.sliceZ = sliceZ;
		    v13 = uintCountPerBin * v10 * v22.tileX;
		    v14 = uintCountPerBin * (sliceZ + v10 * v22.tileX);
		    *(_OWORD *)&retstr->tileSize = *(_OWORD *)&v22.tileSize;
		    v22.zOffset = *baseOffset + v13;
		    v15 = *(_QWORD *)&v22.xyOffset;
		    *baseOffset += v14;
		    *(_QWORD *)&retstr->xyOffset = v15;
		    retstr->uintCount = v14;
		  }
		  return retstr;
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B9073C-0x0000000189B90884
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        BinningPass *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  int32_t x; // eax
		  int32_t NUM_PUNCTUAL_LIGHT_MASK_UNITS; // eax
		  BinningPass_BinningData *v7; // rax
		  int32_t uintCount; // ecx
		  __int64 v9; // xmm0_8
		  BinningPass_BinningData *v10; // rax
		  __int64 v11; // xmm0_8
		  int32_t v12; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Vector2Int v16; // [rsp+40h] [rbp-38h]
		  __int128 v17; // [rsp+40h] [rbp-38h]
		  BinningPass_BinningData v18; // [rsp+50h] [rbp-28h] BYREF
		  int32_t v19; // [rsp+98h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3015, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3015, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		  else
		  {
		    x = (int)shaderVariablesGlobal->_ScreenSize.x;
		    v19 = 0;
		    v16.m_X = x;
		    v16.m_Y = (int)shaderVariablesGlobal->_ScreenSize.y;
		    NUM_PUNCTUAL_LIGHT_MASK_UNITS = HG::Rendering::Runtime::LightConstants::get_NUM_PUNCTUAL_LIGHT_MASK_UNITS(0LL);
		    v7 = HG::Rendering::Runtime::BinningPass::GenerateBinningData(
		           &v18,
		           this,
		           v16,
		           32,
		           2048,
		           NUM_PUNCTUAL_LIGHT_MASK_UNITS,
		           &v19,
		           0LL);
		    uintCount = v7->uintCount;
		    v9 = *(_QWORD *)&v7->xyOffset;
		    *(_OWORD *)&this->fields.m_lightBinningData.tileSize = *(_OWORD *)&v7->tileSize;
		    *(_QWORD *)&this->fields.m_lightBinningData.xyOffset = v9;
		    this->fields.m_lightBinningData.uintCount = uintCount;
		    v10 = HG::Rendering::Runtime::BinningPass::GenerateBinningData(&v18, this, v16, 32, 1024, 1, &v19, 0LL);
		    v11 = *(_QWORD *)&v10->xyOffset;
		    v12 = v10->uintCount;
		    *(_OWORD *)&this->fields.m_reflectionProbeBinningData.tileSize = *(_OWORD *)&v10->tileSize;
		    *(_QWORD *)&this->fields.m_reflectionProbeBinningData.xyOffset = v11;
		    this->fields.m_reflectionProbeBinningData.uintCount = v12;
		    *(_QWORD *)&v17 = *(_QWORD *)&this->fields.m_lightBinningData.xyOffset;
		    *((_QWORD *)&v17 + 1) = *(_QWORD *)&this->fields.m_reflectionProbeBinningData.xyOffset;
		    *(_OWORD *)&shaderVariablesGlobal->_WindMotorParams2.FixedElementField = v17;
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B906E8-0x0000000189B9073C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        BinningPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3016, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3016, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B90694-0x0000000189B906E8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        BinningPass *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3017, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3017, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80860-0x0000000184D80890
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::BinningPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        BinningPass *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3018, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3018, 0LL);
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
