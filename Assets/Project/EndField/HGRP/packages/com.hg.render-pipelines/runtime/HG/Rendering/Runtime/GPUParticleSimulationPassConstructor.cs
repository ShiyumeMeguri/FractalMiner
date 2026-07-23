using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class GPUParticleSimulationPassConstructor : IPassConstructor // TypeDefIndex: 38319
	{
		// Fields
		private const uint SORT_BATCH_SIZE = 4096; // Metadata: 0x02303C7A
		private DynamicArray<SimulateRequiredResources> m_simulateList; // 0x10
		private DynamicArray<SimulateRequiredResources> m_senderSimulateList; // 0x18
		private Dictionary<Guid, int> m_gpuEventDict; // 0x20
		private List<int> m_receivers; // 0x28
		private ComputeShader m_particleCleanupShader; // 0x30
		private ComputeShader m_particleInitShader; // 0x38
		private ComputeShader m_particleCullShader; // 0x40
		private ComputeShader m_particleSortShader; // 0x48
		private ComputeShader m_particleIndirectArgsShader; // 0x50
		private int m_particleCleanupKernel; // 0x58
		private int m_particleInitKernel; // 0x5C
		private int m_particleCullKernel; // 0x60
		private int m_bitonicSortKernel; // 0x64
		private int m_bitonicSortFinalKernel; // 0x68
		private int m_mergeKernel; // 0x6C
		private int m_mergeFinalKernel; // 0x70
		private int m_particleIndirectArgsKernel; // 0x74
		private LocalKeyword m_senderKeyword; // 0x78
		private LocalKeyword m_recieverKeyword; // 0x90
		private static readonly RenderFunc<DepthOnlyPassData> s_occlusionRenderFunc; // 0x00
		private static readonly RenderFunc<PassData> s_renderFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38307
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal TextureHandle sceneNormal; // 0x10
		}
	
		internal struct PassOutput // TypeDefIndex: 38308
		{
		}
	
		private struct MergePassConstants // TypeDefIndex: 38309
		{
			// Fields
			internal uint blockSize; // 0x00
			internal uint groupCount; // 0x04
		}
	
		private struct SortKey // TypeDefIndex: 38310
		{
			// Fields
			internal uint particleIndex; // 0x00
			internal float cameraSpaceDepth; // 0x04
		}
	
		private struct PerFrameBuffer // TypeDefIndex: 38311
		{
			// Fields
			internal uint seed; // 0x00
		}
	
		private struct BufferMapping // TypeDefIndex: 38312
		{
			// Fields
			internal int shaderID; // 0x00
			internal ComputeBufferHandle buffer; // 0x04
		}
	
		private struct TextureMapping // TypeDefIndex: 38313
		{
			// Fields
			internal int shaderID; // 0x00
			internal TextureHandle texture; // 0x04
		}
	
		private struct GPUEventData // TypeDefIndex: 38314
		{
			// Fields
			internal ComputeBufferHandle eventBuffer; // 0x00
			internal ComputeBufferHandle sentCountBuffer; // 0x08
			internal ComputeBufferHandle comsumedCountBuffer; // 0x10
			internal Guid guid; // 0x18
		}
	
		private struct SimulateRequiredResources // TypeDefIndex: 38315
		{
			// Fields
			internal GPUParticleSystemBase gpuParticleSystem; // 0x00
			internal TextureMapping depthOnlyRT; // 0x08
			internal TextureMapping sceneDepth; // 0x1C
			internal TextureMapping sceneNormal; // 0x30
			internal GPUEventData gpuEventData; // 0x44
	
			// Methods
			internal void MarkResourceRead(HGRenderGraphBuilder builder) {} // 0x0000000189BC2388-0x0000000189BC2500
			// Void MarkResourceRead(HGRenderGraphBuilder)
			void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources::MarkResourceRead(
			        GPUParticleSimulationPassConstructor_SimulateRequiredResources *this,
			        HGRenderGraphBuilder *builder,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  __int128 v8; // xmm1
			  HGRenderGraphBuilder v9; // [rsp+20h] [rbp-28h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3209, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3209, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    v8 = *(_OWORD *)&builder->m_RenderGraph;
			    *(_OWORD *)&v9.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
			    *(_OWORD *)&v9.m_RenderGraph = v8;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1183(Patch, this, &v9, 0LL);
			  }
			  else
			  {
			    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->depthOnlyRT.texture, 0LL) )
			      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			        (TextureHandle *)&v9,
			        builder,
			        &this->depthOnlyRT.texture,
			        0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->sceneDepth.texture, 0LL) )
			      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			        (TextureHandle *)&v9,
			        builder,
			        &this->sceneDepth.texture,
			        0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->sceneNormal.texture, 0LL) )
			      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			        (TextureHandle *)&v9,
			        builder,
			        &this->sceneNormal.texture,
			        0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			    if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&this->gpuEventData.eventBuffer, 0LL) )
			      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			        builder,
			        &this->gpuEventData.eventBuffer,
			        0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			    if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&this->gpuEventData.sentCountBuffer, 0LL) )
			      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			        builder,
			        &this->gpuEventData.sentCountBuffer,
			        0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			    if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&this->gpuEventData.comsumedCountBuffer, 0LL) )
			      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
			        builder,
			        &this->gpuEventData.comsumedCountBuffer,
			        0LL);
			  }
			}
			
		}
	
		private class DepthOnlyPassData // TypeDefIndex: 38316
		{
			// Fields
			internal Matrix4x4 deviceViewProj; // 0x10
			internal Matrix4x4 cullingViewProj; // 0x50
			internal uint ecsRendererList; // 0x90
	
			// Constructors
			public DepthOnlyPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class PassData // TypeDefIndex: 38317
		{
			// Fields
			internal ComputeShader particleCleanupShader; // 0x10
			internal ComputeShader particleInitShader; // 0x18
			internal ComputeShader particleCullShader; // 0x20
			internal ComputeShader particleSortShader; // 0x28
			internal ComputeShader particleIndirectArgsShader; // 0x30
			internal int particleCleanupKernel; // 0x38
			internal int particleInitKernel; // 0x3C
			internal int particleCullKernel; // 0x40
			internal int bitonicSortKernel; // 0x44
			internal int bitonicSortFinalKernel; // 0x48
			internal int mergeKernel; // 0x4C
			internal int mergeFinalKernel; // 0x50
			internal int particleIndirectArgsKernel; // 0x54
			internal ComputeBufferHandle[] stagingLiveListBuffers; // 0x58
			internal ComputeBufferHandle dataForEmitterBuffer; // 0x60
			internal ComputeBufferHandle liveCountBuffer; // 0x68
			internal HGCamera camera; // 0x70
			internal DynamicArray<SimulateRequiredResources> senderSimulateList; // 0x78
			internal DynamicArray<SimulateRequiredResources> simulateList; // 0x80
			internal LocalKeyword senderKeyword; // 0x88
			internal LocalKeyword recieverKeyword; // 0xA0
	
			// Constructors
			public PassData() {} // 0x0000000189BC235C-0x0000000189BC2388
			// GPUParticleSimulationPassConstructor+PassData()
			void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData::PassData(
			        GPUParticleSimulationPassConstructor_PassData *this,
			        MethodInfo *method)
			{
			  Type *v3; // rdx
			  PropertyInfo_1 *v4; // r8
			  Int32__Array **v5; // r9
			  MethodInfo *v6; // [rsp+50h] [rbp+28h]
			
			  this->fields.stagingLiveListBuffers = (ComputeBufferHandle__Array *)il2cpp_array_new_specific_1(
			                                                                        TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle,
			                                                                        2LL);
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields.stagingLiveListBuffers, v3, v4, v5, v6);
			}
			
		}
	
		// Constructors
		public GPUParticleSimulationPassConstructor() {} // Dummy constructor
		internal GPUParticleSimulationPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x000000018454A7F0-0x000000018454AB50
		// GPUParticleSimulationPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::GPUParticleSimulationPassConstructor(
		        GPUParticleSimulationPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v5; // rax
		  Type *v6; // rdx
		  ComputeShader *m_particleCleanupShader; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v8; // rsi
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v12; // rax
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v13; // rsi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  Dictionary_2_System_Guid_System_Int32_ *v17; // rax
		  Dictionary_2_System_Guid_System_Int32_ *v18; // rsi
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v22; // rax
		  List_1_System_Int32_ *v23; // rsi
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **v31; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v32; // rax
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v35; // rax
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v38; // rax
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v41; // rax
		  int32_t Kernel; // eax
		  int32_t v43; // eax
		  int32_t v44; // eax
		  int32_t v45; // eax
		  int32_t v46; // eax
		  int32_t v47; // eax
		  int32_t v48; // eax
		  int32_t v49; // eax
		  ComputeShader *m_particleInitShader; // rdx
		  __int64 v51; // xmm1_8
		  Type *v52; // rdx
		  PropertyInfo_1 *v53; // r8
		  Int32__Array **v54; // r9
		  ComputeShader *v55; // rdx
		  __int64 v56; // xmm1_8
		  Type *v57; // rdx
		  PropertyInfo_1 *v58; // r8
		  Int32__Array **v59; // r9
		  LocalKeyword v60; // [rsp+20h] [rbp-38h] BYREF
		  LocalKeyword v61; // [rsp+38h] [rbp-20h] BYREF
		
		  v5 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>);
		  v8 = (DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *)v5;
		  if ( !v5 )
		    goto LABEL_2;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v5,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::DynamicArray);
		  this->fields.m_simulateList = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v9, v10, v11, (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  v12 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>);
		  v13 = (DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *)v12;
		  if ( !v12 )
		    goto LABEL_2;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v12,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::DynamicArray);
		  this->fields.m_senderSimulateList = v13;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_senderSimulateList,
		    v14,
		    v15,
		    v16,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  v17 = (Dictionary_2_System_Guid_System_Int32_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::Guid,int>);
		  v18 = v17;
		  if ( !v17 )
		    goto LABEL_2;
		  System::Collections::Generic::Dictionary<System::Guid,int>::Dictionary(
		    v17,
		    MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::Dictionary);
		  this->fields.m_gpuEventDict = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_gpuEventDict,
		    v19,
		    v20,
		    v21,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  v22 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  v23 = (List_1_System_Int32_ *)v22;
		  if ( !v22 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v22,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_receivers = v23;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_receivers,
		    v24,
		    v25,
		    v26,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_2;
		  this->fields.m_particleCleanupShader = shaders->fields.particleCleanupCS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_particleCleanupShader,
		    v6,
		    v27,
		    v28,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  v32 = resources->defaultResources->fields.shaders;
		  if ( !v32 )
		    goto LABEL_2;
		  this->fields.m_particleInitShader = v32->fields.particleInitCS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_particleInitShader,
		    v6,
		    v30,
		    v31,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  v35 = resources->defaultResources->fields.shaders;
		  if ( !v35 )
		    goto LABEL_2;
		  this->fields.m_particleCullShader = v35->fields.particleCullCS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_particleCullShader,
		    v6,
		    v33,
		    v34,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  v38 = resources->defaultResources->fields.shaders;
		  if ( !v38 )
		    goto LABEL_2;
		  this->fields.m_particleSortShader = v38->fields.particleSortCS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_particleSortShader,
		    v6,
		    v36,
		    v37,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  v41 = resources->defaultResources->fields.shaders;
		  if ( !v41 )
		    goto LABEL_2;
		  this->fields.m_particleIndirectArgsShader = v41->fields.particleIndirectArgsCS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_particleIndirectArgsShader,
		    v6,
		    v39,
		    v40,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  m_particleCleanupShader = this->fields.m_particleCleanupShader;
		  if ( !m_particleCleanupShader )
		    goto LABEL_2;
		  Kernel = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
		  m_particleCleanupShader = this->fields.m_particleInitShader;
		  this->fields.m_particleCleanupKernel = Kernel;
		  if ( !m_particleCleanupShader )
		    goto LABEL_2;
		  v43 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
		  m_particleCleanupShader = this->fields.m_particleCullShader;
		  this->fields.m_particleInitKernel = v43;
		  if ( !m_particleCleanupShader )
		    goto LABEL_2;
		  v44 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
		  m_particleCleanupShader = this->fields.m_particleSortShader;
		  this->fields.m_particleCullKernel = v44;
		  if ( !m_particleCleanupShader )
		    goto LABEL_2;
		  v45 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"Sort", 0LL);
		  m_particleCleanupShader = this->fields.m_particleSortShader;
		  this->fields.m_bitonicSortKernel = v45;
		  if ( !m_particleCleanupShader )
		    goto LABEL_2;
		  v46 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"SortFinal", 0LL);
		  m_particleCleanupShader = this->fields.m_particleSortShader;
		  this->fields.m_bitonicSortFinalKernel = v46;
		  if ( !m_particleCleanupShader
		    || (v47 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"Merge", 0LL),
		        m_particleCleanupShader = this->fields.m_particleSortShader,
		        this->fields.m_mergeKernel = v47,
		        !m_particleCleanupShader)
		    || (v48 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"MergeFinal", 0LL),
		        m_particleCleanupShader = this->fields.m_particleIndirectArgsShader,
		        this->fields.m_mergeFinalKernel = v48,
		        !m_particleCleanupShader) )
		  {
		LABEL_2:
		    sub_1800D8260(m_particleCleanupShader, v6);
		  }
		  v49 = UnityEngine::ComputeShader::FindKernel(m_particleCleanupShader, (String *)"CSMain", 0LL);
		  m_particleInitShader = this->fields.m_particleInitShader;
		  this->fields.m_particleIndirectArgsKernel = v49;
		  memset(&v60, 0, sizeof(v60));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, m_particleInitShader, (String *)"GPU_EVENT_SENDER", 0LL);
		  v51 = *(_QWORD *)&v60.m_Index;
		  *(_OWORD *)&this->fields.m_senderKeyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v60.m_SpaceInfo.m_KeywordSpace;
		  *(_QWORD *)&this->fields.m_senderKeyword.m_Index = v51;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_senderKeyword.m_Name,
		    v52,
		    v53,
		    v54,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		  v55 = this->fields.m_particleInitShader;
		  memset(&v61, 0, sizeof(v61));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v61, v55, (String *)"GPU_EVENT_RECIEVER", 0LL);
		  v56 = *(_QWORD *)&v61.m_Index;
		  *(_OWORD *)&this->fields.m_recieverKeyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v61.m_SpaceInfo.m_KeywordSpace;
		  *(_QWORD *)&this->fields.m_recieverKeyword.m_Index = v56;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_recieverKeyword.m_Name,
		    v57,
		    v58,
		    v59,
		    (MethodInfo *)v60.m_SpaceInfo.m_KeywordSpace);
		}
		
		static GPUParticleSimulationPassConstructor() {} // 0x0000000184CB4240-0x0000000184CB4340
		// GPUParticleSimulationPassConstructor()
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::cctor(MethodInfo *method)
		{
		  struct GPUParticleSimulationPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Type__Class *v6; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::DepthOnlyPassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c::__cctor_b__40_0,
		          0LL),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::__c::__cctor_b__40_1,
		    0LL);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor->static_fields->s_renderFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BB00E0-0x0000000189BB0134
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        GPUParticleSimulationPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3205, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3205, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BB008C-0x0000000189BB00E0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        GPUParticleSimulationPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3206, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3206, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		private static void ProcessParticles(DynamicArray<SimulateRequiredResources> sysList, PassData data, HGRenderGraphContext context) {} // 0x0000000189BB0134-0x0000000189BB1C48
		// Void ProcessParticles(DynamicArray`1[HG.Rendering.Runtime.GPUParticleSimulationPassConstructor+SimulateRequiredResources], GPUParticleSimulationPassConstructor+PassData, HGRenderGraphContext)
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::ProcessParticles(
		        DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *sysList,
		        GPUParticleSimulationPassConstructor_PassData *data,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  _DWORD *p_CB0; // rcx
		  CommandBuffer *cmd; // r15
		  int32_t Ticks; // eax
		  signed int seed; // esi
		  __int64 v12; // rax
		  bool v13; // zf
		  __m128i v14; // xmm11
		  __m128i v15; // xmm6
		  __m128i v16; // xmm8
		  __m128i v17; // xmm10
		  __m128i v18; // xmm9
		  unsigned int i; // ebx
		  ComputeShader *particleCleanupShader; // r14
		  int32_t size; // eax
		  float v22; // xmm0_4
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *Item; // rbx
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v24; // rax
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v25; // rax
		  bool v26; // al
		  int32_t particleInitKernel; // edi
		  ComputeShader *particleInitShader; // r14
		  LocalKeyword *p_senderKeyword; // r8
		  int32_t GPUEventConsumedCount; // edi
		  ComputeBufferHandle comsumedCountBuffer; // rbx
		  ComputeBuffer *v32; // rax
		  int32_t v33; // r9d
		  int32_t stride; // eax
		  ComputeBufferHandle dataForEmitterBuffer; // rbx
		  int32_t DataForEmitter; // edi
		  ComputeBuffer *v37; // rax
		  ComputeBuffer *v38; // rax
		  int32_t v39; // eax
		  int32_t v40; // ebx
		  int32_t count; // eax
		  int32_t v42; // ebx
		  int32_t v43; // eax
		  int32_t v44; // ebx
		  ComputeBuffer *v45; // rax
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v46; // rbx
		  int32_t shaderID; // ebx
		  TextureHandle texture; // xmm6
		  RenderTargetIdentifier *v49; // rax
		  __int128 v50; // xmm1
		  __int64 v51; // xmm0_8
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v52; // rbx
		  int32_t v53; // ebx
		  TextureHandle v54; // xmm6
		  RenderTargetIdentifier *v55; // rax
		  __int128 v56; // xmm1
		  __int64 v57; // xmm0_8
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v58; // rbx
		  int32_t v59; // ebx
		  TextureHandle v60; // xmm6
		  RenderTargetIdentifier *v61; // rax
		  __int128 v62; // xmm1
		  __int64 v63; // xmm0_8
		  int32_t GPUEventBuffer; // edi
		  ComputeBufferHandle eventBuffer; // rbx
		  ComputeBuffer *v66; // rax
		  int32_t v67; // edi
		  ComputeBufferHandle v68; // rbx
		  ComputeBuffer *v69; // rax
		  int32_t PerFrameVariables; // ebx
		  ComputeShader *v71; // xmm11_8
		  int32_t GeneralGPUParticleSystemAttributes; // ebx
		  int32_t v73; // eax
		  int32_t GPUParticleSystemAttributes; // edi
		  int32_t v75; // ebx
		  int32_t v76; // eax
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v77; // rbx
		  int32_t v78; // ebx
		  TextureHandle v79; // xmm6
		  RenderTargetIdentifier *v80; // rax
		  __int128 v81; // xmm1
		  __int64 v82; // xmm0_8
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v83; // rbx
		  int32_t v84; // ebx
		  TextureHandle v85; // xmm6
		  RenderTargetIdentifier *v86; // rax
		  __int128 v87; // xmm1
		  __int64 v88; // xmm0_8
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v89; // rbx
		  int32_t v90; // ebx
		  TextureHandle v91; // xmm6
		  RenderTargetIdentifier *v92; // rax
		  __int128 v93; // xmm1
		  __int64 v94; // xmm0_8
		  int32_t v95; // edi
		  ComputeBufferHandle v96; // rbx
		  ComputeBuffer *v97; // rax
		  int32_t GPUEventSentCount; // edi
		  ComputeBufferHandle sentCountBuffer; // rbx
		  ComputeBuffer *v100; // rax
		  ComputeShader *particleCullShader; // rsi
		  int32_t particleCullKernel; // r14d
		  int32_t v103; // ebx
		  int32_t v104; // ebx
		  int32_t v105; // eax
		  int32_t v106; // edi
		  int32_t v107; // ebx
		  int32_t v108; // eax
		  int32_t LiveList; // ebx
		  ComputeBuffer *v110; // rax
		  int32_t LiveCount; // ebx
		  ComputeBuffer *v112; // rax
		  ComputeShader *particleSortShader; // r14
		  ComputeBuffer *v114; // rax
		  int32_t bitonicSortFinalKernel; // edi
		  ComputeBuffer *v116; // rbx
		  ComputeBuffer *v117; // rax
		  int32_t v118; // ebx
		  ComputeBuffer *v119; // rax
		  unsigned int v120; // r14d
		  unsigned int v121; // edi
		  int v122; // ecx
		  ComputeShader *v123; // rsi
		  int32_t MergePassConstants; // ebx
		  int32_t InputLiveList; // ebx
		  ComputeBuffer *v126; // rax
		  ComputeBuffer *v127; // rax
		  int32_t v128; // ebx
		  ComputeBuffer *v129; // rax
		  ComputeShader *v130; // rsi
		  float v131; // xmm0_4
		  int32_t v132; // ebx
		  int32_t v133; // ebx
		  ComputeBuffer *v134; // rax
		  int32_t v135; // ebx
		  ComputeBuffer *v136; // rax
		  ComputeShader *particleIndirectArgsShader; // r14
		  int32_t particleIndirectArgsKernel; // esi
		  ComputeBufferHandle liveCountBuffer; // rbx
		  int32_t v140; // edi
		  ComputeBuffer *v141; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  bool IsValid; // [rsp+48h] [rbp-C0h]
		  int32_t threadGroupsX; // [rsp+4Ch] [rbp-BCh]
		  int threadGroupsXa; // [rsp+4Ch] [rbp-BCh]
		  int threadGroupsXb; // [rsp+4Ch] [rbp-BCh]
		  int threadGroupsXc; // [rsp+4Ch] [rbp-BCh]
		  unsigned int threadGroupsXd; // [rsp+4Ch] [rbp-BCh]
		  int32_t val; // [rsp+50h] [rbp-B8h]
		  int32_t vala; // [rsp+50h] [rbp-B8h]
		  int32_t valb; // [rsp+50h] [rbp-B8h]
		  int32_t valc; // [rsp+50h] [rbp-B8h]
		  int vald; // [rsp+50h] [rbp-B8h]
		  int32_t vale; // [rsp+50h] [rbp-B8h]
		  int32_t valf; // [rsp+50h] [rbp-B8h]
		  int32_t kernelIndex; // [rsp+54h] [rbp-B4h]
		  int kernelIndexa; // [rsp+54h] [rbp-B4h]
		  int32_t kernelIndexb; // [rsp+54h] [rbp-B4h]
		  bool nameID; // [rsp+58h] [rbp-B0h]
		  bool nameID_1; // [rsp+59h] [rbp-AFh]
		  int32_t nameID_4; // [rsp+5Ch] [rbp-ACh]
		  int nameID_4a; // [rsp+5Ch] [rbp-ACh]
		  int32_t nameID_4b; // [rsp+5Ch] [rbp-ACh]
		  ComputeBuffer *buffer; // [rsp+60h] [rbp-A8h]
		  int32_t buffera; // [rsp+60h] [rbp-A8h]
		  int32_t bufferb; // [rsp+60h] [rbp-A8h]
		  DateTime v167; // [rsp+68h] [rbp-A0h] BYREF
		  GPUParticleSimulationPassConstructor_PerFrameBuffer dataa[2]; // [rsp+70h] [rbp-98h] BYREF
		  ComputeBuffer *v169; // [rsp+78h] [rbp-90h]
		  ComputeBuffer *v170; // [rsp+80h] [rbp-88h]
		  uint64_t v171; // [rsp+88h] [rbp-80h]
		  TextureHandle v172; // [rsp+98h] [rbp-70h] BYREF
		  RenderTargetIdentifier v173; // [rsp+A8h] [rbp-60h] BYREF
		  ComputeBufferHandle v174; // [rsp+D8h] [rbp-30h] BYREF
		  ComputeBufferHandle v175; // [rsp+E0h] [rbp-28h] BYREF
		  ComputeBufferHandle v176; // [rsp+E8h] [rbp-20h] BYREF
		  ComputeBufferHandle v177; // [rsp+F0h] [rbp-18h] BYREF
		  ComputeBufferHandle v178; // [rsp+F8h] [rbp-10h] BYREF
		  ComputeBufferHandle v179; // [rsp+100h] [rbp-8h] BYREF
		  __m128i v180; // [rsp+168h] [rbp+60h]
		  RenderTargetIdentifier v181[2]; // [rsp+178h] [rbp+70h] BYREF
		  ComputeBuffer *v182[2]; // [rsp+1D8h] [rbp+D0h]
		  __int128 v183; // [rsp+1F8h] [rbp+F0h]
		  _BYTE v184[208]; // [rsp+218h] [rbp+110h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3207, 0LL) )
		  {
		    if ( !context )
		      goto LABEL_65;
		    cmd = context->fields.cmd;
		    sub_1800036A0(TypeInfo::System::DateTime);
		    v167._dateData = System::DateTime::get_Now(0LL)._dateData;
		    Ticks = System::DateTime::get_Ticks(&v167, 0LL);
		    UnityEngine::Random::InitState(Ticks, 0LL);
		    dataa[0].seed = UnityEngine::Random::RandomRangeInt(0x80000000, 0x7FFFFFFF, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
		    UnityEngine::Rendering::ConstantBuffer::UpdateData<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
		      cmd,
		      dataa,
		      MethodInfo::UnityEngine::Rendering::ConstantBuffer::UpdateData<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
		    seed = 0;
		    dataa[0].seed = 0;
		    if ( !sysList )
		      goto LABEL_65;
		    while ( 1 )
		    {
		      if ( seed >= sysList->fields._size_k__BackingField )
		        return;
		      if ( !UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		              sysList,
		              seed,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuParticleSystem )
		        goto LABEL_65;
		      v12 = sub_1808AF468(v184);
		      v13 = *(_DWORD *)(v12 + 96) == 0;
		      v14 = *(__m128i *)v12;
		      v15 = *(__m128i *)(v12 + 16);
		      v16 = *(__m128i *)(v12 + 32);
		      v17 = *(__m128i *)(v12 + 64);
		      v18 = *(__m128i *)(v12 + 96);
		      *(_OWORD *)v182 = *(_OWORD *)(v12 + 48);
		      v183 = *(_OWORD *)(v12 + 80);
		      if ( !v13 )
		      {
		        v13 = *(_QWORD *)(v12 + 104) == 0LL;
		        v167._dateData = _mm_srli_si128(v16, 8).m128i_u64[0];
		        buffer = (ComputeBuffer *)_mm_srli_si128(v15, 8).m128i_u64[0];
		        v170 = (ComputeBuffer *)v17.m128i_i64[0];
		        if ( !v13 )
		        {
		          v180 = v18;
		          for ( i = 0; v18.m128i_i64[1]; ++i )
		          {
		            if ( (signed int)i >= *(_DWORD *)(v18.m128i_i64[1] + 24) )
		              goto LABEL_16;
		            if ( i >= *(_DWORD *)(v18.m128i_i64[1] + 24) )
		              sub_1800D2AB0(p_CB0, v7);
		            val = *(_DWORD *)(v18.m128i_i64[1] + 4LL * (int)i + 32);
		            if ( !data )
		              break;
		            particleCleanupShader = data->fields.particleCleanupShader;
		            kernelIndex = data->fields.particleCleanupKernel;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		            nameID_4 = p_CB0[204];
		            if ( !buffer )
		              break;
		            size = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
		            if ( !cmd )
		              break;
		            UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		              cmd,
		              particleCleanupShader,
		              nameID_4,
		              buffer,
		              0,
		              size,
		              0LL);
		            UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		              cmd,
		              particleCleanupShader,
		              kernelIndex,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ParticleAttributes,
		              (ComputeBuffer *)v167._dateData,
		              0,
		              -1,
		              0LL);
		            UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		              cmd,
		              particleCleanupShader,
		              kernelIndex,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadList,
		              v182[1],
		              0,
		              -1,
		              0LL);
		            UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		              cmd,
		              particleCleanupShader,
		              kernelIndex,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadCount,
		              v170,
		              0,
		              -1,
		              0LL);
		            UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
		              cmd,
		              particleCleanupShader,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CleanupOffset,
		              val,
		              0LL);
		            v22 = sub_1801D3680();
		            UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		              cmd,
		              particleCleanupShader,
		              kernelIndex,
		              (int)v22,
		              1,
		              1,
		              0LL);
		          }
		LABEL_65:
		          sub_1800D8260(p_CB0, v7);
		        }
		LABEL_16:
		        kernelIndexa = _mm_cvtsi128_si32(v18);
		        nameID_4a = v183 * kernelIndexa;
		        Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                 sysList,
		                 seed,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		        IsValid = HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&Item->gpuEventData.eventBuffer, 0LL);
		        v24 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        nameID_1 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(
		                     &v24->gpuEventData.sentCountBuffer,
		                     0LL);
		        v25 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        v26 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(
		                &v25->gpuEventData.comsumedCountBuffer,
		                0LL);
		        nameID = v26;
		        if ( !data )
		          goto LABEL_65;
		        particleInitKernel = data->fields.particleInitKernel;
		        p_CB0 = 0LL;
		        particleInitShader = data->fields.particleInitShader;
		        threadGroupsX = particleInitKernel;
		        if ( !cmd )
		          goto LABEL_65;
		        p_senderKeyword = &data->fields.senderKeyword;
		        if ( IsValid )
		        {
		          if ( v26 )
		          {
		            UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, particleInitShader, p_senderKeyword, 0, 0LL);
		            UnityEngine::Rendering::CommandBuffer::SetKeyword(
		              cmd,
		              particleInitShader,
		              &data->fields.recieverKeyword,
		              1,
		              0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            GPUEventConsumedCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventConsumedCount;
		            comsumedCountBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                                    sysList,
		                                    seed,
		                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.comsumedCountBuffer;
		          }
		          else
		          {
		            UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, particleInitShader, p_senderKeyword, 1, 0LL);
		            UnityEngine::Rendering::CommandBuffer::SetKeyword(
		              cmd,
		              particleInitShader,
		              &data->fields.recieverKeyword,
		              0,
		              0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            GPUEventConsumedCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventSentCount;
		            comsumedCountBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                                    sysList,
		                                    seed,
		                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.sentCountBuffer;
		          }
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v32 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(comsumedCountBuffer, 0LL);
		          v33 = GPUEventConsumedCount;
		          particleInitKernel = threadGroupsX;
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            particleInitShader,
		            threadGroupsX,
		            v33,
		            v32,
		            0,
		            -1,
		            0LL);
		        }
		        else
		        {
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, particleInitShader, p_senderKeyword, 0, 0LL);
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            particleInitShader,
		            &data->fields.recieverKeyword,
		            0,
		            0LL);
		          IsValid = 0;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		        vala = p_CB0[204];
		        if ( !buffer )
		          goto LABEL_65;
		        stride = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          particleInitShader,
		          vala,
		          buffer,
		          0,
		          stride,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleInitShader,
		          particleInitKernel,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadCount,
		          v170,
		          0,
		          -1,
		          0LL);
		        dataForEmitterBuffer = data->fields.dataForEmitterBuffer;
		        DataForEmitter = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DataForEmitter;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		        v37 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(dataForEmitterBuffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleInitShader,
		          threadGroupsX,
		          DataForEmitter,
		          v37,
		          0,
		          -1,
		          0LL);
		        dataForEmitterBuffer.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount;
		        v38 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data->fields.liveCountBuffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleInitShader,
		          threadGroupsX,
		          dataForEmitterBuffer.handle.m_Value,
		          v38,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
		          cmd,
		          particleInitShader,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InstanceCount,
		          kernelIndexa,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          particleInitShader,
		          threadGroupsX,
		          1,
		          1,
		          1,
		          0LL);
		        sub_1800036A0(TypeInfo::System::Math);
		        threadGroupsXa = (int)sub_1801D3680();
		        dataForEmitterBuffer.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerFrameVariables;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
		        UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          dataForEmitterBuffer.handle.m_Value,
		          MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
		        dataForEmitterBuffer.handle.m_Value = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GeneralGPUParticleSystemAttributes;
		        v39 = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          dataForEmitterBuffer.handle.m_Value,
		          buffer,
		          0,
		          v39,
		          0LL);
		        v169 = (ComputeBuffer *)v16.m128i_i64[0];
		        p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		        valb = p_CB0[205];
		        if ( !v16.m128i_i64[0] )
		          goto LABEL_65;
		        v40 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)v16.m128i_i64[0], 0LL);
		        count = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)v16.m128i_i64[0], 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          valb,
		          (ComputeBuffer *)v16.m128i_i64[0],
		          0,
		          v40 * count,
		          0LL);
		        p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		        valc = p_CB0[207];
		        if ( !v15.m128i_i64[0] )
		          goto LABEL_65;
		        v42 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)v15.m128i_i64[0], 0LL);
		        v43 = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)v15.m128i_i64[0], 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          valc,
		          (ComputeBuffer *)v15.m128i_i64[0],
		          0,
		          v42 * v43,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          0,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ParticleAttributes,
		          (ComputeBuffer *)v167._dateData,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          0,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadList,
		          v182[1],
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          0,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadCount,
		          v170,
		          0,
		          -1,
		          0LL);
		        v44 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DataForEmitter;
		        v45 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data->fields.dataForEmitterBuffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          0,
		          v44,
		          v45,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DispatchSize,
		          threadGroupsXa << 6,
		          0LL);
		        v46 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v46->depthOnlyRT.texture, 0LL) )
		        {
		          shaderID = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                       sysList,
		                       seed,
		                       MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->depthOnlyRT.shaderID;
		          texture = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                      sysList,
		                      seed,
		                      MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->depthOnlyRT.texture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v172 = texture;
		          v49 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
		          v50 = *(_OWORD *)&v49->m_BufferPointer;
		          *(_OWORD *)&v173.m_Type = *(_OWORD *)&v49->m_Type;
		          v51 = *(_QWORD *)&v49->m_DepthSlice;
		          *(_OWORD *)&v173.m_BufferPointer = v50;
		          *(_QWORD *)&v173.m_DepthSlice = v51;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		            cmd,
		            (ComputeShader *)v14.m128i_i64[0],
		            0,
		            shaderID,
		            &v173,
		            0LL);
		        }
		        v52 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v52->sceneNormal.texture, 0LL) )
		        {
		          v53 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneNormal.shaderID;
		          v54 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneNormal.texture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v172 = v54;
		          v55 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
		          v56 = *(_OWORD *)&v55->m_BufferPointer;
		          *(_OWORD *)&v173.m_Type = *(_OWORD *)&v55->m_Type;
		          v57 = *(_QWORD *)&v55->m_DepthSlice;
		          *(_OWORD *)&v173.m_BufferPointer = v56;
		          *(_QWORD *)&v173.m_DepthSlice = v57;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		            cmd,
		            (ComputeShader *)v14.m128i_i64[0],
		            0,
		            v53,
		            &v173,
		            0LL);
		        }
		        v58 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v58->sceneDepth.texture, 0LL) )
		        {
		          v59 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneDepth.shaderID;
		          v60 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneDepth.texture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v172 = v60;
		          v61 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
		          v62 = *(_OWORD *)&v61->m_BufferPointer;
		          *(_OWORD *)&v173.m_Type = *(_OWORD *)&v61->m_Type;
		          v63 = *(_QWORD *)&v61->m_DepthSlice;
		          *(_OWORD *)&v173.m_BufferPointer = v62;
		          *(_QWORD *)&v173.m_DepthSlice = v63;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		            cmd,
		            (ComputeShader *)v14.m128i_i64[0],
		            0,
		            v59,
		            &v173,
		            0LL);
		        }
		        if ( IsValid )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          GPUEventBuffer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventBuffer;
		          eventBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                          sysList,
		                          seed,
		                          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.eventBuffer;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v66 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(eventBuffer, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            (ComputeShader *)v14.m128i_i64[0],
		            0,
		            GPUEventBuffer,
		            v66,
		            0,
		            -1,
		            0LL);
		        }
		        if ( nameID )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          v67 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventConsumedCount;
		          v68 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.comsumedCountBuffer;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v69 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v68, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            (ComputeShader *)v14.m128i_i64[0],
		            0,
		            v67,
		            v69,
		            0,
		            -1,
		            0LL);
		        }
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          (ComputeShader *)v14.m128i_i64[0],
		          0,
		          threadGroupsXa,
		          1,
		          kernelIndexa,
		          0LL);
		        threadGroupsXb = (int)sub_1801D3680();
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        PerFrameVariables = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerFrameVariables;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
		        v71 = (ComputeShader *)_mm_srli_si128(v14, 8).m128i_u64[0];
		        UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
		          cmd,
		          v71,
		          PerFrameVariables,
		          MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
		        GeneralGPUParticleSystemAttributes = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GeneralGPUParticleSystemAttributes;
		        v73 = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          v71,
		          GeneralGPUParticleSystemAttributes,
		          buffer,
		          0,
		          v73,
		          0LL);
		        GPUParticleSystemAttributes = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUParticleSystemAttributes;
		        v75 = UnityEngine::ComputeBuffer::get_stride(v169, 0LL);
		        v76 = UnityEngine::ComputeBuffer::get_count(v169, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          v71,
		          GPUParticleSystemAttributes,
		          v169,
		          0,
		          v75 * v76,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          v71,
		          0,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ParticleAttributes,
		          (ComputeBuffer *)v167._dateData,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          v71,
		          0,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadList,
		          v182[1],
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          v71,
		          0,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadCount,
		          v170,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
		          cmd,
		          v71,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DispatchSize,
		          threadGroupsXb << 6,
		          0LL);
		        v77 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v77->depthOnlyRT.texture, 0LL) )
		        {
		          v78 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->depthOnlyRT.shaderID;
		          v79 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->depthOnlyRT.texture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v172 = v79;
		          v80 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
		          v81 = *(_OWORD *)&v80->m_BufferPointer;
		          *(_OWORD *)&v173.m_Type = *(_OWORD *)&v80->m_Type;
		          v82 = *(_QWORD *)&v80->m_DepthSlice;
		          *(_OWORD *)&v173.m_BufferPointer = v81;
		          *(_QWORD *)&v173.m_DepthSlice = v82;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v71, 0, v78, &v173, 0LL);
		        }
		        v83 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v83->sceneNormal.texture, 0LL) )
		        {
		          v84 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneNormal.shaderID;
		          v85 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneNormal.texture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v172 = v85;
		          v86 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
		          v87 = *(_OWORD *)&v86->m_BufferPointer;
		          *(_OWORD *)&v173.m_Type = *(_OWORD *)&v86->m_Type;
		          v88 = *(_QWORD *)&v86->m_DepthSlice;
		          *(_OWORD *)&v173.m_BufferPointer = v87;
		          *(_QWORD *)&v173.m_DepthSlice = v88;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v71, 0, v84, &v173, 0LL);
		        }
		        v89 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                sysList,
		                seed,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v89->sceneDepth.texture, 0LL) )
		        {
		          v90 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneDepth.shaderID;
		          v91 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->sceneDepth.texture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v172 = v91;
		          v92 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(v181, &v172, 0LL);
		          v93 = *(_OWORD *)&v92->m_BufferPointer;
		          *(_OWORD *)&v173.m_Type = *(_OWORD *)&v92->m_Type;
		          v94 = *(_QWORD *)&v92->m_DepthSlice;
		          *(_OWORD *)&v173.m_BufferPointer = v93;
		          *(_QWORD *)&v173.m_DepthSlice = v94;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(cmd, v71, 0, v90, &v173, 0LL);
		        }
		        if ( IsValid )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          v95 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventBuffer;
		          v96 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  sysList,
		                  seed,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.eventBuffer;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v97 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v96, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(cmd, v71, 0, v95, v97, 0, -1, 0LL);
		        }
		        if ( nameID_1 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          GPUEventSentCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventSentCount;
		          sentCountBuffer = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                              sysList,
		                              seed,
		                              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.sentCountBuffer;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v100 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(sentCountBuffer, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            v71,
		            0,
		            GPUEventSentCount,
		            v100,
		            0,
		            -1,
		            0LL);
		        }
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          v71,
		          0,
		          threadGroupsXb,
		          1,
		          kernelIndexa,
		          0LL);
		        particleCullShader = data->fields.particleCullShader;
		        particleCullKernel = data->fields.particleCullKernel;
		        vald = (int)sub_1801D3680();
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        v103 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerFrameVariables;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
		        UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>(
		          cmd,
		          particleCullShader,
		          v103,
		          MethodInfo::UnityEngine::Rendering::ConstantBuffer::Set<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PerFrameBuffer>);
		        v104 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GeneralGPUParticleSystemAttributes;
		        v105 = UnityEngine::ComputeBuffer::get_stride(buffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          particleCullShader,
		          v104,
		          buffer,
		          0,
		          v105,
		          0LL);
		        v106 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUParticleSystemAttributes;
		        v107 = UnityEngine::ComputeBuffer::get_stride(v169, 0LL);
		        v108 = UnityEngine::ComputeBuffer::get_count(v169, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
		          cmd,
		          particleCullShader,
		          v106,
		          v169,
		          0,
		          v107 * v108,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleCullShader,
		          particleCullKernel,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ParticleAttributes,
		          (ComputeBuffer *)v167._dateData,
		          0,
		          -1,
		          0LL);
		        LiveList = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveList;
		        p_CB0 = data->fields.stagingLiveListBuffers;
		        if ( !p_CB0 )
		          goto LABEL_65;
		        sub_18047F264(p_CB0, &v174, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		        v110 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v174, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleCullShader,
		          particleCullKernel,
		          LiveList,
		          v110,
		          0,
		          -1,
		          0LL);
		        LiveCount = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount;
		        v112 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data->fields.liveCountBuffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleCullShader,
		          particleCullKernel,
		          LiveCount,
		          v112,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetComputeIntParam(
		          cmd,
		          particleCullShader,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DispatchSize,
		          vald << 6,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          particleCullShader,
		          particleCullKernel,
		          vald,
		          1,
		          kernelIndexa,
		          0LL);
		        particleSortShader = data->fields.particleSortShader;
		        threadGroupsXc = (int)sub_1801D3680();
		        if ( nameID_4a <= 4096 )
		        {
		          v116 = v182[0];
		          bitonicSortFinalKernel = data->fields.bitonicSortFinalKernel;
		        }
		        else
		        {
		          p_CB0 = data->fields.stagingLiveListBuffers;
		          if ( !p_CB0 )
		            goto LABEL_65;
		          sub_18047F264(p_CB0, &v175, 1LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v114 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v175, 0LL);
		          bitonicSortFinalKernel = data->fields.bitonicSortKernel;
		          v116 = v114;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        p_CB0 = data->fields.stagingLiveListBuffers;
		        vale = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputLiveList;
		        if ( !p_CB0 )
		          goto LABEL_65;
		        sub_18047F264(p_CB0, &v176, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		        v117 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v176, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleSortShader,
		          bitonicSortFinalKernel,
		          vale,
		          v117,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleSortShader,
		          bitonicSortFinalKernel,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SortedLiveList,
		          v116,
		          0,
		          -1,
		          0LL);
		        v118 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount;
		        v119 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data->fields.liveCountBuffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleSortShader,
		          bitonicSortFinalKernel,
		          v118,
		          v119,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          particleSortShader,
		          bitonicSortFinalKernel,
		          threadGroupsXc,
		          1,
		          1,
		          0LL);
		        threadGroupsXd = 0;
		        v120 = 1;
		        if ( nameID_4a > 4096 )
		        {
		          v170 = (ComputeBuffer *)nameID_4a;
		          v121 = 0x2000;
		          if ( nameID_4a >= 0x2000LL )
		          {
		            v122 = (int)sub_1801D3680();
		            valf = v122;
		            do
		            {
		              v123 = data->fields.particleSortShader;
		              kernelIndexb = data->fields.mergeKernel;
		              HIDWORD(v171) = v122;
		              LODWORD(v171) = v121 >> 1;
		              v167._dateData = v171;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              MergePassConstants = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MergePassConstants;
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
		              UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>(
		                cmd,
		                (GPUParticleSimulationPassConstructor_MergePassConstants *)&v167,
		                v123,
		                MergePassConstants,
		                MethodInfo::UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>);
		              InputLiveList = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputLiveList;
		              p_CB0 = data->fields.stagingLiveListBuffers;
		              if ( !p_CB0 )
		                goto LABEL_65;
		              sub_18047F264(p_CB0, &v177, v120);
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		              v126 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v177, 0LL);
		              UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		                cmd,
		                v123,
		                kernelIndexb,
		                InputLiveList,
		                v126,
		                0,
		                -1,
		                0LL);
		              p_CB0 = data->fields.stagingLiveListBuffers;
		              buffera = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SortedLiveList;
		              if ( !p_CB0 )
		                goto LABEL_65;
		              sub_18047F264(p_CB0, &v178, threadGroupsXd);
		              v127 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v178, 0LL);
		              UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		                cmd,
		                v123,
		                kernelIndexb,
		                buffera,
		                v127,
		                0,
		                -1,
		                0LL);
		              v128 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount;
		              v129 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
		                       data->fields.liveCountBuffer,
		                       0LL);
		              UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		                cmd,
		                v123,
		                kernelIndexb,
		                v128,
		                v129,
		                0,
		                -1,
		                0LL);
		              UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, v123, kernelIndexb, valf, 1, 1, 0LL);
		              v122 = valf;
		              v120 = ((_BYTE)v120 - 1) & 1;
		              v121 *= 2;
		              threadGroupsXd = ((_BYTE)threadGroupsXd - 1) & 1;
		            }
		            while ( v121 <= (__int64)v170 );
		          }
		          v130 = data->fields.particleSortShader;
		          bufferb = data->fields.mergeFinalKernel;
		          v131 = sub_1801D3680();
		          LODWORD(v171) = v121 >> 1;
		          HIDWORD(v171) = (int)v131;
		          nameID_4b = (int)v131;
		          v167._dateData = v171;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          v132 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MergePassConstants;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ConstantBuffer);
		          UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>(
		            cmd,
		            (GPUParticleSimulationPassConstructor_MergePassConstants *)&v167,
		            v130,
		            v132,
		            MethodInfo::UnityEngine::Rendering::ConstantBuffer::Push<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::MergePassConstants>);
		          v133 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputLiveList;
		          p_CB0 = data->fields.stagingLiveListBuffers;
		          if ( !p_CB0 )
		            goto LABEL_65;
		          sub_18047F264(p_CB0, &v179, v120);
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		          v134 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(v179, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            v130,
		            bufferb,
		            v133,
		            v134,
		            0,
		            -1,
		            0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            v130,
		            bufferb,
		            TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SortedLiveList,
		            v182[0],
		            0,
		            -1,
		            0LL);
		          v135 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount;
		          v136 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(data->fields.liveCountBuffer, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		            cmd,
		            v130,
		            bufferb,
		            v135,
		            v136,
		            0,
		            -1,
		            0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, v130, bufferb, nameID_4b, 1, 1, 0LL);
		        }
		        particleIndirectArgsShader = data->fields.particleIndirectArgsShader;
		        particleIndirectArgsKernel = data->fields.particleIndirectArgsKernel;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        liveCountBuffer = data->fields.liveCountBuffer;
		        v140 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		        v141 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(liveCountBuffer, 0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleIndirectArgsShader,
		          particleIndirectArgsKernel,
		          v140,
		          v141,
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
		          cmd,
		          particleIndirectArgsShader,
		          particleIndirectArgsKernel,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DrawIndirectArg,
		          (ComputeBuffer *)_mm_srli_si128(v17, 8).m128i_i64[0],
		          0,
		          -1,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          particleIndirectArgsShader,
		          particleIndirectArgsKernel,
		          1,
		          1,
		          1,
		          0LL);
		        seed = dataa[0].seed;
		      }
		      dataa[0].seed = ++seed;
		    }
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3207, 0LL);
		  if ( !Patch )
		    goto LABEL_65;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)sysList,
		    (Object *)data,
		    (Object *)context,
		    0LL);
		}
		
		internal void ConstructPass([IsReadOnly] in PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BAEE94-0x0000000189BB0038
		// Void ConstructPass(GPUParticleSimulationPassConstructor+PassInput ByRef, GPUParticleSimulationPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::ConstructPass(
		        GPUParticleSimulationPassConstructor *this,
		        GPUParticleSimulationPassConstructor_PassInput *input,
		        GPUParticleSimulationPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v6; // r12
		  GPUParticleSimulationPassConstructor *v9; // rsi
		  GPUParticleSystemManager *instance; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  GPUParticleSystemManager *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  int32_t maxGPUInstanceCount_k__BackingField; // r14d
		  GPUParticleSystemManager *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  List_1_System_Int32_ *m_receivers; // rbx
		  GPUParticleSystemManager *v29; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v35; // xmm1
		  int v36; // r13d
		  int length; // r15d
		  GPUParticleSystemBase **v38; // rax
		  bool v39; // cf
		  GPUParticleSystemBase *v40; // rbx
		  Type *v41; // rdx
		  PropertyInfo_1 *v42; // r8
		  Int32__Array **v43; // r9
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  GPUParticleSimulationPassConstructor_PassInput *v46; // rdx
		  unsigned __int64 v47; // rcx
		  __m128i v48; // xmm6
		  unsigned __int64 v49; // rax
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  __m128d v52; // xmm6
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *m_simulateList; // rbx
		  unsigned int v54; // ebx
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  Il2CppException *v57; // rax
		  ProjectileComponent_FinishOptions v58; // rdx
		  ProjectileComponent_FinishOptions v59; // rcx
		  int32_t v60; // ebx
		  Dictionary_2_System_Guid_System_Int32_ *m_gpuEventDict; // r15
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *m_senderSimulateList; // r14
		  int32_t size_k__BackingField; // r14d
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v66; // rbx
		  __int64 v67; // rdx
		  int32_t current; // ebx
		  Dictionary_2_System_Guid_System_Int32_ *v69; // r14
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v70; // rcx
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *Item; // rax
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  __int64 v74; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v75; // rcx
		  __int64 v76; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v77; // rcx
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v78; // rax
		  __int64 v79; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v80; // rcx
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v81; // rax
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v82; // rcx
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v83; // rbx
		  int32_t v84; // r15d
		  ProfilingSampler *v85; // rax
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v88; // rax
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v89; // rax
		  __int64 v90; // rdx
		  __int64 v91; // rcx
		  int32_t i; // ebx
		  int32_t j; // ebx
		  DynamicArray_1_HG_Rendering_Runtime_GPUParticleSimulationPassConstructor_SimulateRequiredResources_ *v94; // rax
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources *v95; // rax
		  int k; // ebx
		  MonitorData *monitor; // r14
		  unsigned __int64 v98; // r8
		  signed __int64 v99; // rtt
		  ComputeBufferHandle v100; // rax
		  ComputeBufferHandle v101; // rcx
		  ComputeBufferHandle v102; // r8
		  ComputeBufferHandle *v103; // rbx
		  ComputeBufferHandle v104; // rax
		  ComputeBufferHandle v105; // rdx
		  ComputeBufferHandle v106; // rcx
		  ComputeBufferHandle *v107; // rbx
		  ComputeBufferHandle v108; // rax
		  ComputeBufferHandle v109; // rdx
		  ComputeBufferHandle v110; // rcx
		  Object *v111; // rdx
		  __int64 v112; // rcx
		  unsigned __int64 v113; // rdx
		  unsigned __int64 v114; // r8
		  char v115; // dl
		  signed __int64 v116; // rtt
		  Object *v117; // rdx
		  unsigned __int64 v118; // rdx
		  unsigned __int64 v119; // r8
		  char v120; // dl
		  signed __int64 v121; // rtt
		  Object *v122; // rdx
		  unsigned __int64 v123; // rdx
		  unsigned __int64 v124; // r8
		  char v125; // dl
		  signed __int64 v126; // rtt
		  Object *v127; // rdx
		  unsigned __int64 v128; // rdx
		  unsigned __int64 v129; // r8
		  char v130; // dl
		  signed __int64 v131; // rtt
		  Object *v132; // rdx
		  unsigned __int64 v133; // rdx
		  unsigned __int64 v134; // r8
		  char v135; // dl
		  signed __int64 v136; // rtt
		  __int64 m_particleCleanupKernel; // rdx
		  __int64 m_particleInitKernel; // rdx
		  __int64 m_particleCullKernel; // rdx
		  __int64 m_bitonicSortKernel; // rdx
		  __int64 m_bitonicSortFinalKernel; // rdx
		  __int64 m_mergeKernel; // rdx
		  __int64 m_mergeFinalKernel; // rdx
		  __int64 m_particleIndirectArgsKernel; // rdx
		  Object *v145; // rdx
		  unsigned __int64 v146; // rdx
		  unsigned __int64 v147; // r8
		  char v148; // dl
		  signed __int64 v149; // rtt
		  Object *v150; // rdx
		  unsigned __int64 v151; // rdx
		  unsigned __int64 v152; // r8
		  char v153; // dl
		  signed __int64 v154; // rtt
		  Object *v155; // rdx
		  unsigned __int64 v156; // rdx
		  unsigned __int64 v157; // r8
		  char v158; // dl
		  signed __int64 v159; // rtt
		  Object *v160; // rdx
		  MonitorData *v161; // xmm1_8
		  unsigned __int64 v162; // rdx
		  unsigned __int64 v163; // r8
		  char v164; // dl
		  signed __int64 v165; // rtt
		  Object *v166; // rdx
		  Object__Class *v167; // xmm1_8
		  unsigned __int64 v168; // rdx
		  unsigned __int64 v169; // r8
		  char v170; // dl
		  signed __int64 v171; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v173; // rdx
		  __int64 v174; // rcx
		  MethodInfo *v175; // [rsp+20h] [rbp-2D8h]
		  Object *v176; // [rsp+40h] [rbp-2B8h] BYREF
		  ComputeBufferHandle inputa; // [rsp+48h] [rbp-2B0h] BYREF
		  ComputeBufferDesc desc; // [rsp+50h] [rbp-2A8h] BYREF
		  Il2CppException *ex; // [rsp+68h] [rbp-290h]
		  List_1_T_Enumerator_System_Int32_ *v180; // [rsp+70h] [rbp-288h]
		  ComputeBufferDesc v181; // [rsp+78h] [rbp-280h] BYREF
		  int32_t index; // [rsp+90h] [rbp-268h] BYREF
		  int32_t maxParticleCount_k__BackingField; // [rsp+94h] [rbp-264h]
		  int32_t v184; // [rsp+98h] [rbp-260h]
		  int v185; // [rsp+9Ch] [rbp-25Ch]
		  _BYTE v186[20]; // [rsp+A0h] [rbp-258h]
		  __int128 v187; // [rsp+B8h] [rbp-240h]
		  _BYTE v188[24]; // [rsp+C8h] [rbp-230h] BYREF
		  _QWORD v189[2]; // [rsp+E0h] [rbp-218h] BYREF
		  HGRenderGraphBuilder v190; // [rsp+F0h] [rbp-208h] BYREF
		  HGRenderGraphBuilder v191; // [rsp+110h] [rbp-1E8h] BYREF
		  Guid guid; // [rsp+130h] [rbp-1C8h] BYREF
		  OptionalSystemFeatures v193; // [rsp+140h] [rbp-1B8h] BYREF
		  List_1_T_Enumerator_System_Int32_ v194; // [rsp+170h] [rbp-188h] BYREF
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources value; // [rsp+190h] [rbp-168h] BYREF
		  OptionalSystemFeatures v196; // [rsp+200h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v197; // [rsp+230h] [rbp-C8h] BYREF
		  Il2CppExceptionWrapper *v198; // [rsp+238h] [rbp-C0h] BYREF
		  GPUParticleSimulationPassConstructor_SimulateRequiredResources v199; // [rsp+240h] [rbp-B8h] BYREF
		
		  v6 = (Object *)renderGraph;
		  v9 = this;
		  sub_18033B9D0(&v199, 0LL, 112LL);
		  *(_OWORD *)v186 = 0LL;
		  v187 = 0LL;
		  *(_OWORD *)v188 = 0LL;
		  memset(&desc, 0, sizeof(desc));
		  memset(&v181, 0, sizeof(v181));
		  index = 0;
		  memset(&v190, 0, sizeof(v190));
		  v176 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3208, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3208, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v174, v173);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1184(Patch, (Object *)v9, input, output, v6, (Object *)camera, 0LL);
		  }
		  else
		  {
		    instance = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
		    if ( !instance )
		      sub_1800D8260(v12, v11);
		    maxParticleCount_k__BackingField = instance->fields._maxParticleCount_k__BackingField;
		    v13 = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
		    if ( !v13 )
		      sub_1800D8260(v15, v14);
		    maxGPUInstanceCount_k__BackingField = v13->fields._maxGPUInstanceCount_k__BackingField;
		    v184 = maxGPUInstanceCount_k__BackingField;
		    v17 = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
		    if ( !v17 )
		      sub_1800D8260(v19, v18);
		    if ( !HG::Rendering::Runtime::GPUParticleSystemManager::Empty(v17, 0LL) && maxGPUInstanceCount_k__BackingField )
		    {
		      if ( !v9->fields.m_simulateList )
		        sub_1800D8260(v21, v20);
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v9->fields.m_simulateList,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Clear);
		      if ( !v9->fields.m_senderSimulateList )
		        sub_1800D8260(v23, v22);
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v9->fields.m_senderSimulateList,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Clear);
		      if ( !v9->fields.m_gpuEventDict )
		        sub_1800D8260(v25, v24);
		      System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		        (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v9->fields.m_gpuEventDict,
		        MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::Clear);
		      m_receivers = v9->fields.m_receivers;
		      if ( !m_receivers )
		        sub_1800D8260(v27, v26);
		      ++m_receivers->fields._version;
		      m_receivers->fields._size = 0;
		      v29 = HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(0LL);
		      if ( !v29 )
		        sub_1800D8260(v31, v30);
		      Span = HG::Rendering::Runtime::GPUParticleSystemManager::GetSpan(
		               (ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *)&guid,
		               v29,
		               0LL);
		      v35 = *Span;
		      v36 = 0;
		      length = Span->_length;
		      v185 = length;
		      if ( length > 0 )
		      {
		        v38 = (GPUParticleSystemBase **)v35._pointer._value;
		        inputa = (ComputeBufferHandle)v35._pointer._value;
		        v39 = length != 0;
		        do
		        {
		          if ( !v39 )
		            sub_1800D2AB0(v34, v33);
		          v40 = *v38;
		          if ( *v38 )
		          {
		            sub_18033B9D0(&v199.depthOnlyRT, 0LL, 104LL);
		            v199.gpuParticleSystem = v40;
		            sub_18002D1B0((SingleFieldAccessor *)&v199, v41, v42, v43, v175);
		            value = v199;
		            if ( v40->fields.optionalSystemFeatures.hasValue )
		            {
		              System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value(
		                &v193,
		                &v40->fields.optionalSystemFeatures,
		                MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value);
		              v48 = *(__m128i *)&v193.sceneRTFeature.hasValue;
		              v196 = v193;
		              if ( (unsigned __int8)_mm_cvtsi128_si32(*(__m128i *)&v193.sceneRTFeature.hasValue) )
		              {
		                v49 = (unsigned __int64)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
		                                          (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)&v196,
		                                          MethodInfo::System::Nullable<HG::Rendering::Runtime::SceneRTFeature>::get_Value);
		                v46 = input;
		                if ( (_DWORD)v49 )
		                {
		                  *(_DWORD *)v186 = v49;
		                  *(TextureHandle *)&v186[4] = input->sceneNormal;
		                  *(_OWORD *)&value.sceneNormal.shaderID = *(_OWORD *)v186;
		                  value.sceneNormal.texture.fallBackResource._type_k__BackingField = _mm_cvtsi128_si32(
		                                                                                       _mm_srli_si128(
		                                                                                         *(__m128i *)&v186[4],
		                                                                                         12));
		                }
		                v47 = HIDWORD(v49);
		                if ( HIDWORD(v49) )
		                {
		                  *(_DWORD *)v186 = HIDWORD(v49);
		                  *(TextureHandle *)&v186[4] = input->sceneDepth;
		                  *(_OWORD *)&value.sceneDepth.shaderID = *(_OWORD *)v186;
		                  value.sceneDepth.texture.fallBackResource._type_k__BackingField = _mm_cvtsi128_si32(
		                                                                                      _mm_srli_si128(
		                                                                                        *(__m128i *)&v186[4],
		                                                                                        12));
		                }
		              }
		              if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v48, 12)) )
		                goto LABEL_35;
		              System::Nullable<UnityEngine::Keyframe>::get_Value(
		                (Keyframe *)&v193,
		                (Nullable_1_UnityEngine_Keyframe_ *)&v196.gpuEventFeature,
		                MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_Value);
		              v52 = *(__m128d *)&v193.sceneRTFeature.hasValue;
		              *(_OWORD *)&v191.m_RenderPass = *(_OWORD *)&v193.sceneRTFeature.hasValue;
		              v191.m_RenderGraph = *(HGRenderGraph **)&v193.gpuEventFeature.value.guid._a;
		              *(_DWORD *)&v191.m_Disposed = *(_DWORD *)&v193.gpuEventFeature.value.guid._d;
		              if ( LOBYTE(v193.gpuEventFeature.value.guid._a) )
		              {
		                v57 = (Il2CppException *)System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
		                                           (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)&v191.m_RenderGraph,
		                                           MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_Value);
		                v60 = (int)v57;
		                ex = v57;
		                m_gpuEventDict = v9->fields.m_gpuEventDict;
		                m_senderSimulateList = v9->fields.m_senderSimulateList;
		                if ( !m_senderSimulateList )
		                  sub_1800D8260(v59, v58);
		                size_k__BackingField = m_senderSimulateList->fields._size_k__BackingField;
		                if ( !m_gpuEventDict )
		                  sub_1800D8260(v59, v58);
		                guid = (Guid)v52;
		                System::Collections::Generic::Dictionary<System::Guid,int>::set_Item(
		                  m_gpuEventDict,
		                  &guid,
		                  size_k__BackingField,
		                  MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::set_Item);
		                memset(v188, 0, sizeof(v188));
		                v52 = 0LL;
		                *(_QWORD *)(&desc.type + 1) = 0LL;
		                HIDWORD(desc.name) = 0;
		                desc.count = 1;
		                desc.stride = 4;
		                desc.type = 4;
		                if ( !v6 )
		                  sub_1800D8260(v65, v64);
		                *((ComputeBufferHandle *)&v187 + 1) = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		                                                        (HGRenderGraph *)v6,
		                                                        &desc,
		                                                        0LL);
		                *(_QWORD *)(&v181.type + 1) = 0LL;
		                HIDWORD(v181.name) = 0;
		                v181.count = v60;
		                v181.stride = HIDWORD(ex);
		                v181.type = 16;
		                *(ComputeBufferHandle *)&v187 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		                                                  (HGRenderGraph *)v6,
		                                                  &v181,
		                                                  0LL);
		                length = v185;
		              }
		              else
		              {
		                m_simulateList = v9->fields.m_simulateList;
		                if ( !m_simulateList )
		                  sub_1800D8260(v51, v50);
		                v54 = m_simulateList->fields._size_k__BackingField;
		                if ( !v9->fields.m_receivers )
		                  sub_1800D8260(v51, v50);
		                sub_183081250(v9->fields.m_receivers, v54, MethodInfo::System::Collections::Generic::List<int>::Add);
		                v187 = 0uLL;
		                *(_QWORD *)(&desc.type + 1) = 0LL;
		                HIDWORD(desc.name) = 0;
		                desc.count = 1;
		                desc.stride = 4;
		                desc.type = 4;
		                if ( !v6 )
		                  sub_1800D8260(v56, v55);
		                *(ComputeBufferHandle *)v188 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
		                                                 (HGRenderGraph *)v6,
		                                                 &desc,
		                                                 0LL);
		                *(__m128d *)&v188[8] = v52;
		              }
		              *(_QWORD *)&value.gpuEventData.guid._d = *(_OWORD *)&_mm_unpackhi_pd(v52, v52);
		              *(_OWORD *)&value.gpuEventData.comsumedCountBuffer.handle.m_Value = *(_OWORD *)v188;
		              *(_OWORD *)&value.gpuEventData.eventBuffer.handle.m_Value = v187;
		              if ( LOBYTE(v193.gpuEventFeature.value.guid._a) )
		              {
		                v66 = v9->fields.m_senderSimulateList;
		                if ( !v66 )
		                  sub_1800D8260(v47, v46);
		              }
		              else
		              {
		LABEL_35:
		                v66 = v9->fields.m_simulateList;
		                if ( !v66 )
		                  sub_1800D8260(v47, v46);
		              }
		            }
		            else
		            {
		              v66 = v9->fields.m_simulateList;
		              if ( !v66 )
		                sub_1800D8260(v45, v44);
		            }
		            UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Add(
		              v66,
		              &value,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::Add);
		            v38 = (GPUParticleSystemBase **)inputa;
		          }
		          ++v36;
		          inputa = (ComputeBufferHandle)++v38;
		          v39 = v36 < (unsigned int)length;
		        }
		        while ( v36 < length );
		      }
		      if ( !v9->fields.m_receivers )
		        sub_1800D8260(v34, v33);
		      System::Collections::Generic::List<int>::GetEnumerator(
		        (List_1_T_Enumerator_System_Int32_ *)&v181,
		        v9->fields.m_receivers,
		        MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		      v194 = (List_1_T_Enumerator_System_Int32_)v181;
		      ex = 0LL;
		      v180 = &v194;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                  &v194,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		        {
		          current = v194._current;
		          v69 = v9->fields.m_gpuEventDict;
		          v70 = v9->fields.m_simulateList;
		          if ( !v70 )
		            sub_1800D8250(0LL, v67);
		          Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                   v70,
		                   v194._current,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		          if ( !v69 )
		            sub_1800D8250(v73, v72);
		          guid = Item->gpuEventData.guid;
		          if ( System::Collections::Generic::Dictionary<System::Guid,int>::TryGetValue(
		                 v69,
		                 &guid,
		                 &index,
		                 MethodInfo::System::Collections::Generic::Dictionary<System::Guid,int>::TryGetValue) )
		          {
		            v75 = v9->fields.m_senderSimulateList;
		            if ( !v75 )
		              sub_1800D8250(0LL, v74);
		            v187 = *(_OWORD *)&UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                                 v75,
		                                 index,
		                                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item)->gpuEventData.eventBuffer.handle.m_Value;
		            v77 = v9->fields.m_simulateList;
		            if ( !v77 )
		              sub_1800D8250(0LL, v76);
		            v78 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                    v77,
		                    current,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		            v78->gpuEventData.eventBuffer = (ComputeBufferHandle)v187;
		            v80 = v9->fields.m_simulateList;
		            if ( !v80 )
		              sub_1800D8250(0LL, v79);
		            v81 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                    v80,
		                    current,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		            v81->gpuEventData.sentCountBuffer = (ComputeBufferHandle)*((_QWORD *)&v187 + 1);
		          }
		          else
		          {
		            v82 = v9->fields.m_simulateList;
		            if ( !v82 )
		              sub_1800D8250(0LL, v74);
		            v83 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                    v82,
		                    current,
		                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		            v83->gpuEventData.eventBuffer = HG::Rendering::RenderGraphModule::ComputeBufferHandle::get_nullHandle(0LL);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v197 )
		      {
		        ex = v197->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v6 = (Object *)renderGraph;
		        v9 = this;
		        v84 = maxParticleCount_k__BackingField;
		        goto LABEL_55;
		      }
		      v84 = maxParticleCount_k__BackingField;
		LABEL_55:
		      v85 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0xB6u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		        sub_1800D8250(v87, v86);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v191,
		        (HGRenderGraph *)v6,
		        (String *)"Particle Simulation",
		        &v176,
		        v85,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>);
		      v190 = v191;
		      v189[0] = 0LL;
		      v189[1] = &v190;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v190, 0, 0LL);
		        for ( i = 0; ; ++i )
		        {
		          v88 = v9->fields.m_senderSimulateList;
		          if ( !v88 )
		            sub_1800D8250(v91, v90);
		          if ( i >= v88->fields._size_k__BackingField )
		            break;
		          v89 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  v9->fields.m_senderSimulateList,
		                  i,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		          v191 = v190;
		          HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources::MarkResourceRead(
		            v89,
		            &v191,
		            0LL);
		        }
		        for ( j = 0; ; ++j )
		        {
		          v94 = v9->fields.m_simulateList;
		          if ( !v94 )
		            sub_1800D8250(v91, v90);
		          if ( j >= v94->fields._size_k__BackingField )
		            break;
		          v95 = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item(
		                  v9->fields.m_simulateList,
		                  j,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources>::get_Item);
		          v191 = v190;
		          HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::SimulateRequiredResources::MarkResourceRead(
		            v95,
		            &v191,
		            0LL);
		        }
		        for ( k = 0; k < 2; ++k )
		        {
		          if ( !v176 )
		            sub_1800D8250(v91, v90);
		          monitor = v176[5].monitor;
		          *(_QWORD *)&desc.type = 16LL;
		          desc.count = v84;
		          desc.stride = 8;
		          desc.name = (String *)"PerFrameParticleSimulateBuffer";
		          if ( dword_18F35FD08 )
		          {
		            v98 = (((unsigned __int64)&desc.name >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v98 + 36190]);
		            do
		              v99 = qword_18F0BCBA0[v98 + 36190];
		            while ( v99 != _InterlockedCompareExchange64(
		                             &qword_18F0BCBA0[v98 + 36190],
		                             v99 | (1LL << (((unsigned __int64)&desc.name >> 12) & 0x3F)),
		                             v99) );
		          }
		          inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer((HGRenderGraph *)v6, &desc, 0LL);
		          v100 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v190, &inputa, 0LL);
		          if ( !monitor )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v101, v90);
		          v91 = k;
		          if ( (unsigned int)k >= *((_DWORD *)monitor + 6) )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD, _QWORD))sub_1800D2AA0)(k, v90, v102);
		          *((ComputeBufferHandle *)monitor + k + 4) = v100;
		        }
		        v103 = (ComputeBufferHandle *)v176;
		        *(_QWORD *)(&v181.type + 1) = 0LL;
		        HIDWORD(v181.name) = 0;
		        v181.count = 2 * v184;
		        v181.stride = 4;
		        v181.type = 16;
		        *(_OWORD *)&desc.count = *(_OWORD *)&v181.count;
		        desc.name = 0LL;
		        inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer((HGRenderGraph *)v6, &desc, 0LL);
		        v104 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v190, &inputa, 0LL);
		        if ( !v103 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v106, v105);
		        v103[12] = v104;
		        v107 = (ComputeBufferHandle *)v176;
		        *(_QWORD *)(&v181.type + 1) = 0LL;
		        HIDWORD(v181.name) = 0;
		        v181.count = 1;
		        v181.stride = 4;
		        v181.type = 16;
		        *(_OWORD *)&desc.count = *(_OWORD *)&v181.count;
		        desc.name = 0LL;
		        inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer((HGRenderGraph *)v6, &desc, 0LL);
		        v108 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v190, &inputa, 0LL);
		        if ( !v107 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v110, v109);
		        v107[13] = v108;
		        v111 = v176;
		        if ( !v176 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v110, 0LL);
		        v176[1].klass = (Object__Class *)v9->fields.m_particleCleanupShader;
		        v112 = (unsigned int)dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v113 = ((unsigned __int64)&v111[1] >> 12) & 0x1FFFFF;
		          v114 = v113 >> 6;
		          v115 = v113 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v114 + 36190]);
		          do
		            v116 = qword_18F0BCBA0[v114 + 36190];
		          while ( v116 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v114 + 36190], v116 | (1LL << v115), v116) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v117 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[1].monitor = (MonitorData *)v9->fields.m_particleInitShader;
		        if ( (_DWORD)v112 )
		        {
		          v118 = ((unsigned __int64)&v117[1].monitor >> 12) & 0x1FFFFF;
		          v119 = v118 >> 6;
		          v120 = v118 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v119 + 36190]);
		          do
		            v121 = qword_18F0BCBA0[v119 + 36190];
		          while ( v121 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v119 + 36190], v121 | (1LL << v120), v121) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v122 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[2].klass = (Object__Class *)v9->fields.m_particleCullShader;
		        if ( (_DWORD)v112 )
		        {
		          v123 = ((unsigned __int64)&v122[2] >> 12) & 0x1FFFFF;
		          v124 = v123 >> 6;
		          v125 = v123 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v124 + 36190]);
		          do
		            v126 = qword_18F0BCBA0[v124 + 36190];
		          while ( v126 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v124 + 36190], v126 | (1LL << v125), v126) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v127 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[2].monitor = (MonitorData *)v9->fields.m_particleSortShader;
		        if ( (_DWORD)v112 )
		        {
		          v128 = ((unsigned __int64)&v127[2].monitor >> 12) & 0x1FFFFF;
		          v129 = v128 >> 6;
		          v130 = v128 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v129 + 36190]);
		          do
		            v131 = qword_18F0BCBA0[v129 + 36190];
		          while ( v131 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v129 + 36190], v131 | (1LL << v130), v131) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v132 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[3].klass = (Object__Class *)v9->fields.m_particleIndirectArgsShader;
		        if ( (_DWORD)v112 )
		        {
		          v133 = ((unsigned __int64)&v132[3] >> 12) & 0x1FFFFF;
		          v134 = v133 >> 6;
		          v135 = v133 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v134 + 36190]);
		          do
		            v136 = qword_18F0BCBA0[v134 + 36190];
		          while ( v136 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v134 + 36190], v136 | (1LL << v135), v136) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        m_particleCleanupKernel = (unsigned int)v9->fields.m_particleCleanupKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_particleCleanupKernel);
		        LODWORD(v176[3].monitor) = m_particleCleanupKernel;
		        m_particleInitKernel = (unsigned int)v9->fields.m_particleInitKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_particleInitKernel);
		        HIDWORD(v176[3].monitor) = m_particleInitKernel;
		        m_particleCullKernel = (unsigned int)v9->fields.m_particleCullKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_particleCullKernel);
		        LODWORD(v176[4].klass) = m_particleCullKernel;
		        m_bitonicSortKernel = (unsigned int)v9->fields.m_bitonicSortKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_bitonicSortKernel);
		        HIDWORD(v176[4].klass) = m_bitonicSortKernel;
		        m_bitonicSortFinalKernel = (unsigned int)v9->fields.m_bitonicSortFinalKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_bitonicSortFinalKernel);
		        LODWORD(v176[4].monitor) = m_bitonicSortFinalKernel;
		        m_mergeKernel = (unsigned int)v9->fields.m_mergeKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_mergeKernel);
		        HIDWORD(v176[4].monitor) = m_mergeKernel;
		        m_mergeFinalKernel = (unsigned int)v9->fields.m_mergeFinalKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_mergeFinalKernel);
		        LODWORD(v176[5].klass) = m_mergeFinalKernel;
		        m_particleIndirectArgsKernel = (unsigned int)v9->fields.m_particleIndirectArgsKernel;
		        if ( !v176 )
		          sub_1800D8250(v112, m_particleIndirectArgsKernel);
		        HIDWORD(v176[5].klass) = m_particleIndirectArgsKernel;
		        v145 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[7].monitor = (MonitorData *)v9->fields.m_senderSimulateList;
		        if ( (_DWORD)v112 )
		        {
		          v146 = ((unsigned __int64)&v145[7].monitor >> 12) & 0x1FFFFF;
		          v147 = v146 >> 6;
		          v148 = v146 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v147 + 36190]);
		          do
		            v149 = qword_18F0BCBA0[v147 + 36190];
		          while ( v149 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v147 + 36190], v149 | (1LL << v148), v149) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v150 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[8].klass = (Object__Class *)v9->fields.m_simulateList;
		        if ( (_DWORD)v112 )
		        {
		          v151 = ((unsigned __int64)&v150[8] >> 12) & 0x1FFFFF;
		          v152 = v151 >> 6;
		          v153 = v151 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v152 + 36190]);
		          do
		            v154 = qword_18F0BCBA0[v152 + 36190];
		          while ( v154 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v152 + 36190], v154 | (1LL << v153), v154) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v155 = v176;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[7].klass = (Object__Class *)camera;
		        if ( (_DWORD)v112 )
		        {
		          v156 = ((unsigned __int64)&v155[7] >> 12) & 0x1FFFFF;
		          v157 = v156 >> 6;
		          v158 = v156 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v157 + 36190]);
		          do
		            v159 = qword_18F0BCBA0[v157 + 36190];
		          while ( v159 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v157 + 36190], v159 | (1LL << v158), v159) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v160 = v176;
		        v161 = *(MonitorData **)&v9->fields.m_senderKeyword.m_Index;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        *(Object *)((char *)v176 + 136) = *(Object *)&v9->fields.m_senderKeyword.m_SpaceInfo.m_KeywordSpace;
		        v160[9].monitor = v161;
		        if ( (_DWORD)v112 )
		        {
		          v162 = ((unsigned __int64)&v160[9] >> 12) & 0x1FFFFF;
		          v163 = v162 >> 6;
		          v164 = v162 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v163 + 36190]);
		          do
		            v165 = qword_18F0BCBA0[v163 + 36190];
		          while ( v165 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v163 + 36190], v165 | (1LL << v164), v165) );
		          v112 = (unsigned int)dword_18F35FD08;
		        }
		        v166 = v176;
		        v167 = *(Object__Class **)&v9->fields.m_recieverKeyword.m_Index;
		        if ( !v176 )
		          sub_1800D8250(v112, 0LL);
		        v176[10] = *(Object *)&v9->fields.m_recieverKeyword.m_SpaceInfo.m_KeywordSpace;
		        v166[11].klass = v167;
		        if ( (_DWORD)v112 )
		        {
		          v168 = ((unsigned __int64)&v166[10].monitor >> 12) & 0x1FFFFF;
		          v169 = v168 >> 6;
		          v170 = v168 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v169 + 36190]);
		          do
		            v171 = qword_18F0BCBA0[v169 + 36190];
		          while ( v171 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v169 + 36190], v171 | (1LL << v170), v171) );
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v190,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor->static_fields->s_renderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v198 )
		      {
		        v189[0] = v198->ex;
		      }
		      sub_180268AE0(v189);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BB0038-0x0000000189BB008C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        GPUParticleSimulationPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3210, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3210, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80410-0x0000000184D80440
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        GPUParticleSimulationPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3211, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3211, 0LL);
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
